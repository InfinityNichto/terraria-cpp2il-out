﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using UnityEngine;

namespace InterfaceMovement
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	public class ButtonManager : MonoBehaviour
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002107 File Offset: 0x00000307
		[global::Cpp2ILInjected.Token(Token = "0x600003E")]
		[global::Cpp2ILInjected.Address(RVA = "0x198F654", Offset = "0x198F654", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = "set_StateThreshold", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000210A File Offset: 0x0000030A
		[global::Cpp2ILInjected.Token(Token = "0x600003F")]
		[global::Cpp2ILInjected.Address(RVA = "0x198F6B8", Offset = "0x198F6B8", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Direction", ReturnType = typeof(TwoAxisInputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = "Filter", MemberParameters = new object[]
		{
			typeof(TwoAxisInputControl),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_WasRepeated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_WasPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ButtonManager), Member = "MoveFocusTo", MemberParameters = new object[] { typeof(Button) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000210D File Offset: 0x0000030D
		[global::Cpp2ILInjected.Token(Token = "0x6000040")]
		[global::Cpp2ILInjected.Address(RVA = "0x198F828", Offset = "0x198F828", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ButtonManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void MoveFocusTo(Button newFocusedButton)
		{
			throw null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002110 File Offset: 0x00000310
		[global::Cpp2ILInjected.Token(Token = "0x6000041")]
		[global::Cpp2ILInjected.Address(RVA = "0x198F89C", Offset = "0x198F89C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		public ButtonManager()
		{
			throw null;
		}

		// Token: 0x04000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Button focusedButton;

		// Token: 0x04000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TwoAxisInputControl filteredDirection;
	}
}