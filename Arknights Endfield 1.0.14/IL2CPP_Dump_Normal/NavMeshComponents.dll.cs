// ========================================================
// Dumped by @desirepro
// Assembly: NavMeshComponents.dll
// Classes:  9
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class NavMeshPrefabInstance : MonoBehaviour
    {
        // Fields
        private UnityEngine.AI.NavMeshData m_NavMesh;        // 0x18
        private System.Boolean m_FollowTransform;        // 0x20
        private UnityEngine.AI.NavMeshDataInstance m_Instance;        // 0x24
        private static readonly System.Collections.Generic.List<NavMeshPrefabInstance> s_TrackedInstances;        // 0x0
        private UnityEngine.Vector3 m_Position;        // 0x28
        private UnityEngine.Quaternion m_Rotation;        // 0x34

        // Methods
        private UnityEngine.AI.NavMeshData get_navMeshData() { }
        private System.Void set_navMeshData(UnityEngine.AI.NavMeshData value) { }
        private System.Boolean get_followTransform() { }
        private System.Void set_followTransform(System.Boolean value) { }
        private System.Collections.Generic.List<NavMeshPrefabInstance> get_trackedInstances() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void UpdateInstance() { }
        private System.Void AddInstance() { }
        private System.Void AddTracking() { }
        private System.Void RemoveTracking() { }
        private System.Void SetFollowTransform(System.Boolean value) { }
        private System.Boolean HasMoved() { }
        private System.Void UpdateTrackedInstances() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

namespace UnityEngine.AI
{

    // TypeToken: 0x2000003
    public class NavMeshLink : MonoBehaviour
    {
        // Fields
        private System.Int32 m_AgentTypeID;        // 0x18
        private UnityEngine.Vector3 m_StartRight;        // 0x1C
        private UnityEngine.Vector3 m_StartLeft;        // 0x28
        private UnityEngine.Vector3 m_EndRight;        // 0x34
        private UnityEngine.Vector3 m_EndLeft;        // 0x40
        private System.Boolean m_IsExt;        // 0x4C
        private System.Single m_CostModifier;        // 0x50
        private System.Boolean m_Bidirectional;        // 0x54
        private System.Boolean m_AutoUpdatePosition;        // 0x55
        private System.Int32 m_Area;        // 0x58
        public System.Boolean autoSnapExtent;        // 0x5C
        public UnityEngine.Vector3 snapExtent;        // 0x60
        private UnityEngine.AI.NavMeshLinkInstance m_LinkInstance;        // 0x6C
        private UnityEngine.Vector3 m_LastPosition;        // 0x70
        private UnityEngine.Quaternion m_LastRotation;        // 0x7C
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshLink> s_Tracked;        // 0x0

        // Methods
        private System.Int32 get_agentTypeID() { }
        private System.Void set_agentTypeID(System.Int32 value) { }
        private UnityEngine.Vector3 get_startRight() { }
        private System.Void set_startRight(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_startLeft() { }
        private System.Void set_startLeft(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_startMid() { }
        private UnityEngine.Vector3 get_endRight() { }
        private System.Void set_endRight(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_endLeft() { }
        private System.Void set_endLeft(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_endMid() { }
        private System.Boolean get_isExt() { }
        private System.Void set_isExt(System.Boolean value) { }
        private System.Single get_costModifier() { }
        private System.Void set_costModifier(System.Single value) { }
        private System.Boolean get_bidirectional() { }
        private System.Void set_bidirectional(System.Boolean value) { }
        private System.Boolean get_autoUpdate() { }
        private System.Void set_autoUpdate(System.Boolean value) { }
        private System.Int32 get_area() { }
        private System.Void set_area(System.Int32 value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void UpdateLink() { }
        private System.Void AddTracking(UnityEngine.AI.NavMeshLink link) { }
        private System.Void RemoveTracking(UnityEngine.AI.NavMeshLink link) { }
        private System.Void SetAutoUpdate(System.Boolean value) { }
        private System.Void AddLink() { }
        private System.Void SetByLinkData(UnityEngine.AI.NavMeshLinkData data) { }
        private System.Boolean HasTransformChanged() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void UpdateTrackedInstances() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000004
    public class NavMeshModifier : MonoBehaviour
    {
        // Fields
        private System.Boolean m_OverrideArea;        // 0x18
        private System.Int32 m_Area;        // 0x1C
        private System.Boolean m_IgnoreFromBuild;        // 0x20
        private System.Collections.Generic.List<System.Int32> m_AffectedAgents;        // 0x28
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier> s_NavMeshModifiers;        // 0x0

        // Methods
        private System.Boolean get_overrideArea() { }
        private System.Void set_overrideArea(System.Boolean value) { }
        private System.Int32 get_area() { }
        private System.Void set_area(System.Int32 value) { }
        private System.Boolean get_ignoreFromBuild() { }
        private System.Void set_ignoreFromBuild(System.Boolean value) { }
        private System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier> get_activeModifiers() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean AffectsAgentType(System.Int32 agentTypeID) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000005
    public class NavMeshModifierVolume : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 m_Size;        // 0x18
        private UnityEngine.Vector3 m_Center;        // 0x24
        private System.Int32 m_Area;        // 0x30
        private System.Collections.Generic.List<System.Int32> m_AffectedAgents;        // 0x38
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> s_NavMeshModifiers;        // 0x0

        // Methods
        private UnityEngine.Vector3 get_size() { }
        private System.Void set_size(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_center() { }
        private System.Void set_center(UnityEngine.Vector3 value) { }
        private System.Int32 get_area() { }
        private System.Void set_area(System.Int32 value) { }
        private System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> get_activeModifiers() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean AffectsAgentType(System.Int32 agentTypeID) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000006
    public struct CollectObjects
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AI.CollectObjects All;        // 0x0
        public static UnityEngine.AI.CollectObjects Volume;        // 0x0
        public static UnityEngine.AI.CollectObjects Children;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct PartitioningMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AI.PartitioningMethod Layers;        // 0x0
        public static UnityEngine.AI.PartitioningMethod Monotone;        // 0x0
        public static UnityEngine.AI.PartitioningMethod Watershed;        // 0x0

    }

    // TypeToken: 0x2000008
    public class NavMeshSurface : MonoBehaviour
    {
        // Fields
        private System.Int32 m_AgentTypeID;        // 0x18
        private UnityEngine.AI.CollectObjects m_CollectObjects;        // 0x1C
        private UnityEngine.Vector3 m_Size;        // 0x20
        private UnityEngine.Vector3 m_Center;        // 0x2C
        private UnityEngine.LayerMask m_LayerMask;        // 0x38
        private System.String m_BlockTag;        // 0x40
        private UnityEngine.AI.PartitioningMethod m_PartitioningMethod;        // 0x48
        private System.Boolean m_FilterLowHangingObstacles;        // 0x4C
        private System.Boolean m_FilterLedgeSpans;        // 0x4D
        private System.Boolean m_FilterWalkableLowHeightSpans;        // 0x4E
        private System.Boolean m_OverrideMinRegionArea;        // 0x4F
        private System.Single m_MinRegionArea;        // 0x50
        private UnityEngine.AI.NavMeshCollectGeometry m_UseGeometry;        // 0x54
        private System.Int32 m_DefaultArea;        // 0x58
        private System.Boolean m_IgnoreNavMeshAgent;        // 0x5C
        private System.Boolean m_IgnoreNavMeshObstacle;        // 0x5D
        private System.Boolean m_OverrideTileSize;        // 0x5E
        private System.Int32 m_TileSize;        // 0x60
        private System.Boolean m_OverrideVoxelSize;        // 0x64
        private System.Single m_VoxelSize;        // 0x68
        private System.Boolean m_BuildHeightMesh;        // 0x6C
        private UnityEngine.AI.NavMeshData m_NavMeshData;        // 0x70
        private UnityEngine.AI.NavMeshDataInstance m_NavMeshDataInstance;        // 0x78
        private UnityEngine.Vector3 m_LastPosition;        // 0x7C
        private UnityEngine.Quaternion m_LastRotation;        // 0x88
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface> s_NavMeshSurfaces;        // 0x0

        // Methods
        private System.Int32 get_agentTypeID() { }
        private System.Void set_agentTypeID(System.Int32 value) { }
        private UnityEngine.AI.CollectObjects get_collectObjects() { }
        private System.Void set_collectObjects(UnityEngine.AI.CollectObjects value) { }
        private UnityEngine.Vector3 get_size() { }
        private System.Void set_size(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_center() { }
        private System.Void set_center(UnityEngine.Vector3 value) { }
        private UnityEngine.LayerMask get_layerMask() { }
        private System.Void set_layerMask(UnityEngine.LayerMask value) { }
        private System.String get_BlockTag() { }
        private System.Void set_BlockTag(System.String value) { }
        private UnityEngine.AI.PartitioningMethod get_partitioningMethod() { }
        private System.Void set_partitioningMethod(UnityEngine.AI.PartitioningMethod value) { }
        private System.Boolean get_filterLowHangingObstacles() { }
        private System.Void set_filterLowHangingObstacles(System.Boolean value) { }
        private System.Boolean get_filterLedgeSpans() { }
        private System.Void set_filterLedgeSpans(System.Boolean value) { }
        private System.Boolean get_filterWalkableLowHeightSpans() { }
        private System.Void set_filterWalkableLowHeightSpans(System.Boolean value) { }
        private System.Boolean get_overrideMinRegionArea() { }
        private System.Void set_overrideMinRegionArea(System.Boolean value) { }
        private System.Single get_minRegionArea() { }
        private System.Void set_minRegionArea(System.Single value) { }
        private UnityEngine.AI.NavMeshCollectGeometry get_useGeometry() { }
        private System.Void set_useGeometry(UnityEngine.AI.NavMeshCollectGeometry value) { }
        private System.Int32 get_defaultArea() { }
        private System.Void set_defaultArea(System.Int32 value) { }
        private System.Boolean get_ignoreNavMeshAgent() { }
        private System.Void set_ignoreNavMeshAgent(System.Boolean value) { }
        private System.Boolean get_ignoreNavMeshObstacle() { }
        private System.Void set_ignoreNavMeshObstacle(System.Boolean value) { }
        private System.Boolean get_overrideTileSize() { }
        private System.Void set_overrideTileSize(System.Boolean value) { }
        private System.Int32 get_tileSize() { }
        private System.Void set_tileSize(System.Int32 value) { }
        private System.Boolean get_overrideVoxelSize() { }
        private System.Void set_overrideVoxelSize(System.Boolean value) { }
        private System.Single get_voxelSize() { }
        private System.Void set_voxelSize(System.Single value) { }
        private System.Boolean get_buildHeightMesh() { }
        private System.Void set_buildHeightMesh(System.Boolean value) { }
        private UnityEngine.AI.NavMeshData get_navMeshData() { }
        private System.Void set_navMeshData(UnityEngine.AI.NavMeshData value) { }
        private System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface> get_activeSurfaces() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void AddData() { }
        private System.Void RemoveData() { }
        private UnityEngine.AI.NavMeshBuildSettings GetBuildSettings() { }
        private System.Void BuildNavMesh() { }
        private UnityEngine.AsyncOperation UpdateNavMesh(UnityEngine.AI.NavMeshData data) { }
        private System.Boolean UpdateNavMeshSync(UnityEngine.AI.NavMeshData data) { }
        private System.Void Register(UnityEngine.AI.NavMeshSurface surface) { }
        private System.Void Unregister(UnityEngine.AI.NavMeshSurface surface) { }
        private System.Void UpdateActive() { }
        private System.Void AppendModifierVolumes(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>& sources) { }
        private System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> CollectSources() { }
        private UnityEngine.Vector3 Abs(UnityEngine.Vector3 v) { }
        private UnityEngine.Bounds GetWorldBounds(UnityEngine.Matrix4x4 mat, UnityEngine.Bounds bounds) { }
        private UnityEngine.Bounds CalculateWorldBounds(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources) { }
        private System.Boolean HasTransformChanged() { }
        private System.Void UpdateDataIfTransformChanged() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

