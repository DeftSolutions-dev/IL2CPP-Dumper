// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.HGGraphicsModule.dll
// Classes:  233
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: GetFileHashMappingCallback
TYPE:  class
TOKEN: 0x2000067
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.HyperGryph.VFSBlockFileInfo Invoke(System.Int64 originNameHash)
END_CLASS

CLASS: GetFilePathMappingCallback
TYPE:  class
TOKEN: 0x2000068
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.HyperGryph.VFSBlockFileInfo Invoke(System.String originName)
END_CLASS

CLASS: GetTextureFromHGWaterSectorDataCallback
TYPE:  class
TOKEN: 0x2000069
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.Texture2D Invoke(UnityEngine.ScriptableObject sectorDataScriptableObject)
END_CLASS

CLASS: HGWaterRenderType
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryph.HGWaterRender.HGWaterRenderTypeProxy  // 0x0
  public    static  UnityEngine.HyperGryph.HGWaterRender.HGWaterRenderTypeLOD  // 0x0
METHODS:
END_CLASS

CLASS: HGWaterDecalRenderType
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryph.HGWaterRender.HGWaterDecalRenderTypeNone  // 0x0
  public    static  UnityEngine.HyperGryph.HGWaterRender.HGWaterDecalRenderTypeRegular  // 0x0
  public    static  UnityEngine.HyperGryph.HGWaterRender.HGWaterDecalRenderTypeEmissive  // 0x0
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x20000E9
FIELDS:
  private   readonly UnityEngine.HyperGryph.ECS.EntityTypeInstanceData*m_entityTypes  // 0x10
  private   readonly System.Int32                    m_count  // 0x18
  private           UnityEngine.HyperGryph.ECS.ComponentMaskm_includeComponentMask  // 0x20
  private           UnityEngine.HyperGryph.ECS.ComponentMaskm_excludedComponentMask  // 0x30
  private           System.Int32                    m_index  // 0x40
METHODS:
  System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* entityTypes, System.Int32 count, UnityEngine.HyperGryph.ECS.ComponentMask& includeComponentMask, UnityEngine.HyperGryph.ECS.ComponentMask& excludeComponentMask)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  UnityEngine.HyperGryph.ECS.GroupType get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.HGCapsuleBindingComponent
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Component
FIELDS:
METHODS:
  System.Void set_enabled(System.Boolean value)
  System.Void set_capsuleRadius(System.Single value)
  System.Void set_capsuleHeight(System.Single value)
  System.Void set_localOffset(UnityEngine.Vector3 value)
  System.Void set_localRotation(UnityEngine.Vector3 value)
  System.Void set_intensityScale(System.Single value)
  System.Void set_forceRender(System.Boolean value)
  System.Void set_localOffset_Injected(UnityEngine.Vector3& value)
  System.Void set_localRotation_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.HGDecalShapeType
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HGDecalShapeType    Box  // 0x0
  public    static  UnityEngine.HGDecalShapeType    Cylinder  // 0x0
  public    static  UnityEngine.HGDecalShapeType    Sector  // 0x0
  public    static  UnityEngine.HGDecalShapeType    Sphere  // 0x0
  public    static  UnityEngine.HGDecalShapeType    Mesh  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HGDecalProjector
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Behaviour
FIELDS:
METHODS:
  UnityEngine.HGDecalShapeType get_shapeType()
  UnityEngine.Material get_material()
  System.Void set_material(UnityEngine.Material value)
  System.Void set_baseColor(UnityEngine.Color value)
  UnityEngine.Vector2 get_uvOffset()
  System.Void set_uvOffset(UnityEngine.Vector2 value)
  System.Void set_sectorAngle(System.Single value)
  System.Void set_baseColor_Injected(UnityEngine.Color& value)
  System.Void get_uvOffset_Injected(UnityEngine.Vector2& ret)
  System.Void set_uvOffset_Injected(UnityEngine.Vector2& value)
END_CLASS

CLASS: UnityEngine.HGOccluder
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Component
FIELDS:
METHODS:
  System.Boolean get_enabled()
  System.Void set_enabled(System.Boolean value)
  UnityEngine.HGSoftwareOcclusionCullingData get_occluderData()
  System.Void set_occluderData(UnityEngine.HGSoftwareOcclusionCullingData value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.HGSoftwareOcclusionCullingData
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.HGSoftwareOcclusionCullingData cullingData)
  System.Void GetOccluderData(Unity.Collections.NativeArray<System.Single> centerXs, Unity.Collections.NativeArray<System.Single> centerYs, Unity.Collections.NativeArray<System.Single> centerZs, Unity.Collections.NativeArray<System.Single> extentXs, Unity.Collections.NativeArray<System.Single> extentYs, Unity.Collections.NativeArray<System.Single> extentZs, Unity.Collections.NativeArray<UnityEngine.Vector3> vertexData, System.Int32& quadCount)
  System.Int32 get_quadCount()
  System.Void GetOccluderData(System.IntPtr centerXs, System.IntPtr centerYs, System.IntPtr centerZs, System.IntPtr extentXs, System.IntPtr extentYs, System.IntPtr extentZs, System.IntPtr vertexData, System.Int32& quadCount)
END_CLASS

CLASS: UnityEngine.TransformAnimatedPhasePlayMode
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TransformAnimatedPhasePlayModeTransformAnimatedPhaseCurrent  // 0x0
  public    static  UnityEngine.TransformAnimatedPhasePlayModeTransformAnimatedPhaseSequence  // 0x0
  public    static  UnityEngine.TransformAnimatedPhasePlayModeTransformAnimatedPhaseSequenceLoop  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TransformAnimatedCurveData
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Byte[]                   data  // 0x10
  public            System.Single                   duration  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.TransformMotionPhase
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            UnityEngine.Vector3             translationSpeed  // 0x10
  public            UnityEngine.Vector3             eulerAngleSpeed  // 0x1C
  public            UnityEngine.Vector3             rotAnchorPosition  // 0x28
  public            System.Single                   duration  // 0x34
METHODS:
END_CLASS

CLASS: UnityEngine.HGTransformAnimatedProfile
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            UnityEngine.TransformMotionPhase[]motionPhaseProfiles  // 0x10
  public            UnityEngine.TransformAnimatedCurveDataanimCurveData  // 0x18
  public            UnityEngine.TransformAnimatedPhasePlayModephasePlayMode  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.HGTransformAnimatedBehaviour
TYPE:  class
TOKEN: 0x200000E
EXTENDS: Behaviour
FIELDS:
  public            UnityEngine.HGTransformAnimatedProfileprofileData  // 0x18
  public            System.Boolean                  useLogicDeltaTime  // 0x38
  public            UnityEngine.Renderer            shadowProxyRenderer  // 0x40
METHODS:
  System.Void SetPause()
  System.Void Play()
  System.Single GetTimeScale()
  System.Void SetTimeScale(System.Single scale)
  System.Void SetCurrentPhaseIndex(System.Int32 phase)
  System.Int32 GetCurrentPhaseIndex()
  UnityEngine.Matrix4x4 GetWorldMatrix()
  System.Void SetUseLogicTime(System.Boolean useLogicTime)
  System.Boolean UseLogicTime()
  System.Void .ctor()
  System.Void GetWorldMatrix_Injected(UnityEngine.Matrix4x4& ret)
END_CLASS

CLASS: UnityEngine.HGWindFoliageSyncSystemCPP
TYPE:  class
TOKEN: 0x200000F
FIELDS:
METHODS:
  System.Int64 HGWindFoliageSyncSystemCPP_Create()
  System.Void HGWindFoliageSyncSystemCPP_UpdateWindParam(System.Int64 _ptr, UnityEngine.Vector4 windGlobalParam, System.Single* windMotorParam0, System.Single* windMotorParam1, System.Single* windMotorParam2, System.Single* windMotorParam3, UnityEngine.Vector4 count, System.Single time, System.Single lastTime)
  System.Void HGWindFoliageSyncSystemCPP_Destroy(System.Int64 _ptr)
  System.Void HGWindFoliageSyncSystemCPP_UpdateWindParam_Injected(System.Int64 _ptr, UnityEngine.Vector4& windGlobalParam, System.Single* windMotorParam0, System.Single* windMotorParam1, System.Single* windMotorParam2, System.Single* windMotorParam3, UnityEngine.Vector4& count, System.Single time, System.Single lastTime)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGDLSSUtil
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Boolean IsStreamlineDLSSSupported()
  System.Boolean IsStreamlineDLSSGSupported()
  System.Boolean IsLowLatencyAvailable()
END_CLASS

CLASS: UnityEngine.HyperGryph.GPUDrivenRenderer
TYPE:  class
TOKEN: 0x2000011
FIELDS:
METHODS:
  System.Void CreateRendererListWithPreZ(System.UInt32 viewHandle, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32 prevBatchKeySetIdx, System.UInt32& normalList, System.UInt32& preZPart0List, System.UInt32& preZPart1List, System.UInt32& currBatchKeySetIdx)
  System.Void FreeBatchKeySet(System.UInt32 idx)
  System.Boolean Enable()
  System.Void CreateRendererListWithPreZ(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context, System.UInt32 prevBatchKeySetIdx, System.UInt32& normalList, System.UInt32& preZPart0List, System.UInt32& preZPart1List, System.UInt32& currBatchKeySetIdx)
  System.Void DrawRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList, System.Boolean renderMatchedPrev)
  System.Void AdvanceFrame()
  System.Boolean CullingInspectionMode()
  System.Void PopulatePerFrameData(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 threadGroupSize, System.UInt32 hzbWidth, System.UInt32 hzbHeight, System.Boolean populatePrev)
  System.Void BindFrameConstantsBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader shader, System.UInt32 kernelIdx)
  System.Void BindFrameConstantsBufferGlobal(UnityEngine.Rendering.CommandBuffer cmd, System.Boolean bindPrev)
  System.Void BindBuffersForCulling(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader shader, System.UInt32 kernelIdx)
  System.Void BindBuffersForRendering(UnityEngine.Rendering.CommandBuffer cmd)
  System.Void DispatchComputeMeshletInstanceCount(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader shader, System.UInt32 kernelIdx)
  System.Void DispatchComputeDrawBucketCount(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader shader, System.UInt32 kernelIdx)
END_CLASS

CLASS: UnityEngine.HyperGryph.CapsuleData
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            UnityEngine.Vector3             pa  // 0x10
  public            System.Single                   radius  // 0x1C
  public            UnityEngine.Vector3             pb  // 0x20
  public            System.Single                   len  // 0x2C
  public            UnityEngine.Vector3             dir  // 0x30
  public            System.Single                   padding  // 0x3C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGCapsuleShadowManager
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.UInt32 GetRenderCapsuleNum()
  System.UInt32 CullAndGetRenderCapsuleData(System.UInt32 viewHandle, System.IntPtr outData, System.UInt32 outDataCapacity)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGDecalRender
TYPE:  class
TOKEN: 0x2000014
FIELDS:
METHODS:
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context)
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context, System.IntPtr drawableFeedbackPtr)
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32* drawableFeedbackPtr)
  System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGDrawCallDetailedStats
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    componentInstanceID  // 0x10
  public            System.Int32                    meshInstanceID  // 0x14
  public            System.Int32                    triCount  // 0x18
  public            System.Int32                    meshBatchCount  // 0x1C
  public            System.Int32                    shaderInstanceID  // 0x20
  public            System.Int32                    passNameID  // 0x24
  public            System.Int32                    passVertKeywordsID  // 0x28
  public            System.Int32                    passFragKeywordsID  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFastString
TYPE:  class
TOKEN: 0x2000016
FIELDS:
METHODS:
  System.String IndexToString(System.Int32 index)
  System.Int32 StringToIndex(System.String s)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFactoryRendererData
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            UnityEngine.Mesh                m_mesh  // 0x10
  public            UnityEngine.Mesh                m_shadowProxyMesh  // 0x18
  public            UnityEngine.Material[]          m_materials  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            UnityEngine.HyperGryph.HGFactoryRendererData[]m_rendererDataArr  // 0x10
  public            System.Single                   m_lodScreenSizeMax  // 0x18
  public            System.Single                   m_lodScreenSizeMin  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFactoryEntityDesc
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            UnityEngine.Vector3             m_initPosition  // 0x10
  public            System.Single                   m_initUniformScale  // 0x1C
  public            UnityEngine.Quaternion          m_initRotation  // 0x20
  public            UnityEngine.Rendering.ShadowCastingModem_shadowCastingMode  // 0x30
  public            UnityEngine.Rendering.SubMeshRenderModem_subMeshRenderMode  // 0x34
  public            System.Int32                    m_objectLayer  // 0x38
  public            System.Int32                    m_objectEnabled  // 0x3C
  public            System.Int32                    m_renderFoliageOccluder  // 0x40
  public            System.Single                   m_objectBoundExtentsMultiplier  // 0x44
  public            System.Int32                    m_useCustomLocalBounds  // 0x48
  public            UnityEngine.Bounds              m_customLocalBounds  // 0x4C
  public            System.Int32                    m_autoUpdatePrevTransform  // 0x64
  public            System.UInt32                   m_enabledLightModes  // 0x68
  public            UnityEngine.HyperGryph.ECS.Entitym_logicalEntityHandle  // 0x6C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFactoryEntityTransformData
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            UnityEngine.Vector4             m_positionAndScale  // 0x10
  public            UnityEngine.Quaternion          m_rotation  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFactoryRenderManager
