﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x0200013D RID: 317
	[global::Cpp2ILInjected.Token(Token = "0x2000165")]
	[Serializable]
	internal class PersistentCallGroup
	{
		// Token: 0x06000670 RID: 1648 RVA: 0x00002ED8 File Offset: 0x000010D8
		[global::Cpp2ILInjected.Token(Token = "0x60006AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91654", Offset = "0x1F91654", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public PersistentCallGroup()
		{
			throw null;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002EDB File Offset: 0x000010DB
		[global::Cpp2ILInjected.Token(Token = "0x60006AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F916D4", Offset = "0x1F916D4", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "RebuildPersistentCallsIfNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(List<BaseInvokableCall>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentCall), Member = "IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new object[] { typeof(UnityEventBase) }, ReturnType = typeof(BaseInvokableCall))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCallList), Member = "AddPersistentInvokableCall", MemberParameters = new object[] { typeof(BaseInvokableCall) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
		{
			throw null;
		}

		// Token: 0x04000607 RID: 1543
		[SerializeField]
		[FormerlySerializedAs("m_Listeners")]
		[global::Cpp2ILInjected.Token(Token = "0x400065E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<PersistentCall> m_Calls;
	}
}
