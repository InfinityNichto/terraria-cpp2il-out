﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001FA RID: 506
	[global::Cpp2ILInjected.Token(Token = "0x2000288")]
	internal ref struct ValueUtf8Converter
	{
		// Token: 0x06001453 RID: 5203 RVA: 0x00017E28 File Offset: 0x00016028
		[global::Cpp2ILInjected.Token(Token = "0x600162C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3974", Offset = "0x1AE3974", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "Stat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "LStat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public ValueUtf8Converter(global::System.Span<byte> initialBuffer)
		{
			throw null;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00017E2B File Offset: 0x0001602B
		[global::Cpp2ILInjected.Token(Token = "0x600162D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3980", Offset = "0x1AE3980", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "Stat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "LStat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueUtf8Converter), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public global::System.Span<byte> ConvertAndTerminateString(global::System.ReadOnlySpan<char> value)
		{
			throw null;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00017E2E File Offset: 0x0001602E
		[global::Cpp2ILInjected.Token(Token = "0x600162E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3C24", Offset = "0x1AE3C24", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "Stat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "LStat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueUtf8Converter), Member = "ConvertAndTerminateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.Span<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x040008E1 RID: 2273
		[global::Cpp2ILInjected.Token(Token = "0x4000B5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private byte[] _arrayToReturnToPool;

		// Token: 0x040008E2 RID: 2274
		[global::Cpp2ILInjected.Token(Token = "0x4000B5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private global::System.Span<byte> _bytes;
	}
}