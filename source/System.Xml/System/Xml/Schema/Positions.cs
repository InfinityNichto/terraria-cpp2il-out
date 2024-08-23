﻿using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200009D RID: 157
	[global::Cpp2ILInjected.Token(Token = "0x20000C7")]
	internal class Positions
	{
		// Token: 0x0600078F RID: 1935 RVA: 0x00004511 File Offset: 0x00002711
		[global::Cpp2ILInjected.Token(Token = "0x600081D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5330", Offset = "0x1DB5330", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamespaceListNode), Member = "ExpandTree", MemberParameters = new object[]
		{
			typeof(InteriorNode),
			typeof(SymbolsDictionary),
			typeof(Positions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int Add(int symbol, object particle)
		{
			throw null;
		}

		// Token: 0x170001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x170001F5")]
		public Position this[int pos]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600081E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB53B8", Offset = "0x1DB53B8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new object[]
			{
				typeof(BitSet),
				typeof(BitSet[]),
				typeof(ref BitSet)
			}, ReturnType = typeof(BitSet[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckCMUPAWithLeafRangeNodes", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new object[]
			{
				typeof(BitSet),
				typeof(BitSet),
				typeof(BitSet[])
			}, ReturnType = typeof(BitSet))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new object[]
			{
				typeof(BitSet),
				typeof(BitSet[]),
				typeof(int)
			}, ReturnType = typeof(int[][]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00004517 File Offset: 0x00002717
		[global::Cpp2ILInjected.Token(Token = "0x170001F6")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600081F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB5444", Offset = "0x1DB5444", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000451A File Offset: 0x0000271A
		[global::Cpp2ILInjected.Token(Token = "0x6000820")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5458", Offset = "0x1DB5458", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Positions()
		{
			throw null;
		}

		// Token: 0x040002B0 RID: 688
		[global::Cpp2ILInjected.Token(Token = "0x4000422")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ArrayList positions;
	}
}