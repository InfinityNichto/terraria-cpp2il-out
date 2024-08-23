﻿using System;
using System.Globalization;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	public abstract class X509Builder
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00003093 File Offset: 0x00001293
		[global::Cpp2ILInjected.Token(Token = "0x600009D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8ABC8", Offset = "0x1A8ABC8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected X509Builder()
		{
			throw null;
		}

		// Token: 0x06000071 RID: 113
		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		protected abstract ASN1 ToBeSigned(string hashName);

		// Token: 0x06000072 RID: 114 RVA: 0x00003096 File Offset: 0x00001296
		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8AC1C", Offset = "0x1A8AC1C", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Builder), Member = "Sign", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		protected string GetOid(string hashName)
		{
			throw null;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003099 File Offset: 0x00001299
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000309C File Offset: 0x0000129C
		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		public string Hash
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8AF34", Offset = "0x1A8AF34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8AF3C", Offset = "0x1A8AF3C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000309F File Offset: 0x0000129F
		[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8AF98", Offset = "0x1A8AF98", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual byte[] Sign(AsymmetricAlgorithm aa)
		{
			throw null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000030A2 File Offset: 0x000012A2
		[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8B0C8", Offset = "0x1A8B0C8", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Builder), Member = "Sign", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Builder), Member = "Sign", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7), Member = "AlgorithmIdentifier", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private byte[] Build(ASN1 tbs, string hashoid, byte[] signature)
		{
			throw null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000030A5 File Offset: 0x000012A5
		[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8B1DC", Offset = "0x1A8B1DC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Builder), Member = "GetOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAPKCS1SignatureFormatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Builder), Member = "Build", MemberParameters = new object[]
		{
			typeof(ASN1),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] Sign(RSA key)
		{
			throw null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000030A8 File Offset: 0x000012A8
		[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8B2DC", Offset = "0x1A8B2DC", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSASignatureFormatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Builder), Member = "Build", MemberParameters = new object[]
		{
			typeof(ASN1),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public virtual byte[] Sign(DSA key)
		{
			throw null;
		}

		// Token: 0x0400003A RID: 58
		[global::Cpp2ILInjected.Token(Token = "0x400005A")]
		private const string defaultHash = "SHA1";

		// Token: 0x0400003B RID: 59
		[global::Cpp2ILInjected.Token(Token = "0x400005B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string hashName;
	}
}
