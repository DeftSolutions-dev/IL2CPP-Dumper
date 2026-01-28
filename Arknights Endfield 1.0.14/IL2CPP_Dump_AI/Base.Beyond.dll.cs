// ========================================================
// Dumped by @desirepro
// Assembly: Base.Beyond.dll
// Classes:  20
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: $BurstDirectCallInitializer
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: Beyond.CollectionUtils
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.Void AddRange(System.Collections.Generic.HashSet<T> hashSet, System.Collections.Generic.IEnumerable<T> range)
  System.Collections.Generic.HashSet<T> DeepClone(System.Collections.Generic.HashSet<T> hashSet)
END_CLASS

CLASS: Beyond.DebugAssert
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Void IsTrue(System.Boolean condition)
  System.Void IsTrue(System.Boolean condition, System.String message)
  System.Void IsFalse(System.Boolean condition)
  System.Void IsFalse(System.Boolean condition, System.String message)
  System.Void IsNotNull(T value)
  System.Void IsNull(T value)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.EnumUtils
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Int32>_enumCountCache  // 0x0
METHODS:
  System.Int32 GetEnumCount()
  TEnum FromIntNoGC(System.Int32 value)
  TEnum IntToEnumNoGC(System.Int32 value)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.StaticFastLookupCollection`2
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<TKey,TValue>m_dict  // 0x0
  private   readonly System.Collections.Generic.List<TValue>m_list  // 0x0
METHODS:
  System.Boolean TryAdd(TKey key, TValue value)
  System.Boolean TryGetValue(TKey key, TValue& value)
  System.Boolean ContainsKey(TKey key)
  System.Void Clear()
  System.Collections.Generic.IReadOnlyList<TValue> get_items()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.DynamicFastLookupCollection`2
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private           System.Collections.Generic.Dictionary<TKey,TValue>m_dict  // 0x0
  private           System.Collections.Generic.List<System.ValueTuple<TKey,TValue>>m_list  // 0x0
  private   readonly System.Collections.Generic.IEqualityComparer<TKey>m_keyComparer  // 0x0
METHODS:
  System.Boolean TryAdd(TKey key, TValue value)
  System.Void Add(TKey key, TValue value)
  System.Int32 Count()
  System.Boolean TryGetValue(TKey key, TValue& value)
  System.Boolean ContainsKey(TKey key)
  System.Boolean Remove(TKey key, TValue& value)
  System.Boolean Remove(TKey key)
  System.Void Clear()
  System.Collections.Generic.IReadOnlyList<System.ValueTuple<TKey,TValue>> get_items()
  System.Void .ctor()
END_CLASS

CLASS: Beyond._EqualsIgnoreCase_0000002C$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Boolean Invoke(System.Int16* str1, System.Int16* str2, System.Int32 len)
  System.IAsyncResult BeginInvoke(System.Int16* str1, System.Int16* str2, System.Int32 len, System.AsyncCallback , System.Object )
  System.Boolean EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond._EqualsIgnoreCase_0000002C$BurstDirectCall
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Boolean Invoke(System.Int16* str1, System.Int16* str2, System.Int32 len)
END_CLASS

CLASS: Beyond.StringUtils
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  System.String LowerFirst(System.String str, System.Boolean includeAllStartUppers)
  System.String TrimStartLength(System.String str, System.String lengthString)
  System.String TrimStartLength(System.String str, System.Int32 length)
  System.String TrimEndLength(System.String str, System.String lengthString)
  System.String TrimEndLength(System.String str, System.Int32 length)
  System.String Trim(System.String str, System.String startLengthString, System.String endLengthString)
  System.Boolean EqualsIgnoreCase(System.String strA, System.String strB)
  System.Boolean _EqualsIgnoreCase(System.Int16* str1, System.Int16* str2, System.Int32 len)
  System.String SafeValue(System.String str)
  Cysharp.Text.Utf16ValueStringBuilder CreateZStringBuilder()
  System.String ZConcat(T1 arg1, T2 arg2)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
  System.String ZConcat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
  System.String ZFormat(System.String format, T1 arg1)
  System.String ZFormat(System.String format, T1 arg1, T2 arg2)
  System.String ZFormat(System.String format, T1 arg1, T2 arg2, T3 arg3)
  System.String ZFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.String ZFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.String ZFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.String ZJoin(System.Char separator, T[] values)
  System.String ZJoin(System.Char separator, System.Collections.Generic.List<T> values)
  System.String ZJoin(System.Char separator, System.Collections.Generic.IEnumerable<T> values)
  System.String ZJoin(System.Char separator, System.Collections.Generic.ICollection<T> values)
  System.String ZJoin(System.Char separator, System.Collections.Generic.IList<T> values)
  System.String ZJoin(System.Char separator, System.Collections.Generic.IReadOnlyList<T> values)
  System.String ZJoin(System.Char separator, System.Collections.Generic.IReadOnlyCollection<T> values)
  System.String ZJoin(System.String separator, System.Collections.Generic.List<T> values)
  System.String ZJoin(System.String separator, System.Collections.Generic.IEnumerable<T> values)
  System.String ZJoin(System.String separator, System.Collections.Generic.ICollection<T> values)
  System.String ZJoin(System.String separator, System.Collections.Generic.IList<T> values)
  System.String ZJoin(System.String separator, System.Collections.Generic.IReadOnlyList<T> values)
  System.String ZJoin(System.String separator, System.Collections.Generic.IReadOnlyCollection<T> values)
  System.Boolean _EqualsIgnoreCase$BurstManaged(System.Int16* str1, System.Int16* str2, System.Int32 len)
