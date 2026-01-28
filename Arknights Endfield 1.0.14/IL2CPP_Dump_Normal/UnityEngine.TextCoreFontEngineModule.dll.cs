// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TextCoreFontEngineModule.dll
// Classes:  18
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine.TextCore
{

    // TypeToken: 0x2000002
    public struct FaceInfo
    {
        // Fields
        private System.Int32 m_FaceIndex;        // 0x10
        private System.String m_FamilyName;        // 0x18
        private System.String m_StyleName;        // 0x20
        private System.Int32 m_PointSize;        // 0x28
        private System.Single m_Scale;        // 0x2C
        private System.Int32 m_UnitsPerEM;        // 0x30
        private System.Single m_LineHeight;        // 0x34
        private System.Single m_AscentLine;        // 0x38
        private System.Single m_CapLine;        // 0x3C
        private System.Single m_MeanLine;        // 0x40
        private System.Single m_Baseline;        // 0x44
        private System.Single m_DescentLine;        // 0x48
        private System.Single m_SuperscriptOffset;        // 0x4C
        private System.Single m_SuperscriptSize;        // 0x50
        private System.Single m_SubscriptOffset;        // 0x54
        private System.Single m_SubscriptSize;        // 0x58
        private System.Single m_UnderlineOffset;        // 0x5C
        private System.Single m_UnderlineThickness;        // 0x60
        private System.Single m_StrikethroughOffset;        // 0x64
        private System.Single m_StrikethroughThickness;        // 0x68
        private System.Single m_TabWidth;        // 0x6C

        // Methods
        private System.Int32 get_faceIndex() { }
        private System.String get_familyName() { }
        private System.Void set_familyName(System.String value) { }
        private System.String get_styleName() { }
        private System.Void set_styleName(System.String value) { }
        private System.Int32 get_pointSize() { }
        private System.Void set_pointSize(System.Int32 value) { }
        private System.Single get_scale() { }
        private System.Void set_scale(System.Single value) { }
        private System.Single get_lineHeight() { }
        private System.Void set_lineHeight(System.Single value) { }
        private System.Single get_ascentLine() { }
        private System.Void set_ascentLine(System.Single value) { }
        private System.Single get_capLine() { }
        private System.Void set_capLine(System.Single value) { }
        private System.Single get_meanLine() { }
        private System.Void set_meanLine(System.Single value) { }
        private System.Single get_baseline() { }
        private System.Void set_baseline(System.Single value) { }
        private System.Single get_descentLine() { }
        private System.Void set_descentLine(System.Single value) { }
        private System.Single get_superscriptOffset() { }
        private System.Void set_superscriptOffset(System.Single value) { }
        private System.Single get_superscriptSize() { }
        private System.Void set_superscriptSize(System.Single value) { }
        private System.Single get_subscriptOffset() { }
        private System.Void set_subscriptOffset(System.Single value) { }
        private System.Single get_subscriptSize() { }
        private System.Void set_subscriptSize(System.Single value) { }
        private System.Single get_underlineOffset() { }
        private System.Void set_underlineOffset(System.Single value) { }
        private System.Single get_underlineThickness() { }
        private System.Void set_underlineThickness(System.Single value) { }
        private System.Single get_strikethroughOffset() { }
        private System.Void set_strikethroughOffset(System.Single value) { }
        private System.Void set_strikethroughThickness(System.Single value) { }
        private System.Single get_tabWidth() { }
        private System.Void set_tabWidth(System.Single value) { }

    }

    // TypeToken: 0x2000003
    public struct GlyphClassDefinitionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.GlyphClassDefinitionType Undefined;        // 0x0
        public static UnityEngine.TextCore.GlyphClassDefinitionType Base;        // 0x0
        public static UnityEngine.TextCore.GlyphClassDefinitionType Ligature;        // 0x0
        public static UnityEngine.TextCore.GlyphClassDefinitionType Mark;        // 0x0
        public static UnityEngine.TextCore.GlyphClassDefinitionType Component;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct GlyphRect, IEquatable`1
    {
        // Fields
        private System.Int32 m_X;        // 0x10
        private System.Int32 m_Y;        // 0x14
        private System.Int32 m_Width;        // 0x18
        private System.Int32 m_Height;        // 0x1C
        private static readonly UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect;        // 0x0

        // Methods
        private System.Int32 get_x() { }
        private System.Int32 get_y() { }
        private System.Int32 get_width() { }
        private System.Int32 get_height() { }
        private UnityEngine.TextCore.GlyphRect get_zero() { }
        private System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.TextCore.GlyphRect other) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000005
    public struct GlyphMetrics, IEquatable`1
    {
        // Fields
        private System.Single m_Width;        // 0x10
        private System.Single m_Height;        // 0x14
        private System.Single m_HorizontalBearingX;        // 0x18
        private System.Single m_HorizontalBearingY;        // 0x1C
        private System.Single m_HorizontalAdvance;        // 0x20

        // Methods
        private System.Single get_width() { }
        private System.Single get_height() { }
        private System.Single get_horizontalBearingX() { }
        private System.Single get_horizontalBearingY() { }
        private System.Single get_horizontalAdvance() { }
        private System.Void .ctor(System.Single width, System.Single height, System.Single bearingX, System.Single bearingY, System.Single advance) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.TextCore.GlyphMetrics other) { }

    }

    // TypeToken: 0x2000006
    public class Glyph
    {
        // Fields
        private System.UInt32 m_Index;        // 0x10
        private UnityEngine.TextCore.GlyphMetrics m_Metrics;        // 0x14
        private UnityEngine.TextCore.GlyphRect m_GlyphRect;        // 0x28
        private System.Single m_Scale;        // 0x38
        private System.Int32 m_AtlasIndex;        // 0x3C
        private UnityEngine.TextCore.GlyphClassDefinitionType m_ClassDefinitionType;        // 0x40

        // Methods
        private System.UInt32 get_index() { }
        private System.Void set_index(System.UInt32 value) { }
        private UnityEngine.TextCore.GlyphMetrics get_metrics() { }
        private System.Void set_metrics(UnityEngine.TextCore.GlyphMetrics value) { }
        private UnityEngine.TextCore.GlyphRect get_glyphRect() { }
        private System.Void set_glyphRect(UnityEngine.TextCore.GlyphRect value) { }
        private System.Single get_scale() { }
        private System.Void set_scale(System.Single value) { }
        private System.Int32 get_atlasIndex() { }
        private System.Void set_atlasIndex(System.Int32 value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct) { }
        private System.Void .ctor(System.UInt32 index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, System.Single scale, System.Int32 atlasIndex) { }

    }

}

