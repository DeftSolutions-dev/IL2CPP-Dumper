// ========================================================
// Dumped by @desirepro
// Assembly: Unity.RenderPipelines.Core.Runtime.dll
// Classes:  411
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SceneRenderPipeline
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Rendering.RenderPipelineAssetrenderPipelineAsset  // 0x18
METHODS:
  System.Void OnEnable()
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: ShaderQuality
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.HGShaderQualitySettings.ShaderQualityLow  // 0x0
  public    static  Beyond.Rendering.HGShaderQualitySettings.ShaderQualityHigh  // 0x0
METHODS:
END_CLASS

CLASS: UpDirection
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LightAnchor.UpDirectionWorld  // 0x0
  public    static  UnityEngine.LightAnchor.UpDirectionLocal  // 0x0
METHODS:
END_CLASS

CLASS: Axes
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            UnityEngine.Vector3             up  // 0x10
  public            UnityEngine.Vector3             right  // 0x1C
  public            UnityEngine.Vector3             forward  // 0x28
METHODS:
END_CLASS

CLASS: Brick
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            UnityEngine.Vector3Int          position  // 0x10
  public            System.Int32                    subdivisionLevel  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3Int position, System.Int32 subdivisionLevel)
  System.Boolean Equals(UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick other)
END_CLASS

CLASS: ReservedBrick
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brickbrick  // 0x10
  public            System.Int32                    flattenedIdx  // 0x20
METHODS:
END_CLASS

CLASS: VoxelMeta
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegIdid  // 0x10
  public            System.Collections.Generic.List<System.UInt16>brickIndices  // 0x18
METHODS:
END_CLASS

CLASS: BrickMeta
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Collections.Generic.HashSet<UnityEngine.Vector3Int>voxels  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.ReservedBrick>bricks  // 0x18
METHODS:
END_CLASS

CLASS: CellIndexUpdateInfo
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    firstChunkIndex  // 0x10
  public            System.Int32                    numberOfChunks  // 0x14
  public            System.Int32                    minSubdivInCell  // 0x18
  public            UnityEngine.Vector3Int          minValidBrickIndexForCellAtMaxRes  // 0x1C
  public            UnityEngine.Vector3Int          maxValidBrickIndexForCellAtMaxResPlusOne  // 0x28
  public            UnityEngine.Vector3Int          cellPositionInBricksAtMaxRes  // 0x34
METHODS:
END_CLASS

CLASS: BrickChunkAlloc
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    x  // 0x10
  public            System.Int32                    y  // 0x14
  public            System.Int32                    z  // 0x18
METHODS:
  System.Int32 flattenIndex(System.Int32 sx, System.Int32 sy)
END_CLASS

CLASS: DataLocation
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  private           UnityEngine.Texture3D           TexL0_L1rx  // 0x10
  private           UnityEngine.Texture3D           TexL1_G_ry  // 0x18
  private           UnityEngine.Texture3D           TexL1_B_rz  // 0x20
  private           UnityEngine.Texture3D           TexL2_0  // 0x28
  private           UnityEngine.Texture3D           TexL2_1  // 0x30
  private           UnityEngine.Texture3D           TexL2_2  // 0x38
  private           UnityEngine.Texture3D           TexL2_3  // 0x40
  private           System.Int32                    width  // 0x48
  private           System.Int32                    height  // 0x4C
  private           System.Int32                    depth  // 0x50
METHODS:
  System.Void Cleanup()
END_CLASS

CLASS: IndexMetaData
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  private           UnityEngine.Vector3Int          minLocalIdx  // 0x10
  private           UnityEngine.Vector3Int          maxLocalIdx  // 0x1C
  private           System.Int32                    firstChunkIndex  // 0x28
  private           System.Int32                    minSubdiv  // 0x2C
METHODS:
  System.Void Pack(System.UInt32[]& vals)
END_CLASS

CLASS: Cell
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    index  // 0x10
  public            UnityEngine.Vector3Int          position  // 0x14
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick>bricks  // 0x20
  public            UnityEngine.Vector3[]           probePositions  // 0x28
  public            UnityEngine.Rendering.SphericalHarmonicsL2[]sh  // 0x30
  public            System.Single[]                 validity  // 0x38
  public            System.Int32                    minSubdiv  // 0x40
  public            System.Int32                    flatIdxInCellIndices  // 0x44
  public            System.Boolean                  loaded  // 0x48
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CellChunkInfo
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc>chunks  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CellSortInfo
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  private           System.String                   sourceAsset  // 0x10
  private           UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cellcell  // 0x18
  private           System.Single                   distanceToCamera  // 0x20
  private           UnityEngine.Vector3             position  // 0x24
METHODS:
  System.Int32 CompareTo(System.Object obj)
  System.Void .ctor()
END_CLASS

CLASS: Volume
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  private           UnityEngine.Vector3             corner  // 0x10
  private           UnityEngine.Vector3             X  // 0x1C
  private           UnityEngine.Vector3             Y  // 0x28
  private           UnityEngine.Vector3             Z  // 0x34
  private           System.Single                   maxSubdivisionMultiplier  // 0x40
  private           System.Single                   minSubdivisionMultiplier  // 0x44
METHODS:
  System.Void .ctor(UnityEngine.Matrix4x4 trs, System.Single maxSubdivision, System.Single minSubdivision)
  System.Void .ctor(UnityEngine.Vector3 corner, UnityEngine.Vector3 X, UnityEngine.Vector3 Y, UnityEngine.Vector3 Z, System.Single maxSubdivision, System.Single minSubdivision)
  System.Void .ctor(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume copy)
  UnityEngine.Bounds CalculateAABB()
  System.Void CalculateCenterAndSize(UnityEngine.Vector3& center, UnityEngine.Vector3& size)
  System.Void Transform(UnityEngine.Matrix4x4 trs)
  System.String ToString()
  System.Boolean Equals(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume other)
END_CLASS

CLASS: RefVolTransform
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            UnityEngine.Matrix4x4           refSpaceToWS  // 0x10
  public            UnityEngine.Vector3             posWS  // 0x50
  public            UnityEngine.Quaternion          rot  // 0x5C
  public            System.Single                   scale  // 0x6C
METHODS:
END_CLASS

CLASS: RuntimeResources
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            UnityEngine.ComputeBuffer       index  // 0x10
  public            UnityEngine.ComputeBuffer       cellIndices  // 0x18
  public            UnityEngine.Texture3D           L0_L1rx  // 0x20
  public            UnityEngine.Texture3D           L1_G_ry  // 0x28
  public            UnityEngine.Texture3D           L1_B_rz  // 0x30
  public            UnityEngine.Texture3D           L2_0  // 0x38
  public            UnityEngine.Texture3D           L2_1  // 0x40
  public            UnityEngine.Texture3D           L2_2  // 0x48
  public            UnityEngine.Texture3D           L2_3  // 0x50
METHODS:
END_CLASS

CLASS: RegId
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  private           System.Int32                    id  // 0x10
METHODS:
  System.Boolean IsValid()
  System.Void Invalidate()
  System.Boolean op_Equality(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId lhs, UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId rhs)
  System.Boolean op_Inequality(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId lhs, UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId rhs)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: ExtraDataActionInput
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
METHODS:
END_CLASS

CLASS: InitInfo
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            UnityEngine.Vector3Int          pendingMinCellPosition  // 0x10
  public            UnityEngine.Vector3Int          pendingMaxCellPosition  // 0x1C
METHODS:
END_CLASS

CLASS: CellInstancedDebugProbes
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Matrix4x4[]>probeBuffers  // 0x10
  public            System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock>props  // 0x18
  public            UnityEngine.Hash128             cellHash  // 0x20
  public            UnityEngine.Vector3             cellPosition  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Version
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile.VersionInitial  // 0x0
METHODS:
END_CLASS

CLASS: AssetVersion
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersionFirst  // 0x0
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersionAddProbeVolumesAtlasEncodingModes  // 0x0
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersionPV2  // 0x0
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersionChunkBasedIndex  // 0x0
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersionMax  // 0x0
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersionCurrent  // 0x0
METHODS:
END_CLASS

CLASS: SerializableAssetItem
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            UnityEngine.Experimental.Rendering.ProbeVolumeStatestate  // 0x10
  public            UnityEngine.Experimental.Rendering.ProbeVolumeAssetasset  // 0x18
METHODS:
END_CLASS

CLASS: SerializableBoundItem
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.String                   sceneGUID  // 0x10
  public            UnityEngine.Bounds              bounds  // 0x18
METHODS:
END_CLASS

CLASS: SerializableHasPVItem
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.String                   sceneGUID  // 0x10
  public            System.Boolean                  hasProbeVolumes  // 0x18
METHODS:
END_CLASS

CLASS: SerializablePVProfile
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.String                   sceneGUID  // 0x10
  public            UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfileprofile  // 0x18
METHODS:
END_CLASS

CLASS: SerializablePVBakeSettings
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.String                   sceneGUID  // 0x10
  public            UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettingssettings  // 0x18
METHODS:
END_CLASS

CLASS: BakingSet
TYPE:  class
TOKEN: 0x2000039
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Collections.Generic.List<System.String>sceneGUIDs  // 0x18
  public            UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettingssettings  // 0x20
  public            UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfileprofile  // 0x40
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Strings
TYPE:  class
TOKEN: 0x2000042
FIELDS:
  public    static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltipClearRenderTargetsAtCreation  // 0x0
  public    static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltipDisablePassCulling  // 0x10
  public    static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltipImmediateMode  // 0x20
  public    static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltipEnableLogging  // 0x30
  public    static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltipLogFrameInformation  // 0x40
  public    static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltipLogResources  // 0x50
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: PassDebugData
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Collections.Generic.List<System.Int32>[]resourceReadLists  // 0x18
  public            System.Collections.Generic.List<System.Int32>[]resourceWriteLists  // 0x20
  public            System.Boolean                  culled  // 0x28
  public            System.Boolean                  generateDebugData  // 0x29
METHODS:
END_CLASS

CLASS: ResourceDebugData
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Boolean                  imported  // 0x18
  public            System.Int32                    creationPassIndex  // 0x1C
  public            System.Int32                    releasePassIndex  // 0x20
  public            System.Collections.Generic.List<System.Int32>consumerList  // 0x28
  public            System.Collections.Generic.List<System.Int32>producerList  // 0x30
METHODS:
END_CLASS

CLASS: CompiledResourceInfo
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Collections.Generic.List<System.Int32>producers  // 0x10
  public            System.Collections.Generic.List<System.Int32>consumers  // 0x18
  public            System.Int32                    refCount  // 0x20
  public            System.Boolean                  imported  // 0x24
METHODS:
  System.Void Reset()
END_CLASS

CLASS: CompiledPassInfo
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPasspass  // 0x10
  public            System.Collections.Generic.List<System.Int32>[]resourceCreateList  // 0x18
  public            System.Collections.Generic.List<System.Int32>[]resourceReleaseList  // 0x20
  public            System.Int32                    refCount  // 0x28
  public            System.Boolean                  culled  // 0x2C
  public            System.Boolean                  hasSideEffect  // 0x2D
  public            System.Int32                    syncToPassIndex  // 0x30
  public            System.Int32                    syncFromPassIndex  // 0x34
  public            System.Boolean                  needGraphicsFence  // 0x38
  public            UnityEngine.Rendering.GraphicsFencefence  // 0x40
  public            System.Boolean                  enableAsyncCompute  // 0x50
METHODS:
  System.Boolean get_allowPassCulling()
  System.Void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass)
END_CLASS

CLASS: ProfilingScopePassData
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  public            UnityEngine.Rendering.ProfilingSamplersampler  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: OnGraphRegisteredDelegate
TYPE:  class
TOKEN: 0x200004B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph)
  System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: OnExecutionRegisteredDelegate
TYPE:  class
TOKEN: 0x200004C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, System.String executionName)
  System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, System.String executionName, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SharedObjectPoolBase
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  protected static  System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase>s_AllocatedPools  // 0x0
METHODS:
  System.Void Clear()
  System.Void ClearAll()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: SharedObjectPool`1
TYPE:  class
TOKEN: 0x2000055
EXTENDS: SharedObjectPoolBase
FIELDS:
  private           System.Collections.Generic.Stack<T>m_Pool  // 0x0
  private   static readonly System.Lazy<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T>>s_Instance  // 0x0
METHODS:
  T Get()
  System.Void Release(T value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T> AllocatePool()
  System.Void Clear()
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T> get_sharedPool()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: ResourceLogInfo
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  public            System.String                   name  // 0x0
  public            System.Int64                    size  // 0x0
METHODS:
END_CLASS

CLASS: ResourceCallback
TYPE:  class
TOKEN: 0x2000062
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res)
  System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: RenderGraphResourcesData
TYPE:  class
TOKEN: 0x2000063
FIELDS:
  public            UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource>resourceArray  // 0x10
  public            System.Int32                    sharedResourcesCount  // 0x18
  public            UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePoolpool  // 0x20
  public            UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallbackcreateResourceCallback  // 0x28
  public            UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallbackreleaseResourceCallback  // 0x30
METHODS:
  System.Void Clear(System.Boolean onException, System.Int32 frameIndex)
  System.Void Cleanup()
  System.Void PurgeUnusedGraphicsResources(System.Int32 frameIndex)
  System.Int32 AddNewRenderGraphResource(ResType& outRes, System.Boolean pooledResource)
  System.Void .ctor()
END_CLASS

CLASS: FixedBufferStringQueue
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  private           System.Byte*                    m_ReadCursor  // 0x10
  private           System.Byte*                    m_WriteCursor  // 0x18
  private   readonly System.Byte*                    m_BufferEnd  // 0x20
  private   readonly System.Byte*                    m_BufferStart  // 0x28
  private   readonly System.Int32                    m_BufferLength  // 0x30
  private           System.Int32                    <Count>k__BackingField  // 0x34
METHODS:
  System.Int32 get_Count()
  System.Void set_Count(System.Int32 value)
  System.Void .ctor(System.Byte* ptr, System.Int32 length)
  System.Boolean TryPush(System.String v)
  System.Boolean TryPop(System.String& v)
  System.Void Clear()
END_CLASS

CLASS: IKeyGetter`2
TYPE:  interface
TOKEN: 0x200007F
FIELDS:
METHODS:
  TKey Get(TValue& v)
END_CLASS

CLASS: DefaultKeyGetter`1
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
METHODS:
  T Get(T& v)
END_CLASS

CLASS: UintKeyGetter
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
METHODS:
  System.UInt32 Get(System.UInt32& v)
END_CLASS

CLASS: ScalerContainer
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            UnityEngine.Rendering.DynamicResScalePolicyTypetype  // 0x10
  public            UnityEngine.Rendering.PerformDynamicResmethod  // 0x18
METHODS:
END_CLASS

CLASS: UpsamplerScheduleType
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleTypeBeforePost  // 0x0
  public    static  UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleTypeAfterPost  // 0x0
METHODS:
END_CLASS

CLASS: PooledObject
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  private   readonly T                               m_ToReturn  // 0x0
  private   readonly UnityEngine.Rendering.ObjectPool<T>m_Pool  // 0x0
METHODS:
  System.Void .ctor(T value, UnityEngine.Rendering.ObjectPool<T> pool)
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: StereoRenderingMode
TYPE:  struct
TOKEN: 0x20000A2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.XRGraphics.StereoRenderingModeMultiPass  // 0x0
  public    static  UnityEngine.Rendering.XRGraphics.StereoRenderingModeSinglePass  // 0x0
  public    static  UnityEngine.Rendering.XRGraphics.StereoRenderingModeSinglePassInstanced  // 0x0
  public    static  UnityEngine.Rendering.XRGraphics.StereoRenderingModeSinglePassMultiView  // 0x0
METHODS:
END_CLASS

CLASS: DebugActionKeyType
TYPE:  struct
TOKEN: 0x20000A9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DebugActionState.DebugActionKeyTypeButton  // 0x0
  public    static  UnityEngine.Rendering.DebugActionState.DebugActionKeyTypeAxis  // 0x0
  public    static  UnityEngine.Rendering.DebugActionState.DebugActionKeyTypeKey  // 0x0
METHODS:
END_CLASS

CLASS: Container
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: Widget
FIELDS:
  private           UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget><children>k__BackingField  // 0x48
METHODS:
  UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children()
  System.Void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value)
  UnityEngine.Rendering.DebugUI.Panel get_panel()
  System.Void set_panel(UnityEngine.Rendering.DebugUI.Panel value)
  System.Void .ctor()
  System.Void .ctor(System.String displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children)
  System.Void GenerateQueryPath()
  System.Void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e)
  System.Void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e)
  System.Int32 GetHashCode()
END_CLASS

CLASS: ContextMenuItem
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.String                   displayName  // 0x10
  public            System.Action                   action  // 0x18
METHODS:
END_CLASS

CLASS: Foldout
TYPE:  class
TOKEN: 0x20000AE
EXTENDS: Container
FIELDS:
  public            System.Boolean                  opened  // 0x50
  public            System.Boolean                  isHeader  // 0x51
  public            System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Foldout.ContextMenuItem>contextMenuItems  // 0x58
  private           System.String[]                 <columnLabels>k__BackingField  // 0x60
  private           System.String[]                 <columnTooltips>k__BackingField  // 0x68
METHODS:
  System.Boolean get_isReadOnly()
  System.String[] get_columnLabels()
  System.Void set_columnLabels(System.String[] value)
  System.String[] get_columnTooltips()
  System.Void set_columnTooltips(System.String[] value)
  System.Void .ctor()
  System.Void .ctor(System.String displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children, System.String[] columnLabels, System.String[] columnTooltips)
  System.Boolean GetValue()
  System.Object UnityEngine.Rendering.DebugUI.IValueField.GetValue()
  System.Void SetValue(System.Object value)
  System.Object ValidateValue(System.Object value)
  System.Void SetValue(System.Boolean value)
END_CLASS

CLASS: HBox
TYPE:  class
TOKEN: 0x20000B0
EXTENDS: Container
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VBox
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: Container
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Row
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: Foldout
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Table
TYPE:  class
TOKEN: 0x20000B2
EXTENDS: Container
FIELDS:
  public            System.Boolean                  isReadOnly  // 0x50
  private           System.Boolean[]                m_Header  // 0x58
METHODS:
  System.Void .ctor()
  System.Void SetColumnVisibility(System.Int32 index, System.Boolean visible)
  System.Boolean GetColumnVisibility(System.Int32 index)
  System.Boolean[] get_VisibleColumns()
  System.Void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e)
  System.Void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e)
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x20000B4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DebugUI.FlagsNone  // 0x0
  public    static  UnityEngine.Rendering.DebugUI.FlagsEditorOnly  // 0x0
  public    static  UnityEngine.Rendering.DebugUI.FlagsRuntimeOnly  // 0x0
  public    static  UnityEngine.Rendering.DebugUI.FlagsEditorForceUpdate  // 0x0
METHODS:
END_CLASS

CLASS: NameAndTooltip
TYPE:  struct
TOKEN: 0x20000B6
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   tooltip  // 0x18
METHODS:
END_CLASS

CLASS: Widget
TYPE:  class
TOKEN: 0x20000B5
FIELDS:
  protected         UnityEngine.Rendering.DebugUI.Panelm_Panel  // 0x10
  protected         UnityEngine.Rendering.DebugUI.IContainerm_Parent  // 0x18
  private           UnityEngine.Rendering.DebugUI.Flags<flags>k__BackingField  // 0x20
  private           System.String                   <displayName>k__BackingField  // 0x28
  private           System.String                   <tooltip>k__BackingField  // 0x30
  private           System.String                   <queryPath>k__BackingField  // 0x38
  public            System.Func<System.Boolean>     isHiddenCallback  // 0x40
METHODS:
  UnityEngine.Rendering.DebugUI.Panel get_panel()
  System.Void set_panel(UnityEngine.Rendering.DebugUI.Panel value)
  UnityEngine.Rendering.DebugUI.IContainer get_parent()
  System.Void set_parent(UnityEngine.Rendering.DebugUI.IContainer value)
  UnityEngine.Rendering.DebugUI.Flags get_flags()
  System.Void set_flags(UnityEngine.Rendering.DebugUI.Flags value)
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  System.String get_tooltip()
  System.Void set_tooltip(System.String value)
  System.String get_queryPath()
  System.Void set_queryPath(System.String value)
  System.Boolean get_isEditorOnly()
  System.Boolean get_isRuntimeOnly()
  System.Boolean get_isInactiveInEditor()
  System.Boolean get_isHidden()
  System.Void GenerateQueryPath()
  System.Int32 GetHashCode()
  System.Void set_nameAndTooltip(UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip value)
  System.Void .ctor()
END_CLASS

CLASS: IContainer
TYPE:  interface
TOKEN: 0x20000B7
FIELDS:
METHODS:
  UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children()
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  System.String get_queryPath()
END_CLASS

CLASS: IValueField
TYPE:  interface
TOKEN: 0x20000B8
FIELDS:
METHODS:
  System.Object GetValue()
  System.Void SetValue(System.Object value)
  System.Object ValidateValue(System.Object value)
END_CLASS

CLASS: Button
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: Widget
FIELDS:
  private           System.Action                   <action>k__BackingField  // 0x48
METHODS:
  System.Action get_action()
  System.Void set_action(System.Action value)
  System.Void .ctor()
END_CLASS

CLASS: Value
TYPE:  class
TOKEN: 0x20000BA
EXTENDS: Widget
FIELDS:
  private           System.Func<System.Object>      <getter>k__BackingField  // 0x48
  public            System.Single                   refreshRate  // 0x50
METHODS:
  System.Func<System.Object> get_getter()
  System.Void set_getter(System.Func<System.Object> value)
  System.Void .ctor()
  System.Object GetValue()
END_CLASS

CLASS: Field`1
TYPE:  class
TOKEN: 0x20000BB
EXTENDS: Widget
FIELDS:
  private           System.Func<T>                  <getter>k__BackingField  // 0x0
  private           System.Action<T>                <setter>k__BackingField  // 0x0
  public            System.Action<UnityEngine.Rendering.DebugUI.Field<T>,T>onValueChanged  // 0x0
METHODS:
  System.Func<T> get_getter()
  System.Void set_getter(System.Func<T> value)
  System.Action<T> get_setter()
  System.Void set_setter(System.Action<T> value)
  System.Object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(System.Object value)
  T ValidateValue(T value)
  System.Object UnityEngine.Rendering.DebugUI.IValueField.GetValue()
  T GetValue()
  System.Void SetValue(System.Object value)
  System.Void SetValue(T value)
  System.Void .ctor()
END_CLASS

CLASS: BoolField
TYPE:  class
TOKEN: 0x20000BC
EXTENDS: Field`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HistoryBoolField
TYPE:  class
TOKEN: 0x20000BD
EXTENDS: BoolField
FIELDS:
  private           System.Func<System.Boolean>[]   <historyGetter>k__BackingField  // 0x60
METHODS:
  System.Func<System.Boolean>[] get_historyGetter()
  System.Void set_historyGetter(System.Func<System.Boolean>[] value)
  System.Int32 get_historyDepth()
  System.Boolean GetHistoryValue(System.Int32 historyIndex)
  System.Void .ctor()
END_CLASS

CLASS: IntField
TYPE:  class
TOKEN: 0x20000BE
EXTENDS: Field`1
FIELDS:
  public            System.Func<System.Int32>       min  // 0x60
  public            System.Func<System.Int32>       max  // 0x68
  public            System.Int32                    incStep  // 0x70
  public            System.Int32                    intStepMult  // 0x74
METHODS:
  System.Int32 ValidateValue(System.Int32 value)
  System.Void .ctor()
END_CLASS

CLASS: UIntField
TYPE:  class
TOKEN: 0x20000BF
EXTENDS: Field`1
FIELDS:
  public            System.Func<System.UInt32>      min  // 0x60
  public            System.Func<System.UInt32>      max  // 0x68
  public            System.UInt32                   incStep  // 0x70
  public            System.UInt32                   intStepMult  // 0x74
METHODS:
  System.UInt32 ValidateValue(System.UInt32 value)
  System.Void .ctor()
END_CLASS

CLASS: FloatField
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: Field`1
FIELDS:
  public            System.Func<System.Single>      min  // 0x60
  public            System.Func<System.Single>      max  // 0x68
  public            System.Single                   incStep  // 0x70
  public            System.Single                   incStepMult  // 0x74
  public            System.Int32                    decimals  // 0x78
METHODS:
  System.Single ValidateValue(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: EnumUtility
TYPE:  class
TOKEN: 0x20000C1
FIELDS:
METHODS:
  UnityEngine.GUIContent[] MakeEnumNames(System.Type enumType)
  System.Int32[] MakeEnumValues(System.Type enumType)
END_CLASS

CLASS: EnumField
TYPE:  class
TOKEN: 0x20000C3
EXTENDS: Field`1
FIELDS:
  public            UnityEngine.GUIContent[]        enumNames  // 0x60
  public            System.Int32[]                  enumValues  // 0x68
  private           System.Int32[]                  quickSeparators  // 0x70
  private           System.Int32[]                  indexes  // 0x78
  private           System.Func<System.Int32>       <getIndex>k__BackingField  // 0x80
  private           System.Action<System.Int32>     <setIndex>k__BackingField  // 0x88
METHODS:
  System.Func<System.Int32> get_getIndex()
  System.Void set_getIndex(System.Func<System.Int32> value)
  System.Action<System.Int32> get_setIndex()
  System.Void set_setIndex(System.Action<System.Int32> value)
  System.Int32 get_currentIndex()
  System.Void set_currentIndex(System.Int32 value)
  System.Void set_autoEnum(System.Type value)
  System.Void InitQuickSeparators()
  System.Void InitIndexes()
  System.Void .ctor()
END_CLASS

CLASS: HistoryEnumField
TYPE:  class
TOKEN: 0x20000C5
EXTENDS: EnumField
FIELDS:
  private           System.Func<System.Int32>[]     <historyIndexGetter>k__BackingField  // 0x90
METHODS:
  System.Func<System.Int32>[] get_historyIndexGetter()
  System.Void set_historyIndexGetter(System.Func<System.Int32>[] value)
  System.Int32 get_historyDepth()
  System.Int32 GetHistoryValue(System.Int32 historyIndex)
  System.Void .ctor()
END_CLASS

CLASS: BitField
TYPE:  class
TOKEN: 0x20000C6
EXTENDS: Field`1
FIELDS:
  private           UnityEngine.GUIContent[]        <enumNames>k__BackingField  // 0x60
  private           System.Int32[]                  <enumValues>k__BackingField  // 0x68
  private           System.Type                     m_EnumType  // 0x70
METHODS:
  UnityEngine.GUIContent[] get_enumNames()
  System.Void set_enumNames(UnityEngine.GUIContent[] value)
  System.Int32[] get_enumValues()
  System.Void set_enumValues(System.Int32[] value)
  System.Type get_enumType()
  System.Void set_enumType(System.Type value)
  System.Void .ctor()
END_CLASS

CLASS: ColorField
TYPE:  class
TOKEN: 0x20000C7
EXTENDS: Field`1
FIELDS:
  public            System.Boolean                  hdr  // 0x60
  public            System.Boolean                  showAlpha  // 0x61
  public            System.Boolean                  showPicker  // 0x62
  public            System.Single                   incStep  // 0x64
  public            System.Single                   incStepMult  // 0x68
  public            System.Int32                    decimals  // 0x6C
METHODS:
  UnityEngine.Color ValidateValue(UnityEngine.Color value)
  System.Void .ctor()
END_CLASS

CLASS: Vector2Field
TYPE:  class
TOKEN: 0x20000C8
EXTENDS: Field`1
FIELDS:
  public            System.Single                   incStep  // 0x60
  public            System.Single                   incStepMult  // 0x64
  public            System.Int32                    decimals  // 0x68
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Vector3Field
TYPE:  class
TOKEN: 0x20000C9
EXTENDS: Field`1
FIELDS:
  public            System.Single                   incStep  // 0x60
  public            System.Single                   incStepMult  // 0x64
  public            System.Int32                    decimals  // 0x68
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Vector4Field
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: Field`1
FIELDS:
  public            System.Single                   incStep  // 0x60
  public            System.Single                   incStepMult  // 0x64
  public            System.Int32                    decimals  // 0x68
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Style
TYPE:  struct
TOKEN: 0x20000CC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DebugUI.MessageBox.StyleInfo  // 0x0
  public    static  UnityEngine.Rendering.DebugUI.MessageBox.StyleWarning  // 0x0
  public    static  UnityEngine.Rendering.DebugUI.MessageBox.StyleError  // 0x0
METHODS:
END_CLASS

CLASS: MessageBox
TYPE:  class
TOKEN: 0x20000CB
EXTENDS: Widget
FIELDS:
  public            UnityEngine.Rendering.DebugUI.MessageBox.Stylestyle  // 0x48
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Panel
TYPE:  class
TOKEN: 0x20000CD
FIELDS:
  private           UnityEngine.Rendering.DebugUI.Flags<flags>k__BackingField  // 0x10
  private           System.String                   <displayName>k__BackingField  // 0x18
  private           System.Int32                    <groupIndex>k__BackingField  // 0x20
  private           UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget><children>k__BackingField  // 0x28
  private           System.Action<UnityEngine.Rendering.DebugUI.Panel>onSetDirty  // 0x30
METHODS:
  UnityEngine.Rendering.DebugUI.Flags get_flags()
  System.Void set_flags(UnityEngine.Rendering.DebugUI.Flags value)
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  System.Int32 get_groupIndex()
  System.Void set_groupIndex(System.Int32 value)
  System.String get_queryPath()
  System.Boolean get_isEditorOnly()
  System.Boolean get_isRuntimeOnly()
  System.Boolean get_isInactiveInEditor()
  System.Boolean get_editorForceUpdate()
  UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children()
  System.Void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value)
  System.Void add_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value)
  System.Void remove_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value)
  System.Void .ctor()
  System.Void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e)
  System.Void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e)
  System.Void SetDirty()
  System.Int32 GetHashCode()
  System.Int32 System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(UnityEngine.Rendering.DebugUI.Panel other)
END_CLASS

