﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B7 RID: 439
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001C4")]
	public class AppleMFiMicroGamepadNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007F8 RID: 2040 RVA: 0x00003815 File Offset: 0x00001A15
		[global::Cpp2ILInjected.Token(Token = "0x6000815")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A36704", Offset = "0x1A36704", Length = "0x584")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt32), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(OptionalUInt32))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00003818 File Offset: 0x00001A18
		[global::Cpp2ILInjected.Token(Token = "0x6000816")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A36C88", Offset = "0x1A36C88", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AppleMFiMicroGamepadNativeProfile()
		{
			throw null;
		}
	}
}