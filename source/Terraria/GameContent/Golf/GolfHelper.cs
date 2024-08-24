﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.GameContent.Metadata;
using Terraria.Graphics;
using Terraria.Localization;
using Terraria.Physics;
using Terraria.Utilities;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000678 RID: 1656
	[global::Cpp2ILInjected.Token(Token = "0x2000A03")]
	public static class GolfHelper
	{
		// Token: 0x06004126 RID: 16678 RVA: 0x0002DA4F File Offset: 0x0002BC4F
		[global::Cpp2ILInjected.Token(Token = "0x6004BAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD924", Offset = "0x8AD924", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_149_GolfBall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Update", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "Step", MemberParameters = new object[]
		{
			typeof(PhysicsProperties),
			typeof(Entity),
			typeof(ref float),
			typeof(IBallContactListener)
		}, ReturnType = typeof(BallStepResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static BallStepResult StepGolfBall(Entity entity, ref float angularVelocity)
		{
			throw null;
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x0002DA52 File Offset: 0x0002BC52
		[global::Cpp2ILInjected.Token(Token = "0x6004BAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD9A0", Offset = "0x8AD9A0", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "CalculateShotStrength", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(GolfHelper.ClubProperties)
		}, ReturnType = typeof(GolfHelper.ShotStrength))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Vector2 FindVectorOnOval(Vector2 vector, Vector2 radius)
		{
			throw null;
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x0002DA55 File Offset: 0x0002BC55
		[global::Cpp2ILInjected.Token(Token = "0x6004BAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ADAE8", Offset = "0x8ADAE8", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "CalculateShotStrength", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Entity)
		}, ReturnType = typeof(GolfHelper.ShotStrength))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper), Member = "FindVectorOnOval", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static GolfHelper.ShotStrength CalculateShotStrength(Vector2 shotVector, GolfHelper.ClubProperties clubProperties)
		{
			throw null;
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x0002DA58 File Offset: 0x0002BC58
		[global::Cpp2ILInjected.Token(Token = "0x6004BAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ADC80", Offset = "0x8ADC80", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_HeldItem", ReturnType = typeof(Item))]
		public static bool IsPlayerHoldingClub(Player player)
		{
			throw null;
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x0002DA5B File Offset: 0x0002BC5B
		[global::Cpp2ILInjected.Token(Token = "0x6004BAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ADCE4", Offset = "0x8ADCE4", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_Resources_GolfPower", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_150_GolfClubHelper", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper), Member = "GetClubPropertiesFromGolfHelper", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(GolfHelper.ClubProperties))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper), Member = "CalculateShotStrength", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(GolfHelper.ClubProperties)
		}, ReturnType = typeof(GolfHelper.ShotStrength))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static GolfHelper.ShotStrength CalculateShotStrength(Projectile golfHelper, Entity golfBall)
		{
			throw null;
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x0002DA5E File Offset: 0x0002BC5E
		[global::Cpp2ILInjected.Token(Token = "0x6004BB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ADE88", Offset = "0x8ADE88", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "CalculateShotStrength", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Entity)
		}, ReturnType = typeof(GolfHelper.ShotStrength))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_HeldItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper), Member = "GetClubProperties", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(GolfHelper.ClubProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static GolfHelper.ClubProperties GetClubPropertiesFromGolfHelper(Projectile golfHelper)
		{
			throw null;
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x0002DA61 File Offset: 0x0002BC61
		[global::Cpp2ILInjected.Token(Token = "0x6004BB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ADF54", Offset = "0x8ADF54", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "GetClubPropertiesFromGolfHelper", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(GolfHelper.ClubProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static GolfHelper.ClubProperties GetClubProperties(short itemId)
		{
			throw null;
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x0002DA64 File Offset: 0x0002BC64
		[global::Cpp2ILInjected.Token(Token = "0x6004BB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AE140", Offset = "0x8AE140", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Projectile FindHelperFromGolfBall(Projectile golfBall)
		{
			throw null;
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x0002DA67 File Offset: 0x0002BC67
		[global::Cpp2ILInjected.Token(Token = "0x6004BB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AE1FC", Offset = "0x8AE1FC", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_Resources_GolfPower", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper), Member = "ValidateShot", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Player),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static Projectile FindGolfBallForHelper(Projectile golfHelper)
		{
			throw null;
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x0002DA6A File Offset: 0x0002BC6A
		[global::Cpp2ILInjected.Token(Token = "0x6004BB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AE620", Offset = "0x8AE620", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_GolfBallIndicator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsGolfBallResting(Projectile golfBall)
		{
			throw null;
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x0002DA6D File Offset: 0x0002BC6D
		[global::Cpp2ILInjected.Token(Token = "0x6004BB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AE6F0", Offset = "0x8AE6F0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsGolfShotValid(Entity golfBall, Player player)
		{
			throw null;
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x0002DA70 File Offset: 0x0002BC70
		[global::Cpp2ILInjected.Token(Token = "0x6004BB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AE3E0", Offset = "0x8AE3E0", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_150_GolfClubHelper", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "FindGolfBallForHelper", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(Projectile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool ValidateShot(Entity golfBall, Player player, ref Vector2 shotVector)
		{
			throw null;
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x0002DA73 File Offset: 0x0002BC73
		[global::Cpp2ILInjected.Token(Token = "0x6004BB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AE7E8", Offset = "0x8AE7E8", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_150_GolfClubHelper", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Update", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileMaterials), Member = "GetByTileId", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(TileMaterial))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalGolfState", ReturnType = typeof(GolfState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "RecordSwing", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void HitGolfBall(Entity entity, Vector2 velocity, float roughLandResistance)
		{
			throw null;
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x0002DA76 File Offset: 0x0002BC76
		[global::Cpp2ILInjected.Token(Token = "0x6004BB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AEA7C", Offset = "0x8AEA7C", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyGolfPredictionLine), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyGolfPredictionLine), Member = "Update", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyGolfPredictionLine), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(SpriteBatch),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void DrawPredictionLine(Entity golfBall, Vector2 impactVelocity, float chargeProgress, float roughLandResistance)
		{
			throw null;
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x0002DA79 File Offset: 0x0002BC79
		[Conditional("ENABLE_DEBUG")]
		[Conditional("UNITY_EDITOR")]
		[global::Cpp2ILInjected.Token(Token = "0x6004BB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AF33C", Offset = "0x8AF33C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void UpdateDebugDraw(Vector2 position)
		{
			throw null;
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x0002DA7C File Offset: 0x0002BC7C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004BBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AF340", Offset = "0x8AF340", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PhysicsProperties), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static GolfHelper()
		{
			throw null;
		}

		// Token: 0x04006D9A RID: 28058
		[global::Cpp2ILInjected.Token(Token = "0x40085F9")]
		private static FancyGolfPredictionLine _predictionLine;

		// Token: 0x04006D9B RID: 28059
		[global::Cpp2ILInjected.Token(Token = "0x40085FA")]
		public const int PointsNeededForLevel1 = 500;

		// Token: 0x04006D9C RID: 28060
		[global::Cpp2ILInjected.Token(Token = "0x40085FB")]
		public const int PointsNeededForLevel2 = 1000;

		// Token: 0x04006D9D RID: 28061
		[global::Cpp2ILInjected.Token(Token = "0x40085FC")]
		public const int PointsNeededForLevel3 = 2000;

		// Token: 0x04006D9E RID: 28062
		[global::Cpp2ILInjected.Token(Token = "0x40085FD")]
		public static readonly PhysicsProperties PhysicsProperties;

		// Token: 0x04006D9F RID: 28063
		[global::Cpp2ILInjected.Token(Token = "0x40085FE")]
		public static readonly GolfHelper.ContactListener Listener;

		// Token: 0x02000A6A RID: 2666
		[global::Cpp2ILInjected.Token(Token = "0x2000A04")]
		public struct ClubProperties
		{
			// Token: 0x060050B1 RID: 20657 RVA: 0x000303B0 File Offset: 0x0002E5B0
			[global::Cpp2ILInjected.Token(Token = "0x6004BBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x8AE130", Offset = "0x8AE130", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public ClubProperties(Vector2 minimumStrength, Vector2 maximumStrength, float roughLandResistance)
			{
				throw null;
			}

			// Token: 0x04008E78 RID: 36472
			[global::Cpp2ILInjected.Token(Token = "0x40085FF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly Vector2 MinimumStrength;

			// Token: 0x04008E79 RID: 36473
			[global::Cpp2ILInjected.Token(Token = "0x4008600")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly Vector2 MaximumStrength;

			// Token: 0x04008E7A RID: 36474
			[global::Cpp2ILInjected.Token(Token = "0x4008601")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly float RoughLandResistance;
		}

		// Token: 0x02000A6B RID: 2667
		[global::Cpp2ILInjected.Token(Token = "0x2000A05")]
		public struct ShotStrength
		{
			// Token: 0x060050B2 RID: 20658 RVA: 0x000303B3 File Offset: 0x0002E5B3
			[global::Cpp2ILInjected.Token(Token = "0x6004BBC")]
			[global::Cpp2ILInjected.Address(RVA = "0x8ADC74", Offset = "0x8ADC74", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public ShotStrength(float absoluteStrength, float relativeStrength, float roughLandResistance)
			{
				throw null;
			}

			// Token: 0x04008E7B RID: 36475
			[global::Cpp2ILInjected.Token(Token = "0x4008602")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly float AbsoluteStrength;

			// Token: 0x04008E7C RID: 36476
			[global::Cpp2ILInjected.Token(Token = "0x4008603")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly float RelativeStrength;

			// Token: 0x04008E7D RID: 36477
			[global::Cpp2ILInjected.Token(Token = "0x4008604")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly float RoughLandResistance;
		}

		// Token: 0x02000A6C RID: 2668
		[global::Cpp2ILInjected.Token(Token = "0x2000A06")]
		public class ContactListener : IBallContactListener
		{
			// Token: 0x060050B3 RID: 20659 RVA: 0x000303B6 File Offset: 0x0002E5B6
			[global::Cpp2ILInjected.Token(Token = "0x6004BBD")]
			[global::Cpp2ILInjected.Address(RVA = "0x8AF404", Offset = "0x8AF404", Length = "0x508")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileMaterials), Member = "GetByTileId", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(TileMaterial))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Dot", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(BallCollisionEvent)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(Vector2?),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Dust))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2CircularEdge", MemberParameters = new object[]
			{
				typeof(UnifiedRandom),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			public void OnCollision(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref BallCollisionEvent collision)
			{
				throw null;
			}

			// Token: 0x060050B4 RID: 20660 RVA: 0x000303B9 File Offset: 0x0002E5B9
			[global::Cpp2ILInjected.Token(Token = "0x6004BBE")]
			[global::Cpp2ILInjected.Address(RVA = "0x8AF90C", Offset = "0x8AF90C", Length = "0x350")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "OnCollision", MemberParameters = new object[]
			{
				typeof(PhysicsProperties),
				typeof(ref Vector2),
				typeof(ref Vector2),
				typeof(ref BallCollisionEvent)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalGolfState", ReturnType = typeof(GolfState))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "get_ShouldScoreHole", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "SetScoreTime", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "RecordBallInfo", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "LandBall", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "GetGolfBallScore", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "AccumulateGolfingScore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup_TextAndEffects", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "ResetScoreTime", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Wiring), Member = "HitSwitch", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(NetworkText),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			public void PutBallInCup(Projectile proj, BallCollisionEvent collision)
			{
				throw null;
			}

			// Token: 0x060050B5 RID: 20661 RVA: 0x000303BC File Offset: 0x0002E5BC
			[global::Cpp2ILInjected.Token(Token = "0x6004BBF")]
			[global::Cpp2ILInjected.Address(RVA = "0x8AFC5C", Offset = "0x8AFC5C", Length = "0x490")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(BallCollisionEvent)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper.ContactListener), Member = "EmitGolfballExplosion", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetProjectileName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(NetworkText))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte),
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "BroadcastChatMessage", MemberParameters = new object[]
			{
				typeof(NetworkText),
				typeof(Color),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
			public static void PutBallInCup_TextAndEffects(Point hitLocation, int plr, int numberOfHits, int projid)
			{
				throw null;
			}

			// Token: 0x060050B6 RID: 20662 RVA: 0x000303BF File Offset: 0x0002E5BF
			[global::Cpp2ILInjected.Token(Token = "0x6004BC0")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B0B2C", Offset = "0x8B0B2C", Length = "0x178")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileMaterials), Member = "GetByTileId", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(TileMaterial))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public void OnPassThrough(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref float angularVelocity, ref BallPassThroughEvent collision)
			{
				throw null;
			}

			// Token: 0x060050B7 RID: 20663 RVA: 0x000303C2 File Offset: 0x0002E5C2
			[global::Cpp2ILInjected.Token(Token = "0x6004BC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B0CA4", Offset = "0x8B0CA4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper.ContactListener), Member = "EmitGolfballExplosion", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			public static void EmitGolfballExplosion_Old(Vector2 Center)
			{
				throw null;
			}

			// Token: 0x060050B8 RID: 20664 RVA: 0x000303C5 File Offset: 0x0002E5C5
			[global::Cpp2ILInjected.Token(Token = "0x6004BC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B00EC", Offset = "0x8B00EC", Length = "0xA40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup_TextAndEffects", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "EmitGolfballExplosion_Old", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(LegacySoundStyle),
				typeof(Vector2)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(Vector2?),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Dust))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(byte)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
			{
				typeof(UnifiedRandom),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
			public static void EmitGolfballExplosion(Vector2 Center)
			{
				throw null;
			}

			// Token: 0x060050B9 RID: 20665 RVA: 0x000303C8 File Offset: 0x0002E5C8
			[global::Cpp2ILInjected.Token(Token = "0x6004BC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B0CA8", Offset = "0x8B0CA8", Length = "0x5E4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(Vector2?),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Dust))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			private static void EmitGolfballExplosion_v1(Vector2 Center)
			{
				throw null;
			}

			// Token: 0x060050BA RID: 20666 RVA: 0x000303CB File Offset: 0x0002E5CB
			[global::Cpp2ILInjected.Token(Token = "0x6004BC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x8AF3FC", Offset = "0x8AF3FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ContactListener()
			{
				throw null;
			}
		}
	}
}