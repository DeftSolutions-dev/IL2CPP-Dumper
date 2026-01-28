// ========================================================
// Dumped by @desirepro
// Assembly: clipper_library.dll
// Classes:  26
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace ClipperLib
{

    // TypeToken: 0x2000002
    public struct DoublePoint
    {
        // Fields
        public System.Double X;        // 0x10
        public System.Double Y;        // 0x18

        // Methods
        private System.Void .ctor(System.Double x, System.Double y) { }
        private System.Void .ctor(ClipperLib.DoublePoint dp) { }

    }

    // TypeToken: 0x2000003
    public class PolyNode
    {
        // Fields
        private ClipperLib.PolyNode m_Parent;        // 0x10
        private System.Collections.Generic.List<ClipperLib.IntPoint> m_polygon;        // 0x18
        private System.Int32 m_Index;        // 0x20
        private ClipperLib.JoinType m_jointype;        // 0x24
        private ClipperLib.EndType m_endtype;        // 0x28
        private System.Collections.Generic.List<ClipperLib.PolyNode> m_Childs;        // 0x30
        private System.Boolean <IsOpen>k__BackingField;        // 0x38

        // Methods
        private System.Int32 get_ChildCount() { }
        private System.Void AddChild(ClipperLib.PolyNode Child) { }
        private System.Collections.Generic.List<ClipperLib.PolyNode> get_Childs() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public struct Int128
    {
        // Fields
        private System.Int64 hi;        // 0x10
        private System.UInt64 lo;        // 0x18

        // Methods
        private System.Void .ctor(System.Int64 _hi, System.UInt64 _lo) { }
        private System.Boolean op_Equality(ClipperLib.Int128 val1, ClipperLib.Int128 val2) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private ClipperLib.Int128 op_UnaryNegation(ClipperLib.Int128 val) { }
        private ClipperLib.Int128 Int128Mul(System.Int64 lhs, System.Int64 rhs) { }

    }

    // TypeToken: 0x2000005
    public struct IntPoint
    {
        // Fields
        public System.Int64 X;        // 0x10
        public System.Int64 Y;        // 0x18

        // Methods
        private System.Void .ctor(System.Int64 X, System.Int64 Y) { }
        private System.Void .ctor(System.Double x, System.Double y) { }
        private System.Void .ctor(ClipperLib.IntPoint pt) { }
        private System.Boolean op_Equality(ClipperLib.IntPoint a, ClipperLib.IntPoint b) { }
        private System.Boolean op_Inequality(ClipperLib.IntPoint a, ClipperLib.IntPoint b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000006
    public struct IntRect
    {
        // Fields
        public System.Int64 left;        // 0x10
        public System.Int64 top;        // 0x18
        public System.Int64 right;        // 0x20
        public System.Int64 bottom;        // 0x28

        // Methods
        private System.Void .ctor(System.Int64 l, System.Int64 t, System.Int64 r, System.Int64 b) { }

    }

    // TypeToken: 0x2000007
    public struct ClipType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ClipperLib.ClipType ctIntersection;        // 0x0
        public static ClipperLib.ClipType ctUnion;        // 0x0
        public static ClipperLib.ClipType ctDifference;        // 0x0
        public static ClipperLib.ClipType ctXor;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct PolyType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ClipperLib.PolyType ptSubject;        // 0x0
        public static ClipperLib.PolyType ptClip;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct PolyFillType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ClipperLib.PolyFillType pftEvenOdd;        // 0x0
        public static ClipperLib.PolyFillType pftNonZero;        // 0x0
        public static ClipperLib.PolyFillType pftPositive;        // 0x0
        public static ClipperLib.PolyFillType pftNegative;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct JoinType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ClipperLib.JoinType jtSquare;        // 0x0
        public static ClipperLib.JoinType jtRound;        // 0x0
        public static ClipperLib.JoinType jtMiter;        // 0x0

    }

    // TypeToken: 0x200000B
    public struct EndType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ClipperLib.EndType etClosedPolygon;        // 0x0
        public static ClipperLib.EndType etClosedLine;        // 0x0
        public static ClipperLib.EndType etOpenButt;        // 0x0
        public static ClipperLib.EndType etOpenSquare;        // 0x0
        public static ClipperLib.EndType etOpenRound;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct EdgeSide
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ClipperLib.EdgeSide esLeft;        // 0x0
        public static ClipperLib.EdgeSide esRight;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct Direction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ClipperLib.Direction dRightToLeft;        // 0x0
        public static ClipperLib.Direction dLeftToRight;        // 0x0

    }

    // TypeToken: 0x200000E
    public class TEdge
    {
        // Fields
        private ClipperLib.IntPoint Bot;        // 0x10
        private ClipperLib.IntPoint Curr;        // 0x20
        private ClipperLib.IntPoint Top;        // 0x30
        private ClipperLib.IntPoint Delta;        // 0x40
        private System.Double Dx;        // 0x50
        private ClipperLib.PolyType PolyTyp;        // 0x58
        private ClipperLib.EdgeSide Side;        // 0x5C
        private System.Int32 WindDelta;        // 0x60
        private System.Int32 WindCnt;        // 0x64
        private System.Int32 WindCnt2;        // 0x68
        private System.Int32 OutIdx;        // 0x6C
        private ClipperLib.TEdge Next;        // 0x70
        private ClipperLib.TEdge Prev;        // 0x78
        private ClipperLib.TEdge NextInLML;        // 0x80
        private ClipperLib.TEdge NextInAEL;        // 0x88
        private ClipperLib.TEdge PrevInAEL;        // 0x90
        private ClipperLib.TEdge NextInSEL;        // 0x98
        private ClipperLib.TEdge PrevInSEL;        // 0xA0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class IntersectNode
    {
        // Fields
        private ClipperLib.TEdge Edge1;        // 0x10
        private ClipperLib.TEdge Edge2;        // 0x18
        private ClipperLib.IntPoint Pt;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class MyIntersectNodeSort, IComparer`1
    {
        // Methods
        private System.Int32 Compare(ClipperLib.IntersectNode node1, ClipperLib.IntersectNode node2) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class LocalMinima
    {
        // Fields
        private System.Int64 Y;        // 0x10
        private ClipperLib.TEdge LeftBound;        // 0x18
        private ClipperLib.TEdge RightBound;        // 0x20
        private ClipperLib.LocalMinima Next;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class Scanbeam
    {
        // Fields
        private System.Int64 Y;        // 0x10
        private ClipperLib.Scanbeam Next;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class Maxima
    {
        // Fields
        private System.Int64 X;        // 0x10
        private ClipperLib.Maxima Next;        // 0x18
        private ClipperLib.Maxima Prev;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class OutRec
    {
        // Fields
        private System.Int32 Idx;        // 0x10
        private System.Boolean IsHole;        // 0x14
        private System.Boolean IsOpen;        // 0x15
        private ClipperLib.OutRec FirstLeft;        // 0x18
        private ClipperLib.OutPt Pts;        // 0x20
        private ClipperLib.OutPt BottomPt;        // 0x28
        private ClipperLib.PolyNode PolyNode;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class OutPt
    {
        // Fields
        private System.Int32 Idx;        // 0x10
        private ClipperLib.IntPoint Pt;        // 0x18
        private ClipperLib.OutPt Next;        // 0x28
        private ClipperLib.OutPt Prev;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class Join
    {
        // Fields
        private ClipperLib.OutPt OutPt1;        // 0x10
        private ClipperLib.OutPt OutPt2;        // 0x18
        private ClipperLib.IntPoint OffPt;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class ClipperBase
    {
        // Fields
        private ClipperLib.LocalMinima m_MinimaList;        // 0x10
        private ClipperLib.LocalMinima m_CurrentLM;        // 0x18
        private System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.TEdge>> m_edges;        // 0x20
        private ClipperLib.Scanbeam m_Scanbeam;        // 0x28
        private System.Collections.Generic.List<ClipperLib.OutRec> m_PolyOuts;        // 0x30
        private ClipperLib.TEdge m_ActiveEdges;        // 0x38
        private System.Boolean m_UseFullRange;        // 0x40
        private System.Boolean m_HasOpenPaths;        // 0x41
        private System.Boolean <PreserveCollinear>k__BackingField;        // 0x42

        // Methods
        private System.Boolean near_zero(System.Double val) { }
        private System.Boolean get_PreserveCollinear() { }
        private System.Void set_PreserveCollinear(System.Boolean value) { }
        private System.Void Swap(System.Int64& val1, System.Int64& val2) { }
        private System.Boolean IsHorizontal(ClipperLib.TEdge e) { }
        private System.Boolean SlopesEqual(ClipperLib.TEdge e1, ClipperLib.TEdge e2, System.Boolean UseFullRange) { }
        private System.Boolean SlopesEqual(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2, ClipperLib.IntPoint pt3, System.Boolean UseFullRange) { }
        private System.Boolean SlopesEqual(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2, ClipperLib.IntPoint pt3, ClipperLib.IntPoint pt4, System.Boolean UseFullRange) { }
        private System.Void .ctor() { }
        private System.Void Clear() { }
        private System.Void DisposeLocalMinimaList() { }
        private System.Void RangeTest(ClipperLib.IntPoint Pt, System.Boolean& useFullRange) { }
        private System.Void InitEdge(ClipperLib.TEdge e, ClipperLib.TEdge eNext, ClipperLib.TEdge ePrev, ClipperLib.IntPoint pt) { }
        private System.Void InitEdge2(ClipperLib.TEdge e, ClipperLib.PolyType polyType) { }
        private ClipperLib.TEdge FindNextLocMin(ClipperLib.TEdge E) { }
        private ClipperLib.TEdge ProcessBound(ClipperLib.TEdge E, System.Boolean LeftBoundIsForward) { }
        private System.Boolean AddPath(System.Collections.Generic.List<ClipperLib.IntPoint> pg, ClipperLib.PolyType polyType, System.Boolean Closed) { }
        private System.Boolean AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> ppg, ClipperLib.PolyType polyType, System.Boolean closed) { }
        private System.Boolean Pt2IsBetweenPt1AndPt3(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2, ClipperLib.IntPoint pt3) { }
        private ClipperLib.TEdge RemoveEdge(ClipperLib.TEdge e) { }
        private System.Void SetDx(ClipperLib.TEdge e) { }
        private System.Void InsertLocalMinima(ClipperLib.LocalMinima newLm) { }
        private System.Boolean PopLocalMinima(System.Int64 Y, ClipperLib.LocalMinima& current) { }
        private System.Void ReverseHorizontal(ClipperLib.TEdge e) { }
        private System.Void Reset() { }
        private ClipperLib.IntRect GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> paths) { }
        private System.Void InsertScanbeam(System.Int64 Y) { }
        private System.Boolean PopScanbeam(System.Int64& Y) { }
        private System.Boolean LocalMinimaPending() { }
        private ClipperLib.OutRec CreateOutRec() { }
        private System.Void DisposeOutRec(System.Int32 index) { }
        private System.Void UpdateEdgeIntoAEL(ClipperLib.TEdge& e) { }
        private System.Void SwapPositionsInAEL(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2) { }
        private System.Void DeleteFromAEL(ClipperLib.TEdge e) { }

    }

    // TypeToken: 0x2000018
    public class Clipper : ClipperBase
    {
        // Fields
        private ClipperLib.ClipType m_ClipType;        // 0x48
        private ClipperLib.Maxima m_Maxima;        // 0x50
        private ClipperLib.TEdge m_SortedEdges;        // 0x58
        private System.Collections.Generic.List<ClipperLib.IntersectNode> m_IntersectList;        // 0x60
        private System.Collections.Generic.IComparer<ClipperLib.IntersectNode> m_IntersectNodeComparer;        // 0x68
        private System.Boolean m_ExecuteLocked;        // 0x70
        private ClipperLib.PolyFillType m_ClipFillType;        // 0x74
        private ClipperLib.PolyFillType m_SubjFillType;        // 0x78
        private System.Collections.Generic.List<ClipperLib.Join> m_Joins;        // 0x80
        private System.Collections.Generic.List<ClipperLib.Join> m_GhostJoins;        // 0x88
        private System.Boolean m_UsingPolyTree;        // 0x90
        private System.Boolean <ReverseSolution>k__BackingField;        // 0x91
        private System.Boolean <StrictlySimple>k__BackingField;        // 0x92

        // Methods
        private System.Void .ctor(System.Int32 InitOptions) { }
        private System.Void InsertMaxima(System.Int64 X) { }
        private System.Boolean get_ReverseSolution() { }
        private System.Void set_ReverseSolution(System.Boolean value) { }
        private System.Boolean get_StrictlySimple() { }
        private System.Void set_StrictlySimple(System.Boolean value) { }
        private System.Boolean Execute(ClipperLib.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> solution, ClipperLib.PolyFillType subjFillType, ClipperLib.PolyFillType clipFillType) { }
        private System.Boolean ExecuteInternal() { }
        private System.Void DisposeAllPolyPts() { }
        private System.Void AddJoin(ClipperLib.OutPt Op1, ClipperLib.OutPt Op2, ClipperLib.IntPoint OffPt) { }
        private System.Void AddGhostJoin(ClipperLib.OutPt Op, ClipperLib.IntPoint OffPt) { }
        private System.Void InsertLocalMinimaIntoAEL(System.Int64 botY) { }
        private System.Void InsertEdgeIntoAEL(ClipperLib.TEdge edge, ClipperLib.TEdge startEdge) { }
        private System.Boolean E2InsertsBeforeE1(ClipperLib.TEdge e1, ClipperLib.TEdge e2) { }
        private System.Boolean IsEvenOddFillType(ClipperLib.TEdge edge) { }
        private System.Boolean IsEvenOddAltFillType(ClipperLib.TEdge edge) { }
        private System.Boolean IsContributing(ClipperLib.TEdge edge) { }
        private System.Void SetWindingCount(ClipperLib.TEdge edge) { }
        private System.Void AddEdgeToSEL(ClipperLib.TEdge edge) { }
        private System.Boolean PopEdgeFromSEL(ClipperLib.TEdge& e) { }
        private System.Void CopyAELToSEL() { }
        private System.Void SwapPositionsInSEL(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2) { }
        private System.Void AddLocalMaxPoly(ClipperLib.TEdge e1, ClipperLib.TEdge e2, ClipperLib.IntPoint pt) { }
        private ClipperLib.OutPt AddLocalMinPoly(ClipperLib.TEdge e1, ClipperLib.TEdge e2, ClipperLib.IntPoint pt) { }
        private ClipperLib.OutPt AddOutPt(ClipperLib.TEdge e, ClipperLib.IntPoint pt) { }
        private ClipperLib.OutPt GetLastOutPt(ClipperLib.TEdge e) { }
        private System.Boolean HorzSegmentsOverlap(System.Int64 seg1a, System.Int64 seg1b, System.Int64 seg2a, System.Int64 seg2b) { }
        private System.Void SetHoleState(ClipperLib.TEdge e, ClipperLib.OutRec outRec) { }
        private System.Double GetDx(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2) { }
        private System.Boolean FirstIsBottomPt(ClipperLib.OutPt btmPt1, ClipperLib.OutPt btmPt2) { }
        private ClipperLib.OutPt GetBottomPt(ClipperLib.OutPt pp) { }
        private ClipperLib.OutRec GetLowermostRec(ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2) { }
        private System.Boolean OutRec1RightOfOutRec2(ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2) { }
        private ClipperLib.OutRec GetOutRec(System.Int32 idx) { }
        private System.Void AppendPolygon(ClipperLib.TEdge e1, ClipperLib.TEdge e2) { }
        private System.Void ReversePolyPtLinks(ClipperLib.OutPt pp) { }
        private System.Void SwapSides(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2) { }
        private System.Void SwapPolyIndexes(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2) { }
        private System.Void IntersectEdges(ClipperLib.TEdge e1, ClipperLib.TEdge e2, ClipperLib.IntPoint pt) { }
        private System.Void ProcessHorizontals() { }
        private System.Void GetHorzDirection(ClipperLib.TEdge HorzEdge, ClipperLib.Direction& Dir, System.Int64& Left, System.Int64& Right) { }
        private System.Void ProcessHorizontal(ClipperLib.TEdge horzEdge) { }
        private ClipperLib.TEdge GetNextInAEL(ClipperLib.TEdge e, ClipperLib.Direction Direction) { }
        private System.Boolean IsMaxima(ClipperLib.TEdge e, System.Double Y) { }
        private System.Boolean IsIntermediate(ClipperLib.TEdge e, System.Double Y) { }
        private ClipperLib.TEdge GetMaximaPair(ClipperLib.TEdge e) { }
        private ClipperLib.TEdge GetMaximaPairEx(ClipperLib.TEdge e) { }
        private System.Boolean ProcessIntersections(System.Int64 topY) { }
        private System.Void BuildIntersectList(System.Int64 topY) { }
        private System.Boolean EdgesAdjacent(ClipperLib.IntersectNode inode) { }
        private System.Boolean FixupIntersectionOrder() { }
        private System.Void ProcessIntersectList() { }
        private System.Int64 Round(System.Double value) { }
        private System.Int64 TopX(ClipperLib.TEdge edge, System.Int64 currentY) { }
        private System.Void IntersectPoint(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2, ClipperLib.IntPoint& ip) { }
        private System.Void ProcessEdgesAtTopOfScanbeam(System.Int64 topY) { }
        private System.Void DoMaxima(ClipperLib.TEdge e) { }
        private System.Boolean Orientation(System.Collections.Generic.List<ClipperLib.IntPoint> poly) { }
        private System.Int32 PointCount(ClipperLib.OutPt pts) { }
        private System.Void BuildResult(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> polyg) { }
        private System.Void FixupOutPolyline(ClipperLib.OutRec outrec) { }
        private System.Void FixupOutPolygon(ClipperLib.OutRec outRec) { }
        private ClipperLib.OutPt DupOutPt(ClipperLib.OutPt outPt, System.Boolean InsertAfter) { }
        private System.Boolean GetOverlap(System.Int64 a1, System.Int64 a2, System.Int64 b1, System.Int64 b2, System.Int64& Left, System.Int64& Right) { }
        private System.Boolean JoinHorz(ClipperLib.OutPt op1, ClipperLib.OutPt op1b, ClipperLib.OutPt op2, ClipperLib.OutPt op2b, ClipperLib.IntPoint Pt, System.Boolean DiscardLeft) { }
        private System.Boolean JoinPoints(ClipperLib.Join j, ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2) { }
        private System.Int32 PointInPolygon(ClipperLib.IntPoint pt, System.Collections.Generic.List<ClipperLib.IntPoint> path) { }
        private System.Int32 PointInPolygon(ClipperLib.IntPoint pt, ClipperLib.OutPt op) { }
        private System.Boolean Poly2ContainsPoly1(ClipperLib.OutPt outPt1, ClipperLib.OutPt outPt2) { }
        private System.Void FixupFirstLefts1(ClipperLib.OutRec OldOutRec, ClipperLib.OutRec NewOutRec) { }
        private System.Void FixupFirstLefts2(ClipperLib.OutRec innerOutRec, ClipperLib.OutRec outerOutRec) { }
        private System.Void FixupFirstLefts3(ClipperLib.OutRec OldOutRec, ClipperLib.OutRec NewOutRec) { }
        private ClipperLib.OutRec ParseFirstLeft(ClipperLib.OutRec FirstLeft) { }
        private System.Void JoinCommonEdges() { }
        private System.Void UpdateOutPtIdxs(ClipperLib.OutRec outrec) { }
        private System.Void DoSimplePolygons() { }
        private System.Double Area(System.Collections.Generic.List<ClipperLib.IntPoint> poly) { }
        private System.Double Area(ClipperLib.OutRec outRec) { }
        private System.Double Area(ClipperLib.OutPt op) { }

    }

    // TypeToken: 0x2000019
    public class ClipperOffset
    {
        // Fields
        private System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_destPolys;        // 0x10
        private System.Collections.Generic.List<ClipperLib.IntPoint> m_srcPoly;        // 0x18
        private System.Collections.Generic.List<ClipperLib.IntPoint> m_destPoly;        // 0x20
        private System.Collections.Generic.List<ClipperLib.DoublePoint> m_normals;        // 0x28
        private System.Double m_delta;        // 0x30
        private System.Double m_sinA;        // 0x38
        private System.Double m_sin;        // 0x40
        private System.Double m_cos;        // 0x48
        private System.Double m_miterLim;        // 0x50
        private System.Double m_StepsPerRad;        // 0x58
        private ClipperLib.IntPoint m_lowest;        // 0x60
        private ClipperLib.PolyNode m_polyNodes;        // 0x70
        private System.Double <ArcTolerance>k__BackingField;        // 0x78
        private System.Double <MiterLimit>k__BackingField;        // 0x80
        private static System.Double two_pi;        // 0x0
        private static System.Double def_arc_tolerance;        // 0x0

        // Methods
        private System.Double get_ArcTolerance() { }
        private System.Void set_ArcTolerance(System.Double value) { }
        private System.Double get_MiterLimit() { }
        private System.Void set_MiterLimit(System.Double value) { }
        private System.Void .ctor(System.Double miterLimit, System.Double arcTolerance) { }
        private System.Void Clear() { }
        private System.Int64 Round(System.Double value) { }
        private System.Void AddPath(System.Collections.Generic.List<ClipperLib.IntPoint> path, ClipperLib.JoinType joinType, ClipperLib.EndType endType) { }
        private System.Void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> paths, ClipperLib.JoinType joinType, ClipperLib.EndType endType) { }
        private System.Void FixOrientations() { }
        private ClipperLib.DoublePoint GetUnitNormal(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2) { }
        private System.Void DoOffset(System.Double delta) { }
        private System.Void Execute(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>& solution, System.Double delta) { }
        private System.Void OffsetPoint(System.Int32 j, System.Int32& k, ClipperLib.JoinType jointype) { }
        private System.Void DoSquare(System.Int32 j, System.Int32 k) { }
        private System.Void DoMiter(System.Int32 j, System.Int32 k, System.Double r) { }
        private System.Void DoRound(System.Int32 j, System.Int32 k) { }

    }

    // TypeToken: 0x200001A
    public class ClipperException : Exception
    {
        // Methods
        private System.Void .ctor(System.String description) { }

    }

}

