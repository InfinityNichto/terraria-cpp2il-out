﻿using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000240 RID: 576
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002DD")]
	public class HMACSHA1 : HMAC
	{
		// Token: 0x06001693 RID: 5779 RVA: 0x00018467 File Offset: 0x00016667
		[global::Cpp2ILInjected.Token(Token = "0x60018AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE02C", Offset = "0x1AFE02C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMAC), Member = "Create", ReturnType = typeof(HMAC))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyedHashAlgorithm), Member = "Create", ReturnType = typeof(KeyedHashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMACSHA1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HMACSHA1()
		{
			throw null;
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0001846A File Offset: 0x0001666A
		[global::Cpp2ILInjected.Token(Token = "0x60018AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE950", Offset = "0x1AFE950", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public HMACSHA1(byte[] key)
		{
			throw null;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0001846D File Offset: 0x0001666D
		[global::Cpp2ILInjected.Token(Token = "0x60018AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE958", Offset = "0x1AFE958", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public HMACSHA1(byte[] key, bool useManagedSha1)
		{
			throw null;
		}
	}
}
