// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.Physics2DModule.dll
// Classes:  16
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngine.PhysicsScene2D
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  private           System.Int32                    m_Handle  // 0x10
METHODS:
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.PhysicsScene2D other)
  UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter)
  UnityEngine.RaycastHit2D Linecast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter)
  UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, System.Int32 layerMask)
  UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter)
  UnityEngine.RaycastHit2D Raycast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter)
  System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
  System.Int32 RaycastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
  System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
  System.Int32 RaycastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
  UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask)
  UnityEngine.RaycastHit2D GetRayIntersection_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single distance, System.Int32 layerMask)
  System.Int32 GetRayIntersection(UnityEngine.Ray ray, System.Single distance, UnityEngine.RaycastHit2D[] results, System.Int32 layerMask)
  System.Int32 GetRayIntersectionArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single distance, System.Int32 layerMask, UnityEngine.RaycastHit2D[] results)
  System.Void Linecast_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& start, UnityEngine.Vector2& end, UnityEngine.ContactFilter2D& contactFilter, UnityEngine.RaycastHit2D& ret)
  System.Void Raycast_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, System.Single distance, UnityEngine.ContactFilter2D& contactFilter, UnityEngine.RaycastHit2D& ret)
  System.Int32 RaycastArray_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, System.Single distance, UnityEngine.ContactFilter2D& contactFilter, UnityEngine.RaycastHit2D[] results)
  System.Int32 RaycastList_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, System.Single distance, UnityEngine.ContactFilter2D& contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
  System.Void GetRayIntersection_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, System.Single distance, System.Int32 layerMask, UnityEngine.RaycastHit2D& ret)
  System.Int32 GetRayIntersectionArray_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, System.Single distance, System.Int32 layerMask, UnityEngine.RaycastHit2D[] results)
END_CLASS

CLASS: UnityEngine.Physics2D
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.Rigidbody2D>m_LastDisabledRigidbody2D  // 0x0
METHODS:
  UnityEngine.PhysicsScene2D get_defaultPhysicsScene()
  System.Void set_gravity(UnityEngine.Vector2 value)
  System.Boolean get_queriesHitTriggers()
  UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, System.Int32 layerMask)
  UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end, System.Int32 layerMask)
  UnityEngine.RaycastHit2D[] LinecastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter)
  UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction)
  UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance)
  UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, System.Int32 layerMask)
  UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, System.Int32 layerMask, System.Single minDepth)
  UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, System.Int32 layerMask, System.Single minDepth, System.Single maxDepth)
  System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
  System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, System.Single distance)
  System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, System.Single distance)
  UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask)
  UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray)
  UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, System.Single distance)
  UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask)
  UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single distance, System.Int32 layerMask)
  System.Int32 GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results)
  System.Int32 GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, System.Single distance)
  System.Int32 GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, System.Single distance, System.Int32 layerMask)
  System.Void .cctor()
  System.Void set_gravity_Injected(UnityEngine.Vector2& value)
  UnityEngine.RaycastHit2D[] LinecastAll_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& start, UnityEngine.Vector2& end, UnityEngine.ContactFilter2D& contactFilter)
  UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, System.Single distance, System.Int32 layerMask)
END_CLASS

CLASS: UnityEngine.RigidbodyInterpolation2D
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RigidbodyInterpolation2DNone  // 0x0
  public    static  UnityEngine.RigidbodyInterpolation2DInterpolate  // 0x0
  public    static  UnityEngine.RigidbodyInterpolation2DExtrapolate  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RigidbodySleepMode2D
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RigidbodySleepMode2DNeverSleep  // 0x0
  public    static  UnityEngine.RigidbodySleepMode2DStartAwake  // 0x0
  public    static  UnityEngine.RigidbodySleepMode2DStartAsleep  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.CollisionDetectionMode2D
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.CollisionDetectionMode2DNone  // 0x0
  public    static  UnityEngine.CollisionDetectionMode2DDiscrete  // 0x0
  public    static  UnityEngine.CollisionDetectionMode2DContinuous  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ContactFilter2D
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Boolean                  useTriggers  // 0x10
  public            System.Boolean                  useLayerMask  // 0x11
  public            System.Boolean                  useDepth  // 0x12
  public            System.Boolean                  useOutsideDepth  // 0x13
  public            System.Boolean                  useNormalAngle  // 0x14
  public            System.Boolean                  useOutsideNormalAngle  // 0x15
  public            UnityEngine.LayerMask           layerMask  // 0x18
  public            System.Single                   minDepth  // 0x1C
  public            System.Single                   maxDepth  // 0x20
  public            System.Single                   minNormalAngle  // 0x24
  public            System.Single                   maxNormalAngle  // 0x28
