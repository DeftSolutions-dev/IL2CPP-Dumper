// ========================================================
// Dumped by @desirepro
// Assembly: MagicaCloth.dll
// Classes:  308
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000005
    public struct ReductionWeightMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaReductionMesh.ReductionMesh.ReductionWeightMode Distance;        // 0x0
        public static MagicaReductionMesh.ReductionMesh.ReductionWeightMode Average;        // 0x0
        public static MagicaReductionMesh.ReductionMesh.ReductionWeightMode DistanceAverage;        // 0x0

    }

    // TypeToken: 0x2000009
    public class MeshIndexData
    {
        // Fields
        public System.Collections.Generic.List<System.UInt32> meshIndexPackList;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class MeshInfo
    {
        // Fields
        public System.Int32 meshIndex;        // 0x10
        public UnityEngine.Mesh mesh;        // 0x18
        public System.Collections.Generic.List<UnityEngine.Vector3> vertices;        // 0x20
        public System.Collections.Generic.List<UnityEngine.Vector3> normals;        // 0x28
        public System.Collections.Generic.List<UnityEngine.Vector4> tangents;        // 0x30
        public System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights;        // 0x38
        public System.Collections.Generic.List<System.Int32> parents;        // 0x40

        // Methods
        private System.Int32 get_VertexCount() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class WeightData
    {
        // Fields
        public System.Int32 boneIndex;        // 0x10
        public System.Single boneWeight;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class Vertex
    {
        // Fields
        public System.Int32 meshIndex;        // 0x10
        public System.Int32 vertexIndex;        // 0x14
        public UnityEngine.Vector3 wpos;        // 0x18
        public UnityEngine.Vector3 wnor;        // 0x24
        public UnityEngine.Vector3 wtan;        // 0x30
        public System.Single tanw;        // 0x3C
        public UnityEngine.Vector2 uv;        // 0x40
        public System.Int32 parentIndex;        // 0x48
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.WeightData> boneWeightList;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class MeshInfo
    {
        // Fields
        public System.Int32 index;        // 0x10
        public UnityEngine.Mesh mesh;        // 0x18
        public System.Int32 vertexCount;        // 0x20
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.Vertex> vertexList;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class ShareVertex
    {
        // Fields
        public System.Int32 sindex;        // 0x10
        public UnityEngine.Vector3 wpos;        // 0x14
        public UnityEngine.Vector3 wnor;        // 0x20
        public UnityEngine.Vector3 wtan;        // 0x2C
        public System.Single tanw;        // 0x38
        public UnityEngine.Vector2 uv;        // 0x3C
        public UnityEngine.Matrix4x4 worldToLocalMatrix;        // 0x44
        public UnityEngine.Matrix4x4 bindpose;        // 0x84
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.WeightData> boneWeightList;        // 0xC8
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.Vertex> vertexList;        // 0xD0
        public System.Collections.Generic.HashSet<MagicaReductionMesh.MeshData.ShareVertex> linkShareVertexSet;        // 0xD8
        public System.Collections.Generic.HashSet<MagicaReductionMesh.MeshData.Triangle> linkTriangleSet;        // 0xE0

        // Methods
        private System.Void AddLink(MagicaReductionMesh.MeshData.ShareVertex mv) { }
        private System.Void ReplaseLink(MagicaReductionMesh.MeshData.ShareVertex old, MagicaReductionMesh.MeshData.ShareVertex mv) { }
        private System.Void RecalcCoordinate() { }
        private System.Void CalcNormalTangentFromTriangle() { }
        private UnityEngine.Vector3 CalcLocalPos(UnityEngine.Vector3 pos) { }
        private UnityEngine.Vector3 CalcLocalDir(UnityEngine.Vector3 dir) { }
        private UnityEngine.Matrix4x4 CalcWorldToLocalMatrix() { }
        private System.Void CalcBoneWeight(MagicaReductionMesh.ReductionMesh.ReductionWeightMode weightMode, System.Single weightPow) { }
        private System.Void CalcBoneWeight_DistanceAverage(System.Single weightPow) { }
        private System.Void CalcBoneWeight_Average() { }
        private System.Void AdjustWeight(System.Collections.Generic.List<MagicaReductionMesh.MeshData.WeightData> sumlist) { }
        private System.Void CalcBoneWeight_Distance(System.Single weightPow) { }
        private UnityEngine.BoneWeight GetBoneWeight() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class Triangle
    {
        // Fields
        public System.Int32 tindex;        // 0x10
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> shareVertexList;        // 0x18
        public UnityEngine.Vector3 wnor;        // 0x20
        public UnityEngine.Vector3 wtan;        // 0x2C
        public System.Boolean flipLock;        // 0x38

        // Methods
        private System.Void GetEdge(System.UInt32& edge0, System.UInt32& edge1, System.UInt32& edge2) { }
        private UnityEngine.Vector3 CalcTriangleNormal() { }
        private System.Void Flip() { }
        private UnityEngine.Vector3 CalcTriangleTangent() { }
        private MagicaReductionMesh.MeshData.ShareVertex GetNonEdgeVertex(System.Int32 edgev0, System.Int32 edgev1) { }
        private System.UInt64 GetTriangleHash() { }
        private System.Single GetTriangleArea(MagicaReductionMesh.MeshData.ShareVertex sv0, MagicaReductionMesh.MeshData.ShareVertex sv1, MagicaReductionMesh.MeshData.ShareVertex sv2) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class Line
    {
        // Fields
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> shareVertexList;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public struct UvWrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaReductionMesh.MeshData.UvWrapMode None;        // 0x0
        public static MagicaReductionMesh.MeshData.UvWrapMode Sphere;        // 0x0

    }

    // TypeToken: 0x2000018
    public class Square
    {
        // Fields
        public System.UInt64 shash;        // 0x10
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.Triangle> triangleList;        // 0x18
        public System.Single angle;        // 0x20

        // Methods
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class Tetra
    {
        // Fields
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> shareVertexList;        // 0x10
        public UnityEngine.Vector3 circumCenter;        // 0x18
        public System.Single circumRadius;        // 0x24
        public UnityEngine.Vector3 tetraCenter;        // 0x28
        public System.Single tetraSize;        // 0x34

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(MagicaReductionMesh.MeshData.ShareVertex a, MagicaReductionMesh.MeshData.ShareVertex b, MagicaReductionMesh.MeshData.ShareVertex c, MagicaReductionMesh.MeshData.ShareVertex d) { }
        private System.UInt64 GetTetraHash() { }
        private System.Void CalcCircumcircle() { }
        private System.Boolean IntersectCircumcircle(UnityEngine.Vector3 pos) { }
        private System.Boolean CheckSame(MagicaReductionMesh.MeshData.Tetra tri) { }
        private System.Boolean ContainsPoint(MagicaReductionMesh.MeshData.ShareVertex p1) { }
        private System.Boolean ContainsPoint(MagicaReductionMesh.MeshData.ShareVertex p1, MagicaReductionMesh.MeshData.ShareVertex p2, MagicaReductionMesh.MeshData.ShareVertex p3, MagicaReductionMesh.MeshData.ShareVertex p4) { }
        private System.Void CalcSize() { }
        private System.Boolean Verification() { }

    }

    // TypeToken: 0x200001A
    public class LinkInfo
    {
        // Fields
        public MagicaReductionMesh.MeshData.ShareVertex sv;        // 0x10
        public System.Single length;        // 0x18
        public System.Int32 count;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public class VertexLengthInfo
    {
        // Fields
        public MagicaReductionMesh.MeshData.ShareVertex sv;        // 0x10
        public System.Single length;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class Point
    {
        // Fields
        public MagicaReductionMesh.MeshData.ShareVertex shareVertex;        // 0x10
        public UnityEngine.Vector3 pos;        // 0x18
        public UnityEngine.Vector3Int grid;        // 0x24
        public MagicaReductionMesh.NearPointReduction.Point nearPoint;        // 0x30
        public System.Single nearDist;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class Point
    {
        // Fields
        public MagicaReductionMesh.MeshData.ShareVertex shareVertex;        // 0x10
        public MagicaReductionMesh.PolygonLinkReduction.Point nearPoint;        // 0x18
        public System.Single nearDist;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
    public struct ConnectionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.BoneClothTarget.ConnectionMode Line;        // 0x0
        public static MagicaCloth.BoneClothTarget.ConnectionMode MeshAutomatic;        // 0x0
        public static MagicaCloth.BoneClothTarget.ConnectionMode MeshSequentialLoop;        // 0x0
        public static MagicaCloth.BoneClothTarget.ConnectionMode MeshSequentialNoLoop;        // 0x0

    }

    // TypeToken: 0x200003A
    public class RestoreDistanceWork
    {
        // Fields
        public System.UInt32 vertexPair;        // 0x10
        public System.Single dist;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public class PenetrationBone
    {
        // Fields
        public UnityEngine.Transform bone;        // 0x10
        public UnityEngine.Transform childBone;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public class PenetrationWork
    {
        // Fields
        public UnityEngine.Transform bone;        // 0x10
        public UnityEngine.Transform childBone;        // 0x18
        public System.Int32 boneIndex;        // 0x20
        public System.Single distance;        // 0x24
        public System.Single weight;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003D
    public class VertexInfo
    {
        // Fields
        public System.Int32 vertexIndex;        // 0x10
        public System.Int32 parentVertexIndex;        // 0x14
        public System.Collections.Generic.List<System.Int32> childVertexList;        // 0x18
        public MagicaCloth.ClothData.VertexInfo parentInfo;        // 0x20
        public System.Collections.Generic.List<MagicaCloth.ClothData.VertexInfo> childInfoList;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000043
    public struct Algorithm
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.ClothParams.Algorithm Algorithm_1;        // 0x0
        public static MagicaCloth.ClothParams.Algorithm Algorithm_2;        // 0x0

    }

    // TypeToken: 0x2000044
    public struct TeleportMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.ClothParams.TeleportMode Reset;        // 0x0
        public static MagicaCloth.ClothParams.TeleportMode Keep;        // 0x0

    }

    // TypeToken: 0x2000045
    public struct AdjustMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.ClothParams.AdjustMode Fixed;        // 0x0
        public static MagicaCloth.ClothParams.AdjustMode XYMove;        // 0x0
        public static MagicaCloth.ClothParams.AdjustMode XZMove;        // 0x0
        public static MagicaCloth.ClothParams.AdjustMode YZMove;        // 0x0

    }

    // TypeToken: 0x2000046
    public struct PenetrationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.ClothParams.PenetrationMode SurfacePenetration;        // 0x0
        public static MagicaCloth.ClothParams.PenetrationMode ColliderPenetration;        // 0x0

    }

    // TypeToken: 0x2000047
    public struct PenetrationAxis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.ClothParams.PenetrationAxis X;        // 0x0
        public static MagicaCloth.ClothParams.PenetrationAxis Y;        // 0x0
        public static MagicaCloth.ClothParams.PenetrationAxis Z;        // 0x0
        public static MagicaCloth.ClothParams.PenetrationAxis InverseX;        // 0x0
        public static MagicaCloth.ClothParams.PenetrationAxis InverseY;        // 0x0
        public static MagicaCloth.ClothParams.PenetrationAxis InverseZ;        // 0x0

    }

    // TypeToken: 0x2000048
    public struct ParamType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.ClothParams.ParamType Radius;        // 0x0
        public static MagicaCloth.ClothParams.ParamType Mass;        // 0x0
        public static MagicaCloth.ClothParams.ParamType Gravity;        // 0x0
        public static MagicaCloth.ClothParams.ParamType Drag;        // 0x0
        public static MagicaCloth.ClothParams.ParamType MaxVelocity;        // 0x0
        public static MagicaCloth.ClothParams.ParamType WorldInfluence;        // 0x0
        public static MagicaCloth.ClothParams.ParamType ClampDistance;        // 0x0
        public static MagicaCloth.ClothParams.ParamType ClampPosition;        // 0x0
        public static MagicaCloth.ClothParams.ParamType ClampRotation;        // 0x0
        public static MagicaCloth.ClothParams.ParamType RestoreDistance;        // 0x0
        public static MagicaCloth.ClothParams.ParamType RestoreRotation;        // 0x0
        public static MagicaCloth.ClothParams.ParamType Spring;        // 0x0
        public static MagicaCloth.ClothParams.ParamType AdjustRotation;        // 0x0
        public static MagicaCloth.ClothParams.ParamType AirLine;        // 0x0
        public static MagicaCloth.ClothParams.ParamType TriangleBend;        // 0x0
        public static MagicaCloth.ClothParams.ParamType Volume;        // 0x0
        public static MagicaCloth.ClothParams.ParamType ColliderCollision;        // 0x0
        public static MagicaCloth.ClothParams.ParamType RotationInterpolation;        // 0x0
        public static MagicaCloth.ClothParams.ParamType DistanceDisable;        // 0x0
        public static MagicaCloth.ClothParams.ParamType ExternalForce;        // 0x0
        public static MagicaCloth.ClothParams.ParamType Penetration;        // 0x0
        public static MagicaCloth.ClothParams.ParamType Algorithm;        // 0x0
        public static MagicaCloth.ClothParams.ParamType BaseSkinning;        // 0x0
        public static MagicaCloth.ClothParams.ParamType Max;        // 0x0

    }

    // TypeToken: 0x200004F
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.MagicaMeshSpring.Axis X;        // 0x0
        public static MagicaCloth.MagicaMeshSpring.Axis Y;        // 0x0
        public static MagicaCloth.MagicaMeshSpring.Axis Z;        // 0x0
        public static MagicaCloth.MagicaMeshSpring.Axis InverseX;        // 0x0
        public static MagicaCloth.MagicaMeshSpring.Axis InverseY;        // 0x0
        public static MagicaCloth.MagicaMeshSpring.Axis InverseZ;        // 0x0

    }

    // TypeToken: 0x2000051
    public class DeformerSelection, IDataHash
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> selectData;        // 0x10
        public System.Collections.Generic.List<System.UInt64> vertexHashList;        // 0x18

        // Methods
        private System.Int32 GetDataHash() { }
        private System.Boolean Compare(MagicaCloth.SelectionData.DeformerSelection data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public class DeformerData, IDataHash
    {
        // Fields
        public System.Int32 deformerDataHash;        // 0x10
        public System.Int32 vertexCount;        // 0x14
        public System.Int32[] useVertexIndexList;        // 0x18
        public System.Single[] weightList;        // 0x20

        // Methods
        private System.Int32 get_UseVertexCount() { }
        private System.Int32 GetDataHash() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000055
    public class Compute
    {
        // Fields
        public static System.Single Epsilon;        // 0x0
        public static System.Single CollisionFrictionRange;        // 0x0
        public static System.Single FrictionDampingRate;        // 0x0
        public static System.Single FrictionMoveRatio;        // 0x0
        public static System.Single FrictionPower;        // 0x0
        public static System.Single ClampPositionMaxVelocity;        // 0x0
        public static System.Single GlobalColliderMaxMoveDistance;        // 0x0
        public static System.Single GlobalColliderMaxRotationAngle;        // 0x0
        public static System.Single ColliderExtrusionMaxPower;        // 0x0
        public static System.Single ColliderExtrusionDirectionPower;        // 0x0
        public static System.Single ColliderExtrusionDistPower;        // 0x0
        public static System.Single ColliderExtrusionVelocityInfluence;        // 0x0
        public static System.Single MaxWindMain;        // 0x0
        public static System.Single ClampRotationMaxVelocity;        // 0x0
        public static System.Single ClampRotationMaxVelocity2;        // 0x0
        public static System.Single TriangleBendVelocityInfluence;        // 0x0

    }

    // TypeToken: 0x2000056
    public struct Error
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.Define.Error None;        // 0x0
        public static MagicaCloth.Define.Error Cancel;        // 0x0
        public static MagicaCloth.Define.Error EmptyData;        // 0x0
        public static MagicaCloth.Define.Error InvalidDataHash;        // 0x0
        public static MagicaCloth.Define.Error TooOldDataVersion;        // 0x0
        public static MagicaCloth.Define.Error HigherDataVersion;        // 0x0
        public static MagicaCloth.Define.Error MeshDataNull;        // 0x0
        public static MagicaCloth.Define.Error MeshDataHashMismatch;        // 0x0
        public static MagicaCloth.Define.Error MeshDataVersionMismatch;        // 0x0
        public static MagicaCloth.Define.Error ClothDataNull;        // 0x0
        public static MagicaCloth.Define.Error ClothDataHashMismatch;        // 0x0
        public static MagicaCloth.Define.Error ClothDataVersionMismatch;        // 0x0
        public static MagicaCloth.Define.Error ClothSelectionHashMismatch;        // 0x0
        public static MagicaCloth.Define.Error ClothSelectionVersionMismatch;        // 0x0
        public static MagicaCloth.Define.Error ClothTargetRootCountMismatch;        // 0x0
        public static MagicaCloth.Define.Error UseTransformNull;        // 0x0
        public static MagicaCloth.Define.Error UseTransformCountZero;        // 0x0
        public static MagicaCloth.Define.Error UseTransformCountMismatch;        // 0x0
        public static MagicaCloth.Define.Error DeformerNull;        // 0x0
        public static MagicaCloth.Define.Error DeformerHashMismatch;        // 0x0
        public static MagicaCloth.Define.Error DeformerVersionMismatch;        // 0x0
        public static MagicaCloth.Define.Error DeformerCountZero;        // 0x0
        public static MagicaCloth.Define.Error DeformerCountMismatch;        // 0x0
        public static MagicaCloth.Define.Error VertexCountZero;        // 0x0
        public static MagicaCloth.Define.Error VertexUseCountZero;        // 0x0
        public static MagicaCloth.Define.Error VertexCountMismatch;        // 0x0
        public static MagicaCloth.Define.Error RootListCountMismatch;        // 0x0
        public static MagicaCloth.Define.Error SelectionDataCountMismatch;        // 0x0
        public static MagicaCloth.Define.Error SelectionCountZero;        // 0x0
        public static MagicaCloth.Define.Error CenterTransformNull;        // 0x0
        public static MagicaCloth.Define.Error SpringDataNull;        // 0x0
        public static MagicaCloth.Define.Error SpringDataHashMismatch;        // 0x0
        public static MagicaCloth.Define.Error SpringDataVersionMismatch;        // 0x0
        public static MagicaCloth.Define.Error TargetObjectNull;        // 0x0
        public static MagicaCloth.Define.Error SharedMeshNull;        // 0x0
        public static MagicaCloth.Define.Error SharedMeshCannotRead;        // 0x0
        public static MagicaCloth.Define.Error SharedMeshDifferent;        // 0x0
        public static MagicaCloth.Define.Error SharedMeshDifferentVertexCount;        // 0x0
        public static MagicaCloth.Define.Error MeshOptimizeMismatch;        // 0x0
        public static MagicaCloth.Define.Error MeshVertexCount65535Over;        // 0x0
        public static MagicaCloth.Define.Error MeshKeepQuads;        // 0x0
        public static MagicaCloth.Define.Error BoneListZero;        // 0x0
        public static MagicaCloth.Define.Error BoneListNull;        // 0x0
        public static MagicaCloth.Define.Error RendererNotFound;        // 0x0
        public static MagicaCloth.Define.Error MeshFilterNotFound;        // 0x0
        public static MagicaCloth.Define.Error BuildNoTransformList;        // 0x0
        public static MagicaCloth.Define.Error BuildReadOnlyPrefab;        // 0x0
        public static MagicaCloth.Define.Error BuildFailedSaveAssets;        // 0x0
        public static MagicaCloth.Define.Error BuildPrefabCannotSaved;        // 0x0
        public static MagicaCloth.Define.Error BuildNotSceneObject;        // 0x0
        public static MagicaCloth.Define.Error BuildInvalidComponent;        // 0x0
        public static MagicaCloth.Define.Error BuildInvalidData;        // 0x0
        public static MagicaCloth.Define.Error BuildInvalidMeshData;        // 0x0
        public static MagicaCloth.Define.Error BuildInvalidGameObject;        // 0x0
        public static MagicaCloth.Define.Error BuildInvalidPrefab;        // 0x0
        public static MagicaCloth.Define.Error BuildInvalidRenderDeformer;        // 0x0
        public static MagicaCloth.Define.Error BuildInvalidScene;        // 0x0
        public static MagicaCloth.Define.Error BuildInvalidSelection;        // 0x0
        public static MagicaCloth.Define.Error BuildMissingDeformer;        // 0x0
        public static MagicaCloth.Define.Error BuildMissingSelection;        // 0x0
        public static MagicaCloth.Define.Error BuildMissingMesh;        // 0x0
        public static MagicaCloth.Define.Error BuildMissingScriptOnPrefab;        // 0x0
        public static MagicaCloth.Define.Error OverlappingTransform;        // 0x0
        public static MagicaCloth.Define.Error AddOverlappingTransform;        // 0x0
        public static MagicaCloth.Define.Error OldDataVersion;        // 0x0
        public static MagicaCloth.Define.Error OldAlgorithm;        // 0x0

    }

    // TypeToken: 0x2000057
    public class OptimizeMesh
    {
        // Fields
        public static System.Int32 Unknown;        // 0x0
        public static System.Int32 Nothing;        // 0x0
        public static System.Int32 Unity2018_On;        // 0x0
        public static System.Int32 Unity2019_PolygonOrder;        // 0x0
        public static System.Int32 Unity2019_VertexOrder;        // 0x0

    }

    // TypeToken: 0x2000058
    public class RenderMesh
    {
        // Fields
        public static System.Int32 WorkerMultiplesOfVertexCollection;        // 0x0

    }

    // TypeToken: 0x200005D
    public struct VertexWeight
    {
        // Fields
        public UnityEngine.Vector3 localPos;        // 0x10
        public UnityEngine.Vector3 localNor;        // 0x1C
        public UnityEngine.Vector3 localTan;        // 0x28
        public System.Int32 parentIndex;        // 0x34
        public System.Single weight;        // 0x38

    }

    // TypeToken: 0x200005E
    public class ChildData, IDataHash
    {
        // Fields
        public System.Int32 childDataHash;        // 0x10
        public System.Int32 vertexCount;        // 0x14
        public System.UInt32[] vertexInfoList;        // 0x18
        public MagicaCloth.MeshData.VertexWeight[] vertexWeightList;        // 0x20
        public System.Int32[] parentIndexList;        // 0x28

        // Methods
        private System.Int32 get_VertexCount() { }
        private System.Int32 GetDataHash() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000060
    public struct RecalculateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.RenderMeshDeformer.RecalculateMode None;        // 0x0
        public static MagicaCloth.RenderMeshDeformer.RecalculateMode UpdateNormalPerFrame;        // 0x0
        public static MagicaCloth.RenderMeshDeformer.RecalculateMode UpdateNormalAndTangentPerFrame;        // 0x0

    }

    // TypeToken: 0x2000061
    public struct BoundsMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.RenderMeshDeformer.BoundsMode None;        // 0x0
        public static MagicaCloth.RenderMeshDeformer.BoundsMode ExpandedAtInitialization;        // 0x0

    }

    // TypeToken: 0x2000065
    public struct ClampDistance2Data
    {
        // Fields
        public System.Int32 vertexIndex;        // 0x10
        public System.Int32 parentVertexIndex;        // 0x14
        public System.Single length;        // 0x18

    }

    // TypeToken: 0x2000066
    public struct ClampDistance2RootInfo
    {
        // Fields
        public System.UInt16 startIndex;        // 0x10
        public System.UInt16 dataLength;        // 0x12

    }

    // TypeToken: 0x2000067
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public System.Single minRatio;        // 0x18
        public System.Single maxRatio;        // 0x1C
        public System.Single velocityInfluence;        // 0x20
        public MagicaCloth.ChunkData dataChunk;        // 0x24
        public MagicaCloth.ChunkData rootInfoChunk;        // 0x34

    }

    // TypeToken: 0x2000068
    public struct ClampDistance2Job, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2Data> dataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo> rootInfoList;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> rootTeamList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistance2Constraint.GroupData> groupList;        // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x68
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x98

        // Methods
        private System.Void Execute(System.Int32 rootIndex) { }

    }

    // TypeToken: 0x200006A
    public struct ClampDistanceData
    {
        // Fields
        public System.UInt16 vertexIndex;        // 0x10
        public System.UInt16 targetVertexIndex;        // 0x12
        public System.Single length;        // 0x14

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x200006B
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public System.Single minRatio;        // 0x18
        public System.Single maxRatio;        // 0x1C
        public System.Single velocityInfluence;        // 0x20
        public MagicaCloth.ChunkData dataChunk;        // 0x24
        public MagicaCloth.ChunkData refChunk;        // 0x34

    }

    // TypeToken: 0x200006C
    public struct ClampDistanceJob, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistanceConstraint.ClampDistanceData> clampDistanceList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistanceConstraint.GroupData> groupList;        // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x98
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0xA8

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200006E
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public MagicaCloth.CurveParam limitLength;        // 0x18
        public Unity.Mathematics.float3 axisRatio;        // 0x28
        public System.Single velocityInfluence;        // 0x34

        // Methods
        private System.Boolean IsAxisCheck() { }

    }

    // TypeToken: 0x200006F
    public struct ClampPositionJob, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public System.Single maxMoveLength;        // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.ClampPositionConstraint.GroupData> clampPositionGroupList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x48
        public Unity.Collections.NativeArray<System.Single> depthList;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0x78
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xA8

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000071
    public struct ClampRotationData
    {
        // Fields
        public System.Int32 vertexIndex;        // 0x10
        public System.Int32 parentVertexIndex;        // 0x14
        public Unity.Mathematics.float3 localPos;        // 0x18
        public Unity.Mathematics.quaternion localRot;        // 0x24

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000072
    public struct ClampRotationRootInfo
    {
        // Fields
        public System.UInt16 startIndex;        // 0x10
        public System.UInt16 dataLength;        // 0x12

    }

    // TypeToken: 0x2000073
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public MagicaCloth.CurveParam maxAngle;        // 0x18
        public System.Single velocityInfluence;        // 0x28
        public MagicaCloth.ChunkData dataChunk;        // 0x2C
        public MagicaCloth.ChunkData rootInfoChunk;        // 0x3C

    }

    // TypeToken: 0x2000074
    public struct ClampRotationJob, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public System.Single maxMoveLength;        // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationData> dataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo> rootInfoList;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> rootTeamList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.ClampRotationConstraint.GroupData> groupList;        // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x58
        public Unity.Collections.NativeArray<System.Single> depthList;        // 0x68
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x78
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0xA8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xB8
        public Unity.Collections.NativeArray<System.Single> lengthBuffer;        // 0xC8

        // Methods
        private System.Void Execute(System.Int32 rootIndex) { }

    }

    // TypeToken: 0x2000076
    public struct CollisionJob, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x18
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> radiusList;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0xA8
        public Unity.Collections.NativeArray<System.Int32> transformIndexList;        // 0xB8
        public Unity.Collections.NativeArray<System.Int32> colliderList;        // 0xC8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;        // 0xD8
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0xE8
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0xF8
        public Unity.Collections.NativeArray<System.Int32> collisionLinkIdList;        // 0x108
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalList;        // 0x118

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Single SphereColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3& normal) { }
        private System.Single CapsuleColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3 dir, Unity.Mathematics.float3& normal) { }
        private System.Single PlaneColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3& normal) { }

    }

    // TypeToken: 0x2000078
    public struct CollisionExtrusionJob, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x18
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> collisionLinkIdList;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0x78
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalList;        // 0x98
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0xA8

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200007A
    public struct RotationData
    {
        // Fields
        public System.Int32 vertexIndex;        // 0x10
        public System.Int32 parentVertexIndex;        // 0x14
        public Unity.Mathematics.float3 localPos;        // 0x18
        public Unity.Mathematics.quaternion localRot;        // 0x24

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x200007B
    public struct RootInfo
    {
        // Fields
        public System.UInt16 startIndex;        // 0x10
        public System.UInt16 dataLength;        // 0x12

    }

    // TypeToken: 0x200007C
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 useClamp;        // 0x14
        public System.Int32 useRestore;        // 0x18
        public MagicaCloth.CurveParam maxAngle;        // 0x1C
        public MagicaCloth.CurveParam restorePower;        // 0x2C
        public System.Single restoreVelocityInfluence;        // 0x3C
        public MagicaCloth.ChunkData dataChunk;        // 0x40
        public MagicaCloth.ChunkData rootInfoChunk;        // 0x50

    }

    // TypeToken: 0x200007D
    public struct RotationRootLineJob, IJobParallelFor
    {
        // Fields
        public System.Single updatePower;        // 0x10
        public System.Int32 runCount;        // 0x14
        public System.Single maxMoveSpeed;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.CompositeRotationConstraint.RotationData> dataList;        // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.CompositeRotationConstraint.RootInfo> rootInfoList;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> rootTeamList;        // 0x40
        public Unity.Collections.NativeArray<MagicaCloth.CompositeRotationConstraint.GroupData> groupList;        // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamGravityList;        // 0x70
        public Unity.Collections.NativeArray<System.Single> depthList;        // 0x80
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x90
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xF0
        public Unity.Collections.NativeArray<System.Single> lengthBuffer;        // 0x100

        // Methods
        private System.Void Execute(System.Int32 rootIndex) { }
        private System.Single GetRotRatio(Unity.Mathematics.float3 tv, Unity.Mathematics.float3 gravityVector, System.Single gravity, System.Single minRatio, System.Single maxRatio) { }

    }

    // TypeToken: 0x200007F
    public struct EdgeCollisionData
    {
        // Fields
        public System.UInt16 vindex0;        // 0x10
        public System.UInt16 vindex1;        // 0x12
        public System.Int32 writeIndex0;        // 0x14
        public System.Int32 writeIndex1;        // 0x18

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000080
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public System.Single edgeRadius;        // 0x18
        public MagicaCloth.ChunkData dataChunk;        // 0x1C
        public MagicaCloth.ChunkData groupIndexChunk;        // 0x2C
        public MagicaCloth.ChunkData refDataChunk;        // 0x3C
        public MagicaCloth.ChunkData writeDataChunk;        // 0x4C

    }

    // TypeToken: 0x2000081
    public struct EdgeCollisionCalcJob, IJobParallelFor
    {
        // Fields
        public System.Single updatePower;        // 0x10
        public System.Int32 runCount;        // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.EdgeCollisionConstraint.GroupData> groupDataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData> dataList;        // 0x28
        public Unity.Collections.NativeArray<System.Int16> groupIndexList;        // 0x38
        public Unity.Collections.NativeArray<System.Int32> colliderList;        // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> radiusList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0xA8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0xB8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;        // 0xC8
        public Unity.Collections.NativeArray<System.Int32> transformIndexList;        // 0xD8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;        // 0xE8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;        // 0xF8

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Boolean SphereColliderDetection(Unity.Mathematics.float3 nextpos0, Unity.Mathematics.float3 nextpos1, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, System.Single radius, System.Int32 cindex) { }
        private System.Boolean CapsuleColliderDetection(Unity.Mathematics.float3 nextpos0, Unity.Mathematics.float3 nextpos1, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3 dir) { }

    }

    // TypeToken: 0x2000082
    public struct EdgeCollisionSumJob, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.EdgeCollisionConstraint.GroupData> groupDataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> inoutNextPosList;        // 0x78
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0x88

        // Methods
        private System.Void Execute(System.Int32 pindex) { }

    }

    // TypeToken: 0x2000084
    public struct PenetrationData
    {
        // Fields
        public System.Int16 vertexIndex;        // 0x10
        public System.Int16 colliderIndex;        // 0x12
        public Unity.Mathematics.float3 localPos;        // 0x14
        public Unity.Mathematics.float3 localDir;        // 0x20
        public System.Single distance;        // 0x2C

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000085
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public System.Int32 mode;        // 0x18
        public System.Single maxDepth;        // 0x1C
        public MagicaCloth.CurveParam radius;        // 0x20
        public MagicaCloth.CurveParam distance;        // 0x30
        public MagicaCloth.ChunkData dataChunk;        // 0x40
        public MagicaCloth.ChunkData refDataChunk;        // 0x50
        public MagicaCloth.ChunkData bonePenetrationDataChunk;        // 0x60

    }

    // TypeToken: 0x2000086
    public struct PenetrationJob, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PenetrationConstraint.GroupData> groupList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PenetrationConstraint.PenetrationData> dataList;        // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePenetrationDataList;        // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x58
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0x88
        public Unity.Collections.NativeArray<System.Int32> transformIndexList;        // 0x98
        public Unity.Collections.NativeArray<System.Single> depthList;        // 0xA8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0xB8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0xC8
        public Unity.Collections.NativeArray<System.Int32> colliderList;        // 0xD8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0xE8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0xF8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;        // 0x108
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x118
        public Unity.Collections.NativeArray<System.Int32> skinningBoneList;        // 0x128
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outNextPosList;        // 0x138
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x148

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private Unity.Mathematics.float3 InverseSpherePosition(MagicaCloth.PenetrationConstraint.PenetrationData& data, System.Single teamScale, Unity.Mathematics.float3 scaleDirection, System.Single distance, System.Int32 cindex, System.Single cr) { }
        private Unity.Mathematics.float3 InverseSpherePenetration(Unity.Mathematics.float3 c, System.Single cr, Unity.Mathematics.float3 nextpos) { }

    }

    // TypeToken: 0x2000088
    public struct RestoreDistanceData
    {
        // Fields
        public System.UInt16 vertexIndex;        // 0x10
        public System.UInt16 targetVertexIndex;        // 0x12
        public System.Single length;        // 0x14

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000089
    public struct RestoreDistanceGroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public MagicaCloth.CurveParam mass;        // 0x14
        public System.Single velocityInfluence;        // 0x24
        public MagicaCloth.CurveParam structStiffness;        // 0x28
        public MagicaCloth.ChunkData structDataChunk;        // 0x38
        public MagicaCloth.ChunkData structRefChunk;        // 0x48
        public System.Int32 useBend;        // 0x58
        public MagicaCloth.CurveParam bendStiffness;        // 0x5C
        public MagicaCloth.ChunkData bendDataChunk;        // 0x6C
        public MagicaCloth.ChunkData bendRefChunk;        // 0x7C
        public System.Int32 useNear;        // 0x8C
        public MagicaCloth.CurveParam nearStiffness;        // 0x90
        public MagicaCloth.ChunkData nearDataChunk;        // 0xA0
        public MagicaCloth.ChunkData nearRefChunk;        // 0xB0

        // Methods
        private System.Boolean IsValid(System.Int32 type) { }
        private MagicaCloth.CurveParam GetStiffness(System.Int32 type) { }
        private MagicaCloth.ChunkData GetDataChunk(System.Int32 type) { }
        private MagicaCloth.ChunkData GetRefChunk(System.Int32 type) { }

    }

    // TypeToken: 0x200008A
    public struct DistanceJob, IJobParallelFor
    {
        // Fields
        public System.Single updatePower;        // 0x10
        public System.Int32 runCount;        // 0x14
        public System.Int32 type;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData> restoreDistanceDataList;        // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceGroupData> restoreDistanceGroupDataList;        // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x40
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x50
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x70
        public Unity.Collections.NativeArray<System.Single> depthList;        // 0x80
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outNextPosList;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xD0

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200008C
    public struct RotationData
    {
        // Fields
        public System.UInt16 vertexIndex;        // 0x10
        public System.UInt16 targetVertexIndex;        // 0x12
        public Unity.Mathematics.float3 localPos;        // 0x14

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x200008D
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public MagicaCloth.CurveParam restorePower;        // 0x18
        public System.Single velocityInfluence;        // 0x28
        public MagicaCloth.ChunkData dataChunk;        // 0x2C
        public MagicaCloth.ChunkData refChunk;        // 0x3C

    }

    // TypeToken: 0x200008E
    public struct RotationJob, IJobParallelFor
    {
        // Fields
        public System.Single updatePower;        // 0x10
        public System.Int32 runCount;        // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.RestoreRotationConstraint.RotationData> dataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.RestoreRotationConstraint.GroupData> groupList;        // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x68
        public Unity.Collections.NativeArray<System.Single> depthList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x98
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0xA8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outNextPosList;        // 0xB8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xC8

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000090
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public System.Single spring;        // 0x18

    }

    // TypeToken: 0x2000091
    public struct SpringJob, IJobParallelFor
    {
        // Fields
        public System.Single updatePower;        // 0x10
        public System.Int32 runCount;        // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.SpringConstraint.GroupData> groupList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x68

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000093
    public struct TriangleBendData
    {
        // Fields
        public System.Int32 vindex0;        // 0x10
        public System.Int32 vindex1;        // 0x14
        public System.Int32 vindex2;        // 0x18
        public System.Int32 vindex3;        // 0x1C
        public System.Single restAngle;        // 0x20
        public System.Single direction;        // 0x24
        public System.Single depth;        // 0x28
        public System.Int32 writeIndex0;        // 0x2C
        public System.Int32 writeIndex1;        // 0x30
        public System.Int32 writeIndex2;        // 0x34
        public System.Int32 writeIndex3;        // 0x38

        // Methods
        private System.Boolean IsValid() { }
        private System.Boolean IsPositionBend() { }

    }

    // TypeToken: 0x2000094
    public struct TriangleBendGroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public System.Int32 algorithm;        // 0x18
        public MagicaCloth.CurveParam stiffness;        // 0x1C
        public MagicaCloth.ChunkData dataChunk;        // 0x2C
        public MagicaCloth.ChunkData groupIndexChunk;        // 0x3C
        public MagicaCloth.ChunkData refDataChunk;        // 0x4C
        public MagicaCloth.ChunkData writeDataChunk;        // 0x5C

    }

    // TypeToken: 0x2000095
    public struct TriangleBendCalcJob, IJobParallelFor
    {
        // Fields
        public System.Single updatePower;        // 0x10
        public System.Int32 runCount;        // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendGroupData> triangleBendGroupDataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendData> triangleBendList;        // 0x28
        public Unity.Collections.NativeArray<System.Int16> groupIndexList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x78

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000096
    public struct TriangleBendSumJob, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendGroupData> triangleBendGroupDataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> inoutNextPosList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x88

        // Methods
        private System.Void Execute(System.Int32 pindex) { }

    }

    // TypeToken: 0x2000098
    public struct TwistData
    {
        // Fields
        public System.UInt16 vertexIndex0;        // 0x10
        public System.UInt16 vertexIndex1;        // 0x12

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000099
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public System.Single recoveryPower;        // 0x18
        public MagicaCloth.ChunkData dataChunk;        // 0x1C
        public MagicaCloth.ChunkData refChunk;        // 0x2C

    }

    // TypeToken: 0x200009A
    public struct TwistJob2, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public System.Single updatePower;        // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.TwistConstraint.TwistData> dataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.TwistConstraint.GroupData> groupList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x88
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outNextPosList;        // 0xA8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xB8

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200009C
    public struct VolumeData
    {
        // Fields
        public System.Int32 vindex0;        // 0x10
        public System.Int32 vindex1;        // 0x14
        public System.Int32 vindex2;        // 0x18
        public System.Int32 vindex3;        // 0x1C
        public Unity.Mathematics.float3x3 ivMat;        // 0x20
        public System.Single depth;        // 0x44
        public System.Int32 direction;        // 0x48
        public System.Int32 writeIndex0;        // 0x4C
        public System.Int32 writeIndex1;        // 0x50
        public System.Int32 writeIndex2;        // 0x54
        public System.Int32 writeIndex3;        // 0x58

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x200009D
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public MagicaCloth.CurveParam stretchStiffness;        // 0x18
        public MagicaCloth.CurveParam shearStiffness;        // 0x28
        public MagicaCloth.ChunkData dataChunk;        // 0x38
        public MagicaCloth.ChunkData groupIndexChunk;        // 0x48
        public MagicaCloth.ChunkData refDataChunk;        // 0x58
        public MagicaCloth.ChunkData writeDataChunk;        // 0x68

    }

    // TypeToken: 0x200009E
    public struct VolumeCalcJob, IJobParallelFor
    {
        // Fields
        public System.Single updatePower;        // 0x10
        public System.Int32 runCount;        // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.VolumeConstraint.GroupData> groupDataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.VolumeConstraint.VolumeData> dataList;        // 0x28
        public Unity.Collections.NativeArray<System.Int16> groupIndexList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x68

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200009F
    public struct VolumeSumJob, IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.VolumeConstraint.GroupData> groupDataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> inoutNextPosList;        // 0x78

        // Methods
        private System.Void Execute(System.Int32 pindex) { }

    }

    // TypeToken: 0x20000A5
    public struct RestoreBoneJob, IJobParallelForTransform
    {
        // Fields
        public System.Boolean fixedUpdate;        // 0x10
        public Unity.Collections.NativeArray<System.Int16> boneUnityPhysicsList;        // 0x18
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> restoreBoneLocalPosList;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> restoreBoneLocalRotList;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> restoreBoneIndexList;        // 0x58

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000A6
    public struct ReadBoneJob0, IJobParallelForTransform
    {
        // Fields
        public System.Int32 fixedUpdateCount;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> futurePosList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> futureRotList;        // 0x78
        public Unity.Collections.NativeArray<System.Int16> boneUnityPhysicsList;        // 0x88
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;        // 0x98

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000A7
    public struct ReadBoneJob1, IJobParallelForTransform
    {
        // Fields
        public System.Int32 fixedUpdateCount;        // 0x10
        public System.Single normalFutureRatio;        // 0x14
        public System.Single fixedFutureRatio;        // 0x18
        public System.Single normalDeltaTime;        // 0x1C
        public System.Single fixedDeltaTime;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0x68
        public Unity.Collections.NativeArray<System.Int16> boneUnityPhysicsList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> futurePosList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> futureRotList;        // 0x98
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;        // 0xA8

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000A8
    public struct ConvertWorldToLocalJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> writeBoneIndexList;        // 0x10
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;        // 0x50
        public Unity.Collections.NativeArray<System.Int32> boneParentIndexList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBonePosList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> writeBoneRotList;        // 0x80

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000A9
    public struct WriteBontToTransformJob2, IJobParallelForTransform
    {
        // Fields
        public System.Int32 fixedUpdateCount;        // 0x10
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;        // 0x18
        public Unity.Collections.NativeArray<System.Int32> writeBoneIndexList;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> boneParentIndexList;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBonePosList;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> writeBoneRotList;        // 0x58
        public Unity.Collections.NativeArray<System.Int16> boneUnityPhysicsList;        // 0x68

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000AA
    public struct CopyBoneJob0, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> backBonePosList;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> backBoneRotList;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000AB
    public struct CopyBoneJob1, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> writeBoneIndexList;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> backWriteBoneIndexList;        // 0x20

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000AC
    public struct CopyBoneJob2, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;        // 0x10
        public Unity.Collections.NativeArray<System.Byte> backBoneFlagList;        // 0x20

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000AF
    public struct ForceAndVelocityJob, IJobParallelFor
    {
        // Fields
        public System.Single updateDeltaTime;        // 0x10
        public System.Single updatePower;        // 0x14
        public System.Int32 runCount;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamMassList;        // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamGravityList;        // 0x40
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamDragList;        // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamDepthInfluenceList;        // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WindInfo> teamWindInfoList;        // 0x70
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x80
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x90
        public Unity.Collections.NativeArray<System.Single> depthList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldBasePosList;        // 0xF0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldBaseRotList;        // 0x100
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x110
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0x120
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0x130
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x140
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0x150
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;        // 0x160
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;        // 0x170
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;        // 0x180
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerWindData.WindData> windDataList;        // 0x190
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0x1A0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0x1B0

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private Unity.Mathematics.float3 Wind(System.Int32 teamId, MagicaCloth.PhysicsManagerTeamData.TeamData& teamData, Unity.Mathematics.float3& pos) { }

    }

    // TypeToken: 0x20000B0
    public struct FixPositionJob, IJobParallelFor
    {
        // Fields
        public System.Single updatePower;        // 0x10
        public System.Single updateDeltaTime;        // 0x14
        public System.Int32 runCount;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamMaxVelocityList;        // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x50
        public Unity.Collections.NativeArray<System.Single> depthList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0x80
        public Unity.Collections.NativeArray<System.Single> frictionList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;        // 0xF0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalList;        // 0x100
        public Unity.Collections.NativeArray<System.Single> staticFrictionList;        // 0x110

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000B1
    public struct PostUpdatePhysicsJob, IJobParallelFor
    {
        // Fields
        public System.Single updateDeltaTime;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldBasePosList;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldBaseRotList;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;        // 0xA8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;        // 0xB8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;        // 0xC8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;        // 0xD8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xE8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0xF8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x108
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0x118
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldSlowPosList;        // 0x128

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000B4
    public struct SharedVirtualMeshInfo
    {
        // Fields
        public System.Int32 uid;        // 0x10
        public System.Int32 useCount;        // 0x14
        public System.Int32 sharedChildMeshStartIndex;        // 0x18
        public System.Int32 sharedChildMeshCount;        // 0x1C
        public MagicaCloth.ChunkData vertexChunk;        // 0x20
        public MagicaCloth.ChunkData weightChunk;        // 0x30
        public MagicaCloth.ChunkData triangleChunk;        // 0x40
        public MagicaCloth.ChunkData vertexToTriangleChunk;        // 0x50

    }

    // TypeToken: 0x20000B5
    public struct VirtualMeshInfo
    {
        // Fields
        public System.UInt32 flag;        // 0x10
        public System.Int32 sharedVirtualMeshIndex;        // 0x14
        public System.Int32 meshUseCount;        // 0x18
        public System.Int32 vertexUseCount;        // 0x1C
        public MagicaCloth.ChunkData vertexChunk;        // 0x20
        public MagicaCloth.ChunkData boneChunk;        // 0x30
        public MagicaCloth.ChunkData triangleChunk;        // 0x40
        public System.Int32 transformIndex;        // 0x50

        // Methods
        private System.Boolean IsFlag(System.UInt32 flag) { }
        private System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        private System.Boolean IsActive() { }
        private System.Boolean IsUse() { }
        private System.Boolean IsPause() { }

    }

    // TypeToken: 0x20000B6
    public struct SharedChildMeshInfo
    {
        // Fields
        public System.Int64 cuid;        // 0x10
        public System.Int32 sharedVirtualMeshIndex;        // 0x18
        public System.Int32 virtualMeshIndex;        // 0x1C
        public System.Int32 meshUseCount;        // 0x20
        public MagicaCloth.ChunkData vertexChunk;        // 0x24
        public MagicaCloth.ChunkData weightChunk;        // 0x34

    }

    // TypeToken: 0x20000B7
    public struct SharedRenderMeshInfo
    {
        // Fields
        public System.Int32 uid;        // 0x10
        public System.Int32 useCount;        // 0x14
        public System.UInt32 flag;        // 0x18
        public MagicaCloth.ChunkData vertexChunk;        // 0x1C
        public MagicaCloth.ChunkData bonePerVertexChunk;        // 0x2C
        public MagicaCloth.ChunkData boneWeightsChunk;        // 0x3C
        public System.Int32 rendererBoneIndex;        // 0x4C

        // Methods
        private System.Boolean IsFlag(System.UInt32 flag) { }
        private System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        private System.Boolean IsSkinning() { }

    }

    // TypeToken: 0x20000B8
    public struct RenderMeshInfo
    {
        // Fields
        public System.UInt32 flag;        // 0x10
        public System.Int32 renderSharedMeshIndex;        // 0x14
        public System.Int32 sharedRenderMeshVertexStartIndex;        // 0x18
        public System.Int32 meshUseCount;        // 0x1C
        public Unity.Mathematics.int4 childMeshVertexStartIndex;        // 0x20
        public Unity.Mathematics.int4 childMeshWeightStartIndex;        // 0x30
        public Unity.Mathematics.int4 virtualMeshVertexStartIndex;        // 0x40
        public Unity.Mathematics.int4 sharedVirtualMeshVertexStartIndex;        // 0x50
        public Unity.Mathematics.int4 linkMeshCount;        // 0x60
        public MagicaCloth.ChunkData vertexChunk;        // 0x70
        public MagicaCloth.ChunkData boneWeightsChunk;        // 0x80
        public System.Int32 transformIndex;        // 0x90
        public System.Single baseScale;        // 0x94

        // Methods
        private System.Boolean IsFlag(System.UInt32 flag) { }
        private System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        private System.Boolean IsActive() { }
        private System.Boolean IsUse() { }
        private System.Boolean IsLinkMesh(System.Int32 index) { }
        private System.Boolean IsPause() { }
        private System.Boolean IsFasterWrite() { }
        private System.Boolean IsSkinning() { }
        private System.Boolean AddLinkMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart) { }
        private System.Boolean RemoveLinkMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart) { }

    }

    // TypeToken: 0x20000B9
    public class RenderMeshState
    {
        // Fields
        public System.UInt32 flag;        // 0x10
        public System.Int32 RenderSharedMeshIndex;        // 0x14
        public System.Int32 RenderSharedMeshId;        // 0x18
        public System.Int32 VertexChunkStart;        // 0x1C
        public System.Int32 VertexChunkLength;        // 0x20
        public System.Int32 BoneWeightChunkStart;        // 0x24
        public System.Int32 BoneWeightChunkLength;        // 0x28

        // Methods
        private System.Boolean IsFlag(System.UInt32 flag) { }
        private System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA
    public struct CopyRenderBuffer, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalList;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalArray;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000BD
    public struct ParticleFlag
    {
        // Fields
        public System.UInt32 flag;        // 0x10

        // Methods
        private System.Void .ctor(System.UInt32[] flags) { }
        private System.Boolean IsFlag(System.UInt32 flag) { }
        private System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        private System.Boolean IsValid() { }
        private System.Void SetEnable(System.Boolean sw) { }
        private System.Boolean IsFixed() { }
        private System.Boolean IsMove() { }
        private System.Boolean IsKinematic() { }
        private System.Boolean IsHold() { }
        private System.Boolean IsCollider() { }
        private System.Boolean IsReadTransform() { }
        private System.Boolean IsWriteTransform() { }
        private System.Boolean IsRestoreTransform() { }
        private System.Boolean IsUnityPhysics() { }
        private System.Boolean IsReadSclTransform() { }
        private System.Boolean IsParentTransform() { }

    }

    // TypeToken: 0x20000BE
    public struct CopyBoneToParticleJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamData;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList;        // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x30
        public Unity.Collections.NativeArray<System.Single> depthList;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> transformIndexList;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;        // 0x60
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldSlowPosList;        // 0xF0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0x100
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;        // 0x110
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;        // 0x120
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldBasePosList;        // 0x130
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldBaseRotList;        // 0x140
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x150

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000BF
    public struct ResetParticleJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamData;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldBasePosList;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldBaseRotList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldSlowPosList;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;        // 0xF0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;        // 0x100
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;        // 0x110
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;        // 0x120

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000C0
    public struct CopyParticleToBoneJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneBasePosList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneBaseRotList;        // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x60
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x70
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32> transformParticleIndexMap;        // 0x80
        public Unity.Collections.NativeArray<System.Int32> writeBoneIndexList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0xB0

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000C2
    public struct ForceMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode None;        // 0x0
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode VelocityAdd;        // 0x0
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode VelocityChange;        // 0x0
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode VelocityAddWithoutMass;        // 0x0
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode VelocityChangeWithoutMass;        // 0x0

    }

    // TypeToken: 0x20000C3
    public struct TeamData
    {
        // Fields
        public MagicaCloth.ChunkData particleChunk;        // 0x10
        public MagicaCloth.ChunkData colliderChunk;        // 0x20
        public MagicaCloth.ChunkData skinningBoneChunk;        // 0x30
        public System.UInt32 flag;        // 0x40
        public System.Single dynamicFriction;        // 0x44
        public System.Single staticFriction;        // 0x48
        public System.Single selfCollisionRange;        // 0x4C
        public System.Int32 boneIndex;        // 0x50
        public Unity.Mathematics.float3 initScale;        // 0x54
        public System.Single scaleRatio;        // 0x60
        public Unity.Mathematics.float3 scaleDirection;        // 0x64
        public Unity.Mathematics.float4 quaternionScale;        // 0x70
        public System.Single time;        // 0x80
        public System.Single oldTime;        // 0x84
        public System.Single addTime;        // 0x88
        public System.Single timeScale;        // 0x8C
        public System.Single nowTime;        // 0x90
        public System.Single startTime;        // 0x94
        public System.Int32 updateCount;        // 0x98
        public System.Single blendRatio;        // 0x9C
        public System.Single outPhysicsPoseBlendRatio;        // 0xA0
        public Unity.Mathematics.float3 externalForce;        // 0xA4
        public System.Single forceMassInfluence;        // 0xB0
        public System.Single forceWindInfluence;        // 0xB4
        public System.Single forceWindRandomScale;        // 0xB8
        public System.Single forceWindSynchronization;        // 0xBC
        public System.Single velocityWeight;        // 0xC0
        public System.Single velocityRecoverySpeed;        // 0xC4
        public Unity.Mathematics.float3 gravityDirection;        // 0xC8
        public MagicaCloth.PhysicsManagerTeamData.ForceMode forceMode;        // 0xD4
        public Unity.Mathematics.float3 impactForce;        // 0xD8
        public System.Int32 calcCount;        // 0xE4
        public System.Int16 restoreDistanceGroupIndex;        // 0xE8
        public System.Int16 triangleBendGroupIndex;        // 0xEA
        public System.Int16 clampDistanceGroupIndex;        // 0xEC
        public System.Int16 clampDistance2GroupIndex;        // 0xEE
        public System.Int16 clampPositionGroupIndex;        // 0xF0
        public System.Int16 clampRotationGroupIndex;        // 0xF2
        public System.Int16 restoreRotationGroupIndex;        // 0xF4
        public System.Int16 adjustRotationGroupIndex;        // 0xF6
        public System.Int16 springGroupIndex;        // 0xF8
        public System.Int16 volumeGroupIndex;        // 0xFA
        public System.Int16 airLineGroupIndex;        // 0xFC
        public System.Int16 lineWorkerGroupIndex;        // 0xFE
        public System.Int16 triangleWorkerGroupIndex;        // 0x100
        public System.Int16 selfCollisionGroupIndex;        // 0x102
        public System.Int16 edgeCollisionGroupIndex;        // 0x104
        public System.Int16 penetrationGroupIndex;        // 0x106
        public System.Int16 baseSkinningGroupIndex;        // 0x108
        public System.Int16 twistGroupIndex;        // 0x10A
        public System.Int16 compositeRotationGroupIndex;        // 0x10C

        // Methods
        private System.Boolean IsActive() { }
        private System.Boolean IsRunning() { }
        private System.Boolean IsUpdate(System.Int32 runCount) { }
        private System.Boolean IsInterpolate() { }
        private System.Boolean IsPhysicsUpdate() { }
        private System.Boolean IsFlag(System.UInt32 flag) { }
        private System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        private System.Boolean IsReset() { }
        private System.Boolean IsPause() { }

    }

    // TypeToken: 0x20000C4
    public struct WorldInfluence
    {
        // Fields
        public MagicaCloth.CurveParam moveInfluence;        // 0x10
        public MagicaCloth.CurveParam rotInfluence;        // 0x20
        public System.Single maxMoveSpeed;        // 0x30
        public System.Single maxRotationSpeed;        // 0x34
        public Unity.Mathematics.float3 nowPosition;        // 0x38
        public Unity.Mathematics.float3 oldPosition;        // 0x44
        public Unity.Mathematics.float3 moveOffset;        // 0x50
        public System.Single moveIgnoreRatio;        // 0x5C
        public Unity.Mathematics.quaternion nowRotation;        // 0x60
        public Unity.Mathematics.quaternion oldRotation;        // 0x70
        public Unity.Mathematics.quaternion rotationOffset;        // 0x80
        public System.Single rotationIgnoreRatio;        // 0x90
        public System.Int32 resetTeleport;        // 0x94
        public System.Single teleportDistance;        // 0x98
        public System.Single teleportRotation;        // 0x9C
        public MagicaCloth.ClothParams.TeleportMode teleportMode;        // 0xA0
        public System.Single stabilizationTime;        // 0xA4
        public System.Single clampRotationLimit;        // 0xA8

    }

    // TypeToken: 0x20000C5
    public struct WindInfo
    {
        // Fields
        public System.Int32 windCount;        // 0x10
        public Unity.Mathematics.int4 windDataIndexList;        // 0x14
        public Unity.Mathematics.float3x4 windDirectionList;        // 0x24
        public Unity.Mathematics.float4 windMainList;        // 0x54

    }

    // TypeToken: 0x20000C6
    public struct PreProcessTeamDataJob, IJobParallelFor
    {
        // Fields
        public System.Single deltaTime;        // 0x10
        public System.Single physicsDeltaTime;        // 0x14
        public System.Single updateDeltaTime;        // 0x18
        public System.Single globalTimeScale;        // 0x1C
        public System.Int32 maxUpdateCount;        // 0x20
        public System.Single unityTimeScale;        // 0x24
        public System.Single elapsedTime;        // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamData;        // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList;        // 0x40
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WindInfo> teamWindInfoList;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;        // 0x80
        public System.Int32 windCount;        // 0x90
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerWindData.WindData> windData;        // 0x98

        // Methods
        private System.Void Execute(System.Int32 teamId) { }
        private System.Void UpdateTime(MagicaCloth.PhysicsManagerTeamData.TeamData& tdata, System.Boolean reset, System.Single dtime) { }
        private System.Void Wind(MagicaCloth.PhysicsManagerTeamData.TeamData& tdata, Unity.Mathematics.float3 pos, System.Int32 teamId) { }

    }

    // TypeToken: 0x20000C7
    public struct PostProcessTeamDataJob, IJobParallelFor
    {
        // Fields
        public System.Int32 fixedUpdateCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamData;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList;        // 0x28

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000CA
    public struct WindType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.PhysicsManagerWindData.WindType None;        // 0x0
        public static MagicaCloth.PhysicsManagerWindData.WindType Direction;        // 0x0
        public static MagicaCloth.PhysicsManagerWindData.WindType Area;        // 0x0

    }

    // TypeToken: 0x20000CB
    public struct ShapeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.PhysicsManagerWindData.ShapeType Box;        // 0x0
        public static MagicaCloth.PhysicsManagerWindData.ShapeType Sphere;        // 0x0

    }

    // TypeToken: 0x20000CC
    public struct DirectionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.PhysicsManagerWindData.DirectionType OneDirection;        // 0x0
        public static MagicaCloth.PhysicsManagerWindData.DirectionType Radial;        // 0x0

    }

    // TypeToken: 0x20000CD
    public struct WindData
    {
        // Fields
        public System.UInt32 flag;        // 0x10
        public MagicaCloth.PhysicsManagerWindData.WindType windType;        // 0x14
        public MagicaCloth.PhysicsManagerWindData.ShapeType shapeType;        // 0x18
        public System.Int32 transformIndex;        // 0x1C
        public Unity.Mathematics.float3 areaSize;        // 0x20
        public System.Single main;        // 0x2C
        public System.Single turbulence;        // 0x30
        public System.Single frequency;        // 0x34
        public Unity.Mathematics.float3 direction;        // 0x38
        public MagicaCloth.PhysicsManagerWindData.DirectionType directionType;        // 0x44
        public System.Single areaVolume;        // 0x48
        public System.Single areaLength;        // 0x4C
        public MagicaCloth.CurveParam attenuation;        // 0x50

        // Methods
        private System.Boolean IsFlag(System.UInt32 flag) { }
        private System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        private System.Void SetEnable(System.Boolean sw) { }
        private System.Boolean IsActive() { }

    }

    // TypeToken: 0x20000D1
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.MagicaCapsuleCollider.Axis X;        // 0x0
        public static MagicaCloth.MagicaCapsuleCollider.Axis Y;        // 0x0
        public static MagicaCloth.MagicaCapsuleCollider.Axis Z;        // 0x0

    }

    // TypeToken: 0x20000D6
    public struct TeamUpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.PhysicsTeam.TeamUpdateMode Normal;        // 0x0
        public static MagicaCloth.PhysicsTeam.TeamUpdateMode UnityPhysics;        // 0x0

    }

    // TypeToken: 0x20000D7
    public struct TeamCullingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.PhysicsTeam.TeamCullingMode Reset;        // 0x0
        public static MagicaCloth.PhysicsTeam.TeamCullingMode Pause;        // 0x0
        public static MagicaCloth.PhysicsTeam.TeamCullingMode Off;        // 0x0

    }

    // TypeToken: 0x20000D8
    public struct TeamSkinningMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.PhysicsTeam.TeamSkinningMode None;        // 0x0
        public static MagicaCloth.PhysicsTeam.TeamSkinningMode UserAnimation;        // 0x0

    }

    // TypeToken: 0x20000DB
    public struct AdjustRotationData
    {
        // Fields
        public System.Int32 keyIndex;        // 0x10
        public System.Int32 targetIndex;        // 0x14
        public Unity.Mathematics.float3 localPos;        // 0x18

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x20000DC
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public System.Int32 adjustMode;        // 0x18
        public Unity.Mathematics.float3 axisRotationPower;        // 0x1C
        public MagicaCloth.ChunkData chunk;        // 0x28

    }

    // TypeToken: 0x20000DD
    public struct AdjustRotationJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.AdjustRotationWorker.AdjustRotationData> dataList;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.AdjustRotationWorker.GroupData> groupList;        // 0x20
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32> particleMap;        // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0xA0

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000DF
    public struct BaseSkinningData
    {
        // Fields
        public Unity.Mathematics.float3 localPos;        // 0x10
        public Unity.Mathematics.float3 localNor;        // 0x1C
        public Unity.Mathematics.float3 localTan;        // 0x28
        public Unity.Mathematics.int4 boneIndices;        // 0x34
        public Unity.Mathematics.float4 weights;        // 0x44
        public System.Int16 weightCount;        // 0x54

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x20000E0
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 active;        // 0x14
        public System.Int32 updateFixed;        // 0x18
        public MagicaCloth.ChunkData dataChunk;        // 0x1C
        public MagicaCloth.ChunkData bindPoseChunk;        // 0x2C

    }

    // TypeToken: 0x20000E1
    public struct BaseSkinningJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.BaseSkinningWorker.GroupData> groupList;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.BaseSkinningWorker.BaseSkinningData> dataList;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> bindPoseList;        // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> skinningBoneList;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;        // 0x80
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x90
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;        // 0xC0

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000E3
    public struct LineRotationData
    {
        // Fields
        public System.Int32 vertexIndex;        // 0x10
        public System.Int32 childCount;        // 0x14
        public System.Int32 childStartDataIndex;        // 0x18
        public Unity.Mathematics.float3 localPos;        // 0x1C
        public Unity.Mathematics.quaternion localRot;        // 0x28

    }

    // TypeToken: 0x20000E4
    public struct LineRotationRootInfo
    {
        // Fields
        public System.UInt16 startIndex;        // 0x10
        public System.UInt16 dataLength;        // 0x12

    }

    // TypeToken: 0x20000E5
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 avarage;        // 0x14
        public MagicaCloth.ChunkData dataChunk;        // 0x18
        public MagicaCloth.ChunkData rootInfoChunk;        // 0x28

    }

    // TypeToken: 0x20000E6
    public struct LineRotationJob, IJobParallelFor
    {
        // Fields
        public System.Int32 fixedUpdateCount;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.LineWorker.LineRotationData> dataList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.LineWorker.LineRotationRootInfo> rootInfoList;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> rootTeamList;        // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.LineWorker.GroupData> groupList;        // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0x88

        // Methods
        private System.Void Execute(System.Int32 rootIndex) { }

    }

    // TypeToken: 0x20000E8
    public struct CreateData
    {
        // Fields
        public System.Int32 vertexIndex;        // 0x10
        public System.Int32 particleIndex;        // 0x14

    }

    // TypeToken: 0x20000E9
    public struct VertexToParticleJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> vertexToParticleList;        // 0x20
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32> vertexToParticleMap;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0x50
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;        // 0x80
        private Unity.Collections.NativeParallelMultiHashMapIterator<System.Int32> iterator;        // 0x90

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000EA
    public struct ParticleToVertexJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> vertexToParticleList;        // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32> vertexToParticleMap;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;        // 0x40
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;        // 0x50
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;        // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;        // 0x70
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x80
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x90
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> particleFlagList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> particlePosList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> particleRotList;        // 0xC0
        private Unity.Collections.NativeParallelMultiHashMapIterator<System.Int32> iterator;        // 0xD0

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000EC
    public struct CalcVertexUseFlagJob, IJobParallelFor
    {
        // Fields
        public System.UInt32 updateFlag;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;        // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedRenderMeshInfo> sharedRenderMeshInfoList;        // 0x28
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;        // 0x38
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFixList;        // 0x48
        public Unity.Collections.NativeArray<System.UInt32> sharedChildVertexInfoList;        // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight> sharedChildVertexWeightList;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> sharedRenderVertices;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> sharedRenderNormals;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float4> sharedRenderTangents;        // 0x98
        public Unity.Collections.NativeArray<System.Byte> sharedBonesPerVertexList;        // 0xA8
        public Unity.Collections.NativeArray<System.Int32> sharedBonesPerVertexStartList;        // 0xB8
        public Unity.Collections.NativeArray<UnityEngine.BoneWeight1> sharedBoneWeightList;        // 0xC8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosList;        // 0xD8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalList;        // 0xE8
        public Unity.Collections.NativeArray<Unity.Mathematics.float4> renderTangentList;        // 0xF8
        public Unity.Collections.NativeArray<UnityEngine.BoneWeight1> renderBoneWeightList;        // 0x108
        public Unity.Collections.NativeArray<System.UInt32> renderVertexFlagList;        // 0x118
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosArray;        // 0x128
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalArray;        // 0x138

        // Methods
        private System.Void Execute(System.Int32 rmindex) { }

    }

    // TypeToken: 0x20000ED
    public struct CollectLocalPositionNormalTangentForEachMeshJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPosList;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotList;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;        // 0x40
        public Unity.Collections.NativeArray<System.UInt32> sharedChildVertexInfoList;        // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight> sharedChildVertexWeightList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;        // 0x80
        public Unity.Collections.NativeArray<System.UInt32> renderVertexFlagList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float4> renderTangentList;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosArray;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalArray;        // 0xE0

        // Methods
        private System.Void Execute(System.Int32 rmindex) { }

    }

    // TypeToken: 0x20000EE
    public struct CollectLocalPositionNormalTangentForEachVertexJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPosList;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotList;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;        // 0x40
        public Unity.Collections.NativeArray<System.UInt32> sharedChildVertexInfoList;        // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight> sharedChildVertexWeightList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;        // 0x80
        public Unity.Collections.NativeArray<System.UInt32> renderVertexFlagList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float4> renderTangentList;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosArray;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalArray;        // 0xE0

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20000F0
    public struct SpringData
    {
        // Fields
        public System.Int32 particleIndex;        // 0x10
        public System.Single weight;        // 0x14

    }

    // TypeToken: 0x20000F1
    public struct SpringJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> springVertexList;        // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,MagicaCloth.SpringMeshWorker.SpringData> springMap;        // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> particlePosList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> particleRotList;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;        // 0x80
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;        // 0x90
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;        // 0xA0
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;        // 0xB0
        private Unity.Collections.NativeParallelMultiHashMapIterator<System.Int32> iterator;        // 0xC0

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000F3
    public struct TriangleRotationData
    {
        // Fields
        public System.Int32 targetIndex;        // 0x10
        public System.Int32 triangleCount;        // 0x14
        public System.Int32 triangleStartIndex;        // 0x18
        public Unity.Mathematics.quaternion localRot;        // 0x1C

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x20000F4
    public struct GroupData
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public MagicaCloth.ChunkData triangleDataChunk;        // 0x14
        public MagicaCloth.ChunkData triangleIndexChunk;        // 0x24

    }

    // TypeToken: 0x20000F5
    public struct TriangleRotationJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.TriangleWorker.TriangleRotationData> triangleDataList;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> triangleIndexList;        // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.TriangleWorker.GroupData> groupList;        // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> teamIdList;        // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;        // 0x80

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000F7
    public struct ReadMeshPositionJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;        // 0x20
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;        // 0x30
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> virtualTransformIndexList;        // 0x50
        public Unity.Collections.NativeArray<System.UInt32> sharedVirtualVertexInfoList;        // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight> sharedVirtualWeightList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPosList;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;        // 0xC0
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;        // 0xD0

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20000F8
    public struct CalcMeshTriangleNormalTangentJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;        // 0x20
        public Unity.Collections.NativeArray<System.UInt16> virtualTriangleMeshIndexList;        // 0x30
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;        // 0x50
        public Unity.Collections.NativeArray<System.Int32> sharedTriangles;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> sharedMeshUv;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleNormalList;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleTangentList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;        // 0xA0

        // Methods
        private System.Void Execute(System.Int32 tindex) { }

    }

    // TypeToken: 0x20000F9
    public struct CalcVertexNormalTangentFromTriangleJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;        // 0x20
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;        // 0x30
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;        // 0x40
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;        // 0x50
        public Unity.Collections.NativeArray<System.UInt32> sharedVirtualVertexToTriangleInfoList;        // 0x60
        public Unity.Collections.NativeArray<System.Int32> sharedVirtualVertexToTriangleIndexList;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleNormalList;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleTangentList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;        // 0xA0

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20000FA
    public struct CalcMeshTriangleNormalTangentForEachMeshJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;        // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;        // 0x20
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;        // 0x30
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;        // 0x50
        public Unity.Collections.NativeArray<System.Int32> sharedTriangles;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> sharedMeshUv;        // 0x70
        public Unity.Collections.NativeArray<System.UInt32> sharedVirtualVertexToTriangleInfoList;        // 0x80
        public Unity.Collections.NativeArray<System.Int32> sharedVirtualVertexToTriangleIndexList;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleNormalList;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleTangentList;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;        // 0xD0

        // Methods
        private System.Void Execute(System.Int32 mindex) { }

    }

    // TypeToken: 0x2000100
    public struct MoveMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.CameraOrbit.MoveMode None;        // 0x0
        public static MagicaCloth.CameraOrbit.MoveMode UpDown;        // 0x0
        public static MagicaCloth.CameraOrbit.MoveMode Free;        // 0x0

    }

    // TypeToken: 0x2000104
    public class AvatarPartsGroup
    {
        // Fields
        public System.String groupName;        // 0x10
        public System.Collections.Generic.List<UnityEngine.GameObject> partsPrefabList;        // 0x18
        public System.Int32 id;        // 0x20
        public System.Int32 handle;        // 0x24
        public System.Int32 index;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000116
    public class Point
    {
        // Fields
        public System.Int32 id;        // 0x10
        public Unity.Mathematics.float3 pos;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000128
    public class TetraVertex
    {
        // Fields
        public System.Int32 index;        // 0x10
        public UnityEngine.Vector3 pos;        // 0x14

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Vector3 pos, System.Int32 index) { }

    }

    // TypeToken: 0x2000129
    public class Tetra
    {
        // Fields
        public System.Collections.Generic.List<MagicaCloth.MeshUtility.TetraVertex> vertexList;        // 0x10
        public UnityEngine.Vector3 circumCenter;        // 0x18
        public System.Single circumRadius;        // 0x24
        public UnityEngine.Vector3 tetraCenter;        // 0x28
        public System.Single tetraSize;        // 0x34

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(MagicaCloth.MeshUtility.TetraVertex a, MagicaCloth.MeshUtility.TetraVertex b, MagicaCloth.MeshUtility.TetraVertex c, MagicaCloth.MeshUtility.TetraVertex d) { }
        private System.UInt64 GetTetraHash() { }
        private System.Void CalcCircumcircle() { }
        private System.Boolean IntersectCircumcircle(UnityEngine.Vector3 pos) { }
        private System.Boolean CheckSame(MagicaCloth.MeshUtility.Tetra tri) { }
        private System.Boolean ContainsPoint(MagicaCloth.MeshUtility.TetraVertex p1) { }
        private System.Boolean ContainsPoint(MagicaCloth.MeshUtility.TetraVertex p1, MagicaCloth.MeshUtility.TetraVertex p2, MagicaCloth.MeshUtility.TetraVertex p3, MagicaCloth.MeshUtility.TetraVertex p4) { }
        private System.Void CalcSize() { }
        private System.Boolean Verification() { }

    }

    // TypeToken: 0x200012C
    public struct UpdateCount
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.UpdateTimeManager.UpdateCount _60;        // 0x0
        public static MagicaCloth.UpdateTimeManager.UpdateCount _90_Default;        // 0x0
        public static MagicaCloth.UpdateTimeManager.UpdateCount _120;        // 0x0
        public static MagicaCloth.UpdateTimeManager.UpdateCount _150;        // 0x0
        public static MagicaCloth.UpdateTimeManager.UpdateCount _180;        // 0x0

    }

    // TypeToken: 0x200012D
    public struct UpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.UpdateTimeManager.UpdateMode UnscaledTime;        // 0x0
        public static MagicaCloth.UpdateTimeManager.UpdateMode OncePerFrame;        // 0x0
        public static MagicaCloth.UpdateTimeManager.UpdateMode DelayUnscaledTime;        // 0x0

    }

    // TypeToken: 0x200012E
    public struct UpdateLocation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.UpdateTimeManager.UpdateLocation AfterLateUpdate;        // 0x0
        public static MagicaCloth.UpdateTimeManager.UpdateLocation BeforeLateUpdate;        // 0x0

    }

