﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000533 RID: 1331
	[ChatCommand("AllDeath")]
	[global::Cpp2ILInjected.Token(Token = "0x20007A0")]
	public class AllDeathCommand : IChatCommand
	{
		// Token: 0x06003912 RID: 14610 RVA: 0x0002C306 File Offset: 0x0002A506
		[global::Cpp2ILInjected.Token(Token = "0x6003FBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x749E10", Offset = "0x749E10", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "BroadcastChatMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			throw null;
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x0002C309 File Offset: 0x0002A509
		[global::Cpp2ILInjected.Token(Token = "0x6003FBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x74A0A8", Offset = "0x74A0A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x0002C30C File Offset: 0x0002A50C
		[global::Cpp2ILInjected.Token(Token = "0x6003FC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x74A0AC", Offset = "0x74A0AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AllDeathCommand()
		{
			throw null;
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x0002C30F File Offset: 0x0002A50F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003FC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x74A0B4", Offset = "0x74A0B4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static AllDeathCommand()
		{
			throw null;
		}

		// Token: 0x0400689C RID: 26780
		[global::Cpp2ILInjected.Token(Token = "0x4007DCE")]
		private static readonly Color RESPONSE_COLOR;
	}
}
