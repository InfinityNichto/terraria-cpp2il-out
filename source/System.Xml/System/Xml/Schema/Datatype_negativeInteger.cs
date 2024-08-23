﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000DF RID: 223
	[global::Cpp2ILInjected.Token(Token = "0x200010B")]
	internal class Datatype_negativeInteger : Datatype_nonPositiveInteger
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x000048B3 File Offset: 0x00002AB3
		[global::Cpp2ILInjected.Token(Token = "0x17000280")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x600095E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC28EC", Offset = "0x1DC28EC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x000048B6 File Offset: 0x00002AB6
		[global::Cpp2ILInjected.Token(Token = "0x17000281")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600095F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2944", Offset = "0x1DC2944", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000048B9 File Offset: 0x00002AB9
		[global::Cpp2ILInjected.Token(Token = "0x6000960")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC294C", Offset = "0x1DC294C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_negativeInteger()
		{
			throw null;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000048BC File Offset: 0x00002ABC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000961")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC29A0", Offset = "0x1DC29A0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static Datatype_negativeInteger()
		{
			throw null;
		}

		// Token: 0x04000372 RID: 882
		[global::Cpp2ILInjected.Token(Token = "0x40004EC")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}