namespace MagicaCloth
{

    // TypeToken: 0x2000025
    public class BaseCloth : PhysicsTeam
    {
        // Fields
        protected MagicaCloth.ClothParams clothParams;        // 0x78
        protected System.Collections.Generic.List<System.Int32> clothParamDataHashList;        // 0x80
        private MagicaCloth.ClothData clothData;        // 0x88
        protected System.Int32 clothDataHash;        // 0x90
        protected System.Int32 clothDataVersion;        // 0x94
        private MagicaCloth.SelectionData clothSelection;        // 0x98
        private System.Int32 clothSelectionHash;        // 0xA0
        private System.Int32 clothSelectionVersion;        // 0xA4
        private System.Collections.Generic.List<UnityEngine.Renderer> cullRendererList;        // 0xA8
        protected MagicaCloth.ClothSetup setup;        // 0xB0
        private System.Single oldBlendRatio;        // 0xB8
        private MagicaCloth.PhysicsTeam.TeamUpdateMode oldUpdateMode;        // 0xBC
        private MagicaCloth.PhysicsTeam.TeamCullingMode oldCullingMode;        // 0xC0
        private System.Boolean oldUseAnimatedDistance;        // 0xC4

        // Methods
        private System.Void ResetCloth() { }
        private System.Void ResetCloth(System.Single resetStabilizationTime) { }
        private System.Void ResetCloth(MagicaCloth.ClothParams.TeleportMode teleportMode, System.Single resetStabilizationTime) { }
        private System.Void SetTimeScale(System.Single timeScale) { }
        private System.Single GetTimeScale() { }
        private System.Void AddForce(UnityEngine.Vector3 force, MagicaCloth.PhysicsManagerTeamData.ForceMode mode) { }
        private System.Single get_BlendWeight() { }
        private System.Void set_BlendWeight(System.Single value) { }
        private System.Void AddCollider(MagicaCloth.ColliderComponent collider) { }
        private System.Void RemoveCollider(MagicaCloth.ColliderComponent collider) { }
        private System.Void SetUpdateMode(MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode) { }
        private System.Void SetCullingMode(MagicaCloth.PhysicsTeam.TeamCullingMode cullingMode) { }
        private System.Void Radius_SetRadius(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private System.Void Mass_SetMass(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private System.Void ClampPosition_SetPositionLength(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private System.Void Gravity_SetGravity(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private UnityEngine.Vector3 get_Gravity_GravityDirection() { }
        private System.Void set_Gravity_GravityDirection(UnityEngine.Vector3 value) { }
        private System.Void Drag_SetDrag(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private System.Boolean get_DistanceDisable_Active() { }
        private System.Void set_DistanceDisable_Active(System.Boolean value) { }
        private UnityEngine.Transform get_DistanceDisable_ReferenceObject() { }
        private System.Void set_DistanceDisable_ReferenceObject(UnityEngine.Transform value) { }
        private System.Single get_DistanceDisable_Distance() { }
        private System.Void set_DistanceDisable_Distance(System.Single value) { }
        private System.Single get_DistanceDisable_FadeDistance() { }
        private System.Void set_DistanceDisable_FadeDistance(System.Single value) { }
        private System.Void ExternalForce_DepthInfluence(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private System.Single get_ExternalForce_WindInfluence() { }
        private System.Void set_ExternalForce_WindInfluence(System.Single value) { }
        private System.Single get_ExternalForce_WindRandomScale() { }
        private System.Void set_ExternalForce_WindRandomScale(System.Single value) { }
        private System.Void WorldInfluence_SetMovementInfluence(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private System.Void WorldInfluence_SetRotationInfluence(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private System.Single get_WorldInfluence_MaxMoveSpeed() { }
        private System.Void set_WorldInfluence_MaxMoveSpeed(System.Single value) { }
        private System.Boolean get_WorldInfluence_ResetAfterTeleport() { }
        private System.Void set_WorldInfluence_ResetAfterTeleport(System.Boolean value) { }
        private System.Single get_WorldInfluence_TeleportDistance() { }
        private System.Void set_WorldInfluence_TeleportDistance(System.Single value) { }
        private System.Single get_WorldInfluence_TeleportRotation() { }
        private System.Void set_WorldInfluence_TeleportRotation(System.Single value) { }
        private MagicaCloth.ClothParams.TeleportMode get_WorldInfluence_TeleportMode() { }
        private System.Void set_WorldInfluence_TeleportMode(MagicaCloth.ClothParams.TeleportMode value) { }
        private System.Single get_WorldInfluence_StabilizationTime() { }
        private System.Void set_WorldInfluence_StabilizationTime(System.Single value) { }
        private System.Void WorldInfluence_ReplaceInfluenceTarget(UnityEngine.Transform target) { }
        private System.Boolean get_ColliderCollision_Active() { }
        private System.Void set_ColliderCollision_Active(System.Boolean value) { }
        private System.Boolean get_Penetration_Active() { }
        private System.Void set_Penetration_Active(System.Boolean value) { }
        private System.Void Penetration_SetMovingRadius(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private System.Boolean get_Spring_Active() { }
        private System.Void set_Spring_Active(System.Boolean value) { }
        private System.Single get_Spring_Power() { }
        private System.Void set_Spring_Power(System.Single value) { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.ClothParams get_Params() { }
        private MagicaCloth.ClothData get_ClothData() { }
        private System.Void set_ClothData(MagicaCloth.ClothData value) { }
        private MagicaCloth.SelectionData get_ClothSelection() { }
        private MagicaCloth.ClothSetup get_Setup() { }
        private System.Void Reset() { }
        private System.Void OnValidate() { }
        private System.Void OnInit() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Void OnDispose() { }
        private System.Void UpdateCullingMode(MagicaCloth.CoreComponent caller) { }
        private System.Void OnChangeCalculation() { }
        private System.Int32 GetCullRenderListCount() { }
        private System.Void BaseClothInit() { }
        private System.Void BaseClothDispose() { }
        private System.Void ClothInit() { }
        private System.Void ClothActive() { }
        private System.Void ClothInactive() { }
        private System.Void ClothDispose() { }
        private System.UInt32 UserFlag(System.Int32 vindex) { }
        private UnityEngine.Transform UserTransform(System.Int32 vindex) { }
        private Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        private Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        private System.Boolean IsRequiresDeformer() { }
        private MagicaCloth.BaseMeshDeformer GetDeformer() { }
        private MagicaCloth.MeshData GetMeshData() { }
        private System.Void WorkerInit() { }
        private System.Void SetUseMesh(System.Boolean sw) { }
        private System.Void SetUseVertex(System.Boolean sw) { }
        private System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        private System.Void DeformerForEach(System.Action<MagicaCloth.BaseMeshDeformer> act) { }
        private System.Void UpdateBlend() { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.Boolean HasChangedParam(MagicaCloth.ClothParams.ParamType ptype) { }
        private MagicaCloth.Define.Error VerifyAlgorithmVersion() { }
        private System.Boolean UpgradeFormat() { }
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        private System.Void ResetClothInternal(MagicaCloth.ClothParams.TeleportMode teleportMode, System.Single resetStabilizationTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000027
    public class CoreComponent : BaseComponent, IShareDataObject, IDataVerify, IEditorMesh, IEditorCloth, IDataHash, IBoneReplace
    {
        // Fields
        protected System.Int32 dataHash;        // 0x18
        protected System.Int32 dataVersion;        // 0x1C
        protected MagicaCloth.RuntimeStatus status;        // 0x20
        private System.Int32 useUnityPhysicsCount;        // 0x28
        private System.Boolean nowUseUnityPhysics;        // 0x2C
        private System.Boolean <IsVisible>k__BackingField;        // 0x2D
        protected System.Int32 calculateValue;        // 0x30

        // Methods
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> GetUsedComponentBones() { }
        private System.Collections.Generic.List<System.String> GetUsedComponentBoneNames() { }
        private System.Void ReplaceComponentBone(System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneReplaceDict) { }
        private System.Void ReplaceComponentBone(System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> boneReplaceDict) { }
        private MagicaCloth.RuntimeStatus get_Status() { }
        private System.Boolean get_IsVisible() { }
        private System.Void set_IsVisible(System.Boolean value) { }
        private System.Boolean get_IsCalculate() { }
        private System.Int32 GetDataHash() { }
        private System.Int32 get_SaveDataHash() { }
        private System.Int32 get_SaveDataVersion() { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Init() { }
        private System.Void OnInit() { }
        private System.Void OnDispose() { }
        private System.Void OnUpdate() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Void OnUpdateStatus() { }
        private System.Void OnDisconnectedStatus() { }
        private System.Void SetUseUnityPhysics(System.Boolean sw) { }
        private System.Void ActiveUseUnityPhysics() { }
        private System.Void InactiveUseUnityPhysics() { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Boolean IsUseUnityPhysics() { }
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        private System.Void SetUserEnable(System.Boolean sw) { }
        private System.Void UpdateCullingMode(MagicaCloth.CoreComponent Caller) { }
        private System.Void OnChangeCalculation() { }
        private System.Int32 GetVersion() { }
        private System.Int32 GetErrorVersion() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private MagicaCloth.Define.Error VerifyDataVersion() { }
        private System.Boolean IsOldDataVertion() { }
        private System.Void CreateVerifyData() { }
        private System.String GetInformation() { }
        private System.Boolean UpgradeFormat() { }
        private System.Void ChangeAvatar(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        private System.Collections.Generic.List<System.Int32> GetUseList() { }
        private System.Void .ctor() { }
        private System.Object <Init>b__27_0() { }

    }

    // TypeToken: 0x2000028
    public class AvatarPartsAttachEvent : UnityEvent`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public class AvatarPartsDetachEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002A
    public class PhysicsManagerPreUpdateEvent : UnityEvent
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class PhysicsManagerPostUpdateEvent : UnityEvent
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class MagicaAreaWind : WindComponent
    {
        // Fields
        private MagicaCloth.PhysicsManagerWindData.ShapeType shapeType;        // 0x58
        private System.Boolean isAddition;        // 0x5C

        // Methods
        private MagicaCloth.PhysicsManagerWindData.ShapeType get_ShapeType() { }
        private System.Void set_ShapeType(MagicaCloth.PhysicsManagerWindData.ShapeType value) { }
        private System.Boolean get_Addition() { }
        private System.Void set_Addition(System.Boolean value) { }
        private MagicaCloth.ComponentType GetComponentType() { }
        private MagicaCloth.PhysicsManagerWindData.WindType GetWindType() { }
        private MagicaCloth.PhysicsManagerWindData.ShapeType GetShapeType() { }
        private MagicaCloth.PhysicsManagerWindData.DirectionType GetDirectionType() { }
        private System.Boolean IsAddition() { }
        private UnityEngine.Vector3 GetAreaSize() { }
        private System.Single GetAreaVolume() { }
        private System.Single GetAreaLength() { }
        private System.Void ResetParams() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public class MagicaAvatar : CoreComponent
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        private System.Boolean dataReset;        // 0x38
        private MagicaCloth.MagicaAvatarRuntime runtime;        // 0x40
        public MagicaCloth.AvatarPartsAttachEvent OnAttachParts;        // 0x48
        public MagicaCloth.AvatarPartsDetachEvent OnDetachParts;        // 0x50

        // Methods
        private System.Int32 AttachAvatarParts(UnityEngine.GameObject avatarPartsPrefab, System.Action<UnityEngine.GameObject> instanceAction) { }
        private System.Void DetachAvatarParts(System.Int32 partsId) { }
        private System.Void DetachAvatarParts(UnityEngine.GameObject avatarPartsObject) { }
        private System.Void DetachAvatarParts(MagicaCloth.MagicaAvatarParts parts) { }
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Int32 GetDataHash() { }
        private System.Void set_DataReset(System.Boolean value) { }
        private System.Boolean get_DataReset() { }
        private MagicaCloth.MagicaAvatarRuntime get_Runtime() { }
        private System.Void Reset() { }
        private System.Void OnValidate() { }
        private System.Void OnInit() { }
        private System.Void OnDispose() { }
        private System.Void OnUpdate() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Int32 GetVersion() { }
        private System.Int32 GetErrorVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class MagicaDirectionalWind : WindComponent
    {
        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private MagicaCloth.PhysicsManagerWindData.WindType GetWindType() { }
        private MagicaCloth.PhysicsManagerWindData.ShapeType GetShapeType() { }
        private MagicaCloth.PhysicsManagerWindData.DirectionType GetDirectionType() { }
        private System.Boolean IsAddition() { }
        private UnityEngine.Vector3 GetAreaSize() { }
        private System.Single GetAreaVolume() { }
        private System.Single GetAreaLength() { }
        private System.Void ResetParams() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002F
    public class MagicaPhysicsManager : CreateSingleton`1
    {
        // Fields
        private MagicaCloth.UpdateTimeManager updateTime;        // 0x18
        private MagicaCloth.PhysicsManagerParticleData particle;        // 0x20
        private MagicaCloth.PhysicsManagerBoneData bone;        // 0x28
        private MagicaCloth.PhysicsManagerMeshData mesh;        // 0x30
        private MagicaCloth.PhysicsManagerTeamData team;        // 0x38
        private MagicaCloth.PhysicsManagerWindData wind;        // 0x40
        private MagicaCloth.PhysicsManagerComponent component;        // 0x48
        private MagicaCloth.PhysicsManagerCompute compute;        // 0x50
        private System.Boolean useFasterWrite;        // 0x58
        private UnityEngine.ComputeShader meshWriter;        // 0x60
        public MagicaCloth.PhysicsManagerPreUpdateEvent OnPreUpdate;        // 0x68
        public MagicaCloth.PhysicsManagerPostUpdateEvent OnPostUpdate;        // 0x70
        private System.Boolean useDelay;        // 0x78
        private System.Boolean updatePlayerLoop;        // 0x79
        private System.Boolean isActive;        // 0x7A

        // Methods
        private MagicaCloth.UpdateTimeManager.UpdateCount get_UpdatePerSeccond() { }
        private System.Void set_UpdatePerSeccond(MagicaCloth.UpdateTimeManager.UpdateCount value) { }
        private MagicaCloth.UpdateTimeManager.UpdateMode get_UpdateMode() { }
        private System.Void set_UpdateMode(MagicaCloth.UpdateTimeManager.UpdateMode value) { }
        private System.Void SetGlobalTimeScale(System.Single timeScale) { }
        private System.Single GetGlobalTimeScale() { }
        private System.Single get_FuturePredictionRate() { }
        private System.Void set_FuturePredictionRate(System.Single value) { }
        private MagicaCloth.UpdateTimeManager get_UpdateTime() { }
        private MagicaCloth.PhysicsManagerParticleData get_Particle() { }
        private MagicaCloth.PhysicsManagerBoneData get_Bone() { }
        private MagicaCloth.PhysicsManagerMeshData get_Mesh() { }
        private MagicaCloth.PhysicsManagerTeamData get_Team() { }
        private MagicaCloth.PhysicsManagerWindData get_Wind() { }
        private MagicaCloth.PhysicsManagerComponent get_Component() { }
        private MagicaCloth.PhysicsManagerCompute get_Compute() { }
        private System.Boolean get_IsDelay() { }
        private System.Boolean get_IsActive() { }
        private System.Void set_IsActive(System.Boolean value) { }
        private System.Boolean get_IsFasterWrite() { }
        private UnityEngine.ComputeShader get_MeshWriterShader() { }
        private System.Void Awake() { }
        private System.Void InitSingleton() { }
        private System.Void DuplicateDetection(MagicaCloth.MagicaPhysicsManager duplicate) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void FixedUpdate() { }
        private System.Void OnDestroy() { }
        private System.Void AfterEarlyUpdate() { }
        private System.Void AfterFixedUpdate() { }
        private System.Void AfterUpdate() { }
        private System.Void BeforeLateUpdate() { }
        private System.Void AfterLateUpdate() { }
        private System.Void DefaultUpdate() { }
        private System.Void PostLateUpdate() { }
        private System.Void AfterRendering() { }
        private System.Void Init() { }
        private System.Void InitCustomGameLoop() { }
        private System.Void SetCustomGameLoop(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop) { }
        private System.Boolean CheckRegist(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class WindComponent : BaseComponent
    {
        // Fields
        protected System.Single main;        // 0x18
        protected System.Single turbulence;        // 0x1C
        protected System.Single frequency;        // 0x20
        protected UnityEngine.Vector3 areaSize;        // 0x24
        protected System.Single areaRadius;        // 0x30
        protected System.Single directionAngleX;        // 0x34
        protected System.Single directionAngleY;        // 0x38
        protected MagicaCloth.PhysicsManagerWindData.DirectionType directionType;        // 0x3C
        protected MagicaCloth.BezierParam attenuation;        // 0x40
        protected System.Int32 windId;        // 0x48
        protected MagicaCloth.RuntimeStatus status;        // 0x50

        // Methods
        private System.Single get_Main() { }
        private System.Void set_Main(System.Single value) { }
        private System.Single get_Turbulence() { }
        private System.Void set_Turbulence(System.Single value) { }
        private System.Single get_Frequency() { }
        private System.Void set_Frequency(System.Single value) { }
        private UnityEngine.Vector3 get_MainDirection() { }
        private System.Void set_MainDirection(UnityEngine.Vector3 value) { }
        private System.Single get_DirectionAngleX() { }
        private System.Void set_DirectionAngleX(System.Single value) { }
        private System.Single get_DirectionAngleY() { }
        private System.Void set_DirectionAngleY(System.Single value) { }
        private UnityEngine.Vector3 get_AreaSize() { }
        private System.Void set_AreaSize(UnityEngine.Vector3 value) { }
        private System.Single get_AreaRadius() { }
        private System.Void set_AreaRadius(System.Single value) { }
        private MagicaCloth.PhysicsManagerWindData.DirectionType get_DirectionType() { }
        private System.Void set_DirectionType(MagicaCloth.PhysicsManagerWindData.DirectionType value) { }
        private System.Void SetAttenuation(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval) { }
        private MagicaCloth.RuntimeStatus get_Status() { }
        private System.Void Reset() { }
        private System.Void OnValidate() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Update() { }
        private System.Void Init() { }
        private System.Void OnUpdateStatus() { }
        private System.Boolean VerifyData() { }
        private System.Void OnInit() { }
        private System.Void OnDispose() { }
        private System.Void OnUpdate() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Void EnableWind() { }
        private System.Void DisableWind() { }
        private System.Void RemoveWind() { }
        private System.Void CreateWind() { }
        private UnityEngine.Vector3 GetLocalDirection() { }
        private System.Void ChangeParameter() { }
        private MagicaCloth.PhysicsManagerWindData.WindType GetWindType() { }
        private MagicaCloth.PhysicsManagerWindData.ShapeType GetShapeType() { }
        private MagicaCloth.PhysicsManagerWindData.DirectionType GetDirectionType() { }
        private System.Boolean IsAddition() { }
        private UnityEngine.Vector3 GetAreaSize() { }
        private System.Single GetAreaVolume() { }
        private System.Single GetAreaLength() { }
        private System.Void ResetParams() { }
        private System.Void .ctor() { }
        private System.Object <Init>b__49_0() { }

    }

    // TypeToken: 0x2000033
    public class MagicaAvatarAccess, IDisposable
    {
        // Fields
        protected MagicaCloth.MagicaAvatar owner;        // 0x10

        // Methods
        private MagicaCloth.MagicaAvatarRuntime get_Runtime() { }
        private System.Void SetParent(MagicaCloth.MagicaAvatar avatar) { }
        private System.Void Create() { }
        private System.Void Dispose() { }
        private System.Void Active() { }
        private System.Void Inactive() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class MagicaAvatarParts : BaseComponent, IDataVerify
    {
        // Fields
        private MagicaCloth.MagicaAvatar parentAvatar;        // 0x18
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> boneDict;        // 0x20
        private System.Collections.Generic.List<MagicaCloth.CoreComponent> magicaComponentList;        // 0x28

        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private MagicaCloth.MagicaAvatar get_ParentAvatar() { }
        private System.Void set_ParentAvatar(MagicaCloth.MagicaAvatar value) { }
        private System.Boolean get_HasParent() { }
        private System.Int32 get_PartsId() { }
        private System.Void OnDestroy() { }
        private System.Void Dispose() { }
        private System.Collections.Generic.List<UnityEngine.Transform> CheckOverlappingTransform() { }
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> GetBoneDict() { }
        private System.Collections.Generic.List<MagicaCloth.CoreComponent> GetMagicaComponentList() { }
        private System.Int32 GetVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000035
    public class MagicaAvatarRuntime : MagicaAvatarAccess
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> boneDict;        // 0x18
        private System.Collections.Generic.Dictionary<UnityEngine.Transform,System.Int32> boneReferenceDict;        // 0x20
        private System.Collections.Generic.List<MagicaCloth.MagicaAvatarParts> avatarPartsList;        // 0x28
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> colliderList;        // 0x30

        // Methods
        private System.Void Create() { }
        private System.Void Dispose() { }
        private System.Void Active() { }
        private System.Void Inactive() { }
        private System.Int32 get_AvatarPartsCount() { }
        private MagicaCloth.MagicaAvatarParts GetAvatarParts(System.Int32 index) { }
        private System.Void CreateBoneDict() { }
        private System.Void CreateColliderList() { }
        private System.Int32 GetColliderCount() { }
        private System.Collections.Generic.List<UnityEngine.Transform> CheckOverlappingTransform() { }
        private System.Int32 AddAvatarParts(MagicaCloth.MagicaAvatarParts parts) { }
        private System.Void AddBone(UnityEngine.Transform root, UnityEngine.Transform croot, UnityEngine.Transform bone) { }
        private System.Void ReplaceSkinMeshRenderer(UnityEngine.SkinnedMeshRenderer skinRenderer, System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneReplaceDict) { }
        private System.Void ReplaceMagicaComponent(MagicaCloth.CoreComponent comp, System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneReplaceDict) { }
        private System.Void RemoveAvatarParts(MagicaCloth.MagicaAvatarParts parts) { }
        private System.Void RemoveAvatarParts(System.Int32 partsId) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public class BoneClothTarget, IDataHash, IBoneReplace
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Transform> rootList;        // 0x10
        private MagicaCloth.BoneClothTarget.ConnectionMode connection;        // 0x18
        private System.Single sameSurfaceAngle;        // 0x1C
        private System.Int32[] parentIndexList;        // 0x20

        // Methods
        private System.Int32 GetDataHash() { }
        private System.Int32 get_RootCount() { }
        private UnityEngine.Transform GetRoot(System.Int32 index) { }
        private System.Int32 GetRootIndex(UnityEngine.Transform root) { }
        private System.Void AddParentTransform() { }
        private System.Void RemoveParentTransform() { }
        private System.Void ResetFuturePredictionParentTransform() { }
        private System.Void ChangeUnityPhysicsCount(System.Boolean sw) { }
        private MagicaCloth.BoneClothTarget.ConnectionMode get_Connection() { }
        private System.Single get_SameSurfaceAngle() { }
        private System.Boolean get_IsMeshConnection() { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class ClothData : ShareDataObject
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        public static System.UInt32 VertexFlag_End;        // 0x0
        public static System.UInt32 VertexFlag_TriangleRotation;        // 0x0
        public MagicaCloth.ClothParams.Algorithm triangleBendAlgorithm;        // 0x20
        public MagicaCloth.ClothParams.Algorithm restoreRotationAlgorithm;        // 0x24
        public MagicaCloth.ClothParams.Algorithm clampRotationAlgorithm;        // 0x28
        public System.Collections.Generic.List<System.Int32> useVertexList;        // 0x30
        public System.Collections.Generic.List<System.Int32> selectionData;        // 0x38
        public System.UInt32 maxLevel;        // 0x40
        public System.Collections.Generic.List<System.UInt32> vertexFlagLevelList;        // 0x48
        public System.Collections.Generic.List<System.Single> vertexDepthList;        // 0x50
        public System.Collections.Generic.List<System.Int32> rootList;        // 0x58
        public System.Collections.Generic.List<System.Int32> parentList;        // 0x60
        public MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] structDistanceDataList;        // 0x68
        public MagicaCloth.ReferenceDataIndex[] structDistanceReferenceList;        // 0x70
        public MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] bendDistanceDataList;        // 0x78
        public MagicaCloth.ReferenceDataIndex[] bendDistanceReferenceList;        // 0x80
        public MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] nearDistanceDataList;        // 0x88
        public MagicaCloth.ReferenceDataIndex[] nearDistanceReferenceList;        // 0x90
        public MagicaCloth.ClampDistanceConstraint.ClampDistanceData[] rootDistanceDataList;        // 0x98
        public MagicaCloth.ReferenceDataIndex[] rootDistanceReferenceList;        // 0xA0
        public MagicaCloth.ClampDistance2Constraint.ClampDistance2Data[] clampDistance2DataList;        // 0xA8
        public MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo[] clampDistance2RootInfoList;        // 0xB0
        public MagicaCloth.RestoreRotationConstraint.RotationData[] restoreRotationDataList;        // 0xB8
        public MagicaCloth.ReferenceDataIndex[] restoreRotationReferenceList;        // 0xC0
        public MagicaCloth.ClampRotationConstraint.ClampRotationData[] clampRotationDataList;        // 0xC8
        public MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo[] clampRotationRootInfoList;        // 0xD0
        public MagicaCloth.CompositeRotationConstraint.RotationData[] compositeRotationDataList;        // 0xD8
        public MagicaCloth.CompositeRotationConstraint.RootInfo[] compositeRotationRootInfoList;        // 0xE0
        public MagicaCloth.TwistConstraint.TwistData[] twistDataList;        // 0xE8
        public MagicaCloth.ReferenceDataIndex[] twistReferenceList;        // 0xF0
        public MagicaCloth.AdjustRotationWorker.AdjustRotationData[] adjustRotationDataList;        // 0xF8
        public MagicaCloth.TriangleBendConstraint.TriangleBendData[] triangleBendDataList;        // 0x100
        public MagicaCloth.ReferenceDataIndex[] triangleBendReferenceList;        // 0x108
        public System.Int32 triangleBendWriteBufferCount;        // 0x110
        public MagicaCloth.VolumeConstraint.VolumeData[] volumeDataList;        // 0x118
        public MagicaCloth.ReferenceDataIndex[] volumeReferenceList;        // 0x120
        public System.Int32 volumeWriteBufferCount;        // 0x128
        public MagicaCloth.LineWorker.LineRotationData[] lineRotationDataList;        // 0x130
        public MagicaCloth.LineWorker.LineRotationRootInfo[] lineRotationRootInfoList;        // 0x138
        public MagicaCloth.TriangleWorker.TriangleRotationData[] triangleRotationDataList;        // 0x140
        public System.Int32[] triangleRotationIndexList;        // 0x148
        public MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData[] edgeCollisionDataList;        // 0x150
        public MagicaCloth.ReferenceDataIndex[] edgeCollisionReferenceList;        // 0x158
        public System.Int32 edgeCollisionWriteBufferCount;        // 0x160
        public MagicaCloth.PenetrationConstraint.PenetrationData[] penetrationDataList;        // 0x168
        public MagicaCloth.ReferenceDataIndex[] penetrationReferenceList;        // 0x170
        public Unity.Mathematics.float3[] penetrationDirectionDataList;        // 0x178
        public MagicaCloth.ClothParams.PenetrationMode penetrationMode;        // 0x180
        public MagicaCloth.BaseSkinningWorker.BaseSkinningData[] baseSkinningDataList;        // 0x188
        public Unity.Mathematics.float4x4[] baseSkinningBindPoseList;        // 0x190
        public UnityEngine.Vector3 initScale;        // 0x198

        // Methods
        private System.Int32 GetDataHash() { }
        private System.Int32 get_VertexUseCount() { }
        private System.Int32 get_StructDistanceConstraintCount() { }
        private System.Int32 get_BendDistanceConstraintCount() { }
        private System.Int32 get_NearDistanceConstraintCount() { }
        private System.Int32 get_ClampDistanceConstraintCount() { }
        private System.Int32 get_ClampDistance2ConstraintCount() { }
        private System.Int32 get_RestoreRotationConstraintCount() { }
        private System.Int32 get_ClampRotationConstraintDataCount() { }
        private System.Int32 get_ClampRotationConstraintRootCount() { }
        private System.Int32 get_AdjustRotationConstraintCount() { }
        private System.Int32 get_CompositeRotationCount() { }
        private System.Int32 get_TwistConstraintCount() { }
        private System.Int32 get_TriangleBendConstraintCount() { }
        private System.Int32 get_EdgeCollisionConstraintCount() { }
        private System.Int32 get_VolumeConstraintCount() { }
        private System.Int32 get_LineRotationWorkerCount() { }
        private System.Int32 get_TriangleRotationWorkerCount() { }
        private System.Int32 get_PenetrationCount() { }
        private System.Int32 get_BaseSkinningCount() { }
        private System.Int32 GetClampRotationCount() { }
        private System.Int32 GetRestoreRotationCount() { }
        private System.Boolean IsInvalidVertex(System.Int32 vindex) { }
        private System.Boolean IsFixedVertex(System.Int32 vindex) { }
        private System.Boolean IsMoveVertex(System.Int32 vindex) { }
        private System.Boolean IsExtendVertex(System.Int32 vindex) { }
        private System.Boolean IsLastLevel(System.Int32 vindex) { }
        private System.Boolean IsFlag(System.Int32 vindex, System.UInt32 flag) { }
        private System.Void SetFlag(System.Int32 vindex, System.UInt32 flag) { }
        private System.Int32 GetLevel(System.Int32 vindex) { }
        private System.Int32 GetVersion() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.Void CreateData(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams clothParams, MagicaCloth.PhysicsTeamData teamData, MagicaCloth.MeshData meshData, MagicaCloth.IEditorMesh editMesh, System.Collections.Generic.List<System.Int32> selData, System.Action<System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<UnityEngine.Vector3>,System.Collections.Generic.List<UnityEngine.Vector3>,System.Collections.Generic.List<UnityEngine.Vector3>,System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.Int32>> extensionAction) { }
        private System.Void CreateVertexData(System.Int32 vertexCount, System.Collections.Generic.List<System.Int32> lineList, System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Void CreateConstraintData(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams clothParams, MagicaCloth.PhysicsTeamData teamData, System.Int32 vertexCount, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Collections.Generic.List<UnityEngine.Vector3> wnorList, System.Collections.Generic.List<UnityEngine.Vector3> wtanList, System.Collections.Generic.List<System.Int32> lineList, System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Void RegistTriangleBend(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Collections.Generic.List<UnityEngine.Vector3> wposList, MagicaCloth.ClothParams clothParams, System.Collections.Generic.List<MagicaCloth.TriangleBendConstraint.TriangleBendData> triangleBendData) { }
        private System.Collections.Generic.List<System.Int32> SortTetra(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Collections.Generic.List<System.Single> meshVertexDepthList) { }
        private System.Collections.Generic.List<System.Int32> CheckTetraDirection(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Collections.Generic.HashSet<System.UInt64> trianglePackSet, System.Collections.Generic.List<System.Single> meshVertexDepthList) { }
        private System.Boolean CalcTriangleBendRestAngle(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, System.Single& restAngle) { }
        private System.Collections.Generic.List<System.Single> GetMeshVertexDepthList(System.Int32 vertexCount, System.Collections.Generic.List<System.Single> depthList) { }
        private System.Collections.Generic.List<System.Int32> GetUseParentVertexList(System.Int32 vertexCount, System.Collections.Generic.List<System.Collections.Generic.HashSet<System.Int32>> vlink, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Collections.Generic.List<System.Single> depthList) { }
        private System.Collections.Generic.List<System.Int32> GetUseRootVertexList(System.Collections.Generic.List<System.Int32> parentVertexList) { }
        private System.Collections.Generic.List<MagicaCloth.ClothData.VertexInfo> GetUseVertexInfoList(System.Collections.Generic.List<System.Int32> parentVertexList) { }
        private System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> GetUseRootLineList(System.Collections.Generic.List<System.Int32> parentVertexList) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public class ClothParams
    {
        // Fields
        private MagicaCloth.ClothParams.Algorithm algorithm;        // 0x10
        private MagicaCloth.BezierParam radius;        // 0x18
        private MagicaCloth.BezierParam mass;        // 0x20
        private System.Boolean useGravity;        // 0x28
        private MagicaCloth.BezierParam gravity;        // 0x30
        private UnityEngine.Vector3 gravityDirection;        // 0x38
        private System.Boolean useDrag;        // 0x44
        private MagicaCloth.BezierParam drag;        // 0x48
        private System.Boolean useMaxVelocity;        // 0x50
        private MagicaCloth.BezierParam maxVelocity;        // 0x58
        private UnityEngine.Transform influenceTarget;        // 0x60
        private System.Single maxMoveSpeed;        // 0x68
        private System.Single maxRotationSpeed;        // 0x6C
        private MagicaCloth.BezierParam worldMoveInfluence;        // 0x70
        private MagicaCloth.BezierParam worldRotationInfluence;        // 0x78
        private System.Single massInfluence;        // 0x80
        private MagicaCloth.BezierParam depthInfluence;        // 0x88
        private System.Single windInfluence;        // 0x90
        private System.Single windRandomScale;        // 0x94
        private System.Single windSynchronization;        // 0x98
        private System.Boolean useDistanceDisable;        // 0x9C
        private UnityEngine.Transform disableReferenceObject;        // 0xA0
        private System.Single disableDistance;        // 0xA8
        private System.Single disableFadeDistance;        // 0xAC
        private System.Boolean useResetTeleport;        // 0xB0
        private System.Single teleportDistance;        // 0xB4
        private System.Single teleportRotation;        // 0xB8
        private MagicaCloth.ClothParams.TeleportMode teleportMode;        // 0xBC
        private System.Single resetStabilizationTime;        // 0xC0
        private System.Boolean useClampDistanceRatio;        // 0xC4
        private System.Single clampDistanceMinRatio;        // 0xC8
        private System.Single clampDistanceMaxRatio;        // 0xCC
        private System.Single clampDistanceVelocityInfluence;        // 0xD0
        private System.Boolean useClampPositionLength;        // 0xD4
        private MagicaCloth.BezierParam clampPositionLength;        // 0xD8
        private System.Single clampPositionRatioX;        // 0xE0
        private System.Single clampPositionRatioY;        // 0xE4
        private System.Single clampPositionRatioZ;        // 0xE8
        private System.Single clampPositionVelocityInfluence;        // 0xEC
        private System.Boolean useClampRotation;        // 0xF0
        private MagicaCloth.BezierParam clampRotationAngle;        // 0xF8
        private MagicaCloth.BezierParam clampRotationAngle2;        // 0x100
        private System.Single clampRotationVelocityLimit;        // 0x108
        private System.Single clampRotationVelocityInfluence;        // 0x10C
        private System.Single restoreDistanceVelocityInfluence;        // 0x110
        private MagicaCloth.BezierParam structDistanceStiffness;        // 0x118
        private System.Boolean useBendDistance;        // 0x120
        private System.Int32 bendDistanceMaxCount;        // 0x124
        private MagicaCloth.BezierParam bendDistanceStiffness;        // 0x128
        private System.Boolean useNearDistance;        // 0x130
        private System.Int32 nearDistanceMaxCount;        // 0x134
        private System.Single nearDistanceMaxDepth;        // 0x138
        private MagicaCloth.BezierParam nearDistanceLength;        // 0x140
        private MagicaCloth.BezierParam nearDistanceStiffness;        // 0x148
        private System.Boolean useRestoreRotation;        // 0x150
        private MagicaCloth.BezierParam restoreRotation;        // 0x158
        private MagicaCloth.BezierParam restoreRotation2;        // 0x160
        private System.Single restoreRotationVelocityInfluence;        // 0x168
        private System.Single restoreRotationVelocityInfluence2;        // 0x16C
        private System.Boolean useSpring;        // 0x170
        private System.Single springPower;        // 0x174
        private System.Single springRadius;        // 0x178
        private System.Single springScaleX;        // 0x17C
        private System.Single springScaleY;        // 0x180
        private System.Single springScaleZ;        // 0x184
        private System.Single springIntensity;        // 0x188
        private MagicaCloth.BezierParam springDirectionAtten;        // 0x190
        private MagicaCloth.BezierParam springDistanceAtten;        // 0x198
        private MagicaCloth.ClothParams.AdjustMode adjustMode;        // 0x1A0
        private System.Single adjustRotationPower;        // 0x1A4
        private System.Boolean useTriangleBend;        // 0x1A8
        private MagicaCloth.BezierParam triangleBend;        // 0x1B0
        private MagicaCloth.BezierParam triangleBend2;        // 0x1B8
        private System.Boolean useTwistCorrection;        // 0x1C0
        private System.Single twistRecoveryPower;        // 0x1C4
        private System.Boolean useVolume;        // 0x1C8
        private System.Single maxVolumeLength;        // 0x1CC
        private MagicaCloth.BezierParam volumeStretchStiffness;        // 0x1D0
        private MagicaCloth.BezierParam volumeShearStiffness;        // 0x1D8
        private System.Boolean useCollision;        // 0x1E0
        private System.Single friction;        // 0x1E4
        private System.Single staticFriction;        // 0x1E8
        private System.Boolean usePenetration;        // 0x1EC
        private MagicaCloth.ClothParams.PenetrationMode penetrationMode;        // 0x1F0
        private MagicaCloth.ClothParams.PenetrationAxis penetrationAxis;        // 0x1F4
        private System.Single penetrationMaxDepth;        // 0x1F8
        private MagicaCloth.BezierParam penetrationConnectDistance;        // 0x200
        private MagicaCloth.BezierParam penetrationDistance;        // 0x208
        private MagicaCloth.BezierParam penetrationRadius;        // 0x210
        private System.Boolean useLineAvarageRotation;        // 0x218
        private System.Boolean useFixedNonRotation;        // 0x219
        private System.Collections.Generic.HashSet<MagicaCloth.ClothParams.ParamType> changeSet;        // 0x220

        // Methods
        private System.Void SetChangeParam(MagicaCloth.ClothParams.ParamType ptype) { }
        private System.Boolean ChangedParam(MagicaCloth.ClothParams.ParamType ptype) { }
        private System.Void ClearChangeParam() { }
        private System.Int32 GetParamHash(MagicaCloth.BaseCloth cloth, MagicaCloth.ClothParams.ParamType ptype) { }
        private MagicaCloth.ClothParams.Algorithm get_AlgorithmType() { }
        private System.Void set_AlgorithmType(MagicaCloth.ClothParams.Algorithm value) { }
        private System.Void SetRadius(System.Single sval, System.Single eval) { }
        private System.Single GetRadius(System.Single depth) { }
        private MagicaCloth.BezierParam GetRadius() { }
        private System.Void SetMass(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval) { }
        private MagicaCloth.BezierParam GetMass() { }
        private System.Void SetGravity(System.Boolean sw, System.Single sval, System.Single eval) { }
        private System.Boolean get_UseGravity() { }
        private MagicaCloth.BezierParam GetGravity() { }
        private UnityEngine.Vector3 get_GravityDirection() { }
        private System.Void set_GravityDirection(UnityEngine.Vector3 value) { }
        private System.Void SetDrag(System.Boolean sw, System.Single sval, System.Single eval) { }
        private System.Boolean get_UseDrag() { }
        private MagicaCloth.BezierParam GetDrag() { }
        private System.Void SetMaxVelocity(System.Boolean sw, System.Single sval, System.Single eval) { }
        private System.Boolean get_UseMaxVelocity() { }
        private MagicaCloth.BezierParam GetMaxVelocity() { }
        private System.Void SetExternalForce(System.Single massInfluence, System.Single windInfluence, System.Single windRandomScale, System.Single windSynchronization) { }
        private System.Single get_MassInfluence() { }
        private System.Void set_MassInfluence(System.Single value) { }
        private MagicaCloth.BezierParam GetDepthInfluence() { }
        private System.Single get_WindInfluence() { }
        private System.Void set_WindInfluence(System.Single value) { }
        private System.Single get_WindRandomScale() { }
        private System.Void set_WindRandomScale(System.Single value) { }
        private System.Single get_WindSynchronization() { }
        private System.Void set_WindSynchronization(System.Single value) { }
        private System.Void SetWorldInfluence(System.Single maxspeed, System.Single moveval, System.Single rotval) { }
        private MagicaCloth.BezierParam GetWorldMoveInfluence() { }
        private MagicaCloth.BezierParam GetWorldRotationInfluence() { }
        private UnityEngine.Transform GetInfluenceTarget() { }
        private System.Void SetInfluenceTarget(UnityEngine.Transform t) { }
        private System.Single get_MaxMoveSpeed() { }
        private System.Void set_MaxMoveSpeed(System.Single value) { }
        private System.Single get_MaxRotationSpeed() { }
        private System.Void set_MaxRotationSpeed(System.Single value) { }
        private System.Void SetTeleport(System.Boolean sw, System.Single distance, System.Single rotation, MagicaCloth.ClothParams.TeleportMode mode) { }
        private System.Boolean get_UseResetTeleport() { }
        private System.Void set_UseResetTeleport(System.Boolean value) { }
        private System.Single get_TeleportDistance() { }
        private System.Void set_TeleportDistance(System.Single value) { }
        private System.Single get_TeleportRotation() { }
        private System.Void set_TeleportRotation(System.Single value) { }
        private MagicaCloth.ClothParams.TeleportMode get_TeleportResetMode() { }
        private System.Void set_TeleportResetMode(MagicaCloth.ClothParams.TeleportMode value) { }
        private System.Single get_ResetStabilizationTime() { }
        private System.Void set_ResetStabilizationTime(System.Single value) { }
        private System.Void SetDistanceDisable(System.Boolean sw, System.Single distance, System.Single fadeDistance, UnityEngine.Transform referenceObject) { }
        private System.Boolean get_UseDistanceDisable() { }
        private System.Void set_UseDistanceDisable(System.Boolean value) { }
        private UnityEngine.Transform get_DisableReferenceObject() { }
        private System.Void set_DisableReferenceObject(UnityEngine.Transform value) { }
        private System.Single get_DisableDistance() { }
        private System.Void set_DisableDistance(System.Single value) { }
        private System.Single get_DisableFadeDistance() { }
        private System.Void set_DisableFadeDistance(System.Single value) { }
        private System.Void SetClampDistanceRatio(System.Boolean sw, System.Single minval, System.Single maxval, System.Single influence) { }
        private System.Boolean get_UseClampDistanceRatio() { }
        private System.Single get_ClampDistanceMinRatio() { }
        private System.Single get_ClampDistanceMaxRatio() { }
        private System.Single get_ClampDistanceVelocityInfluence() { }
        private System.Void SetClampPositionLength(System.Boolean sw, System.Single sval, System.Single eval, System.Single ratioX, System.Single ratioY, System.Single ratioZ, System.Single influence) { }
        private System.Boolean get_UseClampPositionLength() { }
        private UnityEngine.Vector3 get_ClampPositionAxisRatio() { }
        private MagicaCloth.BezierParam GetClampPositionLength() { }
        private System.Single get_ClampPositionVelocityInfluence() { }
        private System.Void SetClampRotationAngle(System.Boolean sw, System.Single sval, System.Single eval, System.Single influence) { }
        private System.Boolean get_UseClampRotation() { }
        private MagicaCloth.BezierParam GetClampRotationAngle(MagicaCloth.ClothParams.Algorithm algo) { }
        private System.Single get_ClampRotationVelocityInfluence() { }
        private System.Single GetClampRotationVelocityLimit(MagicaCloth.ClothParams.Algorithm algo) { }
        private System.Void SetRestoreDistance(System.Single influence, System.Single structStiffness) { }
        private System.Single get_RestoreDistanceVelocityInfluence() { }
        private MagicaCloth.BezierParam GetStructDistanceStiffness() { }
        private System.Boolean get_UseBendDistance() { }
        private System.Int32 get_BendDistanceMaxCount() { }
        private MagicaCloth.BezierParam GetBendDistanceStiffness() { }
        private System.Boolean get_UseNearDistance() { }
        private System.Int32 get_NearDistanceMaxCount() { }
        private System.Single get_NearDistanceMaxDepth() { }
        private MagicaCloth.BezierParam GetNearDistanceLength() { }
        private MagicaCloth.BezierParam GetNearDistanceStiffness() { }
        private System.Void SetRestoreRotation(System.Boolean sw, System.Single sval, System.Single eval, System.Single influence) { }
        private System.Boolean get_UseRestoreRotation() { }
        private MagicaCloth.BezierParam GetRestoreRotationPower(MagicaCloth.ClothParams.Algorithm algo) { }
        private System.Single GetRestoreRotationVelocityInfluence(MagicaCloth.ClothParams.Algorithm algo) { }
        private System.Void SetSpring(System.Boolean sw, System.Single power, System.Single r, System.Single sclx, System.Single scly, System.Single sclz, System.Single intensity) { }
        private System.Void SetSpringDirectionAtten(System.Single sval, System.Single eval, System.Single cval) { }
        private System.Void SetSpringDistanceAtten(System.Single sval, System.Single eval, System.Single cval) { }
        private System.Boolean get_UseSpring() { }
        private System.Void set_UseSpring(System.Boolean value) { }
        private System.Single GetSpringPower() { }
        private System.Single get_SpringPowr() { }
        private System.Void set_SpringPowr(System.Single value) { }
        private System.Single get_SpringRadius() { }
        private UnityEngine.Vector3 get_SpringRadiusScale() { }
        private System.Single get_SpringIntensity() { }
        private System.Single GetSpringDirectionAtten(System.Single ratio) { }
        private System.Single GetSpringDistanceAtten(System.Single ratio) { }
        private System.Void SetAdjustRotation(MagicaCloth.ClothParams.AdjustMode amode, System.Single power) { }
        private MagicaCloth.ClothParams.AdjustMode get_AdjustRotationMode() { }
        private UnityEngine.Vector3 get_AdjustRotationVector() { }
        private System.Void SetTriangleBend(System.Boolean sw, System.Single sval, System.Single eval) { }
        private System.Boolean get_UseTriangleBend() { }
        private MagicaCloth.BezierParam GetTriangleBendStiffness(MagicaCloth.ClothParams.Algorithm algo) { }
        private System.Boolean GetUseTwistCorrection(MagicaCloth.ClothParams.Algorithm algo) { }
        private System.Single get_TwistRecoveryPower() { }
        private System.Void SetVolume(System.Boolean sw, System.Single maxLength, System.Single stiffness, System.Single shear) { }
        private System.Boolean get_UseVolume() { }
        private System.Single GetMaxVolumeLength() { }
        private MagicaCloth.BezierParam GetVolumeStretchStiffness() { }
        private MagicaCloth.BezierParam GetVolumeShearStiffness() { }
        private System.Void SetCollision(System.Boolean sw, System.Single dynamicFriction, System.Single staticFriction) { }
        private System.Boolean get_UseCollision() { }
        private System.Single get_DynamicFriction() { }
        private System.Single get_StaticFriction() { }
        private System.Boolean get_UsePenetration() { }
        private System.Void set_UsePenetration(System.Boolean value) { }
        private MagicaCloth.ClothParams.PenetrationMode GetPenetrationMode() { }
        private MagicaCloth.ClothParams.PenetrationAxis GetPenetrationAxis() { }
        private System.Single get_PenetrationMaxDepth() { }
        private MagicaCloth.BezierParam GetPenetrationConnectDistance() { }
        private MagicaCloth.BezierParam GetPenetrationRadius() { }
        private MagicaCloth.BezierParam GetPenetrationDistance() { }
        private System.Boolean get_UseLineAvarageRotation() { }
        private System.Boolean get_UseFixedNonRotation() { }
        private System.Void ConvertToLatestAlgorithmParameter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class ClothSetup
    {
        // Fields
        private System.Int32 teamBoneIndex;        // 0x10
        private System.Single distanceBlendRatio;        // 0x14

        // Methods
        private System.Void ClothInit(MagicaCloth.PhysicsTeam team, MagicaCloth.MeshData meshData, MagicaCloth.ClothData clothData, MagicaCloth.ClothParams param, System.Func<System.Int32,System.UInt32> funcUserFlag) { }
        private System.Void ClothDispose(MagicaCloth.PhysicsTeam team) { }
        private System.Void ClothActive(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param, MagicaCloth.ClothData clothData) { }
        private System.Void ClothInactive(MagicaCloth.PhysicsTeam team) { }
        private System.Void ReplaceBone(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param, System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param) { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Single get_DistanceBlendRatio() { }
        private System.Void set_DistanceBlendRatio(System.Single value) { }
        private System.Void ChangeData(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param, MagicaCloth.ClothData clothData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class MagicaBoneCloth : BaseCloth
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        private static System.Int32 ERR_DATA_VERSION;        // 0x0
        private MagicaCloth.MeshData meshData;        // 0xC8
        private System.Int32 meshDataHash;        // 0xD0
        private System.Int32 meshDataVersion;        // 0xD4
        private MagicaCloth.BoneClothTarget clothTarget;        // 0xD8
        private System.Collections.Generic.List<UnityEngine.Transform> useTransformList;        // 0xE0
        private System.Collections.Generic.List<UnityEngine.Vector3> useTransformPositionList;        // 0xE8
        private System.Collections.Generic.List<UnityEngine.Quaternion> useTransformRotationList;        // 0xF0
        private System.Collections.Generic.List<UnityEngine.Vector3> useTransformScaleList;        // 0xF8

        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.BoneClothTarget get_ClothTarget() { }
        private MagicaCloth.MeshData get_MeshData() { }
        private System.Void Reset() { }
        private System.Void OnValidate() { }
        private System.Void ClothInit() { }
        private System.Void ClothDispose() { }
        private System.Void ClothActive() { }
        private System.UInt32 UserFlag(System.Int32 index) { }
        private UnityEngine.Transform UserTransform(System.Int32 index) { }
        private Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        private Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        private MagicaCloth.BaseMeshDeformer GetDeformer() { }
        private MagicaCloth.MeshData GetMeshData() { }
        private System.Void WorkerInit() { }
        private System.Boolean IsRequiresDeformer() { }
        private System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Void OnChangeCalculation() { }
        private System.Collections.Generic.List<UnityEngine.Transform> GetTransformList() { }
        private UnityEngine.Transform GetUseTransform(System.Int32 index) { }
        private System.Int32 get_UseTransformCount() { }
        private System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Transform>>> GetTransformGrid(System.Int32& maxLevel) { }
        private System.Int32 GetVersion() { }
        private System.Int32 GetErrorVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        private System.Collections.Generic.List<System.Int32> GetUseList() { }
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        private System.Void ResetParams() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004C
    public class MagicaBoneSpring : BaseCloth
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        private static System.Int32 ERR_DATA_VERSION;        // 0x0
        private MagicaCloth.MeshData meshData;        // 0xC8
        private System.Int32 meshDataHash;        // 0xD0
        private System.Int32 meshDataVersion;        // 0xD4
        private MagicaCloth.BoneClothTarget clothTarget;        // 0xD8
        private System.Collections.Generic.List<UnityEngine.Transform> useTransformList;        // 0xE0
        private System.Collections.Generic.List<UnityEngine.Vector3> useTransformPositionList;        // 0xE8
        private System.Collections.Generic.List<UnityEngine.Quaternion> useTransformRotationList;        // 0xF0
        private System.Collections.Generic.List<UnityEngine.Vector3> useTransformScaleList;        // 0xF8

        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.BoneClothTarget get_ClothTarget() { }
        private MagicaCloth.MeshData get_MeshData() { }
        private System.Void Reset() { }
        private System.Void OnValidate() { }
        private System.Void ClothInit() { }
        private System.Void ClothDispose() { }
        private System.Void ClothActive() { }
        private System.UInt32 UserFlag(System.Int32 index) { }
        private UnityEngine.Transform UserTransform(System.Int32 index) { }
        private Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        private Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        private System.Boolean IsRequiresDeformer() { }
        private MagicaCloth.BaseMeshDeformer GetDeformer() { }
        private MagicaCloth.MeshData GetMeshData() { }
        private System.Void WorkerInit() { }
        private System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Void OnChangeCalculation() { }
        private System.Collections.Generic.List<UnityEngine.Transform> GetTransformList() { }
        private UnityEngine.Transform GetUseTransform(System.Int32 index) { }
        private System.Int32 get_UseTransformCount() { }
        private System.Int32 GetVersion() { }
        private System.Int32 GetErrorVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        private System.Collections.Generic.List<System.Int32> GetUseList() { }
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        private System.Void ResetParams() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public class MagicaMeshCloth : BaseCloth
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        private static System.Int32 ERR_DATA_VERSION;        // 0x0
        private MagicaCloth.MagicaVirtualDeformer virtualDeformer;        // 0xC8
        private System.Int32 virtualDeformerHash;        // 0xD0
        private System.Int32 virtualDeformerVersion;        // 0xD4

        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.VirtualMeshDeformer get_Deformer() { }
        private System.Void Reset() { }
        private System.Void OnValidate() { }
        private System.Void OnInit() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Void OnDispose() { }
        private System.UInt32 UserFlag(System.Int32 index) { }
        private UnityEngine.Transform UserTransform(System.Int32 index) { }
        private Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        private Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        private System.Boolean IsRequiresDeformer() { }
        private MagicaCloth.BaseMeshDeformer GetDeformer() { }
        private MagicaCloth.MeshData GetMeshData() { }
        private System.Void WorkerInit() { }
        private System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Int32 GetVersion() { }
        private System.Int32 GetErrorVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }
        private System.Boolean IsValidPointSelect() { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        private System.Collections.Generic.List<System.Int32> GetUseList() { }
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        private System.Void ResetParams() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public class MagicaMeshSpring : BaseCloth
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        private static System.Int32 ERR_DATA_VERSION;        // 0x0
        private MagicaCloth.MagicaVirtualDeformer virtualDeformer;        // 0xC8
        private System.Int32 virtualDeformerHash;        // 0xD0
        private System.Int32 virtualDeformerVersion;        // 0xD4
        private UnityEngine.Transform centerTransform;        // 0xD8
        private MagicaCloth.MagicaMeshSpring.Axis directionAxis;        // 0xE0
        private MagicaCloth.SpringData springData;        // 0xE8
        private System.Int32 springDataHash;        // 0xF0
        private System.Int32 springDataVersion;        // 0xF4

        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.VirtualMeshDeformer get_Deformer() { }
        private MagicaCloth.SpringData get_SpringData() { }
        private System.Int32 get_UseVertexCount() { }
        private UnityEngine.Transform get_CenterTransform() { }
        private System.Void set_CenterTransform(UnityEngine.Transform value) { }
        private MagicaCloth.MagicaMeshSpring.Axis get_DirectionAxis() { }
        private System.Void set_DirectionAxis(MagicaCloth.MagicaMeshSpring.Axis value) { }
        private UnityEngine.Vector3 get_CenterTransformDirection() { }
        private MagicaCloth.SpringData.DeformerData GetDeformerData() { }
        private System.Void Reset() { }
        private System.Void OnValidate() { }
        private System.Void ClothInit() { }
        private System.Void ClothActive() { }
        private System.UInt32 UserFlag(System.Int32 index) { }
        private UnityEngine.Transform UserTransform(System.Int32 index) { }
        private Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        private Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        private System.Boolean IsRequiresDeformer() { }
        private MagicaCloth.BaseMeshDeformer GetDeformer() { }
        private MagicaCloth.MeshData GetMeshData() { }
        private System.Void WorkerInit() { }
        private System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Void OnChangeCalculation() { }
        private System.Int32 GetVersion() { }
        private System.Int32 GetErrorVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }
        private System.Void VerifyDeformer() { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        private System.Collections.Generic.List<System.Int32> GetUseList() { }
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        private System.Void ResetParams() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000050
    public class SelectionData : ShareDataObject
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        public static System.Int32 Invalid;        // 0x0
        public static System.Int32 Move;        // 0x0
        public static System.Int32 Fixed;        // 0x0
        public static System.Int32 Extend;        // 0x0
        public System.Collections.Generic.List<MagicaCloth.SelectionData.DeformerSelection> selectionList;        // 0x20

        // Methods
        private System.Int32 get_DeformerCount() { }
        private System.Int32 GetDataHash() { }
        private System.Int32 GetVersion() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.Boolean Compare(MagicaCloth.SelectionData sel) { }
        private System.Collections.Generic.List<System.Int32> GetSelectionData(MagicaCloth.MeshData meshData, System.Collections.Generic.List<MagicaCloth.MeshData> childMeshDataList) { }
        private System.Int32 GetSelection(MagicaCloth.MeshData meshData, System.Int32 vindex, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.UInt32>> dict, System.Collections.Generic.List<MagicaCloth.MeshData> childMeshDataList, System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.UInt64,System.Int32>> hashList) { }
        private System.Void SetSelectionData(MagicaCloth.MeshData meshData, System.Collections.Generic.List<System.Int32> selects, System.Collections.Generic.List<MagicaCloth.MeshData> childMeshDataList) { }
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.UInt64,System.Int32>> GetSelectionVertexHashList() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public class SpringData : ShareDataObject
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        public MagicaCloth.SpringData.DeformerData deformerData;        // 0x20
        public UnityEngine.Vector3 initScale;        // 0x28

        // Methods
        private System.Int32 GetDataHash() { }
        private System.Int32 get_UseVertexCount() { }
        private System.Int32 GetVersion() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000054
    public class Define
    {
        // Methods
        private System.Boolean IsNormal(MagicaCloth.Define.Error err) { }
        private System.Boolean IsError(MagicaCloth.Define.Error err) { }
        private System.Boolean IsWarning(MagicaCloth.Define.Error err) { }
        private System.String GetErrorMessage(MagicaCloth.Define.Error err) { }

    }

    // TypeToken: 0x2000059
    public class BaseMeshDeformer, IEditorMesh, IDataVerify, IDataHash
    {
        // Fields
        private MagicaCloth.MeshData meshData;        // 0x10
        private UnityEngine.GameObject targetObject;        // 0x18
        protected System.Int32 dataHash;        // 0x20
        protected System.Int32 dataVersion;        // 0x24
        protected MagicaCloth.RuntimeStatus status;        // 0x28
        private MagicaCloth.CoreComponent parent;        // 0x30
        private System.Int32 <MeshIndex>k__BackingField;        // 0x38
        private System.Int32 <VertexCount>k__BackingField;        // 0x3C
        private System.Int32 <SkinningVertexCount>k__BackingField;        // 0x40
        private System.Int32 <TriangleCount>k__BackingField;        // 0x44

        // Methods
        private MagicaCloth.CoreComponent get_Parent() { }
        private System.Void set_Parent(MagicaCloth.CoreComponent value) { }
        private MagicaCloth.MeshData get_MeshData() { }
        private System.Void set_MeshData(MagicaCloth.MeshData value) { }
        private UnityEngine.GameObject get_TargetObject() { }
        private System.Void set_TargetObject(UnityEngine.GameObject value) { }
        private MagicaCloth.RuntimeStatus get_Status() { }
        private System.Int32 get_MeshIndex() { }
        private System.Void set_MeshIndex(System.Int32 value) { }
        private System.Int32 get_VertexCount() { }
        private System.Void set_VertexCount(System.Int32 value) { }
        private System.Int32 get_SkinningVertexCount() { }
        private System.Void set_SkinningVertexCount(System.Int32 value) { }
        private System.Int32 get_TriangleCount() { }
        private System.Void set_TriangleCount(System.Int32 value) { }
        private System.Void Init() { }
        private System.Void OnInit() { }
        private System.Void Dispose() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void MeshCalculation(System.Int32 bufferIndex) { }
        private System.Void NormalWriting(System.Int32 bufferIndex) { }
        private System.Void OnUpdateStatus() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Boolean IsMeshUse() { }
        private System.Boolean IsActiveMesh() { }
        private System.Boolean get_IsSkinning() { }
        private System.Int32 get_BoneCount() { }
        private System.Void AddUseMesh(System.Object parent) { }
        private System.Void RemoveUseMesh(System.Object parent) { }
        private System.Boolean AddUseVertex(System.Int32 vindex, System.Boolean fix) { }
        private System.Boolean RemoveUseVertex(System.Int32 vindex, System.Boolean fix) { }
        private System.Void ResetFuturePrediction() { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Int32 GetDataHash() { }
        private System.Int32 get_SaveDataHash() { }
        private System.Int32 get_SaveDataVersion() { }
        private System.Int32 GetVersion() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.Void CreateVerifyData() { }
        private System.String GetInformation() { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Void .ctor() { }
        private System.Object <Init>b__33_0() { }

    }

    // TypeToken: 0x200005A
    public class MagicaRenderDeformer : CoreComponent
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        private static System.Int32 ERR_DATA_VERSION;        // 0x0
        private MagicaCloth.RenderMeshDeformer deformer;        // 0x38
        private System.Int32 deformerHash;        // 0x40
        private System.Int32 deformerVersion;        // 0x44
        private MagicaCloth.PhysicsTeam.TeamCullingMode <cullModeCash>k__BackingField;        // 0x48

        // Methods
        private MagicaCloth.PhysicsTeam.TeamCullingMode get_cullModeCash() { }
        private System.Void set_cullModeCash(MagicaCloth.PhysicsTeam.TeamCullingMode value) { }
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.RenderMeshDeformer get_Deformer() { }
        private System.Void OnValidate() { }
        private System.Void OnInit() { }
        private System.Void OnDispose() { }
        private System.Void OnUpdate() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Void OnBecameVisible() { }
        private System.Void OnBecameInvisible() { }
        private System.Void UpdateCullingMode(MagicaCloth.CoreComponent caller) { }
        private System.Void OnChangeCalculation() { }
        private System.Int32 GetVersion() { }
        private System.Int32 GetErrorVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Collections.Generic.List<System.Int32> GetUseList() { }
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class MagicaVirtualDeformer : CoreComponent
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        private static System.Int32 ERR_DATA_VERSION;        // 0x0
        private MagicaCloth.VirtualMeshDeformer deformer;        // 0x38
        private System.Int32 deformerHash;        // 0x40
        private System.Int32 deformerVersion;        // 0x44
        private MagicaCloth.PhysicsTeam.TeamCullingMode <cullModeCash>k__BackingField;        // 0x48

        // Methods
        private MagicaCloth.PhysicsTeam.TeamCullingMode get_cullModeCash() { }
        private System.Void set_cullModeCash(MagicaCloth.PhysicsTeam.TeamCullingMode value) { }
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.VirtualMeshDeformer get_Deformer() { }
        private System.Void OnValidate() { }
        private System.Void OnInit() { }
        private System.Void OnDispose() { }
        private System.Void OnUpdate() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Void LinkRenderDeformerStatus(System.Boolean sw) { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Void UpdateCullingMode(MagicaCloth.CoreComponent caller) { }
        private System.Void OnChangeCalculation() { }
        private System.Int32 GetVersion() { }
        private System.Int32 GetErrorVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Collections.Generic.List<System.Int32> GetUseList() { }
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class MeshData : ShareDataObject
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        public System.Boolean isSkinning;        // 0x20
        public System.Int32 vertexCount;        // 0x24
        public System.UInt32[] vertexInfoList;        // 0x28
        public MagicaCloth.MeshData.VertexWeight[] vertexWeightList;        // 0x30
        public System.UInt64[] vertexHashList;        // 0x38
        public UnityEngine.Vector2[] uvList;        // 0x40
        public System.Int32 lineCount;        // 0x48
        public System.Int32[] lineList;        // 0x50
        public System.Int32 triangleCount;        // 0x58
        public System.Int32[] triangleList;        // 0x60
        public System.Int32 boneCount;        // 0x68
        public System.UInt32[] vertexToTriangleInfoList;        // 0x70
        public System.Int32[] vertexToTriangleIndexList;        // 0x78
        public System.Collections.Generic.List<MagicaCloth.MeshData.ChildData> childDataList;        // 0x80
        public UnityEngine.Vector3 baseScale;        // 0x88

        // Methods
        private System.Int32 get_VertexCount() { }
        private System.Int32 get_VertexHashCount() { }
        private System.Int32 get_WeightCount() { }
        private System.Int32 get_LineCount() { }
        private System.Int32 get_TriangleCount() { }
        private System.Int32 get_BoneCount() { }
        private System.Int32 get_ChildCount() { }
        private System.Int32 GetDataHash() { }
        private System.Int32 GetVersion() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.UInt32>> GetVirtualToChildVertexDict() { }
        private System.Collections.Generic.List<System.Int32> ExtendSelection(System.Collections.Generic.List<System.Int32> originalSelection, System.Boolean extendNext, System.Boolean extendWeight) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public class RenderMeshDeformer : BaseMeshDeformer, IBoneReplace
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        private MagicaCloth.RenderMeshDeformer.RecalculateMode normalAndTangentUpdateMode;        // 0x48
        private MagicaCloth.RenderMeshDeformer.BoundsMode boundsUpdateMode;        // 0x4C
        private UnityEngine.Mesh sharedMesh;        // 0x50
        private System.Int32 meshOptimize;        // 0x58
        private UnityEngine.Renderer renderer;        // 0x60
        private UnityEngine.MeshFilter meshFilter;        // 0x68
        private UnityEngine.SkinnedMeshRenderer skinMeshRenderer;        // 0x70
        private UnityEngine.Transform[] originalBones;        // 0x78
        private UnityEngine.Transform[] boneList;        // 0x80
        private UnityEngine.Mesh cloneMesh;        // 0x88
        private UnityEngine.GraphicsBuffer vertexBuffer;        // 0x90
        private System.Boolean <IsChangePosition>k__BackingField;        // 0x98
        private System.Boolean <IsChangeNormalTangent>k__BackingField;        // 0x99
        private System.Boolean <IsChangeBoneWeights>k__BackingField;        // 0x9A
        private System.Boolean oldUse;        // 0x9B
        private System.Boolean <IsWriteSkip>k__BackingField;        // 0x9C
        private System.Boolean <IsFasterWriteUpdate>k__BackingField;        // 0x9D
        private System.Boolean <IsWriteMeshPosition>k__BackingField;        // 0x9E
        private System.Boolean <IsWriteMeshBoneWeight>k__BackingField;        // 0x9F
        private System.Boolean IsWriteMeshNormal;        // 0xA0
        private System.Boolean IsWriteMeshTangent;        // 0xA1
        private System.Boolean <IsFasterWrite>k__BackingField;        // 0xA2

        // Methods
        private System.Boolean get_IsChangePosition() { }
        private System.Void set_IsChangePosition(System.Boolean value) { }
        private System.Boolean get_IsChangeNormalTangent() { }
        private System.Void set_IsChangeNormalTangent(System.Boolean value) { }
        private System.Boolean get_IsChangeBoneWeights() { }
        private System.Void set_IsChangeBoneWeights(System.Boolean value) { }
        private System.Boolean get_IsWriteSkip() { }
        private System.Void set_IsWriteSkip(System.Boolean value) { }
        private System.Boolean get_IsFasterWriteUpdate() { }
        private System.Void set_IsFasterWriteUpdate(System.Boolean value) { }
        private System.Boolean get_IsWriteMeshPosition() { }
        private System.Void set_IsWriteMeshPosition(System.Boolean value) { }
        private System.Boolean get_IsWriteMeshBoneWeight() { }
        private System.Void set_IsWriteMeshBoneWeight(System.Boolean value) { }
        private System.Int32 GetDataHash() { }
        private UnityEngine.Mesh get_SharedMesh() { }
        private System.Boolean get_IsFasterWrite() { }
        private System.Void set_IsFasterWrite(System.Boolean value) { }
        private System.Void OnValidate() { }
        private System.Void OnInit() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Void Dispose() { }
        private System.Void SetRecalculateNormalAndTangentMode() { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Void ChangeCalculation(System.Boolean sw) { }
        private System.Boolean IsMeshUse() { }
        private System.Boolean IsActiveMesh() { }
        private System.Void AddUseMesh(System.Object parent) { }
        private System.Void RemoveUseMesh(System.Object parent) { }
        private System.Boolean get_IsRendererVisible() { }
        private System.Boolean get_HasNormal() { }
        private System.Void MeshCalculation(System.Int32 bufferIndex) { }
        private System.Void NormalWriting(System.Int32 bufferIndex) { }
        private System.Boolean FasterWriting(System.Int32 bufferIndex, UnityEngine.ComputeShader compute, System.Int32 kernel, System.Int32 index, System.Int32& maxVertexCount) { }
        private System.Void ChangeNormalTangentUpdateMode() { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorUseList() { }
        private System.Int32 GetVersion() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private UnityEngine.Mesh GetTargetSharedMesh() { }
        private System.String GetInformation() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class VirtualMeshDeformer : BaseMeshDeformer, IBoneReplace
    {
        // Fields
        private static System.Int32 DATA_VERSION;        // 0x0
        private System.Collections.Generic.List<MagicaCloth.MagicaRenderDeformer> renderDeformerList;        // 0x48
        private System.Collections.Generic.List<System.Int32> renderDeformerHashList;        // 0x50
        private System.Int32 renderDeformerVersion;        // 0x58
        private System.Single mergeVertexDistance;        // 0x5C
        private System.Single mergeTriangleDistance;        // 0x60
        private System.Single sameSurfaceAngle;        // 0x64
        private System.Boolean useSkinning;        // 0x68
        private System.Int32 maxWeightCount;        // 0x6C
        private System.Single weightPow;        // 0x70
        private System.Collections.Generic.List<UnityEngine.Transform> boneList;        // 0x78
        private System.Collections.Generic.List<System.Int32> sharedChildMeshIndexList;        // 0x80

        // Methods
        private System.Int32 GetDataHash() { }
        private System.Void OnInit() { }
        private System.Void Dispose() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Void MeshCalculation(System.Int32 bufferIndex) { }
        private System.Void NormalWriting(System.Int32 bufferIndex) { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private MagicaCloth.BaseMeshDeformer GetDeformer() { }
        private System.Single get_MergeVertexDistance() { }
        private System.Single get_MergeTriangleDistance() { }
        private System.Single get_SameSurfaceAngle() { }
        private System.Int32 get_MaxWeightCount() { }
        private System.Single get_WeightPow() { }
        private System.Int32 get_RenderDeformerCount() { }
        private MagicaCloth.MagicaRenderDeformer GetRenderDeformer(System.Int32 index) { }
        private System.Int32 GetRenderMeshDeformerIndex(MagicaCloth.RenderMeshDeformer deformer) { }
        private System.Collections.Generic.List<MagicaCloth.MeshData> GetRenderDeformerMeshList() { }
        private System.Boolean IsMeshUse() { }
        private System.Boolean IsActiveMesh() { }
        private System.Void AddUseMesh(System.Object parent) { }
        private System.Void RemoveUseMesh(System.Object parent) { }
        private System.Boolean AddUseVertex(System.Int32 vindex, System.Boolean fix) { }
        private System.Boolean RemoveUseVertex(System.Int32 vindex, System.Boolean fix) { }
        private System.Void ResetFuturePrediction() { }
        private System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        private System.Void ChangeCalculation(System.Boolean sw) { }
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        private System.Int32 GetVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000064
    public class ClampDistance2Constraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2Data> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo> rootInfoList;        // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.ClampDistance2Constraint.GroupData> groupList;        // 0x30
        private MagicaCloth.FixedChunkNativeArray<System.Int32> rootTeamList;        // 0x38

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence, MagicaCloth.ClampDistance2Constraint.ClampDistance2Data[] dataArray, MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo[] rootInfoArray) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000069
    public class ClampDistanceConstraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampDistanceConstraint.ClampDistanceData> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.ClampDistanceConstraint.GroupData> groupList;        // 0x30

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence, MagicaCloth.ClampDistanceConstraint.ClampDistanceData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006D
    public class ClampPositionConstraint : PhysicsManagerConstraint
    {
        // Fields
        public MagicaCloth.FixedNativeList<MagicaCloth.ClampPositionConstraint.GroupData> groupList;        // 0x20

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam limitLength, Unity.Mathematics.float3 axisRatio, System.Single velocityInfluence) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam limitLength, Unity.Mathematics.float3 axisRatio, System.Single velocityInfluence) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000070
    public class ClampRotationConstraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationData> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo> rootInfoList;        // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.ClampRotationConstraint.GroupData> groupList;        // 0x30
        private MagicaCloth.FixedChunkNativeArray<System.Int32> rootTeamList;        // 0x38
        private MagicaCloth.FixedChunkNativeArray<System.Single> lengthBuffer;        // 0x40

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam maxAngle, System.Single velocityInfluence, MagicaCloth.ClampRotationConstraint.ClampRotationData[] dataArray, MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo[] rootInfoArray) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam maxAngle, System.Single velocityInfluence) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000075
    public class ColliderCollisionConstraint : PhysicsManagerConstraint
    {
        // Methods
        private System.Void Create() { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean useCollision) { }
        private System.Void Release() { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000077
    public class ColliderExtrusionConstraint : PhysicsManagerConstraint
    {
        // Methods
        private System.Void Create() { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void Release() { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000079
    public class CompositeRotationConstraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.CompositeRotationConstraint.RotationData> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.CompositeRotationConstraint.RootInfo> rootInfoList;        // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.CompositeRotationConstraint.GroupData> groupList;        // 0x30
        private MagicaCloth.FixedChunkNativeArray<System.Int32> rootTeamList;        // 0x38
        private MagicaCloth.FixedChunkNativeArray<System.Single> lengthBuffer;        // 0x40

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean useClamp, MagicaCloth.BezierParam maxAngle, System.Boolean useRestore, MagicaCloth.BezierParam restorePower, System.Single velocityInfluence, MagicaCloth.CompositeRotationConstraint.RotationData[] dataArray, MagicaCloth.CompositeRotationConstraint.RootInfo[] rootInfoArray) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean useClamp, MagicaCloth.BezierParam maxAngle, System.Boolean useRestore, MagicaCloth.BezierParam restorePower, System.Single velocityInfluence) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public class EdgeCollisionConstraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<System.Int16> groupIndexList;        // 0x28
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x30
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x38
        private MagicaCloth.FixedNativeList<MagicaCloth.EdgeCollisionConstraint.GroupData> groupList;        // 0x40

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single edgeRadius, MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray, System.Int32 writeBufferCount) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single edgeRadius) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000083
    public class PenetrationConstraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.PenetrationConstraint.PenetrationData> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x28
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> bonePenetrationDataList;        // 0x30
        public MagicaCloth.FixedNativeList<MagicaCloth.PenetrationConstraint.GroupData> groupList;        // 0x38

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.ClothParams.PenetrationMode mode, MagicaCloth.BezierParam distance, MagicaCloth.BezierParam radius, System.Single maxDepth, MagicaCloth.PenetrationConstraint.PenetrationData[] moveLimitDataList, MagicaCloth.ReferenceDataIndex[] refDataArray, Unity.Mathematics.float3[] bonePenetrationDataArray) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam distance, MagicaCloth.BezierParam radius, System.Single maxDepth) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000087
    public class RestoreDistanceConstraint : PhysicsManagerConstraint
    {
        // Fields
        public static System.Int32 StructType;        // 0x0
        public static System.Int32 BendType;        // 0x0
        public static System.Int32 NearType;        // 0x0
        public static System.Int32 TypeCount;        // 0x0
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData>[] dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>[] refDataList;        // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceGroupData> groupList;        // 0x30

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, MagicaCloth.BezierParam mass, System.Single velocityInfluence, MagicaCloth.BezierParam structStiffness, MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] structDataArray, MagicaCloth.ReferenceDataIndex[] structRefDataArray, System.Boolean useBend, MagicaCloth.BezierParam bendStiffness, MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] bendDataArray, MagicaCloth.ReferenceDataIndex[] bendRefDataArray, System.Boolean useNear, MagicaCloth.BezierParam nearStiffness, MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] nearDataArray, MagicaCloth.ReferenceDataIndex[] nearRefDataArray) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, MagicaCloth.BezierParam mass, System.Single velocityInfluence, MagicaCloth.BezierParam structStiffness, System.Boolean useBend, MagicaCloth.BezierParam bendStiffness, System.Boolean useNear, MagicaCloth.BezierParam nearStiffness) { }
        private System.Int32 GetIterationCount() { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008B
    public class RestoreRotationConstraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.RestoreRotationConstraint.RotationData> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.RestoreRotationConstraint.GroupData> groupList;        // 0x30

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam power, System.Single velocityInfluence, MagicaCloth.RestoreRotationConstraint.RotationData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam power, System.Single velocityInfluence) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008F
    public class SpringConstraint : PhysicsManagerConstraint
    {
        // Fields
        public MagicaCloth.FixedNativeList<MagicaCloth.SpringConstraint.GroupData> groupList;        // 0x20

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single spring) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single spring) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000092
    public class TriangleBendConstraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendData> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<System.Int16> groupIndexList;        // 0x28
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x30
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x38
        private MagicaCloth.FixedNativeList<MagicaCloth.TriangleBendConstraint.TriangleBendGroupData> groupList;        // 0x40

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.ClothParams.Algorithm algorithm, MagicaCloth.BezierParam stiffness, MagicaCloth.TriangleBendConstraint.TriangleBendData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray, System.Int32 writeBufferCount) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam stiffness) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public class TwistConstraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.TwistConstraint.TwistData> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.TwistConstraint.GroupData> groupList;        // 0x30

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single recoveryPower, MagicaCloth.TwistConstraint.TwistData[] dataArray, MagicaCloth.ReferenceDataIndex[] refArray) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single recoveryPower) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009B
    public class VolumeConstraint : PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.VolumeConstraint.VolumeData> dataList;        // 0x20
        private MagicaCloth.FixedChunkNativeArray<System.Int16> groupIndexList;        // 0x28
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;        // 0x30
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x38
        private MagicaCloth.FixedNativeList<MagicaCloth.VolumeConstraint.GroupData> groupList;        // 0x40

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam stretchStiffness, MagicaCloth.BezierParam shearStiffness, MagicaCloth.VolumeConstraint.VolumeData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray, System.Int32 writeBufferCount) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam stretchStiffness, MagicaCloth.BezierParam shearStiffness) { }
        private System.Int32 GetIterationCount() { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0
    public struct CurveParam
    {
        // Fields
        public System.Single sval;        // 0x10
        public System.Single eval;        // 0x14
        public System.Single cval;        // 0x18
        public System.Int32 useCurve;        // 0x1C

        // Methods
        private System.Void .ctor(System.Single value) { }
        private System.Void .ctor(System.Single svalue, System.Single evalue) { }
        private System.Void .ctor(MagicaCloth.BezierParam bezier) { }
        private System.Void Setup(MagicaCloth.BezierParam bezier) { }
        private System.Single Evaluate(System.Single t) { }

    }

    // TypeToken: 0x20000A1
    public class BaseComponent : MonoBehaviour
    {
        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A2
    public struct ComponentType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MagicaCloth.ComponentType None;        // 0x0
        public static MagicaCloth.ComponentType SphereCollider;        // 0x0
        public static MagicaCloth.ComponentType CapsuleCollider;        // 0x0
        public static MagicaCloth.ComponentType PlaneCollider;        // 0x0
        public static MagicaCloth.ComponentType DirectionalWind;        // 0x0
        public static MagicaCloth.ComponentType AreaWind;        // 0x0
        public static MagicaCloth.ComponentType RenderDeformer;        // 0x0
        public static MagicaCloth.ComponentType VirtualDeformer;        // 0x0
        public static MagicaCloth.ComponentType BoneCloth;        // 0x0
        public static MagicaCloth.ComponentType BoneSpring;        // 0x0
        public static MagicaCloth.ComponentType MeshCloth;        // 0x0
        public static MagicaCloth.ComponentType MeshSpring;        // 0x0
        public static MagicaCloth.ComponentType Avatar;        // 0x0
        public static MagicaCloth.ComponentType AvatarParts;        // 0x0

    }

    // TypeToken: 0x20000A3
    public class PhysicsManagerAccess, IDisposable
    {
        // Fields
        protected MagicaCloth.MagicaPhysicsManager manager;        // 0x10

        // Methods
        private MagicaCloth.UpdateTimeManager get_UpdateTime() { }
        private MagicaCloth.PhysicsManagerParticleData get_Particle() { }
        private MagicaCloth.PhysicsManagerBoneData get_Bone() { }
        private MagicaCloth.PhysicsManagerMeshData get_Mesh() { }
        private MagicaCloth.PhysicsManagerTeamData get_Team() { }
        private MagicaCloth.PhysicsManagerWindData get_Wind() { }
        private MagicaCloth.PhysicsManagerComponent get_Component() { }
        private MagicaCloth.PhysicsManagerCompute get_Compute() { }
        private System.Void SetParent(MagicaCloth.MagicaPhysicsManager manager) { }
        private System.Void Create() { }
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A4
    public class PhysicsManagerBoneData : PhysicsManagerAccess
    {
        // Fields
        public static System.Byte Flag_Reset;        // 0x0
        public static System.Byte Flag_Restore;        // 0x0
        public static System.Byte Flag_Write;        // 0x0
        public MagicaCloth.FixedTransformAccessArray boneList;        // 0x18
        public MagicaCloth.FixedNativeList<System.Byte> boneFlagList;        // 0x20
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> bonePosList;        // 0x28
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> boneRotList;        // 0x30
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> boneSclList;        // 0x38
        public MagicaCloth.FixedNativeList<System.Int32> boneParentIndexList;        // 0x40
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> basePosList;        // 0x48
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> baseRotList;        // 0x50
        public MagicaCloth.FixedNativeList<System.Int16> boneUnityPhysicsList;        // 0x58
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> futurePosList;        // 0x60
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> futureRotList;        // 0x68
        public MagicaCloth.FixedTransformAccessArray restoreBoneList;        // 0x70
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> restoreBoneLocalPosList;        // 0x78
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> restoreBoneLocalRotList;        // 0x80
        public MagicaCloth.FixedNativeList<System.Int32> restoreBoneIndexList;        // 0x88
        public MagicaCloth.FixedTransformAccessArray writeBoneList;        // 0x90
        public MagicaCloth.FixedNativeList<System.Int32> writeBoneIndexList;        // 0x98
        public MagicaCloth.ExNativeMultiHashMap<System.Int32,System.Int32> writeBoneParticleIndexMap;        // 0xA0
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> boneToWriteIndexDict;        // 0xA8
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> writeBonePosList;        // 0xB0
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> writeBoneRotList;        // 0xB8
        private System.Boolean <hasBoneChanged>k__BackingField;        // 0xC0
        private UnityEngine.Profiling.CustomSampler <SamplerReadBoneScale>k__BackingField;        // 0xC8

        // Methods
        private System.Boolean get_hasBoneChanged() { }
        private System.Void set_hasBoneChanged(System.Boolean value) { }
        private UnityEngine.Profiling.CustomSampler get_SamplerReadBoneScale() { }
        private System.Void set_SamplerReadBoneScale(UnityEngine.Profiling.CustomSampler value) { }
        private System.Void Create() { }
        private System.Void Dispose() { }
        private System.Int32 AddRestoreBone(UnityEngine.Transform target, Unity.Mathematics.float3 lpos, Unity.Mathematics.quaternion lrot, System.Int32 boneIndex) { }
        private System.Void RemoveRestoreBone(System.Int32 restoreBoneIndex) { }
        private System.Int32 get_RestoreBoneCount() { }
        private System.Int32 AddBone(UnityEngine.Transform target, System.Int32 pindex, System.Boolean addParent) { }
        private System.Boolean RemoveBone(System.Int32 boneIndex, System.Int32 pindex) { }
        private System.Void ChangeUnityPhysicsCount(System.Int32 boneIndex, System.Boolean sw) { }
        private System.Void ResetFuturePrediction(System.Int32 boneIndex) { }
        private System.Int32 get_ReadBoneCount() { }
        private System.Int32 get_WriteBoneCount() { }
        private System.Void ResetBoneFromTransform(System.Boolean fixedUpdate) { }
        private System.Void ReadBoneFromTransform() { }
        private System.Void ConvertWorldToLocal() { }
        private System.Void WriteBoneToTransform(System.Int32 bufferIndex) { }
        private System.Void CopyBoneBuffer() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AD
    public class PhysicsManagerComponent : PhysicsManagerAccess
    {
        // Fields
        private readonly System.Collections.Generic.HashSet<MagicaCloth.CoreComponent> componentSet;        // 0x18
        private System.Collections.Generic.HashSet<MagicaCloth.ParticleComponent> dataUpdateParticleSet;        // 0x20

        // Methods
        private System.Void Create() { }
        private System.Void Dispose() { }
        private System.Int32 get_ComponentCount() { }
        private System.Collections.Generic.List<MagicaCloth.CoreComponent> GetComponentList() { }
        private System.Void ComponentAction(System.Action<MagicaCloth.CoreComponent> act) { }
        private System.Void UpdateComponentStatus() { }
        private System.Void AddComponent(MagicaCloth.CoreComponent comp) { }
        private System.Void RemoveComponent(MagicaCloth.CoreComponent comp) { }
        private System.Void ReserveDataUpdateParticleComponent(MagicaCloth.ParticleComponent comp) { }
        private System.Void DataUpdateParticleComponent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AE
    public class PhysicsManagerCompute : PhysicsManagerAccess
    {
        // Fields
        private System.Int32 solverIteration;        // 0x18
        private System.Collections.Generic.List<MagicaCloth.PhysicsManagerConstraint> constraints;        // 0x20
        private MagicaCloth.ClampPositionConstraint <ClampPosition>k__BackingField;        // 0x28
        private MagicaCloth.ClampDistanceConstraint <ClampDistance>k__BackingField;        // 0x30
        private MagicaCloth.ClampRotationConstraint <ClampRotation>k__BackingField;        // 0x38
        private MagicaCloth.SpringConstraint <Spring>k__BackingField;        // 0x40
        private MagicaCloth.RestoreDistanceConstraint <RestoreDistance>k__BackingField;        // 0x48
        private MagicaCloth.RestoreRotationConstraint <RestoreRotation>k__BackingField;        // 0x50
        private MagicaCloth.TriangleBendConstraint <TriangleBend>k__BackingField;        // 0x58
        private MagicaCloth.ColliderCollisionConstraint <Collision>k__BackingField;        // 0x60
        private MagicaCloth.PenetrationConstraint <Penetration>k__BackingField;        // 0x68
        private MagicaCloth.ColliderExtrusionConstraint <ColliderExtrusion>k__BackingField;        // 0x70
        private MagicaCloth.TwistConstraint <Twist>k__BackingField;        // 0x78
        private MagicaCloth.CompositeRotationConstraint <CompositeRotation>k__BackingField;        // 0x80
        private System.Collections.Generic.List<MagicaCloth.PhysicsManagerWorker> workers;        // 0x88
        private MagicaCloth.RenderMeshWorker <RenderMeshWorker>k__BackingField;        // 0x90
        private MagicaCloth.VirtualMeshWorker <VirtualMeshWorker>k__BackingField;        // 0x98
        private MagicaCloth.MeshParticleWorker <MeshParticleWorker>k__BackingField;        // 0xA0
        private MagicaCloth.SpringMeshWorker <SpringMeshWorker>k__BackingField;        // 0xA8
        private MagicaCloth.AdjustRotationWorker <AdjustRotationWorker>k__BackingField;        // 0xB0
        private MagicaCloth.LineWorker <LineWorker>k__BackingField;        // 0xB8
        private MagicaCloth.TriangleWorker <TriangleWorker>k__BackingField;        // 0xC0
        private MagicaCloth.BaseSkinningWorker <BaseSkinningWorker>k__BackingField;        // 0xC8
        private Unity.Jobs.JobHandle jobHandle;        // 0xD0
        private System.Boolean runMasterJob;        // 0xE0
        private System.Int32 swapIndex;        // 0xE4
        private UnityEngine.Profiling.CustomSampler <SamplerCalcMesh>k__BackingField;        // 0xE8
        private UnityEngine.Profiling.CustomSampler <SamplerWriteMesh>k__BackingField;        // 0xF0

        // Methods
        private MagicaCloth.ClampPositionConstraint get_ClampPosition() { }
        private System.Void set_ClampPosition(MagicaCloth.ClampPositionConstraint value) { }
        private MagicaCloth.ClampDistanceConstraint get_ClampDistance() { }
        private System.Void set_ClampDistance(MagicaCloth.ClampDistanceConstraint value) { }
        private MagicaCloth.ClampRotationConstraint get_ClampRotation() { }
        private System.Void set_ClampRotation(MagicaCloth.ClampRotationConstraint value) { }
        private MagicaCloth.SpringConstraint get_Spring() { }
        private System.Void set_Spring(MagicaCloth.SpringConstraint value) { }
        private MagicaCloth.RestoreDistanceConstraint get_RestoreDistance() { }
        private System.Void set_RestoreDistance(MagicaCloth.RestoreDistanceConstraint value) { }
        private MagicaCloth.RestoreRotationConstraint get_RestoreRotation() { }
        private System.Void set_RestoreRotation(MagicaCloth.RestoreRotationConstraint value) { }
        private MagicaCloth.TriangleBendConstraint get_TriangleBend() { }
        private System.Void set_TriangleBend(MagicaCloth.TriangleBendConstraint value) { }
        private MagicaCloth.ColliderCollisionConstraint get_Collision() { }
        private System.Void set_Collision(MagicaCloth.ColliderCollisionConstraint value) { }
        private MagicaCloth.PenetrationConstraint get_Penetration() { }
        private System.Void set_Penetration(MagicaCloth.PenetrationConstraint value) { }
        private MagicaCloth.ColliderExtrusionConstraint get_ColliderExtrusion() { }
        private System.Void set_ColliderExtrusion(MagicaCloth.ColliderExtrusionConstraint value) { }
        private MagicaCloth.TwistConstraint get_Twist() { }
        private System.Void set_Twist(MagicaCloth.TwistConstraint value) { }
        private MagicaCloth.CompositeRotationConstraint get_CompositeRotation() { }
        private System.Void set_CompositeRotation(MagicaCloth.CompositeRotationConstraint value) { }
        private MagicaCloth.RenderMeshWorker get_RenderMeshWorker() { }
        private System.Void set_RenderMeshWorker(MagicaCloth.RenderMeshWorker value) { }
        private MagicaCloth.VirtualMeshWorker get_VirtualMeshWorker() { }
        private System.Void set_VirtualMeshWorker(MagicaCloth.VirtualMeshWorker value) { }
        private MagicaCloth.MeshParticleWorker get_MeshParticleWorker() { }
        private System.Void set_MeshParticleWorker(MagicaCloth.MeshParticleWorker value) { }
        private MagicaCloth.SpringMeshWorker get_SpringMeshWorker() { }
        private System.Void set_SpringMeshWorker(MagicaCloth.SpringMeshWorker value) { }
        private MagicaCloth.AdjustRotationWorker get_AdjustRotationWorker() { }
        private System.Void set_AdjustRotationWorker(MagicaCloth.AdjustRotationWorker value) { }
        private MagicaCloth.LineWorker get_LineWorker() { }
        private System.Void set_LineWorker(MagicaCloth.LineWorker value) { }
        private MagicaCloth.TriangleWorker get_TriangleWorker() { }
        private System.Void set_TriangleWorker(MagicaCloth.TriangleWorker value) { }
        private MagicaCloth.BaseSkinningWorker get_BaseSkinningWorker() { }
        private System.Void set_BaseSkinningWorker(MagicaCloth.BaseSkinningWorker value) { }
        private UnityEngine.Profiling.CustomSampler get_SamplerCalcMesh() { }
        private System.Void set_SamplerCalcMesh(UnityEngine.Profiling.CustomSampler value) { }
        private UnityEngine.Profiling.CustomSampler get_SamplerWriteMesh() { }
        private System.Void set_SamplerWriteMesh(UnityEngine.Profiling.CustomSampler value) { }
        private System.Void Create() { }
        private System.Void Dispose() { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void UpdateRestoreBone(MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode) { }
        private System.Void UpdateReadBone() { }
        private System.Void UpdateTeamAlways() { }
        private System.Void UpdateStartSimulation(MagicaCloth.UpdateTimeManager update) { }
        private System.Void UpdateCompleteSimulation() { }
        private System.Void UpdateWriteBone() { }
        private System.Void MeshCalculation() { }
        private System.Void NormalWritingMesh() { }
        private System.Void UpdateReadWriteBone() { }
        private System.Void UpdateSyncBuffer() { }
        private System.Void UpdateSwapBuffer() { }
        private Unity.Jobs.JobHandle get_MasterJob() { }
        private System.Void set_MasterJob(Unity.Jobs.JobHandle value) { }
        private System.Void InitJob() { }
        private System.Void ScheduleJob() { }
        private System.Void CompleteJob() { }
        private System.Int32 get_SwapIndex() { }
        private System.Void UpdatePhysics(System.Int32 updateCount, System.Int32 runCount, System.Single updatePower, System.Single updateDeltaTime) { }
        private System.Void PostUpdatePhysics(System.Single updateDeltaTime) { }
        private System.Void WarmupWorker() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B2
    public class PhysicsManagerConstraint
    {
        // Fields
        public System.Int32 iteration;        // 0x10
        private MagicaCloth.MagicaPhysicsManager <Manager>k__BackingField;        // 0x18

        // Methods
        private MagicaCloth.MagicaPhysicsManager get_Manager() { }
        private System.Void set_Manager(MagicaCloth.MagicaPhysicsManager value) { }
        private System.Void Init(MagicaCloth.MagicaPhysicsManager manager) { }
        private System.Void Create() { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void Release() { }
        private System.Int32 GetIterationCount() { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3
    public class PhysicsManagerMeshData : PhysicsManagerAccess
    {
        // Fields
        public static System.UInt32 MeshFlag_Active;        // 0x0
        public static System.UInt32 MeshFlag_Skinning;        // 0x0
        public static System.UInt32 Meshflag_CalcNormal;        // 0x0
        public static System.UInt32 Meshflag_CalcTangent;        // 0x0
        public static System.UInt32 Meshflag_Pause;        // 0x0
        public static System.UInt32 MeshFlag_ExistNormals;        // 0x0
        public static System.UInt32 MeshFlag_ExistTangents;        // 0x0
        public static System.UInt32 MeshFlag_ExistWeights;        // 0x0
        public static System.UInt32 MeshFlag_UpdateUseVertexFront;        // 0x0
        public static System.UInt32 MeshFlag_UpdateUseVertexBack;        // 0x0
        public static System.UInt32 MeshFlag_FasterWrite;        // 0x0
        public static System.UInt32 MeshFlag_MeshLink;        // 0x0
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;        // 0x18
        public System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVirtualMeshIdToIndexDict;        // 0x20
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float2> sharedVirtualUvList;        // 0x28
        public MagicaCloth.FixedChunkNativeArray<System.UInt32> sharedVirtualVertexInfoList;        // 0x30
        public MagicaCloth.FixedChunkNativeArray<MagicaCloth.MeshData.VertexWeight> sharedVirtualWeightList;        // 0x38
        public MagicaCloth.FixedChunkNativeArray<System.Int32> sharedVirtualTriangleList;        // 0x40
        public MagicaCloth.FixedChunkNativeArray<System.UInt32> sharedVirtualVertexToTriangleInfoList;        // 0x48
        public MagicaCloth.FixedChunkNativeArray<System.Int32> sharedVirtualVertexToTriangleIndexList;        // 0x50
        public static System.Byte VirtualVertexFlag_Use;        // 0x0
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;        // 0x58
        public MagicaCloth.FixedChunkNativeArray<System.Int16> virtualVertexMeshIndexList;        // 0x60
        public MagicaCloth.FixedChunkNativeArray<System.Byte> virtualVertexUseList;        // 0x68
        public MagicaCloth.FixedChunkNativeArray<System.Byte> virtualVertexFixList;        // 0x70
        public MagicaCloth.FixedChunkNativeArray<System.Byte> virtualVertexFlagList;        // 0x78
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> virtualPosList;        // 0x80
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> virtualRotList;        // 0x88
        public MagicaCloth.FixedChunkNativeArray<System.Int32> virtualTransformIndexList;        // 0x90
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> virtualTriangleNormalList;        // 0x98
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> virtualTriangleTangentList;        // 0xA0
        public MagicaCloth.FixedChunkNativeArray<System.UInt16> virtualTriangleMeshIndexList;        // 0xA8
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.SharedChildMeshInfo> sharedChildMeshInfoList;        // 0xB0
        public System.Collections.Generic.Dictionary<System.Int64,System.Int32> sharedChildMeshIdToSharedVirtualMeshIndexDict;        // 0xB8
        public MagicaCloth.FixedChunkNativeArray<System.UInt32> sharedChildVertexInfoList;        // 0xC0
        public MagicaCloth.FixedChunkNativeArray<MagicaCloth.MeshData.VertexWeight> sharedChildWeightList;        // 0xC8
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.SharedRenderMeshInfo> sharedRenderMeshInfoList;        // 0xD0
        public System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedRenderMeshIdToIndexDict;        // 0xD8
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> sharedRenderVertices;        // 0xE0
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> sharedRenderNormals;        // 0xE8
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float4> sharedRenderTangents;        // 0xF0
        public MagicaCloth.FixedChunkNativeArray<System.Byte> sharedBonesPerVertexList;        // 0xF8
        public MagicaCloth.FixedChunkNativeArray<System.Int32> sharedBonesPerVertexStartList;        // 0x100
        public MagicaCloth.FixedChunkNativeArray<UnityEngine.BoneWeight1> sharedBoneWeightList;        // 0x108
        public static System.UInt32 RenderVertexFlag_Use;        // 0x0
        public static System.Int32 MaxRenderMeshLinkCount;        // 0x0
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;        // 0x110
        public static System.UInt32 RenderStateFlag_Use;        // 0x0
        public static System.UInt32 RenderStateFlag_ExistNormal;        // 0x0
        public static System.UInt32 RenderStateFlag_ExistTangent;        // 0x0
        public static System.UInt32 RenderStateFlag_FasterWrite;        // 0x0
        public static System.UInt32 RenderStateFlag_DelayedCalculated;        // 0x0
        public System.Collections.Generic.Dictionary<System.Int32,MagicaCloth.PhysicsManagerMeshData.RenderMeshState> renderMeshStateDict;        // 0x118
        public MagicaCloth.FixedChunkNativeArray<System.UInt32> renderVertexFlagList;        // 0x120
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> renderPosList;        // 0x128
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> renderNormalList;        // 0x130
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float4> renderTangentList;        // 0x138
        public MagicaCloth.FixedChunkNativeArray<UnityEngine.BoneWeight1> renderBoneWeightList;        // 0x140
        private MagicaCloth.DoubleComputeBuffer<Unity.Mathematics.float3> renderPosBuffer;        // 0x148
        private MagicaCloth.DoubleComputeBuffer<Unity.Mathematics.float3> renderNormalBuffer;        // 0x150
        private UnityEngine.ComputeBuffer emptyByteAddressBuffer;        // 0x158
        private System.Boolean isBeginWrite;        // 0x160
        private System.Collections.Generic.HashSet<MagicaCloth.BaseMeshDeformer> renderMeshSet;        // 0x168
        private System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer> normalWriteList;        // 0x170
        private System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer> fasterWritePositionList;        // 0x178
        private System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer> fasterWritePositionNormalList;        // 0x180

        // Methods
        private System.Void Create() { }
        private System.Void Dispose() { }
        private System.Void AddMesh(MagicaCloth.BaseMeshDeformer bmesh) { }
        private System.Void RemoveMesh(MagicaCloth.BaseMeshDeformer bmesh) { }
        private System.Int32 AddVirtualMesh(System.Int32 uid, System.Int32 vertexCount, System.Int32 weightCount, System.Int32 boneCount, System.Int32 triangleCount, System.Int32 vertexToTriangleIndexCount, UnityEngine.Transform transform) { }
        private System.Boolean IsEmptySharedVirtualMesh(System.Int32 uid) { }
        private System.Void SetSharedVirtualMeshData(System.Int32 virtualMeshIndex, System.UInt32[] sharedVertexInfoList, MagicaCloth.MeshData.VertexWeight[] sharedWeightList, UnityEngine.Vector2[] sharedUv, System.Int32[] sharedTriangles, System.UInt32[] vertexToTriangleInfoList, System.Int32[] vertexToTriangleIndexList) { }
        private System.Void RemoveVirtualMesh(System.Int32 virtualMeshIndex) { }
        private System.Boolean ExistsVirtualMesh(System.Int32 virtualMeshIndex) { }
        private MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo GetVirtualMeshInfo(System.Int32 virtualMeshIndex) { }
        private System.Boolean IsUseVirtualMesh(System.Int32 virtualMeshIndex) { }
        private System.Boolean IsActiveVirtualMesh(System.Int32 virtualMeshIndex) { }
        private System.Void SetVirtualMeshActive(System.Int32 virtualMeshIndex, System.Boolean sw) { }
        private System.Void AddUseVirtualMesh(System.Int32 virtualMeshIndex) { }
        private System.Void RemoveUseVirtualMesh(System.Int32 virtualMeshIndex) { }
        private System.Boolean AddUseVirtualVertex(System.Int32 virtualMeshIndex, System.Int32 vindex, System.Boolean fix) { }
        private System.Boolean RemoveUseVirtualVertex(System.Int32 virtualMeshIndex, System.Int32 vindex, System.Boolean fix) { }
        private System.Void CopyToVirtualMeshWorldData(System.Int32 virtualMeshIndex, UnityEngine.Vector3[] vertices, UnityEngine.Vector3[] normals, UnityEngine.Vector3[] tangents) { }
        private System.Void AddVirtualMeshBone(System.Int32 virtualMeshIndex, System.Collections.Generic.List<UnityEngine.Transform> boneList) { }
        private System.Void RemoveVirtualMeshBone(System.Int32 virtualMeshIndex) { }
        private System.Void ResetFuturePredictionVirtualMeshBone(System.Int32 virtualMeshIndex) { }
        private System.Void ChangeVirtualMeshUseUnityPhysics(System.Int32 virtualMeshIndex, System.Boolean sw) { }
        private System.Void SetVirtualMeshFlag(System.Int32 virtualMeshIndex, System.UInt32 flag, System.Boolean sw) { }
        private System.Int32 get_SharedVirtualMeshCount() { }
        private System.Int32 get_VirtualMeshCount() { }
        private System.Int32 get_VirtualMeshVertexCount() { }
        private System.Int32 get_VirtualMeshTriangleCount() { }
        private System.Int32 get_VirtualMeshVertexUseCount() { }
        private System.Int32 get_VirtualMeshUseCount() { }
        private System.Int32 get_VirtualMeshPauseCount() { }
        private System.Int32 AddSharedChildMesh(System.Int64 cuid, System.Int32 virtualMeshIndex, System.Int32 vertexCount, System.Int32 weightCount) { }
        private System.Boolean IsEmptySharedChildMesh(System.Int64 cuid) { }
        private System.Void SetSharedChildMeshData(System.Int32 sharedMeshIndex, System.UInt32[] sharedVertexInfoList, MagicaCloth.MeshData.VertexWeight[] sharedVertexWeightList) { }
        private System.Void RemoveSharedChildMesh(System.Int32 sharedChildMeshIndex) { }
        private System.Int32 get_SharedRenderMeshCount() { }
        private System.Int32 get_SharedChildMeshCount() { }
        private System.Int32 AddRenderMesh(System.Int32 uid, System.Boolean isSkinning, System.Boolean isFasterWrite, UnityEngine.Vector3 baseScale, System.Int32 vertexCount, System.Int32 rendererBoneIndex, System.Int32 boneWeightCount) { }
        private System.Void UpdateMeshState(System.Int32 renderMeshIndex) { }
        private System.Void AddRenderMeshBone(System.Int32 renderMeshIndex, UnityEngine.Transform rendererTransform) { }
        private System.Boolean IsEmptySharedRenderMesh(System.Int32 uid) { }
        private System.Void SetRenderSharedMeshData(System.Int32 renderMeshIndex, System.Boolean isSkinning, UnityEngine.Vector3[] sharedVertices, UnityEngine.Vector3[] sharedNormals, UnityEngine.Vector4[] sharedTangents, Unity.Collections.NativeArray<System.Byte> sharedBonesPerVertex, Unity.Collections.NativeArray<UnityEngine.BoneWeight1> sharedBoneWeights) { }
        private System.Void RemoveRenderMesh(System.Int32 renderMeshIndex) { }
        private System.Void RemoveRenderMeshBone(System.Int32 renderMeshIndex) { }
        private System.Void ChangeRenderMeshUseUnityPhysics(System.Int32 renderMeshIndex, System.Boolean sw) { }
        private System.Boolean IsUseRenderMesh(System.Int32 renderMeshIndex) { }
        private System.Boolean IsActiveRenderMesh(System.Int32 renderMeshIndex) { }
        private System.Void SetRenderMeshFlag(System.Int32 renderMeshIndex, System.UInt32 flag, System.Boolean sw) { }
        private System.Boolean IsRenderMeshFlag(System.Int32 renderMeshIndex, System.UInt32 flag) { }
        private System.Void SetRenderMeshActive(System.Int32 renderMeshIndex, System.Boolean sw) { }
        private System.Void AddUseRenderMesh(System.Int32 renderMeshIndex) { }
        private System.Void RemoveUseRenderMesh(System.Int32 renderMeshIndex) { }
        private System.Void LinkRenderMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart) { }
        private System.Void UnlinkRenderMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart) { }
        private System.Void CopyToRenderMeshLocalPositionData(System.Int32 renderMeshIndex, UnityEngine.Mesh mesh, System.Int32 bufferIndex) { }
        private System.Void CopyToRenderMeshLocalNormalTangentData(System.Int32 renderMeshIndex, UnityEngine.Mesh mesh, System.Int32 bufferIndex, System.Boolean normal, System.Boolean tangent) { }
        private System.Void CopyToRenderMeshBoneWeightData(System.Int32 renderMeshIndex, UnityEngine.Mesh mesh, UnityEngine.Mesh sharedMesh, System.Int32 bufferIndex) { }
        private System.Void CopyToRenderMeshWorldData(System.Int32 renderMeshIndex, UnityEngine.Transform target, UnityEngine.Vector3[] vertices, UnityEngine.Vector3[] normals, UnityEngine.Vector3[] tangents) { }
        private System.Collections.Generic.List<System.Int32> GetVertexUseList(System.Int32 renderMeshIndex) { }
        private System.Int32 get_RenderMeshCount() { }
        private System.Int32 get_RenderMeshVertexCount() { }
        private System.Int32 get_RenderMeshUseCount() { }
        private System.Int32 get_RenderMeshVertexUseCount() { }
        private System.Int32 get_RenderMeshPauseCount() { }
        private System.Void SetDelayedCalculatedFlag() { }
        private System.Void ClearWritingList() { }
        private System.Void MeshCalculation(System.Int32 bufferIndex) { }
        private System.Void NormalWriting(System.Int32 bufferIndex) { }
        private System.Void CopyToRenderVertexBuffer(System.Int32 renderMeshIndex, System.Int32 bufferIndex, UnityEngine.GraphicsBuffer vertexBuffer, System.Boolean normal, UnityEngine.ComputeShader compute, System.Int32 kernel, System.Int32 index) { }
        private System.Void UpdateVertexBuffer() { }
        private System.Void FinishVertexBuffer() { }
        private System.Void FasterWriting(System.Int32 bufferIndex) { }
        private System.Void DispatchWriting(System.Int32 kernel, System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer> rlist, System.Int32 bufferIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BC
    public class PhysicsManagerParticleData : PhysicsManagerAccess
    {
        // Fields
        public static System.UInt32 Flag_Enable;        // 0x0
        public static System.UInt32 Flag_Kinematic;        // 0x0
        public static System.UInt32 Flag_Hold;        // 0x0
        public static System.UInt32 Flag_Collider;        // 0x0
        public static System.UInt32 Flag_Plane;        // 0x0
        public static System.UInt32 Flag_CapsuleX;        // 0x0
        public static System.UInt32 Flag_CapsuleY;        // 0x0
        public static System.UInt32 Flag_CapsuleZ;        // 0x0
        public static System.UInt32 Flag_Box;        // 0x0
        public static System.UInt32 Flag_TriangleRotation;        // 0x0
        public static System.UInt32 Flag_Transform_Read_Pos;        // 0x0
        public static System.UInt32 Flag_Transform_Read_Rot;        // 0x0
        public static System.UInt32 Flag_Transform_Read_Base;        // 0x0
        public static System.UInt32 Flag_Transform_Read_Local;        // 0x0
        public static System.UInt32 Flag_Transform_Read_Scl;        // 0x0
        public static System.UInt32 Flag_Transform_Write;        // 0x0
        public static System.UInt32 Flag_Transform_Restore;        // 0x0
        public static System.UInt32 Flag_Transform_UnityPhysics;        // 0x0
        public static System.UInt32 Flag_Transform_Parent;        // 0x0
        public static System.UInt32 Flag_Step_Update;        // 0x0
        public static System.UInt32 Flag_Reset_Position;        // 0x0
        public MagicaCloth.FixedChunkNativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;        // 0x18
        public MagicaCloth.FixedChunkNativeArray<System.Int32> teamIdList;        // 0x20
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> posList;        // 0x28
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> rotList;        // 0x30
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> oldPosList;        // 0x38
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> oldRotList;        // 0x40
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> oldSlowPosList;        // 0x48
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> localPosList;        // 0x50
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> basePosList;        // 0x58
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> baseRotList;        // 0x60
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> snapBasePosList;        // 0x68
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> snapBaseRotList;        // 0x70
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> oldBasePosList;        // 0x78
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> oldBaseRotList;        // 0x80
        public MagicaCloth.FixedChunkNativeArray<System.Single> depthList;        // 0x88
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> radiusList;        // 0x90
        public MagicaCloth.FixedChunkNativeArray<System.Int32> restoreTransformIndexList;        // 0x98
        public MagicaCloth.FixedChunkNativeArray<System.Int32> transformIndexList;        // 0xA0
        public MagicaCloth.FixedChunkNativeArray<System.Single> frictionList;        // 0xA8
        public MagicaCloth.FixedChunkNativeArray<System.Single> staticFrictionList;        // 0xB0
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> velocityList;        // 0xB8
        public MagicaCloth.FixedChunkNativeArray<System.Int32> collisionLinkIdList;        // 0xC0
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> collisionNormalList;        // 0xC8
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> nextPos0List;        // 0xD0
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> nextPos1List;        // 0xD8
        private System.Int32 nextPosSwitch;        // 0xE0
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> nextRot0List;        // 0xE8
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> nextRot1List;        // 0xF0
        private System.Int32 nextRotSwitch;        // 0xF8
        private System.Int32 colliderCount;        // 0xFC

        // Methods
        private System.Void Create() { }
        private System.Void Dispose() { }
        private MagicaCloth.ChunkData CreateParticle(System.UInt32 flag, System.Int32 team, Unity.Mathematics.float3 wpos, Unity.Mathematics.quaternion wrot, System.Single depth, Unity.Mathematics.float3 radius, Unity.Mathematics.float3 targetLocalPos) { }
        private MagicaCloth.ChunkData CreateParticle(System.Int32 team, System.Int32 count, System.Func<System.Int32,System.UInt32> funcFlag, System.Func<System.Int32,Unity.Mathematics.float3> funcWpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcWrot, System.Func<System.Int32,System.Single> funcDepth, System.Func<System.Int32,Unity.Mathematics.float3> funcRadius, System.Func<System.Int32,Unity.Mathematics.float3> funcTargetLocalPos) { }
        private System.Void RemoveParticle(MagicaCloth.ChunkData c) { }
        private System.Void SetEnable(MagicaCloth.ChunkData c, System.Boolean sw, System.Func<System.Int32,UnityEngine.Transform> funcTarget, System.Func<System.Int32,Unity.Mathematics.float3> funcLpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcLrot) { }
        private System.Void SetRadius(System.Int32 index, Unity.Mathematics.float3 radius) { }
        private System.Void SetLocalPos(System.Int32 index, UnityEngine.Vector3 lpos) { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Length() { }
        private System.Int32 get_ColliderCount() { }
        private System.Boolean IsValid(System.Int32 index) { }
        private System.Int32 GetTeamId(System.Int32 index) { }
        private System.Void ResetFuturePredictionTransform(System.Int32 index) { }
        private System.Void ResetFuturePredictionTransform(MagicaCloth.ChunkData c) { }
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> get_InNextPosList() { }
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> get_OutNextPosList() { }
        private System.Void SwitchingNextPosList() { }
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> get_InNextRotList() { }
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> get_OutNextRotList() { }
        private System.Void SwitchingNextRotList() { }
        private System.Void UpdateBoneToParticle() { }
        private System.Void UpdateResetParticle() { }
        private System.Boolean UpdateParticleToBone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1
    public class PhysicsManagerTeamData : PhysicsManagerAccess
    {
        // Fields
        public static System.UInt32 Flag_Enable;        // 0x0
        public static System.UInt32 Flag_Interpolate;        // 0x0
        public static System.UInt32 Flag_FixedNonRotation;        // 0x0
        public static System.UInt32 Flag_AnimatedPose;        // 0x0
        public static System.UInt32 Flag_IgnoreClampPositionVelocity;        // 0x0
        public static System.UInt32 Flag_Collision;        // 0x0
        public static System.UInt32 Flag_AfterCollision;        // 0x0
        public static System.UInt32 Flag_UpdatePhysics;        // 0x0
        public static System.UInt32 Flag_Pause;        // 0x0
        public static System.UInt32 Flag_Reset_WorldInfluence;        // 0x0
        public static System.UInt32 Flag_Reset_Position;        // 0x0
        public static System.UInt32 Flag_Reset_Keep;        // 0x0
        public static System.UInt32 Flag_Wind;        // 0x0
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;        // 0x18
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamMassList;        // 0x20
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamGravityList;        // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamDragList;        // 0x30
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamMaxVelocityList;        // 0x38
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamDepthInfluenceList;        // 0x40
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList;        // 0x48
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerTeamData.WindInfo> teamWindInfoList;        // 0x50
        public MagicaCloth.FixedMultiNativeList<System.Int32> colliderList;        // 0x58
        public MagicaCloth.FixedMultiNativeList<System.Int32> skinningBoneList;        // 0x60
        private System.Collections.Generic.Dictionary<System.Int32,MagicaCloth.PhysicsTeam> teamComponentDict;        // 0x68
        private System.Int32 activeTeamCount;        // 0x70
        private System.Int32 normalUpdateCount;        // 0x74
        private System.Int32 physicsUpdateCount;        // 0x78

        // Methods
        private System.Void Create() { }
        private System.Void Dispose() { }
        private System.Int32 get_TeamCount() { }
        private System.Int32 get_TeamLength() { }
        private System.Int32 get_ActiveTeamCount() { }
        private System.Int32 get_ColliderCount() { }
        private System.Int32 get_NormalUpdateCount() { }
        private System.Int32 get_PhysicsUpdateCount() { }
        private System.Int32 get_PauseCount() { }
        private System.Int32 CreateTeam(MagicaCloth.PhysicsTeam team, System.UInt32 flag) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void SetEnable(System.Int32 teamId, System.Boolean sw) { }
        private System.Boolean IsValid(System.Int32 teamId) { }
        private System.Boolean IsValidData(System.Int32 teamId) { }
        private System.Boolean IsActive(System.Int32 teamId) { }
        private System.Void SetFlag(System.Int32 teamId, System.UInt32 flag, System.Boolean sw) { }
        private System.Boolean IsFlag(System.Int32 teamId, System.UInt32 flag) { }
        private System.Void SetParticleChunk(System.Int32 teamId, MagicaCloth.ChunkData chunk) { }
        private System.Void SetFriction(System.Int32 teamId, System.Single dynamicFriction, System.Single staticFriction) { }
        private System.Void SetMass(System.Int32 teamId, MagicaCloth.BezierParam mass) { }
        private System.Void SetGravity(System.Int32 teamId, MagicaCloth.BezierParam gravity) { }
        private System.Void SetGravityDirection(System.Int32 teamId, Unity.Mathematics.float3 dir) { }
        private System.Void SetDrag(System.Int32 teamId, MagicaCloth.BezierParam drag) { }
        private System.Void SetMaxVelocity(System.Int32 teamId, MagicaCloth.BezierParam maxVelocity) { }
        private System.Void SetExternalForce(System.Int32 teamId, System.Single massInfluence, System.Single windInfluence, System.Single windRandomScale, System.Single windSynchronization) { }
        private System.Void SetDepthInfluence(System.Int32 teamId, MagicaCloth.BezierParam depthInfluence) { }
        private System.Void SetWorldInfluence(System.Int32 teamId, System.Single maxSpeed, System.Single maxRotatinSpeed, MagicaCloth.BezierParam moveInfluence, MagicaCloth.BezierParam rotInfluence, System.Boolean resetTeleport, System.Single teleportDistance, System.Single teleportRotation, System.Single resetStabilizationTime, MagicaCloth.ClothParams.TeleportMode teleportMode, System.Boolean useClampRotation, MagicaCloth.BezierParam clampRotation) { }
        private System.Single CalcClampRotationLimit(System.Boolean useClampRotation, MagicaCloth.BezierParam clampRotation) { }
        private System.Void SetWorldInfluence(System.Int32 teamId, System.Single maxSpeed, System.Single maxRotationSpeed, MagicaCloth.BezierParam moveInfluence, MagicaCloth.BezierParam rotInfluence) { }
        private System.Void SetAfterTeleport(System.Int32 teamId, System.Boolean resetTeleport, System.Single teleportDistance, System.Single teleportRotation, MagicaCloth.ClothParams.TeleportMode teleportMode) { }
        private System.Void SetStabilizationTime(System.Int32 teamId, System.Single resetStabilizationTime) { }
        private System.Void ResetWorldInfluenceTarget(System.Int32 teamId, UnityEngine.Transform target) { }
        private System.Void SetClampRotation(System.Int32 teamId, System.Boolean useClampRotation, MagicaCloth.BezierParam clampRotation) { }
        private System.Void SetSelfCollisionRange(System.Int32 teamId, System.Single range) { }
        private System.Void SetBoneIndex(System.Int32 teamId, System.Int32 boneIndex, UnityEngine.Vector3 initScale) { }
        private System.Void AddColliderParticle(System.Int32 teamId, System.Int32 particleIndex) { }
        private System.Void RemoveColliderParticle(System.Int32 teamId, System.Int32 particleIndex) { }
        private System.Void RemoveCollider(System.Int32 teamId, MagicaCloth.ColliderComponent collider) { }
        private System.Void ResetFuturePredictionCollidere(System.Int32 teamId) { }
        private System.Void AddSkinningBoneIndex(System.Int32 teamId, System.Collections.Generic.List<UnityEngine.Transform> boneList) { }
        private System.Void RemoveSkinningBoneIndex(System.Int32 teamId) { }
        private System.Void SetTimeScale(System.Int32 teamId, System.Single timeScale) { }
        private System.Single GetTimeScale(System.Int32 teamId) { }
        private System.Void SetBlendRatio(System.Int32 teamId, System.Single blendRatio) { }
        private System.Single GetBlendRatio(System.Int32 teamId) { }
        private System.Void SetOutPhysicsPoseBlendRatio(System.Int32 teamId, System.Single blendRatio) { }
        private System.Single GetOutPhysicsPoseBlendRatio(System.Int32 teamId) { }
        private System.Void SetImpactForce(System.Int32 teamId, Unity.Mathematics.float3 force, MagicaCloth.PhysicsManagerTeamData.ForceMode mode) { }
        private System.Void ResetStabilizationTime(System.Int32 teamId, System.Single resetStabilizationTime) { }
        private System.Void SetUpdateMode(System.Int32 teamId, MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode) { }
        private System.Void ChangeUseUnityPhysics(System.Int32 teamId, System.Boolean sw) { }
        private System.Void ChangeParticleUseUnityPhysics(System.Int32 pindex, System.Boolean unityPhysics) { }
        private System.Void ChangeBoneFlag(System.Int32 teamId, MagicaCloth.PhysicsTeam.TeamCullingMode cullingMode, System.Boolean isCalculation) { }
        private System.Void EarlyUpdateTeamAlways() { }
        private System.Void PreUpdateTeamAlways() { }
        private System.Int32 CalcMaxUpdateCount(System.Int32 ups, System.Single deltaTime, System.Single physicsDeltaTime, System.Single updateDeltaTime) { }
        private System.Void PreUpdateTeamData(System.Single deltaTime, System.Single physicsDeltaTime, System.Single updateDeltaTime, System.Int32 ups, System.Int32 maxUpdateCount) { }
        private System.Void PostUpdateTeamData() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9
    public class PhysicsManagerWindData : PhysicsManagerAccess
    {
        // Fields
        public static System.UInt32 Flag_Enable;        // 0x0
        public static System.UInt32 Flag_Addition;        // 0x0
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerWindData.WindData> windDataList;        // 0x18

        // Methods
        private System.Void Create() { }
        private System.Void Dispose() { }
        private System.Int32 CreateWind(MagicaCloth.PhysicsManagerWindData.WindType windType, MagicaCloth.PhysicsManagerWindData.ShapeType shapeType, Unity.Mathematics.float3 areaSize, System.Boolean addition, System.Single main, System.Single turbulence, System.Single frequency, Unity.Mathematics.float3 direction, MagicaCloth.PhysicsManagerWindData.DirectionType directinType, System.Single areaVolume, System.Single areaLength, MagicaCloth.BezierParam attenuation) { }
        private System.Void RemoveWind(System.Int32 windId) { }
        private System.Void SetEnable(System.Int32 windId, System.Boolean sw, UnityEngine.Transform target) { }
        private System.Boolean IsActive(System.Int32 windId) { }
        private System.Void SetFlag(System.Int32 windId, System.UInt32 flag, System.Boolean sw) { }
        private System.Void SetParameter(System.Int32 windId, Unity.Mathematics.float3 areaSize, System.Boolean addition, System.Single main, System.Single turbulence, System.Single frequency, Unity.Mathematics.float3 direction, System.Single areaVolume, System.Single areaLength, MagicaCloth.BezierParam attenuation) { }
        private System.Int32 get_Count() { }
        private Unity.Mathematics.float3 CalcWindForce(System.Single time, Unity.Mathematics.float2 noiseBasePos, Unity.Mathematics.float3 mainDir, System.Single main, System.Single turbulence, System.Single frequency, System.Single randomScale) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CE
    public class PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.MagicaPhysicsManager <Manager>k__BackingField;        // 0x10

        // Methods
        private MagicaCloth.MagicaPhysicsManager get_Manager() { }
        private System.Void set_Manager(MagicaCloth.MagicaPhysicsManager value) { }
        private System.Void Start() { }
        private System.Void Init(MagicaCloth.MagicaPhysicsManager manager) { }
        private System.Void Create() { }
        private System.Void RemoveGroup(System.Int32 group) { }
        private System.Void Release() { }
        private System.Void Warmup() { }
        private Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF
    public class ColliderComponent : ParticleComponent
    {
        // Fields
        protected System.Boolean isGlobal;        // 0x28
        private UnityEngine.Vector3 center;        // 0x2C

        // Methods
        private UnityEngine.Vector3 get_Center() { }
        private System.Void set_Center(UnityEngine.Vector3 value) { }
        private System.Void OnInit() { }
        private System.Void OnDispose() { }
        private System.Int32 GetDataHash() { }
        private System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning) { }
        private UnityEngine.Vector3 CalcLocalPos(UnityEngine.Vector3 pos) { }
        private UnityEngine.Vector3 CalcLocalDir(UnityEngine.Vector3 dir) { }
        private MagicaCloth.ChunkData CreateColliderParticle(System.Int32 teamId) { }
        private System.Void RemoveColliderParticle(System.Int32 teamId) { }
        private MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D0
    public class MagicaCapsuleCollider : ColliderComponent
    {
        // Fields
        private MagicaCloth.MagicaCapsuleCollider.Axis axis;        // 0x38
        private System.Single length;        // 0x3C
        private System.Single startRadius;        // 0x40
        private System.Single endRadius;        // 0x44

        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Void OnValidate() { }
        private System.Void DataUpdate() { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.MagicaCapsuleCollider.Axis get_AxisMode() { }
        private System.Void set_AxisMode(MagicaCloth.MagicaCapsuleCollider.Axis value) { }
        private System.Single get_Length() { }
        private System.Void set_Length(System.Single value) { }
        private System.Single get_StartRadius() { }
        private System.Void set_StartRadius(System.Single value) { }
        private System.Single get_EndRadius() { }
        private System.Void set_EndRadius(System.Single value) { }
        private MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId) { }
        private System.UInt32 GetCapsuleFlag() { }
        private UnityEngine.Vector3 GetLocalDir() { }
        private UnityEngine.Vector3 GetLocalUp() { }
        private System.Single GetScale() { }
        private System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D2
    public class MagicaPlaneCollider : ColliderComponent
    {
        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Void OnValidate() { }
        private System.Void DataUpdate() { }
        private MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId) { }
        private System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3
    public class MagicaSphereCollider : ColliderComponent
    {
        // Fields
        private System.Single radius;        // 0x38

        // Methods
        private MagicaCloth.ComponentType GetComponentType() { }
        private System.Void OnValidate() { }
        private System.Void DataUpdate() { }
        private System.Single get_Radius() { }
        private System.Void set_Radius(System.Single value) { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId) { }
        private System.Single GetScale() { }
        private System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4
    public class ParticleComponent : BaseComponent, IDataHash
    {
        // Fields
        protected System.Collections.Generic.Dictionary<System.Int32,MagicaCloth.ChunkData> particleDict;        // 0x18
        protected MagicaCloth.RuntimeStatus status;        // 0x20

        // Methods
        private MagicaCloth.RuntimeStatus get_Status() { }
        private System.Int32 GetDataHash() { }
        private System.Int32 get_CenterParticleIndex() { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Init() { }
        private System.Void OnUpdateStatus() { }
        private System.Boolean VerifyData() { }
        private System.Void OnInit() { }
        private System.Void OnDispose() { }
        private System.Void OnUpdate() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Void EnableParticle() { }
        private System.Void DisableParticle() { }
        private System.Void EnableTeamParticle(System.Int32 teamId) { }
        private System.Void DisableTeamParticle(System.Int32 teamId) { }
        private System.Void ReserveDataUpdate() { }
        private System.Void DataUpdate() { }
        private System.Void UpdateStatus() { }
        private MagicaCloth.ChunkData CreateParticle(System.UInt32 flag, System.Int32 teamId, System.Single depth, Unity.Mathematics.float3 radius, Unity.Mathematics.float3 localPos) { }
        private System.Void RemoveTeamParticle(System.Int32 teamId) { }
        private System.Void RemoveParticle() { }
        private UnityEngine.Transform UserTransform(System.Int32 vindex) { }
        private Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        private Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        private System.Void .ctor() { }
        private System.Object <Init>b__11_0() { }

    }

    // TypeToken: 0x20000D5
    public class PhysicsTeam : CoreComponent
    {
        // Fields
        protected MagicaCloth.PhysicsTeamData teamData;        // 0x38
        private System.Single userBlendWeight;        // 0x40
        private System.Single userPhysicsBlendWeight;        // 0x44
        private System.Boolean syncBlendWeightToPoseBlendWeight;        // 0x48
        private System.Single userCloseThreshold;        // 0x4C
        private MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode;        // 0x50
        private MagicaCloth.PhysicsTeam.TeamCullingMode cullingMode;        // 0x54
        private MagicaCloth.PhysicsTeam.TeamSkinningMode skinningMode;        // 0x58
        protected System.Int32 teamId;        // 0x5C
        protected MagicaCloth.ChunkData particleChunk;        // 0x60
        protected UnityEngine.Transform influenceTarget;        // 0x70

        // Methods
        private System.Int32 GetDataHash() { }
        private System.Int32 get_TeamId() { }
        private MagicaCloth.PhysicsTeamData get_TeamData() { }
        private MagicaCloth.ChunkData get_ParticleChunk() { }
        private System.Void set_InfluenceTarget(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_InfluenceTarget() { }
        private System.Single get_UserBlendWeight() { }
        private System.Void set_UserBlendWeight(System.Single value) { }
        private System.Single get_UserPhysicsBlendWeight() { }
        private System.Void set_UserPhysicsBlendWeight(System.Single value) { }
        private System.Boolean get_SyncBlendWeightToPoseBlendWeight() { }
        private System.Void set_SyncBlendWeightToPoseBlendWeight(System.Boolean value) { }
        private System.Single get_UserCloseThreshold() { }
        private System.Void set_UserCloseThreshold(System.Single value) { }
        private MagicaCloth.PhysicsTeam.TeamUpdateMode get_UpdateMode() { }
        private System.Void set_UpdateMode(MagicaCloth.PhysicsTeam.TeamUpdateMode value) { }
        private MagicaCloth.PhysicsTeam.TeamCullingMode get_CullingMode() { }
        private System.Void set_CullingMode(MagicaCloth.PhysicsTeam.TeamCullingMode value) { }
        private MagicaCloth.PhysicsTeam.TeamSkinningMode get_SkinningMode() { }
        private System.Void set_SkinningMode(MagicaCloth.PhysicsTeam.TeamSkinningMode value) { }
        private System.Boolean get_UseAnimatedPose() { }
        private System.Void OnInit() { }
        private System.Void OnDispose() { }
        private System.Void OnUpdate() { }
        private System.Void OnActive() { }
        private System.Void OnInactive() { }
        private System.Boolean IsActive() { }
        private System.Boolean IsValid() { }
        private MagicaCloth.ChunkData CreateParticle(System.Int32 team, System.Int32 count, System.Func<System.Int32,System.UInt32> funcFlag, System.Func<System.Int32,Unity.Mathematics.float3> funcWpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcWrot, System.Func<System.Int32,System.Single> funcDepth, System.Func<System.Int32,Unity.Mathematics.float3> funcRadius, System.Func<System.Int32,Unity.Mathematics.float3> funcTargetLocalPos) { }
        private System.Void RemoveAllParticle() { }
        private System.Void EnableParticle(System.Func<System.Int32,UnityEngine.Transform> funcTarget, System.Func<System.Int32,Unity.Mathematics.float3> funcLpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcLrot) { }
        private System.Void DisableParticle(System.Func<System.Int32,UnityEngine.Transform> funcTarget, System.Func<System.Int32,Unity.Mathematics.float3> funcLpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcLrot) { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9
    public class PhysicsTeamData, IDataHash
    {
        // Fields
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> colliderList;        // 0x10
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> penetrationIgnoreColliderList;        // 0x18
        private System.Boolean mergeAvatarCollider;        // 0x20
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> addColliderList;        // 0x28

        // Methods
        private System.Int32 GetDataHash() { }
        private System.Void Init(System.Int32 teamId) { }
        private System.Void Dispose(System.Int32 teamId) { }
        private System.Void AddCollider(MagicaCloth.ColliderComponent collider) { }
        private System.Void RemoveCollider(MagicaCloth.ColliderComponent collider) { }
        private System.Void UpdateStatus() { }
        private System.Int32 get_ColliderCount() { }
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> get_ColliderList() { }
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> get_PenetrationIgnoreColliderList() { }
        private System.Boolean get_MergeAvatarCollider() { }
        private System.Void ValidateColliderList() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DA
    public class AdjustRotationWorker : PhysicsManagerWorker
    {
        // Fields
        private static System.Int32 AdjustMode_Fixed;        // 0x0
        private static System.Int32 AdjustMode_XYMove;        // 0x0
        private static System.Int32 AdjustMode_XZMove;        // 0x0
        private static System.Int32 AdjustMode_YZMove;        // 0x0
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.AdjustRotationWorker.AdjustRotationData> dataList;        // 0x18
        public MagicaCloth.FixedNativeList<MagicaCloth.AdjustRotationWorker.GroupData> groupList;        // 0x20
        private MagicaCloth.ExNativeMultiHashMap<System.Int32,System.Int32> particleMap;        // 0x28

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Int32 adjustMode, Unity.Mathematics.float3 axisRotationPower, MagicaCloth.AdjustRotationWorker.AdjustRotationData[] dataArray) { }
        private System.Void RemoveGroup(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Int32 adjustMode, Unity.Mathematics.float3 axisRotationPower) { }
        private System.Void Warmup() { }
        private Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DE
    public class BaseSkinningWorker : PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.BaseSkinningWorker.BaseSkinningData> dataList;        // 0x18
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float4x4> bindPoseList;        // 0x20
        public MagicaCloth.FixedNativeList<MagicaCloth.BaseSkinningWorker.GroupData> groupList;        // 0x28

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Boolean updateFixed, MagicaCloth.BaseSkinningWorker.BaseSkinningData[] skinningDataList, Unity.Mathematics.float4x4[] skinningBindPoseList) { }
        private System.Void RemoveGroup(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean updateFixed) { }
        private System.Void Warmup() { }
        private Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2
    public class LineWorker : PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.LineWorker.LineRotationData> dataList;        // 0x18
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.LineWorker.LineRotationRootInfo> rootInfoList;        // 0x20
        public MagicaCloth.FixedNativeList<MagicaCloth.LineWorker.GroupData> groupList;        // 0x28
        private MagicaCloth.FixedChunkNativeArray<System.Int32> rootTeamList;        // 0x30

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, System.Boolean avarage, MagicaCloth.LineWorker.LineRotationData[] dataArray, MagicaCloth.LineWorker.LineRotationRootInfo[] rootInfoArray) { }
        private System.Void RemoveGroup(System.Int32 teamId) { }
        private System.Void ChangeParam(System.Int32 teamId, System.Boolean avarage) { }
        private System.Void Warmup() { }
        private Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E7
    public class MeshParticleWorker : PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.ExNativeMultiHashMap<System.Int32,System.Int32> vertexToParticleMap;        // 0x18
        private MagicaCloth.FixedNativeListWithCount<System.Int32> vertexToParticleList;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<MagicaCloth.MeshParticleWorker.CreateData>> groupCreateDict;        // 0x28

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Void Add(System.Int32 group, System.Int32 vindex, System.Int32 pindex) { }
        private System.Void RemoveGroup(System.Int32 group) { }
        private System.Void Warmup() { }
        private Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EB
    public class RenderMeshWorker : PhysicsManagerWorker
    {
        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Void RemoveGroup(System.Int32 group) { }
        private System.Boolean IsPerformMeshProcessForEachParticle() { }
        private System.Void Warmup() { }
        private Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void CollectionVertex(MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo& r_minfo, Unity.Collections.NativeArray<System.UInt32>& sharedChildVertexInfoList, Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight>& sharedChildVertexWeightList, Unity.Collections.NativeArray<Unity.Mathematics.float3>& virtualPosList, Unity.Collections.NativeArray<Unity.Mathematics.quaternion>& virtualRotList, Unity.Mathematics.float3& tpos, Unity.Mathematics.quaternion& trot, Unity.Mathematics.float3& tscl, Unity.Mathematics.quaternion& itrot, System.Single scaleRatio, Unity.Mathematics.float3& scaleDirection, System.Boolean calcNormal, System.Boolean calcTangent, System.Int32 vindex, System.Int32 i, System.UInt32 flag, System.Boolean isFasterWrite, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderPosList, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderNormalList, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderPosArray, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderNomalArray, Unity.Collections.NativeArray<Unity.Mathematics.float4>& renderTangentList) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EF
    public class SpringMeshWorker : PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.ExNativeMultiHashMap<System.Int32,MagicaCloth.SpringMeshWorker.SpringData> springMap;        // 0x18
        private MagicaCloth.FixedNativeListWithCount<System.Int32> springVertexList;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> groupIndexDict;        // 0x28

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Void Add(System.Int32 group, System.Int32 vertexIndex, System.Int32 particleIndex, System.Single weight) { }
        private System.Void RemoveGroup(System.Int32 group) { }
        private System.Void Warmup() { }
        private Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F2
    public class TriangleWorker : PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.TriangleWorker.TriangleRotationData> triangleDataList;        // 0x18
        private MagicaCloth.FixedChunkNativeArray<System.Int32> triangleIndexList;        // 0x20
        public MagicaCloth.FixedNativeList<MagicaCloth.TriangleWorker.GroupData> groupList;        // 0x28

        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Int32 AddGroup(System.Int32 teamId, MagicaCloth.TriangleWorker.TriangleRotationData[] dataArray, System.Int32[] indexArray) { }
        private System.Void RemoveGroup(System.Int32 teamId) { }
        private System.Void Warmup() { }
        private Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F6
    public class VirtualMeshWorker : PhysicsManagerWorker
    {
        // Methods
        private System.Void Create() { }
        private System.Void Release() { }
        private System.Void RemoveGroup(System.Int32 group) { }
        private System.Boolean IsPerformMeshProcessForEachParticle() { }
        private System.Void Warmup() { }
        private Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FB
    public class AutoMove : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 direction;        // 0x18
        private System.Single length;        // 0x24
        private System.Single interval;        // 0x28
        private UnityEngine.Vector3 startPosition;        // 0x2C
        private System.Single time;        // 0x38

        // Methods
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void OnMoveButton() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FC
    public class AutoRotate : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 rotateAngle;        // 0x18
        private System.Single interval;        // 0x24
        private System.Single time;        // 0x28

        // Methods
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void OnMoveButton() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD
    public class BlastWaveController : MonoBehaviour
    {
        // Fields
        public MagicaCloth.MagicaAreaWind wind;        // 0x18
        public System.Single attenuationStartTime;        // 0x20
        public System.Single attenuationTime;        // 0x24

        // Methods
        private System.Collections.IEnumerator Start() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF
    public class CameraOrbit : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform cameraTransform;        // 0x18
        public UnityEngine.Transform cameraTarget;        // 0x20
        public UnityEngine.Vector3 cameraTargetPos;        // 0x28
        public UnityEngine.Vector3 cameraTargetOffset;        // 0x34
        private System.Single cameraDist;        // 0x40
        private System.Single cameraPitch;        // 0x44
        private System.Single cameraYaw;        // 0x48
        private System.Single cameraDistHokanTime;        // 0x4C
        private System.Single cameraAngleHokanTime;        // 0x50
        private System.Single cameraDistSpeed;        // 0x54
        private System.Single cameraDistMax;        // 0x58
        private System.Single cameraDistMin;        // 0x5C
        private System.Single cameraYawSpeed;        // 0x60
        private System.Single cameraPitchSpeed;        // 0x64
        private System.Single cameraMaxAngleSpeed;        // 0x68
        private System.Single cameraPitchMax;        // 0x6C
        private System.Single cameraPitchMin;        // 0x70
        private MagicaCloth.CameraOrbit.MoveMode moveMode;        // 0x74
        private System.Single moveSpeed;        // 0x78
        private System.Single setCameraDist;        // 0x7C
        private System.Single setCameraPitch;        // 0x80
        private System.Single setCameraYaw;        // 0x84
        private System.Single cameraDistVelocity;        // 0x88
        private System.Single cameraPitchVelocity;        // 0x8C
        private System.Single cameraYawVelocity;        // 0x90

        // Methods
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void LateUpdate() { }
        private System.Void updateCamera() { }
        private System.Void updatePitchYaw(UnityEngine.Vector2 speed) { }
        private System.Void updateOffset(UnityEngine.Vector2 speed) { }
        private System.Void updateZoom(System.Single speed) { }
        private System.Void OnTouchMove(System.Int32 fid, UnityEngine.Vector2 screenPos, UnityEngine.Vector2 screenVelocity, UnityEngine.Vector2 cmVelocity) { }
        private System.Void OnDoubleTouchMove(System.Int32 fid, UnityEngine.Vector2 screenPos, UnityEngine.Vector2 screenVelocity, UnityEngine.Vector2 cmVelocity) { }
        private System.Void OnTouchPinch(System.Single speedscr, System.Single speedcm) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000101
    public class CopyObject : MonoBehaviour
    {
        // Fields
        public System.Int32 seed;        // 0x18
        public System.Int32 count;        // 0x1C
        public System.Single radius;        // 0x20
        public UnityEngine.GameObject prefab;        // 0x28
        public System.Int32 delayFrame;        // 0x30

        // Methods
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Collections.IEnumerator CreateObject() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000103
    public class DressUpControl : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject partsItemPrefab;        // 0x18
        private UnityEngine.UI.VerticalLayoutGroup verticalLayoutGroup;        // 0x20
        private MagicaCloth.MagicaAvatar avatar;        // 0x28
        public System.Collections.Generic.List<MagicaCloth.DressUpControl.AvatarPartsGroup> avatarPartsGroupList;        // 0x30

        // Methods
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void OnDestroy() { }
        private System.Void Init() { }
        private System.Void ChangeParts(System.Int32 id, System.Int32 dir) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }
        private System.Void <Init>b__8_0(System.Int32 id, System.Int32 dir) { }

    }

    // TypeToken: 0x2000105
    public class ModelController : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> characterList;        // 0x18
        private System.Single slowTime;        // 0x20
        private System.Boolean slow;        // 0x24

        // Methods
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void AnimatorAction(System.Action<UnityEngine.Animator> act) { }
        private System.Void ClothAction(System.Action<MagicaCloth.BaseCloth> act) { }
        private System.Void OnNextButton() { }
        private System.Void OnBackButton() { }
        private System.Void OnSlowButton() { }
        private System.Void OnActiveButton() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000108
    public class ObjectUtility
    {
        // Methods
        private UnityEngine.GameObject[] PlaceRandomCubes(System.Int32 count, UnityEngine.Vector3 center, System.Single radius) { }
        private UnityEngine.GameObject[] PlaceRandomCubes(System.Int32 count) { }
        private UnityEngine.GameObject MakeStrippedCube() { }
        private UnityEngine.GameObject[] PlaceRandomGameObject(System.Int32 count, UnityEngine.Vector3 center, System.Single radius, UnityEngine.GameObject prefab) { }

    }

    // TypeToken: 0x2000109
    public class SimpleInputManager : CreateSingleton`1
    {
        // Fields
        private static System.Int32 MaxFinger;        // 0x0
        public System.Single tapRadiusCm;        // 0x18
        public System.Single flickRangeCm;        // 0x1C
        public System.Single flickCheckSpeed;        // 0x20
        public System.Single mouseWheelSpeed;        // 0x24
        private System.Int32 mainFingerId;        // 0x28
        private System.Int32 subFingerId;        // 0x2C
        private UnityEngine.Vector2[] downPos;        // 0x30
        private UnityEngine.Vector2[] lastPos;        // 0x38
        private UnityEngine.Vector2[] flickDownPos;        // 0x40
        private System.Single[] flickDownTime;        // 0x48
        private System.Single lastTime;        // 0x50
        private System.Boolean mobilePlatform;        // 0x54
        private System.Boolean[] mouseDown;        // 0x58
        private UnityEngine.Vector2[] mouseOldMovePos;        // 0x60
        private System.Single screenDpi;        // 0x68
        private System.Single screenDpc;        // 0x6C
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2> OnTouchDown;        // 0x0
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2> OnTouchMove;        // 0x8
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2> OnDoubleTouchMove;        // 0x10
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2> OnTouchUp;        // 0x18
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2> OnTouchMoveCancel;        // 0x20
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2> OnTouchTap;        // 0x28
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2> OnTouchFlick;        // 0x30
        public static UnityEngine.Events.UnityAction<System.Single,System.Single> OnTouchPinch;        // 0x38
        public static UnityEngine.Events.UnityAction OnBackButton;        // 0x40

        // Methods
        private System.Void Init() { }
        private System.Void InitSingleton() { }
        private System.Void Update() { }
        private System.Single get_ScreenDpi() { }
        private System.Single get_ScreenDpc() { }
        private System.Void CalcScreenDpi() { }
        private System.Void AllResetTouchInfo() { }
        private System.Int32 GetTouchCount() { }
        private System.Boolean IsUI() { }
        private System.Void UpdateMobile() { }
        private UnityEngine.Vector2 CalcScreenRatioVector(UnityEngine.Vector2 vec) { }
        private System.Boolean CheckFlic(System.Int32 fid, UnityEngine.Vector2 oldpos, UnityEngine.Vector2 nowpos, UnityEngine.Vector2 downpos, System.Single flicktime) { }
        private System.Void UpdateMouse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010A
    public class SliderStart : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text text;        // 0x18
        private System.String lable;        // 0x20
        private System.String format;        // 0x28
        private System.String formatString;        // 0x30

        // Methods
        private System.Void Start() { }
        private System.Void OnChangeValue(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010B
    public class UIPartsItem : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text text;        // 0x18
        public UnityEngine.UI.Button prefButton;        // 0x20
        public UnityEngine.UI.Button nextButton;        // 0x28
        private System.Int32 id;        // 0x30

        // Methods
        private System.Void Start() { }
        private System.Void Init(System.String title, System.Int32 id, System.Action<System.Int32,System.Int32> onClick) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010D
    public class WindController : MonoBehaviour
    {
        // Fields
        private UnityEngine.WindZone unityWindZone;        // 0x18
        private System.Single unityWindZoneScale;        // 0x20
        private UnityEngine.Renderer arrowRenderer;        // 0x28
        private UnityEngine.Gradient arrowGradient;        // 0x30
        private System.Collections.Generic.List<UnityEngine.Transform> rotationTransforms;        // 0x38
        private UnityEngine.GameObject blastWavePrefab;        // 0x40
        private System.Single blastWaveSpawnRadius;        // 0x48
        private System.Single angleY;        // 0x4C
        private System.Single angleX;        // 0x50

        // Methods
        private System.Void Start() { }
        private System.Void OnDirectionY(System.Single value) { }
        private System.Void OnDirectionX(System.Single value) { }
        private System.Void OnMain(System.Single value) { }
        private System.Void OnTurbulence(System.Single value) { }
        private System.Void OnFrequency(System.Single value) { }
        private System.Void OnBlastWave() { }
        private MagicaCloth.MagicaDirectionalWind get_Wind() { }
        private System.Void UpdateDirection() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010E
    public class BezierParam, IDataHash
    {
        // Fields
        private System.Single startValue;        // 0x10
        private System.Single endValue;        // 0x14
        private System.Boolean useEndValue;        // 0x18
        private System.Single curveValue;        // 0x1C
        private System.Boolean useCurveValue;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Single val) { }
        private System.Void .ctor(System.Single sval, System.Single eval) { }
        private System.Void .ctor(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval) { }
        private System.Void SetParam(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval) { }
        private System.Single get_StartValue() { }
        private System.Single get_EndValue() { }
        private System.Single get_CurveValue() { }
        private System.Boolean get_UseCurve() { }
        private System.Single Evaluate(System.Single x) { }
        private MagicaCloth.BezierParam AutoSetup(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        private System.Int32 GetDataHash() { }
        private MagicaCloth.BezierParam Clone() { }

    }

    // TypeToken: 0x200010F
    public interface IBoneReplace
    {
        // Methods
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        private System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }

    }

    // TypeToken: 0x2000110
    public interface IDataVerify
    {
        // Methods
        private System.Int32 GetVersion() { }
        private System.Void CreateVerifyData() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.String GetInformation() { }

    }

    // TypeToken: 0x2000111
    public interface IEditorCloth
    {
        // Methods
        private System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        private System.Collections.Generic.List<System.Int32> GetUseList() { }

    }

    // TypeToken: 0x2000112
    public interface IEditorMesh
    {
        // Methods
        private System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        private System.Collections.Generic.List<System.Int32> GetEditorLineList() { }

    }

    // TypeToken: 0x2000113
    public class RuntimeStatus
    {
        // Fields
        private System.Boolean initStart;        // 0x10
        private System.Boolean init;        // 0x11
        private System.Boolean initError;        // 0x12
        private System.Boolean enable;        // 0x13
        private System.Boolean userEnable;        // 0x14
        private System.Boolean runtimeError;        // 0x15
        private System.Boolean dispose;        // 0x16
        private System.Boolean isActive;        // 0x17
        private System.Boolean isDirty;        // 0x18
        private System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> <parentStatusSet>k__BackingField;        // 0x20
        private System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> <childStatusSet>k__BackingField;        // 0x28
        private System.Action UpdateStatusAction;        // 0x30
        private System.Action DisconnectedAction;        // 0x38
        private System.Func<System.Object> OwnerFunc;        // 0x40

        // Methods
        private System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> get_parentStatusSet() { }
        private System.Void set_parentStatusSet(System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> value) { }
        private System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> get_childStatusSet() { }
        private System.Void set_childStatusSet(System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> value) { }
        private System.Boolean get_IsActive() { }
        private System.Boolean get_IsInitStart() { }
        private System.Boolean get_IsInitComplete() { }
        private System.Boolean get_IsInitSuccess() { }
        private System.Boolean get_IsInitError() { }
        private System.Boolean get_IsDispose() { }
        private System.Boolean get_IsDirty() { }
        private System.Void SetInitStart() { }
        private System.Void SetInitComplete() { }
        private System.Void SetInitError() { }
        private System.Boolean SetEnable(System.Boolean sw) { }
        private System.Boolean SetUserEnable(System.Boolean sw) { }
        private System.Boolean SetRuntimeError(System.Boolean sw) { }
        private System.Void SetDispose() { }
        private System.Void SetDirty() { }
        private System.Void ClearDirty() { }
        private System.Boolean UpdateStatus() { }
        private System.Void AddParentStatus(MagicaCloth.RuntimeStatus status) { }
        private System.Void RemoveParentStatus(MagicaCloth.RuntimeStatus status) { }
        private System.Void AddChildStatus(MagicaCloth.RuntimeStatus status) { }
        private System.Void RemoveChildStatus(MagicaCloth.RuntimeStatus status) { }
        private System.Void LinkParentStatus(MagicaCloth.RuntimeStatus parent) { }
        private System.Void UnlinkParentStatus(MagicaCloth.RuntimeStatus parent) { }
        private System.Boolean IsParentStatusActive() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000114
    public class DataHashExtensions
    {
        // Fields
        public static System.Int32 NullHash;        // 0x0
        public static System.Int32 NumberHash;        // 0x0

        // Methods
        private System.Int32 GetDataHash(System.Object data) { }
        private System.Int32 GetDataHash(MagicaCloth.IDataHash data) { }
        private System.Int32 GetDataHash(T[] data) { }
        private System.Int32 GetDataHash(System.Collections.Generic.List<T> data) { }
        private System.Int32 GetDataCountHash(T[] data) { }
        private System.Int32 GetDataCountHash(System.Collections.Generic.List<T> data) { }
        private System.UInt64 GetVectorDataHash(UnityEngine.Vector3 v) { }

    }

    // TypeToken: 0x2000115
    public class GridHash
    {
        // Fields
        protected System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<MagicaCloth.GridHash.Point>> gridMap;        // 0x10
        protected System.Single gridSize;        // 0x18

        // Methods
        private System.Void Create(System.Single gridSize) { }
        private System.Void AddPoint(Unity.Mathematics.float3 pos, System.Int32 id) { }
        private System.Void Remove(Unity.Mathematics.float3 pos, System.Int32 id) { }
        private System.Void Clear() { }
        private Unity.Mathematics.int3 GetGridPos(Unity.Mathematics.float3 pos, System.Single gridSize) { }
        private System.UInt32 GetGridHash(Unity.Mathematics.int3 pos) { }
        private System.UInt32 GetGridHash(Unity.Mathematics.float3 pos, System.Single gridSize) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000117
    public class NearPointSearch : GridHash
    {
        // Fields
        private System.Single radius;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> nearDict;        // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,System.Single> distDict;        // 0x30
        private System.Collections.Generic.HashSet<System.UInt32> lockPairSet;        // 0x38

        // Methods
        private System.Void Create(Unity.Mathematics.float3[] positionList, System.Single radius) { }
        private System.Void SearchNearPointAll() { }
        private System.Void SearchNearPoint(System.Int32 id, Unity.Mathematics.float3 pos) { }
        private System.Void SearchNearPoint(Unity.Mathematics.float3 pos, System.Single r) { }
        private System.Void AddPoint(Unity.Mathematics.float3 pos, System.Int32 id) { }
        private System.Void Remove(Unity.Mathematics.float3 pos, System.Int32 id) { }
        private System.Void AddLockPair(System.Int32 id1, System.Int32 id2) { }
        private System.Boolean GetNearPointPair(System.Int32& id1, System.Int32& id2) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000118
    public struct ChunkData
    {
        // Fields
        public System.Int32 chunkNo;        // 0x10
        public System.Int32 startIndex;        // 0x14
        public System.Int32 dataLength;        // 0x18
        public System.Int32 useLength;        // 0x1C

        // Methods
        private System.Void Clear() { }
        private System.Boolean IsValid() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000119
    public class DoubleComputeBuffer`1, IDisposable
    {
        // Fields
        private UnityEngine.ComputeBuffer buffer0;        // 0x0
        private UnityEngine.ComputeBuffer buffer1;        // 0x0
        private Unity.Collections.NativeArray<T> nativeArrya;        // 0x0
        public System.UInt32 bufferID;        // 0x0
        public System.UInt32 bufferOffset;        // 0x0
        public System.Int32 bufferCount;        // 0x0

        // Methods
        private System.Void Dispose() { }
        private System.Void Swap() { }
        private System.Void Create(System.Int32 size, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage) { }
        private System.Void BeginWrite(System.Int32 length) { }
        private System.Void EndWrite(System.Int32 length) { }
        private Unity.Collections.NativeArray<T> GetNativeArray() { }
        private UnityEngine.ComputeBuffer GetBuffer(System.Int32 bufferIndex) { }
        private System.Int32 get_Count() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011A
    public class ExNativeHashMap`2
    {
        // Fields
        private Unity.Collections.NativeParallelHashMap<TKey,TValue> nativeHashMap;        // 0x0
        private System.Int32 nativeLength;        // 0x0
        private System.Collections.Generic.HashSet<TKey> useKeySet;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Int32 get_NativeCount() { }
        private System.Void Add(TKey key, TValue value) { }
        private TValue Get(TKey key) { }
        private System.Void Remove(System.Func<TKey,TValue,System.Boolean> func) { }
        private System.Void Replace(System.Func<TKey,TValue,System.Boolean> func, System.Func<TValue,TValue> datafunc) { }
        private System.Void Remove(TKey key) { }
        private System.Int32 get_Count() { }
        private System.Void Clear() { }
        private Unity.Collections.NativeParallelHashMap<TKey,TValue> get_Map() { }
        private System.Collections.Generic.HashSet<TKey> get_UseKeySet() { }

    }

    // TypeToken: 0x200011B
    public class ExNativeMultiHashMap`2
    {
        // Fields
        private Unity.Collections.NativeParallelMultiHashMap<TKey,TValue> nativeMultiHashMap;        // 0x0
        private System.Int32 nativeLength;        // 0x0
        private System.Collections.Generic.Dictionary<TKey,System.Int32> useKeyDict;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Int32 get_NativeCount() { }
        private System.Boolean get_IsCreated() { }
        private System.Void Add(TKey key, TValue value) { }
        private System.Void Remove(TKey key, TValue value) { }
        private System.Void Remove(System.Func<TKey,TValue,System.Boolean> func) { }
        private System.Void Replace(System.Func<TKey,TValue,System.Boolean> func, System.Func<TValue,TValue> datafunc) { }
        private System.Void Process(System.Action<TKey,TValue> act) { }
        private System.Void Process(TKey key, System.Action<TValue> act) { }
        private System.Boolean Contains(TKey key, TValue value) { }
        private System.Boolean Contains(TKey key) { }
        private System.Void Remove(TKey key) { }
        private System.Int32 get_Count() { }
        private System.Void Clear() { }
        private Unity.Collections.NativeParallelMultiHashMap<TKey,TValue> get_Map() { }

    }

    // TypeToken: 0x200011C
    public class FixedChunkNativeArray`1, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<T> nativeArray0;        // 0x0
        private Unity.Collections.NativeArray<T> nativeArray1;        // 0x0
        private System.Int32 nativeLength;        // 0x0
        private System.Collections.Generic.List<MagicaCloth.ChunkData> emptyChunkList;        // 0x0
        private System.Collections.Generic.List<MagicaCloth.ChunkData> useChunkList;        // 0x0
        private System.Int32 chunkSeed;        // 0x0
        private System.Int32 initLength;        // 0x0
        private T emptyElement;        // 0x0
        private System.Int32 useLength;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void SetEmptyElement(T empty) { }
        private MagicaCloth.ChunkData AddChunk(System.Int32 length) { }
        private MagicaCloth.ChunkData Add(T data) { }
        private System.Void RemoveChunk(System.Int32 chunkNo) { }
        private System.Void RemoveChunk(MagicaCloth.ChunkData chunk) { }
        private System.Void Fill(MagicaCloth.ChunkData chunk, T data) { }
        private System.Int32 get_Length() { }
        private System.Int32 get_ChunkCount() { }
        private System.Int32 get_Count() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private Unity.Collections.NativeArray<T> ToJobArray() { }
        private Unity.Collections.NativeArray<T> ToJobArray(System.Int32 bufferIndex) { }
        private System.Void SwapBuffer() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200011D
    public class FixedMultiNativeList`1, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<T> nativeArray;        // 0x0
        private System.Int32 nativeLength;        // 0x0
        private System.Collections.Generic.List<MagicaCloth.ChunkData> emptyChunkList;        // 0x0
        private System.Collections.Generic.List<MagicaCloth.ChunkData> useChunkList;        // 0x0
        private System.Int32 chunkSeed;        // 0x0
        private System.Int32 initLength;        // 0x0
        private T emptyElement;        // 0x0
        private System.Int32 useLength;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void SetEmptyElement(T empty) { }
        private MagicaCloth.ChunkData AddChunk(System.Int32 length) { }
        private System.Void RemoveChunk(System.Int32 chunkNo) { }
        private System.Void RemoveChunk(MagicaCloth.ChunkData chunk) { }
        private MagicaCloth.ChunkData AddData(MagicaCloth.ChunkData chunk, T data) { }
        private MagicaCloth.ChunkData RemoveData(MagicaCloth.ChunkData chunk, T data) { }
        private MagicaCloth.ChunkData ClearData(MagicaCloth.ChunkData chunk) { }
        private System.Void Process(MagicaCloth.ChunkData chunk, System.Action<T> act) { }
        private System.Int32 get_Length() { }
        private System.Int32 get_ChunkCount() { }
        private System.Int32 get_Count() { }
        private T get_Item(System.Int32 index) { }
        private Unity.Collections.NativeArray<T> ToJobArray() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200011E
    public class FixedNativeList`1, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<T> nativeArray0;        // 0x0
        private Unity.Collections.NativeArray<T> nativeArray1;        // 0x0
        private System.Int32 nativeLength;        // 0x0
        private System.Collections.Generic.Queue<System.Int32> emptyStack;        // 0x0
        private System.Collections.Generic.HashSet<System.Int32> useIndexSet;        // 0x0
        private System.Int32 useLength;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Int32 Add(T element) { }
        private System.Void Remove(System.Int32 index) { }
        private System.Boolean Exists(System.Int32 index) { }
        private System.Int32 get_Length() { }
        private System.Int32 get_Count() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Void Clear() { }
        private Unity.Collections.NativeArray<T> ToJobArray() { }
        private Unity.Collections.NativeArray<T> ToJobArray(System.Int32 bufferIndex) { }
        private System.Void SyncBuffer() { }

    }

    // TypeToken: 0x200011F
    public class FixedNativeListWithCount`1, IDisposable
    {
        // Fields
        private Unity.Collections.NativeList<T> nativeList;        // 0x0
        private System.Int32 nativeLength;        // 0x0
        private System.Collections.Generic.Queue<System.Int32> emptyStack;        // 0x0
        private System.Collections.Generic.HashSet<System.Int32> useIndexSet;        // 0x0
        private System.Collections.Generic.Dictionary<T,System.Int32> indexDict;        // 0x0
        private System.Collections.Generic.Dictionary<T,System.Int32> countDict;        // 0x0
        private T emptyElement;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Dispose() { }
        private System.Void SetEmptyElement(T empty) { }
        private System.Int32 Add(T element) { }
        private System.Void Remove(T element) { }
        private System.Boolean Exist(T element) { }
        private System.Int32 GetUseCount(T element) { }
        private System.Int32 get_Length() { }
        private System.Int32 get_Count() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Void Clear() { }
        private T[] ToArray() { }
        private Unity.Collections.NativeArray<T> ToJobArray() { }

    }

    // TypeToken: 0x2000120
    public class FixedTransformAccessArray, IDisposable
    {
        // Fields
        private UnityEngine.Jobs.TransformAccessArray transformArray;        // 0x10
        private System.Int32 nativeLength;        // 0x18
        private System.Collections.Generic.Queue<System.Int32> emptyStack;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> useIndexDict;        // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> indexDict;        // 0x30
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> referenceDict;        // 0x38

        // Methods
        private System.Void .ctor(System.Int32 desiredJobCount) { }
        private System.Void .ctor(System.Int32 capacity, System.Int32 desiredJobCount) { }
        private System.Int32 Add(UnityEngine.Transform element) { }
        private System.Void Remove(System.Int32 index) { }
        private System.Boolean Exist(System.Int32 index) { }
        private System.Boolean Exist(UnityEngine.Transform element) { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Length() { }
        private UnityEngine.Transform get_Item(System.Int32 index) { }
        private System.Int32 GetIndex(UnityEngine.Transform element) { }
        private System.Void Clear() { }
        private System.Void Dispose() { }
        private UnityEngine.Jobs.TransformAccessArray GetTransformAccessArray() { }

    }

    // TypeToken: 0x2000121
    public class NativeArrayExtension
    {
        // Methods
        private System.Void CopyToFast(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, T2[] array) { }
        private System.Void CopyToFast(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, Unity.Collections.NativeArray<T> array) { }
        private System.Void CopyBlock(Unity.Collections.NativeArray<T> nativeArray, System.Int32 sourceIndex, System.Int32 destinationIndex, System.Int32 count) { }
        private System.Void CopyFromFast(Unity.Collections.NativeArray<T> nativeArray, Unity.Collections.NativeArray<T> array) { }
        private System.Void CopyFromFast(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, T2[] array) { }
        private System.Void SetValue(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, System.Int32 count, T value) { }

    }

    // TypeToken: 0x2000122
    public class CreateSingleton`1 : MonoBehaviour
    {
        // Fields
        private static T instance;        // 0x0
        private static T initInstance;        // 0x0
        private static System.Boolean isDestroy;        // 0x0

        // Methods
        private System.Void InitMember() { }
        private T get_Instance() { }
        private System.Void InitInstance() { }
        private System.Boolean IsInstance() { }
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void DuplicateDetection(T duplicate) { }
        private System.Void InitSingleton() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000123
    public class DataUtility
    {
        // Methods
        private System.UInt32 PackPair(System.Int32 v0, System.Int32 v1) { }
        private System.Void UnpackPair(System.UInt32 pack, System.Int32& v0, System.Int32& v1) { }
        private System.UInt32 Pack16(System.Int32 hi, System.Int32 low) { }
        private System.Int32 Unpack16Hi(System.UInt32 pack) { }
        private System.Int32 Unpack16Low(System.UInt32 pack) { }
        private System.UInt32 Pack4_28(System.Int32 hi, System.Int32 low) { }
        private System.Int32 Unpack4_28Hi(System.UInt32 pack) { }
        private System.Int32 Unpack4_28Low(System.UInt32 pack) { }
        private System.UInt32 Pack8_24(System.Int32 hi, System.Int32 low) { }
        private System.Int32 Unpack8_24Hi(System.UInt32 pack) { }
        private System.Int32 Unpack8_24Low(System.UInt32 pack) { }
        private System.UInt64 Pack32(System.Int32 hi, System.Int32 low) { }
        private System.Int32 Unpack32Hi(System.UInt64 pack) { }
        private System.Int32 Unpack32Low(System.UInt64 pack) { }
        private System.UInt64 PackTriple(System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        private System.Void UnpackTriple(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2) { }
        private System.UInt64 PackQuater(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3) { }
        private System.Void UnpackQuater(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2, System.Int32& v3) { }

    }

    // TypeToken: 0x2000124
    public class Develop
    {
        // Methods
        private System.Void Log(System.String str) { }

    }

    // TypeToken: 0x2000125
    public class GizmoUtility
    {
        // Fields
        public static readonly UnityEngine.Color ColorDynamic;        // 0x0
        public static readonly UnityEngine.Color ColorKinematic;        // 0x10
        public static readonly UnityEngine.Color ColorInvalid;        // 0x20
        public static readonly UnityEngine.Color ColorCollider;        // 0x30
        public static readonly UnityEngine.Color ColorNonSelectedCollider;        // 0x40
        public static readonly UnityEngine.Color ColorTriangle;        // 0x50
        public static readonly UnityEngine.Color ColorStructLine;        // 0x60
        public static readonly UnityEngine.Color ColorBendLine;        // 0x70
        public static readonly UnityEngine.Color ColorNearLine;        // 0x80
        public static readonly UnityEngine.Color ColorRotationLine;        // 0x90
        public static readonly UnityEngine.Color ColorAdjustLine;        // 0xA0
        public static readonly UnityEngine.Color ColorAirLine;        // 0xB0
        public static readonly UnityEngine.Color ColorBasePosition;        // 0xC0
        public static readonly UnityEngine.Color ColorDirectionMoveLimit;        // 0xD0
        public static readonly UnityEngine.Color ColorPenetration;        // 0xE0
        public static readonly UnityEngine.Color ColorCollisionNormal;        // 0xF0
        public static readonly UnityEngine.Color ColorVelocity;        // 0x100
        public static readonly UnityEngine.Color ColorSkinningBone;        // 0x110
        public static readonly UnityEngine.Color ColorDeformerPoint;        // 0x120
        public static readonly UnityEngine.Color ColorDeformerPointRange;        // 0x130
        public static readonly UnityEngine.Color ColorWind;        // 0x140

        // Methods
        private System.Void DrawWireCapsule(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scl, UnityEngine.Vector3 ldir, UnityEngine.Vector3 lup, System.Single length, System.Single startRadius, System.Single endRadius, System.Boolean resetMatrix) { }
        private System.Void DrawWireSphere(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scl, System.Single radius, System.Boolean drawSphere, System.Boolean drawAxis, System.Boolean resetMatrix) { }
        private System.Void DrawWireCube(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 size, System.Boolean resetMatrix) { }
        private System.Void DrawWireCone(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Single length, System.Single radius, System.Int32 div) { }
        private System.Void DrawWireArrow(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 size, System.Boolean cross) { }
        private System.Void DrawAxis(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Single size, System.Boolean resetMatrix) { }
        private System.Void DrawBone(UnityEngine.Vector3 pos, UnityEngine.Vector3 tpos, System.Single size) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000126
    public class MathUtility
    {
        // Methods
        private System.Single Clamp1(System.Single a) { }
        private System.Single Clamp01(System.Single a) { }
        private Unity.Mathematics.float3 Project(Unity.Mathematics.float3 v, Unity.Mathematics.float3 n) { }
        private System.Single Angle(Unity.Mathematics.float3 v1, Unity.Mathematics.float3 v2) { }
        private Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single minlength, System.Single maxlength) { }
        private Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single maxlength) { }
        private Unity.Mathematics.float3 ClampDistance(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to, System.Single maxlength) { }
        private System.Boolean ClampAngle(Unity.Mathematics.float3 dir, Unity.Mathematics.float3 basedir, System.Single maxAngle, Unity.Mathematics.float3& outdir) { }
        private Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to, System.Single t) { }
        private Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.quaternion from, Unity.Mathematics.quaternion to) { }
        private System.Single Angle(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b) { }
        private Unity.Mathematics.quaternion ClampAngle(Unity.Mathematics.quaternion from, Unity.Mathematics.quaternion to, System.Single maxAngle) { }
        private Unity.Mathematics.float3 AxisToEuler(Unity.Mathematics.float3 axis) { }
        private Unity.Mathematics.quaternion AxisQuaternion(Unity.Mathematics.float3 dir) { }
        private System.Single ClosestPtPointSegmentRatio(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        private System.Single ClosestPtPointSegmentRatioNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        private Unity.Mathematics.float3 ClosestPtPointSegment(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        private Unity.Mathematics.float3 ClosestPtPointSegmentNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        private System.Boolean IntersectPointPlane(Unity.Mathematics.float3 planePos, Unity.Mathematics.float3 planeDir, Unity.Mathematics.float3 pos, Unity.Mathematics.float3& outpos) { }
        private System.Single IntersectPointPlaneDist(Unity.Mathematics.float3 planePos, Unity.Mathematics.float3 planeDir, Unity.Mathematics.float3 pos, Unity.Mathematics.float3& outPos) { }
        private System.Boolean IntersectSegmentPlane(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 p, Unity.Mathematics.float3 pn, Unity.Mathematics.float3& opos) { }
        private System.Boolean IntersectPointSphere(Unity.Mathematics.float3 sc, System.Single sr, Unity.Mathematics.float3 pos, Unity.Mathematics.float3& outPos) { }
        private System.Boolean IntersectPointSphere(Unity.Mathematics.float3 p, Unity.Mathematics.float3 sc, System.Single sr) { }
        private System.Boolean IntersectRaySphere(Unity.Mathematics.float3 p, Unity.Mathematics.float3 d, Unity.Mathematics.float3 sc, System.Single sr, Unity.Mathematics.float3& q, System.Single& t) { }
        private System.Boolean IntersectLineSphare(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 sc, System.Single sr, Unity.Mathematics.float3& q) { }
        private System.Boolean IntersectRayCone(Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, Unity.Mathematics.float3 c, Unity.Mathematics.float3 v, System.Single cost, System.Single& t, Unity.Mathematics.float3& p) { }
        private System.Boolean IntersectLineConeSurface(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 d, System.Single dlen, Unity.Mathematics.float3 c, Unity.Mathematics.float3 v, System.Single cost, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, Unity.Mathematics.float3& p) { }
        private System.Boolean IntersectLineCylinderSurface(Unity.Mathematics.float3 sa, Unity.Mathematics.float3 sb, Unity.Mathematics.float3 p, Unity.Mathematics.float3 q, System.Single r, System.Single& t) { }
        private System.Boolean IntersectLineCylinderSurface(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, System.Single r1, System.Single r2, Unity.Mathematics.float3& p) { }
        private System.Boolean IntersectLineCapsule(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, System.Single r1, System.Single r2, Unity.Mathematics.float3& p) { }
        private System.Boolean IntersectTrianglePointDistance(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, System.Single restDist, System.Single compressionStiffness, System.Single stretchStiffness, Unity.Mathematics.float3& corr, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, Unity.Mathematics.float3& corr2) { }
        private System.Boolean IntersectTrianglePointDistanceSide(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, System.Single restDist, System.Single compressionStiffness, System.Single stretchStiffness, System.Single side, Unity.Mathematics.float3& corr, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, Unity.Mathematics.float3& corr2) { }
        private System.Boolean IntersectTrianglePointDistanceSide2(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, System.Single radius, System.Single restDist, System.Single compressionStiffness, System.Single stretchStiffness, System.Single side, Unity.Mathematics.float3& corr, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, Unity.Mathematics.float3& corr2) { }
        private System.Single DistanceTrianglePoint(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        private Unity.Mathematics.float3 TriangleCenter(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        private Unity.Mathematics.float3 TriangleNormal(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        private Unity.Mathematics.quaternion TriangleRotation(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        private Unity.Mathematics.quaternion TriangleCenterRotation(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 p3) { }
        private System.Single DistanceTriangleCenter(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        private System.Single DirectionPointTriangle(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c) { }
        private System.Boolean IntersectLineTriangle(Unity.Mathematics.float3 p, Unity.Mathematics.float3 q, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c, Unity.Mathematics.float3& hitpos, System.Single& t, Unity.Mathematics.float3& n) { }
        private System.Single ClosestPtSegmentSegment(Unity.Mathematics.float3 p1, Unity.Mathematics.float3 q1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 q2, System.Single& s, System.Single& t, Unity.Mathematics.float3& c1, Unity.Mathematics.float3& c2) { }
        private System.Single GetBezierValue(MagicaCloth.BezierParam bparam, System.Single t) { }
        private System.Single GetBezierValue(System.Single sval, System.Single eval, System.Single curve, System.Single t) { }

    }

    // TypeToken: 0x2000127
    public class MeshUtility
    {
        // Methods
        private UnityEngine.GameObject ReplaceSkinnedMeshRendererToMeshRenderer(UnityEngine.SkinnedMeshRenderer sren, System.Boolean replaceSkinnedMeshRenderer) { }
        private System.Boolean CalcMeshWorldPositionNormalTangent(MagicaCloth.MeshData meshData, System.Collections.Generic.List<UnityEngine.Transform> boneList, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Boolean CalcMeshWorldPositionNormalTangent(UnityEngine.Renderer ren, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        private System.Boolean CalcMeshLocalNormalTangent(System.Collections.Generic.List<System.Int32> selectList, UnityEngine.Vector3[] vlist, UnityEngine.Vector2[] uvlist, System.Int32[] triangles, System.Collections.Generic.List<UnityEngine.Vector3>& lnorList, System.Collections.Generic.List<UnityEngine.Vector3>& ltanList) { }
        private System.Collections.Generic.List<System.Collections.Generic.HashSet<System.Int32>> GetTriangleToVertexLinkList(System.Int32 vcnt, System.Collections.Generic.List<System.Int32> lineList, System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Collections.Generic.List<System.Collections.Generic.HashSet<System.Int32>> GetVertexLinkList(System.Int32 vcnt, System.Collections.Generic.HashSet<System.UInt32> lineSet) { }
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int32>> GetVertexToTriangles(System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Int32 RestTriangleVertex(System.Int32 tindex, System.Int32 v0, System.Int32 v1, System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Void RestTriangleVertex(System.Int32 tindex, System.Int32 v0, System.Collections.Generic.List<System.Int32> triangleList, System.Int32& v1, System.Int32& v2) { }
        private System.Boolean CheckAdjacentTriangle(System.Int32 tindex0, System.Int32 tindex1, System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<System.Int32>> GetTriangleEdgePair(System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Void AddTriangleEdge(System.Int32 v0, System.Int32 v1, System.Int32 tindex, System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<System.Int32>> triangleEdgeDict) { }
        private System.Collections.Generic.List<System.UInt64> GetTrianglePackList(System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Single ClosestPtBoneLine(UnityEngine.Vector3 pos, UnityEngine.Transform bone, System.Single lineWidth, UnityEngine.Vector3& d) { }
        private System.Collections.Generic.List<UnityEngine.Transform> GetUseBoneTransformList(UnityEngine.Transform[] bones, UnityEngine.Mesh mesh) { }
        private System.Void CalcTetraMesh(System.Collections.Generic.List<UnityEngine.Vector3> posList, System.Int32& tetraCount, System.Collections.Generic.List<System.Int32>& tetraIndexList, System.Collections.Generic.List<System.Single>& tetraSizeList) { }
        private UnityEngine.Transform GetReplaceBone(UnityEngine.Transform now, System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }

    }

    // TypeToken: 0x200012A
    public class StaticStringBuilder
    {
        // Fields
        private static System.Text.StringBuilder stringBuilder;        // 0x0

        // Methods
        private System.Text.StringBuilder get_Instance() { }
        private System.Void Clear() { }
        private System.Text.StringBuilder Append(System.Object[] args) { }
        private System.Text.StringBuilder AppendLine(System.Object[] args) { }
        private System.Text.StringBuilder AppendLine() { }
        private System.String AppendToString(System.Object[] args) { }
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200012B
    public class UpdateTimeManager
    {
        // Fields
        private MagicaCloth.UpdateTimeManager.UpdateCount updatePerSeccond;        // 0x10
        private MagicaCloth.UpdateTimeManager.UpdateMode updateMode;        // 0x14
        private MagicaCloth.UpdateTimeManager.UpdateLocation updateLocation;        // 0x18
        private System.Single timeScale;        // 0x1C
        private System.Single futurePredictionRate;        // 0x20
        private System.Boolean updateBoneScale;        // 0x24
        private System.Int32 fixedUpdateCount;        // 0x28

        // Methods
        private System.Void ResetFixedUpdateCount() { }
        private System.Void AddFixedUpdateCount() { }
        private System.Int32 get_FixedUpdateCount() { }
        private MagicaCloth.UpdateTimeManager.UpdateMode GetUpdateMode() { }
        private System.Void SetUpdateMode(MagicaCloth.UpdateTimeManager.UpdateMode mode) { }
        private MagicaCloth.UpdateTimeManager.UpdateLocation GetUpdateLocation() { }
        private System.Void SetUpdateLocation(MagicaCloth.UpdateTimeManager.UpdateLocation location) { }
        private System.Int32 get_UpdatePerSecond() { }
        private System.Void SetUpdatePerSecond(MagicaCloth.UpdateTimeManager.UpdateCount ucount) { }
        private System.Single get_UpdateIntervalTime() { }
        private System.Single get_UpdatePower() { }
        private System.Single get_TimeScale() { }
        private System.Void set_TimeScale(System.Single value) { }
        private System.Single get_DeltaTime() { }
        private System.Single get_PhysicsDeltaTime() { }
        private System.Single get_AverageDeltaTime() { }
        private System.Boolean get_IsUnscaledUpdate() { }
        private System.Boolean get_IsDelay() { }
        private System.Single get_FuturePredictionRate() { }
        private System.Void set_FuturePredictionRate(System.Single value) { }
        private System.Boolean get_UpdateBoneScale() { }
        private System.Void set_UpdateBoneScale(System.Boolean value) { }
        private System.Int32 get_WorkerMaximumCount() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012F
    public class ReferenceDataBuilder`1
    {
        // Fields
        private System.Int32 indexCount;        // 0x0
        private System.Collections.Generic.List<T> dataList;        // 0x0
        private System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> indexToDataIndexList;        // 0x0
        private System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> dataIndexToIndexList;        // 0x0

        // Methods
        private System.Void Init(System.Int32 indexCount) { }
        private System.Void AddData(T data, System.Int32[] indexes) { }
        private System.ValueTuple<System.Collections.Generic.List<MagicaCloth.ReferenceDataIndex>,System.Collections.Generic.List<T>> GetDirectReferenceData() { }
        private System.ValueTuple<System.Collections.Generic.List<MagicaCloth.ReferenceDataIndex>,System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>> GetIndirectReferenceData() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000130
    public struct ReferenceDataIndex
    {
        // Fields
        public System.Int32 startIndex;        // 0x10
        public System.Int32 count;        // 0x14

    }

    // TypeToken: 0x2000131
    public interface IDataHash
    {
        // Methods
        private System.Int32 GetDataHash() { }

    }

    // TypeToken: 0x2000132
    public interface IShareDataObject
    {
        // Methods
        private System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        private MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }

    }

    // TypeToken: 0x2000133
    public class ShareDataObject : ScriptableObject, IDataVerify, IDataHash
    {
        // Fields
        protected System.Int32 dataHash;        // 0x18
        protected System.Int32 dataVersion;        // 0x1C

        // Methods
        private System.Int32 GetDataHash() { }
        private System.Void set_SaveDataHash(System.Int32 value) { }
        private System.Int32 get_SaveDataHash() { }
        private System.Void set_SaveDataVersion(System.Int32 value) { }
        private System.Int32 get_SaveDataVersion() { }
        private System.Int32 GetVersion() { }
        private MagicaCloth.Define.Error VerifyData() { }
        private System.Void CreateVerifyData() { }
        private System.String GetInformation() { }
        private T CreateShareData(System.String dataName) { }
        private System.Boolean RemoveNullAndDuplication(System.Collections.Generic.List<T> data) { }
        private T Clone(T source) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000134
    public class StopWatch
    {
        // Fields
        private System.Single startTime;        // 0x10
        private System.Single endTime;        // 0x14

        // Methods
        private MagicaCloth.StopWatch Start() { }
        private MagicaCloth.StopWatch Stop() { }
        private System.Single get_ElapsedSeconds() { }
        private System.Single get_ElapsedMilliseconds() { }
        private System.Void .ctor() { }

    }

}

namespace MagicaReductionMesh
{

    // TypeToken: 0x2000004
    public class ReductionMesh
    {
        // Fields
        private MagicaReductionMesh.ReductionMesh.ReductionWeightMode <WeightMode>k__BackingField;        // 0x10
        private MagicaReductionMesh.MeshData meshData;        // 0x18
        private MagicaReductionMesh.ReductionData reductionData;        // 0x20
        private MagicaReductionMesh.DebugData debugData;        // 0x28

        // Methods
        private MagicaReductionMesh.ReductionMesh.ReductionWeightMode get_WeightMode() { }
        private System.Void set_WeightMode(MagicaReductionMesh.ReductionMesh.ReductionWeightMode value) { }
        private MagicaReductionMesh.MeshData get_MeshData() { }
        private MagicaReductionMesh.ReductionData get_ReductionData() { }
        private MagicaReductionMesh.DebugData get_DebugData() { }
        private System.Int32 AddMesh(System.Boolean isSkinning, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Transform> bones, UnityEngine.Matrix4x4[] bindPoseList, UnityEngine.BoneWeight[] boneWeightList) { }
        private System.Int32 AddMesh(UnityEngine.Renderer ren) { }
        private System.Int32 AddMesh(UnityEngine.Transform root, System.Collections.Generic.List<UnityEngine.Vector3> posList, System.Collections.Generic.List<UnityEngine.Vector3> norList, System.Collections.Generic.List<UnityEngine.Vector4> tanList, System.Collections.Generic.List<UnityEngine.Vector2> uvList, System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Void Reduction(System.Single zeroRadius, System.Single radius, System.Single polygonLength, System.Boolean createTetra) { }
        private MagicaReductionMesh.FinalData GetFinalData(UnityEngine.Transform root) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class ReductionMeshAccess
    {
        // Fields
        protected MagicaReductionMesh.ReductionMesh parent;        // 0x10

        // Methods
        private MagicaReductionMesh.MeshData get_MeshData() { }
        private MagicaReductionMesh.ReductionData get_ReductionData() { }
        private MagicaReductionMesh.DebugData get_DebugData() { }
        private System.Void SetParent(MagicaReductionMesh.ReductionMesh parent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class DebugData : ReductionMeshAccess
    {
        // Methods
        private System.Void DispMeshInfo(System.String header) { }
        private System.Void DebugDrawShared(MagicaReductionMesh.FinalData final, System.Boolean drawTriangle, System.Boolean drawLine, System.Boolean drawTetra, System.Boolean drawVertexNormal, System.Boolean drawVertexTangent, System.Boolean drawNumber, System.Int32 maxPolygonCount, System.Int32 layer, System.Int32 tetraIndex, System.Single tetraSize, System.Collections.Generic.List<System.Int32> drawNumberList, System.Single axisSize) { }
        private System.Void DrawTetra(MagicaReductionMesh.FinalData final, System.Int32 tetraIndex, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Single tetraSize) { }
        private System.Void DebugDrawChild(MagicaReductionMesh.FinalData final, System.Boolean drawPosition, System.Boolean drawNormal, System.Boolean drawTriangle, System.Boolean drawNumber, System.Int32 maxVertexCount, System.Single positionSize, System.Single axisSize) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class FinalData
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Vector3> vertices;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Vector3> normals;        // 0x18
        public System.Collections.Generic.List<UnityEngine.Vector4> tangents;        // 0x20
        public System.Collections.Generic.List<UnityEngine.Vector2> uvs;        // 0x28
        public System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights;        // 0x30
        public System.Collections.Generic.List<UnityEngine.Matrix4x4> bindPoses;        // 0x38
        public System.Collections.Generic.List<UnityEngine.Transform> bones;        // 0x40
        public System.Collections.Generic.List<System.Int32> lines;        // 0x48
        public System.Collections.Generic.List<System.Int32> triangles;        // 0x50
        public System.Collections.Generic.List<System.Int32> tetras;        // 0x58
        public System.Collections.Generic.List<System.Single> tetraSizes;        // 0x60
        public System.Collections.Generic.List<UnityEngine.Matrix4x4> vertexBindPoses;        // 0x68
        public System.Collections.Generic.List<MagicaReductionMesh.FinalData.MeshIndexData> vertexToMeshIndexList;        // 0x70
        public System.Collections.Generic.List<System.Int32> vertexToTriangleCountList;        // 0x78
        public System.Collections.Generic.List<System.Int32> vertexToTriangleStartList;        // 0x80
        public System.Collections.Generic.List<System.Int32> vertexToTriangleIndexList;        // 0x88
        public System.Collections.Generic.List<MagicaReductionMesh.FinalData.MeshInfo> meshList;        // 0x90

        // Methods
        private System.Boolean get_IsValid() { }
        private System.Int32 get_VertexCount() { }
        private System.Int32 get_LineCount() { }
        private System.Int32 get_TriangleCount() { }
        private System.Int32 get_TetraCount() { }
        private System.Int32 get_BoneCount() { }
        private System.Boolean get_IsSkinning() { }
        private System.Int32 get_MeshCount() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class MeshData : ReductionMeshAccess
    {
        // Fields
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.Vertex> originalVertexList;        // 0x18
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.MeshInfo> meshInfoList;        // 0x20
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> shareVertexList;        // 0x28
        private System.Collections.Generic.Dictionary<System.UInt64,MagicaReductionMesh.MeshData.Triangle> triangleDict;        // 0x30
        private System.Collections.Generic.Dictionary<System.UInt32,MagicaReductionMesh.MeshData.Line> lineDict;        // 0x38
        public System.Collections.Generic.List<UnityEngine.Transform> boneList;        // 0x40
        private System.Collections.Generic.List<MagicaReductionMesh.MeshData.Tetra> tetraList;        // 0x48
        private System.Single weightPow;        // 0x50
        private System.Int32 maxWeightCount;        // 0x54
        private System.Single sameSurfaceAngle;        // 0x58
        private System.Boolean removeSameTrianglePair;        // 0x5C
        private System.Single removeSameTrianglePairAngle;        // 0x60

        // Methods
        private System.Int32 get_VertexCount() { }
        private System.Int32 get_LineCount() { }
        private System.Int32 get_TriangleCount() { }
        private System.Int32 get_TetraCount() { }
        private System.Int32 get_MeshCount() { }
        private System.Single get_WeightPow() { }
        private System.Void set_WeightPow(System.Single value) { }
        private System.Int32 get_MaxWeightCount() { }
        private System.Void set_MaxWeightCount(System.Int32 value) { }
        private System.Single get_SameSurfaceAngle() { }
        private System.Void set_SameSurfaceAngle(System.Single value) { }
        private System.Boolean get_RemoveSameTrianglePair() { }
        private System.Void set_RemoveSameTrianglePair(System.Boolean value) { }
        private System.Single get_RemoveSameTrianglePairAngle() { }
        private System.Void set_RemoveSameTrianglePairAngle(System.Single value) { }
        private System.Int32 AddMesh(System.Boolean isSkinning, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Transform> bones, UnityEngine.Matrix4x4[] bindPoseList, UnityEngine.BoneWeight[] boneWeightList) { }
        private System.Int32 AddMesh(UnityEngine.Transform root, System.Collections.Generic.List<UnityEngine.Vector3> posList, System.Collections.Generic.List<UnityEngine.Vector3> norList, System.Collections.Generic.List<UnityEngine.Vector4> tanList, System.Collections.Generic.List<UnityEngine.Vector2> uvList, System.Collections.Generic.List<System.Int32> triangleList) { }
        private System.Void CombineVertex(MagicaReductionMesh.MeshData.ShareVertex sv0, MagicaReductionMesh.MeshData.ShareVertex sv1) { }
        private System.Void UpdateMeshData(System.Boolean createTetra) { }
        private System.Void CalcVertexIndex() { }
        private System.Void CalcUV(MagicaReductionMesh.MeshData.UvWrapMode wrapMode) { }
        private System.Void CreateTriangleAndLine() { }
        private System.Void CalcShareVertexWeight() { }
        private System.Void AdjustTriangleNormal() { }
        private System.Boolean CheckTwoTriangleOpen(MagicaReductionMesh.MeshData.Triangle tri1, MagicaReductionMesh.MeshData.Triangle tri2, System.UInt32 edge) { }
        private System.Single CalcTwoTriangleAngle(MagicaReductionMesh.MeshData.Triangle tri1, MagicaReductionMesh.MeshData.Triangle tri2, System.UInt32 edge) { }
        private System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<System.UInt64>> GetEdgeToTriangleDict() { }
        private System.Void CalcVertexNormalFromTriangle() { }
        private System.Void RemoveTriangle(System.UInt64 thash) { }
        private System.Collections.Generic.Dictionary<System.UInt64,System.Collections.Generic.List<MagicaReductionMesh.MeshData.Square>> GetSquareDict() { }
        private System.Void RemoveOverlappingSquareTriangles() { }
        private System.Void CreateTetraMesh() { }
        private UnityEngine.Bounds CalcBounding() { }
        private MagicaReductionMesh.FinalData GetFinalData(UnityEngine.Transform root) { }
        private System.Void CreateOriginalMeshInfo(MagicaReductionMesh.FinalData final, UnityEngine.Transform root, System.Single weightLength) { }
        private System.Void AddVertexToMeshIndexData(MagicaReductionMesh.FinalData final, System.Int32 sindex, System.Int32 meshIndex, System.Int32 meshVertexIndex) { }
        private System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> SearchNearPointList(UnityEngine.Vector3 basePos, MagicaReductionMesh.MeshData.ShareVertex sv, System.Single weightLength, System.Int32 maxCount) { }
        private System.Void CalcMeshWorldPositionNormalTangent(System.Boolean isSkinning, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Transform> bones, UnityEngine.Matrix4x4[] bindPoseList, UnityEngine.BoneWeight[] boneWeightList, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector4>& wtanList) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class ReductionData : ReductionMeshAccess
    {
        // Methods
        private System.Void ReductionZeroDistance(System.Single radius) { }
        private System.Void ReductionRadius(System.Single radius) { }
        private System.Void ReductionPolygonLink(System.Single length) { }
        private System.Void ReductionBone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class NearPointReduction
    {
        // Fields
        protected MagicaReductionMesh.MeshData meshData;        // 0x10
        private System.Collections.Generic.List<MagicaReductionMesh.NearPointReduction.Point> pointList;        // 0x18
        protected System.Collections.Generic.Dictionary<UnityEngine.Vector3Int,System.Collections.Generic.List<MagicaReductionMesh.NearPointReduction.Point>> gridMap;        // 0x20
        protected System.Single gridSize;        // 0x28
        private System.Single searchRadius;        // 0x2C
        private System.Collections.Generic.Dictionary<MagicaReductionMesh.NearPointReduction.Point,System.Collections.Generic.List<MagicaReductionMesh.NearPointReduction.Point>> nearPointDict;        // 0x30

        // Methods
        private System.Void .ctor(System.Single radius) { }
        private System.Int32 get_PointCount() { }
        private System.Void Create(MagicaReductionMesh.MeshData meshData) { }
        private System.Void Reduction() { }
        private MagicaReductionMesh.NearPointReduction.Point AddPoint(MagicaReductionMesh.MeshData.ShareVertex sv, UnityEngine.Vector3 pos) { }
        private System.Void AddGrid(MagicaReductionMesh.NearPointReduction.Point p) { }
        private System.Void RemoveGrid(MagicaReductionMesh.NearPointReduction.Point p) { }
        private System.Void Move(MagicaReductionMesh.NearPointReduction.Point p, UnityEngine.Vector3 newpos) { }
        private System.Void Remove(MagicaReductionMesh.NearPointReduction.Point p) { }
        private UnityEngine.Vector3Int GetGridPos(UnityEngine.Vector3 pos) { }
        private System.Void SearchNearPointAll() { }
        private System.Void SearchNearPoint(MagicaReductionMesh.NearPointReduction.Point p, System.Single radius, MagicaReductionMesh.NearPointReduction.Point ignorePoint) { }
        private MagicaReductionMesh.NearPointReduction.Point GetNearPointPair() { }

    }

    // TypeToken: 0x2000022
    public class PolygonLinkReduction
    {
        // Fields
        protected MagicaReductionMesh.MeshData meshData;        // 0x10
        private System.Single reductionLength;        // 0x18
        private System.Collections.Generic.List<MagicaReductionMesh.PolygonLinkReduction.Point> pointList;        // 0x20
        private System.Collections.Generic.Dictionary<MagicaReductionMesh.MeshData.ShareVertex,MagicaReductionMesh.PolygonLinkReduction.Point> pointDict;        // 0x28

        // Methods
        private System.Void .ctor(System.Single length) { }
        private System.Int32 get_PointCount() { }
        private System.Void Create(MagicaReductionMesh.MeshData meshData) { }
        private System.Void Reduction() { }
        private System.Void AddPoint(MagicaReductionMesh.MeshData.ShareVertex sv) { }
        private MagicaReductionMesh.PolygonLinkReduction.Point GetPoint(MagicaReductionMesh.MeshData.ShareVertex sv) { }
        private System.Void Remove(MagicaReductionMesh.PolygonLinkReduction.Point p) { }
        private System.Void SearchNearPointAll() { }
        private System.Void SearchNearPoint(MagicaReductionMesh.PolygonLinkReduction.Point p) { }
        private MagicaReductionMesh.PolygonLinkReduction.Point GetNearPointPair() { }

    }

    // TypeToken: 0x2000024
    public class Utility
    {
        // Methods
        private System.UInt32 PackPair(System.Int32 v0, System.Int32 v1) { }
        private System.Void UnpackPair(System.UInt32 pack, System.Int32& v0, System.Int32& v1) { }
        private System.UInt64 PackTriple(System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        private System.Void UnpackTriple(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2) { }
        private System.UInt64 PackQuater(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3) { }
        private System.Void UnpackQuater(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2, System.Int32& v3) { }
        private System.UInt32 Pack16(System.Int32 hi, System.Int32 low) { }
        private System.Int32 Unpack16Hi(System.UInt32 pack) { }
        private System.Int32 Unpack16Low(System.UInt32 pack) { }
        private System.UInt64 Pack32(System.Int32 hi, System.Int32 low) { }
        private System.Int32 Unpack32Hi(System.UInt64 pack) { }
        private System.Int32 Unpack32Low(System.UInt64 pack) { }
        private System.Void CalcFinalDataWorldPositionNormalTangent(MagicaReductionMesh.FinalData final, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector4>& wtanList) { }
        private System.Void CalcFinalDataChildWorldPositionNormalTangent(MagicaReductionMesh.FinalData final, System.Int32 meshIndex, System.Collections.Generic.List<UnityEngine.Vector3> sposList, System.Collections.Generic.List<UnityEngine.Vector3> snorList, System.Collections.Generic.List<UnityEngine.Vector4> stanList, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector4>& wtanList) { }
        private System.Void CalcLocalPositionNormalTangent(UnityEngine.Transform root, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Collections.Generic.List<UnityEngine.Vector3> wnorList, System.Collections.Generic.List<UnityEngine.Vector4> wtanList) { }
        private System.Void .ctor() { }

    }

}

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002
    public class EmbeddedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class IsUnmanagedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

