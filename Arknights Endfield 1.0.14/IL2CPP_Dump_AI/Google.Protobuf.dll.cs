// ========================================================
// Dumped by @desirepro
// Assembly: Google.Protobuf.dll
// Classes:  318
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: OutOfSpaceException
TYPE:  class
TOKEN: 0x200000C
EXTENDS: IOException
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ExtensionComparer
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private   static  Google.Protobuf.ExtensionRegistry.ExtensionComparerInstance  // 0x0
METHODS:
  System.Boolean Equals(Google.Protobuf.Extension a, Google.Protobuf.Extension b)
  System.Int32 GetHashCode(Google.Protobuf.Extension a)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: WrapperCodecs
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Object>Codecs  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Object>Readers  // 0x8
METHODS:
  Google.Protobuf.FieldCodec<T> GetCodec()
  Google.Protobuf.ValueReader<System.Nullable<T>> GetReader()
  T Read(Google.Protobuf.ParseContext& ctx, Google.Protobuf.FieldCodec<T> codec)
  System.Void Write(Google.Protobuf.WriteContext& ctx, T value, Google.Protobuf.FieldCodec<T> codec)
  System.Int32 CalculateSize(T value, Google.Protobuf.FieldCodec<T> codec)
  System.Void .cctor()
END_CLASS

CLASS: InputMerger
TYPE:  class
TOKEN: 0x2000029
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Google.Protobuf.ParseContext& ctx, T& value)
  System.IAsyncResult BeginInvoke(Google.Protobuf.ParseContext& ctx, T& value, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(Google.Protobuf.ParseContext& ctx, T& value, System.IAsyncResult result)
END_CLASS

CLASS: ValuesMerger
TYPE:  class
TOKEN: 0x200002A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(T& value, T other)
  System.IAsyncResult BeginInvoke(T& value, T other, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(T& value, System.IAsyncResult result)
END_CLASS

CLASS: Node
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.FieldMaskTree.Node><Children>k__BackingField  // 0x10
METHODS:
  System.Collections.Generic.Dictionary<System.String,Google.Protobuf.FieldMaskTree.Node> get_Children()
  System.Void .ctor()
END_CLASS

CLASS: Settings
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  private   static readonly Google.Protobuf.JsonFormatter.Settings<Default>k__BackingField  // 0x0
  private   readonly System.Boolean                  <FormatDefaultValues>k__BackingField  // 0x10
  private   readonly Google.Protobuf.Reflection.TypeRegistry<TypeRegistry>k__BackingField  // 0x18
  private   readonly System.Boolean                  <FormatEnumsAsIntegers>k__BackingField  // 0x20
  private   readonly System.Boolean                  <PreserveProtoFieldNames>k__BackingField  // 0x21
METHODS:
  Google.Protobuf.JsonFormatter.Settings get_Default()
  System.Void .cctor()
  System.Boolean get_FormatDefaultValues()
  Google.Protobuf.Reflection.TypeRegistry get_TypeRegistry()
  System.Boolean get_FormatEnumsAsIntegers()
  System.Boolean get_PreserveProtoFieldNames()
  System.Void .ctor(System.Boolean formatDefaultValues)
  System.Void .ctor(System.Boolean formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry)
  System.Void .ctor(System.Boolean formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry, System.Boolean formatEnumsAsIntegers, System.Boolean preserveProtoFieldNames)
  Google.Protobuf.JsonFormatter.Settings WithFormatDefaultValues(System.Boolean formatDefaultValues)
  Google.Protobuf.JsonFormatter.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry)
  Google.Protobuf.JsonFormatter.Settings WithFormatEnumsAsIntegers(System.Boolean formatEnumsAsIntegers)
  Google.Protobuf.JsonFormatter.Settings WithPreserveProtoFieldNames(System.Boolean preserveProtoFieldNames)
END_CLASS

CLASS: OriginalEnumValueHelper
TYPE:  class
TOKEN: 0x200003B
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Object,System.String>>dictionaries  // 0x0
METHODS:
  System.String GetOriginalName(System.Object value)
  System.Collections.Generic.Dictionary<System.Object,System.String> GetNameMapping(System.Type enumType)
  System.Void .cctor()
END_CLASS

CLASS: Settings
TYPE:  class
TOKEN: 0x200003E
FIELDS:
  private   static readonly Google.Protobuf.JsonParser.Settings<Default>k__BackingField  // 0x0
  private   readonly System.Int32                    <RecursionLimit>k__BackingField  // 0x10
  private   readonly Google.Protobuf.Reflection.TypeRegistry<TypeRegistry>k__BackingField  // 0x18
  private   readonly System.Boolean                  <IgnoreUnknownFields>k__BackingField  // 0x20
METHODS:
  Google.Protobuf.JsonParser.Settings get_Default()
  System.Void .cctor()
  System.Int32 get_RecursionLimit()
  Google.Protobuf.Reflection.TypeRegistry get_TypeRegistry()
  System.Boolean get_IgnoreUnknownFields()
  System.Void .ctor(System.Int32 recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry, System.Boolean ignoreUnknownFields)
  System.Void .ctor(System.Int32 recursionLimit)
  System.Void .ctor(System.Int32 recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry)
  Google.Protobuf.JsonParser.Settings WithIgnoreUnknownFields(System.Boolean ignoreUnknownFields)
  Google.Protobuf.JsonParser.Settings WithRecursionLimit(System.Int32 recursionLimit)
  Google.Protobuf.JsonParser.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry)
END_CLASS

CLASS: TokenType
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.JsonToken.TokenTypeNull  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeFalse  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeTrue  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeStringValue  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeNumber  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeName  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeStartObject  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeEndObject  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeStartArray  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeEndArray  // 0x0
  public    static  Google.Protobuf.JsonToken.TokenTypeEndDocument  // 0x0
METHODS:
END_CLASS

CLASS: JsonReplayTokenizer
TYPE:  class
TOKEN: 0x2000043
EXTENDS: JsonTokenizer
FIELDS:
  private   readonly System.Collections.Generic.IList<Google.Protobuf.JsonToken>tokens  // 0x20
  private   readonly Google.Protobuf.JsonTokenizer   nextTokenizer  // 0x28
  private           System.Int32                    nextTokenIndex  // 0x30
METHODS:
  System.Void .ctor(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer nextTokenizer)
  Google.Protobuf.JsonToken NextImpl()
END_CLASS

CLASS: ContainerType
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerTypeDocument  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerTypeObject  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerTypeArray  // 0x0
METHODS:
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateStartOfDocument  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateExpectedEndOfDocument  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateReaderExhausted  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectStart  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectBeforeColon  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectAfterColon  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectAfterProperty  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectAfterComma  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateArrayStart  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateArrayAfterValue  // 0x0
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateArrayAfterComma  // 0x0
METHODS:
END_CLASS

CLASS: PushBackReader
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  private   readonly System.IO.TextReader            reader  // 0x10
  private           System.Nullable<System.Char>    nextChar  // 0x18
METHODS:
  System.Void .ctor(System.IO.TextReader reader)
  System.Nullable<System.Char> Read()
  System.Char ReadOrFail(System.String messageOnFailure)
  System.Void PushBack(System.Char c)
  Google.Protobuf.InvalidJsonException CreateException(System.String message)
END_CLASS

CLASS: JsonTextTokenizer
TYPE:  class
TOKEN: 0x2000044
EXTENDS: JsonTokenizer
FIELDS:
  private   static readonly Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateValueStates  // 0x0
  private   readonly System.Collections.Generic.Stack<Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType>containerStack  // 0x20
  private   readonly Google.Protobuf.JsonTokenizer.JsonTextTokenizer.PushBackReaderreader  // 0x28
  private           Google.Protobuf.JsonTokenizer.JsonTextTokenizer.Statestate  // 0x30
METHODS:
  System.Void .ctor(System.IO.TextReader reader)
  Google.Protobuf.JsonToken NextImpl()
  System.Void ValidateState(Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State validStates, System.String errorPrefix)
  System.String ReadString()
  System.Char ReadEscapedCharacter()
  System.Char ReadUnicodeEscape()
  System.Void ConsumeLiteral(System.String text)
  System.Double ReadNumber(System.Char initialCharacter)
  System.Nullable<System.Char> ReadInt(System.Text.StringBuilder builder)
  System.Nullable<System.Char> ReadFrac(System.Text.StringBuilder builder)
  System.Nullable<System.Char> ReadExp(System.Text.StringBuilder builder)
  System.Nullable<System.Char> ConsumeDigits(System.Text.StringBuilder builder, System.Int32& count)
  System.Void ValidateAndModifyStateForValue(System.String errorPrefix)
  System.Void PopContainer()
  System.Void .cctor()
END_CLASS

CLASS: WireType
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Google.Protobuf.WireFormat.WireTypeVarint  // 0x0
  public    static  Google.Protobuf.WireFormat.WireTypeFixed64  // 0x0
  public    static  Google.Protobuf.WireFormat.WireTypeLengthDelimited  // 0x0
  public    static  Google.Protobuf.WireFormat.WireTypeStartGroup  // 0x0
  public    static  Google.Protobuf.WireFormat.WireTypeEndGroup  // 0x0
  public    static  Google.Protobuf.WireFormat.WireTypeFixed32  // 0x0
METHODS:
END_CLASS

CLASS: MergeOptions
TYPE:  class
TOKEN: 0x2000072
FIELDS:
  private           System.Boolean                  <ReplaceMessageFields>k__BackingField  // 0x10
  private           System.Boolean                  <ReplaceRepeatedFields>k__BackingField  // 0x11
  private           System.Boolean                  <ReplacePrimitiveFields>k__BackingField  // 0x12
METHODS:
  System.Boolean get_ReplaceMessageFields()
  System.Void set_ReplaceMessageFields(System.Boolean value)
  System.Boolean get_ReplaceRepeatedFields()
  System.Void set_ReplaceRepeatedFields(System.Boolean value)
  System.Boolean get_ReplacePrimitiveFields()
  System.Void set_ReplacePrimitiveFields(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: KindOneofCase
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseNone  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseNullValue  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseNumberValue  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseStringValue  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseBoolValue  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseStructValue  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseListValue  // 0x0
METHODS:
END_CLASS

CLASS: Kind
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeUnknown  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeDouble  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeFloat  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeInt64  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeUint64  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeInt32  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeFixed64  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeFixed32  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeBool  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeString  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeGroup  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeMessage  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeBytes  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeUint32  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeEnum  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeSfixed32  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeSfixed64  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeSint32  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeSint64  // 0x0
METHODS:
END_CLASS

CLASS: Cardinality
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.CardinalityUnknown  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.CardinalityOptional  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.CardinalityRequired  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.CardinalityRepeated  // 0x0
METHODS:
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x2000089
FIELDS:
METHODS:
END_CLASS

CLASS: ExtensionRange
TYPE:  class
TOKEN: 0x20000AF
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    StartFieldNumber  // 0x0
  private   static readonly System.Int32                    StartDefaultValue  // 0x8
  private           System.Int32                    start_  // 0x1C
  public    static  System.Int32                    EndFieldNumber  // 0x0
  private   static readonly System.Int32                    EndDefaultValue  // 0xC
  private           System.Int32                    end_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.ExtensionRangeOptionsoptions_  // 0x28
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other)
  Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange Clone()
  System.Int32 get_Start()
  System.Void set_Start(System.Int32 value)
  System.Boolean get_HasStart()
  System.Void ClearStart()
  System.Int32 get_End()
  System.Void set_End(System.Int32 value)
  System.Boolean get_HasEnd()
  System.Void ClearEnd()
  Google.Protobuf.Reflection.ExtensionRangeOptions get_Options()
  System.Void set_Options(Google.Protobuf.Reflection.ExtensionRangeOptions value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: ReservedRange
TYPE:  class
TOKEN: 0x20000B1
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    StartFieldNumber  // 0x0
  private   static readonly System.Int32                    StartDefaultValue  // 0x8
  private           System.Int32                    start_  // 0x1C
  public    static  System.Int32                    EndFieldNumber  // 0x0
  private   static readonly System.Int32                    EndDefaultValue  // 0xC
  private           System.Int32                    end_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other)
  Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange Clone()
  System.Int32 get_Start()
  System.Void set_Start(System.Int32 value)
  System.Boolean get_HasStart()
  System.Void ClearStart()
  System.Int32 get_End()
  System.Void set_End(System.Int32 value)
  System.Boolean get_HasEnd()
  System.Void ClearEnd()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x20000AE
FIELDS:
METHODS:
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x20000B8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeDouble  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeFloat  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeInt64  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeUint64  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeInt32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeFixed64  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeFixed32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeBool  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeString  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeGroup  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeMessage  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeBytes  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeUint32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeEnum  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeSfixed32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeSfixed64  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeSint32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeSint64  // 0x0
METHODS:
END_CLASS

CLASS: Label
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.LabelOptional  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.LabelRequired  // 0x0
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.LabelRepeated  // 0x0
METHODS:
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x20000B7
FIELDS:
METHODS:
END_CLASS

CLASS: EnumReservedRange
TYPE:  class
TOKEN: 0x20000BF
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    StartFieldNumber  // 0x0
  private   static readonly System.Int32                    StartDefaultValue  // 0x8
  private           System.Int32                    start_  // 0x1C
  public    static  System.Int32                    EndFieldNumber  // 0x0
  private   static readonly System.Int32                    EndDefaultValue  // 0xC
  private           System.Int32                    end_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other)
  Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange Clone()
  System.Int32 get_Start()
  System.Void set_Start(System.Int32 value)
  System.Boolean get_HasStart()
  System.Void ClearStart()
  System.Int32 get_End()
  System.Void set_End(System.Int32 value)
  System.Boolean get_HasEnd()
  System.Void ClearEnd()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x20000BE
FIELDS:
METHODS:
END_CLASS

CLASS: OptimizeMode
TYPE:  struct
TOKEN: 0x20000CA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeSpeed  // 0x0
  public    static  Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeCodeSize  // 0x0
  public    static  Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeLiteRuntime  // 0x0
METHODS:
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x20000C9
FIELDS:
METHODS:
END_CLASS

CLASS: CType
TYPE:  struct
TOKEN: 0x20000D0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.CTypeString  // 0x0
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.CTypeCord  // 0x0
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.CTypeStringPiece  // 0x0
METHODS:
END_CLASS

CLASS: JSType
TYPE:  struct
TOKEN: 0x20000D1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.JSTypeJsNormal  // 0x0
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.JSTypeJsString  // 0x0
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.JSTypeJsNumber  // 0x0
METHODS:
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x20000CF
FIELDS:
METHODS:
END_CLASS

CLASS: IdempotencyLevel
TYPE:  struct
TOKEN: 0x20000DD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelIdempotencyUnknown  // 0x0
  public    static  Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelNoSideEffects  // 0x0
  public    static  Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelIdempotent  // 0x0
METHODS:
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x20000DC
FIELDS:
METHODS:
END_CLASS

CLASS: NamePart
TYPE:  class
TOKEN: 0x20000E1
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NamePart_FieldNumber  // 0x0
  private   static readonly System.String                   NamePart_DefaultValue  // 0x8
  private           System.String                   namePart_  // 0x20
  public    static  System.Int32                    IsExtensionFieldNumber  // 0x0
  private   static readonly System.Boolean                  IsExtensionDefaultValue  // 0x10
  private           System.Boolean                  isExtension_  // 0x28
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other)
  Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart Clone()
  System.String get_NamePart_()
  System.Void set_NamePart_(System.String value)
  System.Boolean get_HasNamePart_()
  System.Void ClearNamePart_()
  System.Boolean get_IsExtension()
  System.Void set_IsExtension(System.Boolean value)
  System.Boolean get_HasIsExtension()
  System.Void ClearIsExtension()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x20000E0
FIELDS:
METHODS:
END_CLASS

CLASS: Location
TYPE:  class
TOKEN: 0x20000E6
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    PathFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_path_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>path_  // 0x18
  public    static  System.Int32                    SpanFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_span_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>span_  // 0x20
  public    static  System.Int32                    LeadingCommentsFieldNumber  // 0x0
  private   static readonly System.String                   LeadingCommentsDefaultValue  // 0x18
  private           System.String                   leadingComments_  // 0x28
  public    static  System.Int32                    TrailingCommentsFieldNumber  // 0x0
  private   static readonly System.String                   TrailingCommentsDefaultValue  // 0x20
  private           System.String                   trailingComments_  // 0x30
  public    static  System.Int32                    LeadingDetachedCommentsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_leadingDetachedComments_codec  // 0x28
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>leadingDetachedComments_  // 0x38
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other)
  Google.Protobuf.Reflection.SourceCodeInfo.Types.Location Clone()
  Google.Protobuf.Collections.RepeatedField<System.Int32> get_Path()
  Google.Protobuf.Collections.RepeatedField<System.Int32> get_Span()
  System.String get_LeadingComments()
  System.Void set_LeadingComments(System.String value)
  System.Boolean get_HasLeadingComments()
  System.Void ClearLeadingComments()
  System.String get_TrailingComments()
  System.Void set_TrailingComments(System.String value)
  System.Boolean get_HasTrailingComments()
  System.Void ClearTrailingComments()
  Google.Protobuf.Collections.RepeatedField<System.String> get_LeadingDetachedComments()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x20000E5
FIELDS:
METHODS:
END_CLASS

CLASS: Annotation
TYPE:  class
TOKEN: 0x20000EB
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    PathFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_path_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>path_  // 0x20
  public    static  System.Int32                    SourceFileFieldNumber  // 0x0
  private   static readonly System.String                   SourceFileDefaultValue  // 0x10
  private           System.String                   sourceFile_  // 0x28
  public    static  System.Int32                    BeginFieldNumber  // 0x0
  private   static readonly System.Int32                    BeginDefaultValue  // 0x18
  private           System.Int32                    begin_  // 0x30
  public    static  System.Int32                    EndFieldNumber  // 0x0
  private   static readonly System.Int32                    EndDefaultValue  // 0x1C
  private           System.Int32                    end_  // 0x34
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other)
  Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation Clone()
  Google.Protobuf.Collections.RepeatedField<System.Int32> get_Path()
  System.String get_SourceFile()
  System.Void set_SourceFile(System.String value)
  System.Boolean get_HasSourceFile()
  System.Void ClearSourceFile()
  System.Int32 get_Begin()
  System.Void set_Begin(System.Int32 value)
  System.Boolean get_HasBegin()
  System.Void ClearBegin()
  System.Int32 get_End()
  System.Void set_End(System.Int32 value)
  System.Boolean get_HasEnd()
  System.Void ClearEnd()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  class
TOKEN: 0x20000EA
FIELDS:
METHODS:
END_CLASS

CLASS: IndexedConverter`2
TYPE:  class
TOKEN: 0x20000F2
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TOutput Invoke(TInput element, System.Int32 index)
  System.IAsyncResult BeginInvoke(TInput element, System.Int32 index, System.AsyncCallback callback, System.Object object)
  TOutput EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FieldCollection
TYPE:  class
TOKEN: 0x2000108
FIELDS:
  private   readonly Google.Protobuf.Reflection.MessageDescriptormessageDescriptor  // 0x10
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor)
  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InDeclarationOrder()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InFieldNumberOrder()
  System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> ByJsonName()
  Google.Protobuf.Reflection.FieldDescriptor get_Item(System.Int32 number)
  Google.Protobuf.Reflection.FieldDescriptor get_Item(System.String name)
END_CLASS

CLASS: IReflectionHelper
TYPE:  interface
TOKEN: 0x2000113
FIELDS:
METHODS:
  System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method)
  System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method)
  System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method)
  System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method)
  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method)
END_CLASS

CLASS: IExtensionReflectionHelper
TYPE:  interface
TOKEN: 0x2000114
FIELDS:
METHODS:
  System.Object GetExtension(Google.Protobuf.IMessage message)
  System.Void SetExtension(Google.Protobuf.IMessage message, System.Object value)
  System.Boolean HasExtension(Google.Protobuf.IMessage message)
  System.Void ClearExtension(Google.Protobuf.IMessage message)
END_CLASS

CLASS: IExtensionSetReflector
TYPE:  interface
TOKEN: 0x2000115
FIELDS:
METHODS:
  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller()
END_CLASS

CLASS: ReflectionHelper`2
TYPE:  class
TOKEN: 0x2000116
FIELDS:
METHODS:
  System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method)
  System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method)
  System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method)
  System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method)
  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: ExtensionReflectionHelper`2
TYPE:  class
TOKEN: 0x200011D
FIELDS:
  private   readonly Google.Protobuf.Extension       extension  // 0x0
METHODS:
  System.Void .ctor(Google.Protobuf.Extension extension)
  System.Object GetExtension(Google.Protobuf.IMessage message)
  System.Boolean HasExtension(Google.Protobuf.IMessage message)
  System.Void SetExtension(Google.Protobuf.IMessage message, System.Object value)
  System.Void ClearExtension(Google.Protobuf.IMessage message)
END_CLASS

CLASS: ExtensionSetReflector`1
TYPE:  class
TOKEN: 0x200011E
FIELDS:
METHODS:
  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller()
  System.Void .ctor()
END_CLASS

CLASS: SampleEnum
TYPE:  struct
TOKEN: 0x2000120
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.ReflectionUtil.SampleEnumX  // 0x0
METHODS:
END_CLASS

CLASS: Builder
TYPE:  class
TOKEN: 0x200012A
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor>types  // 0x10
  private   readonly System.Collections.Generic.HashSet<System.String>fileDescriptorNames  // 0x18
METHODS:
  System.Void .ctor()
  System.Void AddFile(Google.Protobuf.Reflection.FileDescriptor fileDescriptor)
  System.Void AddMessage(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor)
  Google.Protobuf.Reflection.TypeRegistry Build()
END_CLASS

CLASS: DictionaryEnumerator
TYPE:  class
TOKEN: 0x2000130
FIELDS:
  private   readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>enumerator  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> enumerator)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Object get_Current()
  System.Collections.DictionaryEntry get_Entry()
  System.Object get_Key()
  System.Object get_Value()
END_CLASS

CLASS: Codec
TYPE:  class
TOKEN: 0x2000131
FIELDS:
  private   readonly Google.Protobuf.FieldCodec<TKey>keyCodec  // 0x0
  private   readonly Google.Protobuf.FieldCodec<TValue>valueCodec  // 0x0
  private   readonly System.UInt32                   mapTag  // 0x0
