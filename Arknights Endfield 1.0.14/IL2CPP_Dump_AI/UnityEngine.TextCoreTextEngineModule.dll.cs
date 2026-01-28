// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TextCoreTextEngineModule.dll
// Classes:  59
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SpecialCharacter
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            UnityEngine.TextCore.Text.Charactercharacter  // 0x10
  public            UnityEngine.TextCore.Text.FontAssetfontAsset  // 0x18
  public            UnityEngine.Material            material  // 0x20
  public            System.Int32                    materialIndex  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.TextCore.Text.Character character, System.Int32 materialIndex)
END_CLASS

CLASS: FontAssetRef
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    nameHashCode  // 0x10
  public            System.Int32                    familyNameHashCode  // 0x14
  public            System.Int32                    styleNameHashCode  // 0x18
  public            System.Int64                    familyNameAndStyleHashCode  // 0x20
  public    readonly UnityEngine.TextCore.Text.FontAssetfontAsset  // 0x28
METHODS:
  System.Void .ctor(System.Int32 nameHashCode, System.Int32 familyNameHashCode, System.Int32 styleNameHashCode, UnityEngine.TextCore.Text.FontAsset fontAsset)
END_CLASS

CLASS: FontReferenceMap
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            UnityEngine.Font                font  // 0x10
  public            UnityEngine.TextCore.Text.FontAssetfontAsset  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Font font, UnityEngine.TextCore.Text.FontAsset fontAsset)
END_CLASS

CLASS: UnityEngine.TextCore.Text.Character
TYPE:  class
TOKEN: 0x2000002
EXTENDS: TextElement
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph)
  System.Void .ctor(System.UInt32 unicode, System.UInt32 glyphIndex)
END_CLASS

CLASS: UnityEngine.TextCore.Text.ColorUtilities
TYPE:  class
TOKEN: 0x2000003
FIELDS:
METHODS:
  System.Boolean CompareColors(UnityEngine.Color32 a, UnityEngine.Color32 b)
  UnityEngine.Color32 MultiplyColors(UnityEngine.Color32 c1, UnityEngine.Color32 c2)
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextFontWeight
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.TextFontWeightThin  // 0x0
  public    static  UnityEngine.TextCore.Text.TextFontWeightExtraLight  // 0x0
  public    static  UnityEngine.TextCore.Text.TextFontWeightLight  // 0x0
  public    static  UnityEngine.TextCore.Text.TextFontWeightRegular  // 0x0
  public    static  UnityEngine.TextCore.Text.TextFontWeightMedium  // 0x0
  public    static  UnityEngine.TextCore.Text.TextFontWeightSemiBold  // 0x0
  public    static  UnityEngine.TextCore.Text.TextFontWeightBold  // 0x0
  public    static  UnityEngine.TextCore.Text.TextFontWeightHeavy  // 0x0
  public    static  UnityEngine.TextCore.Text.TextFontWeightBlack  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.FontWeightPair
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            UnityEngine.TextCore.Text.FontAssetregularTypeface  // 0x10
  public            UnityEngine.TextCore.Text.FontAssetitalicTypeface  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.FontAssetCreationEditorSettings
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.String                   sourceFontFileGUID  // 0x10
  public            System.Int32                    faceIndex  // 0x18
  public            System.Int32                    pointSizeSamplingMode  // 0x1C
  public            System.Int32                    pointSize  // 0x20
  public            System.Int32                    padding  // 0x24
  public            System.Int32                    packingMode  // 0x28
  public            System.Int32                    atlasWidth  // 0x2C
  public            System.Int32                    atlasHeight  // 0x30
  public            System.Int32                    characterSetSelectionMode  // 0x34
  public            System.String                   characterSequence  // 0x38
  public            System.String                   referencedFontAssetGUID  // 0x40
  public            System.String                   referencedTextAssetGUID  // 0x48
  public            System.Int32                    fontStyle  // 0x50
  public            System.Single                   fontStyleModifier  // 0x54
  public            System.Int32                    renderMode  // 0x58
  public            System.Boolean                  includeFontFeatures  // 0x5C
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.AtlasPopulationMode
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.AtlasPopulationModeStatic  // 0x0
  public    static  UnityEngine.TextCore.Text.AtlasPopulationModeDynamic  // 0x0
  public    static  UnityEngine.TextCore.Text.AtlasPopulationModeDynamicOS  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.FontAsset
TYPE:  class
TOKEN: 0x2000008
EXTENDS: TextAsset
FIELDS:
  private           System.String                   m_SourceFontFileGUID  // 0x38
  private           UnityEngine.Font                m_SourceFontFile  // 0x40
  private           UnityEngine.TextCore.Text.AtlasPopulationModem_AtlasPopulationMode  // 0x48
  private           System.Boolean                  InternalDynamicOS  // 0x4C
  private           UnityEngine.TextCore.FaceInfo   m_FaceInfo  // 0x50
  private           System.Int32                    m_FamilyNameHashCode  // 0xB0
  private           System.Int32                    m_StyleNameHashCode  // 0xB4
  private           UnityEngine.TextCore.Text.FontWeightPair[]m_FontWeightTable  // 0xB8
  private           System.Collections.Generic.List<UnityEngine.TextCore.Glyph>m_GlyphTable  // 0xC0
  private           System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph>m_GlyphLookupDictionary  // 0xC8
  private           System.Collections.Generic.List<UnityEngine.TextCore.Text.Character>m_CharacterTable  // 0xD0
  private           System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.Character>m_CharacterLookupDictionary  // 0xD8
  private           UnityEngine.Texture2D           m_AtlasTexture  // 0xE0
  private           UnityEngine.Texture2D[]         m_AtlasTextures  // 0xE8
  private           System.Int32                    m_AtlasTextureIndex  // 0xF0
  private           System.Boolean                  m_IsMultiAtlasTexturesEnabled  // 0xF4
  private           System.Boolean                  m_ClearDynamicDataOnBuild  // 0xF5
  private           System.Int32                    m_AtlasWidth  // 0xF8
  private           System.Int32                    m_AtlasHeight  // 0xFC
  private           System.Int32                    m_AtlasPadding  // 0x100
  private           UnityEngine.TextCore.LowLevel.GlyphRenderModem_AtlasRenderMode  // 0x104
  private           System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect>m_UsedGlyphRects  // 0x108
  private           System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect>m_FreeGlyphRects  // 0x110
  private           UnityEngine.TextCore.Text.FontFeatureTablem_FontFeatureTable  // 0x118
  private           System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset>m_FallbackFontAssetTable  // 0x120
  private           UnityEngine.TextCore.Text.FontAssetCreationEditorSettingsm_fontAssetCreationEditorSettings  // 0x128
  private           System.Single                   m_RegularStyleWeight  // 0x178
  private           System.Single                   m_RegularStyleSpacing  // 0x17C
  private           System.Single                   m_BoldStyleWeight  // 0x180
  private           System.Single                   m_BoldStyleSpacing  // 0x184
  private           System.Byte                     m_ItalicStyleSlant  // 0x188
  private           System.Byte                     m_TabMultiple  // 0x189
  private           System.Boolean                  IsFontAssetLookupTablesDirty  // 0x18A
  private   static  Unity.Profiling.ProfilerMarker  k_ReadFontAssetDefinitionMarker  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  k_AddSynthesizedCharactersMarker  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  k_TryAddCharacterMarker  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  k_TryAddCharactersMarker  // 0x18
  private   static  Unity.Profiling.ProfilerMarker  k_UpdateGlyphAdjustmentRecordsMarker  // 0x20
  private   static  Unity.Profiling.ProfilerMarker  k_ClearFontAssetDataMarker  // 0x28
  private   static  Unity.Profiling.ProfilerMarker  k_UpdateFontAssetDataMarker  // 0x30
  private   static  System.String                   s_DefaultMaterialSuffix  // 0x38
  private   static  System.Collections.Generic.HashSet<System.Int32>k_SearchedFontAssetLookup  // 0x40
  private   static  System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset>k_FontAssets_FontFeaturesUpdateQueue  // 0x48
  private   static  System.Collections.Generic.HashSet<System.Int32>k_FontAssets_FontFeaturesUpdateQueueLookup  // 0x50
  private   static  System.Collections.Generic.List<UnityEngine.Texture2D>k_FontAssets_AtlasTexturesUpdateQueue  // 0x58
  private   static  System.Collections.Generic.HashSet<System.Int32>k_FontAssets_AtlasTexturesUpdateQueueLookup  // 0x60
  private           System.Collections.Generic.List<UnityEngine.TextCore.Glyph>m_GlyphsToRender  // 0x190
  private           System.Collections.Generic.List<UnityEngine.TextCore.Glyph>m_GlyphsRendered  // 0x198
  private           System.Collections.Generic.List<System.UInt32>m_GlyphIndexList  // 0x1A0
  private           System.Collections.Generic.List<System.UInt32>m_GlyphIndexListNewlyAdded  // 0x1A8
  private           System.Collections.Generic.List<System.UInt32>m_GlyphsToAdd  // 0x1B0
  private           System.Collections.Generic.HashSet<System.UInt32>m_GlyphsToAddLookup  // 0x1B8
  private           System.Collections.Generic.List<UnityEngine.TextCore.Text.Character>m_CharactersToAdd  // 0x1C0
  private           System.Collections.Generic.HashSet<System.UInt32>m_CharactersToAddLookup  // 0x1C8
  private           System.Collections.Generic.List<System.UInt32>s_MissingCharacterList  // 0x1D0
  private           System.Collections.Generic.HashSet<System.UInt32>m_MissingUnicodesFromFontFile  // 0x1D8
  private   static  System.UInt32[]                 k_GlyphIndexArray  // 0x68
