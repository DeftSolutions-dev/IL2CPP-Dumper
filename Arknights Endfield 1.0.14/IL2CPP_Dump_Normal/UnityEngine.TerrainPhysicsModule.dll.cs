// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TerrainPhysicsModule.dll
// Classes:  3
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public struct HGTerrainRaycastHit
    {
        // Fields
        private UnityEngine.Vector3 m_Position;        // 0x10
        private UnityEngine.Vector3 m_Normal;        // 0x1C
        private System.Single m_Distance;        // 0x28
        private UnityEngine.Vector3 m_Edge01;        // 0x2C
        private UnityEngine.Vector3 m_Edge02;        // 0x38

        // Methods
        private UnityEngine.Vector3 get_position() { }
        private UnityEngine.Vector3 get_normal() { }
        private UnityEngine.Vector3 get_edge01() { }
        private UnityEngine.Vector3 get_edge02() { }
        private System.Single get_distance() { }

    }

    // TypeToken: 0x2000003
    public class TerrainCollider : Collider
    {
        // Methods
        private System.Void set_terrainData(UnityEngine.TerrainData value) { }
        private UnityEngine.HGTerrainRaycastHit HGTerrainRaycast(UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit) { }
        private System.Boolean HGTerrainRaycast(UnityEngine.Ray ray, UnityEngine.HGTerrainRaycastHit& hitInfo, System.Single maxDistance, System.Boolean hitHoles) { }
        private System.Void HGTerrainRaycast_Injected(UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.HGTerrainRaycastHit& ret) { }

    }

}

