// ========================================================
// Dumped by @desirepro
// Assembly: Google.FlatBuffers.dll
// Classes:  17
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnionForShort
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int16                    shortVal  // 0x10
  public            System.UInt16                   ushortVal  // 0x10
METHODS:
END_CLASS

CLASS: UnionForLong
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int64                    longVal  // 0x10
  public            System.Single                   floatValLow  // 0x10
  public            System.Single                   floatValHigh  // 0x14
METHODS:
END_CLASS

CLASS: Google.FlatBuffers.ByteData
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  private           System.Byte*                    _buffer  // 0x10
  private           System.Int32                    _length  // 0x18
METHODS:
  System.Byte* get_Buffer()
  System.Int32 get_Length()
  System.Boolean IsCreated()
  System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer)
  System.Span<System.Byte> get_Span()
  System.ReadOnlySpan<System.Byte> get_ReadOnlySpan()
  System.Span<T> ToSpan(T* ptr, System.Int32 length)
  System.ReadOnlySpan<T> ToReadOnlySpan(T* ptr, System.Int32 length)
END_CLASS

CLASS: Google.FlatBuffers.ByteBuffer
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  private           Google.FlatBuffers.ByteData     _buffer  // 0x10
  private           System.Int32                    _pos  // 0x20
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Int32>genericSizes  // 0x0
METHODS:
  System.Void .ctor(Google.FlatBuffers.ByteData allocator, System.Int32 position)
  System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer)
  System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer, System.Int32 pos)
  System.Boolean IsCreated()
  System.Int32 get_Position()
  System.Void set_Position(System.Int32 value)
  System.Int32 get_Length()
  System.Void Reset()
  Google.FlatBuffers.ByteBuffer Duplicate()
  System.Byte[] ToArray(System.Int32 pos, System.Int32 len)
  System.Int32 SizeOf()
  System.Boolean IsSupportedType()
  System.Int32 ArraySize(T[] x)
  System.Int32 ArraySize(System.ArraySegment<T> x)
  System.Int32 ArraySize(System.Span<T> x)
  System.ReadOnlySpan<T> ToSpanSlice(System.Int32 pos, System.Int32 count)
  T[] ToArray(System.Int32 pos, System.Int32 count)
  Unity.Collections.NativeArray<T> ToNativeArray(System.Int32 pos, System.Int32 count)
  System.Byte[] ToSizedArray()
  System.Byte[] ToFullArray()
  System.Span<System.Byte> ToSpan(System.Int32 pos, System.Int32 len)
  System.Byte* GetUnsafePtr()
  System.Void WriteLittleEndian(System.Int32 offset, System.Int32 count, System.UInt64 data)
  System.UInt64 ReadLittleEndian(System.Int32 offset, System.Int32 count)
  System.Void AssertOffsetAndLength(System.Int32 offset, System.Int32 length)
  System.Void PutSbyte(System.Int32 offset, System.SByte value)
  System.Void PutByte(System.Int32 offset, System.Byte value)
  System.Void PutByte(System.Int32 offset, System.Byte value, System.Int32 count)
  System.Void Put(System.Int32 offset, System.Byte value)
  System.Void PutStringUTF8(System.Int32 offset, System.String value)
  System.Void PutShort(System.Int32 offset, System.Int16 value)
  System.Void PutUshort(System.Int32 offset, System.UInt16 value)
  System.Void PutInt(System.Int32 offset, System.Int32 value)
  System.Void PutUint(System.Int32 offset, System.UInt32 value)
  System.Void PutLong(System.Int32 offset, System.Int64 value)
  System.Void PutUlong(System.Int32 offset, System.UInt64 value)
  System.Void PutFloat(System.Int32 offset, System.Single value)
  System.Void PutDouble(System.Int32 offset, System.Double value)
  System.SByte GetSbyte(System.Int32 index)
  System.Byte Get(System.Int32 index)
  System.String GetStringUTF8(System.Int32 startPos, System.Int32 len)
  System.Int16 GetShort(System.Int32 offset)
  System.UInt16 GetUshort(System.Int32 offset)
  System.Int32 GetInt(System.Int32 offset)
  System.UInt32 GetUint(System.Int32 offset)
  System.Int64 GetLong(System.Int32 offset)
  System.UInt64 GetUlong(System.Int32 offset)
  System.Single GetFloat(System.Int32 offset)
  System.Double GetDouble(System.Int32 offset)
  System.Int32 Put(System.Int32 offset, T[] x)
  System.Int32 Put(System.Int32 offset, System.ArraySegment<T> x)
  System.Int32 Put(System.Int32 offset, System.IntPtr ptr, System.Int32 sizeInBytes)
  System.Int32 Put(System.Int32 offset, System.Span<T> x)
  System.Void .cctor()
