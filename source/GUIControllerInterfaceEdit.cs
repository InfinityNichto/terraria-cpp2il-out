﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000064 RID: 100
[global::Cpp2ILInjected.Token(Token = "0x2000091")]
public class GUIControllerInterfaceEdit : GUIControllerItem
{
	// Token: 0x060002EB RID: 747 RVA: 0x00022412 File Offset: 0x00020612
	[global::Cpp2ILInjected.Token(Token = "0x6000385")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C4540", Offset = "0x9C4540", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00022415 File Offset: 0x00020615
	[global::Cpp2ILInjected.Token(Token = "0x6000386")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C4548", Offset = "0x9C4548", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00022418 File Offset: 0x00020618
	[global::Cpp2ILInjected.Token(Token = "0x6000387")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C4550", Offset = "0x9C4550", Length = "0x1C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInterfaceEdit), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RefreshSelected", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawGroupEditControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateInterfaceMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "RefreshSelected", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void UpdatePageScroll()
	{
		throw null;
	}

	// Token: 0x060002EE RID: 750 RVA: 0x0002241B File Offset: 0x0002061B
	[global::Cpp2ILInjected.Token(Token = "0x6000388")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C4710", Offset = "0x9C4710", Length = "0x520")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInterfaceEdit), Member = "UpdatePageScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060002EF RID: 751 RVA: 0x0002241E File Offset: 0x0002061E
	[global::Cpp2ILInjected.Token(Token = "0x6000389")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C4C30", Offset = "0x9C4C30", Length = "0x46C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "GetRegion", MemberParameters = new object[] { typeof(Slider_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00022421 File Offset: 0x00020621
	[global::Cpp2ILInjected.Token(Token = "0x600038A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C509C", Offset = "0x9C509C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerInterfaceEdit()
	{
		throw null;
	}

	// Token: 0x04000243 RID: 579
	[global::Cpp2ILInjected.Token(Token = "0x4000366")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int EditControl;

	// Token: 0x04000244 RID: 580
	[global::Cpp2ILInjected.Token(Token = "0x4000367")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int EditProfile;

	// Token: 0x04000245 RID: 581
	[global::Cpp2ILInjected.Token(Token = "0x4000368")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int EditTemplate;

	// Token: 0x04000246 RID: 582
	[global::Cpp2ILInjected.Token(Token = "0x4000369")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int AdjustColumn;

	// Token: 0x04000247 RID: 583
	[global::Cpp2ILInjected.Token(Token = "0x400036A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int AdjustRow;

	// Token: 0x04000248 RID: 584
	[global::Cpp2ILInjected.Token(Token = "0x400036B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int PageColumn;

	// Token: 0x04000249 RID: 585
	[global::Cpp2ILInjected.Token(Token = "0x400036C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int PageRow;
}