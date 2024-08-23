﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Internal;

namespace Unity.Collections
{
	// Token: 0x02000013 RID: 19
	[NativeContainerSupportsDeallocateOnJobCompletion]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[DebuggerDisplay("Length = {Length}")]
	[NativeContainer]
	[DebuggerTypeProxy(typeof(NativeArrayDebugView<>))]
	[NativeContainerSupportsDeferredConvertListToArray]
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> where T : struct
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000206E File Offset: 0x0000026E
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000E")]
			[global::Cpp2ILInjected.Address(RVA = "0x17CBEF8", Offset = "0x17CBEF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000002 RID: 2
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000F")]
			[global::Cpp2ILInjected.Address(RVA = "0x17CBF00", Offset = "0x17CBF00", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[WriteAccessRequired]
			[global::Cpp2ILInjected.Token(Token = "0x6000010")]
			[global::Cpp2ILInjected.Address(RVA = "0x17CBF78", Offset = "0x17CBF78", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002077 File Offset: 0x00000277
		[WriteAccessRequired]
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CC010", Offset = "0x17CC010", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(Allocator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public unsafe void Dispose()
		{
			throw null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000207A File Offset: 0x0000027A
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CC0C4", Offset = "0x17CC0C4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeArray<>), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArray<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "Unity.Collections.NativeArray`1<T>&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NativeArray<T>.Enumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000207D File Offset: 0x0000027D
		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CC130", Offset = "0x17CC130", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArray<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "Unity.Collections.NativeArray`1<T>&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002080 File Offset: 0x00000280
		[global::Cpp2ILInjected.Token(Token = "0x6000014")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CC1C0", Offset = "0x17CC1C0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArray<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002083 File Offset: 0x00000283
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CC24C", Offset = "0x17CC24C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(NativeArray<T> other)
		{
			throw null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002086 File Offset: 0x00000286
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CC270", Offset = "0x17CC270", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002089 File Offset: 0x00000289
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CC348", Offset = "0x17CC348", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000208C File Offset: 0x0000028C
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CC360", Offset = "0x17CC360", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(GCHandleType)
		}, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public unsafe static void Copy(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			throw null;
		}

		// Token: 0x0400003C RID: 60
		[NativeDisableUnsafePtrRestriction]
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal unsafe void* m_Buffer;

		// Token: 0x0400003D RID: 61
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal int m_Length;

		// Token: 0x0400003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal Allocator m_AllocatorLabel;

		// Token: 0x02000161 RID: 353
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x2000015")]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x060006B6 RID: 1718 RVA: 0x00002F80 File Offset: 0x00001180
			[global::Cpp2ILInjected.Token(Token = "0x6000019")]
			[global::Cpp2ILInjected.Address(RVA = "0x1644B9C", Offset = "0x1644B9C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeArray<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeArray<>), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			public Enumerator(ref NativeArray<T> array)
			{
				throw null;
			}

			// Token: 0x060006B7 RID: 1719 RVA: 0x00002F83 File Offset: 0x00001183
			[global::Cpp2ILInjected.Token(Token = "0x600001A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1644BB0", Offset = "0x1644BB0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x060006B8 RID: 1720 RVA: 0x00002F86 File Offset: 0x00001186
			[global::Cpp2ILInjected.Token(Token = "0x600001B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1644BB4", Offset = "0x1644BB4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060006B9 RID: 1721 RVA: 0x00002F89 File Offset: 0x00001189
			[global::Cpp2ILInjected.Token(Token = "0x600001C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1644BD4", Offset = "0x1644BD4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x060006BA RID: 1722 RVA: 0x00002F8C File Offset: 0x0000118C
			[global::Cpp2ILInjected.Token(Token = "0x17000003")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600001D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1644BE0", Offset = "0x1644BE0", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x060006BB RID: 1723 RVA: 0x00002F8F File Offset: 0x0000118F
			[global::Cpp2ILInjected.Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600001E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1644BFC", Offset = "0x1644BFC", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04000630 RID: 1584
			[global::Cpp2ILInjected.Token(Token = "0x400003F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private NativeArray<T> m_Array;

			// Token: 0x04000631 RID: 1585
			[global::Cpp2ILInjected.Token(Token = "0x4000040")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int m_Index;
		}
	}
}
