﻿using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002B2")]
	internal sealed class LinuxNetworkInterface : UnixNetworkInterface
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700044C")]
		internal string IfacePath
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1F17C", Offset = "0x1E1F17C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1F09C", Offset = "0x1E1F09C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnixNetworkInterface), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal LinuxNetworkInterface(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1F184", Offset = "0x1E1F184", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinuxIPInterfaceProperties), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LinuxNetworkInterface),
			typeof(List<IPAddress>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPInterfaceProperties GetIPProperties()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700044D")]
		public override OperationalStatus OperationalStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1F1F0", Offset = "0x1E1F1F0", Length = "0x2BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinuxNetworkInterface), Member = "ReadLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1F4AC", Offset = "0x1E1F4AC", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterface), Member = "get_OperationalStatus", ReturnType = typeof(OperationalStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal static string ReadLine(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000ED1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string iface_path;

		[global::Cpp2ILInjected.Token(Token = "0x4000ED2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string iface_operstate_path;

		[global::Cpp2ILInjected.Token(Token = "0x4000ED3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string iface_flags_path;
	}
}
