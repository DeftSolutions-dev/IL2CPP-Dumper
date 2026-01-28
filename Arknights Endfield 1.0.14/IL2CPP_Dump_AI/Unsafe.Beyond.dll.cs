// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.Beyond.dll
// Classes:  101
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnionKey
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    intKey  // 0x10
  public            System.Int64                    longKey  // 0x18
  public            System.String                   stringKey  // 0x20
METHODS:
  System.Void .ctor(System.Int32 key)
  System.Void .ctor(System.Int64 key)
  System.Void .ctor(System.String key)
END_CLASS

CLASS: UnionKeyEnumerator
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_parent  // 0x10
  private           System.Int32                    m_index  // 0x58
  private           System.Int32                    m_currentSlotIndex  // 0x5C
  private           System.Int32                    m_currentSlotStartIndex  // 0x60
  private           Beyond.SparkBuffer.Runtime.Wrapper.HashSlotm_currentSlot  // 0x64
METHODS:
  Beyond.SparkBuffer.Runtime.Map.UnionKey get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map parent)
  System.Boolean MoveNext()
  System.Void Dispose()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: Options
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.String                   rootName  // 0x10
  public            Beyond.SparkBuffer.SparkType    rootType  // 0x18
  public            Beyond.SparkBuffer.SparkType    subType1  // 0x19
  public            Beyond.SparkBuffer.SparkType    subType2  // 0x1A
  public            Beyond.SparkBuffer.Runtime.BeanTypebeanType  // 0x20
  public            Beyond.SparkBuffer.Runtime.EnumTypeenumType  // 0x28
  public            Beyond.SparkBuffer.Runtime.EnumTypemapKeyEnumType  // 0x30
METHODS:
END_CLASS

CLASS: ReservedField
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    position  // 0x10
  public            Newtonsoft.Json.Linq.JToken     token  // 0x18
  public            Beyond.SparkBuffer.SparkType    type  // 0x20
  public            Beyond.SparkBuffer.Runtime.BeanTypebeanType  // 0x28
  public            Beyond.SparkBuffer.Runtime.ArrayTypearrayType  // 0x30
  public            Beyond.SparkBuffer.Runtime.MapTypemapType  // 0x48
METHODS:
END_CLASS

CLASS: JsonLoader
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private           Beyond.SparkBuffer.Runtime.ByteWriterm_writer  // 0x10
  private           System.Collections.Generic.Dictionary<System.String,System.Int32>m_stringMap  // 0x18
METHODS:
  System.Void .ctor(Beyond.SparkBuffer.Runtime.ByteWriter writer)
  System.Void Dispose()
  System.Void PopulateJsonDataWithoutTypeAndRootDef(Beyond.SparkBuffer.Runtime.ByteWriter writer, Newtonsoft.Json.Linq.JToken rootObj, Beyond.SparkBuffer.Runtime.Root.Options rootOptions, System.Int32& dataOffset)
  System.Void _LoadJsonContentWithoutTypeAndRootDef(Newtonsoft.Json.Linq.JToken rootObj, Beyond.SparkBuffer.Runtime.Root.Options rootOptions, System.Int32& dataOffset)
  System.Void _ExportStrings(Newtonsoft.Json.Linq.JToken rootJson, Beyond.SparkBuffer.Runtime.Root.Options rootOptions)
  System.Void _CollectBeanStrings(System.Collections.Generic.HashSet<System.String> stringSet, Newtonsoft.Json.Linq.JObject obj, Beyond.SparkBuffer.Runtime.BeanType beanType)
  System.Void _CollectArrayStrings(System.Collections.Generic.HashSet<System.String> stringSet, Newtonsoft.Json.Linq.JArray obj, Beyond.SparkBuffer.Runtime.ArrayType arrayType)
  System.Void _CollectMapStrings(System.Collections.Generic.HashSet<System.String> stringSet, Newtonsoft.Json.Linq.JObject obj, Beyond.SparkBuffer.Runtime.MapType mapType)
  System.Int32 _ExportRootData(Newtonsoft.Json.Linq.JToken rootJson, Beyond.SparkBuffer.Runtime.Root.Options rootOptions)
  System.Int32 _ExportBeanData(Newtonsoft.Json.Linq.JObject beanObj, Beyond.SparkBuffer.Runtime.BeanType beanType)
  System.Int32 _ExportArrayData(Newtonsoft.Json.Linq.JArray arrayObj, Beyond.SparkBuffer.Runtime.ArrayType arrayType)
  System.Int32 _ExportMapData(Newtonsoft.Json.Linq.JObject mapObj, Beyond.SparkBuffer.Runtime.MapType mapType)
  System.Void _ExportReservedFields(System.Collections.Generic.List<Beyond.SparkBuffer.Runtime.SparkManager.JsonLoader.ReservedField> reservedFields)
  System.Void _ExportStringByLoc(System.String strVal)
  System.Void _ExportEnumData(Newtonsoft.Json.Linq.JToken token, Beyond.SparkBuffer.Runtime.EnumType enumType)
  System.Void _ExportCommonDataOrThrow(Newtonsoft.Json.Linq.JToken token, Beyond.SparkBuffer.SparkType type, System.Collections.Generic.List<Beyond.SparkBuffer.Runtime.SparkManager.JsonLoader.ReservedField> reservedFields)
  System.Void _EnsureJTokenType(Newtonsoft.Json.Linq.JToken token, Newtonsoft.Json.Linq.JTokenType requiredType)
  System.Exception _InvalidRootTypeError(Beyond.SparkBuffer.SparkType rootType)
END_CLASS

CLASS: EnumItem
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Int32                    value  // 0x18
METHODS:
END_CLASS

CLASS: ReflectResult
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType[]types  // 0x10
  public            Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObjectrootObj  // 0x18
METHODS:
END_CLASS

CLASS: FieldInfo
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  public            System.String                   name  // 0x10
  public            Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectTypetype  // 0x18
METHODS:
END_CLASS

CLASS: ReflectType
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  public            Beyond.SparkBuffer.SparkType    sparkType  // 0x10
  public            System.Type                     concreteType  // 0x18
  public            Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectTypesubType1  // 0x20
  public            Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectTypesubType2  // 0x28
  public            System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType.FieldInfo>beanFields  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ReflectObject
TYPE:  class
TOKEN: 0x2000056
FIELDS:
  public            System.Object                   originObj  // 0x10
  public            Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectTypereflectType  // 0x18
  public            System.Collections.Specialized.OrderedDictionarybeanElements  // 0x20
  public            System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject>arrayElements  // 0x28
  public            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject>>mapElements  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ReservedField
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            System.Int32                    position  // 0x10
  public            Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObjectreflectObj  // 0x18
METHODS:
END_CLASS

CLASS: Options
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public    static readonly Beyond.SparkBuffer.Serialize.SparkSerializer.OptionsDEFAULT  // 0x0
  public            System.String                   rootName  // 0x10
  public            System.String                   stripTypeNamePrefix  // 0x18
