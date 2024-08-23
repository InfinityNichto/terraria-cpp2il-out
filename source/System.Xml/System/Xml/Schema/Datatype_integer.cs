﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000DD RID: 221
	[global::Cpp2ILInjected.Token(Token = "0x2000109")]
	internal class Datatype_integer : Datatype_decimal
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0000489E File Offset: 0x00002A9E
		[global::Cpp2ILInjected.Token(Token = "0x1700027D")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000957")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC25F0", Offset = "0x1DC25F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000048A1 File Offset: 0x00002AA1
		[global::Cpp2ILInjected.Token(Token = "0x6000958")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC25F8", Offset = "0x1DC25F8", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToInteger", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref decimal)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x000048A4 File Offset: 0x00002AA4
		[global::Cpp2ILInjected.Token(Token = "0x6000959")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC272C", Offset = "0x1DC272C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_nonPositiveInteger), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_negativeInteger), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_long), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_int), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_nonNegativeInteger), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_unsignedLong), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_positiveInteger), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_integer()
		{
			throw null;
		}
	}
}
