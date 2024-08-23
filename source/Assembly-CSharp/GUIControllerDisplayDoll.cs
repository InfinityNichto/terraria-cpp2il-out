﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000088 RID: 136
[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
public class GUIControllerDisplayDoll : GUIPageContentController
{
	// Token: 0x06000417 RID: 1047 RVA: 0x0002278A File Offset: 0x0002098A
	[global::Cpp2ILInjected.Token(Token = "0x60004B1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B734", Offset = "0xA8B734", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerDisplayDoll()
	{
		throw null;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x0002278D File Offset: 0x0002098D
	[global::Cpp2ILInjected.Token(Token = "0x60004B2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B740", Offset = "0xA8B740", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00022790 File Offset: 0x00020990
	[global::Cpp2ILInjected.Token(Token = "0x60004B3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B744", Offset = "0xA8B744", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00022793 File Offset: 0x00020993
	[global::Cpp2ILInjected.Token(Token = "0x60004B4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B748", Offset = "0xA8B748", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00022796 File Offset: 0x00020996
	[global::Cpp2ILInjected.Token(Token = "0x60004B5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B858", Offset = "0xA8B858", Length = "0x22C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002D0 RID: 720
	[global::Cpp2ILInjected.Token(Token = "0x4000449")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x040002D1 RID: 721
	[global::Cpp2ILInjected.Token(Token = "0x400044A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;
}
