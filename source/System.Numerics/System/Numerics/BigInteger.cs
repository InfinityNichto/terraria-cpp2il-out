﻿using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Numerics
{
	// Token: 0x02000002 RID: 2
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	[Serializable]
	public readonly struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D54C58", Offset = "0x1D54C58", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BigInteger(int value)
		{
			throw null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D54CD4", Offset = "0x1D54CD4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public BigInteger(long value)
		{
			throw null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002056 File Offset: 0x00000256
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D54DC0", Offset = "0x1D54DC0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadInteger", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public BigInteger(byte[] value)
		{
			throw null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D54E5C", Offset = "0x1D54E5C", Length = "0x470")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumericsHelpers), Member = "DangerousMakeTwosComplement", MemberParameters = new object[] { typeof(uint[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false, bool isBigEndian = false)
		{
			throw null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000205C File Offset: 0x0000025C
		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5534C", Offset = "0x1D5534C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal BigInteger(int n, uint[] rgu)
		{
			throw null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		[global::Cpp2ILInjected.Token(Token = "0x6000006")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55358", Offset = "0x1D55358", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal BigInteger(uint[] value, bool negative)
		{
			throw null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public static BigInteger MinusOne
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000007")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D554DC", Offset = "0x1D554DC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002065 File Offset: 0x00000265
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55534", Offset = "0x1D55534", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55574", Offset = "0x1D55574", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000206B File Offset: 0x0000026B
		[global::Cpp2ILInjected.Token(Token = "0x600000A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D555EC", Offset = "0x1D555EC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(BigInteger other)
		{
			throw null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206E File Offset: 0x0000026E
		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D556FC", Offset = "0x1D556FC", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int CompareTo(BigInteger other)
		{
			throw null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002071 File Offset: 0x00000271
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55810", Offset = "0x1D55810", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public int CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002074 File Offset: 0x00000274
		[global::Cpp2ILInjected.Token(Token = "0x600000D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D558E4", Offset = "0x1D558E4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "TryGetBytes", MemberParameters = new object[]
		{
			typeof(BigInteger.GetBytesMode),
			typeof(Span<byte>),
			typeof(bool),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(byte[]))]
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			throw null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002077 File Offset: 0x00000277
		[global::Cpp2ILInjected.Token(Token = "0x600000E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55D70", Offset = "0x1D55D70", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "TryGetBytes", MemberParameters = new object[]
		{
			typeof(BigInteger.GetBytesMode),
			typeof(Span<byte>),
			typeof(bool),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(byte[]))]
		internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			throw null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000207A File Offset: 0x0000027A
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55924", Offset = "0x1D55924", Length = "0x44C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "TryWriteBytes", MemberParameters = new object[]
		{
			typeof(Span<byte>),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "TryWriteOrCountBytes", MemberParameters = new object[]
		{
			typeof(Span<byte>),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(char),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten)
		{
			throw null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55DA4", Offset = "0x1D55DA4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002080 File Offset: 0x00000280
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55E80", Offset = "0x1D55E80", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(string),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(string))]
		public string ToString(string format, IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002083 File Offset: 0x00000283
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55EB8", Offset = "0x1D55EB8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(uint)
		}, ReturnType = typeof(uint[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(uint[])
		}, ReturnType = typeof(uint[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
		{
			throw null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002086 File Offset: 0x00000286
		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D561C8", Offset = "0x1D561C8", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(uint)
		}, ReturnType = typeof(uint[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(uint[])
		}, ReturnType = typeof(uint[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
		{
			throw null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002089 File Offset: 0x00000289
		[global::Cpp2ILInjected.Token(Token = "0x6000014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56568", Offset = "0x1D56568", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public static implicit operator BigInteger(byte value)
		{
			throw null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000208C File Offset: 0x0000028C
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56590", Offset = "0x1D56590", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public static implicit operator BigInteger(int value)
		{
			throw null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000208F File Offset: 0x0000028F
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56004", Offset = "0x1D56004", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		public static implicit operator BigInteger(long value)
		{
			throw null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002092 File Offset: 0x00000292
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D565B8", Offset = "0x1D565B8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadInteger", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static explicit operator int(BigInteger value)
		{
			throw null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002095 File Offset: 0x00000295
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56688", Offset = "0x1D56688", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GetPartsForBitManipulation", MemberParameters = new object[]
		{
			typeof(ref BigInteger),
			typeof(ref uint[]),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static BigInteger operator <<(BigInteger value, int shift)
		{
			throw null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002098 File Offset: 0x00000298
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5685C", Offset = "0x1D5685C", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GetPartsForBitManipulation", MemberParameters = new object[]
		{
			typeof(ref BigInteger),
			typeof(ref uint[]),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumericsHelpers), Member = "DangerousMakeTwosComplement", MemberParameters = new object[] { typeof(uint[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static BigInteger operator >>(BigInteger value, int shift)
		{
			throw null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000209B File Offset: 0x0000029B
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56B94", Offset = "0x1D56B94", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static BigInteger operator +(BigInteger left, BigInteger right)
		{
			throw null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000209E File Offset: 0x0000029E
		[global::Cpp2ILInjected.Token(Token = "0x600001B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56AF0", Offset = "0x1D56AF0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl)
		{
			throw null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020A1 File Offset: 0x000002A1
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D556C8", Offset = "0x1D556C8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu)
		{
			throw null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020A4 File Offset: 0x000002A4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56C40", Offset = "0x1D56C40", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static BigInteger()
		{
			throw null;
		}

		// Token: 0x04000001 RID: 1
		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly int _sign;

		// Token: 0x04000002 RID: 2
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal readonly uint[] _bits;

		// Token: 0x04000003 RID: 3
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		private static readonly BigInteger s_bnMinInt;

		// Token: 0x04000004 RID: 4
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		private static readonly BigInteger s_bnOneInt;

		// Token: 0x04000005 RID: 5
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		private static readonly BigInteger s_bnZeroInt;

		// Token: 0x04000006 RID: 6
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		private static readonly BigInteger s_bnMinusOneInt;

		// Token: 0x04000007 RID: 7
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		private static readonly byte[] s_success;

		// Token: 0x02000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x2000003")]
		private enum GetBytesMode
		{
			// Token: 0x04000022 RID: 34
			[global::Cpp2ILInjected.Token(Token = "0x4000009")]
			AllocateArray,
			// Token: 0x04000023 RID: 35
			[global::Cpp2ILInjected.Token(Token = "0x400000A")]
			Count,
			// Token: 0x04000024 RID: 36
			[global::Cpp2ILInjected.Token(Token = "0x400000B")]
			Span
		}
	}
}
