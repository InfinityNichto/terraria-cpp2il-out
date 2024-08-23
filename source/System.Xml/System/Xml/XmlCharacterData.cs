﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000048 RID: 72
	[global::Cpp2ILInjected.Token(Token = "0x2000065")]
	public abstract class XmlCharacterData : XmlLinkedNode
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x00003B39 File Offset: 0x00001D39
		[global::Cpp2ILInjected.Token(Token = "0x600049C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D1CC", Offset = "0x1D8D1CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSignificantWhitespace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlText), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWhitespace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLinkedNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		protected internal XmlCharacterData(string data, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00003B3C File Offset: 0x00001D3C
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00003B3F File Offset: 0x00001D3F
		[global::Cpp2ILInjected.Token(Token = "0x170000FB")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D310", Offset = "0x1D8D310", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600049E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D320", Offset = "0x1D8D320", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00003B42 File Offset: 0x00001D42
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00003B45 File Offset: 0x00001D45
		[global::Cpp2ILInjected.Token(Token = "0x170000FC")]
		public override string InnerText
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D330", Offset = "0x1D8D330", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D33C", Offset = "0x1D8D33C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00003B48 File Offset: 0x00001D48
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00003B4B File Offset: 0x00001D4B
		[global::Cpp2ILInjected.Token(Token = "0x170000FD")]
		public virtual string Data
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D348", Offset = "0x1D8D348", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D39C", Offset = "0x1D8D39C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00003B4E File Offset: 0x00001D4E
		[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D43C", Offset = "0x1D8D43C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSignificantWhitespace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSignificantWhitespace), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWhitespace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWhitespace), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		internal bool CheckOnData(string data)
		{
			throw null;
		}

		// Token: 0x04000195 RID: 405
		[global::Cpp2ILInjected.Token(Token = "0x400028F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string data;
	}
}
