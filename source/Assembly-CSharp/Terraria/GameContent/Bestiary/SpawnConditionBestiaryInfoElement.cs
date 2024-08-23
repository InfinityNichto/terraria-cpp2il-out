﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000639 RID: 1593
	[global::Cpp2ILInjected.Token(Token = "0x200095C")]
	public class SpawnConditionBestiaryInfoElement : FilterProviderInfoElement, IBestiaryBackgroundImagePathAndColorProvider, IBestiaryPrioritizedElement
	{
		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x0002D38F File Offset: 0x0002B58F
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x0002D392 File Offset: 0x0002B592
		[global::Cpp2ILInjected.Token(Token = "0x17000828")]
		public float OrderPriority
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x81D730", Offset = "0x81D730", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x81D738", Offset = "0x81D738", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x0002D395 File Offset: 0x0002B595
		[global::Cpp2ILInjected.Token(Token = "0x60047F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x811E4C", Offset = "0x811E4C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SpawnConditionBestiaryInfoElement(string nameLanguageKey, int filterIconFrame, string backgroundImagePath = null, Color? backgroundColor = null)
		{
			throw null;
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x0002D398 File Offset: 0x0002B598
		[global::Cpp2ILInjected.Token(Token = "0x60047F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D740", Offset = "0x81D740", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Asset<Texture2D> GetBackgroundImage()
		{
			throw null;
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x0002D39B File Offset: 0x0002B59B
		[global::Cpp2ILInjected.Token(Token = "0x60047F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D84C", Offset = "0x81D84C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Color? GetBackgroundColor()
		{
			throw null;
		}

		// Token: 0x04006C77 RID: 27767
		[global::Cpp2ILInjected.Token(Token = "0x4008396")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _backgroundImagePath;

		// Token: 0x04006C78 RID: 27768
		[global::Cpp2ILInjected.Token(Token = "0x4008397")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Color? _backgroundColor;

		// Token: 0x04006C79 RID: 27769
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008398")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private float <OrderPriority>k__BackingField;
	}
}
