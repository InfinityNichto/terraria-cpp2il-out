﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000069 RID: 105
	[AddComponentMenu("Event/Standalone Input Module")]
	[global::Cpp2ILInjected.Token(Token = "0x20000B7")]
	public class StandaloneInputModule : PointerInputModule
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x00003187 File Offset: 0x00001387
		[global::Cpp2ILInjected.Token(Token = "0x6000692")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEA7E4", Offset = "0x1FEA7E4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected StandaloneInputModule()
		{
			throw null;
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0000318A File Offset: 0x0000138A
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x170001BA")]
		public StandaloneInputModule.InputMode inputMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000693")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8A0", Offset = "0x1FEA8A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0000318D File Offset: 0x0000138D
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00003190 File Offset: 0x00001390
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		[global::Cpp2ILInjected.Token(Token = "0x170001BB")]
		public bool allowActivationOnMobileDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000694")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8A8", Offset = "0x1FEA8A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000695")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8B0", Offset = "0x1FEA8B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00003193 File Offset: 0x00001393
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00003196 File Offset: 0x00001396
		[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
		[global::Cpp2ILInjected.Token(Token = "0x170001BC")]
		public bool forceModuleActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000696")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8BC", Offset = "0x1FEA8BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000697")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8C4", Offset = "0x1FEA8C4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00003199 File Offset: 0x00001399
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x0000319C File Offset: 0x0000139C
		[global::Cpp2ILInjected.Token(Token = "0x170001BD")]
		public float inputActionsPerSecond
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000698")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8D0", Offset = "0x1FEA8D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000699")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8D8", Offset = "0x1FEA8D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0000319F File Offset: 0x0000139F
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x000031A2 File Offset: 0x000013A2
		[global::Cpp2ILInjected.Token(Token = "0x170001BE")]
		public float repeatDelay
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8E0", Offset = "0x1FEA8E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600069B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8E8", Offset = "0x1FEA8E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x000031A5 File Offset: 0x000013A5
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000031A8 File Offset: 0x000013A8
		[global::Cpp2ILInjected.Token(Token = "0x170001BF")]
		public string horizontalAxis
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8F0", Offset = "0x1FEA8F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600069D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA8F8", Offset = "0x1FEA8F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x000031AB File Offset: 0x000013AB
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x000031AE File Offset: 0x000013AE
		[global::Cpp2ILInjected.Token(Token = "0x170001C0")]
		public string verticalAxis
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA900", Offset = "0x1FEA900", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600069F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA908", Offset = "0x1FEA908", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x000031B1 File Offset: 0x000013B1
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x000031B4 File Offset: 0x000013B4
		[global::Cpp2ILInjected.Token(Token = "0x170001C1")]
		public string submitButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA910", Offset = "0x1FEA910", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA918", Offset = "0x1FEA918", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x000031B7 File Offset: 0x000013B7
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x000031BA File Offset: 0x000013BA
		[global::Cpp2ILInjected.Token(Token = "0x170001C2")]
		public string cancelButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA920", Offset = "0x1FEA920", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA928", Offset = "0x1FEA928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000031BD File Offset: 0x000013BD
		[global::Cpp2ILInjected.Token(Token = "0x60006A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEA930", Offset = "0x1FEA930", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			throw null;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000031C0 File Offset: 0x000013C0
		[global::Cpp2ILInjected.Token(Token = "0x60006A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEA938", Offset = "0x1FEA938", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void UpdateModule()
		{
			throw null;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000031C3 File Offset: 0x000013C3
		[global::Cpp2ILInjected.Token(Token = "0x60006A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEA9F8", Offset = "0x1FEA9F8", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "UpdateModule", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
		{
			throw null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000031C6 File Offset: 0x000013C6
		[global::Cpp2ILInjected.Token(Token = "0x60006A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEAD5C", Offset = "0x1FEAD5C", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "ShouldActivateModule", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool ShouldActivateModule()
		{
			throw null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000031C9 File Offset: 0x000013C9
		[global::Cpp2ILInjected.Token(Token = "0x60006A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEAF50", Offset = "0x1FEAF50", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void ActivateModule()
		{
			throw null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000031CC File Offset: 0x000013CC
		[global::Cpp2ILInjected.Token(Token = "0x60006A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEB034", Offset = "0x1FEB034", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "ClearSelection", ReturnType = typeof(void))]
		public override void DeactivateModule()
		{
			throw null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000031CF File Offset: 0x000013CF
		[global::Cpp2ILInjected.Token(Token = "0x60006AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEB038", Offset = "0x1FEB038", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "SendUpdateEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "SendMoveEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "SendSubmitEventToSelectedObject", ReturnType = typeof(bool))]
		public override void Process()
		{
			throw null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000031D2 File Offset: 0x000013D2
		[global::Cpp2ILInjected.Token(Token = "0x60006AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEB208", Offset = "0x1FEB208", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_type", ReturnType = typeof(TouchType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new object[]
		{
			typeof(Touch),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(PointerEventData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "RemovePointerData", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ProcessTouchEvents()
		{
			throw null;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000031D5 File Offset: 0x000013D5
		[global::Cpp2ILInjected.Token(Token = "0x60006AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEB7D0", Offset = "0x1FEB7D0", Length = "0x65C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			throw null;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000031D8 File Offset: 0x000013D8
		[global::Cpp2ILInjected.Token(Token = "0x60006AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEB5E0", Offset = "0x1FEB5E0", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected bool SendSubmitEventToSelectedObject()
		{
			throw null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000031DB File Offset: 0x000013DB
		[global::Cpp2ILInjected.Token(Token = "0x60006AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEBE2C", Offset = "0x1FEBE2C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "SendMoveEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private Vector2 GetRawMoveVector()
		{
			throw null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000031DE File Offset: 0x000013DE
		[global::Cpp2ILInjected.Token(Token = "0x60006AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEB388", Offset = "0x1FEB388", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "GetRawMoveVector", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected bool SendMoveEventToSelectedObject()
		{
			throw null;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000031E1 File Offset: 0x000013E1
		[global::Cpp2ILInjected.Token(Token = "0x60006B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEB380", Offset = "0x1FEB380", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		protected void ProcessMouseEvent()
		{
			throw null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000031E4 File Offset: 0x000013E4
		[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
		[global::Cpp2ILInjected.Token(Token = "0x60006B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC19C", Offset = "0x1FEC19C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual bool ForceAutoSelect()
		{
			throw null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000031E7 File Offset: 0x000013E7
		[global::Cpp2ILInjected.Token(Token = "0x60006B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEBF28", Offset = "0x1FEBF28", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule.MouseState), Member = "GetButtonState", MemberParameters = new object[] { typeof(PointerEventData.InputButton) }, ReturnType = typeof(PointerInputModule.ButtonState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected void ProcessMouseEvent(int id)
		{
			throw null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000031EA File Offset: 0x000013EA
		[global::Cpp2ILInjected.Token(Token = "0x60006B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEB0CC", Offset = "0x1FEB0CC", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected bool SendUpdateEventToSelectedObject()
		{
			throw null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000031ED File Offset: 0x000013ED
		[global::Cpp2ILInjected.Token(Token = "0x60006B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC1A4", Offset = "0x1FEC1A4", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
			throw null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000031F0 File Offset: 0x000013F0
		[global::Cpp2ILInjected.Token(Token = "0x60006B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC4EC", Offset = "0x1FEC4EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected GameObject GetCurrentFocusedGameObject()
		{
			throw null;
		}

		// Token: 0x0400020A RID: 522
		[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private float m_PrevActionTime;

		// Token: 0x0400020B RID: 523
		[global::Cpp2ILInjected.Token(Token = "0x40002FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private Vector2 m_LastMoveVector;

		// Token: 0x0400020C RID: 524
		[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private int m_ConsecutiveMoveCount;

		// Token: 0x0400020D RID: 525
		[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Vector2 m_LastMousePosition;

		// Token: 0x0400020E RID: 526
		[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Vector2 m_MousePosition;

		// Token: 0x0400020F RID: 527
		[global::Cpp2ILInjected.Token(Token = "0x4000300")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private GameObject m_CurrentFocusedGameObject;

		// Token: 0x04000210 RID: 528
		[global::Cpp2ILInjected.Token(Token = "0x4000301")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private PointerEventData m_InputPointerEvent;

		// Token: 0x04000211 RID: 529
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000302")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string m_HorizontalAxis;

		// Token: 0x04000212 RID: 530
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000303")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string m_VerticalAxis;

		// Token: 0x04000213 RID: 531
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000304")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private string m_SubmitButton;

		// Token: 0x04000214 RID: 532
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000305")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string m_CancelButton;

		// Token: 0x04000215 RID: 533
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000306")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private float m_InputActionsPerSecond;

		// Token: 0x04000216 RID: 534
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000307")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		private float m_RepeatDelay;

		// Token: 0x04000217 RID: 535
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		[HideInInspector]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000308")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private bool m_ForceModuleActive;

		// Token: 0x020000CD RID: 205
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x20000B8")]
		public enum InputMode
		{
			// Token: 0x0400033B RID: 827
			[global::Cpp2ILInjected.Token(Token = "0x400030A")]
			Mouse,
			// Token: 0x0400033C RID: 828
			[global::Cpp2ILInjected.Token(Token = "0x400030B")]
			Buttons
		}
	}
}
