﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x200056A")]
	internal static class MonoIO
	{
		[global::Cpp2ILInjected.Token(Token = "0x60029A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE1B8", Offset = "0x1BCE1B8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.HandleRef),
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(global::System.Runtime.InteropServices.HandleRef),
			typeof(ref Microsoft.Win32.SafeHandles.SafeWaitHandle),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.HandleRef),
			typeof(global::System.Runtime.InteropServices.HandleRef),
			typeof(global::System.Runtime.InteropServices.HandleRef),
			"Microsoft.Win32.SafeHandles.SafeProcessHandle&",
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new object[]
		{
			typeof(ref global::System.IntPtr),
			typeof(ref global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UnauthorizedAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(MonoIOError)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static global::System.Exception GetException(MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCAAA4", Offset = "0x1BCAAA4", Length = "0x6C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new object[]
		{
			typeof(Microsoft.Win32.SafeHandles.SafeFileHandle),
			typeof(FileAccess),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new object[]
		{
			typeof(long),
			typeof(SeekOrigin)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new object[] { typeof(MonoIOError) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathTooLongException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DirectoryNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UnauthorizedAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		public static global::System.Exception GetException(string path, MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE2E0", Offset = "0x1BCE2E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern string GetCurrentDirectory(out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE2E4", Offset = "0x1BCE2E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern bool SetFileAttributes(char* path, FileAttributes attrs, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE2E8", Offset = "0x1BCE2E8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool SetFileAttributes(string path, FileAttributes attrs, out MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE364", Offset = "0x1BCE364", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern MonoFileType GetFileType(global::System.IntPtr handle, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCB168", Offset = "0x1BCB168", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new object[]
		{
			typeof(Microsoft.Win32.SafeHandles.SafeFileHandle),
			typeof(FileAccess),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static MonoFileType GetFileType(global::System.Runtime.InteropServices.SafeHandle safeHandle, out MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE368", Offset = "0x1BCE368", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern global::System.IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCA990", Offset = "0x1BCA990", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static global::System.IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE36C", Offset = "0x1BCE36C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool Cancel_internal(global::System.IntPtr handle, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE370", Offset = "0x1BCE370", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.AsyncStreamReader", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static bool Cancel(global::System.Runtime.InteropServices.SafeHandle safeHandle, out MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCDEB0", Offset = "0x1BCDEB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafeFileHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new object[]
		{
			typeof(ref global::System.IntPtr),
			typeof(ref global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern bool Close(global::System.IntPtr handle, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE480", Offset = "0x1BCE480", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int Read(global::System.IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCDF44", Offset = "0x1BCDF44", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static int Read(global::System.Runtime.InteropServices.SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE484", Offset = "0x1BCE484", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int Write(global::System.IntPtr handle, [global::System.Runtime.InteropServices.In] byte[] src, int src_offset, int count, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCCD0C", Offset = "0x1BCCD0C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static int Write(global::System.Runtime.InteropServices.SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE488", Offset = "0x1BCE488", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern long Seek(global::System.IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCB528", Offset = "0x1BCB528", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new object[]
		{
			typeof(Microsoft.Win32.SafeHandles.SafeFileHandle),
			typeof(FileAccess),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new object[]
		{
			typeof(long),
			typeof(SeekOrigin)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static long Seek(global::System.Runtime.InteropServices.SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE48C", Offset = "0x1BCE48C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern long GetLength(global::System.IntPtr handle, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCB7E4", Offset = "0x1BCB7E4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static long GetLength(global::System.Runtime.InteropServices.SafeHandle safeHandle, out MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE490", Offset = "0x1BCE490", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool SetLength(global::System.IntPtr handle, long length, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCD960", Offset = "0x1BCD960", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool SetLength(global::System.Runtime.InteropServices.SafeHandle safeHandle, long length, out MonoIOError error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005FF")]
		public static extern global::System.IntPtr ConsoleOutput
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE494", Offset = "0x1BCE494", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "OpenStandardOutput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000600")]
		public static extern global::System.IntPtr ConsoleInput
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE498", Offset = "0x1BCE498", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "OpenStandardInput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000601")]
		public static extern global::System.IntPtr ConsoleError
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE49C", Offset = "0x1BCE49C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "OpenStandardError", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE4A0", Offset = "0x1BCE4A0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new object[]
		{
			typeof(ref global::System.IntPtr),
			typeof(ref global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern bool CreatePipe(out global::System.IntPtr read_handle, out global::System.IntPtr write_handle, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x60029BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE4A4", Offset = "0x1BCE4A4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.HandleRef),
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(global::System.Runtime.InteropServices.HandleRef),
			typeof(ref Microsoft.Win32.SafeHandles.SafeWaitHandle),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.HandleRef),
			typeof(global::System.Runtime.InteropServices.HandleRef),
			typeof(global::System.Runtime.InteropServices.HandleRef),
			"Microsoft.Win32.SafeHandles.SafeProcessHandle&",
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new object[]
		{
			typeof(ref global::System.IntPtr),
			typeof(ref global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern bool DuplicateHandle(global::System.IntPtr source_process_handle, global::System.IntPtr source_handle, global::System.IntPtr target_process_handle, out global::System.IntPtr target_handle, int access, int inherit, int options, out MonoIOError error);

		[global::Cpp2ILInjected.Token(Token = "0x17000602")]
		public static extern char VolumeSeparatorChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE4A8", Offset = "0x1BCE4A8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000603")]
		public static extern char DirectorySeparatorChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE4AC", Offset = "0x1BCE4AC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000604")]
		public static extern char AltDirectorySeparatorChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE4B0", Offset = "0x1BCE4B0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000605")]
		public static extern char PathSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE4B4", Offset = "0x1BCE4B4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE2DC", Offset = "0x1BCE2DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void DumpHandles();

		[global::Cpp2ILInjected.Token(Token = "0x60029C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE4B8", Offset = "0x1BCE4B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern bool RemapPath(string path, out string newPath);

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60029C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE4BC", Offset = "0x1BCE4BC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static MonoIO()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001657")]
		public static readonly global::System.IntPtr InvalidHandle;

		[global::Cpp2ILInjected.Token(Token = "0x4001658")]
		private static bool dump_handles;
	}
}
