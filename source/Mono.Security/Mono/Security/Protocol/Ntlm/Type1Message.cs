﻿using System;
using System.Globalization;
using System.Net;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000024 RID: 36
	[global::Cpp2ILInjected.Token(Token = "0x200003F")]
	public class Type1Message : MessageBase
	{
		// Token: 0x0600017C RID: 380 RVA: 0x000033B1 File Offset: 0x000015B1
		[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9A004", Offset = "0x1A9A004", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_UserDomainName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_MachineName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Type1Message()
		{
			throw null;
		}

		// Token: 0x1700006B RID: 107
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000033B4 File Offset: 0x000015B4
		[global::Cpp2ILInjected.Token(Token = "0x17000086")]
		public string Domain
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9A088", Offset = "0x1A9A088", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (set) Token: 0x0600017E RID: 382 RVA: 0x000033B7 File Offset: 0x000015B7
		[global::Cpp2ILInjected.Token(Token = "0x17000087")]
		public string Host
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9A108", Offset = "0x1A9A108", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000033BA File Offset: 0x000015BA
		[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9A188", Offset = "0x1A9A188", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageBase), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		protected override void Decode(byte[] message)
		{
			throw null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000033BD File Offset: 0x000015BD
		[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9A250", Offset = "0x1A9A250", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageBase), Member = "PrepareMessage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override byte[] GetBytes()
		{
			throw null;
		}

		// Token: 0x040000BC RID: 188
		[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _host;

		// Token: 0x040000BD RID: 189
		[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _domain;
	}
}