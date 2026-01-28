// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Collections.dll
// Classes:  191
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000008
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x2000007
    public struct JobBurstSchedulableProducer`1
    {
        // Fields
        private static readonly Unity.Burst.SharedStatic<System.IntPtr> jobReflectionData;        // 0x0

        // Methods
        private System.Void Initialize() { }
        private System.Void Execute(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000C
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x200000B
    public struct JobParallelForBatchProducer`1
    {
        // Fields
        private static readonly Unity.Burst.SharedStatic<System.IntPtr> jobReflectionData;        // 0x0

        // Methods
        private System.Void Initialize() { }
        private System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000010
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x200000F
    public struct JobParallelForBurstSchedulableProducer`1
    {
        // Fields
        private static readonly Unity.Burst.SharedStatic<System.IntPtr> jobReflectionData;        // 0x0

        // Methods
        private System.Void Initialize() { }
        private System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000014
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x2000013
    public struct JobParallelForDeferProducer`1
    {
        // Fields
        private static readonly Unity.Burst.SharedStatic<System.IntPtr> jobReflectionData;        // 0x0

        // Methods
        private System.Void Initialize() { }
        private System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000018
    public struct JobWrapper
    {
        // Fields
        public Unity.Collections.NativeList<System.Int32> outputIndices;        // 0x0
        public System.Int32 appendCount;        // 0x0
        public T JobData;        // 0x0

    }

    // TypeToken: 0x2000019
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Unity.Jobs.JobParallelIndexListExtensions.JobParallelForFilterProducer.JobWrapper<T>& jobWrapper, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x2000017
    public struct JobParallelForFilterProducer`1
    {
        // Fields
        private static readonly Unity.Burst.SharedStatic<System.IntPtr> jobReflectionData;        // 0x0

        // Methods
        private System.Void Initialize() { }
        private System.Void Execute(Unity.Jobs.JobParallelIndexListExtensions.JobParallelForFilterProducer.JobWrapper<T>& jobWrapper, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }
        private System.Void ExecuteAppend(Unity.Jobs.JobParallelIndexListExtensions.JobParallelForFilterProducer.JobWrapper<T>& jobWrapper, System.IntPtr bufferRangePatchData) { }
        private System.Void ExecuteFilter(Unity.Jobs.JobParallelIndexListExtensions.JobParallelForFilterProducer.JobWrapper<T>& jobWrapper, System.IntPtr bufferRangePatchData) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001C
    public class TryFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x200001D
    public struct AllocatorHandle, IAllocator, IDisposable
    {
        // Fields
        public System.UInt16 Index;        // 0x10
        public System.UInt16 Version;        // 0x12

        // Methods
        private Unity.Collections.AllocatorManager.TableEntry& get_TableEntry() { }
        private System.Void Rewind() { }
        private Unity.Collections.AllocatorManager.AllocatorHandle op_Implicit(Unity.Collections.Allocator a) { }
        private System.Int32 get_Value() { }
        private System.Int32 Try(Unity.Collections.AllocatorManager.Block& block) { }
        private Unity.Collections.AllocatorManager.AllocatorHandle get_Handle() { }
        private Unity.Collections.Allocator get_ToAllocator() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200001E
    public struct Range, IDisposable
    {
        // Fields
        public System.IntPtr Pointer;        // 0x10
        public System.Int32 Items;        // 0x18
        public Unity.Collections.AllocatorManager.AllocatorHandle Allocator;        // 0x1C

        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200001F
    public struct Block, IDisposable
    {
        // Fields
        public Unity.Collections.AllocatorManager.Range Range;        // 0x10
        public System.Int32 BytesPerItem;        // 0x20
        public System.Int32 AllocatedItems;        // 0x24
        public System.Byte Log2Alignment;        // 0x28
        public System.Byte Padding0;        // 0x29
        public System.UInt16 Padding1;        // 0x2A
        public System.UInt32 Padding2;        // 0x2C

        // Methods
        private System.Int64 get_Bytes() { }
        private System.Int64 get_AllocatedBytes() { }
        private System.Int32 get_Alignment() { }
        private System.Void set_Alignment(System.Int32 value) { }
        private System.Void Dispose() { }
        private System.Int32 TryFree() { }

    }

    // TypeToken: 0x2000020
    public interface IAllocator : IDisposable
    {
        // Methods
        private System.Int32 Try(Unity.Collections.AllocatorManager.Block& block) { }
        private Unity.Collections.AllocatorManager.AllocatorHandle get_Handle() { }

    }

    // TypeToken: 0x2000022
    public class Try_000000A0$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x2000023
    public class Try_000000A0$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x2000021
    public struct StackAllocator, IAllocator, IDisposable
    {
        // Fields
        private Unity.Collections.AllocatorManager.AllocatorHandle m_handle;        // 0x10
        private Unity.Collections.AllocatorManager.Block m_storage;        // 0x18
        private System.Int64 m_top;        // 0x38

        // Methods
        private Unity.Collections.AllocatorManager.AllocatorHandle get_Handle() { }
        private System.Int32 Try(Unity.Collections.AllocatorManager.Block& block) { }
        private System.Int32 Try(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block) { }
        private System.Void Dispose() { }
        private System.Int32 Try$BurstManaged(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x2000025
    public class Try_000000AE$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x2000026
    public class Try_000000AE$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Int32 Invoke(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x2000024
    public struct SlabAllocator, IAllocator, IDisposable
    {
        // Fields
        private Unity.Collections.AllocatorManager.AllocatorHandle m_handle;        // 0x10
        private Unity.Collections.AllocatorManager.Block Storage;        // 0x18
        private System.Int32 Log2SlabSizeInBytes;        // 0x38
        private Unity.Collections.FixedList4096Bytes<System.Int32> Occupied;        // 0x3C
        private System.Int64 budgetInBytes;        // 0x1040
        private System.Int64 allocatedBytes;        // 0x1048

        // Methods
        private Unity.Collections.AllocatorManager.AllocatorHandle get_Handle() { }
        private System.Int32 get_SlabSizeInBytes() { }
        private System.Int32 Try(Unity.Collections.AllocatorManager.Block& block) { }
        private System.Int32 Try(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block) { }
        private System.Void Dispose() { }
        private System.Int32 Try$BurstManaged(System.IntPtr allocatorState, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x2000027
    public struct TableEntry
    {
        // Fields
        private System.IntPtr function;        // 0x10
        private System.IntPtr state;        // 0x18

    }

    // TypeToken: 0x2000028
    public struct Array16`1
    {
        // Fields
        private T f0;        // 0x0
        private T f1;        // 0x0
        private T f2;        // 0x0
        private T f3;        // 0x0
        private T f4;        // 0x0
        private T f5;        // 0x0
        private T f6;        // 0x0
        private T f7;        // 0x0
        private T f8;        // 0x0
        private T f9;        // 0x0
        private T f10;        // 0x0
        private T f11;        // 0x0
        private T f12;        // 0x0
        private T f13;        // 0x0
        private T f14;        // 0x0
        private T f15;        // 0x0

    }

    // TypeToken: 0x2000029
    public struct Array256`1
    {
        // Fields
        private Unity.Collections.AllocatorManager.Array16<T> f0;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f1;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f2;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f3;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f4;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f5;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f6;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f7;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f8;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f9;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f10;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f11;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f12;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f13;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f14;        // 0x0
        private Unity.Collections.AllocatorManager.Array16<T> f15;        // 0x0

    }

    // TypeToken: 0x200002A
    public struct Array4096`1
    {
        // Fields
        private Unity.Collections.AllocatorManager.Array256<T> f0;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f1;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f2;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f3;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f4;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f5;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f6;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f7;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f8;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f9;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f10;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f11;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f12;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f13;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f14;        // 0x0
        private Unity.Collections.AllocatorManager.Array256<T> f15;        // 0x0

    }

    // TypeToken: 0x200002B
    public struct Array32768`1, IIndexable`1
    {
        // Fields
        private Unity.Collections.AllocatorManager.Array4096<T> f0;        // 0x0
        private Unity.Collections.AllocatorManager.Array4096<T> f1;        // 0x0
        private Unity.Collections.AllocatorManager.Array4096<T> f2;        // 0x0
        private Unity.Collections.AllocatorManager.Array4096<T> f3;        // 0x0
        private Unity.Collections.AllocatorManager.Array4096<T> f4;        // 0x0
        private Unity.Collections.AllocatorManager.Array4096<T> f5;        // 0x0
        private Unity.Collections.AllocatorManager.Array4096<T> f6;        // 0x0
        private Unity.Collections.AllocatorManager.Array4096<T> f7;        // 0x0

        // Methods
        private System.Int32 get_Length() { }
        private T& ElementAt(System.Int32 index) { }

    }

    // TypeToken: 0x200002D
    public class TableEntry
    {
        // Fields
        private static readonly Unity.Burst.SharedStatic<Unity.Collections.AllocatorManager.Array32768<Unity.Collections.AllocatorManager.TableEntry>> Ref;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002C
    public class SharedStatics
    {
    }

    // TypeToken: 0x200002E
    public class Managed
    {
        // Fields
        private static Unity.Collections.AllocatorManager.TryFunction[] TryFunctionDelegates;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000044
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private Unity.Collections.FixedList512Bytes<T> m_List;        // 0x0
        private System.Int32 m_Index;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.FixedList512Bytes<T>& list) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x200005A
    public struct Array
    {
        // Methods
        private System.Boolean IsCustom(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void* CustomResize(System.Void* oldPointer, System.Int64 oldCount, System.Int64 newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int64 size, System.Int32 align) { }
        private System.Void* Resize(System.Void* oldPointer, System.Int64 oldCount, System.Int64 newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int64 size, System.Int32 align) { }
        private T* Resize(T* oldPointer, System.Int64 oldCount, System.Int64 newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }

    }

    // TypeToken: 0x2000059
    public struct Unmanaged
    {
        // Methods
        private System.Void* Allocate(System.Int64 size, System.Int32 align, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void Free(System.Void* pointer, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void Free(T* pointer, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }

    }

    // TypeToken: 0x200005F
    public struct ParallelWriter
    {
        // Fields
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* ListData;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* listData) { }
        private System.Void AddNoResize(T value) { }

    }

    // TypeToken: 0x2000064
    public struct ParallelWriter
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<TKey,TValue> m_Writer;        // 0x0

        // Methods
        private System.Boolean TryAdd(TKey key, TValue item) { }

    }

    // TypeToken: 0x2000065
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataEnumerator m_Enumerator;        // 0x0

        // Methods
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue> get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x2000069
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataEnumerator m_Enumerator;        // 0x0

        // Methods
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x200006D
    public struct ParallelWriter
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMap.ParallelWriter<TKey,TValue> m_Writer;        // 0x0

        // Methods
        private System.Void Add(TKey key, TValue item) { }

    }

    // TypeToken: 0x200006E
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private Unity.Collections.NativeParallelMultiHashMap<TKey,TValue> hashmap;        // 0x0
        private TKey key;        // 0x0
        private System.Boolean isFirst;        // 0x0
        private TValue value;        // 0x0
        private Unity.Collections.NativeParallelMultiHashMapIterator<TKey> iterator;        // 0x0

        // Methods
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private TValue get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private Unity.Collections.NativeParallelMultiHashMap.Enumerator<TKey,TValue> GetEnumerator() { }

    }

    // TypeToken: 0x2000075
    public struct ParallelWriter
    {
        // Fields
        private Unity.Collections.NativeQueueData* m_Buffer;        // 0x0
        private Unity.Collections.NativeQueueBlockPoolData* m_QueuePool;        // 0x0
        private System.Int32 m_ThreadIndex;        // 0x0

        // Methods
        private System.Void Enqueue(T value) { }

    }

    // TypeToken: 0x200007C
    public struct DefaultComparer`1, IComparer`1
    {
        // Methods
        private System.Int32 Compare(T x, T y) { }

    }

    // TypeToken: 0x200007E
    public struct SegmentSort, IJobParallelFor
    {
        // Fields
        public T* Data;        // 0x0
        public U Comp;        // 0x0
        public System.Int32 Length;        // 0x0
        public System.Int32 SegmentWidth;        // 0x0

        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200007F
    public struct SegmentSortMerge, IJob
    {
        // Fields
        public T* Data;        // 0x0
        public U Comp;        // 0x0
        public System.Int32 Length;        // 0x0
        public System.Int32 SegmentWidth;        // 0x0

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000081
    public struct ConstructJobList, IJob
    {
        // Fields
        public Unity.Collections.NativeStream Container;        // 0x10
        public Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* List;        // 0x20

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000082
    public struct ConstructJob, IJob
    {
        // Fields
        public Unity.Collections.NativeStream Container;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> Length;        // 0x20

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000086
    public struct MemoryBlock, IDisposable
    {
        // Fields
        public System.Byte* m_pointer;        // 0x10
        public System.Int64 m_bytes;        // 0x18
        public System.Int64 m_current;        // 0x20
        public System.Int64 m_allocations;        // 0x28

        // Methods
        private System.Void .ctor(System.Int64 bytes) { }
        private System.Void Rewind() { }
        private System.Void Dispose() { }
        private System.Int32 TryAllocate(Unity.Collections.AllocatorManager.Block& block) { }
        private System.Boolean Contains(System.IntPtr ptr) { }

    }

    // TypeToken: 0x200008D
    public struct Rune
    {
        // Fields
        public System.Int32 value;        // 0x10

    }

    // TypeToken: 0x200008F
    public struct Comparison
    {
        // Fields
        public System.Boolean terminates;        // 0x10
        public System.Int32 result;        // 0x14

        // Methods
        private System.Void .ctor(Unity.Collections.Unicode.Rune runeA, Unity.Collections.ConversionError errorA, Unity.Collections.Unicode.Rune runeB, Unity.Collections.ConversionError errorB) { }

    }

    // TypeToken: 0x2000091
    public struct ulong2
    {
        // Fields
        public System.UInt64 x;        // 0x10
        public System.UInt64 y;        // 0x18

        // Methods
        private System.Void .ctor(System.UInt64 x, System.UInt64 y) { }

    }

    // TypeToken: 0x200009E
    public struct ParallelReader
    {
        // Fields
        public readonly T* Ptr;        // 0x0
        public readonly System.Int32 Length;        // 0x0

        // Methods
        private System.Void .ctor(T* ptr, System.Int32 length) { }

    }

    // TypeToken: 0x200009F
    public struct ParallelWriter
    {
        // Fields
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* ListData;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* listData) { }
        private System.Void AddNoResize(T value) { }

    }

    // TypeToken: 0x20000A9
    public struct ParallelWriter
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;        // 0x0
        private System.Int32 m_ThreadIndex;        // 0x0

        // Methods
        private System.Boolean TryAdd(TKey key, TValue item) { }

    }

    // TypeToken: 0x20000AD
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataEnumerator m_Enumerator;        // 0x0

        // Methods
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x20000B1
    public struct ParallelWriter
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;        // 0x0
        private System.Int32 m_ThreadIndex;        // 0x0

        // Methods
        private System.Void Add(TKey key, TValue item) { }

    }

    // TypeToken: 0x20000B8
    public struct DisposeJob, IJob
    {
        // Fields
        public Unity.Collections.LowLevel.Unsafe.UnsafeStream Container;        // 0x10

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000B9
    public struct ConstructJobList, IJob
    {
        // Fields
        public Unity.Collections.LowLevel.Unsafe.UnsafeStream Container;        // 0x10
        public Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* List;        // 0x20

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000BA
    public struct ConstructJob, IJob
    {
        // Fields
        public Unity.Collections.LowLevel.Unsafe.UnsafeStream Container;        // 0x10
        public Unity.Collections.NativeArray<System.Int32> Length;        // 0x20

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000BD
    public struct __StaticArrayInitTypeSize=192
    {
    }

    // TypeToken: 0x20000BE
    public class __JobReflectionRegistrationOutput__3250816150
    {
        // Methods
        private System.Void CreateJobReflectionData() { }
        private System.Void EarlyInit() { }

    }

    // TypeToken: 0x20000BF
    public class $BurstDirectCallInitializer
    {
        // Methods
        private System.Void Initialize() { }

    }

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002
    public class EmbeddedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class IsUnmanagedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Unity.Collections
{

    // TypeToken: 0x200001B
    public class AllocatorManager
    {
        // Fields
        public static readonly Unity.Collections.AllocatorManager.AllocatorHandle Invalid;        // 0x0
        public static readonly Unity.Collections.AllocatorManager.AllocatorHandle None;        // 0x4
        public static readonly Unity.Collections.AllocatorManager.AllocatorHandle Temp;        // 0x8
        public static readonly Unity.Collections.AllocatorManager.AllocatorHandle TempJob;        // 0xC
        public static readonly Unity.Collections.AllocatorManager.AllocatorHandle Persistent;        // 0x10
        public static readonly Unity.Collections.AllocatorManager.AllocatorHandle AudioKernel;        // 0x14

        // Methods
        private Unity.Collections.AllocatorManager.Block AllocateBlock(T& t, System.Int32 sizeOf, System.Int32 alignOf, System.Int32 items) { }
        private System.Void* Allocate(T& t, System.Int32 sizeOf, System.Int32 alignOf, System.Int32 items) { }
        private U* Allocate(T& t, U u, System.Int32 items) { }
        private System.Void* AllocateStruct(T& t, U u, System.Int32 items) { }
        private System.Void FreeBlock(T& t, Unity.Collections.AllocatorManager.Block& block) { }
        private System.Void Free(T& t, System.Void* pointer, System.Int32 sizeOf, System.Int32 alignOf, System.Int32 items) { }
        private System.Void Free(T& t, U* pointer, System.Int32 items) { }
        private System.Void* Allocate(Unity.Collections.AllocatorManager.AllocatorHandle handle, System.Int32 itemSizeInBytes, System.Int32 alignmentInBytes, System.Int32 items) { }
        private T* Allocate(Unity.Collections.AllocatorManager.AllocatorHandle handle, System.Int32 items) { }
        private System.Void Free(Unity.Collections.AllocatorManager.AllocatorHandle handle, System.Void* pointer) { }
        private System.Void Free(Unity.Collections.AllocatorManager.AllocatorHandle handle, T* pointer, System.Int32 items) { }
        private System.Void CheckDelegate(System.Boolean& useDelegate) { }
        private System.Boolean UseDelegate() { }
        private System.Int32 allocate_block(Unity.Collections.AllocatorManager.Block& block) { }
        private System.Void forward_mono_allocate_block(Unity.Collections.AllocatorManager.Block& block, System.Int32& error) { }
        private Unity.Collections.Allocator LegacyOf(Unity.Collections.AllocatorManager.AllocatorHandle handle) { }
        private System.Int32 TryLegacy(Unity.Collections.AllocatorManager.Block& block) { }
        private System.Int32 Try(Unity.Collections.AllocatorManager.Block& block) { }
        private System.Boolean IsCustomAllocator(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void .cctor() { }
        private System.Void Initialize$StackAllocator_Try_000000A0$BurstDirectCall() { }
        private System.Void Initialize$SlabAllocator_Try_000000AE$BurstDirectCall() { }

    }

    // TypeToken: 0x200002F
    public class CreatePropertyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000030
    public struct Bitwise
    {
        // Methods
        private System.Int32 FromBool(System.Boolean value) { }
        private System.UInt32 ExtractBits(System.UInt32 input, System.Int32 pos, System.UInt32 mask) { }
        private System.UInt32 ReplaceBits(System.UInt32 input, System.Int32 pos, System.UInt32 mask, System.UInt32 value) { }
        private System.UInt32 SetBits(System.UInt32 input, System.Int32 pos, System.UInt32 mask, System.Boolean value) { }
        private System.UInt64 ExtractBits(System.UInt64 input, System.Int32 pos, System.UInt64 mask) { }
        private System.UInt64 ReplaceBits(System.UInt64 input, System.Int32 pos, System.UInt64 mask, System.UInt64 value) { }
        private System.UInt64 SetBits(System.UInt64 input, System.Int32 pos, System.UInt64 mask, System.Boolean value) { }

    }

    // TypeToken: 0x2000031
    public struct BitField32
    {
        // Fields
        public System.UInt32 Value;        // 0x10

        // Methods
        private System.Void SetBits(System.Int32 pos, System.Boolean value) { }
        private System.UInt32 GetBits(System.Int32 pos, System.Int32 numBits) { }
        private System.Boolean IsSet(System.Int32 pos) { }

    }

    // TypeToken: 0x2000032
    public class BitField32DebugView
    {
    }

    // TypeToken: 0x2000033
    public struct BitField64
    {
        // Fields
        public System.UInt64 Value;        // 0x10

        // Methods
        private System.Void SetBits(System.Int32 pos, System.Boolean value) { }
        private System.UInt64 GetBits(System.Int32 pos, System.Int32 numBits) { }
        private System.Boolean IsSet(System.Int32 pos) { }
        private System.Boolean TestAny(System.Int32 pos, System.Int32 numBits) { }

    }

    // TypeToken: 0x2000034
    public class BitField64DebugView
    {
    }

    // TypeToken: 0x2000035
    public class BurstCompatibleAttribute : Attribute
    {
        // Fields
        private System.Type[] <GenericTypeArguments>k__BackingField;        // 0x10
        public System.String RequiredUnityDefine;        // 0x18

        // Methods
        private System.Void set_GenericTypeArguments(System.Type[] value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000036
    public class NotBurstCompatibleAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public interface INativeDisposable : IDisposable
    {
    }

    // TypeToken: 0x2000038
    public class CollectionHelper
    {
        // Methods
        private System.Int32 Log2Floor(System.Int32 value) { }
        private System.Int32 Align(System.Int32 size, System.Int32 alignmentPowerOfTwo) { }
        private System.UInt32 Hash(System.Void* ptr, System.Int32 bytes) { }
        private System.Boolean ShouldDeallocate(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Int32 AssumePositive(System.Int32 value) { }
        private Unity.Collections.NativeArray<T> CreateNativeArray(System.Int32 length, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options) { }
        private Unity.Collections.NativeArray<T> CreateNativeArray(T[] array, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }

    }

    // TypeToken: 0x2000039
    public struct FixedList
    {
        // Methods
        private System.Int32 PaddingBytes() { }
        private System.Int32 StorageBytes() { }
        private System.Int32 Capacity() { }

    }

    // TypeToken: 0x200003A
    public struct FixedList32Bytes`1, INativeList`1, IIndexable`1, IEnumerable`1, IEnumerable, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1
    {
        // Fields
        private System.UInt16 length;        // 0x0
        private Unity.Collections.FixedBytes30 buffer;        // 0x0

        // Methods
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.Int32 get_LengthInBytes() { }
        private System.Byte* get_Buffer() { }
        private System.Int32 get_Capacity() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private T& ElementAt(System.Int32 index) { }
        private System.Int32 GetHashCode() { }
        private System.Void Add(T& item) { }
        private System.Void RemoveAtSwapBack(System.Int32 index) { }
        private System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveRange(System.Int32 index, System.Int32 count) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

    }

    // TypeToken: 0x200003B
    public class FixedList32BytesExtensions
    {
        // Methods
        private System.Int32 IndexOf(Unity.Collections.FixedList32Bytes<T>& list, U value) { }
        private System.Boolean Contains(Unity.Collections.FixedList32Bytes<T>& list, U value) { }

    }

    // TypeToken: 0x200003C
    public class FixedList32BytesDebugView`1
    {
    }

    // TypeToken: 0x200003D
    public struct FixedList64Bytes`1, INativeList`1, IIndexable`1, IEnumerable`1, IEnumerable, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1
    {
        // Fields
        private System.UInt16 length;        // 0x0
        private Unity.Collections.FixedBytes62 buffer;        // 0x0

        // Methods
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.Int32 get_LengthInBytes() { }
        private System.Byte* get_Buffer() { }
        private System.Int32 get_Capacity() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private T& ElementAt(System.Int32 index) { }
        private System.Int32 GetHashCode() { }
        private System.Void Add(T& item) { }
        private System.Void RemoveAtSwapBack(System.Int32 index) { }
        private System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveRange(System.Int32 index, System.Int32 count) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

    }

    // TypeToken: 0x200003E
    public class FixedList64BytesExtensions
    {
        // Methods
        private System.Int32 IndexOf(Unity.Collections.FixedList64Bytes<T>& list, U value) { }
        private System.Boolean Contains(Unity.Collections.FixedList64Bytes<T>& list, U value) { }

    }

    // TypeToken: 0x200003F
    public class FixedList64BytesDebugView`1
    {
    }

    // TypeToken: 0x2000040
    public struct FixedList128Bytes`1, INativeList`1, IIndexable`1, IEnumerable`1, IEnumerable, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1
    {
        // Fields
        private System.UInt16 length;        // 0x0
        private Unity.Collections.FixedBytes126 buffer;        // 0x0

        // Methods
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 get_LengthInBytes() { }
        private System.Byte* get_Buffer() { }
        private System.Int32 get_Capacity() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private T& ElementAt(System.Int32 index) { }
        private System.Int32 GetHashCode() { }
        private System.Void Add(T& item) { }
        private System.Void AddNoResize(T& item) { }
        private System.Void Clear() { }
        private System.Void RemoveAtSwapBack(System.Int32 index) { }
        private System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveRange(System.Int32 index, System.Int32 count) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

    }

    // TypeToken: 0x2000041
    public class FixedList128BytesExtensions
    {
        // Methods
        private System.Int32 IndexOf(Unity.Collections.FixedList128Bytes<T>& list, U value) { }
        private System.Boolean Contains(Unity.Collections.FixedList128Bytes<T>& list, U value) { }
        private System.Boolean Remove(Unity.Collections.FixedList128Bytes<T>& list, U value) { }

    }

    // TypeToken: 0x2000042
    public class FixedList128BytesDebugView`1
    {
    }

    // TypeToken: 0x2000043
    public struct FixedList512Bytes`1, INativeList`1, IIndexable`1, IEnumerable`1, IEnumerable, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1
    {
        // Fields
        private System.UInt16 length;        // 0x0
        private Unity.Collections.FixedBytes510 buffer;        // 0x0

        // Methods
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 get_LengthInBytes() { }
        private System.Byte* get_Buffer() { }
        private System.Int32 get_Capacity() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private T& ElementAt(System.Int32 index) { }
        private System.Int32 GetHashCode() { }
        private System.Void Add(T& item) { }
        private System.Void Clear() { }
        private System.Void RemoveAtSwapBack(System.Int32 index) { }
        private System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveRange(System.Int32 index, System.Int32 count) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private Unity.Collections.FixedList512Bytes.Enumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

    }

    // TypeToken: 0x2000045
    public class FixedList512BytesExtensions
    {
        // Methods
        private System.Int32 IndexOf(Unity.Collections.FixedList512Bytes<T>& list, U value) { }
        private System.Boolean Contains(Unity.Collections.FixedList512Bytes<T>& list, U value) { }
        private System.Boolean Remove(Unity.Collections.FixedList512Bytes<T>& list, U value) { }

    }

    // TypeToken: 0x2000046
    public class FixedList512BytesDebugView`1
    {
    }

    // TypeToken: 0x2000047
    public struct FixedList4096Bytes`1, INativeList`1, IIndexable`1, IEnumerable`1, IEnumerable, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1
    {
        // Fields
        private System.UInt16 length;        // 0x0
        private Unity.Collections.FixedBytes4094 buffer;        // 0x0

        // Methods
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 get_LengthInBytes() { }
        private System.Byte* get_Buffer() { }
        private System.Int32 get_Capacity() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private T& ElementAt(System.Int32 index) { }
        private System.Int32 GetHashCode() { }
        private System.Void Add(T& item) { }
        private System.Void Clear() { }
        private System.Void RemoveAtSwapBack(System.Int32 index) { }
        private System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveRange(System.Int32 index, System.Int32 count) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList32Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList64Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList128Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList512Bytes<T> other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(Unity.Collections.FixedList4096Bytes<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

    }

    // TypeToken: 0x2000048
    public class FixedList4096BytesExtensions
    {
        // Methods
        private System.Int32 IndexOf(Unity.Collections.FixedList4096Bytes<T>& list, U value) { }
        private System.Boolean Contains(Unity.Collections.FixedList4096Bytes<T>& list, U value) { }

    }

    // TypeToken: 0x2000049
    public class FixedList4096BytesDebugView`1
    {
    }

    // TypeToken: 0x200004A
    public struct FixedBytes16
    {
        // Fields
        public System.Byte byte0000;        // 0x10
        public System.Byte byte0001;        // 0x11
        public System.Byte byte0002;        // 0x12
        public System.Byte byte0003;        // 0x13
        public System.Byte byte0004;        // 0x14
        public System.Byte byte0005;        // 0x15
        public System.Byte byte0006;        // 0x16
        public System.Byte byte0007;        // 0x17
        public System.Byte byte0008;        // 0x18
        public System.Byte byte0009;        // 0x19
        public System.Byte byte0010;        // 0x1A
        public System.Byte byte0011;        // 0x1B
        public System.Byte byte0012;        // 0x1C
        public System.Byte byte0013;        // 0x1D
        public System.Byte byte0014;        // 0x1E
        public System.Byte byte0015;        // 0x1F

    }

    // TypeToken: 0x200004B
    public struct FixedBytes30
    {
        // Fields
        public Unity.Collections.FixedBytes16 offset0000;        // 0x10
        public System.Byte byte0016;        // 0x20
        public System.Byte byte0017;        // 0x21
        public System.Byte byte0018;        // 0x22
        public System.Byte byte0019;        // 0x23
        public System.Byte byte0020;        // 0x24
        public System.Byte byte0021;        // 0x25
        public System.Byte byte0022;        // 0x26
        public System.Byte byte0023;        // 0x27
        public System.Byte byte0024;        // 0x28
        public System.Byte byte0025;        // 0x29
        public System.Byte byte0026;        // 0x2A
        public System.Byte byte0027;        // 0x2B
        public System.Byte byte0028;        // 0x2C
        public System.Byte byte0029;        // 0x2D

    }

    // TypeToken: 0x200004C
    public struct FixedString32Bytes, INativeList`1, IIndexable`1, IUTF8Bytes, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1
    {
        // Fields
        private static System.UInt16 utf8MaxLengthInBytes;        // 0x0
        private System.UInt16 utf8LengthInBytes;        // 0x10
        private Unity.Collections.FixedBytes30 bytes;        // 0x12

        // Methods
        private System.String get_Value() { }
        private System.Byte* GetUnsafePtr() { }
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 CompareTo(System.String other) { }
        private System.Boolean Equals(System.String other) { }
        private System.Void .ctor(System.String source) { }
        private System.Int32 Initialize(System.String source) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString32Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString32Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString64Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString64Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString128Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString128Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString512Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString512Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString32Bytes& a, Unity.Collections.FixedString4096Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString4096Bytes other) { }
        private Unity.Collections.FixedString32Bytes op_Implicit(System.String b) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x200004D
    public struct FixedBytes62
    {
        // Fields
        public Unity.Collections.FixedBytes16 offset0000;        // 0x10
        public Unity.Collections.FixedBytes16 offset0016;        // 0x20
        public Unity.Collections.FixedBytes16 offset0032;        // 0x30
        public System.Byte byte0048;        // 0x40
        public System.Byte byte0049;        // 0x41
        public System.Byte byte0050;        // 0x42
        public System.Byte byte0051;        // 0x43
        public System.Byte byte0052;        // 0x44
        public System.Byte byte0053;        // 0x45
        public System.Byte byte0054;        // 0x46
        public System.Byte byte0055;        // 0x47
        public System.Byte byte0056;        // 0x48
        public System.Byte byte0057;        // 0x49
        public System.Byte byte0058;        // 0x4A
        public System.Byte byte0059;        // 0x4B
        public System.Byte byte0060;        // 0x4C
        public System.Byte byte0061;        // 0x4D

    }

    // TypeToken: 0x200004E
    public struct FixedString64Bytes, INativeList`1, IIndexable`1, IUTF8Bytes, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1
    {
        // Fields
        private static System.UInt16 utf8MaxLengthInBytes;        // 0x0
        private System.UInt16 utf8LengthInBytes;        // 0x10
        private Unity.Collections.FixedBytes62 bytes;        // 0x12

        // Methods
        private System.String get_Value() { }
        private System.Byte* GetUnsafePtr() { }
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 CompareTo(System.String other) { }
        private System.Boolean Equals(System.String other) { }
        private System.Void .ctor(System.String source) { }
        private System.Int32 Initialize(System.String source) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString32Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString32Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString64Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString64Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString128Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString128Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString512Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString512Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString64Bytes& a, Unity.Collections.FixedString4096Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString4096Bytes other) { }
        private Unity.Collections.FixedString64Bytes op_Implicit(System.String b) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x200004F
    public struct FixedBytes126
    {
        // Fields
        public Unity.Collections.FixedBytes16 offset0000;        // 0x10
        public Unity.Collections.FixedBytes16 offset0016;        // 0x20
        public Unity.Collections.FixedBytes16 offset0032;        // 0x30
        public Unity.Collections.FixedBytes16 offset0048;        // 0x40
        public Unity.Collections.FixedBytes16 offset0064;        // 0x50
        public Unity.Collections.FixedBytes16 offset0080;        // 0x60
        public Unity.Collections.FixedBytes16 offset0096;        // 0x70
        public System.Byte byte0112;        // 0x80
        public System.Byte byte0113;        // 0x81
        public System.Byte byte0114;        // 0x82
        public System.Byte byte0115;        // 0x83
        public System.Byte byte0116;        // 0x84
        public System.Byte byte0117;        // 0x85
        public System.Byte byte0118;        // 0x86
        public System.Byte byte0119;        // 0x87
        public System.Byte byte0120;        // 0x88
        public System.Byte byte0121;        // 0x89
        public System.Byte byte0122;        // 0x8A
        public System.Byte byte0123;        // 0x8B
        public System.Byte byte0124;        // 0x8C
        public System.Byte byte0125;        // 0x8D

    }

    // TypeToken: 0x2000050
    public struct FixedString128Bytes, INativeList`1, IIndexable`1, IUTF8Bytes, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1
    {
        // Fields
        private static System.UInt16 utf8MaxLengthInBytes;        // 0x0
        private System.UInt16 utf8LengthInBytes;        // 0x10
        private Unity.Collections.FixedBytes126 bytes;        // 0x12

        // Methods
        private System.Byte* GetUnsafePtr() { }
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions) { }
        private System.Int32 CompareTo(System.String other) { }
        private System.Boolean Equals(System.String other) { }
        private System.Void .ctor(System.String source) { }
        private System.Int32 Initialize(System.String source) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString32Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString32Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString64Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString64Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString128Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString128Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString512Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString512Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString128Bytes& a, Unity.Collections.FixedString4096Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString4096Bytes other) { }
        private Unity.Collections.FixedString128Bytes op_Implicit(System.String b) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x2000051
    public struct FixedBytes510
    {
        // Fields
        public Unity.Collections.FixedBytes16 offset0000;        // 0x10
        public Unity.Collections.FixedBytes16 offset0016;        // 0x20
        public Unity.Collections.FixedBytes16 offset0032;        // 0x30
        public Unity.Collections.FixedBytes16 offset0048;        // 0x40
        public Unity.Collections.FixedBytes16 offset0064;        // 0x50
        public Unity.Collections.FixedBytes16 offset0080;        // 0x60
        public Unity.Collections.FixedBytes16 offset0096;        // 0x70
        public Unity.Collections.FixedBytes16 offset0112;        // 0x80
        public Unity.Collections.FixedBytes16 offset0128;        // 0x90
        public Unity.Collections.FixedBytes16 offset0144;        // 0xA0
        public Unity.Collections.FixedBytes16 offset0160;        // 0xB0
        public Unity.Collections.FixedBytes16 offset0176;        // 0xC0
        public Unity.Collections.FixedBytes16 offset0192;        // 0xD0
        public Unity.Collections.FixedBytes16 offset0208;        // 0xE0
        public Unity.Collections.FixedBytes16 offset0224;        // 0xF0
        public Unity.Collections.FixedBytes16 offset0240;        // 0x100
        public Unity.Collections.FixedBytes16 offset0256;        // 0x110
        public Unity.Collections.FixedBytes16 offset0272;        // 0x120
        public Unity.Collections.FixedBytes16 offset0288;        // 0x130
        public Unity.Collections.FixedBytes16 offset0304;        // 0x140
        public Unity.Collections.FixedBytes16 offset0320;        // 0x150
        public Unity.Collections.FixedBytes16 offset0336;        // 0x160
        public Unity.Collections.FixedBytes16 offset0352;        // 0x170
        public Unity.Collections.FixedBytes16 offset0368;        // 0x180
        public Unity.Collections.FixedBytes16 offset0384;        // 0x190
        public Unity.Collections.FixedBytes16 offset0400;        // 0x1A0
        public Unity.Collections.FixedBytes16 offset0416;        // 0x1B0
        public Unity.Collections.FixedBytes16 offset0432;        // 0x1C0
        public Unity.Collections.FixedBytes16 offset0448;        // 0x1D0
        public Unity.Collections.FixedBytes16 offset0464;        // 0x1E0
        public Unity.Collections.FixedBytes16 offset0480;        // 0x1F0
        public System.Byte byte0496;        // 0x200
        public System.Byte byte0497;        // 0x201
        public System.Byte byte0498;        // 0x202
        public System.Byte byte0499;        // 0x203
        public System.Byte byte0500;        // 0x204
        public System.Byte byte0501;        // 0x205
        public System.Byte byte0502;        // 0x206
        public System.Byte byte0503;        // 0x207
        public System.Byte byte0504;        // 0x208
        public System.Byte byte0505;        // 0x209
        public System.Byte byte0506;        // 0x20A
        public System.Byte byte0507;        // 0x20B
        public System.Byte byte0508;        // 0x20C
        public System.Byte byte0509;        // 0x20D

    }

    // TypeToken: 0x2000052
    public struct FixedString512Bytes, INativeList`1, IIndexable`1, IUTF8Bytes, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1
    {
        // Fields
        private System.UInt16 utf8LengthInBytes;        // 0x10
        private Unity.Collections.FixedBytes510 bytes;        // 0x12

        // Methods
        private System.Byte* GetUnsafePtr() { }
        private System.Int32 get_Length() { }
        private System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions) { }
        private System.Int32 CompareTo(System.String other) { }
        private System.Boolean Equals(System.String other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString32Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString32Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString64Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString64Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString128Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString128Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString512Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString512Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString512Bytes& a, Unity.Collections.FixedString4096Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString4096Bytes other) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x2000053
    public struct FixedBytes4094
    {
        // Fields
        public Unity.Collections.FixedBytes16 offset0000;        // 0x10
        public Unity.Collections.FixedBytes16 offset0016;        // 0x20
        public Unity.Collections.FixedBytes16 offset0032;        // 0x30
        public Unity.Collections.FixedBytes16 offset0048;        // 0x40
        public Unity.Collections.FixedBytes16 offset0064;        // 0x50
        public Unity.Collections.FixedBytes16 offset0080;        // 0x60
        public Unity.Collections.FixedBytes16 offset0096;        // 0x70
        public Unity.Collections.FixedBytes16 offset0112;        // 0x80
        public Unity.Collections.FixedBytes16 offset0128;        // 0x90
        public Unity.Collections.FixedBytes16 offset0144;        // 0xA0
        public Unity.Collections.FixedBytes16 offset0160;        // 0xB0
        public Unity.Collections.FixedBytes16 offset0176;        // 0xC0
        public Unity.Collections.FixedBytes16 offset0192;        // 0xD0
        public Unity.Collections.FixedBytes16 offset0208;        // 0xE0
        public Unity.Collections.FixedBytes16 offset0224;        // 0xF0
        public Unity.Collections.FixedBytes16 offset0240;        // 0x100
        public Unity.Collections.FixedBytes16 offset0256;        // 0x110
        public Unity.Collections.FixedBytes16 offset0272;        // 0x120
        public Unity.Collections.FixedBytes16 offset0288;        // 0x130
        public Unity.Collections.FixedBytes16 offset0304;        // 0x140
        public Unity.Collections.FixedBytes16 offset0320;        // 0x150
        public Unity.Collections.FixedBytes16 offset0336;        // 0x160
        public Unity.Collections.FixedBytes16 offset0352;        // 0x170
        public Unity.Collections.FixedBytes16 offset0368;        // 0x180
        public Unity.Collections.FixedBytes16 offset0384;        // 0x190
        public Unity.Collections.FixedBytes16 offset0400;        // 0x1A0
        public Unity.Collections.FixedBytes16 offset0416;        // 0x1B0
        public Unity.Collections.FixedBytes16 offset0432;        // 0x1C0
        public Unity.Collections.FixedBytes16 offset0448;        // 0x1D0
        public Unity.Collections.FixedBytes16 offset0464;        // 0x1E0
        public Unity.Collections.FixedBytes16 offset0480;        // 0x1F0
        public Unity.Collections.FixedBytes16 offset0496;        // 0x200
        public Unity.Collections.FixedBytes16 offset0512;        // 0x210
        public Unity.Collections.FixedBytes16 offset0528;        // 0x220
        public Unity.Collections.FixedBytes16 offset0544;        // 0x230
        public Unity.Collections.FixedBytes16 offset0560;        // 0x240
        public Unity.Collections.FixedBytes16 offset0576;        // 0x250
        public Unity.Collections.FixedBytes16 offset0592;        // 0x260
        public Unity.Collections.FixedBytes16 offset0608;        // 0x270
        public Unity.Collections.FixedBytes16 offset0624;        // 0x280
        public Unity.Collections.FixedBytes16 offset0640;        // 0x290
        public Unity.Collections.FixedBytes16 offset0656;        // 0x2A0
        public Unity.Collections.FixedBytes16 offset0672;        // 0x2B0
        public Unity.Collections.FixedBytes16 offset0688;        // 0x2C0
        public Unity.Collections.FixedBytes16 offset0704;        // 0x2D0
        public Unity.Collections.FixedBytes16 offset0720;        // 0x2E0
        public Unity.Collections.FixedBytes16 offset0736;        // 0x2F0
        public Unity.Collections.FixedBytes16 offset0752;        // 0x300
        public Unity.Collections.FixedBytes16 offset0768;        // 0x310
        public Unity.Collections.FixedBytes16 offset0784;        // 0x320
        public Unity.Collections.FixedBytes16 offset0800;        // 0x330
        public Unity.Collections.FixedBytes16 offset0816;        // 0x340
        public Unity.Collections.FixedBytes16 offset0832;        // 0x350
        public Unity.Collections.FixedBytes16 offset0848;        // 0x360
        public Unity.Collections.FixedBytes16 offset0864;        // 0x370
        public Unity.Collections.FixedBytes16 offset0880;        // 0x380
        public Unity.Collections.FixedBytes16 offset0896;        // 0x390
        public Unity.Collections.FixedBytes16 offset0912;        // 0x3A0
        public Unity.Collections.FixedBytes16 offset0928;        // 0x3B0
        public Unity.Collections.FixedBytes16 offset0944;        // 0x3C0
        public Unity.Collections.FixedBytes16 offset0960;        // 0x3D0
        public Unity.Collections.FixedBytes16 offset0976;        // 0x3E0
        public Unity.Collections.FixedBytes16 offset0992;        // 0x3F0
        public Unity.Collections.FixedBytes16 offset1008;        // 0x400
        public Unity.Collections.FixedBytes16 offset1024;        // 0x410
        public Unity.Collections.FixedBytes16 offset1040;        // 0x420
        public Unity.Collections.FixedBytes16 offset1056;        // 0x430
        public Unity.Collections.FixedBytes16 offset1072;        // 0x440
        public Unity.Collections.FixedBytes16 offset1088;        // 0x450
        public Unity.Collections.FixedBytes16 offset1104;        // 0x460
        public Unity.Collections.FixedBytes16 offset1120;        // 0x470
        public Unity.Collections.FixedBytes16 offset1136;        // 0x480
        public Unity.Collections.FixedBytes16 offset1152;        // 0x490
        public Unity.Collections.FixedBytes16 offset1168;        // 0x4A0
        public Unity.Collections.FixedBytes16 offset1184;        // 0x4B0
        public Unity.Collections.FixedBytes16 offset1200;        // 0x4C0
        public Unity.Collections.FixedBytes16 offset1216;        // 0x4D0
        public Unity.Collections.FixedBytes16 offset1232;        // 0x4E0
        public Unity.Collections.FixedBytes16 offset1248;        // 0x4F0
        public Unity.Collections.FixedBytes16 offset1264;        // 0x500
        public Unity.Collections.FixedBytes16 offset1280;        // 0x510
        public Unity.Collections.FixedBytes16 offset1296;        // 0x520
        public Unity.Collections.FixedBytes16 offset1312;        // 0x530
        public Unity.Collections.FixedBytes16 offset1328;        // 0x540
        public Unity.Collections.FixedBytes16 offset1344;        // 0x550
        public Unity.Collections.FixedBytes16 offset1360;        // 0x560
        public Unity.Collections.FixedBytes16 offset1376;        // 0x570
        public Unity.Collections.FixedBytes16 offset1392;        // 0x580
        public Unity.Collections.FixedBytes16 offset1408;        // 0x590
        public Unity.Collections.FixedBytes16 offset1424;        // 0x5A0
        public Unity.Collections.FixedBytes16 offset1440;        // 0x5B0
        public Unity.Collections.FixedBytes16 offset1456;        // 0x5C0
        public Unity.Collections.FixedBytes16 offset1472;        // 0x5D0
        public Unity.Collections.FixedBytes16 offset1488;        // 0x5E0
        public Unity.Collections.FixedBytes16 offset1504;        // 0x5F0
        public Unity.Collections.FixedBytes16 offset1520;        // 0x600
        public Unity.Collections.FixedBytes16 offset1536;        // 0x610
        public Unity.Collections.FixedBytes16 offset1552;        // 0x620
        public Unity.Collections.FixedBytes16 offset1568;        // 0x630
        public Unity.Collections.FixedBytes16 offset1584;        // 0x640
        public Unity.Collections.FixedBytes16 offset1600;        // 0x650
        public Unity.Collections.FixedBytes16 offset1616;        // 0x660
        public Unity.Collections.FixedBytes16 offset1632;        // 0x670
        public Unity.Collections.FixedBytes16 offset1648;        // 0x680
        public Unity.Collections.FixedBytes16 offset1664;        // 0x690
        public Unity.Collections.FixedBytes16 offset1680;        // 0x6A0
        public Unity.Collections.FixedBytes16 offset1696;        // 0x6B0
        public Unity.Collections.FixedBytes16 offset1712;        // 0x6C0
        public Unity.Collections.FixedBytes16 offset1728;        // 0x6D0
        public Unity.Collections.FixedBytes16 offset1744;        // 0x6E0
        public Unity.Collections.FixedBytes16 offset1760;        // 0x6F0
        public Unity.Collections.FixedBytes16 offset1776;        // 0x700
        public Unity.Collections.FixedBytes16 offset1792;        // 0x710
        public Unity.Collections.FixedBytes16 offset1808;        // 0x720
        public Unity.Collections.FixedBytes16 offset1824;        // 0x730
        public Unity.Collections.FixedBytes16 offset1840;        // 0x740
        public Unity.Collections.FixedBytes16 offset1856;        // 0x750
        public Unity.Collections.FixedBytes16 offset1872;        // 0x760
        public Unity.Collections.FixedBytes16 offset1888;        // 0x770
        public Unity.Collections.FixedBytes16 offset1904;        // 0x780
        public Unity.Collections.FixedBytes16 offset1920;        // 0x790
        public Unity.Collections.FixedBytes16 offset1936;        // 0x7A0
        public Unity.Collections.FixedBytes16 offset1952;        // 0x7B0
        public Unity.Collections.FixedBytes16 offset1968;        // 0x7C0
        public Unity.Collections.FixedBytes16 offset1984;        // 0x7D0
        public Unity.Collections.FixedBytes16 offset2000;        // 0x7E0
        public Unity.Collections.FixedBytes16 offset2016;        // 0x7F0
        public Unity.Collections.FixedBytes16 offset2032;        // 0x800
        public Unity.Collections.FixedBytes16 offset2048;        // 0x810
        public Unity.Collections.FixedBytes16 offset2064;        // 0x820
        public Unity.Collections.FixedBytes16 offset2080;        // 0x830
        public Unity.Collections.FixedBytes16 offset2096;        // 0x840
        public Unity.Collections.FixedBytes16 offset2112;        // 0x850
        public Unity.Collections.FixedBytes16 offset2128;        // 0x860
        public Unity.Collections.FixedBytes16 offset2144;        // 0x870
        public Unity.Collections.FixedBytes16 offset2160;        // 0x880
        public Unity.Collections.FixedBytes16 offset2176;        // 0x890
        public Unity.Collections.FixedBytes16 offset2192;        // 0x8A0
        public Unity.Collections.FixedBytes16 offset2208;        // 0x8B0
        public Unity.Collections.FixedBytes16 offset2224;        // 0x8C0
        public Unity.Collections.FixedBytes16 offset2240;        // 0x8D0
        public Unity.Collections.FixedBytes16 offset2256;        // 0x8E0
        public Unity.Collections.FixedBytes16 offset2272;        // 0x8F0
        public Unity.Collections.FixedBytes16 offset2288;        // 0x900
        public Unity.Collections.FixedBytes16 offset2304;        // 0x910
        public Unity.Collections.FixedBytes16 offset2320;        // 0x920
        public Unity.Collections.FixedBytes16 offset2336;        // 0x930
        public Unity.Collections.FixedBytes16 offset2352;        // 0x940
        public Unity.Collections.FixedBytes16 offset2368;        // 0x950
        public Unity.Collections.FixedBytes16 offset2384;        // 0x960
        public Unity.Collections.FixedBytes16 offset2400;        // 0x970
        public Unity.Collections.FixedBytes16 offset2416;        // 0x980
        public Unity.Collections.FixedBytes16 offset2432;        // 0x990
        public Unity.Collections.FixedBytes16 offset2448;        // 0x9A0
        public Unity.Collections.FixedBytes16 offset2464;        // 0x9B0
        public Unity.Collections.FixedBytes16 offset2480;        // 0x9C0
        public Unity.Collections.FixedBytes16 offset2496;        // 0x9D0
        public Unity.Collections.FixedBytes16 offset2512;        // 0x9E0
        public Unity.Collections.FixedBytes16 offset2528;        // 0x9F0
        public Unity.Collections.FixedBytes16 offset2544;        // 0xA00
        public Unity.Collections.FixedBytes16 offset2560;        // 0xA10
        public Unity.Collections.FixedBytes16 offset2576;        // 0xA20
        public Unity.Collections.FixedBytes16 offset2592;        // 0xA30
        public Unity.Collections.FixedBytes16 offset2608;        // 0xA40
        public Unity.Collections.FixedBytes16 offset2624;        // 0xA50
        public Unity.Collections.FixedBytes16 offset2640;        // 0xA60
        public Unity.Collections.FixedBytes16 offset2656;        // 0xA70
        public Unity.Collections.FixedBytes16 offset2672;        // 0xA80
        public Unity.Collections.FixedBytes16 offset2688;        // 0xA90
        public Unity.Collections.FixedBytes16 offset2704;        // 0xAA0
        public Unity.Collections.FixedBytes16 offset2720;        // 0xAB0
        public Unity.Collections.FixedBytes16 offset2736;        // 0xAC0
        public Unity.Collections.FixedBytes16 offset2752;        // 0xAD0
        public Unity.Collections.FixedBytes16 offset2768;        // 0xAE0
        public Unity.Collections.FixedBytes16 offset2784;        // 0xAF0
        public Unity.Collections.FixedBytes16 offset2800;        // 0xB00
        public Unity.Collections.FixedBytes16 offset2816;        // 0xB10
        public Unity.Collections.FixedBytes16 offset2832;        // 0xB20
        public Unity.Collections.FixedBytes16 offset2848;        // 0xB30
        public Unity.Collections.FixedBytes16 offset2864;        // 0xB40
        public Unity.Collections.FixedBytes16 offset2880;        // 0xB50
        public Unity.Collections.FixedBytes16 offset2896;        // 0xB60
        public Unity.Collections.FixedBytes16 offset2912;        // 0xB70
        public Unity.Collections.FixedBytes16 offset2928;        // 0xB80
        public Unity.Collections.FixedBytes16 offset2944;        // 0xB90
        public Unity.Collections.FixedBytes16 offset2960;        // 0xBA0
        public Unity.Collections.FixedBytes16 offset2976;        // 0xBB0
        public Unity.Collections.FixedBytes16 offset2992;        // 0xBC0
        public Unity.Collections.FixedBytes16 offset3008;        // 0xBD0
        public Unity.Collections.FixedBytes16 offset3024;        // 0xBE0
        public Unity.Collections.FixedBytes16 offset3040;        // 0xBF0
        public Unity.Collections.FixedBytes16 offset3056;        // 0xC00
        public Unity.Collections.FixedBytes16 offset3072;        // 0xC10
        public Unity.Collections.FixedBytes16 offset3088;        // 0xC20
        public Unity.Collections.FixedBytes16 offset3104;        // 0xC30
        public Unity.Collections.FixedBytes16 offset3120;        // 0xC40
        public Unity.Collections.FixedBytes16 offset3136;        // 0xC50
        public Unity.Collections.FixedBytes16 offset3152;        // 0xC60
        public Unity.Collections.FixedBytes16 offset3168;        // 0xC70
        public Unity.Collections.FixedBytes16 offset3184;        // 0xC80
        public Unity.Collections.FixedBytes16 offset3200;        // 0xC90
        public Unity.Collections.FixedBytes16 offset3216;        // 0xCA0
        public Unity.Collections.FixedBytes16 offset3232;        // 0xCB0
        public Unity.Collections.FixedBytes16 offset3248;        // 0xCC0
        public Unity.Collections.FixedBytes16 offset3264;        // 0xCD0
        public Unity.Collections.FixedBytes16 offset3280;        // 0xCE0
        public Unity.Collections.FixedBytes16 offset3296;        // 0xCF0
        public Unity.Collections.FixedBytes16 offset3312;        // 0xD00
        public Unity.Collections.FixedBytes16 offset3328;        // 0xD10
        public Unity.Collections.FixedBytes16 offset3344;        // 0xD20
        public Unity.Collections.FixedBytes16 offset3360;        // 0xD30
        public Unity.Collections.FixedBytes16 offset3376;        // 0xD40
        public Unity.Collections.FixedBytes16 offset3392;        // 0xD50
        public Unity.Collections.FixedBytes16 offset3408;        // 0xD60
        public Unity.Collections.FixedBytes16 offset3424;        // 0xD70
        public Unity.Collections.FixedBytes16 offset3440;        // 0xD80
        public Unity.Collections.FixedBytes16 offset3456;        // 0xD90
        public Unity.Collections.FixedBytes16 offset3472;        // 0xDA0
        public Unity.Collections.FixedBytes16 offset3488;        // 0xDB0
        public Unity.Collections.FixedBytes16 offset3504;        // 0xDC0
        public Unity.Collections.FixedBytes16 offset3520;        // 0xDD0
        public Unity.Collections.FixedBytes16 offset3536;        // 0xDE0
        public Unity.Collections.FixedBytes16 offset3552;        // 0xDF0
        public Unity.Collections.FixedBytes16 offset3568;        // 0xE00
        public Unity.Collections.FixedBytes16 offset3584;        // 0xE10
        public Unity.Collections.FixedBytes16 offset3600;        // 0xE20
        public Unity.Collections.FixedBytes16 offset3616;        // 0xE30
        public Unity.Collections.FixedBytes16 offset3632;        // 0xE40
        public Unity.Collections.FixedBytes16 offset3648;        // 0xE50
        public Unity.Collections.FixedBytes16 offset3664;        // 0xE60
        public Unity.Collections.FixedBytes16 offset3680;        // 0xE70
        public Unity.Collections.FixedBytes16 offset3696;        // 0xE80
        public Unity.Collections.FixedBytes16 offset3712;        // 0xE90
        public Unity.Collections.FixedBytes16 offset3728;        // 0xEA0
        public Unity.Collections.FixedBytes16 offset3744;        // 0xEB0
        public Unity.Collections.FixedBytes16 offset3760;        // 0xEC0
        public Unity.Collections.FixedBytes16 offset3776;        // 0xED0
        public Unity.Collections.FixedBytes16 offset3792;        // 0xEE0
        public Unity.Collections.FixedBytes16 offset3808;        // 0xEF0
        public Unity.Collections.FixedBytes16 offset3824;        // 0xF00
        public Unity.Collections.FixedBytes16 offset3840;        // 0xF10
        public Unity.Collections.FixedBytes16 offset3856;        // 0xF20
        public Unity.Collections.FixedBytes16 offset3872;        // 0xF30
        public Unity.Collections.FixedBytes16 offset3888;        // 0xF40
        public Unity.Collections.FixedBytes16 offset3904;        // 0xF50
        public Unity.Collections.FixedBytes16 offset3920;        // 0xF60
        public Unity.Collections.FixedBytes16 offset3936;        // 0xF70
        public Unity.Collections.FixedBytes16 offset3952;        // 0xF80
        public Unity.Collections.FixedBytes16 offset3968;        // 0xF90
        public Unity.Collections.FixedBytes16 offset3984;        // 0xFA0
        public Unity.Collections.FixedBytes16 offset4000;        // 0xFB0
        public Unity.Collections.FixedBytes16 offset4016;        // 0xFC0
        public Unity.Collections.FixedBytes16 offset4032;        // 0xFD0
        public Unity.Collections.FixedBytes16 offset4048;        // 0xFE0
        public Unity.Collections.FixedBytes16 offset4064;        // 0xFF0
        public System.Byte byte4080;        // 0x1000
        public System.Byte byte4081;        // 0x1001
        public System.Byte byte4082;        // 0x1002
        public System.Byte byte4083;        // 0x1003
        public System.Byte byte4084;        // 0x1004
        public System.Byte byte4085;        // 0x1005
        public System.Byte byte4086;        // 0x1006
        public System.Byte byte4087;        // 0x1007
        public System.Byte byte4088;        // 0x1008
        public System.Byte byte4089;        // 0x1009
        public System.Byte byte4090;        // 0x100A
        public System.Byte byte4091;        // 0x100B
        public System.Byte byte4092;        // 0x100C
        public System.Byte byte4093;        // 0x100D

    }

    // TypeToken: 0x2000054
    public struct FixedString4096Bytes, INativeList`1, IIndexable`1, IUTF8Bytes, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1, IComparable`1, IEquatable`1
    {
        // Fields
        private System.UInt16 utf8LengthInBytes;        // 0x10
        private Unity.Collections.FixedBytes4094 bytes;        // 0x12

        // Methods
        private System.Byte* GetUnsafePtr() { }
        private System.Int32 get_Length() { }
        private System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions) { }
        private System.Int32 CompareTo(System.String other) { }
        private System.Boolean Equals(System.String other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString32Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString32Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString32Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString64Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString64Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString64Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString128Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString128Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString128Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString512Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString512Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString512Bytes other) { }
        private System.Int32 CompareTo(Unity.Collections.FixedString4096Bytes other) { }
        private System.Boolean op_Equality(Unity.Collections.FixedString4096Bytes& a, Unity.Collections.FixedString4096Bytes& b) { }
        private System.Boolean Equals(Unity.Collections.FixedString4096Bytes other) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x2000055
    public class FixedStringMethods
    {
        // Methods
        private Unity.Collections.FormatError Append(T& fs, System.Byte* utf8Bytes, System.Int32 utf8BytesLength) { }
        private Unity.Collections.FormatError Append(T& fs, System.String s) { }
        private System.Int32 CompareTo(T& fs, System.Byte* bytes, System.Int32 bytesLen) { }
        private System.Int32 CompareTo(T& fs, T2& other) { }
        private System.String ConvertToString(T& fs) { }
        private System.Int32 ComputeHashCode(T& fs) { }

    }

    // TypeToken: 0x2000056
    public interface IUTF8Bytes
    {
        // Methods
        private System.Byte* GetUnsafePtr() { }
        private System.Boolean TryResize(System.Int32 newLength, Unity.Collections.NativeArrayOptions clearOptions) { }

    }

    // TypeToken: 0x2000057
    public class ListExtensions
    {
        // Methods
        private System.Boolean RemoveSwapBack(System.Collections.Generic.List<T> list, T value) { }
        private System.Void RemoveAtSwapBack(System.Collections.Generic.List<T> list, System.Int32 index) { }
        private Unity.Collections.NativeArray<T> ToNativeArray(System.Collections.Generic.List<T> list, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }

    }

    // TypeToken: 0x2000058
    public struct Memory
    {
    }

    // TypeToken: 0x200005B
    public class NativeArrayExtensions
    {
        // Methods
        private System.Boolean Contains(Unity.Collections.NativeList<T> list, U value) { }
        private System.Span<T> AsSpan(Unity.Collections.NativeArray<T> array) { }
        private System.Span<T> AsSpanThread(Unity.Collections.NativeArray<T> array) { }
        private System.Int32 IndexOf(System.Void* ptr, System.Int32 length, U value) { }
        private Unity.Collections.NativeArray<U> Reinterpret(Unity.Collections.NativeArray<T> array) { }
        private System.Void Initialize(Unity.Collections.NativeArray<T>& array, System.Int32 length, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options) { }

    }

    // TypeToken: 0x200005C
    public interface IIndexable`1
    {
        // Methods
        private System.Int32 get_Length() { }

    }

    // TypeToken: 0x200005D
    public interface INativeList`1 : IIndexable`1
    {
    }

    // TypeToken: 0x200005E
    public struct NativeList`1, INativeDisposable, IDisposable, INativeList`1, IIndexable`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* m_ListData;        // 0x0
        private Unity.Collections.AllocatorManager.AllocatorHandle m_DeprecatedAllocator;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void .ctor(System.Int32 initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void Initialize(System.Int32 initialCapacity, U& allocator, System.Int32 disposeSentinelStackDepth) { }
        private System.Void .ctor(System.Int32 initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int32 disposeSentinelStackDepth) { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private T& ElementAt(System.Int32 index) { }
        private System.Int32 get_Length() { }
        private System.Int32 get_Capacity() { }
        private System.Void set_Capacity(System.Int32 value) { }
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* GetUnsafeList() { }
        private System.Void AddNoResize(T value) { }
        private System.Void Add(T& value) { }
        private System.Void AddRange(Unity.Collections.NativeArray<T> array) { }
        private System.Void AddRange(System.Void* ptr, System.Int32 count) { }
        private System.Void RemoveAtSwapBack(System.Int32 index) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveRange(System.Int32 index, System.Int32 count) { }
        private System.Boolean get_IsEmpty() { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps) { }
        private Unity.Jobs.JobHandle CrossFrameDispose(Unity.Jobs.JobHandle inputDeps, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority) { }
        private System.Void Clear() { }
        private Unity.Collections.NativeArray<T> op_Implicit(Unity.Collections.NativeList<T> nativeList) { }
        private Unity.Collections.NativeArray<T> AsArray() { }
        private Unity.Collections.NativeArray<T> AsDeferredJobArray() { }
        private T[] ToArray() { }
        private Unity.Collections.NativeArray.Enumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Void CopyFrom(Unity.Collections.NativeArray<T> array) { }
        private System.Void Resize(System.Int32 length, Unity.Collections.NativeArrayOptions options) { }
        private System.Void ResizeUninitialized(System.Int32 length) { }
        private Unity.Collections.NativeArray.ReadOnly<T> AsParallelReader() { }
        private Unity.Collections.NativeList.ParallelWriter<T> AsParallelWriter() { }

    }

    // TypeToken: 0x2000060
    public struct NativeListDispose
    {
        // Fields
        public Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* m_ListData;        // 0x10

        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000061
    public struct NativeListDisposeJob, IJob
    {
        // Fields
        private Unity.Collections.NativeListDispose Data;        // 0x10

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000062
    public class NativeListDebugView`1
    {
    }

    // TypeToken: 0x2000063
    public struct NativeParallelHashMap`2, INativeDisposable, IDisposable, IEnumerable`1, IEnumerable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<TKey,TValue> m_HashMapData;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int32 disposeSentinelStackDepth) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 Count() { }
        private System.Int32 get_Capacity() { }
        private System.Void set_Capacity(System.Int32 value) { }
        private System.Void Clear() { }
        private System.Boolean TryAdd(TKey key, TValue item) { }
        private System.Void Add(TKey key, TValue item) { }
        private System.Boolean Remove(TKey key) { }
        private System.Boolean TryGetValue(TKey key, TValue& item) { }
        private System.Boolean ContainsKey(TKey key) { }
        private TValue get_Item(TKey key) { }
        private System.Void set_Item(TKey key, TValue value) { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps) { }
        private Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private Unity.Collections.NativeParallelHashMap.ParallelWriter<TKey,TValue> AsParallelWriter() { }
        private Unity.Collections.NativeParallelHashMap.Enumerator<TKey,TValue> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000066
    public class NativeParallelHashMapDebuggerTypeProxy`2
    {
    }

    // TypeToken: 0x2000067
    public class NativeParallelHashMapExtensions
    {
        // Methods
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<TKey,TValue> GetUnsafeMap(Unity.Collections.NativeParallelHashMap<TKey,TValue> container) { }

    }

    // TypeToken: 0x2000068
    public struct NativeParallelHashSet`1, INativeDisposable, IDisposable, IEnumerable`1, IEnumerable
    {
        // Fields
        private Unity.Collections.NativeParallelHashMap<T,System.Boolean> m_Data;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 Count() { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private System.Void Clear() { }
        private System.Boolean Add(T item) { }
        private System.Boolean Remove(T item) { }
        private System.Boolean Contains(T item) { }
        private Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private Unity.Collections.NativeParallelHashSet.Enumerator<T> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200006A
    public class NativeHashSetDebuggerTypeProxy`1
    {
    }

    // TypeToken: 0x200006B
    public struct NativeParallelMultiHashMapIterator`1
    {
        // Fields
        private TKey key;        // 0x0
        private System.Int32 NextEntryIndex;        // 0x0
        private System.Int32 EntryIndex;        // 0x0

    }

    // TypeToken: 0x200006C
    public struct NativeParallelMultiHashMap`2, INativeDisposable, IDisposable, IEnumerable`1, IEnumerable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMap<TKey,TValue> m_MultiHashMapData;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void Initialize(System.Int32 capacity, U& allocator, System.Int32 disposeSentinelStackDepth) { }
        private System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, System.Int32 disposeSentinelStackDepth) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 Count() { }
        private System.Int32 get_Capacity() { }
        private System.Void Clear() { }
        private System.Void Add(TKey key, TValue item) { }
        private System.Int32 Remove(TKey key) { }
        private System.Void Remove(Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it) { }
        private System.Boolean TryGetFirstValue(TKey key, TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it) { }
        private System.Boolean TryGetNextValue(TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Int32 CountValuesForKey(TKey key) { }
        private System.Boolean SetValue(TValue item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it) { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private Unity.Collections.NativeParallelMultiHashMap.Enumerator<TKey,TValue> GetValuesForKey(TKey key) { }
        private System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200006F
    public class NativeParallelMultiHashMapDebuggerTypeProxy`2
    {
    }

    // TypeToken: 0x2000070
    public struct NativeQueueBlockHeader
    {
        // Fields
        public Unity.Collections.NativeQueueBlockHeader* m_NextBlock;        // 0x10
        public System.Int32 m_NumItems;        // 0x18

    }

    // TypeToken: 0x2000071
    public struct NativeQueueBlockPoolData
    {
        // Fields
        private System.IntPtr m_FirstBlock;        // 0x10
        private System.Int32 m_NumBlocks;        // 0x18
        private System.Int32 m_MaxBlocks;        // 0x1C
        private System.Int32 m_AllocLock;        // 0x20

        // Methods
        private Unity.Collections.NativeQueueBlockHeader* AllocateBlock() { }
        private System.Void FreeBlock(Unity.Collections.NativeQueueBlockHeader* block) { }

    }

    // TypeToken: 0x2000072
    public class NativeQueueBlockPool
    {
        // Fields
        private static readonly Unity.Burst.SharedStatic<System.IntPtr> Data;        // 0x0

        // Methods
        private Unity.Collections.NativeQueueBlockPoolData* GetQueueBlockPool() { }
        private System.Void AppDomainOnDomainUnload() { }
        private System.Void OnDomainUnload(System.Object sender, System.EventArgs e) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000073
    public struct NativeQueueData
    {
        // Fields
        public System.IntPtr m_FirstBlock;        // 0x10
        public System.IntPtr m_LastBlock;        // 0x18
        public System.Int32 m_MaxItems;        // 0x20
        public System.Int32 m_CurrentRead;        // 0x24
        public System.Byte* m_CurrentWriteBlockTLS;        // 0x28

        // Methods
        private Unity.Collections.NativeQueueBlockHeader* GetCurrentWriteBlockTLS(System.Int32 threadIndex) { }
        private System.Void SetCurrentWriteBlockTLS(System.Int32 threadIndex, Unity.Collections.NativeQueueBlockHeader* currentWriteBlock) { }
        private Unity.Collections.NativeQueueBlockHeader* AllocateWriteBlockMT(Unity.Collections.NativeQueueData* data, Unity.Collections.NativeQueueBlockPoolData* pool, System.Int32 threadIndex) { }
        private System.Void AllocateQueue(Unity.Collections.AllocatorManager.AllocatorHandle label, Unity.Collections.NativeQueueData*& outBuf) { }
        private System.Void DeallocateQueue(Unity.Collections.NativeQueueData* data, Unity.Collections.NativeQueueBlockPoolData* pool, Unity.Collections.AllocatorManager.AllocatorHandle allocation) { }

    }

    // TypeToken: 0x2000074
    public struct NativeQueue`1, INativeDisposable, IDisposable
    {
        // Fields
        private Unity.Collections.NativeQueueData* m_Buffer;        // 0x0
        private Unity.Collections.NativeQueueBlockPoolData* m_QueuePool;        // 0x0
        private Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Boolean IsEmpty() { }
        private System.Int32 get_Count() { }
        private System.Void Enqueue(T value) { }
        private System.Boolean TryDequeue(T& item) { }
        private Unity.Collections.NativeArray<T> ToArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void Clear() { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps) { }
        private Unity.Collections.NativeQueue.ParallelWriter<T> AsParallelWriter() { }

    }

    // TypeToken: 0x2000076
    public struct NativeQueueDispose
    {
        // Fields
        private Unity.Collections.NativeQueueData* m_Buffer;        // 0x10
        private Unity.Collections.NativeQueueBlockPoolData* m_QueuePool;        // 0x18
        private Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;        // 0x20

        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000077
    public struct NativeQueueDisposeJob, IJob
    {
        // Fields
        public Unity.Collections.NativeQueueDispose Data;        // 0x10

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000078
    public struct NativeReference`1, INativeDisposable, IDisposable, IEquatable`1
    {
        // Fields
        private System.Void* m_Data;        // 0x0
        private Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options) { }
        private System.Void .ctor(T value, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void Allocate(Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeReference<T>& reference) { }
        private T get_Value() { }
        private System.Void set_Value(T value) { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private System.Boolean Equals(Unity.Collections.NativeReference<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000079
    public struct NativeReferenceDispose
    {
        // Fields
        private System.Void* m_Data;        // 0x10
        private Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;        // 0x18

        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200007A
    public struct NativeReferenceDisposeJob, IJob
    {
        // Fields
        private Unity.Collections.NativeReferenceDispose Data;        // 0x10

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200007B
    public class NativeSortExtension
    {
        // Methods
        private System.Void Sort(T* array, System.Int32 length) { }
        private System.Void Sort(T* array, System.Int32 length, U comp) { }
        private Unity.Collections.SortJob<T,U> SortJob(T* array, System.Int32 length, U comp) { }
        private System.Int32 BinarySearch(T* ptr, System.Int32 length, T value) { }
        private System.Int32 BinarySearch(T* ptr, System.Int32 length, T value, U comp) { }
        private Unity.Collections.SortJob<T,Unity.Collections.NativeSortExtension.DefaultComparer<T>> SortJob(Unity.Collections.NativeArray<T> array) { }
        private System.Void Sort(Unity.Collections.NativeList<T> list) { }
        private System.Void Sort(Unity.Collections.NativeList<T> list, U comp) { }
        private System.Void IntroSort(System.Void* array, System.Int32 length, U comp) { }
        private System.Void IntroSort(System.Void* array, System.Int32 lo, System.Int32 hi, System.Int32 depth, U comp) { }
        private System.Void InsertionSort(System.Void* array, System.Int32 lo, System.Int32 hi, U comp) { }
        private System.Int32 Partition(System.Void* array, System.Int32 lo, System.Int32 hi, U comp) { }
        private System.Void HeapSort(System.Void* array, System.Int32 lo, System.Int32 hi, U comp) { }
        private System.Void Heapify(System.Void* array, System.Int32 i, System.Int32 n, System.Int32 lo, U comp) { }
        private System.Void Swap(System.Void* array, System.Int32 lhs, System.Int32 rhs) { }
        private System.Void SwapIfGreaterWithItems(System.Void* array, System.Int32 lhs, System.Int32 rhs, U comp) { }

    }

    // TypeToken: 0x200007D
    public struct SortJob`2
    {
        // Fields
        public T* Data;        // 0x0
        public U Comp;        // 0x0
        public System.Int32 Length;        // 0x0

        // Methods
        private Unity.Jobs.JobHandle Schedule(Unity.Jobs.JobHandle inputDeps) { }

    }

    // TypeToken: 0x2000080
    public struct NativeStream, IDisposable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeStream m_Stream;        // 0x10

        // Methods
        private System.Void Dispose() { }
        private System.Void AllocateForEach(System.Int32 forEachCount) { }

    }

    // TypeToken: 0x2000083
    public struct Spinner
    {
        // Fields
        private System.Int32 m_value;        // 0x10

        // Methods
        private System.Void Lock() { }
        private System.Void Unlock() { }

    }

    // TypeToken: 0x2000084
    public struct UnmanagedArray`1, IDisposable
    {
        // Fields
        private System.IntPtr m_pointer;        // 0x0
        private System.Int32 m_length;        // 0x0
        private Unity.Collections.AllocatorManager.AllocatorHandle m_allocator;        // 0x0

        // Methods
        private System.Void Dispose() { }
        private T& get_Item(System.Int32 index) { }

    }

    // TypeToken: 0x2000087
    public class Try_000008B6$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Int32 Invoke(System.IntPtr state, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x2000088
    public class Try_000008B6$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Int32 Invoke(System.IntPtr state, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x2000085
    public struct RewindableAllocator, IAllocator, IDisposable
    {
        // Fields
        private Unity.Collections.Spinner m_spinner;        // 0x10
        private Unity.Collections.AllocatorManager.AllocatorHandle m_handle;        // 0x14
        private Unity.Collections.UnmanagedArray<Unity.Collections.RewindableAllocator.MemoryBlock> m_block;        // 0x18
        private System.Int32 m_best;        // 0x28
        private System.Int32 m_last;        // 0x2C
        private System.Int32 m_used;        // 0x30
        private System.Boolean m_enableBlockFree;        // 0x34

        // Methods
        private System.Void Rewind() { }
        private System.Void Dispose() { }
        private System.Int32 Try(Unity.Collections.AllocatorManager.Block& block) { }
        private System.Int32 Try(System.IntPtr state, Unity.Collections.AllocatorManager.Block& block) { }
        private Unity.Collections.AllocatorManager.AllocatorHandle get_Handle() { }
        private System.Int32 Try$BurstManaged(System.IntPtr state, Unity.Collections.AllocatorManager.Block& block) { }

    }

    // TypeToken: 0x2000089
    public struct FormatError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Collections.FormatError None;        // 0x0
        public static Unity.Collections.FormatError Overflow;        // 0x0

    }

    // TypeToken: 0x200008A
    public struct CopyError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Collections.CopyError None;        // 0x0
        public static Unity.Collections.CopyError Truncation;        // 0x0

    }

    // TypeToken: 0x200008B
    public struct ConversionError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Collections.ConversionError None;        // 0x0
        public static Unity.Collections.ConversionError Overflow;        // 0x0
        public static Unity.Collections.ConversionError Encoding;        // 0x0
        public static Unity.Collections.ConversionError CodePoint;        // 0x0

    }

    // TypeToken: 0x200008C
    public struct Unicode
    {
        // Methods
        private System.Boolean IsValidCodePoint(System.Int32 codepoint) { }
        private System.Boolean NotTrailer(System.Byte b) { }
        private Unity.Collections.Unicode.Rune get_ReplacementCharacter() { }
        private Unity.Collections.ConversionError Utf8ToUcs(Unity.Collections.Unicode.Rune& rune, System.Byte* buffer, System.Int32& index, System.Int32 capacity) { }
        private System.Boolean IsLeadingSurrogate(System.Char c) { }
        private System.Boolean IsTrailingSurrogate(System.Char c) { }
        private Unity.Collections.ConversionError Utf16ToUcs(Unity.Collections.Unicode.Rune& rune, System.Char* buffer, System.Int32& index, System.Int32 capacity) { }
        private Unity.Collections.ConversionError UcsToUtf8(System.Byte* buffer, System.Int32& index, System.Int32 capacity, Unity.Collections.Unicode.Rune rune) { }
        private Unity.Collections.ConversionError UcsToUtf16(System.Char* buffer, System.Int32& index, System.Int32 capacity, Unity.Collections.Unicode.Rune rune) { }
        private Unity.Collections.ConversionError Utf16ToUtf8(System.Char* utf16Buffer, System.Int32 utf16Length, System.Byte* utf8Buffer, System.Int32& utf8Length, System.Int32 utf8Capacity) { }
        private Unity.Collections.ConversionError Utf8ToUtf16(System.Byte* utf8Buffer, System.Int32 utf8Length, System.Char* utf16Buffer, System.Int32& utf16Length, System.Int32 utf16Capacity) { }

    }

    // TypeToken: 0x200008E
    public class UTF8ArrayUnsafeUtility
    {
        // Methods
        private Unity.Collections.CopyError Copy(System.Byte* dest, System.Int32& destLength, System.Int32 destUTF8MaxLengthInBytes, System.Char* src, System.Int32 srcLength) { }
        private Unity.Collections.CopyError Copy(System.Byte* dest, System.UInt16& destLength, System.UInt16 destUTF8MaxLengthInBytes, System.Char* src, System.Int32 srcLength) { }
        private System.Int32 StrCmp(System.Byte* utf8BufferA, System.Int32 utf8LengthInBytesA, System.Byte* utf8BufferB, System.Int32 utf8LengthInBytesB) { }
        private System.Boolean EqualsUTF8Bytes(System.Byte* aBytes, System.Int32 aLength, System.Byte* bBytes, System.Int32 bLength) { }
        private System.Int32 StrCmp(System.Byte* utf8Buffer, System.Int32 utf8LengthInBytes, System.Char* utf16Buffer, System.Int32 utf16LengthInChars) { }

    }

    // TypeToken: 0x2000092
    public class Hash64Long_000008F7$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.UInt64 Invoke(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret) { }

    }

    // TypeToken: 0x2000093
    public class Hash64Long_000008F7$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.UInt64 Invoke(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret) { }

    }

    // TypeToken: 0x2000094
    public class Hash128Long_000008FE$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Void Invoke(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, Unity.Mathematics.uint4& result) { }

    }

    // TypeToken: 0x2000095
    public class Hash128Long_000008FE$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;        // 0x0
        private static System.IntPtr DeferredCompilation;        // 0x8

        // Methods
        private System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        private System.IntPtr GetFunctionPointer() { }
        private System.Void Constructor() { }
        private System.Void Initialize() { }
        private System.Void .cctor() { }
        private System.Void Invoke(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, Unity.Mathematics.uint4& result) { }

    }

    // TypeToken: 0x2000090
    public class xxHash3
    {
        // Methods
        private System.Void Avx2HashLongInternalLoop(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, System.Int32 isHash64) { }
        private System.Void Avx2ScrambleAcc(System.UInt64* acc, System.Byte* secret) { }
        private System.Void Avx2Accumulate(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Byte* secret, System.Int64 nbStripes, System.Int32 isHash64) { }
        private System.Void Avx2Accumulate512(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Byte* secret) { }
        private Unity.Mathematics.uint2 Hash64(System.Void* input, System.Int64 length) { }
        private Unity.Mathematics.uint4 Hash128(System.Void* input, System.Int64 length) { }
        private System.UInt64 Hash64Internal(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, System.UInt64 seed) { }
        private System.Void Hash128Internal(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result) { }
        private System.UInt64 Hash64Len1To3(System.Byte* input, System.Int64 len, System.Byte* secret, System.UInt64 seed) { }
        private System.UInt64 Hash64Len4To8(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed) { }
        private System.UInt64 Hash64Len9To16(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed) { }
        private System.UInt64 Hash64Len0To16(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed) { }
        private System.UInt64 Hash64Len17To128(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed) { }
        private System.UInt64 Hash64Len129To240(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed) { }
        private System.UInt64 Hash64Long(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret) { }
        private System.Void Hash128Len1To3(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result) { }
        private System.Void Hash128Len4To8(System.Byte* input, System.Int64 len, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result) { }
        private System.Void Hash128Len9To16(System.Byte* input, System.Int64 len, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result) { }
        private System.Void Hash128Len0To16(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result) { }
        private System.Void Hash128Len17To128(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result) { }
        private System.Void Hash128Len129To240(System.Byte* input, System.Int64 length, System.Byte* secret, System.UInt64 seed, Unity.Mathematics.uint4& result) { }
        private System.Void Hash128Long(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, Unity.Mathematics.uint4& result) { }
        private Unity.Mathematics.uint2 ToUint2(System.UInt64 u) { }
        private Unity.Mathematics.uint4 ToUint4(System.UInt64 ul0, System.UInt64 ul1) { }
        private System.Void EncodeSecretKey(System.Byte* dst, System.Byte* secret, System.UInt64 seed) { }
        private System.UInt64 Read64LE(System.Void* addr) { }
        private System.UInt32 Read32LE(System.Void* addr) { }
        private System.Void Write64LE(System.Void* addr, System.UInt64 value) { }
        private System.UInt64 Mul32To64(System.UInt32 x, System.UInt32 y) { }
        private System.UInt64 Swap64(System.UInt64 x) { }
        private System.UInt32 Swap32(System.UInt32 x) { }
        private System.UInt32 RotL32(System.UInt32 x, System.Int32 r) { }
        private System.UInt64 RotL64(System.UInt64 x, System.Int32 r) { }
        private System.UInt64 XorShift64(System.UInt64 v64, System.Int32 shift) { }
        private System.UInt64 Mul128Fold64(System.UInt64 lhs, System.UInt64 rhs) { }
        private System.UInt64 Mix16(System.Byte* input, System.Byte* secret, System.UInt64 seed) { }
        private Unity.Collections.xxHash3.ulong2 Mix32(Unity.Collections.xxHash3.ulong2 acc, System.Byte* input_1, System.Byte* input_2, System.Byte* secret, System.UInt64 seed) { }
        private System.UInt64 Avalanche(System.UInt64 h64) { }
        private System.UInt64 AvalancheH64(System.UInt64 h64) { }
        private System.UInt64 rrmxmx(System.UInt64 h64, System.UInt64 length) { }
        private System.UInt64 Mix2Acc(System.UInt64 acc0, System.UInt64 acc1, System.Byte* secret) { }
        private System.UInt64 MergeAcc(System.UInt64* acc, System.Byte* secret, System.UInt64 start) { }
        private System.Void DefaultHashLongInternalLoop(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, System.Int32 isHash64) { }
        private System.Void DefaultAccumulate(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Byte* secret, System.Int64 nbStripes, System.Int32 isHash64) { }
        private System.Void DefaultAccumulate512(System.UInt64* acc, System.Byte* input, System.Byte* dest, System.Byte* secret, System.Int32 isHash64) { }
        private System.Void DefaultScrambleAcc(System.UInt64* acc, System.Byte* secret) { }
        private System.UInt64 Hash64Long$BurstManaged(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret) { }
        private System.Void Hash128Long$BurstManaged(System.Byte* input, System.Byte* dest, System.Int64 length, System.Byte* secret, Unity.Mathematics.uint4& result) { }

    }

    // TypeToken: 0x2000096
    public class xxHashDefaultKey
    {
        // Fields
        public static readonly System.Byte[] kSecret;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

}

namespace Unity.Collections.LowLevel.Unsafe
{

    // TypeToken: 0x2000098
    public class NativeListUnsafeUtility
    {
        // Methods
        private System.Void* GetUnsafePtr(Unity.Collections.NativeList<T> list) { }
        private System.Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeList<T> list) { }
        private System.Void* GetInternalListDataPtrUnchecked(Unity.Collections.NativeList<T>& list) { }

    }

    // TypeToken: 0x2000099
    public class NativeReferenceUnsafeUtility
    {
        // Methods
        private System.Void* GetUnsafePtr(Unity.Collections.NativeReference<T> reference) { }
        private System.Void* GetUnsafePtrWithoutChecks(Unity.Collections.NativeReference<T> reference) { }

    }

    // TypeToken: 0x200009A
    public struct UnsafeAppendBuffer, INativeDisposable, IDisposable
    {
        // Fields
        public System.Byte* Ptr;        // 0x10
        public System.Int32 Length;        // 0x18
        public System.Int32 Capacity;        // 0x1C
        public Unity.Collections.AllocatorManager.AllocatorHandle Allocator;        // 0x20
        public readonly System.Int32 Alignment;        // 0x24

        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200009B
    public struct UnsafeDisposeJob, IJob
    {
        // Fields
        public System.Void* Ptr;        // 0x10
        public Unity.Collections.AllocatorManager.AllocatorHandle Allocator;        // 0x18

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200009C
    public struct UntypedUnsafeList
    {
        // Fields
        public System.Void* Ptr;        // 0x10
        public System.Int32 m_length;        // 0x18
        public System.Int32 m_capacity;        // 0x1C
        public Unity.Collections.AllocatorManager.AllocatorHandle Allocator;        // 0x20
        private System.Int32 obsolete_length;        // 0x24
        private System.Int32 obsolete_capacity;        // 0x28

    }

    // TypeToken: 0x200009D
    public struct UnsafeList`1, INativeDisposable, IDisposable, INativeList`1, IIndexable`1, IEnumerable`1, IEnumerable
    {
        // Fields
        public T* Ptr;        // 0x0
        public System.Int32 m_length;        // 0x0
        public System.Int32 m_capacity;        // 0x0
        public Unity.Collections.AllocatorManager.AllocatorHandle Allocator;        // 0x0
        public System.Int32 length;        // 0x0
        public System.Int32 capacity;        // 0x0

        // Methods
        private System.Int32 get_Length() { }
        private System.Int32 get_Capacity() { }
        private System.Void set_Capacity(System.Int32 value) { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private T& ElementAt(System.Int32 index) { }
        private System.Void .ctor(System.Int32 initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options) { }
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* Create(System.Int32 initialCapacity, U& allocator, Unity.Collections.NativeArrayOptions options) { }
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* Create(System.Int32 initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options) { }
        private System.Void Destroy(Unity.Collections.LowLevel.Unsafe.UnsafeList<T>* listData) { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps) { }
        private Unity.Jobs.JobHandle CrossFrameDispose(Unity.Jobs.JobHandle inputDeps, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority) { }
        private System.Void Clear() { }
        private System.Void Resize(System.Int32 length, Unity.Collections.NativeArrayOptions options) { }
        private System.Void Realloc(U& allocator, System.Int32 newCapacity) { }
        private System.Void SetCapacity(U& allocator, System.Int32 capacity) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Void AddNoResize(T value) { }
        private System.Void Add(T& value) { }
        private System.Void AddRange(System.Void* ptr, System.Int32 count) { }
        private System.Void RemoveAtSwapBack(System.Int32 index) { }
        private System.Void RemoveRangeSwapBack(System.Int32 index, System.Int32 count) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveRange(System.Int32 index, System.Int32 count) { }
        private Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<T> AsParallelReader() { }
        private Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<T> AsParallelWriter() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

    }

    // TypeToken: 0x20000A0
    public class UnsafeListTDebugView`1
    {
    }

    // TypeToken: 0x20000A1
    public struct UnsafeParallelHashMapData
    {
        // Fields
        private System.Byte* values;        // 0x10
        private System.Byte* keys;        // 0x18
        private System.Byte* next;        // 0x20
        private System.Byte* buckets;        // 0x28
        private System.Int32 keyCapacity;        // 0x30
        private System.Int32 bucketCapacityMask;        // 0x34
        private System.Int32 allocatedIndexLength;        // 0x38
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData.<firstFreeTLS>e__FixedBuffer firstFreeTLS;        // 0x50
        private static System.Int32 IntsPerCacheLine;        // 0x0

        // Methods
        private System.Int32 GetBucketSize(System.Int32 capacity) { }
        private System.Int32 GrowCapacity(System.Int32 capacity) { }
        private System.Void AllocateHashMap(System.Int32 length, System.Int32 bucketLength, Unity.Collections.AllocatorManager.AllocatorHandle label, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*& outBuf) { }
        private System.Void ReallocateHashMap(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, System.Int32 newCapacity, System.Int32 newBucketCapacity, Unity.Collections.AllocatorManager.AllocatorHandle label) { }
        private System.Void DeallocateHashMap(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Int32 CalculateDataSize(System.Int32 length, System.Int32 bucketLength, System.Int32& keyOffset, System.Int32& nextOffset, System.Int32& bucketOffset) { }
        private System.Boolean IsEmpty(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data) { }
        private System.Int32 GetCount(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data) { }
        private System.Boolean MoveNext(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, System.Int32& bucketIndex, System.Int32& nextIndex, System.Int32& index) { }
        private System.Void GetKeyArray(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.NativeArray<TKey> result) { }
        private System.Void GetValueArray(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.NativeArray<TValue> result) { }

    }

    // TypeToken: 0x20000A3
    public struct UnsafeParallelHashMapDataDispose
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;        // 0x10
        private Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;        // 0x18

        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000A4
    public struct UnsafeParallelHashMapDataDisposeJob, IJob
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataDispose Data;        // 0x10

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000A5
    public struct UnsafeParallelHashMapBase`2
    {
        // Methods
        private System.Void Clear(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data) { }
        private System.Int32 AllocEntry(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, System.Int32 threadIndex) { }
        private System.Void FreeEntry(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, System.Int32 idx, System.Int32 threadIndex) { }
        private System.Boolean TryAddAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue item, System.Int32 threadIndex) { }
        private System.Void AddAtomicMulti(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue item, System.Int32 threadIndex) { }
        private System.Boolean TryAdd(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue item, System.Boolean isMultiHashMap, Unity.Collections.AllocatorManager.AllocatorHandle allocation) { }
        private System.Int32 Remove(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, System.Boolean isMultiHashMap) { }
        private System.Void Remove(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it) { }
        private System.Boolean TryGetFirstValueAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it) { }
        private System.Boolean TryGetNextValueAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it) { }
        private System.Boolean SetValue(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it, TValue& item) { }

    }

    // TypeToken: 0x20000A6
    public struct KeyValue`2
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;        // 0x0
        private System.Int32 m_Index;        // 0x0
        private System.Int32 m_Next;        // 0x0

        // Methods
        private TKey get_Key() { }
        private TValue& get_Value() { }

    }

    // TypeToken: 0x20000A7
    public struct UnsafeParallelHashMapDataEnumerator
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;        // 0x10
        private System.Int32 m_Index;        // 0x18
        private System.Int32 m_BucketIndex;        // 0x1C
        private System.Int32 m_NextIndex;        // 0x20

        // Methods
        private System.Void .ctor(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue> GetCurrent() { }
        private TKey GetCurrentKey() { }

    }

    // TypeToken: 0x20000A8
    public struct UnsafeParallelHashMap`2, INativeDisposable, IDisposable, IEnumerable`1, IEnumerable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;        // 0x0
        private Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 Count() { }
        private System.Int32 get_Capacity() { }
        private System.Void set_Capacity(System.Int32 value) { }
        private System.Void Clear() { }
        private System.Boolean TryAdd(TKey key, TValue item) { }
        private System.Boolean Remove(TKey key) { }
        private System.Boolean TryGetValue(TKey key, TValue& item) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Void set_Item(TKey key, TValue value) { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<TKey,TValue> AsParallelWriter() { }
        private System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x20000AA
    public struct UnsafeParallelHashMapDisposeJob, IJob
    {
        // Fields
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* Data;        // 0x10
        public Unity.Collections.AllocatorManager.AllocatorHandle Allocator;        // 0x18

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x20000AB
    public class UnsafeParallelHashMapDebuggerTypeProxy`2
    {
    }

    // TypeToken: 0x20000AC
    public struct UnsafeParallelHashSet`1, INativeDisposable, IDisposable, IEnumerable`1, IEnumerable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<T,System.Boolean> m_Data;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Void Dispose() { }
        private System.Void Clear() { }
        private System.Boolean Add(T item) { }
        private System.Boolean Remove(T item) { }
        private System.Boolean Contains(T item) { }
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSet.Enumerator<T> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x20000AE
    public class UnsafeHashSetDebuggerTypeProxy`1
    {
    }

    // TypeToken: 0x20000AF
    public class HashSetExtensions
    {
        // Methods
        private System.Void UnionWith(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSet<T> other) { }

    }

    // TypeToken: 0x20000B0
    public struct UnsafeParallelMultiHashMap`2, INativeDisposable, IDisposable, IEnumerable`1, IEnumerable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;        // 0x0
        private Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 Count() { }
        private System.Int32 get_Capacity() { }
        private System.Void Clear() { }
        private System.Void Add(TKey key, TValue item) { }
        private System.Int32 Remove(TKey key) { }
        private System.Void Remove(Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it) { }
        private System.Boolean TryGetFirstValue(TKey key, TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it) { }
        private System.Boolean TryGetNextValue(TValue& item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey>& it) { }
        private System.Boolean SetValue(TValue item, Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it) { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator) { }
        private System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x20000B2
    public class UnsafeParallelMultiHashMapDebuggerTypeProxy`2
    {
    }

    // TypeToken: 0x20000B3
    public struct UnsafeStreamBlock
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* Next;        // 0x10
        private Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock.<Data>e__FixedBuffer Data;        // 0x18

    }

    // TypeToken: 0x20000B5
    public struct UnsafeStreamRange
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* Block;        // 0x10
        private System.Int32 OffsetInFirstBlock;        // 0x18
        private System.Int32 ElementCount;        // 0x1C
        private System.Int32 LastOffset;        // 0x20
        private System.Int32 NumberOfBlocks;        // 0x24

    }

    // TypeToken: 0x20000B6
    public struct UnsafeStreamBlockData
    {
        // Fields
        private Unity.Collections.AllocatorManager.AllocatorHandle Allocator;        // 0x10
        private Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock** Blocks;        // 0x18
        private System.Int32 BlockCount;        // 0x20
        private Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* Free;        // 0x28
        private Unity.Collections.LowLevel.Unsafe.UnsafeStreamRange* Ranges;        // 0x30
        private System.Int32 RangeCount;        // 0x38

    }

    // TypeToken: 0x20000B7
    public struct UnsafeStream, INativeDisposable, IDisposable
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlockData* m_Block;        // 0x10
        private Unity.Collections.AllocatorManager.AllocatorHandle m_Allocator;        // 0x18

        // Methods
        private System.Void AllocateForEach(System.Int32 forEachCount) { }
        private System.Void Deallocate() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000BB
    public class UnsafeUtilityExtensions
    {
        // Methods
        private System.Void* AddressOf(T& value) { }
        private T& AsRef(T& value) { }
        private System.IntPtr Malloc(System.Int64 size, System.Int32 alignment, Unity.Collections.Allocator allocator) { }

    }

}

namespace Unity.Collections.NotBurstCompatible
{

    // TypeToken: 0x2000097
    public class Extensions
    {
        // Methods
        private T[] ToArrayNBC(Unity.Collections.NativeList<T> list) { }

    }

}

namespace Unity.Jobs
{

    // TypeToken: 0x2000004
    public class EarlyInitHelpers
    {
        // Methods
        private System.Void JobReflectionDataCreationFailed(System.Exception ex, System.Type jobType) { }

    }

    // TypeToken: 0x2000005
    public interface IJobBurstSchedulable
    {
        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000006
    public class IJobBurstSchedulableExtensions
    {
    }

    // TypeToken: 0x2000009
    public interface IJobParallelForBatch
    {
        // Methods
        private System.Void Execute(System.Int32 startIndex, System.Int32 count) { }

    }

    // TypeToken: 0x200000A
    public class IJobParallelForBatchExtensions
    {
        // Methods
        private System.Void EarlyJobInit() { }
        private Unity.Jobs.JobHandle ScheduleBatch(T jobData, System.Int32 arrayLength, System.Int32 minIndicesPerJobCount, Unity.Jobs.JobHandle dependsOn) { }

    }

    // TypeToken: 0x200000D
    public interface IJobParallelForBurstSchedulable
    {
        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200000E
    public class IJobParallelForExtensionsBurstSchedulable
    {
    }

    // TypeToken: 0x2000011
    public interface IJobParallelForDefer
    {
        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000012
    public class IJobParallelForDeferExtensions
    {
        // Methods
        private System.Void EarlyJobInit() { }
        private Unity.Jobs.JobHandle Schedule(T jobData, Unity.Collections.NativeList<U> list, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle Schedule(T jobData, System.Int32* forEachCount, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ScheduleByRef(T& jobData, System.Int32* forEachCount, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ScheduleInternal(T& jobData, System.Int32 innerloopBatchCount, System.Void* forEachListPtr, System.Void* atomicSafetyHandlePtr, Unity.Jobs.JobHandle dependsOn) { }

    }

    // TypeToken: 0x2000015
    public interface IJobParallelForFilter
    {
        // Methods
        private System.Boolean Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000016
    public class JobParallelIndexListExtensions
    {
    }

    // TypeToken: 0x200001A
    public class DOTSCompilerGeneratedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

