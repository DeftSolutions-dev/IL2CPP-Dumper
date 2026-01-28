// ========================================================
// Dumped by @desirepro
// Assembly: MagicaCloth.dll
// Classes:  308
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: ReductionWeightMode
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaReductionMesh.ReductionMesh.ReductionWeightModeDistance  // 0x0
  public    static  MagicaReductionMesh.ReductionMesh.ReductionWeightModeAverage  // 0x0
  public    static  MagicaReductionMesh.ReductionMesh.ReductionWeightModeDistanceAverage  // 0x0
METHODS:
END_CLASS

CLASS: MeshIndexData
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  public            System.Collections.Generic.List<System.UInt32>meshIndexPackList  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MeshInfo
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    meshIndex  // 0x10
  public            UnityEngine.Mesh                mesh  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Vector3>vertices  // 0x20
  public            System.Collections.Generic.List<UnityEngine.Vector3>normals  // 0x28
  public            System.Collections.Generic.List<UnityEngine.Vector4>tangents  // 0x30
  public            System.Collections.Generic.List<UnityEngine.BoneWeight>boneWeights  // 0x38
  public            System.Collections.Generic.List<System.Int32>parents  // 0x40
METHODS:
  System.Int32 get_VertexCount()
  System.Void .ctor()
END_CLASS

CLASS: WeightData
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    boneIndex  // 0x10
  public            System.Single                   boneWeight  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Vertex
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    meshIndex  // 0x10
  public            System.Int32                    vertexIndex  // 0x14
  public            UnityEngine.Vector3             wpos  // 0x18
  public            UnityEngine.Vector3             wnor  // 0x24
  public            UnityEngine.Vector3             wtan  // 0x30
  public            System.Single                   tanw  // 0x3C
  public            UnityEngine.Vector2             uv  // 0x40
  public            System.Int32                    parentIndex  // 0x48
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.WeightData>boneWeightList  // 0x50
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MeshInfo
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    index  // 0x10
  public            UnityEngine.Mesh                mesh  // 0x18
  public            System.Int32                    vertexCount  // 0x20
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.Vertex>vertexList  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ShareVertex
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    sindex  // 0x10
  public            UnityEngine.Vector3             wpos  // 0x14
  public            UnityEngine.Vector3             wnor  // 0x20
  public            UnityEngine.Vector3             wtan  // 0x2C
  public            System.Single                   tanw  // 0x38
  public            UnityEngine.Vector2             uv  // 0x3C
  public            UnityEngine.Matrix4x4           worldToLocalMatrix  // 0x44
  public            UnityEngine.Matrix4x4           bindpose  // 0x84
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.WeightData>boneWeightList  // 0xC8
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.Vertex>vertexList  // 0xD0
  public            System.Collections.Generic.HashSet<MagicaReductionMesh.MeshData.ShareVertex>linkShareVertexSet  // 0xD8
  public            System.Collections.Generic.HashSet<MagicaReductionMesh.MeshData.Triangle>linkTriangleSet  // 0xE0
METHODS:
  System.Void AddLink(MagicaReductionMesh.MeshData.ShareVertex mv)
  System.Void ReplaseLink(MagicaReductionMesh.MeshData.ShareVertex old, MagicaReductionMesh.MeshData.ShareVertex mv)
  System.Void RecalcCoordinate()
  System.Void CalcNormalTangentFromTriangle()
  UnityEngine.Vector3 CalcLocalPos(UnityEngine.Vector3 pos)
  UnityEngine.Vector3 CalcLocalDir(UnityEngine.Vector3 dir)
  UnityEngine.Matrix4x4 CalcWorldToLocalMatrix()
  System.Void CalcBoneWeight(MagicaReductionMesh.ReductionMesh.ReductionWeightMode weightMode, System.Single weightPow)
  System.Void CalcBoneWeight_DistanceAverage(System.Single weightPow)
  System.Void CalcBoneWeight_Average()
  System.Void AdjustWeight(System.Collections.Generic.List<MagicaReductionMesh.MeshData.WeightData> sumlist)
  System.Void CalcBoneWeight_Distance(System.Single weightPow)
  UnityEngine.BoneWeight GetBoneWeight()
  System.Void .ctor()
END_CLASS

CLASS: Triangle
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    tindex  // 0x10
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex>shareVertexList  // 0x18
  public            UnityEngine.Vector3             wnor  // 0x20
  public            UnityEngine.Vector3             wtan  // 0x2C
  public            System.Boolean                  flipLock  // 0x38
METHODS:
  System.Void GetEdge(System.UInt32& edge0, System.UInt32& edge1, System.UInt32& edge2)
  UnityEngine.Vector3 CalcTriangleNormal()
  System.Void Flip()
  UnityEngine.Vector3 CalcTriangleTangent()
  MagicaReductionMesh.MeshData.ShareVertex GetNonEdgeVertex(System.Int32 edgev0, System.Int32 edgev1)
  System.UInt64 GetTriangleHash()
  System.Single GetTriangleArea(MagicaReductionMesh.MeshData.ShareVertex sv0, MagicaReductionMesh.MeshData.ShareVertex sv1, MagicaReductionMesh.MeshData.ShareVertex sv2)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: Line
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex>shareVertexList  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UvWrapMode
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaReductionMesh.MeshData.UvWrapModeNone  // 0x0
  public    static  MagicaReductionMesh.MeshData.UvWrapModeSphere  // 0x0
METHODS:
END_CLASS

CLASS: Square
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public            System.UInt64                   shash  // 0x10
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.Triangle>triangleList  // 0x18
  public            System.Single                   angle  // 0x20
METHODS:
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: Tetra
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex>shareVertexList  // 0x10
  public            UnityEngine.Vector3             circumCenter  // 0x18
  public            System.Single                   circumRadius  // 0x24
  public            UnityEngine.Vector3             tetraCenter  // 0x28
  public            System.Single                   tetraSize  // 0x34
METHODS:
  System.Void .ctor()
  System.Void .ctor(MagicaReductionMesh.MeshData.ShareVertex a, MagicaReductionMesh.MeshData.ShareVertex b, MagicaReductionMesh.MeshData.ShareVertex c, MagicaReductionMesh.MeshData.ShareVertex d)
  System.UInt64 GetTetraHash()
  System.Void CalcCircumcircle()
  System.Boolean IntersectCircumcircle(UnityEngine.Vector3 pos)
  System.Boolean CheckSame(MagicaReductionMesh.MeshData.Tetra tri)
  System.Boolean ContainsPoint(MagicaReductionMesh.MeshData.ShareVertex p1)
  System.Boolean ContainsPoint(MagicaReductionMesh.MeshData.ShareVertex p1, MagicaReductionMesh.MeshData.ShareVertex p2, MagicaReductionMesh.MeshData.ShareVertex p3, MagicaReductionMesh.MeshData.ShareVertex p4)
  System.Void CalcSize()
  System.Boolean Verification()
END_CLASS

CLASS: LinkInfo
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  public            MagicaReductionMesh.MeshData.ShareVertexsv  // 0x10
  public            System.Single                   length  // 0x18
  public            System.Int32                    count  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VertexLengthInfo
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  public            MagicaReductionMesh.MeshData.ShareVertexsv  // 0x10
  public            System.Single                   length  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Point
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  public            MagicaReductionMesh.MeshData.ShareVertexshareVertex  // 0x10
  public            UnityEngine.Vector3             pos  // 0x18
  public            UnityEngine.Vector3Int          grid  // 0x24
  public            MagicaReductionMesh.NearPointReduction.PointnearPoint  // 0x30
  public            System.Single                   nearDist  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Point
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  public            MagicaReductionMesh.MeshData.ShareVertexshareVertex  // 0x10
  public            MagicaReductionMesh.PolygonLinkReduction.PointnearPoint  // 0x18
  public            System.Single                   nearDist  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ConnectionMode
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.BoneClothTarget.ConnectionModeLine  // 0x0
  public    static  MagicaCloth.BoneClothTarget.ConnectionModeMeshAutomatic  // 0x0
  public    static  MagicaCloth.BoneClothTarget.ConnectionModeMeshSequentialLoop  // 0x0
  public    static  MagicaCloth.BoneClothTarget.ConnectionModeMeshSequentialNoLoop  // 0x0
METHODS:
END_CLASS

CLASS: RestoreDistanceWork
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  public            System.UInt32                   vertexPair  // 0x10
  public            System.Single                   dist  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PenetrationBone
TYPE:  class
TOKEN: 0x200003B
FIELDS:
  public            UnityEngine.Transform           bone  // 0x10
  public            UnityEngine.Transform           childBone  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PenetrationWork
TYPE:  class
TOKEN: 0x200003C
FIELDS:
  public            UnityEngine.Transform           bone  // 0x10
  public            UnityEngine.Transform           childBone  // 0x18
  public            System.Int32                    boneIndex  // 0x20
  public            System.Single                   distance  // 0x24
  public            System.Single                   weight  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VertexInfo
TYPE:  class
TOKEN: 0x200003D
FIELDS:
  public            System.Int32                    vertexIndex  // 0x10
  public            System.Int32                    parentVertexIndex  // 0x14
  public            System.Collections.Generic.List<System.Int32>childVertexList  // 0x18
  public            MagicaCloth.ClothData.VertexInfoparentInfo  // 0x20
  public            System.Collections.Generic.List<MagicaCloth.ClothData.VertexInfo>childInfoList  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Algorithm
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.ClothParams.AlgorithmAlgorithm_1  // 0x0
  public    static  MagicaCloth.ClothParams.AlgorithmAlgorithm_2  // 0x0
METHODS:
END_CLASS

CLASS: TeleportMode
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.ClothParams.TeleportModeReset  // 0x0
  public    static  MagicaCloth.ClothParams.TeleportModeKeep  // 0x0
METHODS:
END_CLASS

CLASS: AdjustMode
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.ClothParams.AdjustModeFixed  // 0x0
  public    static  MagicaCloth.ClothParams.AdjustModeXYMove  // 0x0
  public    static  MagicaCloth.ClothParams.AdjustModeXZMove  // 0x0
  public    static  MagicaCloth.ClothParams.AdjustModeYZMove  // 0x0
METHODS:
END_CLASS

CLASS: PenetrationMode
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.ClothParams.PenetrationModeSurfacePenetration  // 0x0
  public    static  MagicaCloth.ClothParams.PenetrationModeColliderPenetration  // 0x0
METHODS:
END_CLASS

CLASS: PenetrationAxis
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.ClothParams.PenetrationAxisX  // 0x0
  public    static  MagicaCloth.ClothParams.PenetrationAxisY  // 0x0
  public    static  MagicaCloth.ClothParams.PenetrationAxisZ  // 0x0
  public    static  MagicaCloth.ClothParams.PenetrationAxisInverseX  // 0x0
  public    static  MagicaCloth.ClothParams.PenetrationAxisInverseY  // 0x0
  public    static  MagicaCloth.ClothParams.PenetrationAxisInverseZ  // 0x0
METHODS:
END_CLASS

CLASS: ParamType
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.ClothParams.ParamTypeRadius  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeMass  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeGravity  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeDrag  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeMaxVelocity  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeWorldInfluence  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeClampDistance  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeClampPosition  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeClampRotation  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeRestoreDistance  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeRestoreRotation  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeSpring  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeAdjustRotation  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeAirLine  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeTriangleBend  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeVolume  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeColliderCollision  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeRotationInterpolation  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeDistanceDisable  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeExternalForce  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypePenetration  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeAlgorithm  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeBaseSkinning  // 0x0
  public    static  MagicaCloth.ClothParams.ParamTypeMax  // 0x0
METHODS:
END_CLASS

CLASS: Axis
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.MagicaMeshSpring.AxisX  // 0x0
  public    static  MagicaCloth.MagicaMeshSpring.AxisY  // 0x0
  public    static  MagicaCloth.MagicaMeshSpring.AxisZ  // 0x0
  public    static  MagicaCloth.MagicaMeshSpring.AxisInverseX  // 0x0
  public    static  MagicaCloth.MagicaMeshSpring.AxisInverseY  // 0x0
  public    static  MagicaCloth.MagicaMeshSpring.AxisInverseZ  // 0x0
METHODS:
END_CLASS

CLASS: DeformerSelection
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  public            System.Collections.Generic.List<System.Int32>selectData  // 0x10
  public            System.Collections.Generic.List<System.UInt64>vertexHashList  // 0x18
METHODS:
  System.Int32 GetDataHash()
  System.Boolean Compare(MagicaCloth.SelectionData.DeformerSelection data)
  System.Void .ctor()
END_CLASS

CLASS: DeformerData
TYPE:  class
TOKEN: 0x2000053
FIELDS:
  public            System.Int32                    deformerDataHash  // 0x10
  public            System.Int32                    vertexCount  // 0x14
  public            System.Int32[]                  useVertexIndexList  // 0x18
  public            System.Single[]                 weightList  // 0x20
METHODS:
  System.Int32 get_UseVertexCount()
  System.Int32 GetDataHash()
  System.Void .ctor()
END_CLASS

CLASS: Compute
TYPE:  class
TOKEN: 0x2000055
FIELDS:
  public    static  System.Single                   Epsilon  // 0x0
  public    static  System.Single                   CollisionFrictionRange  // 0x0
  public    static  System.Single                   FrictionDampingRate  // 0x0
  public    static  System.Single                   FrictionMoveRatio  // 0x0
  public    static  System.Single                   FrictionPower  // 0x0
  public    static  System.Single                   ClampPositionMaxVelocity  // 0x0
  public    static  System.Single                   GlobalColliderMaxMoveDistance  // 0x0
  public    static  System.Single                   GlobalColliderMaxRotationAngle  // 0x0
  public    static  System.Single                   ColliderExtrusionMaxPower  // 0x0
  public    static  System.Single                   ColliderExtrusionDirectionPower  // 0x0
  public    static  System.Single                   ColliderExtrusionDistPower  // 0x0
  public    static  System.Single                   ColliderExtrusionVelocityInfluence  // 0x0
  public    static  System.Single                   MaxWindMain  // 0x0
  public    static  System.Single                   ClampRotationMaxVelocity  // 0x0
  public    static  System.Single                   ClampRotationMaxVelocity2  // 0x0
  public    static  System.Single                   TriangleBendVelocityInfluence  // 0x0
METHODS:
END_CLASS

CLASS: Error
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.Define.Error        None  // 0x0
  public    static  MagicaCloth.Define.Error        Cancel  // 0x0
  public    static  MagicaCloth.Define.Error        EmptyData  // 0x0
  public    static  MagicaCloth.Define.Error        InvalidDataHash  // 0x0
  public    static  MagicaCloth.Define.Error        TooOldDataVersion  // 0x0
  public    static  MagicaCloth.Define.Error        HigherDataVersion  // 0x0
  public    static  MagicaCloth.Define.Error        MeshDataNull  // 0x0
  public    static  MagicaCloth.Define.Error        MeshDataHashMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        MeshDataVersionMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        ClothDataNull  // 0x0
  public    static  MagicaCloth.Define.Error        ClothDataHashMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        ClothDataVersionMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        ClothSelectionHashMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        ClothSelectionVersionMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        ClothTargetRootCountMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        UseTransformNull  // 0x0
  public    static  MagicaCloth.Define.Error        UseTransformCountZero  // 0x0
  public    static  MagicaCloth.Define.Error        UseTransformCountMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        DeformerNull  // 0x0
  public    static  MagicaCloth.Define.Error        DeformerHashMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        DeformerVersionMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        DeformerCountZero  // 0x0
  public    static  MagicaCloth.Define.Error        DeformerCountMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        VertexCountZero  // 0x0
  public    static  MagicaCloth.Define.Error        VertexUseCountZero  // 0x0
  public    static  MagicaCloth.Define.Error        VertexCountMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        RootListCountMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        SelectionDataCountMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        SelectionCountZero  // 0x0
  public    static  MagicaCloth.Define.Error        CenterTransformNull  // 0x0
  public    static  MagicaCloth.Define.Error        SpringDataNull  // 0x0
  public    static  MagicaCloth.Define.Error        SpringDataHashMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        SpringDataVersionMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        TargetObjectNull  // 0x0
  public    static  MagicaCloth.Define.Error        SharedMeshNull  // 0x0
  public    static  MagicaCloth.Define.Error        SharedMeshCannotRead  // 0x0
  public    static  MagicaCloth.Define.Error        SharedMeshDifferent  // 0x0
  public    static  MagicaCloth.Define.Error        SharedMeshDifferentVertexCount  // 0x0
  public    static  MagicaCloth.Define.Error        MeshOptimizeMismatch  // 0x0
  public    static  MagicaCloth.Define.Error        MeshVertexCount65535Over  // 0x0
  public    static  MagicaCloth.Define.Error        MeshKeepQuads  // 0x0
  public    static  MagicaCloth.Define.Error        BoneListZero  // 0x0
  public    static  MagicaCloth.Define.Error        BoneListNull  // 0x0
  public    static  MagicaCloth.Define.Error        RendererNotFound  // 0x0
  public    static  MagicaCloth.Define.Error        MeshFilterNotFound  // 0x0
  public    static  MagicaCloth.Define.Error        BuildNoTransformList  // 0x0
  public    static  MagicaCloth.Define.Error        BuildReadOnlyPrefab  // 0x0
  public    static  MagicaCloth.Define.Error        BuildFailedSaveAssets  // 0x0
  public    static  MagicaCloth.Define.Error        BuildPrefabCannotSaved  // 0x0
  public    static  MagicaCloth.Define.Error        BuildNotSceneObject  // 0x0
  public    static  MagicaCloth.Define.Error        BuildInvalidComponent  // 0x0
  public    static  MagicaCloth.Define.Error        BuildInvalidData  // 0x0
  public    static  MagicaCloth.Define.Error        BuildInvalidMeshData  // 0x0
  public    static  MagicaCloth.Define.Error        BuildInvalidGameObject  // 0x0
  public    static  MagicaCloth.Define.Error        BuildInvalidPrefab  // 0x0
  public    static  MagicaCloth.Define.Error        BuildInvalidRenderDeformer  // 0x0
  public    static  MagicaCloth.Define.Error        BuildInvalidScene  // 0x0
  public    static  MagicaCloth.Define.Error        BuildInvalidSelection  // 0x0
  public    static  MagicaCloth.Define.Error        BuildMissingDeformer  // 0x0
  public    static  MagicaCloth.Define.Error        BuildMissingSelection  // 0x0
  public    static  MagicaCloth.Define.Error        BuildMissingMesh  // 0x0
  public    static  MagicaCloth.Define.Error        BuildMissingScriptOnPrefab  // 0x0
  public    static  MagicaCloth.Define.Error        OverlappingTransform  // 0x0
  public    static  MagicaCloth.Define.Error        AddOverlappingTransform  // 0x0
  public    static  MagicaCloth.Define.Error        OldDataVersion  // 0x0
  public    static  MagicaCloth.Define.Error        OldAlgorithm  // 0x0
METHODS:
END_CLASS

CLASS: OptimizeMesh
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  public    static  System.Int32                    Unknown  // 0x0
  public    static  System.Int32                    Nothing  // 0x0
  public    static  System.Int32                    Unity2018_On  // 0x0
  public    static  System.Int32                    Unity2019_PolygonOrder  // 0x0
  public    static  System.Int32                    Unity2019_VertexOrder  // 0x0
METHODS:
END_CLASS

CLASS: RenderMesh
TYPE:  class
TOKEN: 0x2000058
FIELDS:
  public    static  System.Int32                    WorkerMultiplesOfVertexCollection  // 0x0
METHODS:
END_CLASS

CLASS: VertexWeight
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            UnityEngine.Vector3             localPos  // 0x10
  public            UnityEngine.Vector3             localNor  // 0x1C
  public            UnityEngine.Vector3             localTan  // 0x28
  public            System.Int32                    parentIndex  // 0x34
  public            System.Single                   weight  // 0x38
METHODS:
END_CLASS

CLASS: ChildData
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  public            System.Int32                    childDataHash  // 0x10
  public            System.Int32                    vertexCount  // 0x14
  public            System.UInt32[]                 vertexInfoList  // 0x18
  public            MagicaCloth.MeshData.VertexWeight[]vertexWeightList  // 0x20
  public            System.Int32[]                  parentIndexList  // 0x28
METHODS:
  System.Int32 get_VertexCount()
  System.Int32 GetDataHash()
  System.Void .ctor()
END_CLASS

CLASS: RecalculateMode
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.RenderMeshDeformer.RecalculateModeNone  // 0x0
  public    static  MagicaCloth.RenderMeshDeformer.RecalculateModeUpdateNormalPerFrame  // 0x0
  public    static  MagicaCloth.RenderMeshDeformer.RecalculateModeUpdateNormalAndTangentPerFrame  // 0x0
METHODS:
END_CLASS

CLASS: BoundsMode
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.RenderMeshDeformer.BoundsModeNone  // 0x0
  public    static  MagicaCloth.RenderMeshDeformer.BoundsModeExpandedAtInitialization  // 0x0
METHODS:
END_CLASS

CLASS: ClampDistance2Data
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Int32                    vertexIndex  // 0x10
  public            System.Int32                    parentVertexIndex  // 0x14
  public            System.Single                   length  // 0x18
METHODS:
END_CLASS

CLASS: ClampDistance2RootInfo
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.UInt16                   startIndex  // 0x10
  public            System.UInt16                   dataLength  // 0x12
METHODS:
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            System.Single                   minRatio  // 0x18
  public            System.Single                   maxRatio  // 0x1C
  public            System.Single                   velocityInfluence  // 0x20
  public            MagicaCloth.ChunkData           dataChunk  // 0x24
  public            MagicaCloth.ChunkData           rootInfoChunk  // 0x34
METHODS:
END_CLASS

CLASS: ClampDistance2Job
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2Data>dataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo>rootInfoList  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>rootTeamList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.ClampDistance2Constraint.GroupData>groupList  // 0x48
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x68
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x98
METHODS:
  System.Void Execute(System.Int32 rootIndex)
END_CLASS

CLASS: ClampDistanceData
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.UInt16                   vertexIndex  // 0x10
  public            System.UInt16                   targetVertexIndex  // 0x12
  public            System.Single                   length  // 0x14
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            System.Single                   minRatio  // 0x18
  public            System.Single                   maxRatio  // 0x1C
  public            System.Single                   velocityInfluence  // 0x20
  public            MagicaCloth.ChunkData           dataChunk  // 0x24
  public            MagicaCloth.ChunkData           refChunk  // 0x34
METHODS:
END_CLASS

CLASS: ClampDistanceJob
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.ClampDistanceConstraint.ClampDistanceData>clampDistanceList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.ClampDistanceConstraint.GroupData>groupList  // 0x28
  public            Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x98
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0xA8
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            MagicaCloth.CurveParam          limitLength  // 0x18
  public            Unity.Mathematics.float3        axisRatio  // 0x28
  public            System.Single                   velocityInfluence  // 0x34
METHODS:
  System.Boolean IsAxisCheck()
END_CLASS

CLASS: ClampPositionJob
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            System.Single                   maxMoveLength  // 0x14
  public            Unity.Collections.NativeArray<MagicaCloth.ClampPositionConstraint.GroupData>clampPositionGroupList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x48
  public            Unity.Collections.NativeArray<System.Single>depthList  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0x78
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xA8
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: ClampRotationData
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    vertexIndex  // 0x10
  public            System.Int32                    parentVertexIndex  // 0x14
  public            Unity.Mathematics.float3        localPos  // 0x18
  public            Unity.Mathematics.quaternion    localRot  // 0x24
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: ClampRotationRootInfo
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.UInt16                   startIndex  // 0x10
  public            System.UInt16                   dataLength  // 0x12
METHODS:
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            MagicaCloth.CurveParam          maxAngle  // 0x18
  public            System.Single                   velocityInfluence  // 0x28
  public            MagicaCloth.ChunkData           dataChunk  // 0x2C
  public            MagicaCloth.ChunkData           rootInfoChunk  // 0x3C
METHODS:
END_CLASS

CLASS: ClampRotationJob
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            System.Single                   maxMoveLength  // 0x14
  public            Unity.Collections.NativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationData>dataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo>rootInfoList  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>rootTeamList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.ClampRotationConstraint.GroupData>groupList  // 0x48
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x58
  public            Unity.Collections.NativeArray<System.Single>depthList  // 0x68
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x78
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0xA8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xB8
  public            Unity.Collections.NativeArray<System.Single>lengthBuffer  // 0xC8
METHODS:
  System.Void Execute(System.Int32 rootIndex)
END_CLASS

CLASS: CollisionJob
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x18
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>radiusList  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPosList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0xA8
  public            Unity.Collections.NativeArray<System.Int32>transformIndexList  // 0xB8
  public            Unity.Collections.NativeArray<System.Int32>colliderList  // 0xC8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneSclList  // 0xD8
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0xE8
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0xF8
  public            Unity.Collections.NativeArray<System.Int32>collisionLinkIdList  // 0x108
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>collisionNormalList  // 0x118
METHODS:
  System.Void Execute(System.Int32 index)
  System.Single SphereColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3& normal)
  System.Single CapsuleColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3 dir, Unity.Mathematics.float3& normal)
  System.Single PlaneColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3& normal)
END_CLASS

CLASS: CollisionExtrusionJob
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x18
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>collisionLinkIdList  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0x78
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>collisionNormalList  // 0x98
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0xA8
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: RotationData
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            System.Int32                    vertexIndex  // 0x10
  public            System.Int32                    parentVertexIndex  // 0x14
  public            Unity.Mathematics.float3        localPos  // 0x18
  public            Unity.Mathematics.quaternion    localRot  // 0x24
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: RootInfo
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            System.UInt16                   startIndex  // 0x10
  public            System.UInt16                   dataLength  // 0x12
METHODS:
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    useClamp  // 0x14
  public            System.Int32                    useRestore  // 0x18
  public            MagicaCloth.CurveParam          maxAngle  // 0x1C
  public            MagicaCloth.CurveParam          restorePower  // 0x2C
  public            System.Single                   restoreVelocityInfluence  // 0x3C
  public            MagicaCloth.ChunkData           dataChunk  // 0x40
  public            MagicaCloth.ChunkData           rootInfoChunk  // 0x50
METHODS:
END_CLASS

CLASS: RotationRootLineJob
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            System.Single                   updatePower  // 0x10
  public            System.Int32                    runCount  // 0x14
  public            System.Single                   maxMoveSpeed  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.CompositeRotationConstraint.RotationData>dataList  // 0x20
  public            Unity.Collections.NativeArray<MagicaCloth.CompositeRotationConstraint.RootInfo>rootInfoList  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>rootTeamList  // 0x40
  public            Unity.Collections.NativeArray<MagicaCloth.CompositeRotationConstraint.GroupData>groupList  // 0x50
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x60
  public            Unity.Collections.NativeArray<MagicaCloth.CurveParam>teamGravityList  // 0x70
  public            Unity.Collections.NativeArray<System.Single>depthList  // 0x80
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x90
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xF0
  public            Unity.Collections.NativeArray<System.Single>lengthBuffer  // 0x100
METHODS:
  System.Void Execute(System.Int32 rootIndex)
  System.Single GetRotRatio(Unity.Mathematics.float3 tv, Unity.Mathematics.float3 gravityVector, System.Single gravity, System.Single minRatio, System.Single maxRatio)
END_CLASS

CLASS: EdgeCollisionData
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            System.UInt16                   vindex0  // 0x10
  public            System.UInt16                   vindex1  // 0x12
  public            System.Int32                    writeIndex0  // 0x14
  public            System.Int32                    writeIndex1  // 0x18
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            System.Single                   edgeRadius  // 0x18
  public            MagicaCloth.ChunkData           dataChunk  // 0x1C
  public            MagicaCloth.ChunkData           groupIndexChunk  // 0x2C
  public            MagicaCloth.ChunkData           refDataChunk  // 0x3C
  public            MagicaCloth.ChunkData           writeDataChunk  // 0x4C
METHODS:
END_CLASS

CLASS: EdgeCollisionCalcJob
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
  public            System.Single                   updatePower  // 0x10
  public            System.Int32                    runCount  // 0x14
  public            Unity.Collections.NativeArray<MagicaCloth.EdgeCollisionConstraint.GroupData>groupDataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData>dataList  // 0x28
  public            Unity.Collections.NativeArray<System.Int16>groupIndexList  // 0x38
  public            Unity.Collections.NativeArray<System.Int32>colliderList  // 0x48
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>radiusList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0xA8
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0xB8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPosList  // 0xC8
  public            Unity.Collections.NativeArray<System.Int32>transformIndexList  // 0xD8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneSclList  // 0xE8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBuffer  // 0xF8
METHODS:
  System.Void Execute(System.Int32 index)
  System.Boolean SphereColliderDetection(Unity.Mathematics.float3 nextpos0, Unity.Mathematics.float3 nextpos1, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, System.Single radius, System.Int32 cindex)
  System.Boolean CapsuleColliderDetection(Unity.Mathematics.float3 nextpos0, Unity.Mathematics.float3 nextpos1, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3 dir)
END_CLASS

CLASS: EdgeCollisionSumJob
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.EdgeCollisionConstraint.GroupData>groupDataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBuffer  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>inoutNextPosList  // 0x78
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0x88
METHODS:
  System.Void Execute(System.Int32 pindex)
END_CLASS

CLASS: PenetrationData
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Int16                    vertexIndex  // 0x10
  public            System.Int16                    colliderIndex  // 0x12
  public            Unity.Mathematics.float3        localPos  // 0x14
  public            Unity.Mathematics.float3        localDir  // 0x20
  public            System.Single                   distance  // 0x2C
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            System.Int32                    mode  // 0x18
  public            System.Single                   maxDepth  // 0x1C
  public            MagicaCloth.CurveParam          radius  // 0x20
  public            MagicaCloth.CurveParam          distance  // 0x30
  public            MagicaCloth.ChunkData           dataChunk  // 0x40
  public            MagicaCloth.ChunkData           refDataChunk  // 0x50
  public            MagicaCloth.ChunkData           bonePenetrationDataChunk  // 0x60
METHODS:
END_CLASS

CLASS: PenetrationJob
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PenetrationConstraint.GroupData>groupList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.PenetrationConstraint.PenetrationData>dataList  // 0x28
  public            Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePenetrationDataList  // 0x48
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x58
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0x88
  public            Unity.Collections.NativeArray<System.Int32>transformIndexList  // 0x98
  public            Unity.Collections.NativeArray<System.Single>depthList  // 0xA8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0xB8
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0xC8
  public            Unity.Collections.NativeArray<System.Int32>colliderList  // 0xD8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0xE8
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0xF8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneSclList  // 0x108
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x118
  public            Unity.Collections.NativeArray<System.Int32>skinningBoneList  // 0x128
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>outNextPosList  // 0x138
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x148
METHODS:
  System.Void Execute(System.Int32 index)
  Unity.Mathematics.float3 InverseSpherePosition(MagicaCloth.PenetrationConstraint.PenetrationData& data, System.Single teamScale, Unity.Mathematics.float3 scaleDirection, System.Single distance, System.Int32 cindex, System.Single cr)
  Unity.Mathematics.float3 InverseSpherePenetration(Unity.Mathematics.float3 c, System.Single cr, Unity.Mathematics.float3 nextpos)
END_CLASS

CLASS: RestoreDistanceData
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.UInt16                   vertexIndex  // 0x10
  public            System.UInt16                   targetVertexIndex  // 0x12
  public            System.Single                   length  // 0x14
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: RestoreDistanceGroupData
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            MagicaCloth.CurveParam          mass  // 0x14
  public            System.Single                   velocityInfluence  // 0x24
  public            MagicaCloth.CurveParam          structStiffness  // 0x28
  public            MagicaCloth.ChunkData           structDataChunk  // 0x38
  public            MagicaCloth.ChunkData           structRefChunk  // 0x48
  public            System.Int32                    useBend  // 0x58
  public            MagicaCloth.CurveParam          bendStiffness  // 0x5C
  public            MagicaCloth.ChunkData           bendDataChunk  // 0x6C
  public            MagicaCloth.ChunkData           bendRefChunk  // 0x7C
  public            System.Int32                    useNear  // 0x8C
  public            MagicaCloth.CurveParam          nearStiffness  // 0x90
  public            MagicaCloth.ChunkData           nearDataChunk  // 0xA0
  public            MagicaCloth.ChunkData           nearRefChunk  // 0xB0
METHODS:
  System.Boolean IsValid(System.Int32 type)
  MagicaCloth.CurveParam GetStiffness(System.Int32 type)
  MagicaCloth.ChunkData GetDataChunk(System.Int32 type)
  MagicaCloth.ChunkData GetRefChunk(System.Int32 type)
END_CLASS

CLASS: DistanceJob
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Single                   updatePower  // 0x10
  public            System.Int32                    runCount  // 0x14
  public            System.Int32                    type  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData>restoreDistanceDataList  // 0x20
  public            Unity.Collections.NativeArray<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceGroupData>restoreDistanceGroupDataList  // 0x30
  public            Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x40
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x50
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x60
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x70
  public            Unity.Collections.NativeArray<System.Single>depthList  // 0x80
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>outNextPosList  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xD0
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: RotationData
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.UInt16                   vertexIndex  // 0x10
  public            System.UInt16                   targetVertexIndex  // 0x12
  public            Unity.Mathematics.float3        localPos  // 0x14
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            MagicaCloth.CurveParam          restorePower  // 0x18
  public            System.Single                   velocityInfluence  // 0x28
  public            MagicaCloth.ChunkData           dataChunk  // 0x2C
  public            MagicaCloth.ChunkData           refChunk  // 0x3C
METHODS:
END_CLASS

CLASS: RotationJob
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Single                   updatePower  // 0x10
  public            System.Int32                    runCount  // 0x14
  public            Unity.Collections.NativeArray<MagicaCloth.RestoreRotationConstraint.RotationData>dataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.RestoreRotationConstraint.GroupData>groupList  // 0x28
  public            Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x68
  public            Unity.Collections.NativeArray<System.Single>depthList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x98
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0xA8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>outNextPosList  // 0xB8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xC8
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            System.Single                   spring  // 0x18
METHODS:
END_CLASS

CLASS: SpringJob
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  public            System.Single                   updatePower  // 0x10
  public            System.Int32                    runCount  // 0x14
  public            Unity.Collections.NativeArray<MagicaCloth.SpringConstraint.GroupData>groupList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x68
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: TriangleBendData
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            System.Int32                    vindex0  // 0x10
  public            System.Int32                    vindex1  // 0x14
  public            System.Int32                    vindex2  // 0x18
  public            System.Int32                    vindex3  // 0x1C
  public            System.Single                   restAngle  // 0x20
  public            System.Single                   direction  // 0x24
  public            System.Single                   depth  // 0x28
  public            System.Int32                    writeIndex0  // 0x2C
  public            System.Int32                    writeIndex1  // 0x30
  public            System.Int32                    writeIndex2  // 0x34
  public            System.Int32                    writeIndex3  // 0x38
