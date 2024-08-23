﻿using System;
using System.IO;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000E5 RID: 229
	[global::Cpp2ILInjected.Token(Token = "0x2000117")]
	[global::System.Serializable]
	public class UnauthorizedAccessException : global::System.SystemException
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x00016313 File Offset: 0x00014513
		[global::Cpp2ILInjected.Token(Token = "0x6000B01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52FA4", Offset = "0x1C52FA4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public UnauthorizedAccessException()
		{
			throw null;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00016316 File Offset: 0x00014516
		[global::Cpp2ILInjected.Token(Token = "0x6000B02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52FFC", Offset = "0x1C52FFC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "GetBuffer", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.__Error), Member = "WinIOError", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.FileMode),
			typeof(global::System.IO.FileAccess),
			typeof(global::System.IO.FileShare),
			typeof(int),
			typeof(bool),
			typeof(global::System.IO.FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "GetException", MemberParameters = new object[] { typeof(global::System.IO.MonoIOError) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "GetException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.MonoIOError)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public UnauthorizedAccessException(string message)
		{
			throw null;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00016319 File Offset: 0x00014519
		[global::Cpp2ILInjected.Token(Token = "0x6000B03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5301C", Offset = "0x1C5301C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
		{
			typeof(global::Interop.ErrorInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public UnauthorizedAccessException(string message, global::System.Exception inner)
		{
			throw null;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0001631C File Offset: 0x0001451C
		[global::Cpp2ILInjected.Token(Token = "0x6000B04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5303C", Offset = "0x1C5303C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected UnauthorizedAccessException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
