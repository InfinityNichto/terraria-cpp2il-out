﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004CA RID: 1226
	[global::Cpp2ILInjected.Token(Token = "0x20005B8")]
	[StructLayout(0)]
	internal class CultureData
	{
		// Token: 0x0600293E RID: 10558 RVA: 0x0001B81E File Offset: 0x00019A1E
		[global::Cpp2ILInjected.Token(Token = "0x6002C9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6340", Offset = "0x1BF6340", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private CultureData(string name)
		{
			throw null;
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x0001B821 File Offset: 0x00019A21
		[global::Cpp2ILInjected.Token(Token = "0x170006B0")]
		public static CultureData Invariant
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF6368", Offset = "0x1BF6368", Length = "0x34C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "get_Invariant", ReturnType = typeof(TextInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(string)
			}, ReturnType = typeof(CultureData))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x0001B824 File Offset: 0x00019A24
		[global::Cpp2ILInjected.Token(Token = "0x6002C9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF66B4", Offset = "0x1BF66B4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static CultureData GetCultureData(string cultureName, bool useUserOverride)
		{
			throw null;
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x0001B827 File Offset: 0x00019A27
		[global::Cpp2ILInjected.Token(Token = "0x6002CA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF67A0", Offset = "0x1BF67A0", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "GetCultures", MemberParameters = new object[] { typeof(CultureTypes) }, ReturnType = typeof(CultureInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator)
		{
			throw null;
		}

		// Token: 0x06002942 RID: 10562
		[global::Cpp2ILInjected.Token(Token = "0x6002CA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF68B8", Offset = "0x1BF68B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern void fill_culture_data(int datetimeIndex);

		// Token: 0x06002943 RID: 10563 RVA: 0x0001B82A File Offset: 0x00019A2A
		[global::Cpp2ILInjected.Token(Token = "0x6002CA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF68BC", Offset = "0x1BF68BC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = "GetCalendarData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "DayNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "AbbreviatedDayNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "MonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "AbbreviatedMonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "AbbreviatedGenitiveMonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "LeapYearMonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public CalendarData GetCalendar(int calendarId)
		{
			throw null;
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x0001B82D File Offset: 0x00019A2D
		[global::Cpp2ILInjected.Token(Token = "0x170006B1")]
		internal string[] LongTimes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF69AC", Offset = "0x1BF69AC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new object[]
			{
				typeof(CultureData),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongTimePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x0001B830 File Offset: 0x00019A30
		[global::Cpp2ILInjected.Token(Token = "0x170006B2")]
		internal string[] ShortTimes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF69C4", Offset = "0x1BF69C4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new object[]
			{
				typeof(CultureData),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortTimePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x0001B833 File Offset: 0x00019A33
		[global::Cpp2ILInjected.Token(Token = "0x170006B3")]
		internal string SISO639LANGNAME
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF69DC", Offset = "0x1BF69DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x0001B836 File Offset: 0x00019A36
		[global::Cpp2ILInjected.Token(Token = "0x170006B4")]
		internal int IFIRSTDAYOFWEEK
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF69E4", Offset = "0x1BF69E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x0001B839 File Offset: 0x00019A39
		[global::Cpp2ILInjected.Token(Token = "0x170006B5")]
		internal int IFIRSTWEEKOFYEAR
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF69EC", Offset = "0x1BF69EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x0001B83C File Offset: 0x00019A3C
		[global::Cpp2ILInjected.Token(Token = "0x170006B6")]
		internal string SAM1159
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF69F4", Offset = "0x1BF69F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x0001B83F File Offset: 0x00019A3F
		[global::Cpp2ILInjected.Token(Token = "0x170006B7")]
		internal string SPM2359
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF69FC", Offset = "0x1BF69FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x0001B842 File Offset: 0x00019A42
		[global::Cpp2ILInjected.Token(Token = "0x170006B8")]
		internal string TimeSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF6A04", Offset = "0x1BF6A04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x0001B845 File Offset: 0x00019A45
		[global::Cpp2ILInjected.Token(Token = "0x170006B9")]
		internal int[] CalendarIds
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF6A0C", Offset = "0x1BF6A0C", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0001B848 File Offset: 0x00019A48
		[global::Cpp2ILInjected.Token(Token = "0x6002CAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6B60", Offset = "0x1BF6B60", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new object[] { typeof(Calendar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_OptionalCalendars", ReturnType = typeof(CalendarId[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_CalendarIds", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal CalendarId[] GetCalendarIds()
		{
			throw null;
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x0001B84B File Offset: 0x00019A4B
		[global::Cpp2ILInjected.Token(Token = "0x170006BA")]
		internal bool IsInvariantCulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF6C10", Offset = "0x1BF6C10", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new object[] { typeof(CultureData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x0001B84E File Offset: 0x00019A4E
		[global::Cpp2ILInjected.Token(Token = "0x170006BB")]
		internal string CultureName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF6C1C", Offset = "0x1BF6C1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x0001B851 File Offset: 0x00019A51
		[global::Cpp2ILInjected.Token(Token = "0x170006BC")]
		internal string SCOMPAREINFO
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF6C24", Offset = "0x1BF6C24", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x0001B854 File Offset: 0x00019A54
		[global::Cpp2ILInjected.Token(Token = "0x170006BD")]
		internal string STEXTINFO
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF6C64", Offset = "0x1BF6C64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x0001B857 File Offset: 0x00019A57
		[global::Cpp2ILInjected.Token(Token = "0x170006BE")]
		internal bool UseUserOverride
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF6C6C", Offset = "0x1BF6C6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x0001B85A File Offset: 0x00019A5A
		[global::Cpp2ILInjected.Token(Token = "0x6002CB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6C74", Offset = "0x1BF6C74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_EraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] EraNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x0001B85D File Offset: 0x00019A5D
		[global::Cpp2ILInjected.Token(Token = "0x6002CB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6C88", Offset = "0x1BF6C88", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] AbbrevEraNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x0001B860 File Offset: 0x00019A60
		[global::Cpp2ILInjected.Token(Token = "0x6002CB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6C9C", Offset = "0x1BF6C9C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedEnglishEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] AbbreviatedEnglishEraNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x0001B863 File Offset: 0x00019A63
		[global::Cpp2ILInjected.Token(Token = "0x6002CB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6CB0", Offset = "0x1BF6CB0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new object[]
		{
			typeof(CultureData),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] ShortDates(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x0001B866 File Offset: 0x00019A66
		[global::Cpp2ILInjected.Token(Token = "0x6002CB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6CC4", Offset = "0x1BF6CC4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new object[]
		{
			typeof(CultureData),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] LongDates(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x0001B869 File Offset: 0x00019A69
		[global::Cpp2ILInjected.Token(Token = "0x6002CB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6CD8", Offset = "0x1BF6CD8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new object[]
		{
			typeof(CultureData),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] YearMonths(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x0001B86C File Offset: 0x00019A6C
		[global::Cpp2ILInjected.Token(Token = "0x6002CB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6CEC", Offset = "0x1BF6CEC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] DayNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x0001B86F File Offset: 0x00019A6F
		[global::Cpp2ILInjected.Token(Token = "0x6002CB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6D00", Offset = "0x1BF6D00", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] AbbreviatedDayNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0001B872 File Offset: 0x00019A72
		[global::Cpp2ILInjected.Token(Token = "0x6002CBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6D14", Offset = "0x1BF6D14", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] MonthNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x0001B875 File Offset: 0x00019A75
		[global::Cpp2ILInjected.Token(Token = "0x6002CBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6D28", Offset = "0x1BF6D28", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] GenitiveMonthNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x0001B878 File Offset: 0x00019A78
		[global::Cpp2ILInjected.Token(Token = "0x6002CBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6D3C", Offset = "0x1BF6D3C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] AbbreviatedMonthNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x0001B87B File Offset: 0x00019A7B
		[global::Cpp2ILInjected.Token(Token = "0x6002CBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6D50", Offset = "0x1BF6D50", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] AbbreviatedGenitiveMonthNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x0001B87E File Offset: 0x00019A7E
		[global::Cpp2ILInjected.Token(Token = "0x6002CBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6D64", Offset = "0x1BF6D64", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetLeapYearMonthNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string[] LeapYearMonthNames(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0001B881 File Offset: 0x00019A81
		[global::Cpp2ILInjected.Token(Token = "0x6002CBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6D78", Offset = "0x1BF6D78", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		internal string MonthDay(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x0001B884 File Offset: 0x00019A84
		[global::Cpp2ILInjected.Token(Token = "0x6002CC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6D8C", Offset = "0x1BF6D8C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new object[]
		{
			typeof(CultureData),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal string DateSeparator(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x0001B887 File Offset: 0x00019A87
		[global::Cpp2ILInjected.Token(Token = "0x6002CC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6E20", Offset = "0x1BF6E20", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string GetDateSeparator(string format)
		{
			throw null;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0001B88A File Offset: 0x00019A8A
		[global::Cpp2ILInjected.Token(Token = "0x6002CC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6E68", Offset = "0x1BF6E68", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "IndexOfTimePart", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "UnescapeNlsString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string GetSeparator(string format, string timeParts)
		{
			throw null;
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x0001B88D File Offset: 0x00019A8D
		[global::Cpp2ILInjected.Token(Token = "0x6002CC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6F64", Offset = "0x1BF6F64", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GetSeparator", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		private static int IndexOfTimePart(string format, int startIndex, string timeParts)
		{
			throw null;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x0001B890 File Offset: 0x00019A90
		[global::Cpp2ILInjected.Token(Token = "0x6002CC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF7044", Offset = "0x1BF7044", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GetSeparator", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string UnescapeNlsString(string str, int start, int end)
		{
			throw null;
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x0001B893 File Offset: 0x00019A93
		[global::Cpp2ILInjected.Token(Token = "0x6002CC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF71C0", Offset = "0x1BF71C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal static string[] ReescapeWin32Strings(string[] array)
		{
			throw null;
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x0001B896 File Offset: 0x00019A96
		[global::Cpp2ILInjected.Token(Token = "0x6002CC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF71C4", Offset = "0x1BF71C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static string ReescapeWin32String(string str)
		{
			throw null;
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x0001B899 File Offset: 0x00019A99
		[global::Cpp2ILInjected.Token(Token = "0x6002CC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF71C8", Offset = "0x1BF71C8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe static int strlen(byte* s)
		{
			throw null;
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x0001B89C File Offset: 0x00019A9C
		[global::Cpp2ILInjected.Token(Token = "0x6002CC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF71E0", Offset = "0x1BF71E0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new object[] { typeof(NumberFormatInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(string))]
		private unsafe static string idx2string(byte* data, int idx)
		{
			throw null;
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x0001B89F File Offset: 0x00019A9F
		[global::Cpp2ILInjected.Token(Token = "0x6002CC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF721C", Offset = "0x1BF721C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new object[] { typeof(NumberFormatInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int[] create_group_sizes_array(int gs0, int gs1)
		{
			throw null;
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x0001B8A2 File Offset: 0x00019AA2
		[global::Cpp2ILInjected.Token(Token = "0x6002CCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF72A4", Offset = "0x1BF72A4", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new object[] { typeof(CultureData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "create_group_sizes_array", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "idx2string", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "set_NaNSymbol", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe void GetNFIValues(NumberFormatInfo nfi)
		{
			throw null;
		}

		// Token: 0x0600296C RID: 10604
		[global::Cpp2ILInjected.Token(Token = "0x6002CCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF7430", Offset = "0x1BF7430", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern byte* fill_number_data(int index, ref CultureData.NumberFormatEntryManaged nfe);

		// Token: 0x040014F7 RID: 5367
		[global::Cpp2ILInjected.Token(Token = "0x40018BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string sAM1159;

		// Token: 0x040014F8 RID: 5368
		[global::Cpp2ILInjected.Token(Token = "0x40018BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string sPM2359;

		// Token: 0x040014F9 RID: 5369
		[global::Cpp2ILInjected.Token(Token = "0x40018BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string sTimeSeparator;

		// Token: 0x040014FA RID: 5370
		[global::Cpp2ILInjected.Token(Token = "0x40018C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string[] saLongTimes;

		// Token: 0x040014FB RID: 5371
		[global::Cpp2ILInjected.Token(Token = "0x40018C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string[] saShortTimes;

		// Token: 0x040014FC RID: 5372
		[global::Cpp2ILInjected.Token(Token = "0x40018C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int iFirstDayOfWeek;

		// Token: 0x040014FD RID: 5373
		[global::Cpp2ILInjected.Token(Token = "0x40018C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int iFirstWeekOfYear;

		// Token: 0x040014FE RID: 5374
		[global::Cpp2ILInjected.Token(Token = "0x40018C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int[] waCalendars;

		// Token: 0x040014FF RID: 5375
		[global::Cpp2ILInjected.Token(Token = "0x40018C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private CalendarData[] calendars;

		// Token: 0x04001500 RID: 5376
		[global::Cpp2ILInjected.Token(Token = "0x40018C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string sISO639Language;

		// Token: 0x04001501 RID: 5377
		[global::Cpp2ILInjected.Token(Token = "0x40018C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly string sRealName;

		// Token: 0x04001502 RID: 5378
		[global::Cpp2ILInjected.Token(Token = "0x40018C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool bUseOverrides;

		// Token: 0x04001503 RID: 5379
		[global::Cpp2ILInjected.Token(Token = "0x40018C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int calendarId;

		// Token: 0x04001504 RID: 5380
		[global::Cpp2ILInjected.Token(Token = "0x40018CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int numberIndex;

		// Token: 0x04001505 RID: 5381
		[global::Cpp2ILInjected.Token(Token = "0x40018CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private int iDefaultAnsiCodePage;

		// Token: 0x04001506 RID: 5382
		[global::Cpp2ILInjected.Token(Token = "0x40018CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int iDefaultOemCodePage;

		// Token: 0x04001507 RID: 5383
		[global::Cpp2ILInjected.Token(Token = "0x40018CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private int iDefaultMacCodePage;

		// Token: 0x04001508 RID: 5384
		[global::Cpp2ILInjected.Token(Token = "0x40018CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int iDefaultEbcdicCodePage;

		// Token: 0x04001509 RID: 5385
		[global::Cpp2ILInjected.Token(Token = "0x40018CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private bool isRightToLeft;

		// Token: 0x0400150A RID: 5386
		[global::Cpp2ILInjected.Token(Token = "0x40018D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private string sListSeparator;

		// Token: 0x0400150B RID: 5387
		[global::Cpp2ILInjected.Token(Token = "0x40018D1")]
		private static CultureData s_Invariant;

		// Token: 0x02000638 RID: 1592
		[global::Cpp2ILInjected.Token(Token = "0x20005B9")]
		internal struct NumberFormatEntryManaged
		{
			// Token: 0x04001A4C RID: 6732
			[global::Cpp2ILInjected.Token(Token = "0x40018D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int currency_decimal_digits;

			// Token: 0x04001A4D RID: 6733
			[global::Cpp2ILInjected.Token(Token = "0x40018D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			internal int currency_decimal_separator;

			// Token: 0x04001A4E RID: 6734
			[global::Cpp2ILInjected.Token(Token = "0x40018D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int currency_group_separator;

			// Token: 0x04001A4F RID: 6735
			[global::Cpp2ILInjected.Token(Token = "0x40018D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal int currency_group_sizes0;

			// Token: 0x04001A50 RID: 6736
			[global::Cpp2ILInjected.Token(Token = "0x40018D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal int currency_group_sizes1;

			// Token: 0x04001A51 RID: 6737
			[global::Cpp2ILInjected.Token(Token = "0x40018D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			internal int currency_negative_pattern;

			// Token: 0x04001A52 RID: 6738
			[global::Cpp2ILInjected.Token(Token = "0x40018D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int currency_positive_pattern;

			// Token: 0x04001A53 RID: 6739
			[global::Cpp2ILInjected.Token(Token = "0x40018D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			internal int currency_symbol;

			// Token: 0x04001A54 RID: 6740
			[global::Cpp2ILInjected.Token(Token = "0x40018DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal int nan_symbol;

			// Token: 0x04001A55 RID: 6741
			[global::Cpp2ILInjected.Token(Token = "0x40018DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			internal int negative_infinity_symbol;

			// Token: 0x04001A56 RID: 6742
			[global::Cpp2ILInjected.Token(Token = "0x40018DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal int negative_sign;

			// Token: 0x04001A57 RID: 6743
			[global::Cpp2ILInjected.Token(Token = "0x40018DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			internal int number_decimal_digits;

			// Token: 0x04001A58 RID: 6744
			[global::Cpp2ILInjected.Token(Token = "0x40018DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal int number_decimal_separator;

			// Token: 0x04001A59 RID: 6745
			[global::Cpp2ILInjected.Token(Token = "0x40018DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			internal int number_group_separator;

			// Token: 0x04001A5A RID: 6746
			[global::Cpp2ILInjected.Token(Token = "0x40018E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal int number_group_sizes0;

			// Token: 0x04001A5B RID: 6747
			[global::Cpp2ILInjected.Token(Token = "0x40018E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			internal int number_group_sizes1;

			// Token: 0x04001A5C RID: 6748
			[global::Cpp2ILInjected.Token(Token = "0x40018E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			internal int number_negative_pattern;

			// Token: 0x04001A5D RID: 6749
			[global::Cpp2ILInjected.Token(Token = "0x40018E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
			internal int per_mille_symbol;

			// Token: 0x04001A5E RID: 6750
			[global::Cpp2ILInjected.Token(Token = "0x40018E4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			internal int percent_negative_pattern;

			// Token: 0x04001A5F RID: 6751
			[global::Cpp2ILInjected.Token(Token = "0x40018E5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			internal int percent_positive_pattern;

			// Token: 0x04001A60 RID: 6752
			[global::Cpp2ILInjected.Token(Token = "0x40018E6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			internal int percent_symbol;

			// Token: 0x04001A61 RID: 6753
			[global::Cpp2ILInjected.Token(Token = "0x40018E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
			internal int positive_infinity_symbol;

			// Token: 0x04001A62 RID: 6754
			[global::Cpp2ILInjected.Token(Token = "0x40018E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal int positive_sign;
		}
	}
}
