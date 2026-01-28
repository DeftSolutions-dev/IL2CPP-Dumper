// ========================================================
// Dumped by @desirepro
// Assembly: DestMath.dll
// Classes:  152
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000005
    public struct Edge
    {
        // Fields
        public System.Int32 V0;        // 0x10
        public System.Int32 V1;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 v0, System.Int32 v1) { }

    }

    // TypeToken: 0x2000006
    public struct InnerPoint
    {
        // Fields
        public System.Single AverageDistance;        // 0x10
        public System.Single Distance0;        // 0x14
        public System.Single Distance1;        // 0x18
        public System.Int32 Index;        // 0x1C

    }

    // TypeToken: 0x2000009
    public class SortedVertex
    {
        // Fields
        public System.Single Value;        // 0x10
        public System.Int32 Index;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class Edge
    {
        // Fields
        public System.Int32 V0;        // 0x10
        public System.Int32 V1;        // 0x14
        public Dest.Math.ConvexHull2.Edge E0;        // 0x18
        public Dest.Math.ConvexHull2.Edge E1;        // 0x20
        public System.Int32 Sign;        // 0x28
        public System.Int32 Time;        // 0x2C

        // Methods
        private System.Void .ctor(System.Int32 v0, System.Int32 v1) { }
        private System.Int32 GetSign(System.Int32 i, Dest.Math.Query2 query) { }
        private System.Void Insert(Dest.Math.ConvexHull2.Edge adj0, Dest.Math.ConvexHull2.Edge adj1) { }
        private System.Void DeleteSelf() { }
        private System.Void GetIndices(System.Int32[]& indices) { }

    }

    // TypeToken: 0x200000E
    public class Triangle
    {
        // Fields
        public System.Int32 V0;        // 0x10
        public System.Int32 V1;        // 0x14
        public System.Int32 V2;        // 0x18
        public Dest.Math.ConvexHull3.Triangle Adj0;        // 0x20
        public Dest.Math.ConvexHull3.Triangle Adj1;        // 0x28
        public Dest.Math.ConvexHull3.Triangle Adj2;        // 0x30
        public System.Int32 Sign;        // 0x38
        public System.Int32 Time;        // 0x3C
        public System.Boolean OnStack;        // 0x40

        // Methods
        private System.Void .ctor(System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        private Dest.Math.ConvexHull3.Triangle GetAdj(System.Int32 index) { }
        private System.Void SetAdj(System.Int32 index, Dest.Math.ConvexHull3.Triangle value) { }
        private System.Int32 GetV(System.Int32 index) { }
        private System.Int32 GetSign(System.Int32 i, Dest.Math.Query3 query) { }
        private System.Void AttachTo(Dest.Math.ConvexHull3.Triangle adj0, Dest.Math.ConvexHull3.Triangle adj1, Dest.Math.ConvexHull3.Triangle adj2) { }
        private System.Int32 DetachFrom(System.Int32 adjIndex, Dest.Math.ConvexHull3.Triangle adj) { }

    }

    // TypeToken: 0x200000F
    public class TerminatorData
    {
        // Fields
        public System.Int32 V0;        // 0x10
        public System.Int32 V1;        // 0x14
        public System.Int32 NullIndex;        // 0x18
        public Dest.Math.ConvexHull3.Triangle T;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32 v0, System.Int32 v1, System.Int32 nullIndex, Dest.Math.ConvexHull3.Triangle tri) { }

    }

    // TypeToken: 0x2000055
    public class Information
    {
        // Fields
        public System.Int32 Dimension;        // 0x10
        public UnityEngine.Vector2 Min;        // 0x14
        public UnityEngine.Vector2 Max;        // 0x1C
        public System.Single MaxRange;        // 0x24
        public UnityEngine.Vector2 Origin;        // 0x28
        public UnityEngine.Vector2[] Direction;        // 0x30
        public System.Int32[] Extreme;        // 0x38
        public System.Boolean ExtremeCCW;        // 0x40

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public class Information
    {
        // Fields
        public System.Int32 Dimension;        // 0x10
        public UnityEngine.Vector3 Min;        // 0x14
        public UnityEngine.Vector3 Max;        // 0x20
        public System.Single MaxRange;        // 0x2C
        public UnityEngine.Vector3 Origin;        // 0x30
        public UnityEngine.Vector3[] Direction;        // 0x40
        public System.Int32[] Extreme;        // 0x48
        public System.Boolean ExtremeCCW;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class PolyRootFinder
    {
        // Fields
        private System.Int32 _count;        // 0x10
        private System.Int32 _maxRoot;        // 0x14
        private System.Single[] _roots;        // 0x18
        private System.Single _epsilon;        // 0x20

        // Methods
        private System.Single[] get_Roots() { }
        private System.Void .ctor(System.Single epsilon) { }
        private System.Boolean Bisection(Dest.Math.Polynomial poly, System.Single xMin, System.Single xMax, System.Int32 digits, System.Single& root) { }
        private System.Boolean Find(Dest.Math.Polynomial poly, System.Single xMin, System.Single xMax, System.Int32 digits) { }

    }

    // TypeToken: 0x200008A
    public class ItemData
    {
        // Fields
        public UnityEngine.Vector3 Position;        // 0x10
        public UnityEngine.Vector3 A;        // 0x1C
        public UnityEngine.Vector3 B;        // 0x28
        public UnityEngine.Vector3 C;        // 0x34
        public UnityEngine.Vector3 D;        // 0x40
        public System.Single Length;        // 0x4C
        public System.Single AccumulatedLength;        // 0x50
        private static System.Int32 SegmentCount;        // 0x0
        private static System.Int32 SegmentCountPlus1;        // 0x0
        private static System.Single DeltaTime;        // 0x0
        public UnityEngine.Vector3[] RenderPoints;        // 0x58

        // Methods
        private System.Boolean EnsureRenderPointsValidity() { }
        private System.Void UpdateRenderPoints() { }
        private UnityEngine.Vector3 EvalPosition(System.Single t) { }
        private UnityEngine.Vector3 EvalFirstDerivative(System.Single t) { }
        private UnityEngine.Vector3 EvalSecondDerivative(System.Single t) { }
        private UnityEngine.Vector3 EvalThirdDerivative(System.Single t) { }
        private System.Single EvalSpeed(System.Single t) { }
        private UnityEngine.Vector3 EvalTangent(System.Single t) { }
        private System.Single EvalLength() { }
        private System.Single EvalLength(System.Single t0, System.Single t1) { }
        private System.Single ProcessLength(System.Single currentLength) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008B
    public class ArcLengthParametrization
    {
        // Fields
        public System.Single[] sSample;        // 0x10
        public System.Single[] tSample;        // 0x18
        public System.Single[] tsSlope;        // 0x20
        public System.Single L;        // 0x28

        // Methods
        private System.Single GetApproximateTimeParameter(System.Single s) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008D
    public class Data
    {
        // Fields
        private UnityEngine.Vector3[] _points;        // 0x10
        private System.Collections.Generic.List<System.Int32>[,,] _grid;        // 0x18
        private UnityEngine.Vector3 _min;        // 0x20
        private UnityEngine.Vector3 _max;        // 0x2C
        private System.Int32 _cellsX;        // 0x38
        private System.Int32 _cellsY;        // 0x3C
        private System.Int32 _cellsZ;        // 0x40
        private System.Single _cellSize;        // 0x44
        private System.Single _radius;        // 0x48
        private Dest.Math.Rand _rand;        // 0x50

        // Methods
        private System.Void .ctor(UnityEngine.Vector3[] points, System.Single radius, Dest.Math.Rand rand, Dest.Math.AAB3 aab) { }
        private System.Int32 BinarySearch(System.Collections.Generic.List<System.Int32> array, System.Int32 value) { }
        private System.Int32 BinarySearch(System.Int32[] array, System.Int32 length, System.Int32 value) { }
        private System.Void CalcGridIndices(UnityEngine.Vector3& point, System.Int32& i, System.Int32& j, System.Int32& k) { }
        private System.Collections.Generic.List<System.Int32> Filter() { }

    }

    // TypeToken: 0x200008F
    public class PointDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Single Invoke(UnityEngine.Vector2& point) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Vector2& point, System.AsyncCallback callback, System.Object object) { }
        private System.Single EndInvoke(UnityEngine.Vector2& point, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000098
    public struct __StaticArrayInitTypeSize=20
    {
    }

namespace Dest.Math
{

    // TypeToken: 0x2000002
    public class Polynomial
    {
        // Fields
        private System.Int32 _degree;        // 0x10
        private System.Single[] _coeffs;        // 0x18

        // Methods
        private System.Int32 get_Degree() { }
        private System.Void set_Degree(System.Int32 value) { }
        private System.Single get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Single value) { }
        private System.Void .ctor(System.Int32 degree) { }
        private Dest.Math.Polynomial DeepCopy() { }
        private Dest.Math.Polynomial CalcDerivative() { }
        private Dest.Math.Polynomial CalcInversion() { }
        private System.Void Compress(System.Single epsilon) { }
        private System.Single Eval(System.Single t) { }

    }

    // TypeToken: 0x2000003
    public class Approximation
    {
        // Methods
        private Dest.Math.Box2 GaussPointsFit2(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }
        private System.Boolean HeightLineFit2(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Single& a, System.Single& b) { }
        private Dest.Math.Line2 LeastSquaresLineFit2(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }
        private Dest.Math.Box3 GaussPointsFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }
        private Dest.Math.Line3 LeastsSquaresLineFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }
        private System.Boolean HeightPlaneFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Single& a, System.Single& b, System.Single& c) { }
        private Dest.Math.Plane3 LeastSquaresPlaneFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }

    }

    // TypeToken: 0x2000004
    public class ConcaveHull2
    {
        // Methods
        private System.Boolean _TryFastSort(Dest.Math.ConcaveHull2.InnerPoint[] x, System.Int32 first, System.Int32 last) { }
        private System.Void Quicksort(Dest.Math.ConcaveHull2.InnerPoint[] x, System.Int32 first, System.Int32 last) { }
        private System.Single CalcDistanceFromPointToEdge(UnityEngine.Vector2& pointA, UnityEngine.Vector2& v0, UnityEngine.Vector2& v1) { }
        private System.Boolean Create(UnityEngine.Vector2[] points, System.Int32[]& concaveHull, System.Int32[] convexHull, System.Single N, System.Single epsilon) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class ConcaveHull
    {
        // Methods
        private System.Boolean Create2D(UnityEngine.Vector2[] points, System.Int32[]& concaveHull, System.Int32[]& convexHull, System.Single algorithmThreshold, System.Single epsilon) { }
        private System.Boolean Create2D(UnityEngine.Vector2[] points, System.Int32[]& concaveHull, System.Single algorithmThreshold, System.Single epsilon) { }

    }

    // TypeToken: 0x2000008
    public class ConvexHull1
    {
        // Methods
        private System.Void Create(System.Single[] vertices, System.Single epsilon, System.Int32& dimension, System.Int32[]& indices) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class ConvexHull2
    {
        // Methods
        private System.Boolean Create(System.Collections.Generic.IList<UnityEngine.Vector2> vertices, System.Single epsilon, System.Int32& dimension, System.Int32[]& indices) { }
        private System.Boolean Update(Dest.Math.ConvexHull2.Edge& hull, System.Int32 i, Dest.Math.Query2 query) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class ConvexHull3
    {
        // Methods
        private System.Boolean Create(System.Collections.Generic.IList<UnityEngine.Vector3> vertices, System.Single epsilon, System.Int32& dimension, System.Int32[]& indices) { }
        private System.Boolean Update(System.Collections.Generic.HashSet<Dest.Math.ConvexHull3.Triangle> hull, System.Int32 i, Dest.Math.Query3 query) { }
        private System.Void ExtractIndices(System.Collections.Generic.HashSet<Dest.Math.ConvexHull3.Triangle> hull, System.Int32[]& indices) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class ConvexHull
    {
        // Methods
        private System.Boolean Create2D(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Int32[]& indices, System.Int32& dimension, System.Single epsilon) { }
        private System.Boolean Create3D(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Int32[]& indices, System.Int32& dimension, System.Single epsilon) { }

    }

    // TypeToken: 0x2000011
    public class Distance
    {
        // Methods
        private System.Single Line2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1) { }
        private System.Single Line2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single SqrLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1) { }
        private System.Single SqrLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single Line2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray) { }
        private System.Single Line2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single SqrLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray) { }
        private System.Single SqrLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single Line2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment) { }
        private System.Single Line2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single SqrLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment) { }
        private System.Single SqrLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single Point2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box) { }
        private System.Single Point2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box, UnityEngine.Vector2& closestPoint) { }
        private System.Single SqrPoint2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box) { }
        private System.Single SqrPoint2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box, UnityEngine.Vector2& closestPoint) { }
        private System.Single Point2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box) { }
        private System.Single Point2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box, UnityEngine.Vector2& closestPoint) { }
        private System.Single SqrPoint2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box) { }
        private System.Single SqrPoint2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box, UnityEngine.Vector2& closestPoint) { }
        private System.Single Point2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle) { }
        private System.Single Point2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle, UnityEngine.Vector2& closestPoint) { }
        private System.Single SqrPoint2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle) { }
        private System.Single SqrPoint2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle, UnityEngine.Vector2& closestPoint) { }
        private System.Single Point2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line) { }
        private System.Single Point2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line, UnityEngine.Vector2& closestPoint) { }
        private System.Single SqrPoint2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line) { }
        private System.Single SqrPoint2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line, UnityEngine.Vector2& closestPoint) { }
        private System.Single Point2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray) { }
        private System.Single Point2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint) { }
        private System.Single SqrPoint2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray) { }
        private System.Single SqrPoint2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint) { }
        private System.Single Point2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment) { }
        private System.Single Point2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint) { }
        private System.Single SqrPoint2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment) { }
        private System.Single SqrPoint2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint) { }
        private System.Single Point2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle) { }
        private System.Single Point2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle, UnityEngine.Vector2& closestPoint) { }
        private System.Single SqrPoint2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle) { }
        private System.Single SqrPoint2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle, UnityEngine.Vector2& closestPoint) { }
        private System.Single Ray2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1) { }
        private System.Single Ray2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single SqrRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1) { }
        private System.Single SqrRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single Ray2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment) { }
        private System.Single Ray2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single SqrRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment) { }
        private System.Single SqrRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single Segment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1) { }
        private System.Single Segment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Single SqrSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1) { }
        private System.Single SqrSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1) { }
        private System.Void Face(Dest.Math.Box3& mBox, System.Single& mLineParameter, System.Int32 i0, System.Int32 i1, System.Int32 i2, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, UnityEngine.Vector3& PmE, System.Single& sqrDistance) { }
        private System.Void CaseNoZeros(Dest.Math.Box3& mBox, System.Single& mLineParameter, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, System.Single& sqrDistance) { }
        private System.Void Case0(Dest.Math.Box3& mBox, System.Single& mLineParameter, System.Int32 i0, System.Int32 i1, System.Int32 i2, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, System.Single& sqrDistance) { }
        private System.Void Case00(Dest.Math.Box3& mBox, System.Single& mLineParameter, System.Int32 i0, System.Int32 i1, System.Int32 i2, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, System.Single& sqrDistance) { }
        private System.Void Case000(Dest.Math.Box3& mBox, System.Single& mLineParameter, UnityEngine.Vector3& pnt, System.Single& sqrDistance) { }
        private System.Single Line3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box, Dest.Math.Line3Box3Dist& info) { }
        private System.Single Line3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box) { }
        private System.Single SqrLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box, Dest.Math.Line3Box3Dist& info) { }
        private System.Single SqrLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box) { }
        private System.Single Line3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1) { }
        private System.Single Line3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single SqrLine3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1) { }
        private System.Single SqrLine3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single Line3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray) { }
        private System.Single Line3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single SqrLine3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray) { }
        private System.Single SqrLine3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single Line3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment) { }
        private System.Single Line3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single SqrLine3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment) { }
        private System.Single SqrLine3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single Point3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box) { }
        private System.Single Point3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box, UnityEngine.Vector3& closestPoint) { }
        private System.Single SqrPoint3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box) { }
        private System.Single SqrPoint3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box, UnityEngine.Vector3& closestPoint) { }
        private System.Single Point3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box) { }
        private System.Single Point3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint) { }
        private System.Single SqrPoint3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box) { }
        private System.Single SqrPoint3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint) { }
        private System.Single Point3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, System.Boolean solid) { }
        private System.Single Point3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, UnityEngine.Vector3& closestPoint, System.Boolean solid) { }
        private System.Single SqrPoint3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, System.Boolean solid) { }
        private System.Single SqrPoint3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, UnityEngine.Vector3& closestPoint, System.Boolean solid) { }
        private System.Single Point3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line) { }
        private System.Single Point3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line, UnityEngine.Vector3& closestPoint) { }
        private System.Single SqrPoint3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line) { }
        private System.Single SqrPoint3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line, UnityEngine.Vector3& closestPoint) { }
        private System.Single Point3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane) { }
        private System.Single Point3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane, UnityEngine.Vector3& closestPoint) { }
        private System.Single SqrPoint3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane) { }
        private System.Single SqrPoint3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane, UnityEngine.Vector3& closestPoint) { }
        private System.Single Point3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray) { }
        private System.Single Point3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint) { }
        private System.Single SqrPoint3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray) { }
        private System.Single SqrPoint3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint) { }
        private System.Single Point3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle) { }
        private System.Single Point3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle, UnityEngine.Vector3& closestPoint) { }
        private System.Single SqrPoint3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle) { }
        private System.Single SqrPoint3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle, UnityEngine.Vector3& closestPoint) { }
        private System.Single Point3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment) { }
        private System.Single Point3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint) { }
        private System.Single SqrPoint3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment) { }
        private System.Single SqrPoint3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint) { }
        private System.Single Point3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere) { }
        private System.Single Point3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere, UnityEngine.Vector3& closestPoint) { }
        private System.Single SqrPoint3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere) { }
        private System.Single SqrPoint3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere, UnityEngine.Vector3& closestPoint) { }
        private System.Single Ray3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1) { }
        private System.Single Ray3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single SqrRay3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1) { }
        private System.Single SqrRay3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single Ray3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment) { }
        private System.Single Ray3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single SqrRay3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment) { }
        private System.Single SqrRay3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single Segment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single Segment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box) { }
        private System.Single SqrSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single SqrSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box) { }
        private System.Single Segment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1) { }
        private System.Single Segment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }
        private System.Single SqrSegment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1) { }
        private System.Single SqrSegment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1) { }

    }

    // TypeToken: 0x2000012
    public struct Line3Box3Dist
    {
        // Fields
        public UnityEngine.Vector3 ClosestPoint0;        // 0x10
        public UnityEngine.Vector3 ClosestPoint1;        // 0x1C
        public System.Single LineParameter;        // 0x28

    }

    // TypeToken: 0x2000013
    public class Intersection
    {
        // Fields
        private static System.Single _intervalThreshold;        // 0x0
        private static System.Single _dotThreshold;        // 0x4
        private static System.Single _distanceThreshold;        // 0x8

        // Methods
        private System.Boolean TestAAB2AAB2(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1) { }
        private System.Boolean FindAAB2AAB2(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1, Dest.Math.AAB2& intersection) { }
        private System.Boolean TestAAB2AAB2OverlapX(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1) { }
        private System.Boolean TestAAB2AAB2OverlapY(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1) { }
        private System.Boolean TestAAB2Circle2(Dest.Math.AAB2& box, Dest.Math.Circle2& circle) { }
        private System.Boolean TestBox2Box2(Dest.Math.Box2& box0, Dest.Math.Box2& box1) { }
        private System.Boolean TestBox2Circle2(Dest.Math.Box2& box, Dest.Math.Circle2& circle) { }
        private System.Boolean TestCircle2Circle2(Dest.Math.Circle2& circle0, Dest.Math.Circle2& circle1) { }
        private System.Boolean FindCircle2Circle2(Dest.Math.Circle2& circle0, Dest.Math.Circle2& circle1, Dest.Math.Circle2Circle2Intr& info) { }
        private System.Int32 WhichSide(Dest.Math.Polygon2 V, UnityEngine.Vector2 P, UnityEngine.Vector2& D) { }
        private System.Boolean TestConvexPolygon2ConvexPolygon2(Dest.Math.Polygon2 convexPolygon0, Dest.Math.Polygon2 convexPolygon1) { }
        private System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.AAB2& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector2& point0, UnityEngine.Vector2& point1, Dest.Math.IntersectionTypes& intrType) { }
        private System.Boolean TestLine2AAB2(Dest.Math.Line2& line, Dest.Math.AAB2& box) { }
        private System.Boolean FindLine2AAB2(Dest.Math.Line2& line, Dest.Math.AAB2& box, Dest.Math.Line2AAB2Intr& info) { }
        private System.Boolean Clip(System.Single denom, System.Single numer, System.Single& t0, System.Single& t1) { }
        private System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.Box2& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector2& point0, UnityEngine.Vector2& point1, Dest.Math.IntersectionTypes& intrType) { }
        private System.Boolean TestLine2Box2(Dest.Math.Line2& line, Dest.Math.Box2& box) { }
        private System.Boolean FindLine2Box2(Dest.Math.Line2& line, Dest.Math.Box2& box, Dest.Math.Line2Box2Intr& info) { }
        private System.Boolean Find(UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, UnityEngine.Vector2& center, System.Single radius, System.Int32& rootCount, System.Single& t0, System.Single& t1) { }
        private System.Boolean TestLine2Circle2(Dest.Math.Line2& line, Dest.Math.Circle2& circle) { }
        private System.Boolean FindLine2Circle2(Dest.Math.Line2& line, Dest.Math.Circle2& circle, Dest.Math.Line2Circle2Intr& info) { }
        private System.Boolean TestLine2ConvexPolygon2(Dest.Math.Line2& line, Dest.Math.Polygon2 convexPolygon) { }
        private System.Boolean FindLine2ConvexPolygon2(Dest.Math.Line2& line, Dest.Math.Polygon2 convexPolygon, Dest.Math.Line2ConvexPolygon2Intr& info) { }
        private Dest.Math.IntersectionTypes Classify(Dest.Math.Line2& line0, Dest.Math.Line2& line1, System.Single& s0) { }
        private System.Boolean TestLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1) { }
        private System.Boolean FindLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, Dest.Math.Line2Line2Intr& info) { }
        private Dest.Math.IntersectionTypes Classify(Dest.Math.Line2& line, Dest.Math.Ray2& ray, System.Single& s0, System.Single& s1) { }
        private System.Boolean TestLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray) { }
        private System.Boolean FindLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, Dest.Math.Line2Ray2Intr& info) { }
        private Dest.Math.IntersectionTypes Classify(Dest.Math.Segment2& segment, Dest.Math.Line2& line, System.Single& s0, System.Single& s1) { }
        private System.Boolean TestLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment) { }
        private System.Boolean FindLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, Dest.Math.Line2Segment2Intr& info) { }
        private System.Void TriangleLineRelations(UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.Triangle2& triangle, System.Single& dist0, System.Single& dist1, System.Single& dist2, System.Int32& sign0, System.Int32& sign1, System.Int32& sign2, System.Int32& positive, System.Int32& negative, System.Int32& zero) { }
        private System.Boolean GetInterval(UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.Triangle2& triangle, System.Single dist0, System.Single dist1, System.Single dist2, System.Int32 sign0, System.Int32 sign1, System.Int32 sign2, System.Single& param0, System.Single& param1) { }
        private System.Boolean TestLine2Triangle2(Dest.Math.Line2& line, Dest.Math.Triangle2& triangle, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestLine2Triangle2(Dest.Math.Line2& line, Dest.Math.Triangle2& triangle) { }
        private System.Boolean FindLine2Triangle2(Dest.Math.Line2& line, Dest.Math.Triangle2& triangle, Dest.Math.Line2Triangle2Intr& info) { }
        private System.Boolean TestRay2AAB2(Dest.Math.Ray2& ray, Dest.Math.AAB2& box) { }
        private System.Boolean FindRay2AAB2(Dest.Math.Ray2& ray, Dest.Math.AAB2& box, Dest.Math.Ray2AAB2Intr& info) { }
        private System.Boolean TestRay2Box2(Dest.Math.Ray2& ray, Dest.Math.Box2& box) { }
        private System.Boolean FindRay2Box2(Dest.Math.Ray2& ray, Dest.Math.Box2& box, Dest.Math.Ray2Box2Intr& info) { }
        private System.Boolean TestRay2Circle2(Dest.Math.Ray2& ray, Dest.Math.Circle2& circle) { }
        private System.Boolean FindRay2Circle2(Dest.Math.Ray2& ray, Dest.Math.Circle2& circle, Dest.Math.Ray2Circle2Intr& info) { }
        private System.Boolean TestRay2ConvexPolygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 convexPolygon) { }
        private System.Boolean FindRay2ConvexPolygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 convexPolygon, Dest.Math.Ray2ConvexPolygon2Intr& info) { }
        private System.Boolean TestRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 polygon) { }
        private System.Boolean TestRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Segment2[] segments) { }
        private System.Boolean FindRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 polygon, Dest.Math.Ray2Polygon2Intr& info) { }
        private System.Boolean FindRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Segment2[] segments, Dest.Math.Ray2Polygon2Intr& info) { }
        private Dest.Math.IntersectionTypes Classify(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, System.Single& s0, System.Single& s1) { }
        private System.Boolean TestRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1) { }
        private System.Boolean FindRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, Dest.Math.Ray2Ray2Intr& info) { }
        private Dest.Math.IntersectionTypes Classify(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, System.Single& s0, System.Single& s1) { }
        private System.Boolean TestRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment) { }
        private System.Boolean FindRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, Dest.Math.Ray2Segment2Intr& info) { }
        private System.Boolean TestRay2Triangle2(Dest.Math.Ray2& ray, Dest.Math.Triangle2& triangle, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestRay2Triangle2(Dest.Math.Ray2& ray, Dest.Math.Triangle2& triangle) { }
        private System.Boolean FindRay2Triangle2(Dest.Math.Ray2& ray, Dest.Math.Triangle2& triangle, Dest.Math.Ray2Triangle2Intr& info) { }
        private System.Boolean TestSegment2AAB2(Dest.Math.Segment2& segment, Dest.Math.AAB2& box) { }
        private System.Boolean FindSegment2AAB2(Dest.Math.Segment2& segment, Dest.Math.AAB2& box, Dest.Math.Segment2AAB2Intr& info) { }
        private System.Boolean TestSegment2Box2(Dest.Math.Segment2& segment, Dest.Math.Box2& box) { }
        private System.Boolean FindSegment2Box2(Dest.Math.Segment2& segment, Dest.Math.Box2& box, Dest.Math.Segment2Box2Intr& info) { }
        private System.Boolean TestSegment2Circle2(Dest.Math.Segment2& segment, Dest.Math.Circle2& circle) { }
        private System.Boolean FindSegment2Circle2(Dest.Math.Segment2& segment, Dest.Math.Circle2& circle, Dest.Math.Segment2Circle2Intr& info) { }
        private System.Boolean TestSegment2ConvexPolygon2(Dest.Math.Segment2& segment, Dest.Math.Polygon2 convexPolygon) { }
        private System.Boolean FindSegment2ConvexPolygon2(Dest.Math.Segment2& segment, Dest.Math.Polygon2 convexPolygon, Dest.Math.Segment2ConvexPolygon2Intr& info) { }
        private Dest.Math.IntersectionTypes Classify(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, System.Single& s0, System.Single& s1) { }
        private System.Boolean TestSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1) { }
        private System.Boolean FindSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, Dest.Math.Segment2Segment2Intr& info) { }
        private System.Boolean TestSegment2Triangle2(Dest.Math.Segment2& segment, Dest.Math.Triangle2& triangle, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestSegment2Triangle2(Dest.Math.Segment2& segment, Dest.Math.Triangle2& triangle) { }
        private System.Boolean FindSegment2Triangle2(Dest.Math.Segment2& segment, Dest.Math.Triangle2& triangle, Dest.Math.Segment2Triangle2Intr& info) { }
        private System.Int32 WhichSide(Dest.Math.Triangle2& triangle, UnityEngine.Vector2& P, UnityEngine.Vector2& D) { }
        private System.Void ClipConvexPolygonAgainstLine(UnityEngine.Vector2& edgeStart, UnityEngine.Vector2& edgeEnd, System.Int32& quantity, Dest.Math.Triangle2Triangle2Intr& info) { }
        private System.Boolean TestTriangle2Triangle2(Dest.Math.Triangle2& triangle0, Dest.Math.Triangle2& triangle1) { }
        private System.Boolean FindTriangle2Triangle2(Dest.Math.Triangle2& triangle0, Dest.Math.Triangle2& triangle1, Dest.Math.Triangle2Triangle2Intr& info) { }
        private System.Boolean TestAAB3AAB3(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1) { }
        private System.Boolean FindAAB3AAB3(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1, Dest.Math.AAB3& intersection) { }
        private System.Boolean TestAAB3AAB3OverlapX(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1) { }
        private System.Boolean TestAAB3AAB3OverlapY(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1) { }
        private System.Boolean TestAAB3AAB3OverlapZ(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1) { }
        private System.Boolean TestAAB3Sphere3(Dest.Math.AAB3& box, Dest.Math.Sphere3& sphere) { }
        private System.Boolean TestBox3Box3(Dest.Math.Box3& box0, Dest.Math.Box3& box1) { }
        private System.Boolean TestBox3Capsule3(Dest.Math.Box3& box, Dest.Math.Capsule3& capsule) { }
        private System.Boolean TestBox3Sphere3(Dest.Math.Box3& box, Dest.Math.Sphere3& sphere) { }
        private System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, Dest.Math.AAB3& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, Dest.Math.IntersectionTypes& intrType) { }
        private System.Boolean TestLine3AAB3(Dest.Math.Line3& line, Dest.Math.AAB3& box) { }
        private System.Boolean FindLine3AAB3(Dest.Math.Line3& line, Dest.Math.AAB3& box, Dest.Math.Line3AAB3Intr& info) { }
        private System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, Dest.Math.Box3& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, Dest.Math.IntersectionTypes& intrType) { }
        private System.Boolean TestLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box) { }
        private System.Boolean FindLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box, Dest.Math.Line3Box3Intr& info) { }
        private System.Boolean TestLine3Circle3(Dest.Math.Line3& line, Dest.Math.Circle3& circle) { }
        private System.Boolean FindLine3Circle3(Dest.Math.Line3& line, Dest.Math.Circle3& circle, Dest.Math.Line3Circle3Intr& info) { }
        private System.Boolean TestLine3Plane3(Dest.Math.Line3& line, Dest.Math.Plane3& plane, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestLine3Plane3(Dest.Math.Line3& line, Dest.Math.Plane3& plane) { }
        private System.Boolean FindLine3Plane3(Dest.Math.Line3& line, Dest.Math.Plane3& plane, Dest.Math.Line3Plane3Intr& info) { }
        private System.Boolean TestLine3Polygon3(Dest.Math.Line3& line, Dest.Math.Polygon3 polygon) { }
        private System.Boolean FindLine3Polygon3(Dest.Math.Line3& line, Dest.Math.Polygon3 polygon, Dest.Math.Line3Polygon3Intr& info) { }
        private System.Boolean Point3InsideRectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle) { }
        private System.Boolean TestLine3Rectangle3(Dest.Math.Line3& line, Dest.Math.Rectangle3& rectangle) { }
        private System.Boolean FindLine3Rectangle3(Dest.Math.Line3& line, Dest.Math.Rectangle3& rectangle, Dest.Math.Line3Rectangle3Intr& info) { }
        private System.Boolean TestLine3Sphere3(Dest.Math.Line3& line, Dest.Math.Sphere3& sphere) { }
        private System.Boolean FindLine3Sphere3(Dest.Math.Line3& line, Dest.Math.Sphere3& sphere, Dest.Math.Line3Sphere3Intr& info) { }
        private System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, Dest.Math.Triangle3& triangle, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, Dest.Math.Triangle3& triangle) { }
        private System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2) { }
        private System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private System.Boolean FindLine3Triangle3(Dest.Math.Line3& line, Dest.Math.Triangle3& triangle, Dest.Math.Line3Triangle3Intr& info) { }
        private System.Boolean FindLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.Line3Triangle3Intr& info) { }
        private System.Boolean FindLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Line3Triangle3Intr& info) { }
        private System.Boolean TestPlane3AAB3(Dest.Math.Plane3& plane, Dest.Math.AAB3& box) { }
        private System.Boolean TestPlane3Box3(Dest.Math.Plane3& plane, Dest.Math.Box3& box) { }
        private System.Boolean TestPlane3Plane3(Dest.Math.Plane3& plane0, Dest.Math.Plane3& plane1) { }
        private System.Boolean FindPlane3Plane3(Dest.Math.Plane3& plane0, Dest.Math.Plane3& plane1, Dest.Math.Plane3Plane3Intr& info) { }
        private System.Boolean TestPlane3Sphere3(Dest.Math.Plane3& plane, Dest.Math.Sphere3& sphere) { }
        private System.Boolean FindPlane3Sphere3(Dest.Math.Plane3& plane, Dest.Math.Sphere3& sphere, Dest.Math.Plane3Sphere3Intr& info) { }
        private System.Boolean TestPlane3Triangle3(Dest.Math.Plane3& plane, Dest.Math.Triangle3& triangle) { }
        private System.Boolean FindPlane3Triangle3(Dest.Math.Plane3& plane, Dest.Math.Triangle3& triangle, Dest.Math.Plane3Triangle3Intr& info) { }
        private System.Boolean TestRay3AAB3(Dest.Math.Ray3& ray, Dest.Math.AAB3& box) { }
        private System.Boolean FindRay3AAB3(Dest.Math.Ray3& ray, Dest.Math.AAB3& box, Dest.Math.Ray3AAB3Intr& info) { }
        private System.Boolean TestRay3Box3(Dest.Math.Ray3& ray, Dest.Math.Box3& box) { }
        private System.Boolean FindRay3Box3(Dest.Math.Ray3& ray, Dest.Math.Box3& box, Dest.Math.Ray3Box3Intr& info) { }
        private System.Boolean TestRay3Circle3(Dest.Math.Ray3& ray, Dest.Math.Circle3& circle) { }
        private System.Boolean FindRay3Circle3(Dest.Math.Ray3& ray, Dest.Math.Circle3& circle, Dest.Math.Ray3Circle3Intr& info) { }
        private System.Boolean TestRay3Plane3(Dest.Math.Ray3& ray, Dest.Math.Plane3& plane, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestRay3Plane3(Dest.Math.Ray3& ray, Dest.Math.Plane3& plane) { }
        private System.Boolean FindRay3Plane3(Dest.Math.Ray3& ray, Dest.Math.Plane3& plane, Dest.Math.Ray3Plane3Intr& info) { }
        private System.Boolean TestRay3Polygon3(Dest.Math.Ray3& ray, Dest.Math.Polygon3 polygon) { }
        private System.Boolean FindRay3Polygon3(Dest.Math.Ray3& ray, Dest.Math.Polygon3 polygon, Dest.Math.Ray3Polygon3Intr& info) { }
        private System.Boolean TestRay3Rectangle3(Dest.Math.Ray3& ray, Dest.Math.Rectangle3& rectangle) { }
        private System.Boolean FindRay3Rectangle3(Dest.Math.Ray3& ray, Dest.Math.Rectangle3& rectangle, Dest.Math.Ray3Rectangle3Intr& info) { }
        private System.Boolean TestRay3Sphere3(Dest.Math.Ray3& ray, Dest.Math.Sphere3& sphere) { }
        private System.Boolean FindRay3Sphere3(Dest.Math.Ray3& ray, Dest.Math.Sphere3& sphere, Dest.Math.Ray3Sphere3Intr& info) { }
        private System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, Dest.Math.Triangle3& triangle, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, Dest.Math.Triangle3& triangle) { }
        private System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2) { }
        private System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private System.Boolean FindRay3Triangle3(Dest.Math.Ray3& ray, Dest.Math.Triangle3& triangle, Dest.Math.Ray3Triangle3Intr& info) { }
        private System.Boolean FindRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.Ray3Triangle3Intr& info) { }
        private System.Boolean FindRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Ray3Triangle3Intr& info) { }
        private System.Boolean TestSegment3AAB3(Dest.Math.Segment3& segment, Dest.Math.AAB3& box) { }
        private System.Boolean FindSegment3AAB3(Dest.Math.Segment3& segment, Dest.Math.AAB3& box, Dest.Math.Segment3AAB3Intr& info) { }
        private System.Boolean TestSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box) { }
        private System.Boolean FindSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box, Dest.Math.Segment3Box3Intr& info) { }
        private System.Boolean TestSegment3Circle3(Dest.Math.Segment3& segment, Dest.Math.Circle3& circle) { }
        private System.Boolean FindSegment3Circle3(Dest.Math.Segment3& segment, Dest.Math.Circle3& circle, Dest.Math.Segment3Circle3Intr& info) { }
        private System.Boolean TestSegment3Plane3(Dest.Math.Segment3& segment, Dest.Math.Plane3& plane, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestSegment3Plane3(Dest.Math.Segment3& segment, Dest.Math.Plane3& plane) { }
        private System.Boolean FindSegment3Plane3(Dest.Math.Segment3& segment, Dest.Math.Plane3& plane, Dest.Math.Segment3Plane3Intr& info) { }
        private System.Boolean TestSegment3Polygon3(Dest.Math.Segment3& segment, Dest.Math.Polygon3 polygon) { }
        private System.Boolean FindSegment3Polygon3(Dest.Math.Segment3& segment, Dest.Math.Polygon3 polygon, Dest.Math.Segment3Polygon3Intr& info) { }
        private System.Boolean TestSegment3Rectangle3(Dest.Math.Segment3& segment, Dest.Math.Rectangle3& rectangle) { }
        private System.Boolean FindSegment3Rectangle3(Dest.Math.Segment3& segment, Dest.Math.Rectangle3& rectangle, Dest.Math.Segment3Rectangle3Intr& info) { }
        private System.Boolean TestSegment3Sphere3(Dest.Math.Segment3& segment, Dest.Math.Sphere3& sphere) { }
        private System.Boolean FindSegment3Sphere3(Dest.Math.Segment3& segment, Dest.Math.Sphere3& sphere, Dest.Math.Segment3Sphere3Intr& info) { }
        private System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, Dest.Math.Triangle3& triangle, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, Dest.Math.Triangle3& triangle) { }
        private System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2) { }
        private System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private System.Boolean FindSegment3Triangle3(Dest.Math.Segment3& segment, Dest.Math.Triangle3& triangle, Dest.Math.Segment3Triangle3Intr& info) { }
        private System.Boolean FindSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.Segment3Triangle3Intr& info) { }
        private System.Boolean FindSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Segment3Triangle3Intr& info) { }
        private System.Boolean TestSphere3Sphere3(Dest.Math.Sphere3& sphere0, Dest.Math.Sphere3& sphere1) { }
        private System.Boolean FindSphere3Sphere3(Dest.Math.Sphere3& sphere0, Dest.Math.Sphere3& sphere1, Dest.Math.Sphere3Sphere3Intr& info) { }
        private System.Void ProjectOntoAxis(Dest.Math.Triangle3& triangle, UnityEngine.Vector3& axis, System.Single& fmin, System.Single& fmax) { }
        private System.Void TrianglePlaneRelations(Dest.Math.Triangle3& triangle, Dest.Math.Plane3& plane, System.Single& dist0, System.Single& dist1, System.Single& dist2, System.Int32& sign0, System.Int32& sign1, System.Int32& sign2, System.Int32& positive, System.Int32& negative, System.Int32& zero) { }
        private System.Boolean TrianglePlaneRelationsQuick(Dest.Math.Triangle3& triangle, Dest.Math.Plane3& plane) { }
        private System.Boolean IntersectsSegment(Dest.Math.Plane3& plane, Dest.Math.Triangle3& triangle, UnityEngine.Vector3& end0, UnityEngine.Vector3& end1, System.Boolean grazing, Dest.Math.Triangle3Triangle3Intr& info) { }
        private System.Int32 QueryToLine(UnityEngine.Vector2& test, UnityEngine.Vector2& vec0, UnityEngine.Vector2& vec1) { }
        private System.Int32 QueryToTriangle(UnityEngine.Vector2& test, UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2) { }
        private System.Boolean ContainsPoint(Dest.Math.Triangle3& triangle, Dest.Math.Plane3& plane, UnityEngine.Vector3& point, Dest.Math.Triangle3Triangle3Intr& info) { }
        private System.Boolean GetCoplanarIntersection(Dest.Math.Plane3& plane, Dest.Math.Triangle3& tri0, Dest.Math.Triangle3& tri1, Dest.Math.Triangle3Triangle3Intr& info) { }
        private System.Boolean TestTriangle3Triangle3(Dest.Math.Triangle3& triangle0, Dest.Math.Triangle3& triangle1, Dest.Math.IntersectionTypes& intersectionType) { }
        private System.Boolean TestTriangle3Triangle3(Dest.Math.Triangle3& triangle0, Dest.Math.Triangle3& triangle1) { }
        private System.Boolean FindTriangle3Triangle3(Dest.Math.Triangle3& triangle0, Dest.Math.Triangle3& triangle1, Dest.Math.Triangle3Triangle3Intr& info, System.Boolean reportCoplanarIntersections) { }
        private System.Single get_IntervalThreshold() { }
        private System.Void set_IntervalThreshold(System.Single value) { }
        private System.Single get_DotThreshold() { }
        private System.Void set_DotThreshold(System.Single value) { }
        private System.Single get_DistanceThreshold() { }
        private System.Void set_DistanceThreshold(System.Single value) { }
        private System.Void .cctor() { }
        private System.Int32 FindSegment1Segment1(System.Single seg0Start, System.Single seg0End, System.Single seg1Start, System.Single seg1End, System.Single& w0, System.Single& w1) { }

    }

    // TypeToken: 0x2000014
    public struct Circle2Circle2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x2000015
    public struct Line2AAB2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x2000016
    public struct Line2Box2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x2000017
    public struct Line2Circle2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point0;        // 0x14
        public UnityEngine.Vector2 Point1;        // 0x1C

    }

    // TypeToken: 0x2000018
    public struct Line2ConvexPolygon2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20
        public System.Single Parameter0;        // 0x28
        public System.Single Parameter1;        // 0x2C

    }

    // TypeToken: 0x2000019
    public struct Line2Line2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point;        // 0x14
        public System.Single Parameter;        // 0x1C

    }

    // TypeToken: 0x200001A
    public struct Line2Ray2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point;        // 0x14
        public System.Single Parameter;        // 0x1C

    }

    // TypeToken: 0x200001B
    public struct Line2Segment2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point;        // 0x14
        public System.Single Parameter;        // 0x1C

    }

    // TypeToken: 0x200001C
    public struct Line2Triangle2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x200001D
    public struct Ray2AAB2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x200001E
    public struct Ray2Box2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x200001F
    public struct Ray2Circle2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point0;        // 0x14
        public UnityEngine.Vector2 Point1;        // 0x1C

    }

    // TypeToken: 0x2000020
    public struct Ray2ConvexPolygon2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20
        public System.Single Parameter0;        // 0x28
        public System.Single Parameter1;        // 0x2C

    }

    // TypeToken: 0x2000021
    public struct Ray2Polygon2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point0;        // 0x14
        public UnityEngine.Vector2 Point1;        // 0x1C
        public System.Single Parameter0;        // 0x24
        public System.Single Parameter1;        // 0x28

    }

    // TypeToken: 0x2000022
    public struct Ray2Ray2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point;        // 0x14
        public System.Single Parameter;        // 0x1C

    }

    // TypeToken: 0x2000023
    public struct Ray2Segment2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point0;        // 0x14
        public UnityEngine.Vector2 Point1;        // 0x1C
        public System.Single Parameter0;        // 0x24
        public System.Single Parameter1;        // 0x28

    }

    // TypeToken: 0x2000024
    public struct Ray2Triangle2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x2000025
    public struct Segment2AAB2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x2000026
    public struct Segment2Box2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x2000027
    public struct Segment2Circle2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point0;        // 0x14
        public UnityEngine.Vector2 Point1;        // 0x1C

    }

    // TypeToken: 0x2000028
    public struct Segment2ConvexPolygon2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20
        public System.Single Parameter0;        // 0x28
        public System.Single Parameter1;        // 0x2C

    }

    // TypeToken: 0x2000029
    public struct Segment2Segment2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector2 Point0;        // 0x14
        public UnityEngine.Vector2 Point1;        // 0x1C
        public System.Single Parameter0;        // 0x24
        public System.Single Parameter1;        // 0x28

    }

    // TypeToken: 0x200002A
    public struct Segment2Triangle2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20

    }

    // TypeToken: 0x200002B
    public struct Triangle2Triangle2Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector2 Point0;        // 0x18
        public UnityEngine.Vector2 Point1;        // 0x20
        public UnityEngine.Vector2 Point2;        // 0x28
        public UnityEngine.Vector2 Point3;        // 0x30
        public UnityEngine.Vector2 Point4;        // 0x38
        public UnityEngine.Vector2 Point5;        // 0x40

        // Methods
        private UnityEngine.Vector2 get_Item(System.Int32 i) { }
        private System.Void set_Item(System.Int32 i, UnityEngine.Vector2 value) { }

    }

    // TypeToken: 0x200002C
    public struct Float6
    {
        // Fields
        private System.Single _0;        // 0x10
        private System.Single _1;        // 0x14
        private System.Single _2;        // 0x18
        private System.Single _3;        // 0x1C
        private System.Single _4;        // 0x20
        private System.Single _5;        // 0x24

        // Methods
        private System.Single get_Item(System.Int32 i) { }
        private System.Void set_Item(System.Int32 i, System.Single value) { }

    }

    // TypeToken: 0x200002D
    public struct Line3AAB3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24

    }

    // TypeToken: 0x200002E
    public struct Line3Box3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24

    }

    // TypeToken: 0x200002F
    public struct Line3Circle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14

    }

    // TypeToken: 0x2000030
    public struct Line3Plane3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14
        public System.Single LineParameter;        // 0x20

    }

    // TypeToken: 0x2000031
    public struct Line3Polygon3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14

    }

    // TypeToken: 0x2000032
    public struct Line3Rectangle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14

    }

    // TypeToken: 0x2000033
    public struct Line3Sphere3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24
        public System.Single LineParameter0;        // 0x30
        public System.Single LineParameter1;        // 0x34

    }

    // TypeToken: 0x2000034
    public struct Line3Triangle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14
        public System.Single LineParameter;        // 0x20
        public System.Single TriBary0;        // 0x24
        public System.Single TriBary1;        // 0x28
        public System.Single TriBary2;        // 0x2C

    }

    // TypeToken: 0x2000035
    public struct Plane3Plane3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public Dest.Math.Line3 Line;        // 0x14

    }

    // TypeToken: 0x2000036
    public struct Plane3Sphere3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public Dest.Math.Circle3 Circle;        // 0x14

    }

    // TypeToken: 0x2000037
    public struct Plane3Triangle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24
        public UnityEngine.Vector3 Point2;        // 0x30

    }

    // TypeToken: 0x2000038
    public struct Ray3AAB3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24

    }

    // TypeToken: 0x2000039
    public struct Ray3Box3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24

    }

    // TypeToken: 0x200003A
    public struct Ray3Circle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14

    }

    // TypeToken: 0x200003B
    public struct Ray3Plane3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14
        public System.Single RayParameter;        // 0x20

    }

    // TypeToken: 0x200003C
    public struct Ray3Polygon3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14

    }

    // TypeToken: 0x200003D
    public struct Ray3Rectangle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14

    }

    // TypeToken: 0x200003E
    public struct Ray3Sphere3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24
        public System.Single RayParameter0;        // 0x30
        public System.Single RayParameter1;        // 0x34

    }

    // TypeToken: 0x200003F
    public struct Ray3Triangle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14
        public System.Single RayParameter;        // 0x20
        public System.Single TriBary0;        // 0x24
        public System.Single TriBary1;        // 0x28
        public System.Single TriBary2;        // 0x2C

    }

    // TypeToken: 0x2000040
    public struct Segment3AAB3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24

    }

    // TypeToken: 0x2000041
    public struct Segment3Box3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24

    }

    // TypeToken: 0x2000042
    public struct Segment3Circle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14

    }

    // TypeToken: 0x2000043
    public struct Segment3Plane3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14
        public System.Single SegmentParameter;        // 0x20

    }

    // TypeToken: 0x2000044
    public struct Segment3Polygon3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14

    }

    // TypeToken: 0x2000045
    public struct Segment3Rectangle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14

    }

    // TypeToken: 0x2000046
    public struct Segment3Sphere3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public System.Int32 Quantity;        // 0x14
        public UnityEngine.Vector3 Point0;        // 0x18
        public UnityEngine.Vector3 Point1;        // 0x24
        public System.Single SegmentParameter0;        // 0x30
        public System.Single SegmentParameter1;        // 0x34

    }

    // TypeToken: 0x2000047
    public struct Segment3Triangle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public UnityEngine.Vector3 Point;        // 0x14
        public System.Single SegmentParameter;        // 0x20
        public System.Single TriBary0;        // 0x24
        public System.Single TriBary1;        // 0x28
        public System.Single TriBary2;        // 0x2C

    }

    // TypeToken: 0x2000048
    public struct Sphere3Sphere3IntrTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Dest.Math.Sphere3Sphere3IntrTypes Empty;        // 0x0
        public static Dest.Math.Sphere3Sphere3IntrTypes Point;        // 0x0
        public static Dest.Math.Sphere3Sphere3IntrTypes Circle;        // 0x0
        public static Dest.Math.Sphere3Sphere3IntrTypes Sphere0;        // 0x0
        public static Dest.Math.Sphere3Sphere3IntrTypes Sphere0Point;        // 0x0
        public static Dest.Math.Sphere3Sphere3IntrTypes Sphere1;        // 0x0
        public static Dest.Math.Sphere3Sphere3IntrTypes Sphere1Point;        // 0x0
        public static Dest.Math.Sphere3Sphere3IntrTypes Same;        // 0x0

    }

    // TypeToken: 0x2000049
    public struct Sphere3Sphere3Intr
    {
        // Fields
        public Dest.Math.Sphere3Sphere3IntrTypes IntersectionType;        // 0x10
        public Dest.Math.Circle3 Circle;        // 0x14
        public UnityEngine.Vector3 ContactPoint;        // 0x48

    }

    // TypeToken: 0x200004A
    public struct Triangle3Triangle3Intr
    {
        // Fields
        public Dest.Math.IntersectionTypes IntersectionType;        // 0x10
        public Dest.Math.IntersectionTypes CoplanarIntersectionType;        // 0x14
        public System.Boolean Touching;        // 0x18
        public System.Int32 Quantity;        // 0x1C
        public UnityEngine.Vector3 Point0;        // 0x20
        public UnityEngine.Vector3 Point1;        // 0x2C
        public UnityEngine.Vector3 Point2;        // 0x38
        public UnityEngine.Vector3 Point3;        // 0x44
        public UnityEngine.Vector3 Point4;        // 0x50
        public UnityEngine.Vector3 Point5;        // 0x5C

        // Methods
        private UnityEngine.Vector3 get_Item(System.Int32 i) { }
        private System.Void set_Item(System.Int32 i, UnityEngine.Vector3 value) { }

    }

    // TypeToken: 0x200004B
    public struct IntersectionTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Dest.Math.IntersectionTypes Empty;        // 0x0
        public static Dest.Math.IntersectionTypes Point;        // 0x0
        public static Dest.Math.IntersectionTypes Segment;        // 0x0
        public static Dest.Math.IntersectionTypes Ray;        // 0x0
        public static Dest.Math.IntersectionTypes Line;        // 0x0
        public static Dest.Math.IntersectionTypes Polygon;        // 0x0
        public static Dest.Math.IntersectionTypes Plane;        // 0x0
        public static Dest.Math.IntersectionTypes Polyhedron;        // 0x0
        public static Dest.Math.IntersectionTypes Other;        // 0x0

    }

    // TypeToken: 0x200004C
    public interface ILogger
    {
        // Methods
        private System.Void LogInfo(System.Object value) { }
        private System.Void LogWarning(System.Object value) { }
        private System.Void LogError(System.Object value) { }

    }

    // TypeToken: 0x200004D
    public class Logger
    {
        // Fields
        private static Dest.Math.ILogger _instance;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Void LogInfo(System.Object value) { }
        private System.Void LogWarning(System.Object value) { }
        private System.Void LogError(System.Object value) { }
        private System.Void SetLogger(Dest.Math.ILogger logger) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public class DefaultLogger, ILogger
    {
        // Methods
        private System.Void LogInfo(System.Object value) { }
        private System.Void LogWarning(System.Object value) { }
        private System.Void LogError(System.Object value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public class EmptyLogger, ILogger
    {
        // Methods
        private System.Void LogInfo(System.Object value) { }
        private System.Void LogWarning(System.Object value) { }
        private System.Void LogError(System.Object value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000050
    public class Mathfex
    {
        // Fields
        public static System.Single ZeroTolerance;        // 0x0
        public static System.Single NegativeZeroTolerance;        // 0x0
        public static System.Single ZeroToleranceSqr;        // 0x0
        public static System.Single Pi;        // 0x0
        public static System.Single HalfPi;        // 0x0
        public static System.Single TwoPi;        // 0x0

        // Methods
        private System.Single EvalSquared(System.Single x) { }
        private System.Single EvalInvSquared(System.Single x) { }
        private System.Single EvalCubic(System.Single x) { }
        private System.Single EvalInvCubic(System.Single x) { }
        private System.Single EvalQuadratic(System.Single x, System.Single a, System.Single b, System.Single c) { }
        private System.Single EvalSigmoid(System.Single x) { }
        private System.Single EvalOverlappedStep(System.Single x, System.Single overlap, System.Int32 objectIndex, System.Int32 objectCount) { }
        private System.Single EvalSmoothOverlappedStep(System.Single x, System.Single overlap, System.Int32 objectIndex, System.Int32 objectCount) { }
        private System.Single EvalGaussian(System.Single x, System.Single a, System.Single b, System.Single c) { }
        private System.Single EvalGaussian2D(System.Single x, System.Single y, System.Single x0, System.Single y0, System.Single A, System.Single a, System.Single b, System.Single c) { }
        private System.Single Lerp(System.Single value0, System.Single value1, System.Single factor) { }
        private System.Single LerpUnclamped(System.Single value0, System.Single value1, System.Single factor) { }
        private System.Single SigmoidInterp(System.Single value0, System.Single value1, System.Single factor) { }
        private System.Single SinInterp(System.Single value0, System.Single value1, System.Single factor) { }
        private System.Single CosInterp(System.Single value0, System.Single value1, System.Single factor) { }
        private System.Single WobbleInterp(System.Single value0, System.Single value1, System.Single factor) { }
        private System.Single CurveInterp(System.Single value0, System.Single value1, System.Single factor, UnityEngine.AnimationCurve curve) { }
        private System.Single FuncInterp(System.Single value0, System.Single value1, System.Single factor, System.Func<System.Single,System.Single> func) { }
        private System.Single InvSqrt(System.Single value) { }
        private System.Boolean Near(System.Single value0, System.Single value1, System.Single epsilon) { }
        private System.Boolean NearZero(System.Single value, System.Single epsilon) { }
        private UnityEngine.Vector2 CartesianToPolar(UnityEngine.Vector2 cartesianCoordinates) { }
        private UnityEngine.Vector2 PolarToCartesian(UnityEngine.Vector2 polarCoordinates) { }
        private UnityEngine.Vector3 CartesianToSpherical(UnityEngine.Vector3 cartesianCoordinates) { }
        private UnityEngine.Vector3 SphericalToCartesian(UnityEngine.Vector3 sphericalCoordinates) { }
        private UnityEngine.Vector3 CartesianToCylindrical(UnityEngine.Vector3 cartesianCoordinates) { }
        private UnityEngine.Vector3 CylindricalToCartesian(UnityEngine.Vector3 cylindricalCoordinates) { }

    }

    // TypeToken: 0x2000051
    public class Matrix4x4ex
    {
        // Fields
        public static readonly UnityEngine.Matrix4x4 Identity;        // 0x0

        // Methods
        private System.Void RotationMatrixToQuaternion(UnityEngine.Matrix4x4& matrix, UnityEngine.Quaternion& quaternion) { }
        private System.Void QuaternionToRotationMatrix(UnityEngine.Quaternion quaternion, UnityEngine.Matrix4x4& matrix) { }
        private System.Void QuaternionToRotationMatrix(UnityEngine.Quaternion& quaternion, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateTranslation(UnityEngine.Vector3 position, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateTranslation(UnityEngine.Vector3& position, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateScale(UnityEngine.Vector3 scale, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateScale(UnityEngine.Vector3& scale, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateScale(System.Single scale, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotationEuler(System.Single eulerX, System.Single eulerY, System.Single eulerZ, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotationEuler(UnityEngine.Vector3 eulerAngles, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotationEuler(UnityEngine.Vector3& eulerAngles, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotationX(System.Single angleInDegrees, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotationY(System.Single angleInDegrees, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotationZ(System.Single angleInDegrees, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotationAngleAxis(System.Single angleInDegrees, UnityEngine.Vector3 rotationAxis, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotationAngleUnitAxis(System.Single angleInDegrees, UnityEngine.Vector3 normalizedAxis, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotation(UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateRotation(UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Matrix4x4& result) { }
        private System.Void Transpose(UnityEngine.Matrix4x4& matrix) { }
        private System.Void Transpose(UnityEngine.Matrix4x4& matrix, UnityEngine.Matrix4x4& transpose) { }
        private System.Single CalcDeterminant(UnityEngine.Matrix4x4& matrix) { }
        private System.Void Inverse(UnityEngine.Matrix4x4& matrix, System.Single epsilon) { }
        private System.Void Inverse(UnityEngine.Matrix4x4& matrix, UnityEngine.Matrix4x4& inverse, System.Single epsilon) { }
        private System.Void CopyMatrix(UnityEngine.Matrix4x4& source, UnityEngine.Matrix4x4& destination) { }
        private System.Void Multiply(UnityEngine.Matrix4x4& matrix0, UnityEngine.Matrix4x4& matrix1, UnityEngine.Matrix4x4& result) { }
        private System.Void MultiplyRight(UnityEngine.Matrix4x4& matrix0, UnityEngine.Matrix4x4& matrix1) { }
        private System.Void MultiplyLeft(UnityEngine.Matrix4x4& matrix1, UnityEngine.Matrix4x4& matrix0) { }
        private System.Void Multiply(UnityEngine.Matrix4x4& matrix, System.Single scalar) { }
        private System.Void Multiply(UnityEngine.Matrix4x4& matrix, System.Single scalar, UnityEngine.Matrix4x4& result) { }
        private UnityEngine.Vector4 Multiply(UnityEngine.Matrix4x4& matrix, UnityEngine.Vector4 vector) { }
        private UnityEngine.Vector4 Multiply(UnityEngine.Matrix4x4& matrix, UnityEngine.Vector4& vector) { }
        private System.Void CreateSRT(UnityEngine.Vector3 scaling, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateSRT(UnityEngine.Vector3& scaling, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateSRT(System.Single scaling, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateSRT(System.Single scaling, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateSRT(UnityEngine.Vector3 scaling, UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateSRT(UnityEngine.Vector3& scaling, UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateSRT(System.Single scaling, UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateSRT(System.Single scaling, UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateRT(UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateRT(UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateRT(UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateRT(UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateST(UnityEngine.Vector3 scaling, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateST(UnityEngine.Vector3& scaling, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateRotationFromColumns(UnityEngine.Vector3 column0, UnityEngine.Vector3 column1, UnityEngine.Vector3 column2, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateRotationFromColumns(UnityEngine.Vector3& column0, UnityEngine.Vector3& column1, UnityEngine.Vector3& column2, UnityEngine.Matrix4x4& matrix) { }
        private System.Void CreateShadowDirectional(Dest.Math.Plane3 shadowPlane, UnityEngine.Vector3 dirLightOppositeDirection, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateShadowDirectional(Dest.Math.Plane3& shadowPlane, UnityEngine.Vector3& dirLightOppositeDirection, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateShadowPoint(Dest.Math.Plane3 shadowPlane, UnityEngine.Vector3 pointLightPosition, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateShadowPoint(Dest.Math.Plane3& shadowPlane, UnityEngine.Vector3& pointLightPosition, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateShadow(Dest.Math.Plane3 shadowPlane, UnityEngine.Vector4 lightData, UnityEngine.Matrix4x4& result) { }
        private System.Void CreateShadow(Dest.Math.Plane3& shadowPlane, UnityEngine.Vector4& lightData, UnityEngine.Matrix4x4& result) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000052
    public class Quaternionex
    {
        // Methods
        private UnityEngine.Quaternion DeltaTo(UnityEngine.Quaternion quat, UnityEngine.Quaternion target) { }
        private System.String ToStringEx(UnityEngine.Quaternion quat) { }

    }

    // TypeToken: 0x2000053
    public class Rand
    {
        // Fields
        private static System.Int32 a;        // 0x0
        private static System.Int32 b;        // 0x0
        private static System.Int32 c;        // 0x0
        private static System.UInt32 DefaultY;        // 0x0
        private static System.UInt32 DefaultZ;        // 0x0
        private static System.UInt32 DefaultW;        // 0x0
        private static System.UInt32 PositiveMask;        // 0x0
        private static System.UInt32 BoolModuloMask;        // 0x0
        private static System.UInt32 ByteModuloMask;        // 0x0
        private static System.Double One_div_uintMaxValuePlusOne;        // 0x0
        private static System.Double TwoPi;        // 0x0
        private static Dest.Math.Rand _seedGenerator;        // 0x0
        private System.UInt32 _x;        // 0x10
        private System.UInt32 _y;        // 0x14
        private System.UInt32 _z;        // 0x18
        private System.UInt32 _w;        // 0x1C
        public static Dest.Math.Rand Instance;        // 0x8

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 seed) { }
        private System.Void ResetSeed(System.Int32 seed) { }
        private System.Void GetState(System.UInt32& x, System.UInt32& y, System.UInt32& z, System.UInt32& w) { }
        private System.Void SetState(System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w) { }
        private System.Int32 NextInt() { }
        private System.Int32 NextInt(System.Int32 max) { }
        private System.Int32 NextInt(System.Int32 min, System.Int32 max) { }
        private System.Int32 NextIntInclusive(System.Int32 min, System.Int32 max) { }
        private System.Int32 NextPositiveInt() { }
        private System.UInt32 NextUInt() { }
        private System.Double NextDouble() { }
        private System.Double NextDouble(System.Double min, System.Double max) { }
        private System.Single NextFloat() { }
        private System.Single NextFloat(System.Single min, System.Single max) { }
        private System.Boolean NextBool() { }
        private System.Byte NextByte() { }
        private UnityEngine.Color RandomColorOpaque() { }
        private UnityEngine.Color RandomColorTransparent() { }
        private UnityEngine.Color32 RandomColor32Opaque() { }
        private UnityEngine.Color32 RandomColor32Transparent() { }
        private System.Single RandomAngleRadians() { }
        private System.Single RandomAngleDegrees() { }
        private UnityEngine.Vector2 InSquare(System.Single side) { }
        private UnityEngine.Vector2 OnSquare(System.Single side) { }
        private UnityEngine.Vector3 InCube(System.Single side) { }
        private UnityEngine.Vector3 OnCube(System.Single side) { }
        private UnityEngine.Vector2 InCircle(System.Single radius) { }
        private UnityEngine.Vector2 InCircle(System.Single radiusMin, System.Single radiusMax) { }
        private UnityEngine.Vector2 OnCircle(System.Single radius) { }
        private UnityEngine.Vector3 InSphere(System.Single radius) { }
        private UnityEngine.Vector3 OnSphere(System.Single radius) { }
        private UnityEngine.Vector3 InTriangle(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2) { }
        private UnityEngine.Vector3 InTriangle(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private UnityEngine.Quaternion RandomRotation() { }

    }

    // TypeToken: 0x2000054
    public class Vector2ex
    {
        // Fields
        public static readonly UnityEngine.Vector2 Zero;        // 0x0
        public static readonly UnityEngine.Vector2 One;        // 0x8
        public static readonly UnityEngine.Vector2 UnitX;        // 0x10
        public static readonly UnityEngine.Vector2 UnitY;        // 0x18
        public static readonly UnityEngine.Vector2 PositiveInfinity;        // 0x20
        public static readonly UnityEngine.Vector2 NegativeInfinity;        // 0x28

        // Methods
        private Dest.Math.Vector2ex.Information GetInformation(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Single epsilon) { }
        private System.Single Length(UnityEngine.Vector2 vector) { }
        private System.Single LengthSqr(UnityEngine.Vector2 vector) { }
        private System.Single DotPerp(UnityEngine.Vector2 vector, UnityEngine.Vector2 value) { }
        private System.Single DotPerp(UnityEngine.Vector2 vector, UnityEngine.Vector2& value) { }
        private System.Single DotPerp(UnityEngine.Vector2& vector, UnityEngine.Vector2& value) { }
        private System.Single Dot(UnityEngine.Vector2 vector, UnityEngine.Vector2 value) { }
        private System.Single Dot(UnityEngine.Vector2 vector, UnityEngine.Vector2& value) { }
        private System.Single Dot(UnityEngine.Vector2& vector, UnityEngine.Vector2& value) { }
        private UnityEngine.Vector2 Perp(UnityEngine.Vector2 vector) { }
        private System.Single AngleDeg(UnityEngine.Vector2 vector, UnityEngine.Vector2 target) { }
        private System.Single AngleRad(UnityEngine.Vector2 vector, UnityEngine.Vector2 target) { }
        private System.Single Normalize(UnityEngine.Vector2& vector, System.Single epsilon) { }
        private System.Single SetLength(UnityEngine.Vector2& vector, System.Single lengthValue, System.Single epsilon) { }
        private System.Single GrowLength(UnityEngine.Vector2& vector, System.Single lengthDelta, System.Single epsilon) { }
        private UnityEngine.Vector2 Replicate(System.Single value) { }
        private UnityEngine.Vector3 ToVector3XY(UnityEngine.Vector2 vector) { }
        private UnityEngine.Vector3 ToVector3XZ(UnityEngine.Vector2 vector) { }
        private UnityEngine.Vector3 ToVector3YZ(UnityEngine.Vector2 vector) { }
        private System.String ToStringEx(UnityEngine.Vector2 vector) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000056
    public struct ProjectionPlanes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Dest.Math.ProjectionPlanes XY;        // 0x0
        public static Dest.Math.ProjectionPlanes XZ;        // 0x0
        public static Dest.Math.ProjectionPlanes YZ;        // 0x0

    }

    // TypeToken: 0x2000057
    public class Vector3ex
    {
        // Fields
        public static readonly UnityEngine.Vector3 Zero;        // 0x0
        public static readonly UnityEngine.Vector3 One;        // 0xC
        public static readonly UnityEngine.Vector3 UnitX;        // 0x18
        public static readonly UnityEngine.Vector3 UnitY;        // 0x24
        public static readonly UnityEngine.Vector3 UnitZ;        // 0x30
        public static readonly UnityEngine.Vector3 PositiveInfinity;        // 0x3C
        public static readonly UnityEngine.Vector3 NegativeInfinity;        // 0x48

        // Methods
        private Dest.Math.Vector3ex.Information GetInformation(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Single epsilon) { }
        private System.Single Length(UnityEngine.Vector3 vector) { }
        private System.Single LengthSqr(UnityEngine.Vector3 vector) { }
        private System.Single Dot(UnityEngine.Vector3 vector, UnityEngine.Vector3 value) { }
        private System.Single Dot(UnityEngine.Vector3 vector, UnityEngine.Vector3& value) { }
        private System.Single Dot(UnityEngine.Vector3& vector, UnityEngine.Vector3& value) { }
        private System.Single AngleDeg(UnityEngine.Vector3 vector, UnityEngine.Vector3 target) { }
        private System.Single AngleRad(UnityEngine.Vector3 vector, UnityEngine.Vector3 target) { }
        private System.Single SignedAngleDeg(UnityEngine.Vector3 vector, UnityEngine.Vector3 target, UnityEngine.Vector3 normal) { }
        private System.Single SignedAngleRad(UnityEngine.Vector3 vector, UnityEngine.Vector3 target, UnityEngine.Vector3 normal) { }
        private UnityEngine.Vector3 Cross(UnityEngine.Vector3 vector, UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 Cross(UnityEngine.Vector3 vector, UnityEngine.Vector3& value) { }
        private UnityEngine.Vector3 Cross(UnityEngine.Vector3& vector, UnityEngine.Vector3& value) { }
        private UnityEngine.Vector3 UnitCross(UnityEngine.Vector3 vector, UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 UnitCross(UnityEngine.Vector3 vector, UnityEngine.Vector3& value) { }
        private UnityEngine.Vector3 UnitCross(UnityEngine.Vector3& vector, UnityEngine.Vector3& value) { }
        private System.Single Normalize(UnityEngine.Vector3& vector, System.Single epsilon) { }
        private System.Single SetLength(UnityEngine.Vector3& vector, System.Single lengthValue, System.Single epsilon) { }
        private System.Single GrowLength(UnityEngine.Vector3& vector, System.Single lengthDelta, System.Single epsilon) { }
        private UnityEngine.Vector3 Replicate(System.Single value) { }
        private System.Void CreateOrthonormalBasis(UnityEngine.Vector3& u, UnityEngine.Vector3& v, UnityEngine.Vector3& w) { }
        private System.Boolean SameDirection(UnityEngine.Vector3 value0, UnityEngine.Vector3 value1) { }
        private UnityEngine.Vector2 ToVector2XY(UnityEngine.Vector3 vector) { }
        private UnityEngine.Vector2 ToVector2XZ(UnityEngine.Vector3 vector) { }
        private UnityEngine.Vector2 ToVector2YZ(UnityEngine.Vector3 vector) { }
        private UnityEngine.Vector2 ToVector2(UnityEngine.Vector3 vector, Dest.Math.ProjectionPlanes projectionPlane) { }
        private Dest.Math.ProjectionPlanes GetProjectionPlane(UnityEngine.Vector3 vector) { }
        private System.String ToStringEx(UnityEngine.Vector3 vector) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000059
    public struct BrentsRoot
    {
        // Fields
        public System.Single X;        // 0x10
        public System.Int32 Iterations;        // 0x14
        public System.Boolean ExceededMaxIterations;        // 0x18

    }

    // TypeToken: 0x200005A
    public class RootFinder
    {
        // Fields
        private static System.Single third;        // 0x0
        private static System.Single twentySeventh;        // 0x0
        private static System.Single sqrt3;        // 0x0

        // Methods
        private System.Boolean BrentsMethod(System.Func<System.Single,System.Single> function, System.Single x0, System.Single x1, Dest.Math.BrentsRoot& root, System.Int32 maxIterations, System.Single negativeTolerance, System.Single positiveTolerance, System.Single stepTolerance, System.Single segmentTolerance) { }
        private System.Boolean Linear(System.Single c0, System.Single c1, System.Single& root, System.Single epsilon) { }
        private System.Boolean Quadratic(System.Single c0, System.Single c1, System.Single c2, Dest.Math.QuadraticRoots& roots, System.Single epsilon) { }
        private System.Boolean Cubic(System.Single c0, System.Single c1, System.Single c2, System.Single c3, Dest.Math.CubicRoots& roots, System.Single epsilon) { }
        private System.Boolean Quartic(System.Single c0, System.Single c1, System.Single c2, System.Single c3, System.Single c4, Dest.Math.QuarticRoots& roots, System.Single epsilon) { }
        private System.Single PolynomialBound(Dest.Math.Polynomial poly, System.Single epsilon) { }
        private System.Boolean Polynomial(Dest.Math.Polynomial poly, System.Single xMin, System.Single xMax, System.Single[]& roots, System.Int32 digits, System.Single epsilon) { }
        private System.Boolean Polynomial(Dest.Math.Polynomial poly, System.Single[]& roots, System.Int32 digits, System.Single epsilon) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005C
    public class EigenData
    {
        // Fields
        private System.Int32 _size;        // 0x10
        private System.Single[] _diagonal;        // 0x18
        private System.Single[,] _matrix;        // 0x20

        // Methods
        private System.Int32 get_Size() { }
        private System.Void .ctor(System.Single[] diagonal, System.Single[,] matrix) { }
        private System.Single GetEigenvalue(System.Int32 index) { }
        private UnityEngine.Vector2 GetEigenvector2(System.Int32 index) { }
        private UnityEngine.Vector3 GetEigenvector3(System.Int32 index) { }
        private System.Single[] GetEigenvector(System.Int32 index) { }
        private System.Void GetEigenvector(System.Int32 index, System.Single[] out_eigenvector) { }

    }

    // TypeToken: 0x200005D
    public class EigenDecomposition
    {
        // Methods
        private System.Void Tridiagonal2(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation) { }
        private System.Void Tridiagonal3(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation) { }
        private System.Void TridiagonalN(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation) { }
        private System.Boolean QLAlgorithm(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix) { }
        private System.Void IncreasingSort(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation) { }
        private System.Void DecreasingSort(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation) { }
        private System.Void GuaranteeRotation(System.Single[,] matrix, System.Boolean isRotation) { }
        private Dest.Math.EigenData Solve(System.Single[,] symmetricSquareMatrix, System.Boolean increasingSort) { }

    }

    // TypeToken: 0x200005E
    public class Integrator
    {
        // Fields
        private static System.Int32 _degree;        // 0x0
        private static System.Single[] root;        // 0x0
        private static System.Single[] coeff;        // 0x8

        // Methods
        private System.Single TrapezoidRule(System.Func<System.Single,System.Single> function, System.Single a, System.Single b, System.Int32 sampleCount) { }
        private System.Single RombergIntegral(System.Func<System.Single,System.Single> function, System.Single a, System.Single b, System.Int32 order) { }
        private System.Single GaussianQuadrature(System.Func<System.Single,System.Single> function, System.Single a, System.Single b) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005F
    public class LinearSystem
    {
        // Methods
        private System.Boolean Solve2(System.Single[,] A, System.Single[] B, System.Single[]& X, System.Single zeroTolerance) { }
        private System.Boolean Solve2(System.Single[,] A, System.Single[] B, UnityEngine.Vector2& X, System.Single zeroTolerance) { }
        private System.Boolean Solve3(System.Single[,] A, System.Single[] B, System.Single[]& X, System.Single zeroTolerance) { }
        private System.Boolean Solve3(System.Single[,] A, System.Single[] B, UnityEngine.Vector3& X, System.Single zeroTolerance) { }
        private System.Void SwapRows(System.Single[,] matrix, System.Int32 row0, System.Int32 row1, System.Int32 columnCount) { }
        private System.Boolean Solve(System.Single[,] A, System.Single[] B, System.Single[]& X) { }
        private System.Boolean SolveTridiagonal(System.Single[] A, System.Single[] B, System.Single[] C, System.Single[] R, System.Single[]& U) { }
        private System.Boolean Inverse(System.Single[,] A, System.Single[,]& invA) { }

    }

    // TypeToken: 0x2000060
    public class OdeFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Single t, System.Single[] y, System.Single[] F) { }
        private System.IAsyncResult BeginInvoke(System.Single t, System.Single[] y, System.Single[] F, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000061
    public class OdeSolver
    {
        // Fields
        protected System.Int32 _dim;        // 0x10
        protected System.Single _step;        // 0x14
        protected Dest.Math.OdeFunction _function;        // 0x18
        protected System.Single[] _FValue;        // 0x20

        // Methods
        private System.Single get_Step() { }
        private System.Void set_Step(System.Single value) { }
        private System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function) { }
        private System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut) { }

    }

    // TypeToken: 0x2000062
    public class OdeEuler : OdeSolver
    {
        // Methods
        private System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function) { }
        private System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut) { }

    }

    // TypeToken: 0x2000063
    public class OdeMidpoint : OdeSolver
    {
        // Fields
        private System.Single _halfStep;        // 0x28
        private System.Single[] _yTemp;        // 0x30

        // Methods
        private System.Single get_Step() { }
        private System.Void set_Step(System.Single value) { }
        private System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function) { }
        private System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut) { }

    }

    // TypeToken: 0x2000064
    public class OdeRungeKutta4 : OdeSolver
    {
        // Fields
        private System.Single _halfStep;        // 0x28
        private System.Single _sixthStep;        // 0x2C
        private System.Single[] _temp1;        // 0x30
        private System.Single[] _temp2;        // 0x38
        private System.Single[] _temp3;        // 0x40
        private System.Single[] _temp4;        // 0x48
        private System.Single[] _yTemp;        // 0x50

        // Methods
        private System.Single get_Step() { }
        private System.Void set_Step(System.Single value) { }
        private System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function) { }
        private System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut) { }

    }

    // TypeToken: 0x2000065
    public struct QuadraticRoots
    {
        // Fields
        public System.Single X0;        // 0x10
        public System.Single X1;        // 0x14
        public System.Int32 RootCount;        // 0x18

        // Methods
        private System.Single get_Item(System.Int32 rootIndex) { }

    }

    // TypeToken: 0x2000066
    public struct CubicRoots
    {
        // Fields
        public System.Single X0;        // 0x10
        public System.Single X1;        // 0x14
        public System.Single X2;        // 0x18
        public System.Int32 RootCount;        // 0x1C

        // Methods
        private System.Single get_Item(System.Int32 rootIndex) { }

    }

    // TypeToken: 0x2000067
    public struct QuarticRoots
    {
        // Fields
        public System.Single X0;        // 0x10
        public System.Single X1;        // 0x14
        public System.Single X2;        // 0x18
        public System.Single X3;        // 0x1C
        public System.Int32 RootCount;        // 0x20

        // Methods
        private System.Single get_Item(System.Int32 rootIndex) { }

    }

    // TypeToken: 0x2000068
    public struct AAB2
    {
        // Fields
        public UnityEngine.Vector2 Min;        // 0x10
        public UnityEngine.Vector2 Max;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Vector2& min, UnityEngine.Vector2& max) { }
        private System.Void .ctor(UnityEngine.Vector2 min, UnityEngine.Vector2 max) { }
        private System.Void .ctor(System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax) { }
        private UnityEngine.Rect op_Implicit(Dest.Math.AAB2 value) { }
        private Dest.Math.AAB2 op_Implicit(UnityEngine.Rect value) { }
        private Dest.Math.AAB2 CreateFromPoint(UnityEngine.Vector2& point) { }
        private Dest.Math.AAB2 CreateFromPoint(UnityEngine.Vector2 point) { }
        private Dest.Math.AAB2 CreateFromTwoPoints(UnityEngine.Vector2& point0, UnityEngine.Vector2& point1) { }
        private Dest.Math.AAB2 CreateFromTwoPoints(UnityEngine.Vector2 point0, UnityEngine.Vector2 point1) { }
        private Dest.Math.AAB2 CreateFromPoints(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points) { }
        private Dest.Math.AAB2 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }
        private Dest.Math.AAB2 CreateFromPoints(UnityEngine.Vector2[] points) { }
        private System.Void CalcCenterExtents(UnityEngine.Vector2& center, UnityEngine.Vector2& extents) { }
        private System.Void CalcVertices(UnityEngine.Vector2& vertex0, UnityEngine.Vector2& vertex1, UnityEngine.Vector2& vertex2, UnityEngine.Vector2& vertex3) { }
        private UnityEngine.Vector2[] CalcVertices() { }
        private System.Void CalcVertices(UnityEngine.Vector2[] array) { }
        private System.Single CalcArea() { }
        private System.Single DistanceTo(UnityEngine.Vector2 point) { }
        private UnityEngine.Vector2 Project(UnityEngine.Vector2 point) { }
        private System.Boolean Contains(UnityEngine.Vector2& point) { }
        private System.Boolean Contains(UnityEngine.Vector2 point) { }
        private System.Void Include(UnityEngine.Vector2& point) { }
        private System.Void Include(UnityEngine.Vector2 point) { }
        private System.Void Include(Dest.Math.AAB2& box) { }
        private System.Void Include(Dest.Math.AAB2 box) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000069
    public struct Box2
    {
        // Fields
        public UnityEngine.Vector2 Center;        // 0x10
        public UnityEngine.Vector2 Axis0;        // 0x18
        public UnityEngine.Vector2 Axis1;        // 0x20
        public UnityEngine.Vector2 Extents;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& axis0, UnityEngine.Vector2& axis1, UnityEngine.Vector2& extents) { }
        private System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 axis0, UnityEngine.Vector2 axis1, UnityEngine.Vector2 extents) { }
        private System.Void .ctor(Dest.Math.AAB2& box) { }
        private System.Void .ctor(Dest.Math.AAB2 box) { }
        private Dest.Math.Box2 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }
        private UnityEngine.Vector2 GetAxis(System.Int32 index) { }
        private System.Void CalcVertices(UnityEngine.Vector2& vertex0, UnityEngine.Vector2& vertex1, UnityEngine.Vector2& vertex2, UnityEngine.Vector2& vertex3) { }
        private UnityEngine.Vector2[] CalcVertices() { }
        private System.Void CalcVertices(UnityEngine.Vector2[] array) { }
        private System.Single CalcArea() { }
        private System.Single DistanceTo(UnityEngine.Vector2 point) { }
        private UnityEngine.Vector2 Project(UnityEngine.Vector2 point) { }
        private System.Boolean Contains(UnityEngine.Vector2& point) { }
        private System.Boolean Contains(UnityEngine.Vector2 point) { }
        private System.Void Include(Dest.Math.Box2& box) { }
        private System.Void Include(Dest.Math.Box2 box) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200006A
    public struct Circle2
    {
        // Fields
        public UnityEngine.Vector2 Center;        // 0x10
        public System.Single Radius;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Vector2& center, System.Single radius) { }
        private System.Void .ctor(UnityEngine.Vector2 center, System.Single radius) { }
        private Dest.Math.Circle2 CreateFromPointsAAB(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points) { }
        private Dest.Math.Circle2 CreateFromPointsAAB(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }
        private Dest.Math.Circle2 CreateFromPointsAverage(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points) { }
        private Dest.Math.Circle2 CreateFromPointsAverage(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }
        private System.Boolean CreateCircumscribed(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2, Dest.Math.Circle2& circle) { }
        private System.Boolean CreateInscribed(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2, Dest.Math.Circle2& circle) { }
        private System.Single CalcPerimeter() { }
        private System.Single CalcArea() { }
        private UnityEngine.Vector2 Eval(System.Single t) { }
        private UnityEngine.Vector2 Eval(System.Single t, System.Single radius) { }
        private System.Single DistanceTo(UnityEngine.Vector2 point) { }
        private UnityEngine.Vector2 Project(UnityEngine.Vector2 point) { }
        private System.Boolean Contains(UnityEngine.Vector2& point) { }
        private System.Boolean Contains(UnityEngine.Vector2 point) { }
        private System.Void Include(Dest.Math.Circle2& circle) { }
        private System.Void Include(Dest.Math.Circle2 circle) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200006B
    public struct Line2
    {
        // Fields
        public UnityEngine.Vector2 Center;        // 0x10
        public UnityEngine.Vector2 Direction;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& direction) { }
        private System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 direction) { }
        private Dest.Math.Line2 CreateFromTwoPoints(UnityEngine.Vector2& p0, UnityEngine.Vector2& p1) { }
        private Dest.Math.Line2 CreateFromTwoPoints(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1) { }
        private Dest.Math.Line2 CreatePerpToLineTrhoughPoint(Dest.Math.Line2 line, UnityEngine.Vector2 point) { }
        private Dest.Math.Line2 CreateBetweenAndEquidistantToPoints(UnityEngine.Vector2 point0, UnityEngine.Vector2 point1) { }
        private Dest.Math.Line2 CreateParallelToGivenLineAtGivenDistance(Dest.Math.Line2 line, System.Single distance) { }
        private UnityEngine.Vector2 Eval(System.Single t) { }
        private System.Single SignedDistanceTo(UnityEngine.Vector2 point) { }
        private System.Single DistanceTo(UnityEngine.Vector2 point) { }
        private System.Int32 QuerySide(UnityEngine.Vector2 point, System.Single epsilon) { }
        private System.Boolean QuerySideNegative(UnityEngine.Vector2 point, System.Single epsilon) { }
        private System.Boolean QuerySidePositive(UnityEngine.Vector2 point, System.Single epsilon) { }
        private System.Int32 QuerySide(Dest.Math.Box2& box, System.Single epsilon) { }
        private System.Boolean QuerySideNegative(Dest.Math.Box2& box, System.Single epsilon) { }
        private System.Boolean QuerySidePositive(Dest.Math.Box2& box, System.Single epsilon) { }
        private System.Int32 QuerySide(Dest.Math.AAB2& box, System.Single epsilon) { }
        private System.Boolean QuerySideNegative(Dest.Math.AAB2& box, System.Single epsilon) { }
        private System.Boolean QuerySidePositive(Dest.Math.AAB2& box, System.Single epsilon) { }
        private System.Int32 QuerySide(Dest.Math.Circle2& circle, System.Single epsilon) { }
        private System.Boolean QuerySideNegative(Dest.Math.Circle2& circle, System.Single epsilon) { }
        private System.Boolean QuerySidePositive(Dest.Math.Circle2& circle, System.Single epsilon) { }
        private UnityEngine.Vector2 Project(UnityEngine.Vector2 point) { }
        private System.Single AngleBetweenTwoLines(Dest.Math.Line2 anotherLine, System.Boolean acuteAngleDesired) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200006C
    public struct Edge2
    {
        // Fields
        public UnityEngine.Vector2 Point0;        // 0x10
        public UnityEngine.Vector2 Point1;        // 0x18
        public UnityEngine.Vector2 Direction;        // 0x20
        public UnityEngine.Vector2 Normal;        // 0x28
        public System.Single Length;        // 0x30

    }

    // TypeToken: 0x200006D
    public class Polygon2
    {
        // Fields
        private UnityEngine.Vector2[] _vertices;        // 0x10
        private Dest.Math.Edge2[] _edges;        // 0x18

        // Methods
        private UnityEngine.Vector2[] get_Vertices() { }
        private Dest.Math.Edge2[] get_Edges() { }
        private System.Int32 get_VertexCount() { }
        private UnityEngine.Vector2 get_Item(System.Int32 vertexIndex) { }
        private System.Void set_Item(System.Int32 vertexIndex, UnityEngine.Vector2 value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Vector2[] vertices) { }
        private System.Void .ctor(System.Int32 vertexCount) { }
        private Dest.Math.Polygon2 CreateProjected(Dest.Math.Polygon3 polygon, Dest.Math.ProjectionPlanes projectionPlane) { }
        private Dest.Math.Edge2 GetEdge(System.Int32 edgeIndex) { }
        private System.Void UpdateEdges() { }
        private System.Void UpdateEdge(System.Int32 edgeIndex) { }
        private UnityEngine.Vector2 CalcCenter() { }
        private System.Single CalcPerimeter() { }
        private System.Single CalcArea() { }
        private System.Boolean IsConvex(Dest.Math.Orientations& orientation, System.Single threshold) { }
        private System.Boolean IsConvex(System.Single threshold) { }
        private System.Boolean HasZeroCorners(System.Single threshold) { }
        private System.Void ReverseVertices() { }
        private System.Boolean ContainsConvexQuadCCW(UnityEngine.Vector2& point) { }
        private System.Boolean ContainsConvexQuadCCW(UnityEngine.Vector2 point) { }
        private System.Boolean ContainsConvexQuadCW(UnityEngine.Vector2& point) { }
        private System.Boolean ContainsConvexQuadCW(UnityEngine.Vector2 point) { }
        private System.Boolean ContainsConvexCCW(UnityEngine.Vector2& point) { }
        private System.Boolean ContainsConvexCCW(UnityEngine.Vector2 point) { }
        private System.Boolean SubContainsPointCCW(UnityEngine.Vector2& p, System.Int32 i0, System.Int32 i1) { }
        private System.Boolean ContainsConvexCW(UnityEngine.Vector2& point) { }
        private System.Boolean ContainsConvexCW(UnityEngine.Vector2 point) { }
        private System.Boolean SubContainsPointCW(UnityEngine.Vector2& p, System.Int32 i0, System.Int32 i1) { }
        private System.Boolean ContainsSimple(UnityEngine.Vector2& point) { }
        private System.Boolean ContainsSimple(UnityEngine.Vector2 point) { }
        private Dest.Math.Segment2[] ToSegmentArray() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200006E
    public struct Ray2
    {
        // Fields
        public UnityEngine.Vector2 Center;        // 0x10
        public UnityEngine.Vector2 Direction;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& direction) { }
        private System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 direction) { }
        private UnityEngine.Vector2 Eval(System.Single t) { }
        private System.Single DistanceTo(UnityEngine.Vector2 point) { }
        private UnityEngine.Vector2 Project(UnityEngine.Vector2 point) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200006F
    public struct Segment2
    {
        // Fields
        public UnityEngine.Vector2 P0;        // 0x10
        public UnityEngine.Vector2 P1;        // 0x18
        public UnityEngine.Vector2 Center;        // 0x20
        public UnityEngine.Vector2 Direction;        // 0x28
        public System.Single Extent;        // 0x30

        // Methods
        private System.Void .ctor(UnityEngine.Vector2& p0, UnityEngine.Vector2& p1) { }
        private System.Void .ctor(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1) { }
        private System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& direction, System.Single extent) { }
        private System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 direction, System.Single extent) { }
        private System.Void SetEndpoints(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1) { }
        private System.Void SetCenterDirectionExtent(UnityEngine.Vector2 center, UnityEngine.Vector2 direction, System.Single extent) { }
        private System.Void CalcCenterDirectionExtent() { }
        private System.Void CalcEndPoints() { }
        private UnityEngine.Vector2 Eval(System.Single s) { }
        private System.Single DistanceTo(UnityEngine.Vector2 point) { }
        private UnityEngine.Vector2 Project(UnityEngine.Vector2 point) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000070
    public struct Triangle2
    {
        // Fields
        public UnityEngine.Vector2 V0;        // 0x10
        public UnityEngine.Vector2 V1;        // 0x18
        public UnityEngine.Vector2 V2;        // 0x20

        // Methods
        private UnityEngine.Vector2 get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, UnityEngine.Vector2 value) { }
        private System.Void .ctor(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2) { }
        private System.Void .ctor(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2) { }
        private UnityEngine.Vector2 CalcEdge(System.Int32 edgeIndex) { }
        private System.Single CalcDeterminant() { }
        private Dest.Math.Orientations CalcOrientation(System.Single threshold) { }
        private System.Single CalcArea() { }
        private System.Single CalcArea(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2) { }
        private System.Single CalcArea(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2) { }
        private UnityEngine.Vector3 CalcAnglesDeg() { }
        private UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2) { }
        private UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2) { }
        private UnityEngine.Vector3 CalcAnglesRad() { }
        private UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2) { }
        private UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2) { }
        private UnityEngine.Vector2 EvalBarycentric(System.Single c0, System.Single c1) { }
        private UnityEngine.Vector2 EvalBarycentric(UnityEngine.Vector3& baryCoords) { }
        private UnityEngine.Vector2 EvalBarycentric(UnityEngine.Vector3 baryCoords) { }
        private System.Void CalcBarycentricCoords(UnityEngine.Vector2& point, UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2, UnityEngine.Vector3& baryCoords) { }
        private UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector2& point) { }
        private UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector2 point) { }
        private System.Single DistanceTo(UnityEngine.Vector2 point) { }
        private System.Int32 QuerySideCCW(UnityEngine.Vector2 point, System.Single epsilon) { }
        private System.Int32 QuerySideCW(UnityEngine.Vector2 point, System.Single epsilon) { }
        private UnityEngine.Vector2 Project(UnityEngine.Vector2 point) { }
        private System.Boolean Contains(UnityEngine.Vector2& point) { }
        private System.Boolean Contains(UnityEngine.Vector2 point) { }
        private System.Boolean ContainsCCW(UnityEngine.Vector2& point) { }
        private System.Boolean ContainsCCW(UnityEngine.Vector2 point) { }
        private System.Boolean ContainsCW(UnityEngine.Vector2& point) { }
        private System.Boolean ContainsCW(UnityEngine.Vector2 point) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000071
    public struct AAB3
    {
        // Fields
        public UnityEngine.Vector3 Min;        // 0x10
        public UnityEngine.Vector3 Max;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3& min, UnityEngine.Vector3& max) { }
        private System.Void .ctor(UnityEngine.Vector3 min, UnityEngine.Vector3 max) { }
        private System.Void .ctor(System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, System.Single zMin, System.Single zMax) { }
        private UnityEngine.Bounds op_Implicit(Dest.Math.AAB3 value) { }
        private Dest.Math.AAB3 op_Implicit(UnityEngine.Bounds value) { }
        private Dest.Math.AAB3 CreateFromPoint(UnityEngine.Vector3& point) { }
        private Dest.Math.AAB3 CreateFromPoint(UnityEngine.Vector3 point) { }
        private Dest.Math.AAB3 CreateFromTwoPoints(UnityEngine.Vector3& point0, UnityEngine.Vector3& point1) { }
        private Dest.Math.AAB3 CreateFromTwoPoints(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1) { }
        private Dest.Math.AAB3 CreateFromPoints(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points) { }
        private Dest.Math.AAB3 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }
        private Dest.Math.AAB3 CreateFromPoints(UnityEngine.Vector3[] points) { }
        private System.Void CalcCenterExtents(UnityEngine.Vector3& center, UnityEngine.Vector3& extents) { }
        private System.Void CalcVertices(UnityEngine.Vector3& vertex0, UnityEngine.Vector3& vertex1, UnityEngine.Vector3& vertex2, UnityEngine.Vector3& vertex3, UnityEngine.Vector3& vertex4, UnityEngine.Vector3& vertex5, UnityEngine.Vector3& vertex6, UnityEngine.Vector3& vertex7) { }
        private UnityEngine.Vector3[] CalcVertices() { }
        private System.Void CalcVertices(UnityEngine.Vector3[] array) { }
        private System.Single CalcVolume() { }
        private System.Single DistanceTo(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 point) { }
        private System.Boolean Contains(UnityEngine.Vector3& point) { }
        private System.Boolean Contains(UnityEngine.Vector3 point) { }
        private System.Void Include(UnityEngine.Vector3& point) { }
        private System.Void Include(UnityEngine.Vector3 point) { }
        private System.Void Include(Dest.Math.AAB3& box) { }
        private System.Void Include(Dest.Math.AAB3 box) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000072
    public struct Box3
    {
        // Fields
        public UnityEngine.Vector3 Center;        // 0x10
        public UnityEngine.Vector3 Axis0;        // 0x1C
        public UnityEngine.Vector3 Axis1;        // 0x28
        public UnityEngine.Vector3 Axis2;        // 0x34
        public UnityEngine.Vector3 Extents;        // 0x40

        // Methods
        private System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& axis0, UnityEngine.Vector3& axis1, UnityEngine.Vector3& axis2, UnityEngine.Vector3& extents) { }
        private System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 axis0, UnityEngine.Vector3 axis1, UnityEngine.Vector3 axis2, UnityEngine.Vector3 extents) { }
        private System.Void .ctor(Dest.Math.AAB3& box) { }
        private System.Void .ctor(Dest.Math.AAB3 box) { }
        private Dest.Math.Box3 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }
        private UnityEngine.Vector3 GetAxis(System.Int32 index) { }
        private System.Void CalcVertices(UnityEngine.Vector3& vertex0, UnityEngine.Vector3& vertex1, UnityEngine.Vector3& vertex2, UnityEngine.Vector3& vertex3, UnityEngine.Vector3& vertex4, UnityEngine.Vector3& vertex5, UnityEngine.Vector3& vertex6, UnityEngine.Vector3& vertex7) { }
        private UnityEngine.Vector3[] CalcVertices() { }
        private System.Void CalcVertices(UnityEngine.Vector3[] array) { }
        private System.Single CalcVolume() { }
        private System.Single DistanceTo(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 point) { }
        private System.Boolean Contains(UnityEngine.Vector3& point) { }
        private System.Boolean Contains(UnityEngine.Vector3 point) { }
        private System.Void Include(Dest.Math.Box3& box) { }
        private System.Void Include(Dest.Math.Box3 box) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000073
    public struct Capsule3
    {
        // Fields
        public Dest.Math.Segment3 Segment;        // 0x10
        public System.Single Radius;        // 0x44

        // Methods
        private System.Void .ctor(Dest.Math.Segment3& segment, System.Single radius) { }
        private System.Void .ctor(Dest.Math.Segment3 segment, System.Single radius) { }

    }

    // TypeToken: 0x2000074
    public struct Circle3
    {
        // Fields
        public UnityEngine.Vector3 Center;        // 0x10
        public UnityEngine.Vector3 Axis0;        // 0x1C
        public UnityEngine.Vector3 Axis1;        // 0x28
        public UnityEngine.Vector3 Normal;        // 0x34
        public System.Single Radius;        // 0x40

        // Methods
        private System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& axis0, UnityEngine.Vector3& axis1, System.Single radius) { }
        private System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 axis0, UnityEngine.Vector3 axis1, System.Single radius) { }
        private System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& normal, System.Single radius) { }
        private System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 normal, System.Single radius) { }
        private System.Boolean CreateCircumscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Circle3& circle) { }
        private System.Boolean CreateInscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Circle3& circle) { }
        private System.Single CalcPerimeter() { }
        private System.Single CalcArea() { }
        private UnityEngine.Vector3 Eval(System.Single t) { }
        private UnityEngine.Vector3 Eval(System.Single t, System.Single radius) { }
        private System.Single DistanceTo(UnityEngine.Vector3 point, System.Boolean solid) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 point, System.Boolean solid) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000075
    public struct Line3
    {
        // Fields
        public UnityEngine.Vector3 Center;        // 0x10
        public UnityEngine.Vector3 Direction;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& direction) { }
        private System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 direction) { }
        private Dest.Math.Line3 CreateFromTwoPoints(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1) { }
        private Dest.Math.Line3 CreateFromTwoPoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1) { }
        private UnityEngine.Vector3 Eval(System.Single t) { }
        private System.Single DistanceTo(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 point) { }
        private System.Single AngleBetweenTwoLines(Dest.Math.Line3 anotherLine, System.Boolean acuteAngleDesired) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000076
    public struct Plane3
    {
        // Fields
        public UnityEngine.Vector3 Normal;        // 0x10
        public System.Single Constant;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3& normal, System.Single constant) { }
        private System.Void .ctor(UnityEngine.Vector3 normal, System.Single constant) { }
        private System.Void .ctor(UnityEngine.Vector3& normal, UnityEngine.Vector3& point) { }
        private System.Void .ctor(UnityEngine.Vector3 normal, UnityEngine.Vector3 point) { }
        private System.Void .ctor(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, UnityEngine.Vector3& p2) { }
        private System.Void .ctor(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2) { }
        private UnityEngine.Plane op_Implicit(Dest.Math.Plane3 value) { }
        private Dest.Math.Plane3 op_Implicit(UnityEngine.Plane value) { }
        private UnityEngine.Vector3 CalcOrigin() { }
        private System.Void CreateOrthonormalBasis(UnityEngine.Vector3& u, UnityEngine.Vector3& v, UnityEngine.Vector3& n) { }
        private System.Single SignedDistanceTo(UnityEngine.Vector3& point) { }
        private System.Single SignedDistanceTo(UnityEngine.Vector3 point) { }
        private System.Single DistanceTo(UnityEngine.Vector3 point) { }
        private System.Int32 QuerySide(UnityEngine.Vector3 point, System.Single epsilon) { }
        private System.Boolean QuerySideNegative(UnityEngine.Vector3 point, System.Single epsilon) { }
        private System.Boolean QuerySidePositive(UnityEngine.Vector3 point, System.Single epsilon) { }
        private System.Int32 QuerySide(Dest.Math.Box3& box, System.Single epsilon) { }
        private System.Boolean QuerySideNegative(Dest.Math.Box3& box, System.Single epsilon) { }
        private System.Boolean QuerySidePositive(Dest.Math.Box3& box, System.Single epsilon) { }
        private System.Int32 QuerySide(Dest.Math.AAB3& box, System.Single epsilon) { }
        private System.Boolean QuerySideNegative(Dest.Math.AAB3& box, System.Single epsilon) { }
        private System.Boolean QuerySidePositive(Dest.Math.AAB3& box, System.Single epsilon) { }
        private System.Int32 QuerySide(Dest.Math.Sphere3& sphere, System.Single epsilon) { }
        private System.Boolean QuerySideNegative(Dest.Math.Sphere3& sphere, System.Single epsilon) { }
        private System.Boolean QuerySidePositive(Dest.Math.Sphere3& sphere, System.Single epsilon) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 ProjectVector(UnityEngine.Vector3 vector) { }
        private System.Single AngleBetweenPlaneNormalAndLine(Dest.Math.Line3 line) { }
        private System.Single AngleBetweenPlaneNormalAndLine(UnityEngine.Vector3 direction) { }
        private System.Single AngleBetweenPlaneAndLine(Dest.Math.Line3 line) { }
        private System.Single AngleBetweenPlaneAndLine(UnityEngine.Vector3 direction) { }
        private System.Single AngleBetweenTwoPlanes(Dest.Math.Plane3 anotherPlane) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000077
    public struct Edge3
    {
        // Fields
        public UnityEngine.Vector3 Point0;        // 0x10
        public UnityEngine.Vector3 Point1;        // 0x1C
        public UnityEngine.Vector3 Direction;        // 0x28
        public UnityEngine.Vector3 Normal;        // 0x34
        public System.Single Length;        // 0x40

    }

    // TypeToken: 0x2000078
    public class Polygon3
    {
        // Fields
        private UnityEngine.Vector3[] _vertices;        // 0x10
        private Dest.Math.Edge3[] _edges;        // 0x18
        private Dest.Math.Plane3 _plane;        // 0x20

        // Methods
        private UnityEngine.Vector3[] get_Vertices() { }
        private Dest.Math.Edge3[] get_Edges() { }
        private System.Int32 get_VertexCount() { }
        private UnityEngine.Vector3 get_Item(System.Int32 vertexIndex) { }
        private System.Void set_Item(System.Int32 vertexIndex, UnityEngine.Vector3 value) { }
        private Dest.Math.Plane3 get_Plane() { }
        private System.Void set_Plane(Dest.Math.Plane3 value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Vector3[] vertices, Dest.Math.Plane3 plane) { }
        private System.Void .ctor(System.Int32 vertexCount, Dest.Math.Plane3 plane) { }
        private System.Void SetVertexProjected(System.Int32 vertexIndex, UnityEngine.Vector3 vertex) { }
        private System.Void ProjectVertices() { }
        private Dest.Math.Edge3 GetEdge(System.Int32 edgeIndex) { }
        private System.Void UpdateEdges() { }
        private System.Void UpdateEdge(System.Int32 edgeIndex) { }
        private UnityEngine.Vector3 CalcCenter() { }
        private System.Single CalcPerimeter() { }
        private System.Boolean HasZeroCorners(System.Single threshold) { }
        private System.Void ReverseVertices() { }
        private Dest.Math.Segment3[] ToSegmentArray() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000079
    public struct Ray3
    {
        // Fields
        public UnityEngine.Vector3 Center;        // 0x10
        public UnityEngine.Vector3 Direction;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& direction) { }
        private System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 direction) { }
        private UnityEngine.Ray op_Implicit(Dest.Math.Ray3 value) { }
        private Dest.Math.Ray3 op_Implicit(UnityEngine.Ray value) { }
        private UnityEngine.Vector3 Eval(System.Single t) { }
        private System.Single DistanceTo(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 point) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200007A
    public struct Rectangle3
    {
        // Fields
        public UnityEngine.Vector3 Center;        // 0x10
        public UnityEngine.Vector3 Axis0;        // 0x1C
        public UnityEngine.Vector3 Axis1;        // 0x28
        public UnityEngine.Vector3 Normal;        // 0x34
        public UnityEngine.Vector2 Extents;        // 0x40

        // Methods
        private System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& axis0, UnityEngine.Vector3& axis1, UnityEngine.Vector2& extents) { }
        private System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 axis0, UnityEngine.Vector3 axis1, UnityEngine.Vector2 extents) { }
        private Dest.Math.Rectangle3 CreateFromCCWPoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3) { }
        private Dest.Math.Rectangle3 CreateFromCWPoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3) { }
        private System.Void CalcVertices(UnityEngine.Vector3& vertex0, UnityEngine.Vector3& vertex1, UnityEngine.Vector3& vertex2, UnityEngine.Vector3& vertex3) { }
        private UnityEngine.Vector3[] CalcVertices() { }
        private System.Void CalcVertices(UnityEngine.Vector3[] array) { }
        private System.Single CalcArea() { }
        private System.Single DistanceTo(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 point) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200007B
    public struct Segment3
    {
        // Fields
        public UnityEngine.Vector3 P0;        // 0x10
        public UnityEngine.Vector3 P1;        // 0x1C
        public UnityEngine.Vector3 Center;        // 0x28
        public UnityEngine.Vector3 Direction;        // 0x34
        public System.Single Extent;        // 0x40

        // Methods
        private System.Void .ctor(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1) { }
        private System.Void .ctor(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1) { }
        private System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& direction, System.Single extent) { }
        private System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 direction, System.Single extent) { }
        private System.Void SetEndpoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1) { }
        private System.Void SetCenterDirectionExtent(UnityEngine.Vector3 center, UnityEngine.Vector3 direction, System.Single extent) { }
        private System.Void CalcCenterDirectionExtent() { }
        private System.Void CalcEndPoints() { }
        private UnityEngine.Vector3 Eval(System.Single s) { }
        private System.Single DistanceTo(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 point) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200007C
    public struct Sphere3
    {
        // Fields
        private static System.Single _4div3mulPi;        // 0x0
        public UnityEngine.Vector3 Center;        // 0x10
        public System.Single Radius;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3& center, System.Single radius) { }
        private System.Void .ctor(UnityEngine.Vector3 center, System.Single radius) { }
        private Dest.Math.Sphere3 CreateFromPointsAAB(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points) { }
        private Dest.Math.Sphere3 CreateFromPointsAAB(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }
        private Dest.Math.Sphere3 CreateFromPointsAverage(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points) { }
        private Dest.Math.Sphere3 CreateFromPointsAverage(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }
        private System.Boolean CreateCircumscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 v3, Dest.Math.Sphere3& sphere) { }
        private System.Boolean CreateInscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 v3, Dest.Math.Sphere3& sphere) { }
        private System.Single CalcArea() { }
        private System.Single CalcVolume() { }
        private UnityEngine.Vector3 Eval(System.Single theta, System.Single phi) { }
        private System.Single DistanceTo(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 point) { }
        private System.Boolean Contains(UnityEngine.Vector3& point) { }
        private System.Boolean Contains(UnityEngine.Vector3 point) { }
        private System.Void Include(Dest.Math.Sphere3& sphere) { }
        private System.Void Include(Dest.Math.Sphere3 sphere) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200007D
    public struct Triangle3
    {
        // Fields
        public UnityEngine.Vector3 V0;        // 0x10
        public UnityEngine.Vector3 V1;        // 0x1C
        public UnityEngine.Vector3 V2;        // 0x28

        // Methods
        private UnityEngine.Vector3 get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, UnityEngine.Vector3 value) { }
        private System.Void .ctor(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2) { }
        private System.Void .ctor(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private UnityEngine.Vector3 CalcEdge(System.Int32 edgeIndex) { }
        private UnityEngine.Vector3 CalcNormal() { }
        private System.Single CalcArea() { }
        private System.Single CalcArea(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2) { }
        private System.Single CalcArea(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private UnityEngine.Vector3 CalcAnglesDeg() { }
        private UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2) { }
        private UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private UnityEngine.Vector3 CalcAnglesRad() { }
        private UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2) { }
        private UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private UnityEngine.Vector3 EvalBarycentric(System.Single c0, System.Single c1) { }
        private UnityEngine.Vector3 EvalBarycentric(UnityEngine.Vector3& baryCoords) { }
        private UnityEngine.Vector3 EvalBarycentric(UnityEngine.Vector3 baryCoords) { }
        private System.Void CalcBarycentricCoords(UnityEngine.Vector3& point, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, UnityEngine.Vector3& baryCoords) { }
        private UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector3& point) { }
        private UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector3 point) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200007E
    public struct Orientations
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Dest.Math.Orientations CW;        // 0x0
        public static Dest.Math.Orientations CCW;        // 0x0
        public static Dest.Math.Orientations None;        // 0x0

    }

    // TypeToken: 0x200007F
    public class Query2 : Query
    {
        // Fields
        private static System.Single Zero;        // 0x0
        private UnityEngine.Vector2[] _vertices;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Vector2[] vertices) { }
        private System.Int32 ToLine(System.Int32 i, System.Int32 v0, System.Int32 v1) { }
        private System.Int32 ToLine(UnityEngine.Vector2& test, System.Int32 v0, System.Int32 v1) { }
        private System.Int32 ToTriangle(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        private System.Int32 ToTriangle(UnityEngine.Vector2& test, System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        private System.Int32 ToCircumcircle(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        private System.Int32 ToCircumcircle(UnityEngine.Vector2& test, System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        private System.Single Dot(System.Single x0, System.Single y0, System.Single x1, System.Single y1) { }
        private System.Single Det2(System.Single x0, System.Single y0, System.Single x1, System.Single y1) { }
        private System.Single Det3(System.Single x0, System.Single y0, System.Single z0, System.Single x1, System.Single y1, System.Single z1, System.Single x2, System.Single y2, System.Single z2) { }

    }

    // TypeToken: 0x2000080
    public class Query3 : Query
    {
        // Fields
        private static System.Single Zero;        // 0x0
        private UnityEngine.Vector3[] _vertices;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Vector3[] vertices) { }
        private System.Int32 ToPlane(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        private System.Int32 ToPlane(UnityEngine.Vector3& test, System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        private System.Int32 ToTetrahedron(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3) { }
        private System.Int32 ToTetrahedron(UnityEngine.Vector3& test, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3) { }
        private System.Int32 ToCircumsphere(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3) { }
        private System.Int32 ToCircumsphere(UnityEngine.Vector3& test, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3) { }
        private System.Single Dot(System.Single x0, System.Single y0, System.Single z0, System.Single x1, System.Single y1, System.Single z1) { }
        private System.Single Det3(System.Single x0, System.Single y0, System.Single z0, System.Single x1, System.Single y1, System.Single z1, System.Single x2, System.Single y2, System.Single z2) { }
        private System.Single Det4(System.Single x0, System.Single y0, System.Single z0, System.Single w0, System.Single x1, System.Single y1, System.Single z1, System.Single w1, System.Single x2, System.Single y2, System.Single z2, System.Single w2, System.Single x3, System.Single y3, System.Single z3, System.Single w3) { }

    }

    // TypeToken: 0x2000081
    public struct QueryTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Dest.Math.QueryTypes Int64;        // 0x0
        public static Dest.Math.QueryTypes Integer;        // 0x0
        public static Dest.Math.QueryTypes Rational;        // 0x0
        public static Dest.Math.QueryTypes Real;        // 0x0
        public static Dest.Math.QueryTypes Filtered;        // 0x0

    }

    // TypeToken: 0x2000082
    public class Query
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean Sort(System.Int32& v0, System.Int32& v1) { }
        private System.Boolean Sort(System.Int32& v0, System.Int32& v1, System.Int32& v2) { }
        private System.Boolean Sort(System.Int32& v0, System.Int32& v1, System.Int32& v2, System.Int32& v3) { }

    }

    // TypeToken: 0x2000083
    public class CatmullRomSpline3 : SplineBase
    {
        // Methods
        private Dest.Math.SplineTypes get_SplineType() { }
        private System.Void set_SplineType(Dest.Math.SplineTypes value) { }
        private Dest.Math.CatmullRomSpline3 Create() { }
        private Dest.Math.CatmullRomSpline3 Create(System.Collections.Generic.IList<UnityEngine.Vector3> points, Dest.Math.SplineTypes type) { }
        private System.Void UpdateSegment(System.Int32 index) { }
        private System.Void UpdateAdjacentSegments(System.Int32 vertexIndex) { }
        private System.Void AddVertexFirst(UnityEngine.Vector3 position) { }
        private System.Void AddVertexLast(UnityEngine.Vector3 position) { }
        private System.Void RemoveVertex(System.Int32 index) { }
        private System.Void Clear() { }
        private System.Void InsertBefore(System.Int32 vertexIndex, UnityEngine.Vector3 position) { }
        private System.Void InsertAfter(System.Int32 vertexIndex, UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 GetVertex(System.Int32 vertexIndex) { }
        private System.Void SetVertex(System.Int32 vertexIndex, UnityEngine.Vector3 position) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000084
    public class CubicSpline3 : SplineBase
    {
        // Methods
        private Dest.Math.SplineTypes get_SplineType() { }
        private System.Void set_SplineType(Dest.Math.SplineTypes value) { }
        private Dest.Math.CubicSpline3 Create() { }
        private Dest.Math.CubicSpline3 Create(System.Collections.Generic.IList<UnityEngine.Vector3> points, Dest.Math.SplineTypes type) { }
        private System.Void BuildSpline() { }
        private System.Void CreateOpenedSpline() { }
        private System.Void CreateClosedSpline() { }
        private System.Void AddVertexFirst(UnityEngine.Vector3 position) { }
        private System.Void AddVertexLast(UnityEngine.Vector3 position) { }
        private System.Void RemoveVertex(System.Int32 index) { }
        private System.Void Clear() { }
        private System.Void InsertBefore(System.Int32 vertexIndex, UnityEngine.Vector3 position) { }
        private System.Void InsertAfter(System.Int32 vertexIndex, UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 GetVertex(System.Int32 vertexIndex) { }
        private System.Void SetVertex(System.Int32 vertexIndex, UnityEngine.Vector3 position) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000085
    public struct SplineTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Dest.Math.SplineTypes Open;        // 0x0
        public static Dest.Math.SplineTypes Closed;        // 0x0

    }

    // TypeToken: 0x2000086
    public struct SplinePlaneTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Dest.Math.SplinePlaneTypes XZ;        // 0x0
        public static Dest.Math.SplinePlaneTypes XY;        // 0x0
        public static Dest.Math.SplinePlaneTypes YZ;        // 0x0

    }

    // TypeToken: 0x2000087
    public struct PositionTangent
    {
        // Fields
        public UnityEngine.Vector3 Position;        // 0x10
        public UnityEngine.Vector3 Tangent;        // 0x1C

    }

    // TypeToken: 0x2000088
    public struct CurveFrame
    {
        // Fields
        public UnityEngine.Vector3 Position;        // 0x10
        public UnityEngine.Vector3 Tangent;        // 0x1C
        public UnityEngine.Vector3 Normal;        // 0x28
        public UnityEngine.Vector3 Binormal;        // 0x34

    }

    // TypeToken: 0x2000089
    public class SplineBase : MonoBehaviour
    {
        // Fields
        protected Dest.Math.SplineBase.ArcLengthParametrization _parametrization;        // 0x18
        protected System.Collections.Generic.List<Dest.Math.SplineBase.ItemData> _data;        // 0x20
        protected Dest.Math.SplineTypes _type;        // 0x28
        protected System.Boolean _recalcSegmentsLength;        // 0x2C
        protected UnityEngine.Color _renderColor;        // 0x30
        protected Dest.Math.SplinePlaneTypes _creationPlane;        // 0x40

        // Methods
        private System.Int32 get_SegmentCount() { }
        private System.Int32 get_VertexCount() { }
        private System.Boolean get_Valid() { }
        private Dest.Math.SplineTypes get_SplineType() { }
        private System.Void set_SplineType(Dest.Math.SplineTypes value) { }
        private System.Void Awake() { }
        private System.Void .ctor() { }
        private System.Void GetSegmentIndexAndTime(System.Single time, System.Int32& segmentIndex, System.Single& segmentTime) { }
        private System.Void PrepareForRuntime() { }
        private System.Void RecalcSegmentsLength() { }
        private System.Void AddVertexFirst(UnityEngine.Vector3 position) { }
        private System.Void AddVertexLast(UnityEngine.Vector3 position) { }
        private System.Void RemoveVertex(System.Int32 index) { }
        private System.Void Clear() { }
        private System.Void InsertBefore(System.Int32 vertexIndex, UnityEngine.Vector3 position) { }
        private System.Void InsertAfter(System.Int32 vertexIndex, UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 GetVertex(System.Int32 vertexIndex) { }
        private System.Void SetVertex(System.Int32 vertexIndex, UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 EvalPosition(System.Single time) { }
        private UnityEngine.Vector3 EvalTangent(System.Single time) { }
        private Dest.Math.PositionTangent EvalPositionTangent(System.Single time) { }
        private System.Void EvalPosition(System.Single time, UnityEngine.Vector3& position) { }
        private System.Void EvalTangent(System.Single time, UnityEngine.Vector3& tangent) { }
        private System.Void EvalPositionTangent(System.Single time, Dest.Math.PositionTangent& positionTangent) { }
        private System.Void EvalFrame(System.Single time, Dest.Math.CurveFrame& frame) { }
        private System.Single EvalCurvature(System.Single time) { }
        private System.Single EvalTorsion(System.Single time) { }
        private UnityEngine.Vector3 EvalPositionParametrized(System.Single length) { }
        private UnityEngine.Vector3 EvalTangentParametrized(System.Single length) { }
        private Dest.Math.PositionTangent EvalPositionTangentParametrized(System.Single length) { }
        private System.Void EvalPositionParametrized(System.Single length, UnityEngine.Vector3& position) { }
        private System.Void EvalTangentParametrized(System.Single length, UnityEngine.Vector3& tangent) { }
        private System.Void EvalPositionTangentParametrized(System.Single length, Dest.Math.PositionTangent& positionTangent) { }
        private System.Void EvalFrameParametrized(System.Single length, Dest.Math.CurveFrame& frame) { }
        private System.Single EvalCurvatureParametrized(System.Single length) { }
        private System.Single EvalTorsionParametrized(System.Single length) { }
        private System.Single CalcTotalLength() { }
        private System.Single LengthToTime(System.Single length, System.Int32 iterations, System.Single tolerance) { }
        private System.Single LengthToTime(System.Single length) { }
        private System.Single ParametrizeByArcLength(System.Int32 pointCount) { }

    }

    // TypeToken: 0x200008C
    public class PointsFilter
    {
        // Methods
        private System.Collections.Generic.List<System.Int32> DistanceFilter(UnityEngine.Vector3[] points, Dest.Math.AAB3 pointsAAB, System.Single radius, Dest.Math.Rand rand) { }

    }

    // TypeToken: 0x200008E
    public class PoissonDiskSampler
    {
        // Fields
        private static readonly System.Single one_div_sqrtTwo;        // 0x0
        private Dest.Math.Rand _rand;        // 0x10
        private System.Collections.Generic.List<System.Int32> _activeList;        // 0x18
        private System.Collections.Generic.List<UnityEngine.Vector2> _points;        // 0x20
        private System.Nullable<System.Int32>[,] _grid;        // 0x28
        private System.Single _r;        // 0x30
        private System.Single _rSquared;        // 0x34
        private System.Single _rTwo;        // 0x38
        private System.Single _rMin;        // 0x3C
        private UnityEngine.Vector2 _min;        // 0x40
        private UnityEngine.Vector2 _max;        // 0x48
        private UnityEngine.Vector2 _size;        // 0x50
        private System.Single _cellSize;        // 0x58
        private System.Int32 _cellsX;        // 0x5C
        private System.Int32 _cellsY;        // 0x60
        public Dest.Math.PoissonDiskSampler.PointDelegate DistanceFilter;        // 0x68
        public System.Int32 PointsPerStep;        // 0x70
        private System.Int32 <MaxPoints>k__BackingField;        // 0x74

        // Methods
        private System.Int32 get_MaxPoints() { }
        private System.Void set_MaxPoints(System.Int32 value) { }
        private System.Void .cctor() { }
        private System.Void .ctor(Dest.Math.Rand rand, UnityEngine.Vector2 minCorner, UnityEngine.Vector2 maxCorner, System.Single minDistanceOuter, System.Single minDistanceInner) { }
        private System.Void CalcGridIndices(UnityEngine.Vector2& point, System.Int32& i, System.Int32& j) { }
        private System.Void InsertIntoGrid(UnityEngine.Vector2& point, System.Int32 index) { }
        private System.Boolean AddPoint(UnityEngine.Vector2& center) { }
        private System.Collections.Generic.List<UnityEngine.Vector2> Sample() { }

    }

    // TypeToken: 0x2000090
    public class WeightedSampler
    {
        // Fields
        protected System.Single[] _accum;        // 0x10
        protected System.Single _total;        // 0x18
        protected Dest.Math.Rand _rand;        // 0x20

        // Methods
        private System.Void .ctor(Dest.Math.Rand rand) { }
        private System.Int32 BinarySearch(System.Single[] array, System.Single value) { }
        private System.Void .ctor(System.Single[] weights) { }
        private System.Void .ctor(System.Single[] weights, Dest.Math.Rand rand) { }
        private System.Void Init(System.Single[] weights) { }
        private System.Int32 SampleIndex() { }

    }

    // TypeToken: 0x2000091
    public class TrianglesSamplerBase : WeightedSampler
    {
        // Fields
        protected UnityEngine.Vector3[] _vertices;        // 0x28

        // Methods
        private System.Void .ctor(Dest.Math.Rand rand) { }
        private System.Single CalclTriangleArea(UnityEngine.Vector3& e0, UnityEngine.Vector3& e1) { }

    }

    // TypeToken: 0x2000092
    public class IndexedTrianglesSampler : TrianglesSamplerBase
    {
        // Fields
        protected System.Int32[] _indices;        // 0x30

        // Methods
        private System.Void .ctor(UnityEngine.Vector3[] vertices, System.Int32[] indices) { }
        private System.Void .ctor(UnityEngine.Vector3[] vertices, System.Int32[] indices, Dest.Math.Rand rand) { }
        private System.Void .ctor(UnityEngine.Mesh mesh) { }
        private System.Void .ctor(UnityEngine.Mesh mesh, Dest.Math.Rand rand) { }
        private System.Void Init() { }
        private UnityEngine.Vector3 Sample() { }
        private UnityEngine.Vector3[] SampleArray(System.Int32 count) { }
        private UnityEngine.Vector3[] SampleArray(System.Int32 count, UnityEngine.Vector2[] uvs, UnityEngine.Texture2D sampleMap, System.Single min, System.Single max) { }

    }

    // TypeToken: 0x2000093
    public class NonIndexedTrianglesSampler : TrianglesSamplerBase
    {
        // Methods
        private System.Void .ctor(UnityEngine.Vector3[] vertices) { }
        private System.Void .ctor(UnityEngine.Vector3[] vertices, Dest.Math.Rand rand) { }
        private System.Void .ctor(UnityEngine.Mesh mesh) { }
        private System.Void .ctor(UnityEngine.Mesh mesh, Dest.Math.Rand rand) { }
        private System.Void Init() { }
        private UnityEngine.Vector3 Sample() { }
        private UnityEngine.Vector3[] SampleArray(System.Int32 count) { }

    }

    // TypeToken: 0x2000094
    public class ShuffleBag`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Dest.Math.Rand _rand;        // 0x0
        private System.Collections.Generic.List<T> _items;        // 0x0
        private System.Int32 _index;        // 0x0

        // Methods
        private System.Int32 get_Count() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void .ctor(Dest.Math.Rand rand) { }
        private System.Void .ctor(Dest.Math.Rand rand, System.Int32 capacity) { }
        private System.Void Add(T item, System.UInt32 count) { }
        private T NextItem() { }
        private System.Void Reset() { }
        private System.Void Clear() { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000096
    public class Util
    {
        // Methods
        private System.Void Shuffle(System.Collections.Generic.IList<T> collection) { }
        private System.Void Shuffle(System.Collections.Generic.IList<T> collection, Dest.Math.Rand rand) { }
        private System.Void Shuffle(T[] collection) { }
        private System.Void Shuffle(T[] collection, Dest.Math.Rand rand) { }

    }

}

