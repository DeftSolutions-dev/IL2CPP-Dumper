// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.HGGraphicsModule.dll
// Classes:  233
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000067
    public class GetFileHashMappingCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.HyperGryph.VFSBlockFileInfo Invoke(System.Int64 originNameHash) { }

    }

    // TypeToken: 0x2000068
    public class GetFilePathMappingCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.HyperGryph.VFSBlockFileInfo Invoke(System.String originName) { }

    }

    // TypeToken: 0x2000069
    public class GetTextureFromHGWaterSectorDataCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.Texture2D Invoke(UnityEngine.ScriptableObject sectorDataScriptableObject) { }

    }

    // TypeToken: 0x2000086
    public struct HGWaterRenderType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HyperGryph.HGWaterRender.HGWaterRenderType Proxy;        // 0x0
        public static UnityEngine.HyperGryph.HGWaterRender.HGWaterRenderType LOD;        // 0x0

    }

    // TypeToken: 0x2000087
    public struct HGWaterDecalRenderType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HyperGryph.HGWaterRender.HGWaterDecalRenderType None;        // 0x0
        public static UnityEngine.HyperGryph.HGWaterRender.HGWaterDecalRenderType Regular;        // 0x0
        public static UnityEngine.HyperGryph.HGWaterRender.HGWaterDecalRenderType Emissive;        // 0x0

    }

    // TypeToken: 0x20000E9
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* m_entityTypes;        // 0x10
        private readonly System.Int32 m_count;        // 0x18
        private UnityEngine.HyperGryph.ECS.ComponentMask m_includeComponentMask;        // 0x20
        private UnityEngine.HyperGryph.ECS.ComponentMask m_excludedComponentMask;        // 0x30
        private System.Int32 m_index;        // 0x40

        // Methods
        private System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* entityTypes, System.Int32 count, UnityEngine.HyperGryph.ECS.ComponentMask& includeComponentMask, UnityEngine.HyperGryph.ECS.ComponentMask& excludeComponentMask) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private UnityEngine.HyperGryph.ECS.GroupType get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

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
    public class IsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class IsUnmanagedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace UnityEngine
{

    // TypeToken: 0x2000005
    public class HGCapsuleBindingComponent : Component
    {
        // Methods
        private System.Void set_enabled(System.Boolean value) { }
        private System.Void set_capsuleRadius(System.Single value) { }
        private System.Void set_capsuleHeight(System.Single value) { }
        private System.Void set_localOffset(UnityEngine.Vector3 value) { }
        private System.Void set_localRotation(UnityEngine.Vector3 value) { }
        private System.Void set_intensityScale(System.Single value) { }
        private System.Void set_forceRender(System.Boolean value) { }
        private System.Void set_localOffset_Injected(UnityEngine.Vector3& value) { }
        private System.Void set_localRotation_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x2000006
    public struct HGDecalShapeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HGDecalShapeType Box;        // 0x0
        public static UnityEngine.HGDecalShapeType Cylinder;        // 0x0
        public static UnityEngine.HGDecalShapeType Sector;        // 0x0
        public static UnityEngine.HGDecalShapeType Sphere;        // 0x0
        public static UnityEngine.HGDecalShapeType Mesh;        // 0x0

    }

    // TypeToken: 0x2000007
    public class HGDecalProjector : Behaviour
    {
        // Methods
        private UnityEngine.HGDecalShapeType get_shapeType() { }
        private UnityEngine.Material get_material() { }
        private System.Void set_material(UnityEngine.Material value) { }
        private System.Void set_baseColor(UnityEngine.Color value) { }
        private UnityEngine.Vector2 get_uvOffset() { }
        private System.Void set_uvOffset(UnityEngine.Vector2 value) { }
        private System.Void set_sectorAngle(System.Single value) { }
        private System.Void set_baseColor_Injected(UnityEngine.Color& value) { }
        private System.Void get_uvOffset_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_uvOffset_Injected(UnityEngine.Vector2& value) { }

    }

    // TypeToken: 0x2000008
    public class HGOccluder : Component
    {
        // Methods
        private System.Boolean get_enabled() { }
        private System.Void set_enabled(System.Boolean value) { }
        private UnityEngine.HGSoftwareOcclusionCullingData get_occluderData() { }
        private System.Void set_occluderData(UnityEngine.HGSoftwareOcclusionCullingData value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class HGSoftwareOcclusionCullingData
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.HGSoftwareOcclusionCullingData cullingData) { }
        private System.Void GetOccluderData(Unity.Collections.NativeArray<System.Single> centerXs, Unity.Collections.NativeArray<System.Single> centerYs, Unity.Collections.NativeArray<System.Single> centerZs, Unity.Collections.NativeArray<System.Single> extentXs, Unity.Collections.NativeArray<System.Single> extentYs, Unity.Collections.NativeArray<System.Single> extentZs, Unity.Collections.NativeArray<UnityEngine.Vector3> vertexData, System.Int32& quadCount) { }
        private System.Int32 get_quadCount() { }
        private System.Void GetOccluderData(System.IntPtr centerXs, System.IntPtr centerYs, System.IntPtr centerZs, System.IntPtr extentXs, System.IntPtr extentYs, System.IntPtr extentZs, System.IntPtr vertexData, System.Int32& quadCount) { }

    }

    // TypeToken: 0x200000A
    public struct TransformAnimatedPhasePlayMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TransformAnimatedPhasePlayMode TransformAnimatedPhaseCurrent;        // 0x0
        public static UnityEngine.TransformAnimatedPhasePlayMode TransformAnimatedPhaseSequence;        // 0x0
        public static UnityEngine.TransformAnimatedPhasePlayMode TransformAnimatedPhaseSequenceLoop;        // 0x0

    }

    // TypeToken: 0x200000B
    public struct TransformAnimatedCurveData
    {
        // Fields
        public System.Byte[] data;        // 0x10
        public System.Single duration;        // 0x18

    }

    // TypeToken: 0x200000C
    public struct TransformMotionPhase
    {
        // Fields
        public UnityEngine.Vector3 translationSpeed;        // 0x10
        public UnityEngine.Vector3 eulerAngleSpeed;        // 0x1C
        public UnityEngine.Vector3 rotAnchorPosition;        // 0x28
        public System.Single duration;        // 0x34

    }

    // TypeToken: 0x200000D
    public struct HGTransformAnimatedProfile
    {
        // Fields
        public UnityEngine.TransformMotionPhase[] motionPhaseProfiles;        // 0x10
        public UnityEngine.TransformAnimatedCurveData animCurveData;        // 0x18
        public UnityEngine.TransformAnimatedPhasePlayMode phasePlayMode;        // 0x28

    }

    // TypeToken: 0x200000E
    public class HGTransformAnimatedBehaviour : Behaviour
    {
        // Fields
        public UnityEngine.HGTransformAnimatedProfile profileData;        // 0x18
        public System.Boolean useLogicDeltaTime;        // 0x38
        public UnityEngine.Renderer shadowProxyRenderer;        // 0x40

        // Methods
        private System.Void SetPause() { }
        private System.Void Play() { }
        private System.Single GetTimeScale() { }
        private System.Void SetTimeScale(System.Single scale) { }
        private System.Void SetCurrentPhaseIndex(System.Int32 phase) { }
        private System.Int32 GetCurrentPhaseIndex() { }
        private UnityEngine.Matrix4x4 GetWorldMatrix() { }
        private System.Void SetUseLogicTime(System.Boolean useLogicTime) { }
        private System.Boolean UseLogicTime() { }
        private System.Void .ctor() { }
        private System.Void GetWorldMatrix_Injected(UnityEngine.Matrix4x4& ret) { }

    }

    // TypeToken: 0x200000F
    public class HGWindFoliageSyncSystemCPP
    {
        // Methods
        private System.Int64 HGWindFoliageSyncSystemCPP_Create() { }
        private System.Void HGWindFoliageSyncSystemCPP_UpdateWindParam(System.Int64 _ptr, UnityEngine.Vector4 windGlobalParam, System.Single* windMotorParam0, System.Single* windMotorParam1, System.Single* windMotorParam2, System.Single* windMotorParam3, UnityEngine.Vector4 count, System.Single time, System.Single lastTime) { }
        private System.Void HGWindFoliageSyncSystemCPP_Destroy(System.Int64 _ptr) { }
        private System.Void HGWindFoliageSyncSystemCPP_UpdateWindParam_Injected(System.Int64 _ptr, UnityEngine.Vector4& windGlobalParam, System.Single* windMotorParam0, System.Single* windMotorParam1, System.Single* windMotorParam2, System.Single* windMotorParam3, UnityEngine.Vector4& count, System.Single time, System.Single lastTime) { }

    }

}

namespace UnityEngine.HyperGryph
{

    // TypeToken: 0x2000010
    public struct HGDLSSUtil
    {
        // Methods
        private System.Boolean IsStreamlineDLSSSupported() { }
        private System.Boolean IsStreamlineDLSSGSupported() { }
        private System.Boolean IsLowLatencyAvailable() { }

    }

