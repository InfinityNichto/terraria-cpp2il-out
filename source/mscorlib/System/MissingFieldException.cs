﻿using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000FF RID: 255
	[global::Cpp2ILInjected.Token(Token = "0x2000131")]
	[global::System.Serializable]
	public class MissingFieldException : global::System.MissingMemberException, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000B31 RID: 2865 RVA: 0x00016586 File Offset: 0x00014786
		[global::Cpp2ILInjected.Token(Token = "0x6000BD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56654", Offset = "0x1C56654", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemberAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MissingFieldException()
		{
			throw null;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00016589 File Offset: 0x00014789
		[global::Cpp2ILInjected.Token(Token = "0x6000BDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C566D4", Offset = "0x1C566D4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToField", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.FieldInfo[]),
			typeof(object),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemberAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MissingFieldException(string message)
		{
			throw null;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0001658C File Offset: 0x0001478C
		[global::Cpp2ILInjected.Token(Token = "0x6000BDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C566F8", Offset = "0x1C566F8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMemberException), Member = ".ctor", ReturnType = typeof(void))]
		public MissingFieldException(string className, string fieldName)
		{
			throw null;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0001658F File Offset: 0x0001478F
		[global::Cpp2ILInjected.Token(Token = "0x6000BDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5677C", Offset = "0x1C5677C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected MissingFieldException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00016592 File Offset: 0x00014792
		[global::Cpp2ILInjected.Token(Token = "0x17000106")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C56904", Offset = "0x1C56904", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}
	}
}
