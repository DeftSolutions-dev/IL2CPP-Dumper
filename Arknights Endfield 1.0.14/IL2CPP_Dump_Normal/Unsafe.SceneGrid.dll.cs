// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.SceneGrid.dll
// Classes:  25
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000A
    public struct FDictionaryEnumerator
    {
        // Fields
        public Beyond.Gameplay.Core.FDictionary4<Tk,Tv>* ptr;        // 0x0
        private System.Int32 m_pos;        // 0x0

        // Methods
        private System.Void .ctor(Beyond.Gameplay.Core.FDictionary4<Tk,Tv>* initPtr) { }
        private System.Boolean MoveNext() { }
        private System.ValueTuple<Tk,Tv> get_Current() { }

    }

    // TypeToken: 0x200000C
    public struct FDictionaryEnumerator
    {
        // Fields
        public Beyond.Gameplay.Core.FDictionary16<Tk,Tv>* ptr;        // 0x0
        private System.Int32 m_pos;        // 0x0

        // Methods
        private System.Void .ctor(Beyond.Gameplay.Core.FDictionary16<Tk,Tv>* initPtr) { }
        private System.Boolean MoveNext() { }
        private System.ValueTuple<Tk,Tv> get_Current() { }

    }

namespace Beyond.Gameplay.Core
{

    // TypeToken: 0x2000009
    public struct FDictionary4`2
    {
        // Fields
        public Beyond.FArray4<Tk> kArray;        // 0x0
        public Beyond.FArray4<Tv> vArray;        // 0x0
        public System.UInt32 bitArray;        // 0x0
        public static readonly System.Int32 CAPACITY;        // 0x0

        // Methods
        private Beyond.Gameplay.Core.FDictionary4.FDictionaryEnumerator<Tk,Tv> GetEnumerator() { }
        private System.Void .ctor(System.Int32 len) { }
        private System.Void SetBitEnable(System.Int32 bit) { }
        private System.Void SetBitDisable(System.Int32 bit) { }
        private System.Boolean IsBitEnable(System.Int32 bit) { }
        private System.Boolean TryGetValue(Tk k, Tv& v) { }
        private System.Boolean TryRemove(Tk k) { }
        private Tv get_Item(Tk k) { }
        private System.Void set_Item(Tk k, Tv value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000B
    public struct FDictionary16`2
    {
        // Fields
        public Beyond.FArray16<Tk> kArray;        // 0x0
        public Beyond.FArray16<Tv> vArray;        // 0x0
        public System.UInt32 bitArray;        // 0x0
        public static readonly System.Int32 CAPACITY;        // 0x0

