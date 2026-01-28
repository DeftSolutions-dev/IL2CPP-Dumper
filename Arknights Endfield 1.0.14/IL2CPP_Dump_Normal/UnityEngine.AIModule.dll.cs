// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AIModule.dll
// Classes:  30
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000012
    public class OnNavMeshPreUpdate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000013
    public class OnUnloadFinishDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.UInt64 surfTileID) { }

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

namespace UnityEngine.AI
{

    // TypeToken: 0x2000004
    public struct NavMeshPathStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AI.NavMeshPathStatus PathComplete;        // 0x0
        public static UnityEngine.AI.NavMeshPathStatus PathPartial;        // 0x0
        public static UnityEngine.AI.NavMeshPathStatus PathInvalid;        // 0x0
        public static UnityEngine.AI.NavMeshPathStatus PathProcessing;        // 0x0

    }

    // TypeToken: 0x2000005
    public class NavMeshPath
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private UnityEngine.Vector3[] m_Corners;        // 0x18
        private System.Int32[] m_Areas;        // 0x20
        private UnityEngine.Vector3[] m_DividingPos;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.IntPtr InitializeNavMeshPath() { }
        private System.Void DestroyNavMeshPath(System.IntPtr ptr) { }
        private System.Int32 GetCornersNonAlloc(UnityEngine.Vector3[] corners, System.Int32[] areas, UnityEngine.Vector3[] dividingPos) { }
        private System.Int32 GetPolyCount() { }
        private UnityEngine.Vector3[] CalculateCornersInternal() { }
        private System.Void ClearCornersInternal() { }
        private System.Void ClearCorners() { }
        private System.Void CalculateCorners() { }
        private UnityEngine.Vector3[] get_corners() { }
        private UnityEngine.AI.NavMeshPathStatus get_status() { }
        private System.Boolean get_needRepath() { }
        private System.Void set_needRepath(System.Boolean value) { }
        private System.Void set_calcAutoRepath(System.Boolean value) { }

    }

    // TypeToken: 0x2000006
    public class NavMeshBuilder
    {
        // Methods
        private System.Void CollectSources(UnityEngine.Bounds includedWorldBounds, System.Int32 includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results) { }
        private System.Void CollectSources(UnityEngine.Transform root, System.Int32 includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results) { }
        private UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal(System.Int32 includedLayerMask, UnityEngine.Bounds includedWorldBounds, UnityEngine.Transform root, System.Boolean useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups) { }
        private System.Void CollectSourcesV2(UnityEngine.Bounds includedWorldBounds, System.Int32 includedLayerMask, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results) { }
        private UnityEngine.AI.NavMeshBuildSource[] CollectSourcesV2Internal(System.Int32 includedLayerMask, UnityEngine.Bounds includedWorldBounds, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups) { }
        private UnityEngine.AI.NavMeshData BuildNavMeshData(UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useSubJob) { }
        private System.Boolean UpdateNavMeshData(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob) { }
        private System.Boolean UpdateNavMeshDataListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Object sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob) { }
        private UnityEngine.AsyncOperation UpdateNavMeshDataAsync(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob) { }
        private UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Object sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob) { }
        private UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal_Injected(System.Int32 includedLayerMask, UnityEngine.Bounds& includedWorldBounds, UnityEngine.Transform root, System.Boolean useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups) { }
        private UnityEngine.AI.NavMeshBuildSource[] CollectSourcesV2Internal_Injected(System.Int32 includedLayerMask, UnityEngine.Bounds& includedWorldBounds, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups) { }
        private System.Boolean UpdateNavMeshDataListInternal_Injected(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings& buildSettings, System.Object sources, UnityEngine.Bounds& localBounds, System.Boolean useSubJob) { }
        private UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings& buildSettings, System.Object sources, UnityEngine.Bounds& localBounds, System.Boolean useSubJob) { }

    }

    // TypeToken: 0x2000007
    public class HGNavMeshAgent : Behaviour
    {
    }

    // TypeToken: 0x2000008
    public class NavMeshAgent : Behaviour
    {
    }

    // TypeToken: 0x2000009
    public struct NavMeshObstacleShape
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AI.NavMeshObstacleShape Capsule;        // 0x0
        public static UnityEngine.AI.NavMeshObstacleShape Box;        // 0x0
        public static UnityEngine.AI.NavMeshObstacleShape Polygon;        // 0x0

    }

    // TypeToken: 0x200000A
    public class NavMeshObstacle : Behaviour
    {
        // Methods
        private System.Single get_height() { }
        private System.Void set_height(System.Single value) { }
        private System.Single get_radius() { }
        private System.Void set_radius(System.Single value) { }
        private System.Void set_carving(System.Boolean value) { }
        private System.Void set_carveOnlyStationary(System.Boolean value) { }
        private System.Void set_shape(UnityEngine.AI.NavMeshObstacleShape value) { }
        private UnityEngine.Vector3 get_center() { }
        private System.Void set_center(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_size() { }
        private System.Void set_size(UnityEngine.Vector3 value) { }
        private System.Void set_ignoredSurfaceID(System.Int32 value) { }
        private System.Void get_center_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_center_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_size_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_size_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200000B
    public struct NavMeshHit
    {
        // Fields
        private UnityEngine.Vector3 m_Position;        // 0x10
        private UnityEngine.Vector3 m_Normal;        // 0x1C
        private System.Single m_Distance;        // 0x28
        private System.Int32 m_Mask;        // 0x2C
        private System.Int32 m_Hit;        // 0x30

        // Methods
        private UnityEngine.Vector3 get_position() { }
        private UnityEngine.Vector3 get_normal() { }
        private System.Boolean get_hit() { }

    }

    // TypeToken: 0x200000C
    public struct QueryPolygonInfo
    {
        // Fields
        public System.Single distance;        // 0x10
        public System.UInt64 polyRef;        // 0x18

    }

    // TypeToken: 0x200000D
    public class NavMeshData
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 agentTypeID) { }
        private System.Void Internal_Create(UnityEngine.AI.NavMeshData mono, System.Int32 agentTypeID) { }
        private UnityEngine.Bounds get_sourceBounds() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private System.Void AppendExtOffMeshLink(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single width, System.Boolean bidirectional, System.Int32 area, System.Single costModifier) { }
        private System.Void Internal_AppendExtOffMeshLink(UnityEngine.Vector3 startLeft, UnityEngine.Vector3 startRight, UnityEngine.Vector3 endRight, UnityEngine.Vector3 endLeft, System.Boolean bidirectional, System.Int32 area, System.Single costModifier) { }
        private System.Void get_sourceBounds_Injected(UnityEngine.Bounds& ret) { }
        private System.Void set_position_Injected(UnityEngine.Vector3& value) { }
        private System.Void set_rotation_Injected(UnityEngine.Quaternion& value) { }
        private System.Void Internal_AppendExtOffMeshLink_Injected(UnityEngine.Vector3& startLeft, UnityEngine.Vector3& startRight, UnityEngine.Vector3& endRight, UnityEngine.Vector3& endLeft, System.Boolean bidirectional, System.Int32 area, System.Single costModifier) { }

    }

    // TypeToken: 0x200000E
    public struct NavMeshDataInstance
    {
        // Fields
        private System.Int32 <id>k__BackingField;        // 0x10

        // Methods
        private System.Boolean get_valid() { }
        private System.Int32 get_id() { }
        private System.Void set_id(System.Int32 value) { }
        private System.Int32 get_handleId() { }
        private System.Void set_handleId(System.Int32 value) { }
        private System.Void Remove() { }
        private System.Void set_owner(UnityEngine.Object value) { }

    }

    // TypeToken: 0x200000F
    public struct NavMeshLinkData
    {
        // Fields
        private System.Boolean m_IsExt;        // 0x10
        private UnityEngine.Vector3 m_StartLeft;        // 0x14
        private UnityEngine.Vector3 m_StartRight;        // 0x20
        private UnityEngine.Vector3 m_EndRight;        // 0x2C
        private UnityEngine.Vector3 m_EndLeft;        // 0x38
        private System.Single m_CostModifier;        // 0x44
        private System.Int32 m_Bidirectional;        // 0x48
        private System.Int32 m_Area;        // 0x4C
        private System.Int32 m_AgentTypeID;        // 0x50

        // Methods
        private System.Boolean get_isExt() { }
        private System.Void set_isExt(System.Boolean value) { }
        private UnityEngine.Vector3 get_startLeft() { }
        private System.Void set_startLeft(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_startRight() { }
        private System.Void set_startRight(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_endRight() { }
        private System.Void set_endRight(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_endLeft() { }
        private System.Void set_endLeft(UnityEngine.Vector3 value) { }
        private System.Single get_costModifier() { }
        private System.Void set_costModifier(System.Single value) { }
        private System.Boolean get_bidirectional() { }
        private System.Void set_bidirectional(System.Boolean value) { }
        private System.Int32 get_area() { }
        private System.Void set_area(System.Int32 value) { }
        private System.Int32 get_agentTypeID() { }
        private System.Void set_agentTypeID(System.Int32 value) { }

    }

    // TypeToken: 0x2000010
    public struct NavMeshLinkInstance
    {
        // Fields
        private System.Int32 <id>k__BackingField;        // 0x10

        // Methods
        private System.Boolean get_valid() { }
        private System.Int32 get_id() { }
        private System.Void set_id(System.Int32 value) { }
        private System.Void Remove() { }
        private System.Void set_owner(UnityEngine.Object value) { }

    }

    // TypeToken: 0x2000011
    public class NavMesh
    {
        // Fields
        public static UnityEngine.AI.NavMesh.OnNavMeshPreUpdate onPreUpdate;        // 0x0
        public static UnityEngine.AI.NavMesh.OnUnloadFinishDelegate onUnloadFinish;        // 0x8

        // Methods
        private System.Void Internal_CallOnNavMeshPreUpdate() { }
        private System.Boolean Raycast(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }
        private System.Boolean CalculatePath(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        private System.Boolean CalculatePathInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        private System.Boolean FindClosestEdge(UnityEngine.Vector3 sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }
        private System.Boolean SamplePosition(UnityEngine.Vector3 sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Single maxDistance, System.Int32 areaMask) { }
        private System.Int32 GetAreaFromName(System.String areaName) { }
        private UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData) { }
        private UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void UpdateSurfaceTransform(UnityEngine.AI.NavMeshDataInstance handle, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void RemoveNavMeshData(UnityEngine.AI.NavMeshDataInstance handle) { }
        private System.Boolean IsValidNavMeshDataHandle(System.Int32 handle) { }
        private System.Boolean IsValidLinkHandle(System.Int32 handle) { }
        private System.Boolean InternalSetOwner(System.Int32 dataID, System.Int32 ownerID) { }
        private System.Boolean InternalSetLinkOwner(System.Int32 linkID, System.Int32 ownerID) { }
        private System.Int32 AddNavMeshDataInternal(UnityEngine.AI.NavMeshData navMeshData) { }
        private System.Int32 AddNavMeshDataTransformedInternal(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void RemoveNavMeshDataInternal(System.Int32 handle) { }
        private UnityEngine.AI.NavMeshLinkInstance AddLink(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void RemoveLink(UnityEngine.AI.NavMeshLinkInstance handle) { }
        private System.Int32 AddLinkInternal(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void RemoveLinkInternal(System.Int32 handle) { }
        private UnityEngine.AI.NavMeshBuildSettings GetSettingsByID(System.Int32 agentTypeID) { }
        private UnityEngine.AI.NavMeshBuildSettings GetSettingsByIndex(System.Int32 index) { }
        private System.Void UpdateSurfaceTransformInternal(System.Int32 surfaceID, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Boolean DetachFromSurface(System.Int32 chunkSurfaceId, System.Int32 builderSurfaceId, System.Int32 indexX, System.Int32 indexZ) { }
        private System.Boolean SetBuilderSurfaceParams(System.Int32 surfID, System.Single chunkSize, System.Single tileSize, System.Single centerX, System.Single centerZ, System.Single sizeX, System.Single sizeZ) { }
        private System.Boolean Internal_DetachFromSurface(System.Int32 chunkSurfaceId, System.Int32 builderSurfaceId, System.Int32 indexX, System.Int32 indexZ) { }
        private System.Boolean Internal_SetBuilderSurfaceParams(System.Int32 surfID, System.Single chunkSize, System.Single tileSize, System.Single centerX, System.Single centerZ, System.Single sizeX, System.Single sizeZ) { }
        private System.Boolean VerticalQueryNearestPolygons(UnityEngine.Vector3 start, System.Single height, UnityEngine.AI.QueryPolygonInfo& nearestPoly, System.Int32 agentTypeID, System.Int32 areaMask) { }
        private System.Boolean VerticalQueryNearestPolygons(UnityEngine.Vector3 start, System.Single height, UnityEngine.AI.QueryPolygonInfo& nearestPoly) { }
        private System.Boolean Internal_VerticalQueryNearestPolygons(UnityEngine.Vector3 start, System.Single height, UnityEngine.AI.QueryPolygonInfo& nearestPoly, System.Int32 agentTypeID, System.UInt32 areaMask) { }
        private System.Int32 LoadDynamicBakeTile(UnityEngine.AI.NavMeshData navMeshData) { }
        private System.Void UnloadDynamicBakeTile(System.Int32 dynamicTileID) { }
        private System.Int32 Internal_LoadDynamicBakeTile(UnityEngine.AI.NavMeshData navMeshData) { }
        private System.Void Internal_UnloadDynamicBakeTile(System.Int32 dynamicTileID) { }
        private System.Int32 ModifyVolumeArea(System.Collections.Generic.List<UnityEngine.Vector3> center, System.Collections.Generic.List<UnityEngine.Vector3> ext, System.Collections.Generic.List<UnityEngine.Quaternion> rotation, System.Int32 area) { }
        private System.Int32 ModifyBoxAreaInternal(System.Collections.Generic.List<UnityEngine.Vector3> center, System.Collections.Generic.List<UnityEngine.Vector3> ext, System.Collections.Generic.List<UnityEngine.Quaternion> rotation, System.Int32 area) { }
        private System.Int32 ModifyVolumeArea(UnityEngine.Vector3[] center, UnityEngine.Vector3[] ext, UnityEngine.Quaternion[] rotation, System.Int32 area) { }
        private System.Int32 ModifyBoxArrayAreaInternal(UnityEngine.Vector3[] center, UnityEngine.Vector3[] ext, UnityEngine.Quaternion[] rotation, System.Int32 area) { }
        private System.Int32 ModifyVolumeArea(System.Collections.Generic.List<UnityEngine.Vector3> verts, System.Single hMin, System.Single hMax, System.Int32 area) { }
        private System.Int32 ModifyPolygonAreaInternal(System.Collections.Generic.List<UnityEngine.Vector3> verts, System.Single hMin, System.Single hMax, System.Int32 area) { }
        private System.Void LoadExtOffMeshLinks(System.Int32 surfaceID) { }
        private System.Void Internal_LoadExtOffMeshLinks(System.Int32 surfaceID) { }
        private UnityEngine.AsyncOperation AddNavMeshDataAsync(System.Int32& surfaceID, UnityEngine.AI.NavMeshData navMeshData, System.UInt64 surfTileID) { }
        private UnityEngine.AsyncOperation AddNavMeshDataAsyncInternal(System.Int32& surfaceID, UnityEngine.AI.NavMeshData navMeshData, System.UInt64 surfTileID) { }
        private System.Void CancelAsyncAdd(System.UInt64 surfTileID) { }
        private System.Void Internal_CancelAsyncAdd(System.UInt64 surfaceID) { }
        private System.Void UnloadDataAsync(System.Int32 surfaceID, System.UInt64 surfTileID) { }
        private System.Void Internal_UnloadDataAsync(System.Int32 surfaceID, System.UInt64 surfTileID) { }
        private System.Void Internal_InvokeOnUnloadFinish(System.UInt64 surfTileID) { }
        private System.Boolean IsSurfaceUnloading(System.UInt64 surfTileID) { }
        private System.Boolean Internal_IsSurfaceUnloading(System.UInt64 surfTileID) { }
        private System.Void ForceClearUnloadDataRequest() { }
        private System.Void Internal_ForceClearUnloadDataRequest() { }
        private System.Void CalculatePathAsync(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        private System.Void CalculatePathAsyncInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        private System.Void SetFindPathMaxIterPerFrame(System.Int32 maxIterPerFrame) { }
        private System.Void Internal_SetFindPathMaxIterPerFrame(System.Int32 maxIterPerFrame) { }
        private System.Void CancelAsyncCalculatePath(UnityEngine.AI.NavMeshPath path) { }
        private System.Void Internal_CancelAsyncCalculatePath(UnityEngine.AI.NavMeshPath path) { }
        private System.Void RegisterAutoRepath(UnityEngine.AI.NavMeshPath path) { }
        private System.Void Internal_RegisterAutoRepath(UnityEngine.AI.NavMeshPath path) { }
        private System.Void UnregisterAutoRepath(UnityEngine.AI.NavMeshPath path) { }
        private System.Void Internal_UnregisterAutoRepath(UnityEngine.AI.NavMeshPath path) { }
        private System.Boolean Raycast_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }
        private System.Boolean CalculatePathInternal_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        private System.Boolean FindClosestEdge_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }
        private System.Boolean SamplePosition_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Single maxDistance, System.Int32 areaMask) { }
        private System.Int32 AddNavMeshDataTransformedInternal_Injected(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Int32 AddLinkInternal_Injected(UnityEngine.AI.NavMeshLinkData& link, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Void GetSettingsByID_Injected(System.Int32 agentTypeID, UnityEngine.AI.NavMeshBuildSettings& ret) { }
        private System.Void GetSettingsByIndex_Injected(System.Int32 index, UnityEngine.AI.NavMeshBuildSettings& ret) { }
        private System.Void UpdateSurfaceTransformInternal_Injected(System.Int32 surfaceID, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Boolean Internal_VerticalQueryNearestPolygons_Injected(UnityEngine.Vector3& start, System.Single height, UnityEngine.AI.QueryPolygonInfo& nearestPoly, System.Int32 agentTypeID, System.UInt32 areaMask) { }
        private System.Void CalculatePathAsyncInternal_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }

    }

    // TypeToken: 0x2000014
    public struct NavMeshBuildSourceShape
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AI.NavMeshBuildSourceShape Mesh;        // 0x0
        public static UnityEngine.AI.NavMeshBuildSourceShape Terrain;        // 0x0
        public static UnityEngine.AI.NavMeshBuildSourceShape Box;        // 0x0
        public static UnityEngine.AI.NavMeshBuildSourceShape Sphere;        // 0x0
        public static UnityEngine.AI.NavMeshBuildSourceShape Capsule;        // 0x0
        public static UnityEngine.AI.NavMeshBuildSourceShape ModifierBox;        // 0x0
        public static UnityEngine.AI.NavMeshBuildSourceShape PhysicsTriangleMesh;        // 0x0
        public static UnityEngine.AI.NavMeshBuildSourceShape PhysicsConvexMesh;        // 0x0
        public static UnityEngine.AI.NavMeshBuildSourceShape PhysicsTerrain;        // 0x0
        public static UnityEngine.AI.NavMeshBuildSourceShape ModifierPoly;        // 0x0

    }

    // TypeToken: 0x2000015
    public struct NavMeshCollectGeometry
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AI.NavMeshCollectGeometry RenderMeshes;        // 0x0
        public static UnityEngine.AI.NavMeshCollectGeometry PhysicsColliders;        // 0x0

    }

    // TypeToken: 0x2000016
    public struct NavMeshBuildSource
    {
        // Fields
        private UnityEngine.Matrix4x4 m_Transform;        // 0x10
        private UnityEngine.Vector3 m_Size;        // 0x50
        private UnityEngine.AI.NavMeshBuildSourceShape m_Shape;        // 0x5C
        private System.Int32 m_Area;        // 0x60
        private System.Int32 m_InstanceID;        // 0x64
        private System.Int32 m_ComponentID;        // 0x68
        private System.Boolean m_IsConvex;        // 0x6C
        private System.IntPtr m_EcsShape;        // 0x70
        public System.Collections.Generic.List<UnityEngine.Vector3> convexVerts;        // 0x78
        public System.Single convexHmin;        // 0x80
        public System.Single convexHmax;        // 0x84

        // Methods
        private UnityEngine.Matrix4x4 get_transform() { }
        private System.Void set_transform(UnityEngine.Matrix4x4 value) { }
        private UnityEngine.Vector3 get_size() { }
        private System.Void set_size(UnityEngine.Vector3 value) { }
        private UnityEngine.AI.NavMeshBuildSourceShape get_shape() { }
        private System.Void set_shape(UnityEngine.AI.NavMeshBuildSourceShape value) { }
        private System.Int32 get_area() { }
        private System.Void set_area(System.Int32 value) { }
        private UnityEngine.Object get_sourceObject() { }
        private UnityEngine.Component get_component() { }
        private UnityEngine.Component InternalGetComponent(System.Int32 instanceID) { }
        private UnityEngine.Object InternalGetObject(System.Int32 instanceID) { }

    }

    // TypeToken: 0x2000017
    public struct NavMeshBuildMarkup
    {
        // Fields
        private System.Int32 m_OverrideArea;        // 0x10
        private System.Int32 m_Area;        // 0x14
        private System.Int32 m_IgnoreFromBuild;        // 0x18
        private System.Int32 m_InstanceID;        // 0x1C

        // Methods
        private System.Void set_overrideArea(System.Boolean value) { }
        private System.Void set_area(System.Int32 value) { }
        private System.Void set_ignoreFromBuild(System.Boolean value) { }
        private System.Void set_root(UnityEngine.Transform value) { }

    }

    // TypeToken: 0x2000018
    public struct NavMeshBuildSettings
    {
        // Fields
        private System.Int32 m_AgentTypeID;        // 0x10
        private System.Single m_AgentRadius;        // 0x14
        private System.Single m_AgentHeight;        // 0x18
        private System.Single m_AgentSlope;        // 0x1C
        private System.Single m_AgentClimb;        // 0x20
        private System.Single m_LedgeDropHeight;        // 0x24
        private System.Single m_MaxJumpAcrossDistance;        // 0x28
        private System.Single m_MinRegionArea;        // 0x2C
        private System.Int32 m_OverrideVoxelSize;        // 0x30
        private System.Single m_VoxelSize;        // 0x34
        private System.Int32 m_OverrideTileSize;        // 0x38
        private System.Int32 m_TileSize;        // 0x3C
        private System.Int32 m_AccuratePlacement;        // 0x40
        private System.UInt32 m_MaxJobWorkers;        // 0x44
        private System.Int32 m_PreserveTilesOutsideBounds;        // 0x48
        private System.Int32 m_PartitioningMethod;        // 0x4C
        private System.Int32 m_FilterLowHangingObstacles;        // 0x50
        private System.Int32 m_FilterLedgeSpans;        // 0x54
        private System.Int32 m_FilterWalkableLowHeightSpans;        // 0x58
        private System.Int32 m_erodeAgainstWallSpans;        // 0x5C
        private System.Int32 m_cliffIndent;        // 0x60
        private System.Int32 m_DynamicNavmeshSurfaceType;        // 0x64
        private UnityEngine.AI.NavMeshBuildDebugSettings m_Debug;        // 0x68

        // Methods
        private System.Int32 get_agentTypeID() { }
        private System.Void set_agentTypeID(System.Int32 value) { }
        private System.Single get_agentRadius() { }
        private System.Single get_agentHeight() { }
        private System.Single get_agentClimb() { }
        private System.Void set_minRegionArea(System.Single value) { }
        private System.Void set_overrideVoxelSize(System.Boolean value) { }
        private System.Void set_voxelSize(System.Single value) { }
        private System.Void set_overrideTileSize(System.Boolean value) { }
        private System.Void set_tileSize(System.Int32 value) { }
        private System.Void set_partitioningMethod(System.Int32 value) { }
        private System.Void set_filterLowHangingObstacles(System.Boolean value) { }
        private System.Void set_filterLedgeSpans(System.Boolean value) { }
        private System.Void set_filterWalkableLowHeightSpans(System.Boolean value) { }
        private System.Void set_erodeAgainstWallSpans(System.Boolean value) { }
        private System.Void set_cliffIndent(System.Int32 value) { }

    }

    // TypeToken: 0x2000019
    public struct NavMeshBuildDebugSettings
    {
        // Fields
        private System.Byte m_Flags;        // 0x10

    }

}

namespace UnityEngine.Experimental.AI
{

    // TypeToken: 0x200001A
    public struct PolygonId, IEquatable`1
    {
        // Fields
        private System.UInt64 polyRef;        // 0x10

        // Methods
        private System.Boolean IsNull() { }
        private System.Boolean op_Equality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y) { }
        private System.Boolean op_Inequality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(UnityEngine.Experimental.AI.PolygonId rhs) { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x200001B
    public struct NavMeshLocation
    {
        // Fields
        private readonly UnityEngine.Experimental.AI.PolygonId <polygon>k__BackingField;        // 0x10
        private readonly UnityEngine.Vector3 <position>k__BackingField;        // 0x18

        // Methods
        private UnityEngine.Experimental.AI.PolygonId get_polygon() { }
        private UnityEngine.Vector3 get_position() { }

    }

    // TypeToken: 0x200001C
    public struct PathQueryStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.AI.PathQueryStatus Failure;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus Success;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus InProgress;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus StatusDetailMask;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus WrongMagic;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus WrongVersion;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus OutOfMemory;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus InvalidParam;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus BufferTooSmall;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus OutOfNodes;        // 0x0
        public static UnityEngine.Experimental.AI.PathQueryStatus PartialResult;        // 0x0

    }

    // TypeToken: 0x200001D
    public struct NavMeshWorld
    {
        // Fields
        private System.IntPtr world;        // 0x10

        // Methods
        private UnityEngine.Experimental.AI.NavMeshWorld GetDefaultWorld() { }
        private System.Void GetDefaultWorld_Injected(UnityEngine.Experimental.AI.NavMeshWorld& ret) { }

    }

    // TypeToken: 0x200001E
    public struct NavMeshQuery, IDisposable
    {
        // Fields
        private System.IntPtr m_NavMeshQuery;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Experimental.AI.NavMeshWorld world, Unity.Collections.Allocator allocator, System.Int32 pathNodePoolSize) { }
        private System.Void Dispose() { }
        private System.IntPtr Create(UnityEngine.Experimental.AI.NavMeshWorld world, System.Int32 nodePoolSize) { }
        private System.Void Destroy(System.IntPtr navMeshQuery) { }
        private UnityEngine.Experimental.AI.NavMeshLocation MapLocation(System.IntPtr navMeshQuery, UnityEngine.Vector3 position, UnityEngine.Vector3 extents, System.Int32 agentTypeID, System.Int32 areaMask) { }
        private UnityEngine.Experimental.AI.NavMeshLocation MapLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 extents, System.Int32 agentTypeID, System.Int32 areaMask) { }
        private UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, System.Int32 areaMask) { }
        private UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, System.Int32 areaMask) { }
        private UnityEngine.Experimental.AI.PathQueryStatus Raycast(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, System.Void* costs, UnityEngine.AI.NavMeshHit& hit, System.Void* path, System.Int32& pathCount, System.Int32 maxPath) { }
        private UnityEngine.Experimental.AI.PathQueryStatus Raycast(UnityEngine.AI.NavMeshHit& hit, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, Unity.Collections.NativeArray<System.Single> costs) { }
        private System.IntPtr Create_Injected(UnityEngine.Experimental.AI.NavMeshWorld& world, System.Int32 nodePoolSize) { }
        private System.Void MapLocation_Injected(System.IntPtr navMeshQuery, UnityEngine.Vector3& position, UnityEngine.Vector3& extents, System.Int32 agentTypeID, System.Int32 areaMask, UnityEngine.Experimental.AI.NavMeshLocation& ret) { }
        private System.Void MoveLocation_Injected(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation& location, UnityEngine.Vector3& target, System.Int32 areaMask, UnityEngine.Experimental.AI.NavMeshLocation& ret) { }
        private UnityEngine.Experimental.AI.PathQueryStatus Raycast_Injected(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation& start, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, System.Void* costs, UnityEngine.AI.NavMeshHit& hit, System.Void* path, System.Int32& pathCount, System.Int32 maxPath) { }

    }

}