METHODS:
  System.Boolean IsValid()
  System.Boolean IsPositionBend()
END_CLASS

CLASS: TriangleBendGroupData
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            System.Int32                    algorithm  // 0x18
  public            MagicaCloth.CurveParam          stiffness  // 0x1C
  public            MagicaCloth.ChunkData           dataChunk  // 0x2C
  public            MagicaCloth.ChunkData           groupIndexChunk  // 0x3C
  public            MagicaCloth.ChunkData           refDataChunk  // 0x4C
  public            MagicaCloth.ChunkData           writeDataChunk  // 0x5C
METHODS:
END_CLASS

CLASS: TriangleBendCalcJob
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            System.Single                   updatePower  // 0x10
  public            System.Int32                    runCount  // 0x14
  public            Unity.Collections.NativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendGroupData>triangleBendGroupDataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendData>triangleBendList  // 0x28
  public            Unity.Collections.NativeArray<System.Int16>groupIndexList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBuffer  // 0x78
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: TriangleBendSumJob
TYPE:  struct
TOKEN: 0x2000096
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendGroupData>triangleBendGroupDataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBuffer  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>inoutNextPosList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x88
METHODS:
  System.Void Execute(System.Int32 pindex)
END_CLASS

CLASS: TwistData
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public            System.UInt16                   vertexIndex0  // 0x10
  public            System.UInt16                   vertexIndex1  // 0x12
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            System.Single                   recoveryPower  // 0x18
  public            MagicaCloth.ChunkData           dataChunk  // 0x1C
  public            MagicaCloth.ChunkData           refChunk  // 0x2C
METHODS:
END_CLASS

CLASS: TwistJob2
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            System.Single                   updatePower  // 0x14
  public            Unity.Collections.NativeArray<MagicaCloth.TwistConstraint.TwistData>dataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x28
  public            Unity.Collections.NativeArray<MagicaCloth.TwistConstraint.GroupData>groupList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x88
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>outNextPosList  // 0xA8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xB8
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: VolumeData
TYPE:  struct
TOKEN: 0x200009C
FIELDS:
  public            System.Int32                    vindex0  // 0x10
  public            System.Int32                    vindex1  // 0x14
  public            System.Int32                    vindex2  // 0x18
  public            System.Int32                    vindex3  // 0x1C
  public            Unity.Mathematics.float3x3      ivMat  // 0x20
  public            System.Single                   depth  // 0x44
  public            System.Int32                    direction  // 0x48
  public            System.Int32                    writeIndex0  // 0x4C
  public            System.Int32                    writeIndex1  // 0x50
  public            System.Int32                    writeIndex2  // 0x54
  public            System.Int32                    writeIndex3  // 0x58
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x200009D
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            MagicaCloth.CurveParam          stretchStiffness  // 0x18
  public            MagicaCloth.CurveParam          shearStiffness  // 0x28
  public            MagicaCloth.ChunkData           dataChunk  // 0x38
  public            MagicaCloth.ChunkData           groupIndexChunk  // 0x48
  public            MagicaCloth.ChunkData           refDataChunk  // 0x58
  public            MagicaCloth.ChunkData           writeDataChunk  // 0x68
METHODS:
END_CLASS

CLASS: VolumeCalcJob
TYPE:  struct
TOKEN: 0x200009E
FIELDS:
  public            System.Single                   updatePower  // 0x10
  public            System.Int32                    runCount  // 0x14
  public            Unity.Collections.NativeArray<MagicaCloth.VolumeConstraint.GroupData>groupDataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.VolumeConstraint.VolumeData>dataList  // 0x28
  public            Unity.Collections.NativeArray<System.Int16>groupIndexList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBuffer  // 0x68
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: VolumeSumJob
TYPE:  struct
TOKEN: 0x200009F
FIELDS:
  public            System.Int32                    runCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.VolumeConstraint.GroupData>groupDataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBuffer  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>inoutNextPosList  // 0x78
METHODS:
  System.Void Execute(System.Int32 pindex)
END_CLASS

CLASS: RestoreBoneJob
TYPE:  struct
TOKEN: 0x20000A5
FIELDS:
  public            System.Boolean                  fixedUpdate  // 0x10
  public            Unity.Collections.NativeArray<System.Int16>boneUnityPhysicsList  // 0x18
  public            Unity.Collections.NativeArray<System.Byte>boneFlagList  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>restoreBoneLocalPosList  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>restoreBoneLocalRotList  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>restoreBoneIndexList  // 0x58
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: ReadBoneJob0
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  public            System.Int32                    fixedUpdateCount  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneSclList  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>futurePosList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>futureRotList  // 0x78
  public            Unity.Collections.NativeArray<System.Int16>boneUnityPhysicsList  // 0x88
  public            Unity.Collections.NativeArray<System.Byte>boneFlagList  // 0x98
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: ReadBoneJob1
TYPE:  struct
TOKEN: 0x20000A7
FIELDS:
  public            System.Int32                    fixedUpdateCount  // 0x10
  public            System.Single                   normalFutureRatio  // 0x14
  public            System.Single                   fixedFutureRatio  // 0x18
  public            System.Single                   normalDeltaTime  // 0x1C
  public            System.Single                   fixedDeltaTime  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneSclList  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0x68
  public            Unity.Collections.NativeArray<System.Int16>boneUnityPhysicsList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>futurePosList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>futureRotList  // 0x98
  public            Unity.Collections.NativeArray<System.Byte>boneFlagList  // 0xA8
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: ConvertWorldToLocalJob
TYPE:  struct
TOKEN: 0x20000A8
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>writeBoneIndexList  // 0x10
  public            Unity.Collections.NativeArray<System.Byte>boneFlagList  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneSclList  // 0x50
  public            Unity.Collections.NativeArray<System.Int32>boneParentIndexList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBonePosList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>writeBoneRotList  // 0x80
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: WriteBontToTransformJob2
TYPE:  struct
TOKEN: 0x20000A9
FIELDS:
  public            System.Int32                    fixedUpdateCount  // 0x10
  public            Unity.Collections.NativeArray<System.Byte>boneFlagList  // 0x18
  public            Unity.Collections.NativeArray<System.Int32>writeBoneIndexList  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>boneParentIndexList  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBonePosList  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>writeBoneRotList  // 0x58
  public            Unity.Collections.NativeArray<System.Int16>boneUnityPhysicsList  // 0x68
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: CopyBoneJob0
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>backBonePosList  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>backBoneRotList  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: CopyBoneJob1
TYPE:  struct
TOKEN: 0x20000AB
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>writeBoneIndexList  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>backWriteBoneIndexList  // 0x20
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: CopyBoneJob2
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  public            Unity.Collections.NativeArray<System.Byte>boneFlagList  // 0x10
  public            Unity.Collections.NativeArray<System.Byte>backBoneFlagList  // 0x20
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: ForceAndVelocityJob
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.Single                   updateDeltaTime  // 0x10
  public            System.Single                   updatePower  // 0x14
  public            System.Int32                    runCount  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x20
  public            Unity.Collections.NativeArray<MagicaCloth.CurveParam>teamMassList  // 0x30
  public            Unity.Collections.NativeArray<MagicaCloth.CurveParam>teamGravityList  // 0x40
  public            Unity.Collections.NativeArray<MagicaCloth.CurveParam>teamDragList  // 0x50
  public            Unity.Collections.NativeArray<MagicaCloth.CurveParam>teamDepthInfluenceList  // 0x60
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WindInfo>teamWindInfoList  // 0x70
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x80
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x90
  public            Unity.Collections.NativeArray<System.Single>depthList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>snapBasePosList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>snapBaseRotList  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldBasePosList  // 0xF0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldBaseRotList  // 0x100
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x110
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0x120
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0x130
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x140
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0x150
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosList  // 0x160
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotList  // 0x170
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityList  // 0x180
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerWindData.WindData>windDataList  // 0x190
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0x1A0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0x1B0
METHODS:
  System.Void Execute(System.Int32 index)
  Unity.Mathematics.float3 Wind(System.Int32 teamId, MagicaCloth.PhysicsManagerTeamData.TeamData& teamData, Unity.Mathematics.float3& pos)
END_CLASS

CLASS: FixPositionJob
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  public            System.Single                   updatePower  // 0x10
  public            System.Single                   updateDeltaTime  // 0x14
  public            System.Int32                    runCount  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x20
  public            Unity.Collections.NativeArray<MagicaCloth.CurveParam>teamMaxVelocityList  // 0x30
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x50
  public            Unity.Collections.NativeArray<System.Single>depthList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0x80
  public            Unity.Collections.NativeArray<System.Single>frictionList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosList  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotList  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPosList  // 0xF0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>collisionNormalList  // 0x100
  public            Unity.Collections.NativeArray<System.Single>staticFrictionList  // 0x110
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: PostUpdatePhysicsJob
TYPE:  struct
TOKEN: 0x20000B1
FIELDS:
  public            System.Single                   updateDeltaTime  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>snapBasePosList  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>snapBaseRotList  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldBasePosList  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldBaseRotList  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityList  // 0xA8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPosList  // 0xB8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosList  // 0xC8
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotList  // 0xD8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xE8
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0xF8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x108
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0x118
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldSlowPosList  // 0x128
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: SharedVirtualMeshInfo
TYPE:  struct
TOKEN: 0x20000B4
FIELDS:
  public            System.Int32                    uid  // 0x10
  public            System.Int32                    useCount  // 0x14
  public            System.Int32                    sharedChildMeshStartIndex  // 0x18
  public            System.Int32                    sharedChildMeshCount  // 0x1C
  public            MagicaCloth.ChunkData           vertexChunk  // 0x20
  public            MagicaCloth.ChunkData           weightChunk  // 0x30
  public            MagicaCloth.ChunkData           triangleChunk  // 0x40
  public            MagicaCloth.ChunkData           vertexToTriangleChunk  // 0x50
METHODS:
END_CLASS

CLASS: VirtualMeshInfo
TYPE:  struct
TOKEN: 0x20000B5
FIELDS:
  public            System.UInt32                   flag  // 0x10
  public            System.Int32                    sharedVirtualMeshIndex  // 0x14
  public            System.Int32                    meshUseCount  // 0x18
  public            System.Int32                    vertexUseCount  // 0x1C
  public            MagicaCloth.ChunkData           vertexChunk  // 0x20
  public            MagicaCloth.ChunkData           boneChunk  // 0x30
  public            MagicaCloth.ChunkData           triangleChunk  // 0x40
  public            System.Int32                    transformIndex  // 0x50
METHODS:
  System.Boolean IsFlag(System.UInt32 flag)
  System.Void SetFlag(System.UInt32 flag, System.Boolean sw)
  System.Boolean IsActive()
  System.Boolean IsUse()
  System.Boolean IsPause()
END_CLASS

CLASS: SharedChildMeshInfo
TYPE:  struct
TOKEN: 0x20000B6
FIELDS:
  public            System.Int64                    cuid  // 0x10
  public            System.Int32                    sharedVirtualMeshIndex  // 0x18
  public            System.Int32                    virtualMeshIndex  // 0x1C
  public            System.Int32                    meshUseCount  // 0x20
  public            MagicaCloth.ChunkData           vertexChunk  // 0x24
  public            MagicaCloth.ChunkData           weightChunk  // 0x34
METHODS:
END_CLASS

CLASS: SharedRenderMeshInfo
TYPE:  struct
TOKEN: 0x20000B7
FIELDS:
  public            System.Int32                    uid  // 0x10
  public            System.Int32                    useCount  // 0x14
  public            System.UInt32                   flag  // 0x18
  public            MagicaCloth.ChunkData           vertexChunk  // 0x1C
  public            MagicaCloth.ChunkData           bonePerVertexChunk  // 0x2C
  public            MagicaCloth.ChunkData           boneWeightsChunk  // 0x3C
  public            System.Int32                    rendererBoneIndex  // 0x4C
METHODS:
  System.Boolean IsFlag(System.UInt32 flag)
  System.Void SetFlag(System.UInt32 flag, System.Boolean sw)
  System.Boolean IsSkinning()
END_CLASS

CLASS: RenderMeshInfo
TYPE:  struct
TOKEN: 0x20000B8
FIELDS:
  public            System.UInt32                   flag  // 0x10
  public            System.Int32                    renderSharedMeshIndex  // 0x14
  public            System.Int32                    sharedRenderMeshVertexStartIndex  // 0x18
  public            System.Int32                    meshUseCount  // 0x1C
  public            Unity.Mathematics.int4          childMeshVertexStartIndex  // 0x20
  public            Unity.Mathematics.int4          childMeshWeightStartIndex  // 0x30
  public            Unity.Mathematics.int4          virtualMeshVertexStartIndex  // 0x40
  public            Unity.Mathematics.int4          sharedVirtualMeshVertexStartIndex  // 0x50
  public            Unity.Mathematics.int4          linkMeshCount  // 0x60
  public            MagicaCloth.ChunkData           vertexChunk  // 0x70
  public            MagicaCloth.ChunkData           boneWeightsChunk  // 0x80
  public            System.Int32                    transformIndex  // 0x90
  public            System.Single                   baseScale  // 0x94
METHODS:
  System.Boolean IsFlag(System.UInt32 flag)
  System.Void SetFlag(System.UInt32 flag, System.Boolean sw)
  System.Boolean IsActive()
  System.Boolean IsUse()
  System.Boolean IsLinkMesh(System.Int32 index)
  System.Boolean IsPause()
  System.Boolean IsFasterWrite()
  System.Boolean IsSkinning()
  System.Boolean AddLinkMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart)
  System.Boolean RemoveLinkMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart)
END_CLASS

CLASS: RenderMeshState
TYPE:  class
TOKEN: 0x20000B9
FIELDS:
  public            System.UInt32                   flag  // 0x10
  public            System.Int32                    RenderSharedMeshIndex  // 0x14
  public            System.Int32                    RenderSharedMeshId  // 0x18
  public            System.Int32                    VertexChunkStart  // 0x1C
  public            System.Int32                    VertexChunkLength  // 0x20
  public            System.Int32                    BoneWeightChunkStart  // 0x24
  public            System.Int32                    BoneWeightChunkLength  // 0x28
METHODS:
  System.Boolean IsFlag(System.UInt32 flag)
  System.Void SetFlag(System.UInt32 flag, System.Boolean sw)
  System.Void .ctor()
END_CLASS

CLASS: CopyRenderBuffer
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderPosList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderNormalList  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderPosArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderNormalArray  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: ParticleFlag
TYPE:  struct
TOKEN: 0x20000BD
FIELDS:
  public            System.UInt32                   flag  // 0x10
METHODS:
  System.Void .ctor(System.UInt32[] flags)
  System.Boolean IsFlag(System.UInt32 flag)
  System.Void SetFlag(System.UInt32 flag, System.Boolean sw)
  System.Boolean IsValid()
  System.Void SetEnable(System.Boolean sw)
  System.Boolean IsFixed()
  System.Boolean IsMove()
  System.Boolean IsKinematic()
  System.Boolean IsHold()
  System.Boolean IsCollider()
  System.Boolean IsReadTransform()
  System.Boolean IsWriteTransform()
  System.Boolean IsRestoreTransform()
  System.Boolean IsUnityPhysics()
  System.Boolean IsReadSclTransform()
  System.Boolean IsParentTransform()
END_CLASS

CLASS: CopyBoneToParticleJob
TYPE:  struct
TOKEN: 0x20000BE
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamData  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WorldInfluence>teamWorldInfluenceList  // 0x20
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x30
  public            Unity.Collections.NativeArray<System.Single>depthList  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>transformIndexList  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPosList  // 0x60
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityList  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneSclList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosList  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotList  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldSlowPosList  // 0xF0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0x100
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>snapBasePosList  // 0x110
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>snapBaseRotList  // 0x120
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldBasePosList  // 0x130
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldBaseRotList  // 0x140
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x150
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: ResetParticleJob
TYPE:  struct
TOKEN: 0x20000BF
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamData  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>snapBasePosList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>snapBaseRotList  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldBasePosList  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldBaseRotList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosList  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotList  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldSlowPosList  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityList  // 0xF0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosList  // 0x100
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nextRotList  // 0x110
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPosList  // 0x120
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: CopyParticleToBoneJob
TYPE:  struct
TOKEN: 0x20000C0
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneBasePosList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneBaseRotList  // 0x50
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x60
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x70
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32>transformParticleIndexMap  // 0x80
  public            Unity.Collections.NativeArray<System.Int32>writeBoneIndexList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0xB0
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: ForceMode
TYPE:  struct
TOKEN: 0x20000C2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.PhysicsManagerTeamData.ForceModeNone  // 0x0
  public    static  MagicaCloth.PhysicsManagerTeamData.ForceModeVelocityAdd  // 0x0
  public    static  MagicaCloth.PhysicsManagerTeamData.ForceModeVelocityChange  // 0x0
  public    static  MagicaCloth.PhysicsManagerTeamData.ForceModeVelocityAddWithoutMass  // 0x0
  public    static  MagicaCloth.PhysicsManagerTeamData.ForceModeVelocityChangeWithoutMass  // 0x0
METHODS:
END_CLASS

CLASS: TeamData
TYPE:  struct
TOKEN: 0x20000C3
FIELDS:
  public            MagicaCloth.ChunkData           particleChunk  // 0x10
  public            MagicaCloth.ChunkData           colliderChunk  // 0x20
  public            MagicaCloth.ChunkData           skinningBoneChunk  // 0x30
  public            System.UInt32                   flag  // 0x40
  public            System.Single                   dynamicFriction  // 0x44
  public            System.Single                   staticFriction  // 0x48
  public            System.Single                   selfCollisionRange  // 0x4C
  public            System.Int32                    boneIndex  // 0x50
  public            Unity.Mathematics.float3        initScale  // 0x54
  public            System.Single                   scaleRatio  // 0x60
  public            Unity.Mathematics.float3        scaleDirection  // 0x64
  public            Unity.Mathematics.float4        quaternionScale  // 0x70
  public            System.Single                   time  // 0x80
  public            System.Single                   oldTime  // 0x84
  public            System.Single                   addTime  // 0x88
  public            System.Single                   timeScale  // 0x8C
  public            System.Single                   nowTime  // 0x90
  public            System.Single                   startTime  // 0x94
  public            System.Int32                    updateCount  // 0x98
  public            System.Single                   blendRatio  // 0x9C
  public            System.Single                   outPhysicsPoseBlendRatio  // 0xA0
  public            Unity.Mathematics.float3        externalForce  // 0xA4
  public            System.Single                   forceMassInfluence  // 0xB0
  public            System.Single                   forceWindInfluence  // 0xB4
  public            System.Single                   forceWindRandomScale  // 0xB8
  public            System.Single                   forceWindSynchronization  // 0xBC
  public            System.Single                   velocityWeight  // 0xC0
  public            System.Single                   velocityRecoverySpeed  // 0xC4
  public            Unity.Mathematics.float3        gravityDirection  // 0xC8
  public            MagicaCloth.PhysicsManagerTeamData.ForceModeforceMode  // 0xD4
  public            Unity.Mathematics.float3        impactForce  // 0xD8
  public            System.Int32                    calcCount  // 0xE4
  public            System.Int16                    restoreDistanceGroupIndex  // 0xE8
  public            System.Int16                    triangleBendGroupIndex  // 0xEA
  public            System.Int16                    clampDistanceGroupIndex  // 0xEC
  public            System.Int16                    clampDistance2GroupIndex  // 0xEE
  public            System.Int16                    clampPositionGroupIndex  // 0xF0
  public            System.Int16                    clampRotationGroupIndex  // 0xF2
  public            System.Int16                    restoreRotationGroupIndex  // 0xF4
  public            System.Int16                    adjustRotationGroupIndex  // 0xF6
  public            System.Int16                    springGroupIndex  // 0xF8
  public            System.Int16                    volumeGroupIndex  // 0xFA
  public            System.Int16                    airLineGroupIndex  // 0xFC
  public            System.Int16                    lineWorkerGroupIndex  // 0xFE
  public            System.Int16                    triangleWorkerGroupIndex  // 0x100
  public            System.Int16                    selfCollisionGroupIndex  // 0x102
  public            System.Int16                    edgeCollisionGroupIndex  // 0x104
  public            System.Int16                    penetrationGroupIndex  // 0x106
  public            System.Int16                    baseSkinningGroupIndex  // 0x108
  public            System.Int16                    twistGroupIndex  // 0x10A
  public            System.Int16                    compositeRotationGroupIndex  // 0x10C
METHODS:
  System.Boolean IsActive()
  System.Boolean IsRunning()
  System.Boolean IsUpdate(System.Int32 runCount)
  System.Boolean IsInterpolate()
  System.Boolean IsPhysicsUpdate()
  System.Boolean IsFlag(System.UInt32 flag)
  System.Void SetFlag(System.UInt32 flag, System.Boolean sw)
  System.Boolean IsReset()
  System.Boolean IsPause()
END_CLASS

CLASS: WorldInfluence
TYPE:  struct
TOKEN: 0x20000C4
FIELDS:
  public            MagicaCloth.CurveParam          moveInfluence  // 0x10
  public            MagicaCloth.CurveParam          rotInfluence  // 0x20
  public            System.Single                   maxMoveSpeed  // 0x30
  public            System.Single                   maxRotationSpeed  // 0x34
  public            Unity.Mathematics.float3        nowPosition  // 0x38
  public            Unity.Mathematics.float3        oldPosition  // 0x44
  public            Unity.Mathematics.float3        moveOffset  // 0x50
  public            System.Single                   moveIgnoreRatio  // 0x5C
  public            Unity.Mathematics.quaternion    nowRotation  // 0x60
  public            Unity.Mathematics.quaternion    oldRotation  // 0x70
  public            Unity.Mathematics.quaternion    rotationOffset  // 0x80
  public            System.Single                   rotationIgnoreRatio  // 0x90
  public            System.Int32                    resetTeleport  // 0x94
  public            System.Single                   teleportDistance  // 0x98
  public            System.Single                   teleportRotation  // 0x9C
  public            MagicaCloth.ClothParams.TeleportModeteleportMode  // 0xA0
  public            System.Single                   stabilizationTime  // 0xA4
  public            System.Single                   clampRotationLimit  // 0xA8
METHODS:
END_CLASS

CLASS: WindInfo
TYPE:  struct
TOKEN: 0x20000C5
FIELDS:
  public            System.Int32                    windCount  // 0x10
  public            Unity.Mathematics.int4          windDataIndexList  // 0x14
  public            Unity.Mathematics.float3x4      windDirectionList  // 0x24
  public            Unity.Mathematics.float4        windMainList  // 0x54
METHODS:
END_CLASS

CLASS: PreProcessTeamDataJob
TYPE:  struct
TOKEN: 0x20000C6
FIELDS:
  public            System.Single                   deltaTime  // 0x10
  public            System.Single                   physicsDeltaTime  // 0x14
  public            System.Single                   updateDeltaTime  // 0x18
  public            System.Single                   globalTimeScale  // 0x1C
  public            System.Int32                    maxUpdateCount  // 0x20
  public            System.Single                   unityTimeScale  // 0x24
  public            System.Single                   elapsedTime  // 0x28
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamData  // 0x30
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WorldInfluence>teamWorldInfluenceList  // 0x40
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WindInfo>teamWindInfoList  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneSclList  // 0x80
  public            System.Int32                    windCount  // 0x90
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerWindData.WindData>windData  // 0x98
METHODS:
  System.Void Execute(System.Int32 teamId)
  System.Void UpdateTime(MagicaCloth.PhysicsManagerTeamData.TeamData& tdata, System.Boolean reset, System.Single dtime)
  System.Void Wind(MagicaCloth.PhysicsManagerTeamData.TeamData& tdata, Unity.Mathematics.float3 pos, System.Int32 teamId)
END_CLASS

CLASS: PostProcessTeamDataJob
TYPE:  struct
TOKEN: 0x20000C7
FIELDS:
  public            System.Int32                    fixedUpdateCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamData  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WorldInfluence>teamWorldInfluenceList  // 0x28
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: WindType
TYPE:  struct
TOKEN: 0x20000CA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.PhysicsManagerWindData.WindTypeNone  // 0x0
  public    static  MagicaCloth.PhysicsManagerWindData.WindTypeDirection  // 0x0
  public    static  MagicaCloth.PhysicsManagerWindData.WindTypeArea  // 0x0
METHODS:
END_CLASS

CLASS: ShapeType
TYPE:  struct
TOKEN: 0x20000CB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.PhysicsManagerWindData.ShapeTypeBox  // 0x0
  public    static  MagicaCloth.PhysicsManagerWindData.ShapeTypeSphere  // 0x0
METHODS:
END_CLASS

CLASS: DirectionType
TYPE:  struct
TOKEN: 0x20000CC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.PhysicsManagerWindData.DirectionTypeOneDirection  // 0x0
  public    static  MagicaCloth.PhysicsManagerWindData.DirectionTypeRadial  // 0x0
METHODS:
END_CLASS

CLASS: WindData
TYPE:  struct
TOKEN: 0x20000CD
FIELDS:
  public            System.UInt32                   flag  // 0x10
  public            MagicaCloth.PhysicsManagerWindData.WindTypewindType  // 0x14
  public            MagicaCloth.PhysicsManagerWindData.ShapeTypeshapeType  // 0x18
  public            System.Int32                    transformIndex  // 0x1C
  public            Unity.Mathematics.float3        areaSize  // 0x20
  public            System.Single                   main  // 0x2C
  public            System.Single                   turbulence  // 0x30
  public            System.Single                   frequency  // 0x34
  public            Unity.Mathematics.float3        direction  // 0x38
  public            MagicaCloth.PhysicsManagerWindData.DirectionTypedirectionType  // 0x44
  public            System.Single                   areaVolume  // 0x48
  public            System.Single                   areaLength  // 0x4C
  public            MagicaCloth.CurveParam          attenuation  // 0x50
METHODS:
  System.Boolean IsFlag(System.UInt32 flag)
  System.Void SetFlag(System.UInt32 flag, System.Boolean sw)
  System.Void SetEnable(System.Boolean sw)
  System.Boolean IsActive()
END_CLASS

CLASS: Axis
TYPE:  struct
TOKEN: 0x20000D1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.MagicaCapsuleCollider.AxisX  // 0x0
  public    static  MagicaCloth.MagicaCapsuleCollider.AxisY  // 0x0
  public    static  MagicaCloth.MagicaCapsuleCollider.AxisZ  // 0x0
METHODS:
END_CLASS

CLASS: TeamUpdateMode
TYPE:  struct
TOKEN: 0x20000D6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.PhysicsTeam.TeamUpdateModeNormal  // 0x0
  public    static  MagicaCloth.PhysicsTeam.TeamUpdateModeUnityPhysics  // 0x0
METHODS:
END_CLASS

CLASS: TeamCullingMode
TYPE:  struct
TOKEN: 0x20000D7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.PhysicsTeam.TeamCullingModeReset  // 0x0
  public    static  MagicaCloth.PhysicsTeam.TeamCullingModePause  // 0x0
  public    static  MagicaCloth.PhysicsTeam.TeamCullingModeOff  // 0x0
METHODS:
END_CLASS

CLASS: TeamSkinningMode
TYPE:  struct
TOKEN: 0x20000D8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.PhysicsTeam.TeamSkinningModeNone  // 0x0
  public    static  MagicaCloth.PhysicsTeam.TeamSkinningModeUserAnimation  // 0x0
METHODS:
END_CLASS

CLASS: AdjustRotationData
TYPE:  struct
TOKEN: 0x20000DB
FIELDS:
  public            System.Int32                    keyIndex  // 0x10
  public            System.Int32                    targetIndex  // 0x14
  public            Unity.Mathematics.float3        localPos  // 0x18
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x20000DC
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            System.Int32                    adjustMode  // 0x18
  public            Unity.Mathematics.float3        axisRotationPower  // 0x1C
  public            MagicaCloth.ChunkData           chunk  // 0x28
METHODS:
END_CLASS

CLASS: AdjustRotationJob
TYPE:  struct
TOKEN: 0x20000DD
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.AdjustRotationWorker.AdjustRotationData>dataList  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.AdjustRotationWorker.GroupData>groupList  // 0x20
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32>particleMap  // 0x30
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x50
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>snapBasePosList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>snapBaseRotList  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0xA0
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: BaseSkinningData
TYPE:  struct
TOKEN: 0x20000DF
FIELDS:
  public            Unity.Mathematics.float3        localPos  // 0x10
  public            Unity.Mathematics.float3        localNor  // 0x1C
  public            Unity.Mathematics.float3        localTan  // 0x28
  public            Unity.Mathematics.int4          boneIndices  // 0x34
  public            Unity.Mathematics.float4        weights  // 0x44
  public            System.Int16                    weightCount  // 0x54
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x20000E0
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    active  // 0x14
  public            System.Int32                    updateFixed  // 0x18
  public            MagicaCloth.ChunkData           dataChunk  // 0x1C
  public            MagicaCloth.ChunkData           bindPoseChunk  // 0x2C
METHODS:
END_CLASS

CLASS: BaseSkinningJob
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.BaseSkinningWorker.GroupData>groupList  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.BaseSkinningWorker.BaseSkinningData>dataList  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4x4>bindPoseList  // 0x30
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>skinningBoneList  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>bonePosList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>boneRotList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>boneSclList  // 0x80
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x90
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>snapBasePosList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>snapBaseRotList  // 0xC0
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: LineRotationData
TYPE:  struct
TOKEN: 0x20000E3
FIELDS:
  public            System.Int32                    vertexIndex  // 0x10
  public            System.Int32                    childCount  // 0x14
  public            System.Int32                    childStartDataIndex  // 0x18
  public            Unity.Mathematics.float3        localPos  // 0x1C
  public            Unity.Mathematics.quaternion    localRot  // 0x28
METHODS:
END_CLASS

CLASS: LineRotationRootInfo
TYPE:  struct
TOKEN: 0x20000E4
FIELDS:
  public            System.UInt16                   startIndex  // 0x10
  public            System.UInt16                   dataLength  // 0x12
METHODS:
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    avarage  // 0x14
  public            MagicaCloth.ChunkData           dataChunk  // 0x18
  public            MagicaCloth.ChunkData           rootInfoChunk  // 0x28
METHODS:
END_CLASS

CLASS: LineRotationJob
TYPE:  struct
TOKEN: 0x20000E6
FIELDS:
  public            System.Int32                    fixedUpdateCount  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.LineWorker.LineRotationData>dataList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.LineWorker.LineRotationRootInfo>rootInfoList  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>rootTeamList  // 0x38
  public            Unity.Collections.NativeArray<MagicaCloth.LineWorker.GroupData>groupList  // 0x48
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0x88
METHODS:
  System.Void Execute(System.Int32 rootIndex)
END_CLASS

CLASS: CreateData
TYPE:  struct
TOKEN: 0x20000E8
FIELDS:
  public            System.Int32                    vertexIndex  // 0x10
  public            System.Int32                    particleIndex  // 0x14
METHODS:
END_CLASS

CLASS: VertexToParticleJob
TYPE:  struct
TOKEN: 0x20000E9
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo>virtualMeshInfoList  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>vertexToParticleList  // 0x20
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32>vertexToParticleMap  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0x50
  public            Unity.Collections.NativeArray<System.Int16>virtualVertexMeshIndexList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>snapBasePosList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>snapBaseRotList  // 0x80
  private           Unity.Collections.NativeParallelMultiHashMapIterator<System.Int32>iterator  // 0x90
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: ParticleToVertexJob
TYPE:  struct
TOKEN: 0x20000EA
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>vertexToParticleList  // 0x10
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32>vertexToParticleMap  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualPosList  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>virtualRotList  // 0x40
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexFlagList  // 0x50
  public            Unity.Collections.NativeArray<System.Int16>virtualVertexMeshIndexList  // 0x60
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo>virtualMeshInfoList  // 0x70
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x80
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x90
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>particleFlagList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>particlePosList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>particleRotList  // 0xC0
  private           Unity.Collections.NativeParallelMultiHashMapIterator<System.Int32>iterator  // 0xD0
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: CalcVertexUseFlagJob
TYPE:  struct
TOKEN: 0x20000EC
FIELDS:
  public            System.UInt32                   updateFlag  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo>renderMeshInfoList  // 0x18
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedRenderMeshInfo>sharedRenderMeshInfoList  // 0x28
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexUseList  // 0x38
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexFixList  // 0x48
  public            Unity.Collections.NativeArray<System.UInt32>sharedChildVertexInfoList  // 0x58
  public            Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight>sharedChildVertexWeightList  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>sharedRenderVertices  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>sharedRenderNormals  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4>sharedRenderTangents  // 0x98
  public            Unity.Collections.NativeArray<System.Byte>sharedBonesPerVertexList  // 0xA8
  public            Unity.Collections.NativeArray<System.Int32>sharedBonesPerVertexStartList  // 0xB8
  public            Unity.Collections.NativeArray<UnityEngine.BoneWeight1>sharedBoneWeightList  // 0xC8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderPosList  // 0xD8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderNormalList  // 0xE8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4>renderTangentList  // 0xF8
  public            Unity.Collections.NativeArray<UnityEngine.BoneWeight1>renderBoneWeightList  // 0x108
  public            Unity.Collections.NativeArray<System.UInt32>renderVertexFlagList  // 0x118
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderPosArray  // 0x128
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderNormalArray  // 0x138
METHODS:
  System.Void Execute(System.Int32 rmindex)
END_CLASS

CLASS: CollectLocalPositionNormalTangentForEachMeshJob
TYPE:  struct
TOKEN: 0x20000ED
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo>renderMeshInfoList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPosList  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotList  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformSclList  // 0x40
  public            Unity.Collections.NativeArray<System.UInt32>sharedChildVertexInfoList  // 0x50
  public            Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight>sharedChildVertexWeightList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualPosList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>virtualRotList  // 0x80
  public            Unity.Collections.NativeArray<System.UInt32>renderVertexFlagList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderPosList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderNormalList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4>renderTangentList  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderPosArray  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderNormalArray  // 0xE0
METHODS:
  System.Void Execute(System.Int32 rmindex)
END_CLASS

CLASS: CollectLocalPositionNormalTangentForEachVertexJob
TYPE:  struct
TOKEN: 0x20000EE
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo>renderMeshInfoList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPosList  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotList  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformSclList  // 0x40
  public            Unity.Collections.NativeArray<System.UInt32>sharedChildVertexInfoList  // 0x50
  public            Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight>sharedChildVertexWeightList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualPosList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>virtualRotList  // 0x80
  public            Unity.Collections.NativeArray<System.UInt32>renderVertexFlagList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderPosList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderNormalList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4>renderTangentList  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderPosArray  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>renderNormalArray  // 0xE0
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: SpringData
TYPE:  struct
TOKEN: 0x20000F0
FIELDS:
  public            System.Int32                    particleIndex  // 0x10
  public            System.Single                   weight  // 0x14
