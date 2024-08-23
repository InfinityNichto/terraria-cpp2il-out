﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000190 RID: 400
	[global::Cpp2ILInjected.Token(Token = "0x2000241")]
	internal sealed class EndPointListener
	{
		// Token: 0x06000CFD RID: 3325 RVA: 0x00005336 File Offset: 0x00003536
		[global::Cpp2ILInjected.Token(Token = "0x6000E7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F444C8", Offset = "0x1F444C8", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(HttpListener),
			typeof(bool)
		}, ReturnType = typeof(EndPointListener))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "LoadCertificateAndKey", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandler<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncEventArgs), Member = "add_Completed", MemberParameters = new object[] { typeof(EventHandler<SocketAsyncEventArgs>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(SocketAsyncEventArgs),
			typeof(ref Socket)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public EndPointListener(HttpListener listener, IPAddress addr, int port, bool secure)
		{
			throw null;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00005339 File Offset: 0x00003539
		[global::Cpp2ILInjected.Token(Token = "0x17000302")]
		internal HttpListener Listener
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F44C10", Offset = "0x1F44C10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0000533C File Offset: 0x0000353C
		[global::Cpp2ILInjected.Token(Token = "0x6000E7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F44AE0", Offset = "0x1F44AE0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListener),
			typeof(IPAddress),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "AcceptAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void Accept(Socket socket, SocketAsyncEventArgs e, ref Socket accepted)
		{
			throw null;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0000533F File Offset: 0x0000353F
		[global::Cpp2ILInjected.Token(Token = "0x6000E7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F44C18", Offset = "0x1F44C18", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(SocketAsyncEventArgs),
			typeof(ref Socket)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "OnAccept", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SocketAsyncEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(SocketAsyncEventArgs),
			typeof(ref Socket)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(EndPointListener),
			typeof(bool),
			typeof(X509Certificate)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "BeginReadRequest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void ProcessAccept(SocketAsyncEventArgs args)
		{
			throw null;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00005342 File Offset: 0x00003542
		[global::Cpp2ILInjected.Token(Token = "0x6000E7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F45224", Offset = "0x1F45224", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(void))]
		private static void OnAccept(object sender, SocketAsyncEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00005345 File Offset: 0x00003545
		[global::Cpp2ILInjected.Token(Token = "0x6000E80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4522C", Offset = "0x1F4522C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "RemoveConnection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void RemoveConnection(HttpConnection conn)
		{
			throw null;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00005348 File Offset: 0x00003548
		[global::Cpp2ILInjected.Token(Token = "0x6000E81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F45320", Offset = "0x1F45320", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref ListenerPrefix)
		}, ReturnType = typeof(HttpListener))]
		public bool BindContext(HttpListenerContext context)
		{
			throw null;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0000534B File Offset: 0x0000354B
		[global::Cpp2ILInjected.Token(Token = "0x6000E82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4595C", Offset = "0x1F4595C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UnbindContext(HttpListenerContext context)
		{
			throw null;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0000534E File Offset: 0x0000354E
		[global::Cpp2ILInjected.Token(Token = "0x6000E83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F45364", Offset = "0x1F45364", Length = "0x5F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "BindContext", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "UrlDecode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "MatchFromList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ArrayList),
			typeof(ref ListenerPrefix)
		}, ReturnType = typeof(HttpListener))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private HttpListener SearchListener(Uri uri, out ListenerPrefix prefix)
		{
			throw null;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00005351 File Offset: 0x00003551
		[global::Cpp2ILInjected.Token(Token = "0x6000E84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F45B20", Offset = "0x1F45B20", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref ListenerPrefix)
		}, ReturnType = typeof(HttpListener))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private HttpListener MatchFromList(string host, string path, ArrayList list, out ListenerPrefix prefix)
		{
			throw null;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00005354 File Offset: 0x00003554
		[global::Cpp2ILInjected.Token(Token = "0x6000E85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F45E20", Offset = "0x1F45E20", Length = "0x340")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "AddPrefix", MemberParameters = new object[]
		{
			typeof(ListenerPrefix),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void AddSpecial(ArrayList coll, ListenerPrefix prefix)
		{
			throw null;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00005357 File Offset: 0x00003557
		[global::Cpp2ILInjected.Token(Token = "0x6000E86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F46160", Offset = "0x1F46160", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "RemovePrefix", MemberParameters = new object[]
		{
			typeof(ListenerPrefix),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool RemoveSpecial(ArrayList coll, ListenerPrefix prefix)
		{
			throw null;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0000535A File Offset: 0x0000355A
		[global::Cpp2ILInjected.Token(Token = "0x6000E87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F46248", Offset = "0x1F46248", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "RemovePrefix", MemberParameters = new object[]
		{
			typeof(ListenerPrefix),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CheckIfRemove()
		{
			throw null;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0000535D File Offset: 0x0000355D
		[global::Cpp2ILInjected.Token(Token = "0x6000E88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4653C", Offset = "0x1F4653C", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "RemoveEndPoint", MemberParameters = new object[]
		{
			typeof(EndPointListener),
			typeof(IPEndPoint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00005360 File Offset: 0x00003560
		[global::Cpp2ILInjected.Token(Token = "0x6000E89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F469FC", Offset = "0x1F469FC", Length = "0x370")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "AddSpecial", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(ListenerPrefix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void AddPrefix(ListenerPrefix prefix, HttpListener listener)
		{
			throw null;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00005363 File Offset: 0x00003563
		[global::Cpp2ILInjected.Token(Token = "0x6000E8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F46D6C", Offset = "0x1F46D6C", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "RemovePrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "RemoveSpecial", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(ListenerPrefix)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "CheckIfRemove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void RemovePrefix(ListenerPrefix prefix, HttpListener listener)
		{
			throw null;
		}

		// Token: 0x04000930 RID: 2352
		[global::Cpp2ILInjected.Token(Token = "0x4000BD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private HttpListener listener;

		// Token: 0x04000931 RID: 2353
		[global::Cpp2ILInjected.Token(Token = "0x4000BD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IPEndPoint endpoint;

		// Token: 0x04000932 RID: 2354
		[global::Cpp2ILInjected.Token(Token = "0x4000BDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Socket sock;

		// Token: 0x04000933 RID: 2355
		[global::Cpp2ILInjected.Token(Token = "0x4000BDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Hashtable prefixes;

		// Token: 0x04000934 RID: 2356
		[global::Cpp2ILInjected.Token(Token = "0x4000BDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ArrayList unhandled;

		// Token: 0x04000935 RID: 2357
		[global::Cpp2ILInjected.Token(Token = "0x4000BDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ArrayList all;

		// Token: 0x04000936 RID: 2358
		[global::Cpp2ILInjected.Token(Token = "0x4000BDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private X509Certificate cert;

		// Token: 0x04000937 RID: 2359
		[global::Cpp2ILInjected.Token(Token = "0x4000BDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool secure;

		// Token: 0x04000938 RID: 2360
		[global::Cpp2ILInjected.Token(Token = "0x4000BE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Dictionary<HttpConnection, HttpConnection> unregistered;
	}
}
