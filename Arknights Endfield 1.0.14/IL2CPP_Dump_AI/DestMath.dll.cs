// ========================================================
// Dumped by @desirepro
// Assembly: DestMath.dll
// Classes:  152
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Edge
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    V0  // 0x10
  public            System.Int32                    V1  // 0x14
METHODS:
  System.Void .ctor(System.Int32 v0, System.Int32 v1)
END_CLASS

CLASS: InnerPoint
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Single                   AverageDistance  // 0x10
  public            System.Single                   Distance0  // 0x14
  public            System.Single                   Distance1  // 0x18
  public            System.Int32                    Index  // 0x1C
METHODS:
END_CLASS

CLASS: SortedVertex
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  public            System.Single                   Value  // 0x10
  public            System.Int32                    Index  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Edge
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    V0  // 0x10
  public            System.Int32                    V1  // 0x14
  public            Dest.Math.ConvexHull2.Edge      E0  // 0x18
  public            Dest.Math.ConvexHull2.Edge      E1  // 0x20
  public            System.Int32                    Sign  // 0x28
  public            System.Int32                    Time  // 0x2C
METHODS:
  System.Void .ctor(System.Int32 v0, System.Int32 v1)
  System.Int32 GetSign(System.Int32 i, Dest.Math.Query2 query)
  System.Void Insert(Dest.Math.ConvexHull2.Edge adj0, Dest.Math.ConvexHull2.Edge adj1)
  System.Void DeleteSelf()
  System.Void GetIndices(System.Int32[]& indices)
END_CLASS

CLASS: Triangle
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    V0  // 0x10
  public            System.Int32                    V1  // 0x14
  public            System.Int32                    V2  // 0x18
  public            Dest.Math.ConvexHull3.Triangle  Adj0  // 0x20
  public            Dest.Math.ConvexHull3.Triangle  Adj1  // 0x28
  public            Dest.Math.ConvexHull3.Triangle  Adj2  // 0x30
  public            System.Int32                    Sign  // 0x38
  public            System.Int32                    Time  // 0x3C
  public            System.Boolean                  OnStack  // 0x40
METHODS:
  System.Void .ctor(System.Int32 v0, System.Int32 v1, System.Int32 v2)
  Dest.Math.ConvexHull3.Triangle GetAdj(System.Int32 index)
  System.Void SetAdj(System.Int32 index, Dest.Math.ConvexHull3.Triangle value)
  System.Int32 GetV(System.Int32 index)
  System.Int32 GetSign(System.Int32 i, Dest.Math.Query3 query)
  System.Void AttachTo(Dest.Math.ConvexHull3.Triangle adj0, Dest.Math.ConvexHull3.Triangle adj1, Dest.Math.ConvexHull3.Triangle adj2)
  System.Int32 DetachFrom(System.Int32 adjIndex, Dest.Math.ConvexHull3.Triangle adj)
END_CLASS

CLASS: TerminatorData
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    V0  // 0x10
  public            System.Int32                    V1  // 0x14
  public            System.Int32                    NullIndex  // 0x18
  public            Dest.Math.ConvexHull3.Triangle  T  // 0x20
METHODS:
  System.Void .ctor(System.Int32 v0, System.Int32 v1, System.Int32 nullIndex, Dest.Math.ConvexHull3.Triangle tri)
END_CLASS

CLASS: Information
TYPE:  class
TOKEN: 0x2000055
FIELDS:
  public            System.Int32                    Dimension  // 0x10
  public            UnityEngine.Vector2             Min  // 0x14
  public            UnityEngine.Vector2             Max  // 0x1C
  public            System.Single                   MaxRange  // 0x24
  public            UnityEngine.Vector2             Origin  // 0x28
  public            UnityEngine.Vector2[]           Direction  // 0x30
  public            System.Int32[]                  Extreme  // 0x38
  public            System.Boolean                  ExtremeCCW  // 0x40
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Information
TYPE:  class
TOKEN: 0x2000058
FIELDS:
  public            System.Int32                    Dimension  // 0x10
  public            UnityEngine.Vector3             Min  // 0x14
  public            UnityEngine.Vector3             Max  // 0x20
  public            System.Single                   MaxRange  // 0x2C
  public            UnityEngine.Vector3             Origin  // 0x30
  public            UnityEngine.Vector3[]           Direction  // 0x40
  public            System.Int32[]                  Extreme  // 0x48
  public            System.Boolean                  ExtremeCCW  // 0x50
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PolyRootFinder
TYPE:  class
TOKEN: 0x200005B
FIELDS:
  private           System.Int32                    _count  // 0x10
  private           System.Int32                    _maxRoot  // 0x14
  private           System.Single[]                 _roots  // 0x18
  private           System.Single                   _epsilon  // 0x20
METHODS:
  System.Single[] get_Roots()
  System.Void .ctor(System.Single epsilon)
  System.Boolean Bisection(Dest.Math.Polynomial poly, System.Single xMin, System.Single xMax, System.Int32 digits, System.Single& root)
  System.Boolean Find(Dest.Math.Polynomial poly, System.Single xMin, System.Single xMax, System.Int32 digits)
END_CLASS

CLASS: ItemData
TYPE:  class
TOKEN: 0x200008A
FIELDS:
  public            UnityEngine.Vector3             Position  // 0x10
  public            UnityEngine.Vector3             A  // 0x1C
  public            UnityEngine.Vector3             B  // 0x28
  public            UnityEngine.Vector3             C  // 0x34
  public            UnityEngine.Vector3             D  // 0x40
  public            System.Single                   Length  // 0x4C
  public            System.Single                   AccumulatedLength  // 0x50
  private   static  System.Int32                    SegmentCount  // 0x0
  private   static  System.Int32                    SegmentCountPlus1  // 0x0
  private   static  System.Single                   DeltaTime  // 0x0
  public            UnityEngine.Vector3[]           RenderPoints  // 0x58
METHODS:
  System.Boolean EnsureRenderPointsValidity()
  System.Void UpdateRenderPoints()
  UnityEngine.Vector3 EvalPosition(System.Single t)
  UnityEngine.Vector3 EvalFirstDerivative(System.Single t)
  UnityEngine.Vector3 EvalSecondDerivative(System.Single t)
  UnityEngine.Vector3 EvalThirdDerivative(System.Single t)
  System.Single EvalSpeed(System.Single t)
  UnityEngine.Vector3 EvalTangent(System.Single t)
  System.Single EvalLength()
  System.Single EvalLength(System.Single t0, System.Single t1)
  System.Single ProcessLength(System.Single currentLength)
  System.Void .ctor()
END_CLASS

CLASS: ArcLengthParametrization
TYPE:  class
TOKEN: 0x200008B
FIELDS:
  public            System.Single[]                 sSample  // 0x10
  public            System.Single[]                 tSample  // 0x18
  public            System.Single[]                 tsSlope  // 0x20
  public            System.Single                   L  // 0x28
METHODS:
  System.Single GetApproximateTimeParameter(System.Single s)
  System.Void .ctor()
END_CLASS

CLASS: Data
TYPE:  class
TOKEN: 0x200008D
FIELDS:
  private           UnityEngine.Vector3[]           _points  // 0x10
  private           System.Collections.Generic.List<System.Int32>[,,]_grid  // 0x18
  private           UnityEngine.Vector3             _min  // 0x20
  private           UnityEngine.Vector3             _max  // 0x2C
  private           System.Int32                    _cellsX  // 0x38
  private           System.Int32                    _cellsY  // 0x3C
  private           System.Int32                    _cellsZ  // 0x40
  private           System.Single                   _cellSize  // 0x44
  private           System.Single                   _radius  // 0x48
  private           Dest.Math.Rand                  _rand  // 0x50
METHODS:
  System.Void .ctor(UnityEngine.Vector3[] points, System.Single radius, Dest.Math.Rand rand, Dest.Math.AAB3 aab)
  System.Int32 BinarySearch(System.Collections.Generic.List<System.Int32> array, System.Int32 value)
  System.Int32 BinarySearch(System.Int32[] array, System.Int32 length, System.Int32 value)
  System.Void CalcGridIndices(UnityEngine.Vector3& point, System.Int32& i, System.Int32& j, System.Int32& k)
  System.Collections.Generic.List<System.Int32> Filter()
END_CLASS

CLASS: PointDelegate
TYPE:  class
TOKEN: 0x200008F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Single Invoke(UnityEngine.Vector2& point)
  System.IAsyncResult BeginInvoke(UnityEngine.Vector2& point, System.AsyncCallback callback, System.Object object)
  System.Single EndInvoke(UnityEngine.Vector2& point, System.IAsyncResult result)
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
METHODS:
END_CLASS

CLASS: Dest.Math.Polynomial
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private           System.Int32                    _degree  // 0x10
  private           System.Single[]                 _coeffs  // 0x18
METHODS:
  System.Int32 get_Degree()
  System.Void set_Degree(System.Int32 value)
  System.Single get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Single value)
  System.Void .ctor(System.Int32 degree)
  Dest.Math.Polynomial DeepCopy()
  Dest.Math.Polynomial CalcDerivative()
  Dest.Math.Polynomial CalcInversion()
  System.Void Compress(System.Single epsilon)
  System.Single Eval(System.Single t)
END_CLASS

CLASS: Dest.Math.Approximation
TYPE:  class
TOKEN: 0x2000003
FIELDS:
METHODS:
  Dest.Math.Box2 GaussPointsFit2(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  System.Boolean HeightLineFit2(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Single& a, System.Single& b)
  Dest.Math.Line2 LeastSquaresLineFit2(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  Dest.Math.Box3 GaussPointsFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  Dest.Math.Line3 LeastsSquaresLineFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  System.Boolean HeightPlaneFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Single& a, System.Single& b, System.Single& c)
  Dest.Math.Plane3 LeastSquaresPlaneFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points)
END_CLASS

CLASS: Dest.Math.ConcaveHull2
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.Boolean _TryFastSort(Dest.Math.ConcaveHull2.InnerPoint[] x, System.Int32 first, System.Int32 last)
  System.Void Quicksort(Dest.Math.ConcaveHull2.InnerPoint[] x, System.Int32 first, System.Int32 last)
  System.Single CalcDistanceFromPointToEdge(UnityEngine.Vector2& pointA, UnityEngine.Vector2& v0, UnityEngine.Vector2& v1)
  System.Boolean Create(UnityEngine.Vector2[] points, System.Int32[]& concaveHull, System.Int32[] convexHull, System.Single N, System.Single epsilon)
  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.ConcaveHull
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Boolean Create2D(UnityEngine.Vector2[] points, System.Int32[]& concaveHull, System.Int32[]& convexHull, System.Single algorithmThreshold, System.Single epsilon)
  System.Boolean Create2D(UnityEngine.Vector2[] points, System.Int32[]& concaveHull, System.Single algorithmThreshold, System.Single epsilon)
END_CLASS

CLASS: Dest.Math.ConvexHull1
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Void Create(System.Single[] vertices, System.Single epsilon, System.Int32& dimension, System.Int32[]& indices)
  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.ConvexHull2
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  System.Boolean Create(System.Collections.Generic.IList<UnityEngine.Vector2> vertices, System.Single epsilon, System.Int32& dimension, System.Int32[]& indices)
  System.Boolean Update(Dest.Math.ConvexHull2.Edge& hull, System.Int32 i, Dest.Math.Query2 query)
  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.ConvexHull3
TYPE:  class
TOKEN: 0x200000D
FIELDS:
METHODS:
  System.Boolean Create(System.Collections.Generic.IList<UnityEngine.Vector3> vertices, System.Single epsilon, System.Int32& dimension, System.Int32[]& indices)
  System.Boolean Update(System.Collections.Generic.HashSet<Dest.Math.ConvexHull3.Triangle> hull, System.Int32 i, Dest.Math.Query3 query)
  System.Void ExtractIndices(System.Collections.Generic.HashSet<Dest.Math.ConvexHull3.Triangle> hull, System.Int32[]& indices)
  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.ConvexHull
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Boolean Create2D(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Int32[]& indices, System.Int32& dimension, System.Single epsilon)
  System.Boolean Create3D(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Int32[]& indices, System.Int32& dimension, System.Single epsilon)
END_CLASS

