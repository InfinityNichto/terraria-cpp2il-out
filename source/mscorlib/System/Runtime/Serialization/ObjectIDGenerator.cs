﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000333 RID: 819
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003DB")]
	[global::System.Serializable]
	public class ObjectIDGenerator
	{
		// Token: 0x06001CDD RID: 7389 RVA: 0x000195A1 File Offset: 0x000177A1
		[global::Cpp2ILInjected.Token(Token = "0x6001F1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5465C", Offset = "0x1B5465C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ObjectIDGenerator()
		{
			throw null;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x000195A4 File Offset: 0x000177A4
		[global::Cpp2ILInjected.Token(Token = "0x6001F1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54728", Offset = "0x1B54728", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectIDGenerator), Member = "GetId", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectIDGenerator), Member = "HasId", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectIDGenerator), Member = "Rehash", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		private int FindElement(object obj, out bool found)
		{
			throw null;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x000195A7 File Offset: 0x000177A7
		[global::Cpp2ILInjected.Token(Token = "0x6001F1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B547D4", Offset = "0x1B547D4", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectIDGenerator), Member = "FindElement", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectIDGenerator), Member = "Rehash", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual long GetId(object obj, out bool firstTime)
		{
			throw null;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x000195AA File Offset: 0x000177AA
		[global::Cpp2ILInjected.Token(Token = "0x6001F1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54B30", Offset = "0x1B54B30", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectIDGenerator), Member = "FindElement", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual long HasId(object obj, out bool firstTime)
		{
			throw null;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x000195AD File Offset: 0x000177AD
		[global::Cpp2ILInjected.Token(Token = "0x6001F1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5490C", Offset = "0x1B5490C", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectIDGenerator), Member = "GetId", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectIDGenerator), Member = "FindElement", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void Rehash()
		{
			throw null;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x000195B0 File Offset: 0x000177B0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001F20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54BE8", Offset = "0x1B54BE8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ObjectIDGenerator()
		{
			throw null;
		}

		// Token: 0x04000CA3 RID: 3235
		[global::Cpp2ILInjected.Token(Token = "0x4000F95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int m_currentCount;

		// Token: 0x04000CA4 RID: 3236
		[global::Cpp2ILInjected.Token(Token = "0x4000F96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int m_currentSize;

		// Token: 0x04000CA5 RID: 3237
		[global::Cpp2ILInjected.Token(Token = "0x4000F97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal long[] m_ids;

		// Token: 0x04000CA6 RID: 3238
		[global::Cpp2ILInjected.Token(Token = "0x4000F98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal object[] m_objs;

		// Token: 0x04000CA7 RID: 3239
		[global::Cpp2ILInjected.Token(Token = "0x4000F99")]
		private static readonly int[] sizes;
	}
}
