﻿using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000B3 RID: 179
	[global::Cpp2ILInjected.Token(Token = "0x20000DF")]
	internal class Datatype_List : Datatype_anySimpleType
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x00004643 File Offset: 0x00002843
		[global::Cpp2ILInjected.Token(Token = "0x600088E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC5F0", Offset = "0x1DBC5F0", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new object[] { typeof(XmlTypeCode) }, ReturnType = typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlListConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlValueConverter) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00004646 File Offset: 0x00002846
		[global::Cpp2ILInjected.Token(Token = "0x600088F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC150", Offset = "0x1DBC150", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "DeriveByList", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSchemaType)
		}, ReturnType = typeof(XmlSchemaDatatype))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Datatype_List(DatatypeImplementation type, int minListSize)
		{
			throw null;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00004649 File Offset: 0x00002849
		[global::Cpp2ILInjected.Token(Token = "0x6000890")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC880", Offset = "0x1DBC880", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0000464C File Offset: 0x0000284C
		[global::Cpp2ILInjected.Token(Token = "0x17000217")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000891")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBCAC4", Offset = "0x1DBCAC4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0000464F File Offset: 0x0000284F
		[global::Cpp2ILInjected.Token(Token = "0x17000218")]
		public override XmlTokenizedType TokenizedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000892")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBCAD4", Offset = "0x1DBCAD4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00004652 File Offset: 0x00002852
		[global::Cpp2ILInjected.Token(Token = "0x17000219")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000893")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBCAE4", Offset = "0x1DBCAE4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00004655 File Offset: 0x00002855
		[global::Cpp2ILInjected.Token(Token = "0x1700021A")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000894")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBCAF8", Offset = "0x1DBCAF8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00004658 File Offset: 0x00002858
		[global::Cpp2ILInjected.Token(Token = "0x1700021B")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000895")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBCB50", Offset = "0x1DBCB50", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0000465B File Offset: 0x0000285B
		[global::Cpp2ILInjected.Token(Token = "0x6000896")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBCB60", Offset = "0x1DBCB60", Length = "0x13E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "SplitString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x04000352 RID: 850
		[global::Cpp2ILInjected.Token(Token = "0x40004CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private DatatypeImplementation itemType;

		// Token: 0x04000353 RID: 851
		[global::Cpp2ILInjected.Token(Token = "0x40004CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int minListSize;
	}
}