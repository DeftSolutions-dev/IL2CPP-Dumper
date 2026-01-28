// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Splines.dll
// Classes:  37
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000008
    public struct FrenetFrame
    {
        // Fields
        public Unity.Mathematics.float3 origin;        // 0x10
        public Unity.Mathematics.float3 tangent;        // 0x1C
        public Unity.Mathematics.float3 normal;        // 0x28
        public Unity.Mathematics.float3 binormal;        // 0x34

    }

    // TypeToken: 0x2000011
    public class KnotLink, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1
    {
        // Fields
        public UnityEngine.Splines.SplineKnotIndex[] Knots;        // 0x10

        // Methods
        private System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineKnotIndex> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 get_Count() { }
        private UnityEngine.Splines.SplineKnotIndex get_Item(System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public struct Slice`1, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1
    {
        // Fields
        private Unity.Collections.NativeSlice<T> m_Slice;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.NativeArray<T> array, System.Int32 start, System.Int32 count) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 get_Count() { }
        private T get_Item(System.Int32 index) { }

    }

    // TypeToken: 0x2000015
    public class MetaData
    {
        // Fields
        public UnityEngine.Splines.TangentMode Mode;        // 0x10
        public System.Single Tension;        // 0x14
        private UnityEngine.Splines.DistanceToInterpolation[] m_DistanceToInterpolation;        // 0x18

        // Methods
        private UnityEngine.Splines.DistanceToInterpolation[] get_DistanceToInterpolation() { }
        private System.Void .ctor() { }
        private System.Void InvalidateCache() { }

    }

    // TypeToken: 0x2000025
    public struct Segment
    {
        // Fields
        public System.Single start;        // 0x10
        public System.Single length;        // 0x14

        // Methods
        private System.Void .ctor(System.Single start, System.Single length) { }

    }

namespace UnityEngine.Splines
{

    // TypeToken: 0x2000002
    public class ArrayUtility
    {
        // Methods
        private System.Void RemoveAt(T[]& array, System.Int32 index) { }
        private System.Void Remove(T[]& array, T element) { }

    }

    // TypeToken: 0x2000003
    public struct BezierCurve, IEquatable`1
    {
        // Fields
        public Unity.Mathematics.float3 P0;        // 0x10
        public Unity.Mathematics.float3 P1;        // 0x1C
        public Unity.Mathematics.float3 P2;        // 0x28
        public Unity.Mathematics.float3 P3;        // 0x34

        // Methods
        private System.Void .ctor(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 p3) { }
        private System.Void .ctor(UnityEngine.Splines.BezierKnot a, UnityEngine.Splines.BezierKnot b) { }
        private System.Boolean Equals(UnityEngine.Splines.BezierCurve other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000004
    public struct BezierKnot, ISerializationCallbackReceiver, IEquatable`1
    {
        // Fields
        public Unity.Mathematics.float3 Position;        // 0x10
        public Unity.Mathematics.float3 TangentIn;        // 0x1C
        public Unity.Mathematics.float3 TangentOut;        // 0x28
        public Unity.Mathematics.quaternion Rotation;        // 0x34
        public System.Single Width;        // 0x44

        // Methods
        private System.Void .ctor(Unity.Mathematics.float3 position) { }
        private System.Void .ctor(Unity.Mathematics.float3 position, Unity.Mathematics.float3 tangentIn, Unity.Mathematics.float3 tangentOut, Unity.Mathematics.quaternion rotation, System.Single width) { }
        private UnityEngine.Splines.BezierKnot Transform(Unity.Mathematics.float4x4 matrix) { }
        private UnityEngine.Splines.BezierKnot BakeTangentDirectionToRotation(System.Boolean mirrored, UnityEngine.Splines.BezierTangent main) { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.Splines.BezierKnot other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000005
    public struct TangentMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Splines.TangentMode AutoSmooth;        // 0x0
        public static UnityEngine.Splines.TangentMode Linear;        // 0x0
        public static UnityEngine.Splines.TangentMode Mirrored;        // 0x0
        public static UnityEngine.Splines.TangentMode Continuous;        // 0x0
        public static UnityEngine.Splines.TangentMode Broken;        // 0x0

    }

    // TypeToken: 0x2000006
    public struct BezierTangent
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Splines.BezierTangent In;        // 0x0
        public static UnityEngine.Splines.BezierTangent Out;        // 0x0

    }

    // TypeToken: 0x2000007
    public class CurveUtility
    {
        // Fields
        private static readonly UnityEngine.Splines.DistanceToInterpolation[] k_DistanceLUT;        // 0x0

        // Methods
        private Unity.Mathematics.float3 EvaluatePosition(UnityEngine.Splines.BezierCurve curve, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateTangent(UnityEngine.Splines.BezierCurve curve, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateAcceleration(UnityEngine.Splines.BezierCurve curve, System.Single t) { }
        private System.Void CalculateCurveLengths(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.DistanceToInterpolation[] lookupTable) { }
        private System.Boolean Approximately(System.Single a, System.Single b) { }
        private Unity.Mathematics.float3 EvaluateUpVector(UnityEngine.Splines.BezierCurve curve, System.Single t, Unity.Mathematics.float3 startUp, Unity.Mathematics.float3 endUp) { }
        private UnityEngine.Splines.CurveUtility.FrenetFrame GetNextRotationMinimizingFrame(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.CurveUtility.FrenetFrame previousRMFrame, System.Single nextRMFrameT) { }
        private System.Single GetDistanceToInterpolation(T lut, System.Single distance) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000009
    public interface IDataPoint
    {
        // Methods
        private System.Single get_Index() { }

    }

    // TypeToken: 0x200000A
    public struct DataPoint`1, IComparable`1, IComparable`1, IDataPoint
    {
        // Fields
        private System.Single m_Index;        // 0x0
        private TDataType m_Value;        // 0x0

        // Methods
        private System.Single get_Index() { }
        private System.Void set_Index(System.Single value) { }
        private TDataType get_Value() { }
        private System.Int32 CompareTo(UnityEngine.Splines.DataPoint<TDataType> other) { }
        private System.Int32 CompareTo(System.Single other) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200000B
    public class DataPointComparer`1, IComparer`1
    {
        // Methods
        private System.Int32 Compare(T x, T y) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public struct DistanceToInterpolation
    {
        // Fields
        public System.Single Distance;        // 0x10
        public System.Single T;        // 0x14
        private static readonly UnityEngine.Splines.DistanceToInterpolation Invalid;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public interface IHasEmptyCurves
    {
        // Methods
        private System.Collections.Generic.IReadOnlyList<System.Int32> get_EmptyCurves() { }

    }

    // TypeToken: 0x200000E
    public interface ISpline : IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1
    {
        // Methods
        private System.Boolean get_Closed() { }
        private System.Single GetLength() { }
        private UnityEngine.Splines.BezierCurve GetCurve(System.Int32 index) { }
        private System.Single GetCurveLength(System.Int32 index) { }
        private System.Single GetCurveInterpolation(System.Int32 curveIndex, System.Single curveDistance) { }

    }

    // TypeToken: 0x200000F
    public interface ISplineContainer
    {
        // Methods
        private System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> get_Splines() { }
        private UnityEngine.Splines.KnotLinkCollection get_KnotLinkCollection() { }

    }

    // TypeToken: 0x2000010
    public class KnotLinkCollection
    {
        // Fields
        private UnityEngine.Splines.KnotLinkCollection.KnotLink[] m_KnotsLink;        // 0x10

        // Methods
        private UnityEngine.Splines.KnotLinkCollection.KnotLink GetKnotLinksInternal(UnityEngine.Splines.SplineKnotIndex index) { }
        private System.Boolean TryGetKnotLinks(UnityEngine.Splines.SplineKnotIndex knotIndex, System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex>& linkedKnots) { }
        private System.Void Unlink(UnityEngine.Splines.SplineKnotIndex knot) { }
        private System.Void KnotRemoved(System.Int32 splineIndex, System.Int32 knotIndex) { }
        private System.Void KnotRemoved(UnityEngine.Splines.SplineKnotIndex index) { }
        private System.Void KnotInserted(System.Int32 splineIndex, System.Int32 knotIndex) { }
        private System.Void KnotInserted(UnityEngine.Splines.SplineKnotIndex index) { }
        private System.Void ShiftKnotIndices(UnityEngine.Splines.SplineKnotIndex index, System.Int32 offset) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public struct NativeSpline, ISpline, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<UnityEngine.Splines.BezierKnot> m_Knots;        // 0x10
        private Unity.Collections.NativeArray<UnityEngine.Splines.BezierCurve> m_Curves;        // 0x20
        private Unity.Collections.NativeArray<UnityEngine.Splines.DistanceToInterpolation> m_SegmentLengthsLookupTable;        // 0x30
        private System.Boolean m_Closed;        // 0x40
        private System.Single m_Length;        // 0x44

        // Methods
        private System.Boolean get_Closed() { }
        private System.Int32 get_Count() { }
        private System.Single GetLength() { }
        private UnityEngine.Splines.BezierKnot get_Item(System.Int32 index) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void .ctor(UnityEngine.Splines.ISpline spline, Unity.Mathematics.float4x4 transform, Unity.Collections.Allocator allocator) { }
        private System.Void .ctor(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot> knots, System.Collections.Generic.IReadOnlyList<System.Int32> splits, System.Boolean closed, Unity.Mathematics.float4x4 transform, Unity.Collections.Allocator allocator) { }
        private UnityEngine.Splines.BezierCurve GetCurve(System.Int32 index) { }
        private System.Single GetCurveLength(System.Int32 curveIndex) { }
        private System.Void Dispose() { }
        private System.Single GetCurveInterpolation(System.Int32 curveIndex, System.Single curveDistance) { }

    }

    // TypeToken: 0x2000014
    public class Spline, ISpline, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1, IList`1, ICollection`1
    {
        // Fields
        private static UnityEngine.Splines.TangentMode k_DefaultTangentMode;        // 0x0
        private static UnityEngine.Splines.BezierTangent k_DefaultMainTangent;        // 0x0
        private static System.Int32 k_BatchModification;        // 0x0
        private static System.Int32 k_CurveDistanceLutResolution;        // 0x0
        private UnityEngine.Splines.SplineType m_EditModeType;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Splines.BezierKnot> m_Knots;        // 0x18
        private System.Single m_Length;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Splines.Spline.MetaData> m_MetaData;        // 0x28
        private System.Boolean m_Closed;        // 0x30
        private UnityEngine.Splines.SplineDataDictionary<System.Int32> m_IntData;        // 0x38
        private UnityEngine.Splines.SplineDataDictionary<System.Single> m_FloatData;        // 0x40
        private UnityEngine.Splines.SplineDataDictionary<Unity.Mathematics.float4> m_Float4Data;        // 0x48
        private UnityEngine.Splines.SplineDataDictionary<UnityEngine.Object> m_ObjectData;        // 0x50
        private System.Action changed;        // 0x58
        private static System.Action<UnityEngine.Splines.Spline,System.Int32,UnityEngine.Splines.SplineModification> Changed;        // 0x0
        private System.ValueTuple<System.Single,System.Single> m_LastKnotChangeCurveLengths;        // 0x60

        // Methods
        private System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler> get_embeddedSplineData() { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void add_Changed(System.Action<UnityEngine.Splines.Spline,System.Int32,UnityEngine.Splines.SplineModification> value) { }
        private System.Void remove_Changed(System.Action<UnityEngine.Splines.Spline,System.Int32,UnityEngine.Splines.SplineModification> value) { }
        private System.Void SetDirtyNoNotify() { }
        private System.Void SetDirty(UnityEngine.Splines.SplineModification modificationEvent, System.Int32 knotIndex) { }
        private System.Void OnSplineChanged() { }
        private System.Void EnsureMetaDataValid() { }
        private UnityEngine.Splines.TangentMode GetTangentMode(System.Int32 index) { }
        private System.Void ApplyTangentModeNoNotify(System.Int32 index, UnityEngine.Splines.BezierTangent main) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot> get_Knots() { }
        private System.Boolean get_Closed() { }
        private System.Void set_Closed(System.Boolean value) { }
        private System.Int32 IndexOf(UnityEngine.Splines.BezierKnot item) { }
        private System.Void Insert(System.Int32 index, UnityEngine.Splines.BezierKnot knot) { }
        private System.Void Insert(System.Int32 index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode) { }
        private System.Void Insert(System.Int32 index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode, System.Single tension) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private UnityEngine.Splines.BezierKnot get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, UnityEngine.Splines.BezierKnot value) { }
        private System.Void SetKnot(System.Int32 index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main) { }
        private System.Void SetKnotNoNotify(System.Int32 index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot> knots, System.Boolean closed) { }
        private UnityEngine.Splines.BezierCurve GetCurve(System.Int32 index) { }
        private System.Single GetCurveLength(System.Int32 index) { }
        private System.Single GetLength() { }
        private UnityEngine.Splines.DistanceToInterpolation[] GetCurveDistanceLut(System.Int32 index) { }
        private System.Single GetCurveInterpolation(System.Int32 curveIndex, System.Single curveDistance) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Add(UnityEngine.Splines.BezierKnot item) { }
        private System.Void Add(UnityEngine.Splines.BezierKnot item, UnityEngine.Splines.TangentMode mode) { }
        private System.Void Clear() { }
        private System.Boolean Contains(UnityEngine.Splines.BezierKnot item) { }
        private System.Void CopyTo(UnityEngine.Splines.BezierKnot[] array, System.Int32 arrayIndex) { }
        private System.Boolean Remove(UnityEngine.Splines.BezierKnot item) { }
        private System.Void CacheKnotOperationCurves(System.Int32 index) { }

    }

    // TypeToken: 0x2000017
    public class SplineContainer : MonoBehaviour, ISplineContainer, ISerializationCallbackReceiver
    {
        // Fields
        private static System.String k_IconPath;        // 0x0
        private UnityEngine.Splines.Spline m_Spline;        // 0x18
        private UnityEngine.Splines.Spline[] m_Splines;        // 0x20
        private UnityEngine.Splines.KnotLinkCollection m_Knots;        // 0x28
        private System.Collections.Generic.List<System.ValueTuple<System.Int32,System.Int32>> m_ReorderedSplinesIndices;        // 0x30
        private System.Collections.Generic.List<System.Int32> m_RemovedSplinesIndices;        // 0x38
        private System.Collections.Generic.List<System.Int32> m_AddedSplinesIndices;        // 0x40
        private static System.Action<UnityEngine.Splines.SplineContainer,System.Int32> SplineAdded;        // 0x0
        private static System.Action<UnityEngine.Splines.SplineContainer,System.Int32> SplineRemoved;        // 0x8
        private static System.Action<UnityEngine.Splines.SplineContainer,System.Int32,System.Int32> SplineReordered;        // 0x10

        // Methods
        private System.Void add_SplineAdded(System.Action<UnityEngine.Splines.SplineContainer,System.Int32> value) { }
        private System.Void remove_SplineAdded(System.Action<UnityEngine.Splines.SplineContainer,System.Int32> value) { }
        private System.Void add_SplineRemoved(System.Action<UnityEngine.Splines.SplineContainer,System.Int32> value) { }
        private System.Void remove_SplineRemoved(System.Action<UnityEngine.Splines.SplineContainer,System.Int32> value) { }
        private System.Void add_SplineReordered(System.Action<UnityEngine.Splines.SplineContainer,System.Int32,System.Int32> value) { }
        private System.Void remove_SplineReordered(System.Action<UnityEngine.Splines.SplineContainer,System.Int32,System.Int32> value) { }
        private System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> get_Splines() { }
        private System.Void set_Splines(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> value) { }
        private System.Int32 IndexOf(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> self, UnityEngine.Splines.Spline elementToFind) { }
        private UnityEngine.Splines.KnotLinkCollection get_KnotLinkCollection() { }
        private UnityEngine.Splines.Spline get_Item(System.Int32 index) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnSplineChanged(UnityEngine.Splines.Spline spline, System.Int32 index, UnityEngine.Splines.SplineModification modificationType) { }
        private System.Void OnKnotModified(UnityEngine.Splines.Spline spline, System.Int32 index) { }
        private System.Boolean get_IsScaled() { }
        private UnityEngine.Splines.Spline get_Spline() { }
        private System.Void set_Spline(UnityEngine.Splines.Spline value) { }
        private System.Boolean Evaluate(System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector) { }
        private System.Boolean Evaluate(System.Int32 splineIndex, System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector) { }
        private System.Boolean Evaluate(T spline, System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector) { }
        private Unity.Mathematics.float3 EvaluatePosition(System.Single t) { }
        private UnityEngine.Vector3 EvaluatePositionV3(System.Single t) { }
        private Unity.Mathematics.float3 EvaluatePosition(System.Int32 splineIndex, System.Single t) { }
        private Unity.Mathematics.float3 EvaluatePosition(T spline, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateTangent(System.Single t) { }
        private Unity.Mathematics.float3 EvaluateTangent(System.Int32 splineIndex, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateTangent(T spline, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateUpVector(System.Single t) { }
        private Unity.Mathematics.float3 EvaluateUpVector(System.Int32 splineIndex, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateUpVector(T spline, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateAcceleration(System.Single t) { }
        private Unity.Mathematics.float3 EvaluateAcceleration(System.Int32 splineIndex, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateAcceleration(T spline, System.Single t) { }
        private System.Single CalculateLength() { }
        private System.Single CalculateLength(System.Int32 splineIndex) { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public struct PathIndexUnit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Splines.PathIndexUnit Distance;        // 0x0
        public static UnityEngine.Splines.PathIndexUnit Normalized;        // 0x0
        public static UnityEngine.Splines.PathIndexUnit Knot;        // 0x0

    }

    // TypeToken: 0x200001A
    public interface ISplineModificationHandler
    {
        // Methods
        private System.Void OnSplineModified(UnityEngine.Splines.SplineModificationData info) { }

    }

    // TypeToken: 0x200001B
    public class SplineData`1, IEnumerable`1, IEnumerable, ISplineModificationHandler
    {
        // Fields
        private static readonly UnityEngine.Splines.DataPointComparer<UnityEngine.Splines.DataPoint<T>> k_DataPointComparer;        // 0x0
        private UnityEngine.Splines.PathIndexUnit m_IndexUnit;        // 0x0
        private T m_DefaultValue;        // 0x0
        private System.Collections.Generic.List<UnityEngine.Splines.DataPoint<T>> m_DataPoints;        // 0x0
        private System.Boolean m_NeedsSort;        // 0x0
        private System.Action changed;        // 0x0
        private System.Action Changed;        // 0x0

        // Methods
        private System.Int32 get_Count() { }
        private System.Void .ctor() { }
        private System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void UnityEngine.Splines.ISplineModificationHandler.OnSplineModified(UnityEngine.Splines.SplineModificationData data) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001D
    public class SplineDataKeyValuePair`1
    {
        // Fields
        public System.String Key;        // 0x0
        public UnityEngine.Splines.SplineData<T> Value;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class SplineDataDictionary`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Splines.SplineDataKeyValuePair<T>> m_Data;        // 0x0

        // Methods
        private System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<T>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public struct SplineKnotIndex, IEquatable`1
    {
        // Fields
        public System.Int32 Spline;        // 0x10
        public System.Int32 Knot;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 spline, System.Int32 knot) { }
        private System.Boolean Equals(UnityEngine.Splines.SplineKnotIndex otherIndex) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000020
    public class SplineMath
    {
        // Methods
        private Unity.Mathematics.float3 PointLineNearestPoint(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, System.Single& lineParam) { }

    }

    // TypeToken: 0x2000021
    public struct SplineModification
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Splines.SplineModification Default;        // 0x0
        public static UnityEngine.Splines.SplineModification ClosedModified;        // 0x0
        public static UnityEngine.Splines.SplineModification KnotModified;        // 0x0
        public static UnityEngine.Splines.SplineModification KnotInserted;        // 0x0
        public static UnityEngine.Splines.SplineModification KnotRemoved;        // 0x0
        public static UnityEngine.Splines.SplineModification KnotReordered;        // 0x0

    }

    // TypeToken: 0x2000022
    public struct SplineModificationData
    {
        // Fields
        public readonly UnityEngine.Splines.Spline Spline;        // 0x10
        public readonly UnityEngine.Splines.SplineModification Modification;        // 0x18
        public readonly System.Int32 KnotIndex;        // 0x1C
        public readonly System.Single PrevCurveLength;        // 0x20
        public readonly System.Single NextCurveLength;        // 0x24

        // Methods
        private System.Void .ctor(UnityEngine.Splines.Spline spline, UnityEngine.Splines.SplineModification modification, System.Int32 knotIndex, System.Single prevCurveLength, System.Single nextCurveLength) { }

    }

    // TypeToken: 0x2000023
    public struct SplineType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.Splines.SplineType CatmullRom;        // 0x0
        public static UnityEngine.Splines.SplineType Bezier;        // 0x0
        public static UnityEngine.Splines.SplineType Linear;        // 0x0

    }

    // TypeToken: 0x2000024
    public class SplineUtility
    {
        // Methods
        private System.Boolean Evaluate(T spline, System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector) { }
        private Unity.Mathematics.float3 EvaluatePosition(T spline, System.Single t) { }
        private UnityEngine.Vector3 EvaluatePositionV3(T spline, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateTangent(T spline, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateUpVector(T spline, System.Single t) { }
        private Unity.Mathematics.float3 EvaluateUpVector(T spline, System.Int32 curveIndex, System.Single curveT) { }
        private Unity.Mathematics.float3 EvaluateAcceleration(T spline, System.Single t) { }
        private System.Int32 SplineToCurveT(T spline, System.Single splineT, System.Single& curveT) { }
        private System.Int32 SplineToCurveT(T spline, System.Single splineT, System.Single& curveT, System.Boolean useLUT) { }
        private System.Single CalculateLength(T spline, Unity.Mathematics.float4x4 transform) { }
        private System.Int32 GetCurveCount(T spline) { }
        private System.Int32 GetSubdivisionCount(System.Single length, System.Int32 resolution) { }
        private UnityEngine.Splines.SplineUtility.Segment GetNearestPoint(T spline, Unity.Mathematics.float3 point, UnityEngine.Splines.SplineUtility.Segment range, System.Single& distance, Unity.Mathematics.float3& nearest, System.Single& time, System.Int32 segments) { }
        private System.Single GetNearestPoint(T spline, Unity.Mathematics.float3 point, Unity.Mathematics.float3& nearest, System.Single& t, System.Int32 resolution, System.Int32 iterations) { }
        private System.Int32 PreviousIndex(T spline, System.Int32 index) { }
        private System.Int32 NextIndex(T spline, System.Int32 index) { }
        private UnityEngine.Splines.BezierKnot Previous(T spline, System.Int32 index) { }
        private UnityEngine.Splines.BezierKnot Next(T spline, System.Int32 index) { }
        private System.Int32 PreviousIndex(System.Int32 index, System.Int32 count, System.Boolean wrap) { }
        private System.Int32 NextIndex(System.Int32 index, System.Int32 count, System.Boolean wrap) { }
        private Unity.Mathematics.float3 GetExplicitLinearTangent(Unity.Mathematics.float3 point, Unity.Mathematics.float3 to) { }
        private Unity.Mathematics.float3 GetAutoSmoothTangent(Unity.Mathematics.float3 previous, Unity.Mathematics.float3 current, Unity.Mathematics.float3 next, System.Single tension) { }
        private UnityEngine.Splines.BezierKnot GetAutoSmoothKnot(Unity.Mathematics.float3 position, Unity.Mathematics.float3 previous, Unity.Mathematics.float3 next, Unity.Mathematics.float3 normal, System.Single width, System.Single tension) { }
        private Unity.Mathematics.quaternion GetKnotRotation(Unity.Mathematics.float3 tangent, Unity.Mathematics.float3 normal) { }
        private System.Boolean IsIndexValid(T container, UnityEngine.Splines.SplineKnotIndex index) { }
        private System.Void SetLinkedKnotPosition(T container, UnityEngine.Splines.SplineKnotIndex index) { }

    }

}