TYPE:  class
TOKEN: 0x200001B
FIELDS:
METHODS:
  UnityEngine.HyperGryph.ECS.Entity CreateRegularEntity(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc desc, System.String entityName, UnityEngine.HyperGryph.ECS.Entity gameplayEntity, UnityEngine.Material[] additiveMaterials)
  System.Void UpdateRegularEntity(UnityEngine.HyperGryph.ECS.Entity gameplayEntity, UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc desc)
  System.Void UpdateRegularEntityAdditiveMaterials(UnityEngine.HyperGryph.ECS.Entity gameplayEntity, UnityEngine.Material[] additiveMaterials)
  System.Void DestroyRegularEntity(UnityEngine.HyperGryph.ECS.Entity gameplayEntity)
  System.Void CreateBatchedEntities(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc desc, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> entities, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> gameplayEntities, System.String entityName)
  System.Void DestroyBatchedEntities(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> gameplayEntities)
  System.Void CreateBatchedEntities(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc desc, System.IntPtr entities, System.IntPtr gameplayEntities, System.Int32 count, System.String entityName)
  System.Void DestroyBatchedEntities(System.IntPtr gameplayEntities, System.Int32 count)
  System.Void SetEntityEnabledLightModes(UnityEngine.HyperGryph.ECS.Entity rendererEntity, System.UInt32 lightModeMask)
  System.Void SetEntitySharedData(System.UInt32 sharedDataIndex, T data, System.Int32 offset)
  System.Void SetEntitySharedDataPartial(System.UInt32 sharedDataIndex, System.IntPtr data, System.Int32 offset, System.Int32 size)
  System.Byte GetEntityDirtyFlags(System.UInt32 sharedDataIndex)
  System.Void SetEntityDirtyFlags(System.UInt32 sharedDataIndex, System.Byte flags)
  System.Byte GetEntityObjectFlags(System.UInt32 sharedDataIndex)
  System.UInt32 GetEntityAdditiveVFXFlags(System.UInt32 sharedDataIndex)
  System.Void SetEntityAdditiveVFXFlags(System.UInt32 sharedDataIndex, System.UInt32 flags)
  System.Void FrameUpdateEntities()
  System.Void CreateRegularEntity_Injected(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc& desc, System.String entityName, UnityEngine.HyperGryph.ECS.Entity& gameplayEntity, UnityEngine.Material[] additiveMaterials, UnityEngine.HyperGryph.ECS.Entity& ret)
  System.Void UpdateRegularEntity_Injected(UnityEngine.HyperGryph.ECS.Entity& gameplayEntity, UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc& desc)
  System.Void UpdateRegularEntityAdditiveMaterials_Injected(UnityEngine.HyperGryph.ECS.Entity& gameplayEntity, UnityEngine.Material[] additiveMaterials)
  System.Void DestroyRegularEntity_Injected(UnityEngine.HyperGryph.ECS.Entity& gameplayEntity)
  System.Void CreateBatchedEntities_Injected(UnityEngine.HyperGryph.HGFactoryInstancingLODDataV2[] entityData, UnityEngine.HyperGryph.HGFactoryEntityDesc& desc, System.IntPtr entities, System.IntPtr gameplayEntities, System.Int32 count, System.String entityName)
  System.Void SetEntityEnabledLightModes_Injected(UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.UInt32 lightModeMask)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFoliageInteractCPP
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    compID  // 0x10
  public            UnityEngine.Transform           transform  // 0x18
  public            UnityEngine.Mesh                interactCollider  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFoliageInteractRaftCPP
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    compID  // 0x10
  public            UnityEngine.Transform           transform  // 0x18
  public            UnityEngine.Mesh                interactCollider  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFoliageInteractiveManagerV2
TYPE:  class
TOKEN: 0x200001E
FIELDS:
METHODS:
  System.Void SetupFoliageInteractiveManager(UnityEngine.Mesh characterProxyMesh, System.Boolean enabled)
  System.Void CleanUpFoliageInteractiveManager()
  System.Void SetEnabled(System.Boolean enabled)
  System.Void SetInteractCenter(UnityEngine.Vector3 center)
  System.Void SetCharacterPositions(System.Collections.Generic.List<UnityEngine.Vector3> positions)
  System.Void SetCharacterPositions(UnityEngine.Vector3* positions, System.Int32 count)
  System.Void RegisterInteract(UnityEngine.HyperGryph.HGFoliageInteractCPP interact)
  System.Void UnregisterInteract(System.Int32 interactInstID)
  System.Void RegisterInteractRaft(UnityEngine.HyperGryph.HGFoliageInteractRaftCPP raft)
  System.Void UnregisterInteractRaft(System.Int32 raftInstID)
  System.Void SetInteractCenter_Injected(UnityEngine.Vector3& center)
  System.Void RegisterInteract_Injected(UnityEngine.HyperGryph.HGFoliageInteractCPP& interact)
  System.Void RegisterInteractRaft_Injected(UnityEngine.HyperGryph.HGFoliageInteractRaftCPP& raft)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFoliageOccluderManagerV2
TYPE:  class
TOKEN: 0x200001F
FIELDS:
METHODS:
  System.Void SetCenterPosition(UnityEngine.Vector3 center)
  System.Void SetCenterPosition_Injected(UnityEngine.Vector3& center)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFoliageOccluderRender
TYPE:  class
TOKEN: 0x2000020
FIELDS:
METHODS:
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 materialHandle, System.UInt32 geometryHandle, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context)
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 materialHandle, System.UInt32 geometryHandle, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32* drawableFeedbackPtr)
  System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList)
END_CLASS

CLASS: UnityEngine.HyperGryph.GpuClothClearBufferDataCPP
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Boolean                  shouldClear  // 0x10
  public            UnityEngine.HyperGryph.IVec4    eleNum  // 0x14
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: UnityEngine.HyperGryph.ClothGroupUploadDataMapCPP
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  private           UnityEngine.HyperGryph.IVec4    clothNodeDataMap  // 0x10
  private           UnityEngine.HyperGryph.IVec4    clothBatchMetaDataMap  // 0x20
  private           UnityEngine.HyperGryph.IVec4    clothBatchCacheDataMap  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ClothMetaDataCPP
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  private           System.UInt32                   clothNodeIdxStart  // 0x10
  private           System.UInt32                   clothNodeIdxEnd  // 0x14
  private           System.UInt32                   batchIdxStart  // 0x18
  private           System.UInt32                   iterNum  // 0x1C
  private           System.Single                   damping  // 0x20
  private           System.Single                   windFreqFactor  // 0x24
  private           System.Single                   windBalanceFactor  // 0x28
  private           System.Single                   windIntensityScale  // 0x2C
  private           UnityEngine.HyperGryph.IVec4    groupOffset  // 0x30
  private           UnityEngine.Vector4             packedLongestAnchorDistance  // 0x40
  private           UnityEngine.Vector4             packedClothNormal  // 0x50
  private           UnityEngine.Vector4             localToWorld0  // 0x60
  private           UnityEngine.Vector4             localToWorld1  // 0x70
  private           UnityEngine.Vector4             localToWorld2  // 0x80
  private           UnityEngine.Vector4             worldToLocal0  // 0x90
  private           UnityEngine.Vector4             worldToLocal1  // 0xA0
  private           UnityEngine.Vector4             worldToLocal2  // 0xB0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ClothNodeDataCPP
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  private           UnityEngine.HyperGryph.IVec2    anchorNodeCacheIdx  // 0x10
  private           UnityEngine.Vector2             anchorNodeDistance  // 0x18
  private           UnityEngine.Vector2             uv  // 0x20
  private           UnityEngine.Vector2             collisionPlaneXY  // 0x28
  private           UnityEngine.Vector4             packedBasePosition  // 0x30
  private           UnityEngine.Vector4             packedBaseNormal  // 0x40
  private           UnityEngine.Vector4             baseTangent  // 0x50
  private           UnityEngine.Vector4             packedPrePosition  // 0x60
  private           UnityEngine.Vector4             packedCurPosition  // 0x70
  private           UnityEngine.Vector4             packedCurNormal  // 0x80
  private           UnityEngine.HyperGryph.ClothNodeDataCPP.<neighborClothNodeCacheIdx>e__FixedBufferneighborClothNodeCacheIdx  // 0x90
  private           UnityEngine.HyperGryph.ClothNodeDataCPP.<neighborClothNodeDistance>e__FixedBufferneighborClothNodeDistance  // 0xB0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.GpuClothGroupUploadDataCPP
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Boolean                  isValid  // 0x10
  public            System.Int32                    uploadDataMapNum  // 0x14
  public            System.IntPtr                   uploadDataMap  // 0x18
  public            System.Int32                    clothMetaUploadDataNum  // 0x20
  public            System.IntPtr                   clothMetaUploadData  // 0x28
  public            System.Int32                    clothNodeUploadDataNum  // 0x30
  public            System.IntPtr                   clothNodeUploadData  // 0x38
  public            System.Int32                    clothBatchMetaUploadDataNum  // 0x40
  public            System.IntPtr                   clothBatchMetaUploadData  // 0x48
  public            System.Int32                    clothBatchCacheMapUploadDataNum  // 0x50
  public            System.IntPtr                   clothBatchCacheMapUploadData  // 0x58
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: UnityEngine.HyperGryph.ClothConstDataCPP
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  private           UnityEngine.Vector4             packedDeltaT  // 0x10
  private           UnityEngine.Vector4             clothParam1  // 0x20
  private           UnityEngine.HyperGryph.ClothConstDataCPP.<colliderInfos>e__FixedBuffercolliderInfos  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.GpuClothRenderDataCPP
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Boolean                  isValid  // 0x10
  public            System.Int32                    clothNum  // 0x14
  public            UnityEngine.HyperGryph.ClothConstDataCPPclothConstData  // 0x18
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: UnityEngine.HyperGryph.HGGpuClothManagerV2
TYPE:  class
TOKEN: 0x200002B
FIELDS:
METHODS:
  System.Void SetupGpuClothManager(UnityEngine.Mesh defaultCapsuleMesh)
  System.Void SetWindDirection(UnityEngine.Vector3 direction)
  System.Void SetPlayerCenter(UnityEngine.Vector3 playerCenter)
  System.Void UpdateCharacterPositions(System.Collections.Generic.List<UnityEngine.Vector3> positions)
  System.Void UpdateCharacterPositions(UnityEngine.Vector3* positionPtr, System.Int32 count)
  System.Boolean IsClothSkeletonValid()
  System.Boolean IsClothSkeletonFlipped()
  System.Boolean ShouldStep()
  UnityEngine.HyperGryph.GpuClothClearBufferDataCPP GetClearBufferData_CSharpWrapper()
  UnityEngine.HyperGryph.GpuClothGroupUploadDataCPP GetUploadData_CSharpWrapper()
  UnityEngine.HyperGryph.GpuClothRenderDataCPP GetRenderData_CSharpWrapper()
  System.UInt32 GetSkeletonBufferID()
  System.UInt32 GetClothNodeBufferID()
  System.UInt32 GetClothMetaDataBufferID()
  System.UInt32 GetClothBatchMetaDataBufferID()
  System.UInt32 GetClothBatchCacheMapBufferID()
  System.Void SetWindDirection_Injected(UnityEngine.Vector3& direction)
  System.Void SetPlayerCenter_Injected(UnityEngine.Vector3& playerCenter)
  System.Void GetClearBufferData_CSharpWrapper_Injected(UnityEngine.HyperGryph.GpuClothClearBufferDataCPP& ret)
  System.Void GetUploadData_CSharpWrapper_Injected(UnityEngine.HyperGryph.GpuClothGroupUploadDataCPP& ret)
  System.Void GetRenderData_CSharpWrapper_Injected(UnityEngine.HyperGryph.GpuClothRenderDataCPP& ret)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGLODStateSystem
TYPE:  class
TOKEN: 0x200002C
FIELDS:
METHODS:
  System.Boolean IsCurrFrameTriggerTransition()
  System.Single GetLODTransitionFraction()
  System.Single GetLODTransitionTime()
  System.Void SetLODTransitionTime(System.Single lodTransitionTime)
END_CLASS

CLASS: UnityEngine.HyperGryph.LODStreamingStatus
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.LODStreamingStatusIdle  // 0x0
  public    static  UnityEngine.HyperGryph.LODStreamingStatusLoading  // 0x0
  public    static  UnityEngine.HyperGryph.LODStreamingStatusUnloading  // 0x0
  public    static  UnityEngine.HyperGryph.LODStreamingStatusDisabled  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGLODStreamingSystem
TYPE:  class
TOKEN: 0x200002E
FIELDS:
METHODS:
  System.Boolean get_enableLODStreaming()
  System.Void set_enableLODStreaming(System.Boolean value)
  System.Void set_enableLODStreamingKeepLastLODResource(System.Boolean value)
  System.Void set_lodConfig(UnityEngine.HyperGryph.LODCrossFadeConfig value)
  System.Void SetArtTagLODStreamingOffset(System.UInt32 artTag, System.Int32 lodStreamingOffset)
  System.Void SetHLODUnloadDistance(System.Int32 hlodLevel, System.Single unloadDistance)
  System.Void set_lodStreamingLoadDirtyDistance(System.Single value)
  System.Void set_lodStreamingUnloadDirtyDistance(System.Single value)
  UnityEngine.HyperGryph.LODStreamingStatus QueryLODStreamingStatus()
  System.Void set_lodConfig_Injected(UnityEngine.HyperGryph.LODCrossFadeConfig& value)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGShadingStateSystem
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  private   static  UnityEngine.Events.UnityAction<System.Int32,System.Boolean>shadingStateChanged  // 0x0
METHODS:
  System.UInt32 GetMaterialHandle(System.Int32 instanceId)
  UnityEngine.Material GetMaterial(System.UInt32 handle)
  System.Void add_shadingStateChanged(UnityEngine.Events.UnityAction<System.Int32,System.Boolean> value)
  System.Void remove_shadingStateChanged(UnityEngine.Events.UnityAction<System.Int32,System.Boolean> value)
  System.Void Internal_OnShadingStateChanged(System.Int32 instanceId, System.Boolean state)
  System.Void FlushAllMaterialCallbacks()
END_CLASS

CLASS: UnityEngine.HyperGryph.HGGeometrySystem
TYPE:  class
TOKEN: 0x2000030
FIELDS:
METHODS:
  System.UInt32 GetGeometryHandle(System.Int32 instanceId)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGGraphicsUtils
TYPE:  class
TOKEN: 0x2000031
FIELDS:
METHODS:
  System.Boolean get_enableRayTracing()
  System.Void set_enableRayTracing(System.Boolean value)
  System.Boolean get_enableRayTracingRender()
  System.Void set_enableRayTracingRender(System.Boolean value)
  System.Boolean get_enableECSRenderer()
  System.Boolean get_enableHGNewGraphicsAPI()
  System.Boolean get_enableCppRenderPath()
  System.Int32 get_maxAnisoLevel()
  System.Void set_maxAnisoLevel(System.Int32 value)
  System.Void set_enableRenderingCommandBufferDirectCall(System.Boolean value)
  UnityEngine.Rendering.CBHandle HGAllocateTempVertexBuffer(System.Int32 size)
  System.UInt32 AllocateTempCompoundRendererListFromScript(System.IntPtr& outPtr)
  System.Boolean IsCompoundRendererListDrawable(System.UInt32 id)
  System.Void PrepareGeometryJobRenderersForRendering()
  System.UInt32 CreateMetalFXSpatialScaler(System.Int32 inputWidth, System.Int32 inputWeight, System.Int32 outputWidth, System.Int32 outputHeight, UnityEngine.Experimental.Rendering.GraphicsFormat colorTextureFormat, UnityEngine.Experimental.Rendering.GraphicsFormat outputTextureFormat)
  System.Void DestroyMetalFXSpatialScaler(System.UInt32 spatialScalerHandle)
  System.UInt32 CreateMetalFXTemporalScaler(System.Int32 inputWidth, System.Int32 inputWeight, System.Int32 outputWidth, System.Int32 outputHeight, UnityEngine.Experimental.Rendering.GraphicsFormat colorTextureFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthTextureFormat, UnityEngine.Experimental.Rendering.GraphicsFormat motionTextureFormat, UnityEngine.Experimental.Rendering.GraphicsFormat outputTextureFormat)
  System.Void DestroyMetalFXTemporalScaler(System.UInt32 temporalScalerHandle)
  System.Void HGAllocateTempVertexBuffer_Injected(System.Int32 size, UnityEngine.Rendering.CBHandle& ret)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGRendererSystem
