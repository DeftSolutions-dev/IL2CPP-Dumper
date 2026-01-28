// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Collections.dll
// Classes:  191
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x2000008
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: JobBurstSchedulableProducer`1
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  private   static readonly Unity.Burst.SharedStatic<System.IntPtr>jobReflectionData  // 0x0
METHODS:
  System.Void Initialize()
  System.Void Execute(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
  System.Void .cctor()
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: JobParallelForBatchProducer`1
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  private   static readonly Unity.Burst.SharedStatic<System.IntPtr>jobReflectionData  // 0x0
METHODS:
  System.Void Initialize()
  System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
  System.Void .cctor()
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: JobParallelForBurstSchedulableProducer`1
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  private   static readonly Unity.Burst.SharedStatic<System.IntPtr>jobReflectionData  // 0x0
METHODS:
  System.Void Initialize()
  System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
  System.Void .cctor()
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x2000014
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: JobParallelForDeferProducer`1
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  private   static readonly Unity.Burst.SharedStatic<System.IntPtr>jobReflectionData  // 0x0
METHODS:
  System.Void Initialize()
  System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
  System.Void .cctor()
END_CLASS

CLASS: JobWrapper
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            Unity.Collections.NativeList<System.Int32>outputIndices  // 0x0
  public            System.Int32                    appendCount  // 0x0
  public            T                               JobData  // 0x0
METHODS:
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x2000019
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Unity.Jobs.JobParallelIndexListExtensions.JobParallelForFilterProducer.JobWrapper<T>& jobWrapper, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: JobParallelForFilterProducer`1
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  private   static readonly Unity.Burst.SharedStatic<System.IntPtr>jobReflectionData  // 0x0
METHODS:
  System.Void Initialize()
  System.Void Execute(Unity.Jobs.JobParallelIndexListExtensions.JobParallelForFilterProducer.JobWrapper<T>& jobWrapper, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
  System.Void ExecuteAppend(Unity.Jobs.JobParallelIndexListExtensions.JobParallelForFilterProducer.JobWrapper<T>& jobWrapper, System.IntPtr bufferRangePatchData)
  System.Void ExecuteFilter(Unity.Jobs.JobParallelIndexListExtensions.JobParallelForFilterProducer.JobWrapper<T>& jobWrapper, System.IntPtr bufferRangePatchData)
  System.Void .cctor()
END_CLASS

CLASS: TryFunction
TYPE:  class
TOKEN: 0x200001C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: AllocatorHandle
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.UInt16                   Index  // 0x10
  public            System.UInt16                   Version  // 0x12
METHODS:
  Unity.Collections.AllocatorManager.TableEntry& get_TableEntry()
  System.Void Rewind()
  Unity.Collections.AllocatorManager.AllocatorHandle op_Implicit(Unity.Collections.Allocator a)
  System.Int32 get_Value()
  System.Int32 Try(Unity.Collections.AllocatorManager.Block& block)
  Unity.Collections.AllocatorManager.AllocatorHandle get_Handle()
  Unity.Collections.Allocator get_ToAllocator()
  System.Void Dispose()
END_CLASS

CLASS: Range
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.IntPtr                   Pointer  // 0x10
  public            System.Int32                    Items  // 0x18
  public            Unity.Collections.AllocatorManager.AllocatorHandleAllocator  // 0x1C
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: Block
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            Unity.Collections.AllocatorManager.RangeRange  // 0x10
  public            System.Int32                    BytesPerItem  // 0x20
  public            System.Int32                    AllocatedItems  // 0x24
  public            System.Byte                     Log2Alignment  // 0x28
  public            System.Byte                     Padding0  // 0x29
  public            System.UInt16                   Padding1  // 0x2A
  public            System.UInt32                   Padding2  // 0x2C
METHODS:
  System.Int64 get_Bytes()
  System.Int64 get_AllocatedBytes()
  System.Int32 get_Alignment()
  System.Void set_Alignment(System.Int32 value)
  System.Void Dispose()
  System.Int32 TryFree()
END_CLASS

CLASS: IAllocator
TYPE:  interface
TOKEN: 0x2000020
FIELDS:
METHODS:
  System.Int32 Try(Unity.Collections.AllocatorManager.Block& block)
  Unity.Collections.AllocatorManager.AllocatorHandle get_Handle()
END_CLASS

CLASS: Try_000000A0$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000022
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: Try_000000A0$BurstDirectCall
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: StackAllocator
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_handle  // 0x10
  private           Unity.Collections.AllocatorManager.Blockm_storage  // 0x18
  private           System.Int64                    m_top  // 0x38
METHODS:
  Unity.Collections.AllocatorManager.AllocatorHandle get_Handle()
  System.Int32 Try(Unity.Collections.AllocatorManager.Block& block)
  System.Int32 Try(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block)
  System.Void Dispose()
  System.Int32 Try$BurstManaged(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: Try_000000AE$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000025
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: Try_000000AE$BurstDirectCall
TYPE:  class
TOKEN: 0x2000026
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: SlabAllocator
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_handle  // 0x10
  private           Unity.Collections.AllocatorManager.BlockStorage  // 0x18
  private           System.Int32                    Log2SlabSizeInBytes  // 0x38
  private           Unity.Collections.FixedList4096Bytes<System.Int32>Occupied  // 0x3C
  private           System.Int64                    budgetInBytes  // 0x1040
  private           System.Int64                    allocatedBytes  // 0x1048
METHODS:
  Unity.Collections.AllocatorManager.AllocatorHandle get_Handle()
  System.Int32 get_SlabSizeInBytes()
  System.Int32 Try(Unity.Collections.AllocatorManager.Block& block)
  System.Int32 Try(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block)
  System.Void Dispose()
  System.Int32 Try$BurstManaged(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: TableEntry
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  private           System.IntPtr                   function  // 0x10
  private           System.IntPtr                   state  // 0x18
METHODS:
END_CLASS

CLASS: Array16`1
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  private           T                               f0  // 0x0
  private           T                               f1  // 0x0
  private           T                               f2  // 0x0
  private           T                               f3  // 0x0
  private           T                               f4  // 0x0
  private           T                               f5  // 0x0
  private           T                               f6  // 0x0
  private           T                               f7  // 0x0
  private           T                               f8  // 0x0
  private           T                               f9  // 0x0
  private           T                               f10  // 0x0
  private           T                               f11  // 0x0
  private           T                               f12  // 0x0
  private           T                               f13  // 0x0
  private           T                               f14  // 0x0
  private           T                               f15  // 0x0
METHODS:
END_CLASS

CLASS: Array256`1
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  private           Unity.Collections.AllocatorManager.Array16<T>f0  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f1  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f2  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f3  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f4  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f5  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f6  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f7  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f8  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f9  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f10  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f11  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f12  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f13  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f14  // 0x0
  private           Unity.Collections.AllocatorManager.Array16<T>f15  // 0x0
METHODS:
END_CLASS

CLASS: Array4096`1
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  private           Unity.Collections.AllocatorManager.Array256<T>f0  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f1  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f2  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f3  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f4  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f5  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f6  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f7  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f8  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f9  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f10  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f11  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f12  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f13  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f14  // 0x0
  private           Unity.Collections.AllocatorManager.Array256<T>f15  // 0x0
METHODS:
END_CLASS

CLASS: Array32768`1
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  private           Unity.Collections.AllocatorManager.Array4096<T>f0  // 0x0
  private           Unity.Collections.AllocatorManager.Array4096<T>f1  // 0x0
  private           Unity.Collections.AllocatorManager.Array4096<T>f2  // 0x0
  private           Unity.Collections.AllocatorManager.Array4096<T>f3  // 0x0
  private           Unity.Collections.AllocatorManager.Array4096<T>f4  // 0x0
  private           Unity.Collections.AllocatorManager.Array4096<T>f5  // 0x0
  private           Unity.Collections.AllocatorManager.Array4096<T>f6  // 0x0
  private           Unity.Collections.AllocatorManager.Array4096<T>f7  // 0x0
METHODS:
  System.Int32 get_Length()
  T& ElementAt(System.Int32 index)
END_CLASS

CLASS: TableEntry
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  private   static readonly Unity.Burst.SharedStatic<Unity.Collections.AllocatorManager.Array32768<Unity.Collections.AllocatorManager.TableEntry>>Ref  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: SharedStatics
TYPE:  class
TOKEN: 0x200002C
FIELDS:
METHODS:
END_CLASS

CLASS: Managed
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  private   static  Unity.Collections.AllocatorManager.TryFunction[]TryFunctionDelegates  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  private           Unity.Collections.FixedList512Bytes<T>m_List  // 0x0
  private           System.Int32                    m_Index  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.FixedList512Bytes<T>& list)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Array
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
METHODS:
  System.Boolean IsCustom(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void* CustomResize(System.Void* oldPointer, System.Int64 oldCount, System.Int64 newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int64 size, System.Int32 align)
  System.Void* Resize(System.Void* oldPointer, System.Int64 oldCount, System.Int64 newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int64 size, System.Int32 align)
  T* Resize(T* oldPointer, System.Int64 oldCount, System.Int64 newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
END_CLASS

CLASS: Unmanaged
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
METHODS:
  System.Void* Allocate(System.Int64 size, System.Int32 align, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void Free(System.Void* pointer, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void Free(T* pointer, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
END_CLASS

CLASS: ParallelWriter
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<T>*ListData  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* listData)
  System.Void AddNoResize(T value)
END_CLASS

CLASS: ParallelWriter
TYPE:  struct
TOKEN: 0x2000064
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<TKey,TValue>m_Writer  // 0x0
METHODS:
  System.Boolean TryAdd(TKey key, TValue item)
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataEnumeratorm_Enumerator  // 0x0
METHODS:
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue> get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataEnumeratorm_Enumerator  // 0x0
METHODS:
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: ParallelWriter
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMap.ParallelWriter<TKey,TValue>m_Writer  // 0x0
METHODS:
  System.Void Add(TKey key, TValue item)
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  private           Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>hashmap  // 0x0
  private           TKey                            key  // 0x0
  private           System.Boolean                  isFirst  // 0x0
  private           TValue                          value  // 0x0
  private           Unity.Collections.NativeParallelMultiHashMapIterator<TKey>iterator  // 0x0
METHODS:
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  TValue get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  Unity.Collections.NativeParallelMultiHashMap.Enumerator<TKey,TValue> GetEnumerator()
END_CLASS

CLASS: ParallelWriter
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  private           Unity.Collections.NativeQueueData*m_Buffer  // 0x0
  private           Unity.Collections.NativeQueueBlockPoolData*m_QueuePool  // 0x0
  private           System.Int32                    m_ThreadIndex  // 0x0
METHODS:
  System.Void Enqueue(T value)
END_CLASS

CLASS: DefaultComparer`1
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
METHODS:
  System.Int32 Compare(T x, T y)
END_CLASS

CLASS: SegmentSort
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  public            T*                              Data  // 0x0
  public            U                               Comp  // 0x0
  public            System.Int32                    Length  // 0x0
  public            System.Int32                    SegmentWidth  // 0x0
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: SegmentSortMerge
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            T*                              Data  // 0x0
  public            U                               Comp  // 0x0
  public            System.Int32                    Length  // 0x0
  public            System.Int32                    SegmentWidth  // 0x0
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ConstructJobList
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
  public            Unity.Collections.NativeStream  Container  // 0x10
  public            Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList*List  // 0x20
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ConstructJob
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            Unity.Collections.NativeStream  Container  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>Length  // 0x20
METHODS:
  System.Void Execute()
END_CLASS

CLASS: MemoryBlock
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            System.Byte*                    m_pointer  // 0x10
  public            System.Int64                    m_bytes  // 0x18
  public            System.Int64                    m_current  // 0x20
  public            System.Int64                    m_allocations  // 0x28
