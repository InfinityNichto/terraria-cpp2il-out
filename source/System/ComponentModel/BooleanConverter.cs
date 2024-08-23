﻿using System;
using System.Collections;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200025F RID: 607
	[global::Cpp2ILInjected.Token(Token = "0x2000353")]
	public class BooleanConverter : TypeConverter
	{
		// Token: 0x06001409 RID: 5129 RVA: 0x00006764 File Offset: 0x00004964
		[global::Cpp2ILInjected.Token(Token = "0x600164B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FB70", Offset = "0x1E3FB70", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			throw null;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00006767 File Offset: 0x00004967
		[global::Cpp2ILInjected.Token(Token = "0x600164C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FC38", Offset = "0x1E3FC38", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0000676A File Offset: 0x0000496A
		[global::Cpp2ILInjected.Token(Token = "0x600164D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FE30", Offset = "0x1E3FE30", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0000676D File Offset: 0x0000496D
		[global::Cpp2ILInjected.Token(Token = "0x600164E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FF70", Offset = "0x1E3FF70", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00006770 File Offset: 0x00004970
		[global::Cpp2ILInjected.Token(Token = "0x600164F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FF78", Offset = "0x1E3FF78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00006773 File Offset: 0x00004973
		[global::Cpp2ILInjected.Token(Token = "0x6001650")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FF80", Offset = "0x1E3FF80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public BooleanConverter()
		{
			throw null;
		}

		// Token: 0x04000DD4 RID: 3540
		[global::Cpp2ILInjected.Token(Token = "0x40011D7")]
		private static TypeConverter.StandardValuesCollection s_values;
	}
}
