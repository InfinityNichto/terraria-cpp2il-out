﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000532 RID: 1330
	[global::Cpp2ILInjected.Token(Token = "0x2000650")]
	internal class ArraySortHelper<TKey, TValue>
	{
		// Token: 0x06002CCF RID: 11471 RVA: 0x0001C1CF File Offset: 0x0001A3CF
		[global::Cpp2ILInjected.Token(Token = "0x6003160")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F25DC", Offset = "0x17F25DC", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x0001C1D2 File Offset: 0x0001A3D2
		[global::Cpp2ILInjected.Token(Token = "0x6003161")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F27C8", Offset = "0x17F27C8", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b)
		{
			throw null;
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x0001C1D5 File Offset: 0x0001A3D5
		[global::Cpp2ILInjected.Token(Token = "0x6003162")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F28DC", Offset = "0x17F28DC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void Swap(TKey[] keys, TValue[] values, int i, int j)
		{
			throw null;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
		[global::Cpp2ILInjected.Token(Token = "0x6003163")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F2910", Offset = "0x17F2910", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x0001C1DB File Offset: 0x0001A3DB
		[global::Cpp2ILInjected.Token(Token = "0x6003164")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F2A1C", Offset = "0x17F2A1C", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x0001C1DE File Offset: 0x0001A3DE
		[global::Cpp2ILInjected.Token(Token = "0x6003165")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F2EEC", Offset = "0x17F2EEC", Length = "0x470")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x0001C1E1 File Offset: 0x0001A3E1
		[global::Cpp2ILInjected.Token(Token = "0x6003166")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F335C", Offset = "0x17F335C", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0001C1E4 File Offset: 0x0001A3E4
		[global::Cpp2ILInjected.Token(Token = "0x6003167")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F3564", Offset = "0x17F3564", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0001C1E7 File Offset: 0x0001A3E7
		[global::Cpp2ILInjected.Token(Token = "0x6003168")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F378C", Offset = "0x17F378C", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x0001C1EA File Offset: 0x0001A3EA
		[global::Cpp2ILInjected.Token(Token = "0x170007F7")]
		public static ArraySortHelper<TKey, TValue> Default
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003169")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F38F4", Offset = "0x17F38F4", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x0001C1ED File Offset: 0x0001A3ED
		[global::Cpp2ILInjected.Token(Token = "0x600316A")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F3960", Offset = "0x17F3960", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArraySortHelper()
		{
			throw null;
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600316B")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F3968", Offset = "0x17F3968", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		static ArraySortHelper()
		{
			throw null;
		}

		// Token: 0x04001637 RID: 5687
		[global::Cpp2ILInjected.Token(Token = "0x4001AA6")]
		private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper;
	}
}
