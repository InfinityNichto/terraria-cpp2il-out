﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.Skies;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000690 RID: 1680
	[global::Cpp2ILInjected.Token(Token = "0x2000A50")]
	public class LanternNight
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600420A RID: 16906 RVA: 0x0002DCD4 File Offset: 0x0002BED4
		[global::Cpp2ILInjected.Token(Token = "0x1700089B")]
		public static bool LanternsUp
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004DF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8CE578", Offset = "0x8CE578", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(CaptureSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateWeather", MemberParameters = new object[]
			{
				typeof(GameTime),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ShouldNormalEventsBeAbleToStart", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_StartNight", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(NetworkText),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "RecalculateLuck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_Head_GetTVScreen", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternSky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternNight), Member = "ToggleManualLanterns", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternNight), Member = "UpdateTime", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x0002DCD7 File Offset: 0x0002BED7
		[global::Cpp2ILInjected.Token(Token = "0x6004DF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE5D8", Offset = "0x8CE5D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_StartDay", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void CheckMorning()
		{
			throw null;
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x0002DCDA File Offset: 0x0002BEDA
		[global::Cpp2ILInjected.Token(Token = "0x6004DF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE634", Offset = "0x8CE634", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_StartNight", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void CheckNight()
		{
			throw null;
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x0002DCDD File Offset: 0x0002BEDD
		[global::Cpp2ILInjected.Token(Token = "0x6004DF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE78C", Offset = "0x8CE78C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternNight), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool LanternsCanPersist()
		{
			throw null;
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x0002DCE0 File Offset: 0x0002BEE0
		[global::Cpp2ILInjected.Token(Token = "0x6004DFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE7F8", Offset = "0x8CE7F8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternNight), Member = "NaturalAttempt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternNight), Member = "BossIsActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool LanternsCanStart()
		{
			throw null;
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x0002DCE3 File Offset: 0x0002BEE3
		[global::Cpp2ILInjected.Token(Token = "0x6004DFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE8F0", Offset = "0x8CE8F0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternNight), Member = "LanternsCanStart", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool BossIsActive()
		{
			throw null;
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x0002DCE6 File Offset: 0x0002BEE6
		[global::Cpp2ILInjected.Token(Token = "0x6004DFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE638", Offset = "0x8CE638", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternNight), Member = "LanternsCanStart", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void NaturalAttempt()
		{
			throw null;
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x0002DCE9 File Offset: 0x0002BEE9
		[global::Cpp2ILInjected.Token(Token = "0x6004DFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE988", Offset = "0x8CE988", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternNight), Member = "get_LanternsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void ToggleManualLanterns()
		{
			throw null;
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x0002DCEC File Offset: 0x0002BEEC
		[global::Cpp2ILInjected.Token(Token = "0x6004DFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CEA9C", Offset = "0x8CEA9C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClearVisualPostProcessEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void WorldClear()
		{
			throw null;
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x0002DCEF File Offset: 0x0002BEEF
		[global::Cpp2ILInjected.Token(Token = "0x6004DFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CEAEC", Offset = "0x8CEAEC", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternNight), Member = "LanternsCanPersist", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternNight), Member = "get_LanternsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Activate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(object[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Deactivate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static void UpdateTime()
		{
			throw null;
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x0002DCF2 File Offset: 0x0002BEF2
		[global::Cpp2ILInjected.Token(Token = "0x6004E00")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CED5C", Offset = "0x8CED5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LanternNight()
		{
			throw null;
		}

		// Token: 0x04006DF8 RID: 28152
		[global::Cpp2ILInjected.Token(Token = "0x40086BE")]
		public static bool ManualLanterns;

		// Token: 0x04006DF9 RID: 28153
		[global::Cpp2ILInjected.Token(Token = "0x40086BF")]
		public static bool GenuineLanterns;

		// Token: 0x04006DFA RID: 28154
		[global::Cpp2ILInjected.Token(Token = "0x40086C0")]
		public static bool NextNightIsLanternNight;

		// Token: 0x04006DFB RID: 28155
		[global::Cpp2ILInjected.Token(Token = "0x40086C1")]
		public static int LanternNightsOnCooldown;

		// Token: 0x04006DFC RID: 28156
		[global::Cpp2ILInjected.Token(Token = "0x40086C2")]
		private static bool _wasLanternNight;
	}
}
