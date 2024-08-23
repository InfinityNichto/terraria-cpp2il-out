﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004FC RID: 1276
	[global::Cpp2ILInjected.Token(Token = "0x2000758")]
	public class FlameParticle : ABasicParticle
	{
		// Token: 0x0600376C RID: 14188 RVA: 0x0002BE74 File Offset: 0x0002A074
		[global::Cpp2ILInjected.Token(Token = "0x6003DE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6AD4", Offset = "0x14A6AD4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		public override void FetchFromPool()
		{
			throw null;
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x0002BE77 File Offset: 0x0002A077
		[global::Cpp2ILInjected.Token(Token = "0x6003DE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6AF8", Offset = "0x14A6AF8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "SetBasicInfo", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Rectangle?),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public override void SetBasicInfo(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
		{
			throw null;
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x0002BE7A File Offset: 0x0002A07A
		[global::Cpp2ILInjected.Token(Token = "0x6003DE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6B5C", Offset = "0x14A6B5C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_FlameWaders", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_WallOfFleshGoatMountFlames", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void SetTypeInfo(float timeToLive, int indexOfPlayerWhoSpawnedIt, int packedShaderIndex)
		{
			throw null;
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x0002BE7D File Offset: 0x0002A07D
		[global::Cpp2ILInjected.Token(Token = "0x6003DE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6B68", Offset = "0x14A6B68", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		public override void Update(ref ParticleRendererSettings settings)
		{
			throw null;
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x0002BE80 File Offset: 0x0002A080
		[global::Cpp2ILInjected.Token(Token = "0x6003DE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6B9C", Offset = "0x14A6B9C", Length = "0x580")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomInt", MemberParameters = new object[]
		{
			typeof(ref ulong),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHelper), Member = "SetShaderForData", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(ref DrawData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_pixelShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			throw null;
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x0002BE83 File Offset: 0x0002A083
		[global::Cpp2ILInjected.Token(Token = "0x6003DE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A711C", Offset = "0x14A711C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "GetNewFlameParticle", ReturnType = typeof(FlameParticle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = ".ctor", ReturnType = typeof(void))]
		public FlameParticle()
		{
			throw null;
		}

		// Token: 0x040067B5 RID: 26549
		[global::Cpp2ILInjected.Token(Token = "0x4007C9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public float FadeOutNormalizedTime;

		// Token: 0x040067B6 RID: 26550
		[global::Cpp2ILInjected.Token(Token = "0x4007C9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private float _timeTolive;

		// Token: 0x040067B7 RID: 26551
		[global::Cpp2ILInjected.Token(Token = "0x4007C9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private float _timeSinceSpawn;

		// Token: 0x040067B8 RID: 26552
		[global::Cpp2ILInjected.Token(Token = "0x4007CA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private int _indexOfPlayerWhoSpawnedThis;

		// Token: 0x040067B9 RID: 26553
		[global::Cpp2ILInjected.Token(Token = "0x4007CA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private int _packedShaderIndex;
	}
}
