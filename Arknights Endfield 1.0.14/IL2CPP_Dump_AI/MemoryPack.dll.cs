// ========================================================
// Dumped by @desirepro
// Assembly: MemoryPack.dll
// Classes:  165
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: MemoryPackRegister`1
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  public    static  System.Func<System.Boolean>     s_initFunc  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Check`1
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public    static  System.Boolean                  registered  // 0x0
METHODS:
END_CLASS

CLASS: Cache`1
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private   static  MemoryPack.IMemoryPackFormatter<T>_formatter  // 0x0
METHODS:
  MemoryPack.IMemoryPackFormatter<T> get_formatter()
  System.Void set_formatter(MemoryPack.IMemoryPackFormatter<T> value)
END_CLASS

CLASS: SerializerWriterThreadStaticState
TYPE:  class
TOKEN: 0x2000029
FIELDS:
  public            MemoryPack.Internal.ReusableLinkedArrayBufferWriterBufferWriter  // 0x10
  public            MemoryPack.MemoryPackWriterOptionalStateOptionalState  // 0x18
METHODS:
  System.Void .ctor()
  System.Void Init(MemoryPack.MemoryPackSerializerOptions options)
  System.Void Reset()
END_CLASS

CLASS: ReferenceEqualityComparer
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  private   static readonly MemoryPack.MemoryPackWriterOptionalState.ReferenceEqualityComparer<Instance>k__BackingField  // 0x0
METHODS:
  System.Void .ctor()
  MemoryPack.MemoryPackWriterOptionalState.ReferenceEqualityComparer get_Instance()
  System.Boolean Equals(System.Object x, System.Object y)
  System.Int32 GetHashCode(System.Object obj)
  System.Void .cctor()
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.StateFirstBuffer  // 0x0
  public    static  MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.StateBuffersInit  // 0x0
  public    static  MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.StateBuffersIterate  // 0x0
  public    static  MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.StateCurrent  // 0x0
  public    static  MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.StateEnd  // 0x0
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  private           MemoryPack.Internal.ReusableLinkedArrayBufferWriterparent  // 0x10
  private           MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator.Statestate  // 0x18
  private           System.Memory<System.Byte>      current  // 0x20
  private           System.Collections.Generic.List.Enumerator<MemoryPack.Internal.BufferSegment>buffersEnumerator  // 0x30
METHODS:
  System.Void .ctor(MemoryPack.Internal.ReusableLinkedArrayBufferWriter parent)
  System.Memory<System.Byte> get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: Segment
TYPE:  class
TOKEN: 0x2000041
EXTENDS: ReadOnlySequenceSegment`1
FIELDS:
  private           System.Boolean                  returnToPool  // 0x30
METHODS:
  System.Void .ctor()
  System.Void SetBuffer(System.ReadOnlyMemory<System.Byte> buffer, System.Boolean returnToPool)
  System.Void Reset()
  System.Void SetRunningIndexAndNext(System.Int64 runningIndex, MemoryPack.Internal.ReusableReadOnlySequenceBuilder.Segment nextSegment)
END_CLASS

CLASS: Cache`1
TYPE:  class
TOKEN: 0x2000043
FIELDS:
  public    static  System.Boolean                  IsReferenceOrNullable  // 0x0
  public    static  System.Boolean                  IsUnmanagedSZArray  // 0x0
  public    static  System.Int32                    UnmanagedSZArrayElementSize  // 0x0
  public    static  System.Boolean                  IsFixedSizeMemoryPackable  // 0x0
  public    static  System.Int32                    MemoryPackableFixedSize  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: TypeKind
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  MemoryPack.Internal.TypeHelpers.TypeKindNone  // 0x0
  public    static  MemoryPack.Internal.TypeHelpers.TypeKindUnmanagedSZArray  // 0x0
  public    static  MemoryPack.Internal.TypeHelpers.TypeKindFixedSizeMemoryPackable  // 0x0
METHODS:
END_CLASS

CLASS: MemoryPack.MemoryPackableAttribute
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Attribute
FIELDS:
  private   readonly MemoryPack.GenerateType         <GenerateType>k__BackingField  // 0x10
  private   readonly MemoryPack.SerializeLayout      <SerializeLayout>k__BackingField  // 0x14
METHODS:
  MemoryPack.GenerateType get_GenerateType()
  MemoryPack.SerializeLayout get_SerializeLayout()
  System.Void .ctor(MemoryPack.GenerateType generateType)
  System.Void .ctor(MemoryPack.SerializeLayout serializeLayout)
  System.Void .ctor(MemoryPack.GenerateType generateType, MemoryPack.SerializeLayout serializeLayout)
END_CLASS

CLASS: MemoryPack.GenerateType
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MemoryPack.GenerateType         Object  // 0x0
  public    static  MemoryPack.GenerateType         VersionTolerant  // 0x0
  public    static  MemoryPack.GenerateType         CircularReference  // 0x0
  public    static  MemoryPack.GenerateType         Collection  // 0x0
  public    static  MemoryPack.GenerateType         NoGenerate  // 0x0
METHODS:
END_CLASS

CLASS: MemoryPack.SerializeLayout
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MemoryPack.SerializeLayout      Sequential  // 0x0
  public    static  MemoryPack.SerializeLayout      Explicit  // 0x0
METHODS:
END_CLASS

CLASS: MemoryPack.MemoryPackUnionAttribute
TYPE:  class
TOKEN: 0x200000B
EXTENDS: Attribute
FIELDS:
  private   readonly System.UInt16                   <Tag>k__BackingField  // 0x10
  private   readonly System.Type                     <Type>k__BackingField  // 0x18
METHODS:
  System.UInt16 get_Tag()
  System.Type get_Type()
  System.Void .ctor(System.UInt16 tag, System.Type type)
END_CLASS

CLASS: MemoryPack.MemoryPackUnionFormatterAttribute
TYPE:  class
TOKEN: 0x200000C
EXTENDS: Attribute
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x10
METHODS:
  System.Type get_Type()
  System.Void .ctor(System.Type type)
END_CLASS

CLASS: MemoryPack.MemoryPackAllowSerializeAttribute
TYPE:  class
TOKEN: 0x200000D
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.MemoryPackOrderAttribute
TYPE:  class
TOKEN: 0x200000E
EXTENDS: Attribute
FIELDS:
  private   readonly System.Int32                    <Order>k__BackingField  // 0x10
METHODS:
  System.Int32 get_Order()
  System.Void .ctor(System.Int32 order)
END_CLASS

CLASS: MemoryPack.MemoryPackIgnoreAttribute
TYPE:  class
TOKEN: 0x200000F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.MemoryPackIncludeAttribute
TYPE:  class
TOKEN: 0x2000010
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.MemoryPackConstructorAttribute
TYPE:  class
TOKEN: 0x2000011
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.MemoryPackOnSerializingAttribute
TYPE:  class
TOKEN: 0x2000012
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.MemoryPackOnSerializedAttribute
TYPE:  class
TOKEN: 0x2000013
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.MemoryPackOnDeserializingAttribute
TYPE:  class
TOKEN: 0x2000014
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.MemoryPackOnDeserializedAttribute
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.GenerateTypeScriptAttribute
TYPE:  class
TOKEN: 0x2000016
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.MemoryPackFormatterProvider
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Type>ArrayLikeFormatters  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Type>CollectionFormatters  // 0x8
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Type>InterfaceCollectionFormatters  // 0x10
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,MemoryPack.IMemoryPackFormatter>formatters  // 0x18
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Type>genericFormatterFactory  // 0x20
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Type>genericCollectionFormatterFactory  // 0x28
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Type>KnownGenericTypeFormatters  // 0x30
  private   static  System.Object                   lockObj  // 0x38
METHODS:
  System.Void RegisterInitialFormatters()
  System.Void .cctor()
  System.Boolean IsRegistered()
  System.Void Register(MemoryPack.IMemoryPackFormatter<T> formatter)
  System.Void RegisterGenericType(System.Type genericType, System.Type genericFormatterType)
  System.Void RegisterCollection()
  System.Void RegisterCollection(System.Type genericCollectionType)
  System.Void RegisterSet()
  System.Void RegisterSet(System.Type genericSetType)
  System.Void RegisterDictionary()
  System.Void RegisterDictionary(System.Type genericDictionaryType)
  MemoryPack.IMemoryPackFormatter<T> GetFormatter()
  MemoryPack.IMemoryPackFormatter GetFormatter(System.Type type)
  System.Boolean TryInvokeRegisterFormatter(System.Type type)
  System.Void ForceRegister(MemoryPack.IMemoryPackFormatter<T> formatter)
  System.Object CreateGenericFormatter(System.Type type, System.Boolean typeIsReferenceOrContainsReferences)
  System.Type TryCreateGenericFormatterType(System.Type type, System.Collections.Generic.IDictionary<System.Type,System.Type> knownTypes)
  System.Type TryCreateGenericCollectionFormatterType(System.Type type)
  System.Void RegisterWellKnownTypesFormatters()
  System.Void UnityRegister()
END_CLASS

CLASS: MemoryPack.IMemoryPackFormatterRegister
TYPE:  interface
TOKEN: 0x200001A
FIELDS:
METHODS:
END_CLASS

CLASS: MemoryPack.IMemoryPackable`1
TYPE:  interface
TOKEN: 0x200001B
FIELDS:
METHODS:
END_CLASS

