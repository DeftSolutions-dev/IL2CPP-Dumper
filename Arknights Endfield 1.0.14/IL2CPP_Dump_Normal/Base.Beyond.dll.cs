// ========================================================
// Dumped by @desirepro
// Assembly: Base.Beyond.dll
// Classes:  20
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000010
    public class $BurstDirectCallInitializer
    {
        // Methods
        private System.Void Initialize() { }

    }

namespace Beyond
{

    // TypeToken: 0x2000006
    public class CollectionUtils
    {
        // Methods
        private System.Void AddRange(System.Collections.Generic.HashSet<T> hashSet, System.Collections.Generic.IEnumerable<T> range) { }
        private System.Collections.Generic.HashSet<T> DeepClone(System.Collections.Generic.HashSet<T> hashSet) { }

    }

    // TypeToken: 0x2000007
    public class DebugAssert
    {
        // Methods
        private System.Void IsTrue(System.Boolean condition) { }
        private System.Void IsTrue(System.Boolean condition, System.String message) { }
        private System.Void IsFalse(System.Boolean condition) { }
        private System.Void IsFalse(System.Boolean condition, System.String message) { }
        private System.Void IsNotNull(T value) { }
        private System.Void IsNull(T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class EnumUtils
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Int32> _enumCountCache;        // 0x0

        // Methods
        private System.Int32 GetEnumCount() { }
        private TEnum FromIntNoGC(System.Int32 value) { }
        private TEnum IntToEnumNoGC(System.Int32 value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000009
    public class StaticFastLookupCollection`2
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<TKey,TValue> m_dict;        // 0x0
        private readonly System.Collections.Generic.List<TValue> m_list;        // 0x0

        // Methods
        private System.Boolean TryAdd(TKey key, TValue value) { }
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Void Clear() { }
        private System.Collections.Generic.IReadOnlyList<TValue> get_items() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class DynamicFastLookupCollection`2
    {
        // Fields
        private System.Collections.Generic.Dictionary<TKey,TValue> m_dict;        // 0x0
        private System.Collections.Generic.List<System.ValueTuple<TKey,TValue>> m_list;        // 0x0
        private readonly System.Collections.Generic.IEqualityComparer<TKey> m_keyComparer;        // 0x0

        // Methods
        private System.Boolean TryAdd(TKey key, TValue value) { }
        private System.Void Add(TKey key, TValue value) { }
        private System.Int32 Count() { }
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Boolean Remove(TKey key, TValue& value) { }
        private System.Boolean Remove(TKey key) { }
        private System.Void Clear() { }
        private System.Collections.Generic.IReadOnlyList<System.ValueTuple<TKey,TValue>> get_items() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class _EqualsIgnoreCase_0000002C$PostfixBurstDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object , System.IntPtr ) { }
        private System.Boolean Invoke(System.Int16* str1, System.Int16* str2, System.Int32 len) { }
        private System.IAsyncResult BeginInvoke(System.Int16* str1, System.Int16* str2, System.Int32 len, System.AsyncCallback , System.Object ) { }
        private System.Boolean EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200000D
    public class _EqualsIgnoreCase_0000002C$BurstDirectCall
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
        private System.Boolean Invoke(System.Int16* str1, System.Int16* str2, System.Int32 len) { }

    }

    // TypeToken: 0x200000B
    public class StringUtils
    {
        // Methods
        private System.String LowerFirst(System.String str, System.Boolean includeAllStartUppers) { }
        private System.String TrimStartLength(System.String str, System.String lengthString) { }
        private System.String TrimStartLength(System.String str, System.Int32 length) { }
        private System.String TrimEndLength(System.String str, System.String lengthString) { }
        private System.String TrimEndLength(System.String str, System.Int32 length) { }
        private System.String Trim(System.String str, System.String startLengthString, System.String endLengthString) { }
        private System.Boolean EqualsIgnoreCase(System.String strA, System.String strB) { }
        private System.Boolean _EqualsIgnoreCase(System.Int16* str1, System.Int16* str2, System.Int32 len) { }
        private System.String SafeValue(System.String str) { }
        private Cysharp.Text.Utf16ValueStringBuilder CreateZStringBuilder() { }
        private System.String ZConcat(T1 arg1, T2 arg2) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
        private System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
        private System.String ZFormat(System.String format, T1 arg1) { }
        private System.String ZFormat(System.String format, T1 arg1, T2 arg2) { }
        private System.String ZFormat(System.String format, T1 arg1, T2 arg2, T3 arg3) { }
        private System.String ZFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.String ZFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.String ZFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.String ZJoin(System.Char separator, T[] values) { }
        private System.String ZJoin(System.Char separator, System.Collections.Generic.List<T> values) { }
        private System.String ZJoin(System.Char separator, System.Collections.Generic.IEnumerable<T> values) { }
        private System.String ZJoin(System.Char separator, System.Collections.Generic.ICollection<T> values) { }
        private System.String ZJoin(System.Char separator, System.Collections.Generic.IList<T> values) { }
        private System.String ZJoin(System.Char separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        private System.String ZJoin(System.Char separator, System.Collections.Generic.IReadOnlyCollection<T> values) { }
        private System.String ZJoin(System.String separator, System.Collections.Generic.List<T> values) { }
        private System.String ZJoin(System.String separator, System.Collections.Generic.IEnumerable<T> values) { }
        private System.String ZJoin(System.String separator, System.Collections.Generic.ICollection<T> values) { }
        private System.String ZJoin(System.String separator, System.Collections.Generic.IList<T> values) { }
        private System.String ZJoin(System.String separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        private System.String ZJoin(System.String separator, System.Collections.Generic.IReadOnlyCollection<T> values) { }
        private System.Boolean _EqualsIgnoreCase$BurstManaged(System.Int16* str1, System.Int16* str2, System.Int32 len) { }

    }

}

namespace Beyond.Base
{

    // TypeToken: 0x200000F
    public interface IDisposeEnumerator
    {
        // Methods
        private System.Void Dispose() { }

    }

}

namespace Beyond.Security
{

    // TypeToken: 0x200000E
    public class IOOO000iiI
    {
        // Fields
        public static System.String FONT_PATH;        // 0x0

        // Methods
        private System.String Encrypt(System.String text, System.String key) { }
        private System.String IOoOIiII(System.String encryptText, System.String key) { }
        private System.String EncryptBytes(System.Byte[] bytes, System.String key) { }
        private System.Byte[] _IooiIIO(System.String encryptText, System.String key) { }
        private System.Int32 IooiIIO(System.String encryptText, System.Span<System.Byte> result, System.String key) { }
        private System.Byte[] _Encrypt(System.Byte[] data, System.String key) { }
        private System.Void _IIiiIIIoO(System.ReadOnlySpan<System.Byte> data, System.String key, System.Span<System.Byte> result) { }
        private System.Byte[] _IIiiIIIoO(System.Byte[] data, System.String key) { }
        private System.Void FromBase64String(System.String text, System.Span<System.Byte> buffer, System.Int32& count) { }
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000011
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.String __Gen_Wrap_0(System.Object P0, System.Boolean P1) { }
        private System.String __Gen_Wrap_1(System.Object P0, System.Object P1) { }
        private System.String __Gen_Wrap_2(System.Object P0, System.Int32 P1) { }
        private System.String __Gen_Wrap_3(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Boolean __Gen_Wrap_4(System.Object P0, System.Object P1) { }
        private System.String __Gen_Wrap_5(System.Object P0) { }
        private Cysharp.Text.Utf16ValueStringBuilder __Gen_Wrap_6() { }
        private System.Byte[] __Gen_Wrap_7(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_8(System.Object P0, System.Span<System.Byte> P1, System.Object P2) { }
        private System.Void __Gen_Wrap_9(System.ReadOnlySpan<System.Byte> P0, System.Object P1, System.Span<System.Byte> P2) { }
        private System.Void __Gen_Wrap_10(System.Object P0, System.Span<System.Byte> P1, System.Int32& P2) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000012
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000013
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

    // TypeToken: 0x2000014
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-StringUtils-LowerFirst0;        // 0x0
        public static IFix.IDMAP0 Beyond-StringUtils-TrimStartLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-StringUtils-TrimStartLength1;        // 0x0
        public static IFix.IDMAP0 Beyond-StringUtils-TrimEndLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-StringUtils-TrimEndLength1;        // 0x0
        public static IFix.IDMAP0 Beyond-StringUtils-Trim0;        // 0x0
        public static IFix.IDMAP0 Beyond-StringUtils-EqualsIgnoreCase0;        // 0x0
        public static IFix.IDMAP0 Beyond-StringUtils-SafeValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-StringUtils-CreateZStringBuilder0;        // 0x0
        public static IFix.IDMAP0 Beyond-Security-IOOO000iiI-_Encrypt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Security-IOOO000iiI-EncryptBytes0;        // 0x0
        public static IFix.IDMAP0 Beyond-Security-IOOO000iiI-Encrypt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Security-IOOO000iiI-_IIiiIIIoO0;        // 0x0
        public static IFix.IDMAP0 Beyond-Security-IOOO000iiI-_IooiIIO0;        // 0x0
        public static IFix.IDMAP0 Beyond-Security-IOOO000iiI-IOoOIiII0;        // 0x0
        public static IFix.IDMAP0 Beyond-Security-IOOO000iiI-IooiIIO0;        // 0x0
        public static IFix.IDMAP0 Beyond-Security-IOOO000iiI-_IIiiIIIoO1;        // 0x0
        public static IFix.IDMAP0 Beyond-Security-IOOO000iiI-FromBase64String0;        // 0x0

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

namespace Unity.IL2CPP.CompilerServices
{

    // TypeToken: 0x2000004
    public struct Option
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.IL2CPP.CompilerServices.Option NullChecks;        // 0x0
        public static Unity.IL2CPP.CompilerServices.Option ArrayBoundsChecks;        // 0x0
        public static Unity.IL2CPP.CompilerServices.Option DivideByZeroChecks;        // 0x0

    }

    // TypeToken: 0x2000005
    public class Il2CppSetOptionAttribute : Attribute
    {
        // Fields
        private Unity.IL2CPP.CompilerServices.Option <Option>k__BackingField;        // 0x10
        private System.Object <Value>k__BackingField;        // 0x18

        // Methods
        private Unity.IL2CPP.CompilerServices.Option get_Option() { }
        private System.Void set_Option(Unity.IL2CPP.CompilerServices.Option value) { }
        private System.Object get_Value() { }
        private System.Void set_Value(System.Object value) { }
        private System.Void .ctor(Unity.IL2CPP.CompilerServices.Option option, System.Object value) { }

    }

}

