﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005DA RID: 1498
	[global::Cpp2ILInjected.Token(Token = "0x2000887")]
	public class OneFromOptionsNotScaledWithLuckDropRule : IItemDropRule
	{
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x0002CD95 File Offset: 0x0002AF95
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x0002CD98 File Offset: 0x0002AF98
		[global::Cpp2ILInjected.Token(Token = "0x170007DD")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004432")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA418", Offset = "0x7AA418", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004433")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA420", Offset = "0x7AA420", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x0002CD9B File Offset: 0x0002AF9B
		[global::Cpp2ILInjected.Token(Token = "0x6004434")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA428", Offset = "0x7AA428", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "OneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "OneFromOptionsNotScalingWithLuckWithX", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public OneFromOptionsNotScaledWithLuckDropRule(int chanceDenominator, int chanceNumerator, params int[] options)
		{
			throw null;
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x0002CD9E File Offset: 0x0002AF9E
		[global::Cpp2ILInjected.Token(Token = "0x6004435")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA4C4", Offset = "0x7AA4C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x0002CDA1 File Offset: 0x0002AFA1
		[global::Cpp2ILInjected.Token(Token = "0x6004436")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA4CC", Offset = "0x7AA4CC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x0002CDA4 File Offset: 0x0002AFA4
		[global::Cpp2ILInjected.Token(Token = "0x6004437")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA544", Offset = "0x7AA544", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(List<IItemDropRuleCondition>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<IItemDropRuleChainAttempt>),
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x04006BB7 RID: 27575
		[global::Cpp2ILInjected.Token(Token = "0x40081E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int[] dropIds;

		// Token: 0x04006BB8 RID: 27576
		[global::Cpp2ILInjected.Token(Token = "0x40081E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int chanceDenominator;

		// Token: 0x04006BB9 RID: 27577
		[global::Cpp2ILInjected.Token(Token = "0x40081E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int chanceNumerator;

		// Token: 0x04006BBA RID: 27578
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