CLASS: MemoryPack.IMemoryPackFormatter
TYPE:  interface
TOKEN: 0x200001C
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Object& value)
END_CLASS

CLASS: MemoryPack.IMemoryPackFormatter`1
TYPE:  interface
TOKEN: 0x200001D
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value)
END_CLASS

CLASS: MemoryPack.MemoryPackFormatter`1
TYPE:  class
TOKEN: 0x200001E
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value)
  System.Void MemoryPack.IMemoryPackFormatter.Deserialize(MemoryPack.MemoryPackReader& reader, System.Object& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.MemoryPackCode
TYPE:  class
TOKEN: 0x200001F
FIELDS:
  public    static  System.Int32                    NullCollection  // 0x0
  public    static  System.Byte                     WideTag  // 0x0
  public    static  System.Byte                     ReferenceId  // 0x0
  public    static  System.Byte                     Reserved1  // 0x0
  public    static  System.Byte                     Reserved2  // 0x0
  public    static  System.Byte                     Reserved3  // 0x0
  public    static  System.Byte                     Reserved4  // 0x0
  public    static  System.Byte                     Reserved5  // 0x0
  public    static  System.Byte                     NullObject  // 0x0
METHODS:
  System.ReadOnlySpan<System.Byte> get_NullCollectionData()
  System.ReadOnlySpan<System.Byte> get_ZeroCollectionData()
END_CLASS

CLASS: MemoryPack.ErrorMemoryPackFormatter
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  private   readonly System.Type                     type  // 0x10
  private   readonly System.String                   message  // 0x18
METHODS:
  System.Void .ctor(System.Type type)
  System.Void .ctor(System.Type type, System.String message)
  System.Void Serialize(MemoryPack.MemoryPackWriter& writer, System.Object& value)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Object& value)
  System.Void Throw()
END_CLASS