METHODS:
  System.Void .ctor(Google.Protobuf.FieldCodec<TKey> keyCodec, Google.Protobuf.FieldCodec<TValue> valueCodec, System.UInt32 mapTag)
  Google.Protobuf.FieldCodec<TKey> get_KeyCodec()
  Google.Protobuf.FieldCodec<TValue> get_ValueCodec()
  System.UInt32 get_MapTag()
END_CLASS

CLASS: MapView`1
TYPE:  class
TOKEN: 0x2000132
FIELDS:
  private   readonly Google.Protobuf.Collections.MapField<TKey,TValue>parent  // 0x0
  private   readonly System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,T>projection  // 0x0
  private   readonly System.Func<T,System.Boolean>   containsCheck  // 0x0
METHODS:
  System.Void .ctor(Google.Protobuf.Collections.MapField<TKey,TValue> parent, System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,T> projection, System.Func<T,System.Boolean> containsCheck)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean get_IsSynchronized()
  System.Object get_SyncRoot()
  System.Void Add(T item)
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Boolean Remove(T item)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void CopyTo(System.Array array, System.Int32 index)
END_CLASS

CLASS: BitwiseDoubleEqualityComparerImpl
TYPE:  class
TOKEN: 0x2000136
EXTENDS: EqualityComparer`1
FIELDS:
METHODS:
  System.Boolean Equals(System.Double x, System.Double y)
  System.Int32 GetHashCode(System.Double obj)
  System.Void .ctor()
END_CLASS

CLASS: BitwiseSingleEqualityComparerImpl
TYPE:  class
TOKEN: 0x2000137
EXTENDS: EqualityComparer`1
FIELDS:
METHODS:
  System.Boolean Equals(System.Single x, System.Single y)
  System.Int32 GetHashCode(System.Single obj)
  System.Void .ctor()
END_CLASS

CLASS: BitwiseNullableDoubleEqualityComparerImpl
TYPE:  class
TOKEN: 0x2000138
EXTENDS: EqualityComparer`1
FIELDS:
METHODS:
  System.Boolean Equals(System.Nullable<System.Double> x, System.Nullable<System.Double> y)
  System.Int32 GetHashCode(System.Nullable<System.Double> obj)
  System.Void .ctor()
END_CLASS

CLASS: BitwiseNullableSingleEqualityComparerImpl
TYPE:  class
TOKEN: 0x2000139
EXTENDS: EqualityComparer`1
FIELDS:
METHODS:
  System.Boolean Equals(System.Nullable<System.Single> x, System.Nullable<System.Single> y)
  System.Int32 GetHashCode(System.Nullable<System.Single> obj)
  System.Void .ctor()
END_CLASS

CLASS: __StaticArrayInitTypeSize=44
TYPE:  struct
TOKEN: 0x200013E
FIELDS:
METHODS:
END_CLASS

CLASS: Google.Protobuf.ByteArray
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  private   static  System.Int32                    CopyThreshold  // 0x0
METHODS:
  System.Void Copy(System.Byte[] src, System.Int32 srcOffset, System.Byte[] dst, System.Int32 dstOffset, System.Int32 count)
  System.Void Reverse(System.Byte[] bytes)
END_CLASS

CLASS: Google.Protobuf.ByteString
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static readonly Google.Protobuf.ByteString      empty  // 0x0
  private   readonly System.ReadOnlyMemory<System.Byte>bytes  // 0x10
METHODS:
  Google.Protobuf.ByteString AttachBytes(System.ReadOnlyMemory<System.Byte> bytes)
  Google.Protobuf.ByteString AttachBytes(System.Byte[] bytes)
  System.Void .ctor(System.ReadOnlyMemory<System.Byte> bytes)
  Google.Protobuf.ByteString get_Empty()
  System.Int32 get_Length()
  System.Boolean get_IsEmpty()
  System.ReadOnlySpan<System.Byte> get_Span()
  System.ReadOnlyMemory<System.Byte> get_Memory()
  System.Byte[] ToByteArray()
  System.String ToBase64()
  Google.Protobuf.ByteString FromBase64(System.String bytes)
  Google.Protobuf.ByteString FromStream(System.IO.Stream stream)
  System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
  Google.Protobuf.ByteString CopyFrom(System.Byte[] bytes)
  Google.Protobuf.ByteString CopyFrom(System.Byte[] bytes, System.Int32 offset, System.Int32 count)
  Google.Protobuf.ByteString CopyFrom(System.ReadOnlySpan<System.Byte> bytes)
  Google.Protobuf.ByteString CopyFrom(System.String text, System.Text.Encoding encoding)
  Google.Protobuf.ByteString CopyFromUtf8(System.String text)
  System.Byte get_Item(System.Int32 index)
  System.String ToString(System.Text.Encoding encoding)
  System.String ToStringUtf8()
  System.Collections.Generic.IEnumerator<System.Byte> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  Google.Protobuf.CodedInputStream CreateCodedInput()
  System.Boolean op_Equality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs)
  System.Boolean op_Inequality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean Equals(Google.Protobuf.ByteString other)
  System.Void CopyTo(System.Byte[] array, System.Int32 position)
  System.Void WriteTo(System.IO.Stream outputStream)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.ByteStringAsync
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsyncCore(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: Google.Protobuf.CodedInputStream
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   readonly System.Boolean                  leaveOpen  // 0x10
  private   readonly System.Byte[]                   buffer  // 0x18
  private   readonly System.IO.Stream                input  // 0x20
  private           Google.Protobuf.ParserInternalStatestate  // 0x28
  private   static  System.Int32                    DefaultRecursionLimit  // 0x0
  private   static  System.Int32                    DefaultSizeLimit  // 0x0
  private   static  System.Int32                    BufferSize  // 0x0
METHODS:
  System.Void .ctor(System.Byte[] buffer)
  System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 length)
  System.Void .ctor(System.IO.Stream input)
  System.Void .ctor(System.IO.Stream input, System.Boolean leaveOpen)
  System.Void .ctor(System.IO.Stream input, System.Byte[] buffer, System.Int32 bufferPos, System.Int32 bufferSize, System.Boolean leaveOpen)
  System.Void .ctor(System.IO.Stream input, System.Byte[] buffer, System.Int32 bufferPos, System.Int32 bufferSize, System.Int32 sizeLimit, System.Int32 recursionLimit, System.Boolean leaveOpen)
  Google.Protobuf.CodedInputStream CreateWithLimits(System.IO.Stream input, System.Int32 sizeLimit, System.Int32 recursionLimit)
  System.Int64 get_Position()
  System.UInt32 get_LastTag()
  System.Int32 get_SizeLimit()
  System.Int32 get_RecursionLimit()
  System.Boolean get_DiscardUnknownFields()
  System.Void set_DiscardUnknownFields(System.Boolean value)
  Google.Protobuf.ExtensionRegistry get_ExtensionRegistry()
  System.Void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value)
  System.Byte[] get_InternalBuffer()
  System.IO.Stream get_InternalInputStream()
  Google.Protobuf.ParserInternalState& get_InternalState()
  System.Void Dispose()
  System.Void CheckReadEndOfStreamTag()
  System.UInt32 PeekTag()
  System.UInt32 ReadTag()
  System.Void SkipLastField()
  System.Void SkipGroup(System.UInt32 startGroupTag)
  System.Double ReadDouble()
  System.Single ReadFloat()
  System.UInt64 ReadUInt64()
  System.Int64 ReadInt64()
  System.Int32 ReadInt32()
  System.UInt64 ReadFixed64()
  System.UInt32 ReadFixed32()
  System.Boolean ReadBool()
  System.String ReadString()
  System.Void ReadMessage(Google.Protobuf.IMessage builder)
  System.Void ReadGroup(Google.Protobuf.IMessage builder)
  Google.Protobuf.ByteString ReadBytes()
  System.UInt32 ReadUInt32()
  System.Int32 ReadEnum()
  System.Int32 ReadSFixed32()
  System.Int64 ReadSFixed64()
  System.Int32 ReadSInt32()
  System.Int64 ReadSInt64()
  System.Int32 ReadLength()
  System.Boolean MaybeConsumeTag(System.UInt32 tag)
  System.UInt32 ReadRawVarint32()
  System.UInt32 ReadRawVarint32(System.IO.Stream input)
  System.UInt64 ReadRawVarint64()
  System.UInt32 ReadRawLittleEndian32()
  System.UInt64 ReadRawLittleEndian64()
  System.Int32 PushLimit(System.Int32 byteLimit)
  System.Void PopLimit(System.Int32 oldLimit)
  System.Boolean get_ReachedLimit()
  System.Boolean get_IsAtEnd()
  System.Boolean RefillBuffer(System.Boolean mustSucceed)
  System.Byte[] ReadRawBytes(System.Int32 size)
  System.Void ReadRawMessage(Google.Protobuf.IMessage message)
END_CLASS

CLASS: Google.Protobuf.CodedOutputStream
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private   static  System.Int32                    LittleEndian64Size  // 0x0
  private   static  System.Int32                    LittleEndian32Size  // 0x0
  private   static  System.Int32                    DoubleSize  // 0x0
  private   static  System.Int32                    FloatSize  // 0x0
  private   static  System.Int32                    BoolSize  // 0x0
  public    static readonly System.Int32                    DefaultBufferSize  // 0x0
  private   readonly System.Boolean                  leaveOpen  // 0x10
  private   readonly System.Byte[]                   buffer  // 0x18
  private           Google.Protobuf.WriterInternalStatestate  // 0x20
  private   readonly System.IO.Stream                output  // 0x38
METHODS:
  System.Int32 ComputeDoubleSize(System.Double value)
  System.Int32 ComputeFloatSize(System.Single value)
  System.Int32 ComputeUInt64Size(System.UInt64 value)
  System.Int32 ComputeInt64Size(System.Int64 value)
  System.Int32 ComputeInt32Size(System.Int32 value)
  System.Int32 ComputeFixed64Size(System.UInt64 value)
  System.Int32 ComputeFixed32Size(System.UInt32 value)
  System.Int32 ComputeBoolSize(System.Boolean value)
  System.Int32 ComputeStringSize(System.String value)
  System.Int32 ComputeGroupSize(Google.Protobuf.IMessage value)
  System.Int32 ComputeMessageSize(Google.Protobuf.IMessage value)
  System.Int32 ComputeBytesSize(Google.Protobuf.ByteString value)
  System.Int32 ComputeUInt32Size(System.UInt32 value)
  System.Int32 ComputeEnumSize(System.Int32 value)
  System.Int32 ComputeSFixed32Size(System.Int32 value)
  System.Int32 ComputeSFixed64Size(System.Int64 value)
  System.Int32 ComputeSInt32Size(System.Int32 value)
  System.Int32 ComputeSInt64Size(System.Int64 value)
  System.Int32 ComputeLengthSize(System.Int32 length)
  System.Int32 ComputeRawVarint32Size(System.UInt32 value)
  System.Int32 ComputeRawVarint64Size(System.UInt64 value)
  System.Int32 ComputeTagSize(System.Int32 fieldNumber)
  System.Void .ctor(System.Byte[] flatArray)
  System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 length)
  System.Void .ctor(System.IO.Stream output, System.Byte[] buffer, System.Boolean leaveOpen)
  System.Void .ctor(System.IO.Stream output)
  System.Void .ctor(System.IO.Stream output, System.Int32 bufferSize)
  System.Void .ctor(System.IO.Stream output, System.Boolean leaveOpen)
  System.Void .ctor(System.IO.Stream output, System.Int32 bufferSize, System.Boolean leaveOpen)
  System.Int64 get_Position()
  System.Int32 get_NonOutputPosition()
  System.Void WriteDouble(System.Double value)
  System.Void WriteFloat(System.Single value)
  System.Void WriteUInt64(System.UInt64 value)
  System.Void WriteInt64(System.Int64 value)
  System.Void WriteInt32(System.Int32 value)
  System.Void WriteFixed64(System.UInt64 value)
  System.Void WriteFixed32(System.UInt32 value)
  System.Void WriteBool(System.Boolean value)
  System.Void WriteString(System.String value)
  System.Void WriteMessage(Google.Protobuf.IMessage value)
  System.Void WriteRawMessage(Google.Protobuf.IMessage value)
  System.Void WriteGroup(Google.Protobuf.IMessage value)
  System.Void WriteBytes(Google.Protobuf.ByteString value)
  System.Void WriteUInt32(System.UInt32 value)
  System.Void WriteEnum(System.Int32 value)
  System.Void WriteSFixed32(System.Int32 value)
  System.Void WriteSFixed64(System.Int64 value)
  System.Void WriteSInt32(System.Int32 value)
  System.Void WriteSInt64(System.Int64 value)
  System.Void WriteLength(System.Int32 length)
  System.Void WriteTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type)
  System.Void WriteTag(System.UInt32 tag)
  System.Void WriteRawTag(System.Byte b1)
  System.Void WriteRawTag(System.Byte b1, System.Byte b2)
  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3)
  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4)
  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5)
  System.Void WriteRawVarint32(System.UInt32 value)
  System.Void WriteRawVarint64(System.UInt64 value)
  System.Void WriteRawLittleEndian32(System.UInt32 value)
  System.Void WriteRawLittleEndian64(System.UInt64 value)
  System.Void WriteRawBytes(System.Byte[] value)
  System.Void WriteRawBytes(System.Byte[] value, System.Int32 offset, System.Int32 length)
  System.Void Dispose()
  System.Void Flush()
  System.Void CheckNoSpaceLeft()
  System.Int32 get_SpaceLeft()
  System.Byte[] get_InternalBuffer()
  System.IO.Stream get_InternalOutputStream()
  Google.Protobuf.WriterInternalState& get_InternalState()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Extension
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   readonly System.Int32                    <FieldNumber>k__BackingField  // 0x10
METHODS:
  System.Type get_TargetType()
  System.Void .ctor(System.Int32 fieldNumber)
  Google.Protobuf.IExtensionValue CreateValue()
  System.Int32 get_FieldNumber()
  System.Boolean get_IsRepeated()
END_CLASS

CLASS: Google.Protobuf.Extension`2
TYPE:  class
TOKEN: 0x200000E
EXTENDS: Extension
FIELDS:
  private   readonly Google.Protobuf.FieldCodec<TValue>codec  // 0x0
METHODS:
  System.Void .ctor(System.Int32 fieldNumber, Google.Protobuf.FieldCodec<TValue> codec)
  TValue get_DefaultValue()
  System.Type get_TargetType()
  System.Boolean get_IsRepeated()
  Google.Protobuf.IExtensionValue CreateValue()
END_CLASS

CLASS: Google.Protobuf.RepeatedExtension`2
TYPE:  class
TOKEN: 0x200000F
EXTENDS: Extension
FIELDS:
  private   readonly Google.Protobuf.FieldCodec<TValue>codec  // 0x0
METHODS:
  System.Void .ctor(System.Int32 fieldNumber, Google.Protobuf.FieldCodec<TValue> codec)
  System.Type get_TargetType()
  System.Boolean get_IsRepeated()
  Google.Protobuf.IExtensionValue CreateValue()
END_CLASS

CLASS: Google.Protobuf.ExtensionRegistry
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private           System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension>extensions  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> collection)
  System.Int32 get_Count()
  System.Boolean System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly()
  System.Boolean ContainsInputField(System.UInt32 lastTag, System.Type target, Google.Protobuf.Extension& extension)
  System.Void Add(Google.Protobuf.Extension extension)
  System.Void AddRange(System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> extensions)
  System.Void Clear()
  System.Boolean Contains(Google.Protobuf.Extension item)
  System.Void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(Google.Protobuf.Extension[] array, System.Int32 arrayIndex)
  System.Collections.Generic.IEnumerator<Google.Protobuf.Extension> GetEnumerator()
  System.Boolean Remove(Google.Protobuf.Extension item)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  Google.Protobuf.ExtensionRegistry Clone()
END_CLASS

CLASS: Google.Protobuf.ExtensionSet
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.Boolean TryGetValue(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension extension, Google.Protobuf.IExtensionValue& value)
  TValue Get(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> Get(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitialize(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension)
  System.Void Set(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension, TValue value)
  System.Boolean Has(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension)
  System.Void Clear(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension)
  System.Void Clear(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension)
  System.Boolean TryMergeFieldFrom(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.CodedInputStream stream)
  System.Boolean TryMergeFieldFrom(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.ParseContext& ctx)
  System.Void MergeFrom(Google.Protobuf.ExtensionSet<TTarget>& first, Google.Protobuf.ExtensionSet<TTarget> second)
  Google.Protobuf.ExtensionSet<TTarget> Clone(Google.Protobuf.ExtensionSet<TTarget> set)
END_CLASS

CLASS: Google.Protobuf.ExtensionSet`1
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Google.Protobuf.IExtensionValue><ValuesByNumber>k__BackingField  // 0x0
METHODS:
  System.Collections.Generic.Dictionary<System.Int32,Google.Protobuf.IExtensionValue> get_ValuesByNumber()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Int32 CalculateSize()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream stream)
  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  System.Boolean IsInitialized()
  System.Void .ctor()
END_CLASS

CLASS: Google.Protobuf.IExtensionValue
TYPE:  interface
TOKEN: 0x2000016
FIELDS:
METHODS:
  System.Void MergeFrom(Google.Protobuf.ParseContext& ctx)
  System.Void MergeFrom(Google.Protobuf.IExtensionValue value)
  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  System.Int32 CalculateSize()
  System.Boolean IsInitialized()
  System.Object GetValue()
END_CLASS

CLASS: Google.Protobuf.ExtensionValue`1
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private           T                               field  // 0x0
  private           Google.Protobuf.FieldCodec<T>   codec  // 0x0
METHODS:
  System.Void .ctor(Google.Protobuf.FieldCodec<T> codec)
  System.Int32 CalculateSize()
  Google.Protobuf.IExtensionValue Clone()
  System.Boolean Equals(Google.Protobuf.IExtensionValue other)
  System.Int32 GetHashCode()
  System.Void MergeFrom(Google.Protobuf.ParseContext& ctx)
  System.Void MergeFrom(Google.Protobuf.IExtensionValue value)
  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  T GetValue()
  System.Object Google.Protobuf.IExtensionValue.GetValue()
  System.Void SetValue(T value)
  System.Boolean IsInitialized()
END_CLASS

CLASS: Google.Protobuf.RepeatedExtensionValue`1
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  private           Google.Protobuf.Collections.RepeatedField<T>field  // 0x0
  private   readonly Google.Protobuf.FieldCodec<T>   codec  // 0x0
METHODS:
  System.Void .ctor(Google.Protobuf.FieldCodec<T> codec)
  System.Int32 CalculateSize()
  Google.Protobuf.IExtensionValue Clone()
  System.Boolean Equals(Google.Protobuf.IExtensionValue other)
  System.Int32 GetHashCode()
  System.Void MergeFrom(Google.Protobuf.ParseContext& ctx)
  System.Void MergeFrom(Google.Protobuf.IExtensionValue value)
  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  Google.Protobuf.Collections.RepeatedField<T> GetValue()
  System.Object Google.Protobuf.IExtensionValue.GetValue()
  System.Boolean IsInitialized()
END_CLASS

