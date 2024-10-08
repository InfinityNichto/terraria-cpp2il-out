﻿using System;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Util;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200015C")]
	internal sealed class SharedStatics
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C75170", Offset = "0x1C75170", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private SharedStatics()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C75178", Offset = "0x1C75178", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityDocument), Member = "GetString", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "BasicInitialization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Util.Tokenizer.StringMaker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static global::System.Security.Util.Tokenizer.StringMaker GetSharedStringMaker()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C75324", Offset = "0x1C75324", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityDocument), Member = "GetString", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "Recycle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void ReleaseSharedStringMaker(ref global::System.Security.Util.Tokenizer.StringMaker maker)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000E27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C75468", Offset = "0x1C75468", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static SharedStatics()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000568")]
		private static readonly global::System.SharedStatics _sharedStatics;

		[global::Cpp2ILInjected.Token(Token = "0x4000569")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Security.Util.Tokenizer.StringMaker _maker;
	}
}
