﻿using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000141 RID: 321
	[global::Cpp2ILInjected.Token(Token = "0x2000169")]
	[Serializable]
	public class UnityEvent<T0, T1> : UnityEventBase
	{
		// Token: 0x06000689 RID: 1673 RVA: 0x00002F17 File Offset: 0x00001117
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60006C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1897C48", Offset = "0x1897C48", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
		public UnityEvent()
		{
			throw null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002F1A File Offset: 0x0000111A
		[global::Cpp2ILInjected.Token(Token = "0x60006C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1897C54", Offset = "0x1897C54", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			throw null;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00002F1D File Offset: 0x0000111D
		[global::Cpp2ILInjected.Token(Token = "0x60006C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1897D6C", Offset = "0x1897D6C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw null;
		}

		// Token: 0x0400060F RID: 1551
		[global::Cpp2ILInjected.Token(Token = "0x4000666")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object[] m_InvokeArray;
	}
}
