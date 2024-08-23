﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI
{
	// Token: 0x02000039 RID: 57
	[AddComponentMenu("UI/Legacy/Text", 100)]
	[RequireComponent(typeof(CanvasRenderer))]
	[global::Cpp2ILInjected.Token(Token = "0x2000072")]
	public class Text : MaskableGraphic, ILayoutElement
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x00002C9E File Offset: 0x00000E9E
		[global::Cpp2ILInjected.Token(Token = "0x600049B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDC608", Offset = "0x1FDC608", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FontData), Member = "get_defaultFontData", ReturnType = typeof(FontData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected Text()
		{
			throw null;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00002CA1 File Offset: 0x00000EA1
		[global::Cpp2ILInjected.Token(Token = "0x17000136")]
		public TextGenerator cachedTextGenerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDC6A0", Offset = "0x1FDC6A0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "FontTextureChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00002CA4 File Offset: 0x00000EA4
		[global::Cpp2ILInjected.Token(Token = "0x17000137")]
		public TextGenerator cachedTextGeneratorForLayout
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDC720", Offset = "0x1FDC720", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00002CA7 File Offset: 0x00000EA7
		[global::Cpp2ILInjected.Token(Token = "0x17000138")]
		public override Texture mainTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDC784", Offset = "0x1FDC784", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Font), Member = "get_material", ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002CAA File Offset: 0x00000EAA
		[global::Cpp2ILInjected.Token(Token = "0x600049F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDC910", Offset = "0x1FDC910", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FontUpdateTracker), Member = "RebuildForFont", MemberParameters = new object[] { typeof(Font) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "Invalidate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingGraphics", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void FontTextureChanged()
		{
			throw null;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00002CAD File Offset: 0x00000EAD
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00002CB0 File Offset: 0x00000EB0
		[global::Cpp2ILInjected.Token(Token = "0x17000139")]
		public Font font
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDC904", Offset = "0x1FDC904", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "IsValidChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCA14", Offset = "0x1FDCA14", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "AssignDefaultFont", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "AssignDefaultFontIfNecessary", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00002CB3 File Offset: 0x00000EB3
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00002CB6 File Offset: 0x00000EB6
		[global::Cpp2ILInjected.Token(Token = "0x1700013A")]
		public virtual string text
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCB20", Offset = "0x1FDCB20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCB28", Offset = "0x1FDCB28", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00002CB9 File Offset: 0x00000EB9
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00002CBC File Offset: 0x00000EBC
		[global::Cpp2ILInjected.Token(Token = "0x1700013B")]
		public bool supportRichText
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCBF0", Offset = "0x1FDCBF0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCBFC", Offset = "0x1FDCBFC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00002CBF File Offset: 0x00000EBF
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00002CC2 File Offset: 0x00000EC2
		[global::Cpp2ILInjected.Token(Token = "0x1700013C")]
		public bool resizeTextForBestFit
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCC54", Offset = "0x1FDCC54", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCC60", Offset = "0x1FDCC60", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00002CC5 File Offset: 0x00000EC5
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00002CC8 File Offset: 0x00000EC8
		[global::Cpp2ILInjected.Token(Token = "0x1700013D")]
		public int resizeTextMinSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCCB8", Offset = "0x1FDCCB8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCCC4", Offset = "0x1FDCCC4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00002CCB File Offset: 0x00000ECB
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00002CCE File Offset: 0x00000ECE
		[global::Cpp2ILInjected.Token(Token = "0x1700013E")]
		public int resizeTextMaxSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCD10", Offset = "0x1FDCD10", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCD1C", Offset = "0x1FDCD1C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00002CD1 File Offset: 0x00000ED1
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00002CD4 File Offset: 0x00000ED4
		[global::Cpp2ILInjected.Token(Token = "0x1700013F")]
		public TextAnchor alignment
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCD68", Offset = "0x1FDCD68", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCD74", Offset = "0x1FDCD74", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateButton", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00002CD7 File Offset: 0x00000ED7
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00002CDA File Offset: 0x00000EDA
		[global::Cpp2ILInjected.Token(Token = "0x17000140")]
		public bool alignByGeometry
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCDC0", Offset = "0x1FDCDC0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCDCC", Offset = "0x1FDCDCC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00002CDD File Offset: 0x00000EDD
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00002CE0 File Offset: 0x00000EE0
		[global::Cpp2ILInjected.Token(Token = "0x17000141")]
		public int fontSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCE00", Offset = "0x1FDCE00", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCE0C", Offset = "0x1FDCE0C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00002CE3 File Offset: 0x00000EE3
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00002CE6 File Offset: 0x00000EE6
		[global::Cpp2ILInjected.Token(Token = "0x17000142")]
		public HorizontalWrapMode horizontalOverflow
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCE58", Offset = "0x1FDCE58", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCE64", Offset = "0x1FDCE64", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00002CE9 File Offset: 0x00000EE9
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00002CEC File Offset: 0x00000EEC
		[global::Cpp2ILInjected.Token(Token = "0x17000143")]
		public VerticalWrapMode verticalOverflow
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCEB0", Offset = "0x1FDCEB0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCEBC", Offset = "0x1FDCEBC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00002CEF File Offset: 0x00000EEF
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002CF2 File Offset: 0x00000EF2
		[global::Cpp2ILInjected.Token(Token = "0x17000144")]
		public float lineSpacing
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCF08", Offset = "0x1FDCF08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCF14", Offset = "0x1FDCF14", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00002CF5 File Offset: 0x00000EF5
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00002CF8 File Offset: 0x00000EF8
		[global::Cpp2ILInjected.Token(Token = "0x17000145")]
		public FontStyle fontStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCF60", Offset = "0x1FDCF60", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCF6C", Offset = "0x1FDCF6C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00002CFB File Offset: 0x00000EFB
		[global::Cpp2ILInjected.Token(Token = "0x17000146")]
		public float pixelsPerUnit
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDCFB8", Offset = "0x1FDCFB8", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(TextGenerator)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TextGenerationSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Font), Member = "get_dynamic", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Font), Member = "get_fontSize", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002CFE File Offset: 0x00000EFE
		[global::Cpp2ILInjected.Token(Token = "0x60004BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDD0D8", Offset = "0x1FDD0D8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "Invalidate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002D01 File Offset: 0x00000F01
		[global::Cpp2ILInjected.Token(Token = "0x60004BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDD14C", Offset = "0x1FDD14C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002D04 File Offset: 0x00000F04
		[global::Cpp2ILInjected.Token(Token = "0x60004BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDD1B0", Offset = "0x1FDD1B0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "UpdateGeometry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void UpdateGeometry()
		{
			throw null;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002D07 File Offset: 0x00000F07
		[global::Cpp2ILInjected.Token(Token = "0x60004BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDD230", Offset = "0x1FDD230", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "GetBuiltinResource", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new object[] { typeof(Font) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void AssignDefaultFont()
		{
			throw null;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002D0A File Offset: 0x00000F0A
		[global::Cpp2ILInjected.Token(Token = "0x60004BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDD2A0", Offset = "0x1FDD2A0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "GetBuiltinResource", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new object[] { typeof(Font) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void AssignDefaultFontIfNecessary()
		{
			throw null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002D0D File Offset: 0x00000F0D
		[global::Cpp2ILInjected.Token(Token = "0x60004C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDD354", Offset = "0x1FDD354", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Font), Member = "get_dynamic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TextGenerationSettings GetGenerationSettings(Vector2 extents)
		{
			throw null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002D10 File Offset: 0x00000F10
		[global::Cpp2ILInjected.Token(Token = "0x60004C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDD51C", Offset = "0x1FDD51C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor)
		{
			throw null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002D13 File Offset: 0x00000F13
		[global::Cpp2ILInjected.Token(Token = "0x60004C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDD588", Offset = "0x1FDD588", Length = "0x54C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TextGenerationSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "PopulateWithErrors", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings),
			typeof(GameObject)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_verts", ReturnType = typeof(IList<UIVertex>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "PixelAdjustPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new object[] { typeof(UIVertex[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
			throw null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002D16 File Offset: 0x00000F16
		[global::Cpp2ILInjected.Token(Token = "0x60004C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDDBC8", Offset = "0x1FDDBC8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002D19 File Offset: 0x00000F19
		[global::Cpp2ILInjected.Token(Token = "0x60004C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDDBCC", Offset = "0x1FDDBCC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputVertical()
		{
			throw null;
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00002D1C File Offset: 0x00000F1C
		[global::Cpp2ILInjected.Token(Token = "0x17000147")]
		public virtual float minWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDBD0", Offset = "0x1FDDBD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00002D1F File Offset: 0x00000F1F
		[global::Cpp2ILInjected.Token(Token = "0x17000148")]
		public virtual float preferredWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDBD8", Offset = "0x1FDDBD8", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TextGenerationSettings))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new object[]
			{
				typeof(string),
				typeof(TextGenerationSettings)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00002D22 File Offset: 0x00000F22
		[global::Cpp2ILInjected.Token(Token = "0x17000149")]
		public virtual float flexibleWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDC94", Offset = "0x1FDDC94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00002D25 File Offset: 0x00000F25
		[global::Cpp2ILInjected.Token(Token = "0x1700014A")]
		public virtual float minHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDC9C", Offset = "0x1FDDC9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00002D28 File Offset: 0x00000F28
		[global::Cpp2ILInjected.Token(Token = "0x1700014B")]
		public virtual float preferredHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDCA4", Offset = "0x1FDDCA4", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TextGenerationSettings))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new object[]
			{
				typeof(string),
				typeof(TextGenerationSettings)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00002D2B File Offset: 0x00000F2B
		[global::Cpp2ILInjected.Token(Token = "0x1700014C")]
		public virtual float flexibleHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDD4C", Offset = "0x1FDDD4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00002D2E File Offset: 0x00000F2E
		[global::Cpp2ILInjected.Token(Token = "0x1700014D")]
		public virtual int layoutPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDD54", Offset = "0x1FDDD54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000170 RID: 368
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000243")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private FontData m_FontData;

		// Token: 0x04000171 RID: 369
		[SerializeField]
		[TextArea(3, 10)]
		[global::Cpp2ILInjected.Token(Token = "0x4000244")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		protected string m_Text;

		// Token: 0x04000172 RID: 370
		[global::Cpp2ILInjected.Token(Token = "0x4000245")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private TextGenerator m_TextCache;

		// Token: 0x04000173 RID: 371
		[global::Cpp2ILInjected.Token(Token = "0x4000246")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private TextGenerator m_TextCacheForLayout;

		// Token: 0x04000174 RID: 372
		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		protected static Material s_DefaultText;

		// Token: 0x04000175 RID: 373
		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		protected bool m_DisableFontTextureRebuiltCallback;

		// Token: 0x04000176 RID: 374
		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private readonly UIVertex[] m_TempVerts;
	}
}