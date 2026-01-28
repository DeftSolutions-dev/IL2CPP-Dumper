// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIModule.dll
// Classes:  12
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: InstanceRange
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.UInt16                   start  // 0x10
  public            System.UInt16                   end  // 0x12
METHODS:
END_CLASS

CLASS: WillRenderCanvases
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: SampleType
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UISystemProfilerApi.SampleTypeLayout  // 0x0
  public    static  UnityEngine.UISystemProfilerApi.SampleTypeRender  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ICanvasRaycastFilter
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
END_CLASS

CLASS: UnityEngine.CanvasGroup
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Behaviour
FIELDS:
METHODS:
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  System.Single get_alpha()
  System.Void set_alpha(System.Single value)
  System.Boolean get_interactable()
  System.Void set_interactable(System.Boolean value)
  System.Boolean get_blocksRaycasts()
  System.Void set_blocksRaycasts(System.Boolean value)
  System.Boolean get_ignoreParentGroups()
  System.Void set_ignoreParentGroups(System.Boolean value)
  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  System.Void .ctor()
  System.Void get_color_Injected(UnityEngine.Color& ret)
  System.Void set_color_Injected(UnityEngine.Color& value)
END_CLASS

CLASS: UnityEngine.CanvasRenderer
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Component
FIELDS:
  private           System.Boolean                  <isMask>k__BackingField  // 0x18
METHODS:
  System.Void set_hasPopInstruction(System.Boolean value)
  System.Int32 get_materialCount()
  System.Void set_materialCount(System.Int32 value)
  System.Void set_popMaterialCount(System.Int32 value)
  System.Int32 get_absoluteDepth()
  System.Boolean get_hasMoved()
  System.Boolean get_cullTransparentMesh()
  System.Void set_cullTransparentMesh(System.Boolean value)
  System.Boolean get_cull()
  System.Void set_cull(System.Boolean value)
  System.Void SetColor(UnityEngine.Color color)
  UnityEngine.Color GetColor()
  System.Void EnableRectClipping(UnityEngine.Rect rect)
  System.Void set_clippingSoftness(UnityEngine.Vector2 value)
  System.Void set_clippingHGSoftness(UnityEngine.Vector4 value)
  System.Void DisableRectClipping()
  System.Void SetMaterial(UnityEngine.Material material, System.Int32 index)
  UnityEngine.Material GetMaterial(System.Int32 index)
  System.Void SetPopMaterial(UnityEngine.Material material, System.Int32 index)
  System.Void SetTexture(UnityEngine.Texture texture)
  System.Void SetAlphaTexture(UnityEngine.Texture texture)
  System.Void SetMesh(UnityEngine.Mesh mesh)
  System.Void Clear()
  System.Void SetAlpha(System.Single alpha)
  System.Void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture)
  UnityEngine.Material GetMaterial()
  System.Void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices)
  System.Void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices)
  System.Void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents)
  System.Void SplitIndicesStreamsInternal(System.Object verts, System.Object indices)
  System.Void SplitUIVertexStreamsInternal(System.Object verts, System.Object positions, System.Object colors, System.Object uv0S, System.Object uv1S, System.Object uv2S, System.Object uv3S, System.Object normals, System.Object tangents)
  System.Void CreateUIVertexStreamInternal(System.Object verts, System.Object positions, System.Object colors, System.Object uv0S, System.Object uv1S, System.Object uv2S, System.Object uv3S, System.Object normals, System.Object tangents, System.Object indices)
  System.Void UpdateInstanceRange(System.UInt32 rangeCount, System.Void* ranges)
  System.Void UpdateInstanceRange(System.UInt32 rangeCount, Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> rangers)
  System.Void* BeginInstanceBufferWrite(System.UInt32 count, System.UInt32 stride)
  System.Void* BeginPrefabBufferWrite(System.UInt32 count, System.UInt32 stride)
  System.Void EndInstanceBufferWrite()
  System.Void EndPrefabBufferWrite()
  Unity.Collections.NativeArray<T> BeginInstanceDataWrite(System.Int32 count)
  Unity.Collections.NativeArray<T> BeginPrefabBufferWrite(System.Int32 count)
  System.Void EnableInstance()
  System.Void SetColor_Injected(UnityEngine.Color& color)
  System.Void GetColor_Injected(UnityEngine.Color& ret)
  System.Void EnableRectClipping_Injected(UnityEngine.Rect& rect)
  System.Void set_clippingSoftness_Injected(UnityEngine.Vector2& value)
  System.Void set_clippingHGSoftness_Injected(UnityEngine.Vector4& value)
END_CLASS

CLASS: UnityEngine.RectTransformUtility
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  private   static readonly UnityEngine.Vector3[]           s_Corners  // 0x0
METHODS:
  UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas)
  UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas)
  System.Boolean PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset)
  System.Void .ctor()
  System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint)
  System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam)
  System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset)
  System.Boolean ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector3& worldPoint)
  System.Boolean ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector2& localPoint)
  UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos)
  UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint)
  UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform root, UnityEngine.Transform child)
  UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform trans)
  System.Void FlipLayoutOnAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Boolean keepPositioning, System.Boolean recursive)
  System.Void FlipLayoutAxes(UnityEngine.RectTransform rect, System.Boolean keepPositioning, System.Boolean recursive)
  UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input)
  System.Void .cctor()
  System.Void PixelAdjustPoint_Injected(UnityEngine.Vector2& point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas, UnityEngine.Vector2& ret)
  System.Void PixelAdjustRect_Injected(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas, UnityEngine.Rect& ret)
  System.Boolean PointInRectangle_Injected(UnityEngine.Vector2& screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4& offset)
