//
// ServisimClient.cs
//
// Author:
//       Eddy Zavaleta <eddy@mictlanix.com>
//
// Copyright (c) 2014 Eddy Zavaleta, Mictlanix, and contributors.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using Mictlanix.Servisim.Client.Internals;
using Mictlanix.CFDv32;

namespace Mictlanix.Servisim.Client {
	public class ServisimClient {
		public static string URL_PRODUCTION = @"http://201.150.37.21/ServisimService/TimbradoCFDi";
		public static string URL_TEST       = @"http://201.150.37.20:8080/ServisimTest/TimbradoCFDi";

		public event EventHandler<RequestEventArgs> BeginRequest;
		public event EventHandler<RequestEventArgs> EndRequest;

		public ServisimClient (string username, string password, string url)
		{
			Username = username;
			Password = password;
			Url = url;

			ServicePointManager.ServerCertificateValidationCallback = 
				(object sp, X509Certificate c, X509Chain r, SslPolicyErrors e) => true;
		}

		public string Username { get; protected set; }
		public string Password { get; protected set; }
		public string Url { get; protected set; }

		public TimbreFiscalDigital Stamp (string id, Comprobante cfd)
		{
			return Stamp (id, cfd.ToXmlString ());
		}

		public TimbreFiscalDigital Stamp (string id, string xml)
		{
			TimbreFiscalDigital tfd = null;
			var env = CreateEnvelope (id, xml);
			string response = TryRequest (env);

			if (response.Length == 0) {
				throw new ServisimClientException ("Bad response format.");
			}

			var doc = SoapEnvelope.FromXml (response);

			if (doc.Body.Length == 0) {
				throw new ServisimClientException ("Bad response format.");
			}

			if (doc.Body[0] is SoapFault) {
				var fault = doc.Body[0] as SoapFault;
				throw new ServisimClientException (fault.FaultString);
			}

			if (!(doc.Body [0] is TimbrarCFDIResponse)) {
				throw new ServisimClientException ("Bad response format.");
			}

			var res = doc.Body [0] as TimbrarCFDIResponse;

			if (res.Response.Code != null) {
				throw new ServisimClientException (res.Response.Code.Value, res.Response.Error);
			}

			var comprobante = Comprobante.FromXml (res.Response.Xml);

			foreach (var item in comprobante.Complemento) {
				if (item is TimbreFiscalDigital) {
					tfd = item as TimbreFiscalDigital;
					break;
				}
			}

			if (tfd == null) {
				throw new ServisimClientException ("TimbreFiscalDigital not found.");
			}

			return new TimbreFiscalDigital {
				UUID = tfd.UUID,
				FechaTimbrado = tfd.FechaTimbrado,
				selloCFD = tfd.selloCFD,
				noCertificadoSAT = tfd.noCertificadoSAT,
				selloSAT = tfd.selloSAT
			};
		}

		public bool Cancel (string issuer, string uuid)
		{
			var env = CreateEnvelope2 (issuer, uuid);
			string response = TryRequest (env);

			if (response.Length == 0) {
				throw new ServisimClientException ("Bad response format.");
			}

			var doc = SoapEnvelope.FromXml (response);

			if (doc.Body.Length == 0) {
				throw new ServisimClientException ("Bad response format.");
			}

			if (doc.Body[0] is SoapFault) {
				var fault = doc.Body[0] as SoapFault;
				throw new ServisimClientException (fault.FaultString);
			}

			if (!(doc.Body [0] is CancelarCFDIResponse)) {
				throw new ServisimClientException ("Bad response format.");
			}

			var res = doc.Body [0] as CancelarCFDIResponse;

			if (res.Response.Code != null) {
				throw new ServisimClientException (res.Response.Code.Value, res.Response.Error);
			}

			return string.Compare (res.Response.Uuid, res.Response.Uuid, true) == 0;
		}

