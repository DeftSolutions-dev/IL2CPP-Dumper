// ========================================================
// Dumped by @desirepro
// Assembly: ManifestDataBinary.dll
// Classes:  12
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: RefEnumerator`1
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  private   readonly System.Byte*                    m_address  // 0x0
  private   readonly System.Byte*                    m_slotAddress  // 0x0
  private           System.Int32                    m_currentIndex  // 0x0
  private           System.Int32                    m_slotIndex  // 0x0
  private   readonly System.Int32                    m_capacity  // 0x0
METHODS:
  System.Int32 get_slotIndex()
  System.Void .ctor(Beyond.ManifestBinary.RefMultiHashTable<K,V> table)
  System.Boolean MoveNext()
  System.IntPtr get_ptrCurrent()
  T* get_current()
  T get_GetCurrent()
END_CLASS

CLASS: Beyond.ManifestBinary.RefHashSlot
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    offset  // 0x10
  public            System.Int32                    bucketsSize  // 0x14
METHODS:
  System.Int32 GetSize()
END_CLASS

CLASS: Beyond.ManifestBinary.IRefComparer`1
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Int64 GetHashCode(T obj)
END_CLASS

CLASS: Beyond.ManifestBinary.RefMultiHashTable`2
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    capacity  // 0x0
  private           System.Byte*                    m_head  // 0x0
  private           System.Byte*                    m_slotAddress  // 0x0
  public            Beyond.ManifestBinary.IRefComparer<K>m_iComparer  // 0x0
METHODS:
  Beyond.ManifestBinary.RefHashSlot[] get_slots()
  System.Void .ctor(Beyond.ManifestBinary.IRefComparer<K> iComparer)
  System.Void Init(System.Byte* data)
  System.Void Init(System.IntPtr data)
  System.Boolean ContainsKey(K key)
  System.Boolean ContainsKey(System.Int64 hash)
  Beyond.ManifestBinary.RefHashSlot* GetHashSlots(K key, System.Int64& hash)
  Beyond.ManifestBinary.RefHashSlot* GetHashSlots(System.Int64 hash)
  System.Boolean TryGetValue(K key, V*& item, System.Int32 valueKeyOffset)
  System.Boolean TryGetValue(K key, V& item, System.Int32 valueKeyOffset)
  System.Boolean TryGetValue(K key, System.Collections.Generic.List<V>& array)
  Beyond.ManifestBinary.RefMultiHashTable.RefEnumerator<K,V,V> GetEnumerator()
END_CLASS

CLASS: Beyond.ManifestBinary.IRefStructInterface
TYPE:  interface
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Void Init(System.Byte* data)
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Int32 __Gen_Wrap_0()
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x200000A
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x200000B
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
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-ManifestBinary-RefHashSlot-GetSize0  // 0x0
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

