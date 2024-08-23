﻿using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002F8 RID: 760
	[global::Cpp2ILInjected.Token(Token = "0x200039D")]
	[global::System.Serializable]
	internal class CADMethodRef
	{
		// Token: 0x06001B8D RID: 7053 RVA: 0x00019226 File Offset: 0x00017426
		[global::Cpp2ILInjected.Token(Token = "0x6001DBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44D20", Offset = "0x1B44D20", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private global::System.Type[] GetTypes(string[] typeArray)
		{
			throw null;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00019229 File Offset: 0x00017429
		[global::Cpp2ILInjected.Token(Token = "0x6001DC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44E44", Offset = "0x1B44E44", Length = "0x434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMessageBase), Member = "GetMethod", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMethodRef), Member = "GetTypes", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethods", ReturnType = typeof(global::System.Reflection.MethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public global::System.Reflection.MethodBase Resolve()
		{
			throw null;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0001922C File Offset: 0x0001742C
		[global::Cpp2ILInjected.Token(Token = "0x6001DC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B45278", Offset = "0x1B45278", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMessageBase), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsConstructor", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public CADMethodRef(IMethodMessage msg)
		{
			throw null;
		}

		// Token: 0x04000C1C RID: 3100
		[global::Cpp2ILInjected.Token(Token = "0x4000F08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool ctor;

		// Token: 0x04000C1D RID: 3101
		[global::Cpp2ILInjected.Token(Token = "0x4000F09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string typeName;

		// Token: 0x04000C1E RID: 3102
		[global::Cpp2ILInjected.Token(Token = "0x4000F0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string methodName;

		// Token: 0x04000C1F RID: 3103
		[global::Cpp2ILInjected.Token(Token = "0x4000F0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string[] param_names;

		// Token: 0x04000C20 RID: 3104
		[global::Cpp2ILInjected.Token(Token = "0x4000F0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string[] generic_arg_names;
	}
}