METHODS:
  System.Void CheckConsistency()
  System.Void SetLayerMask(UnityEngine.LayerMask layerMask)
  System.Void SetDepth(System.Single minDepth, System.Single maxDepth)
  UnityEngine.ContactFilter2D CreateLegacyFilter(System.Int32 layerMask, System.Single minDepth, System.Single maxDepth)
  System.Void CheckConsistency_Injected(UnityEngine.ContactFilter2D& _unity_self)
END_CLASS

CLASS: UnityEngine.Collision2D
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           System.Int32                    m_Collider  // 0x10
  private           System.Int32                    m_OtherCollider  // 0x14
  private           System.Int32                    m_Rigidbody  // 0x18
  private           System.Int32                    m_OtherRigidbody  // 0x1C
  private           UnityEngine.Vector2             m_RelativeVelocity  // 0x20
  private           System.Int32                    m_Enabled  // 0x28
  private           System.Int32                    m_ContactCount  // 0x2C
  private           UnityEngine.ContactPoint2D[]    m_ReusedContacts  // 0x30
  private           UnityEngine.ContactPoint2D[]    m_LegacyContacts  // 0x38
METHODS:
  UnityEngine.Collider2D get_collider()
  UnityEngine.Rigidbody2D get_rigidbody()
  UnityEngine.GameObject get_gameObject()
  UnityEngine.Vector2 get_relativeVelocity()
  UnityEngine.ContactPoint2D[] get_contacts()
END_CLASS

CLASS: UnityEngine.ContactPoint2D
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  private           UnityEngine.Vector2             m_Point  // 0x10
  private           UnityEngine.Vector2             m_Normal  // 0x18
  private           UnityEngine.Vector2             m_RelativeVelocity  // 0x20
  private           System.Single                   m_Separation  // 0x28
  private           System.Single                   m_NormalImpulse  // 0x2C
  private           System.Single                   m_TangentImpulse  // 0x30
  private           System.Int32                    m_Collider  // 0x34
  private           System.Int32                    m_OtherCollider  // 0x38
  private           System.Int32                    m_Rigidbody  // 0x3C
  private           System.Int32                    m_OtherRigidbody  // 0x40
  private           System.Int32                    m_Enabled  // 0x44
METHODS:
  UnityEngine.Vector2 get_point()
  UnityEngine.Vector2 get_normal()
  UnityEngine.Collider2D get_collider()
  UnityEngine.Collider2D get_otherCollider()
END_CLASS

CLASS: UnityEngine.RaycastHit2D
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  private           UnityEngine.Vector2             m_Centroid  // 0x10
  private           UnityEngine.Vector2             m_Point  // 0x18
  private           UnityEngine.Vector2             m_Normal  // 0x20
  private           System.Single                   m_Distance  // 0x28
  private           System.Single                   m_Fraction  // 0x2C
  private           System.Int32                    m_Collider  // 0x30
METHODS:
  UnityEngine.Vector2 get_point()
  UnityEngine.Vector2 get_normal()
  System.Single get_distance()
  System.Single get_fraction()
  UnityEngine.Collider2D get_collider()
END_CLASS

CLASS: UnityEngine.Rigidbody2D
TYPE:  class
TOKEN: 0x200000B
EXTENDS: Component
FIELDS:
METHODS:
  UnityEngine.Vector2 get_velocity()
  System.Single get_mass()
  System.Void .ctor()
  System.Void get_velocity_Injected(UnityEngine.Vector2& ret)
END_CLASS

CLASS: UnityEngine.Collider2D
TYPE:  class
TOKEN: 0x200000C
EXTENDS: Behaviour
FIELDS:
METHODS:
  UnityEngine.Vector2 get_offset()
  UnityEngine.Rigidbody2D get_attachedRigidbody()
  System.Boolean OverlapPoint(UnityEngine.Vector2 point)
  System.Void get_offset_Injected(UnityEngine.Vector2& ret)
  System.Boolean OverlapPoint_Injected(UnityEngine.Vector2& point)
END_CLASS

CLASS: UnityEngine.CircleCollider2D
TYPE:  class
TOKEN: 0x200000D
EXTENDS: Collider2D
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.PolygonCollider2D
TYPE:  class
TOKEN: 0x200000E
EXTENDS: Collider2D
FIELDS:
METHODS:
  System.Int32 GetTotalPointCount()
  System.Int32 get_pathCount()
  UnityEngine.Vector2[] GetPath(System.Int32 index)
  UnityEngine.Vector2[] GetPath_Internal(System.Int32 index)
END_CLASS

CLASS: UnityEngine.CompositeCollider2D
TYPE:  class
TOKEN: 0x200000F
EXTENDS: Collider2D
FIELDS:
METHODS:
  System.Int32 get_pathCount()
  System.Int32 get_pointCount()
  System.Int32 GetPath(System.Int32 index, UnityEngine.Vector2[] points)
  System.Int32 GetPathArray_Internal(System.Int32 index, UnityEngine.Vector2[] points)
END_CLASS

CLASS: UnityEngine.PhysicsMaterial2D
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
END_CLASS

