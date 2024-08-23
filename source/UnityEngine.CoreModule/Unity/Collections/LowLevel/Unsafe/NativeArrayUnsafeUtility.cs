﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200001D RID: 29
	[global::Cpp2ILInjected.Token(Token = "0x2000020")]
	public static class NativeArrayUnsafeUtility
	{
		// Token: 0x06000025 RID: 37 RVA: 0x000020AA File Offset: 0x000002AA
		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593A3C", Offset = "0x1593A3C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BatchRendererGroup), Member = "InvokeOnPerformCulling", MemberParameters = new object[]
		{
			typeof(BatchRendererGroup),
			typeof(ref BatchRendererCullingOutput),
			typeof(ref LODParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public unsafe static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) where T : struct
		{
			throw null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020AD File Offset: 0x000002AD
		[global::Cpp2ILInjected.Token(Token = "0x600002E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593A90", Offset = "0x1593A90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMap", Member = "ClearMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMap", Member = "DrawToMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMap", Member = "ApplySection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMap", Member = "DrawToMap_Section", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public unsafe static void* GetUnsafePtr<T>(this NativeArray<T> nativeArray) where T : struct
		{
			throw null;
		}
	}
}