METHODS:
  System.Void .ctor(System.String rootName)
  System.Void .ctor(System.String rootName, System.String stripTypeNamePrefix)
  System.Void .cctor()
END_CLASS

CLASS: HashSlot
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public            System.Int32                    offset  // 0x10
  public            System.Int32                    bucketsSize  // 0x14
METHODS:
END_CLASS

CLASS: Beyond.Reflection.MethodPointerManager
TYPE:  class
TOKEN: 0x200005D
FIELDS:
METHODS:
  T2 CallPointer(System.IntPtr ptr, T1 param)
  TRet CallDelegatePointer(System.IntPtr ptr, TParam1 target)
  TRet CallDelegatePointer(System.IntPtr ptr, TParam1 target, TParam2 param)
  System.ValueTuple<System.IntPtr,T1> GetDelegatePointer(System.Delegate d)
  System.IntPtr GetDelegatePointer(System.Reflection.MethodInfo d)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Reflection.ObjectPointerHelper
TYPE:  class
TOKEN: 0x200005E
FIELDS:
METHODS:
  System.IntPtr GetIntPtr(T& value)
  System.IntPtr GetArrayPtr(T[] value)
  T GetStructByPointer(System.IntPtr ptr)
  T GetValue(System.IntPtr ptr, System.Int32 offset)
  T GetArrayElement(System.IntPtr array, System.Int32 index)
  System.Void SetValue(System.IntPtr ptr, System.Int32 offset, T value)
  System.Void SetValue(System.IntPtr ptr, System.Int32 offset, System.Byte* data, System.Int32 size)
  System.Object GetObj(System.IntPtr ptr, System.Int32 offset)
  System.Void SetObj(System.IntPtr ptr, System.Int32 offset, System.Object value)
  System.Void CopyValue(System.IntPtr target, System.IntPtr source, System.Int32 size)
  System.Void CopyValue(System.Void* target, System.Void* source, System.Int32 size)
  System.Void CopyValue(System.Byte* to, System.Byte* from, System.Int32 size)
END_CLASS

CLASS: Beyond.Reflection.StructMemManager
TYPE:  class
TOKEN: 0x200005F
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.ValueTuple<System.Collections.Generic.HashSet<System.Int64>,System.Collections.Generic.List<System.IntPtr>>>s_structMemDict  // 0x0
METHODS:
  System.IntPtr GetMemoryBySize(System.Int32 size)
  System.Void FreeMemory(System.Int32 size, System.IntPtr ptr)
  System.Void ClearMemory()
  System.String DumpMemory()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Reflection.StructPtrRefrenceManager
TYPE:  class
TOKEN: 0x2000060
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Object,System.Object>s_refDic  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<System.Int32>>s_structPtrOffsetDic  // 0x8
METHODS:
  System.Void _RunOnStart()
  System.Void AddObjInPtrRef(System.Type type, System.IntPtr ptr)
  System.Void RemoveObjInPtrRef(System.Type type, System.IntPtr ptr)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Reflection.StructPtrWrapper
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  public            System.IntPtr                   ptr  // 0x10
  public            System.Int32                    size  // 0x18
  public            System.Type                     type  // 0x20
  private   static  UnityEngine.Pool.ObjectPool<Beyond.Reflection.StructPtrWrapper>s_pool  // 0x0
  private   static  System.IntPtr                   s_ptr  // 0x8
  private   static  System.Int32                    s_size  // 0x10
  private   static  System.Type                     s_type  // 0x18
  private   static  System.Object                   s_structObj  // 0x20
METHODS:
  Beyond.Reflection.StructPtrWrapper GetStructPtrWrapper(System.IntPtr ptr, System.Int32 size, System.Type type)
  Beyond.Reflection.StructPtrWrapper GetStructPtrWrapper(System.Object structObj)
  System.Void Release(Beyond.Reflection.StructPtrWrapper obj)
  System.Void .ctor(System.IntPtr ptr, System.Int32 size, System.Type type)
  System.Object GetStructObj()
  System.Object GetStructObj(System.IntPtr ptr, System.Type type, System.Int32 size)
  System.Void SetStructObjValue(System.Object structObj)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.Type GetType()
  System.Object GetStructObj(Beyond.Reflection.StructPtrWrapper obj)
  System.Void .ctor(System.Object structObj)
  Beyond.Reflection.StructPtrWrapper _OnCreate()
  System.Void _OnGet(Beyond.Reflection.StructPtrWrapper o)
  System.Void _OnRealse(Beyond.Reflection.StructPtrWrapper obj)
  System.Void .cctor()
  System.Int32 <>iFixBaseProxy_GetHashCode()
  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.SparkBuffer.SparkType
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.SparkBuffer.SparkType    Bool  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    Byte  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    Int  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    Long  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    Float  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    Double  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    Enum  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    String  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    Bean  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    Array  // 0x0
  public    static  Beyond.SparkBuffer.SparkType    Map  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.SparkBuffer.Common
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  public    static  System.Int32                    NULL_PLACEHOLDER  // 0x0
  public    static  System.Int32                    BOOL_MEM_SIZE  // 0x0
  public    static  System.Int32                    BYTE_MEM_SIZE  // 0x0
  public    static  System.Int32                    INT_MEM_SIZE  // 0x0
  public    static  System.Int32                    LONG_MEM_SIZE  // 0x0
  public    static  System.Int32                    FLOAT_MEM_SIZE  // 0x0
  public    static  System.Int32                    DOUBLE_MEM_SIZE  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.SparkBuffer.Utils
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.Int32 Align4Bytes(System.Int32 position)
  System.Int32 Align8Bytes(System.Int32 position)
  System.Int32 AlignBytesForSize(System.Int32 position, System.Int32 size)
  System.Int32 GetMemSizeForType(Beyond.SparkBuffer.SparkType sparkType)
  System.Int32 GetFieldOffset(Beyond.SparkBuffer.SparkType sparkType, System.Int32& postion)
  System.Boolean IsEnumOrBean(Beyond.SparkBuffer.SparkType sparkType)
  System.Boolean IsArrayOrMap(Beyond.SparkBuffer.SparkType sparkType)
  System.Boolean CheckValidMapKeyType(Beyond.SparkBuffer.SparkType sparkType)
  System.Boolean CheckValidRootType(Beyond.SparkBuffer.SparkType sparkType)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.ByteReader
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private           Unity.Collections.NativeArray<System.Byte>m_buffer  // 0x10
  private           System.Byte*                    m_bufferPtr  // 0x20
  private           System.Int32                    m_position  // 0x28
  private   readonly System.Int32                    m_length  // 0x2C
  public    static  Beyond.SparkBuffer.Runtime.IStringPools_stringPool  // 0x0
  public    static  System.Action<System.IntPtr>    s_freeMemory  // 0x8
  public    static  System.Func<System.Byte[],System.IntPtr>s_mallocMemory  // 0x10
