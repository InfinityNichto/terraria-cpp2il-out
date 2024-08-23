﻿using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000FE RID: 254
	[global::Cpp2ILInjected.Token(Token = "0x2000130")]
	[global::System.Serializable]
	public sealed class OperatingSystem : global::System.Runtime.Serialization.ISerializable, global::System.ICloneable
	{
		// Token: 0x06000B2A RID: 2858 RVA: 0x00016571 File Offset: 0x00014771
		[global::Cpp2ILInjected.Token(Token = "0x6000BD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C562A0", Offset = "0x1C562A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "get_OSVersion", ReturnType = typeof(global::System.OperatingSystem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public OperatingSystem(global::System.PlatformID platform, global::System.Version version)
		{
			throw null;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00016574 File Offset: 0x00014774
		[global::Cpp2ILInjected.Token(Token = "0x6000BD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C562A8", Offset = "0x1C562A8", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OperatingSystem), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal OperatingSystem(global::System.PlatformID platform, global::System.Version version, string servicePack)
		{
			throw null;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00016577 File Offset: 0x00014777
		[global::Cpp2ILInjected.Token(Token = "0x6000BD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C563E0", Offset = "0x1C563E0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0001657A File Offset: 0x0001477A
		[global::Cpp2ILInjected.Token(Token = "0x17000104")]
		public global::System.PlatformID Platform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C56414", Offset = "0x1C56414", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0001657D File Offset: 0x0001477D
		[global::Cpp2ILInjected.Token(Token = "0x6000BD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5641C", Offset = "0x1C5641C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OperatingSystem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.PlatformID),
			typeof(global::System.Version),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00016580 File Offset: 0x00014780
		[global::Cpp2ILInjected.Token(Token = "0x6000BD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56490", Offset = "0x1C56490", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00016583 File Offset: 0x00014783
		[global::Cpp2ILInjected.Token(Token = "0x17000105")]
		public string VersionString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C56494", Offset = "0x1C56494", Length = "0x1C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000378 RID: 888
		[global::Cpp2ILInjected.Token(Token = "0x40004CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Version _version;

		// Token: 0x04000379 RID: 889
		[global::Cpp2ILInjected.Token(Token = "0x40004CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly global::System.PlatformID _platform;

		// Token: 0x0400037A RID: 890
		[global::Cpp2ILInjected.Token(Token = "0x40004CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string _servicePack;

		// Token: 0x0400037B RID: 891
		[global::Cpp2ILInjected.Token(Token = "0x40004CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _versionString;
	}
}