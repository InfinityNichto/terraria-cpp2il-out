﻿using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000081 RID: 129
[global::Cpp2ILInjected.Token(Token = "0x20000B8")]
public class GUIControllerCoins : GUIPageContentController
{
	// Token: 0x060003CA RID: 970 RVA: 0x000226A3 File Offset: 0x000208A3
	[global::Cpp2ILInjected.Token(Token = "0x6000464")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88EB8", Offset = "0xA88EB8", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerCoins()
	{
		throw null;
	}

	// Token: 0x060003CB RID: 971 RVA: 0x000226A6 File Offset: 0x000208A6
	[global::Cpp2ILInjected.Token(Token = "0x6000465")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88EC4", Offset = "0xA88EC4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060003CC RID: 972 RVA: 0x000226A9 File Offset: 0x000208A9
	[global::Cpp2ILInjected.Token(Token = "0x6000466")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88EC8", Offset = "0xA88EC8", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void NavigateFromInventoryRow(int row)
	{
		throw null;
	}

	// Token: 0x060003CD RID: 973 RVA: 0x000226AC File Offset: 0x000208AC
	[global::Cpp2ILInjected.Token(Token = "0x6000467")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88EE4", Offset = "0xA88EE4", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual int GetInventoryRow()
	{
		throw null;
	}

	// Token: 0x060003CE RID: 974 RVA: 0x000226AF File Offset: 0x000208AF
	[global::Cpp2ILInjected.Token(Token = "0x6000468")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88F00", Offset = "0xA88F00", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Inventory", ReturnType = typeof(GUIControllerInventory))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Ammo", ReturnType = typeof(GUIControllerAmmo))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060003CF RID: 975 RVA: 0x000226B2 File Offset: 0x000208B2
	[global::Cpp2ILInjected.Token(Token = "0x6000469")]
	[global::Cpp2ILInjected.Address(RVA = "0xA89088", Offset = "0xA89088", Length = "0x274")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002C8 RID: 712
	[global::Cpp2ILInjected.Token(Token = "0x400043E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;
}