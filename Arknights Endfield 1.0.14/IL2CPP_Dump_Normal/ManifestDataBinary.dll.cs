// ========================================================
// Dumped by @desirepro
// Assembly: ManifestDataBinary.dll
// Classes:  12
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000007
    public struct RefEnumerator`1
    {
        // Fields
        private readonly System.Byte* m_address;        // 0x0
        private readonly System.Byte* m_slotAddress;        // 0x0
        private System.Int32 m_currentIndex;        // 0x0
        private System.Int32 m_slotIndex;        // 0x0
        private readonly System.Int32 m_capacity;        // 0x0

        // Methods
        private System.Int32 get_slotIndex() { }
        private System.Void .ctor(Beyond.ManifestBinary.RefMultiHashTable<K,V> table) { }
        private System.Boolean MoveNext() { }
        private System.IntPtr get_ptrCurrent() { }
        private T* get_current() { }
        private T get_GetCurrent() { }

    }

namespace Beyond.ManifestBinary
{

    // TypeToken: 0x2000004
    public struct RefHashSlot
    {
        // Fields
        public System.Int32 offset;        // 0x10
        public System.Int32 bucketsSize;        // 0x14

        // Methods
        private System.Int32 GetSize() { }

    }

    // TypeToken: 0x2000005
    public interface IRefComparer`1
    {
        // Methods
        private System.Int64 GetHashCode(T obj) { }

    }

    // TypeToken: 0x2000006
    public struct RefMultiHashTable`2, IRefStructInterface
    {
        // Fields
        public System.Int32 capacity;        // 0x0
        private System.Byte* m_head;        // 0x0
        private System.Byte* m_slotAddress;        // 0x0
        public Beyond.ManifestBinary.IRefComparer<K> m_iComparer;        // 0x0

        // Methods
        private Beyond.ManifestBinary.RefHashSlot[] get_slots() { }
        private System.Void .ctor(Beyond.ManifestBinary.IRefComparer<K> iComparer) { }
        private System.Void Init(System.Byte* data) { }
        private System.Void Init(System.IntPtr data) { }
        private System.Boolean ContainsKey(K key) { }
        private System.Boolean ContainsKey(System.Int64 hash) { }
        private Beyond.ManifestBinary.RefHashSlot* GetHashSlots(K key, System.Int64& hash) { }
        private Beyond.ManifestBinary.RefHashSlot* GetHashSlots(System.Int64 hash) { }
        private System.Boolean TryGetValue(K key, V*& item, System.Int32 valueKeyOffset) { }
        private System.Boolean TryGetValue(K key, V& item, System.Int32 valueKeyOffset) { }
        private System.Boolean TryGetValue(K key, System.Collections.Generic.List<V>& array) { }
        private Beyond.ManifestBinary.RefMultiHashTable.RefEnumerator<K,V,V> GetEnumerator() { }

    }

    // TypeToken: 0x2000008
    public interface IRefStructInterface
    {
        // Methods
        private System.Void Init(System.Byte* data) { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000009
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Int32 __Gen_Wrap_0() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x200000B
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

    // TypeToken: 0x200000C
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-ManifestBinary-RefHashSlot-GetSize0;        // 0x0

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

