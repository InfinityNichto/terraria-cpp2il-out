﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.ID;
using Terraria.Localization;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x0200057F RID: 1407
	[global::Cpp2ILInjected.Token(Token = "0x2000818")]
	public class TETrainingDummy : TileEntity
	{
		// Token: 0x06003B62 RID: 15202 RVA: 0x0002C9BD File Offset: 0x0002ABBD
		[global::Cpp2ILInjected.Token(Token = "0x6004279")]
		[global::Cpp2ILInjected.Address(RVA = "0x7932DC", Offset = "0x7932DC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "add__UpdateStart", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void RegisterTileEntityID(int assignedID)
		{
			throw null;
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x0002C9C0 File Offset: 0x0002ABC0
		[global::Cpp2ILInjected.Token(Token = "0x600427A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7933B0", Offset = "0x7933B0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x0002C9C3 File Offset: 0x0002ABC3
		[global::Cpp2ILInjected.Token(Token = "0x600427B")]
		[global::Cpp2ILInjected.Address(RVA = "0x793414", Offset = "0x793414", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void NetPlaceEntity(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x0002C9C6 File Offset: 0x0002ABC6
		[global::Cpp2ILInjected.Token(Token = "0x600427C")]
		[global::Cpp2ILInjected.Address(RVA = "0x793668", Offset = "0x793668", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETrainingDummy), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override TileEntity GenerateInstance()
		{
			throw null;
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x0002C9C9 File Offset: 0x0002ABC9
		[global::Cpp2ILInjected.Token(Token = "0x600427D")]
		[global::Cpp2ILInjected.Address(RVA = "0x79371C", Offset = "0x79371C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsTileValidForEntity(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x0002C9CC File Offset: 0x0002ABCC
		[global::Cpp2ILInjected.Token(Token = "0x600427E")]
		[global::Cpp2ILInjected.Address(RVA = "0x793910", Offset = "0x793910", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Rectangle>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void ClearBoxes()
		{
			throw null;
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x0002C9CF File Offset: 0x0002ABCF
		[global::Cpp2ILInjected.Token(Token = "0x600427F")]
		[global::Cpp2ILInjected.Address(RVA = "0x793990", Offset = "0x793990", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETrainingDummy), Member = "Deactivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETrainingDummy), Member = "FillPlayerHitboxes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Rectangle>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Rectangle>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Rectangle>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETrainingDummy), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override void Update()
		{
			throw null;
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x0002C9D2 File Offset: 0x0002ABD2
		[global::Cpp2ILInjected.Token(Token = "0x6004280")]
		[global::Cpp2ILInjected.Address(RVA = "0x793DA8", Offset = "0x793DA8", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "getRect", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Rectangle>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void FillPlayerHitboxes()
		{
			throw null;
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x0002C9D5 File Offset: 0x0002ABD5
		[global::Cpp2ILInjected.Token(Token = "0x6004281")]
		[global::Cpp2ILInjected.Address(RVA = "0x793780", Offset = "0x793780", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool ValidTile(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x0002C9D8 File Offset: 0x0002ABD8
		[global::Cpp2ILInjected.Token(Token = "0x6004282")]
		[global::Cpp2ILInjected.Address(RVA = "0x7936B8", Offset = "0x7936B8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntitiesManager), Member = "RegisterAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "GenerateInstance", ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TETrainingDummy()
		{
			throw null;
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x0002C9DB File Offset: 0x0002ABDB
		[global::Cpp2ILInjected.Token(Token = "0x6004283")]
		[global::Cpp2ILInjected.Address(RVA = "0x793478", Offset = "0x793478", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "Hook_AfterPlacement", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETrainingDummy), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "AssignNewID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "get_PositionKey", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static int Place(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x0002C9DE File Offset: 0x0002ABDE
		[global::Cpp2ILInjected.Token(Token = "0x6004284")]
		[global::Cpp2ILInjected.Address(RVA = "0x7940B8", Offset = "0x7940B8", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendTileSquare", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TileChangeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETrainingDummy), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static int Hook_AfterPlacement(int x, int y, int type = 378, int style = 0, int direction = 1, int alternate = 0)
		{
			throw null;
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x0002C9E1 File Offset: 0x0002ABE1
		[global::Cpp2ILInjected.Token(Token = "0x6004285")]
		[global::Cpp2ILInjected.Address(RVA = "0x7942A8", Offset = "0x7942A8", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "Check2xX", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "GetKey", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void Kill(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x0002C9E4 File Offset: 0x0002ABE4
		[global::Cpp2ILInjected.Token(Token = "0x6004286")]
		[global::Cpp2ILInjected.Address(RVA = "0x7944C0", Offset = "0x7944C0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "GetKey", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int Find(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x0002C9E7 File Offset: 0x0002ABE7
		[global::Cpp2ILInjected.Token(Token = "0x6004287")]
		[global::Cpp2ILInjected.Address(RVA = "0x7945B8", Offset = "0x7945B8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
			throw null;
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x0002C9EA File Offset: 0x0002ABEA
		[global::Cpp2ILInjected.Token(Token = "0x6004288")]
		[global::Cpp2ILInjected.Address(RVA = "0x7945D4", Offset = "0x7945D4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void ReadExtraData(BinaryReader reader, bool networkSend)
		{
			throw null;
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x0002C9ED File Offset: 0x0002ABED
		[global::Cpp2ILInjected.Token(Token = "0x6004289")]
		[global::Cpp2ILInjected.Address(RVA = "0x793F0C", Offset = "0x793F0C", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_TileEntity), Member = ".ctor", MemberParameters = new object[] { typeof(TileEntity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		public void Activate()
		{
			throw null;
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
		[global::Cpp2ILInjected.Token(Token = "0x600428A")]
		[global::Cpp2ILInjected.Address(RVA = "0x793C9C", Offset = "0x793C9C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Deactivate()
		{
			throw null;
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x0002C9F3 File Offset: 0x0002ABF3
		[global::Cpp2ILInjected.Token(Token = "0x600428B")]
		[global::Cpp2ILInjected.Address(RVA = "0x794604", Offset = "0x794604", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x0002C9F6 File Offset: 0x0002ABF6
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600428C")]
		[global::Cpp2ILInjected.Address(RVA = "0x794770", Offset = "0x794770", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Rectangle>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static TETrainingDummy()
		{
			throw null;
		}

		// Token: 0x04006B01 RID: 27393
		[global::Cpp2ILInjected.Token(Token = "0x40080E8")]
		private static Dictionary<int, Rectangle> playerBox;

		// Token: 0x04006B02 RID: 27394
		[global::Cpp2ILInjected.Token(Token = "0x40080E9")]
		private static bool playerBoxFilled;

		// Token: 0x04006B03 RID: 27395
		[global::Cpp2ILInjected.Token(Token = "0x40080EA")]
		private static byte _myEntityID;

		// Token: 0x04006B04 RID: 27396
		[global::Cpp2ILInjected.Token(Token = "0x40080EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int npc;
	}
}
