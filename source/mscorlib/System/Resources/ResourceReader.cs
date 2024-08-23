﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003FA RID: 1018
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20004B7")]
	public sealed class ResourceReader : IResourceReader, global::System.Collections.IEnumerable, global::System.IDisposable
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x0001A05D File Offset: 0x0001825D
		[global::Cpp2ILInjected.Token(Token = "0x600232B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76128", Offset = "0x1B76128", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.BinaryReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal ResourceReader(global::System.IO.Stream stream, global::System.Collections.Generic.Dictionary<string, ResourceLocator> resCache)
		{
			throw null;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0001A060 File Offset: 0x00018260
		[global::Cpp2ILInjected.Token(Token = "0x600232C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76440", Offset = "0x1B76440", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x0001A063 File Offset: 0x00018263
		[global::Cpp2ILInjected.Token(Token = "0x600232D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7CF20", Offset = "0x1B7CF20", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0001A066 File Offset: 0x00018266
		[global::Cpp2ILInjected.Token(Token = "0x600232E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7CEE0", Offset = "0x1B7CEE0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x0001A069 File Offset: 0x00018269
		[global::Cpp2ILInjected.Token(Token = "0x600232F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7CF5C", Offset = "0x1B7CF5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static int ReadUnalignedI4(int* p)
		{
			throw null;
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0001A06C File Offset: 0x0001826C
		[global::Cpp2ILInjected.Token(Token = "0x6002330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7CF64", Offset = "0x1B7CF64", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "GetValueForNameIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.BinaryReader), Member = "Read7BitEncodedInt", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void SkipString()
		{
			throw null;
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x0001A06F File Offset: 0x0001826F
		[global::Cpp2ILInjected.Token(Token = "0x6002331")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7D004", Offset = "0x1B7D004", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "FindPosForResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		private int GetNameHash(int index)
		{
			throw null;
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0001A072 File Offset: 0x00018272
		[global::Cpp2ILInjected.Token(Token = "0x6002332")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7D028", Offset = "0x1B7D028", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "FindPosForResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "GetValueForNameIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private int GetNamePosition(int index)
		{
			throw null;
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0001A075 File Offset: 0x00018275
		[global::Cpp2ILInjected.Token(Token = "0x6002333")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7D114", Offset = "0x1B7D114", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0001A078 File Offset: 0x00018278
		[global::Cpp2ILInjected.Token(Token = "0x6002334")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7D118", Offset = "0x1B7D118", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public global::System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0001A07B File Offset: 0x0001827B
		[global::Cpp2ILInjected.Token(Token = "0x6002335")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77620", Offset = "0x1B77620", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ResourceReader.ResourceEnumerator GetEnumeratorInternal()
		{
			throw null;
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0001A07E File Offset: 0x0001827E
		[global::Cpp2ILInjected.Token(Token = "0x6002336")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76FA0", Offset = "0x1B76FA0", Length = "0x374")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastResourceComparer), Member = "HashFunction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "GetNameHash", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "GetNamePosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal int FindPosForResource(string name)
		{
			throw null;
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0001A081 File Offset: 0x00018281
		[global::Cpp2ILInjected.Token(Token = "0x6002337")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7D20C", Offset = "0x1B7D20C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "FindPosForResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.BinaryReader), Member = "Read7BitEncodedInt", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "get_PositionPointer", ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastResourceComparer), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastResourceComparer), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private unsafe bool CompareStringEqualsName(string name)
		{
			throw null;
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0001A084 File Offset: 0x00018284
		[global::Cpp2ILInjected.Token(Token = "0x6002338")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7D3F4", Offset = "0x1B7D3F4", Length = "0x77C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader.ResourceEnumerator), Member = "get_Key", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader.ResourceEnumerator), Member = "get_Entry", ReturnType = typeof(global::System.Collections.DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "GetNamePosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.BinaryReader), Member = "Read7BitEncodedInt", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "get_PositionPointer", ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_Unicode", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.EndOfStreamException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 64)]
		private unsafe string AllocateStringForNameIndex(int index, out int dataOffset)
		{
			throw null;
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0001A087 File Offset: 0x00018287
		[global::Cpp2ILInjected.Token(Token = "0x6002339")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7DB70", Offset = "0x1B7DB70", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader.ResourceEnumerator), Member = "get_Entry", ReturnType = typeof(global::System.Collections.DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader.ResourceEnumerator), Member = "get_Value", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "GetNamePosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "SkipString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private object GetValueForNameIndex(int index)
		{
			throw null;
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0001A08A File Offset: 0x0001828A
		[global::Cpp2ILInjected.Token(Token = "0x600233A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77314", Offset = "0x1B77314", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.BinaryReader), Member = "Read7BitEncodedInt", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "FindType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal string LoadString(int pos)
		{
			throw null;
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0001A08D File Offset: 0x0001828D
		[global::Cpp2ILInjected.Token(Token = "0x600233B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7E2CC", Offset = "0x1B7E2CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader.ResourceEnumerator), Member = "get_Entry", ReturnType = typeof(global::System.Collections.DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		internal object LoadObject(int pos)
		{
			throw null;
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0001A090 File Offset: 0x00018290
		[global::Cpp2ILInjected.Token(Token = "0x600233C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77570", Offset = "0x1B77570", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "ResolveResourceLocator", MemberParameters = new object[]
		{
			typeof(ResourceLocator),
			typeof(string),
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceLocator>),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal object LoadObject(int pos, out ResourceTypeCode typeCode)
		{
			throw null;
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0001A093 File Offset: 0x00018293
		[global::Cpp2ILInjected.Token(Token = "0x600233D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7DDC0", Offset = "0x1B7DDC0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "GetValueForNameIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "LoadObject", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "LoadObject", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "_LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal object LoadObjectV1(int pos)
		{
			throw null;
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x0001A096 File Offset: 0x00018296
		[global::Cpp2ILInjected.Token(Token = "0x600233E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7E2F8", Offset = "0x1B7E2F8", Length = "0x7E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.BinaryReader), Member = "Read7BitEncodedInt", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "FindType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "DeserializeObject", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		private object _LoadObjectV1(int pos)
		{
			throw null;
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0001A099 File Offset: 0x00018299
		[global::Cpp2ILInjected.Token(Token = "0x600233F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7DEB8", Offset = "0x1B7DEB8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "GetValueForNameIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "LoadObject", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "LoadObject", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			throw null;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0001A09C File Offset: 0x0001829C
		[global::Cpp2ILInjected.Token(Token = "0x6002340")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7EC5C", Offset = "0x1B7EC5C", Length = "0x6A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.BinaryReader), Member = "Read7BitEncodedInt", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "DeserializeObject", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "FromBinary", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "get_PositionPointer", ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long),
			typeof(long),
			typeof(global::System.IO.FileAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.PinnedBufferMemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private unsafe object _LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			throw null;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0001A09F File Offset: 0x0001829F
		[global::Cpp2ILInjected.Token(Token = "0x6002341")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7EAD8", Offset = "0x1B7EAD8", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "FindType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "Deserialize", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private object DeserializeObject(int typeIndex)
		{
			throw null;
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0001A0A2 File Offset: 0x000182A2
		[global::Cpp2ILInjected.Token(Token = "0x6002342")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7CD7C", Offset = "0x1B7CD7C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceLocator>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.StreamingContext), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContextStates) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.ISurrogateSelector),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void ReadResources()
		{
			throw null;
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0001A0A5 File Offset: 0x000182A5
		[global::Cpp2ILInjected.Token(Token = "0x6002343")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7F2FC", Offset = "0x1B7F2FC", Length = "0x5FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = "CompareNames", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Reflection.AssemblyName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "SkipString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "get_PositionPointer", ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private unsafe void _ReadResources()
		{
			throw null;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0001A0A8 File Offset: 0x000182A8
		[global::Cpp2ILInjected.Token(Token = "0x6002344")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7DFB0", Offset = "0x1B7DFB0", Length = "0x31C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "LoadString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "DeserializeObject", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BadImageFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private global::System.RuntimeType FindType(int typeIndex)
		{
			throw null;
		}

		// Token: 0x04001029 RID: 4137
		[global::Cpp2ILInjected.Token(Token = "0x400133F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.IO.BinaryReader _store;

		// Token: 0x0400102A RID: 4138
		[global::Cpp2ILInjected.Token(Token = "0x4001340")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.Collections.Generic.Dictionary<string, ResourceLocator> _resCache;

		// Token: 0x0400102B RID: 4139
		[global::Cpp2ILInjected.Token(Token = "0x4001341")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private long _nameSectionOffset;

		// Token: 0x0400102C RID: 4140
		[global::Cpp2ILInjected.Token(Token = "0x4001342")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private long _dataSectionOffset;

		// Token: 0x0400102D RID: 4141
		[global::Cpp2ILInjected.Token(Token = "0x4001343")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int[] _nameHashes;

		// Token: 0x0400102E RID: 4142
		[global::Cpp2ILInjected.Token(Token = "0x4001344")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private unsafe int* _nameHashesPtr;

		// Token: 0x0400102F RID: 4143
		[global::Cpp2ILInjected.Token(Token = "0x4001345")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int[] _namePositions;

		// Token: 0x04001030 RID: 4144
		[global::Cpp2ILInjected.Token(Token = "0x4001346")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private unsafe int* _namePositionsPtr;

		// Token: 0x04001031 RID: 4145
		[global::Cpp2ILInjected.Token(Token = "0x4001347")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.RuntimeType[] _typeTable;

		// Token: 0x04001032 RID: 4146
		[global::Cpp2ILInjected.Token(Token = "0x4001348")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int[] _typeNamePositions;

		// Token: 0x04001033 RID: 4147
		[global::Cpp2ILInjected.Token(Token = "0x4001349")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _objFormatter;

		// Token: 0x04001034 RID: 4148
		[global::Cpp2ILInjected.Token(Token = "0x400134A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int _numResources;

		// Token: 0x04001035 RID: 4149
		[global::Cpp2ILInjected.Token(Token = "0x400134B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.IO.UnmanagedMemoryStream _ums;

		// Token: 0x04001036 RID: 4150
		[global::Cpp2ILInjected.Token(Token = "0x400134C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int _version;

		// Token: 0x02000608 RID: 1544
		[global::Cpp2ILInjected.Token(Token = "0x20004B8")]
		internal sealed class ResourceEnumerator : global::System.Collections.IDictionaryEnumerator, global::System.Collections.IEnumerator
		{
			// Token: 0x06004167 RID: 16743 RVA: 0x0001FECB File Offset: 0x0001E0CB
			[global::Cpp2ILInjected.Token(Token = "0x6002345")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7D1D8", Offset = "0x1B7D1D8", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal ResourceEnumerator(ResourceReader reader)
			{
				throw null;
			}

			// Token: 0x06004168 RID: 16744 RVA: 0x0001FECE File Offset: 0x0001E0CE
			[global::Cpp2ILInjected.Token(Token = "0x6002346")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B77730", Offset = "0x1B77730", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x06004169 RID: 16745 RVA: 0x0001FED1 File Offset: 0x0001E0D1
			[global::Cpp2ILInjected.Token(Token = "0x17000494")]
			public object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002347")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B77688", Offset = "0x1B77688", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
				{
					typeof(string),
					typeof(bool),
					typeof(bool)
				}, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new object[]
				{
					typeof(int),
					typeof(ref int)
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x0600416A RID: 16746 RVA: 0x0001FED4 File Offset: 0x0001E0D4
			[global::Cpp2ILInjected.Token(Token = "0x17000495")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002348")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B7F8F8", Offset = "0x1B7F8F8", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader.ResourceEnumerator), Member = "get_Entry", ReturnType = typeof(global::System.Collections.DictionaryEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x0600416B RID: 16747 RVA: 0x0001FED7 File Offset: 0x0001E0D7
			[global::Cpp2ILInjected.Token(Token = "0x17000496")]
			internal int DataPosition
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002349")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B7FC48", Offset = "0x1B7FC48", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x0600416C RID: 16748 RVA: 0x0001FEDA File Offset: 0x0001E0DA
			[global::Cpp2ILInjected.Token(Token = "0x17000497")]
			public global::System.Collections.DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x600234A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B7F95C", Offset = "0x1B7F95C", Length = "0x2EC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader.ResourceEnumerator), Member = "get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
				{
					typeof(object),
					typeof(ref bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new object[]
				{
					typeof(int),
					typeof(ref int)
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, ResourceLocator>), Member = "TryGetValue", MemberParameters = new object[]
				{
					typeof(object),
					typeof(ref ResourceLocator)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadObject", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "GetValueForNameIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x0600416D RID: 16749 RVA: 0x0001FEDD File Offset: 0x0001E0DD
			[global::Cpp2ILInjected.Token(Token = "0x17000498")]
			public object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x600234B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B7FC50", Offset = "0x1B7FC50", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "GetValueForNameIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600416E RID: 16750 RVA: 0x0001FEE0 File Offset: 0x0001E0E0
			[global::Cpp2ILInjected.Token(Token = "0x600234C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7FCF0", Offset = "0x1B7FCF0", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x0400199E RID: 6558
			[global::Cpp2ILInjected.Token(Token = "0x400134D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ResourceReader _reader;

			// Token: 0x0400199F RID: 6559
			[global::Cpp2ILInjected.Token(Token = "0x400134E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private bool _currentIsValid;

			// Token: 0x040019A0 RID: 6560
			[global::Cpp2ILInjected.Token(Token = "0x400134F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _currentName;

			// Token: 0x040019A1 RID: 6561
			[global::Cpp2ILInjected.Token(Token = "0x4001350")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _dataPosition;
		}
	}
}