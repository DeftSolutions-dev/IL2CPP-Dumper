// ========================================================
// Dumped by @desirepro
// Assembly: VWKDTree.dll
// Classes:  13
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace DataStructures.ViliWonka.Heap
{

    // TypeToken: 0x2000007
    public class BaseHeap
    {
        // Fields
        protected System.Int32 nodesCount;        // 0x10
        protected System.Int32 maxSize;        // 0x14
        protected System.Single[] heap;        // 0x18
        protected System.Single tempHeap;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32 initialSize) { }
        private System.Int32 get_Count() { }
        private System.Single get_HeadValue() { }
        private System.Void Clear() { }
        private System.Int32 Parent(System.Int32 index) { }
        private System.Int32 Left(System.Int32 index) { }
        private System.Int32 Right(System.Int32 index) { }
        private System.Void BubbleDownMax(System.Int32 index) { }
        private System.Void BubbleUpMax(System.Int32 index) { }
        private System.Void BubbleDownMin(System.Int32 index) { }
        private System.Void BubbleUpMin(System.Int32 index) { }
        private System.Void Swap(System.Int32 A, System.Int32 B) { }
        private System.Void UpsizeHeap() { }
        private System.Void PushValue(System.Single h) { }
        private System.Single PopValue() { }
        private System.Void FlushHeapResult(System.Collections.Generic.List<System.Single> heapList) { }

    }

    // TypeToken: 0x2000008
    public class KSmallestHeap : BaseHeap
    {
        // Methods
        private System.Void .ctor(System.Int32 maxEntries) { }
        private System.Boolean get_Full() { }
        private System.Void PushValue(System.Single h) { }
        private System.Single PopValue() { }
        private System.Void Print() { }
        private System.Boolean HeapPropertyHolds(System.Int32 index, System.Int32 depth) { }

    }

    // TypeToken: 0x2000009
    public class KSmallestHeap`1 : KSmallestHeap
    {
        // Fields
        private T[] objs;        // 0x0
        private T tempObjs;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 maxEntries) { }
        private T get_HeadHeapObject() { }
        private System.Void Swap(System.Int32 A, System.Int32 B) { }
        private System.Void PushValue(System.Single h) { }
        private System.Void PushObj(T obj, System.Single h) { }
        private System.Single PopValue() { }
        private T PopObj() { }
        private T PopObj(System.Single& heapValue) { }
        private System.Void FlushResult(System.Collections.Generic.List<T> resultList, System.Collections.Generic.List<System.Single> heapList) { }

    }

    // TypeToken: 0x200000A
    public class MaxHeap : BaseHeap
    {
        // Methods
        private System.Void .ctor(System.Int32 initialSize) { }
        private System.Void PushValue(System.Single h) { }
        private System.Single PopValue() { }

    }

    // TypeToken: 0x200000B
    public class MaxHeap`1 : MaxHeap
    {
        // Fields
        private T[] objs;        // 0x0
        private T tempObjs;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 maxNodes) { }
        private T get_HeadHeapObject() { }
        private System.Void Swap(System.Int32 A, System.Int32 B) { }
        private System.Void PushValue(System.Single h) { }
        private System.Single PopValue() { }
        private System.Void PushObj(T obj, System.Single h) { }
        private T PopObj() { }
        private T PopObj(System.Single& heapValue) { }
        private System.Void UpsizeHeap() { }
        private System.Void FlushResult(System.Collections.Generic.List<T> resultList, System.Collections.Generic.List<System.Single> heapList) { }

    }

    // TypeToken: 0x200000C
    public class MinHeap : BaseHeap
    {
        // Methods
        private System.Void .ctor(System.Int32 initialSize) { }
        private System.Void PushValue(System.Single h) { }
        private System.Single PopValue() { }

    }

    // TypeToken: 0x200000D
    public class MinHeap`1 : MinHeap
    {
        // Fields
        private T[] objs;        // 0x0
        private T tempObjs;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 maxNodes) { }
        private T get_HeadHeapObject() { }
        private System.Void Swap(System.Int32 A, System.Int32 B) { }
        private System.Void PushValue(System.Single h) { }
        private System.Single PopValue() { }
        private System.Void PushObj(T obj, System.Single h) { }
        private T PopObj() { }
        private T PopObj(System.Single& heapValue) { }
        private System.Void UpsizeHeap() { }
        private System.Void FlushResult(System.Collections.Generic.List<T> resultList, System.Collections.Generic.List<System.Single> heapList) { }

    }

}

namespace DataStructures.ViliWonka.KDTree
{

    // TypeToken: 0x2000002
    public struct KDBounds
    {
        // Fields
        public UnityEngine.Vector3 min;        // 0x10
        public UnityEngine.Vector3 max;        // 0x1C

        // Methods
        private UnityEngine.Vector3 get_size() { }
        private UnityEngine.Bounds get_Bounds() { }
        private UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point) { }

    }

    // TypeToken: 0x2000003
    public class KDNode
    {
        // Fields
        public System.Single partitionCoordinate;        // 0x10
        public System.Int32 partitionAxis;        // 0x14
        public DataStructures.ViliWonka.KDTree.KDNode negativeChild;        // 0x18
        public DataStructures.ViliWonka.KDTree.KDNode positiveChild;        // 0x20
        public System.Int32 start;        // 0x28
        public System.Int32 end;        // 0x2C
        public DataStructures.ViliWonka.KDTree.KDBounds bounds;        // 0x30

        // Methods
        private System.Int32 get_Count() { }
        private System.Boolean get_Leaf() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class KDQuery
    {
        // Fields
        protected DataStructures.ViliWonka.KDTree.KDQueryNode[] queueArray;        // 0x10
        protected DataStructures.ViliWonka.Heap.MinHeap<DataStructures.ViliWonka.KDTree.KDQueryNode> minHeap;        // 0x18
        protected System.Int32 count;        // 0x20
        protected System.Int32 queryIndex;        // 0x24
        private System.Collections.Generic.SortedList<System.Int32,DataStructures.ViliWonka.Heap.KSmallestHeap<System.Int32>> _heaps;        // 0x28

        // Methods
        private DataStructures.ViliWonka.KDTree.KDQueryNode PushGetQueue() { }
        private System.Void PushToQueue(DataStructures.ViliWonka.KDTree.KDNode node, UnityEngine.Vector3 tempClosestPoint) { }
        private System.Void PushToHeap(DataStructures.ViliWonka.KDTree.KDNode node, UnityEngine.Vector3 tempClosestPoint, UnityEngine.Vector3 queryPosition) { }
        private System.Int32 get_LeftToProcess() { }
        private DataStructures.ViliWonka.KDTree.KDQueryNode PopFromQueue() { }
        private DataStructures.ViliWonka.KDTree.KDQueryNode PopFromHeap() { }
        private System.Void Reset() { }
        private System.Void .ctor(System.Int32 queryNodesContainersInitialSize) { }
        private System.Void DrawLastQuery() { }
        private System.Void ClosestPoint(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 queryPosition, System.Collections.Generic.List<System.Int32> resultIndices, System.Collections.Generic.List<System.Single> resultDistances) { }
        private System.Void Interval(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 min, UnityEngine.Vector3 max, System.Collections.Generic.List<System.Int32> resultIndices) { }
        private System.Void KNearest(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 queryPosition, System.Int32 k, System.Collections.Generic.List<System.Int32> resultIndices, System.Collections.Generic.List<System.Single> resultDistances) { }
        private System.Void Radius(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 queryPosition, System.Single queryRadius, System.Collections.Generic.List<System.Int32> resultIndices) { }

    }

    // TypeToken: 0x2000005
    public class KDQueryNode
    {
        // Fields
        public DataStructures.ViliWonka.KDTree.KDNode node;        // 0x10
        public UnityEngine.Vector3 tempClosestPoint;        // 0x18
        public System.Single distance;        // 0x24

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(DataStructures.ViliWonka.KDTree.KDNode node, UnityEngine.Vector3 tempClosestPoint) { }

    }

    // TypeToken: 0x2000006
    public class KDTree
    {
        // Fields
        private DataStructures.ViliWonka.KDTree.KDNode <RootNode>k__BackingField;        // 0x10
        private UnityEngine.Vector3[] points;        // 0x18
        private System.Int32[] permutation;        // 0x20
        private System.Int32 <Count>k__BackingField;        // 0x28
        private System.Int32 maxPointsPerLeafNode;        // 0x2C
        private DataStructures.ViliWonka.KDTree.KDNode[] kdNodesStack;        // 0x30
        private System.Int32 kdNodesCount;        // 0x38

        // Methods
        private DataStructures.ViliWonka.KDTree.KDNode get_RootNode() { }
        private System.Void set_RootNode(DataStructures.ViliWonka.KDTree.KDNode value) { }
        private UnityEngine.Vector3[] get_Points() { }
        private System.Int32[] get_Permutation() { }
        private System.Int32 get_Count() { }
        private System.Void set_Count(System.Int32 value) { }
        private System.Void .ctor(System.Int32 maxPointsPerLeafNode) { }
        private System.Void .ctor(UnityEngine.Vector3[] points, System.Int32 maxPointsPerLeafNode) { }
        private System.Void Build(UnityEngine.Vector3[] newPoints, System.Int32 maxPointsPerLeafNode) { }
        private System.Void Build(System.Collections.Generic.List<UnityEngine.Vector3> newPoints, System.Int32 maxPointsPerLeafNode) { }
        private System.Void Rebuild(System.Int32 maxPointsPerLeafNode) { }
        private System.Void SetCount(System.Int32 newSize) { }
        private System.Void BuildTree() { }
        private DataStructures.ViliWonka.KDTree.KDNode GetKDNode() { }
        private System.Void ResetKDNodeStack() { }
        private DataStructures.ViliWonka.KDTree.KDBounds MakeBounds() { }
        private System.Void SplitNode(DataStructures.ViliWonka.KDTree.KDNode parent) { }
        private System.Single CalculatePivot(System.Int32 start, System.Int32 end, System.Single boundsStart, System.Single boundsEnd, System.Int32 axis) { }
        private System.Int32 Partition(System.Int32 start, System.Int32 end, System.Single partitionPivot, System.Int32 axis) { }
        private System.Boolean ContinueSplit(DataStructures.ViliWonka.KDTree.KDNode node) { }

    }

}

