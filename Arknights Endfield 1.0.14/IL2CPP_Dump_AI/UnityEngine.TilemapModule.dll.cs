// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TilemapModule.dll
// Classes:  12
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: ColliderType
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Tilemaps.Tile.ColliderTypeNone  // 0x0
  public    static  UnityEngine.Tilemaps.Tile.ColliderTypeSprite  // 0x0
  public    static  UnityEngine.Tilemaps.Tile.ColliderTypeGrid  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Tilemaps.ITilemap
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  UnityEngine.Tilemaps.ITilemap   s_Instance  // 0x0
  private           UnityEngine.Tilemaps.Tilemap    m_Tilemap  // 0x10
  private           System.Boolean                  m_AddToList  // 0x18
  private           System.Int32                    m_RefreshCount  // 0x1C
  private           Unity.Collections.NativeArray<UnityEngine.Vector3Int>m_RefreshPos  // 0x20
METHODS:
  System.Void .ctor()
  System.Void RefreshTile(UnityEngine.Vector3Int position)
  UnityEngine.Tilemaps.ITilemap CreateInstance()
  System.Void FindAllRefreshPositions(UnityEngine.Tilemaps.ITilemap tilemap, System.Int32 count, System.IntPtr oldTilesIntPtr, System.IntPtr newTilesIntPtr, System.IntPtr positionsIntPtr)
  System.Void GetAllTileData(UnityEngine.Tilemaps.ITilemap tilemap, System.Int32 count, System.IntPtr tilesIntPtr, System.IntPtr positionsIntPtr, System.IntPtr outTileDataIntPtr)
END_CLASS

CLASS: UnityEngine.Tilemaps.Tile
TYPE:  class
TOKEN: 0x2000003
EXTENDS: TileBase
FIELDS:
  private           UnityEngine.Sprite              m_Sprite  // 0x18
  private           UnityEngine.Color               m_Color  // 0x20
  private           UnityEngine.Matrix4x4           m_Transform  // 0x30
  private           UnityEngine.GameObject          m_InstancedGameObject  // 0x70
  private           UnityEngine.Tilemaps.TileFlags  m_Flags  // 0x78
  private           UnityEngine.Tilemaps.Tile.ColliderTypem_ColliderType  // 0x7C
METHODS:
  UnityEngine.Sprite get_sprite()
  System.Void set_sprite(UnityEngine.Sprite value)
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  UnityEngine.Matrix4x4 get_transform()
  System.Void set_transform(UnityEngine.Matrix4x4 value)
  UnityEngine.GameObject get_gameObject()
  System.Void set_gameObject(UnityEngine.GameObject value)
  UnityEngine.Tilemaps.TileFlags get_flags()
  System.Void set_flags(UnityEngine.Tilemaps.TileFlags value)
  UnityEngine.Tilemaps.Tile.ColliderType get_colliderType()
  System.Void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value)
  System.Void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileData& tileData)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Tilemaps.TileBase
TYPE:  class
TOKEN: 0x2000005
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  System.Void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap)
  System.Void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileData& tileData)
  UnityEngine.Tilemaps.TileData GetTileDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap)
  System.Boolean GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileAnimationData& tileAnimationData)
  UnityEngine.Tilemaps.TileAnimationData GetTileAnimationDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap)
  System.Void GetTileAnimationDataRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileAnimationData& tileAnimationData, System.Boolean& hasAnimation)
  System.Boolean StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go)
  System.Void StartUpRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go, System.Boolean& startUpInvokedByUser)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Tilemaps.Tilemap
