﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000044 RID: 68
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200004F")]
	internal class ReflectionObject
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00002927 File Offset: 0x00000B27
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0000292A File Offset: 0x00000B2A
		[global::Cpp2ILInjected.Token(Token = "0x17000091")]
		public ObjectConstructor<object> Creator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD06B4", Offset = "0x1CD06B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD06BC", Offset = "0x1CD06BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000292D File Offset: 0x00000B2D
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00002930 File Offset: 0x00000B30
		[global::Cpp2ILInjected.Token(Token = "0x17000092")]
		public IDictionary<string, ReflectionMember> Members
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD06C4", Offset = "0x1CD06C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD06CC", Offset = "0x1CD06CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002933 File Offset: 0x00000B33
		[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD06D4", Offset = "0x1CD06D4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodBase),
			typeof(string[])
		}, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ReflectionObject()
		{
			throw null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002936 File Offset: 0x00000B36
		[global::Cpp2ILInjected.Token(Token = "0x60002FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD0754", Offset = "0x1CD0754", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAssociateMetadataTypeFromAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "GetByteArray", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object GetValue(object target, string member)
		{
			throw null;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002939 File Offset: 0x00000B39
		[global::Cpp2ILInjected.Token(Token = "0x60002FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD0818", Offset = "0x1CD0818", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetValue(object target, string member, object value)
		{
			throw null;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000293C File Offset: 0x00000B3C
		[global::Cpp2ILInjected.Token(Token = "0x60002FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD08EC", Offset = "0x1CD08EC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Type GetType(string member)
		{
			throw null;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000293F File Offset: 0x00000B3F
		[global::Cpp2ILInjected.Token(Token = "0x60002FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD099C", Offset = "0x1CD099C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAssociateMetadataTypeFromAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			throw null;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002942 File Offset: 0x00000B42
		[global::Cpp2ILInjected.Token(Token = "0x6000300")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD09A8", Offset = "0x1CD09A8", Length = "0x808")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "EnsureReflectionObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "InitializeReflectionObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "HasDefaultConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectConstructor<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Single", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "CanReadMemberValue", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateGet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = "System.Func`2<T, Object>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "CanSetMemberValue", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateSet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = "System.Action`2<T, Object>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 56)]
		public static ReflectionObject Create(Type t, MethodBase creator, params string[] memberNames)
		{
			throw null;
		}

		// Token: 0x04000165 RID: 357
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400018C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ObjectConstructor<object> <Creator>k__BackingField;

		// Token: 0x04000166 RID: 358
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400018D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IDictionary<string, ReflectionMember> <Members>k__BackingField;

		// Token: 0x020000FD RID: 253
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000050")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06000A9A RID: 2714 RVA: 0x00003F4A File Offset: 0x0000214A
			[global::Cpp2ILInjected.Token(Token = "0x6000301")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD1258", Offset = "0x1CD1258", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_0()
			{
				throw null;
			}

			// Token: 0x06000A9B RID: 2715 RVA: 0x00003F4D File Offset: 0x0000214D
			[global::Cpp2ILInjected.Token(Token = "0x6000302")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD1740", Offset = "0x1CD1740", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal object <Create>b__0(object[] args)
			{
				throw null;
			}

			// Token: 0x0400038B RID: 907
			[global::Cpp2ILInjected.Token(Token = "0x400018E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Func<object> ctor;
		}

		// Token: 0x020000FE RID: 254
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000051")]
		private sealed class <>c__DisplayClass13_1
		{
			// Token: 0x06000A9C RID: 2716 RVA: 0x00003F50 File Offset: 0x00002150
			[global::Cpp2ILInjected.Token(Token = "0x6000303")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD1518", Offset = "0x1CD1518", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_1()
			{
				throw null;
			}

			// Token: 0x06000A9D RID: 2717 RVA: 0x00003F53 File Offset: 0x00002153
			[global::Cpp2ILInjected.Token(Token = "0x6000304")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD1754", Offset = "0x1CD1754", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal object <Create>b__1(object target)
			{
				throw null;
			}

			// Token: 0x0400038C RID: 908
			[global::Cpp2ILInjected.Token(Token = "0x400018F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MethodCall<object, object> call;
		}

		// Token: 0x020000FF RID: 255
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000052")]
		private sealed class <>c__DisplayClass13_2
		{
			// Token: 0x06000A9E RID: 2718 RVA: 0x00003F56 File Offset: 0x00002156
			[global::Cpp2ILInjected.Token(Token = "0x6000305")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD1520", Offset = "0x1CD1520", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_2()
			{
				throw null;
			}

			// Token: 0x06000A9F RID: 2719 RVA: 0x00003F59 File Offset: 0x00002159
			[global::Cpp2ILInjected.Token(Token = "0x6000306")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD17C8", Offset = "0x1CD17C8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal void <Create>b__2(object target, object arg)
			{
				throw null;
			}

			// Token: 0x0400038D RID: 909
			[global::Cpp2ILInjected.Token(Token = "0x4000190")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MethodCall<object, object> call;
		}
	}
}