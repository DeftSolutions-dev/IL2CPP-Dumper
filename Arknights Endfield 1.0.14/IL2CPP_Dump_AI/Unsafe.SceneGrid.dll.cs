// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.SceneGrid.dll
// Classes:  25
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: FDictionaryEnumerator
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            Beyond.Gameplay.Core.FDictionary4<Tk,Tv>*ptr  // 0x0
  private           System.Int32                    m_pos  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Core.FDictionary4<Tk,Tv>* initPtr)
  System.Boolean MoveNext()
  System.ValueTuple<Tk,Tv> get_Current()
END_CLASS

CLASS: FDictionaryEnumerator
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            Beyond.Gameplay.Core.FDictionary16<Tk,Tv>*ptr  // 0x0
  private           System.Int32                    m_pos  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Core.FDictionary16<Tk,Tv>* initPtr)
  System.Boolean MoveNext()
  System.ValueTuple<Tk,Tv> get_Current()
END_CLASS

CLASS: Beyond.Gameplay.Core.FDictionary4`2
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            Beyond.FArray4<Tk>              kArray  // 0x0
  public            Beyond.FArray4<Tv>              vArray  // 0x0
  public            System.UInt32                   bitArray  // 0x0
  public    static readonly System.Int32                    CAPACITY  // 0x0
METHODS:
  Beyond.Gameplay.Core.FDictionary4.FDictionaryEnumerator<Tk,Tv> GetEnumerator()
  System.Void .ctor(System.Int32 len)
  System.Void SetBitEnable(System.Int32 bit)
  System.Void SetBitDisable(System.Int32 bit)
  System.Boolean IsBitEnable(System.Int32 bit)
  System.Boolean TryGetValue(Tk k, Tv& v)
  System.Boolean TryRemove(Tk k)
  Tv get_Item(Tk k)
  System.Void set_Item(Tk k, Tv value)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.FDictionary16`2
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            Beyond.FArray16<Tk>             kArray  // 0x0
  public            Beyond.FArray16<Tv>             vArray  // 0x0
  public            System.UInt32                   bitArray  // 0x0
  public    static readonly System.Int32                    CAPACITY  // 0x0
METHODS:
  Beyond.Gameplay.Core.FDictionary16.FDictionaryEnumerator<Tk,Tv> GetEnumerator()
  System.Void .ctor(System.Int32 len)
  System.Void SetBitEnable(System.Int32 bit)
  System.Void SetBitDisable(System.Int32 bit)
  System.Boolean IsBitEnable(System.Int32 bit)
  System.Boolean TryGetValue(Tk k, Tv& v)
  System.Boolean TryRemove(Tk k)
  Tv get_Item(Tk k)
  System.Void set_Item(Tk k, Tv value)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendSetContextManager`1
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   static  System.Int32                    ARRAY_CACHE_SIZE  // 0x0
  private   static  System.Int32                    SEQ_SET_MAX  // 0x0
  private   static  System.Int32                    INIT_SET_CAP  // 0x0
  private   static  System.Int32                    MAX_SET_CAP  // 0x0
  private   static  System.Int32                    INIT_MIN_CAP  // 0x0
  public    static  System.Int32                    MAX_CONTENT_SIZE  // 0x0
  public    readonly System.Int32                    minCapSize  // 0x0
  public    readonly System.Int32                    initContentSize  // 0x0
  public    readonly System.Int32                    freeListPointerSize  // 0x0
  private   readonly Beyond.Gameplay.Core.MemFriendSetContextBase<T>[]m_setContexts  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Gameplay.Core.MemFriendSetContextBase<T>>m_setContextsMap  // 0x0
METHODS:
  System.Void .ctor()
  Beyond.Gameplay.Core.MemFriendSetContextBase<T> _GetContext(System.Int32 cap)
  Beyond.Gameplay.Core.MemFriendSetContextBase<T> _CreateContext(System.Int32 cap)
  System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  Beyond.Gameplay.Core.PureEnumerator<T> GetEnumerator(Beyond.Gameplay.Core.MemFriendHashSet& set)
  System.Void AddToMonoSet(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Collections.Generic.HashSet<T> monoSet)
  System.Void AddToMonoList(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Collections.Generic.List<T> monoList)
  Beyond.Gameplay.Core.MemFriendHashSet AllocateSet(System.Int32 cap)
  System.Void Recycle(Beyond.Gameplay.Core.MemFriendHashSet& set)
  System.Int32 GetContextSize(System.Int32 cap)
  System.Void OnRelease()
END_CLASS

CLASS: Beyond.Gameplay.Core.PureEnumerator`1
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  private           System.Int32                    m_index  // 0x0
  private           System.Int32                    m_validCnt  // 0x0
  private           Beyond.Gameplay.Core.MemFriendHashSetm_set  // 0x0
  private   readonly Beyond.Gameplay.Core.MemFriendSetContextBase<T>m_context  // 0x0
