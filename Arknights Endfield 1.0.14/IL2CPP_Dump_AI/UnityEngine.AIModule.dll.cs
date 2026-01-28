// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AIModule.dll
// Classes:  30
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: OnNavMeshPreUpdate
TYPE:  class
TOKEN: 0x2000012
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: OnUnloadFinishDelegate
TYPE:  class
TOKEN: 0x2000013
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.UInt64 surfTileID)
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

CLASS: UnityEngine.AI.NavMeshPathStatus
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.NavMeshPathStatusPathComplete  // 0x0
  public    static  UnityEngine.AI.NavMeshPathStatusPathPartial  // 0x0
  public    static  UnityEngine.AI.NavMeshPathStatusPathInvalid  // 0x0
  public    static  UnityEngine.AI.NavMeshPathStatusPathProcessing  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshPath
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           UnityEngine.Vector3[]           m_Corners  // 0x18
  private           System.Int32[]                  m_Areas  // 0x20
  private           UnityEngine.Vector3[]           m_DividingPos  // 0x28
METHODS:
  System.Void .ctor()
  System.Void Finalize()
  System.IntPtr InitializeNavMeshPath()
  System.Void DestroyNavMeshPath(System.IntPtr ptr)
  System.Int32 GetCornersNonAlloc(UnityEngine.Vector3[] corners, System.Int32[] areas, UnityEngine.Vector3[] dividingPos)
  System.Int32 GetPolyCount()
  UnityEngine.Vector3[] CalculateCornersInternal()
  System.Void ClearCornersInternal()
  System.Void ClearCorners()
  System.Void CalculateCorners()
  UnityEngine.Vector3[] get_corners()
  UnityEngine.AI.NavMeshPathStatus get_status()
  System.Boolean get_needRepath()
  System.Void set_needRepath(System.Boolean value)
  System.Void set_calcAutoRepath(System.Boolean value)
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuilder
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.Void CollectSources(UnityEngine.Bounds includedWorldBounds, System.Int32 includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
  System.Void CollectSources(UnityEngine.Transform root, System.Int32 includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
  UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal(System.Int32 includedLayerMask, UnityEngine.Bounds includedWorldBounds, UnityEngine.Transform root, System.Boolean useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups)
  System.Void CollectSourcesV2(UnityEngine.Bounds includedWorldBounds, System.Int32 includedLayerMask, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
  UnityEngine.AI.NavMeshBuildSource[] CollectSourcesV2Internal(System.Int32 includedLayerMask, UnityEngine.Bounds includedWorldBounds, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups)
  UnityEngine.AI.NavMeshData BuildNavMeshData(UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useSubJob)
  System.Boolean UpdateNavMeshData(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob)
  System.Boolean UpdateNavMeshDataListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Object sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob)
  UnityEngine.AsyncOperation UpdateNavMeshDataAsync(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob)
  UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Object sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob)
  UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal_Injected(System.Int32 includedLayerMask, UnityEngine.Bounds& includedWorldBounds, UnityEngine.Transform root, System.Boolean useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups)
  UnityEngine.AI.NavMeshBuildSource[] CollectSourcesV2Internal_Injected(System.Int32 includedLayerMask, UnityEngine.Bounds& includedWorldBounds, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups)
  System.Boolean UpdateNavMeshDataListInternal_Injected(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings& buildSettings, System.Object sources, UnityEngine.Bounds& localBounds, System.Boolean useSubJob)
  UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings& buildSettings, System.Object sources, UnityEngine.Bounds& localBounds, System.Boolean useSubJob)
END_CLASS

CLASS: UnityEngine.AI.HGNavMeshAgent
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Behaviour
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshAgent
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Behaviour
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshObstacleShape
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.NavMeshObstacleShapeCapsule  // 0x0
  public    static  UnityEngine.AI.NavMeshObstacleShapeBox  // 0x0
  public    static  UnityEngine.AI.NavMeshObstacleShapePolygon  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshObstacle
