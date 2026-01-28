// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.PhysicsModule.dll
// Classes:  35
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: CollisionCallback
TYPE:  class
TOKEN: 0x2000017
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
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

CLASS: UnityEngine.RigidbodyConstraints
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RigidbodyConstraintsNone  // 0x0
  public    static  UnityEngine.RigidbodyConstraintsFreezePositionX  // 0x0
  public    static  UnityEngine.RigidbodyConstraintsFreezePositionY  // 0x0
  public    static  UnityEngine.RigidbodyConstraintsFreezePositionZ  // 0x0
  public    static  UnityEngine.RigidbodyConstraintsFreezeRotationX  // 0x0
  public    static  UnityEngine.RigidbodyConstraintsFreezeRotationY  // 0x0
  public    static  UnityEngine.RigidbodyConstraintsFreezeRotationZ  // 0x0
  public    static  UnityEngine.RigidbodyConstraintsFreezePosition  // 0x0
  public    static  UnityEngine.RigidbodyConstraintsFreezeRotation  // 0x0
  public    static  UnityEngine.RigidbodyConstraintsFreezeAll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ForceMode
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ForceMode           Force  // 0x0
  public    static  UnityEngine.ForceMode           Acceleration  // 0x0
  public    static  UnityEngine.ForceMode           Impulse  // 0x0
  public    static  UnityEngine.ForceMode           VelocityChange  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.MeshColliderCookingOptions
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.MeshColliderCookingOptionsNone  // 0x0
  public    static  UnityEngine.MeshColliderCookingOptionsInflateConvexMesh  // 0x0
  public    static  UnityEngine.MeshColliderCookingOptionsCookForFasterSimulation  // 0x0
  public    static  UnityEngine.MeshColliderCookingOptionsEnableMeshCleaning  // 0x0
  public    static  UnityEngine.MeshColliderCookingOptionsWeldColocatedVertices  // 0x0
  public    static  UnityEngine.MeshColliderCookingOptionsUseFastMidphase  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ColliderSurfaceType
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ColliderSurfaceType Default  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Concrete  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Wood  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Dirt  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Grass  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Stone  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Water  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Flesh  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Metal  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Crystal  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Rubber  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Sand  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Gravel  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Moss  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Custom  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Snow  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Mud  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Cardboard  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Plastic  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Ice  // 0x0
  public    static  UnityEngine.ColliderSurfaceType Wet  // 0x0
  public    static  UnityEngine.ColliderSurfaceType WaterV2  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RigidbodyInterpolation
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RigidbodyInterpolationNone  // 0x0
  public    static  UnityEngine.RigidbodyInterpolationInterpolate  // 0x0
  public    static  UnityEngine.RigidbodyInterpolationExtrapolate  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ControllerColliderHit
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private           UnityEngine.CharacterController m_Controller  // 0x10
  private           UnityEngine.Collider            m_Collider  // 0x18
  private           UnityEngine.Vector3             m_Point  // 0x20
  private           UnityEngine.Vector3             m_Normal  // 0x2C
  private           UnityEngine.Vector3             m_MoveDirection  // 0x38
  private           System.Single                   m_MoveLength  // 0x44
  private           System.Int32                    m_Push  // 0x48
METHODS:
  UnityEngine.GameObject get_gameObject()
  UnityEngine.Vector3 get_point()
END_CLASS

CLASS: UnityEngine.Collision
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private           UnityEngine.Vector3             m_Impulse  // 0x10
  private           UnityEngine.Vector3             m_RelativeVelocity  // 0x1C
  private           UnityEngine.Component           m_Body  // 0x28
  private           UnityEngine.Collider            m_Collider  // 0x30
  private           System.Int32                    m_ContactCount  // 0x38
  private           UnityEngine.ContactPoint[]      m_ReusedContacts  // 0x40
  private           UnityEngine.ContactPoint[]      m_LegacyContacts  // 0x48
METHODS:
  UnityEngine.Vector3 get_relativeVelocity()
  UnityEngine.Collider get_collider()
  UnityEngine.GameObject get_gameObject()
  UnityEngine.ContactPoint[] get_contacts()
  UnityEngine.Vector3 get_impulse()
END_CLASS

CLASS: UnityEngine.QueryTriggerInteraction
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.QueryTriggerInteractionUseGlobal  // 0x0
  public    static  UnityEngine.QueryTriggerInteractionIgnore  // 0x0
  public    static  UnityEngine.QueryTriggerInteractionCollide  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.CollisionDetectionMode
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.CollisionDetectionModeDiscrete  // 0x0
  public    static  UnityEngine.CollisionDetectionModeContinuous  // 0x0
  public    static  UnityEngine.CollisionDetectionModeContinuousDynamic  // 0x0
  public    static  UnityEngine.CollisionDetectionModeContinuousSpeculative  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ArticulationBody
TYPE:  class
TOKEN: 0x200000D
EXTENDS: Behaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Physics
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private   static  System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>>ContactModifyEvent  // 0x0
  private   static  System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>>ContactModifyEventCCD  // 0x8
  private   static  System.Single                   k_MaxFloatMinusEpsilon  // 0x0
  public    static  System.Int32                    IgnoreRaycastLayer  // 0x0
  public    static  System.Int32                    DefaultRaycastLayers  // 0x0
  public    static  System.Int32                    AllLayers  // 0x0
  public    static  System.Int32                    kIgnoreRaycastLayer  // 0x0
  public    static  System.Int32                    kDefaultRaycastLayers  // 0x0
  public    static  System.Int32                    kAllLayers  // 0x0