CLASS: Dest.Math.Distance
TYPE:  class
TOKEN: 0x2000011
FIELDS:
METHODS:
  System.Single Line2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1)
  System.Single Line2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single SqrLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1)
  System.Single SqrLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single Line2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray)
  System.Single Line2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single SqrLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray)
  System.Single SqrLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single Line2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment)
  System.Single Line2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single SqrLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment)
  System.Single SqrLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single Point2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box)
  System.Single Point2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box, UnityEngine.Vector2& closestPoint)
  System.Single SqrPoint2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box)
  System.Single SqrPoint2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box, UnityEngine.Vector2& closestPoint)
  System.Single Point2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box)
  System.Single Point2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box, UnityEngine.Vector2& closestPoint)
  System.Single SqrPoint2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box)
  System.Single SqrPoint2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box, UnityEngine.Vector2& closestPoint)
  System.Single Point2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle)
  System.Single Point2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle, UnityEngine.Vector2& closestPoint)
  System.Single SqrPoint2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle)
  System.Single SqrPoint2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle, UnityEngine.Vector2& closestPoint)
  System.Single Point2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line)
  System.Single Point2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line, UnityEngine.Vector2& closestPoint)
  System.Single SqrPoint2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line)
  System.Single SqrPoint2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line, UnityEngine.Vector2& closestPoint)
  System.Single Point2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray)
  System.Single Point2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint)
  System.Single SqrPoint2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray)
  System.Single SqrPoint2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint)
  System.Single Point2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment)
  System.Single Point2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint)
  System.Single SqrPoint2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment)
  System.Single SqrPoint2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint)
  System.Single Point2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle)
  System.Single Point2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle, UnityEngine.Vector2& closestPoint)
  System.Single SqrPoint2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle)
  System.Single SqrPoint2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle, UnityEngine.Vector2& closestPoint)
  System.Single Ray2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1)
  System.Single Ray2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single SqrRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1)
  System.Single SqrRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single Ray2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment)
  System.Single Ray2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single SqrRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment)
  System.Single SqrRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single Segment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1)
  System.Single Segment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Single SqrSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1)
  System.Single SqrSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  System.Void Face(Dest.Math.Box3& mBox, System.Single& mLineParameter, System.Int32 i0, System.Int32 i1, System.Int32 i2, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, UnityEngine.Vector3& PmE, System.Single& sqrDistance)
  System.Void CaseNoZeros(Dest.Math.Box3& mBox, System.Single& mLineParameter, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, System.Single& sqrDistance)
  System.Void Case0(Dest.Math.Box3& mBox, System.Single& mLineParameter, System.Int32 i0, System.Int32 i1, System.Int32 i2, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, System.Single& sqrDistance)
  System.Void Case00(Dest.Math.Box3& mBox, System.Single& mLineParameter, System.Int32 i0, System.Int32 i1, System.Int32 i2, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, System.Single& sqrDistance)
  System.Void Case000(Dest.Math.Box3& mBox, System.Single& mLineParameter, UnityEngine.Vector3& pnt, System.Single& sqrDistance)
  System.Single Line3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box, Dest.Math.Line3Box3Dist& info)
  System.Single Line3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box)
  System.Single SqrLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box, Dest.Math.Line3Box3Dist& info)
  System.Single SqrLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box)
  System.Single Line3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1)
  System.Single Line3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single SqrLine3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1)
  System.Single SqrLine3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single Line3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray)
  System.Single Line3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single SqrLine3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray)
  System.Single SqrLine3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single Line3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment)
  System.Single Line3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single SqrLine3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment)
  System.Single SqrLine3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single Point3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box)
  System.Single Point3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box, UnityEngine.Vector3& closestPoint)
  System.Single SqrPoint3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box)
  System.Single SqrPoint3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box, UnityEngine.Vector3& closestPoint)
  System.Single Point3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box)
  System.Single Point3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint)
  System.Single SqrPoint3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box)
  System.Single SqrPoint3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint)
  System.Single Point3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, System.Boolean solid)
  System.Single Point3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, UnityEngine.Vector3& closestPoint, System.Boolean solid)
  System.Single SqrPoint3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, System.Boolean solid)
  System.Single SqrPoint3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, UnityEngine.Vector3& closestPoint, System.Boolean solid)
  System.Single Point3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line)
  System.Single Point3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line, UnityEngine.Vector3& closestPoint)
  System.Single SqrPoint3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line)
  System.Single SqrPoint3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line, UnityEngine.Vector3& closestPoint)
  System.Single Point3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane)
  System.Single Point3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane, UnityEngine.Vector3& closestPoint)
  System.Single SqrPoint3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane)
  System.Single SqrPoint3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane, UnityEngine.Vector3& closestPoint)
  System.Single Point3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray)
  System.Single Point3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint)
  System.Single SqrPoint3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray)
  System.Single SqrPoint3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint)
  System.Single Point3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle)
  System.Single Point3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle, UnityEngine.Vector3& closestPoint)
  System.Single SqrPoint3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle)
  System.Single SqrPoint3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle, UnityEngine.Vector3& closestPoint)
  System.Single Point3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment)
  System.Single Point3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint)
  System.Single SqrPoint3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment)
  System.Single SqrPoint3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint)
  System.Single Point3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere)
  System.Single Point3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere, UnityEngine.Vector3& closestPoint)
  System.Single SqrPoint3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere)
  System.Single SqrPoint3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere, UnityEngine.Vector3& closestPoint)
  System.Single Ray3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1)
  System.Single Ray3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single SqrRay3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1)
  System.Single SqrRay3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single Ray3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment)
  System.Single Ray3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single SqrRay3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment)
  System.Single SqrRay3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single Segment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single Segment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box)
  System.Single SqrSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single SqrSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box)
  System.Single Segment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1)
  System.Single Segment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  System.Single SqrSegment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1)
  System.Single SqrSegment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
END_CLASS

CLASS: Dest.Math.Line3Box3Dist
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            UnityEngine.Vector3             ClosestPoint0  // 0x10
  public            UnityEngine.Vector3             ClosestPoint1  // 0x1C
  public            System.Single                   LineParameter  // 0x28
METHODS:
END_CLASS

CLASS: Dest.Math.Intersection
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private   static  System.Single                   _intervalThreshold  // 0x0
  private   static  System.Single                   _dotThreshold  // 0x4
  private   static  System.Single                   _distanceThreshold  // 0x8
