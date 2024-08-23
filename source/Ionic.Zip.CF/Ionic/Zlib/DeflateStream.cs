﻿using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zip;

namespace Ionic.Zlib
{
	// Token: 0x02000036 RID: 54
	[global::Cpp2ILInjected.Token(Token = "0x2000043")]
	public class DeflateStream : Stream
	{
		// Token: 0x0600031F RID: 799 RVA: 0x000057D6 File Offset: 0x000039D6
		[global::Cpp2ILInjected.Token(Token = "0x600033D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6CCC8", Offset = "0x1A6CCC8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "DecompressData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "DecompressData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "InternalSaveMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "LoadMapWithUltraCompression", MemberParameters = new object[]
		{
			typeof(MemoryStream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "LoadMapVersion2", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public DeflateStream(Stream stream, CompressionMode mode)
		{
			throw null;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000057D9 File Offset: 0x000039D9
		[global::Cpp2ILInjected.Token(Token = "0x600033E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6CD90", Offset = "0x1A6CD90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
			throw null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000057DC File Offset: 0x000039DC
		[global::Cpp2ILInjected.Token(Token = "0x600033F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6CD98", Offset = "0x1A6CD98", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NetMessage", Member = "CompressTileBlock", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(short),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NetMessage", Member = "DecompressTileBlock", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "GetExtractDecompressor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000057DF File Offset: 0x000039DF
		[global::Cpp2ILInjected.Token(Token = "0x6000340")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6CCD4", Offset = "0x1A6CCD4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "MaybeApplyCompression", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "CompressString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "CompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "UncompressString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "UncompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(ZlibStreamFlavor),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000323 RID: 803 RVA: 0x000057E2 File Offset: 0x000039E2
		// (set) Token: 0x06000324 RID: 804 RVA: 0x000057E5 File Offset: 0x000039E5
		[global::Cpp2ILInjected.Token(Token = "0x170000CB")]
		public virtual FlushType FlushMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000341")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6CEC4", Offset = "0x1A6CEC4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000342")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6CED0", Offset = "0x1A6CED0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000325 RID: 805 RVA: 0x000057E8 File Offset: 0x000039E8
		// (set) Token: 0x06000326 RID: 806 RVA: 0x000057EB File Offset: 0x000039EB
		[global::Cpp2ILInjected.Token(Token = "0x170000CC")]
		public int BufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000343")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6CF34", Offset = "0x1A6CF34", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000344")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6CF40", Offset = "0x1A6CF40", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "MaybeApplyCompression", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(long)
			}, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000057EE File Offset: 0x000039EE
		// (set) Token: 0x06000328 RID: 808 RVA: 0x000057F1 File Offset: 0x000039F1
		[global::Cpp2ILInjected.Token(Token = "0x170000CD")]
		public CompressionStrategy Strategy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000345")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D0E4", Offset = "0x1A6D0E4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000346")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D0F0", Offset = "0x1A6D0F0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "MaybeApplyCompression", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(long)
			}, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000057F4 File Offset: 0x000039F4
		[global::Cpp2ILInjected.Token(Token = "0x170000CE")]
		public virtual long TotalIn
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000347")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D154", Offset = "0x1A6D154", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000057F7 File Offset: 0x000039F7
		[global::Cpp2ILInjected.Token(Token = "0x170000CF")]
		public virtual long TotalOut
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000348")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D164", Offset = "0x1A6D164", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000057FA File Offset: 0x000039FA
		[global::Cpp2ILInjected.Token(Token = "0x6000349")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D174", Offset = "0x1A6D174", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000057FD File Offset: 0x000039FD
		[global::Cpp2ILInjected.Token(Token = "0x170000D0")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600034A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D240", Offset = "0x1A6D240", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00005800 File Offset: 0x00003A00
		[global::Cpp2ILInjected.Token(Token = "0x170000D1")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x600034B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D2AC", Offset = "0x1A6D2AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00005803 File Offset: 0x00003A03
		[global::Cpp2ILInjected.Token(Token = "0x170000D2")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600034C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D2B4", Offset = "0x1A6D2B4", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00005806 File Offset: 0x00003A06
		[global::Cpp2ILInjected.Token(Token = "0x600034D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D320", Offset = "0x1A6D320", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00005809 File Offset: 0x00003A09
		[global::Cpp2ILInjected.Token(Token = "0x170000D3")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600034E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D38C", Offset = "0x1A6D38C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000580C File Offset: 0x00003A0C
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0000580F File Offset: 0x00003A0F
		[global::Cpp2ILInjected.Token(Token = "0x170000D4")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600034F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D3C4", Offset = "0x1A6D3C4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000350")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6D3FC", Offset = "0x1A6D3FC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00005812 File Offset: 0x00003A12
		[global::Cpp2ILInjected.Token(Token = "0x6000351")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D434", Offset = "0x1A6D434", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00005815 File Offset: 0x00003A15
		[global::Cpp2ILInjected.Token(Token = "0x6000352")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D4A0", Offset = "0x1A6D4A0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00005818 File Offset: 0x00003A18
		[global::Cpp2ILInjected.Token(Token = "0x6000353")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D4D8", Offset = "0x1A6D4D8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000581B File Offset: 0x00003A1B
		[global::Cpp2ILInjected.Token(Token = "0x6000354")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D510", Offset = "0x1A6D510", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000581E File Offset: 0x00003A1E
		[global::Cpp2ILInjected.Token(Token = "0x6000355")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D57C", Offset = "0x1A6D57C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "CompressString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static byte[] CompressString(string s)
		{
			throw null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00005821 File Offset: 0x00003A21
		[global::Cpp2ILInjected.Token(Token = "0x6000356")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D8F0", Offset = "0x1A6D8F0", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "CompressBuffer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static byte[] CompressBuffer(byte[] b)
		{
			throw null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00005824 File Offset: 0x00003A24
		[global::Cpp2ILInjected.Token(Token = "0x6000357")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6DC48", Offset = "0x1A6DC48", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "UncompressString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Stream)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static string UncompressString(byte[] compressed)
		{
			throw null;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00005827 File Offset: 0x00003A27
		[global::Cpp2ILInjected.Token(Token = "0x6000358")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6E1B4", Offset = "0x1A6E1B4", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "UncompressBuffer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Stream)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			throw null;
		}

		// Token: 0x040001DA RID: 474
		[global::Cpp2ILInjected.Token(Token = "0x400022C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal ZlibBaseStream _baseStream;

		// Token: 0x040001DB RID: 475
		[global::Cpp2ILInjected.Token(Token = "0x400022D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal Stream _innerStream;

		// Token: 0x040001DC RID: 476
		[global::Cpp2ILInjected.Token(Token = "0x400022E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool _disposed;
	}
}