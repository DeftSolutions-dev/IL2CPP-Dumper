// ========================================================
// Dumped by @desirepro
// Assembly: XLua.Runtime.dll
// Classes:  228
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: LuaAsset
TYPE:  class
TOKEN: 0x2000006
EXTENDS: ScriptableObject
FIELDS:
  public    static  System.String                   LuaDecodeKey  // 0x0
  public            System.Boolean                  encode  // 0x18
  public            System.Byte[]                   data  // 0x20
METHODS:
  System.Byte[] GetDecodeBytes()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: LuaGenericDelegateCall
TYPE:  class
TOKEN: 0x2000046
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr L, System.Delegate delegate, XLua.ObjectTranslator objectTranslator, System.Collections.Generic.List<System.Type> castType)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.Delegate delegate, XLua.ObjectTranslator objectTranslator, System.Collections.Generic.List<System.Type> castType, System.AsyncCallback callback, System.Object object)
  System.Int32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TryArrayGet
TYPE:  class
TOKEN: 0x2000059
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Object obj, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Object obj, System.Int32 index, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TryArraySet
TYPE:  class
TOKEN: 0x200005A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Object obj, System.Int32 array_idx, System.Int32 obj_idx)
  System.IAsyncResult BeginInvoke(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Object obj, System.Int32 array_idx, System.Int32 obj_idx, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GCAction
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            System.Int32                    Reference  // 0x10
  public            System.Boolean                  IsDelegate  // 0x14
METHODS:
END_CLASS

CLASS: CustomLoader
TYPE:  class
TOKEN: 0x2000064
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Byte[] Invoke(System.String& filepath)
  System.IAsyncResult BeginInvoke(System.String& filepath, System.AsyncCallback callback, System.Object object)
  System.Byte[] EndInvoke(System.String& filepath, System.IAsyncResult result)
END_CLASS

CLASS: Slot
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            System.Int32                    next  // 0x10
  public            System.Object                   obj  // 0x18
METHODS:
  System.Void .ctor(System.Int32 next, System.Object obj)
END_CLASS

CLASS: LOGLEVEL
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  XLua.ObjectTranslator.LOGLEVEL  NO  // 0x0
  public    static  XLua.ObjectTranslator.LOGLEVEL  INFO  // 0x0
  public    static  XLua.ObjectTranslator.LOGLEVEL  WARN  // 0x0
  public    static  XLua.ObjectTranslator.LOGLEVEL  ERROR  // 0x0
METHODS:
END_CLASS

CLASS: EnumerableWrapper
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.Int32                    Index  // 0x10
  public            System.Collections.IList        CurList  // 0x18
  public            System.Collections.IEnumerator  Enumerator  // 0x20
  public    static  System.Collections.Generic.Stack<XLua.ObjectTranslator.EnumerableWrapper>enumerableStack  // 0x0
METHODS:
  System.Int32 ListCsPairs(System.IntPtr L)
  System.Int32 DicCsPairs(System.IntPtr L)
  System.Int32 IEnumerableCsPairs(System.IntPtr L)
  System.Void .cctor()
END_CLASS

CLASS: FStructWrap`1
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            T                               value  // 0x0
METHODS:
  System.IntPtr GetPtr()
END_CLASS

CLASS: CSharpStructInLua
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    fake_id  // 0x10
  public            System.UInt32                   len  // 0x14
  public            System.IntPtr                   ptr  // 0x18
METHODS:
END_CLASS

CLASS: LuaCSFunctionPtr
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.IntPtr                   ptr  // 0x10
  public            System.Object                   target  // 0x18
METHODS:
END_CLASS

CLASS: GetDelegatePointer`1
TYPE:  class
TOKEN: 0x200008C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.ValueTuple<System.IntPtr,T1> Invoke(System.Delegate d)
  System.IAsyncResult BeginInvoke(System.Delegate d, System.AsyncCallback callback, System.Object object)
  System.ValueTuple<System.IntPtr,T1> EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: PushCSObject
TYPE:  class
TOKEN: 0x200008D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.IntPtr L, System.Object obj)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.Object obj, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetCSObject
TYPE:  class
TOKEN: 0x200008E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Object Invoke(System.IntPtr L, System.Int32 idx)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.AsyncCallback callback, System.Object object)
  System.Object EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UpdateCSObject
TYPE:  class
TOKEN: 0x200008F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.IntPtr L, System.Int32 idx, System.Object obj)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.Object obj, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CheckFunc`1
TYPE:  class
TOKEN: 0x2000090
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.IntPtr L, System.Int32 idx)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetFunc`1
TYPE:  class
TOKEN: 0x2000091
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.IntPtr L, System.Int32 idx, T& val)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, T& val, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(T& val, System.IAsyncResult result)
END_CLASS

CLASS: MethodKey
TYPE:  struct
TOKEN: 0x20000A7
FIELDS:
  public            System.String                   Name  // 0x10
  public            System.Boolean                  IsStatic  // 0x18
METHODS:
END_CLASS

CLASS: HyperLuaLogCallbackDelegate
TYPE:  class
TOKEN: 0x20000DD
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.IntPtr L, System.Int32 level, System.String text)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 level, System.String text, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: LuaUtilsLogCallbackDelegate
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Int32 level, System.String text)
  System.IAsyncResult BeginInvoke(System.Int32 level, System.String text, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: DecryptionFunc
TYPE:  class
TOKEN: 0x20000DF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.IntPtr Invoke(System.IntPtr input, System.Int32 size, System.Int32& outSize)
  System.IAsyncResult BeginInvoke(System.IntPtr input, System.Int32 size, System.Int32& outSize, System.AsyncCallback callback, System.Object object)
  System.IntPtr EndInvoke(System.Int32& outSize, System.IAsyncResult result)
END_CLASS

CLASS: Beyond.Lua.LuaCypher
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  private   static  System.String                   KEY  // 0x0
  private   static readonly System.String[]                 KEYS  // 0x0
  private   static  System.String                   INITIAL_ASSETS_ROOT_PATH  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  decryptionMaker  // 0x8
METHODS:
  System.String GetKey()
  System.Void GetKey(System.Span<System.Byte> buffer, System.Int32& len)
  System.Boolean SkipDecrypt(System.String luaString)
  System.String DecryptLuaString(System.String encryptLua)
  System.Byte[] DecryptLua(System.String encryptLua)
  System.IntPtr DecryptionFunc(System.IntPtr input, System.Int32 size, System.Int32& outSize)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Lua.LuaGenericDelegateCaller
TYPE:  class
TOKEN: 0x2000045
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall>s_callerDic  // 0x0
METHODS:
  Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall GetCaller(System.String delegateTypeName)
  System.Void AddCaller(System.String delegateTypeName, Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall caller)
  System.Int32 OverloadMethodCall(System.IntPtr L, XLua.ObjectTranslator objectTranslator, XLua.IOverloadMethodWrap[] overload)
  System.Int32 DefaultValueMethodCall(System.IntPtr L, XLua.ObjectTranslator objectTranslator, XLua.IOverloadMethodWrap[] defaultValues)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Reflection.GenericDelegateCaller
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,System.Type>s_customDelegateTypeDic  // 0x0
METHODS:
  System.Type GetCustomDelegateType(System.String delegateName)
  System.Void AddCustomDelegateType(System.String delegateName, System.Type type)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Reflection.MethodParamItem
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  public            System.Type                     type  // 0x10
  public            System.Boolean                  isRef  // 0x18
  public            System.Boolean                  isOut  // 0x19
  public            System.Object                   defaultValue  // 0x20
  public            System.Boolean                  hasDefaultValue  // 0x28
  public            System.String                   name  // 0x30
  public            System.Type                     realType  // 0x38
METHODS:
  System.Collections.Generic.List<Beyond.Reflection.MethodParamItem> GetMethodParamList(System.Reflection.MethodInfo method, System.Boolean needLua, System.Boolean needEnum)
  System.String GetMethodSignatureString(System.Reflection.MethodInfo method, System.Boolean needLua, System.Boolean keepType, System.Boolean needEnum)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize0
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize1
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Byte                     b0  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize2
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int16                    s0  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize3
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int16                    s0  // 0x10
  public            System.Byte                     b0  // 0x12
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize4
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    i0  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize5
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    i0  // 0x10
  public            System.Byte                     b0  // 0x14
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize8
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Int64                    l0  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize12
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int32                    i0  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize16
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize18
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int16                    s0  // 0x20
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize20
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int32                    i0  // 0x20
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize24
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize28
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int32                    i0  // 0x28
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize32
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize34
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int16                    s0  // 0x30
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize36
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int32                    i0  // 0x30
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize40
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize44
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int32                    i0  // 0x38
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize48
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize52
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int32                    i0  // 0x40
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize56
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize60
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int32                    i0  // 0x48
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize64
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize68
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int32                    i0  // 0x50
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize72
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize76
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int32                    i0  // 0x58
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize80
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize84
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int32                    i0  // 0x60
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize88
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize92
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int32                    i0  // 0x68
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize96
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize104
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize108
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int32                    i0  // 0x78
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize112
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize120
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize124
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int32                    i0  // 0x88
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize128
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize136
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize140
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int32                    i0  // 0x98
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize144
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize148
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int32                    i0  // 0xA0
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize152
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize160
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize168
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize176
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize180
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int32                    i0  // 0xC0
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize184
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize192
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize196
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int32                    i0  // 0xD0
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize200
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int64                    l24  // 0xD0
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize208
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int64                    l24  // 0xD0
  public            System.Int64                    l25  // 0xD8
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize216
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int64                    l24  // 0xD0
  public            System.Int64                    l25  // 0xD8
  public            System.Int64                    l26  // 0xE0
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize220
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int64                    l24  // 0xD0
  public            System.Int64                    l25  // 0xD8
  public            System.Int64                    l26  // 0xE0
  public            System.Int32                    i0  // 0xE8
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize224
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int64                    l24  // 0xD0
  public            System.Int64                    l25  // 0xD8
  public            System.Int64                    l26  // 0xE0
  public            System.Int64                    l27  // 0xE8
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize232
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int64                    l24  // 0xD0
  public            System.Int64                    l25  // 0xD8
  public            System.Int64                    l26  // 0xE0
  public            System.Int64                    l27  // 0xE8
  public            System.Int64                    l28  // 0xF0
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize240
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int64                    l24  // 0xD0
  public            System.Int64                    l25  // 0xD8
  public            System.Int64                    l26  // 0xE0
  public            System.Int64                    l27  // 0xE8
  public            System.Int64                    l28  // 0xF0
  public            System.Int64                    l29  // 0xF8
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize248
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int64                    l24  // 0xD0
  public            System.Int64                    l25  // 0xD8
  public            System.Int64                    l26  // 0xE0
  public            System.Int64                    l27  // 0xE8
  public            System.Int64                    l28  // 0xF0
  public            System.Int64                    l29  // 0xF8
  public            System.Int64                    l30  // 0x100
METHODS:
END_CLASS

CLASS: Beyond.Reflection.StructSizeGen.FStructSize256
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            System.Int64                    l0  // 0x10
  public            System.Int64                    l1  // 0x18
  public            System.Int64                    l2  // 0x20
  public            System.Int64                    l3  // 0x28
  public            System.Int64                    l4  // 0x30
  public            System.Int64                    l5  // 0x38
  public            System.Int64                    l6  // 0x40
  public            System.Int64                    l7  // 0x48
  public            System.Int64                    l8  // 0x50
  public            System.Int64                    l9  // 0x58
  public            System.Int64                    l10  // 0x60
  public            System.Int64                    l11  // 0x68
  public            System.Int64                    l12  // 0x70
  public            System.Int64                    l13  // 0x78
  public            System.Int64                    l14  // 0x80
  public            System.Int64                    l15  // 0x88
  public            System.Int64                    l16  // 0x90
  public            System.Int64                    l17  // 0x98
  public            System.Int64                    l18  // 0xA0
  public            System.Int64                    l19  // 0xA8
  public            System.Int64                    l20  // 0xB0
  public            System.Int64                    l21  // 0xB8
  public            System.Int64                    l22  // 0xC0
  public            System.Int64                    l23  // 0xC8
  public            System.Int64                    l24  // 0xD0
  public            System.Int64                    l25  // 0xD8
  public            System.Int64                    l26  // 0xE0
  public            System.Int64                    l27  // 0xE8
  public            System.Int64                    l28  // 0xF0
  public            System.Int64                    l29  // 0xF8
  public            System.Int64                    l30  // 0x100
  public            System.Int64                    l31  // 0x108
METHODS:
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x20000E1
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Type __Gen_Wrap_0(System.Object P0)
  System.Void __Gen_Wrap_1(System.Object P0, System.Object P1)
  System.Collections.Generic.List<Beyond.Reflection.MethodParamItem> __Gen_Wrap_2(System.Object P0, System.Boolean P1, System.Boolean P2)
  System.String __Gen_Wrap_3(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3)
  System.String __Gen_Wrap_4()
  System.Void __Gen_Wrap_5(System.Span<System.Byte> P0, System.Int32& P1)
  System.Boolean __Gen_Wrap_6(System.Object P0)
  System.Byte[] __Gen_Wrap_7(System.Object P0)
  System.String __Gen_Wrap_8(System.Object P0)
  System.IntPtr __Gen_Wrap_9(System.IntPtr P0, System.Int32 P1, System.Int32& P2)
  Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall __Gen_Wrap_10(System.Object P0)
  System.Int32 __Gen_Wrap_11(System.IntPtr P0, System.Object P1, System.Object P2)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x20000E3
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
TOKEN: 0x20000E4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Reflection-GenericDelegateCaller-GetCustomDelegateType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-GenericDelegateCaller-AddCustomDelegateType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-MethodParamItem-GetMethodParamList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-MethodParamItem-GetMethodSignatureString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCypher-GetKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCypher-GetKey1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCypher-SkipDecrypt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCypher-DecryptLua0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCypher-DecryptLuaString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCypher-DecryptionFunc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaGenericDelegateCaller-GetCaller0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaGenericDelegateCaller-AddCaller0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaGenericDelegateCaller-OverloadMethodCall0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaGenericDelegateCaller-DefaultValueMethodCall0  // 0x0
METHODS:
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Security.XXTEA
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static readonly System.Text.UTF8Encoding        utf8  // 0x0
  private   static  System.UInt32                   delta  // 0x0
METHODS:
  System.UInt32 MX(System.UInt32 sum, System.UInt32 y, System.UInt32 z, System.Int32 p, System.UInt32 e, System.UInt32[] k)
  System.Void .ctor()
  System.Byte[] Encrypt(System.Byte[] data, System.Byte[] key)
  System.Byte[] Encrypt(System.String data, System.Byte[] key)
  System.Byte[] Encrypt(System.Byte[] data, System.String key)
  System.Byte[] Encrypt(System.String data, System.String key)
  System.String EncryptToBase64String(System.Byte[] data, System.Byte[] key)
  System.String EncryptToBase64String(System.String data, System.Byte[] key)
  System.String EncryptToBase64String(System.Byte[] data, System.String key)
  System.String EncryptToBase64String(System.String data, System.String key)
  System.Byte[] Decrypt(System.Byte[] data, System.Byte[] key)
  System.Int32 _Decrypt(System.Span<System.Byte> data, System.Span<System.Byte> key, System.Span<System.Byte> result)
  System.Byte[] Decrypt(System.Byte[] data, System.String key)
  System.Int32 Decrypt(System.Span<System.Byte> data, System.Span<System.Byte> key, System.Span<System.Byte> result)
  System.Byte[] DecryptBase64String(System.String data, System.Byte[] key)
  System.Byte[] DecryptBase64String(System.String data, System.String key)
  System.String DecryptToString(System.Byte[] data, System.Byte[] key)
  System.String DecryptToString(System.Byte[] data, System.String key)
  System.String DecryptBase64StringToString(System.String data, System.Byte[] key)
  System.String DecryptBase64StringToString(System.String data, System.String key)
  System.UInt32[] Encrypt(System.UInt32[] v, System.UInt32[] k)
  System.UInt32[] Decrypt(System.UInt32[] v, System.UInt32[] k)
  System.Void DecryptInPlace(System.Span<System.UInt32> v, System.Span<System.UInt32> k)
  System.UInt32 MxForSpan(System.UInt32 sum, System.UInt32 y, System.UInt32 z, System.Int32 p, System.UInt32 e, System.Span<System.UInt32> k)
  System.Byte[] FixKey(System.Byte[] key)
  System.Void FixKey(System.Span<System.Byte> key, System.Span<System.Byte> fixedkey)
  System.UInt32[] ToUInt32Array(System.Byte[] data, System.Boolean includeLength)
  System.Void ToUInt32Array(System.Span<System.Byte> data, System.Boolean includeLength, System.Span<System.UInt32> result)
  System.Byte[] ToByteArray(System.UInt32[] data, System.Boolean includeLength)
  System.Void ToByteSpanFromUInt32(System.Span<System.UInt32> data, System.Boolean includeLength, System.Span<System.Byte> result, System.Int32& len)
  System.Void .cctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: XLua.CopyByValue
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  public    static  XLua.CopyByValue                Instance  // 0x0
METHODS:
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Byte field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Byte& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.SByte field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.SByte& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Int16 field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Int16& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.UInt16 field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.UInt16& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Int32 field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Int32& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.UInt32 field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.UInt32& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Int64 field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Int64& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.UInt64 field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.UInt64& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Single field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Single& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Double field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Double& field)
  System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Decimal field)
  System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Decimal& field)
  System.Boolean IsStruct(System.Type type)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: XLua.DelegateBridgeBase
