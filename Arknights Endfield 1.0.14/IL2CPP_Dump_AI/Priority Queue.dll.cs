// ========================================================
// Dumped by @desirepro
// Assembly: Priority Queue.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SimpleNode
TYPE:  class
TOKEN: 0x200000B
EXTENDS: GenericPriorityQueueNode`1
FIELDS:
  private           TItem                           <Data>k__BackingField  // 0x0
METHODS:
  TItem get_Data()
  System.Void set_Data(TItem value)
  System.Void .ctor(TItem data)
END_CLASS

CLASS: Priority_Queue.FastPriorityQueue`1
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private           System.Int32                    _numNodes  // 0x0
  private           T[]                             _nodes  // 0x0
METHODS:
  System.Void .ctor(System.Int32 maxNodes)
  System.Int32 get_Count()
  System.Int32 get_MaxSize()
  System.Void Clear()
  System.Boolean Contains(T node)
  System.Void Enqueue(T node, System.Single priority)
  System.Void CascadeUp(T node)
  System.Void CascadeDown(T node)
  System.Boolean HasHigherPriority(T higher, T lower)
  System.Boolean HasHigherOrEqualPriority(T higher, T lower)
  T Dequeue()
  System.Void Resize(System.Int32 maxNodes)
  T get_First()
  System.Void UpdatePriority(T node, System.Single priority)
  System.Void OnNodeUpdated(T node)
  System.Void Remove(T node)
  System.Void ResetNode(T node)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean IsValidQueue()
END_CLASS

CLASS: Priority_Queue.FastPriorityQueueNode
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           System.Single                   <Priority>k__BackingField  // 0x10
  private           System.Int32                    <QueueIndex>k__BackingField  // 0x14
METHODS:
  System.Single get_Priority()
  System.Void set_Priority(System.Single value)
  System.Int32 get_QueueIndex()
  System.Void set_QueueIndex(System.Int32 value)
  System.Void .ctor()
END_CLASS

CLASS: Priority_Queue.GenericPriorityQueue`2
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private           System.Int32                    _numNodes  // 0x0
  private           TItem[]                         _nodes  // 0x0
  private           System.Int64                    _numNodesEverEnqueued  // 0x0
  private   readonly System.Comparison<TPriority>    _comparer  // 0x0
METHODS:
  System.Void .ctor(System.Int32 maxNodes)
  System.Void .ctor(System.Int32 maxNodes, System.Collections.Generic.IComparer<TPriority> comparer)
  System.Void .ctor(System.Int32 maxNodes, System.Comparison<TPriority> comparer)
  System.Int32 get_Count()
  System.Int32 get_MaxSize()
  System.Void Clear()
  System.Boolean Contains(TItem node)
  System.Void Enqueue(TItem node, TPriority priority)
  System.Void CascadeUp(TItem node)
  System.Void CascadeDown(TItem node)
  System.Boolean HasHigherPriority(TItem higher, TItem lower)
  TItem Dequeue()
  System.Void Resize(System.Int32 maxNodes)
  TItem get_First()
  System.Void UpdatePriority(TItem node, TPriority priority)
  System.Void OnNodeUpdated(TItem node)
  System.Void Remove(TItem node)
  System.Void ResetNode(TItem node)
  System.Collections.Generic.IEnumerator<TItem> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean IsValidQueue()
END_CLASS

CLASS: Priority_Queue.GenericPriorityQueueNode`1
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private           TPriority                       <Priority>k__BackingField  // 0x0
  private           System.Int32                    <QueueIndex>k__BackingField  // 0x0
  private           System.Int64                    <InsertionIndex>k__BackingField  // 0x0
METHODS:
  TPriority get_Priority()
  System.Void set_Priority(TPriority value)
  System.Int32 get_QueueIndex()
  System.Void set_QueueIndex(System.Int32 value)
  System.Int64 get_InsertionIndex()
  System.Void set_InsertionIndex(System.Int64 value)
  System.Void .ctor()
END_CLASS

