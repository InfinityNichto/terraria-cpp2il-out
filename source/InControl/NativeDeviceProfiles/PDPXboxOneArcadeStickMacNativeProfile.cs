﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200017E RID: 382
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200018B")]
	public class PDPXboxOneArcadeStickMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06000786 RID: 1926 RVA: 0x000036BF File Offset: 0x000018BF
		[global::Cpp2ILInjected.Token(Token = "0x60007A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A285BC", Offset = "0x1A285BC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000036C2 File Offset: 0x000018C2
		[global::Cpp2ILInjected.Token(Token = "0x60007A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28688", Offset = "0x1A28688", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public PDPXboxOneArcadeStickMacNativeProfile()
		{
			throw null;
		}
	}
}
