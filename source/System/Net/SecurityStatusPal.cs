﻿using System;
using System.Net.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000CD RID: 205
	[global::Cpp2ILInjected.Token(Token = "0x200012F")]
	internal readonly struct SecurityStatusPal
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x000040CA File Offset: 0x000022CA
		[global::Cpp2ILInjected.Token(Token = "0x600072D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE4470", Offset = "0x1EE4470", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "EstablishSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(ref SafeDeleteContext),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "CompleteAuthToken", MemberParameters = new object[]
		{
			typeof(ref SafeDeleteContext),
			typeof(SecurityBuffer[])
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public SecurityStatusPal(SecurityStatusPalErrorCode errorCode, Exception exception = null)
		{
			throw null;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000040CD File Offset: 0x000022CD
		[global::Cpp2ILInjected.Token(Token = "0x600072E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5260", Offset = "0x1EE5260", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400041F RID: 1055
		[global::Cpp2ILInjected.Token(Token = "0x4000597")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly SecurityStatusPalErrorCode ErrorCode;

		// Token: 0x04000420 RID: 1056
		[global::Cpp2ILInjected.Token(Token = "0x4000598")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly Exception Exception;
	}
}
