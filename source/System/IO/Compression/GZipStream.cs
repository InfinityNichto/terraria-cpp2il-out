﻿using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO.Compression
{
	// Token: 0x02000319 RID: 793
	[global::Cpp2ILInjected.Token(Token = "0x200043C")]
	public class GZipStream : Stream
	{
		// Token: 0x06001A53 RID: 6739 RVA: 0x00007856 File Offset: 0x00005A56
		[global::Cpp2ILInjected.Token(Token = "0x6001D9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93A80", Offset = "0x1E93A80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "NewDrawFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentDecodeStream), Member = "Create", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(ContentDecodeStream.Mode)
		}, ReturnType = typeof(ContentDecodeStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(WebResponseStream),
			typeof(CookieContainer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public GZipStream(Stream stream, CompressionMode mode)
		{
			throw null;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00007859 File Offset: 0x00005A59
		[global::Cpp2ILInjected.Token(Token = "0x6001DA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93A88", Offset = "0x1E93A88", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x0000785C File Offset: 0x00005A5C
		[global::Cpp2ILInjected.Token(Token = "0x170006B1")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93B44", Offset = "0x1E93B44", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0000785F File Offset: 0x00005A5F
		[global::Cpp2ILInjected.Token(Token = "0x170006B2")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93B5C", Offset = "0x1E93B5C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00007862 File Offset: 0x00005A62
		[global::Cpp2ILInjected.Token(Token = "0x170006B3")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93B74", Offset = "0x1E93B74", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00007865 File Offset: 0x00005A65
		[global::Cpp2ILInjected.Token(Token = "0x170006B4")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93B8C", Offset = "0x1E93B8C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x00007868 File Offset: 0x00005A68
		// (set) Token: 0x06001A5A RID: 6746 RVA: 0x0000786B File Offset: 0x00005A6B
		[global::Cpp2ILInjected.Token(Token = "0x170006B5")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93BD8", Offset = "0x1E93BD8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001DA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93C24", Offset = "0x1E93C24", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0000786E File Offset: 0x00005A6E
		[global::Cpp2ILInjected.Token(Token = "0x6001DA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93C70", Offset = "0x1E93C70", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00007871 File Offset: 0x00005A71
		[global::Cpp2ILInjected.Token(Token = "0x6001DA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93CAC", Offset = "0x1E93CAC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00007874 File Offset: 0x00005A74
		[global::Cpp2ILInjected.Token(Token = "0x6001DA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93CF8", Offset = "0x1E93CF8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00007877 File Offset: 0x00005A77
		[global::Cpp2ILInjected.Token(Token = "0x6001DAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93D44", Offset = "0x1E93D44", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int ReadByte()
		{
			throw null;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0000787A File Offset: 0x00005A7A
		[global::Cpp2ILInjected.Token(Token = "0x6001DAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93D68", Offset = "0x1E93D68", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			throw null;
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0000787D File Offset: 0x00005A7D
		[global::Cpp2ILInjected.Token(Token = "0x6001DAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93E1C", Offset = "0x1E93E1C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00007880 File Offset: 0x00005A80
		[global::Cpp2ILInjected.Token(Token = "0x6001DAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93E64", Offset = "0x1E93E64", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Read(byte[] array, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00007883 File Offset: 0x00005A83
		[global::Cpp2ILInjected.Token(Token = "0x6001DAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93E88", Offset = "0x1E93E88", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Read", MemberParameters = new object[] { typeof(Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int Read(Span<byte> buffer)
		{
			throw null;
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00007886 File Offset: 0x00005A86
		[global::Cpp2ILInjected.Token(Token = "0x6001DAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E940A4", Offset = "0x1E940A4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			throw null;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00007889 File Offset: 0x00005A89
		[global::Cpp2ILInjected.Token(Token = "0x6001DB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94158", Offset = "0x1E94158", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0000788C File Offset: 0x00005A8C
		[global::Cpp2ILInjected.Token(Token = "0x6001DB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94164", Offset = "0x1E94164", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(byte[] array, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0000788F File Offset: 0x00005A8F
		[global::Cpp2ILInjected.Token(Token = "0x6001DB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94188", Offset = "0x1E94188", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Write", MemberParameters = new object[] { typeof(ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			throw null;
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00007892 File Offset: 0x00005A92
		[global::Cpp2ILInjected.Token(Token = "0x6001DB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E942F8", Offset = "0x1E942F8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void CopyTo(Stream destination, int bufferSize)
		{
			throw null;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00007895 File Offset: 0x00005A95
		[global::Cpp2ILInjected.Token(Token = "0x6001DB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9431C", Offset = "0x1E9431C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00007898 File Offset: 0x00005A98
		[global::Cpp2ILInjected.Token(Token = "0x6001DB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E943D4", Offset = "0x1E943D4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0000789B File Offset: 0x00005A9B
		[global::Cpp2ILInjected.Token(Token = "0x6001DB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E943F8", Offset = "0x1E943F8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0000789E File Offset: 0x00005A9E
		[global::Cpp2ILInjected.Token(Token = "0x6001DB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E944DC", Offset = "0x1E944DC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x000078A1 File Offset: 0x00005AA1
		[global::Cpp2ILInjected.Token(Token = "0x6001DB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94500", Offset = "0x1E94500", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x000078A4 File Offset: 0x00005AA4
		[global::Cpp2ILInjected.Token(Token = "0x6001DB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E945E4", Offset = "0x1E945E4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000078A7 File Offset: 0x00005AA7
		[global::Cpp2ILInjected.Token(Token = "0x6001DBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93C94", Offset = "0x1E93C94", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
		private void CheckDeflateStream()
		{
			throw null;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x000078AA File Offset: 0x00005AAA
		[global::Cpp2ILInjected.Token(Token = "0x6001DBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94608", Offset = "0x1E94608", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "Read", MemberParameters = new object[] { typeof(Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "Write", MemberParameters = new object[] { typeof(ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "CheckDeflateStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowStreamClosedException()
		{
			throw null;
		}

		// Token: 0x04000F98 RID: 3992
		[global::Cpp2ILInjected.Token(Token = "0x4001409")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private DeflateStream _deflateStream;
	}
}
