﻿using System;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200049C RID: 1180
	[global::Cpp2ILInjected.Token(Token = "0x2000572")]
	internal class CStreamWriter : StreamWriter
	{
		// Token: 0x060026E2 RID: 9954 RVA: 0x0001B149 File Offset: 0x00019349
		[global::Cpp2ILInjected.Token(Token = "0x60029FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD2248", Offset = "0x1BD2248", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public CStreamWriter(Stream stream, global::System.Text.Encoding encoding, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x0001B14C File Offset: 0x0001934C
		[global::Cpp2ILInjected.Token(Token = "0x6002A00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD2370", Offset = "0x1BD2370", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override void Write(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x0001B14F File Offset: 0x0001934F
		[global::Cpp2ILInjected.Token(Token = "0x6002A01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD2678", Offset = "0x1BD2678", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override void Write(char val)
		{
			throw null;
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x0001B152 File Offset: 0x00019352
		[global::Cpp2ILInjected.Token(Token = "0x6002A02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD2874", Offset = "0x1BD2874", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "WriteConsole", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void InternalWriteString(string val)
		{
			throw null;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0001B155 File Offset: 0x00019355
		[global::Cpp2ILInjected.Token(Token = "0x6002A03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD27F0", Offset = "0x1BD27F0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void InternalWriteChar(char val)
		{
			throw null;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x0001B158 File Offset: 0x00019358
		[global::Cpp2ILInjected.Token(Token = "0x6002A04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD28F8", Offset = "0x1BD28F8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "QueueEcho", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Echo", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "EchoFlush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void InternalWriteChars(char[] buffer, int n)
		{
			throw null;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x0001B15B File Offset: 0x0001935B
		[global::Cpp2ILInjected.Token(Token = "0x6002A05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD2984", Offset = "0x1BD2984", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(char[] val)
		{
			throw null;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0001B15E File Offset: 0x0001935E
		[global::Cpp2ILInjected.Token(Token = "0x6002A06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD299C", Offset = "0x1BD299C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Write(string val)
		{
			throw null;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0001B161 File Offset: 0x00019361
		[global::Cpp2ILInjected.Token(Token = "0x6002A07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD2A60", Offset = "0x1BD2A60", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteLine(string val)
		{
			throw null;
		}

		// Token: 0x0400133B RID: 4923
		[global::Cpp2ILInjected.Token(Token = "0x400168A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.TermInfoDriver driver;
	}
}