METHODS:
  System.Void .ctor(System.Int64 bytes)
  System.Void Rewind()
  System.Void Dispose()
  System.Int32 TryAllocate(Unity.Collections.AllocatorManager.Block& block)
  System.Boolean Contains(System.IntPtr ptr)
END_CLASS

CLASS: Rune
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Int32                    value  // 0x10
METHODS:
END_CLASS

CLASS: Comparison
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Boolean                  terminates  // 0x10
  public            System.Int32                    result  // 0x14
METHODS:
  System.Void .ctor(Unity.Collections.Unicode.Rune runeA, Unity.Collections.ConversionError errorA, Unity.Collections.Unicode.Rune runeB, Unity.Collections.ConversionError errorB)
END_CLASS

CLASS: ulong2
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  public            System.UInt64                   x  // 0x10
  public            System.UInt64                   y  // 0x18
METHODS:
  System.Void .ctor(System.UInt64 x, System.UInt64 y)
END_CLASS

CLASS: ParallelReader
TYPE:  struct
TOKEN: 0x200009E
FIELDS:
  public    readonly T*                              Ptr  // 0x0
  public    readonly System.Int32                    Length  // 0x0
METHODS:
  System.Void .ctor(T* ptr, System.Int32 length)
END_CLASS

CLASS: ParallelWriter
TYPE:  struct
TOKEN: 0x200009F
FIELDS:
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<T>*ListData  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* listData)
  System.Void AddNoResize(T value)
END_CLASS

CLASS: ParallelWriter
TYPE:  struct
TOKEN: 0x20000A9
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*m_Buffer  // 0x0
  private           System.Int32                    m_ThreadIndex  // 0x0
METHODS:
  System.Boolean TryAdd(TKey key, TValue item)
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x20000AD
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataEnumeratorm_Enumerator  // 0x0
METHODS:
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: ParallelWriter
TYPE:  struct
TOKEN: 0x20000B1
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*m_Buffer  // 0x0
  private           System.Int32                    m_ThreadIndex  // 0x0
METHODS:
  System.Void Add(TKey key, TValue item)
END_CLASS

CLASS: DisposeJob
TYPE:  struct
TOKEN: 0x20000B8
FIELDS:
  public            Unity.Collections.LowLevel.Unsafe.UnsafeStreamContainer  // 0x10
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ConstructJobList
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  public            Unity.Collections.LowLevel.Unsafe.UnsafeStreamContainer  // 0x10
  public            Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList*List  // 0x20
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ConstructJob
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public            Unity.Collections.LowLevel.Unsafe.UnsafeStreamContainer  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>Length  // 0x20
METHODS:
  System.Void Execute()
END_CLASS

CLASS: __StaticArrayInitTypeSize=192
TYPE:  struct
TOKEN: 0x20000BD
FIELDS:
METHODS:
END_CLASS

CLASS: __JobReflectionRegistrationOutput__3250816150
TYPE:  class
TOKEN: 0x20000BE
FIELDS:
METHODS:
  System.Void CreateJobReflectionData()
  System.Void EarlyInit()
END_CLASS

CLASS: $BurstDirectCallInitializer
TYPE:  class
TOKEN: 0x20000BF
FIELDS:
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.AllocatorManager
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  public    static readonly Unity.Collections.AllocatorManager.AllocatorHandleInvalid  // 0x0
  public    static readonly Unity.Collections.AllocatorManager.AllocatorHandleNone  // 0x4
  public    static readonly Unity.Collections.AllocatorManager.AllocatorHandleTemp  // 0x8
  public    static readonly Unity.Collections.AllocatorManager.AllocatorHandleTempJob  // 0xC
  public    static readonly Unity.Collections.AllocatorManager.AllocatorHandlePersistent  // 0x10
  public    static readonly Unity.Collections.AllocatorManager.AllocatorHandleAudioKernel  // 0x14
