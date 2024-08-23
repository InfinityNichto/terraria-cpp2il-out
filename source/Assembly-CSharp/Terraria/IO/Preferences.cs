﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Terraria.DataStructures;
using Terraria.GameContent.UI.BigProgressBar;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.GameInput;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.Social.Base;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x020003BF RID: 959
	[global::Cpp2ILInjected.Token(Token = "0x2000564")]
	public class Preferences
	{
		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06002F28 RID: 12072 RVA: 0x0002A6C2 File Offset: 0x000288C2
		// (remove) Token: 0x06002F29 RID: 12073 RVA: 0x0002A6C5 File Offset: 0x000288C5
		[global::Cpp2ILInjected.Token(Token = "0x1400003B")]
		public event Action<Preferences> OnSave
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600338F")]
			[global::Cpp2ILInjected.Address(RVA = "0x133E308", Offset = "0x133E308", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CloudSocialModule), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SelectionHolder<>), Member = "BindTo", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "BindTo", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003390")]
			[global::Cpp2ILInjected.Address(RVA = "0x133E3B8", Offset = "0x133E3B8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06002F2A RID: 12074 RVA: 0x0002A6C8 File Offset: 0x000288C8
		// (remove) Token: 0x06002F2B RID: 12075 RVA: 0x0002A6CB File Offset: 0x000288CB
		[global::Cpp2ILInjected.Token(Token = "0x1400003C")]
		public event Action<Preferences> OnLoad
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003391")]
			[global::Cpp2ILInjected.Address(RVA = "0x133E468", Offset = "0x133E468", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CloudSocialModule), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SelectionHolder<>), Member = "BindTo", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "BindTo", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003392")]
			[global::Cpp2ILInjected.Address(RVA = "0x133E518", Offset = "0x133E518", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06002F2C RID: 12076 RVA: 0x0002A6CE File Offset: 0x000288CE
		// (remove) Token: 0x06002F2D RID: 12077 RVA: 0x0002A6D1 File Offset: 0x000288D1
		[global::Cpp2ILInjected.Token(Token = "0x1400003D")]
		public event Preferences.TextProcessAction OnProcessText
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003393")]
			[global::Cpp2ILInjected.Address(RVA = "0x133E5C8", Offset = "0x133E5C8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "Initialize", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003394")]
			[global::Cpp2ILInjected.Address(RVA = "0x133E664", Offset = "0x133E664", Length = "0x9C")]
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

		// Token: 0x06002F2E RID: 12078 RVA: 0x0002A6D4 File Offset: 0x000288D4
		[global::Cpp2ILInjected.Token(Token = "0x6003395")]
		[global::Cpp2ILInjected.Address(RVA = "0x133E700", Offset = "0x133E700", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_Configuration", ReturnType = typeof(Preferences))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_InputProfiles", ReturnType = typeof(Preferences))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_TypeNameHandling", MemberParameters = new object[] { typeof(TypeNameHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_MetadataPropertyHandling", MemberParameters = new object[] { typeof(MetadataPropertyHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_Formatting", MemberParameters = new object[] { typeof(Formatting) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public Preferences(string path, bool parseAllTypes = false, bool useBson = false)
		{
			throw null;
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x0002A6D7 File Offset: 0x000288D7
		[global::Cpp2ILInjected.Token(Token = "0x6003396")]
		[global::Cpp2ILInjected.Address(RVA = "0x133E830", Offset = "0x133E830", Length = "0x5F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Create", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer[]), Member = "Deserialize", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert[]), Member = "DeserializeObject", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(JsonSerializerSettings)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		public bool Load()
		{
			throw null;
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x0002A6DA File Offset: 0x000288DA
		[global::Cpp2ILInjected.Token(Token = "0x6003397")]
		[global::Cpp2ILInjected.Address(RVA = "0x133EE24", Offset = "0x133EE24", Length = "0x658")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIProfileSwitch), Member = "CycleNextProfile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryPickingDefaultUIScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetParent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DirectoryInfo), Member = "Create", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Create", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Formatting),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public bool Save(bool canCreateFile = true)
		{
			throw null;
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x0002A6DD File Offset: 0x000288DD
		[global::Cpp2ILInjected.Token(Token = "0x6003398")]
		[global::Cpp2ILInjected.Address(RVA = "0x133F47C", Offset = "0x133F47C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x0002A6E0 File Offset: 0x000288E0
		[global::Cpp2ILInjected.Token(Token = "0x6003399")]
		[global::Cpp2ILInjected.Address(RVA = "0x133F4C4", Offset = "0x133F4C4", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SaveConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SaveConfiguration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Preferences)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "SaveConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SaveConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryPickingDefaultUIScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CloudSocialModule), Member = "<Initialize>b__1_1", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "Configuration_OnSave_MinimapFrame", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "Configuration_OnSave_PlayerResourcesSet", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager2), Member = "Configuration_Save", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "Configuration_OnSave", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameManager), Member = "Configuration_Save", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = "Configuration_Save", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 130)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Put(string name, object value)
		{
			throw null;
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x0002A6E3 File Offset: 0x000288E3
		[global::Cpp2ILInjected.Token(Token = "0x600339A")]
		[global::Cpp2ILInjected.Address(RVA = "0x133F5D8", Offset = "0x133F5D8", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool Contains(string name)
		{
			throw null;
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x0002A6E6 File Offset: 0x000288E6
		[global::Cpp2ILInjected.Token(Token = "0x600339B")]
		[global::Cpp2ILInjected.Address(RVA = "0x15947B0", Offset = "0x15947B0", Length = "0x388")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadConfiguration", MemberParameters = new object[]
		{
			typeof(Preferences),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CloudSocialModule), Member = "<Initialize>b__1_0", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = "Configuration_OnLoad", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 53)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public T Get<T>(string name, T defaultValue)
		{
			throw null;
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x0002A6E9 File Offset: 0x000288E9
		[global::Cpp2ILInjected.Token(Token = "0x600339C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1594B38", Offset = "0x1594B38", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void Get<T>(string name, ref T currentValue)
		{
			throw null;
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x0002A6EC File Offset: 0x000288EC
		[global::Cpp2ILInjected.Token(Token = "0x600339D")]
		[global::Cpp2ILInjected.Address(RVA = "0x133F6D8", Offset = "0x133F6D8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public List<string> GetAllKeys()
		{
			throw null;
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x0002A6EF File Offset: 0x000288EF
		[global::Cpp2ILInjected.Token(Token = "0x600339E")]
		[global::Cpp2ILInjected.Address(RVA = "0x133F744", Offset = "0x133F744", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SaveConfiguration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Preferences)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear(string name)
		{
			throw null;
		}

		// Token: 0x04003296 RID: 12950
		[global::Cpp2ILInjected.Token(Token = "0x4003C4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<string, object> _data;

		// Token: 0x04003297 RID: 12951
		[global::Cpp2ILInjected.Token(Token = "0x4003C4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string _path;

		// Token: 0x04003298 RID: 12952
		[global::Cpp2ILInjected.Token(Token = "0x4003C4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly JsonSerializerSettings _serializerSettings;

		// Token: 0x04003299 RID: 12953
		[global::Cpp2ILInjected.Token(Token = "0x4003C4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly bool UseBson;

		// Token: 0x0400329A RID: 12954
		[global::Cpp2ILInjected.Token(Token = "0x4003C50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly object _lock;

		// Token: 0x0400329B RID: 12955
		[global::Cpp2ILInjected.Token(Token = "0x4003C51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public bool AutoSave;

		// Token: 0x0400329C RID: 12956
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Action<Preferences> OnSave;

		// Token: 0x0400329D RID: 12957
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Action<Preferences> OnLoad;

		// Token: 0x0400329E RID: 12958
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Preferences.TextProcessAction OnProcessText;

		// Token: 0x020008F5 RID: 2293
		// (Invoke) Token: 0x06004C13 RID: 19475
		[global::Cpp2ILInjected.Token(Token = "0x2000565")]
		public delegate void TextProcessAction(ref string text);
	}
}