﻿using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Telepathy;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.NetModules;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.UI;
using UnityEngine;

namespace Terraria.Net
{
	// Token: 0x02000496 RID: 1174
	[global::Cpp2ILInjected.Token(Token = "0x200069D")]
	public class NetManager
	{
		// Token: 0x0600333F RID: 13119 RVA: 0x0002B295 File Offset: 0x00029495
		[global::Cpp2ILInjected.Token(Token = "0x6003875")]
		[global::Cpp2ILInjected.Address(RVA = "0x143B0E0", Offset = "0x143B0E0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private NetManager()
		{
			throw null;
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x0002B298 File Offset: 0x00029498
		[global::Cpp2ILInjected.Token(Token = "0x6003876")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593AE4", Offset = "0x1593AE4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Register<T>() where T : NetModule, new()
		{
			throw null;
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x0002B29B File Offset: 0x0002949B
		[global::Cpp2ILInjected.Token(Token = "0x6003877")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593ABC", Offset = "0x1593ABC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NetModule GetModule<T>() where T : NetModule
		{
			throw null;
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x0002B29E File Offset: 0x0002949E
		[global::Cpp2ILInjected.Token(Token = "0x6003878")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593A94", Offset = "0x1593A94", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ushort GetId<T>() where T : NetModule
		{
			throw null;
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x0002B2A1 File Offset: 0x000294A1
		[global::Cpp2ILInjected.Token(Token = "0x6003879")]
		[global::Cpp2ILInjected.Address(RVA = "0x143B15C", Offset = "0x143B15C", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToSelf", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "get_Item", MemberParameters = new object[] { typeof(ushort) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActiveNetDiagnosticsUI", ReturnType = typeof(INetDiagnosticsUI))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Read(BinaryReader reader, int userId, int readLength)
		{
			throw null;
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x0002B2A4 File Offset: 0x000294A4
		[global::Cpp2ILInjected.Token(Token = "0x600387A")]
		[global::Cpp2ILInjected.Address(RVA = "0x143B2C8", Offset = "0x143B2C8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "BroadcastOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKillsTracker), Member = "RegisterKill", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCWasNearPlayerTracker), Member = "RegisterWasNearby", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCWasChatWithTracker), Member = "RegisterChatStartWith", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "BroadcastAllChanges", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetParticlesModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetPingModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "SetEnabledState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "DeserializeNetMessage", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "DeserializeNetMessage", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemoteClient), Member = "get_HasAnySection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Broadcast(NetPacket packet, int ignoreClient = -1)
		{
			throw null;
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x0002B2A7 File Offset: 0x000294A7
		[global::Cpp2ILInjected.Token(Token = "0x600387B")]
		[global::Cpp2ILInjected.Address(RVA = "0x143B670", Offset = "0x143B670", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "BroadcastChatMessageAs", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(NetworkText),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "BroadcastEachChunkSeparately", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemoteClient), Member = "get_HasAnySection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Broadcast(NetPacket packet, NetManager.BroadcastCondition conditionToBroadcast, int ignoreClient = -1)
		{
			throw null;
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x0002B2AA File Offset: 0x000294AA
		[global::Cpp2ILInjected.Token(Token = "0x600387C")]
		[global::Cpp2ILInjected.Address(RVA = "0x143B774", Offset = "0x143B774", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "BroadcastOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToServerAndSelf", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Read", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActiveNetDiagnosticsUI", ReturnType = typeof(INetDiagnosticsUI))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void SendToSelf(NetPacket packet)
		{
			throw null;
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x0002B2AD File Offset: 0x000294AD
		[global::Cpp2ILInjected.Token(Token = "0x600387D")]
		[global::Cpp2ILInjected.Address(RVA = "0x143B98C", Offset = "0x143B98C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "UpdatePylonsListAndBroadcastChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "BroadcastParticleSpawn", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "BroadcastOrRequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "SpawnForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToSelf", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void BroadcastOrLoopback(NetPacket packet)
		{
			throw null;
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x0002B2B0 File Offset: 0x000294B0
		[global::Cpp2ILInjected.Token(Token = "0x600387E")]
		[global::Cpp2ILInjected.Address(RVA = "0x143BA50", Offset = "0x143BA50", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "ActionResearch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "RequestTeleportation", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowerManager), Member = "SyncSplitScreenPlayerInternal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "SacrificeItem", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(CreativeUI.ItemSacrificeResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "RequestUse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "DebugCall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "PushChange", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "RequestUse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "RequestUse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "DebugCall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "AttemptPushingChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToSelf", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SendToServerOrLoopback(NetPacket packet)
		{
			throw null;
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x0002B2B3 File Offset: 0x000294B3
		[global::Cpp2ILInjected.Token(Token = "0x600387F")]
		[global::Cpp2ILInjected.Address(RVA = "0x143BB1C", Offset = "0x143BB1C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "RequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "BroadcastOrRequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToSelf", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SendToServerAndSelf(NetPacket packet)
		{
			throw null;
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x0002B2B6 File Offset: 0x000294B6
		[global::Cpp2ILInjected.Token(Token = "0x6003880")]
		[global::Cpp2ILInjected.Address(RVA = "0x143BB14", Offset = "0x143BB14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TriggerPing", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "SendChatMessageFromClient", MemberParameters = new object[] { typeof(ChatMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void SendToServer(NetPacket packet)
		{
			throw null;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x0002B2B9 File Offset: 0x000294B9
		[global::Cpp2ILInjected.Token(Token = "0x6003881")]
		[global::Cpp2ILInjected.Address(RVA = "0x143B3B0", Offset = "0x143B3B0", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(NetManager.BroadcastCondition),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToServerAndSelf", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToServer", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "DisplayMessageOnClient", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "SendChatMessageToClientAs", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(NetworkText),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKillsTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCWasNearPlayerTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCWasChatWithTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "PrepareAndSendToEachPlayerSeparately", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowerManager), Member = "SyncThingsToJoiningPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "ShrinkToFit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "Send", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActiveNetDiagnosticsUI", ReturnType = typeof(INetDiagnosticsUI))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public void SendToClient(NetPacket packet, int clientId)
		{
			throw null;
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x0002B2BC File Offset: 0x000294BC
		[global::Cpp2ILInjected.Token(Token = "0x6003882")]
		[global::Cpp2ILInjected.Address(RVA = "0x143B920", Offset = "0x143B920", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToSelf", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedBuffer), Member = "Recycle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void SendCallback(object state)
		{
			throw null;
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x0002B2BF File Offset: 0x000294BF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003883")]
		[global::Cpp2ILInjected.Address(RVA = "0x143BCB4", Offset = "0x143BCB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static NetManager()
		{
			throw null;
		}

		// Token: 0x0400653A RID: 25914
		[global::Cpp2ILInjected.Token(Token = "0x4007937")]
		public static NetManager Instance;

		// Token: 0x0400653B RID: 25915
		[global::Cpp2ILInjected.Token(Token = "0x4007938")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<ushort, NetModule> _modules;

		// Token: 0x0400653C RID: 25916
		[global::Cpp2ILInjected.Token(Token = "0x4007939")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ushort _moduleCount;

		// Token: 0x0400653D RID: 25917
		[global::Cpp2ILInjected.Token(Token = "0x400793A")]
		public static bool LoopbackClientSends;

		// Token: 0x0200093C RID: 2364
		[global::Cpp2ILInjected.Token(Token = "0x200069E")]
		private class PacketTypeStorage<T> where T : NetModule
		{
			// Token: 0x06004CAB RID: 19627 RVA: 0x0002F8F7 File Offset: 0x0002DAF7
			[global::Cpp2ILInjected.Token(Token = "0x6003884")]
			[global::Cpp2ILInjected.Address(RVA = "0x1818CA8", Offset = "0x1818CA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PacketTypeStorage()
			{
				throw null;
			}

			// Token: 0x04008ADC RID: 35548
			[global::Cpp2ILInjected.Token(Token = "0x400793B")]
			public static ushort Id;

			// Token: 0x04008ADD RID: 35549
			[global::Cpp2ILInjected.Token(Token = "0x400793C")]
			public static T Module;
		}

		// Token: 0x0200093D RID: 2365
		// (Invoke) Token: 0x06004CAD RID: 19629
		[global::Cpp2ILInjected.Token(Token = "0x200069F")]
		public delegate bool BroadcastCondition(int clientIndex);
	}
}
