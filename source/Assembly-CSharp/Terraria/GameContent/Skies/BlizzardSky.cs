﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Initializers;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x0200065A RID: 1626
	[global::Cpp2ILInjected.Token(Token = "0x20009CC")]
	public class BlizzardSky : CustomSky
	{
		// Token: 0x06003F9A RID: 16282 RVA: 0x0002D5AB File Offset: 0x0002B7AB
		[global::Cpp2ILInjected.Token(Token = "0x60049F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x839488", Offset = "0x839488", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x0002D5AE File Offset: 0x0002B7AE
		[global::Cpp2ILInjected.Token(Token = "0x60049F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x83948C", Offset = "0x83948C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x0002D5B1 File Offset: 0x0002B7B1
		[global::Cpp2ILInjected.Token(Token = "0x60049F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x83957C", Offset = "0x83957C", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x0002D5B4 File Offset: 0x0002B7B4
		[global::Cpp2ILInjected.Token(Token = "0x60049F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8397E4", Offset = "0x8397E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x0002D5B7 File Offset: 0x0002B7B7
		[global::Cpp2ILInjected.Token(Token = "0x60049F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8397F0", Offset = "0x8397F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x0002D5BA File Offset: 0x0002B7BA
		[global::Cpp2ILInjected.Token(Token = "0x60049F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8397FC", Offset = "0x8397FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x0002D5BD File Offset: 0x0002B7BD
		[global::Cpp2ILInjected.Token(Token = "0x60049F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x839808", Offset = "0x839808", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0002D5C0 File Offset: 0x0002B7C0
		[global::Cpp2ILInjected.Token(Token = "0x60049F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x839810", Offset = "0x839810", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BlizzardSky()
		{
			throw null;
		}

		// Token: 0x04006CCD RID: 27853
		[global::Cpp2ILInjected.Token(Token = "0x4008497")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UnifiedRandom _random;

		// Token: 0x04006CCE RID: 27854
		[global::Cpp2ILInjected.Token(Token = "0x4008498")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _isActive;

		// Token: 0x04006CCF RID: 27855
		[global::Cpp2ILInjected.Token(Token = "0x4008499")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _isLeaving;

		// Token: 0x04006CD0 RID: 27856
		[global::Cpp2ILInjected.Token(Token = "0x400849A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _opacity;
	}
}
