﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E2 RID: 226
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
	public class XboxOneMacChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x00003317 File Offset: 0x00001517
		[global::Cpp2ILInjected.Token(Token = "0x600066B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A0047C", Offset = "0x1A0047C", Length = "0xD00")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 99)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0000331A File Offset: 0x0000151A
		[global::Cpp2ILInjected.Token(Token = "0x600066C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A0117C", Offset = "0x1A0117C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XboxOneMacChromeUnityProfile()
		{
			throw null;
		}
	}
}
