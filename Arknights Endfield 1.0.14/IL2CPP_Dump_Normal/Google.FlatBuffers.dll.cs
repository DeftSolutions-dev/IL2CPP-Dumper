// ========================================================
// Dumped by @desirepro
// Assembly: Google.FlatBuffers.dll
// Classes:  17
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000A
    public struct UnionForShort
    {
        // Fields
        public System.Int16 shortVal;        // 0x10
        public System.UInt16 ushortVal;        // 0x10

    }

    // TypeToken: 0x200000B
    public struct UnionForLong
    {
        // Fields
        public System.Int64 longVal;        // 0x10
        public System.Single floatValLow;        // 0x10
        public System.Single floatValHigh;        // 0x14

    }

namespace Google.FlatBuffers
{

    // TypeToken: 0x2000004
    public struct ByteData
    {
        // Fields
        private System.Byte* _buffer;        // 0x10
        private System.Int32 _length;        // 0x18

        // Methods
        private System.Byte* get_Buffer() { }
        private System.Int32 get_Length() { }
        private System.Boolean IsCreated() { }
        private System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer) { }
        private System.Span<System.Byte> get_Span() { }
        private System.ReadOnlySpan<System.Byte> get_ReadOnlySpan() { }
        private System.Span<T> ToSpan(T* ptr, System.Int32 length) { }
        private System.ReadOnlySpan<T> ToReadOnlySpan(T* ptr, System.Int32 length) { }

    }

    // TypeToken: 0x2000005
    public struct ByteBuffer
    {
        // Fields
        private Google.FlatBuffers.ByteData _buffer;        // 0x10
        private System.Int32 _pos;        // 0x20
        private static System.Collections.Generic.Dictionary<System.Type,System.Int32> genericSizes;        // 0x0

        // Methods
        private System.Void .ctor(Google.FlatBuffers.ByteData allocator, System.Int32 position) { }
        private System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer) { }
        private System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer, System.Int32 pos) { }
        private System.Boolean IsCreated() { }
        private System.Int32 get_Position() { }
        private System.Void set_Position(System.Int32 value) { }
        private System.Int32 get_Length() { }
        private System.Void Reset() { }
        private Google.FlatBuffers.ByteBuffer Duplicate() { }
        private System.Byte[] ToArray(System.Int32 pos, System.Int32 len) { }
        private System.Int32 SizeOf() { }
        private System.Boolean IsSupportedType() { }
        private System.Int32 ArraySize(T[] x) { }
        private System.Int32 ArraySize(System.ArraySegment<T> x) { }
        private System.Int32 ArraySize(System.Span<T> x) { }
        private System.ReadOnlySpan<T> ToSpanSlice(System.Int32 pos, System.Int32 count) { }
        private T[] ToArray(System.Int32 pos, System.Int32 count) { }
        private Unity.Collections.NativeArray<T> ToNativeArray(System.Int32 pos, System.Int32 count) { }
        private System.Byte[] ToSizedArray() { }
        private System.Byte[] ToFullArray() { }
        private System.Span<System.Byte> ToSpan(System.Int32 pos, System.Int32 len) { }
        private System.Byte* GetUnsafePtr() { }
        private System.Void WriteLittleEndian(System.Int32 offset, System.Int32 count, System.UInt64 data) { }
        private System.UInt64 ReadLittleEndian(System.Int32 offset, System.Int32 count) { }
        private System.Void AssertOffsetAndLength(System.Int32 offset, System.Int32 length) { }
        private System.Void PutSbyte(System.Int32 offset, System.SByte value) { }
        private System.Void PutByte(System.Int32 offset, System.Byte value) { }
        private System.Void PutByte(System.Int32 offset, System.Byte value, System.Int32 count) { }
        private System.Void Put(System.Int32 offset, System.Byte value) { }
        private System.Void PutStringUTF8(System.Int32 offset, System.String value) { }
        private System.Void PutShort(System.Int32 offset, System.Int16 value) { }
        private System.Void PutUshort(System.Int32 offset, System.UInt16 value) { }
        private System.Void PutInt(System.Int32 offset, System.Int32 value) { }
        private System.Void PutUint(System.Int32 offset, System.UInt32 value) { }
        private System.Void PutLong(System.Int32 offset, System.Int64 value) { }
        private System.Void PutUlong(System.Int32 offset, System.UInt64 value) { }
        private System.Void PutFloat(System.Int32 offset, System.Single value) { }
        private System.Void PutDouble(System.Int32 offset, System.Double value) { }
        private System.SByte GetSbyte(System.Int32 index) { }
        private System.Byte Get(System.Int32 index) { }
        private System.String GetStringUTF8(System.Int32 startPos, System.Int32 len) { }
        private System.Int16 GetShort(System.Int32 offset) { }
        private System.UInt16 GetUshort(System.Int32 offset) { }
        private System.Int32 GetInt(System.Int32 offset) { }
        private System.UInt32 GetUint(System.Int32 offset) { }
        private System.Int64 GetLong(System.Int32 offset) { }
        private System.UInt64 GetUlong(System.Int32 offset) { }
        private System.Single GetFloat(System.Int32 offset) { }
        private System.Double GetDouble(System.Int32 offset) { }
        private System.Int32 Put(System.Int32 offset, T[] x) { }
        private System.Int32 Put(System.Int32 offset, System.ArraySegment<T> x) { }
        private System.Int32 Put(System.Int32 offset, System.IntPtr ptr, System.Int32 sizeInBytes) { }
        private System.Int32 Put(System.Int32 offset, System.Span<T> x) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000006
    public class ByteBufferUtil
    {
        // Methods
        private System.Int32 GetSizePrefix(Google.FlatBuffers.ByteBuffer bb) { }
        private Google.FlatBuffers.ByteBuffer RemoveSizePrefix(Google.FlatBuffers.ByteBuffer bb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class FlatBufferBuilder, IDisposable
    {
        // Fields
        private System.Int32 _space;        // 0x10
        private Unity.Collections.NativeArray<System.Byte> _data;        // 0x18
        private Google.FlatBuffers.ByteBuffer _bb;        // 0x28
        private System.Int32 _minAlign;        // 0x40
        private System.Int32[] _vtable;        // 0x48
        private System.Int32 _vtableSize;        // 0x50
        private System.Int32 _objectStart;        // 0x54
        private System.Int32[] _vtables;        // 0x58
        private System.Int32 _numVtables;        // 0x60
        private System.Int32 _vectorNumElems;        // 0x64
        private System.Collections.Generic.Dictionary<System.String,Google.FlatBuffers.StringOffset> _sharedStringMap;        // 0x68
        private System.Boolean <ForceDefaults>k__BackingField;        // 0x70

        // Methods
        private System.Void .ctor(System.Int32 initialSize) { }
        private System.Void Dispose() { }
        private System.Void Clear() { }
        private System.Boolean get_ForceDefaults() { }
        private System.Void set_ForceDefaults(System.Boolean value) { }
        private System.Int32 get_Offset() { }
        private System.Void Pad(System.Int32 size) { }
        private System.Void GrowBuffer() { }
        private System.Void Prep(System.Int32 size, System.Int32 additionalBytes) { }
        private System.Void PutBool(System.Boolean x) { }
        private System.Void PutSbyte(System.SByte x) { }
        private System.Void PutByte(System.Byte x) { }
        private System.Void PutShort(System.Int16 x) { }
        private System.Void PutUshort(System.UInt16 x) { }
        private System.Void PutInt(System.Int32 x) { }
        private System.Void PutUint(System.UInt32 x) { }
        private System.Void PutLong(System.Int64 x) { }
        private System.Void PutUlong(System.UInt64 x) { }
        private System.Void PutFloat(System.Single x) { }
        private System.Void Put(T[] x) { }
        private System.Void Put(System.ArraySegment<T> x) { }
        private System.Void Put(System.IntPtr ptr, System.Int32 sizeInBytes) { }
        private System.Void Put(System.Span<T> x) { }
        private System.Void PutDouble(System.Double x) { }
        private System.Void AddBool(System.Boolean x) { }
        private System.Void AddSbyte(System.SByte x) { }
        private System.Void AddByte(System.Byte x) { }
        private System.Void AddShort(System.Int16 x) { }
        private System.Void AddUshort(System.UInt16 x) { }
        private System.Void AddInt(System.Int32 x) { }
        private System.Void AddUint(System.UInt32 x) { }
        private System.Void AddLong(System.Int64 x) { }
        private System.Void AddUlong(System.UInt64 x) { }
        private System.Void AddFloat(System.Single x) { }
        private System.Void Add(T[] x) { }
        private System.Void Add(System.ArraySegment<T> x) { }
        private System.Void Add(System.IntPtr ptr, System.Int32 sizeInBytes) { }
        private System.Void Add(System.Span<T> x) { }
        private System.Void AddDouble(System.Double x) { }
        private System.Void AddOffset(System.Int32 off) { }
        private System.Void StartVector(System.Int32 elemSize, System.Int32 count, System.Int32 alignment) { }
        private Google.FlatBuffers.VectorOffset EndVector() { }
        private Google.FlatBuffers.VectorOffset CreateVectorOfTables(Google.FlatBuffers.Offset<T>[] offsets) { }
        private System.Void Nested(System.Int32 obj) { }
        private System.Void NotNested() { }
        private System.Void StartTable(System.Int32 numfields) { }
        private System.Void Slot(System.Int32 voffset) { }
        private System.Void AddBool(System.Int32 o, System.Boolean x, System.Boolean d) { }
        private System.Void AddBool(System.Int32 o, System.Nullable<System.Boolean> x) { }
        private System.Void AddSbyte(System.Int32 o, System.SByte x, System.SByte d) { }
        private System.Void AddSbyte(System.Int32 o, System.Nullable<System.SByte> x) { }
        private System.Void AddByte(System.Int32 o, System.Byte x, System.Byte d) { }
        private System.Void AddByte(System.Int32 o, System.Nullable<System.Byte> x) { }
        private System.Void AddShort(System.Int32 o, System.Int16 x, System.Int32 d) { }
        private System.Void AddShort(System.Int32 o, System.Nullable<System.Int16> x) { }
        private System.Void AddUshort(System.Int32 o, System.UInt16 x, System.UInt16 d) { }
        private System.Void AddUshort(System.Int32 o, System.Nullable<System.UInt16> x) { }
        private System.Void AddInt(System.Int32 o, System.Int32 x, System.Int32 d) { }
        private System.Void AddInt(System.Int32 o, System.Nullable<System.Int32> x) { }
        private System.Void AddUint(System.Int32 o, System.UInt32 x, System.UInt32 d) { }
        private System.Void AddUint(System.Int32 o, System.Nullable<System.UInt32> x) { }
        private System.Void AddLong(System.Int32 o, System.Int64 x, System.Int64 d) { }
        private System.Void AddLong(System.Int32 o, System.Nullable<System.Int64> x) { }
        private System.Void AddUlong(System.Int32 o, System.UInt64 x, System.UInt64 d) { }
        private System.Void AddUlong(System.Int32 o, System.Nullable<System.UInt64> x) { }
        private System.Void AddFloat(System.Int32 o, System.Single x, System.Double d) { }
        private System.Void AddFloat(System.Int32 o, System.Nullable<System.Single> x) { }
        private System.Void AddDouble(System.Int32 o, System.Double x, System.Double d) { }
        private System.Void AddDouble(System.Int32 o, System.Nullable<System.Double> x) { }
        private System.Void AddOffset(System.Int32 o, System.Int32 x, System.Int32 d) { }
        private Google.FlatBuffers.StringOffset CreateString(System.String s) { }
        private Google.FlatBuffers.StringOffset CreateUTF8String(System.Span<System.Byte> chars) { }
        private Google.FlatBuffers.StringOffset CreateSharedString(System.String s) { }
        private System.Void AddStruct(System.Int32 voffset, System.Int32 x, System.Int32 d) { }
        private System.Int32 EndTable() { }
        private System.Void Required(System.Int32 table, System.Int32 field) { }
        private System.Void Finish(System.Int32 rootTable, System.Boolean sizePrefix) { }
        private System.Void Finish(System.Int32 rootTable) { }
        private System.Void FinishSizePrefixed(System.Int32 rootTable) { }
        private Google.FlatBuffers.ByteBuffer get_DataBuffer() { }
        private System.Byte[] SizedByteArray() { }
        private System.Void Finish(System.Int32 rootTable, System.String fileIdentifier, System.Boolean sizePrefix) { }
        private System.Void Finish(System.Int32 rootTable, System.String fileIdentifier) { }
        private System.Void FinishSizePrefixed(System.Int32 rootTable, System.String fileIdentifier) { }

    }

    // TypeToken: 0x2000008
    public class FlatBufferConstants
    {
        // Fields
        public static System.Int32 FileIdentifierLength;        // 0x0
        public static System.Int32 SizePrefixLength;        // 0x0

        // Methods
        private System.Void FLATBUFFERS_23_1_21() { }

    }

    // TypeToken: 0x2000009
    public class FlatBufferUtils
    {
        // Methods
        private System.Int16 ReinterpretAsShort(System.UInt16 val) { }
        private System.UInt16 ReinterpretAsUShort(System.Int16 val) { }
        private System.Void ReinterpretAsFloat(System.Int64 val, System.Single& floatValLow, System.Single& floatValHigh) { }
        private System.Span<T> AsSpan(Unity.Collections.NativeArray<T> nativeArray) { }
        private System.ReadOnlySpan<T> AsReadOnlySpan(Unity.Collections.NativeArray<T> nativeArray) { }

    }

    // TypeToken: 0x200000C
    public interface IFlatbufferObject
    {
        // Methods
        private System.Void __init(System.Int32 _i, Google.FlatBuffers.ByteBuffer _bb) { }
        private Google.FlatBuffers.ByteBuffer get_ByteBuffer() { }

    }

    // TypeToken: 0x200000D
    public struct Offset`1
    {
        // Fields
        public System.Int32 Value;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 value) { }

    }

    // TypeToken: 0x200000E
    public struct StringOffset
    {
        // Fields
        public System.Int32 Value;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 value) { }

    }

    // TypeToken: 0x200000F
    public struct VectorOffset
    {
        // Fields
        public System.Int32 Value;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 value) { }

    }

    // TypeToken: 0x2000010
    public struct Struct
    {
        // Fields
        private System.Int32 <bb_pos>k__BackingField;        // 0x10
        private Google.FlatBuffers.ByteBuffer <bb>k__BackingField;        // 0x18

        // Methods
        private System.Int32 get_bb_pos() { }
        private System.Void set_bb_pos(System.Int32 value) { }
        private Google.FlatBuffers.ByteBuffer get_bb() { }
        private System.Void set_bb(Google.FlatBuffers.ByteBuffer value) { }
        private System.Void .ctor(System.Int32 _i, Google.FlatBuffers.ByteBuffer _bb) { }

    }

    // TypeToken: 0x2000011
    public struct Table
    {
        // Fields
        private System.Int32 <bb_pos>k__BackingField;        // 0x10
        private Google.FlatBuffers.ByteBuffer <bb>k__BackingField;        // 0x18

        // Methods
        private System.Int32 get_bb_pos() { }
        private System.Void set_bb_pos(System.Int32 value) { }
        private Google.FlatBuffers.ByteBuffer get_bb() { }
        private System.Void set_bb(Google.FlatBuffers.ByteBuffer value) { }
        private Google.FlatBuffers.ByteBuffer get_ByteBuffer() { }
        private System.Void .ctor(System.Int32 _i, Google.FlatBuffers.ByteBuffer _bb) { }
        private System.Int32 __offset(System.Int32 vtableOffset) { }
        private System.Int32 __offset(System.Int32 vtableOffset, System.Int32 offset, Google.FlatBuffers.ByteBuffer bb) { }
        private System.Int32 __indirect(System.Int32 offset) { }
        private System.Int32 __indirect(System.Int32 offset, Google.FlatBuffers.ByteBuffer bb) { }
        private System.String __string(System.Int32 offset) { }
        private System.Int32 __vector_len(System.Int32 offset) { }
        private System.Int32 __vector(System.Int32 offset) { }
        private System.Span<T> __vector_as_span(System.Int32 offset, System.Int32 elementSize) { }
        private T[] __vector_as_array(System.Int32 offset) { }
        private T __union(System.Int32 offset) { }
        private System.Boolean __has_identifier(Google.FlatBuffers.ByteBuffer bb, System.String ident) { }
        private System.Int32 CompareStrings(System.Int32 offset_1, System.Int32 offset_2, Google.FlatBuffers.ByteBuffer bb) { }
        private System.Int32 CompareStrings(System.Int32 offset_1, System.Byte[] key, Google.FlatBuffers.ByteBuffer bb) { }

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

