﻿using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x020000D6 RID: 214
[global::Cpp2ILInjected.Token(Token = "0x2000136")]
public class GUICraftGuide
{
	// Token: 0x06000711 RID: 1809 RVA: 0x00023078 File Offset: 0x00021278
	[global::Cpp2ILInjected.Token(Token = "0x600080B")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F1A98", Offset = "0x13F1A98", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "LoadPageRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CraftGuide_Layout), Member = "get_DisplayGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "set_PageContentRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void LoadPageRegion()
	{
		throw null;
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000712 RID: 1810 RVA: 0x0002307B File Offset: 0x0002127B
	[global::Cpp2ILInjected.Token(Token = "0x170000D2")]
	public bool Collapsed
	{
		[global::Cpp2ILInjected.Token(Token = "0x600080C")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F1B84", Offset = "0x13F1B84", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CraftGuide_Layout), Member = "get_DisplayGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "IsCollapsed", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x0002307E File Offset: 0x0002127E
	[global::Cpp2ILInjected.Token(Token = "0x600080D")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F1BE0", Offset = "0x13F1BE0", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000714 RID: 1812 RVA: 0x00023081 File Offset: 0x00021281
	[global::Cpp2ILInjected.Token(Token = "0x170000D3")]
	public bool HasFocus
	{
		[global::Cpp2ILInjected.Token(Token = "0x600080E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F1C78", Offset = "0x13F1C78", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "DrawGuideList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "GuideItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_CraftingGuide", ReturnType = typeof(GUIControllerCraftingGuide))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000715 RID: 1813 RVA: 0x00023084 File Offset: 0x00021284
	[global::Cpp2ILInjected.Token(Token = "0x170000D4")]
	public Item guideItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x600080F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F1D0C", Offset = "0x13F1D0C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "DrawGuideList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "DrawItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "UpdateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "CraftItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "FindRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00023087 File Offset: 0x00021287
	[global::Cpp2ILInjected.Token(Token = "0x6000810")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F1DD0", Offset = "0x13F1DD0", Length = "0x15C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void RefreshItems()
	{
		throw null;
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x0002308A File Offset: 0x0002128A
	[global::Cpp2ILInjected.Token(Token = "0x6000811")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F1F2C", Offset = "0x13F1F2C", Length = "0x33C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuide), Member = "get_guideItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuide), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_CraftingGuide", ReturnType = typeof(GUIControllerCraftingGuide))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "IsInMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "OpenPopup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void DrawGuideList()
	{
		throw null;
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x0002308D File Offset: 0x0002128D
	[global::Cpp2ILInjected.Token(Token = "0x6000812")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F2410", Offset = "0x13F2410", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float GuideItemScale(int index)
	{
		throw null;
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00023090 File Offset: 0x00021290
	[global::Cpp2ILInjected.Token(Token = "0x6000813")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F2458", Offset = "0x13F2458", Length = "0x294")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
	{
		typeof(ref Item),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "UpdateTooltipContext", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "FindRecipes", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_CraftingGuide", ReturnType = typeof(GUIControllerCraftingGuide))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void GuideItemOver(int index)
	{
		throw null;
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00023093 File Offset: 0x00021293
	[global::Cpp2ILInjected.Token(Token = "0x6000814")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F2934", Offset = "0x13F2934", Length = "0x4D4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuide), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Vector2),
		typeof(Rectangle?),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ref Item),
		typeof(int),
		typeof(Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
	public void GuideItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00023096 File Offset: 0x00021296
	[global::Cpp2ILInjected.Token(Token = "0x6000815")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F2E08", Offset = "0x13F2E08", Length = "0x580")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawPageContent", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_InGuideCraftMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "dropItemCheck", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_InReforgeMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuide), Member = "RefreshItems", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuide), Member = "get_guideItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CraftGuide_Layout), Member = "get_DisplayGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Vector2),
		typeof(Texture2D),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00023099 File Offset: 0x00021299
	[global::Cpp2ILInjected.Token(Token = "0x6000816")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F3388", Offset = "0x13F3388", Length = "0x12C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingMaterials), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public GUICraftGuide()
	{
		throw null;
	}

	// Token: 0x04000499 RID: 1177
	[global::Cpp2ILInjected.Token(Token = "0x40006D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public float craftScrollOffset;

	// Token: 0x0400049A RID: 1178
	[global::Cpp2ILInjected.Token(Token = "0x40006D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float craftScrollMomentum;

	// Token: 0x0400049B RID: 1179
	[global::Cpp2ILInjected.Token(Token = "0x40006D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int craftScrollDragging;

	// Token: 0x0400049C RID: 1180
	[global::Cpp2ILInjected.Token(Token = "0x40006DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private Vector2 craftDragOffset;

	// Token: 0x0400049D RID: 1181
	[global::Cpp2ILInjected.Token(Token = "0x40006DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private int cursorOver;

	// Token: 0x0400049E RID: 1182
	[global::Cpp2ILInjected.Token(Token = "0x40006DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool menuTogglePressed;

	// Token: 0x0400049F RID: 1183
	[global::Cpp2ILInjected.Token(Token = "0x40006DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	public bool materialsGridActive;

	// Token: 0x040004A0 RID: 1184
	[global::Cpp2ILInjected.Token(Token = "0x40006DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private DateTime NavigationTick;

	// Token: 0x040004A1 RID: 1185
	[global::Cpp2ILInjected.Token(Token = "0x40006DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private GUIControllerCraftingMaterials materialController;

	// Token: 0x040004A2 RID: 1186
	[global::Cpp2ILInjected.Token(Token = "0x40006E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private List<string> _requiredObjecsForCraftingText;

	// Token: 0x040004A3 RID: 1187
	[global::Cpp2ILInjected.Token(Token = "0x40006E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public List<int> _materialItems;

	// Token: 0x040004A4 RID: 1188
	[global::Cpp2ILInjected.Token(Token = "0x40006E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private Item _defaultItem;

	// Token: 0x040004A5 RID: 1189
	[global::Cpp2ILInjected.Token(Token = "0x40006E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private int _selectedItem;
}