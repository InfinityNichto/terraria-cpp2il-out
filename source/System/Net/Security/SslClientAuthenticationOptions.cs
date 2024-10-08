﻿using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;

namespace System.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000319")]
	public class SslClientAuthenticationOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x170004AC")]
		public string TargetHost
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600149E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37A28", Offset = "0x1E37A28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600149F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37A30", Offset = "0x1E37A30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004AD")]
		public X509CertificateCollection ClientCertificates
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37A38", Offset = "0x1E37A38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37A40", Offset = "0x1E37A40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004AE")]
		public X509RevocationMode CertificateRevocationCheckMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37A48", Offset = "0x1E37A48", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new object[] { typeof(X509RevocationMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004AF")]
		public EncryptionPolicy EncryptionPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37AE4", Offset = "0x1E37AE4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new object[] { typeof(EncryptionPolicy) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004B0")]
		public SslProtocols EnabledSslProtocols
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37B80", Offset = "0x1E37B80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37B88", Offset = "0x1E37B88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E37B90", Offset = "0x1E37B90", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SslClientAuthenticationOptions()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private EncryptionPolicy _encryptionPolicy;

		[global::Cpp2ILInjected.Token(Token = "0x400113A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private X509RevocationMode _checkCertificateRevocation;

		[global::Cpp2ILInjected.Token(Token = "0x400113B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SslProtocols _enabledSslProtocols;

		[global::Cpp2ILInjected.Token(Token = "0x400113C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _allowRenegotiation;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400113D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string <TargetHost>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400113E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private X509CertificateCollection <ClientCertificates>k__BackingField;
	}
}
