﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002AB RID: 683
	[global::Cpp2ILInjected.Token(Token = "0x2000373")]
	public class GeometryBufferInstanceList
	{
		// Token: 0x0600159B RID: 5531 RVA: 0x00025B59 File Offset: 0x00023D59
		[global::Cpp2ILInjected.Token(Token = "0x6001704")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAED74", Offset = "0xAAED74", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance.PlayerBatchBuffers), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public GeometryBufferInstanceList(int vertexCount, string rootName = null, int forcedLayer = -1)
		{
			throw null;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00025B5C File Offset: 0x00023D5C
		[global::Cpp2ILInjected.Token(Token = "0x6001705")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAD210", Offset = "0xAAD210", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetBatchInstance", ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "SetupParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObjectExtensions), Member = "SetLayer", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public GeometryBufferInstance GetBatchInstance(int bufferOffest)
		{
			throw null;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00025B5F File Offset: 0x00023D5F
		[global::Cpp2ILInjected.Token(Token = "0x6001706")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAD614", Offset = "0xAAD614", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "SetupParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObjectExtensions), Member = "SetLayer", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "Clear", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "set_subMeshCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetVertexBufferParams", MemberParameters = new object[]
		{
			typeof(int),
			typeof(VertexAttributeDescriptor[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetIndexBufferParams", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IndexFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetSubMesh", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SubMeshDescriptor),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "set_bounds", MemberParameters = new object[] { typeof(Bounds) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public GeometryBufferInstance GetInstance(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, int bufferOffest)
		{
			throw null;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00025B62 File Offset: 0x00023D62
		[global::Cpp2ILInjected.Token(Token = "0x6001707")]
		[global::Cpp2ILInjected.Address(RVA = "0xAADB8C", Offset = "0xAADB8C", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(List<Vector2>),
			typeof(List<Vector4>),
			typeof(List<Color32>),
			typeof(List<int>)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "SetupParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObjectExtensions), Member = "SetLayer", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "Clear", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new object[] { typeof(List<Vector3>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector2>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector4>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new object[] { typeof(List<Color32>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new object[]
		{
			typeof(List<int>),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "set_bounds", MemberParameters = new object[] { typeof(Bounds) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public GeometryBufferInstance GetInstance(List<Vector3> positions, List<Vector2> uvs, List<Vector4> uv2s, List<Color32> colours, List<int> indices, int bufferOffest)
		{
			throw null;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00025B65 File Offset: 0x00023D65
		[global::Cpp2ILInjected.Token(Token = "0x6001708")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAEE28", Offset = "0xAAEE28", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "GetBatchInstance", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(List<Vector2>),
			typeof(List<Vector4>),
			typeof(List<Color32>),
			typeof(List<int>),
			typeof(int)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "SetOffset", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObjectExtensions), Member = "FindInChildren", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(string)
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_parent", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void SetupParent()
		{
			throw null;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00025B68 File Offset: 0x00023D68
		[global::Cpp2ILInjected.Token(Token = "0x6001709")]
		[global::Cpp2ILInjected.Address(RVA = "0xAACFF0", Offset = "0xAACFF0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "EndBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "SetupParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetOffset(Vector2 offset)
		{
			throw null;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00025B6B File Offset: 0x00023D6B
		[global::Cpp2ILInjected.Token(Token = "0x600170A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAACF58", Offset = "0xAACF58", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "EndBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "FinaliseInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void FinaliseInstances()
		{
			throw null;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00025B6E File Offset: 0x00023D6E
		[global::Cpp2ILInjected.Token(Token = "0x600170B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAABD20", Offset = "0xAABD20", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearBuffers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void ClearInstances()
		{
			throw null;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00025B71 File Offset: 0x00023D71
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600170C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAF038", Offset = "0xAAF038", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexAttributeDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static GeometryBufferInstanceList()
		{
			throw null;
		}

		// Token: 0x04001F64 RID: 8036
		[global::Cpp2ILInjected.Token(Token = "0x400259D")]
		private static GameObject _root;

		// Token: 0x04001F65 RID: 8037
		[global::Cpp2ILInjected.Token(Token = "0x400259E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _rootName;

		// Token: 0x04001F66 RID: 8038
		[global::Cpp2ILInjected.Token(Token = "0x400259F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private GameObject _parent;

		// Token: 0x04001F67 RID: 8039
		[global::Cpp2ILInjected.Token(Token = "0x40025A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Transform _parentTransform;

		// Token: 0x04001F68 RID: 8040
		[global::Cpp2ILInjected.Token(Token = "0x40025A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<GeometryBufferInstance> _freeInstances;

		// Token: 0x04001F69 RID: 8041
		[global::Cpp2ILInjected.Token(Token = "0x40025A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private List<GeometryBufferInstance> _usedInstances;

		// Token: 0x04001F6A RID: 8042
		[global::Cpp2ILInjected.Token(Token = "0x40025A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _resetOffset;

		// Token: 0x04001F6B RID: 8043
		[global::Cpp2ILInjected.Token(Token = "0x40025A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int _vertexCount;

		// Token: 0x04001F6C RID: 8044
		[global::Cpp2ILInjected.Token(Token = "0x40025A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _forcedLayer;

		// Token: 0x04001F6D RID: 8045
		[global::Cpp2ILInjected.Token(Token = "0x40025A6")]
		public static VertexAttributeDescriptor[] vertexDescription;

		// Token: 0x04001F6E RID: 8046
		[global::Cpp2ILInjected.Token(Token = "0x40025A7")]
		private static SubMeshDescriptor[] subMeshes;

		// Token: 0x04001F6F RID: 8047
		[global::Cpp2ILInjected.Token(Token = "0x40025A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private bool _finalPending;
	}
}