METHODS:
  Unity.Collections.AllocatorManager.Block AllocateBlock(T& t, System.Int32 sizeOf, System.Int32 alignOf, System.Int32 items)
  System.Void* Allocate(T& t, System.Int32 sizeOf, System.Int32 alignOf, System.Int32 items)
  U* Allocate(T& t, U u, System.Int32 items)
  System.Void* AllocateStruct(T& t, U u, System.Int32 items)
  System.Void FreeBlock(T& t, Unity.Collections.AllocatorManager.Block& block)
  System.Void Free(T& t, System.Void* pointer, System.Int32 sizeOf, System.Int32 alignOf, System.Int32 items)
  System.Void Free(T& t, U* pointer, System.Int32 items)
  System.Void* Allocate(Unity.Collections.AllocatorManager.AllocatorHandle handle, System.Int32 itemSizeInBytes, System.Int32 alignmentInBytes, System.Int32 items)
  T* Allocate(Unity.Collections.AllocatorManager.AllocatorHandle handle, System.Int32 items)
  System.Void Free(Unity.Collections.AllocatorManager.AllocatorHandle handle, System.Void* pointer)
  System.Void Free(Unity.Collections.AllocatorManager.AllocatorHandle handle, T* pointer, System.Int32 items)
  System.Void CheckDelegate(System.Boolean& useDelegate)
  System.Boolean UseDelegate()
  System.Int32 allocate_block(Unity.Collections.AllocatorManager.Block& block)
  System.Void forward_mono_allocate_block(Unity.Collections.AllocatorManager.Block& block, System.Int32& error)
  Unity.Collections.Allocator LegacyOf(Unity.Collections.AllocatorManager.AllocatorHandle handle)
  System.Int32 TryLegacy(Unity.Collections.AllocatorManager.Block& block)
  System.Int32 Try(Unity.Collections.AllocatorManager.Block& block)
  System.Boolean IsCustomAllocator(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void .cctor()
  System.Void Initialize$StackAllocator_Try_000000A0$BurstDirectCall()
  System.Void Initialize$SlabAllocator_Try_000000AE$BurstDirectCall()
END_CLASS

CLASS: Unity.Collections.CreatePropertyAttribute
TYPE:  class
TOKEN: 0x200002F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.Bitwise
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
METHODS:
  System.Int32 FromBool(System.Boolean value)
  System.UInt32 ExtractBits(System.UInt32 input, System.Int32 pos, System.UInt32 mask)
  System.UInt32 ReplaceBits(System.UInt32 input, System.Int32 pos, System.UInt32 mask, System.UInt32 value)
  System.UInt32 SetBits(System.UInt32 input, System.Int32 pos, System.UInt32 mask, System.Boolean value)
  System.UInt64 ExtractBits(System.UInt64 input, System.Int32 pos, System.UInt64 mask)
  System.UInt64 ReplaceBits(System.UInt64 input, System.Int32 pos, System.UInt64 mask, System.UInt64 value)
  System.UInt64 SetBits(System.UInt64 input, System.Int32 pos, System.UInt64 mask, System.Boolean value)
END_CLASS

CLASS: Unity.Collections.BitField32
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.UInt32                   Value  // 0x10
METHODS:
  System.Void SetBits(System.Int32 pos, System.Boolean value)
  System.UInt32 GetBits(System.Int32 pos, System.Int32 numBits)
  System.Boolean IsSet(System.Int32 pos)
END_CLASS

CLASS: Unity.Collections.BitField32DebugView
TYPE:  class
TOKEN: 0x2000032
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.BitField64
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.UInt64                   Value  // 0x10
METHODS:
  System.Void SetBits(System.Int32 pos, System.Boolean value)
  System.UInt64 GetBits(System.Int32 pos, System.Int32 numBits)
  System.Boolean IsSet(System.Int32 pos)
  System.Boolean TestAny(System.Int32 pos, System.Int32 numBits)
END_CLASS

CLASS: Unity.Collections.BitField64DebugView
TYPE:  class
TOKEN: 0x2000034
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.BurstCompatibleAttribute
TYPE:  class
TOKEN: 0x2000035
EXTENDS: Attribute
FIELDS:
  private           System.Type[]                   <GenericTypeArguments>k__BackingField  // 0x10
  public            System.String                   RequiredUnityDefine  // 0x18
METHODS:
  System.Void set_GenericTypeArguments(System.Type[] value)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.NotBurstCompatibleAttribute
TYPE:  class
TOKEN: 0x2000036
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.INativeDisposable
TYPE:  interface
TOKEN: 0x2000037
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.CollectionHelper
TYPE:  class
TOKEN: 0x2000038
FIELDS:
METHODS:
  System.Int32 Log2Floor(System.Int32 value)
  System.Int32 Align(System.Int32 size, System.Int32 alignmentPowerOfTwo)
  System.UInt32 Hash(System.Void* ptr, System.Int32 bytes)
  System.Boolean ShouldDeallocate(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Int32 AssumePositive(System.Int32 value)
  Unity.Collections.NativeArray<T> CreateNativeArray(System.Int32 length, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options)
  Unity.Collections.NativeArray<T> CreateNativeArray(T[] array, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
END_CLASS

CLASS: Unity.Collections.FixedList
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
METHODS:
  System.Int32 PaddingBytes()
  System.Int32 StorageBytes()
  System.Int32 Capacity()
END_CLASS

CLASS: Unity.Collections.FixedList32Bytes`1
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  private           System.UInt16                   length  // 0x0
  private           Unity.Collections.FixedBytes30  buffer  // 0x0
METHODS:
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.Int32 get_LengthInBytes()
  System.Byte* get_Buffer()
  System.Int32 get_Capacity()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  T& ElementAt(System.Int32 index)
  System.Int32 GetHashCode()
  System.Void Add(T& item)
  System.Void RemoveAtSwapBack(System.Int32 index)
  System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveRange(System.Int32 index, System.Int32 count)
  System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(System.Object obj)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.FixedList32BytesExtensions
TYPE:  class
TOKEN: 0x200003B
FIELDS:
METHODS:
  System.Int32 IndexOf(Unity.Collections.FixedList32Bytes<T>& list, U value)
  System.Boolean Contains(Unity.Collections.FixedList32Bytes<T>& list, U value)
END_CLASS

CLASS: Unity.Collections.FixedList32BytesDebugView`1
TYPE:  class
TOKEN: 0x200003C
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedList64Bytes`1
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  private           System.UInt16                   length  // 0x0
  private           Unity.Collections.FixedBytes62  buffer  // 0x0
METHODS:
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.Int32 get_LengthInBytes()
  System.Byte* get_Buffer()
  System.Int32 get_Capacity()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  T& ElementAt(System.Int32 index)
  System.Int32 GetHashCode()
  System.Void Add(T& item)
  System.Void RemoveAtSwapBack(System.Int32 index)
  System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveRange(System.Int32 index, System.Int32 count)
  System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(System.Object obj)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.FixedList64BytesExtensions
TYPE:  class
TOKEN: 0x200003E
FIELDS:
METHODS:
  System.Int32 IndexOf(Unity.Collections.FixedList64Bytes<T>& list, U value)
  System.Boolean Contains(Unity.Collections.FixedList64Bytes<T>& list, U value)
END_CLASS

CLASS: Unity.Collections.FixedList64BytesDebugView`1
TYPE:  class
TOKEN: 0x200003F
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedList128Bytes`1
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  private           System.UInt16                   length  // 0x0
  private           Unity.Collections.FixedBytes126 buffer  // 0x0
METHODS:
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.Boolean get_IsEmpty()
  System.Int32 get_LengthInBytes()
  System.Byte* get_Buffer()
  System.Int32 get_Capacity()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  T& ElementAt(System.Int32 index)
  System.Int32 GetHashCode()
  System.Void Add(T& item)
  System.Void AddNoResize(T& item)
  System.Void Clear()
  System.Void RemoveAtSwapBack(System.Int32 index)
  System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveRange(System.Int32 index, System.Int32 count)
  System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(System.Object obj)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.FixedList128BytesExtensions
TYPE:  class
TOKEN: 0x2000041
FIELDS:
METHODS:
  System.Int32 IndexOf(Unity.Collections.FixedList128Bytes<T>& list, U value)
  System.Boolean Contains(Unity.Collections.FixedList128Bytes<T>& list, U value)
  System.Boolean Remove(Unity.Collections.FixedList128Bytes<T>& list, U value)
END_CLASS

CLASS: Unity.Collections.FixedList128BytesDebugView`1
TYPE:  class
TOKEN: 0x2000042
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedList512Bytes`1
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  private           System.UInt16                   length  // 0x0
  private           Unity.Collections.FixedBytes510 buffer  // 0x0
METHODS:
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.Boolean get_IsEmpty()
  System.Int32 get_LengthInBytes()
  System.Byte* get_Buffer()
  System.Int32 get_Capacity()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  T& ElementAt(System.Int32 index)
  System.Int32 GetHashCode()
  System.Void Add(T& item)
  System.Void Clear()
  System.Void RemoveAtSwapBack(System.Int32 index)
  System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveRange(System.Int32 index, System.Int32 count)
  System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(System.Object obj)
  Unity.Collections.FixedList512Bytes.Enumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.FixedList512BytesExtensions
TYPE:  class
TOKEN: 0x2000045
FIELDS:
METHODS:
  System.Int32 IndexOf(Unity.Collections.FixedList512Bytes<T>& list, U value)
  System.Boolean Contains(Unity.Collections.FixedList512Bytes<T>& list, U value)
  System.Boolean Remove(Unity.Collections.FixedList512Bytes<T>& list, U value)
END_CLASS

CLASS: Unity.Collections.FixedList512BytesDebugView`1
TYPE:  class
TOKEN: 0x2000046
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedList4096Bytes`1
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  private           System.UInt16                   length  // 0x0
  private           Unity.Collections.FixedBytes4094buffer  // 0x0
METHODS:
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.Boolean get_IsEmpty()
  System.Int32 get_LengthInBytes()
  System.Byte* get_Buffer()
  System.Int32 get_Capacity()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  T& ElementAt(System.Int32 index)
  System.Int32 GetHashCode()
  System.Void Add(T& item)
  System.Void Clear()
  System.Void RemoveAtSwapBack(System.Int32 index)
  System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveRange(System.Int32 index, System.Int32 count)
  System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other)
  System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other)
  System.Boolean Equals(System.Object obj)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.FixedList4096BytesExtensions
TYPE:  class
TOKEN: 0x2000048
FIELDS:
METHODS:
  System.Int32 IndexOf(Unity.Collections.FixedList4096Bytes<T>& list, U value)
  System.Boolean Contains(Unity.Collections.FixedList4096Bytes<T>& list, U value)
END_CLASS

CLASS: Unity.Collections.FixedList4096BytesDebugView`1
TYPE:  class
TOKEN: 0x2000049
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedBytes16
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            System.Byte                     byte0000  // 0x10
  public            System.Byte                     byte0001  // 0x11
  public            System.Byte                     byte0002  // 0x12
  public            System.Byte                     byte0003  // 0x13
  public            System.Byte                     byte0004  // 0x14
  public            System.Byte                     byte0005  // 0x15
  public            System.Byte                     byte0006  // 0x16
  public            System.Byte                     byte0007  // 0x17
  public            System.Byte                     byte0008  // 0x18
  public            System.Byte                     byte0009  // 0x19
  public            System.Byte                     byte0010  // 0x1A
  public            System.Byte                     byte0011  // 0x1B
  public            System.Byte                     byte0012  // 0x1C
  public            System.Byte                     byte0013  // 0x1D
  public            System.Byte                     byte0014  // 0x1E
  public            System.Byte                     byte0015  // 0x1F
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedBytes30
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            Unity.Collections.FixedBytes16  offset0000  // 0x10
  public            System.Byte                     byte0016  // 0x20
  public            System.Byte                     byte0017  // 0x21
  public            System.Byte                     byte0018  // 0x22
  public            System.Byte                     byte0019  // 0x23
  public            System.Byte                     byte0020  // 0x24
  public            System.Byte                     byte0021  // 0x25
  public            System.Byte                     byte0022  // 0x26
  public            System.Byte                     byte0023  // 0x27
  public            System.Byte                     byte0024  // 0x28
  public            System.Byte                     byte0025  // 0x29
  public            System.Byte                     byte0026  // 0x2A
  public            System.Byte                     byte0027  // 0x2B
  public            System.Byte                     byte0028  // 0x2C
  public            System.Byte                     byte0029  // 0x2D
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedString32Bytes
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  private   static  System.UInt16                   utf8MaxLengthInBytes  // 0x0
  private           System.UInt16                   utf8LengthInBytes  // 0x10
  private           Unity.Collections.FixedBytes30  bytes  // 0x12
METHODS:
  System.String get_Value()
  System.Byte* GetUnsafePtr()
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions)
  System.Boolean get_IsEmpty()
  System.Int32 CompareTo(System.String other)
  System.Boolean Equals(System.String other)
  System.Void .ctor(System.String source)
  System.Int32 Initialize(System.String source)
  System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString32Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString32Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString64Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString64Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString128Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString128Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString512Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString512Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString4096Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString4096Bytes other)
  Unity.Collections.FixedString32Bytes op_Implicit(System.String b)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: Unity.Collections.FixedBytes62
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            Unity.Collections.FixedBytes16  offset0000  // 0x10
  public            Unity.Collections.FixedBytes16  offset0016  // 0x20
  public            Unity.Collections.FixedBytes16  offset0032  // 0x30
  public            System.Byte                     byte0048  // 0x40
  public            System.Byte                     byte0049  // 0x41
  public            System.Byte                     byte0050  // 0x42
  public            System.Byte                     byte0051  // 0x43
  public            System.Byte                     byte0052  // 0x44
  public            System.Byte                     byte0053  // 0x45
  public            System.Byte                     byte0054  // 0x46
  public            System.Byte                     byte0055  // 0x47
  public            System.Byte                     byte0056  // 0x48
  public            System.Byte                     byte0057  // 0x49
  public            System.Byte                     byte0058  // 0x4A
  public            System.Byte                     byte0059  // 0x4B
  public            System.Byte                     byte0060  // 0x4C
  public            System.Byte                     byte0061  // 0x4D
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedString64Bytes
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  private   static  System.UInt16                   utf8MaxLengthInBytes  // 0x0
  private           System.UInt16                   utf8LengthInBytes  // 0x10
  private           Unity.Collections.FixedBytes62  bytes  // 0x12
METHODS:
  System.String get_Value()
  System.Byte* GetUnsafePtr()
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions)
  System.Boolean get_IsEmpty()
  System.Int32 CompareTo(System.String other)
  System.Boolean Equals(System.String other)
  System.Void .ctor(System.String source)
  System.Int32 Initialize(System.String source)
  System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString32Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString32Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString64Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString64Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString128Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString128Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString512Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString512Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString4096Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString4096Bytes other)
  Unity.Collections.FixedString64Bytes op_Implicit(System.String b)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: Unity.Collections.FixedBytes126
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            Unity.Collections.FixedBytes16  offset0000  // 0x10
  public            Unity.Collections.FixedBytes16  offset0016  // 0x20
  public            Unity.Collections.FixedBytes16  offset0032  // 0x30
  public            Unity.Collections.FixedBytes16  offset0048  // 0x40
  public            Unity.Collections.FixedBytes16  offset0064  // 0x50
  public            Unity.Collections.FixedBytes16  offset0080  // 0x60
  public            Unity.Collections.FixedBytes16  offset0096  // 0x70
  public            System.Byte                     byte0112  // 0x80
  public            System.Byte                     byte0113  // 0x81
  public            System.Byte                     byte0114  // 0x82
  public            System.Byte                     byte0115  // 0x83
  public            System.Byte                     byte0116  // 0x84
  public            System.Byte                     byte0117  // 0x85
  public            System.Byte                     byte0118  // 0x86
  public            System.Byte                     byte0119  // 0x87
  public            System.Byte                     byte0120  // 0x88
  public            System.Byte                     byte0121  // 0x89
  public            System.Byte                     byte0122  // 0x8A
  public            System.Byte                     byte0123  // 0x8B
  public            System.Byte                     byte0124  // 0x8C
  public            System.Byte                     byte0125  // 0x8D
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedString128Bytes
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  private   static  System.UInt16                   utf8MaxLengthInBytes  // 0x0
  private           System.UInt16                   utf8LengthInBytes  // 0x10
  private           Unity.Collections.FixedBytes126 bytes  // 0x12
METHODS:
  System.Byte* GetUnsafePtr()
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions)
  System.Int32 CompareTo(System.String other)
  System.Boolean Equals(System.String other)
  System.Void .ctor(System.String source)
  System.Int32 Initialize(System.String source)
  System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString32Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString32Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString64Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString64Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString128Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString128Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString512Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString512Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString4096Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString4096Bytes other)
  Unity.Collections.FixedString128Bytes op_Implicit(System.String b)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: Unity.Collections.FixedBytes510
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  public            Unity.Collections.FixedBytes16  offset0000  // 0x10
  public            Unity.Collections.FixedBytes16  offset0016  // 0x20
  public            Unity.Collections.FixedBytes16  offset0032  // 0x30
  public            Unity.Collections.FixedBytes16  offset0048  // 0x40
  public            Unity.Collections.FixedBytes16  offset0064  // 0x50
  public            Unity.Collections.FixedBytes16  offset0080  // 0x60
  public            Unity.Collections.FixedBytes16  offset0096  // 0x70
  public            Unity.Collections.FixedBytes16  offset0112  // 0x80
  public            Unity.Collections.FixedBytes16  offset0128  // 0x90
  public            Unity.Collections.FixedBytes16  offset0144  // 0xA0
  public            Unity.Collections.FixedBytes16  offset0160  // 0xB0
  public            Unity.Collections.FixedBytes16  offset0176  // 0xC0
  public            Unity.Collections.FixedBytes16  offset0192  // 0xD0
  public            Unity.Collections.FixedBytes16  offset0208  // 0xE0
  public            Unity.Collections.FixedBytes16  offset0224  // 0xF0
  public            Unity.Collections.FixedBytes16  offset0240  // 0x100
  public            Unity.Collections.FixedBytes16  offset0256  // 0x110
  public            Unity.Collections.FixedBytes16  offset0272  // 0x120
  public            Unity.Collections.FixedBytes16  offset0288  // 0x130
  public            Unity.Collections.FixedBytes16  offset0304  // 0x140
  public            Unity.Collections.FixedBytes16  offset0320  // 0x150
  public            Unity.Collections.FixedBytes16  offset0336  // 0x160
  public            Unity.Collections.FixedBytes16  offset0352  // 0x170
  public            Unity.Collections.FixedBytes16  offset0368  // 0x180
  public            Unity.Collections.FixedBytes16  offset0384  // 0x190
  public            Unity.Collections.FixedBytes16  offset0400  // 0x1A0
  public            Unity.Collections.FixedBytes16  offset0416  // 0x1B0
  public            Unity.Collections.FixedBytes16  offset0432  // 0x1C0
  public            Unity.Collections.FixedBytes16  offset0448  // 0x1D0
  public            Unity.Collections.FixedBytes16  offset0464  // 0x1E0
  public            Unity.Collections.FixedBytes16  offset0480  // 0x1F0
  public            System.Byte                     byte0496  // 0x200
  public            System.Byte                     byte0497  // 0x201
  public            System.Byte                     byte0498  // 0x202
  public            System.Byte                     byte0499  // 0x203
  public            System.Byte                     byte0500  // 0x204
  public            System.Byte                     byte0501  // 0x205
  public            System.Byte                     byte0502  // 0x206
  public            System.Byte                     byte0503  // 0x207
  public            System.Byte                     byte0504  // 0x208
  public            System.Byte                     byte0505  // 0x209
  public            System.Byte                     byte0506  // 0x20A
  public            System.Byte                     byte0507  // 0x20B
  public            System.Byte                     byte0508  // 0x20C
  public            System.Byte                     byte0509  // 0x20D
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedString512Bytes
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  private           System.UInt16                   utf8LengthInBytes  // 0x10
  private           Unity.Collections.FixedBytes510 bytes  // 0x12
