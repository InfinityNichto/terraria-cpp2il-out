﻿using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000035 RID: 53
	[global::Cpp2ILInjected.Token(Token = "0x200007F")]
	internal static class SecurityUtils
	{
		// Token: 0x06000164 RID: 356 RVA: 0x000031F7 File Offset: 0x000013F7
		[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1F08", Offset = "0x1EA1F08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DemandReflectionAccess(Type type)
		{
			throw null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000031FA File Offset: 0x000013FA
		[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1F0C", Offset = "0x1EA1F0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DemandGrantSet(Assembly assembly)
		{
			throw null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000031FD File Offset: 0x000013FD
		[global::Cpp2ILInjected.Token(Token = "0x60001EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1F10", Offset = "0x1EA1F10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool HasReflectionPermission(Type type)
		{
			throw null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00003200 File Offset: 0x00001400
		[global::Cpp2ILInjected.Token(Token = "0x60001ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1F18", Offset = "0x1EA1F18", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BindingList<>), Member = "AddNewCore", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "ValidateInternalRecursive", MemberParameters = new object[]
		{
			typeof(LicenseContext),
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal static object SecureCreateInstance(Type type)
		{
			throw null;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00003203 File Offset: 0x00001403
		[global::Cpp2ILInjected.Token(Token = "0x60001EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1F24", Offset = "0x1EA1F24", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateDesigner", MemberParameters = new object[]
		{
			typeof(IComponent),
			typeof(Type)
		}, ReturnType = typeof(IDesigner))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object[]),
			typeof(CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic)
		{
			throw null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00003206 File Offset: 0x00001406
		[global::Cpp2ILInjected.Token(Token = "0x60001EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA2010", Offset = "0x1EA2010", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "CreateWithContext", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(LicenseContext),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(IServiceProvider),
			typeof(Type),
			typeof(Type[]),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[]),
			typeof(bool)
		}, ReturnType = typeof(object))]
		internal static object SecureCreateInstance(Type type, object[] args)
		{
			throw null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00003209 File Offset: 0x00001409
		[global::Cpp2ILInjected.Token(Token = "0x60001F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA2018", Offset = "0x1EA2018", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(IServiceProvider),
			typeof(Type),
			typeof(Type[]),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic)
		{
			throw null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000320C File Offset: 0x0000140C
		[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA2024", Offset = "0x1EA2024", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(IServiceProvider),
			typeof(Type),
			typeof(Type[]),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(Binder),
			typeof(Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags)
		{
			throw null;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000320F File Offset: 0x0000140F
		[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA218C", Offset = "0x1EA218C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityUtils), Member = "MethodInfoInvoke", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
		private static bool GenericArgumentsAreVisible(MethodInfo method)
		{
			throw null;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00003212 File Offset: 0x00001412
		[global::Cpp2ILInjected.Token(Token = "0x60001F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA2210", Offset = "0x1EA2210", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "GenericArgumentsAreVisible", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args)
		{
			throw null;
		}
	}
}