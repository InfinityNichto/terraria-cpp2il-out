﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x020002C6 RID: 710
	[global::Cpp2ILInjected.Token(Token = "0x2000368")]
	internal class ContextCallbackObject : global::System.ContextBoundObject
	{
		// Token: 0x06001ADC RID: 6876 RVA: 0x00019079 File Offset: 0x00017279
		[global::Cpp2ILInjected.Token(Token = "0x6001D06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C180", Offset = "0x1B3C180", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DoCallBack(CrossContextDelegate deleg)
		{
			throw null;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0001907C File Offset: 0x0001727C
		[global::Cpp2ILInjected.Token(Token = "0x6001D07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C178", Offset = "0x1B3C178", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ContextBoundObject), Member = ".ctor", ReturnType = typeof(void))]
		public ContextCallbackObject()
		{
			throw null;
		}
	}
}
