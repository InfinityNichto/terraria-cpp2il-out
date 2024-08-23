﻿using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000062 RID: 98
	[AddComponentMenu("Event/Event System")]
	[DisallowMultipleComponent]
	[global::Cpp2ILInjected.Token(Token = "0x20000AA")]
	public class EventSystem : UIBehaviour
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00002FB0 File Offset: 0x000011B0
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00002FB3 File Offset: 0x000011B3
		[global::Cpp2ILInjected.Token(Token = "0x1700018E")]
		public static EventSystem current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4C74", Offset = "0x1FE4C74", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown.DropdownItem), Member = "OnPointerEnter", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "Select", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventSystem), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4D28", Offset = "0x1FE4D28", Length = "0x194")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Insert", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00002FB6 File Offset: 0x000011B6
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00002FB9 File Offset: 0x000011B9
		[global::Cpp2ILInjected.Token(Token = "0x1700018F")]
		public bool sendNavigationEvents
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4EBC", Offset = "0x1FE4EBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4EC4", Offset = "0x1FE4EC4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00002FBC File Offset: 0x000011BC
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00002FBF File Offset: 0x000011BF
		[global::Cpp2ILInjected.Token(Token = "0x17000190")]
		public int pixelDragThreshold
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4ED0", Offset = "0x1FE4ED0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4ED8", Offset = "0x1FE4ED8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00002FC2 File Offset: 0x000011C2
		[global::Cpp2ILInjected.Token(Token = "0x17000191")]
		public BaseInputModule currentInputModule
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4EE0", Offset = "0x1FE4EE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00002FC5 File Offset: 0x000011C5
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00002FC8 File Offset: 0x000011C8
		[global::Cpp2ILInjected.Token(Token = "0x17000192")]
		public GameObject firstSelectedGameObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4EE8", Offset = "0x1FE4EE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4EF0", Offset = "0x1FE4EF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00002FCB File Offset: 0x000011CB
		[global::Cpp2ILInjected.Token(Token = "0x17000193")]
		public GameObject currentSelectedGameObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4EF8", Offset = "0x1FE4EF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00002FCE File Offset: 0x000011CE
		[Obsolete("lastSelectedGameObject is no longer supported")]
		[global::Cpp2ILInjected.Token(Token = "0x17000194")]
		public GameObject lastSelectedGameObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4F00", Offset = "0x1FE4F00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00002FD1 File Offset: 0x000011D1
		[global::Cpp2ILInjected.Token(Token = "0x17000195")]
		public bool isFocused
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE4F08", Offset = "0x1FE4F08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002FD4 File Offset: 0x000011D4
		[global::Cpp2ILInjected.Token(Token = "0x60005ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE4F10", Offset = "0x1FE4F10", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected EventSystem()
		{
			throw null;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002FD7 File Offset: 0x000011D7
		[global::Cpp2ILInjected.Token(Token = "0x60005EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE4FA8", Offset = "0x1FE4FA8", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseInputModule), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseInputModule), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void UpdateModules()
		{
			throw null;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00002FDA File Offset: 0x000011DA
		[global::Cpp2ILInjected.Token(Token = "0x17000196")]
		public bool alreadySelecting
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE50DC", Offset = "0x1FE50DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002FDD File Offset: 0x000011DD
		[global::Cpp2ILInjected.Token(Token = "0x60005F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE398C", Offset = "0x1FE398C", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ActivateModule", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "SendVectorEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMove", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "ClearSelection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ActivateModule", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
			throw null;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00002FE0 File Offset: 0x000011E0
		[global::Cpp2ILInjected.Token(Token = "0x17000197")]
		private BaseEventData baseEventDataCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE50E4", Offset = "0x1FE50E4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002FE3 File Offset: 0x000011E3
		[global::Cpp2ILInjected.Token(Token = "0x60005F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE514C", Offset = "0x1FE514C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown.DropdownItem), Member = "OnPointerEnter", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "Select", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_baseEventDataCache", ReturnType = typeof(BaseEventData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public void SetSelectedGameObject(GameObject selected)
		{
			throw null;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00002FE6 File Offset: 0x000011E6
		[global::Cpp2ILInjected.Token(Token = "0x60005F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5178", Offset = "0x1FE5178", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseRaycaster), Member = "get_rootRaycaster", ReturnType = typeof(BaseRaycaster))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingLayer), Member = "GetLayerValueFromID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			throw null;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00002FE9 File Offset: 0x000011E9
		[global::Cpp2ILInjected.Token(Token = "0x60005F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5548", Offset = "0x1FE5548", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new object[]
		{
			typeof(Touch),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(PointerEventData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new object[] { typeof(int) }, ReturnType = "UnityEngine.EventSystems.PointerInputModule.MouseState")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RaycastResult>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<RaycastResult>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
			throw null;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002FEC File Offset: 0x000011EC
		[global::Cpp2ILInjected.Token(Token = "0x60005F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5728", Offset = "0x1FE5728", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsPointerOverGameObject()
		{
			throw null;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002FEF File Offset: 0x000011EF
		[global::Cpp2ILInjected.Token(Token = "0x60005F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5730", Offset = "0x1FE5730", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool IsPointerOverGameObject(int pointerId)
		{
			throw null;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002FF2 File Offset: 0x000011F2
		[global::Cpp2ILInjected.Token(Token = "0x60005F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE57CC", Offset = "0x1FE57CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true)
		{
			throw null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002FF5 File Offset: 0x000011F5
		[global::Cpp2ILInjected.Token(Token = "0x60005F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE57D0", Offset = "0x1FE57D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002FF8 File Offset: 0x000011F8
		[global::Cpp2ILInjected.Token(Token = "0x60005F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE57D8", Offset = "0x1FE57D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002FFB File Offset: 0x000011FB
		[global::Cpp2ILInjected.Token(Token = "0x60005FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE57E0", Offset = "0x1FE57E0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002FFE File Offset: 0x000011FE
		[global::Cpp2ILInjected.Token(Token = "0x60005FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE58A8", Offset = "0x1FE58A8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00003001 File Offset: 0x00001201
		[global::Cpp2ILInjected.Token(Token = "0x60005FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5978", Offset = "0x1FE5978", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventSystem), Member = "OnApplicationFocus", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventSystem), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void TickModules()
		{
			throw null;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00003004 File Offset: 0x00001204
		[global::Cpp2ILInjected.Token(Token = "0x60005FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5A68", Offset = "0x1FE5A68", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "TickModules", ReturnType = typeof(void))]
		protected virtual void OnApplicationFocus(bool hasFocus)
		{
			throw null;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00003007 File Offset: 0x00001207
		[global::Cpp2ILInjected.Token(Token = "0x60005FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5A7C", Offset = "0x1FE5A7C", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "TickModules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "ChangeEventModule", MemberParameters = new object[] { typeof(BaseInputModule) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000300A File Offset: 0x0000120A
		[global::Cpp2ILInjected.Token(Token = "0x60005FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5CC0", Offset = "0x1FE5CC0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventSystem), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ChangeEventModule(BaseInputModule module)
		{
			throw null;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000300D File Offset: 0x0000120D
		[global::Cpp2ILInjected.Token(Token = "0x6000600")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5DAC", Offset = "0x1FE5DAC", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00003010 File Offset: 0x00001210
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000601")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE5EF8", Offset = "0x1FE5EF8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<RaycastResult>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static EventSystem()
		{
			throw null;
		}

		// Token: 0x040001CC RID: 460
		[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<BaseInputModule> m_SystemInputModules;

		// Token: 0x040001CD RID: 461
		[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BaseInputModule m_CurrentInputModule;

		// Token: 0x040001CE RID: 462
		[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
		private static List<EventSystem> m_EventSystems;

		// Token: 0x040001CF RID: 463
		[FormerlySerializedAs("m_Selected")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private GameObject m_FirstSelected;

		// Token: 0x040001D0 RID: 464
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool m_sendNavigationEvents;

		// Token: 0x040001D1 RID: 465
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int m_DragThreshold;

		// Token: 0x040001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x40002BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private GameObject m_CurrentSelected;

		// Token: 0x040001D3 RID: 467
		[global::Cpp2ILInjected.Token(Token = "0x40002BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool m_HasFocus;

		// Token: 0x040001D4 RID: 468
		[global::Cpp2ILInjected.Token(Token = "0x40002BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool m_SelectionGuard;

		// Token: 0x040001D5 RID: 469
		[global::Cpp2ILInjected.Token(Token = "0x40002BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private BaseEventData m_DummyData;

		// Token: 0x040001D6 RID: 470
		[global::Cpp2ILInjected.Token(Token = "0x40002C0")]
		private static readonly Comparison<RaycastResult> s_RaycastComparer;
	}
}