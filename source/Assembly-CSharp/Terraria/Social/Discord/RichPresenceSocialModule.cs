﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;
using Terraria.Net;
using Terraria.Social.Base;

namespace Terraria.Social.Discord
{
	// Token: 0x0200038B RID: 907
	[global::Cpp2ILInjected.Token(Token = "0x2000526")]
	public class RichPresenceSocialModule : ISocialModule
	{
		// Token: 0x06002D54 RID: 11604 RVA: 0x0002A206 File Offset: 0x00028406
		[global::Cpp2ILInjected.Token(Token = "0x60031AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A440", Offset = "0x132A440", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetGroupInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "add_OnTickForThirdPartySoftwareOnly", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x0002A209 File Offset: 0x00028409
		[global::Cpp2ILInjected.Token(Token = "0x60031AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A51C", Offset = "0x132A51C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "remove_OnTickForThirdPartySoftwareOnly", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Shutdown()
		{
			throw null;
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x0002A20C File Offset: 0x0002840C
		[global::Cpp2ILInjected.Token(Token = "0x60031AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A5C0", Offset = "0x132A5C0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RichPresenceState), Member = "GetCurrentState", ReturnType = typeof(RichPresenceState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RichPresenceSocialModule), Member = "PublishPresence", MemberParameters = new object[] { typeof(RichPresenceState) }, ReturnType = typeof(void))]
		private void UpdatePresence()
		{
			throw null;
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x0002A20F File Offset: 0x0002840F
		[global::Cpp2ILInjected.Token(Token = "0x60031B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A6D8", Offset = "0x132A6D8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RichPresenceSocialModule), Member = "UpdatePresence", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.RichPresence), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetGroupInfo), Member = "ComposeInfo", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc), Member = "UpdatePresence", MemberParameters = new object[] { typeof(DiscordRpc.RichPresence) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void PublishPresence(RichPresenceState state)
		{
			throw null;
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x0002A212 File Offset: 0x00028412
		[global::Cpp2ILInjected.Token(Token = "0x60031B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A83C", Offset = "0x132A83C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool ShouldAllowJoinRequests(RichPresenceState state)
		{
			throw null;
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x0002A215 File Offset: 0x00028415
		[global::Cpp2ILInjected.Token(Token = "0x60031B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A84C", Offset = "0x132A84C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetGroupInfo), Member = "ComposeInfo", ReturnType = typeof(string))]
		private string GetJoinSecret()
		{
			throw null;
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x0002A218 File Offset: 0x00028418
		[global::Cpp2ILInjected.Token(Token = "0x60031B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A858", Offset = "0x132A858", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RichPresenceSocialModule()
		{
			throw null;
		}

		// Token: 0x040031CE RID: 12750
		[global::Cpp2ILInjected.Token(Token = "0x4003B59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RichPresenceState _lastState;

		// Token: 0x040031CF RID: 12751
		[global::Cpp2ILInjected.Token(Token = "0x4003B5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Guid _uniquePartyId;

		// Token: 0x040031D0 RID: 12752
		[global::Cpp2ILInjected.Token(Token = "0x4003B5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private NetGroupInfo _infoAboutNetGroup;
	}
}
