﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004E RID: 78
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200005F")]
	internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection
	{
		// Token: 0x06000319 RID: 793 RVA: 0x000029C6 File Offset: 0x00000BC6
		[global::Cpp2ILInjected.Token(Token = "0x600033B")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ED680", Offset = "0x18ED680", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public CollectionWrapper(IList list)
		{
			throw null;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000029C9 File Offset: 0x00000BC9
		[global::Cpp2ILInjected.Token(Token = "0x600033C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ED7A8", Offset = "0x18ED7A8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CollectionWrapper(ICollection<T> list)
		{
			throw null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000029CC File Offset: 0x00000BCC
		[global::Cpp2ILInjected.Token(Token = "0x600033D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ED814", Offset = "0x18ED814", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void Add(T item)
		{
			throw null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000029CF File Offset: 0x00000BCF
		[global::Cpp2ILInjected.Token(Token = "0x600033E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ED91C", Offset = "0x18ED91C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void Clear()
		{
			throw null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000029D2 File Offset: 0x00000BD2
		[global::Cpp2ILInjected.Token(Token = "0x600033F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EDA24", Offset = "0x18EDA24", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool Contains(T item)
		{
			throw null;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000029D5 File Offset: 0x00000BD5
		[global::Cpp2ILInjected.Token(Token = "0x6000340")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EDB3C", Offset = "0x18EDB3C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000029D8 File Offset: 0x00000BD8
		[global::Cpp2ILInjected.Token(Token = "0x1700009C")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000341")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EDC60", Offset = "0x18EDC60", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000320 RID: 800 RVA: 0x000029DB File Offset: 0x00000BDB
		[global::Cpp2ILInjected.Token(Token = "0x1700009D")]
		public virtual bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000342")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EDD6C", Offset = "0x18EDD6C", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000029DE File Offset: 0x00000BDE
		[global::Cpp2ILInjected.Token(Token = "0x6000343")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EDE74", Offset = "0x18EDE74", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual bool Remove(T item)
		{
			throw null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000029E1 File Offset: 0x00000BE1
		[global::Cpp2ILInjected.Token(Token = "0x6000344")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EE02C", Offset = "0x18EE02C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual IEnumerator<T> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000029E4 File Offset: 0x00000BE4
		[global::Cpp2ILInjected.Token(Token = "0x6000345")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EE128", Offset = "0x18EE128", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000029E7 File Offset: 0x00000BE7
		[global::Cpp2ILInjected.Token(Token = "0x6000346")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EE21C", Offset = "0x18EE21C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000029EA File Offset: 0x00000BEA
		[global::Cpp2ILInjected.Token(Token = "0x6000347")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EE2C8", Offset = "0x18EE2C8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000029ED File Offset: 0x00000BED
		[global::Cpp2ILInjected.Token(Token = "0x6000348")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EE36C", Offset = "0x18EE36C", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000029F0 File Offset: 0x00000BF0
		[global::Cpp2ILInjected.Token(Token = "0x6000349")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EE4E8", Offset = "0x18EE4E8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void System.Collections.IList.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000029F3 File Offset: 0x00000BF3
		[global::Cpp2ILInjected.Token(Token = "0x600034A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EE5DC", Offset = "0x18EE5DC", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000029F6 File Offset: 0x00000BF6
		[global::Cpp2ILInjected.Token(Token = "0x1700009E")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600034B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EE750", Offset = "0x18EE750", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000029F9 File Offset: 0x00000BF9
		[global::Cpp2ILInjected.Token(Token = "0x600034C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EE858", Offset = "0x18EE858", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000029FC File Offset: 0x00000BFC
		// (set) Token: 0x0600032C RID: 812 RVA: 0x000029FF File Offset: 0x00000BFF
		[global::Cpp2ILInjected.Token(Token = "0x1700009F")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x600034D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EE8F8", Offset = "0x18EE8F8", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600034E")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EE9E8", Offset = "0x18EE9E8", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002A02 File Offset: 0x00000C02
		[global::Cpp2ILInjected.Token(Token = "0x600034F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EEB5C", Offset = "0x18EEB5C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00002A05 File Offset: 0x00000C05
		[global::Cpp2ILInjected.Token(Token = "0x170000A0")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000350")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EEBE0", Offset = "0x18EEBE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00002A08 File Offset: 0x00000C08
		[global::Cpp2ILInjected.Token(Token = "0x170000A1")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000351")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EEBE8", Offset = "0x18EEBE8", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002A0B File Offset: 0x00000C0B
		[global::Cpp2ILInjected.Token(Token = "0x6000352")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EEC5C", Offset = "0x18EEC5C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void VerifyValueType(object value)
		{
			throw null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002A0E File Offset: 0x00000C0E
		[global::Cpp2ILInjected.Token(Token = "0x6000353")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EED8C", Offset = "0x18EED8C", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsValueType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool IsCompatibleObject(object value)
		{
			throw null;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00002A11 File Offset: 0x00000C11
		[global::Cpp2ILInjected.Token(Token = "0x170000A2")]
		public object UnderlyingCollection
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000354")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EEED4", Offset = "0x18EEED4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040001A6 RID: 422
		[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly IList _list;

		// Token: 0x040001A7 RID: 423
		[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly ICollection<T> _genericCollection;

		// Token: 0x040001A8 RID: 424
		[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object _syncRoot;
	}
}
