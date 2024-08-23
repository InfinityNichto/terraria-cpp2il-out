﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005D8 RID: 1496
	[global::Cpp2ILInjected.Token(Token = "0x2000884")]
	public class LeadingConditionRule : IItemDropRule
	{
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x0002CD71 File Offset: 0x0002AF71
		// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x0002CD74 File Offset: 0x0002AF74
		[global::Cpp2ILInjected.Token(Token = "0x170007DB")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004425")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A9F28", Offset = "0x7A9F28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004426")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A9F30", Offset = "0x7A9F30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x0002CD77 File Offset: 0x0002AF77
		[global::Cpp2ILInjected.Token(Token = "0x6004427")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9F38", Offset = "0x7A9F38", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCsNotRemixSeed", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCsRemixSeed", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterEclipse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMimic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Plantera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Twins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_WOF", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_MoonLord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Golem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_DukeFishron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public LeadingConditionRule(IItemDropRuleCondition condition)
		{
			throw null;
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x0002CD7A File Offset: 0x0002AF7A
		[global::Cpp2ILInjected.Token(Token = "0x6004428")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9FC0", Offset = "0x7A9FC0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x0002CD7D File Offset: 0x0002AF7D
		[global::Cpp2ILInjected.Token(Token = "0x6004429")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA08C", Offset = "0x7AA08C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "AddCondition", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<IItemDropRuleChainAttempt>),
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x0002CD80 File Offset: 0x0002AF80
		[global::Cpp2ILInjected.Token(Token = "0x600442A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA0DC", Offset = "0x7AA0DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x04006BB2 RID: 27570
		[global::Cpp2ILInjected.Token(Token = "0x40081D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public IItemDropRuleCondition condition;

		// Token: 0x04006BB3 RID: 27571
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
