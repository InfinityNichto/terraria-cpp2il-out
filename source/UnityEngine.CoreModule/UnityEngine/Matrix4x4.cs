﻿using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B9 RID: 185
	[DefaultMember("Item")]
	[NativeClass("Matrix4x4f")]
	[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[Il2CppEagerStaticClassConstruction]
	[global::Cpp2ILInjected.Token(Token = "0x20000CB")]
	public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
	{
		// Token: 0x0600039A RID: 922 RVA: 0x000027C1 File Offset: 0x000009C1
		[global::Cpp2ILInjected.Token(Token = "0x60003AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F93C", Offset = "0x1F7F93C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
		{
			throw null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000027C4 File Offset: 0x000009C4
		[global::Cpp2ILInjected.Token(Token = "0x60003AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F958", Offset = "0x1F7F958", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000027C7 File Offset: 0x000009C7
		[global::Cpp2ILInjected.Token(Token = "0x60003B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7FBC0", Offset = "0x1F7FBC0", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000027CA File Offset: 0x000009CA
		[global::Cpp2ILInjected.Token(Token = "0x60003B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7FD34", Offset = "0x1F7FD34", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public bool Equals(Matrix4x4 other)
		{
			throw null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000027CD File Offset: 0x000009CD
		[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7FAEC", Offset = "0x1F7FAEC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Vector4 GetColumn(int index)
		{
			throw null;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000027D0 File Offset: 0x000009D0
		[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7FE3C", Offset = "0x1F7FE3C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public Vector3 MultiplyPoint(Vector3 point)
		{
			throw null;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000027D3 File Offset: 0x000009D3
		[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7FEBC", Offset = "0x1F7FEBC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "InternalGetBounds", MemberParameters = new object[]
		{
			"UnityEngine.Vector3[]",
			typeof(ref Matrix4x4)
		}, ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Vector3 MultiplyPoint3x4(Vector3 point)
		{
			throw null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000027D6 File Offset: 0x000009D6
		[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7FF14", Offset = "0x1F7FF14", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000027D9 File Offset: 0x000009D9
		[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7FF20", Offset = "0x1F7FF20", Length = "0x43C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000027DC File Offset: 0x000009DC
		[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8035C", Offset = "0x1F8035C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WaterRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAWorldCameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			throw null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000027DF File Offset: 0x000009DF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8048C", Offset = "0x1F8048C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Matrix4x4()
		{
			throw null;
		}

		// Token: 0x060003A5 RID: 933
		[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80408", Offset = "0x1F80408", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret);

		// Token: 0x04000359 RID: 857
		[NativeName("m_Data[0]")]
		[global::Cpp2ILInjected.Token(Token = "0x4000391")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float m00;

		// Token: 0x0400035A RID: 858
		[NativeName("m_Data[1]")]
		[global::Cpp2ILInjected.Token(Token = "0x4000392")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float m10;

		// Token: 0x0400035B RID: 859
		[NativeName("m_Data[2]")]
		[global::Cpp2ILInjected.Token(Token = "0x4000393")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float m20;

		// Token: 0x0400035C RID: 860
		[NativeName("m_Data[3]")]
		[global::Cpp2ILInjected.Token(Token = "0x4000394")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float m30;

		// Token: 0x0400035D RID: 861
		[NativeName("m_Data[4]")]
		[global::Cpp2ILInjected.Token(Token = "0x4000395")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float m01;

		// Token: 0x0400035E RID: 862
		[NativeName("m_Data[5]")]
		[global::Cpp2ILInjected.Token(Token = "0x4000396")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float m11;

		// Token: 0x0400035F RID: 863
		[NativeName("m_Data[6]")]
		[global::Cpp2ILInjected.Token(Token = "0x4000397")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float m21;

		// Token: 0x04000360 RID: 864
		[NativeName("m_Data[7]")]
		[global::Cpp2ILInjected.Token(Token = "0x4000398")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float m31;

		// Token: 0x04000361 RID: 865
		[NativeName("m_Data[8]")]
		[global::Cpp2ILInjected.Token(Token = "0x4000399")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float m02;

		// Token: 0x04000362 RID: 866
		[NativeName("m_Data[9]")]
		[global::Cpp2ILInjected.Token(Token = "0x400039A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float m12;

		// Token: 0x04000363 RID: 867
		[NativeName("m_Data[10]")]
		[global::Cpp2ILInjected.Token(Token = "0x400039B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public float m22;

		// Token: 0x04000364 RID: 868
		[NativeName("m_Data[11]")]
		[global::Cpp2ILInjected.Token(Token = "0x400039C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float m32;

		// Token: 0x04000365 RID: 869
		[NativeName("m_Data[12]")]
		[global::Cpp2ILInjected.Token(Token = "0x400039D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float m03;

		// Token: 0x04000366 RID: 870
		[NativeName("m_Data[13]")]
		[global::Cpp2ILInjected.Token(Token = "0x400039E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float m13;

		// Token: 0x04000367 RID: 871
		[NativeName("m_Data[14]")]
		[global::Cpp2ILInjected.Token(Token = "0x400039F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public float m23;

		// Token: 0x04000368 RID: 872
		[NativeName("m_Data[15]")]
		[global::Cpp2ILInjected.Token(Token = "0x40003A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float m33;

		// Token: 0x04000369 RID: 873
		[global::Cpp2ILInjected.Token(Token = "0x40003A1")]
		private static readonly Matrix4x4 zeroMatrix;

		// Token: 0x0400036A RID: 874
		[global::Cpp2ILInjected.Token(Token = "0x40003A2")]
		private static readonly Matrix4x4 identityMatrix;
	}
}