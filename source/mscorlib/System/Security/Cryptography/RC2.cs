﻿using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200024D RID: 589
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002EA")]
	public abstract class RC2 : SymmetricAlgorithm
	{
		// Token: 0x060016F2 RID: 5874 RVA: 0x0001856C File Offset: 0x0001676C
		[global::Cpp2ILInjected.Token(Token = "0x600190C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01CB8", Offset = "0x1B01CB8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected RC2()
		{
			throw null;
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0001856F File Offset: 0x0001676F
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x00018572 File Offset: 0x00016772
		[global::Cpp2ILInjected.Token(Token = "0x170002B0")]
		public virtual int EffectiveKeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600190D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B01D34", Offset = "0x1B01D34", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600190E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B01D50", Offset = "0x1B01D50", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00018575 File Offset: 0x00016775
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x00018578 File Offset: 0x00016778
		[global::Cpp2ILInjected.Token(Token = "0x170002B1")]
		public override int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600190F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B01E00", Offset = "0x1B01E00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001910")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B01E08", Offset = "0x1B01E08", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0001857B File Offset: 0x0001677B
		[global::Cpp2ILInjected.Token(Token = "0x6001911")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01E78", Offset = "0x1B01E78", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RC2CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static RC2 Create()
		{
			throw null;
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0001857E File Offset: 0x0001677E
		[global::Cpp2ILInjected.Token(Token = "0x6001912")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0204C", Offset = "0x1B0204C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static RC2 Create(string AlgName)
		{
			throw null;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00018581 File Offset: 0x00016781
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001913")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B020F0", Offset = "0x1B020F0", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static RC2()
		{
			throw null;
		}

		// Token: 0x040009F5 RID: 2549
		[global::Cpp2ILInjected.Token(Token = "0x4000CCF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		protected int EffectiveKeySizeValue;

		// Token: 0x040009F6 RID: 2550
		[global::Cpp2ILInjected.Token(Token = "0x4000CD0")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x040009F7 RID: 2551
		[global::Cpp2ILInjected.Token(Token = "0x4000CD1")]
		private static KeySizes[] s_legalKeySizes;
	}
}
