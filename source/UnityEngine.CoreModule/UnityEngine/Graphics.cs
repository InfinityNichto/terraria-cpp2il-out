﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000050 RID: 80
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Graphics/ColorGamut.h")]
	[NativeHeader("Runtime/Graphics/CopyTexture.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000054")]
	public class Graphics
	{
		// Token: 0x0600016A RID: 362 RVA: 0x00002338 File Offset: 0x00000538
		[global::Cpp2ILInjected.Token(Token = "0x6000172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7381C", Offset = "0x1F7381C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphics), Member = "Blit", MemberParameters = new object[]
		{
			typeof(Texture),
			typeof(RenderTexture),
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Blit(Texture source, RenderTexture dest, Material mat, [DefaultValue("-1")] int pass)
		{
			throw null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000233B File Offset: 0x0000053B
		[global::Cpp2ILInjected.Token(Token = "0x6000173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73928", Offset = "0x1F73928", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ScreenPostProcessor", Member = "OnRenderImage", MemberParameters = new object[]
		{
			typeof(RenderTexture),
			typeof(RenderTexture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphics), Member = "Blit", MemberParameters = new object[]
		{
			typeof(Texture),
			typeof(RenderTexture),
			typeof(Material),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Blit(Texture source, RenderTexture dest, Material mat)
		{
			throw null;
		}

		// Token: 0x0600016C RID: 364
		[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount")]
		[global::Cpp2ILInjected.Token(Token = "0x6000174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73998", Offset = "0x1F73998", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int Internal_GetMaxDrawMeshInstanceCount();

		// Token: 0x0600016D RID: 365
		[FreeFunction("GraphicsScripting::BlitMaterial")]
		[global::Cpp2ILInjected.Token(Token = "0x6000175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F738BC", Offset = "0x1F738BC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_BlitMaterial5(Texture source, RenderTexture dest, [NotNull("ArgumentNullException")] Material mat, int pass, bool setRT);

		// Token: 0x0600016E RID: 366 RVA: 0x0000233E File Offset: 0x0000053E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F739C0", Offset = "0x1F739C0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static Graphics()
		{
			throw null;
		}

		// Token: 0x04000214 RID: 532
		[global::Cpp2ILInjected.Token(Token = "0x4000219")]
		internal static readonly int kMaxDrawMeshInstanceCount;
	}
}