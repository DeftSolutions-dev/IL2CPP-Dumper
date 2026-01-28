// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIModule.dll
// Classes:  12
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000005
    public struct InstanceRange
    {
        // Fields
        public System.UInt16 start;        // 0x10
        public System.UInt16 end;        // 0x12

    }

    // TypeToken: 0x200000A
    public class WillRenderCanvases : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200000C
    public struct SampleType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UISystemProfilerApi.SampleType Layout;        // 0x0
        public static UnityEngine.UISystemProfilerApi.SampleType Render;        // 0x0

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public interface ICanvasRaycastFilter
    {
        // Methods
        private System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }

    }

    // TypeToken: 0x2000003
    public class CanvasGroup : Behaviour, ICanvasRaycastFilter
    {
        // Methods
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Single get_alpha() { }
        private System.Void set_alpha(System.Single value) { }
        private System.Boolean get_interactable() { }
        private System.Void set_interactable(System.Boolean value) { }
        private System.Boolean get_blocksRaycasts() { }
        private System.Void set_blocksRaycasts(System.Boolean value) { }
        private System.Boolean get_ignoreParentGroups() { }
        private System.Void set_ignoreParentGroups(System.Boolean value) { }
        private System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        private System.Void .ctor() { }
        private System.Void get_color_Injected(UnityEngine.Color& ret) { }
        private System.Void set_color_Injected(UnityEngine.Color& value) { }

    }

    // TypeToken: 0x2000004
    public class CanvasRenderer : Component
    {
        // Fields
        private System.Boolean <isMask>k__BackingField;        // 0x18

        // Methods
        private System.Void set_hasPopInstruction(System.Boolean value) { }
        private System.Int32 get_materialCount() { }
        private System.Void set_materialCount(System.Int32 value) { }
        private System.Void set_popMaterialCount(System.Int32 value) { }
        private System.Int32 get_absoluteDepth() { }
        private System.Boolean get_hasMoved() { }
        private System.Boolean get_cullTransparentMesh() { }
        private System.Void set_cullTransparentMesh(System.Boolean value) { }
        private System.Boolean get_cull() { }
        private System.Void set_cull(System.Boolean value) { }
        private System.Void SetColor(UnityEngine.Color color) { }
        private UnityEngine.Color GetColor() { }
        private System.Void EnableRectClipping(UnityEngine.Rect rect) { }
        private System.Void set_clippingSoftness(UnityEngine.Vector2 value) { }
        private System.Void set_clippingHGSoftness(UnityEngine.Vector4 value) { }
        private System.Void DisableRectClipping() { }
        private System.Void SetMaterial(UnityEngine.Material material, System.Int32 index) { }
        private UnityEngine.Material GetMaterial(System.Int32 index) { }
        private System.Void SetPopMaterial(UnityEngine.Material material, System.Int32 index) { }
        private System.Void SetTexture(UnityEngine.Texture texture) { }
        private System.Void SetAlphaTexture(UnityEngine.Texture texture) { }
        private System.Void SetMesh(UnityEngine.Mesh mesh) { }
        private System.Void Clear() { }
        private System.Void SetAlpha(System.Single alpha) { }
        private System.Void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture) { }
        private UnityEngine.Material GetMaterial() { }
        private System.Void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }
        private System.Void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }
        private System.Void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents) { }
        private System.Void SplitIndicesStreamsInternal(System.Object verts, System.Object indices) { }
        private System.Void SplitUIVertexStreamsInternal(System.Object verts, System.Object positions, System.Object colors, System.Object uv0S, System.Object uv1S, System.Object uv2S, System.Object uv3S, System.Object normals, System.Object tangents) { }
        private System.Void CreateUIVertexStreamInternal(System.Object verts, System.Object positions, System.Object colors, System.Object uv0S, System.Object uv1S, System.Object uv2S, System.Object uv3S, System.Object normals, System.Object tangents, System.Object indices) { }
        private System.Void UpdateInstanceRange(System.UInt32 rangeCount, System.Void* ranges) { }
        private System.Void UpdateInstanceRange(System.UInt32 rangeCount, Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> rangers) { }
        private System.Void* BeginInstanceBufferWrite(System.UInt32 count, System.UInt32 stride) { }
        private System.Void* BeginPrefabBufferWrite(System.UInt32 count, System.UInt32 stride) { }
        private System.Void EndInstanceBufferWrite() { }
        private System.Void EndPrefabBufferWrite() { }
        private Unity.Collections.NativeArray<T> BeginInstanceDataWrite(System.Int32 count) { }
        private Unity.Collections.NativeArray<T> BeginPrefabBufferWrite(System.Int32 count) { }
        private System.Void EnableInstance() { }
        private System.Void SetColor_Injected(UnityEngine.Color& color) { }
        private System.Void GetColor_Injected(UnityEngine.Color& ret) { }
        private System.Void EnableRectClipping_Injected(UnityEngine.Rect& rect) { }
        private System.Void set_clippingSoftness_Injected(UnityEngine.Vector2& value) { }
        private System.Void set_clippingHGSoftness_Injected(UnityEngine.Vector4& value) { }

    }

    // TypeToken: 0x2000006
    public class RectTransformUtility
    {
        // Fields
        private static readonly UnityEngine.Vector3[] s_Corners;        // 0x0

        // Methods
        private UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas) { }
        private UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas) { }
        private System.Boolean PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset) { }
        private System.Void .ctor() { }
        private System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint) { }
        private System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam) { }
        private System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset) { }
        private System.Boolean ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector3& worldPoint) { }
        private System.Boolean ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector2& localPoint) { }
        private UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos) { }
        private UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint) { }
        private UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform root, UnityEngine.Transform child) { }
        private UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform trans) { }
        private System.Void FlipLayoutOnAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Boolean keepPositioning, System.Boolean recursive) { }
        private System.Void FlipLayoutAxes(UnityEngine.RectTransform rect, System.Boolean keepPositioning, System.Boolean recursive) { }
        private UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input) { }
        private System.Void .cctor() { }
        private System.Void PixelAdjustPoint_Injected(UnityEngine.Vector2& point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas, UnityEngine.Vector2& ret) { }
        private System.Void PixelAdjustRect_Injected(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas, UnityEngine.Rect& ret) { }
        private System.Boolean PointInRectangle_Injected(UnityEngine.Vector2& screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4& offset) { }

    }

    // TypeToken: 0x2000007
    public struct RenderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RenderMode ScreenSpaceOverlay;        // 0x0
        public static UnityEngine.RenderMode ScreenSpaceCamera;        // 0x0
        public static UnityEngine.RenderMode WorldSpace;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct AdditionalCanvasShaderChannels
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AdditionalCanvasShaderChannels None;        // 0x0
        public static UnityEngine.AdditionalCanvasShaderChannels TexCoord1;        // 0x0
        public static UnityEngine.AdditionalCanvasShaderChannels TexCoord2;        // 0x0
        public static UnityEngine.AdditionalCanvasShaderChannels TexCoord3;        // 0x0
        public static UnityEngine.AdditionalCanvasShaderChannels Normal;        // 0x0
        public static UnityEngine.AdditionalCanvasShaderChannels Tangent;        // 0x0

    }

    // TypeToken: 0x2000009
    public class Canvas : Behaviour
    {
        // Fields
        private static UnityEngine.Canvas.WillRenderCanvases preWillRenderCanvases;        // 0x0
        private static UnityEngine.Canvas.WillRenderCanvases willRenderCanvases;        // 0x8
        private static System.Action<System.Int32> <externBeginRenderOverlays>k__BackingField;        // 0x10
        private static System.Action<System.Int32,System.Int32> <externRenderOverlaysBefore>k__BackingField;        // 0x18
        private static System.Action<System.Int32> <externEndRenderOverlays>k__BackingField;        // 0x20

        // Methods
        private System.Void add_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value) { }
        private System.Void remove_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value) { }
        private System.Void add_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value) { }
        private System.Void remove_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value) { }
        private UnityEngine.RenderMode get_renderMode() { }
        private System.Void set_renderMode(UnityEngine.RenderMode value) { }
        private System.Boolean get_isRootCanvas() { }
        private UnityEngine.Rect get_pixelRect() { }
        private System.Single get_scaleFactor() { }
        private System.Void set_scaleFactor(System.Single value) { }
        private System.Single get_referencePixelsPerUnit() { }
        private System.Void set_referencePixelsPerUnit(System.Single value) { }
        private System.Boolean get_overridePixelPerfect() { }
        private System.Void set_overridePixelPerfect(System.Boolean value) { }
        private System.Boolean get_vertexColorAlwaysGammaSpace() { }
        private System.Void set_vertexColorAlwaysGammaSpace(System.Boolean value) { }
        private System.Boolean get_pixelPerfect() { }
        private System.Void set_pixelPerfect(System.Boolean value) { }
        private System.Single get_planeDistance() { }
        private System.Void set_planeDistance(System.Single value) { }
        private System.Int32 get_renderOrder() { }
        private System.Boolean get_overrideSorting() { }
        private System.Void set_overrideSorting(System.Boolean value) { }
        private System.Int32 get_sortingOrder() { }
        private System.Void set_sortingOrder(System.Int32 value) { }
        private System.Int32 get_targetDisplay() { }
        private System.Void set_targetDisplay(System.Int32 value) { }
        private System.Int32 get_sortingLayerID() { }
        private System.Void set_sortingLayerID(System.Int32 value) { }
        private System.Int32 get_cachedSortingLayerValue() { }
        private UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels() { }
        private System.Void set_additionalShaderChannels(UnityEngine.AdditionalCanvasShaderChannels value) { }
        private System.String get_sortingLayerName() { }
        private System.Void set_sortingLayerName(System.String value) { }
        private UnityEngine.Canvas get_rootCanvas() { }
        private UnityEngine.Vector2 get_renderingDisplaySize() { }
        private System.Action<System.Int32> get_externBeginRenderOverlays() { }
        private System.Void set_externBeginRenderOverlays(System.Action<System.Int32> value) { }
        private System.Action<System.Int32,System.Int32> get_externRenderOverlaysBefore() { }
        private System.Void set_externRenderOverlaysBefore(System.Action<System.Int32,System.Int32> value) { }
        private System.Action<System.Int32> get_externEndRenderOverlays() { }
        private System.Void set_externEndRenderOverlays(System.Action<System.Int32> value) { }
        private System.Void SetExternalCanvasEnabled(System.Boolean enabled) { }
        private UnityEngine.Camera get_worldCamera() { }
        private System.Void set_worldCamera(UnityEngine.Camera value) { }
        private System.Single get_normalizedSortingGridSize() { }
        private System.Void set_normalizedSortingGridSize(System.Single value) { }
        private System.Int32 get_sortingGridNormalizedSize() { }
        private System.Void set_sortingGridNormalizedSize(System.Int32 value) { }
        private UnityEngine.Material GetDefaultCanvasTextMaterial() { }
        private UnityEngine.Material GetDefaultCanvasMaterial() { }
        private UnityEngine.Material GetETC1SupportedCanvasMaterial() { }
        private System.Void UpdateCanvasRectTransform(System.Boolean alignWithCamera) { }
        private System.Void ForceUpdateCanvases() { }
        private System.Void SendPreWillRenderCanvases() { }
        private System.Void SendWillRenderCanvases() { }
        private System.Void BeginRenderExtraOverlays(System.Int32 displayIndex) { }
        private System.Void RenderExtraOverlaysBefore(System.Int32 displayIndex, System.Int32 sortingOrder) { }
        private System.Void EndRenderExtraOverlays(System.Int32 displayIndex) { }
        private System.Void .ctor() { }
        private System.Void get_pixelRect_Injected(UnityEngine.Rect& ret) { }
        private System.Void get_renderingDisplaySize_Injected(UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x200000B
    public class UISystemProfilerApi
    {
        // Methods
        private System.Void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type) { }
        private System.Void EndSample(UnityEngine.UISystemProfilerApi.SampleType type) { }
        private System.Void AddMarker(System.String name, UnityEngine.Object obj) { }

    }

}

