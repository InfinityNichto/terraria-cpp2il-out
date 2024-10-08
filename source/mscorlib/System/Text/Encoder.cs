﻿using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000269")]
	[global::System.Serializable]
	public abstract class Encoder
	{
		[global::Cpp2ILInjected.Token(Token = "0x60014CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3A10", Offset = "0x1CB3A10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderNLS), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingNLS), Member = "GetEncoder", ReturnType = typeof(Encoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.UTF7Encoding.Encoder", Member = ".ctor", MemberParameters = new object[] { typeof(UTF7Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.UTF8Encoding.UTF8Encoder", Member = ".ctor", MemberParameters = new object[] { typeof(UTF8Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.DefaultEncoder), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.DefaultEncoder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Encoder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000210")]
		public EncoderFallback Fallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB3A18", Offset = "0x1CB3A18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000211")]
		public unsafe EncoderFallbackBuffer FallbackBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB06CC", Offset = "0x1CB06CC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = "GetByteCount", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingByteBuffer), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Encoding),
				typeof(EncoderNLS),
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
			{
				typeof(EncoderNLS),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(EncoderFallback))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000212")]
		internal unsafe bool InternalHasFallbackBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB06BC", Offset = "0x1CB06BC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingByteBuffer), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Encoding),
				typeof(EncoderNLS),
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
			{
				typeof(EncoderNLS),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3A20", Offset = "0x1CB3A20", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014D2")]
		public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60014D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3B04", Offset = "0x1CB3B04", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public unsafe virtual int GetByteCount(char* chars, int count, bool flush)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014D4")]
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60014D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3C48", Offset = "0x1CB3C48", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3E30", Offset = "0x1CB3E30", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60014D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB410C", Offset = "0x1CB410C", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public unsafe virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal EncoderFallback _fallback;

		[global::Cpp2ILInjected.Token(Token = "0x4000AFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal EncoderFallbackBuffer _fallbackBuffer;
	}
}
