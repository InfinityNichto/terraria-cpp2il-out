﻿using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Utilities
{
	// Token: 0x02000370 RID: 880
	[global::Cpp2ILInjected.Token(Token = "0x20004F1")]
	public struct Vertical64BitStrips
	{
		// Token: 0x06002C96 RID: 11414 RVA: 0x00029FE7 File Offset: 0x000281E7
		[global::Cpp2ILInjected.Token(Token = "0x60030A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF3EC", Offset = "0x12FF3EC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Vertical64BitStrips(int len)
		{
			throw null;
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00029FEA File Offset: 0x000281EA
		[global::Cpp2ILInjected.Token(Token = "0x60030A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF448", Offset = "0x12FF448", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshStrip", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x170005A2 RID: 1442
		[global::Cpp2ILInjected.Token(Token = "0x1700060E")]
		public Bits64 this[int x]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF45C", Offset = "0x12FF45C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshStrip", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60030A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF46C", Offset = "0x12FF46C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshStrip", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x00029FF3 File Offset: 0x000281F3
		[global::Cpp2ILInjected.Token(Token = "0x60030A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF47C", Offset = "0x12FF47C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshStrip", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Expand3x3()
		{
			throw null;
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x00029FF6 File Offset: 0x000281F6
		[global::Cpp2ILInjected.Token(Token = "0x60030A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF520", Offset = "0x12FF520", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04003183 RID: 12675
		[global::Cpp2ILInjected.Token(Token = "0x4003AA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Bits64[] arr;
	}
}
