﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x0200053F RID: 1343
	[global::Cpp2ILInjected.Token(Token = "0x20007B0")]
	public class MinecartDiggerHelper
	{
		// Token: 0x0600394E RID: 14670 RVA: 0x0002C3BA File Offset: 0x0002A5BA
		[global::Cpp2ILInjected.Token(Token = "0x6004013")]
		[global::Cpp2ILInjected.Address(RVA = "0x74F62C", Offset = "0x74F62C", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryUsingDiggerCart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "AlreadyLeadsIntoWantedTrack", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "CanGetPastTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "HasEnoughPickPowerToHurtTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "FindMinecartTrackItem", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "MineTheTileIfNecessary", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "ConsumeATrackItem", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "PlaceATrack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "CorrectTrackConnections", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void TryDigging(Player player, Vector2 trackWorldPosition, int digDirectionX, int digDirectionY)
		{
			throw null;
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x0002C3BD File Offset: 0x0002A5BD
		[global::Cpp2ILInjected.Token(Token = "0x6004014")]
		[global::Cpp2ILInjected.Address(RVA = "0x74FB8C", Offset = "0x74FB8C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "FindMinecartTrackItem", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(Item))]
		private bool CanConsumeATrackItem(Player player)
		{
			throw null;
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x0002C3C0 File Offset: 0x0002A5C0
		[global::Cpp2ILInjected.Token(Token = "0x6004015")]
		[global::Cpp2ILInjected.Address(RVA = "0x74FD34", Offset = "0x74FD34", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "TryDigging", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "FindMinecartTrackItem", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TurnToAir", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void ConsumeATrackItem(Player player)
		{
			throw null;
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x0002C3C3 File Offset: 0x0002A5C3
		[global::Cpp2ILInjected.Token(Token = "0x6004016")]
		[global::Cpp2ILInjected.Address(RVA = "0x74FFE8", Offset = "0x74FFE8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "TryDigging", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "CanConsumeATrackItem", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "ConsumeATrackItem", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		private Item FindMinecartTrackItem(Player player)
		{
			throw null;
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x0002C3C6 File Offset: 0x0002A5C6
		[global::Cpp2ILInjected.Token(Token = "0x6004017")]
		[global::Cpp2ILInjected.Address(RVA = "0x750058", Offset = "0x750058", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "FrameTrack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void PoundTrack(Point spot)
		{
			throw null;
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x0002C3C9 File Offset: 0x0002A5C9
		[global::Cpp2ILInjected.Token(Token = "0x6004018")]
		[global::Cpp2ILInjected.Address(RVA = "0x74F868", Offset = "0x74F868", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "TryDigging", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "DoTheTracksConnectProperly", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "GetExpectedDirections", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(ref int?),
			typeof(ref int?),
			typeof(ref int?),
			typeof(ref int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "GetAreExpectationsForSidesMet", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int?),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool AlreadyLeadsIntoWantedTrack(Point tileCoordsOfFrontWheel, Point tileCoordsWeWantToReach)
		{
			throw null;
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0002C3CC File Offset: 0x0002A5CC
		[global::Cpp2ILInjected.Token(Token = "0x6004019")]
		[global::Cpp2ILInjected.Address(RVA = "0x7501AC", Offset = "0x7501AC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "AlreadyLeadsIntoWantedTrack", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "CorrectTrackConnections", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static void GetExpectedDirections(Point startCoords, Point endCoords, out int? expectedStartLeft, out int? expectedStartRight, out int? expectedEndLeft, out int? expectedEndRight)
		{
			throw null;
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x0002C3CF File Offset: 0x0002A5CF
		[global::Cpp2ILInjected.Token(Token = "0x600401A")]
		[global::Cpp2ILInjected.Address(RVA = "0x74FE80", Offset = "0x74FE80", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "AlreadyLeadsIntoWantedTrack", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		private bool DoTheTracksConnectProperly(Point tileCoordsOfFrontWheel, Point tileCoordsWeWantToReach)
		{
			throw null;
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x0002C3D2 File Offset: 0x0002A5D2
		[global::Cpp2ILInjected.Token(Token = "0x600401B")]
		[global::Cpp2ILInjected.Address(RVA = "0x74FE84", Offset = "0x74FE84", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "TryDigging", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinecartDiggerHelper), Member = "GetExpectedDirections", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(ref int?),
			typeof(ref int?),
			typeof(ref int?),
			typeof(ref int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "TryFittingTileOrientation", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int?),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CorrectTrackConnections(Point startCoords, Point endCoords)
		{
			throw null;
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x0002C3D5 File Offset: 0x0002A5D5
		[global::Cpp2ILInjected.Token(Token = "0x600401C")]
		[global::Cpp2ILInjected.Address(RVA = "0x74FB78", Offset = "0x74FB78", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "HasEnoughPickPowerToHurtTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		private bool HasPickPower(Player player, int x, int y)
		{
			throw null;
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x0002C3D8 File Offset: 0x0002A5D8
		[global::Cpp2ILInjected.Token(Token = "0x600401D")]
		[global::Cpp2ILInjected.Address(RVA = "0x74F9D4", Offset = "0x74F9D4", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "TryDigging", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CheckTileBreakability", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CheckTileBreakability2_ShouldTileSurvive", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CanKillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private bool CanGetPastTile(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0002C3DB File Offset: 0x0002A5DB
		[global::Cpp2ILInjected.Token(Token = "0x600401E")]
		[global::Cpp2ILInjected.Address(RVA = "0x74FD64", Offset = "0x74FD64", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "TryDigging", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void PlaceATrack(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x0002C3DE File Offset: 0x0002A5DE
		[global::Cpp2ILInjected.Token(Token = "0x600401F")]
		[global::Cpp2ILInjected.Address(RVA = "0x74FBA4", Offset = "0x74FBA4", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "TryDigging", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void MineTheTileIfNecessary(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x0002C3E1 File Offset: 0x0002A5E1
		[global::Cpp2ILInjected.Token(Token = "0x6004020")]
		[global::Cpp2ILInjected.Address(RVA = "0x7502C4", Offset = "0x7502C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MinecartDiggerHelper()
		{
			throw null;
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x0002C3E4 File Offset: 0x0002A5E4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004021")]
		[global::Cpp2ILInjected.Address(RVA = "0x7502CC", Offset = "0x7502CC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static MinecartDiggerHelper()
		{
			throw null;
		}

		// Token: 0x040068B1 RID: 26801
		[global::Cpp2ILInjected.Token(Token = "0x4007E00")]
		public static MinecartDiggerHelper Instance;
	}
}