METHODS:
  System.Boolean TestAAB2AAB2(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1)
  System.Boolean FindAAB2AAB2(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1, Dest.Math.AAB2& intersection)
  System.Boolean TestAAB2AAB2OverlapX(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1)
  System.Boolean TestAAB2AAB2OverlapY(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1)
  System.Boolean TestAAB2Circle2(Dest.Math.AAB2& box, Dest.Math.Circle2& circle)
  System.Boolean TestBox2Box2(Dest.Math.Box2& box0, Dest.Math.Box2& box1)
  System.Boolean TestBox2Circle2(Dest.Math.Box2& box, Dest.Math.Circle2& circle)
  System.Boolean TestCircle2Circle2(Dest.Math.Circle2& circle0, Dest.Math.Circle2& circle1)
  System.Boolean FindCircle2Circle2(Dest.Math.Circle2& circle0, Dest.Math.Circle2& circle1, Dest.Math.Circle2Circle2Intr& info)
  System.Int32 WhichSide(Dest.Math.Polygon2 V, UnityEngine.Vector2 P, UnityEngine.Vector2& D)
  System.Boolean TestConvexPolygon2ConvexPolygon2(Dest.Math.Polygon2 convexPolygon0, Dest.Math.Polygon2 convexPolygon1)
  System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.AAB2& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector2& point0, UnityEngine.Vector2& point1, Dest.Math.IntersectionTypes& intrType)
  System.Boolean TestLine2AAB2(Dest.Math.Line2& line, Dest.Math.AAB2& box)
  System.Boolean FindLine2AAB2(Dest.Math.Line2& line, Dest.Math.AAB2& box, Dest.Math.Line2AAB2Intr& info)
  System.Boolean Clip(System.Single denom, System.Single numer, System.Single& t0, System.Single& t1)
  System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.Box2& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector2& point0, UnityEngine.Vector2& point1, Dest.Math.IntersectionTypes& intrType)
  System.Boolean TestLine2Box2(Dest.Math.Line2& line, Dest.Math.Box2& box)
  System.Boolean FindLine2Box2(Dest.Math.Line2& line, Dest.Math.Box2& box, Dest.Math.Line2Box2Intr& info)
  System.Boolean Find(UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, UnityEngine.Vector2& center, System.Single radius, System.Int32& rootCount, System.Single& t0, System.Single& t1)
  System.Boolean TestLine2Circle2(Dest.Math.Line2& line, Dest.Math.Circle2& circle)
  System.Boolean FindLine2Circle2(Dest.Math.Line2& line, Dest.Math.Circle2& circle, Dest.Math.Line2Circle2Intr& info)
  System.Boolean TestLine2ConvexPolygon2(Dest.Math.Line2& line, Dest.Math.Polygon2 convexPolygon)
  System.Boolean FindLine2ConvexPolygon2(Dest.Math.Line2& line, Dest.Math.Polygon2 convexPolygon, Dest.Math.Line2ConvexPolygon2Intr& info)
  Dest.Math.IntersectionTypes Classify(Dest.Math.Line2& line0, Dest.Math.Line2& line1, System.Single& s0)
  System.Boolean TestLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1)
  System.Boolean FindLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, Dest.Math.Line2Line2Intr& info)
  Dest.Math.IntersectionTypes Classify(Dest.Math.Line2& line, Dest.Math.Ray2& ray, System.Single& s0, System.Single& s1)
  System.Boolean TestLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray)
  System.Boolean FindLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, Dest.Math.Line2Ray2Intr& info)
  Dest.Math.IntersectionTypes Classify(Dest.Math.Segment2& segment, Dest.Math.Line2& line, System.Single& s0, System.Single& s1)
  System.Boolean TestLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment)
  System.Boolean FindLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, Dest.Math.Line2Segment2Intr& info)
  System.Void TriangleLineRelations(UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.Triangle2& triangle, System.Single& dist0, System.Single& dist1, System.Single& dist2, System.Int32& sign0, System.Int32& sign1, System.Int32& sign2, System.Int32& positive, System.Int32& negative, System.Int32& zero)
  System.Boolean GetInterval(UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.Triangle2& triangle, System.Single dist0, System.Single dist1, System.Single dist2, System.Int32 sign0, System.Int32 sign1, System.Int32 sign2, System.Single& param0, System.Single& param1)
  System.Boolean TestLine2Triangle2(Dest.Math.Line2& line, Dest.Math.Triangle2& triangle, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestLine2Triangle2(Dest.Math.Line2& line, Dest.Math.Triangle2& triangle)
  System.Boolean FindLine2Triangle2(Dest.Math.Line2& line, Dest.Math.Triangle2& triangle, Dest.Math.Line2Triangle2Intr& info)
  System.Boolean TestRay2AAB2(Dest.Math.Ray2& ray, Dest.Math.AAB2& box)
  System.Boolean FindRay2AAB2(Dest.Math.Ray2& ray, Dest.Math.AAB2& box, Dest.Math.Ray2AAB2Intr& info)
  System.Boolean TestRay2Box2(Dest.Math.Ray2& ray, Dest.Math.Box2& box)
  System.Boolean FindRay2Box2(Dest.Math.Ray2& ray, Dest.Math.Box2& box, Dest.Math.Ray2Box2Intr& info)
  System.Boolean TestRay2Circle2(Dest.Math.Ray2& ray, Dest.Math.Circle2& circle)
  System.Boolean FindRay2Circle2(Dest.Math.Ray2& ray, Dest.Math.Circle2& circle, Dest.Math.Ray2Circle2Intr& info)
  System.Boolean TestRay2ConvexPolygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 convexPolygon)
  System.Boolean FindRay2ConvexPolygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 convexPolygon, Dest.Math.Ray2ConvexPolygon2Intr& info)
  System.Boolean TestRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 polygon)
  System.Boolean TestRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Segment2[] segments)
  System.Boolean FindRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 polygon, Dest.Math.Ray2Polygon2Intr& info)
  System.Boolean FindRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Segment2[] segments, Dest.Math.Ray2Polygon2Intr& info)
  Dest.Math.IntersectionTypes Classify(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, System.Single& s0, System.Single& s1)
  System.Boolean TestRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1)
  System.Boolean FindRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, Dest.Math.Ray2Ray2Intr& info)
  Dest.Math.IntersectionTypes Classify(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, System.Single& s0, System.Single& s1)
  System.Boolean TestRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment)
  System.Boolean FindRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, Dest.Math.Ray2Segment2Intr& info)
  System.Boolean TestRay2Triangle2(Dest.Math.Ray2& ray, Dest.Math.Triangle2& triangle, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestRay2Triangle2(Dest.Math.Ray2& ray, Dest.Math.Triangle2& triangle)
  System.Boolean FindRay2Triangle2(Dest.Math.Ray2& ray, Dest.Math.Triangle2& triangle, Dest.Math.Ray2Triangle2Intr& info)
  System.Boolean TestSegment2AAB2(Dest.Math.Segment2& segment, Dest.Math.AAB2& box)
  System.Boolean FindSegment2AAB2(Dest.Math.Segment2& segment, Dest.Math.AAB2& box, Dest.Math.Segment2AAB2Intr& info)
  System.Boolean TestSegment2Box2(Dest.Math.Segment2& segment, Dest.Math.Box2& box)
  System.Boolean FindSegment2Box2(Dest.Math.Segment2& segment, Dest.Math.Box2& box, Dest.Math.Segment2Box2Intr& info)
  System.Boolean TestSegment2Circle2(Dest.Math.Segment2& segment, Dest.Math.Circle2& circle)
  System.Boolean FindSegment2Circle2(Dest.Math.Segment2& segment, Dest.Math.Circle2& circle, Dest.Math.Segment2Circle2Intr& info)
  System.Boolean TestSegment2ConvexPolygon2(Dest.Math.Segment2& segment, Dest.Math.Polygon2 convexPolygon)
  System.Boolean FindSegment2ConvexPolygon2(Dest.Math.Segment2& segment, Dest.Math.Polygon2 convexPolygon, Dest.Math.Segment2ConvexPolygon2Intr& info)
  Dest.Math.IntersectionTypes Classify(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, System.Single& s0, System.Single& s1)
  System.Boolean TestSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1)
  System.Boolean FindSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, Dest.Math.Segment2Segment2Intr& info)
  System.Boolean TestSegment2Triangle2(Dest.Math.Segment2& segment, Dest.Math.Triangle2& triangle, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestSegment2Triangle2(Dest.Math.Segment2& segment, Dest.Math.Triangle2& triangle)
  System.Boolean FindSegment2Triangle2(Dest.Math.Segment2& segment, Dest.Math.Triangle2& triangle, Dest.Math.Segment2Triangle2Intr& info)
  System.Int32 WhichSide(Dest.Math.Triangle2& triangle, UnityEngine.Vector2& P, UnityEngine.Vector2& D)
  System.Void ClipConvexPolygonAgainstLine(UnityEngine.Vector2& edgeStart, UnityEngine.Vector2& edgeEnd, System.Int32& quantity, Dest.Math.Triangle2Triangle2Intr& info)
  System.Boolean TestTriangle2Triangle2(Dest.Math.Triangle2& triangle0, Dest.Math.Triangle2& triangle1)
  System.Boolean FindTriangle2Triangle2(Dest.Math.Triangle2& triangle0, Dest.Math.Triangle2& triangle1, Dest.Math.Triangle2Triangle2Intr& info)
  System.Boolean TestAAB3AAB3(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1)
  System.Boolean FindAAB3AAB3(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1, Dest.Math.AAB3& intersection)
  System.Boolean TestAAB3AAB3OverlapX(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1)
  System.Boolean TestAAB3AAB3OverlapY(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1)
  System.Boolean TestAAB3AAB3OverlapZ(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1)
  System.Boolean TestAAB3Sphere3(Dest.Math.AAB3& box, Dest.Math.Sphere3& sphere)
  System.Boolean TestBox3Box3(Dest.Math.Box3& box0, Dest.Math.Box3& box1)
  System.Boolean TestBox3Capsule3(Dest.Math.Box3& box, Dest.Math.Capsule3& capsule)
  System.Boolean TestBox3Sphere3(Dest.Math.Box3& box, Dest.Math.Sphere3& sphere)
  System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, Dest.Math.AAB3& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, Dest.Math.IntersectionTypes& intrType)
  System.Boolean TestLine3AAB3(Dest.Math.Line3& line, Dest.Math.AAB3& box)
  System.Boolean FindLine3AAB3(Dest.Math.Line3& line, Dest.Math.AAB3& box, Dest.Math.Line3AAB3Intr& info)
  System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, Dest.Math.Box3& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, Dest.Math.IntersectionTypes& intrType)
  System.Boolean TestLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box)
  System.Boolean FindLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box, Dest.Math.Line3Box3Intr& info)
  System.Boolean TestLine3Circle3(Dest.Math.Line3& line, Dest.Math.Circle3& circle)
  System.Boolean FindLine3Circle3(Dest.Math.Line3& line, Dest.Math.Circle3& circle, Dest.Math.Line3Circle3Intr& info)
  System.Boolean TestLine3Plane3(Dest.Math.Line3& line, Dest.Math.Plane3& plane, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestLine3Plane3(Dest.Math.Line3& line, Dest.Math.Plane3& plane)
  System.Boolean FindLine3Plane3(Dest.Math.Line3& line, Dest.Math.Plane3& plane, Dest.Math.Line3Plane3Intr& info)
  System.Boolean TestLine3Polygon3(Dest.Math.Line3& line, Dest.Math.Polygon3 polygon)
  System.Boolean FindLine3Polygon3(Dest.Math.Line3& line, Dest.Math.Polygon3 polygon, Dest.Math.Line3Polygon3Intr& info)
  System.Boolean Point3InsideRectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle)
  System.Boolean TestLine3Rectangle3(Dest.Math.Line3& line, Dest.Math.Rectangle3& rectangle)
  System.Boolean FindLine3Rectangle3(Dest.Math.Line3& line, Dest.Math.Rectangle3& rectangle, Dest.Math.Line3Rectangle3Intr& info)
  System.Boolean TestLine3Sphere3(Dest.Math.Line3& line, Dest.Math.Sphere3& sphere)
  System.Boolean FindLine3Sphere3(Dest.Math.Line3& line, Dest.Math.Sphere3& sphere, Dest.Math.Line3Sphere3Intr& info)
  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, Dest.Math.Triangle3& triangle, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, Dest.Math.Triangle3& triangle)
  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  System.Boolean FindLine3Triangle3(Dest.Math.Line3& line, Dest.Math.Triangle3& triangle, Dest.Math.Line3Triangle3Intr& info)
  System.Boolean FindLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.Line3Triangle3Intr& info)
  System.Boolean FindLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Line3Triangle3Intr& info)
  System.Boolean TestPlane3AAB3(Dest.Math.Plane3& plane, Dest.Math.AAB3& box)
  System.Boolean TestPlane3Box3(Dest.Math.Plane3& plane, Dest.Math.Box3& box)
  System.Boolean TestPlane3Plane3(Dest.Math.Plane3& plane0, Dest.Math.Plane3& plane1)
  System.Boolean FindPlane3Plane3(Dest.Math.Plane3& plane0, Dest.Math.Plane3& plane1, Dest.Math.Plane3Plane3Intr& info)
  System.Boolean TestPlane3Sphere3(Dest.Math.Plane3& plane, Dest.Math.Sphere3& sphere)
  System.Boolean FindPlane3Sphere3(Dest.Math.Plane3& plane, Dest.Math.Sphere3& sphere, Dest.Math.Plane3Sphere3Intr& info)
  System.Boolean TestPlane3Triangle3(Dest.Math.Plane3& plane, Dest.Math.Triangle3& triangle)
  System.Boolean FindPlane3Triangle3(Dest.Math.Plane3& plane, Dest.Math.Triangle3& triangle, Dest.Math.Plane3Triangle3Intr& info)
  System.Boolean TestRay3AAB3(Dest.Math.Ray3& ray, Dest.Math.AAB3& box)
  System.Boolean FindRay3AAB3(Dest.Math.Ray3& ray, Dest.Math.AAB3& box, Dest.Math.Ray3AAB3Intr& info)
  System.Boolean TestRay3Box3(Dest.Math.Ray3& ray, Dest.Math.Box3& box)
  System.Boolean FindRay3Box3(Dest.Math.Ray3& ray, Dest.Math.Box3& box, Dest.Math.Ray3Box3Intr& info)
  System.Boolean TestRay3Circle3(Dest.Math.Ray3& ray, Dest.Math.Circle3& circle)
  System.Boolean FindRay3Circle3(Dest.Math.Ray3& ray, Dest.Math.Circle3& circle, Dest.Math.Ray3Circle3Intr& info)
  System.Boolean TestRay3Plane3(Dest.Math.Ray3& ray, Dest.Math.Plane3& plane, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestRay3Plane3(Dest.Math.Ray3& ray, Dest.Math.Plane3& plane)
  System.Boolean FindRay3Plane3(Dest.Math.Ray3& ray, Dest.Math.Plane3& plane, Dest.Math.Ray3Plane3Intr& info)
  System.Boolean TestRay3Polygon3(Dest.Math.Ray3& ray, Dest.Math.Polygon3 polygon)
  System.Boolean FindRay3Polygon3(Dest.Math.Ray3& ray, Dest.Math.Polygon3 polygon, Dest.Math.Ray3Polygon3Intr& info)
  System.Boolean TestRay3Rectangle3(Dest.Math.Ray3& ray, Dest.Math.Rectangle3& rectangle)
  System.Boolean FindRay3Rectangle3(Dest.Math.Ray3& ray, Dest.Math.Rectangle3& rectangle, Dest.Math.Ray3Rectangle3Intr& info)
  System.Boolean TestRay3Sphere3(Dest.Math.Ray3& ray, Dest.Math.Sphere3& sphere)
  System.Boolean FindRay3Sphere3(Dest.Math.Ray3& ray, Dest.Math.Sphere3& sphere, Dest.Math.Ray3Sphere3Intr& info)
  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, Dest.Math.Triangle3& triangle, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, Dest.Math.Triangle3& triangle)
  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  System.Boolean FindRay3Triangle3(Dest.Math.Ray3& ray, Dest.Math.Triangle3& triangle, Dest.Math.Ray3Triangle3Intr& info)
  System.Boolean FindRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.Ray3Triangle3Intr& info)
  System.Boolean FindRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Ray3Triangle3Intr& info)
  System.Boolean TestSegment3AAB3(Dest.Math.Segment3& segment, Dest.Math.AAB3& box)
  System.Boolean FindSegment3AAB3(Dest.Math.Segment3& segment, Dest.Math.AAB3& box, Dest.Math.Segment3AAB3Intr& info)
  System.Boolean TestSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box)
  System.Boolean FindSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box, Dest.Math.Segment3Box3Intr& info)
  System.Boolean TestSegment3Circle3(Dest.Math.Segment3& segment, Dest.Math.Circle3& circle)
  System.Boolean FindSegment3Circle3(Dest.Math.Segment3& segment, Dest.Math.Circle3& circle, Dest.Math.Segment3Circle3Intr& info)
  System.Boolean TestSegment3Plane3(Dest.Math.Segment3& segment, Dest.Math.Plane3& plane, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestSegment3Plane3(Dest.Math.Segment3& segment, Dest.Math.Plane3& plane)
  System.Boolean FindSegment3Plane3(Dest.Math.Segment3& segment, Dest.Math.Plane3& plane, Dest.Math.Segment3Plane3Intr& info)
  System.Boolean TestSegment3Polygon3(Dest.Math.Segment3& segment, Dest.Math.Polygon3 polygon)
  System.Boolean FindSegment3Polygon3(Dest.Math.Segment3& segment, Dest.Math.Polygon3 polygon, Dest.Math.Segment3Polygon3Intr& info)
  System.Boolean TestSegment3Rectangle3(Dest.Math.Segment3& segment, Dest.Math.Rectangle3& rectangle)
  System.Boolean FindSegment3Rectangle3(Dest.Math.Segment3& segment, Dest.Math.Rectangle3& rectangle, Dest.Math.Segment3Rectangle3Intr& info)
  System.Boolean TestSegment3Sphere3(Dest.Math.Segment3& segment, Dest.Math.Sphere3& sphere)
  System.Boolean FindSegment3Sphere3(Dest.Math.Segment3& segment, Dest.Math.Sphere3& sphere, Dest.Math.Segment3Sphere3Intr& info)
  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, Dest.Math.Triangle3& triangle, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, Dest.Math.Triangle3& triangle)
  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  System.Boolean FindSegment3Triangle3(Dest.Math.Segment3& segment, Dest.Math.Triangle3& triangle, Dest.Math.Segment3Triangle3Intr& info)
  System.Boolean FindSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.Segment3Triangle3Intr& info)
  System.Boolean FindSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Segment3Triangle3Intr& info)
  System.Boolean TestSphere3Sphere3(Dest.Math.Sphere3& sphere0, Dest.Math.Sphere3& sphere1)
  System.Boolean FindSphere3Sphere3(Dest.Math.Sphere3& sphere0, Dest.Math.Sphere3& sphere1, Dest.Math.Sphere3Sphere3Intr& info)
  System.Void ProjectOntoAxis(Dest.Math.Triangle3& triangle, UnityEngine.Vector3& axis, System.Single& fmin, System.Single& fmax)
  System.Void TrianglePlaneRelations(Dest.Math.Triangle3& triangle, Dest.Math.Plane3& plane, System.Single& dist0, System.Single& dist1, System.Single& dist2, System.Int32& sign0, System.Int32& sign1, System.Int32& sign2, System.Int32& positive, System.Int32& negative, System.Int32& zero)
  System.Boolean TrianglePlaneRelationsQuick(Dest.Math.Triangle3& triangle, Dest.Math.Plane3& plane)
  System.Boolean IntersectsSegment(Dest.Math.Plane3& plane, Dest.Math.Triangle3& triangle, UnityEngine.Vector3& end0, UnityEngine.Vector3& end1, System.Boolean grazing, Dest.Math.Triangle3Triangle3Intr& info)
  System.Int32 QueryToLine(UnityEngine.Vector2& test, UnityEngine.Vector2& vec0, UnityEngine.Vector2& vec1)
  System.Int32 QueryToTriangle(UnityEngine.Vector2& test, UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  System.Boolean ContainsPoint(Dest.Math.Triangle3& triangle, Dest.Math.Plane3& plane, UnityEngine.Vector3& point, Dest.Math.Triangle3Triangle3Intr& info)
  System.Boolean GetCoplanarIntersection(Dest.Math.Plane3& plane, Dest.Math.Triangle3& tri0, Dest.Math.Triangle3& tri1, Dest.Math.Triangle3Triangle3Intr& info)
  System.Boolean TestTriangle3Triangle3(Dest.Math.Triangle3& triangle0, Dest.Math.Triangle3& triangle1, Dest.Math.IntersectionTypes& intersectionType)
  System.Boolean TestTriangle3Triangle3(Dest.Math.Triangle3& triangle0, Dest.Math.Triangle3& triangle1)
  System.Boolean FindTriangle3Triangle3(Dest.Math.Triangle3& triangle0, Dest.Math.Triangle3& triangle1, Dest.Math.Triangle3Triangle3Intr& info, System.Boolean reportCoplanarIntersections)
  System.Single get_IntervalThreshold()
  System.Void set_IntervalThreshold(System.Single value)
  System.Single get_DotThreshold()
  System.Void set_DotThreshold(System.Single value)
  System.Single get_DistanceThreshold()
  System.Void set_DistanceThreshold(System.Single value)
  System.Void .cctor()
  System.Int32 FindSegment1Segment1(System.Single seg0Start, System.Single seg0End, System.Single seg1Start, System.Single seg1End, System.Single& w0, System.Single& w1)
END_CLASS

CLASS: Dest.Math.Circle2Circle2Intr
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Line2AAB2Intr
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Box2Intr
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Circle2Intr
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1C
METHODS:
END_CLASS

CLASS: Dest.Math.Line2ConvexPolygon2Intr
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
  public            System.Single                   Parameter0  // 0x28
  public            System.Single                   Parameter1  // 0x2C
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Line2Intr
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point  // 0x14
  public            System.Single                   Parameter  // 0x1C
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Ray2Intr
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point  // 0x14
  public            System.Single                   Parameter  // 0x1C
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Segment2Intr
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point  // 0x14
  public            System.Single                   Parameter  // 0x1C
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Triangle2Intr
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2AAB2Intr
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Box2Intr
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Circle2Intr
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1C
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2ConvexPolygon2Intr
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
  public            System.Single                   Parameter0  // 0x28
  public            System.Single                   Parameter1  // 0x2C
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Polygon2Intr
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1C
  public            System.Single                   Parameter0  // 0x24
  public            System.Single                   Parameter1  // 0x28
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Ray2Intr
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point  // 0x14
  public            System.Single                   Parameter  // 0x1C
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Segment2Intr
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1C
  public            System.Single                   Parameter0  // 0x24
  public            System.Single                   Parameter1  // 0x28
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Triangle2Intr
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2AAB2Intr
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2Box2Intr
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2Circle2Intr
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1C
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2ConvexPolygon2Intr
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
  public            System.Single                   Parameter0  // 0x28
  public            System.Single                   Parameter1  // 0x2C
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2Segment2Intr
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1C
  public            System.Single                   Parameter0  // 0x24
  public            System.Single                   Parameter1  // 0x28
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2Triangle2Intr
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Triangle2Triangle2Intr
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
  public            UnityEngine.Vector2             Point2  // 0x28
  public            UnityEngine.Vector2             Point3  // 0x30
  public            UnityEngine.Vector2             Point4  // 0x38
  public            UnityEngine.Vector2             Point5  // 0x40
METHODS:
  UnityEngine.Vector2 get_Item(System.Int32 i)
  System.Void set_Item(System.Int32 i, UnityEngine.Vector2 value)
END_CLASS

CLASS: Dest.Math.Float6
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  private           System.Single                   _0  // 0x10
  private           System.Single                   _1  // 0x14
  private           System.Single                   _2  // 0x18
  private           System.Single                   _3  // 0x1C
  private           System.Single                   _4  // 0x20
  private           System.Single                   _5  // 0x24
METHODS:
  System.Single get_Item(System.Int32 i)
  System.Void set_Item(System.Int32 i, System.Single value)
END_CLASS

CLASS: Dest.Math.Line3AAB3Intr
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Box3Intr
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Circle3Intr
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Plane3Intr
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   LineParameter  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Polygon3Intr
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Rectangle3Intr
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Sphere3Intr
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
  public            System.Single                   LineParameter0  // 0x30
  public            System.Single                   LineParameter1  // 0x34
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Triangle3Intr
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   LineParameter  // 0x20
  public            System.Single                   TriBary0  // 0x24
  public            System.Single                   TriBary1  // 0x28
  public            System.Single                   TriBary2  // 0x2C
METHODS:
END_CLASS

CLASS: Dest.Math.Plane3Plane3Intr
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            Dest.Math.Line3                 Line  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Plane3Sphere3Intr
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            Dest.Math.Circle3               Circle  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Plane3Triangle3Intr
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
  public            UnityEngine.Vector3             Point2  // 0x30
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3AAB3Intr
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Box3Intr
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Circle3Intr
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Plane3Intr
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   RayParameter  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Polygon3Intr
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Rectangle3Intr
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Sphere3Intr
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
  public            System.Single                   RayParameter0  // 0x30
  public            System.Single                   RayParameter1  // 0x34
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Triangle3Intr
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   RayParameter  // 0x20
  public            System.Single                   TriBary0  // 0x24
  public            System.Single                   TriBary1  // 0x28
  public            System.Single                   TriBary2  // 0x2C
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3AAB3Intr
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Box3Intr
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Circle3Intr
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Plane3Intr
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   SegmentParameter  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Polygon3Intr
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Rectangle3Intr
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Sphere3Intr
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
  public            System.Single                   SegmentParameter0  // 0x30
  public            System.Single                   SegmentParameter1  // 0x34
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Triangle3Intr
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   SegmentParameter  // 0x20
  public            System.Single                   TriBary0  // 0x24
  public            System.Single                   TriBary1  // 0x28
  public            System.Single                   TriBary2  // 0x2C
METHODS:
END_CLASS

CLASS: Dest.Math.Sphere3Sphere3IntrTypes
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.Sphere3Sphere3IntrTypesEmpty  // 0x0
  public    static  Dest.Math.Sphere3Sphere3IntrTypesPoint  // 0x0
  public    static  Dest.Math.Sphere3Sphere3IntrTypesCircle  // 0x0
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSphere0  // 0x0
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSphere0Point  // 0x0
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSphere1  // 0x0
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSphere1Point  // 0x0
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSame  // 0x0
METHODS:
END_CLASS

CLASS: Dest.Math.Sphere3Sphere3Intr
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            Dest.Math.Sphere3Sphere3IntrTypesIntersectionType  // 0x10
  public            Dest.Math.Circle3               Circle  // 0x14
  public            UnityEngine.Vector3             ContactPoint  // 0x48
METHODS:
END_CLASS

CLASS: Dest.Math.Triangle3Triangle3Intr
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            Dest.Math.IntersectionTypes     CoplanarIntersectionType  // 0x14
  public            System.Boolean                  Touching  // 0x18
  public            System.Int32                    Quantity  // 0x1C
  public            UnityEngine.Vector3             Point0  // 0x20
  public            UnityEngine.Vector3             Point1  // 0x2C
  public            UnityEngine.Vector3             Point2  // 0x38
  public            UnityEngine.Vector3             Point3  // 0x44
  public            UnityEngine.Vector3             Point4  // 0x50
  public            UnityEngine.Vector3             Point5  // 0x5C
METHODS:
  UnityEngine.Vector3 get_Item(System.Int32 i)
  System.Void set_Item(System.Int32 i, UnityEngine.Vector3 value)
END_CLASS

CLASS: Dest.Math.IntersectionTypes
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.IntersectionTypes     Empty  // 0x0
  public    static  Dest.Math.IntersectionTypes     Point  // 0x0
  public    static  Dest.Math.IntersectionTypes     Segment  // 0x0
  public    static  Dest.Math.IntersectionTypes     Ray  // 0x0
  public    static  Dest.Math.IntersectionTypes     Line  // 0x0
  public    static  Dest.Math.IntersectionTypes     Polygon  // 0x0
  public    static  Dest.Math.IntersectionTypes     Plane  // 0x0
  public    static  Dest.Math.IntersectionTypes     Polyhedron  // 0x0
  public    static  Dest.Math.IntersectionTypes     Other  // 0x0
METHODS:
END_CLASS

CLASS: Dest.Math.ILogger
TYPE:  interface
TOKEN: 0x200004C
FIELDS:
METHODS:
  System.Void LogInfo(System.Object value)
  System.Void LogWarning(System.Object value)
  System.Void LogError(System.Object value)
END_CLASS

CLASS: Dest.Math.Logger
TYPE:  class
TOKEN: 0x200004D
FIELDS:
  private   static  Dest.Math.ILogger               _instance  // 0x0
METHODS:
  System.Void .cctor()
  System.Void LogInfo(System.Object value)
  System.Void LogWarning(System.Object value)
  System.Void LogError(System.Object value)
  System.Void SetLogger(Dest.Math.ILogger logger)
  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.DefaultLogger
TYPE:  class
TOKEN: 0x200004E
FIELDS:
METHODS:
  System.Void LogInfo(System.Object value)
  System.Void LogWarning(System.Object value)
  System.Void LogError(System.Object value)
  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.EmptyLogger
TYPE:  class
TOKEN: 0x200004F
FIELDS:
METHODS:
  System.Void LogInfo(System.Object value)
  System.Void LogWarning(System.Object value)
  System.Void LogError(System.Object value)
  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.Mathfex
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  public    static  System.Single                   ZeroTolerance  // 0x0
  public    static  System.Single                   NegativeZeroTolerance  // 0x0
  public    static  System.Single                   ZeroToleranceSqr  // 0x0
  public    static  System.Single                   Pi  // 0x0
  public    static  System.Single                   HalfPi  // 0x0
  public    static  System.Single                   TwoPi  // 0x0
METHODS:
  System.Single EvalSquared(System.Single x)
  System.Single EvalInvSquared(System.Single x)
  System.Single EvalCubic(System.Single x)
  System.Single EvalInvCubic(System.Single x)
  System.Single EvalQuadratic(System.Single x, System.Single a, System.Single b, System.Single c)
  System.Single EvalSigmoid(System.Single x)
  System.Single EvalOverlappedStep(System.Single x, System.Single overlap, System.Int32 objectIndex, System.Int32 objectCount)
  System.Single EvalSmoothOverlappedStep(System.Single x, System.Single overlap, System.Int32 objectIndex, System.Int32 objectCount)
  System.Single EvalGaussian(System.Single x, System.Single a, System.Single b, System.Single c)
  System.Single EvalGaussian2D(System.Single x, System.Single y, System.Single x0, System.Single y0, System.Single A, System.Single a, System.Single b, System.Single c)
  System.Single Lerp(System.Single value0, System.Single value1, System.Single factor)
  System.Single LerpUnclamped(System.Single value0, System.Single value1, System.Single factor)
  System.Single SigmoidInterp(System.Single value0, System.Single value1, System.Single factor)
  System.Single SinInterp(System.Single value0, System.Single value1, System.Single factor)
  System.Single CosInterp(System.Single value0, System.Single value1, System.Single factor)
  System.Single WobbleInterp(System.Single value0, System.Single value1, System.Single factor)
  System.Single CurveInterp(System.Single value0, System.Single value1, System.Single factor, UnityEngine.AnimationCurve curve)
  System.Single FuncInterp(System.Single value0, System.Single value1, System.Single factor, System.Func<System.Single,System.Single> func)
  System.Single InvSqrt(System.Single value)
  System.Boolean Near(System.Single value0, System.Single value1, System.Single epsilon)
  System.Boolean NearZero(System.Single value, System.Single epsilon)
  UnityEngine.Vector2 CartesianToPolar(UnityEngine.Vector2 cartesianCoordinates)
  UnityEngine.Vector2 PolarToCartesian(UnityEngine.Vector2 polarCoordinates)
  UnityEngine.Vector3 CartesianToSpherical(UnityEngine.Vector3 cartesianCoordinates)
  UnityEngine.Vector3 SphericalToCartesian(UnityEngine.Vector3 sphericalCoordinates)
  UnityEngine.Vector3 CartesianToCylindrical(UnityEngine.Vector3 cartesianCoordinates)
  UnityEngine.Vector3 CylindricalToCartesian(UnityEngine.Vector3 cylindricalCoordinates)
END_CLASS

CLASS: Dest.Math.Matrix4x4ex
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  public    static readonly UnityEngine.Matrix4x4           Identity  // 0x0
METHODS:
  System.Void RotationMatrixToQuaternion(UnityEngine.Matrix4x4& matrix, UnityEngine.Quaternion& quaternion)
  System.Void QuaternionToRotationMatrix(UnityEngine.Quaternion quaternion, UnityEngine.Matrix4x4& matrix)
  System.Void QuaternionToRotationMatrix(UnityEngine.Quaternion& quaternion, UnityEngine.Matrix4x4& matrix)
  System.Void CreateTranslation(UnityEngine.Vector3 position, UnityEngine.Matrix4x4& matrix)
  System.Void CreateTranslation(UnityEngine.Vector3& position, UnityEngine.Matrix4x4& matrix)
  System.Void CreateScale(UnityEngine.Vector3 scale, UnityEngine.Matrix4x4& matrix)
  System.Void CreateScale(UnityEngine.Vector3& scale, UnityEngine.Matrix4x4& matrix)
  System.Void CreateScale(System.Single scale, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotationEuler(System.Single eulerX, System.Single eulerY, System.Single eulerZ, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotationEuler(UnityEngine.Vector3 eulerAngles, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotationEuler(UnityEngine.Vector3& eulerAngles, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotationX(System.Single angleInDegrees, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotationY(System.Single angleInDegrees, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotationZ(System.Single angleInDegrees, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotationAngleAxis(System.Single angleInDegrees, UnityEngine.Vector3 rotationAxis, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotationAngleUnitAxis(System.Single angleInDegrees, UnityEngine.Vector3 normalizedAxis, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotation(UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Matrix4x4& result)
  System.Void CreateRotation(UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Matrix4x4& result)
  System.Void Transpose(UnityEngine.Matrix4x4& matrix)
  System.Void Transpose(UnityEngine.Matrix4x4& matrix, UnityEngine.Matrix4x4& transpose)
  System.Single CalcDeterminant(UnityEngine.Matrix4x4& matrix)
  System.Void Inverse(UnityEngine.Matrix4x4& matrix, System.Single epsilon)
  System.Void Inverse(UnityEngine.Matrix4x4& matrix, UnityEngine.Matrix4x4& inverse, System.Single epsilon)
  System.Void CopyMatrix(UnityEngine.Matrix4x4& source, UnityEngine.Matrix4x4& destination)
  System.Void Multiply(UnityEngine.Matrix4x4& matrix0, UnityEngine.Matrix4x4& matrix1, UnityEngine.Matrix4x4& result)
  System.Void MultiplyRight(UnityEngine.Matrix4x4& matrix0, UnityEngine.Matrix4x4& matrix1)
  System.Void MultiplyLeft(UnityEngine.Matrix4x4& matrix1, UnityEngine.Matrix4x4& matrix0)
  System.Void Multiply(UnityEngine.Matrix4x4& matrix, System.Single scalar)
  System.Void Multiply(UnityEngine.Matrix4x4& matrix, System.Single scalar, UnityEngine.Matrix4x4& result)
  UnityEngine.Vector4 Multiply(UnityEngine.Matrix4x4& matrix, UnityEngine.Vector4 vector)
  UnityEngine.Vector4 Multiply(UnityEngine.Matrix4x4& matrix, UnityEngine.Vector4& vector)
  System.Void CreateSRT(UnityEngine.Vector3 scaling, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  System.Void CreateSRT(UnityEngine.Vector3& scaling, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  System.Void CreateSRT(System.Single scaling, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  System.Void CreateSRT(System.Single scaling, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  System.Void CreateSRT(UnityEngine.Vector3 scaling, UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  System.Void CreateSRT(UnityEngine.Vector3& scaling, UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  System.Void CreateSRT(System.Single scaling, UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  System.Void CreateSRT(System.Single scaling, UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  System.Void CreateRT(UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  System.Void CreateRT(UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  System.Void CreateRT(UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  System.Void CreateRT(UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  System.Void CreateST(UnityEngine.Vector3 scaling, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  System.Void CreateST(UnityEngine.Vector3& scaling, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  System.Void CreateRotationFromColumns(UnityEngine.Vector3 column0, UnityEngine.Vector3 column1, UnityEngine.Vector3 column2, UnityEngine.Matrix4x4& matrix)
  System.Void CreateRotationFromColumns(UnityEngine.Vector3& column0, UnityEngine.Vector3& column1, UnityEngine.Vector3& column2, UnityEngine.Matrix4x4& matrix)
  System.Void CreateShadowDirectional(Dest.Math.Plane3 shadowPlane, UnityEngine.Vector3 dirLightOppositeDirection, UnityEngine.Matrix4x4& result)
  System.Void CreateShadowDirectional(Dest.Math.Plane3& shadowPlane, UnityEngine.Vector3& dirLightOppositeDirection, UnityEngine.Matrix4x4& result)
  System.Void CreateShadowPoint(Dest.Math.Plane3 shadowPlane, UnityEngine.Vector3 pointLightPosition, UnityEngine.Matrix4x4& result)
  System.Void CreateShadowPoint(Dest.Math.Plane3& shadowPlane, UnityEngine.Vector3& pointLightPosition, UnityEngine.Matrix4x4& result)
  System.Void CreateShadow(Dest.Math.Plane3 shadowPlane, UnityEngine.Vector4 lightData, UnityEngine.Matrix4x4& result)
  System.Void CreateShadow(Dest.Math.Plane3& shadowPlane, UnityEngine.Vector4& lightData, UnityEngine.Matrix4x4& result)
  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.Quaternionex
TYPE:  class
TOKEN: 0x2000052
FIELDS:
METHODS:
  UnityEngine.Quaternion DeltaTo(UnityEngine.Quaternion quat, UnityEngine.Quaternion target)
  System.String ToStringEx(UnityEngine.Quaternion quat)
END_CLASS

CLASS: Dest.Math.Rand
TYPE:  class
TOKEN: 0x2000053
FIELDS:
  private   static  System.Int32                    a  // 0x0
  private   static  System.Int32                    b  // 0x0
  private   static  System.Int32                    c  // 0x0
  private   static  System.UInt32                   DefaultY  // 0x0
  private   static  System.UInt32                   DefaultZ  // 0x0
  private   static  System.UInt32                   DefaultW  // 0x0
  private   static  System.UInt32                   PositiveMask  // 0x0
  private   static  System.UInt32                   BoolModuloMask  // 0x0
  private   static  System.UInt32                   ByteModuloMask  // 0x0
  private   static  System.Double                   One_div_uintMaxValuePlusOne  // 0x0
  private   static  System.Double                   TwoPi  // 0x0
  private   static  Dest.Math.Rand                  _seedGenerator  // 0x0
  private           System.UInt32                   _x  // 0x10
  private           System.UInt32                   _y  // 0x14
  private           System.UInt32                   _z  // 0x18
  private           System.UInt32                   _w  // 0x1C
  public    static  Dest.Math.Rand                  Instance  // 0x8
METHODS:
  System.Void .cctor()
  System.Void .ctor()
  System.Void .ctor(System.Int32 seed)
  System.Void ResetSeed(System.Int32 seed)
  System.Void GetState(System.UInt32& x, System.UInt32& y, System.UInt32& z, System.UInt32& w)
  System.Void SetState(System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w)
  System.Int32 NextInt()
  System.Int32 NextInt(System.Int32 max)
  System.Int32 NextInt(System.Int32 min, System.Int32 max)
  System.Int32 NextIntInclusive(System.Int32 min, System.Int32 max)
  System.Int32 NextPositiveInt()
  System.UInt32 NextUInt()
  System.Double NextDouble()
  System.Double NextDouble(System.Double min, System.Double max)
  System.Single NextFloat()
  System.Single NextFloat(System.Single min, System.Single max)
  System.Boolean NextBool()
  System.Byte NextByte()
  UnityEngine.Color RandomColorOpaque()
  UnityEngine.Color RandomColorTransparent()
  UnityEngine.Color32 RandomColor32Opaque()
  UnityEngine.Color32 RandomColor32Transparent()
  System.Single RandomAngleRadians()
  System.Single RandomAngleDegrees()
  UnityEngine.Vector2 InSquare(System.Single side)
  UnityEngine.Vector2 OnSquare(System.Single side)
  UnityEngine.Vector3 InCube(System.Single side)
  UnityEngine.Vector3 OnCube(System.Single side)
  UnityEngine.Vector2 InCircle(System.Single radius)
  UnityEngine.Vector2 InCircle(System.Single radiusMin, System.Single radiusMax)
  UnityEngine.Vector2 OnCircle(System.Single radius)
  UnityEngine.Vector3 InSphere(System.Single radius)
  UnityEngine.Vector3 OnSphere(System.Single radius)
  UnityEngine.Vector3 InTriangle(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  UnityEngine.Vector3 InTriangle(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  UnityEngine.Quaternion RandomRotation()
END_CLASS

CLASS: Dest.Math.Vector2ex
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  public    static readonly UnityEngine.Vector2             Zero  // 0x0
  public    static readonly UnityEngine.Vector2             One  // 0x8
  public    static readonly UnityEngine.Vector2             UnitX  // 0x10
  public    static readonly UnityEngine.Vector2             UnitY  // 0x18
  public    static readonly UnityEngine.Vector2             PositiveInfinity  // 0x20
  public    static readonly UnityEngine.Vector2             NegativeInfinity  // 0x28
METHODS:
  Dest.Math.Vector2ex.Information GetInformation(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Single epsilon)
  System.Single Length(UnityEngine.Vector2 vector)
  System.Single LengthSqr(UnityEngine.Vector2 vector)
  System.Single DotPerp(UnityEngine.Vector2 vector, UnityEngine.Vector2 value)
  System.Single DotPerp(UnityEngine.Vector2 vector, UnityEngine.Vector2& value)
  System.Single DotPerp(UnityEngine.Vector2& vector, UnityEngine.Vector2& value)
  System.Single Dot(UnityEngine.Vector2 vector, UnityEngine.Vector2 value)
  System.Single Dot(UnityEngine.Vector2 vector, UnityEngine.Vector2& value)
  System.Single Dot(UnityEngine.Vector2& vector, UnityEngine.Vector2& value)
  UnityEngine.Vector2 Perp(UnityEngine.Vector2 vector)
  System.Single AngleDeg(UnityEngine.Vector2 vector, UnityEngine.Vector2 target)
  System.Single AngleRad(UnityEngine.Vector2 vector, UnityEngine.Vector2 target)
  System.Single Normalize(UnityEngine.Vector2& vector, System.Single epsilon)
  System.Single SetLength(UnityEngine.Vector2& vector, System.Single lengthValue, System.Single epsilon)
  System.Single GrowLength(UnityEngine.Vector2& vector, System.Single lengthDelta, System.Single epsilon)
  UnityEngine.Vector2 Replicate(System.Single value)
  UnityEngine.Vector3 ToVector3XY(UnityEngine.Vector2 vector)
  UnityEngine.Vector3 ToVector3XZ(UnityEngine.Vector2 vector)
  UnityEngine.Vector3 ToVector3YZ(UnityEngine.Vector2 vector)
  System.String ToStringEx(UnityEngine.Vector2 vector)
  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.ProjectionPlanes
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.ProjectionPlanes      XY  // 0x0
  public    static  Dest.Math.ProjectionPlanes      XZ  // 0x0
  public    static  Dest.Math.ProjectionPlanes      YZ  // 0x0
METHODS:
END_CLASS

CLASS: Dest.Math.Vector3ex
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  public    static readonly UnityEngine.Vector3             Zero  // 0x0
  public    static readonly UnityEngine.Vector3             One  // 0xC
  public    static readonly UnityEngine.Vector3             UnitX  // 0x18
  public    static readonly UnityEngine.Vector3             UnitY  // 0x24
  public    static readonly UnityEngine.Vector3             UnitZ  // 0x30
  public    static readonly UnityEngine.Vector3             PositiveInfinity  // 0x3C
  public    static readonly UnityEngine.Vector3             NegativeInfinity  // 0x48
METHODS:
  Dest.Math.Vector3ex.Information GetInformation(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Single epsilon)
  System.Single Length(UnityEngine.Vector3 vector)
  System.Single LengthSqr(UnityEngine.Vector3 vector)
  System.Single Dot(UnityEngine.Vector3 vector, UnityEngine.Vector3 value)
  System.Single Dot(UnityEngine.Vector3 vector, UnityEngine.Vector3& value)
  System.Single Dot(UnityEngine.Vector3& vector, UnityEngine.Vector3& value)
  System.Single AngleDeg(UnityEngine.Vector3 vector, UnityEngine.Vector3 target)
  System.Single AngleRad(UnityEngine.Vector3 vector, UnityEngine.Vector3 target)
  System.Single SignedAngleDeg(UnityEngine.Vector3 vector, UnityEngine.Vector3 target, UnityEngine.Vector3 normal)
  System.Single SignedAngleRad(UnityEngine.Vector3 vector, UnityEngine.Vector3 target, UnityEngine.Vector3 normal)
  UnityEngine.Vector3 Cross(UnityEngine.Vector3 vector, UnityEngine.Vector3 value)
  UnityEngine.Vector3 Cross(UnityEngine.Vector3 vector, UnityEngine.Vector3& value)
  UnityEngine.Vector3 Cross(UnityEngine.Vector3& vector, UnityEngine.Vector3& value)
  UnityEngine.Vector3 UnitCross(UnityEngine.Vector3 vector, UnityEngine.Vector3 value)
  UnityEngine.Vector3 UnitCross(UnityEngine.Vector3 vector, UnityEngine.Vector3& value)
  UnityEngine.Vector3 UnitCross(UnityEngine.Vector3& vector, UnityEngine.Vector3& value)
  System.Single Normalize(UnityEngine.Vector3& vector, System.Single epsilon)
  System.Single SetLength(UnityEngine.Vector3& vector, System.Single lengthValue, System.Single epsilon)
  System.Single GrowLength(UnityEngine.Vector3& vector, System.Single lengthDelta, System.Single epsilon)
  UnityEngine.Vector3 Replicate(System.Single value)
  System.Void CreateOrthonormalBasis(UnityEngine.Vector3& u, UnityEngine.Vector3& v, UnityEngine.Vector3& w)
  System.Boolean SameDirection(UnityEngine.Vector3 value0, UnityEngine.Vector3 value1)
  UnityEngine.Vector2 ToVector2XY(UnityEngine.Vector3 vector)
  UnityEngine.Vector2 ToVector2XZ(UnityEngine.Vector3 vector)
  UnityEngine.Vector2 ToVector2YZ(UnityEngine.Vector3 vector)
  UnityEngine.Vector2 ToVector2(UnityEngine.Vector3 vector, Dest.Math.ProjectionPlanes projectionPlane)
  Dest.Math.ProjectionPlanes GetProjectionPlane(UnityEngine.Vector3 vector)
  System.String ToStringEx(UnityEngine.Vector3 vector)
  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.BrentsRoot
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            System.Single                   X  // 0x10
  public            System.Int32                    Iterations  // 0x14
  public            System.Boolean                  ExceededMaxIterations  // 0x18
METHODS:
END_CLASS

CLASS: Dest.Math.RootFinder
TYPE:  class
TOKEN: 0x200005A
FIELDS:
  private   static  System.Single                   third  // 0x0
  private   static  System.Single                   twentySeventh  // 0x0
  private   static  System.Single                   sqrt3  // 0x0
METHODS:
  System.Boolean BrentsMethod(System.Func<System.Single,System.Single> function, System.Single x0, System.Single x1, Dest.Math.BrentsRoot& root, System.Int32 maxIterations, System.Single negativeTolerance, System.Single positiveTolerance, System.Single stepTolerance, System.Single segmentTolerance)
  System.Boolean Linear(System.Single c0, System.Single c1, System.Single& root, System.Single epsilon)
  System.Boolean Quadratic(System.Single c0, System.Single c1, System.Single c2, Dest.Math.QuadraticRoots& roots, System.Single epsilon)
  System.Boolean Cubic(System.Single c0, System.Single c1, System.Single c2, System.Single c3, Dest.Math.CubicRoots& roots, System.Single epsilon)
  System.Boolean Quartic(System.Single c0, System.Single c1, System.Single c2, System.Single c3, System.Single c4, Dest.Math.QuarticRoots& roots, System.Single epsilon)
  System.Single PolynomialBound(Dest.Math.Polynomial poly, System.Single epsilon)
  System.Boolean Polynomial(Dest.Math.Polynomial poly, System.Single xMin, System.Single xMax, System.Single[]& roots, System.Int32 digits, System.Single epsilon)
  System.Boolean Polynomial(Dest.Math.Polynomial poly, System.Single[]& roots, System.Int32 digits, System.Single epsilon)
  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.EigenData
TYPE:  class
TOKEN: 0x200005C
FIELDS:
  private           System.Int32                    _size  // 0x10
  private           System.Single[]                 _diagonal  // 0x18
  private           System.Single[,]                _matrix  // 0x20
METHODS:
  System.Int32 get_Size()
  System.Void .ctor(System.Single[] diagonal, System.Single[,] matrix)
  System.Single GetEigenvalue(System.Int32 index)
  UnityEngine.Vector2 GetEigenvector2(System.Int32 index)
  UnityEngine.Vector3 GetEigenvector3(System.Int32 index)
  System.Single[] GetEigenvector(System.Int32 index)
  System.Void GetEigenvector(System.Int32 index, System.Single[] out_eigenvector)
END_CLASS

CLASS: Dest.Math.EigenDecomposition
TYPE:  class
TOKEN: 0x200005D
FIELDS:
METHODS:
  System.Void Tridiagonal2(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  System.Void Tridiagonal3(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  System.Void TridiagonalN(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  System.Boolean QLAlgorithm(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix)
  System.Void IncreasingSort(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  System.Void DecreasingSort(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  System.Void GuaranteeRotation(System.Single[,] matrix, System.Boolean isRotation)
  Dest.Math.EigenData Solve(System.Single[,] symmetricSquareMatrix, System.Boolean increasingSort)
END_CLASS

CLASS: Dest.Math.Integrator
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  private   static  System.Int32                    _degree  // 0x0
  private   static  System.Single[]                 root  // 0x0
  private   static  System.Single[]                 coeff  // 0x8
METHODS:
  System.Single TrapezoidRule(System.Func<System.Single,System.Single> function, System.Single a, System.Single b, System.Int32 sampleCount)
  System.Single RombergIntegral(System.Func<System.Single,System.Single> function, System.Single a, System.Single b, System.Int32 order)
  System.Single GaussianQuadrature(System.Func<System.Single,System.Single> function, System.Single a, System.Single b)
  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.LinearSystem
TYPE:  class
TOKEN: 0x200005F
FIELDS:
METHODS:
  System.Boolean Solve2(System.Single[,] A, System.Single[] B, System.Single[]& X, System.Single zeroTolerance)
  System.Boolean Solve2(System.Single[,] A, System.Single[] B, UnityEngine.Vector2& X, System.Single zeroTolerance)
  System.Boolean Solve3(System.Single[,] A, System.Single[] B, System.Single[]& X, System.Single zeroTolerance)
  System.Boolean Solve3(System.Single[,] A, System.Single[] B, UnityEngine.Vector3& X, System.Single zeroTolerance)
  System.Void SwapRows(System.Single[,] matrix, System.Int32 row0, System.Int32 row1, System.Int32 columnCount)
  System.Boolean Solve(System.Single[,] A, System.Single[] B, System.Single[]& X)
  System.Boolean SolveTridiagonal(System.Single[] A, System.Single[] B, System.Single[] C, System.Single[] R, System.Single[]& U)
  System.Boolean Inverse(System.Single[,] A, System.Single[,]& invA)
END_CLASS

CLASS: Dest.Math.OdeFunction
TYPE:  class
TOKEN: 0x2000060
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Single t, System.Single[] y, System.Single[] F)
  System.IAsyncResult BeginInvoke(System.Single t, System.Single[] y, System.Single[] F, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Dest.Math.OdeSolver
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  protected         System.Int32                    _dim  // 0x10
  protected         System.Single                   _step  // 0x14
  protected         Dest.Math.OdeFunction           _function  // 0x18
  protected         System.Single[]                 _FValue  // 0x20
METHODS:
  System.Single get_Step()
  System.Void set_Step(System.Single value)
  System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function)
  System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut)
END_CLASS

CLASS: Dest.Math.OdeEuler
TYPE:  class
TOKEN: 0x2000062
EXTENDS: OdeSolver
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function)
  System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut)
END_CLASS

CLASS: Dest.Math.OdeMidpoint
TYPE:  class
TOKEN: 0x2000063
EXTENDS: OdeSolver
FIELDS:
  private           System.Single                   _halfStep  // 0x28
  private           System.Single[]                 _yTemp  // 0x30
METHODS:
  System.Single get_Step()
  System.Void set_Step(System.Single value)
  System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function)
  System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut)
END_CLASS

CLASS: Dest.Math.OdeRungeKutta4
TYPE:  class
TOKEN: 0x2000064
EXTENDS: OdeSolver
FIELDS:
  private           System.Single                   _halfStep  // 0x28
  private           System.Single                   _sixthStep  // 0x2C
  private           System.Single[]                 _temp1  // 0x30
  private           System.Single[]                 _temp2  // 0x38
  private           System.Single[]                 _temp3  // 0x40
  private           System.Single[]                 _temp4  // 0x48
  private           System.Single[]                 _yTemp  // 0x50
METHODS:
  System.Single get_Step()
  System.Void set_Step(System.Single value)
  System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function)
  System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut)
END_CLASS

CLASS: Dest.Math.QuadraticRoots
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Single                   X0  // 0x10
  public            System.Single                   X1  // 0x14
  public            System.Int32                    RootCount  // 0x18
METHODS:
  System.Single get_Item(System.Int32 rootIndex)
END_CLASS

CLASS: Dest.Math.CubicRoots
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.Single                   X0  // 0x10
  public            System.Single                   X1  // 0x14
  public            System.Single                   X2  // 0x18
  public            System.Int32                    RootCount  // 0x1C
METHODS:
  System.Single get_Item(System.Int32 rootIndex)
END_CLASS

CLASS: Dest.Math.QuarticRoots
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  public            System.Single                   X0  // 0x10
  public            System.Single                   X1  // 0x14
  public            System.Single                   X2  // 0x18
  public            System.Single                   X3  // 0x1C
  public            System.Int32                    RootCount  // 0x20
METHODS:
  System.Single get_Item(System.Int32 rootIndex)
END_CLASS

CLASS: Dest.Math.AAB2
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            UnityEngine.Vector2             Min  // 0x10
  public            UnityEngine.Vector2             Max  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Vector2& min, UnityEngine.Vector2& max)
  System.Void .ctor(UnityEngine.Vector2 min, UnityEngine.Vector2 max)
  System.Void .ctor(System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax)
  UnityEngine.Rect op_Implicit(Dest.Math.AAB2 value)
  Dest.Math.AAB2 op_Implicit(UnityEngine.Rect value)
  Dest.Math.AAB2 CreateFromPoint(UnityEngine.Vector2& point)
  Dest.Math.AAB2 CreateFromPoint(UnityEngine.Vector2 point)
  Dest.Math.AAB2 CreateFromTwoPoints(UnityEngine.Vector2& point0, UnityEngine.Vector2& point1)
  Dest.Math.AAB2 CreateFromTwoPoints(UnityEngine.Vector2 point0, UnityEngine.Vector2 point1)
  Dest.Math.AAB2 CreateFromPoints(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points)
  Dest.Math.AAB2 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  Dest.Math.AAB2 CreateFromPoints(UnityEngine.Vector2[] points)
  System.Void CalcCenterExtents(UnityEngine.Vector2& center, UnityEngine.Vector2& extents)
  System.Void CalcVertices(UnityEngine.Vector2& vertex0, UnityEngine.Vector2& vertex1, UnityEngine.Vector2& vertex2, UnityEngine.Vector2& vertex3)
  UnityEngine.Vector2[] CalcVertices()
  System.Void CalcVertices(UnityEngine.Vector2[] array)
  System.Single CalcArea()
  System.Single DistanceTo(UnityEngine.Vector2 point)
  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  System.Boolean Contains(UnityEngine.Vector2& point)
  System.Boolean Contains(UnityEngine.Vector2 point)
  System.Void Include(UnityEngine.Vector2& point)
  System.Void Include(UnityEngine.Vector2 point)
  System.Void Include(Dest.Math.AAB2& box)
  System.Void Include(Dest.Math.AAB2 box)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Box2
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  public            UnityEngine.Vector2             Center  // 0x10
  public            UnityEngine.Vector2             Axis0  // 0x18
  public            UnityEngine.Vector2             Axis1  // 0x20
  public            UnityEngine.Vector2             Extents  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& axis0, UnityEngine.Vector2& axis1, UnityEngine.Vector2& extents)
  System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 axis0, UnityEngine.Vector2 axis1, UnityEngine.Vector2 extents)
  System.Void .ctor(Dest.Math.AAB2& box)
  System.Void .ctor(Dest.Math.AAB2 box)
  Dest.Math.Box2 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  UnityEngine.Vector2 GetAxis(System.Int32 index)
  System.Void CalcVertices(UnityEngine.Vector2& vertex0, UnityEngine.Vector2& vertex1, UnityEngine.Vector2& vertex2, UnityEngine.Vector2& vertex3)
  UnityEngine.Vector2[] CalcVertices()
  System.Void CalcVertices(UnityEngine.Vector2[] array)
  System.Single CalcArea()
  System.Single DistanceTo(UnityEngine.Vector2 point)
  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  System.Boolean Contains(UnityEngine.Vector2& point)
  System.Boolean Contains(UnityEngine.Vector2 point)
  System.Void Include(Dest.Math.Box2& box)
  System.Void Include(Dest.Math.Box2 box)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Circle2
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            UnityEngine.Vector2             Center  // 0x10
  public            System.Single                   Radius  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Vector2& center, System.Single radius)
  System.Void .ctor(UnityEngine.Vector2 center, System.Single radius)
  Dest.Math.Circle2 CreateFromPointsAAB(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points)
  Dest.Math.Circle2 CreateFromPointsAAB(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  Dest.Math.Circle2 CreateFromPointsAverage(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points)
  Dest.Math.Circle2 CreateFromPointsAverage(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  System.Boolean CreateCircumscribed(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2, Dest.Math.Circle2& circle)
  System.Boolean CreateInscribed(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2, Dest.Math.Circle2& circle)
  System.Single CalcPerimeter()
  System.Single CalcArea()
  UnityEngine.Vector2 Eval(System.Single t)
  UnityEngine.Vector2 Eval(System.Single t, System.Single radius)
  System.Single DistanceTo(UnityEngine.Vector2 point)
  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  System.Boolean Contains(UnityEngine.Vector2& point)
  System.Boolean Contains(UnityEngine.Vector2 point)
  System.Void Include(Dest.Math.Circle2& circle)
  System.Void Include(Dest.Math.Circle2 circle)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Line2
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  public            UnityEngine.Vector2             Center  // 0x10
  public            UnityEngine.Vector2             Direction  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& direction)
  System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 direction)
  Dest.Math.Line2 CreateFromTwoPoints(UnityEngine.Vector2& p0, UnityEngine.Vector2& p1)
  Dest.Math.Line2 CreateFromTwoPoints(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1)
  Dest.Math.Line2 CreatePerpToLineTrhoughPoint(Dest.Math.Line2 line, UnityEngine.Vector2 point)
  Dest.Math.Line2 CreateBetweenAndEquidistantToPoints(UnityEngine.Vector2 point0, UnityEngine.Vector2 point1)
  Dest.Math.Line2 CreateParallelToGivenLineAtGivenDistance(Dest.Math.Line2 line, System.Single distance)
  UnityEngine.Vector2 Eval(System.Single t)
  System.Single SignedDistanceTo(UnityEngine.Vector2 point)
  System.Single DistanceTo(UnityEngine.Vector2 point)
  System.Int32 QuerySide(UnityEngine.Vector2 point, System.Single epsilon)
  System.Boolean QuerySideNegative(UnityEngine.Vector2 point, System.Single epsilon)
  System.Boolean QuerySidePositive(UnityEngine.Vector2 point, System.Single epsilon)
  System.Int32 QuerySide(Dest.Math.Box2& box, System.Single epsilon)
  System.Boolean QuerySideNegative(Dest.Math.Box2& box, System.Single epsilon)
  System.Boolean QuerySidePositive(Dest.Math.Box2& box, System.Single epsilon)
  System.Int32 QuerySide(Dest.Math.AAB2& box, System.Single epsilon)
  System.Boolean QuerySideNegative(Dest.Math.AAB2& box, System.Single epsilon)
  System.Boolean QuerySidePositive(Dest.Math.AAB2& box, System.Single epsilon)
  System.Int32 QuerySide(Dest.Math.Circle2& circle, System.Single epsilon)
  System.Boolean QuerySideNegative(Dest.Math.Circle2& circle, System.Single epsilon)
  System.Boolean QuerySidePositive(Dest.Math.Circle2& circle, System.Single epsilon)
  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  System.Single AngleBetweenTwoLines(Dest.Math.Line2 anotherLine, System.Boolean acuteAngleDesired)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Edge2
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            UnityEngine.Vector2             Point0  // 0x10
  public            UnityEngine.Vector2             Point1  // 0x18
  public            UnityEngine.Vector2             Direction  // 0x20
  public            UnityEngine.Vector2             Normal  // 0x28
  public            System.Single                   Length  // 0x30
METHODS:
END_CLASS

CLASS: Dest.Math.Polygon2
TYPE:  class
TOKEN: 0x200006D
FIELDS:
  private           UnityEngine.Vector2[]           _vertices  // 0x10
  private           Dest.Math.Edge2[]               _edges  // 0x18
METHODS:
  UnityEngine.Vector2[] get_Vertices()
  Dest.Math.Edge2[] get_Edges()
  System.Int32 get_VertexCount()
  UnityEngine.Vector2 get_Item(System.Int32 vertexIndex)
  System.Void set_Item(System.Int32 vertexIndex, UnityEngine.Vector2 value)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Vector2[] vertices)
  System.Void .ctor(System.Int32 vertexCount)
  Dest.Math.Polygon2 CreateProjected(Dest.Math.Polygon3 polygon, Dest.Math.ProjectionPlanes projectionPlane)
  Dest.Math.Edge2 GetEdge(System.Int32 edgeIndex)
  System.Void UpdateEdges()
  System.Void UpdateEdge(System.Int32 edgeIndex)
  UnityEngine.Vector2 CalcCenter()
  System.Single CalcPerimeter()
  System.Single CalcArea()
  System.Boolean IsConvex(Dest.Math.Orientations& orientation, System.Single threshold)
  System.Boolean IsConvex(System.Single threshold)
  System.Boolean HasZeroCorners(System.Single threshold)
  System.Void ReverseVertices()
  System.Boolean ContainsConvexQuadCCW(UnityEngine.Vector2& point)
  System.Boolean ContainsConvexQuadCCW(UnityEngine.Vector2 point)
  System.Boolean ContainsConvexQuadCW(UnityEngine.Vector2& point)
  System.Boolean ContainsConvexQuadCW(UnityEngine.Vector2 point)
  System.Boolean ContainsConvexCCW(UnityEngine.Vector2& point)
  System.Boolean ContainsConvexCCW(UnityEngine.Vector2 point)
  System.Boolean SubContainsPointCCW(UnityEngine.Vector2& p, System.Int32 i0, System.Int32 i1)
  System.Boolean ContainsConvexCW(UnityEngine.Vector2& point)
  System.Boolean ContainsConvexCW(UnityEngine.Vector2 point)
  System.Boolean SubContainsPointCW(UnityEngine.Vector2& p, System.Int32 i0, System.Int32 i1)
  System.Boolean ContainsSimple(UnityEngine.Vector2& point)
  System.Boolean ContainsSimple(UnityEngine.Vector2 point)
  Dest.Math.Segment2[] ToSegmentArray()
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Ray2
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            UnityEngine.Vector2             Center  // 0x10
  public            UnityEngine.Vector2             Direction  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& direction)
  System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 direction)
  UnityEngine.Vector2 Eval(System.Single t)
  System.Single DistanceTo(UnityEngine.Vector2 point)
  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Segment2
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            UnityEngine.Vector2             P0  // 0x10
  public            UnityEngine.Vector2             P1  // 0x18
  public            UnityEngine.Vector2             Center  // 0x20
  public            UnityEngine.Vector2             Direction  // 0x28
  public            System.Single                   Extent  // 0x30
METHODS:
  System.Void .ctor(UnityEngine.Vector2& p0, UnityEngine.Vector2& p1)
  System.Void .ctor(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1)
  System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& direction, System.Single extent)
  System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 direction, System.Single extent)
  System.Void SetEndpoints(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1)
  System.Void SetCenterDirectionExtent(UnityEngine.Vector2 center, UnityEngine.Vector2 direction, System.Single extent)
  System.Void CalcCenterDirectionExtent()
  System.Void CalcEndPoints()
  UnityEngine.Vector2 Eval(System.Single s)
  System.Single DistanceTo(UnityEngine.Vector2 point)
  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Triangle2
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            UnityEngine.Vector2             V0  // 0x10
  public            UnityEngine.Vector2             V1  // 0x18
  public            UnityEngine.Vector2             V2  // 0x20
METHODS:
  UnityEngine.Vector2 get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, UnityEngine.Vector2 value)
  System.Void .ctor(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  System.Void .ctor(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
  UnityEngine.Vector2 CalcEdge(System.Int32 edgeIndex)
  System.Single CalcDeterminant()
  Dest.Math.Orientations CalcOrientation(System.Single threshold)
  System.Single CalcArea()
  System.Single CalcArea(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  System.Single CalcArea(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
  UnityEngine.Vector3 CalcAnglesDeg()
  UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
  UnityEngine.Vector3 CalcAnglesRad()
  UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
  UnityEngine.Vector2 EvalBarycentric(System.Single c0, System.Single c1)
  UnityEngine.Vector2 EvalBarycentric(UnityEngine.Vector3& baryCoords)
  UnityEngine.Vector2 EvalBarycentric(UnityEngine.Vector3 baryCoords)
  System.Void CalcBarycentricCoords(UnityEngine.Vector2& point, UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2, UnityEngine.Vector3& baryCoords)
  UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector2& point)
  UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector2 point)
  System.Single DistanceTo(UnityEngine.Vector2 point)
  System.Int32 QuerySideCCW(UnityEngine.Vector2 point, System.Single epsilon)
  System.Int32 QuerySideCW(UnityEngine.Vector2 point, System.Single epsilon)
  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  System.Boolean Contains(UnityEngine.Vector2& point)
  System.Boolean Contains(UnityEngine.Vector2 point)
  System.Boolean ContainsCCW(UnityEngine.Vector2& point)
  System.Boolean ContainsCCW(UnityEngine.Vector2 point)
  System.Boolean ContainsCW(UnityEngine.Vector2& point)
  System.Boolean ContainsCW(UnityEngine.Vector2 point)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.AAB3
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            UnityEngine.Vector3             Min  // 0x10
  public            UnityEngine.Vector3             Max  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3& min, UnityEngine.Vector3& max)
  System.Void .ctor(UnityEngine.Vector3 min, UnityEngine.Vector3 max)
  System.Void .ctor(System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, System.Single zMin, System.Single zMax)
  UnityEngine.Bounds op_Implicit(Dest.Math.AAB3 value)
  Dest.Math.AAB3 op_Implicit(UnityEngine.Bounds value)
  Dest.Math.AAB3 CreateFromPoint(UnityEngine.Vector3& point)
  Dest.Math.AAB3 CreateFromPoint(UnityEngine.Vector3 point)
  Dest.Math.AAB3 CreateFromTwoPoints(UnityEngine.Vector3& point0, UnityEngine.Vector3& point1)
  Dest.Math.AAB3 CreateFromTwoPoints(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1)
  Dest.Math.AAB3 CreateFromPoints(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points)
  Dest.Math.AAB3 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  Dest.Math.AAB3 CreateFromPoints(UnityEngine.Vector3[] points)
  System.Void CalcCenterExtents(UnityEngine.Vector3& center, UnityEngine.Vector3& extents)
  System.Void CalcVertices(UnityEngine.Vector3& vertex0, UnityEngine.Vector3& vertex1, UnityEngine.Vector3& vertex2, UnityEngine.Vector3& vertex3, UnityEngine.Vector3& vertex4, UnityEngine.Vector3& vertex5, UnityEngine.Vector3& vertex6, UnityEngine.Vector3& vertex7)
  UnityEngine.Vector3[] CalcVertices()
  System.Void CalcVertices(UnityEngine.Vector3[] array)
  System.Single CalcVolume()
  System.Single DistanceTo(UnityEngine.Vector3 point)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  System.Boolean Contains(UnityEngine.Vector3& point)
  System.Boolean Contains(UnityEngine.Vector3 point)
  System.Void Include(UnityEngine.Vector3& point)
  System.Void Include(UnityEngine.Vector3 point)
  System.Void Include(Dest.Math.AAB3& box)
  System.Void Include(Dest.Math.AAB3 box)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Box3
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Axis0  // 0x1C
  public            UnityEngine.Vector3             Axis1  // 0x28
  public            UnityEngine.Vector3             Axis2  // 0x34
  public            UnityEngine.Vector3             Extents  // 0x40
METHODS:
  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& axis0, UnityEngine.Vector3& axis1, UnityEngine.Vector3& axis2, UnityEngine.Vector3& extents)
  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 axis0, UnityEngine.Vector3 axis1, UnityEngine.Vector3 axis2, UnityEngine.Vector3 extents)
  System.Void .ctor(Dest.Math.AAB3& box)
  System.Void .ctor(Dest.Math.AAB3 box)
  Dest.Math.Box3 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  UnityEngine.Vector3 GetAxis(System.Int32 index)
  System.Void CalcVertices(UnityEngine.Vector3& vertex0, UnityEngine.Vector3& vertex1, UnityEngine.Vector3& vertex2, UnityEngine.Vector3& vertex3, UnityEngine.Vector3& vertex4, UnityEngine.Vector3& vertex5, UnityEngine.Vector3& vertex6, UnityEngine.Vector3& vertex7)
  UnityEngine.Vector3[] CalcVertices()
  System.Void CalcVertices(UnityEngine.Vector3[] array)
  System.Single CalcVolume()
  System.Single DistanceTo(UnityEngine.Vector3 point)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  System.Boolean Contains(UnityEngine.Vector3& point)
  System.Boolean Contains(UnityEngine.Vector3 point)
  System.Void Include(Dest.Math.Box3& box)
  System.Void Include(Dest.Math.Box3 box)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Capsule3
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            Dest.Math.Segment3              Segment  // 0x10
  public            System.Single                   Radius  // 0x44
METHODS:
  System.Void .ctor(Dest.Math.Segment3& segment, System.Single radius)
  System.Void .ctor(Dest.Math.Segment3 segment, System.Single radius)
END_CLASS

CLASS: Dest.Math.Circle3
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Axis0  // 0x1C
  public            UnityEngine.Vector3             Axis1  // 0x28
  public            UnityEngine.Vector3             Normal  // 0x34
  public            System.Single                   Radius  // 0x40
METHODS:
  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& axis0, UnityEngine.Vector3& axis1, System.Single radius)
  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 axis0, UnityEngine.Vector3 axis1, System.Single radius)
  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& normal, System.Single radius)
  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 normal, System.Single radius)
  System.Boolean CreateCircumscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Circle3& circle)
  System.Boolean CreateInscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Circle3& circle)
  System.Single CalcPerimeter()
  System.Single CalcArea()
  UnityEngine.Vector3 Eval(System.Single t)
  UnityEngine.Vector3 Eval(System.Single t, System.Single radius)
  System.Single DistanceTo(UnityEngine.Vector3 point, System.Boolean solid)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 point, System.Boolean solid)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Line3
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Direction  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& direction)
  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 direction)
  Dest.Math.Line3 CreateFromTwoPoints(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1)
  Dest.Math.Line3 CreateFromTwoPoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1)
  UnityEngine.Vector3 Eval(System.Single t)
  System.Single DistanceTo(UnityEngine.Vector3 point)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  System.Single AngleBetweenTwoLines(Dest.Math.Line3 anotherLine, System.Boolean acuteAngleDesired)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Plane3
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            UnityEngine.Vector3             Normal  // 0x10
  public            System.Single                   Constant  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3& normal, System.Single constant)
  System.Void .ctor(UnityEngine.Vector3 normal, System.Single constant)
  System.Void .ctor(UnityEngine.Vector3& normal, UnityEngine.Vector3& point)
  System.Void .ctor(UnityEngine.Vector3 normal, UnityEngine.Vector3 point)
  System.Void .ctor(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, UnityEngine.Vector3& p2)
  System.Void .ctor(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
  UnityEngine.Plane op_Implicit(Dest.Math.Plane3 value)
  Dest.Math.Plane3 op_Implicit(UnityEngine.Plane value)
  UnityEngine.Vector3 CalcOrigin()
  System.Void CreateOrthonormalBasis(UnityEngine.Vector3& u, UnityEngine.Vector3& v, UnityEngine.Vector3& n)
  System.Single SignedDistanceTo(UnityEngine.Vector3& point)
  System.Single SignedDistanceTo(UnityEngine.Vector3 point)
  System.Single DistanceTo(UnityEngine.Vector3 point)
  System.Int32 QuerySide(UnityEngine.Vector3 point, System.Single epsilon)
  System.Boolean QuerySideNegative(UnityEngine.Vector3 point, System.Single epsilon)
  System.Boolean QuerySidePositive(UnityEngine.Vector3 point, System.Single epsilon)
  System.Int32 QuerySide(Dest.Math.Box3& box, System.Single epsilon)
  System.Boolean QuerySideNegative(Dest.Math.Box3& box, System.Single epsilon)
  System.Boolean QuerySidePositive(Dest.Math.Box3& box, System.Single epsilon)
  System.Int32 QuerySide(Dest.Math.AAB3& box, System.Single epsilon)
  System.Boolean QuerySideNegative(Dest.Math.AAB3& box, System.Single epsilon)
  System.Boolean QuerySidePositive(Dest.Math.AAB3& box, System.Single epsilon)
  System.Int32 QuerySide(Dest.Math.Sphere3& sphere, System.Single epsilon)
  System.Boolean QuerySideNegative(Dest.Math.Sphere3& sphere, System.Single epsilon)
  System.Boolean QuerySidePositive(Dest.Math.Sphere3& sphere, System.Single epsilon)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  UnityEngine.Vector3 ProjectVector(UnityEngine.Vector3 vector)
  System.Single AngleBetweenPlaneNormalAndLine(Dest.Math.Line3 line)
  System.Single AngleBetweenPlaneNormalAndLine(UnityEngine.Vector3 direction)
  System.Single AngleBetweenPlaneAndLine(Dest.Math.Line3 line)
  System.Single AngleBetweenPlaneAndLine(UnityEngine.Vector3 direction)
  System.Single AngleBetweenTwoPlanes(Dest.Math.Plane3 anotherPlane)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Edge3
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            UnityEngine.Vector3             Point0  // 0x10
  public            UnityEngine.Vector3             Point1  // 0x1C
  public            UnityEngine.Vector3             Direction  // 0x28
  public            UnityEngine.Vector3             Normal  // 0x34
  public            System.Single                   Length  // 0x40
METHODS:
END_CLASS

CLASS: Dest.Math.Polygon3
TYPE:  class
TOKEN: 0x2000078
FIELDS:
  private           UnityEngine.Vector3[]           _vertices  // 0x10
  private           Dest.Math.Edge3[]               _edges  // 0x18
  private           Dest.Math.Plane3                _plane  // 0x20
METHODS:
  UnityEngine.Vector3[] get_Vertices()
  Dest.Math.Edge3[] get_Edges()
  System.Int32 get_VertexCount()
  UnityEngine.Vector3 get_Item(System.Int32 vertexIndex)
  System.Void set_Item(System.Int32 vertexIndex, UnityEngine.Vector3 value)
  Dest.Math.Plane3 get_Plane()
  System.Void set_Plane(Dest.Math.Plane3 value)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Vector3[] vertices, Dest.Math.Plane3 plane)
  System.Void .ctor(System.Int32 vertexCount, Dest.Math.Plane3 plane)
  System.Void SetVertexProjected(System.Int32 vertexIndex, UnityEngine.Vector3 vertex)
  System.Void ProjectVertices()
  Dest.Math.Edge3 GetEdge(System.Int32 edgeIndex)
  System.Void UpdateEdges()
  System.Void UpdateEdge(System.Int32 edgeIndex)
  UnityEngine.Vector3 CalcCenter()
  System.Single CalcPerimeter()
  System.Boolean HasZeroCorners(System.Single threshold)
  System.Void ReverseVertices()
  Dest.Math.Segment3[] ToSegmentArray()
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Ray3
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Direction  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& direction)
  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 direction)
  UnityEngine.Ray op_Implicit(Dest.Math.Ray3 value)
  Dest.Math.Ray3 op_Implicit(UnityEngine.Ray value)
  UnityEngine.Vector3 Eval(System.Single t)
  System.Single DistanceTo(UnityEngine.Vector3 point)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Rectangle3
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Axis0  // 0x1C
  public            UnityEngine.Vector3             Axis1  // 0x28
  public            UnityEngine.Vector3             Normal  // 0x34
  public            UnityEngine.Vector2             Extents  // 0x40
