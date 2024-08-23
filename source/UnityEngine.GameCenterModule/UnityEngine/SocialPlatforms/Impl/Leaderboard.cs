﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000012 RID: 18
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	public class Leaderboard
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000020CE File Offset: 0x000002CE
		[global::Cpp2ILInjected.Token(Token = "0x6000031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F938CC", Offset = "0x1F938CC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Local), Member = "PopulateStaticData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Score), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public Leaderboard()
		{
			throw null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020D1 File Offset: 0x000002D1
		[global::Cpp2ILInjected.Token(Token = "0x6000032")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F94514", Offset = "0x1F94514", Length = "0x4A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020D4 File Offset: 0x000002D4
		[global::Cpp2ILInjected.Token(Token = "0x6000033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F93A2C", Offset = "0x1F93A2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetScores(IScore[] scores)
		{
			throw null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020D7 File Offset: 0x000002D7
		[global::Cpp2ILInjected.Token(Token = "0x6000034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F939CC", Offset = "0x1F939CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetTitle(string title)
		{
			throw null;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000020DA File Offset: 0x000002DA
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000020DD File Offset: 0x000002DD
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public string id
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000035")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F949BC", Offset = "0x1F949BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000036")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F949C4", Offset = "0x1F949C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000020E0 File Offset: 0x000002E0
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000020E3 File Offset: 0x000002E3
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public UserScope userScope
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000037")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F949CC", Offset = "0x1F949CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000038")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F949D4", Offset = "0x1F949D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000020E6 File Offset: 0x000002E6
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000020E9 File Offset: 0x000002E9
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public Range range
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000039")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F949DC", Offset = "0x1F949DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600003A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F949E4", Offset = "0x1F949E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000020EC File Offset: 0x000002EC
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000020EF File Offset: 0x000002EF
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public TimeScope timeScope
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600003B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F949EC", Offset = "0x1F949EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600003C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F949F4", Offset = "0x1F949F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_Loading;

		// Token: 0x04000030 RID: 48
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IScore m_LocalUserScore;

		// Token: 0x04000031 RID: 49
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private uint m_MaxRange;

		// Token: 0x04000032 RID: 50
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IScore[] m_Scores;

		// Token: 0x04000033 RID: 51
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string m_Title;

		// Token: 0x04000034 RID: 52
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string[] m_UserIDs;

		// Token: 0x04000035 RID: 53
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string <id>k__BackingField;

		// Token: 0x04000036 RID: 54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private UserScope <userScope>k__BackingField;

		// Token: 0x04000037 RID: 55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private Range <range>k__BackingField;

		// Token: 0x04000038 RID: 56
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private TimeScope <timeScope>k__BackingField;
	}
}
