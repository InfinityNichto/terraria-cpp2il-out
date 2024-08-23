﻿using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000196 RID: 406
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20001FB")]
	[global::System.Serializable]
	public class ThreadInterruptedException : global::System.SystemException
	{
		// Token: 0x060010D7 RID: 4311 RVA: 0x00017483 File Offset: 0x00015683
		[global::Cpp2ILInjected.Token(Token = "0x6001230")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E1DC", Offset = "0x1C9E1DC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetMessageFromNativeResources", MemberParameters = new object[] { typeof(global::System.Exception.ExceptionMessageKind) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ThreadInterruptedException()
		{
			throw null;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00017486 File Offset: 0x00015686
		[global::Cpp2ILInjected.Token(Token = "0x6001231")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E258", Offset = "0x1C9E258", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected ThreadInterruptedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
