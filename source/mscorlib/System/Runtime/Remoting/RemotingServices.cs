﻿using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Services;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002AB RID: 683
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000349")]
	public static class RemotingServices
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x00018E09 File Offset: 0x00017009
		[global::Cpp2ILInjected.Token(Token = "0x6001C1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2CEB0", Offset = "0x1B2CEB0", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.RemotingSurrogateSelector), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.StreamingContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.StreamingContextStates),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.ISurrogateSelector),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "RegisterInternalChannels", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "CreateWellKnownServerIdentity", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(WellKnownObjectMode)
		}, ReturnType = typeof(ServerIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		static RemotingServices()
		{
			throw null;
		}

		// Token: 0x060019FC RID: 6652
		[global::Cpp2ILInjected.Token(Token = "0x6001C1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2D18C", Offset = "0x1B2D18C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern object InternalExecute(global::System.Reflection.MethodBase method, object obj, object[] parameters, out object[] out_args);

		// Token: 0x060019FD RID: 6653
		[global::Cpp2ILInjected.Token(Token = "0x6001C20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2D190", Offset = "0x1B2D190", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Reflection.MethodBase GetVirtualMethod(global::System.Type type, global::System.Reflection.MethodBase method);

		// Token: 0x060019FE RID: 6654 RVA: 0x00018E0C File Offset: 0x0001700C
		[global::Cpp2ILInjected.Token(Token = "0x6001C21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2D194", Offset = "0x1B2D194", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetRealProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Runtime.Remoting.Proxies.RealProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Runtime.Remoting.Contexts.Context)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetDynamicPropertyCollection", MemberParameters = new object[]
		{
			typeof(global::System.ContextBoundObject),
			typeof(global::System.Runtime.Remoting.Contexts.Context)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "MarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.RemotingSurrogate), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.StackBuilderSink), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsTransparentProxy(object proxy)
		{
			throw null;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00018E0F File Offset: 0x0001700F
		[global::Cpp2ILInjected.Token(Token = "0x6001C22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2D1CC", Offset = "0x1B2D1CC", Length = "0x8F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.StackBuilderSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.StackBuilderSink), Member = "ExecuteAsyncMessage", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.CallContext), Member = "SetLogicalCallContext", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(global::System.Threading.ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(int),
			typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		internal static global::System.Runtime.Remoting.Messaging.IMethodReturnMessage InternalExecuteMessage(global::System.MarshalByRefObject target, global::System.Runtime.Remoting.Messaging.IMethodCallMessage reqMsg)
		{
			throw null;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00018E12 File Offset: 0x00017012
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6001C23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2DAC0", Offset = "0x1B2DAC0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.AppDomainLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static object Connect(global::System.Type classToProxy, string url)
		{
			throw null;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00018E15 File Offset: 0x00017015
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6001C24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2DBC8", Offset = "0x1B2DBC8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new object[] { typeof(WellKnownClientTypeEntry) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetRemoteObject", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static object Connect(global::System.Type classToProxy, string url, object data)
		{
			throw null;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00018E18 File Offset: 0x00017018
		[global::Cpp2ILInjected.Token(Token = "0x6001C25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2DC68", Offset = "0x1B2DC68", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static global::System.Type GetServerTypeForUri(string URI)
		{
			throw null;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00018E1B File Offset: 0x0001701B
		[global::Cpp2ILInjected.Token(Token = "0x6001C26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B26194", Offset = "0x1B26194", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static object Unmarshal(ObjRef objectRef)
		{
			throw null;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00018E1E File Offset: 0x0001701E
		[global::Cpp2ILInjected.Token(Token = "0x6001C27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2DF44", Offset = "0x1B2DF44", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new object[] { typeof(ObjRef) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = "get_ServerType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = "get_IsReferenceToWellKnow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetRemoteObject", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetProxyForRemoteObject", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Services.TrackingServices), Member = "NotifyUnmarshaledObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ObjRef)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static object Unmarshal(ObjRef objectRef, bool fRefine)
		{
			throw null;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00018E21 File Offset: 0x00017021
		[global::Cpp2ILInjected.Token(Token = "0x6001C28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2E270", Offset = "0x1B2E270", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.RemoteActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "MarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ObjRef Marshal(global::System.MarshalByRefObject Obj)
		{
			throw null;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00018E24 File Offset: 0x00017024
		[global::Cpp2ILInjected.Token(Token = "0x6001C29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2E2BC", Offset = "0x1B2E2BC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "GetMarshalledDomainObjRef", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new object[] { typeof(global::System.MarshalByRefObject) }, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ObjRef Marshal(global::System.MarshalByRefObject Obj, string ObjURI, global::System.Type RequestedType)
		{
			throw null;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00018E27 File Offset: 0x00017027
		[global::Cpp2ILInjected.Token(Token = "0x6001C2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2E37C", Offset = "0x1B2E37C", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "NewGuid", ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static string NewUri()
		{
			throw null;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00018E2A File Offset: 0x0001702A
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001C2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2E334", Offset = "0x1B2E334", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.ProxyAttribute), Member = "CreateProxy", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Contexts.Context)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Proxies.RealProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetDynamicPropertyCollection", MemberParameters = new object[]
		{
			typeof(global::System.ContextBoundObject),
			typeof(global::System.Runtime.Remoting.Contexts.Context)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.RemotingSurrogate), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.StackBuilderSink), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static global::System.Runtime.Remoting.Proxies.RealProxy GetRealProxy(object proxy)
		{
			throw null;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00018E2D File Offset: 0x0001702D
		[global::Cpp2ILInjected.Token(Token = "0x6001C2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2EB64", Offset = "0x1B2EB64", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = "get_MethodBase", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static global::System.Reflection.MethodBase GetMethodBaseFromMethodMessage(global::System.Runtime.Remoting.Messaging.IMethodMessage msg)
		{
			throw null;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00018E30 File Offset: 0x00017030
		[global::Cpp2ILInjected.Token(Token = "0x6001C2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2EE44", Offset = "0x1B2EE44", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static global::System.Reflection.MethodBase GetMethodBaseFromName(global::System.Type type, string methodName, global::System.Type[] signature)
		{
			throw null;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00018E33 File Offset: 0x00017033
		[global::Cpp2ILInjected.Token(Token = "0x6001C2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F00C", Offset = "0x1B2F00C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "FindInterfaceMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "FindInterfaceMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.Reflection.MethodBase FindInterfaceMethod(global::System.Type type, string methodName, global::System.Type[] signature)
		{
			throw null;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00018E36 File Offset: 0x00017036
		[global::Cpp2ILInjected.Token(Token = "0x6001C2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F120", Offset = "0x1B2F120", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.RemotingSurrogate), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new object[] { typeof(global::System.MarshalByRefObject) }, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void GetObjectData(object obj, global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00018E39 File Offset: 0x00017039
		[global::Cpp2ILInjected.Token(Token = "0x6001C30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F1CC", Offset = "0x1B2F1CC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = "get_CallType", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.CallType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsOneWay(global::System.Reflection.MethodBase method)
		{
			throw null;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00018E3C File Offset: 0x0001703C
		[global::Cpp2ILInjected.Token(Token = "0x6001C31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F25C", Offset = "0x1B2F25C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateProxyForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes)
		{
			throw null;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00018E3F File Offset: 0x0001703F
		[global::Cpp2ILInjected.Token(Token = "0x6001C32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F34C", Offset = "0x1B2F34C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetClientChannelSinkChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref string)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static object CreateClientProxy(global::System.Type objectType, string url, object[] activationAttributes)
		{
			throw null;
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x00018E42 File Offset: 0x00017042
		[global::Cpp2ILInjected.Token(Token = "0x6001C33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F554", Offset = "0x1B2F554", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateProxyForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "Connect", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static object CreateClientProxy(WellKnownClientTypeEntry entry)
		{
			throw null;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00018E45 File Offset: 0x00017045
		[global::Cpp2ILInjected.Token(Token = "0x6001C34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F5B8", Offset = "0x1B2F5B8", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateProxyForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static object CreateClientProxyForContextBound(global::System.Type type, object[] activationAttributes)
		{
			throw null;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00018E48 File Offset: 0x00017048
		[global::Cpp2ILInjected.Token(Token = "0x6001C35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2DD10", Offset = "0x1B2DD10", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetServerTypeForUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetProxyForRemoteObject", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "GetAppDomainTarget", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "CheckIncomingMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.AppDomainLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetNormalizedUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "RemoveAppNameFromUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static Identity GetIdentityForUri(string uri)
		{
			throw null;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00018E4B File Offset: 0x0001704B
		[global::Cpp2ILInjected.Token(Token = "0x6001C36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F79C", Offset = "0x1B2F79C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static string RemoveAppNameFromUri(string uri)
		{
			throw null;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00018E4E File Offset: 0x0001704E
		[global::Cpp2ILInjected.Token(Token = "0x6001C37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F884", Offset = "0x1B2F884", Length = "0x490")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetRemoteObject", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.AppDomainLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetClientChannelSinkChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref string)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetNormalizedUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClientIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ObjRef)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ClientIdentity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClientIdentity), Member = "set_ClientProxy", MemberParameters = new object[] { typeof(global::System.MarshalByRefObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClientIdentity), Member = "get_ClientProxy", ReturnType = typeof(global::System.MarshalByRefObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "DisposeIdentity", MemberParameters = new object[] { typeof(Identity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, global::System.Type proxyType, out object clientProxy)
		{
			throw null;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00018E51 File Offset: 0x00017051
		[global::Cpp2ILInjected.Token(Token = "0x6001C38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F474", Offset = "0x1B2F474", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(ClientIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref string)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static global::System.Runtime.Remoting.Messaging.IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri)
		{
			throw null;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00018E54 File Offset: 0x00017054
		[global::Cpp2ILInjected.Token(Token = "0x6001C39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2FEF4", Offset = "0x1B2FEF4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ContextLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClientActivatedIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(global::System.Type objectType)
		{
			throw null;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00018E57 File Offset: 0x00017057
		[global::Cpp2ILInjected.Token(Token = "0x6001C3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2EA2C", Offset = "0x1B2EA2C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClientActivatedIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "get_DefaultContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Runtime.Remoting.Contexts.Context)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "RegisterServerIdentity", MemberParameters = new object[] { typeof(ServerIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerIdentity), Member = "StartTrackingLifetime", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Lifetime.ILease) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(global::System.MarshalByRefObject realObject, global::System.Type objectType, string objectUri)
		{
			throw null;
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00018E5A File Offset: 0x0001705A
		[global::Cpp2ILInjected.Token(Token = "0x6001C3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B27440", Offset = "0x1B27440", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterWellKnownServiceType", MemberParameters = new object[] { typeof(WellKnownServiceTypeEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "get_DefaultContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingleCallIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Runtime.Remoting.Contexts.Context),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Runtime.Remoting.Contexts.Context),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "RegisterServerIdentity", MemberParameters = new object[] { typeof(ServerIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static ServerIdentity CreateWellKnownServerIdentity(global::System.Type objectType, string objectUri, WellKnownObjectMode mode)
		{
			throw null;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00018E5D File Offset: 0x0001705D
		[global::Cpp2ILInjected.Token(Token = "0x6001C3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2E6B4", Offset = "0x1B2E6B4", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateClientActivatedServerIdentity", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(ClientActivatedIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateWellKnownServerIdentity", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(WellKnownObjectMode)
		}, ReturnType = typeof(ServerIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void RegisterServerIdentity(ServerIdentity identity)
		{
			throw null;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00018E60 File Offset: 0x00017060
		[global::Cpp2ILInjected.Token(Token = "0x6001C3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2E184", Offset = "0x1B2E184", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.ProxyAttribute), Member = "CreateProxy", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Contexts.Context)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Proxies.RealProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetRemoteObject", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static object GetProxyForRemoteObject(ObjRef objref, global::System.Type classToProxy)
		{
			throw null;
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00018E63 File Offset: 0x00017063
		[global::Cpp2ILInjected.Token(Token = "0x6001C3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2DB54", Offset = "0x1B2DB54", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Connect", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetProxyForRemoteObject", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(ClientIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static object GetRemoteObject(ObjRef objRef, global::System.Type proxyType)
		{
			throw null;
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00018E66 File Offset: 0x00017066
		[global::Cpp2ILInjected.Token(Token = "0x6001C3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3001C", Offset = "0x1B3001C", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetExecutionContextReader", ReturnType = typeof(global::System.Threading.ExecutionContext.Reader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext.Reader), Member = "get_LogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext.Reader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext.Reader), Member = "get_IsNull", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext.Reader), Member = "Clone", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal static byte[] SerializeCallData(object obj)
		{
			throw null;
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00018E69 File Offset: 0x00017069
		[global::Cpp2ILInjected.Token(Token = "0x6001C40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30210", Offset = "0x1B30210", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "Deserialize", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(global::System.Threading.ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "Merge", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static object DeserializeCallData(byte[] array)
		{
			throw null;
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00018E6C File Offset: 0x0001706C
		[global::Cpp2ILInjected.Token(Token = "0x6001C41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30440", Offset = "0x1B30440", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static byte[] SerializeExceptionData(global::System.Exception ex)
		{
			throw null;
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00018E6F File Offset: 0x0001706F
		[global::Cpp2ILInjected.Token(Token = "0x6001C42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2D13C", Offset = "0x1B2D13C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainChannel), Member = "RegisterCrossAppDomainChannel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void RegisterInternalChannels()
		{
			throw null;
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00018E72 File Offset: 0x00017072
		[global::Cpp2ILInjected.Token(Token = "0x6001C43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2FD14", Offset = "0x1B2FD14", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(ClientIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClientActivatedIdentity), Member = "OnLifetimeExpired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetNormalizedUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static void DisposeIdentity(Identity ident)
		{
			throw null;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00018E75 File Offset: 0x00017075
		[global::Cpp2ILInjected.Token(Token = "0x6001C44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B305A4", Offset = "0x1B305A4", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.LeaseSink), Member = "RenewLease", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "Activate", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy),
			typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerObjectTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerObjectTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetNormalizedUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal static Identity GetMessageTargetIdentity(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00018E78 File Offset: 0x00017078
		[global::Cpp2ILInjected.Token(Token = "0x6001C45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B308C8", Offset = "0x1B308C8", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "CheckIncomingMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.AppDomainLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ContextLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static void SetMessageTargetIdentity(global::System.Runtime.Remoting.Messaging.IMessage msg, Identity ident)
		{
			throw null;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00018E7B File Offset: 0x0001707B
		[global::Cpp2ILInjected.Token(Token = "0x6001C46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B309D4", Offset = "0x1B309D4", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "ProcessResponse", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage),
			typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool UpdateOutArgObject(global::System.Reflection.ParameterInfo pi, object local, object remote)
		{
			throw null;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00018E7E File Offset: 0x0001707E
		[global::Cpp2ILInjected.Token(Token = "0x6001C47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2F72C", Offset = "0x1B2F72C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(ClientIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "DisposeIdentity", MemberParameters = new object[] { typeof(Identity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string GetNormalizedUri(string uri)
		{
			throw null;
		}

		// Token: 0x04000B73 RID: 2931
		[global::Cpp2ILInjected.Token(Token = "0x4000E53")]
		private static global::System.Collections.Hashtable uri_hash;

		// Token: 0x04000B74 RID: 2932
		[global::Cpp2ILInjected.Token(Token = "0x4000E54")]
		private static global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _serializationFormatter;

		// Token: 0x04000B75 RID: 2933
		[global::Cpp2ILInjected.Token(Token = "0x4000E55")]
		private static global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _deserializationFormatter;

		// Token: 0x04000B76 RID: 2934
		[global::Cpp2ILInjected.Token(Token = "0x4000E56")]
		private static string app_id;

		// Token: 0x04000B77 RID: 2935
		[global::Cpp2ILInjected.Token(Token = "0x4000E57")]
		private static readonly object app_id_lock;

		// Token: 0x04000B78 RID: 2936
		[global::Cpp2ILInjected.Token(Token = "0x4000E58")]
		private static int next_id;

		// Token: 0x04000B79 RID: 2937
		[global::Cpp2ILInjected.Token(Token = "0x4000E59")]
		private static readonly global::System.Reflection.MethodInfo FieldSetterMethod;

		// Token: 0x04000B7A RID: 2938
		[global::Cpp2ILInjected.Token(Token = "0x4000E5A")]
		private static readonly global::System.Reflection.MethodInfo FieldGetterMethod;

		// Token: 0x020005E9 RID: 1513
		[global::Cpp2ILInjected.Token(Token = "0x200034A")]
		[global::System.Serializable]
		private class CACD
		{
			// Token: 0x060040FA RID: 16634 RVA: 0x0001FD9C File Offset: 0x0001DF9C
			[global::Cpp2ILInjected.Token(Token = "0x6001C48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B30208", Offset = "0x1B30208", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CACD()
			{
				throw null;
			}

			// Token: 0x04001968 RID: 6504
			[global::Cpp2ILInjected.Token(Token = "0x4000E5B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public object d;

			// Token: 0x04001969 RID: 6505
			[global::Cpp2ILInjected.Token(Token = "0x4000E5C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public object c;
		}
	}
}
