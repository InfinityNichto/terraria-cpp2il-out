﻿using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000151 RID: 337
	[global::Cpp2ILInjected.Token(Token = "0x200019C")]
	internal class ArraySpec : global::System.ModifierSpec
	{
		// Token: 0x06000ED0 RID: 3792 RVA: 0x00016EF2 File Offset: 0x000150F2
		[global::Cpp2ILInjected.Token(Token = "0x6000FCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89828", Offset = "0x1C89828", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ArraySpec(int dimensions, bool bound)
		{
			throw null;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00016EF5 File Offset: 0x000150F5
		[global::Cpp2ILInjected.Token(Token = "0x6000FCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89858", Offset = "0x1C89858", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.Type Resolve(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00016EF8 File Offset: 0x000150F8
		[global::Cpp2ILInjected.Token(Token = "0x6000FD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8989C", Offset = "0x1C8989C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySpec), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.Text.StringBuilder Append(global::System.Text.StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00016EFB File Offset: 0x000150FB
		[global::Cpp2ILInjected.Token(Token = "0x6000FD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8992C", Offset = "0x1C8992C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArraySpec), Member = "Append", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040006AB RID: 1707
		[global::Cpp2ILInjected.Token(Token = "0x4000882")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int dimensions;

		// Token: 0x040006AC RID: 1708
		[global::Cpp2ILInjected.Token(Token = "0x4000883")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool bound;
	}
}
