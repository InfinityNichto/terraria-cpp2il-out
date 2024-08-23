﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000140 RID: 320
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200014D")]
	public class HoriXbox360GemPadExMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600070A RID: 1802 RVA: 0x0000354B File Offset: 0x0000174B
		[global::Cpp2ILInjected.Token(Token = "0x6000727")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A234E8", Offset = "0x1A234E8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0000354E File Offset: 0x0000174E
		[global::Cpp2ILInjected.Token(Token = "0x6000728")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A235B4", Offset = "0x1A235B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriXbox360GemPadExMacNativeProfile()
		{
			throw null;
		}
	}
}