    // TypeToken: 0x2000011
    public class GPUDrivenRenderer
    {
        // Methods
        private System.Void CreateRendererListWithPreZ(System.UInt32 viewHandle, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32 prevBatchKeySetIdx, System.UInt32& normalList, System.UInt32& preZPart0List, System.UInt32& preZPart1List, System.UInt32& currBatchKeySetIdx) { }
        private System.Void FreeBatchKeySet(System.UInt32 idx) { }
        private System.Boolean Enable() { }
        private System.Void CreateRendererListWithPreZ(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context, System.UInt32 prevBatchKeySetIdx, System.UInt32& normalList, System.UInt32& preZPart0List, System.UInt32& preZPart1List, System.UInt32& currBatchKeySetIdx) { }
        private System.Void DrawRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList, System.Boolean renderMatchedPrev) { }
        private System.Void AdvanceFrame() { }
        private System.Boolean CullingInspectionMode() { }
        private System.Void PopulatePerFrameData(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 threadGroupSize, System.UInt32 hzbWidth, System.UInt32 hzbHeight, System.Boolean populatePrev) { }
        private System.Void BindFrameConstantsBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader shader, System.UInt32 kernelIdx) { }
        private System.Void BindFrameConstantsBufferGlobal(UnityEngine.Rendering.CommandBuffer cmd, System.Boolean bindPrev) { }
        private System.Void BindBuffersForCulling(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader shader, System.UInt32 kernelIdx) { }
        private System.Void BindBuffersForRendering(UnityEngine.Rendering.CommandBuffer cmd) { }
        private System.Void DispatchComputeMeshletInstanceCount(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader shader, System.UInt32 kernelIdx) { }
        private System.Void DispatchComputeDrawBucketCount(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader shader, System.UInt32 kernelIdx) { }

    }

    // TypeToken: 0x2000012
    public struct CapsuleData
    {
        // Fields
        public UnityEngine.Vector3 pa;        // 0x10
        public System.Single radius;        // 0x1C
        public UnityEngine.Vector3 pb;        // 0x20
        public System.Single len;        // 0x2C
        public UnityEngine.Vector3 dir;        // 0x30
        public System.Single padding;        // 0x3C

    }

    // TypeToken: 0x2000013
    public class HGCapsuleShadowManager
    {
        // Methods
        private System.UInt32 GetRenderCapsuleNum() { }
        private System.UInt32 CullAndGetRenderCapsuleData(System.UInt32 viewHandle, System.IntPtr outData, System.UInt32 outDataCapacity) { }

    }

    // TypeToken: 0x2000014
    public class HGDecalRender
    {
        // Methods
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context) { }
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context, System.IntPtr drawableFeedbackPtr) { }
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32* drawableFeedbackPtr) { }
        private System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList) { }

    }

    // TypeToken: 0x2000015
    public struct HGDrawCallDetailedStats
    {
        // Fields
        public System.Int32 componentInstanceID;        // 0x10
        public System.Int32 meshInstanceID;        // 0x14
        public System.Int32 triCount;        // 0x18
        public System.Int32 meshBatchCount;        // 0x1C
        public System.Int32 shaderInstanceID;        // 0x20
        public System.Int32 passNameID;        // 0x24
        public System.Int32 passVertKeywordsID;        // 0x28
        public System.Int32 passFragKeywordsID;        // 0x2C

    }

    // TypeToken: 0x2000016
    public class HGFastString
    {
        // Methods
        private System.String IndexToString(System.Int32 index) { }
        private System.Int32 StringToIndex(System.String s) { }

    }

    // TypeToken: 0x2000017
    public struct HGFactoryRendererData
    {
        // Fields
        public UnityEngine.Mesh m_mesh;        // 0x10
        public UnityEngine.Mesh m_shadowProxyMesh;        // 0x18
        public UnityEngine.Material[] m_materials;        // 0x20

    }

    // TypeToken: 0x2000018
    public struct HGFactoryInstancingLODDataV2
    {
        // Fields
        public UnityEngine.HyperGryph.HGFactoryRendererData[] m_rendererDataArr;        // 0x10
        public System.Single m_lodScreenSizeMax;        // 0x18
        public System.Single m_lodScreenSizeMin;        // 0x1C

    }

    // TypeToken: 0x2000019
    public struct HGFactoryEntityDesc
    {
        // Fields
        public UnityEngine.Vector3 m_initPosition;        // 0x10
        public System.Single m_initUniformScale;        // 0x1C
        public UnityEngine.Quaternion m_initRotation;        // 0x20
        public UnityEngine.Rendering.ShadowCastingMode m_shadowCastingMode;        // 0x30
        public UnityEngine.Rendering.SubMeshRenderMode m_subMeshRenderMode;        // 0x34
        public System.Int32 m_objectLayer;        // 0x38
        public System.Int32 m_objectEnabled;        // 0x3C
        public System.Int32 m_renderFoliageOccluder;        // 0x40
        public System.Single m_objectBoundExtentsMultiplier;        // 0x44
        public System.Int32 m_useCustomLocalBounds;        // 0x48
        public UnityEngine.Bounds m_customLocalBounds;        // 0x4C
        public System.Int32 m_autoUpdatePrevTransform;        // 0x64
        public System.UInt32 m_enabledLightModes;        // 0x68
        public UnityEngine.HyperGryph.ECS.Entity m_logicalEntityHandle;        // 0x6C

    }

    // TypeToken: 0x200001A
    public struct HGFactoryEntityTransformData
    {
        // Fields
        public UnityEngine.Vector4 m_positionAndScale;        // 0x10
        public UnityEngine.Quaternion m_rotation;        // 0x20

    }

    // TypeToken: 0x200001B
    public class HGFactoryRenderManager
    {
        // Methods
        private UnityEngine.HyperGryph.ECS.Entity CreateRegularEntity(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc desc, System.String entityName, UnityEngine.HyperGryph.ECS.Entity gameplayEntity, UnityEngine.Material[] additiveMaterials) { }
        private System.Void UpdateRegularEntity(UnityEngine.HyperGryph.ECS.Entity gameplayEntity, UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc desc) { }
        private System.Void UpdateRegularEntityAdditiveMaterials(UnityEngine.HyperGryph.ECS.Entity gameplayEntity, UnityEngine.Material[] additiveMaterials) { }
        private System.Void DestroyRegularEntity(UnityEngine.HyperGryph.ECS.Entity gameplayEntity) { }
        private System.Void CreateBatchedEntities(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc desc, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> entities, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> gameplayEntities, System.String entityName) { }
        private System.Void DestroyBatchedEntities(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> gameplayEntities) { }
        private System.Void CreateBatchedEntities(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc desc, System.IntPtr entities, System.IntPtr gameplayEntities, System.Int32 count, System.String entityName) { }
        private System.Void DestroyBatchedEntities(System.IntPtr gameplayEntities, System.Int32 count) { }
        private System.Void SetEntityEnabledLightModes(UnityEngine.HyperGryph.ECS.Entity rendererEntity, System.UInt32 lightModeMask) { }
        private System.Void SetEntitySharedData(System.UInt32 sharedDataIndex, T data, System.Int32 offset) { }
        private System.Void SetEntitySharedDataPartial(System.UInt32 sharedDataIndex, System.IntPtr data, System.Int32 offset, System.Int32 size) { }
        private System.Byte GetEntityDirtyFlags(System.UInt32 sharedDataIndex) { }
        private System.Void SetEntityDirtyFlags(System.UInt32 sharedDataIndex, System.Byte flags) { }
        private System.Byte GetEntityObjectFlags(System.UInt32 sharedDataIndex) { }
        private System.UInt32 GetEntityAdditiveVFXFlags(System.UInt32 sharedDataIndex) { }
        private System.Void SetEntityAdditiveVFXFlags(System.UInt32 sharedDataIndex, System.UInt32 flags) { }
        private System.Void FrameUpdateEntities() { }
        private System.Void CreateRegularEntity_Injected(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc& desc, System.String entityName, UnityEngine.HyperGryph.ECS.Entity& gameplayEntity, UnityEngine.Material[] additiveMaterials, UnityEngine.HyperGryph.ECS.Entity& ret) { }
        private System.Void UpdateRegularEntity_Injected(UnityEngine.HyperGryph.ECS.Entity& gameplayEntity, UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc& desc) { }
        private System.Void UpdateRegularEntityAdditiveMaterials_Injected(UnityEngine.HyperGryph.ECS.Entity& gameplayEntity, UnityEngine.Material[] additiveMaterials) { }
        private System.Void DestroyRegularEntity_Injected(UnityEngine.HyperGryph.ECS.Entity& gameplayEntity) { }
        private System.Void CreateBatchedEntities_Injected(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc& desc, System.IntPtr entities, System.IntPtr gameplayEntities, System.Int32 count, System.String entityName) { }
        private System.Void SetEntityEnabledLightModes_Injected(UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.UInt32 lightModeMask) { }

    }

    // TypeToken: 0x200001C
    public struct HGFoliageInteractCPP
    {
        // Fields
        public System.Int32 compID;        // 0x10
        public UnityEngine.Transform transform;        // 0x18
        public UnityEngine.Mesh interactCollider;        // 0x20

    }

    // TypeToken: 0x200001D
    public struct HGFoliageInteractRaftCPP
    {
        // Fields
        public System.Int32 compID;        // 0x10
        public UnityEngine.Transform transform;        // 0x18
        public UnityEngine.Mesh interactCollider;        // 0x20

    }

    // TypeToken: 0x200001E
    public class HGFoliageInteractiveManagerV2
    {
        // Methods
        private System.Void SetupFoliageInteractiveManager(UnityEngine.Mesh characterProxyMesh, System.Boolean enabled) { }
        private System.Void CleanUpFoliageInteractiveManager() { }
        private System.Void SetEnabled(System.Boolean enabled) { }
        private System.Void SetInteractCenter(UnityEngine.Vector3 center) { }
        private System.Void SetCharacterPositions(System.Collections.Generic.List<UnityEngine.Vector3> positions) { }
        private System.Void SetCharacterPositions(UnityEngine.Vector3* positions, System.Int32 count) { }
        private System.Void RegisterInteract(UnityEngine.HyperGryph.HGFoliageInteractCPP interact) { }
        private System.Void UnregisterInteract(System.Int32 interactInstID) { }
        private System.Void RegisterInteractRaft(UnityEngine.HyperGryph.HGFoliageInteractRaftCPP raft) { }
        private System.Void UnregisterInteractRaft(System.Int32 raftInstID) { }
        private System.Void SetInteractCenter_Injected(UnityEngine.Vector3& center) { }
        private System.Void RegisterInteract_Injected(UnityEngine.HyperGryph.HGFoliageInteractCPP& interact) { }
        private System.Void RegisterInteractRaft_Injected(UnityEngine.HyperGryph.HGFoliageInteractRaftCPP& raft) { }

    }

    // TypeToken: 0x200001F
    public class HGFoliageOccluderManagerV2
    {
        // Methods
        private System.Void SetCenterPosition(UnityEngine.Vector3 center) { }
        private System.Void SetCenterPosition_Injected(UnityEngine.Vector3& center) { }

    }

    // TypeToken: 0x2000020
    public class HGFoliageOccluderRender
    {
        // Methods
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 materialHandle, System.UInt32 geometryHandle, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context) { }
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 materialHandle, System.UInt32 geometryHandle, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32* drawableFeedbackPtr) { }
        private System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList) { }

    }

    // TypeToken: 0x2000021
    public struct GpuClothClearBufferDataCPP
    {
        // Fields
        public System.Boolean shouldClear;        // 0x10
        public UnityEngine.HyperGryph.IVec4 eleNum;        // 0x14

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000022
    public struct ClothGroupUploadDataMapCPP
    {
        // Fields
        private UnityEngine.HyperGryph.IVec4 clothNodeDataMap;        // 0x10
        private UnityEngine.HyperGryph.IVec4 clothBatchMetaDataMap;        // 0x20
        private UnityEngine.HyperGryph.IVec4 clothBatchCacheDataMap;        // 0x30

    }

    // TypeToken: 0x2000023
    public struct ClothMetaDataCPP
    {
        // Fields
        private System.UInt32 clothNodeIdxStart;        // 0x10
        private System.UInt32 clothNodeIdxEnd;        // 0x14
        private System.UInt32 batchIdxStart;        // 0x18
        private System.UInt32 iterNum;        // 0x1C
        private System.Single damping;        // 0x20
        private System.Single windFreqFactor;        // 0x24
        private System.Single windBalanceFactor;        // 0x28
        private System.Single windIntensityScale;        // 0x2C
        private UnityEngine.HyperGryph.IVec4 groupOffset;        // 0x30
        private UnityEngine.Vector4 packedLongestAnchorDistance;        // 0x40
        private UnityEngine.Vector4 packedClothNormal;        // 0x50
        private UnityEngine.Vector4 localToWorld0;        // 0x60
        private UnityEngine.Vector4 localToWorld1;        // 0x70
        private UnityEngine.Vector4 localToWorld2;        // 0x80
        private UnityEngine.Vector4 worldToLocal0;        // 0x90
        private UnityEngine.Vector4 worldToLocal1;        // 0xA0
        private UnityEngine.Vector4 worldToLocal2;        // 0xB0

    }

    // TypeToken: 0x2000024
    public struct ClothNodeDataCPP
    {
        // Fields
        private UnityEngine.HyperGryph.IVec2 anchorNodeCacheIdx;        // 0x10
        private UnityEngine.Vector2 anchorNodeDistance;        // 0x18
        private UnityEngine.Vector2 uv;        // 0x20
        private UnityEngine.Vector2 collisionPlaneXY;        // 0x28
        private UnityEngine.Vector4 packedBasePosition;        // 0x30
        private UnityEngine.Vector4 packedBaseNormal;        // 0x40
        private UnityEngine.Vector4 baseTangent;        // 0x50
        private UnityEngine.Vector4 packedPrePosition;        // 0x60
        private UnityEngine.Vector4 packedCurPosition;        // 0x70
        private UnityEngine.Vector4 packedCurNormal;        // 0x80
        private UnityEngine.HyperGryph.ClothNodeDataCPP.<neighborClothNodeCacheIdx>e__FixedBuffer neighborClothNodeCacheIdx;        // 0x90
        private UnityEngine.HyperGryph.ClothNodeDataCPP.<neighborClothNodeDistance>e__FixedBuffer neighborClothNodeDistance;        // 0xB0

    }

    // TypeToken: 0x2000027
    public struct GpuClothGroupUploadDataCPP
    {
        // Fields
        public System.Boolean isValid;        // 0x10
        public System.Int32 uploadDataMapNum;        // 0x14
        public System.IntPtr uploadDataMap;        // 0x18
        public System.Int32 clothMetaUploadDataNum;        // 0x20
        public System.IntPtr clothMetaUploadData;        // 0x28
        public System.Int32 clothNodeUploadDataNum;        // 0x30
        public System.IntPtr clothNodeUploadData;        // 0x38
        public System.Int32 clothBatchMetaUploadDataNum;        // 0x40
        public System.IntPtr clothBatchMetaUploadData;        // 0x48
        public System.Int32 clothBatchCacheMapUploadDataNum;        // 0x50
        public System.IntPtr clothBatchCacheMapUploadData;        // 0x58

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000028
    public struct ClothConstDataCPP
    {
        // Fields
        private UnityEngine.Vector4 packedDeltaT;        // 0x10
        private UnityEngine.Vector4 clothParam1;        // 0x20
        private UnityEngine.HyperGryph.ClothConstDataCPP.<colliderInfos>e__FixedBuffer colliderInfos;        // 0x30

    }

    // TypeToken: 0x200002A
    public struct GpuClothRenderDataCPP
    {
        // Fields
        public System.Boolean isValid;        // 0x10
        public System.Int32 clothNum;        // 0x14
        public UnityEngine.HyperGryph.ClothConstDataCPP clothConstData;        // 0x18

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x200002B
    public class HGGpuClothManagerV2
    {
        // Methods
        private System.Void SetupGpuClothManager(UnityEngine.Mesh defaultCapsuleMesh) { }
        private System.Void SetWindDirection(UnityEngine.Vector3 direction) { }
        private System.Void SetPlayerCenter(UnityEngine.Vector3 playerCenter) { }
        private System.Void UpdateCharacterPositions(System.Collections.Generic.List<UnityEngine.Vector3> positions) { }
        private System.Void UpdateCharacterPositions(UnityEngine.Vector3* positionPtr, System.Int32 count) { }
        private System.Boolean IsClothSkeletonValid() { }
        private System.Boolean IsClothSkeletonFlipped() { }
        private System.Boolean ShouldStep() { }
        private UnityEngine.HyperGryph.GpuClothClearBufferDataCPP GetClearBufferData_CSharpWrapper() { }
        private UnityEngine.HyperGryph.GpuClothGroupUploadDataCPP GetUploadData_CSharpWrapper() { }
        private UnityEngine.HyperGryph.GpuClothRenderDataCPP GetRenderData_CSharpWrapper() { }
        private System.UInt32 GetSkeletonBufferID() { }
        private System.UInt32 GetClothNodeBufferID() { }
        private System.UInt32 GetClothMetaDataBufferID() { }
        private System.UInt32 GetClothBatchMetaDataBufferID() { }
        private System.UInt32 GetClothBatchCacheMapBufferID() { }
        private System.Void SetWindDirection_Injected(UnityEngine.Vector3& direction) { }
        private System.Void SetPlayerCenter_Injected(UnityEngine.Vector3& playerCenter) { }
        private System.Void GetClearBufferData_CSharpWrapper_Injected(UnityEngine.HyperGryph.GpuClothClearBufferDataCPP& ret) { }
        private System.Void GetUploadData_CSharpWrapper_Injected(UnityEngine.HyperGryph.GpuClothGroupUploadDataCPP& ret) { }
        private System.Void GetRenderData_CSharpWrapper_Injected(UnityEngine.HyperGryph.GpuClothRenderDataCPP& ret) { }

    }

    // TypeToken: 0x200002C
    public class HGLODStateSystem
    {
        // Methods
        private System.Boolean IsCurrFrameTriggerTransition() { }
        private System.Single GetLODTransitionFraction() { }
        private System.Single GetLODTransitionTime() { }
        private System.Void SetLODTransitionTime(System.Single lodTransitionTime) { }

    }

    // TypeToken: 0x200002D
    public struct LODStreamingStatus
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.LODStreamingStatus Idle;        // 0x0
        public static UnityEngine.HyperGryph.LODStreamingStatus Loading;        // 0x0
        public static UnityEngine.HyperGryph.LODStreamingStatus Unloading;        // 0x0
        public static UnityEngine.HyperGryph.LODStreamingStatus Disabled;        // 0x0

    }

    // TypeToken: 0x200002E
    public class HGLODStreamingSystem
    {
        // Methods
        private System.Boolean get_enableLODStreaming() { }
        private System.Void set_enableLODStreaming(System.Boolean value) { }
        private System.Void set_enableLODStreamingKeepLastLODResource(System.Boolean value) { }
        private System.Void set_lodConfig(UnityEngine.HyperGryph.LODCrossFadeConfig value) { }
        private System.Void SetArtTagLODStreamingOffset(System.UInt32 artTag, System.Int32 lodStreamingOffset) { }
        private System.Void SetHLODUnloadDistance(System.Int32 hlodLevel, System.Single unloadDistance) { }
        private System.Void set_lodStreamingLoadDirtyDistance(System.Single value) { }
        private System.Void set_lodStreamingUnloadDirtyDistance(System.Single value) { }
        private UnityEngine.HyperGryph.LODStreamingStatus QueryLODStreamingStatus() { }
        private System.Void set_lodConfig_Injected(UnityEngine.HyperGryph.LODCrossFadeConfig& value) { }

    }

    // TypeToken: 0x200002F
    public class HGShadingStateSystem
    {
        // Fields
        private static UnityEngine.Events.UnityAction<System.Int32,System.Boolean> shadingStateChanged;        // 0x0

        // Methods
        private System.UInt32 GetMaterialHandle(System.Int32 instanceId) { }
        private UnityEngine.Material GetMaterial(System.UInt32 handle) { }
        private System.Void add_shadingStateChanged(UnityEngine.Events.UnityAction<System.Int32,System.Boolean> value) { }
        private System.Void remove_shadingStateChanged(UnityEngine.Events.UnityAction<System.Int32,System.Boolean> value) { }
        private System.Void Internal_OnShadingStateChanged(System.Int32 instanceId, System.Boolean state) { }
        private System.Void FlushAllMaterialCallbacks() { }

    }

    // TypeToken: 0x2000030
    public class HGGeometrySystem
    {
        // Methods
        private System.UInt32 GetGeometryHandle(System.Int32 instanceId) { }

    }

    // TypeToken: 0x2000031
    public class HGGraphicsUtils
    {
        // Methods
        private System.Boolean get_enableRayTracing() { }
        private System.Void set_enableRayTracing(System.Boolean value) { }
        private System.Boolean get_enableRayTracingRender() { }
        private System.Void set_enableRayTracingRender(System.Boolean value) { }
        private System.Boolean get_enableECSRenderer() { }
        private System.Boolean get_enableHGNewGraphicsAPI() { }
        private System.Boolean get_enableCppRenderPath() { }
        private System.Int32 get_maxAnisoLevel() { }
        private System.Void set_maxAnisoLevel(System.Int32 value) { }
        private System.Void set_enableRenderingCommandBufferDirectCall(System.Boolean value) { }
        private UnityEngine.Rendering.CBHandle HGAllocateTempVertexBuffer(System.Int32 size) { }
        private System.UInt32 AllocateTempCompoundRendererListFromScript(System.IntPtr& outPtr) { }
        private System.Boolean IsCompoundRendererListDrawable(System.UInt32 id) { }
        private System.Void PrepareGeometryJobRenderersForRendering() { }
        private System.UInt32 CreateMetalFXSpatialScaler(System.Int32 inputWidth, System.Int32 inputWeight, System.Int32 outputWidth, System.Int32 outputHeight, UnityEngine.Experimental.Rendering.GraphicsFormat colorTextureFormat, UnityEngine.Experimental.Rendering.GraphicsFormat outputTextureFormat) { }
        private System.Void DestroyMetalFXSpatialScaler(System.UInt32 spatialScalerHandle) { }
        private System.UInt32 CreateMetalFXTemporalScaler(System.Int32 inputWidth, System.Int32 inputWeight, System.Int32 outputWidth, System.Int32 outputHeight, UnityEngine.Experimental.Rendering.GraphicsFormat colorTextureFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthTextureFormat, UnityEngine.Experimental.Rendering.GraphicsFormat motionTextureFormat, UnityEngine.Experimental.Rendering.GraphicsFormat outputTextureFormat) { }
        private System.Void DestroyMetalFXTemporalScaler(System.UInt32 temporalScalerHandle) { }
        private System.Void HGAllocateTempVertexBuffer_Injected(System.Int32 size, UnityEngine.Rendering.CBHandle& ret) { }

    }

    // TypeToken: 0x2000032
    public class HGRendererSystem
    {
        // Methods
        private System.Void set_PerRendererLightingFallbackPosition(UnityEngine.Vector3 value) { }
        private System.UInt32 get_MaxPerRendererLightingCount() { }
        private System.Void set_CSMStopRenderCharacterCascadeLevel(System.UInt32 value) { }
        private System.Void set_PerRendererLightingFallbackPosition_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x2000033
    public class HGLogicTimeManager
    {
        // Methods
        private System.Void SetLogicTickDeltaTime(System.Single deltaTime) { }
        private System.Void SetHgrpDeltaTime(System.Single deltaTime) { }

    }

    // TypeToken: 0x2000034
    public class HGGrassRender
    {
        // Methods
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context, System.Boolean noAlphaTest) { }
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32* drawableFeedbackPtr, System.Boolean noAlphaTest) { }
        private System.UInt32 RegisterGrassBatchGroup(System.UInt32 batchGroupKey, UnityEngine.Material material, UnityEngine.Mesh mesh, System.UInt16 subMeshIndex) { }
        private System.Void UnregisterGrassBatchGroupWithHandle(System.UInt32 batchGroupKey, System.UInt32 batchGroupHandle) { }
        private System.Boolean IsInGrassBoundsV2(UnityEngine.Vector3 worldPos, UnityEngine.Bounds& overlapBounds, UnityEngine.Bounds& originBounds, System.UInt32& argTag) { }
        private System.Void set_grassGlobalSparsity(System.Single value) { }
        private System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList) { }
        private System.Boolean IsInGrassBoundsV2_Injected(UnityEngine.Vector3& worldPos, UnityEngine.Bounds& overlapBounds, UnityEngine.Bounds& originBounds, System.UInt32& argTag) { }

    }

    // TypeToken: 0x2000035
    public struct EInteractionProxyType
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.HyperGryph.EInteractionProxyType Sphere;        // 0x0
        public static UnityEngine.HyperGryph.EInteractionProxyType Capsule;        // 0x0
        public static UnityEngine.HyperGryph.EInteractionProxyType Texture;        // 0x0
        public static UnityEngine.HyperGryph.EInteractionProxyType Mesh;        // 0x0

    }

    // TypeToken: 0x2000036
    public struct HGInteractionNodeV2
    {
        // Fields
        public System.Int32 m_nodeKey;        // 0x10
        public UnityEngine.HyperGryph.EInteractionProxyType m_proxyType;        // 0x14
        public UnityEngine.Matrix4x4 m_localToWorldMatrix;        // 0x18
        public UnityEngine.Matrix4x4 m_prevLocalToWorldMatrix;        // 0x58
        public System.Single m_groundHeight;        // 0x98
        public System.Boolean m_bUseCCD;        // 0x9C
        public System.Single m_length;        // 0xA0
        public System.Single m_radius;        // 0xA4
        public System.Single m_interactLength;        // 0xA8
        public System.Single m_interactHeight;        // 0xAC
        public System.Int32 m_texture;        // 0xB0
        public UnityEngine.Vector2 m_extent;        // 0xB4
        public System.Single m_heightScale;        // 0xBC
        public System.Int32 m_mesh;        // 0xC0

    }

    // TypeToken: 0x2000037
    public struct HGDecalInteractionParametersV2
    {
        // Fields
        public System.Boolean m_enableDecalInteraction;        // 0x10
        public System.IntPtr m_decalInteractionMaterial;        // 0x18
        public System.Single m_decalNodeWidth;        // 0x20
        public System.Single m_decalNodeLength;        // 0x24
        public System.Single m_decalNodeHeadLength;        // 0x28
        public System.Single m_decalNodeOffset;        // 0x2C
        public System.Single m_nodeDistanceThreshold;        // 0x30
        public System.Single m_edgeFadeDistance;        // 0x34
        public System.Single m_heightFadeDistanceMin;        // 0x38
        public System.Single m_heightFadeDistanceMax;        // 0x3C
        public System.Single m_rotationThreshold;        // 0x40
        public System.Single m_backwardDistanceThreshold;        // 0x44
        public System.Single m_timeFadeSpeed;        // 0x48

    }

    // TypeToken: 0x2000038
    public class HGInteractionManagerV2
    {
        // Methods
        private System.Void UpdateFromNodes(Unity.Collections.NativeArray<UnityEngine.HyperGryph.HGInteractionNodeV2> nodes, System.Int32 nodeCount, System.Boolean bUpdateMobile) { }
        private System.Void UpdateFromNodes(System.IntPtr nodeData, System.Int32 nodeCount, System.Boolean bUpdateMobile) { }
        private System.Void UpdateSettingParameters(UnityEngine.HyperGryph.HGDecalInteractionParametersV2 settingParameters) { }
        private System.Void UpdateSettingParameters_Injected(UnityEngine.HyperGryph.HGDecalInteractionParametersV2& settingParameters) { }

    }

    // TypeToken: 0x2000039
    public struct HGIrradianceVolumeConfig
    {
        // Fields
        public System.UInt32 enableLowQualityMode;        // 0x10
        public System.Int32 indirectionTextureSize;        // 0x14
        public System.UInt32 blockCountX;        // 0x18
        public System.UInt32 blockCountY;        // 0x1C
        public System.UInt32 blockCountZ;        // 0x20
        public System.UInt32 hashTableSize;        // 0x24
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perLOD>e__FixedBuffer perLOD;        // 0x28
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perHalfChunkCounts>e__FixedBuffer perHalfChunkCounts;        // 0x34
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perHashTableOffsets>e__FixedBuffer perHashTableOffsets;        // 0x40
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perHashTableSizes>e__FixedBuffer perHashTableSizes;        // 0x4C
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perPhysicalTextureOffsets>e__FixedBuffer perPhysicalTextureOffsets;        // 0x58
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perPhysicalTextureBlockCounts>e__FixedBuffer perPhysicalTextureBlockCounts;        // 0x64
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perFrameMaxLoadingByteCount>e__FixedBuffer perFrameMaxLoadingByteCount;        // 0x70
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perFrameMaxUploadChunkCount>e__FixedBuffer perFrameMaxUploadChunkCount;        // 0x7C
        public System.UInt32 perFrameMaxLoadingByteCountV3;        // 0x88
        public System.UInt32 perFrameMaxUploadChunkCountV3;        // 0x8C
        public System.UInt32 maxHashTableSize;        // 0x90
        public System.UInt32 maxInactiveFrameCount;        // 0x94
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<ClipmapTextureSize>e__FixedBuffer ClipmapTextureSize;        // 0x98
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<blockSizesV3>e__FixedBuffer blockSizesV3;        // 0xA4
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<cameraForwardBiasForYAxis>e__FixedBuffer cameraForwardBiasForYAxis;        // 0xB0
        public System.UInt32 maxRegionCount;        // 0xBC
        public System.Int32 regionAtlasSizeX;        // 0xC0
        public System.Int32 regionAtlasSizeY;        // 0xC4
        public System.Int32 regionAtlasSizeZ;        // 0xC8
        public System.UInt32 enableLowMemoryMode;        // 0xCC

    }

    // TypeToken: 0x2000045
    public struct HGIrradianceVolumePipelineUpdateResult
    {
        // Fields
        public UnityEngine.Vector4 param0;        // 0x10
        public UnityEngine.Vector4 param1;        // 0x20
        public UnityEngine.Vector4 param2;        // 0x30
        public UnityEngine.Vector4 param3;        // 0x40
        public UnityEngine.Texture indirectionTexture;        // 0x50
        public UnityEngine.Texture physicalTexture0;        // 0x58
        public UnityEngine.Texture physicalTexture1;        // 0x60

    }

    // TypeToken: 0x2000046
    public class HGIrradianceVolume
    {
        // Methods
        private System.Int64 Create(UnityEngine.HyperGryph.HGIrradianceVolumeConfig& config) { }
        private System.Void Destroy(System.Int64 id) { }
        private System.Void SetEnableV3(System.Boolean enable) { }
        private System.Void SetSceneStateNames(System.String[] stateNames, System.String[] activateStates) { }
        private System.Void SetActiveSceneStateNames(System.String[] activateNames) { }
        private System.Void SetActiveSceneStateMask(System.UInt32 mask) { }
        private System.String[] GetActiveSceneStateNames() { }
        private System.Void SetMap(System.Int64 id, System.String path) { }
        private System.Void SetMapV3(System.Int64 id, System.String path) { }
        private System.Void StreamingInCabin(System.Int64 id, System.String slotId, System.UInt32 roomTypeId) { }
        private System.Void StreamingOutCabin(System.Int64 id, System.String slotId) { }
        private System.Void SetStreamingCenter(System.Int64 id, UnityEngine.Vector3 center) { }
        private System.Void PipelineUpdate(UnityEngine.HyperGryph.HGIrradianceVolumePipelineUpdateResult& result, System.Int64 id, System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.Int32 bakeCS, System.Int32 updateIndirectionCS) { }
        private System.Void SetStreamingCenter_Injected(System.Int64 id, UnityEngine.Vector3& center) { }

    }

    // TypeToken: 0x2000047
    public struct HGIrradianceVolumeConfigV2
    {
        // Fields
        public System.UInt32 enableLowQualityMode;        // 0x10
        public System.Int32 clipMapTextureSizeX;        // 0x14
        public System.Int32 clipMapTextureSizeY;        // 0x18
        public System.Int32 clipMapTextureSizeZ;        // 0x1C
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<basisBaseGridDim>e__FixedBuffer basisBaseGridDim;        // 0x20
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<basisVoxelDataDim>e__FixedBuffer basisVoxelDataDim;        // 0x38
        public System.UInt32 coeffBaseGridDim;        // 0x50
        public System.UInt32 coeffVoxelDataDim;        // 0x54
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perCoeffLodBudget>e__FixedBuffer perCoeffLodBudget;        // 0x58
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBasisLodBudget>e__FixedBuffer perBasisLodBudget;        // 0x64
        public System.UInt32 lod3BaseGridDim;        // 0x70
        public System.UInt32 lod3VoxelDataDim;        // 0x74
        public System.UInt32 lod3Budget;        // 0x78
        public System.UInt32 rawDataSize;        // 0x7C
        public System.UInt32 modelBufferBudget;        // 0x80
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perLOD>e__FixedBuffer perLOD;        // 0x84
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perHalfStreamingChunkCountsX>e__FixedBuffer perHalfStreamingChunkCountsX;        // 0x90
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perHalfStreamingChunkCountsY>e__FixedBuffer perHalfStreamingChunkCountsY;        // 0x9C
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perHalfStreamingChunkCountsZ>e__FixedBuffer perHalfStreamingChunkCountsZ;        // 0xA8
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perRawBufferOffsets>e__FixedBuffer perRawBufferOffsets;        // 0xB4
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perRawBufferCounts>e__FixedBuffer perRawBufferCounts;        // 0xC0
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBlockInfoBufferOffsets>e__FixedBuffer perBlockInfoBufferOffsets;        // 0xCC
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBlockInfoSize>e__FixedBuffer perBlockInfoSize;        // 0xD8
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBasisTextureOffset>e__FixedBuffer perBasisTextureOffset;        // 0xE4
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBasisTextureBlockCounts>e__FixedBuffer perBasisTextureBlockCounts;        // 0xF0
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perCoeffTextureOffset>e__FixedBuffer perCoeffTextureOffset;        // 0xFC
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perCoeffTextureBlockCounts>e__FixedBuffer perCoeffTextureBlockCounts;        // 0x108
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perFrameMaxLoadingByteCount>e__FixedBuffer perFrameMaxLoadingByteCount;        // 0x114
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perFrameMaxUploadChunkCount>e__FixedBuffer perFrameMaxUploadChunkCount;        // 0x120
        public System.UInt32 maxRegionCount;        // 0x12C
        public System.UInt32 regionAtlasSizeX;        // 0x130
        public System.UInt32 regionAtlasSizeY;        // 0x134
        public System.UInt32 regionAtlasSizeZ;        // 0x138
        public UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<streamingCenterBias>e__FixedBuffer streamingCenterBias;        // 0x13C

    }

    // TypeToken: 0x200005B
    public struct HGIrradianceVolumePipelineUpdateResultV2
    {
        // Fields
        public UnityEngine.Vector4 param0;        // 0x10
        public UnityEngine.Vector4 param1;        // 0x20
        public UnityEngine.Vector4 param2;        // 0x30
        public UnityEngine.Vector4 param3;        // 0x40
        public UnityEngine.Texture clipmapTextureALod0;        // 0x50
        public UnityEngine.Texture clipmapTextureBLod0;        // 0x58
        public UnityEngine.Texture clipmapTextureALod1;        // 0x60
        public UnityEngine.Texture clipmapTextureBLod1;        // 0x68
        public UnityEngine.Texture clipmapTextureALod3;        // 0x70
        public UnityEngine.Texture clipmapTextureBLod3;        // 0x78

    }

    // TypeToken: 0x200005C
    public class HGIrradianceVolumeV2
    {
        // Methods
        private System.Int64 Create(UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2& config) { }
        private System.Void Destroy(System.Int64 id) { }
        private System.Void SetSceneStateNames(System.String[] stateNames, System.String[] activateStates) { }
        private System.Void SetActiveSceneStateNames(System.String[] activateStates) { }
        private System.Void SetActiveSceneStateMask(System.UInt32 mask) { }
        private System.String[] GetActiveSceneStateNames() { }
        private System.Void SetMap(System.Int64 id, System.String path) { }
        private System.Void SetStreamingCenter(System.Int64 id, UnityEngine.Vector3 center) { }
        private System.Void SetCameraForwardDirection(System.Int64 id, UnityEngine.Vector3 cameraForwardDir) { }
        private System.Void PipelineUpdate(UnityEngine.HyperGryph.HGIrradianceVolumePipelineUpdateResultV2& result, System.Int64 id, System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.Int32 bakeCS, System.Int32 updateClipmapCS) { }
        private System.Void StreamingInCabin(System.Int64 id, System.Int64 slotId, System.UInt32 roomTypeId) { }
        private System.Void StreamingOutCabin(System.Int64 id, System.Int64 slotId) { }
        private System.Void SetStreamingCenter_Injected(System.Int64 id, UnityEngine.Vector3& center) { }
        private System.Void SetCameraForwardDirection_Injected(System.Int64 id, UnityEngine.Vector3& cameraForwardDir) { }

    }

    // TypeToken: 0x200005D
    public class HGMeshRender
    {
        // Methods
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.UInt16 globalKeywords, System.IntPtr context, System.Boolean multiDraw, System.Boolean transparentSorting, System.UInt32 cullingLayerMask, System.Boolean noAlphaTest, System.UInt32* drawableFeedbackPtr, System.Boolean excludeGPUDriven) { }
        private System.Void CreateRendererListWithPreZ(System.UInt32 viewHandle, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32& normalList, System.UInt32& preZPart0List, System.UInt32& preZPart1List, System.Boolean excludeGPUDriven) { }
        private System.UInt32 CreateRendererListWithCharacterIndex(System.UInt32 viewHandle, System.UInt16 characterIndex, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.UInt16 globalHGKeywords, System.IntPtr context) { }
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, UnityEngine.HyperGryph.HGRenderKeyword globalKeywords, System.IntPtr context, System.Boolean multiDraw, System.Boolean transparentSorting, System.UInt32 cullingLayerMask, System.Boolean noAlphaTest, System.Boolean excludeGPUDriven) { }
        private System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, UnityEngine.HyperGryph.HGRenderKeyword globalKeywords, System.IntPtr context, System.IntPtr drawableFeedbackPtr, System.Boolean multiDraw, System.Boolean transparentSorting, System.UInt32 cullingLayerMask, System.Boolean noAlphaTest, System.Boolean excludeGPUDriven) { }
        private System.UInt32 CreateRendererListWithCharacterIndex(System.UInt32 viewHandle, System.UInt16 characterIndex, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, UnityEngine.HyperGryph.HGRenderKeyword globalKeywords, System.IntPtr context) { }
        private System.Void CreateRendererListWithPreZ(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context, System.UInt32& normalList, System.UInt32& preZPart0List, System.UInt32& preZPart1List, System.Boolean excludeGPUDriven) { }
        private System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList) { }
        private System.Void DrawECSMeshRendererListWithSRPRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 ecsList, UnityEngine.Rendering.RendererUtils.RendererList srpList) { }

    }

    // TypeToken: 0x200005E
    public class HGRayTracingScene
    {
        // Methods
        private System.UInt32 AddCullViewHandle(System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig config, System.Single viewScreenSizeMinSquared, System.Single cullingRadius) { }
        private System.UInt32 PrepareTLASCreationForCullView(System.UInt32 viewHandle) { }
        private System.UInt32 AddCullViewHandle_Injected(System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig& config, System.Single viewScreenSizeMinSquared, System.Single cullingRadius) { }

    }

    // TypeToken: 0x200005F
    public class HGReflectionProbe
    {
        // Methods
        private System.Single get_cameraMovementNotFadeness() { }
        private System.Single get_fadeTime() { }
        private System.UInt32 AddView(UnityEngine.Camera camera) { }
        private System.Void RemoveView(System.UInt32 viewHandle) { }
        private System.Void ResetView(System.UInt32 viewHandle) { }
        private System.Void UpdateViewPhase0(System.UInt32 viewHandle, UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 visibleBox, System.Boolean loadSync) { }
        private System.Void UpdateViewPhase1(System.UInt32 viewHandle, System.Single dt, System.Boolean enableFadeness, System.IntPtr blitList, System.Int32 maxBlitCount, System.Int32& blitCount) { }
        private System.Void UpdateViewCBHandle(System.UInt32 viewHandle, UnityEngine.Matrix4x4 worldToCameraMatrix, UnityEngine.Matrix4x4 unitExtents, System.IntPtr binningBufferPtr, System.IntPtr globalBufferPtr) { }
        private UnityEngine.Texture GetTexture(System.UInt32 viewHandle, System.UInt64 hash) { }
        private System.Int32 GetTextureIndex(System.UInt32 viewHandle, System.UInt64 hash) { }
        private System.Void SetViewTextureArrayCount(System.UInt32 viewHandle, System.Int32 count) { }
        private System.Void UpdateViewPhase0_Injected(System.UInt32 viewHandle, UnityEngine.Vector3& cameraPosition, UnityEngine.Vector3& visibleBox, System.Boolean loadSync) { }
        private System.Void UpdateViewCBHandle_Injected(System.UInt32 viewHandle, UnityEngine.Matrix4x4& worldToCameraMatrix, UnityEngine.Matrix4x4& unitExtents, System.IntPtr binningBufferPtr, System.IntPtr globalBufferPtr) { }

    }

    // TypeToken: 0x2000060
    public struct AssetType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HyperGryph.AssetType Invalid;        // 0x0
        public static UnityEngine.HyperGryph.AssetType Material;        // 0x0
        public static UnityEngine.HyperGryph.AssetType Mesh;        // 0x0
        public static UnityEngine.HyperGryph.AssetType Texture2D;        // 0x0
        public static UnityEngine.HyperGryph.AssetType Texture3D;        // 0x0
        public static UnityEngine.HyperGryph.AssetType CubeMap;        // 0x0
        public static UnityEngine.HyperGryph.AssetType ScriptableObject;        // 0x0
        public static UnityEngine.HyperGryph.AssetType Shader;        // 0x0
        public static UnityEngine.HyperGryph.AssetType ComputeShader;        // 0x0
        public static UnityEngine.HyperGryph.AssetType TerrainLayer;        // 0x0
        public static UnityEngine.HyperGryph.AssetType SubsurfaceProfile;        // 0x0
        public static UnityEngine.HyperGryph.AssetType Count;        // 0x0

    }

    // TypeToken: 0x2000061
    public struct AssetPriority
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static UnityEngine.HyperGryph.AssetPriority Preload;        // 0x0
        public static UnityEngine.HyperGryph.AssetPriority LODStreaming;        // 0x0
        public static UnityEngine.HyperGryph.AssetPriority Default;        // 0x0
        public static UnityEngine.HyperGryph.AssetPriority Streaming;        // 0x0

    }

    // TypeToken: 0x2000062
    public struct AssetState
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.AssetState Loading;        // 0x0
        public static UnityEngine.HyperGryph.AssetState Loaded;        // 0x0
        public static UnityEngine.HyperGryph.AssetState Failed;        // 0x0

    }

    // TypeToken: 0x2000063
    public struct VFSBlockFileInfo
    {
        // Fields
        public System.UInt64 offset;        // 0x10
        public System.UInt64 len;        // 0x18
        public System.String chunkFilePath;        // 0x20

    }

    // TypeToken: 0x2000064
    public struct AssetIdentifier
    {
        // Fields
        public System.Int64 hash;        // 0x10
        public UnityEngine.HyperGryph.AssetType type;        // 0x18

    }

    // TypeToken: 0x2000065
    public struct AssetOperation
    {
        // Fields
        public System.Boolean isLoadOperation;        // 0x10
        public UnityEngine.HyperGryph.AssetPriority priority;        // 0x12
        public System.UInt32 handleIndex;        // 0x14
        public UnityEngine.HyperGryph.AssetIdentifier identifier;        // 0x18

    }

    // TypeToken: 0x2000066
    public class HGResourceManager
    {
        // Fields
        public static UnityEngine.HyperGryph.HGResourceManager.GetFileHashMappingCallback getFileHashMappingCallback;        // 0x0
        public static UnityEngine.HyperGryph.HGResourceManager.GetFilePathMappingCallback getFilePathMappingCallback;        // 0x8
        public static UnityEngine.HyperGryph.HGResourceManager.GetTextureFromHGWaterSectorDataCallback getWaterSectorTextureCallback;        // 0x10
        private static readonly System.Type[] kAssetTypeToUnityType;        // 0x18

        // Methods
        private System.Void set_usingVFS(System.Boolean value) { }
        private System.UInt32 LoadAsync(System.Int64 assetHash, UnityEngine.HyperGryph.AssetType type, UnityEngine.HyperGryph.AssetPriority priority) { }
        private System.Void Dispose(System.UInt32 assetHandle) { }
        private UnityEngine.HyperGryph.AssetState GetAssetState(System.UInt32 assetHandle) { }
        private UnityEngine.Object GetAsset(System.UInt32 assetHandle) { }
        private System.Boolean TryGetAsset(System.UInt32 assetHandle, T& asset) { }
        private System.Void UpdateAssetHandle(System.UInt32 handleIndex, UnityEngine.HyperGryph.AssetIdentifier identifier, UnityEngine.HyperGryph.AssetState state, System.Int32 assetInstanceID) { }
        private System.IntPtr get_assetOperations() { }
        private System.Int32 get_assetOperationCount() { }
        private System.Void ClearAssetOperations() { }
        private System.Void Reset() { }
        private UnityEngine.HyperGryph.VFSBlockFileInfo GetFileHashMapping(System.Int64 originNameHash) { }
        private UnityEngine.HyperGryph.VFSBlockFileInfo GetFilePathMapping(System.String originName) { }
        private UnityEngine.Texture2D GetTextureFromHGWaterSectorData(UnityEngine.ScriptableObject sectorDataScriptableObject) { }
        private System.Type ToUnityType(UnityEngine.HyperGryph.AssetType type) { }
        private Unity.Collections.NativeArray<UnityEngine.HyperGryph.AssetOperation> GetAssetOperationsArray() { }
        private System.Void .cctor() { }
        private System.Void UpdateAssetHandle_Injected(System.UInt32 handleIndex, UnityEngine.HyperGryph.AssetIdentifier& identifier, UnityEngine.HyperGryph.AssetState state, System.Int32 assetInstanceID) { }

    }

    // TypeToken: 0x200006A
    public struct HGRenderFlags
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.HyperGryph.HGRenderFlags None;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags PreZ;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags ShadowTwoSided;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags NegativeScale;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags PreZEqual;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags AlphaTest;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags Opaque;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags Transparent;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags ShadowOnly;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags TransparentBeforeDistortion;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags TransparentAfterDistortionBeforePP;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags TransparentAfterDistortion;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags TransparentAfterPP;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags HasCustomProps;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags ManualDither;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags CameraDither;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags CastShadow;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags CSMShadowCascade0;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags CSMShadowCascade1;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags CSMShadowCascade2;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags CSMShadowCascade3;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags CSMShadows;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags StaticShadowCaster;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags RealtimeShadowCaster;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags EnableCharacterOutline;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderFlags RayTracing;        // 0x0

    }

    // TypeToken: 0x200006B
    public struct HGRenderKeyword
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static UnityEngine.HyperGryph.HGRenderKeyword None;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderKeyword CrossFade;        // 0x0
        public static UnityEngine.HyperGryph.HGRenderKeyword Dither;        // 0x0

    }

    // TypeToken: 0x200006C
    public struct HGShaderLightMode
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.HyperGryph.HGShaderLightMode None;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode GBuffer;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode GBufferMobile;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode Erosion;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode ErosionMobile;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode ErosionClear;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode ForwardOnly;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode Forward;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode ForwardCharacterOnly;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode ForwardReflection;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode CharacterOutline;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode ShadowCaster;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode DepthOnly;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode DepthCharacterOnly;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode SRPDefaultUnlit;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode ForwardDecal;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode VFXDecal;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode WetnessDecal;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode Distortion;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode FullScreenDebug;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode OccludedDisplay;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode TerrainVTDecal;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode TerrainVTDecalMobile;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode RayTracingReflection;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode StencilAlphaBlend;        // 0x0
        public static UnityEngine.HyperGryph.HGShaderLightMode WaterMarkUI;        // 0x0

    }

    // TypeToken: 0x200006D
    public struct HGObjectFlags
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.HyperGryph.HGObjectFlags None;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags Enabled;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CastShadow;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags NegativeScale;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags PrevResReady;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CurrResReady;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags TempResReady;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags ResReadyMask;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags PrevHideByHLODSystem;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CurrHideByHLODSystem;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags TempHideAsHLODChildByHLODSystem;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags TempHideAsHLODParentByHLODSystem;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags TempHideByHLODSystemMask;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags HideByHLODSystemMask;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags TransformDirty;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags Static;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags ManualDither;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CameraDither;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags FoliageOccluder;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CpuSkinning;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags VertexSkinning;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags SkinningMask;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CSMShadowCascade0;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CSMShadowCascade1;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CSMShadowCascade2;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CSMShadowCascade3;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CSMShadows;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags StaticShadowCaster;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags RealtimeShadowCaster;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags ToRenderFlagMask;        // 0x0
        public static UnityEngine.HyperGryph.HGObjectFlags CanBeRenderedMask;        // 0x0

    }

    // TypeToken: 0x200006E
    public struct HGFactoryDirtyFlags
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.HGFactoryDirtyFlags None;        // 0x0
        public static UnityEngine.HyperGryph.HGFactoryDirtyFlags PerDrawData;        // 0x0
        public static UnityEngine.HyperGryph.HGFactoryDirtyFlags ObjectData;        // 0x0
        public static UnityEngine.HyperGryph.HGFactoryDirtyFlags TransformData;        // 0x0
        public static UnityEngine.HyperGryph.HGFactoryDirtyFlags VFXStatus;        // 0x0
        public static UnityEngine.HyperGryph.HGFactoryDirtyFlags VFXVisibility;        // 0x0

    }

    // TypeToken: 0x200006F
    public struct IVec2
    {
        // Fields
        public System.Int32 x;        // 0x10
        public System.Int32 y;        // 0x14

    }

    // TypeToken: 0x2000070
    public struct IVec4
    {
        // Fields
        public System.Int32 x;        // 0x10
        public System.Int32 y;        // 0x14
        public System.Int32 z;        // 0x18
        public System.Int32 w;        // 0x1C

    }

    // TypeToken: 0x2000071
    public struct SludgeNodeData
    {
        // Fields
        public System.Byte allHole;        // 0x10
        public System.Byte treeLevel;        // 0x11
        public System.UInt16 parent;        // 0x12
        public UnityEngine.Vector3 aabbCenter;        // 0x14
        public UnityEngine.Vector3 aabbExtent;        // 0x20
        public UnityEngine.HyperGryph.SludgeNodeData.<patchAABBData>e__FixedBuffer patchAABBData;        // 0x2C

    }

    // TypeToken: 0x2000073
    public struct SludgeHeightmapInfo
    {
        // Fields
        public UnityEngine.Vector4 heightmapUVOffsetScale;        // 0x10
        public UnityEngine.Texture2D heightmapAtlas;        // 0x20

    }

    // TypeToken: 0x2000074
    public class HGSludgeRender
    {
        // Methods
        private System.Boolean RegisterSludge(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.Texture2D bakedHeightmap, Unity.Collections.NativeArray<UnityEngine.HyperGryph.SludgeNodeData> nodeData) { }
        private System.Boolean RegisterSludge(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.Texture2D bakedHeightmap, System.Int32 nodeCount, System.IntPtr nodeData) { }
        private System.Void UnregisterAndDestroySludge(UnityEngine.HyperGryph.ECS.Entity entity) { }
        private System.UInt32 CreateRendererList(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, System.UInt32 viewHandle, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, UnityEngine.HyperGryph.HGShaderLightMode decalLightModeMask, System.Single lodFactor, System.IntPtr context, System.Boolean useMetric) { }
        private System.UInt32 CreateRendererList(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, System.UInt32 viewHandle, System.UInt32 lightModeMask, System.UInt32 decalLightModeMask, System.Single loadFactor, System.IntPtr context, System.Boolean useMetric) { }
        private System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList, UnityEngine.MaterialPropertyBlock customPros) { }
        private System.Void DrawECSDecalRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList, UnityEngine.MaterialPropertyBlock customProps) { }
        private System.Void DrawECSBlendRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList, UnityEngine.MaterialPropertyBlock customProps) { }
        private System.Void HitSludge(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.Vector3 worldPos, System.Single range, System.Single deltaHeightNormalized) { }
        private UnityEngine.HyperGryph.SludgeHeightmapInfo GetHeightmapInfo(UnityEngine.HyperGryph.ECS.Entity entity) { }
        private System.UInt32 GetDynamicThicknessMapSize() { }
        private System.Boolean ShouldDrawThicknessMap() { }
        private System.Void DrawThicknessMap(System.IntPtr context, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material blitMat, System.Int32 passIdx, System.Int32 viewHandle) { }
        private System.Boolean RegisterSludge_Injected(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.Texture2D bakedHeightmap, System.Int32 nodeCount, System.IntPtr nodeData) { }
        private System.Void UnregisterAndDestroySludge_Injected(UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private System.UInt32 CreateRendererList_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, System.UInt32 viewHandle, System.UInt32 lightModeMask, System.UInt32 decalLightModeMask, System.Single loadFactor, System.IntPtr context, System.Boolean useMetric) { }
        private System.Void HitSludge_Injected(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.Vector3& worldPos, System.Single range, System.Single deltaHeightNormalized) { }
        private System.Void GetHeightmapInfo_Injected(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.SludgeHeightmapInfo& ret) { }

    }

    // TypeToken: 0x2000075
    public struct SplineEmissionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HyperGryph.SplineEmissionType Box;        // 0x0
        public static UnityEngine.HyperGryph.SplineEmissionType Mesh;        // 0x0

    }

    // TypeToken: 0x2000076
    public struct SplineEmissionMeshType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HyperGryph.SplineEmissionMeshType Triangle;        // 0x0
        public static UnityEngine.HyperGryph.SplineEmissionMeshType Vertex;        // 0x0
        public static UnityEngine.HyperGryph.SplineEmissionMeshType Edge;        // 0x0

    }

    // TypeToken: 0x2000077
    public struct SplineObjectsDesc
    {
        // Fields
        public System.String name;        // 0x10
        public System.Boolean useLogicDeltaTime;        // 0x18
        public System.Boolean prewarm;        // 0x19
        public System.Boolean has3dStartRotation;        // 0x1A
        public System.Boolean hasNoise;        // 0x1B
        public System.Boolean hasAlphaControl;        // 0x1C
        public System.Boolean hasRotation;        // 0x1D
        public System.Boolean has3dRotation;        // 0x1E
        public System.Single simulateSpeed;        // 0x20
        public System.Single emissionRateOverTime;        // 0x24
        public System.Single transparentAlpha;        // 0x28
        public UnityEngine.Vector3 emissionMeshScale;        // 0x2C
        public UnityEngine.HyperGryph.SplineEmissionType emissionType;        // 0x38
        public UnityEngine.HyperGryph.SplineEmissionMeshType emissionMeshType;        // 0x3C
        public UnityEngine.Matrix4x4 objectToWorld;        // 0x40
        public UnityEngine.Bounds aabb;        // 0x80
        public System.UInt64 sceneMask;        // 0x98
        public UnityEngine.Mesh emissionMesh;        // 0xA0
        public UnityEngine.LODGroup[] lodGroups;        // 0xA8
        public UnityEngine.ParticleSystem.MinMaxCurve startLifeTime;        // 0xB0
        public UnityEngine.ParticleSystem.MinMaxCurve startSize;        // 0xD0
        public UnityEngine.ParticleSystem.MinMaxCurve rotationOverLifeTime;        // 0xF0
        public UnityEngine.ParticleSystem.MinMaxCurve rotationXOverLifeTime;        // 0x110
        public UnityEngine.ParticleSystem.MinMaxCurve rotationYOverLifeTime;        // 0x130
        public UnityEngine.ParticleSystem.MinMaxCurve startRotationX;        // 0x150
        public UnityEngine.ParticleSystem.MinMaxCurve startRotationY;        // 0x170
        public UnityEngine.ParticleSystem.MinMaxCurve startRotationZ;        // 0x190
        public UnityEngine.ParticleSystem.MinMaxCurve sizeOverLifeTime;        // 0x1B0
        public UnityEngine.ParticleSystem.MinMaxCurve velocityOverLifeTime;        // 0x1D0
        public UnityEngine.ParticleSystem.MinMaxCurve alphaOverLifeTime;        // 0x1F0
        public UnityEngine.ParticleSystem.MinMaxCurve noiseAmplitudeLifeTime;        // 0x210
        public UnityEngine.ParticleSystem.MinMaxCurve noiseFrequencyLifeTime;        // 0x230

    }

    // TypeToken: 0x2000078
    public struct SplineObjectsKnotData
    {
        // Fields
        public UnityEngine.Vector3 p0;        // 0x10
        public UnityEngine.Vector3 p1;        // 0x1C
        public UnityEngine.Vector3 p2;        // 0x28
        public UnityEngine.Vector3 p3;        // 0x34
        public System.Single length;        // 0x40

    }

    // TypeToken: 0x2000079
    public class HGSplineMovingObjectsManager
    {
        // Methods
        private System.UInt32 CreateInstance(UnityEngine.HyperGryph.SplineObjectsDesc desc, Unity.Collections.NativeArray<UnityEngine.HyperGryph.SplineObjectsKnotData> curveData) { }
        private System.Boolean DestroyInstance(System.UInt32 instanceID) { }
        private System.Boolean UpdateObjectToWorld(System.UInt32 instanceID, UnityEngine.Matrix4x4 objectToWorld) { }
        private System.Boolean Pause(System.UInt32 instanceID) { }
        private System.UInt32 CreateInstance(UnityEngine.HyperGryph.SplineObjectsDesc desc, UnityEngine.HyperGryph.SplineObjectsKnotData* curveData, System.Int32 length) { }
        private System.Boolean UpdateObjectToWorld_Injected(System.UInt32 instanceID, UnityEngine.Matrix4x4& objectToWorld) { }
        private System.UInt32 CreateInstance_Injected(UnityEngine.HyperGryph.SplineObjectsDesc& desc, UnityEngine.HyperGryph.SplineObjectsKnotData* curveData, System.Int32 length) { }

    }

    // TypeToken: 0x200007A
    public class HGSubsurfaceProfileManager
    {
        // Methods
        private System.Void RegisterFromTerrain(UnityEngine.HGSubsurfaceProfile profile) { }
        private System.Void UnregisterFromTerrain() { }

    }

    // TypeToken: 0x200007B
    public struct TerrainNodePayload
    {
        // Fields
        public UnityEngine.Texture2D heightmapPage;        // 0x10
        public UnityEngine.Texture2D normalmapPage;        // 0x18
        public UnityEngine.Texture2D tintColorPage;        // 0x20
        public UnityEngine.Texture2D splatCtrlPage;        // 0x28
        public UnityEngine.Texture2D albedoPage;        // 0x30

    }

    // TypeToken: 0x200007C
    public struct TerrainSplatPayload
    {
        // Fields
        public UnityEngine.Texture2D diffuseTex;        // 0x10
        public UnityEngine.Texture2D normalROTex;        // 0x18
        public UnityEngine.Texture2D coneMapTex;        // 0x20

    }

    // TypeToken: 0x200007D
    public struct TerrainInfo
    {
        // Fields
        public UnityEngine.Vector3 terrainPosition;        // 0x10
        public System.Single heightScale;        // 0x1C
        public System.UInt32 terrainSize;        // 0x20
        public System.UInt16 heightmapPageSize;        // 0x24
        public System.UInt16 normalmapPageSize;        // 0x26
        public System.UInt16 tintColorPageSize;        // 0x28
        public System.UInt16 splatCtrlPageSize;        // 0x2A
        public System.UInt16 albedoTexPageSize;        // 0x2C

    }

    // TypeToken: 0x200007E
    public struct TerrainNodeData
    {
        // Fields
        public System.Byte allHole;        // 0x10
        public System.Byte nodeLevel;        // 0x11
        public System.UInt16 parent;        // 0x12
        public System.Single localMinHeight;        // 0x14
        public System.Single localMaxHeight;        // 0x18
        public System.Single maxHeightError;        // 0x1C

    }

    // TypeToken: 0x200007F
    public struct SplatLayerData
    {
        // Fields
        public UnityEngine.Vector4 packedSplatInfo;        // 0x10
        public UnityEngine.Vector4 splatST;        // 0x20
        public UnityEngine.Vector4 diffuseRemapScale;        // 0x30
        public UnityEngine.Vector4 maskMapRemapOffset;        // 0x40
        public UnityEngine.Vector4 maskMapRemapScale;        // 0x50
        public UnityEngine.Vector4 packedDeformParams;        // 0x60
        public UnityEngine.Vector4 pomParams;        // 0x70

    }

    // TypeToken: 0x2000080
    public class HGTerrainManager
    {
        // Methods
        private System.Void ReadbackVTFeedbackBuffer(System.Int32 feedbackViewId, UnityEngine.Rendering.CommandBuffer cmd, System.IntPtr renderContext) { }
        private System.Void* GetTerrainNodesForCanceling(System.Int32& length) { }
        private System.Void* GetTerrainNodesForStreaming(System.Int32& length) { }
        private System.UInt64 GetTerrainSplatsForCanceling() { }
        private System.UInt64 GetTerrainSplatsForStreaming() { }
        private System.Void ResetTerrainNodesForCanceling() { }
        private System.Void ResetTerrainNodesForStreaming() { }
        private System.Void ResetTerrainSplatsForCanceling() { }
        private System.Void ResetTerrainSplatsForStreaming() { }
        private System.Boolean StreamingInTerrainNodePayload(System.UInt32 nodeKey, UnityEngine.HyperGryph.TerrainNodePayload& payload) { }
        private System.Void StreamingInTerrainSplat(System.UInt32 splatIdx, UnityEngine.HyperGryph.TerrainSplatPayload payload) { }
        private System.Void ResetLoadingStatusForAllNodes() { }
        private System.Void ResetLoadingStatusForAllSplats() { }
        private System.Void SetupTerrainManager(UnityEngine.HyperGryph.TerrainInfo& terrainInfo, UnityEngine.ComputeShader terrainCS, UnityEngine.ComputeShader terrainRTCS, UnityEngine.Shader terrainPS, UnityEngine.Texture2D splatIndexMap, Unity.Collections.NativeArray<UnityEngine.HyperGryph.SplatLayerData> layerData, UnityEngine.Texture2D[] splatDiffuseTextures, UnityEngine.Texture2D[] splatNormalTextures, UnityEngine.Texture2D[] splatConeMapTextures, System.Int32 splatTier, Unity.Collections.NativeArray<UnityEngine.HyperGryph.TerrainNodeData> nodeData, Unity.Collections.NativeArray<System.UInt64> sectorSplatInfo, System.Boolean enableHalfVTSize, System.Boolean enableHalfAtlasSize, UnityEngine.Experimental.Rendering.GraphicsFormat mobileSplatCtrlAtlasFormat, System.Boolean enableIndirectionCpuUpload) { }
        private System.Void SetupTerrainManager(UnityEngine.HyperGryph.TerrainInfo& terrainInfo, UnityEngine.ComputeShader terrainCS, UnityEngine.ComputeShader terrainRTCS, UnityEngine.Shader terrainPS, UnityEngine.Texture2D splatIndexMap, System.Int32 layerCount, System.IntPtr layerData, UnityEngine.Texture2D[] splatDiffuseTextures, UnityEngine.Texture2D[] splatNormalTextures, UnityEngine.Texture2D[] splatConeMapTextures, System.Int32 splatTier, System.Int32 nodeCount, System.IntPtr nodeData, System.Int32 sectorCount, System.IntPtr sectorSplatInfo, System.Boolean enableHalfVTSize, System.Boolean enableHalfAtlasSize, UnityEngine.Experimental.Rendering.GraphicsFormat mobileSplatCtrlAtlasFormat, System.Boolean enableIndirectionCpuUpload) { }
        private System.Void CleanupTerrainManager() { }
        private System.UInt32 CullTerrainAndUpdateVTFeedbackView(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, UnityEngine.Matrix4x4 viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext, System.UInt32 viewHandle, System.Int32 feedbackViewId, UnityEngine.Vector3 vtUpdateCenter) { }
        private System.UInt32 CullTerrain(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, UnityEngine.Matrix4x4 viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext) { }
        private System.Void PrepareDecalRendererListsForVTPages(System.Int32 feedbackViewId, System.IntPtr renderContext) { }
        private System.Void ExecuteVTUpdateCommand(System.Int32 feedbackViewId, System.IntPtr renderContext) { }
        private System.Void RenderVTPages(System.Int32 feedbackViewId, System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer copyCmd, UnityEngine.Rendering.CommandBuffer renderCmd, System.Int32 bakePassIndex, System.Int32 bc3PassIndex, System.Int32 astcPassIndex, System.Int32 bc5PassIndex) { }
        private System.Void RenderScreenSpaceTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId, System.Int32 passIndex, System.IntPtr features) { }
        private System.Void RenderTerrainAfterGBuffer(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId, System.IntPtr features) { }
        private System.Void UpdateSubdivisionParameters(System.Int32 mode, System.Int32 modeV2, System.Int32 subd, System.Int32 primitivePixelLengthTargetLog2) { }
        private System.Void SetTerrainBlendBindings(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId) { }
        private System.Void SetDecalDeformBindings(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId) { }
        private UnityEngine.Texture2D GetHeightmapAtlas() { }
        private UnityEngine.Texture2D GetNormalmapAtlas() { }
        private UnityEngine.Texture2D GetTintColorAtlas() { }
        private UnityEngine.Texture2D GetSplatControlAtlas() { }
        private UnityEngine.Texture2D GetAlbedoAtlas() { }
        private UnityEngine.Texture2D GetSplatIndexMap() { }
        private UnityEngine.Texture2DArray GetSplatDiffuseArray() { }
        private UnityEngine.Texture2DArray GetSplatNormalROArray() { }
        private UnityEngine.Rendering.CBHandle GetSplatDataUBO() { }
        private System.Void SubdivisionTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 subdivisionHandle, System.Boolean enableSubdivision, System.Boolean enableSubdivisionV2, UnityEngine.Texture HZBTexture) { }
        private System.Void RenderTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 subdivisionHandle, System.Int32 passIndex, System.Int32 tessellationPassIndex, System.Int32 subdivisionPassIndex, System.Boolean enableSubdivisionV2) { }
        private System.Void StreamingInChunkSurfaceTypeData(System.UInt32 chunkKey, System.UIntPtr chunkSurfaceTypeData, System.Int32 dataLength, System.Int32 chunkSize) { }
        private System.Void StreamingOutChunkSurfaceTypeData(System.UInt32 chunkKey) { }
        private System.Boolean GetSurfaceTypeByWorldPosition(System.Single x, System.Single y, System.Int32& surfaceType) { }
        private System.Void set_minVerticalFieldOfView(System.Single value) { }
        private System.Void StreamingInTerrainSplat_Injected(System.UInt32 splatIdx, UnityEngine.HyperGryph.TerrainSplatPayload& payload) { }
        private System.UInt32 CullTerrainAndUpdateVTFeedbackView_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, UnityEngine.Matrix4x4& viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext, System.UInt32 viewHandle, System.Int32 feedbackViewId, UnityEngine.Vector3& vtUpdateCenter) { }
        private System.UInt32 CullTerrain_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, UnityEngine.Matrix4x4& viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext) { }
        private System.Void GetSplatDataUBO_Injected(UnityEngine.Rendering.CBHandle& ret) { }

    }

    // TypeToken: 0x2000081
    public class HGEditorTerrainManager
    {
        // Methods
        private System.Void SetUseNewEditorTerrainRendering(System.Boolean value) { }
        private System.UInt32 CullTerrainAndUpdateVTFeedbackView(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, UnityEngine.Matrix4x4 viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext, System.UInt32 viewHandle, System.Int32 feedbackViewId, UnityEngine.Vector3 vtUpdateCenter) { }
        private System.UInt32 CullTerrain(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, UnityEngine.Matrix4x4 viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext) { }
        private System.Void SetTerrainBlendBindings(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId) { }
        private System.Void RenderTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 subdivisionHandle, System.Int32 passIndex, System.Int32 subdivisionPassIndex, System.Boolean enableSubdivisionV2) { }
        private System.Void RenderScreenSpaceTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId, System.Int32 passIndex, System.IntPtr features) { }
        private System.Void RenderSeparateTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 passIndex, System.IntPtr features) { }
        private System.Void RenderTerrainAfterGBuffer(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId, System.IntPtr features) { }
        private System.Void BakeAtlasTexture(UnityEngine.Rendering.CommandBuffer cmd, System.IntPtr renderContext) { }
        private System.Void PrepareDecalRendererListsForVTPages(System.Int32 feedbackViewId, System.IntPtr renderContext) { }
        private System.Void ExecuteVTUpdateCommand(System.Int32 feedbackViewId, System.IntPtr renderContext) { }
        private System.Void RenderVTPages(System.Int32 feedbackViewId, System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer copyCmd, UnityEngine.Rendering.CommandBuffer renderCmd, System.Int32 bakePass, System.Int32 bc3Pass, System.Int32 astcPass) { }
        private System.Void ReadbackVTFeedbackBuffer(System.Int32 feedbackViewId, UnityEngine.Rendering.CommandBuffer cmd, System.IntPtr renderContext) { }
        private System.UInt32 CullTerrainAndUpdateVTFeedbackView_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, UnityEngine.Matrix4x4& viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext, System.UInt32 viewHandle, System.Int32 feedbackViewId, UnityEngine.Vector3& vtUpdateCenter) { }
        private System.UInt32 CullTerrain_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, UnityEngine.Matrix4x4& viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext) { }

    }

    // TypeToken: 0x2000082
    public struct HGTerrainDeformConfigV2
    {
        // Fields
        public System.Single m_deformGlobalStrength;        // 0x10
        public System.Single m_latency;        // 0x14

    }

    // TypeToken: 0x2000083
    public class HGTerrainDeformManagerV2
    {
        // Methods
        private System.Void SetPlayerCenter(UnityEngine.Vector3 position) { }
        private System.Void UpdateDeformConfig(UnityEngine.HyperGryph.HGTerrainDeformConfigV2 config) { }
        private System.Void SetPlayerCenter_Injected(UnityEngine.Vector3& position) { }
        private System.Void UpdateDeformConfig_Injected(UnityEngine.HyperGryph.HGTerrainDeformConfigV2& config) { }

    }

    // TypeToken: 0x2000084
    public class HGUIRender
    {
        // Methods
        private System.UInt32 CreateRendererList(System.UInt32 cullingLayerMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.Int16 sortingOrderMin, System.Int16 sortingOrderMax, System.Int32 cameraInstanceID, System.IntPtr context, System.Boolean isWorldUI, System.Single wolrdUICullingDistance) { }
        private System.UInt32 CreateRendererList(System.UInt32 cullingLayerMask, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.Int16 sortingOrderMin, System.Int16 sortingOrderMax, System.Int32 cameraInstanceID, System.IntPtr context, System.Boolean isWorldUI, System.Single wolrdUICullingDistance) { }

    }

    // TypeToken: 0x2000085
    public class HGWaterRender
    {
        // Methods
        private System.Void CullWaterProxy(System.UInt32 viewHandle, UnityEngine.Matrix4x4 viewProj, System.UInt32 cullingMask, System.Boolean useOC, System.UInt32& visibleCount, System.UInt32& cullHandle) { }
        private System.Void CullWaterDecals(System.UInt32 viewHandle, UnityEngine.Matrix4x4 viewProj, System.UInt32& visibleCount, System.UInt32& cullHandle) { }
        private System.Void DrawWaterProxy(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 cullHandle, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPass, System.Int32 nameID, System.Boolean clear, System.UInt32 renderTypeMask) { }
        private System.Void DrawWaterDecals(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 cullHandle, UnityEngine.MaterialPropertyBlock properties, System.Int32 nameID, System.Boolean clear, System.Int32 shaderPass, System.UInt32 renderTypeMask) { }
        private System.Boolean IsHGWaterGloablConfigValidCPP() { }
        private System.Boolean CheckNewHGWaterGloablConfigCPP(System.String scenePath) { }
        private System.Void UpdateHGWaterGloablConfigCPP(System.String scenePath, System.Int32 sectorNum, System.Int32 sectorSize, System.Int32 sectorCoordsMin, System.Int32 sectorCoordsMax, System.Int64[] sectorDataGUIDs, System.Boolean[] sectorDataExists) { }
        private System.Void AddSectorTexture(System.Int32 id, System.Int32 textureID) { }
        private System.Void RemoveSectorTexture(System.Int32 id) { }
        private System.Void CullWaterProxy_Injected(System.UInt32 viewHandle, UnityEngine.Matrix4x4& viewProj, System.UInt32 cullingMask, System.Boolean useOC, System.UInt32& visibleCount, System.UInt32& cullHandle) { }
        private System.Void CullWaterDecals_Injected(System.UInt32 viewHandle, UnityEngine.Matrix4x4& viewProj, System.UInt32& visibleCount, System.UInt32& cullHandle) { }

    }

}

