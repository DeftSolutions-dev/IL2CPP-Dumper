// ========================================================
// Dumped by @desirepro
// Assembly: BeyondDynamicBone.dll
// Classes:  633
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000C
    public struct GenerateSelectionJob, IJobParallelFor
    {
        // Fields
        public System.Int32 offset;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positionList;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributeList;        // 0x28
        public System.Int32 attributeMapWidth;        // 0x38
        public Unity.Mathematics.float4x4 toM;        // 0x3C
        public Unity.Mathematics.int2 xySize;        // 0x7C
        public BeyondDynamicBone.ExBitFlag8 attributeReadFlag;        // 0x84
        public Unity.Collections.NativeArray<UnityEngine.Color32> attributeMapData;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> uvs;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> vertexs;        // 0xA8

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x200000D
    public class RenderMeshInfo
    {
        // Fields
        public System.Int32 renderHandle;        // 0x10
        public BeyondDynamicBone.VirtualMeshContainer renderMeshContainer;        // 0x18
        public BeyondDynamicBone.DataChunk mappingChunk;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class PaintMapData
    {
        // Fields
        public static System.Byte ReadFlag_Fixed;        // 0x0
        public static System.Byte ReadFlag_Move;        // 0x0
        public static System.Byte ReadFlag_Limit;        // 0x0
        public UnityEngine.Color32[] paintData;        // 0x10
        public System.Int32 paintMapWidth;        // 0x18
        public System.Int32 paintMapHeight;        // 0x1C
        public BeyondDynamicBone.ExBitFlag8 paintReadFlag;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public struct ClothType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.ClothProcess.ClothType MeshCloth;        // 0x0
        public static BeyondDynamicBone.ClothProcess.ClothType BoneCloth;        // 0x0
        public static BeyondDynamicBone.ClothProcess.ClothType BoneSpring;        // 0x0

    }

    // TypeToken: 0x2000017
    public struct PaintMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.ClothSerializeData.PaintMode Manual;        // 0x0
        public static BeyondDynamicBone.ClothSerializeData.PaintMode Texture_Fixed_Move;        // 0x0
        public static BeyondDynamicBone.ClothSerializeData.PaintMode Texture_Fixed_Move_Limit;        // 0x0

    }

    // TypeToken: 0x2000018
    public struct AnimatorAbilityLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.ClothSerializeData.AnimatorAbilityLevel OnlyPlayerOrBoss;        // 0x0
        public static BeyondDynamicBone.ClothSerializeData.AnimatorAbilityLevel AICharOrElite;        // 0x0
        public static BeyondDynamicBone.ClothSerializeData.AnimatorAbilityLevel DefaultOrAtmosphere;        // 0x0

    }

    // TypeToken: 0x2000019
    public class TempBuffer
    {
        // Fields
        private BeyondDynamicBone.ClothProcess.ClothType clothType;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Renderer> sourceRenderers;        // 0x18
        private BeyondDynamicBone.ClothMeshWriteMode meshWriteMode;        // 0x20
        private BeyondDynamicBone.ClothSerializeData.PaintMode paintMode;        // 0x24
        private System.Collections.Generic.List<UnityEngine.Texture2D> paintMaps;        // 0x28
        private System.Collections.Generic.List<UnityEngine.Transform> rootBones;        // 0x30
        private System.Collections.Generic.List<UnityEngine.Transform> ignoreFromRootBones;        // 0x38
        private BeyondDynamicBone.RenderSetupData.BoneConnectionMode connectionMode;        // 0x40
        private System.Single rotationalInterpolation;        // 0x44
        private System.Single rootRotation;        // 0x48
        private BeyondDynamicBone.ClothUpdateMode updateMode;        // 0x4C
        private System.Int32 clothAnimatorLODThreshold;        // 0x50
        private System.Int32 clothAnimatorAbilityLODThreshold;        // 0x54
        private System.Single clothLodFadeTime;        // 0x58
        private System.Single animationPoseRatio;        // 0x5C
        private System.Single clothSimulateWeight;        // 0x60
        private BeyondDynamicBone.ReductionSettings reductionSetting;        // 0x68
        private BeyondDynamicBone.CustomSkinningSettings customSkinningSetting;        // 0x70
        private BeyondDynamicBone.NormalAlignmentSettings normalAlignmentSetting;        // 0x78
        private BeyondDynamicBone.ClothNormalAxis normalAxis;        // 0x80
        private System.Collections.Generic.List<BeyondDynamicBone.ColliderComponent> colliderList;        // 0x88
        private System.Collections.Generic.List<UnityEngine.Transform> collisionBones;        // 0x90
        private BeyondDynamicBone.BeyondBoneCloth synchronization;        // 0x98
        private System.Single stablizationTimeAfterReset;        // 0xA0
        private System.Single blendWeight;        // 0xA4
        private BeyondDynamicBone.CullingSettings cullingSetting;        // 0xA8
        private UnityEngine.Transform anchor;        // 0xB0
        private System.Single anchorInertia;        // 0xB8

        // Methods
        private System.Void .ctor(BeyondDynamicBone.ClothSerializeData sdata) { }
        private System.Void Push(BeyondDynamicBone.ClothSerializeData sdata) { }
        private System.Void Pop(BeyondDynamicBone.ClothSerializeData sdata) { }

    }

    // TypeToken: 0x200001E
    public struct Direction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.BeyondBoneCapsuleCollider.Direction X;        // 0x0
        public static BeyondDynamicBone.BeyondBoneCapsuleCollider.Direction Y;        // 0x0
        public static BeyondDynamicBone.BeyondBoneCapsuleCollider.Direction Z;        // 0x0

    }

    // TypeToken: 0x2000028
    public class RestorationSerializeData, IDataValidate
    {
        // Fields
        public System.Boolean useAngleRestoration;        // 0x10
        public BeyondDynamicBone.CurveSerializeData stiffness;        // 0x18
        public System.Single velocityAttenuation;        // 0x20
        public System.Single gravityFalloff;        // 0x24

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.AngleConstraint.RestorationSerializeData Clone() { }

    }

    // TypeToken: 0x2000029
    public class LimitSerializeData, IDataValidate
    {
        // Fields
        public System.Boolean useAngleLimit;        // 0x10
        public BeyondDynamicBone.CurveSerializeData limitAngle;        // 0x18
        public System.Single stiffness;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.AngleConstraint.LimitSerializeData Clone() { }

    }

    // TypeToken: 0x200002A
    public struct AngleConstraintParams
    {
        // Fields
        public System.Boolean useAngleRestoration;        // 0x10
        public Unity.Mathematics.float4x4 restorationStiffness;        // 0x14
        public System.Single restorationVelocityAttenuation;        // 0x54
        public System.Single restorationGravityFalloff;        // 0x58
        public System.Boolean useAngleLimit;        // 0x5C
        public Unity.Mathematics.float4x4 limitCurveData;        // 0x60
        public System.Single limitstiffness;        // 0xA0

        // Methods
        private System.Void Convert(BeyondDynamicBone.AngleConstraint.RestorationSerializeData restorationData, BeyondDynamicBone.AngleConstraint.LimitSerializeData limitData) { }

    }

    // TypeToken: 0x200002B
    public struct AngleConstraintJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Mathematics.float4 simulationPower;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> stepBaseLineIndexArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x50
        public Unity.Collections.NativeArray<System.Single> vertexDepths;        // 0x60
        public Unity.Collections.NativeArray<System.Int32> vertexParentIndices;        // 0x70
        public Unity.Collections.NativeArray<System.UInt16> baseLineStartDataIndices;        // 0x80
        public Unity.Collections.NativeArray<System.UInt16> baseLineDataCounts;        // 0x90
        public Unity.Collections.NativeArray<System.UInt16> baseLineData;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0xC0
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> stepBasicPositionBuffer;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> stepBasicRotationBuffer;        // 0xF0
        public Unity.Collections.NativeArray<System.Single> lengthBufferArray;        // 0x100
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosBufferArray;        // 0x110
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotBufferArray;        // 0x120
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotationBufferArray;        // 0x130
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> restorationVectorBufferArray;        // 0x140
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x150

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200002E
    public class PointColliderCollisionConstraintKernel_000000DB$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200002F
    public class PointColliderCollisionConstraintKernel_000000DB$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000030
    public class PointColliderCollisionConstraintRangeKernel_000000DC$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000031
    public class PointColliderCollisionConstraintRangeKernel_000000DC$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200002D
    public class PointColliderCollisionConstraintJobKernels
    {
        // Methods
        private System.Void PointColliderCollisionConstraintKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index) { }
        private System.Void PointColliderCollisionConstraintRangeKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr) { }
        private System.Single PointSphereColliderDetection(Unity.Mathematics.float3& nextpos, Unity.Mathematics.float3& basePos, System.Single radius, BeyondDynamicBone.AABB& aabb, BeyondDynamicBone.ColliderManager.WorkData& cwork, System.Boolean isSpring, System.Single maxLength, Unity.Mathematics.float3& normal) { }
        private System.Single PointPlaneColliderDetction(Unity.Mathematics.float3& nextpos, System.Single radius, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }
        private System.Single PointCapsuleColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, BeyondDynamicBone.AABB& aabb, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }
        private System.Void PointColliderCollisionConstraintKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index) { }
        private System.Void PointColliderCollisionConstraintRangeKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000033
    public class EdgeColliderCollisionConstraintKernel_000000E0$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000034
    public class EdgeColliderCollisionConstraintKernel_000000E0$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000035
    public class EdgeColliderCollisionConstraintRangeKernel_000000E1$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000036
    public class EdgeColliderCollisionConstraintRangeKernel_000000E1$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000032
    public class EdgeColliderCollisionConstraintJobKernels
    {
        // Methods
        private System.Void EdgeColliderCollisionConstraintKernel(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index) { }
        private System.Void EdgeColliderCollisionConstraintRangeKernel(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr) { }
        private System.Single EdgeSphereColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.AABB& aabbE, System.Single cfr, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }
        private System.Single EdgeCapsuleColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.AABB& aabbE, System.Single cfr, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }
        private System.Single EdgePlaneColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }
        private System.Void EdgeColliderCollisionConstraintKernel$BurstManaged(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index) { }
        private System.Void EdgeColliderCollisionConstraintRangeKernel$BurstManaged(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000038
    public class SolveEdgeBufferAndClearKernel_000000E5$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000039
    public class SolveEdgeBufferAndClearKernel_000000E5$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index) { }

    }

    // TypeToken: 0x200003A
    public class SolveEdgeBufferAndClearRangeKernel_000000E6$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200003B
    public class SolveEdgeBufferAndClearRangeKernel_000000E6$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000037
    public class SolveEdgeBufferAndClearJobKernels
    {
        // Methods
        private System.Void SolveEdgeBufferAndClearKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index) { }
        private System.Void SolveEdgeBufferAndClearRangeKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr) { }
        private System.Void SolveEdgeBufferAndClearKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index) { }
        private System.Void SolveEdgeBufferAndClearRangeKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200003C
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.ColliderCollisionConstraint.Mode None;        // 0x0
        public static BeyondDynamicBone.ColliderCollisionConstraint.Mode Point;        // 0x0
        public static BeyondDynamicBone.ColliderCollisionConstraint.Mode Edge;        // 0x0

    }

    // TypeToken: 0x200003D
    public class SerializeData, IDataValidate, ITransform
    {
        // Fields
        public BeyondDynamicBone.ColliderCollisionConstraint.Mode mode;        // 0x10
        public System.Single friction;        // 0x14
        public System.Collections.Generic.List<BeyondDynamicBone.ColliderComponent> colliderList;        // 0x18
        public System.Collections.Generic.List<UnityEngine.Transform> collisionBones;        // 0x20
        public BeyondDynamicBone.CurveSerializeData limitDistance;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.ColliderCollisionConstraint.SerializeData Clone() { }
        private System.Int32 GetHashCode() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Int32 get_ColliderLength() { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x200003E
    public struct ColliderCollisionConstraintParams
    {
        // Fields
        public BeyondDynamicBone.ColliderCollisionConstraint.Mode mode;        // 0x10
        public System.Single dynamicFriction;        // 0x14
        public System.Single staticFriction;        // 0x18
        public Unity.Mathematics.float4x4 limitDistance;        // 0x1C

        // Methods
        private System.Void Convert(BeyondDynamicBone.ColliderCollisionConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType) { }

    }

    // TypeToken: 0x200003F
    public struct PointColliderCollisionConstraintJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> stepParticleIndexArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x40
        public Unity.Collections.NativeArray<System.Single> vertexDepths;        // 0x50
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x70
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalArray;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosArray;        // 0xB0
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> colliderFlagArray;        // 0xC0
        public Unity.Collections.NativeArray<BeyondDynamicBone.ColliderManager.WorkData> colliderWorkDataArray;        // 0xD0
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xE0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void UnsafeDo() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Single PointSphereColliderDetection(Unity.Mathematics.float3& nextpos, Unity.Mathematics.float3& basePos, System.Single radius, BeyondDynamicBone.AABB& aabb, BeyondDynamicBone.ColliderManager.WorkData& cwork, System.Boolean isSpring, System.Single maxLength, Unity.Mathematics.float3& normal) { }
        private System.Single PointPlaneColliderDetction(Unity.Mathematics.float3& nextpos, System.Single radius, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }
        private System.Single PointCapsuleColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, BeyondDynamicBone.AABB& aabb, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }

    }

    // TypeToken: 0x2000040
    public struct EdgeColliderCollisionConstraintJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> stepEdgeCollisionIndexArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x40
        public Unity.Collections.NativeArray<System.Single> vertexDepths;        // 0x50
        public Unity.Collections.NativeArray<System.Int16> edgeTeamIdArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.int2> edges;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x80
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalArray;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0xB0
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> colliderFlagArray;        // 0xC0
        public Unity.Collections.NativeArray<BeyondDynamicBone.ColliderManager.WorkData> colliderWorkDataArray;        // 0xD0
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0xE0
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0xF0
        public Unity.Collections.NativeArray<System.Int32> tempFrictionArray;        // 0x100
        public Unity.Collections.NativeArray<System.Int32> tempNormalArray;        // 0x110
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x120

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Single EdgeSphereColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.AABB& aabbE, System.Single cfr, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }
        private System.Single EdgeCapsuleColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.AABB& aabbE, System.Single cfr, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }
        private System.Single EdgePlaneColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000041
    public struct SolveEdgeBufferAndClearJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> jobParticleIndexList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x20
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalArray;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0x50
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x60
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x70
        public Unity.Collections.NativeArray<System.Int32> tempFrictionArray;        // 0x80
        public Unity.Collections.NativeArray<System.Int32> tempNormalArray;        // 0x90
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xA0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000048
    public class SerializeData, IDataValidate
    {
        // Fields
        public BeyondDynamicBone.CurveSerializeData stiffness;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.DistanceConstraint.SerializeData Clone() { }

    }

    // TypeToken: 0x2000049
    public struct DistanceConstraintParams
    {
        // Fields
        public Unity.Mathematics.float4x4 restorationStiffness;        // 0x10
        public System.Single velocityAttenuation;        // 0x50

        // Methods
        private System.Void Convert(BeyondDynamicBone.DistanceConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType) { }

    }

    // TypeToken: 0x200004A
    public class ConstraintData, IValid
    {
        // Fields
        public BeyondDynamicBone.ResultCode result;        // 0x10
        public System.UInt32[] indexArray;        // 0x18
        public System.UInt16[] dataArray;        // 0x20
        public System.Single[] distanceArray;        // 0x28

        // Methods
        private System.Boolean IsValid() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public struct DistanceConstraintJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Mathematics.float4 simulationPower;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> stepParticleIndexArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x50
        public Unity.Collections.NativeArray<System.Single> depthArray;        // 0x60
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosArray;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0xA0
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0xB0
        public Unity.Collections.NativeArray<System.UInt32> indexArray;        // 0xC0
        public Unity.Collections.NativeArray<System.UInt16> dataArray;        // 0xD0
        public Unity.Collections.NativeArray<System.Single> distanceArray;        // 0xE0
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xF0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200004D
    public struct TeleportMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.InertiaConstraint.TeleportMode None;        // 0x0
        public static BeyondDynamicBone.InertiaConstraint.TeleportMode Reset;        // 0x0
        public static BeyondDynamicBone.InertiaConstraint.TeleportMode Keep;        // 0x0

    }

    // TypeToken: 0x200004E
    public class SerializeData, IDataValidate
    {
        // Fields
        public UnityEngine.Transform anchor;        // 0x10
        public System.Single anchorInertia;        // 0x18
        public System.Single worldInertia;        // 0x1C
        public System.Single movementInertiaSmoothing;        // 0x20
        public BeyondDynamicBone.CheckSliderSerializeData movementSpeedLimit;        // 0x28
        public BeyondDynamicBone.CheckSliderSerializeData rotationSpeedLimit;        // 0x30
        public System.Single localInertia;        // 0x38
        public BeyondDynamicBone.CheckSliderSerializeData localMovementSpeedLimit;        // 0x40
        public BeyondDynamicBone.CheckSliderSerializeData localRotationSpeedLimit;        // 0x48
        public System.Single depthInertia;        // 0x50
        public System.Single centrifualAcceleration;        // 0x54
        public BeyondDynamicBone.CheckSliderSerializeData particleSpeedLimit;        // 0x58
        public BeyondDynamicBone.InertiaConstraint.TeleportMode teleportMode;        // 0x60
        public System.Single teleportDistance;        // 0x64
        public System.Single teleportRotation;        // 0x68

        // Methods
        private System.Void .ctor() { }
        private BeyondDynamicBone.InertiaConstraint.SerializeData Clone() { }
        private System.Void DataValidate() { }

    }

    // TypeToken: 0x200004F
    public struct InertiaConstraintParams
    {
        // Fields
        public System.Single anchorInertia;        // 0x10
        public System.Single worldInertia;        // 0x14
        public System.Single movementInertiaSmoothing;        // 0x18
        public System.Single movementSpeedLimit;        // 0x1C
        public System.Single rotationSpeedLimit;        // 0x20
        public System.Single localInertia;        // 0x24
        public System.Single localMovementSpeedLimit;        // 0x28
        public System.Single localRotationSpeedLimit;        // 0x2C
        public System.Single depthInertia;        // 0x30
        public System.Single centrifualAcceleration;        // 0x34
        public System.Single particleSpeedLimit;        // 0x38
        public BeyondDynamicBone.InertiaConstraint.TeleportMode teleportMode;        // 0x3C
        public System.Single teleportDistance;        // 0x40
        public System.Single teleportRotation;        // 0x44

        // Methods
        private System.Void Convert(BeyondDynamicBone.InertiaConstraint.SerializeData sdata) { }

    }

    // TypeToken: 0x2000050
    public struct CenterData
    {
        // Fields
        public Unity.Mathematics.float3 anchorPosition;        // 0x10
        public Unity.Mathematics.quaternion anchorRotation;        // 0x1C
        public Unity.Mathematics.float3 oldAnchorPosition;        // 0x2C
        public Unity.Mathematics.quaternion oldAnchorRotation;        // 0x38
        public Unity.Mathematics.float3 anchorComponentLocalPosition;        // 0x48
        public System.Int32 centerTransformIndex;        // 0x54
        public Unity.Mathematics.float3 componentWorldPosition;        // 0x58
        public Unity.Mathematics.quaternion componentWorldRotation;        // 0x64
        public Unity.Mathematics.float3 componentWorldScale;        // 0x74
        public Unity.Mathematics.float3 oldComponentWorldPosition;        // 0x80
        public Unity.Mathematics.quaternion oldComponentWorldRotation;        // 0x8C
        public Unity.Mathematics.float3 oldComponentWorldScale;        // 0x9C
        public Unity.Mathematics.float3 frameComponentShiftVector;        // 0xA8
        public Unity.Mathematics.quaternion frameComponentShiftRotation;        // 0xB4
        public System.Single frameMovingSpeed;        // 0xC4
        public Unity.Mathematics.float3 frameMovingDirection;        // 0xC8
        public Unity.Mathematics.float3 frameWorldPosition;        // 0xD4
        public Unity.Mathematics.quaternion frameWorldRotation;        // 0xE0
        public Unity.Mathematics.float3 frameWorldScale;        // 0xF0
        public Unity.Mathematics.float3 frameLocalPosition;        // 0xFC
        public Unity.Mathematics.float3 oldFrameWorldPosition;        // 0x108
        public Unity.Mathematics.quaternion oldFrameWorldRotation;        // 0x114
        public Unity.Mathematics.float3 oldFrameWorldScale;        // 0x124
        public Unity.Mathematics.float3 nowWorldPosition;        // 0x130
        public Unity.Mathematics.quaternion nowWorldRotation;        // 0x13C
        public Unity.Mathematics.float3 oldWorldPosition;        // 0x14C
        public Unity.Mathematics.quaternion oldWorldRotation;        // 0x158
        public System.Single stepMoveInertiaRatio;        // 0x168
        public System.Single stepRotationInertiaRatio;        // 0x16C
        public Unity.Mathematics.float3 stepVector;        // 0x170
        public Unity.Mathematics.quaternion stepRotation;        // 0x17C
        public Unity.Mathematics.float3 inertiaVector;        // 0x18C
        public Unity.Mathematics.quaternion inertiaRotation;        // 0x198
        public System.Single stepMovingSpeed;        // 0x1A8
        public Unity.Mathematics.float3 stepMovingDirection;        // 0x1AC
        public System.Single angularVelocity;        // 0x1B8
        public Unity.Mathematics.float3 rotationAxis;        // 0x1BC
        public Unity.Mathematics.float3 initLocalGravityDirection;        // 0x1C8
        public Unity.Mathematics.float3 smoothingVelocity;        // 0x1D4
        public Unity.Mathematics.float4x4 negativeScaleMatrix;        // 0x1E0

        // Methods
        private System.Void Initialize() { }

    }

    // TypeToken: 0x2000051
    public class ConstraintData
    {
        // Fields
        public BeyondDynamicBone.ResultCode result;        // 0x10
        public BeyondDynamicBone.InertiaConstraint.CenterData centerData;        // 0x18
        public Unity.Mathematics.float3 initLocalGravityDirection;        // 0x228

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public class SerializeData, IDataValidate
    {
        // Fields
        public System.Boolean useMaxDistance;        // 0x10
        public BeyondDynamicBone.CurveSerializeData maxDistance;        // 0x18
        public System.Boolean useBackstop;        // 0x20
        public System.Single backstopRadius;        // 0x24
        public BeyondDynamicBone.CurveSerializeData backstopDistance;        // 0x28
        public System.Single stiffness;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.MotionConstraint.SerializeData Clone() { }

    }

    // TypeToken: 0x2000059
    public struct MotionConstraintParams
    {
        // Fields
        public System.Boolean useMaxDistance;        // 0x10
        public Unity.Mathematics.float4x4 maxDistanceCurveData;        // 0x14
        public System.Boolean useBackstop;        // 0x54
        public System.Single backstopRadius;        // 0x58
        public Unity.Mathematics.float4x4 backstopDistanceCurveData;        // 0x5C
        public System.Single stiffness;        // 0x9C

        // Methods
        private System.Void Convert(BeyondDynamicBone.MotionConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType) { }

    }

    // TypeToken: 0x200005A
    public struct MotionConstraintJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> stepParticleIndexArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x40
        public Unity.Collections.NativeArray<System.Single> vertexDepths;        // 0x50
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosArray;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotArray;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0xA0
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalArray;        // 0xC0
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xD0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200005D
    public class IntersectUpdatePrimitiveKernel_00000145$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200005E
    public class IntersectUpdatePrimitiveKernel_00000145$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index) { }

    }

    // TypeToken: 0x200005F
    public class IntersectUpdatePrimitiveRangeKernel_00000146$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000060
    public class IntersectUpdatePrimitiveRangeKernel_00000146$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200005C
    public class IntersectUpdatePrimitiveJobKernels
    {
        // Methods
        private System.Void IntersectUpdatePrimitiveKernel(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index) { }
        private System.Void IntersectUpdatePrimitiveRangeKernel(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr) { }
        private System.Void IntersectUpdatePrimitiveKernel$BurstManaged(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index) { }
        private System.Void IntersectUpdatePrimitiveRangeKernel$BurstManaged(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000062
    public class UpdatePrimitiveKernel_00000147$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000063
    public class UpdatePrimitiveKernel_00000147$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000064
    public class UpdatePrimitiveRangeKernel_00000148$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000065
    public class UpdatePrimitiveRangeKernel_00000148$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000061
    public class UpdatePrimitiveJobKernels
    {
        // Methods
        private System.Void UpdatePrimitiveKernel(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index) { }
        private System.Void UpdatePrimitiveRangeKernel(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr) { }
        private System.Void UpdatePrimitiveKernel$BurstManaged(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index) { }
        private System.Void UpdatePrimitiveRangeKernel$BurstManaged(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000067
    public class ClearBufferKernel_00000149$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000068
    public class ClearBufferKernel_00000149$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000066
    public class ClearBufferJobKernels
    {
        // Methods
        private System.Void ClearBufferKernel() { }
        private System.Void ClearBufferKernel$BurstManaged() { }

    }

    // TypeToken: 0x200006A
    public class SortKernel_0000014A$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200006B
    public class SortKernel_0000014A$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index) { }

    }

    // TypeToken: 0x200006C
    public class SortRangeKernel_0000014B$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200006D
    public class SortRangeKernel_0000014B$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length) { }

    }

    // TypeToken: 0x2000069
    public class SortJobKernels
    {
        // Methods
        private System.Void SortKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index) { }
        private System.Void SortRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length) { }
        private System.Void SortKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index) { }
        private System.Void SortRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length) { }

    }

    // TypeToken: 0x200006E
    public struct SelfCollisionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionMode None;        // 0x0
        public static BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionMode FullMesh;        // 0x0

    }

    // TypeToken: 0x200006F
    public class SerializeData, IDataValidate
    {
        // Fields
        public BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionMode selfMode;        // 0x10
        public BeyondDynamicBone.CurveSerializeData surfaceThickness;        // 0x18
        public BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionMode syncMode;        // 0x20
        public BeyondDynamicBone.BeyondBoneCloth syncPartner;        // 0x28
        public System.Single clothMass;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.SelfCollisionConstraint.SerializeData Clone() { }
        private BeyondDynamicBone.BeyondBoneCloth GetSyncPartner() { }

    }

    // TypeToken: 0x2000070
    public struct SelfCollisionConstraintParams
    {
        // Fields
        public BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionMode selfMode;        // 0x10
        public Unity.Mathematics.float4x4 surfaceThicknessCurveData;        // 0x14
        public BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionMode syncMode;        // 0x54
        public System.Single clothMass;        // 0x58

        // Methods
        private System.Void Convert(BeyondDynamicBone.SelfCollisionConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType) { }

    }

    // TypeToken: 0x2000071
    public struct Primitive
    {
        // Fields
        public System.UInt32 flagAndTeamId;        // 0x10
        public System.Int32 sortIndex;        // 0x14
        public Unity.Mathematics.int3 particleIndices;        // 0x18
        public Unity.Mathematics.float3x3 nextPos;        // 0x24
        public Unity.Mathematics.float3x3 oldPos;        // 0x48
        public Unity.Mathematics.float3 invMass;        // 0x6C
        public System.Single thickness;        // 0x78

        // Methods
        private System.Boolean IsIgnore() { }
        private System.Boolean HasParticle(System.Int32 p) { }
        private System.UInt32 GetKind() { }
        private System.Int32 GetTeamId() { }
        private System.Single GetSolveThickness(BeyondDynamicBone.SelfCollisionConstraint.Primitive& pri) { }
        private System.Boolean AnyParticle(BeyondDynamicBone.SelfCollisionConstraint.Primitive& pri) { }

    }

    // TypeToken: 0x2000072
    public struct SortData, IComparable`1
    {
        // Fields
        public System.UInt32 flagAndTeamId;        // 0x10
        public System.Int32 primitiveIndex;        // 0x14
        public Unity.Mathematics.float2 firstMinMax;        // 0x18
        public Unity.Mathematics.float2 secondMinMax;        // 0x20
        public Unity.Mathematics.float2 thirdMinMax;        // 0x28

        // Methods
        private System.Int32 CompareTo(BeyondDynamicBone.SelfCollisionConstraint.SortData other) { }
        private System.UInt32 GetKind() { }

    }

    // TypeToken: 0x2000073
    public struct EdgeEdgeContact
    {
        // Fields
        public System.UInt32 flagAndTeamId0;        // 0x10
        public System.UInt32 flagAndTeamId1;        // 0x14
        public Unity.Mathematics.half thickness;        // 0x18
        public Unity.Mathematics.half s;        // 0x1A
        public Unity.Mathematics.half t;        // 0x1C
        public Unity.Mathematics.half3 n;        // 0x1E
        public Unity.Mathematics.half2 edgeInvMass0;        // 0x24
        public Unity.Mathematics.half2 edgeInvMass1;        // 0x28
        public Unity.Mathematics.int2 edgeParticleIndex0;        // 0x2C
        public Unity.Mathematics.int2 edgeParticleIndex1;        // 0x34

        // Methods
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000074
    public struct PointTriangleContact
    {
        // Fields
        public System.UInt32 flagAndTeamId0;        // 0x10
        public System.UInt32 flagAndTeamId1;        // 0x14
        public Unity.Mathematics.half thickness;        // 0x18
        public Unity.Mathematics.half sign;        // 0x1A
        public System.Int32 pointParticleIndex;        // 0x1C
        public Unity.Mathematics.int3 triangleParticleIndex;        // 0x20
        public Unity.Mathematics.half pointInvMass;        // 0x2C
        public Unity.Mathematics.half3 triangleInvMass;        // 0x2E

        // Methods
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000075
    public struct InitPrimitiveJob, IJobParallelFor
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public BeyondDynamicBone.TeamManager.TeamData tdata;        // 0x18
        public System.UInt32 kind;        // 0x1E8
        public System.Int32 startPrimitive;        // 0x1EC
        public System.Int32 startSort;        // 0x1F0
        public Unity.Collections.NativeArray<Unity.Mathematics.int2> edges;        // 0x1F8
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x208
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive> primitiveArray;        // 0x218
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData> sortArray;        // 0x228

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000076
    public struct ClearBufferJob, IJob
    {
        // Fields
        public Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactQueue;        // 0x10
        public Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactQueue;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000077
    public struct UpdatePrimitiveJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public System.UInt32 kind;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x28
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x38
        public Unity.Collections.NativeArray<System.Single> depthArray;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x68
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0x78
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive> primitiveArray;        // 0x88
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData> sortAndSweepArray;        // 0x98
        public Unity.Collections.NativeArray<System.UInt32> processingArray;        // 0xA8
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xB8

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000078
    public struct SortJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive> primitiveArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData> sortAndSweepArray;        // 0x30
        public System.Int32 _indexCount;        // 0x40

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000079
    public struct PointTriangleBroadPhaseJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob
    {
        // Fields
        public System.UInt32 mainKind;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x28
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x58
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0x68
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive> primitiveArray;        // 0x78
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData> sortAndSweepArray;        // 0x88
        public Unity.Collections.NativeArray<System.UInt32> processingPointTriangleArray;        // 0x98
        public Unity.Collections.NativeQueue.ParallelWriter<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactQueue;        // 0xA8
        public Unity.Collections.NativeArray<System.Byte> intersectFlagArray;        // 0xC0
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xD0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void SweepTest(System.Int32 sortIndex, BeyondDynamicBone.SelfCollisionConstraint.Primitive& primitive0, BeyondDynamicBone.SelfCollisionConstraint.SortData& sd0, BeyondDynamicBone.DataChunk& subChunk, System.Boolean connectionCheck) { }
        private System.Void BroadPointTriangle(BeyondDynamicBone.SelfCollisionConstraint.Primitive& p_pri, BeyondDynamicBone.SelfCollisionConstraint.Primitive& t_pri, System.Single thickness, System.Single scr, System.Single ang) { }

    }

    // TypeToken: 0x200007A
    public struct EdgeEdgeBroadPhaseJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive> primitiveArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData> sortAndSweepArray;        // 0x30
        public Unity.Collections.NativeArray<System.UInt32> processingEdgeEdgeArray;        // 0x40
        public Unity.Collections.NativeQueue.ParallelWriter<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactQueue;        // 0x50
        public Unity.Collections.NativeArray<System.Byte> intersectFlagArray;        // 0x68
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x78

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void SweepTest(System.Int32 sortIndex, BeyondDynamicBone.SelfCollisionConstraint.Primitive& primitive0, BeyondDynamicBone.SelfCollisionConstraint.SortData& sd0, BeyondDynamicBone.DataChunk& subChunk, System.Boolean connectionCheck) { }
        private System.Void BroadEdgeEdge(BeyondDynamicBone.SelfCollisionConstraint.Primitive& pri0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& pri1, System.Single thickness, System.Single scr) { }

    }

    // TypeToken: 0x200007B
    public struct EdgeEdgeToListJob, IJob
    {
        // Fields
        public Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactQueue;        // 0x10
        public Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactList;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200007C
    public struct PointTriangleToListJob, IJob
    {
        // Fields
        public Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactQueue;        // 0x10
        public Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactList;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200007D
    public struct UpdateEdgeEdgeBroadPhaseJob, IJobParallelForDefer
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x20
        public Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactList;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200007E
    public struct UpdatePointTriangleBroadPhaseJob, IJobParallelForDefer
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x20
        public Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactList;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200007F
    public struct SolverEdgeEdgeJob, IJobParallelForDefer
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000080
    public struct SolverPointTriangleJob, IJobParallelForDefer
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000081
    public struct IntersectUpdatePrimitiveJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public System.UInt32 kind;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x28
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive> primitiveArray;        // 0x38
        public Unity.Collections.NativeArray<System.UInt32> processingArray;        // 0x48
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x58

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000082
    public struct IntersectEdgeTriangleJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob
    {
        // Fields
        public System.UInt32 mainKind;        // 0x10
        public System.Int32 execNumber;        // 0x14
        public System.Int32 div;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive> primitiveArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData> sortAndSweepArray;        // 0x40
        public Unity.Collections.NativeArray<System.UInt32> processingEdgeEdgeArray;        // 0x50
        public Unity.Collections.NativeArray<System.Byte> intersectFlagArray;        // 0x60
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x70

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void SweepTest(BeyondDynamicBone.SelfCollisionConstraint.Primitive& primitive0, BeyondDynamicBone.SelfCollisionConstraint.SortData& sd0, BeyondDynamicBone.DataChunk& subChunk, System.Boolean connectionCheck) { }
        private System.Void IntersectTest(BeyondDynamicBone.SelfCollisionConstraint.Primitive& epri, BeyondDynamicBone.SelfCollisionConstraint.Primitive& tpri) { }

    }

    // TypeToken: 0x2000084
    public class SolverPointTriangleCrossFrameKernel_0000017E$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000085
    public class SolverPointTriangleCrossFrameKernel_0000017E$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000086
    public class SolverPointTriangleCrossFrameRangeKernel_0000017F$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000087
    public class SolverPointTriangleCrossFrameRangeKernel_0000017F$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }

    }

    // TypeToken: 0x2000083
    public class SolverPointTriangleCrossFrameJobKernels
    {
        // Methods
        private System.Void SolverPointTriangleCrossFrameKernel(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void SolverPointTriangleCrossFrameRangeKernel(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }
        private System.Void SolverPointTriangleCrossFrameKernel$BurstManaged(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void SolverPointTriangleCrossFrameRangeKernel$BurstManaged(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }

    }

    // TypeToken: 0x2000089
    public class SolverEdgeEdgeCrossFrameKernel_00000180$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200008A
    public class SolverEdgeEdgeCrossFrameKernel_00000180$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }

    }

    // TypeToken: 0x200008B
    public class SolverEdgeEdgeCrossFrameRangeKernel_00000181$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200008C
    public class SolverEdgeEdgeCrossFrameRangeKernel_00000181$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }

    }

    // TypeToken: 0x2000088
    public class SolverEdgeEdgeCrossFrameJobKernels
    {
        // Methods
        private System.Void SolverEdgeEdgeCrossFrameKernel(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void SolverEdgeEdgeCrossFrameRangeKernel(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }
        private System.Void SolverEdgeEdgeCrossFrameKernel$BurstManaged(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void SolverEdgeEdgeCrossFrameRangeKernel$BurstManaged(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }

    }

    // TypeToken: 0x200008D
    public struct UpdateEdgeEdgeBroadPhaseCrossFrameJob, IJob
    {
        // Fields
        public Unity.Collections.NativeReference<System.Int32> indexCount;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x30
        public Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactList;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void Execute() { }

    }

    // TypeToken: 0x200008E
    public struct UpdatePointTriangleBroadPhaseCrossFrameJob, IJob
    {
        // Fields
        public Unity.Collections.NativeReference<System.Int32> indexCount;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x30
        public Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactList;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void Execute() { }

    }

    // TypeToken: 0x200008F
    public struct SolverEdgeEdgeCrossFrameJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void Execute() { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000090
    public struct SolverPointTriangleCrossFrameJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void Execute() { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000092
    public class SerializeData, IDataValidate
    {
        // Fields
        public System.Boolean useSpring;        // 0x10
        public System.Single springPower;        // 0x14
        public System.Single limitDistance;        // 0x18
        public System.Single normalLimitRatio;        // 0x1C
        public System.Single springNoise;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.SpringConstraint.SerializeData Clone() { }

    }

    // TypeToken: 0x2000093
    public struct SpringConstraintParams
    {
        // Fields
        public System.Single springPower;        // 0x10
        public System.Single limitDistance;        // 0x14
        public System.Single normalLimitRatio;        // 0x18
        public System.Single springNoise;        // 0x1C

        // Methods
        private System.Void Convert(BeyondDynamicBone.SpringConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType) { }

    }

    // TypeToken: 0x200009A
    public class SerializeData, IDataValidate
    {
        // Fields
        public System.Single distanceCompression;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.TetherConstraint.SerializeData Clone() { }

    }

    // TypeToken: 0x200009B
    public struct TetherConstraintParams
    {
        // Fields
        public System.Single compressionLimit;        // 0x10
        public System.Single stretchLimit;        // 0x14

        // Methods
        private System.Void Convert(BeyondDynamicBone.TetherConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType) { }

    }

    // TypeToken: 0x200009C
    public struct TethreConstraintJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> stepParticleIndexArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x50
        public Unity.Collections.NativeArray<System.Single> vertexDepths;        // 0x60
        public Unity.Collections.NativeArray<System.Int32> vertexRootIndices;        // 0x70
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0xA0
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> stepBasicPositionBuffer;        // 0xC0
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xD0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200009F
    public class TriangleBendingKernel_000001AA$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000A0
    public class TriangleBendingKernel_000001AA$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index) { }

    }

    // TypeToken: 0x20000A1
    public class TriangleBendingRangeKernel_000001AB$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000A2
    public class TriangleBendingRangeKernel_000001AB$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200009E
    public class TriangleBendingJobKernels
    {
        // Methods
        private System.Void TriangleBendingKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index) { }
        private System.Void TriangleBendingRangeKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr) { }
        private System.Boolean Volume(Unity.Mathematics.float3x4& nextPosBuffer, Unity.Mathematics.float4& invMassBuffer, System.Single volumeRest, System.Single stiffness, Unity.Mathematics.float3x4& addPosBuffer) { }
        private System.Boolean DihedralAngle(System.Single sign, Unity.Mathematics.float3x4& nextPosBuffer, Unity.Mathematics.float4& invMassBuffer, System.Single restAngle, System.Single stiffness, Unity.Mathematics.float3x4& addPosBuffer) { }
        private System.Void TriangleBendingKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index) { }
        private System.Void TriangleBendingRangeKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x20000A4
    public class SolveAggregateBufferKernel_000001AE$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000A5
    public class SolveAggregateBufferKernel_000001AE$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index) { }

    }

    // TypeToken: 0x20000A6
    public class SolveAggregateBufferRangeKernel_000001AF$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000A7
    public class SolveAggregateBufferRangeKernel_000001AF$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x20000A3
    public class SolveAggregateBufferJobKernels
    {
        // Methods
        private System.Void SolveAggregateBufferKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index) { }
        private System.Void SolveAggregateBufferRangeKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr) { }
        private System.Void SolveAggregateBufferKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index) { }
        private System.Void SolveAggregateBufferRangeKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x20000A8
    public struct Method
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.TriangleBendingConstraint.Method None;        // 0x0
        public static BeyondDynamicBone.TriangleBendingConstraint.Method DihedralAngle;        // 0x0
        public static BeyondDynamicBone.TriangleBendingConstraint.Method DirectionDihedralAngle;        // 0x0

    }

    // TypeToken: 0x20000A9
    public class SerializeData, IDataValidate
    {
        // Fields
        public System.Single stiffness;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.TriangleBendingConstraint.SerializeData Clone() { }

    }

    // TypeToken: 0x20000AA
    public struct TriangleBendingConstraintParams
    {
        // Fields
        public BeyondDynamicBone.TriangleBendingConstraint.Method method;        // 0x10
        public System.Single stiffness;        // 0x14

        // Methods
        private System.Void Convert(BeyondDynamicBone.TriangleBendingConstraint.SerializeData sdata) { }

    }

    // TypeToken: 0x20000AB
    public class ConstraintData, IValid
    {
        // Fields
        public BeyondDynamicBone.ResultCode result;        // 0x10
        public System.UInt64[] trianglePairArray;        // 0x18
        public System.Single[] restAngleOrVolumeArray;        // 0x20
        public System.SByte[] signOrVolumeArray;        // 0x28
        public System.Int32 writeBufferCount;        // 0x30
        public System.UInt32[] writeDataArray;        // 0x38
        public System.UInt32[] writeIndexArray;        // 0x40

        // Methods
        private System.Boolean IsValid() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC
    public struct TriangleBendingJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Mathematics.float4 simulationPower;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> stepTriangleBendIndexArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x50
        public Unity.Collections.NativeArray<System.Single> depthArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x70
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0x80
        public Unity.Collections.NativeArray<System.UInt64> trianglePairArray;        // 0x90
        public Unity.Collections.NativeArray<System.Single> restAngleOrVolumeArray;        // 0xA0
        public Unity.Collections.NativeArray<System.SByte> signOrVolumeArray;        // 0xB0
        public Unity.Collections.NativeArray<System.UInt32> writeDataArray;        // 0xC0
        public Unity.Collections.NativeArray<System.UInt32> writeIndexArray;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;        // 0xE0
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xF0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Boolean Volume(Unity.Mathematics.float3x4& nextPosBuffer, Unity.Mathematics.float4& invMassBuffer, System.Single volumeRest, System.Single stiffness, Unity.Mathematics.float3x4& addPosBuffer) { }
        private System.Boolean DihedralAngle(System.Single sign, Unity.Mathematics.float3x4& nextPosBuffer, Unity.Mathematics.float4& invMassBuffer, System.Single restAngle, System.Single stiffness, Unity.Mathematics.float3x4& addPosBuffer) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20000AD
    public struct SolveAggregateBufferJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> stepParticleIndexArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x30
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x50
        public Unity.Collections.NativeArray<System.UInt32> writeIndexArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x70
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x80

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20000AF
    public struct CameraCullingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.CullingSettings.CameraCullingMode Off;        // 0x0
        public static BeyondDynamicBone.CullingSettings.CameraCullingMode Reset;        // 0x0
        public static BeyondDynamicBone.CullingSettings.CameraCullingMode Keep;        // 0x0
        public static BeyondDynamicBone.CullingSettings.CameraCullingMode AnimatorLinkage;        // 0x0

    }

    // TypeToken: 0x20000B0
    public struct CameraCullingMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.CullingSettings.CameraCullingMethod AutomaticRenderer;        // 0x0
        public static BeyondDynamicBone.CullingSettings.CameraCullingMethod ManualRenderer;        // 0x0

    }

    // TypeToken: 0x20000B1
    public struct CullingParams
    {
        // Fields
        public System.Boolean useDistanceCulling;        // 0x10
        public System.Single distanceCullingLength;        // 0x14
        public System.Single distanceCullingFadeRatio;        // 0x18

        // Methods
        private System.Void Convert(BeyondDynamicBone.CullingSettings cullingSettings) { }

    }

    // TypeToken: 0x20000B7
    public struct AlignmentMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.NormalAlignmentSettings.AlignmentMode None;        // 0x0
        public static BeyondDynamicBone.NormalAlignmentSettings.AlignmentMode BoundingBoxCenter;        // 0x0
        public static BeyondDynamicBone.NormalAlignmentSettings.AlignmentMode Transform;        // 0x0

    }

    // TypeToken: 0x20000B9
    public struct TransformPositionJob, IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float4x4 transformMatrix;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x50

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000BA
    public struct CreateGridMapJob, IJob
    {
        // Fields
        public System.Boolean move;        // 0x10
        public System.Boolean fix;        // 0x11
        public System.Boolean ignore;        // 0x12
        public System.Boolean invalid;        // 0x13
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0x18
        public System.Single gridSize;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attribute;        // 0x40

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000BB
    public struct ConvertSelectionJob, IJobParallelFor
    {
        // Fields
        public System.Single gridSize;        // 0x10
        public System.Single radius;        // 0x14
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> toPositions;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> toAttributes;        // 0x28
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> fromPositions;        // 0x48
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> fromAttributes;        // 0x58

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20000BD
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.BeyondBoneWindZone.Mode GlobalDirection;        // 0x0
        public static BeyondDynamicBone.BeyondBoneWindZone.Mode SphereDirection;        // 0x0
        public static BeyondDynamicBone.BeyondBoneWindZone.Mode BoxDirection;        // 0x0
        public static BeyondDynamicBone.BeyondBoneWindZone.Mode SphereRadial;        // 0x0

    }

    // TypeToken: 0x20000C1
    public struct Result
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.Define.Result None;        // 0x0
        public static BeyondDynamicBone.Define.Result Empty;        // 0x0
        public static BeyondDynamicBone.Define.Result Success;        // 0x0
        public static BeyondDynamicBone.Define.Result Cancel;        // 0x0
        public static BeyondDynamicBone.Define.Result Process;        // 0x0
        public static BeyondDynamicBone.Define.Result Warning;        // 0x0
        public static BeyondDynamicBone.Define.Result RenderMesh_UnknownWarning;        // 0x0
        public static BeyondDynamicBone.Define.Result RenderMesh_VertexWeightIs5BonesOrMore;        // 0x0
        public static BeyondDynamicBone.Define.Result Init_NonUniformScale;        // 0x0
        public static BeyondDynamicBone.Define.Result Error;        // 0x0
        public static BeyondDynamicBone.Define.Result SerializeData_InvalidData;        // 0x0
        public static BeyondDynamicBone.Define.Result SerializeData_Over31Renderers;        // 0x0
        public static BeyondDynamicBone.Define.Result Init_InvalidData;        // 0x0
        public static BeyondDynamicBone.Define.Result Init_InvalidPaintMap;        // 0x0
        public static BeyondDynamicBone.Define.Result Init_PaintMapNotReadable;        // 0x0
        public static BeyondDynamicBone.Define.Result Init_ScaleIsZero;        // 0x0
        public static BeyondDynamicBone.Define.Result Init_NegativeScale;        // 0x0
        public static BeyondDynamicBone.Define.Result RenderSetup_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result RenderSetup_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result RenderSetup_InvalidSource;        // 0x0
        public static BeyondDynamicBone.Define.Result RenderSetup_NoMeshOnRenderer;        // 0x0
        public static BeyondDynamicBone.Define.Result RenderSetup_InvalidType;        // 0x0
        public static BeyondDynamicBone.Define.Result RenderSetup_Unreadable;        // 0x0
        public static BeyondDynamicBone.Define.Result RenderSetup_Over65535vertices;        // 0x0
        public static BeyondDynamicBone.Define.Result VirtualMesh_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result VirtualMesh_InvalidSetup;        // 0x0
        public static BeyondDynamicBone.Define.Result VirtualMesh_InvalidRenderData;        // 0x0
        public static BeyondDynamicBone.Define.Result VirtualMesh_ImportError;        // 0x0
        public static BeyondDynamicBone.Define.Result VirtualMesh_SelectionException;        // 0x0
        public static BeyondDynamicBone.Define.Result VirtualMesh_SelectionUnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result VirtualMesh_InvalidSelection;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_InvalidCloth;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_InvalidSerializeData;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_InvalidSetupList;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_NoRenderer;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_InvalidPaintMap;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_PaintMapNotReadable;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_PaintMapCountMismatch;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_CanNotStart;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_VertexAttributeListCountMismatch;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_VertexAttributeListIsNull;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_VertexAttributeListDataMismatch;        // 0x0
        public static BeyondDynamicBone.Define.Result CreateCloth_InvalidVertexAttributeData;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_InitError;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_SameDistanceException;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_SimpleDistanceException;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_ShapeDistanceException;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_MaxSideLengthZero;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_OrganizationError;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_StoreVirtualMeshError;        // 0x0
        public static BeyondDynamicBone.Define.Result Reduction_CalcAverageException;        // 0x0
        public static BeyondDynamicBone.Define.Result Optimize_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result ProxyMesh_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result ProxyMesh_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result ProxyMesh_ApplySelectionError;        // 0x0
        public static BeyondDynamicBone.Define.Result ProxyMesh_ConvertError;        // 0x0
        public static BeyondDynamicBone.Define.Result ProxyMesh_Over32767Vertices;        // 0x0
        public static BeyondDynamicBone.Define.Result ProxyMesh_Over32767Edges;        // 0x0
        public static BeyondDynamicBone.Define.Result ProxyMesh_Over32767Triangles;        // 0x0
        public static BeyondDynamicBone.Define.Result MappingMesh_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result MappingMesh_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result MappingMesh_ProxyError;        // 0x0
        public static BeyondDynamicBone.Define.Result ClothInit_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result ClothInit_FailedAddRenderer;        // 0x0
        public static BeyondDynamicBone.Define.Result ClothProcess_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result ClothProcess_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result ClothProcess_Invalid;        // 0x0
        public static BeyondDynamicBone.Define.Result ClothProcess_InvalidRenderHandleList;        // 0x0
        public static BeyondDynamicBone.Define.Result ClothProcess_GenerateSelectionError;        // 0x0
        public static BeyondDynamicBone.Define.Result ClothProcess_OverflowTeamCount4096;        // 0x0
        public static BeyondDynamicBone.Define.Result Constraint_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result Constraint_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result Constraint_CreateDistanceException;        // 0x0
        public static BeyondDynamicBone.Define.Result Constraint_CreateTriangleBendingException;        // 0x0
        public static BeyondDynamicBone.Define.Result Constraint_CreateInertiaException;        // 0x0
        public static BeyondDynamicBone.Define.Result Constraint_CreateSelfCollisionException;        // 0x0
        public static BeyondDynamicBone.Define.Result MagicaMesh_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result MagicaMesh_Invalid;        // 0x0
        public static BeyondDynamicBone.Define.Result MagicaMesh_InvalidRenderer;        // 0x0
        public static BeyondDynamicBone.Define.Result MagicaMesh_InvalidMeshFilter;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuildData_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuildData_MagicaClothException;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuildData_VirtualMeshDeserializationException;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuildData_VerificationResult;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuildData_VersionMismatch;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuildData_InvalidClothData;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuildData_Empty;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuildData_InvalidScale;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuild_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuild_Exception;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuild_InvalidPreBuildData;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuild_InvalidRenderSetupData;        // 0x0
        public static BeyondDynamicBone.Define.Result PreBuild_SetupDeserializationError;        // 0x0
        public static BeyondDynamicBone.Define.Result Deserialization_UnknownError;        // 0x0
        public static BeyondDynamicBone.Define.Result Deserialization_Exception;        // 0x0

    }

    // TypeToken: 0x20000C2
    public class System
    {
        // Fields
        public static System.Int32 LatestPreBuildVersion;        // 0x0
        public static System.Single Epsilon;        // 0x0
        public static System.Int32 MaxRendererCount;        // 0x0
        public static System.Single MinimumGridSize;        // 0x0
        public static System.Int32 MaximumTeamCount;        // 0x0
        public static System.Int32 DefaultSimulationFrequency;        // 0x0
        public static System.Int32 SimulationFrequency_Low;        // 0x0
        public static System.Int32 SimulationFrequency_Hi;        // 0x0
        public static System.Int32 DefaultMaxSimulationCountPerFrame;        // 0x0
        public static System.Int32 MaxSimulationCountPerFrame_Low;        // 0x0
        public static System.Int32 MaxSimulationCountPerFrame_Hi;        // 0x0
        public static System.Single SameSurfaceAngle;        // 0x0
        public static System.Single MaxDistanceRatioFutuerPrediction;        // 0x0
        public static System.Boolean ReductionEnable;        // 0x0
        public static System.Single ReductionSameDistance;        // 0x0
        public static System.Boolean ReductionDontMakeLine;        // 0x0
        public static System.Single ReductionJoinPositionAdjustment;        // 0x0
        public static System.Int32 ReductionMaxStep;        // 0x0
        public static System.Int32 MaxProxyMeshVertexCount;        // 0x0
        public static System.Int32 MaxProxyMeshEdgeCount;        // 0x0
        public static System.Int32 MaxProxyMeshTriangleCount;        // 0x0
        public static System.Single ProxyMeshTrianglePairAngle;        // 0x0
        public static System.Single ProxyMeshBoneClothTriangleAngle;        // 0x0
        public static System.Single FrictionMass;        // 0x0
        public static System.Single DepthMass;        // 0x0
        public static System.Single FrictionDampingRate;        // 0x0
        public static System.Single PositionAverageExponent;        // 0x0
        public static System.Single MaxRealVelocity;        // 0x0
        public static System.Single TetherCompressionStiffness;        // 0x0
        public static System.Single TetherStretchStiffness;        // 0x0
        public static System.Single TetherStretchLimit;        // 0x0
        public static System.Single TetherStiffnessWidth;        // 0x0
        public static System.Single TetherCompressionVelocityAttenuation;        // 0x0
        public static System.Single TetherStretchVelocityAttenuation;        // 0x0
        public static System.Single DistanceVelocityAttenuation;        // 0x0
        public static System.Single DistanceVerticalStiffness;        // 0x0
        public static System.Single DistanceHorizontalStiffness;        // 0x0
        public static System.Single TriangleBendingMaxAngle;        // 0x0
        public static System.Single VolumeMinAngle;        // 0x0
        public static System.Single MaxAngleLimit;        // 0x0
        public static System.Int32 AngleLimitIteration;        // 0x0
        public static System.Single AngleLimitAttenuation;        // 0x0
        public static System.Single MaxMovementSpeedLimit;        // 0x0
        public static System.Single MaxRotationSpeedLimit;        // 0x0
        public static System.Single MaxParticleSpeedLimit;        // 0x0
        public static System.Int32 ExpandedColliderCount;        // 0x0
        public static System.Single ColliderCollisionDynamicFrictionRatio;        // 0x0
        public static System.Single ColliderCollisionStaticFrictionRatio;        // 0x0
        public static System.Single CustomSkinningAngularAttenuation;        // 0x0
        public static System.Single CustomSkinningDistanceReduction;        // 0x0
        public static System.Single CustomSkinningDistancePow;        // 0x0
        public static System.Int32 SelfCollisionSolverIteration;        // 0x0
        public static System.Single SelfCollisionFixedMass;        // 0x0
        public static System.Single SelfCollisionFrictionMass;        // 0x0
        public static System.Single SelfCollisionClothMass;        // 0x0
        public static System.Single SelfCollisionSCR;        // 0x0
        public static readonly System.Single SelfCollisionPointTriangleAngleCos;        // 0x0
        public static System.Int32 SelfCollisionIntersectDiv;        // 0x0
        public static System.Single SelfCollisionThicknessMin;        // 0x0
        public static System.Single SelfCollisionThicknessMax;        // 0x0
        public static System.Single WindMaxTime;        // 0x0
        public static System.Single WindBaseSpeed;        // 0x0
        public static System.Single BoneSpringDistanceStiffness;        // 0x0
        public static System.Single BoneSpringTetherCompressionLimit;        // 0x0
        public static System.Single BoneSpringCollisionFriction;        // 0x0
        public static System.Single DistanceCullingMaxLength;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C9
    public class ShareDeserializationData, IDisposable
    {
        // Fields
        private System.String buildId;        // 0x10
        private BeyondDynamicBone.ResultCode result;        // 0x18
        private System.Int32 referenceCount;        // 0x20
        private System.Collections.Generic.List<BeyondDynamicBone.RenderSetupData> renderSetupDataList;        // 0x28
        private BeyondDynamicBone.VirtualMesh proxyMesh;        // 0x30
        private System.Collections.Generic.List<BeyondDynamicBone.VirtualMesh> renderMeshList;        // 0x38
        private BeyondDynamicBone.DistanceConstraint.ConstraintData distanceConstraintData;        // 0x40
        private BeyondDynamicBone.TriangleBendingConstraint.ConstraintData bendingConstraintData;        // 0x48
        private BeyondDynamicBone.InertiaConstraint.ConstraintData inertiaConstraintData;        // 0x50

        // Methods
        private System.Void Dispose() { }
        private System.Void Deserialize(BeyondDynamicBone.SharePreBuildData sharePreBuilddata) { }
        private System.Int32 get_RenderMeshCount() { }
        private BeyondDynamicBone.VirtualMeshContainer GetProxyMeshContainer() { }
        private BeyondDynamicBone.VirtualMeshContainer GetRenderMeshContainer(System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D1
    public class WriteAnimatorBufferDataKernel_0000025C$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000D2
    public class WriteAnimatorBufferDataKernel_0000025C$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }

    }

    // TypeToken: 0x20000D3
    public class WriteAnimatorBufferDataRangeKernel_0000025D$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000D4
    public class WriteAnimatorBufferDataRangeKernel_0000025D$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x20000D0
    public class WriteAnimatorBufferDataJobKernels
    {
        // Methods
        private System.Void WriteAnimatorBufferDataKernel(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }
        private System.Void WriteAnimatorBufferDataRangeKernel(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }
        private System.Void WriteAnimatorBufferDataKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }
        private System.Void WriteAnimatorBufferDataRangeKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x20000D5
    public struct ReadAnimatorBufferDataJob, IJobCrossFrameTransform
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positionArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotationArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> scaleList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositionArray;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotationArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> localToWorldMatrixArray;        // 0x70
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> teamId2AnimatorInstanceId;        // 0x80
        public Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle> animatorID2RWHandler;        // 0x90
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> transformID2RWHandlerID;        // 0xA0
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0xB0
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0xC0

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }
        private System.Void _Do(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000D6
    public struct WriteAnimatorBufferDataJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positionArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotationArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositionArray;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotationArray;        // 0x50
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> teamId2AnimatorInstanceId;        // 0x60
        public Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle> animatorID2RWHandler;        // 0x70
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> transformID2RWHandlerID;        // 0x80
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x90
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0xA0

        // Methods
        private System.Void Execute() { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20000D7
    public struct CopyDoubleBufferJob, IJob
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> worldPositions;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> worldRotations;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotations;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> lastworldPositions;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> lastworldRotations;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> lastlocalPositions;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> lastlocalRotations;        // 0x80

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000D8
    public struct EnableTransformJob, IJob
    {
        // Fields
        public BeyondDynamicBone.DataChunk chunk;        // 0x10
        public System.Boolean sw;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagList;        // 0x20

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000D9
    public struct RestoreTransformJob, IJobParallelForTransform
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositionArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotationArray;        // 0x30
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x50

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000DA
    public struct ReadTransformJob, IJobParallelForTransform
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positionArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotationArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> scaleList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositionArray;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotationArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> localToWorldMatrixArray;        // 0x70
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x80
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x90

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000DC
    public class ValidateTransformKernel_00000266$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000DD
    public class ValidateTransformKernel_00000266$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }

    }

    // TypeToken: 0x20000DE
    public class ValidateTransformRangeKernel_00000267$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000DF
    public class ValidateTransformRangeKernel_00000267$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x20000DB
    public class ValidTransformKernels
    {
        // Methods
        private System.Void ValidateTransformKernel(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }
        private System.Void ValidateTransformRangeKernel(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }
        private System.Void ValidateTransformKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }
        private System.Void ValidateTransformRangeKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x20000E0
    public struct ValidTransformJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> worldPositions;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x30
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x50
        public System.Int32 count;        // 0x60

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void UnsafeDo() { }
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000E1
    public struct WriteTransformJob, IJobParallelForTransform
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> lastpositionArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> lastrotationArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> lastlocalPositionArray;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> lastlocalRotationArray;        // 0x50
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x60
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x70

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000E2
    public struct ReadComponentTransformJob, IJobParallelForTransform
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positionArray;        // 0x10

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000E5
    public class SimulationStepTeamUpdateKernel_00000294$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId) { }
        private System.IAsyncResult BeginInvoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000E6
    public class SimulationStepTeamUpdateKernel_00000294$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId) { }

    }

    // TypeToken: 0x20000E7
    public class SimulationStepTeamUpdateRangeKernel_00000295$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000E8
    public class SimulationStepTeamUpdateRangeKernel_00000295$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length) { }

    }

    // TypeToken: 0x20000E9
    public class UpdateWind_00000296$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime) { }
        private System.IAsyncResult BeginInvoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000EA
    public class UpdateWind_00000296$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime) { }

    }

    // TypeToken: 0x20000EB
    public class UpdateWindTime_00000297$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000EC
    public class UpdateWindTime_00000297$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime) { }

    }

    // TypeToken: 0x20000E4
    public class SimulationStepTeamUpdateKernels
    {
        // Methods
        private System.Void SimulationStepTeamUpdateKernel(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId) { }
        private System.Void SimulationStepTeamUpdateRangeKernel(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length) { }
        private System.Void UpdateWind(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime) { }
        private System.Void UpdateWindTime(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime) { }
        private System.Void SimulationStepTeamUpdateKernel$BurstManaged(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId) { }
        private System.Void SimulationStepTeamUpdateRangeKernel$BurstManaged(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length) { }
        private System.Void UpdateWind$BurstManaged(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime) { }
        private System.Void UpdateWindTime$BurstManaged(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime) { }

    }

    // TypeToken: 0x20000EE
    public class PostTeamUpdateKernel_00000298$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000EF
    public class PostTeamUpdateKernel_00000298$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId) { }

    }

    // TypeToken: 0x20000F0
    public class PostTeamUpdateRangeKernel_00000299$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000F1
    public class PostTeamUpdateRangeKernel_00000299$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x20000ED
    public class PostTeamUpdateJobKernels
    {
        // Methods
        private System.Void PostTeamUpdateKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId) { }
        private System.Void PostTeamUpdateRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length) { }
        private System.Void PostTeamUpdateKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId) { }
        private System.Void PostTeamUpdateRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x20000F2
    public struct TeamData
    {
        // Fields
        public Unity.Collections.BitField64 flag;        // 0x10
        public BeyondDynamicBone.ClothUpdateMode originalUpdateMode;        // 0x18
        public BeyondDynamicBone.ClothUpdateMode updateMode;        // 0x1C
        public System.Single frameDeltaTime;        // 0x20
        public System.Single time;        // 0x24
        public System.Single oldTime;        // 0x28
        public System.Single nowUpdateTime;        // 0x2C
        public System.Single oldUpdateTime;        // 0x30
        public System.Single frameUpdateTime;        // 0x34
        public System.Single frameOldTime;        // 0x38
        public System.Single timeScale;        // 0x3C
        public System.Single nowTimeScale;        // 0x40
        public System.Int32 updateCount;        // 0x44
        public System.Int32 skipCount;        // 0x48
        public System.Single frameInterpolation;        // 0x4C
        public System.Single gravityRatio;        // 0x50
        public System.Single gravityDot;        // 0x54
        public System.Int32 centerTransformIndex;        // 0x58
        public System.Int32 distanceReferenceObjectId;        // 0x5C
        public System.Int32 componentTransformIndex;        // 0x60
        public Unity.Mathematics.float3 initScale;        // 0x64
        public System.Single scaleRatio;        // 0x70
        public System.Single negativeScaleSign;        // 0x74
        public Unity.Mathematics.float3 negativeScaleDirection;        // 0x78
        public Unity.Mathematics.float3 negativeScaleChange;        // 0x84
        public Unity.Mathematics.float2 negativeScaleTriangleSign;        // 0x90
        public Unity.Mathematics.float4 negativeScaleQuaternionValue;        // 0x98
        public System.Int32 componentId;        // 0xA8
        public System.Int32 useRelativeTransform;        // 0xAC
        public Unity.Mathematics.float3 relativeTransformPos;        // 0xB0
        public Unity.Mathematics.quaternion relativeTransformRot;        // 0xBC
        public System.Int32 syncTeamId;        // 0xCC
        public Unity.Collections.FixedList32Bytes<System.Int32> syncParentTeamId;        // 0xD0
        public System.Int32 syncCenterTransformIndex;        // 0xF0
        public System.Int32 interlockingAnimatorId;        // 0xF4
        public System.Single animationPoseRatio;        // 0xF8
        public System.Single clothSimulateWeight;        // 0xFC
        public System.Single clothLodFadeWeight;        // 0x100
        public System.Single clothLodFadeTime;        // 0x104
        public System.Single velocityWeight;        // 0x108
        public System.Single distanceWeight;        // 0x10C
        public System.Single blendWeight;        // 0x110
        public BeyondDynamicBone.ClothForceMode forceMode;        // 0x114
        public Unity.Mathematics.float3 impactForce;        // 0x118
        public BeyondDynamicBone.VirtualMesh.MeshType proxyMeshType;        // 0x124
        public BeyondDynamicBone.DataChunk proxyTransformChunk;        // 0x128
        public BeyondDynamicBone.DataChunk proxyCommonChunk;        // 0x130
        public BeyondDynamicBone.DataChunk proxyVertexChildDataChunk;        // 0x138
        public BeyondDynamicBone.DataChunk proxyTriangleChunk;        // 0x140
        public BeyondDynamicBone.DataChunk proxyEdgeChunk;        // 0x148
        public BeyondDynamicBone.DataChunk proxyMeshChunk;        // 0x150
        public BeyondDynamicBone.DataChunk proxyBoneChunk;        // 0x158
        public BeyondDynamicBone.DataChunk proxySkinBoneChunk;        // 0x160
        public BeyondDynamicBone.DataChunk baseLineChunk;        // 0x168
        public BeyondDynamicBone.DataChunk baseLineDataChunk;        // 0x170
        public BeyondDynamicBone.DataChunk fixedDataChunk;        // 0x178
        public BeyondDynamicBone.DataChunk particleChunk;        // 0x180
        public BeyondDynamicBone.DataChunk colliderChunk;        // 0x188
        public BeyondDynamicBone.DataChunk colliderTransformChunk;        // 0x190
        public System.Int32 colliderCount;        // 0x198
        public BeyondDynamicBone.DataChunk distanceStartChunk;        // 0x19C
        public BeyondDynamicBone.DataChunk distanceDataChunk;        // 0x1A4
        public BeyondDynamicBone.DataChunk bendingPairChunk;        // 0x1AC
        public BeyondDynamicBone.DataChunk bendingWriteIndexChunk;        // 0x1B4
        public BeyondDynamicBone.DataChunk bendingBufferChunk;        // 0x1BC
        public BeyondDynamicBone.DataChunk selfPointChunk;        // 0x1C4
        public BeyondDynamicBone.DataChunk selfEdgeChunk;        // 0x1CC
        public BeyondDynamicBone.DataChunk selfTriangleChunk;        // 0x1D4

        // Methods
        private System.Boolean get_bUseRelativeTransform() { }
        private System.Boolean get_IsFixedUpdate() { }
        private System.Boolean get_IsUnscaled() { }
        private System.Boolean get_IsValid() { }
        private System.Boolean get_IsEnable() { }
        private System.Boolean get_IsLODCulled() { }
        private System.Boolean get_IsProcess() { }
        private System.Boolean get_IsReset() { }
        private System.Boolean get_IsKeepReset() { }
        private System.Boolean get_IsInertiaShift() { }
        private System.Boolean get_IsRunning() { }
        private System.Boolean get_IsStepRunning() { }
        private System.Boolean get_IsCameraCullingInvisible() { }
        private System.Boolean get_IsCameraCullingKeep() { }
        private System.Boolean get_IsDistanceCullingInvisible() { }
        private System.Boolean get_IsCullingInvisible() { }
        private System.Boolean get_IsSpring() { }
        private System.Boolean get_IsNegativeScale() { }
        private System.Boolean get_IsNegativeScaleTeleport() { }
        private System.Boolean get_IsTangent() { }
        private System.Int32 get_ParticleCount() { }
        private System.Int32 get_ColliderCount() { }
        private System.Int32 get_BaseLineCount() { }
        private System.Int32 get_TriangleCount() { }
        private System.Int32 get_EdgeCount() { }
        private System.Single get_InitScale() { }

    }

    // TypeToken: 0x20000F3
    public struct MappingData, IValid
    {
        // Fields
        public System.Int32 teamId;        // 0x10
        public System.Int32 centerTransformIndex;        // 0x14
        public BeyondDynamicBone.DataChunk mappingCommonChunk;        // 0x18
        public Unity.Mathematics.float4x4 toProxyMatrix;        // 0x20
        public Unity.Mathematics.quaternion toProxyRotation;        // 0x60
        public System.Boolean sameSpace;        // 0x70
        public Unity.Mathematics.float4x4 toMappingMatrix;        // 0x74
        public Unity.Mathematics.quaternion toMappingRotation;        // 0xB4
        public System.Single scaleRatio;        // 0xC4

        // Methods
        private System.Boolean IsValid() { }
        private System.Int32 get_VertexCount() { }

    }

    // TypeToken: 0x20000F4
    public struct AlwaysTeamUpdatePreJob, IJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x20
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2SuspendCounterMap;        // 0x30
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2TeamIdMap;        // 0x40
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2SyncPartnerCompMap;        // 0x50
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2SyncTopCompMap;        // 0x60
        public Unity.Collections.NativeParallelHashSet<System.Int32> selfCollisionUpdateSet;        // 0x70
        public Unity.Collections.NativeReference<System.Int32> edgeColliderCollisionCountBuff;        // 0x80

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000F5
    public struct AlwaysTeamUpdatePostJob, IJob
    {
        // Fields
        public System.Int32 teamCount;        // 0x10
        public System.Single unityFrameDeltaTime;        // 0x14
        public System.Single unityFrameFixedDeltaTime;        // 0x18
        public System.Single unityFrameUnscaledDeltaTime;        // 0x1C
        public System.Single globalTimeScale;        // 0x20
        public System.Single simulationDeltaTime;        // 0x24
        public System.Int32 maxSimmulationCountPerFrame;        // 0x28
        public Unity.Collections.NativeReference<System.Int32> maxUpdateCount;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x50
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> componentPositionArray;        // 0x70
        public System.Boolean hasMainCamera;        // 0x80
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2TeamIdMap;        // 0x88
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2SyncTopCompMap;        // 0x98
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> animatorUpdateModeMap;        // 0xA8
        public Unity.Collections.NativeArray<System.Int32> teamAnchorTransformIndexArray;        // 0xB8
        public Unity.Collections.NativeArray<System.Int32> teamDistanceTransformIndexArray;        // 0xC8
        public Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.float3> transformPositionMap;        // 0xD8
        public Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.quaternion> transformRotationMap;        // 0xE8
        public Unity.Collections.NativeList<System.Int32> cullingDirtyList;        // 0xF8

        // Methods
        private System.Void Execute() { }
        private System.Void DistanceCullingUpdate(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata) { }

    }

    // TypeToken: 0x20000F7
    public class CalcCenterAndInertiaAndWindKernel_000002B9$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId) { }
        private System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000F8
    public class CalcCenterAndInertiaAndWindKernel_000002B9$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId) { }

    }

    // TypeToken: 0x20000F9
    public class CalcCenterAndInertiaAndWindRangeKernel_000002BA$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000FA
    public class CalcCenterAndInertiaAndWindRangeKernel_000002BA$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x20000FB
    public class Wind_000002BB$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray) { }
        private System.IAsyncResult BeginInvoke(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20000FC
    public class Wind_000002BB$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray) { }

    }

    // TypeToken: 0x20000F6
    public class CalcCenterAndInertiaAndWindKernels
    {
        // Methods
        private System.Void CalcCenterAndInertiaAndWindKernel(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId) { }
        private System.Void CalcCenterAndInertiaAndWindRangeKernel(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length) { }
        private System.Void Wind(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray) { }
        private System.Void CalcCenterAndInertiaAndWindKernel$BurstManaged(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId) { }
        private System.Void CalcCenterAndInertiaAndWindRangeKernel$BurstManaged(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length) { }
        private System.Void Wind$BurstManaged(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray) { }

    }

    // TypeToken: 0x20000FD
    public struct CalcCenterAndInertiaAndWindJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public System.Single simulationDeltaTime;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x28
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamWindData> teamWindArray;        // 0x38
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexBindPoseRotations;        // 0x78
        public Unity.Collections.NativeArray<System.UInt16> fixedArray;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPositionArray;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotationArray;        // 0xA8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformScaleArray;        // 0xB8
        public System.Int32 windZoneCount;        // 0xC8
        public Unity.Collections.NativeArray<BeyondDynamicBone.WindManager.WindData> windDataArray;        // 0xD0
        public System.Int32 _indexCount;        // 0xE0

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 teamId) { }
        private System.Void Wind(System.Int32 teamId, BeyondDynamicBone.ClothParameters& param, Unity.Mathematics.float3& centerWorldPos) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20000FE
    public struct SimulationStepTeamUpdateJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public System.Int32 updateIndex;        // 0x10
        public System.Single simulationDeltaTime;        // 0x14
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x28
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x38
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamWindData> teamWindArray;        // 0x48
        public System.Int32 _indexCount;        // 0x58

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 teamId) { }
        private System.Void UpdateWind(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata) { }
        private System.Void UpdateWindTime(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20000FF
    public struct PostTeamUpdateJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x20
        public System.Int32 _indexCount;        // 0x30

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 teamId) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000103
    public class CalcProxyMeshSkinningKernel_000002E4$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000104
    public class CalcProxyMeshSkinningKernel_000002E4$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000105
    public class CalcProxyMeshSkinningRangeKernel_000002E5$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000106
    public class CalcProxyMeshSkinningRangeKernel_000002E5$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000102
    public class CalcProxyMeshSkinningKernels
    {
        // Methods
        private System.Void CalcProxyMeshSkinningKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index) { }
        private System.Void CalcProxyMeshSkinningRangeKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr) { }
        private System.Void CalcProxyMeshSkinningKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index) { }
        private System.Void CalcProxyMeshSkinningRangeKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000108
    public class CreatePostProxyMeshUpdateListKernel_000002E6$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000109
    public class CreatePostProxyMeshUpdateListKernel_000002E6$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId) { }

    }

    // TypeToken: 0x200010A
    public class CreatePostProxyMeshUpdateListRangeKernel_000002E7$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200010B
    public class CreatePostProxyMeshUpdateListRangeKernel_000002E7$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length) { }

    }

    // TypeToken: 0x2000107
    public class CreatePostProxyMeshUpdateListJobKernels
    {
        // Methods
        private System.Void CreatePostProxyMeshUpdateListKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId) { }
        private System.Void CreatePostProxyMeshUpdateListRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length) { }
        private System.Void CreatePostProxyMeshUpdateListKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId) { }
        private System.Void CreatePostProxyMeshUpdateListRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length) { }

    }

    // TypeToken: 0x200010D
    public class CalcLineNormalTangentKernel_000002E8$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200010E
    public class CalcLineNormalTangentKernel_000002E8$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index) { }

    }

    // TypeToken: 0x200010F
    public class CalcLineNormalTangentRangeKernel_000002E9$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000110
    public class CalcLineNormalTangentRangeKernel_000002E9$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200010C
    public class CalcLineNormalTangentJobKernels
    {
        // Methods
        private System.Void CalcLineNormalTangentKernel(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index) { }
        private System.Void CalcLineNormalTangentRangeKernel(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr) { }
        private System.Void CalcLineNormalTangentKernel$BurstManaged(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index) { }
        private System.Void CalcLineNormalTangentRangeKernel$BurstManaged(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000112
    public class WriteTransformDataKernel_000002EA$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000113
    public class WriteTransformDataKernel_000002EA$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index) { }

    }

    // TypeToken: 0x2000114
    public class WriteTransformDataRangeKernel_000002EB$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000115
    public class WriteTransformDataRangeKernel_000002EB$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000111
    public class WriteTransformDataJobKernels
    {
        // Methods
        private System.Void WriteTransformDataKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index) { }
        private System.Void WriteTransformDataRangeKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr) { }
        private System.Void WriteTransformDataKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index) { }
        private System.Void WriteTransformDataRangeKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000117
    public class WriteTransformLocalDataKernel_000002EC$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000118
    public class WriteTransformLocalDataKernel_000002EC$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000119
    public class WriteTransformLocalDataRangeKernel_000002ED$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200011A
    public class WriteTransformLocalDataRangeKernel_000002ED$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000116
    public class WriteTransformLocalDataJobKernels
    {
        // Methods
        private System.Void WriteTransformLocalDataKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index) { }
        private System.Void WriteTransformLocalDataRangeKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr) { }
        private System.Void WriteTransformLocalDataKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index) { }
        private System.Void WriteTransformLocalDataRangeKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200011C
    public class CalcProxySkinningKernel_000002EE$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200011D
    public class CalcProxySkinningKernel_000002EE$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex) { }

    }

    // TypeToken: 0x200011E
    public class CalcProxySkinningRangeKernel_000002EF$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200011F
    public class CalcProxySkinningRangeKernel_000002EF$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length) { }

    }

    // TypeToken: 0x200011B
    public class CalcProxySkinningJobKernels
    {
        // Methods
        private System.Void CalcProxySkinningKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex) { }
        private System.Void CalcProxySkinningRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length) { }
        private System.Void CalcProxySkinningKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex) { }
        private System.Void CalcProxySkinningRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length) { }

    }

    // TypeToken: 0x2000121
    public class CalcMeshConvertMatrixKernel_000002F0$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000122
    public class CalcMeshConvertMatrixKernel_000002F0$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000123
    public class CalcMeshConvertMatrixRangeKernel_000002F1$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000124
    public class CalcMeshConvertMatrixRangeKernel_000002F1$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length) { }

    }

    // TypeToken: 0x2000120
    public class CalcMeshConvertMatrixJobKernels
    {
        // Methods
        private System.Void CalcMeshConvertMatrixKernel(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index) { }
        private System.Void CalcMeshConvertMatrixRangeKernel(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length) { }
        private System.Void CalcMeshConvertMatrixKernel$BurstManaged(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index) { }
        private System.Void CalcMeshConvertMatrixRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length) { }

    }

    // TypeToken: 0x2000126
    public class CalcTriangleNormalTangentKernel_000002F2$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000127
    public class CalcTriangleNormalTangentKernel_000002F2$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index) { }

    }

    // TypeToken: 0x2000128
    public class CalcTriangleNormalTangentRangeKernel_000002F3$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000129
    public class CalcTriangleNormalTangentRangeKernel_000002F3$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000125
    public class CalcTriangleNormalTangentJobKernels
    {
        // Methods
        private System.Void CalcTriangleNormalTangentKernel(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index) { }
        private System.Void CalcTriangleNormalTangentRangeKernel(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr) { }
        private System.Void CalcTriangleNormalTangentKernel$BurstManaged(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index) { }
        private System.Void CalcTriangleNormalTangentRangeKernel$BurstManaged(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200012B
    public class CalcVertexNormalTangentFromTriangleKernel_000002F4$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200012C
    public class CalcVertexNormalTangentFromTriangleKernel_000002F4$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index) { }

    }

    // TypeToken: 0x200012D
    public class CalcVertexNormalTangentFromTriangleRangeKernel_000002F5$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200012E
    public class CalcVertexNormalTangentFromTriangleRangeKernel_000002F5$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200012A
    public class CalcVertexNormalTangentFromTriangleJobKernels
    {
        // Methods
        private System.Void CalcVertexNormalTangentFromTriangleKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index) { }
        private System.Void CalcVertexNormalTangentFromTriangleRangeKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr) { }
        private System.Void CalcVertexNormalTangentFromTriangleKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index) { }
        private System.Void CalcVertexNormalTangentFromTriangleRangeKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000130
    public class ClearProxyMeshUpdateBufferKernel_000002F6$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3) { }
        private System.IAsyncResult BeginInvoke(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000131
    public class ClearProxyMeshUpdateBufferKernel_000002F6$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3) { }

    }

    // TypeToken: 0x200012F
    public class ClearProxyMeshUpdateBufferJobKernels
    {
        // Methods
        private System.Void ClearProxyMeshUpdateBufferKernel(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3) { }
        private System.Void ClearProxyMeshUpdateBufferKernel$BurstManaged(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3) { }

    }

    // TypeToken: 0x2000132
    public struct ClearProxyMeshUpdateBufferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeReference<System.Int32> processingCounter0;        // 0x10
        public Unity.Collections.NativeReference<System.Int32> processingCounter1;        // 0x20
        public Unity.Collections.NativeReference<System.Int32> processingCounter2;        // 0x30
        public Unity.Collections.NativeReference<System.Int32> processingCounter3;        // 0x40

        // Methods
        private System.Void Execute() { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000133
    public struct CreateProxyMeshUpdateVertexList, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeReference<System.Int32> processingCounter1;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> processingList1;        // 0x30
        public System.Int32 _indexCount;        // 0x40

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 teamId) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000134
    public struct CalcProxyMeshSkinningJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> jobVertexIndexList;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int16> teamIds;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0x70
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x80
        public Unity.Collections.NativeArray<System.Int32> skinBoneTransformIndices;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> skinBoneBindPoses;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> transformLocalToWorldMatrixArray;        // 0xD0
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xE0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000135
    public struct CreatePostProxyMeshUpdateListJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeReference<System.Int32> processingCounter0;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> processingList0;        // 0x30
        public Unity.Collections.NativeReference<System.Int32> processingCounter1;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> processingList1;        // 0x50
        public Unity.Collections.NativeReference<System.Int32> processingCounter2;        // 0x60
        public Unity.Collections.NativeArray<System.Int32> processingList2;        // 0x70
        public Unity.Collections.NativeReference<System.Int32> processingCounter3;        // 0x80
        public Unity.Collections.NativeArray<System.Int32> processingList3;        // 0x90
        public System.Int32 _indexCount;        // 0xA0

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 teamId) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000136
    public struct CalcLineNormalTangentJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> jobBaseLineList;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> vertexLocalPositions;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexLocalRotations;        // 0x80
        public Unity.Collections.NativeArray<System.Int32> parentIndices;        // 0x90
        public Unity.Collections.NativeArray<System.UInt32> childIndexArray;        // 0xA0
        public Unity.Collections.NativeArray<System.UInt16> childDataArray;        // 0xB0
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> baseLineFlags;        // 0xC0
        public Unity.Collections.NativeArray<System.Int16> baseLineTeamIds;        // 0xD0
        public Unity.Collections.NativeArray<System.UInt16> baseLineStartIndices;        // 0xE0
        public Unity.Collections.NativeArray<System.UInt16> baseLineDataCounts;        // 0xF0
        public Unity.Collections.NativeArray<System.UInt16> baseLineData;        // 0x100
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x110

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000137
    public struct CalcTriangleNormalTangentJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> jobTriangleList;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int16> triangleTeamIdArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outTriangleNormals;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outTriangleTangents;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> uv;        // 0x80
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x90

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000138
    public struct CalcVertexNormalTangentFromTriangleJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> jobVertexIndexList;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int16> teamIds;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleNormals;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleTangents;        // 0x50
        public Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>> vertexToTriangles;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> normalAdjustmentRotations;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> outRotations;        // 0x80
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x90

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000139
    public struct WriteTransformDataJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> jobVertexIndexList;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPositionArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotationArray;        // 0x40
        public Unity.Collections.NativeArray<System.Int16> teamIds;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexToTransformRotations;        // 0x80
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x90

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200013A
    public struct WriteTransformLocalDataJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> jobVertexIndexList;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int16> teamIds;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> vertexParentIndices;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPositionArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotationArray;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformScaleArray;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformLocalPositionArray;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformLocalRotationArray;        // 0xA0
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xB0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200013B
    public struct CalcMeshConvertMatrixJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.MappingData> mappingDataArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPositionArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotationArray;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformScaleArray;        // 0x50
        public System.Int32 _indexCount;        // 0x60

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200013C
    public struct CalcProxySkinningJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.MappingData> mappingDataArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int16> mappingIdArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> mappingAttributes;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingLocalPositions;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingLocalNormals;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingLocalTangents;        // 0x70
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> mappingBoneWeights;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingPositions;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingNormals;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingTangents;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> proxyPositions;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> proxyRotations;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> proxyVertexBindPosePositions;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> proxyVertexBindPoseRotations;        // 0xF0
        public System.Int32 _indexCount;        // 0x100

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 mvindex) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200013F
    public class UpdateMethod : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000140
    public struct InitializationLocation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.MagicaManager.InitializationLocation Start;        // 0x0
        public static BeyondDynamicBone.MagicaManager.InitializationLocation Awake;        // 0x0

    }

    // TypeToken: 0x2000144
    public struct RefreshMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.MagicaSettings.RefreshMode OnAwake;        // 0x0
        public static BeyondDynamicBone.MagicaSettings.RefreshMode EveryFrame;        // 0x0
        public static BeyondDynamicBone.MagicaSettings.RefreshMode OnStart;        // 0x0
        public static BeyondDynamicBone.MagicaSettings.RefreshMode Manual;        // 0x0

    }

    // TypeToken: 0x2000155
    public struct UpdatePositionNormalJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public System.Int32 startIndex;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> meshLocalPositions;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> meshLocalNormals;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> mappingReferenceIndices;        // 0x38
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> mappingAttributes;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingPositions;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingNormals;        // 0x68
        public System.Int32 _indexCount;        // 0x78

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000156
    public struct UpdatePositionNormalTangentJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public System.Int32 startIndex;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> meshLocalPositions;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> meshLocalNormals;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float4> meshLocalTangents;        // 0x38
        public Unity.Collections.NativeArray<System.Int32> mappingReferenceIndices;        // 0x48
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> mappingAttributes;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingPositions;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingNormals;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> mappingTangents;        // 0x88
        public System.Int32 _indexCount;        // 0x98

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000157
    public struct UpdateBoneWeightJob2, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public System.Int32 startIndex;        // 0x10
        public UnityEngine.BoneWeight centerBoneWeight;        // 0x14
        public Unity.Collections.NativeArray<UnityEngine.BoneWeight> meshBoneWeights;        // 0x38
        public Unity.Collections.NativeArray<System.Int32> mappingReferenceIndices;        // 0x48
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> mappingAttributes;        // 0x58
        public System.Int32 _indexCount;        // 0x68

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200015B
    public struct SetupType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.RenderSetupData.SetupType MeshCloth;        // 0x0
        public static BeyondDynamicBone.RenderSetupData.SetupType BoneCloth;        // 0x0
        public static BeyondDynamicBone.RenderSetupData.SetupType BoneSpring;        // 0x0

    }

    // TypeToken: 0x200015C
    public struct BoneConnectionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.RenderSetupData.BoneConnectionMode Line;        // 0x0
        public static BeyondDynamicBone.RenderSetupData.BoneConnectionMode AutomaticMesh;        // 0x0
        public static BeyondDynamicBone.RenderSetupData.BoneConnectionMode SequentialLoopMesh;        // 0x0
        public static BeyondDynamicBone.RenderSetupData.BoneConnectionMode SequentialNonLoopMesh;        // 0x0

    }

    // TypeToken: 0x200015D
    public struct VertexWeight5BoneCheckJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public Unity.Collections.NativeArray<System.Byte> bonesPerVertexArray;        // 0x18
        public Unity.Collections.NativeReference<BeyondDynamicBone.Define.Result> result;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200015E
    public struct ReadTransformJob, IJobParallelForTransform
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> scales;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotations;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> inverseRotations;        // 0x60

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x200015F
    public struct GetBoneWeightJos, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public Unity.Collections.NativeArray<System.Byte> bonesPerVertexArray;        // 0x18
        public Unity.Collections.NativeArray<UnityEngine.BoneWeight1> boneWeightArray;        // 0x28
        public Unity.Collections.NativeArray<UnityEngine.BoneWeight> boneWeights;        // 0x38

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000160
    public class ShareSerializationData
    {
        // Fields
        public BeyondDynamicBone.ResultCode result;        // 0x10
        public System.String name;        // 0x18
        public BeyondDynamicBone.RenderSetupData.SetupType setupType;        // 0x20
        public UnityEngine.Mesh originalMesh;        // 0x28
        public System.Int32 vertexCount;        // 0x30
        public System.Boolean hasSkinnedMesh;        // 0x34
        public System.Boolean hasBoneWeight;        // 0x35
        public System.Int32 skinRootBoneIndex;        // 0x38
        public System.Int32 skinBoneCount;        // 0x3C
        public System.Collections.Generic.List<UnityEngine.Matrix4x4> bindPoseList;        // 0x40
        public System.Byte[] bonesPerVertexArray;        // 0x48
        public System.Byte[] boneWeightArray;        // 0x50
        public UnityEngine.Vector3[] localPositions;        // 0x58
        public UnityEngine.Vector3[] localNormals;        // 0x60
        public UnityEngine.Vector4[] localTangents;        // 0x68
        public BeyondDynamicBone.RenderSetupData.BoneConnectionMode boneConnectionMode;        // 0x70
        public System.Int32 renderTransformIndex;        // 0x74

        // Methods
        private System.Boolean get_HasTangent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000161
    public class UniqueSerializationData, ITransform
    {
        // Fields
        public BeyondDynamicBone.ResultCode result;        // 0x10
        public UnityEngine.Renderer renderer;        // 0x18
        public UnityEngine.SkinnedMeshRenderer skinRenderer;        // 0x20
        public UnityEngine.MeshFilter meshFilter;        // 0x28
        public UnityEngine.Mesh originalMesh;        // 0x30
        public System.Collections.Generic.List<UnityEngine.Transform> transformList;        // 0x38

        // Methods
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016A
    public class PreSimulationUpdateKernel_000003D1$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200016B
    public class PreSimulationUpdateKernel_000003D1$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index) { }

    }

    // TypeToken: 0x200016C
    public class PreSimulationUpdateRangeKernel_000003D2$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200016D
    public class PreSimulationUpdateRangeKernel_000003D2$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x2000169
    public class ColliderKernels
    {
        // Methods
        private System.Void PreSimulationUpdateKernel(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index) { }
        private System.Void PreSimulationUpdateRangeKernel(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length) { }
        private System.Void PreSimulationUpdateKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index) { }
        private System.Void PreSimulationUpdateRangeKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x200016F
    public class CreateUpdatecolliderListKernel_000003D3$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId) { }
        private System.IAsyncResult BeginInvoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000170
    public class CreateUpdatecolliderListKernel_000003D3$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId) { }

    }

    // TypeToken: 0x2000171
    public class CreateUpdatecolliderListRangeKernel_000003D4$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000172
    public class CreateUpdatecolliderListRangeKernel_000003D4$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length) { }

    }

    // TypeToken: 0x200016E
    public class CreateUpdatecolliderListJobKernels
    {
        // Methods
        private System.Void CreateUpdatecolliderListKernel(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId) { }
        private System.Void CreateUpdatecolliderListRangeKernel(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length) { }
        private System.Void CreateUpdatecolliderListKernel$BurstManaged(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId) { }
        private System.Void CreateUpdatecolliderListRangeKernel$BurstManaged(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length) { }

    }

    // TypeToken: 0x2000174
    public class StartSimulationStepKernel_000003D5$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000175
    public class StartSimulationStepKernel_000003D5$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000176
    public class StartSimulationStepRangeKernel_000003D6$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000177
    public class StartSimulationStepRangeKernel_000003D6$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000173
    public class StartSimulationStepJobKernels
    {
        // Methods
        private System.Void StartSimulationStepKernel(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index) { }
        private System.Void StartSimulationStepRangeKernel(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr) { }
        private System.Void StartSimulationStepKernel$BurstManaged(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index) { }
        private System.Void StartSimulationStepRangeKernel$BurstManaged(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000179
    public class PostSimulationUpdateKernel_000003D7$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200017A
    public class PostSimulationUpdateKernel_000003D7$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }

    }

    // TypeToken: 0x200017B
    public class PostSimulationUpdateRangeKernel_000003D8$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200017C
    public class PostSimulationUpdateRangeKernel_000003D8$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x2000178
    public class PostSimulationUpdateJobKernels
    {
        // Methods
        private System.Void PostSimulationUpdateKernel(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }
        private System.Void PostSimulationUpdateRangeKernel(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }
        private System.Void PostSimulationUpdateKernel$BurstManaged(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index) { }
        private System.Void PostSimulationUpdateRangeKernel$BurstManaged(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length) { }

    }

    // TypeToken: 0x200017D
    public struct ColliderType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static BeyondDynamicBone.ColliderManager.ColliderType None;        // 0x0
        public static BeyondDynamicBone.ColliderManager.ColliderType Sphere;        // 0x0
        public static BeyondDynamicBone.ColliderManager.ColliderType CapsuleX_Center;        // 0x0
        public static BeyondDynamicBone.ColliderManager.ColliderType CapsuleY_Center;        // 0x0
        public static BeyondDynamicBone.ColliderManager.ColliderType CapsuleZ_Center;        // 0x0
        public static BeyondDynamicBone.ColliderManager.ColliderType CapsuleX_Start;        // 0x0
        public static BeyondDynamicBone.ColliderManager.ColliderType CapsuleY_Start;        // 0x0
        public static BeyondDynamicBone.ColliderManager.ColliderType CapsuleZ_Start;        // 0x0
        public static BeyondDynamicBone.ColliderManager.ColliderType Plane;        // 0x0
        public static BeyondDynamicBone.ColliderManager.ColliderType Box;        // 0x0

    }

    // TypeToken: 0x200017E
    public struct WorkData
    {
        // Fields
        public BeyondDynamicBone.AABB aabb;        // 0x10
        public Unity.Mathematics.float2 radius;        // 0x28
        public Unity.Mathematics.float3x2 oldPos;        // 0x30
        public Unity.Mathematics.float3x2 nextPos;        // 0x48
        public Unity.Mathematics.quaternion inverseOldRot;        // 0x60
        public Unity.Mathematics.quaternion rot;        // 0x70

    }

    // TypeToken: 0x200017F
    public struct PreSimulationUpdateJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagArray;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> centerArray;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> framePositions;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> frameRotations;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> frameScales;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldFramePositions;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldFrameRotations;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nowPositions;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nowRotations;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPositions;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotations;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPositionArray;        // 0xF0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotationArray;        // 0x100
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformScaleArray;        // 0x110
        public System.Int32 _indexCount;        // 0x120

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000180
    public struct CreateUpdatecolliderListJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public System.Int32 updateIndex;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x18
        public Unity.Collections.NativeReference<System.Int32> jobColliderCounter;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> jobColliderIndexList;        // 0x38
        public System.Int32 _indexCount;        // 0x48

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 teamId) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000181
    public struct StartSimulationStepJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> jobColliderIndexList;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x30
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagArray;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> sizeArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> framePositions;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> frameRotations;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> frameScales;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldFramePositions;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldFrameRotations;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nowPositions;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nowRotations;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPositions;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotations;        // 0xF0
        public Unity.Collections.NativeArray<BeyondDynamicBone.ColliderManager.WorkData> workDataArray;        // 0x100
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x110

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000182
    public struct EndSimulationStepJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> jobColliderIndexList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nowPositions;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nowRotations;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPositions;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotations;        // 0x50
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x60

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000183
    public struct PostSimulationUpdateJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> framePositions;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> frameRotations;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldFramePositions;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldFrameRotations;        // 0x60
        public System.Int32 _indexCount;        // 0x70

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x2000186
    public class CreateUpdateParticleListKernel_00000401$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000187
    public class CreateUpdateParticleListKernel_00000401$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId) { }

    }

    // TypeToken: 0x2000188
    public class CreateUpdateParticleListRangeKernel_00000402$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000189
    public class CreateUpdateParticleListRangeKernel_00000402$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length) { }

    }

    // TypeToken: 0x2000185
    public class CreateUpdateParticleListKernels
    {
        // Methods
        private System.Void CreateUpdateParticleListKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId) { }
        private System.Void CreateUpdateParticleListRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length) { }
        private System.Void CreateUpdateParticleListKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId) { }
        private System.Void CreateUpdateParticleListRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length) { }

    }

    // TypeToken: 0x200018B
    public class PreSimulationUpdateKernel_00000403$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex) { }
        private System.IAsyncResult BeginInvoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200018C
    public class PreSimulationUpdateKernel_00000403$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex) { }

    }

    // TypeToken: 0x200018D
    public class PreSimulationUpdateRangeKernel_00000404$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200018E
    public class PreSimulationUpdateRangeKernel_00000404$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length) { }

    }

    // TypeToken: 0x200018A
    public class PreSimulationUpdateJobKernels
    {
        // Methods
        private System.Void PreSimulationUpdateKernel(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex) { }
        private System.Void PreSimulationUpdateRangeKernel(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length) { }
        private System.Void PreSimulationUpdateKernel$BurstManaged(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex) { }
        private System.Void PreSimulationUpdateRangeKernel$BurstManaged(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length) { }

    }

    // TypeToken: 0x2000190
    public class StartSimulationStepKernel_00000405$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000191
    public class StartSimulationStepKernel_00000405$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000192
    public class StartSimulationStepRangeKernel_00000406$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000193
    public class StartSimulationStepRangeKernel_00000406$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000194
    public class Spring_00000407$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000195
    public class Spring_00000407$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio) { }

    }

    // TypeToken: 0x2000196
    public class Wind_00000408$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result) { }
        private System.IAsyncResult BeginInvoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000197
    public class Wind_00000408$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result) { }

    }

    // TypeToken: 0x2000198
    public class WindForceBlend_00000409$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result) { }
        private System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000199
    public class WindForceBlend_00000409$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result) { }

    }

    // TypeToken: 0x200018F
    public class StartSimulationStepJobKernels
    {
        // Methods
        private System.Void StartSimulationStepKernel(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index) { }
        private System.Void StartSimulationStepRangeKernel(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr) { }
        private System.Void Spring(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio) { }
        private System.Void Wind(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result) { }
        private System.Void WindForceBlend(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result) { }
        private System.Void StartSimulationStepKernel$BurstManaged(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index) { }
        private System.Void StartSimulationStepRangeKernel$BurstManaged(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr) { }
        private System.Void Spring$BurstManaged(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio) { }
        private System.Void Wind$BurstManaged(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result) { }
        private System.Void WindForceBlend$BurstManaged(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result) { }

    }

    // TypeToken: 0x200019B
    public class UpdateStepBasicPotureKernel_0000040A$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200019C
    public class UpdateStepBasicPotureKernel_0000040A$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index) { }

    }

    // TypeToken: 0x200019D
    public class UpdateStepBasicPotureRangeKernel_0000040B$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200019E
    public class UpdateStepBasicPotureRangeKernel_0000040B$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200019A
    public class UpdateStepBasicPotureJobKernels
    {
        // Methods
        private System.Void UpdateStepBasicPotureKernel(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index) { }
        private System.Void UpdateStepBasicPotureRangeKernel(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr) { }
        private System.Void UpdateStepBasicPotureKernel$BurstManaged(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index) { }
        private System.Void UpdateStepBasicPotureRangeKernel$BurstManaged(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x20001A0
    public class EndSimulationStepKernel_0000040C$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001A1
    public class EndSimulationStepKernel_0000040C$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index) { }

    }

    // TypeToken: 0x20001A2
    public class EndSimulationStepRangeKernel_0000040D$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001A3
    public class EndSimulationStepRangeKernel_0000040D$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200019F
    public class EndSimulationStepJobKernels
    {
        // Methods
        private System.Void EndSimulationStepKernel(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index) { }
        private System.Void EndSimulationStepRangeKernel(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr) { }
        private System.Void EndSimulationStepKernel$BurstManaged(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index) { }
        private System.Void EndSimulationStepRangeKernel$BurstManaged(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x20001A5
    public class CalcDisplayPositionKernel_0000040E$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex) { }
        private System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001A6
    public class CalcDisplayPositionKernel_0000040E$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex) { }

    }

    // TypeToken: 0x20001A7
    public class CalcDisplayPositionRangeKernel_0000040F$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001A8
    public class CalcDisplayPositionRangeKernel_0000040F$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length) { }

    }

    // TypeToken: 0x20001A4
    public class CalcDisplayPositionJobKernels
    {
        // Methods
        private System.Void CalcDisplayPositionKernel(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex) { }
        private System.Void CalcDisplayPositionRangeKernel(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length) { }
        private System.Void CalcDisplayPositionKernel$BurstManaged(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex) { }
        private System.Void CalcDisplayPositionRangeKernel$BurstManaged(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length) { }

    }

    // TypeToken: 0x20001AA
    public class ClearStepCounterKernel_00000410$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint) { }
        private System.IAsyncResult BeginInvoke(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001AB
    public class ClearStepCounterKernel_00000410$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint) { }

    }

    // TypeToken: 0x20001A9
    public class ClearStepCounterKernels
    {
        // Methods
        private System.Void ClearStepCounterKernel(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint) { }
        private System.Void ClearStepCounterKernel$BurstManaged(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint) { }

    }

    // TypeToken: 0x20001AC
    public struct PreSimulationUpdateJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;        // 0x50
        public Unity.Collections.NativeArray<System.Single> vertexDepths;        // 0x60
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotArray;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosArray;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotArray;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPositionArray;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotationArray;        // 0xE0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0xF0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> dispPosArray;        // 0x100
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityArray;        // 0x110
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> realVelocityArray;        // 0x120
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0x130
        public Unity.Collections.NativeArray<System.Single> staticFrictionArray;        // 0x140
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalArray;        // 0x150
        public System.Int32 _indexCount;        // 0x160

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 pindex) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20001AD
    public struct ClearStepCounter, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeReference<System.Int32> processingStepParticle;        // 0x10
        public Unity.Collections.NativeReference<System.Int32> processingStepTriangleBending;        // 0x20
        public Unity.Collections.NativeReference<System.Int32> processingStepEdgeCollision;        // 0x30
        public Unity.Collections.NativeReference<System.Int32> processingStepCollider;        // 0x40
        public Unity.Collections.NativeReference<System.Int32> processingStepBaseLine;        // 0x50
        public Unity.Collections.NativeReference<System.Int32> processingStepMotionParticle;        // 0x60
        public Unity.Collections.NativeReference<System.Int32> processingSelfParticle;        // 0x70
        public Unity.Collections.NativeReference<System.Int32> processingSelfPointTriangle;        // 0x80
        public Unity.Collections.NativeReference<System.Int32> processingSelfEdgeEdge;        // 0x90
        public Unity.Collections.NativeReference<System.Int32> processingSelfTrianglePoint;        // 0xA0

        // Methods
        private System.Void Execute() { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20001AE
    public struct CreateUpdateParticleList, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x20
        public Unity.Collections.NativeReference<System.Int32> stepParticleIndexCounter;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> stepParticleIndexArray;        // 0x40
        public Unity.Collections.NativeReference<System.Int32> stepBaseLineIndexCounter;        // 0x50
        public Unity.Collections.NativeArray<System.Int32> stepBaseLineIndexArray;        // 0x60
        public Unity.Collections.NativeReference<System.Int32> stepTriangleBendIndexCounter;        // 0x70
        public Unity.Collections.NativeArray<System.Int32> stepTriangleBendIndexArray;        // 0x80
        public Unity.Collections.NativeReference<System.Int32> stepEdgeCollisionIndexCounter;        // 0x90
        public Unity.Collections.NativeArray<System.Int32> stepEdgeCollisionIndexArray;        // 0xA0
        public Unity.Collections.NativeReference<System.Int32> motionParticleIndexCounter;        // 0xB0
        public Unity.Collections.NativeArray<System.Int32> motionParticleIndexArray;        // 0xC0
        public Unity.Collections.NativeReference<System.Int32> selfParticleCounter;        // 0xD0
        public Unity.Collections.NativeArray<System.Int32> selfParticleIndexArray;        // 0xE0
        public Unity.Collections.NativeReference<System.Int32> selfPointTriangleCounter;        // 0xF0
        public Unity.Collections.NativeArray<System.UInt32> selfPointTriangleIndexArray;        // 0x100
        public Unity.Collections.NativeReference<System.Int32> selfEdgeEdgeCounter;        // 0x110
        public Unity.Collections.NativeArray<System.UInt32> selfEdgeEdgeIndexArray;        // 0x120
        public Unity.Collections.NativeReference<System.Int32> selfTrianglePointCounter;        // 0x130
        public Unity.Collections.NativeArray<System.UInt32> selfTrianglePointIndexArray;        // 0x140
        public System.Int32 _indexCount;        // 0x150

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 teamId) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20001AF
    public struct StartSimulationStepJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Mathematics.float4 simulationPower;        // 0x10
        public System.Single simulationDeltaTime;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> stepParticleIndexArray;        // 0x28
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x38
        public Unity.Collections.NativeArray<System.Single> depthArray;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;        // 0x68
        public Unity.Collections.NativeArray<System.Int32> vertexRootIndices;        // 0x78
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x88
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x98
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0xA8
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamWindData> teamWindArray;        // 0xB8
        public Unity.Collections.NativeArray<BeyondDynamicBone.WindManager.WindData> windDataArray;        // 0xC8
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0xD8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0xE8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityArray;        // 0xF8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x108
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosArray;        // 0x118
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotArray;        // 0x128
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPositionArray;        // 0x138
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotationArray;        // 0x148
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0x158
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0x168
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> stepBasicPositionArray;        // 0x178
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> stepBasicRotationArray;        // 0x188
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x198

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void Spring(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio) { }
        private System.Void Wind(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, Unity.Mathematics.float3& result) { }
        private System.Void WindForceBlend(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20001B0
    public struct UpdateStepBasicPotureJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> stepBaseLineIndexArray;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> vertexParentIndices;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> vertexLocalPositions;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexLocalRotations;        // 0x60
        public Unity.Collections.NativeArray<System.UInt16> baseLineStartDataIndices;        // 0x70
        public Unity.Collections.NativeArray<System.UInt16> baseLineDataCounts;        // 0x80
        public Unity.Collections.NativeArray<System.UInt16> baseLineData;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosArray;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotArray;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> stepBasicPositionArray;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> stepBasicRotationArray;        // 0xD0
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0xE0

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20001B1
    public struct EndSimulationStepJob, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public System.Single simulationDeltaTime;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> stepParticleIndexArray;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x28
        public Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x38
        public Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x48
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x58
        public Unity.Collections.NativeArray<System.Single> vertexDepths;        // 0x68
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityArray;        // 0xA8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> realVelocityArray;        // 0xB8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0xC8
        public Unity.Collections.NativeArray<System.Single> frictionArray;        // 0xD8
        public Unity.Collections.NativeArray<System.Single> staticFrictionArray;        // 0xE8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalArray;        // 0xF8
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x108

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20001B2
    public struct CalcDisplayPositionJob, IJobParallelFor, ICrossFrameParallelForJob, IJob, IUnsafeJob
    {
        // Fields
        public System.Single simulationDeltaTime;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x18
        public Unity.Collections.NativeArray<System.Int16> teamIdArray;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> realVelocityArray;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPositionArray;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotationArray;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> dispPosArray;        // 0x78
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;        // 0xA8
        public Unity.Collections.NativeArray<System.Int32> vertexRootIndices;        // 0xB8
        public System.Int32 _indexCount;        // 0xC8

        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 pindex) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20001B3
    public struct FeedbackTempPosJob, IJobParallelForDefer
    {
        // Fields
        public Unity.Collections.NativeList<System.Int32> jobParticleIndexList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> tempFloat3Buffer;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001B4
    public struct FeedbackTempPosJob2, IJobParallelForDefer
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> particleIndexArray;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> tempFloat3Buffer;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001B6
    public struct UpdateLocation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.TimeManager.UpdateLocation AfterLateUpdate;        // 0x0
        public static BeyondDynamicBone.TimeManager.UpdateLocation BeforeLateUpdate;        // 0x0

    }

    // TypeToken: 0x20001B8
    public struct WindData
    {
        // Fields
        public Unity.Collections.BitField32 flag;        // 0x10
        public BeyondDynamicBone.BeyondBoneWindZone.Mode mode;        // 0x14
        public Unity.Mathematics.float3 size;        // 0x18
        public System.Single main;        // 0x24
        public System.Single turbulence;        // 0x28
        public System.Single zoneVolume;        // 0x2C
        public Unity.Mathematics.float3 worldWindDirection;        // 0x30
        public Unity.Mathematics.float3 worldPositin;        // 0x3C
        public Unity.Mathematics.quaternion worldRotation;        // 0x48
        public Unity.Mathematics.float3 worldScale;        // 0x58
        public Unity.Mathematics.float4x4 worldToLocalMatrix;        // 0x64
        public Unity.Mathematics.float4x4 attenuation;        // 0xA4

        // Methods
        private System.Boolean IsValid() { }
        private System.Boolean IsEnable() { }
        private System.Boolean IsAddition() { }

    }

    // TypeToken: 0x20001BC
    public struct RestoreTransformJob, IJobParallelForTransform
    {
        // Fields
        public System.Int32 count;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagList;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositionArray;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotationArray;        // 0x38

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20001BD
    public struct ReadTransformJob, IJobParallelForTransform
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> flagList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positionArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotationArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> scaleList;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositionArray;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotationArray;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> inverseRotationArray;        // 0x70

        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20001BE
    public class ShareSerializationData
    {
        // Fields
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<BeyondDynamicBone.ExBitFlag8> flagArray;        // 0x10
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float3> initLocalPositionArray;        // 0x18
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.quaternion> initLocalRotationArray;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BF
    public class UniqueSerializationData, ITransform
    {
        // Fields
        public UnityEngine.Transform[] transformArray;        // 0x10

        // Methods
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001CC
    public struct InitGridJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public System.Single gridSize;        // 0x14
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x18
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x28
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0x38

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001CD
    public struct SearchJoinJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public System.Single gridSize;        // 0x14
        public System.Single radius;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x30
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0x40
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> joinPairMap;        // 0x50

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001CE
    public struct JoinJob2, IJob
    {
        // Fields
        public System.Int32 vertexCount;        // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> joinPairMap;        // 0x18
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x28
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> vertexToVertexMap;        // 0x38
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x48
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x58
        public Unity.Collections.NativeReference<System.Int32> result;        // 0x68
        public Unity.Collections.NativeList<System.UInt16> tempList;        // 0x78

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001CF
    public struct UpdateJoinIndexJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x10

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20001D0
    public struct UpdateLinkIndexJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> vertexToVertexMap;        // 0x20

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20001D1
    public struct FinalMergeVertexJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20001D3
    public struct SearchJoinEdgeJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public System.Single radius;        // 0x14
        public System.Boolean dontMakeLine;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x30
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> vertexToVertexMap;        // 0x40
        public Unity.Collections.NativeList<BeyondDynamicBone.StepReductionBase.JoinEdge> joinEdgeList;        // 0x50

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001D5
    public struct InitGridJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public System.Single gridSize;        // 0x14
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x18
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x28
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0x38

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001D6
    public struct SearchJoinEdgeJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public System.Single gridSize;        // 0x14
        public System.Single radius;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x30
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> vertexToVertexMap;        // 0x40
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0x50
        public Unity.Collections.NativeList<BeyondDynamicBone.StepReductionBase.JoinEdge> joinEdgeList;        // 0x60

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001D8
    public struct JoinEdge, IComparable`1
    {
        // Fields
        public Unity.Mathematics.int2 vertexPair;        // 0x10
        public System.Single cost;        // 0x18

        // Methods
        private System.Boolean Contains(Unity.Mathematics.int2& pair) { }
        private System.Int32 CompareTo(BeyondDynamicBone.StepReductionBase.JoinEdge other) { }

    }

    // TypeToken: 0x20001D9
    public struct DeterminJoinEdgeJob, IJob
    {
        // Fields
        public System.Int32 stepIndex;        // 0x10
        public System.Single mergeLength;        // 0x14
        public Unity.Collections.NativeList<BeyondDynamicBone.StepReductionBase.JoinEdge> joinEdgeList;        // 0x18
        public Unity.Collections.NativeParallelHashSet<System.Int32> completeVertexSet;        // 0x28
        public Unity.Collections.NativeList<Unity.Mathematics.int2> removePairList;        // 0x38
        public Unity.Collections.NativeArray<System.Int32> resultArray;        // 0x48

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001DA
    public struct JoinPairJob, IJob
    {
        // Fields
        public System.Single joinPositionAdjustment;        // 0x10
        public Unity.Collections.NativeList<Unity.Mathematics.int2> removePairList;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x38
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> vertexToVertexMap;        // 0x48
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x58
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x68
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x78

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001DB
    public struct UpdateJoinIndexJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x10

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20001DC
    public struct UpdateLinkIndexJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> vertexToVertexMap;        // 0x20

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20001DD
    public struct FinalMergeVertexJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20001DF
    public struct DebugAxis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.ClothDebugSettings.DebugAxis None;        // 0x0
        public static BeyondDynamicBone.ClothDebugSettings.DebugAxis Normal;        // 0x0
        public static BeyondDynamicBone.ClothDebugSettings.DebugAxis All;        // 0x0

    }

    // TypeToken: 0x20001E3
    public struct GridEnumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap;        // 0x0
        private Unity.Mathematics.int3 startGrid;        // 0x0
        private Unity.Mathematics.int3 endGrid;        // 0x0
        private Unity.Mathematics.int3 currentGrid;        // 0x0
        private System.Boolean isFirst;        // 0x0

        // Methods
        private Unity.Mathematics.int3 get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private BeyondDynamicBone.GridMap.GridEnumerator<T> GetEnumerator() { }

    }

    // TypeToken: 0x20001E5
    public struct FillJob`1, IJobParallelFor, ICrossFrameParallelForJob, IJob
    {
        // Fields
        public T value;        // 0x0
        public Unity.Collections.NativeArray<T> array;        // 0x0
        public System.Int32 _indexCount;        // 0x0

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001E6
    public struct FillJob2`1, IJobParallelFor, ICrossFrameParallelForJob, IJob
    {
        // Fields
        public T value;        // 0x0
        public System.Int32 startIndex;        // 0x0
        public Unity.Collections.NativeArray<T> array;        // 0x0
        public System.Int32 _indexCount;        // 0x0

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void SetIndexCount(System.Int32 indexCount) { }
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001E7
    public struct FillRefJob`1, IJob
    {
        // Fields
        public T value;        // 0x0
        public Unity.Collections.NativeReference<T> reference;        // 0x0

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001E8
    public struct SerialNumberJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> array;        // 0x10

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001E9
    public struct ConvertHashSetToListJob`1, IJob
    {
        // Fields
        public Unity.Collections.NativeParallelHashSet<T> hashSet;        // 0x0
        public Unity.Collections.NativeList<T> list;        // 0x0

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001EA
    public struct ConvertHashSetKeyToListJob`1, IJob
    {
        // Fields
        public Unity.Collections.NativeParallelHashSet<T> hashSet;        // 0x0
        public Unity.Collections.NativeList<T> list;        // 0x0

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001EB
    public struct CalcAABBJob, IJob
    {
        // Fields
        public System.Int32 length;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x18
        public Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001EC
    public struct CalcAABBDeferJob, IJob
    {
        // Fields
        public Unity.Collections.NativeList<Unity.Mathematics.float3> positions;        // 0x10
        public Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB;        // 0x20

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001ED
    public struct CalcUVJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x10
        public Unity.Collections.NativeReference<BeyondDynamicBone.AABB> aabb;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> uvs;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001EE
    public struct AddIntDataCopyJob, IJobParallelFor
    {
        // Fields
        public System.Int32 dstOffset;        // 0x10
        public System.Int32 addData;        // 0x14
        public Unity.Collections.NativeArray<System.Int32> srcData;        // 0x18
        public Unity.Collections.NativeArray<System.Int32> dstData;        // 0x28

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001EF
    public struct AddInt2DataCopyJob, IJobParallelFor
    {
        // Fields
        public System.Int32 dstOffset;        // 0x10
        public Unity.Mathematics.int2 addData;        // 0x14
        public Unity.Collections.NativeArray<Unity.Mathematics.int2> srcData;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.int2> dstData;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001F0
    public struct AddInt3DataCopyJob, IJobParallelFor
    {
        // Fields
        public System.Int32 dstOffset;        // 0x10
        public Unity.Mathematics.int3 addData;        // 0x14
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> srcData;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> dstData;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001F1
    public struct TransformPositionJob, IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float4x4 toM;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;        // 0x50

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20001F2
    public struct TransformPositionJob2, IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float4x4 toM;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> srcPositions;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> dstPositions;        // 0x60

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20001F3
    public struct ConvertArrayToMapJob`1, IJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.UInt32> indexArray;        // 0x0
        public Unity.Collections.NativeArray<TData> dataArray;        // 0x0
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,TData> map;        // 0x0

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001F4
    public struct ClearReferenceJob, IJob
    {
        // Fields
        public Unity.Collections.NativeReference<System.Int32> reference;        // 0x10

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20001F7
    public class AggregateKernel_00000564$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001F8
    public class AggregateKernel_00000564$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }

    }

    // TypeToken: 0x20001F9
    public class AggregateRangeKernel_00000565$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001FA
    public class AggregateRangeKernel_00000565$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }

    }

    // TypeToken: 0x20001F6
    public class AggregateJobKernels
    {
        // Methods
        private System.Void AggregateKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void AggregateRangeKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }
        private System.Void AggregateKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void AggregateRangeKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }

    }

    // TypeToken: 0x20001FC
    public class AggregateWithVelocityKernel_00000566$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001FD
    public class AggregateWithVelocityKernel_00000566$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }

    }

    // TypeToken: 0x20001FE
    public class AggregateWithVelocityRangeKernel_00000567$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001FF
    public class AggregateWithVelocityRangeKernel_00000567$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }

    }

    // TypeToken: 0x20001FB
    public class AggregateWithVelocityJobKernels
    {
        // Methods
        private System.Void AggregateWithVelocityKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void AggregateWithVelocityRangeKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }
        private System.Void AggregateWithVelocityKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void AggregateWithVelocityRangeKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length) { }

    }

    // TypeToken: 0x2000201
    public class AggregateJob2Kernel_00000568$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000202
    public class AggregateJob2Kernel_00000568$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000203
    public class AggregateJob2RangeKernel_00000569$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000204
    public class AggregateJob2RangeKernel_00000569$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000200
    public class AggregateJob2Kernels
    {
        // Methods
        private System.Void AggregateJob2Kernel(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void AggregateJob2RangeKernel(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr) { }
        private System.Void AggregateJob2Kernel$BurstManaged(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void AggregateJob2RangeKernel$BurstManaged(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000206
    public class AggregateWithVelocityJob2Kernel_0000056A$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000207
    public class AggregateWithVelocityJob2Kernel_0000056A$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000208
    public class AggregateWithVelocityJob2RangeKernel_0000056B$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000209
    public class AggregateWithVelocityJob2RangeKernel_0000056B$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000205
    public class AggregateWithVelocityJob2Kernels
    {
        // Methods
        private System.Void AggregateWithVelocityJob2Kernel(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void AggregateWithVelocityJob2RangeKernel(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr) { }
        private System.Void AggregateWithVelocityJob2Kernel$BurstManaged(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index) { }
        private System.Void AggregateWithVelocityJob2RangeKernel$BurstManaged(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x200020A
    public struct AggregateJob, IJobParallelForDefer, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeList<System.Int32> jobParticleIndexList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200020B
    public struct AggregateWithVelocityJob, IJobParallelForDefer, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeList<System.Int32> jobParticleIndexList;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0x30
        public System.Single velocityAttenuation;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x58

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200020C
    public struct AggregateJob2, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> particleIndexArray;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x40
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x50

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200020D
    public struct AggregateWithVelocityJob2, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IJob, IUnsafeJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> particleIndexArray;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0x30
        public System.Single velocityAttenuation;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x58
        public Unity.Collections.NativeReference<System.Int32> _indexCount;        // 0x68

        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }
        private System.Void Execute() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x200020E
    public struct AggregateWithVelocityCrossFrameJob2, IJob
    {
        // Fields
        public Unity.Collections.NativeReference<System.Int32> indexCount;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> particleIndexArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0x40
        public System.Single velocityAttenuation;        // 0x50
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x58
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x68

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void Execute() { }

    }

    // TypeToken: 0x200020F
    public struct AggregateCrossFrameJob2, IJob
    {
        // Fields
        public Unity.Collections.NativeReference<System.Int32> indexCount;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> particleIndexArray;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> countArray;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x50

        // Methods
        private System.Void Execute(System.Int32 index) { }
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000221
    public class SerializationData
    {
        // Fields
        public System.Int32 count;        // 0x0
        public System.Int32 length;        // 0x0
        public System.Byte[] arrayBytes;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022A
    public struct SetParallelMultiHashMapJob`2, IJob
    {
        // Fields
        public Unity.Collections.NativeParallelMultiHashMap<TKey,TValue> map;        // 0x0
        public Unity.Collections.NativeArray<TKey> keyArray;        // 0x0
        public Unity.Collections.NativeArray<TValue> valueArray;        // 0x0

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000235
    public struct Import_GenerateTangentJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0x20

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000236
    public struct Import_CalcSkinningJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> skinBoneTransformIndices;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> bindPoses;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPositionArray;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotationArray;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformScaleArray;        // 0x90
        public Unity.Mathematics.float4x4 toM;        // 0xA0

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000237
    public struct Import_BoneWeightJob1, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public Unity.Collections.NativeArray<System.Byte> bonesPerVertexArray;        // 0x18
        public Unity.Collections.NativeArray<System.Int32> startBoneWeightIndices;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000238
    public struct Import_BoneWeightJob2, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> startBoneWeightIndices;        // 0x10
        public Unity.Collections.NativeArray<UnityEngine.BoneWeight1> boneWeightArray;        // 0x20
        public Unity.Collections.NativeArray<System.Byte> bonesPerVertexArray;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000239
    public struct Import_BoneVertexJob, IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float4x4 WtoL;        // 0x10
        public Unity.Mathematics.float4x4 LtoW;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPositions;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotations;        // 0xA0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformScales;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0xC0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0xD0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0xE0
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0xF0
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> skinBoneBindPoses;        // 0x100

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x200023A
    public struct Select_PackVertexJob, IJob
    {
        // Fields
        public System.Int32 vertexCount;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> newVertexRemapIndices;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> uv;        // 0x68
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x78
        public Unity.Collections.NativeArray<System.Int32> newReferenceIndices;        // 0x88
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> newAttributes;        // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> newLocalPositions;        // 0xA8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> newLocalNormals;        // 0xB8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> newLocalTangents;        // 0xC8
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> newUv;        // 0xD8
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> newBoneWeights;        // 0xE8

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200023B
    public struct Select_GridJob, IJob
    {
        // Fields
        public System.Single gridSize;        // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0x18
        public System.Int32 selectionCount;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> selectionPositions;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> selectionAttributes;        // 0x40
        public System.Int32 vertexCount;        // 0x50
        public System.Int32 triangleCount;        // 0x54
        public System.Single searchRadius;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> meshPositions;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> meshTriangles;        // 0x70
        public Unity.Collections.NativeList<Unity.Mathematics.int3> newTriangles;        // 0x80
        public Unity.Collections.NativeArray<System.Int32> newVertexRemapIndices;        // 0x90
        public Unity.Collections.NativeReference<System.Int32> newVertexCount;        // 0xA0

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200023C
    public struct Add_CalcBindPoseJob, IJobParallelFor
    {
        // Fields
        public System.Int32 skinBoneOffset;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> srcSkinBoneTransformIndices;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> srcTransformPositionArray;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> srcTransformRotationArray;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> srcTransformScaleArray;        // 0x48
        public Unity.Mathematics.float4x4 dstCenterLocalToWorldMatrix;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> dstSkinBoneBindPoses;        // 0x98

        // Methods
        private System.Void Execute(System.Int32 boneIndex) { }

    }

    // TypeToken: 0x200023D
    public struct Add_CopyVerticesJob, IJobParallelFor
    {
        // Fields
        public System.Int32 vertexOffset;        // 0x10
        public System.Int32 skinBoneOffset;        // 0x14
        public Unity.Mathematics.float4x4 toM;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> srcAttributes;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> srclocalPositions;        // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> srclocalNormals;        // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> srclocalTangents;        // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> srcUV;        // 0x98
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> srcBoneWeights;        // 0xA8
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> dstAttributes;        // 0xB8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> dstlocalPositions;        // 0xC8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> dstlocalNormals;        // 0xD8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> dstlocalTangents;        // 0xE8
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> dstUV;        // 0xF8
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> dstBoneWeights;        // 0x108
        public Unity.Collections.NativeArray<System.Int32> dstSkinBoneIndices;        // 0x118

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x200023E
    public struct MappingWorkData
    {
        // Fields
        public Unity.Mathematics.float3 position;        // 0x10
        public System.Int32 vertexIndex;        // 0x1C
        public System.Int32 proxyVertexIndex;        // 0x20
        public System.Single proxyVertexDistance;        // 0x24

    }

    // TypeToken: 0x200023F
    public struct Mapping_DirectConnectionVertexDataJob, IJob
    {
        // Fields
        public Unity.Mathematics.float4x4 toP;        // 0x10
        public System.Int32 vcnt;        // 0x50
        public BeyondDynamicBone.DataChunk mergeChunk;        // 0x54
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x60
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x70
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x80
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> proxyAttributes;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> proxyLocalPositions;        // 0xA0
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMesh.MappingWorkData> mappingWorkData;        // 0xB0

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000240
    public struct Mapping_CalcDirectWeightJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public System.Single weightLength;        // 0x14
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMesh.MappingWorkData> mappingWorkData;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x28
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> proxyLocalPositions;        // 0x48
        public Unity.Collections.NativeArray<System.UInt32> proxyVertexToVertexIndexArray;        // 0x58
        public Unity.Collections.NativeArray<System.UInt16> proxyVertexToVertexDataArray;        // 0x68
        public Unity.Collections.NativeParallelHashSet<System.UInt16> useSet;        // 0x78

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000241
    public struct Mapping_CalcConnectionVertexDataJob, IJob
    {
        // Fields
        public System.Single gridSize;        // 0x10
        public System.Single searchRadius;        // 0x14
        public Unity.Mathematics.float4x4 toP;        // 0x18
        public System.Int32 vcnt;        // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x60
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x70
        public Unity.Collections.NativeArray<System.Int32> transformIds;        // 0x80
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x90
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0xA0
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> proxyAttributes;        // 0xB0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> proxyLocalPositions;        // 0xC0
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> proxyBoneWeights;        // 0xD0
        public Unity.Collections.NativeArray<System.Int32> proxyTransformIds;        // 0xE0
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMesh.MappingWorkData> mappingWorkData;        // 0xF0

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000242
    public struct Mapping_CalcWeightJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMesh.MappingWorkData> mappingWorkData;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> proxyAttributes;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> proxyLocalPositions;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> proxyLocalNormals;        // 0x60
        public Unity.Collections.NativeArray<System.UInt32> proxyVertexToVertexIndexArray;        // 0x70
        public Unity.Collections.NativeArray<System.UInt16> proxyVertexToVertexDataArray;        // 0x80

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000243
    public struct Optimize_EdgeToTrianlgeJob, IJob
    {
        // Fields
        public System.Int32 tcnt;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x28
        public Unity.Collections.NativeParallelHashMap<Unity.Mathematics.int2,Unity.Collections.FixedList128Bytes<System.Int32>> edgeToTriangleList;        // 0x38
        public Unity.Collections.NativeList<Unity.Mathematics.int3> newTriangles;        // 0x48
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int4> useQuadSet;        // 0x58
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int3> removeTriangleSet;        // 0x68

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000244
    public struct ProxyNormalRadiationAdjustmentJob, IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float3 center;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> vertexParentIndices;        // 0x30
        public Unity.Collections.NativeArray<System.UInt32> vertexChildIndexArray;        // 0x40
        public Unity.Collections.NativeArray<System.UInt16> vertexChildDataArray;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> normalAdjustmentRotations;        // 0x80

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000245
    public struct ProxyCreateFixedListAndAABBJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x28
        public Unity.Collections.NativeArray<System.UInt32> vertexToVertexIndexArray;        // 0x38
        public Unity.Collections.NativeArray<System.UInt16> vertexToVertexDataArray;        // 0x48
        public Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB;        // 0x58
        public Unity.Collections.NativeList<System.UInt16> fixedList;        // 0x68
        public Unity.Collections.NativeReference<Unity.Mathematics.float3> localCenterPosition;        // 0x78

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000246
    public struct Proxy_CalcTriangleNormalJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositins;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleNormals;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 tindex) { }

    }

    // TypeToken: 0x2000247
    public struct Proxy_CalcTriangleTangentJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositins;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> uv;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleTangents;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 tindex) { }

    }

    // TypeToken: 0x2000248
    public struct Proxy_CreateVertexToTrianglesJob, IJob
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x10
        public Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>> vertexToTriangles;        // 0x20

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000249
    public struct Proxy_OrganizeVertexToTrianglsJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>> vertexToTriangles;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleNormals;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleTangents;        // 0x30
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x200024A
    public struct Proxy_CalcVertexNormalTangentFromTriangleJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleNormals;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleTangents;        // 0x20
        public Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>> vertexToTriangles;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0x50

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x200024B
    public struct Proxy_CalcVertexToTransformJob, IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.quaternion invRot;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexToTransformRotations;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotations;        // 0x50

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x200024C
    public struct Proxy_CalcEdgeToTriangleJob, IJob
    {
        // Fields
        public System.Int32 tcnt;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x18
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16> edgeToTriangles;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200024D
    public struct Proxy_CalcVertexBindPoseJob2, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> vertexBindPosePositions;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexBindPoseRotations;        // 0x50

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x200024E
    public struct Proxy_CalcVertexToVertexFromTriangleJob, IJob
    {
        // Fields
        public System.Int32 triangleCount;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x18
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> vertexToVertexMap;        // 0x28
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2> edgeSet;        // 0x38

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200024F
    public struct Proxy_CalcVertexToVertexFromLineJob, IJob
    {
        // Fields
        public System.Int32 lineCount;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.int2> lines;        // 0x18
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> vertexToVertexMap;        // 0x28
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2> edgeSet;        // 0x38

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000250
    public struct Proxy_CreateEdgeFlagJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.int2> edges;        // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16> edgeToTriangles;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> edgeFlags;        // 0x30

        // Methods
        private System.Void Execute(System.Int32 eindex) { }

    }

    // TypeToken: 0x2000251
    public struct SkinningBoneInfo
    {
        // Fields
        public System.Int32 parentTransformIndex;        // 0x10
        public Unity.Mathematics.float3 parentPos;        // 0x14
        public System.Int32 childTransformIndex;        // 0x20
        public Unity.Mathematics.float3 childPos;        // 0x24

    }

    // TypeToken: 0x2000252
    public struct Proxy_CalcCustomSkinningWeightsJobV2, IJobParallelFor
    {
        // Fields
        public System.Boolean isBoneCloth;        // 0x10
        public System.Single angularAttenuation;        // 0x14
        public System.Single distanceReduction;        // 0x18
        public System.Single distancePow;        // 0x1C
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x30
        public Unity.Collections.NativeList<BeyondDynamicBone.VirtualMesh.SkinningBoneInfo> boneInfoList;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x50

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000253
    public struct Proxy_ApplySelectionJob, IJobParallelFor
    {
        // Fields
        public System.Single gridSize;        // 0x10
        public System.Single radius;        // 0x14
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x28
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> selectionPositions;        // 0x48
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> selectionAttributes;        // 0x58

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000254
    public struct Proxy_BoneClothApplayTransformFlagJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> transformFlags;        // 0x20

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000255
    public struct BaseLineWork, IComparable`1
    {
        // Fields
        public System.Int32 vindex;        // 0x10
        public System.Single dist;        // 0x14

        // Methods
        private System.Int32 CompareTo(BeyondDynamicBone.VirtualMesh.BaseLineWork other) { }

    }

    // TypeToken: 0x2000256
    public struct BaseLine_Mesh_CreateParentJob2, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public System.Single avgDist;        // 0x14
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attribues;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x28
        public Unity.Collections.NativeArray<System.UInt32> vertexToVertexIndexArray;        // 0x38
        public Unity.Collections.NativeArray<System.UInt16> vertexToVertexDataArray;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> vertexParentIndices;        // 0x58
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> vertexChildMap;        // 0x68
        public Unity.Collections.NativeList<System.Int32> fixedList;        // 0x78
        public Unity.Collections.NativeList<BeyondDynamicBone.VirtualMesh.BaseLineWork> nextList;        // 0x88
        public Unity.Collections.NativeArray<System.Byte> markBuff;        // 0x98
        public Unity.Collections.NativeParallelHashMap<System.Int32,BeyondDynamicBone.VirtualMesh.BaseLineWork> vertexMap;        // 0xA8

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000257
    public struct BaseLine_Mesh_CareteFixedListJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attribues;        // 0x18
        public Unity.Collections.NativeList<System.Int32> fixedList;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000258
    public struct BaseLine_Bone_CreateBoneChildInfoJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> parentIndices;        // 0x18
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> childMap;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000259
    public struct BaseLine_CalcLocalPositionRotationJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> parentIndices;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localNormals;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localTangents;        // 0x40
        public Unity.Collections.NativeArray<System.UInt16> baseLineIndices;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> vertexLocalPositions;        // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexLocalRotations;        // 0x70

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200025A
    public struct BaseLine_CalcMaxBaseLineLengthJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> attribues;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> vertexParentIndices;        // 0x38
        public Unity.Collections.NativeArray<System.Single> vertexDepths;        // 0x48
        public Unity.Collections.NativeArray<System.Int32> vertexRootIndices;        // 0x58
        public Unity.Collections.NativeArray<System.Single> rootLengthArray;        // 0x68

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200025B
    public struct Reduction_InitVertexToVertexJob2, IJob
    {
        // Fields
        public System.Int32 triangleCount;        // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x18
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> vertexToVertexMap;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200025C
    public struct Organize_RemapVertexJob, IJob
    {
        // Fields
        public System.Int32 oldVertexCount;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x18
        public Unity.Collections.NativeArray<System.Int32> vertexRemapIndices;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200025D
    public struct Organize_CollectUseSkinBoneJob, IJob
    {
        // Fields
        public System.Int32 oldVertexCount;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x18
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> oldBoneWeights;        // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> oldBindPoses;        // 0x38
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> useSkinBoneMap;        // 0x48
        public Unity.Collections.NativeList<System.Int32> newSkinBoneTransformIndices;        // 0x58
        public Unity.Collections.NativeList<Unity.Mathematics.float4x4> newSkinBoneBindPoses;        // 0x68
        public Unity.Collections.NativeReference<System.Int32> newSkinBoneCount;        // 0x78
        public Unity.Collections.NativeList<System.Int32> useSkinBoneMapKeyList;        // 0x88

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200025E
    public struct Organize_CopyVertexJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> vertexRemapIndices;        // 0x20
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> oldAttributes;        // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldLocalPositions;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldLocalNormals;        // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldLocalTangents;        // 0x60
        public Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> newAttributes;        // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> newLocalPositions;        // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> newLocalNormals;        // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> newLocalTangents;        // 0xA0

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200025F
    public struct Organize_RemapBoneWeightJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> vertexRemapIndices;        // 0x20
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> useSkinBoneMap;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> oldSkinBoneIndices;        // 0x40
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> oldBoneWeights;        // 0x50
        public Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> newBoneWeights;        // 0x60

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000260
    public struct Organize_RemapLinkPointArrayJob, IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> vertexRemapIndices;        // 0x20
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> oldVertexToVertexMap;        // 0x30
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> newVertexToVertexMap;        // 0x40

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x2000261
    public struct Organize_CreateLineTriangleJob, IJob
    {
        // Fields
        public System.Int32 newVertexCount;        // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> newVertexToVertexMap;        // 0x18
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2> edgeSet;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000262
    public struct Organize_CreateLineTriangleJob2, IJob
    {
        // Fields
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> newVertexToVertexMap;        // 0x10
        public Unity.Collections.NativeList<Unity.Mathematics.int2> newLineList;        // 0x20
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2> edgeSet;        // 0x30
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int3> triangleSet;        // 0x40

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000263
    public struct Organize_CreateNewTriangleJob3, IJob
    {
        // Fields
        public Unity.Collections.NativeList<Unity.Mathematics.int3> newTriangleList;        // 0x10
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int3> triangleSet;        // 0x20

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000264
    public class ShareSerializationData
    {
        // Fields
        public System.String name;        // 0x10
        public BeyondDynamicBone.VirtualMesh.MeshType meshType;        // 0x18
        public System.Boolean isBoneCloth;        // 0x1C
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<System.Int32> referenceIndices;        // 0x20
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<BeyondDynamicBone.VertexAttribute> attributes;        // 0x28
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float3> localPositions;        // 0x30
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float3> localNormals;        // 0x38
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float3> localTangents;        // 0x40
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float2> uv;        // 0x48
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x50
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.int3> triangles;        // 0x58
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.int2> lines;        // 0x60
        public System.Int32 centerTransformIndex;        // 0x68
        public Unity.Mathematics.float4x4 initLocalToWorld;        // 0x6C
        public Unity.Mathematics.float4x4 initWorldToLocal;        // 0xAC
        public Unity.Mathematics.quaternion initRotation;        // 0xEC
        public Unity.Mathematics.quaternion initInverseRotation;        // 0xFC
        public Unity.Mathematics.float3 initScale;        // 0x10C
        public System.Int32 skinRootIndex;        // 0x118
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<System.Int32> skinBoneTransformIndices;        // 0x120
        public BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float4x4> skinBoneBindPoses;        // 0x128
        public BeyondDynamicBone.TransformData.ShareSerializationData transformData;        // 0x130
        public BeyondDynamicBone.AABB boundingBox;        // 0x138
        public System.Single averageVertexDistance;        // 0x150
        public System.Single maxVertexDistance;        // 0x154
        public System.Byte[] vertexToTriangles;        // 0x158
        public System.Byte[] vertexToVertexIndexArray;        // 0x160
        public System.Byte[] vertexToVertexDataArray;        // 0x168
        public System.Byte[] edges;        // 0x170
        public System.Byte[] edgeFlags;        // 0x178
        public Unity.Mathematics.int2[] edgeToTrianglesKeys;        // 0x180
        public System.UInt16[] edgeToTrianglesValues;        // 0x188
        public System.Byte[] vertexBindPosePositions;        // 0x190
        public System.Byte[] vertexBindPoseRotations;        // 0x198
        public System.Byte[] vertexToTransformRotations;        // 0x1A0
        public System.Byte[] vertexDepths;        // 0x1A8
        public System.Byte[] vertexRootIndices;        // 0x1B0
        public System.Byte[] vertexParentIndices;        // 0x1B8
        public System.Byte[] vertexChildIndexArray;        // 0x1C0
        public System.Byte[] vertexChildDataArray;        // 0x1C8
        public System.Byte[] vertexLocalPositions;        // 0x1D0
        public System.Byte[] vertexLocalRotations;        // 0x1D8
        public System.Byte[] normalAdjustmentRotations;        // 0x1E0
        public System.Byte[] baseLineFlags;        // 0x1E8
        public System.Byte[] baseLineStartDataIndices;        // 0x1F0
        public System.Byte[] baseLineDataCounts;        // 0x1F8
        public System.Byte[] baseLineData;        // 0x200
        public System.Int32[] customSkinningBoneIndices;        // 0x208
        public System.UInt16[] centerFixedList;        // 0x210
        public Unity.Mathematics.float3 localCenterPosition;        // 0x218
        public Unity.Mathematics.float3 centerWorldPosition;        // 0x224
        public Unity.Mathematics.quaternion centerWorldRotation;        // 0x230
        public Unity.Mathematics.float3 centerWorldScale;        // 0x240
        public Unity.Mathematics.float4x4 toProxyMatrix;        // 0x24C
        public Unity.Mathematics.quaternion toProxyRotation;        // 0x28C

        // Methods
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000265
    public class UniqueSerializationData, ITransform
    {
        // Fields
        public BeyondDynamicBone.TransformData.UniqueSerializationData transformData;        // 0x10

        // Methods
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000266
    public struct Work_AverageTriangleDistanceJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public System.Int32 tcnt;        // 0x14
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x28
        public Unity.Collections.NativeReference<System.Single> averageVertexDistance;        // 0x38
        public Unity.Collections.NativeReference<System.Int32> averageCount;        // 0x48
        public Unity.Collections.NativeReference<System.Single> maxVertexDistance;        // 0x58

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000267
    public struct Work_AverageLineDistanceJob, IJob
    {
        // Fields
        public System.Int32 vcnt;        // 0x10
        public System.Int32 lcnt;        // 0x14
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.int2> lines;        // 0x28
        public Unity.Collections.NativeReference<System.Single> averageVertexDistance;        // 0x38
        public Unity.Collections.NativeReference<System.Int32> averageCount;        // 0x48
        public Unity.Collections.NativeReference<System.Single> maxVertexDistance;        // 0x58

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000268
    public struct Work_AddVertexIndexGirdMapJob, IJob
    {
        // Fields
        public System.Single gridSize;        // 0x10
        public System.Int32 vcnt;        // 0x14
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> positins;        // 0x18
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32> gridMap;        // 0x28

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000269
    public struct Work_IntersectTriangleJob, IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float3 localRayPos;        // 0x10
        public Unity.Mathematics.float3 localRayDir;        // 0x1C
        public Unity.Mathematics.float3 localRayEndPos;        // 0x28
        public System.Boolean doubleSide;        // 0x34
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.int3> triangles;        // 0x48
        public Unity.Collections.NativeList.ParallelWriter<BeyondDynamicBone.VirtualMeshRaycastHit> hitList;        // 0x58

        // Methods
        private System.Void Execute(System.Int32 tindex) { }

    }

    // TypeToken: 0x200026A
    public struct Work_IntersectEdgeJob, IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float3 localRayPos;        // 0x10
        public Unity.Mathematics.float3 localRayDir;        // 0x1C
        public Unity.Mathematics.float3 localRayEndPos;        // 0x28
        public Unity.Mathematics.float3 rayDir;        // 0x34
        public System.Single localEdgeRadius;        // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.int2> edges;        // 0x58
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16> edgeToTriangles;        // 0x68
        public Unity.Collections.NativeList.ParallelWriter<BeyondDynamicBone.VirtualMeshRaycastHit> hitList;        // 0x78

        // Methods
        private System.Void Execute(System.Int32 eindex) { }

    }

    // TypeToken: 0x200026B
    public struct Work_IntersectPointJob, IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float3 localRayPos;        // 0x10
        public Unity.Mathematics.float3 localRayDir;        // 0x1C
        public Unity.Mathematics.float3 rayDir;        // 0x28
        public System.Single localPointRadius;        // 0x34
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions;        // 0x38
        public Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.Int32>> vertexToTriangles;        // 0x48
        public Unity.Collections.NativeList.ParallelWriter<BeyondDynamicBone.VirtualMeshRaycastHit> hitList;        // 0x58

        // Methods
        private System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x200026C
    public struct Work_IntersetcSortJob, IJob
    {
        // Fields
        public Unity.Collections.NativeList<BeyondDynamicBone.VirtualMeshRaycastHit> hitList;        // 0x10

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200026D
    public struct MeshType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.VirtualMesh.MeshType NormalMesh;        // 0x0
        public static BeyondDynamicBone.VirtualMesh.MeshType NormalBoneMesh;        // 0x0
        public static BeyondDynamicBone.VirtualMesh.MeshType ProxyMesh;        // 0x0
        public static BeyondDynamicBone.VirtualMesh.MeshType ProxyBoneMesh;        // 0x0
        public static BeyondDynamicBone.VirtualMesh.MeshType Mapping;        // 0x0

    }

    // TypeToken: 0x2000274
    public class __JobReflectionRegistrationOutput__496319927
    {
        // Methods
        private System.Void CreateJobReflectionData() { }
        private System.Void EarlyInit() { }

    }

    // TypeToken: 0x2000275
    public class $BurstDirectCallInitializer
    {
        // Methods
        private System.Void Initialize() { }

    }

namespace BeyondDynamicBone
{

    // TypeToken: 0x2000004
    public class BeyondBoneCloth : ClothBehaviour, IValid
    {
        // Fields
        public System.Int32 clothAnimatorAbilityLODThresholdProperty;        // 0x20
        private System.Int32 _clothAnimatorAbilityLODThresholdProperty;        // 0x24
        public System.Int32 clothAnimatorLODThresholdProperty;        // 0x28
        private System.Int32 _clothAnimatorLODThresholdProperty;        // 0x2C
        public System.Single clothLODFadeTimeProperty;        // 0x30
        private System.Single _clothLODFadeTimeProperty;        // 0x34
        public System.Single animationPoseRatioProperty;        // 0x38
        private System.Single _animationPoseRatioProperty;        // 0x3C
        public System.Single clothSimulateWeightProperty;        // 0x40
        private System.Single _clothSimulateWeightProperty;        // 0x44
        public System.Single gravityProperty;        // 0x48
        private System.Single _gravityProperty;        // 0x4C
        public System.Single dampingProperty;        // 0x50
        private System.Single _dampingProperty;        // 0x54
        public System.Single worldInertiaProperty;        // 0x58
        private System.Single _worldInertiaProperty;        // 0x5C
        public System.Single localInertiaProperty;        // 0x60
        private System.Single _localInertiaProperty;        // 0x64
        public System.Single windInfluenceProperty;        // 0x68
        private System.Single _windInfluenceProperty;        // 0x6C
        public System.Single blendWeightProperty;        // 0x70
        private System.Single _blendWeightProperty;        // 0x74
        private System.Boolean <bUseRelativeTransform>k__BackingField;        // 0x78
        public Unity.Mathematics.float3 relativeTransformPos;        // 0x7C
        public Unity.Mathematics.quaternion relativeTransformRot;        // 0x88
        private BeyondDynamicBone.ClothSerializeData serializeData;        // 0x98
        private BeyondDynamicBone.ClothSerializeData2 serializeData2;        // 0xA0
        private BeyondDynamicBone.ClothProcess process;        // 0xA8
        public System.Action<System.Boolean> OnBuildComplete;        // 0xB0

        // Methods
        private System.Void InitAnimationProperty() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Boolean get_bUseRelativeTransform() { }
        private System.Void set_bUseRelativeTransform(System.Boolean value) { }
        private System.Void SetRelativeTransform(System.Boolean useRelativeTransform, Unity.Mathematics.float3 newPos, Unity.Mathematics.quaternion newRot) { }
        private BeyondDynamicBone.ClothSerializeData get_SerializeData() { }
        private System.Void set_SerializeData(BeyondDynamicBone.ClothSerializeData value) { }
        private BeyondDynamicBone.ClothProcess get_Process() { }
        private UnityEngine.Transform get_ClothTransform() { }
        private BeyondDynamicBone.BeyondBoneCloth get_SyncPartnerCloth() { }
        private System.Boolean IsValid() { }
        private System.Void Reset() { }
        private System.Void OnValidate() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Int32 GetMagicaHashCode() { }
        private BeyondDynamicBone.ClothSerializeData2 GetSerializeData2() { }
        private System.Void Initialize() { }
        private System.Void DisableAutoBuild() { }
        private System.Void SetClothSimulateWeight(System.Single weight) { }
        private System.Void SetClothSimulateWeightIgnorePlaying(System.Single weight) { }
        private System.Void SetClothStablizationTimeAfterResetIgnorePlaying(System.Single time) { }
        private System.Void SetAnimationPoseRatio(System.Single ratio) { }
        private System.Void SetCodeParamaterDirty() { }
        private System.Void SetCodeParamaterDirtyIgnorePlaying() { }
        private System.Boolean BuildAndRun() { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> targetTransformDict) { }
        private System.Void SetParameterChange() { }
        private System.Void SetTimeScale(System.Single timeScale) { }
        private System.Single GetTimeScale() { }
        private System.Void ResetCloth(System.Boolean keepPose) { }
        private System.Void SoftResetCloth(System.Boolean keepPose) { }
        private UnityEngine.Vector3 GetCenterPosition() { }
        private System.Void AddForce(UnityEngine.Vector3 forceDirection, System.Single forceVelocity, BeyondDynamicBone.ClothForceMode fmode) { }
        private System.Void SetSkipWriting(System.Boolean sw) { }
        private System.Void .ctor() { }
        private System.Int32 <>iFixBaseProxy_GetMagicaHashCode() { }

    }

    // TypeToken: 0x2000005
    public class CheckSliderSerializeData
    {
        // Fields
        public System.Single value;        // 0x10
        public System.Boolean use;        // 0x14

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean use, System.Single value) { }
        private System.Single GetValue(System.Single unusedValue) { }
        private System.Void SetValue(System.Boolean use, System.Single value) { }
        private System.Void DataValidate(System.Single min, System.Single max) { }
        private BeyondDynamicBone.CheckSliderSerializeData Clone() { }

    }

    // TypeToken: 0x2000006
    public class ClothBehaviour : MonoBehaviour
    {
        // Fields
        private System.Boolean <IsGizmoVisible>k__BackingField;        // 0x18

        // Methods
        private System.Int32 GetMagicaHashCode() { }
        private System.Boolean get_IsGizmoVisible() { }
        private System.Void set_IsGizmoVisible(System.Boolean value) { }
        private System.Void OnDrawGizmos() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public struct ClothForceMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.ClothForceMode None;        // 0x0
        public static BeyondDynamicBone.ClothForceMode VelocityAdd;        // 0x0
        public static BeyondDynamicBone.ClothForceMode VelocityChange;        // 0x0
        public static BeyondDynamicBone.ClothForceMode VelocityAddWithoutDepth;        // 0x0
        public static BeyondDynamicBone.ClothForceMode VelocityChangeWithoutDepth;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct ClothMeshWriteMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.ClothMeshWriteMode PositionAndNormal;        // 0x0
        public static BeyondDynamicBone.ClothMeshWriteMode PositionAndNormalTangent;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct ClothNormalAxis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.ClothNormalAxis Right;        // 0x0
        public static BeyondDynamicBone.ClothNormalAxis Up;        // 0x0
        public static BeyondDynamicBone.ClothNormalAxis Forward;        // 0x0
        public static BeyondDynamicBone.ClothNormalAxis InverseRight;        // 0x0
        public static BeyondDynamicBone.ClothNormalAxis InverseUp;        // 0x0
        public static BeyondDynamicBone.ClothNormalAxis InverseForward;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct ClothParameters
    {
        // Fields
        public System.Single gravity;        // 0x10
        public Unity.Mathematics.float3 worldGravityDirection;        // 0x14
        public System.Single gravityFalloff;        // 0x20
        public System.Single stablizationTimeAfterReset;        // 0x24
        public System.Single blendWeight;        // 0x28
        public Unity.Mathematics.float4x4 dampingCurveData;        // 0x2C
        public Unity.Mathematics.float4x4 radiusCurveData;        // 0x6C
        public BeyondDynamicBone.ClothNormalAxis normalAxis;        // 0xAC
        public System.Single rotationalInterpolation;        // 0xB0
        public System.Single rootRotation;        // 0xB4
        public BeyondDynamicBone.CullingSettings.CullingParams culling;        // 0xB8
        public BeyondDynamicBone.InertiaConstraint.InertiaConstraintParams inertiaConstraint;        // 0xC4
        public BeyondDynamicBone.TetherConstraint.TetherConstraintParams tetherConstraint;        // 0xFC
        public BeyondDynamicBone.DistanceConstraint.DistanceConstraintParams distanceConstraint;        // 0x104
        public BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingConstraintParams triangleBendingConstraint;        // 0x148
        public BeyondDynamicBone.AngleConstraint.AngleConstraintParams angleConstraint;        // 0x150
        public BeyondDynamicBone.MotionConstraint.MotionConstraintParams motionConstraint;        // 0x1E4
        public BeyondDynamicBone.ColliderCollisionConstraint.ColliderCollisionConstraintParams colliderCollisionConstraint;        // 0x274
        public BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionConstraintParams selfCollisionConstraint;        // 0x2C0
        public BeyondDynamicBone.WindParams wind;        // 0x30C
        public BeyondDynamicBone.SpringConstraint.SpringConstraintParams springConstraint;        // 0x328

    }

    // TypeToken: 0x200000B
    public class ClothProcess, IDisposable, IValid, ITransform
    {
        // Fields
        private static readonly Unity.Profiling.ProfilerMarker initProfiler;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker preBuildProfiler;        // 0x8
        private static readonly Unity.Profiling.ProfilerMarker preBuildDeserializationProfiler;        // 0x10
        private static readonly Unity.Profiling.ProfilerMarker preBuildRegistrationProfiler;        // 0x18
        private BeyondDynamicBone.BeyondBoneCloth <cloth>k__BackingField;        // 0x10
        private BeyondDynamicBone.BeyondBoneCloth <SyncTopCloth>k__BackingField;        // 0x18
        public static System.Int32 State_Valid;        // 0x0
        public static System.Int32 State_Enable;        // 0x0
        public static System.Int32 State_InitSuccess;        // 0x0
        public static System.Int32 State_InitComplete;        // 0x0
        public static System.Int32 State_Build;        // 0x0
        public static System.Int32 State_Running;        // 0x0
        public static System.Int32 State_DisableAutoBuild;        // 0x0
        public static System.Int32 State_CameraCullingInvisible;        // 0x0
        public static System.Int32 State_CameraCullingKeep;        // 0x0
        public static System.Int32 State_SkipWriting;        // 0x0
        public static System.Int32 State_UsePreBuild;        // 0x0
        public static System.Int32 State_DistanceCullingInvisible;        // 0x0
        public static System.Int32 State_UpdateTangent;        // 0x0
        public static System.Int32 State_Component;        // 0x0
        public static System.Int32 State_Verification;        // 0x0
        public static System.Int32 State_LOD_Culled;        // 0x0
        private Unity.Collections.BitField32 stateFlag;        // 0x20
        private BeyondDynamicBone.TransformRecord <clothTransformRecord>k__BackingField;        // 0x28
        private System.Collections.Generic.List<System.Int32> renderHandleList;        // 0x30
        private BeyondDynamicBone.RenderSetupData boneClothSetupData;        // 0x38
        private System.Collections.Generic.List<BeyondDynamicBone.ClothProcess.RenderMeshInfo> renderMeshInfoList;        // 0x40
        private System.Collections.Generic.List<BeyondDynamicBone.TransformRecord> customSkinningBoneRecords;        // 0x48
        private BeyondDynamicBone.TransformRecord <normalAdjustmentTransformRecord>k__BackingField;        // 0x50
        private BeyondDynamicBone.ResultCode result;        // 0x58
        private BeyondDynamicBone.ClothProcess.ClothType <clothType>k__BackingField;        // 0x60
        private BeyondDynamicBone.ReductionSettings reductionSettings;        // 0x68
        private BeyondDynamicBone.ClothParameters <parameters>k__BackingField;        // 0x70
        private BeyondDynamicBone.VirtualMeshContainer <ProxyMeshContainer>k__BackingField;        // 0x398
        private System.Collections.Generic.List<BeyondDynamicBone.ColliderComponent> colliderList;        // 0x3A0
        private System.Int32 <TeamId>k__BackingField;        // 0x3A8
        private BeyondDynamicBone.InertiaConstraint.ConstraintData inertiaConstraintData;        // 0x3B0
        private BeyondDynamicBone.DistanceConstraint.ConstraintData distanceConstraintData;        // 0x3B8
        private BeyondDynamicBone.TriangleBendingConstraint.ConstraintData bendingConstraintData;        // 0x3C0
        private UnityEngine.Animator interlockingAnimator;        // 0x3C8
        private System.Collections.Generic.List<UnityEngine.Renderer> interlockingAnimatorRenderers;        // 0x3D0
        private System.Int32 anchorTransformId;        // 0x3D8
        private System.Int32 distanceReferenceObjectId;        // 0x3DC
        private UnityEngine.Animator cameraCullingAnimator;        // 0x3E0
        private System.Collections.Generic.List<UnityEngine.Renderer> cameraCullingRenderers;        // 0x3E8
        private BeyondDynamicBone.CullingSettings.CameraCullingMode cameraCullingMode;        // 0x3F0
        private System.Boolean cameraCullingOldInvisible;        // 0x3F4
        private System.Threading.CancellationTokenSource cts;        // 0x3F8
        private System.Object lockObject;        // 0x400
        private System.Boolean isDestory;        // 0x408
        private System.Boolean isDestoryInternal;        // 0x409
        private System.Boolean isBuild;        // 0x40A

        // Methods
        private System.Void Init() { }
        private System.Int32 AddRenderer(UnityEngine.Renderer ren, BeyondDynamicBone.RenderSetupData referenceSetupData, BeyondDynamicBone.RenderSetupData.UniqueSerializationData referenceUniqueSetupData) { }
        private System.Void CreateBoneRenderSetupData(BeyondDynamicBone.ClothProcess.ClothType ctype, System.Collections.Generic.List<UnityEngine.Transform> rootTransforms, System.Collections.Generic.List<UnityEngine.Transform> ignoreFromRootBones, System.Collections.Generic.List<UnityEngine.Transform> collisionBones, BeyondDynamicBone.RenderSetupData.BoneConnectionMode connectionMode) { }
        private System.Void StartUse() { }
        private System.Void EndUse() { }
        private System.Void UpdateUse() { }
        private System.Void DataUpdate() { }
        private System.Boolean StartRuntimeBuild() { }
        private System.Boolean AutoBuild() { }
        private System.Threading.Tasks.Task RuntimeBuildAsync(System.Threading.CancellationToken ct) { }
        private BeyondDynamicBone.ResultCode GenerateSelectionDataFromPaintMap(BeyondDynamicBone.TransformRecord clothTransformRecord, BeyondDynamicBone.VirtualMesh renderMesh, BeyondDynamicBone.ClothProcess.PaintMapData paintMapData, BeyondDynamicBone.SelectionData& selectionData) { }
        private BeyondDynamicBone.ResultCode GeneratePaintMapDataList(System.Collections.Generic.List<BeyondDynamicBone.ClothProcess.PaintMapData> dataList) { }
        private BeyondDynamicBone.ResultCode GenerateSelectionDataFromVertexAttributeData(BeyondDynamicBone.TransformRecord clothTransformRecord, BeyondDynamicBone.VirtualMesh renderMesh, BeyondDynamicBone.VertexAttribute[] vertexAttributeArray, BeyondDynamicBone.SelectionData& selectionData) { }
        private System.Boolean PreBuildDataConstruction() { }
        private System.Int32 GetColliderIndex(BeyondDynamicBone.ColliderComponent col) { }
        private System.Void UpdateCullingAnimatorAndRenderers() { }
        private System.Void UpdateRendererUse() { }
        private BeyondDynamicBone.BeyondBoneCloth get_cloth() { }
        private System.Void set_cloth(BeyondDynamicBone.BeyondBoneCloth value) { }
        private BeyondDynamicBone.BeyondBoneCloth get_SyncTopCloth() { }
        private System.Void set_SyncTopCloth(BeyondDynamicBone.BeyondBoneCloth value) { }
        private BeyondDynamicBone.TransformRecord get_clothTransformRecord() { }
        private System.Void set_clothTransformRecord(BeyondDynamicBone.TransformRecord value) { }
        private BeyondDynamicBone.TransformRecord get_normalAdjustmentTransformRecord() { }
        private System.Void set_normalAdjustmentTransformRecord(BeyondDynamicBone.TransformRecord value) { }
        private BeyondDynamicBone.ResultCode get_Result() { }
        private BeyondDynamicBone.ClothProcess.ClothType get_clothType() { }
        private System.Void set_clothType(BeyondDynamicBone.ClothProcess.ClothType value) { }
        private BeyondDynamicBone.ClothParameters get_parameters() { }
        private System.Void set_parameters(BeyondDynamicBone.ClothParameters value) { }
        private BeyondDynamicBone.VirtualMeshContainer get_ProxyMeshContainer() { }
        private System.Void set_ProxyMeshContainer(BeyondDynamicBone.VirtualMeshContainer value) { }
        private System.Int32 get_ColliderCapacity() { }
        private System.Int32 get_TeamId() { }
        private System.Void set_TeamId(System.Int32 value) { }
        private Unity.Collections.BitField32 GetStateFlag() { }
        private System.Boolean IsState(System.Int32 state) { }
        private System.Void SetState(System.Int32 state, System.Boolean sw) { }
        private System.Boolean IsValid() { }
        private System.Boolean IsRunning() { }
        private System.Boolean IsCameraCullingInvisible() { }
        private System.Boolean IsLodCulled() { }
        private System.Boolean IsCameraCullingKeep() { }
        private System.Boolean IsDistanceCullingInvisible() { }
        private System.Boolean IsSkipWriting() { }
        private System.Boolean IsUpdateTangent() { }
        private System.Boolean get_IsEnable() { }
        private System.Boolean get_HasProxyMesh() { }
        private System.String get_Name() { }
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void DisposeInternal() { }
        private System.Void IncrementSuspendCounter() { }
        private System.Void DecrementSuspendCounter() { }
        private System.Int32 GetSuspendCounter() { }
        private BeyondDynamicBone.ClothProcess.RenderMeshInfo GetRenderMeshInfo(System.Int32 index) { }
        private System.Void SyncParameters() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Void SetSkipWriting(System.Boolean sw) { }
        private BeyondDynamicBone.ClothUpdateMode GetClothUpdateMode() { }
        private BeyondDynamicBone.ResultCode GenerateStatusCheck() { }
        private System.Boolean GenerateInitialization() { }
        private System.Boolean GenerateBoneClothSelection() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000016
    public class ClothSerializeData, IDataValidate, IValid, ITransform
    {
        // Fields
        public BeyondDynamicBone.ClothProcess.ClothType clothType;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Renderer> sourceRenderers;        // 0x18
        public BeyondDynamicBone.ClothMeshWriteMode meshWriteMode;        // 0x20
        public BeyondDynamicBone.ClothSerializeData.PaintMode paintMode;        // 0x24
        public System.Collections.Generic.List<UnityEngine.Texture2D> paintMaps;        // 0x28
        public System.Collections.Generic.List<UnityEngine.Transform> rootBones;        // 0x30
        public System.Collections.Generic.List<UnityEngine.Transform> ignoreFromRootBones;        // 0x38
        public BeyondDynamicBone.RenderSetupData.BoneConnectionMode connectionMode;        // 0x40
        public System.Single rotationalInterpolation;        // 0x44
        public System.Single rootRotation;        // 0x48
        public BeyondDynamicBone.ClothUpdateMode updateMode;        // 0x4C
        public BeyondDynamicBone.ClothSerializeData.AnimatorAbilityLevel clothAnimatorAbilityLODThreshold;        // 0x50
        public System.Int32 clothAnimatorLODThreshold;        // 0x54
        public System.Single clothLodFadeTime;        // 0x58
        public System.Single clothSimulateWeight;        // 0x5C
        public System.Single animationPoseRatio;        // 0x60
        public BeyondDynamicBone.ReductionSettings reductionSetting;        // 0x68
        public BeyondDynamicBone.CustomSkinningSettings customSkinningSetting;        // 0x70
        public BeyondDynamicBone.NormalAlignmentSettings normalAlignmentSetting;        // 0x78
        public BeyondDynamicBone.CullingSettings cullingSettings;        // 0x80
        public BeyondDynamicBone.ClothNormalAxis normalAxis;        // 0x88
        public System.Single gravity;        // 0x8C
        public Unity.Mathematics.float3 gravityDirection;        // 0x90
        public System.Single gravityFalloff;        // 0x9C
        public System.Single stablizationTimeAfterReset;        // 0xA0
        public System.Single blendWeight;        // 0xA4
        public BeyondDynamicBone.CurveSerializeData damping;        // 0xA8
        public BeyondDynamicBone.CurveSerializeData radius;        // 0xB0
        public BeyondDynamicBone.InertiaConstraint.SerializeData inertiaConstraint;        // 0xB8
        public BeyondDynamicBone.TetherConstraint.SerializeData tetherConstraint;        // 0xC0
        public BeyondDynamicBone.DistanceConstraint.SerializeData distanceConstraint;        // 0xC8
        public BeyondDynamicBone.TriangleBendingConstraint.SerializeData triangleBendingConstraint;        // 0xD0
        public BeyondDynamicBone.AngleConstraint.RestorationSerializeData angleRestorationConstraint;        // 0xD8
        public BeyondDynamicBone.AngleConstraint.LimitSerializeData angleLimitConstraint;        // 0xE0
        public BeyondDynamicBone.MotionConstraint.SerializeData motionConstraint;        // 0xE8
        public BeyondDynamicBone.ColliderCollisionConstraint.SerializeData colliderCollisionConstraint;        // 0xF0
        public BeyondDynamicBone.SelfCollisionConstraint.SerializeData selfCollisionConstraint;        // 0xF8
        public BeyondDynamicBone.WindSettings wind;        // 0x100
        public BeyondDynamicBone.SpringConstraint.SerializeData springConstraint;        // 0x108
        private BeyondDynamicBone.ResultCode verificationResult;        // 0x110

        // Methods
        private BeyondDynamicBone.Define.Result get_VerificationResult() { }
        private System.Void .ctor() { }
        private System.Boolean IsValid() { }
        private System.Void DataValidate() { }
        private System.Int32 GetHashCode() { }
        private BeyondDynamicBone.ClothParameters GetClothParameters() { }
        private System.String ExportJson() { }
        private System.Boolean ImportJson(System.String json) { }
        private System.Void Import(BeyondDynamicBone.ClothSerializeData sdata, System.Boolean deepCopy) { }
        private System.Void Import(BeyondDynamicBone.BeyondBoneCloth src, System.Boolean deepCopy) { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Boolean IsBoneSpring() { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x200001B
    public class ClothSerializeData2, IDataValidate, IValid, ITransform
    {
        // Fields
        public BeyondDynamicBone.SelectionData selectionData;        // 0x10
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,BeyondDynamicBone.VertexAttribute> boneAttributeDict;        // 0x18
        public System.Collections.Generic.List<BeyondDynamicBone.VertexAttribute[]> vertexAttributeList;        // 0x20
        public BeyondDynamicBone.PreBuildSerializeData preBuildData;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Boolean IsValid() { }
        private System.Void DataValidate() { }
        private System.Int32 GetHashCode() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x200001C
    public struct ClothUpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.ClothUpdateMode Normal;        // 0x0
        public static BeyondDynamicBone.ClothUpdateMode UnityPhysics;        // 0x0
        public static BeyondDynamicBone.ClothUpdateMode Unscaled;        // 0x0
        public static BeyondDynamicBone.ClothUpdateMode AnimatorLinkage;        // 0x0

    }

    // TypeToken: 0x200001D
    public class BeyondBoneCapsuleCollider : ColliderComponent
    {
        // Fields
        public BeyondDynamicBone.BeyondBoneCapsuleCollider.Direction direction;        // 0x40
        public System.Boolean reverseDirection;        // 0x44
        public System.Boolean radiusSeparation;        // 0x45
        public System.Boolean alignedOnCenter;        // 0x46

        // Methods
        private BeyondDynamicBone.ColliderManager.ColliderType GetColliderType() { }
        private System.Void SetSize(System.Single startRadius, System.Single endRadius, System.Single length) { }
        private UnityEngine.Vector3 GetSize() { }
        private UnityEngine.Vector3 GetLocalDir() { }
        private UnityEngine.Vector3 GetLocalUp() { }
        private System.Boolean IsReverseDirection() { }
        private System.Void DataValidate() { }
        private System.Void .ctor() { }
        private UnityEngine.Vector3 <>iFixBaseProxy_GetSize() { }
        private System.Boolean <>iFixBaseProxy_IsReverseDirection() { }

    }

    // TypeToken: 0x200001F
    public class BeyondBonePlaneCollider : ColliderComponent
    {
        // Methods
        private BeyondDynamicBone.ColliderManager.ColliderType GetColliderType() { }
        private System.Void DataValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class BeyondBoneSphereCollider : ColliderComponent
    {
        // Methods
        private BeyondDynamicBone.ColliderManager.ColliderType GetColliderType() { }
        private System.Void DataValidate() { }
        private System.Void SetSize(System.Single radius) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class ColliderComponent : ClothBehaviour, IDataValidate
    {
        // Fields
        public UnityEngine.Vector3 center;        // 0x20
        protected UnityEngine.Vector3 size;        // 0x2C
        private System.Collections.Generic.HashSet<System.Int32> teamIdSet;        // 0x38

        // Methods
        private BeyondDynamicBone.ColliderManager.ColliderType GetColliderType() { }
        private System.Void DataValidate() { }
        private UnityEngine.Vector3 GetSize() { }
        private System.Void SetSize(UnityEngine.Vector3 size) { }
        private System.Void SetSizeX(System.Single size) { }
        private System.Void SetSizeY(System.Single size) { }
        private System.Void SetSizeZ(System.Single size) { }
        private System.Single GetScale() { }
        private System.Boolean IsReverseDirection() { }
        private System.Void Register(System.Int32 teamId) { }
        private System.Void Exit(System.Int32 teamId) { }
        private System.Void UpdateParameters() { }
        private System.Void Start() { }
        private System.Void OnValidate() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class AngleConstraintKernel_000000C4$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000024
    public class AngleConstraintKernel_000000C4$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000025
    public class AngleConstraintRangeKernel_000000C5$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000026
    public class AngleConstraintRangeKernel_000000C5$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000022
    public class AngleConstraintJobKernels
    {
        // Methods
        private System.Void AngleConstraintKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index) { }
        private System.Void AngleConstraintRangeKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr) { }
        private System.Void AngleConstraintKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index) { }
        private System.Void AngleConstraintRangeKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000027
    public class AngleConstraint, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<System.Single> lengthBuffer;        // 0x10
        private Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosBuffer;        // 0x20
        private Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotBuffer;        // 0x30
        private Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotationBuffer;        // 0x40
        private Unity.Collections.NativeArray<Unity.Mathematics.float3> restorationVectorBuffer;        // 0x50

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void WorkBufferUpdate() { }
        private System.String ToString() { }
        private Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle) { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200002C
    public class ColliderCollisionConstraint, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<System.Int32> tempFrictionArray;        // 0x10
        private Unity.Collections.NativeArray<System.Int32> tempNormalArray;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void WorkBufferUpdate() { }
        private System.String ToString() { }
        private Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000DB$BurstDirectCall() { }
        private System.Void Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000DC$BurstDirectCall() { }
        private System.Void Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E0$BurstDirectCall() { }
        private System.Void Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000E1$BurstDirectCall() { }
        private System.Void Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000E5$BurstDirectCall() { }
        private System.Void Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000E6$BurstDirectCall() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000043
    public class DistanceConstraintKernel_00000101$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000044
    public class DistanceConstraintKernel_00000101$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000045
    public class DistanceConstraintRangeKernel_00000102$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000046
    public class DistanceConstraintRangeKernel_00000102$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000042
    public class DistanceConstraintJobKernels
    {
        // Methods
        private System.Void DistanceConstraintKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index) { }
        private System.Void DistanceConstraintRangeKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr) { }
        private System.Void DistanceConstraintKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index) { }
        private System.Void DistanceConstraintRangeKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000047
    public class DistanceConstraint, IDisposable
    {
        // Fields
        public static System.Int32 TypeCount;        // 0x0
        public BeyondDynamicBone.ExNativeArray<System.UInt32> indexArray;        // 0x10
        public BeyondDynamicBone.ExNativeArray<System.UInt16> dataArray;        // 0x18
        public BeyondDynamicBone.ExNativeArray<System.Single> distanceArray;        // 0x20

        // Methods
        private System.Int32 get_DataCount() { }
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.String ToString() { }
        private BeyondDynamicBone.DistanceConstraint.ConstraintData CreateData(BeyondDynamicBone.VirtualMesh proxyMesh, BeyondDynamicBone.ClothParameters& parameters) { }
        private System.Void Register(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void Exit(BeyondDynamicBone.ClothProcess cprocess) { }
        private Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle) { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200004C
    public class InertiaConstraint, IDisposable
    {
        // Fields
        private BeyondDynamicBone.ExNativeArray<System.UInt16> fixedArray;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.String ToString() { }
        private BeyondDynamicBone.InertiaConstraint.ConstraintData CreateData(BeyondDynamicBone.VirtualMesh proxyMesh, BeyondDynamicBone.ClothParameters& parameters) { }
        private System.Void Register(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void Exit(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000053
    public class MotionConstraintKernel_00000121$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000054
    public class MotionConstraintKernel_00000121$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index) { }

    }

    // TypeToken: 0x2000055
    public class MotionConstraintRangeKernel_00000122$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000056
    public class MotionConstraintRangeKernel_00000122$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000052
    public class MotionConstraintJobKernels
    {
        // Methods
        private System.Void MotionConstraintKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index) { }
        private System.Void MotionConstraintRangeKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr) { }
        private System.Void MotionConstraintKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index) { }
        private System.Void MotionConstraintRangeKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000057
    public class MotionConstraint, IDisposable
    {
        // Methods
        private System.Void Dispose() { }
        private Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class SelfCollisionConstraint, IDisposable
    {
        // Fields
        public static System.UInt32 KindPoint;        // 0x0
        public static System.UInt32 KindEdge;        // 0x0
        public static System.UInt32 KindTriangle;        // 0x0
        public static System.UInt32 Flag_KindMask;        // 0x0
        public static System.UInt32 Flag_Fix0;        // 0x0
        public static System.UInt32 Flag_Fix1;        // 0x0
        public static System.UInt32 Flag_Fix2;        // 0x0
        public static System.UInt32 Flag_AllFix;        // 0x0
        public static System.UInt32 Flag_Ignore;        // 0x0
        public static System.UInt32 Flag_Enable;        // 0x0
        private BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive> primitiveArray;        // 0x10
        private BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData> sortAndSweepArray;        // 0x18
        private System.Int32 <PointPrimitiveCount>k__BackingField;        // 0x20
        private System.Int32 <EdgePrimitiveCount>k__BackingField;        // 0x24
        private System.Int32 <TrianglePrimitiveCount>k__BackingField;        // 0x28
        private Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactQueue;        // 0x30
        private Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact> edgeEdgeContactList;        // 0x48
        private Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactQueue;        // 0x58
        private Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact> pointTriangleContactList;        // 0x70
        private Unity.Collections.NativeArray<System.Byte> intersectFlagArray;        // 0x80
        private System.Int32 <IntersectCount>k__BackingField;        // 0x90

        // Methods
        private System.Int32 get_PointPrimitiveCount() { }
        private System.Void set_PointPrimitiveCount(System.Int32 value) { }
        private System.Int32 get_EdgePrimitiveCount() { }
        private System.Void set_EdgePrimitiveCount(System.Int32 value) { }
        private System.Int32 get_TrianglePrimitiveCount() { }
        private System.Void set_TrianglePrimitiveCount(System.Int32 value) { }
        private System.Int32 get_IntersectCount() { }
        private System.Void set_IntersectCount(System.Int32 value) { }
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Boolean HasPrimitive() { }
        private System.String ToString() { }
        private System.Void Register(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void Exit(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void UpdateTeam(System.Int32 teamId) { }
        private System.Void InitPrimitive(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData tdata, System.UInt32 kind, System.Int32 startPrimitive, System.Int32 startSort, System.Int32 length) { }
        private System.Void WorkBufferUpdate() { }
        private System.Int32 BinarySearchSortAndlSweep(Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>& sortAndSweepArray, BeyondDynamicBone.SelfCollisionConstraint.SortData& sd, BeyondDynamicBone.DataChunk& chunk) { }
        private Unity.Jobs.JobHandle SolverConstraint(System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle SolverRuntimeSelfCollision(System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle SolverBroadPhase(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle UpdateBroadPhase(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle SolveIntersect(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_00000145$BurstDirectCall() { }
        private System.Void Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_00000146$BurstDirectCall() { }
        private System.Void Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000147$BurstDirectCall() { }
        private System.Void Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000148$BurstDirectCall() { }
        private System.Void Initialize$ClearBufferJobKernels_ClearBufferKernel_00000149$BurstDirectCall() { }
        private System.Void Initialize$SortJobKernels_SortKernel_0000014A$BurstDirectCall() { }
        private System.Void Initialize$SortJobKernels_SortRangeKernel_0000014B$BurstDirectCall() { }
        private System.Void Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_0000017E$BurstDirectCall() { }
        private System.Void Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_0000017F$BurstDirectCall() { }
        private System.Void Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000180$BurstDirectCall() { }
        private System.Void Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_00000181$BurstDirectCall() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000091
    public class SpringConstraint, IDisposable
    {
        // Methods
        private System.Void Dispose() { }
        private Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000095
    public class TethreConstraintKernel_00000193$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000096
    public class TethreConstraintKernel_00000193$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index) { }

    }

    // TypeToken: 0x2000097
    public class TethreConstraintRangeKernel_00000194$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000098
    public class TethreConstraintRangeKernel_00000194$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000094
    public class TethreConstraintJobKernels
    {
        // Methods
        private System.Void TethreConstraintKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index) { }
        private System.Void TethreConstraintRangeKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr) { }
        private System.Void TethreConstraintKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index) { }
        private System.Void TethreConstraintRangeKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000099
    public class TetherConstraint, IDisposable
    {
        // Methods
        private System.Void Dispose() { }
        private Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009D
    public class TriangleBendingConstraint, IDisposable
    {
        // Fields
        private static System.SByte VOLUME_SIGN;        // 0x0
        public BeyondDynamicBone.ExNativeArray<System.UInt64> trianglePairArray;        // 0x10
        public BeyondDynamicBone.ExNativeArray<System.Single> restAngleOrVolumeArray;        // 0x18
        public BeyondDynamicBone.ExNativeArray<System.SByte> signOrVolumeArray;        // 0x20
        public BeyondDynamicBone.ExNativeArray<System.UInt32> writeDataArray;        // 0x28
        public BeyondDynamicBone.ExNativeArray<System.UInt32> writeIndexArray;        // 0x30
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> writeBuffer;        // 0x38
        private static System.Single VolumeScale;        // 0x0

        // Methods
        private System.Int32 get_DataCount() { }
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.String ToString() { }
        private BeyondDynamicBone.TriangleBendingConstraint.ConstraintData CreateData(BeyondDynamicBone.VirtualMesh proxyMesh, BeyondDynamicBone.ClothParameters& parameters) { }
        private System.Void InitVolume(BeyondDynamicBone.VirtualMesh proxyMesh, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Single& volumeRest, System.SByte& signFlag) { }
        private System.Void InitDihedralAngle(BeyondDynamicBone.VirtualMesh proxyMesh, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Single& restAngle, System.SByte& signFlag) { }
        private System.Void Register(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void Exit(BeyondDynamicBone.ClothProcess cprocess) { }
        private Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void Initialize$TriangleBendingJobKernels_TriangleBendingKernel_000001AA$BurstDirectCall() { }
        private System.Void Initialize$TriangleBendingJobKernels_TriangleBendingRangeKernel_000001AB$BurstDirectCall() { }
        private System.Void Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001AE$BurstDirectCall() { }
        private System.Void Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001AF$BurstDirectCall() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x20000AE
    public class CullingSettings, IDataValidate
    {
        // Fields
        public BeyondDynamicBone.CullingSettings.CameraCullingMode cameraCullingMode;        // 0x10
        public BeyondDynamicBone.CullingSettings.CameraCullingMethod cameraCullingMethod;        // 0x14
        public System.Collections.Generic.List<UnityEngine.Renderer> cameraCullingRenderers;        // 0x18
        public BeyondDynamicBone.CheckSliderSerializeData distanceCullingLength;        // 0x20
        public System.Single distanceCullingFadeRatio;        // 0x28
        public UnityEngine.GameObject distanceCullingReferenceObject;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.CullingSettings Clone() { }
        private System.Int32 GetHashCode() { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x20000B2
    public class CurveSerializeData
    {
        // Fields
        public System.Single value;        // 0x10
        public System.Boolean useCurve;        // 0x14
        public UnityEngine.AnimationCurve curve;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Single value) { }
        private System.Void .ctor(System.Single value, System.Single curveStart, System.Single curveEnd, System.Boolean useCurve) { }
        private System.Void .ctor(System.Single value, UnityEngine.AnimationCurve curve) { }
        private System.Void SetValue(System.Single value) { }
        private System.Void SetValue(System.Single value, System.Single curveStart, System.Single curveEnd, System.Boolean useCurve) { }
        private System.Void SetValue(System.Single value, UnityEngine.AnimationCurve curve) { }
        private System.Void DataValidate(System.Single min, System.Single max) { }
        private System.Single Evaluate(System.Single time) { }
        private Unity.Mathematics.float4x4 ConvertFloatArray() { }
        private BeyondDynamicBone.CurveSerializeData Clone() { }

    }

    // TypeToken: 0x20000B3
    public class CustomSkinningSettings, IValid, IDataValidate, ITransform
    {
        // Fields
        public System.Boolean enable;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Transform> skinningBones;        // 0x18

        // Methods
        private System.Void DataValidate() { }
        private System.Boolean IsValid() { }
        private BeyondDynamicBone.CustomSkinningSettings Clone() { }
        private System.Int32 GetHashCode() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Void .ctor() { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x20000B5
    public class GizmoSerializeData
    {
        // Fields
        public System.Boolean always;        // 0x10
        public BeyondDynamicBone.ClothDebugSettings clothDebugSettings;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Boolean IsAlways() { }

    }

    // TypeToken: 0x20000B6
    public class NormalAlignmentSettings, IValid, IDataValidate, ITransform
    {
        // Fields
        public BeyondDynamicBone.NormalAlignmentSettings.AlignmentMode alignmentMode;        // 0x10
        public UnityEngine.Transform adjustmentTransform;        // 0x18

        // Methods
        private System.Void DataValidate() { }
        private System.Boolean IsValid() { }
        private BeyondDynamicBone.NormalAlignmentSettings Clone() { }
        private System.Int32 GetHashCode() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Void .ctor() { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x20000B8
    public class SelectionData, IValid
    {
        // Fields
        public Unity.Mathematics.float3[] positions;        // 0x10
        public BeyondDynamicBone.VertexAttribute[] attributes;        // 0x18
        public System.Single maxConnectionDistance;        // 0x20
        public System.Boolean userEdit;        // 0x24

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 cnt) { }
        private System.Void .ctor(BeyondDynamicBone.VirtualMesh vmesh, Unity.Mathematics.float4x4 transformMatrix) { }
        private System.Int32 get_Count() { }
        private System.Boolean IsValid() { }
        private System.Boolean IsUserEdit() { }
        private BeyondDynamicBone.SelectionData Clone() { }
        private System.Boolean Compare(BeyondDynamicBone.SelectionData sdata) { }
        private System.Void AddRange(Unity.Mathematics.float3[] addPositions, BeyondDynamicBone.VertexAttribute[] addAttributes) { }
        private System.Void Fill(BeyondDynamicBone.VertexAttribute attr) { }
        private Unity.Collections.NativeArray<Unity.Mathematics.float3> GetPositionNativeArray() { }
        private Unity.Collections.NativeArray<Unity.Mathematics.float3> GetPositionNativeArray(Unity.Mathematics.float4x4 transformMatrix) { }
        private Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> GetAttributeNativeArray() { }
        private BeyondDynamicBone.GridMap<System.Int32> CreateGridMapRun(System.Single gridSize, Unity.Collections.NativeArray<Unity.Mathematics.float3>& positions, Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>& attributes, System.Boolean move, System.Boolean fix, System.Boolean ignore, System.Boolean invalid) { }
        private System.Void Merge(BeyondDynamicBone.SelectionData from) { }
        private System.Void ConvertFrom(BeyondDynamicBone.SelectionData from) { }

    }

    // TypeToken: 0x20000BC
    public class BeyondBoneWindZone : ClothBehaviour
    {
        // Fields
        public BeyondDynamicBone.BeyondBoneWindZone.Mode mode;        // 0x20
        public UnityEngine.Vector3 size;        // 0x24
        public System.Single radius;        // 0x30
        public System.Single main;        // 0x34
        public System.Single turbulence;        // 0x38
        public System.Single directionAngleX;        // 0x3C
        public System.Single directionAngleY;        // 0x40
        public UnityEngine.AnimationCurve attenuation;        // 0x48
        public System.Boolean isAddition;        // 0x50
        private System.Int32 <WindId>k__BackingField;        // 0x54

        // Methods
        private System.Int32 get_WindId() { }
        private System.Void set_WindId(System.Int32 value) { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Boolean IsDirection() { }
        private System.Boolean IsRadial() { }
        private System.Boolean IsAddition() { }
        private UnityEngine.Vector3 GetWindDirection(System.Boolean localSpace) { }
        private System.Void SetWindDirection(UnityEngine.Vector3 dir, System.Boolean localSpace) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BE
    public struct WindParams, IValid
    {
        // Fields
        public System.Single influence;        // 0x10
        public System.Single frequency;        // 0x14
        public System.Single turbulence;        // 0x18
        public System.Single blend;        // 0x1C
        public System.Single synchronization;        // 0x20
        public System.Single depthWeight;        // 0x24
        public System.Single movingWind;        // 0x28

        // Methods
        private System.Void Convert(BeyondDynamicBone.WindSettings sdata, BeyondDynamicBone.ClothProcess.ClothType clothType) { }
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x20000BF
    public class WindSettings, IValid, IDataValidate
    {
        // Fields
        public System.Single influence;        // 0x10
        public System.Single frequency;        // 0x14
        public System.Single turbulence;        // 0x18
        public System.Single blend;        // 0x1C
        public System.Single synchronization;        // 0x20
        public System.Single depthWeight;        // 0x24
        public System.Single movingWind;        // 0x28

        // Methods
        private System.Boolean IsValid() { }
        private System.Void DataValidate() { }
        private BeyondDynamicBone.WindSettings Clone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C0
    public class Define
    {
    }

    // TypeToken: 0x20000C3
    public interface ICount
    {
        // Methods
        private System.Int32 Count() { }

    }

    // TypeToken: 0x20000C4
    public interface IDataValidate
    {
        // Methods
        private System.Void DataValidate() { }

    }

    // TypeToken: 0x20000C5
    public interface ITransform
    {
        // Methods
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }

    }

    // TypeToken: 0x20000C6
    public interface IValid
    {
        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x20000C7
    public class ClothManager, IManager, IDisposable, IValid
    {
        // Fields
        private System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess> clothSet;        // 0x10
        private System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess> boneClothSet;        // 0x18
        private System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess> meshClothSet;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Boolean> animatorVisibleDict;        // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,System.Boolean> rendererVisibleDict;        // 0x30
        private Unity.Jobs.JobHandle masterJob;        // 0x38
        private System.Boolean isValid;        // 0x48
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateTimeProfiler;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateTeamProfiler;        // 0x8
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdatePrePareProfiler;        // 0x10
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateScheduleProfiler;        // 0x18
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateScheduleStep1Profiler;        // 0x20
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateScheduleStep2Profiler;        // 0x28
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateScheduleStep3Profiler;        // 0x30
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateScheduleStep4Profiler;        // 0x38
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateScheduleStep5Profiler;        // 0x40
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateWaitMasterJobProfiler;        // 0x48

        // Methods
        private System.Void Dispose() { }
        private System.Void EnterdEditMode() { }
        private System.Void Initialize() { }
        private System.Boolean IsValid() { }
        private System.Void ClearMasterJob() { }
        private System.Void CompleteMasterJob() { }
        private System.Void ForceCompleteAllJob() { }
        private System.Int32 AddCloth(BeyondDynamicBone.ClothProcess cprocess, BeyondDynamicBone.ClothParameters& clothParams) { }
        private System.Void RemoveCloth(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void OnEarlyClothUpdate() { }
        private System.Void OnAfterUpdate() { }
        private System.Void OnApplicationQuit() { }
        private System.Void OnBeforeLateUpdate() { }
        private System.Void OnAfterLateUpdate() { }
        private System.Void ClothUpdate() { }
        private System.Void ClearVisibleDict() { }
        private System.Boolean CheckVisible(UnityEngine.Animator ani, System.Collections.Generic.List<UnityEngine.Renderer> renderers) { }
        private System.Boolean CheckLODVisible(UnityEngine.Animator ani, System.Int32 clothAnimatorAbilityLODThresholdProperty, System.Int32 clothAnimatorLODThresholdProperty) { }
        private System.Boolean CheckRendererVisible(System.Collections.Generic.List<UnityEngine.Renderer> renderers) { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C8
    public class PreBuildManager, IManager, IDisposable, IValid
    {
        // Fields
        private System.Collections.Generic.Dictionary<BeyondDynamicBone.SharePreBuildData,BeyondDynamicBone.PreBuildManager.ShareDeserializationData> deserializationDict;        // 0x10
        private System.Boolean isValid;        // 0x18
        private static readonly Unity.Profiling.ProfilerMarker deserializationProfiler;        // 0x0

        // Methods
        private System.Void Dispose() { }
        private System.Void EnterdEditMode() { }
        private System.Void Initialize() { }
        private System.Boolean IsValid() { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private BeyondDynamicBone.PreBuildManager.ShareDeserializationData RegisterPreBuildData(BeyondDynamicBone.SharePreBuildData sdata, System.Boolean referenceIncrement) { }
        private BeyondDynamicBone.PreBuildManager.ShareDeserializationData GetPreBuildData(BeyondDynamicBone.SharePreBuildData sdata) { }
        private System.Void UnregisterPreBuildData(BeyondDynamicBone.SharePreBuildData sdata) { }
        private System.Void UnloadUnusedData() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CA
    public struct DoAllInOneJob, IJob
    {
        // Fields
        public System.Runtime.InteropServices.GCHandle bmHandle;        // 0x10
        public System.Runtime.InteropServices.GCHandle tmHandle;        // 0x18
        public System.Runtime.InteropServices.GCHandle vmHandle;        // 0x20
        public System.Runtime.InteropServices.GCHandle smHandle;        // 0x28
        public System.Runtime.InteropServices.GCHandle wmHandle;        // 0x30
        public System.Runtime.InteropServices.GCHandle meshClothSetHandle;        // 0x38

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000CB
    public interface ICrossFrameParallelForJob : IJob
    {
        // Methods
        private System.Void SetIndexCount(System.Int32 indexCount) { }

    }

    // TypeToken: 0x20000CC
    public interface ICrossFrameParallelForDeferJob : IJob
    {
        // Methods
        private System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount) { }

    }

    // TypeToken: 0x20000CD
    public interface IUnsafeJob
    {
        // Methods
        private System.Void UnsafeDo() { }

    }

    // TypeToken: 0x20000CE
    public class CrossFrameJobUtils
    {
        // Fields
        public static System.Int32 s_MainThreadId;        // 0x0

        // Methods
        private Unity.Jobs.JobHandle ScheduleNoUseRun(T& jobData, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle Schedule2(T& jobData, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle Schedule(T& jobData, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle Schedule(T& jobData, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle Schedule2(T& jobData, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle Schedule2(T& jobData, System.Int32* forEachCount, Unity.Collections.NativeReference<System.Int32> forEachCountRef, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle Schedule(T& jobData, System.Int32* forEachCount, Unity.Collections.NativeReference<System.Int32> forEachCountRef, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn) { }

    }

    // TypeToken: 0x20000CF
    public class DynamicBoneTransformManager, IManager, IDisposable, IValid
    {
        // Fields
        private static System.Byte Flag_Read;        // 0x0
        private static System.Byte Flag_WorldRotWrite;        // 0x0
        private static System.Byte Flag_LocalPosRotWrite;        // 0x0
        private static System.Byte Flag_Restore;        // 0x0
        private static System.Byte Flag_Enable;        // 0x0
        private BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ExBitFlag8> flagArray;        // 0x10
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> initLocalPositionArray;        // 0x18
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> initLocalRotationArray;        // 0x20
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> positionArray;        // 0x28
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> lastpositionArray;        // 0x30
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> rotationArray;        // 0x38
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> lastrotationArray;        // 0x40
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> scaleArray;        // 0x48
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> localPositionArray;        // 0x50
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> lastlocalPositionArray;        // 0x58
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> localRotationArray;        // 0x60
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> lastlocalRotationArray;        // 0x68
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float4x4> localToWorldMatrixArray;        // 0x70
        private BeyondDynamicBone.ExNativeArray<System.Int16> teamIdArray;        // 0x78
        private UnityEngine.Jobs.TransformAccessArray transformAccessArray;        // 0x80
        private System.Collections.Generic.Dictionary<UnityEngine.Animator,System.Collections.Generic.List<System.Int32>> animatorTransformMap;        // 0x88
        private BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> componentPositionArray;        // 0x90
        private UnityEngine.Jobs.TransformAccessArray componentTransformAccessArray;        // 0x98
        private System.Boolean isValid;        // 0xA0

        // Methods
        private Unity.Jobs.JobHandle WriteAnimatorBufferData(Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& teamId2AnimatorInstnceId, Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>& animatorID2RWHandler, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& transformID2RWHandlerID) { }
        private Unity.Jobs.JobHandle ReadAnimatorBufferData(Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& teamId2AnimatorInstnceId, Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>& animatorID2RWHandler, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& transformID2RWHandlerID) { }
        private Unity.Jobs.JobHandle CopyDoubleBuffer(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle WriteDoubleBufferTransform(Unity.Jobs.JobHandle jobHandle) { }
        private System.Int32 get_Count() { }
        private System.Void Dispose() { }
        private System.Void EnterdEditMode() { }
        private System.Void Initialize() { }
        private System.Boolean IsValid() { }
        private BeyondDynamicBone.DataChunk AddTransform(BeyondDynamicBone.VirtualMeshContainer cmesh, System.Int32 teamId) { }
        private BeyondDynamicBone.DataChunk AddTransform(System.Int32 count, System.Int32 teamId) { }
        private BeyondDynamicBone.DataChunk AddTransform(UnityEngine.Transform t, BeyondDynamicBone.ExBitFlag8 flag, System.Int32 teamId) { }
        private System.Void SetTransform(UnityEngine.Transform t, BeyondDynamicBone.ExBitFlag8 flag, System.Int32 index, System.Int32 teamId) { }
        private System.Void CopyTransform(System.Int32 fromIndex, System.Int32 toIndex) { }
        private System.Void RemoveTransform(BeyondDynamicBone.DataChunk c) { }
        private System.Void EnableTransform(BeyondDynamicBone.DataChunk c, System.Boolean sw) { }
        private System.Void EnableTransform(System.Int32 index, System.Boolean sw) { }
        private BeyondDynamicBone.DataChunk Expand(BeyondDynamicBone.DataChunk c, System.Int32 newLength) { }
        private Unity.Jobs.JobHandle RestoreTransform(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle ReadTransform(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle WriteTransform(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle ValidPosition(Unity.Jobs.JobHandle jobHandle) { }
        private System.Int32 AddComponentTransform(UnityEngine.Transform t) { }
        private System.Void RemoveComponentTransform(System.Int32 index) { }
        private Unity.Jobs.JobHandle ReadComponentTransform(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private System.Void .ctor() { }
        private System.Void Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_0000025C$BurstDirectCall() { }
        private System.Void Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_0000025D$BurstDirectCall() { }

    }

    // TypeToken: 0x20000E3
    public class TeamManager, IManager, IDisposable, IValid
    {
        // Fields
        public static System.Int32 Flag_Valid;        // 0x0
        public static System.Int32 Flag_Enable;        // 0x0
        public static System.Int32 Flag_Reset;        // 0x0
        public static System.Int32 Flag_TimeReset;        // 0x0
        public static System.Int32 Flag_SyncSuspend;        // 0x0
        public static System.Int32 Flag_Running;        // 0x0
        public static System.Int32 Flag_Synchronization;        // 0x0
        public static System.Int32 Flag_StepRunning;        // 0x0
        public static System.Int32 Flag_Exit;        // 0x0
        public static System.Int32 Flag_KeepTeleport;        // 0x0
        public static System.Int32 Flag_InertiaShift;        // 0x0
        public static System.Int32 Flag_CameraCullingInvisible;        // 0x0
        public static System.Int32 Flag_CameraCullingKeep;        // 0x0
        public static System.Int32 Flag_Spring;        // 0x0
        public static System.Int32 Flag_SkipWriting;        // 0x0
        public static System.Int32 Flag_Anchor;        // 0x0
        public static System.Int32 Flag_AnchorReset;        // 0x0
        public static System.Int32 Flag_NegativeScale;        // 0x0
        public static System.Int32 Flag_NegativeScaleTeleport;        // 0x0
        public static System.Int32 Flag_DistanceCullingInvisible;        // 0x0
        public static System.Int32 Flag_RestoreTransformOnlyOnec;        // 0x0
        public static System.Int32 Flag_Tangent;        // 0x0
        public static System.Int32 Flag_Self_PointPrimitive;        // 0x0
        public static System.Int32 Flag_Self_EdgePrimitive;        // 0x0
        public static System.Int32 Flag_Self_TrianglePrimitive;        // 0x0
        public static System.Int32 Flag_Self_EdgeEdge;        // 0x0
        public static System.Int32 Flag_Sync_EdgeEdge;        // 0x0
        public static System.Int32 Flag_PSync_EdgeEdge;        // 0x0
        public static System.Int32 Flag_Self_PointTriangle;        // 0x0
        public static System.Int32 Flag_Sync_PointTriangle;        // 0x0
        public static System.Int32 Flag_PSync_PointTriangle;        // 0x0
        public static System.Int32 Flag_Self_TrianglePoint;        // 0x0
        public static System.Int32 Flag_Sync_TrianglePoint;        // 0x0
        public static System.Int32 Flag_PSync_TrianglePoint;        // 0x0
        public static System.Int32 Flag_Self_EdgeTriangleIntersect;        // 0x0
        public static System.Int32 Flag_Sync_EdgeTriangleIntersect;        // 0x0
        public static System.Int32 Flag_PSync_EdgeTriangleIntersect;        // 0x0
        public static System.Int32 Flag_Self_TriangleEdgeIntersect;        // 0x0
        public static System.Int32 Flag_Sync_TriangleEdgeIntersect;        // 0x0
        public static System.Int32 Flag_PSync_TriangleEdgeIntersect;        // 0x0
        public static System.Int32 Flag_Lod_LodOut;        // 0x0
        public static System.Int32 Flag_Lod_Culled;        // 0x0
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.TeamManager.TeamData> teamDataArray;        // 0x10
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.TeamWindData> teamWindArray;        // 0x18
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.TeamManager.MappingData> mappingDataArray;        // 0x20
        public BeyondDynamicBone.ExNativeArray<Unity.Collections.FixedList64Bytes<System.Int16>> teamMappingIndexArray;        // 0x28
        public Unity.Collections.NativeReference<System.Int32> maxUpdateCount;        // 0x30
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ClothParameters> parameterArray;        // 0x40
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.InertiaConstraint.CenterData> centerDataArray;        // 0x48
        private System.Collections.Generic.HashSet<System.Int32> enableTeamSet;        // 0x50
        private System.Collections.Generic.Dictionary<System.Int32,BeyondDynamicBone.ClothProcess> clothProcessDict;        // 0x58
        private System.Boolean isValid;        // 0x60
        private System.Int32 edgeColliderCollisionCount;        // 0x64
        private Unity.Collections.NativeReference<System.Int32> edgeColliderCollisionCountBuff;        // 0x68
        private Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2SuspendCounterMap;        // 0x78
        private Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2TeamIdMap;        // 0x88
        private Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2SyncPartnerCompMap;        // 0x98
        private Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> comp2SyncTopCompMap;        // 0xA8
        private Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> teamId2AnimatorInstnceId;        // 0xB8
        private Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle> animatorID2RWHandler;        // 0xC8
        private Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> transformID2RWHandlerID;        // 0xD8
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Animator> teamId2Animator;        // 0xE8
        private System.Collections.Generic.HashSet<System.Int32> dirtyAnimatorTransformTeams;        // 0xF0
        private System.Collections.Generic.HashSet<System.Int32> m_tempList;        // 0xF8
        private System.Collections.Generic.List<BeyondDynamicBone.ClothProcess> parameterDirtyList;        // 0x100
        private System.Collections.Generic.List<BeyondDynamicBone.ClothProcess> skipWritingDirtyList;        // 0x108
        private System.Collections.Generic.List<BeyondDynamicBone.ClothProcess> codeParameterDirtyList;        // 0x110
        private Unity.Collections.NativeList<System.Int32> cullingDirtyList;        // 0x118
        private Unity.Collections.NativeParallelHashSet<System.Int32> alwaysTeamUpdateSelfCollisionUpdateSet;        // 0x128
        private Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> animatorUpdateModeMap;        // 0x138
        private BeyondDynamicBone.ExSimpleNativeArray<System.Int32> teamAnchorTransformIndexArray;        // 0x148
        private BeyondDynamicBone.ExSimpleNativeArray<System.Int32> teamDistanceTransformIndexArray;        // 0x150
        private Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.float3> transformPositionMap;        // 0x158
        private Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.quaternion> transformRotationMap;        // 0x168
        private System.Collections.Generic.HashSet<BeyondDynamicBone.BeyondBoneCloth> cameraCullingClothSet;        // 0x178
        private static readonly Unity.Profiling.ProfilerMarker teamCameraCullingPreProfiler;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker teamCameraCullingProfiler;        // 0x8
        private static readonly Unity.Profiling.ProfilerMarker startClothUpdateComponentProfiler;        // 0x10
        private static readonly Unity.Profiling.ProfilerMarker alwaysTeamUpdateParameterDirtyProfiler;        // 0x18
        private static readonly Unity.Profiling.ProfilerMarker alwaysTeamUpdateStep2Profiler;        // 0x20
        private static readonly Unity.Profiling.ProfilerMarker alwaysTeamUpdateStep3Profiler;        // 0x28
        private static readonly Unity.Profiling.ProfilerMarker alwaysTeamUpdateEdgeColliderProfiler;        // 0x30
        private static readonly Unity.Profiling.ProfilerMarker alwaysTeamUpdateSelfCollisionStepProfiler;        // 0x38
        private System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess> monitoringProcessSet;        // 0x180
        private System.Collections.Generic.List<BeyondDynamicBone.ClothProcess> disposeProcessList;        // 0x188

        // Methods
        private System.Int32 get_MappingCount() { }
        private System.Int32 get_TeamCount() { }
        private System.Int32 get_TrueTeamCount() { }
        private System.Int32 get_ActiveTeamCount() { }
        private System.Void UpdateTeamAnimatorData(BeyondDynamicBone.ExNativeArray<System.Int16> teamIdArray, UnityEngine.Jobs.TransformAccessArray transformArray) { }
        private System.Void ClearTeamAnimatorData(System.Int32 teamId) { }
        private System.Void AddTeamAnimatorData(System.Int32 teamId, BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void AddAnimatorTransform(System.Int32 teamId, UnityEngine.Transform t) { }
        private System.Void MarkAnimatorTransformDirty(System.Int32 teamId, UnityEngine.Transform t) { }
        private System.Void Dispose() { }
        private System.Void EnterdEditMode() { }
        private System.Void Initialize() { }
        private System.Boolean IsValid() { }
        private System.Int32 AddTeam(BeyondDynamicBone.ClothProcess cprocess, BeyondDynamicBone.ClothParameters clothParams) { }
        private System.Void RemoveTeam(System.Int32 teamId) { }
        private System.Void SetEnable(System.Int32 teamId, System.Boolean sw) { }
        private System.Boolean IsEnable(System.Int32 teamId) { }
        private System.Void SetSkipWriting(System.Int32 teamId, System.Boolean sw) { }
        private System.Boolean ContainsTeamData(System.Int32 teamId) { }
        private BeyondDynamicBone.TeamManager.TeamData& GetTeamDataRef(System.Int32 teamId) { }
        private Unity.Collections.FixedList64Bytes<System.Int16>& GetTeamMappingRef(System.Int32 teamId) { }
        private BeyondDynamicBone.ClothParameters& GetParametersRef(System.Int32 teamId) { }
        private BeyondDynamicBone.InertiaConstraint.CenterData& GetCenterDataRef(System.Int32 teamId) { }
        private BeyondDynamicBone.ClothProcess GetClothProcess(System.Int32 teamId) { }
        private System.Void CameraCullingPreProcess() { }
        private System.Void CameraCullingPostProcess() { }
        private System.Void AlwaysTeamUpdate() { }
        private System.Void RemoveSyncParent(BeyondDynamicBone.TeamManager.TeamData& tdata, System.Int32 parentTeamId) { }
        private Unity.Jobs.JobHandle CalcCenterAndInertiaAndWind(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle SimulationStepTeamUpdate(System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostTeamUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void AddMonitoringProcess(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void RemoveMonitoringProcess(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void MonitoringProcess(System.Boolean force) { }
        private System.Void MonitoringProcessUpdate() { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void Initialize$PostTeamUpdateJobKernels_PostTeamUpdateKernel_00000298$BurstDirectCall() { }
        private System.Void Initialize$PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_00000299$BurstDirectCall() { }

    }

    // TypeToken: 0x2000101
    public class VirtualMeshManager, IManager, IDisposable, IValid
    {
        // Fields
        public BeyondDynamicBone.ExNativeArray<System.Int16> teamIds;        // 0x10
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x18
        public BeyondDynamicBone.ExNativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>> vertexToTriangles;        // 0x20
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> vertexBindPosePositions;        // 0x28
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> vertexBindPoseRotations;        // 0x30
        public BeyondDynamicBone.ExNativeArray<System.Single> vertexDepths;        // 0x38
        public BeyondDynamicBone.ExNativeArray<System.Int32> vertexRootIndices;        // 0x40
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> vertexLocalPositions;        // 0x48
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> vertexLocalRotations;        // 0x50
        public BeyondDynamicBone.ExNativeArray<System.Int32> vertexParentIndices;        // 0x58
        public BeyondDynamicBone.ExNativeArray<System.UInt32> vertexChildIndexArray;        // 0x60
        public BeyondDynamicBone.ExNativeArray<System.UInt16> vertexChildDataArray;        // 0x68
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> normalAdjustmentRotations;        // 0x70
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float2> uv;        // 0x78
        public BeyondDynamicBone.ExNativeArray<System.Int16> triangleTeamIdArray;        // 0x80
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.int3> triangles;        // 0x88
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> triangleNormals;        // 0x90
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> triangleTangents;        // 0x98
        public BeyondDynamicBone.ExNativeArray<System.Int16> edgeTeamIdArray;        // 0xA0
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.int2> edges;        // 0xA8
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ExBitFlag8> edgeFlags;        // 0xB0
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ExBitFlag8> baseLineFlags;        // 0xB8
        public BeyondDynamicBone.ExNativeArray<System.Int16> baseLineTeamIds;        // 0xC0
        public BeyondDynamicBone.ExNativeArray<System.UInt16> baseLineStartDataIndices;        // 0xC8
        public BeyondDynamicBone.ExNativeArray<System.UInt16> baseLineDataCounts;        // 0xD0
        public BeyondDynamicBone.ExNativeArray<System.UInt16> baseLineData;        // 0xD8
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> localPositions;        // 0xE0
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> localNormals;        // 0xE8
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> localTangents;        // 0xF0
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0xF8
        public BeyondDynamicBone.ExNativeArray<System.Int32> skinBoneTransformIndices;        // 0x100
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float4x4> skinBoneBindPoses;        // 0x108
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> vertexToTransformRotations;        // 0x110
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> positions;        // 0x118
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> rotations;        // 0x120
        public BeyondDynamicBone.ExNativeArray<System.Int16> mappingIdArray;        // 0x128
        public BeyondDynamicBone.ExNativeArray<System.Int32> mappingReferenceIndices;        // 0x130
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.VertexAttribute> mappingAttributes;        // 0x138
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> mappingLocalPositins;        // 0x140
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> mappingLocalNormals;        // 0x148
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> mappingLocalTangents;        // 0x150
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> mappingBoneWeights;        // 0x158
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> mappingPositions;        // 0x160
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> mappingNormals;        // 0x168
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> mappingTangents;        // 0x170
        private System.Boolean isValid;        // 0x178

        // Methods
        private System.Void CreateProxyMeshUpdateVertexListKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32 teamId) { }
        private System.Void CreateProxyMeshUpdateVertexListRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32 length) { }
        private System.Int32 get_ProxyVertexCount() { }
        private System.Int32 get_ProxyTriangleCount() { }
        private System.Int32 get_ProxyEdgeCount() { }
        private System.Int32 get_ProxyBaseLineCount() { }
        private System.Int32 get_ProxyLocalPositionCount() { }
        private System.Int32 get_MappingVertexCount() { }
        private System.Void Dispose() { }
        private System.Void EnterdEditMode() { }
        private System.Void Initialize() { }
        private System.Boolean IsValid() { }
        private System.Void RegisterProxyMesh(System.Int32 teamId, BeyondDynamicBone.VirtualMeshContainer proxyMeshContainer) { }
        private System.Void ExitProxyMesh(System.Int32 teamId) { }
        private BeyondDynamicBone.DataChunk RegisterMappingMesh(System.Int32 teamId, BeyondDynamicBone.VirtualMeshContainer mappingMeshContainer) { }
        private System.Void ExitMappingMesh(System.Int32 teamId, System.Int32 mappingIndex) { }
        private System.Void UpdateBuffer() { }
        private Unity.Jobs.JobHandle PreProxyMeshUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostProxyMeshUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostMappingMeshUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private System.Void .ctor() { }
        private System.Void Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002E6$BurstDirectCall() { }
        private System.Void Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002E7$BurstDirectCall() { }
        private System.Void Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002E8$BurstDirectCall() { }
        private System.Void Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002E9$BurstDirectCall() { }
        private System.Void Initialize$WriteTransformDataJobKernels_WriteTransformDataKernel_000002EA$BurstDirectCall() { }
        private System.Void Initialize$WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002EB$BurstDirectCall() { }
        private System.Void Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002EC$BurstDirectCall() { }
        private System.Void Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002ED$BurstDirectCall() { }
        private System.Void Initialize$CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002EE$BurstDirectCall() { }
        private System.Void Initialize$CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002EF$BurstDirectCall() { }
        private System.Void Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002F0$BurstDirectCall() { }
        private System.Void Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002F1$BurstDirectCall() { }
        private System.Void Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002F2$BurstDirectCall() { }
        private System.Void Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002F3$BurstDirectCall() { }
        private System.Void Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_000002F4$BurstDirectCall() { }
        private System.Void Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_000002F5$BurstDirectCall() { }
        private System.Void Initialize$ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_000002F6$BurstDirectCall() { }

    }

    // TypeToken: 0x200013D
    public interface IManager : IDisposable
    {
        // Methods
        private System.Void Initialize() { }
        private System.Void EnterdEditMode() { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }

    }

    // TypeToken: 0x200013E
    public class MagicaManager
    {
        // Fields
        private static System.Collections.Generic.List<BeyondDynamicBone.IManager> managers;        // 0x0
        public static System.Boolean EnableTick;        // 0x8
        public static System.Boolean UseCrossFrameJob;        // 0x9
        public static System.Boolean UseAnimatorTransform;        // 0xA
        public static BeyondDynamicBone.MagicaManager.UpdateMethod afterEarlyUpdateDelegate;        // 0x10
        public static BeyondDynamicBone.MagicaManager.UpdateMethod afterFixedUpdateDelegate;        // 0x18
        public static BeyondDynamicBone.MagicaManager.UpdateMethod afterUpdateDelegate;        // 0x20
        public static BeyondDynamicBone.MagicaManager.UpdateMethod beforeLateUpdateDelegate;        // 0x28
        public static BeyondDynamicBone.MagicaManager.UpdateMethod afterLateUpdateDelegate;        // 0x30
        public static BeyondDynamicBone.MagicaManager.UpdateMethod afterDelayedDelegate;        // 0x38
        public static BeyondDynamicBone.MagicaManager.UpdateMethod afterRenderingDelegate;        // 0x40
        public static BeyondDynamicBone.MagicaManager.UpdateMethod defaultUpdateDelegate;        // 0x48
        public static BeyondDynamicBone.MagicaManager.UpdateMethod onApplicationQuitDelegate;        // 0x50
        private static System.Boolean isPlaying;        // 0x58
        public static System.Action OnPreSimulation;        // 0x60
        public static System.Action OnPostSimulation;        // 0x68
        private static BeyondDynamicBone.MagicaManager.InitializationLocation initializationLocation;        // 0x70

        // Methods
        private BeyondDynamicBone.TimeManager get_Time() { }
        private BeyondDynamicBone.TeamManager get_Team() { }
        private BeyondDynamicBone.ClothManager get_Cloth() { }
        private BeyondDynamicBone.RenderManager get_Render() { }
        private BeyondDynamicBone.DynamicBoneTransformManager get_Bone() { }
        private BeyondDynamicBone.VirtualMeshManager get_VMesh() { }
        private BeyondDynamicBone.SimulationManager get_Simulation() { }
        private BeyondDynamicBone.ColliderManager get_Collider() { }
        private BeyondDynamicBone.WindManager get_Wind() { }
        private BeyondDynamicBone.PreBuildManager get_PreBuild() { }
        private System.Void Initialize() { }
        private System.Void Dispose() { }
        private System.Boolean IsPlaying() { }
        private System.Void SetUseCrossFrameJob(System.Boolean value) { }
        private System.Void InitCustomGameLoop() { }
        private System.Void SetCustomGameLoop(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop) { }
        private System.Boolean CheckRegist(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop) { }
        private System.Void SetGlobalTimeScale(System.Single timeScale) { }
        private System.Single GetGlobalTimeScale() { }
        private System.Void SetSimulationFrequency(System.Int32 freq) { }
        private System.Void SetAOVMode(System.Boolean enable, System.Single deltaTime) { }
        private System.Void DoAOVUpdate() { }
        private System.Void DoAOVAfterAnimatorUpdate() { }
        private System.Int32 GetSimulationFrequency() { }
        private System.Void SetMaxSimulationCountPerFrame(System.Int32 count) { }
        private System.Int32 GetMaxSimulationCountPerFrame() { }
        private System.Void SetUpdateLocation(BeyondDynamicBone.TimeManager.UpdateLocation updateLocation) { }
        private BeyondDynamicBone.TimeManager.UpdateLocation GetUpdateLocation() { }
        private System.Void UnloadUnusedData() { }
        private System.Void SetInitializationLocation(BeyondDynamicBone.MagicaManager.InitializationLocation initLocation) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000143
    public class MagicaSettings : ClothBehaviour
    {
        // Fields
        public BeyondDynamicBone.MagicaSettings.RefreshMode refreshMode;        // 0x20
        public System.Int32 simulationFrequency;        // 0x24
        public System.Int32 maxSimulationCountPerFrame;        // 0x28
        public BeyondDynamicBone.MagicaManager.InitializationLocation initializationLocation;        // 0x2C
        public BeyondDynamicBone.TimeManager.UpdateLocation updateLocation;        // 0x30
        public System.Boolean monitorPlayerLoop;        // 0x34

        // Methods
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void OnValidate() { }
        private System.Void Refresh() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000146
    public class UpdatePositionNormalKernel_00000359$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000147
    public class UpdatePositionNormalKernel_00000359$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index) { }

    }

    // TypeToken: 0x2000148
    public class UpdatePositionNormalRangeKernel_0000035A$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000149
    public class UpdatePositionNormalRangeKernel_0000035A$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length) { }

    }

    // TypeToken: 0x2000145
    public class UpdatePositionNormalJobKernels
    {
        // Methods
        private System.Void UpdatePositionNormalKernel(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index) { }
        private System.Void UpdatePositionNormalRangeKernel(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length) { }
        private System.Void UpdatePositionNormalKernel$BurstManaged(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index) { }
        private System.Void UpdatePositionNormalRangeKernel$BurstManaged(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length) { }

    }

    // TypeToken: 0x200014B
    public class UpdatePositionNormalTangentKernel_0000035B$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200014C
    public class UpdatePositionNormalTangentKernel_0000035B$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index) { }

    }

    // TypeToken: 0x200014D
    public class UpdatePositionNormalTangentRangeKernel_0000035C$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200014E
    public class UpdatePositionNormalTangentRangeKernel_0000035C$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length) { }

    }

    // TypeToken: 0x200014A
    public class UpdatePositionNormalTangentJobKernels
    {
        // Methods
        private System.Void UpdatePositionNormalTangentKernel(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index) { }
        private System.Void UpdatePositionNormalTangentRangeKernel(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length) { }
        private System.Void UpdatePositionNormalTangentKernel$BurstManaged(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index) { }
        private System.Void UpdatePositionNormalTangentRangeKernel$BurstManaged(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length) { }

    }

    // TypeToken: 0x2000150
    public class UpdateBoneWeight2Kernel_0000035D$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000151
    public class UpdateBoneWeight2Kernel_0000035D$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index) { }

    }

    // TypeToken: 0x2000152
    public class UpdateBoneWeight2RangeKernel_0000035E$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000153
    public class UpdateBoneWeight2RangeKernel_0000035E$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length) { }

    }

    // TypeToken: 0x200014F
    public class UpdateBoneWeightJob2Kernels
    {
        // Methods
        private System.Void UpdateBoneWeight2Kernel(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index) { }
        private System.Void UpdateBoneWeight2RangeKernel(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length) { }
        private System.Void UpdateBoneWeight2Kernel$BurstManaged(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index) { }
        private System.Void UpdateBoneWeight2RangeKernel$BurstManaged(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length) { }

    }

    // TypeToken: 0x2000154
    public class RenderData, IDisposable, ITransform
    {
        // Fields
        private System.Int32 <ReferenceCount>k__BackingField;        // 0x10
        private System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess> useProcessSet;        // 0x18
        private System.Boolean isSkipWriting;        // 0x20
        private BeyondDynamicBone.RenderSetupData setupData;        // 0x28
        private BeyondDynamicBone.RenderSetupData.UniqueSerializationData preBuildUniqueSerializeData;        // 0x30
        private UnityEngine.Mesh originalMesh;        // 0x38
        private UnityEngine.SkinnedMeshRenderer skinnedMeshRendere;        // 0x40
        private UnityEngine.MeshFilter meshFilter;        // 0x48
        private System.Collections.Generic.List<UnityEngine.Transform> transformList;        // 0x50
        private UnityEngine.Mesh customMesh;        // 0x58
        private Unity.Collections.NativeArray<UnityEngine.Vector3> localPositions;        // 0x60
        private Unity.Collections.NativeArray<UnityEngine.Vector3> localNormals;        // 0x70
        private Unity.Collections.NativeArray<UnityEngine.Vector4> localTangents;        // 0x80
        private Unity.Collections.NativeArray<UnityEngine.BoneWeight> boneWeights;        // 0x90
        private UnityEngine.BoneWeight centerBoneWeight;        // 0xA0
        private static System.Int32 Flag_UseCustomMesh;        // 0x0
        private static System.Int32 Flag_ChangePositionNormal;        // 0x0
        private static System.Int32 Flag_ChangeBoneWeight;        // 0x0
        private static System.Int32 Flag_ModifyBoneWeight;        // 0x0
        private static System.Int32 Flag_HasMeshTangent;        // 0x0
        private static System.Int32 Flag_HasTangent;        // 0x0
        private static System.Int32 Flag_ChangeTangent;        // 0x0
        private Unity.Collections.BitField32 flag;        // 0xC0

        // Methods
        private System.Int32 get_ReferenceCount() { }
        private System.Void set_ReferenceCount(System.Int32 value) { }
        private System.String get_Name() { }
        private System.Boolean get_HasSkinnedMesh() { }
        private System.Boolean get_HasBoneWeight() { }
        private System.Boolean get_UseCustomMesh() { }
        private System.Boolean get_HasMeshTangent() { }
        private System.Boolean get_HasTangent() { }
        private System.Void Dispose() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Void Initialize(UnityEngine.Renderer ren, BeyondDynamicBone.RenderSetupData referenceSetupData, BeyondDynamicBone.RenderSetupData.UniqueSerializationData referencePreBuildUniqueSetupData) { }
        private BeyondDynamicBone.ResultCode get_Result() { }
        private System.Int32 AddReferenceCount() { }
        private System.Int32 RemoveReferenceCount() { }
        private System.Void SwapCustomMesh() { }
        private System.Void ResetCustomMeshWorkData() { }
        private System.Void SwapOriginalMesh() { }
        private System.Void SetMesh(UnityEngine.Mesh mesh) { }
        private System.Void StartUse(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void EndUse(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void UpdateUse(BeyondDynamicBone.ClothProcess cprocess, System.Int32 add) { }
        private System.Void UpdateSkipWriting() { }
        private System.Void WriteMesh() { }
        private Unity.Jobs.JobHandle UpdatePositionNormal(System.Boolean updateTangent, BeyondDynamicBone.DataChunk mappingChunk, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle UpdateBoneWeight(BeyondDynamicBone.DataChunk mappingChunk, Unity.Jobs.JobHandle jobHandle) { }
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000159
    public class RenderManager, IManager, IDisposable, IValid
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Int32,BeyondDynamicBone.RenderData> renderDataDict;        // 0x10
        private System.Boolean isValid;        // 0x18

        // Methods
        private System.Void Initialize() { }
        private System.Void EnterdEditMode() { }
        private System.Void Dispose() { }
        private System.Boolean IsValid() { }
        private System.Int32 AddRenderer(UnityEngine.Renderer ren, BeyondDynamicBone.RenderSetupData referenceSetupData, BeyondDynamicBone.RenderSetupData.UniqueSerializationData referenceUniqueSetupData) { }
        private System.Boolean RemoveRenderer(System.Int32 handle) { }
        private BeyondDynamicBone.RenderData GetRendererData(System.Int32 handle) { }
        private System.Void StartUse(BeyondDynamicBone.ClothProcess cprocess, System.Int32 handle) { }
        private System.Void EndUse(BeyondDynamicBone.ClothProcess cprocess, System.Int32 handle) { }
        private System.Void PreRenderingUpdate() { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015A
    public class RenderSetupData, IDisposable, ITransform
    {
        // Fields
        public BeyondDynamicBone.ResultCode result;        // 0x10
        public System.String name;        // 0x18
        public System.Boolean isManaged;        // 0x20
        public BeyondDynamicBone.RenderSetupData.SetupType setupType;        // 0x24
        public UnityEngine.Renderer renderer;        // 0x28
        public UnityEngine.SkinnedMeshRenderer skinRenderer;        // 0x30
        public UnityEngine.MeshFilter meshFilter;        // 0x38
        public UnityEngine.Mesh originalMesh;        // 0x40
        public System.Int32 vertexCount;        // 0x48
        public System.Boolean hasSkinnedMesh;        // 0x4C
        public System.Boolean hasBoneWeight;        // 0x4D
        public UnityEngine.Mesh.MeshDataArray meshDataArray;        // 0x50
        public System.Int32 skinRootBoneIndex;        // 0x60
        public System.Int32 skinBoneCount;        // 0x64
        public System.Collections.Generic.List<UnityEngine.Matrix4x4> bindPoseList;        // 0x68
        public Unity.Collections.NativeArray<System.Byte> bonesPerVertexArray;        // 0x70
        public Unity.Collections.NativeArray<UnityEngine.BoneWeight1> boneWeightArray;        // 0x80
        public Unity.Collections.NativeArray<UnityEngine.Vector3> localPositions;        // 0x90
        public Unity.Collections.NativeArray<UnityEngine.Vector3> localNormals;        // 0xA0
        public Unity.Collections.NativeArray<UnityEngine.Vector4> localTangents;        // 0xB0
        public System.Collections.Generic.List<System.Int32> rootTransformIdList;        // 0xC0
        public BeyondDynamicBone.RenderSetupData.BoneConnectionMode boneConnectionMode;        // 0xC8
        public System.Collections.Generic.List<System.Int32> collisionBoneIndexList;        // 0xD0
        public System.Collections.Generic.List<UnityEngine.Transform> transformList;        // 0xD8
        public System.Collections.Generic.List<System.Int32> transformIdList;        // 0xE0
        public System.Collections.Generic.List<System.Int32> transformParentIdList;        // 0xE8
        public System.Collections.Generic.List<Unity.Collections.FixedList512Bytes<System.Int32>> transformChildIdList;        // 0xF0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPositions;        // 0xF8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotations;        // 0x108
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformLocalPositins;        // 0x118
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformLocalRotations;        // 0x128
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformScales;        // 0x138
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformInverseRotations;        // 0x148
        public System.Int32 renderTransformIndex;        // 0x158
        public Unity.Mathematics.float4x4 initRenderLocalToWorld;        // 0x15C
        public Unity.Mathematics.float4x4 initRenderWorldtoLocal;        // 0x19C
        public Unity.Mathematics.quaternion initRenderRotation;        // 0x1DC
        public Unity.Mathematics.float3 initRenderScale;        // 0x1EC

        // Methods
        private System.Boolean IsSuccess() { }
        private System.Boolean IsFaild() { }
        private System.Int32 get_TransformCount() { }
        private System.Boolean get_HasMeshDataArray() { }
        private System.Boolean get_HasLocalPositions() { }
        private System.Boolean get_HasTangent() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Renderer ren) { }
        private System.Void .ctor(BeyondDynamicBone.RenderSetupData.SetupType setType, UnityEngine.Transform renderTransform, System.Collections.Generic.List<UnityEngine.Transform> rootTransforms, System.Collections.Generic.List<UnityEngine.Transform> ignoreFromRootBones, System.Collections.Generic.List<UnityEngine.Transform> collisionBones, BeyondDynamicBone.RenderSetupData.BoneConnectionMode connectionMode, System.String name) { }
        private System.Void ReadTransformInformation(System.Boolean includeChilds) { }
        private System.Void Dispose() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private UnityEngine.Transform GetRendeerTransform() { }
        private System.Int32 GetRenderTransformId() { }
        private Unity.Mathematics.float4x4 GetRendeerLocalToWorldMatrix() { }
        private UnityEngine.Transform GetSkinRootTransform() { }
        private System.Int32 GetSkinRootTransformId() { }
        private System.Int32 GetTransformIndexFromId(System.Int32 id) { }
        private System.Int32 GetParentTransformIndex(System.Int32 index, System.Boolean centerExcluded) { }
        private System.Void GetBoneWeightsRun(Unity.Collections.NativeArray<UnityEngine.BoneWeight> weights) { }
        private BeyondDynamicBone.RenderSetupData.ShareSerializationData ShareSerialize() { }
        private BeyondDynamicBone.RenderSetupData ShareDeserialize(BeyondDynamicBone.RenderSetupData.ShareSerializationData sdata) { }
        private BeyondDynamicBone.RenderSetupData.UniqueSerializationData UniqueSerialize() { }

    }

    // TypeToken: 0x2000164
    public class EndSimulationStepKernel_000003B8$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000165
    public class EndSimulationStepKernel_000003B8$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index) { }

    }

    // TypeToken: 0x2000166
    public class EndSimulationStepRangeKernel_000003B9$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr) { }
        private System.IAsyncResult BeginInvoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr, System.AsyncCallback , System.Object ) { }
        private System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000167
    public class EndSimulationStepRangeKernel_000003B9$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000163
    public class EndSimulationStepJobKernels
    {
        // Methods
        private System.Void EndSimulationStepKernel(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index) { }
        private System.Void EndSimulationStepRangeKernel(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr) { }
        private System.Void EndSimulationStepKernel$BurstManaged(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index) { }
        private System.Void EndSimulationStepRangeKernel$BurstManaged(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr) { }

    }

    // TypeToken: 0x2000168
    public class ColliderManager, IManager, IDisposable, IValid
    {
        // Fields
        public BeyondDynamicBone.ExNativeArray<System.Int16> teamIdArray;        // 0x10
        public static System.Byte Flag_Valid;        // 0x0
        public static System.Byte Flag_Enable;        // 0x0
        public static System.Byte Flag_Reset;        // 0x0
        public static System.Byte Flag_Reverse;        // 0x0
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ExBitFlag8> flagArray;        // 0x18
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> centerArray;        // 0x20
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> sizeArray;        // 0x28
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> framePositions;        // 0x30
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> frameRotations;        // 0x38
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> frameScales;        // 0x40
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> oldFramePositions;        // 0x48
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> oldFrameRotations;        // 0x50
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> nowPositions;        // 0x58
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> nowRotations;        // 0x60
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> oldPositions;        // 0x68
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> oldRotations;        // 0x70
        public System.Collections.Generic.HashSet<BeyondDynamicBone.ColliderComponent> colliderSet;        // 0x78
        private System.Boolean isValid;        // 0x80
        private BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ColliderManager.WorkData> workDataArray;        // 0x88

        // Methods
        private System.Int32 get_DataCount() { }
        private System.Int32 get_ColliderCount() { }
        private System.Void Dispose() { }
        private System.Void EnterdEditMode() { }
        private System.Void Initialize() { }
        private System.Boolean IsValid() { }
        private System.Void Register(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void Exit(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void InitColliders(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void UpdateColliders(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void AddCollider(BeyondDynamicBone.ClothProcess cprocess, BeyondDynamicBone.ColliderComponent col) { }
        private System.Void RemoveCollider(BeyondDynamicBone.ColliderComponent col, System.Int32 teamId) { }
        private System.Void AddColliderInternal(BeyondDynamicBone.ClothProcess cprocess, BeyondDynamicBone.ColliderComponent col, System.Int32 index, System.Int32 arrayIndex, System.Int32 transformIndex) { }
        private System.Void EnableCollider(BeyondDynamicBone.ColliderComponent col, System.Int32 teamId, System.Boolean sw) { }
        private System.Void EnableTeamCollider(System.Int32 teamId) { }
        private System.Void UpdateParameters(BeyondDynamicBone.ColliderComponent col, System.Int32 teamId) { }
        private Unity.Jobs.JobHandle PreSimulationUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle CreateUpdateColliderList(System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle StartSimulationStep(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle EndSimulationStep(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle PostSimulationUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private System.Void .ctor() { }
        private System.Void Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003D3$BurstDirectCall() { }
        private System.Void Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003D4$BurstDirectCall() { }
        private System.Void Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003D7$BurstDirectCall() { }
        private System.Void Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003D8$BurstDirectCall() { }

    }

    // TypeToken: 0x2000184
    public class SimulationManager, IManager, IDisposable, IValid
    {
        // Fields
        public BeyondDynamicBone.ExNativeArray<System.Int16> teamIdArray;        // 0x10
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> nextPosArray;        // 0x18
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> oldPosArray;        // 0x20
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> oldRotArray;        // 0x28
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> basePosArray;        // 0x30
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> baseRotArray;        // 0x38
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> oldPositionArray;        // 0x40
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion> oldRotationArray;        // 0x48
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> velocityPosArray;        // 0x50
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> dispPosArray;        // 0x58
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> velocityArray;        // 0x60
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> realVelocityArray;        // 0x68
        public BeyondDynamicBone.ExNativeArray<System.Single> frictionArray;        // 0x70
        public BeyondDynamicBone.ExNativeArray<System.Single> staticFrictionArray;        // 0x78
        public BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3> collisionNormalArray;        // 0x80
        public BeyondDynamicBone.DistanceConstraint distanceConstraint;        // 0x88
        public BeyondDynamicBone.TriangleBendingConstraint bendingConstraint;        // 0x90
        public BeyondDynamicBone.TetherConstraint tetherConstraint;        // 0x98
        public BeyondDynamicBone.AngleConstraint angleConstraint;        // 0xA0
        public BeyondDynamicBone.InertiaConstraint inertiaConstraint;        // 0xA8
        public BeyondDynamicBone.ColliderCollisionConstraint colliderCollisionConstraint;        // 0xB0
        public BeyondDynamicBone.MotionConstraint motionConstraint;        // 0xB8
        public BeyondDynamicBone.SelfCollisionConstraint selfCollisionConstraint;        // 0xC0
        private BeyondDynamicBone.ExProcessingList<System.Int32> processingStepParticle;        // 0xC8
        private BeyondDynamicBone.ExProcessingList<System.Int32> processingStepTriangleBending;        // 0xD0
        private BeyondDynamicBone.ExProcessingList<System.Int32> processingStepEdgeCollision;        // 0xD8
        private BeyondDynamicBone.ExProcessingList<System.Int32> processingStepCollider;        // 0xE0
        private BeyondDynamicBone.ExProcessingList<System.Int32> processingStepBaseLine;        // 0xE8
        private BeyondDynamicBone.ExProcessingList<System.Int32> processingStepMotionParticle;        // 0xF0
        private BeyondDynamicBone.ExProcessingList<System.Int32> processingSelfParticle;        // 0xF8
        private BeyondDynamicBone.ExProcessingList<System.UInt32> processingSelfPointTriangle;        // 0x100
        private BeyondDynamicBone.ExProcessingList<System.UInt32> processingSelfEdgeEdge;        // 0x108
        private BeyondDynamicBone.ExProcessingList<System.UInt32> processingSelfTrianglePoint;        // 0x110
        private Unity.Collections.NativeArray<Unity.Mathematics.float3> tempFloat3Buffer;        // 0x118
        private Unity.Collections.NativeArray<System.Int32> countArray;        // 0x128
        private Unity.Collections.NativeArray<System.Int32> sumArray;        // 0x138
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> stepBasicPositionBuffer;        // 0x148
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> stepBasicRotationBuffer;        // 0x158
        private System.Int32 <SimulationStepCount>k__BackingField;        // 0x168
        private System.Boolean isValid;        // 0x16C

        // Methods
        private System.Int32 get_ParticleCount() { }
        private System.Int32 get_SimulationStepCount() { }
        private System.Void set_SimulationStepCount(System.Int32 value) { }
        private System.Int32 get_WorkerCount() { }
        private System.Void Dispose() { }
        private System.Void EnterdEditMode() { }
        private System.Void Initialize() { }
        private System.Boolean IsValid() { }
        private System.Void RegisterProxyMesh(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void RegisterConstraint(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void ExitProxyMesh(BeyondDynamicBone.ClothProcess cprocess) { }
        private System.Void WorkBufferUpdate() { }
        private Unity.Jobs.JobHandle PreSimulationUpdate(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle SimulationStepUpdate(System.Int32 updateCount, System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle CalcDisplayPosition(Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle FeedbackTempFloat3Buffer(Unity.Collections.NativeList<System.Int32>& particleList, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle FeedbackTempFloat3Buffer(BeyondDynamicBone.ExProcessingList<System.Int32>& processingList, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle FeedbackTempFloat3Buffer(Unity.Collections.NativeArray<System.Int32>& particleArray, Unity.Collections.NativeReference<System.Int32>& counter, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private System.Void .ctor() { }
        private System.Void Initialize$StartSimulationStepJobKernels_StartSimulationStepKernel_00000405$BurstDirectCall() { }
        private System.Void Initialize$StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000406$BurstDirectCall() { }
        private System.Void Initialize$StartSimulationStepJobKernels_Spring_00000407$BurstDirectCall() { }
        private System.Void Initialize$StartSimulationStepJobKernels_Wind_00000408$BurstDirectCall() { }
        private System.Void Initialize$StartSimulationStepJobKernels_WindForceBlend_00000409$BurstDirectCall() { }
        private System.Void Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_0000040A$BurstDirectCall() { }
        private System.Void Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_0000040B$BurstDirectCall() { }
        private System.Void Initialize$EndSimulationStepJobKernels_EndSimulationStepKernel_0000040C$BurstDirectCall() { }
        private System.Void Initialize$EndSimulationStepJobKernels_EndSimulationStepRangeKernel_0000040D$BurstDirectCall() { }
        private System.Void Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_0000040E$BurstDirectCall() { }
        private System.Void Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_0000040F$BurstDirectCall() { }
        private System.Void Initialize$ClearStepCounterKernels_ClearStepCounterKernel_00000410$BurstDirectCall() { }

    }

    // TypeToken: 0x20001B5
    public class TimeManager, IManager, IDisposable, IValid
    {
        // Fields
        private System.Int32 simulationFrequency;        // 0x10
        private System.Int32 maxSimulationCountPerFrame;        // 0x14
        private BeyondDynamicBone.TimeManager.UpdateLocation updateLocation;        // 0x18
        private System.Boolean isValid;        // 0x1C
        private System.Int32 <FixedUpdateCount>k__BackingField;        // 0x20
        private System.Single GlobalTimeScale;        // 0x24
        private System.Single <SimulationDeltaTime>k__BackingField;        // 0x28
        private System.Single <MaxDeltaTime>k__BackingField;        // 0x2C
        private Unity.Mathematics.float4 <SimulationPower>k__BackingField;        // 0x30
        private static System.Single <DeltaTime>k__BackingField;        // 0x0
        private static System.Single <FixedDeltaTime>k__BackingField;        // 0x4
        private static System.Single <UnscaledDeltaTime>k__BackingField;        // 0x8
        private static System.Boolean <EnableAOVMode>k__BackingField;        // 0xC

        // Methods
        private System.Int32 get_FixedUpdateCount() { }
        private System.Void set_FixedUpdateCount(System.Int32 value) { }
        private System.Single get_SimulationDeltaTime() { }
        private System.Void set_SimulationDeltaTime(System.Single value) { }
        private System.Single get_MaxDeltaTime() { }
        private System.Void set_MaxDeltaTime(System.Single value) { }
        private Unity.Mathematics.float4 get_SimulationPower() { }
        private System.Void set_SimulationPower(Unity.Mathematics.float4 value) { }
        private System.Single get_DeltaTime() { }
        private System.Void set_DeltaTime(System.Single value) { }
        private System.Single get_FixedDeltaTime() { }
        private System.Void set_FixedDeltaTime(System.Single value) { }
        private System.Single get_UnscaledDeltaTime() { }
        private System.Void set_UnscaledDeltaTime(System.Single value) { }
        private System.Boolean get_EnableAOVMode() { }
        private System.Void set_EnableAOVMode(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void EnterdEditMode() { }
        private System.Void Initialize() { }
        private System.Boolean IsValid() { }
        private System.Void AfterFixedUpdate() { }
        private System.Void AfterRenderring() { }
        private System.Single GetDeltaTime() { }
        private System.Single GetFixedDeltaTime() { }
        private System.Single GetUnscaledDeltaTime() { }
        private System.Void FrameUpdate() { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B7
    public class WindManager, IManager, IDisposable, IValid
    {
        // Fields
        public static System.Int32 Flag_Valid;        // 0x0
        public static System.Int32 Flag_Enable;        // 0x0
        public static System.Int32 Flag_Addition;        // 0x0
        public BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.WindManager.WindData> windDataArray;        // 0x10
        private System.Boolean isValid;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,BeyondDynamicBone.BeyondBoneWindZone> windZoneDict;        // 0x20

        // Methods
        private System.Int32 get_WindCount() { }
        private System.Void Dispose() { }
        private System.Void EnterdEditMode() { }
        private System.Void Initialize() { }
        private System.Boolean IsValid() { }
        private System.Int32 AddWind(BeyondDynamicBone.BeyondBoneWindZone windZone) { }
        private System.Void RemoveWind(System.Int32 windId) { }
        private System.Void SetEnable(System.Int32 windId, System.Boolean sw) { }
        private System.Void AlwaysWindUpdate() { }
        private System.Void InformationLog(System.Text.StringBuilder allsb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B9
    public struct TeamWindInfo, IValid
    {
        // Fields
        public System.Int32 windId;        // 0x10
        public System.Single time;        // 0x14
        public System.Single main;        // 0x18
        public Unity.Mathematics.float3 direction;        // 0x1C

        // Methods
        private System.Boolean IsValid() { }
        private System.String ToString() { }
        private System.Void DebugLog() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x20001BA
    public struct TeamWindData
    {
        // Fields
        public Unity.Collections.FixedList128Bytes<BeyondDynamicBone.TeamWindInfo> windZoneList;        // 0x10
        public BeyondDynamicBone.TeamWindInfo movingWind;        // 0x90

        // Methods
        private System.Int32 get_ZoneCount() { }
        private System.Int32 IndexOf(System.Int32 windId) { }
        private System.Void ClearZoneList() { }
        private System.Void AddOrReplaceWindZone(BeyondDynamicBone.TeamWindInfo windInfo, BeyondDynamicBone.TeamWindData& oldWindData) { }
        private System.Void RemoveWindZone(System.Int32 windId) { }

    }

    // TypeToken: 0x20001BB
    public class TransformData, IDisposable
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Transform> transformList;        // 0x10
        private BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.ExBitFlag8> flagArray;        // 0x18
        private BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> initLocalPositionArray;        // 0x20
        private BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.quaternion> initLocalRotationArray;        // 0x28
        private BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> positionArray;        // 0x30
        private BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.quaternion> rotationArray;        // 0x38
        private BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.quaternion> inverseRotationArray;        // 0x40
        private BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> scaleArray;        // 0x48
        private BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> localPositionArray;        // 0x50
        private BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.quaternion> localRotationArray;        // 0x58
        private BeyondDynamicBone.ExSimpleNativeArray<System.Int32> idArray;        // 0x60
        private BeyondDynamicBone.ExSimpleNativeArray<System.Int32> parentIdArray;        // 0x68
        private System.Collections.Generic.List<System.Int32> rootIdList;        // 0x70
        private System.Boolean isDirty;        // 0x78
        private UnityEngine.Jobs.TransformAccessArray transformAccessArray;        // 0x80
        private System.Collections.Generic.Queue<System.Int32> emptyStack;        // 0x88

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Init(System.Int32 capacity) { }
        private System.Void Dispose() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_RootCount() { }
        private System.Boolean get_IsDirty() { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 AddTransform(UnityEngine.Transform t, System.Int32 tid, System.Int32 pid, System.Byte flag, System.Boolean checkDuplicate) { }
        private System.Int32 AddTransform(BeyondDynamicBone.TransformRecord record, System.Int32 pid, System.Byte flag, System.Boolean checkDuplicate) { }
        private System.Int32 AddTransform(BeyondDynamicBone.TransformData srcData, System.Int32 srcIndex, System.Boolean checkDuplicate) { }
        private System.Int32[] AddTransformRange(System.Collections.Generic.List<UnityEngine.Transform> tlist, System.Collections.Generic.List<System.Int32> idList, System.Collections.Generic.List<System.Int32> pidList, System.Int32 copyCount) { }
        private System.Int32[] AddTransformRange(BeyondDynamicBone.TransformData stdata, System.Int32 copyCount) { }
        private System.Int32[] AddTransformRange(System.Collections.Generic.List<UnityEngine.Transform> tlist, System.Collections.Generic.List<System.Int32> idList, System.Collections.Generic.List<System.Int32> pidList, System.Collections.Generic.List<System.Int32> rootIds, Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotations, Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations, Unity.Collections.NativeArray<Unity.Mathematics.float3> scales, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> inverseRotations) { }
        private System.Void RemoveTransformIndex(System.Int32 index) { }
        private System.Int32 ReplaceTransform(System.Int32 index, UnityEngine.Transform t, System.Int32 tid, System.Int32 pid, System.Byte flag) { }
        private System.Int32 ReferenceIndexOf(System.Collections.Generic.List<T> list, T item) { }
        private System.Void UpdateWorkData() { }
        private Unity.Jobs.JobHandle RestoreTransform(System.Int32 count, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle ReadTransform(Unity.Jobs.JobHandle jobHandle) { }
        private System.Void ReadTransformRun() { }
        private System.Void OrganizeReductionTransform(BeyondDynamicBone.VirtualMesh vmesh, BeyondDynamicBone.ReductionWorkData workData) { }
        private UnityEngine.Transform GetTransformFromIndex(System.Int32 index) { }
        private System.Int32 GetTransformIndexFormId(System.Int32 id) { }
        private System.Int32 GetTransformIdFromIndex(System.Int32 index) { }
        private System.Int32 GetParentIdFromIndex(System.Int32 index) { }
        private Unity.Mathematics.float4x4 GetLocalToWorldMatrix(System.Int32 index) { }
        private Unity.Mathematics.float4x4 GetWorldToLocalMatrix(System.Int32 index) { }
        private System.String ToString() { }
        private BeyondDynamicBone.TransformData.ShareSerializationData ShareSerialize() { }
        private BeyondDynamicBone.TransformData ShareDeserialize(BeyondDynamicBone.TransformData.ShareSerializationData sdata) { }
        private BeyondDynamicBone.TransformData.UniqueSerializationData UniqueSerialize() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x20001C0
    public class TransformRecord, IValid, ITransform
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public System.Int32 id;        // 0x18
        public UnityEngine.Vector3 localPosition;        // 0x1C
        public UnityEngine.Quaternion localRotation;        // 0x28
        public UnityEngine.Vector3 position;        // 0x38
        public UnityEngine.Quaternion rotation;        // 0x44
        public UnityEngine.Vector3 scale;        // 0x54
        public UnityEngine.Matrix4x4 localToWorldMatrix;        // 0x60
        public UnityEngine.Matrix4x4 worldToLocalMatrix;        // 0xA0
        public System.Int32 pid;        // 0xE0

        // Methods
        private System.Void .ctor(UnityEngine.Transform t) { }
        private UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 dir) { }
        private System.Boolean IsValid() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }

    }

    // TypeToken: 0x20001C1
    public class PreBuildScriptableObject : ScriptableObject
    {
        // Fields
        public System.Collections.Generic.List<BeyondDynamicBone.SharePreBuildData> sharePreBuildDataList;        // 0x18

        // Methods
        private System.Boolean HasPreBuildData(System.String buildId) { }
        private BeyondDynamicBone.SharePreBuildData GetPreBuildData(System.String buildId) { }
        private System.Void AddPreBuildData(BeyondDynamicBone.SharePreBuildData sdata) { }
        private System.Void Warmup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C4
    public class PreBuildSerializeData, ITransform
    {
        // Fields
        public System.Boolean enabled;        // 0x10
        public BeyondDynamicBone.SharePreBuildData preBuildData;        // 0x18
        public BeyondDynamicBone.UniquePreBuildData uniquePreBuildData;        // 0x20

        // Methods
        private System.Boolean UsePreBuild() { }
        private BeyondDynamicBone.ResultCode DataValidate() { }
        private BeyondDynamicBone.SharePreBuildData GetSharePreBuildData() { }
        private System.String GenerateBuildID() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C5
    public class SharePreBuildData
    {
        // Fields
        public System.Int32 version;        // 0x10
        public System.String buildId;        // 0x18
        public BeyondDynamicBone.ResultCode buildResult;        // 0x20
        public UnityEngine.Vector3 buildScale;        // 0x28
        public System.Collections.Generic.List<BeyondDynamicBone.RenderSetupData.ShareSerializationData> renderSetupDataList;        // 0x38
        public BeyondDynamicBone.VirtualMesh.ShareSerializationData proxyMesh;        // 0x40
        public System.Collections.Generic.List<BeyondDynamicBone.VirtualMesh.ShareSerializationData> renderMeshList;        // 0x48
        public BeyondDynamicBone.DistanceConstraint.ConstraintData distanceConstraintData;        // 0x50
        public BeyondDynamicBone.TriangleBendingConstraint.ConstraintData bendingConstraintData;        // 0x58
        public BeyondDynamicBone.InertiaConstraint.ConstraintData inertiaConstraintData;        // 0x60

        // Methods
        private BeyondDynamicBone.ResultCode DataValidate() { }
        private System.Boolean CheckBuildId(System.String buildId) { }
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x20001C6
    public class UniquePreBuildData, ITransform
    {
        // Fields
        public System.Int32 version;        // 0x10
        public BeyondDynamicBone.ResultCode buildResult;        // 0x14
        public System.Collections.Generic.List<BeyondDynamicBone.RenderSetupData.UniqueSerializationData> renderSetupDataList;        // 0x20
        public BeyondDynamicBone.VirtualMesh.UniqueSerializationData proxyMesh;        // 0x28
        public System.Collections.Generic.List<BeyondDynamicBone.VirtualMesh.UniqueSerializationData> renderMeshList;        // 0x30

        // Methods
        private BeyondDynamicBone.ResultCode DataValidate() { }
        private System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet) { }
        private System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C9
    public class ReductionSettings, IDataValidate
    {
        // Fields
        public System.Single simpleDistance;        // 0x10
        public System.Single shapeDistance;        // 0x14

        // Methods
        private System.Boolean get_IsEnabled() { }
        private System.Single GetMaxConnectionDistance() { }
        private BeyondDynamicBone.ReductionSettings Clone() { }
        private System.Void DataValidate() { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x20001CA
    public class ReductionWorkData, IDisposable
    {
        // Fields
        public BeyondDynamicBone.VirtualMesh vmesh;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> vertexJoinIndices;        // 0x18
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> vertexToVertexMap;        // 0x28
        public Unity.Collections.NativeArray<System.Int32> vertexRemapIndices;        // 0x38
        public Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> useSkinBoneMap;        // 0x48
        public Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> newVertexToVertexMap;        // 0x58
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2> edgeSet;        // 0x68
        public Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int3> triangleSet;        // 0x78
        public System.Int32 oldVertexCount;        // 0x88
        public System.Int32 newVertexCount;        // 0x8C
        public System.Int32 removeVertexCount;        // 0x90
        public BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.VertexAttribute> newAttributes;        // 0x98
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> newLocalPositions;        // 0xA0
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> newLocalNormals;        // 0xA8
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> newLocalTangents;        // 0xB0
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float2> newUv;        // 0xB8
        public BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> newBoneWeights;        // 0xC0
        public Unity.Collections.NativeReference<System.Int32> newSkinBoneCount;        // 0xC8
        public Unity.Collections.NativeList<System.Int32> newSkinBoneTransformIndices;        // 0xD8
        public Unity.Collections.NativeList<Unity.Mathematics.float4x4> newSkinBoneBindPoseList;        // 0xE8
        public Unity.Collections.NativeList<Unity.Mathematics.int2> newLineList;        // 0xF8
        public Unity.Collections.NativeList<Unity.Mathematics.int3> newTriangleList;        // 0x108

        // Methods
        private System.Void .ctor(BeyondDynamicBone.VirtualMesh vmesh) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20001CB
    public class SameDistanceReduction, IDisposable
    {
        // Fields
        private System.String name;        // 0x10
        private BeyondDynamicBone.VirtualMesh vmesh;        // 0x18
        private BeyondDynamicBone.ReductionWorkData workData;        // 0x20
        private BeyondDynamicBone.ResultCode result;        // 0x28
        private System.Single mergeLength;        // 0x30
        private BeyondDynamicBone.GridMap<System.Int32> gridMap;        // 0x38
        private Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16> joinPairMap;        // 0x40
        private Unity.Collections.NativeReference<System.Int32> resultRef;        // 0x50

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name, BeyondDynamicBone.VirtualMesh mesh, BeyondDynamicBone.ReductionWorkData workingData, System.Single mergeLength) { }
        private System.Void Dispose() { }
        private BeyondDynamicBone.ResultCode get_Result() { }
        private BeyondDynamicBone.ResultCode Reduction() { }
        private System.Void UpdateJoinAndLink() { }
        private System.Void UpdateReductionResultJob() { }

    }

    // TypeToken: 0x20001D2
    public class ShapeDistanceReduction : StepReductionBase
    {
        // Methods
        private System.Void .ctor(System.String name, BeyondDynamicBone.VirtualMesh mesh, BeyondDynamicBone.ReductionWorkData workingData, System.Single startMergeLength, System.Single endMergeLength, System.Int32 maxStep, System.Boolean dontMakeLine, System.Single joinPositionAdjustment) { }
        private System.Void Dispose() { }
        private System.Void StepInitialize() { }
        private System.Void CustomReductionStep() { }
        private System.Void <>iFixBaseProxy_Dispose() { }
        private System.Void <>iFixBaseProxy_StepInitialize() { }
        private System.Void <>iFixBaseProxy_CustomReductionStep() { }

    }

    // TypeToken: 0x20001D4
    public class SimpleDistanceReduction : StepReductionBase
    {
        // Fields
        private BeyondDynamicBone.GridMap<System.Int32> gridMap;        // 0x90

        // Methods
        private System.Void .ctor(System.String name, BeyondDynamicBone.VirtualMesh mesh, BeyondDynamicBone.ReductionWorkData workingData, System.Single startMergeLength, System.Single endMergeLength, System.Int32 maxStep, System.Boolean dontMakeLine, System.Single joinPositionAdjustment) { }
        private System.Void Dispose() { }
        private System.Void StepInitialize() { }
        private System.Void CustomReductionStep() { }
        private System.Void <>iFixBaseProxy_Dispose() { }
        private System.Void <>iFixBaseProxy_StepInitialize() { }
        private System.Void <>iFixBaseProxy_CustomReductionStep() { }

    }

    // TypeToken: 0x20001D7
    public class StepReductionBase, IDisposable
    {
        // Fields
        protected System.String name;        // 0x10
        protected BeyondDynamicBone.VirtualMesh vmesh;        // 0x18
        protected BeyondDynamicBone.ReductionWorkData workData;        // 0x20
        protected BeyondDynamicBone.ResultCode result;        // 0x28
        protected System.Single startMergeLength;        // 0x30
        protected System.Single endMergeLength;        // 0x34
        protected System.Int32 maxStep;        // 0x38
        protected System.Boolean dontMakeLine;        // 0x3C
        protected System.Single joinPositionAdjustment;        // 0x40
        protected System.Int32 nowStepIndex;        // 0x44
        protected System.Single nowMergeLength;        // 0x48
        protected System.Single nowStepScale;        // 0x4C
        protected Unity.Collections.NativeList<BeyondDynamicBone.StepReductionBase.JoinEdge> joinEdgeList;        // 0x50
        private Unity.Collections.NativeParallelHashSet<System.Int32> completeVertexSet;        // 0x60
        private Unity.Collections.NativeList<Unity.Mathematics.int2> removePairList;        // 0x70
        private Unity.Collections.NativeArray<System.Int32> resultArray;        // 0x80

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name, BeyondDynamicBone.VirtualMesh mesh, BeyondDynamicBone.ReductionWorkData workingData, System.Single startMergeLength, System.Single endMergeLength, System.Int32 maxStep, System.Boolean dontMakeLine, System.Single joinPositionAdjustment) { }
        private System.Void Dispose() { }
        private BeyondDynamicBone.ResultCode get_Result() { }
        private BeyondDynamicBone.ResultCode Reduction() { }
        private System.Void InitStep() { }
        private System.Boolean IsEndStep() { }
        private System.Void NextStep() { }
        private System.Void ReductionStep() { }
        private System.Void StepInitialize() { }
        private System.Void CustomReductionStep() { }
        private System.Void PreReductionStep() { }
        private System.Void PostReductionStep() { }
        private System.Void SortJoinEdge() { }
        private System.Void DetermineJoinEdge() { }
        private System.Void RunJoinEdge() { }
        private System.Void UpdateJoinAndLink() { }
        private System.Void UpdateReductionResultJob() { }
        private System.Boolean CheckJoin2(Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>& vertexToVertexMap, System.Int32 vindex, System.Int32 tvindex, System.Boolean dontMakeLine) { }
        private System.Boolean CheckJoin(Unity.Collections.NativeArray<Unity.Collections.FixedList128Bytes<System.UInt16>>& vertexToVertexArray, System.Int32 vindex, System.Int32 tvindex, Unity.Collections.FixedList128Bytes<System.UInt16>& vlist, Unity.Collections.FixedList128Bytes<System.UInt16>& tvlist, System.Boolean dontMakeLine) { }

    }

    // TypeToken: 0x20001DE
    public class ClothDebugSettings
    {
        // Fields
        public System.Boolean enable;        // 0x10
        public System.Boolean ztest;        // 0x11
        public System.Boolean position;        // 0x12
        public BeyondDynamicBone.ClothDebugSettings.DebugAxis axis;        // 0x14
        public System.Boolean shape;        // 0x18
        public System.Boolean baseLine;        // 0x19
        public System.Boolean depth;        // 0x1A
        public System.Boolean collider;        // 0x1B
        public System.Boolean animatedPosition;        // 0x1C
        public BeyondDynamicBone.ClothDebugSettings.DebugAxis animatedAxis;        // 0x20
        public System.Boolean animatedShape;        // 0x24
        public System.Boolean inertiaCenter;        // 0x25
        public System.Boolean customSkinningBone;        // 0x26

        // Methods
        private System.Boolean CheckParticleDrawing(System.Int32 index) { }
        private System.Boolean CheckTriangleDrawing(System.Int32 index) { }
        private System.Boolean CheckRadiusDrawing() { }
        private System.Single GetPointSize() { }
        private System.Single GetLineSize() { }
        private System.Single GetInertiaCenterRadius() { }
        private System.Single GetCustomSkinningRadius() { }
        private System.Boolean IsReferOldPos() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E0
    public class DataUtility
    {
        // Methods
        private Unity.Mathematics.int2 PackInt2(System.Int32 d0, System.Int32 d1) { }
        private Unity.Mathematics.int2 PackInt2(Unity.Mathematics.int2& d) { }
        private Unity.Mathematics.int3 PackInt3(System.Int32 d0, System.Int32 d1, System.Int32 d2) { }
        private Unity.Mathematics.int3 PackInt3(Unity.Mathematics.int3& d) { }
        private Unity.Mathematics.int4 PackInt4(System.Int32 d0, System.Int32 d1, System.Int32 d2, System.Int32 d3) { }
        private Unity.Mathematics.int4 PackInt4(Unity.Mathematics.int4 d) { }
        private System.UInt32 Pack32(System.Int32 hi, System.Int32 low) { }
        private System.UInt32 Pack32Sort(System.Int32 a, System.Int32 b) { }
        private System.Int32 Unpack32Hi(System.UInt32 pack) { }
        private System.Int32 Unpack32Low(System.UInt32 pack) { }
        private System.UInt32 Pack12_20(System.Int32 hi, System.Int32 low) { }
        private System.Int32 Unpack12_20Hi(System.UInt32 pack) { }
        private System.Int32 Unpack12_20Low(System.UInt32 pack) { }
        private System.Void Unpack12_20(System.UInt32 pack, System.Int32& hi, System.Int32& low) { }
        private System.UInt64 Pack64(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w) { }
        private System.UInt64 Pack64(Unity.Mathematics.int4& a) { }
        private Unity.Mathematics.int4 Unpack64(System.UInt64& pack) { }
        private System.Int32 Unpack64X(System.UInt64& pack) { }
        private System.Int32 Unpack64Y(System.UInt64& pack) { }
        private System.Int32 Unpack64Z(System.UInt64& pack) { }
        private System.Int32 Unpack64W(System.UInt64& pack) { }
        private System.UInt32 Pack32(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w) { }
        private System.UInt64 Pack32(Unity.Mathematics.int4& a) { }
        private Unity.Mathematics.int4 Unpack32(System.UInt32& pack) { }
        private System.Int32 RemainingData(Unity.Mathematics.int3& data, Unity.Mathematics.int2& use) { }
        private Unity.Mathematics.float4x4 ConvertAnimationCurve(UnityEngine.AnimationCurve curve) { }
        private System.Single EvaluateCurve(Unity.Mathematics.float4x4& curve, System.Single time) { }
        private BeyondDynamicBone.ColliderManager.ColliderType GetColliderType(BeyondDynamicBone.ExBitFlag8& flag) { }
        private BeyondDynamicBone.ExBitFlag8 SetColliderType(BeyondDynamicBone.ExBitFlag8 flag, BeyondDynamicBone.ColliderManager.ColliderType ctype) { }
        private System.Void ArrayCopy(T[] src, T[]& dst) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E1
    public class MultiDataBuilder`1, IDisposable
    {
        // Fields
        private System.Int32 indexCount;        // 0x0
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,T> Map;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 indexCount, System.Int32 dataCapacity) { }
        private System.Void Dispose() { }
        private System.Int32 Count() { }
        private System.Int32 GetDataCount(System.Int32 index) { }
        private System.Void Add(System.Int32 key, T data) { }
        private System.Int32 CountValuesForKey(System.Int32 key) { }
        private System.ValueTuple<T[],System.UInt32[]> ToArray() { }
        private System.UInt32[] ToIndexArray() { }
        private System.Void ToNativeArray(Unity.Collections.NativeArray<System.UInt32>& indexArray, Unity.Collections.NativeArray<T>& dataArray) { }

    }

    // TypeToken: 0x20001E2
    public class GridMap`1, IDisposable
    {
        // Fields
        private Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Dispose() { }
        private Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> GetMultiHashMap() { }
        private System.Int32 get_DataCount() { }
        private BeyondDynamicBone.GridMap.GridEnumerator<T> GetArea(Unity.Mathematics.int3 startGrid, Unity.Mathematics.int3 endGrid, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap) { }
        private BeyondDynamicBone.GridMap.GridEnumerator<T> GetArea(Unity.Mathematics.float3 pos, System.Single radius, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap, System.Single gridSize) { }
        private Unity.Mathematics.int3 GetGrid(Unity.Mathematics.float3 pos, System.Single gridSize) { }
        private System.Void AddGrid(Unity.Mathematics.int3 grid, T data, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap) { }
        private Unity.Mathematics.int3 AddGrid(Unity.Mathematics.float3 pos, T data, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap, System.Single gridSize) { }
        private Unity.Mathematics.int3 AddGrid(Unity.Mathematics.float3 pos, T data, Unity.Collections.NativeParallelMultiHashMap.ParallelWriter<Unity.Mathematics.int3,T> gridMap, System.Single gridSize) { }
        private System.Boolean RemoveGrid(Unity.Mathematics.int3 grid, T data, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap) { }
        private System.Boolean MoveGrid(Unity.Mathematics.int3 fromGrid, Unity.Mathematics.int3 toGrid, T data, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap) { }

    }

    // TypeToken: 0x20001E4
    public class ClothJobUtility
    {
        // Methods
        private Unity.Jobs.JobHandle Fill(Unity.Collections.NativeArray<System.Byte> array, System.Int32 length, System.Byte value, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void FillRun(Unity.Collections.NativeArray<System.Int32> array, System.Int32 length, System.Int32 value) { }
        private System.Void FillRun(Unity.Collections.NativeArray<Unity.Mathematics.quaternion> array, System.Int32 length, Unity.Mathematics.quaternion value) { }
        private System.Void FillRun(Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> array, System.Int32 length, BeyondDynamicBone.VirtualMeshBoneWeight value) { }
        private Unity.Jobs.JobHandle Fill(Unity.Collections.NativeArray<System.Int32> array, System.Int32 startIndex, System.Int32 length, System.Int32 value, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle Fill(Unity.Collections.NativeReference<System.Int32> reference, System.Int32 value, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle SerialNumber(Unity.Collections.NativeArray<System.Int32> array, System.Int32 length, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void SerialNumberRun(Unity.Collections.NativeArray<System.Int32> array, System.Int32 length) { }
        private Unity.Jobs.JobHandle ConvertHashSetToNativeList(Unity.Collections.NativeParallelHashSet<System.Int32> hashSet, Unity.Collections.NativeList<System.Int32> list, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ConvertHashSetKeyToNativeList(Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2> hashSet, Unity.Collections.NativeList<Unity.Mathematics.int2> keyList, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ConvertHashSetKeyToNativeList(Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int4> hashSet, Unity.Collections.NativeList<Unity.Mathematics.int4> keyList, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle CalcAABB(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void CalcAABBRun(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB) { }
        private Unity.Jobs.JobHandle CalcAABB(Unity.Collections.NativeList<Unity.Mathematics.float3> positions, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void CalcAABBRun(Unity.Collections.NativeList<Unity.Mathematics.float3> positions, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB) { }
        private BeyondDynamicBone.AABB CalcAABBInternal(Unity.Collections.NativeArray<Unity.Mathematics.float3>& positions, System.Int32 length) { }
        private Unity.Jobs.JobHandle CalcUVWithSphereMapping(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> aabb, Unity.Collections.NativeArray<Unity.Mathematics.float2> outUVs, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void CalcUVWithSphereMappingRun(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> aabb, Unity.Collections.NativeArray<Unity.Mathematics.float2> outUVs) { }
        private Unity.Jobs.JobHandle TransformPosition(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Mathematics.float4x4& toM, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void TransformPositionRun(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Mathematics.float4x4& toM) { }
        private Unity.Jobs.JobHandle TransformPosition(Unity.Collections.NativeArray<Unity.Mathematics.float3> srcPositions, Unity.Collections.NativeArray<Unity.Mathematics.float3> dstPositions, System.Int32 length, Unity.Mathematics.float4x4& toM, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void TransformPositionRun(Unity.Collections.NativeArray<Unity.Mathematics.float3> srcPositions, Unity.Collections.NativeArray<Unity.Mathematics.float3> dstPositions, System.Int32 length, Unity.Mathematics.float4x4& toM) { }
        private Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> ToNativeMultiHashMap(Unity.Collections.NativeArray<System.UInt32>& indexArray, Unity.Collections.NativeArray<System.UInt16>& dataArray) { }
        private Unity.Jobs.JobHandle ClearReference(Unity.Collections.NativeReference<System.Int32> reference, Unity.Jobs.JobHandle jobHandle) { }

    }

    // TypeToken: 0x20001F5
    public class InterlockUtility
    {
        // Fields
        private static System.Int32 ToFixed;        // 0x0
        private static System.Single ToFloat;        // 0x0

        // Methods
        private System.Void AddFloat3(System.Int32 index, Unity.Mathematics.float3 add, System.Int32* cntPt, System.Int32* sumPt) { }
        private System.Void AddFloat3(System.Int32 index, Unity.Mathematics.float3 add, System.Int32* sumPt) { }
        private System.Void Increment(System.Int32 index, System.Int32* cntPt) { }
        private System.Void Max(System.Int32 index, System.Single value, System.Int32* pt) { }
        private Unity.Mathematics.float3 ReadAverageFloat3(System.Int32 index, Unity.Collections.NativeArray<System.Int32>& countArray, Unity.Collections.NativeArray<System.Int32>& sumArray) { }
        private Unity.Mathematics.float3 ReadAverageFloat3(System.Int32 index, System.Int32* countArray, System.Int32* sumArray) { }
        private Unity.Mathematics.float3 ReadFloat3(System.Int32 index, Unity.Collections.NativeArray<System.Int32>& bufferArray) { }
        private Unity.Mathematics.float3 ReadFloat3(System.Int32 index, System.Int32* bufferArray) { }
        private System.Single ReadFloat(System.Int32 index, Unity.Collections.NativeArray<System.Int32>& bufferArray) { }
        private System.Single ReadFloat(System.Int32 index, System.Int32* bufferArray) { }
        private Unity.Jobs.JobHandle SolveAggregateBufferAndClear(Unity.Collections.NativeList<System.Int32>& particleList, System.Single velocityAttenuation, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle SolveAggregateBufferAndClear(BeyondDynamicBone.ExProcessingList<System.Int32>& processingList, System.Single velocityAttenuation, Unity.Jobs.JobHandle jobHandle) { }
        private Unity.Jobs.JobHandle SolveAggregateBufferAndClear(Unity.Collections.NativeArray<System.Int32>& particleArray, Unity.Collections.NativeReference<System.Int32>& counter, System.Single velocityAttenuation, Unity.Jobs.JobHandle jobHandle) { }
        private System.Void Initialize$AggregateJobKernels_AggregateKernel_00000564$BurstDirectCall() { }
        private System.Void Initialize$AggregateJobKernels_AggregateRangeKernel_00000565$BurstDirectCall() { }
        private System.Void Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_00000566$BurstDirectCall() { }
        private System.Void Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_00000567$BurstDirectCall() { }
        private System.Void Initialize$AggregateJob2Kernels_AggregateJob2Kernel_00000568$BurstDirectCall() { }
        private System.Void Initialize$AggregateJob2Kernels_AggregateJob2RangeKernel_00000569$BurstDirectCall() { }
        private System.Void Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_0000056A$BurstDirectCall() { }
        private System.Void Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_0000056B$BurstDirectCall() { }

    }

    // TypeToken: 0x2000210
    public struct AABB, IEquatable`1
    {
        // Fields
        public Unity.Mathematics.float3 Min;        // 0x10
        public Unity.Mathematics.float3 Max;        // 0x1C

        // Methods
        private System.Void .ctor(Unity.Mathematics.float3& min, Unity.Mathematics.float3& max) { }
        private BeyondDynamicBone.AABB CreateFromCenterAndExtents(Unity.Mathematics.float3 center, Unity.Mathematics.float3 extents) { }
        private BeyondDynamicBone.AABB CreateFromCenterAndHalfExtents(Unity.Mathematics.float3 center, Unity.Mathematics.float3 halfExtents) { }
        private Unity.Mathematics.float3 get_Extents() { }
        private Unity.Mathematics.float3 get_HalfExtents() { }
        private Unity.Mathematics.float3 get_Center() { }
        private System.Single get_MaxSideLength() { }
        private System.Boolean get_IsValid() { }
        private System.Single get_SurfaceArea() { }
        private System.Boolean Contains(Unity.Mathematics.float3& point) { }
        private System.Boolean Contains(BeyondDynamicBone.AABB& aabb) { }
        private System.Boolean Overlaps(BeyondDynamicBone.AABB& aabb) { }
        private System.Void Expand(System.Single signedDistance) { }
        private System.Void Encapsulate(BeyondDynamicBone.AABB& aabb) { }
        private System.Void Encapsulate(Unity.Mathematics.float3& point) { }
        private System.Boolean Equals(BeyondDynamicBone.AABB other) { }
        private System.Void Transform(Unity.Mathematics.float4x4& toM) { }
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000211
    public struct IntAABB, IEquatable`1
    {
        // Fields
        public Unity.Mathematics.int3 Min;        // 0x10
        public Unity.Mathematics.int3 Max;        // 0x1C

        // Methods
        private System.Void .ctor(Unity.Mathematics.int3 min, Unity.Mathematics.int3 max) { }
        private Unity.Mathematics.int3 get_Extents() { }
        private Unity.Mathematics.int3 get_Center() { }
        private System.Boolean get_IsValid() { }
        private System.Boolean Contains(Unity.Mathematics.int3 point) { }
        private System.Boolean Contains(BeyondDynamicBone.IntAABB aabb) { }
        private System.Boolean Overlaps(BeyondDynamicBone.IntAABB aabb) { }
        private System.Void Expand(System.Int32 signedDistance) { }
        private System.Void Encapsulate(BeyondDynamicBone.IntAABB aabb) { }
        private System.Void Encapsulate(Unity.Mathematics.int3 point) { }
        private System.Boolean Equals(BeyondDynamicBone.IntAABB other) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000212
    public class MathExtensions
    {
        // Methods
        private System.Single MC2GetValue(Unity.Mathematics.float4x4& m, System.Int32 index) { }
        private System.Void MC2SetValue(Unity.Mathematics.float4x4& m, System.Int32 index, System.Single value) { }
        private System.Single MC2EvaluateCurveClamp01(Unity.Mathematics.float4x4& m, System.Single time) { }
        private System.Single MC2EvaluateCurve(Unity.Mathematics.float4x4& m, System.Single time) { }

    }

    // TypeToken: 0x2000213
    public class MathUtility
    {
        // Methods
        private System.Void ComputeVirtualParentWithoutLocal(Unity.Mathematics.float3 fromPos, Unity.Mathematics.quaternion fromRot, Unity.Mathematics.float3 toPos, Unity.Mathematics.quaternion toRot, Unity.Mathematics.float3& dPos, Unity.Mathematics.quaternion& dRot) { }
        private System.Single Clamp1(System.Single a) { }
        private Unity.Mathematics.float3 Project(Unity.Mathematics.float3& v, Unity.Mathematics.float3& n) { }
        private Unity.Mathematics.float3 ProjectOnPlane(Unity.Mathematics.float3& v, Unity.Mathematics.float3& n) { }
        private System.Single Angle(Unity.Mathematics.float3& v1, Unity.Mathematics.float3& v2) { }
        private Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single minlength, System.Single maxlength) { }
        private Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single maxlength) { }
        private Unity.Mathematics.float3 ClampDistance(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to, System.Single maxlength) { }
        private System.Boolean ClampAngle(Unity.Mathematics.float3& dir, Unity.Mathematics.float3& basedir, System.Single maxAngle, Unity.Mathematics.float3& outdir) { }
        private Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.float3& from, Unity.Mathematics.float3& to, System.Single t) { }
        private Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.quaternion& from, Unity.Mathematics.quaternion& to) { }
        private System.Single Angle(Unity.Mathematics.quaternion& a, Unity.Mathematics.quaternion& b) { }
        private Unity.Mathematics.quaternion ClampAngle(Unity.Mathematics.quaternion from, Unity.Mathematics.quaternion to, System.Single maxAngle) { }
        private Unity.Mathematics.quaternion ToRotation(Unity.Mathematics.float3& nor, Unity.Mathematics.float3& tan) { }
        private System.Void ToNormalTangent(Unity.Mathematics.quaternion& rot, Unity.Mathematics.float3& nor, Unity.Mathematics.float3& tan) { }
        private Unity.Mathematics.float3 ToNormal(Unity.Mathematics.quaternion& rot) { }
        private Unity.Mathematics.float3 ToTangent(Unity.Mathematics.quaternion& rot) { }
        private Unity.Mathematics.float3 ToBinormal(Unity.Mathematics.quaternion& rot) { }
        private Unity.Mathematics.float3 Binormal(Unity.Mathematics.float3& nor, Unity.Mathematics.float3& tan) { }
        private Unity.Mathematics.float3 AxisToEuler(Unity.Mathematics.float3& axis) { }
        private Unity.Mathematics.quaternion AxisQuaternion(Unity.Mathematics.float3 dir) { }
        private System.Void ToAngleAxis(Unity.Mathematics.quaternion& q, System.Single& angle, Unity.Mathematics.float3& axis) { }
        private System.Single ClosestPtPointSegmentRatio(Unity.Mathematics.float3& c, Unity.Mathematics.float3& a, Unity.Mathematics.float3& b) { }
        private System.Single ClosestPtPointSegmentRatioNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        private Unity.Mathematics.float3 ClosestPtPointSegment(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        private Unity.Mathematics.float3 ClosestPtPointSegmentNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        private System.Single ClosestPtSegmentSegment(Unity.Mathematics.float3& p1, Unity.Mathematics.float3& q1, Unity.Mathematics.float3& p2, Unity.Mathematics.float3& q2, System.Single& s, System.Single& t, Unity.Mathematics.float3& c1, Unity.Mathematics.float3& c2) { }
        private System.Void ClosestPtSegmentSegment2(Unity.Mathematics.float3& p1, Unity.Mathematics.float3& q1, Unity.Mathematics.float3& p2, Unity.Mathematics.float3& q2, System.Single& s, System.Single& t) { }
        private Unity.Mathematics.float3 ClosestPtPointTriangle(Unity.Mathematics.float3& p, Unity.Mathematics.float3& a, Unity.Mathematics.float3& b, Unity.Mathematics.float3& c, Unity.Mathematics.float3& uvw) { }
        private System.Boolean PointInTriangleUVW(Unity.Mathematics.float3 uvw) { }
        private Unity.Mathematics.float3 TriangleCenter(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2) { }
        private Unity.Mathematics.float3 TriangleNormal(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2) { }
        private System.Single TriangleArea(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2) { }
        private System.Boolean IsSafeTriangle(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2) { }
        private Unity.Mathematics.float3 TriangleTangent(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2, Unity.Mathematics.float2& uv0, Unity.Mathematics.float2& uv1, Unity.Mathematics.float2& uv2) { }
        private System.Single TriangleAngle(Unity.Mathematics.float3& v0, Unity.Mathematics.float3& v1, Unity.Mathematics.float3& v2, Unity.Mathematics.float3& v3) { }
        private System.Single DistanceTriangleCenter(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        private System.Single DirectionPointTriangle(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c) { }
        private Unity.Mathematics.int2 GetRestTriangleVertex(Unity.Mathematics.int3 tri1, Unity.Mathematics.int3 tri2, Unity.Mathematics.int2 edge) { }
        private Unity.Mathematics.int2 GetCommonEdgeFromTrianglePair(Unity.Mathematics.int3 tri1, Unity.Mathematics.int3 tri2) { }
        private Unity.Mathematics.int4 GetTrianglePairIndices(Unity.Mathematics.int3 tri1, Unity.Mathematics.int3 tri2) { }
        private System.Int32 GetUnuseTriangleIndex(Unity.Mathematics.int3 tri, Unity.Mathematics.int2 edge) { }
        private System.Single GetTrianglePairAngle(Unity.Mathematics.float3 pos0, Unity.Mathematics.float3 pos1, Unity.Mathematics.float3 pos2, Unity.Mathematics.float3 pos3) { }
        private Unity.Mathematics.int3 FlipTriangle(Unity.Mathematics.int3& tri) { }
        private System.Void GetTriangleSphere(Unity.Mathematics.float3 pos0, Unity.Mathematics.float3 pos1, Unity.Mathematics.float3 pos2, Unity.Mathematics.float3& sc, System.Single& sr) { }
        private Unity.Mathematics.float4x4 LocalToWorldMatrix(Unity.Mathematics.float3& wpos, Unity.Mathematics.quaternion& wrot, Unity.Mathematics.float3& wscl) { }
        private Unity.Mathematics.float4x4 WorldToLocalMatrix(Unity.Mathematics.float3& wpos, Unity.Mathematics.quaternion& wrot, Unity.Mathematics.float3& wscl) { }
        private Unity.Mathematics.float3 TransformPoint(Unity.Mathematics.float3& pos, Unity.Mathematics.float3& wpos, Unity.Mathematics.quaternion& wrot, Unity.Mathematics.float3& wscl) { }
        private Unity.Mathematics.float3 TransformPoint(Unity.Mathematics.float3& pos, Unity.Mathematics.float4x4& m) { }
        private Unity.Mathematics.float3 TransformVector(Unity.Mathematics.float3& vec, Unity.Mathematics.float4x4& m) { }
        private Unity.Mathematics.float3 TransformDirection(Unity.Mathematics.float3& dir, Unity.Mathematics.float4x4& m) { }
        private Unity.Mathematics.quaternion TransformRotation(Unity.Mathematics.quaternion& rot, Unity.Mathematics.float4x4& m, Unity.Mathematics.float3& normalTangentFlip) { }
        private System.Single TransformDistance(System.Single& dist, Unity.Mathematics.float4x4& localToWorldMatrix) { }
        private System.Void TransformPositionNormalTangent(Unity.Mathematics.float3& tpos, Unity.Mathematics.quaternion& trot, Unity.Mathematics.float3& tscl, Unity.Mathematics.float3& pos, Unity.Mathematics.float3& nor, Unity.Mathematics.float3& tan) { }
        private System.Single TransformLength(System.Single length, Unity.Mathematics.float4x4& matrix) { }
        private Unity.Mathematics.float3 InverseTransformPoint(Unity.Mathematics.float3& pos, Unity.Mathematics.float4x4& worldToLocalMatrix) { }
        private Unity.Mathematics.float3 InverseTransformPoint(Unity.Mathematics.float3& pos, Unity.Mathematics.float3& wpos, Unity.Mathematics.quaternion& wrot, Unity.Mathematics.float3& wscl) { }
        private Unity.Mathematics.float3 InverseTransformVector(Unity.Mathematics.float3& vec, Unity.Mathematics.float4x4& worldToLocalMatrix) { }
        private Unity.Mathematics.float3 InverseTransformVector(Unity.Mathematics.float3& vec, Unity.Mathematics.quaternion& rot) { }
        private Unity.Mathematics.float3 InverseTransformDirection(Unity.Mathematics.float3& dir, Unity.Mathematics.float4x4& worldToLocalMatrix) { }
        private Unity.Mathematics.float4x4 Transform(Unity.Mathematics.float4x4& fromLocalToWorldMatrix, Unity.Mathematics.float4x4& toWorldToLocalMatrix) { }
        private System.Boolean CompareMatrix(Unity.Mathematics.float4x4& m1, Unity.Mathematics.float4x4& m2) { }
        private System.Boolean CompareTransform(Unity.Mathematics.float3& pos1, Unity.Mathematics.quaternion& rot1, Unity.Mathematics.float3& scl1, Unity.Mathematics.float3& pos2, Unity.Mathematics.quaternion& rot2, Unity.Mathematics.float3& scl2) { }
        private System.Boolean IntersectSegmentTriangle(Unity.Mathematics.float3& p, Unity.Mathematics.float3& q, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c, System.Boolean doubleSide, System.Single& u, System.Single& v, System.Single& w, System.Single& t) { }
        private System.Boolean IntersectSegmentTriangle(Unity.Mathematics.float3& p, Unity.Mathematics.float3& q, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c) { }
        private System.Single IntersectPointPlaneDist(Unity.Mathematics.float3& planePos, Unity.Mathematics.float3& planeDir, Unity.Mathematics.float3& pos, Unity.Mathematics.float3& outPos) { }
        private System.Boolean IntersectRaySphere(Unity.Mathematics.float3& p, Unity.Mathematics.float3& d, Unity.Mathematics.float3& sc, System.Single& sr, System.Single& t, Unity.Mathematics.float3& q) { }
        private System.Single SqDistPointSegment(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        private System.Boolean IsNaN(Unity.Mathematics.float3 v) { }
        private System.Boolean IsNaN(Unity.Mathematics.float4 v) { }
        private System.Boolean IsNaN(Unity.Mathematics.quaternion q) { }
        private Unity.Mathematics.float3 Lerp(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y, System.Single s) { }
        private Unity.Mathematics.float3 ShiftPosition(Unity.Mathematics.float3& oldPos, Unity.Mathematics.float3& oldPivotPosition, Unity.Mathematics.float3& shiftVector, Unity.Mathematics.quaternion& shiftRotation) { }
        private System.Single CalcMass(System.Single depth) { }
        private System.Single CalcInverseMass(System.Single friction) { }
        private System.Single CalcInverseMass(System.Single friction, System.Single depth) { }
        private System.Single CalcInverseMass(System.Single friction, System.Single depth, System.Boolean fix, System.Single fixMass) { }
        private System.Single CalcSelfCollisionInverseMass(System.Single friction, System.Boolean fix, System.Single clothMass) { }

    }

    // TypeToken: 0x2000214
    public class MinimumData`2
    {
        // Fields
        private T1 minDist;        // 0x0
        private T2 minData;        // 0x0
        private System.Boolean isValid;        // 0x0

        // Methods
        private System.Void Add(T1 distance, T2 data) { }
        private System.Void Clear() { }
        private System.Boolean get_IsValid() { }
        private T1 get_MinDistance() { }
        private T2 get_MinData() { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000215
    public struct FTransform
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Quaternion rotation;        // 0x1C
        public UnityEngine.Vector3 scale;        // 0x2C

        // Methods
        private BeyondDynamicBone.FTransform Default() { }

    }

    // TypeToken: 0x2000216
    public class MeshUtility
    {
        // Methods
        private UnityEngine.Mesh GetSharedMesh(UnityEngine.Renderer ren) { }
        private System.Boolean SetMesh(UnityEngine.Renderer ren, UnityEngine.Mesh mesh, UnityEngine.Transform[] skinBones) { }
        private System.Int32 GetTransformCount(UnityEngine.Renderer ren) { }

    }

    // TypeToken: 0x2000217
    public class Develop
    {
        // Methods
        private System.Void Log(System.Object& mes) { }
        private System.Void LogWarning(System.Object& mes) { }
        private System.Void LogError(System.Object& mes) { }
        private System.Void DebugLog(System.Object& mes) { }
        private System.Void DebugLogWarning(System.Object& mes) { }
        private System.Void DebugLogError(System.Object& mes) { }
        private System.Void Assert(System.Boolean condition) { }

    }

    // TypeToken: 0x2000218
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

    // TypeToken: 0x2000219
    public struct DataChunk
    {
        // Fields
        public System.Int32 startIndex;        // 0x10
        public System.Int32 dataLength;        // 0x14

        // Methods
        private System.Boolean get_IsValid() { }
        private BeyondDynamicBone.DataChunk get_Empty() { }
        private System.Void .ctor(System.Int32 sindex, System.Int32 length) { }
        private System.Void .ctor(System.Int32 sindex) { }
        private System.Void Clear() { }
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200021A
    public struct ExBitFlag16
    {
        // Fields
        public System.UInt16 Value;        // 0x10

        // Methods
        private System.Void .ctor(System.UInt16 initialValue) { }
        private System.Void Clear() { }
        private System.Void SetFlag(System.UInt16 flag, System.Boolean sw) { }
        private System.Boolean IsSet(System.UInt16 flag) { }

    }

    // TypeToken: 0x200021B
    public struct ExBitFlag8
    {
        // Fields
        public System.Byte Value;        // 0x10

        // Methods
        private System.Void .ctor(System.Byte initialValue) { }
        private System.Void Clear() { }
        private System.Void SetFlag(System.Byte flag, System.Boolean sw) { }
        private System.Boolean IsSet(System.Byte flag) { }

    }

    // TypeToken: 0x200021C
    public struct ExCostSortedList1, IComparable`1
    {
        // Fields
        private System.Single cost;        // 0x10
        private System.Int32 data;        // 0x14

        // Methods
        private System.Void .ctor(System.Single invalidCost) { }
        private System.Void .ctor(System.Single invalidCost, System.Int32 initData) { }
        private System.Boolean get_IsValid() { }
        private System.Int32 get_Count() { }
        private System.Single get_Cost() { }
        private System.Int32 get_Data() { }
        private System.Void Add(System.Single cost, System.Int32 item) { }
        private System.Int32 CompareTo(BeyondDynamicBone.ExCostSortedList1 other) { }
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200021D
    public struct ExCostSortedList4
    {
        // Fields
        private Unity.Mathematics.float4 costs;        // 0x10
        private Unity.Mathematics.int4 data;        // 0x20

        // Methods
        private System.Void .ctor(System.Single invalidCost) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsValid() { }
        private System.Boolean Add(System.Single cost, System.Int32 item) { }
        private System.Boolean Contains(System.Int32 item) { }
        private System.Int32 indexOf(System.Int32 item) { }
        private System.Void RemoveItem(System.Int32 item) { }
        private System.Single get_MinCost() { }
        private System.Single get_MaxCost() { }
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200021E
    public class ExNativeArray`1, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<T> nativeArray;        // 0x0
        private System.Collections.Generic.List<BeyondDynamicBone.DataChunk> emptyChunks;        // 0x0
        private System.Int32 useCount;        // 0x0

        // Methods
        private System.Void Dispose() { }
        private System.Boolean get_IsValid() { }
        private System.Int32 get_Length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 emptyLength, System.Boolean create) { }
        private System.Void .ctor(System.Int32 emptyLength, T fillData) { }
        private System.Void .ctor(Unity.Collections.NativeArray<T> dataArray) { }
        private System.Void .ctor(T[] dataArray) { }
        private BeyondDynamicBone.DataChunk AddRange(System.Int32 dataLength) { }
        private BeyondDynamicBone.DataChunk AddRange(System.Int32 dataLength, T fillData) { }
        private BeyondDynamicBone.DataChunk AddRange(T[] array) { }
        private BeyondDynamicBone.DataChunk AddRange(Unity.Collections.NativeArray<T> narray, System.Int32 length) { }
        private BeyondDynamicBone.DataChunk AddRange(BeyondDynamicBone.ExNativeArray<T> exarray) { }
        private BeyondDynamicBone.DataChunk AddRange(BeyondDynamicBone.ExSimpleNativeArray<T> exarray) { }
        private BeyondDynamicBone.DataChunk AddRange(U[] array) { }
        private BeyondDynamicBone.DataChunk AddRange(Unity.Collections.NativeArray<U> udata) { }
        private BeyondDynamicBone.DataChunk AddRangeTypeChange(U[] array) { }
        private BeyondDynamicBone.DataChunk AddRangeStride(U[] array) { }
        private BeyondDynamicBone.DataChunk Add(T data) { }
        private BeyondDynamicBone.DataChunk Expand(BeyondDynamicBone.DataChunk c, System.Int32 newDataLength) { }
        private BeyondDynamicBone.DataChunk ExpandAndFill(BeyondDynamicBone.DataChunk c, System.Int32 newDataLength, T fillData, T clearData) { }
        private T[] ToArray() { }
        private System.Void CopyTo(T[] array) { }
        private System.Void CopyTo(U[] array) { }
        private System.Void CopyFrom(Unity.Collections.NativeArray<T> array) { }
        private System.Void CopyFrom(Unity.Collections.NativeArray<U> array) { }
        private System.Void CopyTypeChange(U[] array) { }
        private System.Void CopyTypeChangeStride(U[] array) { }
        private System.Void AddEmpty(System.Int32 dataLength) { }
        private System.Void Remove(BeyondDynamicBone.DataChunk chunk) { }
        private System.Void Remove(System.Int32 index) { }
        private System.Void RemoveAndFill(BeyondDynamicBone.DataChunk chunk, T clearData) { }
        private System.Void Fill(T fillData) { }
        private System.Void Fill(BeyondDynamicBone.DataChunk chunk, T fillData) { }
        private System.Void FillInternal(System.Int32 start, System.Int32 size, T fillData) { }
        private System.Void Clear() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private T& GetRef(System.Int32 index) { }
        private Unity.Collections.NativeArray<T> GetNativeArray() { }
        private Unity.Collections.NativeArray<U> GetNativeArray() { }
        private BeyondDynamicBone.DataChunk GetEmptyChunk(System.Int32 dataLength) { }
        private System.Void AddEmptyChunk(BeyondDynamicBone.DataChunk chunk) { }
        private System.String ToString() { }
        private System.String ToSummary() { }

    }

    // TypeToken: 0x200021F
    public class ExProcessingList`1, IDisposable, IValid
    {
        // Fields
        public Unity.Collections.NativeReference<System.Int32> Counter;        // 0x0
        public Unity.Collections.NativeArray<T> Buffer;        // 0x0

        // Methods
        private System.Void Dispose() { }
        private System.Boolean IsValid() { }
        private System.Void .ctor() { }
        private System.Void UpdateBuffer(System.Int32 capacity) { }
        private System.Int32* GetJobSchedulePtr() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000220
    public class ExSimpleNativeArray`1, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<T> nativeArray;        // 0x0
        private System.Int32 count;        // 0x0
        private System.Int32 length;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 dataLength, System.Boolean areaOnly) { }
        private System.Void .ctor(T[] dataArray) { }
        private System.Void .ctor(Unity.Collections.NativeArray<T> array) { }
        private System.Void .ctor(Unity.Collections.NativeList<T> array) { }
        private System.Void .ctor(BeyondDynamicBone.ExSimpleNativeArray.SerializationData<T> sdata) { }
        private System.Void Dispose() { }
        private System.Boolean get_IsValid() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Length() { }
        private System.Void SetCount(System.Int32 newCount) { }
        private System.Void SetLength(System.Int32 newLength) { }
        private System.Void AddRange(System.Int32 dataLength) { }
        private System.Void AddRange(T[] dataArray) { }
        private System.Void AddRange(T[] dataArray, System.Int32 cnt) { }
        private System.Void AddRange(System.Int32 dataLength, T fillData) { }
        private System.Void AddRange(Unity.Collections.NativeArray<T> narray) { }
        private System.Void AddRange(Unity.Collections.NativeList<T> nlist) { }
        private System.Void AddRange(BeyondDynamicBone.ExSimpleNativeArray<T> exarray) { }
        private System.Void AddRange(U[] array) { }
        private System.Void AddRangeTypeChange(U[] array) { }
        private System.Void AddRangeTypeChange(Unity.Collections.NativeArray<U> array) { }
        private System.Void AddRangeStride(U[] array) { }
        private System.Void Add(T data) { }
        private T[] ToArray() { }
        private System.Void CopyTo(T[] array) { }
        private System.Void CopyTo(U[] array) { }
        private System.Void CopyToWithTypeChange(U[] array) { }
        private System.Void CopyToWithTypeChangeStride(U[] array) { }
        private System.Void CopyFrom(Unity.Collections.NativeArray<T> array) { }
        private System.Void CopyFrom(Unity.Collections.NativeArray<U> array) { }
        private System.Void CopyFromWithTypeChangeStride(Unity.Collections.NativeArray<U> array) { }
        private System.Void Fill(System.Int32 startIndex, System.Int32 dataLength, T fillData) { }
        private System.Void FillInternal(System.Int32 start, System.Int32 size, T fillData) { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private Unity.Collections.NativeArray<T> GetNativeArray() { }
        private Unity.Collections.NativeArray<U> GetNativeArray() { }
        private System.Void Expand(System.Int32 dataLength, System.Boolean force, System.Boolean copy) { }
        private System.String ToString() { }
        private BeyondDynamicBone.ExSimpleNativeArray.SerializationData<T> Serialize() { }
        private System.Boolean Deserialize(BeyondDynamicBone.ExSimpleNativeArray.SerializationData<T> data) { }

    }

    // TypeToken: 0x2000222
    public class ExTransformAccessArray, IDisposable
    {
        // Fields
        private UnityEngine.Jobs.TransformAccessArray transformArray;        // 0x10
        private System.Int32 nativeLength;        // 0x18
        private System.Collections.Generic.Queue<System.Int32> emptyStack;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> useIndexDict;        // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> indexDict;        // 0x30
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> referenceDict;        // 0x38

        // Methods
        private System.Void .ctor(System.Int32 capacity, System.Int32 desiredJobCount) { }
        private System.Void Dispose() { }
        private UnityEngine.Jobs.TransformAccessArray GetTransformAccessArray() { }
        private System.Int32 Add(UnityEngine.Transform element) { }
        private System.Void Remove(System.Int32 index) { }
        private System.Boolean Exist(System.Int32 index) { }
        private System.Boolean Exist(UnityEngine.Transform element) { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Length() { }
        private UnityEngine.Transform get_Item(System.Int32 index) { }
        private System.Int32 GetIndex(UnityEngine.Transform element) { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x2000223
    public class FixedList128BytesExtensions
    {
        // Methods
        private System.Boolean MC2IsCapacity(Unity.Collections.FixedList128Bytes<T>& fixedList) { }
        private System.Void MC2Set(Unity.Collections.FixedList128Bytes<T>& fixedList, T item) { }
        private System.Void MC2SetLimit(Unity.Collections.FixedList128Bytes<T>& fixedList, T item) { }
        private System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList128Bytes<T>& fixedList, T item) { }
        private System.Void MC2Push(Unity.Collections.FixedList128Bytes<T>& fixedList, T item) { }
        private T MC2Pop(Unity.Collections.FixedList128Bytes<T>& fixedList) { }
        private System.Void MC2Enqueue(Unity.Collections.FixedList128Bytes<T>& fixedList, T item) { }
        private T MC2Dequque(Unity.Collections.FixedList128Bytes<T>& fixedList) { }

    }

    // TypeToken: 0x2000224
    public class FixedList32BytesExtensions
    {
        // Methods
        private System.Boolean MC2IsCapacity(Unity.Collections.FixedList32Bytes<T>& fixedList) { }
        private System.Void MC2Set(Unity.Collections.FixedList32Bytes<T>& fixedList, T item) { }
        private System.Void MC2SetLimit(Unity.Collections.FixedList32Bytes<T>& fixedList, T item) { }
        private System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList32Bytes<T>& fixedList, T item) { }
        private System.Void MC2Push(Unity.Collections.FixedList32Bytes<T>& fixedList, T item) { }
        private T MC2Pop(Unity.Collections.FixedList32Bytes<T>& fixedList) { }
        private System.Void MC2Enqueue(Unity.Collections.FixedList32Bytes<T>& fixedList, T item) { }
        private T MC2Dequque(Unity.Collections.FixedList32Bytes<T>& fixedList) { }

    }

    // TypeToken: 0x2000225
    public class FixedList4096BytesExtensions
    {
        // Methods
        private System.Boolean MC2IsCapacity(Unity.Collections.FixedList4096Bytes<T>& fixedList) { }
        private System.Void MC2Set(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item) { }
        private System.Void MC2SetLimit(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item) { }
        private System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item) { }
        private System.Void MC2Push(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item) { }
        private T MC2Pop(Unity.Collections.FixedList4096Bytes<T>& fixedList) { }
        private System.Void MC2Enqueue(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item) { }
        private T MC2Dequque(Unity.Collections.FixedList4096Bytes<T>& fixedList) { }

    }

    // TypeToken: 0x2000226
    public class FixedList512BytesExtensions
    {
        // Methods
        private System.Boolean MC2IsCapacity(Unity.Collections.FixedList512Bytes<T>& fixedList) { }
        private System.Void MC2Set(Unity.Collections.FixedList512Bytes<T>& fixedList, T item) { }
        private System.Void MC2SetLimit(Unity.Collections.FixedList512Bytes<T>& fixedList, T item) { }
        private System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList512Bytes<T>& fixedList, T item) { }
        private System.Void MC2Push(Unity.Collections.FixedList512Bytes<T>& fixedList, T item) { }
        private T MC2Pop(Unity.Collections.FixedList512Bytes<T>& fixedList) { }
        private System.Void MC2Enqueue(Unity.Collections.FixedList512Bytes<T>& fixedList, T item) { }
        private T MC2Dequque(Unity.Collections.FixedList512Bytes<T>& fixedList) { }

    }

    // TypeToken: 0x2000227
    public class FixedList64BytesExtensions
    {
        // Methods
        private System.Boolean MC2IsCapacity(Unity.Collections.FixedList64Bytes<T>& fixedList) { }
        private System.Void MC2Set(Unity.Collections.FixedList64Bytes<T>& fixedList, T item) { }
        private System.Void MC2SetLimit(Unity.Collections.FixedList64Bytes<T>& fixedList, T item) { }
        private System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList64Bytes<T>& fixedList, T item) { }
        private System.Void MC2Push(Unity.Collections.FixedList64Bytes<T>& fixedList, T item) { }
        private T MC2Pop(Unity.Collections.FixedList64Bytes<T>& fixedList) { }
        private System.Void MC2Enqueue(Unity.Collections.FixedList64Bytes<T>& fixedList, T item) { }
        private T MC2Dequque(Unity.Collections.FixedList64Bytes<T>& fixedList) { }

    }

    // TypeToken: 0x2000228
    public class NativeArrayExtensions
    {
        // Methods
        private System.Void MC2DisposeSafe(Unity.Collections.NativeArray<T>& array) { }
        private System.Void MC2Resize(Unity.Collections.NativeArray<T>& array, System.Int32 size, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options) { }
        private System.Byte[] MC2ToRawBytes(Unity.Collections.NativeArray<T>& array) { }
        private Unity.Collections.NativeArray<T> MC2FromRawBytes(System.Byte[] bytes, Unity.Collections.Allocator allocator) { }

    }

    // TypeToken: 0x2000229
    public class NativeMultiHashMapExtensions
    {
        // Methods
        private System.Boolean MC2Contains(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key, TValue value) { }
        private System.Void MC2UniqueAdd(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key, TValue value) { }
        private System.Boolean MC2RemoveValue(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key, TValue value) { }
        private Unity.Collections.FixedList512Bytes<TValue> MC2ToFixedList512Bytes(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key) { }
        private Unity.Collections.FixedList128Bytes<TValue> MC2ToFixedList128Bytes(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key) { }
        private System.ValueTuple<TKey[],TValue[]> MC2Serialize(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map) { }
        private Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16> MC2Deserialize(Unity.Mathematics.int2[] keyArray, System.UInt16[] valueArray) { }
        private System.Void MC2DisposeSafe(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map) { }

    }

    // TypeToken: 0x200022B
    public class NativeParallelHashMap
    {
        // Methods
        private System.Void MC2DisposeSafe(Unity.Collections.NativeParallelHashMap<TKey,TValue>& map) { }

    }

    // TypeToken: 0x200022C
    public class NativeReferenceExtensions
    {
        // Methods
        private System.Int32 MC2InterlockedStartIndex(Unity.Collections.NativeReference<System.Int32>& counter, System.Int32 dataCount) { }
        private System.Int32 MC2InterlockedStartIndex(System.Int32* cntPt, System.Int32 dataCount) { }

    }

    // TypeToken: 0x200022D
    public class PlayerLoopUtils
    {
        // Methods
        private System.Void AddPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem method, UnityEngine.LowLevel.PlayerLoopSystem& playerLoop, System.String categoryName, System.String systemName, System.Boolean last, System.Boolean before) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022F
    public class MagicaClothProcessingException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception inner) { }

    }

    // TypeToken: 0x2000230
    public class MagicaClothCanceledException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception inner) { }

    }

    // TypeToken: 0x2000231
    public struct ResultCode
    {
        // Fields
        private BeyondDynamicBone.Define.Result result;        // 0x10
        private BeyondDynamicBone.Define.Result warning;        // 0x14

        // Methods
        private BeyondDynamicBone.Define.Result get_Result() { }
        private BeyondDynamicBone.ResultCode get_None() { }
        private BeyondDynamicBone.ResultCode get_Empty() { }
        private BeyondDynamicBone.ResultCode get_Success() { }
        private BeyondDynamicBone.ResultCode get_Error() { }
        private System.Void .ctor(BeyondDynamicBone.Define.Result initResult) { }
        private System.Void Clear() { }
        private System.Void SetResult(BeyondDynamicBone.Define.Result code) { }
        private System.Void SetSuccess() { }
        private System.Void SetCancel() { }
        private System.Void SetError(BeyondDynamicBone.Define.Result code) { }
        private System.Void SetWarning(BeyondDynamicBone.Define.Result code) { }
        private System.Void Merge(BeyondDynamicBone.ResultCode src) { }
        private System.Void SetProcess() { }
        private System.Boolean IsResult(BeyondDynamicBone.Define.Result code) { }
        private System.Boolean IsNone() { }
        private System.Boolean IsSuccess() { }
        private System.Boolean IsFaild() { }
        private System.Boolean IsCancel() { }
        private System.Boolean IsNormal() { }
        private System.Boolean IsError() { }
        private System.Boolean IsProcess() { }
        private System.Boolean IsWarning() { }
        private System.String GetResultString() { }
        private System.String GetWarningString() { }
        private System.String GetResultInformation() { }
        private System.String GetWarningInformation() { }
        private System.Void DebugLog(System.Boolean error, System.Boolean warning, System.Boolean normal) { }

    }

    // TypeToken: 0x2000232
    public class TimeSpan
    {
        // Fields
        private System.String name;        // 0x10
        private System.DateTime stime;        // 0x18
        private System.DateTime etime;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }
        private System.Void Start() { }
        private System.Void Finish() { }
        private System.Double TotalSeconds() { }
        private System.Double TotalMilliSeconds() { }
        private System.String ToString() { }
        private System.Void DebugLog() { }
        private System.Void Log() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000233
    public class UnityTimeSpan
    {
        // Fields
        private System.String name;        // 0x10
        private System.Single stime;        // 0x18
        private System.Single etime;        // 0x1C
        private System.Boolean isFinish;        // 0x20

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Void Finish() { }
        private System.Single TotalSeconds() { }
        private System.Single TotalMilliSeconds() { }
        private System.String ToString() { }
        private System.Void DebugLog() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000234
    public class VirtualMesh, IDisposable, IValid
    {
        // Fields
        public System.String name;        // 0x10
        public BeyondDynamicBone.ResultCode result;        // 0x18
        public System.Boolean isManaged;        // 0x20
        public BeyondDynamicBone.VirtualMesh.MeshType meshType;        // 0x24
        public System.Boolean isBoneCloth;        // 0x28
        public BeyondDynamicBone.ExSimpleNativeArray<System.Int32> referenceIndices;        // 0x30
        public BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.VertexAttribute> attributes;        // 0x38
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> localPositions;        // 0x40
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> localNormals;        // 0x48
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3> localTangents;        // 0x50
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float2> uv;        // 0x58
        public BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> boneWeights;        // 0x60
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.int3> triangles;        // 0x68
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.int2> lines;        // 0x70
        public System.Int32 centerTransformIndex;        // 0x78
        public Unity.Mathematics.float4x4 initLocalToWorld;        // 0x7C
        public Unity.Mathematics.float4x4 initWorldToLocal;        // 0xBC
        public Unity.Mathematics.quaternion initRotation;        // 0xFC
        public Unity.Mathematics.quaternion initInverseRotation;        // 0x10C
        public Unity.Mathematics.float3 initScale;        // 0x11C
        public System.Int32 skinRootIndex;        // 0x128
        public BeyondDynamicBone.ExSimpleNativeArray<System.Int32> skinBoneTransformIndices;        // 0x130
        public BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float4x4> skinBoneBindPoses;        // 0x138
        public BeyondDynamicBone.TransformData transformData;        // 0x140
        public Unity.Collections.NativeReference<BeyondDynamicBone.AABB> boundingBox;        // 0x148
        public Unity.Collections.NativeReference<System.Single> averageVertexDistance;        // 0x158
        public Unity.Collections.NativeReference<System.Single> maxVertexDistance;        // 0x168
        public BeyondDynamicBone.DataChunk mergeChunk;        // 0x178
        public Unity.Collections.NativeArray<System.Int32> joinIndices;        // 0x180
        public Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>> vertexToTriangles;        // 0x190
        public Unity.Collections.NativeArray<System.UInt32> vertexToVertexIndexArray;        // 0x1A0
        public Unity.Collections.NativeArray<System.UInt16> vertexToVertexDataArray;        // 0x1B0
        public Unity.Collections.NativeArray<Unity.Mathematics.int2> edges;        // 0x1C0
        public static System.Byte EdgeFlag_Cut;        // 0x0
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> edgeFlags;        // 0x1D0
        public Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16> edgeToTriangles;        // 0x1E0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> vertexBindPosePositions;        // 0x1F0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexBindPoseRotations;        // 0x200
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexToTransformRotations;        // 0x210
        public Unity.Collections.NativeArray<System.Single> vertexDepths;        // 0x220
        public Unity.Collections.NativeArray<System.Int32> vertexRootIndices;        // 0x230
        public Unity.Collections.NativeArray<System.Int32> vertexParentIndices;        // 0x240
        public Unity.Collections.NativeArray<System.UInt32> vertexChildIndexArray;        // 0x250
        public Unity.Collections.NativeArray<System.UInt16> vertexChildDataArray;        // 0x260
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> vertexLocalPositions;        // 0x270
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> vertexLocalRotations;        // 0x280
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> normalAdjustmentRotations;        // 0x290
        public static System.Byte BaseLineFlag_IncludeLine;        // 0x0
        public Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8> baseLineFlags;        // 0x2A0
        public Unity.Collections.NativeArray<System.UInt16> baseLineStartDataIndices;        // 0x2B0
        public Unity.Collections.NativeArray<System.UInt16> baseLineDataCounts;        // 0x2C0
        public Unity.Collections.NativeArray<System.UInt16> baseLineData;        // 0x2D0
        public System.Int32[] customSkinningBoneIndices;        // 0x2E0
        public System.UInt16[] centerFixedList;        // 0x2E8
        public Unity.Collections.NativeReference<Unity.Mathematics.float3> localCenterPosition;        // 0x2F0
        public BeyondDynamicBone.VirtualMesh mappingProxyMesh;        // 0x300
        public Unity.Mathematics.float3 centerWorldPosition;        // 0x308
        public Unity.Mathematics.quaternion centerWorldRotation;        // 0x314
        public Unity.Mathematics.float3 centerWorldScale;        // 0x324
        public Unity.Mathematics.float4x4 toProxyMatrix;        // 0x330
        public Unity.Mathematics.quaternion toProxyRotation;        // 0x370
        public System.Int32 mappingId;        // 0x380

        // Methods
        private System.Void ImportFrom(BeyondDynamicBone.RenderSetupData rsetup) { }
        private System.Void ImportMeshType(BeyondDynamicBone.RenderSetupData rsetup, System.Int32[] transformIndices) { }
        private System.Void ImportMeshSkinning() { }
        private System.Void ImportBoneType(BeyondDynamicBone.RenderSetupData rsetup, System.Int32[] transformIndices) { }
        private System.Void ImportFrom(BeyondDynamicBone.RenderData renderData) { }
        private System.Void SelectionMesh(BeyondDynamicBone.SelectionData selectionData, Unity.Mathematics.float4x4 selectionLocalToWorldMatrix, System.Single mergin) { }
        private System.Single CalcSelectionMergin(BeyondDynamicBone.ReductionSettings settings) { }
        private System.Void AddMesh(BeyondDynamicBone.VirtualMesh cmesh) { }
        private System.Void SetTransform(UnityEngine.Transform center, UnityEngine.Transform skinRoot, System.Int32 centerId, System.Int32 skinRootId) { }
        private System.Void SetTransform(BeyondDynamicBone.TransformRecord centerRecord, BeyondDynamicBone.TransformRecord skinRootRecord) { }
        private System.Void SetCenterTransform(UnityEngine.Transform t, System.Int32 tid) { }
        private System.Void SetSkinRoot(UnityEngine.Transform t, System.Int32 tid) { }
        private UnityEngine.Transform GetCenterTransform() { }
        private System.Void SetCustomSkinningBones(BeyondDynamicBone.TransformRecord clothTransformRecord, System.Collections.Generic.List<BeyondDynamicBone.TransformRecord> bones) { }
        private System.Boolean CompareSpace(BeyondDynamicBone.VirtualMesh target) { }
        private Unity.Mathematics.float4x4 CenterTransformTo(BeyondDynamicBone.VirtualMesh to) { }
        private System.Void Mapping(BeyondDynamicBone.VirtualMesh proxyMesh) { }
        private Unity.Mathematics.float4 CalcVertexWeights(Unity.Mathematics.float4 distances) { }
        private System.Void Optimization() { }
        private System.Void RemoveDuplicateTriangles() { }
        private System.Boolean CheckTwoTriangleOpen(Unity.Mathematics.int3& tri1, Unity.Mathematics.int3& tri2, Unity.Mathematics.int2& edge, Unity.Mathematics.float3& tri1n) { }
        private System.Single CalcTwoTriangleAngle(Unity.Mathematics.int3& tri1, Unity.Mathematics.int3& tri2, Unity.Mathematics.int2& edge) { }
        private System.Void ConvertProxyMesh(BeyondDynamicBone.ClothSerializeData sdata, BeyondDynamicBone.TransformRecord clothTransformRecord, System.Collections.Generic.List<BeyondDynamicBone.TransformRecord> customSkinningBoneRecords, BeyondDynamicBone.TransformRecord normalAdjustmentTransformRecord) { }
        private System.Void ProxyNormalAdjustment(BeyondDynamicBone.ClothSerializeData sdata, BeyondDynamicBone.TransformRecord normalAdjustmentTransformRecord) { }
        private System.Void ProxyCreateFixedListAndAABB() { }
        private System.Void OptimizeTriangleDirection(Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleNormals, System.Single sameSurfaceAngle) { }
        private System.Void CreateCustomSkinning(BeyondDynamicBone.CustomSkinningSettings setting, System.Collections.Generic.List<BeyondDynamicBone.TransformRecord> bones) { }
        private System.Void ApplySelectionAttribute(BeyondDynamicBone.SelectionData selectionData) { }
        private System.Void CreateMeshBaseLine() { }
        private System.Void CreateTransformBaseLine() { }
        private System.Void DoBaseLine_Bone_CreateBoneChildInfo(System.Int32 vcnt, Unity.Collections.NativeArray<System.Int32> parentIndices, Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> childMap) { }
        private System.Void CreateBaseLinePose() { }
        private System.Void CreateVertexRootAndDepth() { }
        private System.Void Reduction(BeyondDynamicBone.ReductionSettings settings, System.Threading.CancellationToken ct) { }
        private System.Void InitReductionWorkData(BeyondDynamicBone.ReductionWorkData workData) { }
        private System.Void Organization(BeyondDynamicBone.ReductionSettings setting, BeyondDynamicBone.ReductionWorkData workData) { }
        private System.Void OrganizationInit(BeyondDynamicBone.ReductionSettings setting, BeyondDynamicBone.ReductionWorkData workData) { }
        private System.Void OrganizationCreateRemapData(BeyondDynamicBone.ReductionWorkData workData) { }
        private System.Void OrganizationCreateBasicData(BeyondDynamicBone.ReductionWorkData workData) { }
        private System.Void OrganizationCreateLineTriangle(BeyondDynamicBone.ReductionWorkData workData) { }
        private System.Void OrganizeStoreVirtualMesh(BeyondDynamicBone.ReductionWorkData workData) { }
        private BeyondDynamicBone.VirtualMesh.ShareSerializationData ShareSerialize() { }
        private BeyondDynamicBone.VirtualMesh ShareDeserialize(BeyondDynamicBone.VirtualMesh.ShareSerializationData sdata) { }
        private BeyondDynamicBone.VirtualMesh.UniqueSerializationData UniqueSerialize() { }
        private System.Void CalcAverageAndMaxVertexDistanceRun() { }
        private BeyondDynamicBone.GridMap<System.Int32> CreateVertexIndexGridMapRun(System.Single gridSize) { }
        private BeyondDynamicBone.VirtualMeshRaycastHit IntersectRayMesh(Unity.Mathematics.float3 rayPos, Unity.Mathematics.float3 rayDir, System.Boolean doubleSide, System.Single pointRadius) { }
        private System.Single get_InitCalcScale() { }
        private System.Boolean get_IsSuccess() { }
        private System.Boolean get_IsError() { }
        private System.Boolean get_IsProcess() { }
        private System.Int32 get_VertexCount() { }
        private System.Int32 get_TriangleCount() { }
        private System.Int32 get_LineCount() { }
        private System.Int32 get_SkinBoneCount() { }
        private System.Int32 get_TransformCount() { }
        private System.Boolean get_IsProxy() { }
        private System.Boolean get_IsMapping() { }
        private System.Int32 get_BaseLineCount() { }
        private System.Int32 get_EdgeCount() { }
        private System.Int32 get_CustomSkinningBoneCount() { }
        private System.Int32 get_CenterFixedPointCount() { }
        private System.Int32 get_NormalAdjustmentRotationCount() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean initialize) { }
        private System.Void .ctor(System.String name) { }
        private System.Void Dispose() { }
        private System.Void SetName(System.String newName) { }
        private System.Boolean IsValid() { }
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200026E
    public struct VertexAttribute, IEquatable`1
    {
        // Fields
        public static System.Byte Flag_Fixed;        // 0x0
        public static System.Byte Flag_Move;        // 0x0
        public static System.Byte Flag_InvalidMotion;        // 0x0
        public static System.Byte Flag_DisableCollision;        // 0x0
        public static System.Byte Flag_Triangle;        // 0x0
        public static readonly BeyondDynamicBone.VertexAttribute Invalid;        // 0x0
        public static readonly BeyondDynamicBone.VertexAttribute Fixed;        // 0x1
        public static readonly BeyondDynamicBone.VertexAttribute Move;        // 0x2
        public static readonly BeyondDynamicBone.VertexAttribute DisableCollision;        // 0x3
        public System.Byte Value;        // 0x10

        // Methods
        private System.Void .ctor(System.Byte initialValue) { }
        private System.Void Clear() { }
        private System.Void SetFlag(System.Byte flag, System.Boolean sw) { }
        private System.Void SetFlag(BeyondDynamicBone.VertexAttribute attr, System.Boolean sw) { }
        private System.Boolean IsSet(System.Byte flag) { }
        private System.Boolean IsInvalid() { }
        private System.Boolean IsFixed() { }
        private System.Boolean IsMove() { }
        private System.Boolean IsDontMove() { }
        private System.Boolean IsMotion() { }
        private System.Boolean IsDisableCollision() { }
        private BeyondDynamicBone.VertexAttribute JoinAttribute(BeyondDynamicBone.VertexAttribute attr1, BeyondDynamicBone.VertexAttribute attr2) { }
        private System.Boolean Equals(BeyondDynamicBone.VertexAttribute other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(BeyondDynamicBone.VertexAttribute lhs, BeyondDynamicBone.VertexAttribute rhs) { }
        private System.Boolean op_Inequality(BeyondDynamicBone.VertexAttribute lhs, BeyondDynamicBone.VertexAttribute rhs) { }
        private System.Void .cctor() { }
        private System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x200026F
    public struct VirtualMeshBoneWeight
    {
        // Fields
        public Unity.Mathematics.float4 weights;        // 0x10
        public Unity.Mathematics.int4 boneIndices;        // 0x20

        // Methods
        private System.Boolean get_IsValid() { }
        private System.Void .ctor(Unity.Mathematics.int4 boneIndices, Unity.Mathematics.float4 weights) { }
        private System.Int32 get_Count() { }
        private System.Void AddWeight(System.Int32 boneIndex, System.Single weight) { }
        private System.Void AddWeight(BeyondDynamicBone.VirtualMeshBoneWeight& bw) { }
        private System.Void AdjustWeight() { }
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000270
    public class VirtualMeshContainer, IDisposable
    {
        // Fields
        public BeyondDynamicBone.VirtualMesh shareVirtualMesh;        // 0x10
        public BeyondDynamicBone.VirtualMesh.UniqueSerializationData uniqueData;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(BeyondDynamicBone.VirtualMesh vmesh) { }
        private System.Void Dispose() { }
        private System.Boolean get_hasUniqueData() { }
        private System.Int32 GetTransformCount() { }
        private UnityEngine.Transform GetTransformFromIndex(System.Int32 index) { }
        private UnityEngine.Transform GetCenterTransform() { }

    }

    // TypeToken: 0x2000271
    public struct VirtualMeshPrimitive
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static BeyondDynamicBone.VirtualMeshPrimitive None;        // 0x0
        public static BeyondDynamicBone.VirtualMeshPrimitive Point;        // 0x0
        public static BeyondDynamicBone.VirtualMeshPrimitive Edge;        // 0x0
        public static BeyondDynamicBone.VirtualMeshPrimitive Triangle;        // 0x0

    }

    // TypeToken: 0x2000272
    public struct VirtualMeshRaycastHit, IComparable`1, IValid
    {
        // Fields
        public BeyondDynamicBone.VirtualMeshPrimitive type;        // 0x10
        public System.Int32 index;        // 0x14
        public Unity.Mathematics.float3 position;        // 0x18
        public Unity.Mathematics.float3 normal;        // 0x24
        public System.Single distance;        // 0x30

        // Methods
        private System.Int32 CompareTo(BeyondDynamicBone.VirtualMeshRaycastHit other) { }
        private System.Boolean IsValid() { }
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000273
    public struct VirtualMeshTransform
    {
        // Fields
        public Unity.Collections.FixedString32Bytes name;        // 0x10
        public System.Int32 index;        // 0x30
        public Unity.Mathematics.float4x4 localToWorldMatrix;        // 0x34
        public Unity.Mathematics.float4x4 worldToLocalMatrix;        // 0x74
        public System.Int32 parentIndex;        // 0xB4

        // Methods
        private System.Void .ctor(UnityEngine.Transform t) { }
        private System.Void .ctor(UnityEngine.Transform t, System.Int32 index) { }
        private BeyondDynamicBone.VirtualMeshTransform Clone() { }
        private BeyondDynamicBone.VirtualMeshTransform get_Origin() { }
        private System.Int32 GetHashCode() { }
        private System.Void Update(UnityEngine.Transform t) { }
        private Unity.Mathematics.float3 TransformPoint(Unity.Mathematics.float3 pos) { }
        private Unity.Mathematics.float3 TransformVector(Unity.Mathematics.float3 vec) { }
        private Unity.Mathematics.float3 TransformDirection(Unity.Mathematics.float3 dir) { }
        private Unity.Mathematics.float3 InverseTransformPoint(Unity.Mathematics.float3 pos) { }
        private Unity.Mathematics.float3 InverseTransformVector(Unity.Mathematics.float3 vec) { }
        private Unity.Mathematics.float3 InverseTransformDirection(Unity.Mathematics.float3 dir) { }
        private Unity.Mathematics.quaternion InverseTransformRotation(Unity.Mathematics.quaternion rot) { }
        private BeyondDynamicBone.VirtualMeshTransform Transform(BeyondDynamicBone.VirtualMeshTransform& to) { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000276
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void __Gen_Wrap_0(System.Object P0) { }
        private System.Boolean __Gen_Wrap_1() { }
        private System.Boolean __Gen_Wrap_2(System.Object P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_3(System.Object P0) { }
        private System.Void __Gen_Wrap_4(System.Object P0, System.Single P1, System.Single P2) { }
        private System.Void __Gen_Wrap_5(System.Object P0, System.Boolean P1, Unity.Mathematics.float3 P2, Unity.Mathematics.quaternion P3) { }
        private BeyondDynamicBone.BeyondBoneCloth __Gen_Wrap_6(System.Object P0) { }
        private System.Void __Gen_Wrap_7(BeyondDynamicBone.ResultCode& P0, BeyondDynamicBone.Define.Result P1) { }
        private System.Void __Gen_Wrap_8(BeyondDynamicBone.ResultCode& P0) { }
        private System.Void __Gen_Wrap_9(System.Object& P0) { }
        private BeyondDynamicBone.ClothSerializeData2 __Gen_Wrap_10(System.Object P0) { }
        private System.Void __Gen_Wrap_11(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.Boolean __Gen_Wrap_12(UnityEngine.Transform P0) { }
        private System.Boolean __Gen_Wrap_13(UnityEngine.Renderer P0) { }
        private BeyondDynamicBone.ResultCode __Gen_Wrap_14(System.Object P0) { }
        private System.Boolean __Gen_Wrap_15(BeyondDynamicBone.ResultCode& P0) { }
        private System.Void __Gen_Wrap_16(BeyondDynamicBone.ResultCode& P0, BeyondDynamicBone.ResultCode P1) { }
        private BeyondDynamicBone.SharePreBuildData __Gen_Wrap_17(System.Object P0) { }
        private Unity.Mathematics.float4x4 __Gen_Wrap_18(System.Object P0) { }
        private System.Void __Gen_Wrap_19(BeyondDynamicBone.CullingSettings.CullingParams& P0, System.Object P1) { }
        private System.Single __Gen_Wrap_20(System.Object P0, System.Single P1) { }
        private System.Void __Gen_Wrap_21(BeyondDynamicBone.InertiaConstraint.InertiaConstraintParams& P0, System.Object P1) { }
        private System.Void __Gen_Wrap_22(BeyondDynamicBone.TetherConstraint.TetherConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2) { }
        private System.Void __Gen_Wrap_23(BeyondDynamicBone.DistanceConstraint.DistanceConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2) { }
        private System.Void __Gen_Wrap_24(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingConstraintParams& P0, System.Object P1) { }
        private System.Void __Gen_Wrap_25(BeyondDynamicBone.AngleConstraint.AngleConstraintParams& P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_26(BeyondDynamicBone.MotionConstraint.MotionConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2) { }
        private System.Void __Gen_Wrap_27(BeyondDynamicBone.ColliderCollisionConstraint.ColliderCollisionConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2) { }
        private System.Void __Gen_Wrap_28(BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2) { }
        private System.Void __Gen_Wrap_29(BeyondDynamicBone.WindParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2) { }
        private System.Void __Gen_Wrap_30(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2) { }
        private BeyondDynamicBone.ClothParameters __Gen_Wrap_31(System.Object P0) { }
        private BeyondDynamicBone.RenderSetupData __Gen_Wrap_32(System.Object P0) { }
        private BeyondDynamicBone.TransformData __Gen_Wrap_33(System.Object P0) { }
        private Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16> __Gen_Wrap_34(System.Object P0, System.Object P1) { }
        private BeyondDynamicBone.VirtualMesh __Gen_Wrap_35(System.Object P0) { }
        private System.Void __Gen_Wrap_36(System.Object P0, System.Object P1) { }
        private BeyondDynamicBone.PreBuildManager.ShareDeserializationData __Gen_Wrap_37(System.Object P0, System.Object P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_38(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.Int32 __Gen_Wrap_39(System.Object P0) { }
        private System.Int32 __Gen_Wrap_40(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private BeyondDynamicBone.RenderData __Gen_Wrap_41(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_42(System.Object P0, BeyondDynamicBone.ClothProcess.ClothType P1, System.Object P2, System.Object P3, System.Object P4, BeyondDynamicBone.RenderSetupData.BoneConnectionMode P5) { }
        private BeyondDynamicBone.TeamManager.TeamData& __Gen_Wrap_43(System.Object P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_44(BeyondDynamicBone.TeamManager.TeamData& P0) { }
        private System.Void __Gen_Wrap_45(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_46(System.Object P0, BeyondDynamicBone.DataChunk P1, System.Boolean P2) { }
        private System.Boolean __Gen_Wrap_47(BeyondDynamicBone.ClothProcess P0) { }
        private System.Void __Gen_Wrap_48(System.Object P0, Unity.Collections.NativeArray<UnityEngine.BoneWeight> P1) { }
        private System.Void __Gen_Wrap_49(System.Object P0, System.Object P1, System.Int32 P2) { }
        private BeyondDynamicBone.PreBuildManager.ShareDeserializationData __Gen_Wrap_50(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_51(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_52(System.Object P0, System.Int32 P1, System.Object P2) { }
        private System.Int32 __Gen_Wrap_53(System.Object P0, System.Object P1, BeyondDynamicBone.ClothParameters P2) { }
        private System.Int32 __Gen_Wrap_54(System.Object P0, System.Object P1, BeyondDynamicBone.ClothParameters& P2) { }
        private UnityEngine.Transform __Gen_Wrap_55(System.Object P0, System.Int32 P1) { }
        private BeyondDynamicBone.DataChunk __Gen_Wrap_56(System.Object P0, System.Object P1, System.Int32 P2) { }
        private BeyondDynamicBone.DataChunk __Gen_Wrap_57(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private UnityEngine.Vector3 __Gen_Wrap_58(System.Object P0) { }
        private System.Void __Gen_Wrap_59(System.Object P0, System.Object P1, BeyondDynamicBone.ExBitFlag8 P2, System.Int32 P3, System.Int32 P4) { }
        private System.Void __Gen_Wrap_60(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.Int32 P4, System.Int32 P5) { }
        private BeyondDynamicBone.ClothParameters& __Gen_Wrap_61(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_62(System.Object P0, System.Int32 P1, BeyondDynamicBone.TeamManager.TeamData P2, System.UInt32 P3, System.Int32 P4, System.Int32 P5, System.Int32 P6) { }
        private System.Void __Gen_Wrap_63(BeyondDynamicBone.DataChunk& P0) { }
        private Unity.Collections.FixedList64Bytes<System.Int16>& __Gen_Wrap_64(System.Object P0, System.Int32 P1) { }
        private UnityEngine.Transform __Gen_Wrap_65(System.Object P0) { }
        private BeyondDynamicBone.DataChunk __Gen_Wrap_66(System.Object P0, System.Object P1, BeyondDynamicBone.ExBitFlag8 P2, System.Int32 P3) { }
        private BeyondDynamicBone.DataChunk __Gen_Wrap_67(System.Object P0, System.Int32 P1, System.Object P2) { }
        private System.Void __Gen_Wrap_68(BeyondDynamicBone.VirtualMeshContainer P0) { }
        private System.String __Gen_Wrap_69(BeyondDynamicBone.ResultCode& P0) { }
        private Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> __Gen_Wrap_70(Unity.Collections.NativeArray<System.UInt32>& P0, Unity.Collections.NativeArray<System.UInt16>& P1) { }
        private System.Int32 __Gen_Wrap_71(Unity.Mathematics.int3 P0, Unity.Mathematics.int2 P1) { }
        private BeyondDynamicBone.DistanceConstraint.ConstraintData __Gen_Wrap_72(System.Object P0, BeyondDynamicBone.ClothParameters& P1) { }
        private Unity.Mathematics.int2 __Gen_Wrap_73(Unity.Mathematics.int3 P0, Unity.Mathematics.int3 P1, Unity.Mathematics.int2 P2) { }
        private System.Void __Gen_Wrap_74(System.Object P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Single& P5, System.SByte& P6) { }
        private Unity.Mathematics.int4 __Gen_Wrap_75(System.Int32 P0, System.Int32 P1, System.Int32 P2, System.Int32 P3) { }
        private Unity.Mathematics.int4 __Gen_Wrap_76(Unity.Mathematics.int4 P0) { }
        private BeyondDynamicBone.TriangleBendingConstraint.ConstraintData __Gen_Wrap_77(System.Object P0, BeyondDynamicBone.ClothParameters& P1) { }
        private System.Void __Gen_Wrap_78(BeyondDynamicBone.InertiaConstraint.CenterData& P0) { }
        private BeyondDynamicBone.InertiaConstraint.ConstraintData __Gen_Wrap_79(System.Object P0, BeyondDynamicBone.ClothParameters& P1) { }
        private System.Int32 __Gen_Wrap_80(System.Object P0, System.Object P1, System.Int32 P2, System.Byte P3, System.Boolean P4) { }
        private System.Void __Gen_Wrap_81(System.Object P0, System.Object P1, System.Object P2) { }
        private System.String __Gen_Wrap_82(System.Object P0) { }
        private System.Int32[] __Gen_Wrap_83(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, Unity.Collections.NativeArray<Unity.Mathematics.float3> P5, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> P6, Unity.Collections.NativeArray<Unity.Mathematics.float3> P7, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> P8, Unity.Collections.NativeArray<Unity.Mathematics.float3> P9, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> P10) { }
        private System.Void __Gen_Wrap_84(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_85(Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> P0, System.Int32 P1, BeyondDynamicBone.VirtualMeshBoneWeight P2) { }
        private System.Int32 __Gen_Wrap_86(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private Unity.Mathematics.int3 __Gen_Wrap_87(System.Int32 P0, System.Int32 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_88(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P2) { }
        private System.Void __Gen_Wrap_89(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P2, Unity.Collections.NativeArray<Unity.Mathematics.float2> P3) { }
        private System.Void __Gen_Wrap_90(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, Unity.Collections.NativeArray<Unity.Mathematics.float3> P1, System.Int32 P2, Unity.Mathematics.float4x4& P3) { }
        private BeyondDynamicBone.ResultCode __Gen_Wrap_91(System.Object P0, System.Object P1, System.Object P2, System.Object P3, BeyondDynamicBone.SelectionData& P4) { }
        private System.Single __Gen_Wrap_92(BeyondDynamicBone.AABB& P0) { }
        private System.Single __Gen_Wrap_93(System.Object P0) { }
        private System.Single __Gen_Wrap_94(System.Object P0, System.Object P1) { }
        private Unity.Collections.NativeArray<Unity.Mathematics.float3> __Gen_Wrap_95(System.Object P0) { }
        private Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> __Gen_Wrap_96(System.Object P0) { }
        private System.Void __Gen_Wrap_97(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Mathematics.float4x4& P2) { }
        private BeyondDynamicBone.GridMap<System.Int32> __Gen_Wrap_98(System.Single P0, Unity.Collections.NativeArray<Unity.Mathematics.float3>& P1, Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>& P2, System.Boolean P3, System.Boolean P4, System.Boolean P5, System.Boolean P6) { }
        private System.Void __Gen_Wrap_99(System.Object P0, System.Object P1, Unity.Mathematics.float4x4 P2, System.Single P3) { }
        private System.Boolean __Gen_Wrap_100(System.Object P0, System.Object P1) { }
        private Unity.Mathematics.float4x4 __Gen_Wrap_101(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_102(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_103(System.Object P0, BeyondDynamicBone.VertexAttribute P1) { }
        private System.Int32 __Gen_Wrap_104(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_105(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_106(System.Object P0, System.Object P1, System.Threading.CancellationToken P2) { }
        private System.Void __Gen_Wrap_107(Unity.Collections.NativeArray<Unity.Mathematics.quaternion> P0, System.Int32 P1, Unity.Mathematics.quaternion P2) { }
        private System.Single __Gen_Wrap_108(System.Object P0, Unity.Mathematics.int3& P1, Unity.Mathematics.int3& P2, Unity.Mathematics.int2& P3) { }
        private System.Boolean __Gen_Wrap_109(System.Object P0, Unity.Mathematics.int3& P1, Unity.Mathematics.int3& P2, Unity.Mathematics.int2& P3, Unity.Mathematics.float3& P4) { }
        private System.Void __Gen_Wrap_110(System.Object P0, Unity.Collections.NativeArray<Unity.Mathematics.float3> P1, System.Single P2) { }
        private Unity.Mathematics.float3 __Gen_Wrap_111(BeyondDynamicBone.AABB& P0) { }
        private System.Void __Gen_Wrap_112(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4) { }
        private BeyondDynamicBone.GridMap<System.Int32> __Gen_Wrap_113(System.Object P0, System.Single P1) { }
        private BeyondDynamicBone.ResultCode __Gen_Wrap_114(System.Object P0, System.Object P1) { }
        private BeyondDynamicBone.SelectionData __Gen_Wrap_115(System.Object P0) { }
        private System.Void __Gen_Wrap_116() { }
        private System.Void __Gen_Wrap_117(System.Object P0, BeyondDynamicBone.DataChunk P1) { }
        private System.Void __Gen_Wrap_118(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_119(System.Object P0, BeyondDynamicBone.TeamManager.TeamData& P1, System.Int32 P2) { }
        private System.Threading.Tasks.Task __Gen_Wrap_120(System.Object P0, System.Threading.CancellationToken P1) { }
        private System.Void __Gen_Wrap_121(System.Object P0, System.Single P1) { }
        private System.Void __Gen_Wrap_122(UnityEngine.Transform P0) { }
        private System.Void __Gen_Wrap_123(BeyondDynamicBone.RenderSetupData.UniqueSerializationData P0) { }
        private System.Void __Gen_Wrap_124(BeyondDynamicBone.VirtualMesh.UniqueSerializationData P0) { }
        private System.Void __Gen_Wrap_125(System.Int32 P0) { }
        private System.Void __Gen_Wrap_126(BeyondDynamicBone.TransformRecord P0) { }
        private System.Void __Gen_Wrap_127(System.Object P0, System.Boolean P1) { }
        private BeyondDynamicBone.InertiaConstraint.CenterData& __Gen_Wrap_128(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_129(System.Object P0, UnityEngine.Vector3 P1, System.Single P2, BeyondDynamicBone.ClothForceMode P3) { }
        private System.Void __Gen_Wrap_130(System.Object P0, System.Boolean P1, System.Single P2) { }
        private BeyondDynamicBone.CheckSliderSerializeData __Gen_Wrap_131(System.Object P0) { }
        private Unity.Collections.BitField32 __Gen_Wrap_132(System.Object P0) { }
        private BeyondDynamicBone.ClothProcess.RenderMeshInfo __Gen_Wrap_133(System.Object P0, System.Int32 P1) { }
        private BeyondDynamicBone.ClothUpdateMode __Gen_Wrap_134(System.Object P0) { }
        private System.Void __Gen_Wrap_135(BeyondDynamicBone.ClothProcess.GenerateSelectionJob& P0, System.Int32 P1) { }
        private BeyondDynamicBone.ReductionSettings __Gen_Wrap_136(System.Object P0) { }
        private BeyondDynamicBone.CustomSkinningSettings __Gen_Wrap_137(System.Object P0) { }
        private BeyondDynamicBone.NormalAlignmentSettings __Gen_Wrap_138(System.Object P0) { }
        private BeyondDynamicBone.CullingSettings __Gen_Wrap_139(System.Object P0) { }
        private BeyondDynamicBone.CurveSerializeData __Gen_Wrap_140(System.Object P0) { }
        private BeyondDynamicBone.InertiaConstraint.SerializeData __Gen_Wrap_141(System.Object P0) { }
        private BeyondDynamicBone.TetherConstraint.SerializeData __Gen_Wrap_142(System.Object P0) { }
        private BeyondDynamicBone.DistanceConstraint.SerializeData __Gen_Wrap_143(System.Object P0) { }
        private BeyondDynamicBone.TriangleBendingConstraint.SerializeData __Gen_Wrap_144(System.Object P0) { }
        private BeyondDynamicBone.AngleConstraint.RestorationSerializeData __Gen_Wrap_145(System.Object P0) { }
        private BeyondDynamicBone.AngleConstraint.LimitSerializeData __Gen_Wrap_146(System.Object P0) { }
        private BeyondDynamicBone.MotionConstraint.SerializeData __Gen_Wrap_147(System.Object P0) { }
        private BeyondDynamicBone.ColliderCollisionConstraint.SerializeData __Gen_Wrap_148(System.Object P0) { }
        private BeyondDynamicBone.SelfCollisionConstraint.SerializeData __Gen_Wrap_149(System.Object P0) { }
        private BeyondDynamicBone.WindSettings __Gen_Wrap_150(System.Object P0) { }
        private System.Void __Gen_Wrap_151(System.Object P0, System.Object P1, System.Boolean P2) { }
        private BeyondDynamicBone.ColliderManager.ColliderType __Gen_Wrap_152(System.Object P0) { }
        private System.Void __Gen_Wrap_153(System.Object P0, UnityEngine.Vector3 P1) { }
        private System.Void __Gen_Wrap_154(System.Object P0, System.Single P1, System.Single P2, System.Single P3) { }
        private BeyondDynamicBone.ClothProcess __Gen_Wrap_155(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_156(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_157(System.Object P0, Unity.Jobs.JobHandle P1) { }
        private System.Void __Gen_Wrap_158(BeyondDynamicBone.AngleConstraint.AngleConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Boolean __Gen_Wrap_159(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, System.Single P2, Unity.Mathematics.float3& P3) { }
        private Unity.Mathematics.quaternion __Gen_Wrap_160(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, System.Single P2) { }
        private System.Void __Gen_Wrap_161(BeyondDynamicBone.AngleConstraint.AngleConstraintJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_162(BeyondDynamicBone.AngleConstraint.AngleConstraintJob& P0) { }
        private System.Single __Gen_Wrap_163(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, System.Single P2, BeyondDynamicBone.AABB& P3, BeyondDynamicBone.ColliderManager.WorkData& P4, System.Boolean P5, System.Single P6, Unity.Mathematics.float3& P7) { }
        private System.Single __Gen_Wrap_164(Unity.Mathematics.float3& P0, System.Single P1, BeyondDynamicBone.ColliderManager.WorkData& P2, Unity.Mathematics.float3& P3) { }
        private System.Single __Gen_Wrap_165(Unity.Mathematics.float3& P0, System.Single P1, BeyondDynamicBone.AABB& P2, BeyondDynamicBone.ColliderManager.WorkData& P3, Unity.Mathematics.float3& P4) { }
        private System.Single __Gen_Wrap_166(Unity.Mathematics.float3x2& P0, Unity.Mathematics.float2& P1, BeyondDynamicBone.AABB& P2, System.Single P3, BeyondDynamicBone.ColliderManager.WorkData& P4, Unity.Mathematics.float3& P5) { }
        private System.Single __Gen_Wrap_167(Unity.Mathematics.float3x2& P0, Unity.Mathematics.float2& P1, BeyondDynamicBone.ColliderManager.WorkData& P2, Unity.Mathematics.float3& P3) { }
        private System.Void __Gen_Wrap_168(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Single __Gen_Wrap_169(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3& P2, System.Single P3, BeyondDynamicBone.AABB& P4, BeyondDynamicBone.ColliderManager.WorkData& P5, System.Boolean P6, System.Single P7, Unity.Mathematics.float3& P8) { }
        private System.Single __Gen_Wrap_170(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, Unity.Mathematics.float3& P1, System.Single P2, BeyondDynamicBone.AABB& P3, BeyondDynamicBone.ColliderManager.WorkData& P4, Unity.Mathematics.float3& P5) { }
        private System.Single __Gen_Wrap_171(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, Unity.Mathematics.float3& P1, System.Single P2, BeyondDynamicBone.ColliderManager.WorkData& P3, Unity.Mathematics.float3& P4) { }
        private System.Void __Gen_Wrap_172(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_173(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0) { }
        private System.Void __Gen_Wrap_174(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Single __Gen_Wrap_175(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0, Unity.Mathematics.float3x2& P1, Unity.Mathematics.float2& P2, BeyondDynamicBone.AABB& P3, System.Single P4, BeyondDynamicBone.ColliderManager.WorkData& P5, Unity.Mathematics.float3& P6) { }
        private System.Single __Gen_Wrap_176(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0, Unity.Mathematics.float3x2& P1, Unity.Mathematics.float2& P2, BeyondDynamicBone.ColliderManager.WorkData& P3, Unity.Mathematics.float3& P4) { }
        private System.Void __Gen_Wrap_177(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_178(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0) { }
        private System.Void __Gen_Wrap_179(BeyondDynamicBone.ColliderCollisionConstraint.SolveEdgeBufferAndClearJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private Unity.Mathematics.float3 __Gen_Wrap_180(System.Int32 P0, Unity.Collections.NativeArray<System.Int32>& P1, Unity.Collections.NativeArray<System.Int32>& P2) { }
        private System.Single __Gen_Wrap_181(System.Int32 P0, Unity.Collections.NativeArray<System.Int32>& P1) { }
        private Unity.Mathematics.float3 __Gen_Wrap_182(System.Int32 P0, Unity.Collections.NativeArray<System.Int32>& P1) { }
        private System.Void __Gen_Wrap_183(BeyondDynamicBone.ColliderCollisionConstraint.SolveEdgeBufferAndClearJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_184(BeyondDynamicBone.ColliderCollisionConstraint.SolveEdgeBufferAndClearJob& P0) { }
        private System.Void __Gen_Wrap_185(BeyondDynamicBone.DistanceConstraint.DistanceConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_186(BeyondDynamicBone.DistanceConstraint.DistanceConstraintJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_187(BeyondDynamicBone.DistanceConstraint.DistanceConstraintJob& P0) { }
        private System.Void __Gen_Wrap_188(BeyondDynamicBone.MotionConstraint.MotionConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_189(BeyondDynamicBone.MotionConstraint.MotionConstraintJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_190(BeyondDynamicBone.MotionConstraint.MotionConstraintJob& P0) { }
        private System.Int32 __Gen_Wrap_191(Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>& P0, BeyondDynamicBone.SelfCollisionConstraint.SortData& P1, BeyondDynamicBone.DataChunk& P2) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_192(Unity.Collections.NativeArray<System.Int32>& P0, Unity.Collections.NativeReference<System.Int32>& P1, System.Single P2, Unity.Jobs.JobHandle P3) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_193(BeyondDynamicBone.ExProcessingList<System.Int32>& P0, System.Single P1, Unity.Jobs.JobHandle P2) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_194(System.Object P0, System.Int32 P1, Unity.Jobs.JobHandle P2) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_195(Unity.Collections.NativeArray<System.Byte> P0, System.Int32 P1, System.Byte P2, Unity.Jobs.JobHandle P3) { }
        private System.Int32 __Gen_Wrap_196(BeyondDynamicBone.SelfCollisionConstraint.SortData& P0, BeyondDynamicBone.SelfCollisionConstraint.SortData P1) { }
        private System.String __Gen_Wrap_197(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact& P0) { }
        private System.String __Gen_Wrap_198(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact& P0) { }
        private System.Void __Gen_Wrap_199(BeyondDynamicBone.SelfCollisionConstraint.InitPrimitiveJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_200(BeyondDynamicBone.SelfCollisionConstraint.ClearBufferJob& P0) { }
        private System.Void __Gen_Wrap_201(BeyondDynamicBone.SelfCollisionConstraint.UpdatePrimitiveJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_202(BeyondDynamicBone.SelfCollisionConstraint.UpdatePrimitiveJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_203(BeyondDynamicBone.SelfCollisionConstraint.UpdatePrimitiveJob& P0) { }
        private System.Void __Gen_Wrap_204(BeyondDynamicBone.SelfCollisionConstraint.SortJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_205(BeyondDynamicBone.SelfCollisionConstraint.SortJob& P0) { }
        private System.Void __Gen_Wrap_206(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_207(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2, System.Single P3, System.Single P4, System.Single P5) { }
        private System.Void __Gen_Wrap_208(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0, System.Int32 P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2, BeyondDynamicBone.SelfCollisionConstraint.SortData& P3, BeyondDynamicBone.DataChunk& P4, System.Boolean P5) { }
        private System.Void __Gen_Wrap_209(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_210(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0) { }
        private System.Void __Gen_Wrap_211(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_212(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2, System.Single P3, System.Single P4) { }
        private System.Void __Gen_Wrap_213(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0, System.Int32 P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2, BeyondDynamicBone.SelfCollisionConstraint.SortData& P3, BeyondDynamicBone.DataChunk& P4, System.Boolean P5) { }
        private System.Void __Gen_Wrap_214(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_215(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0) { }
        private System.Void __Gen_Wrap_216(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeToListJob& P0) { }
        private System.Void __Gen_Wrap_217(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleToListJob& P0) { }
        private System.Void __Gen_Wrap_218(BeyondDynamicBone.SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_219(BeyondDynamicBone.SelfCollisionConstraint.UpdatePointTriangleBroadPhaseJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_220(BeyondDynamicBone.SelfCollisionConstraint.SolverEdgeEdgeJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_221(BeyondDynamicBone.SelfCollisionConstraint.SolverPointTriangleJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_222(BeyondDynamicBone.SelfCollisionConstraint.IntersectUpdatePrimitiveJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_223(BeyondDynamicBone.SelfCollisionConstraint.IntersectUpdatePrimitiveJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_224(BeyondDynamicBone.SelfCollisionConstraint.IntersectUpdatePrimitiveJob& P0) { }
        private System.Void __Gen_Wrap_225(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_226(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2) { }
        private System.Void __Gen_Wrap_227(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P1, BeyondDynamicBone.SelfCollisionConstraint.SortData& P2, BeyondDynamicBone.DataChunk& P3, System.Boolean P4) { }
        private System.Void __Gen_Wrap_228(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_229(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0) { }
        private System.Void __Gen_Wrap_230(BeyondDynamicBone.SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_231(BeyondDynamicBone.SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob& P0) { }
        private System.Void __Gen_Wrap_232(BeyondDynamicBone.SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_233(BeyondDynamicBone.SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob& P0) { }
        private System.Void __Gen_Wrap_234(BeyondDynamicBone.SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_235(BeyondDynamicBone.SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob& P0) { }
        private System.Void __Gen_Wrap_236(BeyondDynamicBone.SelfCollisionConstraint.SolverPointTriangleCrossFrameJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_237(BeyondDynamicBone.SelfCollisionConstraint.SolverPointTriangleCrossFrameJob& P0) { }
        private BeyondDynamicBone.SpringConstraint.SerializeData __Gen_Wrap_238(System.Object P0) { }
        private System.Void __Gen_Wrap_239(BeyondDynamicBone.TetherConstraint.TethreConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_240(BeyondDynamicBone.TetherConstraint.TethreConstraintJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_241(BeyondDynamicBone.TetherConstraint.TethreConstraintJob& P0) { }
        private System.Boolean __Gen_Wrap_242(Unity.Mathematics.float3x4& P0, Unity.Mathematics.float4& P1, System.Single P2, System.Single P3, Unity.Mathematics.float3x4& P4) { }
        private System.Boolean __Gen_Wrap_243(System.Single P0, Unity.Mathematics.float3x4& P1, Unity.Mathematics.float4& P2, System.Single P3, System.Single P4, Unity.Mathematics.float3x4& P5) { }
        private System.Void __Gen_Wrap_244(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Boolean __Gen_Wrap_245(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0, Unity.Mathematics.float3x4& P1, Unity.Mathematics.float4& P2, System.Single P3, System.Single P4, Unity.Mathematics.float3x4& P5) { }
        private System.Boolean __Gen_Wrap_246(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0, System.Single P1, Unity.Mathematics.float3x4& P2, Unity.Mathematics.float4& P3, System.Single P4, System.Single P5, Unity.Mathematics.float3x4& P6) { }
        private System.Void __Gen_Wrap_247(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_248(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0) { }
        private System.Void __Gen_Wrap_249(BeyondDynamicBone.TriangleBendingConstraint.SolveAggregateBufferJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_250(BeyondDynamicBone.TriangleBendingConstraint.SolveAggregateBufferJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_251(BeyondDynamicBone.TriangleBendingConstraint.SolveAggregateBufferJob& P0) { }
        private System.Void __Gen_Wrap_252(System.Object P0, System.Single P1, System.Single P2, System.Single P3, System.Boolean P4) { }
        private System.Void __Gen_Wrap_253(System.Object P0, System.Single P1, System.Object P2) { }
        private Unity.Collections.NativeArray<Unity.Mathematics.float3> __Gen_Wrap_254(System.Object P0, Unity.Mathematics.float4x4 P1) { }
        private System.Void __Gen_Wrap_255(BeyondDynamicBone.SelectionData.TransformPositionJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_256(BeyondDynamicBone.SelectionData.CreateGridMapJob& P0) { }
        private System.Void __Gen_Wrap_257(BeyondDynamicBone.SelectionData.ConvertSelectionJob& P0, System.Int32 P1) { }
        private UnityEngine.Vector3 __Gen_Wrap_258(System.Object P0, System.Boolean P1) { }
        private System.Void __Gen_Wrap_259(System.Object P0, UnityEngine.Vector3 P1, System.Boolean P2) { }
        private System.Boolean __Gen_Wrap_260(BeyondDynamicBone.WindParams& P0) { }
        private System.Boolean __Gen_Wrap_261(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Boolean __Gen_Wrap_262(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3) { }
        private System.Void __Gen_Wrap_263(System.Object P0, System.Object P1, UnityEngine.Jobs.TransformAccessArray P2) { }
        private BeyondDynamicBone.DataChunk __Gen_Wrap_264(System.Object P0, BeyondDynamicBone.DataChunk P1, System.Int32 P2) { }
        private System.Single __Gen_Wrap_265() { }
        private Unity.Jobs.JobHandle __Gen_Wrap_266(System.Object P0, Unity.Jobs.JobHandle P1, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& P2, Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>& P3, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& P4) { }
        private System.Void __Gen_Wrap_267(BeyondDynamicBone.DynamicBoneTransformManager.ValidTransformJob& P0, System.Int32 P1) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_268(System.Object P0, System.Int32 P1, System.Int32 P2, Unity.Jobs.JobHandle P3) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_269(System.Object P0, System.Boolean P1, BeyondDynamicBone.DataChunk P2, Unity.Jobs.JobHandle P3) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_270(System.Object P0, BeyondDynamicBone.DataChunk P1, Unity.Jobs.JobHandle P2) { }
        private BeyondDynamicBone.VirtualMeshContainer __Gen_Wrap_271(System.Object P0) { }
        private BeyondDynamicBone.VirtualMeshContainer __Gen_Wrap_272(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_273(BeyondDynamicBone.DoAllInOneJob& P0) { }
        private System.Void __Gen_Wrap_274(BeyondDynamicBone.DynamicBoneTransformManager.ReadAnimatorBufferDataJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2) { }
        private System.Void __Gen_Wrap_275(BeyondDynamicBone.DynamicBoneTransformManager.WriteAnimatorBufferDataJob& P0) { }
        private System.Void __Gen_Wrap_276(BeyondDynamicBone.DynamicBoneTransformManager.CopyDoubleBufferJob& P0) { }
        private System.Void __Gen_Wrap_277(BeyondDynamicBone.DynamicBoneTransformManager.EnableTransformJob& P0) { }
        private System.Void __Gen_Wrap_278(BeyondDynamicBone.DynamicBoneTransformManager.RestoreTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2) { }
        private System.Void __Gen_Wrap_279(BeyondDynamicBone.DynamicBoneTransformManager.ReadTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2) { }
        private System.Void __Gen_Wrap_280(BeyondDynamicBone.DynamicBoneTransformManager.ValidTransformJob& P0) { }
        private System.Void __Gen_Wrap_281(BeyondDynamicBone.DynamicBoneTransformManager.WriteTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2) { }
        private System.Void __Gen_Wrap_282(BeyondDynamicBone.DynamicBoneTransformManager.ReadComponentTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2) { }
        private System.Void __Gen_Wrap_283(BeyondDynamicBone.ClothProcess P0) { }
        private System.String __Gen_Wrap_284(BeyondDynamicBone.TeamWindInfo& P0) { }
        private System.Boolean __Gen_Wrap_285(BeyondDynamicBone.TeamManager.MappingData& P0) { }
        private System.Void __Gen_Wrap_286(BeyondDynamicBone.TeamManager.AlwaysTeamUpdatePreJob& P0) { }
        private System.Void __Gen_Wrap_287(BeyondDynamicBone.TeamManager.AlwaysTeamUpdatePostJob& P0, System.Int32 P1, BeyondDynamicBone.TeamManager.TeamData& P2) { }
        private System.Void __Gen_Wrap_288(BeyondDynamicBone.TeamManager.AlwaysTeamUpdatePostJob& P0) { }
        private System.Void __Gen_Wrap_289(BeyondDynamicBone.TeamManager.CalcCenterAndInertiaAndWindJob& P0, System.Int32 P1) { }
        private Unity.Mathematics.float3 __Gen_Wrap_290(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3& P2, Unity.Mathematics.quaternion& P3) { }
        private System.Boolean __Gen_Wrap_291(BeyondDynamicBone.WindManager.WindData& P0) { }
        private System.Boolean __Gen_Wrap_292(BeyondDynamicBone.TeamWindInfo& P0) { }
        private System.Int32 __Gen_Wrap_293(BeyondDynamicBone.TeamWindData& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_294(BeyondDynamicBone.TeamWindData& P0, BeyondDynamicBone.TeamWindInfo P1, BeyondDynamicBone.TeamWindData& P2) { }
        private System.Void __Gen_Wrap_295(BeyondDynamicBone.TeamWindData& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_296(BeyondDynamicBone.TeamManager.CalcCenterAndInertiaAndWindJob& P0, System.Int32 P1, BeyondDynamicBone.ClothParameters& P2, Unity.Mathematics.float3& P3) { }
        private System.Void __Gen_Wrap_297(BeyondDynamicBone.TeamManager.CalcCenterAndInertiaAndWindJob& P0) { }
        private System.Void __Gen_Wrap_298(BeyondDynamicBone.TeamManager.SimulationStepTeamUpdateJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_299(BeyondDynamicBone.TeamManager.SimulationStepTeamUpdateJob& P0, BeyondDynamicBone.TeamWindInfo& P1, System.Single P2, System.Single P3) { }
        private System.Void __Gen_Wrap_300(BeyondDynamicBone.TeamManager.SimulationStepTeamUpdateJob& P0, System.Int32 P1, BeyondDynamicBone.TeamManager.TeamData& P2, BeyondDynamicBone.WindParams& P3, BeyondDynamicBone.InertiaConstraint.CenterData& P4) { }
        private System.Void __Gen_Wrap_301(BeyondDynamicBone.TeamManager.SimulationStepTeamUpdateJob& P0) { }
        private System.Void __Gen_Wrap_302(BeyondDynamicBone.TeamManager.PostTeamUpdateJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_303(BeyondDynamicBone.TeamManager.PostTeamUpdateJob& P0) { }
        private System.Void __Gen_Wrap_304(BeyondDynamicBone.VirtualMeshManager.ClearProxyMeshUpdateBufferJob& P0) { }
        private System.Void __Gen_Wrap_305(BeyondDynamicBone.VirtualMeshManager.CreateProxyMeshUpdateVertexList& P0, System.Int32 P1) { }
        private System.Int32 __Gen_Wrap_306(Unity.Collections.NativeReference<System.Int32>& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_307(BeyondDynamicBone.VirtualMeshManager.CreateProxyMeshUpdateVertexList& P0) { }
        private System.Void __Gen_Wrap_308(BeyondDynamicBone.VirtualMeshManager.CalcProxyMeshSkinningJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Int32 __Gen_Wrap_309(BeyondDynamicBone.VirtualMeshBoneWeight& P0) { }
        private System.Void __Gen_Wrap_310(BeyondDynamicBone.VirtualMeshManager.CalcProxyMeshSkinningJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_311(BeyondDynamicBone.VirtualMeshManager.CalcProxyMeshSkinningJob& P0) { }
        private System.Void __Gen_Wrap_312(BeyondDynamicBone.VirtualMeshManager.CreatePostProxyMeshUpdateListJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_313(BeyondDynamicBone.VirtualMeshManager.CreatePostProxyMeshUpdateListJob& P0) { }
        private System.Void __Gen_Wrap_314(BeyondDynamicBone.VirtualMeshManager.CalcLineNormalTangentJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_315(BeyondDynamicBone.VirtualMeshManager.CalcLineNormalTangentJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_316(BeyondDynamicBone.VirtualMeshManager.CalcLineNormalTangentJob& P0) { }
        private System.Void __Gen_Wrap_317(BeyondDynamicBone.VirtualMeshManager.CalcTriangleNormalTangentJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private Unity.Mathematics.float3 __Gen_Wrap_318(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3& P2, Unity.Mathematics.float2& P3, Unity.Mathematics.float2& P4, Unity.Mathematics.float2& P5) { }
        private System.Void __Gen_Wrap_319(BeyondDynamicBone.VirtualMeshManager.CalcTriangleNormalTangentJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_320(BeyondDynamicBone.VirtualMeshManager.CalcTriangleNormalTangentJob& P0) { }
        private System.Void __Gen_Wrap_321(BeyondDynamicBone.VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_322(BeyondDynamicBone.VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_323(BeyondDynamicBone.VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob& P0) { }
        private System.Void __Gen_Wrap_324(BeyondDynamicBone.VirtualMeshManager.WriteTransformDataJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_325(BeyondDynamicBone.VirtualMeshManager.WriteTransformDataJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_326(BeyondDynamicBone.VirtualMeshManager.WriteTransformDataJob& P0) { }
        private System.Void __Gen_Wrap_327(BeyondDynamicBone.VirtualMeshManager.WriteTransformLocalDataJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_328(BeyondDynamicBone.VirtualMeshManager.WriteTransformLocalDataJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_329(BeyondDynamicBone.VirtualMeshManager.WriteTransformLocalDataJob& P0) { }
        private System.Void __Gen_Wrap_330(BeyondDynamicBone.VirtualMeshManager.CalcMeshConvertMatrixJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_331(BeyondDynamicBone.VirtualMeshManager.CalcMeshConvertMatrixJob& P0) { }
        private System.Void __Gen_Wrap_332(BeyondDynamicBone.VirtualMeshManager.CalcProxySkinningJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_333(BeyondDynamicBone.VirtualMeshManager.CalcProxySkinningJob& P0) { }
        private System.Boolean __Gen_Wrap_334(UnityEngine.LowLevel.PlayerLoopSystem P0) { }
        private System.Boolean __Gen_Wrap_335(UnityEngine.LowLevel.PlayerLoopSystem& P0) { }
        private System.Void __Gen_Wrap_336(UnityEngine.LowLevel.PlayerLoopSystem P0, UnityEngine.LowLevel.PlayerLoopSystem& P1, System.Object P2, System.Object P3, System.Boolean P4, System.Boolean P5) { }
        private System.Void __Gen_Wrap_337(UnityEngine.LowLevel.PlayerLoopSystem& P0) { }
        private System.Void __Gen_Wrap_338(System.Boolean P0) { }
        private System.Void __Gen_Wrap_339(System.Single P0) { }
        private System.Void __Gen_Wrap_340(System.Boolean P0, System.Single P1) { }
        private System.Int32 __Gen_Wrap_341() { }
        private System.Void __Gen_Wrap_342(BeyondDynamicBone.TimeManager.UpdateLocation P0) { }
        private BeyondDynamicBone.TimeManager.UpdateLocation __Gen_Wrap_343() { }
        private System.Void __Gen_Wrap_344(BeyondDynamicBone.MagicaManager.InitializationLocation P0) { }
        private System.Void __Gen_Wrap_345(BeyondDynamicBone.RenderData.UpdatePositionNormalJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_346(BeyondDynamicBone.RenderData.UpdatePositionNormalJob& P0) { }
        private System.Void __Gen_Wrap_347(BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_348(BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob& P0) { }
        private System.Void __Gen_Wrap_349(BeyondDynamicBone.RenderData.UpdateBoneWeightJob2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_350(BeyondDynamicBone.RenderData.UpdateBoneWeightJob2& P0) { }
        private BeyondDynamicBone.RenderSetupData.ShareSerializationData __Gen_Wrap_351(System.Object P0) { }
        private BeyondDynamicBone.RenderSetupData.UniqueSerializationData __Gen_Wrap_352(System.Object P0) { }
        private System.Void __Gen_Wrap_353(BeyondDynamicBone.RenderSetupData.VertexWeight5BoneCheckJob& P0) { }
        private System.Void __Gen_Wrap_354(BeyondDynamicBone.RenderSetupData.ReadTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2) { }
        private System.Void __Gen_Wrap_355(BeyondDynamicBone.RenderSetupData.GetBoneWeightJos& P0) { }
        private System.Void __Gen_Wrap_356(BeyondDynamicBone.ColliderManager.PreSimulationUpdateJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_357(BeyondDynamicBone.ColliderManager.PreSimulationUpdateJob& P0) { }
        private System.Void __Gen_Wrap_358(BeyondDynamicBone.ColliderManager.CreateUpdatecolliderListJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_359(BeyondDynamicBone.ColliderManager.CreateUpdatecolliderListJob& P0) { }
        private System.Void __Gen_Wrap_360(BeyondDynamicBone.ColliderManager.StartSimulationStepJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_361(BeyondDynamicBone.ColliderManager.StartSimulationStepJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_362(BeyondDynamicBone.ColliderManager.StartSimulationStepJob& P0) { }
        private System.Void __Gen_Wrap_363(BeyondDynamicBone.ColliderManager.EndSimulationStepJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_364(BeyondDynamicBone.ColliderManager.EndSimulationStepJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_365(BeyondDynamicBone.ColliderManager.EndSimulationStepJob& P0) { }
        private System.Void __Gen_Wrap_366(BeyondDynamicBone.ColliderManager.PostSimulationUpdateJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_367(BeyondDynamicBone.ColliderManager.PostSimulationUpdateJob& P0) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_368(System.Object P0, Unity.Collections.NativeList<System.Int32>& P1, Unity.Jobs.JobHandle P2) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_369(System.Object P0, Unity.Collections.NativeArray<System.Int32>& P1, Unity.Collections.NativeReference<System.Int32>& P2, Unity.Jobs.JobHandle P3) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_370(System.Object P0, BeyondDynamicBone.ExProcessingList<System.Int32>& P1, Unity.Jobs.JobHandle P2) { }
        private System.Void __Gen_Wrap_371(BeyondDynamicBone.SimulationManager.PreSimulationUpdateJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_372(BeyondDynamicBone.SimulationManager.PreSimulationUpdateJob& P0) { }
        private System.Void __Gen_Wrap_373(BeyondDynamicBone.SimulationManager.ClearStepCounter& P0) { }
        private System.Void __Gen_Wrap_374(BeyondDynamicBone.SimulationManager.CreateUpdateParticleList& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_375(BeyondDynamicBone.SimulationManager.CreateUpdateParticleList& P0) { }
        private System.Void __Gen_Wrap_376(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_377(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, BeyondDynamicBone.TeamWindInfo& P1, BeyondDynamicBone.WindParams& P2, Unity.Mathematics.float3& P3, System.Single P4, Unity.Mathematics.float3& P5) { }
        private System.Void __Gen_Wrap_378(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, System.Int32 P1, BeyondDynamicBone.TeamManager.TeamData& P2, BeyondDynamicBone.WindParams& P3, BeyondDynamicBone.InertiaConstraint.CenterData& P4, System.Int32 P5, System.Int32 P6, System.Single P7, Unity.Mathematics.float3& P8) { }
        private System.Void __Gen_Wrap_379(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, BeyondDynamicBone.SpringConstraint.SpringConstraintParams& P1, BeyondDynamicBone.ClothNormalAxis P2, Unity.Mathematics.float3& P3, Unity.Mathematics.float3& P4, Unity.Mathematics.quaternion& P5, System.Single P6, System.Single P7) { }
        private System.Void __Gen_Wrap_380(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_381(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0) { }
        private System.Void __Gen_Wrap_382(BeyondDynamicBone.SimulationManager.UpdateStepBasicPotureJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_383(BeyondDynamicBone.SimulationManager.UpdateStepBasicPotureJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_384(BeyondDynamicBone.SimulationManager.UpdateStepBasicPotureJob& P0) { }
        private System.Void __Gen_Wrap_385(BeyondDynamicBone.SimulationManager.EndSimulationStepJob& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_386(BeyondDynamicBone.SimulationManager.EndSimulationStepJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_387(BeyondDynamicBone.SimulationManager.EndSimulationStepJob& P0) { }
        private System.Void __Gen_Wrap_388(BeyondDynamicBone.SimulationManager.CalcDisplayPositionJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_389(BeyondDynamicBone.SimulationManager.CalcDisplayPositionJob& P0) { }
        private System.Void __Gen_Wrap_390(BeyondDynamicBone.SimulationManager.FeedbackTempPosJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_391(BeyondDynamicBone.SimulationManager.FeedbackTempPosJob2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_392(BeyondDynamicBone.TeamWindInfo& P0) { }
        private System.Void __Gen_Wrap_393(BeyondDynamicBone.TeamWindData& P0) { }
        private System.Int32 __Gen_Wrap_394(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Byte P4, System.Boolean P5) { }
        private System.Int32[] __Gen_Wrap_395(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Int32 P4) { }
        private System.Int32[] __Gen_Wrap_396(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.Int32 __Gen_Wrap_397(System.Object P0, System.Int32 P1, System.Object P2, System.Int32 P3, System.Int32 P4, System.Byte P5) { }
        private Unity.Mathematics.float4x4 __Gen_Wrap_398(System.Object P0, System.Int32 P1) { }
        private BeyondDynamicBone.TransformData.ShareSerializationData __Gen_Wrap_399(System.Object P0) { }
        private BeyondDynamicBone.TransformData.UniqueSerializationData __Gen_Wrap_400(System.Object P0) { }
        private System.Void __Gen_Wrap_401(BeyondDynamicBone.TransformData.RestoreTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2) { }
        private System.Void __Gen_Wrap_402(BeyondDynamicBone.TransformData.ReadTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2) { }
        private UnityEngine.Vector3 __Gen_Wrap_403(System.Object P0, UnityEngine.Vector3 P1) { }
        private BeyondDynamicBone.SharePreBuildData __Gen_Wrap_404(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_405(BeyondDynamicBone.SharePreBuildData P0) { }
        private System.Void __Gen_Wrap_406(BeyondDynamicBone.SharePreBuildData P0) { }
        private System.String __Gen_Wrap_407() { }
        private System.Void __Gen_Wrap_408(BeyondDynamicBone.SameDistanceReduction.InitGridJob& P0) { }
        private System.Void __Gen_Wrap_409(BeyondDynamicBone.SameDistanceReduction.SearchJoinJob& P0) { }
        private System.Void __Gen_Wrap_410(BeyondDynamicBone.VirtualMeshBoneWeight& P0, System.Int32 P1, System.Single P2) { }
        private System.Void __Gen_Wrap_411(BeyondDynamicBone.VirtualMeshBoneWeight& P0, BeyondDynamicBone.VirtualMeshBoneWeight& P1) { }
        private System.Void __Gen_Wrap_412(BeyondDynamicBone.SameDistanceReduction.JoinJob2& P0) { }
        private System.Void __Gen_Wrap_413(BeyondDynamicBone.SameDistanceReduction.UpdateJoinIndexJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_414(BeyondDynamicBone.SameDistanceReduction.UpdateLinkIndexJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_415(BeyondDynamicBone.VirtualMeshBoneWeight& P0) { }
        private System.Void __Gen_Wrap_416(BeyondDynamicBone.SameDistanceReduction.FinalMergeVertexJob& P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_417(Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>& P0, System.Int32 P1, System.Int32 P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_418(BeyondDynamicBone.ShapeDistanceReduction.SearchJoinEdgeJob& P0) { }
        private System.Void __Gen_Wrap_419(BeyondDynamicBone.SimpleDistanceReduction.InitGridJob& P0) { }
        private System.Void __Gen_Wrap_420(BeyondDynamicBone.SimpleDistanceReduction.SearchJoinEdgeJob& P0) { }
        private System.Boolean __Gen_Wrap_421(Unity.Collections.NativeArray<Unity.Collections.FixedList128Bytes<System.UInt16>>& P0, System.Int32 P1, System.Int32 P2, Unity.Collections.FixedList128Bytes<System.UInt16>& P3, Unity.Collections.FixedList128Bytes<System.UInt16>& P4, System.Boolean P5) { }
        private System.Boolean __Gen_Wrap_422(BeyondDynamicBone.StepReductionBase.JoinEdge& P0, Unity.Mathematics.int2& P1) { }
        private System.Int32 __Gen_Wrap_423(BeyondDynamicBone.StepReductionBase.JoinEdge& P0, BeyondDynamicBone.StepReductionBase.JoinEdge P1) { }
        private System.Void __Gen_Wrap_424(BeyondDynamicBone.StepReductionBase.DeterminJoinEdgeJob& P0) { }
        private System.Void __Gen_Wrap_425(BeyondDynamicBone.StepReductionBase.JoinPairJob& P0) { }
        private System.Void __Gen_Wrap_426(BeyondDynamicBone.StepReductionBase.UpdateJoinIndexJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_427(BeyondDynamicBone.StepReductionBase.UpdateLinkIndexJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_428(BeyondDynamicBone.StepReductionBase.FinalMergeVertexJob& P0, System.Int32 P1) { }
        private Unity.Mathematics.int3 __Gen_Wrap_429(Unity.Mathematics.int3& P0) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_430(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, Unity.Jobs.JobHandle P4) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_431(Unity.Collections.NativeReference<System.Int32> P0, System.Int32 P1, Unity.Jobs.JobHandle P2) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_432(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1, Unity.Jobs.JobHandle P2) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_433(Unity.Collections.NativeParallelHashSet<System.Int32> P0, Unity.Collections.NativeList<System.Int32> P1, Unity.Jobs.JobHandle P2) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_434(Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2> P0, Unity.Collections.NativeList<Unity.Mathematics.int2> P1, Unity.Jobs.JobHandle P2) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_435(Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int4> P0, Unity.Collections.NativeList<Unity.Mathematics.int4> P1, Unity.Jobs.JobHandle P2) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_436(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P2, Unity.Jobs.JobHandle P3) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_437(Unity.Collections.NativeList<Unity.Mathematics.float3> P0, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P1, Unity.Jobs.JobHandle P2) { }
        private System.Void __Gen_Wrap_438(Unity.Collections.NativeList<Unity.Mathematics.float3> P0, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P1) { }
        private BeyondDynamicBone.AABB __Gen_Wrap_439(Unity.Collections.NativeArray<Unity.Mathematics.float3>& P0, System.Int32 P1) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_440(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P2, Unity.Collections.NativeArray<Unity.Mathematics.float2> P3, Unity.Jobs.JobHandle P4) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_441(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Mathematics.float4x4& P2, Unity.Jobs.JobHandle P3) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_442(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, Unity.Collections.NativeArray<Unity.Mathematics.float3> P1, System.Int32 P2, Unity.Mathematics.float4x4& P3, Unity.Jobs.JobHandle P4) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_443(Unity.Collections.NativeReference<System.Int32> P0, Unity.Jobs.JobHandle P1) { }
        private System.Void __Gen_Wrap_444(BeyondDynamicBone.ClothJobUtility.SerialNumberJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_445(BeyondDynamicBone.ClothJobUtility.CalcAABBJob& P0) { }
        private System.Void __Gen_Wrap_446(BeyondDynamicBone.ClothJobUtility.CalcAABBDeferJob& P0) { }
        private System.Void __Gen_Wrap_447(BeyondDynamicBone.ClothJobUtility.CalcUVJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_448(BeyondDynamicBone.ClothJobUtility.AddIntDataCopyJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_449(BeyondDynamicBone.ClothJobUtility.AddInt2DataCopyJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_450(BeyondDynamicBone.ClothJobUtility.AddInt3DataCopyJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_451(BeyondDynamicBone.ClothJobUtility.TransformPositionJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_452(BeyondDynamicBone.ClothJobUtility.TransformPositionJob2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_453(BeyondDynamicBone.ClothJobUtility.ClearReferenceJob& P0) { }
        private Unity.Jobs.JobHandle __Gen_Wrap_454(Unity.Collections.NativeList<System.Int32>& P0, System.Single P1, Unity.Jobs.JobHandle P2) { }
        private System.Void __Gen_Wrap_455(BeyondDynamicBone.InterlockUtility.AggregateJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_456(BeyondDynamicBone.InterlockUtility.AggregateJob& P0) { }
        private System.Void __Gen_Wrap_457(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_458(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob& P0) { }
        private System.Void __Gen_Wrap_459(BeyondDynamicBone.InterlockUtility.AggregateJob2& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_460(BeyondDynamicBone.InterlockUtility.AggregateJob2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_461(BeyondDynamicBone.InterlockUtility.AggregateJob2& P0) { }
        private System.Void __Gen_Wrap_462(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob2& P0, Unity.Collections.NativeReference<System.Int32> P1) { }
        private System.Void __Gen_Wrap_463(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_464(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob2& P0) { }
        private System.Void __Gen_Wrap_465(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityCrossFrameJob2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_466(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityCrossFrameJob2& P0) { }
        private System.Void __Gen_Wrap_467(BeyondDynamicBone.InterlockUtility.AggregateCrossFrameJob2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_468(BeyondDynamicBone.InterlockUtility.AggregateCrossFrameJob2& P0) { }
        private System.String __Gen_Wrap_469(BeyondDynamicBone.AABB& P0) { }
        private System.Void __Gen_Wrap_470(Unity.Mathematics.float3 P0, Unity.Mathematics.quaternion P1, Unity.Mathematics.float3 P2, Unity.Mathematics.quaternion P3, Unity.Mathematics.float3& P4, Unity.Mathematics.quaternion& P5) { }
        private Unity.Mathematics.int2 __Gen_Wrap_471(Unity.Mathematics.int3 P0, Unity.Mathematics.int3 P1) { }
        private Unity.Mathematics.int4 __Gen_Wrap_472(Unity.Mathematics.int3 P0, Unity.Mathematics.int3 P1) { }
        private System.Boolean __Gen_Wrap_473(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3 P2, Unity.Mathematics.float3 P3, Unity.Mathematics.float3 P4, System.Boolean P5, System.Single& P6, System.Single& P7, System.Single& P8, System.Single& P9) { }
        private System.Boolean __Gen_Wrap_474(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3 P2, Unity.Mathematics.float3 P3, Unity.Mathematics.float3 P4) { }
        private System.Single __Gen_Wrap_475(UnityEngine.Vector3 P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2) { }
        private BeyondDynamicBone.FTransform __Gen_Wrap_476() { }
        private UnityEngine.Mesh __Gen_Wrap_477(System.Object P0) { }
        private System.Text.StringBuilder __Gen_Wrap_478(System.Object P0) { }
        private System.Text.StringBuilder __Gen_Wrap_479() { }
        private System.String __Gen_Wrap_480(BeyondDynamicBone.DataChunk& P0) { }
        private System.Void __Gen_Wrap_481(BeyondDynamicBone.ExBitFlag16& P0) { }
        private System.Int32 __Gen_Wrap_482(BeyondDynamicBone.ExCostSortedList1& P0, BeyondDynamicBone.ExCostSortedList1 P1) { }
        private System.String __Gen_Wrap_483(BeyondDynamicBone.ExCostSortedList1& P0) { }
        private System.Boolean __Gen_Wrap_484(BeyondDynamicBone.ExCostSortedList4& P0, System.Single P1, System.Int32 P2) { }
        private System.Int32 __Gen_Wrap_485(BeyondDynamicBone.ExCostSortedList4& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_486(BeyondDynamicBone.ExCostSortedList4& P0, System.Int32 P1) { }
        private System.String __Gen_Wrap_487(BeyondDynamicBone.ExCostSortedList4& P0) { }
        private UnityEngine.Jobs.TransformAccessArray __Gen_Wrap_488(System.Object P0) { }
        private System.Boolean __Gen_Wrap_489(BeyondDynamicBone.ResultCode& P0, BeyondDynamicBone.Define.Result P1) { }
        private System.Void __Gen_Wrap_490(BeyondDynamicBone.ResultCode& P0, System.Boolean P1, System.Boolean P2, System.Boolean P3) { }
        private System.Double __Gen_Wrap_491(System.Object P0) { }
        private System.Void __Gen_Wrap_492(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.Int32 P4) { }
        private Unity.Mathematics.float4 __Gen_Wrap_493(Unity.Mathematics.float4 P0) { }
        private BeyondDynamicBone.VirtualMesh.ShareSerializationData __Gen_Wrap_494(System.Object P0) { }
        private BeyondDynamicBone.VirtualMesh.UniqueSerializationData __Gen_Wrap_495(System.Object P0) { }
        private BeyondDynamicBone.VirtualMeshRaycastHit __Gen_Wrap_496(System.Object P0, Unity.Mathematics.float3 P1, Unity.Mathematics.float3 P2, System.Boolean P3, System.Single P4) { }
        private System.Void __Gen_Wrap_497(BeyondDynamicBone.VirtualMesh.Import_GenerateTangentJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_498(BeyondDynamicBone.VirtualMesh.Import_CalcSkinningJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_499(BeyondDynamicBone.VirtualMesh.Import_BoneWeightJob1& P0) { }
        private System.Void __Gen_Wrap_500(BeyondDynamicBone.VirtualMesh.Import_BoneWeightJob2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_501(BeyondDynamicBone.VirtualMesh.Import_BoneVertexJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_502(BeyondDynamicBone.VirtualMesh.Select_PackVertexJob& P0) { }
        private System.Void __Gen_Wrap_503(BeyondDynamicBone.VirtualMesh.Select_GridJob& P0) { }
        private System.Void __Gen_Wrap_504(BeyondDynamicBone.VirtualMesh.Add_CalcBindPoseJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_505(BeyondDynamicBone.VirtualMesh.Add_CopyVerticesJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_506(BeyondDynamicBone.VirtualMesh.Mapping_DirectConnectionVertexDataJob& P0) { }
        private System.Void __Gen_Wrap_507(BeyondDynamicBone.VirtualMesh.Mapping_CalcDirectWeightJob& P0) { }
        private System.Void __Gen_Wrap_508(BeyondDynamicBone.VirtualMesh.Mapping_CalcConnectionVertexDataJob& P0) { }
        private System.Void __Gen_Wrap_509(BeyondDynamicBone.VirtualMesh.Mapping_CalcWeightJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_510(BeyondDynamicBone.VirtualMesh.Optimize_EdgeToTrianlgeJob& P0) { }
        private System.Void __Gen_Wrap_511(BeyondDynamicBone.VirtualMesh.ProxyNormalRadiationAdjustmentJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_512(BeyondDynamicBone.VirtualMesh.ProxyCreateFixedListAndAABBJob& P0) { }
        private System.Void __Gen_Wrap_513(BeyondDynamicBone.VirtualMesh.Proxy_CalcTriangleNormalJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_514(BeyondDynamicBone.VirtualMesh.Proxy_CalcTriangleTangentJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_515(BeyondDynamicBone.VirtualMesh.Proxy_CreateVertexToTrianglesJob& P0) { }
        private System.Void __Gen_Wrap_516(BeyondDynamicBone.VirtualMesh.Proxy_OrganizeVertexToTrianglsJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_517(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexNormalTangentFromTriangleJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_518(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexToTransformJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_519(BeyondDynamicBone.VirtualMesh.Proxy_CalcEdgeToTriangleJob& P0) { }
        private System.Void __Gen_Wrap_520(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexBindPoseJob2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_521(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexToVertexFromTriangleJob& P0) { }
        private System.Void __Gen_Wrap_522(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexToVertexFromLineJob& P0) { }
        private System.Void __Gen_Wrap_523(BeyondDynamicBone.VirtualMesh.Proxy_CreateEdgeFlagJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_524(BeyondDynamicBone.VirtualMesh.Proxy_CalcCustomSkinningWeightsJobV2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_525(BeyondDynamicBone.VirtualMesh.Proxy_ApplySelectionJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_526(BeyondDynamicBone.VirtualMesh.Proxy_BoneClothApplayTransformFlagJob& P0, System.Int32 P1) { }
        private System.Int32 __Gen_Wrap_527(BeyondDynamicBone.VirtualMesh.BaseLineWork& P0, BeyondDynamicBone.VirtualMesh.BaseLineWork P1) { }
        private System.Void __Gen_Wrap_528(BeyondDynamicBone.VirtualMesh.BaseLine_Mesh_CreateParentJob2& P0) { }
        private System.Void __Gen_Wrap_529(BeyondDynamicBone.VirtualMesh.BaseLine_Mesh_CareteFixedListJob& P0) { }
        private System.Void __Gen_Wrap_530(BeyondDynamicBone.VirtualMesh.BaseLine_Bone_CreateBoneChildInfoJob& P0) { }
        private System.Void __Gen_Wrap_531(BeyondDynamicBone.VirtualMesh.BaseLine_CalcLocalPositionRotationJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_532(BeyondDynamicBone.VirtualMesh.BaseLine_CalcMaxBaseLineLengthJob& P0) { }
        private System.Void __Gen_Wrap_533(BeyondDynamicBone.VirtualMesh.Reduction_InitVertexToVertexJob2& P0) { }
        private System.Void __Gen_Wrap_534(BeyondDynamicBone.VirtualMesh.Organize_RemapVertexJob& P0) { }
        private System.Void __Gen_Wrap_535(BeyondDynamicBone.VirtualMesh.Organize_CollectUseSkinBoneJob& P0) { }
        private System.Void __Gen_Wrap_536(BeyondDynamicBone.VirtualMesh.Organize_CopyVertexJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_537(BeyondDynamicBone.VirtualMesh.Organize_RemapBoneWeightJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_538(BeyondDynamicBone.VirtualMesh.Organize_RemapLinkPointArrayJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_539(BeyondDynamicBone.VirtualMesh.Organize_CreateLineTriangleJob& P0) { }
        private System.Void __Gen_Wrap_540(BeyondDynamicBone.VirtualMesh.Organize_CreateLineTriangleJob2& P0) { }
        private System.Void __Gen_Wrap_541(BeyondDynamicBone.VirtualMesh.Organize_CreateNewTriangleJob3& P0) { }
        private System.Void __Gen_Wrap_542(BeyondDynamicBone.VirtualMesh.Work_AverageTriangleDistanceJob& P0) { }
        private System.Void __Gen_Wrap_543(BeyondDynamicBone.VirtualMesh.Work_AverageLineDistanceJob& P0) { }
        private System.Void __Gen_Wrap_544(BeyondDynamicBone.VirtualMesh.Work_AddVertexIndexGirdMapJob& P0) { }
        private System.Void __Gen_Wrap_545(BeyondDynamicBone.VirtualMesh.Work_IntersectTriangleJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_546(BeyondDynamicBone.VirtualMesh.Work_IntersectEdgeJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_547(BeyondDynamicBone.VirtualMesh.Work_IntersectPointJob& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_548(BeyondDynamicBone.VirtualMesh.Work_IntersetcSortJob& P0) { }
        private System.Boolean __Gen_Wrap_549(BeyondDynamicBone.VertexAttribute& P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_550(BeyondDynamicBone.VertexAttribute& P0) { }
        private System.String __Gen_Wrap_551(BeyondDynamicBone.VirtualMeshBoneWeight& P0) { }
        private System.Int32 __Gen_Wrap_552(BeyondDynamicBone.VirtualMeshRaycastHit& P0, BeyondDynamicBone.VirtualMeshRaycastHit P1) { }
        private System.Boolean __Gen_Wrap_553(BeyondDynamicBone.VirtualMeshRaycastHit& P0) { }
        private System.String __Gen_Wrap_554(BeyondDynamicBone.VirtualMeshRaycastHit& P0) { }
        private BeyondDynamicBone.VirtualMeshTransform __Gen_Wrap_555(BeyondDynamicBone.VirtualMeshTransform& P0) { }
        private BeyondDynamicBone.VirtualMeshTransform __Gen_Wrap_556() { }
        private System.Int32 __Gen_Wrap_557(BeyondDynamicBone.VirtualMeshTransform& P0) { }
        private System.Void __Gen_Wrap_558(BeyondDynamicBone.VirtualMeshTransform& P0, System.Object P1) { }
        private BeyondDynamicBone.VirtualMeshTransform __Gen_Wrap_559(BeyondDynamicBone.VirtualMeshTransform& P0, BeyondDynamicBone.VirtualMeshTransform& P1) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000277
    public class ILFixInterfaceBridge : AnonymousStorey, IAsyncStateMachine
    {
        // Fields
        private System.Int32 methodId_0;        // 0x40
        private System.Int32 methodId_1;        // 0x44

        // Methods
        private System.Void MoveNext() { }
        private System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine P0) { }
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAwaitUnsafeOnCompleteMethod() { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000278
    public class WrappersManagerImpl, WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000279
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-InitAnimationProperty0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-IsPlaying0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IsState0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ReductionSettings-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CustomSkinningSettings-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-NormalAlignmentSettings-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CheckSliderSerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CullingSettings-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CurveSerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InertiaConstraint-SerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TetherConstraint-SerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-SerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-SerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-RestorationSerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-LimitSerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MotionConstraint-SerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindSettings-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData2-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-DataUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetParameterChange0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-OnDidApplyAnimationProperties0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetRelativeTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-IsBoneSpring0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SerializeData-GetSyncPartner0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-get_SyncPartnerCloth0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-Reset0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-OnValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-SetResult0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-SetSuccess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-Develop-LogError0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-GetSerializeData20;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-SetState0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-SetError0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-SetWarning0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GenerateStatusCheck0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-IsError0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-IsWarning0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-Merge0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildSerializeData-UsePreBuild0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildSerializeData-GetSharePreBuildData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-IsSuccess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-IsFaild0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SharePreBuildData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-UniquePreBuildData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildSerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DataUtility-ConvertAnimationCurve0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CurveSerializeData-ConvertFloatArray0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CullingSettings-CullingParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CheckSliderSerializeData-GetValue0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InertiaConstraint-InertiaConstraintParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TetherConstraint-TetherConstraintParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-DistanceConstraintParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingConstraintParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-AngleConstraintParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MotionConstraint-MotionConstraintParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-ColliderCollisionConstraintParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SelfCollisionConstraintParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SpringConstraint-SpringConstraintParams-Convert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-GetClothParameters0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-SetProcess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-ShareDeserialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-ShareDeserialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-NativeMultiHashMapExtensions-MC2Deserialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ShareDeserialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-ShareDeserializationData-Deserialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-RegisterPreBuildData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-AddReferenceCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-AddRenderer0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-AddRenderer0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-GetRendererData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-CreateBoneRenderSetupData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-AddMonitoringProcess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-Init0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-RemoveMonitoringProcess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-Awake0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-CompleteMasterJob0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-ForceCompleteAllJob0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-GetTeamDataRef0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-TeamData-get_IsEnable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-EnableTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-EnableTeamCollider0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-EnableTransform1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-SetEnable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IsCameraCullingInvisible0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IsCameraCullingKeep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IsDistanceCullingInvisible0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-SetMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-SwapOriginalMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-IsFaild0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-get_HasTangent0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetBoneWeightsRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-ResetCustomMeshWorkData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-SwapCustomMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdateUse0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-StartUse0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-StartUse0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-EndUse0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-EndUse0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-UpdateUse0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-StartUse0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-OnEnable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-EndUse0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-OnDisable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-GetPreBuildData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-AddComponentTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-AddTeamAnimatorData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-AddTeam0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-AddCloth0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshContainer-GetTransformCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-GetTransformFromIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshContainer-GetTransformFromIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-AddAnimatorTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-AddTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-get_EdgeCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-get_BaseLineCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-RegisterProxyMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-RegisterProxyMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-AddTransform1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-IsReverseDirection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-GetSize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-Register0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-IsEnable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-get_IsEnable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-MarkAnimatorTransformDirty0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-SetTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-AddColliderInternal0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-InitColliders0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-Register0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-ConstraintData-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-Register0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-ConstraintData-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-Register0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InertiaConstraint-Register0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-ContainsTeamData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-GetParametersRef0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-InitPrimitive0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DataChunk-Clear0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdateTeam0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Register0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-RegisterConstraint0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-GetTeamMappingRef0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-GetCenterTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshContainer-GetCenterTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-AddTransform2;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-RegisterMappingMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-Clear0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshContainer-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-IsNormal0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-GetResultString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-PreBuildDataConstruction0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-ToNativeMultiHashMap0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-GetUnuseTriangleIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-CreateData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-GetRestTriangleVertex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-InitDihedralAngle0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DataUtility-PackInt40;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DataUtility-PackInt41;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-InitVolume0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-CreateData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InertiaConstraint-CenterData-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InertiaConstraint-CreateData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-AddTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-SetTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-get_Name0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-AddTransformRange0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-SerialNumberRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-FillRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ImportMeshType0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ImportMeshSkinning0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetParentTransformIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DataUtility-PackInt30;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ImportBoneType0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcAABBRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcUVWithSphereMappingRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CalcAverageAndMaxVertexDistanceRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-IsNone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ImportFrom0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ImportFrom1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-TransformPositionRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GenerateSelectionDataFromVertexAttributeData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-Merge0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GenerateSelectionDataFromPaintMap0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AABB-get_MaxSideLength0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ReductionSettings-GetMaxConnectionDistance0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CalcSelectionMergin0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-GetPositionNativeArray0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-GetAttributeNativeArray0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-TransformPositionRun1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-CreateGridMapRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-SelectionMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CompareSpace0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CenterTransformTo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-AddTransform1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-AddMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-Fill0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetTransformIndexFromId0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-FillRun1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-InitReductionWorkData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-UpdateJoinAndLink0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-UpdateReductionResultJob0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-Reduction0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-StepInitialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-InitStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-PreReductionStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-CustomReductionStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-SortJoinEdge0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-DetermineJoinEdge0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-RunJoinEdge0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-UpdateJoinAndLink0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-PostReductionStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-ReductionStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-IsEndStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-NextStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-UpdateReductionResultJob0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-Reduction0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-OrganizationInit0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-OrganizationCreateRemapData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-OrganizationCreateBasicData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-OrganizationCreateLineTriangle0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Organization0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-OrganizeReductionTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-OrganizeStoreVirtualMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-SetCancel0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Reduction0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-RemoveDuplicateTriangles0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Optimization0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ApplySelectionAttribute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformRecord-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-SetCustomSkinningBones0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-FillRun2;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CalcTwoTriangleAngle0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CheckTwoTriangleOpen0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-OptimizeTriangleDirection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ProxyCreateFixedListAndAABB0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CreateTransformBaseLine0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CreateMeshBaseLine0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AABB-get_Center0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ProxyNormalAdjustment0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CreateBaseLinePose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CreateVertexRootAndDepth0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CreateCustomSkinning0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ConvertProxyMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CreateVertexIndexGridMapRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Mapping0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IncrementSuspendCounter0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GeneratePaintMapDataList0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-Develop-LogWarning0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-DecrementSuspendCounter0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-Exit0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-Exit0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InertiaConstraint-Exit0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Exit0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-ExitProxyMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-RemoveTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-ExitMappingMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-ExitProxyMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-Exit0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-Exit0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-RemoveSyncParent0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-RemoveComponentTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-ClearTeamAnimatorData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-RemoveTeam0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-RemoveCloth0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-RemoveReferenceCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-RemoveRenderer0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-UnregisterPreBuildData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-DisposeInternal0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-RuntimeBuildAsync0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-StartRuntimeBuild0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-AutoBuild0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-Start0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-GetMagicaHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-DisableAutoBuild0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetCodeParamaterDirty0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetClothSimulateWeight0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetCodeParamaterDirtyIgnorePlaying0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetClothSimulateWeightIgnorePlaying0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetClothStablizationTimeAfterResetIgnorePlaying0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetAnimationPoseRatio0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GenerateInitialization0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-IsUserEdit0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GenerateBoneClothSelection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-BuildAndRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformRecord-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CustomSkinningSettings-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-NormalAlignmentSettings-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-UniqueSerializationData-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-UniqueSerializationData-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-UniqueSerializationData-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-UniquePreBuildData-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildSerializeData-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData2-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GetUsedTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformRecord-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CustomSkinningSettings-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-NormalAlignmentSettings-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-UniqueSerializationData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-UniqueSerializationData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-UniqueSerializationData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-UniquePreBuildData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildSerializeData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData2-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetTimeScale0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-GetTimeScale0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-UpdateRendererUse0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-ResetCloth0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SoftResetCloth0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-GetCenterDataRef0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-GetCenterPosition0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-AddForce0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-SetSkipWriting0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCloth-SetSkipWriting0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CheckSliderSerializeData-SetValue0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CheckSliderSerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothBehaviour-GetMagicaHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothBehaviour-OnDrawGizmos0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GetColliderIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-UpdateCullingAnimatorAndRenderers0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GetStateFlag0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IsRunning0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IsLodCulled0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IsSkipWriting0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-IsUpdateTangent0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-get_HasProxyMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-get_Name0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GetSuspendCounter0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GetRenderMeshInfo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-SyncParameters0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GetClothUpdateMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothProcess-GenerateSelectionJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-ExportJson0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-TempBuffer-Pop0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-ImportJson0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ReductionSettings-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CustomSkinningSettings-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-NormalAlignmentSettings-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CullingSettings-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CurveSerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InertiaConstraint-SerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TetherConstraint-SerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-SerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-SerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-RestorationSerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-LimitSerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MotionConstraint-SerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindSettings-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-Import0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-Import1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData-TempBuffer-Push0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData2-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothSerializeData2-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCapsuleCollider-GetColliderType0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-SetSize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCapsuleCollider-SetSize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCapsuleCollider-GetSize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCapsuleCollider-GetLocalDir0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCapsuleCollider-GetLocalUp0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCapsuleCollider-IsReverseDirection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneCapsuleCollider-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBonePlaneCollider-GetColliderType0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBonePlaneCollider-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneSphereCollider-GetColliderType0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneSphereCollider-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneSphereCollider-SetSize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-SetSizeX0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-SetSizeY0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-SetSizeZ0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-GetScale0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-GetClothProcess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-UpdateParameters0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-UpdateParameters0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-Start0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-OnValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-EnableCollider0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-OnEnable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-OnDisable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-CopyTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-RemoveCollider0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderComponent-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-WorkBufferUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-SolverConstraint0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-AngleConstraintJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-ClampAngle0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-FromToRotation0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-AngleConstraintJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-AngleConstraintJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AngleConstraint-AngleConstraintJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-WorkBufferUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SolverConstraint0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000DB$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000DC$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E0$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000E1$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000E5$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000E6$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointSphereColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointPlaneColliderDetction0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointCapsuleColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgeSphereColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgeCapsuleColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgePlaneColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointSphereColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointCapsuleColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointPlaneColliderDetction0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgeSphereColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgeCapsuleColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgePlaneColliderDetection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-ReadAverageFloat30;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-ReadFloat0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-ReadFloat30;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-SolverConstraint0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InertiaConstraint-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InertiaConstraint-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MotionConstraint-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MotionConstraint-SolverConstraint0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MotionConstraint-MotionConstraintJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MotionConstraint-MotionConstraintJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MotionConstraint-MotionConstraintJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MotionConstraint-MotionConstraintJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-HasPrimitive0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-WorkBufferUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-BinarySearchSortAndlSweep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverBroadPhase0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdateBroadPhase0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverRuntimeSelfCollision0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-Fill0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolveIntersect0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverConstraint0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_00000145$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_00000146$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000147$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000148$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$ClearBufferJobKernels_ClearBufferKernel_00000149$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$SortJobKernels_SortKernel_0000014A$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$SortJobKernels_SortRangeKernel_0000014B$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_0000017E$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_0000017F$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000180$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_00000181$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SortData-CompareTo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeContact-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-PointTriangleContact-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-InitPrimitiveJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-ClearBufferJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SortJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-TeamData-get_IsProcess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SortJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SortJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SortJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-BroadPointTriangle0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-SweepTest0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-BroadEdgeEdge0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-SweepTest0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeToListJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-PointTriangleToListJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-IntersectTest0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-SweepTest0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseCrossFrameJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseCrossFrameJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseCrossFrameJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseCrossFrameJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SpringConstraint-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SpringConstraint-SolverConstraint0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SpringConstraint-SerializeData-DataValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SpringConstraint-SerializeData-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TetherConstraint-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TetherConstraint-SolverConstraint0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TetherConstraint-TethreConstraintJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TetherConstraint-TethreConstraintJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TetherConstraint-TethreConstraintJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TetherConstraint-TethreConstraintJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-SolverConstraint0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-Initialize$TriangleBendingJobKernels_TriangleBendingKernel_000001AA$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-Initialize$TriangleBendingJobKernels_TriangleBendingRangeKernel_000001AB$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001AE$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001AF$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJobKernels-Volume0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJobKernels-DihedralAngle0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Volume0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-DihedralAngle0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CullingSettings-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CurveSerializeData-SetValue0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CurveSerializeData-SetValue1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CurveSerializeData-SetValue2;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CurveSerializeData-Evaluate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CustomSkinningSettings-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-CustomSkinningSettings-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-GizmoSerializeData-IsAlways0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-NormalAlignmentSettings-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-NormalAlignmentSettings-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-Compare0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-AddRange0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-GetPositionNativeArray1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-ConvertFrom0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-TransformPositionJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-CreateGridMapJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SelectionData-ConvertSelectionJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-AddWind0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-Awake0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-Start0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-SetEnable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-OnEnable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-OnDisable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-RemoveWind0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-IsDirection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-IsRadial0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-IsAddition0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-GetWindDirection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-BeyondBoneWindZone-SetWindDirection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindParams-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindSettings-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-ClearVisibleDict0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-CheckRendererVisible0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-CheckVisible0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-CheckLODVisible0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-CameraCullingPostProcess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-RestoreTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-OnEarlyClothUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-UpdateTeamAnimatorData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-OnAfterUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-FrameUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-Expand0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-AddCollider0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-UpdateColliders0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdateSkipWriting0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ReadComponentTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-GetDeltaTime0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-GetFixedDeltaTime0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-GetUnscaledDeltaTime0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-AlwaysTeamUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-AlwaysWindUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-WorkBufferUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-ClearMasterJob0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-UpdateBuffer0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-CameraCullingPreProcess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ReadTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-WriteDoubleBufferTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ValidPosition0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-PreProxyMeshUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWind0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-PreSimulationUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PreSimulationUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-SimulationStepTeamUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-CreateUpdateColliderList0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-StartSimulationStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-EndSimulationStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-SimulationStepUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-CalcDisplayPosition0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-PostProxyMeshUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-PostMappingMeshUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdatePositionNormal0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdateBoneWeight0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-CopyDoubleBuffer0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-WriteTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PostSimulationUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-PostTeamUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-ClothUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-OnAfterLateUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-OnBeforeLateUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-OnApplicationQuit0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-ShareDeserializationData-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-UnloadUnusedData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-ShareDeserializationData-GetProxyMeshContainer0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildManager-ShareDeserializationData-GetRenderMeshContainer0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DoAllInOneJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_0000025C$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_0000025D$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferDataJob-_Do0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferDataJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferDataJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferDataJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-CopyDoubleBufferJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-EnableTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-RestoreTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ReadTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-WriteTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DynamicBoneTransformManager-ReadComponentTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-MonitoringProcess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-MonitoringProcessUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-SetSkipWriting0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamWindInfo-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-Initialize$PostTeamUpdateJobKernels_PostTeamUpdateKernel_00000298$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-Initialize$PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_00000299$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-MappingData-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePreJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePostJob-DistanceCullingUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePostJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-ShiftPosition0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-WindData-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-WindData-IsEnable0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-WindData-IsAddition0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamWindInfo-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamWindData-IndexOf0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamWindData-AddOrReplaceWindZone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamWindData-RemoveWindZone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Wind0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UpdateWindTime0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UpdateWind0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-PostTeamUpdateJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-PostTeamUpdateJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-PostTeamUpdateJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamManager-PostTeamUpdateJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002E6$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002E7$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002E8$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002E9$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformDataJobKernels_WriteTransformDataKernel_000002EA$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002EB$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002EC$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002ED$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002EE$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002EF$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002F0$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002F1$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002F2$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002F3$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_000002F4$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_000002F5$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-Initialize$ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_000002F6$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-ClearProxyMeshUpdateBufferJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-ClearProxyMeshUpdateBufferJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-NativeReferenceExtensions-MC2InterlockedStartIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshBoneWeight-get_Count0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-TriangleTangent0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-CheckRegist0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PlayerLoopUtils-AddPlayerLoop0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-SetCustomGameLoop0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-InitCustomGameLoop0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-SetUseCrossFrameJob0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-SetGlobalTimeScale0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-GetGlobalTimeScale0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-SetSimulationFrequency0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-SetAOVMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-DoAOVUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-DoAOVAfterAnimatorUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-GetSimulationFrequency0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-SetMaxSimulationCountPerFrame0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-GetMaxSimulationCountPerFrame0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-SetUpdateLocation0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-GetUpdateLocation0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-UnloadUnusedData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaManager-SetInitializationLocation0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaSettings-Refresh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaSettings-Awake0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaSettings-Start0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaSettings-Update0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MagicaSettings-OnValidate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-WriteMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdatePositionNormalJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdatePositionNormalJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdatePositionNormalJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdatePositionNormalJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-PreRenderingUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-IsSuccess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetRendeerLocalToWorldMatrix0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-ReadTransformInformation0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetRendeerTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetRenderTransformId0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetSkinRootTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetSkinRootTransformId0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-ShareSerialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-UniqueSerialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-VertexWeight5BoneCheckJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-ReadTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-RenderSetupData-GetBoneWeightJos-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003D3$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003D4$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003D7$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003D8$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-StartSimulationStepJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-StartSimulationStepJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-StartSimulationStepJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-StartSimulationStepJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-EndSimulationStepJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-EndSimulationStepJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-EndSimulationStepJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-EndSimulationStepJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer2;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_StartSimulationStepKernel_00000405$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000406$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_Spring_00000407$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_Wind_00000408$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_WindForceBlend_00000409$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_0000040A$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_0000040B$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$EndSimulationStepJobKernels_EndSimulationStepKernel_0000040C$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$EndSimulationStepJobKernels_EndSimulationStepRangeKernel_0000040D$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_0000040E$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_0000040F$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-Initialize$ClearStepCounterKernels_ClearStepCounterKernel_00000410$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-ClearStepCounter-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-ClearStepCounter-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-StartSimulationStepJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-StartSimulationStepJob-WindForceBlend0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Wind0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Spring0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-StartSimulationStepJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-EndSimulationStepJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-EndSimulationStepJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-EndSimulationStepJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-EndSimulationStepJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-FeedbackTempPosJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimulationManager-FeedbackTempPosJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-AfterFixedUpdate0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-AfterRenderring0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-EnterdEditMode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-Initialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-WindManager-InformationLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamWindInfo-DebugLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TeamWindData-ClearZoneList0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-Init0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-AddTransform2;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-AddTransformRange1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-AddTransformRange2;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-RemoveTransformIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-ReplaceTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-UpdateWorkData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-RestoreTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-ReadTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-ReadTransformRun0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-GetTransformIndexFormId0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-GetTransformIdFromIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-GetParentIdFromIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-GetLocalToWorldMatrix0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-GetWorldToLocalMatrix0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-ShareSerialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-UniqueSerialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-RestoreTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformData-ReadTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TransformRecord-InverseTransformDirection0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SharePreBuildData-CheckBuildId0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildScriptableObject-GetPreBuildData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildScriptableObject-HasPreBuildData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildScriptableObject-AddPreBuildData0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildScriptableObject-Warmup0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-PreBuildSerializeData-GenerateBuildID0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SharePreBuildData-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ReductionSettings-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ReductionSettings-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ReductionWorkData-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-InitGridJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-SearchJoinJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshBoneWeight-AddWeight0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshBoneWeight-AddWeight1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-JoinJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-UpdateJoinIndexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-UpdateLinkIndexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshBoneWeight-AdjustWeight0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SameDistanceReduction-FinalMergeVertexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ShapeDistanceReduction-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ShapeDistanceReduction-StepInitialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ShapeDistanceReduction-CustomReductionStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-CheckJoin20;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ShapeDistanceReduction-SearchJoinEdgeJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimpleDistanceReduction-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimpleDistanceReduction-StepInitialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimpleDistanceReduction-CustomReductionStep0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimpleDistanceReduction-InitGridJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-SimpleDistanceReduction-SearchJoinEdgeJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-CheckJoin0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-JoinEdge-Contains0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-JoinEdge-CompareTo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-DeterminJoinEdgeJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-JoinPairJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-UpdateJoinIndexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-UpdateLinkIndexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StepReductionBase-FinalMergeVertexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothDebugSettings-CheckParticleDrawing0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothDebugSettings-CheckTriangleDrawing0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothDebugSettings-CheckRadiusDrawing0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothDebugSettings-GetPointSize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothDebugSettings-GetLineSize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothDebugSettings-GetInertiaCenterRadius0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothDebugSettings-GetCustomSkinningRadius0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothDebugSettings-IsReferOldPos0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DataUtility-PackInt31;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-Fill1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-Fill2;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-SerialNumber0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-ConvertHashSetToNativeList0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-ConvertHashSetKeyToNativeList0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-ConvertHashSetKeyToNativeList1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcAABB0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcAABB1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcAABBRun1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcAABBInternal0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcUVWithSphereMapping0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-TransformPosition0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-TransformPosition1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-ClearReference0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-SerialNumberJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcAABBJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcAABBDeferJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-CalcUVJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-AddIntDataCopyJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-AddInt2DataCopyJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-AddInt3DataCopyJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-TransformPositionJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-TransformPositionJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ClothJobUtility-ClearReferenceJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear2;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-Initialize$AggregateJobKernels_AggregateKernel_00000564$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-Initialize$AggregateJobKernels_AggregateRangeKernel_00000565$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_00000566$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_00000567$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-Initialize$AggregateJob2Kernels_AggregateJob2Kernel_00000568$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-Initialize$AggregateJob2Kernels_AggregateJob2RangeKernel_00000569$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_0000056A$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_0000056B$BurstDirectCall0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateJob2-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateJob2-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateJob2-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-SetIndexCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-UnsafeDo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateWithVelocityCrossFrameJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateWithVelocityCrossFrameJob2-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateCrossFrameJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-InterlockUtility-AggregateCrossFrameJob2-Execute1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AABB-get_HalfExtents0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AABB-get_SurfaceArea0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-AABB-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-ComputeVirtualParentWithoutLocal0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-GetCommonEdgeFromTrianglePair0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-GetTrianglePairIndices0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-IntersectSegmentTriangle0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-IntersectSegmentTriangle1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MathUtility-SqDistPointSegment0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-FTransform-Default0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MeshUtility-GetSharedMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MeshUtility-SetMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-MeshUtility-GetTransformCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-Develop-Log0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-Develop-DebugLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-Develop-DebugLogWarning0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-Develop-DebugLogError0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-Develop-Assert0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StaticStringBuilder-Clear0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StaticStringBuilder-Append0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StaticStringBuilder-AppendLine0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StaticStringBuilder-AppendLine1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StaticStringBuilder-AppendToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-StaticStringBuilder-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-DataChunk-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExBitFlag16-Clear0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExCostSortedList1-CompareTo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExCostSortedList1-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExCostSortedList4-Add0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExCostSortedList4-indexOf0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExCostSortedList4-RemoveItem0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExCostSortedList4-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExTransformAccessArray-Dispose0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExTransformAccessArray-GetTransformAccessArray0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExTransformAccessArray-Add0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExTransformAccessArray-Remove0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExTransformAccessArray-Exist0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExTransformAccessArray-Exist1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExTransformAccessArray-GetIndex0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ExTransformAccessArray-Clear0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-IsResult0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-IsCancel0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-IsProcess0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-GetWarningString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-GetResultInformation0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-GetWarningInformation0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-ResultCode-DebugLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeSpan-Start0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeSpan-Finish0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeSpan-TotalSeconds0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeSpan-TotalMilliSeconds0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeSpan-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeSpan-DebugLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-TimeSpan-Log0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-UnityTimeSpan-Finish0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-UnityTimeSpan-TotalSeconds0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-UnityTimeSpan-TotalMilliSeconds0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-UnityTimeSpan-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-UnityTimeSpan-DebugLog0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-SetCenterTransform0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-SetSkinRoot0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-SetTransform1;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-CalcVertexWeights0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ShareSerialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-UniqueSerialize0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-IntersectRayMesh0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-get_NormalAdjustmentRotationCount0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-SetName0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Import_GenerateTangentJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Import_CalcSkinningJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Import_BoneWeightJob1-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Import_BoneWeightJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Import_BoneVertexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Select_PackVertexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Select_GridJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Add_CalcBindPoseJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Add_CopyVerticesJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Mapping_DirectConnectionVertexDataJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Mapping_CalcDirectWeightJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Mapping_CalcConnectionVertexDataJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Mapping_CalcWeightJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Optimize_EdgeToTrianlgeJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ProxyNormalRadiationAdjustmentJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ProxyCreateFixedListAndAABBJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CalcTriangleNormalJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CalcTriangleTangentJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CreateVertexToTrianglesJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_OrganizeVertexToTrianglsJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexNormalTangentFromTriangleJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToTransformJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CalcEdgeToTriangleJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexBindPoseJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToVertexFromTriangleJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToVertexFromLineJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CreateEdgeFlagJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_CalcCustomSkinningWeightsJobV2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_ApplySelectionJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Proxy_BoneClothApplayTransformFlagJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-BaseLineWork-CompareTo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-BaseLine_Mesh_CreateParentJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-BaseLine_Mesh_CareteFixedListJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-BaseLine_Bone_CreateBoneChildInfoJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-BaseLine_CalcLocalPositionRotationJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-BaseLine_CalcMaxBaseLineLengthJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Reduction_InitVertexToVertexJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Organize_RemapVertexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Organize_CollectUseSkinBoneJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Organize_CopyVertexJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Organize_RemapBoneWeightJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Organize_RemapLinkPointArrayJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Organize_CreateLineTriangleJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Organize_CreateLineTriangleJob2-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Organize_CreateNewTriangleJob3-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-ShareSerializationData-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Work_AverageTriangleDistanceJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Work_AverageLineDistanceJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Work_AddVertexIndexGirdMapJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Work_IntersectTriangleJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Work_IntersectEdgeJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Work_IntersectPointJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMesh-Work_IntersetcSortJob-Execute0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VertexAttribute-Equals0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VertexAttribute-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshBoneWeight-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshRaycastHit-CompareTo0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshRaycastHit-IsValid0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshRaycastHit-ToString0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshTransform-Clone0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshTransform-get_Origin0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshTransform-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshTransform-Update0;        // 0x0
        public static IFix.IDMAP0 BeyondDynamicBone-VirtualMeshTransform-Transform0;        // 0x0

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

