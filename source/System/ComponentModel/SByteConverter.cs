﻿using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002B9 RID: 697
	[global::Cpp2ILInjected.Token(Token = "0x20003B7")]
	public class SByteConverter : BaseNumberConverter
	{
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x00006EF9 File Offset: 0x000050F9
		[global::Cpp2ILInjected.Token(Token = "0x170005CE")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600195C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5D68C", Offset = "0x1E5D68C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00006EFC File Offset: 0x000050FC
		[global::Cpp2ILInjected.Token(Token = "0x600195D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D6F8", Offset = "0x1E5D6F8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00006EFF File Offset: 0x000050FF
		[global::Cpp2ILInjected.Token(Token = "0x600195E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D78C", Offset = "0x1E5D78C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00006F02 File Offset: 0x00005102
		[global::Cpp2ILInjected.Token(Token = "0x600195F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D800", Offset = "0x1E5D800", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00006F05 File Offset: 0x00005105
		[global::Cpp2ILInjected.Token(Token = "0x6001960")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D8A8", Offset = "0x1E5D8A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public SByteConverter()
		{
			throw null;
		}
	}
}