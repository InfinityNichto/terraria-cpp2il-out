﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using UnityEngine;

namespace VirtualDeviceExample
{
	// Token: 0x02000003 RID: 3
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	public class VirtualDeviceExample : MonoBehaviour
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002065 File Offset: 0x00000265
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x198C730", Offset = "0x198C730", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualDevice), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnSetup", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x198C804", Offset = "0x198C804", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "DetachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000206B File Offset: 0x0000026B
		[global::Cpp2ILInjected.Token(Token = "0x600000A")]
		[global::Cpp2ILInjected.Address(RVA = "0x198C860", Offset = "0x198C860", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickX", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "op_Implicit", MemberParameters = new object[] { typeof(OneAxisInputControl) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "Rotate", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float),
			typeof(Space)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickY", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightStickX", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightStickY", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action1", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_IsPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action2", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action3", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action4", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "get_material", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206E File Offset: 0x0000026E
		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x198CC08", Offset = "0x198CC08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		public VirtualDeviceExample()
		{
			throw null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002071 File Offset: 0x00000271
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x198CC10", Offset = "0x198CC10", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AttachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void <OnEnable>b__3_0()
		{
			throw null;
		}

		// Token: 0x04000007 RID: 7
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public GameObject leftObject;

		// Token: 0x04000008 RID: 8
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GameObject rightObject;

		// Token: 0x04000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private VirtualDevice virtualDevice;
	}
}
