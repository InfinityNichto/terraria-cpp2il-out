﻿using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C0 RID: 192
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000107")]
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00003B69 File Offset: 0x00001D69
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00003B6C File Offset: 0x00001D6C
		[global::Cpp2ILInjected.Token(Token = "0x170001D7")]
		public DateTimeStyles DateTimeStyles
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2A5C0", Offset = "0x1D2A5C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A68")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2A5C8", Offset = "0x1D2A5C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00003B6F File Offset: 0x00001D6F
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00003B72 File Offset: 0x00001D72
		[global::Cpp2ILInjected.Token(Token = "0x170001D8")]
		public string DateTimeFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2A5D0", Offset = "0x1D2A5D0", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2A624", Offset = "0x1D2A624", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "NullEmptyString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00003B75 File Offset: 0x00001D75
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00003B78 File Offset: 0x00001D78
		[global::Cpp2ILInjected.Token(Token = "0x170001D9")]
		public CultureInfo Culture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2A644", Offset = "0x1D2A644", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IsoDateTimeConverter), Member = "WriteJson", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(JsonSerializer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IsoDateTimeConverter), Member = "ReadJson", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(object),
				typeof(JsonSerializer)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2A6AC", Offset = "0x1D2A6AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00003B7B File Offset: 0x00001D7B
		[global::Cpp2ILInjected.Token(Token = "0x6000A6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2A6B4", Offset = "0x1D2A6B4", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "ToUniversalTime", ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IsoDateTimeConverter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetObjectType", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00003B7E File Offset: 0x00001D7E
		[global::Cpp2ILInjected.Token(Token = "0x6000A6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2A8C4", Offset = "0x1D2A8C4", Length = "0x4A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IsoDateTimeConverter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00003B81 File Offset: 0x00001D81
		[global::Cpp2ILInjected.Token(Token = "0x6000A6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2AD68", Offset = "0x1D2AD68", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public IsoDateTimeConverter()
		{
			throw null;
		}

		// Token: 0x040002EF RID: 751
		[global::Cpp2ILInjected.Token(Token = "0x4000409")]
		private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x040002F0 RID: 752
		[global::Cpp2ILInjected.Token(Token = "0x400040A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DateTimeStyles _dateTimeStyles;

		// Token: 0x040002F1 RID: 753
		[global::Cpp2ILInjected.Token(Token = "0x400040B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _dateTimeFormat;

		// Token: 0x040002F2 RID: 754
		[global::Cpp2ILInjected.Token(Token = "0x400040C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private CultureInfo _culture;
	}
}