METHODS:
  System.Void add_ContactModifyEvent(System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value)
  System.Void remove_ContactModifyEvent(System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value)
  System.Void add_ContactModifyEventCCD(System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value)
  System.Void remove_ContactModifyEventCCD(System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value)
  System.Void OnSceneContactModify(UnityEngine.PhysicsScene scene, System.IntPtr buffer, System.Int32 count, System.Boolean isCCD)
  UnityEngine.Vector3 get_gravity()
  System.Void set_gravity(UnityEngine.Vector3 value)
  System.Single get_defaultContactOffset()
  System.Void set_defaultContactOffset(System.Single value)
  System.Single get_sleepThreshold()
  System.Void set_sleepThreshold(System.Single value)
  System.Boolean get_queriesHitTriggers()
  System.Void set_queriesHitTriggers(System.Boolean value)
  System.Boolean get_queriesHitBackfaces()
  System.Void set_queriesHitBackfaces(System.Boolean value)
  System.Single get_bounceThreshold()
  System.Void set_bounceThreshold(System.Single value)
  System.Single get_defaultMaxDepenetrationVelocity()
  System.Void set_defaultMaxDepenetrationVelocity(System.Single value)
  System.Int32 get_defaultSolverIterations()
  System.Void set_defaultSolverIterations(System.Int32 value)
  System.Int32 get_defaultSolverVelocityIterations()
  System.Void set_defaultSolverVelocityIterations(System.Int32 value)
  System.Single get_defaultMaxAngularSpeed()
  System.Void set_defaultMaxAngularSpeed(System.Single value)
  System.Boolean get_improvedPatchFriction()
  System.Void set_improvedPatchFriction(System.Boolean value)
  UnityEngine.PhysicsScene get_defaultPhysicsScene()
  System.Boolean get_logPhysXCheckError()
  System.Void set_logPhysXCheckError(System.Boolean value)
  System.Void ClearUnusedMemory()
  System.Void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2, System.Boolean ignore)
  System.Void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2)
  System.Void IgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2, System.Boolean ignore)
  System.Void ForceRebuildDynamicTree(System.Boolean rebuildStatic, System.Boolean rebuildDynamic)
  System.Void IgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2)
  System.Boolean GetIgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2)
  System.Boolean GetIgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  System.Boolean RaycastV2(UnityEngine.ECSColliderResultProxy proxy, UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  System.Boolean RaycastV2(UnityEngine.ECSColliderResultProxy proxy, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hit)
  UnityEngine.RaycastHit Internal_RaycastTestV2(UnityEngine.ECSColliderResultProxy collider, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit)
  System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance)
  System.Boolean Raycast(UnityEngine.Ray ray)
  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo)
  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32 layerMask)
  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask)
  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo)
  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance)
  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction)
  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance)
  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius)
  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance)
  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask)
  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance)
  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray)
  System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results)
  System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
  UnityEngine.RaycastHit[] Query_CapsuleCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance)
  UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction)
  UnityEngine.RaycastHit[] Query_SphereCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance)
  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction)
  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask)
  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance)
  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius)
  UnityEngine.Collider[] OverlapCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask)
  UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius)
  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask)
  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius)
  UnityEngine.Collider[] OverlapSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy CreateECSProxy(UnityEngine.Collider collider)
  UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask)
  UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius)
  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask)
  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius)
  System.Void Simulate_Internal(UnityEngine.PhysicsScene physicsScene, System.Single step)
  System.Void Simulate(System.Single step)
  System.Boolean get_autoSimulation()
  System.Void set_autoSimulation(System.Boolean value)
  System.Void SyncTransforms()
  System.Boolean get_autoSyncTransforms()
  System.Void set_autoSyncTransforms(System.Boolean value)
  System.Boolean get_reuseCollisionCallbacks()
  System.Void set_reuseCollisionCallbacks(System.Boolean value)
  System.Boolean Query_ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputePenetrationV2(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean ComputePenetrationV2(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputeCapsulePenetration(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean ComputeCapsulePenetration(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputeCapsulePenetrationV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean ComputeCapsulePenetrationV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputeSpherePenetrationV2(UnityEngine.Vector3 center, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean ComputeSpherePenetrationV2(UnityEngine.Vector3 center, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputeBoxPenetrationV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtent, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean ComputeBoxPenetrationV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtent, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean IsSimulatedThisFrame_Internal()
  System.Boolean IsSimulatedThisFrame()
  System.Void SetForceSimulateThisFrame_Internal(System.Boolean force)
  System.Void SetForceSimulateThisFrame(System.Boolean force)
  System.Void SetFastSimulate_Internal(System.Boolean fast)
  System.Void SetFastSimulate(System.Boolean fast)
  UnityEngine.Vector3 Query_ClosestPoint(UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point)
  UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point, UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  UnityEngine.Vector3 Query_ClosestPointV2(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point)
  UnityEngine.Vector3 ClosestPointV2(UnityEngine.Vector3 point, UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  UnityEngine.Vector3 Query_TryGetClosestPoint(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point, System.Boolean& resultIsValid)
  System.Boolean TryGetClosestPoint(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point, UnityEngine.Vector3& result)
  System.Single get_interCollisionDistance()
  System.Void set_interCollisionDistance(System.Single value)
  System.Single get_interCollisionStiffness()
  System.Void set_interCollisionStiffness(System.Single value)
  System.Boolean get_interCollisionSettingsToggle()
  System.Void set_interCollisionSettingsToggle(System.Boolean value)
  UnityEngine.Vector3 get_clothGravity()
  System.Void set_clothGravity(UnityEngine.Vector3 value)
  System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask)
  System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results)
  System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask)
  System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results)
  System.Boolean CheckSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask)
  System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius)
  System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance, System.Int32 layerMask)
  System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance)
  System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
  System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results)
  System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
  System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results)
  System.Boolean CheckCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask)
  System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius)
  System.Boolean CheckBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask)
  System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation)
  System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents)
  UnityEngine.Collider[] OverlapBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask)
  UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation)
  UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents)
  System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask)
  System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation)
  System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results)
  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask)
  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation)
  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents)
  System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask)
  System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation)
  System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results)
  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation)
  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance)
  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask)
  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
  UnityEngine.RaycastHit[] Internal_BoxCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask)
  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance)
  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation)
  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction)
  System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask)
  System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results)
  System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask)
  System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results)
  System.Void Internal_RebuildBroadphaseRegions(UnityEngine.Bounds bounds, System.Int32 subdivisions)
  System.Void RebuildBroadphaseRegions(UnityEngine.Bounds worldBounds, System.Int32 subdivisions)
  System.Void BakeMesh(System.Int32 meshID, System.Boolean convex)
  System.Single get_minPenetrationForPenalty()
  System.Void set_minPenetrationForPenalty(System.Single value)
  System.Single get_bounceTreshold()
  System.Void set_bounceTreshold(System.Single value)
  System.Single get_sleepVelocity()
  System.Void set_sleepVelocity(System.Single value)
  System.Single get_sleepAngularVelocity()
  System.Void set_sleepAngularVelocity(System.Single value)
  System.Single get_maxAngularVelocity()
  System.Void set_maxAngularVelocity(System.Single value)
  System.Int32 get_solverIterationCount()
  System.Void set_solverIterationCount(System.Int32 value)
  System.Int32 get_solverVelocityIterationCount()
  System.Void set_solverVelocityIterationCount(System.Int32 value)
  System.Single get_penetrationPenaltyForce()
  System.Void set_penetrationPenaltyForce(System.Single value)
  System.Void .ctor()
  System.Void get_gravity_Injected(UnityEngine.Vector3& ret)
  System.Void set_gravity_Injected(UnityEngine.Vector3& value)
  System.Void get_defaultPhysicsScene_Injected(UnityEngine.PhysicsScene& ret)
  System.Void Internal_RaycastTestV2_Injected(UnityEngine.ECSColliderResultProxy& collider, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  UnityEngine.RaycastHit[] Internal_RaycastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] Query_CapsuleCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] Query_SphereCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.Collider[] OverlapCapsule_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.Collider[] OverlapSphere_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Void Simulate_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, System.Single step)
  System.Boolean Query_ComputePenetration_Injected(UnityEngine.Collider colliderA, UnityEngine.Vector3& positionA, UnityEngine.Quaternion& rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputePenetrationV2_Injected(UnityEngine.ECSColliderResultProxy& colliderA, UnityEngine.Vector3& positionA, UnityEngine.Quaternion& rotationA, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputeCapsulePenetration_Injected(UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputeCapsulePenetrationV2_Injected(UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputeSpherePenetrationV2_Injected(UnityEngine.Vector3& center, System.Single radius, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Boolean Query_ComputeBoxPenetrationV2_Injected(UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtent, UnityEngine.Quaternion& rotationA, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  System.Void Query_ClosestPoint_Injected(UnityEngine.Collider collider, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, UnityEngine.Vector3& ret)
  System.Void Query_ClosestPointV2_Injected(UnityEngine.ECSColliderResultProxy& colliderProxy, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, UnityEngine.Vector3& ret)
  System.Void Query_TryGetClosestPoint_Injected(UnityEngine.ECSColliderResultProxy& colliderProxy, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret)
  System.Void get_clothGravity_Injected(UnityEngine.Vector3& ret)
  System.Void set_clothGravity_Injected(UnityEngine.Vector3& value)
  System.Boolean CheckSphere_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CheckCapsule_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& start, UnityEngine.Vector3& end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CheckBox_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.Collider[] OverlapBox_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] Internal_BoxCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.Quaternion& orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Void Internal_RebuildBroadphaseRegions_Injected(UnityEngine.Bounds& bounds, System.Int32 subdivisions)
END_CLASS

CLASS: UnityEngine.ModifiableContactPair
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  private           System.IntPtr                   actor  // 0x10
  private           System.IntPtr                   otherActor  // 0x18
  private           System.IntPtr                   shape  // 0x20
  private           System.IntPtr                   otherShape  // 0x28
  public            UnityEngine.Quaternion          rotation  // 0x30
  public            UnityEngine.Vector3             position  // 0x40
  public            UnityEngine.Quaternion          otherRotation  // 0x4C
  public            UnityEngine.Vector3             otherPosition  // 0x5C
  private           System.Int32                    numContacts  // 0x68
  private           System.IntPtr                   contacts  // 0x70
METHODS:
END_CLASS

CLASS: UnityEngine.PhysicMaterial
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_CreateDynamicsMaterial(UnityEngine.PhysicMaterial mat, System.String name)
END_CLASS

CLASS: UnityEngine.ECSColliderResultProxy
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  private           System.IntPtr                   m_Actor  // 0x10
  private           System.Int32                    m_EcsId  // 0x18
  private           System.UInt32                   m_EcsVersion  // 0x1C
  private           System.Int32                    m_Collider  // 0x20
  private           System.Int32                    m_ComponentIndex  // 0x24
  private   static readonly UnityEngine.ECSColliderResultProxyINVALID_PROXY  // 0x0
METHODS:
  System.Void SetColliderAndSetIndex(System.Int32 colliderInstanceID)
  System.Void SetComponentIndex(System.Int32 index)
  System.Void SetActor(System.IntPtr actor)
  System.Void SetEcsId(System.Int32 id)
  System.Void SetEcsVersion(System.UInt32 version)
  System.Int32 get_componentIndex()
  UnityEngine.HyperGryph.ECS.Entity get_colliderEntity()
  System.Int32 get_ecsId()
  System.UInt32 get_ecsVersion()
  UnityEngine.ECSColliderResultProxy get_invalid()
  UnityEngine.Collider get_collider()
  System.Int32 get_colliderInstanceId()
  System.Boolean get_bIsECS()
  System.Int32 get_tagConfig()
  System.Boolean IsValid()
  System.Boolean get_isTrigger()
  System.Int32 get_layer()
  UnityEngine.Transform get_transform()
  UnityEngine.Vector3 get_transformPosition()
  UnityEngine.Quaternion get_transformRotation()
  UnityEngine.Vector3 get_transformLossyScale()
  UnityEngine.Vector3 get_shapePosition()
  UnityEngine.Bounds get_bounds()
  System.Int32 get_colliderOptions()
  UnityEngine.ColliderSurfaceType get_surfaceType()
  System.String GetColliderGoName()
  UnityEngine.ECSColliderType get_colliderType()
  UnityEngine.GameObject get_gameObject()
  System.Int32 GetFactoryBuildingIdentifier()
  System.Boolean get_hasComplexMesh()
  System.Boolean TryGetClosestPoint(UnityEngine.Vector3 point, UnityEngine.Vector3& result)
  UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position)
  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  System.Boolean op_Equality(UnityEngine.ECSColliderResultProxy left, UnityEngine.ECSColliderResultProxy right)
  System.Boolean op_Inequality(UnityEngine.ECSColliderResultProxy left, UnityEngine.ECSColliderResultProxy right)
  System.Boolean Equals(UnityEngine.ECSColliderResultProxy other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean CompareTag(System.Int32 tagValue)
  System.Boolean IsSameCollider(UnityEngine.Collider otherCollider)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.RaycastHit
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  private           UnityEngine.Vector3             m_Point  // 0x10
  private           UnityEngine.Vector3             m_Normal  // 0x1C
  private           System.UInt32                   m_FaceID  // 0x28
  private           System.Single                   m_Distance  // 0x2C
  private           UnityEngine.Vector2             m_UV  // 0x30
  private           System.Int32                    m_Collider  // 0x38
  private           System.Int32                    m_Index  // 0x3C
  private           System.Int32                    m_EcsId  // 0x40
  private           System.UInt32                   m_EcsVersion  // 0x44
  private           System.IntPtr                   m_Actor  // 0x48
METHODS:
  System.Int32 get_ecsId()
  System.UInt32 get_ecsVersion()
  System.Boolean get_IsECSCollider()
  UnityEngine.Collider get_collider()
  System.Int32 get_colliderInstanceID()
  UnityEngine.Collider get_editorCollider()
  UnityEngine.ECSColliderResultProxy get_colliderProxy()
  UnityEngine.Vector3 get_point()
  System.Void set_point(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_normal()
  System.Void set_normal(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_barycentricCoordinate()
  System.Void set_barycentricCoordinate(UnityEngine.Vector3 value)
  System.Single get_distance()
  System.Void set_distance(System.Single value)
  System.Int32 get_triangleIndex()
  System.Int32 get_componentIndex()
  UnityEngine.Vector2 CalculateRaycastTexCoord(UnityEngine.Collider collider, System.Int32 m_Index, UnityEngine.Vector2 uv, UnityEngine.Vector3 pos, System.UInt32 face, System.Int32 textcoord)
  UnityEngine.Vector2 get_textureCoord()
  UnityEngine.Vector2 get_textureCoord2()
  UnityEngine.Transform get_transform()
  UnityEngine.Vector3 get_shapePosition()
  UnityEngine.Quaternion get_shapeRotation()
  UnityEngine.Vector3 get_position()
  UnityEngine.Quaternion get_rotation()
  UnityEngine.Vector3 get_scale()
  UnityEngine.Rigidbody get_rigidbody()
  UnityEngine.ArticulationBody get_articulationBody()
  UnityEngine.Vector2 get_lightmapCoord()
  UnityEngine.Vector2 get_textureCoord1()
  System.Void CalculateRaycastTexCoord_Injected(UnityEngine.Collider collider, System.Int32 m_Index, UnityEngine.Vector2& uv, UnityEngine.Vector3& pos, System.UInt32 face, System.Int32 textcoord, UnityEngine.Vector2& ret)
END_CLASS

CLASS: UnityEngine.Rigidbody
TYPE:  class
TOKEN: 0x2000013
EXTENDS: Component
FIELDS:
METHODS:
  UnityEngine.Vector3 get_velocity()
  System.Void set_velocity(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_angularVelocity()
  System.Void set_angularVelocity(UnityEngine.Vector3 value)
  System.Single get_drag()
  System.Void set_drag(System.Single value)
  System.Single get_angularDrag()
  System.Void set_angularDrag(System.Single value)
  System.Single get_mass()
  System.Void set_mass(System.Single value)
  System.Void SetDensity(System.Single density)
  System.Boolean get_useGravity()
  System.Void set_useGravity(System.Boolean value)
  System.Single get_maxDepenetrationVelocity()
  System.Void set_maxDepenetrationVelocity(System.Single value)
  System.Boolean get_isKinematic()
  System.Void set_isKinematic(System.Boolean value)
  System.Boolean get_freezeRotation()
  System.Void set_freezeRotation(System.Boolean value)
  UnityEngine.RigidbodyConstraints get_constraints()
  System.Void set_constraints(UnityEngine.RigidbodyConstraints value)
  UnityEngine.CollisionDetectionMode get_collisionDetectionMode()
  System.Void set_collisionDetectionMode(UnityEngine.CollisionDetectionMode value)
  UnityEngine.Vector3 get_centerOfMass()
  System.Void set_centerOfMass(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_worldCenterOfMass()
  UnityEngine.Quaternion get_inertiaTensorRotation()
  System.Void set_inertiaTensorRotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_inertiaTensor()
  System.Void set_inertiaTensor(UnityEngine.Vector3 value)
  System.Boolean get_detectCollisions()
  System.Void set_detectCollisions(System.Boolean value)
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  UnityEngine.RigidbodyInterpolation get_interpolation()
  System.Void set_interpolation(UnityEngine.RigidbodyInterpolation value)
  System.Int32 get_solverIterations()
  System.Void set_solverIterations(System.Int32 value)
  System.Single get_sleepThreshold()
  System.Void set_sleepThreshold(System.Single value)
  System.Single get_maxAngularVelocity()
  System.Void set_maxAngularVelocity(System.Single value)
  System.Void MovePosition(UnityEngine.Vector3 position)
  System.Void MoveRotation(UnityEngine.Quaternion rot)
  System.Void Sleep()
  System.Boolean IsSleeping()
  System.Void WakeUp()
  System.Void ResetCenterOfMass()
  System.Void ResetInertiaTensor()
  UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3 relativePoint)
  UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 worldPoint)
  System.Int32 get_solverVelocityIterations()
  System.Void set_solverVelocityIterations(System.Int32 value)
  System.Void AddForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
  System.Void AddForce(UnityEngine.Vector3 force)
  System.Void AddForce(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode)
  System.Void AddForce(System.Single x, System.Single y, System.Single z)
  System.Void AddRelativeForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
  System.Void AddRelativeForce(UnityEngine.Vector3 force)
  System.Void AddRelativeForce(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode)
  System.Void AddRelativeForce(System.Single x, System.Single y, System.Single z)
  System.Void AddTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
  System.Void AddTorque(UnityEngine.Vector3 torque)
  System.Void AddTorque(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode)
  System.Void AddTorque(System.Single x, System.Single y, System.Single z)
  System.Void AddRelativeTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
  System.Void AddRelativeTorque(UnityEngine.Vector3 torque)
  System.Void AddRelativeTorque(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode)
  System.Void AddRelativeTorque(System.Single x, System.Single y, System.Single z)
  System.Void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode)
  System.Void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position)
  System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius, System.Single upwardsModifier, UnityEngine.ForceMode mode)
  System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius, System.Single upwardsModifier)
  System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius)
  System.Void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, UnityEngine.Vector3& outPos, System.Single& distance)
  UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position)
  UnityEngine.RaycastHit SweepTest(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.Boolean& hasHit)
  System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  UnityEngine.RaycastHit[] Internal_SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance)
  UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction)
  System.Single get_sleepVelocity()
  System.Void set_sleepVelocity(System.Single value)
  System.Single get_sleepAngularVelocity()
  System.Void set_sleepAngularVelocity(System.Single value)
  System.Void SetMaxAngularVelocity(System.Single a)
  System.Boolean get_useConeFriction()
  System.Void set_useConeFriction(System.Boolean value)
  System.Int32 get_solverIterationCount()
  System.Void set_solverIterationCount(System.Int32 value)
  System.Int32 get_solverVelocityIterationCount()
  System.Void set_solverVelocityIterationCount(System.Int32 value)
  System.Void .ctor()
  System.Void get_velocity_Injected(UnityEngine.Vector3& ret)
  System.Void set_velocity_Injected(UnityEngine.Vector3& value)
  System.Void get_angularVelocity_Injected(UnityEngine.Vector3& ret)
  System.Void set_angularVelocity_Injected(UnityEngine.Vector3& value)
  System.Void get_centerOfMass_Injected(UnityEngine.Vector3& ret)
  System.Void set_centerOfMass_Injected(UnityEngine.Vector3& value)
  System.Void get_worldCenterOfMass_Injected(UnityEngine.Vector3& ret)
  System.Void get_inertiaTensorRotation_Injected(UnityEngine.Quaternion& ret)
  System.Void set_inertiaTensorRotation_Injected(UnityEngine.Quaternion& value)
  System.Void get_inertiaTensor_Injected(UnityEngine.Vector3& ret)
  System.Void set_inertiaTensor_Injected(UnityEngine.Vector3& value)
  System.Void get_position_Injected(UnityEngine.Vector3& ret)
  System.Void set_position_Injected(UnityEngine.Vector3& value)
  System.Void get_rotation_Injected(UnityEngine.Quaternion& ret)
  System.Void set_rotation_Injected(UnityEngine.Quaternion& value)
  System.Void MovePosition_Injected(UnityEngine.Vector3& position)
  System.Void MoveRotation_Injected(UnityEngine.Quaternion& rot)
  System.Void GetRelativePointVelocity_Injected(UnityEngine.Vector3& relativePoint, UnityEngine.Vector3& ret)
  System.Void GetPointVelocity_Injected(UnityEngine.Vector3& worldPoint, UnityEngine.Vector3& ret)
  System.Void AddForce_Injected(UnityEngine.Vector3& force, UnityEngine.ForceMode mode)
  System.Void AddRelativeForce_Injected(UnityEngine.Vector3& force, UnityEngine.ForceMode mode)
  System.Void AddTorque_Injected(UnityEngine.Vector3& torque, UnityEngine.ForceMode mode)
  System.Void AddRelativeTorque_Injected(UnityEngine.Vector3& torque, UnityEngine.ForceMode mode)
  System.Void AddForceAtPosition_Injected(UnityEngine.Vector3& force, UnityEngine.Vector3& position, UnityEngine.ForceMode mode)
  System.Void AddExplosionForce_Injected(System.Single explosionForce, UnityEngine.Vector3& explosionPosition, System.Single explosionRadius, System.Single upwardsModifier, UnityEngine.ForceMode mode)
  System.Void Internal_ClosestPointOnBounds_Injected(UnityEngine.Vector3& point, UnityEngine.Vector3& outPos, System.Single& distance)
  System.Void SweepTest_Injected(UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  UnityEngine.RaycastHit[] Internal_SweepTestAll_Injected(UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
END_CLASS

CLASS: UnityEngine.ECSColliderType
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ECSColliderType     Default  // 0x0
  public    static  UnityEngine.ECSColliderType     BoxCollider  // 0x0
  public    static  UnityEngine.ECSColliderType     CapsuleCollider  // 0x0
  public    static  UnityEngine.ECSColliderType     SphereCollider  // 0x0
  public    static  UnityEngine.ECSColliderType     MeshCollider  // 0x0
  public    static  UnityEngine.ECSColliderType     MultiCollider  // 0x0
  public    static  UnityEngine.ECSColliderType     TerrainCollider  // 0x0
  public    static  UnityEngine.ECSColliderType     ECSCollider  // 0x0
  public    static  UnityEngine.ECSColliderType     Invalid  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Collider
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Component
FIELDS:
METHODS:
  System.Boolean get_enabled()
  System.Void set_enabled(System.Boolean value)
  UnityEngine.Rigidbody get_attachedRigidbody()
  UnityEngine.ArticulationBody get_attachedArticulationBody()
  System.Boolean get_isTrigger()
  System.Void set_isTrigger(System.Boolean value)
  System.Boolean get_enableDither()
  System.Void set_enableDither(System.Boolean value)
  System.Single get_contactOffset()
  System.Void set_contactOffset(System.Single value)
  UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position)
  UnityEngine.Bounds get_bounds()
  System.Boolean get_hasModifiableContacts()
  System.Void set_hasModifiableContacts(System.Boolean value)
  UnityEngine.ColliderSurfaceType get_surfaceType()
  System.Void set_surfaceType(UnityEngine.ColliderSurfaceType value)
  System.Int32 get_tagConfig()
  System.Void set_tagConfig(System.Int32 value)
  System.Int32 get_colliderOptions()
  System.Void set_colliderOptions(System.Int32 value)
  System.IntPtr GetActor()
  System.Int32 GetComponentIndex()
  System.Int32 GetFactoryBuildingIdentifier()
  System.Void SetFactoryBuildingIdentifier(System.Int32 value)
  UnityEngine.PhysicMaterial get_sharedMaterial()
  System.Void set_sharedMaterial(UnityEngine.PhysicMaterial value)
  UnityEngine.PhysicMaterial get_material()
  System.Void set_material(UnityEngine.PhysicMaterial value)
  UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Boolean& hasHit)
  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  System.Void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, UnityEngine.Vector3& outPos, System.Single& distance)
  UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position)
  System.Boolean CanColliderComputeClosestPoint()
  UnityEngine.Vector3 TryGetClosestPoint_Internal(UnityEngine.Vector3 point, System.Boolean& resultIsValid)
  System.Boolean TryGetClosestPoint(UnityEngine.Vector3 point, UnityEngine.Vector3& result)
  System.Void .ctor()
  System.Void ClosestPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
  System.Void get_bounds_Injected(UnityEngine.Bounds& ret)
  System.Void Raycast_Injected(UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  System.Void Internal_ClosestPointOnBounds_Injected(UnityEngine.Vector3& point, UnityEngine.Vector3& outPos, System.Single& distance)
  System.Void TryGetClosestPoint_Internal_Injected(UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.ECSCollider
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           System.IntPtr                   self  // 0x10
  public    static  UnityEngine.ECSCollider.CollisionCallbackcollisionEnterCallback  // 0x0
  public    static  UnityEngine.ECSCollider.CollisionCallbackcollisionStayCallback  // 0x8
  public    static  UnityEngine.ECSCollider.CollisionCallbackcollisionExitCallback  // 0x10
  public    static  UnityEngine.ECSCollider.CollisionCallbacktriggerEnterCallback  // 0x18
  public    static  UnityEngine.ECSCollider.CollisionCallbacktriggerStayCallback  // 0x20
  public    static  UnityEngine.ECSCollider.CollisionCallbacktriggerExitCallback  // 0x28
METHODS:
  System.IntPtr CreateActor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.UInt32 layer, System.Int32 tagInt, System.Boolean movable, System.Boolean enableDither)
  System.Void DestroyActor(System.Int32 id, System.UInt32 version)
  System.IntPtr Decode(System.IntPtr data, System.Int32 length, System.IntPtr meshes, System.Int32 meshesCount, UnityEngine.Texture2D heightmaps)
  System.IntPtr Decode(System.IntPtr data, System.Int32 length, Unity.Collections.NativeArray<System.Int32> meshInstanceIds, UnityEngine.Texture2D heightmap)
  System.Void RecordEntity(System.IntPtr actor, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Int32 GetId(System.IntPtr actor)
  System.UInt32 GetVersion(System.IntPtr actor)
  System.Boolean IsValid(System.Int32 id, System.UInt32 version, System.IntPtr actor)
  UnityEngine.HyperGryph.ECS.Entity GetEntity(System.Int32 id, System.UInt32 version)
  UnityEngine.Vector3 GetPosition(System.Int32 ecsId, System.UInt32 ecsVersion)
  UnityEngine.Vector3 GetShapePosition(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  System.Void SetPosition(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 position)
  UnityEngine.Quaternion GetShapeRotation(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  UnityEngine.Quaternion GetRotation(System.Int32 ecsId, System.UInt32 ecsVersion)
  System.Void SetRotation(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion rotation)
  System.Void AttachBox(System.Int32 id, System.UInt32 version, UnityEngine.Vector3 halfExtent, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation, System.Int32 surfaceType, System.Int32 colliderOption, System.Int32 tag, System.Boolean isTrigger, System.Boolean isPrimitive)
  System.Boolean HasComplexMesh(System.Int32 id, System.UInt32 version)
  UnityEngine.RaycastHit Raycast_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit)
  System.Boolean Raycast(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hitInfo)
  UnityEngine.RaycastHit RaycastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit)
  System.Boolean RaycastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hitInfo)
  UnityEngine.RaycastHit CapsuleCastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit)
  System.Boolean CapsuleCastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo)
  UnityEngine.RaycastHit SphereCastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit)
  System.Boolean SphereCastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo)
  System.Boolean CanColliderComputeClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion)
  UnityEngine.ColliderSurfaceType GetSurfaceTypeAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  System.Int32 GetColliderOptionAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  System.Int32 GetTagConfigAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  System.Boolean GetIsTrigger(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  UnityEngine.Bounds GetBounds(System.Int32 ecsId, System.UInt32 ecsVersion)
  UnityEngine.Vector3 TryGetClosestPoint_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 point, System.Boolean& resultIsValid)
  System.Boolean TryGetClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 point, UnityEngine.Vector3& result)
  UnityEngine.Vector3 ClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 position)
  System.Boolean CompareTag(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 tagValue)
  System.Int32 GetLayer(System.Int32 ecsId, System.UInt32 ecsVersion)
  System.Int32 GetFactoryBuildingIdentifier(System.Int32 ecsId, System.UInt32 ecsVersion)
  System.Void SetFactoryBuildingIdentifier(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 identifier)
  System.Void OnCollisionEnterV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  System.Void OnCollisionStayV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  System.Void OnCollisionExitV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  System.Void OnTriggerEnterV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  System.Void OnTriggerStayV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  System.Void OnTriggerExitV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  System.Void ToggleCollision(System.Int32 id, System.UInt32 version, System.Boolean enableCollision)
  System.IntPtr CreateActor_Injected(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, System.UInt32 layer, System.Int32 tagInt, System.Boolean movable, System.Boolean enableDither)
  System.Void RecordEntity_Injected(System.IntPtr actor, UnityEngine.HyperGryph.ECS.Entity& entity)
  System.Void GetEntity_Injected(System.Int32 id, System.UInt32 version, UnityEngine.HyperGryph.ECS.Entity& ret)
  System.Void GetPosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& ret)
  System.Void GetShapePosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index, UnityEngine.Vector3& ret)
  System.Void SetPosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& position)
  System.Void GetShapeRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index, UnityEngine.Quaternion& ret)
  System.Void GetRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion& ret)
  System.Void SetRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion& rotation)
  System.Void AttachBox_Injected(System.Int32 id, System.UInt32 version, UnityEngine.Vector3& halfExtent, UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation, System.Int32 surfaceType, System.Int32 colliderOption, System.Int32 tag, System.Boolean isTrigger, System.Boolean isPrimitive)
  System.Void Raycast_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  System.Void RaycastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  System.Void CapsuleCastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  System.Void SphereCastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& center, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  System.Void GetBounds_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Bounds& ret)
  System.Void TryGetClosestPoint_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret)
  System.Void ClosestPoint_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.CharacterController
