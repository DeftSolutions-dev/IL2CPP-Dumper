// ========================================================
// Dumped by @desirepro
// Assembly: clipper_library.dll
// Classes:  26
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: ClipperLib.DoublePoint
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            System.Double                   X  // 0x10
  public            System.Double                   Y  // 0x18
METHODS:
  System.Void .ctor(System.Double x, System.Double y)
  System.Void .ctor(ClipperLib.DoublePoint dp)
END_CLASS

CLASS: ClipperLib.PolyNode
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           ClipperLib.PolyNode             m_Parent  // 0x10
  private           System.Collections.Generic.List<ClipperLib.IntPoint>m_polygon  // 0x18
  private           System.Int32                    m_Index  // 0x20
  private           ClipperLib.JoinType             m_jointype  // 0x24
  private           ClipperLib.EndType              m_endtype  // 0x28
  private           System.Collections.Generic.List<ClipperLib.PolyNode>m_Childs  // 0x30
  private           System.Boolean                  <IsOpen>k__BackingField  // 0x38
METHODS:
  System.Int32 get_ChildCount()
  System.Void AddChild(ClipperLib.PolyNode Child)
  System.Collections.Generic.List<ClipperLib.PolyNode> get_Childs()
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.Int128
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  private           System.Int64                    hi  // 0x10
  private           System.UInt64                   lo  // 0x18
METHODS:
  System.Void .ctor(System.Int64 _hi, System.UInt64 _lo)
  System.Boolean op_Equality(ClipperLib.Int128 val1, ClipperLib.Int128 val2)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  ClipperLib.Int128 op_UnaryNegation(ClipperLib.Int128 val)
  ClipperLib.Int128 Int128Mul(System.Int64 lhs, System.Int64 rhs)
END_CLASS

CLASS: ClipperLib.IntPoint
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int64                    X  // 0x10
  public            System.Int64                    Y  // 0x18
