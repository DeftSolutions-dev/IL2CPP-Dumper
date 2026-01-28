// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TextRenderingModule.dll
// Classes:  14
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: FontTextureRebuildCallback
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.FontStyle
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.FontStyle           Normal  // 0x0
  public    static  UnityEngine.FontStyle           Bold  // 0x0
  public    static  UnityEngine.FontStyle           Italic  // 0x0
  public    static  UnityEngine.FontStyle           BoldAndItalic  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextGenerationError
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextGenerationError None  // 0x0
  public    static  UnityEngine.TextGenerationError CustomSizeOnNonDynamicFont  // 0x0
  public    static  UnityEngine.TextGenerationError CustomStyleOnNonDynamicFont  // 0x0
  public    static  UnityEngine.TextGenerationError NoFont  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextGenerationSettings
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            UnityEngine.Font                font  // 0x10
  public            UnityEngine.Color               color  // 0x18
  public            System.Int32                    fontSize  // 0x28
  public            System.Single                   lineSpacing  // 0x2C
  public            System.Boolean                  richText  // 0x30
  public            System.Single                   scaleFactor  // 0x34
  public            UnityEngine.FontStyle           fontStyle  // 0x38
  public            UnityEngine.TextAnchor          textAnchor  // 0x3C
  public            System.Boolean                  alignByGeometry  // 0x40
  public            System.Boolean                  resizeTextForBestFit  // 0x41
  public            System.Int32                    resizeTextMinSize  // 0x44
  public            System.Int32                    resizeTextMaxSize  // 0x48
  public            System.Boolean                  updateBounds  // 0x4C
  public            UnityEngine.VerticalWrapMode    verticalOverflow  // 0x50
  public            UnityEngine.HorizontalWrapMode  horizontalOverflow  // 0x54
  public            UnityEngine.Vector2             generationExtents  // 0x58
  public            UnityEngine.Vector2             pivot  // 0x60
  public            System.Boolean                  generateOutOfBounds  // 0x68
METHODS:
  System.Boolean CompareColors(UnityEngine.Color left, UnityEngine.Color right)
  System.Boolean CompareVector2(UnityEngine.Vector2 left, UnityEngine.Vector2 right)
  System.Boolean Equals(UnityEngine.TextGenerationSettings other)
END_CLASS

CLASS: UnityEngine.TextGenerator
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           System.String                   m_LastString  // 0x18
  private           UnityEngine.TextGenerationSettingsm_LastSettings  // 0x20
  private           System.Boolean                  m_HasGenerated  // 0x80
  private           UnityEngine.TextGenerationError m_LastValid  // 0x84
  private   readonly System.Collections.Generic.List<UnityEngine.UIVertex>m_Verts  // 0x88
  private   readonly System.Collections.Generic.List<UnityEngine.UICharInfo>m_Characters  // 0x90
  private   readonly System.Collections.Generic.List<UnityEngine.UILineInfo>m_Lines  // 0x98
  private           System.Boolean                  m_CachedVerts  // 0xA0
  private           System.Boolean                  m_CachedCharacters  // 0xA1
  private           System.Boolean                  m_CachedLines  // 0xA2
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 initialCapacity)
  System.Void Finalize()
  System.Void System.IDisposable.Dispose()
  System.Int32 get_characterCountVisible()
  UnityEngine.TextGenerationSettings ValidatedSettings(UnityEngine.TextGenerationSettings settings)
  System.Void Invalidate()
  System.Void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters)
  System.Void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines)
  System.Void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices)
  System.Single GetPreferredWidth(System.String str, UnityEngine.TextGenerationSettings settings)
  System.Single GetPreferredHeight(System.String str, UnityEngine.TextGenerationSettings settings)
  System.Boolean PopulateWithErrors(System.String str, UnityEngine.TextGenerationSettings settings, UnityEngine.GameObject context)
  System.Boolean Populate(System.String str, UnityEngine.TextGenerationSettings settings)
  UnityEngine.TextGenerationError PopulateWithError(System.String str, UnityEngine.TextGenerationSettings settings)
  UnityEngine.TextGenerationError PopulateAlways(System.String str, UnityEngine.TextGenerationSettings settings)
  System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts()
  System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters()
  System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines()
  UnityEngine.Rect get_rectExtents()
  System.Int32 get_characterCount()
  System.Int32 get_lineCount()
  System.IntPtr Internal_Create()
  System.Void Internal_Destroy(System.IntPtr ptr)
  System.Boolean Populate_Internal(System.String str, UnityEngine.Font font, UnityEngine.Color color, System.Int32 fontSize, System.Single scaleFactor, System.Single lineSpacing, UnityEngine.FontStyle style, System.Boolean richText, System.Boolean resizeTextForBestFit, System.Int32 resizeTextMinSize, System.Int32 resizeTextMaxSize, System.Int32 verticalOverFlow, System.Int32 horizontalOverflow, System.Boolean updateBounds, UnityEngine.TextAnchor anchor, System.Single extentsX, System.Single extentsY, System.Single pivotX, System.Single pivotY, System.Boolean generateOutOfBounds, System.Boolean alignByGeometry, System.UInt32& error)
  System.Boolean Populate_Internal(System.String str, UnityEngine.Font font, UnityEngine.Color color, System.Int32 fontSize, System.Single scaleFactor, System.Single lineSpacing, UnityEngine.FontStyle style, System.Boolean richText, System.Boolean resizeTextForBestFit, System.Int32 resizeTextMinSize, System.Int32 resizeTextMaxSize, UnityEngine.VerticalWrapMode verticalOverFlow, UnityEngine.HorizontalWrapMode horizontalOverflow, System.Boolean updateBounds, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 extents, UnityEngine.Vector2 pivot, System.Boolean generateOutOfBounds, System.Boolean alignByGeometry, UnityEngine.TextGenerationError& error)
  System.Void GetVerticesInternal(System.Object vertices)
  System.Void GetCharactersInternal(System.Object characters)
  System.Void GetLinesInternal(System.Object lines)
  System.Void get_rectExtents_Injected(UnityEngine.Rect& ret)
  System.Boolean Populate_Internal_Injected(System.String str, UnityEngine.Font font, UnityEngine.Color& color, System.Int32 fontSize, System.Single scaleFactor, System.Single lineSpacing, UnityEngine.FontStyle style, System.Boolean richText, System.Boolean resizeTextForBestFit, System.Int32 resizeTextMinSize, System.Int32 resizeTextMaxSize, System.Int32 verticalOverFlow, System.Int32 horizontalOverflow, System.Boolean updateBounds, UnityEngine.TextAnchor anchor, System.Single extentsX, System.Single extentsY, System.Single pivotX, System.Single pivotY, System.Boolean generateOutOfBounds, System.Boolean alignByGeometry, System.UInt32& error)
