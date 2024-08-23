﻿using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000078 RID: 120
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000085")]
	public struct Plane : IFormattable
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000246D File Offset: 0x0000066D
		[global::Cpp2ILInjected.Token(Token = "0x1700007A")]
		public Vector3 normal
		{
			[global::Cpp2ILInjected.Token(Token = "0x600023B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F775C8", Offset = "0x1F775C8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(Vector2),
				typeof(Camera),
				typeof(ref Vector3)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002470 File Offset: 0x00000670
		[global::Cpp2ILInjected.Token(Token = "0x600023C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F775D4", Offset = "0x1F775D4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector3)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Plane(Vector3 inNormal, Vector3 inPoint)
		{
			throw null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002473 File Offset: 0x00000673
		[global::Cpp2ILInjected.Token(Token = "0x600023D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F776E4", Offset = "0x1F776E4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector3)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Raycast(Ray ray, out float enter)
		{
			throw null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002476 File Offset: 0x00000676
		[global::Cpp2ILInjected.Token(Token = "0x600023E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F777FC", Offset = "0x1F777FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002479 File Offset: 0x00000679
		[global::Cpp2ILInjected.Token(Token = "0x600023F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77808", Offset = "0x1F77808", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x040002EC RID: 748
		[global::Cpp2ILInjected.Token(Token = "0x4000317")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Vector3 m_Normal;

		// Token: 0x040002ED RID: 749
		[global::Cpp2ILInjected.Token(Token = "0x4000318")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private float m_Distance;
	}
}
