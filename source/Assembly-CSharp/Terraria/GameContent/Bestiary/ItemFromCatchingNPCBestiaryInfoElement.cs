﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200063E RID: 1598
	[global::Cpp2ILInjected.Token(Token = "0x2000961")]
	public class ItemFromCatchingNPCBestiaryInfoElement : IItemBestiaryInfoElement, IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x06003EF6 RID: 16118 RVA: 0x0002D3D4 File Offset: 0x0002B5D4
		[global::Cpp2ILInjected.Token(Token = "0x600480A")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DD40", Offset = "0x81DD40", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemFromCatchingNPCBestiaryInfoElement(int itemId)
		{
			throw null;
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0002D3D7 File Offset: 0x0002B5D7
		[global::Cpp2ILInjected.Token(Token = "0x600480B")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DD68", Offset = "0x81DD68", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryInfoLine<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0002D3DA File Offset: 0x0002B5DA
		[global::Cpp2ILInjected.Token(Token = "0x600480C")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DE34", Offset = "0x81DE34", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C82 RID: 27778
		[global::Cpp2ILInjected.Token(Token = "0x40083A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _itemType;
	}
}
