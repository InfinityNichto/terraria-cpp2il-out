﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002EC RID: 748
	[global::Cpp2ILInjected.Token(Token = "0x20003C0")]
	public struct Rgba64 : IPackedVector<ulong>, IPackedVector, IEquatable<Rgba64>
	{
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x000263FF File Offset: 0x000245FF
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x00026402 File Offset: 0x00024602
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700036D")]
		public ulong PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A0B")]
			[global::Cpp2ILInjected.Address(RVA = "0xB41470", Offset = "0xB41470", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A0C")]
			[global::Cpp2ILInjected.Address(RVA = "0xB41478", Offset = "0xB41478", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00026405 File Offset: 0x00024605
		[global::Cpp2ILInjected.Token(Token = "0x6001A0D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41480", Offset = "0xB41480", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rgba64), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ulong))]
		public Rgba64(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00026408 File Offset: 0x00024608
		[global::Cpp2ILInjected.Token(Token = "0x6001A0E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41760", Offset = "0xB41760", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rgba64), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ulong))]
		public Rgba64(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0002640B File Offset: 0x0002460B
		[global::Cpp2ILInjected.Token(Token = "0x6001A0F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41778", Offset = "0xB41778", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba64), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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

		// Token: 0x06001890 RID: 6288 RVA: 0x0002640E File Offset: 0x0002460E
		[global::Cpp2ILInjected.Token(Token = "0x6001A10")]
		[global::Cpp2ILInjected.Address(RVA = "0xB417F0", Offset = "0xB417F0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rgba64), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ulong))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00026411 File Offset: 0x00024611
		[global::Cpp2ILInjected.Token(Token = "0x6001A11")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41808", Offset = "0xB41808", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00026414 File Offset: 0x00024614
		[global::Cpp2ILInjected.Token(Token = "0x6001A12")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41880", Offset = "0xB41880", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Rgba64 other)
		{
			throw null;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00026417 File Offset: 0x00024617
		[global::Cpp2ILInjected.Token(Token = "0x6001A13")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41890", Offset = "0xB41890", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rgba64), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0002641A File Offset: 0x0002461A
		[global::Cpp2ILInjected.Token(Token = "0x6001A14")]
		[global::Cpp2ILInjected.Address(RVA = "0xB418BC", Offset = "0xB418BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0002641D File Offset: 0x0002461D
		[global::Cpp2ILInjected.Token(Token = "0x6001A15")]
		[global::Cpp2ILInjected.Address(RVA = "0xB418C4", Offset = "0xB418C4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Rgba64 lhs, Rgba64 rhs)
		{
			throw null;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00026420 File Offset: 0x00024620
		[global::Cpp2ILInjected.Token(Token = "0x6001A16")]
		[global::Cpp2ILInjected.Address(RVA = "0xB418D0", Offset = "0xB418D0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Rgba64 lhs, Rgba64 rhs)
		{
			throw null;
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00026423 File Offset: 0x00024623
		[global::Cpp2ILInjected.Token(Token = "0x6001A17")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41498", Offset = "0xB41498", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba64), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba64), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba64), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static ulong Pack(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x04002147 RID: 8519
		[global::Cpp2ILInjected.Token(Token = "0x40027AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ulong packedValue;
	}
}