TYPE:  class
TOKEN: 0x200000A
EXTENDS: Behaviour
FIELDS:
METHODS:
  System.Single get_height()
  System.Void set_height(System.Single value)
  System.Single get_radius()
  System.Void set_radius(System.Single value)
  System.Void set_carving(System.Boolean value)
  System.Void set_carveOnlyStationary(System.Boolean value)
  System.Void set_shape(UnityEngine.AI.NavMeshObstacleShape value)
  UnityEngine.Vector3 get_center()
  System.Void set_center(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_size()
  System.Void set_size(UnityEngine.Vector3 value)
  System.Void set_ignoredSurfaceID(System.Int32 value)
  System.Void get_center_Injected(UnityEngine.Vector3& ret)
  System.Void set_center_Injected(UnityEngine.Vector3& value)
  System.Void get_size_Injected(UnityEngine.Vector3& ret)
  System.Void set_size_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.AI.NavMeshHit
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  private           UnityEngine.Vector3             m_Position  // 0x10
  private           UnityEngine.Vector3             m_Normal  // 0x1C
  private           System.Single                   m_Distance  // 0x28
  private           System.Int32                    m_Mask  // 0x2C
  private           System.Int32                    m_Hit  // 0x30
METHODS:
  UnityEngine.Vector3 get_position()
  UnityEngine.Vector3 get_normal()
  System.Boolean get_hit()
END_CLASS

CLASS: UnityEngine.AI.QueryPolygonInfo
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Single                   distance  // 0x10
  public            System.UInt64                   polyRef  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshData
TYPE:  class
TOKEN: 0x200000D
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 agentTypeID)
  System.Void Internal_Create(UnityEngine.AI.NavMeshData mono, System.Int32 agentTypeID)
  UnityEngine.Bounds get_sourceBounds()
  System.Void set_position(UnityEngine.Vector3 value)
  System.Void set_rotation(UnityEngine.Quaternion value)
  System.Void AppendExtOffMeshLink(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single width, System.Boolean bidirectional, System.Int32 area, System.Single costModifier)
  System.Void Internal_AppendExtOffMeshLink(UnityEngine.Vector3 startLeft, UnityEngine.Vector3 startRight, UnityEngine.Vector3 endRight, UnityEngine.Vector3 endLeft, System.Boolean bidirectional, System.Int32 area, System.Single costModifier)
  System.Void get_sourceBounds_Injected(UnityEngine.Bounds& ret)
  System.Void set_position_Injected(UnityEngine.Vector3& value)
  System.Void set_rotation_Injected(UnityEngine.Quaternion& value)
  System.Void Internal_AppendExtOffMeshLink_Injected(UnityEngine.Vector3& startLeft, UnityEngine.Vector3& startRight, UnityEngine.Vector3& endRight, UnityEngine.Vector3& endLeft, System.Boolean bidirectional, System.Int32 area, System.Single costModifier)
END_CLASS

CLASS: UnityEngine.AI.NavMeshDataInstance
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  private           System.Int32                    <id>k__BackingField  // 0x10
METHODS:
  System.Boolean get_valid()
  System.Int32 get_id()
  System.Void set_id(System.Int32 value)
  System.Int32 get_handleId()
  System.Void set_handleId(System.Int32 value)
  System.Void Remove()
  System.Void set_owner(UnityEngine.Object value)
END_CLASS

CLASS: UnityEngine.AI.NavMeshLinkData
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  private           System.Boolean                  m_IsExt  // 0x10
  private           UnityEngine.Vector3             m_StartLeft  // 0x14
  private           UnityEngine.Vector3             m_StartRight  // 0x20
  private           UnityEngine.Vector3             m_EndRight  // 0x2C
  private           UnityEngine.Vector3             m_EndLeft  // 0x38
  private           System.Single                   m_CostModifier  // 0x44
  private           System.Int32                    m_Bidirectional  // 0x48
  private           System.Int32                    m_Area  // 0x4C
  private           System.Int32                    m_AgentTypeID  // 0x50
