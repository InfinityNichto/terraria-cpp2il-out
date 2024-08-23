﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000008 RID: 8
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public class XDocument : XContainer
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000020F2 File Offset: 0x000002F2
		[global::Cpp2ILInjected.Token(Token = "0x600003F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6BF9C", Offset = "0x1D6BF9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XDocument()
		{
			throw null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020F5 File Offset: 0x000002F5
		[global::Cpp2ILInjected.Token(Token = "0x6000040")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6BFA4", Offset = "0x1D6BFA4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocument), Member = "CloneNode", ReturnType = typeof(XNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = ".ctor", MemberParameters = new object[] { typeof(XContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDeclaration), Member = ".ctor", MemberParameters = new object[] { typeof(XDeclaration) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XDocument(XDocument other)
		{
			throw null;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000020F8 File Offset: 0x000002F8
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000020FB File Offset: 0x000002FB
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		public XDeclaration Declaration
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000041")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C014", Offset = "0x1D6C014", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000042")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C01C", Offset = "0x1D6C01C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000020FE File Offset: 0x000002FE
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000043")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C024", Offset = "0x1D6C024", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002101 File Offset: 0x00000301
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		public XElement Root
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000044")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C02C", Offset = "0x1D6C02C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "get_DocumentElement", ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocument), Member = "GetFirstNode", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002104 File Offset: 0x00000304
		[global::Cpp2ILInjected.Token(Token = "0x6000045")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C074", Offset = "0x1D6C074", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = "WriteContentTo", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void WriteTo(XmlWriter writer)
		{
			throw null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002107 File Offset: 0x00000307
		[global::Cpp2ILInjected.Token(Token = "0x6000046")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C1A0", Offset = "0x1D6C1A0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override void AddAttribute(XAttribute a)
		{
			throw null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000210A File Offset: 0x0000030A
		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C1EC", Offset = "0x1D6C1EC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000210D File Offset: 0x0000030D
		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C238", Offset = "0x1D6C238", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocument), Member = ".ctor", MemberParameters = new object[] { typeof(XDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XNode CloneNode()
		{
			throw null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002110 File Offset: 0x00000310
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A479C", Offset = "0x15A479C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocument), Member = "get_Root", ReturnType = typeof(XElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private T GetFirstNode<T>() where T : XNode
		{
			throw null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002113 File Offset: 0x00000313
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C290", Offset = "0x1D6C290", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocument), Member = "ValidateString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal static bool IsWhitespace(string s)
		{
			throw null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002116 File Offset: 0x00000316
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C314", Offset = "0x1D6C314", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal override void ValidateNode(XNode node, XNode previous)
		{
			throw null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002119 File Offset: 0x00000319
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C4AC", Offset = "0x1D6C4AC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
		{
			throw null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000211C File Offset: 0x0000031C
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C5C4", Offset = "0x1D6C5C4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocument), Member = "IsWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override void ValidateString(string s)
		{
			throw null;
		}

		// Token: 0x04000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XDeclaration _declaration;
	}
}