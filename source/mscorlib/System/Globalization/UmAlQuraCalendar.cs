﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004C7 RID: 1223
	[global::Cpp2ILInjected.Token(Token = "0x20005B4")]
	[global::System.Serializable]
	public class UmAlQuraCalendar : Calendar
	{
		// Token: 0x06002910 RID: 10512 RVA: 0x0001B7A6 File Offset: 0x000199A6
		[global::Cpp2ILInjected.Token(Token = "0x6002C6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4800", Offset = "0x1BF4800", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static UmAlQuraCalendar.DateMapping[] InitDateMapping()
		{
			throw null;
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x0001B7A9 File Offset: 0x000199A9
		[global::Cpp2ILInjected.Token(Token = "0x170006A8")]
		public override global::System.DateTime MinSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF4960", Offset = "0x1BF4960", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x0001B7AC File Offset: 0x000199AC
		[global::Cpp2ILInjected.Token(Token = "0x170006A9")]
		public override global::System.DateTime MaxSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF49B8", Offset = "0x1BF49B8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x0001B7AF File Offset: 0x000199AF
		[global::Cpp2ILInjected.Token(Token = "0x6002C71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4A10", Offset = "0x1BF4A10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = ".ctor", ReturnType = typeof(void))]
		public UmAlQuraCalendar()
		{
			throw null;
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x0001B7B2 File Offset: 0x000199B2
		[global::Cpp2ILInjected.Token(Token = "0x170006AA")]
		internal override int BaseCalendarID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF4A18", Offset = "0x1BF4A18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x0001B7B5 File Offset: 0x000199B5
		[global::Cpp2ILInjected.Token(Token = "0x170006AB")]
		internal override int ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C73")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF4A20", Offset = "0x1BF4A20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x0001B7B8 File Offset: 0x000199B8
		[global::Cpp2ILInjected.Token(Token = "0x6002C74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4A28", Offset = "0x1BF4A28", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddDays", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg)
		{
			throw null;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x0001B7BB File Offset: 0x000199BB
		[global::Cpp2ILInjected.Token(Token = "0x6002C75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4B40", Offset = "0x1BF4B40", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetDatePart", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendar), Member = "GetAbsoluteDate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static long GetAbsoluteDateUmAlQura(int year, int month, int day)
		{
			throw null;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x0001B7BE File Offset: 0x000199BE
		[global::Cpp2ILInjected.Token(Token = "0x6002C76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4C08", Offset = "0x1BF4C08", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetDatePart", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetEra", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal static void CheckTicksRange(long ticks)
		{
			throw null;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x0001B7C1 File Offset: 0x000199C1
		[global::Cpp2ILInjected.Token(Token = "0x6002C77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4E10", Offset = "0x1BF4E10", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void CheckEraRange(int era)
		{
			throw null;
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0001B7C4 File Offset: 0x000199C4
		[global::Cpp2ILInjected.Token(Token = "0x6002C78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4E88", Offset = "0x1BF4E88", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "CheckYearMonthRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetDaysInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetMonthsInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "IsLeapYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "CheckEraRange", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static void CheckYearRange(int year, int era)
		{
			throw null;
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x0001B7C7 File Offset: 0x000199C7
		[global::Cpp2ILInjected.Token(Token = "0x6002C79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4FE4", Offset = "0x1BF4FE4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetDaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
			throw null;
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x0001B7CA File Offset: 0x000199CA
		[global::Cpp2ILInjected.Token(Token = "0x6002C7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF50C0", Offset = "0x1BF50C0", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetDatePart", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "CompareTo", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "Subtract", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_TotalDays", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ConvertGregorianToHijri(global::System.DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay)
		{
			throw null;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x0001B7CD File Offset: 0x000199CD
		[global::Cpp2ILInjected.Token(Token = "0x6002C7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF52D0", Offset = "0x1BF52D0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "CheckTicksRange", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal virtual int GetDatePart(global::System.DateTime time, int part)
		{
			throw null;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x0001B7D0 File Offset: 0x000199D0
		[global::Cpp2ILInjected.Token(Token = "0x6002C7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5434", Offset = "0x1BF5434", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetDayOfMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0001B7D3 File Offset: 0x000199D3
		[global::Cpp2ILInjected.Token(Token = "0x6002C7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5448", Offset = "0x1BF5448", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override global::System.DayOfWeek GetDayOfWeek(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x0001B7D6 File Offset: 0x000199D6
		[global::Cpp2ILInjected.Token(Token = "0x6002C7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF54B0", Offset = "0x1BF54B0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "CheckYearMonthRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			throw null;
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x0001B7D9 File Offset: 0x000199D9
		[global::Cpp2ILInjected.Token(Token = "0x6002C7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5550", Offset = "0x1BF5550", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetDaysInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "IsLeapYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int RealGetDaysInYear(int year)
		{
			throw null;
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x0001B7DC File Offset: 0x000199DC
		[global::Cpp2ILInjected.Token(Token = "0x6002C80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF55DC", Offset = "0x1BF55DC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "RealGetDaysInYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetDaysInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x0001B7DF File Offset: 0x000199DF
		[global::Cpp2ILInjected.Token(Token = "0x6002C81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5648", Offset = "0x1BF5648", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "CheckTicksRange", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetEra(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x0001B7E2 File Offset: 0x000199E2
		[global::Cpp2ILInjected.Token(Token = "0x170006AC")]
		public override int[] Eras
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C82")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF56B8", Offset = "0x1BF56B8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x0001B7E5 File Offset: 0x000199E5
		[global::Cpp2ILInjected.Token(Token = "0x6002C83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5708", Offset = "0x1BF5708", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x0001B7E8 File Offset: 0x000199E8
		[global::Cpp2ILInjected.Token(Token = "0x6002C84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF571C", Offset = "0x1BF571C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetMonthsInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0001B7EB File Offset: 0x000199EB
		[global::Cpp2ILInjected.Token(Token = "0x6002C85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5788", Offset = "0x1BF5788", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetYear(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0001B7EE File Offset: 0x000199EE
		[global::Cpp2ILInjected.Token(Token = "0x6002C86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF579C", Offset = "0x1BF579C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "RealGetDaysInYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsLeapYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x0001B7F1 File Offset: 0x000199F1
		[global::Cpp2ILInjected.Token(Token = "0x6002C87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5814", Offset = "0x1BF5814", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "CheckYearMonthRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override global::System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			throw null;
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x0001B7F4 File Offset: 0x000199F4
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x0001B7F7 File Offset: 0x000199F7
		[global::Cpp2ILInjected.Token(Token = "0x170006AD")]
		public override int TwoDigitYearMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF5A5C", Offset = "0x1BF5A5C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "GetSystemTwoDigitYearSetting", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002C89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF5A98", Offset = "0x1BF5A98", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(global::System.IFormatProvider),
				typeof(string),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x0001B7FA File Offset: 0x000199FA
		[global::Cpp2ILInjected.Token(Token = "0x6002C8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5BB4", Offset = "0x1BF5BB4", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "ToFourDigitYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override int ToFourDigitYear(int year)
		{
			throw null;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x0001B7FD File Offset: 0x000199FD
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002C8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5CEC", Offset = "0x1BF5CEC", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UmAlQuraCalendar), Member = "InitDateMapping", ReturnType = typeof(UmAlQuraCalendar.DateMapping[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static UmAlQuraCalendar()
		{
			throw null;
		}

		// Token: 0x040014F0 RID: 5360
		[global::Cpp2ILInjected.Token(Token = "0x40018B4")]
		private static readonly UmAlQuraCalendar.DateMapping[] HijriYearInfo;

		// Token: 0x040014F1 RID: 5361
		[global::Cpp2ILInjected.Token(Token = "0x40018B5")]
		internal static global::System.DateTime minDate;

		// Token: 0x040014F2 RID: 5362
		[global::Cpp2ILInjected.Token(Token = "0x40018B6")]
		internal static global::System.DateTime maxDate;

		// Token: 0x02000637 RID: 1591
		[global::Cpp2ILInjected.Token(Token = "0x20005B5")]
		internal struct DateMapping
		{
			// Token: 0x06004232 RID: 16946 RVA: 0x000200F0 File Offset: 0x0001E2F0
			[global::Cpp2ILInjected.Token(Token = "0x6002C8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF4920", Offset = "0x1BF4920", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			internal DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay)
			{
				throw null;
			}

			// Token: 0x04001A4A RID: 6730
			[global::Cpp2ILInjected.Token(Token = "0x40018B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int HijriMonthsLengthFlags;

			// Token: 0x04001A4B RID: 6731
			[global::Cpp2ILInjected.Token(Token = "0x40018B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal global::System.DateTime GregorianDate;
		}
	}
}