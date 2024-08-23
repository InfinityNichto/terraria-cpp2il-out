﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002EE RID: 750
	[global::Cpp2ILInjected.Token(Token = "0x20003C2")]
	public struct Short4 : IPackedVector<ulong>, IPackedVector, IEquatable<Short4>
	{
		// Token: 0x060018A6 RID: 6310 RVA: 0x00026450 File Offset: 0x00024650
		[global::Cpp2ILInjected.Token(Token = "0x6001A26")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41C48", Offset = "0xB41C48", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Short4), Member = "Pack", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(ulong))]
		public Short4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00026453 File Offset: 0x00024653
		[global::Cpp2ILInjected.Token(Token = "0x6001A27")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41F6C", Offset = "0xB41F6C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Short4), Member = "Pack", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(ulong))]
		public Short4(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00026456 File Offset: 0x00024656
		[global::Cpp2ILInjected.Token(Token = "0x6001A28")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41FA0", Offset = "0xB41FA0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Short4 a, Short4 b)
		{
			throw null;
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00026459 File Offset: 0x00024659
		[global::Cpp2ILInjected.Token(Token = "0x6001A29")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41FAC", Offset = "0xB41FAC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Short4 a, Short4 b)
		{
			throw null;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x0002645C File Offset: 0x0002465C
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x0002645F File Offset: 0x0002465F
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700036F")]
		public ulong PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A2A")]
			[global::Cpp2ILInjected.Address(RVA = "0xB41FB8", Offset = "0xB41FB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A2B")]
			[global::Cpp2ILInjected.Address(RVA = "0xB41FC0", Offset = "0xB41FC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00026462 File Offset: 0x00024662
		[global::Cpp2ILInjected.Token(Token = "0x6001A2C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41FC8", Offset = "0xB41FC8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00026465 File Offset: 0x00024665
		[global::Cpp2ILInjected.Token(Token = "0x6001A2D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB42040", Offset = "0xB42040", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Short4 other)
		{
			throw null;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00026468 File Offset: 0x00024668
		[global::Cpp2ILInjected.Token(Token = "0x6001A2E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB42050", Offset = "0xB42050", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0002646B File Offset: 0x0002466B
		[global::Cpp2ILInjected.Token(Token = "0x6001A2F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB42058", Offset = "0xB42058", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0002646E File Offset: 0x0002466E
		[global::Cpp2ILInjected.Token(Token = "0x6001A30")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41C74", Offset = "0xB41C74", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Short4), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Short4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Short4), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static ulong Pack(ref Vector4 vector)
		{
			throw null;
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00026471 File Offset: 0x00024671
		[global::Cpp2ILInjected.Token(Token = "0x6001A31")]
		[global::Cpp2ILInjected.Address(RVA = "0xB420A4", Offset = "0xB420A4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Short4), Member = "Pack", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(ulong))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00026474 File Offset: 0x00024674
		[global::Cpp2ILInjected.Token(Token = "0x6001A32")]
		[global::Cpp2ILInjected.Address(RVA = "0xB420D0", Offset = "0xB420D0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Vector4 ToVector4()
		{
			throw null;
		}

		// Token: 0x04002149 RID: 8521
		[global::Cpp2ILInjected.Token(Token = "0x40027AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ulong packedValue;
	}
}
