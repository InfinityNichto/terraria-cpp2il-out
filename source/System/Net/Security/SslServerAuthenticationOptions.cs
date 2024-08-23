﻿using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;

namespace System.Net.Security
{
	// Token: 0x0200022A RID: 554
	[global::Cpp2ILInjected.Token(Token = "0x200031A")]
	public class SslServerAuthenticationOptions
	{
		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x000062ED File Offset: 0x000044ED
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x000062F0 File Offset: 0x000044F0
		[global::Cpp2ILInjected.Token(Token = "0x170004B1")]
		public bool ClientCertificateRequired
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37BA0", Offset = "0x1E37BA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37BA8", Offset = "0x1E37BA8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x000062F3 File Offset: 0x000044F3
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x000062F6 File Offset: 0x000044F6
		[global::Cpp2ILInjected.Token(Token = "0x170004B2")]
		public X509Certificate ServerCertificate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37BB4", Offset = "0x1E37BB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37BBC", Offset = "0x1E37BBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x000062F9 File Offset: 0x000044F9
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x000062FC File Offset: 0x000044FC
		[global::Cpp2ILInjected.Token(Token = "0x170004B3")]
		public SslProtocols EnabledSslProtocols
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37BC4", Offset = "0x1E37BC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37BCC", Offset = "0x1E37BCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x000062FF File Offset: 0x000044FF
		[global::Cpp2ILInjected.Token(Token = "0x170004B4")]
		public X509RevocationMode CertificateRevocationCheckMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37BD4", Offset = "0x1E37BD4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoSslServerAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new object[] { typeof(X509RevocationMode) }, ReturnType = typeof(void))]
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

		// Token: 0x1700048C RID: 1164
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x00006302 File Offset: 0x00004502
		[global::Cpp2ILInjected.Token(Token = "0x170004B5")]
		public EncryptionPolicy EncryptionPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37C70", Offset = "0x1E37C70", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoSslServerAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new object[] { typeof(EncryptionPolicy) }, ReturnType = typeof(void))]
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

		// Token: 0x06001273 RID: 4723 RVA: 0x00006305 File Offset: 0x00004505
		[global::Cpp2ILInjected.Token(Token = "0x60014AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E37D0C", Offset = "0x1E37D0C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoSslServerAuthenticationOptions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SslServerAuthenticationOptions()
		{
			throw null;
		}

		// Token: 0x04000D44 RID: 3396
		[global::Cpp2ILInjected.Token(Token = "0x400113F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private X509RevocationMode _checkCertificateRevocation;

		// Token: 0x04000D45 RID: 3397
		[global::Cpp2ILInjected.Token(Token = "0x4001140")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private SslProtocols _enabledSslProtocols;

		// Token: 0x04000D46 RID: 3398
		[global::Cpp2ILInjected.Token(Token = "0x4001141")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EncryptionPolicy _encryptionPolicy;

		// Token: 0x04000D47 RID: 3399
		[global::Cpp2ILInjected.Token(Token = "0x4001142")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _allowRenegotiation;

		// Token: 0x04000D48 RID: 3400
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001143")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
		private bool <ClientCertificateRequired>k__BackingField;

		// Token: 0x04000D49 RID: 3401
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001144")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private X509Certificate <ServerCertificate>k__BackingField;
	}
}