END_CLASS

CLASS: UnityEngine.RenderMode
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RenderMode          ScreenSpaceOverlay  // 0x0
  public    static  UnityEngine.RenderMode          ScreenSpaceCamera  // 0x0
  public    static  UnityEngine.RenderMode          WorldSpace  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AdditionalCanvasShaderChannels
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AdditionalCanvasShaderChannelsNone  // 0x0
  public    static  UnityEngine.AdditionalCanvasShaderChannelsTexCoord1  // 0x0
  public    static  UnityEngine.AdditionalCanvasShaderChannelsTexCoord2  // 0x0
  public    static  UnityEngine.AdditionalCanvasShaderChannelsTexCoord3  // 0x0
  public    static  UnityEngine.AdditionalCanvasShaderChannelsNormal  // 0x0
  public    static  UnityEngine.AdditionalCanvasShaderChannelsTangent  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Canvas
TYPE:  class
TOKEN: 0x2000009
EXTENDS: Behaviour
FIELDS:
  private   static  UnityEngine.Canvas.WillRenderCanvasespreWillRenderCanvases  // 0x0
  private   static  UnityEngine.Canvas.WillRenderCanvaseswillRenderCanvases  // 0x8
  private   static  System.Action<System.Int32>     <externBeginRenderOverlays>k__BackingField  // 0x10
  private   static  System.Action<System.Int32,System.Int32><externRenderOverlaysBefore>k__BackingField  // 0x18
  private   static  System.Action<System.Int32>     <externEndRenderOverlays>k__BackingField  // 0x20
METHODS:
  System.Void add_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value)
  System.Void remove_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value)
  System.Void add_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value)
  System.Void remove_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value)
  UnityEngine.RenderMode get_renderMode()
  System.Void set_renderMode(UnityEngine.RenderMode value)
  System.Boolean get_isRootCanvas()
  UnityEngine.Rect get_pixelRect()
  System.Single get_scaleFactor()
  System.Void set_scaleFactor(System.Single value)
  System.Single get_referencePixelsPerUnit()
  System.Void set_referencePixelsPerUnit(System.Single value)
  System.Boolean get_overridePixelPerfect()
  System.Void set_overridePixelPerfect(System.Boolean value)
  System.Boolean get_vertexColorAlwaysGammaSpace()
  System.Void set_vertexColorAlwaysGammaSpace(System.Boolean value)
  System.Boolean get_pixelPerfect()
  System.Void set_pixelPerfect(System.Boolean value)
  System.Single get_planeDistance()
  System.Void set_planeDistance(System.Single value)
  System.Int32 get_renderOrder()
  System.Boolean get_overrideSorting()
  System.Void set_overrideSorting(System.Boolean value)
  System.Int32 get_sortingOrder()
  System.Void set_sortingOrder(System.Int32 value)
  System.Int32 get_targetDisplay()
  System.Void set_targetDisplay(System.Int32 value)
  System.Int32 get_sortingLayerID()
  System.Void set_sortingLayerID(System.Int32 value)
  System.Int32 get_cachedSortingLayerValue()
  UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels()
  System.Void set_additionalShaderChannels(UnityEngine.AdditionalCanvasShaderChannels value)
  System.String get_sortingLayerName()
  System.Void set_sortingLayerName(System.String value)
  UnityEngine.Canvas get_rootCanvas()
  UnityEngine.Vector2 get_renderingDisplaySize()
  System.Action<System.Int32> get_externBeginRenderOverlays()
  System.Void set_externBeginRenderOverlays(System.Action<System.Int32> value)
  System.Action<System.Int32,System.Int32> get_externRenderOverlaysBefore()
  System.Void set_externRenderOverlaysBefore(System.Action<System.Int32,System.Int32> value)
  System.Action<System.Int32> get_externEndRenderOverlays()
  System.Void set_externEndRenderOverlays(System.Action<System.Int32> value)
  System.Void SetExternalCanvasEnabled(System.Boolean enabled)
  UnityEngine.Camera get_worldCamera()
  System.Void set_worldCamera(UnityEngine.Camera value)
  System.Single get_normalizedSortingGridSize()
  System.Void set_normalizedSortingGridSize(System.Single value)
  System.Int32 get_sortingGridNormalizedSize()
  System.Void set_sortingGridNormalizedSize(System.Int32 value)
  UnityEngine.Material GetDefaultCanvasTextMaterial()
  UnityEngine.Material GetDefaultCanvasMaterial()
  UnityEngine.Material GetETC1SupportedCanvasMaterial()
  System.Void UpdateCanvasRectTransform(System.Boolean alignWithCamera)
  System.Void ForceUpdateCanvases()
  System.Void SendPreWillRenderCanvases()
  System.Void SendWillRenderCanvases()
  System.Void BeginRenderExtraOverlays(System.Int32 displayIndex)
  System.Void RenderExtraOverlaysBefore(System.Int32 displayIndex, System.Int32 sortingOrder)
  System.Void EndRenderExtraOverlays(System.Int32 displayIndex)
  System.Void .ctor()
  System.Void get_pixelRect_Injected(UnityEngine.Rect& ret)
  System.Void get_renderingDisplaySize_Injected(UnityEngine.Vector2& ret)
END_CLASS

CLASS: UnityEngine.UISystemProfilerApi
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  System.Void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type)
  System.Void EndSample(UnityEngine.UISystemProfilerApi.SampleType type)
  System.Void AddMarker(System.String name, UnityEngine.Object obj)
END_CLASS

