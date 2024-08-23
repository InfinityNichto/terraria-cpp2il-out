﻿using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x0200030F RID: 783
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::Cpp2ILInjected.Token(Token = "0x200042B")]
	internal ref struct ValueListBuilder<T>
	{
		// Token: 0x060019EC RID: 6636 RVA: 0x00007721 File Offset: 0x00005921
		[global::Cpp2ILInjected.Token(Token = "0x6001CF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AAE20", Offset = "0x18AAE20", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = ".ctor", MemberParameters = new object[] { typeof(Span<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Span<int>),
			typeof(Span<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public ValueListBuilder(Span<T> initialSpan)
		{
			throw null;
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x00007724 File Offset: 0x00005924
		[global::Cpp2ILInjected.Token(Token = "0x17000680")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AAE30", Offset = "0x18AAE30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700062C RID: 1580
		[global::Cpp2ILInjected.Token(Token = "0x17000681")]
		public ref T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AAE38", Offset = "0x18AAE38", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "PatchJump", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0000772A File Offset: 0x0000592A
		[global::Cpp2ILInjected.Token(Token = "0x6001CF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AAE44", Offset = "0x18AAE44", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public void Append(T item)
		{
			throw null;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0000772D File Offset: 0x0000592D
		[global::Cpp2ILInjected.Token(Token = "0x6001CF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AAEBC", Offset = "0x18AAEBC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ReadOnlySpan<T> AsSpan()
		{
			throw null;
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00007730 File Offset: 0x00005930
		[global::Cpp2ILInjected.Token(Token = "0x6001CFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AAF7C", Offset = "0x18AAF7C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(256)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00007733 File Offset: 0x00005933
		[global::Cpp2ILInjected.Token(Token = "0x6001CFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AB034", Offset = "0x18AB034", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "PushInt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueListBuilder<>), Member = "Append", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<int>), Member = "TryCopyTo", MemberParameters = new object[] { typeof(Span<int>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void Grow()
		{
			throw null;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00007736 File Offset: 0x00005936
		[global::Cpp2ILInjected.Token(Token = "0x6001CFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AB28C", Offset = "0x18AB28C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public T Pop()
		{
			throw null;
		}

		// Token: 0x04000F7B RID: 3963
		[global::Cpp2ILInjected.Token(Token = "0x40013D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Span<T> _span;

		// Token: 0x04000F7C RID: 3964
		[global::Cpp2ILInjected.Token(Token = "0x40013D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T[] _arrayFromPool;

		// Token: 0x04000F7D RID: 3965
		[global::Cpp2ILInjected.Token(Token = "0x40013D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _pos;
	}
}
