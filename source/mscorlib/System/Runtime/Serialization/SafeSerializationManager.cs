﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x0200033E RID: 830
	[global::Cpp2ILInjected.Token(Token = "0x20003E6")]
	[global::System.Serializable]
	internal sealed class SafeSerializationManager : IObjectReference, ISerializable
	{
		// Token: 0x06001D46 RID: 7494 RVA: 0x000196D9 File Offset: 0x000178D9
		[global::Cpp2ILInjected.Token(Token = "0x6001F84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58AF0", Offset = "0x1B58AF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "OnDeserialized", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SafeSerializationManager()
		{
			throw null;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x000196DC File Offset: 0x000178DC
		[global::Cpp2ILInjected.Token(Token = "0x6001F85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58AF8", Offset = "0x1B58AF8", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private SafeSerializationManager(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x000196DF File Offset: 0x000178DF
		[global::Cpp2ILInjected.Token(Token = "0x17000433")]
		internal bool IsActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B58FF4", Offset = "0x1B58FF4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x000196E2 File Offset: 0x000178E2
		[global::Cpp2ILInjected.Token(Token = "0x6001F87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59004", Offset = "0x1B59004", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSerializationEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "SetType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x000196E5 File Offset: 0x000178E5
		[global::Cpp2ILInjected.Token(Token = "0x6001F88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59318", Offset = "0x1B59318", Length = "0x394")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "OnDeserialized", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal void CompleteDeserialization(object deserializedObject)
		{
			throw null;
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x000196E8 File Offset: 0x000178E8
		[global::Cpp2ILInjected.Token(Token = "0x6001F89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B596AC", Offset = "0x1B596AC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000196EB File Offset: 0x000178EB
		[global::Cpp2ILInjected.Token(Token = "0x6001F8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59754", Offset = "0x1B59754", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Stack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetSerializationCtor", ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ConstructorInfo),
			typeof(global::System.Reflection.ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "SerializationInvoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x000196EE File Offset: 0x000178EE
		[OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6001F8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59A00", Offset = "0x1B59A00", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(SerializationEvents))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "InvokeOnDeserialized", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnDeserialized(StreamingContext context)
		{
			throw null;
		}

		// Token: 0x04000CD0 RID: 3280
		[global::Cpp2ILInjected.Token(Token = "0x4000FC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.Generic.IList<object> m_serializedStates;

		// Token: 0x04000CD1 RID: 3281
		[global::Cpp2ILInjected.Token(Token = "0x4000FC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SerializationInfo m_savedSerializationInfo;

		// Token: 0x04000CD2 RID: 3282
		[global::Cpp2ILInjected.Token(Token = "0x4000FC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object m_realObject;

		// Token: 0x04000CD3 RID: 3283
		[global::Cpp2ILInjected.Token(Token = "0x4000FC5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.RuntimeType m_realType;

		// Token: 0x04000CD4 RID: 3284
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000FC6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.EventHandler<SafeSerializationEventArgs> SerializeObjectState;

		// Token: 0x04000CD5 RID: 3285
		[global::Cpp2ILInjected.Token(Token = "0x4000FC7")]
		private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";
	}
}
