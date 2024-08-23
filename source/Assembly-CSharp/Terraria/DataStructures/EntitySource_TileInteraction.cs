﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000457 RID: 1111
	[global::Cpp2ILInjected.Token(Token = "0x2000653")]
	public class EntitySource_TileInteraction : AEntitySource_Tile
	{
		// Token: 0x060031D4 RID: 12756 RVA: 0x0002AEAE File Offset: 0x000290AE
		[global::Cpp2ILInjected.Token(Token = "0x60036F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D4BC", Offset = "0x141D4BC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_TileInteraction", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemSource_TileInteraction", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetNPCSource_TileInteraction", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GetProjectileSource_PlayerOrWires", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(Player)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public EntitySource_TileInteraction(Entity entity, int tileCoordsX, int tileCoordsY)
		{
			throw null;
		}

		// Token: 0x04006413 RID: 25619
		[global::Cpp2ILInjected.Token(Token = "0x4007803")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly Entity Entity;
	}
}
