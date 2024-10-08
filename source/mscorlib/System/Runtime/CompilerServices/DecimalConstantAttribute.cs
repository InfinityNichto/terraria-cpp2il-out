﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Field | global::System.AttributeTargets.Parameter, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200046E")]
	[global::System.Serializable]
	public sealed class DecimalConstantAttribute : global::System.Attribute
	{
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600220B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73374", Offset = "0x1B73374", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000467")]
		public decimal Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600220C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73410", Offset = "0x1B73410", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private decimal _dec;
	}
}