namespace UnityEngine.TextCore.LowLevel
{

    // TypeToken: 0x2000007
    public struct GlyphLoadFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_DEFAULT;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_NO_SCALE;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_NO_HINTING;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_RENDER;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_NO_BITMAP;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_FORCE_AUTOHINT;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_MONOCHROME;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_NO_AUTOHINT;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_COLOR;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_COMPUTE_METRICS;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphLoadFlags LOAD_BITMAP_METRICS_ONLY;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct FontEngineError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.LowLevel.FontEngineError Success;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_File_Path;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_File_Format;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_File_Structure;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_File;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Table;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Glyph_Index;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Character_Code;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Pixel_Size;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Library;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Face;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Library_or_Face;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Atlas_Generation_Cancelled;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError Invalid_SharedTextureData;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontEngineError OpenTypeLayoutLookup_Mismatch;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct GlyphRenderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode SMOOTH_HINTED;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode SMOOTH;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode COLOR_HINTED;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode COLOR;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode RASTER_HINTED;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode RASTER;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode SDF;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode SDF8;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode SDF16;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode SDF32;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode SDFAA_HINTED;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphRenderMode SDFAA;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct GlyphPackingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.LowLevel.GlyphPackingMode BestShortSideFit;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphPackingMode BestLongSideFit;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphPackingMode BestAreaFit;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphPackingMode BottomLeftRule;        // 0x0
        public static UnityEngine.TextCore.LowLevel.GlyphPackingMode ContactPointRule;        // 0x0

    }

    // TypeToken: 0x200000B
    public struct FontReference
    {
        // Fields
        public System.String familyName;        // 0x10
        public System.String styleName;        // 0x18
        public System.Int32 faceIndex;        // 0x20
        public System.String filePath;        // 0x28

    }

    // TypeToken: 0x200000C
    public class FontEngine
    {
        // Fields
        private static UnityEngine.TextCore.Glyph[] s_Glyphs;        // 0x0
        private static System.UInt32[] s_GlyphIndexes_MarshallingArray_A;        // 0x8
        private static UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN;        // 0x10
        private static UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT;        // 0x18
        private static UnityEngine.TextCore.GlyphRect[] s_FreeGlyphRects;        // 0x20
        private static UnityEngine.TextCore.GlyphRect[] s_UsedGlyphRects;        // 0x28
        private static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;        // 0x30
        private static System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary;        // 0x38

        // Methods
        private UnityEngine.TextCore.LowLevel.FontEngineError InitializeFontEngine() { }
        private System.Int32 InitializeFontEngine_Internal() { }
        private UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(System.String filePath, System.Int32 pointSize, System.Int32 faceIndex) { }
        private System.Int32 LoadFontFace_With_Size_And_FaceIndex_Internal(System.String filePath, System.Int32 pointSize, System.Int32 faceIndex) { }
        private UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, System.Int32 pointSize) { }
        private System.Int32 LoadFontFace_With_Size_FromFont_Internal(UnityEngine.Font font, System.Int32 pointSize) { }
        private UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, System.Int32 pointSize, System.Int32 faceIndex) { }
        private System.Int32 LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(UnityEngine.Font font, System.Int32 pointSize, System.Int32 faceIndex) { }
        private UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(System.String familyName, System.String styleName, System.Int32 pointSize) { }
        private System.Int32 LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(System.String familyName, System.String styleName, System.Int32 pointSize) { }
        private System.Boolean TryGetSystemFontReference(System.String familyName, System.String styleName, UnityEngine.TextCore.LowLevel.FontReference& fontRef) { }
        private System.Boolean TryGetSystemFontReference_Internal(System.String familyName, System.String styleName, UnityEngine.TextCore.LowLevel.FontReference& fontRef) { }
        private UnityEngine.TextCore.FaceInfo GetFaceInfo() { }
        private System.Int32 GetFaceInfo_Internal(UnityEngine.TextCore.FaceInfo& faceInfo) { }
        private System.UInt32 GetGlyphIndex(System.UInt32 unicode) { }
        private System.Boolean TryGetGlyphWithUnicodeValue(System.UInt32 unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, UnityEngine.TextCore.Glyph& glyph) { }
        private System.Boolean TryGetGlyphWithUnicodeValue_Internal(System.UInt32 unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyphStruct) { }
        private System.Boolean TryGetGlyphWithIndexValue(System.UInt32 glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, UnityEngine.TextCore.Glyph& glyph) { }
        private System.Boolean TryGetGlyphWithIndexValue_Internal(System.UInt32 glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyphStruct) { }
        private System.Void SetTextureUploadMode(System.Boolean shouldUploadImmediately) { }
        private System.Boolean TryAddGlyphToTexture(System.UInt32 glyphIndex, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.Glyph& glyph) { }
        private System.Boolean TryAddGlyphToTexture_Internal(System.UInt32 glyphIndex, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, System.Int32& freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, System.Int32& usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyph) { }
        private System.Boolean TryAddGlyphsToTexture(System.Collections.Generic.List<System.UInt32> glyphIndexes, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.Glyph[]& glyphs) { }
        private System.Boolean TryAddGlyphsToTexture_Internal(System.UInt32[] glyphIndex, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, System.Int32& freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, System.Int32& usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, System.Int32& glyphCount) { }
        private UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(System.UInt32[] glyphIndexes) { }
        private UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes, System.Int32& recordCount) { }
        private System.Int32 PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(System.UInt32[] glyphIndexes, System.Int32& recordCount) { }
        private System.Int32 GetPairAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }
        private System.Void GenericListToMarshallingArray(System.Collections.Generic.List<T>& srcList, T[]& dstArray) { }
        private System.Void SetMarshallingArraySize(T[]& marshallingArray, System.Int32 recordCount) { }
        private System.Void ResetAtlasTexture(UnityEngine.Texture2D texture) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public struct FontEngineUtilities
    {
        // Methods
        private System.Int32 MaxValue(System.Int32 a, System.Int32 b, System.Int32 c) { }

    }

    // TypeToken: 0x200000E
    public struct GlyphMarshallingStruct
    {
        // Fields
        public System.UInt32 index;        // 0x10
        public UnityEngine.TextCore.GlyphMetrics metrics;        // 0x14
        public UnityEngine.TextCore.GlyphRect glyphRect;        // 0x28
        public System.Single scale;        // 0x38
        public System.Int32 atlasIndex;        // 0x3C
        public UnityEngine.TextCore.GlyphClassDefinitionType classDefinitionType;        // 0x40

    }

    // TypeToken: 0x200000F
    public struct FontFeatureLookupFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags None;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags IgnoreLigatures;        // 0x0
        public static UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags IgnoreSpacingAdjustments;        // 0x0

    }

    // TypeToken: 0x2000010
    public struct GlyphValueRecord, IEquatable`1
    {
        // Fields
        private System.Single m_XPlacement;        // 0x10
        private System.Single m_YPlacement;        // 0x14
        private System.Single m_XAdvance;        // 0x18
        private System.Single m_YAdvance;        // 0x1C

        // Methods
        private System.Single get_xPlacement() { }
        private System.Single get_yPlacement() { }
        private System.Single get_xAdvance() { }
        private System.Single get_yAdvance() { }
        private UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, UnityEngine.TextCore.LowLevel.GlyphValueRecord b) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord other) { }

    }

    // TypeToken: 0x2000011
    public struct GlyphAdjustmentRecord, IEquatable`1
    {
        // Fields
        private System.UInt32 m_GlyphIndex;        // 0x10
        private UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord;        // 0x14

        // Methods
        private System.UInt32 get_glyphIndex() { }
        private UnityEngine.TextCore.LowLevel.GlyphValueRecord get_glyphValueRecord() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord other) { }

    }

    // TypeToken: 0x2000012
    public struct GlyphPairAdjustmentRecord, IEquatable`1
    {
        // Fields
        private UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord;        // 0x10
        private UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord;        // 0x24
        private UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags;        // 0x38

        // Methods
        private UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_firstAdjustmentRecord() { }
        private UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_secondAdjustmentRecord() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord other) { }

    }

}

