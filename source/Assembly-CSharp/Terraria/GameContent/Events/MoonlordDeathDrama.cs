﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Utilities;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000691 RID: 1681
	[global::Cpp2ILInjected.Token(Token = "0x2000A51")]
	public class MoonlordDeathDrama
	{
		// Token: 0x06004215 RID: 16917 RVA: 0x0002DCF5 File Offset: 0x0002BEF5
		[global::Cpp2ILInjected.Token(Token = "0x6004E01")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CED64", Offset = "0x8CED64", Length = "0x428")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "get_Dead", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordExplosion), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordExplosion), Member = "get_Dead", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "Distance", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x0002DCF8 File Offset: 0x0002BEF8
		[global::Cpp2ILInjected.Token(Token = "0x6004E02")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CF488", Offset = "0x8CF488", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_WallsTilesNPCs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "InDrawRange", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void DrawPieces(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x0002DCFB File Offset: 0x0002BEFB
		[global::Cpp2ILInjected.Token(Token = "0x6004E03")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CF860", Offset = "0x8CF860", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_WallsTilesNPCs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordExplosion), Member = "InDrawRange", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordExplosion), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void DrawExplosions(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x0002DCFE File Offset: 0x0002BEFE
		[global::Cpp2ILInjected.Token(Token = "0x6004E04")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CFC98", Offset = "0x8CFC98", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void DrawWhite(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x0002DD01 File Offset: 0x0002BF01
		[global::Cpp2ILInjected.Token(Token = "0x6004E05")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CFE80", Offset = "0x8CFE80", Length = "0xA90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public static void ThrowPieces(Vector2 MoonlordCoreCenter, int DramaSeed)
		{
			throw null;
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x0002DD04 File Offset: 0x0002BF04
		[global::Cpp2ILInjected.Token(Token = "0x6004E06")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D0988", Offset = "0x8D0988", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordExplosion), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void AddExplosion(Vector2 spot)
		{
			throw null;
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x0002DD07 File Offset: 0x0002BF07
		[global::Cpp2ILInjected.Token(Token = "0x6004E07")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D0CAC", Offset = "0x8D0CAC", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void RequestLight(float light, Vector2 spot)
		{
			throw null;
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x0002DD0A File Offset: 0x0002BF0A
		[global::Cpp2ILInjected.Token(Token = "0x6004E08")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D0DCC", Offset = "0x8D0DCC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MoonlordDeathDrama()
		{
			throw null;
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x0002DD0D File Offset: 0x0002BF0D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004E09")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D0DD4", Offset = "0x8D0DD4", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static MoonlordDeathDrama()
		{
			throw null;
		}

		// Token: 0x04006DFD RID: 28157
		[global::Cpp2ILInjected.Token(Token = "0x40086C3")]
		private static List<MoonlordDeathDrama.MoonlordPiece> _pieces;

		// Token: 0x04006DFE RID: 28158
		[global::Cpp2ILInjected.Token(Token = "0x40086C4")]
		private static List<MoonlordDeathDrama.MoonlordExplosion> _explosions;

		// Token: 0x04006DFF RID: 28159
		[global::Cpp2ILInjected.Token(Token = "0x40086C5")]
		private static List<Vector2> _lightSources;

		// Token: 0x04006E00 RID: 28160
		[global::Cpp2ILInjected.Token(Token = "0x40086C6")]
		private static float whitening;

		// Token: 0x04006E01 RID: 28161
		[global::Cpp2ILInjected.Token(Token = "0x40086C7")]
		private static float requestedLight;

		// Token: 0x02000A9D RID: 2717
		[global::Cpp2ILInjected.Token(Token = "0x2000A52")]
		public class MoonlordPiece
		{
			// Token: 0x06005218 RID: 21016 RVA: 0x000307B2 File Offset: 0x0002E9B2
			[global::Cpp2ILInjected.Token(Token = "0x6004E0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8D0910", Offset = "0x8D0910", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MoonlordPiece(Texture2D pieceTexture, Vector2 textureOrigin, Vector2 centerPos, Vector2 velocity, float rot, float angularVelocity)
			{
				throw null;
			}

			// Token: 0x06005219 RID: 21017 RVA: 0x000307B5 File Offset: 0x0002E9B5
			[global::Cpp2ILInjected.Token(Token = "0x6004E0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8CF18C", Offset = "0x8CF18C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void Update()
			{
				throw null;
			}

			// Token: 0x0600521A RID: 21018 RVA: 0x000307B8 File Offset: 0x0002E9B8
			[global::Cpp2ILInjected.Token(Token = "0x6004E0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8CF754", Offset = "0x8CF754", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama), Member = "DrawPieces", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "GetLight", ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void Draw(SpriteBatch sp)
			{
				throw null;
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x0600521B RID: 21019 RVA: 0x000307BB File Offset: 0x0002E9BB
			[global::Cpp2ILInjected.Token(Token = "0x1700089C")]
			public bool Dead
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004E0D")]
				[global::Cpp2ILInjected.Address(RVA = "0x8CF23C", Offset = "0x8CF23C", Length = "0xD4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama), Member = "Update", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600521C RID: 21020 RVA: 0x000307BE File Offset: 0x0002E9BE
			[global::Cpp2ILInjected.Token(Token = "0x6004E0E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8CF6C8", Offset = "0x8CF6C8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama), Member = "DrawPieces", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool InDrawRange(Rectangle playerScreen)
			{
				throw null;
			}

			// Token: 0x0600521D RID: 21021 RVA: 0x000307C1 File Offset: 0x0002E9C1
			[global::Cpp2ILInjected.Token(Token = "0x6004E0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8D0F00", Offset = "0x8D0F00", Length = "0x25C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector3),
				typeof(Vector3)
			}, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Division", MemberParameters = new object[]
			{
				typeof(Vector3),
				typeof(float)
			}, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public Color GetLight()
			{
				throw null;
			}

			// Token: 0x04008ED9 RID: 36569
			[global::Cpp2ILInjected.Token(Token = "0x40086C8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Texture2D _texture;

			// Token: 0x04008EDA RID: 36570
			[global::Cpp2ILInjected.Token(Token = "0x40086C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Vector2 _position;

			// Token: 0x04008EDB RID: 36571
			[global::Cpp2ILInjected.Token(Token = "0x40086CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Vector2 _velocity;

			// Token: 0x04008EDC RID: 36572
			[global::Cpp2ILInjected.Token(Token = "0x40086CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Vector2 _origin;

			// Token: 0x04008EDD RID: 36573
			[global::Cpp2ILInjected.Token(Token = "0x40086CC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private float _rotation;

			// Token: 0x04008EDE RID: 36574
			[global::Cpp2ILInjected.Token(Token = "0x40086CD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			private float _rotationVelocity;
		}

		// Token: 0x02000A9E RID: 2718
		[global::Cpp2ILInjected.Token(Token = "0x2000A53")]
		public class MoonlordExplosion
		{
			// Token: 0x0600521E RID: 21022 RVA: 0x000307C4 File Offset: 0x0002E9C4
			[global::Cpp2ILInjected.Token(Token = "0x6004E10")]
			[global::Cpp2ILInjected.Address(RVA = "0x8D0BB0", Offset = "0x8D0BB0", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama), Member = "AddExplosion", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public MoonlordExplosion(Texture2D pieceTexture, Vector2 centerPos, int frameSpeed)
			{
				throw null;
			}

			// Token: 0x0600521F RID: 21023 RVA: 0x000307C7 File Offset: 0x0002E9C7
			[global::Cpp2ILInjected.Token(Token = "0x6004E11")]
			[global::Cpp2ILInjected.Address(RVA = "0x8CF310", Offset = "0x8CF310", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void Update()
			{
				throw null;
			}

			// Token: 0x06005220 RID: 21024 RVA: 0x000307CA File Offset: 0x0002E9CA
			[global::Cpp2ILInjected.Token(Token = "0x6004E12")]
			[global::Cpp2ILInjected.Address(RVA = "0x8CFB2C", Offset = "0x8CFB2C", Length = "0x16C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama), Member = "DrawExplosions", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Draw(SpriteBatch sp)
			{
				throw null;
			}

			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x06005221 RID: 21025 RVA: 0x000307CD File Offset: 0x0002E9CD
			[global::Cpp2ILInjected.Token(Token = "0x1700089D")]
			public bool Dead
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004E13")]
				[global::Cpp2ILInjected.Address(RVA = "0x8CF3A0", Offset = "0x8CF3A0", Length = "0xE8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama), Member = "Update", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005222 RID: 21026 RVA: 0x000307D0 File Offset: 0x0002E9D0
			[global::Cpp2ILInjected.Token(Token = "0x6004E14")]
			[global::Cpp2ILInjected.Address(RVA = "0x8CFAA0", Offset = "0x8CFAA0", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama), Member = "DrawExplosions", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool InDrawRange(Rectangle playerScreen)
			{
				throw null;
			}

			// Token: 0x06005223 RID: 21027 RVA: 0x000307D3 File Offset: 0x0002E9D3
			[global::Cpp2ILInjected.Token(Token = "0x6004E15")]
			[global::Cpp2ILInjected.Address(RVA = "0x8D115C", Offset = "0x8D115C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			public Color GetLight()
			{
				throw null;
			}

			// Token: 0x04008EDF RID: 36575
			[global::Cpp2ILInjected.Token(Token = "0x40086CE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Texture2D _texture;

			// Token: 0x04008EE0 RID: 36576
			[global::Cpp2ILInjected.Token(Token = "0x40086CF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Vector2 _position;

			// Token: 0x04008EE1 RID: 36577
			[global::Cpp2ILInjected.Token(Token = "0x40086D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Vector2 _origin;

			// Token: 0x04008EE2 RID: 36578
			[global::Cpp2ILInjected.Token(Token = "0x40086D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Rectangle _frame;

			// Token: 0x04008EE3 RID: 36579
			[global::Cpp2ILInjected.Token(Token = "0x40086D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private int _frameCounter;

			// Token: 0x04008EE4 RID: 36580
			[global::Cpp2ILInjected.Token(Token = "0x40086D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			private int _frameSpeed;
		}
	}
}
