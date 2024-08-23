﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000252 RID: 594
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000344")]
	public sealed class ReadOnlyAttribute : Attribute
	{
		// Token: 0x0600137F RID: 4991 RVA: 0x000065E1 File Offset: 0x000047E1
		[global::Cpp2ILInjected.Token(Token = "0x60015BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CFEC", Offset = "0x1E3CFEC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ReadOnlyAttribute(bool isReadOnly)
		{
			throw null;
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x000065E4 File Offset: 0x000047E4
		[global::Cpp2ILInjected.Token(Token = "0x170004F4")]
		public bool IsReadOnly
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3D014", Offset = "0x1E3D014", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x000065E7 File Offset: 0x000047E7
		[global::Cpp2ILInjected.Token(Token = "0x60015C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3D01C", Offset = "0x1E3D01C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x000065EA File Offset: 0x000047EA
		[global::Cpp2ILInjected.Token(Token = "0x60015C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3D100", Offset = "0x1E3D100", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x000065ED File Offset: 0x000047ED
		[global::Cpp2ILInjected.Token(Token = "0x60015C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3D108", Offset = "0x1E3D108", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x000065F0 File Offset: 0x000047F0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3D180", Offset = "0x1E3D180", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ReadOnlyAttribute()
		{
			throw null;
		}

		// Token: 0x04000DAC RID: 3500
		[global::Cpp2ILInjected.Token(Token = "0x40011AC")]
		public static readonly ReadOnlyAttribute Yes;

		// Token: 0x04000DAD RID: 3501
		[global::Cpp2ILInjected.Token(Token = "0x40011AD")]
		public static readonly ReadOnlyAttribute No;

		// Token: 0x04000DAE RID: 3502
		[global::Cpp2ILInjected.Token(Token = "0x40011AE")]
		public static readonly ReadOnlyAttribute Default;

		// Token: 0x04000DAF RID: 3503
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <IsReadOnly>k__BackingField;
	}
}