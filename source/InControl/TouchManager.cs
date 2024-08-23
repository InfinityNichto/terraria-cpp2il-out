﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200004B RID: 75
	[ExecuteInEditMode]
	[global::Cpp2ILInjected.Token(Token = "0x2000053")]
	public class TouchManager : SingletonMonoBehavior<TouchManager>
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060003C9 RID: 969 RVA: 0x00002B8B File Offset: 0x00000D8B
		// (remove) Token: 0x060003CA RID: 970 RVA: 0x00002B8E File Offset: 0x00000D8E
		[global::Cpp2ILInjected.Token(Token = "0x1400000F")]
		public static event Action OnSetup
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60003D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A1260", Offset = "0x19A1260", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60003D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A1CE8", Offset = "0x19A1CE8", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002B91 File Offset: 0x00000D91
		[global::Cpp2ILInjected.Token(Token = "0x60003D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1DA0", Offset = "0x19A1DA0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected TouchManager()
		{
			throw null;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002B94 File Offset: 0x00000D94
		[global::Cpp2ILInjected.Token(Token = "0x60003D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1E50", Offset = "0x19A1E50", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_EnforceSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(bool) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnSetup", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<ulong, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnUpdateDevices", MemberParameters = new object[] { typeof(Action<ulong, float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnCommitDevices", MemberParameters = new object[] { typeof(Action<ulong, float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002B97 File Offset: 0x00000D97
		[global::Cpp2ILInjected.Token(Token = "0x60003D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A20B8", Offset = "0x19A20B8", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "remove_OnSetup", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<ulong, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "remove_OnUpdateDevices", MemberParameters = new object[] { typeof(Action<ulong, float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "remove_OnCommitDevices", MemberParameters = new object[] { typeof(Action<ulong, float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002B9A File Offset: 0x00000D9A
		[global::Cpp2ILInjected.Token(Token = "0x60003D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A226C", Offset = "0x19A226C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "GetCurrentScreenSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "UpdateScreenSize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "CreateDevice", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "CreateTouches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Setup()
		{
			throw null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002B9D File Offset: 0x00000D9D
		[global::Cpp2ILInjected.Token(Token = "0x60003D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A21F8", Offset = "0x19A21F8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Reset()
		{
			throw null;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002BA0 File Offset: 0x00000DA0
		[global::Cpp2ILInjected.Token(Token = "0x60003D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2AB8", Offset = "0x19A2AB8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator UpdateScreenSizeAtEndOfFrame()
		{
			throw null;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002BA3 File Offset: 0x00000DA3
		[global::Cpp2ILInjected.Token(Token = "0x60003DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2B40", Offset = "0x19A2B40", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "GetCurrentScreenSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "UpdateScreenSize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "UpdateScreenSizeAtEndOfFrame", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002BA6 File Offset: 0x00000DA6
		[global::Cpp2ILInjected.Token(Token = "0x60003DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2540", Offset = "0x19A2540", Length = "0x3F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "Setup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchInputDevice), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "AddControl", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(string)
		}, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AttachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void CreateDevice()
		{
			throw null;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002BA9 File Offset: 0x00000DA9
		[global::Cpp2ILInjected.Token(Token = "0x60003DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2C38", Offset = "0x19A2C38", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "UpdateTouches", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "SubmitControlStates", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		private void UpdateDevice(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002BAC File Offset: 0x00000DAC
		[global::Cpp2ILInjected.Token(Token = "0x60003DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2F98", Offset = "0x19A2F98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void CommitDevice(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002BAF File Offset: 0x00000DAF
		[global::Cpp2ILInjected.Token(Token = "0x60003DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2EF0", Offset = "0x19A2EF0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "UpdateDevice", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		private void SubmitControlStates(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002BB2 File Offset: 0x00000DB2
		[global::Cpp2ILInjected.Token(Token = "0x60003DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2F9C", Offset = "0x19A2F9C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		private void CommitControlStates(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002BB5 File Offset: 0x00000DB5
		[global::Cpp2ILInjected.Token(Token = "0x60003E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2350", Offset = "0x19A2350", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager.<UpdateScreenSizeAtEndOfFrame>d__28), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "Setup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_rect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ConvertViewToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void UpdateScreenSize(Vector2 currentScreenSize)
		{
			throw null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002BB8 File Offset: 0x00000DB8
		[global::Cpp2ILInjected.Token(Token = "0x60003E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2934", Offset = "0x19A2934", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "Setup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchPool), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void CreateTouches()
		{
			throw null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002BBB File Offset: 0x00000DBB
		[global::Cpp2ILInjected.Token(Token = "0x60003E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A2C70", Offset = "0x19A2C70", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "UpdateDevice", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchPool), Member = "FreeEndedTouches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Touch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_fingerId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchPool), Member = "FindOrCreateTouch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Touch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "SetWithTouchData", MemberParameters = new object[]
		{
			typeof(Touch),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "InvokeTouchEvents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void UpdateTouches(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002BBE File Offset: 0x00000DBE
		[global::Cpp2ILInjected.Token(Token = "0x60003E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A3408", Offset = "0x19A3408", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "InvokeTouchEvents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		private void SendTouchBegan(Touch touch)
		{
			throw null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002BC1 File Offset: 0x00000DC1
		[global::Cpp2ILInjected.Token(Token = "0x60003E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A34A0", Offset = "0x19A34A0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "InvokeTouchEvents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		private void SendTouchMoved(Touch touch)
		{
			throw null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[global::Cpp2ILInjected.Token(Token = "0x60003E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A3538", Offset = "0x19A3538", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "InvokeTouchEvents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		private void SendTouchEnded(Touch touch)
		{
			throw null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002BC7 File Offset: 0x00000DC7
		[global::Cpp2ILInjected.Token(Token = "0x60003E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A32D4", Offset = "0x19A32D4", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "UpdateTouches", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "RequestActivation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "set_controlsEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "SendTouchEnded", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "SendTouchMoved", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "SendTouchBegan", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void InvokeTouchEvents()
		{
			throw null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002BCA File Offset: 0x00000DCA
		[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A365C", Offset = "0x19A365C", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ConvertScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ConvertViewToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ConvertScreenToViewPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "GetCurrentScreenSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "IsZero", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool TouchCameraIsValid()
		{
			throw null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002BCD File Offset: 0x00000DCD
		[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A3838", Offset = "0x19A3838", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "TouchCameraIsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private Vector3 ConvertScreenToWorldPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002BD0 File Offset: 0x00000DD0
		[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A3044", Offset = "0x19A3044", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "UpdateScreenSize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ViewToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "TouchCameraIsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ViewportToWorldPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private Vector3 ConvertViewToWorldPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002BD3 File Offset: 0x00000DD3
		[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A38CC", Offset = "0x19A38CC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ScreenToViewPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "TouchCameraIsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenToViewportPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private Vector3 ConvertScreenToViewPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002BD6 File Offset: 0x00000DD6
		[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A22F8", Offset = "0x19A22F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager.<UpdateScreenSizeAtEndOfFrame>d__28), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "Setup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "TouchCameraIsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		private Vector2 GetCurrentScreenSize()
		{
			throw null;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00002BD9 File Offset: 0x00000DD9
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00002BDC File Offset: 0x00000DDC
		[global::Cpp2ILInjected.Token(Token = "0x17000127")]
		public bool controlsEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A3960", Offset = "0x19A3960", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A35D0", Offset = "0x19A35D0", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "InvokeTouchEvents", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "set_ControlsEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00002BDF File Offset: 0x00000DDF
		[global::Cpp2ILInjected.Token(Token = "0x17000128")]
		public static ReadOnlyCollection<Touch> Touches
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A3968", Offset = "0x19A3968", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00002BE2 File Offset: 0x00000DE2
		[global::Cpp2ILInjected.Token(Token = "0x17000129")]
		public static int TouchCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E2EC", Offset = "0x199E2EC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "SubmitControlState", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002BE5 File Offset: 0x00000DE5
		[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E368", Offset = "0x199E368", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Touch GetTouch(int touchIndex)
		{
			throw null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002BE8 File Offset: 0x00000DE8
		[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A39D4", Offset = "0x19A39D4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Touch GetTouchByFingerId(int fingerId)
		{
			throw null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002BEB File Offset: 0x00000DEB
		[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F490", Offset = "0x199F490", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchBegan", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchMoved", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "TouchBegan", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "TouchMoved", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "TouchEnded", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "TouchBegan", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "TouchEnded", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Contains", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ConvertScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Vector3 ScreenToWorldPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002BEE File Offset: 0x00000DEE
		[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1648", Offset = "0x19A1648", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OffsetToWorldPosition", MemberParameters = new object[]
		{
			typeof(TouchControlAnchor),
			typeof(Vector2),
			typeof(TouchUnitType),
			typeof(bool)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ConvertViewToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Vector3 ViewToWorldPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002BF1 File Offset: 0x00000DF1
		[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A09A4", Offset = "0x19A09A4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "TouchBegan", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "TouchMoved", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ConvertScreenToViewPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Vector3 ScreenToViewPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EC58", Offset = "0x199EC58", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PixelToWorld", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PercentToWorld", ReturnType = typeof(float))]
		public static float ConvertToWorld(float value, TouchUnitType unitType)
		{
			throw null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002BF7 File Offset: 0x00000DF7
		[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A3AFC", Offset = "0x19A3AFC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ConvertToWorld", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(TouchUnitType)
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_ViewSize", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Rect PercentToWorldRect(Rect rect)
		{
			throw null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002BFA File Offset: 0x00000DFA
		[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A3BD0", Offset = "0x19A3BD0", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ConvertToWorld", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(TouchUnitType)
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_HalfScreenSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PixelToWorld", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Rect PixelToWorldRect(Rect rect)
		{
			throw null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002BFD File Offset: 0x00000DFD
		[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EC48", Offset = "0x199EC48", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "ConfigureControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "ConfigureControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "ConfigureControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "PixelToWorldRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "PercentToWorldRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(Rect))]
		public static Rect ConvertToWorld(Rect rect, TouchUnitType unitType)
		{
			throw null;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00002C00 File Offset: 0x00000E00
		[global::Cpp2ILInjected.Token(Token = "0x1700012A")]
		public static Camera Camera
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A3F08", Offset = "0x19A3F08", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00002C03 File Offset: 0x00000E03
		[global::Cpp2ILInjected.Token(Token = "0x1700012B")]
		public static InputDevice Device
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A16C8", Offset = "0x19A16C8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "SubmitButtonState", MemberParameters = new object[]
			{
				typeof(TouchControl.ButtonTarget),
				typeof(bool),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "SubmitButtonValue", MemberParameters = new object[]
			{
				typeof(TouchControl.ButtonTarget),
				typeof(float),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "CommitButton", MemberParameters = new object[] { typeof(TouchControl.ButtonTarget) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "SubmitAnalogValue", MemberParameters = new object[]
			{
				typeof(TouchControl.AnalogTarget),
				typeof(Vector2),
				typeof(float),
				typeof(float),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "CommitAnalog", MemberParameters = new object[] { typeof(TouchControl.AnalogTarget) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "SubmitRawAnalogValue", MemberParameters = new object[]
			{
				typeof(TouchControl.AnalogTarget),
				typeof(Vector2),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "InvokeTouchEvents", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00002C06 File Offset: 0x00000E06
		[global::Cpp2ILInjected.Token(Token = "0x1700012C")]
		public static Vector3 ViewSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A156C", Offset = "0x19A156C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OffsetToWorldPosition", MemberParameters = new object[]
			{
				typeof(TouchControlAnchor),
				typeof(Vector2),
				typeof(TouchUnitType),
				typeof(bool)
			}, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "PercentToWorldRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "ScaleSpriteInPercent", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(SpriteRenderer),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00002C09 File Offset: 0x00000E09
		[global::Cpp2ILInjected.Token(Token = "0x1700012D")]
		public static float PercentToWorld
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A1500", Offset = "0x19A1500", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "ConfigureControl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OffsetToWorldPosition", MemberParameters = new object[]
			{
				typeof(TouchControlAnchor),
				typeof(Vector2),
				typeof(TouchUnitType),
				typeof(bool)
			}, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ConvertToWorld", MemberParameters = new object[]
			{
				typeof(float),
				typeof(TouchUnitType)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00002C0C File Offset: 0x00000E0C
		[global::Cpp2ILInjected.Token(Token = "0x1700012E")]
		public static float HalfPercentToWorld
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A3F74", Offset = "0x19A3F74", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00002C0F File Offset: 0x00000E0F
		[global::Cpp2ILInjected.Token(Token = "0x1700012F")]
		public static float PixelToWorld
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A1494", Offset = "0x19A1494", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "ConfigureControl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OffsetToWorldPosition", MemberParameters = new object[]
			{
				typeof(TouchControlAnchor),
				typeof(Vector2),
				typeof(TouchUnitType),
				typeof(bool)
			}, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "ConvertToWorld", MemberParameters = new object[]
			{
				typeof(float),
				typeof(TouchUnitType)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "PixelToWorldRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "ScaleSpriteInPixels", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(SpriteRenderer),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00002C12 File Offset: 0x00000E12
		[global::Cpp2ILInjected.Token(Token = "0x17000130")]
		public static float HalfPixelToWorld
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A3FE0", Offset = "0x19A3FE0", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00002C15 File Offset: 0x00000E15
		[global::Cpp2ILInjected.Token(Token = "0x17000131")]
		public static Vector2 ScreenSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000400")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A404C", Offset = "0x19A404C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00002C18 File Offset: 0x00000E18
		[global::Cpp2ILInjected.Token(Token = "0x17000132")]
		public static Vector2 HalfScreenSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000401")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A3E9C", Offset = "0x19A3E9C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "PixelToWorldRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00002C1B File Offset: 0x00000E1B
		[global::Cpp2ILInjected.Token(Token = "0x17000133")]
		public static TouchManager.GizmoShowOption ControlsShowGizmos
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000402")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A1B1C", Offset = "0x19A1B1C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OnDrawGizmos", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00002C1E File Offset: 0x00000E1E
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00002C21 File Offset: 0x00000E21
		[global::Cpp2ILInjected.Token(Token = "0x17000134")]
		public static bool ControlsEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000403")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A40B8", Offset = "0x19A40B8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000404")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4124", Offset = "0x19A4124", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "set_controlsEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002C24 File Offset: 0x00000E24
		[global::Cpp2ILInjected.Token(Token = "0x6000405")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A4194", Offset = "0x19A4194", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator bool(TouchManager instance)
		{
			throw null;
		}

		// Token: 0x04000351 RID: 849
		[Space(10f)]
		[global::Cpp2ILInjected.Token(Token = "0x4000395")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Camera touchCamera;

		// Token: 0x04000352 RID: 850
		[global::Cpp2ILInjected.Token(Token = "0x4000396")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TouchManager.GizmoShowOption controlsShowGizmos;

		// Token: 0x04000353 RID: 851
		[HideInInspector]
		[global::Cpp2ILInjected.Token(Token = "0x4000397")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool enableControlsOnTouch;

		// Token: 0x04000354 RID: 852
		[SerializeField]
		[HideInInspector]
		[global::Cpp2ILInjected.Token(Token = "0x4000398")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
		private bool _controlsEnabled;

		// Token: 0x04000355 RID: 853
		[HideInInspector]
		[global::Cpp2ILInjected.Token(Token = "0x4000399")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int controlsLayer;

		// Token: 0x04000356 RID: 854
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400039A")]
		private static Action OnSetup;

		// Token: 0x04000357 RID: 855
		[global::Cpp2ILInjected.Token(Token = "0x400039B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private InputDevice device;

		// Token: 0x04000358 RID: 856
		[global::Cpp2ILInjected.Token(Token = "0x400039C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Vector3 viewSize;

		// Token: 0x04000359 RID: 857
		[global::Cpp2ILInjected.Token(Token = "0x400039D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private Vector2 screenSize;

		// Token: 0x0400035A RID: 858
		[global::Cpp2ILInjected.Token(Token = "0x400039E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private Vector2 halfScreenSize;

		// Token: 0x0400035B RID: 859
		[global::Cpp2ILInjected.Token(Token = "0x400039F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private float percentToWorld;

		// Token: 0x0400035C RID: 860
		[global::Cpp2ILInjected.Token(Token = "0x40003A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private float halfPercentToWorld;

		// Token: 0x0400035D RID: 861
		[global::Cpp2ILInjected.Token(Token = "0x40003A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private float pixelToWorld;

		// Token: 0x0400035E RID: 862
		[global::Cpp2ILInjected.Token(Token = "0x40003A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private float halfPixelToWorld;

		// Token: 0x0400035F RID: 863
		[global::Cpp2ILInjected.Token(Token = "0x40003A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private TouchControl[] touchControls;

		// Token: 0x04000360 RID: 864
		[global::Cpp2ILInjected.Token(Token = "0x40003A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private TouchPool cachedTouches;

		// Token: 0x04000361 RID: 865
		[global::Cpp2ILInjected.Token(Token = "0x40003A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private List<Touch> activeTouches;

		// Token: 0x04000362 RID: 866
		[global::Cpp2ILInjected.Token(Token = "0x40003A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private ReadOnlyCollection<Touch> readOnlyActiveTouches;

		// Token: 0x04000363 RID: 867
		[global::Cpp2ILInjected.Token(Token = "0x40003A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool isReady;

		// Token: 0x04000364 RID: 868
		[global::Cpp2ILInjected.Token(Token = "0x40003A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private readonly Touch[] mouseTouches;

		// Token: 0x020001F2 RID: 498
		[global::Cpp2ILInjected.Token(Token = "0x2000054")]
		public enum GizmoShowOption
		{
			// Token: 0x04000417 RID: 1047
			[global::Cpp2ILInjected.Token(Token = "0x40003AA")]
			Never,
			// Token: 0x04000418 RID: 1048
			[global::Cpp2ILInjected.Token(Token = "0x40003AB")]
			WhenSelected,
			// Token: 0x04000419 RID: 1049
			[global::Cpp2ILInjected.Token(Token = "0x40003AC")]
			UnlessPlaying,
			// Token: 0x0400041A RID: 1050
			[global::Cpp2ILInjected.Token(Token = "0x40003AD")]
			Always
		}

		// Token: 0x020001F3 RID: 499
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000055")]
		private sealed class <UpdateScreenSizeAtEndOfFrame>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000859 RID: 2137 RVA: 0x00003938 File Offset: 0x00001B38
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000406")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A2B18", Offset = "0x19A2B18", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <UpdateScreenSizeAtEndOfFrame>d__28(int <>1__state)
			{
				throw null;
			}

			// Token: 0x0600085A RID: 2138 RVA: 0x0000393B File Offset: 0x00001B3B
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000407")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A41F0", Offset = "0x19A41F0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x0600085B RID: 2139 RVA: 0x0000393E File Offset: 0x00001B3E
			[global::Cpp2ILInjected.Token(Token = "0x6000408")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A41F4", Offset = "0x19A41F4", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitForEndOfFrame), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "GetCurrentScreenSize", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "UpdateScreenSize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x0600085C RID: 2140 RVA: 0x00003941 File Offset: 0x00001B41
			[global::Cpp2ILInjected.Token(Token = "0x17000135")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000409")]
				[global::Cpp2ILInjected.Address(RVA = "0x19A42AC", Offset = "0x19A42AC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600085D RID: 2141 RVA: 0x00003944 File Offset: 0x00001B44
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600040A")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A42B4", Offset = "0x19A42B4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x0600085E RID: 2142 RVA: 0x00003947 File Offset: 0x00001B47
			[global::Cpp2ILInjected.Token(Token = "0x17000136")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600040B")]
				[global::Cpp2ILInjected.Address(RVA = "0x19A42EC", Offset = "0x19A42EC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400041B RID: 1051
			[global::Cpp2ILInjected.Token(Token = "0x40003AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400041C RID: 1052
			[global::Cpp2ILInjected.Token(Token = "0x40003AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400041D RID: 1053
			[global::Cpp2ILInjected.Token(Token = "0x40003B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public TouchManager <>4__this;
		}
	}
}
