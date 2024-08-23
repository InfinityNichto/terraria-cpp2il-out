﻿using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200023C RID: 572
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D9")]
	public class DSASignatureFormatter : AsymmetricSignatureFormatter
	{
		// Token: 0x0600167A RID: 5754 RVA: 0x0001841C File Offset: 0x0001661C
		[global::Cpp2ILInjected.Token(Token = "0x6001894")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD8A8", Offset = "0x1AFD8A8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSASignatureFormatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "MapNameToOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DSASignatureFormatter()
		{
			throw null;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0001841F File Offset: 0x0001661F
		[global::Cpp2ILInjected.Token(Token = "0x6001895")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD928", Offset = "0x1AFD928", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Builder", Member = "Sign", MemberParameters = new object[] { typeof(DSA) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSASignatureFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public DSASignatureFormatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00018422 File Offset: 0x00016622
		[global::Cpp2ILInjected.Token(Token = "0x6001896")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFDA18", Offset = "0x1AFDA18", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetKey(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00018425 File Offset: 0x00016625
		[global::Cpp2ILInjected.Token(Token = "0x6001897")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFDB00", Offset = "0x1AFDB00", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "MapNameToOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetHashAlgorithm(string strName)
		{
			throw null;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00018428 File Offset: 0x00016628
		[global::Cpp2ILInjected.Token(Token = "0x6001898")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFDBC4", Offset = "0x1AFDBC4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			throw null;
		}

		// Token: 0x040009D5 RID: 2517
		[global::Cpp2ILInjected.Token(Token = "0x4000CAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DSA _dsaKey;

		// Token: 0x040009D6 RID: 2518
		[global::Cpp2ILInjected.Token(Token = "0x4000CB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _oid;
	}
}
