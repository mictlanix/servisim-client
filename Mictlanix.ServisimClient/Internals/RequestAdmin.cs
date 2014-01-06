﻿//
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
	[XmlType("requestAdmin", Namespace = "http://controller.distribuidor.ws.servisim.com/")]
	public class RequestAdmin {
		string rfc;
		byte[] certificado;
		byte[] llave;
		string password;
		string token;

		public RequestAdmin ()
		{
		}

		[XmlElement("rfc", Form = XmlSchemaForm.Unqualified)]
		public string Rfc  {
			get {
				return rfc;
			}
			set {
				rfc = value;
			}
		}

		[XmlElement("certificado", DataType = "base64Binary", Form = XmlSchemaForm.Unqualified)]
		public byte[] Certificado  {
			get {
				return certificado;
			}
			set {
				certificado = value;
			}
		}

		[XmlElement("llave", DataType = "base64Binary", Form = XmlSchemaForm.Unqualified)]
		public byte[] Llave  {
			get {
				return llave;
			}
			set {
				llave = value;
			}
		}

		[XmlElement("password", Form = XmlSchemaForm.Unqualified)]
		public string Password  {
			get {
				return password;
			}
			set {
				password = value;
			}
		}

		[XmlElement("token", Form = XmlSchemaForm.Unqualified)]
		public string Token  {
			get {
				return token;
			}
			set {
				token = value;
			}
		}
	}
}
