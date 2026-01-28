// ========================================================
// Dumped by @desirepro
// Assembly: NavMeshComponents.dll
// Classes:  9
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: NavMeshPrefabInstance
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.AI.NavMeshData      m_NavMesh  // 0x18
  private           System.Boolean                  m_FollowTransform  // 0x20
  private           UnityEngine.AI.NavMeshDataInstancem_Instance  // 0x24
  private   static readonly System.Collections.Generic.List<NavMeshPrefabInstance>s_TrackedInstances  // 0x0
  private           UnityEngine.Vector3             m_Position  // 0x28
  private           UnityEngine.Quaternion          m_Rotation  // 0x34
METHODS:
  UnityEngine.AI.NavMeshData get_navMeshData()
  System.Void set_navMeshData(UnityEngine.AI.NavMeshData value)
  System.Boolean get_followTransform()
  System.Void set_followTransform(System.Boolean value)
  System.Collections.Generic.List<NavMeshPrefabInstance> get_trackedInstances()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void UpdateInstance()
  System.Void AddInstance()
  System.Void AddTracking()
  System.Void RemoveTracking()
  System.Void SetFollowTransform(System.Boolean value)
  System.Boolean HasMoved()
  System.Void UpdateTrackedInstances()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.AI.NavMeshLink
TYPE:  class
TOKEN: 0x2000003
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Int32                    m_AgentTypeID  // 0x18
  private           UnityEngine.Vector3             m_StartRight  // 0x1C
  private           UnityEngine.Vector3             m_StartLeft  // 0x28
  private           UnityEngine.Vector3             m_EndRight  // 0x34
  private           UnityEngine.Vector3             m_EndLeft  // 0x40
  private           System.Boolean                  m_IsExt  // 0x4C
  private           System.Single                   m_CostModifier  // 0x50
  private           System.Boolean                  m_Bidirectional  // 0x54
  private           System.Boolean                  m_AutoUpdatePosition  // 0x55
  private           System.Int32                    m_Area  // 0x58
  public            System.Boolean                  autoSnapExtent  // 0x5C
  public            UnityEngine.Vector3             snapExtent  // 0x60
  private           UnityEngine.AI.NavMeshLinkInstancem_LinkInstance  // 0x6C
  private           UnityEngine.Vector3             m_LastPosition  // 0x70
  private           UnityEngine.Quaternion          m_LastRotation  // 0x7C
  private   static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshLink>s_Tracked  // 0x0
