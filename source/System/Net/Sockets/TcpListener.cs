﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	// Token: 0x02000217 RID: 535
	[global::Cpp2ILInjected.Token(Token = "0x2000306")]
	public class TcpListener
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x00006161 File Offset: 0x00004361
		[global::Cpp2ILInjected.Token(Token = "0x6001420")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33BA0", Offset = "0x1E33BA0", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.StartListening", MemberParameters = new object[] { "Terraria.Net.Sockets.SocketConnectionAccepted" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TcpListener))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "ValidateTcpPort", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public TcpListener(IPAddress localaddr, int port)
		{
			throw null;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00006164 File Offset: 0x00004364
		[global::Cpp2ILInjected.Token(Token = "0x6001421")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33D2C", Offset = "0x1E33D2C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "ValidateTcpPort", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_DualMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static TcpListener Create(int port)
		{
			throw null;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x00006167 File Offset: 0x00004367
		[global::Cpp2ILInjected.Token(Token = "0x1700048F")]
		public Socket Server
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001422")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E33E54", Offset = "0x1E33E54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0000616A File Offset: 0x0000436A
		[global::Cpp2ILInjected.Token(Token = "0x6001423")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33E5C", Offset = "0x1E33E5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.StartListening", MemberParameters = new object[] { "Terraria.Net.Sockets.SocketConnectionAccepted" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0000616D File Offset: 0x0000436D
		[global::Cpp2ILInjected.Token(Token = "0x6001424")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33E64", Offset = "0x1E33E64", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void Start(int backlog)
		{
			throw null;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00006170 File Offset: 0x00004370
		[global::Cpp2ILInjected.Token(Token = "0x6001425")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33FDC", Offset = "0x1E33FDC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "ListenLoop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_ExclusiveAddressUse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00006173 File Offset: 0x00004373
		[global::Cpp2ILInjected.Token(Token = "0x6001426")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34094", Offset = "0x1E34094", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "ListenLoop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = ".ctor", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public TcpClient AcceptTcpClient()
		{
			throw null;
		}

		// Token: 0x04000CDC RID: 3292
		[global::Cpp2ILInjected.Token(Token = "0x40010D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IPEndPoint m_ServerSocketEP;

		// Token: 0x04000CDD RID: 3293
		[global::Cpp2ILInjected.Token(Token = "0x40010D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Socket m_ServerSocket;

		// Token: 0x04000CDE RID: 3294
		[global::Cpp2ILInjected.Token(Token = "0x40010D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_Active;

		// Token: 0x04000CDF RID: 3295
		[global::Cpp2ILInjected.Token(Token = "0x40010D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool m_ExclusiveAddressUse;
	}
}
