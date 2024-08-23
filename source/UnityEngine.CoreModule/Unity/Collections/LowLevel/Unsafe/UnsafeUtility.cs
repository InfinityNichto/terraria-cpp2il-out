﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200001C RID: 28
	[StaticAccessor("UnsafeUtility", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public static class UnsafeUtility
	{
		// Token: 0x06000017 RID: 23 RVA: 0x0000208F File Offset: 0x0000028F
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3414", Offset = "0x15A3414", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			throw null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002092 File Offset: 0x00000292
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A34D4", Offset = "0x15A34D4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
			throw null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002095 File Offset: 0x00000295
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3474", Offset = "0x15A3474", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int SizeOf<T>() where T : struct
		{
			throw null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002098 File Offset: 0x00000298
		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A054", Offset = "0x1F6A054", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnsafeUtility), Member = "GetReasonForTypeNonBlittableImpl", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnsafeUtility), Member = "IsArrayBlittable", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsBlittableValueType(Type t)
		{
			throw null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000209B File Offset: 0x0000029B
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A0E8", Offset = "0x1F6A0E8", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnsafeUtility), Member = "GetReasonForTypeNonBlittableImpl", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnsafeUtility), Member = "GetReasonForArrayNonBlittable", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "IsBlittableValueType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForTypeNonBlittableImpl", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string GetReasonForTypeNonBlittableImpl(Type t, string name)
		{
			throw null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000209E File Offset: 0x0000029E
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A294", Offset = "0x1F6A294", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "IsBlittableValueType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		internal static bool IsArrayBlittable(Array arr)
		{
			throw null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020A1 File Offset: 0x000002A1
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A2B8", Offset = "0x1F6A2B8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForTypeNonBlittableImpl", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(string))]
		internal static string GetReasonForArrayNonBlittable(Array arr)
		{
			throw null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020A4 File Offset: 0x000002A4
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A339C", Offset = "0x15A339C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TileData", Member = "Allocate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int AlignOf<T>() where T : struct
		{
			throw null;
		}

		// Token: 0x0600001F RID: 31
		[ThreadSafe(ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A2F4", Offset = "0x1F6A2F4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TileData", Member = "Allocate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.WorldMap", Member = "Allocate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public unsafe static extern void* Malloc(long size, int alignment, Allocator allocator);

		// Token: 0x06000020 RID: 32
		[ThreadSafe(ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A348", Offset = "0x1F6A348", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TileData", Member = "Allocate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.WorldMap", Member = "Allocate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeArray<>), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public unsafe static extern void Free(void* memory, Allocator allocator);

		// Token: 0x06000021 RID: 33
		[ThreadSafe(ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A38C", Offset = "0x1F6A38C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeArray<>), Member = "Copy", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			"Unity.Collections.NativeArray`1<T>",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public unsafe static extern void MemCpy(void* destination, void* source, long size);

		// Token: 0x06000022 RID: 34
		[ThreadSafe(ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A3E0", Offset = "0x1F6A3E0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public unsafe static extern void MemSet(void* destination, byte value, long size);

		// Token: 0x06000023 RID: 35 RVA: 0x000020A7 File Offset: 0x000002A7
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A434", Offset = "0x1F6A434", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TileData", Member = "Allocate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe static void MemClear(void* destination, long size)
		{
			throw null;
		}

		// Token: 0x06000024 RID: 36
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A0AC", Offset = "0x1F6A0AC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsBlittable(Type type);

		// Token: 0x02000162 RID: 354
		[global::Cpp2ILInjected.Token(Token = "0x200001F")]
		private struct AlignOfHelper<T> where T : struct
		{
			// Token: 0x04000632 RID: 1586
			[global::Cpp2ILInjected.Token(Token = "0x4000048")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte dummy;

			// Token: 0x04000633 RID: 1587
			[global::Cpp2ILInjected.Token(Token = "0x4000049")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public T data;
		}
	}
}