// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TilemapModule.dll
// Classes:  12
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000004
    public struct ColliderType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Tilemaps.Tile.ColliderType None;        // 0x0
        public static UnityEngine.Tilemaps.Tile.ColliderType Sprite;        // 0x0
        public static UnityEngine.Tilemaps.Tile.ColliderType Grid;        // 0x0

    }

namespace UnityEngine.Tilemaps
{

    // TypeToken: 0x2000002
    public class ITilemap
    {
        // Fields
        private static UnityEngine.Tilemaps.ITilemap s_Instance;        // 0x0
        private UnityEngine.Tilemaps.Tilemap m_Tilemap;        // 0x10
        private System.Boolean m_AddToList;        // 0x18
        private System.Int32 m_RefreshCount;        // 0x1C
        private Unity.Collections.NativeArray<UnityEngine.Vector3Int> m_RefreshPos;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void RefreshTile(UnityEngine.Vector3Int position) { }
        private UnityEngine.Tilemaps.ITilemap CreateInstance() { }
        private System.Void FindAllRefreshPositions(UnityEngine.Tilemaps.ITilemap tilemap, System.Int32 count, System.IntPtr oldTilesIntPtr, System.IntPtr newTilesIntPtr, System.IntPtr positionsIntPtr) { }
        private System.Void GetAllTileData(UnityEngine.Tilemaps.ITilemap tilemap, System.Int32 count, System.IntPtr tilesIntPtr, System.IntPtr positionsIntPtr, System.IntPtr outTileDataIntPtr) { }

    }

    // TypeToken: 0x2000003
    public class Tile : TileBase
    {
        // Fields
        private UnityEngine.Sprite m_Sprite;        // 0x18
        private UnityEngine.Color m_Color;        // 0x20
        private UnityEngine.Matrix4x4 m_Transform;        // 0x30
        private UnityEngine.GameObject m_InstancedGameObject;        // 0x70
        private UnityEngine.Tilemaps.TileFlags m_Flags;        // 0x78
        private UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;        // 0x7C

