﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono
{
	// Token: 0x0200000E RID: 14
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	internal struct RuntimeEventHandle
	{
		// Token: 0x06000028 RID: 40 RVA: 0x0001464B File Offset: 0x0001284B
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB118", Offset = "0x1AAB118", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal RuntimeEventHandle(global::System.IntPtr v)
		{
			throw null;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0001464E File Offset: 0x0001284E
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public global::System.IntPtr Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAB120", Offset = "0x1AAB120", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00014651 File Offset: 0x00012851
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB128", Offset = "0x1AAB128", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00014654 File Offset: 0x00012854
		[global::Cpp2ILInjected.Token(Token = "0x6000051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB234", Offset = "0x1AAB234", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0400000B RID: 11
		[global::Cpp2ILInjected.Token(Token = "0x400008E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.IntPtr value;
	}
}