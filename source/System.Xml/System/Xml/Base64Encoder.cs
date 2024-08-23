﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	internal abstract class Base64Encoder
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000302F File Offset: 0x0000122F
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C588", Offset = "0x1D5C588", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlRawWriterBase64Encoder), Member = ".ctor", MemberParameters = new object[] { typeof(XmlRawWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlRawWriter), Member = "WriteBase64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Base64Encoder()
		{
			throw null;
		}

		// Token: 0x06000005 RID: 5
		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		internal abstract void WriteChars(char[] chars, int index, int count);

		// Token: 0x06000006 RID: 6 RVA: 0x00003032 File Offset: 0x00001232
		[global::Cpp2ILInjected.Token(Token = "0x6000006")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C5E4", Offset = "0x1D5C5E4", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlRawWriter), Member = "WriteBase64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal void Encode(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00003035 File Offset: 0x00001235
		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C8F0", Offset = "0x1D5C8F0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlRawWriter), Member = "WriteEndBase64", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Flush()
		{
			throw null;
		}

		// Token: 0x04000006 RID: 6
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] leftOverBytes;

		// Token: 0x04000007 RID: 7
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int leftOverBytesCount;

		// Token: 0x04000008 RID: 8
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private char[] charsLine;
	}
}