METHODS:
END_CLASS

CLASS: SpringJob
TYPE:  struct
TOKEN: 0x20000F1
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>springVertexList  // 0x10
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,MagicaCloth.SpringMeshWorker.SpringData>springMap  // 0x20
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>particlePosList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>particleRotList  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>snapBasePosList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>snapBaseRotList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualPosList  // 0x80
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexFlagList  // 0x90
  public            Unity.Collections.NativeArray<System.Int16>virtualVertexMeshIndexList  // 0xA0
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo>virtualMeshInfoList  // 0xB0
  private           Unity.Collections.NativeParallelMultiHashMapIterator<System.Int32>iterator  // 0xC0
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: TriangleRotationData
TYPE:  struct
TOKEN: 0x20000F3
FIELDS:
  public            System.Int32                    targetIndex  // 0x10
  public            System.Int32                    triangleCount  // 0x14
  public            System.Int32                    triangleStartIndex  // 0x18
  public            Unity.Mathematics.quaternion    localRot  // 0x1C
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: GroupData
TYPE:  struct
TOKEN: 0x20000F4
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            MagicaCloth.ChunkData           triangleDataChunk  // 0x14
  public            MagicaCloth.ChunkData           triangleIndexChunk  // 0x24
METHODS:
END_CLASS

CLASS: TriangleRotationJob
TYPE:  struct
TOKEN: 0x20000F5
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.TriangleWorker.TriangleRotationData>triangleDataList  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>triangleIndexList  // 0x20
  public            Unity.Collections.NativeArray<MagicaCloth.TriangleWorker.GroupData>groupList  // 0x30
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>teamIdList  // 0x50
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>posList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotList  // 0x80
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: ReadMeshPositionJob
TYPE:  struct
TOKEN: 0x20000F7
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo>virtualMeshInfoList  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo>sharedVirtualMeshInfoList  // 0x20
  public            Unity.Collections.NativeArray<System.Int16>virtualVertexMeshIndexList  // 0x30
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexUseList  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>virtualTransformIndexList  // 0x50
  public            Unity.Collections.NativeArray<System.UInt32>sharedVirtualVertexInfoList  // 0x60
  public            Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight>sharedVirtualWeightList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPosList  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformSclList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualPosList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>virtualRotList  // 0xC0
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexFlagList  // 0xD0
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: CalcMeshTriangleNormalTangentJob
TYPE:  struct
TOKEN: 0x20000F8
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo>virtualMeshInfoList  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo>sharedVirtualMeshInfoList  // 0x20
  public            Unity.Collections.NativeArray<System.UInt16>virtualTriangleMeshIndexList  // 0x30
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexUseList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualPosList  // 0x50
  public            Unity.Collections.NativeArray<System.Int32>sharedTriangles  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>sharedMeshUv  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualTriangleNormalList  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualTriangleTangentList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformSclList  // 0xA0
METHODS:
  System.Void Execute(System.Int32 tindex)
END_CLASS

CLASS: CalcVertexNormalTangentFromTriangleJob
TYPE:  struct
TOKEN: 0x20000F9
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo>virtualMeshInfoList  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo>sharedVirtualMeshInfoList  // 0x20
  public            Unity.Collections.NativeArray<System.Int16>virtualVertexMeshIndexList  // 0x30
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexUseList  // 0x40
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexFlagList  // 0x50
  public            Unity.Collections.NativeArray<System.UInt32>sharedVirtualVertexToTriangleInfoList  // 0x60
  public            Unity.Collections.NativeArray<System.Int32>sharedVirtualVertexToTriangleIndexList  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualTriangleNormalList  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualTriangleTangentList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>virtualRotList  // 0xA0
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: CalcMeshTriangleNormalTangentForEachMeshJob
TYPE:  struct
TOKEN: 0x20000FA
FIELDS:
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo>virtualMeshInfoList  // 0x10
  public            Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo>sharedVirtualMeshInfoList  // 0x20
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexUseList  // 0x30
  public            Unity.Collections.NativeArray<System.Byte>virtualVertexFlagList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualPosList  // 0x50
  public            Unity.Collections.NativeArray<System.Int32>sharedTriangles  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>sharedMeshUv  // 0x70
  public            Unity.Collections.NativeArray<System.UInt32>sharedVirtualVertexToTriangleInfoList  // 0x80
  public            Unity.Collections.NativeArray<System.Int32>sharedVirtualVertexToTriangleIndexList  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformSclList  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualTriangleNormalList  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>virtualTriangleTangentList  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>virtualRotList  // 0xD0
METHODS:
  System.Void Execute(System.Int32 mindex)
END_CLASS

CLASS: MoveMode
TYPE:  struct
TOKEN: 0x2000100
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.CameraOrbit.MoveModeNone  // 0x0
  public    static  MagicaCloth.CameraOrbit.MoveModeUpDown  // 0x0
  public    static  MagicaCloth.CameraOrbit.MoveModeFree  // 0x0
METHODS:
END_CLASS

CLASS: AvatarPartsGroup
TYPE:  class
TOKEN: 0x2000104
FIELDS:
  public            System.String                   groupName  // 0x10
  public            System.Collections.Generic.List<UnityEngine.GameObject>partsPrefabList  // 0x18
  public            System.Int32                    id  // 0x20
  public            System.Int32                    handle  // 0x24
  public            System.Int32                    index  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Point
TYPE:  class
TOKEN: 0x2000116
FIELDS:
  public            System.Int32                    id  // 0x10
  public            Unity.Mathematics.float3        pos  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TetraVertex
TYPE:  class
TOKEN: 0x2000128
FIELDS:
  public            System.Int32                    index  // 0x10
  public            UnityEngine.Vector3             pos  // 0x14
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Vector3 pos, System.Int32 index)
END_CLASS

CLASS: Tetra
TYPE:  class
TOKEN: 0x2000129
FIELDS:
  public            System.Collections.Generic.List<MagicaCloth.MeshUtility.TetraVertex>vertexList  // 0x10
  public            UnityEngine.Vector3             circumCenter  // 0x18
  public            System.Single                   circumRadius  // 0x24
  public            UnityEngine.Vector3             tetraCenter  // 0x28
  public            System.Single                   tetraSize  // 0x34
METHODS:
  System.Void .ctor()
  System.Void .ctor(MagicaCloth.MeshUtility.TetraVertex a, MagicaCloth.MeshUtility.TetraVertex b, MagicaCloth.MeshUtility.TetraVertex c, MagicaCloth.MeshUtility.TetraVertex d)
  System.UInt64 GetTetraHash()
  System.Void CalcCircumcircle()
  System.Boolean IntersectCircumcircle(UnityEngine.Vector3 pos)
  System.Boolean CheckSame(MagicaCloth.MeshUtility.Tetra tri)
  System.Boolean ContainsPoint(MagicaCloth.MeshUtility.TetraVertex p1)
  System.Boolean ContainsPoint(MagicaCloth.MeshUtility.TetraVertex p1, MagicaCloth.MeshUtility.TetraVertex p2, MagicaCloth.MeshUtility.TetraVertex p3, MagicaCloth.MeshUtility.TetraVertex p4)
  System.Void CalcSize()
  System.Boolean Verification()
END_CLASS

CLASS: UpdateCount
TYPE:  struct
TOKEN: 0x200012C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.UpdateTimeManager.UpdateCount_60  // 0x0
  public    static  MagicaCloth.UpdateTimeManager.UpdateCount_90_Default  // 0x0
  public    static  MagicaCloth.UpdateTimeManager.UpdateCount_120  // 0x0
  public    static  MagicaCloth.UpdateTimeManager.UpdateCount_150  // 0x0
  public    static  MagicaCloth.UpdateTimeManager.UpdateCount_180  // 0x0
METHODS:
END_CLASS

CLASS: UpdateMode
TYPE:  struct
TOKEN: 0x200012D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.UpdateTimeManager.UpdateModeUnscaledTime  // 0x0
  public    static  MagicaCloth.UpdateTimeManager.UpdateModeOncePerFrame  // 0x0
  public    static  MagicaCloth.UpdateTimeManager.UpdateModeDelayUnscaledTime  // 0x0
METHODS:
END_CLASS

CLASS: UpdateLocation
TYPE:  struct
TOKEN: 0x200012E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.UpdateTimeManager.UpdateLocationAfterLateUpdate  // 0x0
  public    static  MagicaCloth.UpdateTimeManager.UpdateLocationBeforeLateUpdate  // 0x0
METHODS:
END_CLASS

CLASS: MagicaCloth.BaseCloth
TYPE:  class
TOKEN: 0x2000025
EXTENDS: PhysicsTeam
FIELDS:
  protected         MagicaCloth.ClothParams         clothParams  // 0x78
  protected         System.Collections.Generic.List<System.Int32>clothParamDataHashList  // 0x80
  private           MagicaCloth.ClothData           clothData  // 0x88
  protected         System.Int32                    clothDataHash  // 0x90
  protected         System.Int32                    clothDataVersion  // 0x94
  private           MagicaCloth.SelectionData       clothSelection  // 0x98
  private           System.Int32                    clothSelectionHash  // 0xA0
  private           System.Int32                    clothSelectionVersion  // 0xA4
  private           System.Collections.Generic.List<UnityEngine.Renderer>cullRendererList  // 0xA8
  protected         MagicaCloth.ClothSetup          setup  // 0xB0
  private           System.Single                   oldBlendRatio  // 0xB8
  private           MagicaCloth.PhysicsTeam.TeamUpdateModeoldUpdateMode  // 0xBC
  private           MagicaCloth.PhysicsTeam.TeamCullingModeoldCullingMode  // 0xC0
  private           System.Boolean                  oldUseAnimatedDistance  // 0xC4
METHODS:
  System.Void ResetCloth()
  System.Void ResetCloth(System.Single resetStabilizationTime)
  System.Void ResetCloth(MagicaCloth.ClothParams.TeleportMode teleportMode, System.Single resetStabilizationTime)
  System.Void SetTimeScale(System.Single timeScale)
  System.Single GetTimeScale()
  System.Void AddForce(UnityEngine.Vector3 force, MagicaCloth.PhysicsManagerTeamData.ForceMode mode)
  System.Single get_BlendWeight()
  System.Void set_BlendWeight(System.Single value)
  System.Void AddCollider(MagicaCloth.ColliderComponent collider)
  System.Void RemoveCollider(MagicaCloth.ColliderComponent collider)
  System.Void SetUpdateMode(MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode)
  System.Void SetCullingMode(MagicaCloth.PhysicsTeam.TeamCullingMode cullingMode)
  System.Void Radius_SetRadius(System.Single startVal, System.Single endVal, System.Single curveVal)
  System.Void Mass_SetMass(System.Single startVal, System.Single endVal, System.Single curveVal)
  System.Void ClampPosition_SetPositionLength(System.Single startVal, System.Single endVal, System.Single curveVal)
  System.Void Gravity_SetGravity(System.Single startVal, System.Single endVal, System.Single curveVal)
  UnityEngine.Vector3 get_Gravity_GravityDirection()
  System.Void set_Gravity_GravityDirection(UnityEngine.Vector3 value)
  System.Void Drag_SetDrag(System.Single startVal, System.Single endVal, System.Single curveVal)
  System.Boolean get_DistanceDisable_Active()
  System.Void set_DistanceDisable_Active(System.Boolean value)
  UnityEngine.Transform get_DistanceDisable_ReferenceObject()
  System.Void set_DistanceDisable_ReferenceObject(UnityEngine.Transform value)
  System.Single get_DistanceDisable_Distance()
  System.Void set_DistanceDisable_Distance(System.Single value)
  System.Single get_DistanceDisable_FadeDistance()
  System.Void set_DistanceDisable_FadeDistance(System.Single value)
  System.Void ExternalForce_DepthInfluence(System.Single startVal, System.Single endVal, System.Single curveVal)
  System.Single get_ExternalForce_WindInfluence()
  System.Void set_ExternalForce_WindInfluence(System.Single value)
  System.Single get_ExternalForce_WindRandomScale()
  System.Void set_ExternalForce_WindRandomScale(System.Single value)
  System.Void WorldInfluence_SetMovementInfluence(System.Single startVal, System.Single endVal, System.Single curveVal)
  System.Void WorldInfluence_SetRotationInfluence(System.Single startVal, System.Single endVal, System.Single curveVal)
  System.Single get_WorldInfluence_MaxMoveSpeed()
  System.Void set_WorldInfluence_MaxMoveSpeed(System.Single value)
  System.Boolean get_WorldInfluence_ResetAfterTeleport()
  System.Void set_WorldInfluence_ResetAfterTeleport(System.Boolean value)
  System.Single get_WorldInfluence_TeleportDistance()
  System.Void set_WorldInfluence_TeleportDistance(System.Single value)
  System.Single get_WorldInfluence_TeleportRotation()
  System.Void set_WorldInfluence_TeleportRotation(System.Single value)
  MagicaCloth.ClothParams.TeleportMode get_WorldInfluence_TeleportMode()
  System.Void set_WorldInfluence_TeleportMode(MagicaCloth.ClothParams.TeleportMode value)
  System.Single get_WorldInfluence_StabilizationTime()
  System.Void set_WorldInfluence_StabilizationTime(System.Single value)
  System.Void WorldInfluence_ReplaceInfluenceTarget(UnityEngine.Transform target)
  System.Boolean get_ColliderCollision_Active()
  System.Void set_ColliderCollision_Active(System.Boolean value)
  System.Boolean get_Penetration_Active()
  System.Void set_Penetration_Active(System.Boolean value)
  System.Void Penetration_SetMovingRadius(System.Single startVal, System.Single endVal, System.Single curveVal)
  System.Boolean get_Spring_Active()
  System.Void set_Spring_Active(System.Boolean value)
  System.Single get_Spring_Power()
  System.Void set_Spring_Power(System.Single value)
  System.Int32 GetDataHash()
  MagicaCloth.ClothParams get_Params()
  MagicaCloth.ClothData get_ClothData()
  System.Void set_ClothData(MagicaCloth.ClothData value)
  MagicaCloth.SelectionData get_ClothSelection()
  MagicaCloth.ClothSetup get_Setup()
  System.Void Reset()
  System.Void OnValidate()
  System.Void OnInit()
  System.Void OnActive()
  System.Void OnInactive()
  System.Void OnDispose()
  System.Void UpdateCullingMode(MagicaCloth.CoreComponent caller)
  System.Void OnChangeCalculation()
  System.Int32 GetCullRenderListCount()
  System.Void BaseClothInit()
  System.Void BaseClothDispose()
  System.Void ClothInit()
  System.Void ClothActive()
  System.Void ClothInactive()
  System.Void ClothDispose()
  System.UInt32 UserFlag(System.Int32 vindex)
  UnityEngine.Transform UserTransform(System.Int32 vindex)
  Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex)
  Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex)
  System.Boolean IsRequiresDeformer()
  MagicaCloth.BaseMeshDeformer GetDeformer()
  MagicaCloth.MeshData GetMeshData()
  System.Void WorkerInit()
  System.Void SetUseMesh(System.Boolean sw)
  System.Void SetUseVertex(System.Boolean sw)
  System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer)
  System.Void DeformerForEach(System.Action<MagicaCloth.BaseMeshDeformer> act)
  System.Void UpdateBlend()
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.Boolean HasChangedParam(MagicaCloth.ClothParams.ParamType ptype)
  MagicaCloth.Define.Error VerifyAlgorithmVersion()
  System.Boolean UpgradeFormat()
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
  System.Void ResetClothInternal(MagicaCloth.ClothParams.TeleportMode teleportMode, System.Single resetStabilizationTime)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.CoreComponent
TYPE:  class
TOKEN: 0x2000027
EXTENDS: BaseComponent
FIELDS:
  protected         System.Int32                    dataHash  // 0x18
  protected         System.Int32                    dataVersion  // 0x1C
  protected         MagicaCloth.RuntimeStatus       status  // 0x20
  private           System.Int32                    useUnityPhysicsCount  // 0x28
  private           System.Boolean                  nowUseUnityPhysics  // 0x2C
  private           System.Boolean                  <IsVisible>k__BackingField  // 0x2D
  protected         System.Int32                    calculateValue  // 0x30
