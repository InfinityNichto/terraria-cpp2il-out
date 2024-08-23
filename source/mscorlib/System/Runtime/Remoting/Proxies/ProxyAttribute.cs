﻿using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x020002B9 RID: 697
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x2000359")]
	public class ProxyAttribute : global::System.Attribute, global::System.Runtime.Remoting.Contexts.IContextAttribute
	{
		// Token: 0x06001A6A RID: 6762 RVA: 0x00018F41 File Offset: 0x00017141
		[global::Cpp2ILInjected.Token(Token = "0x6001C8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33DA8", Offset = "0x1B33DA8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateConstructionCall", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual global::System.MarshalByRefObject CreateInstance(global::System.Type serverType)
		{
			throw null;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00018F44 File Offset: 0x00017144
		[global::Cpp2ILInjected.Token(Token = "0x6001C90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33EE4", Offset = "0x1B33EE4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetProxyForRemoteObject", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetRealProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(RealProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual RealProxy CreateProxy(ObjRef objRef, global::System.Type serverType, object serverObject, global::System.Runtime.Remoting.Contexts.Context serverContext)
		{
			throw null;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00018F47 File Offset: 0x00017147
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6001C91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33F54", Offset = "0x1B33F54", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void GetPropertiesForNewContext(global::System.Runtime.Remoting.Activation.IConstructionCallMessage msg)
		{
			throw null;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00018F4A File Offset: 0x0001714A
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6001C92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33F58", Offset = "0x1B33F58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsContextOK(global::System.Runtime.Remoting.Contexts.Context ctx, global::System.Runtime.Remoting.Activation.IConstructionCallMessage msg)
		{
			throw null;
		}
	}
}