CLASS: SunSourceDirLightOverrideLensFlareData
TYPE:  struct
TOKEN: 0x20000DF
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            UnityEngine.Rendering.LensFlareDataSRPlensFlareData  // 0x18
  public            System.Single                   intensity  // 0x20
  public            System.Single                   scale  // 0x24
  public            System.Boolean                  useOcclusion  // 0x28
  public            System.Single                   occlusionRadius  // 0x2C
  public            System.UInt32                   sampleCount  // 0x30
  public            System.Single                   occlusionOffset  // 0x34
  public            System.Boolean                  allowOffScreen  // 0x38
METHODS:
END_CLASS

CLASS: SunSourceDirLightOverrideLightData
TYPE:  struct
TOKEN: 0x20000E0
FIELDS:
  public            UnityEngine.Quaternion          rotationLensFlare  // 0x10
  public            UnityEngine.Vector3             dirLightFoward  // 0x20
  public            UnityEngine.Color               color  // 0x2C
METHODS:
END_CLASS

CLASS: SunSourceDirLightOverrideInfo
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  public            UnityEngine.GameObject          dirLightGameObject  // 0x10
  public            UnityEngine.Rendering.LensFlareCommonSRP.SunSourceDirLightOverrideLensFlareDataflareData  // 0x18
  public            UnityEngine.Rendering.LensFlareCommonSRP.SunSourceDirLightOverrideLightDatalightData  // 0x48
METHODS:
END_CLASS

CLASS: Hammersley2dSeq16
TYPE:  struct
TOKEN: 0x20000F4
FIELDS:
  public            UnityEngine.Rendering.Hammersley.Hammersley2dSeq16.<hammersley2dSeq16>e__FixedBufferhammersley2dSeq16  // 0x10
METHODS:
END_CLASS

CLASS: Hammersley2dSeq32
TYPE:  struct
TOKEN: 0x20000F6
FIELDS:
  public            UnityEngine.Rendering.Hammersley.Hammersley2dSeq32.<hammersley2dSeq32>e__FixedBufferhammersley2dSeq32  // 0x10
METHODS:
END_CLASS

CLASS: Hammersley2dSeq64
TYPE:  struct
TOKEN: 0x20000F8
FIELDS:
  public            UnityEngine.Rendering.Hammersley.Hammersley2dSeq64.<hammersley2dSeq64>e__FixedBufferhammersley2dSeq64  // 0x10
METHODS:
END_CLASS

CLASS: Hammersley2dSeq256
TYPE:  struct
TOKEN: 0x20000FA
FIELDS:
  public            UnityEngine.Rendering.Hammersley.Hammersley2dSeq256.<hammersley2dSeq256>e__FixedBufferhammersley2dSeq256  // 0x10
METHODS:
END_CLASS

CLASS: BlitType
TYPE:  struct
TOKEN: 0x2000100
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitTypePadding  // 0x0
  public    static  UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitTypePaddingMultiply  // 0x0
  public    static  UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitTypeOctahedralPadding  // 0x0
  public    static  UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitTypeOctahedralPaddingMultiply  // 0x0
METHODS:
END_CLASS

CLASS: AtlasNode
TYPE:  class
TOKEN: 0x2000106
FIELDS:
  public            UnityEngine.Rendering.AtlasAllocator.AtlasNodem_RightChild  // 0x10
  public            UnityEngine.Rendering.AtlasAllocator.AtlasNodem_BottomChild  // 0x18
  public            UnityEngine.Vector4             m_Rect  // 0x20
METHODS:
  UnityEngine.Rendering.AtlasAllocator.AtlasNode Allocate(UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode>& pool, System.Int32 width, System.Int32 height, System.Boolean powerOfTwoPadding)
  System.Void Release(UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode>& pool)
  System.Void .ctor()
END_CLASS

CLASS: BlitType
TYPE:  struct
TOKEN: 0x2000109
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.Texture2DAtlas.BlitTypeDefault  // 0x0
  public    static  UnityEngine.Rendering.Texture2DAtlas.BlitTypeCubeTo2DOctahedral  // 0x0
  public    static  UnityEngine.Rendering.Texture2DAtlas.BlitTypeSingleChannel  // 0x0
  public    static  UnityEngine.Rendering.Texture2DAtlas.BlitTypeCubeTo2DOctahedralSingleChannel  // 0x0
METHODS:
END_CLASS

CLASS: AtlasNodePool
TYPE:  class
TOKEN: 0x200010B
FIELDS:
  private           UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNode[]m_Nodes  // 0x10
  private           System.Int16                    m_Next  // 0x18
  private           System.Int16                    m_FreelistHead  // 0x1A
METHODS:
  System.Void .ctor(System.Int16 capacity)
  System.Void Dispose()
  System.Void Clear()
  System.Int16 AtlasNodeCreate(System.Int16 parent)
  System.Void AtlasNodeFree(System.Int16 index)
END_CLASS

CLASS: AtlasNodeFlags
TYPE:  struct
TOKEN: 0x200010D
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNode.AtlasNodeFlagsIsOccupied  // 0x0
METHODS:
END_CLASS

CLASS: AtlasNode
TYPE:  struct
TOKEN: 0x200010C
FIELDS:
  public            System.Int16                    m_Self  // 0x10
  public            System.Int16                    m_Parent  // 0x12
  public            System.Int16                    m_LeftChild  // 0x14
  public            System.Int16                    m_RightChild  // 0x16
  public            System.Int16                    m_FreelistNext  // 0x18
  public            System.UInt16                   m_Flags  // 0x1A
  public            UnityEngine.Vector4             m_Rect  // 0x20
METHODS:
  System.Void .ctor(System.Int16 self, System.Int16 parent)
  System.Boolean IsOccupied()
  System.Void SetIsOccupied()
  System.Void ClearIsOccupied()
  System.Boolean IsLeafNode()
  System.Int16 Allocate(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool, System.Int32 width, System.Int32 height)
  System.Void ReleaseChildren(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool)
  System.Void ReleaseAndMerge(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool)
  System.Boolean IsMergeNeeded(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool)
END_CLASS

CLASS: BlitShaderIDs
TYPE:  class
TOKEN: 0x200011A
FIELDS:
  public    static readonly System.Int32                    _BlitTexture  // 0x0
  public    static readonly System.Int32                    _BlitCubeTexture  // 0x4
  public    static readonly System.Int32                    _BlitScaleBias  // 0x8
  public    static readonly System.Int32                    _BlitScaleBiasRt  // 0xC
  public    static readonly System.Int32                    _BlitMipLevel  // 0x10
  public    static readonly System.Int32                    _BlitTextureSize  // 0x14
  public    static readonly System.Int32                    _BlitPaddingSize  // 0x18
  public    static readonly System.Int32                    _InputDepth  // 0x1C
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Sections
TYPE:  class
TOKEN: 0x200011F
FIELDS:
  public    static  System.Int32                    section1  // 0x0
  public    static  System.Int32                    section2  // 0x0
  public    static  System.Int32                    section3  // 0x0
  public    static  System.Int32                    section4  // 0x0
  public    static  System.Int32                    section5  // 0x0
  public    static  System.Int32                    section6  // 0x0
  public    static  System.Int32                    section7  // 0x0
  public    static  System.Int32                    section8  // 0x0
METHODS:
END_CLASS

CLASS: Priorities
TYPE:  class
TOKEN: 0x2000120
FIELDS:
  public    static  System.Int32                    assetsCreateShaderMenuPriority  // 0x0
  public    static  System.Int32                    assetsCreateRenderingMenuPriority  // 0x0
  public    static  System.Int32                    editMenuPriority  // 0x0
  public    static  System.Int32                    gameObjectMenuPriority  // 0x0
  public    static  System.Int32                    srpLensFlareMenuPriority  // 0x0
METHODS:
END_CLASS

CLASS: ShaderConstants
TYPE:  class
TOKEN: 0x2000125
FIELDS:
  public    static readonly System.Int32                    _FsrEasuConstants0  // 0x0
  public    static readonly System.Int32                    _FsrEasuConstants1  // 0x4
  public    static readonly System.Int32                    _FsrEasuConstants2  // 0x8
  public    static readonly System.Int32                    _FsrEasuConstants3  // 0xC
  public    static readonly System.Int32                    _FsrRcasConstants  // 0x10
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Segment
TYPE:  class
TOKEN: 0x2000127
FIELDS:
  public            System.Single                   offsetX  // 0x10
  public            System.Single                   offsetY  // 0x14
  public            System.Single                   scaleX  // 0x18
  public            System.Single                   scaleY  // 0x1C
  public            System.Single                   lnA  // 0x20
  public            System.Single                   B  // 0x24
METHODS:
  System.Single Eval(System.Single x)
  System.Void .ctor()
END_CLASS

CLASS: DirectParams
TYPE:  struct
TOKEN: 0x2000128
FIELDS:
  private           System.Single                   x0  // 0x10
  private           System.Single                   y0  // 0x14
  private           System.Single                   x1  // 0x18
  private           System.Single                   y1  // 0x1C
  private           System.Single                   W  // 0x20
  private           System.Single                   overshootX  // 0x24
  private           System.Single                   overshootY  // 0x28
  private           System.Single                   gamma  // 0x2C
METHODS:
END_CLASS

CLASS: Uniforms
TYPE:  class
TOKEN: 0x2000129
FIELDS:
  private           UnityEngine.Rendering.HableCurveparent  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Rendering.HableCurve parent)
  UnityEngine.Vector4 get_curve()
  UnityEngine.Vector4 get_toeSegmentA()
  UnityEngine.Vector4 get_toeSegmentB()
  UnityEngine.Vector4 get_midSegmentA()
  UnityEngine.Vector4 get_midSegmentB()
  UnityEngine.Vector4 get_shoSegmentA()
  UnityEngine.Vector4 get_shoSegmentB()
END_CLASS

CLASS: Package
TYPE:  struct
TOKEN: 0x2000130
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReloadAttribute.PackageBuiltin  // 0x0
  public    static  UnityEngine.Rendering.ReloadAttribute.PackageRoot  // 0x0
METHODS:
END_CLASS

CLASS: Indent
TYPE:  class
TOKEN: 0x200013D
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Int32                    relativeAmount  // 0x10
METHODS:
  System.Void .ctor(System.Int32 relativeAmount)
END_CLASS

CLASS: __StaticArrayInitTypeSize=24
TYPE:  struct
TOKEN: 0x2000196
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=144
TYPE:  struct
TOKEN: 0x2000197
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=256
TYPE:  struct
TOKEN: 0x2000198
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=512
TYPE:  struct
TOKEN: 0x2000199
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=1024
TYPE:  struct
TOKEN: 0x200019A
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=4096
TYPE:  struct
TOKEN: 0x200019B
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.Rendering.HGShaderQualitySettings
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  public    static  Beyond.Rendering.HGShaderQualitySettings.ShaderQualityHgShaderLod  // 0x0
METHODS:
  System.Void .cctor()
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

CLASS: UnityEngine.LightAnchor
TYPE:  class
TOKEN: 0x2000007
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.Single                   k_ArcRadius  // 0x0
  private   static  System.Single                   k_AxisLength  // 0x0
  private   static  System.Single                   k_MaxDistance  // 0x0
  private           System.Single                   m_Distance  // 0x18
  private           UnityEngine.LightAnchor.UpDirectionm_FrameSpace  // 0x1C
  private           UnityEngine.Transform           m_AnchorPositionOverride  // 0x20
  private           UnityEngine.Vector3             m_AnchorPositionOffset  // 0x28
  private           System.Single                   m_Yaw  // 0x34
  private           System.Single                   m_Pitch  // 0x38
  private           System.Single                   m_Roll  // 0x3C
METHODS:
  System.Single get_yaw()
  System.Void set_yaw(System.Single value)
  System.Single get_pitch()
  System.Void set_pitch(System.Single value)
  System.Single get_roll()
  System.Void set_roll(System.Single value)
  System.Single get_distance()
  System.Void set_distance(System.Single value)
  UnityEngine.LightAnchor.UpDirection get_frameSpace()
  System.Void set_frameSpace(UnityEngine.LightAnchor.UpDirection value)
  UnityEngine.Vector3 get_anchorPosition()
  UnityEngine.Transform get_anchorPositionOverride()
  System.Void set_anchorPositionOverride(UnityEngine.Transform value)
  UnityEngine.Vector3 get_anchorPositionOffset()
  System.Void set_anchorPositionOffset(UnityEngine.Vector3 value)
  System.Single NormalizeAngleDegree(System.Single angle)
  System.Void SynchronizeOnTransform(UnityEngine.Camera camera)
  System.Void UpdateTransform(UnityEngine.Camera camera, UnityEngine.Vector3 anchor)
  UnityEngine.LightAnchor.Axes GetWorldSpaceAxes(UnityEngine.Camera camera, UnityEngine.Vector3 anchor)
  System.Void Update()
  System.Void OnDrawGizmosSelected()
  System.Void UpdateTransform(UnityEngine.Vector3 up, UnityEngine.Vector3 right, UnityEngine.Vector3 forward, UnityEngine.Vector3 anchor)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeBrickIndex
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static  System.Int32                    kMaxSubdivisionLevels  // 0x0
  private   static  System.Int32                    kIndexChunkSize  // 0x0
  private           System.Collections.BitArray     m_IndexChunks  // 0x10
  private           System.Int32                    m_IndexInChunks  // 0x18
  private           System.Int32                    m_NextFreeChunk  // 0x1C
  private           UnityEngine.ComputeBuffer       m_PhysicalIndexBuffer  // 0x20
  private           System.Int32[]                  m_PhysicalIndexBufferData  // 0x28
  private           System.Int32                    <estimatedVMemCost>k__BackingField  // 0x30
  private           UnityEngine.Vector3Int          m_CenterRS  // 0x34
  private           System.Collections.Generic.Dictionary<UnityEngine.Vector3Int,System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.VoxelMeta>>m_VoxelToBricks  // 0x40
  private           System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId,UnityEngine.Experimental.Rendering.ProbeBrickIndex.BrickMeta>m_BricksToVoxels  // 0x48
  private           System.Boolean                  m_NeedUpdateIndexComputeBuffer  // 0x50
