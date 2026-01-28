// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TerrainModule.dll
// Classes:  21
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000006
    public class HeightmapChangedCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, System.Boolean synched) { }

    }

    // TypeToken: 0x2000007
    public class TextureChangedCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Terrain terrain, System.String textureName, UnityEngine.RectInt texelRegion, System.Boolean synched) { }

    }

    // TypeToken: 0x200000D
    public struct BoundaryValueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TerrainData.BoundaryValueType MaxHeightmapRes;        // 0x0
        public static UnityEngine.TerrainData.BoundaryValueType MinDetailResPerPatch;        // 0x0
        public static UnityEngine.TerrainData.BoundaryValueType MaxDetailResPerPatch;        // 0x0
        public static UnityEngine.TerrainData.BoundaryValueType MaxDetailPatchCount;        // 0x0
        public static UnityEngine.TerrainData.BoundaryValueType MaxDetailsPerRes;        // 0x0
        public static UnityEngine.TerrainData.BoundaryValueType MinAlphamapRes;        // 0x0
        public static UnityEngine.TerrainData.BoundaryValueType MaxAlphamapRes;        // 0x0
        public static UnityEngine.TerrainData.BoundaryValueType MinBaseMapRes;        // 0x0
        public static UnityEngine.TerrainData.BoundaryValueType MaxBaseMapRes;        // 0x0

    }

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002
    public class EmbeddedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class IsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace UnityEngine
{