METHODS:
  UnityEngine.Font get_sourceFontFile()
  System.Void set_sourceFontFile(UnityEngine.Font value)
  UnityEngine.TextCore.Text.AtlasPopulationMode get_atlasPopulationMode()
  System.Void set_atlasPopulationMode(UnityEngine.TextCore.Text.AtlasPopulationMode value)
  UnityEngine.TextCore.FaceInfo get_faceInfo()
  System.Void set_faceInfo(UnityEngine.TextCore.FaceInfo value)
  System.Int32 get_familyNameHashCode()
  System.Void set_familyNameHashCode(System.Int32 value)
  System.Int32 get_styleNameHashCode()
  System.Void set_styleNameHashCode(System.Int32 value)
  UnityEngine.TextCore.Text.FontWeightPair[] get_fontWeightTable()
  System.Void set_fontWeightTable(UnityEngine.TextCore.Text.FontWeightPair[] value)
  System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable()
  System.Void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value)
  System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> get_glyphLookupTable()
  System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> get_characterTable()
  System.Void set_characterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> value)
  System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.Character> get_characterLookupTable()
  UnityEngine.Texture2D get_atlasTexture()
  UnityEngine.Texture2D[] get_atlasTextures()
  System.Void set_atlasTextures(UnityEngine.Texture2D[] value)
  System.Int32 get_atlasTextureCount()
  System.Boolean get_isMultiAtlasTexturesEnabled()
  System.Void set_isMultiAtlasTexturesEnabled(System.Boolean value)
  System.Boolean get_clearDynamicDataOnBuild()
  System.Void set_clearDynamicDataOnBuild(System.Boolean value)
  System.Int32 get_atlasWidth()
  System.Void set_atlasWidth(System.Int32 value)
  System.Int32 get_atlasHeight()
  System.Void set_atlasHeight(System.Int32 value)
  System.Int32 get_atlasPadding()
  System.Void set_atlasPadding(System.Int32 value)
  UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode()
  System.Void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value)
  System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects()
  System.Void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value)
  System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects()
  System.Void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value)
  UnityEngine.TextCore.Text.FontFeatureTable get_fontFeatureTable()
  System.Void set_fontFeatureTable(UnityEngine.TextCore.Text.FontFeatureTable value)
  System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssetTable()
  System.Void set_fallbackFontAssetTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value)
  UnityEngine.TextCore.Text.FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings()
  System.Void set_fontAssetCreationEditorSettings(UnityEngine.TextCore.Text.FontAssetCreationEditorSettings value)
  System.Single get_regularStyleWeight()
  System.Void set_regularStyleWeight(System.Single value)
  System.Single get_regularStyleSpacing()
  System.Void set_regularStyleSpacing(System.Single value)
  System.Single get_boldStyleWeight()
  System.Void set_boldStyleWeight(System.Single value)
  System.Single get_boldStyleSpacing()
  System.Void set_boldStyleSpacing(System.Single value)
  System.Byte get_italicStyleSlant()
  System.Void set_italicStyleSlant(System.Byte value)
  System.Byte get_tabMultiple()
  System.Void set_tabMultiple(System.Byte value)
  UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String familyName, System.String styleName, System.Int32 pointSize)
  UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String fontFilePath, System.Int32 faceIndex, System.Int32 samplingPointSize, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport)
  UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font)
  UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, System.Int32 samplingPointSize, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport)
  UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, System.Int32 faceIndex, System.Int32 samplingPointSize, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport)
  UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font font, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport)
  System.Void Awake()
  System.Void OnDestroy()
  System.Void ReadFontAssetDefinition()
  System.Void InitializeDictionaryLookupTables()
  System.Void InitializeGlyphLookupDictionary()
  System.Void InitializeCharacterLookupDictionary()
  System.Void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
  System.Void AddSynthesizedCharactersAndFaceMetrics()
  System.Void AddSynthesizedCharacter(System.UInt32 unicode, System.Boolean isFontFaceLoaded, System.Boolean addImmediately)
  System.Void AddCharacterToLookupCache(System.UInt32 unicode, UnityEngine.TextCore.Text.Character character)
  UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace()
  System.Void SortCharacterTable()
  System.Void SortGlyphTable()
  System.Void SortFontFeatureTable()
  System.Void SortAllTables()
  System.Boolean HasCharacter(System.Int32 character)
  System.Boolean HasCharacter(System.Char character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter)
  System.Boolean HasCharacter_Internal(System.UInt32 character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter)
  System.Boolean HasCharacters(System.String text, System.Collections.Generic.List<System.Char>& missingCharacters)
  System.Boolean HasCharacters(System.String text, System.UInt32[]& missingCharacters, System.Boolean searchFallbacks, System.Boolean tryAddCharacter)
  System.Boolean HasCharacters(System.String text)
  System.String GetCharacters(UnityEngine.TextCore.Text.FontAsset fontAsset)
  System.Int32[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset fontAsset)
  System.UInt32 GetGlyphIndex(System.UInt32 unicode)
  System.Void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset fontAsset)
  System.Void UpdateFontFeaturesForFontAssetsInQueue()
  System.Void RegisterAtlasTextureForApply(UnityEngine.Texture2D texture)
  System.Void UpdateAtlasTexturesInQueue()
  System.Void UpdateFontAssetInUpdateQueue()
  System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.Boolean includeFontFeatures)
  System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.UInt32[]& missingUnicodes, System.Boolean includeFontFeatures)
  System.Boolean TryAddCharacters(System.String characters, System.Boolean includeFontFeatures)
  System.Boolean TryAddCharacters(System.String characters, System.String& missingCharacters, System.Boolean includeFontFeatures)
  System.Boolean TryAddCharacterInternal(System.UInt32 unicode, UnityEngine.TextCore.Text.Character& character, System.Boolean shouldGetFontFeatures)
  System.Boolean TryGetCharacter_and_QueueRenderToTexture(System.UInt32 unicode, UnityEngine.TextCore.Text.Character& character, System.Boolean shouldGetFontFeatures)
  System.Void TryAddGlyphsToAtlasTextures()
  System.Boolean TryAddGlyphsToNewAtlasTexture()
  System.Void SetupNewAtlasTexture()
  System.Void UpdateAtlasTexture()
  System.Void UpdateGlyphAdjustmentRecords()
  System.Void UpdateGlyphAdjustmentRecords(System.UInt32[] glyphIndexes)
  System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes)
  System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> newGlyphIndexes, System.Collections.Generic.List<System.UInt32> allGlyphIndexes)
  System.Void CopyListDataToArray(System.Collections.Generic.List<T> srcList, T[]& dstArray)
  System.Void ClearFontAssetData(System.Boolean setAtlasSizeToZero)
  System.Void ClearFontAssetDataInternal()
  System.Void UpdateFontAssetData()
  System.Void ClearFontAssetTables()
  System.Void ClearAtlasTextures(System.Boolean setAtlasSizeToZero)
  System.Void DestroyAtlasTextures()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.FontAssetUtilities
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static  System.Collections.Generic.HashSet<System.Int32>k_SearchedAssets  // 0x0
METHODS:
  UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset(System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Boolean includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, System.Boolean& isAlternativeTypeface)
  UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset_Internal(System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Boolean includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, System.Boolean& isAlternativeTypeface)
  UnityEngine.TextCore.Text.Character GetCharacterFromFontAssets(System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, System.Boolean includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, System.Boolean& isAlternativeTypeface)
  UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset(System.UInt32 unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.Boolean includeFallbacks)
  UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(System.UInt32 unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.Boolean includeFallbacks)
END_CLASS

CLASS: UnityEngine.TextCore.Text.FontFeatureTable
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>m_GlyphPairAdjustmentRecords  // 0x10
  private           System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>m_GlyphPairAdjustmentRecordLookup  // 0x18
METHODS:
  System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords()
  System.Void .ctor()
  System.Void SortGlyphPairAdjustmentRecords()
END_CLASS

CLASS: UnityEngine.TextCore.Text.Extents
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            UnityEngine.Vector2             min  // 0x10
  public            UnityEngine.Vector2             max  // 0x18
METHODS:
  System.String ToString()
END_CLASS

