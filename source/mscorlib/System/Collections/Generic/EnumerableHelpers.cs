﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000525 RID: 1317
	[global::Cpp2ILInjected.Token(Token = "0x200063E")]
	internal static class EnumerableHelpers
	{
		// Token: 0x06002C73 RID: 11379 RVA: 0x0001C0BB File Offset: 0x0001A2BB
		[global::Cpp2ILInjected.Token(Token = "0x60030EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1587DB4", Offset = "0x1587DB4", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LargeArrayBuilder<>), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LargeArrayBuilder<>), Member = "AddRange", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LargeArrayBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static T[] ToArray<T>(IEnumerable<T> source)
		{
			throw null;
		}
	}
}