TYPE:  class
TOKEN: 0x2000032
FIELDS:
METHODS:
  System.Void set_PerRendererLightingFallbackPosition(UnityEngine.Vector3 value)
  System.UInt32 get_MaxPerRendererLightingCount()
  System.Void set_CSMStopRenderCharacterCascadeLevel(System.UInt32 value)
  System.Void set_PerRendererLightingFallbackPosition_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGLogicTimeManager
TYPE:  class
TOKEN: 0x2000033
FIELDS:
METHODS:
  System.Void SetLogicTickDeltaTime(System.Single deltaTime)
  System.Void SetHgrpDeltaTime(System.Single deltaTime)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGGrassRender
TYPE:  class
TOKEN: 0x2000034
FIELDS:
METHODS:
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context, System.Boolean noAlphaTest)
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32* drawableFeedbackPtr, System.Boolean noAlphaTest)
  System.UInt32 RegisterGrassBatchGroup(System.UInt32 batchGroupKey, UnityEngine.Material material, UnityEngine.Mesh mesh, System.UInt16 subMeshIndex)
  System.Void UnregisterGrassBatchGroupWithHandle(System.UInt32 batchGroupKey, System.UInt32 batchGroupHandle)
  System.Boolean IsInGrassBoundsV2(UnityEngine.Vector3 worldPos, UnityEngine.Bounds& overlapBounds, UnityEngine.Bounds& originBounds, System.UInt32& argTag)
  System.Void set_grassGlobalSparsity(System.Single value)
  System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList)
  System.Boolean IsInGrassBoundsV2_Injected(UnityEngine.Vector3& worldPos, UnityEngine.Bounds& overlapBounds, UnityEngine.Bounds& originBounds, System.UInt32& argTag)
END_CLASS

CLASS: UnityEngine.HyperGryph.EInteractionProxyType
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.HyperGryph.EInteractionProxyTypeSphere  // 0x0
  public    static  UnityEngine.HyperGryph.EInteractionProxyTypeCapsule  // 0x0
  public    static  UnityEngine.HyperGryph.EInteractionProxyTypeTexture  // 0x0
  public    static  UnityEngine.HyperGryph.EInteractionProxyTypeMesh  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGInteractionNodeV2
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    m_nodeKey  // 0x10
  public            UnityEngine.HyperGryph.EInteractionProxyTypem_proxyType  // 0x14
  public            UnityEngine.Matrix4x4           m_localToWorldMatrix  // 0x18
  public            UnityEngine.Matrix4x4           m_prevLocalToWorldMatrix  // 0x58
  public            System.Single                   m_groundHeight  // 0x98
  public            System.Boolean                  m_bUseCCD  // 0x9C
  public            System.Single                   m_length  // 0xA0
  public            System.Single                   m_radius  // 0xA4
  public            System.Single                   m_interactLength  // 0xA8
  public            System.Single                   m_interactHeight  // 0xAC
  public            System.Int32                    m_texture  // 0xB0
  public            UnityEngine.Vector2             m_extent  // 0xB4
  public            System.Single                   m_heightScale  // 0xBC
  public            System.Int32                    m_mesh  // 0xC0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGDecalInteractionParametersV2
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Boolean                  m_enableDecalInteraction  // 0x10
  public            System.IntPtr                   m_decalInteractionMaterial  // 0x18
  public            System.Single                   m_decalNodeWidth  // 0x20
  public            System.Single                   m_decalNodeLength  // 0x24
  public            System.Single                   m_decalNodeHeadLength  // 0x28
  public            System.Single                   m_decalNodeOffset  // 0x2C
  public            System.Single                   m_nodeDistanceThreshold  // 0x30
  public            System.Single                   m_edgeFadeDistance  // 0x34
  public            System.Single                   m_heightFadeDistanceMin  // 0x38
  public            System.Single                   m_heightFadeDistanceMax  // 0x3C
  public            System.Single                   m_rotationThreshold  // 0x40
  public            System.Single                   m_backwardDistanceThreshold  // 0x44
  public            System.Single                   m_timeFadeSpeed  // 0x48
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGInteractionManagerV2
TYPE:  class
TOKEN: 0x2000038
FIELDS:
METHODS:
  System.Void UpdateFromNodes(Unity.Collections.NativeArray<UnityEngine.HyperGryph.HGInteractionNodeV2> nodes, System.Int32 nodeCount, System.Boolean bUpdateMobile)
  System.Void UpdateFromNodes(System.IntPtr nodeData, System.Int32 nodeCount, System.Boolean bUpdateMobile)
  System.Void UpdateSettingParameters(UnityEngine.HyperGryph.HGDecalInteractionParametersV2 settingParameters)
  System.Void UpdateSettingParameters_Injected(UnityEngine.HyperGryph.HGDecalInteractionParametersV2& settingParameters)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGIrradianceVolumeConfig
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            System.UInt32                   enableLowQualityMode  // 0x10
  public            System.Int32                    indirectionTextureSize  // 0x14
  public            System.UInt32                   blockCountX  // 0x18
  public            System.UInt32                   blockCountY  // 0x1C
  public            System.UInt32                   blockCountZ  // 0x20
  public            System.UInt32                   hashTableSize  // 0x24
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perLOD>e__FixedBufferperLOD  // 0x28
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perHalfChunkCounts>e__FixedBufferperHalfChunkCounts  // 0x34
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perHashTableOffsets>e__FixedBufferperHashTableOffsets  // 0x40
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perHashTableSizes>e__FixedBufferperHashTableSizes  // 0x4C
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perPhysicalTextureOffsets>e__FixedBufferperPhysicalTextureOffsets  // 0x58
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perPhysicalTextureBlockCounts>e__FixedBufferperPhysicalTextureBlockCounts  // 0x64
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perFrameMaxLoadingByteCount>e__FixedBufferperFrameMaxLoadingByteCount  // 0x70
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<perFrameMaxUploadChunkCount>e__FixedBufferperFrameMaxUploadChunkCount  // 0x7C
  public            System.UInt32                   perFrameMaxLoadingByteCountV3  // 0x88
  public            System.UInt32                   perFrameMaxUploadChunkCountV3  // 0x8C
  public            System.UInt32                   maxHashTableSize  // 0x90
  public            System.UInt32                   maxInactiveFrameCount  // 0x94
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<ClipmapTextureSize>e__FixedBufferClipmapTextureSize  // 0x98
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<blockSizesV3>e__FixedBufferblockSizesV3  // 0xA4
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfig.<cameraForwardBiasForYAxis>e__FixedBuffercameraForwardBiasForYAxis  // 0xB0
  public            System.UInt32                   maxRegionCount  // 0xBC
  public            System.Int32                    regionAtlasSizeX  // 0xC0
  public            System.Int32                    regionAtlasSizeY  // 0xC4
  public            System.Int32                    regionAtlasSizeZ  // 0xC8
  public            System.UInt32                   enableLowMemoryMode  // 0xCC
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGIrradianceVolumePipelineUpdateResult
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            UnityEngine.Vector4             param0  // 0x10
  public            UnityEngine.Vector4             param1  // 0x20
  public            UnityEngine.Vector4             param2  // 0x30
  public            UnityEngine.Vector4             param3  // 0x40
  public            UnityEngine.Texture             indirectionTexture  // 0x50
  public            UnityEngine.Texture             physicalTexture0  // 0x58
  public            UnityEngine.Texture             physicalTexture1  // 0x60
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGIrradianceVolume
TYPE:  class
TOKEN: 0x2000046
FIELDS:
METHODS:
  System.Int64 Create(UnityEngine.HyperGryph.HGIrradianceVolumeConfig& config)
  System.Void Destroy(System.Int64 id)
  System.Void SetEnableV3(System.Boolean enable)
  System.Void SetSceneStateNames(System.String[] stateNames, System.String[] activateStates)
  System.Void SetActiveSceneStateNames(System.String[] activateNames)
  System.Void SetActiveSceneStateMask(System.UInt32 mask)
  System.String[] GetActiveSceneStateNames()
  System.Void SetMap(System.Int64 id, System.String path)
  System.Void SetMapV3(System.Int64 id, System.String path)
  System.Void StreamingInCabin(System.Int64 id, System.String slotId, System.UInt32 roomTypeId)
  System.Void StreamingOutCabin(System.Int64 id, System.String slotId)
  System.Void SetStreamingCenter(System.Int64 id, UnityEngine.Vector3 center)
  System.Void PipelineUpdate(UnityEngine.HyperGryph.HGIrradianceVolumePipelineUpdateResult& result, System.Int64 id, System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.Int32 bakeCS, System.Int32 updateIndirectionCS)
  System.Void SetStreamingCenter_Injected(System.Int64 id, UnityEngine.Vector3& center)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.UInt32                   enableLowQualityMode  // 0x10
  public            System.Int32                    clipMapTextureSizeX  // 0x14
  public            System.Int32                    clipMapTextureSizeY  // 0x18
  public            System.Int32                    clipMapTextureSizeZ  // 0x1C
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<basisBaseGridDim>e__FixedBufferbasisBaseGridDim  // 0x20
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<basisVoxelDataDim>e__FixedBufferbasisVoxelDataDim  // 0x38
  public            System.UInt32                   coeffBaseGridDim  // 0x50
  public            System.UInt32                   coeffVoxelDataDim  // 0x54
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perCoeffLodBudget>e__FixedBufferperCoeffLodBudget  // 0x58
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBasisLodBudget>e__FixedBufferperBasisLodBudget  // 0x64
  public            System.UInt32                   lod3BaseGridDim  // 0x70
  public            System.UInt32                   lod3VoxelDataDim  // 0x74
  public            System.UInt32                   lod3Budget  // 0x78
  public            System.UInt32                   rawDataSize  // 0x7C
  public            System.UInt32                   modelBufferBudget  // 0x80
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perLOD>e__FixedBufferperLOD  // 0x84
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perHalfStreamingChunkCountsX>e__FixedBufferperHalfStreamingChunkCountsX  // 0x90
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perHalfStreamingChunkCountsY>e__FixedBufferperHalfStreamingChunkCountsY  // 0x9C
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perHalfStreamingChunkCountsZ>e__FixedBufferperHalfStreamingChunkCountsZ  // 0xA8
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perRawBufferOffsets>e__FixedBufferperRawBufferOffsets  // 0xB4
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perRawBufferCounts>e__FixedBufferperRawBufferCounts  // 0xC0
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBlockInfoBufferOffsets>e__FixedBufferperBlockInfoBufferOffsets  // 0xCC
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBlockInfoSize>e__FixedBufferperBlockInfoSize  // 0xD8
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBasisTextureOffset>e__FixedBufferperBasisTextureOffset  // 0xE4
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perBasisTextureBlockCounts>e__FixedBufferperBasisTextureBlockCounts  // 0xF0
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perCoeffTextureOffset>e__FixedBufferperCoeffTextureOffset  // 0xFC
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perCoeffTextureBlockCounts>e__FixedBufferperCoeffTextureBlockCounts  // 0x108
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perFrameMaxLoadingByteCount>e__FixedBufferperFrameMaxLoadingByteCount  // 0x114
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<perFrameMaxUploadChunkCount>e__FixedBufferperFrameMaxUploadChunkCount  // 0x120
  public            System.UInt32                   maxRegionCount  // 0x12C
  public            System.UInt32                   regionAtlasSizeX  // 0x130
  public            System.UInt32                   regionAtlasSizeY  // 0x134
  public            System.UInt32                   regionAtlasSizeZ  // 0x138
  public            UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2.<streamingCenterBias>e__FixedBufferstreamingCenterBias  // 0x13C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGIrradianceVolumePipelineUpdateResultV2
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public            UnityEngine.Vector4             param0  // 0x10
  public            UnityEngine.Vector4             param1  // 0x20
  public            UnityEngine.Vector4             param2  // 0x30
  public            UnityEngine.Vector4             param3  // 0x40
  public            UnityEngine.Texture             clipmapTextureALod0  // 0x50
  public            UnityEngine.Texture             clipmapTextureBLod0  // 0x58
  public            UnityEngine.Texture             clipmapTextureALod1  // 0x60
  public            UnityEngine.Texture             clipmapTextureBLod1  // 0x68
  public            UnityEngine.Texture             clipmapTextureALod3  // 0x70
  public            UnityEngine.Texture             clipmapTextureBLod3  // 0x78
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGIrradianceVolumeV2
TYPE:  class
TOKEN: 0x200005C
FIELDS:
METHODS:
  System.Int64 Create(UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2& config)
  System.Void Destroy(System.Int64 id)
  System.Void SetSceneStateNames(System.String[] stateNames, System.String[] activateStates)
  System.Void SetActiveSceneStateNames(System.String[] activateStates)
  System.Void SetActiveSceneStateMask(System.UInt32 mask)
  System.String[] GetActiveSceneStateNames()
  System.Void SetMap(System.Int64 id, System.String path)
  System.Void SetStreamingCenter(System.Int64 id, UnityEngine.Vector3 center)
  System.Void SetCameraForwardDirection(System.Int64 id, UnityEngine.Vector3 cameraForwardDir)
  System.Void PipelineUpdate(UnityEngine.HyperGryph.HGIrradianceVolumePipelineUpdateResultV2& result, System.Int64 id, System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.Int32 bakeCS, System.Int32 updateClipmapCS)
  System.Void StreamingInCabin(System.Int64 id, System.Int64 slotId, System.UInt32 roomTypeId)
  System.Void StreamingOutCabin(System.Int64 id, System.Int64 slotId)
  System.Void SetStreamingCenter_Injected(System.Int64 id, UnityEngine.Vector3& center)
  System.Void SetCameraForwardDirection_Injected(System.Int64 id, UnityEngine.Vector3& cameraForwardDir)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGMeshRender
TYPE:  class
TOKEN: 0x200005D
FIELDS:
METHODS:
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.UInt16 globalKeywords, System.IntPtr context, System.Boolean multiDraw, System.Boolean transparentSorting, System.UInt32 cullingLayerMask, System.Boolean noAlphaTest, System.UInt32* drawableFeedbackPtr, System.Boolean excludeGPUDriven)
  System.Void CreateRendererListWithPreZ(System.UInt32 viewHandle, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.IntPtr context, System.UInt32& normalList, System.UInt32& preZPart0List, System.UInt32& preZPart1List, System.Boolean excludeGPUDriven)
  System.UInt32 CreateRendererListWithCharacterIndex(System.UInt32 viewHandle, System.UInt16 characterIndex, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.UInt16 globalHGKeywords, System.IntPtr context)
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, UnityEngine.HyperGryph.HGRenderKeyword globalKeywords, System.IntPtr context, System.Boolean multiDraw, System.Boolean transparentSorting, System.UInt32 cullingLayerMask, System.Boolean noAlphaTest, System.Boolean excludeGPUDriven)
  System.UInt32 CreateRendererList(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, UnityEngine.HyperGryph.HGRenderKeyword globalKeywords, System.IntPtr context, System.IntPtr drawableFeedbackPtr, System.Boolean multiDraw, System.Boolean transparentSorting, System.UInt32 cullingLayerMask, System.Boolean noAlphaTest, System.Boolean excludeGPUDriven)
  System.UInt32 CreateRendererListWithCharacterIndex(System.UInt32 viewHandle, System.UInt16 characterIndex, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, UnityEngine.HyperGryph.HGRenderKeyword globalKeywords, System.IntPtr context)
  System.Void CreateRendererListWithPreZ(System.UInt32 viewHandle, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.IntPtr context, System.UInt32& normalList, System.UInt32& preZPart0List, System.UInt32& preZPart1List, System.Boolean excludeGPUDriven)
  System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList)
  System.Void DrawECSMeshRendererListWithSRPRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 ecsList, UnityEngine.Rendering.RendererUtils.RendererList srpList)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGRayTracingScene
