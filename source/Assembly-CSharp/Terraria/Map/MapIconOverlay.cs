﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Map
{
	// Token: 0x020004A7 RID: 1191
	[global::Cpp2ILInjected.Token(Token = "0x20006B9")]
	public class MapIconOverlay
	{
		// Token: 0x060033B8 RID: 13240 RVA: 0x0002B3AF File Offset: 0x000295AF
		[global::Cpp2ILInjected.Token(Token = "0x600390F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14476FC", Offset = "0x14476FC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MapIconOverlay AddLayer(IMapLayer layer)
		{
			throw null;
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x0002B3B2 File Offset: 0x000295B2
		[global::Cpp2ILInjected.Token(Token = "0x6003910")]
		[global::Cpp2ILInjected.Address(RVA = "0x14477A0", Offset = "0x14477A0", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void Draw(Vector2 mapPosition, Vector2 mapOffset, Rectangle? clippingRect, float mapScale, float drawScale, ref string text)
		{
			throw null;
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x0002B3B5 File Offset: 0x000295B5
		[global::Cpp2ILInjected.Token(Token = "0x6003911")]
		[global::Cpp2ILInjected.Address(RVA = "0x14479B0", Offset = "0x14479B0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public MapIconOverlay()
		{
			throw null;
		}

		// Token: 0x0400659A RID: 26010
		[global::Cpp2ILInjected.Token(Token = "0x40079A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<IMapLayer> _layers;
	}
}
