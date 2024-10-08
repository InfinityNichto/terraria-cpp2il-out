﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Achievements;
using Terraria.Initializers;

namespace Terraria.GameContent.Achievements
{
	[global::Cpp2ILInjected.Token(Token = "0x20009B0")]
	public class ProgressionEventCondition : AchievementCondition
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004964")]
		[global::Cpp2ILInjected.Address(RVA = "0x82DC88", Offset = "0x82DC88", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProgressionEventCondition), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ProgressionEventCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProgressionEventCondition), Member = "CreateMany", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(ProgressionEventCondition[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressionEventCondition), Member = "ListenForPickup", MemberParameters = new object[] { typeof(ProgressionEventCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private ProgressionEventCondition(int eventID)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004965")]
		[global::Cpp2ILInjected.Address(RVA = "0x82DFEC", Offset = "0x82DFEC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProgressionEventCondition), Member = "Create", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(ProgressionEventCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressionEventCondition), Member = "ListenForPickup", MemberParameters = new object[] { typeof(ProgressionEventCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private ProgressionEventCondition(int[] eventIDs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004966")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E094", Offset = "0x82E094", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Shutdown()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004967")]
		[global::Cpp2ILInjected.Address(RVA = "0x82DD64", Offset = "0x82DD64", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProgressionEventCondition), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProgressionEventCondition), Member = ".ctor", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper.ProgressionEventEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "add_OnProgressionEvent", MemberParameters = new object[] { typeof(AchievementsHelper.ProgressionEventEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void ListenForPickup(ProgressionEventCondition condition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004968")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E168", Offset = "0x82E168", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void ProgressionEventListener(int eventID)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004969")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E328", Offset = "0x82E328", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressionEventCondition), Member = ".ctor", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ProgressionEventCondition Create(params int[] eventIDs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600496A")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E380", Offset = "0x82E380", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressionEventCondition), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ProgressionEventCondition Create(int eventID)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600496B")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E3D8", Offset = "0x82E3D8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressionEventCondition), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ProgressionEventCondition[] CreateMany(params int[] eventIDs)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600496C")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E4C0", Offset = "0x82E4C0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ProgressionEventCondition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400844B")]
		private const string Identifier = "PROGRESSION_EVENT";

		[global::Cpp2ILInjected.Token(Token = "0x400844C")]
		private static Dictionary<int, List<ProgressionEventCondition>> _listeners;

		[global::Cpp2ILInjected.Token(Token = "0x400844D")]
		private static bool _isListenerHooked;

		[global::Cpp2ILInjected.Token(Token = "0x400844E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int[] _eventIDs;
	}
}
