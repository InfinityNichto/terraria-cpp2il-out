﻿using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000017 RID: 23
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	public struct UnknownDeviceControl : IEquatable<UnknownDeviceControl>
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00002390 File Offset: 0x00000590
		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984B98", Offset = "0x1984B98", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceControl), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "GetFirstPressedAnalog", ReturnType = typeof(UnknownDeviceControl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "GetFirstPressedButton", ReturnType = typeof(UnknownDeviceControl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "TargetIsButton", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UnknownDeviceControl(InputControlType control, InputRangeType sourceRange)
		{
			throw null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002393 File Offset: 0x00000593
		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983A70", Offset = "0x1983A70", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSource), Member = "GetValue", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSourceListener), Member = "IsPressed", MemberParameters = new object[]
		{
			typeof(UnknownDeviceControl),
			typeof(InputDevice)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputRange), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(InputRangeType),
			typeof(InputRangeType)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal float GetValue(InputDevice device)
		{
			throw null;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002396 File Offset: 0x00000596
		[global::Cpp2ILInjected.Token(Token = "0x17000048")]
		public int Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x600010F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1984CB4", Offset = "0x1984CB4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002399 File Offset: 0x00000599
		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983F40", Offset = "0x1983F40", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(UnknownDeviceControl a, UnknownDeviceControl b)
		{
			throw null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000239C File Offset: 0x0000059C
		[global::Cpp2ILInjected.Token(Token = "0x6000111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984CFC", Offset = "0x1984CFC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator !=(UnknownDeviceControl a, UnknownDeviceControl b)
		{
			throw null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000239F File Offset: 0x0000059F
		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984CD4", Offset = "0x1984CD4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(UnknownDeviceControl other)
		{
			throw null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000023A2 File Offset: 0x000005A2
		[global::Cpp2ILInjected.Token(Token = "0x6000113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984D94", Offset = "0x1984D94", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000023A5 File Offset: 0x000005A5
		[global::Cpp2ILInjected.Token(Token = "0x6000114")]
		[global::Cpp2ILInjected.Address(RVA = "0x19840DC", Offset = "0x19840DC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000023A8 File Offset: 0x000005A8
		[global::Cpp2ILInjected.Token(Token = "0x6000115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984750", Offset = "0x1984750", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator bool(UnknownDeviceControl control)
		{
			throw null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000023AB File Offset: 0x000005AB
		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984E2C", Offset = "0x1984E2C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000023AE File Offset: 0x000005AE
		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984348", Offset = "0x1984348", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000023B1 File Offset: 0x000005B1
		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984254", Offset = "0x1984254", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSource), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "TargetIsButton", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Load(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000023B4 File Offset: 0x000005B4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984EFC", Offset = "0x1984EFC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnknownDeviceControl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(InputRangeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static UnknownDeviceControl()
		{
			throw null;
		}

		// Token: 0x04000106 RID: 262
		[global::Cpp2ILInjected.Token(Token = "0x400010A")]
		public static readonly UnknownDeviceControl None;

		// Token: 0x04000107 RID: 263
		[global::Cpp2ILInjected.Token(Token = "0x400010B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public InputControlType Control;

		// Token: 0x04000108 RID: 264
		[global::Cpp2ILInjected.Token(Token = "0x400010C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public InputRangeType SourceRange;

		// Token: 0x04000109 RID: 265
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public bool IsButton;

		// Token: 0x0400010A RID: 266
		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
		public bool IsAnalog;
	}
}