        // Methods
        private Beyond.Gameplay.Core.FDictionary16.FDictionaryEnumerator<Tk,Tv> GetEnumerator() { }
        private System.Void .ctor(System.Int32 len) { }
        private System.Void SetBitEnable(System.Int32 bit) { }
        private System.Void SetBitDisable(System.Int32 bit) { }
        private System.Boolean IsBitEnable(System.Int32 bit) { }
        private System.Boolean TryGetValue(Tk k, Tv& v) { }
        private System.Boolean TryRemove(Tk k) { }
        private Tv get_Item(Tk k) { }
        private System.Void set_Item(Tk k, Tv value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public class MemFriendSetContextManager`1
    {
        // Fields
        private static System.Int32 ARRAY_CACHE_SIZE;        // 0x0
        private static System.Int32 SEQ_SET_MAX;        // 0x0
        private static System.Int32 INIT_SET_CAP;        // 0x0
        private static System.Int32 MAX_SET_CAP;        // 0x0
        private static System.Int32 INIT_MIN_CAP;        // 0x0
        public static System.Int32 MAX_CONTENT_SIZE;        // 0x0
        public readonly System.Int32 minCapSize;        // 0x0
        public readonly System.Int32 initContentSize;        // 0x0
        public readonly System.Int32 freeListPointerSize;        // 0x0
        private readonly Beyond.Gameplay.Core.MemFriendSetContextBase<T>[] m_setContexts;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Gameplay.Core.MemFriendSetContextBase<T>> m_setContextsMap;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private Beyond.Gameplay.Core.MemFriendSetContextBase<T> _GetContext(System.Int32 cap) { }
        private Beyond.Gameplay.Core.MemFriendSetContextBase<T> _CreateContext(System.Int32 cap) { }
        private System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private Beyond.Gameplay.Core.PureEnumerator<T> GetEnumerator(Beyond.Gameplay.Core.MemFriendHashSet& set) { }
        private System.Void AddToMonoSet(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Collections.Generic.HashSet<T> monoSet) { }
        private System.Void AddToMonoList(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Collections.Generic.List<T> monoList) { }
        private Beyond.Gameplay.Core.MemFriendHashSet AllocateSet(System.Int32 cap) { }
        private System.Void Recycle(Beyond.Gameplay.Core.MemFriendHashSet& set) { }
        private System.Int32 GetContextSize(System.Int32 cap) { }
        private System.Void OnRelease() { }

    }

    // TypeToken: 0x200000E
    public struct PureEnumerator`1
    {
        // Fields
        private System.Int32 m_index;        // 0x0
        private System.Int32 m_validCnt;        // 0x0
        private Beyond.Gameplay.Core.MemFriendHashSet m_set;        // 0x0
        private readonly Beyond.Gameplay.Core.MemFriendSetContextBase<T> m_context;        // 0x0

        // Methods
        private T get_current() { }
        private System.Void .ctor(Beyond.Gameplay.Core.MemFriendHashSet set, Beyond.Gameplay.Core.MemFriendSetContextBase<T> context) { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x200000F
    public struct MemFriendHashSet
    {
        // Fields
        public System.Int32 start;        // 0x10
        public System.Int32 cap;        // 0x14
        public System.Int32 count;        // 0x18
        public System.Int32 bitStart;        // 0x1C

        // Methods
        private System.Void CopyFrom(Beyond.Gameplay.Core.MemFriendHashSet& other) { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x2000010
    public class MemFriendSetContextBase`1, IDisposable
    {
        // Fields
        protected Unity.Collections.NativeArray<T> m_content;        // 0x0
        protected readonly System.Int32 m_singleElementSize;        // 0x0
        public static System.Int32 INVALID_CONTENT_INDEX;        // 0x0
        public readonly System.Int32 typeSize;        // 0x0
        public readonly System.Int32 stride;        // 0x0
        public readonly Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager;        // 0x0
        private System.Int32 m_freeListHead;        // 0x0
        private System.Int32 m_freeListTail;        // 0x0
        private System.Byte* m_ptr;        // 0x0
        public System.Int32 currentCount;        // 0x0

        // Methods
        private System.Int32 get_singleElementSize() { }
        private System.Void .ctor(Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager, System.Int32 initSize, System.Int32 singleElementSize) { }
        private System.Void InitArrayFreeList(System.Int32 baseIndex, System.Int32 size) { }
        private System.Void _ReplaceWithNewCap(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 newCap) { }
        private System.Void _TryShrink(Beyond.Gameplay.Core.MemFriendHashSet& set) { }
        private System.Boolean _TryEnLarge(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Void EnLarge() { }
        private Beyond.Gameplay.Core.MemFriendHashSet Allocate() { }
        private System.Void Free(Beyond.Gameplay.Core.MemFriendHashSet& set) { }
        private System.Void CopyFromAnother(Beyond.Gameplay.Core.MemFriendHashSet& desSet, Beyond.Gameplay.Core.MemFriendHashSet& srcSet) { }
        private T GetElement(System.Int32 index) { }
        private System.Boolean IsEqual(System.Int32 index, T item) { }
        private System.Int32 GetHashCodeOfElement(T item) { }
        private Beyond.Gameplay.Core.PureEnumerator<T> GetEnumerator(Beyond.Gameplay.Core.MemFriendHashSet& set) { }
        private System.Int32 GetNextValidIndex(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 index, System.Int32 validCnt) { }
        private System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Boolean ShouldEnLarge(System.Int32 count) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000011
    public class BitContext, IDisposable
    {
        // Fields
        public Unity.Collections.NativeArray<System.Byte> bits;        // 0x10
        public static System.Int32 ONE_SLOT_BIT_NUM;        // 0x0
        public static System.Int32 ONE_STATE_BIT_NUM;        // 0x0
        public static System.Int32 ONE_SLOT_ELEMENT_NUM;        // 0x0
        public static System.Byte MASK;        // 0x0
        public static System.Byte FREE;        // 0x0
        public static System.Byte OCCUPIED;        // 0x0
        public static System.Byte USED;        // 0x0
        private readonly System.Int32 m_elementBitSlot;        // 0x20
        private System.Byte* m_ptr;        // 0x28

        // Methods
        private System.Void .ctor(System.Int32 initSize, System.Int32 singleElementSize) { }
        private System.Int32 _ComputePropBitArrayLength(System.Int32 contentLength) { }
        private System.Void EnLarge(System.Int32 contentSize) { }
        private System.Void Recycle(System.Int32 bitIndex) { }
        private System.Int32 GetBitStartIndex(System.Int32 index) { }
        private System.Void _CalculateBitIndexAndMask(System.Int32 bitStateStartIndex, System.Int32 index, System.Int32& finalIndex, System.Int32& offsetInternal) { }
        private System.Byte GetState(System.Int32 bitStateStartIndex, System.Int32 index) { }
        private System.Void SetState(System.Int32 bitStateStartIndex, System.Int32 index, System.Byte state) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000012
    public class MemFriendNormalSetContext`1 : MemFriendSetContextBase`1
    {
        // Fields
        private readonly Beyond.Gameplay.Core.BitContext m_bitContext;        // 0x0

        // Methods
        private System.Void .ctor(Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager, System.Int32 initSize, System.Int32 singleElementSize) { }
        private System.Void EnLarge() { }
        private System.Void Dispose() { }
        private System.Int32 GetNextValidIndex(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 index, System.Int32 validCnt) { }
        private Beyond.Gameplay.Core.MemFriendHashSet Allocate() { }
        private System.Void Free(Beyond.Gameplay.Core.MemFriendHashSet& set) { }
        private System.Boolean ShouldEnLarge(System.Int32 count) { }
        private System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }

    }

    // TypeToken: 0x2000013
    public class MemFriendSeqSetContext`1 : MemFriendSetContextBase`1
    {
        // Methods
        private System.Void .ctor(Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager, System.Int32 initSize, System.Int32 singleElementSize) { }
        private System.Int32 GetNextValidIndex(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 index, System.Int32 validCnt) { }
        private System.Boolean ShouldEnLarge(System.Int32 count) { }
        private System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }
        private System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item) { }

    }

    // TypeToken: 0x2000014
    public class GameplayUnsafeUtil
    {
        // Methods
        private System.Byte[] NativeArrayToBytes(Unity.Collections.NativeArray<T> nativeArray) { }
        private Unity.Collections.NativeArray<System.Byte> GetNativeArrayFromStream(System.IO.Stream stream) { }

    }

    // TypeToken: 0x2000015
    public class SparseNativeArray`1
    {
        // Fields
        private Unity.Collections.NativeArray<T> m_rawArray;        // 0x0
        private System.Int32 m_currentCount;        // 0x0
        private System.Int32 m_emptyStartPos;        // 0x0
        private System.Int32 m_marker;        // 0x0
        public readonly System.Int32 typeSize;        // 0x0
        private System.Byte* m_ptr;        // 0x0
        private T* m_validPtr;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Init(System.Int32 initCap) { }
        private System.Boolean IsEmpty() { }
        private T& ElementAt(System.Int32 index) { }
        private System.Int32 InsertValue(T v) { }
        private System.Void Clear() { }
        private System.Int32 Allocate() { }
        private System.Void Remove(System.Int32 v) { }
        private T get_Item(System.Int32 i) { }
        private System.Void set_Item(System.Int32 i, T value) { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000005
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000004
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000016
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void __Gen_Wrap_0(Beyond.Gameplay.Core.MemFriendHashSet& P0, Beyond.Gameplay.Core.MemFriendHashSet& P1) { }
        private System.Void __Gen_Wrap_1(Beyond.Gameplay.Core.MemFriendHashSet& P0) { }
        private System.Int32 __Gen_Wrap_2(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_3(System.Object P0, System.Int32 P1) { }
        private System.Byte __Gen_Wrap_4(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_5(System.Object P0, System.Int32 P1, System.Int32 P2, System.Byte P3) { }
        private System.Void __Gen_Wrap_6(System.Object P0) { }
        private Unity.Collections.NativeArray<System.Byte> __Gen_Wrap_7(System.Object P0) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000017
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000018
    public class WrappersManagerImpl, WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000019
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Gameplay-Core-MemFriendHashSet-CopyFrom0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-MemFriendHashSet-Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-BitContext-_ComputePropBitArrayLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-BitContext-EnLarge0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-BitContext-Recycle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-BitContext-GetState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-BitContext-SetState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-BitContext-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-GameplayUnsafeUtil-GetNativeArrayFromStream0;        // 0x0

    }

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

