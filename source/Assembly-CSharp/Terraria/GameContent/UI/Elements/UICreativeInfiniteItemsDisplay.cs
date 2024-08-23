﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.GameContent.UI.States;
using Terraria.Graphics.Renderers;
using Terraria.Localization;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006CB RID: 1739
	[global::Cpp2ILInjected.Token(Token = "0x2000AAE")]
	public class UICreativeInfiniteItemsDisplay : UIElement
	{
		// Token: 0x06004431 RID: 17457 RVA: 0x0002E334 File Offset: 0x0002C534
		[global::Cpp2ILInjected.Token(Token = "0x6005083")]
		[global::Cpp2ILInjected.Address(RVA = "0x910660", Offset = "0x910660", Length = "0xA48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Weapon), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Armor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Vanity), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.BuildingBlock), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Furniture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Accessories), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.MiscAccessories), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Consumables), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Tools), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Materials), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.MiscFallback), Member = ".ctor", MemberParameters = new object[] { typeof(List<IItemEntryFilter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "AddFilters", MemberParameters = new object[] { "System.Collections.Generic.List`1<U>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.BySearch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "SetSearchFilterObject", MemberTypeParameters = new object[] { "Z" }, MemberParameters = new object[] { "Z" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntrySorter<, >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByCreativeSortingId), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.Alphabetical), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntrySorter<, >), Member = "AddSortSteps", MemberParameters = new object[] { "System.Collections.Generic.List`1<TStepType>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 63)]
		public UICreativeInfiniteItemsDisplay(UIState uiStateThatHoldsThis)
		{
			throw null;
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x0002E337 File Offset: 0x0002C537
		[global::Cpp2ILInjected.Token(Token = "0x6005084")]
		[global::Cpp2ILInjected.Address(RVA = "0x9110A8", Offset = "0x9110A8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void BuildPage()
		{
			throw null;
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x0002E33A File Offset: 0x0002C53A
		[global::Cpp2ILInjected.Token(Token = "0x6005085")]
		[global::Cpp2ILInjected.Address(RVA = "0x912340", Offset = "0x912340", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Hover_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x0002E33D File Offset: 0x0002C53D
		[global::Cpp2ILInjected.Token(Token = "0x6005086")]
		[global::Cpp2ILInjected.Address(RVA = "0x9123A8", Offset = "0x9123A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Hover_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x0002E340 File Offset: 0x0002C540
		[global::Cpp2ILInjected.Token(Token = "0x6005087")]
		[global::Cpp2ILInjected.Address(RVA = "0x9123B0", Offset = "0x9123B0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Hover_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x0002E343 File Offset: 0x0002C543
		[global::Cpp2ILInjected.Token(Token = "0x6005088")]
		[global::Cpp2ILInjected.Address(RVA = "0x9123BC", Offset = "0x9123BC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "SetBasicSizesForCreativeSacrificeOrInfinitesPanel", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static UIPanel CreateBasicPanel()
		{
			throw null;
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x0002E346 File Offset: 0x0002C546
		[global::Cpp2ILInjected.Token(Token = "0x6005089")]
		[global::Cpp2ILInjected.Address(RVA = "0x91247C", Offset = "0x91247C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "CreateBasicPanel", ReturnType = typeof(UIPanel))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddCogsForSacrificeMenu", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		private static void SetBasicSizesForCreativeSacrificeOrInfinitesPanel(UIElement element)
		{
			throw null;
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x0002E349 File Offset: 0x0002C549
		[global::Cpp2ILInjected.Token(Token = "0x600508A")]
		[global::Cpp2ILInjected.Address(RVA = "0x911238", Offset = "0x911238", Length = "0x4B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "CreateBasicPanel", ReturnType = typeof(UIPanel))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIDynamicItemCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIList), Member = "SetScrollbar", MemberParameters = new object[] { typeof(UIScrollbar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EntryFilterer<Item, IItemEntryFilter>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "add_OnClickingOption", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void BuildInfinitesMenuContents(UIElement totalContainer)
		{
			throw null;
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x0002E34C File Offset: 0x0002C54C
		[global::Cpp2ILInjected.Token(Token = "0x600508B")]
		[global::Cpp2ILInjected.Address(RVA = "0x9116F0", Offset = "0x9116F0", Length = "0xAE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "CreateBasicPanel", ReturnType = typeof(UIPanel))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddCogsForSacrificeMenu", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImage), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIParticleLayer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "ProvideItemSlotElement", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 55)]
		private void BuildSacrificeMenuContents(UIElement totalContainer)
		{
			throw null;
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x0002E34F File Offset: 0x0002C54F
		[global::Cpp2ILInjected.Token(Token = "0x600508C")]
		[global::Cpp2ILInjected.Address(RVA = "0x912EEC", Offset = "0x912EEC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void research_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x0002E352 File Offset: 0x0002C552
		[global::Cpp2ILInjected.Token(Token = "0x600508D")]
		[global::Cpp2ILInjected.Address(RVA = "0x912FA4", Offset = "0x912FA4", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x0002E355 File Offset: 0x0002C555
		[global::Cpp2ILInjected.Token(Token = "0x600508E")]
		[global::Cpp2ILInjected.Address(RVA = "0x9130DC", Offset = "0x9130DC", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x0002E358 File Offset: 0x0002C558
		[global::Cpp2ILInjected.Token(Token = "0x600508F")]
		[global::Cpp2ILInjected.Address(RVA = "0x912CC8", Offset = "0x912CC8", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "SetBasicSizesForCreativeSacrificeOrInfinitesPanel", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSymetricalCogsPair", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(Vector2),
			typeof(string),
			typeof(List<UIImage>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void AddCogsForSacrificeMenu(UIElement sacrificesContainer)
		{
			throw null;
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x0002E35B File Offset: 0x0002C55B
		[global::Cpp2ILInjected.Token(Token = "0x6005090")]
		[global::Cpp2ILInjected.Address(RVA = "0x913604", Offset = "0x913604", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void sacrificeWindow_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x0002E35E File Offset: 0x0002C55E
		[global::Cpp2ILInjected.Token(Token = "0x6005091")]
		[global::Cpp2ILInjected.Address(RVA = "0x913608", Offset = "0x913608", Length = "0x3C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "StopPlayingAnimation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "GetSacrificeAnimationProgress", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "OffsetRotationsForCogs", MemberParameters = new object[]
		{
			typeof(float),
			typeof(List<UIImage>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeSacrificeParticle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Rectangle?),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIParticleLayer), Member = "AddParticle", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = "SetFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void UpdateVisualFrame()
		{
			throw null;
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x0002E361 File Offset: 0x0002C561
		[global::Cpp2ILInjected.Token(Token = "0x6005092")]
		[global::Cpp2ILInjected.Address(RVA = "0x913A3C", Offset = "0x913A3C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateVisualFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static void OffsetRotationsForCogs(float rotationOffset, List<UIImage> cogsList)
		{
			throw null;
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x0002E364 File Offset: 0x0002C564
		[global::Cpp2ILInjected.Token(Token = "0x6005093")]
		[global::Cpp2ILInjected.Address(RVA = "0x9131F8", Offset = "0x9131F8", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddCogsForSacrificeMenu", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImage), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void AddSymetricalCogsPair(UIElement sacrificesContainer, Vector2 cogOFfsetsInPixels, string assetPath, List<UIImage> imagesList)
		{
			throw null;
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x0002E367 File Offset: 0x0002C567
		[global::Cpp2ILInjected.Token(Token = "0x6005094")]
		[global::Cpp2ILInjected.Address(RVA = "0x913AC0", Offset = "0x913AC0", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "GetSacrificeNumbers", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "ShouldDrawSacrificeArea", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void descriptionText_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x0002E36A File Offset: 0x0002C56A
		[global::Cpp2ILInjected.Token(Token = "0x6005095")]
		[global::Cpp2ILInjected.Address(RVA = "0x913CF0", Offset = "0x913CF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void sacrificeButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x0002E36D File Offset: 0x0002C56D
		[global::Cpp2ILInjected.Token(Token = "0x6005096")]
		[global::Cpp2ILInjected.Address(RVA = "0x913CF4", Offset = "0x913CF4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "SacrificeWhatsInResearchMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "GetSacrificeNumbers", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "SacrificeItem", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(CreativeUI.ItemSacrificeResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SacrificeWhatYouCan()
		{
			throw null;
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x0002E370 File Offset: 0x0002C570
		[global::Cpp2ILInjected.Token(Token = "0x6005097")]
		[global::Cpp2ILInjected.Address(RVA = "0x913DF4", Offset = "0x913DF4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "StopPlayingResearchAnimations", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIParticleLayer), Member = "ClearParticles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateVisualFrame", ReturnType = typeof(void))]
		public void StopPlayingAnimation()
		{
			throw null;
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x0002E373 File Offset: 0x0002C573
		[global::Cpp2ILInjected.Token(Token = "0x6005098")]
		[global::Cpp2ILInjected.Address(RVA = "0x913DE4", Offset = "0x913DE4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void RememberItemSacrifice(int itemId, int amountWeHave, int amountWeNeedTotal)
		{
			throw null;
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x0002E376 File Offset: 0x0002C576
		[global::Cpp2ILInjected.Token(Token = "0x6005099")]
		[global::Cpp2ILInjected.Address(RVA = "0x913CE4", Offset = "0x913CE4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ForgetItemSacrifice()
		{
			throw null;
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x0002E379 File Offset: 0x0002C579
		[global::Cpp2ILInjected.Token(Token = "0x600509A")]
		[global::Cpp2ILInjected.Address(RVA = "0x913DD8", Offset = "0x913DD8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void BeginSacrificeAnimation()
		{
			throw null;
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x0002E37C File Offset: 0x0002C57C
		[global::Cpp2ILInjected.Token(Token = "0x600509B")]
		[global::Cpp2ILInjected.Address(RVA = "0x913E24", Offset = "0x913E24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void UpdateSacrificeAnimation()
		{
			throw null;
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x0002E37F File Offset: 0x0002C57F
		[global::Cpp2ILInjected.Token(Token = "0x600509C")]
		[global::Cpp2ILInjected.Address(RVA = "0x9139D0", Offset = "0x9139D0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateVisualFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float GetSacrificeAnimationProgress()
		{
			throw null;
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x0002E382 File Offset: 0x0002C582
		[global::Cpp2ILInjected.Token(Token = "0x600509D")]
		[global::Cpp2ILInjected.Address(RVA = "0x913E38", Offset = "0x913E38", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "RefreshElementsOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void SetPageTypeToShow(UICreativeInfiniteItemsDisplay.InfiniteItemsDisplayPage page)
		{
			throw null;
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x0002E385 File Offset: 0x0002C585
		[global::Cpp2ILInjected.Token(Token = "0x600509E")]
		[global::Cpp2ILInjected.Address(RVA = "0x913E48", Offset = "0x913E48", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayerCreativeTracker", ReturnType = typeof(CreativeUnlocksTracker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UICreativeInfiniteItemsDisplay_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x0002E388 File Offset: 0x0002C588
		[global::Cpp2ILInjected.Token(Token = "0x600509F")]
		[global::Cpp2ILInjected.Address(RVA = "0x913F1C", Offset = "0x913F1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateContents", ReturnType = typeof(void))]
		private void filtersHelper_OnClickingOption()
		{
			throw null;
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x0002E38B File Offset: 0x0002C58B
		[global::Cpp2ILInjected.Token(Token = "0x60050A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x9121D4", Offset = "0x9121D4", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UICreativeInfiniteItemsDisplay_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "filtersHelper_OnClickingOption", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "OnSearchContentsChanged", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayerCreativeTracker", ReturnType = typeof(CreativeUnlocksTracker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemsSacrificedUnlocksTracker), Member = "FillListOfItemsThatCanBeObtainedInfinitely", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<int>),
			typeof(Func<int, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(IComparer<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIDynamicItemCollection), Member = "SetContentsToShow", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void UpdateContents()
		{
			throw null;
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x0002E38E File Offset: 0x0002C58E
		[global::Cpp2ILInjected.Token(Token = "0x60050A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x912508", Offset = "0x912508", Length = "0x7C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = "SetVisibility", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "add_OnContentsChanged", MemberParameters = new object[] { typeof(Action<string>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "add_OnStartTakingInput", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "add_OnEndTakingInput", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "add_OnNeedingVirtualKeyboard", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "add_OnCanceledTakingInput", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		private void AddSearchBar(UIElement searchArea)
		{
			throw null;
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x0002E391 File Offset: 0x0002C591
		[global::Cpp2ILInjected.Token(Token = "0x60050A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x913F20", Offset = "0x913F20", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "get_HasContents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		private void searchCancelButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x0002E394 File Offset: 0x0002C594
		[global::Cpp2ILInjected.Token(Token = "0x60050A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x913F78", Offset = "0x913F78", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		private void searchCancelButton_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x0002E397 File Offset: 0x0002C597
		[global::Cpp2ILInjected.Token(Token = "0x60050A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x913F98", Offset = "0x913F98", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ToggleInv", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnCanceledInput()
		{
			throw null;
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x0002E39A File Offset: 0x0002C59A
		[global::Cpp2ILInjected.Token(Token = "0x60050A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x913FF0", Offset = "0x913FF0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "ToggleTakingText", ReturnType = typeof(void))]
		private void Click_SearchArea(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x0002E39D File Offset: 0x0002C59D
		[global::Cpp2ILInjected.Token(Token = "0x60050A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x914028", Offset = "0x914028", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void LeftClick(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x0002E3A0 File Offset: 0x0002C5A0
		[global::Cpp2ILInjected.Token(Token = "0x60050A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x914054", Offset = "0x914054", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RightClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void RightClick(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x0002E3A3 File Offset: 0x0002C5A3
		[global::Cpp2ILInjected.Token(Token = "0x60050A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x914048", Offset = "0x914048", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AttemptStoppingUsingSearchbar(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x0002E3A6 File Offset: 0x0002C5A6
		[global::Cpp2ILInjected.Token(Token = "0x60050A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x914074", Offset = "0x914074", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "ToggleTakingText", ReturnType = typeof(void))]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x0002E3A9 File Offset: 0x0002C5A9
		[global::Cpp2ILInjected.Token(Token = "0x60050AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x9140B4", Offset = "0x9140B4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "SetSearchFilter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnSearchContentsChanged(string contents)
		{
			throw null;
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x0002E3AC File Offset: 0x0002C5AC
		[global::Cpp2ILInjected.Token(Token = "0x60050AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x914118", Offset = "0x914118", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnStartTakingInput()
		{
			throw null;
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x0002E3AF File Offset: 0x0002C5AF
		[global::Cpp2ILInjected.Token(Token = "0x60050AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x91417C", Offset = "0x91417C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void OnEndTakingInput()
		{
			throw null;
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x0002E3B2 File Offset: 0x0002C5B2
		[global::Cpp2ILInjected.Token(Token = "0x60050AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x9141B8", Offset = "0x9141B8", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard.KeyboardSubmitEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "SetMaxInputLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "OpenUIState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void OpenVirtualKeyboardWhenNeeded()
		{
			throw null;
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x0002E3B5 File Offset: 0x0002C5B5
		[global::Cpp2ILInjected.Token(Token = "0x60050AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x914354", Offset = "0x914354", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_playerInventory", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "ToggleTakingText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "ToggleMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool EscapeVirtualKeyboard()
		{
			throw null;
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x0002E3B8 File Offset: 0x0002C5B8
		[global::Cpp2ILInjected.Token(Token = "0x60050AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9143F4", Offset = "0x9143F4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static UserInterface GetCurrentInterface()
		{
			throw null;
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x0002E3BB File Offset: 0x0002C5BB
		[global::Cpp2ILInjected.Token(Token = "0x60050B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x9144A0", Offset = "0x9144A0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void OnFinishedSettingName(string name)
		{
			throw null;
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x0002E3BE File Offset: 0x0002C5BE
		[global::Cpp2ILInjected.Token(Token = "0x60050B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x9144D8", Offset = "0x9144D8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "ToggleMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "ToggleTakingText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void GoBackHere()
		{
			throw null;
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x0002E3C1 File Offset: 0x0002C5C1
		[global::Cpp2ILInjected.Token(Token = "0x60050B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x914564", Offset = "0x914564", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetItemsPerLine()
		{
			throw null;
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x0002E3C4 File Offset: 0x0002C5C4
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60050B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x914570", Offset = "0x914570", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "FitsFilter", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool <UpdateContents>b__63_0(int x)
		{
			throw null;
		}

		// Token: 0x04007009 RID: 28681
		[global::Cpp2ILInjected.Token(Token = "0x400894D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private List<int> _itemIdsAvailableTotal;

		// Token: 0x0400700A RID: 28682
		[global::Cpp2ILInjected.Token(Token = "0x400894E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private List<int> _itemIdsAvailableToShow;

		// Token: 0x0400700B RID: 28683
		[global::Cpp2ILInjected.Token(Token = "0x400894F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private CreativeUnlocksTracker _lastTrackerCheckedForEdits;

		// Token: 0x0400700C RID: 28684
		[global::Cpp2ILInjected.Token(Token = "0x4008950")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private int _lastCheckedVersionForEdits;

		// Token: 0x0400700D RID: 28685
		[global::Cpp2ILInjected.Token(Token = "0x4008951")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private UISearchBar _searchBar;

		// Token: 0x0400700E RID: 28686
		[global::Cpp2ILInjected.Token(Token = "0x4008952")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private UIPanel _searchBoxPanel;

		// Token: 0x0400700F RID: 28687
		[global::Cpp2ILInjected.Token(Token = "0x4008953")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private UIState _parentUIState;

		// Token: 0x04007010 RID: 28688
		[global::Cpp2ILInjected.Token(Token = "0x4008954")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private string _searchString;

		// Token: 0x04007011 RID: 28689
		[global::Cpp2ILInjected.Token(Token = "0x4008955")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private UIDynamicItemCollection _itemGrid;

		// Token: 0x04007012 RID: 28690
		[global::Cpp2ILInjected.Token(Token = "0x4008956")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private EntryFilterer<Item, IItemEntryFilter> _filterer;

		// Token: 0x04007013 RID: 28691
		[global::Cpp2ILInjected.Token(Token = "0x4008957")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private EntrySorter<int, ICreativeItemSortStep> _sorter;

		// Token: 0x04007014 RID: 28692
		[global::Cpp2ILInjected.Token(Token = "0x4008958")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		private UIElement _containerInfinites;

		// Token: 0x04007015 RID: 28693
		[global::Cpp2ILInjected.Token(Token = "0x4008959")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		private UIElement _containerSacrifice;

		// Token: 0x04007016 RID: 28694
		[global::Cpp2ILInjected.Token(Token = "0x400895A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		private bool _showSacrificesInsteadOfInfinites;

		// Token: 0x04007017 RID: 28695
		[global::Cpp2ILInjected.Token(Token = "0x400895B")]
		public const string SnapPointName_SacrificeSlot = "CreativeSacrificeSlot";

		// Token: 0x04007018 RID: 28696
		[global::Cpp2ILInjected.Token(Token = "0x400895C")]
		public const string SnapPointName_SacrificeConfirmButton = "CreativeSacrificeConfirm";

		// Token: 0x04007019 RID: 28697
		[global::Cpp2ILInjected.Token(Token = "0x400895D")]
		public const string SnapPointName_InfinitesFilter = "CreativeInfinitesFilter";

		// Token: 0x0400701A RID: 28698
		[global::Cpp2ILInjected.Token(Token = "0x400895E")]
		public const string SnapPointName_InfinitesSearch = "CreativeInfinitesSearch";

		// Token: 0x0400701B RID: 28699
		[global::Cpp2ILInjected.Token(Token = "0x400895F")]
		public const string SnapPointName_InfinitesItemSlot = "CreativeInfinitesSlot";

		// Token: 0x0400701C RID: 28700
		[global::Cpp2ILInjected.Token(Token = "0x4008960")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		private List<UIImage> _sacrificeCogsSmall;

		// Token: 0x0400701D RID: 28701
		[global::Cpp2ILInjected.Token(Token = "0x4008961")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		private List<UIImage> _sacrificeCogsMedium;

		// Token: 0x0400701E RID: 28702
		[global::Cpp2ILInjected.Token(Token = "0x4008962")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		private List<UIImage> _sacrificeCogsBig;

		// Token: 0x0400701F RID: 28703
		[global::Cpp2ILInjected.Token(Token = "0x4008963")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		private UIImageFramed _sacrificePistons;

		// Token: 0x04007020 RID: 28704
		[global::Cpp2ILInjected.Token(Token = "0x4008964")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
		private UIParticleLayer _pistonParticleSystem;

		// Token: 0x04007021 RID: 28705
		[global::Cpp2ILInjected.Token(Token = "0x4008965")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
		private Asset<Texture2D> _pistonParticleAsset;

		// Token: 0x04007022 RID: 28706
		[global::Cpp2ILInjected.Token(Token = "0x4008966")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		private int _sacrificeAnimationTimeLeft;

		// Token: 0x04007023 RID: 28707
		[global::Cpp2ILInjected.Token(Token = "0x4008967")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1EC")]
		private bool _researchComplete;

		// Token: 0x04007024 RID: 28708
		[global::Cpp2ILInjected.Token(Token = "0x4008968")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1ED")]
		private bool _hovered;

		// Token: 0x04007025 RID: 28709
		[global::Cpp2ILInjected.Token(Token = "0x4008969")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		private int _lastItemIdSacrificed;

		// Token: 0x04007026 RID: 28710
		[global::Cpp2ILInjected.Token(Token = "0x400896A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F4")]
		private int _lastItemAmountWeHad;

		// Token: 0x04007027 RID: 28711
		[global::Cpp2ILInjected.Token(Token = "0x400896B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		private int _lastItemAmountWeNeededTotal;

		// Token: 0x04007028 RID: 28712
		[global::Cpp2ILInjected.Token(Token = "0x400896C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1FC")]
		private bool _didClickSomething;

		// Token: 0x04007029 RID: 28713
		[global::Cpp2ILInjected.Token(Token = "0x400896D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1FD")]
		private bool _didClickSearchBar;

		// Token: 0x02000ABF RID: 2751
		[global::Cpp2ILInjected.Token(Token = "0x2000AAF")]
		public enum InfiniteItemsDisplayPage
		{
			// Token: 0x04008F51 RID: 36689
			[global::Cpp2ILInjected.Token(Token = "0x400896F")]
			InfiniteItemsPickup,
			// Token: 0x04008F52 RID: 36690
			[global::Cpp2ILInjected.Token(Token = "0x4008970")]
			InfiniteItemsResearch
		}
	}
}