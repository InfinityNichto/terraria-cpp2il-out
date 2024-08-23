﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Achievements;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x0200064F RID: 1615
	[global::Cpp2ILInjected.Token(Token = "0x20009A4")]
	public class AchievementsHelper
	{
		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06003F2C RID: 16172 RVA: 0x0002D461 File Offset: 0x0002B661
		// (remove) Token: 0x06003F2D RID: 16173 RVA: 0x0002D464 File Offset: 0x0002B664
		[global::Cpp2ILInjected.Token(Token = "0x14000056")]
		public static event AchievementsHelper.ItemPickupEvent OnItemPickup
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004905")]
			[global::Cpp2ILInjected.Address(RVA = "0x8280C8", Offset = "0x8280C8", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemPickupCondition), Member = "ListenForPickup", MemberParameters = new object[] { typeof(ItemPickupCondition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004906")]
			[global::Cpp2ILInjected.Address(RVA = "0x828180", Offset = "0x828180", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06003F2E RID: 16174 RVA: 0x0002D467 File Offset: 0x0002B667
		// (remove) Token: 0x06003F2F RID: 16175 RVA: 0x0002D46A File Offset: 0x0002B66A
		[global::Cpp2ILInjected.Token(Token = "0x14000057")]
		public static event AchievementsHelper.ItemCraftEvent OnItemCraft
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004907")]
			[global::Cpp2ILInjected.Address(RVA = "0x828238", Offset = "0x828238", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemCraftCondition), Member = "ListenForCraft", MemberParameters = new object[] { typeof(ItemCraftCondition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004908")]
			[global::Cpp2ILInjected.Address(RVA = "0x8282F4", Offset = "0x8282F4", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06003F30 RID: 16176 RVA: 0x0002D46D File Offset: 0x0002B66D
		// (remove) Token: 0x06003F31 RID: 16177 RVA: 0x0002D470 File Offset: 0x0002B670
		[global::Cpp2ILInjected.Token(Token = "0x14000058")]
		public static event AchievementsHelper.TileDestroyedEvent OnTileDestroyed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004909")]
			[global::Cpp2ILInjected.Address(RVA = "0x8283B0", Offset = "0x8283B0", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDestroyedCondition), Member = "ListenForDestruction", MemberParameters = new object[] { typeof(TileDestroyedCondition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600490A")]
			[global::Cpp2ILInjected.Address(RVA = "0x82846C", Offset = "0x82846C", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06003F32 RID: 16178 RVA: 0x0002D473 File Offset: 0x0002B673
		// (remove) Token: 0x06003F33 RID: 16179 RVA: 0x0002D476 File Offset: 0x0002B676
		[global::Cpp2ILInjected.Token(Token = "0x14000059")]
		public static event AchievementsHelper.NPCKilledEvent OnNPCKilled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600490B")]
			[global::Cpp2ILInjected.Address(RVA = "0x828528", Offset = "0x828528", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKilledCondition), Member = "ListenForPickup", MemberParameters = new object[] { typeof(NPCKilledCondition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600490C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8285E4", Offset = "0x8285E4", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06003F34 RID: 16180 RVA: 0x0002D479 File Offset: 0x0002B679
		// (remove) Token: 0x06003F35 RID: 16181 RVA: 0x0002D47C File Offset: 0x0002B67C
		[global::Cpp2ILInjected.Token(Token = "0x1400005A")]
		public static event AchievementsHelper.ProgressionEventEvent OnProgressionEvent
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600490D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8286A0", Offset = "0x8286A0", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProgressionEventCondition), Member = "ListenForPickup", MemberParameters = new object[] { typeof(ProgressionEventCondition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600490E")]
			[global::Cpp2ILInjected.Address(RVA = "0x82875C", Offset = "0x82875C", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06003F36 RID: 16182 RVA: 0x0002D47F File Offset: 0x0002B67F
		// (set) Token: 0x06003F37 RID: 16183 RVA: 0x0002D482 File Offset: 0x0002B682
		[global::Cpp2ILInjected.Token(Token = "0x1700084A")]
		public static bool CurrentlyMining
		{
			[global::Cpp2ILInjected.Token(Token = "0x600490F")]
			[global::Cpp2ILInjected.Address(RVA = "0x828818", Offset = "0x828818", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004910")]
			[global::Cpp2ILInjected.Address(RVA = "0x828860", Offset = "0x828860", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x0002D485 File Offset: 0x0002B685
		[global::Cpp2ILInjected.Token(Token = "0x6004911")]
		[global::Cpp2ILInjected.Address(RVA = "0x8288AC", Offset = "0x8288AC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void NotifyTileDestroyed(Player player, ushort tile)
		{
			throw null;
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x0002D488 File Offset: 0x0002B688
		[global::Cpp2ILInjected.Token(Token = "0x6004912")]
		[global::Cpp2ILInjected.Address(RVA = "0x828964", Offset = "0x828964", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_VoidVault", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot_VoidBag", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillEmptyInventorySlot_VoidBag", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillEmptyInventorySlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "Create", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SwapVanityEquip", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteItemPickedUpForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void NotifyItemPickup(Player player, Item item)
		{
			throw null;
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x0002D48B File Offset: 0x0002B68B
		[global::Cpp2ILInjected.Token(Token = "0x6004913")]
		[global::Cpp2ILInjected.Address(RVA = "0x828A10", Offset = "0x828A10", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_VoidVault", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot_VoidBag", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteItemPickedUpForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void NotifyItemPickup(Player player, Item item, int customStack)
		{
			throw null;
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x0002D48E File Offset: 0x0002B68E
		[global::Cpp2ILInjected.Token(Token = "0x6004914")]
		[global::Cpp2ILInjected.Address(RVA = "0x828AC0", Offset = "0x828AC0", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "Create", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "IsMetalBar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteCraftingStationUsed", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void NotifyItemCraft(Recipe recipe)
		{
			throw null;
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x0002D491 File Offset: 0x0002B691
		[global::Cpp2ILInjected.Token(Token = "0x6004915")]
		[global::Cpp2ILInjected.Address(RVA = "0x828ECC", Offset = "0x828ECC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player.Hooks), Member = "add_OnEnterWorld", MemberParameters = new object[] { typeof(Action<Player>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x0002D494 File Offset: 0x0002B694
		[global::Cpp2ILInjected.Token(Token = "0x6004916")]
		[global::Cpp2ILInjected.Address(RVA = "0x828F40", Offset = "0x828F40", Length = "0x9A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteTriggerForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(eTrigger)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsItemSlotUnlockedAndUsable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CheckAchievement_RealEstateAndTownSlimes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		internal static void OnPlayerEnteredWorld(Player player)
		{
			throw null;
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x0002D497 File Offset: 0x0002B697
		[global::Cpp2ILInjected.Token(Token = "0x6004917")]
		[global::Cpp2ILInjected.Address(RVA = "0x8298E4", Offset = "0x8298E4", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CountKillForAchievements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyNPCKilledDirect", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void NotifyNPCKilled(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x0002D49A File Offset: 0x0002B69A
		[global::Cpp2ILInjected.Token(Token = "0x6004918")]
		[global::Cpp2ILInjected.Address(RVA = "0x829A28", Offset = "0x829A28", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "NotifyNPCKilled", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteTriggerForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(eTrigger)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "GetSlimeStatIDFromNetID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(eSlimeKillStatistics))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteSlimeDefeatedForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(eSlimeKillStatistics)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void NotifyNPCKilledDirect(Player player, int npcNetID)
		{
			throw null;
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x0002D49D File Offset: 0x0002B69D
		[global::Cpp2ILInjected.Token(Token = "0x6004919")]
		[global::Cpp2ILInjected.Address(RVA = "0x829B2C", Offset = "0x829B2C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteTriggerForAllLocalUsers", MemberParameters = new object[] { typeof(eTrigger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void NotifyProgressionEvent(int eventID)
		{
			throw null;
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x0002D4A0 File Offset: 0x0002B6A0
		[global::Cpp2ILInjected.Token(Token = "0x600491A")]
		[global::Cpp2ILInjected.Address(RVA = "0x829D00", Offset = "0x829D00", Length = "0x3E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SwapVanityEquip", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SwapEquip", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteTriggerForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(eTrigger)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsItemSlotUnlockedAndUsable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static void HandleOnEquip(Player player, Item item, int context)
		{
			throw null;
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x0002D4A3 File Offset: 0x0002B6A3
		[global::Cpp2ILInjected.Token(Token = "0x600491B")]
		[global::Cpp2ILInjected.Address(RVA = "0x82A0E4", Offset = "0x82A0E4", Length = "0x6E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteTriggerForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(eTrigger)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		public static void HandleSpecialEvent(Player player, int eventID)
		{
			throw null;
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x0002D4A6 File Offset: 0x0002B6A6
		[global::Cpp2ILInjected.Token(Token = "0x600491C")]
		[global::Cpp2ILInjected.Address(RVA = "0x82A7C8", Offset = "0x82A7C8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option1Clicked", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void HandleNurseService(int coinsSpent)
		{
			throw null;
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x0002D4A9 File Offset: 0x0002B6A9
		[global::Cpp2ILInjected.Token(Token = "0x600491D")]
		[global::Cpp2ILInjected.Address(RVA = "0x82A9D4", Offset = "0x82A9D4", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option1Clicked", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomIntCondition), Member = "set_Value", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void HandleAnglerService()
		{
			throw null;
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x0002D4AC File Offset: 0x0002B6AC
		[global::Cpp2ILInjected.Token(Token = "0x600491E")]
		[global::Cpp2ILInjected.Address(RVA = "0x82AD58", Offset = "0x82AD58", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomFloatCondition), Member = "set_Value", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void HandleRunning(Player player, float pixelsMoved)
		{
			throw null;
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x0002D4AF File Offset: 0x0002B6AF
		[global::Cpp2ILInjected.Token(Token = "0x600491F")]
		[global::Cpp2ILInjected.Address(RVA = "0x82AF10", Offset = "0x82AF10", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PickTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomIntCondition), Member = "set_Value", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void HandleMining()
		{
			throw null;
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x0002D4B2 File Offset: 0x0002B6B2
		[global::Cpp2ILInjected.Token(Token = "0x6004920")]
		[global::Cpp2ILInjected.Address(RVA = "0x82AFEC", Offset = "0x82AFEC", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CountKillForAchievements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnBoss", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteTriggerForAllLocalUsers", MemberParameters = new object[] { typeof(eTrigger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyProgressionEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void CheckMechaMayhem(int justKilled = -1)
		{
			throw null;
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x0002D4B5 File Offset: 0x0002B6B5
		[global::Cpp2ILInjected.Token(Token = "0x6004921")]
		[global::Cpp2ILInjected.Address(RVA = "0x828DEC", Offset = "0x828DEC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "NotifyItemCraft", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static bool IsMetalBar(int itemType)
		{
			throw null;
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x0002D4B8 File Offset: 0x0002B6B8
		[global::Cpp2ILInjected.Token(Token = "0x6004922")]
		[global::Cpp2ILInjected.Address(RVA = "0x82B240", Offset = "0x82B240", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AchievementsHelper()
		{
			throw null;
		}

		// Token: 0x04006C9C RID: 27804
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400842E")]
		private static AchievementsHelper.ItemPickupEvent OnItemPickup;

		// Token: 0x04006C9D RID: 27805
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400842F")]
		private static AchievementsHelper.ItemCraftEvent OnItemCraft;

		// Token: 0x04006C9E RID: 27806
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008430")]
		private static AchievementsHelper.TileDestroyedEvent OnTileDestroyed;

		// Token: 0x04006C9F RID: 27807
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008431")]
		private static AchievementsHelper.NPCKilledEvent OnNPCKilled;

		// Token: 0x04006CA0 RID: 27808
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008432")]
		private static AchievementsHelper.ProgressionEventEvent OnProgressionEvent;

		// Token: 0x04006CA1 RID: 27809
		[global::Cpp2ILInjected.Token(Token = "0x4008433")]
		private static bool _isMining;

		// Token: 0x04006CA2 RID: 27810
		[global::Cpp2ILInjected.Token(Token = "0x4008434")]
		private static bool mayhemOK;

		// Token: 0x04006CA3 RID: 27811
		[global::Cpp2ILInjected.Token(Token = "0x4008435")]
		private static bool mayhem1down;

		// Token: 0x04006CA4 RID: 27812
		[global::Cpp2ILInjected.Token(Token = "0x4008436")]
		private static bool mayhem2down;

		// Token: 0x04006CA5 RID: 27813
		[global::Cpp2ILInjected.Token(Token = "0x4008437")]
		private static bool mayhem3down;

		// Token: 0x02000A34 RID: 2612
		// (Invoke) Token: 0x06005006 RID: 20486
		[global::Cpp2ILInjected.Token(Token = "0x20009A5")]
		public delegate void ItemPickupEvent(Player player, short itemId, int count);

		// Token: 0x02000A35 RID: 2613
		// (Invoke) Token: 0x0600500A RID: 20490
		[global::Cpp2ILInjected.Token(Token = "0x20009A6")]
		public delegate void ItemCraftEvent(Player player, short itemId, int count);

		// Token: 0x02000A36 RID: 2614
		// (Invoke) Token: 0x0600500E RID: 20494
		[global::Cpp2ILInjected.Token(Token = "0x20009A7")]
		public delegate void TileDestroyedEvent(Player player, ushort tileId);

		// Token: 0x02000A37 RID: 2615
		// (Invoke) Token: 0x06005012 RID: 20498
		[global::Cpp2ILInjected.Token(Token = "0x20009A8")]
		public delegate void NPCKilledEvent(Player player, short npcId);

		// Token: 0x02000A38 RID: 2616
		// (Invoke) Token: 0x06005016 RID: 20502
		[global::Cpp2ILInjected.Token(Token = "0x20009A9")]
		public delegate void ProgressionEventEvent(int eventID);
	}
}
