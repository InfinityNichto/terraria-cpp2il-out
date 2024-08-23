﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Renderers;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005B0 RID: 1456
	[global::Cpp2ILInjected.Token(Token = "0x2000853")]
	public class PotionOfReturnGateInteractionChecker : AHoverInteractionChecker
	{
		// Token: 0x06003C0D RID: 15373 RVA: 0x0002CB9D File Offset: 0x0002AD9D
		[global::Cpp2ILInjected.Token(Token = "0x6004344")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A11B0", Offset = "0x7A11B0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractPotionOfReturn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override bool? AttemptOverridingHoverStatus(Player player, Rectangle rectangle)
		{
			throw null;
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x0002CBA0 File Offset: 0x0002ADA0
		[global::Cpp2ILInjected.Token(Token = "0x6004345")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A123C", Offset = "0x7A123C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void DoHoverEffect(Player player, Rectangle hitbox)
		{
			throw null;
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x0002CBA3 File Offset: 0x0002ADA3
		[global::Cpp2ILInjected.Token(Token = "0x6004346")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A1258", Offset = "0x7A1258", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_BlockInteractionWithProjectiles", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override bool ShouldBlockInteraction(Player player, Rectangle hitbox)
		{
			throw null;
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x0002CBA6 File Offset: 0x0002ADA6
		[global::Cpp2ILInjected.Token(Token = "0x6004347")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A12B4", Offset = "0x7A12B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "DoPotionOfReturnReturnToOriginalUsePosition", ReturnType = typeof(void))]
		internal override void PerformInteraction(Player player, Rectangle hitbox)
		{
			throw null;
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x0002CBA9 File Offset: 0x0002ADA9
		[global::Cpp2ILInjected.Token(Token = "0x6004348")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A12C0", Offset = "0x7A12C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PotionOfReturnGateInteractionChecker()
		{
			throw null;
		}
	}
}
