﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;
using Terraria.Utilities;
using UnityEngine;
using UnityEngine.Profiling;

// Token: 0x02000045 RID: 69
[global::Cpp2ILInjected.Token(Token = "0x200006B")]
public class CacheFileManager : FileAPI
{
	// Token: 0x060001A3 RID: 419 RVA: 0x00022061 File Offset: 0x00020261
	[global::Cpp2ILInjected.Token(Token = "0x6000236")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D3C8", Offset = "0x70D3C8", Length = "0x178")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileManager), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterizedThreadStart), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "Run", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public CacheFileManager(FileManager fileMan, FileAPI api, bool primaryUser, PlatformUser user)
	{
		throw null;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00022064 File Offset: 0x00020264
	[global::Cpp2ILInjected.Token(Token = "0x6000237")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D540", Offset = "0x70D540", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "TerminateThread", MemberParameters = new object[] { typeof(ManagedThread) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void Shutdown()
	{
		throw null;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00022067 File Offset: 0x00020267
	[global::Cpp2ILInjected.Token(Token = "0x6000238")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D5E8", Offset = "0x70D5E8", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileManager), Member = "SynchroniseFiles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterizedThreadStart), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "Run", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void ResyncFiles()
	{
		throw null;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0002206A File Offset: 0x0002026A
	[global::Cpp2ILInjected.Token(Token = "0x6000239")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D6A0", Offset = "0x70D6A0", Length = "0x494")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "SyncFolder", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "InSync", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Profiler), Member = "EndThreadProfiling", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
	public void FileSyncInternal(object threadContext)
	{
		throw null;
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0002206D File Offset: 0x0002026D
	[global::Cpp2ILInjected.Token(Token = "0x600023A")]
	[global::Cpp2ILInjected.Address(RVA = "0x70DB34", Offset = "0x70DB34", Length = "0x214")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "FileSyncInternal", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "SyncFolder", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "SyncFolder", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "SyncFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void SyncFolder(string folderPath, bool recursive = false)
	{
		throw null;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00022070 File Offset: 0x00020270
	[global::Cpp2ILInjected.Token(Token = "0x600023B")]
	[global::Cpp2ILInjected.Address(RVA = "0x70DFC8", Offset = "0x70DFC8", Length = "0x21C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "SyncFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "WriteFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "ReadFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileManager), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileManager), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "CleanPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	private CachedFile GetFile(string path, bool create = true)
	{
		throw null;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00022073 File Offset: 0x00020273
	[global::Cpp2ILInjected.Token(Token = "0x600023C")]
	[global::Cpp2ILInjected.Address(RVA = "0x70DE44", Offset = "0x70DE44", Length = "0x184")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "SyncFolder", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "GetFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(CachedFile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void SyncFile(string filePath)
	{
		throw null;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00022076 File Offset: 0x00020276
	[global::Cpp2ILInjected.Token(Token = "0x600023D")]
	[global::Cpp2ILInjected.Address(RVA = "0x70E284", Offset = "0x70E284", Length = "0x544")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByUser", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(LocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadThreadstate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "GetFileModifications", MemberParameters = new object[] { typeof(List<CachedFile>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Profiler), Member = "EndThreadProfiling", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
	private void FileUpload(object threadContext)
	{
		throw null;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00022079 File Offset: 0x00020279
	[global::Cpp2ILInjected.Token(Token = "0x600023E")]
	[global::Cpp2ILInjected.Address(RVA = "0x70E904", Offset = "0x70E904", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public string GetUserSavePath()
	{
		throw null;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x0002207C File Offset: 0x0002027C
	[global::Cpp2ILInjected.Token(Token = "0x600023F")]
	[global::Cpp2ILInjected.Address(RVA = "0x70E90C", Offset = "0x70E90C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void LegacySync()
	{
		throw null;
	}

	// Token: 0x060001AD RID: 429 RVA: 0x0002207F File Offset: 0x0002027F
	[global::Cpp2ILInjected.Token(Token = "0x6000240")]
	[global::Cpp2ILInjected.Address(RVA = "0x70E910", Offset = "0x70E910", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Mount(bool forSync)
	{
		throw null;
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00022082 File Offset: 0x00020282
	[global::Cpp2ILInjected.Token(Token = "0x6000241")]
	[global::Cpp2ILInjected.Address(RVA = "0x70E914", Offset = "0x70E914", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Unmount(bool forSync)
	{
		throw null;
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00022085 File Offset: 0x00020285
	[global::Cpp2ILInjected.Token(Token = "0x6000242")]
	[global::Cpp2ILInjected.Address(RVA = "0x70E918", Offset = "0x70E918", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void CreateDirectory(string directory)
	{
		throw null;
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00022088 File Offset: 0x00020288
	[global::Cpp2ILInjected.Token(Token = "0x6000243")]
	[global::Cpp2ILInjected.Address(RVA = "0x70DD48", Offset = "0x70DD48", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "FileSyncInternal", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void InSync()
	{
		throw null;
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0002208B File Offset: 0x0002028B
	[global::Cpp2ILInjected.Token(Token = "0x6000244")]
	[global::Cpp2ILInjected.Address(RVA = "0x70E91C", Offset = "0x70E91C", Length = "0x1E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileManager), Member = "WriteAllBytes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "GetFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(CachedFile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void WriteFile(string filename, byte[] fileData)
	{
		throw null;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x0002208E File Offset: 0x0002028E
	[global::Cpp2ILInjected.Token(Token = "0x6000245")]
	[global::Cpp2ILInjected.Address(RVA = "0x70EB04", Offset = "0x70EB04", Length = "0x1B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileManager), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "GetFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(CachedFile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void Delete(string filename)
	{
		throw null;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00022091 File Offset: 0x00020291
	[global::Cpp2ILInjected.Token(Token = "0x6000246")]
	[global::Cpp2ILInjected.Address(RVA = "0x70ECB4", Offset = "0x70ECB4", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "GetFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(CachedFile))]
	public byte[] ReadFile(string filename)
	{
		throw null;
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00022094 File Offset: 0x00020294
	[global::Cpp2ILInjected.Token(Token = "0x6000247")]
	[global::Cpp2ILInjected.Address(RVA = "0x70E1E4", Offset = "0x70E1E4", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "GetFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(CachedFile))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "GetFiles", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "SelectAndHighlight", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "SelectAndHighlight", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "CleanSwitchPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public string CleanPath(string path)
	{
		throw null;
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00022097 File Offset: 0x00020297
	[global::Cpp2ILInjected.Token(Token = "0x6000248")]
	[global::Cpp2ILInjected.Address(RVA = "0x70ECD0", Offset = "0x70ECD0", Length = "0x2A0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileManager), Member = "GetFiles", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "CleanPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public string[] GetFiles(string path, string searchPattern)
	{
		throw null;
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0002209A File Offset: 0x0002029A
	[global::Cpp2ILInjected.Token(Token = "0x6000249")]
	[global::Cpp2ILInjected.Address(RVA = "0x70EF70", Offset = "0x70EF70", Length = "0x44")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public string[] GetFolders(string path)
	{
		throw null;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0002209D File Offset: 0x0002029D
	[global::Cpp2ILInjected.Token(Token = "0x600024A")]
	[global::Cpp2ILInjected.Address(RVA = "0x70E7C8", Offset = "0x70E7C8", Length = "0x13C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "FileUpload", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void GetFileModifications(List<CachedFile> files)
	{
		throw null;
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x000220A0 File Offset: 0x000202A0
	[global::Cpp2ILInjected.Token(Token = "0x600024B")]
	[global::Cpp2ILInjected.Address(RVA = "0x70EFB4", Offset = "0x70EFB4", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "GetFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(CachedFile))]
	public bool Exists(string filename)
	{
		throw null;
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x000220A3 File Offset: 0x000202A3
	[global::Cpp2ILInjected.Token(Token = "0x600024C")]
	[global::Cpp2ILInjected.Address(RVA = "0x70EFD8", Offset = "0x70EFD8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetAttributes(string filename, FileAttributes fileAttributes)
	{
		throw null;
	}

	// Token: 0x04000115 RID: 277
	[global::Cpp2ILInjected.Token(Token = "0x400020C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool UploadingFiles;

	// Token: 0x04000116 RID: 278
	[global::Cpp2ILInjected.Token(Token = "0x400020D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private List<CachedFile> allFiles;

	// Token: 0x04000117 RID: 279
	[global::Cpp2ILInjected.Token(Token = "0x400020E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private List<CachedFile> modifications;

	// Token: 0x04000118 RID: 280
	[global::Cpp2ILInjected.Token(Token = "0x400020F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private ManualResetEvent uploadPending;

	// Token: 0x04000119 RID: 281
	[global::Cpp2ILInjected.Token(Token = "0x4000210")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private readonly FileManager fileManager;

	// Token: 0x0400011A RID: 282
	[global::Cpp2ILInjected.Token(Token = "0x4000211")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private readonly FileAPI fileAPI;

	// Token: 0x0400011B RID: 283
	[global::Cpp2ILInjected.Token(Token = "0x4000212")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private readonly bool PrimaryUser;

	// Token: 0x0400011C RID: 284
	[global::Cpp2ILInjected.Token(Token = "0x4000213")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private readonly PlatformUser User;

	// Token: 0x0400011D RID: 285
	[global::Cpp2ILInjected.Token(Token = "0x4000214")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private ManagedThread UploadThread;

	// Token: 0x0400011E RID: 286
	[global::Cpp2ILInjected.Token(Token = "0x4000215")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private ManagedThread SyncThread;

	// Token: 0x0400011F RID: 287
	[global::Cpp2ILInjected.Token(Token = "0x4000216")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private string _userSavePath;
}