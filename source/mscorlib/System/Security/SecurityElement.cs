﻿using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;
using Mono.Xml;

namespace System.Security
{
	// Token: 0x02000208 RID: 520
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200029A")]
	[global::System.Serializable]
	public sealed class SecurityElement
	{
		// Token: 0x06001501 RID: 5377 RVA: 0x00018002 File Offset: 0x00016202
		[global::Cpp2ILInjected.Token(Token = "0x6001700")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA6F4", Offset = "0x1AEA6F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SecurityParser), Member = "OnStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "ToXml", MemberParameters = new object[]
		{
			typeof(SecurityElement),
			typeof(string),
			typeof(global::System.Collections.IEnumerator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public SecurityElement(string tag)
		{
			throw null;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00018005 File Offset: 0x00016205
		[global::Cpp2ILInjected.Token(Token = "0x6001701")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC958", Offset = "0x1AEC958", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CodeAccessPermission), Member = "Element", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PermissionSet), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "IsValidTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public SecurityElement(string tag, string text)
		{
			throw null;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x00018008 File Offset: 0x00016208
		[global::Cpp2ILInjected.Token(Token = "0x17000251")]
		public global::System.Collections.Hashtable Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001702")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AECC0C", Offset = "0x1AECC0C", Length = "0x328")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.ReflectionPermission), Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0001800B File Offset: 0x0001620B
		[global::Cpp2ILInjected.Token(Token = "0x17000252")]
		public global::System.Collections.ArrayList Children
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001703")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AECF34", Offset = "0x1AECF34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0001800E File Offset: 0x0001620E
		[global::Cpp2ILInjected.Token(Token = "0x17000253")]
		public string Tag
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001704")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AECF3C", Offset = "0x1AECF3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000202 RID: 514
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x00018011 File Offset: 0x00016211
		[global::Cpp2ILInjected.Token(Token = "0x17000254")]
		public string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001705")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AECB18", Offset = "0x1AECB18", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SecurityParser), Member = "OnChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "IsValidText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Unescape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00018014 File Offset: 0x00016214
		[global::Cpp2ILInjected.Token(Token = "0x6001706")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA6FC", Offset = "0x1AEA6FC", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SecurityParser), Member = "OnStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CodeAccessPermission), Member = "Element", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamedPermissionSet), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PermissionSet), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.ReflectionPermission), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.SecurityPermission), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "ToXml", MemberParameters = new object[]
		{
			typeof(SecurityElement),
			typeof(string),
			typeof(global::System.Collections.IEnumerator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "GetAttribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SecurityElement.SecurityAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement.SecurityAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void AddAttribute(string name, string value)
		{
			throw null;
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00018017 File Offset: 0x00016217
		[global::Cpp2ILInjected.Token(Token = "0x6001707")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA888", Offset = "0x1AEA888", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SecurityParser), Member = "OnStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PermissionSet), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "ToXml", MemberParameters = new object[]
		{
			typeof(SecurityElement),
			typeof(string),
			typeof(global::System.Collections.IEnumerator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void AddChild(SecurityElement child)
		{
			throw null;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0001801A File Offset: 0x0001621A
		[global::Cpp2ILInjected.Token(Token = "0x6001708")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB084", Offset = "0x1AEB084", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CodeAccessPermission), Member = "CheckSecurityElement", MemberParameters = new object[]
		{
			typeof(SecurityElement),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CodeAccessPermission), Member = "IsUnrestricted", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.SecurityPermission), Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "FromXml", MemberParameters = new object[]
		{
			typeof(global::System.Collections.ArrayList),
			"System.Net.NetworkAccess"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "GetAttribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SecurityElement.SecurityAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public string Attribute(string name)
		{
			throw null;
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0001801D File Offset: 0x0001621D
		[global::Cpp2ILInjected.Token(Token = "0x6001709")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AED5EC", Offset = "0x1AED5EC", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SecurityParser), Member = "OnStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SecurityParser), Member = "OnChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "ToXml", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static string Escape(string str)
		{
			throw null;
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00018020 File Offset: 0x00016220
		[global::Cpp2ILInjected.Token(Token = "0x600170A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AECFC0", Offset = "0x1AECFC0", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement.SecurityAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static string Unescape(string str)
		{
			throw null;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00018023 File Offset: 0x00016223
		[global::Cpp2ILInjected.Token(Token = "0x600170B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AED7D0", Offset = "0x1AED7D0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement.SecurityAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsValidAttributeName(string name)
		{
			throw null;
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00018026 File Offset: 0x00016226
		[global::Cpp2ILInjected.Token(Token = "0x600170C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AED84C", Offset = "0x1AED84C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement.SecurityAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsValidAttributeValue(string value)
		{
			throw null;
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00018029 File Offset: 0x00016229
		[global::Cpp2ILInjected.Token(Token = "0x600170D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AECA9C", Offset = "0x1AECA9C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsValidTag(string tag)
		{
			throw null;
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0001802C File Offset: 0x0001622C
		[global::Cpp2ILInjected.Token(Token = "0x600170E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AECF44", Offset = "0x1AECF44", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsValidText(string text)
		{
			throw null;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0001802F File Offset: 0x0001622F
		[global::Cpp2ILInjected.Token(Token = "0x600170F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AED8C8", Offset = "0x1AED8C8", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "FromXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public SecurityElement SearchForChildByTag(string tag)
		{
			throw null;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00018032 File Offset: 0x00016232
		[global::Cpp2ILInjected.Token(Token = "0x6001710")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AED9F8", Offset = "0x1AED9F8", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "SearchForTextOfTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.SignatureDescription), Member = ".ctor", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "SearchForTextOfTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public string SearchForTextOfTag(string tag)
		{
			throw null;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00018035 File Offset: 0x00016235
		[global::Cpp2ILInjected.Token(Token = "0x6001711")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEDB30", Offset = "0x1AEDB30", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "ToXml", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00018038 File Offset: 0x00016238
		[global::Cpp2ILInjected.Token(Token = "0x6001712")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEDBAC", Offset = "0x1AEDBAC", Length = "0x600")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "ToXml", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "ToXml", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private void ToXml(ref global::System.Text.StringBuilder s, int level)
		{
			throw null;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0001803B File Offset: 0x0001623B
		[global::Cpp2ILInjected.Token(Token = "0x6001713")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AED194", Offset = "0x1AED194", Length = "0x2FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "Attribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal SecurityElement.SecurityAttribute GetAttribute(string name)
		{
			throw null;
		}

		// Token: 0x17000203 RID: 515
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x0001803E File Offset: 0x0001623E
		[global::Cpp2ILInjected.Token(Token = "0x17000255")]
		internal string m_strText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001714")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AEE1AC", Offset = "0x1AEE1AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00018041 File Offset: 0x00016241
		[global::Cpp2ILInjected.Token(Token = "0x6001715")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEE1B4", Offset = "0x1AEE1B4", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSA), Member = "FromXmlString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "FromXmlString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Unescape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal string SearchForTextOfLocalName(string strLocalName)
		{
			throw null;
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00018044 File Offset: 0x00016244
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001716")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEE3E0", Offset = "0x1AEE3E0", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static SecurityElement()
		{
			throw null;
		}

		// Token: 0x04000913 RID: 2323
		[global::Cpp2ILInjected.Token(Token = "0x4000BA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string text;

		// Token: 0x04000914 RID: 2324
		[global::Cpp2ILInjected.Token(Token = "0x4000BA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string tag;

		// Token: 0x04000915 RID: 2325
		[global::Cpp2ILInjected.Token(Token = "0x4000BA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.ArrayList attributes;

		// Token: 0x04000916 RID: 2326
		[global::Cpp2ILInjected.Token(Token = "0x4000BA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Collections.ArrayList children;

		// Token: 0x04000917 RID: 2327
		[global::Cpp2ILInjected.Token(Token = "0x4000BAA")]
		private static readonly char[] invalid_tag_chars;

		// Token: 0x04000918 RID: 2328
		[global::Cpp2ILInjected.Token(Token = "0x4000BAB")]
		private static readonly char[] invalid_text_chars;

		// Token: 0x04000919 RID: 2329
		[global::Cpp2ILInjected.Token(Token = "0x4000BAC")]
		private static readonly char[] invalid_attr_name_chars;

		// Token: 0x0400091A RID: 2330
		[global::Cpp2ILInjected.Token(Token = "0x4000BAD")]
		private static readonly char[] invalid_attr_value_chars;

		// Token: 0x0400091B RID: 2331
		[global::Cpp2ILInjected.Token(Token = "0x4000BAE")]
		private static readonly char[] invalid_chars;

		// Token: 0x020005DD RID: 1501
		[global::Cpp2ILInjected.Token(Token = "0x200029B")]
		internal class SecurityAttribute
		{
			// Token: 0x060040D6 RID: 16598 RVA: 0x0001FD33 File Offset: 0x0001DF33
			[global::Cpp2ILInjected.Token(Token = "0x6001717")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AED490", Offset = "0x1AED490", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "IsValidAttributeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "IsValidAttributeValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Unescape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public SecurityAttribute(string name, string value)
			{
				throw null;
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x060040D7 RID: 16599 RVA: 0x0001FD36 File Offset: 0x0001DF36
			[global::Cpp2ILInjected.Token(Token = "0x17000256")]
			public string Name
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001718")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AEE540", Offset = "0x1AEE540", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x060040D8 RID: 16600 RVA: 0x0001FD39 File Offset: 0x0001DF39
			[global::Cpp2ILInjected.Token(Token = "0x17000257")]
			public string Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001719")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AEE548", Offset = "0x1AEE548", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400191B RID: 6427
			[global::Cpp2ILInjected.Token(Token = "0x4000BAF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string _name;

			// Token: 0x0400191C RID: 6428
			[global::Cpp2ILInjected.Token(Token = "0x4000BB0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string _value;
		}
	}
}