TYPE:  class
TOKEN: 0x2000048
EXTENDS: LuaBase
FIELDS:
  private           System.Type                     firstKey  // 0x20
  private           System.Delegate                 firstValue  // 0x28
  private           System.Collections.Generic.Dictionary<System.Type,System.Delegate>bindTo  // 0x30
  public            System.Int32                    errorFuncRef  // 0x38
METHODS:
  System.Boolean get_IsDispose()
  System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv)
  System.Boolean TryGetDelegate(System.Type key, System.Delegate& value)
  System.Void AddDelegate(System.Type key, System.Delegate value)
  System.Delegate GetDelegateByType(System.Type type)
END_CLASS

CLASS: XLua.HotfixDelegateBridge
TYPE:  class
TOKEN: 0x2000049
FIELDS:
METHODS:
  System.Boolean xlua_get_hotfix_flag(System.Int32 idx)
  XLua.DelegateBridge Get(System.Int32 idx)
  System.Void Set(System.Int32 idx, XLua.DelegateBridge val)
END_CLASS

CLASS: XLua.DelegateBridge
TYPE:  class
TOKEN: 0x200004A
EXTENDS: DelegateBridgeBase
FIELDS:
  private   static  XLua.DelegateBridge[]           DelegateBridgeList  // 0x0
  public    static  System.Boolean                  Gen_Flag  // 0x8
  public    static  System.Func<XLua.DelegateBridge,System.Type,System.Delegate>GetDelegateTypeDelegate  // 0x10
METHODS:
  System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv)
  System.Void PCall(System.IntPtr L, System.Int32 nArgs, System.Int32 nResults, System.Int32 errFunc)
  System.Delegate GetDelegateByType(System.Type type)
  System.Void Action()
  System.Void Action(T1 p1)
  System.Void Action(T1 p1, T2 p2)
  System.Void Action(T1 p1, T2 p2, T3 p3)
  System.Void Action(T1 p1, T2 p2, T3 p3, T4 p4)
  TResult Func()
  TResult Func(T1 p1)
  TResult Func(T1 p1, T2 p2)
  TResult Func(T1 p1, T2 p2, T3 p3)
  TResult Func(T1 p1, T2 p2, T3 p3, T4 p4)
  System.Void .cctor()
END_CLASS

CLASS: XLua.GenFlag
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  XLua.GenFlag                    No  // 0x0
  public    static  XLua.GenFlag                    GCOptimize  // 0x0
METHODS:
END_CLASS

CLASS: XLua.LuaCallCSharpAttribute
TYPE:  class
TOKEN: 0x200004C
EXTENDS: Attribute
FIELDS:
  private           XLua.GenFlag                    flag  // 0x10
METHODS:
  XLua.GenFlag get_Flag()
  System.Void .ctor(XLua.GenFlag flag)
END_CLASS

CLASS: XLua.CSharpCallLuaAttribute
TYPE:  class
TOKEN: 0x200004D
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: XLua.BlackListAttribute
TYPE:  class
TOKEN: 0x200004E
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: XLua.OptimizeFlag
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  XLua.OptimizeFlag               Default  // 0x0
  public    static  XLua.OptimizeFlag               PackAsTable  // 0x0
  public    static  XLua.OptimizeFlag               Custom  // 0x0
METHODS:
END_CLASS

CLASS: XLua.GCOptimizeAttribute
TYPE:  class
TOKEN: 0x2000050
EXTENDS: Attribute
FIELDS:
  private           XLua.OptimizeFlag               flag  // 0x10
METHODS:
  XLua.OptimizeFlag get_Flag()
  System.Void .ctor(XLua.OptimizeFlag flag)
END_CLASS

CLASS: XLua.ReflectionUseAttribute
TYPE:  class
TOKEN: 0x2000051
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: XLua.DoNotGenAttribute
TYPE:  class
TOKEN: 0x2000052
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: XLua.AdditionalPropertiesAttribute
TYPE:  class
TOKEN: 0x2000053
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: XLua.HotfixFlag
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  XLua.HotfixFlag                 Stateless  // 0x0
  public    static  XLua.HotfixFlag                 Stateful  // 0x0
  public    static  XLua.HotfixFlag                 ValueTypeBoxing  // 0x0
  public    static  XLua.HotfixFlag                 IgnoreProperty  // 0x0
  public    static  XLua.HotfixFlag                 IgnoreNotPublic  // 0x0
  public    static  XLua.HotfixFlag                 Inline  // 0x0
  public    static  XLua.HotfixFlag                 IntKey  // 0x0
  public    static  XLua.HotfixFlag                 AdaptByDelegate  // 0x0
  public    static  XLua.HotfixFlag                 IgnoreCompilerGenerated  // 0x0
  public    static  XLua.HotfixFlag                 NoBaseProxy  // 0x0
METHODS:
END_CLASS

CLASS: XLua.HotfixAttribute
TYPE:  class
TOKEN: 0x2000055
EXTENDS: Attribute
FIELDS:
  private           XLua.HotfixFlag                 flag  // 0x10
METHODS:
  XLua.HotfixFlag get_Flag()
  System.Void .ctor(XLua.HotfixFlag e)
END_CLASS

CLASS: XLua.HotfixDelegateAttribute
TYPE:  class
TOKEN: 0x2000056
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: XLua.SysGenConfig
TYPE:  class
TOKEN: 0x2000057
FIELDS:
METHODS:
  System.Collections.Generic.List<System.Type> get_GCOptimize()
  System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<System.String>> get_AdditionalProperties()
END_CLASS

