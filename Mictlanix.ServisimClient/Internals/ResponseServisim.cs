//
// RequestServisim.cs
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
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Mictlanix.Servisim.Client.Internals {
	[Serializable]
	[XmlType("responseServisim", Namespace = "http://controller.timbrado.ws.servisim.com/")]
	public class ResponseServisim {
		string uuid;
		string xml;
		string error;

		public ResponseServisim ()
		{
		}

		[XmlElement("uuid", Form = XmlSchemaForm.Unqualified)]
		public string Uuid  {
			get {
				return uuid;
			}
			set {
				uuid = value;
			}
		}

		[XmlIgnore]
		public DateTime? Date { get; set; }

		[XmlElement("fechaTimbre", IsNullable = true, Form = XmlSchemaForm.Unqualified)]
		public string DateString {
			get {
				return Date.HasValue ? XmlConvert.ToString (Date.Value, "yyyy-MM-ddTHH:mm:sszzzzzz") : null;
			}
			set {
				if (string.IsNullOrWhiteSpace (value)) {
					Date = null;
				} else {
					Date = XmlConvert.ToDateTime (value, XmlDateTimeSerializationMode.Unspecified);
				}
			}
		}

		[XmlElement("xml", Form = XmlSchemaForm.Unqualified)]
		public string Xml  {
			get {
				return xml;
			}
			set {
				xml = value;
			}
		}

		[XmlIgnore]
		public int? Code { get; set; }

		[XmlElement("idError", Form = XmlSchemaForm.Unqualified)]
		public string CodeString  {
			get {
				return Code.HasValue ? XmlConvert.ToString (Code.Value) : null;
			}
			set {
				if (string.IsNullOrWhiteSpace (value)) {
					Code = null;
				} else {
					Code = XmlConvert.ToInt32 (value);
				}
			}
		}

		[XmlElement("error", Form = XmlSchemaForm.Unqualified)]
		public string Error  {
			get {
				return error;
			}
			set {
				error = value;
			}
		}
	}
}

