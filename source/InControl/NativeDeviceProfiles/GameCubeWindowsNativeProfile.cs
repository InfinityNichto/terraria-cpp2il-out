﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C2 RID: 450
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001CF")]
	public class GameCubeWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600080E RID: 2062 RVA: 0x00003857 File Offset: 0x00001A57
		[global::Cpp2ILInjected.Token(Token = "0x600082B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A3D408", Offset = "0x1A3D408", Length = "0x9EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 76)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0000385A File Offset: 0x00001A5A
		[global::Cpp2ILInjected.Token(Token = "0x600082C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A3DDF4", Offset = "0x1A3DDF4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GameCubeWindowsNativeProfile()
		{
			throw null;
		}
	}
}