CLASS: XLua.InternalGlobals
TYPE:  class
TOKEN: 0x2000058
FIELDS:
  private   static  System.Byte[]                   strBuff  // 0x0
  public    static  XLua.InternalGlobals.TryArrayGetgenTryArrayGetPtr  // 0x8
  public    static  XLua.InternalGlobals.TryArraySetgenTryArraySetPtr  // 0x10
  private   static  System.Int32                    LUA_REGISTRYINDEX  // 0x18
  private   static  System.Collections.Generic.Dictionary<System.String,System.String>supportOp  // 0x20
  public    static  System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>extensionMethodMap  // 0x28
  private   static  XLua.LuaDLL.lua_CSFunction      LazyReflectionWrap  // 0x30
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: XLua.LuaBase
TYPE:  class
TOKEN: 0x200005B
FIELDS:
  public            System.Boolean                  disposed  // 0x10
  public    readonly System.Int32                    luaReference  // 0x14
  public    readonly XLua.LuaEnv                     luaEnv  // 0x18
METHODS:
  System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposeManagedResources)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.Void push(System.IntPtr L)
END_CLASS

CLASS: XLua.lua_debug
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  public            System.Int32                    eventCode  // 0x10
  public            System.IntPtr                   name  // 0x18
  public            System.IntPtr                   namewhat  // 0x20
  public            System.IntPtr                   what  // 0x28
  public            System.IntPtr                   source  // 0x30
  public            System.Int32                    currentline  // 0x38
  public            System.Int32                    linedefined  // 0x3C
METHODS:
END_CLASS

CLASS: XLua.lua_state
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.IntPtr                   ptr  // 0x10
  public            System.Byte                     byte1  // 0x18
  public            System.Byte                     byte2  // 0x19
  public            System.Byte                     status  // 0x1A
  public            System.Byte                     allowhook  // 0x1B
METHODS:
END_CLASS

CLASS: XLua.lua_Hook
TYPE:  class
TOKEN: 0x200005E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr L, XLua.lua_debug& ar)
  System.IAsyncResult BeginInvoke(System.IntPtr L, XLua.lua_debug& ar, System.AsyncCallback callback, System.Object object)
  System.Int32 EndInvoke(XLua.lua_debug& ar, System.IAsyncResult result)
END_CLASS

CLASS: XLua.LuaDeadLoopCheck
TYPE:  class
TOKEN: 0x200005F
FIELDS:
  private   static  System.Threading.Thread         s_checkThread  // 0x0
  private   static  System.Collections.Generic.Stack<System.Diagnostics.Stopwatch>s_costStack  // 0x8
  private   static  System.Threading.SpinLock       s_lockObj  // 0x10
  private   static  System.Boolean                  s_isCheck  // 0x14
  private   static  System.IntPtr                   L  // 0x18
  private   static  UnityEngine.Pool.ObjectPool<System.Diagnostics.Stopwatch>s_stopwatchPool  // 0x20
  private   static  System.Int32                    s_allowHookOffset  // 0x28
METHODS:
  System.Void EnableCheck(System.IntPtr L)
  System.Int32 LuaHook(System.IntPtr L, XLua.lua_debug& ar)
  System.Void DisableCheck(System.IntPtr L)
  System.Void PushTime()
  System.Void PopTime()
  System.Void CheckDeadLoop()
END_CLASS

CLASS: XLua.ILoadLuaProxy
TYPE:  interface
TOKEN: 0x2000060
FIELDS:
METHODS:
  System.Byte[] LoadLua(System.String name)
END_CLASS

CLASS: XLua.LoadLuaProxyModule
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  private   static  XLua.ILoadLuaProxy              s_loadLuaProxy  // 0x0
METHODS:
  System.Void RegisterProxy(XLua.ILoadLuaProxy loadLuaProxy)
  XLua.ILoadLuaProxy GetLoadLuaProxy()
  System.Void .ctor()
END_CLASS

CLASS: XLua.LuaEnv
TYPE:  class
TOKEN: 0x2000062
FIELDS:
  public    static  System.String                   CSHARP_NAMESPACE  // 0x0
  public    static  System.String                   MAIN_SHREAD  // 0x0
  public            System.IntPtr                   rawL  // 0x10
  private           XLua.LuaTable                   _G  // 0x18
  public            XLua.ObjectTranslator           translator  // 0x20
  public            System.Int32                    errorFuncRef  // 0x28
  private   static  System.Int32                    LIB_VERSION_EXPECT  // 0x0
  private   static  System.Collections.Generic.List<System.Action<XLua.LuaEnv,XLua.ObjectTranslator>>initers  // 0x0
  private           System.Collections.Generic.Dictionary<System.Int64,System.String>_stringCache  // 0x30
  private           System.Int64                    _stringCacheMemory  // 0x38
  private   readonly System.Int64                    _freeSize  // 0x40
  private           System.Int32                    last_check_point  // 0x48
  private           System.Int32                    max_check_per_tick  // 0x4C
  private           System.Func<System.Object,System.Boolean>object_valid_checker  // 0x50
  private           System.Boolean                  disposed  // 0x58
  private           System.Collections.Generic.Queue<XLua.LuaEnv.GCAction>refQueue  // 0x60
  private           System.Collections.Generic.List<XLua.LuaEnv.CustomLoader>customLoaders  // 0x68
  private           System.Collections.Generic.Dictionary<System.String,XLua.LuaDLL.lua_CSFunction>buildin_initer  // 0x70
METHODS:
  System.IntPtr get_L()
  System.Void .ctor()
  System.Void AddIniter(System.Action<XLua.LuaEnv,XLua.ObjectTranslator> initer)
  XLua.LuaTable get_Global()
  T LoadString(System.Byte[] chunk, System.String chunkName, XLua.LuaTable env)
  T LoadString(System.String chunk, System.String chunkName, XLua.LuaTable env)
  XLua.LuaFunction LoadString(System.String chunk, System.String chunkName, XLua.LuaTable env)
  System.Object[] DoString(System.Byte[] chunk, System.String chunkName, XLua.LuaTable env)
  System.Object[] DoString(System.String chunk, System.String chunkName, XLua.LuaTable env)
  System.Object[] DoFile(System.String luaFile, System.String chunkName, XLua.LuaTable env)
  System.Object[] DoFile(System.String luaFile, XLua.LuaTable env)
  System.Object[] CallGlobalFunction(System.String funcName)
  System.Object[] CallGlobalFunction(System.String funcName, T0 param0)
  System.Void SetGlobalTable(K key, V value)
  V GetGlobalTable(K key)
  System.Void InitCacheString()
  System.String TryGetLuaString(System.IntPtr p)
  System.Void RefString(System.IntPtr L, System.IntPtr strPoint, System.Int32 index, System.String ss)
  System.Void ReleaseStringCache(System.Boolean dispose)
  System.Void AutoFreeStringCache()
  System.Void AddSearcher(XLua.LuaDLL.lua_CSFunction searcher, System.Int32 index)
  System.Void Alias(System.Type type, System.String alias)
  System.Boolean ObjectValidCheck(System.Object obj)
  System.Void ClearAllUserdata()
  System.Void CleanTick()
  System.Void GC()
  XLua.LuaTable NewTable()
  System.Void Dispose()
  System.Void Dispose(System.Boolean dispose)
  System.Void ThrowExceptionFromError(System.Int32 oldTop)
  System.Void equeueGCAction(XLua.LuaEnv.GCAction action)
  System.Void AddLoader(XLua.LuaEnv.CustomLoader loader)
  System.Void AddBuildin(System.String name, XLua.LuaDLL.lua_CSFunction initer)
  System.Int32 get_GcPause()
  System.Void set_GcPause(System.Int32 value)
  System.Int32 get_GcStepmul()
  System.Void set_GcStepmul(System.Int32 value)
  System.Void FullGc()
  System.Void StopGc()
  System.Void RestartGc()
  System.Boolean GcStep(System.Int32 data)
  System.Int32 get_Memroy()
END_CLASS

CLASS: XLua.LuaException
TYPE:  class
TOKEN: 0x2000065
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.String message)
END_CLASS

CLASS: XLua.LuaFunction
TYPE:  class
TOKEN: 0x2000066
EXTENDS: LuaBase
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv)
  System.Void Action(T a)
  TResult Func(T a)
  System.Void Action(T1 a1, T2 a2)
  TResult Func(T1 a1, T2 a2)
  System.Object[] Call(System.Object[] args, System.Type[] returnTypes)
  System.Object[] Call(System.Object[] args)
  T Cast()
  System.Void SetEnv(XLua.LuaTable env)
  System.Void push(System.IntPtr L)
  System.String ToString()
END_CLASS

CLASS: XLua.LuaTable
TYPE:  class
TOKEN: 0x2000067
EXTENDS: LuaBase
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv)
  System.Void Get(TKey key, TValue& value)
  System.Boolean ContainsKey(TKey key)
  System.Void Set(TKey key, TValue value)
  T GetInPath(System.String path)
  System.Void SetInPath(System.String path, T val)
  System.Object get_Item(System.String field)
  System.Void set_Item(System.String field, System.Object value)
  System.Object get_Item(System.Object field)
  System.Void set_Item(System.Object field, System.Object value)
  System.Void ForEach(System.Action<TKey,TValue> action)
  System.Int32 get_Length()
  System.Collections.IEnumerable GetKeys()
  System.Collections.Generic.IEnumerable<T> GetKeys()
  T Get(System.Object key)
  TValue Get(TKey key)
  TValue Get(System.String key)
  System.Void SetMetaTable(XLua.LuaTable metaTable)
  T Cast()
  System.Void push(System.IntPtr L)
  System.String ToString()
  XLua.ObjectTranslator GetTranslator()
END_CLASS

CLASS: XLua.IOverloadMethodWrap
TYPE:  interface
TOKEN: 0x200006A
FIELDS:
METHODS:
  System.Boolean get_InitedForDelegateCall()
  System.Boolean get_HasDefalutValue()
  System.Int32 Call(System.IntPtr L, XLua.ObjectTranslator translator)
  System.Boolean Check(System.IntPtr L, System.Boolean haveOverload)
END_CLASS

CLASS: XLua.OverloadMethodWrapBase
TYPE:  class
TOKEN: 0x200006B
FIELDS:
  protected         XLua.ObjectTranslator           translator  // 0x10
  protected         System.Reflection.MethodBase    method  // 0x18
METHODS:
  XLua.IOverloadMethodWrap CreateMethodWrap(XLua.ObjectTranslator translator, System.Reflection.MethodBase method, System.Type target)
  System.Void .ctor()
END_CLASS

CLASS: XLua.OverloadMethodWrapForDelegate
TYPE:  class
TOKEN: 0x200006C
EXTENDS: OverloadMethodWrapBase
FIELDS:
  private           System.Collections.Generic.List<System.Type>castTypes  // 0x20
  private           System.Delegate                 delegate  // 0x28
  private           Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCallcaller  // 0x30
  private           System.Int32                    <OptionParamCount>k__BackingField  // 0x38
  private           System.Object[]                 <DefalutValue>k__BackingField  // 0x40
  private           System.Boolean                  <HasDefalutValue>k__BackingField  // 0x48
  private           System.Boolean[]                <OutParamFlags>k__BackingField  // 0x50
METHODS:
  System.Boolean get_InitedForDelegateCall()
  System.Collections.Generic.List<System.Type> get_CastTypes()
  System.Int32 get_OptionParamCount()
  System.Void set_OptionParamCount(System.Int32 value)
  System.Object[] get_DefalutValue()
  System.Void set_DefalutValue(System.Object[] value)
  System.Boolean get_HasDefalutValue()
  System.Void set_HasDefalutValue(System.Boolean value)
  System.Boolean[] get_OutParamFlags()
  System.Void set_OutParamFlags(System.Boolean[] value)
  System.Void .ctor(System.Reflection.MethodInfo method)
  XLua.OverloadMethodWrapForDelegate TryGetWrapForDelegate(System.Reflection.MethodInfo method)
  System.Void InitForDefaultValue()
  System.Int32 Call(System.IntPtr L, XLua.ObjectTranslator translator)
  System.Boolean Check(System.IntPtr L, System.Boolean haveOverload)
END_CLASS