METHODS:
  System.Byte* GetUnsafePtr()
  System.Int32 get_Length()
  System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions)
  System.Int32 CompareTo(System.String other)
  System.Boolean Equals(System.String other)
  System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString32Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString32Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString64Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString64Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString128Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString128Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString512Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString512Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString4096Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString4096Bytes other)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: Unity.Collections.FixedBytes4094
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            Unity.Collections.FixedBytes16  offset0000  // 0x10
  public            Unity.Collections.FixedBytes16  offset0016  // 0x20
  public            Unity.Collections.FixedBytes16  offset0032  // 0x30
  public            Unity.Collections.FixedBytes16  offset0048  // 0x40
  public            Unity.Collections.FixedBytes16  offset0064  // 0x50
  public            Unity.Collections.FixedBytes16  offset0080  // 0x60
  public            Unity.Collections.FixedBytes16  offset0096  // 0x70
  public            Unity.Collections.FixedBytes16  offset0112  // 0x80
  public            Unity.Collections.FixedBytes16  offset0128  // 0x90
  public            Unity.Collections.FixedBytes16  offset0144  // 0xA0
  public            Unity.Collections.FixedBytes16  offset0160  // 0xB0
  public            Unity.Collections.FixedBytes16  offset0176  // 0xC0
  public            Unity.Collections.FixedBytes16  offset0192  // 0xD0
  public            Unity.Collections.FixedBytes16  offset0208  // 0xE0
  public            Unity.Collections.FixedBytes16  offset0224  // 0xF0
  public            Unity.Collections.FixedBytes16  offset0240  // 0x100
  public            Unity.Collections.FixedBytes16  offset0256  // 0x110
  public            Unity.Collections.FixedBytes16  offset0272  // 0x120
  public            Unity.Collections.FixedBytes16  offset0288  // 0x130
  public            Unity.Collections.FixedBytes16  offset0304  // 0x140
  public            Unity.Collections.FixedBytes16  offset0320  // 0x150
  public            Unity.Collections.FixedBytes16  offset0336  // 0x160
  public            Unity.Collections.FixedBytes16  offset0352  // 0x170
  public            Unity.Collections.FixedBytes16  offset0368  // 0x180
  public            Unity.Collections.FixedBytes16  offset0384  // 0x190
  public            Unity.Collections.FixedBytes16  offset0400  // 0x1A0
  public            Unity.Collections.FixedBytes16  offset0416  // 0x1B0
  public            Unity.Collections.FixedBytes16  offset0432  // 0x1C0
  public            Unity.Collections.FixedBytes16  offset0448  // 0x1D0
  public            Unity.Collections.FixedBytes16  offset0464  // 0x1E0
  public            Unity.Collections.FixedBytes16  offset0480  // 0x1F0
  public            Unity.Collections.FixedBytes16  offset0496  // 0x200
  public            Unity.Collections.FixedBytes16  offset0512  // 0x210
  public            Unity.Collections.FixedBytes16  offset0528  // 0x220
  public            Unity.Collections.FixedBytes16  offset0544  // 0x230
  public            Unity.Collections.FixedBytes16  offset0560  // 0x240
  public            Unity.Collections.FixedBytes16  offset0576  // 0x250
  public            Unity.Collections.FixedBytes16  offset0592  // 0x260
  public            Unity.Collections.FixedBytes16  offset0608  // 0x270
  public            Unity.Collections.FixedBytes16  offset0624  // 0x280
  public            Unity.Collections.FixedBytes16  offset0640  // 0x290
  public            Unity.Collections.FixedBytes16  offset0656  // 0x2A0
  public            Unity.Collections.FixedBytes16  offset0672  // 0x2B0
  public            Unity.Collections.FixedBytes16  offset0688  // 0x2C0
  public            Unity.Collections.FixedBytes16  offset0704  // 0x2D0
  public            Unity.Collections.FixedBytes16  offset0720  // 0x2E0
  public            Unity.Collections.FixedBytes16  offset0736  // 0x2F0
  public            Unity.Collections.FixedBytes16  offset0752  // 0x300
  public            Unity.Collections.FixedBytes16  offset0768  // 0x310
  public            Unity.Collections.FixedBytes16  offset0784  // 0x320
  public            Unity.Collections.FixedBytes16  offset0800  // 0x330
  public            Unity.Collections.FixedBytes16  offset0816  // 0x340
  public            Unity.Collections.FixedBytes16  offset0832  // 0x350
  public            Unity.Collections.FixedBytes16  offset0848  // 0x360
  public            Unity.Collections.FixedBytes16  offset0864  // 0x370
  public            Unity.Collections.FixedBytes16  offset0880  // 0x380
  public            Unity.Collections.FixedBytes16  offset0896  // 0x390
  public            Unity.Collections.FixedBytes16  offset0912  // 0x3A0
  public            Unity.Collections.FixedBytes16  offset0928  // 0x3B0
  public            Unity.Collections.FixedBytes16  offset0944  // 0x3C0
  public            Unity.Collections.FixedBytes16  offset0960  // 0x3D0
  public            Unity.Collections.FixedBytes16  offset0976  // 0x3E0
  public            Unity.Collections.FixedBytes16  offset0992  // 0x3F0
  public            Unity.Collections.FixedBytes16  offset1008  // 0x400
  public            Unity.Collections.FixedBytes16  offset1024  // 0x410
  public            Unity.Collections.FixedBytes16  offset1040  // 0x420
  public            Unity.Collections.FixedBytes16  offset1056  // 0x430
  public            Unity.Collections.FixedBytes16  offset1072  // 0x440
  public            Unity.Collections.FixedBytes16  offset1088  // 0x450
  public            Unity.Collections.FixedBytes16  offset1104  // 0x460
  public            Unity.Collections.FixedBytes16  offset1120  // 0x470
  public            Unity.Collections.FixedBytes16  offset1136  // 0x480
  public            Unity.Collections.FixedBytes16  offset1152  // 0x490
  public            Unity.Collections.FixedBytes16  offset1168  // 0x4A0
  public            Unity.Collections.FixedBytes16  offset1184  // 0x4B0
  public            Unity.Collections.FixedBytes16  offset1200  // 0x4C0
  public            Unity.Collections.FixedBytes16  offset1216  // 0x4D0
  public            Unity.Collections.FixedBytes16  offset1232  // 0x4E0
  public            Unity.Collections.FixedBytes16  offset1248  // 0x4F0
  public            Unity.Collections.FixedBytes16  offset1264  // 0x500
  public            Unity.Collections.FixedBytes16  offset1280  // 0x510
  public            Unity.Collections.FixedBytes16  offset1296  // 0x520
  public            Unity.Collections.FixedBytes16  offset1312  // 0x530
  public            Unity.Collections.FixedBytes16  offset1328  // 0x540
  public            Unity.Collections.FixedBytes16  offset1344  // 0x550
  public            Unity.Collections.FixedBytes16  offset1360  // 0x560
  public            Unity.Collections.FixedBytes16  offset1376  // 0x570
  public            Unity.Collections.FixedBytes16  offset1392  // 0x580
  public            Unity.Collections.FixedBytes16  offset1408  // 0x590
  public            Unity.Collections.FixedBytes16  offset1424  // 0x5A0
  public            Unity.Collections.FixedBytes16  offset1440  // 0x5B0
  public            Unity.Collections.FixedBytes16  offset1456  // 0x5C0
  public            Unity.Collections.FixedBytes16  offset1472  // 0x5D0
  public            Unity.Collections.FixedBytes16  offset1488  // 0x5E0
  public            Unity.Collections.FixedBytes16  offset1504  // 0x5F0
  public            Unity.Collections.FixedBytes16  offset1520  // 0x600
  public            Unity.Collections.FixedBytes16  offset1536  // 0x610
  public            Unity.Collections.FixedBytes16  offset1552  // 0x620
  public            Unity.Collections.FixedBytes16  offset1568  // 0x630
  public            Unity.Collections.FixedBytes16  offset1584  // 0x640
  public            Unity.Collections.FixedBytes16  offset1600  // 0x650
  public            Unity.Collections.FixedBytes16  offset1616  // 0x660
  public            Unity.Collections.FixedBytes16  offset1632  // 0x670
  public            Unity.Collections.FixedBytes16  offset1648  // 0x680
  public            Unity.Collections.FixedBytes16  offset1664  // 0x690
  public            Unity.Collections.FixedBytes16  offset1680  // 0x6A0
  public            Unity.Collections.FixedBytes16  offset1696  // 0x6B0
  public            Unity.Collections.FixedBytes16  offset1712  // 0x6C0
  public            Unity.Collections.FixedBytes16  offset1728  // 0x6D0
  public            Unity.Collections.FixedBytes16  offset1744  // 0x6E0
  public            Unity.Collections.FixedBytes16  offset1760  // 0x6F0
  public            Unity.Collections.FixedBytes16  offset1776  // 0x700
  public            Unity.Collections.FixedBytes16  offset1792  // 0x710
  public            Unity.Collections.FixedBytes16  offset1808  // 0x720
  public            Unity.Collections.FixedBytes16  offset1824  // 0x730
  public            Unity.Collections.FixedBytes16  offset1840  // 0x740
  public            Unity.Collections.FixedBytes16  offset1856  // 0x750
  public            Unity.Collections.FixedBytes16  offset1872  // 0x760
  public            Unity.Collections.FixedBytes16  offset1888  // 0x770
  public            Unity.Collections.FixedBytes16  offset1904  // 0x780
  public            Unity.Collections.FixedBytes16  offset1920  // 0x790
  public            Unity.Collections.FixedBytes16  offset1936  // 0x7A0
  public            Unity.Collections.FixedBytes16  offset1952  // 0x7B0
  public            Unity.Collections.FixedBytes16  offset1968  // 0x7C0
  public            Unity.Collections.FixedBytes16  offset1984  // 0x7D0
  public            Unity.Collections.FixedBytes16  offset2000  // 0x7E0
  public            Unity.Collections.FixedBytes16  offset2016  // 0x7F0
  public            Unity.Collections.FixedBytes16  offset2032  // 0x800
  public            Unity.Collections.FixedBytes16  offset2048  // 0x810
  public            Unity.Collections.FixedBytes16  offset2064  // 0x820
  public            Unity.Collections.FixedBytes16  offset2080  // 0x830
  public            Unity.Collections.FixedBytes16  offset2096  // 0x840
  public            Unity.Collections.FixedBytes16  offset2112  // 0x850
  public            Unity.Collections.FixedBytes16  offset2128  // 0x860
  public            Unity.Collections.FixedBytes16  offset2144  // 0x870
  public            Unity.Collections.FixedBytes16  offset2160  // 0x880
  public            Unity.Collections.FixedBytes16  offset2176  // 0x890
  public            Unity.Collections.FixedBytes16  offset2192  // 0x8A0
  public            Unity.Collections.FixedBytes16  offset2208  // 0x8B0
  public            Unity.Collections.FixedBytes16  offset2224  // 0x8C0
  public            Unity.Collections.FixedBytes16  offset2240  // 0x8D0
  public            Unity.Collections.FixedBytes16  offset2256  // 0x8E0
  public            Unity.Collections.FixedBytes16  offset2272  // 0x8F0
  public            Unity.Collections.FixedBytes16  offset2288  // 0x900
  public            Unity.Collections.FixedBytes16  offset2304  // 0x910
  public            Unity.Collections.FixedBytes16  offset2320  // 0x920
  public            Unity.Collections.FixedBytes16  offset2336  // 0x930
  public            Unity.Collections.FixedBytes16  offset2352  // 0x940
  public            Unity.Collections.FixedBytes16  offset2368  // 0x950
  public            Unity.Collections.FixedBytes16  offset2384  // 0x960
  public            Unity.Collections.FixedBytes16  offset2400  // 0x970
  public            Unity.Collections.FixedBytes16  offset2416  // 0x980
  public            Unity.Collections.FixedBytes16  offset2432  // 0x990
  public            Unity.Collections.FixedBytes16  offset2448  // 0x9A0
  public            Unity.Collections.FixedBytes16  offset2464  // 0x9B0
  public            Unity.Collections.FixedBytes16  offset2480  // 0x9C0
  public            Unity.Collections.FixedBytes16  offset2496  // 0x9D0
  public            Unity.Collections.FixedBytes16  offset2512  // 0x9E0
  public            Unity.Collections.FixedBytes16  offset2528  // 0x9F0
  public            Unity.Collections.FixedBytes16  offset2544  // 0xA00
  public            Unity.Collections.FixedBytes16  offset2560  // 0xA10
  public            Unity.Collections.FixedBytes16  offset2576  // 0xA20
  public            Unity.Collections.FixedBytes16  offset2592  // 0xA30
  public            Unity.Collections.FixedBytes16  offset2608  // 0xA40
  public            Unity.Collections.FixedBytes16  offset2624  // 0xA50
  public            Unity.Collections.FixedBytes16  offset2640  // 0xA60
  public            Unity.Collections.FixedBytes16  offset2656  // 0xA70
  public            Unity.Collections.FixedBytes16  offset2672  // 0xA80
  public            Unity.Collections.FixedBytes16  offset2688  // 0xA90
  public            Unity.Collections.FixedBytes16  offset2704  // 0xAA0
  public            Unity.Collections.FixedBytes16  offset2720  // 0xAB0
  public            Unity.Collections.FixedBytes16  offset2736  // 0xAC0
  public            Unity.Collections.FixedBytes16  offset2752  // 0xAD0
  public            Unity.Collections.FixedBytes16  offset2768  // 0xAE0
  public            Unity.Collections.FixedBytes16  offset2784  // 0xAF0
  public            Unity.Collections.FixedBytes16  offset2800  // 0xB00
  public            Unity.Collections.FixedBytes16  offset2816  // 0xB10
  public            Unity.Collections.FixedBytes16  offset2832  // 0xB20
  public            Unity.Collections.FixedBytes16  offset2848  // 0xB30
  public            Unity.Collections.FixedBytes16  offset2864  // 0xB40
  public            Unity.Collections.FixedBytes16  offset2880  // 0xB50
  public            Unity.Collections.FixedBytes16  offset2896  // 0xB60
  public            Unity.Collections.FixedBytes16  offset2912  // 0xB70
  public            Unity.Collections.FixedBytes16  offset2928  // 0xB80
  public            Unity.Collections.FixedBytes16  offset2944  // 0xB90
  public            Unity.Collections.FixedBytes16  offset2960  // 0xBA0
  public            Unity.Collections.FixedBytes16  offset2976  // 0xBB0
  public            Unity.Collections.FixedBytes16  offset2992  // 0xBC0
  public            Unity.Collections.FixedBytes16  offset3008  // 0xBD0
  public            Unity.Collections.FixedBytes16  offset3024  // 0xBE0
  public            Unity.Collections.FixedBytes16  offset3040  // 0xBF0
  public            Unity.Collections.FixedBytes16  offset3056  // 0xC00
  public            Unity.Collections.FixedBytes16  offset3072  // 0xC10
  public            Unity.Collections.FixedBytes16  offset3088  // 0xC20
  public            Unity.Collections.FixedBytes16  offset3104  // 0xC30
  public            Unity.Collections.FixedBytes16  offset3120  // 0xC40
  public            Unity.Collections.FixedBytes16  offset3136  // 0xC50
  public            Unity.Collections.FixedBytes16  offset3152  // 0xC60
  public            Unity.Collections.FixedBytes16  offset3168  // 0xC70
  public            Unity.Collections.FixedBytes16  offset3184  // 0xC80
  public            Unity.Collections.FixedBytes16  offset3200  // 0xC90
  public            Unity.Collections.FixedBytes16  offset3216  // 0xCA0
  public            Unity.Collections.FixedBytes16  offset3232  // 0xCB0
  public            Unity.Collections.FixedBytes16  offset3248  // 0xCC0
  public            Unity.Collections.FixedBytes16  offset3264  // 0xCD0
  public            Unity.Collections.FixedBytes16  offset3280  // 0xCE0
  public            Unity.Collections.FixedBytes16  offset3296  // 0xCF0
  public            Unity.Collections.FixedBytes16  offset3312  // 0xD00
  public            Unity.Collections.FixedBytes16  offset3328  // 0xD10
  public            Unity.Collections.FixedBytes16  offset3344  // 0xD20
  public            Unity.Collections.FixedBytes16  offset3360  // 0xD30
  public            Unity.Collections.FixedBytes16  offset3376  // 0xD40
  public            Unity.Collections.FixedBytes16  offset3392  // 0xD50
  public            Unity.Collections.FixedBytes16  offset3408  // 0xD60
  public            Unity.Collections.FixedBytes16  offset3424  // 0xD70
  public            Unity.Collections.FixedBytes16  offset3440  // 0xD80
  public            Unity.Collections.FixedBytes16  offset3456  // 0xD90
  public            Unity.Collections.FixedBytes16  offset3472  // 0xDA0
  public            Unity.Collections.FixedBytes16  offset3488  // 0xDB0
  public            Unity.Collections.FixedBytes16  offset3504  // 0xDC0
  public            Unity.Collections.FixedBytes16  offset3520  // 0xDD0
  public            Unity.Collections.FixedBytes16  offset3536  // 0xDE0
  public            Unity.Collections.FixedBytes16  offset3552  // 0xDF0
  public            Unity.Collections.FixedBytes16  offset3568  // 0xE00
  public            Unity.Collections.FixedBytes16  offset3584  // 0xE10
  public            Unity.Collections.FixedBytes16  offset3600  // 0xE20
  public            Unity.Collections.FixedBytes16  offset3616  // 0xE30
  public            Unity.Collections.FixedBytes16  offset3632  // 0xE40
  public            Unity.Collections.FixedBytes16  offset3648  // 0xE50
  public            Unity.Collections.FixedBytes16  offset3664  // 0xE60
  public            Unity.Collections.FixedBytes16  offset3680  // 0xE70
  public            Unity.Collections.FixedBytes16  offset3696  // 0xE80
  public            Unity.Collections.FixedBytes16  offset3712  // 0xE90
  public            Unity.Collections.FixedBytes16  offset3728  // 0xEA0
  public            Unity.Collections.FixedBytes16  offset3744  // 0xEB0
  public            Unity.Collections.FixedBytes16  offset3760  // 0xEC0
  public            Unity.Collections.FixedBytes16  offset3776  // 0xED0
  public            Unity.Collections.FixedBytes16  offset3792  // 0xEE0
  public            Unity.Collections.FixedBytes16  offset3808  // 0xEF0
  public            Unity.Collections.FixedBytes16  offset3824  // 0xF00
  public            Unity.Collections.FixedBytes16  offset3840  // 0xF10
  public            Unity.Collections.FixedBytes16  offset3856  // 0xF20
  public            Unity.Collections.FixedBytes16  offset3872  // 0xF30
  public            Unity.Collections.FixedBytes16  offset3888  // 0xF40
  public            Unity.Collections.FixedBytes16  offset3904  // 0xF50
  public            Unity.Collections.FixedBytes16  offset3920  // 0xF60
  public            Unity.Collections.FixedBytes16  offset3936  // 0xF70
  public            Unity.Collections.FixedBytes16  offset3952  // 0xF80
  public            Unity.Collections.FixedBytes16  offset3968  // 0xF90
  public            Unity.Collections.FixedBytes16  offset3984  // 0xFA0
  public            Unity.Collections.FixedBytes16  offset4000  // 0xFB0
  public            Unity.Collections.FixedBytes16  offset4016  // 0xFC0
  public            Unity.Collections.FixedBytes16  offset4032  // 0xFD0
  public            Unity.Collections.FixedBytes16  offset4048  // 0xFE0
  public            Unity.Collections.FixedBytes16  offset4064  // 0xFF0
  public            System.Byte                     byte4080  // 0x1000
  public            System.Byte                     byte4081  // 0x1001
  public            System.Byte                     byte4082  // 0x1002
  public            System.Byte                     byte4083  // 0x1003
  public            System.Byte                     byte4084  // 0x1004
  public            System.Byte                     byte4085  // 0x1005
  public            System.Byte                     byte4086  // 0x1006
  public            System.Byte                     byte4087  // 0x1007
  public            System.Byte                     byte4088  // 0x1008
  public            System.Byte                     byte4089  // 0x1009
  public            System.Byte                     byte4090  // 0x100A
  public            System.Byte                     byte4091  // 0x100B
  public            System.Byte                     byte4092  // 0x100C
  public            System.Byte                     byte4093  // 0x100D
