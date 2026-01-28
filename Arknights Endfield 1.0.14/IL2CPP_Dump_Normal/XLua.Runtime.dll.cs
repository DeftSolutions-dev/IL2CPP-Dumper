// ========================================================
// Dumped by @desirepro
// Assembly: XLua.Runtime.dll
// Classes:  228
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000006
    public class LuaAsset : ScriptableObject
    {
        // Fields
        public static System.String LuaDecodeKey;        // 0x0
        public System.Boolean encode;        // 0x18
        public System.Byte[] data;        // 0x20

        // Methods
        private System.Byte[] GetDecodeBytes() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000046
    public class LuaGenericDelegateCall : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr L, System.Delegate delegate, XLua.ObjectTranslator objectTranslator, System.Collections.Generic.List<System.Type> castType) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.Delegate delegate, XLua.ObjectTranslator objectTranslator, System.Collections.Generic.List<System.Type> castType, System.AsyncCallback callback, System.Object object) { }
        private System.Int32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000059
    public class TryArrayGet : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Object obj, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Object obj, System.Int32 index, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200005A
    public class TryArraySet : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Object obj, System.Int32 array_idx, System.Int32 obj_idx) { }
        private System.IAsyncResult BeginInvoke(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Object obj, System.Int32 array_idx, System.Int32 obj_idx, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000063
    public struct GCAction
    {
        // Fields
        public System.Int32 Reference;        // 0x10
        public System.Boolean IsDelegate;        // 0x14

    }

    // TypeToken: 0x2000064
    public class CustomLoader : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Byte[] Invoke(System.String& filepath) { }
        private System.IAsyncResult BeginInvoke(System.String& filepath, System.AsyncCallback callback, System.Object object) { }
        private System.Byte[] EndInvoke(System.String& filepath, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007F
    public struct Slot
    {
        // Fields
        public System.Int32 next;        // 0x10
        public System.Object obj;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 next, System.Object obj) { }

    }

    // TypeToken: 0x2000087
    public struct LOGLEVEL
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static XLua.ObjectTranslator.LOGLEVEL NO;        // 0x0
        public static XLua.ObjectTranslator.LOGLEVEL INFO;        // 0x0
        public static XLua.ObjectTranslator.LOGLEVEL WARN;        // 0x0
        public static XLua.ObjectTranslator.LOGLEVEL ERROR;        // 0x0

    }

    // TypeToken: 0x2000088
    public struct EnumerableWrapper
    {
        // Fields
        public System.Int32 Index;        // 0x10
        public System.Collections.IList CurList;        // 0x18
        public System.Collections.IEnumerator Enumerator;        // 0x20
        public static System.Collections.Generic.Stack<XLua.ObjectTranslator.EnumerableWrapper> enumerableStack;        // 0x0

        // Methods
        private System.Int32 ListCsPairs(System.IntPtr L) { }
        private System.Int32 DicCsPairs(System.IntPtr L) { }
        private System.Int32 IEnumerableCsPairs(System.IntPtr L) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000089
    public struct FStructWrap`1
    {
        // Fields
        public T value;        // 0x0

        // Methods
        private System.IntPtr GetPtr() { }

    }

    // TypeToken: 0x200008A
    public struct CSharpStructInLua
    {
        // Fields
        public System.Int32 fake_id;        // 0x10
        public System.UInt32 len;        // 0x14
        public System.IntPtr ptr;        // 0x18

    }

    // TypeToken: 0x200008B
    public struct LuaCSFunctionPtr
    {
        // Fields
        public System.IntPtr ptr;        // 0x10
        public System.Object target;        // 0x18

    }

    // TypeToken: 0x200008C
    public class GetDelegatePointer`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.ValueTuple<System.IntPtr,T1> Invoke(System.Delegate d) { }
        private System.IAsyncResult BeginInvoke(System.Delegate d, System.AsyncCallback callback, System.Object object) { }
        private System.ValueTuple<System.IntPtr,T1> EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200008D
    public class PushCSObject : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.IntPtr L, System.Object obj) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.Object obj, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200008E
    public class GetCSObject : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Object Invoke(System.IntPtr L, System.Int32 idx) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.AsyncCallback callback, System.Object object) { }
        private System.Object EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200008F
    public class UpdateCSObject : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.IntPtr L, System.Int32 idx, System.Object obj) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.Object obj, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000090
    public class CheckFunc`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.IntPtr L, System.Int32 idx) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000091
    public class GetFunc`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.IntPtr L, System.Int32 idx, T& val) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, T& val, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(T& val, System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000A7
    public struct MethodKey
    {
        // Fields
        public System.String Name;        // 0x10
        public System.Boolean IsStatic;        // 0x18

    }

    // TypeToken: 0x20000DD
    public class HyperLuaLogCallbackDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.IntPtr L, System.Int32 level, System.String text) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 level, System.String text, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000DE
    public class LuaUtilsLogCallbackDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Int32 level, System.String text) { }
        private System.IAsyncResult BeginInvoke(System.Int32 level, System.String text, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000DF
    public class DecryptionFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.IntPtr Invoke(System.IntPtr input, System.Int32 size, System.Int32& outSize) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr input, System.Int32 size, System.Int32& outSize, System.AsyncCallback callback, System.Object object) { }
        private System.IntPtr EndInvoke(System.Int32& outSize, System.IAsyncResult result) { }

    }

namespace Beyond.Lua
{

    // TypeToken: 0x2000044
    public class LuaCypher
    {
        // Fields
        private static System.String KEY;        // 0x0
        private static readonly System.String[] KEYS;        // 0x0
        private static System.String INITIAL_ASSETS_ROOT_PATH;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker decryptionMaker;        // 0x8

        // Methods
        private System.String GetKey() { }
        private System.Void GetKey(System.Span<System.Byte> buffer, System.Int32& len) { }
        private System.Boolean SkipDecrypt(System.String luaString) { }
        private System.String DecryptLuaString(System.String encryptLua) { }
        private System.Byte[] DecryptLua(System.String encryptLua) { }
        private System.IntPtr DecryptionFunc(System.IntPtr input, System.Int32 size, System.Int32& outSize) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000045
    public class LuaGenericDelegateCaller
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall> s_callerDic;        // 0x0

        // Methods
        private Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall GetCaller(System.String delegateTypeName) { }
        private System.Void AddCaller(System.String delegateTypeName, Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall caller) { }
        private System.Int32 OverloadMethodCall(System.IntPtr L, XLua.ObjectTranslator objectTranslator, XLua.IOverloadMethodWrap[] overload) { }
        private System.Int32 DefaultValueMethodCall(System.IntPtr L, XLua.ObjectTranslator objectTranslator, XLua.IOverloadMethodWrap[] defaultValues) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace Beyond.Reflection
{

    // TypeToken: 0x2000008
    public class GenericDelegateCaller
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.String,System.Type> s_customDelegateTypeDic;        // 0x0

        // Methods
        private System.Type GetCustomDelegateType(System.String delegateName) { }
        private System.Void AddCustomDelegateType(System.String delegateName, System.Type type) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000009
    public class MethodParamItem
    {
        // Fields
        public System.Type type;        // 0x10
        public System.Boolean isRef;        // 0x18
        public System.Boolean isOut;        // 0x19
        public System.Object defaultValue;        // 0x20
        public System.Boolean hasDefaultValue;        // 0x28
        public System.String name;        // 0x30
        public System.Type realType;        // 0x38

        // Methods
        private System.Collections.Generic.List<Beyond.Reflection.MethodParamItem> GetMethodParamList(System.Reflection.MethodInfo method, System.Boolean needLua, System.Boolean needEnum) { }
        private System.String GetMethodSignatureString(System.Reflection.MethodInfo method, System.Boolean needLua, System.Boolean keepType, System.Boolean needEnum) { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.Reflection.StructSizeGen
{

    // TypeToken: 0x200000A
    public struct FStructSize0
    {
    }

    // TypeToken: 0x200000B
    public struct FStructSize1
    {
        // Fields
        public System.Byte b0;        // 0x10

    }

    // TypeToken: 0x200000C
    public struct FStructSize2
    {
        // Fields
        public System.Int16 s0;        // 0x10

    }

    // TypeToken: 0x200000D
    public struct FStructSize3
    {
        // Fields
        public System.Int16 s0;        // 0x10
        public System.Byte b0;        // 0x12

    }

    // TypeToken: 0x200000E
    public struct FStructSize4
    {
        // Fields
        public System.Int32 i0;        // 0x10

    }

    // TypeToken: 0x200000F
    public struct FStructSize5
    {
        // Fields
        public System.Int32 i0;        // 0x10
        public System.Byte b0;        // 0x14

    }

    // TypeToken: 0x2000010
    public struct FStructSize8
    {
        // Fields
        public System.Int64 l0;        // 0x10

    }

    // TypeToken: 0x2000011
    public struct FStructSize12
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int32 i0;        // 0x18

    }

    // TypeToken: 0x2000012
    public struct FStructSize16
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18

    }

    // TypeToken: 0x2000013
    public struct FStructSize18
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int16 s0;        // 0x20

    }

    // TypeToken: 0x2000014
    public struct FStructSize20
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int32 i0;        // 0x20

    }

    // TypeToken: 0x2000015
    public struct FStructSize24
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20

    }

