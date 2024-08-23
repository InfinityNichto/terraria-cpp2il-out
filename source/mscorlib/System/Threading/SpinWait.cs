﻿using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Threading
{
	// Token: 0x0200017A RID: 378
	[global::Cpp2ILInjected.Token(Token = "0x20001CD")]
	public struct SpinWait
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x0001719E File Offset: 0x0001539E
		[global::Cpp2ILInjected.Token(Token = "0x1700018E")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9615C", Offset = "0x1C9615C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x000171A1 File Offset: 0x000153A1
		[global::Cpp2ILInjected.Token(Token = "0x1700018F")]
		public bool NextSpinWillYield
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C96164", Offset = "0x1C96164", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new object[]
			{
				typeof(int),
				typeof(uint),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000171A4 File Offset: 0x000153A4
		[global::Cpp2ILInjected.Token(Token = "0x60010FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C960C0", Offset = "0x1C960C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.QueueSegment), Member = "TryDequeue", MemberParameters = new object[] { typeof(ref IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskCompletionSource<>), Member = "SpinUntilCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "SetNotificationForWaitCompletion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentQueue<>.Segment), Member = "EnsureFrozenForEnqueues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentQueue<>.Segment), Member = "TryDequeue", MemberParameters = new object[] { "T&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentQueue<>.Segment), Member = "TryEnqueue", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentQueue<>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentQueue<>), Member = "GetItemWhenAvailable", MemberParameters = new object[]
		{
			"Segment<T>",
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryAddWithNoTimeValidation", MemberParameters = new object[]
		{
			"T",
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void SpinOnce()
		{
			throw null;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000171A7 File Offset: 0x000153A7
		[global::Cpp2ILInjected.Token(Token = "0x60010FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95D6C", Offset = "0x1C95D6C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "SpinWait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void SpinOnce(int sleep1Threshold)
		{
			throw null;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000171AA File Offset: 0x000153AA
		[global::Cpp2ILInjected.Token(Token = "0x60010FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C961DC", Offset = "0x1C961DC", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "UpdateStateAtomically", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinWait), Member = "SpinOnce", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "WaitForCallbackToComplete", MemberParameters = new object[] { typeof(CancellationCallbackInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "DecrementWaiters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "SpinWait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "Yield", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void SpinOnceCore(int sleep1Threshold)
		{
			throw null;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000171AD File Offset: 0x000153AD
		[global::Cpp2ILInjected.Token(Token = "0x60010FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96380", Offset = "0x1C96380", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryAddWithNoTimeValidation", MemberParameters = new object[]
		{
			"T",
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000171B0 File Offset: 0x000153B0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60010FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96388", Offset = "0x1C96388", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SpinWait()
		{
			throw null;
		}

		// Token: 0x04000723 RID: 1827
		[global::Cpp2ILInjected.Token(Token = "0x4000924")]
		internal static readonly int SpinCountforSpinBeforeWait;

		// Token: 0x04000724 RID: 1828
		[global::Cpp2ILInjected.Token(Token = "0x4000925")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _count;
	}
}
