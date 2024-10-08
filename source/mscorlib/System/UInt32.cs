﻿using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000115")]
	[global::System.Serializable]
	public readonly struct UInt32 : global::System.IComparable, global::System.IConvertible, global::System.IFormattable, global::System.IComparable<uint>, global::System.IEquatable<uint>, global::System.ISpanFormattable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51534", Offset = "0x1C51534", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_unsignedInt", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int CompareTo(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51600", Offset = "0x1C51600", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int CompareTo(uint value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5161C", Offset = "0x1C5161C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalUInt32", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51694", Offset = "0x1C51694", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2", Member = "Equals", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2", Member = "op_Equality", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2", "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2", Member = "op_Inequality", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2", "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2", Member = "op_Inequality", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2", "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2", Member = "op_Equality", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2", "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2", Member = "Equals", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public bool Equals(uint obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ACA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C516A4", Offset = "0x1C516A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Byte4", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedByte4", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Rg32", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Rgba1010102", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Short2", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.SlotId", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Numerics.Vector<>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalUInt32", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Playables.PlayableOutputHandle", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Playables.PlayableHandle", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C516AC", Offset = "0x1C516AC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.NativeInputDeviceManager", Member = "CheckPlatformSupport", MemberParameters = new object[] { "System.Collections.Generic.ICollection`1<String>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SocialPlatforms.Impl.Leaderboard", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ACC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51744", Offset = "0x1C51744", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalUInt32", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ACD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C517E0", Offset = "0x1C517E0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Byte4", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedByte4", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Short2", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(string format)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ACE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51894", Offset = "0x1C51894", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFormattedHexString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.UInt32Converter", Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlEncodedRawTextWriter", Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlUtf8RawTextWriter", Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "CreateInvalidSurrogatePairException", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			"System.Xml.ExceptionType",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new object[]
		{
			typeof(char),
			"System.Xml.ExceptionType",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ACF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5194C", Offset = "0x1C5194C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format = default(global::System.ReadOnlySpan<char>), global::System.IFormatProvider provider = null)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C519F0", Offset = "0x1C519F0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "GetResponse", MemberParameters = new object[]
		{
			"System.Net.BufferOffsetSize",
			typeof(ref int),
			"System.Net.ReadState&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static uint Parse(string s)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51AA4", Offset = "0x1C51AA4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.PrimitiveArray), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static uint Parse(string s, global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51B68", Offset = "0x1C51B68", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.UInt32Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static uint Parse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51C3C", Offset = "0x1C51C3C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "HtmlDecode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToUInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref uint)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryParse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, out uint result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51D34", Offset = "0x1C51D34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51D3C", Offset = "0x1C51D3C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51D98", Offset = "0x1C51D98", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51DF4", Offset = "0x1C51DF4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51E50", Offset = "0x1C51E50", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51EAC", Offset = "0x1C51EAC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51F08", Offset = "0x1C51F08", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ADB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51F64", Offset = "0x1C51F64", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ADC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51FC0", Offset = "0x1C51FC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ADD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51FC8", Offset = "0x1C51FC8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ADE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52024", Offset = "0x1C52024", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ADF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52080", Offset = "0x1C52080", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C520DC", Offset = "0x1C520DC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52138", Offset = "0x1C52138", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52194", Offset = "0x1C52194", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private global::System.DateTime System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52218", Offset = "0x1C52218", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly uint m_value;

		[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
		public const uint MaxValue = 4294967295U;

		[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
		public const uint MinValue = 0U;
	}
}
