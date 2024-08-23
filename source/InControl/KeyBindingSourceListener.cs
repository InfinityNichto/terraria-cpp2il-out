﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x0200000B RID: 11
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public class KeyBindingSourceListener : BindingSourceListener
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0000212F File Offset: 0x0000032F
		[global::Cpp2ILInjected.Token(Token = "0x6000042")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AFDC", Offset = "0x197AFDC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002132 File Offset: 0x00000332
		[global::Cpp2ILInjected.Token(Token = "0x6000043")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B008", Offset = "0x197B008", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyCombo), Member = "get_IsPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyCombo), Member = "Detect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(KeyCombo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			throw null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002135 File Offset: 0x00000335
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B34C", Offset = "0x197B34C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public KeyBindingSourceListener()
		{
			throw null;
		}

		// Token: 0x040000A6 RID: 166
		[global::Cpp2ILInjected.Token(Token = "0x40000A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private KeyCombo detectFound;

		// Token: 0x040000A7 RID: 167
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int detectPhase;
	}
}
