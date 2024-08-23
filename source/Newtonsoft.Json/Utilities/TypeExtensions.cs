﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005D RID: 93
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000076")]
	internal static class TypeExtensions
	{
		// Token: 0x060003F5 RID: 1013 RVA: 0x00002C4B File Offset: 0x00000E4B
		[global::Cpp2ILInjected.Token(Token = "0x6000438")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF264", Offset = "0x1CDF264", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnDeserialized", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnDeserializing", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnSerialized", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnSerializing", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnError", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "get_Method", ReturnType = typeof(MethodInfo))]
		public static MethodInfo Method(this Delegate d)
		{
			throw null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002C4E File Offset: 0x00000E4E
		[global::Cpp2ILInjected.Token(Token = "0x6000439")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD1260", Offset = "0x1CD1260", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver.<>c", Member = "<GetExtensionDataMemberForType>b__33_1", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(DataMemberAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static MemberTypes MemberType(this MemberInfo memberInfo)
		{
			throw null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002C51 File Offset: 0x00000E51
		[global::Cpp2ILInjected.Token(Token = "0x600043A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF26C", Offset = "0x1CDF26C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetClrTypeFullName", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool ContainsGenericParameters(this Type type)
		{
			throw null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002C54 File Offset: 0x00000E54
		[global::Cpp2ILInjected.Token(Token = "0x600043B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD3130", Offset = "0x1CD3130", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_CreatedType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonPropertyCollection), Member = "AddProperty", MemberParameters = new object[] { typeof(JsonProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		public static bool IsInterface(this Type type)
		{
			throw null;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002C57 File Offset: 0x00000E57
		[global::Cpp2ILInjected.Token(Token = "0x600043C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB9FC", Offset = "0x1CDB9FC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "ShouldSerializeEntityMember", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashSetConverter), Member = "CanConvert", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "CanConvert", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool IsGenericType(this Type type)
		{
			throw null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002C5A File Offset: 0x00000E5A
		[global::Cpp2ILInjected.Token(Token = "0x600043D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD3138", Offset = "0x1CD3138", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetClrTypeFullName", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool IsGenericTypeDefinition(this Type type)
		{
			throw null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002C5D File Offset: 0x00000E5D
		[global::Cpp2ILInjected.Token(Token = "0x600043E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDBF68", Offset = "0x1CDBF68", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetClassHierarchyForType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(List<Type>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(DataContractAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(DataMemberAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Type BaseType(this Type type)
		{
			throw null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002C60 File Offset: 0x00000E60
		[global::Cpp2ILInjected.Token(Token = "0x600043F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF27C", Offset = "0x1CDF27C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Assembly Assembly(this Type type)
		{
			throw null;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002C63 File Offset: 0x00000E63
		[global::Cpp2ILInjected.Token(Token = "0x6000440")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD1CC8", Offset = "0x1CD1CC8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringEnumConverter), Member = "CanConvert", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool IsEnum(this Type type)
		{
			throw null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002C66 File Offset: 0x00000E66
		[global::Cpp2ILInjected.Token(Token = "0x6000441")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDBE80", Offset = "0x1CDBE80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
		public static bool IsClass(this Type type)
		{
			throw null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002C69 File Offset: 0x00000E69
		[global::Cpp2ILInjected.Token(Token = "0x6000442")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF28C", Offset = "0x1CDF28C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_CreatedType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
		public static bool IsSealed(this Type type)
		{
			throw null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002C6C File Offset: 0x00000E6C
		[global::Cpp2ILInjected.Token(Token = "0x6000443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD3148", Offset = "0x1CD3148", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_CreatedType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
		public static bool IsAbstract(this Type type)
		{
			throw null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002C6F File Offset: 0x00000E6F
		[global::Cpp2ILInjected.Token(Token = "0x6000444")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF294", Offset = "0x1CDF294", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
		public static bool IsVisible(this Type type)
		{
			throw null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002C72 File Offset: 0x00000E72
		[global::Cpp2ILInjected.Token(Token = "0x6000445")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB870", Offset = "0x1CDB870", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LateBoundReflectionDelegateFactory), Member = "CreateDefaultConstructor", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Type) }, ReturnType = "System.Func`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CollectionWrapper<>), Member = "IsCompatibleObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CalculatePropertyDetails", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(ref JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object),
			typeof(ref bool),
			typeof(ref object),
			typeof(ref JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "CanConvert", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		public static bool IsValueType(this Type type)
		{
			throw null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002C75 File Offset: 0x00000E75
		[global::Cpp2ILInjected.Token(Token = "0x6000446")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF29C", Offset = "0x1CDF29C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeExtensions), Member = "AssignableToTypeName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetSerializableMembers", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(List<MemberInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		public static bool AssignableToTypeName(this Type type, string fullTypeName, out Type match)
		{
			throw null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002C78 File Offset: 0x00000E78
		[global::Cpp2ILInjected.Token(Token = "0x6000447")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF398", Offset = "0x1CDF398", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "GetByteArray", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "CanConvert", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "AssignableToTypeName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		public static bool AssignableToTypeName(this Type type, string fullTypeName)
		{
			throw null;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002C7B File Offset: 0x00000E7B
		[global::Cpp2ILInjected.Token(Token = "0x6000448")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF3B4", Offset = "0x1CDF3B4", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeExtensions), Member = "ImplementInterface", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonPropertyCollection), Member = "AddProperty", MemberParameters = new object[] { typeof(JsonProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "ImplementInterface", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static bool ImplementInterface(this Type type, Type interfaceType)
		{
			throw null;
		}
	}
}
