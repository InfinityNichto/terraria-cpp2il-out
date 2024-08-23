﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006BF RID: 1727
	[global::Cpp2ILInjected.Token(Token = "0x2000A9F")]
	public class UIBestiaryEntryIcon : UIElement
	{
		// Token: 0x060043EB RID: 17387 RVA: 0x0002E268 File Offset: 0x0002C468
		[global::Cpp2ILInjected.Token(Token = "0x6005035")]
		[global::Cpp2ILInjected.Address(RVA = "0x906BCC", Offset = "0x906BCC", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryNPCEntryPortrait), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(Asset<Texture2D>),
			typeof(Color),
			typeof(List<IBestiaryBackgroundOverlayAndColorProvider>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_DefaultSamplerState", ReturnType = typeof(SamplerState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public UIBestiaryEntryIcon(BestiaryEntry entry, bool isPortrait)
		{
			throw null;
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x0002E26B File Offset: 0x0002C46B
		[global::Cpp2ILInjected.Token(Token = "0x6005036")]
		[global::Cpp2ILInjected.Address(RVA = "0x90B478", Offset = "0x90B478", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x0002E26E File Offset: 0x0002C46E
		[global::Cpp2ILInjected.Token(Token = "0x6005037")]
		[global::Cpp2ILInjected.Address(RVA = "0x90B650", Offset = "0x90B650", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x0002E271 File Offset: 0x0002C471
		[global::Cpp2ILInjected.Token(Token = "0x6005038")]
		[global::Cpp2ILInjected.Address(RVA = "0x907054", Offset = "0x907054", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string GetHoverText()
		{
			throw null;
		}

		// Token: 0x04006FD0 RID: 28624
		[global::Cpp2ILInjected.Token(Token = "0x4008906")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private BestiaryEntry _entry;

		// Token: 0x04006FD1 RID: 28625
		[global::Cpp2ILInjected.Token(Token = "0x4008907")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Asset<Texture2D> _notUnlockedTexture;

		// Token: 0x04006FD2 RID: 28626
		[global::Cpp2ILInjected.Token(Token = "0x4008908")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private bool _isPortrait;

		// Token: 0x04006FD3 RID: 28627
		[global::Cpp2ILInjected.Token(Token = "0x4008909")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
		public bool ForceHover;

		// Token: 0x04006FD4 RID: 28628
		[global::Cpp2ILInjected.Token(Token = "0x400890A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private BestiaryUICollectionInfo _collectionInfo;
	}
}
