// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TextCoreFontEngineModule.dll
// Classes:  18
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngine.TextCore.FaceInfo
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  private           System.Int32                    m_FaceIndex  // 0x10
  private           System.String                   m_FamilyName  // 0x18
  private           System.String                   m_StyleName  // 0x20
  private           System.Int32                    m_PointSize  // 0x28
  private           System.Single                   m_Scale  // 0x2C
  private           System.Int32                    m_UnitsPerEM  // 0x30
  private           System.Single                   m_LineHeight  // 0x34
  private           System.Single                   m_AscentLine  // 0x38
  private           System.Single                   m_CapLine  // 0x3C
  private           System.Single                   m_MeanLine  // 0x40
  private           System.Single                   m_Baseline  // 0x44
  private           System.Single                   m_DescentLine  // 0x48
  private           System.Single                   m_SuperscriptOffset  // 0x4C
  private           System.Single                   m_SuperscriptSize  // 0x50
  private           System.Single                   m_SubscriptOffset  // 0x54
  private           System.Single                   m_SubscriptSize  // 0x58
  private           System.Single                   m_UnderlineOffset  // 0x5C
  private           System.Single                   m_UnderlineThickness  // 0x60
  private           System.Single                   m_StrikethroughOffset  // 0x64
  private           System.Single                   m_StrikethroughThickness  // 0x68
  private           System.Single                   m_TabWidth  // 0x6C
METHODS:
  System.Int32 get_faceIndex()
  System.String get_familyName()
  System.Void set_familyName(System.String value)
  System.String get_styleName()
  System.Void set_styleName(System.String value)
  System.Int32 get_pointSize()
  System.Void set_pointSize(System.Int32 value)
  System.Single get_scale()
  System.Void set_scale(System.Single value)
  System.Single get_lineHeight()
  System.Void set_lineHeight(System.Single value)
  System.Single get_ascentLine()
  System.Void set_ascentLine(System.Single value)
  System.Single get_capLine()
  System.Void set_capLine(System.Single value)
  System.Single get_meanLine()
  System.Void set_meanLine(System.Single value)
  System.Single get_baseline()
  System.Void set_baseline(System.Single value)
  System.Single get_descentLine()
  System.Void set_descentLine(System.Single value)
  System.Single get_superscriptOffset()
  System.Void set_superscriptOffset(System.Single value)
  System.Single get_superscriptSize()
  System.Void set_superscriptSize(System.Single value)
  System.Single get_subscriptOffset()
  System.Void set_subscriptOffset(System.Single value)
  System.Single get_subscriptSize()
  System.Void set_subscriptSize(System.Single value)
  System.Single get_underlineOffset()
  System.Void set_underlineOffset(System.Single value)
  System.Single get_underlineThickness()
  System.Void set_underlineThickness(System.Single value)
  System.Single get_strikethroughOffset()
  System.Void set_strikethroughOffset(System.Single value)
  System.Void set_strikethroughThickness(System.Single value)
  System.Single get_tabWidth()
  System.Void set_tabWidth(System.Single value)
END_CLASS

CLASS: UnityEngine.TextCore.GlyphClassDefinitionType
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeUndefined  // 0x0
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeBase  // 0x0
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeLigature  // 0x0
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeMark  // 0x0
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeComponent  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.GlyphRect
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  private           System.Int32                    m_X  // 0x10
  private           System.Int32                    m_Y  // 0x14
  private           System.Int32                    m_Width  // 0x18
  private           System.Int32                    m_Height  // 0x1C
  private   static readonly UnityEngine.TextCore.GlyphRect  s_ZeroGlyphRect  // 0x0
METHODS:
  System.Int32 get_x()
  System.Int32 get_y()
  System.Int32 get_width()
  System.Int32 get_height()
  UnityEngine.TextCore.GlyphRect get_zero()
  System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.TextCore.GlyphRect other)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.GlyphMetrics
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  private           System.Single                   m_Width  // 0x10
  private           System.Single                   m_Height  // 0x14
  private           System.Single                   m_HorizontalBearingX  // 0x18
  private           System.Single                   m_HorizontalBearingY  // 0x1C
  private           System.Single                   m_HorizontalAdvance  // 0x20
METHODS:
  System.Single get_width()
  System.Single get_height()
  System.Single get_horizontalBearingX()
  System.Single get_horizontalBearingY()
  System.Single get_horizontalAdvance()
  System.Void .ctor(System.Single width, System.Single height, System.Single bearingX, System.Single bearingY, System.Single advance)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.TextCore.GlyphMetrics other)
