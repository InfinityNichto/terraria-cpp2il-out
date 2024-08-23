﻿using System;
using System.Runtime.Remoting.Contexts;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000319 RID: 793
	[global::Cpp2ILInjected.Token(Token = "0x20003BF")]
	internal class ServerObjectTerminatorSink : IMessageSink
	{
		// Token: 0x06001C76 RID: 7286 RVA: 0x000194A2 File Offset: 0x000176A2
		[global::Cpp2ILInjected.Token(Token = "0x6001EAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4FC6C", Offset = "0x1B4FC6C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "CreateServerObjectSinkChain", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(bool)
		}, ReturnType = typeof(IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ServerObjectTerminatorSink(IMessageSink nextSink)
		{
			throw null;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000194A5 File Offset: 0x000176A5
		[global::Cpp2ILInjected.Token(Token = "0x6001EB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4FC94", Offset = "0x1B4FC94", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Identity), Member = "NotifyServerDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x000194A8 File Offset: 0x000176A8
		[global::Cpp2ILInjected.Token(Token = "0x6001EB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4FE00", Offset = "0x1B4FE00", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Identity), Member = "get_HasServerDynamicSinks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Identity), Member = "NotifyServerDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x04000C7F RID: 3199
		[global::Cpp2ILInjected.Token(Token = "0x4000F6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IMessageSink _nextSink;
	}
}