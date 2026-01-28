// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.PhysicsModule.dll
// Classes:  35
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000017
    public class CollisionCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }

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
    public struct RigidbodyConstraints
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RigidbodyConstraints None;        // 0x0
        public static UnityEngine.RigidbodyConstraints FreezePositionX;        // 0x0
        public static UnityEngine.RigidbodyConstraints FreezePositionY;        // 0x0
        public static UnityEngine.RigidbodyConstraints FreezePositionZ;        // 0x0
        public static UnityEngine.RigidbodyConstraints FreezeRotationX;        // 0x0
        public static UnityEngine.RigidbodyConstraints FreezeRotationY;        // 0x0
        public static UnityEngine.RigidbodyConstraints FreezeRotationZ;        // 0x0
        public static UnityEngine.RigidbodyConstraints FreezePosition;        // 0x0
        public static UnityEngine.RigidbodyConstraints FreezeRotation;        // 0x0
        public static UnityEngine.RigidbodyConstraints FreezeAll;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct ForceMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ForceMode Force;        // 0x0
        public static UnityEngine.ForceMode Acceleration;        // 0x0
        public static UnityEngine.ForceMode Impulse;        // 0x0
        public static UnityEngine.ForceMode VelocityChange;        // 0x0

    }

    // TypeToken: 0x2000006
    public struct MeshColliderCookingOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.MeshColliderCookingOptions None;        // 0x0
        public static UnityEngine.MeshColliderCookingOptions InflateConvexMesh;        // 0x0
        public static UnityEngine.MeshColliderCookingOptions CookForFasterSimulation;        // 0x0
        public static UnityEngine.MeshColliderCookingOptions EnableMeshCleaning;        // 0x0
        public static UnityEngine.MeshColliderCookingOptions WeldColocatedVertices;        // 0x0
        public static UnityEngine.MeshColliderCookingOptions UseFastMidphase;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct ColliderSurfaceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ColliderSurfaceType Default;        // 0x0
        public static UnityEngine.ColliderSurfaceType Concrete;        // 0x0
        public static UnityEngine.ColliderSurfaceType Wood;        // 0x0
        public static UnityEngine.ColliderSurfaceType Dirt;        // 0x0
        public static UnityEngine.ColliderSurfaceType Grass;        // 0x0
        public static UnityEngine.ColliderSurfaceType Stone;        // 0x0
        public static UnityEngine.ColliderSurfaceType Water;        // 0x0
        public static UnityEngine.ColliderSurfaceType Flesh;        // 0x0
        public static UnityEngine.ColliderSurfaceType Metal;        // 0x0
        public static UnityEngine.ColliderSurfaceType Crystal;        // 0x0
        public static UnityEngine.ColliderSurfaceType Rubber;        // 0x0
        public static UnityEngine.ColliderSurfaceType Sand;        // 0x0
        public static UnityEngine.ColliderSurfaceType Gravel;        // 0x0
        public static UnityEngine.ColliderSurfaceType Moss;        // 0x0
        public static UnityEngine.ColliderSurfaceType Custom;        // 0x0
        public static UnityEngine.ColliderSurfaceType Snow;        // 0x0
        public static UnityEngine.ColliderSurfaceType Mud;        // 0x0
        public static UnityEngine.ColliderSurfaceType Cardboard;        // 0x0
        public static UnityEngine.ColliderSurfaceType Plastic;        // 0x0
        public static UnityEngine.ColliderSurfaceType Ice;        // 0x0
        public static UnityEngine.ColliderSurfaceType Wet;        // 0x0
        public static UnityEngine.ColliderSurfaceType WaterV2;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct RigidbodyInterpolation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RigidbodyInterpolation None;        // 0x0
        public static UnityEngine.RigidbodyInterpolation Interpolate;        // 0x0
        public static UnityEngine.RigidbodyInterpolation Extrapolate;        // 0x0

    }

    // TypeToken: 0x2000009
    public class ControllerColliderHit
    {
        // Fields
        private UnityEngine.CharacterController m_Controller;        // 0x10
        private UnityEngine.Collider m_Collider;        // 0x18
        private UnityEngine.Vector3 m_Point;        // 0x20
        private UnityEngine.Vector3 m_Normal;        // 0x2C
        private UnityEngine.Vector3 m_MoveDirection;        // 0x38
        private System.Single m_MoveLength;        // 0x44
        private System.Int32 m_Push;        // 0x48

        // Methods
        private UnityEngine.GameObject get_gameObject() { }
        private UnityEngine.Vector3 get_point() { }

    }

    // TypeToken: 0x200000A
    public class Collision
    {
        // Fields
        private UnityEngine.Vector3 m_Impulse;        // 0x10
        private UnityEngine.Vector3 m_RelativeVelocity;        // 0x1C
        private UnityEngine.Component m_Body;        // 0x28
        private UnityEngine.Collider m_Collider;        // 0x30
        private System.Int32 m_ContactCount;        // 0x38
        private UnityEngine.ContactPoint[] m_ReusedContacts;        // 0x40
        private UnityEngine.ContactPoint[] m_LegacyContacts;        // 0x48

        // Methods
        private UnityEngine.Vector3 get_relativeVelocity() { }
        private UnityEngine.Collider get_collider() { }
        private UnityEngine.GameObject get_gameObject() { }
        private UnityEngine.ContactPoint[] get_contacts() { }
        private UnityEngine.Vector3 get_impulse() { }

    }

    // TypeToken: 0x200000B
    public struct QueryTriggerInteraction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.QueryTriggerInteraction UseGlobal;        // 0x0
        public static UnityEngine.QueryTriggerInteraction Ignore;        // 0x0
        public static UnityEngine.QueryTriggerInteraction Collide;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct CollisionDetectionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.CollisionDetectionMode Discrete;        // 0x0
        public static UnityEngine.CollisionDetectionMode Continuous;        // 0x0
        public static UnityEngine.CollisionDetectionMode ContinuousDynamic;        // 0x0
        public static UnityEngine.CollisionDetectionMode ContinuousSpeculative;        // 0x0

    }

    // TypeToken: 0x200000D
    public class ArticulationBody : Behaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class Physics
    {
        // Fields
        private static System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent;        // 0x0
        private static System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD;        // 0x8
        private static System.Single k_MaxFloatMinusEpsilon;        // 0x0
        public static System.Int32 IgnoreRaycastLayer;        // 0x0
        public static System.Int32 DefaultRaycastLayers;        // 0x0
        public static System.Int32 AllLayers;        // 0x0
        public static System.Int32 kIgnoreRaycastLayer;        // 0x0
        public static System.Int32 kDefaultRaycastLayers;        // 0x0
        public static System.Int32 kAllLayers;        // 0x0

        // Methods
        private System.Void add_ContactModifyEvent(System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value) { }
        private System.Void remove_ContactModifyEvent(System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value) { }
        private System.Void add_ContactModifyEventCCD(System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value) { }
        private System.Void remove_ContactModifyEventCCD(System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value) { }
        private System.Void OnSceneContactModify(UnityEngine.PhysicsScene scene, System.IntPtr buffer, System.Int32 count, System.Boolean isCCD) { }
        private UnityEngine.Vector3 get_gravity() { }
        private System.Void set_gravity(UnityEngine.Vector3 value) { }
        private System.Single get_defaultContactOffset() { }
        private System.Void set_defaultContactOffset(System.Single value) { }
        private System.Single get_sleepThreshold() { }
        private System.Void set_sleepThreshold(System.Single value) { }
        private System.Boolean get_queriesHitTriggers() { }
        private System.Void set_queriesHitTriggers(System.Boolean value) { }
        private System.Boolean get_queriesHitBackfaces() { }
        private System.Void set_queriesHitBackfaces(System.Boolean value) { }
        private System.Single get_bounceThreshold() { }
        private System.Void set_bounceThreshold(System.Single value) { }
        private System.Single get_defaultMaxDepenetrationVelocity() { }
        private System.Void set_defaultMaxDepenetrationVelocity(System.Single value) { }
        private System.Int32 get_defaultSolverIterations() { }
        private System.Void set_defaultSolverIterations(System.Int32 value) { }
        private System.Int32 get_defaultSolverVelocityIterations() { }
        private System.Void set_defaultSolverVelocityIterations(System.Int32 value) { }
        private System.Single get_defaultMaxAngularSpeed() { }
        private System.Void set_defaultMaxAngularSpeed(System.Single value) { }
        private System.Boolean get_improvedPatchFriction() { }
        private System.Void set_improvedPatchFriction(System.Boolean value) { }
        private UnityEngine.PhysicsScene get_defaultPhysicsScene() { }
        private System.Boolean get_logPhysXCheckError() { }
        private System.Void set_logPhysXCheckError(System.Boolean value) { }
        private System.Void ClearUnusedMemory() { }
        private System.Void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2, System.Boolean ignore) { }
        private System.Void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2) { }
        private System.Void IgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2, System.Boolean ignore) { }
        private System.Void ForceRebuildDynamicTree(System.Boolean rebuildStatic, System.Boolean rebuildDynamic) { }
        private System.Void IgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2) { }
        private System.Boolean GetIgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2) { }
        private System.Boolean GetIgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        private System.Boolean RaycastV2(UnityEngine.ECSColliderResultProxy proxy, UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        private System.Boolean RaycastV2(UnityEngine.ECSColliderResultProxy proxy, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hit) { }
        private UnityEngine.RaycastHit Internal_RaycastTestV2(UnityEngine.ECSColliderResultProxy collider, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance) { }
        private System.Boolean Raycast(UnityEngine.Ray ray) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo) { }
        private System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32 layerMask) { }
        private System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end) { }
        private System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask) { }
        private System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo) { }
        private System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        private System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction) { }
        private System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        private System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        private System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        private System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        private System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance) { }
        private System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius) { }
        private System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        private System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        private UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        private UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction) { }
        private UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance) { }
        private UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray) { }
        private System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        private System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results) { }
        private System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        private System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) { }
        private UnityEngine.RaycastHit[] Query_CapsuleCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        private UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction) { }
        private UnityEngine.RaycastHit[] Query_SphereCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        private UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction) { }
        private UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance) { }
        private UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius) { }
        private UnityEngine.Collider[] OverlapCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask) { }
        private UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius) { }
        private UnityEngine.Collider[] OverlapSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy CreateECSProxy(UnityEngine.Collider collider) { }
        private UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask) { }
        private UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapSphereV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius) { }
        private System.Void Simulate_Internal(UnityEngine.PhysicsScene physicsScene, System.Single step) { }
        private System.Void Simulate(System.Single step) { }
        private System.Boolean get_autoSimulation() { }
        private System.Void set_autoSimulation(System.Boolean value) { }
        private System.Void SyncTransforms() { }
        private System.Boolean get_autoSyncTransforms() { }
        private System.Void set_autoSyncTransforms(System.Boolean value) { }
        private System.Boolean get_reuseCollisionCallbacks() { }
        private System.Void set_reuseCollisionCallbacks(System.Boolean value) { }
        private System.Boolean Query_ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputePenetrationV2(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean ComputePenetrationV2(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputeCapsulePenetration(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean ComputeCapsulePenetration(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputeCapsulePenetrationV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean ComputeCapsulePenetrationV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputeSpherePenetrationV2(UnityEngine.Vector3 center, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean ComputeSpherePenetrationV2(UnityEngine.Vector3 center, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputeBoxPenetrationV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtent, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean ComputeBoxPenetrationV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtent, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean IsSimulatedThisFrame_Internal() { }
        private System.Boolean IsSimulatedThisFrame() { }
        private System.Void SetForceSimulateThisFrame_Internal(System.Boolean force) { }
        private System.Void SetForceSimulateThisFrame(System.Boolean force) { }
        private System.Void SetFastSimulate_Internal(System.Boolean fast) { }
        private System.Void SetFastSimulate(System.Boolean fast) { }
        private UnityEngine.Vector3 Query_ClosestPoint(UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point, UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector3 Query_ClosestPointV2(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 ClosestPointV2(UnityEngine.Vector3 point, UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector3 Query_TryGetClosestPoint(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point, System.Boolean& resultIsValid) { }
        private System.Boolean TryGetClosestPoint(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point, UnityEngine.Vector3& result) { }
        private System.Single get_interCollisionDistance() { }
        private System.Void set_interCollisionDistance(System.Single value) { }
        private System.Single get_interCollisionStiffness() { }
        private System.Void set_interCollisionStiffness(System.Single value) { }
        private System.Boolean get_interCollisionSettingsToggle() { }
        private System.Void set_interCollisionSettingsToggle(System.Boolean value) { }
        private UnityEngine.Vector3 get_clothGravity() { }
        private System.Void set_clothGravity(UnityEngine.Vector3 value) { }
        private System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask) { }
        private System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results) { }
        private System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask) { }
        private System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results) { }
        private System.Boolean CheckSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask) { }
        private System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius) { }
        private System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        private System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance) { }
        private System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) { }
        private System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results) { }
        private System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        private System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) { }
        private System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        private System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results) { }
        private System.Boolean CheckCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask) { }
        private System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius) { }
        private System.Boolean CheckBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask) { }
        private System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation) { }
        private System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents) { }
        private UnityEngine.Collider[] OverlapBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask) { }
        private UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation) { }
        private UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents) { }
        private System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask) { }
        private System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation) { }
        private System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapBoxV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents) { }
        private System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask) { }
        private System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation) { }
        private System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results) { }
        private System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation) { }
        private System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance) { }
        private System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask) { }
        private System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) { }
        private UnityEngine.RaycastHit[] Internal_BoxCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask) { }
        private UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance) { }
        private UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation) { }
        private UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction) { }
        private System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask) { }
        private System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results) { }
        private System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask) { }
        private System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results) { }
        private System.Void Internal_RebuildBroadphaseRegions(UnityEngine.Bounds bounds, System.Int32 subdivisions) { }
        private System.Void RebuildBroadphaseRegions(UnityEngine.Bounds worldBounds, System.Int32 subdivisions) { }
        private System.Void BakeMesh(System.Int32 meshID, System.Boolean convex) { }
        private System.Single get_minPenetrationForPenalty() { }
        private System.Void set_minPenetrationForPenalty(System.Single value) { }
        private System.Single get_bounceTreshold() { }
        private System.Void set_bounceTreshold(System.Single value) { }
        private System.Single get_sleepVelocity() { }
        private System.Void set_sleepVelocity(System.Single value) { }
        private System.Single get_sleepAngularVelocity() { }
        private System.Void set_sleepAngularVelocity(System.Single value) { }
        private System.Single get_maxAngularVelocity() { }
        private System.Void set_maxAngularVelocity(System.Single value) { }
        private System.Int32 get_solverIterationCount() { }
        private System.Void set_solverIterationCount(System.Int32 value) { }
        private System.Int32 get_solverVelocityIterationCount() { }
        private System.Void set_solverVelocityIterationCount(System.Int32 value) { }
        private System.Single get_penetrationPenaltyForce() { }
        private System.Void set_penetrationPenaltyForce(System.Single value) { }
        private System.Void .ctor() { }
        private System.Void get_gravity_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_gravity_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_defaultPhysicsScene_Injected(UnityEngine.PhysicsScene& ret) { }
        private System.Void Internal_RaycastTestV2_Injected(UnityEngine.ECSColliderResultProxy& collider, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        private UnityEngine.RaycastHit[] Internal_RaycastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] Query_CapsuleCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] Query_SphereCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.Collider[] OverlapCapsule_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.Collider[] OverlapSphere_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapSphereV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Void Simulate_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, System.Single step) { }
        private System.Boolean Query_ComputePenetration_Injected(UnityEngine.Collider colliderA, UnityEngine.Vector3& positionA, UnityEngine.Quaternion& rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputePenetrationV2_Injected(UnityEngine.ECSColliderResultProxy& colliderA, UnityEngine.Vector3& positionA, UnityEngine.Quaternion& rotationA, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputeCapsulePenetration_Injected(UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputeCapsulePenetrationV2_Injected(UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputeSpherePenetrationV2_Injected(UnityEngine.Vector3& center, System.Single radius, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Boolean Query_ComputeBoxPenetrationV2_Injected(UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtent, UnityEngine.Quaternion& rotationA, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        private System.Void Query_ClosestPoint_Injected(UnityEngine.Collider collider, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, UnityEngine.Vector3& ret) { }
        private System.Void Query_ClosestPointV2_Injected(UnityEngine.ECSColliderResultProxy& colliderProxy, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, UnityEngine.Vector3& ret) { }
        private System.Void Query_TryGetClosestPoint_Injected(UnityEngine.ECSColliderResultProxy& colliderProxy, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret) { }
        private System.Void get_clothGravity_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_clothGravity_Injected(UnityEngine.Vector3& value) { }
        private System.Boolean CheckSphere_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CheckCapsule_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& start, UnityEngine.Vector3& end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CheckBox_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.Collider[] OverlapBox_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.ECSColliderResultProxy[] OverlapBoxV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] Internal_BoxCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.Quaternion& orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Void Internal_RebuildBroadphaseRegions_Injected(UnityEngine.Bounds& bounds, System.Int32 subdivisions) { }

    }

    // TypeToken: 0x200000F
    public struct ModifiableContactPair
    {
        // Fields
        private System.IntPtr actor;        // 0x10
        private System.IntPtr otherActor;        // 0x18
        private System.IntPtr shape;        // 0x20
        private System.IntPtr otherShape;        // 0x28
        public UnityEngine.Quaternion rotation;        // 0x30
        public UnityEngine.Vector3 position;        // 0x40
        public UnityEngine.Quaternion otherRotation;        // 0x4C
        public UnityEngine.Vector3 otherPosition;        // 0x5C
        private System.Int32 numContacts;        // 0x68
        private System.IntPtr contacts;        // 0x70

    }

    // TypeToken: 0x2000010
    public class PhysicMaterial
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_CreateDynamicsMaterial(UnityEngine.PhysicMaterial mat, System.String name) { }

    }

    // TypeToken: 0x2000011
    public struct ECSColliderResultProxy, IEquatable`1
    {
        // Fields
        private System.IntPtr m_Actor;        // 0x10
        private System.Int32 m_EcsId;        // 0x18
        private System.UInt32 m_EcsVersion;        // 0x1C
        private System.Int32 m_Collider;        // 0x20
        private System.Int32 m_ComponentIndex;        // 0x24
        private static readonly UnityEngine.ECSColliderResultProxy INVALID_PROXY;        // 0x0

        // Methods
        private System.Void SetColliderAndSetIndex(System.Int32 colliderInstanceID) { }
        private System.Void SetComponentIndex(System.Int32 index) { }
        private System.Void SetActor(System.IntPtr actor) { }
        private System.Void SetEcsId(System.Int32 id) { }
        private System.Void SetEcsVersion(System.UInt32 version) { }
        private System.Int32 get_componentIndex() { }
        private UnityEngine.HyperGryph.ECS.Entity get_colliderEntity() { }
        private System.Int32 get_ecsId() { }
        private System.UInt32 get_ecsVersion() { }
        private UnityEngine.ECSColliderResultProxy get_invalid() { }
        private UnityEngine.Collider get_collider() { }
        private System.Int32 get_colliderInstanceId() { }
        private System.Boolean get_bIsECS() { }
        private System.Int32 get_tagConfig() { }
        private System.Boolean IsValid() { }
        private System.Boolean get_isTrigger() { }
        private System.Int32 get_layer() { }
        private UnityEngine.Transform get_transform() { }
        private UnityEngine.Vector3 get_transformPosition() { }
        private UnityEngine.Quaternion get_transformRotation() { }
        private UnityEngine.Vector3 get_transformLossyScale() { }
        private UnityEngine.Vector3 get_shapePosition() { }
        private UnityEngine.Bounds get_bounds() { }
        private System.Int32 get_colliderOptions() { }
        private UnityEngine.ColliderSurfaceType get_surfaceType() { }
        private System.String GetColliderGoName() { }
        private UnityEngine.ECSColliderType get_colliderType() { }
        private UnityEngine.GameObject get_gameObject() { }
        private System.Int32 GetFactoryBuildingIdentifier() { }
        private System.Boolean get_hasComplexMesh() { }
        private System.Boolean TryGetClosestPoint(UnityEngine.Vector3 point, UnityEngine.Vector3& result) { }
        private UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        private System.Boolean op_Equality(UnityEngine.ECSColliderResultProxy left, UnityEngine.ECSColliderResultProxy right) { }
        private System.Boolean op_Inequality(UnityEngine.ECSColliderResultProxy left, UnityEngine.ECSColliderResultProxy right) { }
        private System.Boolean Equals(UnityEngine.ECSColliderResultProxy other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean CompareTag(System.Int32 tagValue) { }
        private System.Boolean IsSameCollider(UnityEngine.Collider otherCollider) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000012
    public struct RaycastHit
    {
        // Fields
        private UnityEngine.Vector3 m_Point;        // 0x10
        private UnityEngine.Vector3 m_Normal;        // 0x1C
        private System.UInt32 m_FaceID;        // 0x28
        private System.Single m_Distance;        // 0x2C
        private UnityEngine.Vector2 m_UV;        // 0x30
        private System.Int32 m_Collider;        // 0x38
        private System.Int32 m_Index;        // 0x3C
        private System.Int32 m_EcsId;        // 0x40
        private System.UInt32 m_EcsVersion;        // 0x44
        private System.IntPtr m_Actor;        // 0x48

        // Methods
        private System.Int32 get_ecsId() { }
        private System.UInt32 get_ecsVersion() { }
        private System.Boolean get_IsECSCollider() { }
        private UnityEngine.Collider get_collider() { }
        private System.Int32 get_colliderInstanceID() { }
        private UnityEngine.Collider get_editorCollider() { }
        private UnityEngine.ECSColliderResultProxy get_colliderProxy() { }
        private UnityEngine.Vector3 get_point() { }
        private System.Void set_point(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_normal() { }
        private System.Void set_normal(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_barycentricCoordinate() { }
        private System.Void set_barycentricCoordinate(UnityEngine.Vector3 value) { }
        private System.Single get_distance() { }
        private System.Void set_distance(System.Single value) { }
        private System.Int32 get_triangleIndex() { }
        private System.Int32 get_componentIndex() { }
        private UnityEngine.Vector2 CalculateRaycastTexCoord(UnityEngine.Collider collider, System.Int32 m_Index, UnityEngine.Vector2 uv, UnityEngine.Vector3 pos, System.UInt32 face, System.Int32 textcoord) { }
        private UnityEngine.Vector2 get_textureCoord() { }
        private UnityEngine.Vector2 get_textureCoord2() { }
        private UnityEngine.Transform get_transform() { }
        private UnityEngine.Vector3 get_shapePosition() { }
        private UnityEngine.Quaternion get_shapeRotation() { }
        private UnityEngine.Vector3 get_position() { }
        private UnityEngine.Quaternion get_rotation() { }
        private UnityEngine.Vector3 get_scale() { }
        private UnityEngine.Rigidbody get_rigidbody() { }
        private UnityEngine.ArticulationBody get_articulationBody() { }
        private UnityEngine.Vector2 get_lightmapCoord() { }
        private UnityEngine.Vector2 get_textureCoord1() { }
        private System.Void CalculateRaycastTexCoord_Injected(UnityEngine.Collider collider, System.Int32 m_Index, UnityEngine.Vector2& uv, UnityEngine.Vector3& pos, System.UInt32 face, System.Int32 textcoord, UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x2000013
    public class Rigidbody : Component
    {
        // Methods
        private UnityEngine.Vector3 get_velocity() { }
        private System.Void set_velocity(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_angularVelocity() { }
        private System.Void set_angularVelocity(UnityEngine.Vector3 value) { }
        private System.Single get_drag() { }
        private System.Void set_drag(System.Single value) { }
        private System.Single get_angularDrag() { }
        private System.Void set_angularDrag(System.Single value) { }
        private System.Single get_mass() { }
        private System.Void set_mass(System.Single value) { }
        private System.Void SetDensity(System.Single density) { }
        private System.Boolean get_useGravity() { }
        private System.Void set_useGravity(System.Boolean value) { }
        private System.Single get_maxDepenetrationVelocity() { }
        private System.Void set_maxDepenetrationVelocity(System.Single value) { }
        private System.Boolean get_isKinematic() { }
        private System.Void set_isKinematic(System.Boolean value) { }
        private System.Boolean get_freezeRotation() { }
        private System.Void set_freezeRotation(System.Boolean value) { }
        private UnityEngine.RigidbodyConstraints get_constraints() { }
        private System.Void set_constraints(UnityEngine.RigidbodyConstraints value) { }
        private UnityEngine.CollisionDetectionMode get_collisionDetectionMode() { }
        private System.Void set_collisionDetectionMode(UnityEngine.CollisionDetectionMode value) { }
        private UnityEngine.Vector3 get_centerOfMass() { }
        private System.Void set_centerOfMass(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_worldCenterOfMass() { }
        private UnityEngine.Quaternion get_inertiaTensorRotation() { }
        private System.Void set_inertiaTensorRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_inertiaTensor() { }
        private System.Void set_inertiaTensor(UnityEngine.Vector3 value) { }
        private System.Boolean get_detectCollisions() { }
        private System.Void set_detectCollisions(System.Boolean value) { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private UnityEngine.RigidbodyInterpolation get_interpolation() { }
        private System.Void set_interpolation(UnityEngine.RigidbodyInterpolation value) { }
        private System.Int32 get_solverIterations() { }
        private System.Void set_solverIterations(System.Int32 value) { }
        private System.Single get_sleepThreshold() { }
        private System.Void set_sleepThreshold(System.Single value) { }
        private System.Single get_maxAngularVelocity() { }
        private System.Void set_maxAngularVelocity(System.Single value) { }
        private System.Void MovePosition(UnityEngine.Vector3 position) { }
        private System.Void MoveRotation(UnityEngine.Quaternion rot) { }
        private System.Void Sleep() { }
        private System.Boolean IsSleeping() { }
        private System.Void WakeUp() { }
        private System.Void ResetCenterOfMass() { }
        private System.Void ResetInertiaTensor() { }
        private UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3 relativePoint) { }
        private UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 worldPoint) { }
        private System.Int32 get_solverVelocityIterations() { }
        private System.Void set_solverVelocityIterations(System.Int32 value) { }
        private System.Void AddForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode) { }
        private System.Void AddForce(UnityEngine.Vector3 force) { }
        private System.Void AddForce(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode) { }
        private System.Void AddForce(System.Single x, System.Single y, System.Single z) { }
        private System.Void AddRelativeForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode) { }
        private System.Void AddRelativeForce(UnityEngine.Vector3 force) { }
        private System.Void AddRelativeForce(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode) { }
        private System.Void AddRelativeForce(System.Single x, System.Single y, System.Single z) { }
        private System.Void AddTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode) { }
        private System.Void AddTorque(UnityEngine.Vector3 torque) { }
        private System.Void AddTorque(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode) { }
        private System.Void AddTorque(System.Single x, System.Single y, System.Single z) { }
        private System.Void AddRelativeTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode) { }
        private System.Void AddRelativeTorque(UnityEngine.Vector3 torque) { }
        private System.Void AddRelativeTorque(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode) { }
        private System.Void AddRelativeTorque(System.Single x, System.Single y, System.Single z) { }
        private System.Void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode) { }
        private System.Void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position) { }
        private System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius, System.Single upwardsModifier, UnityEngine.ForceMode mode) { }
        private System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius, System.Single upwardsModifier) { }
        private System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius) { }
        private System.Void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, UnityEngine.Vector3& outPos, System.Single& distance) { }
        private UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position) { }
        private UnityEngine.RaycastHit SweepTest(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.Boolean& hasHit) { }
        private System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        private System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        private UnityEngine.RaycastHit[] Internal_SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance) { }
        private UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction) { }
        private System.Single get_sleepVelocity() { }
        private System.Void set_sleepVelocity(System.Single value) { }
        private System.Single get_sleepAngularVelocity() { }
        private System.Void set_sleepAngularVelocity(System.Single value) { }
        private System.Void SetMaxAngularVelocity(System.Single a) { }
        private System.Boolean get_useConeFriction() { }
        private System.Void set_useConeFriction(System.Boolean value) { }
        private System.Int32 get_solverIterationCount() { }
        private System.Void set_solverIterationCount(System.Int32 value) { }
        private System.Int32 get_solverVelocityIterationCount() { }
        private System.Void set_solverVelocityIterationCount(System.Int32 value) { }
        private System.Void .ctor() { }
        private System.Void get_velocity_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_velocity_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_angularVelocity_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_angularVelocity_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_centerOfMass_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_centerOfMass_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_worldCenterOfMass_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_inertiaTensorRotation_Injected(UnityEngine.Quaternion& ret) { }
        private System.Void set_inertiaTensorRotation_Injected(UnityEngine.Quaternion& value) { }
        private System.Void get_inertiaTensor_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_inertiaTensor_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_position_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_position_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_rotation_Injected(UnityEngine.Quaternion& ret) { }
        private System.Void set_rotation_Injected(UnityEngine.Quaternion& value) { }
        private System.Void MovePosition_Injected(UnityEngine.Vector3& position) { }
        private System.Void MoveRotation_Injected(UnityEngine.Quaternion& rot) { }
        private System.Void GetRelativePointVelocity_Injected(UnityEngine.Vector3& relativePoint, UnityEngine.Vector3& ret) { }
        private System.Void GetPointVelocity_Injected(UnityEngine.Vector3& worldPoint, UnityEngine.Vector3& ret) { }
        private System.Void AddForce_Injected(UnityEngine.Vector3& force, UnityEngine.ForceMode mode) { }
        private System.Void AddRelativeForce_Injected(UnityEngine.Vector3& force, UnityEngine.ForceMode mode) { }
        private System.Void AddTorque_Injected(UnityEngine.Vector3& torque, UnityEngine.ForceMode mode) { }
        private System.Void AddRelativeTorque_Injected(UnityEngine.Vector3& torque, UnityEngine.ForceMode mode) { }
        private System.Void AddForceAtPosition_Injected(UnityEngine.Vector3& force, UnityEngine.Vector3& position, UnityEngine.ForceMode mode) { }
        private System.Void AddExplosionForce_Injected(System.Single explosionForce, UnityEngine.Vector3& explosionPosition, System.Single explosionRadius, System.Single upwardsModifier, UnityEngine.ForceMode mode) { }
        private System.Void Internal_ClosestPointOnBounds_Injected(UnityEngine.Vector3& point, UnityEngine.Vector3& outPos, System.Single& distance) { }
        private System.Void SweepTest_Injected(UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        private UnityEngine.RaycastHit[] Internal_SweepTestAll_Injected(UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000014
    public struct ECSColliderType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ECSColliderType Default;        // 0x0
        public static UnityEngine.ECSColliderType BoxCollider;        // 0x0
        public static UnityEngine.ECSColliderType CapsuleCollider;        // 0x0
        public static UnityEngine.ECSColliderType SphereCollider;        // 0x0
        public static UnityEngine.ECSColliderType MeshCollider;        // 0x0
        public static UnityEngine.ECSColliderType MultiCollider;        // 0x0
        public static UnityEngine.ECSColliderType TerrainCollider;        // 0x0
        public static UnityEngine.ECSColliderType ECSCollider;        // 0x0
        public static UnityEngine.ECSColliderType Invalid;        // 0x0

    }

    // TypeToken: 0x2000015
    public class Collider : Component
    {
        // Methods
        private System.Boolean get_enabled() { }
        private System.Void set_enabled(System.Boolean value) { }
        private UnityEngine.Rigidbody get_attachedRigidbody() { }
        private UnityEngine.ArticulationBody get_attachedArticulationBody() { }
        private System.Boolean get_isTrigger() { }
        private System.Void set_isTrigger(System.Boolean value) { }
        private System.Boolean get_enableDither() { }
        private System.Void set_enableDither(System.Boolean value) { }
        private System.Single get_contactOffset() { }
        private System.Void set_contactOffset(System.Single value) { }
        private UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position) { }
        private UnityEngine.Bounds get_bounds() { }
        private System.Boolean get_hasModifiableContacts() { }
        private System.Void set_hasModifiableContacts(System.Boolean value) { }
        private UnityEngine.ColliderSurfaceType get_surfaceType() { }
        private System.Void set_surfaceType(UnityEngine.ColliderSurfaceType value) { }
        private System.Int32 get_tagConfig() { }
        private System.Void set_tagConfig(System.Int32 value) { }
        private System.Int32 get_colliderOptions() { }
        private System.Void set_colliderOptions(System.Int32 value) { }
        private System.IntPtr GetActor() { }
        private System.Int32 GetComponentIndex() { }
        private System.Int32 GetFactoryBuildingIdentifier() { }
        private System.Void SetFactoryBuildingIdentifier(System.Int32 value) { }
        private UnityEngine.PhysicMaterial get_sharedMaterial() { }
        private System.Void set_sharedMaterial(UnityEngine.PhysicMaterial value) { }
        private UnityEngine.PhysicMaterial get_material() { }
        private System.Void set_material(UnityEngine.PhysicMaterial value) { }
        private UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Boolean& hasHit) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        private System.Void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, UnityEngine.Vector3& outPos, System.Single& distance) { }
        private UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position) { }
        private System.Boolean CanColliderComputeClosestPoint() { }
        private UnityEngine.Vector3 TryGetClosestPoint_Internal(UnityEngine.Vector3 point, System.Boolean& resultIsValid) { }
        private System.Boolean TryGetClosestPoint(UnityEngine.Vector3 point, UnityEngine.Vector3& result) { }
        private System.Void .ctor() { }
        private System.Void ClosestPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret) { }
        private System.Void get_bounds_Injected(UnityEngine.Bounds& ret) { }
        private System.Void Raycast_Injected(UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        private System.Void Internal_ClosestPointOnBounds_Injected(UnityEngine.Vector3& point, UnityEngine.Vector3& outPos, System.Single& distance) { }
        private System.Void TryGetClosestPoint_Internal_Injected(UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x2000016
    public class ECSCollider
    {
        // Fields
        private System.IntPtr self;        // 0x10
        public static UnityEngine.ECSCollider.CollisionCallback collisionEnterCallback;        // 0x0
        public static UnityEngine.ECSCollider.CollisionCallback collisionStayCallback;        // 0x8
        public static UnityEngine.ECSCollider.CollisionCallback collisionExitCallback;        // 0x10
        public static UnityEngine.ECSCollider.CollisionCallback triggerEnterCallback;        // 0x18
        public static UnityEngine.ECSCollider.CollisionCallback triggerStayCallback;        // 0x20
        public static UnityEngine.ECSCollider.CollisionCallback triggerExitCallback;        // 0x28

        // Methods
        private System.IntPtr CreateActor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.UInt32 layer, System.Int32 tagInt, System.Boolean movable, System.Boolean enableDither) { }
        private System.Void DestroyActor(System.Int32 id, System.UInt32 version) { }
        private System.IntPtr Decode(System.IntPtr data, System.Int32 length, System.IntPtr meshes, System.Int32 meshesCount, UnityEngine.Texture2D heightmaps) { }
        private System.IntPtr Decode(System.IntPtr data, System.Int32 length, Unity.Collections.NativeArray<System.Int32> meshInstanceIds, UnityEngine.Texture2D heightmap) { }
        private System.Void RecordEntity(System.IntPtr actor, UnityEngine.HyperGryph.ECS.Entity entity) { }
        private System.Int32 GetId(System.IntPtr actor) { }
        private System.UInt32 GetVersion(System.IntPtr actor) { }
        private System.Boolean IsValid(System.Int32 id, System.UInt32 version, System.IntPtr actor) { }
        private UnityEngine.HyperGryph.ECS.Entity GetEntity(System.Int32 id, System.UInt32 version) { }
        private UnityEngine.Vector3 GetPosition(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        private UnityEngine.Vector3 GetShapePosition(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        private System.Void SetPosition(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 position) { }
        private UnityEngine.Quaternion GetShapeRotation(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        private UnityEngine.Quaternion GetRotation(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        private System.Void SetRotation(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion rotation) { }
        private System.Void AttachBox(System.Int32 id, System.UInt32 version, UnityEngine.Vector3 halfExtent, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation, System.Int32 surfaceType, System.Int32 colliderOption, System.Int32 tag, System.Boolean isTrigger, System.Boolean isPrimitive) { }
        private System.Boolean HasComplexMesh(System.Int32 id, System.UInt32 version) { }
        private UnityEngine.RaycastHit Raycast_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit) { }
        private System.Boolean Raycast(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hitInfo) { }
        private UnityEngine.RaycastHit RaycastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit) { }
        private System.Boolean RaycastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hitInfo) { }
        private UnityEngine.RaycastHit CapsuleCastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit) { }
        private System.Boolean CapsuleCastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo) { }
        private UnityEngine.RaycastHit SphereCastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit) { }
        private System.Boolean SphereCastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo) { }
        private System.Boolean CanColliderComputeClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        private UnityEngine.ColliderSurfaceType GetSurfaceTypeAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        private System.Int32 GetColliderOptionAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        private System.Int32 GetTagConfigAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        private System.Boolean GetIsTrigger(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        private UnityEngine.Bounds GetBounds(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        private UnityEngine.Vector3 TryGetClosestPoint_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 point, System.Boolean& resultIsValid) { }
        private System.Boolean TryGetClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 point, UnityEngine.Vector3& result) { }
        private UnityEngine.Vector3 ClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 position) { }
        private System.Boolean CompareTag(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 tagValue) { }
        private System.Int32 GetLayer(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        private System.Int32 GetFactoryBuildingIdentifier(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        private System.Void SetFactoryBuildingIdentifier(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 identifier) { }
        private System.Void OnCollisionEnterV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        private System.Void OnCollisionStayV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        private System.Void OnCollisionExitV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        private System.Void OnTriggerEnterV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        private System.Void OnTriggerStayV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        private System.Void OnTriggerExitV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        private System.Void ToggleCollision(System.Int32 id, System.UInt32 version, System.Boolean enableCollision) { }
        private System.IntPtr CreateActor_Injected(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, System.UInt32 layer, System.Int32 tagInt, System.Boolean movable, System.Boolean enableDither) { }
        private System.Void RecordEntity_Injected(System.IntPtr actor, UnityEngine.HyperGryph.ECS.Entity& entity) { }
        private System.Void GetEntity_Injected(System.Int32 id, System.UInt32 version, UnityEngine.HyperGryph.ECS.Entity& ret) { }
        private System.Void GetPosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& ret) { }
        private System.Void GetShapePosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index, UnityEngine.Vector3& ret) { }
        private System.Void SetPosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& position) { }
        private System.Void GetShapeRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index, UnityEngine.Quaternion& ret) { }
        private System.Void GetRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion& ret) { }
        private System.Void SetRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion& rotation) { }
        private System.Void AttachBox_Injected(System.Int32 id, System.UInt32 version, UnityEngine.Vector3& halfExtent, UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation, System.Int32 surfaceType, System.Int32 colliderOption, System.Int32 tag, System.Boolean isTrigger, System.Boolean isPrimitive) { }
        private System.Void Raycast_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        private System.Void RaycastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        private System.Void CapsuleCastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        private System.Void SphereCastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& center, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        private System.Void GetBounds_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Bounds& ret) { }
        private System.Void TryGetClosestPoint_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret) { }
        private System.Void ClosestPoint_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& position, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x2000018
    public class CharacterController : Collider
    {
        // Methods
        private System.Boolean get_isGrounded() { }

    }

    // TypeToken: 0x2000019
    public class MultiCollider : Collider
    {
        // Methods
        private System.Void AppendBoxCollider(UnityEngine.BoxCollider boxCollider) { }
        private System.Void AppendCapsuleCollider(UnityEngine.CapsuleCollider collider) { }
        private System.Void AppendSphereCollider(UnityEngine.SphereCollider collider) { }
        private UnityEngine.ColliderSurfaceType GetSurfaceTypeAt(System.Int32 index) { }
        private System.Int32 GetTagConfigAt(System.Int32 index) { }
        private System.Int32 GetGameplayOptionAt(System.Int32 index) { }
        private System.Boolean GetIsTriggerAt(System.Int32 index) { }
        private UnityEngine.Mesh get_ComplexMesh() { }
        private System.Boolean RaycastComplexMesh(UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        private UnityEngine.RaycastHit CapsuleCastComplexMesh_Internal(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit) { }
        private System.Boolean CapsuleCastComplexMesh(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        private UnityEngine.RaycastHit SphereCastComplexMesh_Internal(UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit) { }
        private System.Boolean SphereCastComplexMesh(UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        private System.Boolean RaycastComplexMesh_Injected(UnityEngine.Ray& ray, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        private System.Void CapsuleCastComplexMesh_Internal_Injected(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        private System.Void SphereCastComplexMesh_Internal_Injected(UnityEngine.Vector3& center, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }

    }

    // TypeToken: 0x200001A
    public class MeshCollider : Collider
    {
        // Methods
        private UnityEngine.Mesh get_sharedMesh() { }
        private System.Void set_sharedMesh(UnityEngine.Mesh value) { }
        private System.Boolean get_convex() { }
        private System.Void set_convex(System.Boolean value) { }
        private UnityEngine.MeshColliderCookingOptions get_cookingOptions() { }
        private System.Void set_cookingOptions(UnityEngine.MeshColliderCookingOptions value) { }
        private System.Boolean NeedsReadWriteEnabled() { }
        private System.Boolean get_smoothSphereCollisions() { }
        private System.Void set_smoothSphereCollisions(System.Boolean value) { }
        private System.Single get_skinWidth() { }
        private System.Void set_skinWidth(System.Single value) { }
        private System.Boolean get_inflateMesh() { }
        private System.Void set_inflateMesh(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public class CapsuleCollider : Collider
    {
        // Methods
        private UnityEngine.Vector3 get_center() { }
        private System.Void set_center(UnityEngine.Vector3 value) { }
        private System.Single get_radius() { }
        private System.Void set_radius(System.Single value) { }
        private System.Single get_height() { }
        private System.Void set_height(System.Single value) { }
        private System.Int32 get_direction() { }
        private System.Void set_direction(System.Int32 value) { }
        private System.Void get_center_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_center_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200001C
    public class BoxCollider : Collider
    {
        // Methods
        private UnityEngine.Vector3 get_center() { }
        private System.Void set_center(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_size() { }
        private System.Void set_size(UnityEngine.Vector3 value) { }
        private System.Void get_center_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_center_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_size_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_size_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200001D
    public class SphereCollider : Collider
    {
        // Methods
        private UnityEngine.Vector3 get_center() { }
        private System.Void set_center(UnityEngine.Vector3 value) { }
        private System.Single get_radius() { }
        private System.Void set_radius(System.Single value) { }
        private System.Void get_center_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_center_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200001E
    public class Joint : Component
    {
        // Methods
        private UnityEngine.Rigidbody get_connectedBody() { }
        private System.Void set_connectedAnchor(UnityEngine.Vector3 value) { }
        private System.Void set_connectedAnchor_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200001F
    public struct ContactPoint
    {
        // Fields
        private UnityEngine.Vector3 m_Point;        // 0x10
        private UnityEngine.Vector3 m_Normal;        // 0x1C
        private System.Int32 m_ThisColliderInstanceID;        // 0x28
        private System.Int32 m_OtherColliderInstanceID;        // 0x2C
        private System.Single m_Separation;        // 0x30

        // Methods
        private UnityEngine.Vector3 get_point() { }
        private UnityEngine.Vector3 get_normal() { }
        private UnityEngine.Collider get_thisCollider() { }
        private UnityEngine.Collider get_otherCollider() { }
        private UnityEngine.Collider GetColliderByInstanceID(System.Int32 instanceID) { }

    }

    // TypeToken: 0x2000020
    public struct PhysicsScene, IEquatable`1
    {
        // Fields
        private System.Int32 m_Handle;        // 0x10

        // Methods
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.PhysicsScene other) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Query_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Internal_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_CapsuleCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_CapsuleCastNonAllocV2(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 diretion, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 CapsuleCastV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapCapsuleNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapCapsuleNonAlloc_InternalV2(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Query_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Internal_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_SphereCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapSphereNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapSphere(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapSphereNonAllocV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Query_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, UnityEngine.RaycastHit& outHit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Internal_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapBoxNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapBoxNonAllocV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_BoxCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Internal_RaycastTest_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Internal_Raycast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, UnityEngine.RaycastHit& hit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_RaycastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Query_CapsuleCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_CapsuleCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_CapsuleCastNonAllocV2_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& diretion, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapCapsuleNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapCapsuleNonAlloc_InternalV2_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Query_SphereCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_SphereCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapSphereNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapSphereNonAllocV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Boolean Query_BoxCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.Quaternion& orientation, System.Single maxDistance, UnityEngine.RaycastHit& outHit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapBoxNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion& orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 OverlapBoxNonAllocV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion& orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.Int32 Internal_BoxCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion& orientation, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000021
    public struct QueryParameters
    {
        // Fields
        public System.Int32 layerMask;        // 0x10
        public System.Boolean hitMultipleFaces;        // 0x14
        public System.Boolean hitBackfaces;        // 0x15
        public UnityEngine.QueryTriggerInteraction hitTriggers;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 layerMask, System.Boolean hitMultipleFaces, UnityEngine.QueryTriggerInteraction hitTriggers, System.Boolean hitBackfaces) { }

    }

    // TypeToken: 0x2000022
    public struct RaycastCommand
    {
        // Fields
        private UnityEngine.Vector3 <from>k__BackingField;        // 0x10
        private UnityEngine.Vector3 <direction>k__BackingField;        // 0x1C
        private System.Single <distance>k__BackingField;        // 0x28
        private UnityEngine.PhysicsScene <physicsScene>k__BackingField;        // 0x2C
        public UnityEngine.QueryParameters queryParameters;        // 0x30

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 from, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, System.Single distance) { }
        private UnityEngine.Vector3 get_from() { }
        private System.Void set_from(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_direction() { }
        private System.Void set_direction(UnityEngine.Vector3 value) { }
        private System.Single get_distance() { }
        private System.Void set_distance(System.Single value) { }
        private System.Void set_physicsScene(UnityEngine.PhysicsScene value) { }
        private Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ScheduleRaycastBatch(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits) { }
        private System.Void ScheduleRaycastBatch_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle& ret) { }

    }

    // TypeToken: 0x2000023
    public struct BoxcastCommand
    {
        // Fields
        private UnityEngine.Vector3 <center>k__BackingField;        // 0x10
        private UnityEngine.Vector3 <halfExtents>k__BackingField;        // 0x1C
        private UnityEngine.Quaternion <orientation>k__BackingField;        // 0x28
        private UnityEngine.Vector3 <direction>k__BackingField;        // 0x38
        private System.Single <distance>k__BackingField;        // 0x44
        private UnityEngine.PhysicsScene <physicsScene>k__BackingField;        // 0x48
        public UnityEngine.QueryParameters queryParameters;        // 0x4C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, System.Single distance) { }
        private System.Void set_center(UnityEngine.Vector3 value) { }
        private System.Void set_halfExtents(UnityEngine.Vector3 value) { }
        private System.Void set_orientation(UnityEngine.Quaternion value) { }
        private System.Void set_direction(UnityEngine.Vector3 value) { }
        private System.Void set_distance(System.Single value) { }
        private System.Void set_physicsScene(UnityEngine.PhysicsScene value) { }
        private Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ScheduleBoxcastBatch(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits) { }
        private System.Void ScheduleBoxcastBatch_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle& ret) { }

    }

}