END_CLASS

CLASS: Google.FlatBuffers.ByteBufferUtil
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.Int32 GetSizePrefix(Google.FlatBuffers.ByteBuffer bb)
  Google.FlatBuffers.ByteBuffer RemoveSizePrefix(Google.FlatBuffers.ByteBuffer bb)
  System.Void .ctor()
END_CLASS

CLASS: Google.FlatBuffers.FlatBufferBuilder
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private           System.Int32                    _space  // 0x10
  private           Unity.Collections.NativeArray<System.Byte>_data  // 0x18
  private           Google.FlatBuffers.ByteBuffer   _bb  // 0x28
  private           System.Int32                    _minAlign  // 0x40
  private           System.Int32[]                  _vtable  // 0x48
  private           System.Int32                    _vtableSize  // 0x50
  private           System.Int32                    _objectStart  // 0x54
  private           System.Int32[]                  _vtables  // 0x58
  private           System.Int32                    _numVtables  // 0x60
  private           System.Int32                    _vectorNumElems  // 0x64
  private           System.Collections.Generic.Dictionary<System.String,Google.FlatBuffers.StringOffset>_sharedStringMap  // 0x68
  private           System.Boolean                  <ForceDefaults>k__BackingField  // 0x70
METHODS:
  System.Void .ctor(System.Int32 initialSize)
  System.Void Dispose()
  System.Void Clear()
  System.Boolean get_ForceDefaults()
  System.Void set_ForceDefaults(System.Boolean value)
  System.Int32 get_Offset()
  System.Void Pad(System.Int32 size)
  System.Void GrowBuffer()
  System.Void Prep(System.Int32 size, System.Int32 additionalBytes)
  System.Void PutBool(System.Boolean x)
  System.Void PutSbyte(System.SByte x)
  System.Void PutByte(System.Byte x)
  System.Void PutShort(System.Int16 x)
  System.Void PutUshort(System.UInt16 x)
  System.Void PutInt(System.Int32 x)
  System.Void PutUint(System.UInt32 x)
  System.Void PutLong(System.Int64 x)
  System.Void PutUlong(System.UInt64 x)
  System.Void PutFloat(System.Single x)
  System.Void Put(T[] x)
  System.Void Put(System.ArraySegment<T> x)
  System.Void Put(System.IntPtr ptr, System.Int32 sizeInBytes)
  System.Void Put(System.Span<T> x)
  System.Void PutDouble(System.Double x)
  System.Void AddBool(System.Boolean x)
  System.Void AddSbyte(System.SByte x)
  System.Void AddByte(System.Byte x)
  System.Void AddShort(System.Int16 x)
  System.Void AddUshort(System.UInt16 x)
  System.Void AddInt(System.Int32 x)
  System.Void AddUint(System.UInt32 x)
  System.Void AddLong(System.Int64 x)
  System.Void AddUlong(System.UInt64 x)
  System.Void AddFloat(System.Single x)
  System.Void Add(T[] x)
  System.Void Add(System.ArraySegment<T> x)
  System.Void Add(System.IntPtr ptr, System.Int32 sizeInBytes)
  System.Void Add(System.Span<T> x)
  System.Void AddDouble(System.Double x)
  System.Void AddOffset(System.Int32 off)
  System.Void StartVector(System.Int32 elemSize, System.Int32 count, System.Int32 alignment)
  Google.FlatBuffers.VectorOffset EndVector()
  Google.FlatBuffers.VectorOffset CreateVectorOfTables(Google.FlatBuffers.Offset<T>[] offsets)
  System.Void Nested(System.Int32 obj)
  System.Void NotNested()
  System.Void StartTable(System.Int32 numfields)
  System.Void Slot(System.Int32 voffset)
  System.Void AddBool(System.Int32 o, System.Boolean x, System.Boolean d)
  System.Void AddBool(System.Int32 o, System.Nullable<System.Boolean> x)
  System.Void AddSbyte(System.Int32 o, System.SByte x, System.SByte d)
  System.Void AddSbyte(System.Int32 o, System.Nullable<System.SByte> x)
  System.Void AddByte(System.Int32 o, System.Byte x, System.Byte d)
  System.Void AddByte(System.Int32 o, System.Nullable<System.Byte> x)
  System.Void AddShort(System.Int32 o, System.Int16 x, System.Int32 d)
  System.Void AddShort(System.Int32 o, System.Nullable<System.Int16> x)
  System.Void AddUshort(System.Int32 o, System.UInt16 x, System.UInt16 d)
  System.Void AddUshort(System.Int32 o, System.Nullable<System.UInt16> x)
  System.Void AddInt(System.Int32 o, System.Int32 x, System.Int32 d)
  System.Void AddInt(System.Int32 o, System.Nullable<System.Int32> x)
  System.Void AddUint(System.Int32 o, System.UInt32 x, System.UInt32 d)
  System.Void AddUint(System.Int32 o, System.Nullable<System.UInt32> x)
  System.Void AddLong(System.Int32 o, System.Int64 x, System.Int64 d)
  System.Void AddLong(System.Int32 o, System.Nullable<System.Int64> x)
  System.Void AddUlong(System.Int32 o, System.UInt64 x, System.UInt64 d)
  System.Void AddUlong(System.Int32 o, System.Nullable<System.UInt64> x)
  System.Void AddFloat(System.Int32 o, System.Single x, System.Double d)
  System.Void AddFloat(System.Int32 o, System.Nullable<System.Single> x)
  System.Void AddDouble(System.Int32 o, System.Double x, System.Double d)
  System.Void AddDouble(System.Int32 o, System.Nullable<System.Double> x)
  System.Void AddOffset(System.Int32 o, System.Int32 x, System.Int32 d)
  Google.FlatBuffers.StringOffset CreateString(System.String s)
  Google.FlatBuffers.StringOffset CreateUTF8String(System.Span<System.Byte> chars)
  Google.FlatBuffers.StringOffset CreateSharedString(System.String s)
  System.Void AddStruct(System.Int32 voffset, System.Int32 x, System.Int32 d)
  System.Int32 EndTable()
  System.Void Required(System.Int32 table, System.Int32 field)
  System.Void Finish(System.Int32 rootTable, System.Boolean sizePrefix)
  System.Void Finish(System.Int32 rootTable)
  System.Void FinishSizePrefixed(System.Int32 rootTable)
  Google.FlatBuffers.ByteBuffer get_DataBuffer()
  System.Byte[] SizedByteArray()
  System.Void Finish(System.Int32 rootTable, System.String fileIdentifier, System.Boolean sizePrefix)
  System.Void Finish(System.Int32 rootTable, System.String fileIdentifier)
  System.Void FinishSizePrefixed(System.Int32 rootTable, System.String fileIdentifier)
