// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIElementsNativeModule.dll
// Classes:  32
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: GPUBufferType
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.Utility.GPUBufferTypeVertex  // 0x0
  public    static  UnityEngine.UIElements.UIR.Utility.GPUBufferTypeIndex  // 0x0
METHODS:
END_CLASS

CLASS: GPUBuffer`1
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  private           System.IntPtr                   buffer  // 0x0
  private           System.Int32                    elemCount  // 0x0
  private           System.Int32                    elemStride  // 0x0
METHODS:
  System.Void .ctor(System.Int32 elementCount, UnityEngine.UIElements.UIR.Utility.GPUBufferType type)
  System.Void Dispose()
  System.Void UpdateRanges(Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> ranges, System.Int32 rangesMin, System.Int32 rangesMax)
  System.Int32 get_ElementStride()
  System.IntPtr get_BufferPointer()
END_CLASS

CLASS: UnityEngine.UIElements.TextNativeSettings
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.String                   text  // 0x10
  public            UnityEngine.Font                font  // 0x18
  public            System.Int32                    size  // 0x20
  public            System.Single                   scaling  // 0x24
  public            UnityEngine.FontStyle           style  // 0x28
  public            UnityEngine.Color               color  // 0x2C
  public            UnityEngine.TextAnchor          anchor  // 0x3C
  public            System.Boolean                  wordWrap  // 0x40
  public            System.Single                   wordWrapWidth  // 0x44
  public            System.Boolean                  richText  // 0x48
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TextVertex
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Color32             color  // 0x1C
  public            UnityEngine.Vector2             uv0  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TextNative
TYPE:  class
TOKEN: 0x200001A
FIELDS:
METHODS:
  UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, System.Int32 cursorIndex)
  System.Single ComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings)
  System.Single ComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings)
  Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.TextNativeSettings settings)
  UnityEngine.Vector2 GetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect screenRect)
  System.Single ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, System.Single pixelsPerPoint)
  System.Single DoComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings)
  System.Single DoComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings)
  UnityEngine.Vector2 DoGetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, System.Int32 cursorPosition)
  System.Void GetVertices(UnityEngine.UIElements.TextNativeSettings settings, System.IntPtr buffer, System.Int32 vertexSize, System.Int32& vertexCount)
  UnityEngine.Vector2 DoGetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect)
  System.Single DoComputeTextWidth_Injected(UnityEngine.UIElements.TextNativeSettings& settings)
  System.Single DoComputeTextHeight_Injected(UnityEngine.UIElements.TextNativeSettings& settings)
  System.Void DoGetCursorPosition_Injected(UnityEngine.UIElements.TextNativeSettings& settings, UnityEngine.Rect& rect, System.Int32 cursorPosition, UnityEngine.Vector2& ret)
  System.Void GetVertices_Injected(UnityEngine.UIElements.TextNativeSettings& settings, System.IntPtr buffer, System.Int32 vertexSize, System.Int32& vertexCount)
  System.Void DoGetOffset_Injected(UnityEngine.UIElements.TextNativeSettings& settings, UnityEngine.Rect& rect, UnityEngine.Vector2& ret)
END_CLASS

CLASS: UnityEngine.UIElements.UIElementsRuntimeUtilityNative
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  private   static  System.Action                   RepaintOverlayPanelsCallback  // 0x0
  private   static  System.Action                   UpdateRuntimePanelsCallback  // 0x8
  private   static  System.Action                   RepaintOffscreenPanelsCallback  // 0x10
METHODS:
  System.Void RepaintOverlayPanels()
  System.Void UpdateRuntimePanels()
  System.Void RepaintOffscreenPanels()
  System.Void RegisterPlayerloopCallback()
  System.Void UnregisterPlayerloopCallback()
  System.Void VisualElementCreation()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.GfxUpdateBufferRange
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.UInt32                   offsetFromWriteStart  // 0x10
  public            System.UInt32                   size  // 0x14
  public            System.UIntPtr                  source  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.DrawBufferRange
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    firstIndex  // 0x10
  public            System.Int32                    indexCount  // 0x14
  public            System.Int32                    minIndexVal  // 0x18
  public            System.Int32                    vertsReferenced  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Utility
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  private   static  System.Action<System.Boolean>   GraphicsResourcesRecreate  // 0x0
  private   static  System.Action                   EngineUpdate  // 0x8
  private   static  System.Action                   FlushPendingResources  // 0x10
  private   static  System.Action<UnityEngine.Camera>RegisterIntermediateRenderers  // 0x18
  private   static  System.Action<System.IntPtr>    RenderNodeAdd  // 0x20
  private   static  System.Action<System.IntPtr>    RenderNodeExecute  // 0x28
  private   static  System.Action<System.IntPtr>    RenderNodeCleanup  // 0x30
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerRaiseEngineUpdate  // 0x38
METHODS:
  System.Void SetVectorArray(UnityEngine.MaterialPropertyBlock props, System.Int32 name, Unity.Collections.NativeSlice<T> vector4s)
  System.Void add_GraphicsResourcesRecreate(System.Action<System.Boolean> value)
  System.Void remove_GraphicsResourcesRecreate(System.Action<System.Boolean> value)
  System.Void add_EngineUpdate(System.Action value)
  System.Void remove_EngineUpdate(System.Action value)
  System.Void add_FlushPendingResources(System.Action value)
  System.Void remove_FlushPendingResources(System.Action value)
  System.Void add_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value)
  System.Void remove_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value)
  System.Void add_RenderNodeExecute(System.Action<System.IntPtr> value)
  System.Void remove_RenderNodeExecute(System.Action<System.IntPtr> value)
  System.Void RaiseGraphicsResourcesRecreate(System.Boolean recreate)
  System.Void RaiseEngineUpdate()
  System.Void RaiseFlushPendingResources()
  System.Void RaiseRegisterIntermediateRenderers(UnityEngine.Camera camera)
  System.Void RaiseRenderNodeAdd(System.IntPtr userData)
  System.Void RaiseRenderNodeExecute(System.IntPtr userData)
  System.Void RaiseRenderNodeCleanup(System.IntPtr userData)
  System.IntPtr AllocateBuffer(System.Int32 elementCount, System.Int32 elementStride, System.Boolean vertexBuffer)
  System.Void FreeBuffer(System.IntPtr buffer)
  System.Void UpdateBufferRanges(System.IntPtr buffer, System.IntPtr ranges, System.Int32 rangeCount, System.Int32 writeRangeStart, System.Int32 writeRangeEnd)
  System.Void SetVectorArray(UnityEngine.MaterialPropertyBlock props, System.Int32 name, System.IntPtr vector4s, System.Int32 count)
  System.IntPtr GetVertexDeclaration(UnityEngine.Rendering.VertexAttributeDescriptor[] vertexAttributes)
  System.Void RegisterIntermediateRenderer(UnityEngine.Camera camera, UnityEngine.Material material, UnityEngine.Matrix4x4 transform, UnityEngine.Bounds aabb, System.Int32 renderLayer, System.Int32 shadowCasting, System.Boolean receiveShadows, System.Int32 sameDistanceSortPriority, System.UInt64 sceneCullingMask, System.Int32 rendererCallbackFlags, System.IntPtr userData, System.Int32 userDataSize)
  System.Void DrawRanges(System.IntPtr ib, System.IntPtr* vertexStreams, System.Int32 streamCount, System.IntPtr ranges, System.Int32 rangeCount, System.IntPtr vertexDecl)
  System.Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock props)
  System.Void SetScissorRect(UnityEngine.RectInt scissorRect)
  System.Void DisableScissor()
  System.IntPtr CreateStencilState(UnityEngine.Rendering.StencilState stencilState)
  System.Void SetStencilState(System.IntPtr stencilState, System.Int32 stencilRef)
  System.Boolean HasMappedBufferRange()
  System.UInt32 InsertCPUFence()
  System.Boolean CPUFencePassed(System.UInt32 fence)
  System.Void WaitForCPUFencePassed(System.UInt32 fence)
  System.Void SyncRenderThread()
  UnityEngine.RectInt GetActiveViewport()
  System.Void ProfileDrawChainBegin()
  System.Void ProfileDrawChainEnd()
  System.Void NotifyOfUIREvents(System.Boolean subscribe)
  UnityEngine.Matrix4x4 GetUnityProjectionMatrix()
  System.Void .cctor()
  System.Void RegisterIntermediateRenderer_Injected(UnityEngine.Camera camera, UnityEngine.Material material, UnityEngine.Matrix4x4& transform, UnityEngine.Bounds& aabb, System.Int32 renderLayer, System.Int32 shadowCasting, System.Boolean receiveShadows, System.Int32 sameDistanceSortPriority, System.UInt64 sceneCullingMask, System.Int32 rendererCallbackFlags, System.IntPtr userData, System.Int32 userDataSize)
  System.Void SetScissorRect_Injected(UnityEngine.RectInt& scissorRect)
  System.IntPtr CreateStencilState_Injected(UnityEngine.Rendering.StencilState& stencilState)
  System.Void GetActiveViewport_Injected(UnityEngine.RectInt& ret)
  System.Void GetUnityProjectionMatrix_Injected(UnityEngine.Matrix4x4& ret)
END_CLASS

CLASS: UnityEngine.Yoga.BaselineFunction
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Single Invoke(UnityEngine.Yoga.YogaNode node, System.Single width, System.Single height)
END_CLASS

CLASS: UnityEngine.Yoga.Logger
TYPE:  class
TOKEN: 0x2000003
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Yoga.YogaConfig config, UnityEngine.Yoga.YogaNode node, UnityEngine.Yoga.YogaLogLevel level, System.String message)
END_CLASS

CLASS: UnityEngine.Yoga.MeasureFunction
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.Yoga.YogaSize Invoke(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode)
END_CLASS

CLASS: UnityEngine.Yoga.MeasureOutput
TYPE:  class
TOKEN: 0x2000005
FIELDS:
METHODS:
  UnityEngine.Yoga.YogaSize Make(System.Single width, System.Single height)
END_CLASS

CLASS: UnityEngine.Yoga.YogaAlign
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaAlign      Auto  // 0x0
  public    static  UnityEngine.Yoga.YogaAlign      FlexStart  // 0x0
  public    static  UnityEngine.Yoga.YogaAlign      Center  // 0x0
  public    static  UnityEngine.Yoga.YogaAlign      FlexEnd  // 0x0
  public    static  UnityEngine.Yoga.YogaAlign      Stretch  // 0x0
  public    static  UnityEngine.Yoga.YogaAlign      Baseline  // 0x0
  public    static  UnityEngine.Yoga.YogaAlign      SpaceBetween  // 0x0
  public    static  UnityEngine.Yoga.YogaAlign      SpaceAround  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaConfig
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static readonly UnityEngine.Yoga.YogaConfig     Default  // 0x0
  private           System.IntPtr                   _ygConfig  // 0x10
  private           UnityEngine.Yoga.Logger         _logger  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr ygConfig)
  System.Void .ctor()
  System.Void Finalize()
  System.IntPtr get_Handle()
  System.Boolean get_UseWebDefaults()
  System.Void set_UseWebDefaults(System.Boolean value)
  System.Void set_PointScaleFactor(System.Single value)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Yoga.YogaConstants
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Boolean IsUndefined(System.Single value)
END_CLASS

CLASS: UnityEngine.Yoga.YogaDirection
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaDirection  Inherit  // 0x0
  public    static  UnityEngine.Yoga.YogaDirection  LTR  // 0x0
  public    static  UnityEngine.Yoga.YogaDirection  RTL  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaDisplay
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaDisplay    Flex  // 0x0
  public    static  UnityEngine.Yoga.YogaDisplay    None  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaEdge
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaEdge       Left  // 0x0
  public    static  UnityEngine.Yoga.YogaEdge       Top  // 0x0
  public    static  UnityEngine.Yoga.YogaEdge       Right  // 0x0
  public    static  UnityEngine.Yoga.YogaEdge       Bottom  // 0x0
  public    static  UnityEngine.Yoga.YogaEdge       Start  // 0x0
  public    static  UnityEngine.Yoga.YogaEdge       End  // 0x0
  public    static  UnityEngine.Yoga.YogaEdge       Horizontal  // 0x0
  public    static  UnityEngine.Yoga.YogaEdge       Vertical  // 0x0
  public    static  UnityEngine.Yoga.YogaEdge       All  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaFlexDirection
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaFlexDirectionColumn  // 0x0
  public    static  UnityEngine.Yoga.YogaFlexDirectionColumnReverse  // 0x0
  public    static  UnityEngine.Yoga.YogaFlexDirectionRow  // 0x0
  public    static  UnityEngine.Yoga.YogaFlexDirectionRowReverse  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaJustify
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaJustify    FlexStart  // 0x0
  public    static  UnityEngine.Yoga.YogaJustify    Center  // 0x0
  public    static  UnityEngine.Yoga.YogaJustify    FlexEnd  // 0x0
  public    static  UnityEngine.Yoga.YogaJustify    SpaceBetween  // 0x0
  public    static  UnityEngine.Yoga.YogaJustify    SpaceAround  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaLogLevel
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaLogLevel   Error  // 0x0
  public    static  UnityEngine.Yoga.YogaLogLevel   Warn  // 0x0
  public    static  UnityEngine.Yoga.YogaLogLevel   Info  // 0x0
  public    static  UnityEngine.Yoga.YogaLogLevel   Debug  // 0x0
  public    static  UnityEngine.Yoga.YogaLogLevel   Verbose  // 0x0
  public    static  UnityEngine.Yoga.YogaLogLevel   Fatal  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaMeasureMode
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaMeasureModeUndefined  // 0x0
  public    static  UnityEngine.Yoga.YogaMeasureModeExactly  // 0x0
  public    static  UnityEngine.Yoga.YogaMeasureModeAtMost  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.Native
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.IntPtr YGNodeNewWithConfig(System.IntPtr config)
  System.Void YGNodeFree(System.IntPtr ygNode)
  System.Void YGNodeFreeInternal(System.IntPtr ygNode)
  System.Void YGSetManagedObject(System.IntPtr ygNode, UnityEngine.Yoga.YogaNode node)
  System.Void YGNodeSetConfig(System.IntPtr ygNode, System.IntPtr config)
  System.IntPtr YGConfigGetDefault()
  System.IntPtr YGConfigNew()
  System.Void YGConfigFree(System.IntPtr config)
  System.Void YGConfigFreeInternal(System.IntPtr config)
  System.Void YGConfigSetUseWebDefaults(System.IntPtr config, System.Boolean useWebDefaults)
  System.Boolean YGConfigGetUseWebDefaults(System.IntPtr config)
  System.Void YGConfigSetPointScaleFactor(System.IntPtr config, System.Single pixelsInPoint)
  System.Void YGNodeInsertChild(System.IntPtr node, System.IntPtr child, System.UInt32 index)
  System.Void YGNodeRemoveChild(System.IntPtr node, System.IntPtr child)
  System.Void YGNodeCalculateLayout(System.IntPtr node, System.Single availableWidth, System.Single availableHeight, UnityEngine.Yoga.YogaDirection parentDirection)
  System.Void YGNodeMarkDirty(System.IntPtr node)
  System.Boolean YGNodeIsDirty(System.IntPtr node)
  System.Void YGNodeCopyStyle(System.IntPtr dstNode, System.IntPtr srcNode)
  System.Void YGNodeSetMeasureFunc(System.IntPtr node)
  System.Void YGNodeRemoveMeasureFunc(System.IntPtr node)
  System.Void YGNodeMeasureInvoke(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode, System.IntPtr returnValueAddress)
  System.Void YGNodeBaselineInvoke(UnityEngine.Yoga.YogaNode node, System.Single width, System.Single height, System.IntPtr returnValueAddress)
  System.Void YGNodeSetHasNewLayout(System.IntPtr node, System.Boolean hasNewLayout)
  System.Boolean YGNodeGetHasNewLayout(System.IntPtr node)
  UnityEngine.Yoga.YogaDirection YGNodeStyleGetDirection(System.IntPtr node)
  System.Void YGNodeStyleSetFlexDirection(System.IntPtr node, UnityEngine.Yoga.YogaFlexDirection flexDirection)
  System.Void YGNodeStyleSetJustifyContent(System.IntPtr node, UnityEngine.Yoga.YogaJustify justifyContent)
  System.Void YGNodeStyleSetAlignContent(System.IntPtr node, UnityEngine.Yoga.YogaAlign alignContent)
  System.Void YGNodeStyleSetAlignItems(System.IntPtr node, UnityEngine.Yoga.YogaAlign alignItems)
  System.Void YGNodeStyleSetAlignSelf(System.IntPtr node, UnityEngine.Yoga.YogaAlign alignSelf)
  System.Void YGNodeStyleSetPositionType(System.IntPtr node, UnityEngine.Yoga.YogaPositionType positionType)
  System.Void YGNodeStyleSetFlexWrap(System.IntPtr node, UnityEngine.Yoga.YogaWrap flexWrap)
  System.Void YGNodeStyleSetOverflow(System.IntPtr node, UnityEngine.Yoga.YogaOverflow flexWrap)
  System.Void YGNodeStyleSetDisplay(System.IntPtr node, UnityEngine.Yoga.YogaDisplay display)
  System.Void YGNodeStyleSetFlex(System.IntPtr node, System.Single flex)
  System.Void YGNodeStyleSetFlexGrow(System.IntPtr node, System.Single flexGrow)
  System.Void YGNodeStyleSetFlexShrink(System.IntPtr node, System.Single flexShrink)
  System.Void YGNodeStyleSetFlexBasis(System.IntPtr node, System.Single flexBasis)
  System.Void YGNodeStyleSetFlexBasisPercent(System.IntPtr node, System.Single flexBasis)
  System.Void YGNodeStyleSetFlexBasisAuto(System.IntPtr node)
  System.Void YGNodeStyleSetWidth(System.IntPtr node, System.Single width)
  System.Void YGNodeStyleSetWidthPercent(System.IntPtr node, System.Single width)
  System.Void YGNodeStyleSetWidthAuto(System.IntPtr node)
  System.Void YGNodeStyleSetHeight(System.IntPtr node, System.Single height)
  System.Void YGNodeStyleSetHeightPercent(System.IntPtr node, System.Single height)
  System.Void YGNodeStyleSetHeightAuto(System.IntPtr node)
  System.Void YGNodeStyleSetMinWidth(System.IntPtr node, System.Single minWidth)
  System.Void YGNodeStyleSetMinWidthPercent(System.IntPtr node, System.Single minWidth)
  System.Void YGNodeStyleSetMinHeight(System.IntPtr node, System.Single minHeight)
  System.Void YGNodeStyleSetMinHeightPercent(System.IntPtr node, System.Single minHeight)
  System.Void YGNodeStyleSetMaxWidth(System.IntPtr node, System.Single maxWidth)
  System.Void YGNodeStyleSetMaxWidthPercent(System.IntPtr node, System.Single maxWidth)
  System.Void YGNodeStyleSetMaxHeight(System.IntPtr node, System.Single maxHeight)
  System.Void YGNodeStyleSetMaxHeightPercent(System.IntPtr node, System.Single maxHeight)
  System.Void YGNodeStyleSetPosition(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single position)
  System.Void YGNodeStyleSetPositionPercent(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single position)
  System.Void YGNodeStyleSetMargin(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single margin)
  System.Void YGNodeStyleSetMarginPercent(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single margin)
  System.Void YGNodeStyleSetMarginAuto(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge)
  System.Void YGNodeStyleSetPadding(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single padding)
  System.Void YGNodeStyleSetPaddingPercent(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single padding)
  System.Void YGNodeStyleSetBorder(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single border)
  System.Single YGNodeLayoutGetLeft(System.IntPtr node)
  System.Single YGNodeLayoutGetTop(System.IntPtr node)
  System.Single YGNodeLayoutGetRight(System.IntPtr node)
  System.Single YGNodeLayoutGetBottom(System.IntPtr node)
  System.Single YGNodeLayoutGetWidth(System.IntPtr node)
  System.Single YGNodeLayoutGetHeight(System.IntPtr node)
  System.Single YGNodeLayoutGetMargin(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge)
  System.Single YGNodeLayoutGetPadding(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge)
  System.Single YGNodeLayoutGetBorder(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge)
END_CLASS

CLASS: UnityEngine.Yoga.YogaNode
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           System.IntPtr                   _ygNode  // 0x10
  private           UnityEngine.Yoga.YogaConfig     _config  // 0x18
  private           System.WeakReference            _parent  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Yoga.YogaNode>_children  // 0x28
  private           UnityEngine.Yoga.MeasureFunction_measureFunction  // 0x30
  private           UnityEngine.Yoga.BaselineFunction_baselineFunction  // 0x38
  private           System.Object                   _data  // 0x40
METHODS:
  System.Void .ctor(UnityEngine.Yoga.YogaConfig config)
  System.Void Finalize()
  System.Void set_Config(UnityEngine.Yoga.YogaConfig value)
  System.Boolean get_IsDirty()
  System.Void MarkDirty()
  System.Boolean get_HasNewLayout()
  System.Boolean get_IsMeasureDefined()
  System.Boolean get_IsBaselineDefined()
  System.Void CopyStyle(UnityEngine.Yoga.YogaNode srcNode)
  System.Void set_FlexDirection(UnityEngine.Yoga.YogaFlexDirection value)
  System.Void set_JustifyContent(UnityEngine.Yoga.YogaJustify value)
  System.Void set_Display(UnityEngine.Yoga.YogaDisplay value)
  System.Void set_AlignItems(UnityEngine.Yoga.YogaAlign value)
  System.Void set_AlignSelf(UnityEngine.Yoga.YogaAlign value)
  System.Void set_AlignContent(UnityEngine.Yoga.YogaAlign value)
  System.Void set_PositionType(UnityEngine.Yoga.YogaPositionType value)
  System.Void set_Wrap(UnityEngine.Yoga.YogaWrap value)
  System.Void set_Flex(System.Single value)
  System.Void set_FlexGrow(System.Single value)
  System.Void set_FlexShrink(System.Single value)
  System.Void set_FlexBasis(UnityEngine.Yoga.YogaValue value)
  System.Void set_Width(UnityEngine.Yoga.YogaValue value)
  System.Void set_Height(UnityEngine.Yoga.YogaValue value)
  System.Void set_MaxWidth(UnityEngine.Yoga.YogaValue value)
  System.Void set_MaxHeight(UnityEngine.Yoga.YogaValue value)
  System.Void set_MinWidth(UnityEngine.Yoga.YogaValue value)
  System.Void set_MinHeight(UnityEngine.Yoga.YogaValue value)
  System.Single get_LayoutX()
  System.Single get_LayoutY()
  System.Single get_LayoutRight()
  System.Single get_LayoutBottom()
  System.Single get_LayoutWidth()
  System.Single get_LayoutHeight()
  System.Void set_Overflow(UnityEngine.Yoga.YogaOverflow value)
  System.Int32 get_Count()
  System.Void MarkLayoutSeen()
  System.Void Insert(System.Int32 index, UnityEngine.Yoga.YogaNode node)
  System.Void RemoveAt(System.Int32 index)
  System.Void Clear()
  System.Void SetMeasureFunction(UnityEngine.Yoga.MeasureFunction measureFunction)
  System.Void CalculateLayout(System.Single width, System.Single height)
  UnityEngine.Yoga.YogaSize MeasureInternal(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode)
  System.Single BaselineInternal(UnityEngine.Yoga.YogaNode node, System.Single width, System.Single height)
  System.Collections.Generic.IEnumerator<UnityEngine.Yoga.YogaNode> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void set_Left(UnityEngine.Yoga.YogaValue value)
  System.Void set_Top(UnityEngine.Yoga.YogaValue value)
  System.Void set_Right(UnityEngine.Yoga.YogaValue value)
  System.Void set_Bottom(UnityEngine.Yoga.YogaValue value)
  System.Void SetStylePosition(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value)
  System.Void set_MarginLeft(UnityEngine.Yoga.YogaValue value)
  System.Void set_MarginTop(UnityEngine.Yoga.YogaValue value)
  System.Void set_MarginRight(UnityEngine.Yoga.YogaValue value)
  System.Void set_MarginBottom(UnityEngine.Yoga.YogaValue value)
  System.Void SetStyleMargin(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value)
  System.Void set_PaddingLeft(UnityEngine.Yoga.YogaValue value)
  System.Void set_PaddingTop(UnityEngine.Yoga.YogaValue value)
  System.Void set_PaddingRight(UnityEngine.Yoga.YogaValue value)
  System.Void set_PaddingBottom(UnityEngine.Yoga.YogaValue value)
  System.Void SetStylePadding(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value)
  System.Void set_BorderLeftWidth(System.Single value)
  System.Void set_BorderTopWidth(System.Single value)
  System.Void set_BorderRightWidth(System.Single value)
  System.Void set_BorderBottomWidth(System.Single value)
  System.Single get_LayoutMarginLeft()
  System.Single get_LayoutMarginTop()
  System.Single get_LayoutMarginRight()
  System.Single get_LayoutMarginBottom()
  System.Single get_LayoutPaddingLeft()
  System.Single get_LayoutPaddingTop()
  System.Single get_LayoutPaddingRight()
  System.Single get_LayoutPaddingBottom()
  System.Single get_LayoutBorderLeft()
  System.Single get_LayoutBorderTop()
  System.Single get_LayoutBorderRight()
  System.Single get_LayoutBorderBottom()
END_CLASS

CLASS: UnityEngine.Yoga.YogaOverflow
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaOverflow   Visible  // 0x0
  public    static  UnityEngine.Yoga.YogaOverflow   Hidden  // 0x0
  public    static  UnityEngine.Yoga.YogaOverflow   Scroll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaPositionType
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaPositionTypeRelative  // 0x0
  public    static  UnityEngine.Yoga.YogaPositionTypeAbsolute  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaSize
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Single                   width  // 0x10
  public            System.Single                   height  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaUnit
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaUnit       Undefined  // 0x0
  public    static  UnityEngine.Yoga.YogaUnit       Point  // 0x0
  public    static  UnityEngine.Yoga.YogaUnit       Percent  // 0x0
  public    static  UnityEngine.Yoga.YogaUnit       Auto  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Yoga.YogaValue
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  private           System.Single                   value  // 0x10
  private           UnityEngine.Yoga.YogaUnit       unit  // 0x14
METHODS:
  UnityEngine.Yoga.YogaUnit get_Unit()
  System.Single get_Value()
  UnityEngine.Yoga.YogaValue Point(System.Single value)
  System.Boolean Equals(UnityEngine.Yoga.YogaValue other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  UnityEngine.Yoga.YogaValue Auto()
  UnityEngine.Yoga.YogaValue Percent(System.Single value)
  UnityEngine.Yoga.YogaValue op_Implicit(System.Single pointValue)
END_CLASS

CLASS: UnityEngine.Yoga.YogaWrap
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Yoga.YogaWrap       NoWrap  // 0x0
  public    static  UnityEngine.Yoga.YogaWrap       Wrap  // 0x0
  public    static  UnityEngine.Yoga.YogaWrap       WrapReverse  // 0x0
METHODS:
END_CLASS