METHODS:
  System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> GetUsedComponentBones()
  System.Collections.Generic.List<System.String> GetUsedComponentBoneNames()
  System.Void ReplaceComponentBone(System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneReplaceDict)
  System.Void ReplaceComponentBone(System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> boneReplaceDict)
  MagicaCloth.RuntimeStatus get_Status()
  System.Boolean get_IsVisible()
  System.Void set_IsVisible(System.Boolean value)
  System.Boolean get_IsCalculate()
  System.Int32 GetDataHash()
  System.Int32 get_SaveDataHash()
  System.Int32 get_SaveDataVersion()
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Init()
  System.Void OnInit()
  System.Void OnDispose()
  System.Void OnUpdate()
  System.Void OnActive()
  System.Void OnInactive()
  System.Void OnUpdateStatus()
  System.Void OnDisconnectedStatus()
  System.Void SetUseUnityPhysics(System.Boolean sw)
  System.Void ActiveUseUnityPhysics()
  System.Void InactiveUseUnityPhysics()
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Boolean IsUseUnityPhysics()
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
  System.Void SetUserEnable(System.Boolean sw)
  System.Void UpdateCullingMode(MagicaCloth.CoreComponent Caller)
  System.Void OnChangeCalculation()
  System.Int32 GetVersion()
  System.Int32 GetErrorVersion()
  MagicaCloth.Define.Error VerifyData()
  MagicaCloth.Define.Error VerifyDataVersion()
  System.Boolean IsOldDataVertion()
  System.Void CreateVerifyData()
  System.String GetInformation()
  System.Boolean UpgradeFormat()
  System.Void ChangeAvatar(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Collections.Generic.List<System.Int32> GetSelectionList()
  System.Collections.Generic.List<System.Int32> GetUseList()
  System.Void .ctor()
  System.Object <Init>b__27_0()
END_CLASS

CLASS: MagicaCloth.AvatarPartsAttachEvent
TYPE:  class
TOKEN: 0x2000028
EXTENDS: UnityEvent`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.AvatarPartsDetachEvent
TYPE:  class
TOKEN: 0x2000029
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerPreUpdateEvent
TYPE:  class
TOKEN: 0x200002A
EXTENDS: UnityEvent
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerPostUpdateEvent
TYPE:  class
TOKEN: 0x200002B
EXTENDS: UnityEvent
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaAreaWind
TYPE:  class
TOKEN: 0x200002C
EXTENDS: WindComponent
FIELDS:
  private           MagicaCloth.PhysicsManagerWindData.ShapeTypeshapeType  // 0x58
  private           System.Boolean                  isAddition  // 0x5C
METHODS:
  MagicaCloth.PhysicsManagerWindData.ShapeType get_ShapeType()
  System.Void set_ShapeType(MagicaCloth.PhysicsManagerWindData.ShapeType value)
  System.Boolean get_Addition()
  System.Void set_Addition(System.Boolean value)
  MagicaCloth.ComponentType GetComponentType()
  MagicaCloth.PhysicsManagerWindData.WindType GetWindType()
  MagicaCloth.PhysicsManagerWindData.ShapeType GetShapeType()
  MagicaCloth.PhysicsManagerWindData.DirectionType GetDirectionType()
  System.Boolean IsAddition()
  UnityEngine.Vector3 GetAreaSize()
  System.Single GetAreaVolume()
  System.Single GetAreaLength()
  System.Void ResetParams()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaAvatar
TYPE:  class
TOKEN: 0x200002D
EXTENDS: CoreComponent
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  private           System.Boolean                  dataReset  // 0x38
  private           MagicaCloth.MagicaAvatarRuntime runtime  // 0x40
  public            MagicaCloth.AvatarPartsAttachEventOnAttachParts  // 0x48
  public            MagicaCloth.AvatarPartsDetachEventOnDetachParts  // 0x50
METHODS:
  System.Int32 AttachAvatarParts(UnityEngine.GameObject avatarPartsPrefab, System.Action<UnityEngine.GameObject> instanceAction)
  System.Void DetachAvatarParts(System.Int32 partsId)
  System.Void DetachAvatarParts(UnityEngine.GameObject avatarPartsObject)
  System.Void DetachAvatarParts(MagicaCloth.MagicaAvatarParts parts)
  MagicaCloth.ComponentType GetComponentType()
  System.Int32 GetDataHash()
  System.Void set_DataReset(System.Boolean value)
  System.Boolean get_DataReset()
  MagicaCloth.MagicaAvatarRuntime get_Runtime()
  System.Void Reset()
  System.Void OnValidate()
  System.Void OnInit()
  System.Void OnDispose()
  System.Void OnUpdate()
  System.Void OnActive()
  System.Void OnInactive()
  System.Int32 GetVersion()
  System.Int32 GetErrorVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaDirectionalWind
TYPE:  class
TOKEN: 0x200002E
EXTENDS: WindComponent
FIELDS:
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  MagicaCloth.PhysicsManagerWindData.WindType GetWindType()
  MagicaCloth.PhysicsManagerWindData.ShapeType GetShapeType()
  MagicaCloth.PhysicsManagerWindData.DirectionType GetDirectionType()
  System.Boolean IsAddition()
  UnityEngine.Vector3 GetAreaSize()
  System.Single GetAreaVolume()
  System.Single GetAreaLength()
  System.Void ResetParams()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaPhysicsManager
TYPE:  class
TOKEN: 0x200002F
EXTENDS: CreateSingleton`1
FIELDS:
  private           MagicaCloth.UpdateTimeManager   updateTime  // 0x18
  private           MagicaCloth.PhysicsManagerParticleDataparticle  // 0x20
  private           MagicaCloth.PhysicsManagerBoneDatabone  // 0x28
  private           MagicaCloth.PhysicsManagerMeshDatamesh  // 0x30
  private           MagicaCloth.PhysicsManagerTeamDatateam  // 0x38
  private           MagicaCloth.PhysicsManagerWindDatawind  // 0x40
  private           MagicaCloth.PhysicsManagerComponentcomponent  // 0x48
  private           MagicaCloth.PhysicsManagerComputecompute  // 0x50
  private           System.Boolean                  useFasterWrite  // 0x58
  private           UnityEngine.ComputeShader       meshWriter  // 0x60
  public            MagicaCloth.PhysicsManagerPreUpdateEventOnPreUpdate  // 0x68
  public            MagicaCloth.PhysicsManagerPostUpdateEventOnPostUpdate  // 0x70
  private           System.Boolean                  useDelay  // 0x78
  private           System.Boolean                  updatePlayerLoop  // 0x79
  private           System.Boolean                  isActive  // 0x7A
METHODS:
  MagicaCloth.UpdateTimeManager.UpdateCount get_UpdatePerSeccond()
  System.Void set_UpdatePerSeccond(MagicaCloth.UpdateTimeManager.UpdateCount value)
  MagicaCloth.UpdateTimeManager.UpdateMode get_UpdateMode()
  System.Void set_UpdateMode(MagicaCloth.UpdateTimeManager.UpdateMode value)
  System.Void SetGlobalTimeScale(System.Single timeScale)
  System.Single GetGlobalTimeScale()
  System.Single get_FuturePredictionRate()
  System.Void set_FuturePredictionRate(System.Single value)
  MagicaCloth.UpdateTimeManager get_UpdateTime()
  MagicaCloth.PhysicsManagerParticleData get_Particle()
  MagicaCloth.PhysicsManagerBoneData get_Bone()
  MagicaCloth.PhysicsManagerMeshData get_Mesh()
  MagicaCloth.PhysicsManagerTeamData get_Team()
  MagicaCloth.PhysicsManagerWindData get_Wind()
  MagicaCloth.PhysicsManagerComponent get_Component()
  MagicaCloth.PhysicsManagerCompute get_Compute()
  System.Boolean get_IsDelay()
  System.Boolean get_IsActive()
  System.Void set_IsActive(System.Boolean value)
  System.Boolean get_IsFasterWrite()
  UnityEngine.ComputeShader get_MeshWriterShader()
  System.Void Awake()
  System.Void InitSingleton()
  System.Void DuplicateDetection(MagicaCloth.MagicaPhysicsManager duplicate)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void FixedUpdate()
  System.Void OnDestroy()
  System.Void AfterEarlyUpdate()
  System.Void AfterFixedUpdate()
  System.Void AfterUpdate()
  System.Void BeforeLateUpdate()
  System.Void AfterLateUpdate()
  System.Void DefaultUpdate()
  System.Void PostLateUpdate()
  System.Void AfterRendering()
  System.Void Init()
  System.Void InitCustomGameLoop()
  System.Void SetCustomGameLoop(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop)
  System.Boolean CheckRegist(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.WindComponent
TYPE:  class
TOKEN: 0x2000032
EXTENDS: BaseComponent
FIELDS:
  protected         System.Single                   main  // 0x18
  protected         System.Single                   turbulence  // 0x1C
  protected         System.Single                   frequency  // 0x20
  protected         UnityEngine.Vector3             areaSize  // 0x24
  protected         System.Single                   areaRadius  // 0x30
  protected         System.Single                   directionAngleX  // 0x34
  protected         System.Single                   directionAngleY  // 0x38
  protected         MagicaCloth.PhysicsManagerWindData.DirectionTypedirectionType  // 0x3C
  protected         MagicaCloth.BezierParam         attenuation  // 0x40
  protected         System.Int32                    windId  // 0x48
  protected         MagicaCloth.RuntimeStatus       status  // 0x50
METHODS:
  System.Single get_Main()
  System.Void set_Main(System.Single value)
  System.Single get_Turbulence()
  System.Void set_Turbulence(System.Single value)
  System.Single get_Frequency()
  System.Void set_Frequency(System.Single value)
  UnityEngine.Vector3 get_MainDirection()
  System.Void set_MainDirection(UnityEngine.Vector3 value)
  System.Single get_DirectionAngleX()
  System.Void set_DirectionAngleX(System.Single value)
  System.Single get_DirectionAngleY()
  System.Void set_DirectionAngleY(System.Single value)
  UnityEngine.Vector3 get_AreaSize()
  System.Void set_AreaSize(UnityEngine.Vector3 value)
  System.Single get_AreaRadius()
  System.Void set_AreaRadius(System.Single value)
  MagicaCloth.PhysicsManagerWindData.DirectionType get_DirectionType()
  System.Void set_DirectionType(MagicaCloth.PhysicsManagerWindData.DirectionType value)
  System.Void SetAttenuation(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval)
  MagicaCloth.RuntimeStatus get_Status()
  System.Void Reset()
  System.Void OnValidate()
  System.Void OnDidApplyAnimationProperties()
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Update()
  System.Void Init()
  System.Void OnUpdateStatus()
  System.Boolean VerifyData()
  System.Void OnInit()
  System.Void OnDispose()
  System.Void OnUpdate()
  System.Void OnActive()
  System.Void OnInactive()
  System.Void EnableWind()
  System.Void DisableWind()
  System.Void RemoveWind()
  System.Void CreateWind()
  UnityEngine.Vector3 GetLocalDirection()
  System.Void ChangeParameter()
  MagicaCloth.PhysicsManagerWindData.WindType GetWindType()
  MagicaCloth.PhysicsManagerWindData.ShapeType GetShapeType()
  MagicaCloth.PhysicsManagerWindData.DirectionType GetDirectionType()
  System.Boolean IsAddition()
  UnityEngine.Vector3 GetAreaSize()
  System.Single GetAreaVolume()
  System.Single GetAreaLength()
  System.Void ResetParams()
  System.Void .ctor()
  System.Object <Init>b__49_0()
END_CLASS

CLASS: MagicaCloth.MagicaAvatarAccess
TYPE:  class
TOKEN: 0x2000033
FIELDS:
  protected         MagicaCloth.MagicaAvatar        owner  // 0x10
METHODS:
  MagicaCloth.MagicaAvatarRuntime get_Runtime()
  System.Void SetParent(MagicaCloth.MagicaAvatar avatar)
  System.Void Create()
  System.Void Dispose()
  System.Void Active()
  System.Void Inactive()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaAvatarParts
TYPE:  class
TOKEN: 0x2000034
EXTENDS: BaseComponent
FIELDS:
  private           MagicaCloth.MagicaAvatar        parentAvatar  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform>boneDict  // 0x20
  private           System.Collections.Generic.List<MagicaCloth.CoreComponent>magicaComponentList  // 0x28
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  MagicaCloth.MagicaAvatar get_ParentAvatar()
  System.Void set_ParentAvatar(MagicaCloth.MagicaAvatar value)
  System.Boolean get_HasParent()
  System.Int32 get_PartsId()
  System.Void OnDestroy()
  System.Void Dispose()
  System.Collections.Generic.List<UnityEngine.Transform> CheckOverlappingTransform()
  System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> GetBoneDict()
  System.Collections.Generic.List<MagicaCloth.CoreComponent> GetMagicaComponentList()
  System.Int32 GetVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaAvatarRuntime
TYPE:  class
TOKEN: 0x2000035
EXTENDS: MagicaAvatarAccess
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform>boneDict  // 0x18
  private           System.Collections.Generic.Dictionary<UnityEngine.Transform,System.Int32>boneReferenceDict  // 0x20
  private           System.Collections.Generic.List<MagicaCloth.MagicaAvatarParts>avatarPartsList  // 0x28
  private           System.Collections.Generic.List<MagicaCloth.ColliderComponent>colliderList  // 0x30
METHODS:
  System.Void Create()
  System.Void Dispose()
  System.Void Active()
  System.Void Inactive()
  System.Int32 get_AvatarPartsCount()
  MagicaCloth.MagicaAvatarParts GetAvatarParts(System.Int32 index)
  System.Void CreateBoneDict()
  System.Void CreateColliderList()
  System.Int32 GetColliderCount()
  System.Collections.Generic.List<UnityEngine.Transform> CheckOverlappingTransform()
  System.Int32 AddAvatarParts(MagicaCloth.MagicaAvatarParts parts)
  System.Void AddBone(UnityEngine.Transform root, UnityEngine.Transform croot, UnityEngine.Transform bone)
  System.Void ReplaceSkinMeshRenderer(UnityEngine.SkinnedMeshRenderer skinRenderer, System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneReplaceDict)
  System.Void ReplaceMagicaComponent(MagicaCloth.CoreComponent comp, System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneReplaceDict)
  System.Void RemoveAvatarParts(MagicaCloth.MagicaAvatarParts parts)
  System.Void RemoveAvatarParts(System.Int32 partsId)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.BoneClothTarget
TYPE:  class
TOKEN: 0x2000037
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Transform>rootList  // 0x10
  private           MagicaCloth.BoneClothTarget.ConnectionModeconnection  // 0x18
  private           System.Single                   sameSurfaceAngle  // 0x1C
  private           System.Int32[]                  parentIndexList  // 0x20
METHODS:
  System.Int32 GetDataHash()
  System.Int32 get_RootCount()
  UnityEngine.Transform GetRoot(System.Int32 index)
  System.Int32 GetRootIndex(UnityEngine.Transform root)
  System.Void AddParentTransform()
  System.Void RemoveParentTransform()
  System.Void ResetFuturePredictionParentTransform()
  System.Void ChangeUnityPhysicsCount(System.Boolean sw)
  MagicaCloth.BoneClothTarget.ConnectionMode get_Connection()
  System.Single get_SameSurfaceAngle()
  System.Boolean get_IsMeshConnection()
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ClothData
TYPE:  class
TOKEN: 0x2000039
EXTENDS: ShareDataObject
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  public    static  System.UInt32                   VertexFlag_End  // 0x0
  public    static  System.UInt32                   VertexFlag_TriangleRotation  // 0x0
  public            MagicaCloth.ClothParams.AlgorithmtriangleBendAlgorithm  // 0x20
  public            MagicaCloth.ClothParams.AlgorithmrestoreRotationAlgorithm  // 0x24
  public            MagicaCloth.ClothParams.AlgorithmclampRotationAlgorithm  // 0x28
  public            System.Collections.Generic.List<System.Int32>useVertexList  // 0x30
  public            System.Collections.Generic.List<System.Int32>selectionData  // 0x38
  public            System.UInt32                   maxLevel  // 0x40
  public            System.Collections.Generic.List<System.UInt32>vertexFlagLevelList  // 0x48
  public            System.Collections.Generic.List<System.Single>vertexDepthList  // 0x50
  public            System.Collections.Generic.List<System.Int32>rootList  // 0x58
  public            System.Collections.Generic.List<System.Int32>parentList  // 0x60
  public            MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[]structDistanceDataList  // 0x68
  public            MagicaCloth.ReferenceDataIndex[]structDistanceReferenceList  // 0x70
  public            MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[]bendDistanceDataList  // 0x78
  public            MagicaCloth.ReferenceDataIndex[]bendDistanceReferenceList  // 0x80
  public            MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[]nearDistanceDataList  // 0x88
  public            MagicaCloth.ReferenceDataIndex[]nearDistanceReferenceList  // 0x90
  public            MagicaCloth.ClampDistanceConstraint.ClampDistanceData[]rootDistanceDataList  // 0x98
  public            MagicaCloth.ReferenceDataIndex[]rootDistanceReferenceList  // 0xA0
  public            MagicaCloth.ClampDistance2Constraint.ClampDistance2Data[]clampDistance2DataList  // 0xA8
  public            MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo[]clampDistance2RootInfoList  // 0xB0
  public            MagicaCloth.RestoreRotationConstraint.RotationData[]restoreRotationDataList  // 0xB8
  public            MagicaCloth.ReferenceDataIndex[]restoreRotationReferenceList  // 0xC0
  public            MagicaCloth.ClampRotationConstraint.ClampRotationData[]clampRotationDataList  // 0xC8
  public            MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo[]clampRotationRootInfoList  // 0xD0
  public            MagicaCloth.CompositeRotationConstraint.RotationData[]compositeRotationDataList  // 0xD8
  public            MagicaCloth.CompositeRotationConstraint.RootInfo[]compositeRotationRootInfoList  // 0xE0
  public            MagicaCloth.TwistConstraint.TwistData[]twistDataList  // 0xE8
  public            MagicaCloth.ReferenceDataIndex[]twistReferenceList  // 0xF0
  public            MagicaCloth.AdjustRotationWorker.AdjustRotationData[]adjustRotationDataList  // 0xF8
  public            MagicaCloth.TriangleBendConstraint.TriangleBendData[]triangleBendDataList  // 0x100
  public            MagicaCloth.ReferenceDataIndex[]triangleBendReferenceList  // 0x108
  public            System.Int32                    triangleBendWriteBufferCount  // 0x110
  public            MagicaCloth.VolumeConstraint.VolumeData[]volumeDataList  // 0x118
  public            MagicaCloth.ReferenceDataIndex[]volumeReferenceList  // 0x120
  public            System.Int32                    volumeWriteBufferCount  // 0x128
  public            MagicaCloth.LineWorker.LineRotationData[]lineRotationDataList  // 0x130
  public            MagicaCloth.LineWorker.LineRotationRootInfo[]lineRotationRootInfoList  // 0x138
  public            MagicaCloth.TriangleWorker.TriangleRotationData[]triangleRotationDataList  // 0x140
  public            System.Int32[]                  triangleRotationIndexList  // 0x148
  public            MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData[]edgeCollisionDataList  // 0x150
  public            MagicaCloth.ReferenceDataIndex[]edgeCollisionReferenceList  // 0x158
  public            System.Int32                    edgeCollisionWriteBufferCount  // 0x160
  public            MagicaCloth.PenetrationConstraint.PenetrationData[]penetrationDataList  // 0x168
  public            MagicaCloth.ReferenceDataIndex[]penetrationReferenceList  // 0x170
  public            Unity.Mathematics.float3[]      penetrationDirectionDataList  // 0x178
  public            MagicaCloth.ClothParams.PenetrationModepenetrationMode  // 0x180
  public            MagicaCloth.BaseSkinningWorker.BaseSkinningData[]baseSkinningDataList  // 0x188
  public            Unity.Mathematics.float4x4[]    baseSkinningBindPoseList  // 0x190
  public            UnityEngine.Vector3             initScale  // 0x198
METHODS:
  System.Int32 GetDataHash()
  System.Int32 get_VertexUseCount()
  System.Int32 get_StructDistanceConstraintCount()
  System.Int32 get_BendDistanceConstraintCount()
  System.Int32 get_NearDistanceConstraintCount()
  System.Int32 get_ClampDistanceConstraintCount()
  System.Int32 get_ClampDistance2ConstraintCount()
  System.Int32 get_RestoreRotationConstraintCount()
  System.Int32 get_ClampRotationConstraintDataCount()
  System.Int32 get_ClampRotationConstraintRootCount()
  System.Int32 get_AdjustRotationConstraintCount()
  System.Int32 get_CompositeRotationCount()
  System.Int32 get_TwistConstraintCount()
  System.Int32 get_TriangleBendConstraintCount()
  System.Int32 get_EdgeCollisionConstraintCount()
  System.Int32 get_VolumeConstraintCount()
  System.Int32 get_LineRotationWorkerCount()
  System.Int32 get_TriangleRotationWorkerCount()
  System.Int32 get_PenetrationCount()
  System.Int32 get_BaseSkinningCount()
  System.Int32 GetClampRotationCount()
  System.Int32 GetRestoreRotationCount()
  System.Boolean IsInvalidVertex(System.Int32 vindex)
  System.Boolean IsFixedVertex(System.Int32 vindex)
  System.Boolean IsMoveVertex(System.Int32 vindex)
  System.Boolean IsExtendVertex(System.Int32 vindex)
  System.Boolean IsLastLevel(System.Int32 vindex)
  System.Boolean IsFlag(System.Int32 vindex, System.UInt32 flag)
  System.Void SetFlag(System.Int32 vindex, System.UInt32 flag)
  System.Int32 GetLevel(System.Int32 vindex)
  System.Int32 GetVersion()
  MagicaCloth.Define.Error VerifyData()
  System.Void CreateData(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams clothParams, MagicaCloth.PhysicsTeamData teamData, MagicaCloth.MeshData meshData, MagicaCloth.IEditorMesh editMesh, System.Collections.Generic.List<System.Int32> selData, System.Action<System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<UnityEngine.Vector3>,System.Collections.Generic.List<UnityEngine.Vector3>,System.Collections.Generic.List<UnityEngine.Vector3>,System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.Int32>> extensionAction)
  System.Void CreateVertexData(System.Int32 vertexCount, System.Collections.Generic.List<System.Int32> lineList, System.Collections.Generic.List<System.Int32> triangleList)
  System.Void CreateConstraintData(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams clothParams, MagicaCloth.PhysicsTeamData teamData, System.Int32 vertexCount, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Collections.Generic.List<UnityEngine.Vector3> wnorList, System.Collections.Generic.List<UnityEngine.Vector3> wtanList, System.Collections.Generic.List<System.Int32> lineList, System.Collections.Generic.List<System.Int32> triangleList)
  System.Void RegistTriangleBend(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Collections.Generic.List<UnityEngine.Vector3> wposList, MagicaCloth.ClothParams clothParams, System.Collections.Generic.List<MagicaCloth.TriangleBendConstraint.TriangleBendData> triangleBendData)
  System.Collections.Generic.List<System.Int32> SortTetra(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Collections.Generic.List<System.Single> meshVertexDepthList)
  System.Collections.Generic.List<System.Int32> CheckTetraDirection(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Collections.Generic.HashSet<System.UInt64> trianglePackSet, System.Collections.Generic.List<System.Single> meshVertexDepthList)
  System.Boolean CalcTriangleBendRestAngle(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, System.Single& restAngle)
  System.Collections.Generic.List<System.Single> GetMeshVertexDepthList(System.Int32 vertexCount, System.Collections.Generic.List<System.Single> depthList)
  System.Collections.Generic.List<System.Int32> GetUseParentVertexList(System.Int32 vertexCount, System.Collections.Generic.List<System.Collections.Generic.HashSet<System.Int32>> vlink, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Collections.Generic.List<System.Single> depthList)
  System.Collections.Generic.List<System.Int32> GetUseRootVertexList(System.Collections.Generic.List<System.Int32> parentVertexList)
  System.Collections.Generic.List<MagicaCloth.ClothData.VertexInfo> GetUseVertexInfoList(System.Collections.Generic.List<System.Int32> parentVertexList)
  System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> GetUseRootLineList(System.Collections.Generic.List<System.Int32> parentVertexList)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ClothParams
TYPE:  class
TOKEN: 0x2000042
FIELDS:
  private           MagicaCloth.ClothParams.Algorithmalgorithm  // 0x10
  private           MagicaCloth.BezierParam         radius  // 0x18
  private           MagicaCloth.BezierParam         mass  // 0x20
  private           System.Boolean                  useGravity  // 0x28
  private           MagicaCloth.BezierParam         gravity  // 0x30
  private           UnityEngine.Vector3             gravityDirection  // 0x38
  private           System.Boolean                  useDrag  // 0x44
  private           MagicaCloth.BezierParam         drag  // 0x48
  private           System.Boolean                  useMaxVelocity  // 0x50
  private           MagicaCloth.BezierParam         maxVelocity  // 0x58
  private           UnityEngine.Transform           influenceTarget  // 0x60
  private           System.Single                   maxMoveSpeed  // 0x68
  private           System.Single                   maxRotationSpeed  // 0x6C
  private           MagicaCloth.BezierParam         worldMoveInfluence  // 0x70
  private           MagicaCloth.BezierParam         worldRotationInfluence  // 0x78
  private           System.Single                   massInfluence  // 0x80
  private           MagicaCloth.BezierParam         depthInfluence  // 0x88
  private           System.Single                   windInfluence  // 0x90
  private           System.Single                   windRandomScale  // 0x94
  private           System.Single                   windSynchronization  // 0x98
  private           System.Boolean                  useDistanceDisable  // 0x9C
  private           UnityEngine.Transform           disableReferenceObject  // 0xA0
  private           System.Single                   disableDistance  // 0xA8
  private           System.Single                   disableFadeDistance  // 0xAC
  private           System.Boolean                  useResetTeleport  // 0xB0
  private           System.Single                   teleportDistance  // 0xB4
  private           System.Single                   teleportRotation  // 0xB8
  private           MagicaCloth.ClothParams.TeleportModeteleportMode  // 0xBC
  private           System.Single                   resetStabilizationTime  // 0xC0
  private           System.Boolean                  useClampDistanceRatio  // 0xC4
  private           System.Single                   clampDistanceMinRatio  // 0xC8
  private           System.Single                   clampDistanceMaxRatio  // 0xCC
  private           System.Single                   clampDistanceVelocityInfluence  // 0xD0
  private           System.Boolean                  useClampPositionLength  // 0xD4
  private           MagicaCloth.BezierParam         clampPositionLength  // 0xD8
  private           System.Single                   clampPositionRatioX  // 0xE0
  private           System.Single                   clampPositionRatioY  // 0xE4
  private           System.Single                   clampPositionRatioZ  // 0xE8
  private           System.Single                   clampPositionVelocityInfluence  // 0xEC
  private           System.Boolean                  useClampRotation  // 0xF0
  private           MagicaCloth.BezierParam         clampRotationAngle  // 0xF8
  private           MagicaCloth.BezierParam         clampRotationAngle2  // 0x100
  private           System.Single                   clampRotationVelocityLimit  // 0x108
  private           System.Single                   clampRotationVelocityInfluence  // 0x10C
  private           System.Single                   restoreDistanceVelocityInfluence  // 0x110
  private           MagicaCloth.BezierParam         structDistanceStiffness  // 0x118
  private           System.Boolean                  useBendDistance  // 0x120
  private           System.Int32                    bendDistanceMaxCount  // 0x124
  private           MagicaCloth.BezierParam         bendDistanceStiffness  // 0x128
  private           System.Boolean                  useNearDistance  // 0x130
  private           System.Int32                    nearDistanceMaxCount  // 0x134
  private           System.Single                   nearDistanceMaxDepth  // 0x138
  private           MagicaCloth.BezierParam         nearDistanceLength  // 0x140
  private           MagicaCloth.BezierParam         nearDistanceStiffness  // 0x148
  private           System.Boolean                  useRestoreRotation  // 0x150
  private           MagicaCloth.BezierParam         restoreRotation  // 0x158
  private           MagicaCloth.BezierParam         restoreRotation2  // 0x160
  private           System.Single                   restoreRotationVelocityInfluence  // 0x168
  private           System.Single                   restoreRotationVelocityInfluence2  // 0x16C
  private           System.Boolean                  useSpring  // 0x170
  private           System.Single                   springPower  // 0x174
  private           System.Single                   springRadius  // 0x178
  private           System.Single                   springScaleX  // 0x17C
  private           System.Single                   springScaleY  // 0x180
  private           System.Single                   springScaleZ  // 0x184
  private           System.Single                   springIntensity  // 0x188
  private           MagicaCloth.BezierParam         springDirectionAtten  // 0x190
  private           MagicaCloth.BezierParam         springDistanceAtten  // 0x198
  private           MagicaCloth.ClothParams.AdjustModeadjustMode  // 0x1A0
  private           System.Single                   adjustRotationPower  // 0x1A4
  private           System.Boolean                  useTriangleBend  // 0x1A8
  private           MagicaCloth.BezierParam         triangleBend  // 0x1B0
  private           MagicaCloth.BezierParam         triangleBend2  // 0x1B8
  private           System.Boolean                  useTwistCorrection  // 0x1C0
  private           System.Single                   twistRecoveryPower  // 0x1C4
  private           System.Boolean                  useVolume  // 0x1C8
  private           System.Single                   maxVolumeLength  // 0x1CC
  private           MagicaCloth.BezierParam         volumeStretchStiffness  // 0x1D0
  private           MagicaCloth.BezierParam         volumeShearStiffness  // 0x1D8
  private           System.Boolean                  useCollision  // 0x1E0
  private           System.Single                   friction  // 0x1E4
  private           System.Single                   staticFriction  // 0x1E8
  private           System.Boolean                  usePenetration  // 0x1EC
  private           MagicaCloth.ClothParams.PenetrationModepenetrationMode  // 0x1F0
  private           MagicaCloth.ClothParams.PenetrationAxispenetrationAxis  // 0x1F4
  private           System.Single                   penetrationMaxDepth  // 0x1F8
  private           MagicaCloth.BezierParam         penetrationConnectDistance  // 0x200
  private           MagicaCloth.BezierParam         penetrationDistance  // 0x208
  private           MagicaCloth.BezierParam         penetrationRadius  // 0x210
  private           System.Boolean                  useLineAvarageRotation  // 0x218
  private           System.Boolean                  useFixedNonRotation  // 0x219
  private           System.Collections.Generic.HashSet<MagicaCloth.ClothParams.ParamType>changeSet  // 0x220
METHODS:
  System.Void SetChangeParam(MagicaCloth.ClothParams.ParamType ptype)
  System.Boolean ChangedParam(MagicaCloth.ClothParams.ParamType ptype)
  System.Void ClearChangeParam()
  System.Int32 GetParamHash(MagicaCloth.BaseCloth cloth, MagicaCloth.ClothParams.ParamType ptype)
  MagicaCloth.ClothParams.Algorithm get_AlgorithmType()
  System.Void set_AlgorithmType(MagicaCloth.ClothParams.Algorithm value)
  System.Void SetRadius(System.Single sval, System.Single eval)
  System.Single GetRadius(System.Single depth)
  MagicaCloth.BezierParam GetRadius()
  System.Void SetMass(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval)
  MagicaCloth.BezierParam GetMass()
  System.Void SetGravity(System.Boolean sw, System.Single sval, System.Single eval)
  System.Boolean get_UseGravity()
  MagicaCloth.BezierParam GetGravity()
  UnityEngine.Vector3 get_GravityDirection()
  System.Void set_GravityDirection(UnityEngine.Vector3 value)
  System.Void SetDrag(System.Boolean sw, System.Single sval, System.Single eval)
  System.Boolean get_UseDrag()
  MagicaCloth.BezierParam GetDrag()
  System.Void SetMaxVelocity(System.Boolean sw, System.Single sval, System.Single eval)
  System.Boolean get_UseMaxVelocity()
  MagicaCloth.BezierParam GetMaxVelocity()
  System.Void SetExternalForce(System.Single massInfluence, System.Single windInfluence, System.Single windRandomScale, System.Single windSynchronization)
  System.Single get_MassInfluence()
  System.Void set_MassInfluence(System.Single value)
  MagicaCloth.BezierParam GetDepthInfluence()
  System.Single get_WindInfluence()
  System.Void set_WindInfluence(System.Single value)
  System.Single get_WindRandomScale()
  System.Void set_WindRandomScale(System.Single value)
  System.Single get_WindSynchronization()
  System.Void set_WindSynchronization(System.Single value)
  System.Void SetWorldInfluence(System.Single maxspeed, System.Single moveval, System.Single rotval)
  MagicaCloth.BezierParam GetWorldMoveInfluence()
  MagicaCloth.BezierParam GetWorldRotationInfluence()
  UnityEngine.Transform GetInfluenceTarget()
  System.Void SetInfluenceTarget(UnityEngine.Transform t)
  System.Single get_MaxMoveSpeed()
  System.Void set_MaxMoveSpeed(System.Single value)
  System.Single get_MaxRotationSpeed()
  System.Void set_MaxRotationSpeed(System.Single value)
  System.Void SetTeleport(System.Boolean sw, System.Single distance, System.Single rotation, MagicaCloth.ClothParams.TeleportMode mode)
  System.Boolean get_UseResetTeleport()
  System.Void set_UseResetTeleport(System.Boolean value)
  System.Single get_TeleportDistance()
  System.Void set_TeleportDistance(System.Single value)
  System.Single get_TeleportRotation()
  System.Void set_TeleportRotation(System.Single value)
  MagicaCloth.ClothParams.TeleportMode get_TeleportResetMode()
  System.Void set_TeleportResetMode(MagicaCloth.ClothParams.TeleportMode value)
  System.Single get_ResetStabilizationTime()
  System.Void set_ResetStabilizationTime(System.Single value)
  System.Void SetDistanceDisable(System.Boolean sw, System.Single distance, System.Single fadeDistance, UnityEngine.Transform referenceObject)
  System.Boolean get_UseDistanceDisable()
  System.Void set_UseDistanceDisable(System.Boolean value)
  UnityEngine.Transform get_DisableReferenceObject()
  System.Void set_DisableReferenceObject(UnityEngine.Transform value)
  System.Single get_DisableDistance()
  System.Void set_DisableDistance(System.Single value)
  System.Single get_DisableFadeDistance()
  System.Void set_DisableFadeDistance(System.Single value)
  System.Void SetClampDistanceRatio(System.Boolean sw, System.Single minval, System.Single maxval, System.Single influence)
  System.Boolean get_UseClampDistanceRatio()
  System.Single get_ClampDistanceMinRatio()
  System.Single get_ClampDistanceMaxRatio()
  System.Single get_ClampDistanceVelocityInfluence()
  System.Void SetClampPositionLength(System.Boolean sw, System.Single sval, System.Single eval, System.Single ratioX, System.Single ratioY, System.Single ratioZ, System.Single influence)
  System.Boolean get_UseClampPositionLength()
  UnityEngine.Vector3 get_ClampPositionAxisRatio()
  MagicaCloth.BezierParam GetClampPositionLength()
  System.Single get_ClampPositionVelocityInfluence()
  System.Void SetClampRotationAngle(System.Boolean sw, System.Single sval, System.Single eval, System.Single influence)
  System.Boolean get_UseClampRotation()
  MagicaCloth.BezierParam GetClampRotationAngle(MagicaCloth.ClothParams.Algorithm algo)
  System.Single get_ClampRotationVelocityInfluence()
  System.Single GetClampRotationVelocityLimit(MagicaCloth.ClothParams.Algorithm algo)
  System.Void SetRestoreDistance(System.Single influence, System.Single structStiffness)
  System.Single get_RestoreDistanceVelocityInfluence()
  MagicaCloth.BezierParam GetStructDistanceStiffness()
  System.Boolean get_UseBendDistance()
  System.Int32 get_BendDistanceMaxCount()
  MagicaCloth.BezierParam GetBendDistanceStiffness()
  System.Boolean get_UseNearDistance()
  System.Int32 get_NearDistanceMaxCount()
  System.Single get_NearDistanceMaxDepth()
  MagicaCloth.BezierParam GetNearDistanceLength()
  MagicaCloth.BezierParam GetNearDistanceStiffness()
  System.Void SetRestoreRotation(System.Boolean sw, System.Single sval, System.Single eval, System.Single influence)
  System.Boolean get_UseRestoreRotation()
  MagicaCloth.BezierParam GetRestoreRotationPower(MagicaCloth.ClothParams.Algorithm algo)
  System.Single GetRestoreRotationVelocityInfluence(MagicaCloth.ClothParams.Algorithm algo)
  System.Void SetSpring(System.Boolean sw, System.Single power, System.Single r, System.Single sclx, System.Single scly, System.Single sclz, System.Single intensity)
  System.Void SetSpringDirectionAtten(System.Single sval, System.Single eval, System.Single cval)
  System.Void SetSpringDistanceAtten(System.Single sval, System.Single eval, System.Single cval)
  System.Boolean get_UseSpring()
  System.Void set_UseSpring(System.Boolean value)
  System.Single GetSpringPower()
  System.Single get_SpringPowr()
  System.Void set_SpringPowr(System.Single value)
  System.Single get_SpringRadius()
  UnityEngine.Vector3 get_SpringRadiusScale()
  System.Single get_SpringIntensity()
  System.Single GetSpringDirectionAtten(System.Single ratio)
  System.Single GetSpringDistanceAtten(System.Single ratio)
  System.Void SetAdjustRotation(MagicaCloth.ClothParams.AdjustMode amode, System.Single power)
  MagicaCloth.ClothParams.AdjustMode get_AdjustRotationMode()
  UnityEngine.Vector3 get_AdjustRotationVector()
  System.Void SetTriangleBend(System.Boolean sw, System.Single sval, System.Single eval)
  System.Boolean get_UseTriangleBend()
  MagicaCloth.BezierParam GetTriangleBendStiffness(MagicaCloth.ClothParams.Algorithm algo)
  System.Boolean GetUseTwistCorrection(MagicaCloth.ClothParams.Algorithm algo)
  System.Single get_TwistRecoveryPower()
  System.Void SetVolume(System.Boolean sw, System.Single maxLength, System.Single stiffness, System.Single shear)
  System.Boolean get_UseVolume()
  System.Single GetMaxVolumeLength()
  MagicaCloth.BezierParam GetVolumeStretchStiffness()
  MagicaCloth.BezierParam GetVolumeShearStiffness()
  System.Void SetCollision(System.Boolean sw, System.Single dynamicFriction, System.Single staticFriction)
  System.Boolean get_UseCollision()
  System.Single get_DynamicFriction()
  System.Single get_StaticFriction()
  System.Boolean get_UsePenetration()
  System.Void set_UsePenetration(System.Boolean value)
  MagicaCloth.ClothParams.PenetrationMode GetPenetrationMode()
  MagicaCloth.ClothParams.PenetrationAxis GetPenetrationAxis()
  System.Single get_PenetrationMaxDepth()
  MagicaCloth.BezierParam GetPenetrationConnectDistance()
  MagicaCloth.BezierParam GetPenetrationRadius()
  MagicaCloth.BezierParam GetPenetrationDistance()
  System.Boolean get_UseLineAvarageRotation()
  System.Boolean get_UseFixedNonRotation()
  System.Void ConvertToLatestAlgorithmParameter()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ClothSetup
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  private           System.Int32                    teamBoneIndex  // 0x10
  private           System.Single                   distanceBlendRatio  // 0x14
METHODS:
  System.Void ClothInit(MagicaCloth.PhysicsTeam team, MagicaCloth.MeshData meshData, MagicaCloth.ClothData clothData, MagicaCloth.ClothParams param, System.Func<System.Int32,System.UInt32> funcUserFlag)
  System.Void ClothDispose(MagicaCloth.PhysicsTeam team)
  System.Void ClothActive(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param, MagicaCloth.ClothData clothData)
  System.Void ClothInactive(MagicaCloth.PhysicsTeam team)
  System.Void ReplaceBone(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param, System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param)
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Single get_DistanceBlendRatio()
  System.Void set_DistanceBlendRatio(System.Single value)
  System.Void ChangeData(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param, MagicaCloth.ClothData clothData)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaBoneCloth
TYPE:  class
TOKEN: 0x200004B
EXTENDS: BaseCloth
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  private   static  System.Int32                    ERR_DATA_VERSION  // 0x0
  private           MagicaCloth.MeshData            meshData  // 0xC8
  private           System.Int32                    meshDataHash  // 0xD0
  private           System.Int32                    meshDataVersion  // 0xD4
  private           MagicaCloth.BoneClothTarget     clothTarget  // 0xD8
  private           System.Collections.Generic.List<UnityEngine.Transform>useTransformList  // 0xE0
  private           System.Collections.Generic.List<UnityEngine.Vector3>useTransformPositionList  // 0xE8
  private           System.Collections.Generic.List<UnityEngine.Quaternion>useTransformRotationList  // 0xF0
  private           System.Collections.Generic.List<UnityEngine.Vector3>useTransformScaleList  // 0xF8
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  System.Int32 GetDataHash()
  MagicaCloth.BoneClothTarget get_ClothTarget()
  MagicaCloth.MeshData get_MeshData()
  System.Void Reset()
  System.Void OnValidate()
  System.Void ClothInit()
  System.Void ClothDispose()
  System.Void ClothActive()
  System.UInt32 UserFlag(System.Int32 index)
  UnityEngine.Transform UserTransform(System.Int32 index)
  Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex)
  Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex)
  MagicaCloth.BaseMeshDeformer GetDeformer()
  MagicaCloth.MeshData GetMeshData()
  System.Void WorkerInit()
  System.Boolean IsRequiresDeformer()
  System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer)
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Void OnChangeCalculation()
  System.Collections.Generic.List<UnityEngine.Transform> GetTransformList()
  UnityEngine.Transform GetUseTransform(System.Int32 index)
  System.Int32 get_UseTransformCount()
  System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Transform>>> GetTransformGrid(System.Int32& maxLevel)
  System.Int32 GetVersion()
  System.Int32 GetErrorVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Collections.Generic.List<System.Int32> GetSelectionList()
  System.Collections.Generic.List<System.Int32> GetUseList()
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
  System.Void ResetParams()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaBoneSpring
TYPE:  class
TOKEN: 0x200004C
EXTENDS: BaseCloth
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  private   static  System.Int32                    ERR_DATA_VERSION  // 0x0
  private           MagicaCloth.MeshData            meshData  // 0xC8
  private           System.Int32                    meshDataHash  // 0xD0
  private           System.Int32                    meshDataVersion  // 0xD4
  private           MagicaCloth.BoneClothTarget     clothTarget  // 0xD8
  private           System.Collections.Generic.List<UnityEngine.Transform>useTransformList  // 0xE0
  private           System.Collections.Generic.List<UnityEngine.Vector3>useTransformPositionList  // 0xE8
  private           System.Collections.Generic.List<UnityEngine.Quaternion>useTransformRotationList  // 0xF0
  private           System.Collections.Generic.List<UnityEngine.Vector3>useTransformScaleList  // 0xF8
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  System.Int32 GetDataHash()
  MagicaCloth.BoneClothTarget get_ClothTarget()
  MagicaCloth.MeshData get_MeshData()
  System.Void Reset()
  System.Void OnValidate()
  System.Void ClothInit()
  System.Void ClothDispose()
  System.Void ClothActive()
  System.UInt32 UserFlag(System.Int32 index)
  UnityEngine.Transform UserTransform(System.Int32 index)
  Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex)
  Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex)
  System.Boolean IsRequiresDeformer()
  MagicaCloth.BaseMeshDeformer GetDeformer()
  MagicaCloth.MeshData GetMeshData()
  System.Void WorkerInit()
  System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer)
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Void OnChangeCalculation()
  System.Collections.Generic.List<UnityEngine.Transform> GetTransformList()
  UnityEngine.Transform GetUseTransform(System.Int32 index)
  System.Int32 get_UseTransformCount()
  System.Int32 GetVersion()
  System.Int32 GetErrorVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Collections.Generic.List<System.Int32> GetSelectionList()
  System.Collections.Generic.List<System.Int32> GetUseList()
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
  System.Void ResetParams()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaMeshCloth
TYPE:  class
TOKEN: 0x200004D
EXTENDS: BaseCloth
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  private   static  System.Int32                    ERR_DATA_VERSION  // 0x0
  private           MagicaCloth.MagicaVirtualDeformervirtualDeformer  // 0xC8
  private           System.Int32                    virtualDeformerHash  // 0xD0
  private           System.Int32                    virtualDeformerVersion  // 0xD4
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  System.Int32 GetDataHash()
  MagicaCloth.VirtualMeshDeformer get_Deformer()
  System.Void Reset()
  System.Void OnValidate()
  System.Void OnInit()
  System.Void OnActive()
  System.Void OnInactive()
  System.Void OnDispose()
  System.UInt32 UserFlag(System.Int32 index)
  UnityEngine.Transform UserTransform(System.Int32 index)
  Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex)
  Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex)
  System.Boolean IsRequiresDeformer()
  MagicaCloth.BaseMeshDeformer GetDeformer()
  MagicaCloth.MeshData GetMeshData()
  System.Void WorkerInit()
  System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer)
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Int32 GetVersion()
  System.Int32 GetErrorVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
  System.Boolean IsValidPointSelect()
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Collections.Generic.List<System.Int32> GetSelectionList()
  System.Collections.Generic.List<System.Int32> GetUseList()
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
  System.Void ResetParams()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaMeshSpring
TYPE:  class
TOKEN: 0x200004E
EXTENDS: BaseCloth
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  private   static  System.Int32                    ERR_DATA_VERSION  // 0x0
  private           MagicaCloth.MagicaVirtualDeformervirtualDeformer  // 0xC8
  private           System.Int32                    virtualDeformerHash  // 0xD0
  private           System.Int32                    virtualDeformerVersion  // 0xD4
  private           UnityEngine.Transform           centerTransform  // 0xD8
  private           MagicaCloth.MagicaMeshSpring.AxisdirectionAxis  // 0xE0
  private           MagicaCloth.SpringData          springData  // 0xE8
  private           System.Int32                    springDataHash  // 0xF0
  private           System.Int32                    springDataVersion  // 0xF4
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  System.Int32 GetDataHash()
  MagicaCloth.VirtualMeshDeformer get_Deformer()
  MagicaCloth.SpringData get_SpringData()
  System.Int32 get_UseVertexCount()
  UnityEngine.Transform get_CenterTransform()
  System.Void set_CenterTransform(UnityEngine.Transform value)
  MagicaCloth.MagicaMeshSpring.Axis get_DirectionAxis()
  System.Void set_DirectionAxis(MagicaCloth.MagicaMeshSpring.Axis value)
  UnityEngine.Vector3 get_CenterTransformDirection()
  MagicaCloth.SpringData.DeformerData GetDeformerData()
  System.Void Reset()
  System.Void OnValidate()
  System.Void ClothInit()
  System.Void ClothActive()
  System.UInt32 UserFlag(System.Int32 index)
  UnityEngine.Transform UserTransform(System.Int32 index)
  Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex)
  Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex)
  System.Boolean IsRequiresDeformer()
  MagicaCloth.BaseMeshDeformer GetDeformer()
  MagicaCloth.MeshData GetMeshData()
  System.Void WorkerInit()
  System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer)
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Void OnChangeCalculation()
  System.Int32 GetVersion()
  System.Int32 GetErrorVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
  System.Void VerifyDeformer()
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Collections.Generic.List<System.Int32> GetSelectionList()
  System.Collections.Generic.List<System.Int32> GetUseList()
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
  System.Void ResetParams()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.SelectionData
TYPE:  class
TOKEN: 0x2000050
EXTENDS: ShareDataObject
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  public    static  System.Int32                    Invalid  // 0x0
  public    static  System.Int32                    Move  // 0x0
  public    static  System.Int32                    Fixed  // 0x0
  public    static  System.Int32                    Extend  // 0x0
  public            System.Collections.Generic.List<MagicaCloth.SelectionData.DeformerSelection>selectionList  // 0x20
METHODS:
  System.Int32 get_DeformerCount()
  System.Int32 GetDataHash()
  System.Int32 GetVersion()
  MagicaCloth.Define.Error VerifyData()
  System.Boolean Compare(MagicaCloth.SelectionData sel)
  System.Collections.Generic.List<System.Int32> GetSelectionData(MagicaCloth.MeshData meshData, System.Collections.Generic.List<MagicaCloth.MeshData> childMeshDataList)
  System.Int32 GetSelection(MagicaCloth.MeshData meshData, System.Int32 vindex, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.UInt32>> dict, System.Collections.Generic.List<MagicaCloth.MeshData> childMeshDataList, System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.UInt64,System.Int32>> hashList)
  System.Void SetSelectionData(MagicaCloth.MeshData meshData, System.Collections.Generic.List<System.Int32> selects, System.Collections.Generic.List<MagicaCloth.MeshData> childMeshDataList)
  System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.UInt64,System.Int32>> GetSelectionVertexHashList()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.SpringData
TYPE:  class
TOKEN: 0x2000052
EXTENDS: ShareDataObject
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  public            MagicaCloth.SpringData.DeformerDatadeformerData  // 0x20
  public            UnityEngine.Vector3             initScale  // 0x28
METHODS:
  System.Int32 GetDataHash()
  System.Int32 get_UseVertexCount()
  System.Int32 GetVersion()
  MagicaCloth.Define.Error VerifyData()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.Define
TYPE:  class
TOKEN: 0x2000054
FIELDS:
METHODS:
  System.Boolean IsNormal(MagicaCloth.Define.Error err)
  System.Boolean IsError(MagicaCloth.Define.Error err)
  System.Boolean IsWarning(MagicaCloth.Define.Error err)
  System.String GetErrorMessage(MagicaCloth.Define.Error err)
END_CLASS

CLASS: MagicaCloth.BaseMeshDeformer
TYPE:  class
TOKEN: 0x2000059
FIELDS:
  private           MagicaCloth.MeshData            meshData  // 0x10
  private           UnityEngine.GameObject          targetObject  // 0x18
  protected         System.Int32                    dataHash  // 0x20
  protected         System.Int32                    dataVersion  // 0x24
  protected         MagicaCloth.RuntimeStatus       status  // 0x28
  private           MagicaCloth.CoreComponent       parent  // 0x30
  private           System.Int32                    <MeshIndex>k__BackingField  // 0x38
  private           System.Int32                    <VertexCount>k__BackingField  // 0x3C
  private           System.Int32                    <SkinningVertexCount>k__BackingField  // 0x40
  private           System.Int32                    <TriangleCount>k__BackingField  // 0x44
METHODS:
  MagicaCloth.CoreComponent get_Parent()
  System.Void set_Parent(MagicaCloth.CoreComponent value)
  MagicaCloth.MeshData get_MeshData()
  System.Void set_MeshData(MagicaCloth.MeshData value)
  UnityEngine.GameObject get_TargetObject()
  System.Void set_TargetObject(UnityEngine.GameObject value)
  MagicaCloth.RuntimeStatus get_Status()
  System.Int32 get_MeshIndex()
  System.Void set_MeshIndex(System.Int32 value)
  System.Int32 get_VertexCount()
  System.Void set_VertexCount(System.Int32 value)
  System.Int32 get_SkinningVertexCount()
  System.Void set_SkinningVertexCount(System.Int32 value)
  System.Int32 get_TriangleCount()
  System.Void set_TriangleCount(System.Int32 value)
  System.Void Init()
  System.Void OnInit()
  System.Void Dispose()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void MeshCalculation(System.Int32 bufferIndex)
  System.Void NormalWriting(System.Int32 bufferIndex)
  System.Void OnUpdateStatus()
  System.Void OnActive()
  System.Void OnInactive()
  System.Boolean IsMeshUse()
  System.Boolean IsActiveMesh()
  System.Boolean get_IsSkinning()
  System.Int32 get_BoneCount()
  System.Void AddUseMesh(System.Object parent)
  System.Void RemoveUseMesh(System.Object parent)
  System.Boolean AddUseVertex(System.Int32 vindex, System.Boolean fix)
  System.Boolean RemoveUseVertex(System.Int32 vindex, System.Boolean fix)
  System.Void ResetFuturePrediction()
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Int32 GetDataHash()
  System.Int32 get_SaveDataHash()
  System.Int32 get_SaveDataVersion()
  System.Int32 GetVersion()
  MagicaCloth.Define.Error VerifyData()
  System.Void CreateVerifyData()
  System.String GetInformation()
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Void .ctor()
  System.Object <Init>b__33_0()
END_CLASS

CLASS: MagicaCloth.MagicaRenderDeformer
TYPE:  class
TOKEN: 0x200005A
EXTENDS: CoreComponent
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  private   static  System.Int32                    ERR_DATA_VERSION  // 0x0
  private           MagicaCloth.RenderMeshDeformer  deformer  // 0x38
  private           System.Int32                    deformerHash  // 0x40
  private           System.Int32                    deformerVersion  // 0x44
  private           MagicaCloth.PhysicsTeam.TeamCullingMode<cullModeCash>k__BackingField  // 0x48
