﻿using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO.Compression
{
	// Token: 0x0200031A RID: 794
	[global::Cpp2ILInjected.Token(Token = "0x200043D")]
	public class DeflateStream : Stream
	{
		// Token: 0x06001A70 RID: 6768 RVA: 0x000078AD File Offset: 0x00005AAD
		[global::Cpp2ILInjected.Token(Token = "0x6001DBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94658", Offset = "0x1E94658", Length = "0xC")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public DeflateStream(Stream stream, CompressionMode mode)
		{
			throw null;
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000078B0 File Offset: 0x00005AB0
		[global::Cpp2ILInjected.Token(Token = "0x6001DBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93B38", Offset = "0x1E93B38", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits)
		{
			throw null;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000078B3 File Offset: 0x00005AB3
		[global::Cpp2ILInjected.Token(Token = "0x6001DBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94664", Offset = "0x1E94664", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "Create", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool)
		}, ReturnType = typeof(DeflateStreamNative))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip)
		{
			throw null;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x000078B6 File Offset: 0x00005AB6
		[global::Cpp2ILInjected.Token(Token = "0x6001DBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E948F8", Offset = "0x1E948F8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000078B9 File Offset: 0x00005AB9
		[global::Cpp2ILInjected.Token(Token = "0x6001DC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9499C", Offset = "0x1E9499C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x000078BC File Offset: 0x00005ABC
		[global::Cpp2ILInjected.Token(Token = "0x6001DC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94B50", Offset = "0x1E94B50", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int ReadInternal(byte[] array, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x000078BF File Offset: 0x00005ABF
		[global::Cpp2ILInjected.Token(Token = "0x6001DC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E944D4", Offset = "0x1E944D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x000078C2 File Offset: 0x00005AC2
		[global::Cpp2ILInjected.Token(Token = "0x6001DC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93F74", Offset = "0x1E93F74", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal int ReadCore(Span<byte> destination)
		{
			throw null;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x000078C5 File Offset: 0x00005AC5
		[global::Cpp2ILInjected.Token(Token = "0x6001DC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94BFC", Offset = "0x1E94BFC", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "ReadZStream", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override int Read(byte[] array, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x000078C8 File Offset: 0x00005AC8
		[global::Cpp2ILInjected.Token(Token = "0x6001DC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94DE0", Offset = "0x1E94DE0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void WriteInternal(byte[] array, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000078CB File Offset: 0x00005ACB
		[global::Cpp2ILInjected.Token(Token = "0x6001DC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E945DC", Offset = "0x1E945DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000078CE File Offset: 0x00005ACE
		[global::Cpp2ILInjected.Token(Token = "0x6001DC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94274", Offset = "0x1E94274", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void WriteCore(ReadOnlySpan<byte> source)
		{
			throw null;
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000078D1 File Offset: 0x00005AD1
		[global::Cpp2ILInjected.Token(Token = "0x6001DC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94E7C", Offset = "0x1E94E7C", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "WriteZStream", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public override void Write(byte[] array, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000078D4 File Offset: 0x00005AD4
		[global::Cpp2ILInjected.Token(Token = "0x6001DC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95068", Offset = "0x1E95068", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x000078D7 File Offset: 0x00005AD7
		[global::Cpp2ILInjected.Token(Token = "0x6001DCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95158", Offset = "0x1E95158", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream.ReadMethod), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream.ReadMethod), Member = "BeginInvoke", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			throw null;
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000078DA File Offset: 0x00005ADA
		[global::Cpp2ILInjected.Token(Token = "0x6001DCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95528", Offset = "0x1E95528", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream.WriteMethod), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream.WriteMethod), Member = "BeginInvoke", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			throw null;
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000078DD File Offset: 0x00005ADD
		[global::Cpp2ILInjected.Token(Token = "0x6001DCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E958F8", Offset = "0x1E958F8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x000078E0 File Offset: 0x00005AE0
		[global::Cpp2ILInjected.Token(Token = "0x6001DCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95A64", Offset = "0x1E95A64", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000078E3 File Offset: 0x00005AE3
		[global::Cpp2ILInjected.Token(Token = "0x6001DCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95BB0", Offset = "0x1E95BB0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000078E6 File Offset: 0x00005AE6
		[global::Cpp2ILInjected.Token(Token = "0x6001DCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95BE8", Offset = "0x1E95BE8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x000078E9 File Offset: 0x00005AE9
		[global::Cpp2ILInjected.Token(Token = "0x170006B6")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E95C20", Offset = "0x1E95C20", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x000078EC File Offset: 0x00005AEC
		[global::Cpp2ILInjected.Token(Token = "0x170006B7")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E95C48", Offset = "0x1E95C48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x000078EF File Offset: 0x00005AEF
		[global::Cpp2ILInjected.Token(Token = "0x170006B8")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E95C50", Offset = "0x1E95C50", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x000078F2 File Offset: 0x00005AF2
		[global::Cpp2ILInjected.Token(Token = "0x170006B9")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E95C7C", Offset = "0x1E95C7C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x000078F5 File Offset: 0x00005AF5
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x000078F8 File Offset: 0x00005AF8
		[global::Cpp2ILInjected.Token(Token = "0x170006BA")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E95CB4", Offset = "0x1E95CB4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001DD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E95CEC", Offset = "0x1E95CEC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000F99 RID: 3993
		[global::Cpp2ILInjected.Token(Token = "0x400140A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Stream base_stream;

		// Token: 0x04000F9A RID: 3994
		[global::Cpp2ILInjected.Token(Token = "0x400140B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private CompressionMode mode;

		// Token: 0x04000F9B RID: 3995
		[global::Cpp2ILInjected.Token(Token = "0x400140C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool leaveOpen;

		// Token: 0x04000F9C RID: 3996
		[global::Cpp2ILInjected.Token(Token = "0x400140D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
		private bool disposed;

		// Token: 0x04000F9D RID: 3997
		[global::Cpp2ILInjected.Token(Token = "0x400140E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private DeflateStreamNative native;

		// Token: 0x02000480 RID: 1152
		// (Invoke) Token: 0x06001FB6 RID: 8118
		[global::Cpp2ILInjected.Token(Token = "0x200043E")]
		private delegate int ReadMethod(byte[] array, int offset, int count);

		// Token: 0x02000481 RID: 1153
		// (Invoke) Token: 0x06001FBA RID: 8122
		[global::Cpp2ILInjected.Token(Token = "0x200043F")]
		private delegate void WriteMethod(byte[] array, int offset, int count);
	}
}