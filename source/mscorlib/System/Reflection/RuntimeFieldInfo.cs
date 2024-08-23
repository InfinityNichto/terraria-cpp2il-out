﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200044A RID: 1098
	[global::Cpp2ILInjected.Token(Token = "0x200050C")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal class RuntimeFieldInfo : RtFieldInfo, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x0001A672 File Offset: 0x00018872
		[global::Cpp2ILInjected.Token(Token = "0x17000537")]
		internal BindingFlags BindingFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E030", Offset = "0x1B8E030", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFieldCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(BindingFlags),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<FieldInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetField", MemberParameters = new object[]
			{
				typeof(string),
				typeof(BindingFlags)
			}, ReturnType = typeof(FieldInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x0001A675 File Offset: 0x00018875
		[global::Cpp2ILInjected.Token(Token = "0x17000538")]
		public override Module Module
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E038", Offset = "0x1B8E038", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeFieldInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0001A678 File Offset: 0x00018878
		[global::Cpp2ILInjected.Token(Token = "0x60025A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E060", Offset = "0x1B8E060", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypedReference), Member = "MakeTypedReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FieldInfo[])
		}, ReturnType = typeof(global::System.TypedReference))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "get_Module", ReturnType = typeof(Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.RuntimeType GetDeclaringTypeInternal()
		{
			throw null;
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0001A67B File Offset: 0x0001887B
		[global::Cpp2ILInjected.Token(Token = "0x17000539")]
		private global::System.RuntimeType ReflectedTypeInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E0E4", Offset = "0x1B8E0E4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x0001A67E File Offset: 0x0001887E
		[global::Cpp2ILInjected.Token(Token = "0x60025A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E04C", Offset = "0x1B8E04C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeFieldInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
		internal RuntimeModule GetRuntimeModule()
		{
			throw null;
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x0001A681 File Offset: 0x00018881
		[global::Cpp2ILInjected.Token(Token = "0x60025A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E168", Offset = "0x1B8E168", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeFieldInfo), Member = "get_ReflectedTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(string),
			typeof(global::System.RuntimeType),
			typeof(string),
			typeof(MemberTypes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600230A RID: 8970
		[global::Cpp2ILInjected.Token(Token = "0x60025A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E21C", Offset = "0x1B8E21C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal override extern object UnsafeGetValue(object obj);

		// Token: 0x0600230B RID: 8971 RVA: 0x0001A684 File Offset: 0x00018884
		[global::Cpp2ILInjected.Token(Token = "0x60025A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E220", Offset = "0x1B8E220", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal override void CheckConsistency(object target)
		{
			throw null;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0001A687 File Offset: 0x00018887
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60025AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E384", Offset = "0x1B8E384", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeFieldHandle), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(RuntimeFieldInfo),
			typeof(object),
			typeof(object),
			typeof(global::System.RuntimeType),
			typeof(FieldAttributes),
			typeof(global::System.RuntimeType),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x0001A68A File Offset: 0x0001888A
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60025AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E3E8", Offset = "0x1B8E3E8", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypedReference), Member = "get_IsNull", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeFieldHandle), Member = "SetValueDirect", MemberParameters = new object[]
		{
			typeof(RuntimeFieldInfo),
			typeof(global::System.RuntimeType),
			typeof(void*),
			typeof(object),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public unsafe override void SetValueDirect(global::System.TypedReference obj, object value)
		{
			throw null;
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x0001A68D File Offset: 0x0001888D
		[global::Cpp2ILInjected.Token(Token = "0x1700053A")]
		public override FieldAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E544", Offset = "0x1B8E544", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x0001A690 File Offset: 0x00018890
		[global::Cpp2ILInjected.Token(Token = "0x1700053B")]
		public override global::System.RuntimeFieldHandle FieldHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E54C", Offset = "0x1B8E54C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002310 RID: 8976
		[global::Cpp2ILInjected.Token(Token = "0x60025AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E554", Offset = "0x1B8E554", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.Type ResolveType();

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x0001A693 File Offset: 0x00018893
		[global::Cpp2ILInjected.Token(Token = "0x1700053C")]
		public override global::System.Type FieldType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E558", Offset = "0x1B8E558", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002312 RID: 8978
		[global::Cpp2ILInjected.Token(Token = "0x60025B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E5D4", Offset = "0x1B8E5D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.Type GetParentType(bool declaring);

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x0001A696 File Offset: 0x00018896
		[global::Cpp2ILInjected.Token(Token = "0x1700053D")]
		public override global::System.Type ReflectedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E5DC", Offset = "0x1B8E5DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x0001A699 File Offset: 0x00018899
		[global::Cpp2ILInjected.Token(Token = "0x1700053E")]
		public override global::System.Type DeclaringType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E5E4", Offset = "0x1B8E5E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x0001A69C File Offset: 0x0001889C
		[global::Cpp2ILInjected.Token(Token = "0x1700053F")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E5EC", Offset = "0x1B8E5EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x0001A69F File Offset: 0x0001889F
		[global::Cpp2ILInjected.Token(Token = "0x60025B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E5F4", Offset = "0x1B8E5F4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x0001A6A2 File Offset: 0x000188A2
		[global::Cpp2ILInjected.Token(Token = "0x60025B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E664", Offset = "0x1B8E664", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0001A6A5 File Offset: 0x000188A5
		[global::Cpp2ILInjected.Token(Token = "0x60025B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E6CC", Offset = "0x1B8E6CC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06002319 RID: 8985
		[global::Cpp2ILInjected.Token(Token = "0x60025B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E73C", Offset = "0x1B8E73C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal override extern int GetFieldOffset();

		// Token: 0x0600231A RID: 8986
		[global::Cpp2ILInjected.Token(Token = "0x60025B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E740", Offset = "0x1B8E740", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern object GetValueInternal(object obj);

		// Token: 0x0600231B RID: 8987 RVA: 0x0001A6A8 File Offset: 0x000188A8
		[global::Cpp2ILInjected.Token(Token = "0x60025B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E744", Offset = "0x1B8E744", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeFieldInfo), Member = "CheckGeneric", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override object GetValue(object obj)
		{
			throw null;
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0001A6AB File Offset: 0x000188AB
		[global::Cpp2ILInjected.Token(Token = "0x60025BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E930", Offset = "0x1B8E930", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600231D RID: 8989
		[global::Cpp2ILInjected.Token(Token = "0x60025BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E998", Offset = "0x1B8E998", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void SetValueInternal(FieldInfo fi, object obj, object value);

		// Token: 0x0600231E RID: 8990 RVA: 0x0001A6AE File Offset: 0x000188AE
		[global::Cpp2ILInjected.Token(Token = "0x60025BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E99C", Offset = "0x1B8E99C", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeFieldInfo), Member = "CheckGeneric", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CheckValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Binder),
			typeof(global::System.Globalization.CultureInfo),
			typeof(BindingFlags)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FieldAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x0600231F RID: 8991
		[global::Cpp2ILInjected.Token(Token = "0x60025BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8EC38", Offset = "0x1B8EC38", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public override extern object GetRawConstantValue();

		// Token: 0x06002320 RID: 8992 RVA: 0x0001A6B1 File Offset: 0x000188B1
		[global::Cpp2ILInjected.Token(Token = "0x60025BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E8BC", Offset = "0x1B8E8BC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CheckGeneric()
		{
			throw null;
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x0001A6B4 File Offset: 0x000188B4
		[global::Cpp2ILInjected.Token(Token = "0x17000540")]
		public override int MetadataToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8EC3C", Offset = "0x1B8EC3C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002322 RID: 8994
		[global::Cpp2ILInjected.Token(Token = "0x60025C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8EC40", Offset = "0x1B8EC40", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimeFieldInfo monoField);

		// Token: 0x06002323 RID: 8995 RVA: 0x0001A6B7 File Offset: 0x000188B7
		[global::Cpp2ILInjected.Token(Token = "0x60025C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8EC44", Offset = "0x1B8EC44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = ".ctor", ReturnType = typeof(void))]
		public RuntimeFieldInfo()
		{
			throw null;
		}

		// Token: 0x040011CA RID: 4554
		[global::Cpp2ILInjected.Token(Token = "0x40014E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IntPtr klass;

		// Token: 0x040011CB RID: 4555
		[global::Cpp2ILInjected.Token(Token = "0x40014E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.RuntimeFieldHandle fhandle;

		// Token: 0x040011CC RID: 4556
		[global::Cpp2ILInjected.Token(Token = "0x40014EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x040011CD RID: 4557
		[global::Cpp2ILInjected.Token(Token = "0x40014EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Type type;

		// Token: 0x040011CE RID: 4558
		[global::Cpp2ILInjected.Token(Token = "0x40014EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private FieldAttributes attrs;
	}
}
