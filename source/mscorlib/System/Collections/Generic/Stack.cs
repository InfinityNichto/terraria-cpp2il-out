﻿using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x0200052B RID: 1323
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(StackDebugView<>))]
	[global::System.Runtime.CompilerServices.TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000647")]
	[global::System.Serializable]
	public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x06002C99 RID: 11417 RVA: 0x0001C12D File Offset: 0x0001A32D
		[global::Cpp2ILInjected.Token(Token = "0x600311C")]
		[global::Cpp2ILInjected.Address(RVA = "0x186F020", Offset = "0x186F020", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.DtdParser", Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			"System.Xml.Schema.ParticleContentValidator",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.InteriorNode", Member = "ExpandTreeNoRecursive", MemberParameters = new object[] { "System.Xml.Schema.InteriorNode", "System.Xml.Schema.SymbolsDictionary", "System.Xml.Schema.Positions" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			"Newtonsoft.Json.JsonReader",
			"Newtonsoft.Json.Serialization.JsonArrayContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Stack()
		{
			throw null;
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x0001C130 File Offset: 0x0001A330
		[global::Cpp2ILInjected.Token(Token = "0x170007EB")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600311D")]
			[global::Cpp2ILInjected.Address(RVA = "0x186F05C", Offset = "0x186F05C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x0001C133 File Offset: 0x0001A333
		[global::Cpp2ILInjected.Token(Token = "0x170007EC")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x600311E")]
			[global::Cpp2ILInjected.Address(RVA = "0x186F064", Offset = "0x186F064", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x0001C136 File Offset: 0x0001A336
		[global::Cpp2ILInjected.Token(Token = "0x170007ED")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x600311F")]
			[global::Cpp2ILInjected.Address(RVA = "0x186F06C", Offset = "0x186F06C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x0001C139 File Offset: 0x0001A339
		[global::Cpp2ILInjected.Token(Token = "0x6003120")]
		[global::Cpp2ILInjected.Address(RVA = "0x186F0DC", Offset = "0x186F0DC", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Reverse", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x0001C13C File Offset: 0x0001A33C
		[global::Cpp2ILInjected.Token(Token = "0x6003121")]
		[global::Cpp2ILInjected.Address(RVA = "0x186F380", Offset = "0x186F380", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Stack`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x0001C13F File Offset: 0x0001A33F
		[global::Cpp2ILInjected.Token(Token = "0x6003122")]
		[global::Cpp2ILInjected.Address(RVA = "0x186F3E8", Offset = "0x186F3E8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Stack`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x0001C142 File Offset: 0x0001A342
		[global::Cpp2ILInjected.Token(Token = "0x6003123")]
		[global::Cpp2ILInjected.Address(RVA = "0x186F450", Offset = "0x186F450", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.DtdParser", Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			"System.Xml.Schema.ParticleContentValidator",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			"Newtonsoft.Json.JsonReader",
			"Newtonsoft.Json.Serialization.JsonArrayContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public T Peek()
		{
			throw null;
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x0001C145 File Offset: 0x0001A345
		[global::Cpp2ILInjected.Token(Token = "0x6003124")]
		[global::Cpp2ILInjected.Address(RVA = "0x186F498", Offset = "0x186F498", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.DtdParser", Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			"System.Xml.Schema.ParticleContentValidator",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.InteriorNode", Member = "ExpandTreeNoRecursive", MemberParameters = new object[] { "System.Xml.Schema.InteriorNode", "System.Xml.Schema.SymbolsDictionary", "System.Xml.Schema.Positions" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			"Newtonsoft.Json.JsonReader",
			"Newtonsoft.Json.Serialization.JsonArrayContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public T Pop()
		{
			throw null;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0001C148 File Offset: 0x0001A348
		[global::Cpp2ILInjected.Token(Token = "0x6003125")]
		[global::Cpp2ILInjected.Address(RVA = "0x186F4F8", Offset = "0x186F4F8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.DtdParser", Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			"System.Xml.Schema.ParticleContentValidator",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.InteriorNode", Member = "ExpandTreeNoRecursive", MemberParameters = new object[] { "System.Xml.Schema.InteriorNode", "System.Xml.Schema.SymbolsDictionary", "System.Xml.Schema.Positions" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			"Newtonsoft.Json.JsonReader",
			"Newtonsoft.Json.Serialization.JsonArrayContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Push(T item)
		{
			throw null;
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x0001C14B File Offset: 0x0001A34B
		[global::Cpp2ILInjected.Token(Token = "0x6003126")]
		[global::Cpp2ILInjected.Address(RVA = "0x186F53C", Offset = "0x186F53C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(8)]
		private void PushWithResize(T item)
		{
			throw null;
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x0001C14E File Offset: 0x0001A34E
		[global::Cpp2ILInjected.Token(Token = "0x6003127")]
		[global::Cpp2ILInjected.Address(RVA = "0x186F5A8", Offset = "0x186F5A8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ThrowForEmptyStack()
		{
			throw null;
		}

		// Token: 0x0400162E RID: 5678
		[global::Cpp2ILInjected.Token(Token = "0x4001A95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T[] _array;

		// Token: 0x0400162F RID: 5679
		[global::Cpp2ILInjected.Token(Token = "0x4001A96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x04001630 RID: 5680
		[global::Cpp2ILInjected.Token(Token = "0x4001A97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04001631 RID: 5681
		[global::Cpp2ILInjected.Token(Token = "0x4001A98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.NonSerialized]
		private object _syncRoot;

		// Token: 0x02000662 RID: 1634
		[global::Cpp2ILInjected.Token(Token = "0x2000648")]
		[global::System.Serializable]
		public struct Enumerator : IEnumerator<T>, global::System.IDisposable, IEnumerator
		{
			// Token: 0x06004347 RID: 17223 RVA: 0x00020429 File Offset: 0x0001E629
			[global::Cpp2ILInjected.Token(Token = "0x6003128")]
			[global::Cpp2ILInjected.Address(RVA = "0x1648A18", Offset = "0x1648A18", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stack<>), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stack<>), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			internal Enumerator(Stack<T> stack)
			{
				throw null;
			}

			// Token: 0x06004348 RID: 17224 RVA: 0x0002042C File Offset: 0x0001E62C
			[global::Cpp2ILInjected.Token(Token = "0x6003129")]
			[global::Cpp2ILInjected.Address(RVA = "0x1648A30", Offset = "0x1648A30", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06004349 RID: 17225 RVA: 0x0002042F File Offset: 0x0001E62F
			[global::Cpp2ILInjected.Token(Token = "0x600312A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1648A3C", Offset = "0x1648A3C", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170007ED RID: 2029
			// (get) Token: 0x0600434A RID: 17226 RVA: 0x00020432 File Offset: 0x0001E632
			[global::Cpp2ILInjected.Token(Token = "0x170007EE")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600312B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1648B00", Offset = "0x1648B00", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stack<>.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>.Enumerator), Member = "ThrowEnumerationNotStartedOrEnded", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600434B RID: 17227 RVA: 0x00020435 File Offset: 0x0001E635
			[global::Cpp2ILInjected.Token(Token = "0x600312C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1648B34", Offset = "0x1648B34", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stack<>.Enumerator), Member = "get_Current", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void ThrowEnumerationNotStartedOrEnded()
			{
				throw null;
			}

			// Token: 0x170007EE RID: 2030
			// (get) Token: 0x0600434C RID: 17228 RVA: 0x00020438 File Offset: 0x0001E638
			[global::Cpp2ILInjected.Token(Token = "0x170007EF")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600312D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1648B98", Offset = "0x1648B98", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>.Enumerator), Member = "get_Current", ReturnType = "T")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600434D RID: 17229 RVA: 0x0002043B File Offset: 0x0001E63B
			[global::Cpp2ILInjected.Token(Token = "0x600312E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1648BCC", Offset = "0x1648BCC", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x04001ADE RID: 6878
			[global::Cpp2ILInjected.Token(Token = "0x4001A99")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly Stack<T> _stack;

			// Token: 0x04001ADF RID: 6879
			[global::Cpp2ILInjected.Token(Token = "0x4001A9A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly int _version;

			// Token: 0x04001AE0 RID: 6880
			[global::Cpp2ILInjected.Token(Token = "0x4001A9B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001AE1 RID: 6881
			[global::Cpp2ILInjected.Token(Token = "0x4001A9C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T _currentElement;
		}
	}
}