CLASS: XLua.OverloadMethodWrapForReflection
TYPE:  class
TOKEN: 0x200006D
EXTENDS: OverloadMethodWrapBase
FIELDS:
  private           XLua.ObjectCheck[]              checkArray  // 0x20
  private           XLua.ObjectCast[]               castArray  // 0x28
  private           System.Type                     targetType  // 0x30
  private           System.Int32[]                  inPosArray  // 0x38
  private           System.Int32[]                  outPosArray  // 0x40
  private           System.Boolean[]                isOptionalArray  // 0x48
  private           System.Object[]                 defaultValueArray  // 0x50
  private           System.Boolean                  isVoid  // 0x58
  private           System.Int32                    luaStackPosStart  // 0x5C
  private           System.Boolean                  targetNeeded  // 0x60
  private           System.Object[]                 args  // 0x68
  private           System.Int32[]                  refPos  // 0x70
  private           System.Type                     paramsType  // 0x78
METHODS:
  System.Void .ctor(System.Type target, System.Reflection.MethodBase methodInfo)
  System.Void Init(XLua.ObjectCheckers objCheckers, XLua.ObjectCasters objCasters)
  System.Int32 Call(System.IntPtr L, XLua.ObjectTranslator translator)
  System.Boolean get_InitedForDelegateCall()
  System.Boolean get_HasDefalutValue()
  System.Boolean Check(System.IntPtr L, System.Boolean haveOverload)
  System.Boolean Check(System.IntPtr L)
  System.Boolean CheckForNoOverride(System.IntPtr L)
END_CLASS

CLASS: XLua.OverloadMethodWrap
TYPE:  class
TOKEN: 0x200006E
FIELDS:
  private           XLua.ObjectTranslator           translator  // 0x10
  private           System.Type                     targetType  // 0x18
  private           System.Reflection.MethodBase    method  // 0x20
  private           XLua.ObjectCheck[]              checkArray  // 0x28
  private           XLua.ObjectCast[]               castArray  // 0x30
  private           System.Collections.Generic.List<System.Type>castTypes  // 0x38
  private           System.Delegate                 delegate  // 0x40
  private           Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCallcaller  // 0x48
  private           System.Int32[]                  inPosArray  // 0x50
  private           System.Int32[]                  outPosArray  // 0x58
  private           System.Boolean[]                isOptionalArray  // 0x60
  private           System.Object[]                 defaultValueArray  // 0x68
  private           System.Boolean                  isVoid  // 0x70
  private           System.Int32                    luaStackPosStart  // 0x74
  private           System.Boolean                  targetNeeded  // 0x78
  private           System.Object[]                 args  // 0x80
  private           System.Int32[]                  refPos  // 0x88
  private           System.Type                     paramsType  // 0x90
  private           System.Int32                    <OptionParamCount>k__BackingField  // 0x98
  private           System.Object[]                 <DefalutValue>k__BackingField  // 0xA0
  private           System.Boolean                  <IsInited>k__BackingField  // 0xA8
  private           System.Boolean                  <HasDefalutValue>k__BackingField  // 0xA9
METHODS:
  System.Boolean get_InitedForDelegateCall()
  System.Reflection.MethodBase get_Method()
  System.Collections.Generic.List<System.Type> get_CastTypes()
  System.Int32 get_OptionParamCount()
  System.Void set_OptionParamCount(System.Int32 value)
  System.Object[] get_DefalutValue()
  System.Void set_DefalutValue(System.Object[] value)
  System.Void set_IsInited(System.Boolean value)
  System.Boolean get_IsInited()
  System.Boolean get_HasDefalutValue()
  System.Void set_HasDefalutValue(System.Boolean value)
  System.Void .ctor(XLua.ObjectTranslator translator, System.Type targetType, System.Reflection.MethodBase method)
  System.Void Init(XLua.ObjectCheckers objCheckers, XLua.ObjectCasters objCasters)
  System.Void InitForDefaultValue()
  System.Void InitForDelegateCallMethod()
  System.Int32 Call(System.IntPtr L)
  System.Int32 CallForDelegate(System.IntPtr L, XLua.ObjectTranslator translator)
END_CLASS

CLASS: XLua.MethodWrap
TYPE:  class
TOKEN: 0x200006F
FIELDS:
  private           System.String                   methodName  // 0x10
  private           XLua.IOverloadMethodWrap[]      overloads  // 0x18
  private           System.Type                     targetType  // 0x20
  private           System.Reflection.MethodBase[]  allMethods  // 0x28
  private           System.Boolean                  forceCheck  // 0x30
  private           System.Boolean                  initedForDelegateCall  // 0x31
  private           System.Boolean                  haveDefault  // 0x32
METHODS:
  System.Void .ctor(System.String methodName, System.Collections.Generic.List<System.Reflection.MethodBase> overloads, System.Type targetType, System.Boolean forceCheck)
  System.Void _InitForDelegateCall()
  System.Int32 Call(System.IntPtr L)
END_CLASS

CLASS: XLua.MethodWrapsCache
TYPE:  class
TOKEN: 0x2000070
FIELDS:
  public    static  System.Collections.Generic.Dictionary<System.Type,XLua.LuaDLL.lua_CSFunction>CodeGenConstructorMap  // 0x0
  private           XLua.ObjectTranslator           translator  // 0x10
  private           XLua.ObjectCheckers             objCheckers  // 0x18
  private           XLua.ObjectCasters              objCasters  // 0x20
  private           System.Collections.Generic.Dictionary<System.Type,XLua.LuaDLL.lua_CSFunction>constructorCache  // 0x28
  private           System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,XLua.LuaDLL.lua_CSFunction>>methodsCache  // 0x30
  private           System.Collections.Generic.Dictionary<System.Type,XLua.LuaDLL.lua_CSFunction>delegateCache  // 0x38
METHODS:
  System.Void AddCodeGenConstructor(System.Type type, XLua.LuaDLL.lua_CSFunction lua_CSFunction)
  System.Void ClearCodeGenConstructorMap()
  System.Void .cctor()
  System.Void .ctor(XLua.ObjectTranslator translator, XLua.ObjectCheckers objCheckers, XLua.ObjectCasters objCasters)
  XLua.LuaDLL.lua_CSFunction GetConstructorWrap(System.Type type)
  XLua.LuaDLL.lua_CSFunction GetMethodWrap(System.Type type, System.String methodName)
  XLua.LuaDLL.lua_CSFunction GetMethodWrapInCache(System.Type type, System.String methodName)
  XLua.LuaDLL.lua_CSFunction GetDelegateWrap(System.Type type)
  XLua.LuaDLL.lua_CSFunction GetEventWrap(System.Type type, System.String eventName)
  XLua.MethodWrap _GenMethodWrap(System.Type type, System.String methodName, System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> methodBases, System.Boolean forceCheck)
  System.Boolean tryMakeGenericMethod(System.Reflection.MethodBase& method)
END_CLASS

CLASS: XLua.ObjectCheck
TYPE:  class
TOKEN: 0x2000074
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.IntPtr L, System.Int32 idx)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: XLua.ObjectCast
TYPE:  class
TOKEN: 0x2000075
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Object Invoke(System.IntPtr L, System.Int32 idx, System.Object target)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.Object target, System.AsyncCallback callback, System.Object object)
  System.Object EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: XLua.ObjectCheckers
TYPE:  class
TOKEN: 0x2000076
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Type,XLua.ObjectCheck>checkersMap  // 0x10
  private           XLua.ObjectTranslator           translator  // 0x18
METHODS:
  System.Void .ctor(XLua.ObjectTranslator translator)
  System.Boolean objectCheck(System.IntPtr L, System.Int32 idx)
  System.Boolean luaTableCheck(System.IntPtr L, System.Int32 idx)
  System.Boolean numberCheck(System.IntPtr L, System.Int32 idx)
  System.Boolean decimalCheck(System.IntPtr L, System.Int32 idx)
  System.Boolean strCheck(System.IntPtr L, System.Int32 idx)
  System.Boolean bytesCheck(System.IntPtr L, System.Int32 idx)
  System.Boolean boolCheck(System.IntPtr L, System.Int32 idx)
  System.Boolean int64Check(System.IntPtr L, System.Int32 idx)
  System.Boolean uint64Check(System.IntPtr L, System.Int32 idx)
  System.Boolean luaFunctionCheck(System.IntPtr L, System.Int32 idx)
  System.Boolean intptrCheck(System.IntPtr L, System.Int32 idx)
  XLua.ObjectCheck genChecker(System.Type type)
  XLua.ObjectCheck genNullableChecker(XLua.ObjectCheck oc)
  System.Void AddChecker(System.Type type, XLua.ObjectCheck oc)
  XLua.ObjectCheck GetChecker(System.Type type)
END_CLASS

CLASS: XLua.ObjectCasters
TYPE:  class
TOKEN: 0x2000079
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Type,XLua.ObjectCast>castersMap  // 0x10
  private           XLua.ObjectTranslator           translator  // 0x18
