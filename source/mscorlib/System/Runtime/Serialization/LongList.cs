﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000338 RID: 824
	[global::Cpp2ILInjected.Token(Token = "0x20003E0")]
	[global::System.Serializable]
	internal class LongList
	{
		// Token: 0x06001D2E RID: 7470 RVA: 0x00019694 File Offset: 0x00017894
		[global::Cpp2ILInjected.Token(Token = "0x6001F6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58528", Offset = "0x1B58528", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LongList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		internal LongList()
		{
			throw null;
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00019697 File Offset: 0x00017897
		[global::Cpp2ILInjected.Token(Token = "0x6001F6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58758", Offset = "0x1B58758", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "AddDependency", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LongList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal LongList(int startingSize)
		{
			throw null;
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x0001969A File Offset: 0x0001789A
		[global::Cpp2ILInjected.Token(Token = "0x6001F6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58530", Offset = "0x1B58530", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "AddDependency", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LongList), Member = "EnlargeArray", ReturnType = typeof(void))]
		internal void Add(long value)
		{
			throw null;
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0001969D File Offset: 0x0001789D
		[global::Cpp2ILInjected.Token(Token = "0x1700042C")]
		internal int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B58844", Offset = "0x1B58844", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x000196A0 File Offset: 0x000178A0
		[global::Cpp2ILInjected.Token(Token = "0x6001F70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B56998", Offset = "0x1B56998", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void StartEnumeration()
		{
			throw null;
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x000196A3 File Offset: 0x000178A3
		[global::Cpp2ILInjected.Token(Token = "0x6001F71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B569C4", Offset = "0x1B569C4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool MoveNext()
		{
			throw null;
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x000196A6 File Offset: 0x000178A6
		[global::Cpp2ILInjected.Token(Token = "0x1700042D")]
		internal long Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B569A4", Offset = "0x1B569A4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x000196A9 File Offset: 0x000178A9
		[global::Cpp2ILInjected.Token(Token = "0x6001F73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B584A8", Offset = "0x1B584A8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool RemoveElement(long value)
		{
			throw null;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000196AC File Offset: 0x000178AC
		[global::Cpp2ILInjected.Token(Token = "0x6001F74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B587C4", Offset = "0x1B587C4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LongList), Member = "Add", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnlargeArray()
		{
			throw null;
		}

		// Token: 0x04000CC3 RID: 3267
		[global::Cpp2ILInjected.Token(Token = "0x4000FB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private long[] m_values;

		// Token: 0x04000CC4 RID: 3268
		[global::Cpp2ILInjected.Token(Token = "0x4000FB6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_count;

		// Token: 0x04000CC5 RID: 3269
		[global::Cpp2ILInjected.Token(Token = "0x4000FB7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int m_totalItems;

		// Token: 0x04000CC6 RID: 3270
		[global::Cpp2ILInjected.Token(Token = "0x4000FB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_currentItem;
	}
}
