// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.Beyond.dll
// Classes:  101
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000C
    public struct UnionKey
    {
        // Fields
        public System.Int32 intKey;        // 0x10
        public System.Int64 longKey;        // 0x18
        public System.String stringKey;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32 key) { }
        private System.Void .ctor(System.Int64 key) { }
        private System.Void .ctor(System.String key) { }

    }

    // TypeToken: 0x200000D
    public struct UnionKeyEnumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_parent;        // 0x10
        private System.Int32 m_index;        // 0x58
        private System.Int32 m_currentSlotIndex;        // 0x5C
        private System.Int32 m_currentSlotStartIndex;        // 0x60
        private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot m_currentSlot;        // 0x64

        // Methods
        private Beyond.SparkBuffer.Runtime.Map.UnionKey get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map parent) { }
        private System.Boolean MoveNext() { }
        private System.Void Dispose() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200000F
    public struct Options
    {
        // Fields
        public System.String rootName;        // 0x10
        public Beyond.SparkBuffer.SparkType rootType;        // 0x18
        public Beyond.SparkBuffer.SparkType subType1;        // 0x19
        public Beyond.SparkBuffer.SparkType subType2;        // 0x1A
        public Beyond.SparkBuffer.Runtime.BeanType beanType;        // 0x20
        public Beyond.SparkBuffer.Runtime.EnumType enumType;        // 0x28
        public Beyond.SparkBuffer.Runtime.EnumType mapKeyEnumType;        // 0x30

    }

    // TypeToken: 0x2000013
    public struct ReservedField
    {
        // Fields
        public System.Int32 position;        // 0x10
        public Newtonsoft.Json.Linq.JToken token;        // 0x18
        public Beyond.SparkBuffer.SparkType type;        // 0x20
        public Beyond.SparkBuffer.Runtime.BeanType beanType;        // 0x28
        public Beyond.SparkBuffer.Runtime.ArrayType arrayType;        // 0x30
        public Beyond.SparkBuffer.Runtime.MapType mapType;        // 0x48

    }

    // TypeToken: 0x2000012
    public class JsonLoader, IDisposable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.ByteWriter m_writer;        // 0x10
        private System.Collections.Generic.Dictionary<System.String,System.Int32> m_stringMap;        // 0x18

        // Methods
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.ByteWriter writer) { }
        private System.Void Dispose() { }
        private System.Void PopulateJsonDataWithoutTypeAndRootDef(Beyond.SparkBuffer.Runtime.ByteWriter writer, Newtonsoft.Json.Linq.JToken rootObj, Beyond.SparkBuffer.Runtime.Root.Options rootOptions, System.Int32& dataOffset) { }
        private System.Void _LoadJsonContentWithoutTypeAndRootDef(Newtonsoft.Json.Linq.JToken rootObj, Beyond.SparkBuffer.Runtime.Root.Options rootOptions, System.Int32& dataOffset) { }
        private System.Void _ExportStrings(Newtonsoft.Json.Linq.JToken rootJson, Beyond.SparkBuffer.Runtime.Root.Options rootOptions) { }
        private System.Void _CollectBeanStrings(System.Collections.Generic.HashSet<System.String> stringSet, Newtonsoft.Json.Linq.JObject obj, Beyond.SparkBuffer.Runtime.BeanType beanType) { }
        private System.Void _CollectArrayStrings(System.Collections.Generic.HashSet<System.String> stringSet, Newtonsoft.Json.Linq.JArray obj, Beyond.SparkBuffer.Runtime.ArrayType arrayType) { }
        private System.Void _CollectMapStrings(System.Collections.Generic.HashSet<System.String> stringSet, Newtonsoft.Json.Linq.JObject obj, Beyond.SparkBuffer.Runtime.MapType mapType) { }
        private System.Int32 _ExportRootData(Newtonsoft.Json.Linq.JToken rootJson, Beyond.SparkBuffer.Runtime.Root.Options rootOptions) { }
        private System.Int32 _ExportBeanData(Newtonsoft.Json.Linq.JObject beanObj, Beyond.SparkBuffer.Runtime.BeanType beanType) { }
        private System.Int32 _ExportArrayData(Newtonsoft.Json.Linq.JArray arrayObj, Beyond.SparkBuffer.Runtime.ArrayType arrayType) { }
        private System.Int32 _ExportMapData(Newtonsoft.Json.Linq.JObject mapObj, Beyond.SparkBuffer.Runtime.MapType mapType) { }
        private System.Void _ExportReservedFields(System.Collections.Generic.List<Beyond.SparkBuffer.Runtime.SparkManager.JsonLoader.ReservedField> reservedFields) { }
        private System.Void _ExportStringByLoc(System.String strVal) { }
        private System.Void _ExportEnumData(Newtonsoft.Json.Linq.JToken token, Beyond.SparkBuffer.Runtime.EnumType enumType) { }
        private System.Void _ExportCommonDataOrThrow(Newtonsoft.Json.Linq.JToken token, Beyond.SparkBuffer.SparkType type, System.Collections.Generic.List<Beyond.SparkBuffer.Runtime.SparkManager.JsonLoader.ReservedField> reservedFields) { }
        private System.Void _EnsureJTokenType(Newtonsoft.Json.Linq.JToken token, Newtonsoft.Json.Linq.JTokenType requiredType) { }
        private System.Exception _InvalidRootTypeError(Beyond.SparkBuffer.SparkType rootType) { }

    }

    // TypeToken: 0x2000020
    public struct EnumItem
    {
        // Fields
        public System.String name;        // 0x10
        public System.Int32 value;        // 0x18

    }

    // TypeToken: 0x2000053
    public struct ReflectResult
    {
        // Fields
        public Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType[] types;        // 0x10
        public Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject rootObj;        // 0x18

    }

    // TypeToken: 0x2000055
    public struct FieldInfo
    {
        // Fields
        public System.String name;        // 0x10
        public Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType type;        // 0x18

    }

    // TypeToken: 0x2000054
    public class ReflectType
    {
        // Fields
        public Beyond.SparkBuffer.SparkType sparkType;        // 0x10
        public System.Type concreteType;        // 0x18
        public Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType subType1;        // 0x20
        public Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType subType2;        // 0x28
        public System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType.FieldInfo> beanFields;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public class ReflectObject
    {
        // Fields
        public System.Object originObj;        // 0x10
        public Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType reflectType;        // 0x18
        public System.Collections.Specialized.OrderedDictionary beanElements;        // 0x20
        public System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject> arrayElements;        // 0x28
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject>> mapElements;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000059
    public struct ReservedField
    {
        // Fields
        public System.Int32 position;        // 0x10
        public Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject reflectObj;        // 0x18

    }

    // TypeToken: 0x200005A
    public struct Options
    {
        // Fields
        public static readonly Beyond.SparkBuffer.Serialize.SparkSerializer.Options DEFAULT;        // 0x0
        public System.String rootName;        // 0x10
        public System.String stripTypeNamePrefix;        // 0x18

        // Methods
        private System.Void .ctor(System.String rootName) { }
        private System.Void .ctor(System.String rootName, System.String stripTypeNamePrefix) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005B
    public struct HashSlot
    {
        // Fields
        public System.Int32 offset;        // 0x10
        public System.Int32 bucketsSize;        // 0x14

    }

namespace Beyond.Reflection
{

    // TypeToken: 0x200005D
    public class MethodPointerManager
    {
        // Methods
        private T2 CallPointer(System.IntPtr ptr, T1 param) { }
        private TRet CallDelegatePointer(System.IntPtr ptr, TParam1 target) { }
        private TRet CallDelegatePointer(System.IntPtr ptr, TParam1 target, TParam2 param) { }
        private System.ValueTuple<System.IntPtr,T1> GetDelegatePointer(System.Delegate d) { }
        private System.IntPtr GetDelegatePointer(System.Reflection.MethodInfo d) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005E
    public class ObjectPointerHelper
    {
        // Methods
        private System.IntPtr GetIntPtr(T& value) { }
        private System.IntPtr GetArrayPtr(T[] value) { }
        private T GetStructByPointer(System.IntPtr ptr) { }
        private T GetValue(System.IntPtr ptr, System.Int32 offset) { }
        private T GetArrayElement(System.IntPtr array, System.Int32 index) { }
        private System.Void SetValue(System.IntPtr ptr, System.Int32 offset, T value) { }
        private System.Void SetValue(System.IntPtr ptr, System.Int32 offset, System.Byte* data, System.Int32 size) { }
        private System.Object GetObj(System.IntPtr ptr, System.Int32 offset) { }
        private System.Void SetObj(System.IntPtr ptr, System.Int32 offset, System.Object value) { }
        private System.Void CopyValue(System.IntPtr target, System.IntPtr source, System.Int32 size) { }
        private System.Void CopyValue(System.Void* target, System.Void* source, System.Int32 size) { }
        private System.Void CopyValue(System.Byte* to, System.Byte* from, System.Int32 size) { }

    }

    // TypeToken: 0x200005F
    public class StructMemManager
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Int32,System.ValueTuple<System.Collections.Generic.HashSet<System.Int64>,System.Collections.Generic.List<System.IntPtr>>> s_structMemDict;        // 0x0

        // Methods
        private System.IntPtr GetMemoryBySize(System.Int32 size) { }
        private System.Void FreeMemory(System.Int32 size, System.IntPtr ptr) { }
        private System.Void ClearMemory() { }
        private System.String DumpMemory() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000060
    public class StructPtrRefrenceManager
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Object,System.Object> s_refDic;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<System.Int32>> s_structPtrOffsetDic;        // 0x8

        // Methods
        private System.Void _RunOnStart() { }
        private System.Void AddObjInPtrRef(System.Type type, System.IntPtr ptr) { }
        private System.Void RemoveObjInPtrRef(System.Type type, System.IntPtr ptr) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000061
    public class StructPtrWrapper
    {
        // Fields
        public System.IntPtr ptr;        // 0x10
        public System.Int32 size;        // 0x18
        public System.Type type;        // 0x20
        private static UnityEngine.Pool.ObjectPool<Beyond.Reflection.StructPtrWrapper> s_pool;        // 0x0
        private static System.IntPtr s_ptr;        // 0x8
        private static System.Int32 s_size;        // 0x10
        private static System.Type s_type;        // 0x18
        private static System.Object s_structObj;        // 0x20

        // Methods
        private Beyond.Reflection.StructPtrWrapper GetStructPtrWrapper(System.IntPtr ptr, System.Int32 size, System.Type type) { }
        private Beyond.Reflection.StructPtrWrapper GetStructPtrWrapper(System.Object structObj) { }
        private System.Void Release(Beyond.Reflection.StructPtrWrapper obj) { }
        private System.Void .ctor(System.IntPtr ptr, System.Int32 size, System.Type type) { }
        private System.Object GetStructObj() { }
        private System.Object GetStructObj(System.IntPtr ptr, System.Type type, System.Int32 size) { }
        private System.Void SetStructObjValue(System.Object structObj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.Type GetType() { }
        private System.Object GetStructObj(Beyond.Reflection.StructPtrWrapper obj) { }
        private System.Void .ctor(System.Object structObj) { }
        private Beyond.Reflection.StructPtrWrapper _OnCreate() { }
        private System.Void _OnGet(Beyond.Reflection.StructPtrWrapper o) { }
        private System.Void _OnRealse(Beyond.Reflection.StructPtrWrapper obj) { }
        private System.Void .cctor() { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }
        private System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

}

namespace Beyond.SparkBuffer
{

    // TypeToken: 0x2000004
    public struct SparkType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.SparkBuffer.SparkType Bool;        // 0x0
        public static Beyond.SparkBuffer.SparkType Byte;        // 0x0
        public static Beyond.SparkBuffer.SparkType Int;        // 0x0
        public static Beyond.SparkBuffer.SparkType Long;        // 0x0
        public static Beyond.SparkBuffer.SparkType Float;        // 0x0
        public static Beyond.SparkBuffer.SparkType Double;        // 0x0
        public static Beyond.SparkBuffer.SparkType Enum;        // 0x0
        public static Beyond.SparkBuffer.SparkType String;        // 0x0
        public static Beyond.SparkBuffer.SparkType Bean;        // 0x0
        public static Beyond.SparkBuffer.SparkType Array;        // 0x0
        public static Beyond.SparkBuffer.SparkType Map;        // 0x0

    }

    // TypeToken: 0x2000005
    public class Common
    {
        // Fields
        public static System.Int32 NULL_PLACEHOLDER;        // 0x0
        public static System.Int32 BOOL_MEM_SIZE;        // 0x0
        public static System.Int32 BYTE_MEM_SIZE;        // 0x0
        public static System.Int32 INT_MEM_SIZE;        // 0x0
        public static System.Int32 LONG_MEM_SIZE;        // 0x0
        public static System.Int32 FLOAT_MEM_SIZE;        // 0x0
        public static System.Int32 DOUBLE_MEM_SIZE;        // 0x0

    }

    // TypeToken: 0x2000006
    public class Utils
    {
        // Methods
        private System.Int32 Align4Bytes(System.Int32 position) { }
        private System.Int32 Align8Bytes(System.Int32 position) { }
        private System.Int32 AlignBytesForSize(System.Int32 position, System.Int32 size) { }
        private System.Int32 GetMemSizeForType(Beyond.SparkBuffer.SparkType sparkType) { }
        private System.Int32 GetFieldOffset(Beyond.SparkBuffer.SparkType sparkType, System.Int32& postion) { }
        private System.Boolean IsEnumOrBean(Beyond.SparkBuffer.SparkType sparkType) { }
        private System.Boolean IsArrayOrMap(Beyond.SparkBuffer.SparkType sparkType) { }
        private System.Boolean CheckValidMapKeyType(Beyond.SparkBuffer.SparkType sparkType) { }
        private System.Boolean CheckValidRootType(Beyond.SparkBuffer.SparkType sparkType) { }

    }

}

namespace Beyond.SparkBuffer.Runtime
{

    // TypeToken: 0x2000007
    public class ByteReader, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<System.Byte> m_buffer;        // 0x10
        private System.Byte* m_bufferPtr;        // 0x20
        private System.Int32 m_position;        // 0x28
        private readonly System.Int32 m_length;        // 0x2C
        public static Beyond.SparkBuffer.Runtime.IStringPool s_stringPool;        // 0x0
        public static System.Action<System.IntPtr> s_freeMemory;        // 0x8
        public static System.Func<System.Byte[],System.IntPtr> s_mallocMemory;        // 0x10

        // Methods
        private System.Int32 get_position() { }
        private Unity.Collections.NativeArray<System.Byte> get_buffer() { }
        private System.Void .ctor(System.Byte[] buffer) { }
        private System.Void Dispose() { }
        private System.Void SeekTo(System.Int32 pos) { }
        private System.Boolean ReadBool() { }
        private System.Byte ReadByte() { }
        private System.Int32 ReadInt() { }
        private System.Int64 ReadLong() { }
        private System.Single ReadFloat() { }
        private System.Double ReadDouble() { }
        private System.String ReadString() { }
        private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot ReadHashSlot() { }
        private Beyond.SparkBuffer.SparkType ReadSparkType() { }
        private System.Int32 ReadTypeHash() { }

    }

    // TypeToken: 0x2000008
    public class ByteWriter, IDisposable
    {
        // Fields
        private static readonly System.Byte[] BUFFER_0;        // 0x0
        private readonly System.IO.BinaryWriter m_writer;        // 0x10
        private readonly System.IO.Stream m_stream;        // 0x18
        public static Beyond.SparkBuffer.Runtime.IStringPool s_stringPool;        // 0x8

        // Methods
        private System.Int32 get_position() { }
        private System.Void .ctor(System.IO.Stream stream) { }
        private System.Void Dispose() { }
        private System.Void SeekTo(System.Int32 pos) { }
        private System.Void WriteBool(System.Boolean v) { }
        private System.Void WriteByte(System.Byte v) { }
        private System.Void WriteInt(System.Int32 v) { }
        private System.Void WriteLong(System.Int64 v) { }
        private System.Void WriteFloat(System.Single v) { }
        private System.Void WriteDouble(System.Double v) { }
        private System.Void WriteStringAlignment(System.String v) { }
        private System.Void WriteString(System.String v) { }
        private System.Void WriteBytes(System.ReadOnlySpan<System.Byte> buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteSparkType(Beyond.SparkBuffer.SparkType sparkType) { }
        private System.Int32 FillAlignment(System.Int32 align) { }
        private System.Void _FillAlignment4() { }
        private System.Void _FillAlignment8() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000009
    public struct Array
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.ArrayType m_arrayType;        // 0x10
        private readonly Beyond.SparkBuffer.Runtime.Root m_root;        // 0x28
        private readonly System.Int32 m_dataOffset;        // 0x30
        private readonly System.Int32 m_length;        // 0x34

        // Methods
        private System.Int32 get_length() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.ArrayType arrayType, System.Int32 offset, Beyond.SparkBuffer.Runtime.Root root) { }
        private System.Boolean GetBool(System.Int32 index) { }
        private System.Byte GetByte(System.Int32 index) { }
        private System.Int32 GetInt(System.Int32 index) { }
        private System.Int64 GetLong(System.Int32 index) { }
        private System.Single GetFloat(System.Int32 index) { }
        private System.Double GetDouble(System.Int32 index) { }
        private System.String GetString(System.Int32 index) { }
        private System.Int32 GetEnum(System.Int32 index) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.Int32 index) { }

    }

    // TypeToken: 0x200000A
    public struct Bean
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.BeanType m_beanType;        // 0x10
        private readonly Beyond.SparkBuffer.Runtime.Root m_root;        // 0x18
        private readonly System.Int32 m_dataOffset;        // 0x20

        // Methods
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.BeanType beanType, System.Int32 offset, Beyond.SparkBuffer.Runtime.Root root) { }
        private System.Boolean GetBool(System.String key, System.Int32& offset) { }
        private System.Boolean GetBool(System.Int32 offset) { }
        private System.Byte GetByte(System.String key, System.Int32& offset) { }
        private System.Byte GetByte(System.Int32 offset) { }
        private System.Int32 GetInt(System.String key, System.Int32& offset) { }
        private System.Int32 GetInt(System.Int32 offset) { }
        private System.Int64 GetLong(System.String key, System.Int32& offset) { }
        private System.Int64 GetLong(System.Int32 offset) { }
        private System.Single GetFloat(System.String key, System.Int32& offset) { }
        private System.Single GetFloat(System.Int32 offset) { }
        private System.Double GetDouble(System.String key, System.Int32& offset) { }
        private System.Double GetDouble(System.Int32 offset) { }
        private System.String GetString(System.String key, System.Int32& offset) { }
        private System.String GetString(System.Int32 offset) { }
        private System.Int32 GetEnum(System.String key, System.Int32& offset) { }
        private System.Int32 GetEnum(System.Int32 offset) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.String key) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Array> GetArray(System.String key) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Map> GetMap(System.String key) { }

    }

    // TypeToken: 0x200000B
    public struct Map, IEnumerable`1, IEnumerable
    {
        // Fields
        private static System.Int32 INT_KEY_MEM_SIZE;        // 0x0
        private static System.Int32 LONG_KEY_MEM_SIZE;        // 0x0
        private readonly Beyond.SparkBuffer.Runtime.MapType m_mapType;        // 0x10
        private readonly Beyond.SparkBuffer.Runtime.Root m_root;        // 0x38
        private readonly System.Int32 m_valueMemSize;        // 0x40
        private readonly System.Int32 m_keyMemSize;        // 0x44
        private readonly System.Int32 m_dataOffset;        // 0x48
        private readonly System.Int32 m_count;        // 0x4C
        private readonly System.Int32 m_slotsOffset;        // 0x50

        // Methods
        private System.Int32 get_count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.MapType mapType, System.Int32 offset, Beyond.SparkBuffer.Runtime.Root root) { }
        private Beyond.SparkBuffer.Runtime.Map.UnionKeyEnumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<Beyond.SparkBuffer.Runtime.Map.UnionKey> System.Collections.Generic.IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 GetHash(System.String str) { }
        private System.Int32 GetHash(System.Int32 value) { }
        private System.Int32 GetHash(System.Int64 value) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(System.Int32 slotIndex) { }
        private System.Int32 _FindHashIndexByKey(System.Int32 intKey) { }
        private System.Int32 _FindHashIndexByKey(System.Int64 longKey) { }
        private System.Int32 _FindHashIndexByKey(System.String stringKey) { }
        private System.Int32 GetIntKeyByIndex(System.Int32 index) { }
        private System.Int64 GetLongKeyByIndex(System.Int32 index) { }
        private System.String GetStringKeyByIndex(System.Int32 index) { }
        private System.Int32 GetIntKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, System.Int32 localIndex) { }
        private System.Int64 GetLongKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, System.Int32 localIndex) { }
        private System.String GetStringKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, System.Int32 localIndex) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.Boolean GetBool(System.String key) { }
        private System.Boolean TryGetBool(System.String key, System.Boolean& value) { }
        private System.Byte GetByte(System.String key) { }
        private System.Boolean TryGetByte(System.String key, System.Byte& value) { }
        private System.Int32 GetInt(System.String key) { }
        private System.Boolean TryGetInt(System.String key, System.Int32& value) { }
        private System.Int64 GetLong(System.String key) { }
        private System.Boolean TryGetLong(System.String key, System.Int64& value) { }
        private System.Single GetFloat(System.String key) { }
        private System.Boolean TryGetFloat(System.String key, System.Single& value) { }
        private System.Double GetDouble(System.String key) { }
        private System.Boolean TryGetDouble(System.String key, System.Double& value) { }
        private System.String GetString(System.String key) { }
        private System.Boolean TryGetString(System.String key, System.String& value) { }
        private System.Int32 GetEnum(System.String key) { }
        private System.Boolean TryGetEnum(System.String key, System.Int32& value) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.String key) { }
        private System.Boolean TryGetBean(System.String key, System.Nullable<Beyond.SparkBuffer.Runtime.Bean>& bean) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Boolean GetBool(System.Int32 key) { }
        private System.Boolean TryGetBool(System.Int32 key, System.Boolean& value) { }
        private System.Byte GetByte(System.Int32 key) { }
        private System.Boolean TryGetByte(System.Int32 key, System.Byte& value) { }
        private System.Int32 GetInt(System.Int32 key) { }
        private System.Boolean TryGetInt(System.Int32 key, System.Int32& value) { }
        private System.Int64 GetLong(System.Int32 key) { }
        private System.Boolean TryGetLong(System.Int32 key, System.Int64& value) { }
        private System.Single GetFloat(System.Int32 key) { }
        private System.Boolean TryGetFloat(System.Int32 key, System.Single& value) { }
        private System.Double GetDouble(System.Int32 key) { }
        private System.Boolean TryGetDouble(System.Int32 key, System.Double& value) { }
        private System.String GetString(System.Int32 key) { }
        private System.Boolean TryGetString(System.Int32 key, System.String& value) { }
        private System.Int32 GetEnum(System.Int32 key) { }
        private System.Boolean TryGetEnum(System.Int32 key, System.Int32& value) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.Int32 key) { }
        private System.Boolean TryGetBean(System.Int32 key, System.Nullable<Beyond.SparkBuffer.Runtime.Bean>& bean) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Boolean GetBool(System.Int64 key) { }
        private System.Boolean TryGetBool(System.Int64 key, System.Boolean& value) { }
        private System.Byte GetByte(System.Int64 key) { }
        private System.Boolean TryGetByte(System.Int64 key, System.Byte& value) { }
        private System.Int32 GetInt(System.Int64 key) { }
        private System.Boolean TryGetInt(System.Int64 key, System.Int32& value) { }
        private System.Int64 GetLong(System.Int64 key) { }
        private System.Boolean TryGetLong(System.Int64 key, System.Int64& value) { }
        private System.Single GetFloat(System.Int64 key) { }
        private System.Boolean TryGetFloat(System.Int64 key, System.Single& value) { }
        private System.Double GetDouble(System.Int64 key) { }
        private System.Boolean TryGetDouble(System.Int64 key, System.Double& value) { }
        private System.String GetString(System.Int64 key) { }
        private System.Boolean TryGetString(System.Int64 key, System.String& value) { }
        private System.Int32 GetEnum(System.Int64 key) { }
        private System.Boolean TryGetEnum(System.Int64 key, System.Int32& value) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.Int64 key) { }
        private System.Boolean TryGetBean(System.Int64 key, System.Nullable<Beyond.SparkBuffer.Runtime.Bean>& bean) { }
        private System.Boolean GetBoolByIndex(System.Int32 index) { }
        private System.Byte GetByteByIndex(System.Int32 index) { }
        private System.Int32 GetIntByIndex(System.Int32 index) { }
        private System.Int64 GetLongByIndex(System.Int32 index) { }
        private System.Single GetFloatByIndex(System.Int32 index) { }
        private System.Double GetDoubleByIndex(System.Int32 index) { }
        private System.String GetStringByIndex(System.Int32 index) { }
        private System.Int32 GetEnumByIndex(System.Int32 index) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBeanByIndex(System.Int32 index) { }
        private System.Int32 _GetOffsetByIndex(System.Int32 index) { }
        private System.Boolean GetBoolByOffset(System.Int32 offset) { }
        private System.Byte GetByteByOffset(System.Int32 offset) { }
        private System.Int32 GetIntByOffset(System.Int32 offset) { }
        private System.Int64 GetLongByOffset(System.Int32 offset) { }
        private System.Single GetFloatByOffset(System.Int32 offset) { }
        private System.Double GetDoubleByOffset(System.Int32 offset) { }
        private System.String GetStringByOffset(System.Int32 offset) { }
        private System.Int32 GetEnumByOffset(System.Int32 offset) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBeanByOffset(System.Int32 offset) { }

    }

    // TypeToken: 0x200000E
    public class Root, IDisposable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.ByteReader m_reader;        // 0x10
        private readonly Beyond.SparkBuffer.Runtime.Root.Options m_options;        // 0x18
        private readonly System.Int32 m_dataOffset;        // 0x40
        private System.Collections.Generic.Dictionary<System.Int32,System.String> m_cachedString;        // 0x48

        // Methods
        private System.String get_name() { }
        private Unity.Collections.NativeArray<System.Byte> get_bytes() { }
        private System.Void .ctor(System.Int32 dataOffset, Beyond.SparkBuffer.Runtime.Root.Options options, Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private System.Void Finalize() { }
        private System.String ToString() { }
        private System.Void Dispose() { }
        private System.Boolean IsValid() { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Bean> AsBean() { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Array> AsArray() { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Map> AsMap() { }
        private System.Int32 GetCurReaderPosition() { }
        private System.Boolean GetBool(System.Int32 offset) { }
        private System.Byte GetByte(System.Int32 offset) { }
        private System.Int32 GetInt(System.Int32 offset) { }
        private System.Int64 GetLong(System.Int32 offset) { }
        private System.Single GetFloat(System.Int32 offset) { }
        private System.Double GetDouble(System.Int32 offset) { }
        private System.Int32 GetEnum(System.Int32 offset) { }
        private System.String GetString(System.Int32 offset) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.Int32 offset, Beyond.SparkBuffer.Runtime.BeanType beanType) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Array> GetArray(System.Int32 offset, Beyond.SparkBuffer.Runtime.ArrayType arrayType) { }
        private System.Nullable<Beyond.SparkBuffer.Runtime.Map> GetMap(System.Int32 offset, Beyond.SparkBuffer.Runtime.MapType mapType) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(System.Int32 offset) { }

    }

    // TypeToken: 0x2000010
    public class Error
    {
        // Methods
        private System.Exception TypeNotFoundError(System.Int32 typeHash, Beyond.SparkBuffer.SparkType sparkType) { }
        private System.Exception InvalidTypeError(Beyond.SparkBuffer.SparkType sparkType) { }
        private System.Exception InvalidMapKeyError(Beyond.SparkBuffer.SparkType sparkType) { }
        private System.Exception NullTypeError(Beyond.SparkBuffer.SparkType sparkType) { }
        private System.Exception GetEndOfFile() { }
        private System.Exception SeekAheadOfFile() { }
        private System.Exception DisposedException() { }

    }

    // TypeToken: 0x2000011
    public class SparkManager
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.SparkBuffer.Runtime.BeanType> m_beanTypeMap;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.SparkBuffer.Runtime.EnumType> m_enumTypeMap;        // 0x18
        protected readonly System.Collections.Generic.Dictionary<System.String,Beyond.SparkBuffer.Runtime.Root> m_namedRoots;        // 0x20
        private readonly System.Collections.Generic.List<Beyond.SparkBuffer.Runtime.Root> m_anonymousRoots;        // 0x28
        private readonly System.Collections.Generic.Queue<Beyond.SparkBuffer.Runtime.BeanType> m_beanTypeQueue;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private Beyond.SparkBuffer.Runtime.Root Load(System.Byte[] bytes, System.String overrideRootName) { }
        private Beyond.SparkBuffer.Runtime.Root Load(System.Byte[] bytes) { }
        private Beyond.SparkBuffer.Runtime.Root LoadFromJson_EditorOnly(System.Byte[] bytes, Newtonsoft.Json.Linq.JToken jsonData, System.String overrideRootName) { }
        private Beyond.SparkBuffer.Runtime.Root LoadFromJson_EditorOnly(System.Byte[] bytes, Newtonsoft.Json.Linq.JToken jsonData) { }
        private System.Boolean Unload(Beyond.SparkBuffer.Runtime.Root root) { }
        private System.Void UnloadAndClearAll() { }
        private System.Boolean TryGetEnumType(System.Int32 typeHash, Beyond.SparkBuffer.Runtime.EnumType& enumType) { }
        private System.Boolean TryGetBeanType(System.Int32 typeHash, Beyond.SparkBuffer.Runtime.BeanType& beanType) { }
        private System.Boolean _AddRoot(Beyond.SparkBuffer.Runtime.Root root) { }
        private System.Void _ReadTypeDefs(Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private Beyond.SparkBuffer.Runtime.Root.Options _ReadRootDef(Beyond.SparkBuffer.Runtime.ByteReader reader, System.String overrideRootName) { }

    }

    // TypeToken: 0x2000014
    public class RuntimeSparkManager : SparkManager
    {
        // Fields
        private static Beyond.SparkBuffer.Runtime.RuntimeSparkManager s_instance;        // 0x0
        private System.Action<Beyond.SparkBuffer.Runtime.Root> m_onRootLoaded;        // 0x38
        private System.Action<Beyond.SparkBuffer.Runtime.Root> m_onRootUnloaded;        // 0x40
        private System.Action m_onUnloadAll;        // 0x48
        private static System.String LUADLL;        // 0x0

        // Methods
        private Beyond.SparkBuffer.Runtime.RuntimeSparkManager get_instance() { }
        private System.Void .ctor() { }
        private System.Boolean Unload(Beyond.SparkBuffer.Runtime.Root root) { }
        private System.Void UnloadAndClearAll() { }
        private System.Boolean LuaSpark_LoadRoot(System.IntPtr L, System.String rootName, System.IntPtr data, System.Int32 size) { }
        private System.Boolean LuaSpark_UnloadRoot(System.IntPtr L, System.String rootName) { }
        private System.Void LuaSpark_UnloadAll(System.IntPtr L) { }
        private System.Void RegisterToLua(System.IntPtr L) { }
        private System.Void UnregisterFromLua(System.IntPtr L) { }
        private System.Boolean _AddRoot(Beyond.SparkBuffer.Runtime.Root root) { }

    }

    // TypeToken: 0x2000016
    public interface IStringPool
    {
        // Methods
        private System.Int32 AddString(System.String str) { }
        private System.String GetString(System.Int32 index) { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x2000017
    public class Field
    {
        // Fields
        private readonly System.String <name>k__BackingField;        // 0x10
        private readonly System.Int32 <offset>k__BackingField;        // 0x18

        // Methods
        private System.String get_name() { }
        private System.Int32 get_offset() { }
        private Beyond.SparkBuffer.SparkType get_type() { }
        private System.Void .ctor(System.String fieldName, System.Int32 fieldOffset) { }
        private System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager) { }

    }

    // TypeToken: 0x2000018
    public class SimpleField : Field
    {
        // Fields
        private readonly Beyond.SparkBuffer.SparkType <type>k__BackingField;        // 0x20

        // Methods
        private Beyond.SparkBuffer.SparkType get_type() { }
        private System.Void .ctor(Beyond.SparkBuffer.SparkType type, System.String fieldName, System.Int32 fieldOffset) { }
        private System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager) { }

    }

    // TypeToken: 0x2000019
    public class EnumField : Field
    {
        // Fields
        private System.Int32 m_typeHash;        // 0x20
        private Beyond.SparkBuffer.Runtime.EnumType m_enumType;        // 0x28

        // Methods
        private Beyond.SparkBuffer.SparkType get_type() { }
        private Beyond.SparkBuffer.Runtime.EnumType get_enumType() { }
        private System.Void .ctor(System.String fieldName, System.Int32 fieldOffset) { }
        private System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager) { }

    }

    // TypeToken: 0x200001A
    public class BeanField : Field
    {
        // Fields
        private System.Int32 m_typeHash;        // 0x20
        private Beyond.SparkBuffer.Runtime.BeanType m_beanType;        // 0x28

        // Methods
        private Beyond.SparkBuffer.SparkType get_type() { }
        private Beyond.SparkBuffer.Runtime.BeanType get_beanType() { }
        private System.Void .ctor(System.String fieldName, System.Int32 fieldOffset) { }
        private System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager) { }

    }

    // TypeToken: 0x200001B
    public class ArrayField : Field
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.ArrayType m_arrayType;        // 0x20
        private System.Int32 m_elementTypeHash;        // 0x38

        // Methods
        private Beyond.SparkBuffer.SparkType get_type() { }
        private Beyond.SparkBuffer.Runtime.ArrayType get_arrayType() { }
        private System.Void .ctor(System.String fieldName, System.Int32 fieldOffset) { }
        private System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager) { }

    }

    // TypeToken: 0x200001C
    public class MapField : Field
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.MapType m_mapInfo;        // 0x20
        private System.Int32 m_keyTypeHash;        // 0x48
        private System.Int32 m_valueTypeHash;        // 0x4C

        // Methods
        private Beyond.SparkBuffer.SparkType get_type() { }
        private Beyond.SparkBuffer.Runtime.MapType get_mapType() { }
        private System.Void .ctor(System.String fieldName, System.Int32 fieldOffset) { }
        private System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager) { }

    }

    // TypeToken: 0x200001D
    public struct ArrayType
    {
        // Fields
        public Beyond.SparkBuffer.SparkType elementType;        // 0x10
        public Beyond.SparkBuffer.Runtime.BeanType elementBeanType;        // 0x18
        public Beyond.SparkBuffer.Runtime.EnumType elementEnumType;        // 0x20

    }

    // TypeToken: 0x200001E
    public struct MapType
    {
        // Fields
        public Beyond.SparkBuffer.SparkType keyType;        // 0x10
        public Beyond.SparkBuffer.Runtime.EnumType keyEnumType;        // 0x18
        public Beyond.SparkBuffer.SparkType valueType;        // 0x20
        public Beyond.SparkBuffer.Runtime.BeanType valueBeanType;        // 0x28
        public Beyond.SparkBuffer.Runtime.EnumType valueEnumType;        // 0x30

    }

    // TypeToken: 0x200001F
    public class EnumType
    {
        // Fields
        private System.Collections.Generic.List<Beyond.SparkBuffer.Runtime.EnumType.EnumItem> m_enums;        // 0x10
        private System.Int32 <typeHash>k__BackingField;        // 0x18
        private System.String <name>k__BackingField;        // 0x20

        // Methods
        private System.Int32 get_typeHash() { }
        private System.Void set_typeHash(System.Int32 value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private System.Boolean TryGetValue(System.String enumName, System.Int32& enumVal) { }

    }

    // TypeToken: 0x2000021
    public class BeanType, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,Beyond.SparkBuffer.Runtime.Field> m_fields;        // 0x10
        private System.Int32 <typeHash>k__BackingField;        // 0x18
        private System.String <name>k__BackingField;        // 0x20

        // Methods
        private System.Int32 get_typeHash() { }
        private System.Void set_typeHash(System.Int32 value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.ByteReader reader) { }
        private System.String ToString() { }
        private System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager) { }
        private System.Boolean TryGetField(System.String fieldName, Beyond.SparkBuffer.Runtime.Field& field) { }
        private System.Collections.Generic.Dictionary.Enumerator<System.String,Beyond.SparkBuffer.Runtime.Field> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Beyond.SparkBuffer.Runtime.Field>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Beyond.SparkBuffer.Runtime.Field>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private Beyond.SparkBuffer.Runtime.Field _NewField(System.String name, Beyond.SparkBuffer.SparkType type, System.Int32 offset) { }

    }

}

namespace Beyond.SparkBuffer.Runtime.Wrapper
{

    // TypeToken: 0x2000022
    public interface IArrayWrapper`1
    {
        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private T get_Item(System.Int32 index) { }

    }

    // TypeToken: 0x2000023
    public struct ArrayEnumerator`2, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly TArray m_parent;        // 0x0
        private System.Int32 m_index;        // 0x0

        // Methods
        private TElement get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void .ctor(TArray parent) { }
        private System.Boolean MoveNext() { }
        private System.Void Dispose() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000024
    public struct NullableBeanArray`1, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x0
        private System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> m_creator;        // 0x0

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator) { }
        private System.Nullable<TBean> get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Nullable<TBean>,Beyond.SparkBuffer.Runtime.Wrapper.NullableBeanArray<TBean>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Nullable<TBean>> System.Collections.Generic.IEnumerable<TBean?>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000025
    public struct BeanArray`1, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x0
        private System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> m_creator;        // 0x0

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator) { }
        private TBean get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<TBean,Beyond.SparkBuffer.Runtime.Wrapper.BeanArray<TBean>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<TBean> System.Collections.Generic.IEnumerable<TBean>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000026
    public struct EnumArray`1, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x0
        private System.Func<System.Int32,TEnum> m_converter;        // 0x0

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array, System.Func<System.Int32,TEnum> converter) { }
        private TEnum get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<TEnum,Beyond.SparkBuffer.Runtime.Wrapper.EnumArray<TEnum>> GetEnumerator() { }
        private TEnum[] ToArray() { }
        private System.Boolean Contains(TEnum item) { }
        private System.Collections.Generic.IEnumerator<TEnum> System.Collections.Generic.IEnumerable<TEnum>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000027
    public struct BoolArray, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x10

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array) { }
        private System.Boolean get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Boolean,Beyond.SparkBuffer.Runtime.Wrapper.BoolArray> GetEnumerator() { }
        private System.Boolean[] ToArray() { }
        private System.Boolean Contains(System.Boolean item) { }
        private System.Collections.Generic.IEnumerator<System.Boolean> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000028
    public struct ByteArray, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x10

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array) { }
        private System.Byte get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Byte,Beyond.SparkBuffer.Runtime.Wrapper.ByteArray> GetEnumerator() { }
        private System.Byte[] ToArray() { }
        private System.Boolean Contains(System.Byte item) { }
        private System.Collections.Generic.IEnumerator<System.Byte> System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000029
    public struct IntArray, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x10

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array) { }
        private System.Int32 get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.IntArray> GetEnumerator() { }
        private System.Int32[] ToArray() { }
        private System.Boolean Contains(System.Int32 item) { }
        private System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200002A
    public struct LongArray, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x10

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array) { }
        private System.Int64 get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Int64,Beyond.SparkBuffer.Runtime.Wrapper.LongArray> GetEnumerator() { }
        private System.Int64[] ToArray() { }
        private System.Boolean Contains(System.Int64 item) { }
        private System.Collections.Generic.IEnumerator<System.Int64> System.Collections.Generic.IEnumerable<System.Int64>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200002B
    public struct FloatArray, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x10

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array) { }
        private System.Single get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Single,Beyond.SparkBuffer.Runtime.Wrapper.FloatArray> GetEnumerator() { }
        private System.Single[] ToArray() { }
        private System.Collections.Generic.IEnumerator<System.Single> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200002C
    public struct DoubleArray, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x10

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array) { }
        private System.Double get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Double,Beyond.SparkBuffer.Runtime.Wrapper.DoubleArray> GetEnumerator() { }
        private System.Double[] ToArray() { }
        private System.Collections.Generic.IEnumerator<System.Double> System.Collections.Generic.IEnumerable<System.Double>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200002D
    public struct StringArray, IArrayWrapper`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Beyond.SparkBuffer.Runtime.Array m_array;        // 0x10

        // Methods
        private System.Int32 get_length() { }
        private System.Int32 get_Count() { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array) { }
        private System.String get_Item(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.String,Beyond.SparkBuffer.Runtime.Wrapper.StringArray> GetEnumerator() { }
        private System.String[] ToArray() { }
        private System.Boolean Contains(System.String item) { }
        private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200002E
    public interface IBeanWrapper
    {
        // Methods
        private System.Void SetBean(Beyond.SparkBuffer.Runtime.Bean& bean) { }

    }

    // TypeToken: 0x200002F
    public struct HashSlot
    {
        // Fields
        public System.Int32 offset;        // 0x10
        public System.Int32 bucketsSize;        // 0x14
        public static readonly System.Int32 size;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000030
    public interface IMapWrapper`3
    {
        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private TValue get_Item(TKey key) { }
        private System.Boolean ContainsKey(TKey key) { }
        private TValue GetValue(TKey key) { }
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private TKey GetKeyByIndex(System.Int32 index) { }
        private TValue GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<TKey,TValue,TMap> GetEnumerator() { }

    }

    // TypeToken: 0x2000031
    public struct MapEnumerator`3, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly TMap m_parent;        // 0x0
        private System.Int32 m_index;        // 0x0

        // Methods
        private System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void .ctor(TMap parent) { }
        private System.Boolean MoveNext() { }
        private System.Void Dispose() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000032
    public struct S2NullableBeanMap`1, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x0
        private readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> m_creator;        // 0x0

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Nullable<TBean> get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private System.Nullable<TBean> GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, System.Nullable<TBean>& value) { }
        private System.Nullable<TBean> GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Nullable<TBean>,Beyond.SparkBuffer.Runtime.Wrapper.S2NullableBeanMap<TBean>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Nullable<TBean>>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TBean?>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000033
    public struct S2BeanMap`1, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x0
        private readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> m_creator;        // 0x0

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private TBean get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private TBean GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, TBean& value) { }
        private TBean GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,TBean,Beyond.SparkBuffer.Runtime.Wrapper.S2BeanMap<TBean>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,TBean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TBean>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000034
    public struct S2EnumMap`1, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x0
        private System.Func<System.Int32,TEnum> m_converter;        // 0x0

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private TEnum get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<System.Int32,TEnum> converter) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private TEnum GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, TEnum& value) { }
        private TEnum GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,TEnum,Beyond.SparkBuffer.Runtime.Wrapper.S2EnumMap<TEnum>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,TEnum>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TEnum>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000035
    public struct S2BoolMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Boolean get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private System.Boolean GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, System.Boolean& value) { }
        private System.Boolean GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Boolean,Beyond.SparkBuffer.Runtime.Wrapper.S2BoolMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Boolean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Boolean>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000036
    public struct S2ByteMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Byte get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private System.Byte GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, System.Byte& value) { }
        private System.Byte GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Byte,Beyond.SparkBuffer.Runtime.Wrapper.S2ByteMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Byte>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Byte>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000037
    public struct S2IntMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private System.Int32 GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, System.Int32& value) { }
        private System.Int32 GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.S2IntMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Int32>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000038
    public struct S2LongMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Int64 get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private System.Int64 GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, System.Int64& value) { }
        private System.Int64 GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Int64,Beyond.SparkBuffer.Runtime.Wrapper.S2LongMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Int64>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Int64>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000039
    public struct S2FloatMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Single get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private System.Single GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, System.Single& value) { }
        private System.Single GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Single,Beyond.SparkBuffer.Runtime.Wrapper.S2FloatMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Single>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Single>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200003A
    public struct S2DoubleMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Double get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private System.Double GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, System.Double& value) { }
        private System.Double GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Double,Beyond.SparkBuffer.Runtime.Wrapper.S2DoubleMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Double>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Double>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200003B
    public struct S2StringMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.String get_Item(System.String key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.String key) { }
        private System.String GetKeyByIndex(System.Int32 index) { }
        private System.String GetValue(System.String key) { }
        private System.Boolean TryGetValue(System.String key, System.String& value) { }
        private System.String GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.String,Beyond.SparkBuffer.Runtime.Wrapper.S2StringMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200003C
    public struct I2NullableBeanMap`1, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x0
        private readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> m_creator;        // 0x0

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Nullable<TBean> get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private System.Nullable<TBean> GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, System.Nullable<TBean>& value) { }
        private System.Nullable<TBean> GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Nullable<TBean>,Beyond.SparkBuffer.Runtime.Wrapper.I2NullableBeanMap<TBean>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Nullable<TBean>>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,TBean?>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200003D
    public struct I2BeanMap`1, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x0
        private readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> m_creator;        // 0x0

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private TBean get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private TBean GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, TBean& value) { }
        private TBean GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,TBean,Beyond.SparkBuffer.Runtime.Wrapper.I2BeanMap<TBean>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,TBean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,TBean>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200003E
    public struct I2EnumMap`1, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x0
        private System.Func<System.Int32,TEnum> m_converter;        // 0x0

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private TEnum get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<System.Int32,TEnum> converter) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private TEnum GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, TEnum& value) { }
        private TEnum GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,TEnum,Beyond.SparkBuffer.Runtime.Wrapper.I2EnumMap<TEnum>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,TEnum>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,TEnum>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200003F
    public struct I2BoolMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Boolean get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private System.Boolean GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, System.Boolean& value) { }
        private System.Boolean GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Boolean,Beyond.SparkBuffer.Runtime.Wrapper.I2BoolMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Boolean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Boolean>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000040
    public struct I2ByteMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Byte get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private System.Byte GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, System.Byte& value) { }
        private System.Byte GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Byte,Beyond.SparkBuffer.Runtime.Wrapper.I2ByteMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Byte>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Byte>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000041
    public struct I2IntMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private System.Int32 GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, System.Int32& value) { }
        private System.Int32 GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.I2IntMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000042
    public struct I2LongMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Int64 get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private System.Int64 GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, System.Int64& value) { }
        private System.Int64 GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Int64,Beyond.SparkBuffer.Runtime.Wrapper.I2LongMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Int64>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int64>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000043
    public struct I2FloatMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Single get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private System.Single GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, System.Single& value) { }
        private System.Single GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Single,Beyond.SparkBuffer.Runtime.Wrapper.I2FloatMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Single>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Single>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000044
    public struct I2DoubleMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Double get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private System.Double GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, System.Double& value) { }
        private System.Double GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Double,Beyond.SparkBuffer.Runtime.Wrapper.I2DoubleMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Double>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Double>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000045
    public struct I2StringMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.String get_Item(System.Int32 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int32 key) { }
        private System.Int32 GetKeyByIndex(System.Int32 index) { }
        private System.String GetValue(System.Int32 key) { }
        private System.Boolean TryGetValue(System.Int32 key, System.String& value) { }
        private System.String GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.String,Beyond.SparkBuffer.Runtime.Wrapper.I2StringMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.String>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000046
    public struct L2BoolMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Boolean get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private System.Boolean GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, System.Boolean& value) { }
        private System.Boolean GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Boolean,Beyond.SparkBuffer.Runtime.Wrapper.L2BoolMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Boolean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Boolean>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000047
    public struct L2ByteMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Byte get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private System.Byte GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, System.Byte& value) { }
        private System.Byte GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Byte,Beyond.SparkBuffer.Runtime.Wrapper.L2ByteMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Byte>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Byte>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000048
    public struct L2IntMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private System.Int32 GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, System.Int32& value) { }
        private System.Int32 GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.L2IntMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Int32>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Int32>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000049
    public struct L2LongMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Int64 get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private System.Int64 GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, System.Int64& value) { }
        private System.Int64 GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Int64,Beyond.SparkBuffer.Runtime.Wrapper.L2LongMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Int64>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Int64>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200004A
    public struct L2FloatMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Single get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private System.Single GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, System.Single& value) { }
        private System.Single GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Single,Beyond.SparkBuffer.Runtime.Wrapper.L2FloatMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Single>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Single>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200004B
    public struct L2DoubleMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Double get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private System.Double GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, System.Double& value) { }
        private System.Double GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Double,Beyond.SparkBuffer.Runtime.Wrapper.L2DoubleMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Double>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Double>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200004C
    public struct L2StringMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.String get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private System.String GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, System.String& value) { }
        private System.String GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.String,Beyond.SparkBuffer.Runtime.Wrapper.L2StringMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.String>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200004D
    public struct L2EnumMap, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x10

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private System.Int32 GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, System.Int32& value) { }
        private System.Int32 GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.L2EnumMap> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Int32>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Int32>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200004E
    public struct L2NullableBeanMap`1, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x0
        private readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> m_creator;        // 0x0

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private System.Nullable<TBean> get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private System.Nullable<TBean> GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, System.Nullable<TBean>& value) { }
        private System.Nullable<TBean> GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Nullable<TBean>,Beyond.SparkBuffer.Runtime.Wrapper.L2NullableBeanMap<TBean>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Nullable<TBean>>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,TBean?>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200004F
    public struct L2BeanMap`1, IMapWrapper`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Beyond.SparkBuffer.Runtime.Map m_map;        // 0x0
        private readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> m_creator;        // 0x0

        // Methods
        private System.Int32 get_count() { }
        private System.Int32 get_Count() { }
        private TBean get_Item(System.Int64 key) { }
        private System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator) { }
        private System.Boolean ContainsKey(System.Int64 key) { }
        private System.Int64 GetKeyByIndex(System.Int32 index) { }
        private TBean GetValue(System.Int64 key) { }
        private System.Boolean TryGetValue(System.Int64 key, TBean& value) { }
        private TBean GetValueByIndex(System.Int32 index) { }
        private Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,TBean,Beyond.SparkBuffer.Runtime.Wrapper.L2BeanMap<TBean>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,TBean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,TBean>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

}

