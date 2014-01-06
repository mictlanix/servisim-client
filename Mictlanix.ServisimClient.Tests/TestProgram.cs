//
// TestProgram.cs
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
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Mictlanix.CFDv32;
using Mictlanix.Servisim.Client.Internals;

namespace Mictlanix.Servisim.Client.Tests {
	public class TestProgram {
		const string CSD_CERTIFICATE_FILE = "CSD01_AAA010101AAA.cer";
		const string CSD_PRIVATE_KEY_FILE = "CSD01_AAA010101AAA.key";
		const string CSD_PRIVATE_KEY_PWD = "12345678a";
		const string USERNAME = "1";
		const string PASSWORD = "atenea1307";
		const string TOKEN = "BPOUVO07x+Y+ey/W4bbWsLuxymn8icPrDk9rSPpzA3M=";

		static DateTime TEST_DATE = new DateTime (2014, 01, 06, 8, 9, 13, DateTimeKind.Unspecified);

		public TestProgram ()
		{
		}

		static void Main (string[] args)
		{
			StampTest (USERNAME, PASSWORD);
			// CancelTest (USERNAME, PASSWORD);
			// GetStampTest (USERNAME, PASSWORD);
			// AddIssuerTest (USERNAME, PASSWORD, TOKEN);
		}

		static void StampTest (string username, string password)
		{
			var cfd = CreateCFD ();
			var cli = new ServisimClient (username, password, ServisimClient.URL_TEST);

			AddItems (cfd, "Producto", 3);
			cfd.Sign (File.ReadAllBytes (CSD_PRIVATE_KEY_FILE), Encoding.UTF8.GetBytes (CSD_PRIVATE_KEY_PWD));

			var tfd = cli.Stamp ("WS01", cfd);
			Console.WriteLine (tfd.ToXmlString ());

			cfd.Complemento = new List<object>();
			cfd.Complemento.Add (tfd);

			Console.WriteLine (cfd.ToXmlString ());
			Console.WriteLine (cfd.ToString ());
		}

		static void CancelTest (string username, string password)
		{
			var cli = new ServisimClient (username, password, ServisimClient.URL_TEST);
			var ret = cli.Cancel ("AAA010101AAA", "9B5E9493-02FB-4CD0-8837-57FF286079B9");

			Console.WriteLine ("Cancel: {0}", ret);
		}

		static void GetStampTest (string username, string password)
		{
			var cli = new ServisimClient (username, password, ServisimClient.URL_TEST);
			var tfd = cli.GetStamp ("AAA010101AAA", "9B5E9493-02FB-4CD0-8837-57FF286079B9");

			Console.WriteLine (tfd.ToString ());
			Console.WriteLine (tfd.ToXmlString ());
		}

		static void AddIssuerTest (string username, string password, string token)
		{
			var cli = new ServisimAdminClient (username, password, ServisimAdminClient.URL_TEST, token);
			var ret = cli.AddIssuer ("AAA010101AAA", File.ReadAllBytes (CSD_CERTIFICATE_FILE),
				File.ReadAllBytes (CSD_PRIVATE_KEY_FILE), CSD_PRIVATE_KEY_PWD);

			Console.WriteLine ("AddIssuer: {0}", ret);
		}

		#region Helper Functions

		static Comprobante CreateCFD()
		{
			var cfd = new Comprobante {
				tipoDeComprobante = ComprobanteTipoDeComprobante.ingreso,
				serie = "A",
				folio = "1",
				fecha = TEST_DATE,
				LugarExpedicion = "México, DF",
				metodoDePago = "Efectivo",
				formaDePago = "PAGO EN UNA SOLA EXHIBICION",
				TipoCambio = (1m).ToString(),
				Moneda = "MXN",
				noCertificado = "20001000000200001428",
				certificado = Convert.ToBase64String (File.ReadAllBytes (CSD_CERTIFICATE_FILE)),
				Emisor = new ComprobanteEmisor {
					rfc = "AAA010101AAA",
					nombre = "ACCEM SERVICIOS EMPRESARIALES SC",
					RegimenFiscal = new ComprobanteEmisorRegimenFiscal[] {
						new ComprobanteEmisorRegimenFiscal {
							Regimen = "Régimen General de Ley Personas Morales"
						}
					},
				},
				Receptor = new ComprobanteReceptor {
					rfc = "XAXX010101000",
					nombre = "EMPRESA DEMO SC"
				},
				Impuestos = new ComprobanteImpuestos()
			};

			return cfd;
		}

		static void AddItem (Comprobante cfd, string code, string name, decimal qty, decimal amount)
		{
			int count = 1;

			if (cfd.Conceptos == null) {
				cfd.Conceptos = new ComprobanteConcepto [count];
			} else {
				count = cfd.Conceptos.Length + 1;
				var items = cfd.Conceptos;
				Array.Resize (ref items, count);
				cfd.Conceptos = items;
			}

			cfd.Conceptos[count-1] = new ComprobanteConcepto {
				cantidad = qty,
				unidad = "No Aplica",
				noIdentificacion = code,
				descripcion = name,
				valorUnitario = amount,
				importe = Math.Round(qty * amount, 2)
			};

			cfd.subTotal = cfd.Conceptos.Sum (x => x.importe);
			cfd.total = Math.Round (cfd.subTotal * 1.16m, 2);

			cfd.Impuestos.Traslados = new ComprobanteImpuestosTraslado[] {
				new ComprobanteImpuestosTraslado {
					impuesto = ComprobanteImpuestosTrasladoImpuesto.IVA,
					importe = cfd.total - cfd.subTotal,
					tasa = 16
				}
			};
		}

		static void AddItems (Comprobante cfd, string prefix, int count)
		{
			var sum = 0m;

			cfd.Conceptos = new ComprobanteConcepto[count];

			for(int i = 1; i <= count; i++) {
				cfd.Conceptos[i-1] = new ComprobanteConcepto {
					cantidad = i,
					unidad = "No Aplica",
					noIdentificacion = string.Format("P{0:D4}", i),
					descripcion = string.Format("{0} {1:D4}", prefix, i),
					valorUnitario = 5m * i,
					importe = 5m * i * i
				};
				sum += 5m * i * i;
			}

			cfd.subTotal = sum;
			cfd.total = Math.Round(sum * 1.16m, 2);

			cfd.Impuestos.Traslados = new ComprobanteImpuestosTraslado[] {
				new ComprobanteImpuestosTraslado {
					impuesto = ComprobanteImpuestosTrasladoImpuesto.IVA,
					importe = cfd.total - cfd.subTotal,
					tasa = 16
				}
			};
		}

		#endregion
	}
}