METHODS:
END_CLASS

CLASS: Unity.Collections.FixedString4096Bytes
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  private           System.UInt16                   utf8LengthInBytes  // 0x10
  private           Unity.Collections.FixedBytes4094bytes  // 0x12
METHODS:
  System.Byte* GetUnsafePtr()
  System.Int32 get_Length()
  System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions)
  System.Int32 CompareTo(System.String other)
  System.Boolean Equals(System.String other)
  System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString32Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString32Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString64Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString64Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString128Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString128Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString512Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString512Bytes other)
  System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other)
  System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString4096Bytes& b)
  System.Boolean Equals(Unity.Collections.FixedString4096Bytes other)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: Unity.Collections.FixedStringMethods
TYPE:  class
TOKEN: 0x2000055
FIELDS:
METHODS:
  Unity.Collections.FormatError Append(T& fs, System.Byte* utf8Bytes, System.Int32 utf8BytesLength)
  Unity.Collections.FormatError Append(T& fs, System.String s)
  System.Int32 CompareTo(T& fs, System.Byte* bytes, System.Int32 bytesLen)
  System.Int32 CompareTo(T& fs, T2& other)
  System.String ConvertToString(T& fs)
  System.Int32 ComputeHashCode(T& fs)
END_CLASS

CLASS: Unity.Collections.IUTF8Bytes
TYPE:  interface
TOKEN: 0x2000056
FIELDS:
METHODS:
  System.Byte* GetUnsafePtr()
  System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions)
END_CLASS

