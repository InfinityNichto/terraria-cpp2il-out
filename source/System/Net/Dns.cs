﻿using System;
using System.Collections;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200018F RID: 399
	[global::Cpp2ILInjected.Token(Token = "0x200023B")]
	public static class Dns
	{
		// Token: 0x06000CE2 RID: 3298 RVA: 0x000052EE File Offset: 0x000034EE
		[global::Cpp2ILInjected.Token(Token = "0x6000E4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F42444", Offset = "0x1F42444", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		static Dns()
		{
			throw null;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000052F1 File Offset: 0x000034F1
		[Obsolete("Use BeginGetHostEntry instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000E4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F42448", Offset = "0x1F42448", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns.GetHostByNameCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static IAsyncResult BeginGetHostByName(string hostName, AsyncCallback requestCallback, object stateObject)
		{
			throw null;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000052F4 File Offset: 0x000034F4
		[Obsolete("Use BeginGetHostEntry instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000E4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F42624", Offset = "0x1F42624", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns.ResolveCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static IAsyncResult BeginResolve(string hostName, AsyncCallback requestCallback, object stateObject)
		{
			throw null;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000052F7 File Offset: 0x000034F7
		[global::Cpp2ILInjected.Token(Token = "0x6000E4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F42800", Offset = "0x1F42800", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns.GetHostAddressesCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state)
		{
			throw null;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000052FA File Offset: 0x000034FA
		[global::Cpp2ILInjected.Token(Token = "0x6000E50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F42A74", Offset = "0x1F42A74", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns.GetHostEntryNameCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static IAsyncResult BeginGetHostEntry(string hostNameOrAddress, AsyncCallback requestCallback, object stateObject)
		{
			throw null;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000052FD File Offset: 0x000034FD
		[global::Cpp2ILInjected.Token(Token = "0x6000E51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F42CE8", Offset = "0x1F42CE8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns.GetHostEntryIPCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static IAsyncResult BeginGetHostEntry(IPAddress address, AsyncCallback requestCallback, object stateObject)
		{
			throw null;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00005300 File Offset: 0x00003500
		[Obsolete("Use EndGetHostEntry instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000E52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F42F1C", Offset = "0x1F42F1C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static IPHostEntry EndGetHostByName(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00005303 File Offset: 0x00003503
		[Obsolete("Use EndGetHostEntry instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000E53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F43028", Offset = "0x1F43028", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static IPHostEntry EndResolve(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00005306 File Offset: 0x00003506
		[global::Cpp2ILInjected.Token(Token = "0x6000E54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F43134", Offset = "0x1F43134", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00005309 File Offset: 0x00003509
		[global::Cpp2ILInjected.Token(Token = "0x6000E55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F43240", Offset = "0x1F43240", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static IPHostEntry EndGetHostEntry(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000CEC RID: 3308
		[global::Cpp2ILInjected.Token(Token = "0x6000E56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F433B0", Offset = "0x1F433B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint);

		// Token: 0x06000CED RID: 3309
		[global::Cpp2ILInjected.Token(Token = "0x6000E57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F433B4", Offset = "0x1F433B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint);

		// Token: 0x06000CEE RID: 3310
		[global::Cpp2ILInjected.Token(Token = "0x6000E58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F433B8", Offset = "0x1F433B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool GetHostName_icall(out string h_name);

		// Token: 0x06000CEF RID: 3311 RVA: 0x0000530C File Offset: 0x0000350C
		[global::Cpp2ILInjected.Token(Token = "0x6000E59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F433BC", Offset = "0x1F433BC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void Error_11001(string hostName)
		{
			throw null;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0000530F File Offset: 0x0000350F
		[global::Cpp2ILInjected.Token(Token = "0x6000E5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F43420", Offset = "0x1F43420", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPHostEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv6", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv4", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist)
		{
			throw null;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00005312 File Offset: 0x00003512
		[Obsolete("Use GetHostEntry instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000E5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4370C", Offset = "0x1F4370C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IPHostEntry GetHostByAddress(IPAddress address)
		{
			throw null;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00005315 File Offset: 0x00003515
		[Obsolete("Use GetHostEntry instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000E5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4393C", Offset = "0x1F4393C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "Resolve", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IPHostEntry GetHostByAddress(string address)
		{
			throw null;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00005318 File Offset: 0x00003518
		[global::Cpp2ILInjected.Token(Token = "0x6000E5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F437C8", Offset = "0x1F437C8", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostByAddress", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_FamilyHint", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static IPHostEntry GetHostByAddressFromString(string address, bool parse)
		{
			throw null;
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0000531B File Offset: 0x0000351B
		[global::Cpp2ILInjected.Token(Token = "0x6000E5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F439E0", Offset = "0x1F439E0", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "GetIPV6AddressFromIPV4", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "GetLocalIPAddress", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "BuildServiceNames", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostAddresses", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPAddress[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref IPAddress)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static IPHostEntry GetHostEntry(string hostNameOrAddress)
		{
			throw null;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0000531E File Offset: 0x0000351E
		[global::Cpp2ILInjected.Token(Token = "0x6000E5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F43B84", Offset = "0x1F43B84", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IPHostEntry GetHostEntry(IPAddress address)
		{
			throw null;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00005321 File Offset: 0x00003521
		[global::Cpp2ILInjected.Token(Token = "0x6000E60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F43D80", Offset = "0x1F43D80", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "Resolve", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref IPAddress)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static IPAddress[] GetHostAddresses(string hostNameOrAddress)
		{
			throw null;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00005324 File Offset: 0x00003524
		[Obsolete("Use GetHostEntry instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000E61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F43C40", Offset = "0x1F43C40", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NclUtilities), Member = "GetLocalHost", ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "Resolve", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(HttpListener),
			typeof(bool)
		}, ReturnType = typeof(EndPointListener))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_FamilyHint", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static IPHostEntry GetHostByName(string hostName)
		{
			throw null;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00005327 File Offset: 0x00003527
		[global::Cpp2ILInjected.Token(Token = "0x6000E62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F43F60", Offset = "0x1F43F60", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationBroadcast", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NetMessage", Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			"Terraria.Localization.NetworkText",
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "GetLocalIPAddress", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "StartBroadCasting", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NclUtilities), Member = "GetLocalHost", ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string GetHostName()
		{
			throw null;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0000532A File Offset: 0x0000352A
		[Obsolete("Use GetHostEntry instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000E63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F43FD8", Offset = "0x1F43FD8", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostByAddress", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static IPHostEntry Resolve(string hostName)
		{
			throw null;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0000532D File Offset: 0x0000352D
		[global::Cpp2ILInjected.Token(Token = "0x6000E64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F44110", Offset = "0x1F44110", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory<>), Member = "FromAsync", MemberTypeParameters = new object[] { "TArg1" }, MemberParameters = new object[]
		{
			"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			"TArg1",
			typeof(object)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress)
		{
			throw null;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00005330 File Offset: 0x00003530
		[global::Cpp2ILInjected.Token(Token = "0x6000E65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4422C", Offset = "0x1F4422C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory<>), Member = "FromAsync", MemberTypeParameters = new object[] { "TArg1" }, MemberParameters = new object[]
		{
			"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			"TArg1",
			typeof(object)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Task<IPHostEntry> GetHostEntryAsync(IPAddress address)
		{
			throw null;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00005333 File Offset: 0x00003533
		[global::Cpp2ILInjected.Token(Token = "0x6000E66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F44348", Offset = "0x1F44348", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory<>), Member = "FromAsync", MemberTypeParameters = new object[] { "TArg1" }, MemberParameters = new object[]
		{
			"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			"TArg1",
			typeof(object)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress)
		{
			throw null;
		}

		// Token: 0x02000410 RID: 1040
		// (Invoke) Token: 0x06001E0A RID: 7690
		[global::Cpp2ILInjected.Token(Token = "0x200023C")]
		private delegate IPHostEntry GetHostByNameCallback(string hostName);

		// Token: 0x02000411 RID: 1041
		// (Invoke) Token: 0x06001E0E RID: 7694
		[global::Cpp2ILInjected.Token(Token = "0x200023D")]
		private delegate IPHostEntry ResolveCallback(string hostName);

		// Token: 0x02000412 RID: 1042
		// (Invoke) Token: 0x06001E12 RID: 7698
		[global::Cpp2ILInjected.Token(Token = "0x200023E")]
		private delegate IPHostEntry GetHostEntryNameCallback(string hostName);

		// Token: 0x02000413 RID: 1043
		// (Invoke) Token: 0x06001E16 RID: 7702
		[global::Cpp2ILInjected.Token(Token = "0x200023F")]
		private delegate IPHostEntry GetHostEntryIPCallback(IPAddress hostAddress);

		// Token: 0x02000414 RID: 1044
		// (Invoke) Token: 0x06001E1A RID: 7706
		[global::Cpp2ILInjected.Token(Token = "0x2000240")]
		private delegate IPAddress[] GetHostAddressesCallback(string hostName);
	}
}