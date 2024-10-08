﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004E9")]
	public class TileFont
	{
		[global::Cpp2ILInjected.Token(Token = "0x600307A")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FC80C", Offset = "0x12FC80C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileFont), Member = "HLineLabel", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(string),
			typeof(TileFont.DrawMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileFont), Member = "VLineLabel", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(string),
			typeof(TileFont.DrawMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileFont), Member = "DrawChar", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(byte[]),
			typeof(TileFont.DrawMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void DrawString(Point start, string text, TileFont.DrawMode mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600307B")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FC950", Offset = "0x12FC950", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileFont), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(string),
			typeof(TileFont.DrawMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void DrawChar(Point position, byte[] charData, TileFont.DrawMode mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600307C")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FCB38", Offset = "0x12FCB38", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileFont), Member = "HLineLabel", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(string),
			typeof(TileFont.DrawMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileFont), Member = "VLineLabel", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(string),
			typeof(TileFont.DrawMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static Point MeasureString(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600307D")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FCD00", Offset = "0x12FCD00", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileFont), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(string),
			typeof(TileFont.DrawMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void HLineLabel(Point start, int width, string text, TileFont.DrawMode mode, bool rightSideText = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600307E")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FCEA8", Offset = "0x12FCEA8", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileFont), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(string),
			typeof(TileFont.DrawMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void VLineLabel(Point start, int height, string text, TileFont.DrawMode mode, bool bottomText = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600307F")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FD050", Offset = "0x12FD050", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TileFont()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003080")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FD058", Offset = "0x12FD058", Length = "0x118C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(char),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 132)]
		static TileFont()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003A8F")]
		private static readonly Dictionary<char, byte[]> MicroFont;

		[global::Cpp2ILInjected.Token(Token = "0x20004EA")]
		public struct DrawMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003081")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FE1E4", Offset = "0x12FE1E4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public DrawMode(ushort foregroundTile)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003082")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FE1F4", Offset = "0x12FE1F4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public DrawMode(ushort foregroundTile, ushort backgroundTile)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4003A90")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly ushort ForegroundTile;

			[global::Cpp2ILInjected.Token(Token = "0x4003A91")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
			public readonly ushort BackgroundTile;

			[global::Cpp2ILInjected.Token(Token = "0x4003A92")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly bool HasBackground;
		}
	}
}
