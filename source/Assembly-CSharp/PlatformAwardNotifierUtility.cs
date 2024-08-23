﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Achievements;

// Token: 0x02000208 RID: 520
[global::Cpp2ILInjected.Token(Token = "0x20002AD")]
public class PlatformAwardNotifierUtility
{
	// Token: 0x06000E97 RID: 3735 RVA: 0x000246F5 File Offset: 0x000228F5
	[global::Cpp2ILInjected.Token(Token = "0x6000FC7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39D1C", Offset = "0xA39D1C", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "NotifyNPCKilledDirect", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntHashSet), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static void NoteSlimeDefeatedForPlayer(Player player, eSlimeKillStatistics slimeID)
	{
		throw null;
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x000246F8 File Offset: 0x000228F8
	[global::Cpp2ILInjected.Token(Token = "0x6000FC8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39FDC", Offset = "0xA39FDC", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static void NoteItemCraftedForPlayer(Player player, eCraftingStatistics craftingID)
	{
		throw null;
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x000246FB File Offset: 0x000228FB
	[global::Cpp2ILInjected.Token(Token = "0x6000FC9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3A0CC", Offset = "0xA3A0CC", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static void NoteTraveledForPlayer(Player player, eDistanceStatistics distanceID)
	{
		throw null;
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x000246FE File Offset: 0x000228FE
	[global::Cpp2ILInjected.Token(Token = "0x6000FCA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3A1BC", Offset = "0xA3A1BC", Length = "0x180")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformAwardNotifierUtility), Member = "RegisterKillTileStatistic", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static void NoteMinedForPlayer(Player player, eMiningStatistics miningID)
	{
		throw null;
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00024701 File Offset: 0x00022901
	[global::Cpp2ILInjected.Token(Token = "0x6000FCB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3A33C", Offset = "0xA3A33C", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_02_CopperPickaxe), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_11_Complete), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBuffs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CheckForPetAchievement", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "NoteRunning", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "JumpMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "BordersMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SceneMetrics), Member = "ScanAndExportToMain", MemberParameters = new object[] { typeof(SceneMetricsScanSettings) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "OnPlayerEnteredWorld", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "NotifyNPCKilledDirect", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleOnEquip", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleSpecialEvent", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static void NoteTriggerForPlayer(Player player, eTrigger triggerType)
	{
		throw null;
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x00024704 File Offset: 0x00022904
	[global::Cpp2ILInjected.Token(Token = "0x6000FCC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3A42C", Offset = "0xA3A42C", Length = "0x234")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CountKillForAchievements", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentUserData), Member = "OnKillBoss", MemberParameters = new object[] { typeof(eBossKillStatistics) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public static void NoteBossKillForAllLocalUsers(eBossKillStatistics bossID)
	{
		throw null;
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x00024707 File Offset: 0x00022907
	[global::Cpp2ILInjected.Token(Token = "0x6000FCD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3A740", Offset = "0xA3A740", Length = "0x220")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateInvasion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "Collision_LavaCollision", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CountTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "NotifyProgressionEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "CheckMechaMayhem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public static void NoteTriggerForAllLocalUsers(eTrigger triggerType)
	{
		throw null;
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x0002470A File Offset: 0x0002290A
	[global::Cpp2ILInjected.Token(Token = "0x6000FCE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3A960", Offset = "0xA3A960", Length = "0x2C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "NotifyItemPickup", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "NotifyItemPickup", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "IsArmorForAchievement", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntHashSet), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public static void NoteItemPickedUpForPlayer(Player player, int itemID)
	{
		throw null;
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x0002470D File Offset: 0x0002290D
	[global::Cpp2ILInjected.Token(Token = "0x6000FCF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3AC24", Offset = "0xA3AC24", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteItemPickedUpForPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
	{
		typeof(int[]),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static bool IsArmorForAchievement(int itemID)
	{
		throw null;
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00024710 File Offset: 0x00022910
	[global::Cpp2ILInjected.Token(Token = "0x6000FD0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3ACE8", Offset = "0xA3ACE8", Length = "0x190")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_ItemInExtractinator", MemberParameters = new object[] { typeof(ref Player.ItemCheckContext) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_ApplyHoldStyle", MemberParameters = new object[]
	{
		typeof(float),
		typeof(Item),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "NotifyItemCraft", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "GetAchievementIDFromTileID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntHashSet), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static void NoteCraftingStationUsed(Player player, int tileID)
	{
		throw null;
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00024713 File Offset: 0x00022913
	[global::Cpp2ILInjected.Token(Token = "0x6000FD1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3AE78", Offset = "0xA3AE78", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteCraftingStationUsed", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static int GetAchievementIDFromTileID(int tileID)
	{
		throw null;
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00024716 File Offset: 0x00022916
	[global::Cpp2ILInjected.Token(Token = "0x6000FD2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3AF20", Offset = "0xA3AF20", Length = "0x15C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "NotifyNPCKilledDirect", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static eSlimeKillStatistics GetSlimeStatIDFromNetID(int netID)
	{
		throw null;
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00024719 File Offset: 0x00022919
	[global::Cpp2ILInjected.Token(Token = "0x6000FD3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B07C", Offset = "0xA3B07C", Length = "0x184")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CountKillForAchievements", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public static eBossKillStatistics GetBossStatIDFromNetID(int netID)
	{
		throw null;
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x0002471C File Offset: 0x0002291C
	[global::Cpp2ILInjected.Token(Token = "0x6000FD4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B200", Offset = "0xA3B200", Length = "0x208")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PickTile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteMinedForPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(eMiningStatistics)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void RegisterKillTileStatistic(Player player, int tileType)
	{
		throw null;
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x0002471F File Offset: 0x0002291F
	[global::Cpp2ILInjected.Token(Token = "0x6000FD5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B408", Offset = "0xA3B408", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public PlatformAwardNotifierUtility()
	{
		throw null;
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00024722 File Offset: 0x00022922
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000FD6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B410", Offset = "0xA3B410", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	static PlatformAwardNotifierUtility()
	{
		throw null;
	}

	// Token: 0x04001854 RID: 6228
	[global::Cpp2ILInjected.Token(Token = "0x4001D7B")]
	public static int[] AchievementArmors;

	// Token: 0x04001855 RID: 6229
	[global::Cpp2ILInjected.Token(Token = "0x4001D7C")]
	public static int[] AchievementCraftingStationsTracking;
}
