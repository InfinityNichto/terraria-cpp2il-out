﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.ID;
using Terraria.Utilities;

namespace Terraria.Audio
{
	// Token: 0x02000485 RID: 1157
	[global::Cpp2ILInjected.Token(Token = "0x2000689")]
	public class LegacySoundPlayer
	{
		// Token: 0x060032B1 RID: 12977 RVA: 0x0002B103 File Offset: 0x00029303
		[global::Cpp2ILInjected.Token(Token = "0x60037DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1422454", Offset = "0x1422454", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Load", MemberParameters = new object[] { typeof(IServiceProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public LegacySoundPlayer(IServiceProvider services)
		{
			throw null;
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x0002B106 File Offset: 0x00029306
		[global::Cpp2ILInjected.Token(Token = "0x60037DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x14237A8", Offset = "0x14237A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Reload", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Reload()
		{
			throw null;
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0002B109 File Offset: 0x00029309
		[global::Cpp2ILInjected.Token(Token = "0x60037E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1422788", Offset = "0x1422788", Length = "0x1020")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundPlayer), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Asset<SoundEffect>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "get_TrackableLegacySoundCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "GetTrackableLegacySoundPath", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 97)]
		private void LoadAll()
		{
			throw null;
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x0002B10C File Offset: 0x0002930C
		[global::Cpp2ILInjected.Token(Token = "0x60037E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14237AC", Offset = "0x14237AC", Length = "0x874")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundPlayer), Member = "CreateInstance", MemberParameters = new object[] { typeof(Asset<SoundEffect>) }, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public void CreateAllSoundInstances()
		{
			throw null;
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x0002B10F File Offset: 0x0002930F
		[global::Cpp2ILInjected.Token(Token = "0x60037E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1424110", Offset = "0x1424110", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "CreateAllSoundInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = "CreateInstance", ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private SoundEffectInstance CreateInstance(Asset<SoundEffect> asset)
		{
			throw null;
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x0002B112 File Offset: 0x00029312
		[global::Cpp2ILInjected.Token(Token = "0x60037E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1424020", Offset = "0x1424020", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "LoadAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XnaExtensions), Member = "Get", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(IServiceProvider) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private Asset<SoundEffect> Load(string assetName)
		{
			throw null;
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x0002B115 File Offset: 0x00029315
		[global::Cpp2ILInjected.Token(Token = "0x60037E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x14241D4", Offset = "0x14241D4", Length = "0x4404")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_soundVolume", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ambientVolume", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = "CreateInstance", ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Volume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Pan", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Pitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "Restart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstanceGarbageCollector), Member = "Track", MemberParameters = new object[] { typeof(SoundEffectInstance) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 278)]
		public SoundEffectInstance PlaySound(int type, int x = -1, int y = -1, int Style = 1, float volumeScale = 1f, float pitchOffset = 0f)
		{
			throw null;
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x0002B118 File Offset: 0x00029318
		[global::Cpp2ILInjected.Token(Token = "0x60037E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1428608", Offset = "0x1428608", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "GetTrackableSoundByStyleId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SoundEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public SoundEffect GetTrackableSoundByStyleId(int id)
		{
			throw null;
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x0002B11B File Offset: 0x0002931B
		[global::Cpp2ILInjected.Token(Token = "0x60037E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1428654", Offset = "0x1428654", Length = "0x105C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "StopAmbientSounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void StopAmbientSounds()
		{
			throw null;
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x0002B11E File Offset: 0x0002931E
		[global::Cpp2ILInjected.Token(Token = "0x60037E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14285D8", Offset = "0x14285D8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool DoesSoundScaleWithAmbientVolume(int soundType)
		{
			throw null;
		}

		// Token: 0x040064B8 RID: 25784
		[global::Cpp2ILInjected.Token(Token = "0x40078B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Asset<SoundEffect>[] SoundDrip;

		// Token: 0x040064B9 RID: 25785
		[global::Cpp2ILInjected.Token(Token = "0x40078B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public SoundEffectInstance[] SoundInstanceDrip;

		// Token: 0x040064BA RID: 25786
		[global::Cpp2ILInjected.Token(Token = "0x40078B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Asset<SoundEffect>[] SoundLiquid;

		// Token: 0x040064BB RID: 25787
		[global::Cpp2ILInjected.Token(Token = "0x40078B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public SoundEffectInstance[] SoundInstanceLiquid;

		// Token: 0x040064BC RID: 25788
		[global::Cpp2ILInjected.Token(Token = "0x40078B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Asset<SoundEffect>[] SoundMech;

		// Token: 0x040064BD RID: 25789
		[global::Cpp2ILInjected.Token(Token = "0x40078B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public SoundEffectInstance[] SoundInstanceMech;

		// Token: 0x040064BE RID: 25790
		[global::Cpp2ILInjected.Token(Token = "0x40078BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Asset<SoundEffect>[] SoundDig;

		// Token: 0x040064BF RID: 25791
		[global::Cpp2ILInjected.Token(Token = "0x40078BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public SoundEffectInstance[] SoundInstanceDig;

		// Token: 0x040064C0 RID: 25792
		[global::Cpp2ILInjected.Token(Token = "0x40078BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int _digLastFrame;

		// Token: 0x040064C1 RID: 25793
		[global::Cpp2ILInjected.Token(Token = "0x40078BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public int[] SoundDigPlayCount;

		// Token: 0x040064C2 RID: 25794
		[global::Cpp2ILInjected.Token(Token = "0x40078BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public Asset<SoundEffect>[] SoundThunder;

		// Token: 0x040064C3 RID: 25795
		[global::Cpp2ILInjected.Token(Token = "0x40078BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public SoundEffectInstance[] SoundInstanceThunder;

		// Token: 0x040064C4 RID: 25796
		[global::Cpp2ILInjected.Token(Token = "0x40078C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public Asset<SoundEffect>[] SoundResearch;

		// Token: 0x040064C5 RID: 25797
		[global::Cpp2ILInjected.Token(Token = "0x40078C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public SoundEffectInstance[] SoundInstanceResearch;

		// Token: 0x040064C6 RID: 25798
		[global::Cpp2ILInjected.Token(Token = "0x40078C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public Asset<SoundEffect>[] SoundTink;

		// Token: 0x040064C7 RID: 25799
		[global::Cpp2ILInjected.Token(Token = "0x40078C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public SoundEffectInstance[] SoundInstanceTink;

		// Token: 0x040064C8 RID: 25800
		[global::Cpp2ILInjected.Token(Token = "0x40078C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public Asset<SoundEffect>[] SoundCoin;

		// Token: 0x040064C9 RID: 25801
		[global::Cpp2ILInjected.Token(Token = "0x40078C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public SoundEffectInstance[] SoundInstanceCoin;

		// Token: 0x040064CA RID: 25802
		[global::Cpp2ILInjected.Token(Token = "0x40078C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public Asset<SoundEffect>[] SoundPlayerHit;

		// Token: 0x040064CB RID: 25803
		[global::Cpp2ILInjected.Token(Token = "0x40078C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public SoundEffectInstance[] SoundInstancePlayerHit;

		// Token: 0x040064CC RID: 25804
		[global::Cpp2ILInjected.Token(Token = "0x40078C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public Asset<SoundEffect>[] SoundFemaleHit;

		// Token: 0x040064CD RID: 25805
		[global::Cpp2ILInjected.Token(Token = "0x40078C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public SoundEffectInstance[] SoundInstanceFemaleHit;

		// Token: 0x040064CE RID: 25806
		[global::Cpp2ILInjected.Token(Token = "0x40078CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public Asset<SoundEffect> SoundPlayerKilled;

		// Token: 0x040064CF RID: 25807
		[global::Cpp2ILInjected.Token(Token = "0x40078CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public SoundEffectInstance SoundInstancePlayerKilled;

		// Token: 0x040064D0 RID: 25808
		[global::Cpp2ILInjected.Token(Token = "0x40078CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public Asset<SoundEffect> SoundGrass;

		// Token: 0x040064D1 RID: 25809
		[global::Cpp2ILInjected.Token(Token = "0x40078CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public SoundEffectInstance SoundInstanceGrass;

		// Token: 0x040064D2 RID: 25810
		[global::Cpp2ILInjected.Token(Token = "0x40078CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public Asset<SoundEffect> SoundGrab;

		// Token: 0x040064D3 RID: 25811
		[global::Cpp2ILInjected.Token(Token = "0x40078CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public SoundEffectInstance SoundInstanceGrab;

		// Token: 0x040064D4 RID: 25812
		[global::Cpp2ILInjected.Token(Token = "0x40078D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public Asset<SoundEffect> SoundPixie;

		// Token: 0x040064D5 RID: 25813
		[global::Cpp2ILInjected.Token(Token = "0x40078D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public SoundEffectInstance SoundInstancePixie;

		// Token: 0x040064D6 RID: 25814
		[global::Cpp2ILInjected.Token(Token = "0x40078D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public Asset<SoundEffect>[] SoundItem;

		// Token: 0x040064D7 RID: 25815
		[global::Cpp2ILInjected.Token(Token = "0x40078D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public SoundEffectInstance[] SoundInstanceItem;

		// Token: 0x040064D8 RID: 25816
		[global::Cpp2ILInjected.Token(Token = "0x40078D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public Asset<SoundEffect>[] SoundNpcHit;

		// Token: 0x040064D9 RID: 25817
		[global::Cpp2ILInjected.Token(Token = "0x40078D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public SoundEffectInstance[] SoundInstanceNpcHit;

		// Token: 0x040064DA RID: 25818
		[global::Cpp2ILInjected.Token(Token = "0x40078D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public Asset<SoundEffect>[] SoundNpcKilled;

		// Token: 0x040064DB RID: 25819
		[global::Cpp2ILInjected.Token(Token = "0x40078D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public SoundEffectInstance[] SoundInstanceNpcKilled;

		// Token: 0x040064DC RID: 25820
		[global::Cpp2ILInjected.Token(Token = "0x40078D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public SoundEffectInstance SoundInstanceMoonlordCry;

		// Token: 0x040064DD RID: 25821
		[global::Cpp2ILInjected.Token(Token = "0x40078D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public Asset<SoundEffect> SoundDoorOpen;

		// Token: 0x040064DE RID: 25822
		[global::Cpp2ILInjected.Token(Token = "0x40078DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public SoundEffectInstance SoundInstanceDoorOpen;

		// Token: 0x040064DF RID: 25823
		[global::Cpp2ILInjected.Token(Token = "0x40078DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public Asset<SoundEffect> SoundDoorClosed;

		// Token: 0x040064E0 RID: 25824
		[global::Cpp2ILInjected.Token(Token = "0x40078DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public SoundEffectInstance SoundInstanceDoorClosed;

		// Token: 0x040064E1 RID: 25825
		[global::Cpp2ILInjected.Token(Token = "0x40078DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public Asset<SoundEffect> SoundMenuOpen;

		// Token: 0x040064E2 RID: 25826
		[global::Cpp2ILInjected.Token(Token = "0x40078DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public SoundEffectInstance SoundInstanceMenuOpen;

		// Token: 0x040064E3 RID: 25827
		[global::Cpp2ILInjected.Token(Token = "0x40078DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public Asset<SoundEffect> SoundMenuClose;

		// Token: 0x040064E4 RID: 25828
		[global::Cpp2ILInjected.Token(Token = "0x40078E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		public SoundEffectInstance SoundInstanceMenuClose;

		// Token: 0x040064E5 RID: 25829
		[global::Cpp2ILInjected.Token(Token = "0x40078E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		public Asset<SoundEffect> SoundMenuTick;

		// Token: 0x040064E6 RID: 25830
		[global::Cpp2ILInjected.Token(Token = "0x40078E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		public SoundEffectInstance SoundInstanceMenuTick;

		// Token: 0x040064E7 RID: 25831
		[global::Cpp2ILInjected.Token(Token = "0x40078E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		public Asset<SoundEffect> SoundShatter;

		// Token: 0x040064E8 RID: 25832
		[global::Cpp2ILInjected.Token(Token = "0x40078E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		public SoundEffectInstance SoundInstanceShatter;

		// Token: 0x040064E9 RID: 25833
		[global::Cpp2ILInjected.Token(Token = "0x40078E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		public Asset<SoundEffect> SoundCamera;

		// Token: 0x040064EA RID: 25834
		[global::Cpp2ILInjected.Token(Token = "0x40078E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		public SoundEffectInstance SoundInstanceCamera;

		// Token: 0x040064EB RID: 25835
		[global::Cpp2ILInjected.Token(Token = "0x40078E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		public Asset<SoundEffect>[] SoundZombie;

		// Token: 0x040064EC RID: 25836
		[global::Cpp2ILInjected.Token(Token = "0x40078E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		public SoundEffectInstance[] SoundInstanceZombie;

		// Token: 0x040064ED RID: 25837
		[global::Cpp2ILInjected.Token(Token = "0x40078E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		public Asset<SoundEffect>[] SoundRoar;

		// Token: 0x040064EE RID: 25838
		[global::Cpp2ILInjected.Token(Token = "0x40078EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		public SoundEffectInstance[] SoundInstanceRoar;

		// Token: 0x040064EF RID: 25839
		[global::Cpp2ILInjected.Token(Token = "0x40078EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		public Asset<SoundEffect>[] SoundSplash;

		// Token: 0x040064F0 RID: 25840
		[global::Cpp2ILInjected.Token(Token = "0x40078EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		public SoundEffectInstance[] SoundInstanceSplash;

		// Token: 0x040064F1 RID: 25841
		[global::Cpp2ILInjected.Token(Token = "0x40078ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
		public Asset<SoundEffect> SoundDoubleJump;

		// Token: 0x040064F2 RID: 25842
		[global::Cpp2ILInjected.Token(Token = "0x40078EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
		public SoundEffectInstance SoundInstanceDoubleJump;

		// Token: 0x040064F3 RID: 25843
		[global::Cpp2ILInjected.Token(Token = "0x40078EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		public Asset<SoundEffect> SoundRun;

		// Token: 0x040064F4 RID: 25844
		[global::Cpp2ILInjected.Token(Token = "0x40078F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		public SoundEffectInstance SoundInstanceRun;

		// Token: 0x040064F5 RID: 25845
		[global::Cpp2ILInjected.Token(Token = "0x40078F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		public Asset<SoundEffect> SoundCoins;

		// Token: 0x040064F6 RID: 25846
		[global::Cpp2ILInjected.Token(Token = "0x40078F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
		public SoundEffectInstance SoundInstanceCoins;

		// Token: 0x040064F7 RID: 25847
		[global::Cpp2ILInjected.Token(Token = "0x40078F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
		public Asset<SoundEffect> SoundUnlock;

		// Token: 0x040064F8 RID: 25848
		[global::Cpp2ILInjected.Token(Token = "0x40078F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
		public SoundEffectInstance SoundInstanceUnlock;

		// Token: 0x040064F9 RID: 25849
		[global::Cpp2ILInjected.Token(Token = "0x40078F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
		public Asset<SoundEffect> SoundChat;

		// Token: 0x040064FA RID: 25850
		[global::Cpp2ILInjected.Token(Token = "0x40078F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
		public SoundEffectInstance SoundInstanceChat;

		// Token: 0x040064FB RID: 25851
		[global::Cpp2ILInjected.Token(Token = "0x40078F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
		public Asset<SoundEffect> SoundMaxMana;

		// Token: 0x040064FC RID: 25852
		[global::Cpp2ILInjected.Token(Token = "0x40078F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
		public SoundEffectInstance SoundInstanceMaxMana;

		// Token: 0x040064FD RID: 25853
		[global::Cpp2ILInjected.Token(Token = "0x40078F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
		public Asset<SoundEffect> SoundDrown;

		// Token: 0x040064FE RID: 25854
		[global::Cpp2ILInjected.Token(Token = "0x40078FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
		public SoundEffectInstance SoundInstanceDrown;

		// Token: 0x040064FF RID: 25855
		[global::Cpp2ILInjected.Token(Token = "0x40078FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
		public Asset<SoundEffect>[] TrackableSounds;

		// Token: 0x04006500 RID: 25856
		[global::Cpp2ILInjected.Token(Token = "0x40078FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
		public SoundEffectInstance[] TrackableSoundInstances;

		// Token: 0x04006501 RID: 25857
		[global::Cpp2ILInjected.Token(Token = "0x40078FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
		private readonly IServiceProvider _services;

		// Token: 0x04006502 RID: 25858
		[global::Cpp2ILInjected.Token(Token = "0x40078FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
		private List<SoundEffectInstance> _trackedInstances;
	}
}