CLASS: MemoryPack.ErrorMemoryPackFormatter`1
TYPE:  class
TOKEN: 0x2000021
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Exception                exception  // 0x0
  private   readonly System.String                   message  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Exception exception)
  System.Void .ctor(System.String message)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value)
  System.Void Throw()
END_CLASS

CLASS: MemoryPack.MemoryPackReader
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  private           System.Buffers.ReadOnlySequence<System.Byte>bufferSource  // 0x10
  private   readonly System.Int64                    totalLength  // 0x28
  private           System.ReadOnlySpan<System.Byte>bufferReference  // 0x30
  private           System.Int32                    bufferLength  // 0x40
  private           System.Byte[]                   rentBuffer  // 0x48
  private           System.Int32                    advancedCount  // 0x50
  private           System.Int32                    consumed  // 0x54
  private   readonly MemoryPack.MemoryPackReaderOptionalStateoptionalState  // 0x58
METHODS:
  System.Int32 get_Consumed()
  System.Int64 get_Remaining()
  MemoryPack.MemoryPackReaderOptionalState get_OptionalState()
  MemoryPack.MemoryPackSerializerOptions get_Options()
  System.Void .ctor(System.Buffers.ReadOnlySequence<System.Byte>& sequence, MemoryPack.MemoryPackReaderOptionalState optionalState)
  System.Void .ctor(System.ReadOnlySpan<System.Byte> buffer, MemoryPack.MemoryPackReaderOptionalState optionalState)
  System.Byte& GetSpanReference(System.Int32 sizeHint)
  System.Byte& GetNextSpan(System.Int32 sizeHint)
  System.Void Advance(System.Int32 count)
  System.Boolean TryAdvanceSequence(System.Int32 count)
  System.Void GetRemainingSource(System.ReadOnlySpan<System.Byte>& singleSource, System.Buffers.ReadOnlySequence<System.Byte>& remainingSource)
  System.Void Dispose()
  MemoryPack.IMemoryPackFormatter GetFormatter(System.Type type)
  MemoryPack.IMemoryPackFormatter<T> GetFormatter()
  System.Boolean TryReadObjectHeader(System.Byte& memberCount)
  System.Boolean TryReadUnionHeader(System.UInt16& tag)
  System.Boolean TryReadCollectionHeader(System.Int32& length)
  System.Boolean PeekIsNull()
  System.Boolean TryPeekObjectHeader(System.Byte& memberCount)
  System.Boolean TryPeekUnionHeader(System.UInt16& tag)
  System.Boolean TryPeekUshort(System.UInt16& tag)
  System.Boolean TryPeekCollectionHeader(System.Int32& length)
  System.Boolean DangerousTryReadCollectionHeader(System.Int32& length)
  System.String ReadString()
  System.String ReadUtf16(System.Int32 length)
  System.String ReadUtf8(System.Int32 utf8Length)
  T1 ReadUnmanaged()
  System.Void ReadPackable(T& value)
  T ReadPackable()
  System.Void ReadValue(T& value)
  T ReadValue()
  System.Void ReadValue(System.Type type, System.Object& value)
  System.Object ReadValue(System.Type type)
  System.Void ReadValueWithFormatter(TFormatter formatter, T& value)
  T ReadValueWithFormatter(TFormatter formatter)
  T[] ReadArray()
  System.Void ReadArray(T[]& value)
  System.Void ReadSpan(System.Span<T>& value)
  T[] ReadPackableArray()
  System.Void ReadPackableArray(T[]& value)
  System.Void ReadPackableSpan(System.Span<T>& value)
  T[] ReadUnmanagedArray()
  System.Void ReadUnmanagedArray(T[]& value)
  System.Void ReadUnmanagedSpan(System.Span<T>& value)
  T[] DangerousReadUnmanagedArray()
  System.Void DangerousReadUnmanagedArray(T[]& value)
  System.Void DangerousReadUnmanagedSpan(System.Span<T>& value)
  System.Void ReadSpanWithoutReadLengthHeader(System.Int32 length, System.Span<T>& value)
  System.Void ReadPackableSpanWithoutReadLengthHeader(System.Int32 length, System.Span<T>& value)
  System.Void DangerousReadUnmanagedSpanView(System.Boolean& isNull, System.ReadOnlySpan<System.Byte>& view)
  System.Void ReadUnmanaged(T1& value1)
  System.Void ReadUnmanaged(T1& value1, T2& value2)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14)
  System.Void ReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15)
  System.Void DangerousReadUnmanaged(T1& value1)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14)
  System.Void DangerousReadUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15)
  System.Byte ReadVarIntByte()
  System.SByte ReadVarIntSByte()
  System.UInt16 ReadVarIntUInt16()
  System.Int16 ReadVarIntInt16()
  System.UInt32 ReadVarIntUInt32()
  System.Int32 ReadVarIntInt32()
  System.UInt64 ReadVarIntUInt64()
  System.Int64 ReadVarIntInt64()
END_CLASS

CLASS: MemoryPack.MemoryPackReaderOptionalStatePool
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private   static readonly System.Collections.Concurrent.ConcurrentQueue<MemoryPack.MemoryPackReaderOptionalState>queue  // 0x0
METHODS:
  MemoryPack.MemoryPackReaderOptionalState Rent(MemoryPack.MemoryPackSerializerOptions options)
  System.Void Return(MemoryPack.MemoryPackReaderOptionalState state)
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.MemoryPackReaderOptionalState
TYPE:  class
TOKEN: 0x2000024
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.UInt32,System.Object>refToObject  // 0x10
  private           MemoryPack.MemoryPackSerializerOptions<Options>k__BackingField  // 0x18
METHODS:
  MemoryPack.MemoryPackSerializerOptions get_Options()
  System.Void set_Options(MemoryPack.MemoryPackSerializerOptions value)
  System.Void .ctor()
  System.Void Init(MemoryPack.MemoryPackSerializerOptions options)
  System.Object GetObjectReference(System.UInt32 id)
  System.Void AddObjectReference(System.UInt32 id, System.Object value)
  System.Void Reset()
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: MemoryPack.VarIntCodes
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  public    static  System.Byte                     MaxSingleValue  // 0x0
  public    static  System.SByte                    MinSingleValue  // 0x0
  public    static  System.SByte                    Byte  // 0x0
  public    static  System.SByte                    SByte  // 0x0
  public    static  System.SByte                    UInt16  // 0x0
  public    static  System.SByte                    Int16  // 0x0
  public    static  System.SByte                    UInt32  // 0x0
  public    static  System.SByte                    Int32  // 0x0
  public    static  System.SByte                    UInt64  // 0x0
  public    static  System.SByte                    Int64  // 0x0
METHODS:
END_CLASS

CLASS: MemoryPack.MemoryPackWriter
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  private   static  System.Int32                    DepthLimit  // 0x0
  private           System.Buffers.IBufferWriter<System.Byte>bufferWriter  // 0x10
  private           System.Span<System.Byte>        bufferReference  // 0x18
  private           System.Int32                    bufferLength  // 0x28
  private           System.Int32                    advancedCount  // 0x2C
  private           System.Int32                    depth  // 0x30
  private           System.Int32                    writtenCount  // 0x34
  private   readonly System.Boolean                  serializeStringAsUtf8  // 0x38
  private   readonly MemoryPack.MemoryPackWriterOptionalStateoptionalState  // 0x40
METHODS:
  System.Void WriteVarInt(System.Byte x)
  System.Void WriteVarInt(System.SByte x)
  System.Void WriteVarInt(System.UInt16 x)
  System.Void WriteVarInt(System.Int16 x)
  System.Void WriteVarInt(System.UInt32 x)
  System.Void WriteVarInt(System.Int32 x)
  System.Void WriteVarInt(System.UInt64 x)
  System.Void WriteVarInt(System.Int64 x)
  System.Int32 get_WrittenCount()
  System.Int32 get_BufferLength()
  MemoryPack.MemoryPackWriterOptionalState get_OptionalState()
  MemoryPack.MemoryPackSerializerOptions get_Options()
  System.Void .ctor(System.Buffers.IBufferWriter<System.Byte>& writer, MemoryPack.MemoryPackWriterOptionalState optionalState)
  System.Void .ctor(System.Buffers.IBufferWriter<System.Byte>& writer, System.Byte[] firstBufferOfWriter, MemoryPack.MemoryPackWriterOptionalState optionalState)
  System.Void .ctor(System.Buffers.IBufferWriter<System.Byte>& writer, System.Span<System.Byte> firstBufferOfWriter, MemoryPack.MemoryPackWriterOptionalState optionalState)
  System.Byte& GetSpanReference(System.Int32 sizeHint)
  System.Void RequestNewBuffer(System.Int32 sizeHint)
  System.Void Advance(System.Int32 count)
  System.Void Flush()
  MemoryPack.IMemoryPackFormatter GetFormatter(System.Type type)
  MemoryPack.IMemoryPackFormatter<T> GetFormatter()
  System.Int32 GetStringWriteLength(System.String value)
  System.Int32 GetUnmanageArrayWriteLength(T[] value)
  System.Void WriteObjectHeader(System.Byte memberCount)
  System.Void WriteNullObjectHeader()
  System.Void WriteObjectReferenceId(System.UInt32 referenceId)
  System.Void WriteUnionHeader(System.UInt16 tag)
  System.Void WriteNullUnionHeader()
  System.Void WriteCollectionHeader(System.Int32 length)
  System.Void WriteNullCollectionHeader()
  System.Void WriteString(System.String value)
  System.Void WriteUtf16(System.String value)
  System.Void WriteUtf16(System.ReadOnlySpan<System.Char> value)
  System.Void WriteUtf8(System.String value)
  System.Void WriteUtf8(System.ReadOnlySpan<System.Byte> utf8Value, System.Int32 utf16Length)
  System.Void WriteUnmanaged(T1& value1)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1)
  System.Void WriteUnmanaged(T1& value1, T2& value2)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14)
  System.Void WriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15)
  System.Void WriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15)
  System.Void DangerousWriteUnmanaged(T1& value1)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14)
  System.Void DangerousWriteUnmanaged(T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15)
  System.Void DangerousWriteUnmanagedWithObjectHeader(System.Byte propertyCount, T1& value1, T2& value2, T3& value3, T4& value4, T5& value5, T6& value6, T7& value7, T8& value8, T9& value9, T10& value10, T11& value11, T12& value12, T13& value13, T14& value14, T15& value15)
END_CLASS

CLASS: MemoryPack.MemoryPackSerializationException
TYPE:  class
TOKEN: 0x2000027
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void ThrowMessage(System.String message)
  System.Void ThrowInvalidPropertyCount(System.Byte expected, System.Byte actual)
  System.Void ThrowInvalidPropertyCount(System.Type type, System.Byte expected, System.Byte actual)
  System.Void ThrowInvalidCollection()
  System.Void ThrowInvalidRange(System.Int32 expected, System.Int32 actual)
  System.Void ThrowInvalidAdvance()
  System.Void ThrowSequenceReachedEnd()
  System.Void ThrowWriteInvalidMemberCount(System.Byte memberCount)
  System.Void ThrowInsufficientBufferUnless(System.Int32 length)
  System.Void ThrowNotRegisteredInProvider(System.Type type)
  System.Void ThrowRegisterInProviderFailed(System.Type type, System.Exception innerException)
  System.Void ThrowNotFoundInUnionType(System.Type actualType, System.Type baseType)
  System.Void ThrowInvalidTag(System.UInt16 tag, System.Type baseType)
  System.Void ThrowReachedDepthLimit(System.Type type)
  System.Void ThrowInvalidConcurrrentCollectionOperation()
  System.Void ThrowDeserializeObjectIsNull(System.String target)
  System.Void ThrowFailedEncoding(System.Buffers.OperationStatus status)
  System.Void ThrowCompressionFailed(System.Buffers.OperationStatus status)
  System.Void ThrowCompressionFailed()
  System.Void ThrowAlreadyDecompressed()
  System.Void ThrowDecompressionSizeLimitExceeded(System.Int32 limit, System.Int32 size)
END_CLASS

CLASS: MemoryPack.MemoryPackSerializer
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  private   static  MemoryPack.MemoryPackReaderOptionalStatethreadStaticReaderOptionalState  // 0xFFFFFFFF
  private   static  MemoryPack.MemoryPackSerializer.SerializerWriterThreadStaticStatethreadStaticState  // 0xFFFFFFFF
  private   static  MemoryPack.MemoryPackWriterOptionalStatethreadStaticWriterOptionalState  // 0xFFFFFFFF
METHODS:
  T Deserialize(System.ReadOnlySpan<System.Byte> buffer, MemoryPack.MemoryPackSerializerOptions options)
  System.Int32 Deserialize(System.ReadOnlySpan<System.Byte> buffer, T& value, MemoryPack.MemoryPackSerializerOptions options)
  T Deserialize(System.Buffers.ReadOnlySequence<System.Byte>& buffer, MemoryPack.MemoryPackSerializerOptions options)
  System.Int32 Deserialize(System.Buffers.ReadOnlySequence<System.Byte>& buffer, T& value, MemoryPack.MemoryPackSerializerOptions options)
  System.Int32 Deserialize(System.Buffers.ReadOnlySequence<System.Byte>& buffer, System.Object& value, System.Type type, MemoryPack.MemoryPackSerializerOptions options)
  System.Threading.Tasks.ValueTask<T> DeserializeAsync(System.IO.Stream stream, MemoryPack.MemoryPackSerializerOptions options, System.Threading.CancellationToken cancellationToken)
  System.Object Deserialize(System.Type type, System.ReadOnlySpan<System.Byte> buffer, MemoryPack.MemoryPackSerializerOptions options)
  System.Int32 Deserialize(System.Type type, System.ReadOnlySpan<System.Byte> buffer, System.Object& value, MemoryPack.MemoryPackSerializerOptions options)
  System.Object Deserialize(System.Type type, System.Buffers.ReadOnlySequence<System.Byte>& buffer, MemoryPack.MemoryPackSerializerOptions options)
  System.Int32 Deserialize(System.Type type, System.Buffers.ReadOnlySequence<System.Byte>& buffer, System.Object& value, MemoryPack.MemoryPackSerializerOptions options)
  System.Threading.Tasks.ValueTask<System.Object> DeserializeAsync(System.Type type, System.IO.Stream stream, MemoryPack.MemoryPackSerializerOptions options, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: MemoryPack.MemoryPackSerializerOptions
TYPE:  class
TOKEN: 0x200002C
FIELDS:
  public    static readonly MemoryPack.MemoryPackSerializerOptionsDefault  // 0x0
  public    static readonly MemoryPack.MemoryPackSerializerOptionsUtf8  // 0x8
  public    static readonly MemoryPack.MemoryPackSerializerOptionsUtf16  // 0x10
  private   readonly MemoryPack.StringEncoding       <StringEncoding>k__BackingField  // 0x10
  private   readonly System.IServiceProvider         <ServiceProvider>k__BackingField  // 0x18
METHODS:
  System.Type get_EqualityContract()
  MemoryPack.StringEncoding get_StringEncoding()
  System.Void set_StringEncoding(MemoryPack.StringEncoding value)
  System.IServiceProvider get_ServiceProvider()
  System.Void set_ServiceProvider(System.IServiceProvider value)
  System.String ToString()
  System.Boolean PrintMembers(System.Text.StringBuilder builder)
  System.Boolean op_Inequality(MemoryPack.MemoryPackSerializerOptions r1, MemoryPack.MemoryPackSerializerOptions r2)
  System.Boolean op_Equality(MemoryPack.MemoryPackSerializerOptions r1, MemoryPack.MemoryPackSerializerOptions r2)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(MemoryPack.MemoryPackSerializerOptions other)
  MemoryPack.MemoryPackSerializerOptions <Clone>$()
  System.Void .ctor(MemoryPack.MemoryPackSerializerOptions original)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.StringEncoding
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  MemoryPack.StringEncoding       Utf16  // 0x0
  public    static  MemoryPack.StringEncoding       Utf8  // 0x0
METHODS:
END_CLASS

CLASS: MemoryPack.MemoryPackWriterOptionalStatePool
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  private   static readonly System.Collections.Concurrent.ConcurrentQueue<MemoryPack.MemoryPackWriterOptionalState>queue  // 0x0
METHODS:
  MemoryPack.MemoryPackWriterOptionalState Rent(MemoryPack.MemoryPackSerializerOptions options)
  System.Void Return(MemoryPack.MemoryPackWriterOptionalState state)
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.MemoryPackWriterOptionalState
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  private   static readonly MemoryPack.MemoryPackWriterOptionalStateNullState  // 0x0
  private           System.UInt32                   nextId  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Object,System.UInt32>objectToRef  // 0x18
  private           MemoryPack.MemoryPackSerializerOptions<Options>k__BackingField  // 0x20
METHODS:
  MemoryPack.MemoryPackSerializerOptions get_Options()
  System.Void set_Options(MemoryPack.MemoryPackSerializerOptions value)
  System.Void .ctor()
  System.Void .ctor(System.Boolean _)
  System.Void Init(MemoryPack.MemoryPackSerializerOptions options)
  System.Void Reset()
  System.ValueTuple<System.Boolean,System.UInt32> GetOrAddReference(System.Object value)
  System.Void System.IDisposable.Dispose()
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.AnimationCurveFormatter
TYPE:  class
TOKEN: 0x2000031
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void SerializeKeyFrame(UnityEngine.Keyframe keyframe, MemoryPack.MemoryPackWriter& writer)
  System.Void DeserializeKeyFrame(MemoryPack.MemoryPackReader& reader, UnityEngine.Keyframe& keyframe)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, UnityEngine.AnimationCurve& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.GradientFormatter
TYPE:  class
TOKEN: 0x2000032
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, UnityEngine.Gradient& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.RectOffsetFormatter
TYPE:  class
TOKEN: 0x2000033
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, UnityEngine.RectOffset& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Compression.BitPackFormatter
TYPE:  class
TOKEN: 0x200009E
EXTENDS: MemoryPackFormatter`1
FIELDS:
  public    static readonly MemoryPack.Compression.BitPackFormatterDefault  // 0x0
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Boolean[]& value)
  System.Boolean Get(System.Int32 data, System.Int32 index)
  System.Void Set(System.Int32& data, System.Int32 index, System.Boolean value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Compression.BrotliCompressor
TYPE:  class
TOKEN: 0x200009F
FIELDS:
  private           MemoryPack.Internal.ReusableLinkedArrayBufferWriterbufferWriter  // 0x10
  private   readonly System.Int32                    quality  // 0x18
  private   readonly System.Int32                    window  // 0x1C
METHODS:
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel)
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window)
  System.Void .ctor(System.Int32 quality, System.Int32 window)
  System.Void System.Buffers.IBufferWriter<System.Byte>.Advance(System.Int32 count)
  System.Memory<System.Byte> System.Buffers.IBufferWriter<System.Byte>.GetMemory(System.Int32 sizeHint)
  System.Span<System.Byte> System.Buffers.IBufferWriter<System.Byte>.GetSpan(System.Int32 sizeHint)
  System.Byte[] ToArray()
  System.Void CopyTo(System.Buffers.IBufferWriter<System.Byte>& destBufferWriter)
  System.Threading.Tasks.ValueTask CopyToAsync(System.IO.Stream stream, System.Int32 bufferSize, System.Threading.CancellationToken cancellationToken)
  System.Void CopyTo(MemoryPack.MemoryPackWriter& memoryPackWriter)
  System.Int32 CompressCore(System.IO.Compression.BrotliEncoder& encoder, System.ReadOnlySpan<System.Byte> source, System.Buffers.IBufferWriter<System.Byte>& destBufferWriter, System.Nullable<System.Int32> initialLength, System.Boolean isFinalBlock)
  System.Int32 CompressCore(System.IO.Compression.BrotliEncoder& encoder, System.ReadOnlySpan<System.Byte> source, MemoryPack.MemoryPackWriter& destBufferWriter, System.Nullable<System.Int32> initialLength, System.Boolean isFinalBlock)
  System.Void Dispose()
  System.Void ThrowIfDisposed()
