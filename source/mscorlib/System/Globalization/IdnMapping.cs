﻿using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004D2 RID: 1234
	[global::Cpp2ILInjected.Token(Token = "0x20005C3")]
	public sealed class IdnMapping
	{
		// Token: 0x060029BF RID: 10687 RVA: 0x0001B989 File Offset: 0x00019B89
		[global::Cpp2ILInjected.Token(Token = "0x6002D20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C029D8", Offset = "0x1C029D8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "IdnEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "IdnEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			typeof(string),
			"System.Char*",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IdnMapping()
		{
			throw null;
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x0001B98C File Offset: 0x00019B8C
		[global::Cpp2ILInjected.Token(Token = "0x6002D21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C02AA0", Offset = "0x1C02AA0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x0001B98F File Offset: 0x00019B8F
		[global::Cpp2ILInjected.Token(Token = "0x6002D22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C02B24", Offset = "0x1C02B24", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x0001B992 File Offset: 0x00019B92
		[global::Cpp2ILInjected.Token(Token = "0x6002D23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C02B34", Offset = "0x1C02B34", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "IdnEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public string GetAscii(string unicode)
		{
			throw null;
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x0001B995 File Offset: 0x00019B95
		[global::Cpp2ILInjected.Token(Token = "0x6002D24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C02B94", Offset = "0x1C02B94", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string GetAscii(string unicode, int index, int count)
		{
			throw null;
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x0001B998 File Offset: 0x00019B98
		[global::Cpp2ILInjected.Token(Token = "0x6002D25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C02C5C", Offset = "0x1C02C5C", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "GetUnicode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdnMapping), Member = "ToAscii", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdnMapping), Member = "ToUnicode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private string Convert(string input, int index, int count, bool toAscii)
		{
			throw null;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x0001B99B File Offset: 0x00019B9B
		[global::Cpp2ILInjected.Token(Token = "0x6002D26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C02E54", Offset = "0x1C02E54", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "Convert", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "ToUnicode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdnMapping), Member = "NamePrep", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdnMapping), Member = "VerifyStd3AsciiRules", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bootstring), Member = "Encode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdnMapping), Member = "VerifyLength", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private string ToAscii(string s, int offset)
		{
			throw null;
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x0001B99E File Offset: 0x00019B9E
		[global::Cpp2ILInjected.Token(Token = "0x6002D27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03860", Offset = "0x1C03860", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "ToAscii", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void VerifyLength(string s, int offset)
		{
			throw null;
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x0001B9A1 File Offset: 0x00019BA1
		[global::Cpp2ILInjected.Token(Token = "0x6002D28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0323C", Offset = "0x1C0323C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "ToAscii", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "ToUnicode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new object[] { typeof(global::System.Text.NormalizationForm) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdnMapping), Member = "VerifyProhibitedCharacters", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private string NamePrep(string s, int offset)
		{
			throw null;
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x0001B9A4 File Offset: 0x00019BA4
		[global::Cpp2ILInjected.Token(Token = "0x6002D29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0391C", Offset = "0x1C0391C", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "NamePrep", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void VerifyProhibitedCharacters(string s, int offset)
		{
			throw null;
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x0001B9A7 File Offset: 0x00019BA7
		[global::Cpp2ILInjected.Token(Token = "0x6002D2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03374", Offset = "0x1C03374", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "ToAscii", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void VerifyStd3AsciiRules(string s, int offset)
		{
			throw null;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x0001B9AA File Offset: 0x00019BAA
		[global::Cpp2ILInjected.Token(Token = "0x6002D2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03B4C", Offset = "0x1C03B4C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "IdnEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			typeof(string),
			"System.Char*",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public string GetUnicode(string ascii)
		{
			throw null;
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x0001B9AD File Offset: 0x00019BAD
		[global::Cpp2ILInjected.Token(Token = "0x6002D2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03BAC", Offset = "0x1C03BAC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdnMapping), Member = "Convert", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string GetUnicode(string ascii, int index, int count)
		{
			throw null;
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x0001B9B0 File Offset: 0x00019BB0
		[global::Cpp2ILInjected.Token(Token = "0x6002D2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03078", Offset = "0x1C03078", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "Convert", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdnMapping), Member = "NamePrep", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bootstring), Member = "Decode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdnMapping), Member = "ToAscii", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private string ToUnicode(string s, int offset)
		{
			throw null;
		}

		// Token: 0x04001555 RID: 5461
		[global::Cpp2ILInjected.Token(Token = "0x4001938")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool allow_unassigned;

		// Token: 0x04001556 RID: 5462
		[global::Cpp2ILInjected.Token(Token = "0x4001939")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool use_std3;

		// Token: 0x04001557 RID: 5463
		[global::Cpp2ILInjected.Token(Token = "0x400193A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Punycode puny;
	}
}
