﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using UnityEngine;

namespace MultiplayerWithBindingsExample
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public class Player : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002083 File Offset: 0x00000283
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002086 File Offset: 0x00000286
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public PlayerActions Actions
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000012")]
			[global::Cpp2ILInjected.Address(RVA = "0x198D204", Offset = "0x198D204", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000013")]
			[global::Cpp2ILInjected.Address(RVA = "0x198D20C", Offset = "0x198D20C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002089 File Offset: 0x00000289
		[global::Cpp2ILInjected.Token(Token = "0x6000014")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D214", Offset = "0x198D214", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "Destroy", ReturnType = typeof(void))]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000208C File Offset: 0x0000028C
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D228", Offset = "0x198D228", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000208F File Offset: 0x0000028F
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D278", Offset = "0x198D278", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "get_material", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetColorFromInput", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "Rotate", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float),
			typeof(Space)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002092 File Offset: 0x00000292
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D408", Offset = "0x198D408", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "op_Implicit", MemberParameters = new object[] { typeof(OneAxisInputControl) }, ReturnType = typeof(bool))]
		private Color GetColorFromInput()
		{
			throw null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002095 File Offset: 0x00000295
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D4B4", Offset = "0x198D4B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		public Player()
		{
			throw null;
		}

		// Token: 0x0400000B RID: 11
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private PlayerActions <Actions>k__BackingField;

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Renderer cachedRenderer;
	}
}
