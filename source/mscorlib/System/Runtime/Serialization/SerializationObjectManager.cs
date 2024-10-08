﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003D5")]
	public sealed class SerializationObjectManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001EFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51E10", Offset = "0x1B51E10", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalFE),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SerializationObjectManager(StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001EFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51EA4", Offset = "0x1B51EA4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(SerializationEvents))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryAdd", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "InvokeOnSerializing", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationObjectManager), Member = "AddOnSerialized", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void RegisterObject(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001EFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B52038", Offset = "0x1B52038", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RaiseOnSerializedEvent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001EFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51FAC", Offset = "0x1B51FAC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationObjectManager), Member = "RegisterObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(SerializationEvents))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationEventHandler),
			typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>)
		}, ReturnType = typeof(SerializationEventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddOnSerialized(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Collections.Generic.Dictionary<object, object> _objectSeenTable;

		[global::Cpp2ILInjected.Token(Token = "0x4000F89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly StreamingContext _context;

		[global::Cpp2ILInjected.Token(Token = "0x4000F8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SerializationEventHandler _onSerializedHandler;
	}
}