METHODS:
  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& axis0, UnityEngine.Vector3& axis1, UnityEngine.Vector2& extents)
  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 axis0, UnityEngine.Vector3 axis1, UnityEngine.Vector2 extents)
  Dest.Math.Rectangle3 CreateFromCCWPoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
  Dest.Math.Rectangle3 CreateFromCWPoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
  System.Void CalcVertices(UnityEngine.Vector3& vertex0, UnityEngine.Vector3& vertex1, UnityEngine.Vector3& vertex2, UnityEngine.Vector3& vertex3)
  UnityEngine.Vector3[] CalcVertices()
  System.Void CalcVertices(UnityEngine.Vector3[] array)
  System.Single CalcArea()
  System.Single DistanceTo(UnityEngine.Vector3 point)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Segment3
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            UnityEngine.Vector3             P0  // 0x10
  public            UnityEngine.Vector3             P1  // 0x1C
  public            UnityEngine.Vector3             Center  // 0x28
  public            UnityEngine.Vector3             Direction  // 0x34
  public            System.Single                   Extent  // 0x40
METHODS:
  System.Void .ctor(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1)
  System.Void .ctor(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1)
  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& direction, System.Single extent)
  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 direction, System.Single extent)
  System.Void SetEndpoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1)
  System.Void SetCenterDirectionExtent(UnityEngine.Vector3 center, UnityEngine.Vector3 direction, System.Single extent)
  System.Void CalcCenterDirectionExtent()
  System.Void CalcEndPoints()
  UnityEngine.Vector3 Eval(System.Single s)
  System.Single DistanceTo(UnityEngine.Vector3 point)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Sphere3
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  private   static  System.Single                   _4div3mulPi  // 0x0
  public            UnityEngine.Vector3             Center  // 0x10
  public            System.Single                   Radius  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3& center, System.Single radius)
  System.Void .ctor(UnityEngine.Vector3 center, System.Single radius)
  Dest.Math.Sphere3 CreateFromPointsAAB(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points)
  Dest.Math.Sphere3 CreateFromPointsAAB(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  Dest.Math.Sphere3 CreateFromPointsAverage(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points)
  Dest.Math.Sphere3 CreateFromPointsAverage(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  System.Boolean CreateCircumscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 v3, Dest.Math.Sphere3& sphere)
  System.Boolean CreateInscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 v3, Dest.Math.Sphere3& sphere)
  System.Single CalcArea()
  System.Single CalcVolume()
  UnityEngine.Vector3 Eval(System.Single theta, System.Single phi)
  System.Single DistanceTo(UnityEngine.Vector3 point)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  System.Boolean Contains(UnityEngine.Vector3& point)
  System.Boolean Contains(UnityEngine.Vector3 point)
  System.Void Include(Dest.Math.Sphere3& sphere)
  System.Void Include(Dest.Math.Sphere3 sphere)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Triangle3
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            UnityEngine.Vector3             V0  // 0x10
  public            UnityEngine.Vector3             V1  // 0x1C
  public            UnityEngine.Vector3             V2  // 0x28
