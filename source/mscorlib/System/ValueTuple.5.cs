﻿using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000ED RID: 237
	[global::Cpp2ILInjected.Token(Token = "0x200011F")]
	[global::System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4> : global::System.IEquatable<global::System.ValueTuple<T1, T2, T3, T4>>, global::System.Collections.IStructuralEquatable, global::System.Collections.IStructuralComparable, global::System.IComparable, global::System.IComparable<global::System.ValueTuple<T1, T2, T3, T4>>, global::System.IValueTupleInternal, global::System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000AA0 RID: 2720 RVA: 0x000163DC File Offset: 0x000145DC
		[global::Cpp2ILInjected.Token(Token = "0x6000B48")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B77B8", Offset = "0x18B77B8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "CheckFinalStatus", MemberParameters = new object[] { "System.Net.HttpWebResponse" }, ReturnType = "System.ValueTuple`4<Boolean, Boolean, Task`1<BufferOffsetSize>, WebException>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			throw null;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000163DF File Offset: 0x000145DF
		[global::Cpp2ILInjected.Token(Token = "0x6000B49")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B77D0", Offset = "0x18B77D0", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , >), Member = "Equals", MemberParameters = new object[] { "System.ValueTuple`4<T1, T2, T3, T4>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x000163E2 File Offset: 0x000145E2
		[global::Cpp2ILInjected.Token(Token = "0x6000B4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B78D0", Offset = "0x18B78D0", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , >), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public bool Equals(global::System.ValueTuple<T1, T2, T3, T4> other)
		{
			throw null;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000163E5 File Offset: 0x000145E5
		[global::Cpp2ILInjected.Token(Token = "0x6000B4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B7A9C", Offset = "0x18B7A9C", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000163E8 File Offset: 0x000145E8
		[global::Cpp2ILInjected.Token(Token = "0x6000B4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B7E20", Offset = "0x18B7E20", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , >), Member = "CompareTo", MemberParameters = new object[] { "System.ValueTuple`4<T1, T2, T3, T4>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private int System.IComparable.CompareTo(object other)
		{
			throw null;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000163EB File Offset: 0x000145EB
		[global::Cpp2ILInjected.Token(Token = "0x6000B4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B7FC0", Offset = "0x18B7FC0", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , >), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public int CompareTo(global::System.ValueTuple<T1, T2, T3, T4> other)
		{
			throw null;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000163EE File Offset: 0x000145EE
		[global::Cpp2ILInjected.Token(Token = "0x6000B4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B8188", Offset = "0x18B8188", Length = "0x42C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000163F1 File Offset: 0x000145F1
		[global::Cpp2ILInjected.Token(Token = "0x6000B4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B85B4", Offset = "0x18B85B4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000163F4 File Offset: 0x000145F4
		[global::Cpp2ILInjected.Token(Token = "0x6000B50")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B8680", Offset = "0x18B8680", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000163F7 File Offset: 0x000145F7
		[global::Cpp2ILInjected.Token(Token = "0x6000B51")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B86C4", Offset = "0x18B86C4", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , >), Member = "System.IValueTupleInternal.GetHashCode", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private int GetHashCodeCore(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000163FA File Offset: 0x000145FA
		[global::Cpp2ILInjected.Token(Token = "0x6000B52")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B8940", Offset = "0x18B8940", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.IValueTupleInternal.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000163FD File Offset: 0x000145FD
		[global::Cpp2ILInjected.Token(Token = "0x6000B53")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B8984", Offset = "0x18B8984", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00016400 File Offset: 0x00014600
		[global::Cpp2ILInjected.Token(Token = "0x6000B54")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B8BD0", Offset = "0x18B8BD0", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private string System.IValueTupleInternal.ToStringEnd()
		{
			throw null;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00016403 File Offset: 0x00014603
		[global::Cpp2ILInjected.Token(Token = "0x170000F8")]
		private int System.Runtime.CompilerServices.ITuple.Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B55")]
			[global::Cpp2ILInjected.Address(RVA = "0x18B8DEC", Offset = "0x18B8DEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002B5 RID: 693
		[global::Cpp2ILInjected.Token(Token = "0x4000407")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x040002B6 RID: 694
		[global::Cpp2ILInjected.Token(Token = "0x4000408")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T2 Item2;

		// Token: 0x040002B7 RID: 695
		[global::Cpp2ILInjected.Token(Token = "0x4000409")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T3 Item3;

		// Token: 0x040002B8 RID: 696
		[global::Cpp2ILInjected.Token(Token = "0x400040A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T4 Item4;
	}
}
