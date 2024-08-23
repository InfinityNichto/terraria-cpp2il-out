﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using Terraria.WorldBuilding;

namespace Terraria.IO
{
	// Token: 0x020003BD RID: 957
	[global::Cpp2ILInjected.Token(Token = "0x2000561")]
	public class GameConfiguration
	{
		// Token: 0x06002F13 RID: 12051 RVA: 0x0002A683 File Offset: 0x00028883
		[global::Cpp2ILInjected.Token(Token = "0x6003378")]
		[global::Cpp2ILInjected.Address(RVA = "0x133C020", Offset = "0x133C020", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenConfiguration), Member = ".ctor", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenConfiguration), Member = "GetPassConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GameConfiguration))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameConfiguration(JObject configurationRoot)
		{
			throw null;
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x0002A686 File Offset: 0x00028886
		[global::Cpp2ILInjected.Token(Token = "0x6003379")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A524", Offset = "0x158A524", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_1", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_100", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public T Get<T>(string entry)
		{
			throw null;
		}

		// Token: 0x04003290 RID: 12944
		[global::Cpp2ILInjected.Token(Token = "0x4003C45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly JObject _root;
	}
}