CLASS: Google.Protobuf.FieldCodec
TYPE:  class
TOKEN: 0x2000019
FIELDS:
METHODS:
  Google.Protobuf.FieldCodec<System.String> ForString(System.UInt32 tag)
  Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Boolean> ForBool(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Int32> ForInt32(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Int32> ForSInt32(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.UInt32> ForFixed32(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Int32> ForSFixed32(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.UInt32> ForUInt32(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Int64> ForInt64(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Int64> ForSInt64(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.UInt64> ForFixed64(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Int64> ForSFixed64(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.UInt64> ForUInt64(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Single> ForFloat(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Double> ForDouble(System.UInt32 tag)
  Google.Protobuf.FieldCodec<T> ForEnum(System.UInt32 tag, System.Func<T,System.Int32> toInt32, System.Func<System.Int32,T> fromInt32)
  Google.Protobuf.FieldCodec<System.String> ForString(System.UInt32 tag, System.String defaultValue)
  Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(System.UInt32 tag, Google.Protobuf.ByteString defaultValue)
  Google.Protobuf.FieldCodec<System.Boolean> ForBool(System.UInt32 tag, System.Boolean defaultValue)
  Google.Protobuf.FieldCodec<System.Int32> ForInt32(System.UInt32 tag, System.Int32 defaultValue)
  Google.Protobuf.FieldCodec<System.Int32> ForSInt32(System.UInt32 tag, System.Int32 defaultValue)
  Google.Protobuf.FieldCodec<System.UInt32> ForFixed32(System.UInt32 tag, System.UInt32 defaultValue)
  Google.Protobuf.FieldCodec<System.Int32> ForSFixed32(System.UInt32 tag, System.Int32 defaultValue)
  Google.Protobuf.FieldCodec<System.UInt32> ForUInt32(System.UInt32 tag, System.UInt32 defaultValue)
  Google.Protobuf.FieldCodec<System.Int64> ForInt64(System.UInt32 tag, System.Int64 defaultValue)
  Google.Protobuf.FieldCodec<System.Int64> ForSInt64(System.UInt32 tag, System.Int64 defaultValue)
  Google.Protobuf.FieldCodec<System.UInt64> ForFixed64(System.UInt32 tag, System.UInt64 defaultValue)
  Google.Protobuf.FieldCodec<System.Int64> ForSFixed64(System.UInt32 tag, System.Int64 defaultValue)
  Google.Protobuf.FieldCodec<System.UInt64> ForUInt64(System.UInt32 tag, System.UInt64 defaultValue)
  Google.Protobuf.FieldCodec<System.Single> ForFloat(System.UInt32 tag, System.Single defaultValue)
  Google.Protobuf.FieldCodec<System.Double> ForDouble(System.UInt32 tag, System.Double defaultValue)
  Google.Protobuf.FieldCodec<T> ForEnum(System.UInt32 tag, System.Func<T,System.Int32> toInt32, System.Func<System.Int32,T> fromInt32, T defaultValue)
  Google.Protobuf.FieldCodec<T> ForMessage(System.UInt32 tag, Google.Protobuf.MessageParser<T> parser)
  Google.Protobuf.FieldCodec<T> ForGroup(System.UInt32 startTag, System.UInt32 endTag, Google.Protobuf.MessageParser<T> parser)
  Google.Protobuf.FieldCodec<T> ForClassWrapper(System.UInt32 tag)
  Google.Protobuf.FieldCodec<System.Nullable<T>> ForStructWrapper(System.UInt32 tag)
END_CLASS

CLASS: Google.Protobuf.ValueReader`1
TYPE:  class
TOKEN: 0x2000026
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TValue Invoke(Google.Protobuf.ParseContext& ctx)
  System.IAsyncResult BeginInvoke(Google.Protobuf.ParseContext& ctx, System.AsyncCallback callback, System.Object object)
  TValue EndInvoke(Google.Protobuf.ParseContext& ctx, System.IAsyncResult result)
END_CLASS

CLASS: Google.Protobuf.ValueWriter`1
TYPE:  class
TOKEN: 0x2000027
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Google.Protobuf.WriteContext& ctx, T value)
  System.IAsyncResult BeginInvoke(Google.Protobuf.WriteContext& ctx, T value, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(Google.Protobuf.WriteContext& ctx, System.IAsyncResult result)
END_CLASS

CLASS: Google.Protobuf.FieldCodec`1
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  private   static readonly System.Collections.Generic.EqualityComparer<T>EqualityComparer  // 0x0
  private   static readonly T                               DefaultDefault  // 0x0
  private   static readonly System.Boolean                  TypeSupportsPacking  // 0x0
  private   readonly System.Boolean                  <PackedRepeatedField>k__BackingField  // 0x0
  private   readonly Google.Protobuf.ValueWriter<T>  <ValueWriter>k__BackingField  // 0x0
  private   readonly System.Func<T,System.Int32>     <ValueSizeCalculator>k__BackingField  // 0x0
  private   readonly Google.Protobuf.ValueReader<T>  <ValueReader>k__BackingField  // 0x0
  private   readonly Google.Protobuf.FieldCodec.InputMerger<T><ValueMerger>k__BackingField  // 0x0
  private   readonly Google.Protobuf.FieldCodec.ValuesMerger<T><FieldMerger>k__BackingField  // 0x0
  private   readonly System.Int32                    <FixedSize>k__BackingField  // 0x0
  private   readonly System.UInt32                   <Tag>k__BackingField  // 0x0
  private   readonly System.UInt32                   <EndTag>k__BackingField  // 0x0
  private   readonly T                               <DefaultValue>k__BackingField  // 0x0
  private   readonly System.Int32                    tagSize  // 0x0
METHODS:
  System.Void .cctor()
  System.Boolean IsPackedRepeatedField(System.UInt32 tag)
  System.Boolean get_PackedRepeatedField()
  Google.Protobuf.ValueWriter<T> get_ValueWriter()
  System.Func<T,System.Int32> get_ValueSizeCalculator()
  Google.Protobuf.ValueReader<T> get_ValueReader()
  Google.Protobuf.FieldCodec.InputMerger<T> get_ValueMerger()
  Google.Protobuf.FieldCodec.ValuesMerger<T> get_FieldMerger()
  System.Int32 get_FixedSize()
  System.UInt32 get_Tag()
  System.UInt32 get_EndTag()
  T get_DefaultValue()
  System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Int32 fixedSize, System.UInt32 tag, T defaultValue)
  System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, T defaultValue)
  System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, System.UInt32 endTag)
  System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, System.UInt32 endTag, T defaultValue)
  System.Void WriteTagAndValue(Google.Protobuf.CodedOutputStream output, T value)
  System.Void WriteTagAndValue(Google.Protobuf.WriteContext& ctx, T value)
  T Read(Google.Protobuf.CodedInputStream input)
  T Read(Google.Protobuf.ParseContext& ctx)
  System.Int32 CalculateSizeWithTag(T value)
  System.Int32 CalculateUnconditionalSizeWithTag(T value)
  System.Boolean IsDefault(T value)
END_CLASS

CLASS: Google.Protobuf.FieldMaskTree
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  private   static  System.Char                     FIELD_PATH_SEPARATOR  // 0x0
  private   readonly Google.Protobuf.FieldMaskTree.Noderoot  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.FieldMask mask)
  System.String ToString()
  Google.Protobuf.FieldMaskTree AddFieldPath(System.String path)
  Google.Protobuf.FieldMaskTree MergeFromFieldMask(Google.Protobuf.WellKnownTypes.FieldMask mask)
  Google.Protobuf.WellKnownTypes.FieldMask ToFieldMask()
  System.Void GetFieldPaths(Google.Protobuf.FieldMaskTree.Node node, System.String path, System.Collections.Generic.List<System.String> paths)
  System.Void IntersectFieldPath(System.String path, Google.Protobuf.FieldMaskTree output)
  System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options)
  System.Void Merge(Google.Protobuf.FieldMaskTree.Node node, System.String path, Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options)
END_CLASS

CLASS: Google.Protobuf.FrameworkPortability
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  private   static readonly System.Text.RegularExpressions.RegexOptionsCompiledRegexWhereAvailable  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.IBufferMessage
TYPE:  interface
TOKEN: 0x2000031
FIELDS:
METHODS:
  System.Void InternalMergeFrom(Google.Protobuf.ParseContext& ctx)
  System.Void InternalWriteTo(Google.Protobuf.WriteContext& ctx)
END_CLASS

CLASS: Google.Protobuf.ICustomDiagnosticMessage
TYPE:  interface
TOKEN: 0x2000032
FIELDS:
METHODS:
  System.String ToDiagnosticString()
END_CLASS

CLASS: Google.Protobuf.IDeepCloneable`1
TYPE:  interface
TOKEN: 0x2000033
FIELDS:
METHODS:
  T Clone()
END_CLASS

CLASS: Google.Protobuf.IExtendableMessage`1
TYPE:  interface
TOKEN: 0x2000034
FIELDS:
METHODS:
  TValue GetExtension(Google.Protobuf.Extension<T,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<T,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<T,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<T,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension)
END_CLASS

CLASS: Google.Protobuf.IMessage
TYPE:  interface
TOKEN: 0x2000035
FIELDS:
METHODS:
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Int32 CalculateSize()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
END_CLASS

CLASS: Google.Protobuf.IMessage`1
TYPE:  interface
TOKEN: 0x2000036
FIELDS:
METHODS:
  System.Void MergeFrom(T message)
END_CLASS

CLASS: Google.Protobuf.InvalidJsonException
TYPE:  class
TOKEN: 0x2000037
EXTENDS: IOException
FIELDS:
METHODS:
  System.Void .ctor(System.String message)
END_CLASS

CLASS: Google.Protobuf.InvalidProtocolBufferException
TYPE:  class
TOKEN: 0x2000038
EXTENDS: IOException
FIELDS:
METHODS:
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  Google.Protobuf.InvalidProtocolBufferException MoreDataAvailable()
  Google.Protobuf.InvalidProtocolBufferException TruncatedMessage()
  Google.Protobuf.InvalidProtocolBufferException NegativeSize()
  Google.Protobuf.InvalidProtocolBufferException MalformedVarint()
  Google.Protobuf.InvalidProtocolBufferException InvalidTag()
  Google.Protobuf.InvalidProtocolBufferException InvalidWireType()
  Google.Protobuf.InvalidProtocolBufferException InvalidBase64(System.Exception innerException)
  Google.Protobuf.InvalidProtocolBufferException InvalidEndTag()
  Google.Protobuf.InvalidProtocolBufferException RecursionLimitExceeded()
  Google.Protobuf.InvalidProtocolBufferException JsonRecursionLimitExceeded()
  Google.Protobuf.InvalidProtocolBufferException SizeLimitExceeded()
  Google.Protobuf.InvalidProtocolBufferException InvalidMessageStreamTag()
  Google.Protobuf.InvalidProtocolBufferException MissingFields()
END_CLASS

CLASS: Google.Protobuf.JsonFormatter
TYPE:  class
TOKEN: 0x2000039
FIELDS:
  private   static  System.String                   AnyTypeUrlField  // 0x0
  private   static  System.String                   AnyDiagnosticValueField  // 0x0
  private   static  System.String                   AnyWellKnownTypeValueField  // 0x0
  private   static  System.String                   TypeUrlPrefix  // 0x0
  private   static  System.String                   NameValueSeparator  // 0x0
  private   static  System.String                   PropertySeparator  // 0x0
  private   static readonly Google.Protobuf.JsonFormatter   <Default>k__BackingField  // 0x0
  private   static readonly Google.Protobuf.JsonFormatter   diagnosticFormatter  // 0x8
  private   static readonly System.String[]                 CommonRepresentations  // 0x10
  private   readonly Google.Protobuf.JsonFormatter.Settingssettings  // 0x10
  private   static  System.String                   Hex  // 0x0
METHODS:
  Google.Protobuf.JsonFormatter get_Default()
  System.Void .cctor()
  System.Boolean get_DiagnosticOnly()
  System.Void .ctor(Google.Protobuf.JsonFormatter.Settings settings)
  System.String Format(Google.Protobuf.IMessage message)
  System.Void Format(Google.Protobuf.IMessage message, System.IO.TextWriter writer)
  System.String ToDiagnosticString(Google.Protobuf.IMessage message)
  System.Void WriteMessage(System.IO.TextWriter writer, Google.Protobuf.IMessage message)
  System.Boolean WriteMessageFields(System.IO.TextWriter writer, Google.Protobuf.IMessage message, System.Boolean assumeFirstFieldWritten)
  System.Boolean ShouldFormatFieldValue(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, System.Object value)
  System.String ToJsonName(System.String name)
  System.String FromJsonName(System.String name)
  System.Void WriteNull(System.IO.TextWriter writer)
  System.Boolean IsDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor, System.Object value)
  System.Void WriteValue(System.IO.TextWriter writer, System.Object value)
  System.Void WriteWellKnownTypeValue(System.IO.TextWriter writer, Google.Protobuf.Reflection.MessageDescriptor descriptor, System.Object value)
  System.Void WriteTimestamp(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  System.Void WriteDuration(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  System.Void WriteFieldMask(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  System.Void WriteAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  System.Void WriteDiagnosticOnlyAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  System.Void WriteStruct(System.IO.TextWriter writer, Google.Protobuf.IMessage message)
  System.Void WriteStructFieldValue(System.IO.TextWriter writer, Google.Protobuf.IMessage message)
  System.Void WriteList(System.IO.TextWriter writer, System.Collections.IList list)
  System.Void WriteDictionary(System.IO.TextWriter writer, System.Collections.IDictionary dictionary)
  System.Void WriteString(System.IO.TextWriter writer, System.String text)
  System.Void HexEncodeUtf16CodeUnit(System.IO.TextWriter writer, System.Char c)
END_CLASS

CLASS: Google.Protobuf.JsonParser
TYPE:  class
TOKEN: 0x200003D
FIELDS:
  private   static readonly System.Text.RegularExpressions.RegexTimestampRegex  // 0x0
  private   static readonly System.Text.RegularExpressions.RegexDurationRegex  // 0x8
  private   static readonly System.Int32[]                  SubsecondScalingFactors  // 0x10
  private   static readonly System.Char[]                   FieldMaskPathSeparators  // 0x18
  private   static readonly Google.Protobuf.Reflection.EnumDescriptorNullValueDescriptor  // 0x20
  private   static readonly Google.Protobuf.JsonParser      defaultInstance  // 0x28
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.Action<Google.Protobuf.JsonParser,Google.Protobuf.IMessage,Google.Protobuf.JsonTokenizer>>WellKnownTypeHandlers  // 0x30
  private   readonly Google.Protobuf.JsonParser.Settingssettings  // 0x10
METHODS:
  System.Void MergeWrapperField(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  Google.Protobuf.JsonParser get_Default()
  System.Void .ctor(Google.Protobuf.JsonParser.Settings settings)
  System.Void Merge(Google.Protobuf.IMessage message, System.String json)
  System.Void Merge(Google.Protobuf.IMessage message, System.IO.TextReader jsonReader)
  System.Void Merge(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  System.Void MergeField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer)
  System.Void MergeRepeatedField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer)
  System.Void MergeMapField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer)
  System.Boolean IsGoogleProtobufValueField(Google.Protobuf.Reflection.FieldDescriptor field)
  System.Boolean IsGoogleProtobufNullValueField(Google.Protobuf.Reflection.FieldDescriptor field)
  System.Object ParseSingleValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer)
  T Parse(System.String json)
  T Parse(System.IO.TextReader jsonReader)
  Google.Protobuf.IMessage Parse(System.String json, Google.Protobuf.Reflection.MessageDescriptor descriptor)
  Google.Protobuf.IMessage Parse(System.IO.TextReader jsonReader, Google.Protobuf.Reflection.MessageDescriptor descriptor)
  System.Void MergeStructValue(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  System.Void MergeStruct(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  System.Void MergeAny(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  System.Void MergeWellKnownTypeAnyBody(Google.Protobuf.IMessage body, Google.Protobuf.JsonTokenizer tokenizer)
  System.Object ParseMapKey(Google.Protobuf.Reflection.FieldDescriptor field, System.String keyText)
  System.Object ParseSingleNumberValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonToken token)
  System.Void CheckInteger(System.Double value)
  System.Object ParseSingleStringValue(Google.Protobuf.Reflection.FieldDescriptor field, System.String text)
  Google.Protobuf.IMessage NewMessageForField(Google.Protobuf.Reflection.FieldDescriptor field)
  T ParseNumericString(System.String text, System.Func<System.String,System.Globalization.NumberStyles,System.IFormatProvider,T> parser)
  System.Void ValidateInfinityAndNan(System.String text, System.Boolean isPositiveInfinity, System.Boolean isNegativeInfinity, System.Boolean isNaN)
  System.Void MergeTimestamp(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token)
  System.Void MergeDuration(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token)
  System.Void MergeFieldMask(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token)
  System.String ToSnakeCase(System.String text)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.JsonToken
TYPE:  class
TOKEN: 0x2000040
FIELDS:
  private   static readonly Google.Protobuf.JsonToken       _true  // 0x0
  private   static readonly Google.Protobuf.JsonToken       _false  // 0x8
  private   static readonly Google.Protobuf.JsonToken       _null  // 0x10
  private   static readonly Google.Protobuf.JsonToken       startObject  // 0x18
  private   static readonly Google.Protobuf.JsonToken       endObject  // 0x20
  private   static readonly Google.Protobuf.JsonToken       startArray  // 0x28
  private   static readonly Google.Protobuf.JsonToken       endArray  // 0x30
  private   static readonly Google.Protobuf.JsonToken       endDocument  // 0x38
  private   readonly Google.Protobuf.JsonToken.TokenTypetype  // 0x10
  private   readonly System.String                   stringValue  // 0x18
  private   readonly System.Double                   numberValue  // 0x20
METHODS:
  Google.Protobuf.JsonToken get_Null()
  Google.Protobuf.JsonToken get_False()
  Google.Protobuf.JsonToken get_True()
  Google.Protobuf.JsonToken get_StartObject()
  Google.Protobuf.JsonToken get_EndObject()
  Google.Protobuf.JsonToken get_StartArray()
  Google.Protobuf.JsonToken get_EndArray()
  Google.Protobuf.JsonToken get_EndDocument()
  Google.Protobuf.JsonToken Name(System.String name)
  Google.Protobuf.JsonToken Value(System.String value)
  Google.Protobuf.JsonToken Value(System.Double value)
  Google.Protobuf.JsonToken.TokenType get_Type()
  System.String get_StringValue()
  System.Double get_NumberValue()
  System.Void .ctor(Google.Protobuf.JsonToken.TokenType type, System.String stringValue, System.Double numberValue)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean Equals(Google.Protobuf.JsonToken other)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.JsonTokenizer
TYPE:  class
TOKEN: 0x2000042
FIELDS:
  private           Google.Protobuf.JsonToken       bufferedToken  // 0x10
  private           System.Int32                    <ObjectDepth>k__BackingField  // 0x18
METHODS:
  Google.Protobuf.JsonTokenizer FromTextReader(System.IO.TextReader reader)
  Google.Protobuf.JsonTokenizer FromReplayedTokens(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer continuation)
  System.Int32 get_ObjectDepth()
  System.Void set_ObjectDepth(System.Int32 value)
  System.Void PushBack(Google.Protobuf.JsonToken token)
  Google.Protobuf.JsonToken Next()
  Google.Protobuf.JsonToken NextImpl()
  System.Void SkipValue()
  System.Void .ctor()
END_CLASS

CLASS: Google.Protobuf.LimitedInputStream
TYPE:  class
TOKEN: 0x2000048
EXTENDS: Stream
FIELDS:
  private   readonly System.IO.Stream                proxied  // 0x28
  private           System.Int32                    bytesLeft  // 0x30
METHODS:
  System.Void .ctor(System.IO.Stream proxied, System.Int32 size)
  System.Boolean get_CanRead()
  System.Boolean get_CanSeek()
  System.Boolean get_CanWrite()
  System.Void Flush()
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Void SetLength(System.Int64 value)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
END_CLASS

CLASS: Google.Protobuf.MessageExtensions
TYPE:  class
TOKEN: 0x2000049
FIELDS:
METHODS:
  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data)
  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Int32 offset, System.Int32 length)
  System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data)
  System.Void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input)
  System.Void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<System.Byte> span)
  System.Void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input)
  System.Byte[] ToByteArray(Google.Protobuf.IMessage message)
  System.Int32 WriteToByteArray(Google.Protobuf.IMessage message, System.Byte[] buffer, System.Int32 pos)
  System.Void WriteTo(Google.Protobuf.IMessage message, System.IO.Stream output)
  System.Void WriteDelimitedTo(Google.Protobuf.IMessage message, System.IO.Stream output)
  Google.Protobuf.ByteString ToByteString(Google.Protobuf.IMessage message)
  System.Void WriteTo(Google.Protobuf.IMessage message, System.Buffers.IBufferWriter<System.Byte> output)
  System.Void WriteTo(Google.Protobuf.IMessage message, System.Span<System.Byte> output)
  System.Boolean IsInitialized(Google.Protobuf.IMessage message)
  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Int32 offset, System.Int32 length, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  System.Void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Buffers.ReadOnlySequence<System.Byte> data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  System.Void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<System.Byte> data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  System.Void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
END_CLASS

CLASS: Google.Protobuf.MessageParser
TYPE:  class
TOKEN: 0x200004B
FIELDS:
  private           System.Func<Google.Protobuf.IMessage>factory  // 0x10
  private   readonly System.Boolean                  <DiscardUnknownFields>k__BackingField  // 0x18
  private   readonly Google.Protobuf.ExtensionRegistry<Extensions>k__BackingField  // 0x20
METHODS:
  System.Boolean get_DiscardUnknownFields()
  Google.Protobuf.ExtensionRegistry get_Extensions()
  System.Void .ctor(System.Func<Google.Protobuf.IMessage> factory, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions)
  Google.Protobuf.IMessage CreateTemplate()
  Google.Protobuf.IMessage ParseFrom(System.Byte[] data)
  Google.Protobuf.IMessage ParseFrom(System.Byte[] data, System.Int32 offset, System.Int32 length)
  Google.Protobuf.IMessage ParseFrom(Google.Protobuf.ByteString data)
  Google.Protobuf.IMessage ParseFrom(System.IO.Stream input)
  Google.Protobuf.IMessage ParseFrom(System.Buffers.ReadOnlySequence<System.Byte> data)
  Google.Protobuf.IMessage ParseFrom(System.ReadOnlySpan<System.Byte> data)
  Google.Protobuf.IMessage ParseDelimitedFrom(System.IO.Stream input)
  Google.Protobuf.IMessage ParseFrom(Google.Protobuf.CodedInputStream input)
  Google.Protobuf.IMessage ParseJson(System.String json)
  System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.CodedInputStream codedInput)
  Google.Protobuf.MessageParser WithDiscardUnknownFields(System.Boolean discardUnknownFields)
  Google.Protobuf.MessageParser WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry)
END_CLASS

CLASS: Google.Protobuf.MessageParser`1
TYPE:  class
TOKEN: 0x200004C
EXTENDS: MessageParser
FIELDS:
  private   readonly System.Func<T>                  factory  // 0x0
METHODS:
  System.Void .ctor(System.Func<T> factory)
  System.Void .ctor(System.Func<T> factory, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions)
  T CreateTemplate()
  T ParseFrom(System.Byte[] data)
  T ParseFrom(System.Byte[] data, System.Int32 offset, System.Int32 length)
  T ParseFrom(Google.Protobuf.ByteString data)
  T ParseFrom(System.IO.Stream input)
  T ParseFrom(System.Buffers.ReadOnlySequence<System.Byte> data)
  T ParseFrom(System.ReadOnlySpan<System.Byte> data)
  T ParseDelimitedFrom(System.IO.Stream input)
  T ParseFrom(Google.Protobuf.CodedInputStream input)
  T ParseJson(System.String json)
  Google.Protobuf.MessageParser<T> WithDiscardUnknownFields(System.Boolean discardUnknownFields)
  Google.Protobuf.MessageParser<T> WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry)
END_CLASS

CLASS: Google.Protobuf.ObjectIntPair`1
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  private   readonly System.Int32                    number  // 0x0
  private   readonly T                               obj  // 0x0
METHODS:
  System.Void .ctor(T obj, System.Int32 number)
  System.Boolean Equals(Google.Protobuf.ObjectIntPair<T> other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: Google.Protobuf.ParseContext
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  private   static  System.Int32                    DefaultRecursionLimit  // 0x0
  private   static  System.Int32                    DefaultSizeLimit  // 0x0
  private           System.ReadOnlySpan<System.Byte>buffer  // 0x10
  private           Google.Protobuf.ParserInternalStatestate  // 0x20
METHODS:
  System.Void Initialize(System.ReadOnlySpan<System.Byte> buffer, Google.Protobuf.ParseContext& ctx)
  System.Void Initialize(System.ReadOnlySpan<System.Byte> buffer, Google.Protobuf.ParserInternalState& state, Google.Protobuf.ParseContext& ctx)
  System.Void Initialize(Google.Protobuf.CodedInputStream input, Google.Protobuf.ParseContext& ctx)
  System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> input, Google.Protobuf.ParseContext& ctx)
  System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> input, System.Int32 recursionLimit, Google.Protobuf.ParseContext& ctx)
  System.UInt32 get_LastTag()
  System.Boolean get_DiscardUnknownFields()
  System.Void set_DiscardUnknownFields(System.Boolean value)
  Google.Protobuf.ExtensionRegistry get_ExtensionRegistry()
  System.Void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value)
  System.UInt32 ReadTag()
  System.Double ReadDouble()
  System.Single ReadFloat()
  System.UInt64 ReadUInt64()
  System.Int64 ReadInt64()
  System.Int32 ReadInt32()
  System.UInt64 ReadFixed64()
  System.UInt32 ReadFixed32()
  System.Boolean ReadBool()
  System.String ReadString()
  System.Void ReadMessage(Google.Protobuf.IMessage message)
  System.Void ReadGroup(Google.Protobuf.IMessage message)
  Google.Protobuf.ByteString ReadBytes()
  System.UInt32 ReadUInt32()
  System.Int32 ReadEnum()
  System.Int32 ReadSFixed32()
  System.Int64 ReadSFixed64()
  System.Int32 ReadSInt32()
  System.Int64 ReadSInt64()
  System.Int32 ReadLength()
  System.Void CopyStateTo(Google.Protobuf.CodedInputStream input)
  System.Void LoadStateFrom(Google.Protobuf.CodedInputStream input)
END_CLASS

CLASS: Google.Protobuf.ParserInternalState
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  private           System.Int32                    bufferPos  // 0x10
  private           System.Int32                    bufferSize  // 0x14
  private           System.Int32                    bufferSizeAfterLimit  // 0x18
  private           System.Int32                    currentLimit  // 0x1C
  private           System.Int32                    totalBytesRetired  // 0x20
  private           System.Int32                    recursionDepth  // 0x24
  private           Google.Protobuf.SegmentedBufferHelpersegmentedBufferHelper  // 0x28
  private           System.UInt32                   lastTag  // 0x70
  private           System.UInt32                   nextTag  // 0x74
  private           System.Boolean                  hasNextTag  // 0x78
  private           System.Int32                    sizeLimit  // 0x7C
  private           System.Int32                    recursionLimit  // 0x80
  private           System.Boolean                  <DiscardUnknownFields>k__BackingField  // 0x84
  private           Google.Protobuf.ExtensionRegistry<ExtensionRegistry>k__BackingField  // 0x88
METHODS:
  Google.Protobuf.CodedInputStream get_CodedInputStream()
  System.Boolean get_DiscardUnknownFields()
  System.Void set_DiscardUnknownFields(System.Boolean value)
  Google.Protobuf.ExtensionRegistry get_ExtensionRegistry()
  System.Void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value)
END_CLASS

CLASS: Google.Protobuf.ParsingPrimitives
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  private   static  System.Int32                    StackallocThreshold  // 0x0
METHODS:
  System.Int32 ParseLength(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt32 ParseTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Boolean MaybeConsumeTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.UInt32 tag)
  System.UInt32 PeekTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt64 ParseRawVarint64(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt64 ParseRawVarint64SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt32 ParseRawVarint32(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt32 ParseRawVarint32SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt32 ParseRawLittleEndian32(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt32 ParseRawLittleEndian32SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt64 ParseRawLittleEndian64(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt64 ParseRawLittleEndian64SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Double ParseDouble(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Single ParseFloat(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Single ParseFloatSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Byte[] ReadRawBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size)
  System.Byte[] ReadRawBytesSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size)
  System.Void SkipRawBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size)
  System.String ReadString(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  Google.Protobuf.ByteString ReadBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.String ReadRawString(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length)
  System.String ReadStringSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length)
  System.Void ValidateCurrentLimit(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size)
  System.Byte ReadRawByte(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.UInt32 ReadRawVarint32(System.IO.Stream input)
  System.Int32 DecodeZigZag32(System.UInt32 n)
  System.Int64 DecodeZigZag64(System.UInt64 n)
  System.Boolean IsDataAvailable(Google.Protobuf.ParserInternalState& state, System.Int32 size)
  System.Boolean IsDataAvailableInSource(Google.Protobuf.ParserInternalState& state, System.Int32 size)
  System.Void ReadRawBytesIntoSpan(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length, System.Span<System.Byte> byteSpan)
END_CLASS

CLASS: Google.Protobuf.ParsingPrimitivesMessages
TYPE:  class
TOKEN: 0x2000052
FIELDS:
  private   static readonly System.Byte[]                   ZeroLengthMessageStreamData  // 0x0
METHODS:
  System.Void SkipLastField(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Void SkipGroup(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.UInt32 startGroupTag)
  System.Void ReadMessage(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message)
  System.Collections.Generic.KeyValuePair<TKey,TValue> ReadMapEntry(Google.Protobuf.ParseContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  System.Void ReadGroup(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message)
  System.Void ReadGroup(Google.Protobuf.ParseContext& ctx, System.Int32 fieldNumber, Google.Protobuf.UnknownFieldSet set)
  System.Void ReadRawMessage(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message)
  System.Void CheckReadEndOfStreamTag(Google.Protobuf.ParserInternalState& state)
  System.Void CheckLastTagWas(Google.Protobuf.ParserInternalState& state, System.UInt32 expectedTag)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.ParsingPrimitivesWrappers
TYPE:  class
TOKEN: 0x2000053
FIELDS:
METHODS:
  System.Nullable<System.Single> ReadFloatWrapperLittleEndian(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.Single> ReadFloatWrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.Double> ReadDoubleWrapperLittleEndian(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.Double> ReadDoubleWrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.Boolean> ReadBoolWrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.UInt32> ReadUInt32Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.UInt32> ReadUInt32WrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.Int32> ReadInt32Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.UInt64> ReadUInt64Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.UInt64> ReadUInt64WrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.Int64> ReadInt64Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Nullable<System.Single> ReadFloatWrapperLittleEndian(Google.Protobuf.ParseContext& ctx)
  System.Nullable<System.Single> ReadFloatWrapperSlow(Google.Protobuf.ParseContext& ctx)
  System.Nullable<System.Double> ReadDoubleWrapperLittleEndian(Google.Protobuf.ParseContext& ctx)
  System.Nullable<System.Double> ReadDoubleWrapperSlow(Google.Protobuf.ParseContext& ctx)
  System.Nullable<System.Boolean> ReadBoolWrapper(Google.Protobuf.ParseContext& ctx)
  System.Nullable<System.UInt32> ReadUInt32Wrapper(Google.Protobuf.ParseContext& ctx)
  System.Nullable<System.Int32> ReadInt32Wrapper(Google.Protobuf.ParseContext& ctx)
  System.Nullable<System.UInt64> ReadUInt64Wrapper(Google.Protobuf.ParseContext& ctx)
  System.Nullable<System.UInt64> ReadUInt64WrapperSlow(Google.Protobuf.ParseContext& ctx)
  System.Nullable<System.Int64> ReadInt64Wrapper(Google.Protobuf.ParseContext& ctx)
END_CLASS

CLASS: Google.Protobuf.ProtoPreconditions
TYPE:  class
TOKEN: 0x2000054
FIELDS:
METHODS:
  T CheckNotNull(T value, System.String name)
  T CheckNotNullUnconstrained(T value, System.String name)
END_CLASS

CLASS: Google.Protobuf.SegmentedBufferHelper
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  private           System.Nullable<System.Int32>   totalLength  // 0x10
  private           System.Buffers.ReadOnlySequence.Enumerator<System.Byte>readOnlySequenceEnumerator  // 0x18
  private           Google.Protobuf.CodedInputStreamcodedInputStream  // 0x50
METHODS:
  System.Void Initialize(Google.Protobuf.CodedInputStream codedInputStream, Google.Protobuf.SegmentedBufferHelper& instance)
  System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> sequence, Google.Protobuf.SegmentedBufferHelper& instance, System.ReadOnlySpan<System.Byte>& firstSpan)
  System.Boolean RefillBuffer(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed)
  System.Nullable<System.Int32> get_TotalLength()
  Google.Protobuf.CodedInputStream get_CodedInputStream()
  System.Int32 PushLimit(Google.Protobuf.ParserInternalState& state, System.Int32 byteLimit)
  System.Void PopLimit(Google.Protobuf.ParserInternalState& state, System.Int32 oldLimit)
  System.Boolean IsReachedLimit(Google.Protobuf.ParserInternalState& state)
  System.Boolean IsAtEnd(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  System.Boolean RefillFromReadOnlySequence(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed)
  System.Boolean RefillFromCodedInputStream(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed)
  System.Void RecomputeBufferSizeAfterLimit(Google.Protobuf.ParserInternalState& state)
  System.Void CheckCurrentBufferIsEmpty(Google.Protobuf.ParserInternalState& state)
END_CLASS

CLASS: Google.Protobuf.UnknownField
TYPE:  class
TOKEN: 0x2000056
FIELDS:
  private           System.Collections.Generic.List<System.UInt64>varintList  // 0x10
  private           System.Collections.Generic.List<System.UInt32>fixed32List  // 0x18
  private           System.Collections.Generic.List<System.UInt64>fixed64List  // 0x20
  private           System.Collections.Generic.List<Google.Protobuf.ByteString>lengthDelimitedList  // 0x28
  private           System.Collections.Generic.List<Google.Protobuf.UnknownFieldSet>groupList  // 0x30
METHODS:
  System.Void .ctor()
  System.Boolean Equals(System.Object other)
  System.Int32 GetHashCode()
  System.Void WriteTo(System.Int32 fieldNumber, Google.Protobuf.WriteContext& output)
  System.Int32 GetSerializedSize(System.Int32 fieldNumber)
  Google.Protobuf.UnknownField MergeFrom(Google.Protobuf.UnknownField other)
  System.Collections.Generic.List<T> AddAll(System.Collections.Generic.List<T> current, System.Collections.Generic.IList<T> extras)
  Google.Protobuf.UnknownField AddVarint(System.UInt64 value)
  Google.Protobuf.UnknownField AddFixed32(System.UInt32 value)
  Google.Protobuf.UnknownField AddFixed64(System.UInt64 value)
  Google.Protobuf.UnknownField AddLengthDelimited(Google.Protobuf.ByteString value)
  Google.Protobuf.UnknownField AddGroup(Google.Protobuf.UnknownFieldSet value)
  System.Collections.Generic.List<T> Add(System.Collections.Generic.List<T> list, T value)
END_CLASS

CLASS: Google.Protobuf.UnknownFieldSet
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  private   readonly System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.UnknownField>fields  // 0x10
  private           System.Int32                    lastFieldNumber  // 0x18
  private           Google.Protobuf.UnknownField    lastField  // 0x20
METHODS:
  System.Void .ctor()
  System.Boolean HasField(System.Int32 field)
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  System.Int32 CalculateSize()
  System.Boolean Equals(System.Object other)
  System.Int32 GetHashCode()
  Google.Protobuf.UnknownField GetOrAddField(System.Int32 number)
  Google.Protobuf.UnknownFieldSet AddOrReplaceField(System.Int32 number, Google.Protobuf.UnknownField field)
  System.Boolean MergeFieldFrom(Google.Protobuf.ParseContext& ctx)
  System.Void MergeGroupFrom(Google.Protobuf.ParseContext& ctx)
  Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.CodedInputStream input)
  Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.ParseContext& ctx)
  Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet other)
  Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.UnknownFieldSet other)
  Google.Protobuf.UnknownFieldSet MergeField(System.Int32 number, Google.Protobuf.UnknownField field)
  Google.Protobuf.UnknownFieldSet Clone(Google.Protobuf.UnknownFieldSet other)
END_CLASS

CLASS: Google.Protobuf.UnsafeByteOperations
TYPE:  class
TOKEN: 0x2000058
FIELDS:
METHODS:
  Google.Protobuf.ByteString UnsafeWrap(System.ReadOnlyMemory<System.Byte> bytes)
END_CLASS

CLASS: Google.Protobuf.WireFormat
TYPE:  class
TOKEN: 0x2000059
FIELDS:
  private   static  System.Int32                    TagTypeBits  // 0x0
  private   static  System.UInt32                   TagTypeMask  // 0x0
METHODS:
  Google.Protobuf.WireFormat.WireType GetTagWireType(System.UInt32 tag)
  System.Int32 GetTagFieldNumber(System.UInt32 tag)
  System.UInt32 MakeTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType wireType)
END_CLASS

CLASS: Google.Protobuf.WriteBufferHelper
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  private           System.Buffers.IBufferWriter<System.Byte>bufferWriter  // 0x10
  private           Google.Protobuf.CodedOutputStreamcodedOutputStream  // 0x18
METHODS:
  Google.Protobuf.CodedOutputStream get_CodedOutputStream()
  System.Void Initialize(Google.Protobuf.CodedOutputStream codedOutputStream, Google.Protobuf.WriteBufferHelper& instance)
  System.Void Initialize(System.Buffers.IBufferWriter<System.Byte> bufferWriter, Google.Protobuf.WriteBufferHelper& instance, System.Span<System.Byte>& buffer)
  System.Void InitializeNonRefreshable(Google.Protobuf.WriteBufferHelper& instance)
  System.Void CheckNoSpaceLeft(Google.Protobuf.WriterInternalState& state)
  System.Int32 GetSpaceLeft(Google.Protobuf.WriterInternalState& state)
  System.Void RefreshBuffer(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state)
  System.Void Flush(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state)
END_CLASS

CLASS: Google.Protobuf.WriteContext
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  private           System.Span<System.Byte>        buffer  // 0x10
  private           Google.Protobuf.WriterInternalStatestate  // 0x20
METHODS:
  System.Void Initialize(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, Google.Protobuf.WriteContext& ctx)
  System.Void Initialize(Google.Protobuf.CodedOutputStream output, Google.Protobuf.WriteContext& ctx)
  System.Void Initialize(System.Buffers.IBufferWriter<System.Byte> output, Google.Protobuf.WriteContext& ctx)
  System.Void Initialize(System.Span<System.Byte>& buffer, Google.Protobuf.WriteContext& ctx)
  System.Void WriteDouble(System.Double value)
  System.Void WriteFloat(System.Single value)
  System.Void WriteUInt64(System.UInt64 value)
  System.Void WriteInt64(System.Int64 value)
  System.Void WriteInt32(System.Int32 value)
  System.Void WriteFixed64(System.UInt64 value)
  System.Void WriteFixed32(System.UInt32 value)
  System.Void WriteBool(System.Boolean value)
  System.Void WriteString(System.String value)
  System.Void WriteMessage(Google.Protobuf.IMessage value)
  System.Void WriteGroup(Google.Protobuf.IMessage value)
  System.Void WriteBytes(Google.Protobuf.ByteString value)
  System.Void WriteUInt32(System.UInt32 value)
  System.Void WriteEnum(System.Int32 value)
  System.Void WriteSFixed32(System.Int32 value)
  System.Void WriteSFixed64(System.Int64 value)
  System.Void WriteSInt32(System.Int32 value)
  System.Void WriteSInt64(System.Int64 value)
  System.Void WriteLength(System.Int32 length)
  System.Void WriteTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type)
  System.Void WriteTag(System.UInt32 tag)
  System.Void WriteRawTag(System.Byte b1)
  System.Void WriteRawTag(System.Byte b1, System.Byte b2)
  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3)
  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4)
  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5)
  System.Void Flush()
  System.Void CheckNoSpaceLeft()
  System.Void CopyStateTo(Google.Protobuf.CodedOutputStream output)
  System.Void LoadStateFrom(Google.Protobuf.CodedOutputStream output)
END_CLASS

CLASS: Google.Protobuf.WriterInternalState
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  private           System.Int32                    limit  // 0x10
  private           System.Int32                    position  // 0x14
  private           Google.Protobuf.WriteBufferHelperwriteBufferHelper  // 0x18
METHODS:
  Google.Protobuf.CodedOutputStream get_CodedOutputStream()
END_CLASS

CLASS: Google.Protobuf.WritingPrimitives
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  private   static readonly System.Text.Encoding            Utf8Encoding  // 0x0
METHODS:
  System.Void WriteDouble(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Double value)
  System.Void WriteFloat(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Single value)
  System.Void WriteFloatSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Single value)
  System.Void WriteUInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  System.Void WriteInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value)
  System.Void WriteInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value)
  System.Void WriteFixed64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  System.Void WriteFixed32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  System.Void WriteBool(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Boolean value)
  System.Void WriteString(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.String value)
  System.Void WriteAsciiStringToBuffer(System.Span<System.Byte> buffer, Google.Protobuf.WriterInternalState& state, System.String value, System.Int32 length)
  System.Void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(System.Byte& outputBuffer, System.UInt64 value)
  System.Int32 WriteStringToBuffer(System.Span<System.Byte> buffer, Google.Protobuf.WriterInternalState& state, System.String value)
  System.Void WriteBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, Google.Protobuf.ByteString value)
  System.Void WriteUInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  System.Void WriteEnum(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value)
  System.Void WriteSFixed32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value)
  System.Void WriteSFixed64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value)
  System.Void WriteSInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value)
  System.Void WriteSInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value)
  System.Void WriteLength(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 length)
  System.Void WriteRawVarint32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  System.Void WriteRawVarint64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  System.Void WriteRawLittleEndian32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  System.Void WriteRawLittleEndian32SlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  System.Void WriteRawLittleEndian64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  System.Void WriteRawLittleEndian64SlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  System.Void WriteRawByte(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte value)
  System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte[] value)
  System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte[] value, System.Int32 offset, System.Int32 length)
  System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.ReadOnlySpan<System.Byte> value)
  System.Void WriteTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type)
  System.Void WriteTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 tag)
  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1)
  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2)
  System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2)
  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3)
  System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3)
  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4)
  System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4)
  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5)
  System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5)
  System.UInt32 EncodeZigZag32(System.Int32 n)
  System.UInt64 EncodeZigZag64(System.Int64 n)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WritingPrimitivesMessages
