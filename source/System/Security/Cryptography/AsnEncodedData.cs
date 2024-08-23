﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000098 RID: 152
	[global::Cpp2ILInjected.Token(Token = "0x20000F5")]
	public class AsnEncodedData
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x00003C35 File Offset: 0x00001E35
		[global::Cpp2ILInjected.Token(Token = "0x6000589")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF270", Offset = "0x1ECF270", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(OidCollection),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Extension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(X509KeyUsageFlags),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PublicKey),
			typeof(X509SubjectKeyIdentifierHashAlgorithm),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AsnEncodedData()
		{
			throw null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003C38 File Offset: 0x00001E38
		[global::Cpp2ILInjected.Token(Token = "0x600058A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF278", Offset = "0x1ECF278", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AsnEncodedData(string oid, byte[] rawData)
		{
			throw null;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00003C3B File Offset: 0x00001E3B
		[global::Cpp2ILInjected.Token(Token = "0x600058B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF3E4", Offset = "0x1ECF3E4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_Oid", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		public AsnEncodedData(Oid oid, byte[] rawData)
		{
			throw null;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00003C3E File Offset: 0x00001E3E
		[global::Cpp2ILInjected.Token(Token = "0x600058C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF488", Offset = "0x1ECF488", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PublicKey), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Oid),
			typeof(AsnEncodedData),
			typeof(AsnEncodedData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_Oid", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public AsnEncodedData(AsnEncodedData asnEncodedData)
		{
			throw null;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00003C41 File Offset: 0x00001E41
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00003C44 File Offset: 0x00001E44
		[global::Cpp2ILInjected.Token(Token = "0x17000110")]
		public Oid Oid
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECF55C", Offset = "0x1ECF55C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600058E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECF420", Offset = "0x1ECF420", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Oid),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X500DistinguishedName), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00003C47 File Offset: 0x00001E47
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00003C4A File Offset: 0x00001E4A
		[global::Cpp2ILInjected.Token(Token = "0x17000111")]
		public byte[] RawData
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECF564", Offset = "0x1ECF564", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000590")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECF2F4", Offset = "0x1ECF2F4", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Oid),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X500DistinguishedName), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(OidCollection),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(X509KeyUsageFlags),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(PublicKey),
				typeof(X509SubjectKeyIdentifierHashAlgorithm),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00003C4D File Offset: 0x00001E4D
		[global::Cpp2ILInjected.Token(Token = "0x6000591")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF56C", Offset = "0x1ECF56C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Extension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_Oid", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual void CopyFrom(AsnEncodedData asnEncodedData)
		{
			throw null;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00003C50 File Offset: 0x00001E50
		[global::Cpp2ILInjected.Token(Token = "0x6000592")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF65C", Offset = "0x1ECF65C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual string Format(bool multiLine)
		{
			throw null;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00003C53 File Offset: 0x00001E53
		[global::Cpp2ILInjected.Token(Token = "0x6000593")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF7F8", Offset = "0x1ECF7F8", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "EnhancedKeyUsageExtension", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "KeyUsageExtension", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "SubjectKeyIdentifierExtension", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "SubjectAltName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "NetscapeCertType", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "Default", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal virtual string ToString(bool multiLine)
		{
			throw null;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00003C56 File Offset: 0x00001E56
		[global::Cpp2ILInjected.Token(Token = "0x6000594")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF6EC", Offset = "0x1ECF6EC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal string Default(bool multiLine)
		{
			throw null;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00003C59 File Offset: 0x00001E59
		[global::Cpp2ILInjected.Token(Token = "0x6000595")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF9C0", Offset = "0x1ECF9C0", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509BasicConstraintsExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal string BasicConstraintsExtension(bool multiLine)
		{
			throw null;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00003C5C File Offset: 0x00001E5C
		[global::Cpp2ILInjected.Token(Token = "0x6000596")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECFAC0", Offset = "0x1ECFAC0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal string EnhancedKeyUsageExtension(bool multiLine)
		{
			throw null;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00003C5F File Offset: 0x00001E5F
		[global::Cpp2ILInjected.Token(Token = "0x6000597")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECFBC4", Offset = "0x1ECFBC4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal string KeyUsageExtension(bool multiLine)
		{
			throw null;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00003C62 File Offset: 0x00001E62
		[global::Cpp2ILInjected.Token(Token = "0x6000598")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECFCC8", Offset = "0x1ECFCC8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal string SubjectKeyIdentifierExtension(bool multiLine)
		{
			throw null;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00003C65 File Offset: 0x00001E65
		[global::Cpp2ILInjected.Token(Token = "0x6000599")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECFDCC", Offset = "0x1ECFDCC", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConvert), Member = "ToHex", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal string SubjectAltName(bool multiLine)
		{
			throw null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00003C68 File Offset: 0x00001E68
		[global::Cpp2ILInjected.Token(Token = "0x600059A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED0148", Offset = "0x1ED0148", Length = "0x388")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal string NetscapeCertType(bool multiLine)
		{
			throw null;
		}

		// Token: 0x04000309 RID: 777
		[global::Cpp2ILInjected.Token(Token = "0x4000472")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Oid _oid;

		// Token: 0x0400030A RID: 778
		[global::Cpp2ILInjected.Token(Token = "0x4000473")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal byte[] _raw;
	}
}