END_CLASS

CLASS: MemoryPack.Compression.BrotliUtils
TYPE:  class
TOKEN: 0x20000A1
FIELDS:
  public    static  System.Int32                    WindowBits_Min  // 0x0
  public    static  System.Int32                    WindowBits_Default  // 0x0
  public    static  System.Int32                    WindowBits_Max  // 0x0
  public    static  System.Int32                    Quality_Min  // 0x0
  public    static  System.Int32                    Quality_Default  // 0x0
  public    static  System.Int32                    Quality_Max  // 0x0
  public    static  System.Int32                    MaxInputSize  // 0x0
METHODS:
  System.Int32 GetQualityFromCompressionLevel(System.IO.Compression.CompressionLevel compressionLevel)
  System.Int32 BrotliEncoderMaxCompressedSize(System.Int32 input_size)
END_CLASS

CLASS: MemoryPack.Compression.BrotliDecompressor
TYPE:  struct
TOKEN: 0x20000A2
FIELDS:
  private           MemoryPack.Internal.ReusableReadOnlySequenceBuildersequenceBuilder  // 0x10
METHODS:
  System.Buffers.ReadOnlySequence<System.Byte> Decompress(System.ReadOnlySpan<System.Byte> compressedSpan)
  System.Buffers.ReadOnlySequence<System.Byte> Decompress(System.ReadOnlySpan<System.Byte> compressedSpan, System.Int32& consumed)
  System.Buffers.ReadOnlySequence<System.Byte> Decompress(System.Buffers.ReadOnlySequence<System.Byte> compressedSequence)
  System.Buffers.ReadOnlySequence<System.Byte> Decompress(System.Buffers.ReadOnlySequence<System.Byte> compressedSequence, System.Int32& consumed)
  System.Void DecompressCore(System.Buffers.OperationStatus& status, System.IO.Compression.BrotliDecoder& decoder, System.ReadOnlySpan<System.Byte> source, System.Int32& consumed)
  System.Void Dispose()
  System.Int32 GetDoubleCapacity(System.Int32 length)
