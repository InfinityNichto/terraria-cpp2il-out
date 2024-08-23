﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000087 RID: 135
	[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::Cpp2ILInjected.Token(Token = "0x20000B3")]
	internal ref struct __DTString
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00015824 File Offset: 0x00013A24
		[global::Cpp2ILInjected.Token(Token = "0x17000088")]
		internal int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000701")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2C5D0", Offset = "0x1C2C5D0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchWord", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "HandleTimeZone", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
			{
				typeof(global::System.DateTimeParse.DS),
				typeof(ref global::System.__DTString),
				typeof(ref global::System.DateTimeToken),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(ref global::System.DateTimeResult),
				typeof(ref global::System.Globalization.DateTimeFormatInfo),
				typeof(global::System.Globalization.DateTimeStyles)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "VerifyValidPunctuation", MemberParameters = new object[] { typeof(ref global::System.__DTString) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseDigits", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(int),
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseFractionExact", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(int),
				typeof(ref double)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(global::System.Globalization.DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(global::System.Globalization.DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(global::System.Globalization.DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchDayName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(global::System.Globalization.DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchEraName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(global::System.Globalization.DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchTimeMark", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(global::System.Globalization.DateTimeFormatInfo),
				typeof(ref global::System.DateTimeParse.TM)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(ref global::System.__DTString),
				typeof(ref global::System.ParsingInfo),
				typeof(global::System.Globalization.DateTimeFormatInfo),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
			{
				typeof(global::System.TokenType),
				typeof(ref global::System.TokenType),
				typeof(ref int),
				typeof(ref global::System.__DTString)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00015827 File Offset: 0x00013A27
		[global::Cpp2ILInjected.Token(Token = "0x6000702")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2C60C", Offset = "0x1C2C60C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(void))]
		internal __DTString(global::System.ReadOnlySpan<char> str, global::System.Globalization.DateTimeFormatInfo dtfi, bool checkDigitToken)
		{
			throw null;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001582A File Offset: 0x00013A2A
		[global::Cpp2ILInjected.Token(Token = "0x6000703")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2C630", Offset = "0x1C2C630", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_CompareInfo", ReturnType = typeof(global::System.Globalization.CompareInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(global::System.Globalization.DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal __DTString(global::System.ReadOnlySpan<char> str, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0001582D File Offset: 0x00013A2D
		[global::Cpp2ILInjected.Token(Token = "0x17000089")]
		internal global::System.Globalization.CompareInfo CompareInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000704")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2C6EC", Offset = "0x1C2C6EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00015830 File Offset: 0x00013A30
		[global::Cpp2ILInjected.Token(Token = "0x6000705")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2C6F4", Offset = "0x1C2C6F4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseFraction", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "VerifyValidPunctuation", MemberParameters = new object[] { typeof(ref global::System.__DTString) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchHebrewDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseSign", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchEraName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchTimeMark", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeParse.TM)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeParse.TM)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseJapaneseEraStart", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool GetNext()
		{
			throw null;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00015833 File Offset: 0x00013A33
		[global::Cpp2ILInjected.Token(Token = "0x6000706")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2C760", Offset = "0x1C2C760", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool AtEnd()
		{
			throw null;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00015836 File Offset: 0x00013A36
		[global::Cpp2ILInjected.Token(Token = "0x6000707")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2C7A8", Offset = "0x1C2C7A8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "TryParseHebrewNumber", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
		{
			typeof(global::System.TokenType),
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(ref global::System.__DTString)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool Advance(int count)
		{
			throw null;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00015839 File Offset: 0x00013A39
		[global::Cpp2ILInjected.Token(Token = "0x6000708")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2C814", Offset = "0x1C2C814", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
		{
			typeof(global::System.TokenType),
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(ref global::System.__DTString)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void GetRegularToken(out global::System.TokenType tokenType, out int tokenValue, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001583C File Offset: 0x00013A3C
		[global::Cpp2ILInjected.Token(Token = "0x6000709")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2CAD0", Offset = "0x1C2CAD0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "SkipWhiteSpaceCurrent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
		{
			typeof(global::System.TokenType),
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(ref global::System.__DTString)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.TokenType GetSeparatorToken(global::System.Globalization.DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
		{
			throw null;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001583F File Offset: 0x00013A3F
		[global::Cpp2ILInjected.Token(Token = "0x600070A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2CCC4", Offset = "0x1C2CCC4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		internal bool MatchSpecifiedWord(string target)
		{
			throw null;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00015842 File Offset: 0x00013A42
		[global::Cpp2ILInjected.Token(Token = "0x600070B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2CDBC", Offset = "0x1C2CDBC", Length = "0x430")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "MatchLongestWords", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
		{
			typeof(global::System.TokenType),
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(ref global::System.__DTString)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOptionIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength)
		{
			throw null;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00015845 File Offset: 0x00013A45
		[global::Cpp2ILInjected.Token(Token = "0x600070C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D1EC", Offset = "0x1C2D1EC", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal bool Match(string str)
		{
			throw null;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00015848 File Offset: 0x00013A48
		[global::Cpp2ILInjected.Token(Token = "0x600070D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D310", Offset = "0x1C2D310", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool Match(char ch)
		{
			throw null;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001584B File Offset: 0x00013A4B
		[global::Cpp2ILInjected.Token(Token = "0x600070E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D3A0", Offset = "0x1C2D3A0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		internal int MatchLongestWords(string[] words, ref int maxMatchStrLen)
		{
			throw null;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001584E File Offset: 0x00013A4E
		[global::Cpp2ILInjected.Token(Token = "0x600070F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D440", Offset = "0x1C2D440", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal int GetRepeatCount()
		{
			throw null;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00015851 File Offset: 0x00013A51
		[global::Cpp2ILInjected.Token(Token = "0x6000710")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D4D4", Offset = "0x1C2D4D4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		internal bool GetNextDigit()
		{
			throw null;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00015854 File Offset: 0x00013A54
		[global::Cpp2ILInjected.Token(Token = "0x6000711")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D580", Offset = "0x1C2D580", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchHebrewDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseSign", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeParse.TM)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		internal char GetChar()
		{
			throw null;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00015857 File Offset: 0x00013A57
		[global::Cpp2ILInjected.Token(Token = "0x6000712")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D590", Offset = "0x1C2D590", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseFractionExact", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal int GetDigit()
		{
			throw null;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001585A File Offset: 0x00013A5A
		[global::Cpp2ILInjected.Token(Token = "0x6000713")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D5A4", Offset = "0x1C2D5A4", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void SkipWhiteSpaces()
		{
			throw null;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001585D File Offset: 0x00013A5D
		[global::Cpp2ILInjected.Token(Token = "0x6000714")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2CBA8", Offset = "0x1C2CBA8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "GetSeparatorToken", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int),
			typeof(ref char)
		}, ReturnType = typeof(global::System.TokenType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal bool SkipWhiteSpaceCurrent()
		{
			throw null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00015860 File Offset: 0x00013A60
		[global::Cpp2ILInjected.Token(Token = "0x6000715")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D66C", Offset = "0x1C2D66C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void TrimTail()
		{
			throw null;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00015863 File Offset: 0x00013A63
		[global::Cpp2ILInjected.Token(Token = "0x6000716")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D768", Offset = "0x1C2D768", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal void RemoveTrailingInQuoteSpaces()
		{
			throw null;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00015866 File Offset: 0x00013A66
		[global::Cpp2ILInjected.Token(Token = "0x6000717")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2D980", Offset = "0x1C2D980", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal void RemoveLeadingInQuoteSpaces()
		{
			throw null;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00015869 File Offset: 0x00013A69
		[global::Cpp2ILInjected.Token(Token = "0x6000718")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DBEC", Offset = "0x1C2DBEC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZone", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal global::System.DTSubString GetSubString()
		{
			throw null;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001586C File Offset: 0x00013A6C
		[global::Cpp2ILInjected.Token(Token = "0x6000719")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DD1C", Offset = "0x1C2DD1C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZone", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void ConsumeSubString(global::System.DTSubString sub)
		{
			throw null;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0001586F File Offset: 0x00013A6F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600071A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DD7C", Offset = "0x1C2DD7C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static __DTString()
		{
			throw null;
		}

		// Token: 0x04000190 RID: 400
		[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal global::System.ReadOnlySpan<char> Value;

		// Token: 0x04000191 RID: 401
		[global::Cpp2ILInjected.Token(Token = "0x40002BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int Index;

		// Token: 0x04000192 RID: 402
		[global::Cpp2ILInjected.Token(Token = "0x40002BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal char m_current;

		// Token: 0x04000193 RID: 403
		[global::Cpp2ILInjected.Token(Token = "0x40002BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Globalization.CompareInfo m_info;

		// Token: 0x04000194 RID: 404
		[global::Cpp2ILInjected.Token(Token = "0x40002BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_checkDigitToken;

		// Token: 0x04000195 RID: 405
		[global::Cpp2ILInjected.Token(Token = "0x40002C0")]
		private static readonly char[] WhiteSpaceChecks;
	}
}
