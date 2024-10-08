﻿using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	[global::Cpp2ILInjected.Token(Token = "0x20009F0")]
	public class NetLiquidModule : NetModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004B5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A6A74", Offset = "0x8A6A74", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "BroadcastEachChunkSeparately", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "BroadcastAllChanges", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static NetPacket Serialize(HashSet<int> changes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004B5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A6D20", Offset = "0x8A6D20", Length = "0x488")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "PrepareAndSendToEachPlayerSeparately", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetLiquidModule.ChunkChanges), Member = "BroadcastingCondition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public static NetPacket SerializeForPlayer(int playerIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004B5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7238", Offset = "0x8A7238", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_IsLoaded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_liquid", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7364", Offset = "0x8A7364", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetLiquidModule), Member = "PrepareChunks", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetLiquidModule), Member = "PrepareAndSendToEachPlayerSeparately", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CreateAndBroadcastByChunk(HashSet<int> dirtiedPackedTileCoords)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004B5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7568", Offset = "0x8A7568", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "CreateAndBroadcastByChunk", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetLiquidModule), Member = "SerializeForPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void PrepareAndSendToEachPlayerSeparately()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004B60")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7668", Offset = "0x8A7668", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetLiquidModule), Member = "Serialize", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager.BroadcastCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(NetManager.BroadcastCondition),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static void BroadcastEachChunkSeparately()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004B61")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A73BC", Offset = "0x8A73BC", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "CreateAndBroadcastByChunk", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetLiquidModule), Member = "DistributeChangesIntoChunks", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void PrepareChunks(HashSet<int> dirtiedPackedTileCoords)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004B62")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7B58", Offset = "0x8A7B58", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetLiquidModule), Member = "Serialize", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void BroadcastAllChanges(HashSet<int> dirtiedPackedTileCoords)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004B63")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A78A0", Offset = "0x8A78A0", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "PrepareChunks", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "GetSectionX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "GetSectionY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetLiquidModule.ChunkChanges), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private static void DistributeChangesIntoChunks(HashSet<int> dirtiedPackedTileCoords)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004B64")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7C94", Offset = "0x8A7C94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetLiquidModule()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004B65")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7C9C", Offset = "0x8A7C9C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static NetLiquidModule()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40085AB")]
		private static List<int> _changesForPlayerCache;

		[global::Cpp2ILInjected.Token(Token = "0x40085AC")]
		private static Dictionary<Point, NetLiquidModule.ChunkChanges> _changesByChunkCoords;

		[global::Cpp2ILInjected.Token(Token = "0x20009F1")]
		private class ChunkChanges
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004B66")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A7C00", Offset = "0x8A7C00", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "DistributeChangesIntoChunks", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public ChunkChanges(int x, int y)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004B67")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A71A8", Offset = "0x8A71A8", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "SerializeForPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool BroadcastingCondition(int clientIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40085AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public HashSet<int> DirtiedPackedTileCoords;

			[global::Cpp2ILInjected.Token(Token = "0x40085AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int ChunkX;

			[global::Cpp2ILInjected.Token(Token = "0x40085AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int ChunkY;
		}
	}
}
