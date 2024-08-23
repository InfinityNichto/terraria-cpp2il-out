﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005AA RID: 1450
	[global::Cpp2ILInjected.Token(Token = "0x2000849")]
	public class BlockBecauseYouAreOverAnImportantTile : ISmartInteractBlockReasonProvider
	{
		// Token: 0x06003BFA RID: 15354 RVA: 0x0002CB64 File Offset: 0x0002AD64
		[global::Cpp2ILInjected.Token(Token = "0x600431D")]
		[global::Cpp2ILInjected.Address(RVA = "0x79F388", Offset = "0x79F388", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool ShouldBlockSmartInteract(SmartInteractScanSettings settings)
		{
			throw null;
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x0002CB67 File Offset: 0x0002AD67
		[global::Cpp2ILInjected.Token(Token = "0x600431E")]
		[global::Cpp2ILInjected.Address(RVA = "0x79EAE8", Offset = "0x79EAE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BlockBecauseYouAreOverAnImportantTile()
		{
			throw null;
		}
	}
}
