﻿using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200009A RID: 154
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000CE")]
	public struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x06000700 RID: 1792 RVA: 0x00003503 File Offset: 0x00001703
		[global::Cpp2ILInjected.Token(Token = "0x60007A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1713054", Offset = "0x1713054", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "AsJEnumerable", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = "Newtonsoft.Json.Linq.IJEnumerable`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "Children", ReturnType = typeof(JEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JEnumerable<>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JEnumerable<>), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "PropertyValues", ReturnType = typeof(JEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "Children", MemberTypeParameters = new object[] { "T" }, ReturnType = "Newtonsoft.Json.Linq.JEnumerable`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public JEnumerable(IEnumerable<T> enumerable)
		{
			throw null;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00003506 File Offset: 0x00001706
		[global::Cpp2ILInjected.Token(Token = "0x60007A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x17130B4", Offset = "0x17130B4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.Extensions.<Values>d__11`2", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = "WriteTo", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonConverter[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JEnumerable<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JEnumerable<>), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public IEnumerator<T> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00003509 File Offset: 0x00001709
		[global::Cpp2ILInjected.Token(Token = "0x60007A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x17131E4", Offset = "0x17131E4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x17000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x17000176")]
		public IJEnumerable<JToken> this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713218", Offset = "0x1713218", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0000350F File Offset: 0x0000170F
		[global::Cpp2ILInjected.Token(Token = "0x60007AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1713330", Offset = "0x1713330", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		public bool Equals(JEnumerable<T> other)
		{
			throw null;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00003512 File Offset: 0x00001712
		[global::Cpp2ILInjected.Token(Token = "0x60007AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x171333C", Offset = "0x171333C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00003515 File Offset: 0x00001715
		[global::Cpp2ILInjected.Token(Token = "0x60007AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1713418", Offset = "0x1713418", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00003518 File Offset: 0x00001718
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60007AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1713430", Offset = "0x1713430", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static JEnumerable()
		{
			throw null;
		}

		// Token: 0x04000290 RID: 656
		[global::Cpp2ILInjected.Token(Token = "0x4000328")]
		public static readonly JEnumerable<T> Empty;

		// Token: 0x04000291 RID: 657
		[global::Cpp2ILInjected.Token(Token = "0x4000329")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly IEnumerable<T> _enumerable;
	}
}
