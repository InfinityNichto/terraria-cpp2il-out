﻿using System;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x02000019 RID: 25
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	internal static class StringBuilderCache
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x00002266 File Offset: 0x00000466
		[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6BEA8", Offset = "0x1D6BEA8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDeclaration), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElement), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static StringBuilder Acquire(int capacity = 16)
		{
			throw null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002269 File Offset: 0x00000469
		[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F480", Offset = "0x1D6F480", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDeclaration), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElement), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Release(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000226C File Offset: 0x0000046C
		[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6BF68", Offset = "0x1D6BF68", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		public static string GetStringAndRelease(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x04000038 RID: 56
		[ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x400004F")]
		private static StringBuilder t_cachedInstance;
	}
}