// ========================================================
// Dumped by @desirepro
// Assembly: AstarPathfindingProject.dll
// Classes:  22
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000F
    public struct RVOParallelJob, IJobParallelFor
    {
        // Fields
        public System.Int32 agentCount;        // 0x10
        public Unity.Collections.NativeList<RVO.RVOAgentJobData> agents;        // 0x18
        public System.Int32 obstacleCount;        // 0x28
        public System.Single breakingBias;        // 0x2C
        public Unity.Collections.NativeArray<System.Int32> obsBufferMaxIndex;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> agentBufferMaxIndex;        // 0x40
        public Unity.Collections.NativeArray<RVO.VO> obsVoBuffer;        // 0x50
        public Unity.Collections.NativeArray<RVO.VO> agentVoBuffer;        // 0x60
        public Unity.Collections.NativeArray<System.Single> calculatedSpeeds;        // 0x70
        public Unity.Collections.NativeArray<UnityEngine.Vector2> calculatedTargetPoints;        // 0x80

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000010
    public struct JobForCalcObstacleVO, IJobParallelFor
    {
        // Fields
        public System.Int32 agentCount;        // 0x10
        public Unity.Collections.NativeList<RVO.RVOAgentJobData> agents;        // 0x18
        public System.Int32 obstacleCount;        // 0x28
        public Unity.Collections.NativeList<RVO.RVOObstacleJobData> obstacles;        // 0x30
        public System.Single deltaTime;        // 0x40
        public Unity.Collections.NativeArray<System.Int32> obsBufferMaxIndex;        // 0x48
        public Unity.Collections.NativeArray<RVO.VO> obsVoBuffer;        // 0x58

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000011
    public struct JobForCalcAgentNeighbourVO, IJobParallelFor
    {
        // Fields
        public System.Int32 agentCount;        // 0x10
        public Unity.Collections.NativeList<RVO.RVOAgentJobData> agents;        // 0x18
        public Unity.Collections.NativeList<System.Boolean> agentNeighbours;        // 0x28
        public System.Single deltaTime;        // 0x38
        public Unity.Collections.NativeArray<System.Int32> agentBufferMaxIndex;        // 0x40
        public Unity.Collections.NativeArray<RVO.VO> agentVoBuffer;        // 0x50

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000014
    public struct Node
    {
        // Fields
        public System.Int32 child00;        // 0x10
        public RVO.RVOAgent linkedList;        // 0x18
        public System.Byte count;        // 0x20
        public System.Single maxSpeed;        // 0x24

        // Methods
        private System.Void Add(RVO.RVOAgent rvoAgent) { }
        private System.Void Distribute(RVO.RVOQuadtree.Node[] nodes, UnityEngine.Rect r) { }
        private System.Single CalculateMaxSpeed(RVO.RVOQuadtree.Node[] nodes, System.Int32 index) { }

    }

    // TypeToken: 0x2000015
    public struct QuadtreeQuery
    {
        // Fields
        public UnityEngine.Vector2 p;        // 0x10
        public System.Single speed;        // 0x18
        public System.Single timeHorizon;        // 0x1C
        public System.Single agentRadius;        // 0x20
        public System.Single maxRadius;        // 0x24
        public RVO.RVOAgent RvoAgent;        // 0x28
        public RVO.RVOQuadtree.Node[] nodes;        // 0x30

        // Methods
        private System.Void QueryRec(System.Int32 i, UnityEngine.Rect r) { }

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

namespace RVO
{

    // TypeToken: 0x2000004
    public class AstarMemory
    {
        // Methods
        private T[] ShrinkArray(T[] arr, System.Int32 newLength) { }
        private System.Void Swap(T& a, T& b) { }
        private System.Void Realloc(Unity.Collections.NativeArray<T>& arr, System.Int32 newSize, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options) { }
        private System.Void Realloc(T[]& arr, System.Int32 newSize) { }
        private T[] UnsafeAppendBufferToArray(Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer src) { }

    }

    // TypeToken: 0x2000005
    public class NativeCollectionExtensions
    {
        // Methods
        private System.Void FillIn(Unity.Collections.NativeArray<T>& array, System.Int32 start, System.Int32 length, T value) { }
        private System.Void SetValueAt(Unity.Collections.NativeArray<T>& array, System.Int32 index, T value) { }
        private T GetValueAt(Unity.Collections.NativeArray<T>& array, System.Int32 index) { }

    }

    // TypeToken: 0x2000006
    public struct RVOLayer
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RVO.RVOLayer DefaultAgent;        // 0x0
        public static RVO.RVOLayer DefaultObstacle;        // 0x0
        public static RVO.RVOLayer Character;        // 0x0
        public static RVO.RVOLayer Enemy;        // 0x0
        public static RVO.RVOLayer NPC;        // 0x0
        public static RVO.RVOLayer FactoryObstacle;        // 0x0
        public static RVO.RVOLayer Layer6;        // 0x0
        public static RVO.RVOLayer Layer7;        // 0x0
        public static RVO.RVOLayer Layer8;        // 0x0
        public static RVO.RVOLayer Layer9;        // 0x0
        public static RVO.RVOLayer Layer10;        // 0x0
        public static RVO.RVOLayer Layer11;        // 0x0
        public static RVO.RVOLayer Layer12;        // 0x0
        public static RVO.RVOLayer Layer13;        // 0x0
        public static RVO.RVOLayer Layer14;        // 0x0
        public static RVO.RVOLayer Layer15;        // 0x0
        public static RVO.RVOLayer Layer16;        // 0x0
        public static RVO.RVOLayer Layer17;        // 0x0
        public static RVO.RVOLayer Layer18;        // 0x0
        public static RVO.RVOLayer Layer19;        // 0x0
        public static RVO.RVOLayer Layer20;        // 0x0
        public static RVO.RVOLayer Layer21;        // 0x0
        public static RVO.RVOLayer Layer22;        // 0x0
        public static RVO.RVOLayer Layer23;        // 0x0
        public static RVO.RVOLayer Layer24;        // 0x0
        public static RVO.RVOLayer Layer25;        // 0x0
        public static RVO.RVOLayer Layer26;        // 0x0
        public static RVO.RVOLayer Layer27;        // 0x0
        public static RVO.RVOLayer Layer28;        // 0x0
        public static RVO.RVOLayer Layer29;        // 0x0
        public static RVO.RVOLayer Layer30;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct Side
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static RVO.Side Colinear;        // 0x0
        public static RVO.Side Left;        // 0x0
        public static RVO.Side Right;        // 0x0

    }

    // TypeToken: 0x2000008
    public class VectorMath
    {
        // Methods
        private UnityEngine.Vector2 ComplexMultiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        private UnityEngine.Vector2 ComplexMultiplyConjugate(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        private UnityEngine.Vector3 ClosestPointOnLine(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point) { }
        private System.Single ClosestPointOnLineFactor(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point) { }
        private System.Single ClosestPointOnLineFactor(RVO.Int3 lineStart, RVO.Int3 lineEnd, RVO.Int3 point) { }
        private System.Single ClosestPointOnLineFactor(RVO.Int2 lineStart, RVO.Int2 lineEnd, RVO.Int2 point) { }
        private UnityEngine.Vector3 ClosestPointOnSegment(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 ClosestPointOnSegmentXZ(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point) { }
        private System.Single SqrDistancePointSegmentApproximate(System.Int32 x, System.Int32 z, System.Int32 px, System.Int32 pz, System.Int32 qx, System.Int32 qz) { }
        private System.Single SqrDistancePointSegmentApproximate(RVO.Int3 a, RVO.Int3 b, RVO.Int3 p) { }
        private System.Single SqrDistancePointSegment(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 p) { }
        private System.Single SqrDistanceSegmentSegment(UnityEngine.Vector3 s1, UnityEngine.Vector3 e1, UnityEngine.Vector3 s2, UnityEngine.Vector3 e2) { }
        private System.Single SqrDistanceXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private System.Int64 SignedTriangleAreaTimes2XZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        private System.Single SignedTriangleAreaTimes2XZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        private System.Boolean RightXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 p) { }
        private System.Boolean RightXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 p) { }
        private RVO.Side SideXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 p) { }
        private System.Boolean RightOrColinear(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 p) { }
        private System.Boolean RightOrColinear(RVO.Int2 a, RVO.Int2 b, RVO.Int2 p) { }
        private System.Boolean RightOrColinearXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 p) { }
        private System.Boolean RightOrColinearXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 p) { }
        private System.Boolean IsClockwiseMarginXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        private System.Boolean IsClockwiseXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        private System.Boolean IsClockwiseXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        private System.Boolean IsClockwiseOrColinearXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        private System.Boolean IsClockwiseOrColinear(RVO.Int2 a, RVO.Int2 b, RVO.Int2 c) { }
        private System.Boolean IsColinear(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        private System.Boolean IsColinear(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c) { }
        private System.Boolean IsColinearXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        private System.Boolean IsColinearXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        private System.Boolean IsColinearAlmostXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        private System.Boolean SegmentsIntersect(RVO.Int2 start1, RVO.Int2 end1, RVO.Int2 start2, RVO.Int2 end2) { }
        private System.Boolean SegmentsIntersectXZ(RVO.Int3 start1, RVO.Int3 end1, RVO.Int3 start2, RVO.Int3 end2) { }
        private System.Boolean SegmentsIntersectXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2) { }
        private System.Boolean LineLineIntersectionFactor(UnityEngine.Vector2 start1, UnityEngine.Vector2 dir1, UnityEngine.Vector2 start2, UnityEngine.Vector2 dir2, System.Single& t) { }
        private UnityEngine.Vector3 LineDirIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 dir1, UnityEngine.Vector3 start2, UnityEngine.Vector3 dir2) { }
        private UnityEngine.Vector3 LineDirIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 dir1, UnityEngine.Vector3 start2, UnityEngine.Vector3 dir2, System.Boolean& intersects) { }
        private System.Boolean RaySegmentIntersectXZ(RVO.Int3 start1, RVO.Int3 end1, RVO.Int3 start2, RVO.Int3 end2) { }
        private System.Boolean LineIntersectionFactorXZ(RVO.Int3 start1, RVO.Int3 end1, RVO.Int3 start2, RVO.Int3 end2, System.Single& factor1, System.Single& factor2) { }
        private System.Boolean LineIntersectionFactorXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2, System.Single& factor1, System.Single& factor2) { }
        private System.Single LineRayIntersectionFactorXZ(RVO.Int3 start1, RVO.Int3 end1, RVO.Int3 start2, RVO.Int3 end2) { }
        private System.Single LineIntersectionFactorXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2) { }
        private UnityEngine.Vector3 LineIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2) { }
        private UnityEngine.Vector3 LineIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2, System.Boolean& intersects) { }
        private UnityEngine.Vector2 LineIntersectionPoint(UnityEngine.Vector2 start1, UnityEngine.Vector2 end1, UnityEngine.Vector2 start2, UnityEngine.Vector2 end2) { }
        private UnityEngine.Vector2 LineIntersectionPoint(UnityEngine.Vector2 start1, UnityEngine.Vector2 end1, UnityEngine.Vector2 start2, UnityEngine.Vector2 end2, System.Boolean& intersects) { }
        private UnityEngine.Vector3 SegmentIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2, System.Boolean& intersects) { }
        private System.Boolean SegmentIntersectsBounds(UnityEngine.Bounds bounds, UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private System.Single LineCircleIntersectionFactor(UnityEngine.Vector3 circleCenter, UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, System.Single radius) { }
        private System.Boolean ReversesFaceOrientations(UnityEngine.Matrix4x4 matrix) { }
        private System.Boolean ReversesFaceOrientationsXZ(UnityEngine.Matrix4x4 matrix) { }
        private UnityEngine.Vector3 Normalize(UnityEngine.Vector3 v, System.Single& magnitude) { }
        private UnityEngine.Vector2 Normalize(UnityEngine.Vector2 v, System.Single& magnitude) { }
        private UnityEngine.Vector3 ClampMagnitudeXZ(UnityEngine.Vector3 v, System.Single maxMagnitude) { }
        private System.Single MagnitudeXZ(UnityEngine.Vector3 v) { }

    }

    // TypeToken: 0x2000009
    public struct Int3, IEquatable`1
    {
        // Fields
        public System.Int32 x;        // 0x10
        public System.Int32 y;        // 0x14
        public System.Int32 z;        // 0x18
        public static System.Int32 Precision;        // 0x0
        public static System.Single FloatPrecision;        // 0x0
        public static System.Single PrecisionFactor;        // 0x0

        // Methods
        private RVO.Int3 get_zero() { }
        private System.Void .ctor(UnityEngine.Vector3 position) { }
        private System.Void .ctor(System.Int32 _x, System.Int32 _y, System.Int32 _z) { }
        private System.Boolean op_Equality(RVO.Int3 lhs, RVO.Int3 rhs) { }
        private System.Boolean op_Inequality(RVO.Int3 lhs, RVO.Int3 rhs) { }
        private RVO.Int3 op_Explicit(UnityEngine.Vector3 ob) { }
        private UnityEngine.Vector3 op_Explicit(RVO.Int3 ob) { }
        private RVO.Int3 op_Subtraction(RVO.Int3 lhs, RVO.Int3 rhs) { }
        private RVO.Int3 op_UnaryNegation(RVO.Int3 lhs) { }
        private RVO.Int3 op_Addition(RVO.Int3 lhs, RVO.Int3 rhs) { }
        private RVO.Int3 op_Multiply(RVO.Int3 lhs, System.Int32 rhs) { }
        private RVO.Int3 op_Multiply(RVO.Int3 lhs, System.Single rhs) { }
        private RVO.Int3 op_Multiply(RVO.Int3 lhs, System.Double rhs) { }
        private RVO.Int3 op_Division(RVO.Int3 lhs, System.Single rhs) { }
        private System.Int32 get_Item(System.Int32 i) { }
        private System.Void set_Item(System.Int32 i, System.Int32 value) { }
        private System.Single Angle(RVO.Int3 lhs, RVO.Int3 rhs) { }
        private System.Int32 Dot(RVO.Int3 lhs, RVO.Int3 rhs) { }
        private System.Int64 DotLong(RVO.Int3 lhs, RVO.Int3 rhs) { }
        private RVO.Int3 Normal2D() { }
        private System.Single get_magnitude() { }
        private System.Int32 get_costMagnitude() { }
        private System.Single get_sqrMagnitude() { }
        private System.Int64 get_sqrMagnitudeLong() { }
        private System.String op_Implicit(RVO.Int3 obj) { }
        private System.String ToString() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(RVO.Int3 other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000A
    public struct Int2, IEquatable`1
    {
        // Fields
        public System.Int32 x;        // 0x10
        public System.Int32 y;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 x, System.Int32 y) { }
        private System.Int64 get_sqrMagnitudeLong() { }
        private RVO.Int2 op_UnaryNegation(RVO.Int2 lhs) { }
        private RVO.Int2 op_Addition(RVO.Int2 a, RVO.Int2 b) { }
        private RVO.Int2 op_Subtraction(RVO.Int2 a, RVO.Int2 b) { }
        private System.Boolean op_Equality(RVO.Int2 a, RVO.Int2 b) { }
        private System.Boolean op_Inequality(RVO.Int2 a, RVO.Int2 b) { }
        private System.Int64 DotLong(RVO.Int2 a, RVO.Int2 b) { }
        private System.Boolean Equals(System.Object o) { }
        private System.Boolean Equals(RVO.Int2 other) { }
        private System.Int32 GetHashCode() { }
        private RVO.Int2 Min(RVO.Int2 a, RVO.Int2 b) { }
        private RVO.Int2 Max(RVO.Int2 a, RVO.Int2 b) { }
        private RVO.Int2 FromInt3XZ(RVO.Int3 o) { }
        private RVO.Int3 ToInt3XZ(RVO.Int2 o) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200000B
    public struct RVOAgentJobData
    {
        // Fields
        public System.Int32 agentID;        // 0x10
        public System.Int32 agentIndex;        // 0x14
        public System.Boolean manuallyControlled;        // 0x18
        public System.Boolean locked;        // 0x19
        public System.Single radius;        // 0x1C
        public System.Single height;        // 0x20
        public System.Single desiredSpeed;        // 0x24
        public System.Single maxSpeed;        // 0x28
        public System.Single agentTimeHorizon;        // 0x2C
        public System.Single obstacleTimeHorizon;        // 0x30
        public System.Single priority;        // 0x34
        public System.Single elevationCoordinate;        // 0x38
        public RVO.RVOLayer layer;        // 0x3C
        public RVO.RVOLayer collidesWith;        // 0x40
        public UnityEngine.Vector2 position;        // 0x44
        public UnityEngine.Vector2 currentVelocity;        // 0x4C
        public UnityEngine.Vector2 desiredVelocity;        // 0x54
        public UnityEngine.Vector2 desiredTargetPointInVelocitySpace;        // 0x5C

    }

    // TypeToken: 0x200000C
    public class RVOAgent
    {
        // Fields
        public System.Int32 agentID;        // 0x10
        public System.Int32 agentIndex;        // 0x14
        public System.Single radius;        // 0x18
        public System.Single height;        // 0x1C
        public System.Single desiredSpeed;        // 0x20
        public System.Single maxSpeed;        // 0x24
        public System.Single agentTimeHorizon;        // 0x28
        public System.Single obstacleTimeHorizon;        // 0x2C
        public System.Single priority;        // 0x30
        public System.Boolean locked;        // 0x34
        public RVO.RVOLayer layer;        // 0x38
        public RVO.RVOLayer collidesWith;        // 0x3C
        public System.Int32 maxNeighbours;        // 0x40
        public UnityEngine.Vector2 position;        // 0x44
        public UnityEngine.Vector3 position3;        // 0x4C
        public System.Single elevationCoordinate;        // 0x58
        public RVO.RVOAgent ignoreAgent;        // 0x60
        public UnityEngine.Vector2 currentVelocity;        // 0x68
        public UnityEngine.Vector2 desiredTargetPointInVelocitySpace;        // 0x70
        public UnityEngine.Vector2 desiredVelocity;        // 0x78
        public UnityEngine.Vector2 nextTargetPoint;        // 0x80
        public UnityEngine.Vector2 collisionNormal;        // 0x88
        public System.Boolean manuallyControlled;        // 0x90
        private System.Action <PreCalculationCallback>k__BackingField;        // 0x98
        public RVO.RVOAgent next;        // 0xA0
        public System.Single calculatedSpeed;        // 0xA8
        public UnityEngine.Vector2 calculatedTargetPoint;        // 0xAC
        private System.Collections.Generic.List<RVO.RVOAgent> m_neighbours;        // 0xB8
        private System.Collections.Generic.List<System.Single> m_neighbourDists;        // 0xC0

        // Methods
        private System.Action get_PreCalculationCallback() { }
        private System.Void set_PreCalculationCallback(System.Action value) { }
        private System.Void SetTarget(UnityEngine.Vector2 targetPoint, System.Single desiredSpeed, System.Single maxSpeed) { }
        private System.Void SetCollisionNormal(UnityEngine.Vector2 normal) { }
        private System.Void ForceSetVelocity(UnityEngine.Vector2 velocity) { }
        private System.Collections.Generic.List<RVO.RVOAgent> get_neighbours() { }
        private System.Void .ctor() { }
        private System.Void PreCalculation() { }
        private RVO.RVOAgentJobData CreateJobData() { }
        private System.Void PostCalculation(System.Single resultSpeed, UnityEngine.Vector2 resultTargetPoint) { }
        private System.Void CalculateNeighbours(RVO.RVOQuadtree quadtree, System.Single desiredDeltaTime) { }
        private System.Single InsertAgentNeighbour(RVO.RVOAgent rvoAgent, System.Single rangeSq) { }
        private UnityEngine.Color Rainbow(System.Single v) { }

    }

    // TypeToken: 0x200000D
    public struct RVOObstacleJobData
    {
        // Fields
        public System.Int32 obstacleID;        // 0x10
        public System.Int32 obstacleIndex;        // 0x14
        public RVO.RVOLayer layer;        // 0x18
        public System.Single height;        // 0x1C
        public UnityEngine.Vector3 position;        // 0x20

        // Methods
        private System.Boolean op_Equality(RVO.RVOObstacleJobData a, RVO.RVOObstacleJobData b) { }
        private System.Boolean op_Inequality(RVO.RVOObstacleJobData a, RVO.RVOObstacleJobData b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000E
    public class Simulator
    {
        // Fields
        private System.Single desiredDeltaTime;        // 0x10
        private Unity.Collections.NativeList<RVO.RVOAgentJobData> m_jobAgents;        // 0x18
        private Unity.Collections.NativeList<System.Boolean> m_jobNeighbours;        // 0x28
        private Unity.Collections.NativeList<RVO.RVOObstacleJobData> m_jobObstacles;        // 0x38
        private Unity.Collections.NativeArray<System.Single> m_jobCalculatedSpeeds;        // 0x48
        private Unity.Collections.NativeArray<UnityEngine.Vector2> m_jobCalculatedTargetPoints;        // 0x58
        private Unity.Collections.NativeArray<System.Int32> m_jobAgentBufferMaxIndex;        // 0x68
        private Unity.Collections.NativeArray<RVO.VO> m_jobAgentVoBuffer;        // 0x78
        private Unity.Collections.NativeArray<System.Int32> m_jobObsBufferMaxIndex;        // 0x88
        private Unity.Collections.NativeArray<RVO.VO> m_jobObsVoBuffer;        // 0x98
        private Unity.Collections.NativeList<RVO.RVOObstacleJobData> m_obstacles;        // 0xA8
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_obstacleIDToIndex;        // 0xB8
        private static System.Int32 s_nextObstacleID;        // 0x0
        private System.Boolean m_obstaclesChanged;        // 0xC0
        private System.Collections.Generic.List<RVO.RVOAgent> m_agents;        // 0xC8
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_agentIDToIndex;        // 0xD0
        private static System.Int32 s_nextAgentID;        // 0x4
        private RVO.RVOQuadtree <Quadtree>k__BackingField;        // 0xD8
        private System.Single deltaTime;        // 0xE0
        private System.Single lastStep;        // 0xE4
        private readonly System.Single m_symmetryBreakingBias;        // 0xE8
        private readonly System.Int32 m_simulationFPS;        // 0xEC
        private readonly System.Int32 m_vertexCount;        // 0xF0
        private static System.Single SHRINK_FACTOR;        // 0x0
        private static System.Int32 INIT_AGENT_COUNT;        // 0x0
        private static System.Int32 INIT_OBSTACLE_COUNT;        // 0x0
        private static System.Int32 INIT_AGENT_VO_COUNT;        // 0x0
        private static System.Int32 INIT_OBS_VO_COUNT;        // 0x0
        private System.Int32 m_agentCount;        // 0xF4
        private System.Int32 m_agentVOCount;        // 0xF8
        private System.Int32 m_obsVOCount;        // 0xFC
        private Unity.Jobs.JobHandle m_handle;        // 0x100

        // Methods
        private System.Single get_DesiredDeltaTime() { }
        private System.Void set_DesiredDeltaTime(System.Single value) { }
        private System.Collections.Generic.List<RVO.RVOAgent> get_agents() { }
        private RVO.RVOQuadtree get_Quadtree() { }
        private System.Void set_Quadtree(RVO.RVOQuadtree value) { }
        private System.Void .ctor() { }
        private System.Void OnDestroy() { }
        private RVO.RVOAgent AddAgent() { }
        private System.Void RemoveAgent(RVO.RVOAgent agent) { }
        private System.Int32 AddObstacle(UnityEngine.Vector3[] vertices, System.Single height, RVO.RVOLayer layer) { }
        private System.Void UpdateObstacle(System.Int32 obstacleID, UnityEngine.Vector3[] vertices) { }
        private System.Void RemoveObstacle(System.Int32 obstacleID) { }
        private System.Void BuildQuadtree() { }
        private System.Void Update() { }
        private System.Void _Realloc(System.Int32 agentCount, System.Int32 obstacleCount) { }
        private System.Void _WriteBackResult() { }
        private UnityEngine.Vector2 _To2D(UnityEngine.Vector3 p, System.Single& elevation) { }
        private RVO.VO SegmentObstacle(UnityEngine.Vector2 segmentStart, UnityEngine.Vector2 segmentEnd, UnityEngine.Vector2 offset, System.Single radius, System.Single inverseDt, System.Single inverseDeltaTime) { }
        private System.Boolean BiasDesiredVelocity(System.Int32 obsStart, System.Int32 obsEnd, Unity.Collections.NativeArray<RVO.VO>& obsVos, System.Int32 agentStart, System.Int32 agentEnd, Unity.Collections.NativeArray<RVO.VO>& agentVos, UnityEngine.Vector2& desiredVelocity, UnityEngine.Vector2& targetPointInVelocitySpace, System.Single maxBiasRadians) { }
        private UnityEngine.Vector2 GradientDescent(System.Int32 obsStart, System.Int32 obsEnd, Unity.Collections.NativeArray<RVO.VO>& obsVos, System.Int32 agentStart, System.Int32 agentEnd, Unity.Collections.NativeArray<RVO.VO>& agentVos, RVO.RVOAgentJobData agent, UnityEngine.Vector2 sampleAround1, UnityEngine.Vector2 sampleAround2) { }
        private UnityEngine.Vector2 Trace(System.Int32 obsStart, System.Int32 obsEnd, Unity.Collections.NativeArray<RVO.VO>& obsVos, System.Int32 agentStart, System.Int32 agentEnd, Unity.Collections.NativeArray<RVO.VO>& agentVos, RVO.RVOAgentJobData agent, UnityEngine.Vector2 p, System.Single& score) { }
        private UnityEngine.Vector2 EvaluateGradient(System.Int32 obsStart, System.Int32 obsEnd, Unity.Collections.NativeArray<RVO.VO>& obsVos, System.Int32 agentStart, System.Int32 agentEnd, Unity.Collections.NativeArray<RVO.VO>& agentVos, RVO.RVOAgentJobData agent, UnityEngine.Vector2 p, System.Single& value) { }

    }

    // TypeToken: 0x2000012
    public struct Line
    {
        // Fields
        public UnityEngine.Vector2 point;        // 0x10
        public UnityEngine.Vector2 dir;        // 0x18

    }

    // TypeToken: 0x2000013
    public class RVOQuadtree
    {
        // Fields
        private static System.Int32 LeafSize;        // 0x0
        private System.Single maxRadius;        // 0x10
        private RVO.RVOQuadtree.Node[] m_nodes;        // 0x18
        private System.Int32 filledNodes;        // 0x20
        private UnityEngine.Rect m_bounds;        // 0x24

        // Methods
        private RVO.RVOQuadtree.Node[] get_nodes() { }
        private UnityEngine.Rect get_bounds() { }
        private System.Void Clear() { }
        private System.Void SetBounds(UnityEngine.Rect r) { }
        private System.Int32 GetNodeIndex() { }
        private System.Void Insert(RVO.RVOAgent rvoAgent) { }
        private System.Void CalculateSpeeds() { }
        private System.Void Query(UnityEngine.Vector2 p, System.Single speed, System.Single timeHorizon, System.Single agentRadius, RVO.RVOAgent rvoAgent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public struct VO
    {
        // Fields
        public UnityEngine.Vector2 line1;        // 0x10
        public UnityEngine.Vector2 line2;        // 0x18
        public UnityEngine.Vector2 dir1;        // 0x20
        public UnityEngine.Vector2 dir2;        // 0x28
        public UnityEngine.Vector2 cutoffLine;        // 0x30
        public UnityEngine.Vector2 cutoffDir;        // 0x38
        public UnityEngine.Vector2 circleCenter;        // 0x40
        public System.Boolean colliding;        // 0x48
        public System.Single radius;        // 0x4C
        public System.Single weightFactor;        // 0x50
        public System.Single weightBonus;        // 0x54
        public UnityEngine.Vector2 segmentStart;        // 0x58
        public UnityEngine.Vector2 segmentEnd;        // 0x60
        public System.Boolean segment;        // 0x68

        // Methods
        private System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 offset, System.Single radius, System.Single inverseDt, System.Single inverseDeltaTime) { }
        private System.Single SignedDistanceFromLine(UnityEngine.Vector2 a, UnityEngine.Vector2 dir, UnityEngine.Vector2 p) { }
        private UnityEngine.Vector2 ScaledGradient(UnityEngine.Vector2 p, System.Single& weight) { }
        private UnityEngine.Vector2 Gradient(UnityEngine.Vector2 p, System.Single& weight) { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class IsUnmanagedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