METHODS:
  System.Int32 get_position()
  Unity.Collections.NativeArray<System.Byte> get_buffer()
  System.Void .ctor(System.Byte[] buffer)
  System.Void Dispose()
  System.Void SeekTo(System.Int32 pos)
  System.Boolean ReadBool()
  System.Byte ReadByte()
  System.Int32 ReadInt()
  System.Int64 ReadLong()
  System.Single ReadFloat()
  System.Double ReadDouble()
  System.String ReadString()
  Beyond.SparkBuffer.Runtime.Wrapper.HashSlot ReadHashSlot()
  Beyond.SparkBuffer.SparkType ReadSparkType()
  System.Int32 ReadTypeHash()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.ByteWriter
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private   static readonly System.Byte[]                   BUFFER_0  // 0x0
  private   readonly System.IO.BinaryWriter          m_writer  // 0x10
  private   readonly System.IO.Stream                m_stream  // 0x18
  public    static  Beyond.SparkBuffer.Runtime.IStringPools_stringPool  // 0x8
METHODS:
  System.Int32 get_position()
  System.Void .ctor(System.IO.Stream stream)
  System.Void Dispose()
  System.Void SeekTo(System.Int32 pos)
  System.Void WriteBool(System.Boolean v)
  System.Void WriteByte(System.Byte v)
  System.Void WriteInt(System.Int32 v)
  System.Void WriteLong(System.Int64 v)
  System.Void WriteFloat(System.Single v)
  System.Void WriteDouble(System.Double v)
  System.Void WriteStringAlignment(System.String v)
  System.Void WriteString(System.String v)
  System.Void WriteBytes(System.ReadOnlySpan<System.Byte> buffer, System.Int32 index, System.Int32 count)
  System.Void WriteSparkType(Beyond.SparkBuffer.SparkType sparkType)
  System.Int32 FillAlignment(System.Int32 align)
  System.Void _FillAlignment4()
  System.Void _FillAlignment8()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Array
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.ArrayTypem_arrayType  // 0x10
  private   readonly Beyond.SparkBuffer.Runtime.Root m_root  // 0x28
  private   readonly System.Int32                    m_dataOffset  // 0x30
  private   readonly System.Int32                    m_length  // 0x34
METHODS:
  System.Int32 get_length()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.ArrayType arrayType, System.Int32 offset, Beyond.SparkBuffer.Runtime.Root root)
  System.Boolean GetBool(System.Int32 index)
  System.Byte GetByte(System.Int32 index)
  System.Int32 GetInt(System.Int32 index)
  System.Int64 GetLong(System.Int32 index)
  System.Single GetFloat(System.Int32 index)
  System.Double GetDouble(System.Int32 index)
  System.String GetString(System.Int32 index)
  System.Int32 GetEnum(System.Int32 index)
  System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.Int32 index)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Bean
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.BeanTypem_beanType  // 0x10
  private   readonly Beyond.SparkBuffer.Runtime.Root m_root  // 0x18
  private   readonly System.Int32                    m_dataOffset  // 0x20
METHODS:
  System.Void .ctor(Beyond.SparkBuffer.Runtime.BeanType beanType, System.Int32 offset, Beyond.SparkBuffer.Runtime.Root root)
  System.Boolean GetBool(System.String key, System.Int32& offset)
  System.Boolean GetBool(System.Int32 offset)
  System.Byte GetByte(System.String key, System.Int32& offset)
  System.Byte GetByte(System.Int32 offset)
  System.Int32 GetInt(System.String key, System.Int32& offset)
  System.Int32 GetInt(System.Int32 offset)
  System.Int64 GetLong(System.String key, System.Int32& offset)
  System.Int64 GetLong(System.Int32 offset)
  System.Single GetFloat(System.String key, System.Int32& offset)
  System.Single GetFloat(System.Int32 offset)
  System.Double GetDouble(System.String key, System.Int32& offset)
  System.Double GetDouble(System.Int32 offset)
  System.String GetString(System.String key, System.Int32& offset)
  System.String GetString(System.Int32 offset)
  System.Int32 GetEnum(System.String key, System.Int32& offset)
  System.Int32 GetEnum(System.Int32 offset)
  System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.String key)
  System.Nullable<Beyond.SparkBuffer.Runtime.Array> GetArray(System.String key)
  System.Nullable<Beyond.SparkBuffer.Runtime.Map> GetMap(System.String key)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Map
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  private   static  System.Int32                    INT_KEY_MEM_SIZE  // 0x0
  private   static  System.Int32                    LONG_KEY_MEM_SIZE  // 0x0
  private   readonly Beyond.SparkBuffer.Runtime.MapTypem_mapType  // 0x10
  private   readonly Beyond.SparkBuffer.Runtime.Root m_root  // 0x38
  private   readonly System.Int32                    m_valueMemSize  // 0x40
  private   readonly System.Int32                    m_keyMemSize  // 0x44
  private   readonly System.Int32                    m_dataOffset  // 0x48
  private   readonly System.Int32                    m_count  // 0x4C
  private   readonly System.Int32                    m_slotsOffset  // 0x50
