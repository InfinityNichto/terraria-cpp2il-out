﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014A RID: 330
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000157")]
	public class LogitechF510ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600071E RID: 1822 RVA: 0x00003587 File Offset: 0x00001787
		[global::Cpp2ILInjected.Token(Token = "0x600073B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23D58", Offset = "0x1A23D58", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0000358A File Offset: 0x0000178A
		[global::Cpp2ILInjected.Token(Token = "0x600073C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23E24", Offset = "0x1A23E24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public LogitechF510ControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
