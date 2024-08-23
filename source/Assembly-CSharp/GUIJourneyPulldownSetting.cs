﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200010F RID: 271
[global::Cpp2ILInjected.Token(Token = "0x2000185")]
public class GUIJourneyPulldownSetting : GUIPulldownSetting
{
	// Token: 0x060009F9 RID: 2553 RVA: 0x00023930 File Offset: 0x00021B30
	[global::Cpp2ILInjected.Token(Token = "0x6000B01")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3AE0", Offset = "0x9A3AE0", Length = "0x158")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "Init", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting.ActivateOverlayCallback), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting.DeactivateOverlayCallback), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting.RegisterOverlay), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(GUISettingID),
		typeof(GUIPulldownSetting.ActivateOverlayCallback),
		typeof(GUIPulldownSetting.DeactivateOverlayCallback),
		typeof(GUIPulldownSetting.RegisterOverlay)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public GUIJourneyPulldownSetting(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00023933 File Offset: 0x00021B33
	[global::Cpp2ILInjected.Token(Token = "0x6000B02")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3C38", Offset = "0x9A3C38", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "GetIconTexture", MemberParameters = new object[]
	{
		typeof(GUISettingID),
		typeof(ref Rectangle)
	}, ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00023936 File Offset: 0x00021B36
	[global::Cpp2ILInjected.Token(Token = "0x6000B03")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3DA0", Offset = "0x9A3DA0", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerJourneyModeSettings), Member = "ActivateOverlay", MemberParameters = new object[]
	{
		typeof(GUIPulldownSetting),
		typeof(Rectangle),
		typeof(int),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		throw null;
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00023939 File Offset: 0x00021B39
	[global::Cpp2ILInjected.Token(Token = "0x6000B04")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3E34", Offset = "0x9A3E34", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerJourneyModeSettings), Member = "DeactivateOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static void DeactivateOverlay()
	{
		throw null;
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x0002393C File Offset: 0x00021B3C
	[global::Cpp2ILInjected.Token(Token = "0x6000B05")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3E88", Offset = "0x9A3E88", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "RegisterOverlay", MemberParameters = new object[]
	{
		typeof(GUISettingEntry),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static void RegisterOverlayJM(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
		throw null;
	}

	// Token: 0x04000872 RID: 2162
	[global::Cpp2ILInjected.Token(Token = "0x4000B8E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private float iconScale;
}