TYPE:  class
TOKEN: 0x200005F
FIELDS:
METHODS:
  System.Void WriteMessage(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage value)
  System.Void WriteGroup(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage value)
  System.Void WriteRawMessage(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage message)
END_CLASS

CLASS: Google.Protobuf.Collections.Lists
TYPE:  class
TOKEN: 0x200012E
FIELDS:
METHODS:
  System.Boolean Equals(System.Collections.Generic.List<T> left, System.Collections.Generic.List<T> right)
  System.Int32 GetHashCode(System.Collections.Generic.List<T> list)
END_CLASS

CLASS: Google.Protobuf.Collections.MapField`2
TYPE:  class
TOKEN: 0x200012F
FIELDS:
  private   static readonly System.Collections.Generic.EqualityComparer<TValue>ValueEqualityComparer  // 0x0
  private   static readonly System.Collections.Generic.EqualityComparer<TKey>KeyEqualityComparer  // 0x0
  private   readonly System.Collections.Generic.Dictionary<TKey,System.Collections.Generic.LinkedListNode<System.Collections.Generic.KeyValuePair<TKey,TValue>>>map  // 0x0
  private   readonly System.Collections.Generic.LinkedList<System.Collections.Generic.KeyValuePair<TKey,TValue>>list  // 0x0
METHODS:
  Google.Protobuf.Collections.MapField<TKey,TValue> Clone()
  System.Void Add(TKey key, TValue value)
  System.Boolean ContainsKey(TKey key)
  System.Boolean ContainsValue(TValue value)
  System.Boolean Remove(TKey key)
  System.Boolean TryGetValue(TKey key, TValue& value)
  TValue get_Item(TKey key)
  System.Void set_Item(TKey key, TValue value)
  System.Collections.Generic.ICollection<TKey> get_Keys()
  System.Collections.Generic.ICollection<TValue> get_Values()
  System.Void Add(System.Collections.Generic.IDictionary<TKey,TValue> entries)
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  System.Void Clear()
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean Equals(System.Object other)
  System.Int32 GetHashCode()
  System.Boolean Equals(Google.Protobuf.Collections.MapField<TKey,TValue> other)
  System.Void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  System.Void AddEntriesFrom(Google.Protobuf.ParseContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  System.Void WriteTo(Google.Protobuf.WriteContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  System.Int32 CalculateSize(Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  System.Int32 CalculateEntrySize(Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec, System.Collections.Generic.KeyValuePair<TKey,TValue> entry)
  System.String ToString()
  System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value)
  System.Boolean System.Collections.IDictionary.Contains(System.Object key)
  System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
  System.Void System.Collections.IDictionary.Remove(System.Object key)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Boolean System.Collections.IDictionary.get_IsFixedSize()
  System.Collections.ICollection System.Collections.IDictionary.get_Keys()
  System.Collections.ICollection System.Collections.IDictionary.get_Values()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Object System.Collections.IDictionary.get_Item(System.Object key)
  System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value)
  System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys()
  System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Collections.ProtobufEqualityComparers
TYPE:  class
TOKEN: 0x2000135
FIELDS:
  private   static readonly System.Collections.Generic.EqualityComparer<System.Double><BitwiseDoubleEqualityComparer>k__BackingField  // 0x0
  private   static readonly System.Collections.Generic.EqualityComparer<System.Single><BitwiseSingleEqualityComparer>k__BackingField  // 0x8
  private   static readonly System.Collections.Generic.EqualityComparer<System.Nullable<System.Double>><BitwiseNullableDoubleEqualityComparer>k__BackingField  // 0x10
  private   static readonly System.Collections.Generic.EqualityComparer<System.Nullable<System.Single>><BitwiseNullableSingleEqualityComparer>k__BackingField  // 0x18
METHODS:
  System.Collections.Generic.EqualityComparer<T> GetEqualityComparer()
  System.Collections.Generic.EqualityComparer<System.Double> get_BitwiseDoubleEqualityComparer()
  System.Collections.Generic.EqualityComparer<System.Single> get_BitwiseSingleEqualityComparer()
  System.Collections.Generic.EqualityComparer<System.Nullable<System.Double>> get_BitwiseNullableDoubleEqualityComparer()
  System.Collections.Generic.EqualityComparer<System.Nullable<System.Single>> get_BitwiseNullableSingleEqualityComparer()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Collections.ReadOnlyDictionary`2
