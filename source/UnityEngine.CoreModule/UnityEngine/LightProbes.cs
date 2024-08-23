﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000057 RID: 87
	[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200005B")]
	[StructLayout(0)]
	public sealed class LightProbes : Object
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00002371 File Offset: 0x00000571
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000189")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73D08", Offset = "0x1F73D08", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void Internal_CallTetrahedralizationCompletedFunction()
		{
			throw null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002374 File Offset: 0x00000574
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600018A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73D6C", Offset = "0x1F73D6C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void Internal_CallNeedsRetetrahedralizationFunction()
		{
			throw null;
		}

		// Token: 0x04000227 RID: 551
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022C")]
		private static Action tetrahedralizationCompleted;

		// Token: 0x04000228 RID: 552
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400022D")]
		private static Action needsRetetrahedralization;
	}
}