METHODS:
  System.Int32 get_estimatedVMemCost()
  System.Void set_estimatedVMemCost(System.Int32 value)
  System.Int32 GetVoxelSubdivLevel()
  System.Int32 SizeOfPhysicalIndexFromBudget(UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget)
  System.Void .ctor(UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget)
  System.Void UploadIndexData()
  System.Void Clear()
  System.Void MapBrickToVoxels(UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick brick, System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxels)
  System.Void ClearVoxel(UnityEngine.Vector3Int pos, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
  System.Void GetRuntimeResources(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources& rr)
  System.Void Cleanup()
  System.Int32 MergeIndex(System.Int32 index, System.Int32 size)
  System.Boolean AssignIndexChunksToCell(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, System.Int32 bricksCount, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo& cellUpdateInfo)
  System.Void AddBricks(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick> bricks, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations, System.Int32 allocationSize, System.Int32 poolWidth, System.Int32 poolHeight, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
  System.Void RemoveBricks(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
  System.Void UpdateIndexForVoxel(UnityEngine.Vector3Int voxel, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
  System.Void UpdatePhysicalIndex(UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, System.Int32 value, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
  System.Void ClipToIndexSpace(UnityEngine.Vector3Int pos, System.Int32 subdiv, UnityEngine.Vector3Int& outMinpos, UnityEngine.Vector3Int& outMaxpos, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
  System.Void UpdateIndexForVoxel(UnityEngine.Vector3Int voxel, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.ReservedBrick> bricks, System.Collections.Generic.List<System.UInt16> indices, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeBrickPool
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private   static  System.Int32                    kBrickCellCount  // 0x0
  private   static  System.Int32                    kBrickProbeCountPerDim  // 0x0
  private   static  System.Int32                    kBrickProbeCountTotal  // 0x0
  private           System.Int32                    <estimatedVMemCost>k__BackingField  // 0x10
  private   static  System.Int32                    kMaxPoolWidth  // 0x0
  private           System.Int32                    m_AllocationSize  // 0x14
  private           UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudgetm_MemoryBudget  // 0x18
  private           UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocationm_Pool  // 0x20
  private           UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAllocm_NextFreeChunk  // 0x68
  private           System.Collections.Generic.Stack<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc>m_FreeList  // 0x78
  private           UnityEngine.Experimental.Rendering.ProbeVolumeSHBandsm_SHBands  // 0x80
METHODS:
  System.Int32 get_estimatedVMemCost()
  System.Void set_estimatedVMemCost(System.Int32 value)
  System.Void .ctor(System.Int32 allocationSize, UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands)
  System.Void EnsureTextureValidity()
  System.Int32 GetChunkSize()
  System.Int32 GetChunkSizeInProbeCount()
  System.Int32 GetPoolWidth()
  System.Int32 GetPoolHeight()
  UnityEngine.Vector3Int GetPoolDimensions()
  System.Void GetRuntimeResources(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources& rr)
  System.Void Clear()
  System.Void Allocate(System.Int32 numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations)
  System.Void Deallocate(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations)
  System.Void Update(UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands)
  UnityEngine.Vector3Int ProbeCountToDataLocSize(System.Int32 numProbes)
  UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation CreateDataLocation(System.Int32 numProbes, System.Boolean compressed, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands, System.Int32& allocatedBytes)
  System.Void SetPixel(UnityEngine.Color[]& data, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 dataLocWidth, System.Int32 dataLocHeight, UnityEngine.Color value)
  System.Void FillDataLocation(UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation& loc, UnityEngine.Rendering.SphericalHarmonicsL2[] shl2, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands)
  System.Void DerivePoolSizeFromBudget(System.Int32 allocationSize, UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, System.Int32& width, System.Int32& height, System.Int32& depth)
  System.Void Cleanup()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeCellIndices
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private   static  System.Int32                    kUintPerEntry  // 0x0
  private           System.Int32                    <estimatedVMemCost>k__BackingField  // 0x10
  private           UnityEngine.ComputeBuffer       m_IndexOfIndicesBuffer  // 0x18
  private           System.UInt32[]                 m_IndexOfIndicesData  // 0x20
  private           UnityEngine.Vector3Int          m_CellCount  // 0x28
  private           UnityEngine.Vector3Int          m_CellMin  // 0x34
  private           System.Int32                    m_CellSizeInMinBricks  // 0x40
  private           System.Boolean                  m_NeedUpdateComputeBuffer  // 0x44
METHODS:
  System.Int32 get_estimatedVMemCost()
  System.Void set_estimatedVMemCost(System.Int32 value)
  UnityEngine.Vector3Int GetCellIndexDimension()
  UnityEngine.Vector3Int GetCellMinPosition()
  System.Int32 GetFlatIndex(UnityEngine.Vector3Int normalizedPos)
  System.Void .ctor(UnityEngine.Vector3Int cellMin, UnityEngine.Vector3Int cellMax, System.Int32 cellSizeInMinBricks)
  System.Int32 GetFlatIdxForCell(UnityEngine.Vector3Int cellPosition)
  System.Void AddCell(System.Int32 cellFlatIdx, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo)
  System.Void MarkCellAsUnloaded(System.Int32 cellFlatIdx)
  System.Void PushComputeData()
  System.Void GetRuntimeResources(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources& rr)
  System.Void Cleanup()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumeSystemParameters
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudgetmemoryBudget  // 0x10
  public            UnityEngine.Mesh                probeDebugMesh  // 0x18
  public            UnityEngine.Shader              probeDebugShader  // 0x20
  public            UnityEngine.Experimental.Rendering.ProbeVolumeSceneDatasceneData  // 0x28
  public            UnityEngine.Experimental.Rendering.ProbeVolumeSHBandsshBands  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumeShadingParameters
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Single                   normalBias  // 0x10
  public            System.Single                   viewBias  // 0x14
  public            System.Boolean                  scaleBiasByMinDistanceBetweenProbes  // 0x18
  public            System.Single                   samplingNoise  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudgetMemoryBudgetLow  // 0x0
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudgetMemoryBudgetMedium  // 0x0
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudgetMemoryBudgetHigh  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumeSHBands
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeSHBandsSphericalHarmonicsL1  // 0x0
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeSHBandsSphericalHarmonicsL2  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeReferenceVolume
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  private   static  System.Int32                    kProbeIndexPoolAllocationSize  // 0x0
  private           System.Boolean                  m_IsInitialized  // 0x10
  private           System.Int32                    m_ID  // 0x14
  private           UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RefVolTransformm_Transform  // 0x18
  private           System.Int32                    m_MaxSubdivision  // 0x78
  private           UnityEngine.Experimental.Rendering.ProbeBrickPoolm_Pool  // 0x80
  private           UnityEngine.Experimental.Rendering.ProbeBrickIndexm_Index  // 0x88
  private           UnityEngine.Experimental.Rendering.ProbeCellIndicesm_CellIndices  // 0x90
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc>m_TmpSrcChunks  // 0x98
  private           System.Single[]                 m_PositionOffsets  // 0xA0
  private           System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId,System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc>>m_Registry  // 0xA8
  private           UnityEngine.Bounds              m_CurrGlobalBounds  // 0xB0
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell>cells  // 0xC8
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Experimental.Rendering.ProbeReferenceVolume.CellChunkInfo>m_ChunkInfo  // 0xD0
  private           UnityEngine.Experimental.Rendering.ProbeVolumeSceneDatasceneData  // 0xD8
  public            System.Action<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.ExtraDataActionInput>retrieveExtraDataAction  // 0xE0
  private           System.Boolean                  m_BricksLoaded  // 0xE8
  private           System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell,UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId>m_CellToBricks  // 0xF0
  private           System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId,UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo>m_BricksToCellUpdateInfo  // 0xF8
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeAsset>m_PendingAssetsToBeLoaded  // 0x100
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeAsset>m_PendingAssetsToBeUnloaded  // 0x108
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeAsset>m_ActiveAssets  // 0x110
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.CellSortInfo>m_CellsToBeLoaded  // 0x118
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_CellRefCounting  // 0x120
  private           System.Boolean                  m_NeedLoadAsset  // 0x128
  private           System.Boolean                  m_ProbeReferenceVolumeInit  // 0x129
  private           System.Boolean                  m_EnabledBySRP  // 0x12A
  private           UnityEngine.Experimental.Rendering.ProbeReferenceVolume.InitInfom_PendingInitInfo  // 0x12C
  private           System.Boolean                  m_NeedsIndexRebuild  // 0x144
  private           System.Boolean                  m_HasChangedIndex  // 0x145
  private           System.Int32                    m_CBShaderID  // 0x148
  private           System.Int32                    m_NumberOfCellsLoadedPerFrame  // 0x14C
  private           UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudgetm_MemoryBudget  // 0x150
  private           UnityEngine.Experimental.Rendering.ProbeVolumeSHBandsm_SHBands  // 0x154
  private           System.Boolean                  clearAssetsOnVolumeClear  // 0x158
  private   static  UnityEngine.Experimental.Rendering.ProbeReferenceVolume_instance  // 0x0
  private   static  System.Int32                    kProbesPerBatch  // 0x0
  private   readonly UnityEngine.Experimental.Rendering.ProbeVolumeDebug<debugDisplay>k__BackingField  // 0x160
  private   readonly UnityEngine.Color[]             <subdivisionDebugColors>k__BackingField  // 0x168
  private           UnityEngine.Rendering.DebugUI.Widget[]m_DebugItems  // 0x170
  private           UnityEngine.Mesh                m_DebugMesh  // 0x178
  private           UnityEngine.Material            m_DebugMaterial  // 0x180
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.CellInstancedDebugProbes>m_CellDebugData  // 0x188
  private           UnityEngine.Plane[]             m_DebugFrustumPlanes  // 0x190
  private           System.Single                   dilationValidtyThreshold  // 0x198
  private           System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume,System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick>>realtimeSubdivisionInfo  // 0x1A0
METHODS:
  System.Void InvalidateAllCellRefs()
  System.Boolean get_isInitialized()
  System.Boolean get_enabledBySRP()
  UnityEngine.Experimental.Rendering.ProbeVolumeSHBands get_shBands()
  UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget get_memoryBudget()
  UnityEngine.Experimental.Rendering.ProbeReferenceVolume get_instance()
  System.Void SetNumberOfCellsLoadedPerFrame(System.Int32 numberOfCells)
  System.Void Initialize(UnityEngine.Experimental.Rendering.ProbeVolumeSystemParameters& parameters)
  System.Void SetEnableStateFromSRP(System.Boolean srpEnablesPV)
  System.Void ForceSHBand(UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands)
  System.Void Cleanup()
  System.Int32 GetVideoMemoryCost()
  System.Void RemoveCell(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell)
  System.Void AddCell(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> chunks)
  System.Boolean CheckCompatibilityWithCollection(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset, System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeAsset> collection)
  System.Void AddPendingAssetLoading(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset)
  System.Void AddPendingAssetRemoval(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset)
  System.Void RemovePendingAsset(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset)
  System.Void PerformPendingIndexChangeAndInit()
  System.Void SetMinBrickAndMaxSubdiv(System.Single minBrickSize, System.Int32 maxSubdiv)
  System.Void LoadAsset(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset)
  System.Void PerformPendingLoading()
  System.Void PerformPendingDeletion()
  System.Int32 GetNumberOfBricksAtSubdiv(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Vector3Int& minValidLocalIdxAtMaxRes, UnityEngine.Vector3Int& sizeOfValidIndicesAtMaxRes)
  System.Boolean GetCellIndexUpdate(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo& cellUpdateInfo)
  System.Void LoadPendingCells(System.Boolean loadAll)
  System.Void PerformPendingOperations(System.Boolean loadAllCells)
  System.Void InitProbeReferenceVolume(System.Int32 allocationSize, UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands)
  System.Void SortPendingCells(UnityEngine.Vector3 cameraPosition)
  System.Void .ctor()
  UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources GetRuntimeResources()
  System.Void SetTRS(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Single minBrickSize)
  System.Void SetMaxSubdivision(System.Int32 maxSubdivision)
  System.Int32 CellSize(System.Int32 subdivisionLevel)
  System.Single BrickSize(System.Int32 subdivisionLevel)
  System.Single MinBrickSize()
  System.Single MaxBrickSize()
  UnityEngine.Matrix4x4 GetRefSpaceToWS()
  UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RefVolTransform GetTransform()
  System.Int32 GetMaxSubdivision()
  System.Int32 GetMaxSubdivision(System.Single multiplier)
  System.Single GetDistanceBetweenProbes(System.Int32 subdivisionLevel)
  System.Single MinDistanceBetweenProbes()
  System.Boolean DataHasBeenLoaded()
  System.Void Clear()
  UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId AddBricks(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick> bricks, UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation dataloc, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc>& ch_list)
  System.Void ReleaseBricks(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id)
  System.Void UpdateConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Experimental.Rendering.ProbeVolumeShadingParameters parameters)
  System.Void CleanupLoadedData()
  UnityEngine.Experimental.Rendering.ProbeVolumeDebug get_debugDisplay()
  UnityEngine.Color[] get_subdivisionDebugColors()
  System.Void RenderDebug(UnityEngine.Camera camera)
  System.Void InitializeDebug(UnityEngine.Mesh debugProbeMesh, UnityEngine.Shader debugProbeShader)
  System.Void CleanupDebug()
  System.Void RefreshDebug(UnityEngine.Rendering.DebugUI.Field<T> field, T value)
  System.Void DebugCellIndexChanged(UnityEngine.Rendering.DebugUI.Field<T> field, T value)
  System.Void RegisterDebug()
  System.Void UnregisterDebug(System.Boolean destroyPanel)
  System.Boolean ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Transform cameraTransform, UnityEngine.Plane[] frustumPlanes)
  System.Void DrawProbeDebug(UnityEngine.Camera camera)
  System.Void ClearDebugData()
  System.Void CreateInstancedProbes()
  System.Void OnClearLightingdata()
  System.Void .cctor()
  System.Boolean <RegisterDebug>b__119_0()
  System.Void <RegisterDebug>b__119_1(System.Boolean value)
  System.Boolean <RegisterDebug>b__119_2()
  System.Void <RegisterDebug>b__119_3(System.Boolean value)
  System.Single <RegisterDebug>b__119_4()
  System.Void <RegisterDebug>b__119_5(System.Single value)
  System.Boolean <RegisterDebug>b__119_7()
  System.Void <RegisterDebug>b__119_8(System.Boolean value)
  System.Int32 <RegisterDebug>b__119_9()
  System.Void <RegisterDebug>b__119_10(System.Int32 value)
  System.Int32 <RegisterDebug>b__119_11()
  System.Void <RegisterDebug>b__119_12(System.Int32 value)
  System.Single <RegisterDebug>b__119_13()
  System.Void <RegisterDebug>b__119_14(System.Single value)
  System.Single <RegisterDebug>b__119_17()
  System.Void <RegisterDebug>b__119_18(System.Single value)
  System.Single <RegisterDebug>b__119_19()
  System.Void <RegisterDebug>b__119_20(System.Single value)
  System.Int32 <RegisterDebug>b__119_22()
  System.Void <RegisterDebug>b__119_23(System.Int32 v)
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.DebugProbeShadingMode
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.DebugProbeShadingModeSH  // 0x0
  public    static  UnityEngine.Experimental.Rendering.DebugProbeShadingModeValidity  // 0x0
  public    static  UnityEngine.Experimental.Rendering.DebugProbeShadingModeValidityOverDilationThreshold  // 0x0
  public    static  UnityEngine.Experimental.Rendering.DebugProbeShadingModeSize  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumeDebug
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  public            System.Boolean                  drawProbes  // 0x10
  public            System.Boolean                  drawBricks  // 0x11
  public            System.Boolean                  drawCells  // 0x12
  public            System.Boolean                  realtimeSubdivision  // 0x13
  public            System.Int32                    subdivisionCellUpdatePerFrame  // 0x14
  public            System.Single                   subdivisionDelayInSeconds  // 0x18
  public            UnityEngine.Experimental.Rendering.DebugProbeShadingModeprobeShading  // 0x1C
  public            System.Single                   probeSize  // 0x20
  public            System.Single                   subdivisionViewCullingDistance  // 0x24
  public            System.Single                   probeCullingDistance  // 0x28
  public            System.Int32                    maxSubdivToVisualize  // 0x2C
  public            System.Single                   exposureCompensation  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile
TYPE:  class
TOKEN: 0x2000029
EXTENDS: ScriptableObject
FIELDS:
  private           UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile.Versionversion  // 0x18
  public            System.Int32                    simplificationLevels  // 0x1C
  public            System.Single                   minDistanceBetweenProbes  // 0x20
METHODS:
  System.Int32 get_cellSizeInBricks()
  System.Int32 get_maxSubdivision()
  System.Single get_minBrickSize()
  System.Single get_cellSizeInMeters()
  System.Void OnEnable()
  System.Boolean IsEquivalent(UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile otherProfile)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolume
TYPE:  class
TOKEN: 0x200002B
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  globalVolume  // 0x18
  public            UnityEngine.Vector3             size  // 0x1C
  public            System.Single                   geometryDistanceOffset  // 0x28
  public            UnityEngine.LayerMask           objectLayerMask  // 0x2C
  public            System.Int32                    lowestSubdivLevelOverride  // 0x30
  public            System.Int32                    highestSubdivLevelOverride  // 0x34
  public            System.Boolean                  overridesSubdivLevels  // 0x38
  private           System.Boolean                  mightNeedRebaking  // 0x39
  private           UnityEngine.Matrix4x4           cachedTransform  // 0x3C
  private           System.Int32                    cachedHashCode  // 0x7C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumeAsset
TYPE:  class
TOKEN: 0x200002C
EXTENDS: ScriptableObject
FIELDS:
  protected internal        System.Int32                    m_Version  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell>cells  // 0x20
  private           UnityEngine.Vector3Int          maxCellPosition  // 0x28
  private           UnityEngine.Vector3Int          minCellPosition  // 0x34
  private           UnityEngine.Bounds              globalBounds  // 0x40
  private           UnityEngine.Experimental.Rendering.ProbeVolumeSHBandsbands  // 0x58
  private           System.String                   m_AssetFullPath  // 0x60
  private           System.Int32                    cellSizeInBricks  // 0x68
  private           System.Single                   minDistanceBetweenProbes  // 0x6C
  private           System.Int32                    simplificationLevels  // 0x70
METHODS:
  System.Int32 get_Version()
  System.Int32 get_maxSubdivision()
  System.Single get_minBrickSize()
  System.Boolean CompatibleWith(UnityEngine.Experimental.Rendering.ProbeVolumeAsset otherAsset)
  System.String GetSerializedFullPath()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeDilationSettings
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Boolean                  enableDilation  // 0x10
  public            System.Single                   dilationDistance  // 0x14
  public            System.Single                   dilationValidityThreshold  // 0x18
  public            System.Int32                    dilationIterations  // 0x1C
  public            System.Boolean                  squaredDistWeighting  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.VirtualOffsetSettings
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Boolean                  useVirtualOffset  // 0x10
  public            System.Single                   outOfGeoOffset  // 0x14
  public            System.Single                   searchMultiplier  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettings
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            UnityEngine.Experimental.Rendering.ProbeDilationSettingsdilationSettings  // 0x10
  public            UnityEngine.Experimental.Rendering.VirtualOffsetSettingsvirtualOffsetSettings  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumeState
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeStateDefault  // 0x0
  public    static  UnityEngine.Experimental.Rendering.ProbeVolumeStateInvalid  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumePerSceneData
TYPE:  class
TOKEN: 0x2000032
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeVolumeState,UnityEngine.Experimental.Rendering.ProbeVolumeAsset>assets  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumePerSceneData.SerializableAssetItem>serializedAssets  // 0x20
  private           UnityEngine.Experimental.Rendering.ProbeVolumeStatem_CurrentState  // 0x28
  private           UnityEngine.Experimental.Rendering.ProbeVolumeStatem_PreviousState  // 0x2C
METHODS:
  System.Void OnAfterDeserialize()
  System.Void OnBeforeSerialize()
  System.Void StoreAssetForState(UnityEngine.Experimental.Rendering.ProbeVolumeState state, UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset)
  System.Void InvalidateAllAssets()
  UnityEngine.Experimental.Rendering.ProbeVolumeAsset GetCurrentStateAsset()
  System.Void QueueAssetLoading()
  System.Void QueueAssetRemoval()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ProbeVolumeSceneData
TYPE:  class
TOKEN: 0x2000034
FIELDS:
  private   static  System.Reflection.PropertyInfo  s_SceneGUID  // 0x0
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializableBoundItem>serializedBounds  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializableHasPVItem>serializedHasVolumes  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializablePVProfile>serializedProfiles  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializablePVBakeSettings>serializedBakeSettings  // 0x28
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet>serializedBakingSets  // 0x30
  private           UnityEngine.Object              parentAsset  // 0x38
  private           System.String                   parentSceneDataPropertyName  // 0x40
  public            System.Collections.Generic.Dictionary<System.String,UnityEngine.Bounds>sceneBounds  // 0x48
  private           System.Collections.Generic.Dictionary<System.String,System.Boolean>hasProbeVolumes  // 0x50
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile>sceneProfiles  // 0x58
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettings>sceneBakingSettings  // 0x60
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet>bakingSets  // 0x68
METHODS:
  System.String GetSceneGUID(UnityEngine.SceneManagement.Scene scene)
  System.Void .ctor(UnityEngine.Object parentAsset, System.String parentSceneDataPropertyName)
  System.Void SetParentObject(UnityEngine.Object parent, System.String parentSceneDataPropertyName)
  System.Void OnAfterDeserialize()
  System.Void UpdateBakingSets()
  System.Void OnBeforeSerialize()
  UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet CreateNewBakingSet(System.String name)
  System.Void InitializeBakingSet(UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet set, System.String name)
  System.Void SyncBakingSetSettings()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RendererList
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  private   static readonly UnityEngine.Rendering.ShaderTagIds_EmptyName  // 0x0
  public    static readonly UnityEngine.Experimental.Rendering.RendererListnullRendererList  // 0x8
  private           System.Boolean                  <isValid>k__BackingField  // 0x10
  public            UnityEngine.Rendering.CullingResultscullingResult  // 0x18
  public            UnityEngine.Rendering.DrawingSettingsdrawSettings  // 0x28
  public            UnityEngine.Rendering.FilteringSettingsfilteringSettings  // 0x174
  public            System.Nullable<UnityEngine.Rendering.RenderStateBlock>stateBlock  // 0x194
METHODS:
  System.Boolean get_isValid()
  System.Void set_isValid(System.Boolean value)
  UnityEngine.Experimental.Rendering.RendererList Create(UnityEngine.Experimental.Rendering.RendererListDesc& desc)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RendererListDesc
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            UnityEngine.Rendering.SortingCriteriasortingCriteria  // 0x10
  public            UnityEngine.Rendering.PerObjectDatarendererConfiguration  // 0x14
  public            UnityEngine.Rendering.RenderQueueRangerenderQueueRange  // 0x18
  public            System.Nullable<UnityEngine.Rendering.RenderStateBlock>stateBlock  // 0x20
  public            UnityEngine.Material            overrideMaterial  // 0x90
  public            System.Boolean                  excludeObjectMotionVectors  // 0x98
  public            System.Int32                    layerMask  // 0x9C
  public            System.Int32                    overrideMaterialPassIndex  // 0xA0
  private           UnityEngine.Rendering.CullingResults<cullingResult>k__BackingField  // 0xA8
  private           UnityEngine.Camera              <camera>k__BackingField  // 0xB8
  private           UnityEngine.Rendering.ShaderTagId<passName>k__BackingField  // 0xC0
  private           UnityEngine.Rendering.ShaderTagId[]<passNames>k__BackingField  // 0xC8
METHODS:
  UnityEngine.Rendering.CullingResults get_cullingResult()
  System.Void set_cullingResult(UnityEngine.Rendering.CullingResults value)
  UnityEngine.Camera get_camera()
  System.Void set_camera(UnityEngine.Camera value)
  UnityEngine.Rendering.ShaderTagId get_passName()
  System.Void set_passName(UnityEngine.Rendering.ShaderTagId value)
  UnityEngine.Rendering.ShaderTagId[] get_passNames()
  System.Void set_passNames(UnityEngine.Rendering.ShaderTagId[] value)
  System.Void .ctor(UnityEngine.Rendering.ShaderTagId passName, UnityEngine.Rendering.CullingResults cullingResult, UnityEngine.Camera camera)
  System.Void .ctor(UnityEngine.Rendering.ShaderTagId[] passNames, UnityEngine.Rendering.CullingResults cullingResult, UnityEngine.Camera camera)
  System.Boolean IsValid()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccessRead  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccessWrite  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccessReadWrite  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext
TYPE:  class
TOKEN: 0x200003E
FIELDS:
  public            UnityEngine.Rendering.ScriptableRenderContextrenderContext  // 0x10
  public            UnityEngine.Rendering.CommandBuffercmd  // 0x18
  public            UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPoolrenderGraphPool  // 0x20
  public            UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResourcesdefaultResources  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphParameters
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            System.String                   executionName  // 0x10
  public            System.Int32                    currentFrameIndex  // 0x18
  public            System.Boolean                  rendererListCulling  // 0x1C
  public            UnityEngine.Rendering.ScriptableRenderContextscriptableRenderContext  // 0x20
  public            UnityEngine.Rendering.CommandBuffercommandBuffer  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphExecution
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphrenderGraph  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph)
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams
TYPE:  class
TOKEN: 0x2000041
FIELDS:
  private           UnityEngine.Rendering.DebugUI.Widget[]m_DebugItems  // 0x10
  private           UnityEngine.Rendering.DebugUI.Panelm_DebugPanel  // 0x18
  public            System.Boolean                  clearRenderTargetsAtCreation  // 0x20
  public            System.Boolean                  clearRenderTargetsAtRelease  // 0x21
  public            System.Boolean                  disablePassCulling  // 0x22
  public            System.Boolean                  immediateMode  // 0x23
  public            System.Boolean                  enableLogging  // 0x24
  public            System.Boolean                  logFrameInformation  // 0x25
  public            System.Boolean                  logResources  // 0x26
METHODS:
  System.Void RegisterDebug(System.String name, UnityEngine.Rendering.DebugUI.Panel debugPanel)
  System.Void UnRegisterDebug(System.String name)
  System.Void .ctor()
  System.Boolean <RegisterDebug>b__10_0()
  System.Void <RegisterDebug>b__10_1(System.Boolean value)
  System.Boolean <RegisterDebug>b__10_2()
  System.Void <RegisterDebug>b__10_3(System.Boolean value)
  System.Boolean <RegisterDebug>b__10_4()
  System.Void <RegisterDebug>b__10_5(System.Boolean value)
  System.Boolean <RegisterDebug>b__10_6()
  System.Void <RegisterDebug>b__10_7(System.Boolean value)
  System.Void <RegisterDebug>b__10_8()
  System.Void <RegisterDebug>b__10_9()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc`1
TYPE:  class
TOKEN: 0x2000043
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext)
  System.IAsyncResult BeginInvoke(PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.PassDebugData>passList  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.ResourceDebugData>[]resourceLists  // 0x18
METHODS:
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  public    static readonly System.Int32                    kMaxMRTCount  // 0x0
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistrym_Resources  // 0x10
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPoolm_RenderGraphPool  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass>m_RenderPasses  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle>m_RendererLists  // 0x28
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParamsm_DebugParameters  // 0x30
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLoggerm_FrameInformationLogger  // 0x38
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResourcesm_DefaultResources  // 0x40
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Rendering.ProfilingSampler>m_DefaultProfilingSamplers  // 0x48
  private           System.Boolean                  m_ExecutionExceptionWasRaised  // 0x50
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContextm_RenderGraphContext  // 0x58
  private           UnityEngine.Rendering.CommandBufferm_PreviousCommandBuffer  // 0x60
  private           System.Int32                    m_CurrentImmediatePassIndex  // 0x68
  private           System.Collections.Generic.List<System.Int32>[]m_ImmediateModeResourceList  // 0x70
  private           UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo>[]m_CompiledResourcesInfos  // 0x78
  private           UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo>m_CompiledPassInfos  // 0x80
  private           System.Collections.Generic.Stack<System.Int32>m_CullingStack  // 0x88
  private           System.Int32                    m_ExecutionCount  // 0x90
  private           System.Int32                    m_CurrentFrameIndex  // 0x94
  private           System.Boolean                  m_HasRenderGraphBegun  // 0x98
  private           System.String                   m_CurrentExecutionName  // 0xA0
  private           System.Boolean                  m_RendererListCulling  // 0xA8
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData>m_DebugData  // 0xB0
  private   static  System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph>s_RegisteredGraphs  // 0x8
  private           System.String                   <name>k__BackingField  // 0xB8
  private   static  System.Boolean                  <requireDebugData>k__BackingField  // 0x10
  private   static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegateonGraphRegistered  // 0x18
  private   static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegateonGraphUnregistered  // 0x20
  private   static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegateonExecutionRegistered  // 0x28
  private   static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegateonExecutionUnregistered  // 0x30
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  System.Boolean get_requireDebugData()
  System.Void set_requireDebugData(System.Boolean value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources()
  System.Void .ctor(System.String name)
  System.Void Cleanup()
  System.Void RegisterDebug(UnityEngine.Rendering.DebugUI.Panel panel)
  System.Void UnRegisterDebug()
  System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph> GetRegisteredRenderGraphs()
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData GetDebugData(System.String executionName)
  System.Void EndFrame()
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc, System.Boolean explicitRelease)
  System.Void ReleaseSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture)
  System.Void CreateTextureIfInvalid(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& texture)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc GetTextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture)
  UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ImportComputeBuffer(UnityEngine.ComputeBuffer computeBuffer)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc& desc)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& computeBuffer)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc GetComputeBufferDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& computeBuffer)
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass(System.String passName, PassData& passData, UnityEngine.Rendering.ProfilingSampler sampler)
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass(System.String passName, PassData& passData)
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphExecution RecordAndExecute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphParameters& parameters)
  System.Void Execute()
  System.Void BeginProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler)
  System.Void EndProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler)
  UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> GetCompiledPassInfos()
  System.Void ClearCompiledGraph()
  System.Void InvalidateContext()
  System.Void OnPassAdded(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass)
  System.Void add_onGraphRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value)
  System.Void remove_onGraphRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value)
  System.Void add_onGraphUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value)
  System.Void remove_onGraphUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value)
  System.Void add_onExecutionRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value)
  System.Void remove_onExecutionRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value)
  System.Void add_onExecutionUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value)
  System.Void remove_onExecutionUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value)
  System.Void InitResourceInfosData(UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> resourceInfos, System.Int32 count)
  System.Void InitializeCompilationData()
  System.Void CountReferences()
  System.Void CullUnusedPasses()
  System.Void UpdatePassSynchronization(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& currentPassInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& producerPassInfo, System.Int32 currentPassIndex, System.Int32 lastProducer, System.Int32& intLastSyncIndex)
  System.Void UpdateResourceSynchronization(System.Int32& lastGraphicsPipeSync, System.Int32& lastComputePipeSync, System.Int32 currentPassIndex, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& resource)
  System.Int32 GetLatestProducerIndex(System.Int32 passIndex, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& info)
  System.Int32 GetLatestValidReadIndex(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& info)
  System.Int32 GetFirstValidWriteIndex(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& info)
  System.Int32 GetLatestValidWriteIndex(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& info)
  System.Void CreateRendererLists()
  System.Void UpdateResourceAllocationAndSynchronization()
  System.Boolean AreRendererListsEmpty(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> rendererLists)
  System.Void TryCullPassAtIndex(System.Int32 passIndex)
  System.Void CullRendererLists()
  System.Void CompileRenderGraph()
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& CompilePassImmediatly(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass)
  System.Void ExecutePassImmediatly(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass)
  System.Void ExecuteCompiledPass(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo, System.Int32 passIndex)
  System.Void ExecuteRenderGraph()
  System.Void PreRenderPassSetRenderTargets(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext)
  System.Void PreRenderPassExecute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext)
  System.Void PostRenderPassExecute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext)
  System.Void ClearRenderPasses()
  System.Void ReleaseImmediateModeResources()
  System.Void LogFrameInformation()
  System.Void LogRendererListsCreation()
  System.Void LogRenderPassBegin(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo)
  System.Void LogCulledPasses()
  UnityEngine.Rendering.ProfilingSampler GetDefaultProfilingSampler(System.String name)
  System.Void UpdateImportedResourceLifeTime(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.ResourceDebugData& data, System.Collections.Generic.List<System.Int32> passList)
  System.Void GenerateDebugData()
  System.Void CleanupDebugData()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfilingScope
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  private           System.Boolean                  m_Disposed  // 0x10
  private           UnityEngine.Rendering.ProfilingSamplerm_Sampler  // 0x18
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphm_RenderGraph  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ProfilingSampler sampler)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPassm_RenderPass  // 0x10
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistrym_Resources  // 0x18
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphm_RenderGraph  // 0x20
  private           System.Boolean                  m_Disposed  // 0x28
METHODS:
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle UseColorBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input, System.Int32 index)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle UseDepthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input, UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess flags)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ReadTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle WriteTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ReadWriteTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& texture)
  UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle UseRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle& input)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ReadComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& input)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle WriteComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& input)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateTransientComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc& desc)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateTransientComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& computebuffer)
  System.Void SetRenderFunc(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> renderFunc)
  System.Void EnableAsyncCompute(System.Boolean value)
  System.Void AllowPassCulling(System.Boolean value)
  System.Void Dispose()
  System.Void AllowRendererListCulling(System.Boolean value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle DependsOn(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle& input)
  System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph)
  System.Void Dispose(System.Boolean disposing)
  System.Void CheckResource(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res, System.Boolean dontCheckTransientReadWrite)
  System.Void GenerateDebugData(System.Boolean value)
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  private           System.Boolean                  m_IsValid  // 0x10
  private           UnityEngine.Rendering.RTHandle  m_BlackTexture2D  // 0x18
  private           UnityEngine.Rendering.RTHandle  m_WhiteTexture2D  // 0x20
  private           UnityEngine.Rendering.RTHandle  m_ShadowTexture2D  // 0x28
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<blackTexture>k__BackingField  // 0x30
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<whiteTexture>k__BackingField  // 0x40
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<clearTextureXR>k__BackingField  // 0x50
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<magentaTextureXR>k__BackingField  // 0x60
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<blackTextureXR>k__BackingField  // 0x70
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<blackTextureArrayXR>k__BackingField  // 0x80
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<blackUIntTextureXR>k__BackingField  // 0x90
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<blackTexture3DXR>k__BackingField  // 0xA0
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<whiteTextureXR>k__BackingField  // 0xB0
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<defaultShadowTexture>k__BackingField  // 0xC0
METHODS:
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTexture()
  System.Void set_blackTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_whiteTexture()
  System.Void set_whiteTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_clearTextureXR()
  System.Void set_clearTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_magentaTextureXR()
  System.Void set_magentaTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTextureXR()
  System.Void set_blackTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTextureArrayXR()
  System.Void set_blackTextureArrayXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackUIntTextureXR()
  System.Void set_blackUIntTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTexture3DXR()
  System.Void set_blackTexture3DXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_whiteTextureXR()
  System.Void set_whiteTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_defaultShadowTexture()
  System.Void set_defaultShadowTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  System.Void .ctor()
  System.Void Cleanup()
  System.Void InitializeForRendering(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph)
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogIndent
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  private           System.Int32                    m_Indentation  // 0x10
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLoggerm_Logger  // 0x18
  private           System.Boolean                  m_Disposed  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger, System.Int32 indentation)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger
TYPE:  class
TOKEN: 0x2000052
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,System.Text.StringBuilder>m_LogMap  // 0x10
  private           System.Text.StringBuilder       m_CurrentBuilder  // 0x18
  private           System.Int32                    m_CurrentIndentation  // 0x20
METHODS:
  System.Void Initialize(System.String logName)
  System.Void IncrementIndentation(System.Int32 value)
  System.Void DecrementIndentation(System.Int32 value)
  System.Void LogLine(System.String format, System.Object[] args)
  System.String GetLog(System.String logName)
  System.String GetAllLogs()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool
TYPE:  class
TOKEN: 0x2000053
FIELDS:
  private           System.Collections.Generic.Dictionary<System.ValueTuple<System.Type,System.Int32>,System.Collections.Generic.Stack<System.Object>>m_ArrayPool  // 0x10
  private           System.Collections.Generic.List<System.ValueTuple<System.Object,System.ValueTuple<System.Type,System.Int32>>>m_AllocatedArrays  // 0x18
  private           System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock>m_AllocatedMaterialPropertyBlocks  // 0x20
METHODS:
  System.Void .ctor()
  T[] GetTempArray(System.Int32 size)
  UnityEngine.MaterialPropertyBlock GetTempMaterialPropertyBlock()
  System.Void ReleaseAllTempAlloc()
  T Get()
  System.Void Release(T value)
  System.Void Cleanup()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass
TYPE:  class
TOKEN: 0x2000056
FIELDS:
  private           System.String                   <name>k__BackingField  // 0x10
  private           System.Int32                    <index>k__BackingField  // 0x18
  private           UnityEngine.Rendering.ProfilingSampler<customSampler>k__BackingField  // 0x20
  private           System.Boolean                  <enableAsyncCompute>k__BackingField  // 0x28
  private           System.Boolean                  <allowPassCulling>k__BackingField  // 0x29
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle<depthBuffer>k__BackingField  // 0x2C
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[]<colorBuffers>k__BackingField  // 0x40
  private           System.Int32                    <colorBufferMaxIndex>k__BackingField  // 0x48
  private           System.Int32                    <refCount>k__BackingField  // 0x4C
  private           System.Boolean                  <generateDebugData>k__BackingField  // 0x50
  private           System.Boolean                  <allowRendererListCulling>k__BackingField  // 0x51
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle>[]resourceReadLists  // 0x58
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle>[]resourceWriteLists  // 0x60
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle>[]transientResourceList  // 0x68
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle>usedRendererListList  // 0x70
  public            System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle>dependsOnRendererListList  // 0x78
METHODS:
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> GetExecuteDelegate()
  System.Void Execute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext)
  System.Void Release(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool pool)
  System.Boolean HasRenderFunc()
  System.String get_name()
  System.Void set_name(System.String value)
  System.Int32 get_index()
  System.Void set_index(System.Int32 value)
  UnityEngine.Rendering.ProfilingSampler get_customSampler()
  System.Void set_customSampler(UnityEngine.Rendering.ProfilingSampler value)
  System.Boolean get_enableAsyncCompute()
  System.Void set_enableAsyncCompute(System.Boolean value)
  System.Boolean get_allowPassCulling()
  System.Void set_allowPassCulling(System.Boolean value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_depthBuffer()
  System.Void set_depthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] get_colorBuffers()
  System.Void set_colorBuffers(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] value)
  System.Int32 get_colorBufferMaxIndex()
  System.Void set_colorBufferMaxIndex(System.Int32 value)
  System.Int32 get_refCount()
  System.Void set_refCount(System.Int32 value)
  System.Boolean get_generateDebugData()
  System.Void set_generateDebugData(System.Boolean value)
  System.Boolean get_allowRendererListCulling()
  System.Void set_allowRendererListCulling(System.Boolean value)
  System.Void .ctor()
  System.Void Clear()
  System.Void AddResourceWrite(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res)
  System.Void AddResourceRead(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res)
  System.Void AddTransientResource(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res)
  System.Void UseRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList)
  System.Void DependsOnRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList)
  System.Void EnableAsyncCompute(System.Boolean value)
  System.Void AllowPassCulling(System.Boolean value)
  System.Void AllowRendererListCulling(System.Boolean value)
  System.Void GenerateDebugData(System.Boolean value)
  System.Void SetColorBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle resource, System.Int32 index)
  System.Void SetDepthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess flags)
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass`1
TYPE:  class
TOKEN: 0x2000057
EXTENDS: RenderGraphPass
FIELDS:
  private           PassData                        data  // 0x0
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData>renderFunc  // 0x0
METHODS:
  System.Void Execute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext)
  System.Void Initialize(System.Int32 passIndex, PassData passData, System.String passName, UnityEngine.Rendering.ProfilingSampler sampler)
  System.Void Release(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool pool)
  System.Boolean HasRenderFunc()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileId
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileIdCompileRenderGraph  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileIdExecuteRenderGraph  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileIdRenderGraphClear  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileIdRenderGraphClearDebug  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  private   static  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandles_NullHandle  // 0x0
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandlehandle  // 0x10
METHODS:
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle get_nullHandle()
  System.Void .ctor(System.Int32 handle, System.Boolean shared)
  UnityEngine.ComputeBuffer op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle buffer)
  System.Boolean IsValid()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public            System.Int32                    count  // 0x10
  public            System.Int32                    stride  // 0x14
  public            UnityEngine.ComputeBufferType   type  // 0x18
  public            System.String                   name  // 0x20
METHODS:
  System.Void .ctor(System.Int32 count, System.Int32 stride)
  System.Void .ctor(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferResource
TYPE:  class
TOKEN: 0x200005B
EXTENDS: RenderGraphResource`2
FIELDS:
METHODS:
  System.String GetName()
  System.Void CreatePooledGraphicsResource()
  System.Void ReleasePooledGraphicsResource(System.Int32 frameIndex)
  System.Void CreateGraphicsResource(System.String name)
  System.Void ReleaseGraphicsResource()
  System.Void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger)
  System.Void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferPool
TYPE:  class
TOKEN: 0x200005C
EXTENDS: RenderGraphResourcePool`1
FIELDS:
METHODS:
  System.Void ReleaseInternalResource(UnityEngine.ComputeBuffer res)
  System.String GetResourceName(UnityEngine.ComputeBuffer res)
  System.Int64 GetResourceSize(UnityEngine.ComputeBuffer res)
  System.String GetResourceTypeName()
  System.Int32 GetSortIndex(UnityEngine.ComputeBuffer res)
  System.Void PurgeUnusedResources(System.Int32 currentFrameIndex)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool
TYPE:  class
TOKEN: 0x200005D
FIELDS:
METHODS:
  System.Void PurgeUnusedResources(System.Int32 currentFrameIndex)
  System.Void Cleanup()
  System.Void CheckFrameAllocation(System.Boolean onException, System.Int32 frameIndex)
  System.Void LogResources(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool`1
TYPE:  class
TOKEN: 0x200005E
EXTENDS: IRenderGraphResourcePool
FIELDS:
  protected         System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.SortedList<System.Int32,System.ValueTuple<Type,System.Int32>>>m_ResourcePool  // 0x0
  protected         System.Collections.Generic.List<System.Int32>m_RemoveList  // 0x0
  private           System.Collections.Generic.List<System.ValueTuple<System.Int32,Type>>m_FrameAllocatedResources  // 0x0
  protected static  System.Int32                    s_CurrentFrameIndex  // 0x0
  private   static  System.Int32                    kStaleResourceLifetime  // 0x0
METHODS:
  System.Void ReleaseInternalResource(Type res)
  System.String GetResourceName(Type res)
  System.Int64 GetResourceSize(Type res)
  System.String GetResourceTypeName()
  System.Int32 GetSortIndex(Type res)
  System.Void ReleaseResource(System.Int32 hash, Type resource, System.Int32 currentFrameIndex)
  System.Boolean TryGetResource(System.Int32 hashCode, Type& resource)
  System.Void Cleanup()
  System.Void RegisterFrameAllocation(System.Int32 hash, Type value)
  System.Void UnregisterFrameAllocation(System.Int32 hash, Type value)
  System.Void CheckFrameAllocation(System.Boolean onException, System.Int32 frameIndex)
  System.Void LogResources(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger)
  System.Boolean ShouldReleaseResource(System.Int32 lastUsedFrameIndex, System.Int32 currentFrameIndex)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  private   static  System.Int32                    kSharedResourceLifetime  // 0x0
  private   static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistrym_CurrentRegistry  // 0x0
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.RenderGraphResourcesData[]m_RenderGraphResources  // 0x10
  private           UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListResource>m_RendererListResources  // 0x18
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParamsm_RenderGraphDebug  // 0x20
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLoggerm_ResourceLogger  // 0x28
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLoggerm_FrameInformationLogger  // 0x30
  private           System.Int32                    m_CurrentFrameIndex  // 0x38
  private           System.Int32                    m_ExecutionCount  // 0x3C
  private           UnityEngine.Rendering.RTHandle  m_CurrentBackbuffer  // 0x40
  private   static  System.Int32                    kInitialRendererListCount  // 0x0
  private           System.Collections.Generic.List<UnityEngine.Rendering.RendererUtils.RendererList>m_ActiveRendererLists  // 0x48
METHODS:
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry get_current()
  System.Void set_current(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry value)
  UnityEngine.Rendering.RTHandle GetTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& handle)
  System.Boolean TextureNeedsFallback(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& handle)
  UnityEngine.Rendering.RendererUtils.RendererList GetRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle& handle)
  UnityEngine.ComputeBuffer GetComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& handle)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams renderGraphDebug, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger frameInformationLogger)
  System.Void BeginRenderGraph(System.Int32 executionCount)
  System.Void BeginExecute(System.Int32 currentFrameIndex)
  System.Void EndExecute()
  System.Void CheckHandleValidity(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res)
  System.Void CheckHandleValidity(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Int32 index)
  System.Void IncrementWriteCount(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res)
  System.String GetRenderGraphResourceName(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res)
  System.String GetRenderGraphResourceName(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Int32 index)
  System.Boolean IsRenderGraphResourceImported(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res)
  System.Boolean IsRenderGraphResourceShared(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Int32 index)
  System.Boolean IsGraphicsResourceCreated(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res)
  System.Boolean IsRendererListCreated(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle& res)
  System.Boolean IsRenderGraphResourceImported(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Int32 index)
  System.Int32 GetRenderGraphResourceTransientIndex(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc, System.Boolean explicitRelease)
  System.Void ReleaseSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc, System.Int32 transientPassIndex)
  System.Int32 GetTextureResourceCount()
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureResource GetTextureResource(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle)
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc GetTextureResourceDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle)
  System.Void ForceTextureClear(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle, UnityEngine.Color clearColor)
  UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ImportComputeBuffer(UnityEngine.ComputeBuffer computeBuffer)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc& desc, System.Int32 transientPassIndex)
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc GetComputeBufferResourceDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle)
  System.Int32 GetComputeBufferResourceCount()
  UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferResource GetComputeBufferResource(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle)
  System.Void UpdateSharedResourceLastFrameIndex(System.Int32 type, System.Int32 index)
  System.Void ManageSharedRenderGraphResources()
  System.Void CreatePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, System.Int32 type, System.Int32 index)
  System.Void CreateTextureCallback(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res)
  System.Void ReleasePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, System.Int32 type, System.Int32 index)
  System.Void ReleaseTextureCallback(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res)
  System.Void ValidateTextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc)
  System.Void ValidateRendererListDesc(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc)
  System.Void ValidateComputeBufferDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc& desc)
  System.Void CreateRendererLists(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> rendererLists, UnityEngine.Rendering.ScriptableRenderContext context, System.Boolean manualDispatch)
  System.Void Clear(System.Boolean onException)
  System.Void PurgeUnusedGraphicsResources()
  System.Void Cleanup()
  System.Void FlushLogs()
  System.Void LogResources()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle
TYPE:  struct
TOKEN: 0x2000064
FIELDS:
  private           System.Boolean                  m_IsValid  // 0x10
  private           System.Int32                    <handle>k__BackingField  // 0x14
METHODS:
  System.Int32 get_handle()
  System.Void set_handle(System.Int32 value)
  System.Void .ctor(System.Int32 handle)
  System.Int32 op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle handle)
  UnityEngine.Rendering.RendererUtils.RendererList op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList)
  System.Boolean IsValid()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListResource
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            UnityEngine.Rendering.RendererUtils.RendererListDescdesc  // 0x10
  public            UnityEngine.Rendering.RendererUtils.RendererListrendererList  // 0xF0
METHODS:
  System.Void .ctor(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc)
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceTypeTexture  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceTypeComputeBuffer  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceTypeCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  private   static  System.UInt32                   kValidityMask  // 0x0
  private   static  System.UInt32                   kIndexMask  // 0x0
  private           System.UInt32                   m_Value  // 0x10
  private   static  System.UInt32                   s_CurrentValidBit  // 0x0
  private   static  System.UInt32                   s_SharedResourceValidBit  // 0x4
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType<type>k__BackingField  // 0x14
METHODS:
  System.Int32 get_index()
  UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType get_type()
  System.Void set_type(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType value)
  System.Int32 get_iType()
  System.Void .ctor(System.Int32 value, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Boolean shared)
  System.Int32 op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle)
  System.Boolean IsValid()
  System.Void NewFrame(System.Int32 executionIndex)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource
TYPE:  class
TOKEN: 0x2000068
FIELDS:
  public            System.Boolean                  imported  // 0x10
  public            System.Boolean                  shared  // 0x11
  public            System.Boolean                  sharedExplicitRelease  // 0x12
  public            System.Boolean                  requestFallBack  // 0x13
  public            System.UInt32                   writeCount  // 0x14
  public            System.Int32                    cachedHash  // 0x18
  public            System.Int32                    transientPassIndex  // 0x1C
  public            System.Int32                    sharedResourceLastFrameUsed  // 0x20
  protected         UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePoolm_Pool  // 0x28
METHODS:
  System.Void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool)
  System.String GetName()
  System.Boolean IsCreated()
  System.Void IncrementWriteCount()
  System.Boolean NeedsFallBack()
  System.Void CreatePooledGraphicsResource()
  System.Void CreateGraphicsResource(System.String name)
  System.Void ReleasePooledGraphicsResource(System.Int32 frameIndex)
  System.Void ReleaseGraphicsResource()
  System.Void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger)
  System.Void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger)
  System.Int32 GetSortIndex()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResource`2
TYPE:  class
TOKEN: 0x2000069
EXTENDS: IRenderGraphResource
FIELDS:
  public            DescType                        desc  // 0x0
  public            ResType                         graphicsResource  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool)
  System.Boolean IsCreated()
  System.Void ReleaseGraphicsResource()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  private   static  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandles_NullHandle  // 0x0
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandlehandle  // 0x10
  private           UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandlefallBackResource  // 0x18
METHODS:
  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_nullHandle()
  System.Void .ctor(System.Int32 handle, System.Boolean shared)
  UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture)
  UnityEngine.Texture op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture)
  UnityEngine.RenderTexture op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture)
  UnityEngine.Rendering.RTHandle op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture)
  System.Boolean IsValid()
  System.Void SetFallBackResource(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeMode
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeModeExplicit  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeModeScale  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeModeFunctor  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.FastMemoryDesc
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            System.Boolean                  inFastMemory  // 0x10
  public            UnityEngine.Rendering.FastMemoryFlagsflags  // 0x14
  public            System.Single                   residencyFraction  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public            System.Int32                    width  // 0x10
  public            System.Int32                    height  // 0x14
  public            System.Int32                    slices  // 0x18
  public            UnityEngine.Rendering.DepthBits depthBufferBits  // 0x1C
  public            UnityEngine.Experimental.Rendering.GraphicsFormatcolorFormat  // 0x20
  public            UnityEngine.FilterMode          filterMode  // 0x24
  public            UnityEngine.TextureWrapMode     wrapMode  // 0x28
  public            UnityEngine.Rendering.TextureDimensiondimension  // 0x2C
  public            System.Boolean                  enableRandomWrite  // 0x30
  public            System.Boolean                  useMipMap  // 0x31
  public            System.Boolean                  autoGenerateMips  // 0x32
  public            System.Boolean                  isShadowMap  // 0x33
  public            System.Int32                    anisoLevel  // 0x34
  public            System.Single                   mipMapBias  // 0x38
  public            UnityEngine.Rendering.MSAASamplesmsaaSamples  // 0x3C
  public            System.Boolean                  bindTextureMS  // 0x40
  public            UnityEngine.RenderTextureMemorylessmemoryless  // 0x44
  public            System.String                   name  // 0x48
  public            UnityEngine.Experimental.Rendering.RenderGraphModule.FastMemoryDescfastMemoryDesc  // 0x50
  public            System.Boolean                  fallBackToBlackTexture  // 0x5C
  public            System.Boolean                  clearBuffer  // 0x5D
  public            UnityEngine.Color               clearColor  // 0x60
METHODS:
  System.Void InitDefaultValues(System.Boolean xrReady)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Boolean xrReady)
  System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc input)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.TextureResource