METHODS:
  System.Int32 get_count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.MapType mapType, System.Int32 offset, Beyond.SparkBuffer.Runtime.Root root)
  Beyond.SparkBuffer.Runtime.Map.UnionKeyEnumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<Beyond.SparkBuffer.Runtime.Map.UnionKey> System.Collections.Generic.IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 GetHash(System.String str)
  System.Int32 GetHash(System.Int32 value)
  System.Int32 GetHash(System.Int64 value)
  Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(System.Int32 slotIndex)
  System.Int32 _FindHashIndexByKey(System.Int32 intKey)
  System.Int32 _FindHashIndexByKey(System.Int64 longKey)
  System.Int32 _FindHashIndexByKey(System.String stringKey)
  System.Int32 GetIntKeyByIndex(System.Int32 index)
  System.Int64 GetLongKeyByIndex(System.Int32 index)
  System.String GetStringKeyByIndex(System.Int32 index)
  System.Int32 GetIntKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, System.Int32 localIndex)
  System.Int64 GetLongKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, System.Int32 localIndex)
  System.String GetStringKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, System.Int32 localIndex)
  System.Boolean ContainsKey(System.String key)
  System.Boolean GetBool(System.String key)
  System.Boolean TryGetBool(System.String key, System.Boolean& value)
  System.Byte GetByte(System.String key)
  System.Boolean TryGetByte(System.String key, System.Byte& value)
  System.Int32 GetInt(System.String key)
  System.Boolean TryGetInt(System.String key, System.Int32& value)
  System.Int64 GetLong(System.String key)
  System.Boolean TryGetLong(System.String key, System.Int64& value)
  System.Single GetFloat(System.String key)
  System.Boolean TryGetFloat(System.String key, System.Single& value)
  System.Double GetDouble(System.String key)
  System.Boolean TryGetDouble(System.String key, System.Double& value)
  System.String GetString(System.String key)
  System.Boolean TryGetString(System.String key, System.String& value)
  System.Int32 GetEnum(System.String key)
  System.Boolean TryGetEnum(System.String key, System.Int32& value)
  System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.String key)
  System.Boolean TryGetBean(System.String key, System.Nullable<Beyond.SparkBuffer.Runtime.Bean>& bean)
  System.Boolean ContainsKey(System.Int32 key)
  System.Boolean GetBool(System.Int32 key)
  System.Boolean TryGetBool(System.Int32 key, System.Boolean& value)
  System.Byte GetByte(System.Int32 key)
  System.Boolean TryGetByte(System.Int32 key, System.Byte& value)
  System.Int32 GetInt(System.Int32 key)
  System.Boolean TryGetInt(System.Int32 key, System.Int32& value)
  System.Int64 GetLong(System.Int32 key)
  System.Boolean TryGetLong(System.Int32 key, System.Int64& value)
  System.Single GetFloat(System.Int32 key)
  System.Boolean TryGetFloat(System.Int32 key, System.Single& value)
  System.Double GetDouble(System.Int32 key)
  System.Boolean TryGetDouble(System.Int32 key, System.Double& value)
  System.String GetString(System.Int32 key)
  System.Boolean TryGetString(System.Int32 key, System.String& value)
  System.Int32 GetEnum(System.Int32 key)
  System.Boolean TryGetEnum(System.Int32 key, System.Int32& value)
  System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.Int32 key)
  System.Boolean TryGetBean(System.Int32 key, System.Nullable<Beyond.SparkBuffer.Runtime.Bean>& bean)
  System.Boolean ContainsKey(System.Int64 key)
  System.Boolean GetBool(System.Int64 key)
  System.Boolean TryGetBool(System.Int64 key, System.Boolean& value)
  System.Byte GetByte(System.Int64 key)
  System.Boolean TryGetByte(System.Int64 key, System.Byte& value)
  System.Int32 GetInt(System.Int64 key)
  System.Boolean TryGetInt(System.Int64 key, System.Int32& value)
  System.Int64 GetLong(System.Int64 key)
  System.Boolean TryGetLong(System.Int64 key, System.Int64& value)
  System.Single GetFloat(System.Int64 key)
  System.Boolean TryGetFloat(System.Int64 key, System.Single& value)
  System.Double GetDouble(System.Int64 key)
  System.Boolean TryGetDouble(System.Int64 key, System.Double& value)
  System.String GetString(System.Int64 key)
  System.Boolean TryGetString(System.Int64 key, System.String& value)
  System.Int32 GetEnum(System.Int64 key)
  System.Boolean TryGetEnum(System.Int64 key, System.Int32& value)
  System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.Int64 key)
  System.Boolean TryGetBean(System.Int64 key, System.Nullable<Beyond.SparkBuffer.Runtime.Bean>& bean)
  System.Boolean GetBoolByIndex(System.Int32 index)
  System.Byte GetByteByIndex(System.Int32 index)
  System.Int32 GetIntByIndex(System.Int32 index)
  System.Int64 GetLongByIndex(System.Int32 index)
  System.Single GetFloatByIndex(System.Int32 index)
  System.Double GetDoubleByIndex(System.Int32 index)
  System.String GetStringByIndex(System.Int32 index)
  System.Int32 GetEnumByIndex(System.Int32 index)
  System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBeanByIndex(System.Int32 index)
  System.Int32 _GetOffsetByIndex(System.Int32 index)
  System.Boolean GetBoolByOffset(System.Int32 offset)
  System.Byte GetByteByOffset(System.Int32 offset)
  System.Int32 GetIntByOffset(System.Int32 offset)
  System.Int64 GetLongByOffset(System.Int32 offset)
  System.Single GetFloatByOffset(System.Int32 offset)
  System.Double GetDoubleByOffset(System.Int32 offset)
  System.String GetStringByOffset(System.Int32 offset)
  System.Int32 GetEnumByOffset(System.Int32 offset)
  System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBeanByOffset(System.Int32 offset)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Root
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private           Beyond.SparkBuffer.Runtime.ByteReaderm_reader  // 0x10
  private   readonly Beyond.SparkBuffer.Runtime.Root.Optionsm_options  // 0x18
  private   readonly System.Int32                    m_dataOffset  // 0x40
  private           System.Collections.Generic.Dictionary<System.Int32,System.String>m_cachedString  // 0x48
METHODS:
  System.String get_name()
  Unity.Collections.NativeArray<System.Byte> get_bytes()
  System.Void .ctor(System.Int32 dataOffset, Beyond.SparkBuffer.Runtime.Root.Options options, Beyond.SparkBuffer.Runtime.ByteReader reader)
  System.Void Finalize()
  System.String ToString()
  System.Void Dispose()
  System.Boolean IsValid()
  System.Nullable<Beyond.SparkBuffer.Runtime.Bean> AsBean()
  System.Nullable<Beyond.SparkBuffer.Runtime.Array> AsArray()
  System.Nullable<Beyond.SparkBuffer.Runtime.Map> AsMap()
  System.Int32 GetCurReaderPosition()
  System.Boolean GetBool(System.Int32 offset)
  System.Byte GetByte(System.Int32 offset)
  System.Int32 GetInt(System.Int32 offset)
  System.Int64 GetLong(System.Int32 offset)
  System.Single GetFloat(System.Int32 offset)
  System.Double GetDouble(System.Int32 offset)
  System.Int32 GetEnum(System.Int32 offset)
  System.String GetString(System.Int32 offset)
  System.Nullable<Beyond.SparkBuffer.Runtime.Bean> GetBean(System.Int32 offset, Beyond.SparkBuffer.Runtime.BeanType beanType)
  System.Nullable<Beyond.SparkBuffer.Runtime.Array> GetArray(System.Int32 offset, Beyond.SparkBuffer.Runtime.ArrayType arrayType)
  System.Nullable<Beyond.SparkBuffer.Runtime.Map> GetMap(System.Int32 offset, Beyond.SparkBuffer.Runtime.MapType mapType)
  Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(System.Int32 offset)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Error
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Exception TypeNotFoundError(System.Int32 typeHash, Beyond.SparkBuffer.SparkType sparkType)
  System.Exception InvalidTypeError(Beyond.SparkBuffer.SparkType sparkType)
  System.Exception InvalidMapKeyError(Beyond.SparkBuffer.SparkType sparkType)
  System.Exception NullTypeError(Beyond.SparkBuffer.SparkType sparkType)
  System.Exception GetEndOfFile()
  System.Exception SeekAheadOfFile()
  System.Exception DisposedException()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.SparkManager
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.SparkBuffer.Runtime.BeanType>m_beanTypeMap  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.SparkBuffer.Runtime.EnumType>m_enumTypeMap  // 0x18
  protected readonly System.Collections.Generic.Dictionary<System.String,Beyond.SparkBuffer.Runtime.Root>m_namedRoots  // 0x20
  private   readonly System.Collections.Generic.List<Beyond.SparkBuffer.Runtime.Root>m_anonymousRoots  // 0x28
  private   readonly System.Collections.Generic.Queue<Beyond.SparkBuffer.Runtime.BeanType>m_beanTypeQueue  // 0x30
