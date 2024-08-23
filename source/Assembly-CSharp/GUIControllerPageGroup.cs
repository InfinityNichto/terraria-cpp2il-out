﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000098 RID: 152
[global::Cpp2ILInjected.Token(Token = "0x20000D2")]
public class GUIControllerPageGroup : GUIControllerItem
{
	// Token: 0x060004A9 RID: 1193 RVA: 0x00022940 File Offset: 0x00020B40
	[global::Cpp2ILInjected.Token(Token = "0x6000543")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EE04", Offset = "0xB1EE04", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "get_MenuController", ReturnType = typeof(GUIControllerPageGroup))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerPageGroup(GUIPageIconGrouping grouping)
	{
		throw null;
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00022943 File Offset: 0x00020B43
	[global::Cpp2ILInjected.Token(Token = "0x6000544")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EE2C", Offset = "0xB1EE2C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00022946 File Offset: 0x00020B46
	[global::Cpp2ILInjected.Token(Token = "0x6000545")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EE30", Offset = "0xB1EE30", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00022949 File Offset: 0x00020B49
	[global::Cpp2ILInjected.Token(Token = "0x6000546")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EEB0", Offset = "0xB1EEB0", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateFromMenuIntoPage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageGroup), Member = "ClampMenuItem", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateUp", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x0002294C File Offset: 0x00020B4C
	[global::Cpp2ILInjected.Token(Token = "0x6000547")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1F044", Offset = "0xB1F044", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageGroup), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageGroup), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "GetControllerNavigateController", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void ClampMenuItem(bool preferUp = true)
	{
		throw null;
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x0002294F File Offset: 0x00020B4F
	[global::Cpp2ILInjected.Token(Token = "0x6000548")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1F0FC", Offset = "0xB1F0FC", Length = "0x174")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageGroup), Member = "ClampMenuItem", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "LoadPageAnchor", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002F4 RID: 756
	[global::Cpp2ILInjected.Token(Token = "0x400047E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIPageIconGrouping Grouping;

	// Token: 0x040002F5 RID: 757
	[global::Cpp2ILInjected.Token(Token = "0x400047F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int MenuRow;
}