METHODS:
  UnityEngine.Vector3 get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, UnityEngine.Vector3 value)
  System.Void .ctor(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  System.Void .ctor(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  UnityEngine.Vector3 CalcEdge(System.Int32 edgeIndex)
  UnityEngine.Vector3 CalcNormal()
  System.Single CalcArea()
  System.Single CalcArea(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  System.Single CalcArea(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  UnityEngine.Vector3 CalcAnglesDeg()
  UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  UnityEngine.Vector3 CalcAnglesRad()
  UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  UnityEngine.Vector3 EvalBarycentric(System.Single c0, System.Single c1)
  UnityEngine.Vector3 EvalBarycentric(UnityEngine.Vector3& baryCoords)
  UnityEngine.Vector3 EvalBarycentric(UnityEngine.Vector3 baryCoords)
  System.Void CalcBarycentricCoords(UnityEngine.Vector3& point, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, UnityEngine.Vector3& baryCoords)
  UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector3& point)
  UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector3 point)
  System.String ToString()
END_CLASS

CLASS: Dest.Math.Orientations
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.Orientations          CW  // 0x0
  public    static  Dest.Math.Orientations          CCW  // 0x0
  public    static  Dest.Math.Orientations          None  // 0x0
METHODS:
END_CLASS

CLASS: Dest.Math.Query2
TYPE:  class
TOKEN: 0x200007F
EXTENDS: Query
FIELDS:
  private   static  System.Single                   Zero  // 0x0
  private           UnityEngine.Vector2[]           _vertices  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Vector2[] vertices)
  System.Int32 ToLine(System.Int32 i, System.Int32 v0, System.Int32 v1)
  System.Int32 ToLine(UnityEngine.Vector2& test, System.Int32 v0, System.Int32 v1)
  System.Int32 ToTriangle(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  System.Int32 ToTriangle(UnityEngine.Vector2& test, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  System.Int32 ToCircumcircle(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  System.Int32 ToCircumcircle(UnityEngine.Vector2& test, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  System.Single Dot(System.Single x0, System.Single y0, System.Single x1, System.Single y1)
  System.Single Det2(System.Single x0, System.Single y0, System.Single x1, System.Single y1)
  System.Single Det3(System.Single x0, System.Single y0, System.Single z0, System.Single x1, System.Single y1, System.Single z1, System.Single x2, System.Single y2, System.Single z2)
END_CLASS

CLASS: Dest.Math.Query3
TYPE:  class
TOKEN: 0x2000080
EXTENDS: Query
FIELDS:
  private   static  System.Single                   Zero  // 0x0
  private           UnityEngine.Vector3[]           _vertices  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Vector3[] vertices)
  System.Int32 ToPlane(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  System.Int32 ToPlane(UnityEngine.Vector3& test, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  System.Int32 ToTetrahedron(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  System.Int32 ToTetrahedron(UnityEngine.Vector3& test, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  System.Int32 ToCircumsphere(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  System.Int32 ToCircumsphere(UnityEngine.Vector3& test, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  System.Single Dot(System.Single x0, System.Single y0, System.Single z0, System.Single x1, System.Single y1, System.Single z1)
  System.Single Det3(System.Single x0, System.Single y0, System.Single z0, System.Single x1, System.Single y1, System.Single z1, System.Single x2, System.Single y2, System.Single z2)
  System.Single Det4(System.Single x0, System.Single y0, System.Single z0, System.Single w0, System.Single x1, System.Single y1, System.Single z1, System.Single w1, System.Single x2, System.Single y2, System.Single z2, System.Single w2, System.Single x3, System.Single y3, System.Single z3, System.Single w3)
END_CLASS

CLASS: Dest.Math.QueryTypes
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.QueryTypes            Int64  // 0x0
  public    static  Dest.Math.QueryTypes            Integer  // 0x0
  public    static  Dest.Math.QueryTypes            Rational  // 0x0
  public    static  Dest.Math.QueryTypes            Real  // 0x0
  public    static  Dest.Math.QueryTypes            Filtered  // 0x0
METHODS:
END_CLASS

CLASS: Dest.Math.Query
TYPE:  class
TOKEN: 0x2000082
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean Sort(System.Int32& v0, System.Int32& v1)
  System.Boolean Sort(System.Int32& v0, System.Int32& v1, System.Int32& v2)
  System.Boolean Sort(System.Int32& v0, System.Int32& v1, System.Int32& v2, System.Int32& v3)
END_CLASS

CLASS: Dest.Math.CatmullRomSpline3
TYPE:  class
TOKEN: 0x2000083
EXTENDS: SplineBase
FIELDS:
METHODS:
  Dest.Math.SplineTypes get_SplineType()
  System.Void set_SplineType(Dest.Math.SplineTypes value)
  Dest.Math.CatmullRomSpline3 Create()
  Dest.Math.CatmullRomSpline3 Create(System.Collections.Generic.IList<UnityEngine.Vector3> points, Dest.Math.SplineTypes type)
  System.Void UpdateSegment(System.Int32 index)
  System.Void UpdateAdjacentSegments(System.Int32 vertexIndex)
  System.Void AddVertexFirst(UnityEngine.Vector3 position)
  System.Void AddVertexLast(UnityEngine.Vector3 position)
  System.Void RemoveVertex(System.Int32 index)
  System.Void Clear()
  System.Void InsertBefore(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  System.Void InsertAfter(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  UnityEngine.Vector3 GetVertex(System.Int32 vertexIndex)
  System.Void SetVertex(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.CubicSpline3
TYPE:  class
TOKEN: 0x2000084
EXTENDS: SplineBase
FIELDS:
METHODS:
  Dest.Math.SplineTypes get_SplineType()
  System.Void set_SplineType(Dest.Math.SplineTypes value)
  Dest.Math.CubicSpline3 Create()
  Dest.Math.CubicSpline3 Create(System.Collections.Generic.IList<UnityEngine.Vector3> points, Dest.Math.SplineTypes type)
  System.Void BuildSpline()
  System.Void CreateOpenedSpline()
  System.Void CreateClosedSpline()
  System.Void AddVertexFirst(UnityEngine.Vector3 position)
  System.Void AddVertexLast(UnityEngine.Vector3 position)
  System.Void RemoveVertex(System.Int32 index)
  System.Void Clear()
  System.Void InsertBefore(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  System.Void InsertAfter(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  UnityEngine.Vector3 GetVertex(System.Int32 vertexIndex)
  System.Void SetVertex(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.SplineTypes
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.SplineTypes           Open  // 0x0
  public    static  Dest.Math.SplineTypes           Closed  // 0x0
METHODS:
END_CLASS

CLASS: Dest.Math.SplinePlaneTypes
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.SplinePlaneTypes      XZ  // 0x0
  public    static  Dest.Math.SplinePlaneTypes      XY  // 0x0
  public    static  Dest.Math.SplinePlaneTypes      YZ  // 0x0
METHODS:
END_CLASS

CLASS: Dest.Math.PositionTangent
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            UnityEngine.Vector3             Position  // 0x10
  public            UnityEngine.Vector3             Tangent  // 0x1C
METHODS:
END_CLASS

CLASS: Dest.Math.CurveFrame
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            UnityEngine.Vector3             Position  // 0x10
  public            UnityEngine.Vector3             Tangent  // 0x1C
  public            UnityEngine.Vector3             Normal  // 0x28
  public            UnityEngine.Vector3             Binormal  // 0x34
METHODS:
END_CLASS

CLASS: Dest.Math.SplineBase
TYPE:  class
TOKEN: 0x2000089
EXTENDS: MonoBehaviour
FIELDS:
  protected         Dest.Math.SplineBase.ArcLengthParametrization_parametrization  // 0x18
  protected         System.Collections.Generic.List<Dest.Math.SplineBase.ItemData>_data  // 0x20
  protected         Dest.Math.SplineTypes           _type  // 0x28
  protected         System.Boolean                  _recalcSegmentsLength  // 0x2C
  protected         UnityEngine.Color               _renderColor  // 0x30
  protected         Dest.Math.SplinePlaneTypes      _creationPlane  // 0x40
METHODS:
  System.Int32 get_SegmentCount()
  System.Int32 get_VertexCount()
  System.Boolean get_Valid()
  Dest.Math.SplineTypes get_SplineType()
  System.Void set_SplineType(Dest.Math.SplineTypes value)
  System.Void Awake()
  System.Void .ctor()
  System.Void GetSegmentIndexAndTime(System.Single time, System.Int32& segmentIndex, System.Single& segmentTime)
  System.Void PrepareForRuntime()
  System.Void RecalcSegmentsLength()
  System.Void AddVertexFirst(UnityEngine.Vector3 position)
  System.Void AddVertexLast(UnityEngine.Vector3 position)
  System.Void RemoveVertex(System.Int32 index)
  System.Void Clear()
  System.Void InsertBefore(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  System.Void InsertAfter(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  UnityEngine.Vector3 GetVertex(System.Int32 vertexIndex)
  System.Void SetVertex(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  UnityEngine.Vector3 EvalPosition(System.Single time)
  UnityEngine.Vector3 EvalTangent(System.Single time)
  Dest.Math.PositionTangent EvalPositionTangent(System.Single time)
  System.Void EvalPosition(System.Single time, UnityEngine.Vector3& position)
  System.Void EvalTangent(System.Single time, UnityEngine.Vector3& tangent)
  System.Void EvalPositionTangent(System.Single time, Dest.Math.PositionTangent& positionTangent)
  System.Void EvalFrame(System.Single time, Dest.Math.CurveFrame& frame)
  System.Single EvalCurvature(System.Single time)
  System.Single EvalTorsion(System.Single time)
  UnityEngine.Vector3 EvalPositionParametrized(System.Single length)
  UnityEngine.Vector3 EvalTangentParametrized(System.Single length)
  Dest.Math.PositionTangent EvalPositionTangentParametrized(System.Single length)
  System.Void EvalPositionParametrized(System.Single length, UnityEngine.Vector3& position)
  System.Void EvalTangentParametrized(System.Single length, UnityEngine.Vector3& tangent)
  System.Void EvalPositionTangentParametrized(System.Single length, Dest.Math.PositionTangent& positionTangent)
  System.Void EvalFrameParametrized(System.Single length, Dest.Math.CurveFrame& frame)
  System.Single EvalCurvatureParametrized(System.Single length)
  System.Single EvalTorsionParametrized(System.Single length)
  System.Single CalcTotalLength()
  System.Single LengthToTime(System.Single length, System.Int32 iterations, System.Single tolerance)
  System.Single LengthToTime(System.Single length)
  System.Single ParametrizeByArcLength(System.Int32 pointCount)
END_CLASS

CLASS: Dest.Math.PointsFilter
TYPE:  class
TOKEN: 0x200008C
FIELDS:
METHODS:
  System.Collections.Generic.List<System.Int32> DistanceFilter(UnityEngine.Vector3[] points, Dest.Math.AAB3 pointsAAB, System.Single radius, Dest.Math.Rand rand)
END_CLASS

CLASS: Dest.Math.PoissonDiskSampler
TYPE:  class
TOKEN: 0x200008E
FIELDS:
  private   static readonly System.Single                   one_div_sqrtTwo  // 0x0
  private           Dest.Math.Rand                  _rand  // 0x10
  private           System.Collections.Generic.List<System.Int32>_activeList  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Vector2>_points  // 0x20
  private           System.Nullable<System.Int32>[,]_grid  // 0x28
  private           System.Single                   _r  // 0x30
  private           System.Single                   _rSquared  // 0x34
  private           System.Single                   _rTwo  // 0x38
  private           System.Single                   _rMin  // 0x3C
  private           UnityEngine.Vector2             _min  // 0x40
  private           UnityEngine.Vector2             _max  // 0x48
  private           UnityEngine.Vector2             _size  // 0x50
  private           System.Single                   _cellSize  // 0x58
  private           System.Int32                    _cellsX  // 0x5C
  private           System.Int32                    _cellsY  // 0x60
  public            Dest.Math.PoissonDiskSampler.PointDelegateDistanceFilter  // 0x68
  public            System.Int32                    PointsPerStep  // 0x70
  private           System.Int32                    <MaxPoints>k__BackingField  // 0x74
METHODS:
  System.Int32 get_MaxPoints()
  System.Void set_MaxPoints(System.Int32 value)
  System.Void .cctor()
  System.Void .ctor(Dest.Math.Rand rand, UnityEngine.Vector2 minCorner, UnityEngine.Vector2 maxCorner, System.Single minDistanceOuter, System.Single minDistanceInner)
  System.Void CalcGridIndices(UnityEngine.Vector2& point, System.Int32& i, System.Int32& j)
  System.Void InsertIntoGrid(UnityEngine.Vector2& point, System.Int32 index)
  System.Boolean AddPoint(UnityEngine.Vector2& center)
  System.Collections.Generic.List<UnityEngine.Vector2> Sample()
END_CLASS

CLASS: Dest.Math.WeightedSampler
TYPE:  class
TOKEN: 0x2000090
FIELDS:
  protected         System.Single[]                 _accum  // 0x10
  protected         System.Single                   _total  // 0x18
  protected         Dest.Math.Rand                  _rand  // 0x20
METHODS:
  System.Void .ctor(Dest.Math.Rand rand)
  System.Int32 BinarySearch(System.Single[] array, System.Single value)
  System.Void .ctor(System.Single[] weights)
  System.Void .ctor(System.Single[] weights, Dest.Math.Rand rand)
  System.Void Init(System.Single[] weights)
  System.Int32 SampleIndex()
END_CLASS

CLASS: Dest.Math.TrianglesSamplerBase
TYPE:  class
TOKEN: 0x2000091
EXTENDS: WeightedSampler
FIELDS:
  protected         UnityEngine.Vector3[]           _vertices  // 0x28
METHODS:
  System.Void .ctor(Dest.Math.Rand rand)
  System.Single CalclTriangleArea(UnityEngine.Vector3& e0, UnityEngine.Vector3& e1)
END_CLASS

CLASS: Dest.Math.IndexedTrianglesSampler
TYPE:  class
TOKEN: 0x2000092
EXTENDS: TrianglesSamplerBase
FIELDS:
  protected         System.Int32[]                  _indices  // 0x30
METHODS:
  System.Void .ctor(UnityEngine.Vector3[] vertices, System.Int32[] indices)
  System.Void .ctor(UnityEngine.Vector3[] vertices, System.Int32[] indices, Dest.Math.Rand rand)
  System.Void .ctor(UnityEngine.Mesh mesh)
  System.Void .ctor(UnityEngine.Mesh mesh, Dest.Math.Rand rand)
  System.Void Init()
  UnityEngine.Vector3 Sample()
  UnityEngine.Vector3[] SampleArray(System.Int32 count)
  UnityEngine.Vector3[] SampleArray(System.Int32 count, UnityEngine.Vector2[] uvs, UnityEngine.Texture2D sampleMap, System.Single min, System.Single max)
END_CLASS

CLASS: Dest.Math.NonIndexedTrianglesSampler
TYPE:  class
TOKEN: 0x2000093
EXTENDS: TrianglesSamplerBase
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Vector3[] vertices)
  System.Void .ctor(UnityEngine.Vector3[] vertices, Dest.Math.Rand rand)
  System.Void .ctor(UnityEngine.Mesh mesh)
  System.Void .ctor(UnityEngine.Mesh mesh, Dest.Math.Rand rand)
  System.Void Init()
  UnityEngine.Vector3 Sample()
  UnityEngine.Vector3[] SampleArray(System.Int32 count)
END_CLASS

CLASS: Dest.Math.ShuffleBag`1
TYPE:  class
TOKEN: 0x2000094
FIELDS:
  private           Dest.Math.Rand                  _rand  // 0x0
  private           System.Collections.Generic.List<T>_items  // 0x0
  private           System.Int32                    _index  // 0x0
METHODS:
  System.Int32 get_Count()
  System.Void .ctor()
  System.Void .ctor(System.Int32 capacity)
  System.Void .ctor(Dest.Math.Rand rand)
  System.Void .ctor(Dest.Math.Rand rand, System.Int32 capacity)
  System.Void Add(T item, System.UInt32 count)
  T NextItem()
  System.Void Reset()
  System.Void Clear()
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Dest.Math.Util
TYPE:  class
TOKEN: 0x2000096
FIELDS:
METHODS:
  System.Void Shuffle(System.Collections.Generic.IList<T> collection)
  System.Void Shuffle(System.Collections.Generic.IList<T> collection, Dest.Math.Rand rand)
  System.Void Shuffle(T[] collection)
  System.Void Shuffle(T[] collection, Dest.Math.Rand rand)
END_CLASS