TYPE:  class
TOKEN: 0x200006E
EXTENDS: RenderGraphResource`2
FIELDS:
  private   static  System.Int32                    m_TextureCreationIndex  // 0x0
METHODS:
  System.String GetName()
  System.Void CreatePooledGraphicsResource()
  System.Void ReleasePooledGraphicsResource(System.Int32 frameIndex)
  System.Void CreateGraphicsResource(System.String name)
  System.Void ReleaseGraphicsResource()
  System.Void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger)
  System.Void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RenderGraphModule.TexturePool
TYPE:  class
TOKEN: 0x200006F
EXTENDS: RenderGraphResourcePool`1
FIELDS:
METHODS:
  System.Void ReleaseInternalResource(UnityEngine.Rendering.RTHandle res)
  System.String GetResourceName(UnityEngine.Rendering.RTHandle res)
  System.Int64 GetResourceSize(UnityEngine.Rendering.RTHandle res)
  System.String GetResourceTypeName()
  System.Int32 GetSortIndex(UnityEngine.Rendering.RTHandle res)
  System.Void PurgeUnusedResources(System.Int32 currentFrameIndex)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.CameraSwitcher
TYPE:  class
TOKEN: 0x2000070
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Camera[]            m_Cameras  // 0x18
  private           System.Int32                    m_CurrentCameraIndex  // 0x20
  private           UnityEngine.Camera              m_OriginalCamera  // 0x28
  private           UnityEngine.Vector3             m_OriginalCameraPosition  // 0x30
  private           UnityEngine.Quaternion          m_OriginalCameraRotation  // 0x3C
  private           UnityEngine.Camera              m_CurrentCamera  // 0x50
  private           UnityEngine.GUIContent[]        m_CameraNames  // 0x58
  private           System.Int32[]                  m_CameraIndices  // 0x60
  private           UnityEngine.Rendering.DebugUI.EnumFieldm_DebugEntry  // 0x68
  private           System.Int32                    m_DebugEntryEnumIndex  // 0x70
METHODS:
  System.Void OnEnable()
  System.Void OnDisable()
  System.Int32 GetCameraCount()
  UnityEngine.Camera GetNextCamera()
  System.Void SetCameraIndex(System.Int32 index)
  System.Void .ctor()
  System.Int32 <OnEnable>b__10_0()
  System.Void <OnEnable>b__10_1(System.Int32 value)
  System.Int32 <OnEnable>b__10_2()
  System.Void <OnEnable>b__10_3(System.Int32 value)
END_CLASS

CLASS: UnityEngine.Rendering.FreeCamera
TYPE:  class
TOKEN: 0x2000071
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.Single                   k_MouseSensitivityMultiplier  // 0x0
  public            System.Single                   m_LookSpeedController  // 0x18
  public            System.Single                   m_LookSpeedMouse  // 0x1C
  public            System.Single                   m_MoveSpeed  // 0x20
  public            System.Single                   m_MoveSpeedIncrement  // 0x24
  public            System.Single                   m_Turbo  // 0x28
  private           UnityEngine.InputSystem.InputActionlookAction  // 0x30
  private           UnityEngine.InputSystem.InputActionmoveAction  // 0x38
  private           UnityEngine.InputSystem.InputActionspeedAction  // 0x40
  private           UnityEngine.InputSystem.InputActionyMoveAction  // 0x48
  private           System.Single                   inputRotateAxisX  // 0x50
  private           System.Single                   inputRotateAxisY  // 0x54
  private           System.Single                   inputChangeSpeed  // 0x58
  private           System.Single                   inputVertical  // 0x5C
  private           System.Single                   inputHorizontal  // 0x60
  private           System.Single                   inputYAxis  // 0x64
  private           System.Boolean                  leftShiftBoost  // 0x68
  private           System.Boolean                  leftShift  // 0x69
  private           System.Boolean                  fire1  // 0x6A
METHODS:
  System.Void OnEnable()
  System.Void RegisterInputs()
  System.Void UpdateInputs()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.CommandBufferPool
TYPE:  class
TOKEN: 0x2000072
FIELDS:
  private   static  UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.CommandBuffer>s_BufferPool  // 0x0
METHODS:
  UnityEngine.Rendering.CommandBuffer Get()
  UnityEngine.Rendering.CommandBuffer Get(System.String name)
  System.Void Release(UnityEngine.Rendering.CommandBuffer buffer)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.ClearFlag
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ClearFlag None  // 0x0
  public    static  UnityEngine.Rendering.ClearFlag Color  // 0x0
  public    static  UnityEngine.Rendering.ClearFlag Depth  // 0x0
  public    static  UnityEngine.Rendering.ClearFlag Stencil  // 0x0
  public    static  UnityEngine.Rendering.ClearFlag DepthStencil  // 0x0
  public    static  UnityEngine.Rendering.ClearFlag ColorStencil  // 0x0
  public    static  UnityEngine.Rendering.ClearFlag All  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ComponentSingleton`1
TYPE:  class
TOKEN: 0x2000075
FIELDS:
  private   static  TType                           s_Instance  // 0x0
METHODS:
  TType get_instance()
  System.Void Release()
END_CLASS

CLASS: UnityEngine.Rendering.ConstantBuffer
TYPE:  class
TOKEN: 0x2000076
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.Rendering.ConstantBufferBase>m_RegisteredConstantBuffers  // 0x0
METHODS:
  System.Void PushGlobal(UnityEngine.Rendering.CommandBuffer cmd, CBType& data, System.Int32 shaderId)
  System.Void PushGlobal(CBType& data, System.Int32 shaderId)
  System.Void Push(UnityEngine.Rendering.CommandBuffer cmd, CBType& data, UnityEngine.ComputeShader cs, System.Int32 shaderId)
  System.Void Push(CBType& data, UnityEngine.ComputeShader cs, System.Int32 shaderId)
  System.Void Push(UnityEngine.Rendering.CommandBuffer cmd, CBType& data, UnityEngine.Material mat, System.Int32 shaderId)
  System.Void Push(CBType& data, UnityEngine.Material mat, System.Int32 shaderId)
  System.Void UpdateData(UnityEngine.Rendering.CommandBuffer cmd, CBType& data)
  System.Void UpdateData(CBType& data)
  System.Void SetGlobal(UnityEngine.Rendering.CommandBuffer cmd, System.Int32 shaderId)
  System.Void SetGlobal(System.Int32 shaderId)
  System.Void Set(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, System.Int32 shaderId)
  System.Void Set(UnityEngine.ComputeShader cs, System.Int32 shaderId)
  System.Void Set(UnityEngine.Material mat, System.Int32 shaderId)
  System.Void ReleaseAll()
  System.Void Register(UnityEngine.Rendering.ConstantBufferBase cb)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.ConstantBufferBase
TYPE:  class
TOKEN: 0x2000077
FIELDS:
METHODS:
  System.Void Release()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.ConstantBuffer`1
TYPE:  class
TOKEN: 0x2000078
EXTENDS: ConstantBufferBase
FIELDS:
  private           System.Collections.Generic.HashSet<System.Int32>m_GlobalBindings  // 0x0
  private           CBType[]                        m_Data  // 0x0
  private           UnityEngine.ComputeBuffer       m_GPUConstantBuffer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void UpdateData(UnityEngine.Rendering.CommandBuffer cmd, CBType& data)
  System.Void UpdateData(CBType& data)
  System.Void SetGlobal(UnityEngine.Rendering.CommandBuffer cmd, System.Int32 shaderId)
  System.Void SetGlobal(System.Int32 shaderId)
  System.Void Set(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, System.Int32 shaderId)
  System.Void Set(UnityEngine.ComputeShader cs, System.Int32 shaderId)
  System.Void Set(UnityEngine.Material mat, System.Int32 shaderId)
  System.Void PushGlobal(UnityEngine.Rendering.CommandBuffer cmd, CBType& data, System.Int32 shaderId)
  System.Void PushGlobal(CBType& data, System.Int32 shaderId)
  System.Void Release()
END_CLASS

CLASS: UnityEngine.Rendering.ConstantBufferSingleton`1
TYPE:  class
TOKEN: 0x2000079
EXTENDS: ConstantBuffer`1
FIELDS:
  private   static  UnityEngine.Rendering.ConstantBufferSingleton<CBType>s_Instance  // 0x0
METHODS:
  UnityEngine.Rendering.ConstantBufferSingleton<CBType> get_instance()
  System.Void set_instance(UnityEngine.Rendering.ConstantBufferSingleton<CBType> value)
  System.Void Release()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.DisplayInfoAttribute
TYPE:  class
TOKEN: 0x200007A
EXTENDS: Attribute
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Int32                    order  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.AdditionalPropertyAttribute
TYPE:  class
TOKEN: 0x200007B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.CoreProfileId
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.CoreProfileIdBlitTextureInPotAtlas  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.CoreUnsafeUtils
TYPE:  class
TOKEN: 0x200007D
FIELDS:
METHODS:
  System.Void CopyTo(System.Collections.Generic.List<T> list, System.Void* dest, System.Int32 count)
  System.Void CopyTo(T[] list, System.Void* dest, System.Int32 count)
  System.Void CalculateRadixParams(System.Int32 radixBits, System.Int32& bitStates)
  System.Int32 CalculateRadixSupportSize(System.Int32 bitStates, System.Int32 arrayLength)
  System.Void CalculateRadixSortSupportArrays(System.Int32 bitStates, System.Int32 arrayLength, System.UInt32* supportArray, System.UInt32*& bucketIndices, System.UInt32*& bucketSizes, System.UInt32*& bucketPrefix, System.UInt32*& arrayOutput)
  System.Void MergeSort(System.UInt32* array, System.UInt32* support, System.Int32 length)
  System.Void MergeSort(System.UInt32[] arr, System.Int32 sortSize, System.UInt32[]& supportArray)
  System.Void MergeSort(Unity.Collections.NativeArray<System.UInt32> arr, Unity.Collections.Allocator arrAllocator, System.Int32 sortSize, Unity.Collections.NativeArray<System.UInt32>& supportArray)
  System.Void InsertionSort(System.UInt32* arr, System.Int32 length)
  System.Void InsertionSort(System.UInt32[] arr, System.Int32 sortSize)
  System.Void InsertionSort(Unity.Collections.NativeArray<System.UInt32> arr, System.Int32 sortSize)
  System.Void RadixSort(System.UInt32* array, System.UInt32* support, System.Int32 radixBits, System.Int32 bitStates, System.Int32 length)
  System.Void RadixSort(System.UInt32[] arr, System.Int32 sortSize, System.UInt32[]& supportArray, System.Int32 radixBits)
  System.Void RadixSort(Unity.Collections.NativeArray<System.UInt32> array, System.Int32 sortSize, Unity.Collections.NativeArray<System.UInt32>& supportArray, Unity.Collections.Allocator supportArrayAllocator, System.Int32 radixBits)
  System.Void QuickSort(System.UInt32[] arr, System.Int32 left, System.Int32 right)
  System.Void QuickSort(System.Int32 count, System.Void* data)
  System.Void QuickSort(System.Int32 count, System.Void* data)
  System.Void QuickSort(System.Void* data, System.Int32 left, System.Int32 right)
  System.Int32 IndexOf(System.Void* data, System.Int32 count, T v)
  System.Int32 CompareHashes(System.Int32 oldHashCount, System.Void* oldHashes, System.Int32 newHashCount, System.Void* newHashes, System.Int32* addIndices, System.Int32* removeIndices, System.Int32& addCount, System.Int32& remCount)
  System.Int32 CompareHashes(System.Int32 oldHashCount, UnityEngine.Hash128* oldHashes, System.Int32 newHashCount, UnityEngine.Hash128* newHashes, System.Int32* addIndices, System.Int32* removeIndices, System.Int32& addCount, System.Int32& remCount)
  System.Void CombineHashes(System.Int32 count, System.Void* hashes, UnityEngine.Hash128* outHash)
  System.Void CombineHashes(System.Int32 count, UnityEngine.Hash128* hashes, UnityEngine.Hash128* outHash)
  System.Int32 Partition(System.Void* data, System.Int32 left, System.Int32 right)
  System.Boolean HaveDuplicates(System.Int32[] arr)
END_CLASS

CLASS: UnityEngine.Rendering.DynamicArray`1
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private           T[]                             m_Array  // 0x0
  private           System.Int32                    <size>k__BackingField  // 0x0
METHODS:
  System.Int32 get_size()
  System.Void set_size(System.Int32 value)
  System.Int32 get_capacity()
  System.Void .ctor()
  System.Void .ctor(System.Int32 size)
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Int32 Add(T& value)
  System.Void AddRange(UnityEngine.Rendering.DynamicArray<T> array)
  System.Boolean Remove(T item)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveRange(System.Int32 index, System.Int32 count)
  System.Int32 FindIndex(System.Int32 startIndex, System.Int32 count, System.Predicate<T> match)
  System.Int32 IndexOf(T item, System.Int32 index, System.Int32 count)
  System.Int32 IndexOf(T item, System.Int32 index)
  System.Int32 IndexOf(T item)
  System.Void Resize(System.Int32 newSize, System.Boolean keepContent)
  System.Void Reserve(System.Int32 newCapacity, System.Boolean keepContent)
  T& get_Item(System.Int32 index)
  T[] op_Implicit(UnityEngine.Rendering.DynamicArray<T> array)
END_CLASS

CLASS: UnityEngine.Rendering.DynamicArrayExtensions
TYPE:  class
TOKEN: 0x2000083
FIELDS:
METHODS:
  System.Int32 Partition(T[] data, System.Int32 left, System.Int32 right)
  System.Void QuickSort(T[] data, System.Int32 left, System.Int32 right)
  System.Void QuickSort(UnityEngine.Rendering.DynamicArray<T> array)
END_CLASS

CLASS: UnityEngine.Rendering.PerformDynamicRes
TYPE:  class
TOKEN: 0x2000084
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Single Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Single EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UnityEngine.Rendering.DynamicResScalePolicyType
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DynamicResScalePolicyTypeReturnsPercentage  // 0x0
  public    static  UnityEngine.Rendering.DynamicResScalePolicyTypeReturnsMinMaxLerpFactor  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.DynamicResScalerSlot
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DynamicResScalerSlotUser  // 0x0
  public    static  UnityEngine.Rendering.DynamicResScalerSlotSystem  // 0x0
  public    static  UnityEngine.Rendering.DynamicResScalerSlotCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.DynamicResolutionHandler
TYPE:  class
TOKEN: 0x2000087
FIELDS:
  private           System.Boolean                  m_Enabled  // 0x10
  private           System.Boolean                  m_UseMipBias  // 0x11
  private           System.Single                   m_MinScreenFraction  // 0x14
  private           System.Single                   m_MaxScreenFraction  // 0x18
  private           System.Single                   m_CurrentFraction  // 0x1C
  private           System.Boolean                  m_ForcingRes  // 0x20
  private           System.Boolean                  m_CurrentCameraRequest  // 0x21
  private           System.Single                   m_PrevFraction  // 0x24
  private           System.Boolean                  m_ForceSoftwareFallback  // 0x28
  private           System.Boolean                  m_RunUpscalerFilterOnFullResolution  // 0x29
  private           System.Single                   m_PrevHWScaleWidth  // 0x2C
  private           System.Single                   m_PrevHWScaleHeight  // 0x30
  private           UnityEngine.Vector2Int          m_LastScaledSize  // 0x34
  private   static  UnityEngine.Rendering.DynamicResScalerSlots_ActiveScalerSlot  // 0x0
  private   static  UnityEngine.Rendering.DynamicResolutionHandler.ScalerContainer[]s_ScalerContainers  // 0x8
  private           UnityEngine.Vector2Int          cachedOriginalSize  // 0x3C
  private           UnityEngine.Rendering.DynamicResUpscaleFilter<filter>k__BackingField  // 0x44
  private   static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Rendering.DynamicResUpscaleFilter>s_CameraUpscaleFilters  // 0x10
  private           UnityEngine.Vector2Int          <finalViewport>k__BackingField  // 0x48
  private           UnityEngine.Rendering.DynamicResolutionTypetype  // 0x50
  private           UnityEngine.Rendering.GlobalDynamicResolutionSettingsm_CachedSettings  // 0x54
  private   static  System.Int32                    CameraDictionaryMaxcCapacity  // 0x0
  private           System.WeakReference            m_OwnerCameraWeakRef  // 0x80
  private   static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Rendering.DynamicResolutionHandler>s_CameraInstances  // 0x18
  private   static  UnityEngine.Rendering.DynamicResolutionHandlers_DefaultInstance  // 0x20
  private   static  System.Int32                    s_ActiveCameraId  // 0x28
  private   static  UnityEngine.Rendering.DynamicResolutionHandlers_ActiveInstance  // 0x30
  private   static  System.Boolean                  s_ActiveInstanceDirty  // 0x38
  private   static  System.Single                   s_GlobalHwFraction  // 0x3C
  private   static  System.Boolean                  s_GlobalHwUpresActive  // 0x40
  private           UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleTypem_UpsamplerSchedule  // 0x88
METHODS:
  System.Void Reset()
  UnityEngine.Rendering.DynamicResUpscaleFilter get_filter()
  System.Void set_filter(UnityEngine.Rendering.DynamicResUpscaleFilter value)
  UnityEngine.Vector2Int get_finalViewport()
  System.Void set_finalViewport(UnityEngine.Vector2Int value)
  System.Void set_runUpscalerFilterOnFullResolution(System.Boolean value)
  System.Boolean get_runUpscalerFilterOnFullResolution()
  System.Boolean FlushScalableBufferManagerState()
  UnityEngine.Rendering.DynamicResolutionHandler GetOrCreateDrsInstanceHandler(UnityEngine.Camera camera)
  System.Void set_upsamplerSchedule(UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType value)
  UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType get_upsamplerSchedule()
  UnityEngine.Rendering.DynamicResolutionHandler get_instance()
  System.Void .ctor()
  System.Single DefaultDynamicResMethod()
  System.Void ProcessSettings(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings)
  UnityEngine.Vector2 GetResolvedScale()
  System.Single CalculateMipBias(UnityEngine.Vector2Int inputResolution, UnityEngine.Vector2Int outputResolution, System.Boolean forceApply)
  System.Void SetDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType)
  System.Void SetSystemDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType)
  System.Void SetActiveDynamicScalerSlot(UnityEngine.Rendering.DynamicResScalerSlot slot)
  System.Void ClearSelectedCamera()
  System.Void SetUpscaleFilter(UnityEngine.Camera camera, UnityEngine.Rendering.DynamicResUpscaleFilter filter)
  System.Void SetCurrentCameraRequest(System.Boolean cameraRequest)
  System.Void UpdateAndUseCamera(UnityEngine.Camera camera, System.Nullable<UnityEngine.Rendering.GlobalDynamicResolutionSettings> settings, System.Action OnResolutionChange)
  System.Void Update(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings, System.Action OnResolutionChange)
  System.Boolean SoftwareDynamicResIsEnabled()
  System.Boolean HardwareDynamicResIsEnabled()
  System.Boolean RequestsHardwareDynamicResolution()
  System.Boolean DynamicResolutionEnabled()
  System.Void ForceSoftwareFallback()
  UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int size)
  UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size)
  UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size, UnityEngine.Vector2 scales)
  System.Single GetCurrentScale()
  UnityEngine.Vector2Int GetLastScaledSize()
  System.Single GetLowResMultiplier(System.Single targetLowRes)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.DynamicResolutionType
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.Rendering.DynamicResolutionTypeSoftware  // 0x0
  public    static  UnityEngine.Rendering.DynamicResolutionTypeHardware  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.DynamicResUpscaleFilter
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.Rendering.DynamicResUpscaleFilterBilinear  // 0x0
  public    static  UnityEngine.Rendering.DynamicResUpscaleFilterCatmullRom  // 0x0
  public    static  UnityEngine.Rendering.DynamicResUpscaleFilterLanczos  // 0x0
  public    static  UnityEngine.Rendering.DynamicResUpscaleFilterContrastAdaptiveSharpen  // 0x0
  public    static  UnityEngine.Rendering.DynamicResUpscaleFilterEdgeAdaptiveScalingUpres  // 0x0
  public    static  UnityEngine.Rendering.DynamicResUpscaleFilterTAAU  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.GlobalDynamicResolutionSettings
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Boolean                  enabled  // 0x10
  public            System.Boolean                  useMipBias  // 0x11
  public            System.Boolean                  enableDLSS  // 0x12
  public            System.UInt32                   DLSSPerfQualitySetting  // 0x14
  public            System.Boolean                  DLSSUseOptimalSettings  // 0x18
  public            System.Single                   DLSSSharpness  // 0x1C
  public            System.Single                   maxPercentage  // 0x20
  public            System.Single                   minPercentage  // 0x24
  public            UnityEngine.Rendering.DynamicResolutionTypedynResType  // 0x28
  public            UnityEngine.Rendering.DynamicResUpscaleFilterupsampleFilter  // 0x29
  public            System.Boolean                  forceResolution  // 0x2A
  public            System.Single                   forcedPercentage  // 0x2C
  public            System.Single                   lowResTransparencyMinimumThreshold  // 0x30
  public            System.Single                   rayTracingHalfResThreshold  // 0x34
METHODS:
  UnityEngine.Rendering.GlobalDynamicResolutionSettings NewDefault()
END_CLASS

CLASS: UnityEngine.Rendering.IAdditionalData
TYPE:  interface
TOKEN: 0x200008D
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.IVirtualTexturingEnabledRenderPipeline
TYPE:  interface
TOKEN: 0x200008E
FIELDS:
METHODS:
  System.Boolean get_virtualTexturingEnabled()
END_CLASS

CLASS: UnityEngine.Rendering.ListBuffer`1
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  private           T*                              m_BufferPtr  // 0x0
  private           System.Int32                    m_Capacity  // 0x0
  private           System.Int32*                   m_CountPtr  // 0x0
METHODS:
  T* get_BufferPtr()
  System.Int32 get_Count()
  System.Int32 get_Capacity()
  System.Void .ctor(T* bufferPtr, System.Int32* countPtr, System.Int32 capacity)
  T& get_Item(System.Int32& index)
  T& GetUnchecked(System.Int32& index)
  System.Boolean TryAdd(T& value)
  System.Void CopyTo(T* dstBuffer, System.Int32 startDstIndex, System.Int32 copyCount)
  System.Boolean TryCopyTo(UnityEngine.Rendering.ListBuffer<T> other)
  System.Boolean TryCopyFrom(T* srcPtr, System.Int32 count)
END_CLASS

CLASS: UnityEngine.Rendering.ListBufferExtensions
TYPE:  class
TOKEN: 0x2000090
FIELDS:
METHODS:
  System.Void QuickSort(UnityEngine.Rendering.ListBuffer<T> self)
END_CLASS

CLASS: UnityEngine.Rendering.ObjectPool`1
TYPE:  class
TOKEN: 0x2000091
FIELDS:
  private   readonly System.Collections.Generic.Stack<T>m_Stack  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T>m_ActionOnGet  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T>m_ActionOnRelease  // 0x0
  private   readonly System.Boolean                  m_CollectionCheck  // 0x0
  private           System.Int32                    <countAll>k__BackingField  // 0x0
METHODS:
  System.Int32 get_countAll()
  System.Void set_countAll(System.Int32 value)
  System.Int32 get_countActive()
  System.Int32 get_countInactive()
  System.Void .ctor(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease, System.Boolean collectionCheck)
  T Get()
  UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(T& v)
  System.Void Release(T element)
END_CLASS

CLASS: UnityEngine.Rendering.GenericPool`1
TYPE:  class
TOKEN: 0x2000093
FIELDS:
  private   static readonly UnityEngine.Rendering.ObjectPool<T>s_Pool  // 0x0
METHODS:
  T Get()
  UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(T& value)
  System.Void Release(T toRelease)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.UnsafeGenericPool`1
TYPE:  class
TOKEN: 0x2000094
FIELDS:
  private   static readonly UnityEngine.Rendering.ObjectPool<T>s_Pool  // 0x0
METHODS:
  T Get()
  UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(T& value)
  System.Void Release(T toRelease)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.ListPool`1
