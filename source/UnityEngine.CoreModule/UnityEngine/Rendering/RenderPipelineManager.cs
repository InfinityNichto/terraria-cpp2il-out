﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F1 RID: 241
	[global::Cpp2ILInjected.Token(Token = "0x2000111")]
	public static class RenderPipelineManager
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00002BC0 File Offset: 0x00000DC0
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00002BC3 File Offset: 0x00000DC3
		[global::Cpp2ILInjected.Token(Token = "0x17000124")]
		public static RenderPipeline currentPipeline
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000577")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A76C", Offset = "0x1F8A76C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000578")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A7C4", Offset = "0x1F8A7C4", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "PrepareRenderPipeline", MemberParameters = new object[] { typeof(RenderPipelineAsset) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002BC6 File Offset: 0x00000DC6
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000579")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A86C", Offset = "0x1F8A86C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void OnActiveRenderPipelineTypeChanged()
		{
			throw null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002BC9 File Offset: 0x00000DC9
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600057A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A8E0", Offset = "0x1F8A8E0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "PrepareRenderPipeline", MemberParameters = new object[] { typeof(RenderPipelineAsset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
		{
			throw null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002BCC File Offset: 0x00000DCC
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600057B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A960", Offset = "0x1F8A960", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "HandleRenderPipelineChange", MemberParameters = new object[] { typeof(RenderPipelineAsset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineAsset), Member = "OnValidate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineAsset), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipeline), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipelineManager), Member = "set_currentPipeline", MemberParameters = new object[] { typeof(RenderPipeline) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "set_active", MemberParameters = new object[] { typeof(SupportedRenderingFeatures) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal static void CleanupRenderPipeline()
		{
			throw null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002BCF File Offset: 0x00000DCF
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600057C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8AC3C", Offset = "0x1F8AC3C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static string GetCurrentPipelineAssetType()
		{
			throw null;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002BD2 File Offset: 0x00000DD2
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600057D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8AC94", Offset = "0x1F8AC94", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipelineManager), Member = "PrepareRenderPipeline", MemberParameters = new object[] { typeof(RenderPipelineAsset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableRenderContext), Member = "GetCameras", MemberParameters = new object[] { typeof(List<Camera>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipeline), Member = "InternalRenderWithRequests", MemberParameters = new object[]
		{
			typeof(ScriptableRenderContext),
			typeof(List<Camera>),
			typeof(List<Camera.RenderRequest>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipeline), Member = "InternalRender", MemberParameters = new object[]
		{
			typeof(ScriptableRenderContext),
			typeof(List<Camera>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, List<Camera.RenderRequest> renderRequests)
		{
			throw null;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002BD5 File Offset: 0x00000DD5
		[global::Cpp2ILInjected.Token(Token = "0x600057E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8AE4C", Offset = "0x1F8AE4C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "DoRenderLoop_Internal", MemberParameters = new object[]
		{
			typeof(RenderPipelineAsset),
			typeof(IntPtr),
			typeof(List<Camera.RenderRequest>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineAsset), Member = "OnValidate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipelineManager), Member = "HandleRenderPipelineChange", MemberParameters = new object[] { typeof(RenderPipelineAsset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipelineAsset), Member = "InternalCreatePipeline", ReturnType = typeof(RenderPipeline))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipelineManager), Member = "set_currentPipeline", MemberParameters = new object[] { typeof(RenderPipeline) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
		{
			throw null;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002BD8 File Offset: 0x00000DD8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600057F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B49C", Offset = "0x1F8B49C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static RenderPipelineManager()
		{
			throw null;
		}

		// Token: 0x0400043F RID: 1087
		[global::Cpp2ILInjected.Token(Token = "0x4000485")]
		internal static RenderPipelineAsset s_CurrentPipelineAsset;

		// Token: 0x04000440 RID: 1088
		[global::Cpp2ILInjected.Token(Token = "0x4000486")]
		private static List<Camera> s_Cameras;

		// Token: 0x04000441 RID: 1089
		[global::Cpp2ILInjected.Token(Token = "0x4000487")]
		private static string s_currentPipelineType;

		// Token: 0x04000442 RID: 1090
		[global::Cpp2ILInjected.Token(Token = "0x4000488")]
		private static string s_builtinPipelineName;

		// Token: 0x04000443 RID: 1091
		[global::Cpp2ILInjected.Token(Token = "0x4000489")]
		private static RenderPipeline s_currentPipeline;

		// Token: 0x04000444 RID: 1092
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400048A")]
		private static Action activeRenderPipelineTypeChanged;
	}
}