TYPE:  class
TOKEN: 0x200005E
FIELDS:
METHODS:
  System.UInt32 AddCullViewHandle(System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig config, System.Single viewScreenSizeMinSquared, System.Single cullingRadius)
  System.UInt32 PrepareTLASCreationForCullView(System.UInt32 viewHandle)
  System.UInt32 AddCullViewHandle_Injected(System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig& config, System.Single viewScreenSizeMinSquared, System.Single cullingRadius)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGReflectionProbe
TYPE:  class
TOKEN: 0x200005F
FIELDS:
METHODS:
  System.Single get_cameraMovementNotFadeness()
  System.Single get_fadeTime()
  System.UInt32 AddView(UnityEngine.Camera camera)
  System.Void RemoveView(System.UInt32 viewHandle)
  System.Void ResetView(System.UInt32 viewHandle)
  System.Void UpdateViewPhase0(System.UInt32 viewHandle, UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 visibleBox, System.Boolean loadSync)
  System.Void UpdateViewPhase1(System.UInt32 viewHandle, System.Single dt, System.Boolean enableFadeness, System.IntPtr blitList, System.Int32 maxBlitCount, System.Int32& blitCount)
  System.Void UpdateViewCBHandle(System.UInt32 viewHandle, UnityEngine.Matrix4x4 worldToCameraMatrix, UnityEngine.Matrix4x4 unitExtents, System.IntPtr binningBufferPtr, System.IntPtr globalBufferPtr)
  UnityEngine.Texture GetTexture(System.UInt32 viewHandle, System.UInt64 hash)
  System.Int32 GetTextureIndex(System.UInt32 viewHandle, System.UInt64 hash)
  System.Void SetViewTextureArrayCount(System.UInt32 viewHandle, System.Int32 count)
  System.Void UpdateViewPhase0_Injected(System.UInt32 viewHandle, UnityEngine.Vector3& cameraPosition, UnityEngine.Vector3& visibleBox, System.Boolean loadSync)
  System.Void UpdateViewCBHandle_Injected(System.UInt32 viewHandle, UnityEngine.Matrix4x4& worldToCameraMatrix, UnityEngine.Matrix4x4& unitExtents, System.IntPtr binningBufferPtr, System.IntPtr globalBufferPtr)
END_CLASS

CLASS: UnityEngine.HyperGryph.AssetType
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryph.AssetTypeInvalid  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeMaterial  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeMesh  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeTexture2D  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeTexture3D  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeCubeMap  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeScriptableObject  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeShader  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeComputeShader  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeTerrainLayer  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeSubsurfaceProfile  // 0x0
  public    static  UnityEngine.HyperGryph.AssetTypeCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.AssetPriority
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  UnityEngine.HyperGryph.AssetPriorityPreload  // 0x0
  public    static  UnityEngine.HyperGryph.AssetPriorityLODStreaming  // 0x0
  public    static  UnityEngine.HyperGryph.AssetPriorityDefault  // 0x0
  public    static  UnityEngine.HyperGryph.AssetPriorityStreaming  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.AssetState
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.AssetStateLoading  // 0x0
  public    static  UnityEngine.HyperGryph.AssetStateLoaded  // 0x0
  public    static  UnityEngine.HyperGryph.AssetStateFailed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.VFSBlockFileInfo
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            System.UInt64                   offset  // 0x10
  public            System.UInt64                   len  // 0x18
  public            System.String                   chunkFilePath  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.AssetIdentifier
TYPE:  struct
TOKEN: 0x2000064
FIELDS:
  public            System.Int64                    hash  // 0x10
  public            UnityEngine.HyperGryph.AssetTypetype  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.AssetOperation
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Boolean                  isLoadOperation  // 0x10
  public            UnityEngine.HyperGryph.AssetPrioritypriority  // 0x12
  public            System.UInt32                   handleIndex  // 0x14
  public            UnityEngine.HyperGryph.AssetIdentifieridentifier  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGResourceManager
TYPE:  class
TOKEN: 0x2000066
FIELDS:
  public    static  UnityEngine.HyperGryph.HGResourceManager.GetFileHashMappingCallbackgetFileHashMappingCallback  // 0x0
  public    static  UnityEngine.HyperGryph.HGResourceManager.GetFilePathMappingCallbackgetFilePathMappingCallback  // 0x8
  public    static  UnityEngine.HyperGryph.HGResourceManager.GetTextureFromHGWaterSectorDataCallbackgetWaterSectorTextureCallback  // 0x10
  private   static readonly System.Type[]                   kAssetTypeToUnityType  // 0x18
METHODS:
  System.Void set_usingVFS(System.Boolean value)
  System.UInt32 LoadAsync(System.Int64 assetHash, UnityEngine.HyperGryph.AssetType type, UnityEngine.HyperGryph.AssetPriority priority)
  System.Void Dispose(System.UInt32 assetHandle)
  UnityEngine.HyperGryph.AssetState GetAssetState(System.UInt32 assetHandle)
  UnityEngine.Object GetAsset(System.UInt32 assetHandle)
  System.Boolean TryGetAsset(System.UInt32 assetHandle, T& asset)
  System.Void UpdateAssetHandle(System.UInt32 handleIndex, UnityEngine.HyperGryph.AssetIdentifier identifier, UnityEngine.HyperGryph.AssetState state, System.Int32 assetInstanceID)
  System.IntPtr get_assetOperations()
  System.Int32 get_assetOperationCount()
  System.Void ClearAssetOperations()
  System.Void Reset()
  UnityEngine.HyperGryph.VFSBlockFileInfo GetFileHashMapping(System.Int64 originNameHash)
  UnityEngine.HyperGryph.VFSBlockFileInfo GetFilePathMapping(System.String originName)
  UnityEngine.Texture2D GetTextureFromHGWaterSectorData(UnityEngine.ScriptableObject sectorDataScriptableObject)
  System.Type ToUnityType(UnityEngine.HyperGryph.AssetType type)
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.AssetOperation> GetAssetOperationsArray()
  System.Void .cctor()
  System.Void UpdateAssetHandle_Injected(System.UInt32 handleIndex, UnityEngine.HyperGryph.AssetIdentifier& identifier, UnityEngine.HyperGryph.AssetState state, System.Int32 assetInstanceID)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGRenderFlags
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.HyperGryph.HGRenderFlagsNone  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsPreZ  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsShadowTwoSided  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsNegativeScale  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsPreZEqual  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsAlphaTest  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsOpaque  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsTransparent  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsShadowOnly  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsTransparentBeforeDistortion  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsTransparentAfterDistortionBeforePP  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsTransparentAfterDistortion  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsTransparentAfterPP  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsHasCustomProps  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsManualDither  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsCameraDither  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsCastShadow  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsCSMShadowCascade0  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsCSMShadowCascade1  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsCSMShadowCascade2  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsCSMShadowCascade3  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsCSMShadows  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsStaticShadowCaster  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsRealtimeShadowCaster  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsEnableCharacterOutline  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderFlagsRayTracing  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGRenderKeyword
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  UnityEngine.HyperGryph.HGRenderKeywordNone  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderKeywordCrossFade  // 0x0
  public    static  UnityEngine.HyperGryph.HGRenderKeywordDither  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGShaderLightMode
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.HyperGryph.HGShaderLightModeNone  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeGBuffer  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeGBufferMobile  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeErosion  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeErosionMobile  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeErosionClear  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeForwardOnly  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeForward  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeForwardCharacterOnly  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeForwardReflection  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeCharacterOutline  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeShadowCaster  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeDepthOnly  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeDepthCharacterOnly  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeSRPDefaultUnlit  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeForwardDecal  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeVFXDecal  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeWetnessDecal  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeDistortion  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeFullScreenDebug  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeOccludedDisplay  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeTerrainVTDecal  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeTerrainVTDecalMobile  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeRayTracingReflection  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeStencilAlphaBlend  // 0x0
  public    static  UnityEngine.HyperGryph.HGShaderLightModeWaterMarkUI  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGObjectFlags
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.HyperGryph.HGObjectFlagsNone  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsEnabled  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCastShadow  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsNegativeScale  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsPrevResReady  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCurrResReady  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsTempResReady  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsResReadyMask  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsPrevHideByHLODSystem  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCurrHideByHLODSystem  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsTempHideAsHLODChildByHLODSystem  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsTempHideAsHLODParentByHLODSystem  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsTempHideByHLODSystemMask  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsHideByHLODSystemMask  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsTransformDirty  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsStatic  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsManualDither  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCameraDither  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsFoliageOccluder  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCpuSkinning  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsVertexSkinning  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsSkinningMask  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCSMShadowCascade0  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCSMShadowCascade1  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCSMShadowCascade2  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCSMShadowCascade3  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCSMShadows  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsStaticShadowCaster  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsRealtimeShadowCaster  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsToRenderFlagMask  // 0x0
  public    static  UnityEngine.HyperGryph.HGObjectFlagsCanBeRenderedMask  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGFactoryDirtyFlags
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.HGFactoryDirtyFlagsNone  // 0x0
  public    static  UnityEngine.HyperGryph.HGFactoryDirtyFlagsPerDrawData  // 0x0
  public    static  UnityEngine.HyperGryph.HGFactoryDirtyFlagsObjectData  // 0x0
  public    static  UnityEngine.HyperGryph.HGFactoryDirtyFlagsTransformData  // 0x0
  public    static  UnityEngine.HyperGryph.HGFactoryDirtyFlagsVFXStatus  // 0x0
  public    static  UnityEngine.HyperGryph.HGFactoryDirtyFlagsVFXVisibility  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.IVec2
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            System.Int32                    x  // 0x10
  public            System.Int32                    y  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.IVec4
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            System.Int32                    x  // 0x10
  public            System.Int32                    y  // 0x14
  public            System.Int32                    z  // 0x18
  public            System.Int32                    w  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.SludgeNodeData
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Byte                     allHole  // 0x10
  public            System.Byte                     treeLevel  // 0x11
  public            System.UInt16                   parent  // 0x12
  public            UnityEngine.Vector3             aabbCenter  // 0x14
  public            UnityEngine.Vector3             aabbExtent  // 0x20
  public            UnityEngine.HyperGryph.SludgeNodeData.<patchAABBData>e__FixedBufferpatchAABBData  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.SludgeHeightmapInfo
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            UnityEngine.Vector4             heightmapUVOffsetScale  // 0x10
  public            UnityEngine.Texture2D           heightmapAtlas  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGSludgeRender
TYPE:  class
TOKEN: 0x2000074
FIELDS:
METHODS:
  System.Boolean RegisterSludge(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.Texture2D bakedHeightmap, Unity.Collections.NativeArray<UnityEngine.HyperGryph.SludgeNodeData> nodeData)
  System.Boolean RegisterSludge(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.Texture2D bakedHeightmap, System.Int32 nodeCount, System.IntPtr nodeData)
  System.Void UnregisterAndDestroySludge(UnityEngine.HyperGryph.ECS.Entity entity)
  System.UInt32 CreateRendererList(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, System.UInt32 viewHandle, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, UnityEngine.HyperGryph.HGShaderLightMode decalLightModeMask, System.Single lodFactor, System.IntPtr context, System.Boolean useMetric)
  System.UInt32 CreateRendererList(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, System.UInt32 viewHandle, System.UInt32 lightModeMask, System.UInt32 decalLightModeMask, System.Single loadFactor, System.IntPtr context, System.Boolean useMetric)
  System.Void DrawECSRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList, UnityEngine.MaterialPropertyBlock customPros)
  System.Void DrawECSDecalRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList, UnityEngine.MaterialPropertyBlock customProps)
  System.Void DrawECSBlendRendererList(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 rendererList, UnityEngine.MaterialPropertyBlock customProps)
  System.Void HitSludge(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.Vector3 worldPos, System.Single range, System.Single deltaHeightNormalized)
  UnityEngine.HyperGryph.SludgeHeightmapInfo GetHeightmapInfo(UnityEngine.HyperGryph.ECS.Entity entity)
  System.UInt32 GetDynamicThicknessMapSize()
  System.Boolean ShouldDrawThicknessMap()
  System.Void DrawThicknessMap(System.IntPtr context, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material blitMat, System.Int32 passIdx, System.Int32 viewHandle)
  System.Boolean RegisterSludge_Injected(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.Texture2D bakedHeightmap, System.Int32 nodeCount, System.IntPtr nodeData)
  System.Void UnregisterAndDestroySludge_Injected(UnityEngine.HyperGryph.ECS.Entity& entity)
  System.UInt32 CreateRendererList_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, System.UInt32 viewHandle, System.UInt32 lightModeMask, System.UInt32 decalLightModeMask, System.Single loadFactor, System.IntPtr context, System.Boolean useMetric)
  System.Void HitSludge_Injected(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.Vector3& worldPos, System.Single range, System.Single deltaHeightNormalized)
  System.Void GetHeightmapInfo_Injected(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.SludgeHeightmapInfo& ret)
END_CLASS