CLASS: Unity.Collections.ListExtensions
TYPE:  class
TOKEN: 0x2000057
FIELDS:
METHODS:
  System.Boolean RemoveSwapBack(System.Collections.Generic.List<T> list, T value)
  System.Void RemoveAtSwapBack(System.Collections.Generic.List<T> list, System.Int32 index)
  Unity.Collections.NativeArray<T> ToNativeArray(System.Collections.Generic.List<T> list, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
END_CLASS

CLASS: Unity.Collections.Memory
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeArrayExtensions
TYPE:  class
TOKEN: 0x200005B
FIELDS:
METHODS:
  System.Boolean Contains(Unity.Collections.NativeList<T> list, U value)
  System.Span<T> AsSpan(Unity.Collections.NativeArray<T> array)
  System.Span<T> AsSpanThread(Unity.Collections.NativeArray<T> array)
  System.Int32 IndexOf(System.Void* ptr, System.Int32 length, U value)
  Unity.Collections.NativeArray<U> Reinterpret(Unity.Collections.NativeArray<T> array)
  System.Void Initialize(Unity.Collections.NativeArray<T>& array, System.Int32 length, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options)
END_CLASS

CLASS: Unity.Collections.IIndexable`1
TYPE:  interface
TOKEN: 0x200005C
FIELDS:
METHODS:
  System.Int32 get_Length()
END_CLASS

CLASS: Unity.Collections.INativeList`1
TYPE:  interface
TOKEN: 0x200005D
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeList`1
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeList<T>*m_ListData  // 0x0
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_DeprecatedAllocator  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void .ctor(System.Int32 initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void Initialize(System.Int32 initialCapacity, U& allocator, System.Int32 disposeSentinelStackDepth)
  System.Void .ctor(System.Int32 initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int32 disposeSentinelStackDepth)
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  T& ElementAt(System.Int32 index)
  System.Int32 get_Length()
  System.Int32 get_Capacity()
  System.Void set_Capacity(System.Int32 value)
  Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* GetUnsafeList()
  System.Void AddNoResize(T value)
  System.Void Add(T& value)
  System.Void AddRange(Unity.Collections.NativeArray<T> array)
  System.Void AddRange(System.Void* ptr, System.Int32 count)
  System.Void RemoveAtSwapBack(System.Int32 index)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveRange(System.Int32 index, System.Int32 count)
  System.Boolean get_IsEmpty()
  System.Boolean get_IsCreated()
  System.Void Dispose()
  Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps)
  Unity.Jobs.JobHandle CrossFrameDispose(Unity.Jobs.JobHandle inputDeps, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority)
  System.Void Clear()
  Unity.Collections.NativeArray<T> op_Implicit(Unity.Collections.NativeList<T> nativeList)
  Unity.Collections.NativeArray<T> AsArray()
  Unity.Collections.NativeArray<T> AsDeferredJobArray()
  T[] ToArray()
  Unity.Collections.NativeArray.Enumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Void CopyFrom(Unity.Collections.NativeArray<T> array)
  System.Void Resize(System.Int32 length, Unity.Collections.NativeArrayOptions options)
  System.Void ResizeUninitialized(System.Int32 length)
  Unity.Collections.NativeArray.ReadOnly<T> AsParallelReader()
  Unity.Collections.NativeList.ParallelWriter<T> AsParallelWriter()
END_CLASS

CLASS: Unity.Collections.NativeListDispose
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
  public            Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList*m_ListData  // 0x10
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: Unity.Collections.NativeListDisposeJob
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
  private           Unity.Collections.NativeListDisposeData  // 0x10
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Unity.Collections.NativeListDebugView`1
TYPE:  class
TOKEN: 0x2000062
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeParallelHashMap`2
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<TKey,TValue>m_HashMapData  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int32 disposeSentinelStackDepth)
  System.Boolean get_IsEmpty()
  System.Int32 Count()
  System.Int32 get_Capacity()
  System.Void set_Capacity(System.Int32 value)
  System.Void Clear()
  System.Boolean TryAdd(TKey key, TValue item)
  System.Void Add(TKey key, TValue item)
  System.Boolean Remove(TKey key)
  System.Boolean TryGetValue(TKey key, TValue& item)
  System.Boolean ContainsKey(TKey key)
  TValue get_Item(TKey key)
  System.Void set_Item(TKey key, TValue value)
  System.Boolean get_IsCreated()
  System.Void Dispose()
  Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps)
  Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  Unity.Collections.NativeParallelHashMap.ParallelWriter<TKey,TValue> AsParallelWriter()
  Unity.Collections.NativeParallelHashMap.Enumerator<TKey,TValue> GetEnumerator()
  System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.NativeParallelHashMapDebuggerTypeProxy`2
TYPE:  class
TOKEN: 0x2000066
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeParallelHashMapExtensions
TYPE:  class
TOKEN: 0x2000067
FIELDS:
METHODS:
  Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<TKey,TValue> GetUnsafeMap(Unity.Collections.NativeParallelHashMap<TKey,TValue> container)
END_CLASS

CLASS: Unity.Collections.NativeParallelHashSet`1
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  private           Unity.Collections.NativeParallelHashMap<T,System.Boolean>m_Data  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Boolean get_IsEmpty()
  System.Int32 Count()
  System.Boolean get_IsCreated()
  System.Void Dispose()
  System.Void Clear()
  System.Boolean Add(T item)
  System.Boolean Remove(T item)
  System.Boolean Contains(T item)
  Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  Unity.Collections.NativeParallelHashSet.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.NativeHashSetDebuggerTypeProxy`1
TYPE:  class
TOKEN: 0x200006A
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeParallelMultiHashMapIterator`1
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  private           TKey                            key  // 0x0
  private           System.Int32                    NextEntryIndex  // 0x0
  private           System.Int32                    EntryIndex  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeParallelMultiHashMap`2
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMap<TKey,TValue>m_MultiHashMapData  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void Initialize(System.Int32 capacity, U& allocator, System.Int32 disposeSentinelStackDepth)
  System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int32 disposeSentinelStackDepth)
  System.Boolean get_IsEmpty()
  System.Int32 Count()
  System.Int32 get_Capacity()
  System.Void Clear()
  System.Void Add(TKey key, TValue item)
  System.Int32 Remove(TKey key)
  System.Void Remove(Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it)
  System.Boolean TryGetFirstValue(TKey key, TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it)
  System.Boolean TryGetNextValue(TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it)
  System.Boolean ContainsKey(TKey key)
  System.Int32 CountValuesForKey(TKey key)
  System.Boolean SetValue(TValue item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it)
  System.Boolean get_IsCreated()
  System.Void Dispose()
  Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  Unity.Collections.NativeParallelMultiHashMap.Enumerator<TKey,TValue> GetValuesForKey(TKey key)
  System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.NativeParallelMultiHashMapDebuggerTypeProxy`2
TYPE:  class
TOKEN: 0x200006F
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeQueueBlockHeader
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            Unity.Collections.NativeQueueBlockHeader*m_NextBlock  // 0x10
  public            System.Int32                    m_NumItems  // 0x18
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeQueueBlockPoolData
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  private           System.IntPtr                   m_FirstBlock  // 0x10
  private           System.Int32                    m_NumBlocks  // 0x18
  private           System.Int32                    m_MaxBlocks  // 0x1C
  private           System.Int32                    m_AllocLock  // 0x20
METHODS:
  Unity.Collections.NativeQueueBlockHeader* AllocateBlock()
  System.Void FreeBlock(Unity.Collections.NativeQueueBlockHeader* block)
END_CLASS

CLASS: Unity.Collections.NativeQueueBlockPool
TYPE:  class
TOKEN: 0x2000072
FIELDS:
  private   static readonly Unity.Burst.SharedStatic<System.IntPtr>Data  // 0x0
METHODS:
  Unity.Collections.NativeQueueBlockPoolData* GetQueueBlockPool()
  System.Void AppDomainOnDomainUnload()
  System.Void OnDomainUnload(System.Object sender, System.EventArgs e)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Collections.NativeQueueData
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            System.IntPtr                   m_FirstBlock  // 0x10
  public            System.IntPtr                   m_LastBlock  // 0x18
  public            System.Int32                    m_MaxItems  // 0x20
  public            System.Int32                    m_CurrentRead  // 0x24
  public            System.Byte*                    m_CurrentWriteBlockTLS  // 0x28
METHODS:
  Unity.Collections.NativeQueueBlockHeader* GetCurrentWriteBlockTLS(System.Int32 threadIndex)
  System.Void SetCurrentWriteBlockTLS(System.Int32 threadIndex, Unity.Collections.NativeQueueBlockHeader* currentWriteBlock)
  Unity.Collections.NativeQueueBlockHeader* AllocateWriteBlockMT(Unity.Collections.NativeQueueData* data, Unity.Collections.NativeQueueBlockPoolData* pool, System.Int32 threadIndex)
  System.Void AllocateQueue(Unity.Collections.AllocatorManager.AllocatorHandle label, Unity.Collections.NativeQueueData*& outBuf)
  System.Void DeallocateQueue(Unity.Collections.NativeQueueData* data, Unity.Collections.NativeQueueBlockPoolData* pool, Unity.Collections.AllocatorManager.AllocatorHandle allocation)
END_CLASS

CLASS: Unity.Collections.NativeQueue`1
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  private           Unity.Collections.NativeQueueData*m_Buffer  // 0x0
  private           Unity.Collections.NativeQueueBlockPoolData*m_QueuePool  // 0x0
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_AllocatorLabel  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Boolean IsEmpty()
  System.Int32 get_Count()
  System.Void Enqueue(T value)
  System.Boolean TryDequeue(T& item)
  Unity.Collections.NativeArray<T> ToArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void Clear()
  System.Boolean get_IsCreated()
  System.Void Dispose()
  Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps)
  Unity.Collections.NativeQueue.ParallelWriter<T> AsParallelWriter()
END_CLASS

CLASS: Unity.Collections.NativeQueueDispose
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  private           Unity.Collections.NativeQueueData*m_Buffer  // 0x10
  private           Unity.Collections.NativeQueueBlockPoolData*m_QueuePool  // 0x18
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_AllocatorLabel  // 0x20
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: Unity.Collections.NativeQueueDisposeJob
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            Unity.Collections.NativeQueueDisposeData  // 0x10
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Unity.Collections.NativeReference`1
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  private           System.Void*                    m_Data  // 0x0
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_AllocatorLabel  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options)
  System.Void .ctor(T value, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void Allocate(Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeReference<T>& reference)
  T get_Value()
  System.Void set_Value(T value)
  System.Boolean get_IsCreated()
  System.Void Dispose()
  System.Boolean Equals(Unity.Collections.NativeReference<T> other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: Unity.Collections.NativeReferenceDispose
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  private           System.Void*                    m_Data  // 0x10
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_AllocatorLabel  // 0x18
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: Unity.Collections.NativeReferenceDisposeJob
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  private           Unity.Collections.NativeReferenceDisposeData  // 0x10
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Unity.Collections.NativeSortExtension
TYPE:  class
TOKEN: 0x200007B
FIELDS:
METHODS:
  System.Void Sort(T* array, System.Int32 length)
  System.Void Sort(T* array, System.Int32 length, U comp)
  Unity.Collections.SortJob<T,U> SortJob(T* array, System.Int32 length, U comp)
  System.Int32 BinarySearch(T* ptr, System.Int32 length, T value)
  System.Int32 BinarySearch(T* ptr, System.Int32 length, T value, U comp)
  Unity.Collections.SortJob<T,Unity.Collections.NativeSortExtension.DefaultComparer<T>> SortJob(Unity.Collections.NativeArray<T> array)
  System.Void Sort(Unity.Collections.NativeList<T> list)
  System.Void Sort(Unity.Collections.NativeList<T> list, U comp)
  System.Void IntroSort(System.Void* array, System.Int32 length, U comp)
  System.Void IntroSort(System.Void* array, System.Int32 lo, System.Int32 hi, System.Int32 depth, U comp)
  System.Void InsertionSort(System.Void* array, System.Int32 lo, System.Int32 hi, U comp)
  System.Int32 Partition(System.Void* array, System.Int32 lo, System.Int32 hi, U comp)
  System.Void HeapSort(System.Void* array, System.Int32 lo, System.Int32 hi, U comp)
  System.Void Heapify(System.Void* array, System.Int32 i, System.Int32 n, System.Int32 lo, U comp)
  System.Void Swap(System.Void* array, System.Int32 lhs, System.Int32 rhs)
  System.Void SwapIfGreaterWithItems(System.Void* array, System.Int32 lhs, System.Int32 rhs, U comp)
END_CLASS

CLASS: Unity.Collections.SortJob`2
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            T*                              Data  // 0x0
  public            U                               Comp  // 0x0
  public            System.Int32                    Length  // 0x0
