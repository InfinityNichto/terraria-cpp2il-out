﻿using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000128 RID: 296
	[global::Cpp2ILInjected.Token(Token = "0x200016B")]
	public static class Console
	{
		// Token: 0x06000DB6 RID: 3510 RVA: 0x00016C28 File Offset: 0x00014E28
		[global::Cpp2ILInjected.Token(Token = "0x6000E94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79D9C", Offset = "0x1C79D9C", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console.WindowsConsole), Member = "GetInputCodePage", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console.WindowsConsole), Member = "GetOutputCodePage", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.EncodingHelper), Member = "InternalCodePage", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_Default", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.EncodingHelper), Member = "get_UTF8Unmarked", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		static Console()
		{
			throw null;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00016C2B File Offset: 0x00014E2B
		[global::Cpp2ILInjected.Token(Token = "0x6000E95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A030", Offset = "0x1C7A030", Length = "0x394")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "set_InputEncoding", MemberParameters = new object[] { typeof(global::System.Text.Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "set_OutputEncoding", MemberParameters = new object[] { typeof(global::System.Text.Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "OpenStandardInput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "OpenStandardOutput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.TextWriter), Member = "Synchronized", MemberParameters = new object[] { typeof(global::System.IO.TextWriter) }, ReturnType = typeof(global::System.IO.TextWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "OpenStandardError", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnexceptionalStreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.TextReader), Member = "Synchronized", MemberParameters = new object[] { typeof(global::System.IO.TextReader) }, ReturnType = typeof(global::System.IO.TextReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnexceptionalStreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static void SetupStreams(global::System.Text.Encoding inputEncoding, global::System.Text.Encoding outputEncoding)
		{
			throw null;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00016C2E File Offset: 0x00014E2E
		[global::Cpp2ILInjected.Token(Token = "0x17000151")]
		public static global::System.IO.TextWriter Error
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7A6AC", Offset = "0x1C7A6AC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00016C31 File Offset: 0x00014E31
		[global::Cpp2ILInjected.Token(Token = "0x17000152")]
		public static global::System.IO.TextWriter Out
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7A704", Offset = "0x1C7A704", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00016C34 File Offset: 0x00014E34
		[global::Cpp2ILInjected.Token(Token = "0x6000E98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A75C", Offset = "0x1C7A75C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "OpenStandardError", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "OpenStandardInput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "OpenStandardOutput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IO.FileAccess),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static global::System.IO.Stream Open(global::System.IntPtr handle, global::System.IO.FileAccess access, int bufferSize)
		{
			throw null;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00016C37 File Offset: 0x00014E37
		[global::Cpp2ILInjected.Token(Token = "0x6000E99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A61C", Offset = "0x1C7A61C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MonoIO), Member = "get_ConsoleError", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "Open", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IO.FileAccess),
			typeof(int)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.IO.Stream OpenStandardError(int bufferSize)
		{
			throw null;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00016C3A File Offset: 0x00014E3A
		[global::Cpp2ILInjected.Token(Token = "0x6000E9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A4FC", Offset = "0x1C7A4FC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MonoIO), Member = "get_ConsoleInput", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "Open", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IO.FileAccess),
			typeof(int)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.IO.Stream OpenStandardInput(int bufferSize)
		{
			throw null;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00016C3D File Offset: 0x00014E3D
		[global::Cpp2ILInjected.Token(Token = "0x6000E9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A58C", Offset = "0x1C7A58C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MonoIO), Member = "get_ConsoleOutput", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "Open", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IO.FileAccess),
			typeof(int)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.IO.Stream OpenStandardOutput(int bufferSize)
		{
			throw null;
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00016C40 File Offset: 0x00014E40
		[global::Cpp2ILInjected.Token(Token = "0x6000E9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A8AC", Offset = "0x1C7A8AC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.TextWriter), Member = "Synchronized", MemberParameters = new object[] { typeof(global::System.IO.TextWriter) }, ReturnType = typeof(global::System.IO.TextWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void SetOut(global::System.IO.TextWriter newOut)
		{
			throw null;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00016C43 File Offset: 0x00014E43
		[global::Cpp2ILInjected.Token(Token = "0x6000E9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A98C", Offset = "0x1C7A98C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher.<>c", Member = "<Inititialize>b__18_0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher.<>c", Member = "<Inititialize>b__18_1", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.UnhandledExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Write(string value)
		{
			throw null;
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00016C46 File Offset: 0x00014E46
		[global::Cpp2ILInjected.Token(Token = "0x6000E9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A9F8", Offset = "0x1C7A9F8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "TraceWriteLine", MemberParameters = new object[]
		{
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.BZip2.BZip2OutputStream", Member = "TraceOutput", MemberParameters = new object[]
		{
			"Ionic.BZip2.BZip2OutputStream.TraceBits",
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Write(string format, object arg0)
		{
			throw null;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00016C49 File Offset: 0x00014E49
		[global::Cpp2ILInjected.Token(Token = "0x6000E9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AA74", Offset = "0x1C7AA74", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"System.Boolean[]&",
			"System.Int32[]&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"System.Boolean[]&",
			"System.Int32[]&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"System.Boolean[]&",
			"System.Int32[]&",
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void WriteLine(object value)
		{
			throw null;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00016C4C File Offset: 0x00014E4C
		[global::Cpp2ILInjected.Token(Token = "0x6000EA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AAE0", Offset = "0x1C7AAE0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 62)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void WriteLine(string value)
		{
			throw null;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00016C4F File Offset: 0x00014E4F
		[global::Cpp2ILInjected.Token(Token = "0x6000EA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AB4C", Offset = "0x1C7AB4C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "TraceWriteLine", MemberParameters = new object[]
		{
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.BZip2.BZip2OutputStream", Member = "TraceOutput", MemberParameters = new object[]
		{
			"Ionic.BZip2.BZip2OutputStream.TraceBits",
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void WriteLine(string format, params object[] arg)
		{
			throw null;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00016C52 File Offset: 0x00014E52
		[global::Cpp2ILInjected.Token(Token = "0x6000EA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7ABE8", Offset = "0x1C7ABE8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.FavoritesFile", Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Chat.Commands.SayChatCommand", Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Liquid.LiquidRenderer", Member = "SetWaveMaskData", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.Texture2D&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror", Member = "ToFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void WriteLine(string format, object arg0, object arg1)
		{
			throw null;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00016C55 File Offset: 0x00014E55
		[global::Cpp2ILInjected.Token(Token = "0x6000EA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AC6C", Offset = "0x1C7AC6C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "ReadLineInput", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string ReadLine()
		{
			throw null;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00016C58 File Offset: 0x00014E58
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00016C5B File Offset: 0x00014E5B
		[global::Cpp2ILInjected.Token(Token = "0x17000153")]
		public static global::System.Text.Encoding InputEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7AE3C", Offset = "0x1C7AE3C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000EA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7AE94", Offset = "0x1C7AE94", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "InitializeConsoleOutput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
			{
				typeof(global::System.Text.Encoding),
				typeof(global::System.Text.Encoding)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00016C5E File Offset: 0x00014E5E
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x00016C61 File Offset: 0x00014E61
		[global::Cpp2ILInjected.Token(Token = "0x17000154")]
		public static global::System.Text.Encoding OutputEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7AEF8", Offset = "0x1C7AEF8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000EA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7AF50", Offset = "0x1C7AF50", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "InitializeConsoleOutput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
			{
				typeof(global::System.Text.Encoding),
				typeof(global::System.Text.Encoding)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00016C64 File Offset: 0x00014E64
		[global::Cpp2ILInjected.Token(Token = "0x6000EA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AFB4", Offset = "0x1C7AFB4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Clear()
		{
			throw null;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00016C67 File Offset: 0x00014E67
		[global::Cpp2ILInjected.Token(Token = "0x6000EA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B0C0", Offset = "0x1C7B0C0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamReader), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.ConsoleKeyInfo ReadKey()
		{
			throw null;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00016C6A File Offset: 0x00014E6A
		[global::Cpp2ILInjected.Token(Token = "0x6000EAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B118", Offset = "0x1C7B118", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "ReadKey", ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			throw null;
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00016C6D File Offset: 0x00014E6D
		[global::Cpp2ILInjected.Token(Token = "0x6000EAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B248", Offset = "0x1C7B248", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console.WindowsConsole), Member = "DoWindowsConsoleCancelEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleCancelEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.ConsoleSpecialKey) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static void DoConsoleCancelEvent()
		{
			throw null;
		}

		// Token: 0x04000488 RID: 1160
		[global::Cpp2ILInjected.Token(Token = "0x400064E")]
		internal static global::System.IO.TextWriter stdout;

		// Token: 0x04000489 RID: 1161
		[global::Cpp2ILInjected.Token(Token = "0x400064F")]
		private static global::System.IO.TextWriter stderr;

		// Token: 0x0400048A RID: 1162
		[global::Cpp2ILInjected.Token(Token = "0x4000650")]
		private static global::System.IO.TextReader stdin;

		// Token: 0x0400048B RID: 1163
		[global::Cpp2ILInjected.Token(Token = "0x4000651")]
		private static global::System.Text.Encoding inputEncoding;

		// Token: 0x0400048C RID: 1164
		[global::Cpp2ILInjected.Token(Token = "0x4000652")]
		private static global::System.Text.Encoding outputEncoding;

		// Token: 0x0400048D RID: 1165
		[global::Cpp2ILInjected.Token(Token = "0x4000653")]
		private static global::System.ConsoleCancelEventHandler cancel_event;

		// Token: 0x02000597 RID: 1431
		[global::Cpp2ILInjected.Token(Token = "0x200016C")]
		private class WindowsConsole
		{
			// Token: 0x06003FCD RID: 16333
			[global::Cpp2ILInjected.Token(Token = "0x6000EAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7B418", Offset = "0x1C7B418", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console.WindowsConsole), Member = "GetInputCodePage", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[global::System.Runtime.InteropServices.PreserveSig]
			private static extern int GetConsoleCP();

			// Token: 0x06003FCE RID: 16334
			[global::Cpp2ILInjected.Token(Token = "0x6000EAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7B480", Offset = "0x1C7B480", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console.WindowsConsole), Member = "GetOutputCodePage", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[global::System.Runtime.InteropServices.PreserveSig]
			private static extern int GetConsoleOutputCP();

			// Token: 0x06003FCF RID: 16335 RVA: 0x0001FA27 File Offset: 0x0001DC27
			[global::Cpp2ILInjected.Token(Token = "0x6000EAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7B4EC", Offset = "0x1C7B4EC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "DoConsoleCancelEvent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static bool DoWindowsConsoleCancelEvent(int keyCode)
			{
				throw null;
			}

			// Token: 0x06003FD0 RID: 16336 RVA: 0x0001FA2A File Offset: 0x0001DC2A
			[global::Cpp2ILInjected.Token(Token = "0x6000EAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C79F98", Offset = "0x1C79F98", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console.WindowsConsole), Member = "GetConsoleCP", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(8)]
			public static int GetInputCodePage()
			{
				throw null;
			}

			// Token: 0x06003FD1 RID: 16337 RVA: 0x0001FA2D File Offset: 0x0001DC2D
			[global::Cpp2ILInjected.Token(Token = "0x6000EB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C79FE4", Offset = "0x1C79FE4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console.WindowsConsole), Member = "GetConsoleOutputCP", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(8)]
			public static int GetOutputCodePage()
			{
				throw null;
			}

			// Token: 0x06003FD2 RID: 16338 RVA: 0x0001FA30 File Offset: 0x0001DC30
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000EB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7B54C", Offset = "0x1C7B54C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Console.WindowsConsole.WindowsCancelHandler", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static WindowsConsole()
			{
				throw null;
			}

			// Token: 0x0400186D RID: 6253
			[global::Cpp2ILInjected.Token(Token = "0x4000654")]
			public static bool ctrlHandlerAdded;

			// Token: 0x0400186E RID: 6254
			[global::Cpp2ILInjected.Token(Token = "0x4000655")]
			private static global::System.Console.WindowsConsole.WindowsCancelHandler cancelHandler;

			// Token: 0x020006A8 RID: 1704
			// (Invoke) Token: 0x0600435F RID: 17247
			[global::Cpp2ILInjected.Token(Token = "0x200016D")]
			private delegate bool WindowsCancelHandler(int keyCode);
		}
	}
}