CLASS: UnityEngine.HyperGryph.SplineEmissionType
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryph.SplineEmissionTypeBox  // 0x0
  public    static  UnityEngine.HyperGryph.SplineEmissionTypeMesh  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.SplineEmissionMeshType
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryph.SplineEmissionMeshTypeTriangle  // 0x0
  public    static  UnityEngine.HyperGryph.SplineEmissionMeshTypeVertex  // 0x0
  public    static  UnityEngine.HyperGryph.SplineEmissionMeshTypeEdge  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.SplineObjectsDesc
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Boolean                  useLogicDeltaTime  // 0x18
  public            System.Boolean                  prewarm  // 0x19
  public            System.Boolean                  has3dStartRotation  // 0x1A
  public            System.Boolean                  hasNoise  // 0x1B
  public            System.Boolean                  hasAlphaControl  // 0x1C
  public            System.Boolean                  hasRotation  // 0x1D
  public            System.Boolean                  has3dRotation  // 0x1E
  public            System.Single                   simulateSpeed  // 0x20
  public            System.Single                   emissionRateOverTime  // 0x24
  public            System.Single                   transparentAlpha  // 0x28
  public            UnityEngine.Vector3             emissionMeshScale  // 0x2C
  public            UnityEngine.HyperGryph.SplineEmissionTypeemissionType  // 0x38
  public            UnityEngine.HyperGryph.SplineEmissionMeshTypeemissionMeshType  // 0x3C
  public            UnityEngine.Matrix4x4           objectToWorld  // 0x40
  public            UnityEngine.Bounds              aabb  // 0x80
  public            System.UInt64                   sceneMask  // 0x98
  public            UnityEngine.Mesh                emissionMesh  // 0xA0
  public            UnityEngine.LODGroup[]          lodGroups  // 0xA8
  public            UnityEngine.ParticleSystem.MinMaxCurvestartLifeTime  // 0xB0
  public            UnityEngine.ParticleSystem.MinMaxCurvestartSize  // 0xD0
  public            UnityEngine.ParticleSystem.MinMaxCurverotationOverLifeTime  // 0xF0
  public            UnityEngine.ParticleSystem.MinMaxCurverotationXOverLifeTime  // 0x110
  public            UnityEngine.ParticleSystem.MinMaxCurverotationYOverLifeTime  // 0x130
  public            UnityEngine.ParticleSystem.MinMaxCurvestartRotationX  // 0x150
  public            UnityEngine.ParticleSystem.MinMaxCurvestartRotationY  // 0x170
  public            UnityEngine.ParticleSystem.MinMaxCurvestartRotationZ  // 0x190
  public            UnityEngine.ParticleSystem.MinMaxCurvesizeOverLifeTime  // 0x1B0
  public            UnityEngine.ParticleSystem.MinMaxCurvevelocityOverLifeTime  // 0x1D0
  public            UnityEngine.ParticleSystem.MinMaxCurvealphaOverLifeTime  // 0x1F0
  public            UnityEngine.ParticleSystem.MinMaxCurvenoiseAmplitudeLifeTime  // 0x210
  public            UnityEngine.ParticleSystem.MinMaxCurvenoiseFrequencyLifeTime  // 0x230
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.SplineObjectsKnotData
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            UnityEngine.Vector3             p0  // 0x10
  public            UnityEngine.Vector3             p1  // 0x1C
  public            UnityEngine.Vector3             p2  // 0x28
  public            UnityEngine.Vector3             p3  // 0x34
  public            System.Single                   length  // 0x40
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGSplineMovingObjectsManager
TYPE:  class
TOKEN: 0x2000079
FIELDS:
METHODS:
  System.UInt32 CreateInstance(UnityEngine.HyperGryph.SplineObjectsDesc desc, Unity.Collections.NativeArray<UnityEngine.HyperGryph.SplineObjectsKnotData> curveData)
  System.Boolean DestroyInstance(System.UInt32 instanceID)
  System.Boolean UpdateObjectToWorld(System.UInt32 instanceID, UnityEngine.Matrix4x4 objectToWorld)
  System.Boolean Pause(System.UInt32 instanceID)
  System.UInt32 CreateInstance(UnityEngine.HyperGryph.SplineObjectsDesc desc, UnityEngine.HyperGryph.SplineObjectsKnotData* curveData, System.Int32 length)
  System.Boolean UpdateObjectToWorld_Injected(System.UInt32 instanceID, UnityEngine.Matrix4x4& objectToWorld)
  System.UInt32 CreateInstance_Injected(UnityEngine.HyperGryph.SplineObjectsDesc& desc, UnityEngine.HyperGryph.SplineObjectsKnotData* curveData, System.Int32 length)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGSubsurfaceProfileManager
TYPE:  class
TOKEN: 0x200007A
FIELDS:
METHODS:
  System.Void RegisterFromTerrain(UnityEngine.HGSubsurfaceProfile profile)
  System.Void UnregisterFromTerrain()
END_CLASS

CLASS: UnityEngine.HyperGryph.TerrainNodePayload
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            UnityEngine.Texture2D           heightmapPage  // 0x10
  public            UnityEngine.Texture2D           normalmapPage  // 0x18
  public            UnityEngine.Texture2D           tintColorPage  // 0x20
  public            UnityEngine.Texture2D           splatCtrlPage  // 0x28
  public            UnityEngine.Texture2D           albedoPage  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.TerrainSplatPayload
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            UnityEngine.Texture2D           diffuseTex  // 0x10
  public            UnityEngine.Texture2D           normalROTex  // 0x18
  public            UnityEngine.Texture2D           coneMapTex  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.TerrainInfo
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            UnityEngine.Vector3             terrainPosition  // 0x10
  public            System.Single                   heightScale  // 0x1C
  public            System.UInt32                   terrainSize  // 0x20
  public            System.UInt16                   heightmapPageSize  // 0x24
  public            System.UInt16                   normalmapPageSize  // 0x26
  public            System.UInt16                   tintColorPageSize  // 0x28
  public            System.UInt16                   splatCtrlPageSize  // 0x2A
  public            System.UInt16                   albedoTexPageSize  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.TerrainNodeData
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  public            System.Byte                     allHole  // 0x10
  public            System.Byte                     nodeLevel  // 0x11
  public            System.UInt16                   parent  // 0x12
  public            System.Single                   localMinHeight  // 0x14
  public            System.Single                   localMaxHeight  // 0x18
  public            System.Single                   maxHeightError  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.SplatLayerData
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            UnityEngine.Vector4             packedSplatInfo  // 0x10
  public            UnityEngine.Vector4             splatST  // 0x20
  public            UnityEngine.Vector4             diffuseRemapScale  // 0x30
  public            UnityEngine.Vector4             maskMapRemapOffset  // 0x40
  public            UnityEngine.Vector4             maskMapRemapScale  // 0x50
  public            UnityEngine.Vector4             packedDeformParams  // 0x60
  public            UnityEngine.Vector4             pomParams  // 0x70
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGTerrainManager
TYPE:  class
TOKEN: 0x2000080
FIELDS:
METHODS:
  System.Void ReadbackVTFeedbackBuffer(System.Int32 feedbackViewId, UnityEngine.Rendering.CommandBuffer cmd, System.IntPtr renderContext)
  System.Void* GetTerrainNodesForCanceling(System.Int32& length)
  System.Void* GetTerrainNodesForStreaming(System.Int32& length)
  System.UInt64 GetTerrainSplatsForCanceling()
  System.UInt64 GetTerrainSplatsForStreaming()
  System.Void ResetTerrainNodesForCanceling()
  System.Void ResetTerrainNodesForStreaming()
  System.Void ResetTerrainSplatsForCanceling()
  System.Void ResetTerrainSplatsForStreaming()
  System.Boolean StreamingInTerrainNodePayload(System.UInt32 nodeKey, UnityEngine.HyperGryph.TerrainNodePayload& payload)
  System.Void StreamingInTerrainSplat(System.UInt32 splatIdx, UnityEngine.HyperGryph.TerrainSplatPayload payload)
  System.Void ResetLoadingStatusForAllNodes()
  System.Void ResetLoadingStatusForAllSplats()
  System.Void SetupTerrainManager(UnityEngine.HyperGryph.TerrainInfo& terrainInfo, UnityEngine.ComputeShader terrainCS, UnityEngine.ComputeShader terrainRTCS, UnityEngine.Shader terrainPS, UnityEngine.Texture2D splatIndexMap, Unity.Collections.NativeArray<UnityEngine.HyperGryph.SplatLayerData> layerData, UnityEngine.Texture2D[] splatDiffuseTextures, UnityEngine.Texture2D[] splatNormalTextures, UnityEngine.Texture2D[] splatConeMapTextures, System.Int32 splatTier, Unity.Collections.NativeArray<UnityEngine.HyperGryph.TerrainNodeData> nodeData, Unity.Collections.NativeArray<System.UInt64> sectorSplatInfo, System.Boolean enableHalfVTSize, System.Boolean enableHalfAtlasSize, UnityEngine.Experimental.Rendering.GraphicsFormat mobileSplatCtrlAtlasFormat, System.Boolean enableIndirectionCpuUpload)
  System.Void SetupTerrainManager(UnityEngine.HyperGryph.TerrainInfo& terrainInfo, UnityEngine.ComputeShader terrainCS, UnityEngine.ComputeShader terrainRTCS, UnityEngine.Shader terrainPS, UnityEngine.Texture2D splatIndexMap, System.Int32 layerCount, System.IntPtr layerData, UnityEngine.Texture2D[] splatDiffuseTextures, UnityEngine.Texture2D[] splatNormalTextures, UnityEngine.Texture2D[] splatConeMapTextures, System.Int32 splatTier, System.Int32 nodeCount, System.IntPtr nodeData, System.Int32 sectorCount, System.IntPtr sectorSplatInfo, System.Boolean enableHalfVTSize, System.Boolean enableHalfAtlasSize, UnityEngine.Experimental.Rendering.GraphicsFormat mobileSplatCtrlAtlasFormat, System.Boolean enableIndirectionCpuUpload)
  System.Void CleanupTerrainManager()
  System.UInt32 CullTerrainAndUpdateVTFeedbackView(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, UnityEngine.Matrix4x4 viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext, System.UInt32 viewHandle, System.Int32 feedbackViewId, UnityEngine.Vector3 vtUpdateCenter)
  System.UInt32 CullTerrain(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, UnityEngine.Matrix4x4 viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext)
  System.Void PrepareDecalRendererListsForVTPages(System.Int32 feedbackViewId, System.IntPtr renderContext)
  System.Void ExecuteVTUpdateCommand(System.Int32 feedbackViewId, System.IntPtr renderContext)
  System.Void RenderVTPages(System.Int32 feedbackViewId, System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer copyCmd, UnityEngine.Rendering.CommandBuffer renderCmd, System.Int32 bakePassIndex, System.Int32 bc3PassIndex, System.Int32 astcPassIndex, System.Int32 bc5PassIndex)
  System.Void RenderScreenSpaceTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId, System.Int32 passIndex, System.IntPtr features)
  System.Void RenderTerrainAfterGBuffer(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId, System.IntPtr features)
  System.Void UpdateSubdivisionParameters(System.Int32 mode, System.Int32 modeV2, System.Int32 subd, System.Int32 primitivePixelLengthTargetLog2)
  System.Void SetTerrainBlendBindings(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId)
  System.Void SetDecalDeformBindings(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId)
  UnityEngine.Texture2D GetHeightmapAtlas()
  UnityEngine.Texture2D GetNormalmapAtlas()
  UnityEngine.Texture2D GetTintColorAtlas()
  UnityEngine.Texture2D GetSplatControlAtlas()
  UnityEngine.Texture2D GetAlbedoAtlas()
  UnityEngine.Texture2D GetSplatIndexMap()
  UnityEngine.Texture2DArray GetSplatDiffuseArray()
  UnityEngine.Texture2DArray GetSplatNormalROArray()
  UnityEngine.Rendering.CBHandle GetSplatDataUBO()
  System.Void SubdivisionTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 subdivisionHandle, System.Boolean enableSubdivision, System.Boolean enableSubdivisionV2, UnityEngine.Texture HZBTexture)
  System.Void RenderTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 subdivisionHandle, System.Int32 passIndex, System.Int32 tessellationPassIndex, System.Int32 subdivisionPassIndex, System.Boolean enableSubdivisionV2)
  System.Void StreamingInChunkSurfaceTypeData(System.UInt32 chunkKey, System.UIntPtr chunkSurfaceTypeData, System.Int32 dataLength, System.Int32 chunkSize)
  System.Void StreamingOutChunkSurfaceTypeData(System.UInt32 chunkKey)
  System.Boolean GetSurfaceTypeByWorldPosition(System.Single x, System.Single y, System.Int32& surfaceType)
  System.Void set_minVerticalFieldOfView(System.Single value)
  System.Void StreamingInTerrainSplat_Injected(System.UInt32 splatIdx, UnityEngine.HyperGryph.TerrainSplatPayload& payload)
  System.UInt32 CullTerrainAndUpdateVTFeedbackView_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, UnityEngine.Matrix4x4& viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext, System.UInt32 viewHandle, System.Int32 feedbackViewId, UnityEngine.Vector3& vtUpdateCenter)
  System.UInt32 CullTerrain_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, UnityEngine.Matrix4x4& viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext)
  System.Void GetSplatDataUBO_Injected(UnityEngine.Rendering.CBHandle& ret)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGEditorTerrainManager
TYPE:  class
TOKEN: 0x2000081
FIELDS:
METHODS:
  System.Void SetUseNewEditorTerrainRendering(System.Boolean value)
  System.UInt32 CullTerrainAndUpdateVTFeedbackView(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, UnityEngine.Matrix4x4 viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext, System.UInt32 viewHandle, System.Int32 feedbackViewId, UnityEngine.Vector3 vtUpdateCenter)
  System.UInt32 CullTerrain(UnityEngine.Camera camera, UnityEngine.Vector2Int sceneRTSize, UnityEngine.Matrix4x4 viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext)
  System.Void SetTerrainBlendBindings(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId)
  System.Void RenderTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 subdivisionHandle, System.Int32 passIndex, System.Int32 subdivisionPassIndex, System.Boolean enableSubdivisionV2)
  System.Void RenderScreenSpaceTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId, System.Int32 passIndex, System.IntPtr features)
  System.Void RenderSeparateTerrain(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 passIndex, System.IntPtr features)
  System.Void RenderTerrainAfterGBuffer(UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 terrainCullViewHandle, System.Int32 feedbackViewId, System.IntPtr features)
  System.Void BakeAtlasTexture(UnityEngine.Rendering.CommandBuffer cmd, System.IntPtr renderContext)
  System.Void PrepareDecalRendererListsForVTPages(System.Int32 feedbackViewId, System.IntPtr renderContext)
  System.Void ExecuteVTUpdateCommand(System.Int32 feedbackViewId, System.IntPtr renderContext)
  System.Void RenderVTPages(System.Int32 feedbackViewId, System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer copyCmd, UnityEngine.Rendering.CommandBuffer renderCmd, System.Int32 bakePass, System.Int32 bc3Pass, System.Int32 astcPass)
  System.Void ReadbackVTFeedbackBuffer(System.Int32 feedbackViewId, UnityEngine.Rendering.CommandBuffer cmd, System.IntPtr renderContext)
  System.UInt32 CullTerrainAndUpdateVTFeedbackView_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, UnityEngine.Matrix4x4& viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext, System.UInt32 viewHandle, System.Int32 feedbackViewId, UnityEngine.Vector3& vtUpdateCenter)
  System.UInt32 CullTerrain_Injected(UnityEngine.Camera camera, UnityEngine.Vector2Int& sceneRTSize, UnityEngine.Matrix4x4& viewProj, System.Single lodFactor, System.Boolean useMetric, System.IntPtr renderContext)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGTerrainDeformConfigV2
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.Single                   m_deformGlobalStrength  // 0x10
  public            System.Single                   m_latency  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGTerrainDeformManagerV2