TYPE:  class
TOKEN: 0x2000095
FIELDS:
  private   static readonly UnityEngine.Rendering.ObjectPool<System.Collections.Generic.List<T>>s_Pool  // 0x0
METHODS:
  System.Collections.Generic.List<T> Get()
  UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.List<T>> Get(System.Collections.Generic.List<T>& value)
  System.Void Release(System.Collections.Generic.List<T> toRelease)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.HashSetPool`1
TYPE:  class
TOKEN: 0x2000097
FIELDS:
  private   static readonly UnityEngine.Rendering.ObjectPool<System.Collections.Generic.HashSet<T>>s_Pool  // 0x0
METHODS:
  System.Collections.Generic.HashSet<T> Get()
  UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.HashSet<T>> Get(System.Collections.Generic.HashSet<T>& value)
  System.Void Release(System.Collections.Generic.HashSet<T> toRelease)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.DictionaryPool`2
TYPE:  class
TOKEN: 0x2000099
FIELDS:
  private   static readonly UnityEngine.Rendering.ObjectPool<System.Collections.Generic.Dictionary<TKey,TValue>>s_Pool  // 0x0
METHODS:
  System.Collections.Generic.Dictionary<TKey,TValue> Get()
  UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.Dictionary<TKey,TValue>> Get(System.Collections.Generic.Dictionary<TKey,TValue>& value)
  System.Void Release(System.Collections.Generic.Dictionary<TKey,TValue> toRelease)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.ListChangedEventArgs`1
TYPE:  class
TOKEN: 0x200009B
EXTENDS: EventArgs
FIELDS:
  public    readonly System.Int32                    index  // 0x0
  public    readonly T                               item  // 0x0
METHODS:
  System.Void .ctor(System.Int32 index, T item)
END_CLASS

CLASS: UnityEngine.Rendering.ListChangedEventHandler`1
TYPE:  class
TOKEN: 0x200009C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e)
  System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UnityEngine.Rendering.ObservableList`1
TYPE:  class
TOKEN: 0x200009D
FIELDS:
  private           System.Collections.Generic.IList<T>m_List  // 0x0
  private           UnityEngine.Rendering.ListChangedEventHandler<T>ItemAdded  // 0x0
  private           UnityEngine.Rendering.ListChangedEventHandler<T>ItemRemoved  // 0x0
METHODS:
  System.Void add_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value)
  System.Void remove_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value)
  System.Void add_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value)
  System.Void remove_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value)
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Void .ctor()
  System.Void .ctor(System.Int32 capacity)
  System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection)
  System.Void OnEvent(UnityEngine.Rendering.ListChangedEventHandler<T> e, System.Int32 index, T item)
  System.Boolean Contains(T item)
  System.Int32 IndexOf(T item)
  System.Void Add(T item)
  System.Void Add(T[] items)
  System.Void Insert(System.Int32 index, T item)
  System.Boolean Remove(T item)
  System.Int32 Remove(T[] items)
  System.Void RemoveAt(System.Int32 index)
  System.Void Clear()
  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: UnityEngine.Rendering.SerializableEnum
TYPE:  class
TOKEN: 0x200009E
FIELDS:
  private           System.String                   m_EnumValueAsString  // 0x10
  private           System.Type                     m_EnumType  // 0x18
METHODS:
  System.Enum get_value()
  System.Void set_value(System.Enum value)
  System.Void .ctor(System.Type enumType)
END_CLASS

CLASS: UnityEngine.Rendering.SerializedDictionary`2
TYPE:  class
TOKEN: 0x200009F
EXTENDS: SerializedDictionary`4
FIELDS:
METHODS:
  K SerializeKey(K key)
  V SerializeValue(V val)
  K DeserializeKey(K key)
  V DeserializeValue(V val)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.SerializedDictionary`4
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: Dictionary`2
FIELDS:
  private           System.Collections.Generic.List<SK>m_Keys  // 0x0
  private           System.Collections.Generic.List<SV>m_Values  // 0x0
METHODS:
  SK SerializeKey(K key)
  SV SerializeValue(V value)
  K DeserializeKey(SK serializedKey)
  V DeserializeValue(SV serializedValue)
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.XRGraphics
TYPE:  class
TOKEN: 0x20000A1
FIELDS:
METHODS:
  System.Single get_eyeTextureResolutionScale()
  System.Void set_eyeTextureResolutionScale(System.Single value)
  System.Single get_renderViewportScale()
  System.Boolean get_enabled()
  System.Boolean get_isDeviceActive()
  System.String get_loadedDeviceName()
  System.String[] get_supportedDevices()
  UnityEngine.Rendering.XRGraphics.StereoRenderingMode get_stereoRenderingMode()
  UnityEngine.RenderTextureDescriptor get_eyeTextureDesc()
  System.Int32 get_eyeTextureWidth()
  System.Int32 get_eyeTextureHeight()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.DebugAction
TYPE:  struct
TOKEN: 0x20000A3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DebugActionEnableDebugMenu  // 0x0
  public    static  UnityEngine.Rendering.DebugActionPreviousDebugPanel  // 0x0
  public    static  UnityEngine.Rendering.DebugActionNextDebugPanel  // 0x0
  public    static  UnityEngine.Rendering.DebugActionAction  // 0x0
  public    static  UnityEngine.Rendering.DebugActionMakePersistent  // 0x0
  public    static  UnityEngine.Rendering.DebugActionMoveVertical  // 0x0
  public    static  UnityEngine.Rendering.DebugActionMoveHorizontal  // 0x0
  public    static  UnityEngine.Rendering.DebugActionMultiplier  // 0x0
  public    static  UnityEngine.Rendering.DebugActionResetAll  // 0x0
  public    static  UnityEngine.Rendering.DebugActionDebugActionCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.DebugActionRepeatMode
TYPE:  struct
TOKEN: 0x20000A4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DebugActionRepeatModeNever  // 0x0
  public    static  UnityEngine.Rendering.DebugActionRepeatModeDelay  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.DebugManager
TYPE:  class
TOKEN: 0x20000A5
FIELDS:
  private   static  System.String                   kEnableDebugBtn1  // 0x0
  private   static  System.String                   kEnableDebugBtn2  // 0x0
  private   static  System.String                   kDebugPreviousBtn  // 0x0
  private   static  System.String                   kDebugNextBtn  // 0x0
  private   static  System.String                   kValidateBtn  // 0x0
  private   static  System.String                   kPersistentBtn  // 0x0
  private   static  System.String                   kDPadVertical  // 0x0
  private   static  System.String                   kDPadHorizontal  // 0x0
  private   static  System.String                   kMultiplierBtn  // 0x0
  private   static  System.String                   kResetBtn  // 0x0
  private   static  System.String                   kEnableDebug  // 0x0
  private           UnityEngine.Rendering.DebugActionDesc[]m_DebugActions  // 0x10
  private           UnityEngine.Rendering.DebugActionState[]m_DebugActionStates  // 0x18
  private           UnityEngine.InputSystem.InputActionMapdebugActionMap  // 0x20
  private   static readonly System.Lazy<UnityEngine.Rendering.DebugManager>s_Instance  // 0x0
  private           System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel>m_ReadOnlyPanels  // 0x28
  private   readonly System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Panel>m_Panels  // 0x30
  private           System.Action<System.Boolean>   onDisplayRuntimeUIChanged  // 0x38
  private           System.Action                   onSetDirty  // 0x40
  private           System.Action                   resetData  // 0x48
  public            System.Boolean                  refreshEditorRequested  // 0x50
  private           System.Nullable<System.Int32>   m_RequestedPanelIndex  // 0x54
  private           UnityEngine.GameObject          m_Root  // 0x60
  private           UnityEngine.Rendering.UI.DebugUIHandlerCanvasm_RootUICanvas  // 0x68
  private           UnityEngine.GameObject          m_PersistentRoot  // 0x70
  private           UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvasm_RootUIPersistentCanvas  // 0x78
  private           System.Boolean                  m_EditorOpen  // 0x80
  private           System.Boolean                  m_EnableRuntimeUI  // 0x81
METHODS:
  System.Void RegisterActions()
  System.Void EnableInputActions()
  System.Void AddAction(UnityEngine.Rendering.DebugAction action, UnityEngine.Rendering.DebugActionDesc desc)
  System.Void SampleAction(System.Int32 actionIndex)
  System.Void UpdateAction(System.Int32 actionIndex)
  System.Void UpdateActions()
  System.Single GetAction(UnityEngine.Rendering.DebugAction action)
  System.Boolean GetActionToggleDebugMenuWithTouch()
  System.Boolean GetActionReleaseScrollTarget()
  System.Void RegisterInputs()
  UnityEngine.Rendering.DebugManager get_instance()
  System.Void UpdateReadOnlyCollection()
  System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> get_panels()
  System.Void add_onDisplayRuntimeUIChanged(System.Action<System.Boolean> value)
  System.Void remove_onDisplayRuntimeUIChanged(System.Action<System.Boolean> value)
  System.Void add_onSetDirty(System.Action value)
  System.Void remove_onSetDirty(System.Action value)
  System.Void add_resetData(System.Action value)
  System.Void remove_resetData(System.Action value)
  System.Boolean get_displayEditorUI()
  System.Void ToggleEditorUI(System.Boolean open)
  System.Boolean get_enableRuntimeUI()
  System.Void set_enableRuntimeUI(System.Boolean value)
  System.Boolean get_displayRuntimeUI()
  System.Void set_displayRuntimeUI(System.Boolean value)
  System.Boolean get_displayPersistentRuntimeUI()
  System.Void set_displayPersistentRuntimeUI(System.Boolean value)
  System.Void .ctor()
  System.Void RefreshEditor()
  System.Void Reset()
  System.Void ReDrawOnScreenDebug()
  System.Void RegisterData(UnityEngine.Rendering.IDebugData data)
  System.Void UnregisterData(UnityEngine.Rendering.IDebugData data)
  System.Int32 GetState()
  System.Void RegisterRootCanvas(UnityEngine.Rendering.UI.DebugUIHandlerCanvas root)
  System.Void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, System.Boolean fromNext)
  System.Void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget)
  System.Void EnsurePersistentCanvas()
  System.Void TogglePersistent(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Void OnPanelDirty(UnityEngine.Rendering.DebugUI.Panel panel)
  System.Void RequestEditorWindowPanelIndex(System.Int32 index)
  System.Nullable<System.Int32> GetRequestedEditorWindowPanelIndex()
  UnityEngine.Rendering.DebugUI.Panel GetPanel(System.String displayName, System.Boolean createIfNull, System.Int32 groupIndex, System.Boolean overrideIfExist)
  System.Void RemovePanel(System.String displayName)
  System.Void RemovePanel(UnityEngine.Rendering.DebugUI.Panel panel)
  UnityEngine.Rendering.DebugUI.Widget GetItem(System.String queryPath)
  UnityEngine.Rendering.DebugUI.Widget GetItem(System.String queryPath, UnityEngine.Rendering.DebugUI.IContainer container)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.DebugActionDesc
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
  public            UnityEngine.InputSystem.InputActionbuttonAction  // 0x10
  public            UnityEngine.Rendering.DebugActionRepeatModerepeatMode  // 0x18
  public            System.Single                   repeatDelay  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.DebugActionState
TYPE:  class
TOKEN: 0x20000A8
FIELDS:
  private           UnityEngine.Rendering.DebugActionState.DebugActionKeyTypem_Type  // 0x10
  private           UnityEngine.InputSystem.InputActioninputAction  // 0x18
  private           System.Boolean[]                m_TriggerPressedUp  // 0x20
  private           System.Single                   m_Timer  // 0x28
  private           System.Boolean                  <runningAction>k__BackingField  // 0x2C
  private           System.Single                   <actionState>k__BackingField  // 0x30
METHODS:
  System.Boolean get_runningAction()
  System.Void set_runningAction(System.Boolean value)
  System.Single get_actionState()
  System.Void set_actionState(System.Single value)
  System.Void Trigger(System.Int32 triggerCount, System.Single state)
  System.Void TriggerWithButton(UnityEngine.InputSystem.InputAction action, System.Single state)
  System.Void Reset()
  System.Void Update(UnityEngine.Rendering.DebugActionDesc desc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.IDebugData
TYPE:  interface
TOKEN: 0x20000AA
FIELDS:
METHODS:
  System.Action GetReset()
END_CLASS

CLASS: UnityEngine.Rendering.DebugShapes
TYPE:  class
TOKEN: 0x20000AB
FIELDS:
  private   static  UnityEngine.Rendering.DebugShapess_Instance  // 0x0
  private           UnityEngine.Mesh                m_sphereMesh  // 0x10
  private           UnityEngine.Mesh                m_boxMesh  // 0x18
  private           UnityEngine.Mesh                m_coneMesh  // 0x20
  private           UnityEngine.Mesh                m_pyramidMesh  // 0x28
METHODS:
  UnityEngine.Rendering.DebugShapes get_instance()
  System.Void BuildSphere(UnityEngine.Mesh& outputMesh, System.Single radius, System.UInt32 longSubdiv, System.UInt32 latSubdiv)
  System.Void BuildBox(UnityEngine.Mesh& outputMesh, System.Single length, System.Single width, System.Single height)
  System.Void BuildCone(UnityEngine.Mesh& outputMesh, System.Single height, System.Single topRadius, System.Single bottomRadius, System.Int32 nbSides)
  System.Void BuildPyramid(UnityEngine.Mesh& outputMesh, System.Single width, System.Single height, System.Single depth)
  System.Void BuildShapes()
  System.Void RebuildResources()
  UnityEngine.Mesh RequestSphereMesh()
  UnityEngine.Mesh RequestBoxMesh()
  UnityEngine.Mesh RequestConeMesh()
  UnityEngine.Mesh RequestPyramidMesh()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.DebugUI
TYPE:  class
TOKEN: 0x20000AC
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.DebugUpdater
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: MonoBehaviour
FIELDS:
  private   static  UnityEngine.Rendering.DebugUpdaters_Instance  // 0x0
  private           UnityEngine.ScreenOrientation   m_Orientation  // 0x18
  private           System.Boolean                  m_RuntimeUiWasVisibleLastFrame  // 0x1C
METHODS:
  System.Void RuntimeInit()
  System.Void SetEnabled(System.Boolean enabled)
  System.Void EnableRuntime()
  System.Void DisableRuntime()
  System.Void HandleInternalEventSystemComponents(System.Boolean uiEnabled)
  System.Void EnsureExactlyOneEventSystem()
  System.Collections.IEnumerator DoAfterInputModuleUpdated(System.Action action)
  System.Void CheckInputModuleExists()
  System.Void AssignDefaultActions()
  System.Void CreateDebugEventSystem()
  System.Void DestroyDebugEventSystem()
  System.Void Update()
  System.Collections.IEnumerator RefreshRuntimeUINextFrame()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.MousePositionDebug
TYPE:  class
TOKEN: 0x20000D2
FIELDS:
  private   static  UnityEngine.Rendering.MousePositionDebugs_Instance  // 0x0
METHODS:
  UnityEngine.Rendering.MousePositionDebug get_instance()
  System.Void Build()
  System.Void Cleanup()
  UnityEngine.Vector2 GetMousePosition(System.Single ScreenHeight, System.Boolean sceneView)
  UnityEngine.Vector2 GetInputMousePosition()
  UnityEngine.Vector2 GetMouseClickPosition(System.Single ScreenHeight)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.TProfilingSampler`1
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: ProfilingSampler
FIELDS:
  private   static  System.Collections.Generic.Dictionary<TEnum,UnityEngine.Rendering.TProfilingSampler<TEnum>>samples  // 0x0
METHODS:
  System.Void .cctor()
  System.Void .ctor(System.String name)
END_CLASS

CLASS: UnityEngine.Rendering.ProfilingSampler
TYPE:  class
TOKEN: 0x20000D4
FIELDS:
  private           UnityEngine.Profiling.CustomSampler<sampler>k__BackingField  // 0x10
  private           UnityEngine.Profiling.CustomSampler<inlineSampler>k__BackingField  // 0x18
  private           System.String                   <name>k__BackingField  // 0x20
  private           UnityEngine.Profiling.Recorder  m_Recorder  // 0x28
  private           UnityEngine.Profiling.Recorder  m_InlineRecorder  // 0x30
METHODS:
  UnityEngine.Rendering.ProfilingSampler Get(TEnum marker)
  System.Void .ctor(System.String name)
  System.Void Begin(UnityEngine.Rendering.CommandBuffer cmd)
  System.Void End(UnityEngine.Rendering.CommandBuffer cmd)
  System.Boolean IsValid()
  UnityEngine.Profiling.CustomSampler get_sampler()
  System.Void set_sampler(UnityEngine.Profiling.CustomSampler value)
  UnityEngine.Profiling.CustomSampler get_inlineSampler()
  System.Void set_inlineSampler(UnityEngine.Profiling.CustomSampler value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Void set_enableRecording(System.Boolean value)
  System.Single get_gpuElapsedTime()
  System.Int32 get_gpuSampleCount()
  System.Single get_cpuElapsedTime()
  System.Int32 get_cpuSampleCount()
  System.Single get_inlineCpuElapsedTime()
  System.Int32 get_inlineCpuSampleCount()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.ProfilingScope
TYPE:  struct
TOKEN: 0x20000D5
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler)
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.Rendering.ProfilingSample
TYPE:  struct
TOKEN: 0x20000D6
FIELDS:
  private   readonly UnityEngine.Rendering.CommandBufferm_Cmd  // 0x10
  private   readonly System.String                   m_Name  // 0x18
  private           System.Boolean                  m_Disposed  // 0x20
  private           UnityEngine.Profiling.CustomSamplerm_Sampler  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.Rendering.CommandBuffer cmd, System.String name, UnityEngine.Profiling.CustomSampler sampler)
  System.Void .ctor(UnityEngine.Rendering.CommandBuffer cmd, System.String format, System.Object arg)
  System.Void .ctor(UnityEngine.Rendering.CommandBuffer cmd, System.String format, System.Object[] args)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: UnityEngine.Rendering.CoreRPHelpURLAttribute
TYPE:  class
TOKEN: 0x20000D7
EXTENDS: HelpURLAttribute
FIELDS:
METHODS:
  System.Void .ctor(System.String pageName, System.String packageName)
END_CLASS

CLASS: UnityEngine.Rendering.DocumentationInfo
TYPE:  class
TOKEN: 0x20000D8
FIELDS:
  private   static  System.String                   fallbackVersion  // 0x0
  private   static  System.String                   url  // 0x0
METHODS:
  System.String get_version()
  System.String GetPageLink(System.String packageName, System.String pageName)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.DocumentationUtils
TYPE:  class
TOKEN: 0x20000D9
FIELDS:
METHODS:
  System.String GetHelpURL(TEnum mask)
END_CLASS

CLASS: UnityEngine.Rendering.APVConstantBufferRegister
TYPE:  struct
TOKEN: 0x20000DA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.APVConstantBufferRegisterGlobalRegister  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ShaderVariablesProbeVolumes
TYPE:  struct
TOKEN: 0x20000DB
FIELDS:
  public            UnityEngine.Vector3             _PoolDim  // 0x10
  public            System.Single                   _ViewBias  // 0x1C
  public            UnityEngine.Vector3             _MinCellPosition  // 0x20
  public            System.Single                   _PVSamplingNoise  // 0x2C
  public            UnityEngine.Vector3             _CellIndicesDim  // 0x30
  public            System.Single                   _CellInMeters  // 0x3C
  public            System.Single                   _CellInMinBricks  // 0x40
  public            System.Single                   _MinBrickSize  // 0x44
  public            System.Int32                    _IndexChunkSize  // 0x48
  public            System.Single                   _NormalBias  // 0x4C
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.SphericalHarmonicsL1
TYPE:  struct
TOKEN: 0x20000DC
FIELDS:
  public            UnityEngine.Vector4             shAr  // 0x10
  public            UnityEngine.Vector4             shAg  // 0x20
  public            UnityEngine.Vector4             shAb  // 0x30
  public    static readonly UnityEngine.Rendering.SphericalHarmonicsL1zero  // 0x0
METHODS:
  UnityEngine.Rendering.SphericalHarmonicsL1 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs)
  UnityEngine.Rendering.SphericalHarmonicsL1 op_Subtraction(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs)
  UnityEngine.Rendering.SphericalHarmonicsL1 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, System.Single rhs)
  UnityEngine.Rendering.SphericalHarmonicsL1 op_Division(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, System.Single rhs)
  System.Boolean op_Equality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs)
  System.Boolean op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs)
  System.Boolean Equals(System.Object other)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.SphericalHarmonicsL2Utils
TYPE:  class
TOKEN: 0x20000DD
FIELDS:
METHODS:
  System.Void GetL1(UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3& L1_R, UnityEngine.Vector3& L1_G, UnityEngine.Vector3& L1_B)
  System.Void GetL2(UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3& L2_0, UnityEngine.Vector3& L2_1, UnityEngine.Vector3& L2_2, UnityEngine.Vector3& L2_3, UnityEngine.Vector3& L2_4)
  System.Void SetL0(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L0)
  System.Void SetL1R(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L1_R)
  System.Void SetL1G(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L1_G)
  System.Void SetL1B(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L1_B)
  System.Void SetL1(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L1_R, UnityEngine.Vector3 L1_G, UnityEngine.Vector3 L1_B)
  System.Void SetCoefficient(UnityEngine.Rendering.SphericalHarmonicsL2& sh, System.Int32 index, UnityEngine.Vector3 coefficient)
  UnityEngine.Vector3 GetCoefficient(UnityEngine.Rendering.SphericalHarmonicsL2 sh, System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.LensFlareCommonSRP
TYPE:  class
TOKEN: 0x20000DE
FIELDS:
  private   static  UnityEngine.Rendering.LensFlareCommonSRPm_Instance  // 0x0
  private   static readonly System.Object                   m_Padlock  // 0x8
  private   static  System.Collections.Generic.List<UnityEngine.Rendering.LensFlareComponentSRP>m_Data  // 0x10
  public    static  System.Int32                    maxLensFlareWithOcclusion  // 0x18
  public    static  System.Int32                    maxLensFlareWithOcclusionTemporalSample  // 0x1C
  public    static  System.Int32                    mergeNeeded  // 0x20
  public    static  UnityEngine.Rendering.RTHandle  occlusionRT  // 0x28
  private   static  System.Int32                    frameIdx  // 0x30
METHODS:
  System.Void .ctor()
  System.Void Initialize()
  System.Void Dispose()
  UnityEngine.Rendering.LensFlareCommonSRP get_Instance()
  System.Collections.Generic.List<UnityEngine.Rendering.LensFlareComponentSRP> get_Data()
  System.Collections.Generic.List<UnityEngine.Rendering.LensFlareComponentSRP> GetData()
  System.Boolean IsEmpty()
  System.Void AddData(UnityEngine.Rendering.LensFlareComponentSRP newData)
  System.Single ShapeAttenuationPointLight()
  System.Single ShapeAttenuationDirLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo)
  System.Single ShapeAttenuationSpotConeLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo, System.Single spotAngle, System.Single innerSpotPercent01)
  System.Single ShapeAttenuationSpotBoxLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo)
  System.Single ShapeAttenuationSpotPyramidLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo)
  System.Single ShapeAttenuationAreaTubeLight(UnityEngine.Vector3 lightPositionWS, UnityEngine.Vector3 lightSide, System.Single lightWidth, UnityEngine.Camera cam)
  System.Single ShapeAttenuationAreaRectangleLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo)
  System.Single ShapeAttenuationAreaDiscLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo)
  UnityEngine.Vector4 GetFlareData0(UnityEngine.Vector2 screenPos, UnityEngine.Vector2 translationScale, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 vLocalScreenRatio, System.Single angleDeg, System.Single position, System.Single angularOffset, UnityEngine.Vector2 positionOffset, System.Boolean autoRotate)
  UnityEngine.Vector2 GetLensFlareRayOffset(UnityEngine.Vector2 screenPos, System.Single position, System.Single globalCos0, System.Single globalSin0)
  UnityEngine.Vector3 WorldToViewport(UnityEngine.Camera camera, System.Boolean isLocalLight, System.Boolean isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 positionWS)
  UnityEngine.Vector3 WorldToViewportLocal(System.Boolean isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 cameraPosWS, UnityEngine.Vector3 positionWS)
  UnityEngine.Vector3 WorldToViewportDistance(UnityEngine.Camera cam, UnityEngine.Vector3 positionWS)
  System.Void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Rendering.LensFlareCommonSRP lensFlares, UnityEngine.Camera cam, System.Single actualWidth, System.Single actualHeight, System.Boolean usePanini, System.Single paniniDistance, System.Single paniniCropToFit, System.Boolean isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, System.Boolean taaEnabled, System.Int32 _FlareOcclusionTex, System.Int32 _FlareOcclusionIndex, System.Int32 _FlareTex, System.Int32 _FlareColorValue, System.Int32 _FlareData0, System.Int32 _FlareData1, System.Int32 _FlareData2, System.Int32 _FlareData3, System.Int32 _FlareData4)
  System.Void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Rendering.LensFlareCommonSRP lensFlares, UnityEngine.Camera cam, System.Single actualWidth, System.Single actualHeight, System.Boolean usePanini, System.Single paniniDistance, System.Single paniniCropToFit, System.Boolean isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light,UnityEngine.Camera,UnityEngine.Vector3,System.Single> GetLensFlareLightAttenuation, System.Int32 _FlareOcclusionTex, System.Int32 _FlareOcclusionIndex, System.Int32 _FlareTex, System.Int32 _FlareColorValue, System.Int32 _FlareData0, System.Int32 _FlareData1, System.Int32 _FlareData2, System.Int32 _FlareData3, System.Int32 _FlareData4, System.Boolean debugFullScreen, UnityEngine.ComputeBuffer debugFullscreenBuffer, UnityEngine.Rendering.LensFlareCommonSRP.SunSourceDirLightOverrideInfo dirLightOverrideInfo)
  System.Void RemoveData(UnityEngine.Rendering.LensFlareComponentSRP data)
  UnityEngine.Vector2 DoPaniniProjection(UnityEngine.Vector2 screenPos, System.Single actualWidth, System.Single actualHeight, System.Single fieldOfView, System.Single paniniProjectionCropToFit, System.Single paniniProjectionDistance)
  UnityEngine.Vector2 CalcViewExtents(System.Single actualWidth, System.Single actualHeight, System.Single fieldOfView)
  UnityEngine.Vector2 CalcCropExtents(System.Single actualWidth, System.Single actualHeight, System.Single fieldOfView, System.Single d)
  UnityEngine.Vector2 Panini_Generic_Inv(UnityEngine.Vector2 projPos, System.Single d)
  System.Void .cctor()
  System.Single <ShapeAttenuationAreaTubeLight>g__Fpo|26_0(System.Single d, System.Single l)
  System.Single <ShapeAttenuationAreaTubeLight>g__Fwt|26_1(System.Single d, System.Single l)
  System.Single <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|26_2(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
  UnityEngine.Vector2 <DoLensFlareDataDrivenCommon>g__ComputeLocalSize|35_0(UnityEngine.Vector2 rayOff, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 curSize, UnityEngine.AnimationCurve distortionCurve, UnityEngine.Rendering.LensFlareCommonSRP.<>c__DisplayClass35_0& , UnityEngine.Rendering.LensFlareCommonSRP.<>c__DisplayClass35_1& )
  System.Single <DoLensFlareDataDrivenCommon>g__RandomRange|35_1(System.Single min, System.Single max)
END_CLASS

CLASS: UnityEngine.Rendering.LensFlareComponentSRP
TYPE:  class
TOKEN: 0x20000E4
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Rendering.LensFlareDataSRPm_LensFlareData  // 0x18
  public            System.Single                   intensity  // 0x20
  public            System.Single                   maxAttenuationDistance  // 0x24
  public            System.Single                   maxAttenuationScale  // 0x28
  public            UnityEngine.AnimationCurve      distanceAttenuationCurve  // 0x30
  public            UnityEngine.AnimationCurve      scaleByDistanceCurve  // 0x38
  public            System.Boolean                  attenuationByLightShape  // 0x40
  public            UnityEngine.AnimationCurve      radialScreenAttenuationCurve  // 0x48
  public            System.Boolean                  useOcclusion  // 0x50
  public            System.Single                   occlusionRadius  // 0x54
  public            System.UInt32                   sampleCount  // 0x58
  public            System.Single                   occlusionOffset  // 0x5C
  public            System.Single                   scale  // 0x60
  public            System.Boolean                  allowOffScreen  // 0x64
  public            System.Boolean                  useCustomForward  // 0x65
  public            UnityEngine.Vector3             customForward  // 0x68
  private   static  System.Single                   sCelestialAngularRadius  // 0x0
METHODS:
  UnityEngine.Rendering.LensFlareDataSRP get_lensFlareData()
  System.Void set_lensFlareData(UnityEngine.Rendering.LensFlareDataSRP value)
  System.Single celestialProjectedOcclusionRadius(UnityEngine.Camera mainCam)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnValidate()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.SRPLensFlareBlendMode
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.SRPLensFlareBlendModeAdditive  // 0x0
  public    static  UnityEngine.Rendering.SRPLensFlareBlendModeScreen  // 0x0
  public    static  UnityEngine.Rendering.SRPLensFlareBlendModePremultiply  // 0x0
  public    static  UnityEngine.Rendering.SRPLensFlareBlendModeLerp  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.SRPLensFlareDistribution
TYPE:  struct
TOKEN: 0x20000E6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.SRPLensFlareDistributionUniform  // 0x0
  public    static  UnityEngine.Rendering.SRPLensFlareDistributionCurve  // 0x0
  public    static  UnityEngine.Rendering.SRPLensFlareDistributionRandom  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.SRPLensFlareType
TYPE:  struct
TOKEN: 0x20000E7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.SRPLensFlareTypeImage  // 0x0
  public    static  UnityEngine.Rendering.SRPLensFlareTypeCircle  // 0x0
  public    static  UnityEngine.Rendering.SRPLensFlareTypePolygon  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.LensFlareDataElementSRP
TYPE:  class
TOKEN: 0x20000E8
FIELDS:
  public            System.Boolean                  visible  // 0x10
  public            System.Single                   position  // 0x14
  public            UnityEngine.Vector2             positionOffset  // 0x18
  public            System.Single                   angularOffset  // 0x20
  public            UnityEngine.Vector2             translationScale  // 0x24
  private           System.Single                   m_LocalIntensity  // 0x2C
  public            UnityEngine.Texture             lensFlareTexture  // 0x30
  public            System.Single                   uniformScale  // 0x38
  public            UnityEngine.Vector2             sizeXY  // 0x3C
  public            System.Boolean                  allowMultipleElement  // 0x44
  private           System.Int32                    m_Count  // 0x48
  public            System.Boolean                  preserveAspectRatio  // 0x4C
  public            System.Single                   rotation  // 0x50
  public            UnityEngine.Color               tint  // 0x54
  public            UnityEngine.Rendering.SRPLensFlareBlendModeblendMode  // 0x64
  public            System.Boolean                  autoRotate  // 0x68
  public            UnityEngine.Rendering.SRPLensFlareTypeflareType  // 0x6C
  public            System.Boolean                  modulateByLightColor  // 0x70
  private           System.Boolean                  isFoldOpened  // 0x71
  public            UnityEngine.Rendering.SRPLensFlareDistributiondistribution  // 0x74
  public            System.Single                   lengthSpread  // 0x78
  public            UnityEngine.AnimationCurve      positionCurve  // 0x80
  public            UnityEngine.AnimationCurve      scaleCurve  // 0x88
  public            System.Int32                    seed  // 0x90
  public            UnityEngine.Gradient            colorGradient  // 0x98
  private           System.Single                   m_IntensityVariation  // 0xA0
  public            UnityEngine.Vector2             positionVariation  // 0xA4
  public            System.Single                   scaleVariation  // 0xAC
  public            System.Single                   rotationVariation  // 0xB0
  public            System.Boolean                  enableRadialDistortion  // 0xB4
  public            UnityEngine.Vector2             targetSizeDistortion  // 0xB8
  public            UnityEngine.AnimationCurve      distortionCurve  // 0xC0
  public            System.Boolean                  distortionRelativeToCenter  // 0xC8
  private           System.Single                   m_FallOff  // 0xCC
  private           System.Single                   m_EdgeOffset  // 0xD0
  private           System.Int32                    m_SideCount  // 0xD4
  private           System.Single                   m_SdfRoundness  // 0xD8
  public            System.Boolean                  inverseSDF  // 0xDC
  public            System.Single                   uniformAngle  // 0xE0
  public            UnityEngine.AnimationCurve      uniformAngleCurve  // 0xE8
METHODS:
  System.Void .ctor()
  System.Single get_localIntensity()
  System.Void set_localIntensity(System.Single value)
  System.Int32 get_count()
  System.Void set_count(System.Int32 value)
  System.Single get_intensityVariation()
  System.Void set_intensityVariation(System.Single value)
  System.Single get_fallOff()
  System.Void set_fallOff(System.Single value)
  System.Single get_edgeOffset()
  System.Void set_edgeOffset(System.Single value)
  System.Int32 get_sideCount()
  System.Void set_sideCount(System.Int32 value)
  System.Single get_sdfRoundness()
  System.Void set_sdfRoundness(System.Single value)
END_CLASS

CLASS: UnityEngine.Rendering.LensFlareDataSRP
TYPE:  class
TOKEN: 0x20000E9
EXTENDS: ScriptableObject
FIELDS:
  public            UnityEngine.Rendering.LensFlareDataElementSRP[]elements  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.RenderPipelineResources
TYPE:  class
TOKEN: 0x20000EA
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  System.String get_packagePath()
  System.String get_packagePath_Internal()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.PackingRules
TYPE:  struct
TOKEN: 0x20000EB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.PackingRulesExact  // 0x0
  public    static  UnityEngine.Rendering.PackingRulesAggressive  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.FieldPacking
TYPE:  struct
TOKEN: 0x20000EC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.FieldPackingNoPacking  // 0x0
  public    static  UnityEngine.Rendering.FieldPackingR11G11B10  // 0x0
  public    static  UnityEngine.Rendering.FieldPackingPackedFloat  // 0x0
  public    static  UnityEngine.Rendering.FieldPackingPackedUint  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.FieldPrecision
TYPE:  struct
TOKEN: 0x20000ED
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.FieldPrecisionHalf  // 0x0
  public    static  UnityEngine.Rendering.FieldPrecisionReal  // 0x0
  public    static  UnityEngine.Rendering.FieldPrecisionDefault  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.GenerateHLSL
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: Attribute
FIELDS:
  public            UnityEngine.Rendering.PackingRulespackingRules  // 0x10
  public            System.Boolean                  containsPackedFields  // 0x14
  public            System.Boolean                  needAccessors  // 0x15
  public            System.Boolean                  needSetters  // 0x16
  public            System.Boolean                  needParamDebug  // 0x17
  public            System.Int32                    paramDefinesStart  // 0x18
  public            System.Boolean                  omitStructDeclaration  // 0x1C
  public            System.Boolean                  generateCBuffer  // 0x1D
  public            System.Int32                    constantRegister  // 0x20
  public            System.String                   sourcePath  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.Rendering.PackingRules rules, System.Boolean needAccessors, System.Boolean needSetters, System.Boolean needParamDebug, System.Int32 paramDefinesStart, System.Boolean omitStructDeclaration, System.Boolean containsPackedFields, System.Boolean generateCBuffer, System.Int32 constantRegister, System.String sourcePath)