namespace Beyond.SparkBuffer.Serialize
{

    // TypeToken: 0x2000050
    public class Extensions
    {
        // Methods
        private System.Boolean Contains(System.Collections.Generic.IList<T> list, T element) { }
        private System.Boolean IsNullOrEmpty(System.Collections.Generic.IList<T> list) { }
        private System.Boolean IsNullOrEmpty(System.Collections.Generic.ICollection<T> list) { }
        private System.Boolean IsNullOrEmpty(System.Collections.Specialized.OrderedDictionary dict) { }
        private T[] ToArrayE(System.Collections.Generic.IEnumerable<T> enumerable) { }
        private T GetValue(System.Collections.DictionaryEntry entry) { }

    }

    // TypeToken: 0x2000051
    public class JsonSerializer
    {
        // Methods
        private Newtonsoft.Json.JsonSerializerSettings _GenerateJsonSettings(System.Boolean indented) { }
        private System.String Serialize(T obj, System.Boolean indented) { }
        private System.String Serialize(System.Object obj, System.Boolean indented) { }
        private System.Object _ConstructFromReflectObj(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject reflectObj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public class ObjectReflector
    {
        // Fields
        private System.Collections.Generic.List<System.Object> m_tempList;        // 0x10
        private System.Collections.Generic.Dictionary<System.Type,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType> m_typeMap;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectResult Parse(System.Object obj) { }
        private Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectResult _ParseInternal(System.Object obj) { }
        private Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType _ParseTypeMap(System.Type rootType) { }
        private System.Boolean _TryParseType(System.Type type, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType& reflectType) { }
        private Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject _ReflectObject(System.Object obj, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType reflectType) { }
        private Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject _ReflectBean(System.Object obj, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType reflectType) { }
        private Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject _ReflectArray(System.Object obj, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType reflectType) { }
        private Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject _ReflectMap(System.Object obj, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType reflectType) { }
        private System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> _GetFields(System.Type type) { }
        private System.Object[] _ConvertICollectionToArray(System.Collections.ICollection collection) { }

    }

    // TypeToken: 0x2000058
    public class SparkSerializer, IDisposable
    {
        // Fields
        private Beyond.SparkBuffer.Serialize.SparkSerializer.Options m_options;        // 0x10
        private System.IO.MemoryStream m_ms;        // 0x20
        private Beyond.SparkBuffer.Runtime.ByteWriter m_writer;        // 0x28
        private System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType> m_enumTypes;        // 0x30
        private System.Collections.Generic.Dictionary<System.Type,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType> m_beanMap;        // 0x38
        private System.Collections.Generic.Dictionary<System.Type,System.Int32> m_typeHashMap;        // 0x40
        private System.Collections.Generic.Dictionary<System.String,System.Int32> m_stringMap;        // 0x48

        // Methods
        private System.Byte[] Serialize(T obj) { }
        private System.Byte[] Serialize(T obj, Beyond.SparkBuffer.Serialize.SparkSerializer.Options options) { }
        private System.Byte[] Serialize(System.Object obj) { }
        private System.Byte[] Serialize(System.Object obj, Beyond.SparkBuffer.Serialize.SparkSerializer.Options options) { }
        private System.Void .ctor(Beyond.SparkBuffer.Serialize.SparkSerializer.Options options) { }
        private System.Void Dispose() { }
        private System.Byte[] _SerializeInternal(System.Object obj) { }
        private System.Void _PreprocessTypes(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType[] reflectTypes) { }
        private System.Void _ExportTypeDefs() { }
        private System.Void _ExportEnumType(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType enumType) { }
        private System.Void _ExportBeanType(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType beanType) { }
        private System.String _ParseTypeName(System.Type reflectType) { }
        private System.Collections.Generic.HashSet<System.String> _CollectAllStrings(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject rootObj) { }
        private System.Collections.Generic.List<System.Collections.Generic.List<System.String>> _GenStringHashList(System.Collections.Generic.HashSet<System.String> strings) { }
        private System.Void _ExportStrings(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject rootObj) { }
        private System.Void _ExportElementData(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject elementObj, System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.SparkSerializer.ReservedField> reservedFields) { }
        private System.Int32 _ExportBeanData(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject beanObj) { }
        private System.Int32 _ExportArrayData(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject arrayObj) { }
        private System.Int32 _ExportMapData(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject mapObj) { }
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject>>> _CreateMapHashEntry(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject>> mapElements, Beyond.SparkBuffer.SparkType keyType) { }
        private System.Void _ExportRootDef(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType rootType) { }
        private System.Int32 _ExportDataFromRoot(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject rootObj) { }
        private System.Void _ExportReservedFields(System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.SparkSerializer.ReservedField> reservedFields) { }
        private System.Int32 GetStableStringHash(System.String str) { }
        private System.Int32 GetStableTypeHash(System.Type type) { }
        private System.Void _WriteConcreteType(System.Type type) { }
        private System.Int32 <_ExportTypeDefs>b__17_0(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType lhs, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType rhs) { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000062
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.IntPtr __Gen_Wrap_0(System.Object P0) { }
        private System.IntPtr __Gen_Wrap_1(System.Int32 P0) { }
        private System.Void __Gen_Wrap_2(System.Int32 P0, System.IntPtr P1) { }
        private System.Void __Gen_Wrap_3() { }
        private System.String __Gen_Wrap_4() { }
        private System.Void __Gen_Wrap_5(System.Object P0, System.IntPtr P1) { }
        private Beyond.Reflection.StructPtrWrapper __Gen_Wrap_6(System.IntPtr P0, System.Int32 P1, System.Object P2) { }
        private Beyond.Reflection.StructPtrWrapper __Gen_Wrap_7(System.Object P0) { }
        private System.Void __Gen_Wrap_8(System.Object P0) { }
        private System.Object __Gen_Wrap_9(System.Object P0) { }
        private System.Object __Gen_Wrap_10(System.IntPtr P0, System.Object P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_11(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_12(System.Object P0) { }
        private System.Boolean __Gen_Wrap_13(System.Object P0, System.Object P1) { }
        private System.String __Gen_Wrap_14(System.Object P0) { }
        private System.Type __Gen_Wrap_15(System.Object P0) { }
        private Beyond.Reflection.StructPtrWrapper __Gen_Wrap_16() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000063
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000064
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

    // TypeToken: 0x2000065
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Reflection-MethodPointerManager-GetDelegatePointer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructMemManager-GetMemoryBySize0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructMemManager-FreeMemory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructMemManager-ClearMemory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructMemManager-DumpMemory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrRefrenceManager-_RunOnStart0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrRefrenceManager-AddObjInPtrRef0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrRefrenceManager-RemoveObjInPtrRef0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-GetStructPtrWrapper0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-GetStructPtrWrapper1;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-GetStructObj0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-GetStructObj1;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-SetStructObjValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-Equals0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-GetType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-GetStructObj2;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-_OnCreate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-_OnGet0;        // 0x0
        public static IFix.IDMAP0 Beyond-Reflection-StructPtrWrapper-_OnRealse0;        // 0x0

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