TYPE:  class
TOKEN: 0x2000083
FIELDS:
METHODS:
  System.Void SetPlayerCenter(UnityEngine.Vector3 position)
  System.Void UpdateDeformConfig(UnityEngine.HyperGryph.HGTerrainDeformConfigV2 config)
  System.Void SetPlayerCenter_Injected(UnityEngine.Vector3& position)
  System.Void UpdateDeformConfig_Injected(UnityEngine.HyperGryph.HGTerrainDeformConfigV2& config)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGUIRender
TYPE:  class
TOKEN: 0x2000084
FIELDS:
METHODS:
  System.UInt32 CreateRendererList(System.UInt32 cullingLayerMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsMask, UnityEngine.HyperGryph.HGRenderFlags renderFlagsValue, UnityEngine.HyperGryph.HGShaderLightMode lightModeMask, System.Int16 sortingOrderMin, System.Int16 sortingOrderMax, System.Int32 cameraInstanceID, System.IntPtr context, System.Boolean isWorldUI, System.Single wolrdUICullingDistance)
  System.UInt32 CreateRendererList(System.UInt32 cullingLayerMask, System.UInt32 renderFlagsMask, System.UInt32 renderFlagsValue, System.UInt32 lightModeMask, System.Int16 sortingOrderMin, System.Int16 sortingOrderMax, System.Int32 cameraInstanceID, System.IntPtr context, System.Boolean isWorldUI, System.Single wolrdUICullingDistance)
END_CLASS

CLASS: UnityEngine.HyperGryph.HGWaterRender
TYPE:  class
TOKEN: 0x2000085
FIELDS:
METHODS:
  System.Void CullWaterProxy(System.UInt32 viewHandle, UnityEngine.Matrix4x4 viewProj, System.UInt32 cullingMask, System.Boolean useOC, System.UInt32& visibleCount, System.UInt32& cullHandle)
  System.Void CullWaterDecals(System.UInt32 viewHandle, UnityEngine.Matrix4x4 viewProj, System.UInt32& visibleCount, System.UInt32& cullHandle)
  System.Void DrawWaterProxy(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 cullHandle, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPass, System.Int32 nameID, System.Boolean clear, System.UInt32 renderTypeMask)
  System.Void DrawWaterDecals(System.IntPtr renderContext, UnityEngine.Rendering.CommandBuffer cmd, System.UInt32 cullHandle, UnityEngine.MaterialPropertyBlock properties, System.Int32 nameID, System.Boolean clear, System.Int32 shaderPass, System.UInt32 renderTypeMask)
  System.Boolean IsHGWaterGloablConfigValidCPP()
  System.Boolean CheckNewHGWaterGloablConfigCPP(System.String scenePath)
  System.Void UpdateHGWaterGloablConfigCPP(System.String scenePath, System.Int32 sectorNum, System.Int32 sectorSize, System.Int32 sectorCoordsMin, System.Int32 sectorCoordsMax, System.Int64[] sectorDataGUIDs, System.Boolean[] sectorDataExists)
  System.Void AddSectorTexture(System.Int32 id, System.Int32 textureID)
  System.Void RemoveSectorTexture(System.Int32 id)
  System.Void CullWaterProxy_Injected(System.UInt32 viewHandle, UnityEngine.Matrix4x4& viewProj, System.UInt32 cullingMask, System.Boolean useOC, System.UInt32& visibleCount, System.UInt32& cullHandle)
  System.Void CullWaterDecals_Injected(System.UInt32 viewHandle, UnityEngine.Matrix4x4& viewProj, System.UInt32& visibleCount, System.UInt32& cullHandle)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.ECSExplicitEntityType
TYPE:  struct
TOKEN: 0x20000A8
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.HyperGryph.ECS.ECSExplicitEntityTypeUnknown  // 0x0
  public    static  UnityEngine.HyperGryph.ECS.ECSExplicitEntityTypeMeshRenderer  // 0x0
  public    static  UnityEngine.HyperGryph.ECS.ECSExplicitEntityTypeReflectionProbe  // 0x0
  public    static  UnityEngine.HyperGryph.ECS.ECSExplicitEntityTypeWaterRenderer  // 0x0
  public    static  UnityEngine.HyperGryph.ECS.ECSExplicitEntityTypeFactoryRenderer  // 0x0
  public    static  UnityEngine.HyperGryph.ECS.ECSExplicitEntityTypeHGDecalProjector  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityInstanceData
TYPE:  struct
TOKEN: 0x20000A9
FIELDS:
  public            System.UInt32                   entityType  // 0x10
  public            System.Int32                    entityIdx  // 0x14
  public            System.UInt32                   version  // 0x18
  public            System.UInt32                   padding  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.ComponentType
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  public            System.UInt64                   value  // 0x10
  public            System.Int16                    componentID  // 0x10
  public            System.Int16                    componentSize  // 0x12
  public            System.Int32                    offset  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.ComponentMask
TYPE:  struct
TOKEN: 0x20000AB
FIELDS:
  public            UnityEngine.HyperGryph.ECS.ComponentMask.<componentMaskWords>e__FixedBuffercomponentMaskWords  // 0x10
METHODS:
  System.Boolean ContainsComponentId(System.Int32 id)
  System.Boolean ContainsComponentMask(UnityEngine.HyperGryph.ECS.ComponentMask& other)
  System.Boolean ExcludesComponentMask(UnityEngine.HyperGryph.ECS.ComponentMask& other)
  System.Void .ctor(System.Int32 id)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void And(UnityEngine.HyperGryph.ECS.ComponentMask& other)
  System.Void Or(System.Int32 id)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityTypeInstanceData
TYPE:  struct
TOKEN: 0x20000AD
FIELDS:
  public            System.UInt64                   groupComponentMask  // 0x10
  public            System.Byte*                    groupMemory  // 0x18
  public            System.UInt64                   componentMask  // 0x20
  public            UnityEngine.HyperGryph.ECS.ComponentMaskcomponentMaskAll  // 0x20
  public            System.Byte*                    memory  // 0x30
  public            System.UInt32                   chunkType  // 0x38
  public            System.UInt32                   extraDataMisc  // 0x3C
  public            System.Int32                    count  // 0x40
  public            System.Int32                    capacity  // 0x44
  public            System.Int32                    stride  // 0x48
  public            System.Int32                    componentTypeCount  // 0x4C
  public            UnityEngine.HyperGryph.ECS.EntityTypeInstanceData.<componentTypes>e__FixedBuffercomponentTypes  // 0x50
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.Entity
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.UInt32                   globalIndex  // 0x10
  public            System.UInt32                   version  // 0x14
  private   static readonly UnityEngine.HyperGryph.ECS.Entity<invaildEntity>k__BackingField  // 0x0
METHODS:
  System.UInt64 get_id()
  System.Void set_id(System.UInt64 value)
  System.Boolean Equals(UnityEngine.HyperGryph.ECS.Entity rhs)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean Valid()
  System.Boolean op_Equality(UnityEngine.HyperGryph.ECS.Entity left, UnityEngine.HyperGryph.ECS.Entity right)
  System.Boolean op_Inequality(UnityEngine.HyperGryph.ECS.Entity left, UnityEngine.HyperGryph.ECS.Entity right)
  System.Boolean Equals(System.Object obj)
  UnityEngine.HyperGryph.ECS.Entity get_invaildEntity()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityType
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  public            System.UInt32                   id  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.IComponentECS
TYPE:  interface
TOKEN: 0x20000B1
FIELDS:
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.BoundingCenterXComponent
TYPE:  struct
TOKEN: 0x20000B2
FIELDS:
  public            System.Single                   x  // 0x10
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.BoundingCenterYComponent
TYPE:  struct
TOKEN: 0x20000B3
FIELDS:
  public            System.Single                   y  // 0x10
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.BoundingCenterZComponent
TYPE:  struct
TOKEN: 0x20000B4
FIELDS:
  public            System.Single                   z  // 0x10
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.BoundingExtentXComponent
TYPE:  struct
TOKEN: 0x20000B5
FIELDS:
  public            System.Single                   x  // 0x10
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.BoundingExtentYComponent
TYPE:  struct
TOKEN: 0x20000B6
FIELDS:
  public            System.Single                   y  // 0x10
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.BoundingExtentZComponent
TYPE:  struct
TOKEN: 0x20000B7
FIELDS:
  public            System.Single                   z  // 0x10
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.RenderObjectLODInfoComponent
TYPE:  struct
TOKEN: 0x20000B8
FIELDS:
  public            UnityEngine.Vector3             lodCenter  // 0x10
  public            System.Single                   lodObjectHalfSizeSquared  // 0x1C
  public            System.Boolean                  enableDither  // 0x20
  public            System.Byte                     lodCullingOptions  // 0x21
  public            System.Byte                     padding0  // 0x22
  public            System.Byte                     padding1  // 0x23
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.RenderObjectInfoComponent
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  public            System.UInt32                   roLayerMask  // 0x10
  public            System.UInt32                   objectFlags  // 0x14
  public            System.UInt64                   sceneMask  // 0x18
  public            System.UInt32                   artTag  // 0x20
  public            System.Single                   sortingFudgeSqr  // 0x24
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.RendererInfo
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public            System.UInt16                   hgKeywords  // 0x10
  public            System.Byte                     meshSubIndex  // 0x12
  public            System.SByte                    sortOrder  // 0x13
  public            System.UInt32                   materialHandle  // 0x14
  public            System.UInt32                   geometryHandle  // 0x18
  public            System.UInt32                   shadowProxyGeometryHandle  // 0x1C
  public            System.UInt32                   renderFlags  // 0x20
  public            System.UInt32                   lightModeMask  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.LODInfo
TYPE:  struct
TOKEN: 0x20000BB
FIELDS:
  public            System.Single                   lodScreenSizeMaxSquared  // 0x10
  public            System.Single                   lodScreenSizeMinSquared  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.IRenderObjectKComponent
TYPE:  interface
TOKEN: 0x20000BC
FIELDS:
METHODS:
  System.Byte* GetRenderersPtr()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.RenderObjectK1Component
TYPE:  struct
TOKEN: 0x20000BD
FIELDS:
  public            System.Int32                    count  // 0x10
  public            UnityEngine.HyperGryph.ECS.RenderObjectK1Component.<renderers>e__FixedBufferrenderers  // 0x14
  public            UnityEngine.HyperGryph.ECS.RenderObjectK1Component.<lodInfos>e__FixedBufferlodInfos  // 0x2C
METHODS:
  System.Int32 get_id()
  System.Byte* GetRenderersPtr()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.RenderObjectK2Component
TYPE:  struct
TOKEN: 0x20000C0
FIELDS:
  public            System.Int32                    count  // 0x10
  public            UnityEngine.HyperGryph.ECS.RenderObjectK2Component.<renderers>e__FixedBufferrenderers  // 0x14
  public            UnityEngine.HyperGryph.ECS.RenderObjectK2Component.<lodInfos>e__FixedBufferlodInfos  // 0x44
METHODS:
  System.Int32 get_id()
  System.Byte* GetRenderersPtr()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.RenderObjectK4Component
TYPE:  struct
TOKEN: 0x20000C3
FIELDS:
  public            System.Int32                    count  // 0x10
  public            UnityEngine.HyperGryph.ECS.RenderObjectK4Component.<renderers>e__FixedBufferrenderers  // 0x14
  public            UnityEngine.HyperGryph.ECS.RenderObjectK4Component.<lodInfos>e__FixedBufferlodInfos  // 0x74
METHODS:
  System.Int32 get_id()
  System.Byte* GetRenderersPtr()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.RenderObjectK8Component
TYPE:  struct
TOKEN: 0x20000C6
FIELDS:
  public            System.Int32                    count  // 0x10
  public            UnityEngine.HyperGryph.ECS.RenderObjectK8Component.<renderers>e__FixedBufferrenderers  // 0x14
  public            UnityEngine.HyperGryph.ECS.RenderObjectK8Component.<lodInfos>e__FixedBufferlodInfos  // 0xD4
METHODS:
  System.Int32 get_id()
  System.Byte* GetRenderersPtr()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.RenderObjectK16Component
TYPE:  struct
TOKEN: 0x20000C9
FIELDS:
  public            System.Int32                    count  // 0x10
  public            UnityEngine.HyperGryph.ECS.RenderObjectK16Component.<renderers>e__FixedBufferrenderers  // 0x14
  public            UnityEngine.HyperGryph.ECS.RenderObjectK16Component.<lodInfos>e__FixedBufferlodInfos  // 0x194
METHODS:
  System.Int32 get_id()
  System.Byte* GetRenderersPtr()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.PerDrawBaseData
TYPE:  struct
TOKEN: 0x20000CC
FIELDS:
  public            UnityEngine.Matrix4x4           objectToWorld  // 0x10
  public            UnityEngine.Vector4             lodFade  // 0x50
  public            UnityEngine.Vector4             worldTransformParams  // 0x60
  public            UnityEngine.Matrix4x4           matrixPreviousM  // 0x70
  public            UnityEngine.Vector4             motionVectorsParams  // 0xB0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.CommonInstanceDataComponent
TYPE:  struct
TOKEN: 0x20000CD
FIELDS:
  public            UnityEngine.HyperGryph.ECS.PerDrawBaseDatabaseData  // 0x10
  public            UnityEngine.HyperGryph.ECS.CommonInstanceDataComponent.<customData>e__FixedBuffercustomData  // 0xC0
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.FactoryInstanceDataComponent
TYPE:  struct
TOKEN: 0x20000CF
FIELDS:
  public            UnityEngine.HyperGryph.ECS.PerDrawBaseDatabaseData  // 0x10
  public            UnityEngine.HyperGryph.ECS.FactoryInstanceDataComponent.<customData>e__FixedBuffercustomData  // 0xC0
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.ECSFixedString64
TYPE:  struct
TOKEN: 0x20000D1
FIELDS:
  public            UnityEngine.HyperGryph.ECS.ECSFixedString64.<data>e__FixedBufferdata  // 0x10
METHODS:
  System.String GetData()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.DebugContentsComponent
TYPE:  struct
TOKEN: 0x20000D3
FIELDS:
  public            UnityEngine.HyperGryph.ECS.ECSFixedString64entityName  // 0x10
  public            UnityEngine.HyperGryph.ECS.ECSExplicitEntityTypeentityType  // 0x50
  public            UnityEngine.HyperGryph.ECS.ECSFixedString64debugStr  // 0x54
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent
TYPE:  struct
TOKEN: 0x20000D4
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityrendererEntity  // 0x10
  public            System.UInt32                   sharedDataIndex  // 0x18
  public            System.Byte                     rendererType  // 0x1C
  public            System.Byte                     padding0  // 0x1D
  public            System.Byte                     padding1  // 0x1E
  public            System.Byte                     padding2  // 0x1F