CLASS: UnityEngine.TextCore.Text.LineInfo
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  private           System.Int32                    controlCharacterCount  // 0x10
  public            System.Int32                    characterCount  // 0x14
  public            System.Int32                    visibleCharacterCount  // 0x18
  public            System.Int32                    spaceCount  // 0x1C
  public            System.Int32                    visibleSpaceCount  // 0x20
  public            System.Int32                    wordCount  // 0x24
  public            System.Int32                    firstCharacterIndex  // 0x28
  public            System.Int32                    firstVisibleCharacterIndex  // 0x2C
  public            System.Int32                    lastCharacterIndex  // 0x30
  public            System.Int32                    lastVisibleCharacterIndex  // 0x34
  public            System.Single                   length  // 0x38
  public            System.Single                   lineHeight  // 0x3C
  public            System.Single                   ascender  // 0x40
  public            System.Single                   baseline  // 0x44
  public            System.Single                   descender  // 0x48
  public            System.Single                   maxAdvance  // 0x4C
  public            System.Single                   width  // 0x50
  public            System.Single                   marginLeft  // 0x54
  public            System.Single                   marginRight  // 0x58
  public            UnityEngine.TextCore.Text.TextAlignmentalignment  // 0x5C
  public            UnityEngine.TextCore.Text.ExtentslineExtents  // 0x60
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.LinkInfo
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    hashCode  // 0x10
  public            System.Int32                    linkIdFirstCharacterIndex  // 0x14
  public            System.Int32                    linkIdLength  // 0x18
  public            System.Int32                    linkTextfirstCharacterIndex  // 0x1C
  public            System.Int32                    linkTextLength  // 0x20
  private           System.Char[]                   linkId  // 0x28
METHODS:
  System.Void SetLinkId(System.Char[] text, System.Int32 startIndex, System.Int32 length)
END_CLASS

CLASS: UnityEngine.TextCore.Text.MaterialManager
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Material>s_FallbackMaterials  // 0x0
METHODS:
  UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial)
  UnityEngine.Material GetFallbackMaterial(UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.Material sourceMaterial, System.Int32 atlasIndex)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.MaterialReference
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Int32                    index  // 0x10
  public            UnityEngine.TextCore.Text.FontAssetfontAsset  // 0x18
  public            UnityEngine.TextCore.Text.SpriteAssetspriteAsset  // 0x20
  public            UnityEngine.Material            material  // 0x28
  public            System.Boolean                  isDefaultMaterial  // 0x30
  public            System.Boolean                  isFallbackMaterial  // 0x31
  public            UnityEngine.Material            fallbackMaterial  // 0x38
  public            System.Single                   padding  // 0x40
  public            System.Int32                    referenceCount  // 0x44
METHODS:
  System.Void .ctor(System.Int32 index, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.Material material, System.Single padding)
  System.Int32 AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup)
  System.Int32 AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.TextCore.Text.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup)
END_CLASS

CLASS: UnityEngine.TextCore.Text.MaterialReferenceManager
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private   static  UnityEngine.TextCore.Text.MaterialReferenceManagers_Instance  // 0x0
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material>m_FontMaterialReferenceLookup  // 0x10
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset>m_FontAssetReferenceLookup  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.SpriteAsset>m_SpriteAssetReferenceLookup  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextColorGradient>m_ColorGradientReferenceLookup  // 0x28
METHODS:
  UnityEngine.TextCore.Text.MaterialReferenceManager get_instance()
  System.Void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset)
  System.Void AddFontAssetInternal(UnityEngine.TextCore.Text.FontAsset fontAsset)
  System.Void AddSpriteAsset(System.Int32 hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset)
  System.Void AddSpriteAssetInternal(System.Int32 hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset)
  System.Void AddFontMaterial(System.Int32 hashCode, UnityEngine.Material material)
  System.Void AddFontMaterialInternal(System.Int32 hashCode, UnityEngine.Material material)
  System.Void AddColorGradientPreset(System.Int32 hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset)
  System.Void AddColorGradientPreset_Internal(System.Int32 hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset)
  System.Boolean TryGetFontAsset(System.Int32 hashCode, UnityEngine.TextCore.Text.FontAsset& fontAsset)
  System.Boolean TryGetFontAssetInternal(System.Int32 hashCode, UnityEngine.TextCore.Text.FontAsset& fontAsset)
  System.Boolean TryGetSpriteAsset(System.Int32 hashCode, UnityEngine.TextCore.Text.SpriteAsset& spriteAsset)
  System.Boolean TryGetSpriteAssetInternal(System.Int32 hashCode, UnityEngine.TextCore.Text.SpriteAsset& spriteAsset)
  System.Boolean TryGetColorGradientPreset(System.Int32 hashCode, UnityEngine.TextCore.Text.TextColorGradient& gradientPreset)
  System.Boolean TryGetColorGradientPresetInternal(System.Int32 hashCode, UnityEngine.TextCore.Text.TextColorGradient& gradientPreset)
  System.Boolean TryGetMaterial(System.Int32 hashCode, UnityEngine.Material& material)
  System.Boolean TryGetMaterialInternal(System.Int32 hashCode, UnityEngine.Material& material)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.VertexSortingOrder
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.VertexSortingOrderNormal  // 0x0
  public    static  UnityEngine.TextCore.Text.VertexSortingOrderReverse  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.MeshInfo
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  private   static readonly UnityEngine.Color32             k_DefaultColor  // 0x0
  public            System.Int32                    vertexCount  // 0x10
  public            UnityEngine.Vector3[]           vertices  // 0x18
  public            UnityEngine.Vector2[]           uvs0  // 0x20
  public            UnityEngine.Vector2[]           uvs2  // 0x28
  public            UnityEngine.Color32[]           colors32  // 0x30
  public            System.Int32[]                  triangles  // 0x38
  public            UnityEngine.Material            material  // 0x40
METHODS:
  System.Void .ctor(System.Int32 size)
  System.Void ResizeMeshInfo(System.Int32 size)
  System.Void Clear(System.Boolean uploadChanges)
  System.Void ClearUnusedVertices()
  System.Void SortGeometry(UnityEngine.TextCore.Text.VertexSortingOrder order)
  System.Void SwapVertexData(System.Int32 src, System.Int32 dst)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.SpriteAsset
TYPE:  class
TOKEN: 0x2000015
EXTENDS: TextAsset
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_NameLookup  // 0x38
  private           System.Collections.Generic.Dictionary<System.UInt32,System.Int32>m_GlyphIndexLookup  // 0x40
  private           UnityEngine.TextCore.FaceInfo   m_FaceInfo  // 0x48
  private           UnityEngine.Texture             m_SpriteAtlasTexture  // 0xA8
  private           System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter>m_SpriteCharacterTable  // 0xB0
  private           System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter>m_SpriteCharacterLookup  // 0xB8
  private           System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph>m_SpriteGlyphTable  // 0xC0
  private           System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteGlyph>m_SpriteGlyphLookup  // 0xC8
  public            System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset>fallbackSpriteAssets  // 0xD0
  private           System.Boolean                  m_IsSpriteAssetLookupTablesDirty  // 0xD8
  private   static  System.Collections.Generic.HashSet<System.Int32>k_searchedSpriteAssets  // 0x0
METHODS:
  UnityEngine.TextCore.FaceInfo get_faceInfo()
  System.Void set_faceInfo(UnityEngine.TextCore.FaceInfo value)
  UnityEngine.Texture get_spriteSheet()
  System.Void set_spriteSheet(UnityEngine.Texture value)
  System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterTable()
  System.Void set_spriteCharacterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> value)
  System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterLookupTable()
  System.Void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> value)
  System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> get_spriteGlyphTable()
  System.Void set_spriteGlyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> value)
  System.Void Awake()
  System.Void UpdateLookupTables()
  System.Int32 GetSpriteIndexFromHashcode(System.Int32 hashCode)
  System.Int32 GetSpriteIndexFromUnicode(System.UInt32 unicode)
  System.Int32 GetSpriteIndexFromName(System.String name)
  UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean includeFallbacks, System.Int32& spriteIndex, UnityEngine.TextCore.Text.TextSettings textSettings)
  UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex)
  UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex)
  System.Void SortGlyphTable()
  System.Void SortCharacterTable()
  System.Void SortGlyphAndCharacterTables()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.SpriteCharacter
TYPE:  class
TOKEN: 0x2000017
EXTENDS: TextElement
FIELDS:
  private           System.String                   m_Name  // 0x30
  private           System.Int32                    m_HashCode  // 0x38
METHODS:
  System.String get_name()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.SpriteGlyph
TYPE:  class
TOKEN: 0x2000018
EXTENDS: Glyph
FIELDS:
  public            UnityEngine.Sprite              sprite  // 0x48
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextAsset
TYPE:  class
TOKEN: 0x2000019
EXTENDS: ScriptableObject
FIELDS:
  private           System.String                   m_Version  // 0x18
  private           System.Int32                    m_InstanceID  // 0x20
  private           System.Int32                    m_HashCode  // 0x24
  private           UnityEngine.Material            m_Material  // 0x28
  private           System.Int32                    m_MaterialHashCode  // 0x30