METHODS:
  System.Void .ctor(XLua.ObjectTranslator translator)
  System.Object charCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object sbyteCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object byteCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object shortCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object ushortCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object intCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object uintCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object longCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object ulongCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object getDouble(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object floatCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object decimalCaster(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object getBoolean(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object getString(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object getBytes(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object getIntptr(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object getObject(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object getLuaTable(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Object getLuaFunction(System.IntPtr L, System.Int32 idx, System.Object target)
  System.Void AddCaster(System.Type type, XLua.ObjectCast oc)
  XLua.ObjectCast genCaster(System.Type type)
  XLua.ObjectCast genNullableCaster(XLua.ObjectCast oc)
  XLua.ObjectCast GetCaster(System.Type type)
END_CLASS

CLASS: XLua.ObjectPool
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  private   static  System.Int32                    LIST_END  // 0x0
  private   static  System.Int32                    ALLOCED  // 0x0
  private           XLua.ObjectPool.Slot[]          list  // 0x10
  private           System.Int32                    freelist  // 0x18
  private           System.Int32                    count  // 0x1C
  private           System.Collections.Generic.List<System.Object>needCleanImmediately  // 0x20
METHODS:
  System.Object get_Item(System.Int32 i)
  System.Void AddToNeedCleanImmediately(System.Object obj)
  System.Void Clear()
  System.Void extend_capacity()
  System.Int32 Add(System.Object obj)
  System.Boolean TryGetValue(System.Int32 index, System.Object& obj)
  System.Object Get(System.Int32 index)
  System.Object Remove(System.Int32 index)
  System.Object Replace(System.Int32 index, System.Object o)
  System.Int32 Check(System.Int32 check_pos, System.Int32 max_check, System.Func<System.Object,System.Boolean> checker, System.Collections.Generic.Dictionary<System.Object,System.Int32> reverse_map)
  System.Void ClearAllUserdata(System.Func<System.Object,System.Boolean> checker, System.Collections.Generic.Dictionary<System.Object,System.Int32> reverse_map)
  System.Void .ctor()
END_CLASS

CLASS: XLua.ReferenceEqualsComparer
TYPE:  class
TOKEN: 0x2000080
FIELDS:
METHODS:
  System.Boolean Equals(System.Object o1, System.Object o2)
  System.Int32 GetHashCode(System.Object obj)
  System.Void .ctor()
END_CLASS

CLASS: XLua.MonoPInvokeCallbackAttribute
TYPE:  class
TOKEN: 0x2000081
EXTENDS: Attribute
FIELDS:
  private           System.Type                     type  // 0x10
METHODS:
  System.Void .ctor(System.Type t)
END_CLASS

CLASS: XLua.LuaTypes
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  XLua.LuaTypes                   LUA_TNONE  // 0x0
  public    static  XLua.LuaTypes                   LUA_TNIL  // 0x0
  public    static  XLua.LuaTypes                   LUA_TNUMBER  // 0x0
  public    static  XLua.LuaTypes                   LUA_TSTRING  // 0x0
  public    static  XLua.LuaTypes                   LUA_TBOOLEAN  // 0x0
  public    static  XLua.LuaTypes                   LUA_TTABLE  // 0x0
  public    static  XLua.LuaTypes                   LUA_TFUNCTION  // 0x0
  public    static  XLua.LuaTypes                   LUA_TUSERDATA  // 0x0
  public    static  XLua.LuaTypes                   LUA_TTHREAD  // 0x0
  public    static  XLua.LuaTypes                   LUA_TLIGHTUSERDATA  // 0x0
METHODS:
END_CLASS

CLASS: XLua.LuaGCOptions
TYPE:  struct
TOKEN: 0x2000083
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  XLua.LuaGCOptions               LUA_GCSTOP  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCRESTART  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCCOLLECT  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCCOUNT  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCCOUNTB  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCSTEP  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCSETPAUSE  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCSETSTEPMUL  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCISRUNNING  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCGEN  // 0x0
  public    static  XLua.LuaGCOptions               LUA_GCINC  // 0x0
METHODS:
END_CLASS

CLASS: XLua.LuaThreadStatus
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  XLua.LuaThreadStatus            LUA_RESUME_ERROR  // 0x0
  public    static  XLua.LuaThreadStatus            LUA_OK  // 0x0
  public    static  XLua.LuaThreadStatus            LUA_YIELD  // 0x0
  public    static  XLua.LuaThreadStatus            LUA_ERRRUN  // 0x0
  public    static  XLua.LuaThreadStatus            LUA_ERRSYNTAX  // 0x0
  public    static  XLua.LuaThreadStatus            LUA_ERRMEM  // 0x0
  public    static  XLua.LuaThreadStatus            LUA_ERRERR  // 0x0
METHODS:
END_CLASS

CLASS: XLua.LuaIndexes
TYPE:  class
TOKEN: 0x2000085
FIELDS:
METHODS:
  System.Int32 get_LUA_REGISTRYINDEX()
  System.Void set_LUA_REGISTRYINDEX(System.Int32 value)
  System.Void .ctor()
END_CLASS

CLASS: XLua.ObjectTranslator
TYPE:  class
TOKEN: 0x2000086
FIELDS:
  public            XLua.MethodWrapsCache           methodWrapsCache  // 0x10
  public            XLua.ObjectCheckers             objectCheckers  // 0x18
  public            XLua.ObjectCasters              objectCasters  // 0x20
  private   readonly XLua.ObjectPool                 objects  // 0x28
  private   readonly System.Collections.Generic.Dictionary<System.Object,System.Int32>reverseMap  // 0x30
  private           XLua.LuaEnv                     luaEnv  // 0x38
  private           XLua.StaticLuaCallbacks         metaFunctions  // 0x40
  private           System.Collections.Generic.List<System.Reflection.Assembly>assemblies  // 0x48
  private           XLua.LuaDLL.lua_CSFunction      importTypeFunction  // 0x50
  private           XLua.LuaDLL.lua_CSFunction      loadAssemblyFunction  // 0x58
  private           XLua.LuaDLL.lua_CSFunction      castFunction  // 0x60
  private   static  XLua.LuaDLL.lua_CSFunction      listPairFunction  // 0x0
  private   static  XLua.LuaDLL.lua_CSFunction      dicPairFunction  // 0x8
  private   static  XLua.LuaDLL.lua_CSFunction      normalPairFunction  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Type,System.Action<System.IntPtr>>delayWrap  // 0x68
  private   readonly System.Collections.Generic.Dictionary<System.Type,System.Func<System.Int32,XLua.LuaEnv,XLua.LuaBase>>interfaceBridgeCreators  // 0x70
  private   readonly System.Collections.Generic.Dictionary<System.Type,System.Type>aliasCfg  // 0x78
  private           System.Collections.Generic.Dictionary<System.Type,System.Boolean>loaded_types  // 0x80
  public            System.Int32                    cacheRef  // 0x88
  private           System.Reflection.MethodInfo[]  genericAction  // 0x90
  private           System.Reflection.MethodInfo[]  genericFunc  // 0x98
  private           System.Collections.Generic.Dictionary<System.Type,System.Func<XLua.DelegateBridgeBase,System.Delegate>>delegateCreatorCache  // 0xA0
  private           System.Collections.Generic.Dictionary<System.Int32,System.WeakReference>delegate_bridges  // 0xA8
  private           System.Int32                    common_array_meta  // 0xB0
  private           System.Int32                    common_delegate_meta  // 0xB4
  private           System.Int32                    enumerable_pairs_func  // 0xB8
  private           System.Collections.Generic.Dictionary<System.Type,System.Int32>typeIdMap  // 0xC0
  private           System.Collections.Generic.Dictionary<System.Int32,System.Type>typeMap  // 0xC8
  private           System.Collections.Generic.HashSet<System.Type>privateAccessibleFlags  // 0xD0
  private           System.Collections.Generic.Dictionary<System.Object,System.Int32>enumMap  // 0xD8
  public    static  System.Int32                    s_luaBuffOffset  // 0x18
  public    static  System.Int32                    s_nullableValueOffset  // 0x1C
  private           System.Collections.Generic.Dictionary<System.Type,System.Boolean>_unmanagedTypes  // 0xE0
  private           System.Collections.Generic.List<XLua.LuaDLL.lua_CSFunction>fix_cs_functions  // 0xE8
  private           System.Collections.Generic.List<XLua.ObjectTranslator.LuaCSFunctionPtr>fix_cs_function_ptrs  // 0xF0
  public    static  System.Boolean                  enableLuaCSFunctionPtr  // 0x20
  public    static  XLua.ObjectTranslator.GetDelegatePointer<System.Object>getDelegatePointer  // 0x28
  private           System.Collections.Generic.Dictionary<System.Type,XLua.ObjectTranslator.PushCSObject>custom_push_funcs  // 0xF8
  private           System.Collections.Generic.Dictionary<System.Type,XLua.ObjectTranslator.GetCSObject>custom_get_funcs  // 0x100
  private           System.Collections.Generic.Dictionary<System.Type,XLua.ObjectTranslator.UpdateCSObject>custom_update_funcs  // 0x108
  private           System.Collections.Generic.Dictionary<System.Type,System.Delegate>push_func_with_type  // 0x110
  private           System.Collections.Generic.Dictionary<System.Type,System.Delegate>get_func_with_type  // 0x118
  private           System.Int32                    decimal_type_id  // 0x120
METHODS:
  XLua.ObjectPool get_Pools()
  System.Void DelayWrapLoader(System.Type type, System.Action<System.IntPtr> loader)
  System.Void AddInterfaceBridgeCreator(System.Type type, System.Func<System.Int32,XLua.LuaEnv,XLua.LuaBase> creator)
  System.Boolean TryDelayWrapLoader(System.IntPtr L, System.Type type)
  System.Void Alias(System.Type type, System.String alias)
  System.Void addAssemblieByName(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies_usorted, System.String name)
  System.Void .ctor(XLua.LuaEnv luaenv, System.IntPtr L)
  System.Void initCSharpCallLua()
  System.Func<XLua.DelegateBridgeBase,System.Delegate> getCreatorUsingGeneric(XLua.DelegateBridgeBase bridge, System.Type delegateType, System.Reflection.MethodInfo delegateMethod)
  System.Delegate getDelegate(XLua.DelegateBridgeBase bridge, System.Type delegateType)
  System.Object CreateDelegateBridge(System.IntPtr L, System.Type delegateType, System.Int32 idx)
  System.Boolean AllDelegateBridgeReleased()
  System.Void ReleaseLuaBase(System.IntPtr L, System.Int32 reference, System.Boolean is_delegate)
  System.Object CreateInterfaceBridge(System.IntPtr L, System.Type interfaceType, System.Int32 idx)
  System.Void CreateArrayMetatable(System.IntPtr L)
  System.Void CreateDelegateMetatable(System.IntPtr L)
  System.Void CreateEnumerablePairs(System.IntPtr L)
  System.Int32 CsPairs(System.IntPtr L)
  System.Int32 EnumToInt(System.IntPtr L)
  System.Void CreateEnumerableCSPairs(System.IntPtr L)
  System.Void OpenLib(System.IntPtr L)
  System.Void createFunctionMetatable(System.IntPtr L)
  System.Type FindType(System.String className, System.Boolean isQualifiedName)
  System.Boolean hasMethod(System.Type type, System.String methodName)
  System.Void collectObject(System.Int32 obj_index_to_collect)
  System.Int32 addObject(System.Object obj, System.Boolean is_valuetype, System.Boolean is_enum)
  System.Object GetObject(System.IntPtr L, System.Int32 index)
  System.Type GetTypeOf(System.IntPtr L, System.Int32 idx)
  System.Boolean Assignable(System.IntPtr L, System.Int32 index)
  System.Boolean Assignable(System.IntPtr L, System.Int32 index, System.Type type)
  System.Object FastGetObject(System.IntPtr L, System.Int32 index, System.Type type)
  System.Object GetObject(System.IntPtr L, System.Int32 index, System.Type type)
  System.Void _Get(System.IntPtr L, System.Int32 index, T& v)
  System.Void Get(System.IntPtr L, System.Int32 index, T& v)
  System.Void PushByType(System.IntPtr L, T v)
  T[] GetParams(System.IntPtr L, System.Int32 index)
  System.Array GetParams(System.IntPtr L, System.Int32 index, System.Type type)
  T GetDelegate(System.IntPtr L, System.Int32 index)
  System.Int32 GetTypeId(System.IntPtr L, System.Type type)
  System.Void PrivateAccessible(System.IntPtr L, System.Type type)
  System.Int32 getTypeId(System.IntPtr L, System.Type type, System.Boolean& is_first, XLua.ObjectTranslator.LOGLEVEL log_level)
  System.Void pushPrimitive(System.IntPtr L, System.Object o)
  System.Void PushObject(System.IntPtr L, System.Object o)
  System.Void PushAny(System.IntPtr L, System.Object o)
  System.Int32 TranslateToEnumToTop(System.IntPtr L, System.Type type, System.Int32 idx)
  System.Void Push(System.IntPtr L, XLua.LuaDLL.lua_CSFunction o)
  System.Void Push(System.IntPtr L, XLua.LuaBase o)
  System.Void Push(System.IntPtr L, T o)
  System.Void Push(System.IntPtr L, System.Object o)
  System.Void PushObject(System.IntPtr L, System.Object o, System.Int32 type_id)
  System.Boolean IsUnmanagedType(System.Type type)
  System.Void PushBrigeStruct(System.IntPtr L, System.IntPtr ptr, System.Type type, System.Int32 size)
  System.Void _PushBrigeStruct(System.IntPtr L, System.IntPtr ptr, System.Type type, System.Int32 size)
  System.Void GetBrigeStruct(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type)
  System.Void AddNeedRemoveObjRef(System.Object obj)
  System.Void _GetBrigeStruct(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type)
  System.Void UpdateStructObj(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type)
  System.Void BeyondUpdateStructObj(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type)
  System.Void _UpdateStructObj(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type)
  System.Void Update(System.IntPtr L, System.Int32 index, T obj)
  System.Void Update(System.IntPtr L, System.Int32 index, System.Object obj)
  System.Object getCsObj(System.IntPtr L, System.Int32 index, System.Int32 udata)
  System.Object SafeGetCSObj(System.IntPtr L, System.Int32 index)
  System.Object FastGetCSObj(System.IntPtr L, System.Int32 index)
  System.Void ReleaseCSObj(System.IntPtr L, System.Int32 index)
  XLua.LuaDLL.lua_CSFunction GetFixCSFunction(System.Int32 index)
  XLua.ObjectTranslator.LuaCSFunctionPtr GetFixCSFunctionPtr(System.Int32 index)
  System.Void PushFixCSFunction(System.IntPtr L, XLua.LuaDLL.lua_CSFunction func)
  System.Object[] popValues(System.IntPtr L, System.Int32 oldTop)
  System.Object[] popValues(System.IntPtr L, System.Int32 oldTop, System.Type[] popTypes)
  System.Void registerCustomOp(System.Type type, XLua.ObjectTranslator.PushCSObject push, XLua.ObjectTranslator.GetCSObject get, XLua.ObjectTranslator.UpdateCSObject update)
  System.Boolean HasCustomOp(System.Type type)
  System.Boolean tryGetPushFuncByType(System.Type type, T& func)
  System.Boolean tryGetGetFuncByType(System.Type type, T& func)
  System.Void RegisterPushAndGetAndUpdate(System.Action<System.IntPtr,T> push, XLua.ObjectTranslator.GetFunc<T> get, System.Action<System.IntPtr,System.Int32,T> update)
  System.Void RegisterChecker(XLua.ObjectTranslator.CheckFunc<T> check)
  System.Void RegisterCaster(XLua.ObjectTranslator.GetFunc<T> get)
  System.Void PushDecimal(System.IntPtr L, System.Decimal val)
  System.Boolean IsDecimal(System.IntPtr L, System.Int32 index)
  System.Decimal GetDecimal(System.IntPtr L, System.Int32 index)
  System.Void Get(System.IntPtr L, System.Int32 index, System.Decimal& val)
  System.Void .cctor()
  System.Decimal <tryGetGetFuncByType>b__125_0(System.IntPtr L, System.Int32 idx)
END_CLASS

CLASS: XLua.ObjectTranslatorPool
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  private           System.Collections.Generic.Dictionary<System.IntPtr,System.WeakReference>translators  // 0x10
  private           System.IntPtr                   lastPtr  // 0x18
  private           XLua.ObjectTranslator           lastTranslator  // 0x20
  public    static  XLua.ObjectTranslatorPool       Instance  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Add(System.IntPtr L, XLua.ObjectTranslator translator)
  XLua.ObjectTranslator Find(System.IntPtr L)
  System.Void Remove(System.IntPtr L)
  System.Void .cctor()
END_CLASS

CLASS: XLua.RawObject
TYPE:  interface
TOKEN: 0x200009D
FIELDS:
METHODS:
  System.Object get_Target()
END_CLASS

CLASS: XLua.InternalUtility
TYPE:  class
TOKEN: 0x200009E
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,System.String>s_baseValueTypeDic  // 0x0
METHODS:
  System.String GetTypeGenericSignatureDefine(System.Type type, System.Boolean isGetType, System.Boolean isRef, System.Boolean isOut, System.Boolean needLua, System.Boolean keepType, System.Boolean needEnum)
  System.Boolean CheckRegisterBaseStructOnArm(System.Type type)
  System.Boolean CheckCustomDelegate(System.String name)
  System.Boolean CheckTypNeedToGen(System.Type type)
  System.Boolean IsPublic(System.Type type)
  System.String GetTypeFullName(System.Type t)
  System.String GetDelegateName(System.Reflection.MethodInfo method)
  System.Boolean IsStruct(System.Type type)
  System.String GetGenericTypeName(System.Type type, System.Boolean needPoint)
  System.String GeNormalName(System.String str)
  System.String GetGenericTypeNameString(System.Type type)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: XLua.MethodAndDelegateSignatureManager
TYPE:  class
TOKEN: 0x200009F
FIELDS:
METHODS:
  System.Type MakeMethodDelegateType(System.Reflection.MethodInfo method)
  System.Type MakeMethodDelegateType(System.Reflection.MethodInfo method, System.Type customDelegateType)
  System.ValueTuple<System.Type,System.String> GetMethodDelegateType(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: XLua.SignatureLoader
TYPE:  class
TOKEN: 0x20000A0
FIELDS:
  private           XLua.LuaEnv.CustomLoader        userLoader  // 0x10
  private           System.Security.Cryptography.RSACryptoServiceProviderrsa  // 0x18
  private           System.Security.Cryptography.SHA1sha  // 0x20
METHODS:
  System.Void .ctor(System.String publicKey, XLua.LuaEnv.CustomLoader loader)
  System.Byte[] load_and_verify(System.String& filepath)
  XLua.LuaEnv.CustomLoader op_Implicit(XLua.SignatureLoader signatureLoader)
END_CLASS

CLASS: XLua.CallDelegatePointer`3
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TRet Invoke(System.IntPtr ptr, TParam1 target, TParam2 param)
  System.IAsyncResult BeginInvoke(System.IntPtr ptr, TParam1 target, TParam2 param, System.AsyncCallback callback, System.Object object)
  TRet EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: XLua.StaticLuaCallbacks
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
  private           XLua.LuaDLL.lua_CSFunction      GcMeta  // 0x10
  private           XLua.LuaDLL.lua_CSFunction      ToStringMeta  // 0x18
  private           XLua.LuaDLL.lua_CSFunction      EnumAndMeta  // 0x20
  private           XLua.LuaDLL.lua_CSFunction      EnumOrMeta  // 0x28
  private           XLua.LuaDLL.lua_CSFunction      StaticCSFunctionWraper  // 0x30
  private           XLua.LuaDLL.lua_CSFunction      FixCSFunctionWraper  // 0x38
  private           XLua.LuaDLL.lua_CSFunction      DelegateCtor  // 0x40
  public    static  XLua.CallDelegatePointer<System.Object,System.IntPtr,System.Int32>callDelegatePointer  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 EnumAnd(System.IntPtr L)
  System.Int32 EnumOr(System.IntPtr L)
  System.Int32 StaticCSFunction(System.IntPtr L)
  System.Int32 FixCSFunction(System.IntPtr L)
  System.Int32 DelegateCall(System.IntPtr L)
  System.Int32 LuaGC(System.IntPtr L)
  System.Int32 ToString(System.IntPtr L)
  System.Int32 DelegateCombine(System.IntPtr L)
  System.Int32 DelegateRemove(System.IntPtr L)
  System.Boolean tryPrimitiveArrayGet(System.Type type, System.IntPtr L, System.Object obj, System.Int32 index)
  System.Int32 ArrayIndexer(System.IntPtr L)
  System.Boolean TryPrimitiveArraySet(System.Type type, System.IntPtr L, System.Object obj, System.Int32 array_idx, System.Int32 obj_idx)
  System.Int32 ArrayNewIndexer(System.IntPtr L)
  System.Int32 ArrayLength(System.IntPtr L)
  System.Int32 MetaFuncIndex(System.IntPtr L)
  System.Int32 Panic(System.IntPtr L)
  System.Int32 Print(System.IntPtr L)
  System.Int32 LoadSocketCore(System.IntPtr L)
  System.Int32 LoadCS(System.IntPtr L)
  System.Int32 LoadBuiltinLib(System.IntPtr L)
  System.Int32 LoadFromResource(System.IntPtr L)
  System.Int32 LoadFromStreamingAssetsPath(System.IntPtr L)
  System.Int32 LoadFromCustomLoaders(System.IntPtr L)
  System.Int32 LoadAssembly(System.IntPtr L)
  System.Int32 ImportType(System.IntPtr L)
  System.Int32 ImportGenericType(System.IntPtr L)
  System.Int32 Cast(System.IntPtr L)
  System.Type getType(System.IntPtr L, XLua.ObjectTranslator translator, System.Int32 idx)
  System.Int32 XLuaAccess(System.IntPtr L)
  System.Int32 XLuaPrivateAccessible(System.IntPtr L)
  System.Int32 XLuaMetatableOperation(System.IntPtr L)
  System.Int32 DelegateConstructor(System.IntPtr L)
  System.Int32 ToFunction(System.IntPtr L)
  System.Int32 GenericMethodWraper(System.IntPtr L)
  System.Int32 GetGenericMethod(System.IntPtr L)
  System.Int32 ReleaseCsObject(System.IntPtr L)
END_CLASS

CLASS: XLua.TypeExtensions
TYPE:  class
TOKEN: 0x20000A3
FIELDS:
METHODS:
  System.Boolean IsValueType(System.Type type)
  System.Boolean IsEnum(System.Type type)
  System.Boolean IsPrimitive(System.Type type)
  System.Boolean IsAbstract(System.Type type)
  System.Boolean IsSealed(System.Type type)
  System.Boolean IsInterface(System.Type type)
  System.Boolean IsClass(System.Type type)
  System.Type BaseType(System.Type type)
  System.Boolean IsGenericType(System.Type type)
  System.Boolean IsGenericTypeDefinition(System.Type type)
  System.Boolean IsNestedPublic(System.Type type)
  System.Boolean IsPublic(System.Type type)
  System.String GetFriendlyName(System.Type type)
END_CLASS

CLASS: XLua.LazyMemberTypes
TYPE:  struct
TOKEN: 0x20000A5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  XLua.LazyMemberTypes            Method  // 0x0
  public    static  XLua.LazyMemberTypes            FieldGet  // 0x0
  public    static  XLua.LazyMemberTypes            FieldSet  // 0x0
  public    static  XLua.LazyMemberTypes            PropertyGet  // 0x0
  public    static  XLua.LazyMemberTypes            PropertySet  // 0x0
  public    static  XLua.LazyMemberTypes            Event  // 0x0
METHODS:
END_CLASS

CLASS: XLua.Utils
TYPE:  class
TOKEN: 0x20000A6
FIELDS:
  public    static  System.Boolean                  s_xluaReflectionOpt  // 0x0
  public    static  System.Int32                    OBJ_META_IDX  // 0x0
  public    static  System.Int32                    METHOD_IDX  // 0x0
  public    static  System.Int32                    GETTER_IDX  // 0x0
  public    static  System.Int32                    SETTER_IDX  // 0x0
  public    static  System.Int32                    CLS_IDX  // 0x0
  public    static  System.Int32                    CLS_META_IDX  // 0x0
  public    static  System.Int32                    CLS_GETTER_IDX  // 0x0
  public    static  System.Int32                    CLS_SETTER_IDX  // 0x0
  public    static  System.String                   LuaIndexsFieldName  // 0x0
  public    static  System.String                   LuaNewIndexsFieldName  // 0x0
  public    static  System.String                   LuaClassIndexsFieldName  // 0x0
  public    static  System.String                   LuaClassNewIndexsFieldName  // 0x0
METHODS:
  System.Boolean LoadField(System.IntPtr L, System.Int32 idx, System.String field_name)
  System.IntPtr GetMainState(System.IntPtr L)
  System.Collections.Generic.List<System.Type> GetAllTypes(System.Boolean exclude_generic_definition)
  XLua.LuaDLL.lua_CSFunction genFieldGetter(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction genFieldGetterByPointer(System.Type type, System.Reflection.FieldInfo field)
  System.Boolean IsNullableType(System.Type type)
  XLua.LuaDLL.lua_CSFunction genFieldSetter(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction genFieldSetterByPointer(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction genItemGetterOpt(System.Type type, System.Reflection.PropertyInfo[] props, XLua.ObjectTranslator translator)
  XLua.LuaDLL.lua_CSFunction genItemGetter(System.Type type, System.Reflection.PropertyInfo[] props)
  XLua.LuaDLL.lua_CSFunction genItemSetterOpt(System.Type type, System.Reflection.PropertyInfo[] props, XLua.ObjectTranslator translator)
  XLua.LuaDLL.lua_CSFunction genItemSetter(System.Type type, System.Reflection.PropertyInfo[] props)
  XLua.LuaDLL.lua_CSFunction genEnumCastFrom(System.Type type)
  System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetExtensionMethodsOf(System.Type type_to_be_extend)
  System.Void makeReflectionWrap(System.IntPtr L, System.Type type, System.Int32 cls_field, System.Int32 cls_getter, System.Int32 cls_setter, System.Int32 obj_field, System.Int32 obj_getter, System.Int32 obj_setter, System.Int32 obj_meta, XLua.LuaDLL.lua_CSFunction& item_getter, XLua.LuaDLL.lua_CSFunction& item_setter, System.Reflection.BindingFlags access)
  System.Void loadUpvalue(System.IntPtr L, System.Type type, System.String metafunc, System.Int32 index)
  System.Void RegisterEnumType(System.IntPtr L, System.Type type)
  System.Void MakePrivateAccessible(System.IntPtr L, System.Type type)
  System.Int32 LazyReflectionCall(System.IntPtr L)
  System.Void ReflectionWrap(System.IntPtr L, System.Type type, System.Boolean privateAccessible)
  System.Void BeginObjectRegister(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Int32 meta_count, System.Int32 method_count, System.Int32 getter_count, System.Int32 setter_count, System.Int32 type_id)
  System.Int32 abs_idx(System.Int32 top, System.Int32 idx)
  System.Void EndObjectRegister(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, XLua.LuaDLL.lua_CSFunction csIndexer, XLua.LuaDLL.lua_CSFunction csNewIndexer, System.Type base_type, XLua.LuaDLL.lua_CSFunction arrayIndexer, XLua.LuaDLL.lua_CSFunction arrayNewIndexer)
  System.Void RegisterFunc(System.IntPtr L, System.Int32 idx, System.String name, XLua.LuaDLL.lua_CSFunction func)
  System.Void RegisterLazyFunc(System.IntPtr L, System.Int32 idx, System.String name, System.Type type, XLua.LazyMemberTypes memberType, System.Boolean isStatic)
  System.Void RegisterObject(System.IntPtr L, XLua.ObjectTranslator translator, System.Int32 idx, System.String name, System.Object obj)
  System.Void BeginClassRegister(System.Type type, System.IntPtr L, XLua.LuaDLL.lua_CSFunction creator, System.Int32 class_field_count, System.Int32 static_getter_count, System.Int32 static_setter_count)
  System.Void EndClassRegister(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator)
  System.Collections.Generic.List<System.String> getPathOfType(System.Type type)
  System.Void LoadCSTable(System.IntPtr L, System.Type type)
  System.Void SetCSTable(System.IntPtr L, System.Type type, System.Int32 cls_table)
  System.Boolean IsParamsMatch(System.Reflection.MethodInfo delegateMethod, System.Reflection.MethodInfo bridgeMethod)
  System.Boolean IsSupportedMethod(System.Reflection.MethodInfo method)
  System.Reflection.MethodInfo MakeGenericMethodWithConstraints(System.Reflection.MethodInfo method)
  System.Type getExtendedType(System.Reflection.MethodInfo method)
  System.Boolean IsStaticPInvokeCSFunction(XLua.LuaDLL.lua_CSFunction csFunction)
  System.Boolean IsPublic(System.Type type)
  System.Void .cctor()
END_CLASS

CLASS: XLua.Cast.Any`1
TYPE:  class
TOKEN: 0x20000D0
FIELDS:
  private           T                               mTarget  // 0x0
METHODS:
  System.Void .ctor(T i)
  System.Object get_Target()
END_CLASS

CLASS: XLua.Cast.Byte
TYPE:  class
TOKEN: 0x20000D1
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.Byte i)
END_CLASS

CLASS: XLua.Cast.SByte
TYPE:  class
TOKEN: 0x20000D2
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.SByte i)
END_CLASS

CLASS: XLua.Cast.Char
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.Char i)
END_CLASS

CLASS: XLua.Cast.Int16
TYPE:  class
TOKEN: 0x20000D4
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int16 i)
END_CLASS

CLASS: XLua.Cast.UInt16
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.UInt16 i)
END_CLASS

CLASS: XLua.Cast.Int32
TYPE:  class
TOKEN: 0x20000D6
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 i)
END_CLASS

CLASS: XLua.Cast.UInt32
TYPE:  class
TOKEN: 0x20000D7
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.UInt32 i)
END_CLASS

CLASS: XLua.Cast.Int64
TYPE:  class
TOKEN: 0x20000D8
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int64 i)
END_CLASS

CLASS: XLua.Cast.UInt64
TYPE:  class
TOKEN: 0x20000D9
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.UInt64 i)
END_CLASS

