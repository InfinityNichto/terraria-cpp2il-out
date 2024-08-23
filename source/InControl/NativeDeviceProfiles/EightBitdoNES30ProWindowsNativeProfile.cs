﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001BD RID: 445
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001CA")]
	public class EightBitdoNES30ProWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000804 RID: 2052 RVA: 0x00003839 File Offset: 0x00001A39
		[global::Cpp2ILInjected.Token(Token = "0x6000821")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A3A150", Offset = "0x1A3A150", Length = "0xBA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 88)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0000383C File Offset: 0x00001A3C
		[global::Cpp2ILInjected.Token(Token = "0x6000822")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A3ACF4", Offset = "0x1A3ACF4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoNES30ProWindowsNativeProfile()
		{
			throw null;
		}
	}
}