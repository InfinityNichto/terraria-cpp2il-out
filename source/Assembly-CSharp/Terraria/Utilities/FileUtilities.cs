﻿using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Achievements;
using Terraria.IO;
using Terraria.Map;
using Terraria.Social.Base;
using UnityEngine;

namespace Terraria.Utilities
{
	// Token: 0x02000374 RID: 884
	[global::Cpp2ILInjected.Token(Token = "0x20004F9")]
	public static class FileUtilities
	{
		// Token: 0x06002CBD RID: 11453 RVA: 0x0002A05C File Offset: 0x0002825C
		[global::Cpp2ILInjected.Token(Token = "0x60030CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x13008EC", Offset = "0x13008EC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string WildcardToRegex(string pattern)
		{
			throw null;
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x0002A05F File Offset: 0x0002825F
		[global::Cpp2ILInjected.Token(Token = "0x60030D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300A04", Offset = "0x1300A04", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "CleanPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string CleanSwitchPath(string path)
		{
			throw null;
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x0002A062 File Offset: 0x00028262
		[global::Cpp2ILInjected.Token(Token = "0x60030D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300A90", Offset = "0x1300A90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadWorlds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OldSaveSynchronise), Member = "CopyOldSaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		public static string[] GetFiles(string path, string searchPattern)
		{
			throw null;
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x0002A065 File Offset: 0x00028265
		[global::Cpp2ILInjected.Token(Token = "0x60030D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300A98", Offset = "0x1300A98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveRecent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Preferences), Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		public static void SetAttributes(string path, FileAttributes fileAttributes)
		{
			throw null;
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x0002A068 File Offset: 0x00028268
		[global::Cpp2ILInjected.Token(Token = "0x60030D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300AA0", Offset = "0x1300AA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadWorlds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveRecent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InternalSaveMap", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "OpenFolder", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OldSaveSynchronise), Member = "CopyOldSaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "InternalSaveWorld", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMapCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public static void CreateDirectory(string path)
		{
			throw null;
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x0002A06B File Offset: 0x0002826B
		[global::Cpp2ILInjected.Token(Token = "0x60030D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300AA8", Offset = "0x1300AA8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool Exists(string path, bool cloud = false)
		{
			throw null;
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x0002A06E File Offset: 0x0002826E
		[global::Cpp2ILInjected.Token(Token = "0x60030D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300B30", Offset = "0x1300B30", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "SaveDefaultCategories", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ResetSettings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ErasePlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "EraseWorld", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "KillMeForGood", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "serverLoadWorldCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Move", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "MoveToLocal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OldSaveSynchronise), Member = "CopyOldSaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Delete(string path, bool cloud = false)
		{
			throw null;
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x0002A071 File Offset: 0x00028271
		[global::Cpp2ILInjected.Token(Token = "0x60030D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300BBC", Offset = "0x1300BBC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetPlayerPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetWorldPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static string GetFullPath(string path, bool cloud)
		{
			throw null;
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x0002A074 File Offset: 0x00028274
		[global::Cpp2ILInjected.Token(Token = "0x60030D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300BC0", Offset = "0x1300BC0", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InternalSavePlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "serverLoadWorldCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Move", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OldSaveSynchronise), Member = "CopyOldSaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "Write", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Copy(string source, string destination, bool cloud = false, bool overwrite = true)
		{
			throw null;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x0002A077 File Offset: 0x00028277
		[global::Cpp2ILInjected.Token(Token = "0x60030D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300E24", Offset = "0x1300E24", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldLoadBackup), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetFileData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "DoRollingBackups", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Copy", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Delete", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Move(string source, string destination, bool cloud, bool overwrite = true)
		{
			throw null;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0002A07A File Offset: 0x0002827A
		[global::Cpp2ILInjected.Token(Token = "0x60030D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300EB0", Offset = "0x1300EB0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "SaveCodeArrayCategories", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "SaveConfiguration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "SaveConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Preferences), Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void WriteAllText(string path, string data)
		{
			throw null;
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x0002A07D File Offset: 0x0002827D
		[global::Cpp2ILInjected.Token(Token = "0x60030DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300F3C", Offset = "0x1300F3C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Preferences), Member = "Load", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string ReadAllText(string path)
		{
			throw null;
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x0002A080 File Offset: 0x00028280
		[global::Cpp2ILInjected.Token(Token = "0x60030DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300D30", Offset = "0x1300D30", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static byte[] ReadAllBytes(string path, bool cloud = false)
		{
			throw null;
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x0002A083 File Offset: 0x00028283
		[global::Cpp2ILInjected.Token(Token = "0x60030DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300DB4", Offset = "0x1300DB4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "SavePersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_ReceiveFile), Member = "WriteFile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadWorlds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveRecent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InternalSavePlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Copy", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "WriteAllText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "MoveToCloud", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "MoveToLocal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FavoritesFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Preferences), Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OldSaveSynchronise), Member = "CopyOldSaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "InternalSaveWorld", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "RenameWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Save", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMapCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Write", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void WriteAllBytes(string path, byte[] data, bool cloud = false)
		{
			throw null;
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x0002A086 File Offset: 0x00028286
		[global::Cpp2ILInjected.Token(Token = "0x60030DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300FDC", Offset = "0x1300FDC", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "InternalSaveWorld", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "RenameWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_WorldPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "GetParentFolderPath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void Write(string path, byte[] data, int length, bool cloud)
		{
			throw null;
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x0002A089 File Offset: 0x00028289
		[global::Cpp2ILInjected.Token(Token = "0x60030DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x13012C0", Offset = "0x13012C0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "MoveToCloud", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = "MoveToCloud", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool MoveToCloud(string localPath, string cloudPath)
		{
			throw null;
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x0002A08C File Offset: 0x0002828C
		[global::Cpp2ILInjected.Token(Token = "0x60030DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x13013B4", Offset = "0x13013B4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "MoveToLocal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = "MoveToLocal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Delete", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool MoveToLocal(string cloudPath, string localPath)
		{
			throw null;
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0002A08F File Offset: 0x0002828F
		[global::Cpp2ILInjected.Token(Token = "0x60030E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x130146C", Offset = "0x130146C", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileData), Member = "GetFileName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "MoveToCloud", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "MoveToLocal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = "FromInvalidWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string GetFileName(string path, bool includeExtension = true)
		{
			throw null;
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x0002A092 File Offset: 0x00028292
		[global::Cpp2ILInjected.Token(Token = "0x60030E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x13011DC", Offset = "0x13011DC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Write", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string GetParentFolderPath(string path, bool includeExtension = true)
		{
			throw null;
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x0002A095 File Offset: 0x00028295
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60030E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x13015E8", Offset = "0x13015E8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static FileUtilities()
		{
			throw null;
		}

		// Token: 0x0400318C RID: 12684
		[global::Cpp2ILInjected.Token(Token = "0x4003ACC")]
		private static Regex FileNameRegex;
	}
}