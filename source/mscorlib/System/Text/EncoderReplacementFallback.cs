﻿using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001ED RID: 493
	[global::Cpp2ILInjected.Token(Token = "0x2000272")]
	[global::System.Serializable]
	public sealed class EncoderReplacementFallback : EncoderFallback, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06001358 RID: 4952 RVA: 0x00017B3D File Offset: 0x00015D3D
		[global::Cpp2ILInjected.Token(Token = "0x6001512")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD164C", Offset = "0x1AD164C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(EncoderFallback))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public EncoderReplacementFallback()
		{
			throw null;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00017B40 File Offset: 0x00015D40
		[global::Cpp2ILInjected.Token(Token = "0x6001513")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1830", Offset = "0x1AD1830", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal EncoderReplacementFallback(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00017B43 File Offset: 0x00015D43
		[global::Cpp2ILInjected.Token(Token = "0x6001514")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1928", Offset = "0x1AD1928", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00017B46 File Offset: 0x00015D46
		[global::Cpp2ILInjected.Token(Token = "0x6001515")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1694", Offset = "0x1AD1694", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			"System.UriComponents"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			"System.Char[]",
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char),
			"System.UnescapeMode",
			"System.UriParser",
			typeof(bool)
		}, ReturnType = "System.Char[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextAsset.EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public EncoderReplacementFallback(string replacement)
		{
			throw null;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00017B49 File Offset: 0x00015D49
		[global::Cpp2ILInjected.Token(Token = "0x1700021F")]
		public string DefaultString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001516")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD1984", Offset = "0x1AD1984", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00017B4C File Offset: 0x00015D4C
		[global::Cpp2ILInjected.Token(Token = "0x6001517")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD198C", Offset = "0x1AD198C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			throw null;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00017B4F File Offset: 0x00015D4F
		[global::Cpp2ILInjected.Token(Token = "0x17000220")]
		public override int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001518")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD1A40", Offset = "0x1AD1A40", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00017B52 File Offset: 0x00015D52
		[global::Cpp2ILInjected.Token(Token = "0x6001519")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1A4C", Offset = "0x1AD1A4C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00017B55 File Offset: 0x00015D55
		[global::Cpp2ILInjected.Token(Token = "0x600151A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1AC0", Offset = "0x1AD1AC0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x040008AB RID: 2219
		[global::Cpp2ILInjected.Token(Token = "0x4000B17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _strDefault;
	}
}
