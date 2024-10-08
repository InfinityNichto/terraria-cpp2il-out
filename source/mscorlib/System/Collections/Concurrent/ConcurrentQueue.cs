﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Concurrent
{
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000610")]
	[global::System.Serializable]
	public class ConcurrentQueue<T> : IProducerConsumerCollection<T>, global::System.Collections.Generic.IEnumerable<T>, IEnumerable, ICollection, global::System.Collections.Generic.IReadOnlyCollection<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002F57")]
		[global::Cpp2ILInjected.Address(RVA = "0x191B87C", Offset = "0x191B87C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Common", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ConcurrentQueue()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F58")]
		[global::Cpp2ILInjected.Address(RVA = "0x191B934", Offset = "0x191B934", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700077D")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F59")]
			[global::Cpp2ILInjected.Address(RVA = "0x191BA28", Offset = "0x191BA28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700077E")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x191BA30", Offset = "0x191BA30", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x191BA7C", Offset = "0x191BA7C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x191BAFC", Offset = "0x191BAFC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x191BB20", Offset = "0x191BB20", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(out T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x191BB34", Offset = "0x191BB34", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public T[] ToArray()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700077F")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x191BE58", Offset = "0x191BE58", Length = "0x234")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Common", Member = "get_ReceiveQueueCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Common", Member = "ReceiveLoop", MemberParameters = new object[]
			{
				typeof(int),
				"System.Net.Sockets.TcpClient",
				"System.Collections.Concurrent.ConcurrentQueue`1<Message>",
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F60")]
		[global::Cpp2ILInjected.Address(RVA = "0x191C08C", Offset = "0x191C08C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static int GetCount(ConcurrentQueue<T>.Segment s, int head, int tail)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F61")]
		[global::Cpp2ILInjected.Address(RVA = "0x191C144", Offset = "0x191C144", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static long GetCount(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F62")]
		[global::Cpp2ILInjected.Address(RVA = "0x191C2F0", Offset = "0x191C2F0", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public void CopyTo(T[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F63")]
		[global::Cpp2ILInjected.Address(RVA = "0x191C6B0", Offset = "0x191C6B0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F64")]
		[global::Cpp2ILInjected.Address(RVA = "0x191C720", Offset = "0x191C720", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void SnapForObservation(out ConcurrentQueue<T>.Segment head, out int headHead, out ConcurrentQueue<T>.Segment tail, out int tailTail)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F65")]
		[global::Cpp2ILInjected.Address(RVA = "0x191C878", Offset = "0x191C878", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private T GetItemWhenAvailable(ConcurrentQueue<T>.Segment segment, int i)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F66")]
		[global::Cpp2ILInjected.Address(RVA = "0x191C934", Offset = "0x191C934", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.Collections.Generic.IEnumerator<T> Enumerate(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F67")]
		[global::Cpp2ILInjected.Address(RVA = "0x191C9C4", Offset = "0x191C9C4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Common", Member = "ReceiveLoop", MemberParameters = new object[]
		{
			typeof(int),
			"System.Net.Sockets.TcpClient",
			"System.Collections.Concurrent.ConcurrentQueue`1<Message>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Enqueue(T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F68")]
		[global::Cpp2ILInjected.Address(RVA = "0x191CA48", Offset = "0x191CA48", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void EnqueueSlow(T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F69")]
		[global::Cpp2ILInjected.Address(RVA = "0x191CC64", Offset = "0x191CC64", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Common", Member = "GetNextMessage", MemberParameters = new object[] { "Telepathy.Message&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryDequeue(out T result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x191CCE0", Offset = "0x191CCE0", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private bool TryDequeueSlow(out T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001A12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object _crossSegmentLock;

		[global::Cpp2ILInjected.Token(Token = "0x4001A13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ConcurrentQueue<T>.Segment _tail;

		[global::Cpp2ILInjected.Token(Token = "0x4001A14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ConcurrentQueue<T>.Segment _head;

		[global::System.Diagnostics.DebuggerDisplay("Capacity = {Capacity}")]
		[global::Cpp2ILInjected.Token(Token = "0x2000611")]
		internal sealed class Segment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18637EC", Offset = "0x18637EC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Segment(int boundedLength)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000780")]
			internal int Capacity
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F6C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1863868", Offset = "0x1863868", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000781")]
			internal int FreezeOffset
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F6D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1863874", Offset = "0x1863874", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002F6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1863884", Offset = "0x1863884", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void EnsureFrozenForEnqueues()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002F6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1863910", Offset = "0x1863910", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool TryDequeue(out T item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002F70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1863A4C", Offset = "0x1863A4C", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool TryEnqueue(T item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A15")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal readonly ConcurrentQueue<T>.Segment.Slot[] _slots;

			[global::Cpp2ILInjected.Token(Token = "0x4001A16")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal readonly int _slotsMask;

			[global::Cpp2ILInjected.Token(Token = "0x4001A17")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal PaddedHeadAndTail _headAndTail;

			[global::Cpp2ILInjected.Token(Token = "0x4001A18")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal bool _preservedForObservation;

			[global::Cpp2ILInjected.Token(Token = "0x4001A19")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal bool _frozenForEnqueues;

			[global::Cpp2ILInjected.Token(Token = "0x4001A1A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ConcurrentQueue<T>.Segment _nextSegment;

			[global::System.Diagnostics.DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
			[global::Cpp2ILInjected.Token(Token = "0x2000612")]
			[StructLayout(3)]
			internal struct Slot
			{
				[global::Cpp2ILInjected.Token(Token = "0x4001A1B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public T Item;

				[global::Cpp2ILInjected.Token(Token = "0x4001A1C")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public int SequenceNumber;
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000613")]
		private sealed class <Enumerate>d__28 : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, IEnumerator
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002F71")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B86F8", Offset = "0x15B86F8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <Enumerate>d__28(int <>1__state)
			{
				throw null;
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002F72")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B8720", Offset = "0x15B8720", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002F73")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B8724", Offset = "0x15B8724", Length = "0x2D0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000782")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6002F74")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B89F4", Offset = "0x15B89F4", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002F75")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B8A00", Offset = "0x15B8A00", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000783")]
			private object System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6002F76")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B8A38", Offset = "0x15B8A38", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A1D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4001A1E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x4001A1F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ConcurrentQueue<T>.Segment head;

			[global::Cpp2ILInjected.Token(Token = "0x4001A20")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ConcurrentQueue<T>.Segment tail;

			[global::Cpp2ILInjected.Token(Token = "0x4001A21")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int tailTail;

			[global::Cpp2ILInjected.Token(Token = "0x4001A22")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int headHead;

			[global::Cpp2ILInjected.Token(Token = "0x4001A23")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ConcurrentQueue<T> <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4001A24")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <headTail>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4001A25")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <i>5__3;

			[global::Cpp2ILInjected.Token(Token = "0x4001A26")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private ConcurrentQueue<T>.Segment <s>5__4;

			[global::Cpp2ILInjected.Token(Token = "0x4001A27")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <i>5__5;
		}
	}
}
