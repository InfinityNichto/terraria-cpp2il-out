﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000591 RID: 1425
	[global::Cpp2ILInjected.Token(Token = "0x200082F")]
	public class PersonalityDatabase
	{
		// Token: 0x06003BC6 RID: 15302 RVA: 0x0002CAE9 File Offset: 0x0002ACE9
		[global::Cpp2ILInjected.Token(Token = "0x60042E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C440", Offset = "0x79C440", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersonalityProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public PersonalityDatabase()
		{
			throw null;
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x0002CAEC File Offset: 0x0002ACEC
		[global::Cpp2ILInjected.Token(Token = "0x60042EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C564", Offset = "0x79C564", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersonalityProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Register(int npcId, IShopPersonalityTrait trait)
		{
			throw null;
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x0002CAEF File Offset: 0x0002ACEF
		[global::Cpp2ILInjected.Token(Token = "0x60042EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C6C4", Offset = "0x79C6C4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabase), Member = "Register", MemberParameters = new object[]
		{
			typeof(IShopPersonalityTrait),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersonalityDatabase), Member = "Register", MemberParameters = new object[]
		{
			typeof(IShopPersonalityTrait),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Register(IShopPersonalityTrait trait, params int[] npcIds)
		{
			throw null;
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x0002CAF2 File Offset: 0x0002ACF2
		[global::Cpp2ILInjected.Token(Token = "0x60042EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C764", Offset = "0x79C764", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PersonalityProfile GetByNPCID(int npcId)
		{
			throw null;
		}

		// Token: 0x04006B34 RID: 27444
		[global::Cpp2ILInjected.Token(Token = "0x4008131")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<int, PersonalityProfile> _personalityProfiles;

		// Token: 0x04006B35 RID: 27445
		[global::Cpp2ILInjected.Token(Token = "0x4008132")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private PersonalityProfile _trashEntry;
	}
}