END_CLASS

CLASS: UnityEngine.Rendering.SurfaceDataAttributes
TYPE:  class
TOKEN: 0x20000EF
EXTENDS: Attribute
FIELDS:
  public            System.String[]                 displayNames  // 0x10
  public            System.Boolean                  isDirection  // 0x18
  public            System.Boolean                  sRGBDisplay  // 0x19
  public            UnityEngine.Rendering.FieldPrecisionprecision  // 0x1C
  public            System.Boolean                  checkIsNormalized  // 0x20
  public            System.String                   preprocessor  // 0x28
METHODS:
  System.Void .ctor(System.String displayName, System.Boolean isDirection, System.Boolean sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, System.Boolean checkIsNormalized, System.String preprocessor)
  System.Void .ctor(System.String[] displayNames, System.Boolean isDirection, System.Boolean sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, System.Boolean checkIsNormalized, System.String preprocessor)
END_CLASS

CLASS: UnityEngine.Rendering.HLSLArray
TYPE:  class
TOKEN: 0x20000F0
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    arraySize  // 0x10
  public            System.Type                     elementType  // 0x18
METHODS:
  System.Void .ctor(System.Int32 arraySize, System.Type elementType)
END_CLASS

CLASS: UnityEngine.Rendering.PackingAttribute
TYPE:  class
TOKEN: 0x20000F1
EXTENDS: Attribute
FIELDS:
  public            System.String[]                 displayNames  // 0x10
  public            System.Single[]                 range  // 0x18
  public            UnityEngine.Rendering.FieldPackingpackingScheme  // 0x20
  public            System.Int32                    offsetInSource  // 0x24
  public            System.Int32                    sizeInBits  // 0x28
  public            System.Boolean                  isDirection  // 0x2C
  public            System.Boolean                  sRGBDisplay  // 0x2D
  public            System.Boolean                  checkIsNormalized  // 0x2E
  public            System.String                   preprocessor  // 0x30
METHODS:
  System.Void .ctor(System.String[] displayNames, UnityEngine.Rendering.FieldPacking packingScheme, System.Int32 bitSize, System.Int32 offsetInSource, System.Single minValue, System.Single maxValue, System.Boolean isDirection, System.Boolean sRGBDisplay, System.Boolean checkIsNormalized, System.String preprocessor)
  System.Void .ctor(System.String displayName, UnityEngine.Rendering.FieldPacking packingScheme, System.Int32 bitSize, System.Int32 offsetInSource, System.Single minValue, System.Single maxValue, System.Boolean isDirection, System.Boolean sRGBDisplay, System.Boolean checkIsNormalized, System.String preprocessor)
END_CLASS

CLASS: UnityEngine.Rendering.ShaderGenUInt4
TYPE:  struct
TOKEN: 0x20000F2
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.Hammersley
TYPE:  class
TOKEN: 0x20000F3
FIELDS:
  private   static  System.Single[]                 k_Hammersley2dSeq16  // 0x0
  private   static  System.Single[]                 k_Hammersley2dSeq32  // 0x8
  private   static  System.Single[]                 k_Hammersley2dSeq64  // 0x10
  private   static  System.Single[]                 k_Hammersley2dSeq256  // 0x18
  private   static readonly System.Int32                    s_hammersley2DSeq16Id  // 0x20
  private   static readonly System.Int32                    s_hammersley2DSeq32Id  // 0x24
  private   static readonly System.Int32                    s_hammersley2DSeq64Id  // 0x28
  private   static readonly System.Int32                    s_hammersley2DSeq256Id  // 0x2C
METHODS:
  System.Void Initialize()
  System.Void BindConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.BufferedRTHandleSystem
TYPE:  class
TOKEN: 0x20000FC
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Rendering.RTHandle[]>m_RTHandles  // 0x10
  private           System.Boolean                  m_DisposedValue  // 0x18
METHODS:
  UnityEngine.Rendering.RTHandle GetFrameRT(System.Int32 bufferId, System.Int32 frameIndex)
  System.Void AllocBuffer(System.Int32 bufferId, System.Func<System.Int32,UnityEngine.Rendering.RTHandle> allocator, System.Int32 bufferCount)
  System.Void ReleaseBuffer(System.Int32 bufferId)
  System.Int32 GetNumFramesAllocated(System.Int32 bufferId)
  System.Void Swap()
  System.Void Dispose(System.Boolean disposing)
  System.Void Dispose()
  System.Void ReleaseAll()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.DepthBits
TYPE:  struct
TOKEN: 0x20000FD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DepthBits None  // 0x0
  public    static  UnityEngine.Rendering.DepthBits Depth8  // 0x0
  public    static  UnityEngine.Rendering.DepthBits Depth16  // 0x0
  public    static  UnityEngine.Rendering.DepthBits Depth24  // 0x0
  public    static  UnityEngine.Rendering.DepthBits Depth32  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.MSAASamples
TYPE:  struct
TOKEN: 0x20000FE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.MSAASamplesNone  // 0x0
  public    static  UnityEngine.Rendering.MSAASamplesMSAA2x  // 0x0
  public    static  UnityEngine.Rendering.MSAASamplesMSAA4x  // 0x0
  public    static  UnityEngine.Rendering.MSAASamplesMSAA8x  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.PowerOfTwoTextureAtlas
TYPE:  class
TOKEN: 0x20000FF
EXTENDS: Texture2DAtlas
FIELDS:
  private   readonly System.Int32                    m_MipPadding  // 0x48
  private   static  System.Single                   k_MipmapFactorApprox  // 0x0
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector2Int>m_RequestedTextures  // 0x50
METHODS:
  System.Void .ctor(System.Int32 size, System.Int32 mipPadding, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, System.String name, System.Boolean useMipMap)
  System.Int32 get_mipPadding()
  System.Int32 GetTexturePadding()
  UnityEngine.Vector4 GetPayloadScaleOffset(UnityEngine.Texture texture, UnityEngine.Vector4& scaleOffset)
  UnityEngine.Vector4 GetPayloadScaleOffset(UnityEngine.Vector2& textureSize, UnityEngine.Vector2& paddingSize, UnityEngine.Vector4& scaleOffset)
  System.Void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType blitType)
  System.Void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID)
  System.Void BlitTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID)
  System.Void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID)
  System.Void BlitOctahedralTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID)
  System.Void TextureSizeToPowerOfTwo(UnityEngine.Texture texture, System.Int32& width, System.Int32& height)
  UnityEngine.Vector2 GetPowerOfTwoTextureSize(UnityEngine.Texture texture)
  System.Boolean AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture, System.Int32 width, System.Int32 height, System.Int32 overrideInstanceID)
  System.Void ResetRequestedTexture()
  System.Boolean ReserveSpace(UnityEngine.Texture texture)
  System.Boolean ReserveSpace(UnityEngine.Texture texture, System.Int32 width, System.Int32 height)
  System.Boolean ReserveSpace(UnityEngine.Texture textureA, UnityEngine.Texture textureB, System.Int32 width, System.Int32 height)
  System.Boolean ReserveSpace(System.Int32 id, System.Int32 width, System.Int32 height)
  System.Boolean RelayoutEntries()
  System.Int64 GetApproxCacheSizeInByte(System.Int32 nbElement, System.Int32 resolution, System.Boolean hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Int32 GetMaxCacheSizeForWeightInByte(System.Int32 weight, System.Boolean hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format)
END_CLASS

CLASS: UnityEngine.Rendering.RTHandle
TYPE:  class
TOKEN: 0x2000102
FIELDS:
  private           UnityEngine.RenderTexture       m_RT  // 0x10
  private           UnityEngine.Texture             m_ExternalTexture  // 0x18
  private           UnityEngine.Rendering.RenderTargetIdentifierm_NameID  // 0x20
  private           System.Boolean                  m_EnableMSAA  // 0x48
  private           System.Boolean                  m_EnableRandomWrite  // 0x49
  private           System.String                   m_Name  // 0x50
METHODS:
  UnityEngine.RenderTexture get_rt()
  UnityEngine.Rendering.RenderTargetIdentifier get_nameID()
  System.String get_name()
  System.Void set_name(System.String value)
  System.Boolean get_isMSAAEnabled()
  UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RTHandle handle)
  UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RTHandle handle)
  UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RTHandle handle)
  System.Void SetRenderTexture(UnityEngine.RenderTexture rt)
  System.Void SetTexture(UnityEngine.Texture tex)
  System.Void SetTexture(UnityEngine.Rendering.RenderTargetIdentifier tex)
  System.Int32 GetInstanceID()
  System.Void Release()
  System.Void SwitchToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, System.Single residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags, System.Boolean copyContents)
  System.Void CopyToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, System.Single residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags)
  System.Void SwitchOutFastMemory(UnityEngine.Rendering.CommandBuffer cmd, System.Boolean copyContents)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.RTHandles
TYPE:  class
TOKEN: 0x2000103
FIELDS:
  private   static  UnityEngine.Rendering.RTHandleSystems_DefaultInstance  // 0x0
METHODS:
  UnityEngine.Rendering.RTHandle Alloc(System.Int32 width, System.Int32 height, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, UnityEngine.RenderTextureMemoryless memoryless, System.String name)
  UnityEngine.Rendering.RTHandle Alloc(System.Int32 width, System.Int32 height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, System.Boolean useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, System.String name)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture tex)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture tex)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex, System.String name)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.RTHandleSystem
TYPE:  class
TOKEN: 0x2000104
FIELDS:
METHODS:
  System.Void Initialize()
  UnityEngine.Rendering.RTHandle Alloc(System.Int32 width, System.Int32 height, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, UnityEngine.RenderTextureMemoryless memoryless, System.String name)
  UnityEngine.Rendering.RTHandle Alloc(System.Int32 width, System.Int32 height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, UnityEngine.RenderTextureMemoryless memoryless, System.String name)
  UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(System.Int32 width, System.Int32 height, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, UnityEngine.RenderTextureMemoryless memoryless, System.String name)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture texture)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture texture)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture, System.String name)
  UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.AtlasAllocator
TYPE:  class
TOKEN: 0x2000105
FIELDS:
  private           UnityEngine.Rendering.AtlasAllocator.AtlasNodem_Root  // 0x10
  private           System.Int32                    m_Width  // 0x18
  private           System.Int32                    m_Height  // 0x1C
  private           System.Boolean                  powerOfTwoPadding  // 0x20
  private           UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode>m_NodePool  // 0x28
METHODS:
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Boolean potPadding)
  System.Boolean Allocate(UnityEngine.Vector4& result, System.Int32 width, System.Int32 height)
  System.Void Reset()
END_CLASS

CLASS: UnityEngine.Rendering.Texture2DAtlas
TYPE:  class
TOKEN: 0x2000108
FIELDS:
  private   static  System.Int32                    kGPUTexInvalid  // 0x0
  private   static  System.Int32                    kGPUTexValidMip0  // 0x0
  private   static  System.Int32                    kGPUTexValidMipAll  // 0x0
  private           UnityEngine.Rendering.RTHandle  m_AtlasTexture  // 0x10
  private           System.Int32                    m_Width  // 0x18
  private           System.Int32                    m_Height  // 0x1C
  private           UnityEngine.Experimental.Rendering.GraphicsFormatm_Format  // 0x20
  private           System.Boolean                  m_UseMipMaps  // 0x24
  private           System.Boolean                  m_IsAtlasTextureOwner  // 0x25
  private           UnityEngine.Rendering.AtlasAllocatorm_AtlasAllocator  // 0x28
  private           System.Collections.Generic.Dictionary<System.Int32,System.ValueTuple<UnityEngine.Vector4,UnityEngine.Vector2Int>>m_AllocationCache  // 0x30
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_IsGPUTextureUpToDate  // 0x38
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_TextureHashes  // 0x40
  private   static readonly UnityEngine.Vector4             fullScaleOffset  // 0x0
  private   static readonly System.Int32                    s_MaxMipLevelPadding  // 0x10
METHODS:
  System.Int32 get_maxMipLevelPadding()
  UnityEngine.Rendering.RTHandle get_AtlasTexture()
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, System.Boolean powerOfTwoPadding, System.String name, System.Boolean useMipMap)
  System.Void Release()
  System.Void ResetAllocator()
  System.Void ClearTarget(UnityEngine.Rendering.CommandBuffer cmd)
  System.Int32 GetTextureMipmapCount(System.Int32 width, System.Int32 height)
  System.Boolean Is2D(UnityEngine.Texture texture)
  System.Boolean IsSingleChannelBlit(UnityEngine.Texture source, UnityEngine.Texture destination)
  System.Void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, UnityEngine.Rendering.Texture2DAtlas.BlitType blitType)
  System.Void MarkGPUTextureValid(System.Int32 instanceId, System.Boolean mipAreValid)
  System.Void MarkGPUTextureInvalid(System.Int32 instanceId)
  System.Void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID)
  System.Void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID)
  System.Void BlitCubeTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, System.Boolean blitMips, System.Int32 overrideInstanceID)
  System.Boolean AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture, System.Int32 width, System.Int32 height, System.Int32 overrideInstanceID)
  System.Boolean AllocateTextureWithoutBlit(UnityEngine.Texture texture, System.Int32 width, System.Int32 height, UnityEngine.Vector4& scaleOffset)
  System.Boolean AllocateTextureWithoutBlit(System.Int32 instanceId, System.Int32 width, System.Int32 height, UnityEngine.Vector4& scaleOffset)
  System.Int32 GetTextureHash(UnityEngine.Texture textureA, UnityEngine.Texture textureB)
  System.Int32 GetTextureID(UnityEngine.Texture texture)
  System.Int32 GetTextureID(UnityEngine.Texture textureA, UnityEngine.Texture textureB)
  System.Boolean IsCached(UnityEngine.Vector4& scaleOffset, UnityEngine.Texture textureA, UnityEngine.Texture textureB)
  System.Boolean IsCached(UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture)
  System.Boolean IsCached(UnityEngine.Vector4& scaleOffset, System.Int32 id)
  UnityEngine.Vector2Int GetCachedTextureSize(System.Int32 id)
  System.Boolean NeedsUpdate(UnityEngine.Texture texture, System.Boolean needMips)
  System.Boolean NeedsUpdate(UnityEngine.Texture textureA, UnityEngine.Texture textureB, System.Boolean needMips)
  System.Boolean AddTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture)
  System.Boolean UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture oldTexture, UnityEngine.Texture newTexture, UnityEngine.Vector4& scaleOffset, UnityEngine.Vector4 sourceScaleOffset, System.Boolean updateIfNeeded, System.Boolean blitMips)
  System.Boolean UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, UnityEngine.Vector4& scaleOffset, System.Boolean updateIfNeeded, System.Boolean blitMips)
  System.Boolean EnsureTextureSlot(System.Boolean& isUploadNeeded, UnityEngine.Vector4& scaleBias, System.Int32 key, System.Int32 width, System.Int32 height)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.AtlasAllocatorDynamic
TYPE:  class
TOKEN: 0x200010A
FIELDS:
  private           System.Int32                    m_Width  // 0x10
  private           System.Int32                    m_Height  // 0x14
  private           UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePoolm_Pool  // 0x18
  private           System.Int16                    m_Root  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int16>m_NodeFromID  // 0x28
METHODS:
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 capacityAllocations)
  System.Boolean Allocate(UnityEngine.Vector4& result, System.Int32 key, System.Int32 width, System.Int32 height)
  System.Void Release(System.Int32 key)
  System.Void Release()
  System.String DebugStringFromRoot(System.Int32 depthMax)
  System.Void DebugStringFromNode(System.String& res, System.Int16 n, System.Int32 depthCurrent, System.Int32 depthMax)
END_CLASS

CLASS: UnityEngine.Rendering.Texture2DAtlasDynamic
TYPE:  class
TOKEN: 0x200010E
FIELDS:
  private           UnityEngine.Rendering.RTHandle  m_AtlasTexture  // 0x10
  private           System.Boolean                  isAtlasTextureOwner  // 0x18
  private           System.Int32                    m_Width  // 0x1C
  private           System.Int32                    m_Height  // 0x20
  private           UnityEngine.Experimental.Rendering.GraphicsFormatm_Format  // 0x24
  private           UnityEngine.Rendering.AtlasAllocatorDynamicm_AtlasAllocator  // 0x28
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4>m_AllocationCache  // 0x30
METHODS:
  UnityEngine.Rendering.RTHandle get_AtlasTexture()
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 capacity, UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 capacity, UnityEngine.Rendering.RTHandle atlasTexture)
  System.Void Release()
  System.Void ResetAllocator()
  System.Boolean AddTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture)
  System.Boolean IsCached(UnityEngine.Vector4& scaleOffset, System.Int32 key)
  System.Boolean EnsureTextureSlot(System.Boolean& isUploadNeeded, UnityEngine.Vector4& scaleOffset, System.Int32 key, System.Int32 width, System.Int32 height)
  System.Void ReleaseTextureSlot(System.Int32 key)
END_CLASS

CLASS: UnityEngine.Rendering.TextureXR
TYPE:  class
TOKEN: 0x200010F
FIELDS:
  private   static  System.Int32                    m_MaxViews  // 0x0
  private   static  UnityEngine.Texture             m_BlackUIntTexture2DArray  // 0x8
  private   static  UnityEngine.Texture             m_BlackUIntTexture  // 0x10
  private   static  UnityEngine.Rendering.RTHandle  m_BlackUIntTexture2DArrayRTH  // 0x18
  private   static  UnityEngine.Rendering.RTHandle  m_BlackUIntTextureRTH  // 0x20
  private   static  UnityEngine.Texture2DArray      m_ClearTexture2DArray  // 0x28
  private   static  UnityEngine.Texture2D           m_ClearTexture  // 0x30
  private   static  UnityEngine.Rendering.RTHandle  m_ClearTexture2DArrayRTH  // 0x38
  private   static  UnityEngine.Rendering.RTHandle  m_ClearTextureRTH  // 0x40
  private   static  UnityEngine.Texture2DArray      m_MagentaTexture2DArray  // 0x48
  private   static  UnityEngine.Texture2D           m_MagentaTexture  // 0x50
  private   static  UnityEngine.Rendering.RTHandle  m_MagentaTexture2DArrayRTH  // 0x58
  private   static  UnityEngine.Rendering.RTHandle  m_MagentaTextureRTH  // 0x60
  private   static  UnityEngine.Texture2D           m_BlackTexture  // 0x68
  private   static  UnityEngine.Texture3D           m_BlackTexture3D  // 0x70
  private   static  UnityEngine.Texture2DArray      m_BlackTexture2DArray  // 0x78
  private   static  UnityEngine.Rendering.RTHandle  m_BlackTexture2DArrayRTH  // 0x80
  private   static  UnityEngine.Rendering.RTHandle  m_BlackTextureRTH  // 0x88
  private   static  UnityEngine.Rendering.RTHandle  m_BlackTexture3DRTH  // 0x90
  private   static  UnityEngine.Texture2DArray      m_WhiteTexture2DArray  // 0x98
  private   static  UnityEngine.Rendering.RTHandle  m_WhiteTexture2DArrayRTH  // 0xA0
  private   static  UnityEngine.Rendering.RTHandle  m_WhiteTextureRTH  // 0xA8
METHODS:
  System.Void set_maxViews(System.Int32 value)
  System.Int32 get_slices()
  System.Boolean get_useTexArray()
  UnityEngine.Rendering.TextureDimension get_dimension()
  UnityEngine.Rendering.RTHandle GetBlackUIntTexture()
  UnityEngine.Rendering.RTHandle GetClearTexture()
  UnityEngine.Rendering.RTHandle GetMagentaTexture()
  UnityEngine.Rendering.RTHandle GetBlackTexture()
  UnityEngine.Rendering.RTHandle GetBlackTextureArray()
  UnityEngine.Rendering.RTHandle GetBlackTexture3D()
  UnityEngine.Rendering.RTHandle GetWhiteTexture()
  System.Void Initialize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader)
  UnityEngine.Texture2DArray CreateTexture2DArrayFromTexture2D(UnityEngine.Texture2D source, System.String name)
  UnityEngine.Texture CreateBlackUIntTextureArray(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader)
  UnityEngine.Texture CreateBlackUintTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader)
  UnityEngine.Texture3D CreateBlackTexture3D(System.String name)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.ArrayExtensions
TYPE:  class
TOKEN: 0x2000110
FIELDS:
METHODS:
  System.Void ResizeArray(Unity.Collections.NativeArray<T>& array, System.Int32 capacity, Unity.Collections.Allocator allocator)
  System.Void ResizeArray(UnityEngine.Jobs.TransformAccessArray& array, System.Int32 capacity)
  System.Void ResizeArray(T[]& array, System.Int32 capacity)
  System.Void Grow(T[]& array, System.Int32 targetSize)
  System.Void GrowToNearestPowerOf2(T[]& array, System.Int32 targetSize)
  System.UInt32 RoundUpToPowerOf2(System.UInt32 n)
END_CLASS

CLASS: UnityEngine.Rendering.IBitArray
TYPE:  interface
TOKEN: 0x2000111
FIELDS:
METHODS:
  System.UInt32 get_capacity()
  System.Boolean get_allFalse()
  System.Boolean get_allTrue()
  System.Boolean get_Item(System.UInt32 index)
  System.Void set_Item(System.UInt32 index, System.Boolean value)
  System.String get_humanizedData()
  UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitNot()
END_CLASS

CLASS: UnityEngine.Rendering.BitArray8
TYPE:  struct
TOKEN: 0x2000112
FIELDS:
  private           System.Byte                     data  // 0x10
METHODS:
  System.UInt32 get_capacity()
  System.Boolean get_allFalse()
  System.Boolean get_allTrue()
  System.String get_humanizedData()
  System.Boolean get_Item(System.UInt32 index)
  System.Void set_Item(System.UInt32 index, System.Boolean value)
  System.Void .ctor(System.Byte initValue)
  System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue)
  UnityEngine.Rendering.BitArray8 op_OnesComplement(UnityEngine.Rendering.BitArray8 a)
  UnityEngine.Rendering.BitArray8 op_BitwiseOr(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b)
  UnityEngine.Rendering.BitArray8 op_BitwiseAnd(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b)
  UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitNot()
  System.Boolean op_Equality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b)
  System.Boolean op_Inequality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.BitArray16
TYPE:  struct
TOKEN: 0x2000113
FIELDS:
  private           System.UInt16                   data  // 0x10
METHODS:
  System.UInt32 get_capacity()
  System.Boolean get_allFalse()
  System.Boolean get_allTrue()
  System.String get_humanizedData()
  System.Boolean get_Item(System.UInt32 index)
  System.Void set_Item(System.UInt32 index, System.Boolean value)
  System.Void .ctor(System.UInt16 initValue)
  System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue)
  UnityEngine.Rendering.BitArray16 op_OnesComplement(UnityEngine.Rendering.BitArray16 a)
  UnityEngine.Rendering.BitArray16 op_BitwiseOr(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b)
  UnityEngine.Rendering.BitArray16 op_BitwiseAnd(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b)
  UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitNot()
  System.Boolean op_Equality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b)
  System.Boolean op_Inequality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.BitArray32
TYPE:  struct
TOKEN: 0x2000114
FIELDS:
  private           System.UInt32                   data  // 0x10
METHODS:
  System.UInt32 get_capacity()
  System.Boolean get_allFalse()
  System.Boolean get_allTrue()
  System.String get_humanizedVersion()
  System.String get_humanizedData()
  System.Boolean get_Item(System.UInt32 index)
  System.Void set_Item(System.UInt32 index, System.Boolean value)
  System.Void .ctor(System.UInt32 initValue)
  System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue)
  UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitNot()
  UnityEngine.Rendering.BitArray32 op_OnesComplement(UnityEngine.Rendering.BitArray32 a)
  UnityEngine.Rendering.BitArray32 op_BitwiseOr(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b)
  UnityEngine.Rendering.BitArray32 op_BitwiseAnd(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b)
  System.Boolean op_Equality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b)
  System.Boolean op_Inequality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.BitArray64
TYPE:  struct
TOKEN: 0x2000115
FIELDS:
  private           System.UInt64                   data  // 0x10
METHODS:
  System.UInt32 get_capacity()
  System.Boolean get_allFalse()
  System.Boolean get_allTrue()
  System.String get_humanizedData()
  System.Boolean get_Item(System.UInt32 index)
  System.Void set_Item(System.UInt32 index, System.Boolean value)
  System.Void .ctor(System.UInt64 initValue)
  System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue)
  UnityEngine.Rendering.BitArray64 op_OnesComplement(UnityEngine.Rendering.BitArray64 a)
  UnityEngine.Rendering.BitArray64 op_BitwiseOr(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b)
  UnityEngine.Rendering.BitArray64 op_BitwiseAnd(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b)
  UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitNot()
  System.Boolean op_Equality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b)
  System.Boolean op_Inequality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.BitArray128
TYPE:  struct
TOKEN: 0x2000116
FIELDS:
  private           System.UInt64                   data1  // 0x10
  private           System.UInt64                   data2  // 0x18
