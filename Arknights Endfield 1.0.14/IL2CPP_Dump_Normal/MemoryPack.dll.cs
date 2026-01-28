// ========================================================
// Dumped by @desirepro
// Assembly: MemoryPack.dll
// Classes:  165
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000006
    public class MemoryPackRegister`1
    {
        // Fields
        public static System.Func<System.Boolean> s_initFunc;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class Check`1
    {
        // Fields
        public static System.Boolean registered;        // 0x0

    }

    // TypeToken: 0x2000019
    public class Cache`1
    {
        // Fields
        private static MemoryPack.IMemoryPackFormatter<T> _formatter;        // 0x0

        // Methods
        private MemoryPack.IMemoryPackFormatter<T> get_formatter() { }
        private System.Void set_formatter(MemoryPack.IMemoryPackFormatter<T> value) { }

    }

    // TypeToken: 0x2000029
    public class SerializerWriterThreadStaticState
    {
        // Fields
        public MemoryPack.Internal.ReusableLinkedArrayBufferWriter BufferWriter;        // 0x10
        public MemoryPack.MemoryPackWriterOptionalState OptionalState;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void Init(MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000030
    public class ReferenceEqualityComparer, IEqualityComparer`1
    {
        // Fields
        private static readonly MemoryPack.MemoryPackWriterOptionalState.ReferenceEqualityComparer <Instance>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private MemoryPack.MemoryPackWriterOptionalState.ReferenceEqualityComparer get_Instance() { }
        private System.Boolean Equals(System.Object x, System.Object y) { }
        private System.Int32 GetHashCode(System.Object obj) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003C
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.State FirstBuffer;        // 0x0
        public static MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.State BuffersInit;        // 0x0
        public static MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.State BuffersIterate;        // 0x0
        public static MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.State Current;        // 0x0
        public static MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.State End;        // 0x0

    }

    // TypeToken: 0x200003B
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private MemoryPack.Internal.ReusableLinkedArrayBufferWriter parent;        // 0x10
        private MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.State state;        // 0x18
        private System.Memory<System.Byte> current;        // 0x20
        private System.Collections.Generic.List.Enumerator<MemoryPack.Internal.BufferSegment> buffersEnumerator;        // 0x30

        // Methods
        private System.Void .ctor(MemoryPack.Internal.ReusableLinkedArrayBufferWriter parent) { }
        private System.Memory<System.Byte> get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000041
    public class Segment : ReadOnlySequenceSegment`1
    {
        // Fields
        private System.Boolean returnToPool;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void SetBuffer(System.ReadOnlyMemory<System.Byte> buffer, System.Boolean returnToPool) { }
        private System.Void Reset() { }
        private System.Void SetRunningIndexAndNext(System.Int64 runningIndex, MemoryPack.Internal.ReusableReadOnlySequenceBuilder.Segment nextSegment) { }

    }

    // TypeToken: 0x2000043
    public class Cache`1
    {
        // Fields
        public static System.Boolean IsReferenceOrNullable;        // 0x0
        public static System.Boolean IsUnmanagedSZArray;        // 0x0
        public static System.Int32 UnmanagedSZArrayElementSize;        // 0x0
        public static System.Boolean IsFixedSizeMemoryPackable;        // 0x0
        public static System.Int32 MemoryPackableFixedSize;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000044
    public struct TypeKind
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static MemoryPack.Internal.TypeHelpers.TypeKind None;        // 0x0
        public static MemoryPack.Internal.TypeHelpers.TypeKind UnmanagedSZArray;        // 0x0
        public static MemoryPack.Internal.TypeHelpers.TypeKind FixedSizeMemoryPackable;        // 0x0

    }

namespace MemoryPack
{

    // TypeToken: 0x2000008
    public class MemoryPackableAttribute : Attribute
    {
        // Fields
        private readonly MemoryPack.GenerateType <GenerateType>k__BackingField;        // 0x10
        private readonly MemoryPack.SerializeLayout <SerializeLayout>k__BackingField;        // 0x14

        // Methods
        private MemoryPack.GenerateType get_GenerateType() { }
        private MemoryPack.SerializeLayout get_SerializeLayout() { }
        private System.Void .ctor(MemoryPack.GenerateType generateType) { }
        private System.Void .ctor(MemoryPack.SerializeLayout serializeLayout) { }
        private System.Void .ctor(MemoryPack.GenerateType generateType, MemoryPack.SerializeLayout serializeLayout) { }

    }

