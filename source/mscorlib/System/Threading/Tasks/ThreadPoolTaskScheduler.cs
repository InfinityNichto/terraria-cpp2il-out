﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;
using Internal.Threading.Tasks.Tracing;

namespace System.Threading.Tasks
{
	// Token: 0x020001CE RID: 462
	[global::Cpp2ILInjected.Token(Token = "0x2000251")]
	internal sealed class ThreadPoolTaskScheduler : TaskScheduler
	{
		// Token: 0x06001298 RID: 4760 RVA: 0x0001793F File Offset: 0x00015B3F
		[global::Cpp2ILInjected.Token(Token = "0x600144E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAEE10", Offset = "0x1CAEE10", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskScheduler), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ThreadPoolTaskScheduler()
		{
			throw null;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00017942 File Offset: 0x00015B42
		[global::Cpp2ILInjected.Token(Token = "0x600144F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAEE68", Offset = "0x1CAEE68", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Threading.Tasks.Tracing.TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Threading.Tasks.Tracing.TaskTrace), Member = "TaskScheduled", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "Create", MemberParameters = new object[]
		{
			typeof(ParameterizedThreadStart),
			typeof(int)
		}, ReturnType = typeof(Internal.Runtime.Augments.RuntimeThread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "Start", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected internal override void QueueTask(Task task)
		{
			throw null;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00017945 File Offset: 0x00015B45
		[global::Cpp2ILInjected.Token(Token = "0x6001450")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF01C", Offset = "0x1CAF01C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "TryPopCustomWorkItem", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			throw null;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00017948 File Offset: 0x00015B48
		[global::Cpp2ILInjected.Token(Token = "0x6001451")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF0F4", Offset = "0x1CAF0F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "TryPopCustomWorkItem", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		protected internal override bool TryDequeue(Task task)
		{
			throw null;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0001794B File Offset: 0x00015B4B
		[global::Cpp2ILInjected.Token(Token = "0x6001452")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF0FC", Offset = "0x1CAF0FC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "EnsureVMInitialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void NotifyWorkItemProgress()
		{
			throw null;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x0001794E File Offset: 0x00015B4E
		[global::Cpp2ILInjected.Token(Token = "0x170001FD")]
		internal override bool RequiresAtomicStartTransition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001453")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAF10C", Offset = "0x1CAF10C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00017951 File Offset: 0x00015B51
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001454")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF114", Offset = "0x1CAF114", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterizedThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static ThreadPoolTaskScheduler()
		{
			throw null;
		}

		// Token: 0x0400085A RID: 2138
		[global::Cpp2ILInjected.Token(Token = "0x4000AC5")]
		private static readonly ParameterizedThreadStart s_longRunningThreadWork;

		// Token: 0x020005CE RID: 1486
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000252")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x0600408D RID: 16525 RVA: 0x0001FC58 File Offset: 0x0001DE58
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001455")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAF1D8", Offset = "0x1CAF1D8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x0600408E RID: 16526 RVA: 0x0001FC5B File Offset: 0x0001DE5B
			[global::Cpp2ILInjected.Token(Token = "0x6001456")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAF234", Offset = "0x1CAF234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x0600408F RID: 16527 RVA: 0x0001FC5E File Offset: 0x0001DE5E
			[global::Cpp2ILInjected.Token(Token = "0x6001457")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAF23C", Offset = "0x1CAF23C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <.cctor>b__10_0(object s)
			{
				throw null;
			}

			// Token: 0x040018F3 RID: 6387
			[global::Cpp2ILInjected.Token(Token = "0x4000AC6")]
			public static readonly ThreadPoolTaskScheduler.<>c <>9;
		}
	}
}