METHODS:
  MagicaCloth.PhysicsTeam.TeamCullingMode get_cullModeCash()
  System.Void set_cullModeCash(MagicaCloth.PhysicsTeam.TeamCullingMode value)
  MagicaCloth.ComponentType GetComponentType()
  System.Int32 GetDataHash()
  MagicaCloth.RenderMeshDeformer get_Deformer()
  System.Void OnValidate()
  System.Void OnInit()
  System.Void OnDispose()
  System.Void OnUpdate()
  System.Void OnActive()
  System.Void OnInactive()
  System.Void OnBecameVisible()
  System.Void OnBecameInvisible()
  System.Void UpdateCullingMode(MagicaCloth.CoreComponent caller)
  System.Void OnChangeCalculation()
  System.Int32 GetVersion()
  System.Int32 GetErrorVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Collections.Generic.List<System.Int32> GetUseList()
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaVirtualDeformer
TYPE:  class
TOKEN: 0x200005B
EXTENDS: CoreComponent
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  private   static  System.Int32                    ERR_DATA_VERSION  // 0x0
  private           MagicaCloth.VirtualMeshDeformer deformer  // 0x38
  private           System.Int32                    deformerHash  // 0x40
  private           System.Int32                    deformerVersion  // 0x44
  private           MagicaCloth.PhysicsTeam.TeamCullingMode<cullModeCash>k__BackingField  // 0x48
METHODS:
  MagicaCloth.PhysicsTeam.TeamCullingMode get_cullModeCash()
  System.Void set_cullModeCash(MagicaCloth.PhysicsTeam.TeamCullingMode value)
  MagicaCloth.ComponentType GetComponentType()
  System.Int32 GetDataHash()
  MagicaCloth.VirtualMeshDeformer get_Deformer()
  System.Void OnValidate()
  System.Void OnInit()
  System.Void OnDispose()
  System.Void OnUpdate()
  System.Void OnActive()
  System.Void OnInactive()
  System.Void LinkRenderDeformerStatus(System.Boolean sw)
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Void UpdateCullingMode(MagicaCloth.CoreComponent caller)
  System.Void OnChangeCalculation()
  System.Int32 GetVersion()
  System.Int32 GetErrorVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Collections.Generic.List<System.Int32> GetUseList()
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MeshData
TYPE:  class
TOKEN: 0x200005C
EXTENDS: ShareDataObject
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  public            System.Boolean                  isSkinning  // 0x20
  public            System.Int32                    vertexCount  // 0x24
  public            System.UInt32[]                 vertexInfoList  // 0x28
  public            MagicaCloth.MeshData.VertexWeight[]vertexWeightList  // 0x30
  public            System.UInt64[]                 vertexHashList  // 0x38
  public            UnityEngine.Vector2[]           uvList  // 0x40
  public            System.Int32                    lineCount  // 0x48
  public            System.Int32[]                  lineList  // 0x50
  public            System.Int32                    triangleCount  // 0x58
  public            System.Int32[]                  triangleList  // 0x60
  public            System.Int32                    boneCount  // 0x68
  public            System.UInt32[]                 vertexToTriangleInfoList  // 0x70
  public            System.Int32[]                  vertexToTriangleIndexList  // 0x78
  public            System.Collections.Generic.List<MagicaCloth.MeshData.ChildData>childDataList  // 0x80
  public            UnityEngine.Vector3             baseScale  // 0x88
METHODS:
  System.Int32 get_VertexCount()
  System.Int32 get_VertexHashCount()
  System.Int32 get_WeightCount()
  System.Int32 get_LineCount()
  System.Int32 get_TriangleCount()
  System.Int32 get_BoneCount()
  System.Int32 get_ChildCount()
  System.Int32 GetDataHash()
  System.Int32 GetVersion()
  MagicaCloth.Define.Error VerifyData()
  System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.UInt32>> GetVirtualToChildVertexDict()
  System.Collections.Generic.List<System.Int32> ExtendSelection(System.Collections.Generic.List<System.Int32> originalSelection, System.Boolean extendNext, System.Boolean extendWeight)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.RenderMeshDeformer
TYPE:  class
TOKEN: 0x200005F
EXTENDS: BaseMeshDeformer
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  private           MagicaCloth.RenderMeshDeformer.RecalculateModenormalAndTangentUpdateMode  // 0x48
  private           MagicaCloth.RenderMeshDeformer.BoundsModeboundsUpdateMode  // 0x4C
  private           UnityEngine.Mesh                sharedMesh  // 0x50
  private           System.Int32                    meshOptimize  // 0x58
  private           UnityEngine.Renderer            renderer  // 0x60
  private           UnityEngine.MeshFilter          meshFilter  // 0x68
  private           UnityEngine.SkinnedMeshRenderer skinMeshRenderer  // 0x70
  private           UnityEngine.Transform[]         originalBones  // 0x78
  private           UnityEngine.Transform[]         boneList  // 0x80
  private           UnityEngine.Mesh                cloneMesh  // 0x88
  private           UnityEngine.GraphicsBuffer      vertexBuffer  // 0x90
  private           System.Boolean                  <IsChangePosition>k__BackingField  // 0x98
  private           System.Boolean                  <IsChangeNormalTangent>k__BackingField  // 0x99
  private           System.Boolean                  <IsChangeBoneWeights>k__BackingField  // 0x9A
  private           System.Boolean                  oldUse  // 0x9B
  private           System.Boolean                  <IsWriteSkip>k__BackingField  // 0x9C
  private           System.Boolean                  <IsFasterWriteUpdate>k__BackingField  // 0x9D
  private           System.Boolean                  <IsWriteMeshPosition>k__BackingField  // 0x9E
  private           System.Boolean                  <IsWriteMeshBoneWeight>k__BackingField  // 0x9F
  private           System.Boolean                  IsWriteMeshNormal  // 0xA0
  private           System.Boolean                  IsWriteMeshTangent  // 0xA1
  private           System.Boolean                  <IsFasterWrite>k__BackingField  // 0xA2
METHODS:
  System.Boolean get_IsChangePosition()
  System.Void set_IsChangePosition(System.Boolean value)
  System.Boolean get_IsChangeNormalTangent()
  System.Void set_IsChangeNormalTangent(System.Boolean value)
  System.Boolean get_IsChangeBoneWeights()
  System.Void set_IsChangeBoneWeights(System.Boolean value)
  System.Boolean get_IsWriteSkip()
  System.Void set_IsWriteSkip(System.Boolean value)
  System.Boolean get_IsFasterWriteUpdate()
  System.Void set_IsFasterWriteUpdate(System.Boolean value)
  System.Boolean get_IsWriteMeshPosition()
  System.Void set_IsWriteMeshPosition(System.Boolean value)
  System.Boolean get_IsWriteMeshBoneWeight()
  System.Void set_IsWriteMeshBoneWeight(System.Boolean value)
  System.Int32 GetDataHash()
  UnityEngine.Mesh get_SharedMesh()
  System.Boolean get_IsFasterWrite()
  System.Void set_IsFasterWrite(System.Boolean value)
  System.Void OnValidate()
  System.Void OnInit()
  System.Void OnActive()
  System.Void OnInactive()
  System.Void Dispose()
  System.Void SetRecalculateNormalAndTangentMode()
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Void ChangeCalculation(System.Boolean sw)
  System.Boolean IsMeshUse()
  System.Boolean IsActiveMesh()
  System.Void AddUseMesh(System.Object parent)
  System.Void RemoveUseMesh(System.Object parent)
  System.Boolean get_IsRendererVisible()
  System.Boolean get_HasNormal()
  System.Void MeshCalculation(System.Int32 bufferIndex)
  System.Void NormalWriting(System.Int32 bufferIndex)
  System.Boolean FasterWriting(System.Int32 bufferIndex, UnityEngine.ComputeShader compute, System.Int32 kernel, System.Int32 index, System.Int32& maxVertexCount)
  System.Void ChangeNormalTangentUpdateMode()
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Collections.Generic.List<System.Int32> GetEditorUseList()
  System.Int32 GetVersion()
  MagicaCloth.Define.Error VerifyData()
  UnityEngine.Mesh GetTargetSharedMesh()
  System.String GetInformation()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.VirtualMeshDeformer
TYPE:  class
TOKEN: 0x2000062
EXTENDS: BaseMeshDeformer
FIELDS:
  private   static  System.Int32                    DATA_VERSION  // 0x0
  private           System.Collections.Generic.List<MagicaCloth.MagicaRenderDeformer>renderDeformerList  // 0x48
  private           System.Collections.Generic.List<System.Int32>renderDeformerHashList  // 0x50
  private           System.Int32                    renderDeformerVersion  // 0x58
  private           System.Single                   mergeVertexDistance  // 0x5C
  private           System.Single                   mergeTriangleDistance  // 0x60
  private           System.Single                   sameSurfaceAngle  // 0x64
  private           System.Boolean                  useSkinning  // 0x68
  private           System.Int32                    maxWeightCount  // 0x6C
  private           System.Single                   weightPow  // 0x70
  private           System.Collections.Generic.List<UnityEngine.Transform>boneList  // 0x78
  private           System.Collections.Generic.List<System.Int32>sharedChildMeshIndexList  // 0x80
METHODS:
  System.Int32 GetDataHash()
  System.Void OnInit()
  System.Void Dispose()
  System.Void OnActive()
  System.Void OnInactive()
  System.Void MeshCalculation(System.Int32 bufferIndex)
  System.Void NormalWriting(System.Int32 bufferIndex)
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  MagicaCloth.BaseMeshDeformer GetDeformer()
  System.Single get_MergeVertexDistance()
  System.Single get_MergeTriangleDistance()
  System.Single get_SameSurfaceAngle()
  System.Int32 get_MaxWeightCount()
  System.Single get_WeightPow()
  System.Int32 get_RenderDeformerCount()
  MagicaCloth.MagicaRenderDeformer GetRenderDeformer(System.Int32 index)
  System.Int32 GetRenderMeshDeformerIndex(MagicaCloth.RenderMeshDeformer deformer)
  System.Collections.Generic.List<MagicaCloth.MeshData> GetRenderDeformerMeshList()
  System.Boolean IsMeshUse()
  System.Boolean IsActiveMesh()
  System.Void AddUseMesh(System.Object parent)
  System.Void RemoveUseMesh(System.Object parent)
  System.Boolean AddUseVertex(System.Int32 vindex, System.Boolean fix)
  System.Boolean RemoveUseVertex(System.Int32 vindex, System.Boolean fix)
  System.Void ResetFuturePrediction()
  System.Void ChangeUseUnityPhysics(System.Boolean sw)
  System.Void ChangeCalculation(System.Boolean sw)
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
  System.Int32 GetVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ClampDistance2Constraint
TYPE:  class
TOKEN: 0x2000064
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2Data>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo>rootInfoList  // 0x28
  public            MagicaCloth.FixedNativeList<MagicaCloth.ClampDistance2Constraint.GroupData>groupList  // 0x30
  private           MagicaCloth.FixedChunkNativeArray<System.Int32>rootTeamList  // 0x38
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence, MagicaCloth.ClampDistance2Constraint.ClampDistance2Data[] dataArray, MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo[] rootInfoArray)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ClampDistanceConstraint
TYPE:  class
TOKEN: 0x2000069
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampDistanceConstraint.ClampDistanceData>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x28
  public            MagicaCloth.FixedNativeList<MagicaCloth.ClampDistanceConstraint.GroupData>groupList  // 0x30
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence, MagicaCloth.ClampDistanceConstraint.ClampDistanceData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ClampPositionConstraint
TYPE:  class
TOKEN: 0x200006D
EXTENDS: PhysicsManagerConstraint
FIELDS:
  public            MagicaCloth.FixedNativeList<MagicaCloth.ClampPositionConstraint.GroupData>groupList  // 0x20
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam limitLength, Unity.Mathematics.float3 axisRatio, System.Single velocityInfluence)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam limitLength, Unity.Mathematics.float3 axisRatio, System.Single velocityInfluence)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ClampRotationConstraint
TYPE:  class
TOKEN: 0x2000070
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationData>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo>rootInfoList  // 0x28
  public            MagicaCloth.FixedNativeList<MagicaCloth.ClampRotationConstraint.GroupData>groupList  // 0x30
  private           MagicaCloth.FixedChunkNativeArray<System.Int32>rootTeamList  // 0x38
  private           MagicaCloth.FixedChunkNativeArray<System.Single>lengthBuffer  // 0x40
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam maxAngle, System.Single velocityInfluence, MagicaCloth.ClampRotationConstraint.ClampRotationData[] dataArray, MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo[] rootInfoArray)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam maxAngle, System.Single velocityInfluence)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ColliderCollisionConstraint
TYPE:  class
TOKEN: 0x2000075
EXTENDS: PhysicsManagerConstraint
FIELDS:
METHODS:
  System.Void Create()
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean useCollision)
  System.Void Release()
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ColliderExtrusionConstraint
TYPE:  class
TOKEN: 0x2000077
EXTENDS: PhysicsManagerConstraint
FIELDS:
METHODS:
  System.Void Create()
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void Release()
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.CompositeRotationConstraint
TYPE:  class
TOKEN: 0x2000079
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.CompositeRotationConstraint.RotationData>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.CompositeRotationConstraint.RootInfo>rootInfoList  // 0x28
  public            MagicaCloth.FixedNativeList<MagicaCloth.CompositeRotationConstraint.GroupData>groupList  // 0x30
  private           MagicaCloth.FixedChunkNativeArray<System.Int32>rootTeamList  // 0x38
  private           MagicaCloth.FixedChunkNativeArray<System.Single>lengthBuffer  // 0x40
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean useClamp, MagicaCloth.BezierParam maxAngle, System.Boolean useRestore, MagicaCloth.BezierParam restorePower, System.Single velocityInfluence, MagicaCloth.CompositeRotationConstraint.RotationData[] dataArray, MagicaCloth.CompositeRotationConstraint.RootInfo[] rootInfoArray)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean useClamp, MagicaCloth.BezierParam maxAngle, System.Boolean useRestore, MagicaCloth.BezierParam restorePower, System.Single velocityInfluence)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.EdgeCollisionConstraint
TYPE:  class
TOKEN: 0x200007E
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<System.Int16>groupIndexList  // 0x28
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x30
  private           MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>writeBuffer  // 0x38
  private           MagicaCloth.FixedNativeList<MagicaCloth.EdgeCollisionConstraint.GroupData>groupList  // 0x40
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single edgeRadius, MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray, System.Int32 writeBufferCount)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single edgeRadius)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PenetrationConstraint
TYPE:  class
TOKEN: 0x2000083
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.PenetrationConstraint.PenetrationData>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x28
  private           MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>bonePenetrationDataList  // 0x30
  public            MagicaCloth.FixedNativeList<MagicaCloth.PenetrationConstraint.GroupData>groupList  // 0x38
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.ClothParams.PenetrationMode mode, MagicaCloth.BezierParam distance, MagicaCloth.BezierParam radius, System.Single maxDepth, MagicaCloth.PenetrationConstraint.PenetrationData[] moveLimitDataList, MagicaCloth.ReferenceDataIndex[] refDataArray, Unity.Mathematics.float3[] bonePenetrationDataArray)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam distance, MagicaCloth.BezierParam radius, System.Single maxDepth)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.RestoreDistanceConstraint
TYPE:  class
TOKEN: 0x2000087
EXTENDS: PhysicsManagerConstraint
FIELDS:
  public    static  System.Int32                    StructType  // 0x0
  public    static  System.Int32                    BendType  // 0x0
  public    static  System.Int32                    NearType  // 0x0
  public    static  System.Int32                    TypeCount  // 0x0
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData>[]dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>[]refDataList  // 0x28
  public            MagicaCloth.FixedNativeList<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceGroupData>groupList  // 0x30
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, MagicaCloth.BezierParam mass, System.Single velocityInfluence, MagicaCloth.BezierParam structStiffness, MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] structDataArray, MagicaCloth.ReferenceDataIndex[] structRefDataArray, System.Boolean useBend, MagicaCloth.BezierParam bendStiffness, MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] bendDataArray, MagicaCloth.ReferenceDataIndex[] bendRefDataArray, System.Boolean useNear, MagicaCloth.BezierParam nearStiffness, MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] nearDataArray, MagicaCloth.ReferenceDataIndex[] nearRefDataArray)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, MagicaCloth.BezierParam mass, System.Single velocityInfluence, MagicaCloth.BezierParam structStiffness, System.Boolean useBend, MagicaCloth.BezierParam bendStiffness, System.Boolean useNear, MagicaCloth.BezierParam nearStiffness)
  System.Int32 GetIterationCount()
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.RestoreRotationConstraint
TYPE:  class
TOKEN: 0x200008B
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.RestoreRotationConstraint.RotationData>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x28
  public            MagicaCloth.FixedNativeList<MagicaCloth.RestoreRotationConstraint.GroupData>groupList  // 0x30
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam power, System.Single velocityInfluence, MagicaCloth.RestoreRotationConstraint.RotationData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam power, System.Single velocityInfluence)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.SpringConstraint
TYPE:  class
TOKEN: 0x200008F
EXTENDS: PhysicsManagerConstraint
FIELDS:
  public            MagicaCloth.FixedNativeList<MagicaCloth.SpringConstraint.GroupData>groupList  // 0x20
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single spring)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single spring)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.TriangleBendConstraint
TYPE:  class
TOKEN: 0x2000092
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendData>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<System.Int16>groupIndexList  // 0x28
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x30
  private           MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>writeBuffer  // 0x38
  private           MagicaCloth.FixedNativeList<MagicaCloth.TriangleBendConstraint.TriangleBendGroupData>groupList  // 0x40
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.ClothParams.Algorithm algorithm, MagicaCloth.BezierParam stiffness, MagicaCloth.TriangleBendConstraint.TriangleBendData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray, System.Int32 writeBufferCount)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam stiffness)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.TwistConstraint
TYPE:  class
TOKEN: 0x2000097
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.TwistConstraint.TwistData>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x28
  public            MagicaCloth.FixedNativeList<MagicaCloth.TwistConstraint.GroupData>groupList  // 0x30
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single recoveryPower, MagicaCloth.TwistConstraint.TwistData[] dataArray, MagicaCloth.ReferenceDataIndex[] refArray)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single recoveryPower)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.VolumeConstraint
TYPE:  class
TOKEN: 0x200009B
EXTENDS: PhysicsManagerConstraint
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.VolumeConstraint.VolumeData>dataList  // 0x20
  private           MagicaCloth.FixedChunkNativeArray<System.Int16>groupIndexList  // 0x28
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>refDataList  // 0x30
  private           MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>writeBuffer  // 0x38
  private           MagicaCloth.FixedNativeList<MagicaCloth.VolumeConstraint.GroupData>groupList  // 0x40
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam stretchStiffness, MagicaCloth.BezierParam shearStiffness, MagicaCloth.VolumeConstraint.VolumeData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray, System.Int32 writeBufferCount)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam stretchStiffness, MagicaCloth.BezierParam shearStiffness)
  System.Int32 GetIterationCount()
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.CurveParam
TYPE:  struct
TOKEN: 0x20000A0
FIELDS:
  public            System.Single                   sval  // 0x10
  public            System.Single                   eval  // 0x14
  public            System.Single                   cval  // 0x18
  public            System.Int32                    useCurve  // 0x1C
METHODS:
  System.Void .ctor(System.Single value)
  System.Void .ctor(System.Single svalue, System.Single evalue)
  System.Void .ctor(MagicaCloth.BezierParam bezier)
  System.Void Setup(MagicaCloth.BezierParam bezier)
  System.Single Evaluate(System.Single t)
END_CLASS

CLASS: MagicaCloth.BaseComponent
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ComponentType
TYPE:  struct
TOKEN: 0x20000A2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MagicaCloth.ComponentType       None  // 0x0
  public    static  MagicaCloth.ComponentType       SphereCollider  // 0x0
  public    static  MagicaCloth.ComponentType       CapsuleCollider  // 0x0
  public    static  MagicaCloth.ComponentType       PlaneCollider  // 0x0
  public    static  MagicaCloth.ComponentType       DirectionalWind  // 0x0
  public    static  MagicaCloth.ComponentType       AreaWind  // 0x0
  public    static  MagicaCloth.ComponentType       RenderDeformer  // 0x0
  public    static  MagicaCloth.ComponentType       VirtualDeformer  // 0x0
  public    static  MagicaCloth.ComponentType       BoneCloth  // 0x0
  public    static  MagicaCloth.ComponentType       BoneSpring  // 0x0
  public    static  MagicaCloth.ComponentType       MeshCloth  // 0x0
  public    static  MagicaCloth.ComponentType       MeshSpring  // 0x0
  public    static  MagicaCloth.ComponentType       Avatar  // 0x0
  public    static  MagicaCloth.ComponentType       AvatarParts  // 0x0
METHODS:
END_CLASS

CLASS: MagicaCloth.PhysicsManagerAccess
TYPE:  class
TOKEN: 0x20000A3
FIELDS:
  protected         MagicaCloth.MagicaPhysicsManagermanager  // 0x10
METHODS:
  MagicaCloth.UpdateTimeManager get_UpdateTime()
  MagicaCloth.PhysicsManagerParticleData get_Particle()
  MagicaCloth.PhysicsManagerBoneData get_Bone()
  MagicaCloth.PhysicsManagerMeshData get_Mesh()
  MagicaCloth.PhysicsManagerTeamData get_Team()
  MagicaCloth.PhysicsManagerWindData get_Wind()
  MagicaCloth.PhysicsManagerComponent get_Component()
  MagicaCloth.PhysicsManagerCompute get_Compute()
  System.Void SetParent(MagicaCloth.MagicaPhysicsManager manager)
  System.Void Create()
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerBoneData
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: PhysicsManagerAccess
FIELDS:
  public    static  System.Byte                     Flag_Reset  // 0x0
  public    static  System.Byte                     Flag_Restore  // 0x0
  public    static  System.Byte                     Flag_Write  // 0x0
  public            MagicaCloth.FixedTransformAccessArrayboneList  // 0x18
  public            MagicaCloth.FixedNativeList<System.Byte>boneFlagList  // 0x20
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.float3>bonePosList  // 0x28
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion>boneRotList  // 0x30
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.float3>boneSclList  // 0x38
  public            MagicaCloth.FixedNativeList<System.Int32>boneParentIndexList  // 0x40
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.float3>basePosList  // 0x48
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion>baseRotList  // 0x50
  public            MagicaCloth.FixedNativeList<System.Int16>boneUnityPhysicsList  // 0x58
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.float3>futurePosList  // 0x60
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion>futureRotList  // 0x68
  public            MagicaCloth.FixedTransformAccessArrayrestoreBoneList  // 0x70
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.float3>restoreBoneLocalPosList  // 0x78
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion>restoreBoneLocalRotList  // 0x80
  public            MagicaCloth.FixedNativeList<System.Int32>restoreBoneIndexList  // 0x88
  public            MagicaCloth.FixedTransformAccessArraywriteBoneList  // 0x90
  public            MagicaCloth.FixedNativeList<System.Int32>writeBoneIndexList  // 0x98
  public            MagicaCloth.ExNativeMultiHashMap<System.Int32,System.Int32>writeBoneParticleIndexMap  // 0xA0
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>boneToWriteIndexDict  // 0xA8
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.float3>writeBonePosList  // 0xB0
  public            MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion>writeBoneRotList  // 0xB8
  private           System.Boolean                  <hasBoneChanged>k__BackingField  // 0xC0
  private           UnityEngine.Profiling.CustomSampler<SamplerReadBoneScale>k__BackingField  // 0xC8
METHODS:
  System.Boolean get_hasBoneChanged()
  System.Void set_hasBoneChanged(System.Boolean value)
  UnityEngine.Profiling.CustomSampler get_SamplerReadBoneScale()
  System.Void set_SamplerReadBoneScale(UnityEngine.Profiling.CustomSampler value)
  System.Void Create()
  System.Void Dispose()
  System.Int32 AddRestoreBone(UnityEngine.Transform target, Unity.Mathematics.float3 lpos, Unity.Mathematics.quaternion lrot, System.Int32 boneIndex)
  System.Void RemoveRestoreBone(System.Int32 restoreBoneIndex)
  System.Int32 get_RestoreBoneCount()
  System.Int32 AddBone(UnityEngine.Transform target, System.Int32 pindex, System.Boolean addParent)
  System.Boolean RemoveBone(System.Int32 boneIndex, System.Int32 pindex)
  System.Void ChangeUnityPhysicsCount(System.Int32 boneIndex, System.Boolean sw)
  System.Void ResetFuturePrediction(System.Int32 boneIndex)
  System.Int32 get_ReadBoneCount()
  System.Int32 get_WriteBoneCount()
  System.Void ResetBoneFromTransform(System.Boolean fixedUpdate)
  System.Void ReadBoneFromTransform()
  System.Void ConvertWorldToLocal()
  System.Void WriteBoneToTransform(System.Int32 bufferIndex)
  System.Void CopyBoneBuffer()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerComponent
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: PhysicsManagerAccess
FIELDS:
  private   readonly System.Collections.Generic.HashSet<MagicaCloth.CoreComponent>componentSet  // 0x18
  private           System.Collections.Generic.HashSet<MagicaCloth.ParticleComponent>dataUpdateParticleSet  // 0x20
METHODS:
  System.Void Create()
  System.Void Dispose()
  System.Int32 get_ComponentCount()
  System.Collections.Generic.List<MagicaCloth.CoreComponent> GetComponentList()
  System.Void ComponentAction(System.Action<MagicaCloth.CoreComponent> act)
  System.Void UpdateComponentStatus()
  System.Void AddComponent(MagicaCloth.CoreComponent comp)
  System.Void RemoveComponent(MagicaCloth.CoreComponent comp)
  System.Void ReserveDataUpdateParticleComponent(MagicaCloth.ParticleComponent comp)
  System.Void DataUpdateParticleComponent()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerCompute
TYPE:  class
TOKEN: 0x20000AE
EXTENDS: PhysicsManagerAccess
FIELDS:
  private           System.Int32                    solverIteration  // 0x18
  private           System.Collections.Generic.List<MagicaCloth.PhysicsManagerConstraint>constraints  // 0x20
  private           MagicaCloth.ClampPositionConstraint<ClampPosition>k__BackingField  // 0x28
  private           MagicaCloth.ClampDistanceConstraint<ClampDistance>k__BackingField  // 0x30
  private           MagicaCloth.ClampRotationConstraint<ClampRotation>k__BackingField  // 0x38
  private           MagicaCloth.SpringConstraint    <Spring>k__BackingField  // 0x40
  private           MagicaCloth.RestoreDistanceConstraint<RestoreDistance>k__BackingField  // 0x48
  private           MagicaCloth.RestoreRotationConstraint<RestoreRotation>k__BackingField  // 0x50
  private           MagicaCloth.TriangleBendConstraint<TriangleBend>k__BackingField  // 0x58
  private           MagicaCloth.ColliderCollisionConstraint<Collision>k__BackingField  // 0x60
  private           MagicaCloth.PenetrationConstraint<Penetration>k__BackingField  // 0x68
  private           MagicaCloth.ColliderExtrusionConstraint<ColliderExtrusion>k__BackingField  // 0x70
  private           MagicaCloth.TwistConstraint     <Twist>k__BackingField  // 0x78
  private           MagicaCloth.CompositeRotationConstraint<CompositeRotation>k__BackingField  // 0x80
  private           System.Collections.Generic.List<MagicaCloth.PhysicsManagerWorker>workers  // 0x88
  private           MagicaCloth.RenderMeshWorker    <RenderMeshWorker>k__BackingField  // 0x90
  private           MagicaCloth.VirtualMeshWorker   <VirtualMeshWorker>k__BackingField  // 0x98
  private           MagicaCloth.MeshParticleWorker  <MeshParticleWorker>k__BackingField  // 0xA0
  private           MagicaCloth.SpringMeshWorker    <SpringMeshWorker>k__BackingField  // 0xA8
  private           MagicaCloth.AdjustRotationWorker<AdjustRotationWorker>k__BackingField  // 0xB0
  private           MagicaCloth.LineWorker          <LineWorker>k__BackingField  // 0xB8
  private           MagicaCloth.TriangleWorker      <TriangleWorker>k__BackingField  // 0xC0
  private           MagicaCloth.BaseSkinningWorker  <BaseSkinningWorker>k__BackingField  // 0xC8
  private           Unity.Jobs.JobHandle            jobHandle  // 0xD0
  private           System.Boolean                  runMasterJob  // 0xE0
  private           System.Int32                    swapIndex  // 0xE4
  private           UnityEngine.Profiling.CustomSampler<SamplerCalcMesh>k__BackingField  // 0xE8
  private           UnityEngine.Profiling.CustomSampler<SamplerWriteMesh>k__BackingField  // 0xF0
METHODS:
  MagicaCloth.ClampPositionConstraint get_ClampPosition()
  System.Void set_ClampPosition(MagicaCloth.ClampPositionConstraint value)
  MagicaCloth.ClampDistanceConstraint get_ClampDistance()
  System.Void set_ClampDistance(MagicaCloth.ClampDistanceConstraint value)
  MagicaCloth.ClampRotationConstraint get_ClampRotation()
  System.Void set_ClampRotation(MagicaCloth.ClampRotationConstraint value)
  MagicaCloth.SpringConstraint get_Spring()
  System.Void set_Spring(MagicaCloth.SpringConstraint value)
  MagicaCloth.RestoreDistanceConstraint get_RestoreDistance()
  System.Void set_RestoreDistance(MagicaCloth.RestoreDistanceConstraint value)
  MagicaCloth.RestoreRotationConstraint get_RestoreRotation()
  System.Void set_RestoreRotation(MagicaCloth.RestoreRotationConstraint value)
  MagicaCloth.TriangleBendConstraint get_TriangleBend()
  System.Void set_TriangleBend(MagicaCloth.TriangleBendConstraint value)
  MagicaCloth.ColliderCollisionConstraint get_Collision()
  System.Void set_Collision(MagicaCloth.ColliderCollisionConstraint value)
  MagicaCloth.PenetrationConstraint get_Penetration()
  System.Void set_Penetration(MagicaCloth.PenetrationConstraint value)
  MagicaCloth.ColliderExtrusionConstraint get_ColliderExtrusion()
  System.Void set_ColliderExtrusion(MagicaCloth.ColliderExtrusionConstraint value)
  MagicaCloth.TwistConstraint get_Twist()
  System.Void set_Twist(MagicaCloth.TwistConstraint value)
  MagicaCloth.CompositeRotationConstraint get_CompositeRotation()
  System.Void set_CompositeRotation(MagicaCloth.CompositeRotationConstraint value)
  MagicaCloth.RenderMeshWorker get_RenderMeshWorker()
  System.Void set_RenderMeshWorker(MagicaCloth.RenderMeshWorker value)
  MagicaCloth.VirtualMeshWorker get_VirtualMeshWorker()
  System.Void set_VirtualMeshWorker(MagicaCloth.VirtualMeshWorker value)
  MagicaCloth.MeshParticleWorker get_MeshParticleWorker()
  System.Void set_MeshParticleWorker(MagicaCloth.MeshParticleWorker value)
  MagicaCloth.SpringMeshWorker get_SpringMeshWorker()
  System.Void set_SpringMeshWorker(MagicaCloth.SpringMeshWorker value)
  MagicaCloth.AdjustRotationWorker get_AdjustRotationWorker()
  System.Void set_AdjustRotationWorker(MagicaCloth.AdjustRotationWorker value)
  MagicaCloth.LineWorker get_LineWorker()
  System.Void set_LineWorker(MagicaCloth.LineWorker value)
  MagicaCloth.TriangleWorker get_TriangleWorker()
  System.Void set_TriangleWorker(MagicaCloth.TriangleWorker value)
  MagicaCloth.BaseSkinningWorker get_BaseSkinningWorker()
  System.Void set_BaseSkinningWorker(MagicaCloth.BaseSkinningWorker value)
  UnityEngine.Profiling.CustomSampler get_SamplerCalcMesh()
  System.Void set_SamplerCalcMesh(UnityEngine.Profiling.CustomSampler value)
  UnityEngine.Profiling.CustomSampler get_SamplerWriteMesh()
  System.Void set_SamplerWriteMesh(UnityEngine.Profiling.CustomSampler value)
  System.Void Create()
  System.Void Dispose()
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void UpdateRestoreBone(MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode)
  System.Void UpdateReadBone()
  System.Void UpdateTeamAlways()
  System.Void UpdateStartSimulation(MagicaCloth.UpdateTimeManager update)
  System.Void UpdateCompleteSimulation()
  System.Void UpdateWriteBone()
  System.Void MeshCalculation()
  System.Void NormalWritingMesh()
  System.Void UpdateReadWriteBone()
  System.Void UpdateSyncBuffer()
  System.Void UpdateSwapBuffer()
  Unity.Jobs.JobHandle get_MasterJob()
  System.Void set_MasterJob(Unity.Jobs.JobHandle value)
  System.Void InitJob()
  System.Void ScheduleJob()
  System.Void CompleteJob()
  System.Int32 get_SwapIndex()
  System.Void UpdatePhysics(System.Int32 updateCount, System.Int32 runCount, System.Single updatePower, System.Single updateDeltaTime)
  System.Void PostUpdatePhysics(System.Single updateDeltaTime)
  System.Void WarmupWorker()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerConstraint
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
  public            System.Int32                    iteration  // 0x10
  private           MagicaCloth.MagicaPhysicsManager<Manager>k__BackingField  // 0x18
