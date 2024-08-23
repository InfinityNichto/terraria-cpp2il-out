﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x02000546 RID: 1350
	[global::Cpp2ILInjected.Token(Token = "0x20007B8")]
	public class DontStarveSeed
	{
		// Token: 0x0600399D RID: 14749 RVA: 0x0002C4A7 File Offset: 0x0002A6A7
		[global::Cpp2ILInjected.Token(Token = "0x6004064")]
		[global::Cpp2ILInjected.Address(RVA = "0x76DF8C", Offset = "0x76DF8C", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetBackColor", MemberParameters = new object[]
		{
			typeof(Main.InfoToSetBackColor),
			typeof(ref Color),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void ModifyNightColor(ref Color bgColorToSet, ref Color moonColor)
		{
			throw null;
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x0002C4AA File Offset: 0x0002A6AA
		[global::Cpp2ILInjected.Token(Token = "0x6004065")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E140", Offset = "0x76E140", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetBackColor", MemberParameters = new object[]
		{
			typeof(Main.InfoToSetBackColor),
			typeof(ref Color),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Max", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void ModifyMinimumLightColorAtNight(ref byte minimalLight)
		{
			throw null;
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x0002C4AD File Offset: 0x0002A6AD
		[global::Cpp2ILInjected.Token(Token = "0x6004066")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E28C", Offset = "0x76E28C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetBackColor", MemberParameters = new object[]
		{
			typeof(Main.InfoToSetBackColor),
			typeof(ref Color),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void FixBiomeDarkness(ref Color bgColor, ref int R, ref int G, ref int B)
		{
			throw null;
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x0002C4B0 File Offset: 0x0002A6B0
		[global::Cpp2ILInjected.Token(Token = "0x6004067")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E37C", Offset = "0x76E37C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player.Hooks), Member = "add_OnEnterWorld", MemberParameters = new object[] { typeof(Action<Player>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x0002C4B3 File Offset: 0x0002A6B3
		[global::Cpp2ILInjected.Token(Token = "0x6004068")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E3F0", Offset = "0x76E3F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "UpdateStarvingState", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private static void Hook_OnEnterWorld(Player player)
		{
			throw null;
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0002C4B6 File Offset: 0x0002A6B6
		[global::Cpp2ILInjected.Token(Token = "0x6004069")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E3FC", Offset = "0x76E3FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DontStarveSeed()
		{
			throw null;
		}
	}
}
