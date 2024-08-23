﻿using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000115 RID: 277
	[global::Cpp2ILInjected.Token(Token = "0x2000147")]
	[Serializable]
	public class XmlSchemaException : SystemException
	{
		// Token: 0x06000A42 RID: 2626 RVA: 0x00004CE5 File Offset: 0x00002EE5
		[global::Cpp2ILInjected.Token(Token = "0x6000ADC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCE254", Offset = "0x1DCE254", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		protected XmlSchemaException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00004CE8 File Offset: 0x00002EE8
		[global::Cpp2ILInjected.Token(Token = "0x6000ADD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCE6BC", Offset = "0x1DCE6BC", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00004CEB File Offset: 0x00002EEB
		[global::Cpp2ILInjected.Token(Token = "0x6000ADE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCE82C", Offset = "0x1DCE82C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public XmlSchemaException()
		{
			throw null;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00004CEE File Offset: 0x00002EEE
		[global::Cpp2ILInjected.Token(Token = "0x6000ADF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCE840", Offset = "0x1DCE840", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public XmlSchemaException(string message)
		{
			throw null;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00004CF1 File Offset: 0x00002EF1
		[global::Cpp2ILInjected.Token(Token = "0x6000AE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC54A0", Offset = "0x1DC54A0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_doubleXdr), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_floatXdr), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_QNameXdr), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_char), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_fixed), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_uuid), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public XmlSchemaException(string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[global::Cpp2ILInjected.Token(Token = "0x6000AE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCE850", Offset = "0x1DCE850", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition)
		{
			throw null;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00004CF7 File Offset: 0x00002EF7
		[global::Cpp2ILInjected.Token(Token = "0x6000AE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBFB6C", Offset = "0x1DBFB6C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlSchemaException(string res, string arg)
		{
			throw null;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00004CFA File Offset: 0x00002EFA
		[global::Cpp2ILInjected.Token(Token = "0x6000AE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCE9E8", Offset = "0x1DCE9E8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition)
		{
			throw null;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00004CFD File Offset: 0x00002EFD
		[global::Cpp2ILInjected.Token(Token = "0x6000AE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCE960", Offset = "0x1DCE960", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal XmlSchemaException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source)
		{
			throw null;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00004D00 File Offset: 0x00002F00
		[global::Cpp2ILInjected.Token(Token = "0x6000AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCE5F8", Offset = "0x1DCE5F8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(XmlSchemaObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static string CreateMessage(string res, string[] args)
		{
			throw null;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00004D03 File Offset: 0x00002F03
		[global::Cpp2ILInjected.Token(Token = "0x1700031F")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AE6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCEAC8", Offset = "0x1DCEAC8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000402 RID: 1026
		[global::Cpp2ILInjected.Token(Token = "0x4000591")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string res;

		// Token: 0x04000403 RID: 1027
		[global::Cpp2ILInjected.Token(Token = "0x4000592")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string[] args;

		// Token: 0x04000404 RID: 1028
		[global::Cpp2ILInjected.Token(Token = "0x4000593")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private string sourceUri;

		// Token: 0x04000405 RID: 1029
		[global::Cpp2ILInjected.Token(Token = "0x4000594")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private int lineNumber;

		// Token: 0x04000406 RID: 1030
		[global::Cpp2ILInjected.Token(Token = "0x4000595")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		private int linePosition;

		// Token: 0x04000407 RID: 1031
		[global::Cpp2ILInjected.Token(Token = "0x4000596")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		private XmlSchemaObject sourceSchemaObject;

		// Token: 0x04000408 RID: 1032
		[global::Cpp2ILInjected.Token(Token = "0x4000597")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private string message;
	}
}
