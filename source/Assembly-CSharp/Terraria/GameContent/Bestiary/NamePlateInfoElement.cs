﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000641 RID: 1601
	[global::Cpp2ILInjected.Token(Token = "0x2000966")]
	public class NamePlateInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x06003EFF RID: 16127 RVA: 0x0002D3EF File Offset: 0x0002B5EF
		[global::Cpp2ILInjected.Token(Token = "0x6004817")]
		[global::Cpp2ILInjected.Address(RVA = "0x8199B8", Offset = "0x8199B8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt_NameOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NamePlateInfoElement(string languageKey, int npcNetId)
		{
			throw null;
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x0002D3F2 File Offset: 0x0002B5F2
		[global::Cpp2ILInjected.Token(Token = "0x6004818")]
		[global::Cpp2ILInjected.Address(RVA = "0x81E8A8", Offset = "0x81E8A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public string GetName()
		{
			throw null;
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x0002D3F5 File Offset: 0x0002B5F5
		[global::Cpp2ILInjected.Token(Token = "0x6004819")]
		[global::Cpp2ILInjected.Address(RVA = "0x81E8B4", Offset = "0x81E8B4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x0002D3F8 File Offset: 0x0002B5F8
		[global::Cpp2ILInjected.Token(Token = "0x600481A")]
		[global::Cpp2ILInjected.Address(RVA = "0x81EA24", Offset = "0x81EA24", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C87 RID: 27783
		[global::Cpp2ILInjected.Token(Token = "0x40083AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _key;

		// Token: 0x04006C88 RID: 27784
		[global::Cpp2ILInjected.Token(Token = "0x40083AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _npcNetId;
	}
}