METHODS:
  System.Int32 get_agentTypeID()
  System.Void set_agentTypeID(System.Int32 value)
  UnityEngine.Vector3 get_startRight()
  System.Void set_startRight(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_startLeft()
  System.Void set_startLeft(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_startMid()
  UnityEngine.Vector3 get_endRight()
  System.Void set_endRight(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_endLeft()
  System.Void set_endLeft(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_endMid()
  System.Boolean get_isExt()
  System.Void set_isExt(System.Boolean value)
  System.Single get_costModifier()
  System.Void set_costModifier(System.Single value)
  System.Boolean get_bidirectional()
  System.Void set_bidirectional(System.Boolean value)
  System.Boolean get_autoUpdate()
  System.Void set_autoUpdate(System.Boolean value)
  System.Int32 get_area()
  System.Void set_area(System.Int32 value)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void UpdateLink()
  System.Void AddTracking(UnityEngine.AI.NavMeshLink link)
  System.Void RemoveTracking(UnityEngine.AI.NavMeshLink link)
  System.Void SetAutoUpdate(System.Boolean value)
  System.Void AddLink()
  System.Void SetByLinkData(UnityEngine.AI.NavMeshLinkData data)
  System.Boolean HasTransformChanged()
  System.Void OnDidApplyAnimationProperties()
  System.Void UpdateTrackedInstances()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.AI.NavMeshModifier
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  m_OverrideArea  // 0x18
  private           System.Int32                    m_Area  // 0x1C
  private           System.Boolean                  m_IgnoreFromBuild  // 0x20
  private           System.Collections.Generic.List<System.Int32>m_AffectedAgents  // 0x28
  private   static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier>s_NavMeshModifiers  // 0x0
METHODS:
  System.Boolean get_overrideArea()
  System.Void set_overrideArea(System.Boolean value)
  System.Int32 get_area()
  System.Void set_area(System.Int32 value)
  System.Boolean get_ignoreFromBuild()
  System.Void set_ignoreFromBuild(System.Boolean value)
  System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier> get_activeModifiers()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean AffectsAgentType(System.Int32 agentTypeID)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.AI.NavMeshModifierVolume
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Vector3             m_Size  // 0x18
  private           UnityEngine.Vector3             m_Center  // 0x24
  private           System.Int32                    m_Area  // 0x30
  private           System.Collections.Generic.List<System.Int32>m_AffectedAgents  // 0x38
  private   static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume>s_NavMeshModifiers  // 0x0
METHODS:
  UnityEngine.Vector3 get_size()
  System.Void set_size(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_center()
  System.Void set_center(UnityEngine.Vector3 value)
  System.Int32 get_area()
  System.Void set_area(System.Int32 value)
  System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> get_activeModifiers()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean AffectsAgentType(System.Int32 agentTypeID)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.AI.CollectObjects
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.CollectObjects   All  // 0x0
  public    static  UnityEngine.AI.CollectObjects   Volume  // 0x0
  public    static  UnityEngine.AI.CollectObjects   Children  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AI.PartitioningMethod
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.PartitioningMethodLayers  // 0x0
  public    static  UnityEngine.AI.PartitioningMethodMonotone  // 0x0
  public    static  UnityEngine.AI.PartitioningMethodWatershed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshSurface
TYPE:  class
TOKEN: 0x2000008
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Int32                    m_AgentTypeID  // 0x18
  private           UnityEngine.AI.CollectObjects   m_CollectObjects  // 0x1C
  private           UnityEngine.Vector3             m_Size  // 0x20
  private           UnityEngine.Vector3             m_Center  // 0x2C
  private           UnityEngine.LayerMask           m_LayerMask  // 0x38
  private           System.String                   m_BlockTag  // 0x40
  private           UnityEngine.AI.PartitioningMethodm_PartitioningMethod  // 0x48
  private           System.Boolean                  m_FilterLowHangingObstacles  // 0x4C
  private           System.Boolean                  m_FilterLedgeSpans  // 0x4D
  private           System.Boolean                  m_FilterWalkableLowHeightSpans  // 0x4E
  private           System.Boolean                  m_OverrideMinRegionArea  // 0x4F
  private           System.Single                   m_MinRegionArea  // 0x50
  private           UnityEngine.AI.NavMeshCollectGeometrym_UseGeometry  // 0x54
  private           System.Int32                    m_DefaultArea  // 0x58
  private           System.Boolean                  m_IgnoreNavMeshAgent  // 0x5C
  private           System.Boolean                  m_IgnoreNavMeshObstacle  // 0x5D
  private           System.Boolean                  m_OverrideTileSize  // 0x5E
  private           System.Int32                    m_TileSize  // 0x60
  private           System.Boolean                  m_OverrideVoxelSize  // 0x64
  private           System.Single                   m_VoxelSize  // 0x68
  private           System.Boolean                  m_BuildHeightMesh  // 0x6C
  private           UnityEngine.AI.NavMeshData      m_NavMeshData  // 0x70
  private           UnityEngine.AI.NavMeshDataInstancem_NavMeshDataInstance  // 0x78
  private           UnityEngine.Vector3             m_LastPosition  // 0x7C
  private           UnityEngine.Quaternion          m_LastRotation  // 0x88
  private   static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface>s_NavMeshSurfaces  // 0x0
METHODS:
  System.Int32 get_agentTypeID()
  System.Void set_agentTypeID(System.Int32 value)
  UnityEngine.AI.CollectObjects get_collectObjects()
  System.Void set_collectObjects(UnityEngine.AI.CollectObjects value)
  UnityEngine.Vector3 get_size()
  System.Void set_size(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_center()
  System.Void set_center(UnityEngine.Vector3 value)
  UnityEngine.LayerMask get_layerMask()
  System.Void set_layerMask(UnityEngine.LayerMask value)
  System.String get_BlockTag()
  System.Void set_BlockTag(System.String value)
  UnityEngine.AI.PartitioningMethod get_partitioningMethod()
  System.Void set_partitioningMethod(UnityEngine.AI.PartitioningMethod value)
  System.Boolean get_filterLowHangingObstacles()
  System.Void set_filterLowHangingObstacles(System.Boolean value)
  System.Boolean get_filterLedgeSpans()
  System.Void set_filterLedgeSpans(System.Boolean value)
  System.Boolean get_filterWalkableLowHeightSpans()
  System.Void set_filterWalkableLowHeightSpans(System.Boolean value)
  System.Boolean get_overrideMinRegionArea()
  System.Void set_overrideMinRegionArea(System.Boolean value)
  System.Single get_minRegionArea()
  System.Void set_minRegionArea(System.Single value)
  UnityEngine.AI.NavMeshCollectGeometry get_useGeometry()
  System.Void set_useGeometry(UnityEngine.AI.NavMeshCollectGeometry value)
  System.Int32 get_defaultArea()
  System.Void set_defaultArea(System.Int32 value)
  System.Boolean get_ignoreNavMeshAgent()
  System.Void set_ignoreNavMeshAgent(System.Boolean value)
  System.Boolean get_ignoreNavMeshObstacle()
  System.Void set_ignoreNavMeshObstacle(System.Boolean value)
  System.Boolean get_overrideTileSize()
  System.Void set_overrideTileSize(System.Boolean value)
  System.Int32 get_tileSize()
  System.Void set_tileSize(System.Int32 value)
  System.Boolean get_overrideVoxelSize()
  System.Void set_overrideVoxelSize(System.Boolean value)
  System.Single get_voxelSize()
  System.Void set_voxelSize(System.Single value)
  System.Boolean get_buildHeightMesh()
  System.Void set_buildHeightMesh(System.Boolean value)
  UnityEngine.AI.NavMeshData get_navMeshData()
  System.Void set_navMeshData(UnityEngine.AI.NavMeshData value)
  System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface> get_activeSurfaces()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void AddData()
  System.Void RemoveData()
  UnityEngine.AI.NavMeshBuildSettings GetBuildSettings()
  System.Void BuildNavMesh()
  UnityEngine.AsyncOperation UpdateNavMesh(UnityEngine.AI.NavMeshData data)
  System.Boolean UpdateNavMeshSync(UnityEngine.AI.NavMeshData data)
  System.Void Register(UnityEngine.AI.NavMeshSurface surface)
  System.Void Unregister(UnityEngine.AI.NavMeshSurface surface)
  System.Void UpdateActive()
  System.Void AppendModifierVolumes(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>& sources)
  System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> CollectSources()
  UnityEngine.Vector3 Abs(UnityEngine.Vector3 v)
  UnityEngine.Bounds GetWorldBounds(UnityEngine.Matrix4x4 mat, UnityEngine.Bounds bounds)
  UnityEngine.Bounds CalculateWorldBounds(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources)
  System.Boolean HasTransformChanged()
  System.Void UpdateDataIfTransformChanged()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

