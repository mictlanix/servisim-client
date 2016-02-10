//
// TimbrarCFDIResponse.cs
//
// Author:
//       Eddy Zavaleta <eddy@mictlanix.com>
//
// Copyright (c) 2014-2016 Eddy Zavaleta, Mictlanix, and contributors.
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
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Mictlanix.CFDv32;

namespace Mictlanix.Servisim.Client.Internals {
	[Serializable]
	[XmlType("cancelarCFDiResponse", Namespace = "http://controller.timbrado.ws.servisim.com/")]
	[XmlRoot("cancelarCFDiResponse", Namespace = "http://controller.timbrado.ws.servisim.com/", IsNullable = false)]
	internal partial class CancelarCFDIResponse {
		XmlSerializerNamespaces xmlns;
		ResponseServisim response;

		public CancelarCFDIResponse ()
		{
			response = new ResponseServisim ();
		}

		[XmlElement("ResponseServisim", Form = XmlSchemaForm.Unqualified)]
		public ResponseServisim Response {
			get {
				return response;
			}
			set {
				response = value;
			}
		}

		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Xmlns {
			get {
				if (xmlns == null) {
					xmlns = new XmlSerializerNamespaces (new XmlQualifiedName[] {
						new XmlQualifiedName("ns2", "http://controller.timbrado.ws.servisim.com/")
					});
				}
				
				return xmlns;
			}
			set { xmlns = value; }
		}
	}
}