END_CLASS

CLASS: MemoryPack.Compression.BrotliFormatter
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   static  System.Int32                    DefaultDecompssionSizeLimit  // 0x0
  public    static readonly MemoryPack.Compression.BrotliFormatterDefault  // 0x0
  private   readonly System.IO.Compression.CompressionLevelcompressionLevel  // 0x10
  private   readonly System.Int32                    window  // 0x14
  private   readonly System.Int32                    decompressionSizeLimit  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel)
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window)
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window, System.Int32 decompressionSizeLimit)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Byte[]& value)
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Compression.BrotliFormatter`1
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   static  System.Int32                    DefaultDecompssionSizeLimit  // 0x0
  public    static readonly MemoryPack.Compression.BrotliFormatterDefault  // 0x0
  private   readonly System.IO.Compression.CompressionLevelcompressionLevel  // 0x0
  private   readonly System.Int32                    window  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel)
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value)
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Formatters.UnmanagedArrayFormatter`1
TYPE:  class
TOKEN: 0x2000045
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[]& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.DangerousUnmanagedArrayFormatter`1
TYPE:  class
TOKEN: 0x2000046
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[]& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ArrayFormatter`1
TYPE:  class
TOKEN: 0x2000047
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[]& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ArraySegmentFormatter`1
TYPE:  class
TOKEN: 0x2000048
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ArraySegment<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.MemoryFormatter`1
TYPE:  class
TOKEN: 0x2000049
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Memory<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ReadOnlyMemoryFormatter`1
TYPE:  class
TOKEN: 0x200004A
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ReadOnlyMemory<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ReadOnlySequenceFormatter`1
TYPE:  class
TOKEN: 0x200004B
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Buffers.ReadOnlySequence<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.MemoryPoolFormatter`1
TYPE:  class
TOKEN: 0x200004C
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Memory<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ReadOnlyMemoryPoolFormatter`1
TYPE:  class
TOKEN: 0x200004D
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ReadOnlyMemory<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.BigIntegerFormatter
TYPE:  class
TOKEN: 0x200004E
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Numerics.BigInteger& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.BitArrayFormatter
TYPE:  class
TOKEN: 0x200004F
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.BitArray& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.BitArrayView
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  public            System.Int32[]                  m_array  // 0x10
  public            System.Int32                    m_length  // 0x18
  public            System.Int32                    _version  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ListFormatter