METHODS:
  System.UInt64 get_Data1()
  System.UInt64 get_Data2()
  System.UInt32 get_capacity()
  System.Boolean get_allFalse()
  System.Boolean get_allTrue()
  System.String get_humanizedData()
  System.Boolean get_Item(System.UInt32 index)
  System.Void set_Item(System.UInt32 index, System.Boolean value)
  System.Void .ctor(System.UInt64 initValue1, System.UInt64 initValue2)
  System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue)
  UnityEngine.Rendering.BitArray128 op_OnesComplement(UnityEngine.Rendering.BitArray128 a)
  UnityEngine.Rendering.BitArray128 op_BitwiseOr(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b)
  UnityEngine.Rendering.BitArray128 op_BitwiseAnd(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b)
  UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitNot()
  System.Boolean op_Equality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b)
  System.Boolean op_Inequality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.BitArray256
TYPE:  struct
TOKEN: 0x2000117
FIELDS:
  private           System.UInt64                   data1  // 0x10
  private           System.UInt64                   data2  // 0x18
  private           System.UInt64                   data3  // 0x20
  private           System.UInt64                   data4  // 0x28
METHODS:
  System.UInt32 get_capacity()
  System.Boolean get_allFalse()
  System.Boolean get_allTrue()
  System.String get_humanizedData()
  System.Boolean get_Item(System.UInt32 index)
  System.Void set_Item(System.UInt32 index, System.Boolean value)
  System.Void .ctor(System.UInt64 initValue1, System.UInt64 initValue2, System.UInt64 initValue3, System.UInt64 initValue4)
  System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue)
  UnityEngine.Rendering.BitArray256 op_OnesComplement(UnityEngine.Rendering.BitArray256 a)
  UnityEngine.Rendering.BitArray256 op_BitwiseOr(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b)
  UnityEngine.Rendering.BitArray256 op_BitwiseAnd(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b)
  UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other)
  UnityEngine.Rendering.IBitArray BitNot()
  System.Boolean op_Equality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b)
  System.Boolean op_Inequality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.BitArrayUtilities
TYPE:  class
TOKEN: 0x2000118
FIELDS:
METHODS:
  System.Boolean Get8(System.UInt32 index, System.Byte data)
  System.Boolean Get16(System.UInt32 index, System.UInt16 data)
  System.Boolean Get32(System.UInt32 index, System.UInt32 data)
  System.Boolean Get64(System.UInt32 index, System.UInt64 data)
  System.Boolean Get128(System.UInt32 index, System.UInt64 data1, System.UInt64 data2)
  System.Boolean Get256(System.UInt32 index, System.UInt64 data1, System.UInt64 data2, System.UInt64 data3, System.UInt64 data4)
  System.Void Set8(System.UInt32 index, System.Byte& data, System.Boolean value)
  System.Void Set16(System.UInt32 index, System.UInt16& data, System.Boolean value)
  System.Void Set32(System.UInt32 index, System.UInt32& data, System.Boolean value)
  System.Void Set64(System.UInt32 index, System.UInt64& data, System.Boolean value)
  System.Void Set128(System.UInt32 index, System.UInt64& data1, System.UInt64& data2, System.Boolean value)
  System.Void Set256(System.UInt32 index, System.UInt64& data1, System.UInt64& data2, System.UInt64& data3, System.UInt64& data4, System.Boolean value)
END_CLASS

CLASS: UnityEngine.Rendering.Blitter
TYPE:  class
TOKEN: 0x2000119
FIELDS:
  private   static  UnityEngine.Material            s_Blit  // 0x0
  private   static  UnityEngine.Material            s_BlitTexArray  // 0x8
  private   static  UnityEngine.Material            s_BlitTexArraySingleSlice  // 0x10
  private   static  UnityEngine.Material            s_BlitMotionVector  // 0x18
  private   static  UnityEngine.Material            s_BlitColorAndDepth  // 0x20
  private   static  UnityEngine.Material            s_LowResBlit  // 0x28
  private   static  UnityEngine.MaterialPropertyBlocks_PropertyBlock  // 0x30
  private   static  UnityEngine.Mesh                s_TriangleMesh  // 0x38
  private   static  UnityEngine.Mesh                s_QuadMesh  // 0x40
METHODS:
  System.Void Initialize(UnityEngine.Shader blitPS, UnityEngine.Shader blitColorAndDepthPS, UnityEngine.Shader blitMotionVectorPS, UnityEngine.Shader lowResBlitPS)
  System.Void Cleanup()
  UnityEngine.Material GetBlitMaterial(System.Boolean isFP32Output, UnityEngine.Rendering.TextureDimension dimension, System.Boolean singleSlice)
  UnityEngine.Material GetBlitColorAndDepth(System.Boolean isFP32Output)
  UnityEngine.Material GetBlitMotionVectorMaterial()
  UnityEngine.Material GetLowResBlitMaterial()
  System.Void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, System.Int32 shaderPass)
  System.Void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, System.Int32 shaderPass)
  System.Void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, System.Single mipLevel, System.Boolean bilinear)
  System.Void BlitTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, System.Single mipLevel, System.Boolean bilinear)
  System.Void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, System.Int32 pass)
  System.Void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, System.Single mipLevel, System.Boolean bilinear)
  System.Void BlitCameraTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, System.Single mipLevel, System.Boolean bilinear)
  System.Void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, System.Int32 pass)
  System.Void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Vector4 scaleBias, System.Single mipLevel, System.Boolean bilinear)
  System.Void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect destViewport, System.Single mipLevel, System.Boolean bilinear)
  System.Void BlitQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear)
  System.Void BlitQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear, System.Int32 paddingInPixels)
  System.Void BlitQuadWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear, System.Int32 paddingInPixels)
  System.Void BlitOctahedralWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear, System.Int32 paddingInPixels)
  System.Void BlitOctahedralWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear, System.Int32 paddingInPixels)
  System.Void BlitCubeToOctahedral2DQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex)
  System.Void BlitCubeToOctahedral2DQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex)
  System.Void BlitQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex)
  System.Void .cctor()
  UnityEngine.Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|10_0(System.Single z)
  UnityEngine.Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|10_1()
  UnityEngine.Vector3[] <Initialize>g__GetQuadVertexPosition|10_2(System.Single z)
  UnityEngine.Vector2[] <Initialize>g__GetQuadTexCoord|10_3()
END_CLASS

CLASS: UnityEngine.Rendering.CameraCaptureBridge
TYPE:  class
TOKEN: 0x200011B
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Camera,System.Collections.Generic.HashSet<System.Action<UnityEngine.Rendering.RenderTargetIdentifier,UnityEngine.Rendering.CommandBuffer>>>actionDict  // 0x0
  private   static  System.Boolean                  _enabled  // 0x8
METHODS:
  System.Boolean get_enabled()
  System.Void set_enabled(System.Boolean value)
  System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier,UnityEngine.Rendering.CommandBuffer>> GetCaptureActions(UnityEngine.Camera camera)
  System.Void AddCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier,UnityEngine.Rendering.CommandBuffer> action)
  System.Void RemoveCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier,UnityEngine.Rendering.CommandBuffer> action)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.ColorUtils
TYPE:  class
TOKEN: 0x200011C
FIELDS:
  public    static  System.Single                   s_LightMeterCalibrationConstant  // 0x0
  public    static  System.Single                   s_LensAttenuation  // 0x4
METHODS:
  System.Single get_lensImperfectionExposureScale()
  System.Single StandardIlluminantY(System.Single x)
  UnityEngine.Vector3 CIExyToLMS(System.Single x, System.Single y)
  UnityEngine.Vector3 ColorBalanceToLMSCoeffs(System.Single temperature, System.Single tint)
  System.ValueTuple<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector4> PrepareShadowsMidtonesHighlights(UnityEngine.Vector4& inShadows, UnityEngine.Vector4& inMidtones, UnityEngine.Vector4& inHighlights)
  System.ValueTuple<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector4> PrepareLiftGammaGain(UnityEngine.Vector4& inLift, UnityEngine.Vector4& inGamma, UnityEngine.Vector4& inGain)
  System.ValueTuple<UnityEngine.Vector4,UnityEngine.Vector4> PrepareSplitToning(UnityEngine.Vector4& inShadows, UnityEngine.Vector4& inHighlights, System.Single balance)
  System.Single Luminance(UnityEngine.Color& color)
  System.Single ComputeEV100(System.Single aperture, System.Single shutterSpeed, System.Single ISO)
  System.Single ConvertEV100ToExposure(System.Single EV100)
  System.Single ConvertExposureToEV100(System.Single exposure)
  System.Single ComputeEV100FromAvgLuminance(System.Single avgLuminance)
  System.Single ComputeISO(System.Single aperture, System.Single shutterSpeed, System.Single targetEV100)
  System.UInt32 ToHex(UnityEngine.Color c)
  UnityEngine.Color ToRGBA(System.UInt32 hex)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.CoreMatrixUtils
TYPE:  class
TOKEN: 0x200011D
FIELDS:
METHODS:
  System.Void MatrixTimesTranslation(UnityEngine.Matrix4x4& inOutMatrix, UnityEngine.Vector3 translation)
  System.Void TranslationTimesMatrix(UnityEngine.Matrix4x4& inOutMatrix, UnityEngine.Vector3 translation)
  UnityEngine.Matrix4x4 MultiplyPerspectiveMatrix(UnityEngine.Matrix4x4 perspective, UnityEngine.Matrix4x4 rhs)
  UnityEngine.Matrix4x4 MultiplyOrthoMatrixCentered(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs)
  UnityEngine.Matrix4x4 MultiplyGenericOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs)
  UnityEngine.Matrix4x4 MultiplyOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs, System.Boolean centered)
  UnityEngine.Matrix4x4 MultiplyProjectionMatrix(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 rhs, System.Boolean orthoCentered)
END_CLASS

CLASS: UnityEngine.Rendering.CoreUtils
TYPE:  class
TOKEN: 0x200011E
FIELDS:
  public    static readonly UnityEngine.Vector3[]           lookAtList  // 0x0
  public    static readonly UnityEngine.Vector3[]           upVectorList  // 0x8
  private   static  System.String                   obsoletePriorityMessage  // 0x0
  public    static  System.Int32                    editMenuPriority1  // 0x0
  public    static  System.Int32                    editMenuPriority2  // 0x0
  public    static  System.Int32                    editMenuPriority3  // 0x0
  public    static  System.Int32                    editMenuPriority4  // 0x0
  public    static  System.Int32                    assetCreateMenuPriority1  // 0x0
  public    static  System.Int32                    assetCreateMenuPriority2  // 0x0
  public    static  System.Int32                    assetCreateMenuPriority3  // 0x0
  public    static  System.Int32                    gameObjectMenuPriority  // 0x0
  private   static  UnityEngine.Cubemap             m_BlackCubeTexture  // 0x10
  private   static  UnityEngine.Cubemap             m_MagentaCubeTexture  // 0x18
  private   static  UnityEngine.CubemapArray        m_MagentaCubeTextureArray  // 0x20
  private   static  UnityEngine.Cubemap             m_WhiteCubeTexture  // 0x28
  private   static  UnityEngine.RenderTexture       m_EmptyUAV  // 0x30
  private   static  UnityEngine.Texture3D           m_BlackVolumeTexture  // 0x38
  private   static  System.Collections.Generic.IEnumerable<System.Type>m_AssemblyTypes  // 0x40
METHODS:
  UnityEngine.Cubemap get_blackCubeTexture()
  UnityEngine.Cubemap get_magentaCubeTexture()
  UnityEngine.CubemapArray get_magentaCubeTextureArray()
  UnityEngine.Cubemap get_whiteCubeTexture()
  UnityEngine.RenderTexture get_emptyUAV()
  UnityEngine.Texture3D get_blackVolumeTexture()
  System.Void ClearRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor)
  System.Int32 FixupDepthSlice(System.Int32 depthSlice, UnityEngine.Rendering.RTHandle buffer)
  System.Int32 FixupDepthSlice(System.Int32 depthSlice, UnityEngine.CubemapFace cubemapFace)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag)
  System.Void SetViewportAndClear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag)
  System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor)
  System.Void SetViewport(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle target)
  System.String GetRenderTargetAutoName(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, System.String name, System.Boolean mips, System.Boolean enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples)
  System.String GetRenderTargetAutoName(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.String name, System.Boolean mips, System.Boolean enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples)
  System.String GetRenderTargetAutoName(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Boolean enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean dynamicRes)
  System.String GetRenderTargetAutoName(System.Int32 width, System.Int32 height, System.Int32 depth, System.String format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Boolean enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean dynamicRes)
  System.String GetTextureAutoName(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Int32 depth)
  System.String GetTextureAutoName(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Int32 depth)
  System.String GetTextureAutoName(System.Int32 width, System.Int32 height, System.String format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Int32 depth)
  System.Void ClearCubemap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTexture renderTexture, UnityEngine.Color clearColor, System.Boolean clearMips)
  System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId)
  System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId)
  System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId)
  System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId)
  System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId)
  UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color)
  UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color)
  UnityEngine.Material CreateEngineMaterial(System.String shaderPath)
  UnityEngine.Material CreateEngineMaterial(UnityEngine.Shader shader, System.Boolean enableInstancing)
  System.Boolean HasFlag(T mask, T flag)
  System.Void Swap(T& a, T& b)
  System.Void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, System.String keyword, System.Boolean state)
  System.Void SetKeyword(UnityEngine.Material material, System.String keyword, System.Boolean state)
  System.Void SetKeyword(UnityEngine.ComputeShader cs, System.String keyword, System.Boolean state)
  System.Void Destroy(UnityEngine.Object obj)
  System.Collections.Generic.IEnumerable<System.Type> GetAllAssemblyTypes()
  System.Collections.Generic.IEnumerable<System.Type> GetAllTypesDerivedFrom()
  System.Void SafeRelease(UnityEngine.ComputeBuffer buffer)
  UnityEngine.Mesh CreateCubeMesh(UnityEngine.Vector3 min, UnityEngine.Vector3 max)
  System.Boolean ArePostProcessesEnabled(UnityEngine.Camera camera)
  System.Boolean AreAnimatedMaterialsEnabled(UnityEngine.Camera camera)
  System.Boolean IsSceneLightingDisabled(UnityEngine.Camera camera)
  System.Boolean IsLightOverlapDebugEnabled(UnityEngine.Camera camera)
  System.Boolean IsSceneViewFogEnabled(UnityEngine.Camera camera)
  System.Boolean IsSceneFilteringEnabled()
  System.Boolean IsSceneViewPrefabStageContextHidden()
  System.Void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Experimental.Rendering.RendererList rendererList)
  System.Void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RendererUtils.RendererList rendererList)
  System.Int32 GetTextureHash(UnityEngine.Texture texture)
  System.Int32 PreviousPowerOfTwo(System.Int32 size)
  T GetLastEnumValue()
  System.String GetCorePath()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.DelegateUtility
TYPE:  class
TOKEN: 0x2000123
FIELDS:
METHODS:
  System.Delegate Cast(System.Delegate source, System.Type type)
END_CLASS

CLASS: UnityEngine.Rendering.FSRUtils
TYPE:  class
TOKEN: 0x2000124
FIELDS:
  private   static  System.Single                   kMaxSharpnessStops  // 0x0
  public    static  System.Single                   kDefaultSharpnessStops  // 0x0
  public    static  System.Single                   kDefaultSharpnessLinear  // 0x0
METHODS:
  System.Void SetEasuConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels)
  System.Void SetRcasConstants(UnityEngine.Rendering.CommandBuffer cmd, System.Single sharpnessStops)
  System.Void SetRcasConstantsLinear(UnityEngine.Rendering.CommandBuffer cmd, System.Single sharpnessLinear)
  System.Boolean IsSupported()
END_CLASS

CLASS: UnityEngine.Rendering.HableCurve
TYPE:  class
TOKEN: 0x2000126
FIELDS:
  private           System.Single                   <whitePoint>k__BackingField  // 0x10
  private           System.Single                   <inverseWhitePoint>k__BackingField  // 0x14
  private           System.Single                   <x0>k__BackingField  // 0x18
  private           System.Single                   <x1>k__BackingField  // 0x1C
  public    readonly UnityEngine.Rendering.HableCurve.Segment[]segments  // 0x20
  public    readonly UnityEngine.Rendering.HableCurve.Uniformsuniforms  // 0x28
METHODS:
  System.Single get_whitePoint()
  System.Void set_whitePoint(System.Single value)
  System.Single get_inverseWhitePoint()
  System.Void set_inverseWhitePoint(System.Single value)
  System.Single get_x0()
  System.Void set_x0(System.Single value)
  System.Single get_x1()
  System.Void set_x1(System.Single value)
  System.Void .ctor()
  System.Single Eval(System.Single x)
  System.Void Init(System.Single toeStrength, System.Single toeLength, System.Single shoulderStrength, System.Single shoulderLength, System.Single shoulderAngle, System.Single gamma)
  System.Void InitSegments(UnityEngine.Rendering.HableCurve.DirectParams srcParams)
  System.Void SolveAB(System.Single& lnA, System.Single& B, System.Single x0, System.Single y0, System.Single m)
  System.Void AsSlopeIntercept(System.Single& m, System.Single& b, System.Single x0, System.Single x1, System.Single y0, System.Single y1)
  System.Single EvalDerivativeLinearGamma(System.Single m, System.Single b, System.Single g, System.Single x)
END_CLASS

CLASS: UnityEngine.Rendering.HaltonSequence
TYPE:  class
TOKEN: 0x200012A
FIELDS:
METHODS:
  System.Single Get(System.Int32 index, System.Int32 radix)
END_CLASS

CLASS: UnityEngine.Rendering.MaterialQuality
TYPE:  struct
TOKEN: 0x200012B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.MaterialQualityLow  // 0x0
  public    static  UnityEngine.Rendering.MaterialQualityMedium  // 0x0
  public    static  UnityEngine.Rendering.MaterialQualityHigh  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.MaterialQualityUtilities
TYPE:  class
TOKEN: 0x200012C
FIELDS:
  public    static  System.String[]                 KeywordNames  // 0x0
  public    static  System.String[]                 EnumNames  // 0x8
  public    static  UnityEngine.Rendering.ShaderKeyword[]Keywords  // 0x10
METHODS:
  UnityEngine.Rendering.MaterialQuality GetHighestQuality(UnityEngine.Rendering.MaterialQuality levels)
  UnityEngine.Rendering.MaterialQuality GetClosestQuality(UnityEngine.Rendering.MaterialQuality availableLevels, UnityEngine.Rendering.MaterialQuality requestedLevel)
  System.Void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level)
  System.Void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level, UnityEngine.Rendering.CommandBuffer cmd)
  System.Int32 ToFirstIndex(UnityEngine.Rendering.MaterialQuality level)
  UnityEngine.Rendering.MaterialQuality FromIndex(System.Int32 index)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.MeshGizmo
TYPE:  class
TOKEN: 0x200012D
FIELDS:
  public    static readonly System.Int32                    vertexCountPerCube  // 0x0
  public            UnityEngine.Mesh                mesh  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Vector3>vertices  // 0x18
  private           System.Collections.Generic.List<System.Int32>indices  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Color>colors  // 0x28
  private           UnityEngine.Material            wireMaterial  // 0x30
  private           UnityEngine.Material            dottedWireMaterial  // 0x38
  private           UnityEngine.Material            solidMaterial  // 0x40
METHODS:
  System.Void .ctor(System.Int32 capacity)
  System.Void Clear()
  System.Void AddWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size, UnityEngine.Color color)
  System.Void DrawMesh(UnityEngine.Matrix4x4 trs, UnityEngine.Material mat, UnityEngine.MeshTopology topology, UnityEngine.Rendering.CompareFunction depthTest, System.String gizmoName)
  System.Void RenderWireframe(UnityEngine.Matrix4x4 trs, UnityEngine.Rendering.CompareFunction depthTest, System.String gizmoName)
  System.Void Dispose()
  System.Void .cctor()
  System.Void <AddWireCube>g__AddEdge|10_0(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Rendering.MeshGizmo.<>c__DisplayClass10_0& )
END_CLASS

CLASS: UnityEngine.Rendering.ReloadAttribute
TYPE:  class
TOKEN: 0x200012F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor(System.String[] paths, UnityEngine.Rendering.ReloadAttribute.Package package)
  System.Void .ctor(System.String path, UnityEngine.Rendering.ReloadAttribute.Package package)
  System.Void .ctor(System.String pathFormat, System.Int32 rangeMin, System.Int32 rangeMax, UnityEngine.Rendering.ReloadAttribute.Package package)
END_CLASS

CLASS: UnityEngine.Rendering.ReloadGroupAttribute
TYPE:  class
TOKEN: 0x2000131
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.TextureCurve
TYPE:  class
TOKEN: 0x2000132
FIELDS:
  private   static  System.Int32                    k_Precision  // 0x0
  private   static  System.Single                   k_Step  // 0x0
  private           System.Int32                    <length>k__BackingField  // 0x10
  private           System.Boolean                  m_Loop  // 0x14
  private           System.Single                   m_ZeroValue  // 0x18
  private           System.Single                   m_Range  // 0x1C
  private           UnityEngine.AnimationCurve      m_Curve  // 0x20
  private           UnityEngine.AnimationCurve      m_LoopingCurve  // 0x28
  private           UnityEngine.Texture2D           m_Texture  // 0x30
  private           System.Boolean                  m_IsCurveDirty  // 0x38
  private           System.Boolean                  m_IsTextureDirty  // 0x39
  private           System.Int32                    m_LastUpdatedFrame  // 0x3C
METHODS:
  System.Int32 get_length()
  System.Void set_length(System.Int32 value)
  System.Boolean IsTextureCurveDirty()
  UnityEngine.Keyframe get_Item(System.Int32 index)
  System.Void .ctor(UnityEngine.AnimationCurve baseCurve, System.Single zeroValue, System.Boolean loop, UnityEngine.Vector2& bounds)
  System.Void .ctor(UnityEngine.Keyframe[] keys, System.Single zeroValue, System.Boolean loop, UnityEngine.Vector2& bounds)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Release()
  System.Void SetDirty()
  UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat()
  UnityEngine.Texture2D GetTexture()
  System.Single Evaluate(System.Single time)
  System.Int32 AddKey(System.Single time, System.Single value)
  System.Int32 MoveKey(System.Int32 index, UnityEngine.Keyframe& key)
  System.Void RemoveKey(System.Int32 index)
  System.Void SmoothTangents(System.Int32 index, System.Single weight)
END_CLASS

CLASS: UnityEngine.Rendering.TextureCurveParameter
TYPE:  class
TOKEN: 0x2000133
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Rendering.TextureCurve value, System.Boolean overrideState)
  System.Void Release()
END_CLASS

CLASS: UnityEngine.Rendering.TileLayoutUtils
TYPE:  class
TOKEN: 0x2000134
FIELDS:
METHODS:
  System.Boolean TryLayoutByTiles(UnityEngine.RectInt src, System.UInt32 tileSize, UnityEngine.RectInt& main, UnityEngine.RectInt& topRow, UnityEngine.RectInt& rightCol, UnityEngine.RectInt& topRight)
  System.Boolean TryLayoutByRow(UnityEngine.RectInt src, System.UInt32 tileSize, UnityEngine.RectInt& main, UnityEngine.RectInt& other)
  System.Boolean TryLayoutByCol(UnityEngine.RectInt src, System.UInt32 tileSize, UnityEngine.RectInt& main, UnityEngine.RectInt& other)
END_CLASS

CLASS: UnityEngine.Rendering.XRUtils
TYPE:  class
TOKEN: 0x2000135
FIELDS:
METHODS:
  System.Void DrawOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, System.Boolean stereoEnabled)
END_CLASS

CLASS: UnityEngine.Rendering.IVolume
TYPE:  interface
TOKEN: 0x2000136
FIELDS:
METHODS:
  System.Boolean get_isGlobal()
  System.Void set_isGlobal(System.Boolean value)
  System.Collections.Generic.List<UnityEngine.Collider> get_colliders()
END_CLASS

CLASS: UnityEngine.Rendering.Volume
TYPE:  class
TOKEN: 0x2000137
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  m_IsGlobal  // 0x18
  public            System.Boolean                  isLunaPlatform  // 0x19
  public            System.Single                   priority  // 0x1C
  public            System.Single                   blendDistance  // 0x20
  public            System.Single                   weight  // 0x24
  public            UnityEngine.Rendering.VolumeProfilesharedProfile  // 0x28
  private           System.Collections.Generic.List<UnityEngine.Collider>m_Colliders  // 0x30
  private           System.Int32                    m_PreviousLayer  // 0x38
  private           System.Single                   m_PreviousPriority  // 0x3C
  private           UnityEngine.Rendering.VolumeProfilem_InternalProfile  // 0x40
METHODS:
  System.Boolean get_isGlobal()
  System.Void set_isGlobal(System.Boolean value)
  UnityEngine.Rendering.VolumeProfile GetInstantiatedProfile()
  System.Void SetInstantiatedProfile(UnityEngine.Rendering.VolumeProfile profile)
  System.Collections.Generic.List<UnityEngine.Collider> get_colliders()
  UnityEngine.Rendering.VolumeProfile get_profileRef()
  System.Boolean HasInstantiatedProfile()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void UpdateLayer()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.VolumeComponentMenu
TYPE:  class
TOKEN: 0x2000138
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   menu  // 0x10
METHODS:
  System.Void .ctor(System.String menu)
END_CLASS

CLASS: UnityEngine.Rendering.VolumeComponentMenuForRenderPipeline
TYPE:  class
TOKEN: 0x2000139
EXTENDS: VolumeComponentMenu
FIELDS:
  private   readonly System.Type[]                   <pipelineTypes>k__BackingField  // 0x18
METHODS:
  System.Type[] get_pipelineTypes()
  System.Void .ctor(System.String menu, System.Type[] pipelineTypes)
END_CLASS

CLASS: UnityEngine.Rendering.VolumeComponentDeprecated
TYPE:  class
TOKEN: 0x200013A
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.MigratingVolumeComponent
TYPE:  class
TOKEN: 0x200013B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.VolumeComponent
TYPE:  class
TOKEN: 0x200013C
EXTENDS: ScriptableObject
FIELDS:
  public            System.Boolean                  active  // 0x18
  private           System.String                   <displayName>k__BackingField  // 0x20
  private           UnityEngine.Rendering.VolumeParameter[]<parameters>k__BackingField  // 0x28
METHODS:
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  UnityEngine.Rendering.VolumeParameter[] get_parameters()
  System.Void set_parameters(UnityEngine.Rendering.VolumeParameter[] value)
  System.Void FindParameters(System.Object o, System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameters, System.Func<System.Reflection.FieldInfo,System.Boolean> filter)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Override(UnityEngine.Rendering.VolumeComponent state, System.Single interpFactor)
  System.Void SetAllOverridesTo(System.Boolean state)
  System.Void SetOverridesTo(System.Collections.Generic.IEnumerable<UnityEngine.Rendering.VolumeParameter> enumerable, System.Boolean state)
  System.Int32 GetHashCode()
  System.Void OnDestroy()
  System.Void Release()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.VolumeManager
TYPE:  class
TOKEN: 0x200013F
FIELDS:
  private   static readonly System.Lazy<UnityEngine.Rendering.VolumeManager>s_Instance  // 0x0
  private           UnityEngine.Rendering.VolumeStack<stack>k__BackingField  // 0x10
  private           System.Type[]                   <baseComponentTypeArray>k__BackingField  // 0x18
  private   static  System.Int32                    k_MaxLayerCount  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.Rendering.Volume>>m_SortedVolumes  // 0x20
  private   readonly System.Collections.Generic.List<UnityEngine.Rendering.Volume>m_Volumes  // 0x28
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Boolean>m_SortNeeded  // 0x30
  private   readonly System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent>m_ComponentsDefaultState  // 0x38
  private   readonly System.Collections.Generic.List<UnityEngine.Collider>m_TempColliders  // 0x40
  private           UnityEngine.Rendering.VolumeStackm_DefaultStack  // 0x48
METHODS:
  UnityEngine.Rendering.VolumeManager get_instance()
  UnityEngine.Rendering.VolumeStack get_stack()
  System.Void set_stack(UnityEngine.Rendering.VolumeStack value)
  System.Collections.Generic.IEnumerable<System.Type> get_baseComponentTypes()
  System.Void set_baseComponentTypes(System.Collections.Generic.IEnumerable<System.Type> value)
  System.Type[] get_baseComponentTypeArray()
  System.Void set_baseComponentTypeArray(System.Type[] value)
  System.Void .ctor()
  UnityEngine.Rendering.VolumeStack CreateStack()
  System.Void ResetMainStack()
  System.Void DestroyStack(UnityEngine.Rendering.VolumeStack stack)
  System.Void ReloadBaseTypes()
  System.Void Register(UnityEngine.Rendering.Volume volume, System.Int32 layer)
  System.Void Unregister(UnityEngine.Rendering.Volume volume, System.Int32 layer)
  System.Boolean IsComponentActiveInMask(UnityEngine.LayerMask layerMask)
  System.Void SetLayerDirty(System.Int32 layer)
  System.Void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, System.Int32 prevLayer, System.Int32 newLayer)
  System.Void OverrideData(UnityEngine.Rendering.VolumeStack stack, System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components, System.Single interpFactor)
  System.Void ReplaceData(UnityEngine.Rendering.VolumeStack stack)
  System.Void CheckBaseTypes()
  System.Void CheckStack(UnityEngine.Rendering.VolumeStack stack)
  System.Boolean CheckUpdateRequired(UnityEngine.Rendering.VolumeStack stack)
  System.Void Update(UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask)
  System.Void Update(UnityEngine.Rendering.VolumeStack stack, UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask)
  UnityEngine.Rendering.Volume[] GetVolumes(UnityEngine.LayerMask layerMask)
  System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask)
  System.Void SortByPriority(System.Collections.Generic.List<UnityEngine.Rendering.Volume> volumes)
  System.Boolean IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, UnityEngine.Camera camera)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.VolumeIsolationScope
TYPE:  struct
TOKEN: 0x2000141
FIELDS:
METHODS:
  System.Void .ctor(System.Boolean unused)
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: UnityEngine.Rendering.VolumeParameter
TYPE:  class
TOKEN: 0x2000142
FIELDS:
  public    static  System.String                   k_DebuggerDisplay  // 0x0
  public            System.Boolean                  overrideState  // 0x10