TYPE:  class
TOKEN: 0x200013A
FIELDS:
  private   readonly System.Collections.Generic.IDictionary<TKey,TValue>wrapped  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IDictionary<TKey,TValue> wrapped)
  System.Void Add(TKey key, TValue value)
  System.Boolean ContainsKey(TKey key)
  System.Collections.Generic.ICollection<TKey> get_Keys()
  System.Boolean Remove(TKey key)
  System.Boolean TryGetValue(TKey key, TValue& value)
  System.Collections.Generic.ICollection<TValue> get_Values()
  TValue get_Item(TKey key)
  System.Void set_Item(TKey key, TValue value)
  System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  System.Void Clear()
  System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Google.Protobuf.Collections.RepeatedField`1
TYPE:  class
TOKEN: 0x200013B
FIELDS:
  private   static readonly System.Collections.Generic.EqualityComparer<T>EqualityComparer  // 0x0
  private   static readonly T[]                             EmptyArray  // 0x0
  private   static  System.Int32                    MinArraySize  // 0x0
  private           T[]                             array  // 0x0
  private           System.Int32                    count  // 0x0
METHODS:
  Google.Protobuf.Collections.RepeatedField<T> Clone()
  System.Void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.FieldCodec<T> codec)
  System.Void AddEntriesFrom(Google.Protobuf.ParseContext& ctx, Google.Protobuf.FieldCodec<T> codec)
  System.Int32 CalculateSize(Google.Protobuf.FieldCodec<T> codec)
  System.Int32 CalculatePackedDataSize(Google.Protobuf.FieldCodec<T> codec)
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.FieldCodec<T> codec)
  System.Void WriteTo(Google.Protobuf.WriteContext& ctx, Google.Protobuf.FieldCodec<T> codec)
  System.Int32 get_Capacity()
  System.Void set_Capacity(System.Int32 value)
  System.Void EnsureSize(System.Int32 size)
  System.Void SetSize(System.Int32 size)
  System.Void SetCount(System.Int32 newCount)
  System.Void Add(T item)
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  System.Boolean Remove(T item)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Void AddRange(System.Collections.Generic.IEnumerable<T> values)
  System.Void Add(System.Collections.Generic.IEnumerable<T> values)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Boolean Equals(System.Object obj)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 GetHashCode()
  System.Boolean Equals(Google.Protobuf.Collections.RepeatedField<T> other)
  System.Int32 IndexOf(T item)
  System.Void Insert(System.Int32 index, T item)
  System.Void RemoveAt(System.Int32 index)
  System.String ToString()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Compatibility.PropertyInfoExtensions
TYPE:  class
TOKEN: 0x200012C
FIELDS:
METHODS:
  System.Reflection.MethodInfo GetGetMethod(System.Reflection.PropertyInfo target)
  System.Reflection.MethodInfo GetSetMethod(System.Reflection.PropertyInfo target)
END_CLASS

CLASS: Google.Protobuf.Compatibility.TypeExtensions
TYPE:  class
TOKEN: 0x200012D
FIELDS:
METHODS:
  System.Boolean IsAssignableFrom(System.Type target, System.Type c)
  System.Reflection.PropertyInfo GetProperty(System.Type target, System.String name)
  System.Reflection.MethodInfo GetMethod(System.Type target, System.String name)
END_CLASS

CLASS: Google.Protobuf.Reflection.CustomOptions
TYPE:  class
TOKEN: 0x20000A6
FIELDS:
  private   static  System.String                   UnreferencedCodeMessage  // 0x0
  private   static readonly System.Object[]                 EmptyParameters  // 0x0
  private   readonly System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.IExtensionValue>values  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.IExtensionValue> values)
  System.Boolean TryGetBool(System.Int32 field, System.Boolean& value)
  System.Boolean TryGetInt32(System.Int32 field, System.Int32& value)
  System.Boolean TryGetInt64(System.Int32 field, System.Int64& value)
  System.Boolean TryGetFixed32(System.Int32 field, System.UInt32& value)
  System.Boolean TryGetFixed64(System.Int32 field, System.UInt64& value)
  System.Boolean TryGetSFixed32(System.Int32 field, System.Int32& value)
  System.Boolean TryGetSFixed64(System.Int32 field, System.Int64& value)
  System.Boolean TryGetSInt32(System.Int32 field, System.Int32& value)
  System.Boolean TryGetSInt64(System.Int32 field, System.Int64& value)
  System.Boolean TryGetUInt32(System.Int32 field, System.UInt32& value)
  System.Boolean TryGetUInt64(System.Int32 field, System.UInt64& value)
  System.Boolean TryGetFloat(System.Int32 field, System.Single& value)
  System.Boolean TryGetDouble(System.Int32 field, System.Double& value)
  System.Boolean TryGetString(System.Int32 field, System.String& value)
  System.Boolean TryGetBytes(System.Int32 field, Google.Protobuf.ByteString& value)
  System.Boolean TryGetMessage(System.Int32 field, T& value)
  System.Boolean TryGetPrimitiveValue(System.Int32 field, T& value)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorReflection
TYPE:  class
TOKEN: 0x20000A8
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FileDescriptorSet
TYPE:  class
TOKEN: 0x20000A9
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    FileFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FileDescriptorProto>_repeated_file_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto>file_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.FileDescriptorSet other)
  Google.Protobuf.Reflection.FileDescriptorSet Clone()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto> get_File()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.FileDescriptorSet other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.FileDescriptorSet other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FileDescriptorProto
TYPE:  class
TOKEN: 0x20000AB
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private   static readonly System.String                   NameDefaultValue  // 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    PackageFieldNumber  // 0x0
  private   static readonly System.String                   PackageDefaultValue  // 0x10
  private           System.String                   package_  // 0x20
  public    static  System.Int32                    DependencyFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_dependency_codec  // 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>dependency_  // 0x28
  public    static  System.Int32                    PublicDependencyFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_publicDependency_codec  // 0x20
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>publicDependency_  // 0x30
  public    static  System.Int32                    WeakDependencyFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_weakDependency_codec  // 0x28
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>weakDependency_  // 0x38
  public    static  System.Int32                    MessageTypeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto>_repeated_messageType_codec  // 0x30
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto>messageType_  // 0x40
  public    static  System.Int32                    EnumTypeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto>_repeated_enumType_codec  // 0x38
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto>enumType_  // 0x48
  public    static  System.Int32                    ServiceFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.ServiceDescriptorProto>_repeated_service_codec  // 0x40
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto>service_  // 0x50
  public    static  System.Int32                    ExtensionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto>_repeated_extension_codec  // 0x48
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto>extension_  // 0x58
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.FileOptionsoptions_  // 0x60
  public    static  System.Int32                    SourceCodeInfoFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.SourceCodeInfosourceCodeInfo_  // 0x68
  public    static  System.Int32                    SyntaxFieldNumber  // 0x0
  private   static readonly System.String                   SyntaxDefaultValue  // 0x50
  private           System.String                   syntax_  // 0x70
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.FileDescriptorProto other)
  Google.Protobuf.Reflection.FileDescriptorProto Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_HasName()
  System.Void ClearName()
  System.String get_Package()
  System.Void set_Package(System.String value)
  System.Boolean get_HasPackage()
  System.Void ClearPackage()
  Google.Protobuf.Collections.RepeatedField<System.String> get_Dependency()
  Google.Protobuf.Collections.RepeatedField<System.Int32> get_PublicDependency()
  Google.Protobuf.Collections.RepeatedField<System.Int32> get_WeakDependency()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> get_MessageType()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> get_EnumType()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto> get_Service()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Extension()
  Google.Protobuf.Reflection.FileOptions get_Options()
  System.Void set_Options(Google.Protobuf.Reflection.FileOptions value)
  Google.Protobuf.Reflection.SourceCodeInfo get_SourceCodeInfo()
  System.Void set_SourceCodeInfo(Google.Protobuf.Reflection.SourceCodeInfo value)
  System.String get_Syntax()
  System.Void set_Syntax(System.String value)
  System.Boolean get_HasSyntax()
  System.Void ClearSyntax()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.FileDescriptorProto other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.FileDescriptorProto other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorProto
TYPE:  class
TOKEN: 0x20000AD
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private   static readonly System.String                   NameDefaultValue  // 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    FieldFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto>_repeated_field_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto>field_  // 0x20
  public    static  System.Int32                    ExtensionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto>_repeated_extension_codec  // 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto>extension_  // 0x28
  public    static  System.Int32                    NestedTypeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto>_repeated_nestedType_codec  // 0x20
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto>nestedType_  // 0x30
  public    static  System.Int32                    EnumTypeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto>_repeated_enumType_codec  // 0x28
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto>enumType_  // 0x38
  public    static  System.Int32                    ExtensionRangeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>_repeated_extensionRange_codec  // 0x30
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>extensionRange_  // 0x40
  public    static  System.Int32                    OneofDeclFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.OneofDescriptorProto>_repeated_oneofDecl_codec  // 0x38
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto>oneofDecl_  // 0x48
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.MessageOptionsoptions_  // 0x50
  public    static  System.Int32                    ReservedRangeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>_repeated_reservedRange_codec  // 0x40
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>reservedRange_  // 0x58
  public    static  System.Int32                    ReservedNameFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_reservedName_codec  // 0x48
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>reservedName_  // 0x60
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto other)
  Google.Protobuf.Reflection.DescriptorProto Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_HasName()
  System.Void ClearName()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Field()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Extension()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> get_NestedType()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> get_EnumType()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> get_ExtensionRange()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto> get_OneofDecl()
  Google.Protobuf.Reflection.MessageOptions get_Options()
  System.Void set_Options(Google.Protobuf.Reflection.MessageOptions value)
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> get_ReservedRange()
  Google.Protobuf.Collections.RepeatedField<System.String> get_ReservedName()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.ExtensionRangeOptions
TYPE:  class
TOKEN: 0x20000B4
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions>_extensions  // 0x18
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x20
METHODS:
  Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions> get__Extensions()
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.ExtensionRangeOptions other)
  Google.Protobuf.Reflection.ExtensionRangeOptions Clone()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.ExtensionRangeOptions other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.ExtensionRangeOptions other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldDescriptorProto
TYPE:  class
TOKEN: 0x20000B6
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private   static readonly System.String                   NameDefaultValue  // 0x8
  private           System.String                   name_  // 0x20
  public    static  System.Int32                    NumberFieldNumber  // 0x0
  private   static readonly System.Int32                    NumberDefaultValue  // 0x10
  private           System.Int32                    number_  // 0x28
  public    static  System.Int32                    LabelFieldNumber  // 0x0
  private   static readonly Google.Protobuf.Reflection.FieldDescriptorProto.Types.LabelLabelDefaultValue  // 0x14
  private           Google.Protobuf.Reflection.FieldDescriptorProto.Types.Labellabel_  // 0x2C
  public    static  System.Int32                    TypeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeTypeDefaultValue  // 0x18
  private           Google.Protobuf.Reflection.FieldDescriptorProto.Types.Typetype_  // 0x30
  public    static  System.Int32                    TypeNameFieldNumber  // 0x0
  private   static readonly System.String                   TypeNameDefaultValue  // 0x20
  private           System.String                   typeName_  // 0x38
  public    static  System.Int32                    ExtendeeFieldNumber  // 0x0
  private   static readonly System.String                   ExtendeeDefaultValue  // 0x28
  private           System.String                   extendee_  // 0x40
  public    static  System.Int32                    DefaultValueFieldNumber  // 0x0
  private   static readonly System.String                   DefaultValueDefaultValue  // 0x30
  private           System.String                   defaultValue_  // 0x48
  public    static  System.Int32                    OneofIndexFieldNumber  // 0x0
  private   static readonly System.Int32                    OneofIndexDefaultValue  // 0x38
  private           System.Int32                    oneofIndex_  // 0x50
  public    static  System.Int32                    JsonNameFieldNumber  // 0x0
  private   static readonly System.String                   JsonNameDefaultValue  // 0x40
  private           System.String                   jsonName_  // 0x58
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.FieldOptionsoptions_  // 0x60
  public    static  System.Int32                    Proto3OptionalFieldNumber  // 0x0
  private   static readonly System.Boolean                  Proto3OptionalDefaultValue  // 0x48
  private           System.Boolean                  proto3Optional_  // 0x68
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptorProto other)
  Google.Protobuf.Reflection.FieldDescriptorProto Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_HasName()
  System.Void ClearName()
  System.Int32 get_Number()
  System.Void set_Number(System.Int32 value)
  System.Boolean get_HasNumber()
  System.Void ClearNumber()
  Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label get_Label()
  System.Void set_Label(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label value)
  System.Boolean get_HasLabel()
  System.Void ClearLabel()
  Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type get_Type()
  System.Void set_Type(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type value)
  System.Boolean get_HasType()
  System.Void ClearType()
  System.String get_TypeName()
  System.Void set_TypeName(System.String value)
  System.Boolean get_HasTypeName()
  System.Void ClearTypeName()
  System.String get_Extendee()
  System.Void set_Extendee(System.String value)
  System.Boolean get_HasExtendee()
  System.Void ClearExtendee()
  System.String get_DefaultValue()
  System.Void set_DefaultValue(System.String value)
  System.Boolean get_HasDefaultValue()
  System.Void ClearDefaultValue()
  System.Int32 get_OneofIndex()
  System.Void set_OneofIndex(System.Int32 value)
  System.Boolean get_HasOneofIndex()
  System.Void ClearOneofIndex()
  System.String get_JsonName()
  System.Void set_JsonName(System.String value)
  System.Boolean get_HasJsonName()
  System.Void ClearJsonName()
  Google.Protobuf.Reflection.FieldOptions get_Options()
  System.Void set_Options(Google.Protobuf.Reflection.FieldOptions value)
  System.Boolean get_Proto3Optional()
  System.Void set_Proto3Optional(System.Boolean value)
  System.Boolean get_HasProto3Optional()
  System.Void ClearProto3Optional()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.FieldDescriptorProto other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.FieldDescriptorProto other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.OneofDescriptorProto
TYPE:  class
TOKEN: 0x20000BB
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private   static readonly System.String                   NameDefaultValue  // 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.OneofOptionsoptions_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptorProto other)
  Google.Protobuf.Reflection.OneofDescriptorProto Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_HasName()
  System.Void ClearName()
  Google.Protobuf.Reflection.OneofOptions get_Options()
  System.Void set_Options(Google.Protobuf.Reflection.OneofOptions value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.OneofDescriptorProto other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.OneofDescriptorProto other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumDescriptorProto
TYPE:  class
TOKEN: 0x20000BD
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private   static readonly System.String                   NameDefaultValue  // 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumValueDescriptorProto>_repeated_value_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto>value_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.EnumOptionsoptions_  // 0x28
  public    static  System.Int32                    ReservedRangeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>_repeated_reservedRange_codec  // 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>reservedRange_  // 0x30
  public    static  System.Int32                    ReservedNameFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_reservedName_codec  // 0x20
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>reservedName_  // 0x38
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto other)
  Google.Protobuf.Reflection.EnumDescriptorProto Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_HasName()
  System.Void ClearName()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto> get_Value()
  Google.Protobuf.Reflection.EnumOptions get_Options()
  System.Void set_Options(Google.Protobuf.Reflection.EnumOptions value)
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> get_ReservedRange()
  Google.Protobuf.Collections.RepeatedField<System.String> get_ReservedName()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.EnumDescriptorProto other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumValueDescriptorProto
TYPE:  class
TOKEN: 0x20000C2
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private   static readonly System.String                   NameDefaultValue  // 0x8
  private           System.String                   name_  // 0x20
  public    static  System.Int32                    NumberFieldNumber  // 0x0
  private   static readonly System.Int32                    NumberDefaultValue  // 0x10
  private           System.Int32                    number_  // 0x28
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.EnumValueOptionsoptions_  // 0x30
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.EnumValueDescriptorProto other)
  Google.Protobuf.Reflection.EnumValueDescriptorProto Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_HasName()
  System.Void ClearName()
  System.Int32 get_Number()
  System.Void set_Number(System.Int32 value)
  System.Boolean get_HasNumber()
  System.Void ClearNumber()
  Google.Protobuf.Reflection.EnumValueOptions get_Options()
  System.Void set_Options(Google.Protobuf.Reflection.EnumValueOptions value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.EnumValueDescriptorProto other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.EnumValueDescriptorProto other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.ServiceDescriptorProto
TYPE:  class
TOKEN: 0x20000C4
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private   static readonly System.String                   NameDefaultValue  // 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    MethodFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.MethodDescriptorProto>_repeated_method_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto>method_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.ServiceOptionsoptions_  // 0x28
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.ServiceDescriptorProto other)
  Google.Protobuf.Reflection.ServiceDescriptorProto Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_HasName()
  System.Void ClearName()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto> get_Method()
  Google.Protobuf.Reflection.ServiceOptions get_Options()
  System.Void set_Options(Google.Protobuf.Reflection.ServiceOptions value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.ServiceDescriptorProto other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.ServiceDescriptorProto other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.MethodDescriptorProto
TYPE:  class
TOKEN: 0x20000C6
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private   static readonly System.String                   NameDefaultValue  // 0x8
  private           System.String                   name_  // 0x20
  public    static  System.Int32                    InputTypeFieldNumber  // 0x0
  private   static readonly System.String                   InputTypeDefaultValue  // 0x10
  private           System.String                   inputType_  // 0x28
  public    static  System.Int32                    OutputTypeFieldNumber  // 0x0
  private   static readonly System.String                   OutputTypeDefaultValue  // 0x18
  private           System.String                   outputType_  // 0x30
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private           Google.Protobuf.Reflection.MethodOptionsoptions_  // 0x38
  public    static  System.Int32                    ClientStreamingFieldNumber  // 0x0
  private   static readonly System.Boolean                  ClientStreamingDefaultValue  // 0x20
  private           System.Boolean                  clientStreaming_  // 0x40
  public    static  System.Int32                    ServerStreamingFieldNumber  // 0x0
  private   static readonly System.Boolean                  ServerStreamingDefaultValue  // 0x21
  private           System.Boolean                  serverStreaming_  // 0x41
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.MethodDescriptorProto other)
  Google.Protobuf.Reflection.MethodDescriptorProto Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_HasName()
  System.Void ClearName()
  System.String get_InputType()
  System.Void set_InputType(System.String value)
  System.Boolean get_HasInputType()
  System.Void ClearInputType()
  System.String get_OutputType()
  System.Void set_OutputType(System.String value)
  System.Boolean get_HasOutputType()
  System.Void ClearOutputType()
  Google.Protobuf.Reflection.MethodOptions get_Options()
  System.Void set_Options(Google.Protobuf.Reflection.MethodOptions value)
  System.Boolean get_ClientStreaming()
  System.Void set_ClientStreaming(System.Boolean value)
  System.Boolean get_HasClientStreaming()
  System.Void ClearClientStreaming()
  System.Boolean get_ServerStreaming()
  System.Void set_ServerStreaming(System.Boolean value)
  System.Boolean get_HasServerStreaming()
  System.Void ClearServerStreaming()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.MethodDescriptorProto other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.MethodDescriptorProto other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FileOptions
TYPE:  class
TOKEN: 0x20000C8
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    JavaPackageFieldNumber  // 0x0
  private   static readonly System.String                   JavaPackageDefaultValue  // 0x8
  private           System.String                   javaPackage_  // 0x28
  public    static  System.Int32                    JavaOuterClassnameFieldNumber  // 0x0
  private   static readonly System.String                   JavaOuterClassnameDefaultValue  // 0x10
  private           System.String                   javaOuterClassname_  // 0x30
  public    static  System.Int32                    JavaMultipleFilesFieldNumber  // 0x0
  private   static readonly System.Boolean                  JavaMultipleFilesDefaultValue  // 0x18
  private           System.Boolean                  javaMultipleFiles_  // 0x38
  public    static  System.Int32                    JavaGenerateEqualsAndHashFieldNumber  // 0x0
  private   static readonly System.Boolean                  JavaGenerateEqualsAndHashDefaultValue  // 0x19
  private           System.Boolean                  javaGenerateEqualsAndHash_  // 0x39
  public    static  System.Int32                    JavaStringCheckUtf8FieldNumber  // 0x0
  private   static readonly System.Boolean                  JavaStringCheckUtf8DefaultValue  // 0x1A
  private           System.Boolean                  javaStringCheckUtf8_  // 0x3A
  public    static  System.Int32                    OptimizeForFieldNumber  // 0x0
  private   static readonly Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeOptimizeForDefaultValue  // 0x1C
  private           Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeoptimizeFor_  // 0x3C
  public    static  System.Int32                    GoPackageFieldNumber  // 0x0
  private   static readonly System.String                   GoPackageDefaultValue  // 0x20
  private           System.String                   goPackage_  // 0x40
  public    static  System.Int32                    CcGenericServicesFieldNumber  // 0x0
  private   static readonly System.Boolean                  CcGenericServicesDefaultValue  // 0x28
  private           System.Boolean                  ccGenericServices_  // 0x48
  public    static  System.Int32                    JavaGenericServicesFieldNumber  // 0x0
  private   static readonly System.Boolean                  JavaGenericServicesDefaultValue  // 0x29
  private           System.Boolean                  javaGenericServices_  // 0x49
  public    static  System.Int32                    PyGenericServicesFieldNumber  // 0x0
  private   static readonly System.Boolean                  PyGenericServicesDefaultValue  // 0x2A
  private           System.Boolean                  pyGenericServices_  // 0x4A
  public    static  System.Int32                    PhpGenericServicesFieldNumber  // 0x0
  private   static readonly System.Boolean                  PhpGenericServicesDefaultValue  // 0x2B
  private           System.Boolean                  phpGenericServices_  // 0x4B
  public    static  System.Int32                    DeprecatedFieldNumber  // 0x0
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // 0x2C
  private           System.Boolean                  deprecated_  // 0x4C
  public    static  System.Int32                    CcEnableArenasFieldNumber  // 0x0
  private   static readonly System.Boolean                  CcEnableArenasDefaultValue  // 0x2D
  private           System.Boolean                  ccEnableArenas_  // 0x4D
  public    static  System.Int32                    ObjcClassPrefixFieldNumber  // 0x0
  private   static readonly System.String                   ObjcClassPrefixDefaultValue  // 0x30
  private           System.String                   objcClassPrefix_  // 0x50
  public    static  System.Int32                    CsharpNamespaceFieldNumber  // 0x0
  private   static readonly System.String                   CsharpNamespaceDefaultValue  // 0x38
  private           System.String                   csharpNamespace_  // 0x58
  public    static  System.Int32                    SwiftPrefixFieldNumber  // 0x0
  private   static readonly System.String                   SwiftPrefixDefaultValue  // 0x40
  private           System.String                   swiftPrefix_  // 0x60
  public    static  System.Int32                    PhpClassPrefixFieldNumber  // 0x0
  private   static readonly System.String                   PhpClassPrefixDefaultValue  // 0x48
  private           System.String                   phpClassPrefix_  // 0x68
  public    static  System.Int32                    PhpNamespaceFieldNumber  // 0x0
  private   static readonly System.String                   PhpNamespaceDefaultValue  // 0x50
  private           System.String                   phpNamespace_  // 0x70
  public    static  System.Int32                    PhpMetadataNamespaceFieldNumber  // 0x0
  private   static readonly System.String                   PhpMetadataNamespaceDefaultValue  // 0x58
  private           System.String                   phpMetadataNamespace_  // 0x78
  public    static  System.Int32                    RubyPackageFieldNumber  // 0x0
  private   static readonly System.String                   RubyPackageDefaultValue  // 0x60
  private           System.String                   rubyPackage_  // 0x80
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // 0x68
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x88
METHODS:
  Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions> get__Extensions()
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.FileOptions other)
  Google.Protobuf.Reflection.FileOptions Clone()
  System.String get_JavaPackage()
  System.Void set_JavaPackage(System.String value)
  System.Boolean get_HasJavaPackage()
  System.Void ClearJavaPackage()
  System.String get_JavaOuterClassname()
  System.Void set_JavaOuterClassname(System.String value)
  System.Boolean get_HasJavaOuterClassname()
  System.Void ClearJavaOuterClassname()
  System.Boolean get_JavaMultipleFiles()
  System.Void set_JavaMultipleFiles(System.Boolean value)
  System.Boolean get_HasJavaMultipleFiles()
  System.Void ClearJavaMultipleFiles()
  System.Boolean get_JavaGenerateEqualsAndHash()
  System.Void set_JavaGenerateEqualsAndHash(System.Boolean value)
  System.Boolean get_HasJavaGenerateEqualsAndHash()
  System.Void ClearJavaGenerateEqualsAndHash()
  System.Boolean get_JavaStringCheckUtf8()
  System.Void set_JavaStringCheckUtf8(System.Boolean value)
  System.Boolean get_HasJavaStringCheckUtf8()
  System.Void ClearJavaStringCheckUtf8()
  Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode get_OptimizeFor()
  System.Void set_OptimizeFor(Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode value)
  System.Boolean get_HasOptimizeFor()
  System.Void ClearOptimizeFor()
  System.String get_GoPackage()
  System.Void set_GoPackage(System.String value)
  System.Boolean get_HasGoPackage()
  System.Void ClearGoPackage()
  System.Boolean get_CcGenericServices()
  System.Void set_CcGenericServices(System.Boolean value)
  System.Boolean get_HasCcGenericServices()
  System.Void ClearCcGenericServices()
  System.Boolean get_JavaGenericServices()
  System.Void set_JavaGenericServices(System.Boolean value)
  System.Boolean get_HasJavaGenericServices()
  System.Void ClearJavaGenericServices()
  System.Boolean get_PyGenericServices()
  System.Void set_PyGenericServices(System.Boolean value)
  System.Boolean get_HasPyGenericServices()
  System.Void ClearPyGenericServices()
  System.Boolean get_PhpGenericServices()
  System.Void set_PhpGenericServices(System.Boolean value)
  System.Boolean get_HasPhpGenericServices()
  System.Void ClearPhpGenericServices()
  System.Boolean get_Deprecated()
  System.Void set_Deprecated(System.Boolean value)
  System.Boolean get_HasDeprecated()
  System.Void ClearDeprecated()
  System.Boolean get_CcEnableArenas()
  System.Void set_CcEnableArenas(System.Boolean value)
  System.Boolean get_HasCcEnableArenas()
  System.Void ClearCcEnableArenas()
  System.String get_ObjcClassPrefix()
  System.Void set_ObjcClassPrefix(System.String value)
  System.Boolean get_HasObjcClassPrefix()
  System.Void ClearObjcClassPrefix()
  System.String get_CsharpNamespace()
  System.Void set_CsharpNamespace(System.String value)
  System.Boolean get_HasCsharpNamespace()
  System.Void ClearCsharpNamespace()
  System.String get_SwiftPrefix()
  System.Void set_SwiftPrefix(System.String value)
  System.Boolean get_HasSwiftPrefix()
  System.Void ClearSwiftPrefix()
  System.String get_PhpClassPrefix()
  System.Void set_PhpClassPrefix(System.String value)
  System.Boolean get_HasPhpClassPrefix()
  System.Void ClearPhpClassPrefix()
  System.String get_PhpNamespace()
  System.Void set_PhpNamespace(System.String value)
  System.Boolean get_HasPhpNamespace()
  System.Void ClearPhpNamespace()
  System.String get_PhpMetadataNamespace()
  System.Void set_PhpMetadataNamespace(System.String value)
  System.Boolean get_HasPhpMetadataNamespace()
  System.Void ClearPhpMetadataNamespace()
  System.String get_RubyPackage()
  System.Void set_RubyPackage(System.String value)
  System.Boolean get_HasRubyPackage()
  System.Void ClearRubyPackage()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.FileOptions other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.FileOptions other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.MessageOptions
TYPE:  class
TOKEN: 0x20000CC
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    MessageSetWireFormatFieldNumber  // 0x0
  private   static readonly System.Boolean                  MessageSetWireFormatDefaultValue  // 0x8
  private           System.Boolean                  messageSetWireFormat_  // 0x24
  public    static  System.Int32                    NoStandardDescriptorAccessorFieldNumber  // 0x0
  private   static readonly System.Boolean                  NoStandardDescriptorAccessorDefaultValue  // 0x9
  private           System.Boolean                  noStandardDescriptorAccessor_  // 0x25
  public    static  System.Int32                    DeprecatedFieldNumber  // 0x0
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // 0xA
  private           System.Boolean                  deprecated_  // 0x26
  public    static  System.Int32                    MapEntryFieldNumber  // 0x0
  private   static readonly System.Boolean                  MapEntryDefaultValue  // 0xB
  private           System.Boolean                  mapEntry_  // 0x27
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x28
METHODS:
  Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions> get__Extensions()
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.MessageOptions other)
  Google.Protobuf.Reflection.MessageOptions Clone()
  System.Boolean get_MessageSetWireFormat()
  System.Void set_MessageSetWireFormat(System.Boolean value)
  System.Boolean get_HasMessageSetWireFormat()
  System.Void ClearMessageSetWireFormat()
  System.Boolean get_NoStandardDescriptorAccessor()
  System.Void set_NoStandardDescriptorAccessor(System.Boolean value)
  System.Boolean get_HasNoStandardDescriptorAccessor()
  System.Void ClearNoStandardDescriptorAccessor()
  System.Boolean get_Deprecated()
  System.Void set_Deprecated(System.Boolean value)
  System.Boolean get_HasDeprecated()
  System.Void ClearDeprecated()
  System.Boolean get_MapEntry()
  System.Void set_MapEntry(System.Boolean value)
  System.Boolean get_HasMapEntry()
  System.Void ClearMapEntry()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.MessageOptions other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.MessageOptions other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldOptions
TYPE:  class
TOKEN: 0x20000CE
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    CtypeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.Reflection.FieldOptions.Types.CTypeCtypeDefaultValue  // 0x8
  private           Google.Protobuf.Reflection.FieldOptions.Types.CTypectype_  // 0x24
  public    static  System.Int32                    PackedFieldNumber  // 0x0
  private   static readonly System.Boolean                  PackedDefaultValue  // 0xC
  private           System.Boolean                  packed_  // 0x28
  public    static  System.Int32                    JstypeFieldNumber  // 0x0
  private   static readonly Google.Protobuf.Reflection.FieldOptions.Types.JSTypeJstypeDefaultValue  // 0x10
  private           Google.Protobuf.Reflection.FieldOptions.Types.JSTypejstype_  // 0x2C
  public    static  System.Int32                    LazyFieldNumber  // 0x0
  private   static readonly System.Boolean                  LazyDefaultValue  // 0x14
  private           System.Boolean                  lazy_  // 0x30
  public    static  System.Int32                    UnverifiedLazyFieldNumber  // 0x0
  private   static readonly System.Boolean                  UnverifiedLazyDefaultValue  // 0x15
  private           System.Boolean                  unverifiedLazy_  // 0x31
  public    static  System.Int32                    DeprecatedFieldNumber  // 0x0
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // 0x16
  private           System.Boolean                  deprecated_  // 0x32
  public    static  System.Int32                    WeakFieldNumber  // 0x0
  private   static readonly System.Boolean                  WeakDefaultValue  // 0x17
  private           System.Boolean                  weak_  // 0x33
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x38
METHODS:
  Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions> get__Extensions()
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.FieldOptions other)
  Google.Protobuf.Reflection.FieldOptions Clone()
  Google.Protobuf.Reflection.FieldOptions.Types.CType get_Ctype()
  System.Void set_Ctype(Google.Protobuf.Reflection.FieldOptions.Types.CType value)
  System.Boolean get_HasCtype()
  System.Void ClearCtype()
  System.Boolean get_Packed()
  System.Void set_Packed(System.Boolean value)
  System.Boolean get_HasPacked()
  System.Void ClearPacked()
  Google.Protobuf.Reflection.FieldOptions.Types.JSType get_Jstype()
  System.Void set_Jstype(Google.Protobuf.Reflection.FieldOptions.Types.JSType value)
  System.Boolean get_HasJstype()
  System.Void ClearJstype()
  System.Boolean get_Lazy()
  System.Void set_Lazy(System.Boolean value)
  System.Boolean get_HasLazy()
  System.Void ClearLazy()
  System.Boolean get_UnverifiedLazy()
  System.Void set_UnverifiedLazy(System.Boolean value)
  System.Boolean get_HasUnverifiedLazy()
  System.Void ClearUnverifiedLazy()
  System.Boolean get_Deprecated()
  System.Void set_Deprecated(System.Boolean value)
  System.Boolean get_HasDeprecated()
  System.Void ClearDeprecated()
  System.Boolean get_Weak()
  System.Void set_Weak(System.Boolean value)
  System.Boolean get_HasWeak()
  System.Void ClearWeak()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.FieldOptions other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.FieldOptions other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.OneofOptions
TYPE:  class
TOKEN: 0x20000D3
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions>_extensions  // 0x18
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x20
METHODS:
  Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions> get__Extensions()
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.OneofOptions other)
  Google.Protobuf.Reflection.OneofOptions Clone()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.OneofOptions other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.OneofOptions other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumOptions
TYPE:  class
TOKEN: 0x20000D5
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    AllowAliasFieldNumber  // 0x0
  private   static readonly System.Boolean                  AllowAliasDefaultValue  // 0x8
  private           System.Boolean                  allowAlias_  // 0x24
  public    static  System.Int32                    DeprecatedFieldNumber  // 0x0
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // 0x9
  private           System.Boolean                  deprecated_  // 0x25
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x28
METHODS:
  Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions> get__Extensions()
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.EnumOptions other)
  Google.Protobuf.Reflection.EnumOptions Clone()
  System.Boolean get_AllowAlias()
  System.Void set_AllowAlias(System.Boolean value)
  System.Boolean get_HasAllowAlias()
  System.Void ClearAllowAlias()
  System.Boolean get_Deprecated()
  System.Void set_Deprecated(System.Boolean value)
  System.Boolean get_HasDeprecated()
  System.Void ClearDeprecated()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.EnumOptions other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.EnumOptions other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumValueOptions
TYPE:  class
TOKEN: 0x20000D7
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    DeprecatedFieldNumber  // 0x0
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // 0x8
  private           System.Boolean                  deprecated_  // 0x24
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x28
METHODS:
  Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions> get__Extensions()
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.EnumValueOptions other)
  Google.Protobuf.Reflection.EnumValueOptions Clone()
  System.Boolean get_Deprecated()
  System.Void set_Deprecated(System.Boolean value)
  System.Boolean get_HasDeprecated()
  System.Void ClearDeprecated()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.EnumValueOptions other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.EnumValueOptions other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.ServiceOptions
TYPE:  class
TOKEN: 0x20000D9
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    DeprecatedFieldNumber  // 0x0
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // 0x8
  private           System.Boolean                  deprecated_  // 0x24
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x28
METHODS:
  Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions> get__Extensions()
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.ServiceOptions other)
  Google.Protobuf.Reflection.ServiceOptions Clone()
  System.Boolean get_Deprecated()
  System.Void set_Deprecated(System.Boolean value)
  System.Boolean get_HasDeprecated()
  System.Void ClearDeprecated()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.ServiceOptions other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.ServiceOptions other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.MethodOptions
TYPE:  class
TOKEN: 0x20000DB
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    DeprecatedFieldNumber  // 0x0
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // 0x8
  private           System.Boolean                  deprecated_  // 0x24
  public    static  System.Int32                    IdempotencyLevelFieldNumber  // 0x0
  private   static readonly Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelIdempotencyLevelDefaultValue  // 0xC
  private           Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelidempotencyLevel_  // 0x28
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x30
METHODS:
  Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions> get__Extensions()
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.MethodOptions other)
  Google.Protobuf.Reflection.MethodOptions Clone()
  System.Boolean get_Deprecated()
  System.Void set_Deprecated(System.Boolean value)
  System.Boolean get_HasDeprecated()
  System.Void ClearDeprecated()
  Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel get_IdempotencyLevel()
  System.Void set_IdempotencyLevel(Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel value)
  System.Boolean get_HasIdempotencyLevel()
  System.Void ClearIdempotencyLevel()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.MethodOptions other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.MethodOptions other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension, TValue value)
  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.UninterpretedOption
TYPE:  class
TOKEN: 0x20000DF
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>_repeated_name_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>name_  // 0x20
  public    static  System.Int32                    IdentifierValueFieldNumber  // 0x0
  private   static readonly System.String                   IdentifierValueDefaultValue  // 0x10
  private           System.String                   identifierValue_  // 0x28
  public    static  System.Int32                    PositiveIntValueFieldNumber  // 0x0
  private   static readonly System.UInt64                   PositiveIntValueDefaultValue  // 0x18
  private           System.UInt64                   positiveIntValue_  // 0x30
  public    static  System.Int32                    NegativeIntValueFieldNumber  // 0x0
  private   static readonly System.Int64                    NegativeIntValueDefaultValue  // 0x20
  private           System.Int64                    negativeIntValue_  // 0x38
  public    static  System.Int32                    DoubleValueFieldNumber  // 0x0
  private   static readonly System.Double                   DoubleValueDefaultValue  // 0x28
  private           System.Double                   doubleValue_  // 0x40
  public    static  System.Int32                    StringValueFieldNumber  // 0x0
  private   static readonly Google.Protobuf.ByteString      StringValueDefaultValue  // 0x30
  private           Google.Protobuf.ByteString      stringValue_  // 0x48
  public    static  System.Int32                    AggregateValueFieldNumber  // 0x0
  private   static readonly System.String                   AggregateValueDefaultValue  // 0x38
  private           System.String                   aggregateValue_  // 0x50
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.UninterpretedOption other)
  Google.Protobuf.Reflection.UninterpretedOption Clone()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> get_Name()
  System.String get_IdentifierValue()
  System.Void set_IdentifierValue(System.String value)
  System.Boolean get_HasIdentifierValue()
  System.Void ClearIdentifierValue()
  System.UInt64 get_PositiveIntValue()
  System.Void set_PositiveIntValue(System.UInt64 value)
  System.Boolean get_HasPositiveIntValue()
  System.Void ClearPositiveIntValue()
  System.Int64 get_NegativeIntValue()
  System.Void set_NegativeIntValue(System.Int64 value)
  System.Boolean get_HasNegativeIntValue()
  System.Void ClearNegativeIntValue()
  System.Double get_DoubleValue()
  System.Void set_DoubleValue(System.Double value)
  System.Boolean get_HasDoubleValue()
  System.Void ClearDoubleValue()
  Google.Protobuf.ByteString get_StringValue()
  System.Void set_StringValue(Google.Protobuf.ByteString value)
  System.Boolean get_HasStringValue()
  System.Void ClearStringValue()
  System.String get_AggregateValue()
  System.Void set_AggregateValue(System.String value)
  System.Boolean get_HasAggregateValue()
  System.Void ClearAggregateValue()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.UninterpretedOption other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.SourceCodeInfo
TYPE:  class
TOKEN: 0x20000E4
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    LocationFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>_repeated_location_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>location_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.SourceCodeInfo other)
  Google.Protobuf.Reflection.SourceCodeInfo Clone()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> get_Location()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.SourceCodeInfo other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.GeneratedCodeInfo
TYPE:  class
TOKEN: 0x20000E9
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    AnnotationFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>_repeated_annotation_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>annotation_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.Reflection.GeneratedCodeInfo other)
  Google.Protobuf.Reflection.GeneratedCodeInfo Clone()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> get_Annotation()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.Reflection.GeneratedCodeInfo other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorBase
TYPE:  class
TOKEN: 0x20000EE
FIELDS:
  private   readonly System.Int32                    <Index>k__BackingField  // 0x10
  private   readonly System.String                   <FullName>k__BackingField  // 0x18
  private   readonly Google.Protobuf.Reflection.FileDescriptor<File>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.FileDescriptor file, System.String fullName, System.Int32 index)
  System.Int32 get_Index()
  System.String get_Name()
  System.String get_FullName()
  Google.Protobuf.Reflection.FileDescriptor get_File()
  Google.Protobuf.Reflection.DescriptorDeclaration get_Declaration()
  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorDeclaration
TYPE:  class
TOKEN: 0x20000EF
FIELDS:
  private   readonly Google.Protobuf.Reflection.IDescriptor<Descriptor>k__BackingField  // 0x10
  private   readonly System.Int32                    <StartLine>k__BackingField  // 0x18
  private   readonly System.Int32                    <StartColumn>k__BackingField  // 0x1C
  private   readonly System.Int32                    <EndLine>k__BackingField  // 0x20
  private   readonly System.Int32                    <EndColumn>k__BackingField  // 0x24
  private   readonly System.String                   <LeadingComments>k__BackingField  // 0x28
  private   readonly System.String                   <TrailingComments>k__BackingField  // 0x30
  private   readonly System.Collections.Generic.IReadOnlyList<System.String><LeadingDetachedComments>k__BackingField  // 0x38
METHODS:
  Google.Protobuf.Reflection.IDescriptor get_Descriptor()
  System.Int32 get_StartLine()
  System.Int32 get_StartColumn()
  System.Int32 get_EndLine()
  System.Int32 get_EndColumn()
  System.String get_LeadingComments()
  System.String get_TrailingComments()
  System.Collections.Generic.IReadOnlyList<System.String> get_LeadingDetachedComments()
  System.Void .ctor(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location)
  Google.Protobuf.Reflection.DescriptorDeclaration FromProto(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location)
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorPool
TYPE:  class
TOKEN: 0x20000F0
FIELDS:
  private   readonly System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.IDescriptor>descriptorsByName  // 0x10
  private   readonly System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.FieldDescriptor>fieldsByNumber  // 0x18
  private   readonly System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.EnumValueDescriptor>enumValuesByNumber  // 0x20
  private   readonly System.Collections.Generic.HashSet<Google.Protobuf.Reflection.FileDescriptor>dependencies  // 0x28
  private   static readonly System.Text.RegularExpressions.RegexValidationRegex  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencyFiles)
  System.Void ImportPublicDependencies(Google.Protobuf.Reflection.FileDescriptor file)
  T FindSymbol(System.String fullName)
  System.Void AddPackage(System.String fullName, Google.Protobuf.Reflection.FileDescriptor file)
  System.Void AddSymbol(Google.Protobuf.Reflection.IDescriptor descriptor)
  System.Void ValidateSymbolName(Google.Protobuf.Reflection.IDescriptor descriptor)
  Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor, System.Int32 number)
  Google.Protobuf.Reflection.EnumValueDescriptor FindEnumValueByNumber(Google.Protobuf.Reflection.EnumDescriptor enumDescriptor, System.Int32 number)
  System.Void AddFieldByNumber(Google.Protobuf.Reflection.FieldDescriptor field)
  System.Void AddEnumValueByNumber(Google.Protobuf.Reflection.EnumValueDescriptor enumValue)
  Google.Protobuf.Reflection.IDescriptor LookupSymbol(System.String name, Google.Protobuf.Reflection.IDescriptor relativeTo)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorUtil
TYPE:  class
TOKEN: 0x20000F1
FIELDS:
METHODS:
  System.Collections.Generic.IList<TOutput> ConvertAndMakeReadOnly(System.Collections.Generic.IList<TInput> input, Google.Protobuf.Reflection.DescriptorUtil.IndexedConverter<TInput,TOutput> converter)
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorValidationException
TYPE:  class
TOKEN: 0x20000F3
EXTENDS: Exception
FIELDS:
  private   readonly System.String                   name  // 0x90
  private   readonly System.String                   description  // 0x98
METHODS:
  System.String get_ProblemSymbolName()
  System.String get_Description()
  System.Void .ctor(Google.Protobuf.Reflection.IDescriptor problemDescriptor, System.String description)
  System.Void .ctor(Google.Protobuf.Reflection.IDescriptor problemDescriptor, System.String description, System.Exception cause)
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumDescriptor
TYPE:  class
TOKEN: 0x20000F4
EXTENDS: DescriptorBase
FIELDS:
  private   readonly Google.Protobuf.Reflection.EnumDescriptorProtoproto  // 0x28
  private   readonly Google.Protobuf.Reflection.MessageDescriptorcontainingType  // 0x30
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor>values  // 0x38
  private   readonly System.Type                     clrType  // 0x40
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.Type clrType)
  Google.Protobuf.Reflection.EnumDescriptorProto get_Proto()
  Google.Protobuf.Reflection.EnumDescriptorProto ToProto()
  System.String get_Name()
  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
  System.Type get_ClrType()
  Google.Protobuf.Reflection.MessageDescriptor get_ContainingType()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor> get_Values()
  Google.Protobuf.Reflection.EnumValueDescriptor FindValueByNumber(System.Int32 number)
  Google.Protobuf.Reflection.EnumValueDescriptor FindValueByName(System.String name)
  Google.Protobuf.Reflection.CustomOptions get_CustomOptions()
  Google.Protobuf.Reflection.EnumOptions GetOptions()
  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,T> extension)
  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,T> extension)
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumValueDescriptor
TYPE:  class
TOKEN: 0x20000F6
EXTENDS: DescriptorBase
FIELDS:
  private   readonly Google.Protobuf.Reflection.EnumDescriptorenumDescriptor  // 0x28
  private   readonly Google.Protobuf.Reflection.EnumValueDescriptorProtoproto  // 0x30
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.EnumValueDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.EnumDescriptor parent, System.Int32 index)
  Google.Protobuf.Reflection.EnumValueDescriptorProto get_Proto()
  Google.Protobuf.Reflection.EnumValueDescriptorProto ToProto()
  System.String get_Name()
  System.Int32 get_Number()
  Google.Protobuf.Reflection.EnumDescriptor get_EnumDescriptor()
  Google.Protobuf.Reflection.CustomOptions get_CustomOptions()
  Google.Protobuf.Reflection.EnumValueOptions GetOptions()
  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,T> extension)
  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,T> extension)
END_CLASS

CLASS: Google.Protobuf.Reflection.ExtensionAccessor
TYPE:  class
TOKEN: 0x20000F7
FIELDS:
  private   readonly Google.Protobuf.Extension       extension  // 0x10
  private   readonly Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelperhelper  // 0x18
  private   readonly Google.Protobuf.Reflection.FieldDescriptor<Descriptor>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptor descriptor)
  Google.Protobuf.Reflection.FieldDescriptor get_Descriptor()
  System.Void Clear(Google.Protobuf.IMessage message)
  System.Boolean HasValue(Google.Protobuf.IMessage message)
  System.Object GetValue(Google.Protobuf.IMessage message)
  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.ExtensionCollection
TYPE:  class
TOKEN: 0x20000F8
FIELDS:
  private           System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>extensionsByTypeInDeclarationOrder  // 0x10
  private           System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>extensionsByTypeInNumberOrder  // 0x18
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor><UnorderedExtensions>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Extension[] extensions)
  System.Void .ctor(Google.Protobuf.Reflection.MessageDescriptor message, Google.Protobuf.Extension[] extensions)
  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> get_UnorderedExtensions()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInDeclarationOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor)
  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInNumberOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor)
  System.Void CrossLink()
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldAccessorBase
TYPE:  class
TOKEN: 0x20000FC
FIELDS:
  private   readonly System.Func<Google.Protobuf.IMessage,System.Object>getValueDelegate  // 0x10
  private   readonly Google.Protobuf.Reflection.FieldDescriptordescriptor  // 0x18
METHODS:
  System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor)
  Google.Protobuf.Reflection.FieldDescriptor get_Descriptor()
  System.Object GetValue(Google.Protobuf.IMessage message)
  System.Boolean HasValue(Google.Protobuf.IMessage message)
  System.Void Clear(Google.Protobuf.IMessage message)
  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldDescriptor
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: DescriptorBase
FIELDS:
  private           Google.Protobuf.Reflection.EnumDescriptorenumType  // 0x28
  private           Google.Protobuf.Reflection.MessageDescriptorextendeeType  // 0x30
  private           Google.Protobuf.Reflection.MessageDescriptormessageType  // 0x38
  private           Google.Protobuf.Reflection.FieldTypefieldType  // 0x40
  private           Google.Protobuf.Reflection.IFieldAccessoraccessor  // 0x48
  private   readonly Google.Protobuf.Reflection.MessageDescriptor<ContainingType>k__BackingField  // 0x50
  private   readonly Google.Protobuf.Reflection.OneofDescriptor<ContainingOneof>k__BackingField  // 0x58
  private   readonly System.String                   <JsonName>k__BackingField  // 0x60
  private   readonly System.String                   <PropertyName>k__BackingField  // 0x68
  private   readonly Google.Protobuf.Reflection.FieldDescriptorProto<Proto>k__BackingField  // 0x70
  private   readonly Google.Protobuf.Extension       <Extension>k__BackingField  // 0x78
METHODS:
  Google.Protobuf.Reflection.MessageDescriptor get_ContainingType()
  Google.Protobuf.Reflection.OneofDescriptor get_ContainingOneof()
  Google.Protobuf.Reflection.OneofDescriptor get_RealContainingOneof()
  System.String get_JsonName()
  System.String get_PropertyName()
  System.Boolean get_HasPresence()
  Google.Protobuf.Reflection.FieldDescriptorProto get_Proto()
  Google.Protobuf.Reflection.FieldDescriptorProto ToProto()
  Google.Protobuf.Extension get_Extension()
  System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.String propertyName, Google.Protobuf.Extension extension)
  System.String get_Name()
  Google.Protobuf.Reflection.IFieldAccessor get_Accessor()
  Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type)
  System.Boolean get_IsRepeated()
  System.Boolean get_IsRequired()
  System.Boolean get_IsMap()
  System.Boolean get_IsPacked()
  System.Boolean get_IsExtension()
  Google.Protobuf.Reflection.FieldType get_FieldType()
  System.Int32 get_FieldNumber()
  System.Int32 CompareTo(Google.Protobuf.Reflection.FieldDescriptor other)
  Google.Protobuf.Reflection.EnumDescriptor get_EnumType()
  Google.Protobuf.Reflection.MessageDescriptor get_MessageType()
  Google.Protobuf.Reflection.MessageDescriptor get_ExtendeeType()
  Google.Protobuf.Reflection.CustomOptions get_CustomOptions()
  Google.Protobuf.Reflection.FieldOptions GetOptions()
  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,T> extension)
  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,T> extension)
  System.Void CrossLink()
  Google.Protobuf.Reflection.IFieldAccessor CreateAccessor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldType
TYPE:  struct
TOKEN: 0x20000FE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldTypeDouble  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeFloat  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeInt64  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeUInt64  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeInt32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeFixed64  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeFixed32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeBool  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeString  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeGroup  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeMessage  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeBytes  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeUInt32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeSFixed32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeSFixed64  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeSInt32  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeSInt64  // 0x0
  public    static  Google.Protobuf.Reflection.FieldTypeEnum  // 0x0
METHODS:
END_CLASS

CLASS: Google.Protobuf.Reflection.Syntax
TYPE:  struct
TOKEN: 0x20000FF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.SyntaxProto2  // 0x0
  public    static  Google.Protobuf.Reflection.SyntaxProto3  // 0x0
  public    static  Google.Protobuf.Reflection.SyntaxUnknown  // 0x0
METHODS:
END_CLASS

CLASS: Google.Protobuf.Reflection.FileDescriptor
TYPE:  class
TOKEN: 0x2000100
FIELDS:
  private   readonly System.Lazy<System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration>>declarations  // 0x10
  private   readonly Google.Protobuf.Reflection.FileDescriptorProto<Proto>k__BackingField  // 0x18
  private   readonly Google.Protobuf.Reflection.Syntax<Syntax>k__BackingField  // 0x20
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor><MessageTypes>k__BackingField  // 0x28
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor><EnumTypes>k__BackingField  // 0x30
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor><Services>k__BackingField  // 0x38
  private   readonly Google.Protobuf.Reflection.ExtensionCollection<Extensions>k__BackingField  // 0x40
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor><Dependencies>k__BackingField  // 0x48
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor><PublicDependencies>k__BackingField  // 0x50
  private   readonly Google.Protobuf.ByteString      <SerializedData>k__BackingField  // 0x58
  private   readonly Google.Protobuf.Reflection.DescriptorPool<DescriptorPool>k__BackingField  // 0x60
METHODS:
  System.Void .cctor()
  System.Void .ctor(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, Google.Protobuf.Reflection.DescriptorPool pool, System.Boolean allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
  System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration> CreateDeclarationMap()
  Google.Protobuf.Reflection.IDescriptor FindDescriptorForPath(System.Collections.Generic.IList<System.Int32> path)
  Google.Protobuf.Reflection.DescriptorBase GetDescriptorFromList(System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> list, System.Int32 index)
  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
  Google.Protobuf.Reflection.DescriptorDeclaration GetDeclaration(Google.Protobuf.Reflection.IDescriptor descriptor)
  System.String ComputeFullName(Google.Protobuf.Reflection.MessageDescriptor parent, System.String name)
  System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> DeterminePublicDependencies(Google.Protobuf.Reflection.FileDescriptor this, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, System.Boolean allowUnknownDependencies)
  Google.Protobuf.Reflection.FileDescriptorProto get_Proto()
  Google.Protobuf.Reflection.FileDescriptorProto ToProto()
  Google.Protobuf.Reflection.Syntax get_Syntax()
  System.String get_Name()
  System.String get_Package()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> get_MessageTypes()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> get_EnumTypes()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor> get_Services()
  Google.Protobuf.Reflection.ExtensionCollection get_Extensions()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> get_Dependencies()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> get_PublicDependencies()
  Google.Protobuf.ByteString get_SerializedData()
  System.String Google.Protobuf.Reflection.IDescriptor.get_FullName()
  Google.Protobuf.Reflection.FileDescriptor Google.Protobuf.Reflection.IDescriptor.get_File()
  Google.Protobuf.Reflection.DescriptorPool get_DescriptorPool()
  T FindTypeByName(System.String name)
  Google.Protobuf.Reflection.FileDescriptor BuildFrom(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor[] dependencies, System.Boolean allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
  System.Void CrossLink()
  Google.Protobuf.Reflection.FileDescriptor FromGeneratedCode(System.Byte[] descriptorData, Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
  System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllExtensions(Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedInfo)
  System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllGeneratedExtensions(Google.Protobuf.Reflection.GeneratedClrTypeInfo generated)
  System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensions(Google.Protobuf.Reflection.FileDescriptor descriptor)
  System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensionsFromMessage(Google.Protobuf.Reflection.MessageDescriptor descriptor)
  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData, Google.Protobuf.ExtensionRegistry registry)
  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData)
  System.String ToString()
  Google.Protobuf.Reflection.FileDescriptor get_DescriptorProtoFileDescriptor()
  Google.Protobuf.Reflection.CustomOptions get_CustomOptions()
  Google.Protobuf.Reflection.FileOptions GetOptions()
  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,T> extension)
  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,T> extension)
  System.Void ForceReflectionInitialization()
END_CLASS

CLASS: Google.Protobuf.Reflection.GeneratedClrTypeInfo
TYPE:  class
TOKEN: 0x2000103
FIELDS:
  private   static readonly System.String[]                 EmptyNames  // 0x0
  private   static readonly Google.Protobuf.Reflection.GeneratedClrTypeInfo[]EmptyCodeInfo  // 0x8
  private   static readonly Google.Protobuf.Extension[]     EmptyExtensions  // 0x10
  private   static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesMessageAccessibility  // 0x0
  private           System.Type                     <ClrType>k__BackingField  // 0x10
  private   readonly Google.Protobuf.MessageParser   <Parser>k__BackingField  // 0x18
  private   readonly System.String[]                 <PropertyNames>k__BackingField  // 0x20
  private   readonly Google.Protobuf.Extension[]     <Extensions>k__BackingField  // 0x28
  private   readonly System.String[]                 <OneofNames>k__BackingField  // 0x30
  private   readonly Google.Protobuf.Reflection.GeneratedClrTypeInfo[]<NestedTypes>k__BackingField  // 0x38
  private   readonly System.Type[]                   <NestedEnums>k__BackingField  // 0x40
METHODS:
  System.Type get_ClrType()
  System.Void set_ClrType(System.Type value)
  Google.Protobuf.MessageParser get_Parser()
  System.String[] get_PropertyNames()
  Google.Protobuf.Extension[] get_Extensions()
  System.String[] get_OneofNames()
  Google.Protobuf.Reflection.GeneratedClrTypeInfo[] get_NestedTypes()
  System.Type[] get_NestedEnums()
  System.Void .ctor(System.Type clrType, Google.Protobuf.MessageParser parser, System.String[] propertyNames, System.String[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes)
  System.Void .ctor(System.Type clrType, Google.Protobuf.MessageParser parser, System.String[] propertyNames, System.String[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes)
  System.Void .ctor(System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes)
  System.Void .ctor(System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.IDescriptor
TYPE:  interface
TOKEN: 0x2000104
FIELDS:
METHODS:
  System.String get_Name()
  System.String get_FullName()
  Google.Protobuf.Reflection.FileDescriptor get_File()
END_CLASS

CLASS: Google.Protobuf.Reflection.IFieldAccessor
TYPE:  interface
TOKEN: 0x2000105
FIELDS:
METHODS:
  Google.Protobuf.Reflection.FieldDescriptor get_Descriptor()
  System.Void Clear(Google.Protobuf.IMessage message)
  System.Object GetValue(Google.Protobuf.IMessage message)
  System.Boolean HasValue(Google.Protobuf.IMessage message)
  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.MapFieldAccessor
TYPE:  class
TOKEN: 0x2000106
EXTENDS: FieldAccessorBase
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor)
  System.Void Clear(Google.Protobuf.IMessage message)
  System.Boolean HasValue(Google.Protobuf.IMessage message)
  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.MessageDescriptor
TYPE:  class
TOKEN: 0x2000107
EXTENDS: DescriptorBase
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<System.String>WellKnownTypeNames  // 0x0
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>fieldsInDeclarationOrder  // 0x28
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>fieldsInNumberOrder  // 0x30
  private   readonly System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor>jsonFieldMap  // 0x38
  private           System.Func<Google.Protobuf.IMessage,System.Boolean>extensionSetIsInitialized  // 0x40
  private   readonly Google.Protobuf.Reflection.DescriptorProto<Proto>k__BackingField  // 0x48
  private   readonly System.Type                     <ClrType>k__BackingField  // 0x50
  private   readonly Google.Protobuf.MessageParser   <Parser>k__BackingField  // 0x58
  private   readonly Google.Protobuf.Reflection.MessageDescriptor<ContainingType>k__BackingField  // 0x60
  private   readonly Google.Protobuf.Reflection.MessageDescriptor.FieldCollection<Fields>k__BackingField  // 0x68
  private   readonly Google.Protobuf.Reflection.ExtensionCollection<Extensions>k__BackingField  // 0x70
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor><NestedTypes>k__BackingField  // 0x78
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor><EnumTypes>k__BackingField  // 0x80
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor><Oneofs>k__BackingField  // 0x88
  private   readonly System.Int32                    <RealOneofCount>k__BackingField  // 0x90
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 typeIndex, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
  System.Collections.ObjectModel.ReadOnlyDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> CreateJsonFieldMap(System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields)
  System.String get_Name()
  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
  Google.Protobuf.Reflection.DescriptorProto get_Proto()
  Google.Protobuf.Reflection.DescriptorProto ToProto()
  System.Boolean IsExtensionsInitialized(Google.Protobuf.IMessage message)
  System.Type get_ClrType()
  Google.Protobuf.MessageParser get_Parser()
  System.Boolean get_IsWellKnownType()
  System.Boolean get_IsWrapperType()
  Google.Protobuf.Reflection.MessageDescriptor get_ContainingType()
  Google.Protobuf.Reflection.MessageDescriptor.FieldCollection get_Fields()
  Google.Protobuf.Reflection.ExtensionCollection get_Extensions()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> get_NestedTypes()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> get_EnumTypes()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor> get_Oneofs()
  System.Int32 get_RealOneofCount()
  Google.Protobuf.Reflection.FieldDescriptor FindFieldByName(System.String name)
  Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(System.Int32 number)
  T FindDescriptor(System.String name)
  Google.Protobuf.Reflection.CustomOptions get_CustomOptions()
  Google.Protobuf.Reflection.MessageOptions GetOptions()
  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,T> extension)
  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,T> extension)
  System.Void CrossLink()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.MethodDescriptor
TYPE:  class
TOKEN: 0x200010B
EXTENDS: DescriptorBase
FIELDS:
  private   readonly Google.Protobuf.Reflection.MethodDescriptorProtoproto  // 0x28
  private   readonly Google.Protobuf.Reflection.ServiceDescriptorservice  // 0x30
  private           Google.Protobuf.Reflection.MessageDescriptorinputType  // 0x38
  private           Google.Protobuf.Reflection.MessageDescriptoroutputType  // 0x40
METHODS:
  Google.Protobuf.Reflection.ServiceDescriptor get_Service()
  Google.Protobuf.Reflection.MessageDescriptor get_InputType()
  Google.Protobuf.Reflection.MessageDescriptor get_OutputType()
  System.Boolean get_IsClientStreaming()
  System.Boolean get_IsServerStreaming()
  Google.Protobuf.Reflection.CustomOptions get_CustomOptions()
  Google.Protobuf.Reflection.MethodOptions GetOptions()
  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,T> extension)
  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,T> extension)
  System.Void .ctor(Google.Protobuf.Reflection.MethodDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.ServiceDescriptor parent, System.Int32 index)
  Google.Protobuf.Reflection.MethodDescriptorProto get_Proto()
  Google.Protobuf.Reflection.MethodDescriptorProto ToProto()
  System.String get_Name()
  System.Void CrossLink()
END_CLASS

CLASS: Google.Protobuf.Reflection.OneofAccessor
TYPE:  class
TOKEN: 0x200010C
FIELDS:
  private   readonly System.Func<Google.Protobuf.IMessage,System.Int32>caseDelegate  // 0x10
  private   readonly System.Action<Google.Protobuf.IMessage>clearDelegate  // 0x18
  private   readonly Google.Protobuf.Reflection.OneofDescriptor<Descriptor>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Func<Google.Protobuf.IMessage,System.Int32> caseDelegate, System.Action<Google.Protobuf.IMessage> clearDelegate)
  Google.Protobuf.Reflection.OneofAccessor ForRegularOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Reflection.PropertyInfo caseProperty, System.Reflection.MethodInfo clearMethod)
  Google.Protobuf.Reflection.OneofAccessor ForSyntheticOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor)
  Google.Protobuf.Reflection.OneofDescriptor get_Descriptor()
  System.Void Clear(Google.Protobuf.IMessage message)
  Google.Protobuf.Reflection.FieldDescriptor GetCaseFieldDescriptor(Google.Protobuf.IMessage message)
END_CLASS

CLASS: Google.Protobuf.Reflection.OneofDescriptor
TYPE:  class
TOKEN: 0x200010E
EXTENDS: DescriptorBase
FIELDS:
  private           Google.Protobuf.Reflection.MessageDescriptorcontainingType  // 0x28
  private           System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>fields  // 0x30
  private   readonly Google.Protobuf.Reflection.OneofAccessoraccessor  // 0x38
  private   readonly Google.Protobuf.Reflection.OneofDescriptorProto<Proto>k__BackingField  // 0x40
  private   readonly System.Boolean                  <IsSynthetic>k__BackingField  // 0x48
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.String clrName)
  System.String get_Name()
  Google.Protobuf.Reflection.OneofDescriptorProto get_Proto()
  Google.Protobuf.Reflection.OneofDescriptorProto ToProto()
  Google.Protobuf.Reflection.MessageDescriptor get_ContainingType()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> get_Fields()
  System.Boolean get_IsSynthetic()
  Google.Protobuf.Reflection.OneofAccessor get_Accessor()
  Google.Protobuf.Reflection.CustomOptions get_CustomOptions()
  Google.Protobuf.Reflection.OneofOptions GetOptions()
  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,T> extension)
  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,T> extension)
  System.Void CrossLink()
  Google.Protobuf.Reflection.OneofAccessor CreateAccessor(System.String clrName)
END_CLASS

CLASS: Google.Protobuf.Reflection.OriginalNameAttribute
TYPE:  class
TOKEN: 0x2000110
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.Boolean                  <PreferredAlias>k__BackingField  // 0x18
METHODS:
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_PreferredAlias()
  System.Void set_PreferredAlias(System.Boolean value)
  System.Void .ctor(System.String name)
END_CLASS

CLASS: Google.Protobuf.Reflection.PackageDescriptor
TYPE:  class
TOKEN: 0x2000111
FIELDS:
  private   readonly System.String                   name  // 0x10
  private   readonly System.String                   fullName  // 0x18
  private   readonly Google.Protobuf.Reflection.FileDescriptorfile  // 0x20
METHODS:
  System.Void .ctor(System.String name, System.String fullName, Google.Protobuf.Reflection.FileDescriptor file)
  System.String get_Name()
  System.String get_FullName()
  Google.Protobuf.Reflection.FileDescriptor get_File()
END_CLASS

CLASS: Google.Protobuf.Reflection.ReflectionUtil
TYPE:  class
TOKEN: 0x2000112
FIELDS:
  private   static readonly System.Type[]                   EmptyTypes  // 0x0
  private   static readonly System.Boolean                  <CanConvertEnumFuncToInt32Func>k__BackingField  // 0x8
METHODS:
  System.Void .cctor()
  System.Void ForceInitialize()
  System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method)
  System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method)
  System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method)
  System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method)
  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method)
  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller(System.Type msg)
  Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper CreateExtensionHelper(Google.Protobuf.Extension extension)
  Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper GetReflectionHelper(System.Type t1, System.Type t2)
  System.Boolean get_CanConvertEnumFuncToInt32Func()
  System.Boolean CheckCanConvertEnumFuncToInt32Func()
  Google.Protobuf.Reflection.ReflectionUtil.SampleEnum SampleEnumMethod()
END_CLASS

CLASS: Google.Protobuf.Reflection.RepeatedFieldAccessor
TYPE:  class
TOKEN: 0x2000121
EXTENDS: FieldAccessorBase
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor)
  System.Void Clear(Google.Protobuf.IMessage message)
  System.Boolean HasValue(Google.Protobuf.IMessage message)
  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.ServiceDescriptor
TYPE:  class
TOKEN: 0x2000122
EXTENDS: DescriptorBase
FIELDS:
  private   readonly Google.Protobuf.Reflection.ServiceDescriptorProtoproto  // 0x28
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor>methods  // 0x30
METHODS:
  System.Void .ctor(Google.Protobuf.Reflection.ServiceDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, System.Int32 index)
  System.String get_Name()
  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
  Google.Protobuf.Reflection.ServiceDescriptorProto get_Proto()
  Google.Protobuf.Reflection.ServiceDescriptorProto ToProto()
  System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor> get_Methods()
  Google.Protobuf.Reflection.MethodDescriptor FindMethodByName(System.String name)
  Google.Protobuf.Reflection.CustomOptions get_CustomOptions()
  Google.Protobuf.Reflection.ServiceOptions GetOptions()
  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,T> extension)
  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,T> extension)
  System.Void CrossLink()
END_CLASS

CLASS: Google.Protobuf.Reflection.SingleFieldAccessor
TYPE:  class
TOKEN: 0x2000124
EXTENDS: FieldAccessorBase
FIELDS:
  private   readonly System.Action<Google.Protobuf.IMessage,System.Object>setValueDelegate  // 0x20
  private   readonly System.Action<Google.Protobuf.IMessage>clearDelegate  // 0x28
  private   readonly System.Func<Google.Protobuf.IMessage,System.Boolean>hasDelegate  // 0x30
METHODS:
  System.Void .ctor(System.Type messageType, System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor)
  System.Object GetDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor)
  System.Void Clear(Google.Protobuf.IMessage message)
  System.Boolean HasValue(Google.Protobuf.IMessage message)
  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.TypeRegistry
TYPE:  class
TOKEN: 0x2000129
FIELDS:
  private   static readonly Google.Protobuf.Reflection.TypeRegistry<Empty>k__BackingField  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor>fullNameToMessageMap  // 0x10
METHODS:
  Google.Protobuf.Reflection.TypeRegistry get_Empty()
  System.Void .ctor(System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap)
  Google.Protobuf.Reflection.MessageDescriptor Find(System.String fullName)
  Google.Protobuf.Reflection.TypeRegistry FromFiles(Google.Protobuf.Reflection.FileDescriptor[] fileDescriptors)
  Google.Protobuf.Reflection.TypeRegistry FromFiles(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> fileDescriptors)
  Google.Protobuf.Reflection.TypeRegistry FromMessages(Google.Protobuf.Reflection.MessageDescriptor[] messageDescriptors)
  Google.Protobuf.Reflection.TypeRegistry FromMessages(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.MessageDescriptor> messageDescriptors)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.AnyReflection
TYPE:  class
TOKEN: 0x2000060
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Any
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    TypeUrlFieldNumber  // 0x0
  private           System.String                   typeUrl_  // 0x18
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           Google.Protobuf.ByteString      value_  // 0x20
  private   static  System.String                   DefaultPrefix  // 0x0
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Any other)
  Google.Protobuf.WellKnownTypes.Any Clone()
  System.String get_TypeUrl()
  System.Void set_TypeUrl(System.String value)
  Google.Protobuf.ByteString get_Value()
  System.Void set_Value(Google.Protobuf.ByteString value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Any other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Any other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.String GetTypeUrl(Google.Protobuf.Reflection.MessageDescriptor descriptor, System.String prefix)
  System.String GetTypeName(System.String typeUrl)
  System.Boolean Is(Google.Protobuf.Reflection.MessageDescriptor descriptor)
  T Unpack()
  System.Boolean TryUnpack(T& result)
  Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message)
  Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message, System.String typeUrlPrefix)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.ApiReflection
TYPE:  class
TOKEN: 0x2000063
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Api
TYPE:  class
TOKEN: 0x2000064
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    MethodsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Method>_repeated_methods_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method>methods_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x28
  public    static  System.Int32                    VersionFieldNumber  // 0x0
  private           System.String                   version_  // 0x30
  public    static  System.Int32                    SourceContextFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.SourceContextsourceContext_  // 0x38
  public    static  System.Int32                    MixinsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Mixin>_repeated_mixins_codec  // 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin>mixins_  // 0x40
  public    static  System.Int32                    SyntaxFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.Syntaxsyntax_  // 0x48
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Api other)
  Google.Protobuf.WellKnownTypes.Api Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method> get_Methods()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options()
  System.String get_Version()
  System.Void set_Version(System.String value)
  Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext()
  System.Void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value)
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin> get_Mixins()
  Google.Protobuf.WellKnownTypes.Syntax get_Syntax()
  System.Void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Api other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Api other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Method
TYPE:  class
TOKEN: 0x2000066
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    RequestTypeUrlFieldNumber  // 0x0
  private           System.String                   requestTypeUrl_  // 0x20
  public    static  System.Int32                    RequestStreamingFieldNumber  // 0x0
  private           System.Boolean                  requestStreaming_  // 0x28
  public    static  System.Int32                    ResponseTypeUrlFieldNumber  // 0x0
  private           System.String                   responseTypeUrl_  // 0x30
  public    static  System.Int32                    ResponseStreamingFieldNumber  // 0x0
  private           System.Boolean                  responseStreaming_  // 0x38
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x40
  public    static  System.Int32                    SyntaxFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.Syntaxsyntax_  // 0x48
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Method other)
  Google.Protobuf.WellKnownTypes.Method Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.String get_RequestTypeUrl()
  System.Void set_RequestTypeUrl(System.String value)
  System.Boolean get_RequestStreaming()
  System.Void set_RequestStreaming(System.Boolean value)
  System.String get_ResponseTypeUrl()
  System.Void set_ResponseTypeUrl(System.String value)
  System.Boolean get_ResponseStreaming()
  System.Void set_ResponseStreaming(System.Boolean value)
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options()
  Google.Protobuf.WellKnownTypes.Syntax get_Syntax()
  System.Void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Method other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Method other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Mixin
TYPE:  class
TOKEN: 0x2000068
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    RootFieldNumber  // 0x0
  private           System.String                   root_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Mixin other)
  Google.Protobuf.WellKnownTypes.Mixin Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.String get_Root()
  System.Void set_Root(System.String value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Mixin other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Mixin other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.DurationReflection
TYPE:  class
TOKEN: 0x200006A
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Duration
TYPE:  class
TOKEN: 0x200006B
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    SecondsFieldNumber  // 0x0
  private           System.Int64                    seconds_  // 0x18
  public    static  System.Int32                    NanosFieldNumber  // 0x0
  private           System.Int32                    nanos_  // 0x20
  public    static  System.Int32                    NanosecondsPerSecond  // 0x0
  public    static  System.Int32                    NanosecondsPerTick  // 0x0
  public    static  System.Int64                    MaxSeconds  // 0x0
  public    static  System.Int64                    MinSeconds  // 0x0
  private   static  System.Int32                    MaxNanoseconds  // 0x0
  private   static  System.Int32                    MinNanoseconds  // 0x0
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Duration other)
  Google.Protobuf.WellKnownTypes.Duration Clone()
  System.Int64 get_Seconds()
  System.Void set_Seconds(System.Int64 value)
  System.Int32 get_Nanos()
  System.Void set_Nanos(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Duration other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Duration other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Boolean IsNormalized(System.Int64 seconds, System.Int32 nanoseconds)
  System.TimeSpan ToTimeSpan()
  Google.Protobuf.WellKnownTypes.Duration FromTimeSpan(System.TimeSpan timeSpan)
  Google.Protobuf.WellKnownTypes.Duration op_UnaryNegation(Google.Protobuf.WellKnownTypes.Duration value)
  Google.Protobuf.WellKnownTypes.Duration op_Addition(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs)
  Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs)
  Google.Protobuf.WellKnownTypes.Duration Normalize(System.Int64 seconds, System.Int32 nanoseconds)
  System.String ToJson(System.Int64 seconds, System.Int32 nanoseconds, System.Boolean diagnosticOnly)
  System.String ToDiagnosticString()
  System.Void AppendNanoseconds(System.Text.StringBuilder builder, System.Int32 nanos)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.EmptyReflection
TYPE:  class
TOKEN: 0x200006D
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Empty
TYPE:  class
TOKEN: 0x200006E
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Empty other)
  Google.Protobuf.WellKnownTypes.Empty Clone()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Empty other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Empty other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.FieldMaskReflection
TYPE:  class
TOKEN: 0x2000070
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.FieldMask
TYPE:  class
TOKEN: 0x2000071
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    PathsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_paths_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>paths_  // 0x18
  private   static  System.Char                     FIELD_PATH_SEPARATOR  // 0x0
  private   static  System.Char                     FIELD_SEPARATOR_REGEX  // 0x0
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.FieldMask other)
  Google.Protobuf.WellKnownTypes.FieldMask Clone()
  Google.Protobuf.Collections.RepeatedField<System.String> get_Paths()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.FieldMask other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.FieldMask other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.String ToJson(System.Collections.Generic.IList<System.String> paths, System.Boolean diagnosticOnly)
  System.String ToDiagnosticString()
  Google.Protobuf.WellKnownTypes.FieldMask FromString(System.String value)
  Google.Protobuf.WellKnownTypes.FieldMask FromString(System.String value)
  Google.Protobuf.WellKnownTypes.FieldMask FromStringEnumerable(System.Collections.Generic.IEnumerable<System.String> paths)
  Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers(System.Int32[] fieldNumbers)
  Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers(System.Collections.Generic.IEnumerable<System.Int32> fieldNumbers)
  System.Boolean IsPathValid(System.String input)
  System.Boolean IsValid(Google.Protobuf.WellKnownTypes.FieldMask fieldMask)
  System.Boolean IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, Google.Protobuf.WellKnownTypes.FieldMask fieldMask)
  System.Boolean IsValid(System.String path)
  System.Boolean IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, System.String path)
  Google.Protobuf.WellKnownTypes.FieldMask Normalize()
  Google.Protobuf.WellKnownTypes.FieldMask Union(Google.Protobuf.WellKnownTypes.FieldMask[] otherMasks)
  Google.Protobuf.WellKnownTypes.FieldMask Intersection(Google.Protobuf.WellKnownTypes.FieldMask additionalMask)
  System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options)
  System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.SourceContextReflection
TYPE:  class
TOKEN: 0x2000074
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.SourceContext
TYPE:  class
TOKEN: 0x2000075
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    FileNameFieldNumber  // 0x0
  private           System.String                   fileName_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.SourceContext other)
  Google.Protobuf.WellKnownTypes.SourceContext Clone()
  System.String get_FileName()
  System.Void set_FileName(System.String value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.SourceContext other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.SourceContext other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.StructReflection
TYPE:  class
TOKEN: 0x2000077
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.NullValue
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.NullValueNullValue  // 0x0
METHODS:
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Struct
TYPE:  class
TOKEN: 0x2000079
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    FieldsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.Collections.MapField.Codec<System.String,Google.Protobuf.WellKnownTypes.Value>_map_fields_codec  // 0x8
  private   readonly Google.Protobuf.Collections.MapField<System.String,Google.Protobuf.WellKnownTypes.Value>fields_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Struct other)
  Google.Protobuf.WellKnownTypes.Struct Clone()
  Google.Protobuf.Collections.MapField<System.String,Google.Protobuf.WellKnownTypes.Value> get_Fields()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Struct other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Struct other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Value
TYPE:  class
TOKEN: 0x200007B
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NullValueFieldNumber  // 0x0
  public    static  System.Int32                    NumberValueFieldNumber  // 0x0
  public    static  System.Int32                    StringValueFieldNumber  // 0x0
  public    static  System.Int32                    BoolValueFieldNumber  // 0x0
  public    static  System.Int32                    StructValueFieldNumber  // 0x0
  public    static  System.Int32                    ListValueFieldNumber  // 0x0
  private           System.Object                   kind_  // 0x18
  private           Google.Protobuf.WellKnownTypes.Value.KindOneofCasekindCase_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Value other)
  Google.Protobuf.WellKnownTypes.Value Clone()
  Google.Protobuf.WellKnownTypes.NullValue get_NullValue()
  System.Void set_NullValue(Google.Protobuf.WellKnownTypes.NullValue value)
  System.Double get_NumberValue()
  System.Void set_NumberValue(System.Double value)
  System.String get_StringValue()
  System.Void set_StringValue(System.String value)
  System.Boolean get_BoolValue()
  System.Void set_BoolValue(System.Boolean value)
  Google.Protobuf.WellKnownTypes.Struct get_StructValue()
  System.Void set_StructValue(Google.Protobuf.WellKnownTypes.Struct value)
  Google.Protobuf.WellKnownTypes.ListValue get_ListValue()
  System.Void set_ListValue(Google.Protobuf.WellKnownTypes.ListValue value)
  Google.Protobuf.WellKnownTypes.Value.KindOneofCase get_KindCase()
  System.Void ClearKind()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Value other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Value other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  Google.Protobuf.WellKnownTypes.Value ForString(System.String value)
  Google.Protobuf.WellKnownTypes.Value ForNumber(System.Double value)
  Google.Protobuf.WellKnownTypes.Value ForBool(System.Boolean value)
  Google.Protobuf.WellKnownTypes.Value ForNull()
  Google.Protobuf.WellKnownTypes.Value ForList(Google.Protobuf.WellKnownTypes.Value[] values)
  Google.Protobuf.WellKnownTypes.Value ForStruct(Google.Protobuf.WellKnownTypes.Struct value)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.ListValue
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValuesFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Value>_repeated_values_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value>values_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.ListValue other)
  Google.Protobuf.WellKnownTypes.ListValue Clone()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value> get_Values()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.ListValue other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.ListValue other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.TimeExtensions
TYPE:  class
TOKEN: 0x2000080
FIELDS:
METHODS:
  Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTime dateTime)
  Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTimeOffset dateTimeOffset)
  Google.Protobuf.WellKnownTypes.Duration ToDuration(System.TimeSpan timeSpan)
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.TimestampReflection
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Timestamp
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    SecondsFieldNumber  // 0x0
  private           System.Int64                    seconds_  // 0x18
  public    static  System.Int32                    NanosFieldNumber  // 0x0
  private           System.Int32                    nanos_  // 0x20
  private   static readonly System.DateTime                 UnixEpoch  // 0x8
  private   static  System.Int64                    BclSecondsAtUnixEpoch  // 0x0
  private   static  System.Int64                    UnixSecondsAtBclMaxValue  // 0x0
  private   static  System.Int64                    UnixSecondsAtBclMinValue  // 0x0
  private   static  System.Int32                    MaxNanos  // 0x0
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Timestamp other)
  Google.Protobuf.WellKnownTypes.Timestamp Clone()
  System.Int64 get_Seconds()
  System.Void set_Seconds(System.Int64 value)
  System.Int32 get_Nanos()
  System.Void set_Nanos(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Timestamp other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Timestamp other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Boolean IsNormalized(System.Int64 seconds, System.Int32 nanoseconds)
  Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Timestamp rhs)
  Google.Protobuf.WellKnownTypes.Timestamp op_Addition(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs)
  Google.Protobuf.WellKnownTypes.Timestamp op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs)
  System.DateTime ToDateTime()
  System.DateTimeOffset ToDateTimeOffset()
  Google.Protobuf.WellKnownTypes.Timestamp FromDateTime(System.DateTime dateTime)
  Google.Protobuf.WellKnownTypes.Timestamp FromDateTimeOffset(System.DateTimeOffset dateTimeOffset)
  Google.Protobuf.WellKnownTypes.Timestamp Normalize(System.Int64 seconds, System.Int32 nanoseconds)
  System.String ToJson(System.Int64 seconds, System.Int32 nanoseconds, System.Boolean diagnosticOnly)
  System.Int32 CompareTo(Google.Protobuf.WellKnownTypes.Timestamp other)
  System.Boolean op_LessThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  System.Boolean op_GreaterThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  System.Boolean op_LessThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  System.Boolean op_GreaterThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  System.Boolean op_Equality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  System.Boolean op_Inequality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  System.String ToDiagnosticString()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.TypeReflection
TYPE:  class
TOKEN: 0x2000084
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Syntax
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.SyntaxProto2  // 0x0
  public    static  Google.Protobuf.WellKnownTypes.SyntaxProto3  // 0x0
METHODS:
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Type
TYPE:  class
TOKEN: 0x2000086
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    FieldsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Field>_repeated_fields_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field>fields_  // 0x20
  public    static  System.Int32                    OneofsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_oneofs_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>oneofs_  // 0x28
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x30
  public    static  System.Int32                    SourceContextFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.SourceContextsourceContext_  // 0x38
  public    static  System.Int32                    SyntaxFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.Syntaxsyntax_  // 0x40
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Type other)
  Google.Protobuf.WellKnownTypes.Type Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field> get_Fields()
  Google.Protobuf.Collections.RepeatedField<System.String> get_Oneofs()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options()
  Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext()
  System.Void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value)
  Google.Protobuf.WellKnownTypes.Syntax get_Syntax()
  System.Void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Type other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Type other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Field
TYPE:  class
TOKEN: 0x2000088
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    KindFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.Field.Types.Kindkind_  // 0x18
  public    static  System.Int32                    CardinalityFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.Field.Types.Cardinalitycardinality_  // 0x1C
  public    static  System.Int32                    NumberFieldNumber  // 0x0
  private           System.Int32                    number_  // 0x20
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private           System.String                   name_  // 0x28
  public    static  System.Int32                    TypeUrlFieldNumber  // 0x0
  private           System.String                   typeUrl_  // 0x30
  public    static  System.Int32                    OneofIndexFieldNumber  // 0x0
  private           System.Int32                    oneofIndex_  // 0x38
  public    static  System.Int32                    PackedFieldNumber  // 0x0
  private           System.Boolean                  packed_  // 0x3C
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x40
  public    static  System.Int32                    JsonNameFieldNumber  // 0x0
  private           System.String                   jsonName_  // 0x48
  public    static  System.Int32                    DefaultValueFieldNumber  // 0x0
  private           System.String                   defaultValue_  // 0x50
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Field other)
  Google.Protobuf.WellKnownTypes.Field Clone()
  Google.Protobuf.WellKnownTypes.Field.Types.Kind get_Kind()
  System.Void set_Kind(Google.Protobuf.WellKnownTypes.Field.Types.Kind value)
  Google.Protobuf.WellKnownTypes.Field.Types.Cardinality get_Cardinality()
  System.Void set_Cardinality(Google.Protobuf.WellKnownTypes.Field.Types.Cardinality value)
  System.Int32 get_Number()
  System.Void set_Number(System.Int32 value)
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.String get_TypeUrl()
  System.Void set_TypeUrl(System.String value)
  System.Int32 get_OneofIndex()
  System.Void set_OneofIndex(System.Int32 value)
  System.Boolean get_Packed()
  System.Void set_Packed(System.Boolean value)
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options()
  System.String get_JsonName()
  System.Void set_JsonName(System.String value)
  System.String get_DefaultValue()
  System.Void set_DefaultValue(System.String value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Field other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Field other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Enum
TYPE:  class
TOKEN: 0x200008D
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    EnumvalueFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.EnumValue>_repeated_enumvalue_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue>enumvalue_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x28
  public    static  System.Int32                    SourceContextFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.SourceContextsourceContext_  // 0x30
  public    static  System.Int32                    SyntaxFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.Syntaxsyntax_  // 0x38
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Enum other)
  Google.Protobuf.WellKnownTypes.Enum Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue> get_Enumvalue()
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options()
  Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext()
  System.Void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value)
  Google.Protobuf.WellKnownTypes.Syntax get_Syntax()
  System.Void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Enum other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Enum other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.EnumValue
TYPE:  class
TOKEN: 0x200008F
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    NumberFieldNumber  // 0x0
  private           System.Int32                    number_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x28
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.EnumValue other)
  Google.Protobuf.WellKnownTypes.EnumValue Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Int32 get_Number()
  System.Void set_Number(System.Int32 value)
  Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.EnumValue other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.EnumValue other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Option
TYPE:  class
TOKEN: 0x2000091
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // 0x0
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           Google.Protobuf.WellKnownTypes.Anyvalue_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Option other)
  Google.Protobuf.WellKnownTypes.Option Clone()
  System.String get_Name()
  System.Void set_Name(System.String value)
  Google.Protobuf.WellKnownTypes.Any get_Value()
  System.Void set_Value(Google.Protobuf.WellKnownTypes.Any value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Option other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Option other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.WrappersReflection
TYPE:  class
TOKEN: 0x2000093
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
  private   static  System.Int32                    WrapperValueFieldNumber  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.DoubleValue
TYPE:  class
TOKEN: 0x2000094
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           System.Double                   value_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.DoubleValue other)
  Google.Protobuf.WellKnownTypes.DoubleValue Clone()
  System.Double get_Value()
  System.Void set_Value(System.Double value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.DoubleValue other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.DoubleValue other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.FloatValue
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           System.Single                   value_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.FloatValue other)
  Google.Protobuf.WellKnownTypes.FloatValue Clone()
  System.Single get_Value()
  System.Void set_Value(System.Single value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.FloatValue other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.FloatValue other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Int64Value
TYPE:  class
TOKEN: 0x2000098
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           System.Int64                    value_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Int64Value other)
  Google.Protobuf.WellKnownTypes.Int64Value Clone()
  System.Int64 get_Value()
  System.Void set_Value(System.Int64 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Int64Value other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Int64Value other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.UInt64Value
TYPE:  class
TOKEN: 0x200009A
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           System.UInt64                   value_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.UInt64Value other)
  Google.Protobuf.WellKnownTypes.UInt64Value Clone()
  System.UInt64 get_Value()
  System.Void set_Value(System.UInt64 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.UInt64Value other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.UInt64Value other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Int32Value
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           System.Int32                    value_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.Int32Value other)
  Google.Protobuf.WellKnownTypes.Int32Value Clone()
  System.Int32 get_Value()
  System.Void set_Value(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Int32Value other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Int32Value other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.UInt32Value
TYPE:  class
TOKEN: 0x200009E
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           System.UInt32                   value_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.UInt32Value other)
  Google.Protobuf.WellKnownTypes.UInt32Value Clone()
  System.UInt32 get_Value()
  System.Void set_Value(System.UInt32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.UInt32Value other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.UInt32Value other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.BoolValue
TYPE:  class
TOKEN: 0x20000A0
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           System.Boolean                  value_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.BoolValue other)
  Google.Protobuf.WellKnownTypes.BoolValue Clone()
  System.Boolean get_Value()
  System.Void set_Value(System.Boolean value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.BoolValue other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.BoolValue other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.StringValue
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           System.String                   value_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.StringValue other)
  Google.Protobuf.WellKnownTypes.StringValue Clone()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.StringValue other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.StringValue other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.BytesValue
TYPE:  class
TOKEN: 0x20000A4
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // 0x0
  private           Google.Protobuf.ByteString      value_  // 0x18
METHODS:
  Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Google.Protobuf.WellKnownTypes.BytesValue other)
  Google.Protobuf.WellKnownTypes.BytesValue Clone()
  Google.Protobuf.ByteString get_Value()
  System.Void set_Value(Google.Protobuf.ByteString value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Google.Protobuf.WellKnownTypes.BytesValue other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.BytesValue other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
  private   readonly System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes<MemberTypes>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes memberTypes)
  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes get_MemberTypes()
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNone  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicParameterlessConstructor  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicConstructors  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicConstructors  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicMethods  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicMethods  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicFields  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicFields  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicNestedTypes  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicNestedTypes  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicProperties  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicProperties  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicEvents  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicEvents  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesInterfaces  // 0x0
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesAll  // 0x0
METHODS:
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <Message>k__BackingField  // 0x10
  private           System.String                   <Url>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.String message)
  System.String get_Message()
  System.String get_Url()
  System.Void set_Url(System.String value)
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessageAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <Category>k__BackingField  // 0x10
  private   readonly System.String                   <CheckId>k__BackingField  // 0x18
  private           System.String                   <Scope>k__BackingField  // 0x20
  private           System.String                   <Target>k__BackingField  // 0x28
  private           System.String                   <MessageId>k__BackingField  // 0x30
  private           System.String                   <Justification>k__BackingField  // 0x38
METHODS:
  System.Void .ctor(System.String category, System.String checkId)
  System.String get_Category()
  System.String get_CheckId()
  System.String get_Scope()
  System.Void set_Scope(System.String value)
  System.String get_Target()
  System.Void set_Target(System.String value)
  System.String get_MessageId()
  System.Void set_MessageId(System.String value)
  System.String get_Justification()
  System.Void set_Justification(System.String value)
END_CLASS

