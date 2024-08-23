﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006DA RID: 1754
	[global::Cpp2ILInjected.Token(Token = "0x2000ABE")]
	public class UIKeybindingSimpleListItem : UIElement
	{
		// Token: 0x060044A6 RID: 17574 RVA: 0x0002E48D File Offset: 0x0002C68D
		[global::Cpp2ILInjected.Token(Token = "0x60050F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A608", Offset = "0x92A608", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public UIKeybindingSimpleListItem(Func<string> getText, Color color)
		{
			throw null;
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x0002E490 File Offset: 0x0002C690
		[global::Cpp2ILInjected.Token(Token = "0x60050F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A720", Offset = "0x92A720", Length = "0x374")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiplyRGBA", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawSettings2Panel", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0400706B RID: 28779
		[global::Cpp2ILInjected.Token(Token = "0x40089B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x141")]
		private Color _color;

		// Token: 0x0400706C RID: 28780
		[global::Cpp2ILInjected.Token(Token = "0x40089B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Func<string> _GetTextFunction;

		// Token: 0x02000AC0 RID: 2752
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000ABF")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600527E RID: 21118 RVA: 0x000308CC File Offset: 0x0002EACC
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60050FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x92AA94", Offset = "0x92AA94", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x0600527F RID: 21119 RVA: 0x000308CF File Offset: 0x0002EACF
			[global::Cpp2ILInjected.Token(Token = "0x60050FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x92AAF0", Offset = "0x92AAF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06005280 RID: 21120 RVA: 0x000308D2 File Offset: 0x0002EAD2
			[global::Cpp2ILInjected.Token(Token = "0x60050FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x92AAF8", Offset = "0x92AAF8", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <.ctor>b__2_0()
			{
				throw null;
			}

			// Token: 0x04008F53 RID: 36691
			[global::Cpp2ILInjected.Token(Token = "0x40089B4")]
			public static readonly UIKeybindingSimpleListItem.<>c <>9;

			// Token: 0x04008F54 RID: 36692
			[global::Cpp2ILInjected.Token(Token = "0x40089B5")]
			public static Func<string> <>9__2_0;
		}
	}
}