METHODS:
  System.Void .ctor()
  Beyond.SparkBuffer.Runtime.Root Load(System.Byte[] bytes, System.String overrideRootName)
  Beyond.SparkBuffer.Runtime.Root Load(System.Byte[] bytes)
  Beyond.SparkBuffer.Runtime.Root LoadFromJson_EditorOnly(System.Byte[] bytes, Newtonsoft.Json.Linq.JToken jsonData, System.String overrideRootName)
  Beyond.SparkBuffer.Runtime.Root LoadFromJson_EditorOnly(System.Byte[] bytes, Newtonsoft.Json.Linq.JToken jsonData)
  System.Boolean Unload(Beyond.SparkBuffer.Runtime.Root root)
  System.Void UnloadAndClearAll()
  System.Boolean TryGetEnumType(System.Int32 typeHash, Beyond.SparkBuffer.Runtime.EnumType& enumType)
  System.Boolean TryGetBeanType(System.Int32 typeHash, Beyond.SparkBuffer.Runtime.BeanType& beanType)
  System.Boolean _AddRoot(Beyond.SparkBuffer.Runtime.Root root)
  System.Void _ReadTypeDefs(Beyond.SparkBuffer.Runtime.ByteReader reader)
  Beyond.SparkBuffer.Runtime.Root.Options _ReadRootDef(Beyond.SparkBuffer.Runtime.ByteReader reader, System.String overrideRootName)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.RuntimeSparkManager
TYPE:  class
TOKEN: 0x2000014
EXTENDS: SparkManager
FIELDS:
  private   static  Beyond.SparkBuffer.Runtime.RuntimeSparkManagers_instance  // 0x0
  private           System.Action<Beyond.SparkBuffer.Runtime.Root>m_onRootLoaded  // 0x38
  private           System.Action<Beyond.SparkBuffer.Runtime.Root>m_onRootUnloaded  // 0x40
  private           System.Action                   m_onUnloadAll  // 0x48
  private   static  System.String                   LUADLL  // 0x0
METHODS:
  Beyond.SparkBuffer.Runtime.RuntimeSparkManager get_instance()
  System.Void .ctor()
  System.Boolean Unload(Beyond.SparkBuffer.Runtime.Root root)
  System.Void UnloadAndClearAll()
  System.Boolean LuaSpark_LoadRoot(System.IntPtr L, System.String rootName, System.IntPtr data, System.Int32 size)
  System.Boolean LuaSpark_UnloadRoot(System.IntPtr L, System.String rootName)
  System.Void LuaSpark_UnloadAll(System.IntPtr L)
  System.Void RegisterToLua(System.IntPtr L)
  System.Void UnregisterFromLua(System.IntPtr L)
  System.Boolean _AddRoot(Beyond.SparkBuffer.Runtime.Root root)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.IStringPool
TYPE:  interface
TOKEN: 0x2000016
FIELDS:
METHODS:
  System.Int32 AddString(System.String str)
  System.String GetString(System.Int32 index)
  System.Void Clear()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Field
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private   readonly System.String                   <name>k__BackingField  // 0x10
  private   readonly System.Int32                    <offset>k__BackingField  // 0x18
METHODS:
  System.String get_name()
  System.Int32 get_offset()
  Beyond.SparkBuffer.SparkType get_type()
  System.Void .ctor(System.String fieldName, System.Int32 fieldOffset)
  System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader)
  System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.SimpleField
TYPE:  class
TOKEN: 0x2000018
EXTENDS: Field
FIELDS:
  private   readonly Beyond.SparkBuffer.SparkType    <type>k__BackingField  // 0x20
METHODS:
  Beyond.SparkBuffer.SparkType get_type()
  System.Void .ctor(Beyond.SparkBuffer.SparkType type, System.String fieldName, System.Int32 fieldOffset)
  System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader)
  System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.EnumField
TYPE:  class
TOKEN: 0x2000019
EXTENDS: Field
FIELDS:
  private           System.Int32                    m_typeHash  // 0x20
  private           Beyond.SparkBuffer.Runtime.EnumTypem_enumType  // 0x28
METHODS:
  Beyond.SparkBuffer.SparkType get_type()
  Beyond.SparkBuffer.Runtime.EnumType get_enumType()
  System.Void .ctor(System.String fieldName, System.Int32 fieldOffset)
  System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader)
  System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.BeanField
TYPE:  class
TOKEN: 0x200001A
EXTENDS: Field
FIELDS:
  private           System.Int32                    m_typeHash  // 0x20
  private           Beyond.SparkBuffer.Runtime.BeanTypem_beanType  // 0x28
METHODS:
  Beyond.SparkBuffer.SparkType get_type()
  Beyond.SparkBuffer.Runtime.BeanType get_beanType()
  System.Void .ctor(System.String fieldName, System.Int32 fieldOffset)
  System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader)
  System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.ArrayField
TYPE:  class
TOKEN: 0x200001B
EXTENDS: Field
FIELDS:
  private           Beyond.SparkBuffer.Runtime.ArrayTypem_arrayType  // 0x20
  private           System.Int32                    m_elementTypeHash  // 0x38
METHODS:
  Beyond.SparkBuffer.SparkType get_type()
  Beyond.SparkBuffer.Runtime.ArrayType get_arrayType()
  System.Void .ctor(System.String fieldName, System.Int32 fieldOffset)
  System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader)
  System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.MapField
TYPE:  class
TOKEN: 0x200001C
EXTENDS: Field
FIELDS:
  private           Beyond.SparkBuffer.Runtime.MapTypem_mapInfo  // 0x20
  private           System.Int32                    m_keyTypeHash  // 0x48
  private           System.Int32                    m_valueTypeHash  // 0x4C
METHODS:
  Beyond.SparkBuffer.SparkType get_type()
  Beyond.SparkBuffer.Runtime.MapType get_mapType()
  System.Void .ctor(System.String fieldName, System.Int32 fieldOffset)
  System.Void Unmarshal(Beyond.SparkBuffer.Runtime.ByteReader reader)
  System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.ArrayType
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            Beyond.SparkBuffer.SparkType    elementType  // 0x10
  public            Beyond.SparkBuffer.Runtime.BeanTypeelementBeanType  // 0x18
  public            Beyond.SparkBuffer.Runtime.EnumTypeelementEnumType  // 0x20
METHODS:
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.MapType
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            Beyond.SparkBuffer.SparkType    keyType  // 0x10
  public            Beyond.SparkBuffer.Runtime.EnumTypekeyEnumType  // 0x18
  public            Beyond.SparkBuffer.SparkType    valueType  // 0x20
  public            Beyond.SparkBuffer.Runtime.BeanTypevalueBeanType  // 0x28
  public            Beyond.SparkBuffer.Runtime.EnumTypevalueEnumType  // 0x30
METHODS:
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.EnumType
TYPE:  class
TOKEN: 0x200001F
FIELDS:
  private           System.Collections.Generic.List<Beyond.SparkBuffer.Runtime.EnumType.EnumItem>m_enums  // 0x10
  private           System.Int32                    <typeHash>k__BackingField  // 0x18
  private           System.String                   <name>k__BackingField  // 0x20