    // TypeToken: 0x2000004
    public class Terrain : Behaviour
    {
        // Methods
        private UnityEngine.TerrainData get_terrainData() { }
        private System.Void set_terrainData(UnityEngine.TerrainData value) { }
        private System.Void set_detailObjectDistance(System.Single value) { }
        private System.Void set_detailObjectDensity(System.Single value) { }
        private System.Void set_lightmapIndex(System.Int32 value) { }
        private System.Void set_lightmapScaleOffset(UnityEngine.Vector4 value) { }
        private UnityEngine.Material get_materialTemplate() { }
        private System.Void set_materialTemplate(UnityEngine.Material value) { }
        private System.Boolean get_allowAutoConnect() { }
        private System.Void set_allowAutoConnect(System.Boolean value) { }
        private System.Int32 get_groupingID() { }
        private System.Void set_drawInstanced(System.Boolean value) { }
        private System.Void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom) { }
        private System.Void Flush() { }
        private UnityEngine.Terrain[] get_activeTerrains() { }
        private System.Void GetActiveTerrains(System.Collections.Generic.List<UnityEngine.Terrain> terrainList) { }
        private System.Void Internal_FillActiveTerrainList(System.Object terrainList) { }
        private System.Void .ctor() { }
        private System.Void set_lightmapScaleOffset_Injected(UnityEngine.Vector4& value) { }

    }

    // TypeToken: 0x2000005
    public class TerrainCallbacks
    {
        // Fields
        private static UnityEngine.TerrainCallbacks.HeightmapChangedCallback heightmapChanged;        // 0x0
        private static UnityEngine.TerrainCallbacks.TextureChangedCallback textureChanged;        // 0x8

        // Methods
        private System.Void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, System.Boolean synched) { }
        private System.Void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, System.String textureName, UnityEngine.RectInt texelRegion, System.Boolean synched) { }

    }

    // TypeToken: 0x2000008
    public class TreePrototype
    {
        // Fields
        private UnityEngine.GameObject m_Prefab;        // 0x10
        private System.Single m_BendFactor;        // 0x18
        private System.Int32 m_NavMeshLod;        // 0x1C

        // Methods
        private UnityEngine.GameObject get_prefab() { }
        private System.Void set_prefab(UnityEngine.GameObject value) { }
        private System.Single get_bendFactor() { }
        private System.Void set_bendFactor(System.Single value) { }
        private System.Int32 get_navMeshLod() { }
        private System.Void .ctor() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(UnityEngine.TreePrototype other) { }

    }

    // TypeToken: 0x2000009
    public struct DetailRenderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.DetailRenderMode GrassBillboard;        // 0x0
        public static UnityEngine.DetailRenderMode VertexLit;        // 0x0
        public static UnityEngine.DetailRenderMode Grass;        // 0x0

    }

    // TypeToken: 0x200000A
    public class DetailPrototype
    {
        // Fields
        private static readonly UnityEngine.Color DefaultHealthColor;        // 0x0
        private static readonly UnityEngine.Color DefaultDryColor;        // 0x10
        private UnityEngine.GameObject m_Prototype;        // 0x10
        private UnityEngine.Texture2D m_PrototypeTexture;        // 0x18
        private UnityEngine.Color m_HealthyColor;        // 0x20
        private UnityEngine.Color m_DryColor;        // 0x30
        private System.Single m_MinWidth;        // 0x40
        private System.Single m_MaxWidth;        // 0x44
        private System.Single m_MinHeight;        // 0x48
        private System.Single m_MaxHeight;        // 0x4C
        private System.Int32 m_NoiseSeed;        // 0x50
        private System.Single m_NoiseSpread;        // 0x54
        private System.Single m_HoleEdgePadding;        // 0x58
        private System.Int32 m_RenderMode;        // 0x5C
        private System.Int32 m_UsePrototypeMesh;        // 0x60
        private System.Int32 m_UseInstancing;        // 0x64

        // Methods
        private UnityEngine.GameObject get_prototype() { }
        private System.Void set_prototype(UnityEngine.GameObject value) { }
        private UnityEngine.Texture2D get_prototypeTexture() { }
        private System.Void set_prototypeTexture(UnityEngine.Texture2D value) { }
        private System.Single get_minWidth() { }
        private System.Void set_minWidth(System.Single value) { }
        private System.Single get_maxWidth() { }
        private System.Void set_maxWidth(System.Single value) { }
        private System.Single get_minHeight() { }
        private System.Void set_minHeight(System.Single value) { }
        private System.Single get_maxHeight() { }
        private System.Void set_maxHeight(System.Single value) { }
        private System.Single get_noiseSpread() { }
        private System.Void set_noiseSpread(System.Single value) { }
        private UnityEngine.Color get_healthyColor() { }
        private System.Void set_healthyColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_dryColor() { }
        private System.Void set_dryColor(UnityEngine.Color value) { }
        private UnityEngine.DetailRenderMode get_renderMode() { }
        private System.Void set_renderMode(UnityEngine.DetailRenderMode value) { }
        private System.Void set_usePrototypeMesh(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.DetailPrototype other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(UnityEngine.DetailPrototype other) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000B
    public struct TreeInstance
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public System.Single widthScale;        // 0x1C
        public System.Single heightScale;        // 0x20
        public System.Single rotation;        // 0x24
        public UnityEngine.Color32 color;        // 0x28
        public UnityEngine.Color32 lightmapColor;        // 0x2C
        public System.Int32 prototypeIndex;        // 0x30
        private System.Single temporaryDistance;        // 0x34

    }

    // TypeToken: 0x200000C
    public class TerrainData
    {
        // Fields
        private static System.String k_ScriptingInterfaceName;        // 0x0
        private static System.String k_ScriptingInterfacePrefix;        // 0x0
        private static System.String k_HeightmapPrefix;        // 0x0
        private static System.String k_DetailDatabasePrefix;        // 0x0
        private static System.String k_TreeDatabasePrefix;        // 0x0
        private static System.String k_SplatDatabasePrefix;        // 0x0
        private static readonly System.Int32 k_MaximumResolution;        // 0x0
        private static readonly System.Int32 k_MinimumDetailResolutionPerPatch;        // 0x4
        private static readonly System.Int32 k_MaximumDetailResolutionPerPatch;        // 0x8
        private static readonly System.Int32 k_MaximumDetailPatchCount;        // 0xC
        private static readonly System.Int32 k_MaximumDetailsPerRes;        // 0x10
        private static readonly System.Int32 k_MinimumAlphamapResolution;        // 0x14
        private static readonly System.Int32 k_MaximumAlphamapResolution;        // 0x18
        private static readonly System.Int32 k_MinimumBaseMapResolution;        // 0x1C
        private static readonly System.Int32 k_MaximumBaseMapResolution;        // 0x20

        // Methods
        private System.Int32 GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type) { }
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.TerrainData terrainData) { }
        private UnityEngine.RenderTexture get_heightmapTexture() { }
        private System.Int32 get_heightmapResolution() { }
        private System.Void set_heightmapResolution(System.Int32 value) { }
        private System.Int32 get_internalHeightmapResolution() { }
        private System.Void set_internalHeightmapResolution(System.Int32 value) { }
        private UnityEngine.Texture get_holesTexture() { }
        private System.Boolean get_enableHolesTextureCompression() { }
        private System.Void set_enableHolesTextureCompression(System.Boolean value) { }
        private System.Boolean IsHolesTextureCompressed() { }
        private UnityEngine.RenderTexture GetHolesTexture() { }
        private UnityEngine.Texture2D GetCompressedHolesTexture() { }
        private System.Int32 get_holesResolution() { }
        private UnityEngine.Vector3 get_size() { }
        private System.Void set_size(UnityEngine.Vector3 value) { }
        private System.Single GetInterpolatedHeight(System.Single x, System.Single y) { }
        private System.Single[,] GetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height) { }
        private System.Single[,] Internal_GetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height) { }
        private System.Void SetHeights(System.Int32 xBase, System.Int32 yBase, System.Single[,] heights) { }
        private System.Void Internal_SetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height, System.Single[,] heights) { }
        private System.Boolean[,] GetHoles(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height) { }
        private System.Boolean[,] Internal_GetHoles(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height) { }
        private UnityEngine.Vector3 GetInterpolatedNormal(System.Single x, System.Single y) { }
        private System.Int32 get_detailWidth() { }
        private System.Int32 get_detailHeight() { }
        private System.Void SetDetailResolution(System.Int32 detailResolution, System.Int32 resolutionPerPatch) { }
        private System.Void Internal_SetDetailResolution(System.Int32 patchCount, System.Int32 resolutionPerPatch) { }
        private System.Int32 get_detailResolution() { }
        private System.Int32 get_detailResolutionPerPatch() { }
        private System.Void RefreshPrototypes() { }
        private UnityEngine.DetailPrototype[] get_detailPrototypes() { }
        private System.Void set_detailPrototypes(UnityEngine.DetailPrototype[] value) { }
        private System.Int32[] GetSupportedLayers(System.Int32 xBase, System.Int32 yBase, System.Int32 totalWidth, System.Int32 totalHeight) { }
        private System.Int32[,] GetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height, System.Int32 layer) { }
        private System.Void SetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 layer, System.Int32[,] details) { }
        private System.Void Internal_SetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 totalWidth, System.Int32 totalHeight, System.Int32 detailIndex, System.Int32[,] data) { }
        private UnityEngine.TreeInstance[] get_treeInstances() { }
        private UnityEngine.TreeInstance[] Internal_GetTreeInstances() { }
        private System.Void SetTreeInstances(UnityEngine.TreeInstance[] instances, System.Boolean snapToHeightmap) { }
        private UnityEngine.TreePrototype[] get_treePrototypes() { }
        private System.Void set_treePrototypes(UnityEngine.TreePrototype[] value) { }
        private System.Int32 get_alphamapLayers() { }
        private System.Single[,,] GetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height) { }
        private System.Single[,,] Internal_GetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height) { }
        private System.Int32 get_alphamapResolution() { }
        private System.Void set_alphamapResolution(System.Int32 value) { }
        private System.Single GetAlphamapResolutionInternal() { }
        private System.Int32 get_Internal_alphamapResolution() { }
        private System.Void set_Internal_alphamapResolution(System.Int32 value) { }
        private System.Int32 get_alphamapWidth() { }
        private System.Int32 get_alphamapHeight() { }
        private System.Int32 get_baseMapResolution() { }
        private System.Int32 get_Internal_baseMapResolution() { }
        private System.Void SetAlphamaps(System.Int32 x, System.Int32 y, System.Single[,,] map) { }
        private System.Void Internal_SetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Single[,,] map) { }
        private UnityEngine.Texture2D GetAlphamapTexture(System.Int32 index) { }
        private System.Int32 get_alphamapTextureCount() { }
        private UnityEngine.Texture2D[] get_alphamapTextures() { }
        private UnityEngine.TerrainLayer[] get_terrainLayers() { }
        private System.Void set_terrainLayers(UnityEngine.TerrainLayer[] value) { }
        private UnityEngine.Terrain[] get_users() { }
        private System.Void .cctor() { }
        private System.Void get_size_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_size_Injected(UnityEngine.Vector3& value) { }
        private System.Void GetInterpolatedNormal_Injected(System.Single x, System.Single y, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x200000E
    public class TerrainLayer
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.TerrainLayer layer) { }
        private UnityEngine.Texture2D get_diffuseTexture() { }
        private System.Void set_diffuseTexture(UnityEngine.Texture2D value) { }
        private UnityEngine.Texture2D get_normalMapTexture() { }
        private System.Void set_normalMapTexture(UnityEngine.Texture2D value) { }
        private UnityEngine.Texture2D get_maskMapTexture() { }
        private System.Void set_maskMapTexture(UnityEngine.Texture2D value) { }
        private UnityEngine.Vector2 get_tileSize() { }
        private System.Void set_tileSize(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_tileOffset() { }
        private System.Void set_tileOffset(UnityEngine.Vector2 value) { }
        private UnityEngine.Color get_specular() { }
        private System.Void set_specular(UnityEngine.Color value) { }
        private System.Single get_metallic() { }
        private System.Void set_metallic(System.Single value) { }
        private System.Single get_smoothness() { }
        private System.Void set_smoothness(System.Single value) { }
        private System.Single get_normalScale() { }
        private System.Void set_normalScale(System.Single value) { }
        private UnityEngine.Vector4 get_diffuseRemapMin() { }
        private System.Void set_diffuseRemapMin(UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 get_diffuseRemapMax() { }
        private System.Void set_diffuseRemapMax(UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 get_maskMapRemapMin() { }
        private System.Void set_maskMapRemapMin(UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 get_maskMapRemapMax() { }
        private System.Void set_maskMapRemapMax(UnityEngine.Vector4 value) { }
        private System.Void get_tileSize_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_tileSize_Injected(UnityEngine.Vector2& value) { }
        private System.Void get_tileOffset_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_tileOffset_Injected(UnityEngine.Vector2& value) { }
        private System.Void get_specular_Injected(UnityEngine.Color& ret) { }
        private System.Void set_specular_Injected(UnityEngine.Color& value) { }
        private System.Void get_diffuseRemapMin_Injected(UnityEngine.Vector4& ret) { }
        private System.Void set_diffuseRemapMin_Injected(UnityEngine.Vector4& value) { }
        private System.Void get_diffuseRemapMax_Injected(UnityEngine.Vector4& ret) { }
        private System.Void set_diffuseRemapMax_Injected(UnityEngine.Vector4& value) { }
        private System.Void get_maskMapRemapMin_Injected(UnityEngine.Vector4& ret) { }
        private System.Void set_maskMapRemapMin_Injected(UnityEngine.Vector4& value) { }
        private System.Void get_maskMapRemapMax_Injected(UnityEngine.Vector4& ret) { }
        private System.Void set_maskMapRemapMax_Injected(UnityEngine.Vector4& value) { }

    }

}

namespace UnityEngine.TerrainUtils
{

    // TypeToken: 0x200000F
    public struct TerrainMapStatusCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TerrainUtils.TerrainMapStatusCode OK;        // 0x0
        public static UnityEngine.TerrainUtils.TerrainMapStatusCode Overlapping;        // 0x0
        public static UnityEngine.TerrainUtils.TerrainMapStatusCode SizeMismatch;        // 0x0
        public static UnityEngine.TerrainUtils.TerrainMapStatusCode EdgeAlignmentMismatch;        // 0x0

    }

    // TypeToken: 0x2000010
    public struct TerrainTileCoord
    {
        // Fields
        public readonly System.Int32 tileX;        // 0x10
        public readonly System.Int32 tileZ;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 tileX, System.Int32 tileZ) { }

    }

    // TypeToken: 0x2000011
    public class TerrainMap
    {
        // Fields
        private UnityEngine.Vector3 m_patchSize;        // 0x10
        private UnityEngine.TerrainUtils.TerrainMapStatusCode m_errorCode;        // 0x1C
        private System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord,UnityEngine.Terrain> m_terrainTiles;        // 0x20

        // Methods
        private UnityEngine.Terrain GetTerrain(System.Int32 tileX, System.Int32 tileZ) { }
        private UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter, System.Boolean fullValidation) { }
        private UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, System.Predicate<UnityEngine.Terrain> filter, System.Boolean fullValidation) { }
        private System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord,UnityEngine.Terrain> get_terrainTiles() { }
        private System.Void .ctor() { }
        private System.Void AddTerrainInternal(System.Int32 x, System.Int32 z, UnityEngine.Terrain terrain) { }
        private System.Boolean TryToAddTerrain(System.Int32 tileX, System.Int32 tileZ, UnityEngine.Terrain terrain) { }
        private System.Void ValidateTerrain(System.Int32 tileX, System.Int32 tileZ) { }
        private UnityEngine.TerrainUtils.TerrainMapStatusCode Validate() { }

    }

    // TypeToken: 0x2000013
    public class TerrainUtility
    {
        // Methods
        private System.Boolean ValidTerrainsExist() { }
        private System.Void ClearConnectivity() { }
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TerrainUtils.TerrainMap> CollectTerrains(System.Boolean onlyAutoConnectedTerrains) { }
        private System.Void AutoConnect() { }

    }

}

