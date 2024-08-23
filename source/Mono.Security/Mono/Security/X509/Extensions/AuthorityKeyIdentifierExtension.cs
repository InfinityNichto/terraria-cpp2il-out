﻿using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x02000019 RID: 25
	[global::Cpp2ILInjected.Token(Token = "0x2000034")]
	public class AuthorityKeyIdentifierExtension : X509Extension
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00003306 File Offset: 0x00001506
		[global::Cpp2ILInjected.Token(Token = "0x6000198")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A96734", Offset = "0x1A96734", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		public AuthorityKeyIdentifierExtension(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00003309 File Offset: 0x00001509
		[global::Cpp2ILInjected.Token(Token = "0x6000199")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A96738", Offset = "0x1A96738", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void Decode()
		{
			throw null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000330C File Offset: 0x0000150C
		[global::Cpp2ILInjected.Token(Token = "0x600019A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A96850", Offset = "0x1A96850", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void Encode()
		{
			throw null;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000330F File Offset: 0x0000150F
		[global::Cpp2ILInjected.Token(Token = "0x17000078")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96954", Offset = "0x1A96954", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00003312 File Offset: 0x00001512
		[global::Cpp2ILInjected.Token(Token = "0x17000079")]
		public byte[] Identifier
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96994", Offset = "0x1A96994", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00003315 File Offset: 0x00001515
		[global::Cpp2ILInjected.Token(Token = "0x600019D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A96A08", Offset = "0x1A96A08", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000090 RID: 144
		[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] aki;
	}
}
