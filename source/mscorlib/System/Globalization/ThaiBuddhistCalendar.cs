﻿using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004C6 RID: 1222
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005B3")]
	[global::System.Serializable]
	public class ThaiBuddhistCalendar : Calendar
	{
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x0001B76D File Offset: 0x0001996D
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170006A3")]
		public override global::System.DateTime MinSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF429C", Offset = "0x1BF429C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x0001B770 File Offset: 0x00019970
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170006A4")]
		public override global::System.DateTime MaxSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF42F4", Offset = "0x1BF42F4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x0001B773 File Offset: 0x00019973
		[global::Cpp2ILInjected.Token(Token = "0x6002C5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF434C", Offset = "0x1BF434C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ThaiBuddhistCalendar()
		{
			throw null;
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x0001B776 File Offset: 0x00019976
		[global::Cpp2ILInjected.Token(Token = "0x170006A5")]
		internal override int ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF4428", Offset = "0x1BF4428", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0001B779 File Offset: 0x00019979
		[global::Cpp2ILInjected.Token(Token = "0x6002C5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4430", Offset = "0x1BF4430", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			throw null;
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x0001B77C File Offset: 0x0001997C
		[global::Cpp2ILInjected.Token(Token = "0x6002C60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4438", Offset = "0x1BF4438", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public override int GetDaysInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x0001B77F File Offset: 0x0001997F
		[global::Cpp2ILInjected.Token(Token = "0x6002C61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4440", Offset = "0x1BF4440", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetDayOfMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x0001B782 File Offset: 0x00019982
		[global::Cpp2ILInjected.Token(Token = "0x6002C62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4480", Offset = "0x1BF4480", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfWeek", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DayOfWeek))]
		public override global::System.DayOfWeek GetDayOfWeek(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x0001B785 File Offset: 0x00019985
		[global::Cpp2ILInjected.Token(Token = "0x6002C63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4488", Offset = "0x1BF4488", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		public override int GetMonthsInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x0001B788 File Offset: 0x00019988
		[global::Cpp2ILInjected.Token(Token = "0x6002C64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF44A4", Offset = "0x1BF44A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetEra", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		public override int GetEra(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x0001B78B File Offset: 0x0001998B
		[global::Cpp2ILInjected.Token(Token = "0x6002C65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF44AC", Offset = "0x1BF44AC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x0001B78E File Offset: 0x0001998E
		[global::Cpp2ILInjected.Token(Token = "0x6002C66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF44EC", Offset = "0x1BF44EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYear", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		public override int GetYear(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x0001B791 File Offset: 0x00019991
		[global::Cpp2ILInjected.Token(Token = "0x6002C67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF44F4", Offset = "0x1BF44F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "IsLeapYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		public override bool IsLeapYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x0001B794 File Offset: 0x00019994
		[global::Cpp2ILInjected.Token(Token = "0x6002C68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF44FC", Offset = "0x1BF44FC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new object[]
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
		public override global::System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			throw null;
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x0001B797 File Offset: 0x00019997
		[global::Cpp2ILInjected.Token(Token = "0x170006A6")]
		public override int[] Eras
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF450C", Offset = "0x1BF450C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "get_Eras", ReturnType = typeof(int[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x0001B79A File Offset: 0x0001999A
		// (set) Token: 0x0600290D RID: 10509 RVA: 0x0001B79D File Offset: 0x0001999D
		[global::Cpp2ILInjected.Token(Token = "0x170006A7")]
		public override int TwoDigitYearMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF4514", Offset = "0x1BF4514", Length = "0x44")]
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
			[global::Cpp2ILInjected.Token(Token = "0x6002C6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF4558", Offset = "0x1BF4558", Length = "0x128")]
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

		// Token: 0x0600290E RID: 10510 RVA: 0x0001B7A0 File Offset: 0x000199A0
		[global::Cpp2ILInjected.Token(Token = "0x6002C6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4680", Offset = "0x1BF4680", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "ToFourDigitYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int ToFourDigitYear(int year)
		{
			throw null;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x0001B7A3 File Offset: 0x000199A3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002C6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4720", Offset = "0x1BF4720", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EraInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static ThaiBuddhistCalendar()
		{
			throw null;
		}

		// Token: 0x040014EE RID: 5358
		[global::Cpp2ILInjected.Token(Token = "0x40018B2")]
		internal static EraInfo[] thaiBuddhistEraInfo;

		// Token: 0x040014EF RID: 5359
		[global::Cpp2ILInjected.Token(Token = "0x40018B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal GregorianCalendarHelper helper;
	}
}