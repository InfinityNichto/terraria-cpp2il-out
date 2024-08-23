﻿using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000084 RID: 132
	[global::Cpp2ILInjected.Token(Token = "0x20000DF")]
	public class DefaultTraceListener : TraceListener
	{
		// Token: 0x06000482 RID: 1154 RVA: 0x00003B18 File Offset: 0x00001D18
		[global::Cpp2ILInjected.Token(Token = "0x6000522")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECBACC", Offset = "0x1ECBACC", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultTraceListener), Member = "GetPrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static DefaultTraceListener()
		{
			throw null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00003B1B File Offset: 0x00001D1B
		[global::Cpp2ILInjected.Token(Token = "0x6000523")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECBC08", Offset = "0x1ECBC08", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultTraceListener), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string GetPrefix(string var, string target)
		{
			throw null;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00003B1E File Offset: 0x00001D1E
		[global::Cpp2ILInjected.Token(Token = "0x6000524")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5D3C", Offset = "0x1EC5D3C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceInternal), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DefaultTraceListener()
		{
			throw null;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00003B21 File Offset: 0x00001D21
		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x170000FD")]
		public string LogFileName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000525")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBC78", Offset = "0x1ECBC78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000486 RID: 1158
		[global::Cpp2ILInjected.Token(Token = "0x6000526")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECBC80", Offset = "0x1ECBC80", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern void WriteWindowsDebugString(char* message);

		// Token: 0x06000487 RID: 1159 RVA: 0x00003B24 File Offset: 0x00001D24
		[global::Cpp2ILInjected.Token(Token = "0x6000527")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECBC84", Offset = "0x1ECBC84", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultTraceListener), Member = "WriteImpl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void WriteDebugString(string message)
		{
			throw null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00003B27 File Offset: 0x00001D27
		[global::Cpp2ILInjected.Token(Token = "0x6000528")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECBD34", Offset = "0x1ECBD34", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultTraceListener), Member = "WritePrefix", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void WriteMonoTrace(string message)
		{
			throw null;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00003B2A File Offset: 0x00001D2A
		[global::Cpp2ILInjected.Token(Token = "0x6000529")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC140", Offset = "0x1ECC140", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultTraceListener), Member = "WriteImpl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultTraceListener), Member = "WriteMonoTrace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void WritePrefix()
		{
			throw null;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00003B2D File Offset: 0x00001D2D
		[global::Cpp2ILInjected.Token(Token = "0x600052A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC1C8", Offset = "0x1ECC1C8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultTraceListener), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultTraceListener), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultTraceListener), Member = "WritePrefix", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debugger), Member = "IsLogging", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debugger), Member = "Log", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultTraceListener), Member = "WriteDebugString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultTraceListener), Member = "WriteLogFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void WriteImpl(string message)
		{
			throw null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00003B30 File Offset: 0x00001D30
		[global::Cpp2ILInjected.Token(Token = "0x600052B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECBED8", Offset = "0x1ECBED8", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultTraceListener), Member = "WriteImpl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileInfo), Member = "AppendText", ReturnType = typeof(StreamWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileInfo), Member = "CreateText", ReturnType = typeof(StreamWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void WriteLogFile(string message, string logFile)
		{
			throw null;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00003B33 File Offset: 0x00001D33
		[global::Cpp2ILInjected.Token(Token = "0x600052C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC284", Offset = "0x1ECC284", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultTraceListener), Member = "WriteImpl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void Write(string message)
		{
			throw null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00003B36 File Offset: 0x00001D36
		[global::Cpp2ILInjected.Token(Token = "0x600052D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC288", Offset = "0x1ECC288", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultTraceListener), Member = "WriteImpl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteLine(string message)
		{
			throw null;
		}

		// Token: 0x040002C3 RID: 707
		[global::Cpp2ILInjected.Token(Token = "0x4000418")]
		private static readonly bool OnWin32;

		// Token: 0x040002C4 RID: 708
		[global::Cpp2ILInjected.Token(Token = "0x4000419")]
		private static readonly string MonoTracePrefix;

		// Token: 0x040002C5 RID: 709
		[global::Cpp2ILInjected.Token(Token = "0x400041A")]
		private static readonly string MonoTraceFile;

		// Token: 0x040002C6 RID: 710
		[global::Cpp2ILInjected.Token(Token = "0x400041B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string logFileName;
	}
}
