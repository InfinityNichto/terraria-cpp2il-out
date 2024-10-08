﻿using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.XmlConfiguration
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
	public sealed class XmlReaderSection
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001EE")]
		internal static bool ProhibitDefaultUrlResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB3ACC", Offset = "0x1DB3ACC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsResolverNull", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new object[]
			{
				typeof(IDtdEntityInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = "System.Xml.XmlTextReaderImpl.EntityType")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001EF")]
		internal static bool CollapseWhiteSpaceIntoEmptyString
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DA6CE8", Offset = "0x1DA6CE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
