//
// WsSecurity.cs
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
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Mictlanix.CFDv32;

namespace Mictlanix.Servisim.Client.Internals {
	[Serializable]
	[XmlType("Security", IncludeInSchema = false, Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
	[XmlRoot("Security", Namespace="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", IsNullable = true)]
	public class WsSecurity {
		XmlSerializerNamespaces xmlns;
		WsUsernameToken username_token;
		int must_understand;

		public WsSecurity ()
		{
			username_token = new WsUsernameToken ();
			must_understand = 1;
		}

		[XmlAttribute("mustUnderstand", Namespace="http://www.w3.org/2003/05/soap-envelope", Form = XmlSchemaForm.Qualified)]
		public int MustUnderstand {
			get {
				return must_understand;
			}
			set {
				must_understand = value;
			}
		}

		[XmlElement("UsernameToken", Form = XmlSchemaForm.Qualified)]
		public WsUsernameToken UsernameToken {
			get {
				return username_token;
			}
			set {
				username_token = value;
			}
		}

		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Xmlns {
			get {
				if (xmlns == null) {
					xmlns = new XmlSerializerNamespaces (new XmlQualifiedName[] {
						new XmlQualifiedName("soap", "http://www.w3.org/2003/05/soap-envelope"),
						new XmlQualifiedName("wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")
					});
				}

				return xmlns;
			}
			set { xmlns = value; }
		}

		public string ToXmlString()
		{
			using (var ms = ToXmlStream()) {
				return Encoding.UTF8.GetString (ms.ToArray ());
			}
		}

		public MemoryStream ToXmlStream()
		{
			return CFDLib.Utils.SerializeToXmlStream(this, Xmlns);
		}
	}
}

