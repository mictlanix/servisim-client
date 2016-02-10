namespace Mictlanix.Servisim.Client.Internals {
	internal class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter
	{

		public void Write22_Envelope (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteEmptyTag (@"Envelope", @"http://www.w3.org/2003/05/soap-envelope");
				return;
			}
			TopLevelElement ();
			Write19_SoapEnvelope (@"Envelope", @"http://www.w3.org/2003/05/soap-envelope", ((global::Mictlanix.Servisim.Client.Internals.SoapEnvelope)o), false, false);
		}

		public void Write23_Fault (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteEmptyTag (@"Fault", @"http://www.w3.org/2003/05/soap-envelope");
				return;
			}
			TopLevelElement ();
			Write18_SoapFault (@"Fault", @"http://www.w3.org/2003/05/soap-envelope", ((global::Mictlanix.Servisim.Client.Internals.SoapFault)o), false, false);
		}

		public void Write24_SoapFaultDetail (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"SoapFaultDetail", @"");
				return;
			}
			TopLevelElement ();
			Write20_SoapFaultDetail (@"SoapFaultDetail", @"", ((global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail)o), true, false);
		}

		public void Write25_timbrarCFDi (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"timbrarCFDi", @"http://controller.timbrado.ws.servisim.com/");
				return;
			}
			TopLevelElement ();
			Write6_TimbrarCFDI (@"timbrarCFDi", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI)o), true, false);
		}

		public void Write26_requestServisim (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"requestServisim", @"");
				return;
			}
			TopLevelElement ();
			Write5_RequestServisim (@"requestServisim", @"", ((global::Mictlanix.Servisim.Client.Internals.RequestServisim)o), true, false);
		}

		public void Write27_Security (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"Security", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
				return;
			}
			TopLevelElement ();
			Write4_WsSecurity (@"Security", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", ((global::Mictlanix.Servisim.Client.Internals.WsSecurity)o), true, false);
		}

		public void Write28_UsernameToken (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"UsernameToken", @"");
				return;
			}
			TopLevelElement ();
			Write3_WsUsernameToken (@"UsernameToken", @"", ((global::Mictlanix.Servisim.Client.Internals.WsUsernameToken)o), true, false);
		}

		public void Write29_WsPasswordText (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"WsPasswordText", @"");
				return;
			}
			TopLevelElement ();
			Write21_WsPasswordText (@"WsPasswordText", @"", ((global::Mictlanix.Servisim.Client.Internals.WsPasswordText)o), true, false);
		}

		public void Write30_timbrarCFDiResponse (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"timbrarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/");
				return;
			}
			TopLevelElement ();
			Write8_TimbrarCFDIResponse (@"timbrarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse)o), true, false);
		}

		public void Write31_responseServisim (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"responseServisim", @"");
				return;
			}
			TopLevelElement ();
			Write7_ResponseServisim (@"responseServisim", @"", ((global::Mictlanix.Servisim.Client.Internals.ResponseServisim)o), true, false);
		}

		public void Write32_cancelarCFDi (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"cancelarCFDi", @"http://controller.timbrado.ws.servisim.com/");
				return;
			}
			TopLevelElement ();
			Write9_CancelarCFDI (@"cancelarCFDi", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.CancelarCFDI)o), true, false);
		}

		public void Write33_cancelarCFDiResponse (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"cancelarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/");
				return;
			}
			TopLevelElement ();
			Write10_CancelarCFDIResponse (@"cancelarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse)o), true, false);
		}

		public void Write34_obtenerCFDi (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"obtenerCFDi", @"http://controller.timbrado.ws.servisim.com/");
				return;
			}
			TopLevelElement ();
			Write11_ObtenerCFDI (@"obtenerCFDi", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI)o), true, false);
		}

		public void Write35_obtenerCFDiResponse (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"obtenerCFDiResponse", @"http://controller.timbrado.ws.servisim.com/");
				return;
			}
			TopLevelElement ();
			Write12_ObtenerCFDIResponse (@"obtenerCFDiResponse", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse)o), true, false);
		}

		public void Write36_registrarEmisor (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"registrarEmisor", @"http://controller.distribuidor.ws.servisim.com/");
				return;
			}
			TopLevelElement ();
			Write14_RegistrarEmisor (@"registrarEmisor", @"http://controller.distribuidor.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor)o), true, false);
		}

		public void Write37_registrarEmisorResponse (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"registrarEmisorResponse", @"http://controller.distribuidor.ws.servisim.com/");
				return;
			}
			TopLevelElement ();
			Write16_RegistrarEmisorResponse (@"registrarEmisorResponse", @"http://controller.distribuidor.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse)o), true, false);
		}

		public void Write38_requestAdmin (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"requestAdmin", @"");
				return;
			}
			TopLevelElement ();
			Write13_RequestAdmin (@"requestAdmin", @"", ((global::Mictlanix.Servisim.Client.Internals.RequestAdmin)o), true, false);
		}

		public void Write39_responseAdmin (object o)
		{
			WriteStartDocument ();
			if (o == null) {
				WriteNullTagLiteral (@"responseAdmin", @"");
				return;
			}
			TopLevelElement ();
			Write15_ResponseAdmin (@"responseAdmin", @"", ((global::Mictlanix.Servisim.Client.Internals.ResponseAdmin)o), true, false);
		}

		void Write15_ResponseAdmin (string n, string ns, global::Mictlanix.Servisim.Client.Internals.ResponseAdmin o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.ResponseAdmin)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, null);
			if (needType)
				WriteXsiType (@"responseAdmin", @"http://controller.distribuidor.ws.servisim.com/");
			WriteElementString (@"idError", @"", ((global::System.String)o.@CodeString));
			WriteElementString (@"resultado", @"", ((global::System.String)o.@Resultado));
			WriteEndElement (o);
		}

		void Write13_RequestAdmin (string n, string ns, global::Mictlanix.Servisim.Client.Internals.RequestAdmin o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.RequestAdmin)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, null);
			if (needType)
				WriteXsiType (@"requestAdmin", @"http://controller.distribuidor.ws.servisim.com/");
			WriteElementString (@"rfc", @"", ((global::System.String)o.@Rfc));
			WriteElementStringRaw (@"certificado", @"", FromByteArrayBase64 (((global::System.Byte[])o.@Certificado)));
			WriteElementStringRaw (@"llave", @"", FromByteArrayBase64 (((global::System.Byte[])o.@Llave)));
			WriteElementString (@"password", @"", ((global::System.String)o.@Password));
			WriteElementString (@"token", @"", ((global::System.String)o.@Token));
			WriteEndElement (o);
		}

		void Write16_RegistrarEmisorResponse (string n, string ns, global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"registrarEmisorResponse", @"http://controller.distribuidor.ws.servisim.com/");
			Write15_ResponseAdmin (@"ResponseAdmin", @"", ((global::Mictlanix.Servisim.Client.Internals.ResponseAdmin)o.@Response), false, false);
			WriteEndElement (o);
		}

		void Write14_RegistrarEmisor (string n, string ns, global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"registrarEmisor", @"http://controller.distribuidor.ws.servisim.com/");
			Write13_RequestAdmin (@"RequestAdmin", @"", ((global::Mictlanix.Servisim.Client.Internals.RequestAdmin)o.@Request), false, false);
			WriteEndElement (o);
		}

		void Write12_ObtenerCFDIResponse (string n, string ns, global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"obtenerCFDiResponse", @"http://controller.timbrado.ws.servisim.com/");
			Write7_ResponseServisim (@"ResponseServisim", @"", ((global::Mictlanix.Servisim.Client.Internals.ResponseServisim)o.@Response), false, false);
			WriteEndElement (o);
		}

		void Write7_ResponseServisim (string n, string ns, global::Mictlanix.Servisim.Client.Internals.ResponseServisim o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.ResponseServisim)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, null);
			if (needType)
				WriteXsiType (@"responseServisim", @"http://controller.timbrado.ws.servisim.com/");
			WriteElementString (@"uuid", @"", ((global::System.String)o.@Uuid));
			WriteNullableStringLiteral (@"fechaTimbre", @"", ((global::System.String)o.@DateString));
			WriteElementString (@"xml", @"", ((global::System.String)o.@Xml));
			WriteElementString (@"idError", @"", ((global::System.String)o.@CodeString));
			WriteElementString (@"error", @"", ((global::System.String)o.@Error));
			WriteEndElement (o);
		}

		void Write11_ObtenerCFDI (string n, string ns, global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"obtenerCFDi", @"http://controller.timbrado.ws.servisim.com/");
			Write5_RequestServisim (@"RequestServisim", @"", ((global::Mictlanix.Servisim.Client.Internals.RequestServisim)o.@Request), false, false);
			WriteEndElement (o);
		}

		void Write5_RequestServisim (string n, string ns, global::Mictlanix.Servisim.Client.Internals.RequestServisim o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.RequestServisim)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, null);
			if (needType)
				WriteXsiType (@"requestServisim", @"http://controller.timbrado.ws.servisim.com/");
			WriteElementString (@"id", @"", ((global::System.String)o.@Id));
			WriteElementString (@"xml", @"", ((global::System.String)o.@Xml));
			WriteEndElement (o);
		}

		void Write10_CancelarCFDIResponse (string n, string ns, global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"cancelarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/");
			Write7_ResponseServisim (@"ResponseServisim", @"", ((global::Mictlanix.Servisim.Client.Internals.ResponseServisim)o.@Response), false, false);
			WriteEndElement (o);
		}

		void Write9_CancelarCFDI (string n, string ns, global::Mictlanix.Servisim.Client.Internals.CancelarCFDI o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.CancelarCFDI)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"cancelarCFDi", @"http://controller.timbrado.ws.servisim.com/");
			Write5_RequestServisim (@"RequestServisim", @"", ((global::Mictlanix.Servisim.Client.Internals.RequestServisim)o.@Request), false, false);
			WriteEndElement (o);
		}

		void Write8_TimbrarCFDIResponse (string n, string ns, global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"timbrarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/");
			Write7_ResponseServisim (@"ResponseServisim", @"", ((global::Mictlanix.Servisim.Client.Internals.ResponseServisim)o.@Response), false, false);
			WriteEndElement (o);
		}

		void Write21_WsPasswordText (string n, string ns, global::Mictlanix.Servisim.Client.Internals.WsPasswordText o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.WsPasswordText)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, null);
			if (needType)
				WriteXsiType (@"WsPasswordText", @"");
			WriteAttribute (@"Type", @"", ((global::System.String)o.@Type));
			if ((object)(o.@Value) != null) {
				WriteValue (((global::System.String)o.@Value));
			}
			WriteEndElement (o);
		}

		void Write3_WsUsernameToken (string n, string ns, global::Mictlanix.Servisim.Client.Internals.WsUsernameToken o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.WsUsernameToken)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"UsernameToken", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
			WriteElementString (@"Username", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", ((global::System.String)o.@Username));
			Write2_WsPasswordText (@"Password", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", ((global::Mictlanix.Servisim.Client.Internals.WsPasswordText)o.@Password), false, false);
			WriteEndElement (o);
		}

		void Write2_WsPasswordText (string n, string ns, global::Mictlanix.Servisim.Client.Internals.WsPasswordText o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.WsPasswordText)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, null);
			if (needType)
				WriteXsiType (@"WsPasswordText", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
			WriteAttribute (@"Type", @"", ((global::System.String)o.@Type));
			if ((object)(o.@Value) != null) {
				WriteValue (((global::System.String)o.@Value));
			}
			WriteEndElement (o);
		}

		void Write4_WsSecurity (string n, string ns, global::Mictlanix.Servisim.Client.Internals.WsSecurity o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.WsSecurity)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"Security", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
			WriteAttribute (@"mustUnderstand", @"http://www.w3.org/2003/05/soap-envelope", System.Xml.XmlConvert.ToString ((global::System.Int32)((global::System.Int32)o.@MustUnderstand)));
			Write3_WsUsernameToken (@"UsernameToken", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", ((global::Mictlanix.Servisim.Client.Internals.WsUsernameToken)o.@UsernameToken), false, false);
			WriteEndElement (o);
		}

		void Write6_TimbrarCFDI (string n, string ns, global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"timbrarCFDi", @"http://controller.timbrado.ws.servisim.com/");
			Write5_RequestServisim (@"RequestServisim", @"", ((global::Mictlanix.Servisim.Client.Internals.RequestServisim)o.@Request), false, false);
			WriteEndElement (o);
		}

		void Write20_SoapFaultDetail (string n, string ns, global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, null);
			if (needType)
				WriteXsiType (@"SoapFaultDetail", @"");
			Write1_Object (@"FiscoClicException", @"http://srv.soap.factura.sit.mx.com", ((global::System.Object)o.@Exception), false, false);
			WriteEndElement (o);
		}

		void Write1_Object (string n, string ns, global::System.Object o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::System.Object)) {
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.WsPasswordText)) {
					Write21_WsPasswordText (n, ns, (global::Mictlanix.Servisim.Client.Internals.WsPasswordText)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail)) {
					Write20_SoapFaultDetail (n, ns, (global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.SoapEnvelope)) {
					Write19_SoapEnvelope (n, ns, (global::Mictlanix.Servisim.Client.Internals.SoapEnvelope)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFault)) {
					Write18_SoapFault (n, ns, (global::Mictlanix.Servisim.Client.Internals.SoapFault)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail)) {
					Write17_SoapFaultDetail (n, ns, (global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse)) {
					Write16_RegistrarEmisorResponse (n, ns, (global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.ResponseAdmin)) {
					Write15_ResponseAdmin (n, ns, (global::Mictlanix.Servisim.Client.Internals.ResponseAdmin)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor)) {
					Write14_RegistrarEmisor (n, ns, (global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.RequestAdmin)) {
					Write13_RequestAdmin (n, ns, (global::Mictlanix.Servisim.Client.Internals.RequestAdmin)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse)) {
					Write12_ObtenerCFDIResponse (n, ns, (global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI)) {
					Write11_ObtenerCFDI (n, ns, (global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse)) {
					Write10_CancelarCFDIResponse (n, ns, (global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.CancelarCFDI)) {
					Write9_CancelarCFDI (n, ns, (global::Mictlanix.Servisim.Client.Internals.CancelarCFDI)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse)) {
					Write8_TimbrarCFDIResponse (n, ns, (global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.ResponseServisim)) {
					Write7_ResponseServisim (n, ns, (global::Mictlanix.Servisim.Client.Internals.ResponseServisim)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI)) {
					Write6_TimbrarCFDI (n, ns, (global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.RequestServisim)) {
					Write5_RequestServisim (n, ns, (global::Mictlanix.Servisim.Client.Internals.RequestServisim)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.WsSecurity)) {
					Write4_WsSecurity (n, ns, (global::Mictlanix.Servisim.Client.Internals.WsSecurity)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.WsUsernameToken)) {
					Write3_WsUsernameToken (n, ns, (global::Mictlanix.Servisim.Client.Internals.WsUsernameToken)o, isNullable, true);
					return;
				} else if (t == typeof(global::Mictlanix.Servisim.Client.Internals.WsPasswordText)) {
					Write2_WsPasswordText (n, ns, (global::Mictlanix.Servisim.Client.Internals.WsPasswordText)o, isNullable, true);
					return;
				} else if (t == typeof(global::System.Object[])) {
					Writer.WriteStartElement (n, ns);
					WriteXsiType (@"ArrayOfSecurity", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
					{
						global::System.Object[] a = (global::System.Object[])o;
						if (a != null) {
							for (int ia = 0; ia < a.Length; ia++) {
								Write4_WsSecurity (@"Security", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", ((global::Mictlanix.Servisim.Client.Internals.WsSecurity)a [ia]), true, false);
							}
						}
					}
					Writer.WriteEndElement ();
					return;
				} else if (t == typeof(global::System.Object[])) {
					Writer.WriteStartElement (n, ns);
					WriteXsiType (@"ArrayOfChoice1", @"http://www.w3.org/2003/05/soap-envelope");
					{
						global::System.Object[] a = (global::System.Object[])o;
						if (a != null) {
							for (int ia = 0; ia < a.Length; ia++) {
								global::System.Object ai = (global::System.Object)a [ia];
								if ((object)(ai) != null) {
									if (ai is global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI) {
										Write6_TimbrarCFDI (@"timbrarCFDi", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI)ai), true, false);
									} else if (ai is global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor) {
										Write14_RegistrarEmisor (@"registrarEmisor", @"http://controller.distribuidor.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor)ai), true, false);
									} else if (ai is global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse) {
										Write12_ObtenerCFDIResponse (@"obtenerCFDiResponse", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse)ai), true, false);
									} else if (ai is global::Mictlanix.Servisim.Client.Internals.CancelarCFDI) {
										Write9_CancelarCFDI (@"cancelarCFDi", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.CancelarCFDI)ai), true, false);
									} else if (ai is global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI) {
										Write11_ObtenerCFDI (@"obtenerCFDi", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI)ai), true, false);
									} else if (ai is global::Mictlanix.Servisim.Client.Internals.SoapFault) {
										Write18_SoapFault (@"Fault", @"http://www.w3.org/2003/05/soap-envelope", ((global::Mictlanix.Servisim.Client.Internals.SoapFault)ai), true, false);
									} else if (ai is global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse) {
										Write16_RegistrarEmisorResponse (@"registrarEmisorResponse", @"http://controller.distribuidor.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse)ai), true, false);
									} else if (ai is global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse) {
										Write8_TimbrarCFDIResponse (@"timbrarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse)ai), true, false);
									} else if (ai is global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse) {
										Write10_CancelarCFDIResponse (@"cancelarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse)ai), true, false);
									} else if ((object)(ai) != null) {
										throw CreateUnknownTypeException (ai);
									}
								}
							}
						}
					}
					Writer.WriteEndElement ();
					return;
				} else {
					WriteTypedPrimitive (n, ns, o, true);
					return;
				}
			}
			WriteStartElement (n, ns, o, false, null);
			WriteEndElement (o);
		}

		void Write18_SoapFault (string n, string ns, global::Mictlanix.Servisim.Client.Internals.SoapFault o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFault)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"Fault", @"http://www.w3.org/2003/05/soap-envelope");
			WriteElementString (@"faultcode", @"", ((global::System.String)o.@FaultCode));
			WriteElementString (@"faultstring", @"", ((global::System.String)o.@FaultString));
			Write17_SoapFaultDetail (@"detail", @"", ((global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail)o.@Detail), false, false);
			WriteEndElement (o);
		}

		void Write17_SoapFaultDetail (string n, string ns, global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, null);
			if (needType)
				WriteXsiType (@"SoapFaultDetail", @"http://www.w3.org/2003/05/soap-envelope");
			Write1_Object (@"FiscoClicException", @"http://srv.soap.factura.sit.mx.com", ((global::System.Object)o.@Exception), false, false);
			WriteEndElement (o);
		}

		void Write19_SoapEnvelope (string n, string ns, global::Mictlanix.Servisim.Client.Internals.SoapEnvelope o, bool isNullable, bool needType)
		{
			if ((object)o == null) {
				if (isNullable)
					WriteNullTagLiteral (n, ns);
				return;
			}
			if (!needType) {
				System.Type t = o.GetType ();
				if (t == typeof(global::Mictlanix.Servisim.Client.Internals.SoapEnvelope)) {
				} else {
					throw CreateUnknownTypeException (o);
				}
			}
			WriteStartElement (n, ns, o, false, o.@Xmlns);
			if (needType)
				WriteXsiType (@"Envelope", @"http://www.w3.org/2003/05/soap-envelope");
			{
				global::System.Object[] a = (global::System.Object[])((global::System.Object[])o.@Header);
				if (a != null) {
					WriteStartElement (@"Header", @"http://www.w3.org/2003/05/soap-envelope", null, false);
					for (int ia = 0; ia < a.Length; ia++) {
						Write4_WsSecurity (@"Security", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", ((global::Mictlanix.Servisim.Client.Internals.WsSecurity)a [ia]), true, false);
					}
					WriteEndElement ();
				}
			}
			{
				global::System.Object[] a = (global::System.Object[])((global::System.Object[])o.@Body);
				if (a != null) {
					WriteStartElement (@"Body", @"http://www.w3.org/2003/05/soap-envelope", null, false);
					for (int ia = 0; ia < a.Length; ia++) {
						global::System.Object ai = (global::System.Object)a [ia];
						if ((object)(ai) != null) {
							if (ai is global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI) {
								Write6_TimbrarCFDI (@"timbrarCFDi", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI)ai), true, false);
							} else if (ai is global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor) {
								Write14_RegistrarEmisor (@"registrarEmisor", @"http://controller.distribuidor.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor)ai), true, false);
							} else if (ai is global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse) {
								Write12_ObtenerCFDIResponse (@"obtenerCFDiResponse", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse)ai), true, false);
							} else if (ai is global::Mictlanix.Servisim.Client.Internals.CancelarCFDI) {
								Write9_CancelarCFDI (@"cancelarCFDi", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.CancelarCFDI)ai), true, false);
							} else if (ai is global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI) {
								Write11_ObtenerCFDI (@"obtenerCFDi", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI)ai), true, false);
							} else if (ai is global::Mictlanix.Servisim.Client.Internals.SoapFault) {
								Write18_SoapFault (@"Fault", @"http://www.w3.org/2003/05/soap-envelope", ((global::Mictlanix.Servisim.Client.Internals.SoapFault)ai), true, false);
							} else if (ai is global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse) {
								Write16_RegistrarEmisorResponse (@"registrarEmisorResponse", @"http://controller.distribuidor.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse)ai), true, false);
							} else if (ai is global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse) {
								Write8_TimbrarCFDIResponse (@"timbrarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse)ai), true, false);
							} else if (ai is global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse) {
								Write10_CancelarCFDIResponse (@"cancelarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/", ((global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse)ai), true, false);
							} else if ((object)(ai) != null) {
								throw CreateUnknownTypeException (ai);
							}
						}
					}
					WriteEndElement ();
				}
			}
			WriteEndElement (o);
		}

		protected override void InitCallbacks ()
		{
		}
	}

	internal class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader
	{

		public object Read22_Envelope ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id1_Envelope && (object)Reader.NamespaceURI == (object)id2_Item)) {
					o = Read19_SoapEnvelope (false, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://www.w3.org/2003/05/soap-envelope:Envelope");
			}
			return (object)o;
		}

		public object Read23_Fault ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id3_Fault && (object)Reader.NamespaceURI == (object)id2_Item)) {
					o = Read18_SoapFault (false, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://www.w3.org/2003/05/soap-envelope:Fault");
			}
			return (object)o;
		}

		public object Read24_SoapFaultDetail ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id4_SoapFaultDetail && (object)Reader.NamespaceURI == (object)id5_Item)) {
					o = Read20_SoapFaultDetail (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @":SoapFaultDetail");
			}
			return (object)o;
		}

		public object Read25_timbrarCFDi ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id6_timbrarCFDi && (object)Reader.NamespaceURI == (object)id7_Item)) {
					o = Read6_TimbrarCFDI (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:timbrarCFDi");
			}
			return (object)o;
		}

		public object Read26_requestServisim ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id8_requestServisim && (object)Reader.NamespaceURI == (object)id5_Item)) {
					o = Read5_RequestServisim (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @":requestServisim");
			}
			return (object)o;
		}

		public object Read27_Security ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id9_Security && (object)Reader.NamespaceURI == (object)id10_Item)) {
					o = Read4_WsSecurity (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Security");
			}
			return (object)o;
		}

		public object Read28_UsernameToken ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id11_UsernameToken && (object)Reader.NamespaceURI == (object)id5_Item)) {
					o = Read3_WsUsernameToken (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @":UsernameToken");
			}
			return (object)o;
		}

		public object Read29_WsPasswordText ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id12_WsPasswordText && (object)Reader.NamespaceURI == (object)id5_Item)) {
					o = Read21_WsPasswordText (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @":WsPasswordText");
			}
			return (object)o;
		}

		public object Read30_timbrarCFDiResponse ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id13_timbrarCFDiResponse && (object)Reader.NamespaceURI == (object)id7_Item)) {
					o = Read8_TimbrarCFDIResponse (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:timbrarCFDiResponse");
			}
			return (object)o;
		}

		public object Read31_responseServisim ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id14_responseServisim && (object)Reader.NamespaceURI == (object)id5_Item)) {
					o = Read7_ResponseServisim (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @":responseServisim");
			}
			return (object)o;
		}

		public object Read32_cancelarCFDi ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id15_cancelarCFDi && (object)Reader.NamespaceURI == (object)id7_Item)) {
					o = Read9_CancelarCFDI (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:cancelarCFDi");
			}
			return (object)o;
		}

		public object Read33_cancelarCFDiResponse ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id16_cancelarCFDiResponse && (object)Reader.NamespaceURI == (object)id7_Item)) {
					o = Read10_CancelarCFDIResponse (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:cancelarCFDiResponse");
			}
			return (object)o;
		}

		public object Read34_obtenerCFDi ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id17_obtenerCFDi && (object)Reader.NamespaceURI == (object)id7_Item)) {
					o = Read11_ObtenerCFDI (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:obtenerCFDi");
			}
			return (object)o;
		}

		public object Read35_obtenerCFDiResponse ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id18_obtenerCFDiResponse && (object)Reader.NamespaceURI == (object)id7_Item)) {
					o = Read12_ObtenerCFDIResponse (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:obtenerCFDiResponse");
			}
			return (object)o;
		}

		public object Read36_registrarEmisor ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id19_registrarEmisor && (object)Reader.NamespaceURI == (object)id20_Item)) {
					o = Read14_RegistrarEmisor (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://controller.distribuidor.ws.servisim.com/:registrarEmisor");
			}
			return (object)o;
		}

		public object Read37_registrarEmisorResponse ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id21_registrarEmisorResponse && (object)Reader.NamespaceURI == (object)id20_Item)) {
					o = Read16_RegistrarEmisorResponse (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @"http://controller.distribuidor.ws.servisim.com/:registrarEmisorResponse");
			}
			return (object)o;
		}

		public object Read38_requestAdmin ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id22_requestAdmin && (object)Reader.NamespaceURI == (object)id5_Item)) {
					o = Read13_RequestAdmin (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @":requestAdmin");
			}
			return (object)o;
		}

		public object Read39_responseAdmin ()
		{
			object o = null;
			Reader.MoveToContent ();
			if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
				if (((object)Reader.LocalName == (object)id23_responseAdmin && (object)Reader.NamespaceURI == (object)id5_Item)) {
					o = Read15_ResponseAdmin (true, true);
				} else {
					throw CreateUnknownNodeException ();
				}
			} else {
				UnknownNode (null, @":responseAdmin");
			}
			return (object)o;
		}

		global::Mictlanix.Servisim.Client.Internals.ResponseAdmin Read15_ResponseAdmin (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_responseAdmin && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id20_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.ResponseAdmin o;
			o = new global::Mictlanix.Servisim.Client.Internals.ResponseAdmin ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (!IsXmlnsAttribute (Reader.Name)) {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations0 = 0;
			int readerCount0 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id24_idError && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@CodeString = Reader.ReadElementString ();
						}
						paramsRead [0] = true;
					} else if (!paramsRead [1] && ((object)Reader.LocalName == (object)id25_resultado && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Resultado = Reader.ReadElementString ();
						}
						paramsRead [1] = true;
					} else {
						UnknownNode ((object)o, @":idError, :resultado");
					}
				} else {
					UnknownNode ((object)o, @":idError, :resultado");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations0, ref readerCount0);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.RequestAdmin Read13_RequestAdmin (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_requestAdmin && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id20_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.RequestAdmin o;
			o = new global::Mictlanix.Servisim.Client.Internals.RequestAdmin ();
			bool[] paramsRead = new bool[5];
			while (Reader.MoveToNextAttribute ()) {
				if (!IsXmlnsAttribute (Reader.Name)) {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations1 = 0;
			int readerCount1 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id26_rfc && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Rfc = Reader.ReadElementString ();
						}
						paramsRead [0] = true;
					} else if (!paramsRead [1] && ((object)Reader.LocalName == (object)id27_certificado && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Certificado = ToByteArrayBase64 (false);
						}
						paramsRead [1] = true;
					} else if (!paramsRead [2] && ((object)Reader.LocalName == (object)id28_llave && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Llave = ToByteArrayBase64 (false);
						}
						paramsRead [2] = true;
					} else if (!paramsRead [3] && ((object)Reader.LocalName == (object)id29_password && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Password = Reader.ReadElementString ();
						}
						paramsRead [3] = true;
					} else if (!paramsRead [4] && ((object)Reader.LocalName == (object)id30_token && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Token = Reader.ReadElementString ();
						}
						paramsRead [4] = true;
					} else {
						UnknownNode ((object)o, @":rfc, :certificado, :llave, :password, :token");
					}
				} else {
					UnknownNode ((object)o, @":rfc, :certificado, :llave, :password, :token");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations1, ref readerCount1);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse Read16_RegistrarEmisorResponse (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_registrarEmisorResponse && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id20_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse o;
			o = new global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations2 = 0;
			int readerCount2 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id31_ResponseAdmin && (object)Reader.NamespaceURI == (object)id5_Item)) {
						o.@Response = Read15_ResponseAdmin (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @":ResponseAdmin");
					}
				} else {
					UnknownNode ((object)o, @":ResponseAdmin");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations2, ref readerCount2);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor Read14_RegistrarEmisor (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_registrarEmisor && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id20_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor o;
			o = new global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations3 = 0;
			int readerCount3 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id32_RequestAdmin && (object)Reader.NamespaceURI == (object)id5_Item)) {
						o.@Request = Read13_RequestAdmin (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @":RequestAdmin");
					}
				} else {
					UnknownNode ((object)o, @":RequestAdmin");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations3, ref readerCount3);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse Read12_ObtenerCFDIResponse (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_obtenerCFDiResponse && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse o;
			o = new global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations4 = 0;
			int readerCount4 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id33_ResponseServisim && (object)Reader.NamespaceURI == (object)id5_Item)) {
						o.@Response = Read7_ResponseServisim (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @":ResponseServisim");
					}
				} else {
					UnknownNode ((object)o, @":ResponseServisim");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations4, ref readerCount4);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.ResponseServisim Read7_ResponseServisim (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_responseServisim && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.ResponseServisim o;
			o = new global::Mictlanix.Servisim.Client.Internals.ResponseServisim ();
			bool[] paramsRead = new bool[5];
			while (Reader.MoveToNextAttribute ()) {
				if (!IsXmlnsAttribute (Reader.Name)) {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations5 = 0;
			int readerCount5 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id34_uuid && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Uuid = Reader.ReadElementString ();
						}
						paramsRead [0] = true;
					} else if (!paramsRead [1] && ((object)Reader.LocalName == (object)id35_fechaTimbre && (object)Reader.NamespaceURI == (object)id5_Item)) {
						if (ReadNull ()) {
							o.@DateString = null;
						} else {
							o.@DateString = Reader.ReadElementString ();
						}
						paramsRead [1] = true;
					} else if (!paramsRead [2] && ((object)Reader.LocalName == (object)id36_xml && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Xml = Reader.ReadElementString ();
						}
						paramsRead [2] = true;
					} else if (!paramsRead [3] && ((object)Reader.LocalName == (object)id24_idError && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@CodeString = Reader.ReadElementString ();
						}
						paramsRead [3] = true;
					} else if (!paramsRead [4] && ((object)Reader.LocalName == (object)id37_error && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Error = Reader.ReadElementString ();
						}
						paramsRead [4] = true;
					} else {
						UnknownNode ((object)o, @":uuid, :fechaTimbre, :xml, :idError, :error");
					}
				} else {
					UnknownNode ((object)o, @":uuid, :fechaTimbre, :xml, :idError, :error");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations5, ref readerCount5);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI Read11_ObtenerCFDI (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_obtenerCFDi && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI o;
			o = new global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations6 = 0;
			int readerCount6 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id38_RequestServisim && (object)Reader.NamespaceURI == (object)id5_Item)) {
						o.@Request = Read5_RequestServisim (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @":RequestServisim");
					}
				} else {
					UnknownNode ((object)o, @":RequestServisim");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations6, ref readerCount6);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.RequestServisim Read5_RequestServisim (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_requestServisim && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.RequestServisim o;
			o = new global::Mictlanix.Servisim.Client.Internals.RequestServisim ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (!IsXmlnsAttribute (Reader.Name)) {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations7 = 0;
			int readerCount7 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id39_id && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Id = Reader.ReadElementString ();
						}
						paramsRead [0] = true;
					} else if (!paramsRead [1] && ((object)Reader.LocalName == (object)id36_xml && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@Xml = Reader.ReadElementString ();
						}
						paramsRead [1] = true;
					} else {
						UnknownNode ((object)o, @":id, :xml");
					}
				} else {
					UnknownNode ((object)o, @":id, :xml");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations7, ref readerCount7);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse Read10_CancelarCFDIResponse (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_cancelarCFDiResponse && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse o;
			o = new global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations8 = 0;
			int readerCount8 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id33_ResponseServisim && (object)Reader.NamespaceURI == (object)id5_Item)) {
						o.@Response = Read7_ResponseServisim (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @":ResponseServisim");
					}
				} else {
					UnknownNode ((object)o, @":ResponseServisim");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations8, ref readerCount8);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.CancelarCFDI Read9_CancelarCFDI (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_cancelarCFDi && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.CancelarCFDI o;
			o = new global::Mictlanix.Servisim.Client.Internals.CancelarCFDI ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations9 = 0;
			int readerCount9 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id38_RequestServisim && (object)Reader.NamespaceURI == (object)id5_Item)) {
						o.@Request = Read5_RequestServisim (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @":RequestServisim");
					}
				} else {
					UnknownNode ((object)o, @":RequestServisim");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations9, ref readerCount9);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse Read8_TimbrarCFDIResponse (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_timbrarCFDiResponse && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse o;
			o = new global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations10 = 0;
			int readerCount10 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id33_ResponseServisim && (object)Reader.NamespaceURI == (object)id5_Item)) {
						o.@Response = Read7_ResponseServisim (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @":ResponseServisim");
					}
				} else {
					UnknownNode ((object)o, @":ResponseServisim");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations10, ref readerCount10);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.WsPasswordText Read21_WsPasswordText (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_WsPasswordText && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id5_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.WsPasswordText o;
			o = new global::Mictlanix.Servisim.Client.Internals.WsPasswordText ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (!paramsRead [0] && ((object)Reader.LocalName == (object)id40_Type && (object)Reader.NamespaceURI == (object)id5_Item)) {
					o.@Type = Reader.Value;
					paramsRead [0] = true;
				} else if (!IsXmlnsAttribute (Reader.Name)) {
					UnknownNode ((object)o, @":Type");
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations11 = 0;
			int readerCount11 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				string tmp = null;
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					UnknownNode ((object)o, @"");
				} else if (Reader.NodeType == System.Xml.XmlNodeType.Text ||
				                     Reader.NodeType == System.Xml.XmlNodeType.CDATA ||
				                     Reader.NodeType == System.Xml.XmlNodeType.Whitespace ||
				                     Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
					tmp = ReadString (tmp, false);
					o.@Value = tmp;
				} else {
					UnknownNode ((object)o, @"");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations11, ref readerCount11);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.WsUsernameToken Read3_WsUsernameToken (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_UsernameToken && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id10_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.WsUsernameToken o;
			o = new global::Mictlanix.Servisim.Client.Internals.WsUsernameToken ();
			bool[] paramsRead = new bool[3];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations12 = 0;
			int readerCount12 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id41_Username && (object)Reader.NamespaceURI == (object)id10_Item)) {
						{
							o.@Username = Reader.ReadElementString ();
						}
						paramsRead [0] = true;
					} else if (!paramsRead [1] && ((object)Reader.LocalName == (object)id42_Password && (object)Reader.NamespaceURI == (object)id10_Item)) {
						o.@Password = Read2_WsPasswordText (false, true);
						paramsRead [1] = true;
					} else {
						UnknownNode ((object)o, @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Username, http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Password");
					}
				} else {
					UnknownNode ((object)o, @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Username, http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Password");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations12, ref readerCount12);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.WsPasswordText Read2_WsPasswordText (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_WsPasswordText && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id10_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.WsPasswordText o;
			o = new global::Mictlanix.Servisim.Client.Internals.WsPasswordText ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (!paramsRead [0] && ((object)Reader.LocalName == (object)id40_Type && (object)Reader.NamespaceURI == (object)id5_Item)) {
					o.@Type = Reader.Value;
					paramsRead [0] = true;
				} else if (!IsXmlnsAttribute (Reader.Name)) {
					UnknownNode ((object)o, @":Type");
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations13 = 0;
			int readerCount13 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				string tmp = null;
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					UnknownNode ((object)o, @"");
				} else if (Reader.NodeType == System.Xml.XmlNodeType.Text ||
				                     Reader.NodeType == System.Xml.XmlNodeType.CDATA ||
				                     Reader.NodeType == System.Xml.XmlNodeType.Whitespace ||
				                     Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
					tmp = ReadString (tmp, false);
					o.@Value = tmp;
				} else {
					UnknownNode ((object)o, @"");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations13, ref readerCount13);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.WsSecurity Read4_WsSecurity (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_Security && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id10_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.WsSecurity o;
			o = new global::Mictlanix.Servisim.Client.Internals.WsSecurity ();
			bool[] paramsRead = new bool[3];
			while (Reader.MoveToNextAttribute ()) {
				if (!paramsRead [0] && ((object)Reader.LocalName == (object)id43_mustUnderstand && (object)Reader.NamespaceURI == (object)id2_Item)) {
					o.@MustUnderstand = System.Xml.XmlConvert.ToInt32 (Reader.Value);
					paramsRead [0] = true;
				} else if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o, @"http://www.w3.org/2003/05/soap-envelope:mustUnderstand");
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations14 = 0;
			int readerCount14 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [1] && ((object)Reader.LocalName == (object)id11_UsernameToken && (object)Reader.NamespaceURI == (object)id10_Item)) {
						o.@UsernameToken = Read3_WsUsernameToken (false, true);
						paramsRead [1] = true;
					} else {
						UnknownNode ((object)o, @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:UsernameToken");
					}
				} else {
					UnknownNode ((object)o, @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:UsernameToken");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations14, ref readerCount14);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI Read6_TimbrarCFDI (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_timbrarCFDi && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI o;
			o = new global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI ();
			bool[] paramsRead = new bool[2];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations15 = 0;
			int readerCount15 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id38_RequestServisim && (object)Reader.NamespaceURI == (object)id5_Item)) {
						o.@Request = Read5_RequestServisim (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @":RequestServisim");
					}
				} else {
					UnknownNode ((object)o, @":RequestServisim");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations15, ref readerCount15);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail Read20_SoapFaultDetail (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_SoapFaultDetail && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id5_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail o;
			o = new global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail ();
			bool[] paramsRead = new bool[1];
			while (Reader.MoveToNextAttribute ()) {
				if (!IsXmlnsAttribute (Reader.Name)) {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations16 = 0;
			int readerCount16 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id44_FiscoClicException && (object)Reader.NamespaceURI == (object)id45_Item)) {
						o.@Exception = Read1_Object (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @"http://srv.soap.factura.sit.mx.com:FiscoClicException");
					}
				} else {
					UnknownNode ((object)o, @"http://srv.soap.factura.sit.mx.com:FiscoClicException");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations16, ref readerCount16);
			}
			ReadEndElement ();
			return o;
		}

		global::System.Object Read1_Object (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (isNull) {
					if (xsiType != null)
						return (global::System.Object)ReadTypedNull (xsiType);
					else
						return null;
				}
				if (xsiType == null) {
					return ReadTypedPrimitive (new System.Xml.XmlQualifiedName ("anyType", "http://www.w3.org/2001/XMLSchema"));
				} else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_WsPasswordText && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id5_Item))
					return Read21_WsPasswordText (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_SoapFaultDetail && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id5_Item))
					return Read20_SoapFaultDetail (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_Envelope && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item))
					return Read19_SoapEnvelope (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_Fault && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item))
					return Read18_SoapFault (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_SoapFaultDetail && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item))
					return Read17_SoapFaultDetail (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_registrarEmisorResponse && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id20_Item))
					return Read16_RegistrarEmisorResponse (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_responseAdmin && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id20_Item))
					return Read15_ResponseAdmin (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_registrarEmisor && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id20_Item))
					return Read14_RegistrarEmisor (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_requestAdmin && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id20_Item))
					return Read13_RequestAdmin (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_obtenerCFDiResponse && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item))
					return Read12_ObtenerCFDIResponse (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_obtenerCFDi && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item))
					return Read11_ObtenerCFDI (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_cancelarCFDiResponse && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item))
					return Read10_CancelarCFDIResponse (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_cancelarCFDi && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item))
					return Read9_CancelarCFDI (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_timbrarCFDiResponse && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item))
					return Read8_TimbrarCFDIResponse (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_responseServisim && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item))
					return Read7_ResponseServisim (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_timbrarCFDi && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item))
					return Read6_TimbrarCFDI (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_requestServisim && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item))
					return Read5_RequestServisim (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_Security && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id10_Item))
					return Read4_WsSecurity (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_UsernameToken && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id10_Item))
					return Read3_WsUsernameToken (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_WsPasswordText && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id10_Item))
					return Read2_WsPasswordText (isNullable, false);
				else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_ArrayOfSecurity && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id10_Item)) {
					global::System.Object[] a = null;
					if (!ReadNull ()) {
						global::System.Object[] z_0_0 = null;
						int cz_0_0 = 0;
						if ((Reader.IsEmptyElement)) {
							Reader.Skip ();
						} else {
							Reader.ReadStartElement ();
							Reader.MoveToContent ();
							int whileIterations17 = 0;
							int readerCount17 = ReaderCount;
							while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
								if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
									if (((object)Reader.LocalName == (object)id9_Security && (object)Reader.NamespaceURI == (object)id10_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read4_WsSecurity (true, true);
									} else {
										UnknownNode (null, @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Security");
									}
								} else {
									UnknownNode (null, @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Security");
								}
								Reader.MoveToContent ();
								CheckReaderCount (ref whileIterations17, ref readerCount17);
							}
							ReadEndElement ();
						}
						a = (global::System.Object[])ShrinkArray (z_0_0, cz_0_0, typeof(global::System.Object), false);
					}
					return a;
				} else if (((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_ArrayOfChoice1 && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
					global::System.Object[] a = null;
					if (!ReadNull ()) {
						global::System.Object[] z_0_0 = null;
						int cz_0_0 = 0;
						if ((Reader.IsEmptyElement)) {
							Reader.Skip ();
						} else {
							Reader.ReadStartElement ();
							Reader.MoveToContent ();
							int whileIterations18 = 0;
							int readerCount18 = ReaderCount;
							while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
								if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
									if (((object)Reader.LocalName == (object)id6_timbrarCFDi && (object)Reader.NamespaceURI == (object)id7_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read6_TimbrarCFDI (true, true);
									} else if (((object)Reader.LocalName == (object)id13_timbrarCFDiResponse && (object)Reader.NamespaceURI == (object)id7_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read8_TimbrarCFDIResponse (true, true);
									} else if (((object)Reader.LocalName == (object)id21_registrarEmisorResponse && (object)Reader.NamespaceURI == (object)id20_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read16_RegistrarEmisorResponse (true, true);
									} else if (((object)Reader.LocalName == (object)id3_Fault && (object)Reader.NamespaceURI == (object)id2_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read18_SoapFault (true, true);
									} else if (((object)Reader.LocalName == (object)id17_obtenerCFDi && (object)Reader.NamespaceURI == (object)id7_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read11_ObtenerCFDI (true, true);
									} else if (((object)Reader.LocalName == (object)id15_cancelarCFDi && (object)Reader.NamespaceURI == (object)id7_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read9_CancelarCFDI (true, true);
									} else if (((object)Reader.LocalName == (object)id18_obtenerCFDiResponse && (object)Reader.NamespaceURI == (object)id7_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read12_ObtenerCFDIResponse (true, true);
									} else if (((object)Reader.LocalName == (object)id19_registrarEmisor && (object)Reader.NamespaceURI == (object)id20_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read14_RegistrarEmisor (true, true);
									} else if (((object)Reader.LocalName == (object)id16_cancelarCFDiResponse && (object)Reader.NamespaceURI == (object)id7_Item)) {
										z_0_0 = (global::System.Object[])EnsureArrayIndex (z_0_0, cz_0_0, typeof(global::System.Object));
										z_0_0 [cz_0_0++] = Read10_CancelarCFDIResponse (true, true);
									} else {
										UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:timbrarCFDi, http://controller.timbrado.ws.servisim.com/:timbrarCFDiResponse, http://controller.distribuidor.ws.servisim.com/:registrarEmisorResponse, http://www.w3.org/2003/05/soap-envelope:Fault, http://controller.timbrado.ws.servisim.com/:obtenerCFDi, http://controller.timbrado.ws.servisim.com/:cancelarCFDi, http://controller.timbrado.ws.servisim.com/:obtenerCFDiResponse, http://controller.distribuidor.ws.servisim.com/:registrarEmisor, http://controller.timbrado.ws.servisim.com/:cancelarCFDiResponse");
									}
								} else {
									UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:timbrarCFDi, http://controller.timbrado.ws.servisim.com/:timbrarCFDiResponse, http://controller.distribuidor.ws.servisim.com/:registrarEmisorResponse, http://www.w3.org/2003/05/soap-envelope:Fault, http://controller.timbrado.ws.servisim.com/:obtenerCFDi, http://controller.timbrado.ws.servisim.com/:cancelarCFDi, http://controller.timbrado.ws.servisim.com/:obtenerCFDiResponse, http://controller.distribuidor.ws.servisim.com/:registrarEmisor, http://controller.timbrado.ws.servisim.com/:cancelarCFDiResponse");
								}
								Reader.MoveToContent ();
								CheckReaderCount (ref whileIterations18, ref readerCount18);
							}
							ReadEndElement ();
						}
						a = (global::System.Object[])ShrinkArray (z_0_0, cz_0_0, typeof(global::System.Object), false);
					}
					return a;
				} else
					return ReadTypedPrimitive ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::System.Object o;
			o = new global::System.Object ();
//                bool[] paramsRead = new bool[0];
			while (Reader.MoveToNextAttribute ()) {
				if (!IsXmlnsAttribute (Reader.Name)) {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations19 = 0;
			int readerCount19 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					UnknownNode ((object)o, @"");
				} else {
					UnknownNode ((object)o, @"");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations19, ref readerCount19);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.SoapFault Read18_SoapFault (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_Fault && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.SoapFault o;
			o = new global::Mictlanix.Servisim.Client.Internals.SoapFault ();
			bool[] paramsRead = new bool[4];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations20 = 0;
			int readerCount20 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id48_faultcode && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@FaultCode = Reader.ReadElementString ();
						}
						paramsRead [0] = true;
					} else if (!paramsRead [1] && ((object)Reader.LocalName == (object)id49_faultstring && (object)Reader.NamespaceURI == (object)id5_Item)) {
						{
							o.@FaultString = Reader.ReadElementString ();
						}
						paramsRead [1] = true;
					} else if (!paramsRead [2] && ((object)Reader.LocalName == (object)id50_detail && (object)Reader.NamespaceURI == (object)id5_Item)) {
						o.@Detail = Read17_SoapFaultDetail (false, true);
						paramsRead [2] = true;
					} else {
						UnknownNode ((object)o, @":faultcode, :faultstring, :detail");
					}
				} else {
					UnknownNode ((object)o, @":faultcode, :faultstring, :detail");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations20, ref readerCount20);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail Read17_SoapFaultDetail (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_SoapFaultDetail && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail o;
			o = new global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail ();
			bool[] paramsRead = new bool[1];
			while (Reader.MoveToNextAttribute ()) {
				if (!IsXmlnsAttribute (Reader.Name)) {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations21 = 0;
			int readerCount21 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (!paramsRead [0] && ((object)Reader.LocalName == (object)id44_FiscoClicException && (object)Reader.NamespaceURI == (object)id45_Item)) {
						o.@Exception = Read1_Object (false, true);
						paramsRead [0] = true;
					} else {
						UnknownNode ((object)o, @"http://srv.soap.factura.sit.mx.com:FiscoClicException");
					}
				} else {
					UnknownNode ((object)o, @"http://srv.soap.factura.sit.mx.com:FiscoClicException");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations21, ref readerCount21);
			}
			ReadEndElement ();
			return o;
		}

		global::Mictlanix.Servisim.Client.Internals.SoapEnvelope Read19_SoapEnvelope (bool isNullable, bool checkType)
		{
			System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType () : null;
			bool isNull = false;
			if (isNullable)
				isNull = ReadNull ();
			if (checkType) {
				if (xsiType == null || ((object)((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_Envelope && (object)((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
				} else
					throw CreateUnknownTypeException ((System.Xml.XmlQualifiedName)xsiType);
			}
			if (isNull)
				return null;
			global::Mictlanix.Servisim.Client.Internals.SoapEnvelope o;
			o = new global::Mictlanix.Servisim.Client.Internals.SoapEnvelope ();
//                global::System.Object[] a_0 = null;
//                int ca_0 = 0;
//                global::System.Object[] a_1 = null;
//                int ca_1 = 0;
//                bool[] paramsRead = new bool[3];
			while (Reader.MoveToNextAttribute ()) {
				if (IsXmlnsAttribute (Reader.Name)) {
					if (o.@Xmlns == null)
						o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces ();
					((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add (Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
				} else {
					UnknownNode ((object)o);
				}
			}
			Reader.MoveToElement ();
			if (Reader.IsEmptyElement) {
				Reader.Skip ();
				return o;
			}
			Reader.ReadStartElement ();
			Reader.MoveToContent ();
			int whileIterations22 = 0;
			int readerCount22 = ReaderCount;
			while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
				if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
					if (((object)Reader.LocalName == (object)id51_Header && (object)Reader.NamespaceURI == (object)id2_Item)) {
						if (!ReadNull ()) {
							global::System.Object[] a_0_0 = null;
							int ca_0_0 = 0;
							if ((Reader.IsEmptyElement)) {
								Reader.Skip ();
							} else {
								Reader.ReadStartElement ();
								Reader.MoveToContent ();
								int whileIterations23 = 0;
								int readerCount23 = ReaderCount;
								while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
									if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
										if (((object)Reader.LocalName == (object)id9_Security && (object)Reader.NamespaceURI == (object)id10_Item)) {
											a_0_0 = (global::System.Object[])EnsureArrayIndex (a_0_0, ca_0_0, typeof(global::System.Object));
											a_0_0 [ca_0_0++] = Read4_WsSecurity (true, true);
										} else {
											UnknownNode (null, @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Security");
										}
									} else {
										UnknownNode (null, @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Security");
									}
									Reader.MoveToContent ();
									CheckReaderCount (ref whileIterations23, ref readerCount23);
								}
								ReadEndElement ();
							}
							o.@Header = (global::System.Object[])ShrinkArray (a_0_0, ca_0_0, typeof(global::System.Object), false);
						}
					} else if (((object)Reader.LocalName == (object)id52_Body && (object)Reader.NamespaceURI == (object)id2_Item)) {
						if (!ReadNull ()) {
							global::System.Object[] a_1_0 = null;
							int ca_1_0 = 0;
							if ((Reader.IsEmptyElement)) {
								Reader.Skip ();
							} else {
								Reader.ReadStartElement ();
								Reader.MoveToContent ();
								int whileIterations24 = 0;
								int readerCount24 = ReaderCount;
								while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
									if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
										if (((object)Reader.LocalName == (object)id6_timbrarCFDi && (object)Reader.NamespaceURI == (object)id7_Item)) {
											a_1_0 = (global::System.Object[])EnsureArrayIndex (a_1_0, ca_1_0, typeof(global::System.Object));
											a_1_0 [ca_1_0++] = Read6_TimbrarCFDI (true, true);
										} else if (((object)Reader.LocalName == (object)id13_timbrarCFDiResponse && (object)Reader.NamespaceURI == (object)id7_Item)) {
											a_1_0 = (global::System.Object[])EnsureArrayIndex (a_1_0, ca_1_0, typeof(global::System.Object));
											a_1_0 [ca_1_0++] = Read8_TimbrarCFDIResponse (true, true);
										} else if (((object)Reader.LocalName == (object)id21_registrarEmisorResponse && (object)Reader.NamespaceURI == (object)id20_Item)) {
											a_1_0 = (global::System.Object[])EnsureArrayIndex (a_1_0, ca_1_0, typeof(global::System.Object));
											a_1_0 [ca_1_0++] = Read16_RegistrarEmisorResponse (true, true);
										} else if (((object)Reader.LocalName == (object)id3_Fault && (object)Reader.NamespaceURI == (object)id2_Item)) {
											a_1_0 = (global::System.Object[])EnsureArrayIndex (a_1_0, ca_1_0, typeof(global::System.Object));
											a_1_0 [ca_1_0++] = Read18_SoapFault (true, true);
										} else if (((object)Reader.LocalName == (object)id17_obtenerCFDi && (object)Reader.NamespaceURI == (object)id7_Item)) {
											a_1_0 = (global::System.Object[])EnsureArrayIndex (a_1_0, ca_1_0, typeof(global::System.Object));
											a_1_0 [ca_1_0++] = Read11_ObtenerCFDI (true, true);
										} else if (((object)Reader.LocalName == (object)id15_cancelarCFDi && (object)Reader.NamespaceURI == (object)id7_Item)) {
											a_1_0 = (global::System.Object[])EnsureArrayIndex (a_1_0, ca_1_0, typeof(global::System.Object));
											a_1_0 [ca_1_0++] = Read9_CancelarCFDI (true, true);
										} else if (((object)Reader.LocalName == (object)id18_obtenerCFDiResponse && (object)Reader.NamespaceURI == (object)id7_Item)) {
											a_1_0 = (global::System.Object[])EnsureArrayIndex (a_1_0, ca_1_0, typeof(global::System.Object));
											a_1_0 [ca_1_0++] = Read12_ObtenerCFDIResponse (true, true);
										} else if (((object)Reader.LocalName == (object)id19_registrarEmisor && (object)Reader.NamespaceURI == (object)id20_Item)) {
											a_1_0 = (global::System.Object[])EnsureArrayIndex (a_1_0, ca_1_0, typeof(global::System.Object));
											a_1_0 [ca_1_0++] = Read14_RegistrarEmisor (true, true);
										} else if (((object)Reader.LocalName == (object)id16_cancelarCFDiResponse && (object)Reader.NamespaceURI == (object)id7_Item)) {
											a_1_0 = (global::System.Object[])EnsureArrayIndex (a_1_0, ca_1_0, typeof(global::System.Object));
											a_1_0 [ca_1_0++] = Read10_CancelarCFDIResponse (true, true);
										} else {
											UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:timbrarCFDi, http://controller.timbrado.ws.servisim.com/:timbrarCFDiResponse, http://controller.distribuidor.ws.servisim.com/:registrarEmisorResponse, http://www.w3.org/2003/05/soap-envelope:Fault, http://controller.timbrado.ws.servisim.com/:obtenerCFDi, http://controller.timbrado.ws.servisim.com/:cancelarCFDi, http://controller.timbrado.ws.servisim.com/:obtenerCFDiResponse, http://controller.distribuidor.ws.servisim.com/:registrarEmisor, http://controller.timbrado.ws.servisim.com/:cancelarCFDiResponse");
										}
									} else {
										UnknownNode (null, @"http://controller.timbrado.ws.servisim.com/:timbrarCFDi, http://controller.timbrado.ws.servisim.com/:timbrarCFDiResponse, http://controller.distribuidor.ws.servisim.com/:registrarEmisorResponse, http://www.w3.org/2003/05/soap-envelope:Fault, http://controller.timbrado.ws.servisim.com/:obtenerCFDi, http://controller.timbrado.ws.servisim.com/:cancelarCFDi, http://controller.timbrado.ws.servisim.com/:obtenerCFDiResponse, http://controller.distribuidor.ws.servisim.com/:registrarEmisor, http://controller.timbrado.ws.servisim.com/:cancelarCFDiResponse");
									}
									Reader.MoveToContent ();
									CheckReaderCount (ref whileIterations24, ref readerCount24);
								}
								ReadEndElement ();
							}
							o.@Body = (global::System.Object[])ShrinkArray (a_1_0, ca_1_0, typeof(global::System.Object), false);
						}
					} else {
						UnknownNode ((object)o, @"http://www.w3.org/2003/05/soap-envelope:Header, http://www.w3.org/2003/05/soap-envelope:Body");
					}
				} else {
					UnknownNode ((object)o, @"http://www.w3.org/2003/05/soap-envelope:Header, http://www.w3.org/2003/05/soap-envelope:Body");
				}
				Reader.MoveToContent ();
				CheckReaderCount (ref whileIterations22, ref readerCount22);
			}
			ReadEndElement ();
			return o;
		}

		protected override void InitCallbacks ()
		{
		}

		string id33_ResponseServisim;
		string id52_Body;
		string id6_timbrarCFDi;
		string id44_FiscoClicException;
		string id17_obtenerCFDi;
		string id19_registrarEmisor;
		string id51_Header;
		string id7_Item;
		string id31_ResponseAdmin;
		string id29_password;
		string id15_cancelarCFDi;
		string id39_id;
		string id24_idError;
		string id38_RequestServisim;
		string id22_requestAdmin;
		string id21_registrarEmisorResponse;
		string id11_UsernameToken;
		string id26_rfc;
		string id30_token;
		string id14_responseServisim;
		string id46_ArrayOfSecurity;
		string id45_Item;
		string id41_Username;
		string id20_Item;
		string id13_timbrarCFDiResponse;
		string id23_responseAdmin;
		string id4_SoapFaultDetail;
		string id8_requestServisim;
		string id9_Security;
		string id27_certificado;
		string id10_Item;
		string id12_WsPasswordText;
		string id43_mustUnderstand;
		string id25_resultado;
		string id42_Password;
		string id1_Envelope;
		string id32_RequestAdmin;
		string id36_xml;
		string id5_Item;
		string id16_cancelarCFDiResponse;
		string id2_Item;
		string id47_ArrayOfChoice1;
		string id34_uuid;
		string id3_Fault;
		string id40_Type;
		string id35_fechaTimbre;
		string id28_llave;
		string id48_faultcode;
		string id50_detail;
		string id49_faultstring;
		string id37_error;
		string id18_obtenerCFDiResponse;

		protected override void InitIDs ()
		{
			id33_ResponseServisim = Reader.NameTable.Add (@"ResponseServisim");
			id52_Body = Reader.NameTable.Add (@"Body");
			id6_timbrarCFDi = Reader.NameTable.Add (@"timbrarCFDi");
			id44_FiscoClicException = Reader.NameTable.Add (@"FiscoClicException");
			id17_obtenerCFDi = Reader.NameTable.Add (@"obtenerCFDi");
			id19_registrarEmisor = Reader.NameTable.Add (@"registrarEmisor");
			id51_Header = Reader.NameTable.Add (@"Header");
			id7_Item = Reader.NameTable.Add (@"http://controller.timbrado.ws.servisim.com/");
			id31_ResponseAdmin = Reader.NameTable.Add (@"ResponseAdmin");
			id29_password = Reader.NameTable.Add (@"password");
			id15_cancelarCFDi = Reader.NameTable.Add (@"cancelarCFDi");
			id39_id = Reader.NameTable.Add (@"id");
			id24_idError = Reader.NameTable.Add (@"idError");
			id38_RequestServisim = Reader.NameTable.Add (@"RequestServisim");
			id22_requestAdmin = Reader.NameTable.Add (@"requestAdmin");
			id21_registrarEmisorResponse = Reader.NameTable.Add (@"registrarEmisorResponse");
			id11_UsernameToken = Reader.NameTable.Add (@"UsernameToken");
			id26_rfc = Reader.NameTable.Add (@"rfc");
			id30_token = Reader.NameTable.Add (@"token");
			id14_responseServisim = Reader.NameTable.Add (@"responseServisim");
			id46_ArrayOfSecurity = Reader.NameTable.Add (@"ArrayOfSecurity");
			id45_Item = Reader.NameTable.Add (@"http://srv.soap.factura.sit.mx.com");
			id41_Username = Reader.NameTable.Add (@"Username");
			id20_Item = Reader.NameTable.Add (@"http://controller.distribuidor.ws.servisim.com/");
			id13_timbrarCFDiResponse = Reader.NameTable.Add (@"timbrarCFDiResponse");
			id23_responseAdmin = Reader.NameTable.Add (@"responseAdmin");
			id4_SoapFaultDetail = Reader.NameTable.Add (@"SoapFaultDetail");
			id8_requestServisim = Reader.NameTable.Add (@"requestServisim");
			id9_Security = Reader.NameTable.Add (@"Security");
			id27_certificado = Reader.NameTable.Add (@"certificado");
			id10_Item = Reader.NameTable.Add (@"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
			id12_WsPasswordText = Reader.NameTable.Add (@"WsPasswordText");
			id43_mustUnderstand = Reader.NameTable.Add (@"mustUnderstand");
			id25_resultado = Reader.NameTable.Add (@"resultado");
			id42_Password = Reader.NameTable.Add (@"Password");
			id1_Envelope = Reader.NameTable.Add (@"Envelope");
			id32_RequestAdmin = Reader.NameTable.Add (@"RequestAdmin");
			id36_xml = Reader.NameTable.Add (@"xml");
			id5_Item = Reader.NameTable.Add (@"");
			id16_cancelarCFDiResponse = Reader.NameTable.Add (@"cancelarCFDiResponse");
			id2_Item = Reader.NameTable.Add (@"http://www.w3.org/2003/05/soap-envelope");
			id47_ArrayOfChoice1 = Reader.NameTable.Add (@"ArrayOfChoice1");
			id34_uuid = Reader.NameTable.Add (@"uuid");
			id3_Fault = Reader.NameTable.Add (@"Fault");
			id40_Type = Reader.NameTable.Add (@"Type");
			id35_fechaTimbre = Reader.NameTable.Add (@"fechaTimbre");
			id28_llave = Reader.NameTable.Add (@"llave");
			id48_faultcode = Reader.NameTable.Add (@"faultcode");
			id50_detail = Reader.NameTable.Add (@"detail");
			id49_faultstring = Reader.NameTable.Add (@"faultstring");
			id37_error = Reader.NameTable.Add (@"error");
			id18_obtenerCFDiResponse = Reader.NameTable.Add (@"obtenerCFDiResponse");
		}
	}

	internal abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer
	{
		protected override System.Xml.Serialization.XmlSerializationReader CreateReader ()
		{
			return new XmlSerializationReader1 ();
		}

		protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter ()
		{
			return new XmlSerializationWriter1 ();
		}
	}

	internal sealed class SoapEnvelopeSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"Envelope", @"http://www.w3.org/2003/05/soap-envelope");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write22_Envelope (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read22_Envelope ();
		}
	}

	internal sealed class SoapFaultSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"Fault", @"http://www.w3.org/2003/05/soap-envelope");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write23_Fault (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read23_Fault ();
		}
	}

	internal sealed class SoapFaultDetailSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"SoapFaultDetail", @"");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write24_SoapFaultDetail (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read24_SoapFaultDetail ();
		}
	}

	internal sealed class TimbrarCFDISerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"timbrarCFDi", @"http://controller.timbrado.ws.servisim.com/");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write25_timbrarCFDi (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read25_timbrarCFDi ();
		}
	}

	internal sealed class RequestServisimSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"requestServisim", @"");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write26_requestServisim (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read26_requestServisim ();
		}
	}

	internal sealed class WsSecuritySerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"Security", @"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write27_Security (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read27_Security ();
		}
	}

	internal sealed class WsUsernameTokenSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"UsernameToken", @"");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write28_UsernameToken (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read28_UsernameToken ();
		}
	}

	internal sealed class WsPasswordTextSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"WsPasswordText", @"");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write29_WsPasswordText (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read29_WsPasswordText ();
		}
	}

	internal sealed class TimbrarCFDIResponseSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"timbrarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write30_timbrarCFDiResponse (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read30_timbrarCFDiResponse ();
		}
	}

	internal sealed class ResponseServisimSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"responseServisim", @"");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write31_responseServisim (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read31_responseServisim ();
		}
	}

	internal sealed class CancelarCFDISerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"cancelarCFDi", @"http://controller.timbrado.ws.servisim.com/");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write32_cancelarCFDi (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read32_cancelarCFDi ();
		}
	}

	internal sealed class CancelarCFDIResponseSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"cancelarCFDiResponse", @"http://controller.timbrado.ws.servisim.com/");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write33_cancelarCFDiResponse (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read33_cancelarCFDiResponse ();
		}
	}

	internal sealed class ObtenerCFDISerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"obtenerCFDi", @"http://controller.timbrado.ws.servisim.com/");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write34_obtenerCFDi (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read34_obtenerCFDi ();
		}
	}

	internal sealed class ObtenerCFDIResponseSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"obtenerCFDiResponse", @"http://controller.timbrado.ws.servisim.com/");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write35_obtenerCFDiResponse (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read35_obtenerCFDiResponse ();
		}
	}

	internal sealed class RegistrarEmisorSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"registrarEmisor", @"http://controller.distribuidor.ws.servisim.com/");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write36_registrarEmisor (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read36_registrarEmisor ();
		}
	}

	internal sealed class RegistrarEmisorResponseSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"registrarEmisorResponse", @"http://controller.distribuidor.ws.servisim.com/");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write37_registrarEmisorResponse (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read37_registrarEmisorResponse ();
		}
	}

	internal sealed class RequestAdminSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"requestAdmin", @"");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write38_requestAdmin (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read38_requestAdmin ();
		}
	}

	internal sealed class ResponseAdminSerializer : XmlSerializer1
	{

		public override System.Boolean CanDeserialize (System.Xml.XmlReader xmlReader)
		{
			return xmlReader.IsStartElement (@"responseAdmin", @"");
		}

		protected override void Serialize (object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer)
		{
			((XmlSerializationWriter1)writer).Write39_responseAdmin (objectToSerialize);
		}

		protected override object Deserialize (System.Xml.Serialization.XmlSerializationReader reader)
		{
			return ((XmlSerializationReader1)reader).Read39_responseAdmin ();
		}
	}

	internal class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation
	{
		public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1 (); } }

		public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1 (); } }

		System.Collections.Hashtable readMethods = null;

		public override System.Collections.Hashtable ReadMethods {
			get {
				if (readMethods == null) {
					System.Collections.Hashtable _tmp = new System.Collections.Hashtable ();
					_tmp [@"Mictlanix.Servisim.Client.Internals.SoapEnvelope:http://www.w3.org/2003/05/soap-envelope:Envelope:False:"] = @"Read22_Envelope";
					_tmp [@"Mictlanix.Servisim.Client.Internals.SoapFault:http://www.w3.org/2003/05/soap-envelope:Fault:False:"] = @"Read23_Fault";
					_tmp [@"Mictlanix.Servisim.Client.Internals.SoapFaultDetail::"] = @"Read24_SoapFaultDetail";
					_tmp [@"Mictlanix.Servisim.Client.Internals.TimbrarCFDI:http://controller.timbrado.ws.servisim.com/:timbrarCFDi:False:"] = @"Read25_timbrarCFDi";
					_tmp [@"Mictlanix.Servisim.Client.Internals.RequestServisim::"] = @"Read26_requestServisim";
					_tmp [@"Mictlanix.Servisim.Client.Internals.WsSecurity:http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Security:True:"] = @"Read27_Security";
					_tmp [@"Mictlanix.Servisim.Client.Internals.WsUsernameToken::"] = @"Read28_UsernameToken";
					_tmp [@"Mictlanix.Servisim.Client.WsPasswordText::"] = @"Read29_WsPasswordText";
					_tmp [@"Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse:http://controller.timbrado.ws.servisim.com/:timbrarCFDiResponse:False:"] = @"Read30_timbrarCFDiResponse";
					_tmp [@"Mictlanix.Servisim.Client.Internals.ResponseServisim::"] = @"Read31_responseServisim";
					_tmp [@"Mictlanix.Servisim.Client.Internals.CancelarCFDI:http://controller.timbrado.ws.servisim.com/:cancelarCFDi:False:"] = @"Read32_cancelarCFDi";
					_tmp [@"Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse:http://controller.timbrado.ws.servisim.com/:cancelarCFDiResponse:False:"] = @"Read33_cancelarCFDiResponse";
					_tmp [@"Mictlanix.Servisim.Client.Internals.ObtenerCFDI:http://controller.timbrado.ws.servisim.com/:obtenerCFDi:False:"] = @"Read34_obtenerCFDi";
					_tmp [@"Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse:http://controller.timbrado.ws.servisim.com/:obtenerCFDiResponse:False:"] = @"Read35_obtenerCFDiResponse";
					_tmp [@"Mictlanix.Servisim.Client.Internals.RegistrarEmisor:http://controller.distribuidor.ws.servisim.com/:registrarEmisor:False:"] = @"Read36_registrarEmisor";
					_tmp [@"Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse:http://controller.distribuidor.ws.servisim.com/:registrarEmisorResponse:False:"] = @"Read37_registrarEmisorResponse";
					_tmp [@"Mictlanix.Servisim.Client.Internals.RequestAdmin::"] = @"Read38_requestAdmin";
					_tmp [@"Mictlanix.Servisim.Client.Internals.ResponseAdmin::"] = @"Read39_responseAdmin";
					if (readMethods == null)
						readMethods = _tmp;
				}
				return readMethods;
			}
		}

		System.Collections.Hashtable writeMethods = null;

		public override System.Collections.Hashtable WriteMethods {
			get {
				if (writeMethods == null) {
					System.Collections.Hashtable _tmp = new System.Collections.Hashtable ();
					_tmp [@"Mictlanix.Servisim.Client.Internals.SoapEnvelope:http://www.w3.org/2003/05/soap-envelope:Envelope:False:"] = @"Write22_Envelope";
					_tmp [@"Mictlanix.Servisim.Client.Internals.SoapFault:http://www.w3.org/2003/05/soap-envelope:Fault:False:"] = @"Write23_Fault";
					_tmp [@"Mictlanix.Servisim.Client.Internals.SoapFaultDetail::"] = @"Write24_SoapFaultDetail";
					_tmp [@"Mictlanix.Servisim.Client.Internals.TimbrarCFDI:http://controller.timbrado.ws.servisim.com/:timbrarCFDi:False:"] = @"Write25_timbrarCFDi";
					_tmp [@"Mictlanix.Servisim.Client.Internals.RequestServisim::"] = @"Write26_requestServisim";
					_tmp [@"Mictlanix.Servisim.Client.Internals.WsSecurity:http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Security:True:"] = @"Write27_Security";
					_tmp [@"Mictlanix.Servisim.Client.Internals.WsUsernameToken::"] = @"Write28_UsernameToken";
					_tmp [@"Mictlanix.Servisim.Client.WsPasswordText::"] = @"Write29_WsPasswordText";
					_tmp [@"Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse:http://controller.timbrado.ws.servisim.com/:timbrarCFDiResponse:False:"] = @"Write30_timbrarCFDiResponse";
					_tmp [@"Mictlanix.Servisim.Client.Internals.ResponseServisim::"] = @"Write31_responseServisim";
					_tmp [@"Mictlanix.Servisim.Client.Internals.CancelarCFDI:http://controller.timbrado.ws.servisim.com/:cancelarCFDi:False:"] = @"Write32_cancelarCFDi";
					_tmp [@"Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse:http://controller.timbrado.ws.servisim.com/:cancelarCFDiResponse:False:"] = @"Write33_cancelarCFDiResponse";
					_tmp [@"Mictlanix.Servisim.Client.Internals.ObtenerCFDI:http://controller.timbrado.ws.servisim.com/:obtenerCFDi:False:"] = @"Write34_obtenerCFDi";
					_tmp [@"Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse:http://controller.timbrado.ws.servisim.com/:obtenerCFDiResponse:False:"] = @"Write35_obtenerCFDiResponse";
					_tmp [@"Mictlanix.Servisim.Client.Internals.RegistrarEmisor:http://controller.distribuidor.ws.servisim.com/:registrarEmisor:False:"] = @"Write36_registrarEmisor";
					_tmp [@"Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse:http://controller.distribuidor.ws.servisim.com/:registrarEmisorResponse:False:"] = @"Write37_registrarEmisorResponse";
					_tmp [@"Mictlanix.Servisim.Client.Internals.RequestAdmin::"] = @"Write38_requestAdmin";
					_tmp [@"Mictlanix.Servisim.Client.Internals.ResponseAdmin::"] = @"Write39_responseAdmin";
					if (writeMethods == null)
						writeMethods = _tmp;
				}
				return writeMethods;
			}
		}

		System.Collections.Hashtable typedSerializers = null;

		public override System.Collections.Hashtable TypedSerializers {
			get {
				if (typedSerializers == null) {
					System.Collections.Hashtable _tmp = new System.Collections.Hashtable ();
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.ObtenerCFDI:http://controller.timbrado.ws.servisim.com/:obtenerCFDi:False:", new ObtenerCFDISerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.SoapEnvelope:http://www.w3.org/2003/05/soap-envelope:Envelope:False:", new SoapEnvelopeSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.TimbrarCFDI:http://controller.timbrado.ws.servisim.com/:timbrarCFDi:False:", new TimbrarCFDISerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.RequestAdmin::", new RequestAdminSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.ResponseServisim::", new ResponseServisimSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse:http://controller.timbrado.ws.servisim.com/:obtenerCFDiResponse:False:", new ObtenerCFDIResponseSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.ResponseAdmin::", new ResponseAdminSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.RegistrarEmisor:http://controller.distribuidor.ws.servisim.com/:registrarEmisor:False:", new RegistrarEmisorSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse:http://controller.timbrado.ws.servisim.com/:timbrarCFDiResponse:False:", new TimbrarCFDIResponseSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.WsPasswordText::", new WsPasswordTextSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse:http://controller.timbrado.ws.servisim.com/:cancelarCFDiResponse:False:", new CancelarCFDIResponseSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse:http://controller.distribuidor.ws.servisim.com/:registrarEmisorResponse:False:", new RegistrarEmisorResponseSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.WsSecurity:http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd:Security:True:", new WsSecuritySerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.RequestServisim::", new RequestServisimSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.WsUsernameToken::", new WsUsernameTokenSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.SoapFault:http://www.w3.org/2003/05/soap-envelope:Fault:False:", new SoapFaultSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.SoapFaultDetail::", new SoapFaultDetailSerializer ());
					_tmp.Add (@"Mictlanix.Servisim.Client.Internals.CancelarCFDI:http://controller.timbrado.ws.servisim.com/:cancelarCFDi:False:", new CancelarCFDISerializer ());
					if (typedSerializers == null)
						typedSerializers = _tmp;
				}
				return typedSerializers;
			}
		}

		public override System.Boolean CanSerialize (System.Type type)
		{
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.SoapEnvelope))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFault))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.RequestServisim))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.WsSecurity))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.WsUsernameToken))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.WsPasswordText))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.ResponseServisim))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.CancelarCFDI))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.RequestAdmin))
				return true;
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.ResponseAdmin))
				return true;
			return false;
		}

		public override System.Xml.Serialization.XmlSerializer GetSerializer (System.Type type)
		{
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.SoapEnvelope))
				return new SoapEnvelopeSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFault))
				return new SoapFaultSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.SoapFaultDetail))
				return new SoapFaultDetailSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.TimbrarCFDI))
				return new TimbrarCFDISerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.RequestServisim))
				return new RequestServisimSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.WsSecurity))
				return new WsSecuritySerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.WsUsernameToken))
				return new WsUsernameTokenSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.WsPasswordText))
				return new WsPasswordTextSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.TimbrarCFDIResponse))
				return new TimbrarCFDIResponseSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.ResponseServisim))
				return new ResponseServisimSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.CancelarCFDI))
				return new CancelarCFDISerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.CancelarCFDIResponse))
				return new CancelarCFDIResponseSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.ObtenerCFDI))
				return new ObtenerCFDISerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.ObtenerCFDIResponse))
				return new ObtenerCFDIResponseSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.RegistrarEmisor))
				return new RegistrarEmisorSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.RegistrarEmisorResponse))
				return new RegistrarEmisorResponseSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.RequestAdmin))
				return new RequestAdminSerializer ();
			if (type == typeof(global::Mictlanix.Servisim.Client.Internals.ResponseAdmin))
				return new ResponseAdminSerializer ();
			return null;
		}
	}
}