METHODS:
  System.Void SetDirtyFlag(UnityEngine.HyperGryph.HGFactoryDirtyFlags flag)
  System.Void SetAdditiveMaterialBit(System.Int32 bitIndex, System.Boolean enable)
  System.Void SetPosition(UnityEngine.Vector3 position)
  System.Void SetUniformScale(System.Single uniformScale)
  System.Void SetRotation(UnityEngine.Quaternion rotation)
  System.Void SetTransform(UnityEngine.HyperGryph.HGFactoryEntityTransformData transform)
  System.Void SetCustomPerDrawData(T data, System.Int32 offset)
  System.Void SetEnabled(System.Boolean enabled)
  System.Void SetAdditiveEntitiesVisibility(System.Boolean visible)
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.HGWaterComponent
TYPE:  struct
TOKEN: 0x20000D5
FIELDS:
  public            System.UInt32                   renderTypeMask  // 0x10
  public            System.Int32                    meshID  // 0x14
  public            UnityEngine.Matrix4x4           objectToWorld  // 0x18
  public            UnityEngine.Vector4             param0  // 0x58
  public            UnityEngine.Vector4             param1  // 0x68
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.HGWaterDecalComponent
TYPE:  struct
TOKEN: 0x20000D6
FIELDS:
  public            System.UInt32                   renderTypeMask  // 0x10
  public            System.Int32                    meshID  // 0x14
  public            System.Int32                    materialID  // 0x18
  public            UnityEngine.Matrix4x4           objectToWorld  // 0x1C
  public            UnityEngine.Vector4             param0  // 0x5C
  public            UnityEngine.Vector4             param1  // 0x6C
  public            UnityEngine.Vector4             animParam0  // 0x7C
  public            UnityEngine.Vector4             animParam1  // 0x8C
  public            UnityEngine.Vector4             animParam2  // 0x9C
  public            UnityEngine.Vector4             animParam3  // 0xAC
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.GrassRendererInfo
TYPE:  struct
TOKEN: 0x20000D7
FIELDS:
  public            System.UInt16                   hgKeywords  // 0x10
  public            System.UInt16                   batchGroupHandle  // 0x12
  public            System.UInt32                   batchGroupKey  // 0x14
  public            System.Single                   sparsity  // 0x18
  public            System.UInt32                   renderFlags  // 0x1C
  public            System.UInt32                   padding0  // 0x20
  public            System.UInt32                   padding1  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.GrassPerInstanceData
TYPE:  struct
TOKEN: 0x20000D8
FIELDS:
  public    static  System.Int32                    SIZE  // 0x0
  public            UnityEngine.Matrix4x4           objectToWorld  // 0x10
  public            UnityEngine.Vector4             param0  // 0x50
  public            UnityEngine.Vector4             param1  // 0x60
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.GrassClusterK4Component
TYPE:  struct
TOKEN: 0x20000D9
FIELDS:
  public            System.Int32                    count  // 0x10
  public            UnityEngine.HyperGryph.ECS.GrassClusterK4Component.<perInstanceData>e__FixedBufferperInstanceData  // 0x14
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.GrassClusterK8Component
TYPE:  struct
TOKEN: 0x20000DB
FIELDS:
  public            System.Int32                    count  // 0x10
  public            UnityEngine.HyperGryph.ECS.GrassClusterK8Component.<perInstanceData>e__FixedBufferperInstanceData  // 0x14
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.GrassClusterK16Component
TYPE:  struct
TOKEN: 0x20000DD
FIELDS:
  public            System.Int32                    count  // 0x10
  public            UnityEngine.HyperGryph.ECS.GrassClusterK16Component.<perInstanceData>e__FixedBufferperInstanceData  // 0x14
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.GrassClusterK32Component
TYPE:  struct
TOKEN: 0x20000DF
FIELDS:
  public            System.Int32                    count  // 0x10
  public            UnityEngine.HyperGryph.ECS.GrassClusterK32Component.<perInstanceData>e__FixedBufferperInstanceData  // 0x14
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.ECSColliderComponent
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  public            System.IntPtr                   actor  // 0x10
  public            System.Int32                    ecsId  // 0x18
  public            System.UInt32                   ecsVersion  // 0x1C
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.HGSludgeComponent
TYPE:  struct
TOKEN: 0x20000E2
FIELDS:
  public            System.UInt32                   materialHandle  // 0x10
  public            System.UInt32                   sludgeSize  // 0x14
  public            System.Single                   disappearTime  // 0x18
  public            UnityEngine.Vector4             right  // 0x1C
  public            UnityEngine.Vector4             forward  // 0x2C
  public            UnityEngine.Vector4             position  // 0x3C
  public            UnityEngine.Vector4             up  // 0x4C
  public            UnityEngine.Vector4             customPerDraw0  // 0x5C
  public            UnityEngine.Vector4             customPerDraw1  // 0x6C
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.ECSClothDataComponent
TYPE:  struct
TOKEN: 0x20000E3
FIELDS:
  public            System.UInt32                   clothHash  // 0x10
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.HGECSRegionComponent
TYPE:  struct
TOKEN: 0x20000E4
FIELDS:
  public            System.Boolean                  isEnable  // 0x10
  public            UnityEngine.Vector3             center  // 0x14
  public            UnityEngine.Vector3             size  // 0x20
  public            UnityEngine.Quaternion          rotation  // 0x2C
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.HGCullingParameterComponent
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
  public            System.Boolean                  enableShadowCulling  // 0x10
METHODS:
  System.Int32 get_id()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityManager
TYPE:  struct
TOKEN: 0x20000E6
FIELDS:
  public    readonly System.IntPtr                   m_entitiesPPtr  // 0x10
  public    readonly System.IntPtr                   m_entityTypesPPtr  // 0x18
METHODS:
  System.Int32 GetNFromKNComponentMask(System.UInt64 componentMask)
  System.Int32 GetCountFromKNComponent(System.Byte* component)
  System.Void SetCountForKNComponent(System.Byte* component, System.Int32 count)
  UnityEngine.HyperGryph.ECS.GrassRendererInfo* GetGrassRendererInfosFromKNComponent(System.Byte* component)
  UnityEngine.HyperGryph.ECS.LODInfo* GetLODInfosFromKNComponent(System.Byte* component, System.Int32 n)
  System.Int32 GetCountFromKNGrassCluster(System.Byte* component)
  System.Void SetCountForKNGrassCluster(System.Byte* component, System.Int32 count)
  UnityEngine.HyperGryph.ECS.GrassPerInstanceData* GetPerInstanceDataFromKNGrassCluster(System.Byte* component)
  UnityEngine.HyperGryph.ECS.EntityManager GetEntityManager()
  UnityEngine.HyperGryph.ECS.EntityManager GetGameplayEntityManager()
  UnityEngine.HyperGryph.ECS.EntityManager GetRendererEntityManager()
  System.Boolean HasEntity(UnityEngine.HyperGryph.ECS.Entity entity)
  UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityType entityType)
  System.Void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, System.IntPtr entities, System.Int32 count)
  System.Void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> entities)
  System.Void DestroyEntity(UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void DestroyEntities(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> entities)
  System.Void DestroyEntities(System.IntPtr entities, System.Int32 entityCount)
  UnityEngine.HyperGryph.ECS.ComponentType GetComponentType()
  System.Void AddComponent(UnityEngine.HyperGryph.ECS.Entity& entity, T& t)
  System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.Entity& entity)
  System.Void RemoveComponentsWithMask(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.ComponentMask& needRemoveComponentMask)
  UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityType(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> componentTypes)
  UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityTypeImpl(System.Int32 componentTypeCount, System.IntPtr componentTypes)
  System.Void AddMoveEntityAndEntityTypeDataImpl(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.EntityType& newEntityType)
  System.Void RemoveMoveEntityAndEntityTypeDataImpl(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.EntityType& newEntityType)
  System.UInt64 NumberOfSetBits(System.UInt64 i)
  System.UInt64 NumberOfSetBits(UnityEngine.HyperGryph.ECS.ComponentMask& mask)
  UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1)
  UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1, System.Int32 id2)
  UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3)
  UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4)
  UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4, System.Int32 id5)
  System.Boolean HasComponent(UnityEngine.HyperGryph.ECS.Entity& entity)
  System.Void SetComponents(UnityEngine.HyperGryph.ECS.Entity& entity, T0& t0, T1& t1)
  UnityEngine.HyperGryph.ECS.ComponentMask GetCountingMask(System.Int32 id)
  System.Void SetComponentImplWithRef(UnityEngine.HyperGryph.ECS.EntityInstanceData& entityData, UnityEngine.HyperGryph.ECS.EntityTypeInstanceData& entityTypeData, T& t)
  System.Void SetComponent(UnityEngine.HyperGryph.ECS.Entity& entity, T& t)
  System.Byte* GetComponentPtrImpl(System.Int32 entityIdx, UnityEngine.HyperGryph.ECS.EntityTypeInstanceData& entityTypeData, System.Int32 componentId, System.Int32 componentSize)
  System.Boolean TryGetWorldAABBFromRendererEntity(UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.Bounds& aabb)
  System.UInt64 GetComponentMaskLow(UnityEngine.HyperGryph.ECS.Entity& entity)
  UnityEngine.HyperGryph.ECS.ComponentMask GetComponentMaskAll(UnityEngine.HyperGryph.ECS.Entity& entity)
  System.Byte* GetComponentPtrLowBits(UnityEngine.HyperGryph.ECS.Entity& entity, System.UInt64 componentMask)
  T GetComponent(UnityEngine.HyperGryph.ECS.Entity& entity)
  System.Boolean TryGetComponent(UnityEngine.HyperGryph.ECS.Entity& entity, T& component)
  T& GetComponentRef(UnityEngine.HyperGryph.ECS.Entity& entity)
  T* GetComponentPtr(UnityEngine.HyperGryph.ECS.Entity& entity)
  System.Boolean TryGetComponentPtr(UnityEngine.HyperGryph.ECS.Entity& entity, T*& componentPtr)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.ComponentMask& includeComponentMask, UnityEngine.HyperGryph.ECS.ComponentMask& excludeComponentMask)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.ComponentMask& componentMask)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate()
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate()
  System.Int32 GetEntityTypeCount()
  System.UInt32 GetEntityContainerSize()
  System.Void GarbageCollect()
  System.Void GetEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager& ret)
  System.Void GetGameplayEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager& ret)
  System.Void GetRendererEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager& ret)
  System.Void CreateEntity_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.EntityType& entityType, UnityEngine.HyperGryph.ECS.Entity& ret)
  System.Void CreateEntities_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.EntityType& entityType, System.IntPtr entities, System.Int32 count)
  System.Void DestroyEntity_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.Entity& entity)
  System.Void DestroyEntities_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, System.IntPtr entities, System.Int32 entityCount)
  System.Void GetOrRegisterEntityTypeImpl_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, System.Int32 componentTypeCount, System.IntPtr componentTypes, UnityEngine.HyperGryph.ECS.EntityType& ret)
  System.Void AddMoveEntityAndEntityTypeDataImpl_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.EntityType& newEntityType)
  System.Void RemoveMoveEntityAndEntityTypeDataImpl_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self, UnityEngine.HyperGryph.ECS.Entity& entity, UnityEngine.HyperGryph.ECS.EntityType& newEntityType)
  System.Int32 GetEntityTypeCount_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self)
  System.UInt32 GetEntityContainerSize_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self)
  System.Void GarbageCollect_Injected(UnityEngine.HyperGryph.ECS.EntityManager& _unity_self)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.GroupType
TYPE:  struct
TOKEN: 0x20000E7
FIELDS:
  private   readonly UnityEngine.HyperGryph.ECS.EntityTypeInstanceData*m_entityTypes  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* types)
  System.Int32 Size()
  System.Boolean HasComponent()
  T* GetComponent()
  System.Byte* GetComponentPtr(System.Int32 componentId)
  Unity.Collections.NativeArray<T> GetComponentAsArray()
  UnityEngine.HyperGryph.ECS.Entity* GetEntities()
  UnityEngine.HyperGryph.ECS.ComponentMask GetComponentMaskAll()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> GetEntitiesAsArray()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityManagerRange
TYPE:  struct
TOKEN: 0x20000E8
FIELDS:
  private   readonly UnityEngine.HyperGryph.ECS.EntityTypeInstanceData*m_entityTypes  // 0x10
  private   readonly UnityEngine.HyperGryph.ECS.ComponentMaskm_componentMask  // 0x18
  private   readonly UnityEngine.HyperGryph.ECS.ComponentMaskm_excludeComponentMask  // 0x28
  private   readonly System.Int32                    m_count  // 0x38
METHODS:
  System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* entityTypes, System.Int32 count, UnityEngine.HyperGryph.ECS.ComponentMask& componentMask)
  System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityTypeInstanceData* entityTypes, System.Int32 count, UnityEngine.HyperGryph.ECS.ComponentMask& includeComponentMask, UnityEngine.HyperGryph.ECS.ComponentMask& excludeComponentMask)
  UnityEngine.HyperGryph.ECS.EntityManagerRange.Enumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<UnityEngine.HyperGryph.ECS.GroupType> System.Collections.Generic.IEnumerable<UnityEngine.HyperGryph.ECS.GroupType>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingAssetData
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.Int64                    assetHashV2  // 0x10
  public            UnityEngine.HyperGryph.AssetTypeassetType  // 0x18
