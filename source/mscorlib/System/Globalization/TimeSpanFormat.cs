﻿using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004B6 RID: 1206
	[global::Cpp2ILInjected.Token(Token = "0x2000599")]
	internal static class TimeSpanFormat
	{
		// Token: 0x060027F3 RID: 10227 RVA: 0x0001B473 File Offset: 0x00019673
		[global::Cpp2ILInjected.Token(Token = "0x6002B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE1630", Offset = "0x1BE1630", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(bool),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanFormat.Pattern)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static void AppendNonNegativeInt32(global::System.Text.StringBuilder sb, int n, int digits)
		{
			throw null;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x0001B476 File Offset: 0x00019676
		[global::Cpp2ILInjected.Token(Token = "0x6002B26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE171C", Offset = "0x1BE171C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static string Format(global::System.TimeSpan value, string format, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x0001B479 File Offset: 0x00019679
		[global::Cpp2ILInjected.Token(Token = "0x6002B27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE1A7C", Offset = "0x1BE1A7C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Release", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool TryFormat(global::System.TimeSpan value, global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x0001B47C File Offset: 0x0001967C
		[global::Cpp2ILInjected.Token(Token = "0x6002B28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE17D4", Offset = "0x1BE17D4", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(DateTimeFormatInfo),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(bool),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanFormat.Pattern)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static global::System.Text.StringBuilder FormatToBuilder(global::System.TimeSpan value, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x0001B47F File Offset: 0x0001967F
		[global::Cpp2ILInjected.Token(Token = "0x6002B29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE1B90", Offset = "0x1BE1B90", Length = "0x450")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat.FormatLiterals), Member = "Init", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat), Member = "AppendNonNegativeInt32", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static global::System.Text.StringBuilder FormatStandard(global::System.TimeSpan value, bool isInvariant, global::System.ReadOnlySpan<char> format, TimeSpanFormat.Pattern pattern)
		{
			throw null;
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0001B482 File Offset: 0x00019682
		[global::Cpp2ILInjected.Token(Token = "0x6002B2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE1FE0", Offset = "0x1BE1FE0", Length = "0x6BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(DateTimeFormatInfo),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "ParseNextChar", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(DateTimeFormatInfo),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "ParseRepeatPattern", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "ParseQuoteString", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "FormatDigits", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "FormatDigits", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Release", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private static global::System.Text.StringBuilder FormatCustomized(global::System.TimeSpan value, global::System.ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, global::System.Text.StringBuilder result)
		{
			throw null;
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x0001B485 File Offset: 0x00019685
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002B2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE2B24", Offset = "0x1BE2B24", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat.FormatLiterals), Member = "InitInvariant", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static TimeSpanFormat()
		{
			throw null;
		}

		// Token: 0x04001430 RID: 5168
		[global::Cpp2ILInjected.Token(Token = "0x40017B6")]
		internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals;

		// Token: 0x04001431 RID: 5169
		[global::Cpp2ILInjected.Token(Token = "0x40017B7")]
		internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals;

		// Token: 0x0200062D RID: 1581
		[global::Cpp2ILInjected.Token(Token = "0x200059A")]
		internal enum Pattern
		{
			// Token: 0x04001A0D RID: 6669
			[global::Cpp2ILInjected.Token(Token = "0x40017B9")]
			None,
			// Token: 0x04001A0E RID: 6670
			[global::Cpp2ILInjected.Token(Token = "0x40017BA")]
			Minimum,
			// Token: 0x04001A0F RID: 6671
			[global::Cpp2ILInjected.Token(Token = "0x40017BB")]
			Full
		}

		// Token: 0x0200062E RID: 1582
		[global::Cpp2ILInjected.Token(Token = "0x200059B")]
		internal struct FormatLiterals
		{
			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06004206 RID: 16902 RVA: 0x0002006C File Offset: 0x0001E26C
			[global::Cpp2ILInjected.Token(Token = "0x17000657")]
			internal string Start
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B2C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE2ADC", Offset = "0x1BE2ADC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06004207 RID: 16903 RVA: 0x0002006F File Offset: 0x0001E26F
			[global::Cpp2ILInjected.Token(Token = "0x17000658")]
			internal string DayHourSep
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B2D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE2AE8", Offset = "0x1BE2AE8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x06004208 RID: 16904 RVA: 0x00020072 File Offset: 0x0001E272
			[global::Cpp2ILInjected.Token(Token = "0x17000659")]
			internal string HourMinuteSep
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B2E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE2AF4", Offset = "0x1BE2AF4", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x06004209 RID: 16905 RVA: 0x00020075 File Offset: 0x0001E275
			[global::Cpp2ILInjected.Token(Token = "0x1700065A")]
			internal string MinuteSecondSep
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B2F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE2B00", Offset = "0x1BE2B00", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x0600420A RID: 16906 RVA: 0x00020078 File Offset: 0x0001E278
			[global::Cpp2ILInjected.Token(Token = "0x1700065B")]
			internal string SecondFractionSep
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B30")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE2B0C", Offset = "0x1BE2B0C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x0600420B RID: 16907 RVA: 0x0002007B File Offset: 0x0001E27B
			[global::Cpp2ILInjected.Token(Token = "0x1700065C")]
			internal string End
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B31")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE2B18", Offset = "0x1BE2B18", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600420C RID: 16908 RVA: 0x0002007E File Offset: 0x0001E27E
			[global::Cpp2ILInjected.Token(Token = "0x6002B32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE2BB8", Offset = "0x1BE2BB8", Length = "0x1BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative)
			{
				throw null;
			}

			// Token: 0x0600420D RID: 16909 RVA: 0x00020081 File Offset: 0x0001E281
			[global::Cpp2ILInjected.Token(Token = "0x6002B33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE269C", Offset = "0x1BE269C", Length = "0x3B0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(bool),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(TimeSpanFormat.Pattern)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.TimeSpanRawInfo", Member = "get_PositiveLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.TimeSpanRawInfo", Member = "get_NegativeLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Release", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			internal void Init(global::System.ReadOnlySpan<char> format, bool useInvariantFieldLengths)
			{
				throw null;
			}

			// Token: 0x04001A10 RID: 6672
			[global::Cpp2ILInjected.Token(Token = "0x40017BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal string AppCompatLiteral;

			// Token: 0x04001A11 RID: 6673
			[global::Cpp2ILInjected.Token(Token = "0x40017BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int dd;

			// Token: 0x04001A12 RID: 6674
			[global::Cpp2ILInjected.Token(Token = "0x40017BE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal int hh;

			// Token: 0x04001A13 RID: 6675
			[global::Cpp2ILInjected.Token(Token = "0x40017BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal int mm;

			// Token: 0x04001A14 RID: 6676
			[global::Cpp2ILInjected.Token(Token = "0x40017C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			internal int ss;

			// Token: 0x04001A15 RID: 6677
			[global::Cpp2ILInjected.Token(Token = "0x40017C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int ff;

			// Token: 0x04001A16 RID: 6678
			[global::Cpp2ILInjected.Token(Token = "0x40017C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private string[] _literals;
		}
	}
}