METHODS:
  System.Void .ctor(System.Int64 X, System.Int64 Y)
  System.Void .ctor(System.Double x, System.Double y)
  System.Void .ctor(ClipperLib.IntPoint pt)
  System.Boolean op_Equality(ClipperLib.IntPoint a, ClipperLib.IntPoint b)
  System.Boolean op_Inequality(ClipperLib.IntPoint a, ClipperLib.IntPoint b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: ClipperLib.IntRect
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int64                    left  // 0x10
  public            System.Int64                    top  // 0x18
  public            System.Int64                    right  // 0x20
  public            System.Int64                    bottom  // 0x28
METHODS:
  System.Void .ctor(System.Int64 l, System.Int64 t, System.Int64 r, System.Int64 b)
END_CLASS

CLASS: ClipperLib.ClipType
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.ClipType             ctIntersection  // 0x0
  public    static  ClipperLib.ClipType             ctUnion  // 0x0
  public    static  ClipperLib.ClipType             ctDifference  // 0x0
  public    static  ClipperLib.ClipType             ctXor  // 0x0
METHODS:
END_CLASS

CLASS: ClipperLib.PolyType
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.PolyType             ptSubject  // 0x0
  public    static  ClipperLib.PolyType             ptClip  // 0x0
METHODS:
END_CLASS

CLASS: ClipperLib.PolyFillType
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.PolyFillType         pftEvenOdd  // 0x0
  public    static  ClipperLib.PolyFillType         pftNonZero  // 0x0
  public    static  ClipperLib.PolyFillType         pftPositive  // 0x0
  public    static  ClipperLib.PolyFillType         pftNegative  // 0x0
METHODS:
END_CLASS

CLASS: ClipperLib.JoinType
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.JoinType             jtSquare  // 0x0
  public    static  ClipperLib.JoinType             jtRound  // 0x0
  public    static  ClipperLib.JoinType             jtMiter  // 0x0
METHODS:
END_CLASS

CLASS: ClipperLib.EndType
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.EndType              etClosedPolygon  // 0x0
  public    static  ClipperLib.EndType              etClosedLine  // 0x0
  public    static  ClipperLib.EndType              etOpenButt  // 0x0
  public    static  ClipperLib.EndType              etOpenSquare  // 0x0
  public    static  ClipperLib.EndType              etOpenRound  // 0x0
METHODS:
END_CLASS

CLASS: ClipperLib.EdgeSide
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.EdgeSide             esLeft  // 0x0
  public    static  ClipperLib.EdgeSide             esRight  // 0x0
METHODS:
END_CLASS

CLASS: ClipperLib.Direction
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.Direction            dRightToLeft  // 0x0
  public    static  ClipperLib.Direction            dLeftToRight  // 0x0
METHODS:
END_CLASS

CLASS: ClipperLib.TEdge
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private           ClipperLib.IntPoint             Bot  // 0x10
  private           ClipperLib.IntPoint             Curr  // 0x20
  private           ClipperLib.IntPoint             Top  // 0x30
  private           ClipperLib.IntPoint             Delta  // 0x40
  private           System.Double                   Dx  // 0x50
  private           ClipperLib.PolyType             PolyTyp  // 0x58
  private           ClipperLib.EdgeSide             Side  // 0x5C
  private           System.Int32                    WindDelta  // 0x60
  private           System.Int32                    WindCnt  // 0x64
  private           System.Int32                    WindCnt2  // 0x68
  private           System.Int32                    OutIdx  // 0x6C
  private           ClipperLib.TEdge                Next  // 0x70
  private           ClipperLib.TEdge                Prev  // 0x78
  private           ClipperLib.TEdge                NextInLML  // 0x80
  private           ClipperLib.TEdge                NextInAEL  // 0x88
  private           ClipperLib.TEdge                PrevInAEL  // 0x90
  private           ClipperLib.TEdge                NextInSEL  // 0x98
  private           ClipperLib.TEdge                PrevInSEL  // 0xA0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.IntersectNode
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private           ClipperLib.TEdge                Edge1  // 0x10
  private           ClipperLib.TEdge                Edge2  // 0x18
  private           ClipperLib.IntPoint             Pt  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.MyIntersectNodeSort
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Int32 Compare(ClipperLib.IntersectNode node1, ClipperLib.IntersectNode node2)
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.LocalMinima
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           System.Int64                    Y  // 0x10
  private           ClipperLib.TEdge                LeftBound  // 0x18
  private           ClipperLib.TEdge                RightBound  // 0x20
  private           ClipperLib.LocalMinima          Next  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.Scanbeam
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private           System.Int64                    Y  // 0x10
  private           ClipperLib.Scanbeam             Next  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.Maxima
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private           System.Int64                    X  // 0x10
  private           ClipperLib.Maxima               Next  // 0x18
  private           ClipperLib.Maxima               Prev  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.OutRec
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private           System.Int32                    Idx  // 0x10
  private           System.Boolean                  IsHole  // 0x14
  private           System.Boolean                  IsOpen  // 0x15
  private           ClipperLib.OutRec               FirstLeft  // 0x18
  private           ClipperLib.OutPt                Pts  // 0x20
  private           ClipperLib.OutPt                BottomPt  // 0x28
  private           ClipperLib.PolyNode             PolyNode  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.OutPt
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private           System.Int32                    Idx  // 0x10
  private           ClipperLib.IntPoint             Pt  // 0x18
  private           ClipperLib.OutPt                Next  // 0x28
  private           ClipperLib.OutPt                Prev  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.Join
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           ClipperLib.OutPt                OutPt1  // 0x10
  private           ClipperLib.OutPt                OutPt2  // 0x18
  private           ClipperLib.IntPoint             OffPt  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.ClipperBase
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private           ClipperLib.LocalMinima          m_MinimaList  // 0x10
  private           ClipperLib.LocalMinima          m_CurrentLM  // 0x18
  private           System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.TEdge>>m_edges  // 0x20
  private           ClipperLib.Scanbeam             m_Scanbeam  // 0x28
  private           System.Collections.Generic.List<ClipperLib.OutRec>m_PolyOuts  // 0x30
  private           ClipperLib.TEdge                m_ActiveEdges  // 0x38
  private           System.Boolean                  m_UseFullRange  // 0x40
  private           System.Boolean                  m_HasOpenPaths  // 0x41
  private           System.Boolean                  <PreserveCollinear>k__BackingField  // 0x42
METHODS:
  System.Boolean near_zero(System.Double val)
  System.Boolean get_PreserveCollinear()
  System.Void set_PreserveCollinear(System.Boolean value)
  System.Void Swap(System.Int64& val1, System.Int64& val2)
  System.Boolean IsHorizontal(ClipperLib.TEdge e)
  System.Boolean SlopesEqual(ClipperLib.TEdge e1, ClipperLib.TEdge e2, System.Boolean UseFullRange)
  System.Boolean SlopesEqual(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2, ClipperLib.IntPoint pt3, System.Boolean UseFullRange)
  System.Boolean SlopesEqual(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2, ClipperLib.IntPoint pt3, ClipperLib.IntPoint pt4, System.Boolean UseFullRange)
  System.Void .ctor()
  System.Void Clear()
  System.Void DisposeLocalMinimaList()
  System.Void RangeTest(ClipperLib.IntPoint Pt, System.Boolean& useFullRange)
  System.Void InitEdge(ClipperLib.TEdge e, ClipperLib.TEdge eNext, ClipperLib.TEdge ePrev, ClipperLib.IntPoint pt)
  System.Void InitEdge2(ClipperLib.TEdge e, ClipperLib.PolyType polyType)
  ClipperLib.TEdge FindNextLocMin(ClipperLib.TEdge E)
  ClipperLib.TEdge ProcessBound(ClipperLib.TEdge E, System.Boolean LeftBoundIsForward)
  System.Boolean AddPath(System.Collections.Generic.List<ClipperLib.IntPoint> pg, ClipperLib.PolyType polyType, System.Boolean Closed)
  System.Boolean AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> ppg, ClipperLib.PolyType polyType, System.Boolean closed)
  System.Boolean Pt2IsBetweenPt1AndPt3(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2, ClipperLib.IntPoint pt3)
  ClipperLib.TEdge RemoveEdge(ClipperLib.TEdge e)
  System.Void SetDx(ClipperLib.TEdge e)
  System.Void InsertLocalMinima(ClipperLib.LocalMinima newLm)
  System.Boolean PopLocalMinima(System.Int64 Y, ClipperLib.LocalMinima& current)
  System.Void ReverseHorizontal(ClipperLib.TEdge e)
  System.Void Reset()
  ClipperLib.IntRect GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> paths)
  System.Void InsertScanbeam(System.Int64 Y)
  System.Boolean PopScanbeam(System.Int64& Y)
  System.Boolean LocalMinimaPending()
  ClipperLib.OutRec CreateOutRec()
  System.Void DisposeOutRec(System.Int32 index)
  System.Void UpdateEdgeIntoAEL(ClipperLib.TEdge& e)
  System.Void SwapPositionsInAEL(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
  System.Void DeleteFromAEL(ClipperLib.TEdge e)
END_CLASS

CLASS: ClipperLib.Clipper
TYPE:  class
TOKEN: 0x2000018
EXTENDS: ClipperBase
FIELDS:
  private           ClipperLib.ClipType             m_ClipType  // 0x48
  private           ClipperLib.Maxima               m_Maxima  // 0x50
  private           ClipperLib.TEdge                m_SortedEdges  // 0x58
  private           System.Collections.Generic.List<ClipperLib.IntersectNode>m_IntersectList  // 0x60
  private           System.Collections.Generic.IComparer<ClipperLib.IntersectNode>m_IntersectNodeComparer  // 0x68
  private           System.Boolean                  m_ExecuteLocked  // 0x70
  private           ClipperLib.PolyFillType         m_ClipFillType  // 0x74
  private           ClipperLib.PolyFillType         m_SubjFillType  // 0x78
  private           System.Collections.Generic.List<ClipperLib.Join>m_Joins  // 0x80
  private           System.Collections.Generic.List<ClipperLib.Join>m_GhostJoins  // 0x88
  private           System.Boolean                  m_UsingPolyTree  // 0x90
  private           System.Boolean                  <ReverseSolution>k__BackingField  // 0x91
  private           System.Boolean                  <StrictlySimple>k__BackingField  // 0x92
METHODS:
  System.Void .ctor(System.Int32 InitOptions)
  System.Void InsertMaxima(System.Int64 X)
  System.Boolean get_ReverseSolution()
  System.Void set_ReverseSolution(System.Boolean value)
  System.Boolean get_StrictlySimple()
  System.Void set_StrictlySimple(System.Boolean value)
  System.Boolean Execute(ClipperLib.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> solution, ClipperLib.PolyFillType subjFillType, ClipperLib.PolyFillType clipFillType)
  System.Boolean ExecuteInternal()
  System.Void DisposeAllPolyPts()
  System.Void AddJoin(ClipperLib.OutPt Op1, ClipperLib.OutPt Op2, ClipperLib.IntPoint OffPt)
  System.Void AddGhostJoin(ClipperLib.OutPt Op, ClipperLib.IntPoint OffPt)
  System.Void InsertLocalMinimaIntoAEL(System.Int64 botY)
  System.Void InsertEdgeIntoAEL(ClipperLib.TEdge edge, ClipperLib.TEdge startEdge)
  System.Boolean E2InsertsBeforeE1(ClipperLib.TEdge e1, ClipperLib.TEdge e2)
  System.Boolean IsEvenOddFillType(ClipperLib.TEdge edge)
  System.Boolean IsEvenOddAltFillType(ClipperLib.TEdge edge)
  System.Boolean IsContributing(ClipperLib.TEdge edge)
  System.Void SetWindingCount(ClipperLib.TEdge edge)
  System.Void AddEdgeToSEL(ClipperLib.TEdge edge)
  System.Boolean PopEdgeFromSEL(ClipperLib.TEdge& e)
  System.Void CopyAELToSEL()
  System.Void SwapPositionsInSEL(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
  System.Void AddLocalMaxPoly(ClipperLib.TEdge e1, ClipperLib.TEdge e2, ClipperLib.IntPoint pt)
  ClipperLib.OutPt AddLocalMinPoly(ClipperLib.TEdge e1, ClipperLib.TEdge e2, ClipperLib.IntPoint pt)
  ClipperLib.OutPt AddOutPt(ClipperLib.TEdge e, ClipperLib.IntPoint pt)
  ClipperLib.OutPt GetLastOutPt(ClipperLib.TEdge e)
  System.Boolean HorzSegmentsOverlap(System.Int64 seg1a, System.Int64 seg1b, System.Int64 seg2a, System.Int64 seg2b)
  System.Void SetHoleState(ClipperLib.TEdge e, ClipperLib.OutRec outRec)
  System.Double GetDx(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2)
  System.Boolean FirstIsBottomPt(ClipperLib.OutPt btmPt1, ClipperLib.OutPt btmPt2)
  ClipperLib.OutPt GetBottomPt(ClipperLib.OutPt pp)
  ClipperLib.OutRec GetLowermostRec(ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2)
  System.Boolean OutRec1RightOfOutRec2(ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2)
  ClipperLib.OutRec GetOutRec(System.Int32 idx)
  System.Void AppendPolygon(ClipperLib.TEdge e1, ClipperLib.TEdge e2)
  System.Void ReversePolyPtLinks(ClipperLib.OutPt pp)
  System.Void SwapSides(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
  System.Void SwapPolyIndexes(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
  System.Void IntersectEdges(ClipperLib.TEdge e1, ClipperLib.TEdge e2, ClipperLib.IntPoint pt)
  System.Void ProcessHorizontals()
  System.Void GetHorzDirection(ClipperLib.TEdge HorzEdge, ClipperLib.Direction& Dir, System.Int64& Left, System.Int64& Right)
  System.Void ProcessHorizontal(ClipperLib.TEdge horzEdge)
  ClipperLib.TEdge GetNextInAEL(ClipperLib.TEdge e, ClipperLib.Direction Direction)
  System.Boolean IsMaxima(ClipperLib.TEdge e, System.Double Y)
  System.Boolean IsIntermediate(ClipperLib.TEdge e, System.Double Y)
  ClipperLib.TEdge GetMaximaPair(ClipperLib.TEdge e)
  ClipperLib.TEdge GetMaximaPairEx(ClipperLib.TEdge e)
  System.Boolean ProcessIntersections(System.Int64 topY)
  System.Void BuildIntersectList(System.Int64 topY)
  System.Boolean EdgesAdjacent(ClipperLib.IntersectNode inode)
  System.Boolean FixupIntersectionOrder()
  System.Void ProcessIntersectList()
  System.Int64 Round(System.Double value)
  System.Int64 TopX(ClipperLib.TEdge edge, System.Int64 currentY)
  System.Void IntersectPoint(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2, ClipperLib.IntPoint& ip)
  System.Void ProcessEdgesAtTopOfScanbeam(System.Int64 topY)
  System.Void DoMaxima(ClipperLib.TEdge e)
  System.Boolean Orientation(System.Collections.Generic.List<ClipperLib.IntPoint> poly)
  System.Int32 PointCount(ClipperLib.OutPt pts)
  System.Void BuildResult(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> polyg)
  System.Void FixupOutPolyline(ClipperLib.OutRec outrec)
  System.Void FixupOutPolygon(ClipperLib.OutRec outRec)
  ClipperLib.OutPt DupOutPt(ClipperLib.OutPt outPt, System.Boolean InsertAfter)
  System.Boolean GetOverlap(System.Int64 a1, System.Int64 a2, System.Int64 b1, System.Int64 b2, System.Int64& Left, System.Int64& Right)
  System.Boolean JoinHorz(ClipperLib.OutPt op1, ClipperLib.OutPt op1b, ClipperLib.OutPt op2, ClipperLib.OutPt op2b, ClipperLib.IntPoint Pt, System.Boolean DiscardLeft)
  System.Boolean JoinPoints(ClipperLib.Join j, ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2)
  System.Int32 PointInPolygon(ClipperLib.IntPoint pt, System.Collections.Generic.List<ClipperLib.IntPoint> path)
  System.Int32 PointInPolygon(ClipperLib.IntPoint pt, ClipperLib.OutPt op)
  System.Boolean Poly2ContainsPoly1(ClipperLib.OutPt outPt1, ClipperLib.OutPt outPt2)
  System.Void FixupFirstLefts1(ClipperLib.OutRec OldOutRec, ClipperLib.OutRec NewOutRec)
  System.Void FixupFirstLefts2(ClipperLib.OutRec innerOutRec, ClipperLib.OutRec outerOutRec)
  System.Void FixupFirstLefts3(ClipperLib.OutRec OldOutRec, ClipperLib.OutRec NewOutRec)
  ClipperLib.OutRec ParseFirstLeft(ClipperLib.OutRec FirstLeft)
  System.Void JoinCommonEdges()
  System.Void UpdateOutPtIdxs(ClipperLib.OutRec outrec)
  System.Void DoSimplePolygons()
  System.Double Area(System.Collections.Generic.List<ClipperLib.IntPoint> poly)
  System.Double Area(ClipperLib.OutRec outRec)
  System.Double Area(ClipperLib.OutPt op)
END_CLASS

CLASS: ClipperLib.ClipperOffset
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private           System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>m_destPolys  // 0x10
  private           System.Collections.Generic.List<ClipperLib.IntPoint>m_srcPoly  // 0x18
  private           System.Collections.Generic.List<ClipperLib.IntPoint>m_destPoly  // 0x20
  private           System.Collections.Generic.List<ClipperLib.DoublePoint>m_normals  // 0x28
  private           System.Double                   m_delta  // 0x30
  private           System.Double                   m_sinA  // 0x38
  private           System.Double                   m_sin  // 0x40
  private           System.Double                   m_cos  // 0x48
  private           System.Double                   m_miterLim  // 0x50
  private           System.Double                   m_StepsPerRad  // 0x58
  private           ClipperLib.IntPoint             m_lowest  // 0x60
  private           ClipperLib.PolyNode             m_polyNodes  // 0x70
  private           System.Double                   <ArcTolerance>k__BackingField  // 0x78
  private           System.Double                   <MiterLimit>k__BackingField  // 0x80
  private   static  System.Double                   two_pi  // 0x0
  private   static  System.Double                   def_arc_tolerance  // 0x0
METHODS:
  System.Double get_ArcTolerance()
  System.Void set_ArcTolerance(System.Double value)
  System.Double get_MiterLimit()
  System.Void set_MiterLimit(System.Double value)
  System.Void .ctor(System.Double miterLimit, System.Double arcTolerance)
  System.Void Clear()
  System.Int64 Round(System.Double value)
  System.Void AddPath(System.Collections.Generic.List<ClipperLib.IntPoint> path, ClipperLib.JoinType joinType, ClipperLib.EndType endType)
  System.Void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> paths, ClipperLib.JoinType joinType, ClipperLib.EndType endType)
  System.Void FixOrientations()
  ClipperLib.DoublePoint GetUnitNormal(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2)
  System.Void DoOffset(System.Double delta)
  System.Void Execute(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>& solution, System.Double delta)
  System.Void OffsetPoint(System.Int32 j, System.Int32& k, ClipperLib.JoinType jointype)
  System.Void DoSquare(System.Int32 j, System.Int32 k)
  System.Void DoMiter(System.Int32 j, System.Int32 k, System.Double r)
  System.Void DoRound(System.Int32 j, System.Int32 k)
END_CLASS

CLASS: ClipperLib.ClipperException
TYPE:  class
TOKEN: 0x200001A
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.String description)
END_CLASS

