﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000595 RID: 1429
	[global::Cpp2ILInjected.Token(Token = "0x2000833")]
	public class ForestBiome : AShoppingBiome
	{
		// Token: 0x06003BD3 RID: 15315 RVA: 0x0002CB0D File Offset: 0x0002AD0D
		[global::Cpp2ILInjected.Token(Token = "0x60042F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x79CFE4", Offset = "0x79CFE4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ForestBiome()
		{
			throw null;
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x0002CB10 File Offset: 0x0002AD10
		[global::Cpp2ILInjected.Token(Token = "0x60042F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D25C", Offset = "0x79D25C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ShoppingZone_Forest", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