TYPE:  class
TOKEN: 0x2000051
FIELDS:
METHODS:
  System.Collections.Generic.List<T> DeserializePackable(MemoryPack.MemoryPackReader& reader)
  System.Void DeserializePackable(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.List<T>& value)
END_CLASS

CLASS: MemoryPack.Formatters.ListFormatter`1
TYPE:  class
TOKEN: 0x2000052
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.List<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.StackFormatter`1
TYPE:  class
TOKEN: 0x2000053
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.Stack<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.QueueFormatter`1
TYPE:  class
TOKEN: 0x2000054
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.Queue<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.LinkedListFormatter`1
TYPE:  class
TOKEN: 0x2000055
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.LinkedList<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.HashSetFormatter`1
TYPE:  class
TOKEN: 0x2000056
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IEqualityComparer<T>equalityComparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<T> equalityComparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.HashSet<T>& value)
END_CLASS

CLASS: MemoryPack.Formatters.SortedSetFormatter`1
TYPE:  class
TOKEN: 0x2000057
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IComparer<T>comparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IComparer<T> comparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.SortedSet<T>& value)
END_CLASS

CLASS: MemoryPack.Formatters.CollectionFormatter`1
TYPE:  class
TOKEN: 0x2000058
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.ObjectModel.Collection<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ObservableCollectionFormatter`1
TYPE:  class
TOKEN: 0x2000059
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.ObjectModel.ObservableCollection<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ConcurrentQueueFormatter`1
TYPE:  class
TOKEN: 0x200005A
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.ConcurrentQueue<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ConcurrentStackFormatter`1
TYPE:  class
TOKEN: 0x200005B
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.ConcurrentStack<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ConcurrentBagFormatter`1
TYPE:  class
TOKEN: 0x200005C
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.ConcurrentBag<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.DictionaryFormatter`2
TYPE:  class
TOKEN: 0x200005D
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IEqualityComparer<TKey>equalityComparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.Dictionary<TKey,TValue>& value)
END_CLASS

CLASS: MemoryPack.Formatters.SortedDictionaryFormatter`2
TYPE:  class
TOKEN: 0x200005E
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IComparer<TKey>comparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IComparer<TKey> comparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.SortedDictionary<TKey,TValue>& value)
END_CLASS

CLASS: MemoryPack.Formatters.SortedListFormatter`2
TYPE:  class
TOKEN: 0x200005F
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IComparer<TKey>comparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IComparer<TKey> comparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.SortedList<TKey,TValue>& value)
END_CLASS

CLASS: MemoryPack.Formatters.ConcurrentDictionaryFormatter`2
TYPE:  class
TOKEN: 0x2000060
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IEqualityComparer<TKey>equalityComparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue>& value)
END_CLASS

CLASS: MemoryPack.Formatters.ReadOnlyCollectionFormatter`1
TYPE:  class
TOKEN: 0x2000061
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.ObjectModel.ReadOnlyCollection<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ReadOnlyObservableCollectionFormatter`1
TYPE:  class
TOKEN: 0x2000062
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.ObjectModel.ReadOnlyObservableCollection<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.BlockingCollectionFormatter`1
TYPE:  class
TOKEN: 0x2000063
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Concurrent.BlockingCollection<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.CultureInfoFormatter
TYPE:  class
TOKEN: 0x2000064
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Globalization.CultureInfo& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.DynamicUnionFormatter`1
TYPE:  class
TOKEN: 0x2000065
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Type,System.UInt16>typeToTag  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.UInt16,System.Type>tagToType  // 0x0
METHODS:
  System.Void .ctor(System.ValueTuple<System.UInt16,System.Type>[] memoryPackUnions)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value)
END_CLASS

CLASS: MemoryPack.Formatters.GenericCollectionFormatter`2
TYPE:  class
TOKEN: 0x2000067
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, TCollection& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.GenericSetFormatterBase`2
TYPE:  class
TOKEN: 0x2000068
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  TSet CreateSet()
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, TSet& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.GenericSetFormatter`2
TYPE:  class
TOKEN: 0x2000069
EXTENDS: GenericSetFormatterBase`2
FIELDS:
METHODS:
  TSet CreateSet()
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.GenericDictionaryFormatterBase`3
TYPE:  class
TOKEN: 0x200006A
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  TDictionary CreateDictionary()
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, TDictionary& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.GenericDictionaryFormatter`3
TYPE:  class
TOKEN: 0x200006B
EXTENDS: GenericDictionaryFormatterBase`3
FIELDS:
METHODS:
  TDictionary CreateDictionary()
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceCollectionFormatterUtils
TYPE:  class
TOKEN: 0x200006C
FIELDS:
METHODS:
  System.Collections.Generic.List<T> ReadList(MemoryPack.MemoryPackReader& reader)
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceEnumerableFormatter`1
TYPE:  class
TOKEN: 0x200006D
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IEnumerable<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceCollectionFormatter`1
TYPE:  class
TOKEN: 0x200006E
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void .cctor()
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.ICollection<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceReadOnlyCollectionFormatter`1
TYPE:  class
TOKEN: 0x200006F
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void .cctor()
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IReadOnlyCollection<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceListFormatter`1
TYPE:  class
TOKEN: 0x2000070
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void .cctor()
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IList<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceReadOnlyListFormatter`1
TYPE:  class
TOKEN: 0x2000071
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void .cctor()
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IReadOnlyList<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceDictionaryFormatter`2
TYPE:  class
TOKEN: 0x2000072
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IEqualityComparer<TKey>equalityComparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IDictionary<TKey,TValue>& value)
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceReadOnlyDictionaryFormatter`2
TYPE:  class
TOKEN: 0x2000073
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IEqualityComparer<TKey>equalityComparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>& value)
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceLookupFormatter`2
TYPE:  class
TOKEN: 0x2000074
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IEqualityComparer<TKey>equalityComparer  // 0x0
METHODS:
  System.Void .cctor()
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Linq.ILookup<TKey,TElement>& value)
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceGroupingFormatter`2
TYPE:  class
TOKEN: 0x2000075
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void .cctor()
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Linq.IGrouping<TKey,TElement>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.InterfaceSetFormatter`1
TYPE:  class
TOKEN: 0x2000076
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   readonly System.Collections.Generic.IEqualityComparer<T>equalityComparer  // 0x0
METHODS:
  System.Void .cctor()
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<T> equalityComparer)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.ISet<T>& value)
END_CLASS

