﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000391 RID: 913
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200043B")]
	public sealed class ComDefaultInterfaceAttribute : global::System.Attribute
	{
		// Token: 0x06001F28 RID: 7976 RVA: 0x00019C70 File Offset: 0x00017E70
		[global::Cpp2ILInjected.Token(Token = "0x6002169")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B700C8", Offset = "0x1B700C8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ComDefaultInterfaceAttribute(global::System.Type defaultInterface)
		{
			throw null;
		}

		// Token: 0x04000F0D RID: 3853
		[global::Cpp2ILInjected.Token(Token = "0x4001202")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.Type _val;
	}
}