END_CLASS

CLASS: UnityEngine.TextAlignment
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextAlignment       Left  // 0x0
  public    static  UnityEngine.TextAlignment       Center  // 0x0
  public    static  UnityEngine.TextAlignment       Right  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextAnchor
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextAnchor          UpperLeft  // 0x0
  public    static  UnityEngine.TextAnchor          UpperCenter  // 0x0
  public    static  UnityEngine.TextAnchor          UpperRight  // 0x0
  public    static  UnityEngine.TextAnchor          MiddleLeft  // 0x0
  public    static  UnityEngine.TextAnchor          MiddleCenter  // 0x0
  public    static  UnityEngine.TextAnchor          MiddleRight  // 0x0
  public    static  UnityEngine.TextAnchor          LowerLeft  // 0x0
  public    static  UnityEngine.TextAnchor          LowerCenter  // 0x0
  public    static  UnityEngine.TextAnchor          LowerRight  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HorizontalWrapMode
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HorizontalWrapMode  Wrap  // 0x0
  public    static  UnityEngine.HorizontalWrapMode  Overflow  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.VerticalWrapMode
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.VerticalWrapMode    Truncate  // 0x0
  public    static  UnityEngine.VerticalWrapMode    Overflow  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UICharInfo
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            UnityEngine.Vector2             cursorPos  // 0x10
  public            System.Single                   charWidth  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.UILineInfo
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    startCharIdx  // 0x10
  public            System.Int32                    height  // 0x14
  public            System.Single                   topY  // 0x18
  public            System.Single                   leading  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.UIVertex
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector3             normal  // 0x1C
  public            UnityEngine.Vector4             tangent  // 0x28
  public            UnityEngine.Color32             color  // 0x38
  public            UnityEngine.Vector4             uv0  // 0x3C
  public            UnityEngine.Vector4             uv1  // 0x4C
  public            UnityEngine.Vector4             uv2  // 0x5C
  public            UnityEngine.Vector4             uv3  // 0x6C
  private   static readonly UnityEngine.Color32             s_DefaultColor  // 0x0
  private   static readonly UnityEngine.Vector4             s_DefaultTangent  // 0x4
  public    static  UnityEngine.UIVertex            simpleVert  // 0x14
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Font
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   static  System.Action<UnityEngine.Font> textureRebuilt  // 0x0
  private           UnityEngine.Font.FontTextureRebuildCallbackm_FontTextureRebuildCallback  // 0x18
METHODS:
  System.Void add_textureRebuilt(System.Action<UnityEngine.Font> value)
  System.Void remove_textureRebuilt(System.Action<UnityEngine.Font> value)
  UnityEngine.Material get_material()
  System.Boolean get_dynamic()
  System.Int32 get_fontSize()
  System.Void .ctor()
  System.Void InvokeTextureRebuilt_Internal(UnityEngine.Font font)
  System.Boolean HasCharacter(System.Char c)
  System.Boolean HasCharacter(System.Int32 c)
  System.Void Internal_CreateFont(UnityEngine.Font self, System.String name)
END_CLASS