METHODS:
  Unity.Jobs.JobHandle Schedule(Unity.Jobs.JobHandle inputDeps)
END_CLASS

CLASS: Unity.Collections.NativeStream
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeStreamm_Stream  // 0x10
METHODS:
  System.Void Dispose()
  System.Void AllocateForEach(System.Int32 forEachCount)
END_CLASS

CLASS: Unity.Collections.Spinner
TYPE:  struct
TOKEN: 0x2000083
FIELDS:
  private           System.Int32                    m_value  // 0x10
METHODS:
  System.Void Lock()
  System.Void Unlock()
END_CLASS

CLASS: Unity.Collections.UnmanagedArray`1
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  private           System.IntPtr                   m_pointer  // 0x0
  private           System.Int32                    m_length  // 0x0
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_allocator  // 0x0
METHODS:
  System.Void Dispose()
  T& get_Item(System.Int32 index)
END_CLASS

CLASS: Unity.Collections.Try_000008B6$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000087
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Int32 Invoke(System.IntPtr state, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: Unity.Collections.Try_000008B6$BurstDirectCall
TYPE:  class
TOKEN: 0x2000088
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Int32 Invoke(System.IntPtr state, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: Unity.Collections.RewindableAllocator
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  private           Unity.Collections.Spinner       m_spinner  // 0x10
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_handle  // 0x14
  private           Unity.Collections.UnmanagedArray<Unity.Collections.RewindableAllocator.MemoryBlock>m_block  // 0x18
  private           System.Int32                    m_best  // 0x28
  private           System.Int32                    m_last  // 0x2C
  private           System.Int32                    m_used  // 0x30
  private           System.Boolean                  m_enableBlockFree  // 0x34
METHODS:
  System.Void Rewind()
  System.Void Dispose()
  System.Int32 Try(Unity.Collections.AllocatorManager.Block& block)
  System.Int32 Try(System.IntPtr state, Unity.Collections.AllocatorManager.Block& block)
  Unity.Collections.AllocatorManager.AllocatorHandle get_Handle()
  System.Int32 Try$BurstManaged(System.IntPtr state, Unity.Collections.AllocatorManager.Block& block)
END_CLASS

CLASS: Unity.Collections.FormatError
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Collections.FormatError   None  // 0x0
  public    static  Unity.Collections.FormatError   Overflow  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Collections.CopyError
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Collections.CopyError     None  // 0x0
  public    static  Unity.Collections.CopyError     Truncation  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Collections.ConversionError
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Collections.ConversionErrorNone  // 0x0
  public    static  Unity.Collections.ConversionErrorOverflow  // 0x0
  public    static  Unity.Collections.ConversionErrorEncoding  // 0x0
  public    static  Unity.Collections.ConversionErrorCodePoint  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Collections.Unicode
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
METHODS:
  System.Boolean IsValidCodePoint(System.Int32 codepoint)
  System.Boolean NotTrailer(System.Byte b)
  Unity.Collections.Unicode.Rune get_ReplacementCharacter()
  Unity.Collections.ConversionError Utf8ToUcs(Unity.Collections.Unicode.Rune& rune, System.Byte* buffer, System.Int32& index, System.Int32 capacity)
  System.Boolean IsLeadingSurrogate(System.Char c)
  System.Boolean IsTrailingSurrogate(System.Char c)
  Unity.Collections.ConversionError Utf16ToUcs(Unity.Collections.Unicode.Rune& rune, System.Char* buffer, System.Int32& index, System.Int32 capacity)
  Unity.Collections.ConversionError UcsToUtf8(System.Byte* buffer, System.Int32& index, System.Int32 capacity, Unity.Collections.Unicode.Rune rune)
  Unity.Collections.ConversionError UcsToUtf16(System.Char* buffer, System.Int32& index, System.Int32 capacity, Unity.Collections.Unicode.Rune rune)
  Unity.Collections.ConversionError Utf16ToUtf8(System.Char* utf16Buffer, System.Int32 utf16Length, System.Byte* utf8Buffer, System.Int32& utf8Length, System.Int32 utf8Capacity)
  Unity.Collections.ConversionError Utf8ToUtf16(System.Byte* utf8Buffer, System.Int32 utf8Length, System.Char* utf16Buffer, System.Int32& utf16Length, System.Int32 utf16Capacity)
END_CLASS

CLASS: Unity.Collections.UTF8ArrayUnsafeUtility
TYPE:  class
TOKEN: 0x200008E
FIELDS:
METHODS:
  Unity.Collections.CopyError Copy(System.Byte* dest, System.Int32& destLength, System.Int32 destUTF8MaxLengthInBytes, System.Char* src, System.Int32 srcLength)
  Unity.Collections.CopyError Copy(System.Byte* dest, System.UInt16& destLength, System.UInt16 destUTF8MaxLengthInBytes, System.Char* src, System.Int32 srcLength)
  System.Int32 StrCmp(System.Byte* utf8BufferA, System.Int32 utf8LengthInBytesA, System.Byte* utf8BufferB, System.Int32 utf8LengthInBytesB)
  System.Boolean EqualsUTF8Bytes(System.Byte* aBytes, System.Int32 aLength, System.Byte* bBytes, System.Int32 bLength)
  System.Int32 StrCmp(System.Byte* utf8Buffer, System.Int32 utf8LengthInBytes, System.Char* utf16Buffer, System.Int32 utf16LengthInChars)
END_CLASS

CLASS: Unity.Collections.Hash64Long_000008F7$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000092
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.UInt64 Invoke(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret)
END_CLASS

CLASS: Unity.Collections.Hash64Long_000008F7$BurstDirectCall
TYPE:  class
TOKEN: 0x2000093
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.UInt64 Invoke(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret)
END_CLASS

CLASS: Unity.Collections.Hash128Long_000008FE$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000094
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, Unity.Mathematics.uint4& result)
END_CLASS

CLASS: Unity.Collections.Hash128Long_000008FE$BurstDirectCall
TYPE:  class
TOKEN: 0x2000095
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, Unity.Mathematics.uint4& result)
END_CLASS

CLASS: Unity.Collections.xxHash3
TYPE:  class
TOKEN: 0x2000090
FIELDS:
METHODS:
  System.Void Avx2HashLongInternalLoop(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, System.Int32 isHash64)
  System.Void Avx2ScrambleAcc(System.UInt64* acc, System.Byte* secret)
  System.Void Avx2Accumulate(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Byte* secret, System.Int64 nbStripes, System.Int32 isHash64)
  System.Void Avx2Accumulate512(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Byte* secret)
  Unity.Mathematics.uint2 Hash64(System.Void* input, System.Int64 length)
  Unity.Mathematics.uint4 Hash128(System.Void* input, System.Int64 length)
  System.UInt64 Hash64Internal(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, System.UInt64 seed)
  System.Void Hash128Internal(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result)
  System.UInt64 Hash64Len1To3(System.Byte* input, System.Int64 len, System.Byte* secret, System.UInt64 seed)
  System.UInt64 Hash64Len4To8(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed)
  System.UInt64 Hash64Len9To16(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed)
  System.UInt64 Hash64Len0To16(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed)
  System.UInt64 Hash64Len17To128(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed)
  System.UInt64 Hash64Len129To240(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed)
  System.UInt64 Hash64Long(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret)
  System.Void Hash128Len1To3(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result)
  System.Void Hash128Len4To8(System.Byte* input, System.Int64 len, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result)
  System.Void Hash128Len9To16(System.Byte* input, System.Int64 len, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result)
  System.Void Hash128Len0To16(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result)
  System.Void Hash128Len17To128(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result)
  System.Void Hash128Len129To240(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result)
  System.Void Hash128Long(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, Unity.Mathematics.uint4& result)
  Unity.Mathematics.uint2 ToUint2(System.UInt64 u)
  Unity.Mathematics.uint4 ToUint4(System.UInt64 ul0, System.UInt64 ul1)
  System.Void EncodeSecretKey(System.Byte* dst, System.Byte* secret, System.UInt64 seed)
  System.UInt64 Read64LE(System.Void* addr)
  System.UInt32 Read32LE(System.Void* addr)
  System.Void Write64LE(System.Void* addr, System.UInt64 value)
  System.UInt64 Mul32To64(System.UInt32 x, System.UInt32 y)
  System.UInt64 Swap64(System.UInt64 x)
  System.UInt32 Swap32(System.UInt32 x)
  System.UInt32 RotL32(System.UInt32 x, System.Int32 r)
  System.UInt64 RotL64(System.UInt64 x, System.Int32 r)
  System.UInt64 XorShift64(System.UInt64 v64, System.Int32 shift)
  System.UInt64 Mul128Fold64(System.UInt64 lhs, System.UInt64 rhs)
  System.UInt64 Mix16(System.Byte* input, System.Byte* secret, System.UInt64 seed)
  Unity.Collections.xxHash3.ulong2 Mix32(Unity.Collections.xxHash3.ulong2 acc, System.Byte* input_1, System.Byte* input_2, System.Byte* secret, System.UInt64 seed)
  System.UInt64 Avalanche(System.UInt64 h64)
  System.UInt64 AvalancheH64(System.UInt64 h64)
  System.UInt64 rrmxmx(System.UInt64 h64, System.UInt64 length)
  System.UInt64 Mix2Acc(System.UInt64 acc0, System.UInt64 acc1, System.Byte* secret)
  System.UInt64 MergeAcc(System.UInt64* acc, System.Byte* secret, System.UInt64 start)
  System.Void DefaultHashLongInternalLoop(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, System.Int32 isHash64)
  System.Void DefaultAccumulate(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Byte* secret, System.Int64 nbStripes, System.Int32 isHash64)
  System.Void DefaultAccumulate512(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Byte* secret, System.Int32 isHash64)
  System.Void DefaultScrambleAcc(System.UInt64* acc, System.Byte* secret)
  System.UInt64 Hash64Long$BurstManaged(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret)
  System.Void Hash128Long$BurstManaged(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, Unity.Mathematics.uint4& result)
END_CLASS

CLASS: Unity.Collections.xxHashDefaultKey
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  public    static readonly System.Byte[]                   kSecret  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeListUnsafeUtility
TYPE:  class
TOKEN: 0x2000098
FIELDS:
METHODS:
  System.Void* GetUnsafePtr(Unity.Collections.NativeList<T> list)
  System.Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeList<T> list)
  System.Void* GetInternalListDataPtrUnchecked(Unity.Collections.NativeList<T>& list)
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeReferenceUnsafeUtility
TYPE:  class
TOKEN: 0x2000099
FIELDS:
METHODS:
  System.Void* GetUnsafePtr(Unity.Collections.NativeReference<T> reference)
  System.Void* GetUnsafePtrWithoutChecks(Unity.Collections.NativeReference<T> reference)
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Byte*                    Ptr  // 0x10
  public            System.Int32                    Length  // 0x18
  public            System.Int32                    Capacity  // 0x1C
  public            Unity.Collections.AllocatorManager.AllocatorHandleAllocator  // 0x20
  public    readonly System.Int32                    Alignment  // 0x24
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeDisposeJob
TYPE:  struct
TOKEN: 0x200009B
FIELDS:
  public            System.Void*                    Ptr  // 0x10
  public            Unity.Collections.AllocatorManager.AllocatorHandleAllocator  // 0x18
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList
TYPE:  struct
TOKEN: 0x200009C
FIELDS:
  public            System.Void*                    Ptr  // 0x10
  public            System.Int32                    m_length  // 0x18
  public            System.Int32                    m_capacity  // 0x1C
  public            Unity.Collections.AllocatorManager.AllocatorHandleAllocator  // 0x20
  private           System.Int32                    obsolete_length  // 0x24
  private           System.Int32                    obsolete_capacity  // 0x28
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeList`1
TYPE:  struct
TOKEN: 0x200009D
FIELDS:
  public            T*                              Ptr  // 0x0
  public            System.Int32                    m_length  // 0x0
  public            System.Int32                    m_capacity  // 0x0
  public            Unity.Collections.AllocatorManager.AllocatorHandleAllocator  // 0x0
  public            System.Int32                    length  // 0x0
  public            System.Int32                    capacity  // 0x0