END_CLASS

CLASS: UnityEngine.TextCore.Glyph
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  private           System.UInt32                   m_Index  // 0x10
  private           UnityEngine.TextCore.GlyphMetricsm_Metrics  // 0x14
  private           UnityEngine.TextCore.GlyphRect  m_GlyphRect  // 0x28
  private           System.Single                   m_Scale  // 0x38
  private           System.Int32                    m_AtlasIndex  // 0x3C
  private           UnityEngine.TextCore.GlyphClassDefinitionTypem_ClassDefinitionType  // 0x40
METHODS:
  System.UInt32 get_index()
  System.Void set_index(System.UInt32 value)
  UnityEngine.TextCore.GlyphMetrics get_metrics()
  System.Void set_metrics(UnityEngine.TextCore.GlyphMetrics value)
  UnityEngine.TextCore.GlyphRect get_glyphRect()
  System.Void set_glyphRect(UnityEngine.TextCore.GlyphRect value)
  System.Single get_scale()
  System.Void set_scale(System.Single value)
  System.Int32 get_atlasIndex()
  System.Void set_atlasIndex(System.Int32 value)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct)
  System.Void .ctor(System.UInt32 index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, System.Single scale, System.Int32 atlasIndex)
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphLoadFlags
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_DEFAULT  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_NO_SCALE  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_NO_HINTING  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_RENDER  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_NO_BITMAP  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_FORCE_AUTOHINT  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_MONOCHROME  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_NO_AUTOHINT  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_COLOR  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_COMPUTE_METRICS  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_BITMAP_METRICS_ONLY  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontEngineError
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorSuccess  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_File_Path  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_File_Format  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_File_Structure  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_File  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Table  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Glyph_Index  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Character_Code  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Pixel_Size  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Library  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Face  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Library_or_Face  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorAtlas_Generation_Cancelled  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_SharedTextureData  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorOpenTypeLayoutLookup_Mismatch  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphRenderMode
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSMOOTH_HINTED  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSMOOTH  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeCOLOR_HINTED  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeCOLOR  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeRASTER_HINTED  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeRASTER  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDF  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDF8  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDF16  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDF32  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDFAA_HINTED  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDFAA  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphPackingMode
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeBestShortSideFit  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeBestLongSideFit  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeBestAreaFit  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeBottomLeftRule  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeContactPointRule  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontReference
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.String                   familyName  // 0x10
  public            System.String                   styleName  // 0x18
  public            System.Int32                    faceIndex  // 0x20
  public            System.String                   filePath  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontEngine
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private   static  UnityEngine.TextCore.Glyph[]    s_Glyphs  // 0x0
  private   static  System.UInt32[]                 s_GlyphIndexes_MarshallingArray_A  // 0x8
  private   static  UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[]s_GlyphMarshallingStruct_IN  // 0x10
  private   static  UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[]s_GlyphMarshallingStruct_OUT  // 0x18
  private   static  UnityEngine.TextCore.GlyphRect[]s_FreeGlyphRects  // 0x20
  private   static  UnityEngine.TextCore.GlyphRect[]s_UsedGlyphRects  // 0x28
  private   static  UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]s_PairAdjustmentRecords_MarshallingArray  // 0x30
  private   static  System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph>s_GlyphLookupDictionary  // 0x38