METHODS:
  System.Boolean Equals(UnityEngine.HyperGryph.Streaming.StreamingAssetData other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.PropertySerializeId
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.UInt32                   componentIndex  // 0x10
  public            System.UInt32                   propertyId  // 0x14
  public            System.UInt32                   subPropertyIndex  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType, System.UInt32 propertyId, System.UInt32 subPropertyIndex)
  System.Void .ctor(System.UInt32 componentIndex, System.UInt32 propertyId, System.UInt32 subPropertyIndex)
  System.Void .ctor(System.UInt32 propertyId, System.UInt32 subPropertyIndex)
  UnityEngine.HyperGryph.Streaming.PropertySerializeId op_Implicit(System.UInt32 propertyId)
  System.UInt32 GetComponentIndexFromType(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType)
  System.Int32 GetHashCode()
  System.UInt32 EncodeSerializeIdentifier()
  UnityEngine.HyperGryph.Streaming.PropertySerializeId op_Addition(UnityEngine.HyperGryph.Streaming.PropertySerializeId a, System.UInt32 subIndex)
  UnityEngine.HyperGryph.Streaming.PropertySerializeId op_Addition(UnityEngine.HyperGryph.Streaming.PropertySerializeId a, System.Int32 subIndex)
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public    readonly System.IntPtr                   ptr  // 0x10
METHODS:
  System.Boolean TryEnqueueAssetForAsyncLoad(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId)
  System.Void AddExternalAssetForAsyncLoad(System.Int64 assetHash, UnityEngine.HyperGryph.AssetType assetType, System.UInt32 assetHandle)
  UnityEngine.Object ConvertAssetFromImpl(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId)
  System.IntPtr ConvertPropertyPtrFromImpl(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId)
  System.Void ConvertPropertyDataFromBytesImpl(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId, System.IntPtr& data, System.Int32& size)
  System.String ConvertStringFrom(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId)
  System.Boolean TryConvertAssetFrom(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId, T& asset)
  T ConvertPropertyFrom(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId)
  T ConvertPropertyFromBytes(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId)
  Unity.Collections.NativeArray<System.Byte> ConvertPropertyFromBytes(UnityEngine.HyperGryph.Streaming.PropertySerializeId propertySerializeId)
  System.Boolean TryEnqueueAssetForAsyncLoad_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId)
  System.Void AddExternalAssetForAsyncLoad_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, System.Int64 assetHash, UnityEngine.HyperGryph.AssetType assetType, System.UInt32 assetHandle)
  UnityEngine.Object ConvertAssetFromImpl_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId)
  System.IntPtr ConvertPropertyPtrFromImpl_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId)
  System.Void ConvertPropertyDataFromBytesImpl_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId, System.IntPtr& data, System.Int32& size)
  System.String ConvertStringFrom_Injected(UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2& _unity_self, UnityEngine.HyperGryph.Streaming.PropertySerializeId& propertySerializeId)
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingGameplayManager
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public    readonly System.IntPtr                   ptr  // 0x10
METHODS:
  System.Void Create(UnityEngine.HyperGryph.Streaming.StreamingSceneParameter parameter)
  System.Void Destroy()
  System.UInt32 AllocateRuntimeChunk(System.String initBasePath, System.String streamingBasePath)
  System.UInt32 CreateEntityGroupAndLoad(System.UInt32 chunkId, System.Int32 blobIndex)
  System.Void LoadGroup(System.UInt32 groupHandle)
  System.Boolean IsGroupReady(System.UInt32 groupId)
  System.UInt32 CreateGroupAndLoadWaitBeforeShow(System.UInt32 chunkId, System.Int32 blobIndex)
  System.Void StopGroupWait(System.UInt32 groupId)
  System.Void UnloadGroup(System.UInt32 groupId, System.Boolean imm)
  System.Void DestroyGroup(System.UInt32 groupId)
  System.Boolean IsGroupLoaded(System.UInt32 groupId)
  System.Boolean IsGroupUnloaded(System.UInt32 groupId)
  System.Void Tick(System.Int32 budget)
  System.Void TickResource()
  System.Void Clear()
  System.Boolean IsIdle()
  System.Boolean IsValid()
  System.Void SetNeedLodTransition(System.Boolean needTransition)
  System.Boolean GetNeedLodTransition()
  System.Void Create_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSceneParameter& parameter)
  System.Void Destroy_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self)
  System.UInt32 AllocateRuntimeChunk_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.String initBasePath, System.String streamingBasePath)
  System.UInt32 CreateEntityGroupAndLoad_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 chunkId, System.Int32 blobIndex)
  System.Void LoadGroup_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupHandle)
  System.Boolean IsGroupReady_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId)
  System.UInt32 CreateGroupAndLoadWaitBeforeShow_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 chunkId, System.Int32 blobIndex)
  System.Void StopGroupWait_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId)
  System.Void UnloadGroup_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId, System.Boolean imm)
  System.Void DestroyGroup_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId)
  System.Boolean IsGroupLoaded_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId)
  System.Boolean IsGroupUnloaded_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.UInt32 groupId)
  System.Void Tick_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.Int32 budget)
  System.Void TickResource_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self)
  System.Void Clear_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self)
  System.Boolean IsIdle_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self)
  System.Void SetNeedLodTransition_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self, System.Boolean needTransition)
  System.Boolean GetNeedLodTransition_Injected(UnityEngine.HyperGryph.Streaming.StreamingGameplayManager& _unity_self)
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingComponentType
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.UInt64                   value__  // 0x10
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeNone  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeTransform  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeMeshFilter  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeMeshRenderer  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeLODGroup  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeBoxCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeMeshCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeSphereCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeCapsuleCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeTerrainCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeMultiCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGDecalProjector  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHLODGroup  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGVolumetricLocalFog  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGWaterRenderer  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGEnvironmentVolume  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeVolume  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeReflectionProbe  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeLight  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGIrradianceVolume  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGTerrain  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGGrass  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeAudioVolume  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeAudioSceneEmitter  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeAudioRoom  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeAudioPortal  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGAdditionalLightData  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGTerrainSurfTypeData  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGSOCChunk  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeGpuClothGroup  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeLensFlareComponentSRP  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGTerrainDecal  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeMergedRenderColliderECS  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGWaterGlobalConfig  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGWindMotor  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGECSRegion  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeFakeFogSimple  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeVLB  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeHGWaterDecal  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingComponentTypeCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingLayer
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerDefault  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerPersistent  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerHLOD0  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerHLOD1  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerHLOD2  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerTiny  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerWater  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerLighting  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerAudio  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingLayerCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.EntityTransition
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionInitializing  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionUnloadedToLoading  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionLoadingWaiting  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionLoadingToLoaded  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionUnloadingToLoaded  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionLoadedToUnloading  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionUnloadingToUnloaded  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionUnloadingWaiting  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionLoadingToUnloaded  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionDestroying  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.EntityTransitionCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingMode
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.Streaming.StreamingModeStream  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingModePause  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingModeLoad  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingModeUnload  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingStatus
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.Streaming.StreamingStatusIdle  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingStatusLoading  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingStatusUnloading  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.StreamingStatusEmpty  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingSceneParameter
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  public            System.String                   mapName  // 0x10
  public            UnityEngine.GameObject          streamingRootObject  // 0x18
  public            System.String                   streamingDataPathRoot  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.GridStatus
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.Streaming.GridStatusLoading  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.GridStatusLoaded  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.GridStatusUnloading  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.GridStatusUnloaded  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.GridStatusNotExist  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.GridIdentifier
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            UnityEngine.Vector2Int          pos  // 0x10
  public            System.Int32                    sceneStateId  // 0x18
  public            System.Int32                    areaId  // 0x1C
  public            UnityEngine.HyperGryph.Streaming.StreamingLayerlayer  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, System.Int32 sceneStateId, System.Int32 areaId, UnityEngine.Vector2Int pos)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingSourceData
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  public            UnityEngine.Vector2             streamingPos  // 0x10
  public            System.Single                   chunkLoadRadius  // 0x18
  public            UnityEngine.HyperGryph.Streaming.StreamingSourceData.<layerLoadRadius>e__FixedBufferlayerLoadRadius  // 0x1C
  public            UnityEngine.HyperGryph.Streaming.StreamingSourceData.<layerEnabledInDefaultArea>e__FixedBufferlayerEnabledInDefaultArea  // 0x44
  public    static readonly UnityEngine.HyperGryph.Streaming.StreamingSourceDatakInvalid  // 0x0
METHODS:
  System.Single GetGridLoadRadius(System.Int32 layerIndex)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.ECSEntityType
TYPE:  struct
TOKEN: 0x2000097
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeRender  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeWater  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeConvexCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeCapsuleCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeSphereCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeMeshCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeMultiCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeTerrainCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeTerrainDecal  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeMergedRenderCollider  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeHGDecalProjector  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeTerrainSplineDecal  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeHGECSRegion  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeWaterDecal  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ECSEntityTypeTypeCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.ProxyEntityType
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeIrradianceVolume  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeAudioVolume  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeAudioEmitter  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeAudioRoom  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeTerrainSurfaceTypeData  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeAudioPortal  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeSOCChunk  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeGrassGrid  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeGpuClothGroup  // 0x0
  public    static  UnityEngine.HyperGryph.Streaming.ProxyEntityTypeTypeCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingSceneV2
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public    readonly System.IntPtr                   ptr  // 0x10
METHODS:
  System.Void Create(UnityEngine.HyperGryph.Streaming.StreamingSceneParameter parameter)
  System.Void Destroy()
  System.Void UnloadImmediately()
  UnityEngine.HyperGryph.Streaming.StreamingStatus QueryStreamingStatus()
  System.Void SetArea(System.Int32 areaId, System.Boolean enabled)
  System.Void SetSceneState(System.Int32 sceneStateId, System.Boolean enabled)
  UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatusImpl(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, System.Int32 sceneStateId, System.Int32 areaId, UnityEngine.Vector2 queryPos)
  UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatusByGridIdentifierImpl(UnityEngine.HyperGryph.Streaming.GridIdentifier gridIdentifier)
  System.Void set_streamingMode(UnityEngine.HyperGryph.Streaming.StreamingMode value)
  UnityEngine.HyperGryph.Streaming.StreamingSourceData get_primaryStreamingSourceData()
  System.Void set_primaryStreamingSourceData(UnityEngine.HyperGryph.Streaming.StreamingSourceData value)
  System.Void set_secondaryStreamingSourceData(UnityEngine.HyperGryph.Streaming.StreamingSourceData value)
  System.Single get_streamingProgress()
  System.Boolean IsValid()
  UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatus(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, UnityEngine.Vector2 queryPos)
  UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatus(UnityEngine.HyperGryph.Streaming.GridIdentifier gridIdentifier)
  System.Void Create_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSceneParameter& parameter)
  System.Void Destroy_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self)
  System.Void UnloadImmediately_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self)
  UnityEngine.HyperGryph.Streaming.StreamingStatus QueryStreamingStatus_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self)
  System.Void SetArea_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, System.Int32 areaId, System.Boolean enabled)
  System.Void SetSceneState_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, System.Int32 sceneStateId, System.Boolean enabled)
  UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatusImpl_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingLayer layer, System.Int32 sceneStateId, System.Int32 areaId, UnityEngine.Vector2& queryPos)
  UnityEngine.HyperGryph.Streaming.GridStatus QueryGridLoadStatusByGridIdentifierImpl_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.GridIdentifier& gridIdentifier)
  System.Void set_streamingMode_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingMode value)
  System.Void get_primaryStreamingSourceData_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSourceData& ret)
  System.Void set_primaryStreamingSourceData_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSourceData& value)
  System.Void set_secondaryStreamingSourceData_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self, UnityEngine.HyperGryph.Streaming.StreamingSourceData& value)
  System.Single get_streamingProgress_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self)
  System.Boolean IsValid_Injected(UnityEngine.HyperGryph.Streaming.StreamingSceneV2& _unity_self)
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.ECSEntityHasRequiredComponentsDelegate
TYPE:  class
TOKEN: 0x200009A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.ECSEntityConvertToDelegate
TYPE:  class
TOKEN: 0x200009B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.ProxyEntityHasRequiredComponentsDelegate
TYPE:  class
TOKEN: 0x200009C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.ProxyEntityConvertToDelegate
TYPE:  class
TOKEN: 0x200009D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.MonoIsConvertorOfComponentDelegate
TYPE:  class
TOKEN: 0x200009E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.MonoComponentConvertToDelegate
TYPE:  class
TOKEN: 0x200009F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.ECSEntityConvertFromDelegate
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2 cContext, UnityEngine.HyperGryph.Streaming.EntityTransition transition)
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.ProxyEntityConvertFromDelegate
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.IntPtr& proxyPtr, UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2 cContext, UnityEngine.HyperGryph.Streaming.EntityTransition transition)
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.MonoComponentConvertFromDelegate
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.Component component, UnityEngine.HyperGryph.Streaming.FlatBufferConvertContextV2 cContext, UnityEngine.HyperGryph.Streaming.EntityTransition transition)
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.MonoComponentAddComponentToDelegate
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.Component Invoke(UnityEngine.GameObject gameObject)
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.MonoComponentGetComponentFromDelegate
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.Component Invoke(UnityEngine.GameObject gameObject, System.Int32 multiComponentIndex)
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.HGStreamingSceneManager
TYPE:  class
TOKEN: 0x20000A5
FIELDS:
METHODS:
  System.Int32 get_streamingVersion()
  System.Int32 get_streamingChunkSize()
  System.Void ResetLastProcessStreamingPos()
  System.Void BindECSEntityConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.ECSEntityType entityType, UnityEngine.HyperGryph.Streaming.ECSEntityHasRequiredComponentsDelegate hasRequiredComponentsDelegate, UnityEngine.HyperGryph.Streaming.ECSEntityConvertToDelegate convertToDelegate, UnityEngine.HyperGryph.Streaming.ECSEntityConvertFromDelegate convertFromFunc)
  System.Void ResetECSEntityConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.ECSEntityType entityType)
  System.Boolean IsECSEntityConvertFuncValid(UnityEngine.HyperGryph.Streaming.ECSEntityType entityType)
  System.Void BindProxyEntityConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType, UnityEngine.HyperGryph.Streaming.ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, UnityEngine.HyperGryph.Streaming.ProxyEntityConvertToDelegate convertToFunc, UnityEngine.HyperGryph.Streaming.ProxyEntityConvertFromDelegate convertFromFunc)
  System.Void ResetProxyEntityConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType)
  System.Boolean IsProxyEntityConvertFuncValid(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType)
  System.Void BindMonoComponentConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType, UnityEngine.HyperGryph.Streaming.MonoIsConvertorOfComponentDelegate isConvertorOfFunc, UnityEngine.HyperGryph.Streaming.MonoComponentConvertToDelegate convertToFunc, UnityEngine.HyperGryph.Streaming.MonoComponentConvertFromDelegate convertFromFunc, UnityEngine.HyperGryph.Streaming.MonoComponentAddComponentToDelegate addComponentToFunc, UnityEngine.HyperGryph.Streaming.MonoComponentGetComponentFromDelegate getComponentFromFunc)
  System.Void ResetMonoComponentConvertFuncFromScript(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType)
  System.Boolean IsMonoComponentConvertFuncValid(UnityEngine.HyperGryph.Streaming.StreamingComponentType componentType)
  System.Void BindProxyEntityConvertToFuncFromScript(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType, UnityEngine.HyperGryph.Streaming.ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, UnityEngine.HyperGryph.Streaming.ProxyEntityConvertToDelegate convertToFunc)
  System.Void ResetProxyEntityConvertToFuncFromScript(UnityEngine.HyperGryph.Streaming.ProxyEntityType entityType)
  System.IntPtr get_streamingScenesManaged()
  System.Int32 get_streamingSceneCount()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.Streaming.StreamingSceneV2> GetStreamingScenesArray()
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.StreamingLayerConfig
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  public            System.Boolean                  enabled  // 0x10
  public            UnityEngine.HyperGryph.Streaming.StreamingLayerlayer  // 0x11
  public            System.Boolean                  chunkLoad  // 0x12
  public            System.Int32                    gridSize  // 0x14
  public            System.Int32                    priority  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.Streaming.HGStreamingSettings
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
METHODS:
  System.Void set_loadDirtyDistance(System.Single value)
  System.Void set_unloadDirtyDistance(System.Single value)
  System.Void set_loadElapsedMsPerFrame(System.Single value)
  System.Void set_unloadElapsedMsPerFrame(System.Single value)
  System.Void SetLayerConfig(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, UnityEngine.HyperGryph.Streaming.StreamingLayerConfig config)
  System.Void SetLayerConfig_Injected(UnityEngine.HyperGryph.Streaming.StreamingLayer layer, UnityEngine.HyperGryph.Streaming.StreamingLayerConfig& config)
END_CLASS

