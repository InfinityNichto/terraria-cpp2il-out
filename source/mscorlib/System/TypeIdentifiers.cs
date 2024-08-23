﻿using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200014F RID: 335
	[global::Cpp2ILInjected.Token(Token = "0x2000199")]
	internal class TypeIdentifiers
	{
		// Token: 0x06000ECD RID: 3789 RVA: 0x00016EEF File Offset: 0x000150EF
		[global::Cpp2ILInjected.Token(Token = "0x6000FC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89798", Offset = "0x1C89798", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(global::System.RuntimeType[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "AddName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "ParsedTypeIdentifier", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TypeIdentifier))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static global::System.TypeIdentifier FromDisplay(string displayName)
		{
			throw null;
		}

		// Token: 0x0200059D RID: 1437
		[global::Cpp2ILInjected.Token(Token = "0x200019A")]
		private class Display : global::System.TypeNames.ATypeName, global::System.TypeIdentifier, global::System.TypeName, global::System.IEquatable<global::System.TypeName>
		{
			// Token: 0x06003FE7 RID: 16359 RVA: 0x0001FA6C File Offset: 0x0001DC6C
			[global::Cpp2ILInjected.Token(Token = "0x6000FC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C897E4", Offset = "0x1C897E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal Display(string displayName)
			{
				throw null;
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06003FE8 RID: 16360 RVA: 0x0001FA6F File Offset: 0x0001DC6F
			[global::Cpp2ILInjected.Token(Token = "0x1700016B")]
			public override string DisplayName
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000FC9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C897EC", Offset = "0x1C897EC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x0001FA72 File Offset: 0x0001DC72
			[global::Cpp2ILInjected.Token(Token = "0x1700016C")]
			public string InternalName
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000FCA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C897F4", Offset = "0x1C897F4", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "UnescapeInternalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06003FEA RID: 16362 RVA: 0x0001FA75 File Offset: 0x0001DC75
			[global::Cpp2ILInjected.Token(Token = "0x6000FCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8981C", Offset = "0x1C8981C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "UnescapeInternalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			private string GetInternalName()
			{
				throw null;
			}

			// Token: 0x0400187C RID: 6268
			[global::Cpp2ILInjected.Token(Token = "0x4000880")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string displayName;

			// Token: 0x0400187D RID: 6269
			[global::Cpp2ILInjected.Token(Token = "0x4000881")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string internal_name;
		}
	}
}