CLASS: Priority_Queue.IFixedSizePriorityQueue`2
TYPE:  interface
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Void Resize(System.Int32 maxNodes)
  System.Int32 get_MaxSize()
  System.Void ResetNode(TItem node)
END_CLASS

CLASS: Priority_Queue.IPriorityQueue`2
TYPE:  interface
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Void Enqueue(TItem node, TPriority priority)
  TItem Dequeue()
  System.Void Clear()
  System.Boolean Contains(TItem node)
  System.Void Remove(TItem node)
  System.Void UpdatePriority(TItem node, TPriority priority)
  TItem get_First()
  System.Int32 get_Count()
END_CLASS

CLASS: Priority_Queue.SimplePriorityQueue`2
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static  System.Int32                    INITIAL_QUEUE_SIZE  // 0x0
  private   readonly Priority_Queue.GenericPriorityQueue<Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority>,TPriority>_queue  // 0x0
  private   readonly System.Collections.Generic.Dictionary<TItem,System.Collections.Generic.IList<Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority>>>_itemToNodesCache  // 0x0
  private   readonly System.Collections.Generic.IList<Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority>>_nullNodesCache  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IComparer<TPriority> priorityComparer)
  System.Void .ctor(System.Comparison<TPriority> priorityComparer)
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TItem> itemEquality)
  System.Void .ctor(System.Collections.Generic.IComparer<TPriority> priorityComparer, System.Collections.Generic.IEqualityComparer<TItem> itemEquality)
  System.Void .ctor(System.Comparison<TPriority> priorityComparer, System.Collections.Generic.IEqualityComparer<TItem> itemEquality)
  Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority> GetExistingNode(TItem item)
  System.Void AddToNodeCache(Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority> node)
  System.Void RemoveFromNodeCache(Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority> node)
  System.Int32 get_Count()
  TItem get_First()
  System.Void Clear()
  System.Boolean Contains(TItem item)
  TItem Dequeue()
  Priority_Queue.SimplePriorityQueue.SimpleNode<TItem,TPriority> EnqueueNoLockOrCache(TItem item, TPriority priority)
  System.Void Enqueue(TItem item, TPriority priority)
  System.Boolean EnqueueWithoutDuplicates(TItem item, TPriority priority)
  System.Void Remove(TItem item)
  System.Void UpdatePriority(TItem item, TPriority priority)
  TPriority GetPriority(TItem item)
  System.Boolean TryFirst(TItem& first)
  System.Boolean TryDequeue(TItem& first)
  System.Boolean TryRemove(TItem item)
  System.Boolean TryUpdatePriority(TItem item, TPriority priority)
  System.Boolean TryGetPriority(TItem item, TPriority& priority)
  System.Collections.Generic.IEnumerator<TItem> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean IsValidQueue()
END_CLASS

CLASS: Priority_Queue.SimplePriorityQueue`1
TYPE:  class
TOKEN: 0x200000C
EXTENDS: SimplePriorityQueue`2
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IComparer<System.Single> comparer)
  System.Void .ctor(System.Comparison<System.Single> comparer)
END_CLASS

CLASS: Priority_Queue.StablePriorityQueue`1
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private           System.Int32                    _numNodes  // 0x0
  private           T[]                             _nodes  // 0x0
  private           System.Int64                    _numNodesEverEnqueued  // 0x0
METHODS:
  System.Void .ctor(System.Int32 maxNodes)
  System.Int32 get_Count()
  System.Int32 get_MaxSize()
  System.Void Clear()
  System.Boolean Contains(T node)
  System.Void Enqueue(T node, System.Single priority)
  System.Void CascadeUp(T node)
  System.Void CascadeDown(T node)
  System.Boolean HasHigherPriority(T higher, T lower)
  T Dequeue()
  System.Void Resize(System.Int32 maxNodes)
  T get_First()
  System.Void UpdatePriority(T node, System.Single priority)
  System.Void OnNodeUpdated(T node)
  System.Void Remove(T node)
  System.Void ResetNode(T node)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean IsValidQueue()
END_CLASS

CLASS: Priority_Queue.StablePriorityQueueNode
TYPE:  class
TOKEN: 0x200000F
EXTENDS: FastPriorityQueueNode
FIELDS:
  private           System.Int64                    <InsertionIndex>k__BackingField  // 0x18
METHODS:
  System.Int64 get_InsertionIndex()
  System.Void set_InsertionIndex(System.Int64 value)
  System.Void .ctor()
END_CLASS