METHODS:
  System.Void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, System.Single t)
  T GetValue()
  System.Void SetValue(UnityEngine.Rendering.VolumeParameter parameter)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Release()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.VolumeParameter`1
TYPE:  class
TOKEN: 0x2000143
EXTENDS: VolumeParameter
FIELDS:
  protected         T                               m_Value  // 0x0
METHODS:
  T get_value()
  System.Void set_value(T value)
  System.Void .ctor()
  System.Void .ctor(T value, System.Boolean overrideState)
  System.Void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, System.Single t)
  System.Void Interp(T from, T to, System.Single t)
  System.Void Override(T x)
  System.Void SetValue(UnityEngine.Rendering.VolumeParameter parameter)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean op_Equality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs)
  System.Boolean op_Inequality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs)
  System.Boolean Equals(UnityEngine.Rendering.VolumeParameter<T> other)
  System.Boolean Equals(System.Object obj)
  T op_Explicit(UnityEngine.Rendering.VolumeParameter<T> prop)
END_CLASS

CLASS: UnityEngine.Rendering.BoolParameter
TYPE:  class
TOKEN: 0x2000144
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(System.Boolean value, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.LayerMaskParameter
TYPE:  class
TOKEN: 0x2000145
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.LayerMask value, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.IntParameter
TYPE:  class
TOKEN: 0x2000146
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 value, System.Boolean overrideState)
  System.Void Interp(System.Int32 from, System.Int32 to, System.Single t)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpIntParameter
TYPE:  class
TOKEN: 0x2000147
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 value, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.MinIntParameter
TYPE:  class
TOKEN: 0x2000148
EXTENDS: IntParameter
FIELDS:
  public            System.Int32                    min  // 0x20
METHODS:
  System.Int32 get_value()
  System.Void set_value(System.Int32 value)
  System.Void .ctor(System.Int32 value, System.Int32 min, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpMinIntParameter
TYPE:  class
TOKEN: 0x2000149
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Int32                    min  // 0x20
METHODS:
  System.Int32 get_value()
  System.Void set_value(System.Int32 value)
  System.Void .ctor(System.Int32 value, System.Int32 min, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.MaxIntParameter
TYPE:  class
TOKEN: 0x200014A
EXTENDS: IntParameter
FIELDS:
  public            System.Int32                    max  // 0x20
METHODS:
  System.Int32 get_value()
  System.Void set_value(System.Int32 value)
  System.Void .ctor(System.Int32 value, System.Int32 max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpMaxIntParameter
TYPE:  class
TOKEN: 0x200014B
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Int32                    max  // 0x20
METHODS:
  System.Int32 get_value()
  System.Void set_value(System.Int32 value)
  System.Void .ctor(System.Int32 value, System.Int32 max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.ClampedIntParameter
TYPE:  class
TOKEN: 0x200014C
EXTENDS: IntParameter
FIELDS:
  public            System.Int32                    min  // 0x20
  public            System.Int32                    max  // 0x24
METHODS:
  System.Int32 get_value()
  System.Void set_value(System.Int32 value)
  System.Void .ctor(System.Int32 value, System.Int32 min, System.Int32 max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpClampedIntParameter
TYPE:  class
TOKEN: 0x200014D
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Int32                    min  // 0x20
  public            System.Int32                    max  // 0x24
METHODS:
  System.Int32 get_value()
  System.Void set_value(System.Int32 value)
  System.Void .ctor(System.Int32 value, System.Int32 min, System.Int32 max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.FloatParameter
TYPE:  class
TOKEN: 0x200014E
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(System.Single value, System.Boolean overrideState)
  System.Void Interp(System.Single from, System.Single to, System.Single t)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpFloatParameter
TYPE:  class
TOKEN: 0x200014F
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(System.Single value, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.MinFloatParameter
TYPE:  class
TOKEN: 0x2000150
EXTENDS: FloatParameter
FIELDS:
  public            System.Single                   min  // 0x20
METHODS:
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void .ctor(System.Single value, System.Single min, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpMinFloatParameter
TYPE:  class
TOKEN: 0x2000151
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Single                   min  // 0x20
METHODS:
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void .ctor(System.Single value, System.Single min, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.MaxFloatParameter
TYPE:  class
TOKEN: 0x2000152
EXTENDS: FloatParameter
FIELDS:
  public            System.Single                   max  // 0x20
METHODS:
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void .ctor(System.Single value, System.Single max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpMaxFloatParameter
TYPE:  class
TOKEN: 0x2000153
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Single                   max  // 0x20
METHODS:
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void .ctor(System.Single value, System.Single max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.ClampedFloatParameter
TYPE:  class
TOKEN: 0x2000154
EXTENDS: FloatParameter
FIELDS:
  public            System.Single                   min  // 0x20
  public            System.Single                   max  // 0x24
  public            System.Single                   sliderExponent  // 0x28
METHODS:
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Single sliderExponent, System.Boolean overrideState)
  System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpClampedFloatParameter
TYPE:  class
TOKEN: 0x2000155
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Single                   min  // 0x20
  public            System.Single                   max  // 0x24
  public            System.Single                   sliderExponent  // 0x28
METHODS:
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Single sliderExponent, System.Boolean overrideState)
  System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.UnclampedFloatParameter
TYPE:  class
TOKEN: 0x2000156
EXTENDS: FloatParameter
FIELDS:
  public            System.Single                   min  // 0x20
  public            System.Single                   max  // 0x24
  public            System.Single                   sliderExponent  // 0x28
METHODS:
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Single sliderExponent, System.Boolean overrideState)
  System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpUnclampedFloatParameter
TYPE:  class
TOKEN: 0x2000157
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Single                   min  // 0x20
  public            System.Single                   max  // 0x24
  public            System.Single                   sliderExponent  // 0x28
METHODS:
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Single sliderExponent, System.Boolean overrideState)
  System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.FloatRangeParameter
TYPE:  class
TOKEN: 0x2000158
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Single                   min  // 0x20
  public            System.Single                   max  // 0x24
METHODS:
  UnityEngine.Vector2 get_value()
  System.Void set_value(UnityEngine.Vector2 value)
  System.Void .ctor(UnityEngine.Vector2 value, System.Single min, System.Single max, System.Boolean overrideState)
  System.Void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, System.Single t)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpFloatRangeParameter
TYPE:  class
TOKEN: 0x2000159
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Single                   min  // 0x20
  public            System.Single                   max  // 0x24
METHODS:
  UnityEngine.Vector2 get_value()
  System.Void set_value(UnityEngine.Vector2 value)
  System.Void .ctor(UnityEngine.Vector2 value, System.Single min, System.Single max, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.ColorParameter
TYPE:  class
TOKEN: 0x200015A
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Boolean                  hdr  // 0x28
  public            System.Boolean                  showAlpha  // 0x29
  public            System.Boolean                  showEyeDropper  // 0x2A
METHODS:
  System.Void .ctor(UnityEngine.Color value, System.Boolean overrideState)
  System.Void .ctor(UnityEngine.Color value, System.Boolean hdr, System.Boolean showAlpha, System.Boolean showEyeDropper, System.Boolean overrideState)
  System.Void Interp(UnityEngine.Color from, UnityEngine.Color to, System.Single t)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpColorParameter
TYPE:  class
TOKEN: 0x200015B
EXTENDS: VolumeParameter`1
FIELDS:
  public            System.Boolean                  hdr  // 0x28
  public            System.Boolean                  showAlpha  // 0x29
  public            System.Boolean                  showEyeDropper  // 0x2A
METHODS:
  System.Void .ctor(UnityEngine.Color value, System.Boolean overrideState)
  System.Void .ctor(UnityEngine.Color value, System.Boolean hdr, System.Boolean showAlpha, System.Boolean showEyeDropper, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.Vector2Parameter
TYPE:  class
TOKEN: 0x200015C
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Vector2 value, System.Boolean overrideState)
  System.Void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, System.Single t)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpVector2Parameter
TYPE:  class
TOKEN: 0x200015D
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Vector2 value, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.Vector3Parameter
TYPE:  class
TOKEN: 0x200015E
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Vector3 value, System.Boolean overrideState)
  System.Void Interp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpVector3Parameter
TYPE:  class
TOKEN: 0x200015F
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Vector3 value, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.Vector4Parameter
TYPE:  class
TOKEN: 0x2000160
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Vector4 value, System.Boolean overrideState)
  System.Void Interp(UnityEngine.Vector4 from, UnityEngine.Vector4 to, System.Single t)
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpVector4Parameter
TYPE:  class
TOKEN: 0x2000161
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Vector4 value, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.TextureParameter
TYPE:  class
TOKEN: 0x2000162
EXTENDS: VolumeParameter`1
FIELDS:
  public            UnityEngine.Rendering.TextureDimensiondimension  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState)
  System.Void .ctor(UnityEngine.Texture value, UnityEngine.Rendering.TextureDimension dimension, System.Boolean overrideState)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpTextureParameter
TYPE:  class
TOKEN: 0x2000163
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.Texture2DParameter
TYPE:  class
TOKEN: 0x2000164
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.Texture3DParameter
TYPE:  class
TOKEN: 0x2000165
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.RenderTextureParameter
TYPE:  class
TOKEN: 0x2000166
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.RenderTexture value, System.Boolean overrideState)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpRenderTextureParameter
TYPE:  class
TOKEN: 0x2000167
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.RenderTexture value, System.Boolean overrideState)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.CubemapParameter
TYPE:  class
TOKEN: 0x2000168
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.NoInterpCubemapParameter
TYPE:  class
TOKEN: 0x2000169
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Cubemap value, System.Boolean overrideState)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.AnimationCurveParameter
TYPE:  class
TOKEN: 0x200016A
EXTENDS: VolumeParameter`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.AnimationCurve value, System.Boolean overrideState)
END_CLASS

CLASS: UnityEngine.Rendering.VolumeProfile
TYPE:  class
TOKEN: 0x200016B
EXTENDS: ScriptableObject
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent>components  // 0x18
  public            System.Boolean                  isDirty  // 0x20
METHODS:
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Reset()
  T Add(System.Boolean overrides)
  UnityEngine.Rendering.VolumeComponent Add(System.Type type, System.Boolean overrides)
  System.Void Remove()
  System.Void Remove(System.Type type)
  System.Boolean Has()
  System.Boolean Has(System.Type type)
  System.Boolean HasSubclassOf(System.Type type)
  System.Boolean TryGet(T& component)
  System.Boolean TryGet(System.Type type, T& component)
  System.Boolean TryGetSubclassOf(System.Type type, T& component)
  System.Boolean TryGetAllSubclassOf(System.Type type, System.Collections.Generic.List<T> result)
  System.Int32 GetHashCode()
  System.Int32 GetComponentListHashCode()
  System.Void Sanitize()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.VolumeStack
TYPE:  class
TOKEN: 0x200016D
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.Rendering.VolumeComponent>components  // 0x10
  public            System.ValueTuple<UnityEngine.Rendering.VolumeParameter,UnityEngine.Rendering.VolumeParameter>[]defaultParameters  // 0x18
  private           System.Boolean                  requiresReset  // 0x20
METHODS:
  System.Void .ctor()
  System.Void Reload(System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> componentDefaultStates)
  T GetComponent()
  UnityEngine.Rendering.VolumeComponent GetComponent(System.Type type)
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.Rendering.XRGraphicsAutomatedTests
TYPE:  class
TOKEN: 0x200016E
FIELDS:
  private   static readonly System.Boolean                  <enabled>k__BackingField  // 0x0
  public    static  System.Boolean                  running  // 0x1
METHODS:
  System.Boolean get_activatedFromCommandLine()
  System.Boolean get_enabled()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.LookDev.IDataProvider
TYPE:  interface
TOKEN: 0x200016F
FIELDS:
METHODS:
  System.Void FirstInitScene(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage)
  System.Void UpdateSky(UnityEngine.Camera camera, UnityEngine.Rendering.LookDev.Sky sky, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage)
  System.Collections.Generic.IEnumerable<System.String> get_supportedDebugModes()
  System.Void UpdateDebugMode(System.Int32 debugIndex)
  System.Void GetShadowMask(UnityEngine.RenderTexture& output, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage)
  System.Void OnBeginRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage)
  System.Void OnEndRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage)
  System.Void Cleanup(UnityEngine.Rendering.LookDev.StageRuntimeInterface SRI)
END_CLASS

CLASS: UnityEngine.Rendering.LookDev.Sky
TYPE:  struct
TOKEN: 0x2000170
FIELDS:
  public            UnityEngine.Cubemap             cubemap  // 0x10
  public            System.Single                   longitudeOffset  // 0x18
  public            System.Single                   exposure  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.LookDev.StageRuntimeInterface
TYPE:  class
TOKEN: 0x2000171
FIELDS:
  private           System.Func<System.Boolean,UnityEngine.GameObject>m_AddGameObject  // 0x10
  private           System.Func<UnityEngine.Camera> m_GetCamera  // 0x18
  private           System.Func<UnityEngine.Light>  m_GetSunLight  // 0x20
  public            System.Object                   SRPData  // 0x28
METHODS:
  System.Void .ctor(System.Func<System.Boolean,UnityEngine.GameObject> AddGameObject, System.Func<UnityEngine.Camera> GetCamera, System.Func<UnityEngine.Light> GetSunLight)
  UnityEngine.GameObject AddGameObject(System.Boolean persistent)
  UnityEngine.Camera get_camera()
  UnityEngine.Light get_sunLight()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerBitField
TYPE:  class
TOKEN: 0x2000172
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.Rendering.UI.UIFoldoutvalueToggle  // 0x60
  public            System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerIndirectToggle>toggles  // 0x68
  private           UnityEngine.Rendering.DebugUI.BitFieldm_Field  // 0x70
  private           UnityEngine.Rendering.UI.DebugUIHandlerContainerm_Container  // 0x78
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean GetValue(System.Int32 index)
  System.Void SetValue(System.Int32 index, System.Boolean value)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void OnAction()
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerButton
TYPE:  class
TOKEN: 0x2000173
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  private           UnityEngine.Rendering.DebugUI.Buttonm_Field  // 0x60
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnAction()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIPrefabBundle
TYPE:  class
TOKEN: 0x2000174
FIELDS:
  public            System.String                   type  // 0x10
  public            UnityEngine.RectTransform       prefab  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerCanvas
TYPE:  class
TOKEN: 0x2000175
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Int32                    m_DebugTreeState  // 0x18
  private           System.Collections.Generic.Dictionary<System.Type,UnityEngine.Transform>m_PrefabsMap  // 0x20
  public            UnityEngine.Transform           panelPrefab  // 0x28
  public            System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIPrefabBundle>prefabs  // 0x30
  private           System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerPanel>m_UIPanels  // 0x38
  private           System.Int32                    m_SelectedPanel  // 0x40
  private           UnityEngine.Rendering.UI.DebugUIHandlerWidgetm_SelectedWidget  // 0x48
  private           System.String                   m_CurrentQueryPath  // 0x50
METHODS:
  System.Void OnEnable()
  System.Void Update()
  System.Void RequestHierarchyReset()
  System.Void ResetAllHierarchy()
  System.Void Rebuild()
  System.Void Traverse(UnityEngine.Rendering.DebugUI.IContainer container, UnityEngine.Transform parentTransform, UnityEngine.Rendering.UI.DebugUIHandlerWidget parentUIHandler, UnityEngine.Rendering.UI.DebugUIHandlerWidget& selectedHandler)
  UnityEngine.Rendering.UI.DebugUIHandlerWidget GetWidgetFromPath(System.String queryPath)
  System.Void ActivatePanel(System.Int32 index, UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedWidget)
  System.Void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, System.Boolean fromNext)
  System.Void SelectPreviousItem()
  System.Void SelectNextPanel()
  System.Void SelectPreviousPanel()
  System.Void SelectNextItem()
  System.Void ChangeSelectionValue(System.Single multiplier)
  System.Void ActivateSelection()
  System.Void HandleInput()
  System.Void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerColor
TYPE:  class
TOKEN: 0x2000178
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.Rendering.UI.UIFoldoutvalueToggle  // 0x60
  public            UnityEngine.UI.Image            colorImage  // 0x68
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldR  // 0x70
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldG  // 0x78
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldB  // 0x80
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldA  // 0x88
  private           UnityEngine.Rendering.DebugUI.ColorFieldm_Field  // 0x90
  private           UnityEngine.Rendering.UI.DebugUIHandlerContainerm_Container  // 0x98
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Void SetValue(System.Single x, System.Boolean r, System.Boolean g, System.Boolean b, System.Boolean a)
  System.Void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void OnAction()
  System.Void UpdateColor()
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
  System.Single <SetWidget>b__9_0()
  System.Void <SetWidget>b__9_1(System.Single x)
  System.Single <SetWidget>b__9_2()
  System.Void <SetWidget>b__9_3(System.Single x)
  System.Single <SetWidget>b__9_4()
  System.Void <SetWidget>b__9_5(System.Single x)
  System.Single <SetWidget>b__9_6()
  System.Void <SetWidget>b__9_7(System.Single x)
  System.Single <SetupSettings>b__11_0()
  System.Single <SetupSettings>b__11_1()
  System.Single <SetupSettings>b__11_2()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerContainer
TYPE:  class
TOKEN: 0x2000179
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.RectTransform       contentHolder  // 0x18
METHODS:
  UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem()
  UnityEngine.Rendering.UI.DebugUIHandlerWidget GetLastItem()
  System.Boolean IsDirectChild(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget)
  System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerWidget> GetActiveChildren()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerEnumField
TYPE:  class
TOKEN: 0x200017B
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nextButtonText  // 0x58
  public            UnityEngine.UI.Text             previousButtonText  // 0x60
  public            UnityEngine.UI.Text             nameLabel  // 0x68
  public            UnityEngine.UI.Text             valueLabel  // 0x70
  protected internal        UnityEngine.Rendering.DebugUI.EnumFieldm_Field  // 0x78
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnAction()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void UpdateValueLabel()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory
TYPE:  class
TOKEN: 0x200017C
EXTENDS: DebugUIHandlerEnumField
FIELDS:
  private           UnityEngine.UI.Text[]           historyValues  // 0x80
  private   static  System.Single                   xDecal  // 0x0
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Void UpdateValueLabel()
  System.Collections.IEnumerator RefreshAfterSanitization()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerFloatField
TYPE:  class
TOKEN: 0x200017E
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.UI.Text             valueLabel  // 0x60
  private           UnityEngine.Rendering.DebugUI.FloatFieldm_Field  // 0x68
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void ChangeValue(System.Boolean fast, System.Single multiplier)
  System.Void UpdateValueLabel()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerFoldout
TYPE:  class
TOKEN: 0x200017F
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.Rendering.UI.UIFoldoutvalueToggle  // 0x60
  private           UnityEngine.Rendering.DebugUI.Foldoutm_Field  // 0x68
  private           UnityEngine.Rendering.UI.DebugUIHandlerContainerm_Container  // 0x70
  private   static  System.Single                   xDecal  // 0x0
  private   static  System.Single                   xDecalInit  // 0x0
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void OnAction()
  System.Void UpdateValue()
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerGroup
TYPE:  class
TOKEN: 0x2000180
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.Transform           header  // 0x60
  private           UnityEngine.Rendering.DebugUI.Containerm_Field  // 0x68
  private           UnityEngine.Rendering.UI.DebugUIHandlerContainerm_Container  // 0x70
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerHBox
TYPE:  class
TOKEN: 0x2000181
EXTENDS: DebugUIHandlerWidget
FIELDS:
  private           UnityEngine.Rendering.UI.DebugUIHandlerContainerm_Container  // 0x58
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField
TYPE:  class
TOKEN: 0x2000182
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.UI.Text             valueLabel  // 0x60
  public            System.Func<System.Single>      getter  // 0x68
  public            System.Action<System.Single>    setter  // 0x70
  public            System.Func<System.Single>      incStepGetter  // 0x78
  public            System.Func<System.Single>      incStepMultGetter  // 0x80
  public            System.Func<System.Single>      decimalsGetter  // 0x88
METHODS:
  System.Void Init()
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void ChangeValue(System.Boolean fast, System.Single multiplier)
  System.Void UpdateValueLabel()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerIndirectToggle
TYPE:  class
TOKEN: 0x2000183
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.UI.Toggle           valueToggle  // 0x60
  public            UnityEngine.UI.Image            checkmarkImage  // 0x68
  public            System.Func<System.Int32,System.Boolean>getter  // 0x70
  public            System.Action<System.Int32,System.Boolean>setter  // 0x78
  private           System.Int32                    index  // 0x80
METHODS:
  System.Void Init()
  System.Void OnToggleValueChanged(System.Boolean value)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnAction()
  System.Void UpdateValueLabel()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerIntField
TYPE:  class
TOKEN: 0x2000184
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.UI.Text             valueLabel  // 0x60
  private           UnityEngine.Rendering.DebugUI.IntFieldm_Field  // 0x68
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void ChangeValue(System.Boolean fast, System.Int32 multiplier)
  System.Void UpdateValueLabel()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerMessageBox
TYPE:  class
TOKEN: 0x2000185
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  private           UnityEngine.Rendering.DebugUI.MessageBoxm_Field  // 0x60
  private   static  UnityEngine.Color32             k_WarningBackgroundColor  // 0x0
  private   static  UnityEngine.Color32             k_WarningTextColor  // 0x4
  private   static  UnityEngine.Color32             k_ErrorBackgroundColor  // 0x8
  private   static  UnityEngine.Color32             k_ErrorTextColor  // 0xC
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerPanel
TYPE:  class
TOKEN: 0x2000186
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x18
  public            UnityEngine.UI.ScrollRect       scrollRect  // 0x20
  public            UnityEngine.RectTransform       viewport  // 0x28
  public            UnityEngine.Rendering.UI.DebugUIHandlerCanvasCanvas  // 0x30
  private           UnityEngine.RectTransform       m_ScrollTransform  // 0x38
  private           UnityEngine.RectTransform       m_ContentTransform  // 0x40
  private           UnityEngine.RectTransform       m_MaskTransform  // 0x48
  private           UnityEngine.Rendering.UI.DebugUIHandlerWidgetm_ScrollTarget  // 0x50
  protected internal        UnityEngine.Rendering.DebugUI.Panelm_Panel  // 0x58
METHODS:
  System.Void OnEnable()
  System.Void SetPanel(UnityEngine.Rendering.DebugUI.Panel panel)
  UnityEngine.Rendering.DebugUI.Panel GetPanel()
  System.Void SelectNextItem()
  System.Void SelectPreviousItem()
  System.Void OnScrollbarClicked()
  System.Void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget target)
  System.Void UpdateScroll()
  System.Single GetYPosInScroll(UnityEngine.RectTransform target)
  UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem()
  System.Void ResetDebugManager()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvas
TYPE:  class
TOKEN: 0x2000187
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.RectTransform       panel  // 0x18
  public            UnityEngine.RectTransform       valuePrefab  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerValue>m_Items  // 0x28
METHODS:
  System.Void Toggle(UnityEngine.Rendering.DebugUI.Value widget)
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerRow
TYPE:  class
TOKEN: 0x2000189
EXTENDS: DebugUIHandlerFoldout
FIELDS:
  private           System.Single                   m_Timer  // 0x78
METHODS:
  System.Void OnEnable()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerToggle
TYPE:  class
TOKEN: 0x200018A
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.UI.Toggle           valueToggle  // 0x60
  public            UnityEngine.UI.Image            checkmarkImage  // 0x68
  protected internal        UnityEngine.Rendering.DebugUI.BoolFieldm_Field  // 0x70
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Void OnToggleValueChanged(System.Boolean value)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnAction()
  System.Void UpdateValueLabel()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory
TYPE:  class
TOKEN: 0x200018B
EXTENDS: DebugUIHandlerToggle
FIELDS:
  private           UnityEngine.UI.Toggle[]         historyToggles  // 0x78
  private   static  System.Single                   xDecal  // 0x0
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Void UpdateValueLabel()
  System.Collections.IEnumerator RefreshAfterSanitization()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerUIntField
TYPE:  class
TOKEN: 0x200018D
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.UI.Text             valueLabel  // 0x60
  private           UnityEngine.Rendering.DebugUI.UIntFieldm_Field  // 0x68
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void ChangeValue(System.Boolean fast, System.Int32 multiplier)
  System.Void UpdateValueLabel()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerValue
TYPE:  class
TOKEN: 0x200018E
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.UI.Text             valueLabel  // 0x60
  private           UnityEngine.Rendering.DebugUI.Valuem_Field  // 0x68
  private           System.Single                   m_Timer  // 0x70
METHODS:
  System.Void OnEnable()
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerVBox
TYPE:  class
TOKEN: 0x200018F
EXTENDS: DebugUIHandlerWidget
FIELDS:
  private           UnityEngine.Rendering.UI.DebugUIHandlerContainerm_Container  // 0x58
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerVector2
TYPE:  class
TOKEN: 0x2000190
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.Rendering.UI.UIFoldoutvalueToggle  // 0x60
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldX  // 0x68
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldY  // 0x70
  private           UnityEngine.Rendering.DebugUI.Vector2Fieldm_Field  // 0x78
  private           UnityEngine.Rendering.UI.DebugUIHandlerContainerm_Container  // 0x80
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Void SetValue(System.Single v, System.Boolean x, System.Boolean y)
  System.Void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void OnAction()
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
  System.Single <SetWidget>b__6_0()
  System.Void <SetWidget>b__6_1(System.Single x)
  System.Single <SetWidget>b__6_2()
  System.Void <SetWidget>b__6_3(System.Single x)
  System.Single <SetupSettings>b__8_0()
  System.Single <SetupSettings>b__8_1()
  System.Single <SetupSettings>b__8_2()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerVector3
TYPE:  class
TOKEN: 0x2000191
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.Rendering.UI.UIFoldoutvalueToggle  // 0x60
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldX  // 0x68
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldY  // 0x70
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldZ  // 0x78
  private           UnityEngine.Rendering.DebugUI.Vector3Fieldm_Field  // 0x80
  private           UnityEngine.Rendering.UI.DebugUIHandlerContainerm_Container  // 0x88
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Void SetValue(System.Single v, System.Boolean x, System.Boolean y, System.Boolean z)
  System.Void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void OnAction()
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
  System.Single <SetWidget>b__7_0()
  System.Void <SetWidget>b__7_1(System.Single v)
  System.Single <SetWidget>b__7_2()
  System.Void <SetWidget>b__7_3(System.Single v)
  System.Single <SetWidget>b__7_4()
  System.Void <SetWidget>b__7_5(System.Single v)
  System.Single <SetupSettings>b__9_0()
  System.Single <SetupSettings>b__9_1()
  System.Single <SetupSettings>b__9_2()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerVector4
TYPE:  class
TOKEN: 0x2000192
EXTENDS: DebugUIHandlerWidget
FIELDS:
  public            UnityEngine.UI.Text             nameLabel  // 0x58
  public            UnityEngine.Rendering.UI.UIFoldoutvalueToggle  // 0x60
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldX  // 0x68
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldY  // 0x70
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldZ  // 0x78
  public            UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatFieldfieldW  // 0x80
  private           UnityEngine.Rendering.DebugUI.Vector4Fieldm_Field  // 0x88
  private           UnityEngine.Rendering.UI.DebugUIHandlerContainerm_Container  // 0x90
METHODS:
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  System.Void SetValue(System.Single v, System.Boolean x, System.Boolean y, System.Boolean z, System.Boolean w)
  System.Void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field)
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  System.Void OnAction()
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
  System.Single <SetWidget>b__8_0()
  System.Void <SetWidget>b__8_1(System.Single x)
  System.Single <SetWidget>b__8_2()
  System.Void <SetWidget>b__8_3(System.Single x)
  System.Single <SetWidget>b__8_4()
  System.Void <SetWidget>b__8_5(System.Single x)
  System.Single <SetWidget>b__8_6()
  System.Void <SetWidget>b__8_7(System.Single x)
  System.Single <SetupSettings>b__10_0()
  System.Single <SetupSettings>b__10_1()
  System.Single <SetupSettings>b__10_2()
END_CLASS

CLASS: UnityEngine.Rendering.UI.DebugUIHandlerWidget
TYPE:  class
TOKEN: 0x2000193
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Color               colorDefault  // 0x18
  public            UnityEngine.Color               colorSelected  // 0x28
  private           UnityEngine.Rendering.UI.DebugUIHandlerWidget<parentUIHandler>k__BackingField  // 0x38
  private           UnityEngine.Rendering.UI.DebugUIHandlerWidget<previousUIHandler>k__BackingField  // 0x40
  private           UnityEngine.Rendering.UI.DebugUIHandlerWidget<nextUIHandler>k__BackingField  // 0x48
  protected         UnityEngine.Rendering.DebugUI.Widgetm_Widget  // 0x50
METHODS:
  UnityEngine.Rendering.UI.DebugUIHandlerWidget get_parentUIHandler()
  System.Void set_parentUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value)
  UnityEngine.Rendering.UI.DebugUIHandlerWidget get_previousUIHandler()
  System.Void set_previousUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value)
  UnityEngine.Rendering.UI.DebugUIHandlerWidget get_nextUIHandler()
  System.Void set_nextUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value)
  System.Void OnEnable()
  System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget)
  UnityEngine.Rendering.DebugUI.Widget GetWidget()
  T CastWidget()
  System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous)
  System.Void OnDeselection()
  System.Void OnAction()
  System.Void OnIncrement(System.Boolean fast)
  System.Void OnDecrement(System.Boolean fast)
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Previous()
  UnityEngine.Rendering.UI.DebugUIHandlerWidget Next()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.UI.UIFoldout
TYPE:  class
TOKEN: 0x2000194
EXTENDS: Toggle
FIELDS:
  public            UnityEngine.GameObject          content  // 0x1A8
  public            UnityEngine.GameObject          arrowOpened  // 0x1B0
  public            UnityEngine.GameObject          arrowClosed  // 0x1B8
METHODS:
  System.Void Start()
  System.Void OnValidate()
  System.Void SetState(System.Boolean state)
  System.Void SetState(System.Boolean state, System.Boolean rebuildLayout)
  System.Void .ctor()
END_CLASS