METHODS:
  System.Int32 get_typeHash()
  System.Void set_typeHash(System.Int32 value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.ByteReader reader)
  System.Boolean TryGetValue(System.String enumName, System.Int32& enumVal)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.BeanType
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,Beyond.SparkBuffer.Runtime.Field>m_fields  // 0x10
  private           System.Int32                    <typeHash>k__BackingField  // 0x18
  private           System.String                   <name>k__BackingField  // 0x20
METHODS:
  System.Int32 get_typeHash()
  System.Void set_typeHash(System.Int32 value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.ByteReader reader)
  System.String ToString()
  System.Void Resolve(Beyond.SparkBuffer.Runtime.SparkManager manager)
  System.Boolean TryGetField(System.String fieldName, Beyond.SparkBuffer.Runtime.Field& field)
  System.Collections.Generic.Dictionary.Enumerator<System.String,Beyond.SparkBuffer.Runtime.Field> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Beyond.SparkBuffer.Runtime.Field>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Beyond.SparkBuffer.Runtime.Field>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  Beyond.SparkBuffer.Runtime.Field _NewField(System.String name, Beyond.SparkBuffer.SparkType type, System.Int32 offset)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.IArrayWrapper`1
TYPE:  interface
TOKEN: 0x2000022
FIELDS:
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  T get_Item(System.Int32 index)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator`2
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  private   readonly TArray                          m_parent  // 0x0
  private           System.Int32                    m_index  // 0x0
METHODS:
  TElement get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void .ctor(TArray parent)
  System.Boolean MoveNext()
  System.Void Dispose()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.NullableBeanArray`1
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x0
  private           System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean>m_creator  // 0x0
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator)
  System.Nullable<TBean> get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Nullable<TBean>,Beyond.SparkBuffer.Runtime.Wrapper.NullableBeanArray<TBean>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Nullable<TBean>> System.Collections.Generic.IEnumerable<TBean?>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.BeanArray`1
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x0
  private           System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean>m_creator  // 0x0
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator)
  TBean get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<TBean,Beyond.SparkBuffer.Runtime.Wrapper.BeanArray<TBean>> GetEnumerator()
  System.Collections.Generic.IEnumerator<TBean> System.Collections.Generic.IEnumerable<TBean>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.EnumArray`1
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x0
  private           System.Func<System.Int32,TEnum> m_converter  // 0x0
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array, System.Func<System.Int32,TEnum> converter)
  TEnum get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<TEnum,Beyond.SparkBuffer.Runtime.Wrapper.EnumArray<TEnum>> GetEnumerator()
  TEnum[] ToArray()
  System.Boolean Contains(TEnum item)
  System.Collections.Generic.IEnumerator<TEnum> System.Collections.Generic.IEnumerable<TEnum>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.BoolArray
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x10
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array)
  System.Boolean get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Boolean,Beyond.SparkBuffer.Runtime.Wrapper.BoolArray> GetEnumerator()
  System.Boolean[] ToArray()
  System.Boolean Contains(System.Boolean item)
  System.Collections.Generic.IEnumerator<System.Boolean> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.ByteArray
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x10
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array)
  System.Byte get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Byte,Beyond.SparkBuffer.Runtime.Wrapper.ByteArray> GetEnumerator()
  System.Byte[] ToArray()
  System.Boolean Contains(System.Byte item)
  System.Collections.Generic.IEnumerator<System.Byte> System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.IntArray
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x10
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array)
  System.Int32 get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.IntArray> GetEnumerator()
  System.Int32[] ToArray()
  System.Boolean Contains(System.Int32 item)
  System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.LongArray
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x10
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array)
  System.Int64 get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Int64,Beyond.SparkBuffer.Runtime.Wrapper.LongArray> GetEnumerator()
  System.Int64[] ToArray()
  System.Boolean Contains(System.Int64 item)
  System.Collections.Generic.IEnumerator<System.Int64> System.Collections.Generic.IEnumerable<System.Int64>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.FloatArray
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x10
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array)
  System.Single get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Single,Beyond.SparkBuffer.Runtime.Wrapper.FloatArray> GetEnumerator()
  System.Single[] ToArray()
  System.Collections.Generic.IEnumerator<System.Single> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.DoubleArray
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x10
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array)
  System.Double get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.Double,Beyond.SparkBuffer.Runtime.Wrapper.DoubleArray> GetEnumerator()
  System.Double[] ToArray()
  System.Collections.Generic.IEnumerator<System.Double> System.Collections.Generic.IEnumerable<System.Double>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.StringArray
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  private           Beyond.SparkBuffer.Runtime.Arraym_array  // 0x10
METHODS:
  System.Int32 get_length()
  System.Int32 get_Count()
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Array array)
  System.String get_Item(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.ArrayEnumerator<System.String,Beyond.SparkBuffer.Runtime.Wrapper.StringArray> GetEnumerator()
  System.String[] ToArray()
  System.Boolean Contains(System.String item)
  System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.IBeanWrapper
TYPE:  interface
TOKEN: 0x200002E
FIELDS:
METHODS:
  System.Void SetBean(Beyond.SparkBuffer.Runtime.Bean& bean)
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.HashSlot
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int32                    offset  // 0x10
  public            System.Int32                    bucketsSize  // 0x14
  public    static readonly System.Int32                    size  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.IMapWrapper`3
