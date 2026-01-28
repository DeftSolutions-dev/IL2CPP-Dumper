// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.Physics2DModule.dll
// Classes:  16
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public struct PhysicsScene2D, IEquatable`1
    {
        // Fields
        private System.Int32 m_Handle;        // 0x10

        // Methods
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.PhysicsScene2D other) { }
        private UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter) { }
        private UnityEngine.RaycastHit2D Linecast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter) { }
        private UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter) { }
        private UnityEngine.RaycastHit2D Raycast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter) { }
        private System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results) { }
        private System.Int32 RaycastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results) { }
        private System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results) { }
        private System.Int32 RaycastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results) { }
        private UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit2D GetRayIntersection_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single distance, System.Int32 layerMask) { }
        private System.Int32 GetRayIntersection(UnityEngine.Ray ray, System.Single distance, UnityEngine.RaycastHit2D[] results, System.Int32 layerMask) { }
        private System.Int32 GetRayIntersectionArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single distance, System.Int32 layerMask, UnityEngine.RaycastHit2D[] results) { }
        private System.Void Linecast_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& start, UnityEngine.Vector2& end, UnityEngine.ContactFilter2D& contactFilter, UnityEngine.RaycastHit2D& ret) { }
        private System.Void Raycast_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, System.Single distance, UnityEngine.ContactFilter2D& contactFilter, UnityEngine.RaycastHit2D& ret) { }
        private System.Int32 RaycastArray_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, System.Single distance, UnityEngine.ContactFilter2D& contactFilter, UnityEngine.RaycastHit2D[] results) { }
        private System.Int32 RaycastList_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, System.Single distance, UnityEngine.ContactFilter2D& contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results) { }
        private System.Void GetRayIntersection_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, System.Single distance, System.Int32 layerMask, UnityEngine.RaycastHit2D& ret) { }
        private System.Int32 GetRayIntersectionArray_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, System.Single distance, System.Int32 layerMask, UnityEngine.RaycastHit2D[] results) { }

    }

    // TypeToken: 0x2000003
    public class Physics2D
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;        // 0x0

        // Methods
        private UnityEngine.PhysicsScene2D get_defaultPhysicsScene() { }
        private System.Void set_gravity(UnityEngine.Vector2 value) { }
        private System.Boolean get_queriesHitTriggers() { }
        private UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit2D[] LinecastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter) { }
        private UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction) { }
        private UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance) { }
        private UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, System.Int32 layerMask, System.Single minDepth) { }
        private UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, System.Single distance, System.Int32 layerMask, System.Single minDepth, System.Single maxDepth) { }
        private System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results) { }
        private System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, System.Single distance) { }
        private System.Int32 Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, System.Single distance) { }
        private UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray) { }
        private UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, System.Single distance) { }
        private UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single distance, System.Int32 layerMask) { }
        private System.Int32 GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results) { }
        private System.Int32 GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, System.Single distance) { }
        private System.Int32 GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, System.Single distance, System.Int32 layerMask) { }
        private System.Void .cctor() { }
        private System.Void set_gravity_Injected(UnityEngine.Vector2& value) { }
        private UnityEngine.RaycastHit2D[] LinecastAll_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector2& start, UnityEngine.Vector2& end, UnityEngine.ContactFilter2D& contactFilter) { }
        private UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(UnityEngine.PhysicsScene2D& physicsScene, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, System.Single distance, System.Int32 layerMask) { }

    }

    // TypeToken: 0x2000004
    public struct RigidbodyInterpolation2D
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RigidbodyInterpolation2D None;        // 0x0
        public static UnityEngine.RigidbodyInterpolation2D Interpolate;        // 0x0
        public static UnityEngine.RigidbodyInterpolation2D Extrapolate;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct RigidbodySleepMode2D
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RigidbodySleepMode2D NeverSleep;        // 0x0
        public static UnityEngine.RigidbodySleepMode2D StartAwake;        // 0x0
        public static UnityEngine.RigidbodySleepMode2D StartAsleep;        // 0x0

    }

    // TypeToken: 0x2000006
    public struct CollisionDetectionMode2D
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.CollisionDetectionMode2D None;        // 0x0
        public static UnityEngine.CollisionDetectionMode2D Discrete;        // 0x0
        public static UnityEngine.CollisionDetectionMode2D Continuous;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct ContactFilter2D
    {
        // Fields
        public System.Boolean useTriggers;        // 0x10
        public System.Boolean useLayerMask;        // 0x11
        public System.Boolean useDepth;        // 0x12
        public System.Boolean useOutsideDepth;        // 0x13
        public System.Boolean useNormalAngle;        // 0x14
        public System.Boolean useOutsideNormalAngle;        // 0x15
        public UnityEngine.LayerMask layerMask;        // 0x18
        public System.Single minDepth;        // 0x1C
        public System.Single maxDepth;        // 0x20
        public System.Single minNormalAngle;        // 0x24
        public System.Single maxNormalAngle;        // 0x28

        // Methods
        private System.Void CheckConsistency() { }
        private System.Void SetLayerMask(UnityEngine.LayerMask layerMask) { }
        private System.Void SetDepth(System.Single minDepth, System.Single maxDepth) { }
        private UnityEngine.ContactFilter2D CreateLegacyFilter(System.Int32 layerMask, System.Single minDepth, System.Single maxDepth) { }
        private System.Void CheckConsistency_Injected(UnityEngine.ContactFilter2D& _unity_self) { }

    }

    // TypeToken: 0x2000008
    public class Collision2D
    {
        // Fields
        private System.Int32 m_Collider;        // 0x10
        private System.Int32 m_OtherCollider;        // 0x14
        private System.Int32 m_Rigidbody;        // 0x18
        private System.Int32 m_OtherRigidbody;        // 0x1C
        private UnityEngine.Vector2 m_RelativeVelocity;        // 0x20
        private System.Int32 m_Enabled;        // 0x28
        private System.Int32 m_ContactCount;        // 0x2C
        private UnityEngine.ContactPoint2D[] m_ReusedContacts;        // 0x30
        private UnityEngine.ContactPoint2D[] m_LegacyContacts;        // 0x38

        // Methods
        private UnityEngine.Collider2D get_collider() { }
        private UnityEngine.Rigidbody2D get_rigidbody() { }
        private UnityEngine.GameObject get_gameObject() { }
        private UnityEngine.Vector2 get_relativeVelocity() { }
        private UnityEngine.ContactPoint2D[] get_contacts() { }

    }

    // TypeToken: 0x2000009
    public struct ContactPoint2D
    {
        // Fields
        private UnityEngine.Vector2 m_Point;        // 0x10
        private UnityEngine.Vector2 m_Normal;        // 0x18
        private UnityEngine.Vector2 m_RelativeVelocity;        // 0x20
        private System.Single m_Separation;        // 0x28
        private System.Single m_NormalImpulse;        // 0x2C
        private System.Single m_TangentImpulse;        // 0x30
        private System.Int32 m_Collider;        // 0x34
        private System.Int32 m_OtherCollider;        // 0x38
        private System.Int32 m_Rigidbody;        // 0x3C
        private System.Int32 m_OtherRigidbody;        // 0x40
        private System.Int32 m_Enabled;        // 0x44

        // Methods
        private UnityEngine.Vector2 get_point() { }
        private UnityEngine.Vector2 get_normal() { }
        private UnityEngine.Collider2D get_collider() { }
        private UnityEngine.Collider2D get_otherCollider() { }

    }

    // TypeToken: 0x200000A
    public struct RaycastHit2D
    {
        // Fields
        private UnityEngine.Vector2 m_Centroid;        // 0x10
        private UnityEngine.Vector2 m_Point;        // 0x18
        private UnityEngine.Vector2 m_Normal;        // 0x20
        private System.Single m_Distance;        // 0x28
        private System.Single m_Fraction;        // 0x2C
        private System.Int32 m_Collider;        // 0x30

        // Methods
        private UnityEngine.Vector2 get_point() { }
        private UnityEngine.Vector2 get_normal() { }
        private System.Single get_distance() { }
        private System.Single get_fraction() { }
        private UnityEngine.Collider2D get_collider() { }

    }

    // TypeToken: 0x200000B
    public class Rigidbody2D : Component
    {
        // Methods
        private UnityEngine.Vector2 get_velocity() { }
        private System.Single get_mass() { }
        private System.Void .ctor() { }
        private System.Void get_velocity_Injected(UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x200000C
    public class Collider2D : Behaviour
    {
        // Methods
        private UnityEngine.Vector2 get_offset() { }
        private UnityEngine.Rigidbody2D get_attachedRigidbody() { }
        private System.Boolean OverlapPoint(UnityEngine.Vector2 point) { }
        private System.Void get_offset_Injected(UnityEngine.Vector2& ret) { }
        private System.Boolean OverlapPoint_Injected(UnityEngine.Vector2& point) { }

    }

    // TypeToken: 0x200000D
    public class CircleCollider2D : Collider2D
    {
    }

    // TypeToken: 0x200000E
    public class PolygonCollider2D : Collider2D
    {
        // Methods
        private System.Int32 GetTotalPointCount() { }
        private System.Int32 get_pathCount() { }
        private UnityEngine.Vector2[] GetPath(System.Int32 index) { }
        private UnityEngine.Vector2[] GetPath_Internal(System.Int32 index) { }

    }

    // TypeToken: 0x200000F
    public class CompositeCollider2D : Collider2D
    {
        // Methods
        private System.Int32 get_pathCount() { }
        private System.Int32 get_pointCount() { }
        private System.Int32 GetPath(System.Int32 index, UnityEngine.Vector2[] points) { }
        private System.Int32 GetPathArray_Internal(System.Int32 index, UnityEngine.Vector2[] points) { }

    }

    // TypeToken: 0x2000010
    public class PhysicsMaterial2D
    {
    }

}