        // Methods
        private UnityEngine.Sprite get_sprite() { }
        private System.Void set_sprite(UnityEngine.Sprite value) { }
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private UnityEngine.Matrix4x4 get_transform() { }
        private System.Void set_transform(UnityEngine.Matrix4x4 value) { }
        private UnityEngine.GameObject get_gameObject() { }
        private System.Void set_gameObject(UnityEngine.GameObject value) { }
        private UnityEngine.Tilemaps.TileFlags get_flags() { }
        private System.Void set_flags(UnityEngine.Tilemaps.TileFlags value) { }
        private UnityEngine.Tilemaps.Tile.ColliderType get_colliderType() { }
        private System.Void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value) { }
        private System.Void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileData& tileData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class TileBase : ScriptableObject
    {
        // Methods
        private System.Void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap) { }
        private System.Void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileData& tileData) { }
        private UnityEngine.Tilemaps.TileData GetTileDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap) { }
        private System.Boolean GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileAnimationData& tileAnimationData) { }
        private UnityEngine.Tilemaps.TileAnimationData GetTileAnimationDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap) { }
        private System.Void GetTileAnimationDataRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileAnimationData& tileAnimationData, System.Boolean& hasAnimation) { }
        private System.Boolean StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go) { }
        private System.Void StartUpRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go, System.Boolean& startUpInvokedByUser) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class Tilemap : GridLayout
    {
        // Methods
        private UnityEngine.Grid get_layoutGrid() { }
        private UnityEngine.BoundsInt get_cellBounds() { }
        private UnityEngine.Vector3Int get_origin() { }
        private UnityEngine.Vector3Int get_size() { }
        private UnityEngine.Vector3 get_tileAnchor() { }
        private UnityEngine.Matrix4x4 get_orientationMatrix() { }
        private UnityEngine.Object GetTileAsset(UnityEngine.Vector3Int position) { }
        private T GetTile(UnityEngine.Vector3Int position) { }
        private UnityEngine.Object[] GetTileAssetsBlock(UnityEngine.Vector3Int position, UnityEngine.Vector3Int blockDimensions) { }
        private UnityEngine.Tilemaps.TileBase[] GetTilesBlock(UnityEngine.BoundsInt bounds) { }
        private System.Boolean HasTile(UnityEngine.Vector3Int position) { }
        private System.Void RefreshTile(UnityEngine.Vector3Int position) { }
        private System.Void RefreshTilesNative(System.Void* positions, System.Int32 count) { }
        private System.Int32 GetUsedTilesCount() { }
        private System.Int32 GetUsedTilesNonAlloc(UnityEngine.Tilemaps.TileBase[] usedTiles) { }
        private System.Int32 Internal_GetUsedTilesNonAlloc(UnityEngine.Object[] usedTiles) { }
        private System.Void get_origin_Injected(UnityEngine.Vector3Int& ret) { }
        private System.Void get_size_Injected(UnityEngine.Vector3Int& ret) { }
        private System.Void get_tileAnchor_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_orientationMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private UnityEngine.Object GetTileAsset_Injected(UnityEngine.Vector3Int& position) { }
        private UnityEngine.Object[] GetTileAssetsBlock_Injected(UnityEngine.Vector3Int& position, UnityEngine.Vector3Int& blockDimensions) { }
        private System.Void RefreshTile_Injected(UnityEngine.Vector3Int& position) { }

    }

    // TypeToken: 0x2000007
    public struct TileFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Tilemaps.TileFlags None;        // 0x0
        public static UnityEngine.Tilemaps.TileFlags LockColor;        // 0x0
        public static UnityEngine.Tilemaps.TileFlags LockTransform;        // 0x0
        public static UnityEngine.Tilemaps.TileFlags InstantiateGameObjectRuntimeOnly;        // 0x0
        public static UnityEngine.Tilemaps.TileFlags KeepGameObjectRuntimeOnly;        // 0x0
        public static UnityEngine.Tilemaps.TileFlags LockAll;        // 0x0

    }

    // TypeToken: 0x2000008
    public class TilemapRenderer : Renderer
    {
        // Methods
        private System.Void RegisterSpriteAtlasRegistered() { }
        private System.Void UnregisterSpriteAtlasRegistered() { }
        private System.Void OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas atlas) { }

    }

    // TypeToken: 0x2000009
    public struct TileData
    {
        // Fields
        private System.Int32 m_Sprite;        // 0x10
        private UnityEngine.Color m_Color;        // 0x14
        private UnityEngine.Matrix4x4 m_Transform;        // 0x24
        private System.Int32 m_GameObject;        // 0x64
        private UnityEngine.Tilemaps.TileFlags m_Flags;        // 0x68
        private UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;        // 0x6C
        private static readonly UnityEngine.Tilemaps.TileData Default;        // 0x0

        // Methods
        private System.Void set_sprite(UnityEngine.Sprite value) { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Void set_transform(UnityEngine.Matrix4x4 value) { }
        private System.Void set_gameObject(UnityEngine.GameObject value) { }
        private System.Void set_flags(UnityEngine.Tilemaps.TileFlags value) { }
        private System.Void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value) { }
        private UnityEngine.Tilemaps.TileData CreateDefault() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public struct TileDataNative
    {
        // Fields
        private System.Int32 m_Sprite;        // 0x10
        private UnityEngine.Color m_Color;        // 0x14
        private UnityEngine.Matrix4x4 m_Transform;        // 0x24
        private System.Int32 m_GameObject;        // 0x64
        private UnityEngine.Tilemaps.TileFlags m_Flags;        // 0x68
        private UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;        // 0x6C

    }

    // TypeToken: 0x200000B
    public struct TileChangeData
    {
        // Fields
        private UnityEngine.Vector3Int m_Position;        // 0x10
        private UnityEngine.Object m_TileAsset;        // 0x20
        private UnityEngine.Color m_Color;        // 0x28
        private UnityEngine.Matrix4x4 m_Transform;        // 0x38

    }

    // TypeToken: 0x200000C
    public struct TileAnimationData
    {
        // Fields
        private UnityEngine.Sprite[] m_AnimatedSprites;        // 0x10
        private System.Single m_AnimationSpeed;        // 0x18
        private System.Single m_AnimationStartTime;        // 0x1C

    }

}

