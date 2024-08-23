﻿using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001AC RID: 428
	[global::Cpp2ILInjected.Token(Token = "0x200021A")]
	internal static class TaskToApm
	{
		// Token: 0x06001166 RID: 4454 RVA: 0x000175B8 File Offset: 0x000157B8
		[global::Cpp2ILInjected.Token(Token = "0x60012E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA37B4", Offset = "0x1CA37B4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "BeginRead", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "BeginWrite", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebReadStream", Member = "BeginRead", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginAuthenticateAsClient", MemberParameters = new object[]
		{
			typeof(string),
			"System.Security.Cryptography.X509Certificates.X509CertificateCollection",
			"System.Security.Authentication.SslProtocols",
			typeof(bool),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginRead", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginWrite", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "BeginRead", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "BeginWrite", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskToApm), Member = "InvokeCallbackWhenTaskCompletes", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.AsyncCallback),
			typeof(global::System.IAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static global::System.IAsyncResult Begin(Task task, global::System.AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x000175BB File Offset: 0x000157BB
		[global::Cpp2ILInjected.Token(Token = "0x60012E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3A24", Offset = "0x1CA3A24", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "EndAuthenticateAsClient", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void End(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x000175BE File Offset: 0x000157BE
		[global::Cpp2ILInjected.Token(Token = "0x60012E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0B9C", Offset = "0x15A0B9C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebReadStream", Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter<int>), Member = "GetResult", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static TResult End<TResult>(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000175C1 File Offset: 0x000157C1
		[global::Cpp2ILInjected.Token(Token = "0x60012E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3938", Offset = "0x1CA3938", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskToApm), Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "OnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void InvokeCallbackWhenTaskCompletes(Task antecedent, global::System.AsyncCallback callback, global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x020005BB RID: 1467
		[global::Cpp2ILInjected.Token(Token = "0x200021B")]
		private sealed class TaskWrapperAsyncResult : global::System.IAsyncResult
		{
			// Token: 0x06004057 RID: 16471 RVA: 0x0001FBB6 File Offset: 0x0001DDB6
			[global::Cpp2ILInjected.Token(Token = "0x60012E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA38FC", Offset = "0x1CA38FC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously)
			{
				throw null;
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06004058 RID: 16472 RVA: 0x0001FBB9 File Offset: 0x0001DDB9
			[global::Cpp2ILInjected.Token(Token = "0x170001C6")]
			private object System.IAsyncResult.AsyncState
			{
				[global::Cpp2ILInjected.Token(Token = "0x60012E5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CA3B48", Offset = "0x1CA3B48", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x06004059 RID: 16473 RVA: 0x0001FBBC File Offset: 0x0001DDBC
			[global::Cpp2ILInjected.Token(Token = "0x170001C7")]
			private bool System.IAsyncResult.CompletedSynchronously
			{
				[global::Cpp2ILInjected.Token(Token = "0x60012E6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CA3B50", Offset = "0x1CA3B50", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x0600405A RID: 16474 RVA: 0x0001FBBF File Offset: 0x0001DDBF
			[global::Cpp2ILInjected.Token(Token = "0x170001C8")]
			private bool System.IAsyncResult.IsCompleted
			{
				[global::Cpp2ILInjected.Token(Token = "0x60012E7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CA3B58", Offset = "0x1CA3B58", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x0600405B RID: 16475 RVA: 0x0001FBC2 File Offset: 0x0001DDC2
			[global::Cpp2ILInjected.Token(Token = "0x170001C9")]
			private WaitHandle System.IAsyncResult.AsyncWaitHandle
			{
				[global::Cpp2ILInjected.Token(Token = "0x60012E8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CA3B60", Offset = "0x1CA3B60", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040018C6 RID: 6342
			[global::Cpp2ILInjected.Token(Token = "0x4000A1D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal readonly Task Task;

			// Token: 0x040018C7 RID: 6343
			[global::Cpp2ILInjected.Token(Token = "0x4000A1E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly object _state;

			// Token: 0x040018C8 RID: 6344
			[global::Cpp2ILInjected.Token(Token = "0x4000A1F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private readonly bool _completedSynchronously;
		}

		// Token: 0x020005BC RID: 1468
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200021C")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x0600405C RID: 16476 RVA: 0x0001FBC5 File Offset: 0x0001DDC5
			[global::Cpp2ILInjected.Token(Token = "0x60012E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3B0C", Offset = "0x1CA3B0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass3_0()
			{
				throw null;
			}

			// Token: 0x0600405D RID: 16477 RVA: 0x0001FBC8 File Offset: 0x0001DDC8
			[global::Cpp2ILInjected.Token(Token = "0x60012EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3BFC", Offset = "0x1CA3BFC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <InvokeCallbackWhenTaskCompletes>b__0()
			{
				throw null;
			}

			// Token: 0x040018C9 RID: 6345
			[global::Cpp2ILInjected.Token(Token = "0x4000A20")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public global::System.AsyncCallback callback;

			// Token: 0x040018CA RID: 6346
			[global::Cpp2ILInjected.Token(Token = "0x4000A21")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public global::System.IAsyncResult asyncResult;
		}
	}
}
