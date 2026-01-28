// ========================================================
// Dumped by @desirepro
// Assembly: Priority Queue.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000B
    public class SimpleNode : GenericPriorityQueueNode`1
    {
        // Fields
        private TItem <Data>k__BackingField;        // 0x0

        // Methods
        private TItem get_Data() { }
        private System.Void set_Data(TItem value) { }
        private System.Void .ctor(TItem data) { }

    }

namespace Priority_Queue
{

    // TypeToken: 0x2000002
    public class FastPriorityQueue`1, IFixedSizePriorityQueue`2, IPriorityQueue`2, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Int32 _numNodes;        // 0x0
        private T[] _nodes;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 maxNodes) { }
        private System.Int32 get_Count() { }
        private System.Int32 get_MaxSize() { }
        private System.Void Clear() { }
        private System.Boolean Contains(T node) { }
        private System.Void Enqueue(T node, System.Single priority) { }
        private System.Void CascadeUp(T node) { }
        private System.Void CascadeDown(T node) { }
        private System.Boolean HasHigherPriority(T higher, T lower) { }
        private System.Boolean HasHigherOrEqualPriority(T higher, T lower) { }
        private T Dequeue() { }
        private System.Void Resize(System.Int32 maxNodes) { }
        private T get_First() { }
        private System.Void UpdatePriority(T node, System.Single priority) { }
        private System.Void OnNodeUpdated(T node) { }
        private System.Void Remove(T node) { }
        private System.Void ResetNode(T node) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean IsValidQueue() { }

    }

    // TypeToken: 0x2000004
    public class FastPriorityQueueNode
    {
        // Fields
        private System.Single <Priority>k__BackingField;        // 0x10
        private System.Int32 <QueueIndex>k__BackingField;        // 0x14

        // Methods
        private System.Single get_Priority() { }
        private System.Void set_Priority(System.Single value) { }
        private System.Int32 get_QueueIndex() { }
        private System.Void set_QueueIndex(System.Int32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class GenericPriorityQueue`2, IFixedSizePriorityQueue`2, IPriorityQueue`2, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Int32 _numNodes;        // 0x0
        private TItem[] _nodes;        // 0x0
        private System.Int64 _numNodesEverEnqueued;        // 0x0
        private readonly System.Comparison<TPriority> _comparer;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 maxNodes) { }
        private System.Void .ctor(System.Int32 maxNodes, System.Collections.Generic.IComparer<TPriority> comparer) { }
        private System.Void .ctor(System.Int32 maxNodes, System.Comparison<TPriority> comparer) { }
        private System.Int32 get_Count() { }
        private System.Int32 get_MaxSize() { }
        private System.Void Clear() { }
        private System.Boolean Contains(TItem node) { }
        private System.Void Enqueue(TItem node, TPriority priority) { }
        private System.Void CascadeUp(TItem node) { }
        private System.Void CascadeDown(TItem node) { }
        private System.Boolean HasHigherPriority(TItem higher, TItem lower) { }
        private TItem Dequeue() { }
        private System.Void Resize(System.Int32 maxNodes) { }
        private TItem get_First() { }
        private System.Void UpdatePriority(TItem node, TPriority priority) { }
        private System.Void OnNodeUpdated(TItem node) { }
        private System.Void Remove(TItem node) { }
        private System.Void ResetNode(TItem node) { }
        private System.Collections.Generic.IEnumerator<TItem> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean IsValidQueue() { }

    }

    // TypeToken: 0x2000007
    public class GenericPriorityQueueNode`1
    {
        // Fields
        private TPriority <Priority>k__BackingField;        // 0x0
        private System.Int32 <QueueIndex>k__BackingField;        // 0x0
        private System.Int64 <InsertionIndex>k__BackingField;        // 0x0

        // Methods
        private TPriority get_Priority() { }
        private System.Void set_Priority(TPriority value) { }
        private System.Int32 get_QueueIndex() { }
        private System.Void set_QueueIndex(System.Int32 value) { }
        private System.Int64 get_InsertionIndex() { }
        private System.Void set_InsertionIndex(System.Int64 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public interface IFixedSizePriorityQueue`2 : IPriorityQueue`2, IEnumerable`1, IEnumerable
    {
        // Methods
        private System.Void Resize(System.Int32 maxNodes) { }
        private System.Int32 get_MaxSize() { }
        private System.Void ResetNode(TItem node) { }

    }

    // TypeToken: 0x2000009
    public interface IPriorityQueue`2 : IEnumerable`1, IEnumerable
    {
        // Methods
        private System.Void Enqueue(TItem node, TPriority priority) { }
        private TItem Dequeue() { }
        private System.Void Clear() { }
        private System.Boolean Contains(TItem node) { }
        private System.Void Remove(TItem node) { }
        private System.Void UpdatePriority(TItem node, TPriority priority) { }
        private TItem get_First() { }
        private System.Int32 get_Count() { }

    }

    // TypeToken: 0x200000A
    public class SimplePriorityQueue`2, IPriorityQueue`2, IEnumerable`1, IEnumerable
    {
        // Fields
        private static System.Int32 INITIAL_QUEUE_SIZE;        // 0x0
        private readonly Priority_Queue.GenericPriorityQueue<Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority>,TPriority> _queue;        // 0x0
        private readonly System.Collections.Generic.Dictionary<TItem,System.Collections.Generic.IList<Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority>>> _itemToNodesCache;        // 0x0
        private readonly System.Collections.Generic.IList<Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority>> _nullNodesCache;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IComparer<TPriority> priorityComparer) { }
        private System.Void .ctor(System.Comparison<TPriority> priorityComparer) { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<TItem> itemEquality) { }
        private System.Void .ctor(System.Collections.Generic.IComparer<TPriority> priorityComparer, System.Collections.Generic.IEqualityComparer<TItem> itemEquality) { }
        private System.Void .ctor(System.Comparison<TPriority> priorityComparer, System.Collections.Generic.IEqualityComparer<TItem> itemEquality) { }
        private Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority> GetExistingNode(TItem item) { }
        private System.Void AddToNodeCache(Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority> node) { }
        private System.Void RemoveFromNodeCache(Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority> node) { }
        private System.Int32 get_Count() { }
        private TItem get_First() { }
        private System.Void Clear() { }
        private System.Boolean Contains(TItem item) { }
        private TItem Dequeue() { }
        private Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority> EnqueueNoLockOrCache(TItem item, TPriority priority) { }
        private System.Void Enqueue(TItem item, TPriority priority) { }
        private System.Boolean EnqueueWithoutDuplicates(TItem item, TPriority priority) { }
        private System.Void Remove(TItem item) { }
        private System.Void UpdatePriority(TItem item, TPriority priority) { }
        private TPriority GetPriority(TItem item) { }
        private System.Boolean TryFirst(TItem& first) { }
        private System.Boolean TryDequeue(TItem& first) { }
        private System.Boolean TryRemove(TItem item) { }
        private System.Boolean TryUpdatePriority(TItem item, TPriority priority) { }
        private System.Boolean TryGetPriority(TItem item, TPriority& priority) { }
        private System.Collections.Generic.IEnumerator<TItem> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean IsValidQueue() { }

    }

    // TypeToken: 0x200000C
    public class SimplePriorityQueue`1 : SimplePriorityQueue`2
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IComparer<System.Single> comparer) { }
        private System.Void .ctor(System.Comparison<System.Single> comparer) { }

    }

    // TypeToken: 0x200000D
    public class StablePriorityQueue`1, IFixedSizePriorityQueue`2, IPriorityQueue`2, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Int32 _numNodes;        // 0x0
        private T[] _nodes;        // 0x0
        private System.Int64 _numNodesEverEnqueued;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 maxNodes) { }
        private System.Int32 get_Count() { }
        private System.Int32 get_MaxSize() { }
        private System.Void Clear() { }
        private System.Boolean Contains(T node) { }
        private System.Void Enqueue(T node, System.Single priority) { }
        private System.Void CascadeUp(T node) { }
        private System.Void CascadeDown(T node) { }
        private System.Boolean HasHigherPriority(T higher, T lower) { }
        private T Dequeue() { }
        private System.Void Resize(System.Int32 maxNodes) { }
        private T get_First() { }
        private System.Void UpdatePriority(T node, System.Single priority) { }
        private System.Void OnNodeUpdated(T node) { }
        private System.Void Remove(T node) { }
        private System.Void ResetNode(T node) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean IsValidQueue() { }

    }

    // TypeToken: 0x200000F
    public class StablePriorityQueueNode : FastPriorityQueueNode
    {
        // Fields
        private System.Int64 <InsertionIndex>k__BackingField;        // 0x18

        // Methods
        private System.Int64 get_InsertionIndex() { }
        private System.Void set_InsertionIndex(System.Int64 value) { }
        private System.Void .ctor() { }

    }

}

