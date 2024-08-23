﻿using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020000D3 RID: 211
[global::Cpp2ILInjected.Token(Token = "0x200012E")]
public class GUIControllerDisconnected
{
	// Token: 0x060006EE RID: 1774 RVA: 0x0002300F File Offset: 0x0002120F
	[global::Cpp2ILInjected.Token(Token = "0x60007E1")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ECA04", Offset = "0x13ECA04", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00023012 File Offset: 0x00021212
	[global::Cpp2ILInjected.Token(Token = "0x60007E2")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ECA0C", Offset = "0x13ECA0C", Length = "0x5FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_KeyboardIsActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "CanControllerBeUsedForPlayer", MemberParameters = new object[]
	{
		typeof(ControllerDevice),
		typeof(LocalUser)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Rectangle),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00023015 File Offset: 0x00021215
	[global::Cpp2ILInjected.Token(Token = "0x60007E3")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ED008", Offset = "0x13ED008", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void DisplayNpadConnectionPromptAndReassignNpads()
	{
		throw null;
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00023018 File Offset: 0x00021218
	[global::Cpp2ILInjected.Token(Token = "0x60007E4")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ED070", Offset = "0x13ED070", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerDisconnected()
	{
		throw null;
	}

	// Token: 0x04000473 RID: 1139
	[global::Cpp2ILInjected.Token(Token = "0x4000677")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float statusScale;

	// Token: 0x04000474 RID: 1140
	[global::Cpp2ILInjected.Token(Token = "0x4000678")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float loadScale;

	// Token: 0x04000475 RID: 1141
	[global::Cpp2ILInjected.Token(Token = "0x4000679")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float backScale;

	// Token: 0x04000476 RID: 1142
	[global::Cpp2ILInjected.Token(Token = "0x400067A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float titleScale;

	// Token: 0x04000477 RID: 1143
	[global::Cpp2ILInjected.Token(Token = "0x400067B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float buttonScale;

	// Token: 0x04000478 RID: 1144
	[global::Cpp2ILInjected.Token(Token = "0x400067C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private bool wasDown;

	// Token: 0x04000479 RID: 1145
	[global::Cpp2ILInjected.Token(Token = "0x400067D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x0400047A RID: 1146
	[global::Cpp2ILInjected.Token(Token = "0x400067E")]
	private static bool showingReassign;
}
