﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000064 RID: 100
	[global::Cpp2ILInjected.Token(Token = "0x200008A")]
	public class AssemblyLoadEventArgs : global::System.EventArgs
	{
		// Token: 0x06000368 RID: 872 RVA: 0x00014F69 File Offset: 0x00013169
		[global::Cpp2ILInjected.Token(Token = "0x60003FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB62B8", Offset = "0x1BB62B8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "DoAssemblyLoad", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AssemblyLoadEventArgs(global::System.Reflection.Assembly loadedAssembly)
		{
			throw null;
		}

		// Token: 0x04000100 RID: 256
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Reflection.Assembly <LoadedAssembly>k__BackingField;
	}
}