METHODS:
  System.Int32 get_Length()
  System.Int32 get_Capacity()
  System.Void set_Capacity(System.Int32 value)
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  T& ElementAt(System.Int32 index)
  System.Void .ctor(System.Int32 initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options)
  Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* Create(System.Int32 initialCapacity, U& allocator, Unity.Collections.NativeArrayOptions options)
  Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* Create(System.Int32 initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options)
  System.Void Destroy(Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* listData)
  System.Boolean get_IsCreated()
  System.Void Dispose()
  Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps)
  Unity.Jobs.JobHandle CrossFrameDispose(Unity.Jobs.JobHandle inputDeps, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority)
  System.Void Clear()
  System.Void Resize(System.Int32 length, Unity.Collections.NativeArrayOptions options)
  System.Void Realloc(U& allocator, System.Int32 newCapacity)
  System.Void SetCapacity(U& allocator, System.Int32 capacity)
  System.Void SetCapacity(System.Int32 capacity)
  System.Void AddNoResize(T value)
  System.Void Add(T& value)
  System.Void AddRange(System.Void* ptr, System.Int32 count)
  System.Void RemoveAtSwapBack(System.Int32 index)
  System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveRange(System.Int32 index, System.Int32 count)
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<T> AsParallelReader()
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<T> AsParallelWriter()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeListTDebugView`1
TYPE:  class
TOKEN: 0x20000A0
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData
TYPE:  struct
TOKEN: 0x20000A1
FIELDS:
  private           System.Byte*                    values  // 0x10
  private           System.Byte*                    keys  // 0x18
  private           System.Byte*                    next  // 0x20
  private           System.Byte*                    buckets  // 0x28
  private           System.Int32                    keyCapacity  // 0x30
  private           System.Int32                    bucketCapacityMask  // 0x34
  private           System.Int32                    allocatedIndexLength  // 0x38
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData.<firstFreeTLS>e__FixedBufferfirstFreeTLS  // 0x50
  private   static  System.Int32                    IntsPerCacheLine  // 0x0
METHODS:
  System.Int32 GetBucketSize(System.Int32 capacity)
  System.Int32 GrowCapacity(System.Int32 capacity)
  System.Void AllocateHashMap(System.Int32 length, System.Int32 bucketLength, Unity.Collections.AllocatorManager.AllocatorHandle label, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*& outBuf)
  System.Void ReallocateHashMap(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, System.Int32 newCapacity, System.Int32 newBucketCapacity, Unity.Collections.AllocatorManager.AllocatorHandle label)
  System.Void DeallocateHashMap(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Int32 CalculateDataSize(System.Int32 length, System.Int32 bucketLength, System.Int32& keyOffset, System.Int32& nextOffset, System.Int32& bucketOffset)
  System.Boolean IsEmpty(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data)
  System.Int32 GetCount(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data)
  System.Boolean MoveNext(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, System.Int32& bucketIndex, System.Int32& nextIndex, System.Int32& index)
  System.Void GetKeyArray(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.NativeArray<TKey> result)
  System.Void GetValueArray(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.NativeArray<TValue> result)
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataDispose
TYPE:  struct
TOKEN: 0x20000A3
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*m_Buffer  // 0x10
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_AllocatorLabel  // 0x18
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataDisposeJob
TYPE:  struct
TOKEN: 0x20000A4
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataDisposeData  // 0x10
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2
TYPE:  struct
TOKEN: 0x20000A5
FIELDS:
METHODS:
  System.Void Clear(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data)
  System.Int32 AllocEntry(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, System.Int32 threadIndex)
  System.Void FreeEntry(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, System.Int32 idx, System.Int32 threadIndex)
  System.Boolean TryAddAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue item, System.Int32 threadIndex)
  System.Void AddAtomicMulti(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue item, System.Int32 threadIndex)
  System.Boolean TryAdd(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue item, System.Boolean isMultiHashMap, Unity.Collections.AllocatorManager.AllocatorHandle allocation)
  System.Int32 Remove(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, System.Boolean isMultiHashMap)
  System.Void Remove(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it)
  System.Boolean TryGetFirstValueAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it)
  System.Boolean TryGetNextValueAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it)
  System.Boolean SetValue(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it, TValue& item)
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.KeyValue`2
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*m_Buffer  // 0x0
  private           System.Int32                    m_Index  // 0x0
  private           System.Int32                    m_Next  // 0x0
METHODS:
  TKey get_Key()
  TValue& get_Value()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataEnumerator
TYPE:  struct
TOKEN: 0x20000A7
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*m_Buffer  // 0x10
  private           System.Int32                    m_Index  // 0x18
  private           System.Int32                    m_BucketIndex  // 0x1C
  private           System.Int32                    m_NextIndex  // 0x20
METHODS:
  System.Void .ctor(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data)
  System.Boolean MoveNext()
  System.Void Reset()
  Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue> GetCurrent()
  TKey GetCurrentKey()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap`2
TYPE:  struct
TOKEN: 0x20000A8
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*m_Buffer  // 0x0
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_AllocatorLabel  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Boolean get_IsEmpty()
  System.Int32 Count()
  System.Int32 get_Capacity()
  System.Void set_Capacity(System.Int32 value)
  System.Void Clear()
  System.Boolean TryAdd(TKey key, TValue item)
  System.Boolean Remove(TKey key)
  System.Boolean TryGetValue(TKey key, TValue& item)
  System.Boolean ContainsKey(TKey key)
  System.Void set_Item(TKey key, TValue value)
  System.Boolean get_IsCreated()
  System.Void Dispose()
  Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<TKey,TValue> AsParallelWriter()
  System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDisposeJob
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  public            Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*Data  // 0x10
  public            Unity.Collections.AllocatorManager.AllocatorHandleAllocator  // 0x18
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDebuggerTypeProxy`2
TYPE:  class
TOKEN: 0x20000AB
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSet`1
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<T,System.Boolean>m_Data  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Void Dispose()
  System.Void Clear()
  System.Boolean Add(T item)
  System.Boolean Remove(T item)
  System.Boolean Contains(T item)
  Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSet.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeHashSetDebuggerTypeProxy`1
TYPE:  class
TOKEN: 0x20000AE
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.HashSetExtensions
TYPE:  class
TOKEN: 0x20000AF
FIELDS:
METHODS:
  System.Void UnionWith(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSet<T> other)
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMap`2
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*m_Buffer  // 0x0
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_AllocatorLabel  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Boolean get_IsEmpty()
  System.Int32 Count()
  System.Int32 get_Capacity()
  System.Void Clear()
  System.Void Add(TKey key, TValue item)
  System.Int32 Remove(TKey key)
  System.Void Remove(Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it)
  System.Boolean TryGetFirstValue(TKey key, TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it)
  System.Boolean TryGetNextValue(TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it)
  System.Boolean SetValue(TValue item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it)
  System.Boolean get_IsCreated()
  System.Void Dispose()
  Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator)
  System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMapDebuggerTypeProxy`2
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock
TYPE:  struct
TOKEN: 0x20000B3
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock*Next  // 0x10
  private           Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock.<Data>e__FixedBufferData  // 0x18
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeStreamRange
TYPE:  struct
TOKEN: 0x20000B5
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock*Block  // 0x10
  private           System.Int32                    OffsetInFirstBlock  // 0x18
  private           System.Int32                    ElementCount  // 0x1C
  private           System.Int32                    LastOffset  // 0x20
  private           System.Int32                    NumberOfBlocks  // 0x24
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlockData
TYPE:  struct
TOKEN: 0x20000B6
FIELDS:
  private           Unity.Collections.AllocatorManager.AllocatorHandleAllocator  // 0x10
  private           Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock**Blocks  // 0x18
  private           System.Int32                    BlockCount  // 0x20
  private           Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock*Free  // 0x28
  private           Unity.Collections.LowLevel.Unsafe.UnsafeStreamRange*Ranges  // 0x30
  private           System.Int32                    RangeCount  // 0x38
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeStream
TYPE:  struct
TOKEN: 0x20000B7
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlockData*m_Block  // 0x10
  private           Unity.Collections.AllocatorManager.AllocatorHandlem_Allocator  // 0x18
METHODS:
  System.Void AllocateForEach(System.Int32 forEachCount)
  System.Void Deallocate()
  System.Void Dispose()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeUtilityExtensions
TYPE:  class
TOKEN: 0x20000BB
FIELDS:
METHODS:
  System.Void* AddressOf(T& value)
  T& AsRef(T& value)
  System.IntPtr Malloc(System.Int64 size, System.Int32 alignment, Unity.Collections.Allocator allocator)
END_CLASS

CLASS: Unity.Collections.NotBurstCompatible.Extensions
TYPE:  class
TOKEN: 0x2000097
FIELDS:
METHODS:
  T[] ToArrayNBC(Unity.Collections.NativeList<T> list)
END_CLASS

CLASS: Unity.Jobs.EarlyInitHelpers
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.Void JobReflectionDataCreationFailed(System.Exception ex, System.Type jobType)
END_CLASS

CLASS: Unity.Jobs.IJobBurstSchedulable
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Unity.Jobs.IJobBurstSchedulableExtensions
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Jobs.IJobParallelForBatch
TYPE:  interface
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
END_CLASS

CLASS: Unity.Jobs.IJobParallelForBatchExtensions
TYPE:  class
TOKEN: 0x200000A
FIELDS:
METHODS:
  System.Void EarlyJobInit()
  Unity.Jobs.JobHandle ScheduleBatch(T jobData, System.Int32 arrayLength, System.Int32 minIndicesPerJobCount, Unity.Jobs.JobHandle dependsOn)
END_CLASS

CLASS: Unity.Jobs.IJobParallelForBurstSchedulable
TYPE:  interface
TOKEN: 0x200000D
FIELDS:
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Unity.Jobs.IJobParallelForExtensionsBurstSchedulable
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Jobs.IJobParallelForDefer
TYPE:  interface
TOKEN: 0x2000011
FIELDS:
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Unity.Jobs.IJobParallelForDeferExtensions
TYPE:  class
TOKEN: 0x2000012
FIELDS:
METHODS:
  System.Void EarlyJobInit()
  Unity.Jobs.JobHandle Schedule(T jobData, Unity.Collections.NativeList<U> list, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle Schedule(T jobData, System.Int32* forEachCount, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ScheduleByRef(T& jobData, System.Int32* forEachCount, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ScheduleInternal(T& jobData, System.Int32 innerloopBatchCount, System.Void* forEachListPtr, System.Void* atomicSafetyHandlePtr, Unity.Jobs.JobHandle dependsOn)
END_CLASS

CLASS: Unity.Jobs.IJobParallelForFilter
TYPE:  interface
TOKEN: 0x2000015
FIELDS:
METHODS:
  System.Boolean Execute(System.Int32 index)
END_CLASS

CLASS: Unity.Jobs.JobParallelIndexListExtensions
TYPE:  class
TOKEN: 0x2000016
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Jobs.DOTSCompilerGeneratedAttribute
TYPE:  class
TOKEN: 0x200001A
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