METHODS:
  MagicaCloth.MagicaPhysicsManager get_Manager()
  System.Void set_Manager(MagicaCloth.MagicaPhysicsManager value)
  System.Void Init(MagicaCloth.MagicaPhysicsManager manager)
  System.Void Create()
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void Release()
  System.Int32 GetIterationCount()
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerMeshData
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: PhysicsManagerAccess
FIELDS:
  public    static  System.UInt32                   MeshFlag_Active  // 0x0
  public    static  System.UInt32                   MeshFlag_Skinning  // 0x0
  public    static  System.UInt32                   Meshflag_CalcNormal  // 0x0
  public    static  System.UInt32                   Meshflag_CalcTangent  // 0x0
  public    static  System.UInt32                   Meshflag_Pause  // 0x0
  public    static  System.UInt32                   MeshFlag_ExistNormals  // 0x0
  public    static  System.UInt32                   MeshFlag_ExistTangents  // 0x0
  public    static  System.UInt32                   MeshFlag_ExistWeights  // 0x0
  public    static  System.UInt32                   MeshFlag_UpdateUseVertexFront  // 0x0
  public    static  System.UInt32                   MeshFlag_UpdateUseVertexBack  // 0x0
  public    static  System.UInt32                   MeshFlag_FasterWrite  // 0x0
  public    static  System.UInt32                   MeshFlag_MeshLink  // 0x0
  public            MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo>sharedVirtualMeshInfoList  // 0x18
  public            System.Collections.Generic.Dictionary<System.Int32,System.Int32>sharedVirtualMeshIdToIndexDict  // 0x20
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float2>sharedVirtualUvList  // 0x28
  public            MagicaCloth.FixedChunkNativeArray<System.UInt32>sharedVirtualVertexInfoList  // 0x30
  public            MagicaCloth.FixedChunkNativeArray<MagicaCloth.MeshData.VertexWeight>sharedVirtualWeightList  // 0x38
  public            MagicaCloth.FixedChunkNativeArray<System.Int32>sharedVirtualTriangleList  // 0x40
  public            MagicaCloth.FixedChunkNativeArray<System.UInt32>sharedVirtualVertexToTriangleInfoList  // 0x48
  public            MagicaCloth.FixedChunkNativeArray<System.Int32>sharedVirtualVertexToTriangleIndexList  // 0x50
  public    static  System.Byte                     VirtualVertexFlag_Use  // 0x0
  public            MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo>virtualMeshInfoList  // 0x58
  public            MagicaCloth.FixedChunkNativeArray<System.Int16>virtualVertexMeshIndexList  // 0x60
  public            MagicaCloth.FixedChunkNativeArray<System.Byte>virtualVertexUseList  // 0x68
  public            MagicaCloth.FixedChunkNativeArray<System.Byte>virtualVertexFixList  // 0x70
  public            MagicaCloth.FixedChunkNativeArray<System.Byte>virtualVertexFlagList  // 0x78
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>virtualPosList  // 0x80
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion>virtualRotList  // 0x88
  public            MagicaCloth.FixedChunkNativeArray<System.Int32>virtualTransformIndexList  // 0x90
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>virtualTriangleNormalList  // 0x98
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>virtualTriangleTangentList  // 0xA0
  public            MagicaCloth.FixedChunkNativeArray<System.UInt16>virtualTriangleMeshIndexList  // 0xA8
  public            MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.SharedChildMeshInfo>sharedChildMeshInfoList  // 0xB0
  public            System.Collections.Generic.Dictionary<System.Int64,System.Int32>sharedChildMeshIdToSharedVirtualMeshIndexDict  // 0xB8
  public            MagicaCloth.FixedChunkNativeArray<System.UInt32>sharedChildVertexInfoList  // 0xC0
  public            MagicaCloth.FixedChunkNativeArray<MagicaCloth.MeshData.VertexWeight>sharedChildWeightList  // 0xC8
  public            MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.SharedRenderMeshInfo>sharedRenderMeshInfoList  // 0xD0
  public            System.Collections.Generic.Dictionary<System.Int32,System.Int32>sharedRenderMeshIdToIndexDict  // 0xD8
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>sharedRenderVertices  // 0xE0
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>sharedRenderNormals  // 0xE8
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float4>sharedRenderTangents  // 0xF0
  public            MagicaCloth.FixedChunkNativeArray<System.Byte>sharedBonesPerVertexList  // 0xF8
  public            MagicaCloth.FixedChunkNativeArray<System.Int32>sharedBonesPerVertexStartList  // 0x100
  public            MagicaCloth.FixedChunkNativeArray<UnityEngine.BoneWeight1>sharedBoneWeightList  // 0x108
  public    static  System.UInt32                   RenderVertexFlag_Use  // 0x0
  public    static  System.Int32                    MaxRenderMeshLinkCount  // 0x0
  public            MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo>renderMeshInfoList  // 0x110
  public    static  System.UInt32                   RenderStateFlag_Use  // 0x0
  public    static  System.UInt32                   RenderStateFlag_ExistNormal  // 0x0
  public    static  System.UInt32                   RenderStateFlag_ExistTangent  // 0x0
  public    static  System.UInt32                   RenderStateFlag_FasterWrite  // 0x0
  public    static  System.UInt32                   RenderStateFlag_DelayedCalculated  // 0x0
  public            System.Collections.Generic.Dictionary<System.Int32,MagicaCloth.PhysicsManagerMeshData.RenderMeshState>renderMeshStateDict  // 0x118
  public            MagicaCloth.FixedChunkNativeArray<System.UInt32>renderVertexFlagList  // 0x120
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>renderPosList  // 0x128
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>renderNormalList  // 0x130
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float4>renderTangentList  // 0x138
  public            MagicaCloth.FixedChunkNativeArray<UnityEngine.BoneWeight1>renderBoneWeightList  // 0x140
  private           MagicaCloth.DoubleComputeBuffer<Unity.Mathematics.float3>renderPosBuffer  // 0x148
  private           MagicaCloth.DoubleComputeBuffer<Unity.Mathematics.float3>renderNormalBuffer  // 0x150
  private           UnityEngine.ComputeBuffer       emptyByteAddressBuffer  // 0x158
  private           System.Boolean                  isBeginWrite  // 0x160
  private           System.Collections.Generic.HashSet<MagicaCloth.BaseMeshDeformer>renderMeshSet  // 0x168
  private           System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer>normalWriteList  // 0x170
  private           System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer>fasterWritePositionList  // 0x178
  private           System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer>fasterWritePositionNormalList  // 0x180
METHODS:
  System.Void Create()
  System.Void Dispose()
  System.Void AddMesh(MagicaCloth.BaseMeshDeformer bmesh)
  System.Void RemoveMesh(MagicaCloth.BaseMeshDeformer bmesh)
  System.Int32 AddVirtualMesh(System.Int32 uid, System.Int32 vertexCount, System.Int32 weightCount, System.Int32 boneCount, System.Int32 triangleCount, System.Int32 vertexToTriangleIndexCount, UnityEngine.Transform transform)
  System.Boolean IsEmptySharedVirtualMesh(System.Int32 uid)
  System.Void SetSharedVirtualMeshData(System.Int32 virtualMeshIndex, System.UInt32[] sharedVertexInfoList, MagicaCloth.MeshData.VertexWeight[] sharedWeightList, UnityEngine.Vector2[] sharedUv, System.Int32[] sharedTriangles, System.UInt32[] vertexToTriangleInfoList, System.Int32[] vertexToTriangleIndexList)
  System.Void RemoveVirtualMesh(System.Int32 virtualMeshIndex)
  System.Boolean ExistsVirtualMesh(System.Int32 virtualMeshIndex)
  MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo GetVirtualMeshInfo(System.Int32 virtualMeshIndex)
  System.Boolean IsUseVirtualMesh(System.Int32 virtualMeshIndex)
  System.Boolean IsActiveVirtualMesh(System.Int32 virtualMeshIndex)
  System.Void SetVirtualMeshActive(System.Int32 virtualMeshIndex, System.Boolean sw)
  System.Void AddUseVirtualMesh(System.Int32 virtualMeshIndex)
  System.Void RemoveUseVirtualMesh(System.Int32 virtualMeshIndex)
  System.Boolean AddUseVirtualVertex(System.Int32 virtualMeshIndex, System.Int32 vindex, System.Boolean fix)
  System.Boolean RemoveUseVirtualVertex(System.Int32 virtualMeshIndex, System.Int32 vindex, System.Boolean fix)
  System.Void CopyToVirtualMeshWorldData(System.Int32 virtualMeshIndex, UnityEngine.Vector3[] vertices, UnityEngine.Vector3[] normals, UnityEngine.Vector3[] tangents)
  System.Void AddVirtualMeshBone(System.Int32 virtualMeshIndex, System.Collections.Generic.List<UnityEngine.Transform> boneList)
  System.Void RemoveVirtualMeshBone(System.Int32 virtualMeshIndex)
  System.Void ResetFuturePredictionVirtualMeshBone(System.Int32 virtualMeshIndex)
  System.Void ChangeVirtualMeshUseUnityPhysics(System.Int32 virtualMeshIndex, System.Boolean sw)
  System.Void SetVirtualMeshFlag(System.Int32 virtualMeshIndex, System.UInt32 flag, System.Boolean sw)
  System.Int32 get_SharedVirtualMeshCount()
  System.Int32 get_VirtualMeshCount()
  System.Int32 get_VirtualMeshVertexCount()
  System.Int32 get_VirtualMeshTriangleCount()
  System.Int32 get_VirtualMeshVertexUseCount()
  System.Int32 get_VirtualMeshUseCount()
  System.Int32 get_VirtualMeshPauseCount()
  System.Int32 AddSharedChildMesh(System.Int64 cuid, System.Int32 virtualMeshIndex, System.Int32 vertexCount, System.Int32 weightCount)
  System.Boolean IsEmptySharedChildMesh(System.Int64 cuid)
  System.Void SetSharedChildMeshData(System.Int32 sharedMeshIndex, System.UInt32[] sharedVertexInfoList, MagicaCloth.MeshData.VertexWeight[] sharedVertexWeightList)
  System.Void RemoveSharedChildMesh(System.Int32 sharedChildMeshIndex)
  System.Int32 get_SharedRenderMeshCount()
  System.Int32 get_SharedChildMeshCount()
  System.Int32 AddRenderMesh(System.Int32 uid, System.Boolean isSkinning, System.Boolean isFasterWrite, UnityEngine.Vector3 baseScale, System.Int32 vertexCount, System.Int32 rendererBoneIndex, System.Int32 boneWeightCount)
  System.Void UpdateMeshState(System.Int32 renderMeshIndex)
  System.Void AddRenderMeshBone(System.Int32 renderMeshIndex, UnityEngine.Transform rendererTransform)
  System.Boolean IsEmptySharedRenderMesh(System.Int32 uid)
  System.Void SetRenderSharedMeshData(System.Int32 renderMeshIndex, System.Boolean isSkinning, UnityEngine.Vector3[] sharedVertices, UnityEngine.Vector3[] sharedNormals, UnityEngine.Vector4[] sharedTangents, Unity.Collections.NativeArray<System.Byte> sharedBonesPerVertex, Unity.Collections.NativeArray<UnityEngine.BoneWeight1> sharedBoneWeights)
  System.Void RemoveRenderMesh(System.Int32 renderMeshIndex)
  System.Void RemoveRenderMeshBone(System.Int32 renderMeshIndex)
  System.Void ChangeRenderMeshUseUnityPhysics(System.Int32 renderMeshIndex, System.Boolean sw)
  System.Boolean IsUseRenderMesh(System.Int32 renderMeshIndex)
  System.Boolean IsActiveRenderMesh(System.Int32 renderMeshIndex)
  System.Void SetRenderMeshFlag(System.Int32 renderMeshIndex, System.UInt32 flag, System.Boolean sw)
  System.Boolean IsRenderMeshFlag(System.Int32 renderMeshIndex, System.UInt32 flag)
  System.Void SetRenderMeshActive(System.Int32 renderMeshIndex, System.Boolean sw)
  System.Void AddUseRenderMesh(System.Int32 renderMeshIndex)
  System.Void RemoveUseRenderMesh(System.Int32 renderMeshIndex)
  System.Void LinkRenderMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart)
  System.Void UnlinkRenderMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart)
  System.Void CopyToRenderMeshLocalPositionData(System.Int32 renderMeshIndex, UnityEngine.Mesh mesh, System.Int32 bufferIndex)
  System.Void CopyToRenderMeshLocalNormalTangentData(System.Int32 renderMeshIndex, UnityEngine.Mesh mesh, System.Int32 bufferIndex, System.Boolean normal, System.Boolean tangent)
  System.Void CopyToRenderMeshBoneWeightData(System.Int32 renderMeshIndex, UnityEngine.Mesh mesh, UnityEngine.Mesh sharedMesh, System.Int32 bufferIndex)
  System.Void CopyToRenderMeshWorldData(System.Int32 renderMeshIndex, UnityEngine.Transform target, UnityEngine.Vector3[] vertices, UnityEngine.Vector3[] normals, UnityEngine.Vector3[] tangents)
  System.Collections.Generic.List<System.Int32> GetVertexUseList(System.Int32 renderMeshIndex)
  System.Int32 get_RenderMeshCount()
  System.Int32 get_RenderMeshVertexCount()
  System.Int32 get_RenderMeshUseCount()
  System.Int32 get_RenderMeshVertexUseCount()
  System.Int32 get_RenderMeshPauseCount()
  System.Void SetDelayedCalculatedFlag()
  System.Void ClearWritingList()
  System.Void MeshCalculation(System.Int32 bufferIndex)
  System.Void NormalWriting(System.Int32 bufferIndex)
  System.Void CopyToRenderVertexBuffer(System.Int32 renderMeshIndex, System.Int32 bufferIndex, UnityEngine.GraphicsBuffer vertexBuffer, System.Boolean normal, UnityEngine.ComputeShader compute, System.Int32 kernel, System.Int32 index)
  System.Void UpdateVertexBuffer()
  System.Void FinishVertexBuffer()
  System.Void FasterWriting(System.Int32 bufferIndex)
  System.Void DispatchWriting(System.Int32 kernel, System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer> rlist, System.Int32 bufferIndex)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerParticleData
TYPE:  class
TOKEN: 0x20000BC
EXTENDS: PhysicsManagerAccess
FIELDS:
  public    static  System.UInt32                   Flag_Enable  // 0x0
  public    static  System.UInt32                   Flag_Kinematic  // 0x0
  public    static  System.UInt32                   Flag_Hold  // 0x0
  public    static  System.UInt32                   Flag_Collider  // 0x0
  public    static  System.UInt32                   Flag_Plane  // 0x0
  public    static  System.UInt32                   Flag_CapsuleX  // 0x0
  public    static  System.UInt32                   Flag_CapsuleY  // 0x0
  public    static  System.UInt32                   Flag_CapsuleZ  // 0x0
  public    static  System.UInt32                   Flag_Box  // 0x0
  public    static  System.UInt32                   Flag_TriangleRotation  // 0x0
  public    static  System.UInt32                   Flag_Transform_Read_Pos  // 0x0
  public    static  System.UInt32                   Flag_Transform_Read_Rot  // 0x0
  public    static  System.UInt32                   Flag_Transform_Read_Base  // 0x0
  public    static  System.UInt32                   Flag_Transform_Read_Local  // 0x0
  public    static  System.UInt32                   Flag_Transform_Read_Scl  // 0x0
  public    static  System.UInt32                   Flag_Transform_Write  // 0x0
  public    static  System.UInt32                   Flag_Transform_Restore  // 0x0
  public    static  System.UInt32                   Flag_Transform_UnityPhysics  // 0x0
  public    static  System.UInt32                   Flag_Transform_Parent  // 0x0
  public    static  System.UInt32                   Flag_Step_Update  // 0x0
  public    static  System.UInt32                   Flag_Reset_Position  // 0x0
  public            MagicaCloth.FixedChunkNativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag>flagList  // 0x18
  public            MagicaCloth.FixedChunkNativeArray<System.Int32>teamIdList  // 0x20
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>posList  // 0x28
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion>rotList  // 0x30
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>oldPosList  // 0x38
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion>oldRotList  // 0x40
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>oldSlowPosList  // 0x48
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>localPosList  // 0x50
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>basePosList  // 0x58
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion>baseRotList  // 0x60
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>snapBasePosList  // 0x68
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion>snapBaseRotList  // 0x70
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>oldBasePosList  // 0x78
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion>oldBaseRotList  // 0x80
  public            MagicaCloth.FixedChunkNativeArray<System.Single>depthList  // 0x88
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>radiusList  // 0x90
  public            MagicaCloth.FixedChunkNativeArray<System.Int32>restoreTransformIndexList  // 0x98
  public            MagicaCloth.FixedChunkNativeArray<System.Int32>transformIndexList  // 0xA0
  public            MagicaCloth.FixedChunkNativeArray<System.Single>frictionList  // 0xA8
  public            MagicaCloth.FixedChunkNativeArray<System.Single>staticFrictionList  // 0xB0
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>velocityList  // 0xB8
  public            MagicaCloth.FixedChunkNativeArray<System.Int32>collisionLinkIdList  // 0xC0
  public            MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>collisionNormalList  // 0xC8
  private           MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>nextPos0List  // 0xD0
  private           MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3>nextPos1List  // 0xD8
  private           System.Int32                    nextPosSwitch  // 0xE0
  private           MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion>nextRot0List  // 0xE8
  private           MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion>nextRot1List  // 0xF0
  private           System.Int32                    nextRotSwitch  // 0xF8
  private           System.Int32                    colliderCount  // 0xFC
METHODS:
  System.Void Create()
  System.Void Dispose()
  MagicaCloth.ChunkData CreateParticle(System.UInt32 flag, System.Int32 team, Unity.Mathematics.float3 wpos, Unity.Mathematics.quaternion wrot, System.Single depth, Unity.Mathematics.float3 radius, Unity.Mathematics.float3 targetLocalPos)
  MagicaCloth.ChunkData CreateParticle(System.Int32 team, System.Int32 count, System.Func<System.Int32,System.UInt32> funcFlag, System.Func<System.Int32,Unity.Mathematics.float3> funcWpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcWrot, System.Func<System.Int32,System.Single> funcDepth, System.Func<System.Int32,Unity.Mathematics.float3> funcRadius, System.Func<System.Int32,Unity.Mathematics.float3> funcTargetLocalPos)
  System.Void RemoveParticle(MagicaCloth.ChunkData c)
  System.Void SetEnable(MagicaCloth.ChunkData c, System.Boolean sw, System.Func<System.Int32,UnityEngine.Transform> funcTarget, System.Func<System.Int32,Unity.Mathematics.float3> funcLpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcLrot)
  System.Void SetRadius(System.Int32 index, Unity.Mathematics.float3 radius)
  System.Void SetLocalPos(System.Int32 index, UnityEngine.Vector3 lpos)
  System.Int32 get_Count()
  System.Int32 get_Length()
  System.Int32 get_ColliderCount()
  System.Boolean IsValid(System.Int32 index)
  System.Int32 GetTeamId(System.Int32 index)
  System.Void ResetFuturePredictionTransform(System.Int32 index)
  System.Void ResetFuturePredictionTransform(MagicaCloth.ChunkData c)
  MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> get_InNextPosList()
  MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> get_OutNextPosList()
  System.Void SwitchingNextPosList()
  MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> get_InNextRotList()
  MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> get_OutNextRotList()
  System.Void SwitchingNextRotList()
  System.Void UpdateBoneToParticle()
  System.Void UpdateResetParticle()
  System.Boolean UpdateParticleToBone()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerTeamData
TYPE:  class
TOKEN: 0x20000C1
EXTENDS: PhysicsManagerAccess
FIELDS:
  public    static  System.UInt32                   Flag_Enable  // 0x0
  public    static  System.UInt32                   Flag_Interpolate  // 0x0
  public    static  System.UInt32                   Flag_FixedNonRotation  // 0x0
  public    static  System.UInt32                   Flag_AnimatedPose  // 0x0
  public    static  System.UInt32                   Flag_IgnoreClampPositionVelocity  // 0x0
  public    static  System.UInt32                   Flag_Collision  // 0x0
  public    static  System.UInt32                   Flag_AfterCollision  // 0x0
  public    static  System.UInt32                   Flag_UpdatePhysics  // 0x0
  public    static  System.UInt32                   Flag_Pause  // 0x0
  public    static  System.UInt32                   Flag_Reset_WorldInfluence  // 0x0
  public    static  System.UInt32                   Flag_Reset_Position  // 0x0
  public    static  System.UInt32                   Flag_Reset_Keep  // 0x0
  public    static  System.UInt32                   Flag_Wind  // 0x0
  public            MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerTeamData.TeamData>teamDataList  // 0x18
  public            MagicaCloth.FixedNativeList<MagicaCloth.CurveParam>teamMassList  // 0x20
  public            MagicaCloth.FixedNativeList<MagicaCloth.CurveParam>teamGravityList  // 0x28
  public            MagicaCloth.FixedNativeList<MagicaCloth.CurveParam>teamDragList  // 0x30
  public            MagicaCloth.FixedNativeList<MagicaCloth.CurveParam>teamMaxVelocityList  // 0x38
  public            MagicaCloth.FixedNativeList<MagicaCloth.CurveParam>teamDepthInfluenceList  // 0x40
  public            MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerTeamData.WorldInfluence>teamWorldInfluenceList  // 0x48
  public            MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerTeamData.WindInfo>teamWindInfoList  // 0x50
  public            MagicaCloth.FixedMultiNativeList<System.Int32>colliderList  // 0x58
  public            MagicaCloth.FixedMultiNativeList<System.Int32>skinningBoneList  // 0x60
  private           System.Collections.Generic.Dictionary<System.Int32,MagicaCloth.PhysicsTeam>teamComponentDict  // 0x68
  private           System.Int32                    activeTeamCount  // 0x70
  private           System.Int32                    normalUpdateCount  // 0x74
  private           System.Int32                    physicsUpdateCount  // 0x78
METHODS:
  System.Void Create()
  System.Void Dispose()
  System.Int32 get_TeamCount()
  System.Int32 get_TeamLength()
  System.Int32 get_ActiveTeamCount()
  System.Int32 get_ColliderCount()
  System.Int32 get_NormalUpdateCount()
  System.Int32 get_PhysicsUpdateCount()
  System.Int32 get_PauseCount()
  System.Int32 CreateTeam(MagicaCloth.PhysicsTeam team, System.UInt32 flag)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void SetEnable(System.Int32 teamId, System.Boolean sw)
  System.Boolean IsValid(System.Int32 teamId)
  System.Boolean IsValidData(System.Int32 teamId)
  System.Boolean IsActive(System.Int32 teamId)
  System.Void SetFlag(System.Int32 teamId, System.UInt32 flag, System.Boolean sw)
  System.Boolean IsFlag(System.Int32 teamId, System.UInt32 flag)
  System.Void SetParticleChunk(System.Int32 teamId, MagicaCloth.ChunkData chunk)
  System.Void SetFriction(System.Int32 teamId, System.Single dynamicFriction, System.Single staticFriction)
  System.Void SetMass(System.Int32 teamId, MagicaCloth.BezierParam mass)
  System.Void SetGravity(System.Int32 teamId, MagicaCloth.BezierParam gravity)
  System.Void SetGravityDirection(System.Int32 teamId, Unity.Mathematics.float3 dir)
  System.Void SetDrag(System.Int32 teamId, MagicaCloth.BezierParam drag)
  System.Void SetMaxVelocity(System.Int32 teamId, MagicaCloth.BezierParam maxVelocity)
  System.Void SetExternalForce(System.Int32 teamId, System.Single massInfluence, System.Single windInfluence, System.Single windRandomScale, System.Single windSynchronization)
  System.Void SetDepthInfluence(System.Int32 teamId, MagicaCloth.BezierParam depthInfluence)
  System.Void SetWorldInfluence(System.Int32 teamId, System.Single maxSpeed, System.Single maxRotatinSpeed, MagicaCloth.BezierParam moveInfluence, MagicaCloth.BezierParam rotInfluence, System.Boolean resetTeleport, System.Single teleportDistance, System.Single teleportRotation, System.Single resetStabilizationTime, MagicaCloth.ClothParams.TeleportMode teleportMode, System.Boolean useClampRotation, MagicaCloth.BezierParam clampRotation)
  System.Single CalcClampRotationLimit(System.Boolean useClampRotation, MagicaCloth.BezierParam clampRotation)
  System.Void SetWorldInfluence(System.Int32 teamId, System.Single maxSpeed, System.Single maxRotationSpeed, MagicaCloth.BezierParam moveInfluence, MagicaCloth.BezierParam rotInfluence)
  System.Void SetAfterTeleport(System.Int32 teamId, System.Boolean resetTeleport, System.Single teleportDistance, System.Single teleportRotation, MagicaCloth.ClothParams.TeleportMode teleportMode)
  System.Void SetStabilizationTime(System.Int32 teamId, System.Single resetStabilizationTime)
  System.Void ResetWorldInfluenceTarget(System.Int32 teamId, UnityEngine.Transform target)
  System.Void SetClampRotation(System.Int32 teamId, System.Boolean useClampRotation, MagicaCloth.BezierParam clampRotation)
  System.Void SetSelfCollisionRange(System.Int32 teamId, System.Single range)
  System.Void SetBoneIndex(System.Int32 teamId, System.Int32 boneIndex, UnityEngine.Vector3 initScale)
  System.Void AddColliderParticle(System.Int32 teamId, System.Int32 particleIndex)
  System.Void RemoveColliderParticle(System.Int32 teamId, System.Int32 particleIndex)
  System.Void RemoveCollider(System.Int32 teamId, MagicaCloth.ColliderComponent collider)
  System.Void ResetFuturePredictionCollidere(System.Int32 teamId)
  System.Void AddSkinningBoneIndex(System.Int32 teamId, System.Collections.Generic.List<UnityEngine.Transform> boneList)
  System.Void RemoveSkinningBoneIndex(System.Int32 teamId)
  System.Void SetTimeScale(System.Int32 teamId, System.Single timeScale)
  System.Single GetTimeScale(System.Int32 teamId)
  System.Void SetBlendRatio(System.Int32 teamId, System.Single blendRatio)
  System.Single GetBlendRatio(System.Int32 teamId)
  System.Void SetOutPhysicsPoseBlendRatio(System.Int32 teamId, System.Single blendRatio)
  System.Single GetOutPhysicsPoseBlendRatio(System.Int32 teamId)
  System.Void SetImpactForce(System.Int32 teamId, Unity.Mathematics.float3 force, MagicaCloth.PhysicsManagerTeamData.ForceMode mode)
  System.Void ResetStabilizationTime(System.Int32 teamId, System.Single resetStabilizationTime)
  System.Void SetUpdateMode(System.Int32 teamId, MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode)
  System.Void ChangeUseUnityPhysics(System.Int32 teamId, System.Boolean sw)
  System.Void ChangeParticleUseUnityPhysics(System.Int32 pindex, System.Boolean unityPhysics)
  System.Void ChangeBoneFlag(System.Int32 teamId, MagicaCloth.PhysicsTeam.TeamCullingMode cullingMode, System.Boolean isCalculation)
  System.Void EarlyUpdateTeamAlways()
  System.Void PreUpdateTeamAlways()
  System.Int32 CalcMaxUpdateCount(System.Int32 ups, System.Single deltaTime, System.Single physicsDeltaTime, System.Single updateDeltaTime)
  System.Void PreUpdateTeamData(System.Single deltaTime, System.Single physicsDeltaTime, System.Single updateDeltaTime, System.Int32 ups, System.Int32 maxUpdateCount)
  System.Void PostUpdateTeamData()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerWindData
TYPE:  class
TOKEN: 0x20000C9
EXTENDS: PhysicsManagerAccess
FIELDS:
  public    static  System.UInt32                   Flag_Enable  // 0x0
  public    static  System.UInt32                   Flag_Addition  // 0x0
  public            MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerWindData.WindData>windDataList  // 0x18
METHODS:
  System.Void Create()
  System.Void Dispose()
  System.Int32 CreateWind(MagicaCloth.PhysicsManagerWindData.WindType windType, MagicaCloth.PhysicsManagerWindData.ShapeType shapeType, Unity.Mathematics.float3 areaSize, System.Boolean addition, System.Single main, System.Single turbulence, System.Single frequency, Unity.Mathematics.float3 direction, MagicaCloth.PhysicsManagerWindData.DirectionType directinType, System.Single areaVolume, System.Single areaLength, MagicaCloth.BezierParam attenuation)
  System.Void RemoveWind(System.Int32 windId)
  System.Void SetEnable(System.Int32 windId, System.Boolean sw, UnityEngine.Transform target)
  System.Boolean IsActive(System.Int32 windId)
  System.Void SetFlag(System.Int32 windId, System.UInt32 flag, System.Boolean sw)
  System.Void SetParameter(System.Int32 windId, Unity.Mathematics.float3 areaSize, System.Boolean addition, System.Single main, System.Single turbulence, System.Single frequency, Unity.Mathematics.float3 direction, System.Single areaVolume, System.Single areaLength, MagicaCloth.BezierParam attenuation)
  System.Int32 get_Count()
  Unity.Mathematics.float3 CalcWindForce(System.Single time, Unity.Mathematics.float2 noiseBasePos, Unity.Mathematics.float3 mainDir, System.Single main, System.Single turbulence, System.Single frequency, System.Single randomScale)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsManagerWorker
TYPE:  class
TOKEN: 0x20000CE
FIELDS:
  private           MagicaCloth.MagicaPhysicsManager<Manager>k__BackingField  // 0x10
METHODS:
  MagicaCloth.MagicaPhysicsManager get_Manager()
  System.Void set_Manager(MagicaCloth.MagicaPhysicsManager value)
  System.Void Start()
  System.Void Init(MagicaCloth.MagicaPhysicsManager manager)
  System.Void Create()
  System.Void RemoveGroup(System.Int32 group)
  System.Void Release()
  System.Void Warmup()
  Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ColliderComponent
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: ParticleComponent
FIELDS:
  protected         System.Boolean                  isGlobal  // 0x28
  private           UnityEngine.Vector3             center  // 0x2C
METHODS:
  UnityEngine.Vector3 get_Center()
  System.Void set_Center(UnityEngine.Vector3 value)
  System.Void OnInit()
  System.Void OnDispose()
  System.Int32 GetDataHash()
  System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning)
  UnityEngine.Vector3 CalcLocalPos(UnityEngine.Vector3 pos)
  UnityEngine.Vector3 CalcLocalDir(UnityEngine.Vector3 dir)
  MagicaCloth.ChunkData CreateColliderParticle(System.Int32 teamId)
  System.Void RemoveColliderParticle(System.Int32 teamId)
  MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaCapsuleCollider
TYPE:  class
TOKEN: 0x20000D0
EXTENDS: ColliderComponent
FIELDS:
  private           MagicaCloth.MagicaCapsuleCollider.Axisaxis  // 0x38
  private           System.Single                   length  // 0x3C
  private           System.Single                   startRadius  // 0x40
  private           System.Single                   endRadius  // 0x44
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  System.Void OnValidate()
  System.Void DataUpdate()
  System.Int32 GetDataHash()
  MagicaCloth.MagicaCapsuleCollider.Axis get_AxisMode()
  System.Void set_AxisMode(MagicaCloth.MagicaCapsuleCollider.Axis value)
  System.Single get_Length()
  System.Void set_Length(System.Single value)
  System.Single get_StartRadius()
  System.Void set_StartRadius(System.Single value)
  System.Single get_EndRadius()
  System.Void set_EndRadius(System.Single value)
  MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId)
  System.UInt32 GetCapsuleFlag()
  UnityEngine.Vector3 GetLocalDir()
  UnityEngine.Vector3 GetLocalUp()
  System.Single GetScale()
  System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaPlaneCollider
TYPE:  class
TOKEN: 0x20000D2
EXTENDS: ColliderComponent
FIELDS:
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  System.Void OnValidate()
  System.Void DataUpdate()
  MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId)
  System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MagicaSphereCollider
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: ColliderComponent
FIELDS:
  private           System.Single                   radius  // 0x38
METHODS:
  MagicaCloth.ComponentType GetComponentType()
  System.Void OnValidate()
  System.Void DataUpdate()
  System.Single get_Radius()
  System.Void set_Radius(System.Single value)
  System.Int32 GetDataHash()
  MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId)
  System.Single GetScale()
  System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ParticleComponent
TYPE:  class
TOKEN: 0x20000D4
EXTENDS: BaseComponent
FIELDS:
  protected         System.Collections.Generic.Dictionary<System.Int32,MagicaCloth.ChunkData>particleDict  // 0x18
  protected         MagicaCloth.RuntimeStatus       status  // 0x20
METHODS:
  MagicaCloth.RuntimeStatus get_Status()
  System.Int32 GetDataHash()
  System.Int32 get_CenterParticleIndex()
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Init()
  System.Void OnUpdateStatus()
  System.Boolean VerifyData()
  System.Void OnInit()
  System.Void OnDispose()
  System.Void OnUpdate()
  System.Void OnActive()
  System.Void OnInactive()
  System.Void EnableParticle()
  System.Void DisableParticle()
  System.Void EnableTeamParticle(System.Int32 teamId)
  System.Void DisableTeamParticle(System.Int32 teamId)
  System.Void ReserveDataUpdate()
  System.Void DataUpdate()
  System.Void UpdateStatus()
  MagicaCloth.ChunkData CreateParticle(System.UInt32 flag, System.Int32 teamId, System.Single depth, Unity.Mathematics.float3 radius, Unity.Mathematics.float3 localPos)
  System.Void RemoveTeamParticle(System.Int32 teamId)
  System.Void RemoveParticle()
  UnityEngine.Transform UserTransform(System.Int32 vindex)
  Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex)
  Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex)
  System.Void .ctor()
  System.Object <Init>b__11_0()
END_CLASS

CLASS: MagicaCloth.PhysicsTeam
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: CoreComponent
FIELDS:
  protected         MagicaCloth.PhysicsTeamData     teamData  // 0x38
  private           System.Single                   userBlendWeight  // 0x40
  private           System.Single                   userPhysicsBlendWeight  // 0x44
  private           System.Boolean                  syncBlendWeightToPoseBlendWeight  // 0x48
  private           System.Single                   userCloseThreshold  // 0x4C
  private           MagicaCloth.PhysicsTeam.TeamUpdateModeupdateMode  // 0x50
  private           MagicaCloth.PhysicsTeam.TeamCullingModecullingMode  // 0x54
  private           MagicaCloth.PhysicsTeam.TeamSkinningModeskinningMode  // 0x58
  protected         System.Int32                    teamId  // 0x5C
  protected         MagicaCloth.ChunkData           particleChunk  // 0x60
  protected         UnityEngine.Transform           influenceTarget  // 0x70
