﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000113 RID: 275
	[global::Cpp2ILInjected.Token(Token = "0x2000136")]
	public static class LightmapperUtils
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x00002D22 File Offset: 0x00000F22
		[global::Cpp2ILInjected.Token(Token = "0x60005F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D9B8", Offset = "0x1F8D9B8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static LightMode Extract(LightmapBakeType baketype)
		{
			throw null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002D25 File Offset: 0x00000F25
		[global::Cpp2ILInjected.Token(Token = "0x60005F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D9D8", Offset = "0x1F8D9D8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DirectionalLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref PointLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref SpotLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref RectangleLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DiscLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_intensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_bounceIntensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(LinearColor))]
		public static LinearColor ExtractIndirect(Light l)
		{
			throw null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002D28 File Offset: 0x00000F28
		[global::Cpp2ILInjected.Token(Token = "0x60005F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8DA48", Offset = "0x1F8DA48", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref SpotLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_spotAngle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float ExtractInnerCone(Light l)
		{
			throw null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002D2B File Offset: 0x00000F2B
		[global::Cpp2ILInjected.Token(Token = "0x60005F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8DA94", Offset = "0x1F8DA94", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DirectionalLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref PointLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref SpotLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref RectangleLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DiscLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_useColorTemperature", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_colorTemperature", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mathf), Member = "CorrelatedColorTemperatureToRGB", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static Color ExtractColorTemperature(Light l)
		{
			throw null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002D2E File Offset: 0x00000F2E
		[global::Cpp2ILInjected.Token(Token = "0x60005F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8DB20", Offset = "0x1F8DB20", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DirectionalLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref PointLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref SpotLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref RectangleLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DiscLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinearColor), Member = "set_red", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinearColor), Member = "set_green", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinearColor), Member = "set_blue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor)
		{
			throw null;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002D31 File Offset: 0x00000F31
		[global::Cpp2ILInjected.Token(Token = "0x60005FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8DB68", Offset = "0x1F8DB68", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c", Member = "<.cctor>b__7_0", MemberParameters = new object[]
		{
			typeof(Light[]),
			typeof(NativeArray<LightDataGI>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_intensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(ref LinearColor)
		}, ReturnType = typeof(void))]
		public static void Extract(Light l, ref DirectionalLight dir)
		{
			throw null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002D34 File Offset: 0x00000F34
		[global::Cpp2ILInjected.Token(Token = "0x60005FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8DCE0", Offset = "0x1F8DCE0", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c", Member = "<.cctor>b__7_0", MemberParameters = new object[]
		{
			typeof(Light[]),
			typeof(NativeArray<LightDataGI>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_intensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(ref LinearColor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_range", ReturnType = typeof(float))]
		public static void Extract(Light l, ref PointLight point)
		{
			throw null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002D37 File Offset: 0x00000F37
		[global::Cpp2ILInjected.Token(Token = "0x60005FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8DE70", Offset = "0x1F8DE70", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c", Member = "<.cctor>b__7_0", MemberParameters = new object[]
		{
			typeof(Light[]),
			typeof(NativeArray<LightDataGI>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_intensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(ref LinearColor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_range", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_spotAngle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractInnerCone", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(float))]
		public static void Extract(Light l, ref SpotLight spot)
		{
			throw null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002D3A File Offset: 0x00000F3A
		[global::Cpp2ILInjected.Token(Token = "0x60005FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8E028", Offset = "0x1F8E028", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c", Member = "<.cctor>b__7_0", MemberParameters = new object[]
		{
			typeof(Light[]),
			typeof(NativeArray<LightDataGI>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_intensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(ref LinearColor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_range", ReturnType = typeof(float))]
		public static void Extract(Light l, ref RectangleLight rect)
		{
			throw null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002D3D File Offset: 0x00000F3D
		[global::Cpp2ILInjected.Token(Token = "0x60005FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8E1B8", Offset = "0x1F8E1B8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c", Member = "<.cctor>b__7_0", MemberParameters = new object[]
		{
			typeof(Light[]),
			typeof(NativeArray<LightDataGI>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_intensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(ref LinearColor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_range", ReturnType = typeof(float))]
		public static void Extract(Light l, ref DiscLight disc)
		{
			throw null;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002D40 File Offset: 0x00000F40
		[global::Cpp2ILInjected.Token(Token = "0x60005FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8E348", Offset = "0x1F8E348", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c", Member = "<.cctor>b__7_0", MemberParameters = new object[]
		{
			typeof(Light[]),
			typeof(NativeArray<LightDataGI>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_cookie", ReturnType = typeof(Texture))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_type", ReturnType = typeof(LightType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_cookieSize", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Extract(Light l, out Cookie cookie)
		{
			throw null;
		}
	}
}
