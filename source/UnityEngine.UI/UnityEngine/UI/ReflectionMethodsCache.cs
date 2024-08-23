﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003C RID: 60
	[global::Cpp2ILInjected.Token(Token = "0x2000078")]
	internal class ReflectionMethodsCache
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x00002D9A File Offset: 0x00000F9A
		[global::Cpp2ILInjected.Token(Token = "0x60004F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDF030", Offset = "0x1FDF030", Length = "0xAE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionMethodsCache), Member = "get_Singleton", ReturnType = typeof(ReflectionMethodsCache))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodInfo)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 71)]
		public ReflectionMethodsCache()
		{
			throw null;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00002D9D File Offset: 0x00000F9D
		[global::Cpp2ILInjected.Token(Token = "0x17000151")]
		public static ReflectionMethodsCache Singleton
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDFB18", Offset = "0x1FDFB18", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new object[]
			{
				typeof(PointerEventData),
				typeof(List<RaycastResult>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Physics2DRaycaster), Member = "Raycast", MemberParameters = new object[]
			{
				typeof(PointerEventData),
				typeof(List<RaycastResult>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PhysicsRaycaster), Member = "Raycast", MemberParameters = new object[]
			{
				typeof(PointerEventData),
				typeof(List<RaycastResult>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionMethodsCache), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400017E RID: 382
		[global::Cpp2ILInjected.Token(Token = "0x4000257")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ReflectionMethodsCache.Raycast3DCallback raycast3D;

		// Token: 0x0400017F RID: 383
		[global::Cpp2ILInjected.Token(Token = "0x4000258")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ReflectionMethodsCache.RaycastAllCallback raycast3DAll;

		// Token: 0x04000180 RID: 384
		[global::Cpp2ILInjected.Token(Token = "0x4000259")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc;

		// Token: 0x04000181 RID: 385
		[global::Cpp2ILInjected.Token(Token = "0x400025A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public ReflectionMethodsCache.Raycast2DCallback raycast2D;

		// Token: 0x04000182 RID: 386
		[global::Cpp2ILInjected.Token(Token = "0x400025B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll;

		// Token: 0x04000183 RID: 387
		[global::Cpp2ILInjected.Token(Token = "0x400025C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;

		// Token: 0x04000184 RID: 388
		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		private static ReflectionMethodsCache s_ReflectionMethodsCache;

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x060006CE RID: 1742
		[global::Cpp2ILInjected.Token(Token = "0x2000079")]
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x060006D2 RID: 1746
		[global::Cpp2ILInjected.Token(Token = "0x200007A")]
		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x060006D6 RID: 1750
		[global::Cpp2ILInjected.Token(Token = "0x200007B")]
		public delegate int GetRaycastNonAllocCallback(Ray r, RaycastHit[] results, float f, int i);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x060006DA RID: 1754
		[global::Cpp2ILInjected.Token(Token = "0x200007C")]
		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x060006DE RID: 1758
		[global::Cpp2ILInjected.Token(Token = "0x200007D")]
		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x060006E2 RID: 1762
		[global::Cpp2ILInjected.Token(Token = "0x200007E")]
		public delegate int GetRayIntersectionAllNonAllocCallback(Ray r, RaycastHit2D[] results, float f, int i);
	}
}
