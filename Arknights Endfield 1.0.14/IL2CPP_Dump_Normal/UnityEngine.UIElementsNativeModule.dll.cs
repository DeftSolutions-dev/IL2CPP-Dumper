// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIElementsNativeModule.dll
// Classes:  32
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200001F
    public struct GPUBufferType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UIR.Utility.GPUBufferType Vertex;        // 0x0
        public static UnityEngine.UIElements.UIR.Utility.GPUBufferType Index;        // 0x0

    }

    // TypeToken: 0x2000020
    public class GPUBuffer`1, IDisposable
    {
        // Fields
        private System.IntPtr buffer;        // 0x0
        private System.Int32 elemCount;        // 0x0
        private System.Int32 elemStride;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 elementCount, UnityEngine.UIElements.UIR.Utility.GPUBufferType type) { }
        private System.Void Dispose() { }
        private System.Void UpdateRanges(Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> ranges, System.Int32 rangesMin, System.Int32 rangesMax) { }
        private System.Int32 get_ElementStride() { }
        private System.IntPtr get_BufferPointer() { }

    }

namespace UnityEngine.UIElements
{

    // TypeToken: 0x2000018
    public struct TextNativeSettings
    {
        // Fields
        public System.String text;        // 0x10
        public UnityEngine.Font font;        // 0x18
        public System.Int32 size;        // 0x20
        public System.Single scaling;        // 0x24
        public UnityEngine.FontStyle style;        // 0x28
        public UnityEngine.Color color;        // 0x2C
        public UnityEngine.TextAnchor anchor;        // 0x3C
        public System.Boolean wordWrap;        // 0x40
        public System.Single wordWrapWidth;        // 0x44
        public System.Boolean richText;        // 0x48

    }

    // TypeToken: 0x2000019
    public struct TextVertex
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Color32 color;        // 0x1C
        public UnityEngine.Vector2 uv0;        // 0x20

    }

    // TypeToken: 0x200001A
    public class TextNative
    {
        // Methods
        private UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, System.Int32 cursorIndex) { }
        private System.Single ComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings) { }
        private System.Single ComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings) { }
        private Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.TextNativeSettings settings) { }
        private UnityEngine.Vector2 GetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect screenRect) { }
        private System.Single ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, System.Single pixelsPerPoint) { }
        private System.Single DoComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings) { }
        private System.Single DoComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings) { }
        private UnityEngine.Vector2 DoGetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, System.Int32 cursorPosition) { }
        private System.Void GetVertices(UnityEngine.UIElements.TextNativeSettings settings, System.IntPtr buffer, System.Int32 vertexSize, System.Int32& vertexCount) { }
        private UnityEngine.Vector2 DoGetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect) { }
        private System.Single DoComputeTextWidth_Injected(UnityEngine.UIElements.TextNativeSettings& settings) { }
        private System.Single DoComputeTextHeight_Injected(UnityEngine.UIElements.TextNativeSettings& settings) { }
        private System.Void DoGetCursorPosition_Injected(UnityEngine.UIElements.TextNativeSettings& settings, UnityEngine.Rect& rect, System.Int32 cursorPosition, UnityEngine.Vector2& ret) { }
        private System.Void GetVertices_Injected(UnityEngine.UIElements.TextNativeSettings& settings, System.IntPtr buffer, System.Int32 vertexSize, System.Int32& vertexCount) { }
        private System.Void DoGetOffset_Injected(UnityEngine.UIElements.TextNativeSettings& settings, UnityEngine.Rect& rect, UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x200001B
    public class UIElementsRuntimeUtilityNative
    {
        // Fields
        private static System.Action RepaintOverlayPanelsCallback;        // 0x0
        private static System.Action UpdateRuntimePanelsCallback;        // 0x8
        private static System.Action RepaintOffscreenPanelsCallback;        // 0x10

        // Methods
        private System.Void RepaintOverlayPanels() { }
        private System.Void UpdateRuntimePanels() { }
        private System.Void RepaintOffscreenPanels() { }
        private System.Void RegisterPlayerloopCallback() { }
        private System.Void UnregisterPlayerloopCallback() { }
        private System.Void VisualElementCreation() { }

    }

}

namespace UnityEngine.UIElements.UIR
{

    // TypeToken: 0x200001C
    public struct GfxUpdateBufferRange
    {
        // Fields
        public System.UInt32 offsetFromWriteStart;        // 0x10
        public System.UInt32 size;        // 0x14
        public System.UIntPtr source;        // 0x18

    }

    // TypeToken: 0x200001D
    public struct DrawBufferRange
    {
        // Fields
        public System.Int32 firstIndex;        // 0x10
        public System.Int32 indexCount;        // 0x14
        public System.Int32 minIndexVal;        // 0x18
        public System.Int32 vertsReferenced;        // 0x1C

    }

    // TypeToken: 0x200001E
    public class Utility
    {
        // Fields
        private static System.Action<System.Boolean> GraphicsResourcesRecreate;        // 0x0
        private static System.Action EngineUpdate;        // 0x8
        private static System.Action FlushPendingResources;        // 0x10
        private static System.Action<UnityEngine.Camera> RegisterIntermediateRenderers;        // 0x18
        private static System.Action<System.IntPtr> RenderNodeAdd;        // 0x20
        private static System.Action<System.IntPtr> RenderNodeExecute;        // 0x28
        private static System.Action<System.IntPtr> RenderNodeCleanup;        // 0x30
        private static Unity.Profiling.ProfilerMarker s_MarkerRaiseEngineUpdate;        // 0x38

        // Methods
        private System.Void SetVectorArray(UnityEngine.MaterialPropertyBlock props, System.Int32 name, Unity.Collections.NativeSlice<T> vector4s) { }
        private System.Void add_GraphicsResourcesRecreate(System.Action<System.Boolean> value) { }
        private System.Void remove_GraphicsResourcesRecreate(System.Action<System.Boolean> value) { }
        private System.Void add_EngineUpdate(System.Action value) { }
        private System.Void remove_EngineUpdate(System.Action value) { }
        private System.Void add_FlushPendingResources(System.Action value) { }
        private System.Void remove_FlushPendingResources(System.Action value) { }
        private System.Void add_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value) { }
        private System.Void remove_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value) { }
        private System.Void add_RenderNodeExecute(System.Action<System.IntPtr> value) { }
        private System.Void remove_RenderNodeExecute(System.Action<System.IntPtr> value) { }
        private System.Void RaiseGraphicsResourcesRecreate(System.Boolean recreate) { }
        private System.Void RaiseEngineUpdate() { }
        private System.Void RaiseFlushPendingResources() { }
        private System.Void RaiseRegisterIntermediateRenderers(UnityEngine.Camera camera) { }
        private System.Void RaiseRenderNodeAdd(System.IntPtr userData) { }
        private System.Void RaiseRenderNodeExecute(System.IntPtr userData) { }
        private System.Void RaiseRenderNodeCleanup(System.IntPtr userData) { }
        private System.IntPtr AllocateBuffer(System.Int32 elementCount, System.Int32 elementStride, System.Boolean vertexBuffer) { }
        private System.Void FreeBuffer(System.IntPtr buffer) { }
        private System.Void UpdateBufferRanges(System.IntPtr buffer, System.IntPtr ranges, System.Int32 rangeCount, System.Int32 writeRangeStart, System.Int32 writeRangeEnd) { }
        private System.Void SetVectorArray(UnityEngine.MaterialPropertyBlock props, System.Int32 name, System.IntPtr vector4s, System.Int32 count) { }
        private System.IntPtr GetVertexDeclaration(UnityEngine.Rendering.VertexAttributeDescriptor[] vertexAttributes) { }
        private System.Void RegisterIntermediateRenderer(UnityEngine.Camera camera, UnityEngine.Material material, UnityEngine.Matrix4x4 transform, UnityEngine.Bounds aabb, System.Int32 renderLayer, System.Int32 shadowCasting, System.Boolean receiveShadows, System.Int32 sameDistanceSortPriority, System.UInt64 sceneCullingMask, System.Int32 rendererCallbackFlags, System.IntPtr userData, System.Int32 userDataSize) { }
        private System.Void DrawRanges(System.IntPtr ib, System.IntPtr* vertexStreams, System.Int32 streamCount, System.IntPtr ranges, System.Int32 rangeCount, System.IntPtr vertexDecl) { }
        private System.Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock props) { }
        private System.Void SetScissorRect(UnityEngine.RectInt scissorRect) { }
        private System.Void DisableScissor() { }
        private System.IntPtr CreateStencilState(UnityEngine.Rendering.StencilState stencilState) { }
        private System.Void SetStencilState(System.IntPtr stencilState, System.Int32 stencilRef) { }
        private System.Boolean HasMappedBufferRange() { }
        private System.UInt32 InsertCPUFence() { }
        private System.Boolean CPUFencePassed(System.UInt32 fence) { }
        private System.Void WaitForCPUFencePassed(System.UInt32 fence) { }
        private System.Void SyncRenderThread() { }
        private UnityEngine.RectInt GetActiveViewport() { }
        private System.Void ProfileDrawChainBegin() { }
        private System.Void ProfileDrawChainEnd() { }
        private System.Void NotifyOfUIREvents(System.Boolean subscribe) { }
        private UnityEngine.Matrix4x4 GetUnityProjectionMatrix() { }
        private System.Void .cctor() { }
        private System.Void RegisterIntermediateRenderer_Injected(UnityEngine.Camera camera, UnityEngine.Material material, UnityEngine.Matrix4x4& transform, UnityEngine.Bounds& aabb, System.Int32 renderLayer, System.Int32 shadowCasting, System.Boolean receiveShadows, System.Int32 sameDistanceSortPriority, System.UInt64 sceneCullingMask, System.Int32 rendererCallbackFlags, System.IntPtr userData, System.Int32 userDataSize) { }
        private System.Void SetScissorRect_Injected(UnityEngine.RectInt& scissorRect) { }
        private System.IntPtr CreateStencilState_Injected(UnityEngine.Rendering.StencilState& stencilState) { }
        private System.Void GetActiveViewport_Injected(UnityEngine.RectInt& ret) { }
        private System.Void GetUnityProjectionMatrix_Injected(UnityEngine.Matrix4x4& ret) { }

    }

}

namespace UnityEngine.Yoga
{

    // TypeToken: 0x2000002
    public class BaselineFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Single Invoke(UnityEngine.Yoga.YogaNode node, System.Single width, System.Single height) { }

    }

    // TypeToken: 0x2000003
    public class Logger : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Yoga.YogaConfig config, UnityEngine.Yoga.YogaNode node, UnityEngine.Yoga.YogaLogLevel level, System.String message) { }

    }

    // TypeToken: 0x2000004
    public class MeasureFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.Yoga.YogaSize Invoke(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode) { }

    }

    // TypeToken: 0x2000005
    public class MeasureOutput
    {
        // Methods
        private UnityEngine.Yoga.YogaSize Make(System.Single width, System.Single height) { }

    }

    // TypeToken: 0x2000006
    public struct YogaAlign
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaAlign Auto;        // 0x0
        public static UnityEngine.Yoga.YogaAlign FlexStart;        // 0x0
        public static UnityEngine.Yoga.YogaAlign Center;        // 0x0
        public static UnityEngine.Yoga.YogaAlign FlexEnd;        // 0x0
        public static UnityEngine.Yoga.YogaAlign Stretch;        // 0x0
        public static UnityEngine.Yoga.YogaAlign Baseline;        // 0x0
        public static UnityEngine.Yoga.YogaAlign SpaceBetween;        // 0x0
        public static UnityEngine.Yoga.YogaAlign SpaceAround;        // 0x0

    }

    // TypeToken: 0x2000007
    public class YogaConfig
    {
        // Fields
        private static readonly UnityEngine.Yoga.YogaConfig Default;        // 0x0
        private System.IntPtr _ygConfig;        // 0x10
        private UnityEngine.Yoga.Logger _logger;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr ygConfig) { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.IntPtr get_Handle() { }
        private System.Boolean get_UseWebDefaults() { }
        private System.Void set_UseWebDefaults(System.Boolean value) { }
        private System.Void set_PointScaleFactor(System.Single value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000008
    public class YogaConstants
    {
        // Methods
        private System.Boolean IsUndefined(System.Single value) { }

    }

    // TypeToken: 0x2000009
    public struct YogaDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaDirection Inherit;        // 0x0
        public static UnityEngine.Yoga.YogaDirection LTR;        // 0x0
        public static UnityEngine.Yoga.YogaDirection RTL;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct YogaDisplay
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaDisplay Flex;        // 0x0
        public static UnityEngine.Yoga.YogaDisplay None;        // 0x0

    }

    // TypeToken: 0x200000B
    public struct YogaEdge
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaEdge Left;        // 0x0
        public static UnityEngine.Yoga.YogaEdge Top;        // 0x0
        public static UnityEngine.Yoga.YogaEdge Right;        // 0x0
        public static UnityEngine.Yoga.YogaEdge Bottom;        // 0x0
        public static UnityEngine.Yoga.YogaEdge Start;        // 0x0
        public static UnityEngine.Yoga.YogaEdge End;        // 0x0
        public static UnityEngine.Yoga.YogaEdge Horizontal;        // 0x0
        public static UnityEngine.Yoga.YogaEdge Vertical;        // 0x0
        public static UnityEngine.Yoga.YogaEdge All;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct YogaFlexDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaFlexDirection Column;        // 0x0
        public static UnityEngine.Yoga.YogaFlexDirection ColumnReverse;        // 0x0
        public static UnityEngine.Yoga.YogaFlexDirection Row;        // 0x0
        public static UnityEngine.Yoga.YogaFlexDirection RowReverse;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct YogaJustify
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaJustify FlexStart;        // 0x0
        public static UnityEngine.Yoga.YogaJustify Center;        // 0x0
        public static UnityEngine.Yoga.YogaJustify FlexEnd;        // 0x0
        public static UnityEngine.Yoga.YogaJustify SpaceBetween;        // 0x0
        public static UnityEngine.Yoga.YogaJustify SpaceAround;        // 0x0

    }

    // TypeToken: 0x200000E
    public struct YogaLogLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaLogLevel Error;        // 0x0
        public static UnityEngine.Yoga.YogaLogLevel Warn;        // 0x0
        public static UnityEngine.Yoga.YogaLogLevel Info;        // 0x0
        public static UnityEngine.Yoga.YogaLogLevel Debug;        // 0x0
        public static UnityEngine.Yoga.YogaLogLevel Verbose;        // 0x0
        public static UnityEngine.Yoga.YogaLogLevel Fatal;        // 0x0

    }

    // TypeToken: 0x200000F
    public struct YogaMeasureMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaMeasureMode Undefined;        // 0x0
        public static UnityEngine.Yoga.YogaMeasureMode Exactly;        // 0x0
        public static UnityEngine.Yoga.YogaMeasureMode AtMost;        // 0x0

    }

    // TypeToken: 0x2000010
    public class Native
    {
        // Methods
        private System.IntPtr YGNodeNewWithConfig(System.IntPtr config) { }
        private System.Void YGNodeFree(System.IntPtr ygNode) { }
        private System.Void YGNodeFreeInternal(System.IntPtr ygNode) { }
        private System.Void YGSetManagedObject(System.IntPtr ygNode, UnityEngine.Yoga.YogaNode node) { }
        private System.Void YGNodeSetConfig(System.IntPtr ygNode, System.IntPtr config) { }
        private System.IntPtr YGConfigGetDefault() { }
        private System.IntPtr YGConfigNew() { }
        private System.Void YGConfigFree(System.IntPtr config) { }
        private System.Void YGConfigFreeInternal(System.IntPtr config) { }
        private System.Void YGConfigSetUseWebDefaults(System.IntPtr config, System.Boolean useWebDefaults) { }
        private System.Boolean YGConfigGetUseWebDefaults(System.IntPtr config) { }
        private System.Void YGConfigSetPointScaleFactor(System.IntPtr config, System.Single pixelsInPoint) { }
        private System.Void YGNodeInsertChild(System.IntPtr node, System.IntPtr child, System.UInt32 index) { }
        private System.Void YGNodeRemoveChild(System.IntPtr node, System.IntPtr child) { }
        private System.Void YGNodeCalculateLayout(System.IntPtr node, System.Single availableWidth, System.Single availableHeight, UnityEngine.Yoga.YogaDirection parentDirection) { }
        private System.Void YGNodeMarkDirty(System.IntPtr node) { }
        private System.Boolean YGNodeIsDirty(System.IntPtr node) { }
        private System.Void YGNodeCopyStyle(System.IntPtr dstNode, System.IntPtr srcNode) { }
        private System.Void YGNodeSetMeasureFunc(System.IntPtr node) { }
        private System.Void YGNodeRemoveMeasureFunc(System.IntPtr node) { }
        private System.Void YGNodeMeasureInvoke(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode, System.IntPtr returnValueAddress) { }
        private System.Void YGNodeBaselineInvoke(UnityEngine.Yoga.YogaNode node, System.Single width, System.Single height, System.IntPtr returnValueAddress) { }
        private System.Void YGNodeSetHasNewLayout(System.IntPtr node, System.Boolean hasNewLayout) { }
        private System.Boolean YGNodeGetHasNewLayout(System.IntPtr node) { }
        private UnityEngine.Yoga.YogaDirection YGNodeStyleGetDirection(System.IntPtr node) { }
        private System.Void YGNodeStyleSetFlexDirection(System.IntPtr node, UnityEngine.Yoga.YogaFlexDirection flexDirection) { }
        private System.Void YGNodeStyleSetJustifyContent(System.IntPtr node, UnityEngine.Yoga.YogaJustify justifyContent) { }
        private System.Void YGNodeStyleSetAlignContent(System.IntPtr node, UnityEngine.Yoga.YogaAlign alignContent) { }
        private System.Void YGNodeStyleSetAlignItems(System.IntPtr node, UnityEngine.Yoga.YogaAlign alignItems) { }
        private System.Void YGNodeStyleSetAlignSelf(System.IntPtr node, UnityEngine.Yoga.YogaAlign alignSelf) { }
        private System.Void YGNodeStyleSetPositionType(System.IntPtr node, UnityEngine.Yoga.YogaPositionType positionType) { }
        private System.Void YGNodeStyleSetFlexWrap(System.IntPtr node, UnityEngine.Yoga.YogaWrap flexWrap) { }
        private System.Void YGNodeStyleSetOverflow(System.IntPtr node, UnityEngine.Yoga.YogaOverflow flexWrap) { }
        private System.Void YGNodeStyleSetDisplay(System.IntPtr node, UnityEngine.Yoga.YogaDisplay display) { }
        private System.Void YGNodeStyleSetFlex(System.IntPtr node, System.Single flex) { }
        private System.Void YGNodeStyleSetFlexGrow(System.IntPtr node, System.Single flexGrow) { }
        private System.Void YGNodeStyleSetFlexShrink(System.IntPtr node, System.Single flexShrink) { }
        private System.Void YGNodeStyleSetFlexBasis(System.IntPtr node, System.Single flexBasis) { }
        private System.Void YGNodeStyleSetFlexBasisPercent(System.IntPtr node, System.Single flexBasis) { }
        private System.Void YGNodeStyleSetFlexBasisAuto(System.IntPtr node) { }
        private System.Void YGNodeStyleSetWidth(System.IntPtr node, System.Single width) { }
        private System.Void YGNodeStyleSetWidthPercent(System.IntPtr node, System.Single width) { }
        private System.Void YGNodeStyleSetWidthAuto(System.IntPtr node) { }
        private System.Void YGNodeStyleSetHeight(System.IntPtr node, System.Single height) { }
        private System.Void YGNodeStyleSetHeightPercent(System.IntPtr node, System.Single height) { }
        private System.Void YGNodeStyleSetHeightAuto(System.IntPtr node) { }
        private System.Void YGNodeStyleSetMinWidth(System.IntPtr node, System.Single minWidth) { }
        private System.Void YGNodeStyleSetMinWidthPercent(System.IntPtr node, System.Single minWidth) { }
        private System.Void YGNodeStyleSetMinHeight(System.IntPtr node, System.Single minHeight) { }
        private System.Void YGNodeStyleSetMinHeightPercent(System.IntPtr node, System.Single minHeight) { }
        private System.Void YGNodeStyleSetMaxWidth(System.IntPtr node, System.Single maxWidth) { }
        private System.Void YGNodeStyleSetMaxWidthPercent(System.IntPtr node, System.Single maxWidth) { }
        private System.Void YGNodeStyleSetMaxHeight(System.IntPtr node, System.Single maxHeight) { }
        private System.Void YGNodeStyleSetMaxHeightPercent(System.IntPtr node, System.Single maxHeight) { }
        private System.Void YGNodeStyleSetPosition(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single position) { }
        private System.Void YGNodeStyleSetPositionPercent(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single position) { }
        private System.Void YGNodeStyleSetMargin(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single margin) { }
        private System.Void YGNodeStyleSetMarginPercent(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single margin) { }
        private System.Void YGNodeStyleSetMarginAuto(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge) { }
        private System.Void YGNodeStyleSetPadding(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single padding) { }
        private System.Void YGNodeStyleSetPaddingPercent(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single padding) { }
        private System.Void YGNodeStyleSetBorder(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single border) { }
        private System.Single YGNodeLayoutGetLeft(System.IntPtr node) { }
        private System.Single YGNodeLayoutGetTop(System.IntPtr node) { }
        private System.Single YGNodeLayoutGetRight(System.IntPtr node) { }
        private System.Single YGNodeLayoutGetBottom(System.IntPtr node) { }
        private System.Single YGNodeLayoutGetWidth(System.IntPtr node) { }
        private System.Single YGNodeLayoutGetHeight(System.IntPtr node) { }
        private System.Single YGNodeLayoutGetMargin(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge) { }
        private System.Single YGNodeLayoutGetPadding(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge) { }
        private System.Single YGNodeLayoutGetBorder(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge) { }

    }

    // TypeToken: 0x2000011
    public class YogaNode, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.IntPtr _ygNode;        // 0x10
        private UnityEngine.Yoga.YogaConfig _config;        // 0x18
        private System.WeakReference _parent;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Yoga.YogaNode> _children;        // 0x28
        private UnityEngine.Yoga.MeasureFunction _measureFunction;        // 0x30
        private UnityEngine.Yoga.BaselineFunction _baselineFunction;        // 0x38
        private System.Object _data;        // 0x40

        // Methods
        private System.Void .ctor(UnityEngine.Yoga.YogaConfig config) { }
        private System.Void Finalize() { }
        private System.Void set_Config(UnityEngine.Yoga.YogaConfig value) { }
        private System.Boolean get_IsDirty() { }
        private System.Void MarkDirty() { }
        private System.Boolean get_HasNewLayout() { }
        private System.Boolean get_IsMeasureDefined() { }
        private System.Boolean get_IsBaselineDefined() { }
        private System.Void CopyStyle(UnityEngine.Yoga.YogaNode srcNode) { }
        private System.Void set_FlexDirection(UnityEngine.Yoga.YogaFlexDirection value) { }
        private System.Void set_JustifyContent(UnityEngine.Yoga.YogaJustify value) { }
        private System.Void set_Display(UnityEngine.Yoga.YogaDisplay value) { }
        private System.Void set_AlignItems(UnityEngine.Yoga.YogaAlign value) { }
        private System.Void set_AlignSelf(UnityEngine.Yoga.YogaAlign value) { }
        private System.Void set_AlignContent(UnityEngine.Yoga.YogaAlign value) { }
        private System.Void set_PositionType(UnityEngine.Yoga.YogaPositionType value) { }
        private System.Void set_Wrap(UnityEngine.Yoga.YogaWrap value) { }
        private System.Void set_Flex(System.Single value) { }
        private System.Void set_FlexGrow(System.Single value) { }
        private System.Void set_FlexShrink(System.Single value) { }
        private System.Void set_FlexBasis(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_Width(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_Height(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_MaxWidth(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_MaxHeight(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_MinWidth(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_MinHeight(UnityEngine.Yoga.YogaValue value) { }
        private System.Single get_LayoutX() { }
        private System.Single get_LayoutY() { }
        private System.Single get_LayoutRight() { }
        private System.Single get_LayoutBottom() { }
        private System.Single get_LayoutWidth() { }
        private System.Single get_LayoutHeight() { }
        private System.Void set_Overflow(UnityEngine.Yoga.YogaOverflow value) { }
        private System.Int32 get_Count() { }
        private System.Void MarkLayoutSeen() { }
        private System.Void Insert(System.Int32 index, UnityEngine.Yoga.YogaNode node) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void Clear() { }
        private System.Void SetMeasureFunction(UnityEngine.Yoga.MeasureFunction measureFunction) { }
        private System.Void CalculateLayout(System.Single width, System.Single height) { }
        private UnityEngine.Yoga.YogaSize MeasureInternal(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode) { }
        private System.Single BaselineInternal(UnityEngine.Yoga.YogaNode node, System.Single width, System.Single height) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.Yoga.YogaNode> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void set_Left(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_Top(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_Right(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_Bottom(UnityEngine.Yoga.YogaValue value) { }
        private System.Void SetStylePosition(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_MarginLeft(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_MarginTop(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_MarginRight(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_MarginBottom(UnityEngine.Yoga.YogaValue value) { }
        private System.Void SetStyleMargin(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_PaddingLeft(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_PaddingTop(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_PaddingRight(UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_PaddingBottom(UnityEngine.Yoga.YogaValue value) { }
        private System.Void SetStylePadding(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value) { }
        private System.Void set_BorderLeftWidth(System.Single value) { }
        private System.Void set_BorderTopWidth(System.Single value) { }
        private System.Void set_BorderRightWidth(System.Single value) { }
        private System.Void set_BorderBottomWidth(System.Single value) { }
        private System.Single get_LayoutMarginLeft() { }
        private System.Single get_LayoutMarginTop() { }
        private System.Single get_LayoutMarginRight() { }
        private System.Single get_LayoutMarginBottom() { }
        private System.Single get_LayoutPaddingLeft() { }
        private System.Single get_LayoutPaddingTop() { }
        private System.Single get_LayoutPaddingRight() { }
        private System.Single get_LayoutPaddingBottom() { }
        private System.Single get_LayoutBorderLeft() { }
        private System.Single get_LayoutBorderTop() { }
        private System.Single get_LayoutBorderRight() { }
        private System.Single get_LayoutBorderBottom() { }

    }

    // TypeToken: 0x2000012
    public struct YogaOverflow
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaOverflow Visible;        // 0x0
        public static UnityEngine.Yoga.YogaOverflow Hidden;        // 0x0
        public static UnityEngine.Yoga.YogaOverflow Scroll;        // 0x0

    }

    // TypeToken: 0x2000013
    public struct YogaPositionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaPositionType Relative;        // 0x0
        public static UnityEngine.Yoga.YogaPositionType Absolute;        // 0x0

    }

    // TypeToken: 0x2000014
    public struct YogaSize
    {
        // Fields
        public System.Single width;        // 0x10
        public System.Single height;        // 0x14

    }

    // TypeToken: 0x2000015
    public struct YogaUnit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaUnit Undefined;        // 0x0
        public static UnityEngine.Yoga.YogaUnit Point;        // 0x0
        public static UnityEngine.Yoga.YogaUnit Percent;        // 0x0
        public static UnityEngine.Yoga.YogaUnit Auto;        // 0x0

    }

    // TypeToken: 0x2000016
    public struct YogaValue
    {
        // Fields
        private System.Single value;        // 0x10
        private UnityEngine.Yoga.YogaUnit unit;        // 0x14

        // Methods
        private UnityEngine.Yoga.YogaUnit get_Unit() { }
        private System.Single get_Value() { }
        private UnityEngine.Yoga.YogaValue Point(System.Single value) { }
        private System.Boolean Equals(UnityEngine.Yoga.YogaValue other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private UnityEngine.Yoga.YogaValue Auto() { }
        private UnityEngine.Yoga.YogaValue Percent(System.Single value) { }
        private UnityEngine.Yoga.YogaValue op_Implicit(System.Single pointValue) { }

    }

    // TypeToken: 0x2000017
    public struct YogaWrap
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Yoga.YogaWrap NoWrap;        // 0x0
        public static UnityEngine.Yoga.YogaWrap Wrap;        // 0x0
        public static UnityEngine.Yoga.YogaWrap WrapReverse;        // 0x0

    }

}

