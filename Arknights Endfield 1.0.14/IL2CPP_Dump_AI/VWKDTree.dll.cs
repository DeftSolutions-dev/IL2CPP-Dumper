// ========================================================
// Dumped by @desirepro
// Assembly: VWKDTree.dll
// Classes:  13
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: DataStructures.ViliWonka.Heap.BaseHeap
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  protected         System.Int32                    nodesCount  // 0x10
  protected         System.Int32                    maxSize  // 0x14
  protected         System.Single[]                 heap  // 0x18
  protected         System.Single                   tempHeap  // 0x20
METHODS:
  System.Void .ctor(System.Int32 initialSize)
  System.Int32 get_Count()
  System.Single get_HeadValue()
  System.Void Clear()
  System.Int32 Parent(System.Int32 index)
  System.Int32 Left(System.Int32 index)
  System.Int32 Right(System.Int32 index)
  System.Void BubbleDownMax(System.Int32 index)
  System.Void BubbleUpMax(System.Int32 index)
  System.Void BubbleDownMin(System.Int32 index)
  System.Void BubbleUpMin(System.Int32 index)
  System.Void Swap(System.Int32 A, System.Int32 B)
  System.Void UpsizeHeap()
  System.Void PushValue(System.Single h)
  System.Single PopValue()
  System.Void FlushHeapResult(System.Collections.Generic.List<System.Single> heapList)
END_CLASS

CLASS: DataStructures.ViliWonka.Heap.KSmallestHeap
TYPE:  class
TOKEN: 0x2000008
EXTENDS: BaseHeap
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 maxEntries)
  System.Boolean get_Full()
  System.Void PushValue(System.Single h)
  System.Single PopValue()
  System.Void Print()
  System.Boolean HeapPropertyHolds(System.Int32 index, System.Int32 depth)
END_CLASS

CLASS: DataStructures.ViliWonka.Heap.KSmallestHeap`1
TYPE:  class
TOKEN: 0x2000009
EXTENDS: KSmallestHeap
FIELDS:
  private           T[]                             objs  // 0x0
  private           T                               tempObjs  // 0x0
METHODS:
  System.Void .ctor(System.Int32 maxEntries)
  T get_HeadHeapObject()
  System.Void Swap(System.Int32 A, System.Int32 B)
  System.Void PushValue(System.Single h)
  System.Void PushObj(T obj, System.Single h)
  System.Single PopValue()
  T PopObj()
  T PopObj(System.Single& heapValue)
  System.Void FlushResult(System.Collections.Generic.List<T> resultList, System.Collections.Generic.List<System.Single> heapList)
END_CLASS

CLASS: DataStructures.ViliWonka.Heap.MaxHeap
TYPE:  class
TOKEN: 0x200000A
EXTENDS: BaseHeap
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 initialSize)
  System.Void PushValue(System.Single h)
  System.Single PopValue()
END_CLASS

CLASS: DataStructures.ViliWonka.Heap.MaxHeap`1
TYPE:  class
TOKEN: 0x200000B
EXTENDS: MaxHeap
FIELDS:
  private           T[]                             objs  // 0x0
  private           T                               tempObjs  // 0x0
METHODS:
  System.Void .ctor(System.Int32 maxNodes)
  T get_HeadHeapObject()
  System.Void Swap(System.Int32 A, System.Int32 B)
  System.Void PushValue(System.Single h)
  System.Single PopValue()
  System.Void PushObj(T obj, System.Single h)
  T PopObj()
  T PopObj(System.Single& heapValue)
  System.Void UpsizeHeap()
  System.Void FlushResult(System.Collections.Generic.List<T> resultList, System.Collections.Generic.List<System.Single> heapList)
END_CLASS

CLASS: DataStructures.ViliWonka.Heap.MinHeap
TYPE:  class
TOKEN: 0x200000C
EXTENDS: BaseHeap
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 initialSize)
  System.Void PushValue(System.Single h)
  System.Single PopValue()
END_CLASS

