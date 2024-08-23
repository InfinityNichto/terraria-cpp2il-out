﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public sealed class AndroidJavaException : Exception
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00002173 File Offset: 0x00000373
		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57760", Offset = "0x1F57760", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal AndroidJavaException(string message, string javaStackTrace)
		{
			throw null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002176 File Offset: 0x00000376
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public override string StackTrace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000065")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5D444", Offset = "0x1F5D444", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "get_StackTrace", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000001 RID: 1
		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string mJavaStackTrace;
	}
}
