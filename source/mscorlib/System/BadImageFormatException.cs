﻿using System;
using System.IO;
using System.Resources;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000069 RID: 105
	[global::Cpp2ILInjected.Token(Token = "0x200008F")]
	[global::System.Serializable]
	public class BadImageFormatException : global::System.SystemException
	{
		// Token: 0x06000375 RID: 885 RVA: 0x00014F7E File Offset: 0x0001317E
		[global::Cpp2ILInjected.Token(Token = "0x600040C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB66A4", Offset = "0x1BB66A4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public BadImageFormatException()
		{
			throw null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00014F81 File Offset: 0x00013181
		[global::Cpp2ILInjected.Token(Token = "0x600040D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6700", Offset = "0x1BB6700", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "SkipString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref global::System.Resources.ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "DeserializeObject", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "FindType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public BadImageFormatException(string message)
		{
			throw null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00014F84 File Offset: 0x00013184
		[global::Cpp2ILInjected.Token(Token = "0x600040E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6724", Offset = "0x1BB6724", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref global::System.Resources.ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public BadImageFormatException(string message, global::System.Exception inner)
		{
			throw null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00014F87 File Offset: 0x00013187
		[global::Cpp2ILInjected.Token(Token = "0x600040F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6748", Offset = "0x1BB6748", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public BadImageFormatException(string message, string fileName)
		{
			throw null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00014F8A File Offset: 0x0001318A
		[global::Cpp2ILInjected.Token(Token = "0x6000410")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB677C", Offset = "0x1BB677C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected BadImageFormatException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00014F8D File Offset: 0x0001318D
		[global::Cpp2ILInjected.Token(Token = "0x6000411")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB682C", Offset = "0x1BB682C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00014F90 File Offset: 0x00013190
		[global::Cpp2ILInjected.Token(Token = "0x17000065")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000412")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB6944", Offset = "0x1BB6944", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = "SetMessageField", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00014F93 File Offset: 0x00013193
		[global::Cpp2ILInjected.Token(Token = "0x6000413")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB695C", Offset = "0x1BB695C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BadImageFormatException), Member = "get_Message", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileLoadException), Member = "FormatFileLoadExceptionMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SetMessageField()
		{
			throw null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00014F96 File Offset: 0x00013196
		[global::Cpp2ILInjected.Token(Token = "0x6000414")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB69D8", Offset = "0x1BB69D8", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000116 RID: 278
		[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string _fileName;

		// Token: 0x04000117 RID: 279
		[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string _fusionLog;
	}
}