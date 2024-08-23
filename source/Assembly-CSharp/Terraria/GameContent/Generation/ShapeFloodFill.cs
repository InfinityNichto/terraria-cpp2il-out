﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020005EB RID: 1515
	[global::Cpp2ILInjected.Token(Token = "0x20008D9")]
	public class ShapeFloodFill : GenShape
	{
		// Token: 0x06003D38 RID: 15672 RVA: 0x0002CEDC File Offset: 0x0002B0DC
		[global::Cpp2ILInjected.Token(Token = "0x60045AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BF200", Offset = "0x7BF200", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = ".ctor", ReturnType = typeof(void))]
		public ShapeFloodFill(int maximumActions = 100)
		{
			throw null;
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x0002CEDF File Offset: 0x0002B0DF
		[global::Cpp2ILInjected.Token(Token = "0x60045AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BF228", Offset = "0x7BF228", Length = "0x700")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<Point>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<Point>), Member = "Enqueue", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "StartNewSearch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<Point>), Member = "Dequeue", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "Safe", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_TileSeachUID", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
		{
			typeof(GenAction),
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetTileSeachUID", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public override bool Perform(Point origin, GenAction action)
		{
			throw null;
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x0002CEE2 File Offset: 0x0002B0E2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60045AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BF928", Offset = "0x7BF928", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ShapeFloodFill()
		{
			throw null;
		}

		// Token: 0x04006BD6 RID: 27606
		[global::Cpp2ILInjected.Token(Token = "0x4008211")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _maximumActions;

		// Token: 0x04006BD7 RID: 27607
		[global::Cpp2ILInjected.Token(Token = "0x4008212")]
		private static Queue<Point> checkQueue;
	}
}