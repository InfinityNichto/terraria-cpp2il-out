﻿using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x0200002A RID: 42
	[global::Cpp2ILInjected.Token(Token = "0x2000054")]
	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x000028A5 File Offset: 0x00000AA5
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000028A8 File Offset: 0x00000AA8
		[global::Cpp2ILInjected.Token(Token = "0x170000D8")]
		public MaskableGraphic.CullStateChangedEvent onCullStateChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x600033C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCE7D4", Offset = "0x1FCE7D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600033D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCE7DC", Offset = "0x1FCE7DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000028AB File Offset: 0x00000AAB
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x000028AE File Offset: 0x00000AAE
		[global::Cpp2ILInjected.Token(Token = "0x170000D9")]
		public bool maskable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600033E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCE7E4", Offset = "0x1FCE7E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600033F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCE7EC", Offset = "0x1FCE7EC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000028B1 File Offset: 0x00000AB1
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x000028B4 File Offset: 0x00000AB4
		[global::Cpp2ILInjected.Token(Token = "0x170000DA")]
		public bool isMaskingGraphic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000340")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCE81C", Offset = "0x1FCE81C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000341")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCDCA4", Offset = "0x1FCDCA4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000028B7 File Offset: 0x00000AB7
		[global::Cpp2ILInjected.Token(Token = "0x6000342")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCE824", Offset = "0x1FCE824", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "FindRootSortOverrideCanvas", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(Transform)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StencilMaterial), Member = "Add", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(int),
			typeof(StencilOp),
			typeof(CompareFunction),
			typeof(ColorWriteMask),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			throw null;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000028BA File Offset: 0x00000ABA
		[global::Cpp2ILInjected.Token(Token = "0x6000343")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCE924", Offset = "0x1FCE924", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Overlaps", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "UpdateCull", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public virtual void Cull(Rect clipRect, bool validRect)
		{
			throw null;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000028BD File Offset: 0x00000ABD
		[global::Cpp2ILInjected.Token(Token = "0x6000344")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCEAF4", Offset = "0x1FCEAF4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "Cull", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "set_cull", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<>), Member = "Invoke", MemberParameters = new object[] { "T0" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void UpdateCull(bool cull)
		{
			throw null;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000028C0 File Offset: 0x00000AC0
		[global::Cpp2ILInjected.Token(Token = "0x6000345")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCEBCC", Offset = "0x1FCEBCC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "EnableRectClipping", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "DisableRectClipping", ReturnType = typeof(void))]
		public virtual void SetClipRect(Rect clipRect, bool validRect)
		{
			throw null;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000028C3 File Offset: 0x00000AC3
		[global::Cpp2ILInjected.Token(Token = "0x6000346")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCEC30", Offset = "0x1FCEC30", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "set_clippingSoftness", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		public virtual void SetClipSoftness(Vector2 clipSoftness)
		{
			throw null;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000028C6 File Offset: 0x00000AC6
		[global::Cpp2ILInjected.Token(Token = "0x6000347")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCEC60", Offset = "0x1FCEC60", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "NotifyStencilStateChanged", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000028C9 File Offset: 0x00000AC9
		[global::Cpp2ILInjected.Token(Token = "0x6000348")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCEDF4", Offset = "0x1FCEDF4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "NotifyStencilStateChanged", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000028CC File Offset: 0x00000ACC
		[global::Cpp2ILInjected.Token(Token = "0x6000349")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCEEA0", Offset = "0x1FCEEA0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void OnTransformParentChanged()
		{
			throw null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000028CF File Offset: 0x00000ACF
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x600034A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCEEF0", Offset = "0x1FCEEF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void ParentMaskStateChanged()
		{
			throw null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000028D2 File Offset: 0x00000AD2
		[global::Cpp2ILInjected.Token(Token = "0x600034B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCEEF4", Offset = "0x1FCEEF4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void OnCanvasHierarchyChanged()
		{
			throw null;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x000028D5 File Offset: 0x00000AD5
		[global::Cpp2ILInjected.Token(Token = "0x170000DB")]
		private Rect rootCanvasRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x600034C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCE978", Offset = "0x1FCE978", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "Cull", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000028D8 File Offset: 0x00000AD8
		[global::Cpp2ILInjected.Token(Token = "0x600034D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCECB0", Offset = "0x1FCECB0", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "RecalculateClipping", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "GetRectMaskForClippable", MemberParameters = new object[] { typeof(IClippable) }, ReturnType = typeof(RectMask2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "RemoveClippable", MemberParameters = new object[] { typeof(IClippable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "UpdateCull", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "AddClippable", MemberParameters = new object[] { typeof(IClippable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void UpdateClipParent()
		{
			throw null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000028DB File Offset: 0x00000ADB
		[global::Cpp2ILInjected.Token(Token = "0x600034E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCF33C", Offset = "0x1FCF33C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
		public virtual void RecalculateClipping()
		{
			throw null;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000028DE File Offset: 0x00000ADE
		[global::Cpp2ILInjected.Token(Token = "0x600034F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCF340", Offset = "0x1FCF340", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void RecalculateMasking()
		{
			throw null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000028E1 File Offset: 0x00000AE1
		[global::Cpp2ILInjected.Token(Token = "0x6000350")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCF3BC", Offset = "0x1FCF3BC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RawImage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic.CullStateChangedEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected MaskableGraphic()
		{
			throw null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000028E4 File Offset: 0x00000AE4
		[global::Cpp2ILInjected.Token(Token = "0x6000351")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCF4C0", Offset = "0x1FCF4C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		private GameObject UnityEngine.UI.IClippable.get_gameObject()
		{
			throw null;
		}

		// Token: 0x040000FC RID: 252
		[global::Cpp2ILInjected.Token(Token = "0x4000197")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x99")]
		[NonSerialized]
		protected bool m_ShouldRecalculateStencil;

		// Token: 0x040000FD RID: 253
		[global::Cpp2ILInjected.Token(Token = "0x4000198")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		protected Material m_MaskMaterial;

		// Token: 0x040000FE RID: 254
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		private RectMask2D m_ParentMask;

		// Token: 0x040000FF RID: 255
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private bool m_Maskable;

		// Token: 0x04000100 RID: 256
		[global::Cpp2ILInjected.Token(Token = "0x400019B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB1")]
		private bool m_IsMaskingGraphic;

		// Token: 0x04000101 RID: 257
		[Obsolete("Not used anymore.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB2")]
		[NonSerialized]
		protected bool m_IncludeForMasking;

		// Token: 0x04000102 RID: 258
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;

		// Token: 0x04000103 RID: 259
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		protected bool m_ShouldRecalculate;

		// Token: 0x04000104 RID: 260
		[global::Cpp2ILInjected.Token(Token = "0x400019F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		[NonSerialized]
		protected int m_StencilValue;

		// Token: 0x04000105 RID: 261
		[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private readonly Vector3[] m_Corners;

		// Token: 0x020000A9 RID: 169
		[global::Cpp2ILInjected.Token(Token = "0x2000055")]
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
			// Token: 0x060006BD RID: 1725 RVA: 0x000033C7 File Offset: 0x000015C7
			[global::Cpp2ILInjected.Token(Token = "0x6000352")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCF478", Offset = "0x1FCF478", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public CullStateChangedEvent()
			{
				throw null;
			}
		}
	}
}