END_CLASS

CLASS: Google.FlatBuffers.FlatBufferConstants
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  public    static  System.Int32                    FileIdentifierLength  // 0x0
  public    static  System.Int32                    SizePrefixLength  // 0x0
METHODS:
  System.Void FLATBUFFERS_23_1_21()
END_CLASS

CLASS: Google.FlatBuffers.FlatBufferUtils
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Int16 ReinterpretAsShort(System.UInt16 val)
  System.UInt16 ReinterpretAsUShort(System.Int16 val)
  System.Void ReinterpretAsFloat(System.Int64 val, System.Single& floatValLow, System.Single& floatValHigh)
  System.Span<T> AsSpan(Unity.Collections.NativeArray<T> nativeArray)
  System.ReadOnlySpan<T> AsReadOnlySpan(Unity.Collections.NativeArray<T> nativeArray)
END_CLASS

CLASS: Google.FlatBuffers.IFlatbufferObject
TYPE:  interface
TOKEN: 0x200000C
FIELDS:
METHODS:
  System.Void __init(System.Int32 _i, Google.FlatBuffers.ByteBuffer _bb)
  Google.FlatBuffers.ByteBuffer get_ByteBuffer()
END_CLASS

CLASS: Google.FlatBuffers.Offset`1
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    Value  // 0x0
METHODS:
  System.Void .ctor(System.Int32 value)
END_CLASS

CLASS: Google.FlatBuffers.StringOffset
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    Value  // 0x10
METHODS:
  System.Void .ctor(System.Int32 value)
END_CLASS

CLASS: Google.FlatBuffers.VectorOffset
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    Value  // 0x10
METHODS:
  System.Void .ctor(System.Int32 value)
END_CLASS

CLASS: Google.FlatBuffers.Struct
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  private           System.Int32                    <bb_pos>k__BackingField  // 0x10
  private           Google.FlatBuffers.ByteBuffer   <bb>k__BackingField  // 0x18
METHODS:
  System.Int32 get_bb_pos()
  System.Void set_bb_pos(System.Int32 value)
  Google.FlatBuffers.ByteBuffer get_bb()
  System.Void set_bb(Google.FlatBuffers.ByteBuffer value)
  System.Void .ctor(System.Int32 _i, Google.FlatBuffers.ByteBuffer _bb)
END_CLASS

CLASS: Google.FlatBuffers.Table
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  private           System.Int32                    <bb_pos>k__BackingField  // 0x10
  private           Google.FlatBuffers.ByteBuffer   <bb>k__BackingField  // 0x18
METHODS:
  System.Int32 get_bb_pos()
  System.Void set_bb_pos(System.Int32 value)
  Google.FlatBuffers.ByteBuffer get_bb()
  System.Void set_bb(Google.FlatBuffers.ByteBuffer value)
  Google.FlatBuffers.ByteBuffer get_ByteBuffer()
  System.Void .ctor(System.Int32 _i, Google.FlatBuffers.ByteBuffer _bb)
  System.Int32 __offset(System.Int32 vtableOffset)
  System.Int32 __offset(System.Int32 vtableOffset, System.Int32 offset, Google.FlatBuffers.ByteBuffer bb)
  System.Int32 __indirect(System.Int32 offset)
  System.Int32 __indirect(System.Int32 offset, Google.FlatBuffers.ByteBuffer bb)
  System.String __string(System.Int32 offset)
  System.Int32 __vector_len(System.Int32 offset)
  System.Int32 __vector(System.Int32 offset)
  System.Span<T> __vector_as_span(System.Int32 offset, System.Int32 elementSize)
  T[] __vector_as_array(System.Int32 offset)
  T __union(System.Int32 offset)
  System.Boolean __has_identifier(Google.FlatBuffers.ByteBuffer bb, System.String ident)
  System.Int32 CompareStrings(System.Int32 offset_1, System.Int32 offset_2, Google.FlatBuffers.ByteBuffer bb)
  System.Int32 CompareStrings(System.Int32 offset_1, System.Byte[] key, Google.FlatBuffers.ByteBuffer bb)
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

