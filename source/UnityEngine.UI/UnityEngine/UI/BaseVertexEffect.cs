﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI
{
	// Token: 0x0200003E RID: 62
	[Obsolete("Use BaseMeshEffect instead", true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000080")]
	public abstract class BaseVertexEffect
	{
		// Token: 0x060004A1 RID: 1185
		[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x6000522")]
		public abstract void ModifyVertices(List<UIVertex> vertices);

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002DDC File Offset: 0x00000FDC
		[global::Cpp2ILInjected.Token(Token = "0x6000523")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1A00", Offset = "0x1FE1A00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected BaseVertexEffect()
		{
			throw null;
		}
	}
}
