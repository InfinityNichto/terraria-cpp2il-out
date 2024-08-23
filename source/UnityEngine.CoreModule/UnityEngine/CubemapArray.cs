﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004B RID: 75
	[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
	[ExcludeFromPreset]
	[global::Cpp2ILInjected.Token(Token = "0x200004F")]
	public sealed class CubemapArray : Texture
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000140 RID: 320
		[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
		public override extern bool isReadable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000148")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F71BB8", Offset = "0x1F71BB8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x06000141 RID: 321
		[FreeFunction("CubemapArrayScripting::Create")]
		[global::Cpp2ILInjected.Token(Token = "0x6000149")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71BF4", Offset = "0x1F71BF4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool Internal_CreateImpl([Writable] CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags);

		// Token: 0x06000142 RID: 322 RVA: 0x000022E4 File Offset: 0x000004E4
		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71C68", Offset = "0x1F71C68", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Internal_Create([Writable] CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000022E7 File Offset: 0x000004E7
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x600014B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71D28", Offset = "0x1F71D28", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000022EA File Offset: 0x000004EA
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600014C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71D9C", Offset = "0x1F71D9C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000022ED File Offset: 0x000004ED
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x600014D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71E2C", Offset = "0x1F71E2C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(FormatUsage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CubemapArray), Member = "ValidateIsNotCrunched", MemberParameters = new object[] { typeof(TextureCreationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CubemapArray), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(CubemapArray),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("-1")] int mipCount)
		{
			throw null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000022F0 File Offset: 0x000004F0
		[global::Cpp2ILInjected.Token(Token = "0x600014E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71F50", Offset = "0x1F71F50", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CubemapArray), Member = "ValidateIsNotCrunched", MemberParameters = new object[] { typeof(TextureCreationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CubemapArray), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(CubemapArray),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear)
		{
			throw null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000022F3 File Offset: 0x000004F3
		[global::Cpp2ILInjected.Token(Token = "0x600014F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72088", Offset = "0x1F72088", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear)
		{
			throw null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000022F6 File Offset: 0x000004F6
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000150")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7209C", Offset = "0x1F7209C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain)
		{
			throw null;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000022F9 File Offset: 0x000004F9
		[global::Cpp2ILInjected.Token(Token = "0x6000151")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71EFC", Offset = "0x1F71EFC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
			throw null;
		}
	}
}
