﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000021 RID: 33
[global::Cpp2ILInjected.Token(Token = "0x2000039")]
public static class AndroidImmersive
{
	// Token: 0x060000CE RID: 206 RVA: 0x00021DE2 File Offset: 0x0001FFE2
	[global::Cpp2ILInjected.Token(Token = "0x6000141")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEFC4", Offset = "0x6FEFC4", Length = "0x410")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alert), Member = "AlertButtonClicked", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alert), Member = "AlertCancelled", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive), Member = "GetSDKLevel", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "Call", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = "ReturnType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive.RunPtr), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaRunnable), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
	public static void Activate()
	{
		throw null;
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00021DE5 File Offset: 0x0001FFE5
	[global::Cpp2ILInjected.Token(Token = "0x6000142")]
	[global::Cpp2ILInjected.Address(RVA = "0x703F30", Offset = "0x703F30", Length = "0x288")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive.RunPtr), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaRunnable), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	public static void Deactivate(bool blockReactivation)
	{
		throw null;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00021DE8 File Offset: 0x0001FFE8
	[global::Cpp2ILInjected.Token(Token = "0x6000143")]
	[global::Cpp2ILInjected.Address(RVA = "0x7041B8", Offset = "0x7041B8", Length = "0x234")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidImmersive.Listener), Member = "onSystemUiVisibilityChange", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive.Listener), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
	private static void RunActivate()
	{
		throw null;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00021DEB File Offset: 0x0001FFEB
	[global::Cpp2ILInjected.Token(Token = "0x6000144")]
	[global::Cpp2ILInjected.Address(RVA = "0x70445C", Offset = "0x70445C", Length = "0x154")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	private static void RunDeactivate()
	{
		throw null;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00021DEE File Offset: 0x0001FFEE
	[global::Cpp2ILInjected.Token(Token = "0x6000145")]
	[global::Cpp2ILInjected.Address(RVA = "0x703CC0", Offset = "0x703CC0", Length = "0x1B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidImmersive), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNI), Member = "FindClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNI), Member = "GetStaticFieldID", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNI), Member = "GetStaticIntField", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(IntPtr)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private static int GetSDKLevel()
	{
		throw null;
	}

	// Token: 0x04000081 RID: 129
	[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
	private static AndroidJavaObject _viewInstance;

	// Token: 0x04000082 RID: 130
	[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
	private static AndroidJavaObject _viewInstanceBackup;

	// Token: 0x04000083 RID: 131
	[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
	private static bool _blockReactivation;

	// Token: 0x04000084 RID: 132
	[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
	private const int SYSTEM_UI_FLAG_HIDE_NAVIGATION = 2;

	// Token: 0x04000085 RID: 133
	[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
	private const int SYSTEM_UI_FLAG_FULLSCREEN = 4;

	// Token: 0x04000086 RID: 134
	[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
	private const int SYSTEM_UI_FLAG_LAYOUT_STABLE = 256;

	// Token: 0x04000087 RID: 135
	[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
	private const int SYSTEM_UI_FLAG_LAYOUT_HIDE_NAVIGATION = 512;

	// Token: 0x04000088 RID: 136
	[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
	private const int SYSTEM_UI_FLAG_LAYOUT_FULLSCREEN = 1024;

	// Token: 0x04000089 RID: 137
	[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
	private const int SYSTEM_UI_FLAG_IMMERSIVE = 2048;

	// Token: 0x0400008A RID: 138
	[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
	private const int SYSTEM_UI_FLAG_IMMERSIVE_STICKY = 4096;

	// Token: 0x0200077A RID: 1914
	// (Invoke) Token: 0x06004847 RID: 18503
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	private delegate void RunPtr();

	// Token: 0x0200077B RID: 1915
	[global::Cpp2ILInjected.Token(Token = "0x200003B")]
	private class Listener : AndroidJavaProxy
	{
		// Token: 0x0600484A RID: 18506 RVA: 0x0002EE53 File Offset: 0x0002D053
		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7043EC", Offset = "0x7043EC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidImmersive), Member = "RunActivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Listener()
		{
			throw null;
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x0002EE56 File Offset: 0x0002D056
		[global::Cpp2ILInjected.Token(Token = "0x600014B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7045F0", Offset = "0x7045F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive), Member = "RunActivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void onSystemUiVisibilityChange(int visibility)
		{
			throw null;
		}
	}
}
