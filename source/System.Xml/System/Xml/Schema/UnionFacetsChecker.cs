﻿using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000FC RID: 252
	[global::Cpp2ILInjected.Token(Token = "0x2000129")]
	internal class UnionFacetsChecker : FacetsChecker
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x00004ABA File Offset: 0x00002CBA
		[global::Cpp2ILInjected.Token(Token = "0x6000A0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9CC4", Offset = "0x1DC9CC4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00004ABD File Offset: 0x00002CBD
		[global::Cpp2ILInjected.Token(Token = "0x6000A0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9DAC", Offset = "0x1DC9DAC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00004AC0 File Offset: 0x00002CC0
		[global::Cpp2ILInjected.Token(Token = "0x6000A0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9E58", Offset = "0x1DC9E58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UnionFacetsChecker()
		{
			throw null;
		}
	}
}
