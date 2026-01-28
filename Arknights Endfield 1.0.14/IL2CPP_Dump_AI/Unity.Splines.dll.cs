// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Splines.dll
// Classes:  37
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: FrenetFrame
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            Unity.Mathematics.float3        origin  // 0x10
  public            Unity.Mathematics.float3        tangent  // 0x1C
  public            Unity.Mathematics.float3        normal  // 0x28
  public            Unity.Mathematics.float3        binormal  // 0x34
METHODS:
END_CLASS

CLASS: KnotLink
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  public            UnityEngine.Splines.SplineKnotIndex[]Knots  // 0x10
METHODS:
  System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineKnotIndex> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 get_Count()
  UnityEngine.Splines.SplineKnotIndex get_Item(System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: Slice`1
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  private           Unity.Collections.NativeSlice<T>m_Slice  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.NativeArray<T> array, System.Int32 start, System.Int32 count)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 get_Count()
  T get_Item(System.Int32 index)
END_CLASS

CLASS: MetaData
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  public            UnityEngine.Splines.TangentMode Mode  // 0x10
  public            System.Single                   Tension  // 0x14
  private           UnityEngine.Splines.DistanceToInterpolation[]m_DistanceToInterpolation  // 0x18
METHODS:
  UnityEngine.Splines.DistanceToInterpolation[] get_DistanceToInterpolation()
  System.Void .ctor()
  System.Void InvalidateCache()
END_CLASS

CLASS: Segment
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Single                   start  // 0x10
  public            System.Single                   length  // 0x14
METHODS:
  System.Void .ctor(System.Single start, System.Single length)
END_CLASS

CLASS: UnityEngine.Splines.ArrayUtility
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Void RemoveAt(T[]& array, System.Int32 index)
  System.Void Remove(T[]& array, T element)
END_CLASS

CLASS: UnityEngine.Splines.BezierCurve
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            Unity.Mathematics.float3        P0  // 0x10
  public            Unity.Mathematics.float3        P1  // 0x1C
  public            Unity.Mathematics.float3        P2  // 0x28
  public            Unity.Mathematics.float3        P3  // 0x34
METHODS:
  System.Void .ctor(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 p3)
  System.Void .ctor(UnityEngine.Splines.BezierKnot a, UnityEngine.Splines.BezierKnot b)
  System.Boolean Equals(UnityEngine.Splines.BezierCurve other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Splines.BezierKnot
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            Unity.Mathematics.float3        Position  // 0x10
  public            Unity.Mathematics.float3        TangentIn  // 0x1C
  public            Unity.Mathematics.float3        TangentOut  // 0x28
  public            Unity.Mathematics.quaternion    Rotation  // 0x34
  public            System.Single                   Width  // 0x44
METHODS:
  System.Void .ctor(Unity.Mathematics.float3 position)
  System.Void .ctor(Unity.Mathematics.float3 position, Unity.Mathematics.float3 tangentIn, Unity.Mathematics.float3 tangentOut, Unity.Mathematics.quaternion rotation, System.Single width)
  UnityEngine.Splines.BezierKnot Transform(Unity.Mathematics.float4x4 matrix)
  UnityEngine.Splines.BezierKnot BakeTangentDirectionToRotation(System.Boolean mirrored, UnityEngine.Splines.BezierTangent main)
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.String ToString()
  System.Boolean Equals(UnityEngine.Splines.BezierKnot other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Splines.TangentMode
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Splines.TangentMode AutoSmooth  // 0x0
  public    static  UnityEngine.Splines.TangentMode Linear  // 0x0
  public    static  UnityEngine.Splines.TangentMode Mirrored  // 0x0
  public    static  UnityEngine.Splines.TangentMode Continuous  // 0x0
  public    static  UnityEngine.Splines.TangentMode Broken  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Splines.BezierTangent
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Splines.BezierTangentIn  // 0x0
  public    static  UnityEngine.Splines.BezierTangentOut  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Splines.CurveUtility
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static readonly UnityEngine.Splines.DistanceToInterpolation[]k_DistanceLUT  // 0x0
METHODS:
  Unity.Mathematics.float3 EvaluatePosition(UnityEngine.Splines.BezierCurve curve, System.Single t)
  Unity.Mathematics.float3 EvaluateTangent(UnityEngine.Splines.BezierCurve curve, System.Single t)
  Unity.Mathematics.float3 EvaluateAcceleration(UnityEngine.Splines.BezierCurve curve, System.Single t)
  System.Void CalculateCurveLengths(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.DistanceToInterpolation[] lookupTable)
  System.Boolean Approximately(System.Single a, System.Single b)
  Unity.Mathematics.float3 EvaluateUpVector(UnityEngine.Splines.BezierCurve curve, System.Single t, Unity.Mathematics.float3 startUp, Unity.Mathematics.float3 endUp)
  UnityEngine.Splines.CurveUtility.FrenetFrame GetNextRotationMinimizingFrame(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.CurveUtility.FrenetFrame previousRMFrame, System.Single nextRMFrameT)
  System.Single GetDistanceToInterpolation(T lut, System.Single distance)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Splines.IDataPoint
TYPE:  interface
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Single get_Index()
END_CLASS

CLASS: UnityEngine.Splines.DataPoint`1
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  private           System.Single                   m_Index  // 0x0
  private           TDataType                       m_Value  // 0x0
METHODS:
  System.Single get_Index()
  System.Void set_Index(System.Single value)
  TDataType get_Value()
  System.Int32 CompareTo(UnityEngine.Splines.DataPoint<TDataType> other)
  System.Int32 CompareTo(System.Single other)
  System.String ToString()
END_CLASS

CLASS: UnityEngine.Splines.DataPointComparer`1
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  System.Int32 Compare(T x, T y)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Splines.DistanceToInterpolation
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Single                   Distance  // 0x10
  public            System.Single                   T  // 0x14
  private   static readonly UnityEngine.Splines.DistanceToInterpolationInvalid  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Splines.IHasEmptyCurves
TYPE:  interface
TOKEN: 0x200000D
FIELDS:
METHODS:
  System.Collections.Generic.IReadOnlyList<System.Int32> get_EmptyCurves()
END_CLASS

CLASS: UnityEngine.Splines.ISpline
TYPE:  interface
TOKEN: 0x200000E
FIELDS:
METHODS:
  System.Boolean get_Closed()
  System.Single GetLength()
  UnityEngine.Splines.BezierCurve GetCurve(System.Int32 index)
  System.Single GetCurveLength(System.Int32 index)
  System.Single GetCurveInterpolation(System.Int32 curveIndex, System.Single curveDistance)
END_CLASS

CLASS: UnityEngine.Splines.ISplineContainer
TYPE:  interface
TOKEN: 0x200000F
FIELDS:
METHODS:
  System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> get_Splines()
  UnityEngine.Splines.KnotLinkCollection get_KnotLinkCollection()
END_CLASS

CLASS: UnityEngine.Splines.KnotLinkCollection
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private           UnityEngine.Splines.KnotLinkCollection.KnotLink[]m_KnotsLink  // 0x10
METHODS:
  UnityEngine.Splines.KnotLinkCollection.KnotLink GetKnotLinksInternal(UnityEngine.Splines.SplineKnotIndex index)
  System.Boolean TryGetKnotLinks(UnityEngine.Splines.SplineKnotIndex knotIndex, System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex>& linkedKnots)
  System.Void Unlink(UnityEngine.Splines.SplineKnotIndex knot)
  System.Void KnotRemoved(System.Int32 splineIndex, System.Int32 knotIndex)
  System.Void KnotRemoved(UnityEngine.Splines.SplineKnotIndex index)
  System.Void KnotInserted(System.Int32 splineIndex, System.Int32 knotIndex)
  System.Void KnotInserted(UnityEngine.Splines.SplineKnotIndex index)
  System.Void ShiftKnotIndices(UnityEngine.Splines.SplineKnotIndex index, System.Int32 offset)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Splines.NativeSpline
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  private           Unity.Collections.NativeArray<UnityEngine.Splines.BezierKnot>m_Knots  // 0x10
  private           Unity.Collections.NativeArray<UnityEngine.Splines.BezierCurve>m_Curves  // 0x20
  private           Unity.Collections.NativeArray<UnityEngine.Splines.DistanceToInterpolation>m_SegmentLengthsLookupTable  // 0x30
  private           System.Boolean                  m_Closed  // 0x40
  private           System.Single                   m_Length  // 0x44
METHODS:
  System.Boolean get_Closed()
  System.Int32 get_Count()
  System.Single GetLength()
  UnityEngine.Splines.BezierKnot get_Item(System.Int32 index)
  System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void .ctor(UnityEngine.Splines.ISpline spline, Unity.Mathematics.float4x4 transform, Unity.Collections.Allocator allocator)
  System.Void .ctor(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot> knots, System.Collections.Generic.IReadOnlyList<System.Int32> splits, System.Boolean closed, Unity.Mathematics.float4x4 transform, Unity.Collections.Allocator allocator)
  UnityEngine.Splines.BezierCurve GetCurve(System.Int32 index)
  System.Single GetCurveLength(System.Int32 curveIndex)
  System.Void Dispose()
  System.Single GetCurveInterpolation(System.Int32 curveIndex, System.Single curveDistance)
END_CLASS

CLASS: UnityEngine.Splines.Spline
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private   static  UnityEngine.Splines.TangentMode k_DefaultTangentMode  // 0x0
  private   static  UnityEngine.Splines.BezierTangentk_DefaultMainTangent  // 0x0
  private   static  System.Int32                    k_BatchModification  // 0x0
  private   static  System.Int32                    k_CurveDistanceLutResolution  // 0x0
  private           UnityEngine.Splines.SplineType  m_EditModeType  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Splines.BezierKnot>m_Knots  // 0x18
  private           System.Single                   m_Length  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Splines.Spline.MetaData>m_MetaData  // 0x28
  private           System.Boolean                  m_Closed  // 0x30
  private           UnityEngine.Splines.SplineDataDictionary<System.Int32>m_IntData  // 0x38
  private           UnityEngine.Splines.SplineDataDictionary<System.Single>m_FloatData  // 0x40
  private           UnityEngine.Splines.SplineDataDictionary<Unity.Mathematics.float4>m_Float4Data  // 0x48
  private           UnityEngine.Splines.SplineDataDictionary<UnityEngine.Object>m_ObjectData  // 0x50
  private           System.Action                   changed  // 0x58
  private   static  System.Action<UnityEngine.Splines.Spline,System.Int32,UnityEngine.Splines.SplineModification>Changed  // 0x0
  private           System.ValueTuple<System.Single,System.Single>m_LastKnotChangeCurveLengths  // 0x60
METHODS:
  System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler> get_embeddedSplineData()
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Void add_Changed(System.Action<UnityEngine.Splines.Spline,System.Int32,UnityEngine.Splines.SplineModification> value)
  System.Void remove_Changed(System.Action<UnityEngine.Splines.Spline,System.Int32,UnityEngine.Splines.SplineModification> value)
  System.Void SetDirtyNoNotify()
  System.Void SetDirty(UnityEngine.Splines.SplineModification modificationEvent, System.Int32 knotIndex)
  System.Void OnSplineChanged()
  System.Void EnsureMetaDataValid()
  UnityEngine.Splines.TangentMode GetTangentMode(System.Int32 index)
  System.Void ApplyTangentModeNoNotify(System.Int32 index, UnityEngine.Splines.BezierTangent main)
  System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot> get_Knots()
  System.Boolean get_Closed()
  System.Void set_Closed(System.Boolean value)
  System.Int32 IndexOf(UnityEngine.Splines.BezierKnot item)
  System.Void Insert(System.Int32 index, UnityEngine.Splines.BezierKnot knot)
  System.Void Insert(System.Int32 index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode)
  System.Void Insert(System.Int32 index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode, System.Single tension)
  System.Void RemoveAt(System.Int32 index)
  UnityEngine.Splines.BezierKnot get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, UnityEngine.Splines.BezierKnot value)
  System.Void SetKnot(System.Int32 index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main)
  System.Void SetKnotNoNotify(System.Int32 index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main)
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot> knots, System.Boolean closed)
  UnityEngine.Splines.BezierCurve GetCurve(System.Int32 index)
  System.Single GetCurveLength(System.Int32 index)
  System.Single GetLength()
  UnityEngine.Splines.DistanceToInterpolation[] GetCurveDistanceLut(System.Int32 index)
  System.Single GetCurveInterpolation(System.Int32 curveIndex, System.Single curveDistance)
  System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Add(UnityEngine.Splines.BezierKnot item)
  System.Void Add(UnityEngine.Splines.BezierKnot item, UnityEngine.Splines.TangentMode mode)
  System.Void Clear()
  System.Boolean Contains(UnityEngine.Splines.BezierKnot item)
  System.Void CopyTo(UnityEngine.Splines.BezierKnot[] array, System.Int32 arrayIndex)
  System.Boolean Remove(UnityEngine.Splines.BezierKnot item)
  System.Void CacheKnotOperationCurves(System.Int32 index)
END_CLASS

CLASS: UnityEngine.Splines.SplineContainer
TYPE:  class
TOKEN: 0x2000017
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.String                   k_IconPath  // 0x0
  private           UnityEngine.Splines.Spline      m_Spline  // 0x18
  private           UnityEngine.Splines.Spline[]    m_Splines  // 0x20
  private           UnityEngine.Splines.KnotLinkCollectionm_Knots  // 0x28
  private           System.Collections.Generic.List<System.ValueTuple<System.Int32,System.Int32>>m_ReorderedSplinesIndices  // 0x30
  private           System.Collections.Generic.List<System.Int32>m_RemovedSplinesIndices  // 0x38
  private           System.Collections.Generic.List<System.Int32>m_AddedSplinesIndices  // 0x40
  private   static  System.Action<UnityEngine.Splines.SplineContainer,System.Int32>SplineAdded  // 0x0
  private   static  System.Action<UnityEngine.Splines.SplineContainer,System.Int32>SplineRemoved  // 0x8
  private   static  System.Action<UnityEngine.Splines.SplineContainer,System.Int32,System.Int32>SplineReordered  // 0x10
METHODS:
  System.Void add_SplineAdded(System.Action<UnityEngine.Splines.SplineContainer,System.Int32> value)
  System.Void remove_SplineAdded(System.Action<UnityEngine.Splines.SplineContainer,System.Int32> value)
  System.Void add_SplineRemoved(System.Action<UnityEngine.Splines.SplineContainer,System.Int32> value)
  System.Void remove_SplineRemoved(System.Action<UnityEngine.Splines.SplineContainer,System.Int32> value)
  System.Void add_SplineReordered(System.Action<UnityEngine.Splines.SplineContainer,System.Int32,System.Int32> value)
  System.Void remove_SplineReordered(System.Action<UnityEngine.Splines.SplineContainer,System.Int32,System.Int32> value)
  System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> get_Splines()
  System.Void set_Splines(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> value)
  System.Int32 IndexOf(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> self, UnityEngine.Splines.Spline elementToFind)
  UnityEngine.Splines.KnotLinkCollection get_KnotLinkCollection()
  UnityEngine.Splines.Spline get_Item(System.Int32 index)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnSplineChanged(UnityEngine.Splines.Spline spline, System.Int32 index, UnityEngine.Splines.SplineModification modificationType)
  System.Void OnKnotModified(UnityEngine.Splines.Spline spline, System.Int32 index)
  System.Boolean get_IsScaled()
  UnityEngine.Splines.Spline get_Spline()
  System.Void set_Spline(UnityEngine.Splines.Spline value)
  System.Boolean Evaluate(System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector)
  System.Boolean Evaluate(System.Int32 splineIndex, System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector)
  System.Boolean Evaluate(T spline, System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector)
  Unity.Mathematics.float3 EvaluatePosition(System.Single t)
  UnityEngine.Vector3 EvaluatePositionV3(System.Single t)
  Unity.Mathematics.float3 EvaluatePosition(System.Int32 splineIndex, System.Single t)
  Unity.Mathematics.float3 EvaluatePosition(T spline, System.Single t)
  Unity.Mathematics.float3 EvaluateTangent(System.Single t)
  Unity.Mathematics.float3 EvaluateTangent(System.Int32 splineIndex, System.Single t)
  Unity.Mathematics.float3 EvaluateTangent(T spline, System.Single t)
  Unity.Mathematics.float3 EvaluateUpVector(System.Single t)
  Unity.Mathematics.float3 EvaluateUpVector(System.Int32 splineIndex, System.Single t)
  Unity.Mathematics.float3 EvaluateUpVector(T spline, System.Single t)
  Unity.Mathematics.float3 EvaluateAcceleration(System.Single t)
  Unity.Mathematics.float3 EvaluateAcceleration(System.Int32 splineIndex, System.Single t)
  Unity.Mathematics.float3 EvaluateAcceleration(T spline, System.Single t)
  System.Single CalculateLength()
  System.Single CalculateLength(System.Int32 splineIndex)
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Splines.PathIndexUnit
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Splines.PathIndexUnitDistance  // 0x0
  public    static  UnityEngine.Splines.PathIndexUnitNormalized  // 0x0
  public    static  UnityEngine.Splines.PathIndexUnitKnot  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Splines.ISplineModificationHandler
TYPE:  interface
TOKEN: 0x200001A
FIELDS:
METHODS:
  System.Void OnSplineModified(UnityEngine.Splines.SplineModificationData info)
END_CLASS

CLASS: UnityEngine.Splines.SplineData`1
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  private   static readonly UnityEngine.Splines.DataPointComparer<UnityEngine.Splines.DataPoint<T>>k_DataPointComparer  // 0x0
  private           UnityEngine.Splines.PathIndexUnitm_IndexUnit  // 0x0
  private           T                               m_DefaultValue  // 0x0
  private           System.Collections.Generic.List<UnityEngine.Splines.DataPoint<T>>m_DataPoints  // 0x0
  private           System.Boolean                  m_NeedsSort  // 0x0
  private           System.Action                   changed  // 0x0
  private           System.Action                   Changed  // 0x0
METHODS:
  System.Int32 get_Count()
  System.Void .ctor()
  System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void UnityEngine.Splines.ISplineModificationHandler.OnSplineModified(UnityEngine.Splines.SplineModificationData data)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Splines.SplineDataKeyValuePair`1
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  public            System.String                   Key  // 0x0
  public            UnityEngine.Splines.SplineData<T>Value  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Splines.SplineDataDictionary`1
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Splines.SplineDataKeyValuePair<T>>m_Data  // 0x0
METHODS:
  System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<T>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Splines.SplineKnotIndex
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    Spline  // 0x10
  public            System.Int32                    Knot  // 0x14
METHODS:
  System.Void .ctor(System.Int32 spline, System.Int32 knot)
  System.Boolean Equals(UnityEngine.Splines.SplineKnotIndex otherIndex)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.Splines.SplineMath
TYPE:  class
TOKEN: 0x2000020
FIELDS:
METHODS:
  Unity.Mathematics.float3 PointLineNearestPoint(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, System.Single& lineParam)
END_CLASS

CLASS: UnityEngine.Splines.SplineModification
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Splines.SplineModificationDefault  // 0x0
  public    static  UnityEngine.Splines.SplineModificationClosedModified  // 0x0
  public    static  UnityEngine.Splines.SplineModificationKnotModified  // 0x0
  public    static  UnityEngine.Splines.SplineModificationKnotInserted  // 0x0
  public    static  UnityEngine.Splines.SplineModificationKnotRemoved  // 0x0
  public    static  UnityEngine.Splines.SplineModificationKnotReordered  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Splines.SplineModificationData
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public    readonly UnityEngine.Splines.Spline      Spline  // 0x10
  public    readonly UnityEngine.Splines.SplineModificationModification  // 0x18
  public    readonly System.Int32                    KnotIndex  // 0x1C
  public    readonly System.Single                   PrevCurveLength  // 0x20
  public    readonly System.Single                   NextCurveLength  // 0x24
METHODS:
  System.Void .ctor(UnityEngine.Splines.Spline spline, UnityEngine.Splines.SplineModification modification, System.Int32 knotIndex, System.Single prevCurveLength, System.Single nextCurveLength)
END_CLASS

CLASS: UnityEngine.Splines.SplineType
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.Splines.SplineType  CatmullRom  // 0x0
  public    static  UnityEngine.Splines.SplineType  Bezier  // 0x0
  public    static  UnityEngine.Splines.SplineType  Linear  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Splines.SplineUtility
TYPE:  class
TOKEN: 0x2000024
FIELDS:
METHODS:
  System.Boolean Evaluate(T spline, System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector)
  Unity.Mathematics.float3 EvaluatePosition(T spline, System.Single t)
  UnityEngine.Vector3 EvaluatePositionV3(T spline, System.Single t)
  Unity.Mathematics.float3 EvaluateTangent(T spline, System.Single t)
  Unity.Mathematics.float3 EvaluateUpVector(T spline, System.Single t)
  Unity.Mathematics.float3 EvaluateUpVector(T spline, System.Int32 curveIndex, System.Single curveT)
  Unity.Mathematics.float3 EvaluateAcceleration(T spline, System.Single t)
  System.Int32 SplineToCurveT(T spline, System.Single splineT, System.Single& curveT)
  System.Int32 SplineToCurveT(T spline, System.Single splineT, System.Single& curveT, System.Boolean useLUT)
  System.Single CalculateLength(T spline, Unity.Mathematics.float4x4 transform)
  System.Int32 GetCurveCount(T spline)
  System.Int32 GetSubdivisionCount(System.Single length, System.Int32 resolution)
  UnityEngine.Splines.SplineUtility.Segment GetNearestPoint(T spline, Unity.Mathematics.float3 point, UnityEngine.Splines.SplineUtility.Segment range, System.Single& distance, Unity.Mathematics.float3& nearest, System.Single& time, System.Int32 segments)
  System.Single GetNearestPoint(T spline, Unity.Mathematics.float3 point, Unity.Mathematics.float3& nearest, System.Single& t, System.Int32 resolution, System.Int32 iterations)
  System.Int32 PreviousIndex(T spline, System.Int32 index)
  System.Int32 NextIndex(T spline, System.Int32 index)
  UnityEngine.Splines.BezierKnot Previous(T spline, System.Int32 index)
  UnityEngine.Splines.BezierKnot Next(T spline, System.Int32 index)
  System.Int32 PreviousIndex(System.Int32 index, System.Int32 count, System.Boolean wrap)
  System.Int32 NextIndex(System.Int32 index, System.Int32 count, System.Boolean wrap)
  Unity.Mathematics.float3 GetExplicitLinearTangent(Unity.Mathematics.float3 point, Unity.Mathematics.float3 to)
  Unity.Mathematics.float3 GetAutoSmoothTangent(Unity.Mathematics.float3 previous, Unity.Mathematics.float3 current, Unity.Mathematics.float3 next, System.Single tension)
  UnityEngine.Splines.BezierKnot GetAutoSmoothKnot(Unity.Mathematics.float3 position, Unity.Mathematics.float3 previous, Unity.Mathematics.float3 next, Unity.Mathematics.float3 normal, System.Single width, System.Single tension)
  Unity.Mathematics.quaternion GetKnotRotation(Unity.Mathematics.float3 tangent, Unity.Mathematics.float3 normal)
  System.Boolean IsIndexValid(T container, UnityEngine.Splines.SplineKnotIndex index)
  System.Void SetLinkedKnotPosition(T container, UnityEngine.Splines.SplineKnotIndex index)
END_CLASS

