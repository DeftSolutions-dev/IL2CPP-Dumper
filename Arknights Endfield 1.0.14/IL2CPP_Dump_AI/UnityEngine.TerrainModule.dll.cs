// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TerrainModule.dll
// Classes:  21
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: HeightmapChangedCallback
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, System.Boolean synched)
END_CLASS

CLASS: TextureChangedCallback
TYPE:  class
TOKEN: 0x2000007
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Terrain terrain, System.String textureName, UnityEngine.RectInt texelRegion, System.Boolean synched)
END_CLASS

CLASS: BoundaryValueType
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxHeightmapRes  // 0x0
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMinDetailResPerPatch  // 0x0
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxDetailResPerPatch  // 0x0
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxDetailPatchCount  // 0x0
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxDetailsPerRes  // 0x0
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMinAlphamapRes  // 0x0
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxAlphamapRes  // 0x0
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMinBaseMapRes  // 0x0
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxBaseMapRes  // 0x0
METHODS:
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Terrain
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Behaviour
FIELDS:
METHODS:
  UnityEngine.TerrainData get_terrainData()
  System.Void set_terrainData(UnityEngine.TerrainData value)
  System.Void set_detailObjectDistance(System.Single value)
  System.Void set_detailObjectDensity(System.Single value)
  System.Void set_lightmapIndex(System.Int32 value)
  System.Void set_lightmapScaleOffset(UnityEngine.Vector4 value)
  UnityEngine.Material get_materialTemplate()
  System.Void set_materialTemplate(UnityEngine.Material value)
  System.Boolean get_allowAutoConnect()
  System.Void set_allowAutoConnect(System.Boolean value)
  System.Int32 get_groupingID()
  System.Void set_drawInstanced(System.Boolean value)
  System.Void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom)
  System.Void Flush()
  UnityEngine.Terrain[] get_activeTerrains()
  System.Void GetActiveTerrains(System.Collections.Generic.List<UnityEngine.Terrain> terrainList)
  System.Void Internal_FillActiveTerrainList(System.Object terrainList)
  System.Void .ctor()
  System.Void set_lightmapScaleOffset_Injected(UnityEngine.Vector4& value)
END_CLASS

CLASS: UnityEngine.TerrainCallbacks
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static  UnityEngine.TerrainCallbacks.HeightmapChangedCallbackheightmapChanged  // 0x0
  private   static  UnityEngine.TerrainCallbacks.TextureChangedCallbacktextureChanged  // 0x8
METHODS:
  System.Void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, System.Boolean synched)
  System.Void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, System.String textureName, UnityEngine.RectInt texelRegion, System.Boolean synched)
END_CLASS

CLASS: UnityEngine.TreePrototype
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           UnityEngine.GameObject          m_Prefab  // 0x10
  private           System.Single                   m_BendFactor  // 0x18
  private           System.Int32                    m_NavMeshLod  // 0x1C
METHODS:
  UnityEngine.GameObject get_prefab()
  System.Void set_prefab(UnityEngine.GameObject value)
  System.Single get_bendFactor()
  System.Void set_bendFactor(System.Single value)
  System.Int32 get_navMeshLod()
  System.Void .ctor()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean Equals(UnityEngine.TreePrototype other)
END_CLASS

CLASS: UnityEngine.DetailRenderMode
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.DetailRenderMode    GrassBillboard  // 0x0
  public    static  UnityEngine.DetailRenderMode    VertexLit  // 0x0
  public    static  UnityEngine.DetailRenderMode    Grass  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.DetailPrototype
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static readonly UnityEngine.Color               DefaultHealthColor  // 0x0
  private   static readonly UnityEngine.Color               DefaultDryColor  // 0x10
  private           UnityEngine.GameObject          m_Prototype  // 0x10
  private           UnityEngine.Texture2D           m_PrototypeTexture  // 0x18
  private           UnityEngine.Color               m_HealthyColor  // 0x20
  private           UnityEngine.Color               m_DryColor  // 0x30
  private           System.Single                   m_MinWidth  // 0x40
  private           System.Single                   m_MaxWidth  // 0x44
  private           System.Single                   m_MinHeight  // 0x48
  private           System.Single                   m_MaxHeight  // 0x4C
  private           System.Int32                    m_NoiseSeed  // 0x50
  private           System.Single                   m_NoiseSpread  // 0x54
  private           System.Single                   m_HoleEdgePadding  // 0x58
  private           System.Int32                    m_RenderMode  // 0x5C
  private           System.Int32                    m_UsePrototypeMesh  // 0x60
  private           System.Int32                    m_UseInstancing  // 0x64
