﻿using System;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Utilities;
using UnityEngine;

// Token: 0x0200004A RID: 74
[global::Cpp2ILInjected.Token(Token = "0x2000070")]
public class FileManager
{
	// Token: 0x060001DB RID: 475 RVA: 0x000220E2 File Offset: 0x000202E2
	[global::Cpp2ILInjected.Token(Token = "0x600026E")]
	[global::Cpp2ILInjected.Address(RVA = "0x70FA88", Offset = "0x70FA88", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultFileAPI), Member = ".ctor", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(FileManager),
		typeof(FileAPI),
		typeof(bool),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public FileManager(PlatformUser user, bool primaryUser)
	{
		throw null;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x000220E5 File Offset: 0x000202E5
	[global::Cpp2ILInjected.Token(Token = "0x600026F")]
	[global::Cpp2ILInjected.Address(RVA = "0x70FB50", Offset = "0x70FB50", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "ResyncFiles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public static void SynchroniseFiles()
	{
		throw null;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x000220E8 File Offset: 0x000202E8
	[global::Cpp2ILInjected.Token(Token = "0x6000270")]
	[global::Cpp2ILInjected.Address(RVA = "0x70FC10", Offset = "0x70FC10", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "SwitchPrimaryUser", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "UserSignedOut", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "LocalUserQuit", MemberParameters = new object[] { typeof(LocalUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void Shutdown()
	{
		throw null;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x000220EB File Offset: 0x000202EB
	[global::Cpp2ILInjected.Token(Token = "0x6000271")]
	[global::Cpp2ILInjected.Address(RVA = "0x70FCB8", Offset = "0x70FCB8", Length = "0x13C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Copy", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "GetFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(CachedFile))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public static bool Exists(string path)
	{
		throw null;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x000220EE File Offset: 0x000202EE
	[global::Cpp2ILInjected.Token(Token = "0x6000272")]
	[global::Cpp2ILInjected.Address(RVA = "0x70FDF4", Offset = "0x70FDF4", Length = "0x248")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ErasePlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Delete", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "MoveToCloud", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public static void Delete(string path)
	{
		throw null;
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x000220F1 File Offset: 0x000202F1
	[global::Cpp2ILInjected.Token(Token = "0x6000273")]
	[global::Cpp2ILInjected.Address(RVA = "0x71003C", Offset = "0x71003C", Length = "0x114")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Write", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[]),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public static void CreateDirectory(string path)
	{
		throw null;
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x000220F4 File Offset: 0x000202F4
	[global::Cpp2ILInjected.Token(Token = "0x6000274")]
	[global::Cpp2ILInjected.Address(RVA = "0x710150", Offset = "0x710150", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Copy", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "ReadAllText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "MoveToCloud", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "GetFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(CachedFile))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public static byte[] ReadAllBytes(string path)
	{
		throw null;
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x000220F7 File Offset: 0x000202F7
	[global::Cpp2ILInjected.Token(Token = "0x6000275")]
	[global::Cpp2ILInjected.Address(RVA = "0x710284", Offset = "0x710284", Length = "0x13C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFile), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ErasePlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "GetFiles", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "GetFiles", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public static string[] GetFiles(string path, string searchPattern)
	{
		throw null;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x000220FA File Offset: 0x000202FA
	[global::Cpp2ILInjected.Token(Token = "0x6000276")]
	[global::Cpp2ILInjected.Address(RVA = "0x7103C0", Offset = "0x7103C0", Length = "0x1BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Write", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[]),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "WriteFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public static void WriteAllBytes(string path, byte[] fileData)
	{
		throw null;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x000220FD File Offset: 0x000202FD
	[global::Cpp2ILInjected.Token(Token = "0x6000277")]
	[global::Cpp2ILInjected.Address(RVA = "0x71057C", Offset = "0x71057C", Length = "0x10F4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "SetAttributes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(FileAttributes)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public static void SetAttributes(string path, FileAttributes fileAttributes)
	{
		throw null;
	}

	// Token: 0x04000129 RID: 297
	[ThreadStatic]
	[global::Cpp2ILInjected.Token(Token = "0x4000220")]
	public static FileManager Instance;

	// Token: 0x0400012A RID: 298
	[global::Cpp2ILInjected.Token(Token = "0x4000221")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool CacheFiles;

	// Token: 0x0400012B RID: 299
	[global::Cpp2ILInjected.Token(Token = "0x4000222")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public FileAPI fileAPI;

	// Token: 0x0400012C RID: 300
	[global::Cpp2ILInjected.Token(Token = "0x4000223")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public CacheFileManager FileCache;

	// Token: 0x0400012D RID: 301
	[global::Cpp2ILInjected.Token(Token = "0x4000224")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool IsSyncingUserFiles;

	// Token: 0x0400012E RID: 302
	[global::Cpp2ILInjected.Token(Token = "0x4000225")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	public bool IsWritingFiles;

	// Token: 0x0400012F RID: 303
	[global::Cpp2ILInjected.Token(Token = "0x4000226")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public SyncStatus syncStatus;
}