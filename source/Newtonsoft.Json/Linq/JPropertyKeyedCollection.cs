﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200008F RID: 143
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000BA")]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		// Token: 0x06000658 RID: 1624 RVA: 0x00003317 File Offset: 0x00001517
		[global::Cpp2ILInjected.Token(Token = "0x60006CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D033A8", Offset = "0x1D033A8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IList`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public JPropertyKeyedCollection()
		{
			throw null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000331A File Offset: 0x0000151A
		[global::Cpp2ILInjected.Token(Token = "0x60006D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03438", Offset = "0x1D03438", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "ChangeItemKey", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void AddKey(string key, JToken item)
		{
			throw null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0000331D File Offset: 0x0000151D
		[global::Cpp2ILInjected.Token(Token = "0x60006D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03550", Offset = "0x1D03550", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "ContainsItem", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "GetKeyForItem", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "AddKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "RemoveKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected void ChangeItemKey(JToken item, string newKey)
		{
			throw null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00003320 File Offset: 0x00001520
		[global::Cpp2ILInjected.Token(Token = "0x60006D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03838", Offset = "0x1D03838", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "ClearItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void ClearItems()
		{
			throw null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00003323 File Offset: 0x00001523
		[global::Cpp2ILInjected.Token(Token = "0x60006D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D038B0", Offset = "0x1D038B0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.ContainsKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool Contains(string key)
		{
			throw null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00003326 File Offset: 0x00001526
		[global::Cpp2ILInjected.Token(Token = "0x60006D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D036D8", Offset = "0x1D036D8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "ChangeItemKey", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "GetKeyForItem", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool ContainsItem(JToken item)
		{
			throw null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00003329 File Offset: 0x00001529
		[global::Cpp2ILInjected.Token(Token = "0x60006D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D034A0", Offset = "0x1D034A0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "AddKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "get_Keys", ReturnType = typeof(ICollection<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "get_Values", ReturnType = typeof(ICollection<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void EnsureDictionary()
		{
			throw null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000332C File Offset: 0x0000152C
		[global::Cpp2ILInjected.Token(Token = "0x60006D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0375C", Offset = "0x1D0375C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "ChangeItemKey", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "ContainsItem", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "RemoveItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string GetKeyForItem(JToken item)
		{
			throw null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000332F File Offset: 0x0000152F
		[global::Cpp2ILInjected.Token(Token = "0x60006D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0395C", Offset = "0x1D0395C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "GetKeyForItem", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "AddKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void InsertItem(int index, JToken item)
		{
			throw null;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00003332 File Offset: 0x00001532
		[global::Cpp2ILInjected.Token(Token = "0x60006D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D039D4", Offset = "0x1D039D4", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "Remove", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool Remove(string key)
		{
			throw null;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00003335 File Offset: 0x00001535
		[global::Cpp2ILInjected.Token(Token = "0x60006D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03AD0", Offset = "0x1D03AD0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "GetKeyForItem", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "RemoveKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "RemoveItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void RemoveItem(int index)
		{
			throw null;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00003338 File Offset: 0x00001538
		[global::Cpp2ILInjected.Token(Token = "0x60006DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D037D8", Offset = "0x1D037D8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "ChangeItemKey", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "RemoveItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void RemoveKey(string key)
		{
			throw null;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000333B File Offset: 0x0000153B
		[global::Cpp2ILInjected.Token(Token = "0x60006DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03BBC", Offset = "0x1D03BBC", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "GetKeyForItem", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "AddKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "RemoveKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void SetItem(int index, JToken item)
		{
			throw null;
		}

		// Token: 0x17000147 RID: 327
		[global::Cpp2ILInjected.Token(Token = "0x1700014F")]
		public JToken this[string key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D03DB8", Offset = "0x1D03DB8", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00003341 File Offset: 0x00001541
		[global::Cpp2ILInjected.Token(Token = "0x60006DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03E78", Offset = "0x1D03E78", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "Property", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryGetValue(string key, out JToken value)
		{
			throw null;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00003344 File Offset: 0x00001544
		[global::Cpp2ILInjected.Token(Token = "0x17000150")]
		public ICollection<string> Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D03EF0", Offset = "0x1D03EF0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys", ReturnType = typeof(ICollection<string>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00003347 File Offset: 0x00001547
		[global::Cpp2ILInjected.Token(Token = "0x17000151")]
		public ICollection<JToken> Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D03F40", Offset = "0x1D03F40", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0000334A File Offset: 0x0000154A
		[global::Cpp2ILInjected.Token(Token = "0x60006E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03F90", Offset = "0x1D03F90", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "IndexOfItem", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "IndexOfReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>", "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int IndexOfReference(JToken t)
		{
			throw null;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0000334D File Offset: 0x0000154D
		[global::Cpp2ILInjected.Token(Token = "0x60006E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04034", Offset = "0x1D04034", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "DeepEquals", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public bool Compare(JPropertyKeyedCollection other)
		{
			throw null;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00003350 File Offset: 0x00001550
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60006E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04364", Offset = "0x1D04364", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static JPropertyKeyedCollection()
		{
			throw null;
		}

		// Token: 0x0400027C RID: 636
		[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
		private static readonly IEqualityComparer<string> Comparer;

		// Token: 0x0400027D RID: 637
		[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<string, JToken> _dictionary;
	}
}
