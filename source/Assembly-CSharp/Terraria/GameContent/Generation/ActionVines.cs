﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020005E6 RID: 1510
	[global::Cpp2ILInjected.Token(Token = "0x20008D3")]
	public class ActionVines : GenAction
	{
		// Token: 0x06003D27 RID: 15655 RVA: 0x0002CEB5 File Offset: 0x0002B0B5
		[global::Cpp2ILInjected.Token(Token = "0x6004599")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BC7A4", Offset = "0x7BC7A4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = ".ctor", ReturnType = typeof(void))]
		public ActionVines(int minLength = 6, int maxLength = 10, int vineId = 52)
		{
			throw null;
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x0002CEB8 File Offset: 0x0002B0B8
		[global::Cpp2ILInjected.Token(Token = "0x600459A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BC7E0", Offset = "0x7BC7E0", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			throw null;
		}

		// Token: 0x04006BCC RID: 27596
		[global::Cpp2ILInjected.Token(Token = "0x4008203")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _minLength;

		// Token: 0x04006BCD RID: 27597
		[global::Cpp2ILInjected.Token(Token = "0x4008204")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _maxLength;

		// Token: 0x04006BCE RID: 27598
		[global::Cpp2ILInjected.Token(Token = "0x4008205")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int _vineId;
	}
}
