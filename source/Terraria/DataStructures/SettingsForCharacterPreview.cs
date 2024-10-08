﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000671")]
	public class SettingsForCharacterPreview
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003722")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DA08", Offset = "0x141DA08", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "DrawPet", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Projectile),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SettingsForCharacterPreview.SelectionBasedSettings), Member = "ApplyTo", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void ApplyTo(Projectile proj, bool walking)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003723")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DB68", Offset = "0x141DB68", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = "SimpleLoop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SettingsForCharacterPreview))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SettingsForCharacterPreview), Member = "Modify", MemberParameters = new object[]
		{
			typeof(ref SettingsForCharacterPreview.SelectionBasedSettings),
			typeof(int?),
			typeof(int?),
			typeof(int?),
			typeof(bool?)
		}, ReturnType = typeof(void))]
		public SettingsForCharacterPreview WhenSelected(int? startFrame = null, int? frameCount = null, int? delayPerFrame = null, bool? bounceLoop = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003724")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DCD8", Offset = "0x141DCD8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = "SimpleLoop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SettingsForCharacterPreview))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SettingsForCharacterPreview), Member = "Modify", MemberParameters = new object[]
		{
			typeof(ref SettingsForCharacterPreview.SelectionBasedSettings),
			typeof(int?),
			typeof(int?),
			typeof(int?),
			typeof(bool?)
		}, ReturnType = typeof(void))]
		public SettingsForCharacterPreview WhenNotSelected(int? startFrame = null, int? frameCount = null, int? delayPerFrame = null, bool? bounceLoop = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003725")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DB88", Offset = "0x141DB88", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SettingsForCharacterPreview), Member = "WhenSelected", MemberParameters = new object[]
		{
			typeof(int?),
			typeof(int?),
			typeof(int?),
			typeof(bool?)
		}, ReturnType = typeof(SettingsForCharacterPreview))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SettingsForCharacterPreview), Member = "WhenNotSelected", MemberParameters = new object[]
		{
			typeof(int?),
			typeof(int?),
			typeof(int?),
			typeof(bool?)
		}, ReturnType = typeof(SettingsForCharacterPreview))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void Modify(ref SettingsForCharacterPreview.SelectionBasedSettings target, int? startFrame, int? frameCount, int? delayPerFrame, bool? bounceLoop)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003726")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DCF8", Offset = "0x141DCF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsForCharacterPreview WithOffset(Vector2 offset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003727")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DD00", Offset = "0x141DD00", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 64)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public SettingsForCharacterPreview WithOffset(float x, float y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003728")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DD34", Offset = "0x141DD34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
		public SettingsForCharacterPreview WithSpriteDirection(int spriteDirection)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003729")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DD3C", Offset = "0x141DD3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		public SettingsForCharacterPreview WithCode(SettingsForCharacterPreview.CustomAnimationCode customAnimation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600372A")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DD44", Offset = "0x141DD44", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = "SimpleLoop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SettingsForCharacterPreview))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SettingsForCharacterPreview()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400781C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector2 Offset;

		[global::Cpp2ILInjected.Token(Token = "0x400781D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public SettingsForCharacterPreview.SelectionBasedSettings Selected;

		[global::Cpp2ILInjected.Token(Token = "0x400781E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public SettingsForCharacterPreview.SelectionBasedSettings NotSelected;

		[global::Cpp2ILInjected.Token(Token = "0x400781F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int SpriteDirection;

		[global::Cpp2ILInjected.Token(Token = "0x4007820")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public SettingsForCharacterPreview.CustomAnimationCode CustomAnimation;

		[global::Cpp2ILInjected.Token(Token = "0x2000672")]
		public delegate void CustomAnimationCode(Projectile proj, bool walking);

		[global::Cpp2ILInjected.Token(Token = "0x2000673")]
		public struct SelectionBasedSettings
		{
			[global::Cpp2ILInjected.Token(Token = "0x600372F")]
			[global::Cpp2ILInjected.Address(RVA = "0x141DAF4", Offset = "0x141DAF4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SettingsForCharacterPreview), Member = "ApplyTo", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			public void ApplyTo(Projectile proj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007821")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int StartFrame;

			[global::Cpp2ILInjected.Token(Token = "0x4007822")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int FrameCount;

			[global::Cpp2ILInjected.Token(Token = "0x4007823")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int DelayPerFrame;

			[global::Cpp2ILInjected.Token(Token = "0x4007824")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public bool BounceLoop;
		}
	}
}
