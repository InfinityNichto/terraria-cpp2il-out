﻿using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x2000055")]
	public class MD2Managed : MD2
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000244")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D164", Offset = "0x1A9D164", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD2Managed), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] Padding(int nLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000245")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D0C0", Offset = "0x1A9D0C0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD2), Member = "Create", ReturnType = typeof(MD2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public MD2Managed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000246")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D1E8", Offset = "0x1A9D1E8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000247")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D248", Offset = "0x1A9D248", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD2Managed), Member = "MD2Transform", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000248")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D4DC", Offset = "0x1A9D4DC", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD2Managed), Member = "Padding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000249")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D324", Offset = "0x1A9D324", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD2Managed), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600024A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D5C4", Offset = "0x1A9D5C4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static MD2Managed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000254")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] state;

		[global::Cpp2ILInjected.Token(Token = "0x4000255")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] checksum;

		[global::Cpp2ILInjected.Token(Token = "0x4000256")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private byte[] buffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000257")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int count;

		[global::Cpp2ILInjected.Token(Token = "0x4000258")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] x;

		[global::Cpp2ILInjected.Token(Token = "0x4000259")]
		private static readonly byte[] PI_SUBST;
	}
}
