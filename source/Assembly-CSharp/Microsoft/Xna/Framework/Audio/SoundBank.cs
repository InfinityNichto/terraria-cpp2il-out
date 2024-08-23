﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using Terraria.Audio;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x020002F5 RID: 757
	[global::Cpp2ILInjected.Token(Token = "0x20003CE")]
	public class SoundBank
	{
		// Token: 0x060018E1 RID: 6369 RVA: 0x00026501 File Offset: 0x00024701
		[global::Cpp2ILInjected.Token(Token = "0x6001A70")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49C74", Offset = "0xB49C74", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SoundBank(AudioEngine engine, string contentPath)
		{
			throw null;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00026504 File Offset: 0x00024704
		[global::Cpp2ILInjected.Token(Token = "0x6001A71")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49CF0", Offset = "0xB49CF0", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "LoadCue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = "CreateInstance", ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void LoadMusicId(int musicIndex)
		{
			throw null;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00026507 File Offset: 0x00024707
		[global::Cpp2ILInjected.Token(Token = "0x6001A72")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49E60", Offset = "0xB49E60", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "LoadCue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Cue GetCue(string cueId)
		{
			throw null;
		}

		// Token: 0x0400216E RID: 8558
		[global::Cpp2ILInjected.Token(Token = "0x40027DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<string, Cue> _cues;
	}
}