METHODS:
  System.Int32 GetDataHash()
  System.Int32 get_TeamId()
  MagicaCloth.PhysicsTeamData get_TeamData()
  MagicaCloth.ChunkData get_ParticleChunk()
  System.Void set_InfluenceTarget(UnityEngine.Transform value)
  UnityEngine.Transform get_InfluenceTarget()
  System.Single get_UserBlendWeight()
  System.Void set_UserBlendWeight(System.Single value)
  System.Single get_UserPhysicsBlendWeight()
  System.Void set_UserPhysicsBlendWeight(System.Single value)
  System.Boolean get_SyncBlendWeightToPoseBlendWeight()
  System.Void set_SyncBlendWeightToPoseBlendWeight(System.Boolean value)
  System.Single get_UserCloseThreshold()
  System.Void set_UserCloseThreshold(System.Single value)
  MagicaCloth.PhysicsTeam.TeamUpdateMode get_UpdateMode()
  System.Void set_UpdateMode(MagicaCloth.PhysicsTeam.TeamUpdateMode value)
  MagicaCloth.PhysicsTeam.TeamCullingMode get_CullingMode()
  System.Void set_CullingMode(MagicaCloth.PhysicsTeam.TeamCullingMode value)
  MagicaCloth.PhysicsTeam.TeamSkinningMode get_SkinningMode()
  System.Void set_SkinningMode(MagicaCloth.PhysicsTeam.TeamSkinningMode value)
  System.Boolean get_UseAnimatedPose()
  System.Void OnInit()
  System.Void OnDispose()
  System.Void OnUpdate()
  System.Void OnActive()
  System.Void OnInactive()
  System.Boolean IsActive()
  System.Boolean IsValid()
  MagicaCloth.ChunkData CreateParticle(System.Int32 team, System.Int32 count, System.Func<System.Int32,System.UInt32> funcFlag, System.Func<System.Int32,Unity.Mathematics.float3> funcWpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcWrot, System.Func<System.Int32,System.Single> funcDepth, System.Func<System.Int32,Unity.Mathematics.float3> funcRadius, System.Func<System.Int32,Unity.Mathematics.float3> funcTargetLocalPos)
  System.Void RemoveAllParticle()
  System.Void EnableParticle(System.Func<System.Int32,UnityEngine.Transform> funcTarget, System.Func<System.Int32,Unity.Mathematics.float3> funcLpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcLrot)
  System.Void DisableParticle(System.Func<System.Int32,UnityEngine.Transform> funcTarget, System.Func<System.Int32,Unity.Mathematics.float3> funcLpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcLrot)
  MagicaCloth.Define.Error VerifyData()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.PhysicsTeamData
TYPE:  class
TOKEN: 0x20000D9
FIELDS:
  private           System.Collections.Generic.List<MagicaCloth.ColliderComponent>colliderList  // 0x10
  private           System.Collections.Generic.List<MagicaCloth.ColliderComponent>penetrationIgnoreColliderList  // 0x18
  private           System.Boolean                  mergeAvatarCollider  // 0x20
  private           System.Collections.Generic.List<MagicaCloth.ColliderComponent>addColliderList  // 0x28
METHODS:
  System.Int32 GetDataHash()
  System.Void Init(System.Int32 teamId)
  System.Void Dispose(System.Int32 teamId)
  System.Void AddCollider(MagicaCloth.ColliderComponent collider)
  System.Void RemoveCollider(MagicaCloth.ColliderComponent collider)
  System.Void UpdateStatus()
  System.Int32 get_ColliderCount()
  System.Collections.Generic.List<MagicaCloth.ColliderComponent> get_ColliderList()
  System.Collections.Generic.List<MagicaCloth.ColliderComponent> get_PenetrationIgnoreColliderList()
  System.Boolean get_MergeAvatarCollider()
  System.Void ValidateColliderList()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.AdjustRotationWorker
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: PhysicsManagerWorker
FIELDS:
  private   static  System.Int32                    AdjustMode_Fixed  // 0x0
  private   static  System.Int32                    AdjustMode_XYMove  // 0x0
  private   static  System.Int32                    AdjustMode_XZMove  // 0x0
  private   static  System.Int32                    AdjustMode_YZMove  // 0x0
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.AdjustRotationWorker.AdjustRotationData>dataList  // 0x18
  public            MagicaCloth.FixedNativeList<MagicaCloth.AdjustRotationWorker.GroupData>groupList  // 0x20
  private           MagicaCloth.ExNativeMultiHashMap<System.Int32,System.Int32>particleMap  // 0x28
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Int32 adjustMode, Unity.Mathematics.float3 axisRotationPower, MagicaCloth.AdjustRotationWorker.AdjustRotationData[] dataArray)
  System.Void RemoveGroup(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Int32 adjustMode, Unity.Mathematics.float3 axisRotationPower)
  System.Void Warmup()
  Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.BaseSkinningWorker
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: PhysicsManagerWorker
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.BaseSkinningWorker.BaseSkinningData>dataList  // 0x18
  private           MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float4x4>bindPoseList  // 0x20
  public            MagicaCloth.FixedNativeList<MagicaCloth.BaseSkinningWorker.GroupData>groupList  // 0x28
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Boolean updateFixed, MagicaCloth.BaseSkinningWorker.BaseSkinningData[] skinningDataList, Unity.Mathematics.float4x4[] skinningBindPoseList)
  System.Void RemoveGroup(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean updateFixed)
  System.Void Warmup()
  Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.LineWorker
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: PhysicsManagerWorker
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.LineWorker.LineRotationData>dataList  // 0x18
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.LineWorker.LineRotationRootInfo>rootInfoList  // 0x20
  public            MagicaCloth.FixedNativeList<MagicaCloth.LineWorker.GroupData>groupList  // 0x28
  private           MagicaCloth.FixedChunkNativeArray<System.Int32>rootTeamList  // 0x30
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, System.Boolean avarage, MagicaCloth.LineWorker.LineRotationData[] dataArray, MagicaCloth.LineWorker.LineRotationRootInfo[] rootInfoArray)
  System.Void RemoveGroup(System.Int32 teamId)
  System.Void ChangeParam(System.Int32 teamId, System.Boolean avarage)
  System.Void Warmup()
  Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.MeshParticleWorker
TYPE:  class
TOKEN: 0x20000E7
EXTENDS: PhysicsManagerWorker
FIELDS:
  private           MagicaCloth.ExNativeMultiHashMap<System.Int32,System.Int32>vertexToParticleMap  // 0x18
  private           MagicaCloth.FixedNativeListWithCount<System.Int32>vertexToParticleList  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<MagicaCloth.MeshParticleWorker.CreateData>>groupCreateDict  // 0x28
METHODS:
  System.Void Create()
  System.Void Release()
  System.Void Add(System.Int32 group, System.Int32 vindex, System.Int32 pindex)
  System.Void RemoveGroup(System.Int32 group)
  System.Void Warmup()
  Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.RenderMeshWorker
TYPE:  class
TOKEN: 0x20000EB
EXTENDS: PhysicsManagerWorker
FIELDS:
METHODS:
  System.Void Create()
  System.Void Release()
  System.Void RemoveGroup(System.Int32 group)
  System.Boolean IsPerformMeshProcessForEachParticle()
  System.Void Warmup()
  Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void CollectionVertex(MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo& r_minfo, Unity.Collections.NativeArray<System.UInt32>& sharedChildVertexInfoList, Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight>& sharedChildVertexWeightList, Unity.Collections.NativeArray<Unity.Mathematics.float3>& virtualPosList, Unity.Collections.NativeArray<Unity.Mathematics.quaternion>& virtualRotList, Unity.Mathematics.float3& tpos, Unity.Mathematics.quaternion& trot, Unity.Mathematics.float3& tscl, Unity.Mathematics.quaternion& itrot, System.Single scaleRatio, Unity.Mathematics.float3& scaleDirection, System.Boolean calcNormal, System.Boolean calcTangent, System.Int32 vindex, System.Int32 i, System.UInt32 flag, System.Boolean isFasterWrite, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderPosList, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderNormalList, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderPosArray, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderNomalArray, Unity.Collections.NativeArray<Unity.Mathematics.float4>& renderTangentList)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.SpringMeshWorker
TYPE:  class
TOKEN: 0x20000EF
EXTENDS: PhysicsManagerWorker
FIELDS:
  private           MagicaCloth.ExNativeMultiHashMap<System.Int32,MagicaCloth.SpringMeshWorker.SpringData>springMap  // 0x18
  private           MagicaCloth.FixedNativeListWithCount<System.Int32>springVertexList  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>>groupIndexDict  // 0x28
METHODS:
  System.Void Create()
  System.Void Release()
  System.Void Add(System.Int32 group, System.Int32 vertexIndex, System.Int32 particleIndex, System.Single weight)
  System.Void RemoveGroup(System.Int32 group)
  System.Void Warmup()
  Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.TriangleWorker
TYPE:  class
TOKEN: 0x20000F2
EXTENDS: PhysicsManagerWorker
FIELDS:
  private           MagicaCloth.FixedChunkNativeArray<MagicaCloth.TriangleWorker.TriangleRotationData>triangleDataList  // 0x18
  private           MagicaCloth.FixedChunkNativeArray<System.Int32>triangleIndexList  // 0x20
  public            MagicaCloth.FixedNativeList<MagicaCloth.TriangleWorker.GroupData>groupList  // 0x28
METHODS:
  System.Void Create()
  System.Void Release()
  System.Int32 AddGroup(System.Int32 teamId, MagicaCloth.TriangleWorker.TriangleRotationData[] dataArray, System.Int32[] indexArray)
  System.Void RemoveGroup(System.Int32 teamId)
  System.Void Warmup()
  Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.VirtualMeshWorker
TYPE:  class
TOKEN: 0x20000F6
EXTENDS: PhysicsManagerWorker
FIELDS:
METHODS:
  System.Void Create()
  System.Void Release()
  System.Void RemoveGroup(System.Int32 group)
  System.Boolean IsPerformMeshProcessForEachParticle()
  System.Void Warmup()
  Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.AutoMove
TYPE:  class
TOKEN: 0x20000FB
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Vector3             direction  // 0x18
  private           System.Single                   length  // 0x24
  private           System.Single                   interval  // 0x28
  private           UnityEngine.Vector3             startPosition  // 0x2C
  private           System.Single                   time  // 0x38
METHODS:
  System.Void Start()
  System.Void Update()
  System.Void OnMoveButton()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.AutoRotate
TYPE:  class
TOKEN: 0x20000FC
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Vector3             rotateAngle  // 0x18
  private           System.Single                   interval  // 0x24
  private           System.Single                   time  // 0x28
METHODS:
  System.Void Start()
  System.Void Update()
  System.Void OnMoveButton()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.BlastWaveController
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: MonoBehaviour
FIELDS:
  public            MagicaCloth.MagicaAreaWind      wind  // 0x18
  public            System.Single                   attenuationStartTime  // 0x20
  public            System.Single                   attenuationTime  // 0x24
METHODS:
  System.Collections.IEnumerator Start()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.CameraOrbit
TYPE:  class
TOKEN: 0x20000FF
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Transform           cameraTransform  // 0x18
  public            UnityEngine.Transform           cameraTarget  // 0x20
  public            UnityEngine.Vector3             cameraTargetPos  // 0x28
  public            UnityEngine.Vector3             cameraTargetOffset  // 0x34
  private           System.Single                   cameraDist  // 0x40
  private           System.Single                   cameraPitch  // 0x44
  private           System.Single                   cameraYaw  // 0x48
  private           System.Single                   cameraDistHokanTime  // 0x4C
  private           System.Single                   cameraAngleHokanTime  // 0x50
  private           System.Single                   cameraDistSpeed  // 0x54
  private           System.Single                   cameraDistMax  // 0x58
  private           System.Single                   cameraDistMin  // 0x5C
  private           System.Single                   cameraYawSpeed  // 0x60
  private           System.Single                   cameraPitchSpeed  // 0x64
  private           System.Single                   cameraMaxAngleSpeed  // 0x68
  private           System.Single                   cameraPitchMax  // 0x6C
  private           System.Single                   cameraPitchMin  // 0x70
  private           MagicaCloth.CameraOrbit.MoveModemoveMode  // 0x74
  private           System.Single                   moveSpeed  // 0x78
  private           System.Single                   setCameraDist  // 0x7C
  private           System.Single                   setCameraPitch  // 0x80
  private           System.Single                   setCameraYaw  // 0x84
  private           System.Single                   cameraDistVelocity  // 0x88
  private           System.Single                   cameraPitchVelocity  // 0x8C
  private           System.Single                   cameraYawVelocity  // 0x90
METHODS:
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void LateUpdate()
  System.Void updateCamera()
  System.Void updatePitchYaw(UnityEngine.Vector2 speed)
  System.Void updateOffset(UnityEngine.Vector2 speed)
  System.Void updateZoom(System.Single speed)
  System.Void OnTouchMove(System.Int32 fid, UnityEngine.Vector2 screenPos, UnityEngine.Vector2 screenVelocity, UnityEngine.Vector2 cmVelocity)
  System.Void OnDoubleTouchMove(System.Int32 fid, UnityEngine.Vector2 screenPos, UnityEngine.Vector2 screenVelocity, UnityEngine.Vector2 cmVelocity)
  System.Void OnTouchPinch(System.Single speedscr, System.Single speedcm)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.CopyObject
TYPE:  class
TOKEN: 0x2000101
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Int32                    seed  // 0x18
  public            System.Int32                    count  // 0x1C
  public            System.Single                   radius  // 0x20
  public            UnityEngine.GameObject          prefab  // 0x28
  public            System.Int32                    delayFrame  // 0x30
METHODS:
  System.Void Awake()
  System.Void Start()
  System.Collections.IEnumerator CreateObject()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.DressUpControl
TYPE:  class
TOKEN: 0x2000103
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.GameObject          partsItemPrefab  // 0x18
  private           UnityEngine.UI.VerticalLayoutGroupverticalLayoutGroup  // 0x20
  private           MagicaCloth.MagicaAvatar        avatar  // 0x28
  public            System.Collections.Generic.List<MagicaCloth.DressUpControl.AvatarPartsGroup>avatarPartsGroupList  // 0x30
METHODS:
  System.Void Start()
  System.Void Update()
  System.Void OnDestroy()
  System.Void Init()
  System.Void ChangeParts(System.Int32 id, System.Int32 dir)
  System.Void Clear()
  System.Void .ctor()
  System.Void <Init>b__8_0(System.Int32 id, System.Int32 dir)
END_CLASS

CLASS: MagicaCloth.ModelController
TYPE:  class
TOKEN: 0x2000105
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.GameObject>characterList  // 0x18
  private           System.Single                   slowTime  // 0x20
  private           System.Boolean                  slow  // 0x24
METHODS:
  System.Void Start()
  System.Void Update()
  System.Void AnimatorAction(System.Action<UnityEngine.Animator> act)
  System.Void ClothAction(System.Action<MagicaCloth.BaseCloth> act)
  System.Void OnNextButton()
  System.Void OnBackButton()
  System.Void OnSlowButton()
  System.Void OnActiveButton()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ObjectUtility
TYPE:  class
TOKEN: 0x2000108
FIELDS:
METHODS:
  UnityEngine.GameObject[] PlaceRandomCubes(System.Int32 count, UnityEngine.Vector3 center, System.Single radius)
  UnityEngine.GameObject[] PlaceRandomCubes(System.Int32 count)
  UnityEngine.GameObject MakeStrippedCube()
  UnityEngine.GameObject[] PlaceRandomGameObject(System.Int32 count, UnityEngine.Vector3 center, System.Single radius, UnityEngine.GameObject prefab)
END_CLASS

CLASS: MagicaCloth.SimpleInputManager
TYPE:  class
TOKEN: 0x2000109
EXTENDS: CreateSingleton`1
FIELDS:
  private   static  System.Int32                    MaxFinger  // 0x0
  public            System.Single                   tapRadiusCm  // 0x18
  public            System.Single                   flickRangeCm  // 0x1C
  public            System.Single                   flickCheckSpeed  // 0x20
  public            System.Single                   mouseWheelSpeed  // 0x24
  private           System.Int32                    mainFingerId  // 0x28
  private           System.Int32                    subFingerId  // 0x2C
  private           UnityEngine.Vector2[]           downPos  // 0x30
  private           UnityEngine.Vector2[]           lastPos  // 0x38
  private           UnityEngine.Vector2[]           flickDownPos  // 0x40
  private           System.Single[]                 flickDownTime  // 0x48
  private           System.Single                   lastTime  // 0x50
  private           System.Boolean                  mobilePlatform  // 0x54
  private           System.Boolean[]                mouseDown  // 0x58
  private           UnityEngine.Vector2[]           mouseOldMovePos  // 0x60
  private           System.Single                   screenDpi  // 0x68
  private           System.Single                   screenDpc  // 0x6C
  public    static  UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2>OnTouchDown  // 0x0
  public    static  UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2>OnTouchMove  // 0x8
  public    static  UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2>OnDoubleTouchMove  // 0x10
  public    static  UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2>OnTouchUp  // 0x18
  public    static  UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2>OnTouchMoveCancel  // 0x20
  public    static  UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2>OnTouchTap  // 0x28
  public    static  UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2>OnTouchFlick  // 0x30
  public    static  UnityEngine.Events.UnityAction<System.Single,System.Single>OnTouchPinch  // 0x38
  public    static  UnityEngine.Events.UnityAction  OnBackButton  // 0x40
METHODS:
  System.Void Init()
  System.Void InitSingleton()
  System.Void Update()
  System.Single get_ScreenDpi()
  System.Single get_ScreenDpc()
  System.Void CalcScreenDpi()
  System.Void AllResetTouchInfo()
  System.Int32 GetTouchCount()
  System.Boolean IsUI()
  System.Void UpdateMobile()
  UnityEngine.Vector2 CalcScreenRatioVector(UnityEngine.Vector2 vec)
  System.Boolean CheckFlic(System.Int32 fid, UnityEngine.Vector2 oldpos, UnityEngine.Vector2 nowpos, UnityEngine.Vector2 downpos, System.Single flicktime)
  System.Void UpdateMouse()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.SliderStart
TYPE:  class
TOKEN: 0x200010A
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.UI.Text             text  // 0x18
  private           System.String                   lable  // 0x20
  private           System.String                   format  // 0x28
  private           System.String                   formatString  // 0x30
METHODS:
  System.Void Start()
  System.Void OnChangeValue(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.UIPartsItem
TYPE:  class
TOKEN: 0x200010B
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.UI.Text             text  // 0x18
  public            UnityEngine.UI.Button           prefButton  // 0x20
  public            UnityEngine.UI.Button           nextButton  // 0x28
  private           System.Int32                    id  // 0x30
METHODS:
  System.Void Start()
  System.Void Init(System.String title, System.Int32 id, System.Action<System.Int32,System.Int32> onClick)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.WindController
TYPE:  class
TOKEN: 0x200010D
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.WindZone            unityWindZone  // 0x18
  private           System.Single                   unityWindZoneScale  // 0x20
  private           UnityEngine.Renderer            arrowRenderer  // 0x28
  private           UnityEngine.Gradient            arrowGradient  // 0x30
  private           System.Collections.Generic.List<UnityEngine.Transform>rotationTransforms  // 0x38
  private           UnityEngine.GameObject          blastWavePrefab  // 0x40
  private           System.Single                   blastWaveSpawnRadius  // 0x48
  private           System.Single                   angleY  // 0x4C
  private           System.Single                   angleX  // 0x50
METHODS:
  System.Void Start()
  System.Void OnDirectionY(System.Single value)
  System.Void OnDirectionX(System.Single value)
  System.Void OnMain(System.Single value)
  System.Void OnTurbulence(System.Single value)
  System.Void OnFrequency(System.Single value)
  System.Void OnBlastWave()
  MagicaCloth.MagicaDirectionalWind get_Wind()
  System.Void UpdateDirection()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.BezierParam
TYPE:  class
TOKEN: 0x200010E
FIELDS:
  private           System.Single                   startValue  // 0x10
  private           System.Single                   endValue  // 0x14
  private           System.Boolean                  useEndValue  // 0x18
  private           System.Single                   curveValue  // 0x1C
  private           System.Boolean                  useCurveValue  // 0x20
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Single val)
  System.Void .ctor(System.Single sval, System.Single eval)
  System.Void .ctor(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval)
  System.Void SetParam(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval)
  System.Single get_StartValue()
  System.Single get_EndValue()
  System.Single get_CurveValue()
  System.Boolean get_UseCurve()
  System.Single Evaluate(System.Single x)
  MagicaCloth.BezierParam AutoSetup(System.Single startVal, System.Single endVal, System.Single curveVal)
  System.Int32 GetDataHash()
  MagicaCloth.BezierParam Clone()
END_CLASS

CLASS: MagicaCloth.IBoneReplace
TYPE:  interface
TOKEN: 0x200010F
FIELDS:
METHODS:
  System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones()
  System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
END_CLASS

CLASS: MagicaCloth.IDataVerify
TYPE:  interface
TOKEN: 0x2000110
FIELDS:
METHODS:
  System.Int32 GetVersion()
  System.Void CreateVerifyData()
  MagicaCloth.Define.Error VerifyData()
  System.String GetInformation()
END_CLASS

CLASS: MagicaCloth.IEditorCloth
TYPE:  interface
TOKEN: 0x2000111
FIELDS:
METHODS:
  System.Collections.Generic.List<System.Int32> GetSelectionList()
  System.Collections.Generic.List<System.Int32> GetUseList()
END_CLASS

CLASS: MagicaCloth.IEditorMesh
TYPE:  interface
TOKEN: 0x2000112
FIELDS:
METHODS:
  System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Collections.Generic.List<System.Int32> GetEditorTriangleList()
  System.Collections.Generic.List<System.Int32> GetEditorLineList()
END_CLASS

CLASS: MagicaCloth.RuntimeStatus
TYPE:  class
TOKEN: 0x2000113
FIELDS:
  private           System.Boolean                  initStart  // 0x10
  private           System.Boolean                  init  // 0x11
  private           System.Boolean                  initError  // 0x12
  private           System.Boolean                  enable  // 0x13
  private           System.Boolean                  userEnable  // 0x14
  private           System.Boolean                  runtimeError  // 0x15
  private           System.Boolean                  dispose  // 0x16
  private           System.Boolean                  isActive  // 0x17
  private           System.Boolean                  isDirty  // 0x18
  private           System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus><parentStatusSet>k__BackingField  // 0x20
  private           System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus><childStatusSet>k__BackingField  // 0x28
  private           System.Action                   UpdateStatusAction  // 0x30
  private           System.Action                   DisconnectedAction  // 0x38
  private           System.Func<System.Object>      OwnerFunc  // 0x40
METHODS:
  System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> get_parentStatusSet()
  System.Void set_parentStatusSet(System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> value)
  System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> get_childStatusSet()
  System.Void set_childStatusSet(System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> value)
  System.Boolean get_IsActive()
  System.Boolean get_IsInitStart()
  System.Boolean get_IsInitComplete()
  System.Boolean get_IsInitSuccess()
  System.Boolean get_IsInitError()
  System.Boolean get_IsDispose()
  System.Boolean get_IsDirty()
  System.Void SetInitStart()
  System.Void SetInitComplete()
  System.Void SetInitError()
  System.Boolean SetEnable(System.Boolean sw)
  System.Boolean SetUserEnable(System.Boolean sw)
  System.Boolean SetRuntimeError(System.Boolean sw)
  System.Void SetDispose()
  System.Void SetDirty()
  System.Void ClearDirty()
  System.Boolean UpdateStatus()
  System.Void AddParentStatus(MagicaCloth.RuntimeStatus status)
  System.Void RemoveParentStatus(MagicaCloth.RuntimeStatus status)
  System.Void AddChildStatus(MagicaCloth.RuntimeStatus status)
  System.Void RemoveChildStatus(MagicaCloth.RuntimeStatus status)
  System.Void LinkParentStatus(MagicaCloth.RuntimeStatus parent)
  System.Void UnlinkParentStatus(MagicaCloth.RuntimeStatus parent)
  System.Boolean IsParentStatusActive()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.DataHashExtensions
TYPE:  class
TOKEN: 0x2000114
FIELDS:
  public    static  System.Int32                    NullHash  // 0x0
  public    static  System.Int32                    NumberHash  // 0x0
METHODS:
  System.Int32 GetDataHash(System.Object data)
  System.Int32 GetDataHash(MagicaCloth.IDataHash data)
  System.Int32 GetDataHash(T[] data)
  System.Int32 GetDataHash(System.Collections.Generic.List<T> data)
  System.Int32 GetDataCountHash(T[] data)
  System.Int32 GetDataCountHash(System.Collections.Generic.List<T> data)
  System.UInt64 GetVectorDataHash(UnityEngine.Vector3 v)
END_CLASS

CLASS: MagicaCloth.GridHash
TYPE:  class
TOKEN: 0x2000115
FIELDS:
  protected         System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<MagicaCloth.GridHash.Point>>gridMap  // 0x10
  protected         System.Single                   gridSize  // 0x18
METHODS:
  System.Void Create(System.Single gridSize)
  System.Void AddPoint(Unity.Mathematics.float3 pos, System.Int32 id)
  System.Void Remove(Unity.Mathematics.float3 pos, System.Int32 id)
  System.Void Clear()
  Unity.Mathematics.int3 GetGridPos(Unity.Mathematics.float3 pos, System.Single gridSize)
  System.UInt32 GetGridHash(Unity.Mathematics.int3 pos)
  System.UInt32 GetGridHash(Unity.Mathematics.float3 pos, System.Single gridSize)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.NearPointSearch
TYPE:  class
TOKEN: 0x2000117
EXTENDS: GridHash
FIELDS:
  private           System.Single                   radius  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>nearDict  // 0x28
  private           System.Collections.Generic.Dictionary<System.Int32,System.Single>distDict  // 0x30
  private           System.Collections.Generic.HashSet<System.UInt32>lockPairSet  // 0x38
METHODS:
  System.Void Create(Unity.Mathematics.float3[] positionList, System.Single radius)
  System.Void SearchNearPointAll()
  System.Void SearchNearPoint(System.Int32 id, Unity.Mathematics.float3 pos)
  System.Void SearchNearPoint(Unity.Mathematics.float3 pos, System.Single r)
  System.Void AddPoint(Unity.Mathematics.float3 pos, System.Int32 id)
  System.Void Remove(Unity.Mathematics.float3 pos, System.Int32 id)
  System.Void AddLockPair(System.Int32 id1, System.Int32 id2)
  System.Boolean GetNearPointPair(System.Int32& id1, System.Int32& id2)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ChunkData
TYPE:  struct
TOKEN: 0x2000118
FIELDS:
  public            System.Int32                    chunkNo  // 0x10
  public            System.Int32                    startIndex  // 0x14
  public            System.Int32                    dataLength  // 0x18
  public            System.Int32                    useLength  // 0x1C
METHODS:
  System.Void Clear()
  System.Boolean IsValid()
  System.String ToString()
END_CLASS

CLASS: MagicaCloth.DoubleComputeBuffer`1
TYPE:  class
TOKEN: 0x2000119
FIELDS:
  private           UnityEngine.ComputeBuffer       buffer0  // 0x0
  private           UnityEngine.ComputeBuffer       buffer1  // 0x0
  private           Unity.Collections.NativeArray<T>nativeArrya  // 0x0
  public            System.UInt32                   bufferID  // 0x0
  public            System.UInt32                   bufferOffset  // 0x0
  public            System.Int32                    bufferCount  // 0x0
METHODS:
  System.Void Dispose()
  System.Void Swap()
  System.Void Create(System.Int32 size, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage)
  System.Void BeginWrite(System.Int32 length)
  System.Void EndWrite(System.Int32 length)
  Unity.Collections.NativeArray<T> GetNativeArray()
  UnityEngine.ComputeBuffer GetBuffer(System.Int32 bufferIndex)
  System.Int32 get_Count()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ExNativeHashMap`2
TYPE:  class
TOKEN: 0x200011A
FIELDS:
  private           Unity.Collections.NativeParallelHashMap<TKey,TValue>nativeHashMap  // 0x0
  private           System.Int32                    nativeLength  // 0x0
  private           System.Collections.Generic.HashSet<TKey>useKeySet  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Int32 get_NativeCount()
  System.Void Add(TKey key, TValue value)
  TValue Get(TKey key)
  System.Void Remove(System.Func<TKey,TValue,System.Boolean> func)
  System.Void Replace(System.Func<TKey,TValue,System.Boolean> func, System.Func<TValue,TValue> datafunc)
  System.Void Remove(TKey key)
  System.Int32 get_Count()
  System.Void Clear()
  Unity.Collections.NativeParallelHashMap<TKey,TValue> get_Map()
  System.Collections.Generic.HashSet<TKey> get_UseKeySet()
END_CLASS

CLASS: MagicaCloth.ExNativeMultiHashMap`2
TYPE:  class
TOKEN: 0x200011B
FIELDS:
  private           Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>nativeMultiHashMap  // 0x0
  private           System.Int32                    nativeLength  // 0x0
  private           System.Collections.Generic.Dictionary<TKey,System.Int32>useKeyDict  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Int32 get_NativeCount()
  System.Boolean get_IsCreated()
  System.Void Add(TKey key, TValue value)
  System.Void Remove(TKey key, TValue value)
  System.Void Remove(System.Func<TKey,TValue,System.Boolean> func)
  System.Void Replace(System.Func<TKey,TValue,System.Boolean> func, System.Func<TValue,TValue> datafunc)
  System.Void Process(System.Action<TKey,TValue> act)
  System.Void Process(TKey key, System.Action<TValue> act)
  System.Boolean Contains(TKey key, TValue value)
  System.Boolean Contains(TKey key)
  System.Void Remove(TKey key)
  System.Int32 get_Count()
  System.Void Clear()
  Unity.Collections.NativeParallelMultiHashMap<TKey,TValue> get_Map()
END_CLASS

CLASS: MagicaCloth.FixedChunkNativeArray`1
TYPE:  class
TOKEN: 0x200011C
FIELDS:
  private           Unity.Collections.NativeArray<T>nativeArray0  // 0x0
  private           Unity.Collections.NativeArray<T>nativeArray1  // 0x0
  private           System.Int32                    nativeLength  // 0x0
  private           System.Collections.Generic.List<MagicaCloth.ChunkData>emptyChunkList  // 0x0
  private           System.Collections.Generic.List<MagicaCloth.ChunkData>useChunkList  // 0x0
  private           System.Int32                    chunkSeed  // 0x0
  private           System.Int32                    initLength  // 0x0
  private           T                               emptyElement  // 0x0
  private           System.Int32                    useLength  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void SetEmptyElement(T empty)
  MagicaCloth.ChunkData AddChunk(System.Int32 length)
  MagicaCloth.ChunkData Add(T data)
  System.Void RemoveChunk(System.Int32 chunkNo)
  System.Void RemoveChunk(MagicaCloth.ChunkData chunk)
  System.Void Fill(MagicaCloth.ChunkData chunk, T data)
  System.Int32 get_Length()
  System.Int32 get_ChunkCount()
  System.Int32 get_Count()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  Unity.Collections.NativeArray<T> ToJobArray()
  Unity.Collections.NativeArray<T> ToJobArray(System.Int32 bufferIndex)
  System.Void SwapBuffer()
  System.String ToString()
END_CLASS

CLASS: MagicaCloth.FixedMultiNativeList`1
TYPE:  class
TOKEN: 0x200011D
FIELDS:
  private           Unity.Collections.NativeArray<T>nativeArray  // 0x0
  private           System.Int32                    nativeLength  // 0x0
  private           System.Collections.Generic.List<MagicaCloth.ChunkData>emptyChunkList  // 0x0
  private           System.Collections.Generic.List<MagicaCloth.ChunkData>useChunkList  // 0x0
  private           System.Int32                    chunkSeed  // 0x0
  private           System.Int32                    initLength  // 0x0
  private           T                               emptyElement  // 0x0
  private           System.Int32                    useLength  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void SetEmptyElement(T empty)
  MagicaCloth.ChunkData AddChunk(System.Int32 length)
  System.Void RemoveChunk(System.Int32 chunkNo)
  System.Void RemoveChunk(MagicaCloth.ChunkData chunk)
  MagicaCloth.ChunkData AddData(MagicaCloth.ChunkData chunk, T data)
  MagicaCloth.ChunkData RemoveData(MagicaCloth.ChunkData chunk, T data)
  MagicaCloth.ChunkData ClearData(MagicaCloth.ChunkData chunk)
  System.Void Process(MagicaCloth.ChunkData chunk, System.Action<T> act)
  System.Int32 get_Length()
  System.Int32 get_ChunkCount()
  System.Int32 get_Count()
  T get_Item(System.Int32 index)
  Unity.Collections.NativeArray<T> ToJobArray()
  System.String ToString()
END_CLASS

CLASS: MagicaCloth.FixedNativeList`1
TYPE:  class
TOKEN: 0x200011E
FIELDS:
  private           Unity.Collections.NativeArray<T>nativeArray0  // 0x0
  private           Unity.Collections.NativeArray<T>nativeArray1  // 0x0
  private           System.Int32                    nativeLength  // 0x0
  private           System.Collections.Generic.Queue<System.Int32>emptyStack  // 0x0
  private           System.Collections.Generic.HashSet<System.Int32>useIndexSet  // 0x0
  private           System.Int32                    useLength  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Int32 Add(T element)
  System.Void Remove(System.Int32 index)
  System.Boolean Exists(System.Int32 index)
  System.Int32 get_Length()
  System.Int32 get_Count()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Void Clear()
  Unity.Collections.NativeArray<T> ToJobArray()
  Unity.Collections.NativeArray<T> ToJobArray(System.Int32 bufferIndex)
  System.Void SyncBuffer()
END_CLASS

CLASS: MagicaCloth.FixedNativeListWithCount`1
TYPE:  class
TOKEN: 0x200011F
FIELDS:
  private           Unity.Collections.NativeList<T> nativeList  // 0x0
  private           System.Int32                    nativeLength  // 0x0
  private           System.Collections.Generic.Queue<System.Int32>emptyStack  // 0x0
  private           System.Collections.Generic.HashSet<System.Int32>useIndexSet  // 0x0
  private           System.Collections.Generic.Dictionary<T,System.Int32>indexDict  // 0x0
  private           System.Collections.Generic.Dictionary<T,System.Int32>countDict  // 0x0
  private           T                               emptyElement  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 capacity)
  System.Void Dispose()
  System.Void SetEmptyElement(T empty)
  System.Int32 Add(T element)
  System.Void Remove(T element)
  System.Boolean Exist(T element)
  System.Int32 GetUseCount(T element)
  System.Int32 get_Length()
  System.Int32 get_Count()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Void Clear()
  T[] ToArray()
  Unity.Collections.NativeArray<T> ToJobArray()
END_CLASS

CLASS: MagicaCloth.FixedTransformAccessArray
TYPE:  class
TOKEN: 0x2000120
FIELDS:
  private           UnityEngine.Jobs.TransformAccessArraytransformArray  // 0x10
  private           System.Int32                    nativeLength  // 0x18
  private           System.Collections.Generic.Queue<System.Int32>emptyStack  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>useIndexDict  // 0x28
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>indexDict  // 0x30
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>referenceDict  // 0x38
METHODS:
  System.Void .ctor(System.Int32 desiredJobCount)
  System.Void .ctor(System.Int32 capacity, System.Int32 desiredJobCount)
  System.Int32 Add(UnityEngine.Transform element)
  System.Void Remove(System.Int32 index)
  System.Boolean Exist(System.Int32 index)
  System.Boolean Exist(UnityEngine.Transform element)
  System.Int32 get_Count()
  System.Int32 get_Length()
  UnityEngine.Transform get_Item(System.Int32 index)
  System.Int32 GetIndex(UnityEngine.Transform element)
  System.Void Clear()
  System.Void Dispose()
  UnityEngine.Jobs.TransformAccessArray GetTransformAccessArray()
