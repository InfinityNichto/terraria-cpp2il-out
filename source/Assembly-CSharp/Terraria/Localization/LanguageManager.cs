﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Terraria.GameContent;
using Terraria.GameContent.UI;
using Terraria.Initializers;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.Localization
{
	// Token: 0x020003B6 RID: 950
	[global::Cpp2ILInjected.Token(Token = "0x2000557")]
	public class LanguageManager
	{
		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06002EB7 RID: 11959 RVA: 0x0002A578 File Offset: 0x00028778
		// (remove) Token: 0x06002EB8 RID: 11960 RVA: 0x0002A57B File Offset: 0x0002877B
		[global::Cpp2ILInjected.Token(Token = "0x14000039")]
		public event LanguageChangeCallback OnLanguageChanging
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003318")]
			[global::Cpp2ILInjected.Address(RVA = "0x1337B4C", Offset = "0x1337B4C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003319")]
			[global::Cpp2ILInjected.Address(RVA = "0x1337BE8", Offset = "0x1337BE8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06002EB9 RID: 11961 RVA: 0x0002A57E File Offset: 0x0002877E
		// (remove) Token: 0x06002EBA RID: 11962 RVA: 0x0002A581 File Offset: 0x00028781
		[global::Cpp2ILInjected.Token(Token = "0x1400003A")]
		public event LanguageChangeCallback OnLanguageChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600331A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1337C84", Offset = "0x1337C84", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClientInitialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600331B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1337D20", Offset = "0x1337D20", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x0002A584 File Offset: 0x00028784
		// (set) Token: 0x06002EBC RID: 11964 RVA: 0x0002A587 File Offset: 0x00028787
		[global::Cpp2ILInjected.Token(Token = "0x1700066A")]
		public GameCulture ActiveCulture
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600331C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1337DBC", Offset = "0x1337DBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600331D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1337DC4", Offset = "0x1337DC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x0002A58A File Offset: 0x0002878A
		[global::Cpp2ILInjected.Token(Token = "0x600331E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1337DCC", Offset = "0x1337DCC", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private LanguageManager()
		{
			throw null;
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x0002A58D File Offset: 0x0002878D
		[global::Cpp2ILInjected.Token(Token = "0x600331F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336D98", Offset = "0x1336D98", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int GetCategorySize(string name)
		{
			throw null;
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x0002A590 File Offset: 0x00028790
		[global::Cpp2ILInjected.Token(Token = "0x6003320")]
		[global::Cpp2ILInjected.Address(RVA = "0x1337F60", Offset = "0x1337F60", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OpenLegacySettings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadDedConfig", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadServerParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameCulture), Member = "FromLegacyId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GameCulture))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetLanguage(int legacyId)
		{
			throw null;
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x0002A593 File Offset: 0x00028793
		[global::Cpp2ILInjected.Token(Token = "0x6003321")]
		[global::Cpp2ILInjected.Address(RVA = "0x13380C4", Offset = "0x13380C4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadDedConfig", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadServerParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameCulture), Member = "FromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GameCulture))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(GameCulture) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetLanguage(string cultureName)
		{
			throw null;
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x0002A596 File Offset: 0x00028796
		[global::Cpp2ILInjected.Token(Token = "0x6003322")]
		[global::Cpp2ILInjected.Address(RVA = "0x1338130", Offset = "0x1338130", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.KeyCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.KeyCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.KeyCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public int EstimateWordCount()
		{
			throw null;
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x0002A599 File Offset: 0x00028799
		[global::Cpp2ILInjected.Token(Token = "0x6003323")]
		[global::Cpp2ILInjected.Address(RVA = "0x13383E0", Offset = "0x13383E0", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(GameCulture) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void SetAllTextValuesToKeys()
		{
			throw null;
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x0002A59C File Offset: 0x0002879C
		[global::Cpp2ILInjected.Token(Token = "0x6003324")]
		[global::Cpp2ILInjected.Address(RVA = "0x1338524", Offset = "0x1338524", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "FindAll", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]", "System.Predicate`1<T>" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private string[] GetLanguageFilesForCulture(GameCulture culture)
		{
			throw null;
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x0002A59F File Offset: 0x0002879F
		[global::Cpp2ILInjected.Token(Token = "0x6003325")]
		[global::Cpp2ILInjected.Address(RVA = "0x133868C", Offset = "0x133868C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<LoadContent_Deferred>d__1863", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(GameCulture) }, ReturnType = typeof(void))]
		public void DelayedInit()
		{
			throw null;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x0002A5A2 File Offset: 0x000287A2
		[global::Cpp2ILInjected.Token(Token = "0x6003326")]
		[global::Cpp2ILInjected.Address(RVA = "0x1337FCC", Offset = "0x1337FCC", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "LaunchGame", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "DelayedInit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "SetAllTextValuesToKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "LoadLanguage", MemberParameters = new object[]
		{
			typeof(GameCulture),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_CurrentCulture", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_CurrentUICulture", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetLanguage(GameCulture culture)
		{
			throw null;
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x0002A5A5 File Offset: 0x000287A5
		[global::Cpp2ILInjected.Token(Token = "0x6003327")]
		[global::Cpp2ILInjected.Address(RVA = "0x133869C", Offset = "0x133869C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(GameCulture) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "LoadFilesForCulture", MemberParameters = new object[] { typeof(GameCulture) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "ProcessCopyCommandsInTexts", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatInitializer), Member = "PrepareAliases", ReturnType = typeof(void))]
		private void LoadLanguage(GameCulture culture, bool processCopyCommands = true)
		{
			throw null;
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x0002A5A8 File Offset: 0x000287A8
		[global::Cpp2ILInjected.Token(Token = "0x6003328")]
		[global::Cpp2ILInjected.Address(RVA = "0x13386E8", Offset = "0x13386E8", Length = "0x448")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "LoadLanguage", MemberParameters = new object[]
		{
			typeof(GameCulture),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "LoadAll", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "LoadLanguageFromFileText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debugger), Member = "get_IsAttached", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		private void LoadFilesForCulture(GameCulture culture)
		{
			throw null;
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x0002A5AB File Offset: 0x000287AB
		[global::Cpp2ILInjected.Token(Token = "0x6003329")]
		[global::Cpp2ILInjected.Address(RVA = "0x1338B30", Offset = "0x1338B30", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "LoadLanguage", MemberParameters = new object[]
		{
			typeof(GameCulture),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchEvaluator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(MatchEvaluator)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void ProcessCopyCommandsInTexts()
		{
			throw null;
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x0002A5AE File Offset: 0x000287AE
		[global::Cpp2ILInjected.Token(Token = "0x600332A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1338D4C", Offset = "0x1338D4C", Length = "0x844")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "LoadFilesForCulture", MemberParameters = new object[] { typeof(GameCulture) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert[]), Member = "DeserializeObject", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 67)]
		public void LoadLanguageFromFileText(string fileText)
		{
			throw null;
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x0002A5B1 File Offset: 0x000287B1
		[Conditional("ENABLE_DEBUG")]
		[Conditional("UNITY_EDITOR")]
		[global::Cpp2ILInjected.Token(Token = "0x600332B")]
		[global::Cpp2ILInjected.Address(RVA = "0x13395BC", Offset = "0x13395BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ValidateAllCharactersContainedInFont(SpriteFont font)
		{
			throw null;
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x0002A5B4 File Offset: 0x000287B4
		[global::Cpp2ILInjected.Token(Token = "0x600332C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336E94", Offset = "0x1336E94", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public LocalizedText[] FindAll(Regex regex)
		{
			throw null;
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x0002A5B7 File Offset: 0x000287B7
		[global::Cpp2ILInjected.Token(Token = "0x600332D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1337194", Offset = "0x1337194", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddLast", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public LocalizedText[] FindAll(LanguageSearchFilter filter)
		{
			throw null;
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x0002A5BA File Offset: 0x000287BA
		[global::Cpp2ILInjected.Token(Token = "0x600332E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13373E8", Offset = "0x13373E8", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public LocalizedText[] FindAll(string categoryName)
		{
			throw null;
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x0002A5BD File Offset: 0x000287BD
		[global::Cpp2ILInjected.Token(Token = "0x600332F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1337634", Offset = "0x1337634", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public LocalizedText SelectRandom(LanguageSearchFilter filter, UnifiedRandom random = null)
		{
			throw null;
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x0002A5C0 File Offset: 0x000287C0
		[global::Cpp2ILInjected.Token(Token = "0x6003330")]
		[global::Cpp2ILInjected.Address(RVA = "0x133798C", Offset = "0x133798C", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public LocalizedText RandomFromCategory(string categoryName, UnifiedRandom random = null)
		{
			throw null;
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x0002A5C3 File Offset: 0x000287C3
		[global::Cpp2ILInjected.Token(Token = "0x6003331")]
		[global::Cpp2ILInjected.Address(RVA = "0x13395C0", Offset = "0x13395C0", Length = "0x5F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameTipsDisplay), Member = "AddNewTip", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.KeyCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.KeyCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.KeyCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CanSubstituteBindings", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public LocalizedText RandomFromCategories(string[] categoryNames, ref int keyIndexToSkip, UnifiedRandom random = null)
		{
			throw null;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x0002A5C6 File Offset: 0x000287C6
		[global::Cpp2ILInjected.Token(Token = "0x6003332")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339BB0", Offset = "0x1339BB0", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "GetTextForVariation", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public LocalizedText IndexedFromCategory(string categoryName, int index)
		{
			throw null;
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x0002A5C9 File Offset: 0x000287C9
		[global::Cpp2ILInjected.Token(Token = "0x6003333")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336CE0", Offset = "0x1336CE0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Exists(string key)
		{
			throw null;
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x0002A5CC File Offset: 0x000287CC
		[global::Cpp2ILInjected.Token(Token = "0x6003334")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336110", Offset = "0x1336110", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(StringBuilder)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "FindAll", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "RandomFromCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "RandomFromCategories", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref int),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "IndexedFromCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public LocalizedText GetText(string key)
		{
			throw null;
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x0002A5CF File Offset: 0x000287CF
		[global::Cpp2ILInjected.Token(Token = "0x6003335")]
		[global::Cpp2ILInjected.Address(RVA = "0x13361F0", Offset = "0x13361F0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "EstimateWordCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "<ProcessCopyCommandsInTexts>b__27_0", MemberParameters = new object[] { typeof(Match) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string GetTextValue(string key)
		{
			throw null;
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x0002A5D2 File Offset: 0x000287D2
		[global::Cpp2ILInjected.Token(Token = "0x6003336")]
		[global::Cpp2ILInjected.Address(RVA = "0x13362EC", Offset = "0x13362EC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string GetTextValue(string key, object arg0)
		{
			throw null;
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x0002A5D5 File Offset: 0x000287D5
		[global::Cpp2ILInjected.Token(Token = "0x6003337")]
		[global::Cpp2ILInjected.Address(RVA = "0x133640C", Offset = "0x133640C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string GetTextValue(string key, object arg0, object arg1)
		{
			throw null;
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x0002A5D8 File Offset: 0x000287D8
		[global::Cpp2ILInjected.Token(Token = "0x6003338")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336550", Offset = "0x1336550", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string GetTextValue(string key, object arg0, object arg1, object arg2)
		{
			throw null;
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x0002A5DB File Offset: 0x000287DB
		[global::Cpp2ILInjected.Token(Token = "0x6003339")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336684", Offset = "0x1336684", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string GetTextValue(string key, params object[] args)
		{
			throw null;
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x0002A5DE File Offset: 0x000287DE
		[global::Cpp2ILInjected.Token(Token = "0x600333A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339D4C", Offset = "0x1339D4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetFallbackCulture(GameCulture culture)
		{
			throw null;
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x0002A5E1 File Offset: 0x000287E1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600333B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339D54", Offset = "0x1339D54", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static LanguageManager()
		{
			throw null;
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x0002A5E4 File Offset: 0x000287E4
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600333C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339DAC", Offset = "0x1339DAC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		private string <ProcessCopyCommandsInTexts>b__27_0(Match match)
		{
			throw null;
		}

		// Token: 0x0400326C RID: 12908
		[global::Cpp2ILInjected.Token(Token = "0x4003C1A")]
		public static LanguageManager Instance;

		// Token: 0x0400326D RID: 12909
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private LanguageChangeCallback OnLanguageChanging;

		// Token: 0x0400326E RID: 12910
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private LanguageChangeCallback OnLanguageChanged;

		// Token: 0x0400326F RID: 12911
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private GameCulture <ActiveCulture>k__BackingField;

		// Token: 0x04003270 RID: 12912
		[global::Cpp2ILInjected.Token(Token = "0x4003C1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, LocalizedText> _localizedTexts;

		// Token: 0x04003271 RID: 12913
		[global::Cpp2ILInjected.Token(Token = "0x4003C1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, List<string>> _categoryGroupedKeys;

		// Token: 0x04003272 RID: 12914
		[global::Cpp2ILInjected.Token(Token = "0x4003C20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private GameCulture _fallbackCulture;

		// Token: 0x04003273 RID: 12915
		[global::Cpp2ILInjected.Token(Token = "0x4003C21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool intialLoadDone;

		// Token: 0x04003274 RID: 12916
		[global::Cpp2ILInjected.Token(Token = "0x4003C22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public GameCulture delayedActiveCulture;

		// Token: 0x020008F1 RID: 2289
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000558")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06004C0C RID: 19468 RVA: 0x0002F759 File Offset: 0x0002D959
			[global::Cpp2ILInjected.Token(Token = "0x600333D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1338684", Offset = "0x1338684", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass21_0()
			{
				throw null;
			}

			// Token: 0x06004C0D RID: 19469 RVA: 0x0002F75C File Offset: 0x0002D95C
			[global::Cpp2ILInjected.Token(Token = "0x600333E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1339DF0", Offset = "0x1339DF0", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <GetLanguageFilesForCulture>b__0(string element)
			{
				throw null;
			}

			// Token: 0x04008151 RID: 33105
			[global::Cpp2ILInjected.Token(Token = "0x4003C23")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public GameCulture culture;
		}
	}
}