CLASS: MemoryPack.Formatters.Grouping`2
TYPE:  class
TOKEN: 0x2000077
FIELDS:
  private   readonly TKey                            key  // 0x0
  private   readonly System.Collections.Generic.IEnumerable<TElement>elements  // 0x0
METHODS:
  System.Void .ctor(TKey key, System.Collections.Generic.IEnumerable<TElement> elements)
  TKey get_Key()
  System.Collections.Generic.IEnumerator<TElement> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: MemoryPack.Formatters.Lookup`2
TYPE:  class
TOKEN: 0x2000078
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<TKey,System.Linq.IGrouping<TKey,TElement>>groupings  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.Dictionary<TKey,System.Linq.IGrouping<TKey,TElement>> groupings)
  System.Collections.Generic.IEnumerable<TElement> get_Item(TKey key)
  System.Int32 get_Count()
  System.Boolean Contains(TKey key)
  System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: MemoryPack.Formatters.KeyValuePairFormatter
TYPE:  class
TOKEN: 0x2000079
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.IMemoryPackFormatter<TKey> keyFormatter, MemoryPack.IMemoryPackFormatter<TValue> valueFormatter, MemoryPack.MemoryPackReader& reader, TKey& key, TValue& value)
END_CLASS

CLASS: MemoryPack.Formatters.KeyValuePairFormatter`2
TYPE:  class
TOKEN: 0x200007A
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Collections.Generic.KeyValuePair<TKey,TValue>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.LazyFormatter`1
TYPE:  class
TOKEN: 0x200007B
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Lazy<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TwoDimensionalArrayFormatter`1
TYPE:  class
TOKEN: 0x200007C
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[,]& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ThreeDimensionalArrayFormatter`1
TYPE:  class
TOKEN: 0x200007D
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[,,]& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.FourDimensionalArrayFormatter`1
TYPE:  class
TOKEN: 0x200007E
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T[,,,]& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.NullableFormatter`1
TYPE:  class
TOKEN: 0x200007F
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Nullable<T>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.StringBuilderFormatter
TYPE:  class
TOKEN: 0x2000080
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Text.StringBuilder& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.StringFormatter
TYPE:  class
TOKEN: 0x2000081
EXTENDS: MemoryPackFormatter`1
FIELDS:
  public    static readonly MemoryPack.Formatters.StringFormatterDefault  // 0x0
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Formatters.Utf8StringFormatter
TYPE:  class
TOKEN: 0x2000082
EXTENDS: MemoryPackFormatter`1
FIELDS:
  public    static readonly MemoryPack.Formatters.Utf8StringFormatterDefault  // 0x0
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Formatters.Utf16StringFormatter
TYPE:  class
TOKEN: 0x2000083
EXTENDS: MemoryPackFormatter`1
FIELDS:
  public    static readonly MemoryPack.Formatters.Utf16StringFormatterDefault  // 0x0
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Formatters.InternStringFormatter
TYPE:  class
TOKEN: 0x2000084
EXTENDS: MemoryPackFormatter`1
FIELDS:
  public    static readonly MemoryPack.Formatters.InternStringFormatterDefault  // 0x0
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Formatters.BrotliStringFormatter
TYPE:  class
TOKEN: 0x2000085
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   static  System.Runtime.CompilerServices.StrongBox<System.Int32>threadStaticConsumedBox  // 0xFFFFFFFF
  private   static  System.Int32                    DefaultDecompssionSizeLimit  // 0x0
  public    static readonly MemoryPack.Formatters.BrotliStringFormatterDefault  // 0x0
  private   readonly System.IO.Compression.CompressionLevelcompressionLevel  // 0x10
  private   readonly System.Int32                    window  // 0x14
  private   readonly System.Int32                    decompressionSizeLimit  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel)
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window)
  System.Void .ctor(System.IO.Compression.CompressionLevel compressionLevel, System.Int32 window, System.Int32 decompressionSizeLimit)
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.String& value)
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Formatters.TimeZoneInfoFormatter
TYPE:  class
TOKEN: 0x2000087
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.TimeZoneInfo& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TupleFormatterTypes
TYPE:  class
TOKEN: 0x2000088
FIELDS:
  public    static readonly System.Collections.Generic.Dictionary<System.Type,System.Type>TupleFormatters  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Formatters.TupleFormatter`1
TYPE:  class
TOKEN: 0x2000089
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TupleFormatter`2
TYPE:  class
TOKEN: 0x200008A
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TupleFormatter`3
TYPE:  class
TOKEN: 0x200008B
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TupleFormatter`4
TYPE:  class
TOKEN: 0x200008C
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TupleFormatter`5
TYPE:  class
TOKEN: 0x200008D
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4,T5>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TupleFormatter`6
TYPE:  class
TOKEN: 0x200008E
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4,T5,T6>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TupleFormatter`7
TYPE:  class
TOKEN: 0x200008F
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4,T5,T6,T7>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TupleFormatter`8
TYPE:  class
TOKEN: 0x2000090
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Tuple<T1,T2,T3,T4,T5,T6,T7,TRest>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ValueTupleFormatter`1
TYPE:  class
TOKEN: 0x2000091
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ValueTupleFormatter`2
TYPE:  class
TOKEN: 0x2000092
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ValueTupleFormatter`3
TYPE:  class
TOKEN: 0x2000093
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ValueTupleFormatter`4
TYPE:  class
TOKEN: 0x2000094
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ValueTupleFormatter`5
TYPE:  class
TOKEN: 0x2000095
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4,T5>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ValueTupleFormatter`6
TYPE:  class
TOKEN: 0x2000096
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4,T5,T6>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ValueTupleFormatter`7
TYPE:  class
TOKEN: 0x2000097
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4,T5,T6,T7>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.ValueTupleFormatter`8
TYPE:  class
TOKEN: 0x2000098
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.ValueTuple<T1,T2,T3,T4,T5,T6,T7,TRest>& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.TypeFormatter
TYPE:  class
TOKEN: 0x2000099
EXTENDS: MemoryPackFormatter`1
FIELDS:
  private   static readonly System.Text.RegularExpressions.Regex_shortTypeNameRegex  // 0x0
METHODS:
  System.Text.RegularExpressions.Regex ShortTypeNameRegex()
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Type& value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Formatters.UnmanagedFormatter`1
TYPE:  class
TOKEN: 0x200009A
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.DangerousUnmanagedFormatter`1
TYPE:  class
TOKEN: 0x200009B
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, T& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.UriFormatter
TYPE:  class
TOKEN: 0x200009C
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Uri& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Formatters.VersionFormatter
TYPE:  class
TOKEN: 0x200009D
EXTENDS: MemoryPackFormatter`1
FIELDS:
METHODS:
  System.Void Deserialize(MemoryPack.MemoryPackReader& reader, System.Version& value)
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Internal.EnumerableExtensions
TYPE:  class
TOKEN: 0x2000034
FIELDS:
METHODS:
  System.Boolean TryGetNonEnumeratedCountEx(System.Collections.Generic.IEnumerable<T> value, System.Int32& count)
