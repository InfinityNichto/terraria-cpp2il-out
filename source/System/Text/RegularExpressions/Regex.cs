﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	[global::Cpp2ILInjected.Token(Token = "0x20000AF")]
	public class Regex : ISerializable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000353")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB588", Offset = "0x1EAB588", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex.CachedCodeEntryKey), Member = "Equals", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(bool)
		}, ReturnType = typeof(Regex.CachedCodeEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		private Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000354")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB6B0", Offset = "0x1EAB6B0", Length = "0x454")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "GetCachedCode", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(bool)
		}, ReturnType = typeof(Regex.CachedCodeEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "LookupCachedAndPromote", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(Regex.CachedCodeEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "FillCacheDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Regex.CachedCodeEntryKey, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Regex.CachedCodeEntryKey, object>), Member = "Remove", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000355")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EABDD8", Offset = "0x1EABDD8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(bool)
		}, ReturnType = typeof(Regex.CachedCodeEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Regex.CachedCodeEntryKey, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Regex.CachedCodeEntryKey, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void FillCacheDictionary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000356")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EABEC0", Offset = "0x1EABEC0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Regex.CachedCodeEntryKey, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "TryGetCacheValueSmall", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(ref Regex.CachedCodeEntry)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(256)]
		private static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000357")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EABFCC", Offset = "0x1EABFCC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "TryGetCacheValue", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(ref Regex.CachedCodeEntry)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "LookupCachedAndPromote", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(Regex.CachedCodeEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex.CachedCodeEntryKey), Member = "Equals", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000358")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EABB04", Offset = "0x1EABB04", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(bool)
		}, ReturnType = typeof(Regex.CachedCodeEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex.CachedCodeEntryKey), Member = "Equals", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Regex.CachedCodeEntryKey, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "TryGetCacheValueSmall", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(ref Regex.CachedCodeEntry)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000359")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC09C", Offset = "0x1EAC09C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputDeviceMatcher", Member = "Matches", MemberParameters = new object[] { "InControl.InputDeviceInfo" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsMatch(string input, string pattern, RegexOptions options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600035A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC114", Offset = "0x1EAC114", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600035B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC4F4", Offset = "0x1EAC4F4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "FindAll", MemberParameters = new object[] { typeof(Regex) }, ReturnType = "Terraria.Localization.LocalizedText[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "CheckPatternFacets", MemberParameters = new object[]
		{
			"System.Xml.Schema.RestrictionFacets",
			typeof(string)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.StringFacetsChecker", Member = "CheckBuiltInFacets", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlTypeCode),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool IsMatch(string input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600035C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC56C", Offset = "0x1EAC56C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool IsMatch(string input, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600035D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC5E8", Offset = "0x1EAC5E8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.VersionInfo", Member = "UnityVersion", ReturnType = "InControl.VersionInfo")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Match Match(string input, string pattern)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600035E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC65C", Offset = "0x1EAC65C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600035F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC6E0", Offset = "0x1EAC6E0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FileUtilities", Member = "GetFileName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FileUtilities", Member = "GetParentFolderPath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.iOS.CloudSocialModule", Member = "GetParentFolderPath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "isMatchedURI", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "intersectPair", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "BypassStringEscape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertGuid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.CopyHelper", Member = "AppendCopyToFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Match Match(string input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000360")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC74C", Offset = "0x1EAC74C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(MatchEvaluator),
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Split", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Match Match(string input, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC7BC", Offset = "0x1EAC7BC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText", Member = "CanFormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.Chat.ChatManager", Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			"Microsoft.Xna.Framework.Graphics.Color",
			typeof(float)
		}, ReturnType = "Terraria.UI.Chat.TextSnippet[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public MatchCollection Matches(string input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000362")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC828", Offset = "0x1EAC828", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public MatchCollection Matches(string input, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000363")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC8F0", Offset = "0x1EAC8F0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SanitizePathArgument", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.ZipContentSource", Member = "CleanZipPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Save", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string Replace(string input, string pattern, string replacement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000364")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC96C", Offset = "0x1EAC96C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000365")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC9F8", Offset = "0x1EAC9F8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "SimplifyFwdSlashPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public string Replace(string input, string replacement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000366")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EACA68", Offset = "0x1EACA68", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new object[]
		{
			typeof(WeakReference<RegexReplacement>),
			typeof(string),
			typeof(Hashtable),
			typeof(int),
			typeof(Hashtable),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexReplacement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public string Replace(string input, string replacement, int count, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000367")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EACB38", Offset = "0x1EACB38", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "ProcessCopyCommandsInTexts", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText", Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public string Replace(string input, MatchEvaluator evaluator)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000368")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EACBA8", Offset = "0x1EACBA8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public string Replace(string input, MatchEvaluator evaluator, int count, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000369")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EACC78", Offset = "0x1EACC78", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Match), Member = "NextMatch", ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600036A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAD074", Offset = "0x1EAD074", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.VanillaContentValidator", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.CreativeItemSacrificesCatalog", Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Internal.CodeWriter", Member = "Append", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string[] Split(string input, string pattern)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600036B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAD0E8", Offset = "0x1EAD0E8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string[] Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600036C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAD16C", Offset = "0x1EAD16C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public string[] Split(string input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600036D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAD1DC", Offset = "0x1EAD1DC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public string[] Split(string input, int count, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600036E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAD29C", Offset = "0x1EAD29C", Length = "0x5E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Match), Member = "NextMatch", ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Reverse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static string[] Split(Regex regex, string input, int count, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600036F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAD87C", Offset = "0x1EAD87C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Regex.CachedCodeEntryKey, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "InitDefaultMatchTimeout", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static Regex()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000370")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EADBD4", Offset = "0x1EADBD4", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "InitDefaultMatchTimeout", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(TimeSpan)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000371")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAD9AC", Offset = "0x1EAD9AC", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "GetData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "ValidateMatchTimeout", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private static TimeSpan InitDefaultMatchTimeout()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000372")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EADD2C", Offset = "0x1EADD2C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "get_MatchAllRegex", ReturnType = typeof(Regex))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnixIPInterfaceProperties), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertGuid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.CopyHelper", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Regex(string pattern)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000373")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EADDA4", Offset = "0x1EADDA4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FileUtilities", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.iOS.CloudSocialModule", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "ProcessCopyCommandsInTexts", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.Chat.ChatManager.Regexes", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelayedRegex), Member = "get_AsRegex", ReturnType = typeof(Regex))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "BypassStringEscape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "UpdateRegExList", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.StringFacetsChecker", Member = "get_LanguagePattern", ReturnType = typeof(Regex))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.RegexConverter", Member = "ReadRegexString", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader" }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.RegexConverter", Member = "ReadRegexObject", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader", "Newtonsoft.Json.JsonSerializer" }, ReturnType = typeof(Regex))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Regex(string pattern, RegexOptions options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000374")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EADE20", Offset = "0x1EADE20", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000375")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC198", Offset = "0x1EAC198", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Split", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "ValidateMatchTimeout", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex.CachedCodeEntryKey), Member = "Equals", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new object[]
		{
			typeof(Regex.CachedCodeEntryKey),
			typeof(bool)
		}, ReturnType = typeof(Regex.CachedCodeEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexTree))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "Write", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "InitializeReferences", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000376")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EADF60", Offset = "0x1EADF60", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FileUtilities", Member = "WildcardToRegex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "isSpecialSubsetCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string Escape(string str)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
		public RegexOptions Options
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000377")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAE004", Offset = "0x1EAE004", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000BB")]
		public bool RightToLeft
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000378")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAD068", Offset = "0x1EAD068", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new object[]
			{
				typeof(Regex),
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new object[]
			{
				typeof(Regex),
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(TimeSpan)
			}, ReturnType = typeof(Match))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000379")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAE00C", Offset = "0x1EAE00C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600037A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9038", Offset = "0x1EA9038", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "GetGroupImpl", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashtableExtensions), Member = "TryGetValue", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(Hashtable),
			typeof(object),
			"T&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string GroupNameFromNumber(int i)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600037B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8C94", Offset = "0x1EA8C94", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashtableExtensions), Member = "TryGetValue", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(Hashtable),
			typeof(object),
			"T&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public int GroupNumberFromName(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600037C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EADE64", Offset = "0x1EADE64", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected void InitializeReferences()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600037D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9E28", Offset = "0x1EA9E28", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExclusiveReference), Member = "Get", ReturnType = typeof(RegexRunner))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexInterpreter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(RegexCode),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(TimeSpan)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExclusiveReference), Member = "Release", MemberParameters = new object[] { typeof(RegexRunner) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600037E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAC560", Offset = "0x1EAC560", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected internal bool UseOptionR()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600037F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAE014", Offset = "0x1EAE014", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool UseOptionInvariant()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
		private const int CacheDictionarySwitchLimit = 10;

		[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
		private static int s_cacheSize;

		[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
		private static readonly Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache;

		[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
		private static int s_cacheCount;

		[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
		private static Regex.CachedCodeEntry s_cacheFirst;

		[global::Cpp2ILInjected.Token(Token = "0x40002AD")]
		private static Regex.CachedCodeEntry s_cacheLast;

		[global::Cpp2ILInjected.Token(Token = "0x40002AE")]
		private static readonly TimeSpan s_maximumMatchTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
		private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";

		[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
		internal static readonly TimeSpan s_defaultMatchTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
		public static readonly TimeSpan InfiniteMatchTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected internal TimeSpan internalMatchTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
		internal const int MaxOptionShift = 10;

		[global::Cpp2ILInjected.Token(Token = "0x40002B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected internal string pattern;

		[global::Cpp2ILInjected.Token(Token = "0x40002B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected internal RegexOptions roptions;

		[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected internal RegexRunnerFactory factory;

		[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected internal Hashtable caps;

		[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected internal Hashtable capnames;

		[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected internal string[] capslist;

		[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected internal int capsize;

		[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal ExclusiveReference _runnerref;

		[global::Cpp2ILInjected.Token(Token = "0x40002BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal WeakReference<RegexReplacement> _replref;

		[global::Cpp2ILInjected.Token(Token = "0x40002BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal RegexCode _code;

		[global::Cpp2ILInjected.Token(Token = "0x40002BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal bool _refsInitialized;

		[global::Cpp2ILInjected.Token(Token = "0x20000B0")]
		internal readonly struct CachedCodeEntryKey : IEquatable<Regex.CachedCodeEntryKey>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000380")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EADE58", Offset = "0x1EADE58", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000381")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAE020", Offset = "0x1EAE020", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex.CachedCodeEntryKey), Member = "Equals", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000382")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAE0B0", Offset = "0x1EAE0B0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex.CachedCodeEntryKey), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex.CachedCodeEntryKey), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Regex.CachedCodeEntryKey),
				typeof(Regex.CachedCodeEntryKey)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "GetCachedCode", MemberParameters = new object[]
			{
				typeof(Regex.CachedCodeEntryKey),
				typeof(bool)
			}, ReturnType = typeof(Regex.CachedCodeEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "TryGetCacheValueSmall", MemberParameters = new object[]
			{
				typeof(Regex.CachedCodeEntryKey),
				typeof(ref Regex.CachedCodeEntry)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "LookupCachedAndPromote", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(Regex.CachedCodeEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(RegexOptions),
				typeof(TimeSpan),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			public bool Equals(Regex.CachedCodeEntryKey other)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000383")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAB680", Offset = "0x1EAB680", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex.CachedCodeEntryKey), Member = "Equals", MemberParameters = new object[] { typeof(Regex.CachedCodeEntryKey) }, ReturnType = typeof(bool))]
			public static bool operator ==(Regex.CachedCodeEntryKey left, Regex.CachedCodeEntryKey right)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000384")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAE10C", Offset = "0x1EAE10C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40002BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly RegexOptions _options;

			[global::Cpp2ILInjected.Token(Token = "0x40002C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly string _cultureKey;

			[global::Cpp2ILInjected.Token(Token = "0x40002C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly string _pattern;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20000B1")]
		internal sealed class CachedCodeEntry
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000385")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EABD60", Offset = "0x1EABD60", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CachedCodeEntry(Regex.CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40002C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Regex.CachedCodeEntry Next;

			[global::Cpp2ILInjected.Token(Token = "0x40002C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Regex.CachedCodeEntry Previous;

			[global::Cpp2ILInjected.Token(Token = "0x40002C4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public readonly Regex.CachedCodeEntryKey Key;

			[global::Cpp2ILInjected.Token(Token = "0x40002C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public RegexCode Code;

			[global::Cpp2ILInjected.Token(Token = "0x40002C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public readonly Hashtable Caps;

			[global::Cpp2ILInjected.Token(Token = "0x40002C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public readonly Hashtable Capnames;

			[global::Cpp2ILInjected.Token(Token = "0x40002C8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public readonly string[] Capslist;

			[global::Cpp2ILInjected.Token(Token = "0x40002C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public readonly int Capsize;

			[global::Cpp2ILInjected.Token(Token = "0x40002CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public readonly ExclusiveReference Runnerref;

			[global::Cpp2ILInjected.Token(Token = "0x40002CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public readonly WeakReference<RegexReplacement> ReplRef;
		}
	}
}
