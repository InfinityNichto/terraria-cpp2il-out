﻿using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200009E")]
	internal static class Platform
	{
		[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA75F0", Offset = "0x1EA75F0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Platform), Member = "CheckOS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		private static extern int uname(IntPtr buf);

		[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA766C", Offset = "0x1EA766C", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Platform), Member = "get_IsMacOS", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Platform), Member = "get_IsFreeBSD", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Platform), Member = "get_IsOpenBSD", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Platform), Member = "get_IsIBMi", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Platform), Member = "get_IsAix", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Platform), Member = "uname", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void CheckOS()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000092")]
		public static bool IsMacOS
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA7870", Offset = "0x1EA7870", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Platform), Member = "CheckOS", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000093")]
		public static bool IsFreeBSD
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA7950", Offset = "0x1EA7950", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Platform), Member = "CheckOS", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000094")]
		public static bool IsOpenBSD
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA79AC", Offset = "0x1EA79AC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnixNetworkInterfaceFactoryPal), Member = "Create", ReturnType = typeof(NetworkInterfaceFactory))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Platform), Member = "CheckOS", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000095")]
		public static bool IsIBMi
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA7A08", Offset = "0x1EA7A08", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnixNetworkInterfaceFactoryPal), Member = "Create", ReturnType = typeof(NetworkInterfaceFactory))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Platform), Member = "CheckOS", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000096")]
		public static bool IsAix
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA7A64", Offset = "0x1EA7A64", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnixNetworkInterfaceFactoryPal), Member = "Create", ReturnType = typeof(NetworkInterfaceFactory))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Platform), Member = "CheckOS", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000270")]
		private static bool checkedOS;

		[global::Cpp2ILInjected.Token(Token = "0x4000271")]
		private static bool isMacOS;

		[global::Cpp2ILInjected.Token(Token = "0x4000272")]
		private static bool isAix;

		[global::Cpp2ILInjected.Token(Token = "0x4000273")]
		private static bool isIBMi;

		[global::Cpp2ILInjected.Token(Token = "0x4000274")]
		private static bool isFreeBSD;

		[global::Cpp2ILInjected.Token(Token = "0x4000275")]
		private static bool isOpenBSD;
	}
}