END_CLASS

CLASS: MemoryPack.Internal.FixedArrayBufferWriter
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  private           System.Byte[]                   buffer  // 0x10
  private           System.Int32                    written  // 0x18
METHODS:
  System.Void .ctor(System.Byte[] buffer)
  System.Void Advance(System.Int32 count)
  System.Memory<System.Byte> GetMemory(System.Int32 sizeHint)
  System.Span<System.Byte> GetSpan(System.Int32 sizeHint)
  System.Byte[] GetFilledBuffer()
END_CLASS

CLASS: MemoryPack.Internal.MathEx
TYPE:  class
TOKEN: 0x2000036
FIELDS:
  private   static  System.Int32                    ArrayMexLength  // 0x0
METHODS:
  System.Int32 NewArrayCapacity(System.Int32 size)
END_CLASS

CLASS: MemoryPack.Internal.MemoryMarshalEx
TYPE:  class
TOKEN: 0x2000037
FIELDS:
METHODS:
  T& GetArrayDataReference(T[] array)
  T[] AllocateUninitializedArray(System.Int32 length, System.Boolean pinned)
END_CLASS

CLASS: MemoryPack.Internal.PreserveAttribute
TYPE:  class
TOKEN: 0x2000038
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MemoryPack.Internal.ReusableLinkedArrayBufferWriterPool
TYPE:  class
TOKEN: 0x2000039
FIELDS:
  private   static readonly System.Collections.Concurrent.ConcurrentQueue<MemoryPack.Internal.ReusableLinkedArrayBufferWriter>queue  // 0x0
METHODS:
  MemoryPack.Internal.ReusableLinkedArrayBufferWriter Rent()
  System.Void Return(MemoryPack.Internal.ReusableLinkedArrayBufferWriter writer)
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Internal.ReusableLinkedArrayBufferWriter
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  private   static  System.Int32                    InitialBufferSize  // 0x0
  private   static readonly System.Byte[]                   noUseFirstBufferSentinel  // 0x0
  private           System.Collections.Generic.List<MemoryPack.Internal.BufferSegment>buffers  // 0x10
  private           System.Byte[]                   firstBuffer  // 0x18
  private           System.Int32                    firstBufferWritten  // 0x20
  private           MemoryPack.Internal.BufferSegmentcurrent  // 0x28
  private           System.Int32                    nextBufferSize  // 0x38
  private           System.Int32                    totalWritten  // 0x3C
METHODS:
  System.Int32 get_TotalWritten()
  System.Boolean get_UseFirstBuffer()
  System.Void .ctor(System.Boolean useFirstBuffer, System.Boolean pinned)
  System.Byte[] DangerousGetFirstBuffer()
  System.Memory<System.Byte> GetMemory(System.Int32 sizeHint)
  System.Span<System.Byte> GetSpan(System.Int32 sizeHint)
  System.Void Advance(System.Int32 count)
  System.Byte[] ToArrayAndReset()
  System.Void WriteToAndReset(MemoryPack.MemoryPackWriter& writer)
  System.Threading.Tasks.ValueTask WriteToAndResetAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
  MemoryPack.Internal.ReusableLinkedArrayBufferWriter.Enumerator GetEnumerator()
  System.Void ResetCore()
  System.Void Reset()
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Internal.BufferSegment
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  private           System.Byte[]                   buffer  // 0x10
  private           System.Int32                    written  // 0x18
METHODS:
  System.Boolean get_IsNull()
  System.Int32 get_WrittenCount()
  System.Span<System.Byte> get_WrittenBuffer()
  System.Memory<System.Byte> get_WrittenMemory()
  System.Span<System.Byte> get_FreeBuffer()
  System.Void .ctor(System.Int32 size)
  System.Void Advance(System.Int32 count)
  System.Void Clear()
END_CLASS

CLASS: MemoryPack.Internal.ReusableReadOnlySequenceBuilderPool
TYPE:  class
TOKEN: 0x200003F
FIELDS:
  private   static readonly System.Collections.Concurrent.ConcurrentQueue<MemoryPack.Internal.ReusableReadOnlySequenceBuilder>queue  // 0x0
METHODS:
  MemoryPack.Internal.ReusableReadOnlySequenceBuilder Rent()
  System.Void Return(MemoryPack.Internal.ReusableReadOnlySequenceBuilder builder)
  System.Void .cctor()
END_CLASS

CLASS: MemoryPack.Internal.ReusableReadOnlySequenceBuilder
TYPE:  class
TOKEN: 0x2000040
FIELDS:
  private   readonly System.Collections.Generic.Stack<MemoryPack.Internal.ReusableReadOnlySequenceBuilder.Segment>segmentPool  // 0x10
  private   readonly System.Collections.Generic.List<MemoryPack.Internal.ReusableReadOnlySequenceBuilder.Segment>list  // 0x18
METHODS:
  System.Void .ctor()
  System.Void Add(System.ReadOnlyMemory<System.Byte> buffer, System.Boolean returnToPool)
  System.Boolean TryGetSingleMemory(System.ReadOnlyMemory<System.Byte>& memory)
  System.Buffers.ReadOnlySequence<System.Byte> Build()
  System.Void Reset()
END_CLASS

CLASS: MemoryPack.Internal.TypeHelpers
TYPE:  class
TOKEN: 0x2000042
FIELDS:
  private   static readonly System.Reflection.MethodInfo    isReferenceOrContainsReferences  // 0x0
  private   static readonly System.Reflection.MethodInfo    unsafeSizeOf  // 0x8
METHODS:
  System.Boolean IsReferenceOrNullable()
  MemoryPack.Internal.TypeHelpers.TypeKind TryGetUnmanagedSZArrayElementSizeOrMemoryPackableFixedSize(System.Int32& size)
  System.Boolean IsAnonymous(System.Type type)
  System.Void .cctor()
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

CLASS: System.Runtime.CompilerServices.NullableAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
  public    readonly System.Byte[]                   NullableFlags  // 0x10
METHODS:
  System.Void .ctor(System.Byte )
  System.Void .ctor(System.Byte[] )
END_CLASS

CLASS: System.Runtime.CompilerServices.NullableContextAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  public    readonly System.Byte                     Flag  // 0x10
METHODS:
  System.Void .ctor(System.Byte )
END_CLASS

CLASS: System.Runtime.CompilerServices.IsExternalInit
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