CLASS: XLua.Cast.Float
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: Any`1
FIELDS:
METHODS:
  System.Void .ctor(System.Single i)
END_CLASS

CLASS: XLua.LuaDLL.lua_CSFunction
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr L)
  System.IAsyncResult BeginInvoke(System.IntPtr L, System.AsyncCallback callback, System.Object object)
  System.Int32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: XLua.LuaDLL.Lua
TYPE:  class
TOKEN: 0x20000DC
FIELDS:
  private   static  System.String                   LUADLL  // 0x0
  private   static  System.Int32                    s_mainThreadId  // 0x0
  public    static  System.Func<System.IntPtr,System.String>tryGetLuaStringFunc  // 0x8
  public    static  System.Action<System.IntPtr,System.IntPtr,System.Int32,System.String>refLuaStringFunc  // 0x10
  public    static  System.Int32                    LUAI_MAXSHORTLEN  // 0x0
METHODS:
  System.Void .cctor()
  System.IntPtr lua_tothread(System.IntPtr L, System.Int32 index)
  System.Int32 xlua_get_lib_version()
  System.Int32 lua_gc(System.IntPtr L, XLua.LuaGCOptions what, System.Int32 data)
  System.IntPtr lua_getupvalue(System.IntPtr L, System.Int32 funcindex, System.Int32 n)
  System.IntPtr lua_setupvalue(System.IntPtr L, System.Int32 funcindex, System.Int32 n)
  System.Int32 lua_pushthread(System.IntPtr L)
  System.Boolean lua_isfunction(System.IntPtr L, System.Int32 stackPos)
  System.Boolean lua_islightuserdata(System.IntPtr L, System.Int32 stackPos)
  System.Boolean lua_istable(System.IntPtr L, System.Int32 stackPos)
  System.Boolean lua_isthread(System.IntPtr L, System.Int32 stackPos)
  System.Int32 luaL_error(System.IntPtr L, System.String message)
  System.Int32 lua_setfenv(System.IntPtr L, System.Int32 stackPos)
  System.IntPtr luaL_newstate()
  System.Void lua_close(System.IntPtr L)
  System.Void luaopen_xlua(System.IntPtr L)
  System.Void luaL_openlibs(System.IntPtr L)
  System.UInt32 xlua_objlen(System.IntPtr L, System.Int32 stackPos)
  System.Void lua_createtable(System.IntPtr L, System.Int32 narr, System.Int32 nrec)
  System.Void lua_newtable(System.IntPtr L, System.Int32 arrayL, System.Int32 hashL)
  System.Int32 xlua_getglobal(System.IntPtr L, System.String name)
  System.Int32 xlua_setglobal(System.IntPtr L, System.String name)
  System.Void xlua_getloaders(System.IntPtr L)
  System.Void lua_settop(System.IntPtr L, System.Int32 newTop)
  System.Void lua_pop(System.IntPtr L, System.Int32 amount)
  System.Void lua_insert(System.IntPtr L, System.Int32 newTop)
  System.Void lua_remove(System.IntPtr L, System.Int32 index)
  System.Int32 lua_rawget(System.IntPtr L, System.Int32 index)
  System.Void lua_rawset(System.IntPtr L, System.Int32 index)
  System.Int32 lua_setmetatable(System.IntPtr L, System.Int32 objIndex)
  System.Int32 lua_rawequal(System.IntPtr L, System.Int32 index1, System.Int32 index2)
  System.Void lua_pushvalue(System.IntPtr L, System.Int32 index)
  System.Void lua_pushcclosure(System.IntPtr L, System.IntPtr fn, System.Int32 n)
  System.Void lua_replace(System.IntPtr L, System.Int32 index)
  System.Int32 lua_gettop(System.IntPtr L)
  XLua.LuaTypes lua_type(System.IntPtr L, System.Int32 index)
  System.Boolean lua_isnil(System.IntPtr L, System.Int32 index)
  System.Boolean lua_isnumber(System.IntPtr L, System.Int32 index)
  System.Boolean lua_isboolean(System.IntPtr L, System.Int32 index)
  System.Int32 luaL_ref(System.IntPtr L, System.Int32 registryIndex)
  System.Int32 luaL_ref(System.IntPtr L)
  System.Void xlua_rawgeti(System.IntPtr L, System.Int32 tableIndex, System.Int64 index)
  System.Void xlua_rawseti(System.IntPtr L, System.Int32 tableIndex, System.Int64 index)
  System.Void lua_getref(System.IntPtr L, System.Int32 reference)
  System.Int32 pcall_prepare(System.IntPtr L, System.Int32 error_func_ref, System.Int32 func_ref)
  System.Void luaL_unref(System.IntPtr L, System.Int32 registryIndex, System.Int32 reference)
  System.Void lua_unref(System.IntPtr L, System.Int32 reference)
  System.Boolean lua_isstring(System.IntPtr L, System.Int32 index)
  System.Boolean lua_isinteger(System.IntPtr L, System.Int32 index)
  System.Void lua_pushnil(System.IntPtr L)
  System.Void lua_pushstdcallcfunction(System.IntPtr L, XLua.LuaDLL.lua_CSFunction function, System.Int32 n)
  System.Int32 xlua_upvalueindex(System.Int32 n)
  System.Int32 lua_pcall(System.IntPtr L, System.Int32 nArgs, System.Int32 nResults, System.Int32 errfunc)
  System.Int32 _lua_pcall(System.IntPtr L, System.Int32 nArgs, System.Int32 nResults, System.Int32 errfunc)
  System.Double lua_tonumber(System.IntPtr L, System.Int32 index)
  System.Int32 xlua_tointeger(System.IntPtr L, System.Int32 index)
  System.UInt32 xlua_touint(System.IntPtr L, System.Int32 index)
  System.Boolean lua_toboolean(System.IntPtr L, System.Int32 index)
  System.IntPtr lua_topointer(System.IntPtr L, System.Int32 index)
  System.IntPtr lua_tolstring(System.IntPtr L, System.Int32 index, System.IntPtr& strLen)
  System.String lua_tostring_beyond(System.IntPtr L, System.Int32 index)
  System.String lua_tostring(System.IntPtr L, System.Int32 index, System.Boolean cache)
  System.IntPtr lua_atpanic(System.IntPtr L, XLua.LuaDLL.lua_CSFunction panicf)
  System.Void lua_pushnumber(System.IntPtr L, System.Double number)
  System.Void lua_pushboolean(System.IntPtr L, System.Boolean value)
  System.Void xlua_pushinteger(System.IntPtr L, System.Int32 value)
  System.Void xlua_pushuint(System.IntPtr L, System.UInt32 value)
  System.Void lua_pushstring(System.IntPtr L, System.String str)
  System.Void xlua_pushlstring(System.IntPtr L, System.Byte[] str, System.Int32 size)
  System.Void xlua_pushasciistring(System.IntPtr L, System.String str)
  System.Void lua_pushstring(System.IntPtr L, System.Byte[] str)
  System.Byte[] lua_tobytes(System.IntPtr L, System.Int32 index)
  System.Int32 luaL_newmetatable(System.IntPtr L, System.String meta)
  System.Int32 xlua_pgettable(System.IntPtr L, System.Int32 idx)
  System.Int32 xlua_psettable(System.IntPtr L, System.Int32 idx)
  System.Void luaL_getmetatable(System.IntPtr L, System.String meta)
  System.Int32 xluaL_loadbuffer(System.IntPtr L, System.Byte[] buff, System.Int32 size, System.String name)
  System.Int32 luaL_loadbuffer(System.IntPtr L, System.String buff, System.String name)
  System.Int32 xlua_tocsobj_safe(System.IntPtr L, System.Int32 obj)
  System.Int32 xlua_tocsobj_fast(System.IntPtr L, System.Int32 obj)
  System.Int32 lua_error(System.IntPtr L)
  System.Boolean lua_checkstack(System.IntPtr L, System.Int32 extra)
  System.Int32 lua_next(System.IntPtr L, System.Int32 index)
  System.Void lua_pushlightuserdata(System.IntPtr L, System.IntPtr udata)
  System.IntPtr xlua_tag()
  System.Void luaL_where(System.IntPtr L, System.Int32 level)
  System.Int32 xlua_tryget_cachedud(System.IntPtr L, System.Int32 key, System.Int32 cache_ref)
  System.Void xlua_pushcsobj(System.IntPtr L, System.Int32 key, System.Int32 meta_ref, System.Boolean need_cache, System.Int32 cache_ref)
  System.Int32 gen_obj_indexer(System.IntPtr L)
  System.Int32 gen_obj_newindexer(System.IntPtr L)
  System.Int32 gen_cls_indexer(System.IntPtr L)
  System.Int32 gen_cls_newindexer(System.IntPtr L)
  System.Int32 get_error_func_ref(System.IntPtr L)
  System.Int32 load_error_func(System.IntPtr L, System.Int32 Ref)
  System.Int32 luaopen_i64lib(System.IntPtr L)
  System.Int32 luaopen_socket_core(System.IntPtr L)
  System.Void lua_pushint64(System.IntPtr L, System.Int64 n)
  System.Void lua_pushuint64(System.IntPtr L, System.UInt64 n)
  System.Boolean lua_isint64(System.IntPtr L, System.Int32 idx)
  System.Boolean lua_isuint64(System.IntPtr L, System.Int32 idx)
  System.Int64 lua_toint64(System.IntPtr L, System.Int32 idx)
  System.UInt64 lua_touint64(System.IntPtr L, System.Int32 idx)
  System.Void xlua_push_csharp_function(System.IntPtr L, System.IntPtr fn, System.Int32 n)
  System.Int32 xlua_csharp_str_error(System.IntPtr L, System.String message)
  System.Int32 xlua_csharp_error(System.IntPtr L)
  System.Boolean xlua_pack_int8_t(System.IntPtr buff, System.Int32 offset, System.Byte field)
  System.Boolean xlua_unpack_int8_t(System.IntPtr buff, System.Int32 offset, System.Byte& field)
  System.Boolean xlua_pack_int16_t(System.IntPtr buff, System.Int32 offset, System.Int16 field)
  System.Boolean xlua_unpack_int16_t(System.IntPtr buff, System.Int32 offset, System.Int16& field)
  System.Boolean xlua_pack_int32_t(System.IntPtr buff, System.Int32 offset, System.Int32 field)
  System.Boolean xlua_unpack_int32_t(System.IntPtr buff, System.Int32 offset, System.Int32& field)
  System.Boolean xlua_pack_int64_t(System.IntPtr buff, System.Int32 offset, System.Int64 field)
  System.Boolean xlua_unpack_int64_t(System.IntPtr buff, System.Int32 offset, System.Int64& field)
  System.Boolean xlua_pack_float(System.IntPtr buff, System.Int32 offset, System.Single field)
  System.Boolean xlua_unpack_float(System.IntPtr buff, System.Int32 offset, System.Single& field)
  System.Boolean xlua_pack_double(System.IntPtr buff, System.Int32 offset, System.Double field)
  System.Boolean xlua_unpack_double(System.IntPtr buff, System.Int32 offset, System.Double& field)
  System.IntPtr xlua_pushstruct(System.IntPtr L, System.UInt32 size, System.Int32 meta_ref)
  System.Void xlua_pushcstable(System.IntPtr L, System.UInt32 field_count, System.Int32 meta_ref)
  System.IntPtr lua_touserdata(System.IntPtr L, System.Int32 idx)
  System.Int32 xlua_gettypeid(System.IntPtr L, System.Int32 idx)
  System.Int32 xlua_get_registry_index()
  System.Int32 xlua_pgettable_bypath(System.IntPtr L, System.Int32 idx, System.String path)
  System.Int32 xlua_psettable_bypath(System.IntPtr L, System.Int32 idx, System.String path)
  System.Boolean xlua_pack_float2(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2)
  System.Boolean xlua_unpack_float2(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2)
  System.Boolean xlua_pack_float3(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2, System.Single f3)
  System.Boolean xlua_unpack_float3(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2, System.Single& f3)
  System.Boolean xlua_pack_float4(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2, System.Single f3, System.Single f4)
  System.Boolean xlua_unpack_float4(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2, System.Single& f3, System.Single& f4)
  System.Boolean xlua_pack_float5(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2, System.Single f3, System.Single f4, System.Single f5)
  System.Boolean xlua_unpack_float5(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2, System.Single& f3, System.Single& f4, System.Single& f5)
  System.Boolean xlua_pack_float6(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2, System.Single f3, System.Single f4, System.Single f5, System.Single f6)
  System.Boolean xlua_unpack_float6(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2, System.Single& f3, System.Single& f4, System.Single& f5, System.Single& f6)
  System.Boolean xlua_pack_decimal(System.IntPtr buff, System.Int32 offset, System.Decimal& dec)
  System.Boolean xlua_unpack_decimal(System.IntPtr buff, System.Int32 offset, System.Byte& scale, System.Byte& sign, System.Int32& hi32, System.UInt64& lo64)
  System.Boolean xlua_is_eq_str(System.IntPtr L, System.Int32 index, System.String str)
  System.Boolean xlua_is_eq_str(System.IntPtr L, System.Int32 index, System.String str, System.Int32 str_len)
  System.IntPtr xlua_gl(System.IntPtr L)
  System.Int32 luaL_traceback(System.IntPtr L, System.IntPtr L1, System.String msg, System.Int32 level)
  System.Int32 lua_sethook(System.IntPtr L, XLua.LuaDLL.lua_Hook hook, System.Int32 mask, System.Int32 count)
  XLua.LuaDLL.lua_Hook lua_gethook(System.IntPtr L)
  System.Int32 lua_gethookmask(System.IntPtr L)
  System.Int32 lua_getglobal(System.IntPtr L, System.IntPtr charPtr)
  System.Int32 lua_pushlstring(System.IntPtr L, System.IntPtr charPtr, System.Int32 len)
  System.Int32 luaopen_HyperLua(System.IntPtr L)
  System.Void HyperLua_SetLogCallback(XLua.LuaDLL.Lua.HyperLuaLogCallbackDelegate logCallback)
  System.Int32 LoadHyperLua(System.IntPtr L)
  System.Void SetHyperLuaLogCallback(XLua.LuaDLL.Lua.HyperLuaLogCallbackDelegate logCallback)
  System.Int32 luaopen_LuaUtils(System.IntPtr L)
  System.Void LuaUtils_SetLogCallback(XLua.LuaDLL.Lua.LuaUtilsLogCallbackDelegate logCallback)
  System.Int32 LoadLuaUtils(System.IntPtr L)
  System.Void SetLuaUtilsLogCallback(XLua.LuaDLL.Lua.LuaUtilsLogCallbackDelegate logCallback)
  System.Int32 luaopen_rapidjson(System.IntPtr L)
  System.Int32 LoadRapidJson(System.IntPtr L)
  System.Int32 luaopen_pb(System.IntPtr L)
  System.Int32 LoadLuaProtobuf(System.IntPtr L)
  System.Void beyond_setDecryptionFunc(System.IntPtr L, System.IntPtr func)
END_CLASS

CLASS: XLua.LuaDLL.lua_Hook
TYPE:  class
TOKEN: 0x20000E0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr L, XLua.lua_debug& ar)
  System.IAsyncResult BeginInvoke(System.IntPtr L, XLua.lua_debug& ar, System.AsyncCallback callback, System.Object object)
  System.Int32 EndInvoke(XLua.lua_debug& ar, System.IAsyncResult result)
END_CLASS

CLASS: XLua.Reflection.LuaObjFieldGetterSetter
TYPE:  class
TOKEN: 0x20000BC
FIELDS:
METHODS:
  System.Boolean _CheckRuntimeType(System.IntPtr L, System.Object obj, System.Type type, System.Reflection.FieldInfo field)
  System.IntPtr _GetPtrFromObj(System.Object obj)
  System.IntPtr _GetPtrFromLuaStack(System.IntPtr L, XLua.ObjectTranslator translator, System.Int32 index, System.Boolean isUnmanagedType)
  XLua.LuaDLL.lua_CSFunction GetObjFieldGetterByPushInt32(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFloatFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjDoubleFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldGetterByPushInt64(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldGetterByPushBool(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldGetterByPushString(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldObjGetter(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldStructGetter(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldEnumGetter(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldStructGetter(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldObjSetter(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldStructSetter(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldSetterByGetInt32(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldSetterByGetInt64(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFloatFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjDoubleFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldBoolSetter(System.Type type, System.Reflection.FieldInfo field)
  XLua.LuaDLL.lua_CSFunction GetObjFieldEnumSetter(System.Type type, System.Reflection.FieldInfo field)
  System.Void .ctor()
END_CLASS

CLASS: XLua.Reflection.RuntimeEnumDic
TYPE:  class
TOKEN: 0x20000CF
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Int32,System.Object>>s_enumDic  // 0x0
METHODS:
  System.Object GetEnumByTypeAndValue(System.Type enumType, System.Int32 value)
  System.Void AddEnumValue(System.Type enumType, System.Object enumObj)
  System.Void .cctor()
END_CLASS

CLASS: XLua.TemplateEngine.TokenType
TYPE:  struct
TOKEN: 0x20000B6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  XLua.TemplateEngine.TokenType   Code  // 0x0
  public    static  XLua.TemplateEngine.TokenType   Eval  // 0x0
  public    static  XLua.TemplateEngine.TokenType   Text  // 0x0
METHODS:
END_CLASS

CLASS: XLua.TemplateEngine.Chunk
TYPE:  class
TOKEN: 0x20000B7
FIELDS:
  private           XLua.TemplateEngine.TokenType   <Type>k__BackingField  // 0x10
  private           System.String                   <Text>k__BackingField  // 0x18
METHODS:
  XLua.TemplateEngine.TokenType get_Type()
  System.Void set_Type(XLua.TemplateEngine.TokenType value)
  System.String get_Text()
  System.Void set_Text(System.String value)
  System.Void .ctor(XLua.TemplateEngine.TokenType type, System.String text)
END_CLASS

CLASS: XLua.TemplateEngine.TemplateFormatException
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.String message)
END_CLASS

CLASS: XLua.TemplateEngine.Parser
TYPE:  class
TOKEN: 0x20000B9
FIELDS:
  private   static  System.String                   <RegexString>k__BackingField  // 0x0
METHODS:
  System.String get_RegexString()
  System.Void set_RegexString(System.String value)
  System.Void .cctor()
  System.String EscapeString(System.String input)
  System.String GetRegexString()
  System.Collections.Generic.List<XLua.TemplateEngine.Chunk> Parse(System.String snippet)
  System.Void .ctor()
END_CLASS

CLASS: XLua.TemplateEngine.LuaTemplate
TYPE:  class
TOKEN: 0x20000BB
FIELDS:
  private   static  XLua.LuaDLL.lua_CSFunction      templateCompileFunction  // 0x0
  private   static  XLua.LuaDLL.lua_CSFunction      templateExecuteFunction  // 0x8
METHODS:
  System.String ComposeCode(System.Collections.Generic.List<XLua.TemplateEngine.Chunk> chunks)
  XLua.LuaFunction Compile(XLua.LuaEnv luaenv, System.String snippet)
  System.String Execute(XLua.LuaFunction compiledTemplate, XLua.LuaTable parameters)
  System.String Execute(XLua.LuaFunction compiledTemplate)
  System.Int32 Compile(System.IntPtr L)
  System.Int32 Execute(System.IntPtr L)
  System.Void OpenLib(System.IntPtr L)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

