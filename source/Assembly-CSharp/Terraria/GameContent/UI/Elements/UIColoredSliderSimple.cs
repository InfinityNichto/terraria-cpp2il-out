﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006CA RID: 1738
	[global::Cpp2ILInjected.Token(Token = "0x2000AAD")]
	public class UIColoredSliderSimple : UIElement
	{
		// Token: 0x0600442E RID: 17454 RVA: 0x0002E32B File Offset: 0x0002C52B
		[global::Cpp2ILInjected.Token(Token = "0x6005080")]
		[global::Cpp2ILInjected.Address(RVA = "0x9102E4", Offset = "0x9102E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x0002E32E File Offset: 0x0002C52E
		[global::Cpp2ILInjected.Token(Token = "0x6005081")]
		[global::Cpp2ILInjected.Address(RVA = "0x9102E8", Offset = "0x9102E8", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawSplicedPanel", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void DrawValueBarDynamicWidth(SpriteBatch sb)
		{
			throw null;
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x0002E331 File Offset: 0x0002C531
		[global::Cpp2ILInjected.Token(Token = "0x6005082")]
		[global::Cpp2ILInjected.Address(RVA = "0x9105A0", Offset = "0x9105A0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "FillProgressBottomBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public UIColoredSliderSimple()
		{
			throw null;
		}

		// Token: 0x04007006 RID: 28678
		[global::Cpp2ILInjected.Token(Token = "0x400894A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x144")]
		public float FillPercent;

		// Token: 0x04007007 RID: 28679
		[global::Cpp2ILInjected.Token(Token = "0x400894B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public Color FilledColor;

		// Token: 0x04007008 RID: 28680
		[global::Cpp2ILInjected.Token(Token = "0x400894C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14C")]
		public Color EmptyColor;
	}
}
