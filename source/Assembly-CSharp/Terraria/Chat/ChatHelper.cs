﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat.Commands;
using Terraria.GameContent;
using Terraria.GameContent.Events;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.UI.Chat;
using Terraria.Localization;
using Terraria.Net;

namespace Terraria.Chat
{
	// Token: 0x0200052A RID: 1322
	[global::Cpp2ILInjected.Token(Token = "0x2000794")]
	public static class ChatHelper
	{
		// Token: 0x060038DA RID: 14554 RVA: 0x0002C26A File Offset: 0x0002A46A
		[global::Cpp2ILInjected.Token(Token = "0x6003F7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x747A70", Offset = "0x747A70", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetTextModule), Member = "SerializeServerMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void DisplayMessageOnClient(NetworkText text, Color color, int playerId)
		{
			throw null;
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0002C26D File Offset: 0x0002A46D
		[global::Cpp2ILInjected.Token(Token = "0x6003F7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x747CFC", Offset = "0x747CFC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "TeamOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "greetPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HelpCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListPlayersCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartyChatCommand), Member = "SendNoTeamError", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "HandleTeleportRequest", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "FailureMessage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SendChatMessageToClient(NetworkText text, Color color, int playerId)
		{
			throw null;
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0002C270 File Offset: 0x0002A470
		[global::Cpp2ILInjected.Token(Token = "0x6003F7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x747D6C", Offset = "0x747D6C", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartyChatCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "DisplayMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetTextModule), Member = "SerializeServerMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SendChatMessageToClientAs(byte messageAuthor, NetworkText text, Color color, int playerId)
		{
			throw null;
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x0002C273 File Offset: 0x0002A473
		[global::Cpp2ILInjected.Token(Token = "0x6003F80")]
		[global::Cpp2ILInjected.Address(RVA = "0x747EB8", Offset = "0x747EB8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 65)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void BroadcastChatMessage(NetworkText text, Color color, int excludedPlayer = -1)
		{
			throw null;
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0002C276 File Offset: 0x0002A476
		[global::Cpp2ILInjected.Token(Token = "0x6003F81")]
		[global::Cpp2ILInjected.Address(RVA = "0x747F28", Offset = "0x747F28", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SayChatCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "DisplayMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetTextModule), Member = "SerializeServerMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager.BroadcastCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(NetManager.BroadcastCondition),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void BroadcastChatMessageAs(byte messageAuthor, NetworkText text, Color color, int excludedPlayer = -1)
		{
			throw null;
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0002C279 File Offset: 0x0002A479
		[global::Cpp2ILInjected.Token(Token = "0x6003F82")]
		[global::Cpp2ILInjected.Address(RVA = "0x7480B0", Offset = "0x7480B0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool OnlySendToPlayersWhoAreLoggedIn(int clientIndex)
		{
			throw null;
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0002C27C File Offset: 0x0002A47C
		[global::Cpp2ILInjected.Token(Token = "0x6003F83")]
		[global::Cpp2ILInjected.Address(RVA = "0x748120", Offset = "0x748120", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetTextModule), Member = "SerializeClientMessage", MemberParameters = new object[] { typeof(ChatMessage) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServer", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SendChatMessageFromClient(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0002C27F File Offset: 0x0002A47F
		[global::Cpp2ILInjected.Token(Token = "0x6003F84")]
		[global::Cpp2ILInjected.Address(RVA = "0x7481B0", Offset = "0x7481B0", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "PlatformCheckedMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player.OverheadMessage), Member = "NewMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTagHandler), Member = "GenerateTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "ShouldCacheMessage", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "CacheMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void DisplayCheckedMessage(bool result, ChatHelper.ChatRequest request)
		{
			throw null;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0002C282 File Offset: 0x0002A482
		[global::Cpp2ILInjected.Token(Token = "0x6003F85")]
		[global::Cpp2ILInjected.Address(RVA = "0x7484D8", Offset = "0x7484D8", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "DisplayMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "DisplayCheckedMessage", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ChatHelper.ChatRequest)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper.ChatRequest.ChatRequestCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.User), Member = "CanChatWith", MemberParameters = new object[] { typeof(ChatHelper.ChatRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void PlatformCheckedMessage(string message, Color color, byte messageAuthor)
		{
			throw null;
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0002C285 File Offset: 0x0002A485
		[global::Cpp2ILInjected.Token(Token = "0x6003F86")]
		[global::Cpp2ILInjected.Address(RVA = "0x747BA8", Offset = "0x747BA8", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "SendChatMessageToClientAs", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "BroadcastChatMessageAs", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "DeserializeAsClient", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.User), Member = "get_HasChatPermissions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "PlatformCheckedMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "ShouldCacheMessage", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "CacheMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void DisplayMessage(NetworkText text, Color color, byte messageAuthor)
		{
			throw null;
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x0002C288 File Offset: 0x0002A488
		[global::Cpp2ILInjected.Token(Token = "0x6003F87")]
		[global::Cpp2ILInjected.Address(RVA = "0x7483B0", Offset = "0x7483B0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "DisplayCheckedMessage", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ChatHelper.ChatRequest)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "DisplayMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple<object, Color>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void CacheMessage(string message, Color color)
		{
			throw null;
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x0002C28B File Offset: 0x0002A48B
		[global::Cpp2ILInjected.Token(Token = "0x6003F88")]
		[global::Cpp2ILInjected.Address(RVA = "0x748744", Offset = "0x748744", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateWorldPreparationState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static void ShowCachedMessages()
		{
			throw null;
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x0002C28E File Offset: 0x0002A48E
		[global::Cpp2ILInjected.Token(Token = "0x6003F89")]
		[global::Cpp2ILInjected.Address(RVA = "0x7489C8", Offset = "0x7489C8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateWorldPreparationState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void ClearDelayedMessagesCache()
		{
			throw null;
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0002C291 File Offset: 0x0002A491
		[global::Cpp2ILInjected.Token(Token = "0x6003F8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x748334", Offset = "0x748334", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "DisplayCheckedMessage", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ChatHelper.ChatRequest)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "DisplayMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool ShouldCacheMessage()
		{
			throw null;
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0002C294 File Offset: 0x0002A494
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003F8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x748A58", Offset = "0x748A58", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ChatHelper()
		{
			throw null;
		}

		// Token: 0x04006890 RID: 26768
		[global::Cpp2ILInjected.Token(Token = "0x4007DB9")]
		private static List<Tuple<string, Color>> _cachedMessages;

		// Token: 0x02000976 RID: 2422
		[global::Cpp2ILInjected.Token(Token = "0x2000795")]
		public class ChatRequest
		{
			// Token: 0x06004D7C RID: 19836 RVA: 0x0002FAC5 File Offset: 0x0002DCC5
			[global::Cpp2ILInjected.Token(Token = "0x6003F8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x748678", Offset = "0x748678", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ChatRequest()
			{
				throw null;
			}

			// Token: 0x04008BDE RID: 35806
			[global::Cpp2ILInjected.Token(Token = "0x4007DBA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public PlatformUser LocalUser;

			// Token: 0x04008BDF RID: 35807
			[global::Cpp2ILInjected.Token(Token = "0x4007DBB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public PlatformUser SendingUser;

			// Token: 0x04008BE0 RID: 35808
			[global::Cpp2ILInjected.Token(Token = "0x4007DBC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public ChatHelper.ChatRequest.ChatRequestCallback Callback;

			// Token: 0x04008BE1 RID: 35809
			[global::Cpp2ILInjected.Token(Token = "0x4007DBD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public string message;

			// Token: 0x04008BE2 RID: 35810
			[global::Cpp2ILInjected.Token(Token = "0x4007DBE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public Color color;

			// Token: 0x04008BE3 RID: 35811
			[global::Cpp2ILInjected.Token(Token = "0x4007DBF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
			public byte messageAuthor;

			// Token: 0x04008BE4 RID: 35812
			[global::Cpp2ILInjected.Token(Token = "0x4007DC0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
			public bool result;

			// Token: 0x02000BA9 RID: 2985
			// (Invoke) Token: 0x06005419 RID: 21529
			[global::Cpp2ILInjected.Token(Token = "0x2000796")]
			public delegate void ChatRequestCallback(bool result, ChatHelper.ChatRequest request);
		}
	}
}
