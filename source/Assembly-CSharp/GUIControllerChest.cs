﻿using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200007F RID: 127
[global::Cpp2ILInjected.Token(Token = "0x20000B6")]
public class GUIControllerChest : GUIPageContentController
{
	// Token: 0x060003B9 RID: 953 RVA: 0x00022670 File Offset: 0x00020870
	[global::Cpp2ILInjected.Token(Token = "0x6000453")]
	[global::Cpp2ILInjected.Address(RVA = "0xA886A8", Offset = "0xA886A8", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerChest()
	{
		throw null;
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00022673 File Offset: 0x00020873
	[global::Cpp2ILInjected.Token(Token = "0x6000454")]
	[global::Cpp2ILInjected.Address(RVA = "0xA886C0", Offset = "0xA886C0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00022676 File Offset: 0x00020876
	[global::Cpp2ILInjected.Token(Token = "0x6000455")]
	[global::Cpp2ILInjected.Address(RVA = "0xA886C4", Offset = "0xA886C4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00022679 File Offset: 0x00020879
	[global::Cpp2ILInjected.Token(Token = "0x6000456")]
	[global::Cpp2ILInjected.Address(RVA = "0xA886CC", Offset = "0xA886CC", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060003BD RID: 957 RVA: 0x0002267C File Offset: 0x0002087C
	[global::Cpp2ILInjected.Token(Token = "0x6000457")]
	[global::Cpp2ILInjected.Address(RVA = "0xA887BC", Offset = "0xA887BC", Length = "0x2C4")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest_Layout), Member = "get_DisplayChestGrid", ReturnType = typeof(ItemGrid_Layout))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002C5 RID: 709
	[global::Cpp2ILInjected.Token(Token = "0x400043B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x040002C6 RID: 710
	[global::Cpp2ILInjected.Token(Token = "0x400043C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;
}