METHODS:
  System.String get_version()
  System.Void set_version(System.String value)
  System.Int32 get_instanceID()
  System.Int32 get_hashCode()
  System.Void set_hashCode(System.Int32 value)
  UnityEngine.Material get_material()
  System.Void set_material(UnityEngine.Material value)
  System.Int32 get_materialHashCode()
  System.Void set_materialHashCode(System.Int32 value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.ColorGradientMode
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.ColorGradientModeSingle  // 0x0
  public    static  UnityEngine.TextCore.Text.ColorGradientModeHorizontalGradient  // 0x0
  public    static  UnityEngine.TextCore.Text.ColorGradientModeVerticalGradient  // 0x0
  public    static  UnityEngine.TextCore.Text.ColorGradientModeFourCornersGradient  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextColorGradient
TYPE:  class
TOKEN: 0x200001B
EXTENDS: ScriptableObject
FIELDS:
  public            UnityEngine.TextCore.Text.ColorGradientModecolorMode  // 0x18
  public            UnityEngine.Color               topLeft  // 0x1C
  public            UnityEngine.Color               topRight  // 0x2C
  public            UnityEngine.Color               bottomLeft  // 0x3C
  public            UnityEngine.Color               bottomRight  // 0x4C
  private   static  UnityEngine.TextCore.Text.ColorGradientModek_DefaultColorMode  // 0x0
  private   static readonly UnityEngine.Color               k_DefaultColor  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Color color)
  System.Void .ctor(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextElementType
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.TextCore.Text.TextElementTypeCharacter  // 0x0
  public    static  UnityEngine.TextCore.Text.TextElementTypeSprite  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextElement
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  protected         UnityEngine.TextCore.Text.TextElementTypem_ElementType  // 0x10
  private           System.UInt32                   m_Unicode  // 0x14
  private           UnityEngine.TextCore.Text.TextAssetm_TextAsset  // 0x18
  private           UnityEngine.TextCore.Glyph      m_Glyph  // 0x20
  private           System.UInt32                   m_GlyphIndex  // 0x28
  private           System.Single                   m_Scale  // 0x2C
METHODS:
  UnityEngine.TextCore.Text.TextElementType get_elementType()
  System.UInt32 get_unicode()
  System.Void set_unicode(System.UInt32 value)
  UnityEngine.TextCore.Text.TextAsset get_textAsset()
  System.Void set_textAsset(UnityEngine.TextCore.Text.TextAsset value)
  UnityEngine.TextCore.Glyph get_glyph()
  System.Void set_glyph(UnityEngine.TextCore.Glyph value)
  System.UInt32 get_glyphIndex()
  System.Void set_glyphIndex(System.UInt32 value)
  System.Single get_scale()
  System.Void set_scale(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextVertex
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector2             uv  // 0x1C
  public            UnityEngine.Vector2             uv2  // 0x24
  public            UnityEngine.Vector2             uv4  // 0x2C
  public            UnityEngine.Color32             color  // 0x34
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextElementInfo
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Char                     character  // 0x10
  public            System.Int32                    index  // 0x14
  public            UnityEngine.TextCore.Text.TextElementTypeelementType  // 0x18
  public            UnityEngine.TextCore.Text.TextElementtextElement  // 0x20
  public            UnityEngine.TextCore.Text.FontAssetfontAsset  // 0x28
  public            UnityEngine.TextCore.Text.SpriteAssetspriteAsset  // 0x30
  public            System.Int32                    spriteIndex  // 0x38
  public            UnityEngine.Material            material  // 0x40
  public            System.Int32                    materialReferenceIndex  // 0x48
  public            System.Boolean                  isUsingAlternateTypeface  // 0x4C
  public            System.Single                   pointSize  // 0x50
  public            System.Int32                    lineNumber  // 0x54
  public            System.Int32                    pageNumber  // 0x58
  public            System.Int32                    vertexIndex  // 0x5C
  public            UnityEngine.TextCore.Text.TextVertexvertexTopLeft  // 0x60
  public            UnityEngine.TextCore.Text.TextVertexvertexBottomLeft  // 0x88
  public            UnityEngine.TextCore.Text.TextVertexvertexTopRight  // 0xB0
  public            UnityEngine.TextCore.Text.TextVertexvertexBottomRight  // 0xD8
  public            UnityEngine.Vector3             topLeft  // 0x100
  public            UnityEngine.Vector3             bottomLeft  // 0x10C
  public            UnityEngine.Vector3             topRight  // 0x118
  public            UnityEngine.Vector3             bottomRight  // 0x124
  public            System.Single                   origin  // 0x130
  public            System.Single                   ascender  // 0x134
  public            System.Single                   baseLine  // 0x138
  public            System.Single                   descender  // 0x13C
  public            System.Single                   xAdvance  // 0x140
  public            System.Single                   aspectRatio  // 0x144
  public            System.Single                   scale  // 0x148
  public            UnityEngine.Color32             color  // 0x14C
  public            UnityEngine.Color32             underlineColor  // 0x150
  public            UnityEngine.Color32             strikethroughColor  // 0x154
  public            UnityEngine.Color32             highlightColor  // 0x158
  public            UnityEngine.TextCore.Text.FontStylesstyle  // 0x15C
  public            System.Boolean                  isVisible  // 0x160
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextOverflowMode
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.TextOverflowModeOverflow  // 0x0
  public    static  UnityEngine.TextCore.Text.TextOverflowModeEllipsis  // 0x0
  public    static  UnityEngine.TextCore.Text.TextOverflowModeMasking  // 0x0
  public    static  UnityEngine.TextCore.Text.TextOverflowModeTruncate  // 0x0
  public    static  UnityEngine.TextCore.Text.TextOverflowModeScrollRect  // 0x0
  public    static  UnityEngine.TextCore.Text.TextOverflowModePage  // 0x0
  public    static  UnityEngine.TextCore.Text.TextOverflowModeLinked  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextureMapping
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.TextureMappingCharacter  // 0x0
  public    static  UnityEngine.TextCore.Text.TextureMappingLine  // 0x0
  public    static  UnityEngine.TextCore.Text.TextureMappingParagraph  // 0x0
  public    static  UnityEngine.TextCore.Text.TextureMappingMatchAspect  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextGenerationSettings
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  public            System.String                   text  // 0x10
  public            UnityEngine.Rect                screenRect  // 0x18
  public            UnityEngine.Vector4             margins  // 0x28
  public            System.Single                   scale  // 0x38
  public            UnityEngine.TextCore.Text.FontAssetfontAsset  // 0x40
  public            UnityEngine.Material            material  // 0x48
  public            UnityEngine.TextCore.Text.SpriteAssetspriteAsset  // 0x50
  public            UnityEngine.TextCore.Text.TextStyleSheetstyleSheet  // 0x58
  public            UnityEngine.TextCore.Text.FontStylesfontStyle  // 0x60
  public            UnityEngine.TextCore.Text.TextSettingstextSettings  // 0x68
  public            UnityEngine.TextCore.Text.TextAlignmenttextAlignment  // 0x70
  public            UnityEngine.TextCore.Text.TextOverflowModeoverflowMode  // 0x74
  public            System.Boolean                  wordWrap  // 0x78
  public            System.Single                   wordWrappingRatio  // 0x7C
  public            UnityEngine.Color               color  // 0x80
  public            UnityEngine.TextCore.Text.TextColorGradientfontColorGradient  // 0x90
  public            System.Boolean                  tintSprites  // 0x98
  public            System.Boolean                  overrideRichTextColors  // 0x99
  public            System.Single                   fontSize  // 0x9C
  public            System.Boolean                  autoSize  // 0xA0
  public            System.Single                   fontSizeMin  // 0xA4
  public            System.Single                   fontSizeMax  // 0xA8
  public            System.Boolean                  enableKerning  // 0xAC
  public            System.Boolean                  richText  // 0xAD
  public            System.Boolean                  isRightToLeft  // 0xAE
  public            System.Boolean                  extraPadding  // 0xAF
  public            System.Boolean                  parseControlCharacters  // 0xB0
  public            System.Single                   characterSpacing  // 0xB4
  public            System.Single                   wordSpacing  // 0xB8
  public            System.Single                   lineSpacing  // 0xBC
  public            System.Single                   paragraphSpacing  // 0xC0
  public            System.Single                   lineSpacingMax  // 0xC4
  public            System.Int32                    maxVisibleCharacters  // 0xC8
  public            System.Int32                    maxVisibleWords  // 0xCC
  public            System.Int32                    maxVisibleLines  // 0xD0
  public            System.Int32                    firstVisibleCharacter  // 0xD4
  public            System.Boolean                  useMaxVisibleDescender  // 0xD8
  public            UnityEngine.TextCore.Text.TextFontWeightfontWeight  // 0xDC
  public            System.Int32                    pageToDisplay  // 0xE0
  public            UnityEngine.TextCore.Text.TextureMappinghorizontalMapping  // 0xE4
  public            UnityEngine.TextCore.Text.TextureMappingverticalMapping  // 0xE8
  public            System.Single                   uvLineOffset  // 0xEC
  public            UnityEngine.TextCore.Text.VertexSortingOrdergeometrySortingOrder  // 0xF0
  public            System.Boolean                  inverseYAxis  // 0xF4
  public            System.Single                   charWidthMaxAdj  // 0xF8
METHODS:
  System.Boolean Equals(UnityEngine.TextCore.Text.TextGenerationSettings other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextGenerator
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private   static  UnityEngine.TextCore.Text.TextGenerators_TextGenerator  // 0x0
  private           UnityEngine.Vector3[]           m_RectTransformCorners  // 0x10
  private           System.Single                   m_MarginWidth  // 0x18
  private           System.Single                   m_MarginHeight  // 0x1C
  private           System.Int32[]                  m_CharBuffer  // 0x20
  private           System.Single                   m_PreferredWidth  // 0x28
  private           System.Single                   m_PreferredHeight  // 0x2C
  private           UnityEngine.TextCore.Text.FontAssetm_CurrentFontAsset  // 0x30
  private           UnityEngine.Material            m_CurrentMaterial  // 0x38
  private           System.Int32                    m_CurrentMaterialIndex  // 0x40
  private           UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference>m_MaterialReferenceStack  // 0x48
  private           System.Single                   m_Padding  // 0xA0
  private           UnityEngine.TextCore.Text.SpriteAssetm_CurrentSpriteAsset  // 0xA8
  private           System.Int32                    m_TotalCharacterCount  // 0xB0
  private           System.Single                   m_FontScale  // 0xB4
  private           System.Single                   m_FontSize  // 0xB8
  private           System.Single                   m_FontScaleMultiplier  // 0xBC
  private           System.Single                   m_CurrentFontSize  // 0xC0
  private           UnityEngine.TextCore.Text.TextProcessingStack<System.Single>m_SizeStack  // 0xC8
  private           UnityEngine.TextCore.Text.FontStylesm_FontStyleInternal  // 0xE8
  private           UnityEngine.TextCore.Text.FontStyleStackm_FontStyleStack  // 0xEC
  private           UnityEngine.TextCore.Text.TextFontWeightm_FontWeightInternal  // 0xF8
  private           UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight>m_FontWeightStack  // 0x100
  private           UnityEngine.TextCore.Text.TextAlignmentm_LineJustification  // 0x120
  private           UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment>m_LineJustificationStack  // 0x128
  private           System.Single                   m_BaselineOffset  // 0x148
  private           UnityEngine.TextCore.Text.TextProcessingStack<System.Single>m_BaselineOffsetStack  // 0x150
  private           UnityEngine.Color32             m_FontColor32  // 0x170
  private           UnityEngine.Color32             m_HtmlColor  // 0x174
  private           UnityEngine.Color32             m_UnderlineColor  // 0x178
  private           UnityEngine.Color32             m_StrikethroughColor  // 0x17C
  private           UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32>m_ColorStack  // 0x180
  private           UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32>m_UnderlineColorStack  // 0x1A0
  private           UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32>m_StrikethroughColorStack  // 0x1C0
  private           UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32>m_HighlightColorStack  // 0x1E0
  private           UnityEngine.TextCore.Text.TextColorGradientm_ColorGradientPreset  // 0x200
  private           UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient>m_ColorGradientStack  // 0x208
  private           UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>m_ActionStack  // 0x230
  private           System.Boolean                  m_IsFxMatrixSet  // 0x250
  private           System.Single                   m_LineOffset  // 0x254
  private           System.Single                   m_LineHeight  // 0x258
  private           System.Single                   m_CSpacing  // 0x25C
  private           System.Single                   m_MonoSpacing  // 0x260
  private           System.Single                   m_XAdvance  // 0x264
  private           System.Single                   m_TagLineIndent  // 0x268
  private           System.Single                   m_TagIndent  // 0x26C
  private           UnityEngine.TextCore.Text.TextProcessingStack<System.Single>m_IndentStack  // 0x270
  private           System.Boolean                  m_TagNoParsing  // 0x290
  private           System.Int32                    m_CharacterCount  // 0x294
  private           System.Int32                    m_FirstCharacterOfLine  // 0x298
  private           System.Int32                    m_LastCharacterOfLine  // 0x29C
  private           System.Int32                    m_FirstVisibleCharacterOfLine  // 0x2A0
  private           System.Int32                    m_LastVisibleCharacterOfLine  // 0x2A4
  private           System.Single                   m_MaxLineAscender  // 0x2A8
  private           System.Single                   m_MaxLineDescender  // 0x2AC
  private           System.Int32                    m_LineNumber  // 0x2B0
  private           System.Int32                    m_LineVisibleCharacterCount  // 0x2B4
  private           System.Int32                    m_FirstOverflowCharacterIndex  // 0x2B8
  private           System.Int32                    m_PageNumber  // 0x2BC
  private           System.Single                   m_MarginLeft  // 0x2C0
  private           System.Single                   m_MarginRight  // 0x2C4
  private           System.Single                   m_Width  // 0x2C8
  private           UnityEngine.TextCore.Text.Extentsm_MeshExtents  // 0x2CC
  private           System.Single                   m_MaxCapHeight  // 0x2DC
  private           System.Single                   m_MaxAscender  // 0x2E0
  private           System.Single                   m_MaxDescender  // 0x2E4
  private           System.Boolean                  m_IsNewPage  // 0x2E8
  private           System.Boolean                  m_IsNonBreakingSpace  // 0x2E9
  private           UnityEngine.TextCore.Text.WordWrapStatem_SavedWordWrapState  // 0x2F0
  private           UnityEngine.TextCore.Text.WordWrapStatem_SavedLineState  // 0x600
  private           System.Int32                    m_LoopCountA  // 0x910
  private           UnityEngine.TextCore.Text.TextElementTypem_TextElementType  // 0x914
  private           System.Boolean                  m_IsParsingText  // 0x915
  private           System.Int32                    m_SpriteIndex  // 0x918
  private           UnityEngine.Color32             m_SpriteColor  // 0x91C
  private           UnityEngine.TextCore.Text.TextElementm_CachedTextElement  // 0x920
  private           UnityEngine.Color32             m_HighlightColor  // 0x928
  private           System.Single                   m_CharWidthAdjDelta  // 0x92C
  private           UnityEngine.Matrix4x4           m_FxMatrix  // 0x930
  private           System.Single                   m_MaxFontSize  // 0x970
  private           System.Single                   m_MinFontSize  // 0x974
  private           System.Boolean                  m_IsCharacterWrappingEnabled  // 0x978
  private           System.Single                   m_StartOfLineAscender  // 0x97C
  private           System.Single                   m_LineSpacingDelta  // 0x980
  private           System.Boolean                  m_IsMaskingEnabled  // 0x984
  private           UnityEngine.TextCore.Text.MaterialReference[]m_MaterialReferences  // 0x988
  private           System.Int32                    m_SpriteCount  // 0x990
  private           UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>m_StyleStack  // 0x998
  private           System.Int32                    m_SpriteAnimationId  // 0x9B8
  private           System.UInt32[]                 m_InternalTextParsingBuffer  // 0x9C0
  private           UnityEngine.TextCore.Text.RichTextTagAttribute[]m_Attributes  // 0x9C8
  private           UnityEngine.TextCore.Text.XmlTagAttribute[]m_XmlAttribute  // 0x9D0
  private           System.Char[]                   m_RichTextTag  // 0x9D8
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_MaterialReferenceIndexLookup  // 0x9E0
  private           System.Boolean                  m_IsCalculatingPreferredValues  // 0x9E8
  private           UnityEngine.TextCore.Text.SpriteAssetm_DefaultSpriteAsset  // 0x9F0
  private           System.Boolean                  m_TintSprite  // 0x9F8
  protected         UnityEngine.TextCore.Text.TextGenerator.SpecialCharacterm_Ellipsis  // 0xA00
  protected         UnityEngine.TextCore.Text.TextGenerator.SpecialCharacterm_Underline  // 0xA20
  private           System.Boolean                  m_IsUsingBold  // 0xA40
  private           System.Boolean                  m_IsSdfShader  // 0xA41
  private           UnityEngine.TextCore.Text.TextElementInfo[]m_InternalTextElementInfo  // 0xA48
  private           System.Int32                    m_RecursiveCount  // 0xA50
METHODS:
  UnityEngine.TextCore.Text.TextGenerator GetTextGenerator()
  System.Void GenerateText(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo)
  UnityEngine.Vector2 GetCursorPosition(UnityEngine.TextCore.Text.TextInfo textInfo, UnityEngine.Rect screenRect, System.Int32 index, System.Boolean inverseYAxis)
  UnityEngine.Vector2 GetPreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void Prepare(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void GenerateTextMesh(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void SaveWordWrappingState(UnityEngine.TextCore.Text.WordWrapState& state, System.Int32 index, System.Int32 count, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Int32 RestoreWordWrappingState(UnityEngine.TextCore.Text.WordWrapState& state, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Boolean ValidateHtmlTag(System.Int32[] chars, System.Int32 startIndex, System.Int32& endIndex, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void SaveGlyphVertexInfo(System.Single padding, System.Single stylePadding, UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, System.Single startScale, System.Single endScale, System.Single maxScale, System.Single sdfScale, UnityEngine.Color32 underlineColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, UnityEngine.Color32 highlightColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void ClearMesh(System.Boolean updateMesh, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void EnableMasking()
  System.Void DisableMasking()
  System.Void SetArraySizes(System.Int32[] chars, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  UnityEngine.TextCore.Text.TextElement GetTextElement(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, System.UInt32 unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, System.Boolean& isUsingAlternativeTypeface)
  System.Void ComputeMarginSize(UnityEngine.Rect rect, UnityEngine.Vector4 margins)
  System.Void GetSpecialCharacters(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
  System.Void GetEllipsisSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
  System.Void GetUnderlineSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
  System.Single GetPaddingForMaterial(UnityEngine.Material material, System.Boolean extraPadding)
  UnityEngine.Vector2 GetPreferredValuesInternal(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  UnityEngine.Vector2 CalculatePreferredValues(System.Single defaultFontSize, UnityEngine.Vector2 marginSize, System.Boolean ignoreTextAutoSizing, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextAlignment
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.TextAlignmentTopLeft  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentTopCenter  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentTopRight  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentTopJustified  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentTopFlush  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentTopGeoAligned  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMiddleLeft  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMiddleCenter  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMiddleRight  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMiddleJustified  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMiddleFlush  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMiddleGeoAligned  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBottomLeft  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBottomCenter  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBottomRight  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBottomJustified  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBottomFlush  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBottomGeoAligned  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBaselineLeft  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBaselineCenter  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBaselineRight  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBaselineJustified  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBaselineFlush  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentBaselineGeoAligned  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMidlineLeft  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMidlineCenter  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMidlineRight  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMidlineJustified  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMidlineFlush  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentMidlineGeoAligned  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentCaplineLeft  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentCaplineCenter  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentCaplineRight  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentCaplineJustified  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentCaplineFlush  // 0x0
  public    static  UnityEngine.TextCore.Text.TextAlignmentCaplineGeoAligned  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.FontStyles
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.FontStylesNormal  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesBold  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesItalic  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesUnderline  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesLowerCase  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesUpperCase  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesSmallCaps  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesStrikethrough  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesSuperscript  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesSubscript  // 0x0
  public    static  UnityEngine.TextCore.Text.FontStylesHighlight  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.XmlTagAttribute
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    nameHashCode  // 0x10
  public            UnityEngine.TextCore.Text.TagValueTypevalueType  // 0x14
  public            System.Int32                    valueStartIndex  // 0x18
  public            System.Int32                    valueLength  // 0x1C
  public            System.Int32                    valueHashCode  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.RichTextTagAttribute
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Int32                    nameHashCode  // 0x10
  public            System.Int32                    valueHashCode  // 0x14
  public            UnityEngine.TextCore.Text.TagValueTypevalueType  // 0x18
  public            System.Int32                    valueStartIndex  // 0x1C
  public            System.Int32                    valueLength  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.WordWrapState
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    previousWordBreak  // 0x10
  public            System.Int32                    totalCharacterCount  // 0x14
  public            System.Int32                    visibleCharacterCount  // 0x18
  public            System.Int32                    visibleSpriteCount  // 0x1C
  public            System.Int32                    visibleLinkCount  // 0x20
  public            System.Int32                    firstCharacterIndex  // 0x24
  public            System.Int32                    firstVisibleCharacterIndex  // 0x28
  public            System.Int32                    lastCharacterIndex  // 0x2C
  public            System.Int32                    lastVisibleCharIndex  // 0x30
  public            System.Int32                    lineNumber  // 0x34
  public            System.Single                   maxCapHeight  // 0x38
  public            System.Single                   maxAscender  // 0x3C
  public            System.Single                   maxDescender  // 0x40
  public            System.Single                   maxLineAscender  // 0x44
  public            System.Single                   maxLineDescender  // 0x48
  public            System.Single                   previousLineAscender  // 0x4C
  public            System.Single                   xAdvance  // 0x50
  public            System.Single                   preferredWidth  // 0x54
  public            System.Single                   preferredHeight  // 0x58
  public            System.Single                   previousLineScale  // 0x5C
  public            System.Int32                    wordCount  // 0x60
  public            UnityEngine.TextCore.Text.FontStylesfontStyle  // 0x64
  public            System.Single                   fontScale  // 0x68
  public            System.Single                   fontScaleMultiplier  // 0x6C
  public            System.Single                   currentFontSize  // 0x70
  public            System.Single                   baselineOffset  // 0x74
  public            System.Single                   lineOffset  // 0x78
  public            UnityEngine.TextCore.Text.TextInfotextInfo  // 0x80
  public            UnityEngine.TextCore.Text.LineInfolineInfo  // 0x88
  public            UnityEngine.Color32             vertexColor  // 0xE8
  public            UnityEngine.Color32             underlineColor  // 0xEC
  public            UnityEngine.Color32             strikethroughColor  // 0xF0
  public            UnityEngine.Color32             highlightColor  // 0xF4
  public            UnityEngine.TextCore.Text.FontStyleStackbasicStyleStack  // 0xF8
  public            UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32>colorStack  // 0x108
  public            UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32>underlineColorStack  // 0x128
  public            UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32>strikethroughColorStack  // 0x148
  public            UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32>highlightColorStack  // 0x168
  public            UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient>colorGradientStack  // 0x188
  public            UnityEngine.TextCore.Text.TextProcessingStack<System.Single>sizeStack  // 0x1B0
  public            UnityEngine.TextCore.Text.TextProcessingStack<System.Single>indentStack  // 0x1D0
  public            UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight>fontWeightStack  // 0x1F0
  public            UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>styleStack  // 0x210
  public            UnityEngine.TextCore.Text.TextProcessingStack<System.Single>baselineStack  // 0x230
  public            UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>actionStack  // 0x250
  public            UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference>materialReferenceStack  // 0x270
  public            UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment>lineJustificationStack  // 0x2C8
  public            System.Int32                    spriteAnimationId  // 0x2E8
  public            UnityEngine.TextCore.Text.FontAssetcurrentFontAsset  // 0x2F0
  public            UnityEngine.TextCore.Text.SpriteAssetcurrentSpriteAsset  // 0x2F8
  public            UnityEngine.Material            currentMaterial  // 0x300
  public            System.Int32                    currentMaterialIndex  // 0x308
  public            UnityEngine.TextCore.Text.ExtentsmeshExtents  // 0x30C
  public            System.Boolean                  tagNoParsing  // 0x31C
  public            System.Boolean                  isNonBreakingSpace  // 0x31D
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextGeneratorUtilities
TYPE:  class
TOKEN: 0x200002A
FIELDS:
  public    static readonly UnityEngine.Vector2             largePositiveVector2  // 0x0
  public    static readonly UnityEngine.Vector2             largeNegativeVector2  // 0x8
METHODS:
  System.Boolean Approximately(System.Single a, System.Single b)
  UnityEngine.Color32 HexCharsToColor(System.Char[] hexChars, System.Int32 tagCount)
  UnityEngine.Color32 HexCharsToColor(System.Char[] hexChars, System.Int32 startIndex, System.Int32 length)
  System.Int32 HexToInt(System.Char hex)
  System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length)
  System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length, System.Int32& lastIndex)
  UnityEngine.Vector2 PackUV(System.Single x, System.Single y, System.Single scale)
  System.Void StringToCharArray(System.String sourceText, System.Int32[]& charBuffer, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>& styleStack, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
  System.Void ResizeInternalArray(T[]& array)
  System.Boolean IsTagName(System.String& text, System.String tag, System.Int32 index)
  System.Boolean IsTagName(System.Int32[]& text, System.String tag, System.Int32 index)
  System.Boolean ReplaceOpeningStyleTag(System.Int32[]& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, System.Int32[]& charBuffer, System.Int32& writeIndex, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>& styleStack, UnityEngine.TextCore.Text.TextGenerationSettings& generationSettings)
  System.Boolean ReplaceOpeningStyleTag(System.String& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, System.Int32[]& charBuffer, System.Int32& writeIndex, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>& styleStack, UnityEngine.TextCore.Text.TextGenerationSettings& generationSettings)
  System.Void ReplaceClosingStyleTag(System.Int32[]& charBuffer, System.Int32& writeIndex, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>& styleStack, UnityEngine.TextCore.Text.TextGenerationSettings& generationSettings)
  UnityEngine.TextCore.Text.TextStyle GetStyle(UnityEngine.TextCore.Text.TextGenerationSettings generationSetting, System.Int32 hashCode)
  System.Int32 GetUtf32(System.String text, System.Int32 i)
  System.Int32 GetUtf16(System.String text, System.Int32 i)
  System.Int32 GetTagHashCode(System.Int32[]& text, System.Int32 index, System.Int32& closeIndex)
  System.Int32 GetTagHashCode(System.String& text, System.Int32 index, System.Int32& closeIndex)
  System.Void FillCharacterVertexBuffers(System.Int32 i, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void FillSpriteVertexBuffers(System.Int32 i, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void AdjustLineOffset(System.Int32 startIndex, System.Int32 endIndex, System.Single offset, UnityEngine.TextCore.Text.TextInfo textInfo)
  System.Void ResizeLineExtents(System.Int32 size, UnityEngine.TextCore.Text.TextInfo textInfo)
  UnityEngine.TextCore.Text.FontStyles LegacyStyleToNewStyle(UnityEngine.FontStyle fontStyle)
  UnityEngine.TextCore.Text.TextAlignment LegacyAlignmentToNewAlignment(UnityEngine.TextAnchor anchor)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.PageInfo
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    firstCharacterIndex  // 0x10
  public            System.Int32                    lastCharacterIndex  // 0x14
  public            System.Single                   ascender  // 0x18
  public            System.Single                   baseLine  // 0x1C
  public            System.Single                   descender  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.WordInfo
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Int32                    firstCharacterIndex  // 0x10
  public            System.Int32                    lastCharacterIndex  // 0x14
  public            System.Int32                    characterCount  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextInfo
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  private   static  UnityEngine.Vector2             s_InfinityVectorPositive  // 0x0
  private   static  UnityEngine.Vector2             s_InfinityVectorNegative  // 0x8
  public            System.Int32                    characterCount  // 0x10
  public            System.Int32                    spriteCount  // 0x14
  public            System.Int32                    spaceCount  // 0x18
  public            System.Int32                    wordCount  // 0x1C
  public            System.Int32                    linkCount  // 0x20
  public            System.Int32                    lineCount  // 0x24
  public            System.Int32                    pageCount  // 0x28
  public            System.Int32                    materialCount  // 0x2C
  public            UnityEngine.TextCore.Text.TextElementInfo[]textElementInfo  // 0x30
  public            UnityEngine.TextCore.Text.WordInfo[]wordInfo  // 0x38
  public            UnityEngine.TextCore.Text.LinkInfo[]linkInfo  // 0x40
  public            UnityEngine.TextCore.Text.LineInfo[]lineInfo  // 0x48
  public            UnityEngine.TextCore.Text.PageInfo[]pageInfo  // 0x50
  public            UnityEngine.TextCore.Text.MeshInfo[]meshInfo  // 0x58
  public            System.Boolean                  isDirty  // 0x60
METHODS:
  System.Void .ctor()
  System.Void Clear()
  System.Void ClearMeshInfo(System.Boolean updateMesh)
  System.Void ClearLineInfo()
  System.Void Resize(T[]& array, System.Int32 size)
  System.Void Resize(T[]& array, System.Int32 size, System.Boolean isBlockAllocated)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.MarkupTag
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.MarkupTagBOLD  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_BOLD  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagITALIC  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_ITALIC  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagUNDERLINE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_UNDERLINE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSTRIKETHROUGH  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_STRIKETHROUGH  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMARK  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_MARK  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSUBSCRIPT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_SUBSCRIPT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSUPERSCRIPT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_SUPERSCRIPT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagCOLOR  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_COLOR  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagALPHA  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagA  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_A  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSIZE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_SIZE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSPRITE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagNO_BREAK  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_NO_BREAK  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSTYLE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_STYLE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagFONT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_FONT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_MATERIAL  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagLINK  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_LINK  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagFONT_WEIGHT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_FONT_WEIGHT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagNO_PARSE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_NO_PARSE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPOSITION  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_POSITION  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagVERTICAL_OFFSET  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_VERTICAL_OFFSET  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSPACE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_SPACE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPAGE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_PAGE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagALIGN  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_ALIGN  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagWIDTH  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_WIDTH  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagGRADIENT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_GRADIENT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagCHARACTER_SPACE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_CHARACTER_SPACE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMONOSPACE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_MONOSPACE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagCLASS  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagINDENT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_INDENT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagLINE_INDENT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_LINE_INDENT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMARGIN  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_MARGIN  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMARGIN_LEFT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMARGIN_RIGHT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagLINE_HEIGHT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_LINE_HEIGHT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagACTION  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_ACTION  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSCALE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_SCALE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagROTATE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_ROTATE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagLOWERCASE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_LOWERCASE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagALLCAPS  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_ALLCAPS  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagUPPERCASE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_UPPERCASE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSMALLCAPS  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_SMALLCAPS  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagLIGA  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_LIGA  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagFRAC  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSLASH_FRAC  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagNAME  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagINDEX  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagTINT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagANIM  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMATERIAL  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagHREF  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagANGLE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagRED  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagGREEN  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagBLUE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagYELLOW  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagORANGE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagBLACK  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagWHITE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPURPLE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagBR  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagZWSP  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagNBSP  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagSHY  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagLEFT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagRIGHT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagCENTER  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagJUSTIFIED  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagFLUSH  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagNONE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPLUS  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMINUS  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPX  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPLUS_PX  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMINUS_PX  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagEM  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPLUS_EM  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMINUS_EM  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPCT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPLUS_PCT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMINUS_PCT  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPERCENTAGE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagPLUS_PERCENTAGE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagMINUS_PERCENTAGE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagTRUE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagFALSE  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagINVALID  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagNORMAL  // 0x0
  public    static  UnityEngine.TextCore.Text.MarkupTagDEFAULT  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TagValueType
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.TagValueTypeNone  // 0x0
  public    static  UnityEngine.TextCore.Text.TagValueTypeNumericalValue  // 0x0
  public    static  UnityEngine.TextCore.Text.TagValueTypeStringValue  // 0x0
  public    static  UnityEngine.TextCore.Text.TagValueTypeColorValue  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.TagUnitType
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.Text.TagUnitTypePixels  // 0x0
  public    static  UnityEngine.TextCore.Text.TagUnitTypeFontUnits  // 0x0
  public    static  UnityEngine.TextCore.Text.TagUnitTypePercentage  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.Text.FontStyleStack
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Byte                     bold  // 0x10
  public            System.Byte                     italic  // 0x11
  public            System.Byte                     underline  // 0x12
  public            System.Byte                     strikethrough  // 0x13
  public            System.Byte                     highlight  // 0x14
  public            System.Byte                     superscript  // 0x15
  public            System.Byte                     subscript  // 0x16
  public            System.Byte                     uppercase  // 0x17
  public            System.Byte                     lowercase  // 0x18
  public            System.Byte                     smallcaps  // 0x19
METHODS:
  System.Void Clear()
  System.Byte Add(UnityEngine.TextCore.Text.FontStyles style)
  System.Byte Remove(UnityEngine.TextCore.Text.FontStyles style)
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextProcessingStack`1
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            T[]                             itemStack  // 0x0
  public            System.Int32                    index  // 0x0
  private           T                               m_DefaultItem  // 0x0
  private           System.Int32                    m_Capacity  // 0x0
  private           System.Int32                    m_RolloverSize  // 0x0
  private           System.Int32                    m_Count  // 0x0
METHODS:
  System.Void .ctor(T[] stack)
  System.Void .ctor(System.Int32 capacity)
  System.Void Clear()
  System.Void SetDefault(T item)
  System.Void Add(T item)
  T Remove()
  System.Void Push(T item)
  T Pop()
  T Peek()
  T CurrentItem()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextResourceManager
TYPE:  class
TOKEN: 0x2000033
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextResourceManager.FontAssetRef>s_FontAssetReferences  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset>s_FontAssetNameReferenceLookup  // 0x8
  private   static readonly System.Collections.Generic.Dictionary<System.Int64,UnityEngine.TextCore.Text.FontAsset>s_FontAssetFamilyNameAndStyleReferenceLookup  // 0x10
  private   static readonly System.Collections.Generic.List<System.Int32>s_FontAssetRemovalList  // 0x18
  private   static readonly System.Int32                    k_RegularStyleHashCode  // 0x20
METHODS:
  System.Void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextSettings
TYPE:  class
TOKEN: 0x2000035
EXTENDS: ScriptableObject
FIELDS:
  protected         System.String                   m_Version  // 0x18
  protected         UnityEngine.TextCore.Text.FontAssetm_DefaultFontAsset  // 0x20
  protected         System.String                   m_DefaultFontAssetPath  // 0x28
  protected         System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset>m_FallbackFontAssets  // 0x30
  protected         System.Boolean                  m_MatchMaterialPreset  // 0x38
  protected         System.Int32                    m_MissingCharacterUnicode  // 0x3C
  protected         System.Boolean                  m_ClearDynamicDataOnBuild  // 0x40
  protected         UnityEngine.TextCore.Text.SpriteAssetm_DefaultSpriteAsset  // 0x48
  protected         System.String                   m_DefaultSpriteAssetPath  // 0x50
  protected         System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset>m_FallbackSpriteAssets  // 0x58
  protected         System.UInt32                   m_MissingSpriteCharacterUnicode  // 0x60
  protected         UnityEngine.TextCore.Text.TextStyleSheetm_DefaultStyleSheet  // 0x68
  protected         System.String                   m_StyleSheetsResourcePath  // 0x70
  protected         System.String                   m_DefaultColorGradientPresetsPath  // 0x78
  protected         UnityEngine.TextCore.Text.UnicodeLineBreakingRulesm_UnicodeLineBreakingRules  // 0x80
  protected         System.Boolean                  m_DisplayWarnings  // 0x88
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset>m_FontLookup  // 0x90
  private           System.Collections.Generic.List<UnityEngine.TextCore.Text.TextSettings.FontReferenceMap>m_FontReferences  // 0x98
METHODS:
  System.String get_version()
  System.Void set_version(System.String value)
  UnityEngine.TextCore.Text.FontAsset get_defaultFontAsset()
  System.Void set_defaultFontAsset(UnityEngine.TextCore.Text.FontAsset value)
  System.String get_defaultFontAssetPath()
  System.Void set_defaultFontAssetPath(System.String value)
  System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssets()
  System.Void set_fallbackFontAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value)
  System.Boolean get_matchMaterialPreset()
  System.Void set_matchMaterialPreset(System.Boolean value)
  System.Int32 get_missingCharacterUnicode()
  System.Void set_missingCharacterUnicode(System.Int32 value)
  System.Boolean get_clearDynamicDataOnBuild()
  System.Void set_clearDynamicDataOnBuild(System.Boolean value)
  UnityEngine.TextCore.Text.SpriteAsset get_defaultSpriteAsset()
  System.Void set_defaultSpriteAsset(UnityEngine.TextCore.Text.SpriteAsset value)
  System.String get_defaultSpriteAssetPath()
  System.Void set_defaultSpriteAssetPath(System.String value)
  System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> get_fallbackSpriteAssets()
  System.Void set_fallbackSpriteAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> value)
  System.UInt32 get_missingSpriteCharacterUnicode()
  System.Void set_missingSpriteCharacterUnicode(System.UInt32 value)
  UnityEngine.TextCore.Text.TextStyleSheet get_defaultStyleSheet()
  System.Void set_defaultStyleSheet(UnityEngine.TextCore.Text.TextStyleSheet value)
  System.String get_styleSheetsResourcePath()
  System.Void set_styleSheetsResourcePath(System.String value)
  System.String get_defaultColorGradientPresetsPath()
  System.Void set_defaultColorGradientPresetsPath(System.String value)
  UnityEngine.TextCore.Text.UnicodeLineBreakingRules get_lineBreakingRules()
  System.Void set_lineBreakingRules(UnityEngine.TextCore.Text.UnicodeLineBreakingRules value)
  System.Boolean get_displayWarnings()
  System.Void set_displayWarnings(System.Boolean value)
  System.Void InitializeFontReferenceLookup()
  UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font font)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextShaderUtilities
TYPE:  class
TOKEN: 0x2000037
FIELDS:
  public    static  System.Int32                    ID_MainTex  // 0x0
  public    static  System.Int32                    ID_FaceTex  // 0x4
  public    static  System.Int32                    ID_FaceColor  // 0x8
  public    static  System.Int32                    ID_FaceDilate  // 0xC
  public    static  System.Int32                    ID_Shininess  // 0x10
  public    static  System.Int32                    ID_UnderlayColor  // 0x14
  public    static  System.Int32                    ID_UnderlayOffsetX  // 0x18
  public    static  System.Int32                    ID_UnderlayOffsetY  // 0x1C
  public    static  System.Int32                    ID_UnderlayDilate  // 0x20
  public    static  System.Int32                    ID_UnderlaySoftness  // 0x24
  public    static  System.Int32                    ID_WeightNormal  // 0x28
  public    static  System.Int32                    ID_WeightBold  // 0x2C
  public    static  System.Int32                    ID_OutlineTex  // 0x30
  public    static  System.Int32                    ID_OutlineWidth  // 0x34
  public    static  System.Int32                    ID_OutlineSoftness  // 0x38
  public    static  System.Int32                    ID_OutlineColor  // 0x3C
  public    static  System.Int32                    ID_Outline2Color  // 0x40
  public    static  System.Int32                    ID_Outline2Width  // 0x44
  public    static  System.Int32                    ID_Padding  // 0x48
  public    static  System.Int32                    ID_GradientScale  // 0x4C
  public    static  System.Int32                    ID_ScaleX  // 0x50
  public    static  System.Int32                    ID_ScaleY  // 0x54
  public    static  System.Int32                    ID_PerspectiveFilter  // 0x58
  public    static  System.Int32                    ID_Sharpness  // 0x5C
  public    static  System.Int32                    ID_TextureWidth  // 0x60
  public    static  System.Int32                    ID_TextureHeight  // 0x64
  public    static  System.Int32                    ID_BevelAmount  // 0x68
  public    static  System.Int32                    ID_GlowColor  // 0x6C
  public    static  System.Int32                    ID_GlowOffset  // 0x70
  public    static  System.Int32                    ID_GlowPower  // 0x74
  public    static  System.Int32                    ID_GlowOuter  // 0x78
  public    static  System.Int32                    ID_GlowInner  // 0x7C
  public    static  System.Int32                    ID_LightAngle  // 0x80
  public    static  System.Int32                    ID_EnvMap  // 0x84
  public    static  System.Int32                    ID_EnvMatrix  // 0x88
  public    static  System.Int32                    ID_EnvMatrixRotation  // 0x8C
  public    static  System.Int32                    ID_MaskCoord  // 0x90
  public    static  System.Int32                    ID_ClipRect  // 0x94
  public    static  System.Int32                    ID_MaskSoftnessX  // 0x98
  public    static  System.Int32                    ID_MaskSoftnessY  // 0x9C
  public    static  System.Int32                    ID_VertexOffsetX  // 0xA0
  public    static  System.Int32                    ID_VertexOffsetY  // 0xA4
  public    static  System.Int32                    ID_UseClipRect  // 0xA8
  public    static  System.Int32                    ID_StencilID  // 0xAC
  public    static  System.Int32                    ID_StencilOp  // 0xB0
  public    static  System.Int32                    ID_StencilComp  // 0xB4
  public    static  System.Int32                    ID_StencilReadMask  // 0xB8
  public    static  System.Int32                    ID_StencilWriteMask  // 0xBC
  public    static  System.Int32                    ID_ShaderFlags  // 0xC0
  public    static  System.Int32                    ID_ScaleRatio_A  // 0xC4
  public    static  System.Int32                    ID_ScaleRatio_B  // 0xC8
  public    static  System.Int32                    ID_ScaleRatio_C  // 0xCC
  public    static  System.String                   Keyword_Bevel  // 0xD0
  public    static  System.String                   Keyword_Glow  // 0xD8
  public    static  System.String                   Keyword_Underlay  // 0xE0
  public    static  System.String                   Keyword_Ratios  // 0xE8
  public    static  System.String                   Keyword_MASK_SOFT  // 0xF0
  public    static  System.String                   Keyword_MASK_HARD  // 0xF8
  public    static  System.String                   Keyword_MASK_TEX  // 0x100
  public    static  System.String                   Keyword_Outline  // 0x108
  public    static  System.String                   ShaderTag_ZTestMode  // 0x110
  public    static  System.String                   ShaderTag_CullMode  // 0x118
  private   static  System.Single                   m_clamp  // 0x120
  public    static  System.Boolean                  isInitialized  // 0x124
  private   static  UnityEngine.Shader              k_ShaderRef_MobileSDF  // 0x128
  private   static  UnityEngine.Shader              k_ShaderRef_MobileBitmap  // 0x130
METHODS:
  UnityEngine.Shader get_ShaderRef_MobileSDF()
  UnityEngine.Shader get_ShaderRef_MobileBitmap()
  System.Void .cctor()
  System.Void GetShaderPropertyIDs()
  System.Void UpdateShaderRatios(UnityEngine.Material mat)
  System.Boolean IsMaskingEnabled(UnityEngine.Material material)
  System.Single GetPadding(UnityEngine.Material material, System.Boolean enableExtraPadding, System.Boolean isBold)
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextStyle
TYPE:  class
TOKEN: 0x2000038
FIELDS:
  private   static  UnityEngine.TextCore.Text.TextStylek_NormalStyle  // 0x0
  private           System.String                   m_Name  // 0x10
  private           System.Int32                    m_HashCode  // 0x18
  private           System.String                   m_OpeningDefinition  // 0x20
  private           System.String                   m_ClosingDefinition  // 0x28
  private           System.Int32[]                  m_OpeningTagArray  // 0x30
  private           System.Int32[]                  m_ClosingTagArray  // 0x38
  private           System.UInt32[]                 m_OpeningTagUnicodeArray  // 0x40
  private           System.UInt32[]                 m_ClosingTagUnicodeArray  // 0x48
METHODS:
  System.Int32 get_hashCode()
  System.Int32[] get_styleOpeningTagArray()
  System.Int32[] get_styleClosingTagArray()
  System.Void RefreshStyle()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextStyleSheet
TYPE:  class
TOKEN: 0x2000039
EXTENDS: ScriptableObject
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle>m_StyleList  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextStyle>m_StyleLookupDictionary  // 0x20
METHODS:
  System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> get_styles()
  UnityEngine.TextCore.Text.TextStyle GetStyle(System.Int32 hashCode)
  UnityEngine.TextCore.Text.TextStyle GetStyle(System.String name)
  System.Void RefreshStyles()
  System.Void LoadStyleDictionaryInternal()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.Text.TextUtilities
TYPE:  class
TOKEN: 0x200003A
FIELDS:
METHODS:
  System.Char ToUpperFast(System.Char c)
  System.UInt32 ToUpperASCIIFast(System.UInt32 c)
  System.Int32 GetHashCodeCaseInSensitive(System.String s)
  System.String UintToString(System.Collections.Generic.List<System.UInt32> unicodes)
END_CLASS

CLASS: UnityEngine.TextCore.Text.UnicodeLineBreakingRules
TYPE:  class
TOKEN: 0x200003B
FIELDS:
  private   static  UnityEngine.TextCore.Text.UnicodeLineBreakingRuless_Instance  // 0x0
  private           UnityEngine.TextAsset           m_UnicodeLineBreakingRules  // 0x10
  private           UnityEngine.TextAsset           m_LeadingCharacters  // 0x18
  private           UnityEngine.TextAsset           m_FollowingCharacters  // 0x20
  private           System.Boolean                  m_UseModernHangulLineBreakingRules  // 0x28
  private   static  System.Collections.Generic.HashSet<System.UInt32>s_LeadingCharactersLookup  // 0x8
  private   static  System.Collections.Generic.HashSet<System.UInt32>s_FollowingCharactersLookup  // 0x10
METHODS:
  System.Collections.Generic.HashSet<System.UInt32> get_leadingCharactersLookup()
  System.Collections.Generic.HashSet<System.UInt32> get_followingCharactersLookup()
  System.Void LoadLineBreakingRules()
  System.Collections.Generic.HashSet<System.UInt32> GetCharacters(UnityEngine.TextAsset file)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

