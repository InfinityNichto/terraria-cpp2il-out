﻿using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200001D RID: 29
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
	[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public struct AnimationPlayableOutput
	{
		// Token: 0x04000054 RID: 84
		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;
	}
}
