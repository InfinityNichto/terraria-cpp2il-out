﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002C RID: 44
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200002D")]
	[Serializable]
	public class JsonWriterException : JsonException
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000246E File Offset: 0x0000066E
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002471 File Offset: 0x00000671
		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public string Path
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000142")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1BA0", Offset = "0x1CC1BA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000143")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1BA8", Offset = "0x1CC1BA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002474 File Offset: 0x00000674
		[global::Cpp2ILInjected.Token(Token = "0x6000144")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1BB0", Offset = "0x1CC1BB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", ReturnType = typeof(void))]
		public JsonWriterException()
		{
			throw null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002477 File Offset: 0x00000677
		[global::Cpp2ILInjected.Token(Token = "0x6000145")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1BB4", Offset = "0x1CC1BB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public JsonWriterException(string message)
		{
			throw null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000247A File Offset: 0x0000067A
		[global::Cpp2ILInjected.Token(Token = "0x6000146")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1BB8", Offset = "0x1CC1BB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public JsonWriterException(string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000247D File Offset: 0x0000067D
		[global::Cpp2ILInjected.Token(Token = "0x6000147")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1BBC", Offset = "0x1CC1BBC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		public JsonWriterException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002480 File Offset: 0x00000680
		[global::Cpp2ILInjected.Token(Token = "0x6000148")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1BC0", Offset = "0x1CC1BC0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal JsonWriterException(string message, Exception innerException, string path)
		{
			throw null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002483 File Offset: 0x00000683
		[global::Cpp2ILInjected.Token(Token = "0x6000149")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0410", Offset = "0x1CC0410", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEnd", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "get_WriteState", ReturnType = typeof(WriteState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteConstructorDate", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteEnd", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "GetCloseTokenForType", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "CreateUnsupportedTypeException", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteStartConstructor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteRawValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteObjectId", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex)
		{
			throw null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002486 File Offset: 0x00000686
		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1BE4", Offset = "0x1CC1BE4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static JsonWriterException Create(string path, string message, Exception ex)
		{
			throw null;
		}

		// Token: 0x040000C4 RID: 196
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string <Path>k__BackingField;
	}
}