CLASS: DataStructures.ViliWonka.Heap.MinHeap`1
TYPE:  class
TOKEN: 0x200000D
EXTENDS: MinHeap
FIELDS:
  private           T[]                             objs  // 0x0
  private           T                               tempObjs  // 0x0
METHODS:
  System.Void .ctor(System.Int32 maxNodes)
  T get_HeadHeapObject()
  System.Void Swap(System.Int32 A, System.Int32 B)
  System.Void PushValue(System.Single h)
  System.Single PopValue()
  System.Void PushObj(T obj, System.Single h)
  T PopObj()
  T PopObj(System.Single& heapValue)
  System.Void UpsizeHeap()
  System.Void FlushResult(System.Collections.Generic.List<T> resultList, System.Collections.Generic.List<System.Single> heapList)
END_CLASS

CLASS: DataStructures.ViliWonka.KDTree.KDBounds
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            UnityEngine.Vector3             min  // 0x10
  public            UnityEngine.Vector3             max  // 0x1C
METHODS:
  UnityEngine.Vector3 get_size()
  UnityEngine.Bounds get_Bounds()
  UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point)
END_CLASS

CLASS: DataStructures.ViliWonka.KDTree.KDNode
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  public            System.Single                   partitionCoordinate  // 0x10
  public            System.Int32                    partitionAxis  // 0x14
  public            DataStructures.ViliWonka.KDTree.KDNodenegativeChild  // 0x18
  public            DataStructures.ViliWonka.KDTree.KDNodepositiveChild  // 0x20
  public            System.Int32                    start  // 0x28
  public            System.Int32                    end  // 0x2C
  public            DataStructures.ViliWonka.KDTree.KDBoundsbounds  // 0x30
METHODS:
  System.Int32 get_Count()
  System.Boolean get_Leaf()
  System.Void .ctor()
END_CLASS

CLASS: DataStructures.ViliWonka.KDTree.KDQuery
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  protected         DataStructures.ViliWonka.KDTree.KDQueryNode[]queueArray  // 0x10
  protected         DataStructures.ViliWonka.Heap.MinHeap<DataStructures.ViliWonka.KDTree.KDQueryNode>minHeap  // 0x18
  protected         System.Int32                    count  // 0x20
  protected         System.Int32                    queryIndex  // 0x24
  private           System.Collections.Generic.SortedList<System.Int32,DataStructures.ViliWonka.Heap.KSmallestHeap<System.Int32>>_heaps  // 0x28
METHODS:
  DataStructures.ViliWonka.KDTree.KDQueryNode PushGetQueue()
  System.Void PushToQueue(DataStructures.ViliWonka.KDTree.KDNode node, UnityEngine.Vector3 tempClosestPoint)
  System.Void PushToHeap(DataStructures.ViliWonka.KDTree.KDNode node, UnityEngine.Vector3 tempClosestPoint, UnityEngine.Vector3 queryPosition)
  System.Int32 get_LeftToProcess()
  DataStructures.ViliWonka.KDTree.KDQueryNode PopFromQueue()
  DataStructures.ViliWonka.KDTree.KDQueryNode PopFromHeap()
  System.Void Reset()
  System.Void .ctor(System.Int32 queryNodesContainersInitialSize)
  System.Void DrawLastQuery()
  System.Void ClosestPoint(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 queryPosition, System.Collections.Generic.List<System.Int32> resultIndices, System.Collections.Generic.List<System.Single> resultDistances)
  System.Void Interval(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 min, UnityEngine.Vector3 max, System.Collections.Generic.List<System.Int32> resultIndices)
  System.Void KNearest(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 queryPosition, System.Int32 k, System.Collections.Generic.List<System.Int32> resultIndices, System.Collections.Generic.List<System.Single> resultDistances)
  System.Void Radius(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 queryPosition, System.Single queryRadius, System.Collections.Generic.List<System.Int32> resultIndices)
END_CLASS

CLASS: DataStructures.ViliWonka.KDTree.KDQueryNode
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  public            DataStructures.ViliWonka.KDTree.KDNodenode  // 0x10
  public            UnityEngine.Vector3             tempClosestPoint  // 0x18
  public            System.Single                   distance  // 0x24
METHODS:
  System.Void .ctor()
  System.Void .ctor(DataStructures.ViliWonka.KDTree.KDNode node, UnityEngine.Vector3 tempClosestPoint)
END_CLASS

CLASS: DataStructures.ViliWonka.KDTree.KDTree
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  private           DataStructures.ViliWonka.KDTree.KDNode<RootNode>k__BackingField  // 0x10
  private           UnityEngine.Vector3[]           points  // 0x18
  private           System.Int32[]                  permutation  // 0x20
  private           System.Int32                    <Count>k__BackingField  // 0x28
  private           System.Int32                    maxPointsPerLeafNode  // 0x2C
  private           DataStructures.ViliWonka.KDTree.KDNode[]kdNodesStack  // 0x30
  private           System.Int32                    kdNodesCount  // 0x38
METHODS:
  DataStructures.ViliWonka.KDTree.KDNode get_RootNode()
  System.Void set_RootNode(DataStructures.ViliWonka.KDTree.KDNode value)
  UnityEngine.Vector3[] get_Points()
  System.Int32[] get_Permutation()
  System.Int32 get_Count()
  System.Void set_Count(System.Int32 value)
  System.Void .ctor(System.Int32 maxPointsPerLeafNode)
  System.Void .ctor(UnityEngine.Vector3[] points, System.Int32 maxPointsPerLeafNode)
  System.Void Build(UnityEngine.Vector3[] newPoints, System.Int32 maxPointsPerLeafNode)
  System.Void Build(System.Collections.Generic.List<UnityEngine.Vector3> newPoints, System.Int32 maxPointsPerLeafNode)
  System.Void Rebuild(System.Int32 maxPointsPerLeafNode)
  System.Void SetCount(System.Int32 newSize)
  System.Void BuildTree()
  DataStructures.ViliWonka.KDTree.KDNode GetKDNode()
  System.Void ResetKDNodeStack()
  DataStructures.ViliWonka.KDTree.KDBounds MakeBounds()
  System.Void SplitNode(DataStructures.ViliWonka.KDTree.KDNode parent)
  System.Single CalculatePivot(System.Int32 start, System.Int32 end, System.Single boundsStart, System.Single boundsEnd, System.Int32 axis)
  System.Int32 Partition(System.Int32 start, System.Int32 end, System.Single partitionPivot, System.Int32 axis)
  System.Boolean ContinueSplit(DataStructures.ViliWonka.KDTree.KDNode node)
END_CLASS

