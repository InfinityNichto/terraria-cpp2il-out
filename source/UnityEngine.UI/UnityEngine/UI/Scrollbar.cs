﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000032 RID: 50
	[AddComponentMenu("UI/Scrollbar", 36)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[global::Cpp2ILInjected.Token(Token = "0x200005E")]
	public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00002989 File Offset: 0x00000B89
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000298C File Offset: 0x00000B8C
		[global::Cpp2ILInjected.Token(Token = "0x170000EC")]
		public RectTransform handleRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD2C78", Offset = "0x1FD2C78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600038B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD2C80", Offset = "0x1FD2C80", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000298F File Offset: 0x00000B8F
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00002992 File Offset: 0x00000B92
		[global::Cpp2ILInjected.Token(Token = "0x170000ED")]
		public Scrollbar.Direction direction
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD2F54", Offset = "0x1FD2F54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600038D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD2F5C", Offset = "0x1FD2F5C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "SetDirection", MemberParameters = new object[]
			{
				typeof(Scrollbar.Direction),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002995 File Offset: 0x00000B95
		[global::Cpp2ILInjected.Token(Token = "0x600038E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD2FD0", Offset = "0x1FD2FD0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar.ScrollEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected Scrollbar()
		{
			throw null;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00002998 File Offset: 0x00000B98
		// (set) Token: 0x06000336 RID: 822 RVA: 0x0000299B File Offset: 0x00000B9B
		[global::Cpp2ILInjected.Token(Token = "0x170000EE")]
		public float value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD31EC", Offset = "0x1FD31EC", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar.<ClickRepeat>d__58), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new object[]
			{
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new object[] { typeof(AxisEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000390")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD32A4", Offset = "0x1FD32A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000299E File Offset: 0x00000B9E
		[global::Cpp2ILInjected.Token(Token = "0x6000391")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3368", Offset = "0x1FD3368", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public virtual void SetValueWithoutNotify(float input)
		{
			throw null;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000338 RID: 824 RVA: 0x000029A1 File Offset: 0x00000BA1
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000029A4 File Offset: 0x00000BA4
		[global::Cpp2ILInjected.Token(Token = "0x170000EF")]
		public float size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000392")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD3370", Offset = "0x1FD3370", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000393")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD3378", Offset = "0x1FD3378", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600033A RID: 826 RVA: 0x000029A7 File Offset: 0x00000BA7
		// (set) Token: 0x0600033B RID: 827 RVA: 0x000029AA File Offset: 0x00000BAA
		[global::Cpp2ILInjected.Token(Token = "0x170000F0")]
		public int numberOfSteps
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000394")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD33FC", Offset = "0x1FD33FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000395")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD3404", Offset = "0x1FD3404", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new object[]
			{
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000029AD File Offset: 0x00000BAD
		// (set) Token: 0x0600033D RID: 829 RVA: 0x000029B0 File Offset: 0x00000BB0
		[global::Cpp2ILInjected.Token(Token = "0x170000F1")]
		public Scrollbar.ScrollEvent onValueChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000396")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD3488", Offset = "0x1FD3488", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000397")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD3490", Offset = "0x1FD3490", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600033E RID: 830 RVA: 0x000029B3 File Offset: 0x00000BB3
		[global::Cpp2ILInjected.Token(Token = "0x170000F2")]
		private float stepSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000398")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD3498", Offset = "0x1FD3498", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000029B6 File Offset: 0x00000BB6
		[global::Cpp2ILInjected.Token(Token = "0x6000399")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD34C4", Offset = "0x1FD34C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Rebuild(CanvasUpdate executing)
		{
			throw null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000029B9 File Offset: 0x00000BB9
		[global::Cpp2ILInjected.Token(Token = "0x600039A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD34C8", Offset = "0x1FD34C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void LayoutComplete()
		{
			throw null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000029BC File Offset: 0x00000BBC
		[global::Cpp2ILInjected.Token(Token = "0x600039B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD34CC", Offset = "0x1FD34CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void GraphicUpdateComplete()
		{
			throw null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000029BF File Offset: 0x00000BBF
		[global::Cpp2ILInjected.Token(Token = "0x600039C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD34D0", Offset = "0x1FD34D0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000029C2 File Offset: 0x00000BC2
		[global::Cpp2ILInjected.Token(Token = "0x600039D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3780", Offset = "0x1FD3780", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000029C5 File Offset: 0x00000BC5
		[global::Cpp2ILInjected.Token(Token = "0x600039E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3894", Offset = "0x1FD3894", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000029C8 File Offset: 0x00000BC8
		[global::Cpp2ILInjected.Token(Token = "0x600039F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD2CFC", Offset = "0x1FD2CFC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "set_handleRect", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void UpdateCachedReferences()
		{
			throw null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000029CB File Offset: 0x00000BCB
		[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD32AC", Offset = "0x1FD32AC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar.<ClickRepeat>d__58), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "SetValueWithoutNotify", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "set_numberOfSteps", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "DoUpdateDrag", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new object[] { typeof(AxisEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "get_value", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "Invoke", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Set(float input, bool sendCallback = true)
		{
			throw null;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000029CE File Offset: 0x00000BCE
		[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD38A8", Offset = "0x1FD38A8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		protected override void OnRectTransformDimensionsChange()
		{
			throw null;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000029D1 File Offset: 0x00000BD1
		[global::Cpp2ILInjected.Token(Token = "0x170000F3")]
		private Scrollbar.Axis axis
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD38E0", Offset = "0x1FD38E0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000029D4 File Offset: 0x00000BD4
		[global::Cpp2ILInjected.Token(Token = "0x170000F4")]
		private bool reverseValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD38F0", Offset = "0x1FD38F0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000029D7 File Offset: 0x00000BD7
		[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD2DCC", Offset = "0x1FD2DCC", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "set_handleRect", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "set_direction", MemberParameters = new object[] { typeof(Scrollbar.Direction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "set_numberOfSteps", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Add", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(RectTransform),
			typeof(DrivenTransformProperties)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "get_value", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void UpdateVisuals()
		{
			throw null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000029DA File Offset: 0x00000BDA
		[global::Cpp2ILInjected.Token(Token = "0x60003A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3904", Offset = "0x1FD3904", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "DoUpdateDrag", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void UpdateDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000029DD File Offset: 0x00000BDD
		[global::Cpp2ILInjected.Token(Token = "0x60003A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3B5C", Offset = "0x1FD3B5C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize)
		{
			throw null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000029E0 File Offset: 0x00000BE0
		[global::Cpp2ILInjected.Token(Token = "0x60003A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3BC0", Offset = "0x1FD3BC0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool MayDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000029E3 File Offset: 0x00000BE3
		[global::Cpp2ILInjected.Token(Token = "0x60003A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3C1C", Offset = "0x1FD3C1C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000029E6 File Offset: 0x00000BE6
		[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3DF0", Offset = "0x1FD3DF0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void OnDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000029E9 File Offset: 0x00000BE9
		[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3EA4", Offset = "0x1FD3EA4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Camera)
		}, ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		public override void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000029EC File Offset: 0x00000BEC
		[global::Cpp2ILInjected.Token(Token = "0x60003AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD40F0", Offset = "0x1FD40F0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Camera)
		}, ReturnType = typeof(IEnumerator))]
		protected IEnumerator ClickRepeat(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000029EF File Offset: 0x00000BEF
		[global::Cpp2ILInjected.Token(Token = "0x60003AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD406C", Offset = "0x1FD406C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera)
		{
			throw null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000029F2 File Offset: 0x00000BF2
		[global::Cpp2ILInjected.Token(Token = "0x60003AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD4150", Offset = "0x1FD4150", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
		public override void OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::Cpp2ILInjected.Token(Token = "0x60003AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD418C", Offset = "0x1FD418C", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "get_value", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void OnMove(AxisEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000029F8 File Offset: 0x00000BF8
		[global::Cpp2ILInjected.Token(Token = "0x60003AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD44CC", Offset = "0x1FD44CC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override Selectable FindSelectableOnLeft()
		{
			throw null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000029FB File Offset: 0x00000BFB
		[global::Cpp2ILInjected.Token(Token = "0x60003B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD45C0", Offset = "0x1FD45C0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override Selectable FindSelectableOnRight()
		{
			throw null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000029FE File Offset: 0x00000BFE
		[global::Cpp2ILInjected.Token(Token = "0x60003B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD46B4", Offset = "0x1FD46B4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override Selectable FindSelectableOnUp()
		{
			throw null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002A01 File Offset: 0x00000C01
		[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD47A8", Offset = "0x1FD47A8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override Selectable FindSelectableOnDown()
		{
			throw null;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002A04 File Offset: 0x00000C04
		[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD489C", Offset = "0x1FD489C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002A07 File Offset: 0x00000C07
		[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD48A4", Offset = "0x1FD48A4", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "set_direction", MemberParameters = new object[] { typeof(Scrollbar.Direction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutAxes", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts)
		{
			throw null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002A0A File Offset: 0x00000C0A
		[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD4A1C", Offset = "0x1FD4A1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			throw null;
		}

		// Token: 0x0400011A RID: 282
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private RectTransform m_HandleRect;

		// Token: 0x0400011B RID: 283
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private Scrollbar.Direction m_Direction;

		// Token: 0x0400011C RID: 284
		[SerializeField]
		[Range(0f, 1f)]
		[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		private float m_Value;

		// Token: 0x0400011D RID: 285
		[SerializeField]
		[Range(0f, 1f)]
		[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private float m_Size;

		// Token: 0x0400011E RID: 286
		[Range(0f, 11f)]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
		private int m_NumberOfSteps;

		// Token: 0x0400011F RID: 287
		[Space(6f)]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private Scrollbar.ScrollEvent m_OnValueChanged;

		// Token: 0x04000120 RID: 288
		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private RectTransform m_ContainerRect;

		// Token: 0x04000121 RID: 289
		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private Vector2 m_Offset;

		// Token: 0x04000122 RID: 290
		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x04000123 RID: 291
		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private Coroutine m_PointerDownRepeat;

		// Token: 0x04000124 RID: 292
		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private bool isPointerDownAndNotDragging;

		// Token: 0x04000125 RID: 293
		[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x139")]
		private bool m_DelayedUpdateVisuals;

		// Token: 0x020000AB RID: 171
		[global::Cpp2ILInjected.Token(Token = "0x200005F")]
		public enum Direction
		{
			// Token: 0x040002EB RID: 747
			[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
			LeftToRight,
			// Token: 0x040002EC RID: 748
			[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
			RightToLeft,
			// Token: 0x040002ED RID: 749
			[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
			BottomToTop,
			// Token: 0x040002EE RID: 750
			[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
			TopToBottom
		}

		// Token: 0x020000AC RID: 172
		[global::Cpp2ILInjected.Token(Token = "0x2000060")]
		[Serializable]
		public class ScrollEvent : UnityEvent<float>
		{
			// Token: 0x060006BE RID: 1726 RVA: 0x000033CA File Offset: 0x000015CA
			[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD3090", Offset = "0x1FD3090", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public ScrollEvent()
			{
				throw null;
			}
		}

		// Token: 0x020000AD RID: 173
		[global::Cpp2ILInjected.Token(Token = "0x2000061")]
		private enum Axis
		{
			// Token: 0x040002F0 RID: 752
			[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
			Horizontal,
			// Token: 0x040002F1 RID: 753
			[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
			Vertical
		}

		// Token: 0x020000AE RID: 174
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000062")]
		private sealed class <ClickRepeat>d__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060006BF RID: 1727 RVA: 0x000033CD File Offset: 0x000015CD
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4128", Offset = "0x1FD4128", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <ClickRepeat>d__58(int <>1__state)
			{
				throw null;
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x000033D0 File Offset: 0x000015D0
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4A24", Offset = "0x1FD4A24", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x000033D3 File Offset: 0x000015D3
			[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4A28", Offset = "0x1FD4A28", Length = "0x268")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(Vector2),
				typeof(Camera),
				typeof(ref Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "get_value", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new object[]
			{
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new object[] { typeof(Coroutine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitForEndOfFrame), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x060006C2 RID: 1730 RVA: 0x000033D6 File Offset: 0x000015D6
			[global::Cpp2ILInjected.Token(Token = "0x170000F5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FD4C90", Offset = "0x1FD4C90", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x000033D9 File Offset: 0x000015D9
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4C98", Offset = "0x1FD4C98", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x060006C4 RID: 1732 RVA: 0x000033DC File Offset: 0x000015DC
			[global::Cpp2ILInjected.Token(Token = "0x170000F6")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FD4CD0", Offset = "0x1FD4CD0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040002F2 RID: 754
			[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040002F3 RID: 755
			[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040002F4 RID: 756
			[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Scrollbar <>4__this;

			// Token: 0x040002F5 RID: 757
			[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Vector2 screenPosition;

			// Token: 0x040002F6 RID: 758
			[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public Camera camera;
		}
	}
}
