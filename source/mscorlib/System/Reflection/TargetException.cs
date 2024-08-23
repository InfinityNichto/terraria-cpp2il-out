﻿using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000433 RID: 1075
	[global::Cpp2ILInjected.Token(Token = "0x20004F2")]
	[global::System.Serializable]
	public class TargetException : global::System.ApplicationException
	{
		// Token: 0x06002234 RID: 8756 RVA: 0x0001A453 File Offset: 0x00018653
		[global::Cpp2ILInjected.Token(Token = "0x60024CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86870", Offset = "0x1B86870", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public TargetException()
		{
			throw null;
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x0001A456 File Offset: 0x00018656
		[global::Cpp2ILInjected.Token(Token = "0x60024CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8689C", Offset = "0x1B8689C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "CheckConsistency", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public TargetException(string message)
		{
			throw null;
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0001A459 File Offset: 0x00018659
		[global::Cpp2ILInjected.Token(Token = "0x60024D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B868C4", Offset = "0x1B868C4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public TargetException(string message, global::System.Exception inner)
		{
			throw null;
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x0001A45C File Offset: 0x0001865C
		[global::Cpp2ILInjected.Token(Token = "0x60024D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B868E8", Offset = "0x1B868E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected TargetException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
