﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005D7 RID: 1495
	[global::Cpp2ILInjected.Token(Token = "0x2000883")]
	public class ItemDropWithConditionRule : CommonDrop
	{
		// Token: 0x06003CB4 RID: 15540 RVA: 0x0002CD68 File Offset: 0x0002AF68
		[global::Cpp2ILInjected.Token(Token = "0x6004422")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9CD4", Offset = "0x7A9CD4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "Food", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public ItemDropWithConditionRule(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition condition, int chanceNumerator = 1)
		{
			throw null;
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x0002CD6B File Offset: 0x0002AF6B
		[global::Cpp2ILInjected.Token(Token = "0x6004423")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9D00", Offset = "0x7A9D00", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x0002CD6E File Offset: 0x0002AF6E
		[global::Cpp2ILInjected.Token(Token = "0x6004424")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9DCC", Offset = "0x7A9DCC", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "With", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(DropRateInfoChainFeed))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "AddCondition", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
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
		public override void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x04006BB1 RID: 27569
		[global::Cpp2ILInjected.Token(Token = "0x40081D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public IItemDropRuleCondition condition;
	}
}
