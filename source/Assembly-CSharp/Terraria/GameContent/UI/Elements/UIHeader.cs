﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006D2 RID: 1746
	[global::Cpp2ILInjected.Token(Token = "0x2000AB6")]
	public class UIHeader : UIElement
	{
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x0002E424 File Offset: 0x0002C624
		// (set) Token: 0x06004482 RID: 17538 RVA: 0x0002E427 File Offset: 0x0002C627
		[global::Cpp2ILInjected.Token(Token = "0x170008C4")]
		public string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x60050D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x928930", Offset = "0x928930", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60050D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x928938", Offset = "0x928938", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHeader), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHeader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x0002E42A File Offset: 0x0002C62A
		[global::Cpp2ILInjected.Token(Token = "0x60050D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x928A28", Offset = "0x928A28", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIHeader), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public UIHeader()
		{
			throw null;
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x0002E42D File Offset: 0x0002C62D
		[global::Cpp2ILInjected.Token(Token = "0x60050D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x928AA0", Offset = "0x928AA0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIHeader), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UIHeader(string text)
		{
			throw null;
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x0002E430 File Offset: 0x0002C630
		[global::Cpp2ILInjected.Token(Token = "0x60050D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x928B10", Offset = "0x928B10", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0400704C RID: 28748
		[global::Cpp2ILInjected.Token(Token = "0x4008993")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private string _text;
	}
}
