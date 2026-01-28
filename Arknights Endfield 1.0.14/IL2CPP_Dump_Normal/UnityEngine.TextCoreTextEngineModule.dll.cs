// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TextCoreTextEngineModule.dll
// Classes:  59
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000024
    public struct SpecialCharacter
    {
        // Fields
        public UnityEngine.TextCore.Text.Character character;        // 0x10
        public UnityEngine.TextCore.Text.FontAsset fontAsset;        // 0x18
        public UnityEngine.Material material;        // 0x20
        public System.Int32 materialIndex;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.TextCore.Text.Character character, System.Int32 materialIndex) { }

    }

    // TypeToken: 0x2000034
    public struct FontAssetRef
    {
        // Fields
        public System.Int32 nameHashCode;        // 0x10
        public System.Int32 familyNameHashCode;        // 0x14
        public System.Int32 styleNameHashCode;        // 0x18
        public System.Int64 familyNameAndStyleHashCode;        // 0x20
        public readonly UnityEngine.TextCore.Text.FontAsset fontAsset;        // 0x28

        // Methods
        private System.Void .ctor(System.Int32 nameHashCode, System.Int32 familyNameHashCode, System.Int32 styleNameHashCode, UnityEngine.TextCore.Text.FontAsset fontAsset) { }

    }

    // TypeToken: 0x2000036
    public struct FontReferenceMap
    {
        // Fields
        public UnityEngine.Font font;        // 0x10
        public UnityEngine.TextCore.Text.FontAsset fontAsset;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Font font, UnityEngine.TextCore.Text.FontAsset fontAsset) { }

    }

namespace UnityEngine.TextCore.Text
{

