﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Linq
{
	// Token: 0x0200000E RID: 14
	[global::Cpp2ILInjected.Token(Token = "0x2000023")]
	internal class Set<TElement>
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000441E File Offset: 0x0000261E
		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18646A8", Offset = "0x18646A8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Set(IEqualityComparer<TElement> comparer)
		{
			throw null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004421 File Offset: 0x00002621
		[global::Cpp2ILInjected.Token(Token = "0x600010F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1864760", Offset = "0x1864760", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Add(TElement value)
		{
			throw null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004424 File Offset: 0x00002624
		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x186478C", Offset = "0x186478C", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool Find(TElement value, bool add)
		{
			throw null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004427 File Offset: 0x00002627
		[global::Cpp2ILInjected.Token(Token = "0x6000111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1864970", Offset = "0x1864970", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Resize()
		{
			throw null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000442A File Offset: 0x0000262A
		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1864A9C", Offset = "0x1864A9C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int InternalGetHashCode(TElement value)
		{
			throw null;
		}

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x4000086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int[] buckets;

		// Token: 0x04000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x4000087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Set<TElement>.Slot[] slots;

		// Token: 0x04000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x4000088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int count;

		// Token: 0x04000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x4000089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int freeList;

		// Token: 0x04000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x400008A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TElement> comparer;

		// Token: 0x02000038 RID: 56
		[global::Cpp2ILInjected.Token(Token = "0x2000024")]
		internal struct Slot
		{
			// Token: 0x040000C3 RID: 195
			[global::Cpp2ILInjected.Token(Token = "0x400008B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int hashCode;

			// Token: 0x040000C4 RID: 196
			[global::Cpp2ILInjected.Token(Token = "0x400008C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal TElement value;

			// Token: 0x040000C5 RID: 197
			[global::Cpp2ILInjected.Token(Token = "0x400008D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int next;
		}
	}
}
