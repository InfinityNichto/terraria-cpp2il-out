﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006E2 RID: 1762
	[global::Cpp2ILInjected.Token(Token = "0x2000ACB")]
	public class UISearchBar : UIElement
	{
		// Token: 0x1400005A RID: 90
		// (add) Token: 0x060044D9 RID: 17625 RVA: 0x0002E526 File Offset: 0x0002C726
		// (remove) Token: 0x060044DA RID: 17626 RVA: 0x0002E529 File Offset: 0x0002C729
		[global::Cpp2ILInjected.Token(Token = "0x14000060")]
		public event Action<string> OnContentsChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600513C")]
			[global::Cpp2ILInjected.Address(RVA = "0x92DC98", Offset = "0x92DC98", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
			{
				typeof(UIElement),
				typeof(UIBestiaryEntryInfoPage)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600513D")]
			[global::Cpp2ILInjected.Address(RVA = "0x92DD4C", Offset = "0x92DD4C", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x060044DB RID: 17627 RVA: 0x0002E52C File Offset: 0x0002C72C
		// (remove) Token: 0x060044DC RID: 17628 RVA: 0x0002E52F File Offset: 0x0002C72F
		[global::Cpp2ILInjected.Token(Token = "0x14000061")]
		public event Action OnStartTakingInput
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600513E")]
			[global::Cpp2ILInjected.Address(RVA = "0x92DE00", Offset = "0x92DE00", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
			{
				typeof(UIElement),
				typeof(UIBestiaryEntryInfoPage)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600513F")]
			[global::Cpp2ILInjected.Address(RVA = "0x92DEA0", Offset = "0x92DEA0", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x060044DD RID: 17629 RVA: 0x0002E532 File Offset: 0x0002C732
		// (remove) Token: 0x060044DE RID: 17630 RVA: 0x0002E535 File Offset: 0x0002C735
		[global::Cpp2ILInjected.Token(Token = "0x14000062")]
		public event Action OnEndTakingInput
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005140")]
			[global::Cpp2ILInjected.Address(RVA = "0x92DF40", Offset = "0x92DF40", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
			{
				typeof(UIElement),
				typeof(UIBestiaryEntryInfoPage)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005141")]
			[global::Cpp2ILInjected.Address(RVA = "0x92DFE0", Offset = "0x92DFE0", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x060044DF RID: 17631 RVA: 0x0002E538 File Offset: 0x0002C738
		// (remove) Token: 0x060044E0 RID: 17632 RVA: 0x0002E53B File Offset: 0x0002C73B
		[global::Cpp2ILInjected.Token(Token = "0x14000063")]
		public event Action OnCanceledTakingInput
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005142")]
			[global::Cpp2ILInjected.Address(RVA = "0x92E080", Offset = "0x92E080", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005143")]
			[global::Cpp2ILInjected.Address(RVA = "0x92E120", Offset = "0x92E120", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x060044E1 RID: 17633 RVA: 0x0002E53E File Offset: 0x0002C73E
		// (remove) Token: 0x060044E2 RID: 17634 RVA: 0x0002E541 File Offset: 0x0002C741
		[global::Cpp2ILInjected.Token(Token = "0x14000064")]
		public event Action OnNeedingVirtualKeyboard
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005144")]
			[global::Cpp2ILInjected.Address(RVA = "0x92E1C0", Offset = "0x92E1C0", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
			{
				typeof(UIElement),
				typeof(UIBestiaryEntryInfoPage)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005145")]
			[global::Cpp2ILInjected.Address(RVA = "0x92E260", Offset = "0x92E260", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x0002E544 File Offset: 0x0002C744
		[global::Cpp2ILInjected.Token(Token = "0x170008CB")]
		public bool HasContents
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005146")]
			[global::Cpp2ILInjected.Address(RVA = "0x92E300", Offset = "0x92E300", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "searchCancelButton_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "searchCancelButton_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x0002E547 File Offset: 0x0002C747
		[global::Cpp2ILInjected.Token(Token = "0x170008CC")]
		public bool IsWritingText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005147")]
			[global::Cpp2ILInjected.Address(RVA = "0x92E320", Offset = "0x92E320", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x0002E54A File Offset: 0x0002C74A
		[global::Cpp2ILInjected.Token(Token = "0x6005148")]
		[global::Cpp2ILInjected.Address(RVA = "0x92E328", Offset = "0x92E328", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public UISearchBar(LocalizedText emptyContentText, float scale)
		{
			throw null;
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x0002E54D File Offset: 0x0002C74D
		[global::Cpp2ILInjected.Token(Token = "0x6005149")]
		[global::Cpp2ILInjected.Address(RVA = "0x92E524", Offset = "0x92E524", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "searchCancelButton_OnClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "OnFinishedSettingName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "searchCancelButton_OnClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "OnFinishedSettingName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "SetText", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "TrimDisplayIfOverElementDimensions", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void SetContents(string contents, bool forced = false)
		{
			throw null;
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x0002E550 File Offset: 0x0002C750
		[global::Cpp2ILInjected.Token(Token = "0x600514A")]
		[global::Cpp2ILInjected.Address(RVA = "0x92E684", Offset = "0x92E684", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "SetText", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void TrimDisplayIfOverElementDimensions(int padding)
		{
			throw null;
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x0002E553 File Offset: 0x0002C753
		[global::Cpp2ILInjected.Token(Token = "0x600514B")]
		[global::Cpp2ILInjected.Address(RVA = "0x92E9A8", Offset = "0x92E9A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x0002E556 File Offset: 0x0002C756
		[global::Cpp2ILInjected.Token(Token = "0x600514C")]
		[global::Cpp2ILInjected.Address(RVA = "0x92E9B0", Offset = "0x92E9B0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x0002E559 File Offset: 0x0002C759
		[global::Cpp2ILInjected.Token(Token = "0x600514D")]
		[global::Cpp2ILInjected.Address(RVA = "0x92E9E0", Offset = "0x92E9E0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.SettingsForUI), Member = "get_ShowGamepadHints", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x0002E55C File Offset: 0x0002C75C
		[global::Cpp2ILInjected.Token(Token = "0x600514E")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EAD0", Offset = "0x92EAD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.SettingsForUI), Member = "get_ShowGamepadHints", ReturnType = typeof(bool))]
		private bool NeedsVirtualkeyboard()
		{
			throw null;
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x0002E55F File Offset: 0x0002C75F
		[global::Cpp2ILInjected.Token(Token = "0x600514F")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EAD8", Offset = "0x92EAD8", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Rectangle),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "ToggleTakingText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x0002E562 File Offset: 0x0002C762
		[global::Cpp2ILInjected.Token(Token = "0x6005150")]
		[global::Cpp2ILInjected.Address(RVA = "0x92ED08", Offset = "0x92ED08", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "GoBackHere", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Click_SearchArea", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "Click_SearchArea", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "EscapeVirtualKeyboard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "GoBackHere", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "clrInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void ToggleTakingText()
		{
			throw null;
		}

		// Token: 0x0400708E RID: 28814
		[global::Cpp2ILInjected.Token(Token = "0x40089DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private readonly LocalizedText _textToShowWhenEmpty;

		// Token: 0x0400708F RID: 28815
		[global::Cpp2ILInjected.Token(Token = "0x40089DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private UITextBox _text;

		// Token: 0x04007090 RID: 28816
		[global::Cpp2ILInjected.Token(Token = "0x40089DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private string actualContents;

		// Token: 0x04007091 RID: 28817
		[global::Cpp2ILInjected.Token(Token = "0x40089DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private float _textScale;

		// Token: 0x04007092 RID: 28818
		[global::Cpp2ILInjected.Token(Token = "0x40089DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
		private bool isWritingText;

		// Token: 0x04007093 RID: 28819
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private Action<string> OnContentsChanged;

		// Token: 0x04007094 RID: 28820
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private Action OnStartTakingInput;

		// Token: 0x04007095 RID: 28821
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private Action OnEndTakingInput;

		// Token: 0x04007096 RID: 28822
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private Action OnCanceledTakingInput;

		// Token: 0x04007097 RID: 28823
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private Action OnNeedingVirtualKeyboard;
	}
}