END_CLASS

CLASS: Beyond.Base.IDisposeEnumerator
TYPE:  interface
TOKEN: 0x200000F
FIELDS:
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: Beyond.Security.IOOO000iiI
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  public    static  System.String                   FONT_PATH  // 0x0
METHODS:
  System.String Encrypt(System.String text, System.String key)
  System.String IOoOIiII(System.String encryptText, System.String key)
  System.String EncryptBytes(System.Byte[] bytes, System.String key)
  System.Byte[] _IooiIIO(System.String encryptText, System.String key)
  System.Int32 IooiIIO(System.String encryptText, System.Span<System.Byte> result, System.String key)
  System.Byte[] _Encrypt(System.Byte[] data, System.String key)
  System.Void _IIiiIIIoO(System.ReadOnlySpan<System.Byte> data, System.String key, System.Span<System.Byte> result)
  System.Byte[] _IIiiIIIoO(System.Byte[] data, System.String key)
  System.Void FromBase64String(System.String text, System.Span<System.Byte> buffer, System.Int32& count)
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.String __Gen_Wrap_0(System.Object P0, System.Boolean P1)
  System.String __Gen_Wrap_1(System.Object P0, System.Object P1)
  System.String __Gen_Wrap_2(System.Object P0, System.Int32 P1)
  System.String __Gen_Wrap_3(System.Object P0, System.Object P1, System.Object P2)
  System.Boolean __Gen_Wrap_4(System.Object P0, System.Object P1)
  System.String __Gen_Wrap_5(System.Object P0)
  Cysharp.Text.Utf16ValueStringBuilder __Gen_Wrap_6()
  System.Byte[] __Gen_Wrap_7(System.Object P0, System.Object P1)
  System.Int32 __Gen_Wrap_8(System.Object P0, System.Span<System.Byte> P1, System.Object P2)
  System.Void __Gen_Wrap_9(System.ReadOnlySpan<System.Byte> P0, System.Object P1, System.Span<System.Byte> P2)
  System.Void __Gen_Wrap_10(System.Object P0, System.Span<System.Byte> P1, System.Int32& P2)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000012
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000013
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
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-StringUtils-LowerFirst0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-StringUtils-TrimStartLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-StringUtils-TrimStartLength1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-StringUtils-TrimEndLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-StringUtils-TrimEndLength1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-StringUtils-Trim0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-StringUtils-EqualsIgnoreCase0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-StringUtils-SafeValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-StringUtils-CreateZStringBuilder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Security-IOOO000iiI-_Encrypt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Security-IOOO000iiI-EncryptBytes0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Security-IOOO000iiI-Encrypt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Security-IOOO000iiI-_IIiiIIIoO0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Security-IOOO000iiI-_IooiIIO0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Security-IOOO000iiI-IOoOIiII0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Security-IOOO000iiI-IooiIIO0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Security-IOOO000iiI-_IIiiIIIoO1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Security-IOOO000iiI-FromBase64String0  // 0x0
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

CLASS: Unity.IL2CPP.CompilerServices.Option
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.IL2CPP.CompilerServices.OptionNullChecks  // 0x0
  public    static  Unity.IL2CPP.CompilerServices.OptionArrayBoundsChecks  // 0x0
  public    static  Unity.IL2CPP.CompilerServices.OptionDivideByZeroChecks  // 0x0
METHODS:
END_CLASS

CLASS: Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  private           Unity.IL2CPP.CompilerServices.Option<Option>k__BackingField  // 0x10
  private           System.Object                   <Value>k__BackingField  // 0x18
METHODS:
  Unity.IL2CPP.CompilerServices.Option get_Option()
  System.Void set_Option(Unity.IL2CPP.CompilerServices.Option value)
  System.Object get_Value()
  System.Void set_Value(System.Object value)
  System.Void .ctor(Unity.IL2CPP.CompilerServices.Option option, System.Object value)
END_CLASS