TYPE:  class
TOKEN: 0x2000018
EXTENDS: Collider
FIELDS:
METHODS:
  System.Boolean get_isGrounded()
END_CLASS

CLASS: UnityEngine.MultiCollider
TYPE:  class
TOKEN: 0x2000019
EXTENDS: Collider
FIELDS:
METHODS:
  System.Void AppendBoxCollider(UnityEngine.BoxCollider boxCollider)
  System.Void AppendCapsuleCollider(UnityEngine.CapsuleCollider collider)
  System.Void AppendSphereCollider(UnityEngine.SphereCollider collider)
  UnityEngine.ColliderSurfaceType GetSurfaceTypeAt(System.Int32 index)
  System.Int32 GetTagConfigAt(System.Int32 index)
  System.Int32 GetGameplayOptionAt(System.Int32 index)
  System.Boolean GetIsTriggerAt(System.Int32 index)
  UnityEngine.Mesh get_ComplexMesh()
  System.Boolean RaycastComplexMesh(UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  UnityEngine.RaycastHit CapsuleCastComplexMesh_Internal(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit)
  System.Boolean CapsuleCastComplexMesh(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  UnityEngine.RaycastHit SphereCastComplexMesh_Internal(UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit)
  System.Boolean SphereCastComplexMesh(UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  System.Boolean RaycastComplexMesh_Injected(UnityEngine.Ray& ray, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  System.Void CapsuleCastComplexMesh_Internal_Injected(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  System.Void SphereCastComplexMesh_Internal_Injected(UnityEngine.Vector3& center, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
END_CLASS

CLASS: UnityEngine.MeshCollider
TYPE:  class
TOKEN: 0x200001A
EXTENDS: Collider
FIELDS:
METHODS:
  UnityEngine.Mesh get_sharedMesh()
  System.Void set_sharedMesh(UnityEngine.Mesh value)
  System.Boolean get_convex()
  System.Void set_convex(System.Boolean value)
  UnityEngine.MeshColliderCookingOptions get_cookingOptions()
  System.Void set_cookingOptions(UnityEngine.MeshColliderCookingOptions value)
  System.Boolean NeedsReadWriteEnabled()
  System.Boolean get_smoothSphereCollisions()
  System.Void set_smoothSphereCollisions(System.Boolean value)
  System.Single get_skinWidth()
  System.Void set_skinWidth(System.Single value)
  System.Boolean get_inflateMesh()
  System.Void set_inflateMesh(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.CapsuleCollider
TYPE:  class
TOKEN: 0x200001B
EXTENDS: Collider
FIELDS:
METHODS:
  UnityEngine.Vector3 get_center()
  System.Void set_center(UnityEngine.Vector3 value)
  System.Single get_radius()
  System.Void set_radius(System.Single value)
  System.Single get_height()
  System.Void set_height(System.Single value)
  System.Int32 get_direction()
  System.Void set_direction(System.Int32 value)
  System.Void get_center_Injected(UnityEngine.Vector3& ret)
  System.Void set_center_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.BoxCollider
TYPE:  class
TOKEN: 0x200001C
EXTENDS: Collider
FIELDS:
METHODS:
  UnityEngine.Vector3 get_center()
  System.Void set_center(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_size()
  System.Void set_size(UnityEngine.Vector3 value)
  System.Void get_center_Injected(UnityEngine.Vector3& ret)
  System.Void set_center_Injected(UnityEngine.Vector3& value)
  System.Void get_size_Injected(UnityEngine.Vector3& ret)
  System.Void set_size_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.SphereCollider
TYPE:  class
TOKEN: 0x200001D
EXTENDS: Collider
FIELDS:
METHODS:
  UnityEngine.Vector3 get_center()
  System.Void set_center(UnityEngine.Vector3 value)
  System.Single get_radius()
  System.Void set_radius(System.Single value)
  System.Void get_center_Injected(UnityEngine.Vector3& ret)
  System.Void set_center_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.Joint
TYPE:  class
TOKEN: 0x200001E
EXTENDS: Component
FIELDS:
METHODS:
  UnityEngine.Rigidbody get_connectedBody()
  System.Void set_connectedAnchor(UnityEngine.Vector3 value)
  System.Void set_connectedAnchor_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.ContactPoint
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  private           UnityEngine.Vector3             m_Point  // 0x10
  private           UnityEngine.Vector3             m_Normal  // 0x1C
  private           System.Int32                    m_ThisColliderInstanceID  // 0x28
  private           System.Int32                    m_OtherColliderInstanceID  // 0x2C
  private           System.Single                   m_Separation  // 0x30
METHODS:
  UnityEngine.Vector3 get_point()
  UnityEngine.Vector3 get_normal()
  UnityEngine.Collider get_thisCollider()
  UnityEngine.Collider get_otherCollider()
  UnityEngine.Collider GetColliderByInstanceID(System.Int32 instanceID)
END_CLASS

CLASS: UnityEngine.PhysicsScene
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  private           System.Int32                    m_Handle  // 0x10
METHODS:
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.PhysicsScene other)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Query_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Internal_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_CapsuleCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_CapsuleCastNonAllocV2(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 diretion, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 CapsuleCastV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapCapsuleNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapCapsuleNonAlloc_InternalV2(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Query_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Internal_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_SphereCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapSphereNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapSphere(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapSphereNonAllocV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Query_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, UnityEngine.RaycastHit& outHit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Internal_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapBoxNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapBoxNonAllocV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_BoxCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Internal_RaycastTest_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Internal_Raycast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, UnityEngine.RaycastHit& hit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_RaycastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Query_CapsuleCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_CapsuleCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_CapsuleCastNonAllocV2_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& diretion, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapCapsuleNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapCapsuleNonAlloc_InternalV2_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Query_SphereCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_SphereCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapSphereNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapSphereNonAllocV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Boolean Query_BoxCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.Quaternion& orientation, System.Single maxDistance, UnityEngine.RaycastHit& outHit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapBoxNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion& orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 OverlapBoxNonAllocV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion& orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.Int32 Internal_BoxCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion& orientation, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
END_CLASS

CLASS: UnityEngine.QueryParameters
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    layerMask  // 0x10
  public            System.Boolean                  hitMultipleFaces  // 0x14
  public            System.Boolean                  hitBackfaces  // 0x15
  public            UnityEngine.QueryTriggerInteractionhitTriggers  // 0x18
METHODS:
  System.Void .ctor(System.Int32 layerMask, System.Boolean hitMultipleFaces, UnityEngine.QueryTriggerInteraction hitTriggers, System.Boolean hitBackfaces)
END_CLASS

CLASS: UnityEngine.RaycastCommand
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  private           UnityEngine.Vector3             <from>k__BackingField  // 0x10
  private           UnityEngine.Vector3             <direction>k__BackingField  // 0x1C
  private           System.Single                   <distance>k__BackingField  // 0x28
  private           UnityEngine.PhysicsScene        <physicsScene>k__BackingField  // 0x2C
  public            UnityEngine.QueryParameters     queryParameters  // 0x30
METHODS:
  System.Void .ctor(UnityEngine.Vector3 from, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, System.Single distance)
  UnityEngine.Vector3 get_from()
  System.Void set_from(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_direction()
  System.Void set_direction(UnityEngine.Vector3 value)
  System.Single get_distance()
  System.Void set_distance(System.Single value)
  System.Void set_physicsScene(UnityEngine.PhysicsScene value)
  Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ScheduleRaycastBatch(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits)
  System.Void ScheduleRaycastBatch_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle& ret)
END_CLASS

CLASS: UnityEngine.BoxcastCommand
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  private           UnityEngine.Vector3             <center>k__BackingField  // 0x10
  private           UnityEngine.Vector3             <halfExtents>k__BackingField  // 0x1C
  private           UnityEngine.Quaternion          <orientation>k__BackingField  // 0x28
  private           UnityEngine.Vector3             <direction>k__BackingField  // 0x38
  private           System.Single                   <distance>k__BackingField  // 0x44
  private           UnityEngine.PhysicsScene        <physicsScene>k__BackingField  // 0x48
  public            UnityEngine.QueryParameters     queryParameters  // 0x4C
METHODS:
  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, System.Single distance)
  System.Void set_center(UnityEngine.Vector3 value)
  System.Void set_halfExtents(UnityEngine.Vector3 value)
  System.Void set_orientation(UnityEngine.Quaternion value)
  System.Void set_direction(UnityEngine.Vector3 value)
  System.Void set_distance(System.Single value)
  System.Void set_physicsScene(UnityEngine.PhysicsScene value)
  Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ScheduleBoxcastBatch(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits)
  System.Void ScheduleBoxcastBatch_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle& ret)
END_CLASS