    // TypeToken: 0x2000002
    public class Character : TextElement
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph) { }
        private System.Void .ctor(System.UInt32 unicode, System.UInt32 glyphIndex) { }

    }

    // TypeToken: 0x2000003
    public class ColorUtilities
    {
        // Methods
        private System.Boolean CompareColors(UnityEngine.Color32 a, UnityEngine.Color32 b) { }
        private UnityEngine.Color32 MultiplyColors(UnityEngine.Color32 c1, UnityEngine.Color32 c2) { }

    }

    // TypeToken: 0x2000004
    public struct TextFontWeight
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.TextFontWeight Thin;        // 0x0
        public static UnityEngine.TextCore.Text.TextFontWeight ExtraLight;        // 0x0
        public static UnityEngine.TextCore.Text.TextFontWeight Light;        // 0x0
        public static UnityEngine.TextCore.Text.TextFontWeight Regular;        // 0x0
        public static UnityEngine.TextCore.Text.TextFontWeight Medium;        // 0x0
        public static UnityEngine.TextCore.Text.TextFontWeight SemiBold;        // 0x0
        public static UnityEngine.TextCore.Text.TextFontWeight Bold;        // 0x0
        public static UnityEngine.TextCore.Text.TextFontWeight Heavy;        // 0x0
        public static UnityEngine.TextCore.Text.TextFontWeight Black;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct FontWeightPair
    {
        // Fields
        public UnityEngine.TextCore.Text.FontAsset regularTypeface;        // 0x10
        public UnityEngine.TextCore.Text.FontAsset italicTypeface;        // 0x18

    }

    // TypeToken: 0x2000006
    public struct FontAssetCreationEditorSettings
    {
        // Fields
        public System.String sourceFontFileGUID;        // 0x10
        public System.Int32 faceIndex;        // 0x18
        public System.Int32 pointSizeSamplingMode;        // 0x1C
        public System.Int32 pointSize;        // 0x20
        public System.Int32 padding;        // 0x24
        public System.Int32 packingMode;        // 0x28
        public System.Int32 atlasWidth;        // 0x2C
        public System.Int32 atlasHeight;        // 0x30
        public System.Int32 characterSetSelectionMode;        // 0x34
        public System.String characterSequence;        // 0x38
        public System.String referencedFontAssetGUID;        // 0x40
        public System.String referencedTextAssetGUID;        // 0x48
        public System.Int32 fontStyle;        // 0x50
        public System.Single fontStyleModifier;        // 0x54
        public System.Int32 renderMode;        // 0x58
        public System.Boolean includeFontFeatures;        // 0x5C

    }

    // TypeToken: 0x2000007
    public struct AtlasPopulationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.AtlasPopulationMode Static;        // 0x0
        public static UnityEngine.TextCore.Text.AtlasPopulationMode Dynamic;        // 0x0
        public static UnityEngine.TextCore.Text.AtlasPopulationMode DynamicOS;        // 0x0

    }

    // TypeToken: 0x2000008
    public class FontAsset : TextAsset
    {
        // Fields
        private System.String m_SourceFontFileGUID;        // 0x38
        private UnityEngine.Font m_SourceFontFile;        // 0x40
        private UnityEngine.TextCore.Text.AtlasPopulationMode m_AtlasPopulationMode;        // 0x48
        private System.Boolean InternalDynamicOS;        // 0x4C
        private UnityEngine.TextCore.FaceInfo m_FaceInfo;        // 0x50
        private System.Int32 m_FamilyNameHashCode;        // 0xB0
        private System.Int32 m_StyleNameHashCode;        // 0xB4
        private UnityEngine.TextCore.Text.FontWeightPair[] m_FontWeightTable;        // 0xB8
        private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable;        // 0xC0
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary;        // 0xC8
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharacterTable;        // 0xD0
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.Character> m_CharacterLookupDictionary;        // 0xD8
        private UnityEngine.Texture2D m_AtlasTexture;        // 0xE0
        private UnityEngine.Texture2D[] m_AtlasTextures;        // 0xE8
        private System.Int32 m_AtlasTextureIndex;        // 0xF0
        private System.Boolean m_IsMultiAtlasTexturesEnabled;        // 0xF4
        private System.Boolean m_ClearDynamicDataOnBuild;        // 0xF5
        private System.Int32 m_AtlasWidth;        // 0xF8
        private System.Int32 m_AtlasHeight;        // 0xFC
        private System.Int32 m_AtlasPadding;        // 0x100
        private UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;        // 0x104
        private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;        // 0x108
        private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;        // 0x110
        private UnityEngine.TextCore.Text.FontFeatureTable m_FontFeatureTable;        // 0x118
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssetTable;        // 0x120
        private UnityEngine.TextCore.Text.FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings;        // 0x128
        private System.Single m_RegularStyleWeight;        // 0x178
        private System.Single m_RegularStyleSpacing;        // 0x17C
        private System.Single m_BoldStyleWeight;        // 0x180
        private System.Single m_BoldStyleSpacing;        // 0x184
        private System.Byte m_ItalicStyleSlant;        // 0x188
        private System.Byte m_TabMultiple;        // 0x189
        private System.Boolean IsFontAssetLookupTablesDirty;        // 0x18A
        private static Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;        // 0x0
        private static Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker;        // 0x8
        private static Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker;        // 0x10
        private static Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker;        // 0x18
        private static Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;        // 0x20
        private static Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker;        // 0x28
        private static Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker;        // 0x30
        private static System.String s_DefaultMaterialSuffix;        // 0x38
        private static System.Collections.Generic.HashSet<System.Int32> k_SearchedFontAssetLookup;        // 0x40
        private static System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_FontFeaturesUpdateQueue;        // 0x48
        private static System.Collections.Generic.HashSet<System.Int32> k_FontAssets_FontFeaturesUpdateQueueLookup;        // 0x50
        private static System.Collections.Generic.List<UnityEngine.Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;        // 0x58
        private static System.Collections.Generic.HashSet<System.Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup;        // 0x60
        private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender;        // 0x190
        private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered;        // 0x198
        private System.Collections.Generic.List<System.UInt32> m_GlyphIndexList;        // 0x1A0
        private System.Collections.Generic.List<System.UInt32> m_GlyphIndexListNewlyAdded;        // 0x1A8
        private System.Collections.Generic.List<System.UInt32> m_GlyphsToAdd;        // 0x1B0
        private System.Collections.Generic.HashSet<System.UInt32> m_GlyphsToAddLookup;        // 0x1B8
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharactersToAdd;        // 0x1C0
        private System.Collections.Generic.HashSet<System.UInt32> m_CharactersToAddLookup;        // 0x1C8
        private System.Collections.Generic.List<System.UInt32> s_MissingCharacterList;        // 0x1D0
        private System.Collections.Generic.HashSet<System.UInt32> m_MissingUnicodesFromFontFile;        // 0x1D8
        private static System.UInt32[] k_GlyphIndexArray;        // 0x68

        // Methods
        private UnityEngine.Font get_sourceFontFile() { }
        private System.Void set_sourceFontFile(UnityEngine.Font value) { }
        private UnityEngine.TextCore.Text.AtlasPopulationMode get_atlasPopulationMode() { }
        private System.Void set_atlasPopulationMode(UnityEngine.TextCore.Text.AtlasPopulationMode value) { }
        private UnityEngine.TextCore.FaceInfo get_faceInfo() { }
        private System.Void set_faceInfo(UnityEngine.TextCore.FaceInfo value) { }
        private System.Int32 get_familyNameHashCode() { }
        private System.Void set_familyNameHashCode(System.Int32 value) { }
        private System.Int32 get_styleNameHashCode() { }
        private System.Void set_styleNameHashCode(System.Int32 value) { }
        private UnityEngine.TextCore.Text.FontWeightPair[] get_fontWeightTable() { }
        private System.Void set_fontWeightTable(UnityEngine.TextCore.Text.FontWeightPair[] value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable() { }
        private System.Void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value) { }
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> get_glyphLookupTable() { }
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> get_characterTable() { }
        private System.Void set_characterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> value) { }
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.Character> get_characterLookupTable() { }
        private UnityEngine.Texture2D get_atlasTexture() { }
        private UnityEngine.Texture2D[] get_atlasTextures() { }
        private System.Void set_atlasTextures(UnityEngine.Texture2D[] value) { }
        private System.Int32 get_atlasTextureCount() { }
        private System.Boolean get_isMultiAtlasTexturesEnabled() { }
        private System.Void set_isMultiAtlasTexturesEnabled(System.Boolean value) { }
        private System.Boolean get_clearDynamicDataOnBuild() { }
        private System.Void set_clearDynamicDataOnBuild(System.Boolean value) { }
        private System.Int32 get_atlasWidth() { }
        private System.Void set_atlasWidth(System.Int32 value) { }
        private System.Int32 get_atlasHeight() { }
        private System.Void set_atlasHeight(System.Int32 value) { }
        private System.Int32 get_atlasPadding() { }
        private System.Void set_atlasPadding(System.Int32 value) { }
        private UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode() { }
        private System.Void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects() { }
        private System.Void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects() { }
        private System.Void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value) { }
        private UnityEngine.TextCore.Text.FontFeatureTable get_fontFeatureTable() { }
        private System.Void set_fontFeatureTable(UnityEngine.TextCore.Text.FontFeatureTable value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssetTable() { }
        private System.Void set_fallbackFontAssetTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value) { }
        private UnityEngine.TextCore.Text.FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }
        private System.Void set_fontAssetCreationEditorSettings(UnityEngine.TextCore.Text.FontAssetCreationEditorSettings value) { }
        private System.Single get_regularStyleWeight() { }
        private System.Void set_regularStyleWeight(System.Single value) { }
        private System.Single get_regularStyleSpacing() { }
        private System.Void set_regularStyleSpacing(System.Single value) { }
        private System.Single get_boldStyleWeight() { }
        private System.Void set_boldStyleWeight(System.Single value) { }
        private System.Single get_boldStyleSpacing() { }
        private System.Void set_boldStyleSpacing(System.Single value) { }
        private System.Byte get_italicStyleSlant() { }
        private System.Void set_italicStyleSlant(System.Byte value) { }
        private System.Byte get_tabMultiple() { }
        private System.Void set_tabMultiple(System.Byte value) { }
        private UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String familyName, System.String styleName, System.Int32 pointSize) { }
        private UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String fontFilePath, System.Int32 faceIndex, System.Int32 samplingPointSize, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport) { }
        private UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font) { }
        private UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, System.Int32 samplingPointSize, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport) { }
        private UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, System.Int32 faceIndex, System.Int32 samplingPointSize, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport) { }
        private UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font font, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport) { }
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void ReadFontAssetDefinition() { }
        private System.Void InitializeDictionaryLookupTables() { }
        private System.Void InitializeGlyphLookupDictionary() { }
        private System.Void InitializeCharacterLookupDictionary() { }
        private System.Void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }
        private System.Void AddSynthesizedCharactersAndFaceMetrics() { }
        private System.Void AddSynthesizedCharacter(System.UInt32 unicode, System.Boolean isFontFaceLoaded, System.Boolean addImmediately) { }
        private System.Void AddCharacterToLookupCache(System.UInt32 unicode, UnityEngine.TextCore.Text.Character character) { }
        private UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace() { }
        private System.Void SortCharacterTable() { }
        private System.Void SortGlyphTable() { }
        private System.Void SortFontFeatureTable() { }
        private System.Void SortAllTables() { }
        private System.Boolean HasCharacter(System.Int32 character) { }
        private System.Boolean HasCharacter(System.Char character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter) { }
        private System.Boolean HasCharacter_Internal(System.UInt32 character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter) { }
        private System.Boolean HasCharacters(System.String text, System.Collections.Generic.List<System.Char>& missingCharacters) { }
        private System.Boolean HasCharacters(System.String text, System.UInt32[]& missingCharacters, System.Boolean searchFallbacks, System.Boolean tryAddCharacter) { }
        private System.Boolean HasCharacters(System.String text) { }
        private System.String GetCharacters(UnityEngine.TextCore.Text.FontAsset fontAsset) { }
        private System.Int32[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset fontAsset) { }
        private System.UInt32 GetGlyphIndex(System.UInt32 unicode) { }
        private System.Void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset fontAsset) { }
        private System.Void UpdateFontFeaturesForFontAssetsInQueue() { }
        private System.Void RegisterAtlasTextureForApply(UnityEngine.Texture2D texture) { }
        private System.Void UpdateAtlasTexturesInQueue() { }
        private System.Void UpdateFontAssetInUpdateQueue() { }
        private System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.Boolean includeFontFeatures) { }
        private System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.UInt32[]& missingUnicodes, System.Boolean includeFontFeatures) { }
        private System.Boolean TryAddCharacters(System.String characters, System.Boolean includeFontFeatures) { }
        private System.Boolean TryAddCharacters(System.String characters, System.String& missingCharacters, System.Boolean includeFontFeatures) { }
        private System.Boolean TryAddCharacterInternal(System.UInt32 unicode, UnityEngine.TextCore.Text.Character& character, System.Boolean shouldGetFontFeatures) { }
        private System.Boolean TryGetCharacter_and_QueueRenderToTexture(System.UInt32 unicode, UnityEngine.TextCore.Text.Character& character, System.Boolean shouldGetFontFeatures) { }
        private System.Void TryAddGlyphsToAtlasTextures() { }
        private System.Boolean TryAddGlyphsToNewAtlasTexture() { }
        private System.Void SetupNewAtlasTexture() { }
        private System.Void UpdateAtlasTexture() { }
        private System.Void UpdateGlyphAdjustmentRecords() { }
        private System.Void UpdateGlyphAdjustmentRecords(System.UInt32[] glyphIndexes) { }
        private System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes) { }
        private System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> newGlyphIndexes, System.Collections.Generic.List<System.UInt32> allGlyphIndexes) { }
        private System.Void CopyListDataToArray(System.Collections.Generic.List<T> srcList, T[]& dstArray) { }
        private System.Void ClearFontAssetData(System.Boolean setAtlasSizeToZero) { }
        private System.Void ClearFontAssetDataInternal() { }
        private System.Void UpdateFontAssetData() { }
        private System.Void ClearFontAssetTables() { }
        private System.Void ClearAtlasTextures(System.Boolean setAtlasSizeToZero) { }
        private System.Void DestroyAtlasTextures() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public class FontAssetUtilities
    {
        // Fields
        private static System.Collections.Generic.HashSet<System.Int32> k_SearchedAssets;        // 0x0

        // Methods
        private UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset(System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Boolean includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, System.Boolean& isAlternativeTypeface) { }
        private UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset_Internal(System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Boolean includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, System.Boolean& isAlternativeTypeface) { }
        private UnityEngine.TextCore.Text.Character GetCharacterFromFontAssets(System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, System.Boolean includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, System.Boolean& isAlternativeTypeface) { }
        private UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset(System.UInt32 unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.Boolean includeFallbacks) { }
        private UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(System.UInt32 unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.Boolean includeFallbacks) { }

    }

    // TypeToken: 0x200000B
    public class FontFeatureTable
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;        // 0x10
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup;        // 0x18

        // Methods
        private System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }
        private System.Void .ctor() { }
        private System.Void SortGlyphPairAdjustmentRecords() { }

    }

    // TypeToken: 0x200000D
    public struct Extents
    {
        // Fields
        public UnityEngine.Vector2 min;        // 0x10
        public UnityEngine.Vector2 max;        // 0x18

        // Methods
        private System.String ToString() { }

    }

    // TypeToken: 0x200000E
    public struct LineInfo
    {
        // Fields
        private System.Int32 controlCharacterCount;        // 0x10
        public System.Int32 characterCount;        // 0x14
        public System.Int32 visibleCharacterCount;        // 0x18
        public System.Int32 spaceCount;        // 0x1C
        public System.Int32 visibleSpaceCount;        // 0x20
        public System.Int32 wordCount;        // 0x24
        public System.Int32 firstCharacterIndex;        // 0x28
        public System.Int32 firstVisibleCharacterIndex;        // 0x2C
        public System.Int32 lastCharacterIndex;        // 0x30
        public System.Int32 lastVisibleCharacterIndex;        // 0x34
        public System.Single length;        // 0x38
        public System.Single lineHeight;        // 0x3C
        public System.Single ascender;        // 0x40
        public System.Single baseline;        // 0x44
        public System.Single descender;        // 0x48
        public System.Single maxAdvance;        // 0x4C
        public System.Single width;        // 0x50
        public System.Single marginLeft;        // 0x54
        public System.Single marginRight;        // 0x58
        public UnityEngine.TextCore.Text.TextAlignment alignment;        // 0x5C
        public UnityEngine.TextCore.Text.Extents lineExtents;        // 0x60

    }

    // TypeToken: 0x200000F
    public struct LinkInfo
    {
        // Fields
        public System.Int32 hashCode;        // 0x10
        public System.Int32 linkIdFirstCharacterIndex;        // 0x14
        public System.Int32 linkIdLength;        // 0x18
        public System.Int32 linkTextfirstCharacterIndex;        // 0x1C
        public System.Int32 linkTextLength;        // 0x20
        private System.Char[] linkId;        // 0x28

        // Methods
        private System.Void SetLinkId(System.Char[] text, System.Int32 startIndex, System.Int32 length) { }

    }

    // TypeToken: 0x2000010
    public class MaterialManager
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Material> s_FallbackMaterials;        // 0x0

        // Methods
        private UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial) { }
        private UnityEngine.Material GetFallbackMaterial(UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.Material sourceMaterial, System.Int32 atlasIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000011
    public struct MaterialReference
    {
        // Fields
        public System.Int32 index;        // 0x10
        public UnityEngine.TextCore.Text.FontAsset fontAsset;        // 0x18
        public UnityEngine.TextCore.Text.SpriteAsset spriteAsset;        // 0x20
        public UnityEngine.Material material;        // 0x28
        public System.Boolean isDefaultMaterial;        // 0x30
        public System.Boolean isFallbackMaterial;        // 0x31
        public UnityEngine.Material fallbackMaterial;        // 0x38
        public System.Single padding;        // 0x40
        public System.Int32 referenceCount;        // 0x44

        // Methods
        private System.Void .ctor(System.Int32 index, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.Material material, System.Single padding) { }
        private System.Int32 AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup) { }
        private System.Int32 AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.TextCore.Text.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup) { }

    }

    // TypeToken: 0x2000012
    public class MaterialReferenceManager
    {
        // Fields
        private static UnityEngine.TextCore.Text.MaterialReferenceManager s_Instance;        // 0x0
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material> m_FontMaterialReferenceLookup;        // 0x10
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset> m_FontAssetReferenceLookup;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.SpriteAsset> m_SpriteAssetReferenceLookup;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientReferenceLookup;        // 0x28

        // Methods
        private UnityEngine.TextCore.Text.MaterialReferenceManager get_instance() { }
        private System.Void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset) { }
        private System.Void AddFontAssetInternal(UnityEngine.TextCore.Text.FontAsset fontAsset) { }
        private System.Void AddSpriteAsset(System.Int32 hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset) { }
        private System.Void AddSpriteAssetInternal(System.Int32 hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset) { }
        private System.Void AddFontMaterial(System.Int32 hashCode, UnityEngine.Material material) { }
        private System.Void AddFontMaterialInternal(System.Int32 hashCode, UnityEngine.Material material) { }
        private System.Void AddColorGradientPreset(System.Int32 hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset) { }
        private System.Void AddColorGradientPreset_Internal(System.Int32 hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset) { }
        private System.Boolean TryGetFontAsset(System.Int32 hashCode, UnityEngine.TextCore.Text.FontAsset& fontAsset) { }
        private System.Boolean TryGetFontAssetInternal(System.Int32 hashCode, UnityEngine.TextCore.Text.FontAsset& fontAsset) { }
        private System.Boolean TryGetSpriteAsset(System.Int32 hashCode, UnityEngine.TextCore.Text.SpriteAsset& spriteAsset) { }
        private System.Boolean TryGetSpriteAssetInternal(System.Int32 hashCode, UnityEngine.TextCore.Text.SpriteAsset& spriteAsset) { }
        private System.Boolean TryGetColorGradientPreset(System.Int32 hashCode, UnityEngine.TextCore.Text.TextColorGradient& gradientPreset) { }
        private System.Boolean TryGetColorGradientPresetInternal(System.Int32 hashCode, UnityEngine.TextCore.Text.TextColorGradient& gradientPreset) { }
        private System.Boolean TryGetMaterial(System.Int32 hashCode, UnityEngine.Material& material) { }
        private System.Boolean TryGetMaterialInternal(System.Int32 hashCode, UnityEngine.Material& material) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public struct VertexSortingOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.VertexSortingOrder Normal;        // 0x0
        public static UnityEngine.TextCore.Text.VertexSortingOrder Reverse;        // 0x0

    }

    // TypeToken: 0x2000014
    public struct MeshInfo
    {
        // Fields
        private static readonly UnityEngine.Color32 k_DefaultColor;        // 0x0
        public System.Int32 vertexCount;        // 0x10
        public UnityEngine.Vector3[] vertices;        // 0x18
        public UnityEngine.Vector2[] uvs0;        // 0x20
        public UnityEngine.Vector2[] uvs2;        // 0x28
        public UnityEngine.Color32[] colors32;        // 0x30
        public System.Int32[] triangles;        // 0x38
        public UnityEngine.Material material;        // 0x40

        // Methods
        private System.Void .ctor(System.Int32 size) { }
        private System.Void ResizeMeshInfo(System.Int32 size) { }
        private System.Void Clear(System.Boolean uploadChanges) { }
        private System.Void ClearUnusedVertices() { }
        private System.Void SortGeometry(UnityEngine.TextCore.Text.VertexSortingOrder order) { }
        private System.Void SwapVertexData(System.Int32 src, System.Int32 dst) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000015
    public class SpriteAsset : TextAsset
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_NameLookup;        // 0x38
        private System.Collections.Generic.Dictionary<System.UInt32,System.Int32> m_GlyphIndexLookup;        // 0x40
        private UnityEngine.TextCore.FaceInfo m_FaceInfo;        // 0x48
        private UnityEngine.Texture m_SpriteAtlasTexture;        // 0xA8
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterTable;        // 0xB0
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterLookup;        // 0xB8
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphTable;        // 0xC0
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphLookup;        // 0xC8
        public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets;        // 0xD0
        private System.Boolean m_IsSpriteAssetLookupTablesDirty;        // 0xD8
        private static System.Collections.Generic.HashSet<System.Int32> k_searchedSpriteAssets;        // 0x0

        // Methods
        private UnityEngine.TextCore.FaceInfo get_faceInfo() { }
        private System.Void set_faceInfo(UnityEngine.TextCore.FaceInfo value) { }
        private UnityEngine.Texture get_spriteSheet() { }
        private System.Void set_spriteSheet(UnityEngine.Texture value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterTable() { }
        private System.Void set_spriteCharacterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> value) { }
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterLookupTable() { }
        private System.Void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> get_spriteGlyphTable() { }
        private System.Void set_spriteGlyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> value) { }
        private System.Void Awake() { }
        private System.Void UpdateLookupTables() { }
        private System.Int32 GetSpriteIndexFromHashcode(System.Int32 hashCode) { }
        private System.Int32 GetSpriteIndexFromUnicode(System.UInt32 unicode) { }
        private System.Int32 GetSpriteIndexFromName(System.String name) { }
        private UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex) { }
        private UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex) { }
        private UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex) { }
        private UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean includeFallbacks, System.Int32& spriteIndex, UnityEngine.TextCore.Text.TextSettings textSettings) { }
        private UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex) { }
        private UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex) { }
        private System.Void SortGlyphTable() { }
        private System.Void SortCharacterTable() { }
        private System.Void SortGlyphAndCharacterTables() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class SpriteCharacter : TextElement
    {
        // Fields
        private System.String m_Name;        // 0x30
        private System.Int32 m_HashCode;        // 0x38

        // Methods
        private System.String get_name() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class SpriteGlyph : Glyph
    {
        // Fields
        public UnityEngine.Sprite sprite;        // 0x48

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class TextAsset : ScriptableObject
    {
        // Fields
        private System.String m_Version;        // 0x18
        private System.Int32 m_InstanceID;        // 0x20
        private System.Int32 m_HashCode;        // 0x24
        private UnityEngine.Material m_Material;        // 0x28
        private System.Int32 m_MaterialHashCode;        // 0x30

        // Methods
        private System.String get_version() { }
        private System.Void set_version(System.String value) { }
        private System.Int32 get_instanceID() { }
        private System.Int32 get_hashCode() { }
        private System.Void set_hashCode(System.Int32 value) { }
        private UnityEngine.Material get_material() { }
        private System.Void set_material(UnityEngine.Material value) { }
        private System.Int32 get_materialHashCode() { }
        private System.Void set_materialHashCode(System.Int32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public struct ColorGradientMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.ColorGradientMode Single;        // 0x0
        public static UnityEngine.TextCore.Text.ColorGradientMode HorizontalGradient;        // 0x0
        public static UnityEngine.TextCore.Text.ColorGradientMode VerticalGradient;        // 0x0
        public static UnityEngine.TextCore.Text.ColorGradientMode FourCornersGradient;        // 0x0

    }

    // TypeToken: 0x200001B
    public class TextColorGradient : ScriptableObject
    {
        // Fields
        public UnityEngine.TextCore.Text.ColorGradientMode colorMode;        // 0x18
        public UnityEngine.Color topLeft;        // 0x1C
        public UnityEngine.Color topRight;        // 0x2C
        public UnityEngine.Color bottomLeft;        // 0x3C
        public UnityEngine.Color bottomRight;        // 0x4C
        private static UnityEngine.TextCore.Text.ColorGradientMode k_DefaultColorMode;        // 0x0
        private static readonly UnityEngine.Color k_DefaultColor;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Color color) { }
        private System.Void .ctor(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001C
    public struct TextElementType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.TextCore.Text.TextElementType Character;        // 0x0
        public static UnityEngine.TextCore.Text.TextElementType Sprite;        // 0x0

    }

    // TypeToken: 0x200001D
    public class TextElement
    {
        // Fields
        protected UnityEngine.TextCore.Text.TextElementType m_ElementType;        // 0x10
        private System.UInt32 m_Unicode;        // 0x14
        private UnityEngine.TextCore.Text.TextAsset m_TextAsset;        // 0x18
        private UnityEngine.TextCore.Glyph m_Glyph;        // 0x20
        private System.UInt32 m_GlyphIndex;        // 0x28
        private System.Single m_Scale;        // 0x2C

        // Methods
        private UnityEngine.TextCore.Text.TextElementType get_elementType() { }
        private System.UInt32 get_unicode() { }
        private System.Void set_unicode(System.UInt32 value) { }
        private UnityEngine.TextCore.Text.TextAsset get_textAsset() { }
        private System.Void set_textAsset(UnityEngine.TextCore.Text.TextAsset value) { }
        private UnityEngine.TextCore.Glyph get_glyph() { }
        private System.Void set_glyph(UnityEngine.TextCore.Glyph value) { }
        private System.UInt32 get_glyphIndex() { }
        private System.Void set_glyphIndex(System.UInt32 value) { }
        private System.Single get_scale() { }
        private System.Void set_scale(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public struct TextVertex
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Vector2 uv;        // 0x1C
        public UnityEngine.Vector2 uv2;        // 0x24
        public UnityEngine.Vector2 uv4;        // 0x2C
        public UnityEngine.Color32 color;        // 0x34

    }

    // TypeToken: 0x200001F
    public struct TextElementInfo
    {
        // Fields
        public System.Char character;        // 0x10
        public System.Int32 index;        // 0x14
        public UnityEngine.TextCore.Text.TextElementType elementType;        // 0x18
        public UnityEngine.TextCore.Text.TextElement textElement;        // 0x20
        public UnityEngine.TextCore.Text.FontAsset fontAsset;        // 0x28
        public UnityEngine.TextCore.Text.SpriteAsset spriteAsset;        // 0x30
        public System.Int32 spriteIndex;        // 0x38
        public UnityEngine.Material material;        // 0x40
        public System.Int32 materialReferenceIndex;        // 0x48
        public System.Boolean isUsingAlternateTypeface;        // 0x4C
        public System.Single pointSize;        // 0x50
        public System.Int32 lineNumber;        // 0x54
        public System.Int32 pageNumber;        // 0x58
        public System.Int32 vertexIndex;        // 0x5C
        public UnityEngine.TextCore.Text.TextVertex vertexTopLeft;        // 0x60
        public UnityEngine.TextCore.Text.TextVertex vertexBottomLeft;        // 0x88
        public UnityEngine.TextCore.Text.TextVertex vertexTopRight;        // 0xB0
        public UnityEngine.TextCore.Text.TextVertex vertexBottomRight;        // 0xD8
        public UnityEngine.Vector3 topLeft;        // 0x100
        public UnityEngine.Vector3 bottomLeft;        // 0x10C
        public UnityEngine.Vector3 topRight;        // 0x118
        public UnityEngine.Vector3 bottomRight;        // 0x124
        public System.Single origin;        // 0x130
        public System.Single ascender;        // 0x134
        public System.Single baseLine;        // 0x138
        public System.Single descender;        // 0x13C
        public System.Single xAdvance;        // 0x140
        public System.Single aspectRatio;        // 0x144
        public System.Single scale;        // 0x148
        public UnityEngine.Color32 color;        // 0x14C
        public UnityEngine.Color32 underlineColor;        // 0x150
        public UnityEngine.Color32 strikethroughColor;        // 0x154
        public UnityEngine.Color32 highlightColor;        // 0x158
        public UnityEngine.TextCore.Text.FontStyles style;        // 0x15C
        public System.Boolean isVisible;        // 0x160

    }

    // TypeToken: 0x2000020
    public struct TextOverflowMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.TextOverflowMode Overflow;        // 0x0
        public static UnityEngine.TextCore.Text.TextOverflowMode Ellipsis;        // 0x0
        public static UnityEngine.TextCore.Text.TextOverflowMode Masking;        // 0x0
        public static UnityEngine.TextCore.Text.TextOverflowMode Truncate;        // 0x0
        public static UnityEngine.TextCore.Text.TextOverflowMode ScrollRect;        // 0x0
        public static UnityEngine.TextCore.Text.TextOverflowMode Page;        // 0x0
        public static UnityEngine.TextCore.Text.TextOverflowMode Linked;        // 0x0

    }

    // TypeToken: 0x2000021
    public struct TextureMapping
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.TextureMapping Character;        // 0x0
        public static UnityEngine.TextCore.Text.TextureMapping Line;        // 0x0
        public static UnityEngine.TextCore.Text.TextureMapping Paragraph;        // 0x0
        public static UnityEngine.TextCore.Text.TextureMapping MatchAspect;        // 0x0

    }

    // TypeToken: 0x2000022
    public class TextGenerationSettings, IEquatable`1
    {
        // Fields
        public System.String text;        // 0x10
        public UnityEngine.Rect screenRect;        // 0x18
        public UnityEngine.Vector4 margins;        // 0x28
        public System.Single scale;        // 0x38
        public UnityEngine.TextCore.Text.FontAsset fontAsset;        // 0x40
        public UnityEngine.Material material;        // 0x48
        public UnityEngine.TextCore.Text.SpriteAsset spriteAsset;        // 0x50
        public UnityEngine.TextCore.Text.TextStyleSheet styleSheet;        // 0x58
        public UnityEngine.TextCore.Text.FontStyles fontStyle;        // 0x60
        public UnityEngine.TextCore.Text.TextSettings textSettings;        // 0x68
        public UnityEngine.TextCore.Text.TextAlignment textAlignment;        // 0x70
        public UnityEngine.TextCore.Text.TextOverflowMode overflowMode;        // 0x74
        public System.Boolean wordWrap;        // 0x78
        public System.Single wordWrappingRatio;        // 0x7C
        public UnityEngine.Color color;        // 0x80
        public UnityEngine.TextCore.Text.TextColorGradient fontColorGradient;        // 0x90
        public System.Boolean tintSprites;        // 0x98
        public System.Boolean overrideRichTextColors;        // 0x99
        public System.Single fontSize;        // 0x9C
        public System.Boolean autoSize;        // 0xA0
        public System.Single fontSizeMin;        // 0xA4
        public System.Single fontSizeMax;        // 0xA8
        public System.Boolean enableKerning;        // 0xAC
        public System.Boolean richText;        // 0xAD
        public System.Boolean isRightToLeft;        // 0xAE
        public System.Boolean extraPadding;        // 0xAF
        public System.Boolean parseControlCharacters;        // 0xB0
        public System.Single characterSpacing;        // 0xB4
        public System.Single wordSpacing;        // 0xB8
        public System.Single lineSpacing;        // 0xBC
        public System.Single paragraphSpacing;        // 0xC0
        public System.Single lineSpacingMax;        // 0xC4
        public System.Int32 maxVisibleCharacters;        // 0xC8
        public System.Int32 maxVisibleWords;        // 0xCC
        public System.Int32 maxVisibleLines;        // 0xD0
        public System.Int32 firstVisibleCharacter;        // 0xD4
        public System.Boolean useMaxVisibleDescender;        // 0xD8
        public UnityEngine.TextCore.Text.TextFontWeight fontWeight;        // 0xDC
        public System.Int32 pageToDisplay;        // 0xE0
        public UnityEngine.TextCore.Text.TextureMapping horizontalMapping;        // 0xE4
        public UnityEngine.TextCore.Text.TextureMapping verticalMapping;        // 0xE8
        public System.Single uvLineOffset;        // 0xEC
        public UnityEngine.TextCore.Text.VertexSortingOrder geometrySortingOrder;        // 0xF0
        public System.Boolean inverseYAxis;        // 0xF4
        public System.Single charWidthMaxAdj;        // 0xF8

        // Methods
        private System.Boolean Equals(UnityEngine.TextCore.Text.TextGenerationSettings other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class TextGenerator
    {
        // Fields
        private static UnityEngine.TextCore.Text.TextGenerator s_TextGenerator;        // 0x0
        private UnityEngine.Vector3[] m_RectTransformCorners;        // 0x10
        private System.Single m_MarginWidth;        // 0x18
        private System.Single m_MarginHeight;        // 0x1C
        private System.Int32[] m_CharBuffer;        // 0x20
        private System.Single m_PreferredWidth;        // 0x28
        private System.Single m_PreferredHeight;        // 0x2C
        private UnityEngine.TextCore.Text.FontAsset m_CurrentFontAsset;        // 0x30
        private UnityEngine.Material m_CurrentMaterial;        // 0x38
        private System.Int32 m_CurrentMaterialIndex;        // 0x40
        private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> m_MaterialReferenceStack;        // 0x48
        private System.Single m_Padding;        // 0xA0
        private UnityEngine.TextCore.Text.SpriteAsset m_CurrentSpriteAsset;        // 0xA8
        private System.Int32 m_TotalCharacterCount;        // 0xB0
        private System.Single m_FontScale;        // 0xB4
        private System.Single m_FontSize;        // 0xB8
        private System.Single m_FontScaleMultiplier;        // 0xBC
        private System.Single m_CurrentFontSize;        // 0xC0
        private UnityEngine.TextCore.Text.TextProcessingStack<System.Single> m_SizeStack;        // 0xC8
        private UnityEngine.TextCore.Text.FontStyles m_FontStyleInternal;        // 0xE8
        private UnityEngine.TextCore.Text.FontStyleStack m_FontStyleStack;        // 0xEC
        private UnityEngine.TextCore.Text.TextFontWeight m_FontWeightInternal;        // 0xF8
        private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> m_FontWeightStack;        // 0x100
        private UnityEngine.TextCore.Text.TextAlignment m_LineJustification;        // 0x120
        private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> m_LineJustificationStack;        // 0x128
        private System.Single m_BaselineOffset;        // 0x148
        private UnityEngine.TextCore.Text.TextProcessingStack<System.Single> m_BaselineOffsetStack;        // 0x150
        private UnityEngine.Color32 m_FontColor32;        // 0x170
        private UnityEngine.Color32 m_HtmlColor;        // 0x174
        private UnityEngine.Color32 m_UnderlineColor;        // 0x178
        private UnityEngine.Color32 m_StrikethroughColor;        // 0x17C
        private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_ColorStack;        // 0x180
        private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_UnderlineColorStack;        // 0x1A0
        private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_StrikethroughColorStack;        // 0x1C0
        private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_HighlightColorStack;        // 0x1E0
        private UnityEngine.TextCore.Text.TextColorGradient m_ColorGradientPreset;        // 0x200
        private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientStack;        // 0x208
        private UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> m_ActionStack;        // 0x230
        private System.Boolean m_IsFxMatrixSet;        // 0x250
        private System.Single m_LineOffset;        // 0x254
        private System.Single m_LineHeight;        // 0x258
        private System.Single m_CSpacing;        // 0x25C
        private System.Single m_MonoSpacing;        // 0x260
        private System.Single m_XAdvance;        // 0x264
        private System.Single m_TagLineIndent;        // 0x268
        private System.Single m_TagIndent;        // 0x26C
        private UnityEngine.TextCore.Text.TextProcessingStack<System.Single> m_IndentStack;        // 0x270
        private System.Boolean m_TagNoParsing;        // 0x290
        private System.Int32 m_CharacterCount;        // 0x294
        private System.Int32 m_FirstCharacterOfLine;        // 0x298
        private System.Int32 m_LastCharacterOfLine;        // 0x29C
        private System.Int32 m_FirstVisibleCharacterOfLine;        // 0x2A0
        private System.Int32 m_LastVisibleCharacterOfLine;        // 0x2A4
        private System.Single m_MaxLineAscender;        // 0x2A8
        private System.Single m_MaxLineDescender;        // 0x2AC
        private System.Int32 m_LineNumber;        // 0x2B0
        private System.Int32 m_LineVisibleCharacterCount;        // 0x2B4
        private System.Int32 m_FirstOverflowCharacterIndex;        // 0x2B8
        private System.Int32 m_PageNumber;        // 0x2BC
        private System.Single m_MarginLeft;        // 0x2C0
        private System.Single m_MarginRight;        // 0x2C4
        private System.Single m_Width;        // 0x2C8
        private UnityEngine.TextCore.Text.Extents m_MeshExtents;        // 0x2CC
        private System.Single m_MaxCapHeight;        // 0x2DC
        private System.Single m_MaxAscender;        // 0x2E0
        private System.Single m_MaxDescender;        // 0x2E4
        private System.Boolean m_IsNewPage;        // 0x2E8
        private System.Boolean m_IsNonBreakingSpace;        // 0x2E9
        private UnityEngine.TextCore.Text.WordWrapState m_SavedWordWrapState;        // 0x2F0
        private UnityEngine.TextCore.Text.WordWrapState m_SavedLineState;        // 0x600
        private System.Int32 m_LoopCountA;        // 0x910
        private UnityEngine.TextCore.Text.TextElementType m_TextElementType;        // 0x914
        private System.Boolean m_IsParsingText;        // 0x915
        private System.Int32 m_SpriteIndex;        // 0x918
        private UnityEngine.Color32 m_SpriteColor;        // 0x91C
        private UnityEngine.TextCore.Text.TextElement m_CachedTextElement;        // 0x920
        private UnityEngine.Color32 m_HighlightColor;        // 0x928
        private System.Single m_CharWidthAdjDelta;        // 0x92C
        private UnityEngine.Matrix4x4 m_FxMatrix;        // 0x930
        private System.Single m_MaxFontSize;        // 0x970
        private System.Single m_MinFontSize;        // 0x974
        private System.Boolean m_IsCharacterWrappingEnabled;        // 0x978
        private System.Single m_StartOfLineAscender;        // 0x97C
        private System.Single m_LineSpacingDelta;        // 0x980
        private System.Boolean m_IsMaskingEnabled;        // 0x984
        private UnityEngine.TextCore.Text.MaterialReference[] m_MaterialReferences;        // 0x988
        private System.Int32 m_SpriteCount;        // 0x990
        private UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> m_StyleStack;        // 0x998
        private System.Int32 m_SpriteAnimationId;        // 0x9B8
        private System.UInt32[] m_InternalTextParsingBuffer;        // 0x9C0
        private UnityEngine.TextCore.Text.RichTextTagAttribute[] m_Attributes;        // 0x9C8
        private UnityEngine.TextCore.Text.XmlTagAttribute[] m_XmlAttribute;        // 0x9D0
        private System.Char[] m_RichTextTag;        // 0x9D8
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_MaterialReferenceIndexLookup;        // 0x9E0
        private System.Boolean m_IsCalculatingPreferredValues;        // 0x9E8
        private UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset;        // 0x9F0
        private System.Boolean m_TintSprite;        // 0x9F8
        protected UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Ellipsis;        // 0xA00
        protected UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Underline;        // 0xA20
        private System.Boolean m_IsUsingBold;        // 0xA40
        private System.Boolean m_IsSdfShader;        // 0xA41
        private UnityEngine.TextCore.Text.TextElementInfo[] m_InternalTextElementInfo;        // 0xA48
        private System.Int32 m_RecursiveCount;        // 0xA50

        // Methods
        private UnityEngine.TextCore.Text.TextGenerator GetTextGenerator() { }
        private System.Void GenerateText(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private UnityEngine.Vector2 GetCursorPosition(UnityEngine.TextCore.Text.TextInfo textInfo, UnityEngine.Rect screenRect, System.Int32 index, System.Boolean inverseYAxis) { }
        private UnityEngine.Vector2 GetPreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void Prepare(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void GenerateTextMesh(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void SaveWordWrappingState(UnityEngine.TextCore.Text.WordWrapState& state, System.Int32 index, System.Int32 count, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Int32 RestoreWordWrappingState(UnityEngine.TextCore.Text.WordWrapState& state, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Boolean ValidateHtmlTag(System.Int32[] chars, System.Int32 startIndex, System.Int32& endIndex, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void SaveGlyphVertexInfo(System.Single padding, System.Single stylePadding, UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, System.Single startScale, System.Single endScale, System.Single maxScale, System.Single sdfScale, UnityEngine.Color32 underlineColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, UnityEngine.Color32 highlightColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void ClearMesh(System.Boolean updateMesh, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void EnableMasking() { }
        private System.Void DisableMasking() { }
        private System.Void SetArraySizes(System.Int32[] chars, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private UnityEngine.TextCore.Text.TextElement GetTextElement(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, System.Boolean& isUsingAlternativeTypeface) { }
        private System.Void ComputeMarginSize(UnityEngine.Rect rect, UnityEngine.Vector4 margins) { }
        private System.Void GetSpecialCharacters(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings) { }
        private System.Void GetEllipsisSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings) { }
        private System.Void GetUnderlineSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings) { }
        private System.Single GetPaddingForMaterial(UnityEngine.Material material, System.Boolean extraPadding) { }
        private UnityEngine.Vector2 GetPreferredValuesInternal(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private UnityEngine.Vector2 CalculatePreferredValues(System.Single defaultFontSize, UnityEngine.Vector2 marginSize, System.Boolean ignoreTextAutoSizing, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public struct TextAlignment
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.TextAlignment TopLeft;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment TopCenter;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment TopRight;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment TopJustified;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment TopFlush;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment TopGeoAligned;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MiddleLeft;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MiddleCenter;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MiddleRight;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MiddleJustified;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MiddleFlush;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MiddleGeoAligned;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BottomLeft;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BottomCenter;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BottomRight;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BottomJustified;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BottomFlush;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BottomGeoAligned;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BaselineLeft;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BaselineCenter;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BaselineRight;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BaselineJustified;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BaselineFlush;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment BaselineGeoAligned;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MidlineLeft;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MidlineCenter;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MidlineRight;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MidlineJustified;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MidlineFlush;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment MidlineGeoAligned;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment CaplineLeft;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment CaplineCenter;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment CaplineRight;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment CaplineJustified;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment CaplineFlush;        // 0x0
        public static UnityEngine.TextCore.Text.TextAlignment CaplineGeoAligned;        // 0x0

    }

    // TypeToken: 0x2000026
    public struct FontStyles
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.FontStyles Normal;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles Bold;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles Italic;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles Underline;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles LowerCase;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles UpperCase;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles SmallCaps;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles Strikethrough;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles Superscript;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles Subscript;        // 0x0
        public static UnityEngine.TextCore.Text.FontStyles Highlight;        // 0x0

    }

    // TypeToken: 0x2000027
    public struct XmlTagAttribute
    {
        // Fields
        public System.Int32 nameHashCode;        // 0x10
        public UnityEngine.TextCore.Text.TagValueType valueType;        // 0x14
        public System.Int32 valueStartIndex;        // 0x18
        public System.Int32 valueLength;        // 0x1C
        public System.Int32 valueHashCode;        // 0x20

    }

    // TypeToken: 0x2000028
    public struct RichTextTagAttribute
    {
        // Fields
        public System.Int32 nameHashCode;        // 0x10
        public System.Int32 valueHashCode;        // 0x14
        public UnityEngine.TextCore.Text.TagValueType valueType;        // 0x18
        public System.Int32 valueStartIndex;        // 0x1C
        public System.Int32 valueLength;        // 0x20

    }

    // TypeToken: 0x2000029
    public struct WordWrapState
    {
        // Fields
        public System.Int32 previousWordBreak;        // 0x10
        public System.Int32 totalCharacterCount;        // 0x14
        public System.Int32 visibleCharacterCount;        // 0x18
        public System.Int32 visibleSpriteCount;        // 0x1C
        public System.Int32 visibleLinkCount;        // 0x20
        public System.Int32 firstCharacterIndex;        // 0x24
        public System.Int32 firstVisibleCharacterIndex;        // 0x28
        public System.Int32 lastCharacterIndex;        // 0x2C
        public System.Int32 lastVisibleCharIndex;        // 0x30
        public System.Int32 lineNumber;        // 0x34
        public System.Single maxCapHeight;        // 0x38
        public System.Single maxAscender;        // 0x3C
        public System.Single maxDescender;        // 0x40
        public System.Single maxLineAscender;        // 0x44
        public System.Single maxLineDescender;        // 0x48
        public System.Single previousLineAscender;        // 0x4C
        public System.Single xAdvance;        // 0x50
        public System.Single preferredWidth;        // 0x54
        public System.Single preferredHeight;        // 0x58
        public System.Single previousLineScale;        // 0x5C
        public System.Int32 wordCount;        // 0x60
        public UnityEngine.TextCore.Text.FontStyles fontStyle;        // 0x64
        public System.Single fontScale;        // 0x68
        public System.Single fontScaleMultiplier;        // 0x6C
        public System.Single currentFontSize;        // 0x70
        public System.Single baselineOffset;        // 0x74
        public System.Single lineOffset;        // 0x78
        public UnityEngine.TextCore.Text.TextInfo textInfo;        // 0x80
        public UnityEngine.TextCore.Text.LineInfo lineInfo;        // 0x88
        public UnityEngine.Color32 vertexColor;        // 0xE8
        public UnityEngine.Color32 underlineColor;        // 0xEC
        public UnityEngine.Color32 strikethroughColor;        // 0xF0
        public UnityEngine.Color32 highlightColor;        // 0xF4
        public UnityEngine.TextCore.Text.FontStyleStack basicStyleStack;        // 0xF8
        public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> colorStack;        // 0x108
        public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> underlineColorStack;        // 0x128
        public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> strikethroughColorStack;        // 0x148
        public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> highlightColorStack;        // 0x168
        public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> colorGradientStack;        // 0x188
        public UnityEngine.TextCore.Text.TextProcessingStack<System.Single> sizeStack;        // 0x1B0
        public UnityEngine.TextCore.Text.TextProcessingStack<System.Single> indentStack;        // 0x1D0
        public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> fontWeightStack;        // 0x1F0
        public UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> styleStack;        // 0x210
        public UnityEngine.TextCore.Text.TextProcessingStack<System.Single> baselineStack;        // 0x230
        public UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> actionStack;        // 0x250
        public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> materialReferenceStack;        // 0x270
        public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> lineJustificationStack;        // 0x2C8
        public System.Int32 spriteAnimationId;        // 0x2E8
        public UnityEngine.TextCore.Text.FontAsset currentFontAsset;        // 0x2F0
        public UnityEngine.TextCore.Text.SpriteAsset currentSpriteAsset;        // 0x2F8
        public UnityEngine.Material currentMaterial;        // 0x300
        public System.Int32 currentMaterialIndex;        // 0x308
        public UnityEngine.TextCore.Text.Extents meshExtents;        // 0x30C
        public System.Boolean tagNoParsing;        // 0x31C
        public System.Boolean isNonBreakingSpace;        // 0x31D

    }

    // TypeToken: 0x200002A
    public class TextGeneratorUtilities
    {
        // Fields
        public static readonly UnityEngine.Vector2 largePositiveVector2;        // 0x0
        public static readonly UnityEngine.Vector2 largeNegativeVector2;        // 0x8

        // Methods
        private System.Boolean Approximately(System.Single a, System.Single b) { }
        private UnityEngine.Color32 HexCharsToColor(System.Char[] hexChars, System.Int32 tagCount) { }
        private UnityEngine.Color32 HexCharsToColor(System.Char[] hexChars, System.Int32 startIndex, System.Int32 length) { }
        private System.Int32 HexToInt(System.Char hex) { }
        private System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length) { }
        private System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length, System.Int32& lastIndex) { }
        private UnityEngine.Vector2 PackUV(System.Single x, System.Single y, System.Single scale) { }
        private System.Void StringToCharArray(System.String sourceText, System.Int32[]& charBuffer, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>& styleStack, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings) { }
        private System.Void ResizeInternalArray(T[]& array) { }
        private System.Boolean IsTagName(System.String& text, System.String tag, System.Int32 index) { }
        private System.Boolean IsTagName(System.Int32[]& text, System.String tag, System.Int32 index) { }
        private System.Boolean ReplaceOpeningStyleTag(System.Int32[]& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, System.Int32[]& charBuffer, System.Int32& writeIndex, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>& styleStack, UnityEngine.TextCore.Text.TextGenerationSettings& generationSettings) { }
        private System.Boolean ReplaceOpeningStyleTag(System.String& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, System.Int32[]& charBuffer, System.Int32& writeIndex, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>& styleStack, UnityEngine.TextCore.Text.TextGenerationSettings& generationSettings) { }
        private System.Void ReplaceClosingStyleTag(System.Int32[]& charBuffer, System.Int32& writeIndex, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>& styleStack, UnityEngine.TextCore.Text.TextGenerationSettings& generationSettings) { }
        private UnityEngine.TextCore.Text.TextStyle GetStyle(UnityEngine.TextCore.Text.TextGenerationSettings generationSetting, System.Int32 hashCode) { }
        private System.Int32 GetUtf32(System.String text, System.Int32 i) { }
        private System.Int32 GetUtf16(System.String text, System.Int32 i) { }
        private System.Int32 GetTagHashCode(System.Int32[]& text, System.Int32 index, System.Int32& closeIndex) { }
        private System.Int32 GetTagHashCode(System.String& text, System.Int32 index, System.Int32& closeIndex) { }
        private System.Void FillCharacterVertexBuffers(System.Int32 i, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void FillSpriteVertexBuffers(System.Int32 i, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void AdjustLineOffset(System.Int32 startIndex, System.Int32 endIndex, System.Single offset, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private System.Void ResizeLineExtents(System.Int32 size, UnityEngine.TextCore.Text.TextInfo textInfo) { }
        private UnityEngine.TextCore.Text.FontStyles LegacyStyleToNewStyle(UnityEngine.FontStyle fontStyle) { }
        private UnityEngine.TextCore.Text.TextAlignment LegacyAlignmentToNewAlignment(UnityEngine.TextAnchor anchor) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002B
    public struct PageInfo
    {
        // Fields
        public System.Int32 firstCharacterIndex;        // 0x10
        public System.Int32 lastCharacterIndex;        // 0x14
        public System.Single ascender;        // 0x18
        public System.Single baseLine;        // 0x1C
        public System.Single descender;        // 0x20

    }

    // TypeToken: 0x200002C
    public struct WordInfo
    {
        // Fields
        public System.Int32 firstCharacterIndex;        // 0x10
        public System.Int32 lastCharacterIndex;        // 0x14
        public System.Int32 characterCount;        // 0x18

    }

    // TypeToken: 0x200002D
    public class TextInfo
    {
        // Fields
        private static UnityEngine.Vector2 s_InfinityVectorPositive;        // 0x0
        private static UnityEngine.Vector2 s_InfinityVectorNegative;        // 0x8
        public System.Int32 characterCount;        // 0x10
        public System.Int32 spriteCount;        // 0x14
        public System.Int32 spaceCount;        // 0x18
        public System.Int32 wordCount;        // 0x1C
        public System.Int32 linkCount;        // 0x20
        public System.Int32 lineCount;        // 0x24
        public System.Int32 pageCount;        // 0x28
        public System.Int32 materialCount;        // 0x2C
        public UnityEngine.TextCore.Text.TextElementInfo[] textElementInfo;        // 0x30
        public UnityEngine.TextCore.Text.WordInfo[] wordInfo;        // 0x38
        public UnityEngine.TextCore.Text.LinkInfo[] linkInfo;        // 0x40
        public UnityEngine.TextCore.Text.LineInfo[] lineInfo;        // 0x48
        public UnityEngine.TextCore.Text.PageInfo[] pageInfo;        // 0x50
        public UnityEngine.TextCore.Text.MeshInfo[] meshInfo;        // 0x58
        public System.Boolean isDirty;        // 0x60

        // Methods
        private System.Void .ctor() { }
        private System.Void Clear() { }
        private System.Void ClearMeshInfo(System.Boolean updateMesh) { }
        private System.Void ClearLineInfo() { }
        private System.Void Resize(T[]& array, System.Int32 size) { }
        private System.Void Resize(T[]& array, System.Int32 size, System.Boolean isBlockAllocated) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002E
    public struct MarkupTag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.MarkupTag BOLD;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_BOLD;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ITALIC;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_ITALIC;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag UNDERLINE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_UNDERLINE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag STRIKETHROUGH;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_STRIKETHROUGH;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MARK;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_MARK;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SUBSCRIPT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_SUBSCRIPT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SUPERSCRIPT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_SUPERSCRIPT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag COLOR;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_COLOR;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ALPHA;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag A;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_A;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SIZE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_SIZE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SPRITE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag NO_BREAK;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_NO_BREAK;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag STYLE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_STYLE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag FONT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_FONT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_MATERIAL;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag LINK;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_LINK;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag FONT_WEIGHT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_FONT_WEIGHT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag NO_PARSE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_NO_PARSE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag POSITION;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_POSITION;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag VERTICAL_OFFSET;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_VERTICAL_OFFSET;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SPACE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_SPACE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PAGE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_PAGE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ALIGN;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_ALIGN;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag WIDTH;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_WIDTH;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag GRADIENT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_GRADIENT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag CHARACTER_SPACE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_CHARACTER_SPACE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MONOSPACE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_MONOSPACE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag CLASS;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag INDENT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_INDENT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag LINE_INDENT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_LINE_INDENT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MARGIN;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_MARGIN;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MARGIN_LEFT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MARGIN_RIGHT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag LINE_HEIGHT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_LINE_HEIGHT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ACTION;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_ACTION;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SCALE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_SCALE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ROTATE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_ROTATE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag LOWERCASE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_LOWERCASE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ALLCAPS;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_ALLCAPS;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag UPPERCASE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_UPPERCASE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SMALLCAPS;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_SMALLCAPS;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag LIGA;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_LIGA;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag FRAC;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SLASH_FRAC;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag NAME;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag INDEX;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag TINT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ANIM;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MATERIAL;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag HREF;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ANGLE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag RED;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag GREEN;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag BLUE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag YELLOW;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ORANGE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag BLACK;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag WHITE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PURPLE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag BR;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag ZWSP;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag NBSP;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag SHY;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag LEFT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag RIGHT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag CENTER;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag JUSTIFIED;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag FLUSH;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag NONE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PLUS;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MINUS;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PX;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PLUS_PX;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MINUS_PX;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag EM;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PLUS_EM;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MINUS_EM;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PCT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PLUS_PCT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MINUS_PCT;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PERCENTAGE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag PLUS_PERCENTAGE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag MINUS_PERCENTAGE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag TRUE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag FALSE;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag INVALID;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag NORMAL;        // 0x0
        public static UnityEngine.TextCore.Text.MarkupTag DEFAULT;        // 0x0

    }

    // TypeToken: 0x200002F
    public struct TagValueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.TagValueType None;        // 0x0
        public static UnityEngine.TextCore.Text.TagValueType NumericalValue;        // 0x0
        public static UnityEngine.TextCore.Text.TagValueType StringValue;        // 0x0
        public static UnityEngine.TextCore.Text.TagValueType ColorValue;        // 0x0

    }

    // TypeToken: 0x2000030
    public struct TagUnitType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextCore.Text.TagUnitType Pixels;        // 0x0
        public static UnityEngine.TextCore.Text.TagUnitType FontUnits;        // 0x0
        public static UnityEngine.TextCore.Text.TagUnitType Percentage;        // 0x0

    }

    // TypeToken: 0x2000031
    public struct FontStyleStack
    {
        // Fields
        public System.Byte bold;        // 0x10
        public System.Byte italic;        // 0x11
        public System.Byte underline;        // 0x12
        public System.Byte strikethrough;        // 0x13
        public System.Byte highlight;        // 0x14
        public System.Byte superscript;        // 0x15
        public System.Byte subscript;        // 0x16
        public System.Byte uppercase;        // 0x17
        public System.Byte lowercase;        // 0x18
        public System.Byte smallcaps;        // 0x19

        // Methods
        private System.Void Clear() { }
        private System.Byte Add(UnityEngine.TextCore.Text.FontStyles style) { }
        private System.Byte Remove(UnityEngine.TextCore.Text.FontStyles style) { }

    }

    // TypeToken: 0x2000032
    public struct TextProcessingStack`1
    {
        // Fields
        public T[] itemStack;        // 0x0
        public System.Int32 index;        // 0x0
        private T m_DefaultItem;        // 0x0
        private System.Int32 m_Capacity;        // 0x0
        private System.Int32 m_RolloverSize;        // 0x0
        private System.Int32 m_Count;        // 0x0

        // Methods
        private System.Void .ctor(T[] stack) { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Clear() { }
        private System.Void SetDefault(T item) { }
        private System.Void Add(T item) { }
        private T Remove() { }
        private System.Void Push(T item) { }
        private T Pop() { }
        private T Peek() { }
        private T CurrentItem() { }

    }

    // TypeToken: 0x2000033
    public class TextResourceManager
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextResourceManager.FontAssetRef> s_FontAssetReferences;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset> s_FontAssetNameReferenceLookup;        // 0x8
        private static readonly System.Collections.Generic.Dictionary<System.Int64,UnityEngine.TextCore.Text.FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;        // 0x10
        private static readonly System.Collections.Generic.List<System.Int32> s_FontAssetRemovalList;        // 0x18
        private static readonly System.Int32 k_RegularStyleHashCode;        // 0x20

        // Methods
        private System.Void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000035
    public class TextSettings : ScriptableObject
    {
        // Fields
        protected System.String m_Version;        // 0x18
        protected UnityEngine.TextCore.Text.FontAsset m_DefaultFontAsset;        // 0x20
        protected System.String m_DefaultFontAssetPath;        // 0x28
        protected System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssets;        // 0x30
        protected System.Boolean m_MatchMaterialPreset;        // 0x38
        protected System.Int32 m_MissingCharacterUnicode;        // 0x3C
        protected System.Boolean m_ClearDynamicDataOnBuild;        // 0x40
        protected UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset;        // 0x48
        protected System.String m_DefaultSpriteAssetPath;        // 0x50
        protected System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> m_FallbackSpriteAssets;        // 0x58
        protected System.UInt32 m_MissingSpriteCharacterUnicode;        // 0x60
        protected UnityEngine.TextCore.Text.TextStyleSheet m_DefaultStyleSheet;        // 0x68
        protected System.String m_StyleSheetsResourcePath;        // 0x70
        protected System.String m_DefaultColorGradientPresetsPath;        // 0x78
        protected UnityEngine.TextCore.Text.UnicodeLineBreakingRules m_UnicodeLineBreakingRules;        // 0x80
        protected System.Boolean m_DisplayWarnings;        // 0x88
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset> m_FontLookup;        // 0x90
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.TextSettings.FontReferenceMap> m_FontReferences;        // 0x98

        // Methods
        private System.String get_version() { }
        private System.Void set_version(System.String value) { }
        private UnityEngine.TextCore.Text.FontAsset get_defaultFontAsset() { }
        private System.Void set_defaultFontAsset(UnityEngine.TextCore.Text.FontAsset value) { }
        private System.String get_defaultFontAssetPath() { }
        private System.Void set_defaultFontAssetPath(System.String value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssets() { }
        private System.Void set_fallbackFontAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value) { }
        private System.Boolean get_matchMaterialPreset() { }
        private System.Void set_matchMaterialPreset(System.Boolean value) { }
        private System.Int32 get_missingCharacterUnicode() { }
        private System.Void set_missingCharacterUnicode(System.Int32 value) { }
        private System.Boolean get_clearDynamicDataOnBuild() { }
        private System.Void set_clearDynamicDataOnBuild(System.Boolean value) { }
        private UnityEngine.TextCore.Text.SpriteAsset get_defaultSpriteAsset() { }
        private System.Void set_defaultSpriteAsset(UnityEngine.TextCore.Text.SpriteAsset value) { }
        private System.String get_defaultSpriteAssetPath() { }
        private System.Void set_defaultSpriteAssetPath(System.String value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> get_fallbackSpriteAssets() { }
        private System.Void set_fallbackSpriteAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> value) { }
        private System.UInt32 get_missingSpriteCharacterUnicode() { }
        private System.Void set_missingSpriteCharacterUnicode(System.UInt32 value) { }
        private UnityEngine.TextCore.Text.TextStyleSheet get_defaultStyleSheet() { }
        private System.Void set_defaultStyleSheet(UnityEngine.TextCore.Text.TextStyleSheet value) { }
        private System.String get_styleSheetsResourcePath() { }
        private System.Void set_styleSheetsResourcePath(System.String value) { }
        private System.String get_defaultColorGradientPresetsPath() { }
        private System.Void set_defaultColorGradientPresetsPath(System.String value) { }
        private UnityEngine.TextCore.Text.UnicodeLineBreakingRules get_lineBreakingRules() { }
        private System.Void set_lineBreakingRules(UnityEngine.TextCore.Text.UnicodeLineBreakingRules value) { }
        private System.Boolean get_displayWarnings() { }
        private System.Void set_displayWarnings(System.Boolean value) { }
        private System.Void InitializeFontReferenceLookup() { }
        private UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font font) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public class TextShaderUtilities
    {
        // Fields
        public static System.Int32 ID_MainTex;        // 0x0
        public static System.Int32 ID_FaceTex;        // 0x4
        public static System.Int32 ID_FaceColor;        // 0x8
        public static System.Int32 ID_FaceDilate;        // 0xC
        public static System.Int32 ID_Shininess;        // 0x10
        public static System.Int32 ID_UnderlayColor;        // 0x14
        public static System.Int32 ID_UnderlayOffsetX;        // 0x18
        public static System.Int32 ID_UnderlayOffsetY;        // 0x1C
        public static System.Int32 ID_UnderlayDilate;        // 0x20
        public static System.Int32 ID_UnderlaySoftness;        // 0x24
        public static System.Int32 ID_WeightNormal;        // 0x28
        public static System.Int32 ID_WeightBold;        // 0x2C
        public static System.Int32 ID_OutlineTex;        // 0x30
        public static System.Int32 ID_OutlineWidth;        // 0x34
        public static System.Int32 ID_OutlineSoftness;        // 0x38
        public static System.Int32 ID_OutlineColor;        // 0x3C
        public static System.Int32 ID_Outline2Color;        // 0x40
        public static System.Int32 ID_Outline2Width;        // 0x44
        public static System.Int32 ID_Padding;        // 0x48
        public static System.Int32 ID_GradientScale;        // 0x4C
        public static System.Int32 ID_ScaleX;        // 0x50
        public static System.Int32 ID_ScaleY;        // 0x54
        public static System.Int32 ID_PerspectiveFilter;        // 0x58
        public static System.Int32 ID_Sharpness;        // 0x5C
        public static System.Int32 ID_TextureWidth;        // 0x60
        public static System.Int32 ID_TextureHeight;        // 0x64
        public static System.Int32 ID_BevelAmount;        // 0x68
        public static System.Int32 ID_GlowColor;        // 0x6C
        public static System.Int32 ID_GlowOffset;        // 0x70
        public static System.Int32 ID_GlowPower;        // 0x74
        public static System.Int32 ID_GlowOuter;        // 0x78
        public static System.Int32 ID_GlowInner;        // 0x7C
        public static System.Int32 ID_LightAngle;        // 0x80
        public static System.Int32 ID_EnvMap;        // 0x84
        public static System.Int32 ID_EnvMatrix;        // 0x88
        public static System.Int32 ID_EnvMatrixRotation;        // 0x8C
        public static System.Int32 ID_MaskCoord;        // 0x90
        public static System.Int32 ID_ClipRect;        // 0x94
        public static System.Int32 ID_MaskSoftnessX;        // 0x98
        public static System.Int32 ID_MaskSoftnessY;        // 0x9C
        public static System.Int32 ID_VertexOffsetX;        // 0xA0
        public static System.Int32 ID_VertexOffsetY;        // 0xA4
        public static System.Int32 ID_UseClipRect;        // 0xA8
        public static System.Int32 ID_StencilID;        // 0xAC
        public static System.Int32 ID_StencilOp;        // 0xB0
        public static System.Int32 ID_StencilComp;        // 0xB4
        public static System.Int32 ID_StencilReadMask;        // 0xB8
        public static System.Int32 ID_StencilWriteMask;        // 0xBC
        public static System.Int32 ID_ShaderFlags;        // 0xC0
        public static System.Int32 ID_ScaleRatio_A;        // 0xC4
        public static System.Int32 ID_ScaleRatio_B;        // 0xC8
        public static System.Int32 ID_ScaleRatio_C;        // 0xCC
        public static System.String Keyword_Bevel;        // 0xD0
        public static System.String Keyword_Glow;        // 0xD8
        public static System.String Keyword_Underlay;        // 0xE0
        public static System.String Keyword_Ratios;        // 0xE8
        public static System.String Keyword_MASK_SOFT;        // 0xF0
        public static System.String Keyword_MASK_HARD;        // 0xF8
        public static System.String Keyword_MASK_TEX;        // 0x100
        public static System.String Keyword_Outline;        // 0x108
        public static System.String ShaderTag_ZTestMode;        // 0x110
        public static System.String ShaderTag_CullMode;        // 0x118
        private static System.Single m_clamp;        // 0x120
        public static System.Boolean isInitialized;        // 0x124
        private static UnityEngine.Shader k_ShaderRef_MobileSDF;        // 0x128
        private static UnityEngine.Shader k_ShaderRef_MobileBitmap;        // 0x130

        // Methods
        private UnityEngine.Shader get_ShaderRef_MobileSDF() { }
        private UnityEngine.Shader get_ShaderRef_MobileBitmap() { }
        private System.Void .cctor() { }
        private System.Void GetShaderPropertyIDs() { }
        private System.Void UpdateShaderRatios(UnityEngine.Material mat) { }
        private System.Boolean IsMaskingEnabled(UnityEngine.Material material) { }
        private System.Single GetPadding(UnityEngine.Material material, System.Boolean enableExtraPadding, System.Boolean isBold) { }

    }

    // TypeToken: 0x2000038
    public class TextStyle
    {
        // Fields
        private static UnityEngine.TextCore.Text.TextStyle k_NormalStyle;        // 0x0
        private System.String m_Name;        // 0x10
        private System.Int32 m_HashCode;        // 0x18
        private System.String m_OpeningDefinition;        // 0x20
        private System.String m_ClosingDefinition;        // 0x28
        private System.Int32[] m_OpeningTagArray;        // 0x30
        private System.Int32[] m_ClosingTagArray;        // 0x38
        private System.UInt32[] m_OpeningTagUnicodeArray;        // 0x40
        private System.UInt32[] m_ClosingTagUnicodeArray;        // 0x48

        // Methods
        private System.Int32 get_hashCode() { }
        private System.Int32[] get_styleOpeningTagArray() { }
        private System.Int32[] get_styleClosingTagArray() { }
        private System.Void RefreshStyle() { }

    }

    // TypeToken: 0x2000039
    public class TextStyleSheet : ScriptableObject
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> m_StyleList;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextStyle> m_StyleLookupDictionary;        // 0x20

        // Methods
        private System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> get_styles() { }
        private UnityEngine.TextCore.Text.TextStyle GetStyle(System.Int32 hashCode) { }
        private UnityEngine.TextCore.Text.TextStyle GetStyle(System.String name) { }
        private System.Void RefreshStyles() { }
        private System.Void LoadStyleDictionaryInternal() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003A
    public class TextUtilities
    {
        // Methods
        private System.Char ToUpperFast(System.Char c) { }
        private System.UInt32 ToUpperASCIIFast(System.UInt32 c) { }
        private System.Int32 GetHashCodeCaseInSensitive(System.String s) { }
        private System.String UintToString(System.Collections.Generic.List<System.UInt32> unicodes) { }

    }

    // TypeToken: 0x200003B
    public class UnicodeLineBreakingRules
    {
        // Fields
        private static UnityEngine.TextCore.Text.UnicodeLineBreakingRules s_Instance;        // 0x0
        private UnityEngine.TextAsset m_UnicodeLineBreakingRules;        // 0x10
        private UnityEngine.TextAsset m_LeadingCharacters;        // 0x18
        private UnityEngine.TextAsset m_FollowingCharacters;        // 0x20
        private System.Boolean m_UseModernHangulLineBreakingRules;        // 0x28
        private static System.Collections.Generic.HashSet<System.UInt32> s_LeadingCharactersLookup;        // 0x8
        private static System.Collections.Generic.HashSet<System.UInt32> s_FollowingCharactersLookup;        // 0x10

        // Methods
        private System.Collections.Generic.HashSet<System.UInt32> get_leadingCharactersLookup() { }
        private System.Collections.Generic.HashSet<System.UInt32> get_followingCharactersLookup() { }
        private System.Void LoadLineBreakingRules() { }
        private System.Collections.Generic.HashSet<System.UInt32> GetCharacters(UnityEngine.TextAsset file) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

