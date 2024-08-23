﻿using System;
using System.Runtime.Remoting.Channels;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x02000299 RID: 665
	[global::Cpp2ILInjected.Token(Token = "0x2000337")]
	[global::System.Serializable]
	internal class ChannelInfo : IChannelInfo
	{
		// Token: 0x0600198B RID: 6539 RVA: 0x00018CC8 File Offset: 0x00016EC8
		[global::Cpp2ILInjected.Token(Token = "0x6001BAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24990", Offset = "0x1B24990", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjRef), Member = "UpdateChannelInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "GetCurrentChannelInfo", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ChannelInfo()
		{
			throw null;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00018CCB File Offset: 0x00016ECB
		[global::Cpp2ILInjected.Token(Token = "0x6001BAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B249F8", Offset = "0x1B249F8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ChannelInfo(object remoteChannelData)
		{
			throw null;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00018CCE File Offset: 0x00016ECE
		[global::Cpp2ILInjected.Token(Token = "0x17000322")]
		public object[] ChannelData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24A8C", Offset = "0x1B24A8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000B38 RID: 2872
		[global::Cpp2ILInjected.Token(Token = "0x4000E18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object[] channelData;
	}
}
