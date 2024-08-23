﻿using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Creative;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000671 RID: 1649
	[global::Cpp2ILInjected.Token(Token = "0x20009F8")]
	public class NetCreativeUnlocksPlayerReportModule : NetModule
	{
		// Token: 0x060040F4 RID: 16628 RVA: 0x0002D9B9 File Offset: 0x0002BBB9
		[global::Cpp2ILInjected.Token(Token = "0x6004B79")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A8B60", Offset = "0x8A8B60", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "ActionResearch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "SacrificeItem", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(CreativeUI.ItemSacrificeResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket SerializeSacrificeRequest(int itemId, int amount)
		{
			throw null;
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x0002D9BC File Offset: 0x0002BBBC
		[global::Cpp2ILInjected.Token(Token = "0x6004B7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A8C24", Offset = "0x8A8C24", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			throw null;
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x0002D9BF File Offset: 0x0002BBBF
		[global::Cpp2ILInjected.Token(Token = "0x6004B7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A8C78", Offset = "0x8A8C78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetCreativeUnlocksPlayerReportModule()
		{
			throw null;
		}

		// Token: 0x04006D84 RID: 28036
		[global::Cpp2ILInjected.Token(Token = "0x40085B8")]
		private const byte _requestItemSacrificeId = 0;
	}
}
