//
// SoapFault.cs
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
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Mictlanix.CFDv32;

namespace Mictlanix.Servisim.Client.Internals
{
	[Serializable]
	[XmlType("Fault", Namespace="http://www.w3.org/2003/05/soap-envelope")]
	[XmlRoot("Fault", Namespace="http://www.w3.org/2003/05/soap-envelope", IsNullable=false)]
	internal partial class SoapFault
	{
		string code;
		string fault_string;
		SoapFaultDetail detail;

		[XmlElement("faultcode", Form = XmlSchemaForm.Unqualified)]
		public string FaultCode {
			get { return code; }
			set { code = value; }
		}

		[XmlElement("faultstring", Form = XmlSchemaForm.Unqualified)]
		public string FaultString {
			get { return fault_string; }
			set { fault_string = value; }
		}

		[XmlElement("detail", Form = XmlSchemaForm.Unqualified)]
		public SoapFaultDetail Detail {
			get { return detail; }
			set { detail = value; }
		}

		XmlSerializerNamespaces xmlns;

		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Xmlns {
			get {
				if (xmlns == null) {
					xmlns = new XmlSerializerNamespaces (new XmlQualifiedName[] {
						new XmlQualifiedName("soap", "http://www.w3.org/2003/05/soap-envelope")
					});
				}

				return xmlns;
			}
			set { xmlns = value; }
		}
	}

	[Serializable()]
	[XmlType()]
	internal partial class SoapFaultDetail
	{
		private object exceptionField;

		[XmlElement("FiscoClicException", Namespace="http://srv.soap.factura.sit.mx.com", Form = XmlSchemaForm.Qualified)]
		public object Exception {
			get {
				return this.exceptionField;
			}
			set {
				this.exceptionField = value;
			}
		}
	}
}
