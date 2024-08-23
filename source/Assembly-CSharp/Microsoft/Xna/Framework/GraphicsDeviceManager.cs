﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Shaders;
using UnityEngine;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000276 RID: 630
	[global::Cpp2ILInjected.Token(Token = "0x2000337")]
	public class GraphicsDeviceManager
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x000254CC File Offset: 0x000236CC
		[global::Cpp2ILInjected.Token(Token = "0x1700020F")]
		public GraphicsDevice GraphicsDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014BA")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96510", Offset = "0xA96510", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "OnRenderImage", MemberParameters = new object[]
			{
				typeof(RenderTexture),
				typeof(RenderTexture)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PixelShader), Member = "ApplyValuesToMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Material)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetDisplayMode", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureManager), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "DrawTrail", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "Apply", MemberParameters = new object[]
			{
				typeof(Entity),
				typeof(DrawData?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderData), Member = "Apply", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(DrawData?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "Apply", MemberParameters = new object[] { typeof(DrawData?) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x000254CF File Offset: 0x000236CF
		[global::Cpp2ILInjected.Token(Token = "0x60014BB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96518", Offset = "0xA96518", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GraphicsDeviceManager(Game game)
		{
			throw null;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x000254D2 File Offset: 0x000236D2
		[global::Cpp2ILInjected.Token(Token = "0x17000210")]
		public bool IsFullScreen
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014BC")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96540", Offset = "0xA96540", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ToggleFullScreen", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetResolution", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetDisplayMode", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "UpdateButtons", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "DrawButtons", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000254D5 File Offset: 0x000236D5
		[global::Cpp2ILInjected.Token(Token = "0x60014BD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96548", Offset = "0xA96548", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClientInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetDisplayMode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void ApplyChanges()
		{
			throw null;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x000254D8 File Offset: 0x000236D8
		[global::Cpp2ILInjected.Token(Token = "0x60014BE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9654C", Offset = "0xA9654C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetDisplayMode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void ToggleFullScreen()
		{
			throw null;
		}

		// Token: 0x04001CDD RID: 7389
		[global::Cpp2ILInjected.Token(Token = "0x40022B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Game game;

		// Token: 0x04001CDE RID: 7390
		[global::Cpp2ILInjected.Token(Token = "0x40022B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool SynchronizeWithVerticalRetrace;

		// Token: 0x04001CDF RID: 7391
		[global::Cpp2ILInjected.Token(Token = "0x40022B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int PreferredBackBufferWidth;

		// Token: 0x04001CE0 RID: 7392
		[global::Cpp2ILInjected.Token(Token = "0x40022BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int PreferredBackBufferHeight;

		// Token: 0x04001CE1 RID: 7393
		[global::Cpp2ILInjected.Token(Token = "0x40022BB")]
		public static int DefaultBackBufferWidth;

		// Token: 0x04001CE2 RID: 7394
		[global::Cpp2ILInjected.Token(Token = "0x40022BC")]
		public static int DefaultBackBufferHeight;
	}
}
