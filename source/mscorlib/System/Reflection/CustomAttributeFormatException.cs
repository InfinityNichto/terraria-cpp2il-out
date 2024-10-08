﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004CD")]
	[global::System.Serializable]
	public class CustomAttributeFormatException : global::System.FormatException
	{
		[global::Cpp2ILInjected.Token(Token = "0x600237A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B809C0", Offset = "0x1B809C0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CustomAttributeFormatException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600237B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80A20", Offset = "0x1B80A20", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public CustomAttributeFormatException(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600237C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80A48", Offset = "0x1B80A48", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public CustomAttributeFormatException(string message, global::System.Exception inner)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600237D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80A6C", Offset = "0x1B80A6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected CustomAttributeFormatException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