		public TimbreFiscalDigital GetStamp (string issuer, string uuid)
		{
			TimbreFiscalDigital tfd = null;
			var env = CreateEnvelope3 (issuer, uuid);
			string response = TryRequest (env);

			if (response.Length == 0) {
				throw new ServisimClientException ("Bad response format.");
			}

			var doc = SoapEnvelope.FromXml (response);

			if (doc.Body.Length == 0) {
				throw new ServisimClientException ("Bad response format.");
			}

			if (doc.Body[0] is SoapFault) {
				var fault = doc.Body[0] as SoapFault;
				throw new ServisimClientException (fault.FaultString);
			}

			if (!(doc.Body [0] is ObtenerCFDIResponse)) {
				throw new ServisimClientException ("Bad response format.");
			}

			var res = doc.Body [0] as ObtenerCFDIResponse;

			if (res.Response.Code != null) {
				throw new ServisimClientException (res.Response.Code.Value, res.Response.Error);
			}

			var cfd = Comprobante.FromXml (res.Response.Xml);

			foreach (var item in cfd.Complemento) {
				if (item is TimbreFiscalDigital) {
					tfd = item as TimbreFiscalDigital;
					break;
				}
			}

			if (tfd == null) {
				throw new ServisimClientException ("TimbreFiscalDigital not found.");
			}

			return new TimbreFiscalDigital {
				UUID = tfd.UUID,
				FechaTimbrado = tfd.FechaTimbrado,
				selloCFD = tfd.selloCFD,
				noCertificadoSAT = tfd.noCertificadoSAT,
				selloSAT = tfd.selloSAT
			};
		}

		SoapEnvelope CreateEnvelope (string id, string xml)
		{
			var request = new SoapEnvelope {
				Header = new WsSecurity[] {
					new WsSecurity {
						UsernameToken = new WsUsernameToken {
							Username = Username,
							Password = Password
						}
					}
				},
				Body = new TimbrarCFDI[] {
					new TimbrarCFDI {
						Request = new RequestServisim {
							Id = id,
							Xml = xml
						}
					}
				}
			};

			return request;
		}

		SoapEnvelope CreateEnvelope2 (string issuer, string uuid)
		{
			var request = new SoapEnvelope {
				Header = new WsSecurity[] {
					new WsSecurity {
						UsernameToken = new WsUsernameToken {
							Username = Username,
							Password = Password
						}
					}
				},
				Body = new CancelarCFDI[] {
					new CancelarCFDI {
						Request = new RequestServisim {
							Id = issuer,
							Xml = uuid
						}
					}
				}
			};

			return request;
		}

		SoapEnvelope CreateEnvelope3 (string issuer, string uuid)
		{
			var request = new SoapEnvelope {
				Header = new WsSecurity[] {
					new WsSecurity {
						UsernameToken = new WsUsernameToken {
							Username = Username,
							Password = Password
						}
					}
				},
				Body = new ObtenerCFDI[] {
					new ObtenerCFDI {
						Request = new RequestServisim {
							Id = issuer,
							Xml = uuid
						}
					}
				}
			};

			return request;
		}

		string TryRequest (SoapEnvelope env)
		{
			var bytes = env.ToXmlBytes ();
			string request = env.ToXmlString ();
			string response = null;
			bool is_empty = true;

#if DEBUG
			System.Diagnostics.Debug.WriteLine (request);
#endif
			OnBeginRequest (new RequestEventArgs (Url, request));

			try {
				response = DoPostRequest (Url, bytes);
				is_empty = false;
			} catch (WebException ex) {
				var hwr = ex.Response as HttpWebResponse;
#if DEBUG
				System.Diagnostics.Debug.WriteLine (ex);
#endif
				if (hwr != null) {
					using (var sr = new StreamReader (hwr.GetResponseStream ())) {
						response = sr.ReadToEnd ();
					}

					is_empty = (hwr.StatusCode != HttpStatusCode.InternalServerError);
				}
			}

#if DEBUG
			System.Diagnostics.Debug.WriteLine (response);
#endif
			OnEndRequest (new RequestEventArgs (Url, request, response));

			return is_empty ? string.Empty : response;
		}

		string DoPostRequest (string url, byte[] data)
		{
			var req = (HttpWebRequest)WebRequest.Create(url);
			req.ContentType = "text/xml; charset=utf-8";
			req.Method = "POST";
			req.ContentLength = data.Length;

			using (var stream = req.GetRequestStream ()) {
				stream.Write (data, 0, data.Length);
			}

			using(var resp = req.GetResponse ()) {
				using(var stream = resp.GetResponseStream ()) {
					using(var sr = new StreamReader (stream, Encoding.UTF8)) {
						return sr.ReadToEnd ();
					}
				}
			}
		}

		protected virtual void OnBeginRequest (RequestEventArgs e)
		{
			if (BeginRequest != null) {
				BeginRequest (this, e);
			}
		}

		protected virtual void OnEndRequest (RequestEventArgs e)
		{
			if (EndRequest != null) {
				EndRequest (this, e);
			}
		}
	}
}

