﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000026 RID: 38
	[global::Cpp2ILInjected.Token(Token = "0x2000038")]
	internal class MSCompatUnicodeTableUtil
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00014759 File Offset: 0x00012959
		[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAFA2C", Offset = "0x1AAFA2C", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		static MSCompatUnicodeTableUtil()
		{
			throw null;
		}

		// Token: 0x04000060 RID: 96
		[global::Cpp2ILInjected.Token(Token = "0x40000F9")]
		public static readonly CodePointIndexer Ignorable;

		// Token: 0x04000061 RID: 97
		[global::Cpp2ILInjected.Token(Token = "0x40000FA")]
		public static readonly CodePointIndexer Category;

		// Token: 0x04000062 RID: 98
		[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
		public static readonly CodePointIndexer Level1;

		// Token: 0x04000063 RID: 99
		[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
		public static readonly CodePointIndexer Level2;

		// Token: 0x04000064 RID: 100
		[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
		public static readonly CodePointIndexer Level3;

		// Token: 0x04000065 RID: 101
		[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
		public static readonly CodePointIndexer CjkCHS;

		// Token: 0x04000066 RID: 102
		[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
		public static readonly CodePointIndexer Cjk;
	}
}
