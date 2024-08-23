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
	// Token: 0x02000049 RID: 73
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Graphics/Texture3D.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200004D")]
	public sealed class Texture3D : Texture
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000129 RID: 297
		[global::Cpp2ILInjected.Token(Token = "0x17000038")]
		public override extern bool isReadable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000131")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F70DCC", Offset = "0x1F70DCC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600012A RID: 298
		[FreeFunction("Texture3DScripting::Create")]
		[global::Cpp2ILInjected.Token(Token = "0x6000132")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70E08", Offset = "0x1F70E08", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool Internal_CreateImpl([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex);

		// Token: 0x0600012B RID: 299 RVA: 0x000022AB File Offset: 0x000004AB
		[global::Cpp2ILInjected.Token(Token = "0x6000133")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70E94", Offset = "0x1F70E94", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Internal_Create([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex)
		{
			throw null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000022AE File Offset: 0x000004AE
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000134")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70F6C", Offset = "0x1F70F6C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000022B1 File Offset: 0x000004B1
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000135")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70FE8", Offset = "0x1F70FE8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000022B4 File Offset: 0x000004B4
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000136")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71088", Offset = "0x1F71088", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(FormatUsage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture3D), Member = "ValidateIsNotCrunched", MemberParameters = new object[] { typeof(TextureCreationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture3D), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Texture3D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("-1")] int mipCount)
		{
			throw null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000022B7 File Offset: 0x000004B7
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F711C8", Offset = "0x1F711C8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture3D), Member = "ValidateIsNotCrunched", MemberParameters = new object[] { typeof(TextureCreationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture3D), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Texture3D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount)
		{
			throw null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000022BA File Offset: 0x000004BA
		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71314", Offset = "0x1F71314", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(bool),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture3D), Member = "ValidateIsNotCrunched", MemberParameters = new object[] { typeof(TextureCreationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture3D), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Texture3D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
			throw null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000022BD File Offset: 0x000004BD
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71448", Offset = "0x1F71448", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		{
			throw null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000022C0 File Offset: 0x000004C0
		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71458", Offset = "0x1F71458", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
			throw null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000022C3 File Offset: 0x000004C3
		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71174", Offset = "0x1F71174", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
			throw null;
		}
	}
}