    // TypeToken: 0x2000009
    public struct GenerateType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MemoryPack.GenerateType Object;        // 0x0
        public static MemoryPack.GenerateType VersionTolerant;        // 0x0
        public static MemoryPack.GenerateType CircularReference;        // 0x0
        public static MemoryPack.GenerateType Collection;        // 0x0
        public static MemoryPack.GenerateType NoGenerate;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct SerializeLayout
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MemoryPack.SerializeLayout Sequential;        // 0x0
        public static MemoryPack.SerializeLayout Explicit;        // 0x0

    }

    // TypeToken: 0x200000B
    public class MemoryPackUnionAttribute : Attribute
    {
        // Fields
        private readonly System.UInt16 <Tag>k__BackingField;        // 0x10
        private readonly System.Type <Type>k__BackingField;        // 0x18

        // Methods
        private System.UInt16 get_Tag() { }
        private System.Type get_Type() { }
        private System.Void .ctor(System.UInt16 tag, System.Type type) { }

    }

    // TypeToken: 0x200000C
    public class MemoryPackUnionFormatterAttribute : Attribute
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x10

        // Methods
        private System.Type get_Type() { }
        private System.Void .ctor(System.Type type) { }

    }

    // TypeToken: 0x200000D
    public class MemoryPackAllowSerializeAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class MemoryPackOrderAttribute : Attribute
    {
        // Fields
        private readonly System.Int32 <Order>k__BackingField;        // 0x10

        // Methods
        private System.Int32 get_Order() { }
        private System.Void .ctor(System.Int32 order) { }

    }

    // TypeToken: 0x200000F
    public class MemoryPackIgnoreAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class MemoryPackIncludeAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class MemoryPackConstructorAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class MemoryPackOnSerializingAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class MemoryPackOnSerializedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class MemoryPackOnDeserializingAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class MemoryPackOnDeserializedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class GenerateTypeScriptAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class MemoryPackFormatterProvider
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Type> ArrayLikeFormatters;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Type> CollectionFormatters;        // 0x8
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Type> InterfaceCollectionFormatters;        // 0x10
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,MemoryPack.IMemoryPackFormatter> formatters;        // 0x18
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Type> genericFormatterFactory;        // 0x20
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Type> genericCollectionFormatterFactory;        // 0x28
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Type> KnownGenericTypeFormatters;        // 0x30
        private static System.Object lockObj;        // 0x38

        // Methods
        private System.Void RegisterInitialFormatters() { }
        private System.Void .cctor() { }
        private System.Boolean IsRegistered() { }
        private System.Void Register(MemoryPack.IMemoryPackFormatter<T> formatter) { }
        private System.Void RegisterGenericType(System.Type genericType, System.Type genericFormatterType) { }
        private System.Void RegisterCollection() { }
        private System.Void RegisterCollection(System.Type genericCollectionType) { }
        private System.Void RegisterSet() { }
        private System.Void RegisterSet(System.Type genericSetType) { }
        private System.Void RegisterDictionary() { }
        private System.Void RegisterDictionary(System.Type genericDictionaryType) { }
        private MemoryPack.IMemoryPackFormatter<T> GetFormatter() { }
        private MemoryPack.IMemoryPackFormatter GetFormatter(System.Type type) { }
        private System.Boolean TryInvokeRegisterFormatter(System.Type type) { }
        private System.Void ForceRegister(MemoryPack.IMemoryPackFormatter<T> formatter) { }
        private System.Object CreateGenericFormatter(System.Type type, System.Boolean typeIsReferenceOrContainsReferences) { }
        private System.Type TryCreateGenericFormatterType(System.Type type, System.Collections.Generic.IDictionary<System.Type,System.Type> knownTypes) { }
        private System.Type TryCreateGenericCollectionFormatterType(System.Type type) { }
        private System.Void RegisterWellKnownTypesFormatters() { }
        private System.Void UnityRegister() { }

    }

    // TypeToken: 0x200001A
    public interface IMemoryPackFormatterRegister
    {
    }

    // TypeToken: 0x200001B
    public interface IMemoryPackable`1 : IMemoryPackFormatterRegister
    {
    }

    // TypeToken: 0x200001C
    public interface IMemoryPackFormatter
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Object& value) { }

    }

    // TypeToken: 0x200001D
    public interface IMemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value) { }

    }

    // TypeToken: 0x200001E
    public class MemoryPackFormatter`1, IMemoryPackFormatter`1, IMemoryPackFormatter
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value) { }
        private System.Void MemoryPack.IMemoryPackFormatter.Deserialize(MemoryPack.MemoryPackReader& reader, System.Object& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class MemoryPackCode
    {
        // Fields
        public static System.Int32 NullCollection;        // 0x0
        public static System.Byte WideTag;        // 0x0
        public static System.Byte ReferenceId;        // 0x0
        public static System.Byte Reserved1;        // 0x0
        public static System.Byte Reserved2;        // 0x0
        public static System.Byte Reserved3;        // 0x0
        public static System.Byte Reserved4;        // 0x0
        public static System.Byte Reserved5;        // 0x0
        public static System.Byte NullObject;        // 0x0

        // Methods
        private System.ReadOnlySpan<System.Byte> get_NullCollectionData() { }
        private System.ReadOnlySpan<System.Byte> get_ZeroCollectionData() { }

    }

    // TypeToken: 0x2000020
    public class ErrorMemoryPackFormatter, IMemoryPackFormatter
    {
        // Fields
        private readonly System.Type type;        // 0x10
        private readonly System.String message;        // 0x18

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Void .ctor(System.Type type, System.String message) { }
        private System.Void Serialize(MemoryPack.MemoryPackWriter& writer, System.Object& value) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Object& value) { }
        private System.Void Throw() { }

    }

    // TypeToken: 0x2000021
    public class ErrorMemoryPackFormatter`1 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Exception exception;        // 0x0
        private readonly System.String message;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Exception exception) { }
        private System.Void .ctor(System.String message) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value) { }
        private System.Void Throw() { }

    }

    // TypeToken: 0x2000022
    public struct MemoryPackReader
    {
        // Fields
        private System.Buffers.ReadOnlySequence<System.Byte> bufferSource;        // 0x10
        private readonly System.Int64 totalLength;        // 0x28
        private System.ReadOnlySpan<System.Byte> bufferReference;        // 0x30
        private System.Int32 bufferLength;        // 0x40
        private System.Byte[] rentBuffer;        // 0x48
        private System.Int32 advancedCount;        // 0x50
        private System.Int32 consumed;        // 0x54
        private readonly MemoryPack.MemoryPackReaderOptionalState optionalState;        // 0x58

        // Methods
        private System.Int32 get_Consumed() { }
        private System.Int64 get_Remaining() { }
        private MemoryPack.MemoryPackReaderOptionalState get_OptionalState() { }
        private MemoryPack.MemoryPackSerializerOptions get_Options() { }
        private System.Void .ctor(System.Buffers.ReadOnlySequence<System.Byte>& sequence, MemoryPack.MemoryPackReaderOptionalState optionalState) { }
        private System.Void .ctor(System.ReadOnlySpan<System.Byte> buffer, MemoryPack.MemoryPackReaderOptionalState optionalState) { }
        private System.Byte& GetSpanReference(System.Int32 sizeHint) { }
        private System.Byte& GetNextSpan(System.Int32 sizeHint) { }
        private System.Void Advance(System.Int32 count) { }
        private System.Boolean TryAdvanceSequence(System.Int32 count) { }
        private System.Void GetRemainingSource(System.ReadOnlySpan<System.Byte>& singleSource, System.Buffers.ReadOnlySequence<System.Byte>& remainingSource) { }
        private System.Void Dispose() { }
        private MemoryPack.IMemoryPackFormatter GetFormatter(System.Type type) { }
        private MemoryPack.IMemoryPackFormatter<T> GetFormatter() { }
        private System.Boolean TryReadObjectHeader(System.Byte& memberCount) { }
        private System.Boolean TryReadUnionHeader(System.UInt16& tag) { }
        private System.Boolean TryReadCollectionHeader(System.Int32& length) { }
        private System.Boolean PeekIsNull() { }
        private System.Boolean TryPeekObjectHeader(System.Byte& memberCount) { }
        private System.Boolean TryPeekUnionHeader(System.UInt16& tag) { }
        private System.Boolean TryPeekUshort(System.UInt16& tag) { }
        private System.Boolean TryPeekCollectionHeader(System.Int32& length) { }
        private System.Boolean DangerousTryReadCollectionHeader(System.Int32& length) { }
        private System.String ReadString() { }
        private System.String ReadUtf16(System.Int32 length) { }
        private System.String ReadUtf8(System.Int32 utf8Length) { }
        private T1 ReadUnmanaged() { }
        private System.Void ReadPackable(T& value) { }
        private T ReadPackable() { }
        private System.Void ReadValue(T& value) { }
        private T ReadValue() { }
        private System.Void ReadValue(System.Type type, System.Object& value) { }
        private System.Object ReadValue(System.Type type) { }
        private System.Void ReadValueWithFormatter(TFormatter formatter, T& value) { }
        private T ReadValueWithFormatter(TFormatter formatter) { }
        private T[] ReadArray() { }
        private System.Void ReadArray(T[]& value) { }
        private System.Void ReadSpan(System.Span<T>& value) { }
        private T[] ReadPackableArray() { }
        private System.Void ReadPackableArray(T[]& value) { }
        private System.Void ReadPackableSpan(System.Span<T>& value) { }
        private T[] ReadUnmanagedArray() { }
        private System.Void ReadUnmanagedArray(T[]& value) { }
        private System.Void ReadUnmanagedSpan(System.Span<T>& value) { }
        private T[] DangerousReadUnmanagedArray() { }
        private System.Void DangerousReadUnmanagedArray(T[]& value) { }
        private System.Void DangerousReadUnmanagedSpan(System.Span<T>& value) { }
        private System.Void ReadSpanWithoutReadLengthHeader(System.Int32 length, System.Span<T>& value) { }
        private System.Void ReadPackableSpanWithoutReadLengthHeader(System.Int32 length, System.Span<T>& value) { }
        private System.Void DangerousReadUnmanagedSpanView(System.Boolean& isNull, System.ReadOnlySpan<System.Byte>& view) { }
        private System.Void ReadUnmanaged(T1& value1) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14) { }
        private System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15) { }
        private System.Void DangerousReadUnmanaged(T1& value1) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14) { }
        private System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15) { }
        private System.Byte ReadVarIntByte() { }
        private System.SByte ReadVarIntSByte() { }
        private System.UInt16 ReadVarIntUInt16() { }
        private System.Int16 ReadVarIntInt16() { }
        private System.UInt32 ReadVarIntUInt32() { }
        private System.Int32 ReadVarIntInt32() { }
        private System.UInt64 ReadVarIntUInt64() { }
        private System.Int64 ReadVarIntInt64() { }

    }

    // TypeToken: 0x2000023
    public class MemoryPackReaderOptionalStatePool
    {
        // Fields
        private static readonly System.Collections.Concurrent.ConcurrentQueue<MemoryPack.MemoryPackReaderOptionalState> queue;        // 0x0

        // Methods
        private MemoryPack.MemoryPackReaderOptionalState Rent(MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Void Return(MemoryPack.MemoryPackReaderOptionalState state) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000024
    public class MemoryPackReaderOptionalState, IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.UInt32,System.Object> refToObject;        // 0x10
        private MemoryPack.MemoryPackSerializerOptions <Options>k__BackingField;        // 0x18

        // Methods
        private MemoryPack.MemoryPackSerializerOptions get_Options() { }
        private System.Void set_Options(MemoryPack.MemoryPackSerializerOptions value) { }
        private System.Void .ctor() { }
        private System.Void Init(MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Object GetObjectReference(System.UInt32 id) { }
        private System.Void AddObjectReference(System.UInt32 id, System.Object value) { }
        private System.Void Reset() { }
        private System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x2000025
    public class VarIntCodes
    {
        // Fields
        public static System.Byte MaxSingleValue;        // 0x0
        public static System.SByte MinSingleValue;        // 0x0
        public static System.SByte Byte;        // 0x0
        public static System.SByte SByte;        // 0x0
        public static System.SByte UInt16;        // 0x0
        public static System.SByte Int16;        // 0x0
        public static System.SByte UInt32;        // 0x0
        public static System.SByte Int32;        // 0x0
        public static System.SByte UInt64;        // 0x0
        public static System.SByte Int64;        // 0x0

    }

    // TypeToken: 0x2000026
    public struct MemoryPackWriter
    {
        // Fields
        private static System.Int32 DepthLimit;        // 0x0
        private System.Buffers.IBufferWriter<System.Byte> bufferWriter;        // 0x10
        private System.Span<System.Byte> bufferReference;        // 0x18
        private System.Int32 bufferLength;        // 0x28
        private System.Int32 advancedCount;        // 0x2C
        private System.Int32 depth;        // 0x30
        private System.Int32 writtenCount;        // 0x34
        private readonly System.Boolean serializeStringAsUtf8;        // 0x38
        private readonly MemoryPack.MemoryPackWriterOptionalState optionalState;        // 0x40

        // Methods
        private System.Void WriteVarInt(System.Byte x) { }
        private System.Void WriteVarInt(System.SByte x) { }
        private System.Void WriteVarInt(System.UInt16 x) { }
        private System.Void WriteVarInt(System.Int16 x) { }
        private System.Void WriteVarInt(System.UInt32 x) { }
        private System.Void WriteVarInt(System.Int32 x) { }
        private System.Void WriteVarInt(System.UInt64 x) { }
        private System.Void WriteVarInt(System.Int64 x) { }
        private System.Int32 get_WrittenCount() { }
        private System.Int32 get_BufferLength() { }
        private MemoryPack.MemoryPackWriterOptionalState get_OptionalState() { }
        private MemoryPack.MemoryPackSerializerOptions get_Options() { }
        private System.Void .ctor(System.Buffers.IBufferWriter<System.Byte>& writer, MemoryPack.MemoryPackWriterOptionalState optionalState) { }
        private System.Void .ctor(System.Buffers.IBufferWriter<System.Byte>& writer, System.Byte[] firstBufferOfWriter, MemoryPack.MemoryPackWriterOptionalState optionalState) { }
        private System.Void .ctor(System.Buffers.IBufferWriter<System.Byte>& writer, System.Span<System.Byte> firstBufferOfWriter, MemoryPack.MemoryPackWriterOptionalState optionalState) { }
        private System.Byte& GetSpanReference(System.Int32 sizeHint) { }
        private System.Void RequestNewBuffer(System.Int32 sizeHint) { }
        private System.Void Advance(System.Int32 count) { }
        private System.Void Flush() { }
        private MemoryPack.IMemoryPackFormatter GetFormatter(System.Type type) { }
        private MemoryPack.IMemoryPackFormatter<T> GetFormatter() { }
        private System.Int32 GetStringWriteLength(System.String value) { }
        private System.Int32 GetUnmanageArrayWriteLength(T[] value) { }
        private System.Void WriteObjectHeader(System.Byte memberCount) { }
        private System.Void WriteNullObjectHeader() { }
        private System.Void WriteObjectReferenceId(System.UInt32 referenceId) { }
        private System.Void WriteUnionHeader(System.UInt16 tag) { }
        private System.Void WriteNullUnionHeader() { }
        private System.Void WriteCollectionHeader(System.Int32 length) { }
        private System.Void WriteNullCollectionHeader() { }
        private System.Void WriteString(System.String value) { }
        private System.Void WriteUtf16(System.String value) { }
        private System.Void WriteUtf16(System.ReadOnlySpan<System.Char> value) { }
        private System.Void WriteUtf8(System.String value) { }
        private System.Void WriteUtf8(System.ReadOnlySpan<System.Byte> utf8Value, System.Int32 utf16Length) { }
        private System.Void WriteUnmanaged(T1& value1) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14) { }
        private System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15) { }
        private System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15) { }
        private System.Void DangerousWriteUnmanaged(T1& value1) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14) { }
        private System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15) { }
        private System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15) { }

    }

    // TypeToken: 0x2000027
    public class MemoryPackSerializationException : Exception
    {
        // Methods
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void ThrowMessage(System.String message) { }
        private System.Void ThrowInvalidPropertyCount(System.Byte expected, System.Byte actual) { }
        private System.Void ThrowInvalidPropertyCount(System.Type type, System.Byte expected, System.Byte actual) { }
        private System.Void ThrowInvalidCollection() { }
        private System.Void ThrowInvalidRange(System.Int32 expected, System.Int32 actual) { }
        private System.Void ThrowInvalidAdvance() { }
        private System.Void ThrowSequenceReachedEnd() { }
        private System.Void ThrowWriteInvalidMemberCount(System.Byte memberCount) { }
        private System.Void ThrowInsufficientBufferUnless(System.Int32 length) { }
        private System.Void ThrowNotRegisteredInProvider(System.Type type) { }
        private System.Void ThrowRegisterInProviderFailed(System.Type type, System.Exception innerException) { }
        private System.Void ThrowNotFoundInUnionType(System.Type actualType, System.Type baseType) { }
        private System.Void ThrowInvalidTag(System.UInt16 tag, System.Type baseType) { }
        private System.Void ThrowReachedDepthLimit(System.Type type) { }
        private System.Void ThrowInvalidConcurrrentCollectionOperation() { }
        private System.Void ThrowDeserializeObjectIsNull(System.String target) { }
        private System.Void ThrowFailedEncoding(System.Buffers.OperationStatus status) { }
        private System.Void ThrowCompressionFailed(System.Buffers.OperationStatus status) { }
        private System.Void ThrowCompressionFailed() { }
        private System.Void ThrowAlreadyDecompressed() { }
        private System.Void ThrowDecompressionSizeLimitExceeded(System.Int32 limit, System.Int32 size) { }

    }

    // TypeToken: 0x2000028
    public class MemoryPackSerializer
    {
        // Fields
        private static MemoryPack.MemoryPackReaderOptionalState threadStaticReaderOptionalState;        // 0xFFFFFFFF
        private static MemoryPack.MemoryPackSerializer.SerializerWriterThreadStaticState threadStaticState;        // 0xFFFFFFFF
        private static MemoryPack.MemoryPackWriterOptionalState threadStaticWriterOptionalState;        // 0xFFFFFFFF

        // Methods
        private T Deserialize(System.ReadOnlySpan<System.Byte> buffer, MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Int32 Deserialize(System.ReadOnlySpan<System.Byte> buffer, T& value, MemoryPack.MemoryPackSerializerOptions options) { }
        private T Deserialize(System.Buffers.ReadOnlySequence<System.Byte>& buffer, MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Int32 Deserialize(System.Buffers.ReadOnlySequence<System.Byte>& buffer, T& value, MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Int32 Deserialize(System.Buffers.ReadOnlySequence<System.Byte>& buffer, System.Object& value, System.Type type, MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Threading.Tasks.ValueTask<T> DeserializeAsync(System.IO.Stream stream, MemoryPack.MemoryPackSerializerOptions options, System.Threading.CancellationToken cancellationToken) { }
        private System.Object Deserialize(System.Type type, System.ReadOnlySpan<System.Byte> buffer, MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Int32 Deserialize(System.Type type, System.ReadOnlySpan<System.Byte> buffer, System.Object& value, MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Object Deserialize(System.Type type, System.Buffers.ReadOnlySequence<System.Byte>& buffer, MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Int32 Deserialize(System.Type type, System.Buffers.ReadOnlySequence<System.Byte>& buffer, System.Object& value, MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Threading.Tasks.ValueTask<System.Object> DeserializeAsync(System.Type type, System.IO.Stream stream, MemoryPack.MemoryPackSerializerOptions options, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x200002C
    public class MemoryPackSerializerOptions, IEquatable`1
    {
        // Fields
        public static readonly MemoryPack.MemoryPackSerializerOptions Default;        // 0x0
        public static readonly MemoryPack.MemoryPackSerializerOptions Utf8;        // 0x8
        public static readonly MemoryPack.MemoryPackSerializerOptions Utf16;        // 0x10
        private readonly MemoryPack.StringEncoding <StringEncoding>k__BackingField;        // 0x10
        private readonly System.IServiceProvider <ServiceProvider>k__BackingField;        // 0x18

        // Methods
        private System.Type get_EqualityContract() { }
        private MemoryPack.StringEncoding get_StringEncoding() { }
        private System.Void set_StringEncoding(MemoryPack.StringEncoding value) { }
        private System.IServiceProvider get_ServiceProvider() { }
        private System.Void set_ServiceProvider(System.IServiceProvider value) { }
        private System.String ToString() { }
        private System.Boolean PrintMembers(System.Text.StringBuilder builder) { }
        private System.Boolean op_Inequality(MemoryPack.MemoryPackSerializerOptions r1, MemoryPack.MemoryPackSerializerOptions r2) { }
        private System.Boolean op_Equality(MemoryPack.MemoryPackSerializerOptions r1, MemoryPack.MemoryPackSerializerOptions r2) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(MemoryPack.MemoryPackSerializerOptions other) { }
        private MemoryPack.MemoryPackSerializerOptions <Clone>$() { }
        private System.Void .ctor(MemoryPack.MemoryPackSerializerOptions original) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002D
    public struct StringEncoding
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static MemoryPack.StringEncoding Utf16;        // 0x0
        public static MemoryPack.StringEncoding Utf8;        // 0x0

    }

    // TypeToken: 0x200002E
    public class MemoryPackWriterOptionalStatePool
    {
        // Fields
        private static readonly System.Collections.Concurrent.ConcurrentQueue<MemoryPack.MemoryPackWriterOptionalState> queue;        // 0x0

        // Methods
        private MemoryPack.MemoryPackWriterOptionalState Rent(MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Void Return(MemoryPack.MemoryPackWriterOptionalState state) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002F
    public class MemoryPackWriterOptionalState, IDisposable
    {
        // Fields
        private static readonly MemoryPack.MemoryPackWriterOptionalState NullState;        // 0x0
        private System.UInt32 nextId;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Object,System.UInt32> objectToRef;        // 0x18
        private MemoryPack.MemoryPackSerializerOptions <Options>k__BackingField;        // 0x20

        // Methods
        private MemoryPack.MemoryPackSerializerOptions get_Options() { }
        private System.Void set_Options(MemoryPack.MemoryPackSerializerOptions value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean _) { }
        private System.Void Init(MemoryPack.MemoryPackSerializerOptions options) { }
        private System.Void Reset() { }
        private System.ValueTuple<System.Boolean,System.UInt32> GetOrAddReference(System.Object value) { }
        private System.Void System.IDisposable.Dispose() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000031
    public class AnimationCurveFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void SerializeKeyFrame(UnityEngine.Keyframe keyframe, MemoryPack.MemoryPackWriter& writer) { }
        private System.Void DeserializeKeyFrame(MemoryPack.MemoryPackReader& reader, UnityEngine.Keyframe& keyframe) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, UnityEngine.AnimationCurve& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class GradientFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, UnityEngine.Gradient& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000033
    public class RectOffsetFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, UnityEngine.RectOffset& value) { }
        private System.Void .ctor() { }

    }

}

namespace MemoryPack.Compression
{

    // TypeToken: 0x200009E
    public class BitPackFormatter : MemoryPackFormatter`1
    {
        // Fields
        public static readonly MemoryPack.Compression.BitPackFormatter Default;        // 0x0

        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Boolean[]& value) { }
        private System.Boolean Get(System.Int32 data, System.Int32 index) { }
        private System.Void Set(System.Int32& data, System.Int32 index, System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009F
    public class BrotliCompressor, IBufferWriter`1, IDisposable
    {
        // Fields
        private MemoryPack.Internal.ReusableLinkedArrayBufferWriter bufferWriter;        // 0x10
        private readonly System.Int32 quality;        // 0x18
        private readonly System.Int32 window;        // 0x1C

        // Methods
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel) { }
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window) { }
        private System.Void .ctor(System.Int32 quality, System.Int32 window) { }
        private System.Void System.Buffers.IBufferWriter<System.Byte>.Advance(System.Int32 count) { }
        private System.Memory<System.Byte> System.Buffers.IBufferWriter<System.Byte>.GetMemory(System.Int32 sizeHint) { }
        private System.Span<System.Byte> System.Buffers.IBufferWriter<System.Byte>.GetSpan(System.Int32 sizeHint) { }
        private System.Byte[] ToArray() { }
        private System.Void CopyTo(System.Buffers.IBufferWriter<System.Byte>& destBufferWriter) { }
        private System.Threading.Tasks.ValueTask CopyToAsync(System.IO.Stream stream, System.Int32 bufferSize, System.Threading.CancellationToken cancellationToken) { }
        private System.Void CopyTo(MemoryPack.MemoryPackWriter& memoryPackWriter) { }
        private System.Int32 CompressCore(System.IO.Compression.BrotliEncoder& encoder, System.ReadOnlySpan<System.Byte> source, System.Buffers.IBufferWriter<System.Byte>& destBufferWriter, System.Nullable<System.Int32> initialLength, System.Boolean isFinalBlock) { }
        private System.Int32 CompressCore(System.IO.Compression.BrotliEncoder& encoder, System.ReadOnlySpan<System.Byte> source, MemoryPack.MemoryPackWriter& destBufferWriter, System.Nullable<System.Int32> initialLength, System.Boolean isFinalBlock) { }
        private System.Void Dispose() { }
        private System.Void ThrowIfDisposed() { }

    }

    // TypeToken: 0x20000A1
    public class BrotliUtils
    {
        // Fields
        public static System.Int32 WindowBits_Min;        // 0x0
        public static System.Int32 WindowBits_Default;        // 0x0
        public static System.Int32 WindowBits_Max;        // 0x0
        public static System.Int32 Quality_Min;        // 0x0
        public static System.Int32 Quality_Default;        // 0x0
        public static System.Int32 Quality_Max;        // 0x0
        public static System.Int32 MaxInputSize;        // 0x0

        // Methods
        private System.Int32 GetQualityFromCompressionLevel(System.IO.Compression.CompressionLevel compressionLevel) { }
        private System.Int32 BrotliEncoderMaxCompressedSize(System.Int32 input_size) { }

    }

    // TypeToken: 0x20000A2
    public struct BrotliDecompressor, IDisposable
    {
        // Fields
        private MemoryPack.Internal.ReusableReadOnlySequenceBuilder sequenceBuilder;        // 0x10

        // Methods
        private System.Buffers.ReadOnlySequence<System.Byte> Decompress(System.ReadOnlySpan<System.Byte> compressedSpan) { }
        private System.Buffers.ReadOnlySequence<System.Byte> Decompress(System.ReadOnlySpan<System.Byte> compressedSpan, System.Int32& consumed) { }
        private System.Buffers.ReadOnlySequence<System.Byte> Decompress(System.Buffers.ReadOnlySequence<System.Byte> compressedSequence) { }
        private System.Buffers.ReadOnlySequence<System.Byte> Decompress(System.Buffers.ReadOnlySequence<System.Byte> compressedSequence, System.Int32& consumed) { }
        private System.Void DecompressCore(System.Buffers.OperationStatus& status, System.IO.Compression.BrotliDecoder& decoder, System.ReadOnlySpan<System.Byte> source, System.Int32& consumed) { }
        private System.Void Dispose() { }
        private System.Int32 GetDoubleCapacity(System.Int32 length) { }

    }

    // TypeToken: 0x20000A3
    public class BrotliFormatter : MemoryPackFormatter`1
    {
        // Fields
        private static System.Int32 DefaultDecompssionSizeLimit;        // 0x0
        public static readonly MemoryPack.Compression.BrotliFormatter Default;        // 0x0
        private readonly System.IO.Compression.CompressionLevel compressionLevel;        // 0x10
        private readonly System.Int32 window;        // 0x14
        private readonly System.Int32 decompressionSizeLimit;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel) { }
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window) { }
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window, System.Int32 decompressionSizeLimit) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Byte[]& value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A4
    public class BrotliFormatter`1 : MemoryPackFormatter`1
    {
        // Fields
        private static System.Int32 DefaultDecompssionSizeLimit;        // 0x0
        public static readonly MemoryPack.Compression.BrotliFormatter Default;        // 0x0
        private readonly System.IO.Compression.CompressionLevel compressionLevel;        // 0x0
        private readonly System.Int32 window;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel) { }
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value) { }
        private System.Void .cctor() { }

    }

}

namespace MemoryPack.Formatters
{

    // TypeToken: 0x2000045
    public class UnmanagedArrayFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[]& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000046
    public class DangerousUnmanagedArrayFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[]& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class ArrayFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[]& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000048
    public class ArraySegmentFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ArraySegment<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class MemoryFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Memory<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public class ReadOnlyMemoryFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ReadOnlyMemory<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class ReadOnlySequenceFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Buffers.ReadOnlySequence<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004C
    public class MemoryPoolFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Memory<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public class ReadOnlyMemoryPoolFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ReadOnlyMemory<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public class BigIntegerFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Numerics.BigInteger& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public class BitArrayFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.BitArray& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000050
    public class BitArrayView
    {
        // Fields
        public System.Int32[] m_array;        // 0x10
        public System.Int32 m_length;        // 0x18
        public System.Int32 _version;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public class ListFormatter
    {
        // Methods
        private System.Collections.Generic.List<T> DeserializePackable(MemoryPack.MemoryPackReader& reader) { }
        private System.Void DeserializePackable(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.List<T>& value) { }

    }

    // TypeToken: 0x2000052
    public class ListFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.List<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public class StackFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.Stack<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000054
    public class QueueFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.Queue<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000055
    public class LinkedListFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.LinkedList<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public class HashSetFormatter`1 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IEqualityComparer<T> equalityComparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<T> equalityComparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.HashSet<T>& value) { }

    }

    // TypeToken: 0x2000057
    public class SortedSetFormatter`1 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IComparer<T> comparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IComparer<T> comparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.SortedSet<T>& value) { }

    }

    // TypeToken: 0x2000058
    public class CollectionFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.ObjectModel.Collection<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000059
    public class ObservableCollectionFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.ObjectModel.ObservableCollection<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005A
    public class ConcurrentQueueFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.ConcurrentQueue<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class ConcurrentStackFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.ConcurrentStack<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class ConcurrentBagFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.ConcurrentBag<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public class DictionaryFormatter`2 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IEqualityComparer<TKey> equalityComparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.Dictionary<TKey,TValue>& value) { }

    }

    // TypeToken: 0x200005E
    public class SortedDictionaryFormatter`2 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IComparer<TKey> comparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.SortedDictionary<TKey,TValue>& value) { }

    }

    // TypeToken: 0x200005F
    public class SortedListFormatter`2 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IComparer<TKey> comparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.SortedList<TKey,TValue>& value) { }

    }

    // TypeToken: 0x2000060
    public class ConcurrentDictionaryFormatter`2 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IEqualityComparer<TKey> equalityComparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue>& value) { }

    }

    // TypeToken: 0x2000061
    public class ReadOnlyCollectionFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.ObjectModel.ReadOnlyCollection<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class ReadOnlyObservableCollectionFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.ObjectModel.ReadOnlyObservableCollection<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000063
    public class BlockingCollectionFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.BlockingCollection<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000064
    public class CultureInfoFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Globalization.CultureInfo& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000065
    public class DynamicUnionFormatter`1 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type,System.UInt16> typeToTag;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.UInt16,System.Type> tagToType;        // 0x0

        // Methods
        private System.Void .ctor(System.ValueTuple<System.UInt16,System.Type>[] memoryPackUnions) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value) { }

    }

    // TypeToken: 0x2000067
    public class GenericCollectionFormatter`2 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, TCollection& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000068
    public class GenericSetFormatterBase`2 : MemoryPackFormatter`1
    {
        // Methods
        private TSet CreateSet() { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, TSet& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000069
    public class GenericSetFormatter`2 : GenericSetFormatterBase`2
    {
        // Methods
        private TSet CreateSet() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006A
    public class GenericDictionaryFormatterBase`3 : MemoryPackFormatter`1
    {
        // Methods
        private TDictionary CreateDictionary() { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, TDictionary& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006B
    public class GenericDictionaryFormatter`3 : GenericDictionaryFormatterBase`3
    {
        // Methods
        private TDictionary CreateDictionary() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006C
    public class InterfaceCollectionFormatterUtils
    {
        // Methods
        private System.Collections.Generic.List<T> ReadList(MemoryPack.MemoryPackReader& reader) { }

    }

    // TypeToken: 0x200006D
    public class InterfaceEnumerableFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IEnumerable<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006E
    public class InterfaceCollectionFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void .cctor() { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.ICollection<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006F
    public class InterfaceReadOnlyCollectionFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void .cctor() { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IReadOnlyCollection<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000070
    public class InterfaceListFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void .cctor() { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IList<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000071
    public class InterfaceReadOnlyListFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void .cctor() { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IReadOnlyList<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000072
    public class InterfaceDictionaryFormatter`2 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IEqualityComparer<TKey> equalityComparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IDictionary<TKey,TValue>& value) { }

    }

    // TypeToken: 0x2000073
    public class InterfaceReadOnlyDictionaryFormatter`2 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IEqualityComparer<TKey> equalityComparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>& value) { }

    }

    // TypeToken: 0x2000074
    public class InterfaceLookupFormatter`2 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IEqualityComparer<TKey> equalityComparer;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Linq.ILookup<TKey,TElement>& value) { }

    }

    // TypeToken: 0x2000075
    public class InterfaceGroupingFormatter`2 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void .cctor() { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Linq.IGrouping<TKey,TElement>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000076
    public class InterfaceSetFormatter`1 : MemoryPackFormatter`1
    {
        // Fields
        private readonly System.Collections.Generic.IEqualityComparer<T> equalityComparer;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<T> equalityComparer) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.ISet<T>& value) { }

    }

    // TypeToken: 0x2000077
    public class Grouping`2, IGrouping`2, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly TKey key;        // 0x0
        private readonly System.Collections.Generic.IEnumerable<TElement> elements;        // 0x0

        // Methods
        private System.Void .ctor(TKey key, System.Collections.Generic.IEnumerable<TElement> elements) { }
        private TKey get_Key() { }
        private System.Collections.Generic.IEnumerator<TElement> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000078
    public class Lookup`2, ILookup`2, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<TKey,System.Linq.IGrouping<TKey,TElement>> groupings;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.Dictionary<TKey,System.Linq.IGrouping<TKey,TElement>> groupings) { }
        private System.Collections.Generic.IEnumerable<TElement> get_Item(TKey key) { }
        private System.Int32 get_Count() { }
        private System.Boolean Contains(TKey key) { }
        private System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000079
    public class KeyValuePairFormatter
    {
        // Methods
        private System.Void Deserialize(MemoryPack.IMemoryPackFormatter<TKey> keyFormatter, MemoryPack.IMemoryPackFormatter<TValue> valueFormatter, MemoryPack.MemoryPackReader& reader, TKey& key, TValue& value) { }

    }

    // TypeToken: 0x200007A
    public class KeyValuePairFormatter`2 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.KeyValuePair<TKey,TValue>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007B
    public class LazyFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Lazy<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007C
    public class TwoDimensionalArrayFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[,]& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007D
    public class ThreeDimensionalArrayFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[,,]& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public class FourDimensionalArrayFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[,,,]& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007F
    public class NullableFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Nullable<T>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class StringBuilderFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Text.StringBuilder& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public class StringFormatter : MemoryPackFormatter`1
    {
        // Fields
        public static readonly MemoryPack.Formatters.StringFormatter Default;        // 0x0

        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000082
    public class Utf8StringFormatter : MemoryPackFormatter`1
    {
        // Fields
        public static readonly MemoryPack.Formatters.Utf8StringFormatter Default;        // 0x0

        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000083
    public class Utf16StringFormatter : MemoryPackFormatter`1
    {
        // Fields
        public static readonly MemoryPack.Formatters.Utf16StringFormatter Default;        // 0x0

        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000084
    public class InternStringFormatter : MemoryPackFormatter`1
    {
        // Fields
        public static readonly MemoryPack.Formatters.InternStringFormatter Default;        // 0x0

        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000085
    public class BrotliStringFormatter : MemoryPackFormatter`1
    {
        // Fields
        private static System.Runtime.CompilerServices.StrongBox<System.Int32> threadStaticConsumedBox;        // 0xFFFFFFFF
        private static System.Int32 DefaultDecompssionSizeLimit;        // 0x0
        public static readonly MemoryPack.Formatters.BrotliStringFormatter Default;        // 0x0
        private readonly System.IO.Compression.CompressionLevel compressionLevel;        // 0x10
        private readonly System.Int32 window;        // 0x14
        private readonly System.Int32 decompressionSizeLimit;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel) { }
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window) { }
        private System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window, System.Int32 decompressionSizeLimit) { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000087
    public class TimeZoneInfoFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.TimeZoneInfo& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000088
    public class TupleFormatterTypes
    {
        // Fields
        public static readonly System.Collections.Generic.Dictionary<System.Type,System.Type> TupleFormatters;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000089
    public class TupleFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008A
    public class TupleFormatter`2 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008B
    public class TupleFormatter`3 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008C
    public class TupleFormatter`4 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008D
    public class TupleFormatter`5 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4,T5>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008E
    public class TupleFormatter`6 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4,T5,T6>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008F
    public class TupleFormatter`7 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4,T5,T6,T7>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000090
    public class TupleFormatter`8 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4,T5,T6,T7,TRest>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000091
    public class ValueTupleFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000092
    public class ValueTupleFormatter`2 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000093
    public class ValueTupleFormatter`3 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000094
    public class ValueTupleFormatter`4 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000095
    public class ValueTupleFormatter`5 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4,T5>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000096
    public class ValueTupleFormatter`6 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4,T5,T6>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public class ValueTupleFormatter`7 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4,T5,T6,T7>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000098
    public class ValueTupleFormatter`8 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4,T5,T6,T7,TRest>& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000099
    public class TypeFormatter : MemoryPackFormatter`1
    {
        // Fields
        private static readonly System.Text.RegularExpressions.Regex _shortTypeNameRegex;        // 0x0

        // Methods
        private System.Text.RegularExpressions.Regex ShortTypeNameRegex() { }
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Type& value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009A
    public class UnmanagedFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009B
    public class DangerousUnmanagedFormatter`1 : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009C
    public class UriFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Uri& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009D
    public class VersionFormatter : MemoryPackFormatter`1
    {
        // Methods
        private System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Version& value) { }
        private System.Void .ctor() { }

    }

}

namespace MemoryPack.Internal
{

    // TypeToken: 0x2000034
    public class EnumerableExtensions
    {
        // Methods
        private System.Boolean TryGetNonEnumeratedCountEx(System.Collections.Generic.IEnumerable<T> value, System.Int32& count) { }

    }

    // TypeToken: 0x2000035
    public struct FixedArrayBufferWriter, IBufferWriter`1
    {
        // Fields
        private System.Byte[] buffer;        // 0x10
        private System.Int32 written;        // 0x18

        // Methods
        private System.Void .ctor(System.Byte[] buffer) { }
        private System.Void Advance(System.Int32 count) { }
        private System.Memory<System.Byte> GetMemory(System.Int32 sizeHint) { }
        private System.Span<System.Byte> GetSpan(System.Int32 sizeHint) { }
        private System.Byte[] GetFilledBuffer() { }

    }

    // TypeToken: 0x2000036
    public class MathEx
    {
        // Fields
        private static System.Int32 ArrayMexLength;        // 0x0

        // Methods
        private System.Int32 NewArrayCapacity(System.Int32 size) { }

    }

    // TypeToken: 0x2000037
    public class MemoryMarshalEx
    {
        // Methods
        private T& GetArrayDataReference(T[] array) { }
        private T[] AllocateUninitializedArray(System.Int32 length, System.Boolean pinned) { }

    }

    // TypeToken: 0x2000038
    public class PreserveAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class ReusableLinkedArrayBufferWriterPool
    {
        // Fields
        private static readonly System.Collections.Concurrent.ConcurrentQueue<MemoryPack.Internal.ReusableLinkedArrayBufferWriter> queue;        // 0x0

        // Methods
        private MemoryPack.Internal.ReusableLinkedArrayBufferWriter Rent() { }
        private System.Void Return(MemoryPack.Internal.ReusableLinkedArrayBufferWriter writer) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003A
    public class ReusableLinkedArrayBufferWriter, IBufferWriter`1
    {
        // Fields
        private static System.Int32 InitialBufferSize;        // 0x0
        private static readonly System.Byte[] noUseFirstBufferSentinel;        // 0x0
        private System.Collections.Generic.List<MemoryPack.Internal.BufferSegment> buffers;        // 0x10
        private System.Byte[] firstBuffer;        // 0x18
        private System.Int32 firstBufferWritten;        // 0x20
        private MemoryPack.Internal.BufferSegment current;        // 0x28
        private System.Int32 nextBufferSize;        // 0x38
        private System.Int32 totalWritten;        // 0x3C

        // Methods
        private System.Int32 get_TotalWritten() { }
        private System.Boolean get_UseFirstBuffer() { }
        private System.Void .ctor(System.Boolean useFirstBuffer, System.Boolean pinned) { }
        private System.Byte[] DangerousGetFirstBuffer() { }
        private System.Memory<System.Byte> GetMemory(System.Int32 sizeHint) { }
        private System.Span<System.Byte> GetSpan(System.Int32 sizeHint) { }
        private System.Void Advance(System.Int32 count) { }
        private System.Byte[] ToArrayAndReset() { }
        private System.Void WriteToAndReset(MemoryPack.MemoryPackWriter& writer) { }
        private System.Threading.Tasks.ValueTask WriteToAndResetAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }
        private MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator GetEnumerator() { }
        private System.Void ResetCore() { }
        private System.Void Reset() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003E
    public struct BufferSegment
    {
        // Fields
        private System.Byte[] buffer;        // 0x10
        private System.Int32 written;        // 0x18

        // Methods
        private System.Boolean get_IsNull() { }
        private System.Int32 get_WrittenCount() { }
        private System.Span<System.Byte> get_WrittenBuffer() { }
        private System.Memory<System.Byte> get_WrittenMemory() { }
        private System.Span<System.Byte> get_FreeBuffer() { }
        private System.Void .ctor(System.Int32 size) { }
        private System.Void Advance(System.Int32 count) { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x200003F
    public class ReusableReadOnlySequenceBuilderPool
    {
        // Fields
        private static readonly System.Collections.Concurrent.ConcurrentQueue<MemoryPack.Internal.ReusableReadOnlySequenceBuilder> queue;        // 0x0

        // Methods
        private MemoryPack.Internal.ReusableReadOnlySequenceBuilder Rent() { }
        private System.Void Return(MemoryPack.Internal.ReusableReadOnlySequenceBuilder builder) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000040
    public class ReusableReadOnlySequenceBuilder
    {
        // Fields
        private readonly System.Collections.Generic.Stack<MemoryPack.Internal.ReusableReadOnlySequenceBuilder.Segment> segmentPool;        // 0x10
        private readonly System.Collections.Generic.List<MemoryPack.Internal.ReusableReadOnlySequenceBuilder.Segment> list;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void Add(System.ReadOnlyMemory<System.Byte> buffer, System.Boolean returnToPool) { }
        private System.Boolean TryGetSingleMemory(System.ReadOnlyMemory<System.Byte>& memory) { }
        private System.Buffers.ReadOnlySequence<System.Byte> Build() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000042
    public class TypeHelpers
    {
        // Fields
        private static readonly System.Reflection.MethodInfo isReferenceOrContainsReferences;        // 0x0
        private static readonly System.Reflection.MethodInfo unsafeSizeOf;        // 0x8

        // Methods
        private System.Boolean IsReferenceOrNullable() { }
        private MemoryPack.Internal.TypeHelpers.TypeKind TryGetUnmanagedSZArrayElementSizeOrMemoryPackableFixedSize(System.Int32& size) { }
        private System.Boolean IsAnonymous(System.Type type) { }
        private System.Void .cctor() { }

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

    // TypeToken: 0x2000004
    public class NullableAttribute : Attribute
    {
        // Fields
        public readonly System.Byte[] NullableFlags;        // 0x10

        // Methods
        private System.Void .ctor(System.Byte ) { }
        private System.Void .ctor(System.Byte[] ) { }

    }

    // TypeToken: 0x2000005
    public class NullableContextAttribute : Attribute
    {
        // Fields
        public readonly System.Byte Flag;        // 0x10

        // Methods
        private System.Void .ctor(System.Byte ) { }

    }

    // TypeToken: 0x2000007
    public class IsExternalInit
    {
        // Methods
        private System.Void .ctor() { }

    }

}

