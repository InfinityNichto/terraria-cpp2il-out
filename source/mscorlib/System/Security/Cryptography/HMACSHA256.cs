﻿using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000241 RID: 577
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002DE")]
	public class HMACSHA256 : HMAC
	{
		// Token: 0x06001696 RID: 5782 RVA: 0x00018470 File Offset: 0x00016670
		[global::Cpp2ILInjected.Token(Token = "0x60018B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFEA14", Offset = "0x1AFEA14", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HMACSHA256()
		{
			throw null;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00018473 File Offset: 0x00016673
		[global::Cpp2ILInjected.Token(Token = "0x60018B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFEA78", Offset = "0x1AFEA78", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public HMACSHA256(byte[] key)
		{
			throw null;
		}
	}
}