METHODS:
  System.Boolean get_isExt()
  System.Void set_isExt(System.Boolean value)
  UnityEngine.Vector3 get_startLeft()
  System.Void set_startLeft(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_startRight()
  System.Void set_startRight(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_endRight()
  System.Void set_endRight(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_endLeft()
  System.Void set_endLeft(UnityEngine.Vector3 value)
  System.Single get_costModifier()
  System.Void set_costModifier(System.Single value)
  System.Boolean get_bidirectional()
  System.Void set_bidirectional(System.Boolean value)
  System.Int32 get_area()
  System.Void set_area(System.Int32 value)
  System.Int32 get_agentTypeID()
  System.Void set_agentTypeID(System.Int32 value)
END_CLASS

CLASS: UnityEngine.AI.NavMeshLinkInstance
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  private           System.Int32                    <id>k__BackingField  // 0x10
METHODS:
  System.Boolean get_valid()
  System.Int32 get_id()
  System.Void set_id(System.Int32 value)
  System.Void Remove()
  System.Void set_owner(UnityEngine.Object value)
END_CLASS

CLASS: UnityEngine.AI.NavMesh
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  public    static  UnityEngine.AI.NavMesh.OnNavMeshPreUpdateonPreUpdate  // 0x0
  public    static  UnityEngine.AI.NavMesh.OnUnloadFinishDelegateonUnloadFinish  // 0x8
METHODS:
  System.Void Internal_CallOnNavMeshPreUpdate()
  System.Boolean Raycast(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
  System.Boolean CalculatePath(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  System.Boolean CalculatePathInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  System.Boolean FindClosestEdge(UnityEngine.Vector3 sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
  System.Boolean SamplePosition(UnityEngine.Vector3 sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Single maxDistance, System.Int32 areaMask)
  System.Int32 GetAreaFromName(System.String areaName)
  UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData)
  UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void UpdateSurfaceTransform(UnityEngine.AI.NavMeshDataInstance handle, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void RemoveNavMeshData(UnityEngine.AI.NavMeshDataInstance handle)
  System.Boolean IsValidNavMeshDataHandle(System.Int32 handle)
  System.Boolean IsValidLinkHandle(System.Int32 handle)
  System.Boolean InternalSetOwner(System.Int32 dataID, System.Int32 ownerID)
  System.Boolean InternalSetLinkOwner(System.Int32 linkID, System.Int32 ownerID)
  System.Int32 AddNavMeshDataInternal(UnityEngine.AI.NavMeshData navMeshData)
  System.Int32 AddNavMeshDataTransformedInternal(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void RemoveNavMeshDataInternal(System.Int32 handle)
  UnityEngine.AI.NavMeshLinkInstance AddLink(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void RemoveLink(UnityEngine.AI.NavMeshLinkInstance handle)
  System.Int32 AddLinkInternal(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void RemoveLinkInternal(System.Int32 handle)
  UnityEngine.AI.NavMeshBuildSettings GetSettingsByID(System.Int32 agentTypeID)
  UnityEngine.AI.NavMeshBuildSettings GetSettingsByIndex(System.Int32 index)
  System.Void UpdateSurfaceTransformInternal(System.Int32 surfaceID, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Boolean DetachFromSurface(System.Int32 chunkSurfaceId, System.Int32 builderSurfaceId, System.Int32 indexX, System.Int32 indexZ)
  System.Boolean SetBuilderSurfaceParams(System.Int32 surfID, System.Single chunkSize, System.Single tileSize, System.Single centerX, System.Single centerZ, System.Single sizeX, System.Single sizeZ)
  System.Boolean Internal_DetachFromSurface(System.Int32 chunkSurfaceId, System.Int32 builderSurfaceId, System.Int32 indexX, System.Int32 indexZ)
  System.Boolean Internal_SetBuilderSurfaceParams(System.Int32 surfID, System.Single chunkSize, System.Single tileSize, System.Single centerX, System.Single centerZ, System.Single sizeX, System.Single sizeZ)
  System.Boolean VerticalQueryNearestPolygons(UnityEngine.Vector3 start, System.Single height, UnityEngine.AI.QueryPolygonInfo& nearestPoly, System.Int32 agentTypeID, System.Int32 areaMask)
  System.Boolean VerticalQueryNearestPolygons(UnityEngine.Vector3 start, System.Single height, UnityEngine.AI.QueryPolygonInfo& nearestPoly)
  System.Boolean Internal_VerticalQueryNearestPolygons(UnityEngine.Vector3 start, System.Single height, UnityEngine.AI.QueryPolygonInfo& nearestPoly, System.Int32 agentTypeID, System.UInt32 areaMask)
  System.Int32 LoadDynamicBakeTile(UnityEngine.AI.NavMeshData navMeshData)
  System.Void UnloadDynamicBakeTile(System.Int32 dynamicTileID)
  System.Int32 Internal_LoadDynamicBakeTile(UnityEngine.AI.NavMeshData navMeshData)
  System.Void Internal_UnloadDynamicBakeTile(System.Int32 dynamicTileID)
  System.Int32 ModifyVolumeArea(System.Collections.Generic.List<UnityEngine.Vector3> center, System.Collections.Generic.List<UnityEngine.Vector3> ext, System.Collections.Generic.List<UnityEngine.Quaternion> rotation, System.Int32 area)
  System.Int32 ModifyBoxAreaInternal(System.Collections.Generic.List<UnityEngine.Vector3> center, System.Collections.Generic.List<UnityEngine.Vector3> ext, System.Collections.Generic.List<UnityEngine.Quaternion> rotation, System.Int32 area)
  System.Int32 ModifyVolumeArea(UnityEngine.Vector3[] center, UnityEngine.Vector3[] ext, UnityEngine.Quaternion[] rotation, System.Int32 area)
  System.Int32 ModifyBoxArrayAreaInternal(UnityEngine.Vector3[] center, UnityEngine.Vector3[] ext, UnityEngine.Quaternion[] rotation, System.Int32 area)
  System.Int32 ModifyVolumeArea(System.Collections.Generic.List<UnityEngine.Vector3> verts, System.Single hMin, System.Single hMax, System.Int32 area)
  System.Int32 ModifyPolygonAreaInternal(System.Collections.Generic.List<UnityEngine.Vector3> verts, System.Single hMin, System.Single hMax, System.Int32 area)
  System.Void LoadExtOffMeshLinks(System.Int32 surfaceID)
  System.Void Internal_LoadExtOffMeshLinks(System.Int32 surfaceID)
  UnityEngine.AsyncOperation AddNavMeshDataAsync(System.Int32& surfaceID, UnityEngine.AI.NavMeshData navMeshData, System.UInt64 surfTileID)
  UnityEngine.AsyncOperation AddNavMeshDataAsyncInternal(System.Int32& surfaceID, UnityEngine.AI.NavMeshData navMeshData, System.UInt64 surfTileID)
  System.Void CancelAsyncAdd(System.UInt64 surfTileID)
  System.Void Internal_CancelAsyncAdd(System.UInt64 surfaceID)
  System.Void UnloadDataAsync(System.Int32 surfaceID, System.UInt64 surfTileID)
  System.Void Internal_UnloadDataAsync(System.Int32 surfaceID, System.UInt64 surfTileID)
  System.Void Internal_InvokeOnUnloadFinish(System.UInt64 surfTileID)
  System.Boolean IsSurfaceUnloading(System.UInt64 surfTileID)
  System.Boolean Internal_IsSurfaceUnloading(System.UInt64 surfTileID)
  System.Void ForceClearUnloadDataRequest()
  System.Void Internal_ForceClearUnloadDataRequest()
  System.Void CalculatePathAsync(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  System.Void CalculatePathAsyncInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  System.Void SetFindPathMaxIterPerFrame(System.Int32 maxIterPerFrame)
  System.Void Internal_SetFindPathMaxIterPerFrame(System.Int32 maxIterPerFrame)
  System.Void CancelAsyncCalculatePath(UnityEngine.AI.NavMeshPath path)
  System.Void Internal_CancelAsyncCalculatePath(UnityEngine.AI.NavMeshPath path)
  System.Void RegisterAutoRepath(UnityEngine.AI.NavMeshPath path)
  System.Void Internal_RegisterAutoRepath(UnityEngine.AI.NavMeshPath path)
  System.Void UnregisterAutoRepath(UnityEngine.AI.NavMeshPath path)
  System.Void Internal_UnregisterAutoRepath(UnityEngine.AI.NavMeshPath path)
  System.Boolean Raycast_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
  System.Boolean CalculatePathInternal_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  System.Boolean FindClosestEdge_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
  System.Boolean SamplePosition_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Single maxDistance, System.Int32 areaMask)
  System.Int32 AddNavMeshDataTransformedInternal_Injected(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Int32 AddLinkInternal_Injected(UnityEngine.AI.NavMeshLinkData& link, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Void GetSettingsByID_Injected(System.Int32 agentTypeID, UnityEngine.AI.NavMeshBuildSettings& ret)
  System.Void GetSettingsByIndex_Injected(System.Int32 index, UnityEngine.AI.NavMeshBuildSettings& ret)
  System.Void UpdateSurfaceTransformInternal_Injected(System.Int32 surfaceID, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Boolean Internal_VerticalQueryNearestPolygons_Injected(UnityEngine.Vector3& start, System.Single height, UnityEngine.AI.QueryPolygonInfo& nearestPoly, System.Int32 agentTypeID, System.UInt32 areaMask)
  System.Void CalculatePathAsyncInternal_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildSourceShape
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeMesh  // 0x0
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeTerrain  // 0x0
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeBox  // 0x0
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeSphere  // 0x0
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeCapsule  // 0x0
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeModifierBox  // 0x0
  public    static  UnityEngine.AI.NavMeshBuildSourceShapePhysicsTriangleMesh  // 0x0
  public    static  UnityEngine.AI.NavMeshBuildSourceShapePhysicsConvexMesh  // 0x0
  public    static  UnityEngine.AI.NavMeshBuildSourceShapePhysicsTerrain  // 0x0
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeModifierPoly  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshCollectGeometry
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.NavMeshCollectGeometryRenderMeshes  // 0x0
  public    static  UnityEngine.AI.NavMeshCollectGeometryPhysicsColliders  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildSource
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  private           UnityEngine.Matrix4x4           m_Transform  // 0x10
  private           UnityEngine.Vector3             m_Size  // 0x50
  private           UnityEngine.AI.NavMeshBuildSourceShapem_Shape  // 0x5C
  private           System.Int32                    m_Area  // 0x60
  private           System.Int32                    m_InstanceID  // 0x64
  private           System.Int32                    m_ComponentID  // 0x68
  private           System.Boolean                  m_IsConvex  // 0x6C
  private           System.IntPtr                   m_EcsShape  // 0x70
  public            System.Collections.Generic.List<UnityEngine.Vector3>convexVerts  // 0x78
  public            System.Single                   convexHmin  // 0x80
  public            System.Single                   convexHmax  // 0x84
METHODS:
  UnityEngine.Matrix4x4 get_transform()
  System.Void set_transform(UnityEngine.Matrix4x4 value)
  UnityEngine.Vector3 get_size()
  System.Void set_size(UnityEngine.Vector3 value)
  UnityEngine.AI.NavMeshBuildSourceShape get_shape()
  System.Void set_shape(UnityEngine.AI.NavMeshBuildSourceShape value)
  System.Int32 get_area()
  System.Void set_area(System.Int32 value)
  UnityEngine.Object get_sourceObject()
  UnityEngine.Component get_component()
  UnityEngine.Component InternalGetComponent(System.Int32 instanceID)
  UnityEngine.Object InternalGetObject(System.Int32 instanceID)
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildMarkup
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  private           System.Int32                    m_OverrideArea  // 0x10
  private           System.Int32                    m_Area  // 0x14
  private           System.Int32                    m_IgnoreFromBuild  // 0x18
  private           System.Int32                    m_InstanceID  // 0x1C
METHODS:
  System.Void set_overrideArea(System.Boolean value)
  System.Void set_area(System.Int32 value)
  System.Void set_ignoreFromBuild(System.Boolean value)
  System.Void set_root(UnityEngine.Transform value)
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildSettings
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  private           System.Int32                    m_AgentTypeID  // 0x10
  private           System.Single                   m_AgentRadius  // 0x14
  private           System.Single                   m_AgentHeight  // 0x18
  private           System.Single                   m_AgentSlope  // 0x1C
  private           System.Single                   m_AgentClimb  // 0x20
  private           System.Single                   m_LedgeDropHeight  // 0x24
  private           System.Single                   m_MaxJumpAcrossDistance  // 0x28
  private           System.Single                   m_MinRegionArea  // 0x2C
  private           System.Int32                    m_OverrideVoxelSize  // 0x30
  private           System.Single                   m_VoxelSize  // 0x34
  private           System.Int32                    m_OverrideTileSize  // 0x38
  private           System.Int32                    m_TileSize  // 0x3C
  private           System.Int32                    m_AccuratePlacement  // 0x40
  private           System.UInt32                   m_MaxJobWorkers  // 0x44
  private           System.Int32                    m_PreserveTilesOutsideBounds  // 0x48
  private           System.Int32                    m_PartitioningMethod  // 0x4C
  private           System.Int32                    m_FilterLowHangingObstacles  // 0x50
  private           System.Int32                    m_FilterLedgeSpans  // 0x54
  private           System.Int32                    m_FilterWalkableLowHeightSpans  // 0x58
  private           System.Int32                    m_erodeAgainstWallSpans  // 0x5C
  private           System.Int32                    m_cliffIndent  // 0x60
  private           System.Int32                    m_DynamicNavmeshSurfaceType  // 0x64
  private           UnityEngine.AI.NavMeshBuildDebugSettingsm_Debug  // 0x68
METHODS:
  System.Int32 get_agentTypeID()
  System.Void set_agentTypeID(System.Int32 value)
  System.Single get_agentRadius()
  System.Single get_agentHeight()
  System.Single get_agentClimb()
  System.Void set_minRegionArea(System.Single value)
  System.Void set_overrideVoxelSize(System.Boolean value)
  System.Void set_voxelSize(System.Single value)
  System.Void set_overrideTileSize(System.Boolean value)
  System.Void set_tileSize(System.Int32 value)
  System.Void set_partitioningMethod(System.Int32 value)
  System.Void set_filterLowHangingObstacles(System.Boolean value)
  System.Void set_filterLedgeSpans(System.Boolean value)
  System.Void set_filterWalkableLowHeightSpans(System.Boolean value)
  System.Void set_erodeAgainstWallSpans(System.Boolean value)
  System.Void set_cliffIndent(System.Int32 value)
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildDebugSettings
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  private           System.Byte                     m_Flags  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.AI.PolygonId
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  private           System.UInt64                   polyRef  // 0x10
METHODS:
  System.Boolean IsNull()
  System.Boolean op_Equality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y)
  System.Boolean op_Inequality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y)
  System.Int32 GetHashCode()
  System.Boolean Equals(UnityEngine.Experimental.AI.PolygonId rhs)
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: UnityEngine.Experimental.AI.NavMeshLocation
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  private   readonly UnityEngine.Experimental.AI.PolygonId<polygon>k__BackingField  // 0x10
  private   readonly UnityEngine.Vector3             <position>k__BackingField  // 0x18
METHODS:
  UnityEngine.Experimental.AI.PolygonId get_polygon()
  UnityEngine.Vector3 get_position()
END_CLASS

CLASS: UnityEngine.Experimental.AI.PathQueryStatus
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.AI.PathQueryStatusFailure  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusSuccess  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusInProgress  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusStatusDetailMask  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusWrongMagic  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusWrongVersion  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusOutOfMemory  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusInvalidParam  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusBufferTooSmall  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusOutOfNodes  // 0x0
  public    static  UnityEngine.Experimental.AI.PathQueryStatusPartialResult  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.AI.NavMeshWorld
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  private           System.IntPtr                   world  // 0x10
METHODS:
  UnityEngine.Experimental.AI.NavMeshWorld GetDefaultWorld()
  System.Void GetDefaultWorld_Injected(UnityEngine.Experimental.AI.NavMeshWorld& ret)
END_CLASS

CLASS: UnityEngine.Experimental.AI.NavMeshQuery
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  private           System.IntPtr                   m_NavMeshQuery  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Experimental.AI.NavMeshWorld world, Unity.Collections.Allocator allocator, System.Int32 pathNodePoolSize)
  System.Void Dispose()
  System.IntPtr Create(UnityEngine.Experimental.AI.NavMeshWorld world, System.Int32 nodePoolSize)
  System.Void Destroy(System.IntPtr navMeshQuery)
  UnityEngine.Experimental.AI.NavMeshLocation MapLocation(System.IntPtr navMeshQuery, UnityEngine.Vector3 position, UnityEngine.Vector3 extents, System.Int32 agentTypeID, System.Int32 areaMask)
  UnityEngine.Experimental.AI.NavMeshLocation MapLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 extents, System.Int32 agentTypeID, System.Int32 areaMask)
  UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, System.Int32 areaMask)
  UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, System.Int32 areaMask)
  UnityEngine.Experimental.AI.PathQueryStatus Raycast(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, System.Void* costs, UnityEngine.AI.NavMeshHit& hit, System.Void* path, System.Int32& pathCount, System.Int32 maxPath)
  UnityEngine.Experimental.AI.PathQueryStatus Raycast(UnityEngine.AI.NavMeshHit& hit, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, Unity.Collections.NativeArray<System.Single> costs)
  System.IntPtr Create_Injected(UnityEngine.Experimental.AI.NavMeshWorld& world, System.Int32 nodePoolSize)
  System.Void MapLocation_Injected(System.IntPtr navMeshQuery, UnityEngine.Vector3& position, UnityEngine.Vector3& extents, System.Int32 agentTypeID, System.Int32 areaMask, UnityEngine.Experimental.AI.NavMeshLocation& ret)
  System.Void MoveLocation_Injected(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation& location, UnityEngine.Vector3& target, System.Int32 areaMask, UnityEngine.Experimental.AI.NavMeshLocation& ret)
  UnityEngine.Experimental.AI.PathQueryStatus Raycast_Injected(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation& start, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, System.Void* costs, UnityEngine.AI.NavMeshHit& hit, System.Void* path, System.Int32& pathCount, System.Int32 maxPath)
END_CLASS