    // TypeToken: 0x2000016
    public struct FStructSize28
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int32 i0;        // 0x28

    }

    // TypeToken: 0x2000017
    public struct FStructSize32
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28

    }

    // TypeToken: 0x2000018
    public struct FStructSize34
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int16 s0;        // 0x30

    }

    // TypeToken: 0x2000019
    public struct FStructSize36
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int32 i0;        // 0x30

    }

    // TypeToken: 0x200001A
    public struct FStructSize40
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30

    }

    // TypeToken: 0x200001B
    public struct FStructSize44
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int32 i0;        // 0x38

    }

    // TypeToken: 0x200001C
    public struct FStructSize48
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38

    }

    // TypeToken: 0x200001D
    public struct FStructSize52
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int32 i0;        // 0x40

    }

    // TypeToken: 0x200001E
    public struct FStructSize56
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40

    }

    // TypeToken: 0x200001F
    public struct FStructSize60
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int32 i0;        // 0x48

    }

    // TypeToken: 0x2000020
    public struct FStructSize64
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48

    }

    // TypeToken: 0x2000021
    public struct FStructSize68
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int32 i0;        // 0x50

    }

    // TypeToken: 0x2000022
    public struct FStructSize72
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50

    }

    // TypeToken: 0x2000023
    public struct FStructSize76
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int32 i0;        // 0x58

    }

    // TypeToken: 0x2000024
    public struct FStructSize80
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58

    }

    // TypeToken: 0x2000025
    public struct FStructSize84
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int32 i0;        // 0x60

    }

    // TypeToken: 0x2000026
    public struct FStructSize88
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60

    }

    // TypeToken: 0x2000027
    public struct FStructSize92
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int32 i0;        // 0x68

    }

    // TypeToken: 0x2000028
    public struct FStructSize96
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68

    }

    // TypeToken: 0x2000029
    public struct FStructSize104
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70

    }

    // TypeToken: 0x200002A
    public struct FStructSize108
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int32 i0;        // 0x78

    }

    // TypeToken: 0x200002B
    public struct FStructSize112
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78

    }

    // TypeToken: 0x200002C
    public struct FStructSize120
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80

    }

    // TypeToken: 0x200002D
    public struct FStructSize124
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int32 i0;        // 0x88

    }

    // TypeToken: 0x200002E
    public struct FStructSize128
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88

    }

    // TypeToken: 0x200002F
    public struct FStructSize136
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90

    }

    // TypeToken: 0x2000030
    public struct FStructSize140
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int32 i0;        // 0x98

    }

    // TypeToken: 0x2000031
    public struct FStructSize144
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98

    }

    // TypeToken: 0x2000032
    public struct FStructSize148
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int32 i0;        // 0xA0

    }

    // TypeToken: 0x2000033
    public struct FStructSize152
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0

    }

    // TypeToken: 0x2000034
    public struct FStructSize160
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8

    }

    // TypeToken: 0x2000035
    public struct FStructSize168
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0

    }

    // TypeToken: 0x2000036
    public struct FStructSize176
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8

    }

    // TypeToken: 0x2000037
    public struct FStructSize180
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int32 i0;        // 0xC0

    }

    // TypeToken: 0x2000038
    public struct FStructSize184
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0

    }

    // TypeToken: 0x2000039
    public struct FStructSize192
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8

    }

    // TypeToken: 0x200003A
    public struct FStructSize196
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int32 i0;        // 0xD0

    }

    // TypeToken: 0x200003B
    public struct FStructSize200
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int64 l24;        // 0xD0

    }

    // TypeToken: 0x200003C
    public struct FStructSize208
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int64 l24;        // 0xD0
        public System.Int64 l25;        // 0xD8

    }

    // TypeToken: 0x200003D
    public struct FStructSize216
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int64 l24;        // 0xD0
        public System.Int64 l25;        // 0xD8
        public System.Int64 l26;        // 0xE0

    }

    // TypeToken: 0x200003E
    public struct FStructSize220
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int64 l24;        // 0xD0
        public System.Int64 l25;        // 0xD8
        public System.Int64 l26;        // 0xE0
        public System.Int32 i0;        // 0xE8

    }

    // TypeToken: 0x200003F
    public struct FStructSize224
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int64 l24;        // 0xD0
        public System.Int64 l25;        // 0xD8
        public System.Int64 l26;        // 0xE0
        public System.Int64 l27;        // 0xE8

    }

    // TypeToken: 0x2000040
    public struct FStructSize232
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int64 l24;        // 0xD0
        public System.Int64 l25;        // 0xD8
        public System.Int64 l26;        // 0xE0
        public System.Int64 l27;        // 0xE8
        public System.Int64 l28;        // 0xF0

    }

    // TypeToken: 0x2000041
    public struct FStructSize240
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int64 l24;        // 0xD0
        public System.Int64 l25;        // 0xD8
        public System.Int64 l26;        // 0xE0
        public System.Int64 l27;        // 0xE8
        public System.Int64 l28;        // 0xF0
        public System.Int64 l29;        // 0xF8

    }

    // TypeToken: 0x2000042
    public struct FStructSize248
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int64 l24;        // 0xD0
        public System.Int64 l25;        // 0xD8
        public System.Int64 l26;        // 0xE0
        public System.Int64 l27;        // 0xE8
        public System.Int64 l28;        // 0xF0
        public System.Int64 l29;        // 0xF8
        public System.Int64 l30;        // 0x100

    }

    // TypeToken: 0x2000043
    public struct FStructSize256
    {
        // Fields
        public System.Int64 l0;        // 0x10
        public System.Int64 l1;        // 0x18
        public System.Int64 l2;        // 0x20
        public System.Int64 l3;        // 0x28
        public System.Int64 l4;        // 0x30
        public System.Int64 l5;        // 0x38
        public System.Int64 l6;        // 0x40
        public System.Int64 l7;        // 0x48
        public System.Int64 l8;        // 0x50
        public System.Int64 l9;        // 0x58
        public System.Int64 l10;        // 0x60
        public System.Int64 l11;        // 0x68
        public System.Int64 l12;        // 0x70
        public System.Int64 l13;        // 0x78
        public System.Int64 l14;        // 0x80
        public System.Int64 l15;        // 0x88
        public System.Int64 l16;        // 0x90
        public System.Int64 l17;        // 0x98
        public System.Int64 l18;        // 0xA0
        public System.Int64 l19;        // 0xA8
        public System.Int64 l20;        // 0xB0
        public System.Int64 l21;        // 0xB8
        public System.Int64 l22;        // 0xC0
        public System.Int64 l23;        // 0xC8
        public System.Int64 l24;        // 0xD0
        public System.Int64 l25;        // 0xD8
        public System.Int64 l26;        // 0xE0
        public System.Int64 l27;        // 0xE8
        public System.Int64 l28;        // 0xF0
        public System.Int64 l29;        // 0xF8
        public System.Int64 l30;        // 0x100
        public System.Int64 l31;        // 0x108

    }

}

namespace IFix
{

    // TypeToken: 0x20000E1
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Type __Gen_Wrap_0(System.Object P0) { }
        private System.Void __Gen_Wrap_1(System.Object P0, System.Object P1) { }
        private System.Collections.Generic.List<Beyond.Reflection.MethodParamItem> __Gen_Wrap_2(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        private System.String __Gen_Wrap_3(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3) { }
        private System.String __Gen_Wrap_4() { }
        private System.Void __Gen_Wrap_5(System.Span<System.Byte> P0, System.Int32& P1) { }
        private System.Boolean __Gen_Wrap_6(System.Object P0) { }
        private System.Byte[] __Gen_Wrap_7(System.Object P0) { }
        private System.String __Gen_Wrap_8(System.Object P0) { }
        private System.IntPtr __Gen_Wrap_9(System.IntPtr P0, System.Int32 P1, System.Int32& P2) { }
        private Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall __Gen_Wrap_10(System.Object P0) { }
        private System.Int32 __Gen_Wrap_11(System.IntPtr P0, System.Object P1, System.Object P2) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E2
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x20000E3
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

    // TypeToken: 0x20000E4
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Reflection-GenericDelegateCaller-GetCustomDelegateType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-GenericDelegateCaller-AddCustomDelegateType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-MethodParamItem-GetMethodParamList0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-MethodParamItem-GetMethodSignatureString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCypher-GetKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCypher-GetKey1;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCypher-SkipDecrypt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCypher-DecryptLua0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCypher-DecryptLuaString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCypher-DecryptionFunc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaGenericDelegateCaller-GetCaller0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaGenericDelegateCaller-AddCaller0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaGenericDelegateCaller-OverloadMethodCall0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaGenericDelegateCaller-DefaultValueMethodCall0;        // 0x0

    }

}

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000004
    public class EmbeddedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Security
{

    // TypeToken: 0x2000007
    public class XXTEA
    {
        // Fields
        private static readonly System.Text.UTF8Encoding utf8;        // 0x0
        private static System.UInt32 delta;        // 0x0

        // Methods
        private System.UInt32 MX(System.UInt32 sum, System.UInt32 y, System.UInt32 z, System.Int32 p, System.UInt32 e, System.UInt32[] k) { }
        private System.Void .ctor() { }
        private System.Byte[] Encrypt(System.Byte[] data, System.Byte[] key) { }
        private System.Byte[] Encrypt(System.String data, System.Byte[] key) { }
        private System.Byte[] Encrypt(System.Byte[] data, System.String key) { }
        private System.Byte[] Encrypt(System.String data, System.String key) { }
        private System.String EncryptToBase64String(System.Byte[] data, System.Byte[] key) { }
        private System.String EncryptToBase64String(System.String data, System.Byte[] key) { }
        private System.String EncryptToBase64String(System.Byte[] data, System.String key) { }
        private System.String EncryptToBase64String(System.String data, System.String key) { }
        private System.Byte[] Decrypt(System.Byte[] data, System.Byte[] key) { }
        private System.Int32 _Decrypt(System.Span<System.Byte> data, System.Span<System.Byte> key, System.Span<System.Byte> result) { }
        private System.Byte[] Decrypt(System.Byte[] data, System.String key) { }
        private System.Int32 Decrypt(System.Span<System.Byte> data, System.Span<System.Byte> key, System.Span<System.Byte> result) { }
        private System.Byte[] DecryptBase64String(System.String data, System.Byte[] key) { }
        private System.Byte[] DecryptBase64String(System.String data, System.String key) { }
        private System.String DecryptToString(System.Byte[] data, System.Byte[] key) { }
        private System.String DecryptToString(System.Byte[] data, System.String key) { }
        private System.String DecryptBase64StringToString(System.String data, System.Byte[] key) { }
        private System.String DecryptBase64StringToString(System.String data, System.String key) { }
        private System.UInt32[] Encrypt(System.UInt32[] v, System.UInt32[] k) { }
        private System.UInt32[] Decrypt(System.UInt32[] v, System.UInt32[] k) { }
        private System.Void DecryptInPlace(System.Span<System.UInt32> v, System.Span<System.UInt32> k) { }
        private System.UInt32 MxForSpan(System.UInt32 sum, System.UInt32 y, System.UInt32 z, System.Int32 p, System.UInt32 e, System.Span<System.UInt32> k) { }
        private System.Byte[] FixKey(System.Byte[] key) { }
        private System.Void FixKey(System.Span<System.Byte> key, System.Span<System.Byte> fixedkey) { }
        private System.UInt32[] ToUInt32Array(System.Byte[] data, System.Boolean includeLength) { }
        private System.Void ToUInt32Array(System.Span<System.Byte> data, System.Boolean includeLength, System.Span<System.UInt32> result) { }
        private System.Byte[] ToByteArray(System.UInt32[] data, System.Boolean includeLength) { }
        private System.Void ToByteSpanFromUInt32(System.Span<System.UInt32> data, System.Boolean includeLength, System.Span<System.Byte> result, System.Int32& len) { }
        private System.Void .cctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000005
    public class IsUnmanagedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace XLua
{

    // TypeToken: 0x2000047
    public class CopyByValue
    {
        // Fields
        public static XLua.CopyByValue Instance;        // 0x0

        // Methods
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Byte field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Byte& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.SByte field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.SByte& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Int16 field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Int16& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.UInt16 field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.UInt16& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Int32 field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Int32& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.UInt32 field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.UInt32& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Int64 field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Int64& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.UInt64 field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.UInt64& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Single field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Single& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Double field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Double& field) { }
        private System.Boolean Pack(System.IntPtr buff, System.Int32 offset, System.Decimal field) { }
        private System.Boolean UnPack(System.IntPtr buff, System.Int32 offset, System.Decimal& field) { }
        private System.Boolean IsStruct(System.Type type) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000048
    public class DelegateBridgeBase : LuaBase
    {
        // Fields
        private System.Type firstKey;        // 0x20
        private System.Delegate firstValue;        // 0x28
        private System.Collections.Generic.Dictionary<System.Type,System.Delegate> bindTo;        // 0x30
        public System.Int32 errorFuncRef;        // 0x38

        // Methods
        private System.Boolean get_IsDispose() { }
        private System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv) { }
        private System.Boolean TryGetDelegate(System.Type key, System.Delegate& value) { }
        private System.Void AddDelegate(System.Type key, System.Delegate value) { }
        private System.Delegate GetDelegateByType(System.Type type) { }

    }

    // TypeToken: 0x2000049
    public class HotfixDelegateBridge
    {
        // Methods
        private System.Boolean xlua_get_hotfix_flag(System.Int32 idx) { }
        private XLua.DelegateBridge Get(System.Int32 idx) { }
        private System.Void Set(System.Int32 idx, XLua.DelegateBridge val) { }

    }

    // TypeToken: 0x200004A
    public class DelegateBridge : DelegateBridgeBase
    {
        // Fields
        private static XLua.DelegateBridge[] DelegateBridgeList;        // 0x0
        public static System.Boolean Gen_Flag;        // 0x8
        public static System.Func<XLua.DelegateBridge,System.Type,System.Delegate> GetDelegateTypeDelegate;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv) { }
        private System.Void PCall(System.IntPtr L, System.Int32 nArgs, System.Int32 nResults, System.Int32 errFunc) { }
        private System.Delegate GetDelegateByType(System.Type type) { }
        private System.Void Action() { }
        private System.Void Action(T1 p1) { }
        private System.Void Action(T1 p1, T2 p2) { }
        private System.Void Action(T1 p1, T2 p2, T3 p3) { }
        private System.Void Action(T1 p1, T2 p2, T3 p3, T4 p4) { }
        private TResult Func() { }
        private TResult Func(T1 p1) { }
        private TResult Func(T1 p1, T2 p2) { }
        private TResult Func(T1 p1, T2 p2, T3 p3) { }
        private TResult Func(T1 p1, T2 p2, T3 p3, T4 p4) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004B
    public struct GenFlag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static XLua.GenFlag No;        // 0x0
        public static XLua.GenFlag GCOptimize;        // 0x0

    }

    // TypeToken: 0x200004C
    public class LuaCallCSharpAttribute : Attribute
    {
        // Fields
        private XLua.GenFlag flag;        // 0x10

        // Methods
        private XLua.GenFlag get_Flag() { }
        private System.Void .ctor(XLua.GenFlag flag) { }

    }