TYPE:  interface
TOKEN: 0x2000030
FIELDS:
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  TValue get_Item(TKey key)
  System.Boolean ContainsKey(TKey key)
  TValue GetValue(TKey key)
  System.Boolean TryGetValue(TKey key, TValue& value)
  TKey GetKeyByIndex(System.Int32 index)
  TValue GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<TKey,TValue,TMap> GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator`3
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  private   readonly TMap                            m_parent  // 0x0
  private           System.Int32                    m_index  // 0x0
METHODS:
  System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void .ctor(TMap parent)
  System.Boolean MoveNext()
  System.Void Dispose()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2NullableBeanMap`1
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x0
  private   readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean>m_creator  // 0x0
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Nullable<TBean> get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  System.Nullable<TBean> GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, System.Nullable<TBean>& value)
  System.Nullable<TBean> GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Nullable<TBean>,Beyond.SparkBuffer.Runtime.Wrapper.S2NullableBeanMap<TBean>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Nullable<TBean>>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TBean?>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2BeanMap`1
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x0
  private   readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean>m_creator  // 0x0
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  TBean get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  TBean GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, TBean& value)
  TBean GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,TBean,Beyond.SparkBuffer.Runtime.Wrapper.S2BeanMap<TBean>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,TBean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TBean>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2EnumMap`1
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x0
  private           System.Func<System.Int32,TEnum> m_converter  // 0x0
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  TEnum get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<System.Int32,TEnum> converter)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  TEnum GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, TEnum& value)
  TEnum GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,TEnum,Beyond.SparkBuffer.Runtime.Wrapper.S2EnumMap<TEnum>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,TEnum>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TEnum>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2BoolMap
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Boolean get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  System.Boolean GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, System.Boolean& value)
  System.Boolean GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Boolean,Beyond.SparkBuffer.Runtime.Wrapper.S2BoolMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Boolean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Boolean>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2ByteMap
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Byte get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  System.Byte GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, System.Byte& value)
  System.Byte GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Byte,Beyond.SparkBuffer.Runtime.Wrapper.S2ByteMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Byte>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Byte>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2IntMap
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Int32 get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  System.Int32 GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, System.Int32& value)
  System.Int32 GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.S2IntMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Int32>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2LongMap
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Int64 get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  System.Int64 GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, System.Int64& value)
  System.Int64 GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Int64,Beyond.SparkBuffer.Runtime.Wrapper.S2LongMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Int64>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Int64>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2FloatMap
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Single get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  System.Single GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, System.Single& value)
  System.Single GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Single,Beyond.SparkBuffer.Runtime.Wrapper.S2FloatMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Single>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Single>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2DoubleMap
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Double get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  System.Double GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, System.Double& value)
  System.Double GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.Double,Beyond.SparkBuffer.Runtime.Wrapper.S2DoubleMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Double>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Double>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.S2StringMap
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.String get_Item(System.String key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.String key)
  System.String GetKeyByIndex(System.Int32 index)
  System.String GetValue(System.String key)
  System.Boolean TryGetValue(System.String key, System.String& value)
  System.String GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.String,System.String,Beyond.SparkBuffer.Runtime.Wrapper.S2StringMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2NullableBeanMap`1
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x0
  private   readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean>m_creator  // 0x0
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Nullable<TBean> get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  System.Nullable<TBean> GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, System.Nullable<TBean>& value)
  System.Nullable<TBean> GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Nullable<TBean>,Beyond.SparkBuffer.Runtime.Wrapper.I2NullableBeanMap<TBean>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Nullable<TBean>>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,TBean?>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2BeanMap`1
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x0
  private   readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean>m_creator  // 0x0
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  TBean get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  TBean GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, TBean& value)
  TBean GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,TBean,Beyond.SparkBuffer.Runtime.Wrapper.I2BeanMap<TBean>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,TBean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,TBean>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2EnumMap`1
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x0
  private           System.Func<System.Int32,TEnum> m_converter  // 0x0
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  TEnum get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<System.Int32,TEnum> converter)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  TEnum GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, TEnum& value)
  TEnum GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,TEnum,Beyond.SparkBuffer.Runtime.Wrapper.I2EnumMap<TEnum>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,TEnum>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,TEnum>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2BoolMap
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Boolean get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  System.Boolean GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, System.Boolean& value)
  System.Boolean GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Boolean,Beyond.SparkBuffer.Runtime.Wrapper.I2BoolMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Boolean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Boolean>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2ByteMap
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Byte get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  System.Byte GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, System.Byte& value)
  System.Byte GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Byte,Beyond.SparkBuffer.Runtime.Wrapper.I2ByteMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Byte>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Byte>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2IntMap
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Int32 get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  System.Int32 GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, System.Int32& value)
  System.Int32 GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.I2IntMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2LongMap
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Int64 get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  System.Int64 GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, System.Int64& value)
  System.Int64 GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Int64,Beyond.SparkBuffer.Runtime.Wrapper.I2LongMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Int64>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int64>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2FloatMap
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Single get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  System.Single GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, System.Single& value)
  System.Single GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Single,Beyond.SparkBuffer.Runtime.Wrapper.I2FloatMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Single>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Single>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2DoubleMap
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Double get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  System.Double GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, System.Double& value)
  System.Double GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.Double,Beyond.SparkBuffer.Runtime.Wrapper.I2DoubleMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Double>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Double>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.I2StringMap
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.String get_Item(System.Int32 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int32 key)
  System.Int32 GetKeyByIndex(System.Int32 index)
  System.String GetValue(System.Int32 key)
  System.Boolean TryGetValue(System.Int32 key, System.String& value)
  System.String GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int32,System.String,Beyond.SparkBuffer.Runtime.Wrapper.I2StringMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.String>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2BoolMap
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Boolean get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  System.Boolean GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, System.Boolean& value)
  System.Boolean GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Boolean,Beyond.SparkBuffer.Runtime.Wrapper.L2BoolMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Boolean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Boolean>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2ByteMap
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Byte get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  System.Byte GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, System.Byte& value)
  System.Byte GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Byte,Beyond.SparkBuffer.Runtime.Wrapper.L2ByteMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Byte>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Byte>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2IntMap
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Int32 get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  System.Int32 GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, System.Int32& value)
  System.Int32 GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.L2IntMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Int32>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Int32>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2LongMap
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Int64 get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  System.Int64 GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, System.Int64& value)
  System.Int64 GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Int64,Beyond.SparkBuffer.Runtime.Wrapper.L2LongMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Int64>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Int64>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2FloatMap
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Single get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  System.Single GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, System.Single& value)
  System.Single GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Single,Beyond.SparkBuffer.Runtime.Wrapper.L2FloatMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Single>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Single>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2DoubleMap
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Double get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  System.Double GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, System.Double& value)
  System.Double GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Double,Beyond.SparkBuffer.Runtime.Wrapper.L2DoubleMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Double>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Double>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2StringMap
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.String get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  System.String GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, System.String& value)
  System.String GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.String,Beyond.SparkBuffer.Runtime.Wrapper.L2StringMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.String>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2EnumMap
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x10
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Int32 get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  System.Int32 GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, System.Int32& value)
  System.Int32 GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Int32,Beyond.SparkBuffer.Runtime.Wrapper.L2EnumMap> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Int32>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,System.Int32>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2NullableBeanMap`1
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x0
  private   readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean>m_creator  // 0x0
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  System.Nullable<TBean> get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  System.Nullable<TBean> GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, System.Nullable<TBean>& value)
  System.Nullable<TBean> GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,System.Nullable<TBean>,Beyond.SparkBuffer.Runtime.Wrapper.L2NullableBeanMap<TBean>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Nullable<TBean>>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,TBean?>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Runtime.Wrapper.L2BeanMap`1
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  private   readonly Beyond.SparkBuffer.Runtime.Map  m_map  // 0x0
  private   readonly System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean>m_creator  // 0x0
METHODS:
  System.Int32 get_count()
  System.Int32 get_Count()
  TBean get_Item(System.Int64 key)
  System.Void .ctor(Beyond.SparkBuffer.Runtime.Map map, System.Func<Beyond.SparkBuffer.Runtime.Bean,TBean> creator)
  System.Boolean ContainsKey(System.Int64 key)
  System.Int64 GetKeyByIndex(System.Int32 index)
  TBean GetValue(System.Int64 key)
  System.Boolean TryGetValue(System.Int64 key, TBean& value)
  TBean GetValueByIndex(System.Int32 index)
  Beyond.SparkBuffer.Runtime.Wrapper.MapEnumerator<System.Int64,TBean,Beyond.SparkBuffer.Runtime.Wrapper.L2BeanMap<TBean>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,TBean>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,TBean>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Beyond.SparkBuffer.Serialize.Extensions
TYPE:  class
TOKEN: 0x2000050
FIELDS:
METHODS:
  System.Boolean Contains(System.Collections.Generic.IList<T> list, T element)
  System.Boolean IsNullOrEmpty(System.Collections.Generic.IList<T> list)
  System.Boolean IsNullOrEmpty(System.Collections.Generic.ICollection<T> list)
  System.Boolean IsNullOrEmpty(System.Collections.Specialized.OrderedDictionary dict)
  T[] ToArrayE(System.Collections.Generic.IEnumerable<T> enumerable)
  T GetValue(System.Collections.DictionaryEntry entry)
END_CLASS

CLASS: Beyond.SparkBuffer.Serialize.JsonSerializer
TYPE:  class
TOKEN: 0x2000051
FIELDS:
METHODS:
  Newtonsoft.Json.JsonSerializerSettings _GenerateJsonSettings(System.Boolean indented)
  System.String Serialize(T obj, System.Boolean indented)
  System.String Serialize(System.Object obj, System.Boolean indented)
  System.Object _ConstructFromReflectObj(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject reflectObj)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SparkBuffer.Serialize.ObjectReflector
TYPE:  class
TOKEN: 0x2000052
FIELDS:
  private           System.Collections.Generic.List<System.Object>m_tempList  // 0x10
  private           System.Collections.Generic.Dictionary<System.Type,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType>m_typeMap  // 0x18
METHODS:
  System.Void .ctor()
  Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectResult Parse(System.Object obj)
  Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectResult _ParseInternal(System.Object obj)
  Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType _ParseTypeMap(System.Type rootType)
  System.Boolean _TryParseType(System.Type type, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType& reflectType)
  Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject _ReflectObject(System.Object obj, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType reflectType)
  Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject _ReflectBean(System.Object obj, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType reflectType)
  Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject _ReflectArray(System.Object obj, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType reflectType)
  Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject _ReflectMap(System.Object obj, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType reflectType)
  System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> _GetFields(System.Type type)
  System.Object[] _ConvertICollectionToArray(System.Collections.ICollection collection)
END_CLASS

CLASS: Beyond.SparkBuffer.Serialize.SparkSerializer
TYPE:  class
TOKEN: 0x2000058
FIELDS:
  private           Beyond.SparkBuffer.Serialize.SparkSerializer.Optionsm_options  // 0x10
  private           System.IO.MemoryStream          m_ms  // 0x20
  private           Beyond.SparkBuffer.Runtime.ByteWriterm_writer  // 0x28
  private           System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType>m_enumTypes  // 0x30
  private           System.Collections.Generic.Dictionary<System.Type,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType>m_beanMap  // 0x38
  private           System.Collections.Generic.Dictionary<System.Type,System.Int32>m_typeHashMap  // 0x40
  private           System.Collections.Generic.Dictionary<System.String,System.Int32>m_stringMap  // 0x48
METHODS:
  System.Byte[] Serialize(T obj)
  System.Byte[] Serialize(T obj, Beyond.SparkBuffer.Serialize.SparkSerializer.Options options)
  System.Byte[] Serialize(System.Object obj)
  System.Byte[] Serialize(System.Object obj, Beyond.SparkBuffer.Serialize.SparkSerializer.Options options)
  System.Void .ctor(Beyond.SparkBuffer.Serialize.SparkSerializer.Options options)
  System.Void Dispose()
  System.Byte[] _SerializeInternal(System.Object obj)
  System.Void _PreprocessTypes(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType[] reflectTypes)
  System.Void _ExportTypeDefs()
  System.Void _ExportEnumType(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType enumType)
  System.Void _ExportBeanType(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType beanType)
  System.String _ParseTypeName(System.Type reflectType)
  System.Collections.Generic.HashSet<System.String> _CollectAllStrings(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject rootObj)
  System.Collections.Generic.List<System.Collections.Generic.List<System.String>> _GenStringHashList(System.Collections.Generic.HashSet<System.String> strings)
  System.Void _ExportStrings(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject rootObj)
  System.Void _ExportElementData(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject elementObj, System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.SparkSerializer.ReservedField> reservedFields)
  System.Int32 _ExportBeanData(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject beanObj)
  System.Int32 _ExportArrayData(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject arrayObj)
  System.Int32 _ExportMapData(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject mapObj)
  System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject>>> _CreateMapHashEntry(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject,Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject>> mapElements, Beyond.SparkBuffer.SparkType keyType)
  System.Void _ExportRootDef(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType rootType)
  System.Int32 _ExportDataFromRoot(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectObject rootObj)
  System.Void _ExportReservedFields(System.Collections.Generic.List<Beyond.SparkBuffer.Serialize.SparkSerializer.ReservedField> reservedFields)
  System.Int32 GetStableStringHash(System.String str)
  System.Int32 GetStableTypeHash(System.Type type)
  System.Void _WriteConcreteType(System.Type type)
  System.Int32 <_ExportTypeDefs>b__17_0(Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType lhs, Beyond.SparkBuffer.Serialize.ObjectReflector.ReflectType rhs)
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000062
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.IntPtr __Gen_Wrap_0(System.Object P0)
  System.IntPtr __Gen_Wrap_1(System.Int32 P0)
  System.Void __Gen_Wrap_2(System.Int32 P0, System.IntPtr P1)
  System.Void __Gen_Wrap_3()
  System.String __Gen_Wrap_4()
  System.Void __Gen_Wrap_5(System.Object P0, System.IntPtr P1)
  Beyond.Reflection.StructPtrWrapper __Gen_Wrap_6(System.IntPtr P0, System.Int32 P1, System.Object P2)
  Beyond.Reflection.StructPtrWrapper __Gen_Wrap_7(System.Object P0)
  System.Void __Gen_Wrap_8(System.Object P0)
  System.Object __Gen_Wrap_9(System.Object P0)
  System.Object __Gen_Wrap_10(System.IntPtr P0, System.Object P1, System.Int32 P2)
  System.Void __Gen_Wrap_11(System.Object P0, System.Object P1)
  System.Int32 __Gen_Wrap_12(System.Object P0)
  System.Boolean __Gen_Wrap_13(System.Object P0, System.Object P1)
  System.String __Gen_Wrap_14(System.Object P0)
  System.Type __Gen_Wrap_15(System.Object P0)
  Beyond.Reflection.StructPtrWrapper __Gen_Wrap_16()
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000063
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000064
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
TOKEN: 0x2000065
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Reflection-MethodPointerManager-GetDelegatePointer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructMemManager-GetMemoryBySize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructMemManager-FreeMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructMemManager-ClearMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructMemManager-DumpMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrRefrenceManager-_RunOnStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrRefrenceManager-AddObjInPtrRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrRefrenceManager-RemoveObjInPtrRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-GetStructPtrWrapper0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-GetStructPtrWrapper1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-Release0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-GetStructObj0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-GetStructObj1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-SetStructObjValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-Equals0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-GetType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-GetStructObj2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-_OnCreate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-_OnGet0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Reflection-StructPtrWrapper-_OnRealse0  // 0x0
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