namespace UnityEngine.HyperGryph.ECS
{

    // TypeToken: 0x20000A8
    public struct ECSExplicitEntityType
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.HyperGryph.ECS.ECSExplicitEntityType Unknown;        // 0x0
        public static UnityEngine.HyperGryph.ECS.ECSExplicitEntityType MeshRenderer;        // 0x0
        public static UnityEngine.HyperGryph.ECS.ECSExplicitEntityType ReflectionProbe;        // 0x0
        public static UnityEngine.HyperGryph.ECS.ECSExplicitEntityType WaterRenderer;        // 0x0
        public static UnityEngine.HyperGryph.ECS.ECSExplicitEntityType FactoryRenderer;        // 0x0
        public static UnityEngine.HyperGryph.ECS.ECSExplicitEntityType HGDecalProjector;        // 0x0

    }

    // TypeToken: 0x20000A9
    public struct EntityInstanceData
    {
        // Fields
        public System.UInt32 entityType;        // 0x10
        public System.Int32 entityIdx;        // 0x14
        public System.UInt32 version;        // 0x18
        public System.UInt32 padding;        // 0x1C

    }

    // TypeToken: 0x20000AA
    public struct ComponentType
    {
        // Fields
        public System.UInt64 value;        // 0x10
        public System.Int16 componentID;        // 0x10
        public System.Int16 componentSize;        // 0x12
        public System.Int32 offset;        // 0x14

    }

    // TypeToken: 0x20000AB
    public struct ComponentMask
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.ComponentMask.<componentMaskWords>e__FixedBuffer componentMaskWords;        // 0x10

        // Methods
        private System.Boolean ContainsComponentId(System.Int32 id) { }
        private System.Boolean ContainsComponentMask(UnityEngine.HyperGryph.ECS.ComponentMask& other) { }
        private System.Boolean ExcludesComponentMask(UnityEngine.HyperGryph.ECS.ComponentMask& other) { }
        private System.Void .ctor(System.Int32 id) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void And(UnityEngine.HyperGryph.ECS.ComponentMask& other) { }
        private System.Void Or(System.Int32 id) { }

    }

    // TypeToken: 0x20000AD
    public struct EntityTypeInstanceData
    {
        // Fields
        public System.UInt64 groupComponentMask;        // 0x10
        public System.Byte* groupMemory;        // 0x18
        public System.UInt64 componentMask;        // 0x20
        public UnityEngine.HyperGryph.ECS.ComponentMask componentMaskAll;        // 0x20
        public System.Byte* memory;        // 0x30
        public System.UInt32 chunkType;        // 0x38
        public System.UInt32 extraDataMisc;        // 0x3C
        public System.Int32 count;        // 0x40
        public System.Int32 capacity;        // 0x44
        public System.Int32 stride;        // 0x48
        public System.Int32 componentTypeCount;        // 0x4C
        public UnityEngine.HyperGryph.ECS.EntityTypeInstanceData.<componentTypes>e__FixedBuffer componentTypes;        // 0x50

    }

    // TypeToken: 0x20000AF
    public struct Entity, IEquatable`1
    {
        // Fields
        public System.UInt32 globalIndex;        // 0x10
        public System.UInt32 version;        // 0x14
        private static readonly UnityEngine.HyperGryph.ECS.Entity <invaildEntity>k__BackingField;        // 0x0

        // Methods
        private System.UInt64 get_id() { }
        private System.Void set_id(System.UInt64 value) { }
        private System.Boolean Equals(UnityEngine.HyperGryph.ECS.Entity rhs) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean Valid() { }
        private System.Boolean op_Equality(UnityEngine.HyperGryph.ECS.Entity left, UnityEngine.HyperGryph.ECS.Entity right) { }
        private System.Boolean op_Inequality(UnityEngine.HyperGryph.ECS.Entity left, UnityEngine.HyperGryph.ECS.Entity right) { }
        private System.Boolean Equals(System.Object obj) { }
        private UnityEngine.HyperGryph.ECS.Entity get_invaildEntity() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B0
    public struct EntityType
    {
        // Fields
        public System.UInt32 id;        // 0x10

    }

    // TypeToken: 0x20000B1
    public interface IComponentECS
    {
        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000B2
    public struct BoundingCenterXComponent, IComponentECS
    {
        // Fields
        public System.Single x;        // 0x10

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000B3
    public struct BoundingCenterYComponent, IComponentECS
    {
        // Fields
        public System.Single y;        // 0x10

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000B4
    public struct BoundingCenterZComponent, IComponentECS
    {
        // Fields
        public System.Single z;        // 0x10

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000B5
    public struct BoundingExtentXComponent, IComponentECS
    {
        // Fields
        public System.Single x;        // 0x10

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000B6
    public struct BoundingExtentYComponent, IComponentECS
    {
        // Fields
        public System.Single y;        // 0x10

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000B7
    public struct BoundingExtentZComponent, IComponentECS
    {
        // Fields
        public System.Single z;        // 0x10

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000B8
    public struct RenderObjectLODInfoComponent, IComponentECS
    {
        // Fields
        public UnityEngine.Vector3 lodCenter;        // 0x10
        public System.Single lodObjectHalfSizeSquared;        // 0x1C
        public System.Boolean enableDither;        // 0x20
        public System.Byte lodCullingOptions;        // 0x21
        public System.Byte padding0;        // 0x22
        public System.Byte padding1;        // 0x23

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000B9
    public struct RenderObjectInfoComponent, IComponentECS
    {
        // Fields
        public System.UInt32 roLayerMask;        // 0x10
        public System.UInt32 objectFlags;        // 0x14
        public System.UInt64 sceneMask;        // 0x18
        public System.UInt32 artTag;        // 0x20
        public System.Single sortingFudgeSqr;        // 0x24

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000BA
    public struct RendererInfo
    {
        // Fields
        public System.UInt16 hgKeywords;        // 0x10
        public System.Byte meshSubIndex;        // 0x12
        public System.SByte sortOrder;        // 0x13
        public System.UInt32 materialHandle;        // 0x14
        public System.UInt32 geometryHandle;        // 0x18
        public System.UInt32 shadowProxyGeometryHandle;        // 0x1C
        public System.UInt32 renderFlags;        // 0x20
        public System.UInt32 lightModeMask;        // 0x24

    }

    // TypeToken: 0x20000BB
    public struct LODInfo
    {
        // Fields
        public System.Single lodScreenSizeMaxSquared;        // 0x10
        public System.Single lodScreenSizeMinSquared;        // 0x14

    }

    // TypeToken: 0x20000BC
    public interface IRenderObjectKComponent : IComponentECS
    {
        // Methods
        private System.Byte* GetRenderersPtr() { }

    }

    // TypeToken: 0x20000BD
    public struct RenderObjectK1Component, IRenderObjectKComponent, IComponentECS
    {
        // Fields
        public System.Int32 count;        // 0x10
        public UnityEngine.HyperGryph.ECS.RenderObjectK1Component.<renderers>e__FixedBuffer renderers;        // 0x14
        public UnityEngine.HyperGryph.ECS.RenderObjectK1Component.<lodInfos>e__FixedBuffer lodInfos;        // 0x2C

        // Methods
        private System.Int32 get_id() { }
        private System.Byte* GetRenderersPtr() { }

    }

    // TypeToken: 0x20000C0
    public struct RenderObjectK2Component, IRenderObjectKComponent, IComponentECS
    {
        // Fields
        public System.Int32 count;        // 0x10
        public UnityEngine.HyperGryph.ECS.RenderObjectK2Component.<renderers>e__FixedBuffer renderers;        // 0x14
        public UnityEngine.HyperGryph.ECS.RenderObjectK2Component.<lodInfos>e__FixedBuffer lodInfos;        // 0x44

        // Methods
        private System.Int32 get_id() { }
        private System.Byte* GetRenderersPtr() { }

    }

    // TypeToken: 0x20000C3
    public struct RenderObjectK4Component, IRenderObjectKComponent, IComponentECS
    {
        // Fields
        public System.Int32 count;        // 0x10
        public UnityEngine.HyperGryph.ECS.RenderObjectK4Component.<renderers>e__FixedBuffer renderers;        // 0x14
        public UnityEngine.HyperGryph.ECS.RenderObjectK4Component.<lodInfos>e__FixedBuffer lodInfos;        // 0x74

        // Methods
        private System.Int32 get_id() { }
        private System.Byte* GetRenderersPtr() { }

    }

    // TypeToken: 0x20000C6
    public struct RenderObjectK8Component, IRenderObjectKComponent, IComponentECS
    {
        // Fields
        public System.Int32 count;        // 0x10
        public UnityEngine.HyperGryph.ECS.RenderObjectK8Component.<renderers>e__FixedBuffer renderers;        // 0x14
        public UnityEngine.HyperGryph.ECS.RenderObjectK8Component.<lodInfos>e__FixedBuffer lodInfos;        // 0xD4

        // Methods
        private System.Int32 get_id() { }
        private System.Byte* GetRenderersPtr() { }

    }

    // TypeToken: 0x20000C9
    public struct RenderObjectK16Component, IRenderObjectKComponent, IComponentECS
    {
        // Fields
        public System.Int32 count;        // 0x10
        public UnityEngine.HyperGryph.ECS.RenderObjectK16Component.<renderers>e__FixedBuffer renderers;        // 0x14
        public UnityEngine.HyperGryph.ECS.RenderObjectK16Component.<lodInfos>e__FixedBuffer lodInfos;        // 0x194

        // Methods
        private System.Int32 get_id() { }
        private System.Byte* GetRenderersPtr() { }

    }

    // TypeToken: 0x20000CC
    public struct PerDrawBaseData
    {
        // Fields
        public UnityEngine.Matrix4x4 objectToWorld;        // 0x10
        public UnityEngine.Vector4 lodFade;        // 0x50
        public UnityEngine.Vector4 worldTransformParams;        // 0x60
        public UnityEngine.Matrix4x4 matrixPreviousM;        // 0x70
        public UnityEngine.Vector4 motionVectorsParams;        // 0xB0

    }

    // TypeToken: 0x20000CD
    public struct CommonInstanceDataComponent, IComponentECS
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.PerDrawBaseData baseData;        // 0x10
        public UnityEngine.HyperGryph.ECS.CommonInstanceDataComponent.<customData>e__FixedBuffer customData;        // 0xC0

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000CF
    public struct FactoryInstanceDataComponent, IComponentECS
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.PerDrawBaseData baseData;        // 0x10
        public UnityEngine.HyperGryph.ECS.FactoryInstanceDataComponent.<customData>e__FixedBuffer customData;        // 0xC0

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000D1
    public struct ECSFixedString64
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.ECSFixedString64.<data>e__FixedBuffer data;        // 0x10

        // Methods
        private System.String GetData() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000D3
    public struct DebugContentsComponent, IComponentECS
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.ECSFixedString64 entityName;        // 0x10
        public UnityEngine.HyperGryph.ECS.ECSExplicitEntityType entityType;        // 0x50
        public UnityEngine.HyperGryph.ECS.ECSFixedString64 debugStr;        // 0x54

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000D4
    public struct HGFactoryRendererBinderComponent, IComponentECS
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity rendererEntity;        // 0x10
        public System.UInt32 sharedDataIndex;        // 0x18
        public System.Byte rendererType;        // 0x1C
        public System.Byte padding0;        // 0x1D
        public System.Byte padding1;        // 0x1E
        public System.Byte padding2;        // 0x1F

        // Methods
        private System.Void SetDirtyFlag(UnityEngine.HyperGryph.HGFactoryDirtyFlags flag) { }
        private System.Void SetAdditiveMaterialBit(System.Int32 bitIndex, System.Boolean enable) { }
        private System.Void SetPosition(UnityEngine.Vector3 position) { }
        private System.Void SetUniformScale(System.Single uniformScale) { }
        private System.Void SetRotation(UnityEngine.Quaternion rotation) { }
        private System.Void SetTransform(UnityEngine.HyperGryph.HGFactoryEntityTransformData transform) { }
        private System.Void SetCustomPerDrawData(T data, System.Int32 offset) { }
        private System.Void SetEnabled(System.Boolean enabled) { }
        private System.Void SetAdditiveEntitiesVisibility(System.Boolean visible) { }
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000D5
    public struct HGWaterComponent, IComponentECS
    {
        // Fields
        public System.UInt32 renderTypeMask;        // 0x10
        public System.Int32 meshID;        // 0x14
        public UnityEngine.Matrix4x4 objectToWorld;        // 0x18
        public UnityEngine.Vector4 param0;        // 0x58
        public UnityEngine.Vector4 param1;        // 0x68

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000D6
    public struct HGWaterDecalComponent, IComponentECS
    {
        // Fields
        public System.UInt32 renderTypeMask;        // 0x10
        public System.Int32 meshID;        // 0x14
        public System.Int32 materialID;        // 0x18
        public UnityEngine.Matrix4x4 objectToWorld;        // 0x1C
        public UnityEngine.Vector4 param0;        // 0x5C
        public UnityEngine.Vector4 param1;        // 0x6C
        public UnityEngine.Vector4 animParam0;        // 0x7C
        public UnityEngine.Vector4 animParam1;        // 0x8C
        public UnityEngine.Vector4 animParam2;        // 0x9C
        public UnityEngine.Vector4 animParam3;        // 0xAC

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000D7
    public struct GrassRendererInfo
    {
        // Fields
        public System.UInt16 hgKeywords;        // 0x10
        public System.UInt16 batchGroupHandle;        // 0x12
        public System.UInt32 batchGroupKey;        // 0x14
        public System.Single sparsity;        // 0x18
        public System.UInt32 renderFlags;        // 0x1C
        public System.UInt32 padding0;        // 0x20
        public System.UInt32 padding1;        // 0x24

    }

    // TypeToken: 0x20000D8
    public struct GrassPerInstanceData
    {
        // Fields
        public static System.Int32 SIZE;        // 0x0
        public UnityEngine.Matrix4x4 objectToWorld;        // 0x10
        public UnityEngine.Vector4 param0;        // 0x50
        public UnityEngine.Vector4 param1;        // 0x60

    }

    // TypeToken: 0x20000D9
    public struct GrassClusterK4Component, IComponentECS
    {
        // Fields
        public System.Int32 count;        // 0x10
        public UnityEngine.HyperGryph.ECS.GrassClusterK4Component.<perInstanceData>e__FixedBuffer perInstanceData;        // 0x14

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000DB
    public struct GrassClusterK8Component, IComponentECS
    {
        // Fields
        public System.Int32 count;        // 0x10
        public UnityEngine.HyperGryph.ECS.GrassClusterK8Component.<perInstanceData>e__FixedBuffer perInstanceData;        // 0x14

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000DD
    public struct GrassClusterK16Component, IComponentECS
    {
        // Fields
        public System.Int32 count;        // 0x10
        public UnityEngine.HyperGryph.ECS.GrassClusterK16Component.<perInstanceData>e__FixedBuffer perInstanceData;        // 0x14

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000DF
    public struct GrassClusterK32Component, IComponentECS
    {
        // Fields
        public System.Int32 count;        // 0x10
        public UnityEngine.HyperGryph.ECS.GrassClusterK32Component.<perInstanceData>e__FixedBuffer perInstanceData;        // 0x14

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000E1
    public struct ECSColliderComponent, IComponentECS
    {
        // Fields
        public System.IntPtr actor;        // 0x10
        public System.Int32 ecsId;        // 0x18
        public System.UInt32 ecsVersion;        // 0x1C

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000E2
    public struct HGSludgeComponent, IComponentECS
    {
        // Fields
        public System.UInt32 materialHandle;        // 0x10
        public System.UInt32 sludgeSize;        // 0x14
        public System.Single disappearTime;        // 0x18
        public UnityEngine.Vector4 right;        // 0x1C
        public UnityEngine.Vector4 forward;        // 0x2C
        public UnityEngine.Vector4 position;        // 0x3C
        public UnityEngine.Vector4 up;        // 0x4C
        public UnityEngine.Vector4 customPerDraw0;        // 0x5C
        public UnityEngine.Vector4 customPerDraw1;        // 0x6C

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000E3
    public struct ECSClothDataComponent, IComponentECS
    {
        // Fields
        public System.UInt32 clothHash;        // 0x10

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000E4
    public struct HGECSRegionComponent, IComponentECS
    {
        // Fields
        public System.Boolean isEnable;        // 0x10
        public UnityEngine.Vector3 center;        // 0x14
        public UnityEngine.Vector3 size;        // 0x20
        public UnityEngine.Quaternion rotation;        // 0x2C

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000E5
    public struct HGCullingParameterComponent, IComponentECS
    {
        // Fields
        public System.Boolean enableShadowCulling;        // 0x10

        // Methods
        private System.Int32 get_id() { }

    }

    // TypeToken: 0x20000E6
    public struct EntityManager
    {
        // Fields
        public readonly System.IntPtr m_entitiesPPtr;        // 0x10
        public readonly System.IntPtr m_entityTypesPPtr;        // 0x18

        // Methods
        private System.Int32 GetNFromKNComponentMask(System.UInt64 componentMask) { }
        private System.Int32 GetCountFromKNComponent(System.Byte* component) { }
        private System.Void SetCountForKNComponent(System.Byte* component, System.Int32 count) { }
        private UnityEngine.HyperGryph.ECS.GrassRendererInfo* GetGrassRendererInfosFromKNComponent(System.Byte* component) { }
        private UnityEngine.HyperGryph.ECS.LODInfo* GetLODInfosFromKNComponent(System.Byte* component, System.Int32 n) { }
        private System.Int32 GetCountFromKNGrassCluster(System.Byte* component) { }
        private System.Void SetCountForKNGrassCluster(System.Byte* component, System.Int32 count) { }
        private UnityEngine.HyperGryph.ECS.GrassPerInstanceData* GetPerInstanceDataFromKNGrassCluster(System.Byte* component) { }
        private UnityEngine.HyperGryph.ECS.EntityManager GetEntityManager() { }
        private UnityEngine.HyperGryph.ECS.EntityManager GetGameplayEntityManager() { }
        private UnityEngine.HyperGryph.ECS.EntityManager GetRendererEntityManager() { }
        private System.Boolean HasEntity(UnityEngine.HyperGryph.ECS.Entity entity) { }
        private UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityType entityType) { }
        private System.Void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, System.IntPtr entities, System.Int32 count) { }
        private System.Void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> entities) { }
        private System.Void DestroyEntity(UnityEngine.HyperGryph.ECS.Entity entity) { }
        private System.Void DestroyEntities(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> entities) { }
        private System.Void DestroyEntities(System.IntPtr entities, System.Int32 entityCount) { }
        private UnityEngine.HyperGryph.ECS.ComponentType GetComponentType() { }
        private System.Void AddComponent(UnityEngine.HyperGryph.ECS.Entity& entity, T& t) { }
        private System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private System.Void RemoveComponentsWithMask(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.ComponentMask& needRemoveComponentMask) { }
        private UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityType(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> componentTypes) { }
        private UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityTypeImpl(System.Int32 componentTypeCount, System.IntPtr componentTypes) { }
        private System.Void AddMoveEntityAndEntityTypeDataImpl(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.EntityType& newEntityType) { }
        private System.Void RemoveMoveEntityAndEntityTypeDataImpl(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.EntityType& newEntityType) { }
        private System.UInt64 NumberOfSetBits(System.UInt64 i) { }
        private System.UInt64 NumberOfSetBits(UnityEngine.HyperGryph.ECS.ComponentMask& mask) { }
        private UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1) { }
        private UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1, System.Int32 id2) { }
        private UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3) { }
        private UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4) { }
        private UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4, System.Int32 id5) { }
        private System.Boolean HasComponent(UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private System.Void SetComponents(UnityEngine.HyperGryph.ECS.Entity& entity, T0& t0, T1& t1) { }
        private UnityEngine.HyperGryph.ECS.ComponentMask GetCountingMask(System.Int32 id) { }
        private System.Void SetComponentImplWithRef(UnityEngine.HyperGryph.ECS.EntityInstanceData& entityData, UnityEngine.HyperGryph.ECS.EntityTypeInstanceData& entityTypeData, T& t) { }
        private System.Void SetComponent(UnityEngine.HyperGryph.ECS.Entity& entity, T& t) { }
        private System.Byte* GetComponentPtrImpl(System.Int32 entityIdx, UnityEngine.HyperGryph.ECS.EntityTypeInstanceData& entityTypeData, System.Int32 componentId, System.Int32 componentSize) { }
        private System.Boolean TryGetWorldAABBFromRendererEntity(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.Bounds& aabb) { }
        private System.UInt64 GetComponentMaskLow(UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private UnityEngine.HyperGryph.ECS.ComponentMask GetComponentMaskAll(UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private System.Byte* GetComponentPtrLowBits(UnityEngine.HyperGryph.ECS.Entity& entity, System.UInt64 componentMask) { }
        private T GetComponent(UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private System.Boolean TryGetComponent(UnityEngine.HyperGryph.ECS.Entity& entity, T& component) { }
        private T& GetComponentRef(UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private T* GetComponentPtr(UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private System.Boolean TryGetComponentPtr(UnityEngine.HyperGryph.ECS.Entity& entity, T*& componentPtr) { }
        private UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.ComponentMask& includeComponentMask, UnityEngine.HyperGryph.ECS.ComponentMask& excludeComponentMask) { }
        private UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.ComponentMask& componentMask) { }
        private UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate() { }
        private UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate() { }
        private System.Int32 GetEntityTypeCount() { }
        private System.UInt32 GetEntityContainerSize() { }
        private System.Void GarbageCollect() { }
        private System.Void GetEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager& ret) { }
        private System.Void GetGameplayEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager& ret) { }
        private System.Void GetRendererEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager& ret) { }
        private System.Void CreateEntity_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.EntityType& entityType, UnityEngine.HyperGryph.ECS.Entity& ret) { }
        private System.Void CreateEntities_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.EntityType& entityType, System.IntPtr entities, System.Int32 count) { }
        private System.Void DestroyEntity_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private System.Void DestroyEntities_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, System.IntPtr entities, System.Int32 entityCount) { }
        private System.Void GetOrRegisterEntityTypeImpl_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, System.Int32 componentTypeCount, System.IntPtr componentTypes, UnityEngine.HyperGryph.ECS.EntityType& ret) { }
        private System.Void AddMoveEntityAndEntityTypeDataImpl_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.EntityType& newEntityType) { }
        private System.Void RemoveMoveEntityAndEntityTypeDataImpl_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.EntityType& newEntityType) { }
        private System.Int32 GetEntityTypeCount_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self) { }
        private System.UInt32 GetEntityContainerSize_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self) { }
        private System.Void GarbageCollect_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self) { }

    }

    // TypeToken: 0x20000E7
    public struct GroupType
    {
        // Fields
        private readonly UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* m_entityTypes;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* types) { }
        private System.Int32 Size() { }
        private System.Boolean HasComponent() { }
        private T* GetComponent() { }
        private System.Byte* GetComponentPtr(System.Int32 componentId) { }
        private Unity.Collections.NativeArray<T> GetComponentAsArray() { }
        private UnityEngine.HyperGryph.ECS.Entity* GetEntities() { }
        private UnityEngine.HyperGryph.ECS.ComponentMask GetComponentMaskAll() { }
        private Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> GetEntitiesAsArray() { }

    }

    // TypeToken: 0x20000E8
    public struct EntityManagerRange, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* m_entityTypes;        // 0x10
        private readonly UnityEngine.HyperGryph.ECS.ComponentMask m_componentMask;        // 0x18
        private readonly UnityEngine.HyperGryph.ECS.ComponentMask m_excludeComponentMask;        // 0x28
        private readonly System.Int32 m_count;        // 0x38

        // Methods
        private System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* entityTypes, System.Int32 count, UnityEngine.HyperGryph.ECS.ComponentMask& componentMask) { }
        private System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* entityTypes, System.Int32 count, UnityEngine.HyperGryph.ECS.ComponentMask& includeComponentMask, UnityEngine.HyperGryph.ECS.ComponentMask& excludeComponentMask) { }
        private UnityEngine.HyperGryph.ECS.EntityManagerRange.Enumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<UnityEngine.HyperGryph.ECS.GroupType> System.Collections.Generic.IEnumerable<UnityEngine.HyperGryph.ECS.GroupType>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

}

namespace UnityEngine.HyperGryph.Streaming
{

    // TypeToken: 0x2000088
    public struct StreamingAssetData
    {
        // Fields
        public System.Int64 assetHashV2;        // 0x10
        public UnityEngine.HyperGryph.AssetType assetType;        // 0x18

        // Methods
        private System.Boolean Equals(UnityEngine.HyperGryph.Streaming.StreamingAssetData other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000089
    public struct PropertySerializeId
    {
        // Fields
        public System.UInt32 componentIndex;        // 0x10
        public System.UInt32 propertyId;        // 0x14
        public System.UInt32 subPropertyIndex;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType, System.UInt32 propertyId, System.UInt32 subPropertyIndex) { }
        private System.Void .ctor(System.UInt32 componentIndex, System.UInt32 propertyId, System.UInt32 subPropertyIndex) { }
        private System.Void .ctor(System.UInt32 propertyId, System.UInt32 subPropertyIndex) { }
        private UnityEngine.HyperGryph.Streaming.PropertySerializeId op_Implicit(System.UInt32 propertyId) { }
        private System.UInt32 GetComponentIndexFromType(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType) { }
        private System.Int32 GetHashCode() { }
        private System.UInt32 EncodeSerializeIdentifier() { }
        private UnityEngine.HyperGryph.Streaming.PropertySerializeId op_Addition(UnityEngine.HyperGryph.Streaming.PropertySerializeId a, System.UInt32 subIndex) { }
        private UnityEngine.HyperGryph.Streaming.PropertySerializeId op_Addition(UnityEngine.HyperGryph.Streaming.PropertySerializeId a, System.Int32 subIndex) { }

    }

    // TypeToken: 0x200008A
    public struct FlatBufferConvertContextV2
    {
        // Fields
        public readonly System.IntPtr ptr;        // 0x10

        // Methods
        private System.Boolean TryEnqueueAssetForAsyncLoad(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId) { }
        private System.Void AddExternalAssetForAsyncLoad(System.Int64 assetHash, UnityEngine.HyperGryph.AssetType assetType, System.UInt32 assetHandle) { }
        private UnityEngine.Object ConvertAssetFromImpl(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId) { }
        private System.IntPtr ConvertPropertyPtrFromImpl(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId) { }
        private System.Void ConvertPropertyDataFromBytesImpl(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId, System.IntPtr& data, System.Int32& size) { }
        private System.String ConvertStringFrom(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId) { }
        private System.Boolean TryConvertAssetFrom(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId, T& asset) { }
        private T ConvertPropertyFrom(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId) { }
        private T ConvertPropertyFromBytes(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId) { }
        private Unity.Collections.NativeArray<System.Byte> ConvertPropertyFromBytes(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId) { }
        private System.Boolean TryEnqueueAssetForAsyncLoad_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId) { }
        private System.Void AddExternalAssetForAsyncLoad_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, System.Int64 assetHash, UnityEngine.HyperGryph.AssetType assetType, System.UInt32 assetHandle) { }
        private UnityEngine.Object ConvertAssetFromImpl_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId) { }
        private System.IntPtr ConvertPropertyPtrFromImpl_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId) { }
        private System.Void ConvertPropertyDataFromBytesImpl_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId, System.IntPtr& data, System.Int32& size) { }
        private System.String ConvertStringFrom_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId) { }

    }

    // TypeToken: 0x200008B
    public struct StreamingGameplayManager
    {
        // Fields
        public readonly System.IntPtr ptr;        // 0x10

        // Methods
        private System.Void Create(UnityEngine.HyperGryph.Streaming.StreamingSceneParameter parameter) { }
        private System.Void Destroy() { }
        private System.UInt32 AllocateRuntimeChunk(System.String initBasePath, System.String streamingBasePath) { }
        private System.UInt32 CreateEntityGroupAndLoad(System.UInt32 chunkId, System.Int32 blobIndex) { }
        private System.Void LoadGroup(System.UInt32 groupHandle) { }
        private System.Boolean IsGroupReady(System.UInt32 groupId) { }
        private System.UInt32 CreateGroupAndLoadWaitBeforeShow(System.UInt32 chunkId, System.Int32 blobIndex) { }
        private System.Void StopGroupWait(System.UInt32 groupId) { }
        private System.Void UnloadGroup(System.UInt32 groupId, System.Boolean imm) { }
        private System.Void DestroyGroup(System.UInt32 groupId) { }
        private System.Boolean IsGroupLoaded(System.UInt32 groupId) { }
        private System.Boolean IsGroupUnloaded(System.UInt32 groupId) { }
        private System.Void Tick(System.Int32 budget) { }
        private System.Void TickResource() { }
        private System.Void Clear() { }
        private System.Boolean IsIdle() { }
        private System.Boolean IsValid() { }
        private System.Void SetNeedLodTransition(System.Boolean needTransition) { }
        private System.Boolean GetNeedLodTransition() { }
        private System.Void Create_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSceneParameter& parameter) { }
        private System.Void Destroy_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self) { }
        private System.UInt32 AllocateRuntimeChunk_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.String initBasePath, System.String streamingBasePath) { }
        private System.UInt32 CreateEntityGroupAndLoad_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 chunkId, System.Int32 blobIndex) { }
        private System.Void LoadGroup_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupHandle) { }
        private System.Boolean IsGroupReady_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId) { }
        private System.UInt32 CreateGroupAndLoadWaitBeforeShow_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 chunkId, System.Int32 blobIndex) { }
        private System.Void StopGroupWait_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId) { }
        private System.Void UnloadGroup_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId, System.Boolean imm) { }
        private System.Void DestroyGroup_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId) { }
        private System.Boolean IsGroupLoaded_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId) { }
        private System.Boolean IsGroupUnloaded_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId) { }
        private System.Void Tick_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.Int32 budget) { }
        private System.Void TickResource_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self) { }
        private System.Void Clear_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self) { }
        private System.Boolean IsIdle_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self) { }
        private System.Void SetNeedLodTransition_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.Boolean needTransition) { }
        private System.Boolean GetNeedLodTransition_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self) { }

    }

    // TypeToken: 0x200008C
    public struct StreamingComponentType
    {
        // Fields
        public System.UInt64 value__;        // 0x10
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType None;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType Transform;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType MeshFilter;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType MeshRenderer;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType LODGroup;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType BoxCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType MeshCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType SphereCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType CapsuleCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType TerrainCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType MultiCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGDecalProjector;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HLODGroup;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGVolumetricLocalFog;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGWaterRenderer;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGEnvironmentVolume;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType Volume;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType ReflectionProbe;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType Light;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGIrradianceVolume;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGTerrain;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGGrass;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType AudioVolume;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType AudioSceneEmitter;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType AudioRoom;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType AudioPortal;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGAdditionalLightData;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGTerrainSurfTypeData;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGSOCChunk;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType GpuClothGroup;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType LensFlareComponentSRP;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGTerrainDecal;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType MergedRenderColliderECS;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGWaterGlobalConfig;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGWindMotor;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGECSRegion;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType FakeFogSimple;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType VLB;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType HGWaterDecal;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingComponentType Count;        // 0x0

    }

    // TypeToken: 0x200008D
    public struct StreamingLayer
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer Default;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer Persistent;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer HLOD0;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer HLOD1;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer HLOD2;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer Collider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer Tiny;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer Water;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer Lighting;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer Audio;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingLayer Count;        // 0x0

    }

    // TypeToken: 0x200008E
    public struct EntityTransition
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.Streaming.EntityTransition Initializing;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition UnloadedToLoading;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition LoadingWaiting;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition LoadingToLoaded;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition UnloadingToLoaded;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition LoadedToUnloading;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition UnloadingToUnloaded;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition UnloadingWaiting;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition LoadingToUnloaded;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition Destroying;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.EntityTransition Count;        // 0x0

    }

    // TypeToken: 0x200008F
    public struct StreamingMode
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.Streaming.StreamingMode Stream;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingMode Pause;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingMode Load;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingMode Unload;        // 0x0

    }

    // TypeToken: 0x2000090
    public struct StreamingStatus
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.Streaming.StreamingStatus Idle;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingStatus Loading;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingStatus Unloading;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.StreamingStatus Empty;        // 0x0

    }

    // TypeToken: 0x2000091
    public struct StreamingSceneParameter
    {
        // Fields
        public System.String mapName;        // 0x10
        public UnityEngine.GameObject streamingRootObject;        // 0x18
        public System.String streamingDataPathRoot;        // 0x20

    }

    // TypeToken: 0x2000092
    public struct GridStatus
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.Streaming.GridStatus Loading;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.GridStatus Loaded;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.GridStatus Unloading;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.GridStatus Unloaded;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.GridStatus NotExist;        // 0x0

    }

    // TypeToken: 0x2000093
    public struct GridIdentifier
    {
        // Fields
        public UnityEngine.Vector2Int pos;        // 0x10
        public System.Int32 sceneStateId;        // 0x18
        public System.Int32 areaId;        // 0x1C
        public UnityEngine.HyperGryph.Streaming.StreamingLayer layer;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, System.Int32 sceneStateId, System.Int32 areaId, UnityEngine.Vector2Int pos) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000094
    public struct StreamingSourceData
    {
        // Fields
        public UnityEngine.Vector2 streamingPos;        // 0x10
        public System.Single chunkLoadRadius;        // 0x18
        public UnityEngine.HyperGryph.Streaming.StreamingSourceData.<layerLoadRadius>e__FixedBuffer layerLoadRadius;        // 0x1C
        public UnityEngine.HyperGryph.Streaming.StreamingSourceData.<layerEnabledInDefaultArea>e__FixedBuffer layerEnabledInDefaultArea;        // 0x44
        public static readonly UnityEngine.HyperGryph.Streaming.StreamingSourceData kInvalid;        // 0x0

        // Methods
        private System.Single GetGridLoadRadius(System.Int32 layerIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000097
    public struct ECSEntityType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType Render;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType Water;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType ConvexCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType CapsuleCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType SphereCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType MeshCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType MultiCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType TerrainCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType TerrainDecal;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType MergedRenderCollider;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType HGDecalProjector;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType TerrainSplineDecal;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType HGECSRegion;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType WaterDecal;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ECSEntityType TypeCount;        // 0x0

    }

    // TypeToken: 0x2000098
    public struct ProxyEntityType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType IrradianceVolume;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType AudioVolume;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType AudioEmitter;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType AudioRoom;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType TerrainSurfaceTypeData;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType AudioPortal;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType SOCChunk;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType GrassGrid;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType GpuClothGroup;        // 0x0
        public static UnityEngine.HyperGryph.Streaming.ProxyEntityType TypeCount;        // 0x0

    }

    // TypeToken: 0x2000099
    public struct StreamingSceneV2
    {
        // Fields
        public readonly System.IntPtr ptr;        // 0x10

        // Methods
        private System.Void Create(UnityEngine.HyperGryph.Streaming.StreamingSceneParameter parameter) { }
        private System.Void Destroy() { }
        private System.Void UnloadImmediately() { }
        private UnityEngine.HyperGryph.Streaming.StreamingStatus QueryStreamingStatus() { }
        private System.Void SetArea(System.Int32 areaId, System.Boolean enabled) { }
        private System.Void SetSceneState(System.Int32 sceneStateId, System.Boolean enabled) { }
        private UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatusImpl(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, System.Int32 sceneStateId, System.Int32 areaId, UnityEngine.Vector2 queryPos) { }
        private UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatusByGridIdentifierImpl(UnityEngine.HyperGryph.Streaming.GridIdentifier gridIdentifier) { }
        private System.Void set_streamingMode(UnityEngine.HyperGryph.Streaming.StreamingMode value) { }
        private UnityEngine.HyperGryph.Streaming.StreamingSourceData get_primaryStreamingSourceData() { }
        private System.Void set_primaryStreamingSourceData(UnityEngine.HyperGryph.Streaming.StreamingSourceData value) { }
        private System.Void set_secondaryStreamingSourceData(UnityEngine.HyperGryph.Streaming.StreamingSourceData value) { }
        private System.Single get_streamingProgress() { }
        private System.Boolean IsValid() { }
        private UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatus(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, UnityEngine.Vector2 queryPos) { }
        private UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatus(UnityEngine.HyperGryph.Streaming.GridIdentifier gridIdentifier) { }
        private System.Void Create_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSceneParameter& parameter) { }
        private System.Void Destroy_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self) { }
        private System.Void UnloadImmediately_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self) { }
        private UnityEngine.HyperGryph.Streaming.StreamingStatus QueryStreamingStatus_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self) { }
        private System.Void SetArea_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, System.Int32 areaId, System.Boolean enabled) { }
        private System.Void SetSceneState_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, System.Int32 sceneStateId, System.Boolean enabled) { }
        private UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatusImpl_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingLayer layer, System.Int32 sceneStateId, System.Int32 areaId, UnityEngine.Vector2& queryPos) { }
        private UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatusByGridIdentifierImpl_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.GridIdentifier& gridIdentifier) { }
        private System.Void set_streamingMode_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingMode value) { }
        private System.Void get_primaryStreamingSourceData_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSourceData& ret) { }
        private System.Void set_primaryStreamingSourceData_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSourceData& value) { }
        private System.Void set_secondaryStreamingSourceData_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSourceData& value) { }
        private System.Single get_streamingProgress_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self) { }
        private System.Boolean IsValid_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self) { }

    }

    // TypeToken: 0x200009A
    public class ECSEntityHasRequiredComponentsDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200009B
    public class ECSEntityConvertToDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200009C
    public class ProxyEntityHasRequiredComponentsDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200009D
    public class ProxyEntityConvertToDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200009E
    public class MonoIsConvertorOfComponentDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200009F
    public class MonoComponentConvertToDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x20000A0
    public class ECSEntityConvertFromDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2 cContext, UnityEngine.HyperGryph.Streaming.EntityTransition transition) { }

    }

    // TypeToken: 0x20000A1
    public class ProxyEntityConvertFromDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.IntPtr& proxyPtr, UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2 cContext, UnityEngine.HyperGryph.Streaming.EntityTransition transition) { }

    }

    // TypeToken: 0x20000A2
    public class MonoComponentConvertFromDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.Component component, UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2 cContext, UnityEngine.HyperGryph.Streaming.EntityTransition transition) { }

    }

    // TypeToken: 0x20000A3
    public class MonoComponentAddComponentToDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.Component Invoke(UnityEngine.GameObject gameObject) { }

    }

    // TypeToken: 0x20000A4
    public class MonoComponentGetComponentFromDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.Component Invoke(UnityEngine.GameObject gameObject, System.Int32 multiComponentIndex) { }

    }

    // TypeToken: 0x20000A5
    public class HGStreamingSceneManager
    {
        // Methods
        private System.Int32 get_streamingVersion() { }
        private System.Int32 get_streamingChunkSize() { }
        private System.Void ResetLastProcessStreamingPos() { }
        private System.Void BindECSEntityConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.ECSEntityType entityType, UnityEngine.HyperGryph.Streaming.ECSEntityHasRequiredComponentsDelegate hasRequiredComponentsDelegate, UnityEngine.HyperGryph.Streaming.ECSEntityConvertToDelegate convertToDelegate, UnityEngine.HyperGryph.Streaming.ECSEntityConvertFromDelegate convertFromFunc) { }
        private System.Void ResetECSEntityConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.ECSEntityType entityType) { }
        private System.Boolean IsECSEntityConvertFuncValid(UnityEngine.HyperGryph.Streaming.ECSEntityType entityType) { }
        private System.Void BindProxyEntityConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType, UnityEngine.HyperGryph.Streaming.ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, UnityEngine.HyperGryph.Streaming.ProxyEntityConvertToDelegate convertToFunc, UnityEngine.HyperGryph.Streaming.ProxyEntityConvertFromDelegate convertFromFunc) { }
        private System.Void ResetProxyEntityConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType) { }
        private System.Boolean IsProxyEntityConvertFuncValid(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType) { }
        private System.Void BindMonoComponentConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType, UnityEngine.HyperGryph.Streaming.MonoIsConvertorOfComponentDelegate isConvertorOfFunc, UnityEngine.HyperGryph.Streaming.MonoComponentConvertToDelegate convertToFunc, UnityEngine.HyperGryph.Streaming.MonoComponentConvertFromDelegate convertFromFunc, UnityEngine.HyperGryph.Streaming.MonoComponentAddComponentToDelegate addComponentToFunc, UnityEngine.HyperGryph.Streaming.MonoComponentGetComponentFromDelegate getComponentFromFunc) { }
        private System.Void ResetMonoComponentConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType) { }
        private System.Boolean IsMonoComponentConvertFuncValid(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType) { }
        private System.Void BindProxyEntityConvertToFuncFromScript(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType, UnityEngine.HyperGryph.Streaming.ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, UnityEngine.HyperGryph.Streaming.ProxyEntityConvertToDelegate convertToFunc) { }
        private System.Void ResetProxyEntityConvertToFuncFromScript(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType) { }
        private System.IntPtr get_streamingScenesManaged() { }
        private System.Int32 get_streamingSceneCount() { }
        private Unity.Collections.NativeArray<UnityEngine.HyperGryph.Streaming.StreamingSceneV2> GetStreamingScenesArray() { }

    }

    // TypeToken: 0x20000A6
    public struct StreamingLayerConfig
    {
        // Fields
        public System.Boolean enabled;        // 0x10
        public UnityEngine.HyperGryph.Streaming.StreamingLayer layer;        // 0x11
        public System.Boolean chunkLoad;        // 0x12
        public System.Int32 gridSize;        // 0x14
        public System.Int32 priority;        // 0x18

    }

    // TypeToken: 0x20000A7
    public class HGStreamingSettings
    {
        // Methods
        private System.Void set_loadDirtyDistance(System.Single value) { }
        private System.Void set_unloadDirtyDistance(System.Single value) { }
        private System.Void set_loadElapsedMsPerFrame(System.Single value) { }
        private System.Void set_unloadElapsedMsPerFrame(System.Single value) { }
        private System.Void SetLayerConfig(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, UnityEngine.HyperGryph.Streaming.StreamingLayerConfig config) { }
        private System.Void SetLayerConfig_Injected(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, UnityEngine.HyperGryph.Streaming.StreamingLayerConfig& config) { }

    }

}

