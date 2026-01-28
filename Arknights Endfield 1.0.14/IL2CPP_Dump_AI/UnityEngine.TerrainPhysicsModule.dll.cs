// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TerrainPhysicsModule.dll
// Classes:  3
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngine.HGTerrainRaycastHit
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  private           UnityEngine.Vector3             m_Position  // 0x10
  private           UnityEngine.Vector3             m_Normal  // 0x1C
  private           System.Single                   m_Distance  // 0x28
  private           UnityEngine.Vector3             m_Edge01  // 0x2C
  private           UnityEngine.Vector3             m_Edge02  // 0x38
METHODS:
  UnityEngine.Vector3 get_position()
  UnityEngine.Vector3 get_normal()
  UnityEngine.Vector3 get_edge01()
  UnityEngine.Vector3 get_edge02()
  System.Single get_distance()
END_CLASS

CLASS: UnityEngine.TerrainCollider
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Collider
FIELDS:
METHODS:
  System.Void set_terrainData(UnityEngine.TerrainData value)
  UnityEngine.HGTerrainRaycastHit HGTerrainRaycast(UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit)
  System.Boolean HGTerrainRaycast(UnityEngine.Ray ray, UnityEngine.HGTerrainRaycastHit& hitInfo, System.Single maxDistance, System.Boolean hitHoles)
  System.Void HGTerrainRaycast_Injected(UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.HGTerrainRaycastHit& ret)
END_CLASS