    // TypeToken: 0x200004D
    public class CSharpCallLuaAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public class BlackListAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public struct OptimizeFlag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static XLua.OptimizeFlag Default;        // 0x0
        public static XLua.OptimizeFlag PackAsTable;        // 0x0
        public static XLua.OptimizeFlag Custom;        // 0x0

    }

    // TypeToken: 0x2000050
    public class GCOptimizeAttribute : Attribute
    {
        // Fields
        private XLua.OptimizeFlag flag;        // 0x10

        // Methods
        private XLua.OptimizeFlag get_Flag() { }
        private System.Void .ctor(XLua.OptimizeFlag flag) { }

    }

    // TypeToken: 0x2000051
    public class ReflectionUseAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public class DoNotGenAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public class AdditionalPropertiesAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000054
    public struct HotfixFlag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static XLua.HotfixFlag Stateless;        // 0x0
        public static XLua.HotfixFlag Stateful;        // 0x0
        public static XLua.HotfixFlag ValueTypeBoxing;        // 0x0
        public static XLua.HotfixFlag IgnoreProperty;        // 0x0
        public static XLua.HotfixFlag IgnoreNotPublic;        // 0x0
        public static XLua.HotfixFlag Inline;        // 0x0
        public static XLua.HotfixFlag IntKey;        // 0x0
        public static XLua.HotfixFlag AdaptByDelegate;        // 0x0
        public static XLua.HotfixFlag IgnoreCompilerGenerated;        // 0x0
        public static XLua.HotfixFlag NoBaseProxy;        // 0x0

    }

    // TypeToken: 0x2000055
    public class HotfixAttribute : Attribute
    {
        // Fields
        private XLua.HotfixFlag flag;        // 0x10

        // Methods
        private XLua.HotfixFlag get_Flag() { }
        private System.Void .ctor(XLua.HotfixFlag e) { }

    }

    // TypeToken: 0x2000056
    public class HotfixDelegateAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000057
    public class SysGenConfig
    {
        // Methods
        private System.Collections.Generic.List<System.Type> get_GCOptimize() { }
        private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<System.String>> get_AdditionalProperties() { }

    }

    // TypeToken: 0x2000058
    public class InternalGlobals
    {
        // Fields
        private static System.Byte[] strBuff;        // 0x0
        public static XLua.InternalGlobals.TryArrayGet genTryArrayGetPtr;        // 0x8
        public static XLua.InternalGlobals.TryArraySet genTryArraySetPtr;        // 0x10
        private static System.Int32 LUA_REGISTRYINDEX;        // 0x18
        private static System.Collections.Generic.Dictionary<System.String,System.String> supportOp;        // 0x20
        public static System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> extensionMethodMap;        // 0x28
        private static XLua.LuaDLL.lua_CSFunction LazyReflectionWrap;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005B
    public class LuaBase, IDisposable
    {
        // Fields
        public System.Boolean disposed;        // 0x10
        public readonly System.Int32 luaReference;        // 0x14
        public readonly XLua.LuaEnv luaEnv;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposeManagedResources) { }
        private System.Boolean Equals(System.Object o) { }
        private System.Int32 GetHashCode() { }
        private System.Void push(System.IntPtr L) { }

    }

    // TypeToken: 0x200005C
    public struct lua_debug
    {
        // Fields
        public System.Int32 eventCode;        // 0x10
        public System.IntPtr name;        // 0x18
        public System.IntPtr namewhat;        // 0x20
        public System.IntPtr what;        // 0x28
        public System.IntPtr source;        // 0x30
        public System.Int32 currentline;        // 0x38
        public System.Int32 linedefined;        // 0x3C

    }

    // TypeToken: 0x200005D
    public struct lua_state
    {
        // Fields
        public System.IntPtr ptr;        // 0x10
        public System.Byte byte1;        // 0x18
        public System.Byte byte2;        // 0x19
        public System.Byte status;        // 0x1A
        public System.Byte allowhook;        // 0x1B

    }

    // TypeToken: 0x200005E
    public class lua_Hook : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr L, XLua.lua_debug& ar) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, XLua.lua_debug& ar, System.AsyncCallback callback, System.Object object) { }
        private System.Int32 EndInvoke(XLua.lua_debug& ar, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200005F
    public class LuaDeadLoopCheck
    {
        // Fields
        private static System.Threading.Thread s_checkThread;        // 0x0
        private static System.Collections.Generic.Stack<System.Diagnostics.Stopwatch> s_costStack;        // 0x8
        private static System.Threading.SpinLock s_lockObj;        // 0x10
        private static System.Boolean s_isCheck;        // 0x14
        private static System.IntPtr L;        // 0x18
        private static UnityEngine.Pool.ObjectPool<System.Diagnostics.Stopwatch> s_stopwatchPool;        // 0x20
        private static System.Int32 s_allowHookOffset;        // 0x28

        // Methods
        private System.Void EnableCheck(System.IntPtr L) { }
        private System.Int32 LuaHook(System.IntPtr L, XLua.lua_debug& ar) { }
        private System.Void DisableCheck(System.IntPtr L) { }
        private System.Void PushTime() { }
        private System.Void PopTime() { }
        private System.Void CheckDeadLoop() { }

    }

    // TypeToken: 0x2000060
    public interface ILoadLuaProxy
    {
        // Methods
        private System.Byte[] LoadLua(System.String name) { }

    }

    // TypeToken: 0x2000061
    public class LoadLuaProxyModule
    {
        // Fields
        private static XLua.ILoadLuaProxy s_loadLuaProxy;        // 0x0

        // Methods
        private System.Void RegisterProxy(XLua.ILoadLuaProxy loadLuaProxy) { }
        private XLua.ILoadLuaProxy GetLoadLuaProxy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class LuaEnv, IDisposable
    {
        // Fields
        public static System.String CSHARP_NAMESPACE;        // 0x0
        public static System.String MAIN_SHREAD;        // 0x0
        public System.IntPtr rawL;        // 0x10
        private XLua.LuaTable _G;        // 0x18
        public XLua.ObjectTranslator translator;        // 0x20
        public System.Int32 errorFuncRef;        // 0x28
        private static System.Int32 LIB_VERSION_EXPECT;        // 0x0
        private static System.Collections.Generic.List<System.Action<XLua.LuaEnv,XLua.ObjectTranslator>> initers;        // 0x0
        private System.Collections.Generic.Dictionary<System.Int64,System.String> _stringCache;        // 0x30
        private System.Int64 _stringCacheMemory;        // 0x38
        private readonly System.Int64 _freeSize;        // 0x40
        private System.Int32 last_check_point;        // 0x48
        private System.Int32 max_check_per_tick;        // 0x4C
        private System.Func<System.Object,System.Boolean> object_valid_checker;        // 0x50
        private System.Boolean disposed;        // 0x58
        private System.Collections.Generic.Queue<XLua.LuaEnv.GCAction> refQueue;        // 0x60
        private System.Collections.Generic.List<XLua.LuaEnv.CustomLoader> customLoaders;        // 0x68
        private System.Collections.Generic.Dictionary<System.String,XLua.LuaDLL.lua_CSFunction> buildin_initer;        // 0x70

        // Methods
        private System.IntPtr get_L() { }
        private System.Void .ctor() { }
        private System.Void AddIniter(System.Action<XLua.LuaEnv,XLua.ObjectTranslator> initer) { }
        private XLua.LuaTable get_Global() { }
        private T LoadString(System.Byte[] chunk, System.String chunkName, XLua.LuaTable env) { }
        private T LoadString(System.String chunk, System.String chunkName, XLua.LuaTable env) { }
        private XLua.LuaFunction LoadString(System.String chunk, System.String chunkName, XLua.LuaTable env) { }
        private System.Object[] DoString(System.Byte[] chunk, System.String chunkName, XLua.LuaTable env) { }
        private System.Object[] DoString(System.String chunk, System.String chunkName, XLua.LuaTable env) { }
        private System.Object[] DoFile(System.String luaFile, System.String chunkName, XLua.LuaTable env) { }
        private System.Object[] DoFile(System.String luaFile, XLua.LuaTable env) { }
        private System.Object[] CallGlobalFunction(System.String funcName) { }
        private System.Object[] CallGlobalFunction(System.String funcName, T0 param0) { }
        private System.Void SetGlobalTable(K key, V value) { }
        private V GetGlobalTable(K key) { }
        private System.Void InitCacheString() { }
        private System.String TryGetLuaString(System.IntPtr p) { }
        private System.Void RefString(System.IntPtr L, System.IntPtr strPoint, System.Int32 index, System.String ss) { }
        private System.Void ReleaseStringCache(System.Boolean dispose) { }
        private System.Void AutoFreeStringCache() { }
        private System.Void AddSearcher(XLua.LuaDLL.lua_CSFunction searcher, System.Int32 index) { }
        private System.Void Alias(System.Type type, System.String alias) { }
        private System.Boolean ObjectValidCheck(System.Object obj) { }
        private System.Void ClearAllUserdata() { }
        private System.Void CleanTick() { }
        private System.Void GC() { }
        private XLua.LuaTable NewTable() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean dispose) { }
        private System.Void ThrowExceptionFromError(System.Int32 oldTop) { }
        private System.Void equeueGCAction(XLua.LuaEnv.GCAction action) { }
        private System.Void AddLoader(XLua.LuaEnv.CustomLoader loader) { }
        private System.Void AddBuildin(System.String name, XLua.LuaDLL.lua_CSFunction initer) { }
        private System.Int32 get_GcPause() { }
        private System.Void set_GcPause(System.Int32 value) { }
        private System.Int32 get_GcStepmul() { }
        private System.Void set_GcStepmul(System.Int32 value) { }
        private System.Void FullGc() { }
        private System.Void StopGc() { }
        private System.Void RestartGc() { }
        private System.Boolean GcStep(System.Int32 data) { }
        private System.Int32 get_Memroy() { }

    }

    // TypeToken: 0x2000065
    public class LuaException : Exception
    {
        // Methods
        private System.Void .ctor(System.String message) { }

    }

    // TypeToken: 0x2000066
    public class LuaFunction : LuaBase
    {
        // Methods
        private System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv) { }
        private System.Void Action(T a) { }
        private TResult Func(T a) { }
        private System.Void Action(T1 a1, T2 a2) { }
        private TResult Func(T1 a1, T2 a2) { }
        private System.Object[] Call(System.Object[] args, System.Type[] returnTypes) { }
        private System.Object[] Call(System.Object[] args) { }
        private T Cast() { }
        private System.Void SetEnv(XLua.LuaTable env) { }
        private System.Void push(System.IntPtr L) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000067
    public class LuaTable : LuaBase
    {
        // Methods
        private System.Void .ctor(System.Int32 reference, XLua.LuaEnv luaenv) { }
        private System.Void Get(TKey key, TValue& value) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Void Set(TKey key, TValue value) { }
        private T GetInPath(System.String path) { }
        private System.Void SetInPath(System.String path, T val) { }
        private System.Object get_Item(System.String field) { }
        private System.Void set_Item(System.String field, System.Object value) { }
        private System.Object get_Item(System.Object field) { }
        private System.Void set_Item(System.Object field, System.Object value) { }
        private System.Void ForEach(System.Action<TKey,TValue> action) { }
        private System.Int32 get_Length() { }
        private System.Collections.IEnumerable GetKeys() { }
        private System.Collections.Generic.IEnumerable<T> GetKeys() { }
        private T Get(System.Object key) { }
        private TValue Get(TKey key) { }
        private TValue Get(System.String key) { }
        private System.Void SetMetaTable(XLua.LuaTable metaTable) { }
        private T Cast() { }
        private System.Void push(System.IntPtr L) { }
        private System.String ToString() { }
        private XLua.ObjectTranslator GetTranslator() { }

    }

    // TypeToken: 0x200006A
    public interface IOverloadMethodWrap
    {
        // Methods
        private System.Boolean get_InitedForDelegateCall() { }
        private System.Boolean get_HasDefalutValue() { }
        private System.Int32 Call(System.IntPtr L, XLua.ObjectTranslator translator) { }
        private System.Boolean Check(System.IntPtr L, System.Boolean haveOverload) { }

    }

    // TypeToken: 0x200006B
    public class OverloadMethodWrapBase
    {
        // Fields
        protected XLua.ObjectTranslator translator;        // 0x10
        protected System.Reflection.MethodBase method;        // 0x18

        // Methods
        private XLua.IOverloadMethodWrap CreateMethodWrap(XLua.ObjectTranslator translator, System.Reflection.MethodBase method, System.Type target) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006C
    public class OverloadMethodWrapForDelegate : OverloadMethodWrapBase, IOverloadMethodWrap
    {
        // Fields
        private System.Collections.Generic.List<System.Type> castTypes;        // 0x20
        private System.Delegate delegate;        // 0x28
        private Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall caller;        // 0x30
        private System.Int32 <OptionParamCount>k__BackingField;        // 0x38
        private System.Object[] <DefalutValue>k__BackingField;        // 0x40
        private System.Boolean <HasDefalutValue>k__BackingField;        // 0x48
        private System.Boolean[] <OutParamFlags>k__BackingField;        // 0x50

        // Methods
        private System.Boolean get_InitedForDelegateCall() { }
        private System.Collections.Generic.List<System.Type> get_CastTypes() { }
        private System.Int32 get_OptionParamCount() { }
        private System.Void set_OptionParamCount(System.Int32 value) { }
        private System.Object[] get_DefalutValue() { }
        private System.Void set_DefalutValue(System.Object[] value) { }
        private System.Boolean get_HasDefalutValue() { }
        private System.Void set_HasDefalutValue(System.Boolean value) { }
        private System.Boolean[] get_OutParamFlags() { }
        private System.Void set_OutParamFlags(System.Boolean[] value) { }
        private System.Void .ctor(System.Reflection.MethodInfo method) { }
        private XLua.OverloadMethodWrapForDelegate TryGetWrapForDelegate(System.Reflection.MethodInfo method) { }
        private System.Void InitForDefaultValue() { }
        private System.Int32 Call(System.IntPtr L, XLua.ObjectTranslator translator) { }
        private System.Boolean Check(System.IntPtr L, System.Boolean haveOverload) { }

    }

    // TypeToken: 0x200006D
    public class OverloadMethodWrapForReflection : OverloadMethodWrapBase, IOverloadMethodWrap
    {
        // Fields
        private XLua.ObjectCheck[] checkArray;        // 0x20
        private XLua.ObjectCast[] castArray;        // 0x28
        private System.Type targetType;        // 0x30
        private System.Int32[] inPosArray;        // 0x38
        private System.Int32[] outPosArray;        // 0x40
        private System.Boolean[] isOptionalArray;        // 0x48
        private System.Object[] defaultValueArray;        // 0x50
        private System.Boolean isVoid;        // 0x58
        private System.Int32 luaStackPosStart;        // 0x5C
        private System.Boolean targetNeeded;        // 0x60
        private System.Object[] args;        // 0x68
        private System.Int32[] refPos;        // 0x70
        private System.Type paramsType;        // 0x78

        // Methods
        private System.Void .ctor(System.Type target, System.Reflection.MethodBase methodInfo) { }
        private System.Void Init(XLua.ObjectCheckers objCheckers, XLua.ObjectCasters objCasters) { }
        private System.Int32 Call(System.IntPtr L, XLua.ObjectTranslator translator) { }
        private System.Boolean get_InitedForDelegateCall() { }
        private System.Boolean get_HasDefalutValue() { }
        private System.Boolean Check(System.IntPtr L, System.Boolean haveOverload) { }
        private System.Boolean Check(System.IntPtr L) { }
        private System.Boolean CheckForNoOverride(System.IntPtr L) { }

    }

    // TypeToken: 0x200006E
    public class OverloadMethodWrap
    {
        // Fields
        private XLua.ObjectTranslator translator;        // 0x10
        private System.Type targetType;        // 0x18
        private System.Reflection.MethodBase method;        // 0x20
        private XLua.ObjectCheck[] checkArray;        // 0x28
        private XLua.ObjectCast[] castArray;        // 0x30
        private System.Collections.Generic.List<System.Type> castTypes;        // 0x38
        private System.Delegate delegate;        // 0x40
        private Beyond.Lua.LuaGenericDelegateCaller.LuaGenericDelegateCall caller;        // 0x48
        private System.Int32[] inPosArray;        // 0x50
        private System.Int32[] outPosArray;        // 0x58
        private System.Boolean[] isOptionalArray;        // 0x60
        private System.Object[] defaultValueArray;        // 0x68
        private System.Boolean isVoid;        // 0x70
        private System.Int32 luaStackPosStart;        // 0x74
        private System.Boolean targetNeeded;        // 0x78
        private System.Object[] args;        // 0x80
        private System.Int32[] refPos;        // 0x88
        private System.Type paramsType;        // 0x90
        private System.Int32 <OptionParamCount>k__BackingField;        // 0x98
        private System.Object[] <DefalutValue>k__BackingField;        // 0xA0
        private System.Boolean <IsInited>k__BackingField;        // 0xA8
        private System.Boolean <HasDefalutValue>k__BackingField;        // 0xA9

        // Methods
        private System.Boolean get_InitedForDelegateCall() { }
        private System.Reflection.MethodBase get_Method() { }
        private System.Collections.Generic.List<System.Type> get_CastTypes() { }
        private System.Int32 get_OptionParamCount() { }
        private System.Void set_OptionParamCount(System.Int32 value) { }
        private System.Object[] get_DefalutValue() { }
        private System.Void set_DefalutValue(System.Object[] value) { }
        private System.Void set_IsInited(System.Boolean value) { }
        private System.Boolean get_IsInited() { }
        private System.Boolean get_HasDefalutValue() { }
        private System.Void set_HasDefalutValue(System.Boolean value) { }
        private System.Void .ctor(XLua.ObjectTranslator translator, System.Type targetType, System.Reflection.MethodBase method) { }
        private System.Void Init(XLua.ObjectCheckers objCheckers, XLua.ObjectCasters objCasters) { }
        private System.Void InitForDefaultValue() { }
        private System.Void InitForDelegateCallMethod() { }
        private System.Int32 Call(System.IntPtr L) { }
        private System.Int32 CallForDelegate(System.IntPtr L, XLua.ObjectTranslator translator) { }

    }

    // TypeToken: 0x200006F
    public class MethodWrap
    {
        // Fields
        private System.String methodName;        // 0x10
        private XLua.IOverloadMethodWrap[] overloads;        // 0x18
        private System.Type targetType;        // 0x20
        private System.Reflection.MethodBase[] allMethods;        // 0x28
        private System.Boolean forceCheck;        // 0x30
        private System.Boolean initedForDelegateCall;        // 0x31
        private System.Boolean haveDefault;        // 0x32

        // Methods
        private System.Void .ctor(System.String methodName, System.Collections.Generic.List<System.Reflection.MethodBase> overloads, System.Type targetType, System.Boolean forceCheck) { }
        private System.Void _InitForDelegateCall() { }
        private System.Int32 Call(System.IntPtr L) { }

    }

    // TypeToken: 0x2000070
    public class MethodWrapsCache
    {
        // Fields
        public static System.Collections.Generic.Dictionary<System.Type,XLua.LuaDLL.lua_CSFunction> CodeGenConstructorMap;        // 0x0
        private XLua.ObjectTranslator translator;        // 0x10
        private XLua.ObjectCheckers objCheckers;        // 0x18
        private XLua.ObjectCasters objCasters;        // 0x20
        private System.Collections.Generic.Dictionary<System.Type,XLua.LuaDLL.lua_CSFunction> constructorCache;        // 0x28
        private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,XLua.LuaDLL.lua_CSFunction>> methodsCache;        // 0x30
        private System.Collections.Generic.Dictionary<System.Type,XLua.LuaDLL.lua_CSFunction> delegateCache;        // 0x38

        // Methods
        private System.Void AddCodeGenConstructor(System.Type type, XLua.LuaDLL.lua_CSFunction lua_CSFunction) { }
        private System.Void ClearCodeGenConstructorMap() { }
        private System.Void .cctor() { }
        private System.Void .ctor(XLua.ObjectTranslator translator, XLua.ObjectCheckers objCheckers, XLua.ObjectCasters objCasters) { }
        private XLua.LuaDLL.lua_CSFunction GetConstructorWrap(System.Type type) { }
        private XLua.LuaDLL.lua_CSFunction GetMethodWrap(System.Type type, System.String methodName) { }
        private XLua.LuaDLL.lua_CSFunction GetMethodWrapInCache(System.Type type, System.String methodName) { }
        private XLua.LuaDLL.lua_CSFunction GetDelegateWrap(System.Type type) { }
        private XLua.LuaDLL.lua_CSFunction GetEventWrap(System.Type type, System.String eventName) { }
        private XLua.MethodWrap _GenMethodWrap(System.Type type, System.String methodName, System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> methodBases, System.Boolean forceCheck) { }
        private System.Boolean tryMakeGenericMethod(System.Reflection.MethodBase& method) { }

    }

    // TypeToken: 0x2000074
    public class ObjectCheck : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.IntPtr L, System.Int32 idx) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000075
    public class ObjectCast : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Object Invoke(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.Int32 idx, System.Object target, System.AsyncCallback callback, System.Object object) { }
        private System.Object EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000076
    public class ObjectCheckers
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Type,XLua.ObjectCheck> checkersMap;        // 0x10
        private XLua.ObjectTranslator translator;        // 0x18

        // Methods
        private System.Void .ctor(XLua.ObjectTranslator translator) { }
        private System.Boolean objectCheck(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean luaTableCheck(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean numberCheck(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean decimalCheck(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean strCheck(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean bytesCheck(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean boolCheck(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean int64Check(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean uint64Check(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean luaFunctionCheck(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean intptrCheck(System.IntPtr L, System.Int32 idx) { }
        private XLua.ObjectCheck genChecker(System.Type type) { }
        private XLua.ObjectCheck genNullableChecker(XLua.ObjectCheck oc) { }
        private System.Void AddChecker(System.Type type, XLua.ObjectCheck oc) { }
        private XLua.ObjectCheck GetChecker(System.Type type) { }

    }

    // TypeToken: 0x2000079
    public class ObjectCasters
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Type,XLua.ObjectCast> castersMap;        // 0x10
        private XLua.ObjectTranslator translator;        // 0x18

        // Methods
        private System.Void .ctor(XLua.ObjectTranslator translator) { }
        private System.Object charCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object sbyteCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object byteCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object shortCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object ushortCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object intCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object uintCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object longCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object ulongCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object getDouble(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object floatCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object decimalCaster(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object getBoolean(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object getString(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object getBytes(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object getIntptr(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object getObject(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object getLuaTable(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Object getLuaFunction(System.IntPtr L, System.Int32 idx, System.Object target) { }
        private System.Void AddCaster(System.Type type, XLua.ObjectCast oc) { }
        private XLua.ObjectCast genCaster(System.Type type) { }
        private XLua.ObjectCast genNullableCaster(XLua.ObjectCast oc) { }
        private XLua.ObjectCast GetCaster(System.Type type) { }

    }

    // TypeToken: 0x200007E
    public class ObjectPool
    {
        // Fields
        private static System.Int32 LIST_END;        // 0x0
        private static System.Int32 ALLOCED;        // 0x0
        private XLua.ObjectPool.Slot[] list;        // 0x10
        private System.Int32 freelist;        // 0x18
        private System.Int32 count;        // 0x1C
        private System.Collections.Generic.List<System.Object> needCleanImmediately;        // 0x20

        // Methods
        private System.Object get_Item(System.Int32 i) { }
        private System.Void AddToNeedCleanImmediately(System.Object obj) { }
        private System.Void Clear() { }
        private System.Void extend_capacity() { }
        private System.Int32 Add(System.Object obj) { }
        private System.Boolean TryGetValue(System.Int32 index, System.Object& obj) { }
        private System.Object Get(System.Int32 index) { }
        private System.Object Remove(System.Int32 index) { }
        private System.Object Replace(System.Int32 index, System.Object o) { }
        private System.Int32 Check(System.Int32 check_pos, System.Int32 max_check, System.Func<System.Object,System.Boolean> checker, System.Collections.Generic.Dictionary<System.Object,System.Int32> reverse_map) { }
        private System.Void ClearAllUserdata(System.Func<System.Object,System.Boolean> checker, System.Collections.Generic.Dictionary<System.Object,System.Int32> reverse_map) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class ReferenceEqualsComparer, IEqualityComparer`1
    {
        // Methods
        private System.Boolean Equals(System.Object o1, System.Object o2) { }
        private System.Int32 GetHashCode(System.Object obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public class MonoPInvokeCallbackAttribute : Attribute
    {
        // Fields
        private System.Type type;        // 0x10

        // Methods
        private System.Void .ctor(System.Type t) { }

    }

    // TypeToken: 0x2000082
    public struct LuaTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static XLua.LuaTypes LUA_TNONE;        // 0x0
        public static XLua.LuaTypes LUA_TNIL;        // 0x0
        public static XLua.LuaTypes LUA_TNUMBER;        // 0x0
        public static XLua.LuaTypes LUA_TSTRING;        // 0x0
        public static XLua.LuaTypes LUA_TBOOLEAN;        // 0x0
        public static XLua.LuaTypes LUA_TTABLE;        // 0x0
        public static XLua.LuaTypes LUA_TFUNCTION;        // 0x0
        public static XLua.LuaTypes LUA_TUSERDATA;        // 0x0
        public static XLua.LuaTypes LUA_TTHREAD;        // 0x0
        public static XLua.LuaTypes LUA_TLIGHTUSERDATA;        // 0x0

    }

    // TypeToken: 0x2000083
    public struct LuaGCOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static XLua.LuaGCOptions LUA_GCSTOP;        // 0x0
        public static XLua.LuaGCOptions LUA_GCRESTART;        // 0x0
        public static XLua.LuaGCOptions LUA_GCCOLLECT;        // 0x0
        public static XLua.LuaGCOptions LUA_GCCOUNT;        // 0x0
        public static XLua.LuaGCOptions LUA_GCCOUNTB;        // 0x0
        public static XLua.LuaGCOptions LUA_GCSTEP;        // 0x0
        public static XLua.LuaGCOptions LUA_GCSETPAUSE;        // 0x0
        public static XLua.LuaGCOptions LUA_GCSETSTEPMUL;        // 0x0
        public static XLua.LuaGCOptions LUA_GCISRUNNING;        // 0x0
        public static XLua.LuaGCOptions LUA_GCGEN;        // 0x0
        public static XLua.LuaGCOptions LUA_GCINC;        // 0x0

    }

    // TypeToken: 0x2000084
    public struct LuaThreadStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static XLua.LuaThreadStatus LUA_RESUME_ERROR;        // 0x0
        public static XLua.LuaThreadStatus LUA_OK;        // 0x0
        public static XLua.LuaThreadStatus LUA_YIELD;        // 0x0
        public static XLua.LuaThreadStatus LUA_ERRRUN;        // 0x0
        public static XLua.LuaThreadStatus LUA_ERRSYNTAX;        // 0x0
        public static XLua.LuaThreadStatus LUA_ERRMEM;        // 0x0
        public static XLua.LuaThreadStatus LUA_ERRERR;        // 0x0

    }

    // TypeToken: 0x2000085
    public class LuaIndexes
    {
        // Methods
        private System.Int32 get_LUA_REGISTRYINDEX() { }
        private System.Void set_LUA_REGISTRYINDEX(System.Int32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000086
    public class ObjectTranslator
    {
        // Fields
        public XLua.MethodWrapsCache methodWrapsCache;        // 0x10
        public XLua.ObjectCheckers objectCheckers;        // 0x18
        public XLua.ObjectCasters objectCasters;        // 0x20
        private readonly XLua.ObjectPool objects;        // 0x28
        private readonly System.Collections.Generic.Dictionary<System.Object,System.Int32> reverseMap;        // 0x30
        private XLua.LuaEnv luaEnv;        // 0x38
        private XLua.StaticLuaCallbacks metaFunctions;        // 0x40
        private System.Collections.Generic.List<System.Reflection.Assembly> assemblies;        // 0x48
        private XLua.LuaDLL.lua_CSFunction importTypeFunction;        // 0x50
        private XLua.LuaDLL.lua_CSFunction loadAssemblyFunction;        // 0x58
        private XLua.LuaDLL.lua_CSFunction castFunction;        // 0x60
        private static XLua.LuaDLL.lua_CSFunction listPairFunction;        // 0x0
        private static XLua.LuaDLL.lua_CSFunction dicPairFunction;        // 0x8
        private static XLua.LuaDLL.lua_CSFunction normalPairFunction;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Type,System.Action<System.IntPtr>> delayWrap;        // 0x68
        private readonly System.Collections.Generic.Dictionary<System.Type,System.Func<System.Int32,XLua.LuaEnv,XLua.LuaBase>> interfaceBridgeCreators;        // 0x70
        private readonly System.Collections.Generic.Dictionary<System.Type,System.Type> aliasCfg;        // 0x78
        private System.Collections.Generic.Dictionary<System.Type,System.Boolean> loaded_types;        // 0x80
        public System.Int32 cacheRef;        // 0x88
        private System.Reflection.MethodInfo[] genericAction;        // 0x90
        private System.Reflection.MethodInfo[] genericFunc;        // 0x98
        private System.Collections.Generic.Dictionary<System.Type,System.Func<XLua.DelegateBridgeBase,System.Delegate>> delegateCreatorCache;        // 0xA0
        private System.Collections.Generic.Dictionary<System.Int32,System.WeakReference> delegate_bridges;        // 0xA8
        private System.Int32 common_array_meta;        // 0xB0
        private System.Int32 common_delegate_meta;        // 0xB4
        private System.Int32 enumerable_pairs_func;        // 0xB8
        private System.Collections.Generic.Dictionary<System.Type,System.Int32> typeIdMap;        // 0xC0
        private System.Collections.Generic.Dictionary<System.Int32,System.Type> typeMap;        // 0xC8
        private System.Collections.Generic.HashSet<System.Type> privateAccessibleFlags;        // 0xD0
        private System.Collections.Generic.Dictionary<System.Object,System.Int32> enumMap;        // 0xD8
        public static System.Int32 s_luaBuffOffset;        // 0x18
        public static System.Int32 s_nullableValueOffset;        // 0x1C
        private System.Collections.Generic.Dictionary<System.Type,System.Boolean> _unmanagedTypes;        // 0xE0
        private System.Collections.Generic.List<XLua.LuaDLL.lua_CSFunction> fix_cs_functions;        // 0xE8
        private System.Collections.Generic.List<XLua.ObjectTranslator.LuaCSFunctionPtr> fix_cs_function_ptrs;        // 0xF0
        public static System.Boolean enableLuaCSFunctionPtr;        // 0x20
        public static XLua.ObjectTranslator.GetDelegatePointer<System.Object> getDelegatePointer;        // 0x28
        private System.Collections.Generic.Dictionary<System.Type,XLua.ObjectTranslator.PushCSObject> custom_push_funcs;        // 0xF8
        private System.Collections.Generic.Dictionary<System.Type,XLua.ObjectTranslator.GetCSObject> custom_get_funcs;        // 0x100
        private System.Collections.Generic.Dictionary<System.Type,XLua.ObjectTranslator.UpdateCSObject> custom_update_funcs;        // 0x108
        private System.Collections.Generic.Dictionary<System.Type,System.Delegate> push_func_with_type;        // 0x110
        private System.Collections.Generic.Dictionary<System.Type,System.Delegate> get_func_with_type;        // 0x118
        private System.Int32 decimal_type_id;        // 0x120

        // Methods
        private XLua.ObjectPool get_Pools() { }
        private System.Void DelayWrapLoader(System.Type type, System.Action<System.IntPtr> loader) { }
        private System.Void AddInterfaceBridgeCreator(System.Type type, System.Func<System.Int32,XLua.LuaEnv,XLua.LuaBase> creator) { }
        private System.Boolean TryDelayWrapLoader(System.IntPtr L, System.Type type) { }
        private System.Void Alias(System.Type type, System.String alias) { }
        private System.Void addAssemblieByName(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies_usorted, System.String name) { }
        private System.Void .ctor(XLua.LuaEnv luaenv, System.IntPtr L) { }
        private System.Void initCSharpCallLua() { }
        private System.Func<XLua.DelegateBridgeBase,System.Delegate> getCreatorUsingGeneric(XLua.DelegateBridgeBase bridge, System.Type delegateType, System.Reflection.MethodInfo delegateMethod) { }
        private System.Delegate getDelegate(XLua.DelegateBridgeBase bridge, System.Type delegateType) { }
        private System.Object CreateDelegateBridge(System.IntPtr L, System.Type delegateType, System.Int32 idx) { }
        private System.Boolean AllDelegateBridgeReleased() { }
        private System.Void ReleaseLuaBase(System.IntPtr L, System.Int32 reference, System.Boolean is_delegate) { }
        private System.Object CreateInterfaceBridge(System.IntPtr L, System.Type interfaceType, System.Int32 idx) { }
        private System.Void CreateArrayMetatable(System.IntPtr L) { }
        private System.Void CreateDelegateMetatable(System.IntPtr L) { }
        private System.Void CreateEnumerablePairs(System.IntPtr L) { }
        private System.Int32 CsPairs(System.IntPtr L) { }
        private System.Int32 EnumToInt(System.IntPtr L) { }
        private System.Void CreateEnumerableCSPairs(System.IntPtr L) { }
        private System.Void OpenLib(System.IntPtr L) { }
        private System.Void createFunctionMetatable(System.IntPtr L) { }
        private System.Type FindType(System.String className, System.Boolean isQualifiedName) { }
        private System.Boolean hasMethod(System.Type type, System.String methodName) { }
        private System.Void collectObject(System.Int32 obj_index_to_collect) { }
        private System.Int32 addObject(System.Object obj, System.Boolean is_valuetype, System.Boolean is_enum) { }
        private System.Object GetObject(System.IntPtr L, System.Int32 index) { }
        private System.Type GetTypeOf(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean Assignable(System.IntPtr L, System.Int32 index) { }
        private System.Boolean Assignable(System.IntPtr L, System.Int32 index, System.Type type) { }
        private System.Object FastGetObject(System.IntPtr L, System.Int32 index, System.Type type) { }
        private System.Object GetObject(System.IntPtr L, System.Int32 index, System.Type type) { }
        private System.Void _Get(System.IntPtr L, System.Int32 index, T& v) { }
        private System.Void Get(System.IntPtr L, System.Int32 index, T& v) { }
        private System.Void PushByType(System.IntPtr L, T v) { }
        private T[] GetParams(System.IntPtr L, System.Int32 index) { }
        private System.Array GetParams(System.IntPtr L, System.Int32 index, System.Type type) { }
        private T GetDelegate(System.IntPtr L, System.Int32 index) { }
        private System.Int32 GetTypeId(System.IntPtr L, System.Type type) { }
        private System.Void PrivateAccessible(System.IntPtr L, System.Type type) { }
        private System.Int32 getTypeId(System.IntPtr L, System.Type type, System.Boolean& is_first, XLua.ObjectTranslator.LOGLEVEL log_level) { }
        private System.Void pushPrimitive(System.IntPtr L, System.Object o) { }
        private System.Void PushObject(System.IntPtr L, System.Object o) { }
        private System.Void PushAny(System.IntPtr L, System.Object o) { }
        private System.Int32 TranslateToEnumToTop(System.IntPtr L, System.Type type, System.Int32 idx) { }
        private System.Void Push(System.IntPtr L, XLua.LuaDLL.lua_CSFunction o) { }
        private System.Void Push(System.IntPtr L, XLua.LuaBase o) { }
        private System.Void Push(System.IntPtr L, T o) { }
        private System.Void Push(System.IntPtr L, System.Object o) { }
        private System.Void PushObject(System.IntPtr L, System.Object o, System.Int32 type_id) { }
        private System.Boolean IsUnmanagedType(System.Type type) { }
        private System.Void PushBrigeStruct(System.IntPtr L, System.IntPtr ptr, System.Type type, System.Int32 size) { }
        private System.Void _PushBrigeStruct(System.IntPtr L, System.IntPtr ptr, System.Type type, System.Int32 size) { }
        private System.Void GetBrigeStruct(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type) { }
        private System.Void AddNeedRemoveObjRef(System.Object obj) { }
        private System.Void _GetBrigeStruct(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type) { }
        private System.Void UpdateStructObj(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type) { }
        private System.Void BeyondUpdateStructObj(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type) { }
        private System.Void _UpdateStructObj(System.IntPtr L, System.IntPtr ptr, System.Int32 index, System.Int32 size, System.Type type) { }
        private System.Void Update(System.IntPtr L, System.Int32 index, T obj) { }
        private System.Void Update(System.IntPtr L, System.Int32 index, System.Object obj) { }
        private System.Object getCsObj(System.IntPtr L, System.Int32 index, System.Int32 udata) { }
        private System.Object SafeGetCSObj(System.IntPtr L, System.Int32 index) { }
        private System.Object FastGetCSObj(System.IntPtr L, System.Int32 index) { }
        private System.Void ReleaseCSObj(System.IntPtr L, System.Int32 index) { }
        private XLua.LuaDLL.lua_CSFunction GetFixCSFunction(System.Int32 index) { }
        private XLua.ObjectTranslator.LuaCSFunctionPtr GetFixCSFunctionPtr(System.Int32 index) { }
        private System.Void PushFixCSFunction(System.IntPtr L, XLua.LuaDLL.lua_CSFunction func) { }
        private System.Object[] popValues(System.IntPtr L, System.Int32 oldTop) { }
        private System.Object[] popValues(System.IntPtr L, System.Int32 oldTop, System.Type[] popTypes) { }
        private System.Void registerCustomOp(System.Type type, XLua.ObjectTranslator.PushCSObject push, XLua.ObjectTranslator.GetCSObject get, XLua.ObjectTranslator.UpdateCSObject update) { }
        private System.Boolean HasCustomOp(System.Type type) { }
        private System.Boolean tryGetPushFuncByType(System.Type type, T& func) { }
        private System.Boolean tryGetGetFuncByType(System.Type type, T& func) { }
        private System.Void RegisterPushAndGetAndUpdate(System.Action<System.IntPtr,T> push, XLua.ObjectTranslator.GetFunc<T> get, System.Action<System.IntPtr,System.Int32,T> update) { }
        private System.Void RegisterChecker(XLua.ObjectTranslator.CheckFunc<T> check) { }
        private System.Void RegisterCaster(XLua.ObjectTranslator.GetFunc<T> get) { }
        private System.Void PushDecimal(System.IntPtr L, System.Decimal val) { }
        private System.Boolean IsDecimal(System.IntPtr L, System.Int32 index) { }
        private System.Decimal GetDecimal(System.IntPtr L, System.Int32 index) { }
        private System.Void Get(System.IntPtr L, System.Int32 index, System.Decimal& val) { }
        private System.Void .cctor() { }
        private System.Decimal <tryGetGetFuncByType>b__125_0(System.IntPtr L, System.Int32 idx) { }

    }

    // TypeToken: 0x200009C
    public class ObjectTranslatorPool
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.IntPtr,System.WeakReference> translators;        // 0x10
        private System.IntPtr lastPtr;        // 0x18
        private XLua.ObjectTranslator lastTranslator;        // 0x20
        public static XLua.ObjectTranslatorPool Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Add(System.IntPtr L, XLua.ObjectTranslator translator) { }
        private XLua.ObjectTranslator Find(System.IntPtr L) { }
        private System.Void Remove(System.IntPtr L) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009D
    public interface RawObject
    {
        // Methods
        private System.Object get_Target() { }

    }

    // TypeToken: 0x200009E
    public class InternalUtility
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,System.String> s_baseValueTypeDic;        // 0x0

        // Methods
        private System.String GetTypeGenericSignatureDefine(System.Type type, System.Boolean isGetType, System.Boolean isRef, System.Boolean isOut, System.Boolean needLua, System.Boolean keepType, System.Boolean needEnum) { }
        private System.Boolean CheckRegisterBaseStructOnArm(System.Type type) { }
        private System.Boolean CheckCustomDelegate(System.String name) { }
        private System.Boolean CheckTypNeedToGen(System.Type type) { }
        private System.Boolean IsPublic(System.Type type) { }
        private System.String GetTypeFullName(System.Type t) { }
        private System.String GetDelegateName(System.Reflection.MethodInfo method) { }
        private System.Boolean IsStruct(System.Type type) { }
        private System.String GetGenericTypeName(System.Type type, System.Boolean needPoint) { }
        private System.String GeNormalName(System.String str) { }
        private System.String GetGenericTypeNameString(System.Type type) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009F
    public class MethodAndDelegateSignatureManager
    {
        // Methods
        private System.Type MakeMethodDelegateType(System.Reflection.MethodInfo method) { }
        private System.Type MakeMethodDelegateType(System.Reflection.MethodInfo method, System.Type customDelegateType) { }
        private System.ValueTuple<System.Type,System.String> GetMethodDelegateType(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0
    public class SignatureLoader
    {
        // Fields
        private XLua.LuaEnv.CustomLoader userLoader;        // 0x10
        private System.Security.Cryptography.RSACryptoServiceProvider rsa;        // 0x18
        private System.Security.Cryptography.SHA1 sha;        // 0x20

        // Methods
        private System.Void .ctor(System.String publicKey, XLua.LuaEnv.CustomLoader loader) { }
        private System.Byte[] load_and_verify(System.String& filepath) { }
        private XLua.LuaEnv.CustomLoader op_Implicit(XLua.SignatureLoader signatureLoader) { }

    }

    // TypeToken: 0x20000A1
    public class CallDelegatePointer`3 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TRet Invoke(System.IntPtr ptr, TParam1 target, TParam2 param) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr ptr, TParam1 target, TParam2 param, System.AsyncCallback callback, System.Object object) { }
        private TRet EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000A2
    public class StaticLuaCallbacks
    {
        // Fields
        private XLua.LuaDLL.lua_CSFunction GcMeta;        // 0x10
        private XLua.LuaDLL.lua_CSFunction ToStringMeta;        // 0x18
        private XLua.LuaDLL.lua_CSFunction EnumAndMeta;        // 0x20
        private XLua.LuaDLL.lua_CSFunction EnumOrMeta;        // 0x28
        private XLua.LuaDLL.lua_CSFunction StaticCSFunctionWraper;        // 0x30
        private XLua.LuaDLL.lua_CSFunction FixCSFunctionWraper;        // 0x38
        private XLua.LuaDLL.lua_CSFunction DelegateCtor;        // 0x40
        public static XLua.CallDelegatePointer<System.Object,System.IntPtr,System.Int32> callDelegatePointer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 EnumAnd(System.IntPtr L) { }
        private System.Int32 EnumOr(System.IntPtr L) { }
        private System.Int32 StaticCSFunction(System.IntPtr L) { }
        private System.Int32 FixCSFunction(System.IntPtr L) { }
        private System.Int32 DelegateCall(System.IntPtr L) { }
        private System.Int32 LuaGC(System.IntPtr L) { }
        private System.Int32 ToString(System.IntPtr L) { }
        private System.Int32 DelegateCombine(System.IntPtr L) { }
        private System.Int32 DelegateRemove(System.IntPtr L) { }
        private System.Boolean tryPrimitiveArrayGet(System.Type type, System.IntPtr L, System.Object obj, System.Int32 index) { }
        private System.Int32 ArrayIndexer(System.IntPtr L) { }
        private System.Boolean TryPrimitiveArraySet(System.Type type, System.IntPtr L, System.Object obj, System.Int32 array_idx, System.Int32 obj_idx) { }
        private System.Int32 ArrayNewIndexer(System.IntPtr L) { }
        private System.Int32 ArrayLength(System.IntPtr L) { }
        private System.Int32 MetaFuncIndex(System.IntPtr L) { }
        private System.Int32 Panic(System.IntPtr L) { }
        private System.Int32 Print(System.IntPtr L) { }
        private System.Int32 LoadSocketCore(System.IntPtr L) { }
        private System.Int32 LoadCS(System.IntPtr L) { }
        private System.Int32 LoadBuiltinLib(System.IntPtr L) { }
        private System.Int32 LoadFromResource(System.IntPtr L) { }
        private System.Int32 LoadFromStreamingAssetsPath(System.IntPtr L) { }
        private System.Int32 LoadFromCustomLoaders(System.IntPtr L) { }
        private System.Int32 LoadAssembly(System.IntPtr L) { }
        private System.Int32 ImportType(System.IntPtr L) { }
        private System.Int32 ImportGenericType(System.IntPtr L) { }
        private System.Int32 Cast(System.IntPtr L) { }
        private System.Type getType(System.IntPtr L, XLua.ObjectTranslator translator, System.Int32 idx) { }
        private System.Int32 XLuaAccess(System.IntPtr L) { }
        private System.Int32 XLuaPrivateAccessible(System.IntPtr L) { }
        private System.Int32 XLuaMetatableOperation(System.IntPtr L) { }
        private System.Int32 DelegateConstructor(System.IntPtr L) { }
        private System.Int32 ToFunction(System.IntPtr L) { }
        private System.Int32 GenericMethodWraper(System.IntPtr L) { }
        private System.Int32 GetGenericMethod(System.IntPtr L) { }
        private System.Int32 ReleaseCsObject(System.IntPtr L) { }

    }

    // TypeToken: 0x20000A3
    public class TypeExtensions
    {
        // Methods
        private System.Boolean IsValueType(System.Type type) { }
        private System.Boolean IsEnum(System.Type type) { }
        private System.Boolean IsPrimitive(System.Type type) { }
        private System.Boolean IsAbstract(System.Type type) { }
        private System.Boolean IsSealed(System.Type type) { }
        private System.Boolean IsInterface(System.Type type) { }
        private System.Boolean IsClass(System.Type type) { }
        private System.Type BaseType(System.Type type) { }
        private System.Boolean IsGenericType(System.Type type) { }
        private System.Boolean IsGenericTypeDefinition(System.Type type) { }
        private System.Boolean IsNestedPublic(System.Type type) { }
        private System.Boolean IsPublic(System.Type type) { }
        private System.String GetFriendlyName(System.Type type) { }

    }

    // TypeToken: 0x20000A5
    public struct LazyMemberTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static XLua.LazyMemberTypes Method;        // 0x0
        public static XLua.LazyMemberTypes FieldGet;        // 0x0
        public static XLua.LazyMemberTypes FieldSet;        // 0x0
        public static XLua.LazyMemberTypes PropertyGet;        // 0x0
        public static XLua.LazyMemberTypes PropertySet;        // 0x0
        public static XLua.LazyMemberTypes Event;        // 0x0

    }

    // TypeToken: 0x20000A6
    public class Utils
    {
        // Fields
        public static System.Boolean s_xluaReflectionOpt;        // 0x0
        public static System.Int32 OBJ_META_IDX;        // 0x0
        public static System.Int32 METHOD_IDX;        // 0x0
        public static System.Int32 GETTER_IDX;        // 0x0
        public static System.Int32 SETTER_IDX;        // 0x0
        public static System.Int32 CLS_IDX;        // 0x0
        public static System.Int32 CLS_META_IDX;        // 0x0
        public static System.Int32 CLS_GETTER_IDX;        // 0x0
        public static System.Int32 CLS_SETTER_IDX;        // 0x0
        public static System.String LuaIndexsFieldName;        // 0x0
        public static System.String LuaNewIndexsFieldName;        // 0x0
        public static System.String LuaClassIndexsFieldName;        // 0x0
        public static System.String LuaClassNewIndexsFieldName;        // 0x0

        // Methods
        private System.Boolean LoadField(System.IntPtr L, System.Int32 idx, System.String field_name) { }
        private System.IntPtr GetMainState(System.IntPtr L) { }
        private System.Collections.Generic.List<System.Type> GetAllTypes(System.Boolean exclude_generic_definition) { }
        private XLua.LuaDLL.lua_CSFunction genFieldGetter(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction genFieldGetterByPointer(System.Type type, System.Reflection.FieldInfo field) { }
        private System.Boolean IsNullableType(System.Type type) { }
        private XLua.LuaDLL.lua_CSFunction genFieldSetter(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction genFieldSetterByPointer(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction genItemGetterOpt(System.Type type, System.Reflection.PropertyInfo[] props, XLua.ObjectTranslator translator) { }
        private XLua.LuaDLL.lua_CSFunction genItemGetter(System.Type type, System.Reflection.PropertyInfo[] props) { }
        private XLua.LuaDLL.lua_CSFunction genItemSetterOpt(System.Type type, System.Reflection.PropertyInfo[] props, XLua.ObjectTranslator translator) { }
        private XLua.LuaDLL.lua_CSFunction genItemSetter(System.Type type, System.Reflection.PropertyInfo[] props) { }
        private XLua.LuaDLL.lua_CSFunction genEnumCastFrom(System.Type type) { }
        private System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetExtensionMethodsOf(System.Type type_to_be_extend) { }
        private System.Void makeReflectionWrap(System.IntPtr L, System.Type type, System.Int32 cls_field, System.Int32 cls_getter, System.Int32 cls_setter, System.Int32 obj_field, System.Int32 obj_getter, System.Int32 obj_setter, System.Int32 obj_meta, XLua.LuaDLL.lua_CSFunction& item_getter, XLua.LuaDLL.lua_CSFunction& item_setter, System.Reflection.BindingFlags access) { }
        private System.Void loadUpvalue(System.IntPtr L, System.Type type, System.String metafunc, System.Int32 index) { }
        private System.Void RegisterEnumType(System.IntPtr L, System.Type type) { }
        private System.Void MakePrivateAccessible(System.IntPtr L, System.Type type) { }
        private System.Int32 LazyReflectionCall(System.IntPtr L) { }
        private System.Void ReflectionWrap(System.IntPtr L, System.Type type, System.Boolean privateAccessible) { }
        private System.Void BeginObjectRegister(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, System.Int32 meta_count, System.Int32 method_count, System.Int32 getter_count, System.Int32 setter_count, System.Int32 type_id) { }
        private System.Int32 abs_idx(System.Int32 top, System.Int32 idx) { }
        private System.Void EndObjectRegister(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator, XLua.LuaDLL.lua_CSFunction csIndexer, XLua.LuaDLL.lua_CSFunction csNewIndexer, System.Type base_type, XLua.LuaDLL.lua_CSFunction arrayIndexer, XLua.LuaDLL.lua_CSFunction arrayNewIndexer) { }
        private System.Void RegisterFunc(System.IntPtr L, System.Int32 idx, System.String name, XLua.LuaDLL.lua_CSFunction func) { }
        private System.Void RegisterLazyFunc(System.IntPtr L, System.Int32 idx, System.String name, System.Type type, XLua.LazyMemberTypes memberType, System.Boolean isStatic) { }
        private System.Void RegisterObject(System.IntPtr L, XLua.ObjectTranslator translator, System.Int32 idx, System.String name, System.Object obj) { }
        private System.Void BeginClassRegister(System.Type type, System.IntPtr L, XLua.LuaDLL.lua_CSFunction creator, System.Int32 class_field_count, System.Int32 static_getter_count, System.Int32 static_setter_count) { }
        private System.Void EndClassRegister(System.Type type, System.IntPtr L, XLua.ObjectTranslator translator) { }
        private System.Collections.Generic.List<System.String> getPathOfType(System.Type type) { }
        private System.Void LoadCSTable(System.IntPtr L, System.Type type) { }
        private System.Void SetCSTable(System.IntPtr L, System.Type type, System.Int32 cls_table) { }
        private System.Boolean IsParamsMatch(System.Reflection.MethodInfo delegateMethod, System.Reflection.MethodInfo bridgeMethod) { }
        private System.Boolean IsSupportedMethod(System.Reflection.MethodInfo method) { }
        private System.Reflection.MethodInfo MakeGenericMethodWithConstraints(System.Reflection.MethodInfo method) { }
        private System.Type getExtendedType(System.Reflection.MethodInfo method) { }
        private System.Boolean IsStaticPInvokeCSFunction(XLua.LuaDLL.lua_CSFunction csFunction) { }
        private System.Boolean IsPublic(System.Type type) { }
        private System.Void .cctor() { }

    }

}

namespace XLua.Cast
{

    // TypeToken: 0x20000D0
    public class Any`1, RawObject
    {
        // Fields
        private T mTarget;        // 0x0

        // Methods
        private System.Void .ctor(T i) { }
        private System.Object get_Target() { }

    }

    // TypeToken: 0x20000D1
    public class Byte : Any`1
    {
        // Methods
        private System.Void .ctor(System.Byte i) { }

    }

    // TypeToken: 0x20000D2
    public class SByte : Any`1
    {
        // Methods
        private System.Void .ctor(System.SByte i) { }

    }

    // TypeToken: 0x20000D3
    public class Char : Any`1
    {
        // Methods
        private System.Void .ctor(System.Char i) { }

    }

    // TypeToken: 0x20000D4
    public class Int16 : Any`1
    {
        // Methods
        private System.Void .ctor(System.Int16 i) { }

    }

    // TypeToken: 0x20000D5
    public class UInt16 : Any`1
    {
        // Methods
        private System.Void .ctor(System.UInt16 i) { }

    }

    // TypeToken: 0x20000D6
    public class Int32 : Any`1
    {
        // Methods
        private System.Void .ctor(System.Int32 i) { }

    }

    // TypeToken: 0x20000D7
    public class UInt32 : Any`1
    {
        // Methods
        private System.Void .ctor(System.UInt32 i) { }

    }

    // TypeToken: 0x20000D8
    public class Int64 : Any`1
    {
        // Methods
        private System.Void .ctor(System.Int64 i) { }

    }

    // TypeToken: 0x20000D9
    public class UInt64 : Any`1
    {
        // Methods
        private System.Void .ctor(System.UInt64 i) { }

    }

    // TypeToken: 0x20000DA
    public class Float : Any`1
    {
        // Methods
        private System.Void .ctor(System.Single i) { }

    }

}

namespace XLua.LuaDLL
{

    // TypeToken: 0x20000DB
    public class lua_CSFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr L) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, System.AsyncCallback callback, System.Object object) { }
        private System.Int32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000DC
    public class Lua
    {
        // Fields
        private static System.String LUADLL;        // 0x0
        private static System.Int32 s_mainThreadId;        // 0x0
        public static System.Func<System.IntPtr,System.String> tryGetLuaStringFunc;        // 0x8
        public static System.Action<System.IntPtr,System.IntPtr,System.Int32,System.String> refLuaStringFunc;        // 0x10
        public static System.Int32 LUAI_MAXSHORTLEN;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.IntPtr lua_tothread(System.IntPtr L, System.Int32 index) { }
        private System.Int32 xlua_get_lib_version() { }
        private System.Int32 lua_gc(System.IntPtr L, XLua.LuaGCOptions what, System.Int32 data) { }
        private System.IntPtr lua_getupvalue(System.IntPtr L, System.Int32 funcindex, System.Int32 n) { }
        private System.IntPtr lua_setupvalue(System.IntPtr L, System.Int32 funcindex, System.Int32 n) { }
        private System.Int32 lua_pushthread(System.IntPtr L) { }
        private System.Boolean lua_isfunction(System.IntPtr L, System.Int32 stackPos) { }
        private System.Boolean lua_islightuserdata(System.IntPtr L, System.Int32 stackPos) { }
        private System.Boolean lua_istable(System.IntPtr L, System.Int32 stackPos) { }
        private System.Boolean lua_isthread(System.IntPtr L, System.Int32 stackPos) { }
        private System.Int32 luaL_error(System.IntPtr L, System.String message) { }
        private System.Int32 lua_setfenv(System.IntPtr L, System.Int32 stackPos) { }
        private System.IntPtr luaL_newstate() { }
        private System.Void lua_close(System.IntPtr L) { }
        private System.Void luaopen_xlua(System.IntPtr L) { }
        private System.Void luaL_openlibs(System.IntPtr L) { }
        private System.UInt32 xlua_objlen(System.IntPtr L, System.Int32 stackPos) { }
        private System.Void lua_createtable(System.IntPtr L, System.Int32 narr, System.Int32 nrec) { }
        private System.Void lua_newtable(System.IntPtr L, System.Int32 arrayL, System.Int32 hashL) { }
        private System.Int32 xlua_getglobal(System.IntPtr L, System.String name) { }
        private System.Int32 xlua_setglobal(System.IntPtr L, System.String name) { }
        private System.Void xlua_getloaders(System.IntPtr L) { }
        private System.Void lua_settop(System.IntPtr L, System.Int32 newTop) { }
        private System.Void lua_pop(System.IntPtr L, System.Int32 amount) { }
        private System.Void lua_insert(System.IntPtr L, System.Int32 newTop) { }
        private System.Void lua_remove(System.IntPtr L, System.Int32 index) { }
        private System.Int32 lua_rawget(System.IntPtr L, System.Int32 index) { }
        private System.Void lua_rawset(System.IntPtr L, System.Int32 index) { }
        private System.Int32 lua_setmetatable(System.IntPtr L, System.Int32 objIndex) { }
        private System.Int32 lua_rawequal(System.IntPtr L, System.Int32 index1, System.Int32 index2) { }
        private System.Void lua_pushvalue(System.IntPtr L, System.Int32 index) { }
        private System.Void lua_pushcclosure(System.IntPtr L, System.IntPtr fn, System.Int32 n) { }
        private System.Void lua_replace(System.IntPtr L, System.Int32 index) { }
        private System.Int32 lua_gettop(System.IntPtr L) { }
        private XLua.LuaTypes lua_type(System.IntPtr L, System.Int32 index) { }
        private System.Boolean lua_isnil(System.IntPtr L, System.Int32 index) { }
        private System.Boolean lua_isnumber(System.IntPtr L, System.Int32 index) { }
        private System.Boolean lua_isboolean(System.IntPtr L, System.Int32 index) { }
        private System.Int32 luaL_ref(System.IntPtr L, System.Int32 registryIndex) { }
        private System.Int32 luaL_ref(System.IntPtr L) { }
        private System.Void xlua_rawgeti(System.IntPtr L, System.Int32 tableIndex, System.Int64 index) { }
        private System.Void xlua_rawseti(System.IntPtr L, System.Int32 tableIndex, System.Int64 index) { }
        private System.Void lua_getref(System.IntPtr L, System.Int32 reference) { }
        private System.Int32 pcall_prepare(System.IntPtr L, System.Int32 error_func_ref, System.Int32 func_ref) { }
        private System.Void luaL_unref(System.IntPtr L, System.Int32 registryIndex, System.Int32 reference) { }
        private System.Void lua_unref(System.IntPtr L, System.Int32 reference) { }
        private System.Boolean lua_isstring(System.IntPtr L, System.Int32 index) { }
        private System.Boolean lua_isinteger(System.IntPtr L, System.Int32 index) { }
        private System.Void lua_pushnil(System.IntPtr L) { }
        private System.Void lua_pushstdcallcfunction(System.IntPtr L, XLua.LuaDLL.lua_CSFunction function, System.Int32 n) { }
        private System.Int32 xlua_upvalueindex(System.Int32 n) { }
        private System.Int32 lua_pcall(System.IntPtr L, System.Int32 nArgs, System.Int32 nResults, System.Int32 errfunc) { }
        private System.Int32 _lua_pcall(System.IntPtr L, System.Int32 nArgs, System.Int32 nResults, System.Int32 errfunc) { }
        private System.Double lua_tonumber(System.IntPtr L, System.Int32 index) { }
        private System.Int32 xlua_tointeger(System.IntPtr L, System.Int32 index) { }
        private System.UInt32 xlua_touint(System.IntPtr L, System.Int32 index) { }
        private System.Boolean lua_toboolean(System.IntPtr L, System.Int32 index) { }
        private System.IntPtr lua_topointer(System.IntPtr L, System.Int32 index) { }
        private System.IntPtr lua_tolstring(System.IntPtr L, System.Int32 index, System.IntPtr& strLen) { }
        private System.String lua_tostring_beyond(System.IntPtr L, System.Int32 index) { }
        private System.String lua_tostring(System.IntPtr L, System.Int32 index, System.Boolean cache) { }
        private System.IntPtr lua_atpanic(System.IntPtr L, XLua.LuaDLL.lua_CSFunction panicf) { }
        private System.Void lua_pushnumber(System.IntPtr L, System.Double number) { }
        private System.Void lua_pushboolean(System.IntPtr L, System.Boolean value) { }
        private System.Void xlua_pushinteger(System.IntPtr L, System.Int32 value) { }
        private System.Void xlua_pushuint(System.IntPtr L, System.UInt32 value) { }
        private System.Void lua_pushstring(System.IntPtr L, System.String str) { }
        private System.Void xlua_pushlstring(System.IntPtr L, System.Byte[] str, System.Int32 size) { }
        private System.Void xlua_pushasciistring(System.IntPtr L, System.String str) { }
        private System.Void lua_pushstring(System.IntPtr L, System.Byte[] str) { }
        private System.Byte[] lua_tobytes(System.IntPtr L, System.Int32 index) { }
        private System.Int32 luaL_newmetatable(System.IntPtr L, System.String meta) { }
        private System.Int32 xlua_pgettable(System.IntPtr L, System.Int32 idx) { }
        private System.Int32 xlua_psettable(System.IntPtr L, System.Int32 idx) { }
        private System.Void luaL_getmetatable(System.IntPtr L, System.String meta) { }
        private System.Int32 xluaL_loadbuffer(System.IntPtr L, System.Byte[] buff, System.Int32 size, System.String name) { }
        private System.Int32 luaL_loadbuffer(System.IntPtr L, System.String buff, System.String name) { }
        private System.Int32 xlua_tocsobj_safe(System.IntPtr L, System.Int32 obj) { }
        private System.Int32 xlua_tocsobj_fast(System.IntPtr L, System.Int32 obj) { }
        private System.Int32 lua_error(System.IntPtr L) { }
        private System.Boolean lua_checkstack(System.IntPtr L, System.Int32 extra) { }
        private System.Int32 lua_next(System.IntPtr L, System.Int32 index) { }
        private System.Void lua_pushlightuserdata(System.IntPtr L, System.IntPtr udata) { }
        private System.IntPtr xlua_tag() { }
        private System.Void luaL_where(System.IntPtr L, System.Int32 level) { }
        private System.Int32 xlua_tryget_cachedud(System.IntPtr L, System.Int32 key, System.Int32 cache_ref) { }
        private System.Void xlua_pushcsobj(System.IntPtr L, System.Int32 key, System.Int32 meta_ref, System.Boolean need_cache, System.Int32 cache_ref) { }
        private System.Int32 gen_obj_indexer(System.IntPtr L) { }
        private System.Int32 gen_obj_newindexer(System.IntPtr L) { }
        private System.Int32 gen_cls_indexer(System.IntPtr L) { }
        private System.Int32 gen_cls_newindexer(System.IntPtr L) { }
        private System.Int32 get_error_func_ref(System.IntPtr L) { }
        private System.Int32 load_error_func(System.IntPtr L, System.Int32 Ref) { }
        private System.Int32 luaopen_i64lib(System.IntPtr L) { }
        private System.Int32 luaopen_socket_core(System.IntPtr L) { }
        private System.Void lua_pushint64(System.IntPtr L, System.Int64 n) { }
        private System.Void lua_pushuint64(System.IntPtr L, System.UInt64 n) { }
        private System.Boolean lua_isint64(System.IntPtr L, System.Int32 idx) { }
        private System.Boolean lua_isuint64(System.IntPtr L, System.Int32 idx) { }
        private System.Int64 lua_toint64(System.IntPtr L, System.Int32 idx) { }
        private System.UInt64 lua_touint64(System.IntPtr L, System.Int32 idx) { }
        private System.Void xlua_push_csharp_function(System.IntPtr L, System.IntPtr fn, System.Int32 n) { }
        private System.Int32 xlua_csharp_str_error(System.IntPtr L, System.String message) { }
        private System.Int32 xlua_csharp_error(System.IntPtr L) { }
        private System.Boolean xlua_pack_int8_t(System.IntPtr buff, System.Int32 offset, System.Byte field) { }
        private System.Boolean xlua_unpack_int8_t(System.IntPtr buff, System.Int32 offset, System.Byte& field) { }
        private System.Boolean xlua_pack_int16_t(System.IntPtr buff, System.Int32 offset, System.Int16 field) { }
        private System.Boolean xlua_unpack_int16_t(System.IntPtr buff, System.Int32 offset, System.Int16& field) { }
        private System.Boolean xlua_pack_int32_t(System.IntPtr buff, System.Int32 offset, System.Int32 field) { }
        private System.Boolean xlua_unpack_int32_t(System.IntPtr buff, System.Int32 offset, System.Int32& field) { }
        private System.Boolean xlua_pack_int64_t(System.IntPtr buff, System.Int32 offset, System.Int64 field) { }
        private System.Boolean xlua_unpack_int64_t(System.IntPtr buff, System.Int32 offset, System.Int64& field) { }
        private System.Boolean xlua_pack_float(System.IntPtr buff, System.Int32 offset, System.Single field) { }
        private System.Boolean xlua_unpack_float(System.IntPtr buff, System.Int32 offset, System.Single& field) { }
        private System.Boolean xlua_pack_double(System.IntPtr buff, System.Int32 offset, System.Double field) { }
        private System.Boolean xlua_unpack_double(System.IntPtr buff, System.Int32 offset, System.Double& field) { }
        private System.IntPtr xlua_pushstruct(System.IntPtr L, System.UInt32 size, System.Int32 meta_ref) { }
        private System.Void xlua_pushcstable(System.IntPtr L, System.UInt32 field_count, System.Int32 meta_ref) { }
        private System.IntPtr lua_touserdata(System.IntPtr L, System.Int32 idx) { }
        private System.Int32 xlua_gettypeid(System.IntPtr L, System.Int32 idx) { }
        private System.Int32 xlua_get_registry_index() { }
        private System.Int32 xlua_pgettable_bypath(System.IntPtr L, System.Int32 idx, System.String path) { }
        private System.Int32 xlua_psettable_bypath(System.IntPtr L, System.Int32 idx, System.String path) { }
        private System.Boolean xlua_pack_float2(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2) { }
        private System.Boolean xlua_unpack_float2(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2) { }
        private System.Boolean xlua_pack_float3(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2, System.Single f3) { }
        private System.Boolean xlua_unpack_float3(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2, System.Single& f3) { }
        private System.Boolean xlua_pack_float4(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2, System.Single f3, System.Single f4) { }
        private System.Boolean xlua_unpack_float4(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2, System.Single& f3, System.Single& f4) { }
        private System.Boolean xlua_pack_float5(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2, System.Single f3, System.Single f4, System.Single f5) { }
        private System.Boolean xlua_unpack_float5(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2, System.Single& f3, System.Single& f4, System.Single& f5) { }
        private System.Boolean xlua_pack_float6(System.IntPtr buff, System.Int32 offset, System.Single f1, System.Single f2, System.Single f3, System.Single f4, System.Single f5, System.Single f6) { }
        private System.Boolean xlua_unpack_float6(System.IntPtr buff, System.Int32 offset, System.Single& f1, System.Single& f2, System.Single& f3, System.Single& f4, System.Single& f5, System.Single& f6) { }
        private System.Boolean xlua_pack_decimal(System.IntPtr buff, System.Int32 offset, System.Decimal& dec) { }
        private System.Boolean xlua_unpack_decimal(System.IntPtr buff, System.Int32 offset, System.Byte& scale, System.Byte& sign, System.Int32& hi32, System.UInt64& lo64) { }
        private System.Boolean xlua_is_eq_str(System.IntPtr L, System.Int32 index, System.String str) { }
        private System.Boolean xlua_is_eq_str(System.IntPtr L, System.Int32 index, System.String str, System.Int32 str_len) { }
        private System.IntPtr xlua_gl(System.IntPtr L) { }
        private System.Int32 luaL_traceback(System.IntPtr L, System.IntPtr L1, System.String msg, System.Int32 level) { }
        private System.Int32 lua_sethook(System.IntPtr L, XLua.LuaDLL.lua_Hook hook, System.Int32 mask, System.Int32 count) { }
        private XLua.LuaDLL.lua_Hook lua_gethook(System.IntPtr L) { }
        private System.Int32 lua_gethookmask(System.IntPtr L) { }
        private System.Int32 lua_getglobal(System.IntPtr L, System.IntPtr charPtr) { }
        private System.Int32 lua_pushlstring(System.IntPtr L, System.IntPtr charPtr, System.Int32 len) { }
        private System.Int32 luaopen_HyperLua(System.IntPtr L) { }
        private System.Void HyperLua_SetLogCallback(XLua.LuaDLL.Lua.HyperLuaLogCallbackDelegate logCallback) { }
        private System.Int32 LoadHyperLua(System.IntPtr L) { }
        private System.Void SetHyperLuaLogCallback(XLua.LuaDLL.Lua.HyperLuaLogCallbackDelegate logCallback) { }
        private System.Int32 luaopen_LuaUtils(System.IntPtr L) { }
        private System.Void LuaUtils_SetLogCallback(XLua.LuaDLL.Lua.LuaUtilsLogCallbackDelegate logCallback) { }
        private System.Int32 LoadLuaUtils(System.IntPtr L) { }
        private System.Void SetLuaUtilsLogCallback(XLua.LuaDLL.Lua.LuaUtilsLogCallbackDelegate logCallback) { }
        private System.Int32 luaopen_rapidjson(System.IntPtr L) { }
        private System.Int32 LoadRapidJson(System.IntPtr L) { }
        private System.Int32 luaopen_pb(System.IntPtr L) { }
        private System.Int32 LoadLuaProtobuf(System.IntPtr L) { }
        private System.Void beyond_setDecryptionFunc(System.IntPtr L, System.IntPtr func) { }

    }

    // TypeToken: 0x20000E0
    public class lua_Hook : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr L, XLua.lua_debug& ar) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr L, XLua.lua_debug& ar, System.AsyncCallback callback, System.Object object) { }
        private System.Int32 EndInvoke(XLua.lua_debug& ar, System.IAsyncResult result) { }

    }

}

namespace XLua.Reflection
{

    // TypeToken: 0x20000BC
    public class LuaObjFieldGetterSetter
    {
        // Methods
        private System.Boolean _CheckRuntimeType(System.IntPtr L, System.Object obj, System.Type type, System.Reflection.FieldInfo field) { }
        private System.IntPtr _GetPtrFromObj(System.Object obj) { }
        private System.IntPtr _GetPtrFromLuaStack(System.IntPtr L, XLua.ObjectTranslator translator, System.Int32 index, System.Boolean isUnmanagedType) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldGetterByPushInt32(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFloatFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjDoubleFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldGetterByPushInt64(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldGetterByPushBool(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldGetterByPushString(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldObjGetter(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldStructGetter(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldEnumGetter(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldStructGetter(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldObjSetter(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldStructSetter(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldSetterByGetInt32(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldSetterByGetInt64(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFloatFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjDoubleFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldBoolSetter(System.Type type, System.Reflection.FieldInfo field) { }
        private XLua.LuaDLL.lua_CSFunction GetObjFieldEnumSetter(System.Type type, System.Reflection.FieldInfo field) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF
    public class RuntimeEnumDic
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Int32,System.Object>> s_enumDic;        // 0x0

        // Methods
        private System.Object GetEnumByTypeAndValue(System.Type enumType, System.Int32 value) { }
        private System.Void AddEnumValue(System.Type enumType, System.Object enumObj) { }
        private System.Void .cctor() { }

    }

}

namespace XLua.TemplateEngine
{

    // TypeToken: 0x20000B6
    public struct TokenType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static XLua.TemplateEngine.TokenType Code;        // 0x0
        public static XLua.TemplateEngine.TokenType Eval;        // 0x0
        public static XLua.TemplateEngine.TokenType Text;        // 0x0

    }

    // TypeToken: 0x20000B7
    public class Chunk
    {
        // Fields
        private XLua.TemplateEngine.TokenType <Type>k__BackingField;        // 0x10
        private System.String <Text>k__BackingField;        // 0x18

        // Methods
        private XLua.TemplateEngine.TokenType get_Type() { }
        private System.Void set_Type(XLua.TemplateEngine.TokenType value) { }
        private System.String get_Text() { }
        private System.Void set_Text(System.String value) { }
        private System.Void .ctor(XLua.TemplateEngine.TokenType type, System.String text) { }

    }

    // TypeToken: 0x20000B8
    public class TemplateFormatException : Exception
    {
        // Methods
        private System.Void .ctor(System.String message) { }

    }

    // TypeToken: 0x20000B9
    public class Parser
    {
        // Fields
        private static System.String <RegexString>k__BackingField;        // 0x0

        // Methods
        private System.String get_RegexString() { }
        private System.Void set_RegexString(System.String value) { }
        private System.Void .cctor() { }
        private System.String EscapeString(System.String input) { }
        private System.String GetRegexString() { }
        private System.Collections.Generic.List<XLua.TemplateEngine.Chunk> Parse(System.String snippet) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BB
    public class LuaTemplate
    {
        // Fields
        private static XLua.LuaDLL.lua_CSFunction templateCompileFunction;        // 0x0
        private static XLua.LuaDLL.lua_CSFunction templateExecuteFunction;        // 0x8

        // Methods
        private System.String ComposeCode(System.Collections.Generic.List<XLua.TemplateEngine.Chunk> chunks) { }
        private XLua.LuaFunction Compile(XLua.LuaEnv luaenv, System.String snippet) { }
        private System.String Execute(XLua.LuaFunction compiledTemplate, XLua.LuaTable parameters) { }
        private System.String Execute(XLua.LuaFunction compiledTemplate) { }
        private System.Int32 Compile(System.IntPtr L) { }
        private System.Int32 Execute(System.IntPtr L) { }
        private System.Void OpenLib(System.IntPtr L) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

