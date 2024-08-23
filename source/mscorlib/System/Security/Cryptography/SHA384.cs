﻿using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000260 RID: 608
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002FD")]
	public abstract class SHA384 : HashAlgorithm
	{
		// Token: 0x060017D0 RID: 6096 RVA: 0x00018800 File Offset: 0x00016A00
		[global::Cpp2ILInjected.Token(Token = "0x60019EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0EB48", Offset = "0x1B0EB48", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		protected SHA384()
		{
			throw null;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00018803 File Offset: 0x00016A03
		[global::Cpp2ILInjected.Token(Token = "0x60019EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B73C", Offset = "0x1B0B73C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "InternalHashToHashAlgorithm", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static SHA384 Create()
		{
			throw null;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00018806 File Offset: 0x00016A06
		[global::Cpp2ILInjected.Token(Token = "0x60019EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0EC5C", Offset = "0x1B0EC5C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static SHA384 Create(string hashName)
		{
			throw null;
		}
	}
}