METHODS:
  UnityEngine.GameObject get_prototype()
  System.Void set_prototype(UnityEngine.GameObject value)
  UnityEngine.Texture2D get_prototypeTexture()
  System.Void set_prototypeTexture(UnityEngine.Texture2D value)
  System.Single get_minWidth()
  System.Void set_minWidth(System.Single value)
  System.Single get_maxWidth()
  System.Void set_maxWidth(System.Single value)
  System.Single get_minHeight()
  System.Void set_minHeight(System.Single value)
  System.Single get_maxHeight()
  System.Void set_maxHeight(System.Single value)
  System.Single get_noiseSpread()
  System.Void set_noiseSpread(System.Single value)
  UnityEngine.Color get_healthyColor()
  System.Void set_healthyColor(UnityEngine.Color value)
  UnityEngine.Color get_dryColor()
  System.Void set_dryColor(UnityEngine.Color value)
  UnityEngine.DetailRenderMode get_renderMode()
  System.Void set_renderMode(UnityEngine.DetailRenderMode value)
  System.Void set_usePrototypeMesh(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.DetailPrototype other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean Equals(UnityEngine.DetailPrototype other)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TreeInstance
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            System.Single                   widthScale  // 0x1C
  public            System.Single                   heightScale  // 0x20
  public            System.Single                   rotation  // 0x24
  public            UnityEngine.Color32             color  // 0x28
  public            UnityEngine.Color32             lightmapColor  // 0x2C
  public            System.Int32                    prototypeIndex  // 0x30
  private           System.Single                   temporaryDistance  // 0x34
METHODS:
END_CLASS

CLASS: UnityEngine.TerrainData
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private   static  System.String                   k_ScriptingInterfaceName  // 0x0
  private   static  System.String                   k_ScriptingInterfacePrefix  // 0x0
  private   static  System.String                   k_HeightmapPrefix  // 0x0
  private   static  System.String                   k_DetailDatabasePrefix  // 0x0
  private   static  System.String                   k_TreeDatabasePrefix  // 0x0
  private   static  System.String                   k_SplatDatabasePrefix  // 0x0
  private   static readonly System.Int32                    k_MaximumResolution  // 0x0
  private   static readonly System.Int32                    k_MinimumDetailResolutionPerPatch  // 0x4
  private   static readonly System.Int32                    k_MaximumDetailResolutionPerPatch  // 0x8
  private   static readonly System.Int32                    k_MaximumDetailPatchCount  // 0xC
  private   static readonly System.Int32                    k_MaximumDetailsPerRes  // 0x10
  private   static readonly System.Int32                    k_MinimumAlphamapResolution  // 0x14
  private   static readonly System.Int32                    k_MaximumAlphamapResolution  // 0x18
  private   static readonly System.Int32                    k_MinimumBaseMapResolution  // 0x1C
  private   static readonly System.Int32                    k_MaximumBaseMapResolution  // 0x20
METHODS:
  System.Int32 GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type)
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.TerrainData terrainData)
  UnityEngine.RenderTexture get_heightmapTexture()
  System.Int32 get_heightmapResolution()
  System.Void set_heightmapResolution(System.Int32 value)
  System.Int32 get_internalHeightmapResolution()
  System.Void set_internalHeightmapResolution(System.Int32 value)
  UnityEngine.Texture get_holesTexture()
  System.Boolean get_enableHolesTextureCompression()
  System.Void set_enableHolesTextureCompression(System.Boolean value)
  System.Boolean IsHolesTextureCompressed()
  UnityEngine.RenderTexture GetHolesTexture()
  UnityEngine.Texture2D GetCompressedHolesTexture()
  System.Int32 get_holesResolution()
  UnityEngine.Vector3 get_size()
  System.Void set_size(UnityEngine.Vector3 value)
  System.Single GetInterpolatedHeight(System.Single x, System.Single y)
  System.Single[,] GetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height)
  System.Single[,] Internal_GetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height)
  System.Void SetHeights(System.Int32 xBase, System.Int32 yBase, System.Single[,] heights)
  System.Void Internal_SetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height, System.Single[,] heights)
  System.Boolean[,] GetHoles(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height)
  System.Boolean[,] Internal_GetHoles(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height)
  UnityEngine.Vector3 GetInterpolatedNormal(System.Single x, System.Single y)
  System.Int32 get_detailWidth()
  System.Int32 get_detailHeight()
  System.Void SetDetailResolution(System.Int32 detailResolution, System.Int32 resolutionPerPatch)
  System.Void Internal_SetDetailResolution(System.Int32 patchCount, System.Int32 resolutionPerPatch)
  System.Int32 get_detailResolution()
  System.Int32 get_detailResolutionPerPatch()
  System.Void RefreshPrototypes()
  UnityEngine.DetailPrototype[] get_detailPrototypes()
  System.Void set_detailPrototypes(UnityEngine.DetailPrototype[] value)
  System.Int32[] GetSupportedLayers(System.Int32 xBase, System.Int32 yBase, System.Int32 totalWidth, System.Int32 totalHeight)
  System.Int32[,] GetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height, System.Int32 layer)
  System.Void SetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 layer, System.Int32[,] details)
  System.Void Internal_SetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 totalWidth, System.Int32 totalHeight, System.Int32 detailIndex, System.Int32[,] data)
  UnityEngine.TreeInstance[] get_treeInstances()
  UnityEngine.TreeInstance[] Internal_GetTreeInstances()
  System.Void SetTreeInstances(UnityEngine.TreeInstance[] instances, System.Boolean snapToHeightmap)
  UnityEngine.TreePrototype[] get_treePrototypes()
  System.Void set_treePrototypes(UnityEngine.TreePrototype[] value)
  System.Int32 get_alphamapLayers()
  System.Single[,,] GetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
  System.Single[,,] Internal_GetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
  System.Int32 get_alphamapResolution()
  System.Void set_alphamapResolution(System.Int32 value)
  System.Single GetAlphamapResolutionInternal()
  System.Int32 get_Internal_alphamapResolution()
  System.Void set_Internal_alphamapResolution(System.Int32 value)
  System.Int32 get_alphamapWidth()
  System.Int32 get_alphamapHeight()
  System.Int32 get_baseMapResolution()
  System.Int32 get_Internal_baseMapResolution()
  System.Void SetAlphamaps(System.Int32 x, System.Int32 y, System.Single[,,] map)
  System.Void Internal_SetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Single[,,] map)
  UnityEngine.Texture2D GetAlphamapTexture(System.Int32 index)
  System.Int32 get_alphamapTextureCount()
  UnityEngine.Texture2D[] get_alphamapTextures()
  UnityEngine.TerrainLayer[] get_terrainLayers()
  System.Void set_terrainLayers(UnityEngine.TerrainLayer[] value)
  UnityEngine.Terrain[] get_users()
  System.Void .cctor()
  System.Void get_size_Injected(UnityEngine.Vector3& ret)
  System.Void set_size_Injected(UnityEngine.Vector3& value)
  System.Void GetInterpolatedNormal_Injected(System.Single x, System.Single y, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.TerrainLayer
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.TerrainLayer layer)
  UnityEngine.Texture2D get_diffuseTexture()
  System.Void set_diffuseTexture(UnityEngine.Texture2D value)
  UnityEngine.Texture2D get_normalMapTexture()
  System.Void set_normalMapTexture(UnityEngine.Texture2D value)
  UnityEngine.Texture2D get_maskMapTexture()
  System.Void set_maskMapTexture(UnityEngine.Texture2D value)
  UnityEngine.Vector2 get_tileSize()
  System.Void set_tileSize(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_tileOffset()
  System.Void set_tileOffset(UnityEngine.Vector2 value)
  UnityEngine.Color get_specular()
  System.Void set_specular(UnityEngine.Color value)
  System.Single get_metallic()
  System.Void set_metallic(System.Single value)
  System.Single get_smoothness()
  System.Void set_smoothness(System.Single value)
  System.Single get_normalScale()
  System.Void set_normalScale(System.Single value)
  UnityEngine.Vector4 get_diffuseRemapMin()
  System.Void set_diffuseRemapMin(UnityEngine.Vector4 value)
  UnityEngine.Vector4 get_diffuseRemapMax()
  System.Void set_diffuseRemapMax(UnityEngine.Vector4 value)
  UnityEngine.Vector4 get_maskMapRemapMin()
  System.Void set_maskMapRemapMin(UnityEngine.Vector4 value)
  UnityEngine.Vector4 get_maskMapRemapMax()
  System.Void set_maskMapRemapMax(UnityEngine.Vector4 value)
  System.Void get_tileSize_Injected(UnityEngine.Vector2& ret)
  System.Void set_tileSize_Injected(UnityEngine.Vector2& value)
  System.Void get_tileOffset_Injected(UnityEngine.Vector2& ret)
  System.Void set_tileOffset_Injected(UnityEngine.Vector2& value)
  System.Void get_specular_Injected(UnityEngine.Color& ret)
  System.Void set_specular_Injected(UnityEngine.Color& value)
  System.Void get_diffuseRemapMin_Injected(UnityEngine.Vector4& ret)
  System.Void set_diffuseRemapMin_Injected(UnityEngine.Vector4& value)
  System.Void get_diffuseRemapMax_Injected(UnityEngine.Vector4& ret)
  System.Void set_diffuseRemapMax_Injected(UnityEngine.Vector4& value)
  System.Void get_maskMapRemapMin_Injected(UnityEngine.Vector4& ret)
  System.Void set_maskMapRemapMin_Injected(UnityEngine.Vector4& value)
  System.Void get_maskMapRemapMax_Injected(UnityEngine.Vector4& ret)
  System.Void set_maskMapRemapMax_Injected(UnityEngine.Vector4& value)
END_CLASS

CLASS: UnityEngine.TerrainUtils.TerrainMapStatusCode
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TerrainUtils.TerrainMapStatusCodeOK  // 0x0
  public    static  UnityEngine.TerrainUtils.TerrainMapStatusCodeOverlapping  // 0x0
  public    static  UnityEngine.TerrainUtils.TerrainMapStatusCodeSizeMismatch  // 0x0
  public    static  UnityEngine.TerrainUtils.TerrainMapStatusCodeEdgeAlignmentMismatch  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TerrainUtils.TerrainTileCoord
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public    readonly System.Int32                    tileX  // 0x10
  public    readonly System.Int32                    tileZ  // 0x14
METHODS:
  System.Void .ctor(System.Int32 tileX, System.Int32 tileZ)
END_CLASS

CLASS: UnityEngine.TerrainUtils.TerrainMap
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           UnityEngine.Vector3             m_patchSize  // 0x10
  private           UnityEngine.TerrainUtils.TerrainMapStatusCodem_errorCode  // 0x1C
  private           System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord,UnityEngine.Terrain>m_terrainTiles  // 0x20
METHODS:
  UnityEngine.Terrain GetTerrain(System.Int32 tileX, System.Int32 tileZ)
  UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter, System.Boolean fullValidation)
  UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, System.Predicate<UnityEngine.Terrain> filter, System.Boolean fullValidation)
  System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord,UnityEngine.Terrain> get_terrainTiles()
  System.Void .ctor()
  System.Void AddTerrainInternal(System.Int32 x, System.Int32 z, UnityEngine.Terrain terrain)
  System.Boolean TryToAddTerrain(System.Int32 tileX, System.Int32 tileZ, UnityEngine.Terrain terrain)
  System.Void ValidateTerrain(System.Int32 tileX, System.Int32 tileZ)
  UnityEngine.TerrainUtils.TerrainMapStatusCode Validate()
END_CLASS

CLASS: UnityEngine.TerrainUtils.TerrainUtility
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.Boolean ValidTerrainsExist()
  System.Void ClearConnectivity()
  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TerrainUtils.TerrainMap> CollectTerrains(System.Boolean onlyAutoConnectedTerrains)
  System.Void AutoConnect()
END_CLASS

