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
using Terraria.DataStructures;
using Terraria.GameContent.Tile_Entities;
using Terraria.Localization;
using Terraria.UI;
using UnityEngine;

// Token: 0x020000E1 RID: 225
[global::Cpp2ILInjected.Token(Token = "0x2000144")]
public class GUIHatRack
{
	// Token: 0x060007C7 RID: 1991 RVA: 0x0002329A File Offset: 0x0002149A
	[global::Cpp2ILInjected.Token(Token = "0x60008C1")]
	[global::Cpp2ILInjected.Address(RVA = "0x801B40", Offset = "0x801B40", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "LoadPageRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
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
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Union", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "set_PageContentRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void LoadPageRegion()
	{
		throw null;
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0002329D File Offset: 0x0002149D
	[global::Cpp2ILInjected.Token(Token = "0x60008C2")]
	[global::Cpp2ILInjected.Address(RVA = "0x801CC8", Offset = "0x801CC8", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float HatScale(int index)
	{
		throw null;
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x000232A0 File Offset: 0x000214A0
	[global::Cpp2ILInjected.Token(Token = "0x60008C3")]
	[global::Cpp2ILInjected.Address(RVA = "0x801D10", Offset = "0x801D10", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float HatDyeScale(int index)
	{
		throw null;
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x000232A3 File Offset: 0x000214A3
	[global::Cpp2ILInjected.Token(Token = "0x60008C4")]
	[global::Cpp2ILInjected.Address(RVA = "0x801D58", Offset = "0x801D58", Length = "0x400")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "HatOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "HatDyeOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_HoldingItem", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_IsItemDropped", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorOverride", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_HatRack", ReturnType = typeof(GUIControllerHatRack))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	private void ItemOver(Item[] inv, int index, GUIHatRack.EquipmentItemType equipmentType, int itemContext, ref int itemDragStart)
	{
		throw null;
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x000232A6 File Offset: 0x000214A6
	[global::Cpp2ILInjected.Token(Token = "0x60008C5")]
	[global::Cpp2ILInjected.Address(RVA = "0x802158", Offset = "0x802158", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHatRack), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIHatRack.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	public void HatOver(int index)
	{
		throw null;
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x000232A9 File Offset: 0x000214A9
	[global::Cpp2ILInjected.Token(Token = "0x60008C6")]
	[global::Cpp2ILInjected.Address(RVA = "0x802178", Offset = "0x802178", Length = "0x3AC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHatRack), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public void HatDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x000232AC File Offset: 0x000214AC
	[global::Cpp2ILInjected.Token(Token = "0x60008C7")]
	[global::Cpp2ILInjected.Address(RVA = "0x8025FC", Offset = "0x8025FC", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHatRack), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIHatRack.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	public void HatDyeOver(int index)
	{
		throw null;
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x000232AF File Offset: 0x000214AF
	[global::Cpp2ILInjected.Token(Token = "0x60008C8")]
	[global::Cpp2ILInjected.Address(RVA = "0x80261C", Offset = "0x80261C", Length = "0x39C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHatRack), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
	public void HatDyeDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x000232B2 File Offset: 0x000214B2
	[global::Cpp2ILInjected.Token(Token = "0x60008C9")]
	[global::Cpp2ILInjected.Address(RVA = "0x8029B8", Offset = "0x8029B8", Length = "0x1D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public int CanBeEquipedAccessory(Item checkItem)
	{
		throw null;
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x000232B5 File Offset: 0x000214B5
	[global::Cpp2ILInjected.Token(Token = "0x60008CA")]
	[global::Cpp2ILInjected.Address(RVA = "0x802B88", Offset = "0x802B88", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public bool CanBeEquiped(Item checkItem)
	{
		throw null;
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x000232B8 File Offset: 0x000214B8
	[global::Cpp2ILInjected.Token(Token = "0x60008CB")]
	[global::Cpp2ILInjected.Address(RVA = "0x802B98", Offset = "0x802B98", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool CanBeStored(Item checkItem)
	{
		throw null;
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x000232BB File Offset: 0x000214BB
	[global::Cpp2ILInjected.Token(Token = "0x60008CC")]
	[global::Cpp2ILInjected.Address(RVA = "0x8025B8", Offset = "0x8025B8", Length = "0x44")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private bool CanBeStored(int context, Item checkItem, int slot)
	{
		throw null;
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x000232BE File Offset: 0x000214BE
	[global::Cpp2ILInjected.Token(Token = "0x60008CD")]
	[global::Cpp2ILInjected.Address(RVA = "0x802BB8", Offset = "0x802BB8", Length = "0x468")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	private void DrawHats()
	{
		throw null;
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x000232C1 File Offset: 0x000214C1
	[global::Cpp2ILInjected.Token(Token = "0x60008CE")]
	[global::Cpp2ILInjected.Address(RVA = "0x803020", Offset = "0x803020", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public Item GetSelectedItem()
	{
		throw null;
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x000232C4 File Offset: 0x000214C4
	[global::Cpp2ILInjected.Token(Token = "0x60008CF")]
	[global::Cpp2ILInjected.Address(RVA = "0x80304C", Offset = "0x80304C", Length = "0x7A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "GetTileEntity", ReturnType = typeof(TileEntity))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanStoreItem", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHatRack), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "PopRight", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(GetItemSettings),
		typeof(bool)
	}, ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(NetworkText),
		typeof(int),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
	public void DrawUnequipButton()
	{
		throw null;
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060007D6 RID: 2006 RVA: 0x000232C7 File Offset: 0x000214C7
	[global::Cpp2ILInjected.Token(Token = "0x170000DD")]
	public bool HasFocus
	{
		[global::Cpp2ILInjected.Token(Token = "0x60008D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x802524", Offset = "0x802524", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "HatDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "HatDyeDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "DrawUnequipButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_HatRack", ReturnType = typeof(GUIControllerHatRack))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x000232CA File Offset: 0x000214CA
	[global::Cpp2ILInjected.Token(Token = "0x60008D1")]
	[global::Cpp2ILInjected.Address(RVA = "0x8037F0", Offset = "0x8037F0", Length = "0x308")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawPageContent", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "GetTileEntity", ReturnType = typeof(TileEntity))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHatRack), Member = "DrawHats", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x000232CD File Offset: 0x000214CD
	[global::Cpp2ILInjected.Token(Token = "0x60008D2")]
	[global::Cpp2ILInjected.Address(RVA = "0x803AF8", Offset = "0x803AF8", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIHatRack()
	{
		throw null;
	}

	// Token: 0x0400053C RID: 1340
	[global::Cpp2ILInjected.Token(Token = "0x4000790")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int cursorOver;

	// Token: 0x0400053D RID: 1341
	[global::Cpp2ILInjected.Token(Token = "0x4000791")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int itemOver;

	// Token: 0x0400053E RID: 1342
	[global::Cpp2ILInjected.Token(Token = "0x4000792")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int itemDragStartHat;

	// Token: 0x0400053F RID: 1343
	[global::Cpp2ILInjected.Token(Token = "0x4000793")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private int itemDragStartHatDye;

	// Token: 0x04000540 RID: 1344
	[global::Cpp2ILInjected.Token(Token = "0x4000794")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private GUIHatRack.EquipmentItemType itemType;

	// Token: 0x04000541 RID: 1345
	[global::Cpp2ILInjected.Token(Token = "0x4000795")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private int itemPieceSelected;

	// Token: 0x04000542 RID: 1346
	[global::Cpp2ILInjected.Token(Token = "0x4000796")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float UnequipButtonScale;

	// Token: 0x04000543 RID: 1347
	[global::Cpp2ILInjected.Token(Token = "0x4000797")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private TEHatRack HatRack;

	// Token: 0x020007C4 RID: 1988
	[global::Cpp2ILInjected.Token(Token = "0x2000145")]
	private enum EquipmentItemType
	{
		// Token: 0x04007A1F RID: 31263
		[global::Cpp2ILInjected.Token(Token = "0x4000799")]
		Hat,
		// Token: 0x04007A20 RID: 31264
		[global::Cpp2ILInjected.Token(Token = "0x400079A")]
		HatDye
	}
}
