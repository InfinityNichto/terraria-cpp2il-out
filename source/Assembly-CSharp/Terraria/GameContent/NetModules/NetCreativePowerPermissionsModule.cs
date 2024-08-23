﻿using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Creative;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000672 RID: 1650
	[global::Cpp2ILInjected.Token(Token = "0x20009F9")]
	public class NetCreativePowerPermissionsModule : NetModule
	{
		// Token: 0x060040F7 RID: 16631 RVA: 0x0002D9C2 File Offset: 0x0002BBC2
		[global::Cpp2ILInjected.Token(Token = "0x6004B7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A8C80", Offset = "0x8A8C80", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowerManager), Member = "SyncSplitScreenPlayerInternal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowerManager), Member = "SyncThingsToJoiningPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket SerializeCurrentPowerPermissionLevel(ushort powerId, int level)
		{
			throw null;
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x0002D9C5 File Offset: 0x0002BBC5
		[global::Cpp2ILInjected.Token(Token = "0x6004B7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A8D40", Offset = "0x8A8D40", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadThreadstate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "TryGetPower", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref ICreativePower)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			throw null;
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x0002D9C8 File Offset: 0x0002BBC8
		[global::Cpp2ILInjected.Token(Token = "0x6004B7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A90BC", Offset = "0x8A90BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetCreativePowerPermissionsModule()
		{
			throw null;
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0002D9CB File Offset: 0x0002BBCB
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004B7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A90C4", Offset = "0x8A90C4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static NetCreativePowerPermissionsModule()
		{
			throw null;
		}

		// Token: 0x04006D85 RID: 28037
		[global::Cpp2ILInjected.Token(Token = "0x40085B9")]
		private const byte _setPermissionLevelId = 0;

		// Token: 0x04006D86 RID: 28038
		[global::Cpp2ILInjected.Token(Token = "0x40085BA")]
		public static int specificPlrDeserialise;
	}
}
