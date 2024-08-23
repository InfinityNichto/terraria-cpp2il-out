﻿using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Services
{
	// Token: 0x020002B8 RID: 696
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000358")]
	public class TrackingServices
	{
		// Token: 0x06001A66 RID: 6758 RVA: 0x00018F35 File Offset: 0x00017135
		[global::Cpp2ILInjected.Token(Token = "0x6001C8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B334A4", Offset = "0x1B334A4", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static void NotifyMarshaledObject(object obj, ObjRef or)
		{
			throw null;
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00018F38 File Offset: 0x00017138
		[global::Cpp2ILInjected.Token(Token = "0x6001C8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33784", Offset = "0x1B33784", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static void NotifyUnmarshaledObject(object obj, ObjRef or)
		{
			throw null;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00018F3B File Offset: 0x0001713B
		[global::Cpp2ILInjected.Token(Token = "0x6001C8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33A64", Offset = "0x1B33A64", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static void NotifyDisconnectedObject(object obj)
		{
			throw null;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00018F3E File Offset: 0x0001713E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001C8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33D38", Offset = "0x1B33D38", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static TrackingServices()
		{
			throw null;
		}

		// Token: 0x04000B96 RID: 2966
		[global::Cpp2ILInjected.Token(Token = "0x4000E7A")]
		private static global::System.Collections.ArrayList _handlers;
	}
}