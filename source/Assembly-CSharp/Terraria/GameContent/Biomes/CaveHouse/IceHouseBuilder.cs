﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x0200060D RID: 1549
	[global::Cpp2ILInjected.Token(Token = "0x2000912")]
	public class IceHouseBuilder : HouseBuilder
	{
		// Token: 0x06003E24 RID: 15908 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		[global::Cpp2ILInjected.Token(Token = "0x60046CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E2F68", Offset = "0x7E2F68", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateBuilder", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(HouseBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HouseType),
			typeof(IEnumerable<Rectangle>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IceHouseBuilder(IEnumerable<Rectangle> rooms)
		{
			throw null;
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x0002D1A3 File Offset: 0x0002B3A3
		[global::Cpp2ILInjected.Token(Token = "0x60046CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E3820", Offset = "0x7E3820", Length = "0x814")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.Dither), Member = ".ctor", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.Blotches), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.OnlyTiles), Member = ".ctor", MemberParameters = new object[] { typeof(ushort[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetTileKeepWall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions), Member = "Chain", MemberParameters = new object[] { typeof(GenAction[]) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.Offset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActionStalagtite), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.SkipTiles), Member = ".ctor", MemberParameters = new object[] { typeof(ushort[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.ClearWall), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.PlaceWall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 64)]
		protected override void AgeRoom(Rectangle room)
		{
			throw null;
		}
	}
}
