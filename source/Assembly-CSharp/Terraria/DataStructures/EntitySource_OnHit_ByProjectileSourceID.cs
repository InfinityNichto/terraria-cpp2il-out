﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000469 RID: 1129
	[global::Cpp2ILInjected.Token(Token = "0x2000665")]
	public class EntitySource_OnHit_ByProjectileSourceID : AEntitySource_OnHit
	{
		// Token: 0x060031E6 RID: 12774 RVA: 0x0002AEE4 File Offset: 0x000290E4
		[global::Cpp2ILInjected.Token(Token = "0x6003703")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D7C8", Offset = "0x141D7C8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_OnHit", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_OnHurt", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetProjectileSource_OnHit", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_OnHit_ByProjectileSourceID(Entity entityStriking, Entity entityStruck, int projectileSourceId)
		{
			throw null;
		}

		// Token: 0x0400641F RID: 25631
		[global::Cpp2ILInjected.Token(Token = "0x400780F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int SourceId;
	}
}
