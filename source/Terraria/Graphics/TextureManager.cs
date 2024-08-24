﻿using System;
using System.Collections.Concurrent;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;

namespace Terraria.Graphics
{
	// Token: 0x020004DF RID: 1247
	[global::Cpp2ILInjected.Token(Token = "0x2000734")]
	internal static class TextureManager
	{
		// Token: 0x060036A5 RID: 13989 RVA: 0x0002BC34 File Offset: 0x00029E34
		[global::Cpp2ILInjected.Token(Token = "0x6003D06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1499D34", Offset = "0x1499D34", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDeviceManager), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x0002BC37 File Offset: 0x00029E37
		[global::Cpp2ILInjected.Token(Token = "0x6003D07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1499E00", Offset = "0x1499E00", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldOperationProgress), Member = "GetIcon", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "GetIcon", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "GetIcon", MemberParameters = new object[] { typeof(GUIMultiplayerLobby.ServerInformation) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "GetIcon", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "GetSeedIcon", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(string)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "GetWorldIcon", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureManager), Member = "Retrieve", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Ref<Texture2D>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureManager), Member = "Run", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static Texture2D Load(string name)
		{
			throw null;
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x0002BC3A File Offset: 0x00029E3A
		[global::Cpp2ILInjected.Token(Token = "0x6003D08")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A044", Offset = "0x149A044", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureManager), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Ref<Texture2D> Retrieve(string name)
		{
			throw null;
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x0002BC3D File Offset: 0x00029E3D
		[global::Cpp2ILInjected.Token(Token = "0x6003D09")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A0E8", Offset = "0x149A0E8", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<TextureManager.LoadPair>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<TextureManager.LoadPair>), Member = "TryDequeue", MemberParameters = new object[] { typeof(ref TextureManager.LoadPair) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureManager), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void Run(object context)
		{
			throw null;
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x0002BC40 File Offset: 0x00029E40
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003D0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A200", Offset = "0x149A200", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<TextureManager.LoadPair>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		static TextureManager()
		{
			throw null;
		}

		// Token: 0x04006720 RID: 26400
		[global::Cpp2ILInjected.Token(Token = "0x4007BFE")]
		private static ConcurrentDictionary<string, Texture2D> _textures;

		// Token: 0x04006721 RID: 26401
		[global::Cpp2ILInjected.Token(Token = "0x4007BFF")]
		private static ConcurrentQueue<TextureManager.LoadPair> _loadQueue;

		// Token: 0x04006722 RID: 26402
		[global::Cpp2ILInjected.Token(Token = "0x4007C00")]
		private static Thread _loadThread;

		// Token: 0x04006723 RID: 26403
		[global::Cpp2ILInjected.Token(Token = "0x4007C01")]
		private static readonly object _loadThreadLock;

		// Token: 0x04006724 RID: 26404
		[global::Cpp2ILInjected.Token(Token = "0x4007C02")]
		public static Texture2D BlankTexture;

		// Token: 0x02000962 RID: 2402
		[global::Cpp2ILInjected.Token(Token = "0x2000735")]
		private struct LoadPair
		{
			// Token: 0x06004D3B RID: 19771 RVA: 0x0002FA3E File Offset: 0x0002DC3E
			[global::Cpp2ILInjected.Token(Token = "0x6003D0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x149A310", Offset = "0x149A310", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public LoadPair(string path, Ref<Texture2D> textureRef)
			{
				throw null;
			}

			// Token: 0x04008B94 RID: 35732
			[global::Cpp2ILInjected.Token(Token = "0x4007C03")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string Path;

			// Token: 0x04008B95 RID: 35733
			[global::Cpp2ILInjected.Token(Token = "0x4007C04")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Ref<Texture2D> TextureRef;
		}
	}
}