END_CLASS

CLASS: MagicaCloth.NativeArrayExtension
TYPE:  class
TOKEN: 0x2000121
FIELDS:
METHODS:
  System.Void CopyToFast(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, T2[] array)
  System.Void CopyToFast(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, Unity.Collections.NativeArray<T> array)
  System.Void CopyBlock(Unity.Collections.NativeArray<T> nativeArray, System.Int32 sourceIndex, System.Int32 destinationIndex, System.Int32 count)
  System.Void CopyFromFast(Unity.Collections.NativeArray<T> nativeArray, Unity.Collections.NativeArray<T> array)
  System.Void CopyFromFast(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, T2[] array)
  System.Void SetValue(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, System.Int32 count, T value)
END_CLASS

CLASS: MagicaCloth.CreateSingleton`1
TYPE:  class
TOKEN: 0x2000122
EXTENDS: MonoBehaviour
FIELDS:
  private   static  T                               instance  // 0x0
  private   static  T                               initInstance  // 0x0
  private   static  System.Boolean                  isDestroy  // 0x0
METHODS:
  System.Void InitMember()
  T get_Instance()
  System.Void InitInstance()
  System.Boolean IsInstance()
  System.Void Awake()
  System.Void OnDestroy()
  System.Void DuplicateDetection(T duplicate)
  System.Void InitSingleton()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.DataUtility
TYPE:  class
TOKEN: 0x2000123
FIELDS:
METHODS:
  System.UInt32 PackPair(System.Int32 v0, System.Int32 v1)
  System.Void UnpackPair(System.UInt32 pack, System.Int32& v0, System.Int32& v1)
  System.UInt32 Pack16(System.Int32 hi, System.Int32 low)
  System.Int32 Unpack16Hi(System.UInt32 pack)
  System.Int32 Unpack16Low(System.UInt32 pack)
  System.UInt32 Pack4_28(System.Int32 hi, System.Int32 low)
  System.Int32 Unpack4_28Hi(System.UInt32 pack)
  System.Int32 Unpack4_28Low(System.UInt32 pack)
  System.UInt32 Pack8_24(System.Int32 hi, System.Int32 low)
  System.Int32 Unpack8_24Hi(System.UInt32 pack)
  System.Int32 Unpack8_24Low(System.UInt32 pack)
  System.UInt64 Pack32(System.Int32 hi, System.Int32 low)
  System.Int32 Unpack32Hi(System.UInt64 pack)
  System.Int32 Unpack32Low(System.UInt64 pack)
  System.UInt64 PackTriple(System.Int32 v0, System.Int32 v1, System.Int32 v2)
  System.Void UnpackTriple(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2)
  System.UInt64 PackQuater(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  System.Void UnpackQuater(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2, System.Int32& v3)
END_CLASS

CLASS: MagicaCloth.Develop
TYPE:  class
TOKEN: 0x2000124
FIELDS:
METHODS:
  System.Void Log(System.String str)
END_CLASS

CLASS: MagicaCloth.GizmoUtility
TYPE:  class
TOKEN: 0x2000125
FIELDS:
  public    static readonly UnityEngine.Color               ColorDynamic  // 0x0
  public    static readonly UnityEngine.Color               ColorKinematic  // 0x10
  public    static readonly UnityEngine.Color               ColorInvalid  // 0x20
  public    static readonly UnityEngine.Color               ColorCollider  // 0x30
  public    static readonly UnityEngine.Color               ColorNonSelectedCollider  // 0x40
  public    static readonly UnityEngine.Color               ColorTriangle  // 0x50
  public    static readonly UnityEngine.Color               ColorStructLine  // 0x60
  public    static readonly UnityEngine.Color               ColorBendLine  // 0x70
  public    static readonly UnityEngine.Color               ColorNearLine  // 0x80
  public    static readonly UnityEngine.Color               ColorRotationLine  // 0x90
  public    static readonly UnityEngine.Color               ColorAdjustLine  // 0xA0
  public    static readonly UnityEngine.Color               ColorAirLine  // 0xB0
  public    static readonly UnityEngine.Color               ColorBasePosition  // 0xC0
  public    static readonly UnityEngine.Color               ColorDirectionMoveLimit  // 0xD0
  public    static readonly UnityEngine.Color               ColorPenetration  // 0xE0
  public    static readonly UnityEngine.Color               ColorCollisionNormal  // 0xF0
  public    static readonly UnityEngine.Color               ColorVelocity  // 0x100
  public    static readonly UnityEngine.Color               ColorSkinningBone  // 0x110
  public    static readonly UnityEngine.Color               ColorDeformerPoint  // 0x120
  public    static readonly UnityEngine.Color               ColorDeformerPointRange  // 0x130
  public    static readonly UnityEngine.Color               ColorWind  // 0x140
METHODS:
  System.Void DrawWireCapsule(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scl, UnityEngine.Vector3 ldir, UnityEngine.Vector3 lup, System.Single length, System.Single startRadius, System.Single endRadius, System.Boolean resetMatrix)
  System.Void DrawWireSphere(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scl, System.Single radius, System.Boolean drawSphere, System.Boolean drawAxis, System.Boolean resetMatrix)
  System.Void DrawWireCube(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 size, System.Boolean resetMatrix)
  System.Void DrawWireCone(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Single length, System.Single radius, System.Int32 div)
  System.Void DrawWireArrow(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 size, System.Boolean cross)
  System.Void DrawAxis(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Single size, System.Boolean resetMatrix)
  System.Void DrawBone(UnityEngine.Vector3 pos, UnityEngine.Vector3 tpos, System.Single size)
  System.Void .cctor()
END_CLASS

CLASS: MagicaCloth.MathUtility
TYPE:  class
TOKEN: 0x2000126
FIELDS:
METHODS:
  System.Single Clamp1(System.Single a)
  System.Single Clamp01(System.Single a)
  Unity.Mathematics.float3 Project(Unity.Mathematics.float3 v, Unity.Mathematics.float3 n)
  System.Single Angle(Unity.Mathematics.float3 v1, Unity.Mathematics.float3 v2)
  Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single minlength, System.Single maxlength)
  Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single maxlength)
  Unity.Mathematics.float3 ClampDistance(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to, System.Single maxlength)
  System.Boolean ClampAngle(Unity.Mathematics.float3 dir, Unity.Mathematics.float3 basedir, System.Single maxAngle, Unity.Mathematics.float3& outdir)
  Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to, System.Single t)
  Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.quaternion from, Unity.Mathematics.quaternion to)
  System.Single Angle(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b)
  Unity.Mathematics.quaternion ClampAngle(Unity.Mathematics.quaternion from, Unity.Mathematics.quaternion to, System.Single maxAngle)
  Unity.Mathematics.float3 AxisToEuler(Unity.Mathematics.float3 axis)
  Unity.Mathematics.quaternion AxisQuaternion(Unity.Mathematics.float3 dir)
  System.Single ClosestPtPointSegmentRatio(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b)
  System.Single ClosestPtPointSegmentRatioNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float3 ClosestPtPointSegment(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float3 ClosestPtPointSegmentNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b)
  System.Boolean IntersectPointPlane(Unity.Mathematics.float3 planePos, Unity.Mathematics.float3 planeDir, Unity.Mathematics.float3 pos, Unity.Mathematics.float3& outpos)
  System.Single IntersectPointPlaneDist(Unity.Mathematics.float3 planePos, Unity.Mathematics.float3 planeDir, Unity.Mathematics.float3 pos, Unity.Mathematics.float3& outPos)
  System.Boolean IntersectSegmentPlane(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 p, Unity.Mathematics.float3 pn, Unity.Mathematics.float3& opos)
  System.Boolean IntersectPointSphere(Unity.Mathematics.float3 sc, System.Single sr, Unity.Mathematics.float3 pos, Unity.Mathematics.float3& outPos)
  System.Boolean IntersectPointSphere(Unity.Mathematics.float3 p, Unity.Mathematics.float3 sc, System.Single sr)
  System.Boolean IntersectRaySphere(Unity.Mathematics.float3 p, Unity.Mathematics.float3 d, Unity.Mathematics.float3 sc, System.Single sr, Unity.Mathematics.float3& q, System.Single& t)
  System.Boolean IntersectLineSphare(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 sc, System.Single sr, Unity.Mathematics.float3& q)
  System.Boolean IntersectRayCone(Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, Unity.Mathematics.float3 c, Unity.Mathematics.float3 v, System.Single cost, System.Single& t, Unity.Mathematics.float3& p)
  System.Boolean IntersectLineConeSurface(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 d, System.Single dlen, Unity.Mathematics.float3 c, Unity.Mathematics.float3 v, System.Single cost, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, Unity.Mathematics.float3& p)
  System.Boolean IntersectLineCylinderSurface(Unity.Mathematics.float3 sa, Unity.Mathematics.float3 sb, Unity.Mathematics.float3 p, Unity.Mathematics.float3 q, System.Single r, System.Single& t)
  System.Boolean IntersectLineCylinderSurface(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, System.Single r1, System.Single r2, Unity.Mathematics.float3& p)
  System.Boolean IntersectLineCapsule(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, System.Single r1, System.Single r2, Unity.Mathematics.float3& p)
  System.Boolean IntersectTrianglePointDistance(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, System.Single restDist, System.Single compressionStiffness, System.Single stretchStiffness, Unity.Mathematics.float3& corr, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, Unity.Mathematics.float3& corr2)
  System.Boolean IntersectTrianglePointDistanceSide(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, System.Single restDist, System.Single compressionStiffness, System.Single stretchStiffness, System.Single side, Unity.Mathematics.float3& corr, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, Unity.Mathematics.float3& corr2)
  System.Boolean IntersectTrianglePointDistanceSide2(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, System.Single radius, System.Single restDist, System.Single compressionStiffness, System.Single stretchStiffness, System.Single side, Unity.Mathematics.float3& corr, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, Unity.Mathematics.float3& corr2)
  System.Single DistanceTrianglePoint(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2)
  Unity.Mathematics.float3 TriangleCenter(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2)
  Unity.Mathematics.float3 TriangleNormal(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2)
  Unity.Mathematics.quaternion TriangleRotation(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2)
  Unity.Mathematics.quaternion TriangleCenterRotation(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 p3)
  System.Single DistanceTriangleCenter(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2)
  System.Single DirectionPointTriangle(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c)
  System.Boolean IntersectLineTriangle(Unity.Mathematics.float3 p, Unity.Mathematics.float3 q, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c, Unity.Mathematics.float3& hitpos, System.Single& t, Unity.Mathematics.float3& n)
  System.Single ClosestPtSegmentSegment(Unity.Mathematics.float3 p1, Unity.Mathematics.float3 q1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 q2, System.Single& s, System.Single& t, Unity.Mathematics.float3& c1, Unity.Mathematics.float3& c2)
  System.Single GetBezierValue(MagicaCloth.BezierParam bparam, System.Single t)
  System.Single GetBezierValue(System.Single sval, System.Single eval, System.Single curve, System.Single t)
END_CLASS

CLASS: MagicaCloth.MeshUtility
TYPE:  class
TOKEN: 0x2000127
FIELDS:
METHODS:
  UnityEngine.GameObject ReplaceSkinnedMeshRendererToMeshRenderer(UnityEngine.SkinnedMeshRenderer sren, System.Boolean replaceSkinnedMeshRenderer)
  System.Boolean CalcMeshWorldPositionNormalTangent(MagicaCloth.MeshData meshData, System.Collections.Generic.List<UnityEngine.Transform> boneList, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Boolean CalcMeshWorldPositionNormalTangent(UnityEngine.Renderer ren, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList)
  System.Boolean CalcMeshLocalNormalTangent(System.Collections.Generic.List<System.Int32> selectList, UnityEngine.Vector3[] vlist, UnityEngine.Vector2[] uvlist, System.Int32[] triangles, System.Collections.Generic.List<UnityEngine.Vector3>& lnorList, System.Collections.Generic.List<UnityEngine.Vector3>& ltanList)
  System.Collections.Generic.List<System.Collections.Generic.HashSet<System.Int32>> GetTriangleToVertexLinkList(System.Int32 vcnt, System.Collections.Generic.List<System.Int32> lineList, System.Collections.Generic.List<System.Int32> triangleList)
  System.Collections.Generic.List<System.Collections.Generic.HashSet<System.Int32>> GetVertexLinkList(System.Int32 vcnt, System.Collections.Generic.HashSet<System.UInt32> lineSet)
  System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int32>> GetVertexToTriangles(System.Collections.Generic.List<System.Int32> triangleList)
  System.Int32 RestTriangleVertex(System.Int32 tindex, System.Int32 v0, System.Int32 v1, System.Collections.Generic.List<System.Int32> triangleList)
  System.Void RestTriangleVertex(System.Int32 tindex, System.Int32 v0, System.Collections.Generic.List<System.Int32> triangleList, System.Int32& v1, System.Int32& v2)
  System.Boolean CheckAdjacentTriangle(System.Int32 tindex0, System.Int32 tindex1, System.Collections.Generic.List<System.Int32> triangleList)
  System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<System.Int32>> GetTriangleEdgePair(System.Collections.Generic.List<System.Int32> triangleList)
  System.Void AddTriangleEdge(System.Int32 v0, System.Int32 v1, System.Int32 tindex, System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<System.Int32>> triangleEdgeDict)
  System.Collections.Generic.List<System.UInt64> GetTrianglePackList(System.Collections.Generic.List<System.Int32> triangleList)
  System.Single ClosestPtBoneLine(UnityEngine.Vector3 pos, UnityEngine.Transform bone, System.Single lineWidth, UnityEngine.Vector3& d)
  System.Collections.Generic.List<UnityEngine.Transform> GetUseBoneTransformList(UnityEngine.Transform[] bones, UnityEngine.Mesh mesh)
  System.Void CalcTetraMesh(System.Collections.Generic.List<UnityEngine.Vector3> posList, System.Int32& tetraCount, System.Collections.Generic.List<System.Int32>& tetraIndexList, System.Collections.Generic.List<System.Single>& tetraSizeList)
  UnityEngine.Transform GetReplaceBone(UnityEngine.Transform now, System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict)
END_CLASS

CLASS: MagicaCloth.StaticStringBuilder
TYPE:  class
TOKEN: 0x200012A
FIELDS:
  private   static  System.Text.StringBuilder       stringBuilder  // 0x0
METHODS:
  System.Text.StringBuilder get_Instance()
  System.Void Clear()
  System.Text.StringBuilder Append(System.Object[] args)
  System.Text.StringBuilder AppendLine(System.Object[] args)
  System.Text.StringBuilder AppendLine()
  System.String AppendToString(System.Object[] args)
  System.String ToString()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: MagicaCloth.UpdateTimeManager
TYPE:  class
TOKEN: 0x200012B
FIELDS:
  private           MagicaCloth.UpdateTimeManager.UpdateCountupdatePerSeccond  // 0x10
  private           MagicaCloth.UpdateTimeManager.UpdateModeupdateMode  // 0x14
  private           MagicaCloth.UpdateTimeManager.UpdateLocationupdateLocation  // 0x18
  private           System.Single                   timeScale  // 0x1C
  private           System.Single                   futurePredictionRate  // 0x20
  private           System.Boolean                  updateBoneScale  // 0x24
  private           System.Int32                    fixedUpdateCount  // 0x28
METHODS:
  System.Void ResetFixedUpdateCount()
  System.Void AddFixedUpdateCount()
  System.Int32 get_FixedUpdateCount()
  MagicaCloth.UpdateTimeManager.UpdateMode GetUpdateMode()
  System.Void SetUpdateMode(MagicaCloth.UpdateTimeManager.UpdateMode mode)
  MagicaCloth.UpdateTimeManager.UpdateLocation GetUpdateLocation()
  System.Void SetUpdateLocation(MagicaCloth.UpdateTimeManager.UpdateLocation location)
  System.Int32 get_UpdatePerSecond()
  System.Void SetUpdatePerSecond(MagicaCloth.UpdateTimeManager.UpdateCount ucount)
  System.Single get_UpdateIntervalTime()
  System.Single get_UpdatePower()
  System.Single get_TimeScale()
  System.Void set_TimeScale(System.Single value)
  System.Single get_DeltaTime()
  System.Single get_PhysicsDeltaTime()
  System.Single get_AverageDeltaTime()
  System.Boolean get_IsUnscaledUpdate()
  System.Boolean get_IsDelay()
  System.Single get_FuturePredictionRate()
  System.Void set_FuturePredictionRate(System.Single value)
  System.Boolean get_UpdateBoneScale()
  System.Void set_UpdateBoneScale(System.Boolean value)
  System.Int32 get_WorkerMaximumCount()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ReferenceDataBuilder`1
TYPE:  class
TOKEN: 0x200012F
FIELDS:
  private           System.Int32                    indexCount  // 0x0
  private           System.Collections.Generic.List<T>dataList  // 0x0
  private           System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>indexToDataIndexList  // 0x0
  private           System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>dataIndexToIndexList  // 0x0
METHODS:
  System.Void Init(System.Int32 indexCount)
  System.Void AddData(T data, System.Int32[] indexes)
  System.ValueTuple<System.Collections.Generic.List<MagicaCloth.ReferenceDataIndex>,System.Collections.Generic.List<T>> GetDirectReferenceData()
  System.ValueTuple<System.Collections.Generic.List<MagicaCloth.ReferenceDataIndex>,System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>> GetIndirectReferenceData()
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.ReferenceDataIndex
TYPE:  struct
TOKEN: 0x2000130
FIELDS:
  public            System.Int32                    startIndex  // 0x10
  public            System.Int32                    count  // 0x14
METHODS:
END_CLASS

CLASS: MagicaCloth.IDataHash
TYPE:  interface
TOKEN: 0x2000131
FIELDS:
METHODS:
  System.Int32 GetDataHash()
END_CLASS

CLASS: MagicaCloth.IShareDataObject
TYPE:  interface
TOKEN: 0x2000132
FIELDS:
METHODS:
  System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject()
  MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source)
END_CLASS

CLASS: MagicaCloth.ShareDataObject
TYPE:  class
TOKEN: 0x2000133
EXTENDS: ScriptableObject
FIELDS:
  protected         System.Int32                    dataHash  // 0x18
  protected         System.Int32                    dataVersion  // 0x1C
METHODS:
  System.Int32 GetDataHash()
  System.Void set_SaveDataHash(System.Int32 value)
  System.Int32 get_SaveDataHash()
  System.Void set_SaveDataVersion(System.Int32 value)
  System.Int32 get_SaveDataVersion()
  System.Int32 GetVersion()
  MagicaCloth.Define.Error VerifyData()
  System.Void CreateVerifyData()
  System.String GetInformation()
  T CreateShareData(System.String dataName)
  System.Boolean RemoveNullAndDuplication(System.Collections.Generic.List<T> data)
  T Clone(T source)
  System.Void .ctor()
END_CLASS

CLASS: MagicaCloth.StopWatch
TYPE:  class
TOKEN: 0x2000134
FIELDS:
  private           System.Single                   startTime  // 0x10
  private           System.Single                   endTime  // 0x14
METHODS:
  MagicaCloth.StopWatch Start()
  MagicaCloth.StopWatch Stop()
  System.Single get_ElapsedSeconds()
  System.Single get_ElapsedMilliseconds()
  System.Void .ctor()
END_CLASS

CLASS: MagicaReductionMesh.ReductionMesh
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           MagicaReductionMesh.ReductionMesh.ReductionWeightMode<WeightMode>k__BackingField  // 0x10
  private           MagicaReductionMesh.MeshData    meshData  // 0x18
  private           MagicaReductionMesh.ReductionDatareductionData  // 0x20
  private           MagicaReductionMesh.DebugData   debugData  // 0x28
METHODS:
  MagicaReductionMesh.ReductionMesh.ReductionWeightMode get_WeightMode()
  System.Void set_WeightMode(MagicaReductionMesh.ReductionMesh.ReductionWeightMode value)
  MagicaReductionMesh.MeshData get_MeshData()
  MagicaReductionMesh.ReductionData get_ReductionData()
  MagicaReductionMesh.DebugData get_DebugData()
  System.Int32 AddMesh(System.Boolean isSkinning, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Transform> bones, UnityEngine.Matrix4x4[] bindPoseList, UnityEngine.BoneWeight[] boneWeightList)
  System.Int32 AddMesh(UnityEngine.Renderer ren)
  System.Int32 AddMesh(UnityEngine.Transform root, System.Collections.Generic.List<UnityEngine.Vector3> posList, System.Collections.Generic.List<UnityEngine.Vector3> norList, System.Collections.Generic.List<UnityEngine.Vector4> tanList, System.Collections.Generic.List<UnityEngine.Vector2> uvList, System.Collections.Generic.List<System.Int32> triangleList)
  System.Void Reduction(System.Single zeroRadius, System.Single radius, System.Single polygonLength, System.Boolean createTetra)
  MagicaReductionMesh.FinalData GetFinalData(UnityEngine.Transform root)
  System.Void .ctor()
END_CLASS

CLASS: MagicaReductionMesh.ReductionMeshAccess
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  protected         MagicaReductionMesh.ReductionMeshparent  // 0x10
METHODS:
  MagicaReductionMesh.MeshData get_MeshData()
  MagicaReductionMesh.ReductionData get_ReductionData()
  MagicaReductionMesh.DebugData get_DebugData()
  System.Void SetParent(MagicaReductionMesh.ReductionMesh parent)
  System.Void .ctor()
END_CLASS

CLASS: MagicaReductionMesh.DebugData
TYPE:  class
TOKEN: 0x2000007
EXTENDS: ReductionMeshAccess
FIELDS:
METHODS:
  System.Void DispMeshInfo(System.String header)
  System.Void DebugDrawShared(MagicaReductionMesh.FinalData final, System.Boolean drawTriangle, System.Boolean drawLine, System.Boolean drawTetra, System.Boolean drawVertexNormal, System.Boolean drawVertexTangent, System.Boolean drawNumber, System.Int32 maxPolygonCount, System.Int32 layer, System.Int32 tetraIndex, System.Single tetraSize, System.Collections.Generic.List<System.Int32> drawNumberList, System.Single axisSize)
  System.Void DrawTetra(MagicaReductionMesh.FinalData final, System.Int32 tetraIndex, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Single tetraSize)
  System.Void DebugDrawChild(MagicaReductionMesh.FinalData final, System.Boolean drawPosition, System.Boolean drawNormal, System.Boolean drawTriangle, System.Boolean drawNumber, System.Int32 maxVertexCount, System.Single positionSize, System.Single axisSize)
  System.Void .ctor()
END_CLASS

CLASS: MagicaReductionMesh.FinalData
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Vector3>vertices  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Vector3>normals  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Vector4>tangents  // 0x20
  public            System.Collections.Generic.List<UnityEngine.Vector2>uvs  // 0x28
  public            System.Collections.Generic.List<UnityEngine.BoneWeight>boneWeights  // 0x30
  public            System.Collections.Generic.List<UnityEngine.Matrix4x4>bindPoses  // 0x38
  public            System.Collections.Generic.List<UnityEngine.Transform>bones  // 0x40
  public            System.Collections.Generic.List<System.Int32>lines  // 0x48
  public            System.Collections.Generic.List<System.Int32>triangles  // 0x50
  public            System.Collections.Generic.List<System.Int32>tetras  // 0x58
  public            System.Collections.Generic.List<System.Single>tetraSizes  // 0x60
  public            System.Collections.Generic.List<UnityEngine.Matrix4x4>vertexBindPoses  // 0x68
  public            System.Collections.Generic.List<MagicaReductionMesh.FinalData.MeshIndexData>vertexToMeshIndexList  // 0x70
  public            System.Collections.Generic.List<System.Int32>vertexToTriangleCountList  // 0x78
  public            System.Collections.Generic.List<System.Int32>vertexToTriangleStartList  // 0x80
  public            System.Collections.Generic.List<System.Int32>vertexToTriangleIndexList  // 0x88
  public            System.Collections.Generic.List<MagicaReductionMesh.FinalData.MeshInfo>meshList  // 0x90
METHODS:
  System.Boolean get_IsValid()
  System.Int32 get_VertexCount()
  System.Int32 get_LineCount()
  System.Int32 get_TriangleCount()
  System.Int32 get_TetraCount()
  System.Int32 get_BoneCount()
  System.Boolean get_IsSkinning()
  System.Int32 get_MeshCount()
  System.Void .ctor()
END_CLASS

CLASS: MagicaReductionMesh.MeshData
TYPE:  class
TOKEN: 0x200000B
EXTENDS: ReductionMeshAccess
FIELDS:
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.Vertex>originalVertexList  // 0x18
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.MeshInfo>meshInfoList  // 0x20
  public            System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex>shareVertexList  // 0x28
  private           System.Collections.Generic.Dictionary<System.UInt64,MagicaReductionMesh.MeshData.Triangle>triangleDict  // 0x30
  private           System.Collections.Generic.Dictionary<System.UInt32,MagicaReductionMesh.MeshData.Line>lineDict  // 0x38
  public            System.Collections.Generic.List<UnityEngine.Transform>boneList  // 0x40
  private           System.Collections.Generic.List<MagicaReductionMesh.MeshData.Tetra>tetraList  // 0x48
  private           System.Single                   weightPow  // 0x50
  private           System.Int32                    maxWeightCount  // 0x54
  private           System.Single                   sameSurfaceAngle  // 0x58
  private           System.Boolean                  removeSameTrianglePair  // 0x5C
  private           System.Single                   removeSameTrianglePairAngle  // 0x60
METHODS:
  System.Int32 get_VertexCount()
  System.Int32 get_LineCount()
  System.Int32 get_TriangleCount()
  System.Int32 get_TetraCount()
  System.Int32 get_MeshCount()
  System.Single get_WeightPow()
  System.Void set_WeightPow(System.Single value)
  System.Int32 get_MaxWeightCount()
  System.Void set_MaxWeightCount(System.Int32 value)
  System.Single get_SameSurfaceAngle()
  System.Void set_SameSurfaceAngle(System.Single value)
  System.Boolean get_RemoveSameTrianglePair()
  System.Void set_RemoveSameTrianglePair(System.Boolean value)
  System.Single get_RemoveSameTrianglePairAngle()
  System.Void set_RemoveSameTrianglePairAngle(System.Single value)
  System.Int32 AddMesh(System.Boolean isSkinning, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Transform> bones, UnityEngine.Matrix4x4[] bindPoseList, UnityEngine.BoneWeight[] boneWeightList)
  System.Int32 AddMesh(UnityEngine.Transform root, System.Collections.Generic.List<UnityEngine.Vector3> posList, System.Collections.Generic.List<UnityEngine.Vector3> norList, System.Collections.Generic.List<UnityEngine.Vector4> tanList, System.Collections.Generic.List<UnityEngine.Vector2> uvList, System.Collections.Generic.List<System.Int32> triangleList)
  System.Void CombineVertex(MagicaReductionMesh.MeshData.ShareVertex sv0, MagicaReductionMesh.MeshData.ShareVertex sv1)
  System.Void UpdateMeshData(System.Boolean createTetra)
  System.Void CalcVertexIndex()
  System.Void CalcUV(MagicaReductionMesh.MeshData.UvWrapMode wrapMode)
  System.Void CreateTriangleAndLine()
  System.Void CalcShareVertexWeight()
  System.Void AdjustTriangleNormal()
  System.Boolean CheckTwoTriangleOpen(MagicaReductionMesh.MeshData.Triangle tri1, MagicaReductionMesh.MeshData.Triangle tri2, System.UInt32 edge)
  System.Single CalcTwoTriangleAngle(MagicaReductionMesh.MeshData.Triangle tri1, MagicaReductionMesh.MeshData.Triangle tri2, System.UInt32 edge)
  System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<System.UInt64>> GetEdgeToTriangleDict()
  System.Void CalcVertexNormalFromTriangle()
  System.Void RemoveTriangle(System.UInt64 thash)
  System.Collections.Generic.Dictionary<System.UInt64,System.Collections.Generic.List<MagicaReductionMesh.MeshData.Square>> GetSquareDict()
  System.Void RemoveOverlappingSquareTriangles()
  System.Void CreateTetraMesh()
  UnityEngine.Bounds CalcBounding()
  MagicaReductionMesh.FinalData GetFinalData(UnityEngine.Transform root)
  System.Void CreateOriginalMeshInfo(MagicaReductionMesh.FinalData final, UnityEngine.Transform root, System.Single weightLength)
  System.Void AddVertexToMeshIndexData(MagicaReductionMesh.FinalData final, System.Int32 sindex, System.Int32 meshIndex, System.Int32 meshVertexIndex)
  System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> SearchNearPointList(UnityEngine.Vector3 basePos, MagicaReductionMesh.MeshData.ShareVertex sv, System.Single weightLength, System.Int32 maxCount)
  System.Void CalcMeshWorldPositionNormalTangent(System.Boolean isSkinning, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Transform> bones, UnityEngine.Matrix4x4[] bindPoseList, UnityEngine.BoneWeight[] boneWeightList, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector4>& wtanList)
  System.Void .ctor()
END_CLASS

CLASS: MagicaReductionMesh.ReductionData
TYPE:  class
TOKEN: 0x200001F
EXTENDS: ReductionMeshAccess
FIELDS:
METHODS:
  System.Void ReductionZeroDistance(System.Single radius)
  System.Void ReductionRadius(System.Single radius)
  System.Void ReductionPolygonLink(System.Single length)
  System.Void ReductionBone()
  System.Void .ctor()
END_CLASS

CLASS: MagicaReductionMesh.NearPointReduction
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  protected         MagicaReductionMesh.MeshData    meshData  // 0x10
  private           System.Collections.Generic.List<MagicaReductionMesh.NearPointReduction.Point>pointList  // 0x18
  protected         System.Collections.Generic.Dictionary<UnityEngine.Vector3Int,System.Collections.Generic.List<MagicaReductionMesh.NearPointReduction.Point>>gridMap  // 0x20
  protected         System.Single                   gridSize  // 0x28
  private           System.Single                   searchRadius  // 0x2C
  private           System.Collections.Generic.Dictionary<MagicaReductionMesh.NearPointReduction.Point,System.Collections.Generic.List<MagicaReductionMesh.NearPointReduction.Point>>nearPointDict  // 0x30
METHODS:
  System.Void .ctor(System.Single radius)
  System.Int32 get_PointCount()
  System.Void Create(MagicaReductionMesh.MeshData meshData)
  System.Void Reduction()
  MagicaReductionMesh.NearPointReduction.Point AddPoint(MagicaReductionMesh.MeshData.ShareVertex sv, UnityEngine.Vector3 pos)
  System.Void AddGrid(MagicaReductionMesh.NearPointReduction.Point p)
  System.Void RemoveGrid(MagicaReductionMesh.NearPointReduction.Point p)
  System.Void Move(MagicaReductionMesh.NearPointReduction.Point p, UnityEngine.Vector3 newpos)
  System.Void Remove(MagicaReductionMesh.NearPointReduction.Point p)
  UnityEngine.Vector3Int GetGridPos(UnityEngine.Vector3 pos)
  System.Void SearchNearPointAll()
  System.Void SearchNearPoint(MagicaReductionMesh.NearPointReduction.Point p, System.Single radius, MagicaReductionMesh.NearPointReduction.Point ignorePoint)
  MagicaReductionMesh.NearPointReduction.Point GetNearPointPair()
END_CLASS

CLASS: MagicaReductionMesh.PolygonLinkReduction
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  protected         MagicaReductionMesh.MeshData    meshData  // 0x10
  private           System.Single                   reductionLength  // 0x18
  private           System.Collections.Generic.List<MagicaReductionMesh.PolygonLinkReduction.Point>pointList  // 0x20
  private           System.Collections.Generic.Dictionary<MagicaReductionMesh.MeshData.ShareVertex,MagicaReductionMesh.PolygonLinkReduction.Point>pointDict  // 0x28
METHODS:
  System.Void .ctor(System.Single length)
  System.Int32 get_PointCount()
  System.Void Create(MagicaReductionMesh.MeshData meshData)
  System.Void Reduction()
  System.Void AddPoint(MagicaReductionMesh.MeshData.ShareVertex sv)
  MagicaReductionMesh.PolygonLinkReduction.Point GetPoint(MagicaReductionMesh.MeshData.ShareVertex sv)
  System.Void Remove(MagicaReductionMesh.PolygonLinkReduction.Point p)
  System.Void SearchNearPointAll()
  System.Void SearchNearPoint(MagicaReductionMesh.PolygonLinkReduction.Point p)
  MagicaReductionMesh.PolygonLinkReduction.Point GetNearPointPair()
END_CLASS

CLASS: MagicaReductionMesh.Utility
TYPE:  class
TOKEN: 0x2000024
FIELDS:
METHODS:
  System.UInt32 PackPair(System.Int32 v0, System.Int32 v1)
  System.Void UnpackPair(System.UInt32 pack, System.Int32& v0, System.Int32& v1)
  System.UInt64 PackTriple(System.Int32 v0, System.Int32 v1, System.Int32 v2)
  System.Void UnpackTriple(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2)
  System.UInt64 PackQuater(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  System.Void UnpackQuater(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2, System.Int32& v3)
  System.UInt32 Pack16(System.Int32 hi, System.Int32 low)
  System.Int32 Unpack16Hi(System.UInt32 pack)
  System.Int32 Unpack16Low(System.UInt32 pack)
  System.UInt64 Pack32(System.Int32 hi, System.Int32 low)
  System.Int32 Unpack32Hi(System.UInt64 pack)
  System.Int32 Unpack32Low(System.UInt64 pack)
  System.Void CalcFinalDataWorldPositionNormalTangent(MagicaReductionMesh.FinalData final, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector4>& wtanList)
  System.Void CalcFinalDataChildWorldPositionNormalTangent(MagicaReductionMesh.FinalData final, System.Int32 meshIndex, System.Collections.Generic.List<UnityEngine.Vector3> sposList, System.Collections.Generic.List<UnityEngine.Vector3> snorList, System.Collections.Generic.List<UnityEngine.Vector4> stanList, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector4>& wtanList)
  System.Void CalcLocalPositionNormalTangent(UnityEngine.Transform root, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Collections.Generic.List<UnityEngine.Vector3> wnorList, System.Collections.Generic.List<UnityEngine.Vector4> wtanList)
  System.Void .ctor()
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