TYPE:  class
TOKEN: 0x2000006
EXTENDS: GridLayout
FIELDS:
METHODS:
  UnityEngine.Grid get_layoutGrid()
  UnityEngine.BoundsInt get_cellBounds()
  UnityEngine.Vector3Int get_origin()
  UnityEngine.Vector3Int get_size()
  UnityEngine.Vector3 get_tileAnchor()
  UnityEngine.Matrix4x4 get_orientationMatrix()
  UnityEngine.Object GetTileAsset(UnityEngine.Vector3Int position)
  T GetTile(UnityEngine.Vector3Int position)
  UnityEngine.Object[] GetTileAssetsBlock(UnityEngine.Vector3Int position, UnityEngine.Vector3Int blockDimensions)
  UnityEngine.Tilemaps.TileBase[] GetTilesBlock(UnityEngine.BoundsInt bounds)
  System.Boolean HasTile(UnityEngine.Vector3Int position)
  System.Void RefreshTile(UnityEngine.Vector3Int position)
  System.Void RefreshTilesNative(System.Void* positions, System.Int32 count)
  System.Int32 GetUsedTilesCount()
  System.Int32 GetUsedTilesNonAlloc(UnityEngine.Tilemaps.TileBase[] usedTiles)
  System.Int32 Internal_GetUsedTilesNonAlloc(UnityEngine.Object[] usedTiles)
  System.Void get_origin_Injected(UnityEngine.Vector3Int& ret)
  System.Void get_size_Injected(UnityEngine.Vector3Int& ret)
  System.Void get_tileAnchor_Injected(UnityEngine.Vector3& ret)
  System.Void get_orientationMatrix_Injected(UnityEngine.Matrix4x4& ret)
  UnityEngine.Object GetTileAsset_Injected(UnityEngine.Vector3Int& position)
  UnityEngine.Object[] GetTileAssetsBlock_Injected(UnityEngine.Vector3Int& position, UnityEngine.Vector3Int& blockDimensions)
  System.Void RefreshTile_Injected(UnityEngine.Vector3Int& position)
END_CLASS

CLASS: UnityEngine.Tilemaps.TileFlags
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Tilemaps.TileFlags  None  // 0x0
  public    static  UnityEngine.Tilemaps.TileFlags  LockColor  // 0x0
  public    static  UnityEngine.Tilemaps.TileFlags  LockTransform  // 0x0
  public    static  UnityEngine.Tilemaps.TileFlags  InstantiateGameObjectRuntimeOnly  // 0x0
  public    static  UnityEngine.Tilemaps.TileFlags  KeepGameObjectRuntimeOnly  // 0x0
  public    static  UnityEngine.Tilemaps.TileFlags  LockAll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Tilemaps.TilemapRenderer
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Renderer
FIELDS:
METHODS:
  System.Void RegisterSpriteAtlasRegistered()
  System.Void UnregisterSpriteAtlasRegistered()
  System.Void OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas atlas)
END_CLASS

CLASS: UnityEngine.Tilemaps.TileData
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  private           System.Int32                    m_Sprite  // 0x10
  private           UnityEngine.Color               m_Color  // 0x14
  private           UnityEngine.Matrix4x4           m_Transform  // 0x24
  private           System.Int32                    m_GameObject  // 0x64
  private           UnityEngine.Tilemaps.TileFlags  m_Flags  // 0x68
  private           UnityEngine.Tilemaps.Tile.ColliderTypem_ColliderType  // 0x6C
  private   static readonly UnityEngine.Tilemaps.TileData   Default  // 0x0
METHODS:
  System.Void set_sprite(UnityEngine.Sprite value)
  System.Void set_color(UnityEngine.Color value)
  System.Void set_transform(UnityEngine.Matrix4x4 value)
  System.Void set_gameObject(UnityEngine.GameObject value)
  System.Void set_flags(UnityEngine.Tilemaps.TileFlags value)
  System.Void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value)
  UnityEngine.Tilemaps.TileData CreateDefault()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Tilemaps.TileDataNative
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  private           System.Int32                    m_Sprite  // 0x10
  private           UnityEngine.Color               m_Color  // 0x14
  private           UnityEngine.Matrix4x4           m_Transform  // 0x24
  private           System.Int32                    m_GameObject  // 0x64
  private           UnityEngine.Tilemaps.TileFlags  m_Flags  // 0x68
  private           UnityEngine.Tilemaps.Tile.ColliderTypem_ColliderType  // 0x6C
METHODS:
END_CLASS

CLASS: UnityEngine.Tilemaps.TileChangeData
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  private           UnityEngine.Vector3Int          m_Position  // 0x10
  private           UnityEngine.Object              m_TileAsset  // 0x20
  private           UnityEngine.Color               m_Color  // 0x28
  private           UnityEngine.Matrix4x4           m_Transform  // 0x38
METHODS:
END_CLASS

CLASS: UnityEngine.Tilemaps.TileAnimationData
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  private           UnityEngine.Sprite[]            m_AnimatedSprites  // 0x10
  private           System.Single                   m_AnimationSpeed  // 0x18
  private           System.Single                   m_AnimationStartTime  // 0x1C
METHODS:
END_CLASS

