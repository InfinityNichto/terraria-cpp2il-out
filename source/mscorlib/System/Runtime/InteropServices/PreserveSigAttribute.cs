﻿using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000399 RID: 921
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000443")]
	public sealed class PreserveSigAttribute : global::System.Attribute
	{
		// Token: 0x06001F2D RID: 7981 RVA: 0x00019C7F File Offset: 0x00017E7F
		[global::Cpp2ILInjected.Token(Token = "0x600216E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70170", Offset = "0x1B70170", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public PreserveSigAttribute()
		{
			throw null;
		}
	}
}
