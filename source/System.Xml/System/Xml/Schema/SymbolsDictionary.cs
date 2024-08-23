﻿using System;
using System.Collections;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200009B RID: 155
	[DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x20000C5")]
	internal class SymbolsDictionary
	{
		// Token: 0x06000784 RID: 1924 RVA: 0x000044F0 File Offset: 0x000026F0
		[global::Cpp2ILInjected.Token(Token = "0x6000812")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB44F0", Offset = "0x1DB44F0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public SymbolsDictionary()
		{
			throw null;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000044F3 File Offset: 0x000026F3
		[global::Cpp2ILInjected.Token(Token = "0x170001F3")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000813")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB4590", Offset = "0x1DB4590", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000044F6 File Offset: 0x000026F6
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x000044F9 File Offset: 0x000026F9
		[global::Cpp2ILInjected.Token(Token = "0x170001F4")]
		public bool IsUpaEnforced
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000814")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB459C", Offset = "0x1DB459C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000815")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB45A4", Offset = "0x1DB45A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000044FC File Offset: 0x000026FC
		[global::Cpp2ILInjected.Token(Token = "0x6000816")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB45B0", Offset = "0x1DB45B0", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int AddName(XmlQualifiedName name, object particle)
		{
			throw null;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000044FF File Offset: 0x000026FF
		[global::Cpp2ILInjected.Token(Token = "0x6000817")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB46D0", Offset = "0x1DB46D0", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "AddNamespaceList", MemberParameters = new object[]
		{
			typeof(NamespaceList),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymbolsDictionary), Member = "AddWildcard", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamespaceList), Member = "get_Enumerate", ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal)
		{
			throw null;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00004502 File Offset: 0x00002702
		[global::Cpp2ILInjected.Token(Token = "0x6000818")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB4A54", Offset = "0x1DB4A54", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new object[]
		{
			typeof(NamespaceList),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void AddWildcard(string wildcard, object particle)
		{
			throw null;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00004505 File Offset: 0x00002705
		[global::Cpp2ILInjected.Token(Token = "0x6000819")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB4BA8", Offset = "0x1DB4BA8", Length = "0x72C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamespaceListNode), Member = "GetResolvedSymbols", MemberParameters = new object[] { typeof(SymbolsDictionary) }, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(XmlQualifiedName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamespaceList), Member = "Allows", MemberParameters = new object[] { typeof(XmlQualifiedName) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		public ICollection GetNamespaceListSymbols(NamespaceList list)
		{
			throw null;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00004508 File Offset: 0x00002708
		[global::Cpp2ILInjected.Token(Token = "0x600081A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB52D4", Offset = "0x1DB52D4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Exists(XmlQualifiedName name)
		{
			throw null;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0000450B File Offset: 0x0000270B
		[global::Cpp2ILInjected.Token(Token = "0x600081B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB52FC", Offset = "0x1DB52FC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object GetParticle(int symbol)
		{
			throw null;
		}

		// Token: 0x040002A8 RID: 680
		[global::Cpp2ILInjected.Token(Token = "0x400041A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int last;

		// Token: 0x040002A9 RID: 681
		[global::Cpp2ILInjected.Token(Token = "0x400041B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Hashtable names;

		// Token: 0x040002AA RID: 682
		[global::Cpp2ILInjected.Token(Token = "0x400041C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Hashtable wildcards;

		// Token: 0x040002AB RID: 683
		[global::Cpp2ILInjected.Token(Token = "0x400041D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ArrayList particles;

		// Token: 0x040002AC RID: 684
		[global::Cpp2ILInjected.Token(Token = "0x400041E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private object particleLast;

		// Token: 0x040002AD RID: 685
		[global::Cpp2ILInjected.Token(Token = "0x400041F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool isUpaEnforced;
	}
}