METHODS:
  UnityEngine.TextCore.LowLevel.FontEngineError InitializeFontEngine()
  System.Int32 InitializeFontEngine_Internal()
  UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(System.String filePath, System.Int32 pointSize, System.Int32 faceIndex)
  System.Int32 LoadFontFace_With_Size_And_FaceIndex_Internal(System.String filePath, System.Int32 pointSize, System.Int32 faceIndex)
  UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, System.Int32 pointSize)
  System.Int32 LoadFontFace_With_Size_FromFont_Internal(UnityEngine.Font font, System.Int32 pointSize)
  UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, System.Int32 pointSize, System.Int32 faceIndex)
  System.Int32 LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(UnityEngine.Font font, System.Int32 pointSize, System.Int32 faceIndex)
  UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(System.String familyName, System.String styleName, System.Int32 pointSize)
  System.Int32 LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(System.String familyName, System.String styleName, System.Int32 pointSize)
  System.Boolean TryGetSystemFontReference(System.String familyName, System.String styleName, UnityEngine.TextCore.LowLevel.FontReference& fontRef)
  System.Boolean TryGetSystemFontReference_Internal(System.String familyName, System.String styleName, UnityEngine.TextCore.LowLevel.FontReference& fontRef)
  UnityEngine.TextCore.FaceInfo GetFaceInfo()
  System.Int32 GetFaceInfo_Internal(UnityEngine.TextCore.FaceInfo& faceInfo)
  System.UInt32 GetGlyphIndex(System.UInt32 unicode)
  System.Boolean TryGetGlyphWithUnicodeValue(System.UInt32 unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, UnityEngine.TextCore.Glyph& glyph)
  System.Boolean TryGetGlyphWithUnicodeValue_Internal(System.UInt32 unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyphStruct)
  System.Boolean TryGetGlyphWithIndexValue(System.UInt32 glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, UnityEngine.TextCore.Glyph& glyph)
  System.Boolean TryGetGlyphWithIndexValue_Internal(System.UInt32 glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyphStruct)
  System.Void SetTextureUploadMode(System.Boolean shouldUploadImmediately)
  System.Boolean TryAddGlyphToTexture(System.UInt32 glyphIndex, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.Glyph& glyph)
  System.Boolean TryAddGlyphToTexture_Internal(System.UInt32 glyphIndex, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, System.Int32& freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, System.Int32& usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyph)
  System.Boolean TryAddGlyphsToTexture(System.Collections.Generic.List<System.UInt32> glyphIndexes, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.Glyph[]& glyphs)
  System.Boolean TryAddGlyphsToTexture_Internal(System.UInt32[] glyphIndex, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, System.Int32& freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, System.Int32& usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, System.Int32& glyphCount)
  UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(System.UInt32[] glyphIndexes)
  UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes, System.Int32& recordCount)
  System.Int32 PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(System.UInt32[] glyphIndexes, System.Int32& recordCount)
  System.Int32 GetPairAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords)
  System.Void GenericListToMarshallingArray(System.Collections.Generic.List<T>& srcList, T[]& dstArray)
  System.Void SetMarshallingArraySize(T[]& marshallingArray, System.Int32 recordCount)
  System.Void ResetAtlasTexture(UnityEngine.Texture2D texture)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontEngineUtilities
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
METHODS:
  System.Int32 MaxValue(System.Int32 a, System.Int32 b, System.Int32 c)
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.UInt32                   index  // 0x10
  public            UnityEngine.TextCore.GlyphMetricsmetrics  // 0x14
  public            UnityEngine.TextCore.GlyphRect  glyphRect  // 0x28
  public            System.Single                   scale  // 0x38
  public            System.Int32                    atlasIndex  // 0x3C
  public            UnityEngine.TextCore.GlyphClassDefinitionTypeclassDefinitionType  // 0x40
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.FontFeatureLookupFlagsNone  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontFeatureLookupFlagsIgnoreLigatures  // 0x0
  public    static  UnityEngine.TextCore.LowLevel.FontFeatureLookupFlagsIgnoreSpacingAdjustments  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphValueRecord
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  private           System.Single                   m_XPlacement  // 0x10
  private           System.Single                   m_YPlacement  // 0x14
  private           System.Single                   m_XAdvance  // 0x18
  private           System.Single                   m_YAdvance  // 0x1C
METHODS:
  System.Single get_xPlacement()
  System.Single get_yPlacement()
  System.Single get_xAdvance()
  System.Single get_yAdvance()
  UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, UnityEngine.TextCore.LowLevel.GlyphValueRecord b)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord other)
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  private           System.UInt32                   m_GlyphIndex  // 0x10
  private           UnityEngine.TextCore.LowLevel.GlyphValueRecordm_GlyphValueRecord  // 0x14
METHODS:
  System.UInt32 get_glyphIndex()
  UnityEngine.TextCore.LowLevel.GlyphValueRecord get_glyphValueRecord()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord other)
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  private           UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecordm_FirstAdjustmentRecord  // 0x10
  private           UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecordm_SecondAdjustmentRecord  // 0x24
  private           UnityEngine.TextCore.LowLevel.FontFeatureLookupFlagsm_FeatureLookupFlags  // 0x38
METHODS:
  UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_firstAdjustmentRecord()
  UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_secondAdjustmentRecord()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord other)
END_CLASS

