﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000CB RID: 203
	[global::Cpp2ILInjected.Token(Token = "0x20000F7")]
	internal class Datatype_day : Datatype_dateTimeBase
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x000047A5 File Offset: 0x000029A5
		[global::Cpp2ILInjected.Token(Token = "0x1700024F")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000904")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0B90", Offset = "0x1DC0B90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000047A8 File Offset: 0x000029A8
		[global::Cpp2ILInjected.Token(Token = "0x6000905")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0B98", Offset = "0x1DC0B98", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new object[] { typeof(XsdDateTimeFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Datatype_day()
		{
			throw null;
		}
	}
}