METHODS:
  T get_current()
  System.Void .ctor(Beyond.Gameplay.Core.MemFriendHashSet set, Beyond.Gameplay.Core.MemFriendSetContextBase<T> context)
  System.Boolean MoveNext()
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendHashSet
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    start  // 0x10
  public            System.Int32                    cap  // 0x14
  public            System.Int32                    count  // 0x18
  public            System.Int32                    bitStart  // 0x1C
METHODS:
  System.Void CopyFrom(Beyond.Gameplay.Core.MemFriendHashSet& other)
  System.Void Clear()
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendSetContextBase`1
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  protected         Unity.Collections.NativeArray<T>m_content  // 0x0
  protected readonly System.Int32                    m_singleElementSize  // 0x0
  public    static  System.Int32                    INVALID_CONTENT_INDEX  // 0x0
  public    readonly System.Int32                    typeSize  // 0x0
  public    readonly System.Int32                    stride  // 0x0
  public    readonly Beyond.Gameplay.Core.MemFriendSetContextManager<T>contextManager  // 0x0
  private           System.Int32                    m_freeListHead  // 0x0
  private           System.Int32                    m_freeListTail  // 0x0
  private           System.Byte*                    m_ptr  // 0x0
  public            System.Int32                    currentCount  // 0x0
METHODS:
  System.Int32 get_singleElementSize()
  System.Void .ctor(Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager, System.Int32 initSize, System.Int32 singleElementSize)
  System.Void InitArrayFreeList(System.Int32 baseIndex, System.Int32 size)
  System.Void _ReplaceWithNewCap(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 newCap)
  System.Void _TryShrink(Beyond.Gameplay.Core.MemFriendHashSet& set)
  System.Boolean _TryEnLarge(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Void EnLarge()
  Beyond.Gameplay.Core.MemFriendHashSet Allocate()
  System.Void Free(Beyond.Gameplay.Core.MemFriendHashSet& set)
  System.Void CopyFromAnother(Beyond.Gameplay.Core.MemFriendHashSet& desSet, Beyond.Gameplay.Core.MemFriendHashSet& srcSet)
  T GetElement(System.Int32 index)
  System.Boolean IsEqual(System.Int32 index, T item)
  System.Int32 GetHashCodeOfElement(T item)
  Beyond.Gameplay.Core.PureEnumerator<T> GetEnumerator(Beyond.Gameplay.Core.MemFriendHashSet& set)
  System.Int32 GetNextValidIndex(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 index, System.Int32 validCnt)
  System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Boolean ShouldEnLarge(System.Int32 count)
  System.Void Dispose()
END_CLASS

CLASS: Beyond.Gameplay.Core.BitContext
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  public            Unity.Collections.NativeArray<System.Byte>bits  // 0x10
  public    static  System.Int32                    ONE_SLOT_BIT_NUM  // 0x0
  public    static  System.Int32                    ONE_STATE_BIT_NUM  // 0x0
  public    static  System.Int32                    ONE_SLOT_ELEMENT_NUM  // 0x0
  public    static  System.Byte                     MASK  // 0x0
  public    static  System.Byte                     FREE  // 0x0
  public    static  System.Byte                     OCCUPIED  // 0x0
  public    static  System.Byte                     USED  // 0x0
  private   readonly System.Int32                    m_elementBitSlot  // 0x20
  private           System.Byte*                    m_ptr  // 0x28
METHODS:
  System.Void .ctor(System.Int32 initSize, System.Int32 singleElementSize)
  System.Int32 _ComputePropBitArrayLength(System.Int32 contentLength)
  System.Void EnLarge(System.Int32 contentSize)
  System.Void Recycle(System.Int32 bitIndex)
  System.Int32 GetBitStartIndex(System.Int32 index)
  System.Void _CalculateBitIndexAndMask(System.Int32 bitStateStartIndex, System.Int32 index, System.Int32& finalIndex, System.Int32& offsetInternal)
  System.Byte GetState(System.Int32 bitStateStartIndex, System.Int32 index)
  System.Void SetState(System.Int32 bitStateStartIndex, System.Int32 index, System.Byte state)
  System.Void Dispose()
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendNormalSetContext`1
TYPE:  class
TOKEN: 0x2000012
EXTENDS: MemFriendSetContextBase`1
FIELDS:
  private   readonly Beyond.Gameplay.Core.BitContext m_bitContext  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager, System.Int32 initSize, System.Int32 singleElementSize)
  System.Void EnLarge()
  System.Void Dispose()
  System.Int32 GetNextValidIndex(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 index, System.Int32 validCnt)
  Beyond.Gameplay.Core.MemFriendHashSet Allocate()
  System.Void Free(Beyond.Gameplay.Core.MemFriendHashSet& set)
  System.Boolean ShouldEnLarge(System.Int32 count)
  System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendSeqSetContext`1
