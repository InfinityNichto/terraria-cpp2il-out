﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Utilities
{
	// Token: 0x02000372 RID: 882
	[global::Cpp2ILInjected.Token(Token = "0x20004F6")]
	public static class CrashWatcher
	{
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x0002A008 File Offset: 0x00028208
		// (set) Token: 0x06002CA2 RID: 11426 RVA: 0x0002A00B File Offset: 0x0002820B
		[global::Cpp2ILInjected.Token(Token = "0x1700060F")]
		public static bool LogAllExceptions
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF89C", Offset = "0x12FF89C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF8E4", Offset = "0x12FF8E4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x0002A00E File Offset: 0x0002820E
		// (set) Token: 0x06002CA4 RID: 11428 RVA: 0x0002A011 File Offset: 0x00028211
		[global::Cpp2ILInjected.Token(Token = "0x17000610")]
		public static bool DumpOnException
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF930", Offset = "0x12FF930", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF978", Offset = "0x12FF978", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x0002A014 File Offset: 0x00028214
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x0002A017 File Offset: 0x00028217
		[global::Cpp2ILInjected.Token(Token = "0x17000611")]
		public static bool DumpOnCrash
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF9C4", Offset = "0x12FF9C4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FFA0C", Offset = "0x12FFA0C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x0002A01A File Offset: 0x0002821A
		// (set) Token: 0x06002CA8 RID: 11432 RVA: 0x0002A01D File Offset: 0x0002821D
		[global::Cpp2ILInjected.Token(Token = "0x17000612")]
		public static CrashDump.Options CrashDumpOptions
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FFA58", Offset = "0x12FFA58", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FFAA0", Offset = "0x12FFAA0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x0002A020 File Offset: 0x00028220
		[global::Cpp2ILInjected.Token(Token = "0x17000613")]
		private static string DumpPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FFAEC", Offset = "0x12FFAEC", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrashWatcher.<>c), Member = "<Inititialize>b__18_0", MemberParameters = new object[]
			{
				typeof(object),
				typeof(FirstChanceExceptionEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrashWatcher.<>c), Member = "<Inititialize>b__18_1", MemberParameters = new object[]
			{
				typeof(object),
				typeof(UnhandledExceptionEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x0002A023 File Offset: 0x00028223
		[global::Cpp2ILInjected.Token(Token = "0x60030B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FFB8C", Offset = "0x12FFB8C", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "SetupLogging", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandler<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "add_FirstChanceException", MemberParameters = new object[] { typeof(EventHandler<FirstChanceExceptionEventArgs>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnhandledExceptionEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "add_UnhandledException", MemberParameters = new object[] { typeof(UnhandledExceptionEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void Inititialize()
		{
			throw null;
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x0002A026 File Offset: 0x00028226
		[global::Cpp2ILInjected.Token(Token = "0x60030B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FFD68", Offset = "0x12FFD68", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrashWatcher.<>c), Member = "<Inititialize>b__18_0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FirstChanceExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrashWatcher.<>c), Member = "<Inititialize>b__18_1", MemberParameters = new object[]
		{
			typeof(object),
			typeof(UnhandledExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrashWatcher), Member = "PrintException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrashWatcher), Member = "PrintException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static string PrintException(Exception ex)
		{
			throw null;
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x0002A029 File Offset: 0x00028229
		[global::Cpp2ILInjected.Token(Token = "0x60030BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FFFD4", Offset = "0x12FFFD4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "SetupLogging", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void EnableCrashDumps(CrashDump.Options options)
		{
			throw null;
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x0002A02C File Offset: 0x0002822C
		[global::Cpp2ILInjected.Token(Token = "0x60030BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300050", Offset = "0x1300050", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void DisableCrashDumps()
		{
			throw null;
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0002A02F File Offset: 0x0002822F
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x60030BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300090", Offset = "0x1300090", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void HookDebugExceptionDialog()
		{
			throw null;
		}

		// Token: 0x04003184 RID: 12676
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003AC1")]
		private static bool <LogAllExceptions>k__BackingField;

		// Token: 0x04003185 RID: 12677
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003AC2")]
		private static bool <DumpOnException>k__BackingField;

		// Token: 0x04003186 RID: 12678
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003AC3")]
		private static bool <DumpOnCrash>k__BackingField;

		// Token: 0x04003187 RID: 12679
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003AC4")]
		private static CrashDump.Options <CrashDumpOptions>k__BackingField;

		// Token: 0x020008D6 RID: 2262
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20004F7")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004BBD RID: 19389 RVA: 0x0002F6CC File Offset: 0x0002D8CC
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60030BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1300094", Offset = "0x1300094", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004BBE RID: 19390 RVA: 0x0002F6CF File Offset: 0x0002D8CF
			[global::Cpp2ILInjected.Token(Token = "0x60030BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x13000F0", Offset = "0x13000F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004BBF RID: 19391 RVA: 0x0002F6D2 File Offset: 0x0002D8D2
			[global::Cpp2ILInjected.Token(Token = "0x60030BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x13000F8", Offset = "0x13000F8", Length = "0x2D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrashWatcher), Member = "PrintException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_Name", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrashWatcher), Member = "get_DumpPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			internal void <Inititialize>b__18_0(object sender, FirstChanceExceptionEventArgs exceptionArgs)
			{
				throw null;
			}

			// Token: 0x06004BC0 RID: 19392 RVA: 0x0002F6D5 File Offset: 0x0002D8D5
			[global::Cpp2ILInjected.Token(Token = "0x60030C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x13003C8", Offset = "0x13003C8", Length = "0x2F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrashWatcher), Member = "PrintException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_Name", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrashWatcher), Member = "get_DumpPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			internal void <Inititialize>b__18_1(object sender, UnhandledExceptionEventArgs exceptionArgs)
			{
				throw null;
			}

			// Token: 0x040080E4 RID: 32996
			[global::Cpp2ILInjected.Token(Token = "0x4003AC5")]
			public static readonly CrashWatcher.<>c <>9;

			// Token: 0x040080E5 RID: 32997
			[global::Cpp2ILInjected.Token(Token = "0x4003AC6")]
			public static EventHandler<FirstChanceExceptionEventArgs> <>9__18_0;

			// Token: 0x040080E6 RID: 32998
			[global::Cpp2ILInjected.Token(Token = "0x4003AC7")]
			public static UnhandledExceptionEventHandler <>9__18_1;
		}
	}
}