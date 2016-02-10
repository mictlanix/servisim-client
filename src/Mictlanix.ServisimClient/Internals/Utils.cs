//
// Utils.cs
//
// Author:
//       Eddy Zavaleta <eddy@mictlanix.com>
//
// Copyright (c) 2016 Eddy Zavaleta, Mictlanix, and contributors.
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
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Mictlanix.Servisim.Client.Internals {
	internal static class Utils {
		public static MemoryStream SerializeToXmlStream<T>(T obj, XmlSerializerNamespaces xmlns)
		{
			var ms = new MemoryStream (4 * 1024);
			var xs = new XmlSerializerContract ().GetSerializer (typeof(T));

			using (var xml = new XmlTextWriter (ms, new UTF8Encoding (false))) {
				xs.Serialize (xml, obj, xmlns);
				ms.Seek (0, SeekOrigin.Begin);
			}

			return ms;
		}

		public static T DeserializeFromXmlStream<T>(Stream xml) where T : class
		{
			var xs = new XmlSerializerContract ().GetSerializer (typeof(T));
			object obj = xs.Deserialize (xml);
			return obj as T;
		}
	}
}