TYPE:  class
TOKEN: 0x2000013
EXTENDS: MemFriendSetContextBase`1
FIELDS:
METHODS:
  System.Void .ctor(Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager, System.Int32 initSize, System.Int32 singleElementSize)
  System.Int32 GetNextValidIndex(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 index, System.Int32 validCnt)
  System.Boolean ShouldEnLarge(System.Int32 count)
  System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
END_CLASS

CLASS: Beyond.Gameplay.Core.GameplayUnsafeUtil
TYPE:  class
TOKEN: 0x2000014
FIELDS:
METHODS:
  System.Byte[] NativeArrayToBytes(Unity.Collections.NativeArray<T> nativeArray)
  Unity.Collections.NativeArray<System.Byte> GetNativeArrayFromStream(System.IO.Stream stream)
END_CLASS

CLASS: Beyond.Gameplay.Core.SparseNativeArray`1
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private           Unity.Collections.NativeArray<T>m_rawArray  // 0x0
  private           System.Int32                    m_currentCount  // 0x0
  private           System.Int32                    m_emptyStartPos  // 0x0
  private           System.Int32                    m_marker  // 0x0
  public    readonly System.Int32                    typeSize  // 0x0
  private           System.Byte*                    m_ptr  // 0x0
  private           T*                              m_validPtr  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Init(System.Int32 initCap)
  System.Boolean IsEmpty()
  T& ElementAt(System.Int32 index)
  System.Int32 InsertValue(T v)
  System.Void Clear()
  System.Int32 Allocate()
  System.Void Remove(System.Int32 v)
  T get_Item(System.Int32 i)
  System.Void set_Item(System.Int32 i, T value)
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void __Gen_Wrap_0(Beyond.Gameplay.Core.MemFriendHashSet& P0, Beyond.Gameplay.Core.MemFriendHashSet& P1)
  System.Void __Gen_Wrap_1(Beyond.Gameplay.Core.MemFriendHashSet& P0)
  System.Int32 __Gen_Wrap_2(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_3(System.Object P0, System.Int32 P1)
  System.Byte __Gen_Wrap_4(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_5(System.Object P0, System.Int32 P1, System.Int32 P2, System.Byte P3)
  System.Void __Gen_Wrap_6(System.Object P0)
  Unity.Collections.NativeArray<System.Byte> __Gen_Wrap_7(System.Object P0)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000017
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  System.Object CreateWrapper(System.Int32 id)
  System.Object InitWrapperArray(System.Int32 len)
  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-MemFriendHashSet-CopyFrom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-MemFriendHashSet-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-_ComputePropBitArrayLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-EnLarge0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-Recycle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-GetState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-SetState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-GameplayUnsafeUtil-GetNativeArrayFromStream0  // 0x0
METHODS:
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

